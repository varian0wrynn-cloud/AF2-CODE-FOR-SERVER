using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Steamworks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

// Token: 0x0200020B RID: 523
public class EMJAJDNLEJN
{
	// Token: 0x06007904 RID: 30980 RVA: 0x0039B2F4 File Offset: 0x003994F4
	public void FIDCELLHJIH(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		try
		{
			HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
			try
			{
				NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
				if (ELEMIPMLIGG <= 710)
				{
					if (ELEMIPMLIGG <= 285)
					{
						if (ELEMIPMLIGG <= 235)
						{
							if (ELEMIPMLIGG <= 210)
							{
								if (ELEMIPMLIGG <= 198)
								{
									switch (ELEMIPMLIGG)
									{
									case 1:
										OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(1, true).LELPDGJGLJF(hbpnmngofma);
										goto IL_3C32;
									case 2:
										OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(1, true).BFDCJHPDJDJ(hbpnmngofma);
										goto IL_3C32;
									case 3:
										OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(1, true).CNIBNDBFFDO(hbpnmngofma);
										goto IL_3C32;
									case 4:
									case 8:
									case 9:
									case 10:
									case 11:
									case 13:
									case 14:
									case 17:
									case 20:
									case 22:
									case 23:
									case 31:
									case 33:
									case 34:
									case 35:
									case 36:
									case 37:
									case 38:
									case 39:
									case 41:
									case 42:
									case 43:
									case 44:
									case 46:
									case 49:
									case 51:
									case 52:
									case 53:
									case 54:
									case 55:
									case 56:
									case 57:
									case 58:
									case 59:
									case 61:
									case 62:
									case 63:
									case 64:
									case 65:
									case 66:
									case 67:
									case 68:
									case 69:
									case 71:
									case 73:
									case 80:
									case 84:
									case 88:
									case 89:
									case 93:
									case 95:
									case 97:
									case 114:
									case 117:
									case 118:
									case 119:
									case 121:
									case 122:
									case 123:
									case 124:
									case 127:
									case 128:
									case 129:
									case 133:
									case 136:
									case 137:
									case 138:
									case 139:
									case 140:
									case 142:
									case 143:
									case 144:
									case 146:
									case 147:
									case 148:
									case 149:
									case 152:
									case 153:
									case 154:
									case 156:
									case 163:
									case 164:
									case 165:
									case 169:
									case 170:
									case 171:
									case 172:
									case 176:
									case 177:
									case 182:
									case 183:
									case 184:
									case 185:
									case 189:
										break;
									case 5:
										FlyMessageManager.getI.otherFishTrapped(hbpnmngofma);
										goto IL_3C32;
									case 6:
										ActorMgr.getI.fishMsgDin(hbpnmngofma);
										goto IL_3C32;
									case 7:
									{
										hbpnmngofma.HDBGOLAFOBK();
										hbpnmngofma.HDBGOLAFOBK();
										int lpfkfnlhgbi = hbpnmngofma.HDBGOLAFOBK();
										int num = hbpnmngofma.HDBGOLAFOBK();
										BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
										if (befchfngomi != null)
										{
											string iabkgmnjljo = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg5"), befchfngomi.JPBOPFNPNHC(true, -1), num);
											FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.green, 0, 0);
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 12:
									{
										hbpnmngofma.HDBGOLAFOBK();
										int num2 = hbpnmngofma.HDBGOLAFOBK();
										string iabkgmnjljo2 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg6"), num2 * 10);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo2);
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo2, Color.red, 0, 0);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("SysAlert.wav", 1f);
										goto IL_3C32;
									}
									case 15:
										if (kfhelhglnmh != null)
										{
											kfhelhglnmh.GCAGHAPNNPD(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									case 16:
										JBEHMPDDMME.IKGFHGKKCPG.BJPJPFDOKDL = true;
										goto IL_3C32;
									case 18:
									{
										OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.NHBGDHECDKM(hbpnmngofma);
										if (edpnahlghpl.MODEOKGGDBD && edpnahlghpl.EFFAHDKPOJA)
										{
											string iabkgmnjljo3 = string.Format(JNBICAJIJMM.LEBHCLDODNI("frnd_ingame"), edpnahlghpl.BNIHFBMEPAB);
											FlyMessageManager.getI.addRightMessageColored(iabkgmnjljo3, Color.green);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 19:
									{
										OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(2, true);
										if (lnhmfjdmokp != null)
										{
											lnhmfjdmokp.LELPDGJGLJF(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 21:
									{
										long num3 = hbpnmngofma.DNIIFBAIPBE();
										long num4 = hbpnmngofma.DNIIFBAIPBE();
										long kknekaejlam = hbpnmngofma.DNIIFBAIPBE();
										long kfodjjihnhp = hbpnmngofma.DNIIFBAIPBE();
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
										{
											JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP = kfodjjihnhp;
											JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM = kknekaejlam;
										}
										string str = "<color='#80ff00'>+ </color>";
										if (num4 < 0L || num3 < 0L)
										{
											str = "<color='#ff8000'>- </color>";
											num4 = (long)Mathf.Abs((float)num4);
											num3 = (long)Mathf.Abs((float)num3);
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cash.ogg", 0.5f);
										}
										else
										{
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("money2.wav", 0.5f);
										}
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(str + JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(num3, num4, true));
										goto IL_3C32;
									}
									case 24:
										OAFJCFOGGAF.IKGFHGKKCPG.LIJACMODLFA(hbpnmngofma);
										goto IL_3C32;
									case 25:
									{
										string odmiondmckf = hbpnmngofma.BFPHBMDMODH();
										int naeplckljdn = hbpnmngofma.HDBGOLAFOBK();
										OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(odmiondmckf, naeplckljdn).LELPDGJGLJF(hbpnmngofma);
										goto IL_3C32;
									}
									case 26:
									{
										string odmiondmckf2 = hbpnmngofma.BFPHBMDMODH();
										hbpnmngofma.HDBGOLAFOBK();
										OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(odmiondmckf2, 2).BFDCJHPDJDJ(hbpnmngofma);
										goto IL_3C32;
									}
									case 27:
										OAFJCFOGGAF.IKGFHGKKCPG.DHKLMJADOOJ(hbpnmngofma);
										goto IL_3C32;
									case 28:
									{
										BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
										if (diggohpgcnn.OKEBIHBDEOO("ok"))
										{
											FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_tofrendmsg"), Color.green, 0, 0);
										}
										if (diggohpgcnn.OKEBIHBDEOO("already_exist"))
										{
											FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_ae"), Color.red, 0, 0);
										}
										if (diggohpgcnn.OKEBIHBDEOO("more"))
										{
											FlyMessageManager.getI.addMessageBig(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_maxcnt"), diggohpgcnn.IEIMMFODGFG), Color.red, 0, 0);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 29:
									{
										BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
										if (diggohpgcnn2.OKEBIHBDEOO("ok"))
										{
											FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_delfrendmsg"), Color.green, 0, 0);
											OAFJCFOGGAF.IKGFHGKKCPG.MJOGPKOJODA(diggohpgcnn2.DLJNOCONOJO);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 30:
										kfhelhglnmh.HHFLGLHGHFJ(hbpnmngofma);
										GameInterface.getI.openUserData(3, hbpnmngofma);
										goto IL_3C32;
									case 32:
										GameInterface.getI.openUserData(1, hbpnmngofma);
										goto IL_3C32;
									case 40:
										GameInterface.getI.openUserData(7, hbpnmngofma);
										goto IL_3C32;
									case 45:
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										hbpnmngofma.BFPHBMDMODH();
										HMKIBAFDFDJ.IKGFHGKKCPG.BCCOGADEDDO(hbpnmngofma);
										goto IL_3C32;
									case 47:
									{
										long num5 = hbpnmngofma.DNIIFBAIPBE();
										string arg = hbpnmngofma.BFPHBMDMODH();
										int lpfkfnlhgbi2 = hbpnmngofma.HDBGOLAFOBK();
										int nkhbajkmagd = hbpnmngofma.HDBGOLAFOBK();
										string text = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi2).KGBHELBLPMF(nkhbajkmagd, 3, false);
										if (num5 == kfhelhglnmh.LPFKFNLHGBI)
										{
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("spin_bell.ogg", 1f);
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_umsg10"), text));
											goto IL_3C32;
										}
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrNewLider.ogg", 1f);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_umsg11"), arg, text));
										goto IL_3C32;
									}
									case 48:
									{
										long num6 = hbpnmngofma.DNIIFBAIPBE();
										string arg2 = hbpnmngofma.BFPHBMDMODH();
										int lpfkfnlhgbi3 = hbpnmngofma.HDBGOLAFOBK();
										int num7 = hbpnmngofma.HDBGOLAFOBK();
										IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi3);
										string text2 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg7"), idchhhedhdc.HAJNMNALBBI, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num7));
										if (num6 == kfhelhglnmh.LPFKFNLHGBI)
										{
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("fanfare.wav", 1f);
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg8"), text2));
											goto IL_3C32;
										}
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("allrec.ogg", 1f);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg9"), arg2, text2));
										goto IL_3C32;
									}
									case 50:
										OAFJCFOGGAF.IKGFHGKKCPG.OFHGCIFNICJ(hbpnmngofma);
										goto IL_3C32;
									case 60:
									case 70:
									case 72:
									case 74:
									case 75:
									case 76:
									case 77:
									case 78:
									case 79:
									case 81:
									case 82:
									case 83:
										Debug.Log("QUEST CMD " + ELEMIPMLIGG);
										EJDGMNEEOGN.IKGFHGKKCPG.DHCMMNAJKDI(ELEMIPMLIGG, hbpnmngofma);
										goto IL_3C32;
									case 85:
									{
										int num8 = hbpnmngofma.HDBGOLAFOBK();
										int chanellId = ActorMgr.getI.chanellId;
										ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(260f, 250f, JNBICAJIJMM.LEBHCLDODNI("chan_head"), true);
										onkdcgnbalk.OCHCODJIPHJ.x = (float)Screen.width - onkdcgnbalk.OCHCODJIPHJ.width - 80f;
										onkdcgnbalk.OCHCODJIPHJ.y = 50f;
										Debug.Log(string.Concat(new object[]
										{
											"Rooms  ",
											onkdcgnbalk.OCHCODJIPHJ.x,
											" ",
											onkdcgnbalk.OCHCODJIPHJ.y
										}));
										MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 15f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 70f, 0);
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											int num9 = hbpnmngofma.HDBGOLAFOBK();
											float num10 = (float)hbpnmngofma.HDBGOLAFOBK();
											string text3 = "▯▯▯";
											float num11 = num10 / (float)num8;
											if (num11 > 0.3f)
											{
												text3 = "▮▯▯";
											}
											if (num11 > 0.6f)
											{
												text3 = "▮▮▯";
											}
											if (num11 > 1f)
											{
												text3 = "▮▮▮";
											}
											ItemBase itemBase = new ItemBase(string.Concat(new object[]
											{
												text3,
												" ",
												JNBICAJIJMM.LEBHCLDODNI("chan_nam"),
												" ",
												num9
											}));
											itemBase.tag = (long)num9;
											mmkfaenbhkd.LACAJHOHACK.Add(itemBase);
											if (num9 == chanellId)
											{
												mmkfaenbhkd.IHEILFHMLAG = mmkfaenbhkd.LACAJHOHACK.Count - 1;
											}
										}
										Debug.Log("Rooms SET");
										mmkfaenbhkd.BAFCANOKEML(mmkfaenbhkd.IHEILFHMLAG);
										mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(DownPanelLogic.getI.changeChannel);
										Debug.Log("Rooms SET END");
										if (Fisherman.getI != null)
										{
											Fisherman.getI.MFENINHGBHM = false;
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 86:
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										Fisherman.getI.sendSpawnAction();
										if (Fisherman.getI != null)
										{
											Fisherman.getI.MFENINHGBHM = false;
											goto IL_3C32;
										}
										goto IL_3C32;
									case 87:
										JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB = ObscuredString.GOOIABGKMHK(hbpnmngofma.BFPHBMDMODH());
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										if (ObscuredString.HDFJOKAGNJC(JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("")) && ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB, JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB))
										{
											JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD = true;
										}
										SelectShadowLogic.getI.steamConnectWin.SetActive(true);
										goto IL_3C32;
									case 90:
									{
										JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME = ObscuredInt.GOOIABGKMHK(0);
										string a = hbpnmngofma.BFPHBMDMODH();
										if (a == "Ok")
										{
											JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF = hbpnmngofma.HDBGOLAFOBK();
											if (!hbpnmngofma.JCEGOADAOOI)
											{
												JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB = ObscuredString.GOOIABGKMHK(hbpnmngofma.BFPHBMDMODH());
											}
											if (!hbpnmngofma.JCEGOADAOOI)
											{
												JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME = ObscuredInt.GOOIABGKMHK(hbpnmngofma.HDBGOLAFOBK());
											}
											if (ObscuredString.HDFJOKAGNJC(JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("")))
											{
												JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD = true;
											}
											NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(255, 0);
											NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(105, 0);
											NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(110, 0);
										}
										if (a == "PIN")
										{
											MainMenuScript.getI.connectPanel.gameObject.SetActive(false);
											MainMenuScript.getI.pinPanel.gameObject.SetActive(true);
											EventSystem.current.SetSelectedGameObject(MainMenuScript.getI.pinInput.gameObject);
											JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrStartYou.ogg", 1f);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 91:
										if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB, ObscuredString.GOOIABGKMHK("")))
										{
											JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("steamno"));
										}
										else
										{
											JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("steamider"));
										}
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										NJMHLCGIAJI.IKGFHGKKCPG.NGKANDGCPHO();
										goto IL_3C32;
									case 92:
									{
										string str2 = hbpnmngofma.BFPHBMDMODH();
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("oldvermsg") + str2);
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										NJMHLCGIAJI.IKGFHGKKCPG.NGKANDGCPHO();
										goto IL_3C32;
									}
									case 94:
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), "Проверьте правильность логина и пароля!");
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										goto IL_3C32;
									case 96:
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("noemail"));
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										goto IL_3C32;
									case 98:
									{
										DateTime dateTime = hbpnmngofma.IKJAOHGGCJD();
										string arg3 = hbpnmngofma.BFPHBMDMODH();
										string edaphmjenpk = string.Format(JNBICAJIJMM.LEBHCLDODNI("gameban"), dateTime.ToString("dd/MM/yyyy HH:mm"), arg3);
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), edaphmjenpk);
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										goto IL_3C32;
									}
									case 99:
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("autherror"), JNBICAJIJMM.LEBHCLDODNI("gameexist"));
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										goto IL_3C32;
									case 100:
										FlyMessageManager.getI.clearFlyIcons();
										FlyMessageManager.getI.clearMessages();
										JBEHMPDDMME.IKGFHGKKCPG.LHOBENOACHG(hbpnmngofma);
										goto IL_3C32;
									case 101:
										GameInterface.getI.openUserData(4, hbpnmngofma);
										goto IL_3C32;
									case 102:
									{
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH == null)
										{
											goto IL_3C32;
										}
										long num12 = hbpnmngofma.DNIIFBAIPBE();
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI == num12)
										{
											JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJJMPDCPDMN(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 103:
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
										{
											GameInterface.getI.openLevelUpWin(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									case 104:
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
										{
											while (!hbpnmngofma.JCEGOADAOOI)
											{
												long phjohhdokhc = hbpnmngofma.DNIIFBAIPBE();
												EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(phjohhdokhc);
												if (ekbapcmpani != null)
												{
													JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(phjohhdokhc);
													string iabkgmnjljo4 = string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_drop"), ekbapcmpani.JPBOPFNPNHC(true));
													OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo4);
													FlyMessageManager.getI.addRightMessage(iabkgmnjljo4, 0, 0, 0);
												}
											}
											goto IL_3C32;
										}
										goto IL_3C32;
									case 105:
									{
										long kknekaejlam2 = JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM;
										bool flag = false;
										if (JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI != 0L)
										{
											flag = true;
										}
										JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI = hbpnmngofma.DNIIFBAIPBE();
										JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM = hbpnmngofma.DNIIFBAIPBE();
										DateTime serverTime = hbpnmngofma.IKJAOHGGCJD();
										TimeController.IKGFHGKKCPG.setServerTime(serverTime);
										if (flag && JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM > kknekaejlam2)
										{
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("money2.wav", 1f);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 106:
									{
										int num13 = hbpnmngofma.HDBGOLAFOBK();
										int num14 = hbpnmngofma.HDBGOLAFOBK();
										hbpnmngofma.HDBGOLAFOBK();
										string arg4 = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(num13) + " " + JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num14);
										string iabkgmnjljo5 = string.Format(JNBICAJIJMM.LEBHCLDODNI("myrec"), arg4);
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo5, Color.blue, 0, 0).NENOBDLCFHO = num13;
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo5);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_FullItem.wav", 0.5f);
										goto IL_3C32;
									}
									case 107:
									{
										int olkmhfnlbjb = hbpnmngofma.HDBGOLAFOBK();
										int clcbhhlllfn = hbpnmngofma.HDBGOLAFOBK();
										GameInterface.getI.openFishAchiveWin(olkmhfnlbjb, clcbhhlllfn);
										goto IL_3C32;
									}
									case 108:
									{
										Debug.Log("get 108 packet");
										int hkhmiieifng = hbpnmngofma.HDBGOLAFOBK();
										kfhelhglnmh.HKHMIIEIFNG = hkhmiieifng;
										string str3 = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(kfhelhglnmh.HKHMIIEIFNG, kfhelhglnmh.BNIHFBMEPAB, false, true);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("settitul") + " " + str3);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_FullItem.wav", 1f);
										goto IL_3C32;
									}
									case 109:
									{
										int lpfkfnlhgbi4 = hbpnmngofma.HDBGOLAFOBK();
										string str4 = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(lpfkfnlhgbi4, kfhelhglnmh.BNIHFBMEPAB, false, true);
										string iabkgmnjljo6 = JNBICAJIJMM.LEBHCLDODNI("newtitul") + " " + str4;
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo6);
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo6, Color.green, 0, 0);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrEndLose.ogg", 1f);
										goto IL_3C32;
									}
									case 110:
										JBEHMPDDMME.IKGFHGKKCPG.LEGHCIFPMIA(hbpnmngofma);
										goto IL_3C32;
									case 111:
										OAFJCFOGGAF.IKGFHGKKCPG.HBMNIJCICEI();
										NJMHLCGIAJI.IKGFHGKKCPG.CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(NJMHLCGIAJI.IKGFHGKKCPG.LLAHNMAHNDB);
										JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
										SceneManager.LoadScene(1);
										goto IL_3C32;
									case 112:
										JBEHMPDDMME.IKGFHGKKCPG.NJAMNNOPDDH = hbpnmngofma.HDBGOLAFOBK();
										SceneManager.LoadScene(2);
										goto IL_3C32;
									case 113:
									{
										string @string = PlayerPrefs.GetString("UIChat_channel");
										if (@string != "")
										{
											OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(@string, 2);
										}
										OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp2 = OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(10, true);
										if (lnhmfjdmokp2 != null)
										{
											lnhmfjdmokp2.PNLAPCGPDDL.Add(new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp2, "SYS", JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("chatconnecthelp"), false));
										}
										if (Fisherman.getI != null)
										{
											Fisherman.getI.MFENINHGBHM = false;
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 115:
									{
										bool flag2 = hbpnmngofma.FIFNOBGEKFF();
										JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
										if (CrShadowLogic.getI != null)
										{
											CrShadowLogic.getI.checkNameResult(flag2);
											goto IL_3C32;
										}
										if (flag2)
										{
											JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("chnam1"), JNBICAJIJMM.LEBHCLDODNI("chnam2"));
											goto IL_3C32;
										}
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("chnam3"), JNBICAJIJMM.LEBHCLDODNI("chnam4"));
										goto IL_3C32;
									}
									case 116:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long gdmojdpammn = hbpnmngofma.DNIIFBAIPBE();
											DateTime fpbecplinfd = hbpnmngofma.IKJAOHGGCJD() + TimeController.IKGFHGKKCPG.deltaTime;
											NEBJANKNJOG nebjanknjog = JBEHMPDDMME.IKGFHGKKCPG.OKFPEMCFMKN(gdmojdpammn);
											if (nebjanknjog != null)
											{
												nebjanknjog.HIOAFDBKDJD = true;
												nebjanknjog.FPBECPLINFD = fpbecplinfd;
											}
										}
										goto IL_3C32;
									case 120:
									{
										int num15 = hbpnmngofma.HDBGOLAFOBK();
										if (num15 == 0 && num15 == 1)
										{
											JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
											JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Ошибка!", "Слишком много персонажей!\nНа один аккаунт допускается не более 5 персонажей.");
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 125:
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
										{
											while (!hbpnmngofma.JCEGOADAOOI)
											{
												int num16 = hbpnmngofma.HDBGOLAFOBK();
												int num17 = hbpnmngofma.HDBGOLAFOBK();
												int num18 = hbpnmngofma.HDBGOLAFOBK();
												BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(num16);
												if (befchfngomi2 != null)
												{
													string iabkgmnjljo7 = string.Concat(new object[]
													{
														"+ ",
														befchfngomi2.JPBOPFNPNHC(true, num18).Replace("[sysname]", ""),
														" x",
														num17,
														" шт"
													});
													OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo7);
													FlyMessageManager.getI.addRightMessage(iabkgmnjljo7, num16, num18, 0);
													Color lbcgackjcjb = Color.gray;
													if (num18 == 1)
													{
														lbcgackjcjb = Color.white;
													}
													if (num18 == 2)
													{
														lbcgackjcjb = Color.green;
													}
													if (num18 == 3)
													{
														lbcgackjcjb = Color.blue;
													}
													if (num18 == 4)
													{
														lbcgackjcjb = Color.magenta;
													}
													if (num18 == 5)
													{
														lbcgackjcjb = Color.yellow;
													}
													if (num18 == 6)
													{
														lbcgackjcjb = Color.yellow;
													}
													FlyMessageManager.getI.addMessageBig(iabkgmnjljo7, lbcgackjcjb, num16, num18);
												}
												FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_AddCountitem.wav", 0.3f);
											}
											goto IL_3C32;
										}
										goto IL_3C32;
									case 126:
									{
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("catch2.ogg", 1f);
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH == null)
										{
											goto IL_3C32;
										}
										int num19 = 0;
										int num20 = hbpnmngofma.HDBGOLAFOBK();
										hbpnmngofma.HDBGOLAFOBK();
										int kbghoijipjf = hbpnmngofma.HDBGOLAFOBK();
										if (!hbpnmngofma.JCEGOADAOOI)
										{
											num19 = hbpnmngofma.HDBGOLAFOBK();
										}
										BEFCHFNGOMI befchfngomi3 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(num20);
										if (befchfngomi3 != null)
										{
											string text4 = befchfngomi3.JPBOPFNPNHC(true, -1).Replace("[sysname]", "");
											if (num20 == 1309)
											{
												IDCHHHEDHDC idchhhedhdc2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(num19);
												text4 = string.Format(text4, idchhhedhdc2.POMPCEHPGNG(0));
											}
											string iabkgmnjljo8 = string.Format(JNBICAJIJMM.LEBHCLDODNI("get_lut"), text4);
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo8);
											FlyMessageManager.getI.addMessageBig(iabkgmnjljo8, Color.blue, num20, kbghoijipjf);
											FlyMessageManager.getI.addRightMessage(iabkgmnjljo8, num20, kbghoijipjf, num19);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									case 130:
										GameInterface.getI.openUserData(9, hbpnmngofma);
										goto IL_3C32;
									case 131:
									{
										DODHLMFHFNL.KPPFPHMJPFE kppfphmjpfe = new DODHLMFHFNL.KPPFPHMJPFE(hbpnmngofma);
										string text5 = JNBICAJIJMM.LEBHCLDODNI("cht_ach1") + " " + kppfphmjpfe.KEIEIAAKHHK;
										FlyMessageManager.getI.addMessageBig(text5, new Color(0.7f, 0f, 0.8f), 0, 0).OBEJHDCOCAI = kppfphmjpfe.IBFLGDAMFOB;
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(text5 + ". " + JNBICAJIJMM.LEBHCLDODNI("cht_ach2"));
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_Newitem.wav", 1f);
										goto IL_3C32;
									}
									case 132:
									{
										DODHLMFHFNL.KPPFPHMJPFE kppfphmjpfe2 = new DODHLMFHFNL.KPPFPHMJPFE(hbpnmngofma);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("fanfare.wav", 1f);
										string iabkgmnjljo9 = JNBICAJIJMM.LEBHCLDODNI("cht_ach3") + kppfphmjpfe2.KEIEIAAKHHK;
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo9, new Color(0.7f, 0f, 0.8f), 0, 0).OBEJHDCOCAI = kppfphmjpfe2.IBFLGDAMFOB;
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo9);
										kppfphmjpfe2.AFKGDAPPPLK(2);
										goto IL_3C32;
									}
									case 134:
										LocBaseManager.IKGFHGKKCPG.getTravelBaseList(hbpnmngofma);
										LocBaseManager.IKGFHGKKCPG.loadSceneWaiter(9);
										goto IL_3C32;
									case 135:
										LocBaseManager.IKGFHGKKCPG.traveles.Clear();
										LocBaseManager.IKGFHGKKCPG.toGlobalMap.LNEPKLKELMI = (double)hbpnmngofma.HDBGOLAFOBK();
										LocBaseManager.IKGFHGKKCPG.toGlobalMap.NMKCBJKHBOH = (double)hbpnmngofma.HDBGOLAFOBK();
										LocBaseManager.IKGFHGKKCPG.globalMapTravel = hbpnmngofma.EIMAIEJKHKF();
										LocBaseManager.IKGFHGKKCPG.loadSceneWaiter(9);
										goto IL_3C32;
									case 141:
									{
										string palfnhclkaj = hbpnmngofma.BFPHBMDMODH();
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(palfnhclkaj, 1f);
										goto IL_3C32;
									}
									case 145:
										EDLNGHBMJBL.IKGFHGKKCPG.MDNKLOMHDGG(hbpnmngofma);
										goto IL_3C32;
									case 150:
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN = 0;
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = false;
										EDLNGHBMJBL.IKGFHGKKCPG.FLAICMCBPLH(hbpnmngofma);
										goto IL_3C32;
									case 151:
										Debug.Log("LOAD BASE");
										IFPIMPMKJIB.AKAPNBKMMMN = 4;
										SceneManager.LoadScene(4);
										goto IL_3C32;
									case 155:
									{
										long num21 = hbpnmngofma.DNIIFBAIPBE();
										long mglooioncpm = hbpnmngofma.DNIIFBAIPBE();
										float num22 = hbpnmngofma.FFDPCEAFGNF();
										long num23 = hbpnmngofma.DNIIFBAIPBE();
										float num24 = hbpnmngofma.FFDPCEAFGNF();
										kfhelhglnmh.MGLOOIONCPM = mglooioncpm;
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("infmsg_exp"), new object[]
										{
											num23,
											num24 * 100f,
											num21,
											num22
										}));
										goto IL_3C32;
									}
									case 157:
									{
										int num25 = hbpnmngofma.HDBGOLAFOBK();
										int num26 = hbpnmngofma.HDBGOLAFOBK();
										int anofhalnegn = hbpnmngofma.HDBGOLAFOBK();
										int jdibhegkalb = hbpnmngofma.HDBGOLAFOBK();
										Debug.Log(string.Concat(new object[]
										{
											"*************157 baseid=",
											num25,
											"  locid=",
											num26
										}));
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG = num25;
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE = num26;
										EDLNGHBMJBL.IKGFHGKKCPG.BFBGJGFPKBK(num25, num26);
										EDLNGHBMJBL.BEABHKKIDEL beabhkkidel = EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF;
										if (num26 == 0)
										{
											SceneManager.LoadScene(4);
											goto IL_3C32;
										}
										if (beabhkkidel != null)
										{
											beabhkkidel.ANOFHALNEGN = anofhalnegn;
											beabhkkidel.JDIBHEGKALB = jdibhegkalb;
											ActorMgr.getI.clearAllActors();
											FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(num26, 0), Color.cyan, 0, 0);
											NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1007, 0);
											goto IL_3C32;
										}
										Debug.LogError(string.Concat(new object[]
										{
											"No location found baseid=",
											num25,
											" locid=",
											num26
										}));
										goto IL_3C32;
									}
									case 158:
									{
										int num27 = hbpnmngofma.HDBGOLAFOBK();
										Debug.Log("**********  158 pointid=" + num27);
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN = num27;
										goto IL_3C32;
									}
									case 159:
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = true;
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LELNEEOHJCJ = hbpnmngofma.EIMAIEJKHKF().FPLDMBJEFEB();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AOAAIBOBFND = hbpnmngofma.EIMAIEJKHKF().FPLDMBJEFEB();
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LELNEEOHJCJ.magnitude < 0.1f)
										{
											JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = false;
											goto IL_3C32;
										}
										goto IL_3C32;
									case 160:
									{
										int num28 = hbpnmngofma.HDBGOLAFOBK();
										int num29 = hbpnmngofma.HDBGOLAFOBK();
										int anofhalnegn2 = hbpnmngofma.HDBGOLAFOBK();
										int jdibhegkalb2 = hbpnmngofma.HDBGOLAFOBK();
										Debug.Log(string.Concat(new object[]
										{
											"*************160 baseid=",
											num28,
											"  locid=",
											num29
										}));
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG = num28;
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE = num29;
										EDLNGHBMJBL.IKGFHGKKCPG.BFBGJGFPKBK(num28, num29);
										EDLNGHBMJBL.BEABHKKIDEL beabhkkidel2 = EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF;
										if (num29 == 0)
										{
											SceneManager.LoadScene(4);
										}
										else if (beabhkkidel2 != null)
										{
											beabhkkidel2.ANOFHALNEGN = anofhalnegn2;
											beabhkkidel2.JDIBHEGKALB = jdibhegkalb2;
											SceneManager.LoadScene(6);
										}
										else
										{
											Debug.LogError(string.Concat(new object[]
											{
												"No location found baseid=",
												num28,
												" locid=",
												num29
											}));
										}
										JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
										goto IL_3C32;
									}
									case 161:
										if (MMOItemStaticManager.getI != null)
										{
											MMOItemStaticManager.getI.clearItems();
											MMOItemStaticManager.getI.processItems(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									case 162:
										if (MMOItemStaticManager.getI != null)
										{
											MMOItemStaticManager.getI.processItems(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									case 166:
										GameInterface.getI.OpenHolod(hbpnmngofma);
										goto IL_3C32;
									case 167:
									case 168:
										goto IL_3C32;
									case 173:
										kfhelhglnmh.FDLDMDJAEEI(hbpnmngofma.DNIIFBAIPBE());
										goto IL_3C32;
									case 174:
										kfhelhglnmh.PPFMIKDFFIK();
										goto IL_3C32;
									case 175:
										kfhelhglnmh.MFOBDDHJDBJ(hbpnmngofma);
										goto IL_3C32;
									case 178:
										kfhelhglnmh.PNLEOIALMJM();
										goto IL_3C32;
									case 179:
										kfhelhglnmh.MEIHACLOGKN();
										kfhelhglnmh.GLBJBMBBDFK();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									case 180:
										kfhelhglnmh.BENNFEOMIPD(hbpnmngofma);
										goto IL_3C32;
									case 181:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long num30 = hbpnmngofma.DNIIFBAIPBE();
											EKBAPCMPANI ekbapcmpani2 = kfhelhglnmh.FCHLEBEMIBK(num30);
											if (ekbapcmpani2 != null)
											{
												ekbapcmpani2.DBKAJALPOPM(hbpnmngofma);
											}
											else
											{
												ekbapcmpani2 = new EKBAPCMPANI
												{
													LPFKFNLHGBI = num30
												};
												ekbapcmpani2.DBKAJALPOPM(hbpnmngofma);
												IHFEDJEMJMB.IKGFHGKKCPG.NDKJBHCGHCL(ekbapcmpani2);
												if (ekbapcmpani2.JCGDLKIHBJG == kfhelhglnmh.LPFKFNLHGBI && ekbapcmpani2.KKJKHBJKEPP == 0)
												{
													kfhelhglnmh.PLLHGAFIAFD.Add(ekbapcmpani2.LPFKFNLHGBI, ekbapcmpani2);
												}
											}
											ekbapcmpani2.BALHEIJEDDJ();
										}
										kfhelhglnmh.GLBJBMBBDFK();
										BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									case 186:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long num31 = hbpnmngofma.DNIIFBAIPBE();
											EKBAPCMPANI ekbapcmpani3 = kfhelhglnmh.FCHLEBEMIBK(num31);
											if (ekbapcmpani3 != null)
											{
												ekbapcmpani3.GPFNKNLNLGL(hbpnmngofma);
											}
											else
											{
												ekbapcmpani3 = new EKBAPCMPANI
												{
													LPFKFNLHGBI = num31
												};
												ekbapcmpani3.GPFNKNLNLGL(hbpnmngofma);
											}
											ekbapcmpani3.BALHEIJEDDJ();
										}
										kfhelhglnmh.GLBJBMBBDFK();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									case 187:
									{
										long phjohhdokhc2 = hbpnmngofma.DNIIFBAIPBE();
										EKBAPCMPANI ekbapcmpani4 = kfhelhglnmh.FCHLEBEMIBK(phjohhdokhc2);
										if (ekbapcmpani4 != null)
										{
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(("+ " + ekbapcmpani4.JPBOPFNPNHC(false)) ?? "");
											ekbapcmpani4.BALHEIJEDDJ();
										}
										kfhelhglnmh.GLBJBMBBDFK();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									}
									case 188:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long phjohhdokhc3 = hbpnmngofma.DNIIFBAIPBE();
											float dlhpfghoini = hbpnmngofma.FFDPCEAFGNF();
											EKBAPCMPANI ekbapcmpani5 = kfhelhglnmh.FCHLEBEMIBK(phjohhdokhc3);
											if (ekbapcmpani5 != null)
											{
												ekbapcmpani5.DLHPFGHOINI = dlhpfghoini;
												ekbapcmpani5.BALHEIJEDDJ();
											}
										}
										goto IL_3C32;
									case 190:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long num32 = hbpnmngofma.DNIIFBAIPBE();
											if (kfhelhglnmh.FCHLEBEMIBK(num32) != null)
											{
												kfhelhglnmh.PLLHGAFIAFD.Remove(num32);
											}
										}
										BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
										kfhelhglnmh.GLBJBMBBDFK();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									case 191:
										while (!hbpnmngofma.JCEGOADAOOI)
										{
											long num33 = hbpnmngofma.DNIIFBAIPBE();
											EKBAPCMPANI ekbapcmpani6 = kfhelhglnmh.FCHLEBEMIBK(num33);
											if (ekbapcmpani6 != null)
											{
												kfhelhglnmh.PLLHGAFIAFD.Remove(num33);
												string iabkgmnjljo10 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg10"), ekbapcmpani6.FDJPJJJHHEG);
												OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo10);
												FlyMessageManager.getI.addMessageBig(iabkgmnjljo10, Color.red, 0, 0);
												FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cut.ogg", 1f);
											}
										}
										BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
										kfhelhglnmh.GLBJBMBBDFK();
										CLFFOBKFKDN.IKGFHGKKCPG.BMGFDIFLAGD();
										goto IL_3C32;
									default:
										if (ELEMIPMLIGG == 198)
										{
											EKBAPCMPANI ekbapcmpani7 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(hbpnmngofma.DNIIFBAIPBE());
											if (ekbapcmpani7 != null)
											{
												MDEKJCCIDIA.IKGFHGKKCPG.MBDGHDLHKAJ(ekbapcmpani7);
												goto IL_3C32;
											}
											goto IL_3C32;
										}
										break;
									}
								}
								else
								{
									if (ELEMIPMLIGG == 199)
									{
										string iabkgmnjljo11 = JNBICAJIJMM.LEBHCLDODNI("cht_msg11");
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo11);
										goto IL_3C32;
									}
									if (ELEMIPMLIGG == 210)
									{
										MDEKJCCIDIA.IKGFHGKKCPG.LJKNNJKJEHL(hbpnmngofma);
										goto IL_3C32;
									}
								}
							}
							else if (ELEMIPMLIGG <= 220)
							{
								if (ELEMIPMLIGG == 215)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("MENU.WAV", 1f);
									goto IL_3C32;
								}
								if (ELEMIPMLIGG == 220)
								{
									int num34 = hbpnmngofma.HDBGOLAFOBK();
									if (num34 == 1)
									{
										FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("cht_msg3"), Color.green, 0, 0);
									}
									if (num34 == -1)
									{
										FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("cht_msg4"), Color.red, 0, 0);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
							}
							else
							{
								if (ELEMIPMLIGG == 230)
								{
									Debug.Log("pck 230");
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("MENU.WAV", 1f);
									MDEKJCCIDIA.IKGFHGKKCPG.DLNBJCJAMFD(hbpnmngofma);
									goto IL_3C32;
								}
								if (ELEMIPMLIGG == 235)
								{
									MDEKJCCIDIA.IKGFHGKKCPG.DKPNCFJOKKJ(hbpnmngofma);
									goto IL_3C32;
								}
							}
						}
						else if (ELEMIPMLIGG <= 255)
						{
							if (ELEMIPMLIGG <= 250)
							{
								switch (ELEMIPMLIGG)
								{
								case 240:
								{
									BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn3 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
									if (diggohpgcnn3.OKEBIHBDEOO("no_adm"))
									{
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("Low adminlevel!");
									}
									if (diggohpgcnn3.OKEBIHBDEOO("ok"))
									{
										string iabkgmnjljo12 = "Silence OK. Object:" + diggohpgcnn3.IEIMMFODGFG;
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo12, Color.red, 0, 0);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo12);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								case 241:
								{
									int ppicjoppolk = hbpnmngofma.HDBGOLAFOBK();
									int num35 = hbpnmngofma.HDBGOLAFOBK();
									string iabkgmnjljo13 = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("silence"), num35);
									OAFJCFOGGAF.IKGFHGKKCPG.PBHOFBIHPKF(ppicjoppolk, iabkgmnjljo13);
									goto IL_3C32;
								}
								case 242:
								{
									BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn4 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
									if (diggohpgcnn4.OKEBIHBDEOO("no_adm"))
									{
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("Low adminlevel!");
									}
									if (diggohpgcnn4.OKEBIHBDEOO("ok"))
									{
										string iabkgmnjljo14 = "Censor OK. Object:" + diggohpgcnn4.IEIMMFODGFG;
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo14, Color.red, 0, 0);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo14);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								case 243:
									break;
								case 244:
								{
									BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn5 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
									if (diggohpgcnn5.OKEBIHBDEOO("no_adm"))
									{
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("Low adminlevel!");
									}
									if (diggohpgcnn5.OKEBIHBDEOO("error"))
									{
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("Error - " + diggohpgcnn5.IEIMMFODGFG);
									}
									if (diggohpgcnn5.OKEBIHBDEOO("ok"))
									{
										string iabkgmnjljo15 = "Ban OK. Object:" + diggohpgcnn5.IEIMMFODGFG;
										FlyMessageManager.getI.addMessageBig(iabkgmnjljo15, Color.red, 0, 0);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo15);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								default:
									if (ELEMIPMLIGG == 250)
									{
										if (kfhelhglnmh == null)
										{
											goto IL_3C32;
										}
										hbpnmngofma.HDBGOLAFOBK();
										int lpfkfnlhgbi5 = hbpnmngofma.HDBGOLAFOBK();
										hbpnmngofma.HDBGOLAFOBK();
										BEFCHFNGOMI befchfngomi4 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi5);
										if (befchfngomi4 != null)
										{
											string iabkgmnjljo16 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg12"), befchfngomi4.JPBOPFNPNHC(true, -1).Replace("[sysname]", ""));
											FlyMessageManager.getI.addRightMessage(iabkgmnjljo16, 0, 0, 0);
											OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo16);
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("paper.wav", 1f);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									break;
								}
							}
							else if (ELEMIPMLIGG != 251)
							{
								if (ELEMIPMLIGG == 255)
								{
									NJMHLCGIAJI.IKGFHGKKCPG.KDDIGJFLABF();
									JBEHMPDDMME.IKGFHGKKCPG.MHCCPNFKOKN = hbpnmngofma.HDBGOLAFOBK();
									TimeController.IKGFHGKKCPG.setServerTime(hbpnmngofma.IKJAOHGGCJD());
									JBEHMPDDMME.IKGFHGKKCPG.NDLEAJDKPJN = hbpnmngofma.HDBGOLAFOBK();
									int jbjfbdoneff = JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
									JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF = hbpnmngofma.HDBGOLAFOBK();
									int jbjfbdoneff2 = JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
									if (jbjfbdoneff < JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF)
									{
										goto IL_3C32;
									}
									goto IL_3C32;
								}
							}
							else
							{
								if (kfhelhglnmh == null)
								{
									goto IL_3C32;
								}
								int lfbbnffhkfb = hbpnmngofma.HDBGOLAFOBK();
								int ilfhhdnjhnm = hbpnmngofma.HDBGOLAFOBK();
								CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = CLFFOBKFKDN.IKGFHGKKCPG.DDGNAEHCLCN(lfbbnffhkfb);
								if (dnoemmjajhd != null)
								{
									dnoemmjajhd.ILFHHDNJHNM = ilfhhdnjhnm;
									goto IL_3C32;
								}
								goto IL_3C32;
							}
						}
						else if (ELEMIPMLIGG <= 270)
						{
							if (ELEMIPMLIGG == 260)
							{
								FlyMessageManager.getI.readServerFlyIcons(hbpnmngofma);
								goto IL_3C32;
							}
							if (ELEMIPMLIGG == 270)
							{
								Debug.Log("270");
								int lpfkfnlhgbi6 = hbpnmngofma.HDBGOLAFOBK();
								FlyMessageManager.getI.deleteFlyIcon(lpfkfnlhgbi6);
								goto IL_3C32;
							}
						}
						else if (ELEMIPMLIGG != 275)
						{
							if (ELEMIPMLIGG == 278)
							{
								GameInterface.getI.openUserInfo(hbpnmngofma);
								JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
								goto IL_3C32;
							}
							if (ELEMIPMLIGG == 285)
							{
								IIBEEKCAAHK iibeekcaahk = hbpnmngofma.EIMAIEJKHKF();
								if (iibeekcaahk.ICJDPPOJINN > 0)
								{
									string edaphmjenpk2 = string.Format("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта", iibeekcaahk.ICJDPPOJINN, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.NODLBGKEGPM), iibeekcaahk.IBEIBAHKIAH);
									JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Отпущена рыба", edaphmjenpk2);
									goto IL_3C32;
								}
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Отпущена рыба", "Нечего отпускать!");
								goto IL_3C32;
							}
						}
						else
						{
							if (kfhelhglnmh != null)
							{
								hbpnmngofma.HDBGOLAFOBK();
								FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("cht_msg13"), Color.blue, 0, 0);
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else if (ELEMIPMLIGG <= 335)
					{
						if (ELEMIPMLIGG <= 315)
						{
							if (ELEMIPMLIGG <= 290)
							{
								if (ELEMIPMLIGG == 286)
								{
									hbpnmngofma.HDBGOLAFOBK();
									goto IL_3C32;
								}
								if (ELEMIPMLIGG == 290)
								{
									BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn6 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
									if (diggohpgcnn6.OKEBIHBDEOO("nowpn"))
									{
										JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.DJBELNNPCPO);
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg14"));
									}
									if (diggohpgcnn6.OKEBIHBDEOO("noworkpoints"))
									{
										JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.DJBELNNPCPO);
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg15"));
									}
									if (diggohpgcnn6.OKEBIHBDEOO("norefine"))
									{
										JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.DJBELNNPCPO);
										JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg16"));
									}
									if (diggohpgcnn6.OKEBIHBDEOO("isend"))
									{
										JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.DJBELNNPCPO);
									}
									if (diggohpgcnn6.OKEBIHBDEOO("noresult"))
									{
										MDEKJCCIDIA.IKGFHGKKCPG.IDPELCAAOFB(null);
									}
									if (diggohpgcnn6.OKEBIHBDEOO("result"))
									{
										foreach (IIBEEKCAAHK iibeekcaahk2 in diggohpgcnn6.HDELBIDJNOK)
										{
											bool flag3 = true;
											foreach (IIBEEKCAAHK iibeekcaahk3 in MDEKJCCIDIA.IKGFHGKKCPG.NEGPPBJIHAF)
											{
												if (iibeekcaahk3.IBEIBAHKIAH == iibeekcaahk2.IBEIBAHKIAH)
												{
													iibeekcaahk3.NMKCBJKHBOH += (double)iibeekcaahk2.ICJDPPOJINN;
													flag3 = false;
													break;
												}
											}
											if (flag3)
											{
												MDEKJCCIDIA.IKGFHGKKCPG.NEGPPBJIHAF.Add(iibeekcaahk2);
											}
										}
										MDEKJCCIDIA.IKGFHGKKCPG.IDPELCAAOFB(null);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
							}
							else
							{
								switch (ELEMIPMLIGG)
								{
								case 305:
								{
									int lpfkfnlhgbi7 = hbpnmngofma.HDBGOLAFOBK();
									BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = BHNDGIPPPCE.IKGFHGKKCPG.JFOIIJGMKPM(lpfkfnlhgbi7);
									if (fckccmdiifk == null)
									{
										return;
									}
									string iabkgmnjljo17 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg17"), fckccmdiifk.BNIHFBMEPAB);
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo17);
									FlyMessageManager.getI.addRightMessage(iabkgmnjljo17, 0, 0, 0);
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_Newitem.wav", 1f);
									goto IL_3C32;
								}
								case 306:
								{
									int lpfkfnlhgbi8 = hbpnmngofma.HDBGOLAFOBK();
									int cnolcndblje = hbpnmngofma.HDBGOLAFOBK();
									BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk2 = BHNDGIPPPCE.IKGFHGKKCPG.JFOIIJGMKPM(lpfkfnlhgbi8);
									if (fckccmdiifk2 == null)
									{
										return;
									}
									string iabkgmnjljo18 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg18"), fckccmdiifk2.BNIHFBMEPAB, fckccmdiifk2.CJNHPHAOEDL(cnolcndblje));
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo18);
									FlyMessageManager.getI.addRightMessage(iabkgmnjljo18, 0, 0, 0);
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_Newitem.wav", 1f);
									goto IL_3C32;
								}
								case 307:
								{
									int lpfkfnlhgbi9 = hbpnmngofma.HDBGOLAFOBK();
									hbpnmngofma.HDBGOLAFOBK();
									hbpnmngofma.HDBGOLAFOBK();
									int num36 = hbpnmngofma.HDBGOLAFOBK();
									BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk3 = BHNDGIPPPCE.IKGFHGKKCPG.JFOIIJGMKPM(lpfkfnlhgbi9);
									if (fckccmdiifk3 != null)
									{
										string iabkgmnjljo19 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg19"), fckccmdiifk3.BNIHFBMEPAB, num36);
										OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo19);
										FlyMessageManager.getI.addRightMessage(iabkgmnjljo19, 0, 0, 0);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								case 308:
								case 309:
									break;
								case 310:
									MDEKJCCIDIA.IKGFHGKKCPG.PKFEKICLLAF(hbpnmngofma);
									goto IL_3C32;
								default:
									if (ELEMIPMLIGG == 315)
									{
										MDEKJCCIDIA.IKGFHGKKCPG.EBFGBLMGLBA(hbpnmngofma);
										goto IL_3C32;
									}
									break;
								}
							}
						}
						else if (ELEMIPMLIGG <= 330)
						{
							if (ELEMIPMLIGG != 320)
							{
								if (ELEMIPMLIGG == 330)
								{
									MDEKJCCIDIA.IKGFHGKKCPG.GJFGHJIJNCA(hbpnmngofma);
									goto IL_3C32;
								}
							}
							else
							{
								string a2 = hbpnmngofma.BFPHBMDMODH();
								if (a2 == "ok")
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Item_Sell.ogg", 1f);
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("cht_msg20"));
								}
								if (a2 == "no_money")
								{
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("cht_msg21"));
								}
								if (a2 == "no_wpn")
								{
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("cht_msg22"));
									goto IL_3C32;
								}
								goto IL_3C32;
							}
						}
						else
						{
							if (ELEMIPMLIGG == 332)
							{
								MDEKJCCIDIA.IKGFHGKKCPG.KHPKOPHFDFB(hbpnmngofma);
								goto IL_3C32;
							}
							if (ELEMIPMLIGG == 335)
							{
								MDEKJCCIDIA.IKGFHGKKCPG.KOMKFLJHCNK(hbpnmngofma);
								goto IL_3C32;
							}
						}
					}
					else if (ELEMIPMLIGG <= 672)
					{
						if (ELEMIPMLIGG <= 450)
						{
							switch (ELEMIPMLIGG)
							{
							case 340:
								MDEKJCCIDIA.IKGFHGKKCPG.GFJEGOHIAHL(hbpnmngofma);
								goto IL_3C32;
							case 341:
							case 342:
							case 343:
							case 344:
							case 349:
								break;
							case 345:
								MDEKJCCIDIA.IKGFHGKKCPG.IFGEEBANPJD(hbpnmngofma);
								goto IL_3C32;
							case 346:
								MDEKJCCIDIA.IKGFHGKKCPG.CIIFCFGPPLD(hbpnmngofma);
								goto IL_3C32;
							case 347:
							{
								long num37 = hbpnmngofma.DNIIFBAIPBE();
								string text6 = hbpnmngofma.BFPHBMDMODH();
								Debug.Log(string.Concat(new object[]
								{
									"auk buy result: ",
									num37,
									" ",
									text6
								}));
								goto IL_3C32;
							}
							case 348:
							{
								long num38 = hbpnmngofma.DNIIFBAIPBE();
								string text7 = hbpnmngofma.BFPHBMDMODH();
								Debug.Log(string.Concat(new object[]
								{
									"auk stavka result: ",
									num38,
									" ",
									text7
								}));
								goto IL_3C32;
							}
							case 350:
								MDEKJCCIDIA.IKGFHGKKCPG.OPKCNFFABDF(hbpnmngofma);
								goto IL_3C32;
							default:
								if (ELEMIPMLIGG == 450)
								{
									GameInterface.getI.openArtelListWindow(hbpnmngofma);
									JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
									goto IL_3C32;
								}
								break;
							}
						}
						else if (ELEMIPMLIGG != 670)
						{
							if (ELEMIPMLIGG == 672)
							{
								long olkmhfnlbjb2 = hbpnmngofma.DNIIFBAIPBE();
								if (kfhelhglnmh == null)
								{
									goto IL_3C32;
								}
								OIJEGJLCFCF oijegjlcfcf = kfhelhglnmh.OLPOHFKHBOL(olkmhfnlbjb2);
								if (oijegjlcfcf != null)
								{
									string iabkgmnjljo20 = oijegjlcfcf.LHNOBJDFOOJ(true) + JNBICAJIJMM.LEBHCLDODNI("cht_msg23");
									FlyMessageManager.getI.addRightMessage(iabkgmnjljo20, 0, 0, 0);
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo20);
									kfhelhglnmh.FDLDMDJAEEI(olkmhfnlbjb2);
									goto IL_3C32;
								}
								goto IL_3C32;
							}
						}
						else
						{
							if (kfhelhglnmh != null)
							{
								kfhelhglnmh.OIKOCJOOPDP.CEOLHMPCBFI(hbpnmngofma);
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else if (ELEMIPMLIGG <= 680)
					{
						if (ELEMIPMLIGG == 675)
						{
							kfhelhglnmh.OIKOCJOOPDP.BEFNPAKDBGF.Clear();
							kfhelhglnmh.OIKOCJOOPDP.OHDKAKCPBEN(hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 680)
						{
							if (kfhelhglnmh != null)
							{
								kfhelhglnmh.OIKOCJOOPDP.OHDKAKCPBEN(hbpnmngofma);
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else
					{
						if (ELEMIPMLIGG == 700)
						{
							EJDGMNEEOGN.IKGFHGKKCPG.IKJENJCAPHE(hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 705)
						{
							EJDGMNEEOGN.IKGFHGKKCPG.PGAANCNHIHB(hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 710)
						{
							BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn7 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
							if (diggohpgcnn7.OKEBIHBDEOO("no_task"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg24"));
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(700, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
							}
							if (diggohpgcnn7.OKEBIHBDEOO("no_repa"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg25"));
							}
							if (diggohpgcnn7.OKEBIHBDEOO("no_get"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg26"));
							}
							if (diggohpgcnn7.OKEBIHBDEOO("big_count"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg27"));
							}
							if (diggohpgcnn7.OKEBIHBDEOO("no_time_period"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg28"));
							}
							if (diggohpgcnn7.OKEBIHBDEOO("ok"))
							{
								EJDGMNEEOGN.IKGFHGKKCPG.NPCHOJBIIGJ();
							}
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							goto IL_3C32;
						}
					}
				}
				else if (ELEMIPMLIGG <= 1210)
				{
					if (ELEMIPMLIGG <= 1010)
					{
						if (ELEMIPMLIGG <= 905)
						{
							if (ELEMIPMLIGG <= 812)
							{
								if (ELEMIPMLIGG == 715)
								{
									hbpnmngofma.DNIIFBAIPBE();
									hbpnmngofma.HDBGOLAFOBK();
									int dcpbbplccfh = hbpnmngofma.HDBGOLAFOBK();
									string arg5 = hbpnmngofma.BFPHBMDMODH();
									string arg6 = kfhelhglnmh.OIKOCJOOPDP.BBNHICAOOFM(dcpbbplccfh);
									string iabkgmnjljo21 = string.Format("{0} принял задание '{1}'", arg5, arg6);
									OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo21);
									goto IL_3C32;
								}
								switch (ELEMIPMLIGG)
								{
								case 802:
									GHMGDBLLEAG.IKGFHGKKCPG.JLOHCGNILNC(hbpnmngofma);
									goto IL_3C32;
								case 805:
									GHMGDBLLEAG.IKGFHGKKCPG.CHEIJHEGOJA(hbpnmngofma);
									goto IL_3C32;
								case 808:
									GHMGDBLLEAG.IKGFHGKKCPG.PJAJPGEIILE(hbpnmngofma);
									goto IL_3C32;
								case 810:
									GHMGDBLLEAG.IKGFHGKKCPG.JGEDNAKJCAP(hbpnmngofma);
									goto IL_3C32;
								case 811:
									GHMGDBLLEAG.IKGFHGKKCPG.JGEDNAKJCAP(hbpnmngofma);
									goto IL_3C32;
								case 812:
									GHMGDBLLEAG.IKGFHGKKCPG.HMJDICEDIGB(hbpnmngofma);
									goto IL_3C32;
								}
							}
							else
							{
								if (ELEMIPMLIGG == 818)
								{
									GHMGDBLLEAG.IKGFHGKKCPG.DALLIDDJFGF(hbpnmngofma);
									goto IL_3C32;
								}
								if (ELEMIPMLIGG == 905)
								{
									if (Fisherman.getI != null)
									{
										Fisherman.getI.userDead();
										goto IL_3C32;
									}
									goto IL_3C32;
								}
							}
						}
						else if (ELEMIPMLIGG <= 1000)
						{
							if (ELEMIPMLIGG != 910)
							{
								if (ELEMIPMLIGG == 1000)
								{
									if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
									{
										float bcinommokje = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BCINOMMOKJE;
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BCINOMMOKJE = hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GCLLMNHFMND = hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PMOJDCHIAHE = hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AJHDDHHOHAC = hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.ODHFHEBLIJM = hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CMEGHBFANIO = hbpnmngofma.EIMAIEJKHKF();
										JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF = (int)hbpnmngofma.FFDPCEAFGNF();
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KPKKDPGEPHE = hbpnmngofma.FFDPCEAFGNF();
										if (!hbpnmngofma.JCEGOADAOOI)
										{
											FlyMessageManager.getI.readServerFlyIcons(hbpnmngofma);
										}
										if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BCINOMMOKJE < bcinommokje && Time.time - this.ECNCIDGFMFM > 3f && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BCINOMMOKJE < 20f)
										{
											FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("heart.wav", 1f);
											this.ECNCIDGFMFM = Time.time;
										}
										JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGHLLPECLMG();
										goto IL_3C32;
									}
									goto IL_3C32;
								}
							}
							else
							{
								long iehijalhone = hbpnmngofma.DNIIFBAIPBE();
								string arg7 = hbpnmngofma.BFPHBMDMODH();
								int num39 = hbpnmngofma.HDBGOLAFOBK();
								Debug.Log("910 pck get");
								switch (num39)
								{
								case 1:
								{
									int lpfkfnlhgbi10 = hbpnmngofma.HDBGOLAFOBK();
									BEFCHFNGOMI befchfngomi5 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi10);
									if (befchfngomi5 != null)
									{
										string iabkgmnjljo22 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg29"), arg7, befchfngomi5.JPBOPFNPNHC(false, -1));
										FlyMessageManager.getI.addRightMessageColored(iabkgmnjljo22, Color.red);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								case 2:
								{
									int lpfkfnlhgbi11 = hbpnmngofma.HDBGOLAFOBK();
									BEFCHFNGOMI befchfngomi6 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi11);
									if (befchfngomi6 != null)
									{
										string iabkgmnjljo23 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg30"), arg7, befchfngomi6.JPBOPFNPNHC(false, -1));
										FlyMessageManager.getI.addRightMessageColored(iabkgmnjljo23, Color.red);
										goto IL_3C32;
									}
									goto IL_3C32;
								}
								case 3:
								{
									int nenobdlcfho = hbpnmngofma.HDBGOLAFOBK();
									int dbeigndaldc = hbpnmngofma.HDBGOLAFOBK();
									int bpjcikfgomm = hbpnmngofma.HDBGOLAFOBK();
									float onadlmbjfcc = hbpnmngofma.FFDPCEAFGNF();
									ActorMgr.getI.actorBrag(iehijalhone, nenobdlcfho, dbeigndaldc, bpjcikfgomm, onadlmbjfcc);
									goto IL_3C32;
								}
								default:
									goto IL_3C32;
								}
							}
						}
						else if (ELEMIPMLIGG != 1001)
						{
							switch (ELEMIPMLIGG)
							{
							case 1006:
								ActorMgr.getI.actionProcessor(hbpnmngofma);
								goto IL_3C32;
							case 1007:
								ActorMgr.getI.initialUsersInLoc(hbpnmngofma);
								goto IL_3C32;
							case 1010:
								ActorMgr.getI.actorData(hbpnmngofma);
								goto IL_3C32;
							}
						}
						else
						{
							TimeController.IKGFHGKKCPG.WeatherDoWork(hbpnmngofma);
							if (EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF != null)
							{
								EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF.ANOFHALNEGN = hbpnmngofma.HDBGOLAFOBK();
								EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF.JDIBHEGKALB = hbpnmngofma.HDBGOLAFOBK();
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else if (ELEMIPMLIGG <= 1130)
					{
						if (ELEMIPMLIGG <= 1120)
						{
							if (ELEMIPMLIGG != 1112)
							{
								if (ELEMIPMLIGG == 1120)
								{
									if (hbpnmngofma.FIFNOBGEKFF())
									{
										if (Fisherman.getI != null)
										{
											Fisherman.getI.klevAction(hbpnmngofma);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
									else
									{
										BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA = ObscuredFloat.GOOIABGKMHK(hbpnmngofma.FFDPCEAFGNF());
										if (Application.isEditor)
										{
											Debug.Log("No klev! shance=" + BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA);
											goto IL_3C32;
										}
										goto IL_3C32;
									}
								}
							}
							else
							{
								float num40 = hbpnmngofma.FFDPCEAFGNF();
								if (Application.isEditor)
								{
									Debug.Log("Pricorm count=" + num40);
									goto IL_3C32;
								}
								goto IL_3C32;
							}
						}
						else
						{
							if (ELEMIPMLIGG == 1121)
							{
								Debug.Log(hbpnmngofma.BFPHBMDMODH());
								goto IL_3C32;
							}
							if (ELEMIPMLIGG == 1130)
							{
								if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
								{
									BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBANBEEJAPD = false;
								}
								int num41 = hbpnmngofma.HDBGOLAFOBK();
								OIJEGJLCFCF oijegjlcfcf2 = new OIJEGJLCFCF();
								oijegjlcfcf2.LIMJEKJAILL(hbpnmngofma);
								oijegjlcfcf2.MGLOOIONCPM = hbpnmngofma.HDBGOLAFOBK();
								oijegjlcfcf2.NENNFCJLFAL = hbpnmngofma.HDBGOLAFOBK();
								oijegjlcfcf2.DEGKMKPKMMO = hbpnmngofma.FFDPCEAFGNF();
								if (oijegjlcfcf2.GNEPMCMHDEM)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrNewLider.ogg", 1f);
								}
								BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(num41).EBFADOKNMHD = oijegjlcfcf2.LPFKFNLHGBI;
								Debug.Log("NEW FISH!");
								kfhelhglnmh.NAFGMKJPLPC.Add(oijegjlcfcf2);
								if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD && SteamManager.FPAKOLIPIND)
								{
									string kfidpbaifle = "fishpoplcatch";
									if (num41 == 1)
									{
										kfidpbaifle = "fishspincatch";
									}
									SteamLogic.getI.updateIntStat(kfidpbaifle, 1);
									SteamLogic.getI.updateIntStat("fishcatch", 1);
									SteamLogic.getI.updateFloatStat("fishwgt", (float)oijegjlcfcf2.NKHBAJKMAGD / 1000f);
									SteamUserStats.StoreStats();
								}
								if (GameInterface.getI.sadokWinId > 0)
								{
									JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(GameInterface.getI.sadokWinId);
								}
								GameInterface.getI.openFishWin(oijegjlcfcf2);
								goto IL_3C32;
							}
						}
					}
					else if (ELEMIPMLIGG <= 1150)
					{
						if (ELEMIPMLIGG == 1135)
						{
							int num42 = hbpnmngofma.HDBGOLAFOBK();
							Debug.Log("+ EXP for FISH=" + num42);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 1150)
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							GameInterface.getI.openUserData(2, hbpnmngofma);
							goto IL_3C32;
						}
					}
					else
					{
						if (ELEMIPMLIGG == 1200)
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							ELNGEFIPDJK.IKGFHGKKCPG.JFKDADMHFJK(hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 1205)
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							ELNGEFIPDJK.IKGFHGKKCPG.PFFPCAMAFMM(hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 1210)
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							IIBEEKCAAHK iibeekcaahk4 = hbpnmngofma.EIMAIEJKHKF();
							if (iibeekcaahk4.IBEIBAHKIAH > 0)
							{
								string iabkgmnjljo24 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg1"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)iibeekcaahk4.IBEIBAHKIAH, true), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)iibeekcaahk4.ICJDPPOJINN, true), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)(iibeekcaahk4.IBEIBAHKIAH + iibeekcaahk4.ICJDPPOJINN), true));
								if (iibeekcaahk4.ICJDPPOJINN == 0)
								{
									iabkgmnjljo24 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg2"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)iibeekcaahk4.IBEIBAHKIAH, true));
								}
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo24);
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("money2.wav", 1f);
								kfhelhglnmh.KFODJJIHNHP = (long)iibeekcaahk4.NODLBGKEGPM;
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
				}
				else if (ELEMIPMLIGG <= 1410)
				{
					if (ELEMIPMLIGG <= 1400)
					{
						if (ELEMIPMLIGG <= 1300)
						{
							if (ELEMIPMLIGG == 1230)
							{
								JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
								MDEKJCCIDIA.IKGFHGKKCPG.JDIANCANDFJ(hbpnmngofma);
								goto IL_3C32;
							}
							if (ELEMIPMLIGG == 1300)
							{
								JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
								ELNGEFIPDJK.IKGFHGKKCPG.JAMPKHIMEJD(hbpnmngofma);
								goto IL_3C32;
							}
						}
						else if (ELEMIPMLIGG != 1310)
						{
							if (ELEMIPMLIGG == 1400)
							{
								kfhelhglnmh.AFGFPHNFMOP();
								JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
								kfhelhglnmh.JEKKJEFEHOB(hbpnmngofma);
								goto IL_3C32;
							}
						}
						else
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn8 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
							if (diggohpgcnn8.OKEBIHBDEOO("no_money"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg31"));
							}
							if (diggohpgcnn8.OKEBIHBDEOO("no_inventory"))
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg32"));
							}
							if (!diggohpgcnn8.OKEBIHBDEOO("ok"))
							{
								goto IL_3C32;
							}
							IIBEEKCAAHK iibeekcaahk5 = diggohpgcnn8.FCIMOMDBEDL;
							BEFCHFNGOMI befchfngomi7 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk5.IBEIBAHKIAH);
							if (befchfngomi7 != null)
							{
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg34"), new object[]
								{
									IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(befchfngomi7.MBKMKGABBGE),
									befchfngomi7.BNIHFBMEPAB,
									befchfngomi7.HOALBMDJNDM,
									iibeekcaahk5.ICJDPPOJINN
								}));
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else if (ELEMIPMLIGG <= 1405)
					{
						if (ELEMIPMLIGG == 1401)
						{
							Debug.Log("get 1401 cmd");
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							kfhelhglnmh.AFGFPHNFMOP();
							GameInterface.getI.openUserData(8, hbpnmngofma);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 1405)
						{
							string a3 = hbpnmngofma.BFPHBMDMODH();
							if (a3 == "no_perk")
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg35"));
							}
							if (a3 == "max_level")
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg36"));
							}
							if (a3 == "low_root_level")
							{
								JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("cht_msg37"));
							}
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_DelItem.wav", 1f);
							goto IL_3C32;
						}
					}
					else
					{
						if (ELEMIPMLIGG == 1408)
						{
							while (!hbpnmngofma.JCEGOADAOOI)
							{
								int num43 = hbpnmngofma.HDBGOLAFOBK();
								NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PKJMLDMLFCM(num43);
								if (jenmpdpjkbg != null)
								{
									jenmpdpjkbg.IPHMJFEBBJC(hbpnmngofma);
								}
								else
								{
									jenmpdpjkbg = new NLNNIDBPKAO.JENMPDPJKBG(num43, hbpnmngofma);
									JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GADJFFGDCFA.Add(num43, jenmpdpjkbg);
								}
								string iabkgmnjljo25 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg38"), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN, jenmpdpjkbg.JAGMEPMLCCP);
								if (jenmpdpjkbg.JAGMEPMLCCP == 0)
								{
									iabkgmnjljo25 = string.Format(JNBICAJIJMM.LEBHCLDODNI("cht_msg39"), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN);
								}
								Color lbcgackjcjb2 = Color.cyan;
								if (jenmpdpjkbg.JAGMEPMLCCP == 0)
								{
									lbcgackjcjb2 = Color.gray;
								}
								if (jenmpdpjkbg.JAGMEPMLCCP >= 5)
								{
									lbcgackjcjb2 = Color.yellow;
								}
								FlyMessageManager.getI.addMessageBig(iabkgmnjljo25, lbcgackjcjb2, 0, 0);
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo25);
							}
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("lut.ogg", 1f);
							goto IL_3C32;
						}
						if (ELEMIPMLIGG == 1410)
						{
							while (!hbpnmngofma.JCEGOADAOOI)
							{
								kfhelhglnmh.AFGFPHNFMOP();
								int num44 = hbpnmngofma.HDBGOLAFOBK();
								NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 = kfhelhglnmh.PKJMLDMLFCM(num44);
								if (jenmpdpjkbg2 == null)
								{
									jenmpdpjkbg2 = new NLNNIDBPKAO.JENMPDPJKBG(num44, null);
									kfhelhglnmh.GADJFFGDCFA.Add(num44, jenmpdpjkbg2);
								}
								jenmpdpjkbg2.IPHMJFEBBJC(hbpnmngofma);
							}
							goto IL_3C32;
						}
					}
				}
				else if (ELEMIPMLIGG <= 1510)
				{
					if (ELEMIPMLIGG <= 1450)
					{
						if (ELEMIPMLIGG != 1440)
						{
							if (ELEMIPMLIGG == 1450)
							{
								goto IL_3C32;
							}
						}
						else
						{
							if (RatingBoard.getI != null)
							{
								RatingBoard.getI.readFromServer(hbpnmngofma);
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else if (ELEMIPMLIGG != 1500)
					{
						if (ELEMIPMLIGG == 1510)
						{
							JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
							BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn9 = new BNOOIOKIFJC.DIGGOHPGCNN(hbpnmngofma.BFPHBMDMODH());
							if (!(Fisherman.getI == null))
							{
								Fisherman.getI.IHCKLDNAPDF = false;
								if (diggohpgcnn9.OKEBIHBDEOO("ok"))
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("batechange.ogg", 1f);
								}
								Fisherman.getI.selectedMIO = null;
								goto IL_3C32;
							}
							goto IL_3C32;
						}
					}
					else
					{
						JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
						if (!(Fisherman.getI == null))
						{
							Fisherman.getI.processHarvestEvnt(hbpnmngofma);
							goto IL_3C32;
						}
						goto IL_3C32;
					}
				}
				else if (ELEMIPMLIGG <= 1601)
				{
					if (ELEMIPMLIGG == 1600)
					{
						HMKIBAFDFDJ.IKGFHGKKCPG.MONCOFALJFP(hbpnmngofma);
						goto IL_3C32;
					}
					if (ELEMIPMLIGG == 1601)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
						HMKIBAFDFDJ.IKGFHGKKCPG.FAEBBEBLAMF();
						goto IL_3C32;
					}
				}
				else
				{
					if (ELEMIPMLIGG == 1610)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
						HMKIBAFDFDJ.IKGFHGKKCPG.CNMBNMAGLDD(hbpnmngofma);
						goto IL_3C32;
					}
					if (ELEMIPMLIGG == 1660)
					{
						HMKIBAFDFDJ.IKGFHGKKCPG.JEAEDEDINMJ(hbpnmngofma);
						goto IL_3C32;
					}
					switch (ELEMIPMLIGG)
					{
					case 1700:
						CLFFOBKFKDN.IKGFHGKKCPG.CNBIJKONBAH(hbpnmngofma);
						goto IL_3C32;
					case 1701:
						CLFFOBKFKDN.IKGFHGKKCPG.CNBIJKONBAH(hbpnmngofma);
						goto IL_3C32;
					case 1702:
						CLFFOBKFKDN.IKGFHGKKCPG.PKLOCMDAMKI(hbpnmngofma);
						goto IL_3C32;
					case 1703:
						CLFFOBKFKDN.IKGFHGKKCPG.EILCGHENCJK(hbpnmngofma.BFPHBMDMODH());
						goto IL_3C32;
					case 1704:
					{
						long num45 = hbpnmngofma.DNIIFBAIPBE();
						EKBAPCMPANI ekbapcmpani8 = kfhelhglnmh.FCHLEBEMIBK(num45);
						if (ekbapcmpani8 != null)
						{
							MDEKJCCIDIA.IKGFHGKKCPG.DGMMBBEIMHI(ekbapcmpani8);
							goto IL_3C32;
						}
						Debug.Log("1704 wpn id=" + num45 + " not found");
						goto IL_3C32;
					}
					case 1705:
						CLFFOBKFKDN.IKGFHGKKCPG.PKLOCMDAMKI(hbpnmngofma);
						goto IL_3C32;
					case 1706:
						Debug.Log("OPEN CONSTRUCT");
						CLFFOBKFKDN.IKGFHGKKCPG.JALPPBMBIME(hbpnmngofma);
						goto IL_3C32;
					case 1710:
					{
						string a4 = hbpnmngofma.BFPHBMDMODH();
						string iabkgmnjljo26 = "";
						if (a4 == "ok")
						{
							iabkgmnjljo26 = JNBICAJIJMM.LEBHCLDODNI("cht_msg40");
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
						}
						FlyMessageManager.getI.addRightMessage(iabkgmnjljo26, 0, 0, 0);
						goto IL_3C32;
					}
					}
				}
				Debug.Log("Unknow CMD:" + ELEMIPMLIGG);
				IL_3C32:;
			}
			finally
			{
				hbpnmngofma.LMBPNFHKNGA();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Packet processor error cmd: ",
				ELEMIPMLIGG,
				" Message: ",
				ex.Message,
				" ",
				ex.StackTrace
			}));
		}
	}

	// Token: 0x06007905 RID: 30981 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN DHGJHDBKLAL()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007906 RID: 30982 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN OBDBAABBAKB()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007907 RID: 30983 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN OELKEADDKPE()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007908 RID: 30984 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN DPBNHMCDIIK()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007909 RID: 30985 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EAJGHMMBAFP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790A RID: 30986 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN IFLFANPMLMM()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790B RID: 30987 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EAJHPOJPPFA()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790C RID: 30988 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN HLMNCDHECIP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790D RID: 30989 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN GICMOPPKLPC()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790E RID: 30990 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN ODDOIHEPICE()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600790F RID: 30991 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN NNEAHAFBOHC()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007910 RID: 30992 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN MHFDIJGJGBJ()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007911 RID: 30993 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EABHHPGNFFG()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007912 RID: 30994 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN GAPIOPHMBNB()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007913 RID: 30995 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EEOPOHEALPK()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007914 RID: 30996 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN BBLINJLBAIL()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007915 RID: 30997 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN FGHDAENJDHK()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007917 RID: 30999 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JMHOODFAGAM()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007918 RID: 31000 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN APMJBBDBOJO()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007919 RID: 31001 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN BOKIOJFHNLD()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791A RID: 31002 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN AGCBLDIBMNB()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791B RID: 31003 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN PAMNIOIJGNK()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791C RID: 31004 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN BPPFAOOCENN()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791D RID: 31005 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN FCNIKNBOFOJ()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791E RID: 31006 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN AIHINNHNNIA()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600791F RID: 31007 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN IOALEBMCEGM()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007920 RID: 31008 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN IELNFGAEHNE()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007921 RID: 31009 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN FEJILBICKGG()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007922 RID: 31010 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN DENFEOCOMJP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007923 RID: 31011 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN BCLPDGODGKF()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007924 RID: 31012 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EKEBHIJMEML()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007925 RID: 31013 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN IEFIFAEBNDI()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007926 RID: 31014 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JDELMFDJFNC()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007927 RID: 31015 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EAINABJCMHJ()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007928 RID: 31016 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN OOIJFNAMEDP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007929 RID: 31017 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JKDAKILNPJN()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN NEIPLKACAHP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792B RID: 31019 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN KOJCECHBHLO()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792C RID: 31020 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN GOECJDHPFEI()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792D RID: 31021 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN PFOLNEGNIPP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792E RID: 31022 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN PLGADNLAEGN()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x0600792F RID: 31023 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JPMFFGEBNMO()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN KFJMDGGMPJO()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06007931 RID: 31025 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN IKGFHGKKCPG
	{
		get
		{
			if (EMJAJDNLEJN.CCHGNBELGIA != null)
			{
				return EMJAJDNLEJN.CCHGNBELGIA;
			}
			EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
	}

	// Token: 0x06007932 RID: 31026 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN HIJIMBOKMMD()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007933 RID: 31027 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN NKFMJMHAAOB()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007934 RID: 31028 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JKIFIBEPICO()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN KEGBPOJKINC()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007936 RID: 31030 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN GDDAGIILGGM()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007937 RID: 31031 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN EDKKJNHDBPF()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007938 RID: 31032 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN NPCAKEGNBHD()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x06007939 RID: 31033 RVA: 0x0039EFEC File Offset: 0x0039D1EC
	public static EMJAJDNLEJN JHAAMBEFENP()
	{
		if (EMJAJDNLEJN.CCHGNBELGIA != null)
		{
			return EMJAJDNLEJN.CCHGNBELGIA;
		}
		EMJAJDNLEJN.CCHGNBELGIA = new EMJAJDNLEJN();
		return EMJAJDNLEJN.CCHGNBELGIA;
	}

	// Token: 0x04001186 RID: 4486
	private static EMJAJDNLEJN CCHGNBELGIA;

	// Token: 0x04001187 RID: 4487
	private float ECNCIDGFMFM;
}
