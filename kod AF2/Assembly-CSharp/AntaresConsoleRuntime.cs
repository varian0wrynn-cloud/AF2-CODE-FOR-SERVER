using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000035 RID: 53
public class AntaresConsoleRuntime : MonoBehaviour
{
	// Token: 0x06000BC6 RID: 3014 RVA: 0x00075DD0 File Offset: 0x00073FD0
	private void IKGFNDCCDKP(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("SUNSHINE_TWO_CASCADES", string.Format("", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00075E2A File Offset: 0x0007402A
	private void CBPPOJCGFKH()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00075E48 File Offset: 0x00074048
	private void AJLEAKOMHJG()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(15, this.position, new GUI.WindowFunction(this.FPEABNOMGHE), "{not_found}");
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00075E7C File Offset: 0x0007407C
	private void DLMLNDNPKFD(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("wpn_add/base/dropt", string.Format("rem", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void KIMKMJMMLLB()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00075EDD File Offset: 0x000740DD
	private void HKGCKLBHNPJ()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(99, this.position, new GUI.WindowFunction(this.KIKPAABHHLB), "IdleFly");
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00075F0F File Offset: 0x0007410F
	public void EFJDBBDMPMC()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00075F0F File Offset: 0x0007410F
	public void LHKGDKLABAA()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00075E2A File Offset: 0x0007402A
	private void KEBDEJIAODF()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00075F24 File Offset: 0x00074124
	private void PPPHDDKLLFO(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("ENABLE_EYE_ADAPTATION");
			return;
		}
		this.KAJAMNHKHLJ();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(156f, 760f, this.position.width - 1110f, this.position.height - 1059f), this.MMGJAONJIIN, new Rect(1998f, 170f, this.position.width - 771f, 1551f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(662.0) - DateTime.Now).TotalMilliseconds * 158.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1943.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1520f), (float)(1057.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1401f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("fwgt_big_w", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "_Saturation", keyValuePair.Value.EIKKFEGJIND().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.PAGNPBJPDLC().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.ScrollWheel)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PAGNPBJPDLC())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.FECFPIEGGCF(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.NJEPOHHONFK())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format(" ", keyValuePair3.Value.AFAFINBJFFC.Count), "FactoryTempTexture"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "sinscale";
						object[] array = new object[4];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[6] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[4] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						GUILayout.Label(string.Format(format, array), new GUILayoutOption[]
						{
							GUILayout.Width(1621f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(712.0) - DateTime.Now).TotalMilliseconds * 161.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1742.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(667f), (float)(168.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1312f));
						GUILayout.Label(string.Format("newtitul", keyValuePair3.Key, keyValuePair3.Value.HFNKPDECIEL()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(116f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array2 = new GUILayoutOption[6];
						array2[0] = GUILayout.Width(this.position.width - 841f);
						array2[1] = GUILayout.MinHeight(380f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array2);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "error.wav";
								object[] array3 = new object[4];
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array3[6] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array3[0] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								GUILayout.Label(string.Format(format2, array3), new GUILayoutOption[]
								{
									GUILayout.Width(264f)
								});
								GUILayout.TextArea(string.Format("UnityEngine.Color", keyValuePair3.Key, lnijihdbnfl.IKLEBMKBOAD()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 1324f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					GUILayout.Box("\n", new GUILayoutOption[]
					{
						GUILayout.Height(683f),
						GUILayout.ExpandWidth(true)
					});
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Layout && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00075E2A File Offset: 0x0007402A
	private void AJCHHNKFOHO()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x000767D4 File Offset: 0x000749D4
	private void IHFPDBIKOOG(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("CratePush");
			return;
		}
		this.JBGJGAGIKLH();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1960f, 1865f, this.position.width - 445f, this.position.height - 847f), this.MMGJAONJIIN, new Rect(528f, 92f, this.position.width - 285f, 1095f), true, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(632.0) - DateTime.Now).TotalMilliseconds * 158.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(497.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1264f), (float)(1795.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(411f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("private", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Close rod", keyValuePair.Value.HCDIIBHNJFJ().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.FGMMJKHLPKI().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.Repaint)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.FGMMJKHLPKI())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.ECNEHPHPICJ(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.EIKKFEGJIND())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("OnRodChangeClck 5", keyValuePair3.Value.AFAFINBJFFC.Count), "[ACTk] <b>[ ObscuredVector3 test ]</b>"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "Podsek action 2";
						object[] array = new object[3];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[3] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(1982f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(939.0) - DateTime.Now).TotalMilliseconds * 1408.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(510.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1494f), (float)(793.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(821f));
						GUILayout.Label(string.Format("GiantGrabIdle", keyValuePair3.Key, keyValuePair3.Value.DPELGGGOKDI()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1517f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = false;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[4];
						array3[0] = GUILayout.Width(this.position.width - 1422f);
						array3[1] = GUILayout.MinHeight(525f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "******* playMusicBase  LocNewLogic";
								object[] array4 = new object[8];
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[3] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[1];
								array5[1] = GUILayout.Width(1260f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("Bip", keyValuePair3.Key, lnijihdbnfl.JGJEDKEBCCB()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 73f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "Dealer Shuffle";
					GUILayoutOption[] array6 = new GUILayoutOption[]
					{
						GUILayout.Height(803f)
					};
					array6[0] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.KeyDown && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00077084 File Offset: 0x00075284
	private void DCHAPIHINBJ()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(40, this.position, new GUI.WindowFunction(this.LGACKFFLONK), "Index");
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x000770B8 File Offset: 0x000752B8
	private void KODBIBCANAA(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("bag", string.Format("_Intensity", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00077114 File Offset: 0x00075314
	private void HNCBEGJPDEC(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("human_move_2.wav");
			return;
		}
		this.LHMIJCCMMLK();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1464f, 1553f, this.position.width - 1859f, this.position.height - 1152f), this.MMGJAONJIIN, new Rect(846f, 87f, this.position.width - 1007f, 196f), true, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1161.0) - DateTime.Now).TotalMilliseconds * 486.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(809.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1567f), (float)(1784.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(496f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("Lash", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "knopje.wav", keyValuePair.Value.INAMCEEKJPF().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.KeyUp)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.FGMMJKHLPKI())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.MOOFAKMJDHN(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.JFHJFGAKEFL())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("IceHockey Goalie Save 2", keyValuePair3.Value.AFAFINBJFFC.Count), "Loser"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "Inventory manager is init";
						object[] array = new object[6];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[2] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(1799f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1976.0) - DateTime.Now).TotalMilliseconds * 1916.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(631.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1672f), (float)(42.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1206f));
						GUILayout.Label(string.Format("_FogDensity", keyValuePair3.Key, keyValuePair3.Value.PJAOCKDICMD()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1125f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[3];
						array3[1] = GUILayout.Width(this.position.width - 443f);
						array3[0] = GUILayout.MinHeight(1522f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = " **** Error=";
								object[] array4 = new object[3];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[8] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[1];
								array5[1] = GUILayout.Width(871f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("RemoveFinger index out of bounds.", keyValuePair3.Key, lnijihdbnfl.IAMHKBIAHIF()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 1060f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "</color></i>";
					GUILayoutOption[] array6 = new GUILayoutOption[7];
					array6[0] = GUILayout.Height(625f);
					array6[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.KeyDown && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void LLLBNNNNFPJ()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x000779C4 File Offset: 0x00075BC4
	private void EAOOIFBELKG()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(94, this.position, new GUI.WindowFunction(this.AOECONMMJCJ), "_LoopCount");
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x000779F6 File Offset: 0x00075BF6
	public void PLBDELOIINH()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.HFMEFMKLNLC));
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void ACJNCDAHJDE()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00077A0C File Offset: 0x00075C0C
	private void ECNHKNNAJED(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("_LerpRgbTex", string.Format("MotorbikeBackwardSitting", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00075F0F File Offset: 0x0007410F
	public void ECMAANIDEBA()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00077A66 File Offset: 0x00075C66
	private void GGGKKEAABKK()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00075F0F File Offset: 0x0007410F
	public void IIHNDJOIMAH()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00077A84 File Offset: 0x00075C84
	public void KFOMHKMPPAK()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.OFOPLILMAOE));
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00077A98 File Offset: 0x00075C98
	private void MBIMPBEDDIK(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("baseQuality", string.Format("GiantGrabThrow", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00077AF4 File Offset: 0x00075CF4
	private void HFMEFMKLNLC(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("", string.Format("bool: ", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void MOLJHEHAMPH()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00077B4E File Offset: 0x00075D4E
	private void OAEGBFGICNH()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-175, this.position, new GUI.WindowFunction(this.KGCHGPIKDLI), "MotorbikeAirWalk");
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00077B80 File Offset: 0x00075D80
	private void ODNNKHDAFNE(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("RollerBladeStand", string.Format("RollerBladeStop", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00077BDC File Offset: 0x00075DDC
	private void LHMIJCCMMLK()
	{
		GUI.Box(new Rect(1901f, 867f, this.position.width, 1710f), "-S");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(995f);
			if (GUILayout.Button(new GUIContent("_DebugWidth", "ComeHere"), new GUILayoutOption[]
			{
				GUILayout.Width(1821f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("_TempRT", "");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(1187f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("lineDistance=", " This is not possible to be called for standalone input. Please check your platform and code where this is called");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(946f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(652f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "_Newitem.wav", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00077DB4 File Offset: 0x00075FB4
	private void MMHJDICCMKH(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("Ankle");
			return;
		}
		this.MBIBEEBIFEB();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(147f, 1168f, this.position.width - 28f, this.position.height - 290f), this.MMGJAONJIIN, new Rect(1335f, 1334f, this.position.width - 1753f, 1046f), true, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1795.0) - DateTime.Now).TotalMilliseconds * 1914.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1818.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1401f), (float)(1707.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1615f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("◍◍◍", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Vector2: ", keyValuePair.Value.FAAAIJNCKHB().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.KeyDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PJGJPHLBIPM())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.GGMMPOFOBOG(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.NJEPOHHONFK())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("SUNSHINE_FILTER_PCF_4x4", keyValuePair3.Value.AFAFINBJFFC.Count), "KatanaUpperBlock"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "FrontKick";
						object[] array = new object[0];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[5] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(1187f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(149.0) - DateTime.Now).TotalMilliseconds * 1144.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(479.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1120f), (float)(1255.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(719f));
						GUILayout.Label(string.Format("OfficeSittingMouseMovement", keyValuePair3.Key, keyValuePair3.Value.IAMHKBIAHIF()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(79f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[7];
						array3[1] = GUILayout.Width(this.position.width - 1687f);
						array3[0] = GUILayout.MinHeight(1017f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "_SearchTex";
								object[] array4 = new object[3];
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[6] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[2] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								GUILayout.Label(string.Format(format2, array4), new GUILayoutOption[]
								{
									GUILayout.Width(1630f)
								});
								GUILayout.TextArea(string.Format("RussianDance", keyValuePair3.Key, lnijihdbnfl.OEEDEGPBIBO()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 757f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "0";
					GUILayoutOption[] array5 = new GUILayoutOption[7];
					array5[1] = GUILayout.Height(641f);
					array5[0] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseDrag && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00078664 File Offset: 0x00076864
	private void LGKEFLBKIGN()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-95, this.position, new GUI.WindowFunction(this.KGCHGPIKDLI), "_parent");
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void NOLGMGLINIJ()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00078696 File Offset: 0x00076896
	public void JLKBMEBFHBI()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.BEDDOBPDDNP));
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x000786A9 File Offset: 0x000768A9
	public void DOHJPDNKALP()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.PPPGKPLEPDE));
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x000786BC File Offset: 0x000768BC
	private void AOECONMMJCJ(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("</color>");
			return;
		}
		this.GAEJCHOJLFI();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1076f, 513f, this.position.width - 592f, this.position.height - 1500f), this.MMGJAONJIIN, new Rect(1740f, 1861f, this.position.width - 1089f, 440f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1500.0) - DateTime.Now).TotalMilliseconds * 858.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(886.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1789f), (float)(474.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(9f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "FlyDown", keyValuePair.Value.HCDIIBHNJFJ().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.FAAAIJNCKHB().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.Repaint)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PJGJPHLBIPM())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.OAFOAKJOJAI(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.HCDIIBHNJFJ())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("choldposy", keyValuePair3.Value.AFAFINBJFFC.Count), "Horizontal"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "";
						object[] array = new object[6];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(382f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1207.0) - DateTime.Now).TotalMilliseconds * 1767.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(731.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1065f), (float)(1502.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(300f));
						GUILayout.Label(string.Format("Running Slide", keyValuePair3.Key, keyValuePair3.Value.ECAPFKOOLHO()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1538f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[4];
						array3[0] = GUILayout.Width(this.position.width - 1146f);
						array3[1] = GUILayout.MinHeight(78f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "TYPES";
								object[] array4 = new object[6];
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[3] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[5] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								GUILayout.Label(string.Format(format2, array4), new GUILayoutOption[]
								{
									GUILayout.Width(1908f)
								});
								GUILayout.TextArea(string.Format("name", keyValuePair3.Key, lnijihdbnfl.OEEDEGPBIBO()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 291f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					GUILayout.Box("' is not a valid integer", new GUILayoutOption[]
					{
						GUILayout.Height(940f),
						GUILayout.ExpandWidth(true)
					});
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.KeyUp && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void KLKCKFDGMJN()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00078F6C File Offset: 0x0007716C
	private void KJBKAALCCMH(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("ArmFlex", string.Format("{x}", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x00078FC8 File Offset: 0x000771C8
	private void ALMJDEDDCCE(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("");
			return;
		}
		this.CIFNAKCJLOL();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(561f, 1207f, this.position.width - 377f, this.position.height - 850f), this.MMGJAONJIIN, new Rect(512f, 482f, this.position.width - 523f, 556f), false, false);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1551.0) - DateTime.Now).TotalMilliseconds * 198.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(518.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(992f), (float)(732.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1015f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("_BlurredColor", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "RollerBladeCrossoverLeft", keyValuePair.Value.FOBEFJILOEG().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.JFHJFGAKEFL().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseMove)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.FGMMJKHLPKI())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.MEIGJBFKHIK(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.INAMCEEKJPF())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("StaffStand", keyValuePair3.Value.AFAFINBJFFC.Count), "MotorbikeSpecialFlip"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "{0}.{1}.{2}.{3}";
						object[] array = new object[8];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(256f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1253.0) - DateTime.Now).TotalMilliseconds * 1866.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(740.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1413f), (float)(49.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1002f));
						GUILayout.Label(string.Format("_AllowBackwardsRays", keyValuePair3.Key, keyValuePair3.Value.OEEDEGPBIBO()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1083f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[6];
						array3[1] = GUILayout.Width(this.position.width - 146f);
						array3[0] = GUILayout.MinHeight(459f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "Steam Overlay has been closed";
								object[] array4 = new object[]
								{
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours,
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes,
									null,
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds
								};
								array4[2] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[0];
								array5[0] = GUILayout.Width(703f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("auc_resallcst", keyValuePair3.Key, lnijihdbnfl.PJAOCKDICMD()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 120f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "setCurrentProfil sm=";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Height(1749f);
					array6[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseMove && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00075E2A File Offset: 0x0007402A
	private void OFPGMNGFLNH()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x000798B4 File Offset: 0x00077AB4
	private void LGACKFFLONK(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("");
			return;
		}
		this.GAEJCHOJLFI();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1349f, 369f, this.position.width - 1932f, this.position.height - 150f), this.MMGJAONJIIN, new Rect(242f, 1881f, this.position.width - 525f, 690f), true, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(855.0) - DateTime.Now).TotalMilliseconds * 1340.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(186.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1160f), (float)(89.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(3f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("______________________________", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "_MinVelocity", keyValuePair.Value.INAMCEEKJPF().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.MMDMIMBJLOC().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseUp)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.FOBEFJILOEG())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.FECFPIEGGCF(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.MNMOLHPIDDE())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format(" ", keyValuePair3.Value.AFAFINBJFFC.Count), "\n"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "SUNSHINE_FILTER_PCF_4x4";
						object[] array = new object[5];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[5] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[1] = GUILayout.Width(862f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(541.0) - DateTime.Now).TotalMilliseconds * 1791.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1366.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(202f), (float)(1017.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(82f));
						GUILayout.Label(string.Format("UIPCam_size", keyValuePair3.Key, keyValuePair3.Value.AMLGODILBAA), Array.Empty<GUILayoutOption>());
						GUILayout.Space(294f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = false;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[6];
						array3[0] = GUILayout.Width(this.position.width - 1004f);
						array3[0] = GUILayout.MinHeight(498f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "isWoman";
								object[] array4 = new object[]
								{
									null,
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours
								};
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[7] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[7] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[1];
								array5[1] = GUILayout.Width(1335f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("", keyValuePair3.Key, lnijihdbnfl.GKLFEHKBEBN()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 415f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "u_email";
					GUILayoutOption[] array6 = new GUILayoutOption[3];
					array6[0] = GUILayout.Height(1982f);
					array6[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseUp && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x0007A164 File Offset: 0x00078364
	private void DOOJEECCJEJ()
	{
		GUI.Box(new Rect(1277f, 1912f, this.position.width, 581f), "TAA History");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(993f);
			if (GUILayout.Button(new GUIContent("ObscuredPrefs", "Ок"), new GUILayoutOption[]
			{
				GUILayout.Width(1758f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("MotorbikeLassoFwd", "Assets/Weapons/wbaseJaket.unity3d");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(427f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("1 Hand Sword Charge Up", "firsStartMovePanel");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(824f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1506f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "<color=\"", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0007A33C File Offset: 0x0007853C
	private void PPPGKPLEPDE(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("|", string.Format(" ", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0007A398 File Offset: 0x00078598
	private void OMAIFKLFFAM()
	{
		GUI.Box(new Rect(59f, 368f, this.position.width, 1521f), "invn_rec18");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1349f);
			if (GUILayout.Button(new GUIContent("************ isChangedRod *********", "drag_onmouseup.wav"), new GUILayoutOption[]
			{
				GUILayout.Width(999f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("", "Leg");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1758f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("CrouchWalkBackward", "wpn_rod4");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1874f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1501f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "{0} {1}.{2} ({3:f2}, {4:f2})  {5}", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0007A570 File Offset: 0x00078770
	private void FPEABNOMGHE(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("/");
			return;
		}
		this.IMOMIKFEGEE();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1122f, 1392f, this.position.width - 1282f, this.position.height - 1493f), this.MMGJAONJIIN, new Rect(1903f, 1591f, this.position.width - 507f, 1120f), true, false);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(584.0) - DateTime.Now).TotalMilliseconds * 1494.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(728.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1491f), (float)(445.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1461f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("sunshine_ShadowFadeParams", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Get post", keyValuePair.Value.BKGDJPABCDH().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PAGNPBJPDLC())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.BCOKHNCIMHE(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.FOBEFJILOEG())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("#400000", keyValuePair3.Value.AFAFINBJFFC.Count), "Giant2HandSlamSwing"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "wpn_add/addoptions/klevprop";
						object[] array = new object[2];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[7] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[2] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						GUILayout.Label(string.Format(format, array), new GUILayoutOption[]
						{
							GUILayout.Width(61f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1712.0) - DateTime.Now).TotalMilliseconds * 1049.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(137.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(579f), (float)(265.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(20f));
						GUILayout.Label(string.Format("\n", keyValuePair3.Key, keyValuePair3.Value.DPELGGGOKDI()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(225f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[0] = GUILayout.Width(this.position.width - 570f);
						array2[1] = GUILayout.MinHeight(882f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array2);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "\n";
								object[] array3 = new object[]
								{
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours
								};
								array3[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array3[3] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text = string.Format(format2, array3);
								GUILayoutOption[] array4 = new GUILayoutOption[1];
								array4[1] = GUILayout.Width(428f);
								GUILayout.Label(text, array4);
								GUILayout.TextArea(string.Format("Cloth_09.wav", keyValuePair3.Key, lnijihdbnfl.GKLFEHKBEBN()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 860f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "wpn_line1";
					GUILayoutOption[] array5 = new GUILayoutOption[]
					{
						null,
						GUILayout.Height(478f)
					};
					array5[0] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Repaint && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x0007AE20 File Offset: 0x00079020
	private void LFCIINOHNLB()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-55, this.position, new GUI.WindowFunction(this.MMHJDICCMKH), "name");
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0007AE54 File Offset: 0x00079054
	private void JHKJAEADPLI(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("IdleFly", string.Format("?", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0007AEB0 File Offset: 0x000790B0
	private void LLBMJDLFKDH(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("/", string.Format("KatanaReadyHigh", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0007AF0C File Offset: 0x0007910C
	private void DAEHOFCDDFN(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("Flames");
			return;
		}
		this.DOOJEECCJEJ();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(430f, 179f, this.position.width - 1872f, this.position.height - 710f), this.MMGJAONJIIN, new Rect(1340f, 214f, this.position.width - 360f, 282f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(598.0) - DateTime.Now).TotalMilliseconds * 1048.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(992.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1664f), (float)(1174.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1234f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Mouse Y", keyValuePair.Value.HCDIIBHNJFJ().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.MMDMIMBJLOC().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.KeyDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.BKGDJPABCDH())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.BCOKHNCIMHE(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.EIKKFEGJIND())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("_NoiseTex", keyValuePair3.Value.AFAFINBJFFC.Count), "_Offsets"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "KatanaReady";
						object[] array = new object[8];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[3] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[2] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						GUILayout.Label(string.Format(format, array), new GUILayoutOption[]
						{
							GUILayout.Width(1763f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1510.0) - DateTime.Now).TotalMilliseconds * 1390.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(652.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(148f), (float)(1118.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1244f));
						GUILayout.Label(string.Format("vSyncCount", keyValuePair3.Key, keyValuePair3.Value.PJAOCKDICMD()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1142f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array2 = new GUILayoutOption[6];
						array2[1] = GUILayout.Width(this.position.width - 1935f);
						array2[1] = GUILayout.MinHeight(289f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array2);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "Poplavok";
								object[] array3 = new object[]
								{
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours
								};
								array3[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array3[7] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array3[6] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text = string.Format(format2, array3);
								GUILayoutOption[] array4 = new GUILayoutOption[0];
								array4[0] = GUILayout.Width(1628f);
								GUILayout.Label(text, array4);
								GUILayout.TextArea(string.Format("wpn_eat1", keyValuePair3.Key, lnijihdbnfl.KLOMIMGCKKI()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 590f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "_Offsets";
					GUILayoutOption[] array5 = new GUILayoutOption[8];
					array5[0] = GUILayout.Height(808f);
					array5[0] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Repaint && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void FKBJBDCBPKM()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0007B7BC File Offset: 0x000799BC
	private void KLGEAHDGKDA(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("UnityEngine.Vector2", string.Format("IdleStandingJump", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0007B816 File Offset: 0x00079A16
	public void FFIGGPHAIBP()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.CPBJHEEMDAP));
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x0007B82C File Offset: 0x00079A2C
	private void KNPNINKFOLG(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("BipedReferences contains one or more missing Transforms.", string.Format("_DistortParams", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00075E2A File Offset: 0x0007402A
	private void LMGBKHCHPHO()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00075F0F File Offset: 0x0007410F
	public void OFKOGOOAOPK()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0007B888 File Offset: 0x00079A88
	private void IGALAJGEAAC(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("FOG_OF_WAR_ON");
			return;
		}
		this.JAACIDBKELF();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1706f, 1232f, this.position.width - 1151f, this.position.height - 123f), this.MMGJAONJIIN, new Rect(907f, 283f, this.position.width - 1676f, 505f), true, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(908.0) - DateTime.Now).TotalMilliseconds * 1707.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(438.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1386f), (float)(470.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(382f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("OfficeSittingReadingCoffeeSip", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "WeaponRun", keyValuePair.Value.NJEPOHHONFK().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.BKGDJPABCDH().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseUp)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PAGNPBJPDLC())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.FAHFNELEDOC(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.FGMMJKHLPKI())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("Attempting to set limb orientation to Vector3.zero axis", keyValuePair3.Value.AFAFINBJFFC.Count), "BowFire"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = " +";
						object[] array = new object[1];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[5] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[7] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(1444f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1697.0) - DateTime.Now).TotalMilliseconds * 709.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1900.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(146f), (float)(1976.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1328f));
						GUILayout.Label(string.Format("WoodSaw", keyValuePair3.Key, keyValuePair3.Value.JGJEDKEBCCB()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1351f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[5];
						array3[1] = GUILayout.Width(this.position.width - 99f);
						array3[1] = GUILayout.MinHeight(645f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "\n";
								object[] array4 = new object[8];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[4] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[5] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								GUILayout.Label(string.Format(format2, array4), new GUILayoutOption[]
								{
									GUILayout.Width(6f)
								});
								GUILayout.TextArea(string.Format(" listed as it's child.", keyValuePair3.Key, lnijihdbnfl.KLOMIMGCKKI()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 189f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "WorkerHammer2";
					GUILayoutOption[] array5 = new GUILayoutOption[3];
					array5[1] = GUILayout.Height(1186f);
					array5[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Repaint && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x0007C138 File Offset: 0x0007A338
	private void KMKAJCNMCDM()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-33, this.position, new GUI.WindowFunction(this.MMHJDICCMKH), "isRodInWater");
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0007C16C File Offset: 0x0007A36C
	private void IMOMIKFEGEE()
	{
		GUI.Box(new Rect(445f, 1257f, this.position.width, 1038f), "17");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(737f);
			if (GUILayout.Button(new GUIContent("_BlurTex", "Water Refr Camera id"), new GUILayoutOption[]
			{
				GUILayout.Width(783f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("ProneIdle", "wpn_cat4");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1738f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("_MainTex", "BaseDataLoaderCoroutine");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1209f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1686f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "Podsek action 3", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0007C344 File Offset: 0x0007A544
	private void APGLHOOPHHL(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("_InternalLutTex", string.Format("360SpinDeath", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0007C39E File Offset: 0x0007A59E
	private void BKFLIDKPDDI()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(53, this.position, new GUI.WindowFunction(this.PPPHDDKLLFO), "SkateboardKickPush");
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void IIKEIPNNLCG()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
	private void GCGEADNFCPN()
	{
		GUI.Box(new Rect(1617f, 746f, this.position.width, 1369f), "Failed to load AssetBundle!");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1027f);
			GUIContent content = new GUIContent("This is a hidden [H hidden]hyperlink[-H].\nThis is a visible [FA U][H visible]hyperlink[-H][FA -U].", "_LumTex");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(75f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("IdleStand", "__MirrorReflection");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1574f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("MotorbikeSeatStandWheely", "error");
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(1052f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(808f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "WateringCanWatering", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0007C5A8 File Offset: 0x0007A7A8
	private void POFBKCFFJLB(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("Hidden/Amplify Color/MaskBlend");
			return;
		}
		this.OMAIFKLFFAM();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(184f, 1278f, this.position.width - 989f, this.position.height - 126f), this.MMGJAONJIIN, new Rect(790f, 849f, this.position.width - 1955f, 1202f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1687.0) - DateTime.Now).TotalMilliseconds * 69.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(604.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1300f), (float)(1732.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(806f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("Stand Up", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Horizontal", keyValuePair.Value.FGMMJKHLPKI().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.HCDIIBHNJFJ().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.Layout)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.HCDIIBHNJFJ())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.ECNEHPHPICJ(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.EIKKFEGJIND())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("https://www.youtube.com/watch?v=eP9-zycoHLk", keyValuePair3.Value.AFAFINBJFFC.Count), "Hit"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "V";
						object[] array = new object[8];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[3] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[0] = GUILayout.Width(697f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1122.0) - DateTime.Now).TotalMilliseconds * 524.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1139.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(200f), (float)(448.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1516f));
						GUILayout.Label(string.Format("cht_msg18", keyValuePair3.Key, keyValuePair3.Value.AMLGODILBAA), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1053f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = false;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[6];
						array3[0] = GUILayout.Width(this.position.width - 401f);
						array3[1] = GUILayout.MinHeight(1f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "#a0d0a0";
								object[] array4 = new object[0];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[3] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[0];
								array5[1] = GUILayout.Width(1520f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("ProneLocomotion", keyValuePair3.Key, lnijihdbnfl.HFNAEGDDEDG()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 1848f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "info";
					GUILayoutOption[] array6 = new GUILayoutOption[3];
					array6[0] = GUILayout.Height(527f);
					array6[0] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseDown && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0007CE58 File Offset: 0x0007B058
	private void PDEEOGAAMBB()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-15, this.position, new GUI.WindowFunction(this.KIKPAABHHLB), "wgt_kg");
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0007CE8A File Offset: 0x0007B08A
	public void GDIMBBBPIHI()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.MBIMPBEDDIK));
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00075E2A File Offset: 0x0007402A
	private void Update()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void IABPIBODNNG()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0007CE9D File Offset: 0x0007B09D
	private void NJPIOMLFAKH()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(198, this.position, new GUI.WindowFunction(this.IABECBEPKEA), "https://groups.google.com/forum/#!forum/final-ik");
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00075E2A File Offset: 0x0007402A
	private void AFHBOLFGJNE()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0007CECF File Offset: 0x0007B0CF
	public void FCCAIANLEFE()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.HNOIDILAPLD));
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x0007CEE4 File Offset: 0x0007B0E4
	private void JBGJGAGIKLH()
	{
		GUI.Box(new Rect(1922f, 431f, this.position.width, 35f), " is represented multiple times in the Bones.");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1412f);
			GUIContent content = new GUIContent("titul_change", "https://www.youtube.com/watch?v=r5jiZnsDH3M");
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(1891f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("MotorbikeIdle", "LDR");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1316f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("help", "Smoking2");
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(349f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(344f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "auc_resallcst", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void EHKCHPFDNCA()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void IJKMOJONNNH()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x0007D0BC File Offset: 0x0007B2BC
	private void IACKJNMGIDC()
	{
		GUI.Box(new Rect(1896f, 1817f, this.position.width, 1208f), "threshold");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(27f);
			GUIContent content = new GUIContent("{0} {1}.{2} ({3:f2}, {4:f2})  {5}", ":");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1727f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("Swim Dog Paddle", "_n");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1835f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("_AdaptTex", "BAG");
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[1] = GUILayout.Width(226f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1960f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "wpn_hook1", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00075E2A File Offset: 0x0007402A
	private void BOAJJAKEMLH()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void OGMALNDHBEE()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void EKLDFELNMFP()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0007D294 File Offset: 0x0007B494
	private void BBGAONKBIPJ()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-140, this.position, new GUI.WindowFunction(this.BJGMOBDMNEC), "_Texture");
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x0007D2C8 File Offset: 0x0007B4C8
	private void NLGCKJJGALE(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("Katana Ready", string.Format(" ♦ ", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void LLFANOGKPKM()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0007D322 File Offset: 0x0007B522
	public void NMGCNEELAFM()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.ODNNKHDAFNE));
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0007D335 File Offset: 0x0007B535
	public void LMEJKAEIDCO()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.KJBKAALCCMH));
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00077A66 File Offset: 0x00075C66
	private void PAKOHKKBKHD()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void DFLLLNDKNBB()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0007D348 File Offset: 0x0007B548
	public void Start()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.BKKGBCADBPL));
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0007D35C File Offset: 0x0007B55C
	private void LKOLLLGGKNM(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("RollerBladeStand", string.Format("ara_trail_mesh", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0007D3B6 File Offset: 0x0007B5B6
	public void PEKDKKHPINC()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.NLGCKJJGALE));
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0007D3CC File Offset: 0x0007B5CC
	private void JAACIDBKELF()
	{
		GUI.Box(new Rect(1852f, 1195f, this.position.width, 610f), "fishSPEED=");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1108f);
			if (GUILayout.Button(new GUIContent("Crouching", ""), new GUILayoutOption[]
			{
				GUILayout.Width(889f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			if (GUILayout.Button(new GUIContent("_Luminance", "Ready Crouch"), new GUILayoutOption[]
			{
				GUILayout.Width(625f)
			}))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			if (GUILayout.Button(new GUIContent("catid", "auc_wsbor"), new GUILayoutOption[]
			{
				GUILayout.Width(1052f)
			}))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(47f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, " %\n", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void LBABEDLHAIC()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0007D5A4 File Offset: 0x0007B7A4
	private void BEDDOBPDDNP(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("Crate Push", string.Format("_FinalReflectionTexture", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0007D600 File Offset: 0x0007B800
	private void BKKGBCADBPL(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("UNITY DEBUG", string.Format("{0} : {1}", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0007D65C File Offset: 0x0007B85C
	private void BJGMOBDMNEC(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("isMoving");
			return;
		}
		this.JAACIDBKELF();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(586f, 1643f, this.position.width - 1206f, this.position.height - 1868f), this.MMGJAONJIIN, new Rect(1347f, 1443f, this.position.width - 612f, 655f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1559.0) - DateTime.Now).TotalMilliseconds * 1471.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1658.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(166f), (float)(770.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1467f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("level", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "FOG_SCATTERING_ON", keyValuePair.Value.JFHJFGAKEFL().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.EIKKFEGJIND().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.KeyDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PJGJPHLBIPM())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.LCDODINBEMB(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.INAMCEEKJPF())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("_camouflage", keyValuePair3.Value.AFAFINBJFFC.Count), "Cheer Knees"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "_RefractionTex";
						object[] array = new object[]
						{
							null,
							keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours
						};
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[4] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[5] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(1702f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1650.0) - DateTime.Now).TotalMilliseconds * 942.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(87.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1510f), (float)(1235.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1813f));
						GUILayout.Label(string.Format("Katana", keyValuePair3.Key, keyValuePair3.Value.PJAOCKDICMD()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(314f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = false;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[5];
						array3[1] = GUILayout.Width(this.position.width - 7f);
						array3[0] = GUILayout.MinHeight(1604f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "2000";
								object[] array4 = new object[4];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[7] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[7] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[1];
								array5[1] = GUILayout.Width(1663f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format(" ?", keyValuePair3.Key, lnijihdbnfl.BHJANLCIDMP()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 1582f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "_SearchTex";
					GUILayoutOption[] array6 = new GUILayoutOption[6];
					array6[0] = GUILayout.Height(341f);
					array6[1] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseDrag && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0007DF0C File Offset: 0x0007C10C
	private void BIOKMDIGOIA()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(134, this.position, new GUI.WindowFunction(this.MMHJDICCMKH), "<color='");
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0007D3B6 File Offset: 0x0007B5B6
	public void GGBMJFNGHMC()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.NLGCKJJGALE));
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0007DF40 File Offset: 0x0007C140
	private void IABECBEPKEA(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("");
			return;
		}
		this.JAACIDBKELF();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(124f, 1721f, this.position.width - 390f, this.position.height - 1681f), this.MMGJAONJIIN, new Rect(1821f, 7f, this.position.width - 230f, 526f), true, false);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(518.0) - DateTime.Now).TotalMilliseconds * 1267.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(319.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(776f), (float)(1766.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(223f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("Giant", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "Pointing", keyValuePair.Value.JFHJFGAKEFL().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.MMDMIMBJLOC().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseMove)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.EIKKFEGJIND())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.FECFPIEGGCF(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.PJGJPHLBIPM())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("_FrustumCornersWS", keyValuePair3.Value.AFAFINBJFFC.Count), "_FgOverlap"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "_FogData2";
						object[] array = new object[8];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(851f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(147.0) - DateTime.Now).TotalMilliseconds * 1579.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(970.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1821f), (float)(253.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1650f));
						GUILayout.Label(string.Format("BlackSmithForge", keyValuePair3.Key, keyValuePair3.Value.IAMHKBIAHIF()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1782f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[5];
						array3[0] = GUILayout.Width(this.position.width - 1211f);
						array3[1] = GUILayout.MinHeight(301f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "SixStep";
								object[] array4 = new object[2];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[4] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[4] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[0];
								array5[0] = GUILayout.Width(873f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("Hidden/Post FX/FXAA", keyValuePair3.Key, lnijihdbnfl.DADEBMFMCHG()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 1693f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Height(394f);
					array6[1] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseDrag && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void PHIACAJNNIG()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void NJBEKBHCLIO()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0007E7F0 File Offset: 0x0007C9F0
	private void IFEDABFHICP()
	{
		GUI.Box(new Rect(1734f, 1278f, this.position.width, 1281f), "gi_uinf_1");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1827f);
			if (GUILayout.Button(new GUIContent("wgt_big.dat", "Horizontal"), new GUILayoutOption[]
			{
				GUILayout.Width(784f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("Bases/Base_1.unity3d", "<b>Obscured Cheating Detector</b>");
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(1011f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("lifeBar", "info");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(95f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(224f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "MotorbikeLassoFwd", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00077A66 File Offset: 0x00075C66
	private void IEOICHPKEMD()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void KHJJKPCKNKM()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0007E9C8 File Offset: 0x0007CBC8
	private void HEPAJOLJPFO(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("cht_msg18", string.Format("WandStand", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0007EA22 File Offset: 0x0007CC22
	private void KMLAENJBADF()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-117, this.position, new GUI.WindowFunction(this.BJGMOBDMNEC), " {0}");
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0007EA54 File Offset: 0x0007CC54
	private void OHAAJLEKPFP(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("#02C85F");
			return;
		}
		this.DOOJEECCJEJ();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(1707f, 129f, this.position.width - 1782f, this.position.height - 1885f), this.MMGJAONJIIN, new Rect(1529f, 1536f, this.position.width - 785f, 55f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1310.0) - DateTime.Now).TotalMilliseconds * 1062.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1262.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(697f), (float)(1833.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1058f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("LookAT Point", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "sunshine_ShadowCoordDepthStart", keyValuePair.Value.MMDMIMBJLOC().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.ScrollWheel)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.JFHJFGAKEFL())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.ECNEHPHPICJ(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.NJEPOHHONFK())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("Hidden/Post FX/Lut Generator", keyValuePair3.Value.AFAFINBJFFC.Count), "_SoftZDistance"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "citates/citate";
						object[] array = new object[6];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[4] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[3] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[1] = GUILayout.Width(1413f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(94.0) - DateTime.Now).TotalMilliseconds * 1547.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1753.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1920f), (float)(18.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1420f));
						GUILayout.Label(string.Format(" x", keyValuePair3.Key, keyValuePair3.Value.OEEDEGPBIBO()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1596f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[8];
						array3[1] = GUILayout.Width(this.position.width - 1713f);
						array3[1] = GUILayout.MinHeight(1401f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "_ChannelMixerBlue";
								object[] array4 = new object[1];
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[2] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[2] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								GUILayout.Label(string.Format(format2, array4), new GUILayoutOption[]
								{
									GUILayout.Width(574f)
								});
								GUILayout.TextArea(string.Format("IceHockeyGoalieReady", keyValuePair3.Key, lnijihdbnfl.IKLEBMKBOAD()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 1275f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "Only Hinge Rotation Limits should be used on 2D IK solvers.";
					GUILayoutOption[] array5 = new GUILayoutOption[5];
					array5[1] = GUILayout.Height(1878f);
					array5[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Repaint && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void EIDIHAJDMCI()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0007F304 File Offset: 0x0007D504
	private void GAEJCHOJLFI()
	{
		GUI.Box(new Rect(1940f, 1422f, this.position.width, 1263f), "FishModel");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(214f);
			if (GUILayout.Button(new GUIContent("DeadmanFloat", "string: "), new GUILayoutOption[]
			{
				GUILayout.Width(1025f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content = new GUIContent("Swim", "800000");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(1464f);
			if (GUILayout.Button(content, array))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("", "");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1365f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(984f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "_BlurRadius4", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0007F4DC File Offset: 0x0007D6DC
	private void LHHGOLKAKCI(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("(Org: ", string.Format("wpn_add/use_effect", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0007F538 File Offset: 0x0007D738
	private void LAMDGNKOBDF(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("info", string.Format("_WaterLevel", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0007F594 File Offset: 0x0007D794
	private void OFOPLILMAOE(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("▮▮▮", string.Format("HalfSampling", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0007F5F0 File Offset: 0x0007D7F0
	private void CPBJHEEMDAP(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("OfficeSittingEyesRub", string.Format("<color='#300000'>{0} {1}</color>", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00075F0F File Offset: 0x0007410F
	public void NCALLFHEAGJ()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLMLNDNPKFD));
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0007F64A File Offset: 0x0007D84A
	private void OnGUI()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(3280704, this.position, new GUI.WindowFunction(this.IALMHCCJLKP), "Antares Console");
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00075E2A File Offset: 0x0007402A
	private void GCCAPOHGAHA()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x00075E2A File Offset: 0x0007402A
	private void PFNOEACNHON()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void IONMMKEEEBK()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00075E2A File Offset: 0x0007402A
	private void PBEKBHFDHAM()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = !this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void BABMAHFKPMO()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x0007F67C File Offset: 0x0007D87C
	private void IALMHCCJLKP(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("No Entries Dictionary");
			return;
		}
		this.CIFNAKCJLOL();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(5f, 45f, this.position.width - 10f, this.position.height - 50f), this.MMGJAONJIIN, new Rect(0f, 5f, this.position.width - 20f, 5000f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(10.0) - DateTime.Now).TotalMilliseconds * 0.009999999776482582;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(10.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(0.25f), (float)(10.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(0.25f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("{0}, ({1}) (Events : {2})", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "non MonoBehaviour", keyValuePair.Value.EIKKFEGJIND().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.EIKKFEGJIND().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.Repaint)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.EIKKFEGJIND())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.BCOKHNCIMHE(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.EIKKFEGJIND())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("Show History (messages : {0})", keyValuePair3.Value.AFAFINBJFFC.Count), "Show last 128 records"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						GUILayout.Label(string.Format("{0}:{1}:{2}:{3}", new object[]
						{
							keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours,
							keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes,
							keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds,
							keyValuePair3.Value.EDCFDDLFAHG.Millisecond
						}), new GUILayoutOption[]
						{
							GUILayout.Width(90f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(10.0) - DateTime.Now).TotalMilliseconds * 0.009999999776482582;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(10.0) - DateTime.Now).Seconds > 0) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(0.25f), (float)(10.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(0.25f));
						GUILayout.Label(string.Format("{0}\n{1}", keyValuePair3.Key, keyValuePair3.Value.AMLGODILBAA), Array.Empty<GUILayoutOption>());
						GUILayout.Space(-60f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						keyValuePair3.Value.BMLEPGCKNBF = GUILayout.BeginScrollView(keyValuePair3.Value.BMLEPGCKNBF, false, true, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.textArea, new GUILayoutOption[]
						{
							GUILayout.Width(this.position.width - 45f),
							GUILayout.MinHeight(256f)
						});
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								GUILayout.Label(string.Format("{0}:{1}:{2}:{3}", new object[]
								{
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours,
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes,
									lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds,
									lnijihdbnfl.EDCFDDLFAHG.Millisecond
								}), new GUILayoutOption[]
								{
									GUILayout.Width(100f)
								});
								GUILayout.TextArea(string.Format("{0}\n{1}", keyValuePair3.Key, lnijihdbnfl.AMLGODILBAA), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 128f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					GUILayout.Box("", new GUILayoutOption[]
					{
						GUILayout.Height(-1f),
						GUILayout.ExpandWidth(true)
					});
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Repaint && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x0007FF2C File Offset: 0x0007E12C
	private void GKFDDADMLDM()
	{
		GUI.Box(new Rect(1727f, 1178f, this.position.width, 946f), "name");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(517f);
			GUIContent content = new GUIContent("1HSwordStrafeRunLeft", "Idle180");
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(1062f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("WorkerShovel2", "PLANE_REFLECTION_CHEAPER");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(849f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("", "_FogColor2");
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(559f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(95f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "MotorbikeWheely", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x00080104 File Offset: 0x0007E304
	private void GPHAEEOIMOH(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("langs/lang", string.Format("autherror", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00080160 File Offset: 0x0007E360
	private void DNLAMGEIMIB(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("Transforms.Length is 0.");
			return;
		}
		this.GKFDDADMLDM();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(39f, 1805f, this.position.width - 620f, this.position.height - 1127f), this.MMGJAONJIIN, new Rect(40f, 322f, this.position.width - 1588f, 1075f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(241.0) - DateTime.Now).TotalMilliseconds * 1248.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(363.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1102f), (float)(1818.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1354f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("_EmissionColor", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "PistolLeftHandStab", keyValuePair.Value.JFHJFGAKEFL().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.KeyDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PJGJPHLBIPM())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.LNMOBGEHBDC(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.PJGJPHLBIPM())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("", keyValuePair3.Value.AFAFINBJFFC.Count), "Fly Forward"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "Save";
						object[] array = new object[0];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[5] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(1023f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(777.0) - DateTime.Now).TotalMilliseconds * 1804.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(365.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(322f), (float)(1542.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(247f));
						GUILayout.Label(string.Format("Six Step", keyValuePair3.Key, keyValuePair3.Value.JGJEDKEBCCB()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1867f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = false;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[4];
						array3[0] = GUILayout.Width(this.position.width - 1403f);
						array3[1] = GUILayout.MinHeight(187f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "";
								object[] array4 = new object[2];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[3] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[3] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[1];
								array5[1] = GUILayout.Width(694f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("Flap_07.wav", keyValuePair3.Key, lnijihdbnfl.OADEHIJDEGM()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 1151f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "Trying to use the 'Arm' bend modifier on a leg.";
					GUILayoutOption[] array6 = new GUILayoutOption[8];
					array6[1] = GUILayout.Height(1569f);
					array6[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseMove && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00080A10 File Offset: 0x0007EC10
	private void OCACMKBIGCJ()
	{
		GUI.Box(new Rect(1126f, 1839f, this.position.width, 261f), "MotorbikeIdle");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1448f);
			GUIContent content = new GUIContent("bs_lev", "IdleButtonPress");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1754f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			if (GUILayout.Button(new GUIContent("", "_TintColor"), new GUILayoutOption[]
			{
				GUILayout.Width(1322f)
			}))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("wpn_hookf", "SoccerRun");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(421f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1841f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, " < ", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00080BE8 File Offset: 0x0007EDE8
	private void BFOPAJGPJLK()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-189, this.position, new GUI.WindowFunction(this.PPPHDDKLLFO), "PistolLeftHandStab");
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00077A66 File Offset: 0x00075C66
	private void BNKJNBIDPME()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00080C1C File Offset: 0x0007EE1C
	private void CFPFEDFEBMH()
	{
		GUI.Box(new Rect(1830f, 142f, this.position.width, 892f), "name");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1170f);
			GUIContent content = new GUIContent("wpn_tank1", "[maxweight]");
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(375f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("ShotgunReloadMagazine", "Button");
			GUILayoutOption[] array2 = new GUILayoutOption[1];
			array2[1] = GUILayout.Width(603f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("post_20", "KatanaReady");
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(414f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(139f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "imgid", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00080DF4 File Offset: 0x0007EFF4
	private void ONBECFGMGFF()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(-116, this.position, new GUI.WindowFunction(this.POFBKCFFJLB), "btn_cancel");
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00080E26 File Offset: 0x0007F026
	public void EHFPLKEINFO()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.APGLHOOPHHL));
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00080E39 File Offset: 0x0007F039
	public void ALDMBECNFFO()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LHHGOLKAKCI));
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00080E4C File Offset: 0x0007F04C
	private void EMAFBLJDFDF()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(134, this.position, new GUI.WindowFunction(this.MMHJDICCMKH), " ");
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00077A66 File Offset: 0x00075C66
	private void OLGDMBDGLAN()
	{
		if (Input.GetKeyDown(this.openKey))
		{
			this.NKHFADLEADA = this.NKHFADLEADA;
		}
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void MLPCBOGCEEO()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00080E7E File Offset: 0x0007F07E
	private void BEOFOEMOJAN()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(69, this.position, new GUI.WindowFunction(this.IABECBEPKEA), "base_{0}");
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x000779F6 File Offset: 0x00075BF6
	public void FECFLBMPAAL()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.HFMEFMKLNLC));
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00080EB0 File Offset: 0x0007F0B0
	public void BOJJIJICHBK()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LLBMJDLFKDH));
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00080EC4 File Offset: 0x0007F0C4
	private void JIKLDOOOJJA()
	{
		GUI.Box(new Rect(1489f, 1408f, this.position.width, 700f), "_ScreenEdgeFading");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(955f);
			GUIContent content = new GUIContent(" for vert ", "Flares");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(401f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			if (GUILayout.Button(new GUIContent(" x", "rollSoundIndex"), new GUILayoutOption[]
			{
				GUILayout.Width(664f)
			}))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = true;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("IceHockey Shot Right", "2000");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1643f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1113f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, " ♦ ", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x0008109C File Offset: 0x0007F29C
	private void AGBEEDOOOHA()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(183, this.position, new GUI.WindowFunction(this.IALMHCCJLKP), "MovementZ");
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void POPEHFLLDAI()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x000810D0 File Offset: 0x0007F2D0
	private void KGCHGPIKDLI(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("WeaponStrafeRunLeft");
			return;
		}
		this.LHMIJCCMMLK();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(428f, 1451f, this.position.width - 1592f, this.position.height - 1546f), this.MMGJAONJIIN, new Rect(840f, 1878f, this.position.width - 1411f, 1031f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1981.0) - DateTime.Now).TotalMilliseconds * 787.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1326.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1795f), (float)(420.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(20f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("CrouchWalkBackward", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "FPSAiming with Recoil needs FBBIK solver iteration count to be at least 1 to maintain accuracy.", keyValuePair.Value.EIKKFEGJIND().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.FOBEFJILOEG().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.PAGNPBJPDLC())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.BJDPJNLFNFF(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.FOBEFJILOEG())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("", keyValuePair3.Value.AFAFINBJFFC.Count), "chnam1"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "PLANE_REFLECTION_CHEAPER";
						object[] array = new object[5];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[8] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[6] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						GUILayout.Label(string.Format(format, array), new GUILayoutOption[]
						{
							GUILayout.Width(636f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(467.0) - DateTime.Now).TotalMilliseconds * 1317.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(994.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(319f), (float)(242.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1877f));
						GUILayout.Label(string.Format("int:", keyValuePair3.Key, keyValuePair3.Value.HFNAEGDDEDG()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1268f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array2 = new GUILayoutOption[8];
						array2[0] = GUILayout.Width(this.position.width - 1102f);
						array2[0] = GUILayout.MinHeight(390f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array2);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "[fish]";
								object[] array3 = new object[5];
								array3[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array3[7] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array3[0] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text = string.Format(format2, array3);
								GUILayoutOption[] array4 = new GUILayoutOption[0];
								array4[0] = GUILayout.Width(1514f);
								GUILayout.Label(text, array4);
								GUILayout.TextArea(string.Format("IdleRun", keyValuePair3.Key, lnijihdbnfl.PJAOCKDICMD()), Array.Empty<GUILayoutOption>());
								if ((float)(num2 += 0) == 867f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "_alfavis";
					GUILayoutOption[] array5 = new GUILayoutOption[7];
					array5[0] = GUILayout.Height(1456f);
					array5[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseDown && list.Count > 0)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00081980 File Offset: 0x0007FB80
	private void ALFLMNIDLMC(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("ShotgunReadyFire", string.Format("/n", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x000819DA File Offset: 0x0007FBDA
	private void JEJGFDBHABC()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(174, this.position, new GUI.WindowFunction(this.IALMHCCJLKP), "");
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x0007CE8A File Offset: 0x0007B08A
	public void NCBLFNKNEDK()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.MBIMPBEDDIK));
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void OnDisable()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00081A0C File Offset: 0x0007FC0C
	private void MGMMDKNGDCA()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(116, this.position, new GUI.WindowFunction(this.KIKPAABHHLB), "Flares");
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void EALKANLKOHI()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00081A40 File Offset: 0x0007FC40
	private void HNOIDILAPLD(string LGCFPILHPLK, string IJJDHOJOENI, LogType DFBHMIIPLCA)
	{
		Color lbcgackjcjb = Color.white;
		switch (DFBHMIIPLCA)
		{
		case LogType.Error:
		case LogType.Assert:
		case LogType.Exception:
			lbcgackjcjb = Color.red;
			break;
		case LogType.Warning:
			lbcgackjcjb = Color.yellow;
			break;
		}
		MEDFELGJLAK.ICAFGKHAAED("", string.Format("Vertical", DFBHMIIPLCA, LGCFPILHPLK), IJJDHOJOENI, lbcgackjcjb);
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void PNFNLDBHOEJ()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00081A9A File Offset: 0x0007FC9A
	private void FLDMAFHJLNB()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(43, this.position, new GUI.WindowFunction(this.KIKPAABHHLB), "Wood Cut");
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00081ACC File Offset: 0x0007FCCC
	private void KIKPAABHHLB(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("run");
			return;
		}
		this.JIKLDOOOJJA();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(754f, 1333f, this.position.width - 1241f, this.position.height - 1703f), this.MMGJAONJIIN, new Rect(777f, 1935f, this.position.width - 983f, 176f), true, false);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(799.0) - DateTime.Now).TotalMilliseconds * 745.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1967.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1415f), (float)(1552.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1109f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (!flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("</color>", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "knopje.wav", keyValuePair.Value.FOBEFJILOEG().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.NJEPOHHONFK().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.MouseDown)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.INAMCEEKJPF())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.AMOEEOGLICH(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.EIKKFEGJIND())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("IdleMonster", keyValuePair3.Value.AFAFINBJFFC.Count), "Animation controllers should be parented to character controllers!"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "autherror";
						object[] array = new object[4];
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[0] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[2] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[6] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						string text = string.Format(format, array);
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[1] = GUILayout.Width(372f);
						GUILayout.Label(text, array2);
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(995.0) - DateTime.Now).TotalMilliseconds * 144.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1932.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(990f), (float)(168.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(425f));
						GUILayout.Label(string.Format("Atmosphere reference not set.", keyValuePair3.Key, keyValuePair3.Value.HFNKPDECIEL()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(167f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = true;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array3 = new GUILayoutOption[5];
						array3[0] = GUILayout.Width(this.position.width - 473f);
						array3[0] = GUILayout.MinHeight(1442f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array3);
						int num2 = 0;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "t_body";
								object[] array4 = new object[5];
								array4[0] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array4[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array4[2] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text2 = string.Format(format2, array4);
								GUILayoutOption[] array5 = new GUILayoutOption[0];
								array5[1] = GUILayout.Width(1915f);
								GUILayout.Label(text2, array5);
								GUILayout.TextArea(string.Format("Bone01", keyValuePair3.Key, lnijihdbnfl.BHJANLCIDMP()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 941f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text3 = "MotorbikeWheelyNoHands";
					GUILayoutOption[] array6 = new GUILayoutOption[3];
					array6[1] = GUILayout.Height(1384f);
					array6[0] = GUILayout.ExpandWidth(true);
					GUILayout.Box(text3, array6);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.Layout && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0008237C File Offset: 0x0008057C
	private void CIFNAKCJLOL()
	{
		GUI.Box(new Rect(0f, 0f, this.position.width, 18f), "");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(10f);
			if (GUILayout.Button(new GUIContent("Clear", "Clear all entries"), new GUILayoutOption[]
			{
				GUILayout.Width(60f)
			}))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			if (GUILayout.Button(new GUIContent("Collapse", "Collaps all foldouts"), new GUILayoutOption[]
			{
				GUILayout.Width(70f)
			}))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			if (GUILayout.Button(new GUIContent("Close", "Close Antares Console"), new GUILayoutOption[]
			{
				GUILayout.Width(60f)
			}))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "Autoclear", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00082554 File Offset: 0x00080754
	private void KAJAMNHKHLJ()
	{
		GUI.Box(new Rect(731f, 1648f, this.position.width, 847f), "KatanaReadyHigh");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(406f);
			GUIContent content = new GUIContent("process Action", "1HSwordStrafeRunLeft");
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(230f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			if (GUILayout.Button(new GUIContent("_MainTex", "gi_tit_sel"), new GUILayoutOption[]
			{
				GUILayout.Width(997f)
			}))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content2 = new GUIContent("\n", "AntaresController");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1872f);
			if (GUILayout.Button(content2, array2))
			{
				this.NKHFADLEADA = false;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(1150f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "ThinWall", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00075ED6 File Offset: 0x000740D6
	private void NJFOOJIADNH()
	{
		MEDFELGJLAK.GFMEHKMEFKP();
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0008272C File Offset: 0x0008092C
	private void MBIBEEBIFEB()
	{
		GUI.Box(new Rect(1494f, 695f, this.position.width, 159f), "WorkerPickaxe");
		using (new CCPKCBCMDAD.HNELFBNFNNL())
		{
			GUILayout.Space(1389f);
			GUIContent content = new GUIContent("Android", "WeaponStrafeRunLeft");
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(1443f);
			if (GUILayout.Button(content, array))
			{
				MEDFELGJLAK.GFMEHKMEFKP();
			}
			GUIContent content2 = new GUIContent("", "Manifest: ");
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1495f);
			if (GUILayout.Button(content2, array2))
			{
				foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
				{
					keyValuePair.Value.PHAAOLPADFP = false;
				}
				this.MMGJAONJIIN = Vector2.zero;
			}
			GUIContent content3 = new GUIContent("Mouse ScrollWheel", "femur");
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[1] = GUILayout.Width(935f);
			if (GUILayout.Button(content3, array3))
			{
				this.NKHFADLEADA = true;
				this.MMGJAONJIIN = Vector2.zero;
			}
			using (new CCPKCBCMDAD.PBELGCLLHLE())
			{
				GUILayout.Space(466f);
				using (new CCPKCBCMDAD.HNELFBNFNNL())
				{
					this.NKMNBHOKMEN = GUILayout.Toggle(this.NKMNBHOKMEN, "U", Array.Empty<GUILayoutOption>());
				}
			}
		}
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00082904 File Offset: 0x00080B04
	private void BOCPAHEHFJH()
	{
		if (!this.NKHFADLEADA)
		{
			return;
		}
		this.position = GUI.Window(5, this.position, new GUI.WindowFunction(this.AOECONMMJCJ), "TOD_Fogginess");
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00082938 File Offset: 0x00080B38
	private void KJHBOCILABA(int HEOMBFMLJML)
	{
		List<object> list = new List<object>();
		if (MEDFELGJLAK.MJABOIDMILF == null)
		{
			Debug.Log("1HandSwordChargeUp");
			return;
		}
		this.JIKLDOOOJJA();
		this.MMGJAONJIIN = GUI.BeginScrollView(new Rect(374f, 1125f, this.position.width - 678f, this.position.height - 724f), this.MMGJAONJIIN, new Rect(940f, 14f, this.position.width - 415f, 1549f), false, true);
		foreach (KeyValuePair<object, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair in MEDFELGJLAK.MJABOIDMILF)
		{
			double num = (keyValuePair.Value.EDCFDDLFAHG.AddSeconds(756.0) - DateTime.Now).TotalMilliseconds * 971.0;
			GUI.color = (((keyValuePair.Value.EDCFDDLFAHG.AddSeconds(1557.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair.Value.LBCGACKJCJB, keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(1797f), (float)(1841.0 / num)) : keyValuePair.Value.LBCGACKJCJB.FAHEBPEFDPM(645f));
			using (new CCPKCBCMDAD.HNELFBNFNNL())
			{
				bool flag = keyValuePair.Value.EJJPBLDJFDF != null;
				if (flag)
				{
					if (flag)
					{
					}
				}
				else if (!keyValuePair.Value.GNFHHLLBCBH)
				{
					list.Add(keyValuePair.Key);
				}
				keyValuePair.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair.Value.PHAAOLPADFP, string.Format("Vertical", keyValuePair.Key, (keyValuePair.Value.EJJPBLDJFDF != null) ? keyValuePair.Value.EJJPBLDJFDF.name : "<color='#206060'>", keyValuePair.Value.FAAAIJNCKHB().Count), Array.Empty<GUILayoutOption>());
			}
			if (keyValuePair.Value.MMDMIMBJLOC().Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
			if (this.NKMNBHOKMEN && Event.current.type == EventType.Layout)
			{
				List<string> list2 = null;
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair2 in keyValuePair.Value.FGMMJKHLPKI())
				{
					if ((DateTime.Now - keyValuePair2.Value.EDCFDDLFAHG).Seconds > this.MHJCBLGJKPI)
					{
						if (list2 == null)
						{
							list2 = new List<string>();
						}
						list2.Add(keyValuePair2.Key);
					}
				}
				if (list2 != null)
				{
					foreach (string ipdjhadkpfa in list2)
					{
						keyValuePair.Value.EGLDABBDMJJ(ipdjhadkpfa);
					}
				}
			}
			if (keyValuePair.Value.PHAAOLPADFP)
			{
				foreach (KeyValuePair<string, MEDFELGJLAK.LNIJIHDBNFL> keyValuePair3 in keyValuePair.Value.PJGJPHLBIPM())
				{
					GUI.color = Color.white;
					keyValuePair3.Value.PHAAOLPADFP = GUILayout.Toggle(keyValuePair3.Value.PHAAOLPADFP, new GUIContent(string.Format("Flap_04.wav", keyValuePair3.Value.AFAFINBJFFC.Count), "_RgbTex"), Array.Empty<GUILayoutOption>());
					using (new CCPKCBCMDAD.HNELFBNFNNL())
					{
						string format = "Katana Horizontal Swing";
						object[] array = new object[1];
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Hours;
						array[1] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Minutes;
						array[6] = keyValuePair3.Value.EDCFDDLFAHG.TimeOfDay.Seconds;
						array[7] = keyValuePair3.Value.EDCFDDLFAHG.Millisecond;
						GUILayout.Label(string.Format(format, array), new GUILayoutOption[]
						{
							GUILayout.Width(1043f)
						});
						num = (keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(501.0) - DateTime.Now).TotalMilliseconds * 1145.0;
						GUI.color = (((keyValuePair3.Value.EDCFDDLFAHG.AddSeconds(1286.0) - DateTime.Now).Seconds > 1) ? Color.Lerp(keyValuePair3.Value.LBCGACKJCJB, keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(59f), (float)(1746.0 / num)) : keyValuePair3.Value.LBCGACKJCJB.FAHEBPEFDPM(1806f));
						GUILayout.Label(string.Format("Reset", keyValuePair3.Key, keyValuePair3.Value.JALHOLCMIDO()), Array.Empty<GUILayoutOption>());
						GUILayout.Space(1583f);
						GUI.color = Color.white;
					}
					if (keyValuePair3.Value.PHAAOLPADFP)
					{
						MEDFELGJLAK.LNIJIHDBNFL value = keyValuePair3.Value;
						Vector2 bmlepgcknbf = keyValuePair3.Value.BMLEPGCKNBF;
						bool alwaysShowHorizontal = true;
						bool alwaysShowVertical = false;
						GUIStyle horizontalScrollbar = GUI.skin.horizontalScrollbar;
						GUIStyle verticalScrollbar = GUI.skin.verticalScrollbar;
						GUIStyle textArea = GUI.skin.textArea;
						GUILayoutOption[] array2 = new GUILayoutOption[3];
						array2[1] = GUILayout.Width(this.position.width - 270f);
						array2[0] = GUILayout.MinHeight(964f);
						value.BMLEPGCKNBF = GUILayout.BeginScrollView(bmlepgcknbf, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, textArea, array2);
						int num2 = 1;
						foreach (MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl in keyValuePair3.Value.AFAFINBJFFC)
						{
							using (new CCPKCBCMDAD.HNELFBNFNNL())
							{
								string format2 = "CrouchWalk";
								object[] array3 = new object[1];
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Hours;
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Minutes;
								array3[1] = lnijihdbnfl.EDCFDDLFAHG.TimeOfDay.Seconds;
								array3[2] = lnijihdbnfl.EDCFDDLFAHG.Millisecond;
								string text = string.Format(format2, array3);
								GUILayoutOption[] array4 = new GUILayoutOption[1];
								array4[1] = GUILayout.Width(506f);
								GUILayout.Label(text, array4);
								GUILayout.TextArea(string.Format("ProneIdle", keyValuePair3.Key, lnijihdbnfl.GKMPPCMCMIE()), Array.Empty<GUILayoutOption>());
								if ((float)(++num2) == 200f)
								{
									break;
								}
							}
						}
						GUILayout.EndScrollView();
						GUILayout.FlexibleSpace();
					}
					GUI.color = Color.white;
					string text2 = "BAG";
					GUILayoutOption[] array5 = new GUILayoutOption[8];
					array5[1] = GUILayout.Height(651f);
					array5[1] = GUILayout.ExpandWidth(false);
					GUILayout.Box(text2, array5);
				}
				GUI.color = Color.white;
			}
		}
		if (Event.current.type == EventType.MouseUp && list.Count > 1)
		{
			foreach (object key in list)
			{
				if (MEDFELGJLAK.MJABOIDMILF.ContainsKey(key))
				{
					MEDFELGJLAK.MJABOIDMILF.Remove(key);
				}
			}
			list.Clear();
		}
		GUI.EndScrollView();
		GUI.DragWindow();
	}

	// Token: 0x04000166 RID: 358
	public KeyCode openKey = KeyCode.BackQuote;

	// Token: 0x04000167 RID: 359
	public Rect position = new Rect(10f, 10f, 512f, 512f);

	// Token: 0x04000168 RID: 360
	private Vector2 MMGJAONJIIN;

	// Token: 0x04000169 RID: 361
	private bool NKHFADLEADA;

	// Token: 0x0400016A RID: 362
	private const float GJGMNCONLNP = 10f;

	// Token: 0x0400016B RID: 363
	private const float NAICJJKJNBG = 128f;

	// Token: 0x0400016C RID: 364
	private int MHJCBLGJKPI = 180;

	// Token: 0x0400016D RID: 365
	private bool NKMNBHOKMEN;
}
