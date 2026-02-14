using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

// Token: 0x02000214 RID: 532
public class DODHLMFHFNL
{
	// Token: 0x06007AB0 RID: 31408 RVA: 0x003B4C2C File Offset: 0x003B2E2C
	public DODHLMFHFNL(NEBJANKNJOG FGPKJPBMIHH)
	{
		this.ODONNAANIEP();
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x003B4C84 File Offset: 0x003B2E84
	public bool JJGECDLIAJM(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007AB2 RID: 31410 RVA: 0x003B4CF0 File Offset: 0x003B2EF0
	public bool IGCOCOAGOML(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x003B4D5C File Offset: 0x003B2F5C
	public Sprite NGAMDONKFIM(int DCPBBPLCCFH)
	{
		Sprite result = GameInterface.getI.QTaskIcons[0];
		if (this.DHPFKNOBLNF.ContainsKey(DCPBBPLCCFH))
		{
			result = GameInterface.getI.QTaskIcons[this.DHPFKNOBLNF[DCPBBPLCCFH].KIAPLLDGFNH];
		}
		return result;
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x003B4DA4 File Offset: 0x003B2FA4
	public string CONHGLCNKHE(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		string result = "---";
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			result = this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].DHMBNNPDPMO;
		}
		return result;
	}

	// Token: 0x06007AB5 RID: 31413 RVA: 0x003B4DFC File Offset: 0x003B2FFC
	public void ANFHJIIMJNL()
	{
		Rect rect = new Rect((float)(Screen.width - 500 - 30 - 70), 66f, 500f, 400f);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 24f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = true,
			fontSize = 12,
			alignment = TextAnchor.MiddleRight,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			wordWrap = true,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = ">>";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "<<";
		}
		if (GUI.Button(new Rect((float)(Screen.width - 40 - 64), rect.y - 4f, 35f, 18f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = !HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.BJJNCOINAFG(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 18f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("<size=14><color='#00a0ff'>{0}</color></size>", this.OFJEHCPIFGC(qtask.catid));
						num2 += 18f;
						position = new Rect(rect.x, num2, rect.width, 18f);
						GUI.DrawTexture(new Rect(position.x + 32f + 250f, position.y, position.width - 250f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 18f;
						position = new Rect(rect.x, num2, rect.width, 18f);
					}
					string arg = "#ffffff";
					if (qtask.status == 0)
					{
						arg = "#ffffff";
					}
					if (qtask.status == 1)
					{
						arg = "#a0ffa0";
					}
					if (qtask.status == 2)
					{
						arg = "#ffa0a0";
					}
					string text3 = string.Format("<color='{0}'>{1}</color>", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 32f + 250f, position.y, position.width - 250f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 6f, position.y, 16f, 16f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(qtask.status, 4, 2));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.GDCDHODOPCH())
					{
						Rect position2 = new Rect(rect.x + rect.width + 28f, position.y, 16f, 16f);
						int clbpbjglhee = 6;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 5;
						}
						if (position2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
						{
							JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 4, 2));
						if (GUI.Button(position2, "", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
							this.PLJKFOFECFE(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 18f;
					if (qtask.prise.ToString() != "")
					{
						guistyle.fontSize = 10;
						position = new Rect(rect.x, num2, rect.width, 16f);
						GUI.DrawTexture(new Rect(position.x + 32f + 250f, position.y, position.width - 250f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, "<color='#a0a0a0'>" + qtask.prise.BHNJDBFCCAL() + "</color>", guistyle);
						num2 += 16f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = 10;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 1));
						position = new Rect(rect.x, num2, rect.width, 16f);
						GUI.DrawTexture(new Rect(position.x + 32f + 250f, position.y, position.width - 250f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 16f;
						guistyle.fontSize = 12;
					}
				}
			}
		}
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x003B5404 File Offset: 0x003B3604
	public void BJGOAHGFFEI(int PCPMJEDBDKO, bool KAJABDFEBLH)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB = KAJABDFEBLH;
		}
	}

	// Token: 0x06007AB7 RID: 31415 RVA: 0x003B5404 File Offset: 0x003B3604
	public void MAIBEKINHGP(int PCPMJEDBDKO, bool KAJABDFEBLH)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB = KAJABDFEBLH;
		}
	}

	// Token: 0x06007AB8 RID: 31416 RVA: 0x003B5426 File Offset: 0x003B3626
	public DODHLMFHFNL.BJCMCMLPPPC KKCBFFOFJDO(int PCPMJEDBDKO)
	{
		if (!this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			return null;
		}
		return this.LKGOEHFHCJP[PCPMJEDBDKO];
	}

	// Token: 0x06007AB9 RID: 31417 RVA: 0x003B5444 File Offset: 0x003B3644
	public void HIOKIJHJHAL(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.HKBFCJDJCOB())
		{
			long num = KADBECGIMPD.DMABDIGCLKA();
			DODHLMFHFNL.QTask qtask;
			if (!this.BEFNPAKDBGF.ContainsKey(num))
			{
				qtask = new DODHLMFHFNL.QTask
				{
					inid = num
				};
				this.BEFNPAKDBGF.Add(num, qtask);
			}
			else
			{
				qtask = this.BEFNPAKDBGF[num];
			}
			qtask.MPMELFMBFAN(KADBECGIMPD);
			qtask.text = this.AGOMCKLDHEC(qtask);
			if (qtask.inid == this.GBDIBJEGNIG)
			{
				this.LCCEGBOGDDH(qtask);
				if (qtask.status != 0)
				{
					this.LCCEGBOGDDH(null);
				}
			}
		}
	}

	// Token: 0x06007ABA RID: 31418 RVA: 0x003B54D4 File Offset: 0x003B36D4
	public string BPIGOGBBHLP(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		string result = "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off, C to toggle fog cutting, R to reset fog.";
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			result = this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].DHMBNNPDPMO;
		}
		return result;
	}

