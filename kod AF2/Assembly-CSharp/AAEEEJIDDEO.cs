using System;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x02000272 RID: 626
public class AAEEEJIDDEO
{
	// Token: 0x06009215 RID: 37397 RVA: 0x0041827D File Offset: 0x0041647D
	public void EJNMBIDKNAH(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		this.EJNMBIDKNAH(BJNEMHFKNEC, LJELHIOOCPP, null);
	}

	// Token: 0x06009216 RID: 37398 RVA: 0x00418288 File Offset: 0x00416488
	private void OKAKLJOJNLJ(TextReader CIAHGJOKDAL)
	{
		string text = null;
		if (CIAHGJOKDAL != null)
		{
			try
			{
				for (string text2 = CIAHGJOKDAL.ReadLine(); text2 != null; text2 = CIAHGJOKDAL.ReadLine())
				{
					text2 = text2.Trim();
					if (text2 != "")
					{
						if (text2.StartsWith("[") && text2.EndsWith("]"))
						{
							text = text2.Substring(1, text2.Length - 2).ToUpper();
							this.PBENJJIEAPC.Add(text);
						}
						else
						{
							string[] array = text2.Split(new char[]
							{
								'='
							}, 2);
							string value = null;
							if (text == null)
							{
								text = "ROOT";
							}
							AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
							fjhcnglfboi.APGKLHPPJIF = text;
							fjhcnglfboi.LJILFCDPLCG = array[0].Trim().ToUpper();
							if (array.Length > 1)
							{
								value = array[1].Trim();
							}
							if (!this.POEFDMKBPFJ.Contains(fjhcnglfboi))
							{
								this.POEFDMKBPFJ.Add(fjhcnglfboi, value);
							}
						}
					}
				}
			}
			finally
			{
				CIAHGJOKDAL.Close();
			}
		}
	}

