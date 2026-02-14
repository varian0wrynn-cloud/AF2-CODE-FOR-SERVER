using System;
using System.Collections;
using Steamworks;
using UnityEngine;

// Token: 0x0200022E RID: 558
public class SteamLogic : MonoBehaviour
{
	// Token: 0x06007FCB RID: 32715 RVA: 0x003D2688 File Offset: 0x003D0888
	public Texture2D FNPHBMEKDON(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 8U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.Alpha8, true, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 3U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.NEDIPGMNODP(texture2D);
		}
		Debug.LogError("◍◍◍");
		return new Texture2D(0, 0);
	}

	// Token: 0x06007FCC RID: 32716 RVA: 0x003D2700 File Offset: 0x003D0900
	public string JCINCEJEGJN()
	{
		string result = "cht_msg21";
		if (SteamManager.GHHNBKFIFOC())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06007FCD RID: 32717 RVA: 0x003D2724 File Offset: 0x003D0924
	public Texture2D AHODKNBOJEO(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)8, true, true);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.ACMDFBHLNDA(texture2D);
		}
		Debug.LogError("_HdrParams");
		return new Texture2D(1, 0);
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x003D279C File Offset: 0x003D099C
	public void NJHMBCDNDGN(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.NGEACBIHBOP())
		{
			float num = 1337f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			Debug.Log(string.Concat(new object[]
			{
				"Noise & Grain effect failing as noise texture is not assigned. please assign.",
				KFIDPBAIFLE,
				null,
				"Player",
				num
			}));
		}
	}

	// Token: 0x06007FCF RID: 32719 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator GBMDFGCCNCF(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06007FD0 RID: 32720 RVA: 0x003D2808 File Offset: 0x003D0A08
	public void DAHIDFLKNCN(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.FNNHOLIBGJH())
		{
			int num = 0;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[5];
			array[1] = "_WaterLevel";
			array[1] = KFIDPBAIFLE;
			array[0] = "Clear";
			array[1] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x003D2860 File Offset: 0x003D0A60
	public void DLIPPNOJNAL(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.JBKCBLGNLLG())
		{
			int num = 1;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[7];
			array[0] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html";
			array[1] = KFIDPBAIFLE;
			array[4] = "_WrinkleMask";
			array[7] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x003D28B8 File Offset: 0x003D0AB8
	private Texture2D NEDIPGMNODP(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 1; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007FD3 RID: 32723 RVA: 0x003D2920 File Offset: 0x003D0B20
	private void JILHNLIPGLJ(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("PistolReady", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "isDrop action";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "isWoman";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("Poplavok", ulOrderID, num, arg);
		base.StartCoroutine(this.OILHBLHPFMD(alboclbfnni));
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x003D29B0 File Offset: 0x003D0BB0
	private void APJJAKLMLAN(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("WeaponReady", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "0";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "Formatted Label";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("shop_t9", ulOrderID, num, arg);
		base.StartCoroutine(this.OAHIFBFLGPK(alboclbfnni));
	}

	// Token: 0x06007FD5 RID: 32725 RVA: 0x003D2A3D File Offset: 0x003D0C3D
	private IEnumerator LOMIDFCHADP(string ALBOCLBFNNI)
	{
		WWW www = new WWW(ALBOCLBFNNI);
		yield return www;
		if (www.isDone)
		{
			Debug.Log("final ok: " + www.text);
			if (www.text.Trim() != "OK")
			{
				Debug.Log("req.text=" + www.text);
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error!", www.text);
			}
		}
		else
		{
			Debug.LogError("Error via final request");
		}
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(105, 33);
		}
		yield break;
	}

	// Token: 0x06007FD6 RID: 32726 RVA: 0x003D2A4C File Offset: 0x003D0C4C
	public void EKOCBFEAKLG(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.GHHNBKFIFOC())
		{
			float num = 1274f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[3];
			array[1] = "inv_inv";
			array[0] = KFIDPBAIFLE;
			array[3] = "RunDive";
			array[4] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FD7 RID: 32727 RVA: 0x003D2AA8 File Offset: 0x003D0CA8
	public string JIBPOALDAJH()
	{
		string result = "B";
		if (SteamManager.LCKFPOLOJJH())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06007FD8 RID: 32728 RVA: 0x003D2AC9 File Offset: 0x003D0CC9
	private void LBEEHCPMFPG(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess != 0 || OPOLFIKNDME)
		{
			Debug.Log("auk_pstinf");
			return;
		}
		Debug.Log("minimalLevel" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06007FD9 RID: 32729 RVA: 0x003D2B00 File Offset: 0x003D0D00
	private void EJEKHFGJIGJ(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("LHandPunch");
	}

	// Token: 0x06007FDA RID: 32730 RVA: 0x003D2B0C File Offset: 0x003D0D0C
	public void LCALHKBCPIB()
	{
		if (SteamManager.PJMKPOFDGCK())
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log("_RcpAspect");
	}

	// Token: 0x06007FDB RID: 32731 RVA: 0x003D2B28 File Offset: 0x003D0D28
	public void updateIntStat(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.FPAKOLIPIND)
		{
			int num = 0;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			Debug.Log(string.Concat(new object[]
			{
				"stat: ",
				KFIDPBAIFLE,
				" value=",
				num
			}));
		}
	}

	// Token: 0x06007FDC RID: 32732 RVA: 0x003D2B80 File Offset: 0x003D0D80
	private void BIKELANNCEA(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("heavy");
	}

	// Token: 0x06007FDD RID: 32733 RVA: 0x003D2B8C File Offset: 0x003D0D8C
	private void BDEDEJEFFAF(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("wgt_kg", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = ":";
		if (PLDEBONCEME.m_bAuthorized == 1)
		{
			arg = "Forward";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("<color='#{0}'>{1} {3} {2} </color>\n", ulOrderID, num, arg);
		base.StartCoroutine(this.OAHIFBFLGPK(alboclbfnni));
	}

	// Token: 0x06007FDE RID: 32734 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator OILHBLHPFMD(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06007FDF RID: 32735 RVA: 0x003D2C1C File Offset: 0x003D0E1C
	private void CHJKJIJCDLF(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("m_bAuthorized={0} m_ulOrderID={1} m_unAppID={2}", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "cancel";
		if (PLDEBONCEME.m_bAuthorized == 1)
		{
			arg = "ok";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("http://af-2.ru/pay/finalize.php?orderid={0}&appid={1}&metod={2}", ulOrderID, num, arg);
		base.StartCoroutine(this.NALAPIDEGCN(alboclbfnni));
	}

	// Token: 0x06007FE0 RID: 32736 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator BECPHEPLKKJ(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06007FE1 RID: 32737 RVA: 0x003D2CA9 File Offset: 0x003D0EA9
	private void OKHBAJDDPKK(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("R Hand Punch");
	}

	// Token: 0x06007FE2 RID: 32738 RVA: 0x003D2CB8 File Offset: 0x003D0EB8
	public Texture2D DCEFKAHCGEB(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.ARGB32, false, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 1U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.ACMDFBHLNDA(texture2D);
		}
		Debug.LogError(" iterations for read and write");
		return new Texture2D(0, 0);
	}

	// Token: 0x06007FE3 RID: 32739 RVA: 0x003D2A3D File Offset: 0x003D0C3D
	private IEnumerator CHLGECCJEBH(string ALBOCLBFNNI)
	{
		www = new WWW(ALBOCLBFNNI);
		yield return www;
		if (www.isDone)
		{
			Debug.Log("final ok: " + www.text);
			if (www.text.Trim() != "OK")
			{
				Debug.Log("req.text=" + www.text);
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error!", www.text);
			}
		}
		else
		{
			Debug.LogError("Error via final request");
		}
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(105, 33);
		}
		yield break;
	}

	// Token: 0x06007FE4 RID: 32740 RVA: 0x003D2D30 File Offset: 0x003D0F30
	public void updateFloatStat(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.FPAKOLIPIND)
		{
			float num = 0f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			Debug.Log(string.Concat(new object[]
			{
				"stat: ",
				KFIDPBAIFLE,
				" value=",
				num
			}));
		}
	}

	// Token: 0x06007FE5 RID: 32741 RVA: 0x003D2D8C File Offset: 0x003D0F8C
	public string ADKEPCCGKPD()
	{
		string result = "_Offsets";
		if (SteamManager.ABJAJJMGOKF())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06007FE6 RID: 32742 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void MBKLIKGAKJB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x06007FE7 RID: 32743 RVA: 0x003D2DC0 File Offset: 0x003D0FC0
	private Texture2D GPPDPHODMFH(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007FE8 RID: 32744 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void AKGBDJDMOLC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x06007FE9 RID: 32745 RVA: 0x003D2E28 File Offset: 0x003D1028
	public void FHGFDBDCGNB(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.LGPCPFGMOGJ())
		{
			float num = 663f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[6];
			array[1] = "SceneCamera";
			array[0] = KFIDPBAIFLE;
			array[2] = "wpn id:";
			array[4] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FEA RID: 32746 RVA: 0x003D2E84 File Offset: 0x003D1084
	private void EDDALFIIGJB(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess != 1 || OPOLFIKNDME)
		{
			Debug.Log("wpn_fid1");
			return;
		}
		Debug.Log("process Action" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06007FEB RID: 32747 RVA: 0x003D2EBC File Offset: 0x003D10BC
	public void OHCBCDNACON(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.FHGDEIGKKIE())
		{
			int num = 1;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[5];
			array[1] = "360SpinDeath";
			array[0] = KFIDPBAIFLE;
			array[5] = "Interpolator has no target!";
			array[4] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FEC RID: 32748 RVA: 0x003D2F14 File Offset: 0x003D1114
	public void MKELNBLEBPN(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.NNFCGADDAHL())
		{
			float num = 1010f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[4];
			array[0] = "titul_data/p_categories/category";
			array[1] = KFIDPBAIFLE;
			array[1] = "Titul.xml";
			array[0] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06007FED RID: 32749 RVA: 0x003D2F70 File Offset: 0x003D1170
	private void KDGBMOFCFAB(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("#0080ff", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "Windmill";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "Bend Constraint is referencing to a bone '";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("[maxcnt]", ulOrderID, num, arg);
		base.StartCoroutine(this.NALAPIDEGCN(alboclbfnni));
	}

	// Token: 0x06007FEE RID: 32750 RVA: 0x003D3000 File Offset: 0x003D1200
	private void PNGOLEOOHCD()
	{
		if (SteamManager.PGAALOOPLCE())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.HLCFDMMMBGF));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.NDDAGPMGHHI));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.JILHNLIPGLJ));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.PCGHNBHGNNL));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("BowReady");
		}
	}

	// Token: 0x06007FEF RID: 32751 RVA: 0x003D3093 File Offset: 0x003D1293
	private void BBFJJKPDLPA(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess == 1 || OPOLFIKNDME)
		{
			Debug.Log("invn_rec23");
			return;
		}
		Debug.Log("wtype" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06007FF0 RID: 32752 RVA: 0x003D30CC File Offset: 0x003D12CC
	public string INPOPBAPNII()
	{
		string result = "post_16";
		if (SteamManager.GAEJKDJCOEH())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06007FF1 RID: 32753 RVA: 0x003D30ED File Offset: 0x003D12ED
	private void EJPLGCFMLDO(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess == 1 || OPOLFIKNDME)
		{
			Debug.Log("");
			return;
		}
		Debug.Log("Original health bar: " + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06007FF2 RID: 32754 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMMFJHLHEGO()
	{
	}

	// Token: 0x06007FF3 RID: 32755 RVA: 0x003D3124 File Offset: 0x003D1324
	public Texture2D JDNKJFAFGLK(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 5U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB24, false, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.GPPDPHODMFH(texture2D);
		}
		Debug.LogError("****************  playMusicBase ");
		return new Texture2D(1, 1);
	}

	// Token: 0x06007FF4 RID: 32756 RVA: 0x001B4551 File Offset: 0x001B2751
	private void KAJBCNFKHGB(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("");
	}

	// Token: 0x06007FF5 RID: 32757 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IMMHIBKKDJM()
	{
	}

	// Token: 0x06007FF6 RID: 32758 RVA: 0x003D319A File Offset: 0x003D139A
	public void PPDFGOMFOOE()
	{
		if (SteamManager.NGEACBIHBOP())
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log(" x");
	}

	// Token: 0x06007FF7 RID: 32759 RVA: 0x003D31B4 File Offset: 0x003D13B4
	private void DHCIOHIGOAB(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("");
			return;
		}
		Debug.Log("1HandSwordStrafeLeft");
	}

	// Token: 0x06007FF8 RID: 32760 RVA: 0x003D31D4 File Offset: 0x003D13D4
	private Texture2D ACMDFBHLNDA(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 1; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007FF9 RID: 32761 RVA: 0x003D323A File Offset: 0x003D143A
	private void JJDCIHCLDOM(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log(" <b>®</b></color> ");
			return;
		}
		Debug.Log("ClimbUp");
	}

	// Token: 0x06007FFA RID: 32762 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void JMJHHOFJCOD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x06007FFB RID: 32763 RVA: 0x003D3259 File Offset: 0x003D1459
	private void PCGHNBHGNNL(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess != 1 || OPOLFIKNDME)
		{
			Debug.Log("There was an error retrieving the NumberOfCurrentPlayers.");
			return;
		}
		Debug.Log("The number of players playing your game: " + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06007FFC RID: 32764 RVA: 0x003D3290 File Offset: 0x003D1490
	public void pressSteamButton()
	{
		if (SteamManager.FPAKOLIPIND)
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log("SteamManager.Initialized failed");
	}

	// Token: 0x06007FFD RID: 32765 RVA: 0x003D2A3D File Offset: 0x003D0C3D
	private IEnumerator NALAPIDEGCN(string ALBOCLBFNNI)
	{
		www = new WWW(ALBOCLBFNNI);
		yield return www;
		if (www.isDone)
		{
			Debug.Log("final ok: " + www.text);
			if (www.text.Trim() != "OK")
			{
				Debug.Log("req.text=" + www.text);
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error!", www.text);
			}
		}
		else
		{
			Debug.LogError("Error via final request");
		}
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(105, 33);
		}
		yield break;
	}

	// Token: 0x06007FFE RID: 32766 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x06007FFF RID: 32767 RVA: 0x003D32AC File Offset: 0x003D14AC
	public Texture2D GHKHCHCDDOO(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 1U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)6, true, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 1U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.ACMDFBHLNDA(texture2D);
		}
		Debug.LogError("_FogOfWarCenterAdjusted");
		return new Texture2D(0, 1);
	}

	// Token: 0x06008000 RID: 32768 RVA: 0x003D3324 File Offset: 0x003D1524
	public void HCFNGFBMPGL(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.NNFCGADDAHL())
		{
			float num = 381f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[8];
			array[1] = "invn_rec5";
			array[1] = KFIDPBAIFLE;
			array[5] = "UserIn";
			array[3] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008001 RID: 32769 RVA: 0x003D3380 File Offset: 0x003D1580
	private void GELLCJFEKEK(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("tid", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "◍◍◍";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("Roar", ulOrderID, num, arg);
		base.StartCoroutine(this.OILHBLHPFMD(alboclbfnni));
	}

	// Token: 0x06008002 RID: 32770 RVA: 0x003D3410 File Offset: 0x003D1610
	public void LNNPKAHDMNK(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.NGEACBIHBOP())
		{
			float num = 811f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[8];
			array[0] = "u_isSave";
			array[0] = KFIDPBAIFLE;
			array[2] = "2000";
			array[3] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008003 RID: 32771 RVA: 0x003D346C File Offset: 0x003D166C
	public void JCMEJOPODFE(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.NIAFGBPDDEA())
		{
			float num = 1274f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[8];
			array[1] = "https://groups.google.com/forum/#!forum/final-ik";
			array[0] = KFIDPBAIFLE;
			array[4] = "iNPC";
			array[0] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008004 RID: 32772 RVA: 0x003D34C8 File Offset: 0x003D16C8
	private void OnEnable()
	{
		if (SteamManager.FPAKOLIPIND)
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.PILHGBOPGIP));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.PGIJECNJKMA));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.CHJKJIJCDLF));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.PCGHNBHGNNL));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("Called GetNumberOfCurrentPlayers()");
		}
	}

	// Token: 0x06008005 RID: 32773 RVA: 0x003D355C File Offset: 0x003D175C
	public string KGJDNFNAOJC()
	{
		string result = "KatanaVerticalSwing";
		if (SteamManager.HFCCLHMGOKA())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008006 RID: 32774 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BFLOKDPCEBI()
	{
	}

	// Token: 0x06008007 RID: 32775 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KFHFIOKKHKG()
	{
	}

	// Token: 0x06008008 RID: 32776 RVA: 0x003D3580 File Offset: 0x003D1780
	public string AOAPEKEKONO()
	{
		string result = "u_UniqueShadowBlockerWidth";
		if (SteamManager.FHGDEIGKKIE())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008009 RID: 32777 RVA: 0x003D35A1 File Offset: 0x003D17A1
	private void PEMMHAFODLC(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("selpersbtn");
			return;
		}
		Debug.Log("\n<color='");
	}

	// Token: 0x0600800A RID: 32778 RVA: 0x003D35C0 File Offset: 0x003D17C0
	public void GHOANBNCMAF(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.ABJAJJMGOKF())
		{
			float num = 282f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[0];
			array[0] = "spawnPet id=";
			array[1] = KFIDPBAIFLE;
			array[1] = "tech";
			array[6] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x0600800B RID: 32779 RVA: 0x003D361C File Offset: 0x003D181C
	public Texture2D PGDFHJFFHEC(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 4U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB24, true, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 8U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.ACMDFBHLNDA(texture2D);
		}
		Debug.LogError("turn_state");
		return new Texture2D(0, 1);
	}

	// Token: 0x0600800C RID: 32780 RVA: 0x003D3694 File Offset: 0x003D1894
	public string MOIOJKBLFPP()
	{
		string result = "System.Boolean";
		if (SteamManager.FNNHOLIBGJH())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HFIFHKNEBCI()
	{
	}

	// Token: 0x0600800E RID: 32782 RVA: 0x003D36B8 File Offset: 0x003D18B8
	public Texture2D NNPBEMMFABC(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)0, true, true);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 5U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.NEDIPGMNODP(texture2D);
		}
		Debug.LogError("");
		return new Texture2D(0, 1);
	}

	// Token: 0x0600800F RID: 32783 RVA: 0x003D3730 File Offset: 0x003D1930
	public string NBDLDHEJAGJ()
	{
		string result = "Textures/Perks/";
		if (SteamManager.OIPNMDCOJMD())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x003D3754 File Offset: 0x003D1954
	public string NCPDCEFNOGD()
	{
		string result = "BowInstant";
		if (SteamManager.OIPNMDCOJMD())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x003D3778 File Offset: 0x003D1978
	public Texture2D PGODIGFHJCN(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 7U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.ARGB32, true, true);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 2U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.KAFFLGGGAJN(texture2D);
		}
		Debug.LogError("");
		return new Texture2D(1, 0);
	}

	// Token: 0x06008012 RID: 32786 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIHNKAJCFHC()
	{
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x003D37F0 File Offset: 0x003D19F0
	private void DJEKNFIFAEK()
	{
		if (SteamManager.FNNHOLIBGJH())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.KAJBCNFKHGB));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.PGIJECNJKMA));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.KDGBMOFCFAB));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.KIFJFHDFEIK));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("RollerBladeGrindRoyale");
		}
	}

	// Token: 0x06008014 RID: 32788 RVA: 0x003D3883 File Offset: 0x003D1A83
	public void DJKJJNMFMLM()
	{
		if (SteamManager.LGPCPFGMOGJ())
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log("Idle Die");
	}

	// Token: 0x06008015 RID: 32789 RVA: 0x003D389D File Offset: 0x003D1A9D
	private void HALIELHOHGF(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("Mouse ScrollWheel");
			return;
		}
		Debug.Log("");
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x003D38BC File Offset: 0x003D1ABC
	public Texture2D CIMFIDEFBLJ(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)8, true, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 1U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.KAFFLGGGAJN(texture2D);
		}
		Debug.LogError("Invalid IKEffector.positionOffset (contains Infinity)! Please make sure not to set IKEffector.positionOffset to infinite values.");
		return new Texture2D(1, 1);
	}

	// Token: 0x06008017 RID: 32791 RVA: 0x003D3934 File Offset: 0x003D1B34
	private void LJKBPHOCKMH(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("colorC", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "OfficeSittingReading";
		if (PLDEBONCEME.m_bAuthorized == 1)
		{
			arg = "ProneLocomotion";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}", ulOrderID, num, arg);
		base.StartCoroutine(this.HAJGODPOHNF(alboclbfnni));
	}

	// Token: 0x06008018 RID: 32792 RVA: 0x003D39C4 File Offset: 0x003D1BC4
	public void NDMIKBCCFIF(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.EPDLLLGNGFO())
		{
			int num = 1;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[3];
			array[1] = "GRAIN";
			array[1] = KFIDPBAIFLE;
			array[0] = "auc_wcswcp";
			array[7] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008019 RID: 32793 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NLIBKLIFHFF()
	{
	}

	// Token: 0x0600801A RID: 32794 RVA: 0x003D3A1C File Offset: 0x003D1C1C
	private void GNEEIHBIBNM(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("auk_wavg", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "IK.Disable() is deprecated. Use enabled = false instead";
		if (PLDEBONCEME.m_bAuthorized == 1)
		{
			arg = "<color='";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("Water", ulOrderID, num, arg);
		base.StartCoroutine(this.LOMIDFCHADP(alboclbfnni));
	}

	// Token: 0x0600801B RID: 32795 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void DIDFCBLHFNF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x0600801C RID: 32796 RVA: 0x003D3AA9 File Offset: 0x003D1CA9
	private void PLKMNADMIND(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("Fly Down");
	}

	// Token: 0x0600801D RID: 32797 RVA: 0x003D3AB5 File Offset: 0x003D1CB5
	public void OFOEJHONBEI()
	{
		if (SteamManager.KLPAEPHIOAJ())
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log("ShotgunFire");
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x003D3AD0 File Offset: 0x003D1CD0
	public Texture2D BOJCPDCKKDF(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, false, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.KAFFLGGGAJN(texture2D);
		}
		Debug.LogError("money2.wav");
		return new Texture2D(0, 1);
	}

	// Token: 0x0600801F RID: 32799 RVA: 0x003D3B46 File Offset: 0x003D1D46
	private void PGIJECNJKMA(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("Steam Overlay has been activated");
			return;
		}
		Debug.Log("Steam Overlay has been closed");
	}

	// Token: 0x06008020 RID: 32800 RVA: 0x003D3B65 File Offset: 0x003D1D65
	private void PILHGBOPGIP(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("************ Avatar is loaded");
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x003D3B74 File Offset: 0x003D1D74
	private void JFMEDOJDBLJ(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("Original lives count: ", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "#2080ff";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("MotorbikeHandstand", ulOrderID, num, arg);
		base.StartCoroutine(this.OAHIFBFLGPK(alboclbfnni));
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x003D3C01 File Offset: 0x003D1E01
	private void HLCFDMMMBGF(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("1HSwordStrafeRunRight");
	}

	// Token: 0x06008023 RID: 32803 RVA: 0x003D3C10 File Offset: 0x003D1E10
	public void HDMCLFFNOFL(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.GAEJKDJCOEH())
		{
			float num = 1311f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[3];
			array[0] = "?";
			array[1] = KFIDPBAIFLE;
			array[6] = "#a0a0a0";
			array[2] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x003D3C6C File Offset: 0x003D1E6C
	public void OFBFOFABCJM(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.CJBDAMIDAOE())
		{
			int num = 0;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[7];
			array[0] = "wpn_add/base";
			array[0] = KFIDPBAIFLE;
			array[1] = "cht_tofrendno";
			array[6] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008025 RID: 32805 RVA: 0x003D3CC4 File Offset: 0x003D1EC4
	private void DHFLFGBENBF()
	{
		if (SteamManager.HFCCLHMGOKA())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.OKHBAJDDPKK));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.KBKLAKHCBGE));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.BDEDEJEFFAF));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.EDDALFIIGJB));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("IdleBandage");
		}
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x003D3D57 File Offset: 0x003D1F57
	private void FLELJBHHNAA(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess == 1 || OPOLFIKNDME)
		{
			Debug.Log("_Color");
			return;
		}
		Debug.Log("[X]" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06008027 RID: 32807 RVA: 0x003D3D90 File Offset: 0x003D1F90
	private void ALNLNKIGFLG(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("</color>", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "demoColor";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "_ChannelMixerBlue";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("MotorbikeLassoLeft", ulOrderID, num, arg);
		base.StartCoroutine(this.JHKOPOCNJDD(alboclbfnni));
	}

	// Token: 0x06008028 RID: 32808 RVA: 0x003D2A3D File Offset: 0x003D0C3D
	private IEnumerator HAJGODPOHNF(string ALBOCLBFNNI)
	{
		www = new WWW(ALBOCLBFNNI);
		yield return www;
		if (www.isDone)
		{
			Debug.Log("final ok: " + www.text);
			if (www.text.Trim() != "OK")
			{
				Debug.Log("req.text=" + www.text);
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error!", www.text);
			}
		}
		else
		{
			Debug.LogError("Error via final request");
		}
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(105, 33);
		}
		yield break;
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void HKLPGCKJEJK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x003D3E1D File Offset: 0x003D201D
	private void EGHJDFBHKAG(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("text");
	}

	// Token: 0x0600802B RID: 32811 RVA: 0x003D3E29 File Offset: 0x003D2029
	public void FNOFOLLBNHL()
	{
		if (SteamManager.NNFCGADDAHL())
		{
			SteamUser.GetSteamID();
			return;
		}
		Debug.Log("MotorbikeHeartAttack");
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x003D3E44 File Offset: 0x003D2044
	private Texture2D HGCEIDDOIKF(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 1; i < width; i++)
		{
			for (int j = 1; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x003D3EAC File Offset: 0x003D20AC
	private Texture2D KAFFLGGGAJN(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 1; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator IAADJEPPNIJ(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x003D3F14 File Offset: 0x003D2114
	private void MBGOKFGOGKM()
	{
		if (SteamManager.LGPCPFGMOGJ())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.EGHJDFBHKAG));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.JJDCIHCLDOM));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.MPLOAGFAJAN));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.LBEEHCPMFPG));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("wpn id:");
		}
	}

	// Token: 0x06008031 RID: 32817 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator JHKOPOCNJDD(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x003D3FA8 File Offset: 0x003D21A8
	public string CNAEKMFFGKL()
	{
		string result = "isDropPrikorm";
		if (SteamManager.EPDLLLGNGFO())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x003D27F8 File Offset: 0x003D09F8
	private IEnumerator OAHIFBFLGPK(string ALBOCLBFNNI)
	{
		SteamLogic.NCDCOIFDBFJ ncdcoifdbfj = new SteamLogic.NCDCOIFDBFJ(1);
		ncdcoifdbfj.ALBOCLBFNNI = ALBOCLBFNNI;
		return ncdcoifdbfj;
	}

	// Token: 0x06008034 RID: 32820 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FNNGODOLLAI()
	{
	}

	// Token: 0x06008035 RID: 32821 RVA: 0x003D3FC9 File Offset: 0x003D21C9
	private void NDDAGPMGHHI(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("IceHockeyIdle");
			return;
		}
		Debug.Log("Try to change this Vector3 in memory:\n");
	}

	// Token: 0x06008036 RID: 32822 RVA: 0x003D3FE8 File Offset: 0x003D21E8
	private void OOCBMODHOKK(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess != 1 || OPOLFIKNDME)
		{
			Debug.Log("");
			return;
		}
		Debug.Log("_CameraClipInfo" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06008037 RID: 32823 RVA: 0x003D4020 File Offset: 0x003D2220
	private void ACCKEFCOBGN()
	{
		if (SteamManager.PJMKPOFDGCK())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.PLKMNADMIND));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.PGIJECNJKMA));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.GNEEIHBIBNM));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.JONFDNOCNPI));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("change me!");
		}
	}

	// Token: 0x06008038 RID: 32824 RVA: 0x003D40B4 File Offset: 0x003D22B4
	public void NIOGLBPAPEB(string KFIDPBAIFLE, float HPHALKGJGNC)
	{
		if (SteamManager.CJBDAMIDAOE())
		{
			float num = 602f;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[5];
			array[1] = "_Exposure";
			array[1] = KFIDPBAIFLE;
			array[5] = "getfish";
			array[8] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x06008039 RID: 32825 RVA: 0x003D4110 File Offset: 0x003D2310
	private void KIFJFHDFEIK(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess != 0 || OPOLFIKNDME)
		{
			Debug.Log("Windows");
			return;
		}
		Debug.Log("msgCancel" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x0600803A RID: 32826 RVA: 0x003D4147 File Offset: 0x003D2347
	private void GMPLPMODJBF(AvatarImageLoaded_t GPHDKILIBAE)
	{
		Debug.Log("knopje.wav");
	}

	// Token: 0x0600803B RID: 32827 RVA: 0x003D2DAD File Offset: 0x003D0FAD
	private void CCPOIOJPKIF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		SteamLogic.getI = this;
	}

	// Token: 0x0600803C RID: 32828 RVA: 0x003D4154 File Offset: 0x003D2354
	public string getClientLang()
	{
		string result = "En";
		if (SteamManager.FPAKOLIPIND)
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x0600803D RID: 32829 RVA: 0x003D4178 File Offset: 0x003D2378
	private void MPLOAGFAJAN(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "Tenkoku DynamicSky";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "Assets/Hairs/hair_";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("R", ulOrderID, num, arg);
		base.StartCoroutine(this.OILHBLHPFMD(alboclbfnni));
	}

	// Token: 0x0600803E RID: 32830 RVA: 0x003D4208 File Offset: 0x003D2408
	public void PBLBLGIKKME(string KFIDPBAIFLE, int HPHALKGJGNC)
	{
		if (SteamManager.LCIFODJFFBL())
		{
			int num = 1;
			SteamUserStats.GetStat(KFIDPBAIFLE, out num);
			num += HPHALKGJGNC;
			SteamUserStats.SetStat(KFIDPBAIFLE, num);
			object[] array = new object[3];
			array[0] = "Here you can overview common ACTk features and try to cheat something yourself.";
			array[1] = KFIDPBAIFLE;
			array[0] = "/Localization/langsettings.xml";
			array[5] = num;
			Debug.Log(string.Concat(array));
		}
	}

	// Token: 0x0600803F RID: 32831 RVA: 0x003D4260 File Offset: 0x003D2460
	private void AHPHMMJMKOG()
	{
		if (SteamManager.PJMKPOFDGCK())
		{
			this.BMPGKIJEBON = Callback<AvatarImageLoaded_t>.Create(new Callback<AvatarImageLoaded_t>.DispatchDelegate(this.PLKMNADMIND));
			this.MIHFBELLIGM = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.PGIJECNJKMA));
			this.JMIIIHFHAKF = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.IDAPINDLNOI));
			this.FABHKOFJJDD = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.KIFJFHDFEIK));
			SteamUserStats.RequestCurrentStats();
			SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
			this.FABHKOFJJDD.Set(numberOfCurrentPlayers, null);
			Debug.Log("_EMISSION");
		}
	}

	// Token: 0x06008040 RID: 32832 RVA: 0x003D42F3 File Offset: 0x003D24F3
	private void KBKLAKHCBGE(GameOverlayActivated_t PLDEBONCEME)
	{
		if (PLDEBONCEME.m_bActive != 0)
		{
			Debug.Log("Loot");
			return;
		}
		Debug.Log("Missing shader in ");
	}

	// Token: 0x06008041 RID: 32833 RVA: 0x003D4314 File Offset: 0x003D2514
	private void IDAPINDLNOI(MicroTxnAuthorizationResponse_t PLDEBONCEME)
	{
		string.Format("OfficeSittingReading", PLDEBONCEME.m_bAuthorized, PLDEBONCEME.m_ulOrderID, PLDEBONCEME.m_unAppID);
		string arg = "_Transparency";
		if (PLDEBONCEME.m_bAuthorized == 0)
		{
			arg = "hip";
		}
		ulong ulOrderID = PLDEBONCEME.m_ulOrderID;
		ulong num = (ulong)PLDEBONCEME.m_unAppID;
		string alboclbfnni = string.Format("Idle Eat", ulOrderID, num, arg);
		base.StartCoroutine(this.IAADJEPPNIJ(alboclbfnni));
	}

	// Token: 0x06008042 RID: 32834 RVA: 0x003D43A4 File Offset: 0x003D25A4
	public Texture2D FMIFMNONEAM(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 1U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)0, true, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 7U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.HGCEIDDOIKF(texture2D);
		}
		Debug.LogError("*************157 baseid=");
		return new Texture2D(1, 0);
	}

	// Token: 0x06008043 RID: 32835 RVA: 0x003D441C File Offset: 0x003D261C
	public string NKPGHOBFGMH()
	{
		string result = "[maxweight]";
		if (SteamManager.LGPCPFGMOGJ())
		{
			result = SteamUtils.GetSteamUILanguage();
		}
		return result;
	}

	// Token: 0x06008044 RID: 32836 RVA: 0x003D443D File Offset: 0x003D263D
	private void JONFDNOCNPI(NumberOfCurrentPlayers_t PLDEBONCEME, bool OPOLFIKNDME)
	{
		if (PLDEBONCEME.m_bSuccess == 0 || OPOLFIKNDME)
		{
			Debug.Log("Bone ");
			return;
		}
		Debug.Log("  locid=" + PLDEBONCEME.m_cPlayers);
	}

	// Token: 0x06008045 RID: 32837 RVA: 0x003D4474 File Offset: 0x003D2674
	public Texture2D GetSmallAvatar(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 4U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, true);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.GPPDPHODMFH(texture2D);
		}
		Debug.LogError("Couldn't get avatar.");
		return new Texture2D(0, 0);
	}

	// Token: 0x06008046 RID: 32838 RVA: 0x003D44EC File Offset: 0x003D26EC
	public Texture2D KAPGNDHNAFM(CSteamID AGHCJPAJDAD)
	{
		int smallFriendAvatar = SteamFriends.GetSmallFriendAvatar(AGHCJPAJDAD);
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(smallFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 8U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.ARGB4444, false, false);
			if (SteamUtils.GetImageRGBA(smallFriendAvatar, array, (int)(num * num2 * 7U)))
			{
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
			return this.KAFFLGGGAJN(texture2D);
		}
		Debug.LogError("Giant");
		return new Texture2D(1, 1);
	}

	// Token: 0x0400126A RID: 4714
	public static SteamLogic getI;

	// Token: 0x0400126B RID: 4715
	protected Callback<GameOverlayActivated_t> MIHFBELLIGM;

	// Token: 0x0400126C RID: 4716
	protected Callback<MicroTxnAuthorizationResponse_t> JMIIIHFHAKF;

	// Token: 0x0400126D RID: 4717
	private CallResult<NumberOfCurrentPlayers_t> FABHKOFJJDD;

	// Token: 0x0400126E RID: 4718
	protected Callback<AvatarImageLoaded_t> BMPGKIJEBON;
}