	// Token: 0x06007ABB RID: 31419 RVA: 0x003B552C File Offset: 0x003B372C
	public bool MHEFFDACBGN(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007ABC RID: 31420 RVA: 0x003B5598 File Offset: 0x003B3798
	public DODHLMFHFNL.QTask PLEFMINBIFF(int KKJKHBJKEPP)
	{
		if (!this.BEFNPAKDBGF.ContainsKey((long)KKJKHBJKEPP))
		{
			return null;
		}
		return this.BEFNPAKDBGF[(long)KKJKHBJKEPP];
	}

	// Token: 0x06007ABD RID: 31421 RVA: 0x003B55B8 File Offset: 0x003B37B8
	public void CEOLHMPCBFI(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int num = KADBECGIMPD.HDBGOLAFOBK();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			Debug.Log(string.Concat(new object[]
			{
				"qcmd=",
				num,
				" dataid=",
				num2
			}));
			switch (num)
			{
			case 1:
			{
				if (Time.time - this.JPJHPEKJEEL > 3f)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
				}
				this.JPJHPEKJEEL = Time.time;
				List<long> list = new List<long>();
				foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
				{
					if ((long)qtask.catid == num2)
					{
						list.Add(qtask.inid);
					}
				}
				using (List<long>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						long num3 = enumerator2.Current;
						int num4 = (int)num3;
						this.BEFNPAKDBGF.Remove((long)num4);
					}
					continue;
				}
				break;
			}
			case 2:
				break;
			case 3:
			{
				DODHLMFHFNL.QTask qtask2 = this.BEFNPAKDBGF.ContainsKey(num2) ? this.BEFNPAKDBGF[num2] : null;
				if (qtask2 != null)
				{
					if (this.GBDIBJEGNIG <= 0L && qtask2.taskLang.GDCDHODOPCH())
					{
						this.PLJKFOFECFE(qtask2);
					}
					string iabkgmnjljo = string.Format("<color='#a060ff'>{0}</color>: {1}", this.OFJEHCPIFGC(qtask2.catid), qtask2.text);
					OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
					string iabkgmnjljo2 = string.Format("{0}", qtask2.text);
					FlyMessageManager.getI.addRightMessage(iabkgmnjljo2, 0, 0, 0);
					if (Time.time - this.JPJHPEKJEEL > 3f)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_Newitem.wav", 1f);
					}
					this.JPJHPEKJEEL = Time.time;
					continue;
				}
				continue;
			}
			case 4:
			{
				DODHLMFHFNL.QTask qtask3 = this.BEFNPAKDBGF.ContainsKey(num2) ? this.BEFNPAKDBGF[num2] : null;
				if (qtask3 != null && qtask3.inid == this.GBDIBJEGNIG && qtask3.status != 0)
				{
					this.PLJKFOFECFE(null);
				}
				if (Time.time - this.JPJHPEKJEEL > 3f)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
				}
				this.JPJHPEKJEEL = Time.time;
				continue;
			}
			case 5:
			{
				DODHLMFHFNL.QTask qtask4 = this.BEFNPAKDBGF.ContainsKey(num2) ? this.BEFNPAKDBGF[num2] : null;
				if (qtask4 != null)
				{
					string iabkgmnjljo3 = string.Format("<color='#a060ff'>{0}</color>: {1}", this.OFJEHCPIFGC(qtask4.catid), qtask4.text);
					OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo3);
					string iabkgmnjljo4 = string.Format("{0}", qtask4.text);
					FlyMessageManager.getI.addRightMessage(iabkgmnjljo4, 0, 0, 0);
					if (Time.time - this.JPJHPEKJEEL > 3f)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_AddCountitem.wav", 0.5f);
					}
					this.JPJHPEKJEEL = Time.time;
					continue;
				}
				continue;
			}
			case 6:
			{
				DODHLMFHFNL.QTask qtask5 = this.BEFNPAKDBGF.ContainsKey(num2) ? this.BEFNPAKDBGF[num2] : null;
				if (qtask5 != null && qtask5.inid == this.GBDIBJEGNIG && qtask5.status != 0)
				{
					this.PLJKFOFECFE(null);
					continue;
				}
				continue;
			}
			default:
				continue;
			}
			if (this.BEFNPAKDBGF.ContainsKey(num2))
			{
				this.BEFNPAKDBGF.Remove(num2);
				if (Time.time - this.JPJHPEKJEEL > 3f)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
				}
				this.JPJHPEKJEEL = Time.time;
			}
		}
	}

	// Token: 0x06007ABE RID: 31422 RVA: 0x003B59A0 File Offset: 0x003B3BA0
	public bool BAIEKIAPICB(int PCPMJEDBDKO)
	{
		return this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007ABF RID: 31423 RVA: 0x003B59C4 File Offset: 0x003B3BC4
	public void CGBKGPPNMNM()
	{
		Rect rect = new Rect((float)(Screen.width - 142 - -85 - 10), 441f, 778f, 341f);
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 511f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = false,
			fontSize = -26,
			alignment = TextAnchor.MiddleLeft,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			wordWrap = true,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = "Low adminlevel!";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "crft_to";
		}
		if (GUI.Button(new Rect((float)(Screen.width - 81 - 31), rect.y - 400f, 421f, 1825f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("IceHockeyDekeMiddle", 1033f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.BJJNCOINAFG(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 1107f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("error.wav", this.OFJEHCPIFGC(qtask.catid));
						num2 += 1198f;
						position = new Rect(rect.x, num2, rect.width, 984f);
						GUI.DrawTexture(new Rect(position.x + 917f + 1094f, position.y, position.width - 332f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 1337f;
						position = new Rect(rect.x, num2, rect.width, 444f);
					}
					string arg = "NadeThrow";
					if (qtask.status == 0)
					{
						arg = "Keeper Strafe Right";
					}
					if (qtask.status == 0)
					{
						arg = "wpn_chair3";
					}
					if (qtask.status == 1)
					{
						arg = "_UnderwaterMode";
					}
					string text3 = string.Format("RussianDance", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 1387f + 1603f, position.y, position.width - 917f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 1520f, position.y, 1767f, 718f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(qtask.status, 1, 3));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.AGKKJBAFMIF())
					{
						Rect position2 = new Rect(rect.x + rect.width + 95f, position.y, 105f, 401f);
						int clbpbjglhee = 5;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 6;
						}
						if (position2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
						{
							JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(false);
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(clbpbjglhee, 1, 3));
						if (GUI.Button(position2, "act_orderb_1", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(")", 603f);
							this.FPEOHHNNDKH(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 1146f;
					if (qtask.prise.ToString() != "_MainTex")
					{
						guistyle.fontSize = 58;
						position = new Rect(rect.x, num2, rect.width, 1860f);
						GUI.DrawTexture(new Rect(position.x + 1247f + 178f, position.y, position.width - 930f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, "1HandSwordChargeSwipe" + qtask.prise.HALGHCJFOJF() + "RollerBladeFrontFlip", guistyle);
						num2 += 1807f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = 22;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("demoLong", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 1));
						position = new Rect(rect.x, num2, rect.width, 1245f);
						GUI.DrawTexture(new Rect(position.x + 1963f + 1033f, position.y, position.width - 222f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 96f;
						guistyle.fontSize = -14;
					}
				}
			}
		}
	}

	// Token: 0x06007AC0 RID: 31424 RVA: 0x003B5FCC File Offset: 0x003B41CC
	public void FAENBHHKJEN()
	{
		this.GBDIBJEGNIG = (long)PlayerPrefs.GetInt("selectedTask");
	}

	// Token: 0x06007AC1 RID: 31425 RVA: 0x003B5FE0 File Offset: 0x003B41E0
	public void KBEOAOKBHEK()
	{
		Rect rect = new Rect((float)(Screen.width - 98 - -74 - 1), 562f, 691f, 994f);
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 730f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = true,
			fontSize = 58,
			alignment = TextAnchor.UpperLeft,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			wordWrap = false,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = "isHarvest";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "The shader ";
		}
		if (GUI.Button(new Rect((float)(Screen.width - 40 - 97), rect.y - 1982f, 1727f, 1553f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = !HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.GBHBPNDLCHJ();
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Road Points Marker Left", 1569f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.BJJNCOINAFG(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 1902f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("1HandSwordRollAttack", this.OFJEHCPIFGC(qtask.catid));
						num2 += 670f;
						position = new Rect(rect.x, num2, rect.width, 1046f);
						GUI.DrawTexture(new Rect(position.x + 862f + 612f, position.y, position.width - 1470f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 1235f;
						position = new Rect(rect.x, num2, rect.width, 1417f);
					}
					string arg = "WizardNeoBlock";
					if (qtask.status == 0)
					{
						arg = "_NoiseAmount";
					}
					if (qtask.status == 1)
					{
						arg = "LINEAR";
					}
					if (qtask.status == 1)
					{
						arg = "Forward";
					}
					string text3 = string.Format("_ArScale", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 1917f + 250f, position.y, position.width - 206f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 273f, position.y, 446f, 1069f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(qtask.status, 2, 1));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.PINKGCNAOCD())
					{
						Rect position2 = new Rect(rect.x + rect.width + 1967f, position.y, 421f, 1834f);
						int clbpbjglhee = 5;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 3;
						}
						if (position2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
						{
							JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(true);
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(clbpbjglhee, 7, 3));
						if (GUI.Button(position2, "<color=\"", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("fshop_hd4", 1588f);
							this.PLJKFOFECFE(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 92f;
					if (qtask.prise.ToString() != "MotorbikeLassoLeft")
					{
						guistyle.fontSize = 66;
						position = new Rect(rect.x, num2, rect.width, 1828f);
						GUI.DrawTexture(new Rect(position.x + 381f + 1259f, position.y, position.width - 31f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, "Start.tif" + qtask.prise.APKBOMAKOBI() + "Current fog preset: ", guistyle);
						num2 += 1138f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = -30;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("OK", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 0));
						position = new Rect(rect.x, num2, rect.width, 34f);
						GUI.DrawTexture(new Rect(position.x + 391f + 1810f, position.y, position.width - 1303f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 141f;
						guistyle.fontSize = 96;
					}
				}
			}
		}
	}

	// Token: 0x06007AC2 RID: 31426 RVA: 0x003B59A0 File Offset: 0x003B3BA0
	public bool OCKKPKFOAPL(int PCPMJEDBDKO)
	{
		return this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007AC3 RID: 31427 RVA: 0x003B65E8 File Offset: 0x003B47E8
	public void EPEKCMONJII()
	{
		this.GBDIBJEGNIG = (long)PlayerPrefs.GetInt("_Highlighted");
	}

	// Token: 0x06007AC4 RID: 31428 RVA: 0x003B59A0 File Offset: 0x003B3BA0
	public bool ICHADFEDAFH(int PCPMJEDBDKO)
	{
		return this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007AC5 RID: 31429 RVA: 0x003B65FC File Offset: 0x003B47FC
	private bool FGLJLGBOGLN(int PCPMJEDBDKO, int JOOKAILKHKB, int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			foreach (IIBEEKCAAHK iibeekcaahk in this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].ACPJAMKKDLE)
			{
				if (iibeekcaahk.IBEIBAHKIAH == NKIPHCIGBOL && PNEDPPPEFFG == iibeekcaahk.ICJDPPOJINN)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06007AC6 RID: 31430 RVA: 0x003B59A0 File Offset: 0x003B3BA0
	public bool BJJNCOINAFG(int PCPMJEDBDKO)
	{
		return this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007AC7 RID: 31431 RVA: 0x003B66A0 File Offset: 0x003B48A0
	public void KBAJMMCHDOC()
	{
		Rect rect = new Rect((float)(Screen.width - -46 - -53 - 116), 994f, 1116f, 565f);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 1877f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = false,
			fontSize = 43,
			alignment = TextAnchor.UpperRight,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			wordWrap = true,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = "_Offsets";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "_ReflectionBufferSize";
		}
		if (GUI.Button(new Rect((float)(Screen.width - -128 - -69), rect.y - 501f, 515f, 1096f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = !HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("UNIQUE_SHADOW_LIGHT_COOKIE", 1956f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.BAIEKIAPICB(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 246f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("Wand/Staff", this.OFJEHCPIFGC(qtask.catid));
						num2 += 1860f;
						position = new Rect(rect.x, num2, rect.width, 590f);
						GUI.DrawTexture(new Rect(position.x + 1926f + 1124f, position.y, position.width - 1630f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 589f;
						position = new Rect(rect.x, num2, rect.width, 520f);
					}
					string arg = "MotorbikeShootLeft";
					if (qtask.status == 0)
					{
						arg = "";
					}
					if (qtask.status == 0)
					{
						arg = "WandAttack2";
					}
					if (qtask.status == 8)
					{
						arg = "_noinfo";
					}
					string text3 = string.Format("fishToSPEED=", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 1015f + 440f, position.y, position.width - 820f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 583f, position.y, 1484f, 844f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(qtask.status, 5, 2));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.GCLHBOGJLMA())
					{
						Rect position2 = new Rect(rect.x + rect.width + 1601f, position.y, 1935f, 701f);
						int clbpbjglhee = 4;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 1;
						}
						if (position2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
						{
							JDCEFOFMGHB.IKGFHGKKCPG.OHHMBDOICNG(false);
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 0, 1));
						if (GUI.Button(position2, "This limb does not have a parent (shoulder) bone", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("post_msg4", 525f);
							this.FPEOHHNNDKH(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 479f;
					if (qtask.prise.ToString() != "demoDouble")
					{
						guistyle.fontSize = -77;
						position = new Rect(rect.x, num2, rect.width, 1190f);
						GUI.DrawTexture(new Rect(position.x + 1441f + 247f, position.y, position.width - 249f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, "wpn_fid2" + qtask.prise.ENFKFAKLHNC() + "How your string is stored in memory when obscured:\n", guistyle);
						num2 += 355f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = 61;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("_Offsets", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 0));
						position = new Rect(rect.x, num2, rect.width, 1812f);
						GUI.DrawTexture(new Rect(position.x + 1328f + 1499f, position.y, position.width - 655f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 1505f;
						guistyle.fontSize = 64;
					}
				}
			}
		}
	}

	// Token: 0x06007AC8 RID: 31432 RVA: 0x003B6CA8 File Offset: 0x003B4EA8
	public void AHCBLAOPONE(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.PPAHBNGECGH())
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			DODHLMFHFNL.QTask qtask;
			if (!this.BEFNPAKDBGF.ContainsKey(num))
			{
				qtask = new DODHLMFHFNL.QTask
				{
					inid = num
				};
				this.BEFNPAKDBGF.Add(num, qtask);
			}
			else
			{
				qtask = this.BEFNPAKDBGF[num];
			}
			qtask.IHONANEEDOC(KADBECGIMPD);
			qtask.text = this.FDKEPHNOIFO(qtask);
			if (qtask.inid == this.GBDIBJEGNIG)
			{
				this.FPEOHHNNDKH(qtask);
				if (qtask.status != 0)
				{
					this.FPEOHHNNDKH(null);
				}
			}
		}
	}

	// Token: 0x06007AC9 RID: 31433 RVA: 0x003B59A0 File Offset: 0x003B3BA0
	public bool CCNKCMFFAEE(int PCPMJEDBDKO)
	{
		return this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007ACA RID: 31434 RVA: 0x003B6D35 File Offset: 0x003B4F35
	public void MLAGOEHAFFE()
	{
		this.GBDIBJEGNIG = (long)PlayerPrefs.GetInt("WizardBlock");
	}

	// Token: 0x06007ACB RID: 31435 RVA: 0x003B6D48 File Offset: 0x003B4F48
	public void EMNMOMGOBPI()
	{
		Rect rect = new Rect((float)(Screen.width - -38 - -40 - 24), 1927f, 1562f, 254f);
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 1431f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = true,
			fontSize = -6,
			alignment = TextAnchor.LowerRight,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			wordWrap = false,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = "IdleCheer";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "#FF4040";
		}
		if (GUI.Button(new Rect((float)(Screen.width - 95 - 85), rect.y - 1342f, 837f, 362f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.GBHBPNDLCHJ();
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("gi_inte_1", 920f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.BAIEKIAPICB(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 49f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("#", this.OFJEHCPIFGC(qtask.catid));
						num2 += 1897f;
						position = new Rect(rect.x, num2, rect.width, 1446f);
						GUI.DrawTexture(new Rect(position.x + 1848f + 93f, position.y, position.width - 645f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 1814f;
						position = new Rect(rect.x, num2, rect.width, 534f);
					}
					string arg = "Handstand";
					if (qtask.status == 0)
					{
						arg = "SexyDance";
					}
					if (qtask.status == 1)
					{
						arg = "IdleDie";
					}
					if (qtask.status == 4)
					{
						arg = "RHandPunch";
					}
					string text3 = string.Format("OK", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 1002f + 794f, position.y, position.width - 62f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 376f, position.y, 1716f, 1100f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(qtask.status, 6, 1));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.IOBPCIEIACA())
					{
						Rect position2 = new Rect(rect.x + rect.width + 1405f, position.y, 1103f, 479f);
						int clbpbjglhee = 1;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 6;
						}
						if (position2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
						{
							JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(clbpbjglhee, 0, 4));
						if (GUI.Button(position2, "RandomSound", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP(" ms", 763f);
							this.LCCEGBOGDDH(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 1540f;
					if (qtask.prise.ToString() != "fshop_fcost2")
					{
						guistyle.fontSize = -67;
						position = new Rect(rect.x, num2, rect.width, 1713f);
						GUI.DrawTexture(new Rect(position.x + 160f + 785f, position.y, position.width - 1644f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, "GiantGrabIdle" + qtask.prise.BHNJDBFCCAL() + "_VelTex", guistyle);
						num2 += 650f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = 11;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("error", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 0));
						position = new Rect(rect.x, num2, rect.width, 1115f);
						GUI.DrawTexture(new Rect(position.x + 353f + 1834f, position.y, position.width - 1568f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 1871f;
						guistyle.fontSize = -51;
					}
				}
			}
		}
	}

	// Token: 0x06007ACC RID: 31436 RVA: 0x003B7350 File Offset: 0x003B5550
	public bool KGLNKLLEKKB(int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.status == 0 && this.IBJAACCIGML(qtask.catid, qtask.taskid, NKIPHCIGBOL, PNEDPPPEFFG))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007ACD RID: 31437 RVA: 0x003B73C8 File Offset: 0x003B55C8
	public void PLJKFOFECFE(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ != null)
		{
			this.GBDIBJEGNIG = NELPNBJKNMJ.inid;
		}
		else
		{
			this.GBDIBJEGNIG = -1L;
		}
		PlayerPrefs.SetInt("selectedTask", (int)this.GBDIBJEGNIG);
	}

	// Token: 0x06007ACE RID: 31438 RVA: 0x003B73F4 File Offset: 0x003B55F4
	public bool JODEACICJIK(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007ACF RID: 31439 RVA: 0x003B7460 File Offset: 0x003B5660
	public string OFJEHCPIFGC(int PCPMJEDBDKO)
	{
		if (!this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			return "---";
		}
		return this.LKGOEHFHCJP[PCPMJEDBDKO].DHMBNNPDPMO;
	}

	// Token: 0x06007AD0 RID: 31440 RVA: 0x003B7488 File Offset: 0x003B5688
	public DODHLMFHFNL.HLEJNFDEHOG JHOJIFOOPOH(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		DODHLMFHFNL.BJCMCMLPPPC bjcmcmlpppc = this.KKCBFFOFJDO(PCPMJEDBDKO);
		if (bjcmcmlpppc == null)
		{
			return null;
		}
		if (bjcmcmlpppc.LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			return bjcmcmlpppc.LACCCHCPCAM[JOOKAILKHKB];
		}
		return null;
	}

	// Token: 0x06007AD1 RID: 31441 RVA: 0x003B74C0 File Offset: 0x003B56C0
	private long OHPAMPPDHLH(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return qtask.inid;
			}
		}
		return -1L;
	}

	// Token: 0x06007AD2 RID: 31442 RVA: 0x003B7530 File Offset: 0x003B5730
	public bool ADOKKNAOMDM(int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.status == 0 && this.FGLJLGBOGLN(qtask.catid, qtask.taskid, NKIPHCIGBOL, PNEDPPPEFFG))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007AD3 RID: 31443 RVA: 0x003B75A8 File Offset: 0x003B57A8
	public void AHEAJPNHBBB()
	{
		Rect rect = new Rect((float)(Screen.width - -131 - 47 - 50), 171f, 1125f, 611f);
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE == 0)
		{
			rect.y += 1250f;
		}
		GUIStyle guistyle = new GUIStyle
		{
			richText = true,
			fontSize = -86,
			alignment = TextAnchor.MiddleRight,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			wordWrap = false,
			normal = 
			{
				textColor = Color.white
			}
		};
		string text = "12";
		if (HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			text = "Up Hill Walk";
		}
		if (GUI.Button(new Rect((float)(Screen.width - -113 - -83), rect.y - 613f, 1101f, 953f), text))
		{
			HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG = HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG;
			HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("AssetLoader: ", 885f);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.CMNECFALBLG)
		{
			List<DODHLMFHFNL.QTask> list = new List<DODHLMFHFNL.QTask>(this.BEFNPAKDBGF.Values);
			list.Sort();
			int num = -1;
			float num2 = rect.y;
			foreach (DODHLMFHFNL.QTask qtask in list)
			{
				if (this.GEKFDHBDLOL(qtask.catid) && (!qtask.isTimed || !(qtask.toTime <= DateTime.Now)))
				{
					Rect position = new Rect(rect.x, num2, rect.width, 255f);
					if (qtask.catid != num)
					{
						string text2 = string.Format("CardPlayerIdle", this.OFJEHCPIFGC(qtask.catid));
						num2 += 1123f;
						position = new Rect(rect.x, num2, rect.width, 1560f);
						GUI.DrawTexture(new Rect(position.x + 662f + 1415f, position.y, position.width - 1198f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text2, guistyle);
						num = qtask.catid;
						num2 += 1018f;
						position = new Rect(rect.x, num2, rect.width, 1530f);
					}
					string arg = "Hey, there!";
					if (qtask.status == 0)
					{
						arg = "OnRodChangeClck toorder=";
					}
					if (qtask.status == 1)
					{
						arg = "Ball";
					}
					if (qtask.status == 5)
					{
						arg = "Whistle";
					}
					string text3 = string.Format("FishPointer", arg, qtask.text);
					GUI.DrawTexture(new Rect(position.x + 1641f + 202f, position.y, position.width - 888f, position.height), GameInterface.getI.UpPanelTexture);
					GUI.DrawTextureWithTexCoords(new Rect(rect.x + rect.width + 1404f, position.y, 126f, 1165f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(qtask.status, 5, 6));
					if (qtask.status == 0 && qtask.taskLang != null && qtask.taskLang.NLLJGBJALNK())
					{
						Rect position2 = new Rect(rect.x + rect.width + 1644f, position.y, 1266f, 865f);
						int clbpbjglhee = 7;
						if (this.GBDIBJEGNIG == qtask.inid)
						{
							clbpbjglhee = 8;
						}
						if (position2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
						{
							JDCEFOFMGHB.JFIDAGABKID().FFMGKOIMOPE(true);
						}
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 6, 3));
						if (GUI.Button(position2, "★{0}", GUIStyle.none))
						{
							FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("StartTests", 94f);
							this.LCCEGBOGDDH(qtask);
						}
					}
					GUI.Label(position, text3, guistyle);
					num2 += 924f;
					if (qtask.prise.ToString() != "ApplePick")
					{
						guistyle.fontSize = -50;
						position = new Rect(rect.x, num2, rect.width, 463f);
						GUI.DrawTexture(new Rect(position.x + 1196f + 51f, position.y, position.width - 361f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, " гр " + qtask.prise.PBBDGIBHHID() + ".png", guistyle);
						num2 += 1083f;
					}
					if (qtask.isTimed)
					{
						guistyle.fontSize = 101;
						TimeSpan timeSpan = qtask.toTime - DateTime.Now;
						int days = timeSpan.Days;
						string text4 = string.Format("SampleDistributionCurve", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours * (days + 0));
						position = new Rect(rect.x, num2, rect.width, 144f);
						GUI.DrawTexture(new Rect(position.x + 1917f + 1460f, position.y, position.width - 750f, position.height), GameInterface.getI.UpPanelTexture);
						GUI.Label(position, text4, guistyle);
						num2 += 254f;
						guistyle.fontSize = -123;
					}
				}
			}
		}
	}

	// Token: 0x06007AD4 RID: 31444 RVA: 0x003B7BB0 File Offset: 0x003B5DB0
	private void GGDIKJCGNHB()
	{
		if (this.HILDGANAALH)
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().GHPNJJIMCKF("LH", true));
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("https://groups.google.com/forum/#!forum/final-ik");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int key = int.Parse(xmlNode.Attributes["How your position is stored in memory when obscured: ("].Value);
					this.LKGOEHFHCJP.Add(key, new DODHLMFHFNL.BJCMCMLPPPC(xmlNode));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes(" \"{0}\"");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode2 = (XmlNode)obj2;
				if (xmlNode2.Attributes != null)
				{
					DODHLMFHFNL.OLNONNNNHJJ olnonnnnhjj = new DODHLMFHFNL.OLNONNNNHJJ();
					int key2 = int.Parse(xmlNode2.Attributes["IdleDodgeLeft"].Value);
					olnonnnnhjj.BNIHFBMEPAB = xmlNode2.Attributes["_Parameter"].Value;
					olnonnnnhjj.KIAPLLDGFNH = int.Parse(xmlNode2.Attributes["paper.wav"].Value);
					this.DHPFKNOBLNF.Add(key2, olnonnnnhjj);
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("How your health bar is stored in memory when obscured: ");
		if (xmlNodeList != null)
		{
			foreach (object obj3 in xmlNodeList)
			{
				XmlNode xmlNode3 = (XmlNode)obj3;
				if (xmlNode3.Attributes != null)
				{
					int key3 = int.Parse(xmlNode3.Attributes["sunshine_Lightmap"].Value);
					string value = xmlNode3.Attributes["SexyDance3"].Value;
					string value2 = xmlNode3.Attributes["FlyRight"].Value;
					this.DIFMPAACEGC.Add(key3, new DODHLMFHFNL.BLJIONOFNGJ(value, value2));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("_EdgeThreshold");
		if (xmlNodeList != null)
		{
			foreach (object obj4 in xmlNodeList)
			{
				XmlNode xmlNode4 = (XmlNode)obj4;
				if (xmlNode4.Attributes != null)
				{
					int key4 = int.Parse(xmlNode4.Attributes["invn_rec5"].Value);
					string value3 = xmlNode4.Attributes["shop_wl"].Value;
					string value4 = xmlNode4.Attributes["SneakBackward"].Value;
					this.GCPONGMMAAI.Add(key4, new DODHLMFHFNL.FIAAAIKMAJD(value3, value4));
				}
			}
		}
		this.MLAGOEHAFFE();
		this.HILDGANAALH = true;
		Debug.Log("https://www.youtube.com/watch?v=wT8fViZpLmQ");
	}

	// Token: 0x06007AD5 RID: 31445 RVA: 0x003B7ED8 File Offset: 0x003B60D8
	public bool GEKFDHBDLOL(int PCPMJEDBDKO)
	{
		return !this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) || this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB;
	}

	// Token: 0x06007AD6 RID: 31446 RVA: 0x003B5404 File Offset: 0x003B3604
	public void LDJEIIAHNED(int PCPMJEDBDKO, bool KAJABDFEBLH)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB = KAJABDFEBLH;
		}
	}

	// Token: 0x06007AD7 RID: 31447 RVA: 0x003B7EFC File Offset: 0x003B60FC
	private void ODONNAANIEP()
	{
		if (this.HILDGANAALH)
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("QTask.xml", false));
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("quests/cats/cat");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int key = int.Parse(xmlNode.Attributes["id"].Value);
					this.LKGOEHFHCJP.Add(key, new DODHLMFHFNL.BJCMCMLPPPC(xmlNode));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("quests/qdynamic/qd");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode2 = (XmlNode)obj2;
				if (xmlNode2.Attributes != null)
				{
					DODHLMFHFNL.OLNONNNNHJJ olnonnnnhjj = new DODHLMFHFNL.OLNONNNNHJJ();
					int key2 = int.Parse(xmlNode2.Attributes["id"].Value);
					olnonnnnhjj.BNIHFBMEPAB = xmlNode2.Attributes["name"].Value;
					olnonnnnhjj.KIAPLLDGFNH = int.Parse(xmlNode2.Attributes["imgid"].Value);
					this.DHPFKNOBLNF.Add(key2, olnonnnnhjj);
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("quests/achivments_name/qd");
		if (xmlNodeList != null)
		{
			foreach (object obj3 in xmlNodeList)
			{
				XmlNode xmlNode3 = (XmlNode)obj3;
				if (xmlNode3.Attributes != null)
				{
					int key3 = int.Parse(xmlNode3.Attributes["id"].Value);
					string value = xmlNode3.Attributes["name"].Value;
					string value2 = xmlNode3.Attributes["info"].Value;
					this.DIFMPAACEGC.Add(key3, new DODHLMFHFNL.BLJIONOFNGJ(value, value2));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("quests/tnames/turn");
		if (xmlNodeList != null)
		{
			foreach (object obj4 in xmlNodeList)
			{
				XmlNode xmlNode4 = (XmlNode)obj4;
				if (xmlNode4.Attributes != null)
				{
					int key4 = int.Parse(xmlNode4.Attributes["id"].Value);
					string value3 = xmlNode4.Attributes["name"].Value;
					string value4 = xmlNode4.Attributes["info"].Value;
					this.GCPONGMMAAI.Add(key4, new DODHLMFHFNL.FIAAAIKMAJD(value3, value4));
				}
			}
		}
		this.FAENBHHKJEN();
		this.HILDGANAALH = true;
		Debug.Log("QTaskMgr is INIT");
	}

	// Token: 0x06007AD8 RID: 31448 RVA: 0x003B8224 File Offset: 0x003B6424
	public int KHGOFHNFKMG(int PCPMJEDBDKO)
	{
		int num = 0;
		using (Dictionary<long, DODHLMFHFNL.QTask>.ValueCollection.Enumerator enumerator = this.BEFNPAKDBGF.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.catid == PCPMJEDBDKO)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06007AD9 RID: 31449 RVA: 0x003B8284 File Offset: 0x003B6484
	private void DKKCACOMDDD()
	{
		if (this.HILDGANAALH)
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().CHFGNHKJNFG("1=", false));
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes(" ");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int key = int.Parse(xmlNode.Attributes["1HandHeavySwing2"].Value);
					this.LKGOEHFHCJP.Add(key, new DODHLMFHFNL.BJCMCMLPPPC(xmlNode));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("knopje.wav");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode2 = (XmlNode)obj2;
				if (xmlNode2.Attributes != null)
				{
					DODHLMFHFNL.OLNONNNNHJJ olnonnnnhjj = new DODHLMFHFNL.OLNONNNNHJJ();
					int key2 = int.Parse(xmlNode2.Attributes["IceHockeyIdle"].Value);
					olnonnnnhjj.BNIHFBMEPAB = xmlNode2.Attributes[" for "].Value;
					olnonnnnhjj.KIAPLLDGFNH = int.Parse(xmlNode2.Attributes["_Color"].Value);
					this.DHPFKNOBLNF.Add(key2, olnonnnnhjj);
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("invn_rec22");
		if (xmlNodeList != null)
		{
			foreach (object obj3 in xmlNodeList)
			{
				XmlNode xmlNode3 = (XmlNode)obj3;
				if (xmlNode3.Attributes != null)
				{
					int key3 = int.Parse(xmlNode3.Attributes["hgtDst="].Value);
					string value = xmlNode3.Attributes["Foot"].Value;
					string value2 = xmlNode3.Attributes["_Screen"].Value;
					this.DIFMPAACEGC.Add(key3, new DODHLMFHFNL.BLJIONOFNGJ(value, value2));
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("ClimbLeft");
		if (xmlNodeList != null)
		{
			foreach (object obj4 in xmlNodeList)
			{
				XmlNode xmlNode4 = (XmlNode)obj4;
				if (xmlNode4.Attributes != null)
				{
					int key4 = int.Parse(xmlNode4.Attributes["BlendDirection"].Value);
					string value3 = xmlNode4.Attributes["OnTriggerStay"].Value;
					string value4 = xmlNode4.Attributes["1HandSwordChargeSwipe"].Value;
					this.GCPONGMMAAI.Add(key4, new DODHLMFHFNL.FIAAAIKMAJD(value3, value4));
				}
			}
		}
		this.EPEKCMONJII();
		this.HILDGANAALH = false;
		Debug.Log("SoccerKeeperReady");
	}

	// Token: 0x06007ADA RID: 31450 RVA: 0x003B85AC File Offset: 0x003B67AC
	public bool MHNDLOBEGFM(int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.status == 0 && this.IBJAACCIGML(qtask.catid, qtask.taskid, NKIPHCIGBOL, PNEDPPPEFFG))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007ADB RID: 31451 RVA: 0x003B8624 File Offset: 0x003B6824
	public string CDFCKFCEHGB(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ == null)
		{
			return "-?-";
		}
		string text = this.CONHGLCNKHE(NELPNBJKNMJ.catid, NELPNBJKNMJ.taskid);
		if (NELPNBJKNMJ.wpfishid > 0)
		{
			if (NELPNBJKNMJ.type == 4 || NELPNBJKNMJ.type == 5)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(NELPNBJKNMJ.wpfishid);
				if (befchfngomi != null)
				{
					text = text.Replace("[wtemplid]", befchfngomi.BNIHFBMEPAB);
					text = text.Replace("[wpn]", befchfngomi.BNIHFBMEPAB);
				}
			}
			else
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NELPNBJKNMJ.wpfishid);
				if (idchhhedhdc != null)
				{
					text = text.Replace("[fish]", idchhhedhdc.HAJNMNALBBI);
				}
			}
		}
		if (NELPNBJKNMJ.wpfishid == 0)
		{
			text = text.Replace("[fish]", JNBICAJIJMM.LEBHCLDODNI("anfish"));
		}
		if (NELPNBJKNMJ.baitid > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(NELPNBJKNMJ.baitid);
			if (befchfngomi2 != null)
			{
				text = text.Replace("[baitid]", befchfngomi2.BNIHFBMEPAB);
			}
		}
		text = text.Replace("[weight]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NELPNBJKNMJ.currcount));
		text = text.Replace("[maxweight]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NELPNBJKNMJ.maxcount));
		text = text.Replace("[curcnt]", string.Concat(NELPNBJKNMJ.currcount));
		text = text.Replace("[maxcnt]", string.Concat(NELPNBJKNMJ.maxcount));
		text = text.Replace("[minwgt]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NELPNBJKNMJ.minwgt));
		return text.Replace("[maxwgt]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NELPNBJKNMJ.maxwgt));
	}

	// Token: 0x06007ADC RID: 31452 RVA: 0x003B87C4 File Offset: 0x003B69C4
	private bool IBJAACCIGML(int PCPMJEDBDKO, int JOOKAILKHKB, int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			foreach (IIBEEKCAAHK iibeekcaahk in this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].ACPJAMKKDLE)
			{
				if (iibeekcaahk.NKEOCCKEOCE() == NKIPHCIGBOL && PNEDPPPEFFG == iibeekcaahk.ICJDPPOJINN)
				{
					return false;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06007ADD RID: 31453 RVA: 0x003B8868 File Offset: 0x003B6A68
	public bool JIKJHPAFDDP(int NKIPHCIGBOL, int PNEDPPPEFFG)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.status == 0 && this.IBJAACCIGML(qtask.catid, qtask.taskid, NKIPHCIGBOL, PNEDPPPEFFG))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007ADE RID: 31454 RVA: 0x003B88E0 File Offset: 0x003B6AE0
	public DODHLMFHFNL.HLEJNFDEHOG GFGOHOFBLKL(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		DODHLMFHFNL.BJCMCMLPPPC bjcmcmlpppc = this.KKCBFFOFJDO(PCPMJEDBDKO);
		if (bjcmcmlpppc == null)
		{
			return null;
		}
		if (bjcmcmlpppc.LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			return bjcmcmlpppc.LACCCHCPCAM[JOOKAILKHKB];
		}
		return null;
	}

	// Token: 0x06007ADF RID: 31455 RVA: 0x003B8918 File Offset: 0x003B6B18
	private long EDNLJIMDKEH(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return qtask.inid;
			}
		}
		return -1L;
	}

	// Token: 0x06007AE0 RID: 31456 RVA: 0x003B8988 File Offset: 0x003B6B88
	public void FPEOHHNNDKH(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ != null)
		{
			this.GBDIBJEGNIG = NELPNBJKNMJ.inid;
		}
		else
		{
			this.GBDIBJEGNIG = -1L;
		}
		PlayerPrefs.SetInt("ObscuredPrefs", (int)this.GBDIBJEGNIG);
	}

	// Token: 0x06007AE1 RID: 31457 RVA: 0x003B89B4 File Offset: 0x003B6BB4
	public void LCCEGBOGDDH(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ != null)
		{
			this.GBDIBJEGNIG = NELPNBJKNMJ.inid;
		}
		else
		{
			this.GBDIBJEGNIG = -1L;
		}
		PlayerPrefs.SetInt("INTERFACE", (int)this.GBDIBJEGNIG);
	}

	// Token: 0x06007AE2 RID: 31458 RVA: 0x003B89E0 File Offset: 0x003B6BE0
	public string FDKEPHNOIFO(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ == null)
		{
			return "1HandSwordShieldBash";
		}
		string text = this.KADJFNIOPEO(NELPNBJKNMJ.catid, NELPNBJKNMJ.taskid);
		if (NELPNBJKNMJ.wpfishid > 1)
		{
			if (NELPNBJKNMJ.type == 1 || NELPNBJKNMJ.type == 8)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.NKMGKJLONDK(NELPNBJKNMJ.wpfishid);
				if (befchfngomi != null)
				{
					text = text.Replace("_WaterLevel", befchfngomi.BNIHFBMEPAB);
					text = text.Replace("_TreatBackfaceHitAsMiss", befchfngomi.BNIHFBMEPAB);
				}
			}
			else
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NELPNBJKNMJ.wpfishid);
				if (idchhhedhdc != null)
				{
					text = text.Replace("/", idchhhedhdc.HAJNMNALBBI);
				}
			}
		}
		if (NELPNBJKNMJ.wpfishid == 0)
		{
			text = text.Replace("{not_found}", JNBICAJIJMM.PGJCPFNJNPM("Hand stand"));
		}
		if (NELPNBJKNMJ.baitid > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(NELPNBJKNMJ.baitid);
			if (befchfngomi2 != null)
			{
				text = text.Replace("MotorbikeSeatStand", befchfngomi2.BNIHFBMEPAB);
			}
		}
		text = text.Replace("UI_MapWindow_b", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)NELPNBJKNMJ.currcount));
		text = text.Replace("MENU.WAV", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)NELPNBJKNMJ.maxcount));
		text = text.Replace("BAG", string.Concat(NELPNBJKNMJ.currcount));
		text = text.Replace("Vertical", string.Concat(NELPNBJKNMJ.maxcount));
		text = text.Replace("VaderChoke", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)NELPNBJKNMJ.minwgt));
		return text.Replace("isMove", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)NELPNBJKNMJ.maxwgt));
	}

	// Token: 0x06007AE3 RID: 31459 RVA: 0x003B8B80 File Offset: 0x003B6D80
	public string AGOMCKLDHEC(DODHLMFHFNL.QTask NELPNBJKNMJ)
	{
		if (NELPNBJKNMJ == null)
		{
			return "http://j.mp/1iBK5pz";
		}
		string text = this.CONHGLCNKHE(NELPNBJKNMJ.catid, NELPNBJKNMJ.taskid);
		if (NELPNBJKNMJ.wpfishid > 1)
		{
			if (NELPNBJKNMJ.type == 7 || NELPNBJKNMJ.type == 8)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(NELPNBJKNMJ.wpfishid);
				if (befchfngomi != null)
				{
					text = text.Replace("inv_invheader", befchfngomi.BNIHFBMEPAB);
					text = text.Replace("click Refresh currentQcat=", befchfngomi.BNIHFBMEPAB);
				}
			}
			else
			{
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NELPNBJKNMJ.wpfishid);
				if (idchhhedhdc != null)
				{
					text = text.Replace("Right", idchhhedhdc.HAJNMNALBBI);
				}
			}
		}
		if (NELPNBJKNMJ.wpfishid == 0)
		{
			text = text.Replace("Grounding layers are set to nothing. Please add a ground layer.", JNBICAJIJMM.DIOJFJMOPJO("demoQuaternion"));
		}
		if (NELPNBJKNMJ.baitid > 1)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(NELPNBJKNMJ.baitid);
			if (befchfngomi2 != null)
			{
				text = text.Replace("Open tinfo", befchfngomi2.BNIHFBMEPAB);
			}
		}
		text = text.Replace("<color='{0}'> Очков работы: {1}</color>", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)NELPNBJKNMJ.currcount));
		text = text.Replace("[Y]", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)NELPNBJKNMJ.maxcount));
		text = text.Replace("Sonar_pos", string.Concat(NELPNBJKNMJ.currcount));
		text = text.Replace("PrimaryCausticsProjector", string.Concat(NELPNBJKNMJ.maxcount));
		text = text.Replace("offsets", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NELPNBJKNMJ.minwgt));
		return text.Replace("'>  > ", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NELPNBJKNMJ.maxwgt));
	}

	// Token: 0x06007AE4 RID: 31460 RVA: 0x003B8D1E File Offset: 0x003B6F1E
	public string BFGKADMHBFO(int DCPBBPLCCFH)
	{
		if (!this.DHPFKNOBLNF.ContainsKey(DCPBBPLCCFH))
		{
			return "wpn_tank1";
		}
		return this.DHPFKNOBLNF[DCPBBPLCCFH].ToString();
	}

	// Token: 0x06007AE5 RID: 31461 RVA: 0x003B8D48 File Offset: 0x003B6F48
	public void OHDKAKCPBEN(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			DODHLMFHFNL.QTask qtask;
			if (!this.BEFNPAKDBGF.ContainsKey(num))
			{
				qtask = new DODHLMFHFNL.QTask
				{
					inid = num
				};
				this.BEFNPAKDBGF.Add(num, qtask);
			}
			else
			{
				qtask = this.BEFNPAKDBGF[num];
			}
			qtask.OCPAHLAGCAI(KADBECGIMPD);
			qtask.text = this.CDFCKFCEHGB(qtask);
			if (qtask.inid == this.GBDIBJEGNIG)
			{
				this.PLJKFOFECFE(qtask);
				if (qtask.status != 0)
				{
					this.PLJKFOFECFE(null);
				}
			}
		}
	}

	// Token: 0x06007AE6 RID: 31462 RVA: 0x003B8DD8 File Offset: 0x003B6FD8
	public string KBBCBFJINNG(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		string result = " on effect ";
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			result = this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].DHMBNNPDPMO;
		}
		return result;
	}

	// Token: 0x06007AE7 RID: 31463 RVA: 0x003B8E30 File Offset: 0x003B7030
	private long PFCJBDIPCKI(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		foreach (DODHLMFHFNL.QTask qtask in this.BEFNPAKDBGF.Values)
		{
			if (qtask.catid == PCPMJEDBDKO && qtask.taskid == JOOKAILKHKB)
			{
				return qtask.inid;
			}
		}
		return -1L;
	}

	// Token: 0x06007AE8 RID: 31464 RVA: 0x003B8EA0 File Offset: 0x003B70A0
	public string KADJFNIOPEO(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		string result = "cht_msg22";
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO) && this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM.ContainsKey(JOOKAILKHKB))
		{
			result = this.LKGOEHFHCJP[PCPMJEDBDKO].LACCCHCPCAM[JOOKAILKHKB].DHMBNNPDPMO;
		}
		return result;
	}

	// Token: 0x06007AE9 RID: 31465 RVA: 0x003B8EF8 File Offset: 0x003B70F8
	public string BBNHICAOOFM(int DCPBBPLCCFH)
	{
		if (!this.DHPFKNOBLNF.ContainsKey(DCPBBPLCCFH))
		{
			return "---";
		}
		return this.DHPFKNOBLNF[DCPBBPLCCFH].ToString();
	}

	// Token: 0x06007AEA RID: 31466 RVA: 0x003B5404 File Offset: 0x003B3604
	public void EHODAGFICIC(int PCPMJEDBDKO, bool KAJABDFEBLH)
	{
		if (this.LKGOEHFHCJP.ContainsKey(PCPMJEDBDKO))
		{
			this.LKGOEHFHCJP[PCPMJEDBDKO].NBMAOGDKBDB = KAJABDFEBLH;
		}
	}

	// Token: 0x06007AEB RID: 31467 RVA: 0x003B8F20 File Offset: 0x003B7120
	public bool JFLEPMJFHDA(int PCPMJEDBDKO, int JOOKAILKHKB)
	{
		long key = this.EDNLJIMDKEH(PCPMJEDBDKO, JOOKAILKHKB);
		return this.BEFNPAKDBGF.ContainsKey(key) && this.BEFNPAKDBGF[key].status == 0;
	}

	// Token: 0x040011DC RID: 4572
	public const int NJNJJDNOJMB = 1;

	// Token: 0x040011DD RID: 4573
	public const int PJPLEOBKFAN = 2;

	// Token: 0x040011DE RID: 4574
	public const int NAAIPMAPMPP = 3;

	// Token: 0x040011DF RID: 4575
	public const int DBPNFONJHDD = 4;

	// Token: 0x040011E0 RID: 4576
	public const int ONCKKGIFMJD = 5;

	// Token: 0x040011E1 RID: 4577
	public const int ILALGFPKOOP = 6;

	// Token: 0x040011E2 RID: 4578
	public long GBDIBJEGNIG = -1L;

	// Token: 0x040011E3 RID: 4579
	public Dictionary<long, DODHLMFHFNL.QTask> BEFNPAKDBGF = new Dictionary<long, DODHLMFHFNL.QTask>();

	// Token: 0x040011E4 RID: 4580
	public Dictionary<int, DODHLMFHFNL.BJCMCMLPPPC> LKGOEHFHCJP = new Dictionary<int, DODHLMFHFNL.BJCMCMLPPPC>();

	// Token: 0x040011E5 RID: 4581
	public Dictionary<int, DODHLMFHFNL.OLNONNNNHJJ> DHPFKNOBLNF = new Dictionary<int, DODHLMFHFNL.OLNONNNNHJJ>();

	// Token: 0x040011E6 RID: 4582
	public Dictionary<int, DODHLMFHFNL.BLJIONOFNGJ> DIFMPAACEGC = new Dictionary<int, DODHLMFHFNL.BLJIONOFNGJ>();

	// Token: 0x040011E7 RID: 4583
	public Dictionary<int, DODHLMFHFNL.FIAAAIKMAJD> GCPONGMMAAI = new Dictionary<int, DODHLMFHFNL.FIAAAIKMAJD>();

	// Token: 0x040011E8 RID: 4584
	private bool HILDGANAALH;

	// Token: 0x040011E9 RID: 4585
	public float JPJHPEKJEEL;

	// Token: 0x02000215 RID: 533
	public class OLNONNNNHJJ
	{
		// Token: 0x06007AEC RID: 31468 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JCAONLDGMCJ()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NIDKKALEJIM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string CEOAKEEKAMH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PGOGIIBBPLM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JKGHGFFFGEH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string GIOCLFJADKN()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NMBKBGNBAEM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string IHKJGKNNIHA()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string CJMFHLIBCBM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string FJGIAILHMIF()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string MIHCFECAIAD()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string BNNOHGHHKBF()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string MJODNMLNFJC()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JJPMKNKFPPN()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PDMPLOPPLBI()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string KCBJCGOINMK()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string OKJEDFNFDML()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NEEHKIJGJKB()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NHDAHNIOAFD()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string FEIJPDKNKKG()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NCNNJHIIAFM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PNAEJEIKIOO()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string IBLEHFEBIMG()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string OCJAOJLHOFO()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string DHCBHNAAJKI()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string BHLHEJCILKF()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string EDBCGCIHHKA()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string DDLFNJEJPBP()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string IAJFNKBPACC()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string FGNNJFJLENH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PFNDMCPAGLP()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string DINGGHOCDNN()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JDPKKGOOKDF()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string MFPEPELOHBL()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string IGJFJGKAFIE()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string FBENMKABKKB()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JHGPBNCOHHH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x003B8F5C File Offset: 0x003B715C
		public override string ToString()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PBAJNDNHIFI()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string GJCCJEINDDC()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string AOJIJIPBKPB()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string ALELIIHGHGH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string ADOAJOFIPAM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string HLHHDFFDHGL()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string DFHAGGBIEIH()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string JODMFMFAOEG()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string PINLAFIAGGJ()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string NAAOOABFHKB()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string HDPLEBMIHFA()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string BJALMHGGAFM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string GOLHDFBFJFI()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x003B8F5C File Offset: 0x003B715C
		public virtual string GCIGMHOJAIM()
		{
			return this.BNIHFBMEPAB;
		}

		// Token: 0x040011EA RID: 4586
		public string BNIHFBMEPAB;

		// Token: 0x040011EB RID: 4587
		public int KIAPLLDGFNH;
	}

	// Token: 0x02000216 RID: 534
	public class HLEJNFDEHOG : ItemBase
	{
		// Token: 0x06007B21 RID: 31521 RVA: 0x003B8F64 File Offset: 0x003B7164
		public bool LONOMCADICB()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x003B8F94 File Offset: 0x003B7194
		public bool EJDOHDDMPMH()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x003B8FC4 File Offset: 0x003B71C4
		public bool IOBPCIEIACA()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x003B8FF4 File Offset: 0x003B71F4
		public bool GDCDHODOPCH()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x003B9024 File Offset: 0x003B7224
		public bool EHGIDCILHKF()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x003B9054 File Offset: 0x003B7254
		public bool AGKKJBAFMIF()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x003B9084 File Offset: 0x003B7284
		public bool ENODFJNLEMD()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x003B90B4 File Offset: 0x003B72B4
		public bool JHPJABCOJLD()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x003B90E4 File Offset: 0x003B72E4
		public bool FLBLOEDBKKN()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x003B9114 File Offset: 0x003B7314
		public bool MGLMNIAKCDH()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x003B9144 File Offset: 0x003B7344
		public HLEJNFDEHOG(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes == null)
			{
				return;
			}
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.DHMBNNPDPMO = JEEEOEBNJDJ.Attributes["txt"].Value;
			if (JEEEOEBNJDJ.Attributes["iNPC"] != null)
			{
				this.ACPJAMKKDLE = JLFJEGIPIMM.IKGFHGKKCPG.EBBOBJCKFPP(JEEEOEBNJDJ.Attributes["iNPC"].Value);
			}
			if (JEEEOEBNJDJ.Attributes["iPoint"] != null)
			{
				this.NDJCEMGFOMG = new IIBEEKCAAHK(JEEEOEBNJDJ.Attributes["iPoint"].Value);
			}
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x003B921C File Offset: 0x003B741C
		public bool CDGEPHNLGAG()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x003B924C File Offset: 0x003B744C
		public bool KABBJFKAHNB()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x003B927C File Offset: 0x003B747C
		public bool MNPGBKOHECI()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x003B92AC File Offset: 0x003B74AC
		public bool NLLJGBJALNK()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x003B92DC File Offset: 0x003B74DC
		public bool CNDEELALEHG()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x003B930C File Offset: 0x003B750C
		public bool IHDJBLOMGOC()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x003B933C File Offset: 0x003B753C
		public bool KIJIKHGDEHL()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x003B936C File Offset: 0x003B756C
		public bool IOKFHGHEJCN()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x003B939C File Offset: 0x003B759C
		public bool FMKGLCDFGFL()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x003B93CC File Offset: 0x003B75CC
		public bool BBNPIKMMELP()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x003B93FC File Offset: 0x003B75FC
		public bool PABFGELDGLP()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x003B942C File Offset: 0x003B762C
		public bool KPODBMBGNPB()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x003B945C File Offset: 0x003B765C
		public bool PINKGCNAOCD()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x003B948C File Offset: 0x003B768C
		public bool GCLHBOGJLMA()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x003B94BC File Offset: 0x003B76BC
		public bool DEKGFDOJCAO()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x003B94EC File Offset: 0x003B76EC
		public bool IOOCIMMJMBC()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.CHOHHHOLIBJ())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x003B951C File Offset: 0x003B771C
		public bool EEBADANIHGM()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x003B954C File Offset: 0x003B774C
		public bool LMFFJOOGDNO()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x003B957C File Offset: 0x003B777C
		public bool GFNGPFGHEFC()
		{
			bool result = true;
			if (this.ACPJAMKKDLE.Count > 1 || !this.NDJCEMGFOMG.DMPPOEAOIIC())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x003B95AC File Offset: 0x003B77AC
		public bool DJCKPAEFGAE()
		{
			bool result = false;
			if (this.ACPJAMKKDLE.Count > 0 || !this.NDJCEMGFOMG.DIFFCNOPHBJ)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x040011EC RID: 4588
		public int LPFKFNLHGBI;

		// Token: 0x040011ED RID: 4589
		public string DHMBNNPDPMO;

		// Token: 0x040011EE RID: 4590
		public string IADIEEFCKDI;

		// Token: 0x040011EF RID: 4591
		public List<IIBEEKCAAHK> ACPJAMKKDLE = new List<IIBEEKCAAHK>();

		// Token: 0x040011F0 RID: 4592
		public IIBEEKCAAHK NDJCEMGFOMG = new IIBEEKCAAHK();
	}

	// Token: 0x02000217 RID: 535
	public class BLJIONOFNGJ
	{
		// Token: 0x06007B40 RID: 31552 RVA: 0x003B95D9 File Offset: 0x003B77D9
		public BLJIONOFNGJ(string HGGLNBKFHKK, string IFPKHIOOGOJ)
		{
			this.EOMMIGPCJHM = HGGLNBKFHKK;
			this.JCKHDHGIEEB = IFPKHIOOGOJ;
		}

		// Token: 0x040011F1 RID: 4593
		public string EOMMIGPCJHM;

		// Token: 0x040011F2 RID: 4594
		public string JCKHDHGIEEB;
	}

	// Token: 0x02000218 RID: 536
	public class FIAAAIKMAJD
	{
		// Token: 0x06007B41 RID: 31553 RVA: 0x003B95EF File Offset: 0x003B77EF
		public FIAAAIKMAJD(string HGGLNBKFHKK, string IFPKHIOOGOJ)
		{
			this.AGJCPHMJEID = HGGLNBKFHKK;
			this.JCKHDHGIEEB = IFPKHIOOGOJ;
		}

		// Token: 0x040011F3 RID: 4595
		public string AGJCPHMJEID;

		// Token: 0x040011F4 RID: 4596
		public string JCKHDHGIEEB;
	}

	// Token: 0x02000219 RID: 537
	public class BJCMCMLPPPC : ItemBase
	{
		// Token: 0x06007B42 RID: 31554 RVA: 0x003B9608 File Offset: 0x003B7808
		public virtual void DPLOBGKMDEP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 0 : 4;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 700f, 697f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 1, 3));
			if (GUI.Button(position, "", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Grounded Strafe", 1233f);
			}
			COAGIAMOCIA.x += 789f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x003B96B0 File Offset: 0x003B78B0
		public virtual string NHDAHNIOAFD()
		{
			return string.Format("<color=\"", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x003B96C2 File Offset: 0x003B78C2
		public virtual string BNNOHGHHKBF()
		{
			return string.Format("BrightnessThreshold", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x003B96D4 File Offset: 0x003B78D4
		public virtual void FGPIIDOFGDN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 3 : 1;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 523f, 971f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 2, 4));
			if (GUI.Button(position, "", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO(" ms", 1842f);
			}
			COAGIAMOCIA.x += 964f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x003B977C File Offset: 0x003B797C
		public virtual void EBFNKPBFOIK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 7 : 8;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 76f, 444f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 2, 4));
			if (GUI.Button(position, "stat: ", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("26", 1010f);
			}
			COAGIAMOCIA.x += 1587f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x003B9824 File Offset: 0x003B7A24
		public virtual string BJALMHGGAFM()
		{
			return string.Format("gi_um_mx", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x003B9838 File Offset: 0x003B7A38
		public virtual void IPJJKNBJEIF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 5 : 4;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 280f, 1528f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 6, 8));
			if (GUI.Button(position, "Fishing", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("DealerShuffle", 206f);
			}
			COAGIAMOCIA.x += 649f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x003B98E0 File Offset: 0x003B7AE0
		public virtual void OEDCMOEEKPL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 1 : 0;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 125f, 96f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(clbpbjglhee, 3, 6));
			if (GUI.Button(position, "", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("_Sensitivity", 1957f);
			}
			COAGIAMOCIA.x += 1585f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x003B9988 File Offset: 0x003B7B88
		public virtual void EDMMCDOMKNN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 4 : 3;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1721f, 451f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 1, 1));
			if (GUI.Button(position, "{", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("IceHockeyDekeMiddle", 956f);
			}
			COAGIAMOCIA.x += 494f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x003B9A30 File Offset: 0x003B7C30
		public virtual string PINLAFIAGGJ()
		{
			return string.Format("RollerBladeRoll", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x003B9A44 File Offset: 0x003B7C44
		public virtual void KMAJAKPJLBI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 0 : 8;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1979f, 73f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 2, 0));
			if (GUI.Button(position, "OfficeSittingBack", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Index out of range.", 40f);
			}
			COAGIAMOCIA.x += 545f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x003B9AEC File Offset: 0x003B7CEC
		public virtual void KAJMEFHALNL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 6 : 2;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1076f, 1073f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 1, 1));
			if (GUI.Button(position, "wpn_rem1", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_SampleCount", 822f);
			}
			COAGIAMOCIA.x += 841f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x003B9B94 File Offset: 0x003B7D94
		public virtual string FBENMKABKKB()
		{
			return string.Format("FactoryTempTexture", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x003B9BA6 File Offset: 0x003B7DA6
		public virtual string NMBKBGNBAEM()
		{
			return string.Format("_LumTex", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x003B9BB8 File Offset: 0x003B7DB8
		public virtual void GJGBFPIEGEP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 0 : 4;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1842f, 1240f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 2, 1));
			if (GUI.Button(position, "IKSolverLookAt eyes setup is invalid. Can't initiate solver.", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("#ff80ff", 1915f);
			}
			COAGIAMOCIA.x += 1844f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x003B9C60 File Offset: 0x003B7E60
		public override string CJMFHLIBCBM()
		{
			return string.Format("How your position is stored in memory when obscured: (", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x003B9C72 File Offset: 0x003B7E72
		public virtual string PNAEJEIKIOO()
		{
			return string.Format("maxdeep", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x003B9C84 File Offset: 0x003B7E84
		public override string ToString()
		{
			return string.Format("<size=14><color='#00d0ff'>{0}</color></size>", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x003B9C96 File Offset: 0x003B7E96
		public virtual string FEIJPDKNKKG()
		{
			return string.Format("pointBuffer", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x003B9CA8 File Offset: 0x003B7EA8
		public virtual void DDDDMEGGKBM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 7 : 3;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 664f, 1365f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 5, 5));
			if (GUI.Button(position, "{0}", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("IdleStand", 1557f);
			}
			COAGIAMOCIA.x += 1902f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x003B9D50 File Offset: 0x003B7F50
		public virtual string JODMFMFAOEG()
		{
			return string.Format("wpnlang/weapons/weapon", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x003B9D64 File Offset: 0x003B7F64
		public virtual void FLOGBHKFADM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 7 : 1;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 413f, 978f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(clbpbjglhee, 0, 3));
			if (GUI.Button(position, "IK Effector is referencing to a bone '", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("", 254f);
			}
			COAGIAMOCIA.x += 928f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x003B9E0C File Offset: 0x003B800C
		public virtual string PDMPLOPPLBI()
		{
			return string.Format("_BlurVector", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x003B9E20 File Offset: 0x003B8020
		public override void BOHKFACPFIJ(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 2 : 7;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1722f, 1209f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 4, 2));
			if (GUI.Button(position, "TOD_Brightness", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("RollerBladeFrontFlip", 262f);
			}
			COAGIAMOCIA.x += 1192f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x003B9EC8 File Offset: 0x003B80C8
		public virtual string OKJEDFNFDML()
		{
			return string.Format("lineTENSIONKG=", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x003B9EDA File Offset: 0x003B80DA
		public virtual string JKGHGFFFGEH()
		{
			return string.Format("recept", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x003B9EEC File Offset: 0x003B80EC
		public BJCMCMLPPPC(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes != null)
			{
				this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
				this.DHMBNNPDPMO = JEEEOEBNJDJ.Attributes["name"].Value;
				this.JCAFBJMLDPK = int.Parse(JEEEOEBNJDJ.Attributes["glava"].Value);
			}
			foreach (object obj in JEEEOEBNJDJ.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int key = int.Parse(xmlNode.Attributes["id"].Value);
					this.LACCCHCPCAM.Add(key, new DODHLMFHFNL.HLEJNFDEHOG(xmlNode));
				}
			}
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x003B9FF0 File Offset: 0x003B81F0
		public virtual void AKCLOBAHKFO(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 6 : 0;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 798f, 687f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 5, 5));
			if (GUI.Button(position, "[X]", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("RollerBladeBackFlip", 1995f);
			}
			COAGIAMOCIA.x += 162f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x003BA098 File Offset: 0x003B8298
		public virtual void JJNFMHPMMBF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 4 : 2;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 116f, 1151f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(clbpbjglhee, 1, 5));
			if (GUI.Button(position, "", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("wpn_add/base", 1987f);
			}
			COAGIAMOCIA.x += 967f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x003BA140 File Offset: 0x003B8340
		public virtual string DFHAGGBIEIH()
		{
			return string.Format("head", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x003BA154 File Offset: 0x003B8354
		public override void HHGEJJFKPOK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 0 : 6;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 999f, 1242f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 5, 1));
			if (GUI.Button(position, "IdleStandingJump", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("BlackSmithHammer", 1742f);
			}
			COAGIAMOCIA.x += 435f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x003BA1FC File Offset: 0x003B83FC
		public virtual void JEIHFPODKIN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 6 : 4;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 404f, 972f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 0, 0));
			if (GUI.Button(position, "<color=\"", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_FogOfWarCenter", 1708f);
			}
			COAGIAMOCIA.x += 342f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x003BA2A4 File Offset: 0x003B84A4
		public virtual string MJODNMLNFJC()
		{
			return string.Format("_MainTex", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B63 RID: 31587 RVA: 0x003BA2B8 File Offset: 0x003B84B8
		public virtual void ODCJPHBLBBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 3 : 1;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 521f, 1988f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 4, 0));
			if (GUI.Button(position, " is different than vertices length", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("ObscuredPrefs", 249f);
			}
			COAGIAMOCIA.x += 1519f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x003BA360 File Offset: 0x003B8560
		public virtual string NCNNJHIIAFM()
		{
			return string.Format("_TempRT", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x003BA374 File Offset: 0x003B8574
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 4 : 3;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 16f, 16f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 4, 2));
			if (GUI.Button(position, "", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
			}
			COAGIAMOCIA.x += 20f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x003BA41C File Offset: 0x003B861C
		public virtual void FKHFEGMKBCA(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 1 : 7;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1988f, 1658f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 0, 1));
			if (GUI.Button(position, "saleToShop", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WeaponFire", 632f);
			}
			COAGIAMOCIA.x += 1988f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x003BA4C4 File Offset: 0x003B86C4
		public virtual string JJPMKNKFPPN()
		{
			return string.Format("jamp", this.DHMBNNPDPMO);
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x003BA4D8 File Offset: 0x003B86D8
		public virtual void DBCCBDCAMII(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 7 : 3;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1066f, 487f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 1, 4));
			if (GUI.Button(position, "FlyLeft", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_LayerThickness", 269f);
			}
			COAGIAMOCIA.x += 1687f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x003BA580 File Offset: 0x003B8780
		public virtual void DEGJHBEBGMA(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 5 : 3;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1861f, 620f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 8, 5));
			if (GUI.Button(position, "32", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("mid", 1626f);
			}
			COAGIAMOCIA.x += 408f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x003BA628 File Offset: 0x003B8828
		public virtual void JHAKFEGIANH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 6 : 6;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1832f, 941f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 0, 7));
			if (GUI.Button(position, "_TintColor", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("Mouse Y", 160f);
			}
			COAGIAMOCIA.x += 1419f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x003BA6D0 File Offset: 0x003B88D0
		public virtual void COFFCOCOJFK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 8 : 1;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1311f, 1909f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 1, 4));
			if (GUI.Button(position, "Textures/Weapons/", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("viewType", 1441f);
			}
			COAGIAMOCIA.x += 362f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x003BA778 File Offset: 0x003B8978
		public virtual void JBFOPFFEFJD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 7 : 4;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 609f, 1568f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 1, 1));
			if (GUI.Button(position, "MotorbikeHeartAttack", GUIStyle.none))
			{
				this.NBMAOGDKBDB = !this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_MaxSteps", 1687f);
			}
			COAGIAMOCIA.x += 1340f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x003BA820 File Offset: 0x003B8A20
		public virtual void CIEKGIHHAFF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			int clbpbjglhee = this.NBMAOGDKBDB ? 6 : 2;
			Rect position = new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 695f, 135f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 7, 0));
			if (GUI.Button(position, "colorB", GUIStyle.none))
			{
				this.NBMAOGDKBDB = this.NBMAOGDKBDB;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_CenterRadius", 254f);
			}
			COAGIAMOCIA.x += 318f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x040011F5 RID: 4597
		public int LPFKFNLHGBI;

		// Token: 0x040011F6 RID: 4598
		public int JCAFBJMLDPK;

		// Token: 0x040011F7 RID: 4599
		public string DHMBNNPDPMO;

		// Token: 0x040011F8 RID: 4600
		public Dictionary<int, DODHLMFHFNL.HLEJNFDEHOG> LACCCHCPCAM = new Dictionary<int, DODHLMFHFNL.HLEJNFDEHOG>();

		// Token: 0x040011F9 RID: 4601
		public bool NBMAOGDKBDB = true;
	}

	// Token: 0x0200021A RID: 538
	public class KPPFPHMJPFE : ItemBase
	{
		// Token: 0x06007B6E RID: 31598 RVA: 0x003BA8C8 File Offset: 0x003B8AC8
		public virtual void JJNFMHPMMBF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1984f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = -123,
				font = GuiProcessor.NKOEAPCIBKO().rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 1047f, COAGIAMOCIA.y + 1925f, num, num);
			if (this.CBFKKMHOIKF == 1)
			{
				GUI.color = new Color(315f, 556f, 1458f, 779f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(ibflgdamfob, 1, 1));
			GUI.color = new Color(71f, 612f, 1654f, 758f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(0, 2, 6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 227f + num, COAGIAMOCIA.y + 187f, COAGIAMOCIA.width - num - 399f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 113;
			guistyle.fontStyle = (FontStyle)6;
			guistyle.normal.textColor = new Color(1781f, 959f, 850f);
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 2)
			{
				guistyle.alignment = TextAnchor.LowerCenter;
				Rect rect = new Rect(COAGIAMOCIA.x + 551f + num, COAGIAMOCIA.y + 1707f, COAGIAMOCIA.width - num - 1640f, 1154f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 4, "FOG_EXP", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 261f - 690f, position.y + num / 1159f - 967f, 1845f, 1443f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(1, 0, 7));
			Rect position2 = new Rect(COAGIAMOCIA.x + 1657f + num, COAGIAMOCIA.y + 1281f, COAGIAMOCIA.width - num - 400f, 92f);
			guistyle.normal.textColor = new Color(834f, 1897f, 866f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 1757f;
			guistyle.normal.textColor = new Color(585f, 1645f, 24f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x003BABD6 File Offset: 0x003B8DD6
		public override void INFJMKDHGJA()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
			this.AFKGDAPPPLK(0);
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string HLHHDFFDHGL()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x003BAC00 File Offset: 0x003B8E00
		public virtual void PKGLNPIPCCD()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Name: ", 1149f);
			this.JMFOCLLLJOG(0);
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public override string ToString()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x003BAC20 File Offset: 0x003B8E20
		public void CDILOIKJAAD(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.PLHAGCDJLPA(403f, 1112f, JNBICAJIJMM.LEBHCLDODNI("WindZone"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1857f, 1567f, onkdcgnbalk.OCHCODJIPHJ.width - 1205f, onkdcgnbalk.OCHCODJIPHJ.height - 1220f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 707f - 989f, onkdcgnbalk.OCHCODJIPHJ.height - 1778f, 140f, 319f, JNBICAJIJMM.CDDCIKKDFMP("&"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().IBCKNOEANLN));
			string dpanhmgcbnl = "BaseDataLoaderCoroutine";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.LEBHCLDODNI("_WrinkleInfluences1") + "TOD_CloudScale" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 7)
			{
				dpanhmgcbnl = JNBICAJIJMM.CELEPPAEKAB("1HandSwordRollAttack") + " " + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 961f, 945f, onkdcgnbalk.OCHCODJIPHJ.width - 1455f, 861f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -63;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1434f - 425f, 1885f, 1178f, 1189f), GameInterface.getI.achives, this.IBFLGDAMFOB, 8, 0);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 790f - 827f, 954f, 1303f, 1212f), GameInterface.getI.achives, 0, 7, 1);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 145f, 253f, onkdcgnbalk.OCHCODJIPHJ.width - 1486f, 1636f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = -6;
			new LCOLJOPGDLL(onkdcgnbalk, 1075f, 1090f, onkdcgnbalk.OCHCODJIPHJ.width - 202f, 1818f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(751f, 1152f, 150f)).DFIGKKMMIAF = -98;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(153f, 995f, onkdcgnbalk.OCHCODJIPHJ.width - 1287f, 690f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 8, "BowInstant2", true);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 599f, 950f, onkdcgnbalk.OCHCODJIPHJ.width - 517f, 1641f, JNBICAJIJMM.APMJBBDBOJO().ECNKLECOKHD("") + "_Density" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(786f, 1414f, 1396f));
			lcoljopgdll2.DFIGKKMMIAF = -20;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x003BAF39 File Offset: 0x003B9139
		public virtual void ABEJEGOKNHC()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("demoByteArray", 1104f);
			this.AEFEEOOKFJF(1);
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x003BAF58 File Offset: 0x003B9158
		public virtual void HEMKDCKEKOD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 862f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = 36,
				font = GuiProcessor.IKGFHGKKCPG.rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 1503f, COAGIAMOCIA.y + 95f, num, num);
			if (this.CBFKKMHOIKF == 7)
			{
				GUI.color = new Color(637f, 889f, 1581f, 715f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(ibflgdamfob, 1, 3));
			GUI.color = new Color(546f, 51f, 713f, 1488f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(0, 1, 3));
			GUI.Label(new Rect(COAGIAMOCIA.x + 101f + num, COAGIAMOCIA.y + 1854f, COAGIAMOCIA.width - num - 1337f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 25;
			guistyle.fontStyle = FontStyle.Italic;
			guistyle.normal.textColor = new Color(1453f, 991f, 21f);
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			guistyle.alignment = TextAnchor.UpperLeft;
			if (this.CBFKKMHOIKF < 7)
			{
				guistyle.alignment = TextAnchor.MiddleLeft;
				Rect rect = new Rect(COAGIAMOCIA.x + 1636f + num, COAGIAMOCIA.y + 1483f, COAGIAMOCIA.width - num - 1589f, 1995f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 7, "", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1814f - 560f, position.y + num / 1276f - 1437f, 1879f, 1370f), GameInterface.getI.qtIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 7, 0));
			Rect position2 = new Rect(COAGIAMOCIA.x + 1376f + num, COAGIAMOCIA.y + 248f, COAGIAMOCIA.width - num - 35f, 1179f);
			guistyle.normal.textColor = new Color(1077f, 1576f, 1581f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 761f;
			guistyle.normal.textColor = new Color(1156f, 1950f, 1836f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x003BB266 File Offset: 0x003B9466
		public virtual void PBNAOJHFJIG()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Horizontal", 879f);
			this.CDILOIKJAAD(0);
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x003BB284 File Offset: 0x003B9484
		public void PJIDKPIHCEA(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PJHMHBAGFAN(69f, 1239f, JNBICAJIJMM.PPNKMDJBMLP("Giant Eat"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(527f, 1931f, onkdcgnbalk.OCHCODJIPHJ.width - 1652f, onkdcgnbalk.OCHCODJIPHJ.height - 1633f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 862f - 1782f, onkdcgnbalk.OCHCODJIPHJ.height - 913f, 1713f, 166f, JNBICAJIJMM.LEBHCLDODNI(""), 7, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.BLPLADOIPJG));
			string dpanhmgcbnl = "</color>\n";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.LEBHCLDODNI("wpn_add") + "WeaponRun" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 7)
			{
				dpanhmgcbnl = JNBICAJIJMM.NGALDMFKMJH("") + "_Grain_Params2" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 351f, 1302f, onkdcgnbalk.OCHCODJIPHJ.width - 1783f, 1305f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -36;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 752f - 1842f, 694f, 936f, 704f), GameInterface.getI.achives, this.IBFLGDAMFOB, 6, 2);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1189f - 310f, 1917f, 585f, 1932f), GameInterface.getI.achives, 1, 6, 4);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 630f, 1828f, onkdcgnbalk.OCHCODJIPHJ.width - 1871f, 1490f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 77;
			new LCOLJOPGDLL(onkdcgnbalk, 574f, 588f, onkdcgnbalk.OCHCODJIPHJ.width - 857f, 364f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(79f, 208f, 887f)).DFIGKKMMIAF = -16;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1101f, 1222f, onkdcgnbalk.OCHCODJIPHJ.width - 1584f, 933f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 3, "cash.ogg", true);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1977f, 1009f, onkdcgnbalk.OCHCODJIPHJ.width - 763f, 566f, JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("IdleReady") + "Wizard2HandThrow" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(181f, 572f, 96f));
			lcoljopgdll2.DFIGKKMMIAF = 84;
			lcoljopgdll2.LNDPBNODFPE = false;
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x003BB59D File Offset: 0x003B979D
		public virtual void CEHEBMIJBBC()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("QTaskMgr is INIT", 1620f);
			this.PJIDKPIHCEA(0);
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x003BB5BC File Offset: 0x003B97BC
		public virtual void JBFOPFFEFJD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1930f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = -69,
				font = GuiProcessor.PLGADNLAEGN().rusfont3,
				wordWrap = false,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 419f, COAGIAMOCIA.y + 1050f, num, num);
			if (this.CBFKKMHOIKF == 8)
			{
				GUI.color = new Color(1926f, 1680f, 531f, 1969f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(ibflgdamfob, 2, 4));
			GUI.color = new Color(713f, 345f, 1636f, 138f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(0, 0, 4));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1737f + num, COAGIAMOCIA.y + 473f, COAGIAMOCIA.width - num - 541f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 31;
			guistyle.fontStyle = (FontStyle)5;
			guistyle.normal.textColor = new Color(283f, 1495f, 572f);
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 2)
			{
				guistyle.alignment = TextAnchor.LowerRight;
				Rect rect = new Rect(COAGIAMOCIA.x + 1331f + num, COAGIAMOCIA.y + 776f, COAGIAMOCIA.width - num - 1923f, 222f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 1, "wpn_onlyw", false);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1695f - 877f, position.y + num / 1584f - 461f, 1702f, 1218f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(1, 4, 1));
			Rect position2 = new Rect(COAGIAMOCIA.x + 1459f + num, COAGIAMOCIA.y + 711f, COAGIAMOCIA.width - num - 134f, 240f);
			guistyle.normal.textColor = new Color(1260f, 1845f, 1425f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 192f;
			guistyle.normal.textColor = new Color(857f, 1921f, 891f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x003BB8CC File Offset: 0x003B9ACC
		public virtual void IPJJKNBJEIF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1720f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 84,
				font = GuiProcessor.PLGADNLAEGN().rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 797f, COAGIAMOCIA.y + 977f, num, num);
			if (this.CBFKKMHOIKF == 8)
			{
				GUI.color = new Color(1815f, 1106f, 1900f, 1260f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(ibflgdamfob, 5, 7));
			GUI.color = new Color(440f, 1113f, 1367f, 1802f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 4, 6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 440f + num, COAGIAMOCIA.y + 1225f, COAGIAMOCIA.width - num - 1856f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = -62;
			guistyle.fontStyle = FontStyle.Bold;
			guistyle.normal.textColor = new Color(1666f, 425f, 699f);
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 0)
			{
				guistyle.alignment = TextAnchor.MiddleRight;
				Rect rect = new Rect(COAGIAMOCIA.x + 1707f + num, COAGIAMOCIA.y + 731f, COAGIAMOCIA.width - num - 1283f, 1728f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 0, "</color>", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 698f - 233f, position.y + num / 377f - 1925f, 1764f, 1425f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 1, 2));
			Rect position2 = new Rect(COAGIAMOCIA.x + 1921f + num, COAGIAMOCIA.y + 1676f, COAGIAMOCIA.width - num - 485f, 822f);
			guistyle.normal.textColor = new Color(1874f, 640f, 857f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 1279f;
			guistyle.normal.textColor = new Color(1505f, 1800f, 1272f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x003BBBDC File Offset: 0x003B9DDC
		public virtual void DDDDMEGGKBM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 381f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 104,
				font = GuiProcessor.BBLINJLBAIL().rusfont3,
				wordWrap = false,
				richText = false
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 55f, COAGIAMOCIA.y + 1187f, num, num);
			if (this.CBFKKMHOIKF == 3)
			{
				GUI.color = new Color(1031f, 141f, 64f, 719f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(ibflgdamfob, 6, 6));
			GUI.color = new Color(568f, 1852f, 1349f, 1670f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(0, 1, 5));
			GUI.Label(new Rect(COAGIAMOCIA.x + 611f + num, COAGIAMOCIA.y + 1810f, COAGIAMOCIA.width - num - 336f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = -112;
			guistyle.fontStyle = FontStyle.Italic;
			guistyle.normal.textColor = new Color(125f, 1856f, 291f);
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			guistyle.alignment = TextAnchor.UpperLeft;
			if (this.CBFKKMHOIKF < 2)
			{
				guistyle.alignment = TextAnchor.LowerCenter;
				Rect rect = new Rect(COAGIAMOCIA.x + 1668f + num, COAGIAMOCIA.y + 1629f, COAGIAMOCIA.width - num - 1510f, 887f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 5, "FULLNAME", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1853f - 1553f, position.y + num / 843f - 975f, 1671f, 114f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(1, 6, 1));
			Rect position2 = new Rect(COAGIAMOCIA.x + 1382f + num, COAGIAMOCIA.y + 1749f, COAGIAMOCIA.width - num - 1649f, 1417f);
			guistyle.normal.textColor = new Color(1360f, 173f, 1057f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 1770f;
			guistyle.normal.textColor = new Color(379f, 1482f, 47f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x003BBEEA File Offset: 0x003BA0EA
		public virtual void NLDAODBNKFO()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("ShotgunReloadMagazine", 1686f);
			this.NMPBDCMGCEE(1);
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x003BBF08 File Offset: 0x003BA108
		public void AEFEEOOKFJF(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1035f, 614f, JNBICAJIJMM.LEBHCLDODNI("MotorbikeShootLeft"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(373f, 471f, onkdcgnbalk.OCHCODJIPHJ.width - 1007f, onkdcgnbalk.OCHCODJIPHJ.height - 1621f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 414f - 511f, onkdcgnbalk.OCHCODJIPHJ.height - 1651f, 1868f, 1344f, JNBICAJIJMM.PPNKMDJBMLP("\n"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().ODBGHCIJOHA));
			string dpanhmgcbnl = "change channek close";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = JNBICAJIJMM.PGJCPFNJNPM("gi_uinf_6") + "gi_fridgiceno" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 4)
			{
				dpanhmgcbnl = JNBICAJIJMM.CDDCIKKDFMP("_Parameter") + "OneHandSwordRun" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 752f, 1664f, onkdcgnbalk.OCHCODJIPHJ.width - 1460f, 1414f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -70;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1153f - 283f, 1965f, 318f, 1723f), GameInterface.getI.achives, this.IBFLGDAMFOB, 5, 1);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 834f - 1940f, 697f, 1513f, 480f), GameInterface.getI.achives, 0, 0, 2);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 921f, 454f, onkdcgnbalk.OCHCODJIPHJ.width - 1802f, 376f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 12;
			new LCOLJOPGDLL(onkdcgnbalk, 1329f, 41f, onkdcgnbalk.OCHCODJIPHJ.width - 1078f, 200f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(1743f, 522f, 1862f)).DFIGKKMMIAF = -17;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1331f, 958f, onkdcgnbalk.OCHCODJIPHJ.width - 186f, 553f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 2, "WoodSaw", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1333f, 145f, onkdcgnbalk.OCHCODJIPHJ.width - 162f, 1706f, JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("ComeHere") + "value" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1466f, 468f, 1017f));
			lcoljopgdll2.DFIGKKMMIAF = 52;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x003BC224 File Offset: 0x003BA424
		public void OCLAAINCNCB(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.DKOFCBMKEPC(1658f, 1037f, JNBICAJIJMM.BDKHMOOFHHK("box"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1824f, 241f, onkdcgnbalk.OCHCODJIPHJ.width - 886f, onkdcgnbalk.OCHCODJIPHJ.height - 117f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1905f - 1439f, onkdcgnbalk.OCHCODJIPHJ.height - 1715f, 971f, 1067f, JNBICAJIJMM.DIOJFJMOPJO("ok"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
			string dpanhmgcbnl = "WandStand";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.BDKHMOOFHHK("neck") + "WeaponStrafeRunLeft" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.LEBHCLDODNI("") + "UNDISTORT" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 214f, 1492f, onkdcgnbalk.OCHCODJIPHJ.width - 542f, 331f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 78;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1731f - 799f, 333f, 632f, 30f), GameInterface.getI.achives, this.IBFLGDAMFOB, 7, 7);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1920f - 1100f, 1201f, 644f, 1889f), GameInterface.getI.achives, 1, 5, 1);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 722f, 1991f, onkdcgnbalk.OCHCODJIPHJ.width - 1586f, 1929f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = -12;
			new LCOLJOPGDLL(onkdcgnbalk, 175f, 1516f, onkdcgnbalk.OCHCODJIPHJ.width - 1727f, 1398f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(90f, 0f, 823f)).DFIGKKMMIAF = 76;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(809f, 1492f, onkdcgnbalk.OCHCODJIPHJ.width - 417f, 1274f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 1, "The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).", true);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1082f, 941f, onkdcgnbalk.OCHCODJIPHJ.width - 1405f, 1693f, JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("PER_VERTEX") + "" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1037f, 601f, 714f));
			lcoljopgdll2.DFIGKKMMIAF = 115;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x003BC53D File Offset: 0x003BA73D
		public virtual void KOPMDIOJHIP()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("<color='#20a000'> Требований нет </color>", 1968f);
			this.GEKEAHEBLMI(1);
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string JDPKKGOOKDF()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string AOJIJIPBKPB()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x003BC55A File Offset: 0x003BA75A
		public virtual void PBNEPCPBJEJ()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("WizardPowerUp", 1895f);
			this.JHBPMJCBLKG(0);
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x003BC578 File Offset: 0x003BA778
		public virtual void DPFHNFGPOAH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1266f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 58,
				font = GuiProcessor.BBLINJLBAIL().rusfont3,
				wordWrap = false,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 1885f, COAGIAMOCIA.y + 228f, num, num);
			if (this.CBFKKMHOIKF == 2)
			{
				GUI.color = new Color(626f, 916f, 1520f, 1796f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(ibflgdamfob, 7, 3));
			GUI.color = new Color(1848f, 275f, 1259f, 342f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(0, 1, 6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 222f + num, COAGIAMOCIA.y + 1301f, COAGIAMOCIA.width - num - 1569f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 1;
			guistyle.fontStyle = FontStyle.Italic;
			guistyle.normal.textColor = new Color(739f, 653f, 840f);
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 2)
			{
				guistyle.alignment = TextAnchor.LowerLeft;
				Rect rect = new Rect(COAGIAMOCIA.x + 1833f + num, COAGIAMOCIA.y + 715f, COAGIAMOCIA.width - num - 994f, 1724f);
				GameInterface.getI.NFGOLLEEHHK(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 7, "===== ObscuredVector3Test =====\n", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1558f - 1370f, position.y + num / 1546f - 932f, 740f, 1761f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(0, 2, 0));
			Rect position2 = new Rect(COAGIAMOCIA.x + 48f + num, COAGIAMOCIA.y + 591f, COAGIAMOCIA.width - num - 497f, 243f);
			guistyle.normal.textColor = new Color(689f, 1736f, 1070f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 1043f;
			guistyle.normal.textColor = new Color(1663f, 1886f, 1890f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string OCJAOJLHOFO()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x003BC888 File Offset: 0x003BAA88
		public KPPFPHMJPFE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.IBFLGDAMFOB = KADBECGIMPD.HDBGOLAFOBK();
			this.CBFKKMHOIKF = KADBECGIMPD.HDBGOLAFOBK();
			this.GIPKHILLHCP = KADBECGIMPD.HDBGOLAFOBK();
			Debug.Log("currentCount=" + this.GIPKHILLHCP);
			this.NELPNBJKNMJ = new DODHLMFHFNL.QTask();
			KADBECGIMPD.DNIIFBAIPBE();
			this.NELPNBJKNMJ.OCPAHLAGCAI(KADBECGIMPD);
			this.NELPNBJKNMJ.currcount = this.GIPKHILLHCP;
			this.NELPNBJKNMJ.status = this.CBFKKMHOIKF;
			this.NELPNBJKNMJ.text = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(this.NELPNBJKNMJ);
			DODHLMFHFNL.BLJIONOFNGJ bljionofngj = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DIFMPAACEGC.ContainsKey(this.IBFLGDAMFOB) ? JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DIFMPAACEGC[this.IBFLGDAMFOB] : null;
			if (bljionofngj != null)
			{
				this.KEIEIAAKHHK = bljionofngj.EOMMIGPCJHM;
				this.IFPKHIOOGOJ = bljionofngj.JCKHDHGIEEB;
			}
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x003BC9B4 File Offset: 0x003BABB4
		public virtual void AJPAHPBOLLK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1477f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 19,
				font = GuiProcessor.BBLINJLBAIL().rusfont3,
				wordWrap = true,
				richText = false
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 1905f, COAGIAMOCIA.y + 904f, num, num);
			if (this.CBFKKMHOIKF == 4)
			{
				GUI.color = new Color(1449f, 1032f, 999f, 1813f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(ibflgdamfob, 1, 4));
			GUI.color = new Color(342f, 6f, 994f, 647f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(0, 8, 8));
			GUI.Label(new Rect(COAGIAMOCIA.x + 829f + num, COAGIAMOCIA.y + 1373f, COAGIAMOCIA.width - num - 1329f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 82;
			guistyle.fontStyle = (FontStyle)4;
			guistyle.normal.textColor = new Color(907f, 1815f, 726f);
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 3)
			{
				guistyle.alignment = TextAnchor.UpperRight;
				Rect rect = new Rect(COAGIAMOCIA.x + 1623f + num, COAGIAMOCIA.y + 515f, COAGIAMOCIA.width - num - 779f, 1421f);
				GameInterface.getI.renderPBar(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 8, "\npb_Face: ", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1893f - 1751f, position.y + num / 1822f - 109f, 1876f, 1892f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(1, 5, 7));
			Rect position2 = new Rect(COAGIAMOCIA.x + 144f + num, COAGIAMOCIA.y + 1909f, COAGIAMOCIA.width - num - 741f, 1597f);
			guistyle.normal.textColor = new Color(6f, 1813f, 178f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 648f;
			guistyle.normal.textColor = new Color(948f, 1825f, 1950f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x003BCCC4 File Offset: 0x003BAEC4
		public virtual void COFFCOCOJFK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 689f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = -34,
				font = GuiProcessor.PLGADNLAEGN().rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 804f, COAGIAMOCIA.y + 1666f, num, num);
			if (this.CBFKKMHOIKF == 1)
			{
				GUI.color = new Color(1111f, 300f, 1456f, 1500f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(ibflgdamfob, 6, 5));
			GUI.color = new Color(1628f, 150f, 256f, 1755f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(0, 6, 2));
			GUI.Label(new Rect(COAGIAMOCIA.x + 448f + num, COAGIAMOCIA.y + 931f, COAGIAMOCIA.width - num - 1770f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = -94;
			guistyle.fontStyle = (FontStyle)6;
			guistyle.normal.textColor = new Color(1823f, 1102f, 517f);
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 4)
			{
				guistyle.alignment = TextAnchor.MiddleLeft;
				Rect rect = new Rect(COAGIAMOCIA.x + 1532f + num, COAGIAMOCIA.y + 33f, COAGIAMOCIA.width - num - 1189f, 678f);
				GameInterface.getI.renderPBar(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 7, "shop_t6", false);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 1112f - 770f, position.y + num / 1418f - 274f, 788f, 309f), GameInterface.getI.qtIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 4, 3));
			Rect position2 = new Rect(COAGIAMOCIA.x + 398f + num, COAGIAMOCIA.y + 1661f, COAGIAMOCIA.width - num - 1742f, 1556f);
			guistyle.normal.textColor = new Color(536f, 1648f, 1741f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 241f;
			guistyle.normal.textColor = new Color(205f, 969f, 1024f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x003BCFD4 File Offset: 0x003BB1D4
		public void COKNCLBLDHK(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(1145f, 1574f, JNBICAJIJMM.CDDCIKKDFMP("\n"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(347f, 73f, onkdcgnbalk.OCHCODJIPHJ.width - 1962f, onkdcgnbalk.OCHCODJIPHJ.height - 890f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1682f - 124f, onkdcgnbalk.OCHCODJIPHJ.height - 571f, 1194f, 468f, JNBICAJIJMM.OOOKJHOHPNN("; "), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
			string dpanhmgcbnl = "F4";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.OOOKJHOHPNN("Wizard2HandThrow") + "Z" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.OOOKJHOHPNN("_Texture") + "_InputGamma" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 605f, 249f, onkdcgnbalk.OCHCODJIPHJ.width - 1385f, 326f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -116;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1645f - 1951f, 60f, 1817f, 173f), GameInterface.getI.achives, this.IBFLGDAMFOB, 1, 1);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1795f - 1748f, 189f, 393f, 1687f), GameInterface.getI.achives, 0, 7, 2);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1924f, 19f, onkdcgnbalk.OCHCODJIPHJ.width - 1302f, 1774f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = -24;
			new LCOLJOPGDLL(onkdcgnbalk, 1250f, 1753f, onkdcgnbalk.OCHCODJIPHJ.width - 1102f, 77f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(1475f, 564f, 969f)).DFIGKKMMIAF = 70;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1357f, 21f, onkdcgnbalk.OCHCODJIPHJ.width - 1315f, 1865f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 5, "Vertical", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 753f, 1021f, onkdcgnbalk.OCHCODJIPHJ.width - 76f, 983f, JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("loadedLevel=") + " (hair opaque)" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(168f, 120f, 1768f));
			lcoljopgdll2.DFIGKKMMIAF = -76;
			lcoljopgdll2.LNDPBNODFPE = false;
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x003BD2F0 File Offset: 0x003BB4F0
		public void ANAKBIHEJKJ(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(553f, 534f, JNBICAJIJMM.DCEBAJIILPC("_BgFade"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(642f, 592f, onkdcgnbalk.OCHCODJIPHJ.width - 339f, onkdcgnbalk.OCHCODJIPHJ.height - 380f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1343f - 1667f, onkdcgnbalk.OCHCODJIPHJ.height - 875f, 454f, 1984f, JNBICAJIJMM.DCEBAJIILPC("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center)."), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().AGIEGPEMGOA));
			string dpanhmgcbnl = "1 Hand Sword Swing";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = JNBICAJIJMM.BDKHMOOFHHK(" ") + "cht_msg37" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 6)
			{
				dpanhmgcbnl = JNBICAJIJMM.DCEBAJIILPC("\n") + "ObscuredVector3:" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 958f, 1849f, onkdcgnbalk.OCHCODJIPHJ.width - 1039f, 1635f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -91;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1777f - 25f, 1010f, 1960f, 379f), GameInterface.getI.achives, this.IBFLGDAMFOB, 5, 0);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 291f - 131f, 1331f, 1553f, 1065f), GameInterface.getI.achives, 0, 0, 0);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1019f, 1591f, onkdcgnbalk.OCHCODJIPHJ.width - 176f, 623f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = 33;
			new LCOLJOPGDLL(onkdcgnbalk, 533f, 522f, onkdcgnbalk.OCHCODJIPHJ.width - 915f, 321f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(326f, 577f, 1575f)).DFIGKKMMIAF = 94;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(452f, 1007f, onkdcgnbalk.OCHCODJIPHJ.width - 1013f, 43f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 2, "cht_delfrendmsg", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 915f, 74f, onkdcgnbalk.OCHCODJIPHJ.width - 768f, 952f, JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("_rcpFrame") + "_LerpRgbTex" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(1923f, 299f, 748f));
			lcoljopgdll2.DFIGKKMMIAF = -43;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x003BD60C File Offset: 0x003BB80C
		public virtual void DBCCBDCAMII(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 1554f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 42,
				font = GuiProcessor.NKOEAPCIBKO().rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 926f, COAGIAMOCIA.y + 1050f, num, num);
			if (this.CBFKKMHOIKF == 4)
			{
				GUI.color = new Color(640f, 585f, 800f, 307f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(ibflgdamfob, 8, 6));
			GUI.color = new Color(1898f, 1953f, 1042f, 1653f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(0, 5, 2));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1832f + num, COAGIAMOCIA.y + 1216f, COAGIAMOCIA.width - num - 841f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 53;
			guistyle.fontStyle = FontStyle.Bold;
			guistyle.normal.textColor = new Color(867f, 1900f, 135f);
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			guistyle.alignment = TextAnchor.UpperCenter;
			if (this.CBFKKMHOIKF < 6)
			{
				guistyle.alignment = TextAnchor.UpperLeft;
				Rect rect = new Rect(COAGIAMOCIA.x + 1770f + num, COAGIAMOCIA.y + 1132f, COAGIAMOCIA.width - num - 1136f, 1426f);
				GameInterface.getI.renderPBar(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 4, "", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 24f - 1467f, position.y + num / 614f - 487f, 1273f, 1449f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 6, 8));
			Rect position2 = new Rect(COAGIAMOCIA.x + 951f + num, COAGIAMOCIA.y + 1062f, COAGIAMOCIA.width - num - 1773f, 1037f);
			guistyle.normal.textColor = new Color(1432f, 105f, 1671f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 1721f;
			guistyle.normal.textColor = new Color(1142f, 493f, 267f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string PDMPLOPPLBI()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x003BD91C File Offset: 0x003BBB1C
		public void JHBPMJCBLKG(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().BJFHBPOCELH(700f, 1967f, JNBICAJIJMM.OOOKJHOHPNN("Demo 2 scene: move with WASD. Advance to find the rotating sign which will make the fog disappear."), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(949f, 467f, onkdcgnbalk.OCHCODJIPHJ.width - 980f, onkdcgnbalk.OCHCODJIPHJ.height - 995f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1469f - 640f, onkdcgnbalk.OCHCODJIPHJ.height - 1118f, 173f, 142f, JNBICAJIJMM.DCEBAJIILPC("wpn/"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().AGIEGPEMGOA));
			string dpanhmgcbnl = "IdleMeditate";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = JNBICAJIJMM.BDKHMOOFHHK("act_order") + "cap" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 5)
			{
				dpanhmgcbnl = JNBICAJIJMM.DCEBAJIILPC("") + "ScubaOK" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1884f, 292f, onkdcgnbalk.OCHCODJIPHJ.width - 947f, 473f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -96;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 822f - 131f, 206f, 1522f, 239f), GameInterface.getI.achives, this.IBFLGDAMFOB, 6, 7);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1946f - 1488f, 828f, 1449f, 1194f), GameInterface.getI.achives, 0, 2, 4);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1007f, 623f, onkdcgnbalk.OCHCODJIPHJ.width - 68f, 62f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = -43;
			new LCOLJOPGDLL(onkdcgnbalk, 1563f, 9f, onkdcgnbalk.OCHCODJIPHJ.width - 1859f, 1039f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(1913f, 480f, 83f)).DFIGKKMMIAF = 27;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1074f, 475f, onkdcgnbalk.OCHCODJIPHJ.width - 1753f, 728f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 0, "*************157 baseid=", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1595f, 1934f, onkdcgnbalk.OCHCODJIPHJ.width - 682f, 1852f, JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("WizardBlock") + "" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1255f, 1662f, 570f));
			lcoljopgdll2.DFIGKKMMIAF = -19;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x003BDC38 File Offset: 0x003BBE38
		public void BOIHMNJOAAE(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(579f, 1553f, JNBICAJIJMM.PPNKMDJBMLP("HeelClick"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(711f, 1057f, onkdcgnbalk.OCHCODJIPHJ.width - 604f, onkdcgnbalk.OCHCODJIPHJ.height - 453f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 855f - 658f, onkdcgnbalk.OCHCODJIPHJ.height - 1051f, 514f, 1461f, JNBICAJIJMM.DIOJFJMOPJO("Katana"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
			string dpanhmgcbnl = "Pistol";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.CELEPPAEKAB("IdleWalk") + "auk_wcnt" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 6)
			{
				dpanhmgcbnl = JNBICAJIJMM.PGJCPFNJNPM("<color='#000000'>") + "Используем " + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1066f, 1874f, onkdcgnbalk.OCHCODJIPHJ.width - 4f, 223f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 62;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 588f - 1568f, 1680f, 1108f, 101f), GameInterface.getI.achives, this.IBFLGDAMFOB, 3, 3);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 653f - 1793f, 18f, 1209f, 618f), GameInterface.getI.achives, 1, 1, 4);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1982f, 1805f, onkdcgnbalk.OCHCODJIPHJ.width - 764f, 44f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = -5;
			new LCOLJOPGDLL(onkdcgnbalk, 657f, 1915f, onkdcgnbalk.OCHCODJIPHJ.width - 47f, 246f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(1805f, 1132f, 486f)).DFIGKKMMIAF = -45;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(429f, 488f, onkdcgnbalk.OCHCODJIPHJ.width - 803f, 1113f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 8, "fshop_ks1", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1943f, 413f, onkdcgnbalk.OCHCODJIPHJ.width - 741f, 1585f, JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("DISTORT") + "ClimbUp" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(1294f, 403f, 1624f));
			lcoljopgdll2.DFIGKKMMIAF = -17;
			lcoljopgdll2.LNDPBNODFPE = false;
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x003BDF51 File Offset: 0x003BC151
		public virtual void MNGFCIMHCHM()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("SoccerPassLight", 82f);
			this.PJIDKPIHCEA(0);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x003BDF6E File Offset: 0x003BC16E
		public virtual void AIECNOJIOJL()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("[HA ", 177f);
			this.COKNCLBLDHK(0);
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x003BDF8C File Offset: 0x003BC18C
		public void PPOOEJLIOEB(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(1585f, 1258f, JNBICAJIJMM.LEBHCLDODNI("Cheer Jump"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(483f, 1536f, onkdcgnbalk.OCHCODJIPHJ.width - 1547f, onkdcgnbalk.OCHCODJIPHJ.height - 1127f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1862f - 272f, onkdcgnbalk.OCHCODJIPHJ.height - 1754f, 973f, 1440f, JNBICAJIJMM.CELEPPAEKAB("_parent"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
			string dpanhmgcbnl = "Horizontal";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = JNBICAJIJMM.OOOKJHOHPNN("auc_resallcst") + "Crouch Strafe Right" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 6)
			{
				dpanhmgcbnl = JNBICAJIJMM.NGALDMFKMJH("_DistAmount") + "Roar" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 678f, 1865f, onkdcgnbalk.OCHCODJIPHJ.width - 603f, 1377f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 7;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1328f - 1207f, 1546f, 195f, 64f), GameInterface.getI.achives, this.IBFLGDAMFOB, 2, 5);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 914f - 1214f, 86f, 1112f, 398f), GameInterface.getI.achives, 1, 3, 2);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 612f, 388f, onkdcgnbalk.OCHCODJIPHJ.width - 282f, 221f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = -69;
			new LCOLJOPGDLL(onkdcgnbalk, 1422f, 302f, onkdcgnbalk.OCHCODJIPHJ.width - 641f, 745f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(1549f, 1329f, 580f)).DFIGKKMMIAF = -96;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1743f, 1106f, onkdcgnbalk.OCHCODJIPHJ.width - 1403f, 487f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 8, "isRun", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1559f, 908f, onkdcgnbalk.OCHCODJIPHJ.width - 891f, 890f, JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("<color='#60e0ff'>") + "CrouchWalk" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1915f, 1736f, 244f));
			lcoljopgdll2.DFIGKKMMIAF = -9;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string NCNNJHIIAFM()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x003BE2A8 File Offset: 0x003BC4A8
		public void GEKEAHEBLMI(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().NCIDDNIKACI(871f, 1078f, JNBICAJIJMM.NGALDMFKMJH("name"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(551f, 327f, onkdcgnbalk.OCHCODJIPHJ.width - 1703f, onkdcgnbalk.OCHCODJIPHJ.height - 128f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 975f - 1801f, onkdcgnbalk.OCHCODJIPHJ.height - 1400f, 664f, 1975f, JNBICAJIJMM.CELEPPAEKAB(" iterations for read and write"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().HMBGLALKHCP));
			string dpanhmgcbnl = "</color>";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.OOOKJHOHPNN("offsets") + "" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 4)
			{
				dpanhmgcbnl = JNBICAJIJMM.CDDCIKKDFMP("MotorbikeSeatStand") + "_Offsets" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 60f, 1901f, onkdcgnbalk.OCHCODJIPHJ.width - 828f, 838f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 22;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 632f - 1764f, 1456f, 1658f, 1793f), GameInterface.getI.achives, this.IBFLGDAMFOB, 2, 2);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 272f - 721f, 901f, 825f, 1920f), GameInterface.getI.achives, 0, 4, 0);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1774f, 181f, onkdcgnbalk.OCHCODJIPHJ.width - 97f, 1181f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 126;
			new LCOLJOPGDLL(onkdcgnbalk, 1835f, 787f, onkdcgnbalk.OCHCODJIPHJ.width - 1488f, 1843f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(749f, 1238f, 1017f)).DFIGKKMMIAF = 0;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(460f, 1712f, onkdcgnbalk.OCHCODJIPHJ.width - 553f, 530f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 6, "", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1741f, 871f, onkdcgnbalk.OCHCODJIPHJ.width - 1325f, 1467f, JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE(" cannot be used as a 3D LUT.") + "Dealer Shuffle" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(789f, 1852f, 624f));
			lcoljopgdll2.DFIGKKMMIAF = 54;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x003BE5C4 File Offset: 0x003BC7C4
		public void AFKGDAPPPLK(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 400f, JNBICAJIJMM.LEBHCLDODNI("ncht_ach1"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1f, 40f, onkdcgnbalk.OCHCODJIPHJ.width - 2f, onkdcgnbalk.OCHCODJIPHJ.height - 42f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 50f, onkdcgnbalk.OCHCODJIPHJ.height - 50f, 100f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
			string dpanhmgcbnl = "";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.LEBHCLDODNI("ncht_ach2") + "\n" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 2)
			{
				dpanhmgcbnl = JNBICAJIJMM.LEBHCLDODNI("ncht_ach3") + "\n" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 10f, 55f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, 80f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 22;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 2f - 32f, 110f, 64f, 64f), GameInterface.getI.achives, this.IBFLGDAMFOB, 8, 8);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 2f - 32f, 110f, 64f, 64f), GameInterface.getI.achives, 0, 8, 8);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 30f, 200f, onkdcgnbalk.OCHCODJIPHJ.width - 60f, 90f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 14;
			new LCOLJOPGDLL(onkdcgnbalk, 30f, 250f, onkdcgnbalk.OCHCODJIPHJ.width - 60f, 90f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(0f, 0f, 0.2f)).DFIGKKMMIAF = 14;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(20f, 270f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 20f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 4, "", true);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 30f, 300f, onkdcgnbalk.OCHCODJIPHJ.width - 60f, 90f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise") + "\n" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(0f, 0.2f, 0f));
			lcoljopgdll2.DFIGKKMMIAF = 14;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x003BE8E0 File Offset: 0x003BCAE0
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = COAGIAMOCIA.height - 4f;
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 15,
				font = GuiProcessor.IKGFHGKKCPG.rusfont3,
				wordWrap = true,
				richText = true
			};
			int ibflgdamfob = this.IBFLGDAMFOB;
			Rect position = new Rect(COAGIAMOCIA.x + 2f, COAGIAMOCIA.y + 2f, num, num);
			if (this.CBFKKMHOIKF == 2)
			{
				GUI.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
			}
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(ibflgdamfob, 8, 8));
			GUI.color = new Color(1f, 1f, 1f, 1f);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 8, 8));
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + 2f, COAGIAMOCIA.width - num - 16f, COAGIAMOCIA.height), this.KEIEIAAKHHK, guistyle);
			guistyle.fontSize = 13;
			guistyle.fontStyle = FontStyle.Italic;
			guistyle.normal.textColor = new Color(0f, 0f, 0.2f);
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			guistyle.alignment = TextAnchor.UpperLeft;
			if (this.CBFKKMHOIKF < 2)
			{
				guistyle.alignment = TextAnchor.MiddleCenter;
				Rect rect = new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + 26f, COAGIAMOCIA.width - num - 36f, 28f);
				GameInterface.getI.renderPBar(rect, (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 4, "", true);
				GUI.Label(rect, this.NELPNBJKNMJ.text, guistyle);
				return;
			}
			GUI.DrawTextureWithTexCoords(new Rect(position.x + num / 2f - 8f, position.y + num / 2f - 8f, 16f, 16f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(1, 4, 2));
			Rect position2 = new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + 20f, COAGIAMOCIA.width - num - 36f, 60f);
			guistyle.normal.textColor = new Color(0f, 0f, 0.2f);
			GUI.Label(position2, this.IFPKHIOOGOJ, guistyle);
			position2.y += 18f;
			guistyle.normal.textColor = new Color(0.2f, 0.3f, 0.2f);
			GUI.Label(position2, this.NELPNBJKNMJ.text, guistyle);
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x003BEBF0 File Offset: 0x003BCDF0
		public void NIHGOEIAKBO(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(383f, 1137f, JNBICAJIJMM.PPNKMDJBMLP("WallSit"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1011f, 1097f, onkdcgnbalk.OCHCODJIPHJ.width - 1468f, onkdcgnbalk.OCHCODJIPHJ.height - 356f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1474f - 616f, onkdcgnbalk.OCHCODJIPHJ.height - 695f, 1005f, 1632f, JNBICAJIJMM.DCEBAJIILPC("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().IBCKNOEANLN));
			string dpanhmgcbnl = "componentB";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.PGJCPFNJNPM("id") + "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 7)
			{
				dpanhmgcbnl = JNBICAJIJMM.DCEBAJIILPC("") + "isPaint" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 894f, 1227f, onkdcgnbalk.OCHCODJIPHJ.width - 804f, 552f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -120;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 709f - 1847f, 314f, 1982f, 179f), GameInterface.getI.achives, this.IBFLGDAMFOB, 8, 5);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 885f - 1573f, 256f, 838f, 292f), GameInterface.getI.achives, 1, 2, 0);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 286f, 1825f, onkdcgnbalk.OCHCODJIPHJ.width - 1183f, 1871f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 86;
			new LCOLJOPGDLL(onkdcgnbalk, 1022f, 600f, onkdcgnbalk.OCHCODJIPHJ.width - 1229f, 1428f, this.NELPNBJKNMJ.text, TextAnchor.UpperCenter, new Color(317f, 1670f, 243f)).DFIGKKMMIAF = -3;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1917f, 458f, onkdcgnbalk.OCHCODJIPHJ.width - 948f, 1402f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 7, "USE_CORNER_DETECTION", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 713f, 825f, onkdcgnbalk.OCHCODJIPHJ.width - 1723f, 824f, JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("ZombieIdle") + "UNDISTORT" + this.NELPNBJKNMJ.prise, TextAnchor.UpperCenter, new Color(470f, 1452f, 686f));
			lcoljopgdll2.DFIGKKMMIAF = -69;
			lcoljopgdll2.LNDPBNODFPE = false;
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x003BABF3 File Offset: 0x003B8DF3
		public virtual string DINGGHOCDNN()
		{
			return this.NELPNBJKNMJ.ToString();
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x003BEF0C File Offset: 0x003BD10C
		public void HLCGGFIJGAB(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1911f, 1814f, JNBICAJIJMM.CELEPPAEKAB("** dropAction checkPosition break"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(178f, 1253f, onkdcgnbalk.OCHCODJIPHJ.width - 1837f, onkdcgnbalk.OCHCODJIPHJ.height - 571f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 6f - 1323f, onkdcgnbalk.OCHCODJIPHJ.height - 370f, 302f, 1433f, JNBICAJIJMM.DIOJFJMOPJO("\n"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.ODBGHCIJOHA));
			string dpanhmgcbnl = "MotorbikeLookBack";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = JNBICAJIJMM.PGJCPFNJNPM("RollerBladeGrindRoyale") + "level" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 6)
			{
				dpanhmgcbnl = JNBICAJIJMM.PPNKMDJBMLP("DEPTH_OF_FIELD") + "Assets/Hairs/hair_" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 726f, 599f, onkdcgnbalk.OCHCODJIPHJ.width - 1208f, 163f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -42;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1792f - 600f, 417f, 1427f, 1167f), GameInterface.getI.achives, this.IBFLGDAMFOB, 6, 5);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1407f - 402f, 1821f, 701f, 1766f), GameInterface.getI.achives, 1, 6, 4);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1440f, 195f, onkdcgnbalk.OCHCODJIPHJ.width - 96f, 976f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = -24;
			new LCOLJOPGDLL(onkdcgnbalk, 224f, 1394f, onkdcgnbalk.OCHCODJIPHJ.width - 1197f, 719f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(1623f, 1049f, 1088f)).DFIGKKMMIAF = -54;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1902f, 14f, onkdcgnbalk.OCHCODJIPHJ.width - 563f, 1161f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 3, "selectedTask", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 943f, 1135f, onkdcgnbalk.OCHCODJIPHJ.width - 31f, 1626f, JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("demoUint") + "bool: " + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1762f, 294f, 292f));
			lcoljopgdll2.DFIGKKMMIAF = -72;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x003BF225 File Offset: 0x003BD425
		public virtual void INFOMNFHMIJ()
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("", 552f);
			this.JHBPMJCBLKG(1);
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x003BF244 File Offset: 0x003BD444
		public void NMPBDCMGCEE(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PJHMHBAGFAN(1501f, 956f, JNBICAJIJMM.PPNKMDJBMLP("CratePull"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(700f, 1556f, onkdcgnbalk.OCHCODJIPHJ.width - 1283f, onkdcgnbalk.OCHCODJIPHJ.height - 606f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1233f - 573f, onkdcgnbalk.OCHCODJIPHJ.height - 1571f, 1672f, 1097f, JNBICAJIJMM.BDKHMOOFHHK("{0:f3}"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
			string dpanhmgcbnl = "from friend";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.DCEBAJIILPC("WeaponRun") + "wpn_med2" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 5)
			{
				dpanhmgcbnl = JNBICAJIJMM.BDKHMOOFHHK("_OcclusionTexture") + "post_8" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 645f, 523f, onkdcgnbalk.OCHCODJIPHJ.width - 1157f, 277f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 27;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 689f - 796f, 742f, 185f, 583f), GameInterface.getI.achives, this.IBFLGDAMFOB, 5, 0);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1853f - 1090f, 1444f, 573f, 830f), GameInterface.getI.achives, 1, 2, 8);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 367f, 1833f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, 1536f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 116;
			new LCOLJOPGDLL(onkdcgnbalk, 1885f, 1130f, onkdcgnbalk.OCHCODJIPHJ.width - 329f, 1074f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(1874f, 592f, 311f)).DFIGKKMMIAF = 112;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(1815f, 423f, onkdcgnbalk.OCHCODJIPHJ.width - 573f, 67f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 8, "RunningDance", true);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1385f, 1089f, onkdcgnbalk.OCHCODJIPHJ.width - 1766f, 1414f, JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("MotorbikeShootFwd") + "Try Goscurry! Or better buy it!" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(1811f, 1999f, 1311f));
			lcoljopgdll2.DFIGKKMMIAF = 15;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x003BF560 File Offset: 0x003BD760
		public void JMFOCLLLJOG(int NFBDJNMPKCN)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().NCIDDNIKACI(1278f, 395f, JNBICAJIJMM.CELEPPAEKAB("WoodSaw"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1740f, 691f, onkdcgnbalk.OCHCODJIPHJ.width - 917f, onkdcgnbalk.OCHCODJIPHJ.height - 1848f), GameInterface.getI.blackPaper);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 826f - 199f, onkdcgnbalk.OCHCODJIPHJ.height - 831f, 371f, 371f, JNBICAJIJMM.DCEBAJIILPC("wpn_add/base"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
			string dpanhmgcbnl = "\n";
			if (NFBDJNMPKCN == 0)
			{
				dpanhmgcbnl = this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 1)
			{
				dpanhmgcbnl = JNBICAJIJMM.OOOKJHOHPNN("\n") + "BowInstant2" + this.KEIEIAAKHHK;
			}
			if (NFBDJNMPKCN == 7)
			{
				dpanhmgcbnl = JNBICAJIJMM.CELEPPAEKAB("ClimbLeft") + "Toe" + this.KEIEIAAKHHK;
			}
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1178f, 652f, onkdcgnbalk.OCHCODJIPHJ.width - 934f, 1957f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 8;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 458f - 288f, 1319f, 1275f, 1469f), GameInterface.getI.achives, this.IBFLGDAMFOB, 8, 2);
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 848f - 1532f, 1105f, 1013f, 329f), GameInterface.getI.achives, 1, 5, 1);
			dpanhmgcbnl = this.IFPKHIOOGOJ;
			new LCOLJOPGDLL(onkdcgnbalk, 1871f, 269f, onkdcgnbalk.OCHCODJIPHJ.width - 1796f, 1748f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = -121;
			new LCOLJOPGDLL(onkdcgnbalk, 1360f, 820f, onkdcgnbalk.OCHCODJIPHJ.width - 962f, 1800f, this.NELPNBJKNMJ.text, TextAnchor.UpperLeft, new Color(1155f, 1581f, 1216f)).DFIGKKMMIAF = 69;
			new GMNEKCBLIAN(onkdcgnbalk, new Rect(23f, 1782f, onkdcgnbalk.OCHCODJIPHJ.width - 977f, 1849f), (float)this.GIPKHILLHCP, (float)this.NELPNBJKNMJ.maxcount, 6, "MotorbikeShootFwd", false);
			LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1556f, 902f, onkdcgnbalk.OCHCODJIPHJ.width - 520f, 188f, JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("_DistortParams") + "CraftProf.xml" + this.NELPNBJKNMJ.prise, TextAnchor.UpperLeft, new Color(253f, 1952f, 538f));
			lcoljopgdll2.DFIGKKMMIAF = 22;
			lcoljopgdll2.LNDPBNODFPE = true;
		}

		// Token: 0x040011FA RID: 4602
		public int IBFLGDAMFOB;

		// Token: 0x040011FB RID: 4603
		public int CBFKKMHOIKF;

		// Token: 0x040011FC RID: 4604
		public int GIPKHILLHCP;

		// Token: 0x040011FD RID: 4605
		public string KEIEIAAKHHK = "---";

		// Token: 0x040011FE RID: 4606
		public string IFPKHIOOGOJ = "---";

		// Token: 0x040011FF RID: 4607
		public DODHLMFHFNL.QTask NELPNBJKNMJ;
	}

	// Token: 0x0200021B RID: 539
	[Serializable]
	public class QTask : ItemBase, IComparable<DODHLMFHFNL.QTask>
	{
		// Token: 0x06007B9B RID: 31643 RVA: 0x003BF87C File Offset: 0x003BDA7C
		public void LBINIIGHCMG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.CLPEKGGAMAI();
			this.catid = KADBECGIMPD.AGNKAFLKCAG();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.AGNKAFLKCAG();
			this.wpfishid = KADBECGIMPD.AGNKAFLKCAG();
			this.baitid = KADBECGIMPD.LDLKLPJBIJN();
			this.maxcount = KADBECGIMPD.LDLKLPJBIJN();
			this.minwgt = KADBECGIMPD.CLPEKGGAMAI();
			this.maxwgt = KADBECGIMPD.KDNDJNEGBDI();
			this.baseid = KADBECGIMPD.IFDFHJLCHAE();
			this.locid = KADBECGIMPD.HHLDBAEFNMJ();
			this.currcount = KADBECGIMPD.AGNKAFLKCAG();
			this.isTimed = KADBECGIMPD.ELDBJFLCMAJ();
			this.toTime = KADBECGIMPD.NIIFLPIEMFM();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.JJJJAGJCOGD());
			this.taskLang = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EKEBHIJMEML().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x003BF998 File Offset: 0x003BDB98
		public void DLANACEPJHB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.CLPEKGGAMAI();
			this.catid = KADBECGIMPD.KDNDJNEGBDI();
			this.taskid = KADBECGIMPD.KKOKFLMMAAK();
			this.status = KADBECGIMPD.IFDFHJLCHAE();
			this.wpfishid = KADBECGIMPD.DOJKJHMJJNK();
			this.baitid = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxcount = KADBECGIMPD.KDNDJNEGBDI();
			this.minwgt = KADBECGIMPD.KDNDJNEGBDI();
			this.maxwgt = KADBECGIMPD.KKOKFLMMAAK();
			this.baseid = KADBECGIMPD.AGNKAFLKCAG();
			this.locid = KADBECGIMPD.DOJKJHMJJNK();
			this.currcount = KADBECGIMPD.DOJKJHMJJNK();
			this.isTimed = KADBECGIMPD.JALHMJEKMHF();
			this.toTime = KADBECGIMPD.OODOKDPIMOF();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DPLAJNEDGBL());
			this.taskLang = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.IKGFHGKKCPG.deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
		public int FHDCLBFHPOK(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x003BFAD7 File Offset: 0x003BDCD7
		public int DBMHBKLIEKE(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 1;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06007B9F RID: 31647 RVA: 0x003BFAFC File Offset: 0x003BDCFC
		public void MBJKBKOLBKE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.LDLKLPJBIJN();
			this.catid = KADBECGIMPD.IFDFHJLCHAE();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.CLPEKGGAMAI();
			this.wpfishid = KADBECGIMPD.LDLKLPJBIJN();
			this.baitid = KADBECGIMPD.AGNKAFLKCAG();
			this.maxcount = KADBECGIMPD.AGNKAFLKCAG();
			this.minwgt = KADBECGIMPD.IFDFHJLCHAE();
			this.maxwgt = KADBECGIMPD.CLPEKGGAMAI();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.locid = KADBECGIMPD.KKOKFLMMAAK();
			this.currcount = KADBECGIMPD.AGNKAFLKCAG();
			this.isTimed = KADBECGIMPD.ELDBJFLCMAJ();
			this.toTime = KADBECGIMPD.FCGGODFGMCB();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DHCMILPKJAL());
			this.taskLang = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.IKGFHGKKCPG.deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x003BFC18 File Offset: 0x003BDE18
		public virtual void AGNMECAOOJI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1071f, 1898f), GameInterface.getI.qtIcons, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.status, 6, 0));
			COAGIAMOCIA.x += 639f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x003BFC84 File Offset: 0x003BDE84
		public virtual void JHAKFEGIANH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1322f, 415f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.status, 1, 4));
			COAGIAMOCIA.x += 186f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x003BFCF0 File Offset: 0x003BDEF0
		public virtual void ODCJPHBLBBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1281f, 1968f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.status, 5, 8));
			COAGIAMOCIA.x += 1632f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x003BFD5C File Offset: 0x003BDF5C
		public virtual string OCJAOJLHOFO()
		{
			string arg = "WeaponStand";
			if (this.status == 0)
			{
				arg = "BipedReferences eye bone at index ";
			}
			if (this.status == 0)
			{
				arg = " ";
			}
			if (this.status == 7)
			{
				arg = "Speed";
			}
			return string.Format("_ReflectionBlur", arg, this.text);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x003BFDAC File Offset: 0x003BDFAC
		public void LBBBADCPGOI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.KKOKFLMMAAK();
			this.catid = KADBECGIMPD.KKOKFLMMAAK();
			this.taskid = KADBECGIMPD.LDLKLPJBIJN();
			this.status = KADBECGIMPD.KDNDJNEGBDI();
			this.wpfishid = KADBECGIMPD.LDLKLPJBIJN();
			this.baitid = KADBECGIMPD.AGNKAFLKCAG();
			this.maxcount = KADBECGIMPD.CLPEKGGAMAI();
			this.minwgt = KADBECGIMPD.DOJKJHMJJNK();
			this.maxwgt = KADBECGIMPD.AGNKAFLKCAG();
			this.baseid = KADBECGIMPD.LDLKLPJBIJN();
			this.locid = KADBECGIMPD.IFDFHJLCHAE();
			this.currcount = KADBECGIMPD.IFDFHJLCHAE();
			this.isTimed = KADBECGIMPD.IOEEPNCKLJD();
			this.toTime = KADBECGIMPD.NIIFLPIEMFM();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.taskLang = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.IKGFHGKKCPG.deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x003BFEC8 File Offset: 0x003BE0C8
		public void LFOPENOJDIM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.LDLKLPJBIJN();
			this.catid = KADBECGIMPD.AGNKAFLKCAG();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.AGNKAFLKCAG();
			this.wpfishid = KADBECGIMPD.LDLKLPJBIJN();
			this.baitid = KADBECGIMPD.AGNKAFLKCAG();
			this.maxcount = KADBECGIMPD.HDBGOLAFOBK();
			this.minwgt = KADBECGIMPD.HDBGOLAFOBK();
			this.maxwgt = KADBECGIMPD.DOJKJHMJJNK();
			this.baseid = KADBECGIMPD.CLPEKGGAMAI();
			this.locid = KADBECGIMPD.KDNDJNEGBDI();
			this.currcount = KADBECGIMPD.IFDFHJLCHAE();
			this.isTimed = KADBECGIMPD.DADCGPGEHFK();
			this.toTime = KADBECGIMPD.OJNFAHFAKDO();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.KDELAFDDGJH());
			this.taskLang = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.KOJCECHBHLO().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x003BFFE4 File Offset: 0x003BE1E4
		public void MPMELFMBFAN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.KKOKFLMMAAK();
			this.catid = KADBECGIMPD.HDBGOLAFOBK();
			this.taskid = KADBECGIMPD.DOJKJHMJJNK();
			this.status = KADBECGIMPD.DOJKJHMJJNK();
			this.wpfishid = KADBECGIMPD.HDBGOLAFOBK();
			this.baitid = KADBECGIMPD.AGNKAFLKCAG();
			this.maxcount = KADBECGIMPD.IFDFHJLCHAE();
			this.minwgt = KADBECGIMPD.AGNKAFLKCAG();
			this.maxwgt = KADBECGIMPD.IFDFHJLCHAE();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.locid = KADBECGIMPD.KDNDJNEGBDI();
			this.currcount = KADBECGIMPD.IFDFHJLCHAE();
			this.isTimed = KADBECGIMPD.BEMFIFGOJBL();
			this.toTime = KADBECGIMPD.HGFHMFMNIEI();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.KDELAFDDGJH());
			this.taskLang = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EKEBHIJMEML().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x003C0100 File Offset: 0x003BE300
		public virtual string FBENMKABKKB()
		{
			string arg = "The object '{0}' has a ProBuilder attachment component which contains zero attached elements.";
			if (this.status == 0)
			{
				arg = "";
			}
			if (this.status == 1)
			{
				arg = "fshop_hd3";
			}
			if (this.status == 2)
			{
				arg = "bool: ";
			}
			return string.Format("paper.wav", arg, this.text);
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x003C0150 File Offset: 0x003BE350
		public void PACODAINDCD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.LDLKLPJBIJN();
			this.catid = KADBECGIMPD.HDBGOLAFOBK();
			this.taskid = KADBECGIMPD.AGNKAFLKCAG();
			this.status = KADBECGIMPD.IFDFHJLCHAE();
			this.wpfishid = KADBECGIMPD.DOJKJHMJJNK();
			this.baitid = KADBECGIMPD.KDNDJNEGBDI();
			this.maxcount = KADBECGIMPD.IFDFHJLCHAE();
			this.minwgt = KADBECGIMPD.IFDFHJLCHAE();
			this.maxwgt = KADBECGIMPD.AGNKAFLKCAG();
			this.baseid = KADBECGIMPD.HHLDBAEFNMJ();
			this.locid = KADBECGIMPD.AGNKAFLKCAG();
			this.currcount = KADBECGIMPD.CLPEKGGAMAI();
			this.isTimed = KADBECGIMPD.FIFNOBGEKFF();
			this.toTime = KADBECGIMPD.FCGGODFGMCB();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.FDIDEGHPJPF());
			this.taskLang = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EPCKOOOGNGK().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x003C026C File Offset: 0x003BE46C
		public void NJOCHFIPEBI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.HDBGOLAFOBK();
			this.catid = KADBECGIMPD.KKOKFLMMAAK();
			this.taskid = KADBECGIMPD.KDNDJNEGBDI();
			this.status = KADBECGIMPD.CLPEKGGAMAI();
			this.wpfishid = KADBECGIMPD.DOJKJHMJJNK();
			this.baitid = KADBECGIMPD.AGNKAFLKCAG();
			this.maxcount = KADBECGIMPD.AGNKAFLKCAG();
			this.minwgt = KADBECGIMPD.KKOKFLMMAAK();
			this.maxwgt = KADBECGIMPD.KKOKFLMMAAK();
			this.baseid = KADBECGIMPD.KKOKFLMMAAK();
			this.locid = KADBECGIMPD.KKOKFLMMAAK();
			this.currcount = KADBECGIMPD.IFDFHJLCHAE();
			this.isTimed = KADBECGIMPD.IJJDHHFAIPE();
			this.toTime = KADBECGIMPD.PFKHMDDOHDN();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.PNBECHOLCJM());
			this.taskLang = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.BOBNPEAEECC().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x003C0388 File Offset: 0x003BE588
		public override void PFECLGBDGNH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1040f, 1976f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.status, 4, 6));
			COAGIAMOCIA.x += 729f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x003C03F4 File Offset: 0x003BE5F4
		public virtual void DEGJHBEBGMA(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1941f, 946f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.status, 3, 5));
			COAGIAMOCIA.x += 375f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x003C0460 File Offset: 0x003BE660
		public void KKLMGOBGMHD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.KDNDJNEGBDI();
			this.catid = KADBECGIMPD.CLPEKGGAMAI();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.IFDFHJLCHAE();
			this.wpfishid = KADBECGIMPD.HHLDBAEFNMJ();
			this.baitid = KADBECGIMPD.IFDFHJLCHAE();
			this.maxcount = KADBECGIMPD.IFDFHJLCHAE();
			this.minwgt = KADBECGIMPD.LDLKLPJBIJN();
			this.maxwgt = KADBECGIMPD.IFDFHJLCHAE();
			this.baseid = KADBECGIMPD.LDLKLPJBIJN();
			this.locid = KADBECGIMPD.LDLKLPJBIJN();
			this.currcount = KADBECGIMPD.KKOKFLMMAAK();
			this.isTimed = KADBECGIMPD.BEMFIFGOJBL();
			this.toTime = KADBECGIMPD.MILGIGJBAJL();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.NCODBGMGNFD());
			this.taskLang = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EKEBHIJMEML().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x003BFAD7 File Offset: 0x003BDCD7
		public int CompareTo(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 1;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x003C057C File Offset: 0x003BE77C
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 16f, 16f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.status, 4, 2));
			COAGIAMOCIA.x += 18f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x003C05E8 File Offset: 0x003BE7E8
		public void IHONANEEDOC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.KDNDJNEGBDI();
			this.catid = KADBECGIMPD.KKOKFLMMAAK();
			this.taskid = KADBECGIMPD.DOJKJHMJJNK();
			this.status = KADBECGIMPD.IFDFHJLCHAE();
			this.wpfishid = KADBECGIMPD.KDNDJNEGBDI();
			this.baitid = KADBECGIMPD.HDBGOLAFOBK();
			this.maxcount = KADBECGIMPD.DOJKJHMJJNK();
			this.minwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxwgt = KADBECGIMPD.LDLKLPJBIJN();
			this.baseid = KADBECGIMPD.DOJKJHMJJNK();
			this.locid = KADBECGIMPD.IFDFHJLCHAE();
			this.currcount = KADBECGIMPD.KKOKFLMMAAK();
			this.isTimed = KADBECGIMPD.OMCMPDMJFOJ();
			this.toTime = KADBECGIMPD.MILGIGJBAJL();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DPLAJNEDGBL());
			this.taskLang = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.BOBNPEAEECC().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x003C0704 File Offset: 0x003BE904
		public void MCIKLDBPPFJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.LDLKLPJBIJN();
			this.catid = KADBECGIMPD.LDLKLPJBIJN();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.KDNDJNEGBDI();
			this.wpfishid = KADBECGIMPD.HHLDBAEFNMJ();
			this.baitid = KADBECGIMPD.DOJKJHMJJNK();
			this.maxcount = KADBECGIMPD.DOJKJHMJJNK();
			this.minwgt = KADBECGIMPD.HDBGOLAFOBK();
			this.maxwgt = KADBECGIMPD.HDBGOLAFOBK();
			this.baseid = KADBECGIMPD.IFDFHJLCHAE();
			this.locid = KADBECGIMPD.LDLKLPJBIJN();
			this.currcount = KADBECGIMPD.LDLKLPJBIJN();
			this.isTimed = KADBECGIMPD.DADCGPGEHFK();
			this.toTime = KADBECGIMPD.NIIFLPIEMFM();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.FDIDEGHPJPF());
			this.taskLang = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.BOBNPEAEECC().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
		public int EBLKHOOABEK(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x003C0820 File Offset: 0x003BEA20
		public void PJJDAALHOHH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.HHLDBAEFNMJ();
			this.catid = KADBECGIMPD.HHLDBAEFNMJ();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.DOJKJHMJJNK();
			this.wpfishid = KADBECGIMPD.KKOKFLMMAAK();
			this.baitid = KADBECGIMPD.KDNDJNEGBDI();
			this.maxcount = KADBECGIMPD.IFDFHJLCHAE();
			this.minwgt = KADBECGIMPD.DOJKJHMJJNK();
			this.maxwgt = KADBECGIMPD.CLPEKGGAMAI();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.locid = KADBECGIMPD.KKOKFLMMAAK();
			this.currcount = KADBECGIMPD.IFDFHJLCHAE();
			this.isTimed = KADBECGIMPD.DADCGPGEHFK();
			this.toTime = KADBECGIMPD.MLFLLBPGFIJ();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DPLAJNEDGBL());
			this.taskLang = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EPCKOOOGNGK().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x003C093C File Offset: 0x003BEB3C
		public int OLDHCPFECDK(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x003C0960 File Offset: 0x003BEB60
		public void ONIJHKMCCHH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.AGNKAFLKCAG();
			this.catid = KADBECGIMPD.IFDFHJLCHAE();
			this.taskid = KADBECGIMPD.IFDFHJLCHAE();
			this.status = KADBECGIMPD.LDLKLPJBIJN();
			this.wpfishid = KADBECGIMPD.HDBGOLAFOBK();
			this.baitid = KADBECGIMPD.CLPEKGGAMAI();
			this.maxcount = KADBECGIMPD.IFDFHJLCHAE();
			this.minwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.baseid = KADBECGIMPD.KDNDJNEGBDI();
			this.locid = KADBECGIMPD.HDBGOLAFOBK();
			this.currcount = KADBECGIMPD.AGNKAFLKCAG();
			this.isTimed = KADBECGIMPD.IJJDHHFAIPE();
			this.toTime = KADBECGIMPD.MLFLLBPGFIJ();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.LPKJHMGLCKA());
			this.taskLang = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.IKGFHGKKCPG.deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x003C0A7C File Offset: 0x003BEC7C
		public void EFGBDBAOFCJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.HHLDBAEFNMJ();
			this.catid = KADBECGIMPD.HDBGOLAFOBK();
			this.taskid = KADBECGIMPD.DOJKJHMJJNK();
			this.status = KADBECGIMPD.AGNKAFLKCAG();
			this.wpfishid = KADBECGIMPD.CLPEKGGAMAI();
			this.baitid = KADBECGIMPD.HDBGOLAFOBK();
			this.maxcount = KADBECGIMPD.AGNKAFLKCAG();
			this.minwgt = KADBECGIMPD.KKOKFLMMAAK();
			this.maxwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.baseid = KADBECGIMPD.LDLKLPJBIJN();
			this.locid = KADBECGIMPD.DOJKJHMJJNK();
			this.currcount = KADBECGIMPD.KDNDJNEGBDI();
			this.isTimed = KADBECGIMPD.JNOKJCDAPPA();
			this.toTime = KADBECGIMPD.MLFLLBPGFIJ();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.PNBECHOLCJM());
			this.taskLang = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.EPCKOOOGNGK().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x003C0B98 File Offset: 0x003BED98
		public void OCPAHLAGCAI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.HDBGOLAFOBK();
			this.catid = KADBECGIMPD.HDBGOLAFOBK();
			this.taskid = KADBECGIMPD.HDBGOLAFOBK();
			this.status = KADBECGIMPD.HDBGOLAFOBK();
			this.wpfishid = KADBECGIMPD.HDBGOLAFOBK();
			this.baitid = KADBECGIMPD.HDBGOLAFOBK();
			this.maxcount = KADBECGIMPD.HDBGOLAFOBK();
			this.minwgt = KADBECGIMPD.HDBGOLAFOBK();
			this.maxwgt = KADBECGIMPD.HDBGOLAFOBK();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.locid = KADBECGIMPD.HDBGOLAFOBK();
			this.currcount = KADBECGIMPD.HDBGOLAFOBK();
			this.isTimed = KADBECGIMPD.FIFNOBGEKFF();
			this.toTime = KADBECGIMPD.IKJAOHGGCJD();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.taskLang = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.IKGFHGKKCPG.deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x003C0CB4 File Offset: 0x003BEEB4
		public int JPEELIIOHGB(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 1;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x003C0CD8 File Offset: 0x003BEED8
		public virtual string DFHAGGBIEIH()
		{
			string arg = "\n";
			if (this.status == 0)
			{
				arg = "MidBlendLut";
			}
			if (this.status == 1)
			{
				arg = "pt_setok";
			}
			if (this.status == 6)
			{
				arg = "ok";
			}
			return string.Format("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта", arg, this.text);
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
		public int GKELMEHONGL(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x003C0D28 File Offset: 0x003BEF28
		public virtual string FEIJPDKNKKG()
		{
			string arg = "S ";
			if (this.status == 0)
			{
				arg = "WallSit";
			}
			if (this.status == 0)
			{
				arg = "\n";
			}
			if (this.status == 2)
			{
				arg = "fishsplash2.ogg";
			}
			return string.Format("", arg, this.text);
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x003C0D78 File Offset: 0x003BEF78
		public virtual string JDPKKGOOKDF()
		{
			string arg = "FlyForward";
			if (this.status == 0)
			{
				arg = "colorA";
			}
			if (this.status == 0)
			{
				arg = "Perks.xml";
			}
			if (this.status == 6)
			{
				arg = "gameComplete";
			}
			return string.Format("name", arg, this.text);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
		public int OJJBPNAKBBB(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x003C0DC8 File Offset: 0x003BEFC8
		public virtual void DPFHNFGPOAH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1964f, 715f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.status, 7, 1));
			COAGIAMOCIA.x += 804f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x003C0E34 File Offset: 0x003BF034
		public virtual void IFEJHHNJJJJ(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1015f, 1875f), GameInterface.getI.qtIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.status, 3, 8));
			COAGIAMOCIA.x += 228f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x003C0EA0 File Offset: 0x003BF0A0
		public virtual void OEDCMOEEKPL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1827f, 1190f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.status, 7, 3));
			COAGIAMOCIA.x += 529f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x003C0F0C File Offset: 0x003BF10C
		public virtual void MFIGNCDAALM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 286f, 1264f), GameInterface.getI.qtIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.status, 4, 6));
			COAGIAMOCIA.x += 1208f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x003C0F78 File Offset: 0x003BF178
		public virtual void GJGBFPIEGEP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			GUI.DrawTextureWithTexCoords(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, 1987f, 442f), GameInterface.getI.qtIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.status, 8, 5));
			COAGIAMOCIA.x += 1483f;
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x003C0FE4 File Offset: 0x003BF1E4
		public virtual string KCBJCGOINMK()
		{
			string arg = "RandomizeObscuredVars";
			if (this.status == 0)
			{
				arg = "_SampleMip";
			}
			if (this.status == 0)
			{
				arg = "error";
			}
			if (this.status == 4)
			{
				arg = "_isSelect";
			}
			return string.Format("StrafeRunLeft", arg, this.text);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x003C093C File Offset: 0x003BEB3C
		public int KNLLNMKCEBC(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x003C1034 File Offset: 0x003BF234
		public void OLGEDIFBGNL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.DOJKJHMJJNK();
			this.catid = KADBECGIMPD.HDBGOLAFOBK();
			this.taskid = KADBECGIMPD.HHLDBAEFNMJ();
			this.status = KADBECGIMPD.KKOKFLMMAAK();
			this.wpfishid = KADBECGIMPD.AGNKAFLKCAG();
			this.baitid = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxcount = KADBECGIMPD.KKOKFLMMAAK();
			this.minwgt = KADBECGIMPD.AGNKAFLKCAG();
			this.maxwgt = KADBECGIMPD.DOJKJHMJJNK();
			this.baseid = KADBECGIMPD.KDNDJNEGBDI();
			this.locid = KADBECGIMPD.HHLDBAEFNMJ();
			this.currcount = KADBECGIMPD.DOJKJHMJJNK();
			this.isTimed = KADBECGIMPD.IOEEPNCKLJD();
			this.toTime = KADBECGIMPD.HGFHMFMNIEI();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.PNBECHOLCJM());
			this.taskLang = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.BOBNPEAEECC().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x003C1150 File Offset: 0x003BF350
		public void AGADBLDMILO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.DOJKJHMJJNK();
			this.catid = KADBECGIMPD.DOJKJHMJJNK();
			this.taskid = KADBECGIMPD.HHLDBAEFNMJ();
			this.status = KADBECGIMPD.LDLKLPJBIJN();
			this.wpfishid = KADBECGIMPD.CLPEKGGAMAI();
			this.baitid = KADBECGIMPD.CLPEKGGAMAI();
			this.maxcount = KADBECGIMPD.AGNKAFLKCAG();
			this.minwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxwgt = KADBECGIMPD.CLPEKGGAMAI();
			this.baseid = KADBECGIMPD.KKOKFLMMAAK();
			this.locid = KADBECGIMPD.HHLDBAEFNMJ();
			this.currcount = KADBECGIMPD.DOJKJHMJJNK();
			this.isTimed = KADBECGIMPD.DADCGPGEHFK();
			this.toTime = KADBECGIMPD.MLFLLBPGFIJ();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DHCMILPKJAL());
			this.taskLang = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.JHOJIFOOPOH(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.KOJCECHBHLO().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x003C126C File Offset: 0x003BF46C
		public void DFANMIPGKIP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.type = KADBECGIMPD.HDBGOLAFOBK();
			this.catid = KADBECGIMPD.KDNDJNEGBDI();
			this.taskid = KADBECGIMPD.CLPEKGGAMAI();
			this.status = KADBECGIMPD.IFDFHJLCHAE();
			this.wpfishid = KADBECGIMPD.HDBGOLAFOBK();
			this.baitid = KADBECGIMPD.KDNDJNEGBDI();
			this.maxcount = KADBECGIMPD.HDBGOLAFOBK();
			this.minwgt = KADBECGIMPD.HHLDBAEFNMJ();
			this.maxwgt = KADBECGIMPD.DOJKJHMJJNK();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.locid = KADBECGIMPD.HDBGOLAFOBK();
			this.currcount = KADBECGIMPD.KDNDJNEGBDI();
			this.isTimed = KADBECGIMPD.ELDBJFLCMAJ();
			this.toTime = KADBECGIMPD.NIIFLPIEMFM();
			this.prise = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.JJJJAGJCOGD());
			this.taskLang = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.GFGOHOFBLKL(this.catid, this.taskid);
			try
			{
				this.toTime -= TimeController.BOBNPEAEECC().deltaTime;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x003C1388 File Offset: 0x003BF588
		public override string ToString()
		{
			string arg = "#000000";
			if (this.status == 0)
			{
				arg = "#000000";
			}
			if (this.status == 1)
			{
				arg = "#004000";
			}
			if (this.status == 2)
			{
				arg = "#400000";
			}
			return string.Format("<size=12><color='{0}'>{1}</color></size>", arg, this.text);
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x003C0CB4 File Offset: 0x003BEEB4
		public int KKKOAOIPBJD(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 1;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x003C093C File Offset: 0x003BEB3C
		public int MHGBHCJHLGF(DODHLMFHFNL.QTask INDANOPGHCN)
		{
			if (this.inid > INDANOPGHCN.inid)
			{
				return 0;
			}
			if (this.inid < INDANOPGHCN.inid)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x04001200 RID: 4608
		public long inid;

		// Token: 0x04001201 RID: 4609
		public int type;

		// Token: 0x04001202 RID: 4610
		public int catid;

		// Token: 0x04001203 RID: 4611
		public int taskid;

		// Token: 0x04001204 RID: 4612
		public int wpfishid;

		// Token: 0x04001205 RID: 4613
		public int baitid;

		// Token: 0x04001206 RID: 4614
		public int maxcount;

		// Token: 0x04001207 RID: 4615
		public int currcount;

		// Token: 0x04001208 RID: 4616
		public int baseid;

		// Token: 0x04001209 RID: 4617
		public int locid;

		// Token: 0x0400120A RID: 4618
		public int minwgt;

		// Token: 0x0400120B RID: 4619
		public int maxwgt;

		// Token: 0x0400120C RID: 4620
		public int status;

		// Token: 0x0400120D RID: 4621
		public new string text;

		// Token: 0x0400120E RID: 4622
		public DODHLMFHFNL.HLEJNFDEHOG taskLang;

		// Token: 0x0400120F RID: 4623
		public EJDGMNEEOGN.EMOEAOFEKCO prise;

		// Token: 0x04001210 RID: 4624
		public bool isTimed;

		// Token: 0x04001211 RID: 4625
		public DateTime toTime;
	}
}