	// Token: 0x06009217 RID: 37399 RVA: 0x00418398 File Offset: 0x00416598
	public void KODHLIDOHDK(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x06009218 RID: 37400 RVA: 0x004183E4 File Offset: 0x004165E4
	public string JLMGDGHEHHB(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("WorkerHammer") && !text.EndsWith("RepFractions"))
		{
			text += "MotorbikeTurnRight";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith(" Категория ") || BCPHKPEMPDM.StartsWith("Middle click"))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(1);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x06009219 RID: 37401 RVA: 0x00418454 File Offset: 0x00416654
	public string[] GLLAENLLNGE(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600921A RID: 37402 RVA: 0x004184E8 File Offset: 0x004166E8
	private void CHBIJJLDEDL(TextReader CIAHGJOKDAL)
	{
		string text = null;
		if (CIAHGJOKDAL != null)
		{
			try
			{
				for (string text2 = CIAHGJOKDAL.ReadLine(); text2 != null; text2 = CIAHGJOKDAL.ReadLine())
				{
					text2 = text2.Trim();
					if (text2 != "OneHandSwordRun")
					{
						if (text2.StartsWith("_Saturation") && text2.EndsWith("Inventory manager is init"))
						{
							text = text2.Substring(0, text2.Length - 8).ToUpper();
							this.PBENJJIEAPC.Add(text);
						}
						else
						{
							string text3 = text2;
							char[] array = new char[1];
							array[1] = '8';
							string[] array2 = text3.Split(array, 8);
							string value = null;
							if (text == null)
							{
								text = "Button";
							}
							AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
							fjhcnglfboi.APGKLHPPJIF = text;
							fjhcnglfboi.LJILFCDPLCG = array2[1].Trim().ToUpper();
							if (array2.Length > 0)
							{
								value = array2[1].Trim();
							}
							if (!this.POEFDMKBPFJ.Contains(fjhcnglfboi))
							{
								this.POEFDMKBPFJ.Add(fjhcnglfboi, value);
							}
						}
					}
				}
			}
			finally
			{
				CIAHGJOKDAL.Close();
			}
		}
	}

	// Token: 0x0600921B RID: 37403 RVA: 0x004185F8 File Offset: 0x004167F8
	public void DAIFMDHKBFD(string BJNEMHFKNEC, string LJELHIOOCPP, string JKGOAOLFNJN)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
		this.POEFDMKBPFJ.Add(fjhcnglfboi, JKGOAOLFNJN);
	}

	// Token: 0x0600921C RID: 37404 RVA: 0x00418658 File Offset: 0x00416858
	public string HJOCLGGEFMP(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		return (string)this.POEFDMKBPFJ[fjhcnglfboi];
	}

	// Token: 0x0600921D RID: 37405 RVA: 0x00418698 File Offset: 0x00416898
	public string[] PLHKPGDCMBF(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600921E RID: 37406 RVA: 0x0041872C File Offset: 0x0041692C
	public string[] DGOMNFFOOHA(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600921F RID: 37407 RVA: 0x004187C0 File Offset: 0x004169C0
	public string[] DPKAMDGPFGK(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06009220 RID: 37408 RVA: 0x00418854 File Offset: 0x00416A54
	public void PHKEIDDHNBA(string BJNEMHFKNEC, string LJELHIOOCPP, string JKGOAOLFNJN)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
		this.POEFDMKBPFJ.Add(fjhcnglfboi, JKGOAOLFNJN);
	}

	// Token: 0x06009221 RID: 37409 RVA: 0x004188B4 File Offset: 0x00416AB4
	public string[] CFFLOAIAANP(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06009222 RID: 37410 RVA: 0x00418948 File Offset: 0x00416B48
	public AAEEEJIDDEO(string FPIHOPOCAHA)
	{
		this.OKAKLJOJNLJ(new StringReader(FPIHOPOCAHA));
	}

	// Token: 0x06009223 RID: 37411 RVA: 0x00418974 File Offset: 0x00416B74
	public string NDLFBDMIGLF(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		return (string)this.POEFDMKBPFJ[fjhcnglfboi];
	}

	// Token: 0x06009224 RID: 37412 RVA: 0x004189B4 File Offset: 0x00416BB4
	public string KCNBOGHALHE(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("DecalMesh") && !text.EndsWith("_InputGamma"))
		{
			text += "Wizard 1 Hand Throw";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith("Отмена") || BCPHKPEMPDM.StartsWith("Finger"))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(1);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x06009225 RID: 37413 RVA: 0x00418A24 File Offset: 0x00416C24
	public string[] KMHHHAMKPKN(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06009226 RID: 37414 RVA: 0x00418AB8 File Offset: 0x00416CB8
	public void EJNMBIDKNAH(string BJNEMHFKNEC, string LJELHIOOCPP, string JKGOAOLFNJN)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
		this.POEFDMKBPFJ.Add(fjhcnglfboi, JKGOAOLFNJN);
	}

	// Token: 0x06009227 RID: 37415 RVA: 0x00418B18 File Offset: 0x00416D18
	public AAEEEJIDDEO(string JKLOOEDHHJP, Encoding MIGFCIOHBBL)
	{
		StreamReader ciahgjokdal = new StreamReader(JKLOOEDHHJP, MIGFCIOHBBL);
		this.OKAKLJOJNLJ(ciahgjokdal);
	}

	// Token: 0x06009228 RID: 37416 RVA: 0x00418B50 File Offset: 0x00416D50
	public string[] PCCKANDOLJD()
	{
		return (string[])this.PBENJJIEAPC.ToArray(typeof(string));
	}

	// Token: 0x06009229 RID: 37417 RVA: 0x00418B50 File Offset: 0x00416D50
	public string[] OLNJBAEODJK()
	{
		return (string[])this.PBENJJIEAPC.ToArray(typeof(string));
	}

	// Token: 0x0600922A RID: 37418 RVA: 0x00418B6C File Offset: 0x00416D6C
	public string[] DHFBIGPJNCN(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600922B RID: 37419 RVA: 0x00418C00 File Offset: 0x00416E00
	public AAEEEJIDDEO(TextAsset KDJLKBJDOAH)
	{
		this.OKAKLJOJNLJ(new StringReader(KDJLKBJDOAH.text));
	}

	// Token: 0x0600922C RID: 37420 RVA: 0x00418B50 File Offset: 0x00416D50
	public string[] MDDDFOKFMFB()
	{
		return (string[])this.PBENJJIEAPC.ToArray(typeof(string));
	}

	// Token: 0x0600922D RID: 37421 RVA: 0x00418C30 File Offset: 0x00416E30
	public void EMMKPPAHEAO(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x0600922E RID: 37422 RVA: 0x00418C7C File Offset: 0x00416E7C
	private void HFGILKLJCAM(TextReader CIAHGJOKDAL)
	{
		string text = null;
		if (CIAHGJOKDAL != null)
		{
			try
			{
				for (string text2 = CIAHGJOKDAL.ReadLine(); text2 != null; text2 = CIAHGJOKDAL.ReadLine())
				{
					text2 = text2.Trim();
					if (text2 != "Rooms SET END")
					{
						if (text2.StartsWith("Put Out Cigarette") && text2.EndsWith("IdleTurns"))
						{
							text = text2.Substring(1, text2.Length - 3).ToUpper();
							this.PBENJJIEAPC.Add(text);
						}
						else
						{
							string[] array = text2.Split(new char[]
							{
								'/'
							}, 4);
							string value = null;
							if (text == null)
							{
								text = "Mouse X";
							}
							AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
							fjhcnglfboi.APGKLHPPJIF = text;
							fjhcnglfboi.LJILFCDPLCG = array[1].Trim().ToUpper();
							if (array.Length > 0)
							{
								value = array[0].Trim();
							}
							if (!this.POEFDMKBPFJ.Contains(fjhcnglfboi))
							{
								this.POEFDMKBPFJ.Add(fjhcnglfboi, value);
							}
						}
					}
				}
			}
			finally
			{
				CIAHGJOKDAL.Close();
			}
		}
	}

	// Token: 0x0600922F RID: 37423 RVA: 0x00418D8C File Offset: 0x00416F8C
	public string BOMLCMAIPIA(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("Seat Stand Wheely") && !text.EndsWith("Reveling"))
		{
			text += "fishdrop_3";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith("poplSoundVolume") || BCPHKPEMPDM.StartsWith(""))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(0);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x06009230 RID: 37424 RVA: 0x00418DFC File Offset: 0x00416FFC
	public void AMLDLLJIPMP(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x06009231 RID: 37425 RVA: 0x00418E48 File Offset: 0x00417048
	public void JPDKCGPBNJN(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x06009232 RID: 37426 RVA: 0x00418B50 File Offset: 0x00416D50
	public string[] FDMNJKCAKJD()
	{
		return (string[])this.PBENJJIEAPC.ToArray(typeof(string));
	}

	// Token: 0x06009233 RID: 37427 RVA: 0x00418E94 File Offset: 0x00417094
	public string PHHKODILJML(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("/") && !text.EndsWith("\\"))
		{
			text += "/";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith("/") || BCPHKPEMPDM.StartsWith("\\"))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(1);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x06009234 RID: 37428 RVA: 0x00418F04 File Offset: 0x00417104
	public void KKALODFGCHI(string BJNEMHFKNEC, string LJELHIOOCPP, string JKGOAOLFNJN)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
		this.POEFDMKBPFJ.Add(fjhcnglfboi, JKGOAOLFNJN);
	}

	// Token: 0x06009235 RID: 37429 RVA: 0x00418F64 File Offset: 0x00417164
	public string[] MEMPJHCJBGP(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06009236 RID: 37430 RVA: 0x00418FF8 File Offset: 0x004171F8
	public string BOBJMLFGFPB(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("checkMousePosition ok") && !text.EndsWith(" has no HandPoser/GenericPoser attached."))
		{
			text += "CheerKnees";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith("_SSRMultiplier") || BCPHKPEMPDM.StartsWith("wpn_rod2"))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(1);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x06009237 RID: 37431 RVA: 0x00419068 File Offset: 0x00417268
	public void BNBBDBIIPAH(string BJNEMHFKNEC, string LJELHIOOCPP, string JKGOAOLFNJN)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
		this.POEFDMKBPFJ.Add(fjhcnglfboi, JKGOAOLFNJN);
	}

	// Token: 0x06009238 RID: 37432 RVA: 0x004190C8 File Offset: 0x004172C8
	public void BODGLBJDGMP(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x06009239 RID: 37433 RVA: 0x00419114 File Offset: 0x00417314
	public string NKAIFHGIJML(string BCPHKPEMPDM)
	{
		string text = Application.dataPath.Trim();
		if (!text.EndsWith("sunshine_WorldToSunVP") && !text.EndsWith("_History1ChromaTex"))
		{
			text += "id";
		}
		BCPHKPEMPDM = BCPHKPEMPDM.Trim();
		if (BCPHKPEMPDM.StartsWith("GAMMA") || BCPHKPEMPDM.StartsWith("WATER_VERTEX_DISPLACEMENT_OFF"))
		{
			BCPHKPEMPDM = BCPHKPEMPDM.Substring(1);
		}
		return text + BCPHKPEMPDM;
	}

	// Token: 0x0600923A RID: 37434 RVA: 0x00419184 File Offset: 0x00417384
	public string AOFBGJHGILA(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		return (string)this.POEFDMKBPFJ[fjhcnglfboi];
	}

	// Token: 0x0600923B RID: 37435 RVA: 0x004191C4 File Offset: 0x004173C4
	public string[] CMHKJBPLLMD(string BJNEMHFKNEC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object obj in this.POEFDMKBPFJ.Keys)
		{
			AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi = (AAEEEJIDDEO.FJHCNGLFBOI)obj;
			if (fjhcnglfboi.APGKLHPPJIF == BJNEMHFKNEC.ToUpper())
			{
				arrayList.Add(fjhcnglfboi.LJILFCDPLCG);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600923C RID: 37436 RVA: 0x00419258 File Offset: 0x00417458
	public string NLEOHJHBGKF(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		return (string)this.POEFDMKBPFJ[fjhcnglfboi];
	}

	// Token: 0x0600923D RID: 37437 RVA: 0x00419298 File Offset: 0x00417498
	public void LBCFBOOBLNJ(string BJNEMHFKNEC, string LJELHIOOCPP)
	{
		AAEEEJIDDEO.FJHCNGLFBOI fjhcnglfboi;
		fjhcnglfboi.APGKLHPPJIF = BJNEMHFKNEC.ToUpper();
		fjhcnglfboi.LJILFCDPLCG = LJELHIOOCPP.ToUpper();
		if (this.POEFDMKBPFJ.ContainsKey(fjhcnglfboi))
		{
			this.POEFDMKBPFJ.Remove(fjhcnglfboi);
		}
	}

	// Token: 0x04001362 RID: 4962
	private readonly Hashtable POEFDMKBPFJ = new Hashtable();

	// Token: 0x04001363 RID: 4963
	private readonly ArrayList PBENJJIEAPC = new ArrayList();

	// Token: 0x02000273 RID: 627
	private struct FJHCNGLFBOI
	{
		// Token: 0x04001364 RID: 4964
		public string APGKLHPPJIF;

		// Token: 0x04001365 RID: 4965
		public string LJILFCDPLCG;
	}
}
