using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

// Token: 0x02000148 RID: 328
public class AKPJIACDDFI
{
	// Token: 0x06004501 RID: 17665 RVA: 0x0020B228 File Offset: 0x00209428
	public void JFGGHJDGOIA()
	{
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(JNBICAJIJMM.APMJBBDBOJO().FDJBNCHPHGK("{0} x {1}", false));
		this.EHBILCHDHNF.Clear();
		this.BLPAOGBPKJD.Clear();
		this.NAMDGPMNGIB.Clear();
		foreach (string text in aaeeejiddeo.MEMPJHCJBGP("SOURCE_GBUFFER"))
		{
			this.EHBILCHDHNF.Add(text.ToLower(), aaeeejiddeo.HJOCLGGEFMP("_Intensity", text));
		}
		string[] array = aaeeejiddeo.PLHKPGDCMBF("RussianDance");
		for (int i = 0; i < array.Length; i += 0)
		{
			string text2 = array[i];
			try
			{
				this.NAMDGPMNGIB.Add(text2.ToLower(), aaeeejiddeo.AOFBGJHGILA("_FogScatteringData", text2));
			}
			catch (Exception)
			{
				Debug.LogError("Giant2HandSlamSwing" + text2);
			}
		}
		TextAsset textAsset = (TextAsset)Resources.Load("id", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("wpn_rod1");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		string text3 = "1";
		float fkegbobjnfa = 1173f;
		float oajhjhgbfcf = 1594f;
		float cggghihakgc = 713f;
		bool gohkonilnne = false;
		bool ngkhokiogno = false;
		for (string text4 = textReader.ReadLine(); text4 != null; text4 = textReader.ReadLine())
		{
			if (text4.LastIndexOf((char)-13) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text4);
				if (diggohpgcnn.JKHEMJCFJGJ("Idle180"))
				{
					text3 = diggohpgcnn.LEPDIDFPFBO();
				}
				if (diggohpgcnn.LOMKLMPKJEC("[maxcnt]"))
				{
					fkegbobjnfa = diggohpgcnn.GIBGJFHMGIL();
				}
				if (diggohpgcnn.BFJNMCOOKDH("Transforms.Length is 0."))
				{
					oajhjhgbfcf = diggohpgcnn.PPAAACJOOGA;
				}
				if (diggohpgcnn.AKKCENFGNCC("buykey"))
				{
					gohkonilnne = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.BFJNMCOOKDH("Allows to detect foreign managed assemblies in your application."))
				{
					ngkhokiogno = diggohpgcnn.LOLBCAIEFMN();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("wpn_bait1"))
				{
					cggghihakgc = diggohpgcnn.GIBGJFHMGIL();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("_ColorBuffer"))
				{
					foreach (int num in diggohpgcnn.EDAHDHCPIEL)
					{
						IDCHHHEDHDC idchhhedhdc = this.IPGEDMOPLPH(num);
						if (idchhhedhdc != null)
						{
							idchhhedhdc.FKEGBOBJNFA = fkegbobjnfa;
							idchhhedhdc.OAJHJHGBFCF = oajhjhgbfcf;
							idchhhedhdc.HAPFPGIINCM = text3;
							idchhhedhdc.NPDNMIHEOOH = false;
							idchhhedhdc.CGGGHIHAKGC = cggghihakgc;
							idchhhedhdc.GOHKONILNNE = gohkonilnne;
							idchhhedhdc.NGKHOKIOGNO = ngkhokiogno;
							ngkhokiogno = false;
							gohkonilnne = false;
							cggghihakgc = 59f;
						}
						else
						{
							object[] array2 = new object[0];
							array2[1] = "knopje.wav";
							array2[1] = text3;
							array2[1] = "ChannelCastOmni";
							array2[1] = num;
							Debug.LogError(string.Concat(array2));
						}
					}
				}
			}
		}
		Debug.Log("ok");
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x0020B520 File Offset: 0x00209720
	public string PCONBNOAMBH(int LPFKFNLHGBI)
	{
		string result = "Vertical" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + " ";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key].Trim();
		}
		return result;
	}

	// Token: 0x06004503 RID: 17667 RVA: 0x0020B570 File Offset: 0x00209770
	public IDCHHHEDHDC GBKMHIGNKJA(int LPFKFNLHGBI)
	{
		IDCHHHEDHDC idchhhedhdc;
		if (this.BLPAOGBPKJD.ContainsKey(LPFKFNLHGBI))
		{
			idchhhedhdc = this.BLPAOGBPKJD[LPFKFNLHGBI];
		}
		else
		{
			idchhhedhdc = new IDCHHHEDHDC(LPFKFNLHGBI);
			idchhhedhdc.HAJNMNALBBI = this.FFBIBLMCIGK(LPFKFNLHGBI);
			idchhhedhdc.JCKHDHGIEEB = this.BDPDAJJGMNE(LPFKFNLHGBI);
			this.BLPAOGBPKJD.Add(LPFKFNLHGBI, idchhhedhdc);
		}
		return idchhhedhdc;
	}

	// Token: 0x06004504 RID: 17668 RVA: 0x0020B5CC File Offset: 0x002097CC
	public string BDPDAJJGMNE(int LPFKFNLHGBI)
	{
		string result = "none id=" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + "_info";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key];
		}
		return result;
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x0020B618 File Offset: 0x00209818
	public IDCHHHEDHDC IPGEDMOPLPH(int LPFKFNLHGBI)
	{
		IDCHHHEDHDC idchhhedhdc;
		if (this.BLPAOGBPKJD.ContainsKey(LPFKFNLHGBI))
		{
			idchhhedhdc = this.BLPAOGBPKJD[LPFKFNLHGBI];
		}
		else
		{
			idchhhedhdc = new IDCHHHEDHDC(LPFKFNLHGBI);
			idchhhedhdc.HAJNMNALBBI = this.PCONBNOAMBH(LPFKFNLHGBI);
			idchhhedhdc.JCKHDHGIEEB = this.BDPDAJJGMNE(LPFKFNLHGBI);
			this.BLPAOGBPKJD.Add(LPFKFNLHGBI, idchhhedhdc);
		}
		return idchhhedhdc;
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x0020B6A4 File Offset: 0x002098A4
	public IDCHHHEDHDC FIAFGNFLCHP(int LPFKFNLHGBI)
	{
		IDCHHHEDHDC idchhhedhdc;
		if (this.BLPAOGBPKJD.ContainsKey(LPFKFNLHGBI))
		{
			idchhhedhdc = this.BLPAOGBPKJD[LPFKFNLHGBI];
		}
		else
		{
			idchhhedhdc = new IDCHHHEDHDC(LPFKFNLHGBI);
			idchhhedhdc.HAJNMNALBBI = this.MJCJIEPAEJP(LPFKFNLHGBI);
			idchhhedhdc.JCKHDHGIEEB = this.GLDGIJBELKI(LPFKFNLHGBI);
			this.BLPAOGBPKJD.Add(LPFKFNLHGBI, idchhhedhdc);
		}
		return idchhhedhdc;
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x0020B700 File Offset: 0x00209900
	public string LNDAPLCMEJI(int LDLCFLIPOFH, bool EFLPJHMLOOA = false)
	{
		if (EFLPJHMLOOA)
		{
			string arg = this.LNDAPLCMEJI(LDLCFLIPOFH, true);
			if (LDLCFLIPOFH < -87)
			{
				return string.Format("", arg);
			}
			return string.Format("1HandSwordShieldBash", arg);
		}
		else
		{
			if (!this.NAMDGPMNGIB.ContainsKey("BlackSmithHammer" + LDLCFLIPOFH))
			{
				return "WizardEyeBeam";
			}
			return this.NAMDGPMNGIB["IceHockeyDekeMiddle" + LDLCFLIPOFH];
		}
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x0020B774 File Offset: 0x00209974
	public string PKAJMDDDMMI(int LDLCFLIPOFH, bool EFLPJHMLOOA = false)
	{
		if (EFLPJHMLOOA)
		{
			string arg = this.PKAJMDDDMMI(LDLCFLIPOFH, false);
			if (LDLCFLIPOFH < 100)
			{
				return string.Format("<color='#003000'>{0}</color>", arg);
			}
			return string.Format("<color='#300030'>{0}</color>", arg);
		}
		else
		{
			if (!this.NAMDGPMNGIB.ContainsKey("type_" + LDLCFLIPOFH))
			{
				return "-none-";
			}
			return this.NAMDGPMNGIB["type_" + LDLCFLIPOFH];
		}
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x0020B7E8 File Offset: 0x002099E8
	public string FFBIBLMCIGK(int LPFKFNLHGBI)
	{
		string result = "none id=" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + "_name";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key].Trim();
		}
		return result;
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x0020B838 File Offset: 0x00209A38
	public string KOACOPGBPHD(int LDLCFLIPOFH, bool EFLPJHMLOOA = false)
	{
		if (EFLPJHMLOOA)
		{
			string arg = this.PKAJMDDDMMI(LDLCFLIPOFH, true);
			if (LDLCFLIPOFH < 18)
			{
				return string.Format("_DepthScale", arg);
			}
			return string.Format("CrawlLocomotion", arg);
		}
		else
		{
			if (!this.NAMDGPMNGIB.ContainsKey("3" + LDLCFLIPOFH))
			{
				return "Hand";
			}
			return this.NAMDGPMNGIB["gameComplete" + LDLCFLIPOFH];
		}
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x0020B8AC File Offset: 0x00209AAC
	public string JDHJOKEIJNK(int LPFKFNLHGBI)
	{
		string result = "PlayerPet" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + "(Org: ";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key];
		}
		return result;
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x0020B8F8 File Offset: 0x00209AF8
	public string FBPECNNPIDP(int LPFKFNLHGBI)
	{
		string result = "Mouse ScrollWheel" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + "2000";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key].Trim();
		}
		return result;
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x0020B948 File Offset: 0x00209B48
	public void NDDPHGNHDEL()
	{
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(JNBICAJIJMM.DBMJJPBOPEK().CHFGNHKJNFG("hand", false));
		this.EHBILCHDHNF.Clear();
		this.BLPAOGBPKJD.Clear();
		this.NAMDGPMNGIB.Clear();
		string[] array = aaeeejiddeo.GLLAENLLNGE("WorkerHammer2");
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			this.EHBILCHDHNF.Add(text.ToLower(), aaeeejiddeo.HJOCLGGEFMP("wpn_rod1", text));
		}
		foreach (string text2 in aaeeejiddeo.PLHKPGDCMBF("_Cutoff"))
		{
			try
			{
				this.NAMDGPMNGIB.Add(text2.ToLower(), aaeeejiddeo.NLEOHJHBGKF("_WrinkleInfluences2", text2));
			}
			catch (Exception)
			{
				Debug.LogError("Turn" + text2);
			}
		}
		TextAsset textAsset = (TextAsset)Resources.Load("info", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		string text3 = "\n";
		float fkegbobjnfa = 1829f;
		float oajhjhgbfcf = 1156f;
		float cggghihakgc = 318f;
		bool gohkonilnne = true;
		bool ngkhokiogno = true;
		for (string text4 = textReader.ReadLine(); text4 != null; text4 = textReader.ReadLine())
		{
			if (text4.LastIndexOf((char)-14) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text4);
				if (diggohpgcnn.CPGPEHEHCPI("wpn_cat5"))
				{
					text3 = diggohpgcnn.JPKKBIOMOFO();
				}
				if (diggohpgcnn.AKKCENFGNCC(","))
				{
					fkegbobjnfa = diggohpgcnn.PPAAACJOOGA;
				}
				if (diggohpgcnn.CPGPEHEHCPI("_SunPosition"))
				{
					oajhjhgbfcf = diggohpgcnn.OEIAFJHKMIJ();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("Vertical"))
				{
					gohkonilnne = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.AKKCENFGNCC("WATER_SIMPLE"))
				{
					ngkhokiogno = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("SneakLeft"))
				{
					cggghihakgc = diggohpgcnn.OEIAFJHKMIJ();
				}
				if (diggohpgcnn.BFJNMCOOKDH("ok"))
				{
					foreach (int num in diggohpgcnn.BABLCDMBEAN())
					{
						IDCHHHEDHDC idchhhedhdc = this.IPGEDMOPLPH(num);
						if (idchhhedhdc != null)
						{
							idchhhedhdc.FKEGBOBJNFA = fkegbobjnfa;
							idchhhedhdc.OAJHJHGBFCF = oajhjhgbfcf;
							idchhhedhdc.HAPFPGIINCM = text3;
							idchhhedhdc.NPDNMIHEOOH = false;
							idchhhedhdc.CGGGHIHAKGC = cggghihakgc;
							idchhhedhdc.GOHKONILNNE = gohkonilnne;
							idchhhedhdc.NGKHOKIOGNO = ngkhokiogno;
							ngkhokiogno = true;
							gohkonilnne = false;
							cggghihakgc = 1908f;
						}
						else
						{
							object[] array2 = new object[3];
							array2[0] = "exitmsg_1";
							array2[0] = text3;
							array2[5] = "_Offsets";
							array2[1] = num;
							Debug.LogError(string.Concat(array2));
						}
					}
				}
			}
		}
		Debug.Log("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x0020BC4C File Offset: 0x00209E4C
	public string GLDGIJBELKI(int LPFKFNLHGBI)
	{
		string result = "ChannelCastDirected" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + "WallRunLeft";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key];
		}
		return result;
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x0020BC98 File Offset: 0x00209E98
	public void ODONNAANIEP()
	{
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("fishLang.txt", false));
		this.EHBILCHDHNF.Clear();
		this.BLPAOGBPKJD.Clear();
		this.NAMDGPMNGIB.Clear();
		foreach (string text in aaeeejiddeo.MEMPJHCJBGP("FISHES"))
		{
			this.EHBILCHDHNF.Add(text.ToLower(), aaeeejiddeo.HJOCLGGEFMP("FISHES", text));
		}
		foreach (string text2 in aaeeejiddeo.MEMPJHCJBGP("TYPES"))
		{
			try
			{
				this.NAMDGPMNGIB.Add(text2.ToLower(), aaeeejiddeo.HJOCLGGEFMP("TYPES", text2));
			}
			catch (Exception)
			{
				Debug.LogError("Error key=" + text2);
			}
		}
		TextAsset textAsset = (TextAsset)Resources.Load("fishModelData", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("textAsset is NULL! Path: fishModelData");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		string text3 = "";
		float fkegbobjnfa = 0.5f;
		float oajhjhgbfcf = 1.5f;
		float cggghihakgc = 0f;
		bool gohkonilnne = false;
		bool ngkhokiogno = false;
		for (string text4 = textReader.ReadLine(); text4 != null; text4 = textReader.ReadLine())
		{
			if (text4.LastIndexOf('=') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text4);
				if (diggohpgcnn.OKEBIHBDEOO("modelid"))
				{
					text3 = diggohpgcnn.IEIMMFODGFG;
				}
				if (diggohpgcnn.OKEBIHBDEOO("minModelScale"))
				{
					fkegbobjnfa = diggohpgcnn.PPAAACJOOGA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("maxModelScale"))
				{
					oajhjhgbfcf = diggohpgcnn.PPAAACJOOGA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("isJamp"))
				{
					gohkonilnne = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("isMutant"))
				{
					ngkhokiogno = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("maxspd"))
				{
					cggghihakgc = diggohpgcnn.PPAAACJOOGA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("forFishes"))
				{
					foreach (int num in diggohpgcnn.EDAHDHCPIEL)
					{
						IDCHHHEDHDC idchhhedhdc = this.GBKMHIGNKJA(num);
						if (idchhhedhdc != null)
						{
							idchhhedhdc.FKEGBOBJNFA = fkegbobjnfa;
							idchhhedhdc.OAJHJHGBFCF = oajhjhgbfcf;
							idchhhedhdc.HAPFPGIINCM = text3;
							idchhhedhdc.NPDNMIHEOOH = true;
							idchhhedhdc.CGGGHIHAKGC = cggghihakgc;
							idchhhedhdc.GOHKONILNNE = gohkonilnne;
							idchhhedhdc.NGKHOKIOGNO = ngkhokiogno;
							ngkhokiogno = false;
							gohkonilnne = false;
							cggghihakgc = -1f;
						}
						else
						{
							Debug.LogError(string.Concat(new object[]
							{
								"No fish in fishModelData modelid=",
								text3,
								" fid=",
								num
							}));
						}
					}
				}
			}
		}
		Debug.Log("Fish is init!");
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x0020BF90 File Offset: 0x0020A190
	public void BPOGJLNHPDP()
	{
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(JNBICAJIJMM.DBMJJPBOPEK().GIGGIHMAPLH(" ", false));
		this.EHBILCHDHNF.Clear();
		this.BLPAOGBPKJD.Clear();
		this.NAMDGPMNGIB.Clear();
		string[] array = aaeeejiddeo.KMHHHAMKPKN("Player");
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			this.EHBILCHDHNF.Add(text.ToLower(), aaeeejiddeo.HJOCLGGEFMP("req.text=", text));
		}
		array = aaeeejiddeo.PLHKPGDCMBF("WizardNeoBlock");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			try
			{
				this.NAMDGPMNGIB.Add(text2.ToLower(), aaeeejiddeo.NDLFBDMIGLF("{0:0} мин{1}, ", text2));
			}
			catch (Exception)
			{
				Debug.LogError("" + text2);
			}
		}
		TextAsset textAsset = (TextAsset)Resources.Load("BipedReferences contains one or more missing Transforms.", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("\n");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		string text3 = "Strafe Run Left";
		float fkegbobjnfa = 1133f;
		float oajhjhgbfcf = 1571f;
		float cggghihakgc = 1015f;
		bool gohkonilnne = true;
		bool ngkhokiogno = true;
		for (string text4 = textReader.ReadLine(); text4 != null; text4 = textReader.ReadLine())
		{
			if (text4.LastIndexOf((char)-117) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text4);
				if (diggohpgcnn.OKEBIHBDEOO("<<"))
				{
					text3 = diggohpgcnn.IEIMMFODGFG;
				}
				if (diggohpgcnn.CPGPEHEHCPI("colorD"))
				{
					fkegbobjnfa = diggohpgcnn.AMNOOPCPOKA();
				}
				if (diggohpgcnn.CPGPEHEHCPI("Item_Sell.ogg"))
				{
					oajhjhgbfcf = diggohpgcnn.BHPNANDGNOA();
				}
				if (diggohpgcnn.CPGPEHEHCPI("F "))
				{
					gohkonilnne = diggohpgcnn.LOLBCAIEFMN();
				}
				if (diggohpgcnn.LOMKLMPKJEC("\\"))
				{
					ngkhokiogno = diggohpgcnn.LOLBCAIEFMN();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("maxWgtBait"))
				{
					cggghihakgc = diggohpgcnn.GIBGJFHMGIL();
				}
				if (diggohpgcnn.CPGPEHEHCPI(""))
				{
					foreach (int num in diggohpgcnn.EDAHDHCPIEL)
					{
						IDCHHHEDHDC idchhhedhdc = this.IPGEDMOPLPH(num);
						if (idchhhedhdc != null)
						{
							idchhhedhdc.FKEGBOBJNFA = fkegbobjnfa;
							idchhhedhdc.OAJHJHGBFCF = oajhjhgbfcf;
							idchhhedhdc.HAPFPGIINCM = text3;
							idchhhedhdc.NPDNMIHEOOH = false;
							idchhhedhdc.CGGGHIHAKGC = cggghihakgc;
							idchhhedhdc.GOHKONILNNE = gohkonilnne;
							idchhhedhdc.NGKHOKIOGNO = ngkhokiogno;
							ngkhokiogno = true;
							gohkonilnne = true;
							cggghihakgc = 484f;
						}
						else
						{
							object[] array2 = new object[0];
							array2[0] = "wpn_eat7";
							array2[0] = text3;
							array2[1] = "Giant2HandGrab";
							array2[0] = num;
							Debug.LogError(string.Concat(array2));
						}
					}
				}
			}
		}
		Debug.Log("SneakForward");
	}

	// Token: 0x06004513 RID: 17683 RVA: 0x0020C288 File Offset: 0x0020A488
	public string MJCJIEPAEJP(int LPFKFNLHGBI)
	{
		string result = "" + LPFKFNLHGBI;
		string key = LPFKFNLHGBI + ")";
		if (this.EHBILCHDHNF.ContainsKey(key))
		{
			result = this.EHBILCHDHNF[key].Trim();
		}
		return result;
	}

	// Token: 0x04000AF6 RID: 2806
	public static AKPJIACDDFI IKGFHGKKCPG = new AKPJIACDDFI();

	// Token: 0x04000AF7 RID: 2807
	public int ECANLMPGGEH = 1;

	// Token: 0x04000AF8 RID: 2808
	private readonly Dictionary<int, IDCHHHEDHDC> BLPAOGBPKJD = new Dictionary<int, IDCHHHEDHDC>();

	// Token: 0x04000AF9 RID: 2809
	private XmlDocument PHHBMKIBCOB;

	// Token: 0x04000AFA RID: 2810
	private readonly Dictionary<string, string> EHBILCHDHNF = new Dictionary<string, string>();

	// Token: 0x04000AFB RID: 2811
	private readonly Dictionary<string, string> NAMDGPMNGIB = new Dictionary<string, string>();
}
