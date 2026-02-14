using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001D3 RID: 467
public class MainMenuScript : MonoBehaviour
{
	// Token: 0x06006ACA RID: 27338 RVA: 0x0032A730 File Offset: 0x00328930
	public void AJJLOFLLMIG()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.getSteamID();
		this.isSteamLogin = true;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("Full Body IK is missing the left upper arm node.", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("Roller Blade Skate Fwd", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("HeelClick", "money");
			PlayerPrefs.SetString("BlackSmithForge", "Low adminlevel!");
		}
		PlayerPrefs.SetInt("Vertical", this.PGCLFBHKIIC ? 1 : 1);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		if (NJMHLCGIAJI.IKGFHGKKCPG.COHHJMOFPFF())
		{
			this.NMOJJJOBMII();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006ACB RID: 27339 RVA: 0x0032A814 File Offset: 0x00328A14
	public void KJIDMMHGBMM()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.DDOELNAEODN();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("RollerBladeTurnRight", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("Actor", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("WATER_REFLECTIVE", "");
			PlayerPrefs.SetString("_WaveScale", "7,13,9,8");
		}
		PlayerPrefs.SetInt("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.", this.PGCLFBHKIIC ? 1 : 0);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		if (NJMHLCGIAJI.EAJGHMMBAFP().COHHJMOFPFF())
		{
			this.MECDBPBCENB();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006ACC RID: 27340 RVA: 0x0032A8F8 File Offset: 0x00328AF8
	public void NAEKCFAEDLI()
	{
		Application.OpenURL("NEW FISH!");
	}

	// Token: 0x06006ACD RID: 27341 RVA: 0x0032A904 File Offset: 0x00328B04
	public void NBEHKCKBBMO()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.OHFFEFEENCO();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("WalkBackward", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("INTERFACE", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("id", "_RangeScale");
			PlayerPrefs.SetString("Backward Stand", "StrafeRunRight");
		}
		PlayerPrefs.SetInt("\n", this.PGCLFBHKIIC ? 0 : 0);
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		if (NJMHLCGIAJI.IKGFHGKKCPG.OEMIHLIHKJE())
		{
			this.DENAPDDBIGO();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006ACE RID: 27342 RVA: 0x0032A9E8 File Offset: 0x00328BE8
	private void ANHOOJFEJJE()
	{
		this.passLoginPanel.SetActive(this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.CFJGMNPFLAA();
		this.Version.text = IFPIMPMKJIB.IBCFJGOPJCA;
		GuiProcessor.NKOEAPCIBKO().BJBJKLMJLCA = this.mainCanvas;
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(1, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("404040");
		this.BNANOHGLDGL = PlayerPrefs.GetString("error.wav");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt(" Bones.") == 0);
		this.pin = ObscuredInt.JNKANIEBCMD(PlayerPrefs.GetInt("?"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.EAJGHMMBAFP().NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.KGDBLPLMMFA);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.HLNAMHJMLNI);
		long num = (long)PlayerPrefs.GetInt("offsets");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.OBNCHJKOMCJ();
	}

	// Token: 0x06006ACF RID: 27343 RVA: 0x0032AB30 File Offset: 0x00328D30
	public void OOGNIBCHNAB()
	{
		JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		epmphjgalbe.AAHBHCMKGJD(185L);
		epmphjgalbe.HGCCFFKDELO(this.DIGJFGOGPLC);
		epmphjgalbe.BNPGKHHADEH(this.BNANOHGLDGL);
		epmphjgalbe.JJAOGFKMLIE(ObscuredString.GOOIABGKMHK(this.steamID));
		epmphjgalbe.JJAOGFKMLIE(ObscuredString.CKPPDHPJHEH(this.deviceID));
		epmphjgalbe.FINMMGHAHFI(this.PKDKBFCCLBF);
		epmphjgalbe.IECHKLACNFM(this.isSteamLogin);
		epmphjgalbe.EAOGDKDBENC(ObscuredInt.DGOCFCFPKPI(this.pin));
		NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-76, epmphjgalbe.IEJLLFECFHF());
		epmphjgalbe.LMBPNFHKNGA();
	}

	// Token: 0x06006AD0 RID: 27344 RVA: 0x0032ABD5 File Offset: 0x00328DD5
	public void AFODFEIGHGM()
	{
		Application.OpenURL("Jump");
	}

	// Token: 0x06006AD1 RID: 27345 RVA: 0x0032ABE4 File Offset: 0x00328DE4
	private void Awake()
	{
		this.connectPanel.gameObject.SetActive(false);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(false);
		this.isSteamEnabled = false;
		this.isSteamLogin = false;
		if (SteamManager.FPAKOLIPIND)
		{
			this.isSteamEnabled = true;
			this.isSteamLogin = true;
			this.noSteamLabel.gameObject.SetActive(false);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(true);
	}

	// Token: 0x06006AD2 RID: 27346 RVA: 0x0032AC60 File Offset: 0x00328E60
	private void KOJNOPBGPAM()
	{
		this.connectPanel.gameObject.SetActive(true);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(true);
		this.isSteamEnabled = false;
		this.isSteamLogin = true;
		if (SteamManager.GAEJKDJCOEH())
		{
			this.isSteamEnabled = true;
			this.isSteamLogin = true;
			this.noSteamLabel.gameObject.SetActive(false);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(false);
	}

	// Token: 0x06006AD3 RID: 27347 RVA: 0x0032ACDC File Offset: 0x00328EDC
	private void Start()
	{
		this.passLoginPanel.SetActive(!this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.KMDHOHJFJJP();
		this.Version.text = IFPIMPMKJIB.IBCFJGOPJCA;
		GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(0, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("u_email");
		this.BNANOHGLDGL = PlayerPrefs.GetString("u_pass");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("u_isSave") == 1);
		this.pin = ObscuredInt.GOOIABGKMHK(PlayerPrefs.GetInt("u_pin"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.IKGFHGKKCPG.NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.onConnect);
		NJMHLCGIAJI.IKGFHGKKCPG.CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.onDisconnect);
		long num = (long)PlayerPrefs.GetInt("lastConfirmLic");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.getSteamID();
	}

	// Token: 0x06006AD4 RID: 27348 RVA: 0x0032AE24 File Offset: 0x00329024
	public void DDOELNAEODN()
	{
		if (SteamManager.PJMKPOFDGCK())
		{
			CSteamID steamIDFriend = SteamUser.GetSteamID();
			this.steamID = ObscuredString.LMCJCHPGIJK(steamIDFriend.ToString());
			this.PKDKBFCCLBF = SteamFriends.GetPersonaName();
			JBEHMPDDMME.EAJHPOJPPFA().IDAGBNBFHAB = this.steamID;
			JBEHMPDDMME.JKIFIBEPICO().PCDDHDEIEDB = SteamUtils.GetSteamUILanguage();
			SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		}
		else
		{
			this.steamID = ObscuredString.LMCJCHPGIJK("");
			this.PKDKBFCCLBF = "wpn_add/base";
		}
		this.deviceID = ObscuredString.AOOBGNKCJLF(SystemInfo.deviceUniqueIdentifier);
	}

	// Token: 0x06006AD5 RID: 27349 RVA: 0x0032AEB4 File Offset: 0x003290B4
	public void HEMGMBCFMNF()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.isSteamLogin = false;
		this.OBNCHJKOMCJ();
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			this.DENAPDDBIGO();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006AD6 RID: 27350 RVA: 0x0032AEF4 File Offset: 0x003290F4
	private void FAKMOCKLLHF()
	{
		this.connectPanel.gameObject.SetActive(true);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(false);
		this.isSteamEnabled = false;
		this.isSteamLogin = true;
		if (SteamManager.OIPNMDCOJMD())
		{
			this.isSteamEnabled = true;
			this.isSteamLogin = false;
			this.noSteamLabel.gameObject.SetActive(true);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(false);
	}

	// Token: 0x06006AD7 RID: 27351 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06006AD8 RID: 27352 RVA: 0x0032AF6F File Offset: 0x0032916F
	public void KNMLECOLNNN(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt("**************** RatingBoard readFromServer", this.PGCLFBHKIIC ? 1 : 0);
	}

	// Token: 0x06006AD9 RID: 27353 RVA: 0x0032AF90 File Offset: 0x00329190
	public void KJGCOIIJJBC()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.DDOELNAEODN();
		this.isSteamLogin = true;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("_FogHeight", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("Mouse Y", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("Packet processor error cmd: ", "1HandSwordStrafeLeft");
			PlayerPrefs.SetString("", "_BilateralUpsampling");
		}
		PlayerPrefs.SetInt("maps.txt", this.PGCLFBHKIIC ? 1 : 1);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		if (NJMHLCGIAJI.IKGFHGKKCPG.COHHJMOFPFF())
		{
			this.NMOJJJOBMII();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006ADA RID: 27354 RVA: 0x0032B074 File Offset: 0x00329274
	public void openGreenLight()
	{
		Application.OpenURL("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774");
	}

	// Token: 0x06006ADB RID: 27355 RVA: 0x0032B080 File Offset: 0x00329280
	public void PNNGOPEOAMD()
	{
		Application.OpenURL("WeaponFire");
	}

	// Token: 0x06006ADC RID: 27356 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x06006ADE RID: 27358 RVA: 0x0032B08C File Offset: 0x0032928C
	public void GODFHHLENDM()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.isSteamLogin = true;
		this.OBNCHJKOMCJ();
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			this.NMOJJJOBMII();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006ADF RID: 27359 RVA: 0x0032B0C9 File Offset: 0x003292C9
	public void HEANEIAMMCF()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.isSteamLogin = true;
		this.OHFFEFEENCO();
		if (NJMHLCGIAJI.IKGFHGKKCPG.OEMIHLIHKJE())
		{
			this.MECDBPBCENB();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006AE0 RID: 27360 RVA: 0x0032B106 File Offset: 0x00329306
	public void EKNKEBOEJEB()
	{
		Application.OpenURL("DealerShuffle");
	}

	// Token: 0x06006AE1 RID: 27361 RVA: 0x0032B112 File Offset: 0x00329312
	public void NGHKJFPDKLN()
	{
		if (SteamManager.JBKCBLGNLLG())
		{
			JDCEFOFMGHB.HMJJPNDEKPP().POIPOBBIDPM("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", "lineDistance=" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement("wpn_chair3");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006AE2 RID: 27362 RVA: 0x0032B150 File Offset: 0x00329350
	public void OHFFEFEENCO()
	{
		if (SteamManager.FHGDEIGKKIE())
		{
			CSteamID steamIDFriend = SteamUser.GetSteamID();
			this.steamID = ObscuredString.GOOIABGKMHK(steamIDFriend.ToString());
			this.PKDKBFCCLBF = SteamFriends.GetPersonaName();
			JBEHMPDDMME.EAJHPOJPPFA().IDAGBNBFHAB = this.steamID;
			JBEHMPDDMME.IKGFHGKKCPG.PCDDHDEIEDB = SteamUtils.GetSteamUILanguage();
			SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		}
		else
		{
			this.steamID = ObscuredString.EMFOKHGIMFM("IdleCheer");
			this.PKDKBFCCLBF = "_History1ChromaTex";
		}
		this.deviceID = ObscuredString.GOOIABGKMHK(SystemInfo.deviceUniqueIdentifier);
	}

	// Token: 0x06006AE3 RID: 27363 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MIFLHGMPLJD()
	{
	}

	// Token: 0x06006AE4 RID: 27364 RVA: 0x0032B1E0 File Offset: 0x003293E0
	public void ICDFGBEDLJO()
	{
		Application.OpenURL("SoccerSprint");
	}

	// Token: 0x06006AE5 RID: 27365 RVA: 0x0032B1EC File Offset: 0x003293EC
	private void IAAOGAPJDID()
	{
		this.passLoginPanel.SetActive(!this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.KMDHOHJFJJP();
		this.Version.text = IFPIMPMKJIB.EBLHPPEFBHB();
		GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(0, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("Materials/DFGDesktop");
		this.BNANOHGLDGL = PlayerPrefs.GetString("_FogColor");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("min_lev") == 0);
		this.pin = ObscuredInt.IGDNGFGPOFC(PlayerPrefs.GetInt("#FF4040"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.EAJGHMMBAFP().NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.DFOKLGKLPIF);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.HLNAMHJMLNI);
		long num = (long)PlayerPrefs.GetInt("ArmFlex4");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.ENFIDOBAHFE();
	}

	// Token: 0x06006AE6 RID: 27366 RVA: 0x0032B332 File Offset: 0x00329532
	public void confirmLic()
	{
		PlayerPrefs.SetInt("lastConfirmLic", 173);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
	}

	// Token: 0x06006AE7 RID: 27367 RVA: 0x0032B358 File Offset: 0x00329558
	public void EMKAKPJNHGO()
	{
		this.connectPanel.gameObject.SetActive(true);
		try
		{
			this.pin = ObscuredInt.KHJPCCFDJPA(int.Parse(this.pinInput.text));
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		if (this.pinSave.isOn)
		{
			PlayerPrefs.SetInt("Twist", ObscuredInt.GOOIABGKMHK(this.pin));
		}
		this.DENAPDDBIGO();
		this.pinPanel.gameObject.SetActive(false);
	}

	// Token: 0x06006AE8 RID: 27368 RVA: 0x0032B3E4 File Offset: 0x003295E4
	public void HLNAMHJMLNI()
	{
		this.connectPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006AE9 RID: 27369 RVA: 0x0032B410 File Offset: 0x00329610
	private void CKGPEFOKKNL()
	{
		this.passLoginPanel.SetActive(this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.ECFFFJLCEPE();
		this.Version.text = IFPIMPMKJIB.KGGGLEMFPLP();
		GuiProcessor.IKGFHGKKCPG.EOPEPOJNLNF(this.mainCanvas);
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(0, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("Error");
		this.BNANOHGLDGL = PlayerPrefs.GetString("wpn_hook3");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("_FresnelFade") == 0);
		this.pin = ObscuredInt.KHJPCCFDJPA(PlayerPrefs.GetInt("RollerBladeStop"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.IKGFHGKKCPG.NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.AKPFHDLEGBA);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.HLNAMHJMLNI);
		long num = (long)PlayerPrefs.GetInt("SoccerKeeperJump");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.OHFFEFEENCO();
	}

	// Token: 0x06006AEA RID: 27370 RVA: 0x0032B556 File Offset: 0x00329756
	public void connectSteamBtn()
	{
		this.passLoginPanel.SetActive(true);
		this.steamLoginPanel.SetActive(false);
	}

	// Token: 0x06006AEB RID: 27371 RVA: 0x0032B570 File Offset: 0x00329770
	public void BJOEGIDFAAJ()
	{
		Application.OpenURL("OneHandSwordSwing");
	}

	// Token: 0x06006AEC RID: 27372 RVA: 0x0032B57C File Offset: 0x0032977C
	public void DHJEIHDAKPI()
	{
		this.connectPanel.gameObject.SetActive(false);
		try
		{
			this.pin = ObscuredInt.JNKANIEBCMD(int.Parse(this.pinInput.text));
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		if (this.pinSave.isOn)
		{
			PlayerPrefs.SetInt("\n", ObscuredInt.LBDMFALMOLD(this.pin));
		}
		this.loginAction();
		this.pinPanel.gameObject.SetActive(true);
	}

	// Token: 0x06006AED RID: 27373 RVA: 0x0032B608 File Offset: 0x00329808
	public void NIGDBOHBHKH()
	{
		PlayerPrefs.SetInt("}", -116);
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Horizontal", 1064f);
	}

	// Token: 0x06006AEE RID: 27374 RVA: 0x0032B62D File Offset: 0x0032982D
	public void IHHJKFFGKDH()
	{
		PlayerPrefs.SetInt("StartPhysPoint", 54);
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("gi_um_8", 1883f);
	}

	// Token: 0x06006AEF RID: 27375 RVA: 0x0032B652 File Offset: 0x00329852
	public void MEHJPIIEBPC()
	{
		if (SteamManager.CJBDAMIDAOE())
		{
			JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD("' that does not excist in the Node Chain.", "KatanaUpperBlock" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement(",");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006AF0 RID: 27376 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFPGMNGFLNH()
	{
	}

	// Token: 0x06006AF1 RID: 27377 RVA: 0x0032B690 File Offset: 0x00329890
	public void NMOJJJOBMII()
	{
		JBEHMPDDMME.EAJHPOJPPFA().BJPJPFDOKDL = false;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		epmphjgalbe.OACBICLGENB(72L);
		epmphjgalbe.HGCCFFKDELO(this.DIGJFGOGPLC);
		epmphjgalbe.BNPGKHHADEH(this.BNANOHGLDGL);
		epmphjgalbe.HBJIMCCCNJP(ObscuredString.CKPPDHPJHEH(this.steamID));
		epmphjgalbe.LKNDBBGMIOE(ObscuredString.CKPPDHPJHEH(this.deviceID));
		epmphjgalbe.LCFJAKKMCFN(this.PKDKBFCCLBF);
		epmphjgalbe.APLCAMNONBD(this.isSteamLogin);
		epmphjgalbe.ALNEALEKFNB(ObscuredInt.GOOIABGKMHK(this.pin));
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(90, epmphjgalbe.JOCJNOBBELJ());
		epmphjgalbe.HDKBMLOJLLC();
	}

	// Token: 0x06006AF2 RID: 27378 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMLNBHIIGKH()
	{
	}

	// Token: 0x06006AF3 RID: 27379 RVA: 0x0032B735 File Offset: 0x00329935
	public void steamLogin()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.isSteamLogin = true;
		this.getSteamID();
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			this.loginAction();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006AF4 RID: 27380 RVA: 0x0032B774 File Offset: 0x00329974
	private void OAKCEHBONIP()
	{
		this.connectPanel.gameObject.SetActive(false);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(false);
		this.isSteamEnabled = false;
		this.isSteamLogin = false;
		if (SteamManager.EPDLLLGNGFO())
		{
			this.isSteamEnabled = true;
			this.isSteamLogin = false;
			this.noSteamLabel.gameObject.SetActive(true);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(false);
	}

	// Token: 0x06006AF5 RID: 27381 RVA: 0x0032B7EF File Offset: 0x003299EF
	public void BLDAIFIEDNL()
	{
		Application.OpenURL("0");
	}

	// Token: 0x06006AF6 RID: 27382 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBOONMDONCF()
	{
	}

	// Token: 0x06006AF7 RID: 27383 RVA: 0x0032B7FB File Offset: 0x003299FB
	public void MGIDCFAHDMA()
	{
		this.OHFFEFEENCO();
		this.OOGNIBCHNAB();
	}

	// Token: 0x06006AF8 RID: 27384 RVA: 0x0032B80C File Offset: 0x00329A0C
	private void FIJKDFIMELM()
	{
		this.passLoginPanel.SetActive(!this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.FLAJMNKOKKF();
		this.Version.text = IFPIMPMKJIB.IFHGBMEOEGI();
		GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.mainCanvas);
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(0, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("\n");
		this.BNANOHGLDGL = PlayerPrefs.GetString("_Offsets");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("") == 1);
		this.pin = ObscuredInt.IGDNGFGPOFC(PlayerPrefs.GetInt(" "));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.IKGFHGKKCPG.NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.AKPFHDLEGBA);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.HFPADMKPDNP);
		long num = (long)PlayerPrefs.GetInt("_w");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.DDOELNAEODN();
	}

	// Token: 0x06006AF9 RID: 27385 RVA: 0x0032B952 File Offset: 0x00329B52
	public void isSaveOpt(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt("u_isSave", this.PGCLFBHKIIC ? 1 : 0);
	}

	// Token: 0x06006AFA RID: 27386 RVA: 0x0032B971 File Offset: 0x00329B71
	public void KGDBLPLMMFA()
	{
		this.getSteamID();
		this.NMOJJJOBMII();
	}

	// Token: 0x06006AFB RID: 27387 RVA: 0x0032B97F File Offset: 0x00329B7F
	public void CCDDDPFDPNJ(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt("Special Flip", this.PGCLFBHKIIC ? 1 : 1);
	}

	// Token: 0x06006AFC RID: 27388 RVA: 0x0032B99E File Offset: 0x00329B9E
	public void HPBINOEKIIK()
	{
		PlayerPrefs.SetInt("_LerpRgbTex", 120);
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("post_msg7", 1415f);
	}

	// Token: 0x06006AFD RID: 27389 RVA: 0x0032B9C3 File Offset: 0x00329BC3
	public void POHJFOKACNL()
	{
		this.connectPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006AFE RID: 27390 RVA: 0x0032B9ED File Offset: 0x00329BED
	public void JMNLMGGOCDL()
	{
		this.OBNCHJKOMCJ();
		this.loginAction();
	}

	// Token: 0x06006AFF RID: 27391 RVA: 0x0032B9FB File Offset: 0x00329BFB
	public void AKPFHDLEGBA()
	{
		this.OHFFEFEENCO();
		this.NMOJJJOBMII();
	}

	// Token: 0x06006B00 RID: 27392 RVA: 0x0032BA09 File Offset: 0x00329C09
	public void OKBGEMADBEL()
	{
		if (SteamManager.NNFCGADDAHL())
		{
			JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD("RollerBladeJump", "Overlay Mesh: " + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement("DeadmanFloat");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006B01 RID: 27393 RVA: 0x0032BA48 File Offset: 0x00329C48
	public void LCOBOGBAELF()
	{
		this.connectPanel.gameObject.SetActive(true);
		try
		{
			this.pin = ObscuredInt.IGDNGFGPOFC(int.Parse(this.pinInput.text));
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		if (this.pinSave.isOn)
		{
			PlayerPrefs.SetInt("ShotgunReadyFire", ObscuredInt.LBDMFALMOLD(this.pin));
		}
		this.OOGNIBCHNAB();
		this.pinPanel.gameObject.SetActive(false);
	}

	// Token: 0x06006B02 RID: 27394 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FJEEADNCKAG()
	{
	}

	// Token: 0x06006B03 RID: 27395 RVA: 0x0032BAD4 File Offset: 0x00329CD4
	public void GECIPEAEACH(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt(" iterations for read and write", this.PGCLFBHKIIC ? 0 : 0);
	}

	// Token: 0x06006B04 RID: 27396 RVA: 0x0032BAF4 File Offset: 0x00329CF4
	public void BFINHFJGMEL()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.ENFIDOBAHFE();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("Index", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("IdleMouthWipe", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("Roll", "ZombieCrawl");
			PlayerPrefs.SetString("ProneLocomotion", "WorkerHammer2");
		}
		PlayerPrefs.SetInt("_VelocityScale", this.PGCLFBHKIIC ? 0 : 1);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (NJMHLCGIAJI.IKGFHGKKCPG.OEMIHLIHKJE())
		{
			this.OOGNIBCHNAB();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006B05 RID: 27397 RVA: 0x0032BBD8 File Offset: 0x00329DD8
	private void BJHGPFGBFKF()
	{
		this.passLoginPanel.SetActive(this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.FHIEJJNBBIJ();
		this.Version.text = IFPIMPMKJIB.MCENLBEPLBF();
		GuiProcessor.BBLINJLBAIL().CPDHMBFPGMD(this.mainCanvas);
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(1, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("FogAreaCullingManager missing script.");
		this.BNANOHGLDGL = PlayerPrefs.GetString("GestureHandUp");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("Level loading error Level ID=") == 0);
		this.pin = ObscuredInt.JNKANIEBCMD(PlayerPrefs.GetInt("IdleStandingJump"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.EAJGHMMBAFP().NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.MGIDCFAHDMA);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.onDisconnect);
		long num = (long)PlayerPrefs.GetInt("");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.OHFFEFEENCO();
	}

	// Token: 0x06006B06 RID: 27398 RVA: 0x0032BD1E File Offset: 0x00329F1E
	public void FDMALMKEMDG()
	{
		this.getSteamID();
		this.MECDBPBCENB();
	}

	// Token: 0x06006B07 RID: 27399 RVA: 0x0032BD2C File Offset: 0x00329F2C
	public void PCFCIABGNAP(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt("80ff00", this.PGCLFBHKIIC ? 0 : 1);
	}

	// Token: 0x06006B08 RID: 27400 RVA: 0x0032BD4C File Offset: 0x00329F4C
	public void OBNCHJKOMCJ()
	{
		if (SteamManager.FNNHOLIBGJH())
		{
			CSteamID steamIDFriend = SteamUser.GetSteamID();
			this.steamID = ObscuredString.DGOCFCFPKPI(steamIDFriend.ToString());
			this.PKDKBFCCLBF = SteamFriends.GetPersonaName();
			JBEHMPDDMME.JKIFIBEPICO().IDAGBNBFHAB = this.steamID;
			JBEHMPDDMME.IKGFHGKKCPG.PCDDHDEIEDB = SteamUtils.GetSteamUILanguage();
			SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		}
		else
		{
			this.steamID = ObscuredString.DGOCFCFPKPI(" гр ");
			this.PKDKBFCCLBF = "_LerpRgbTex";
		}
		this.deviceID = ObscuredString.EMFOKHGIMFM(SystemInfo.deviceUniqueIdentifier);
	}

	// Token: 0x06006B09 RID: 27401 RVA: 0x0032BDDC File Offset: 0x00329FDC
	public void onConnect()
	{
		this.getSteamID();
		this.loginAction();
	}

	// Token: 0x06006B0A RID: 27402 RVA: 0x0032BDEC File Offset: 0x00329FEC
	public void loginAction()
	{
		JBEHMPDDMME.IKGFHGKKCPG.BJPJPFDOKDL = false;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		epmphjgalbe.OBCCLNMPGEJ(1731L);
		epmphjgalbe.NEHCMOODKIN(this.DIGJFGOGPLC);
		epmphjgalbe.NEHCMOODKIN(this.BNANOHGLDGL);
		epmphjgalbe.NEHCMOODKIN(ObscuredString.GOOIABGKMHK(this.steamID));
		epmphjgalbe.NEHCMOODKIN(ObscuredString.GOOIABGKMHK(this.deviceID));
		epmphjgalbe.NEHCMOODKIN(this.PKDKBFCCLBF);
		epmphjgalbe.KJDIGAKNOAI(this.isSteamLogin);
		epmphjgalbe.GOMLLPFFPNP(ObscuredInt.GOOIABGKMHK(this.pin));
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(90, epmphjgalbe.JDPHBLHOLAD());
		epmphjgalbe.LMBPNFHKNGA();
	}

	// Token: 0x06006B0B RID: 27403 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IEOICHPKEMD()
	{
	}

	// Token: 0x06006B0C RID: 27404 RVA: 0x0032BE91 File Offset: 0x0032A091
	public void EAOBPAFNGDC()
	{
		Application.OpenURL("SelfBleedReduction");
	}

	// Token: 0x06006B0D RID: 27405 RVA: 0x0032BEA0 File Offset: 0x0032A0A0
	public void getSteamID()
	{
		if (SteamManager.FPAKOLIPIND)
		{
			CSteamID steamIDFriend = SteamUser.GetSteamID();
			this.steamID = ObscuredString.GOOIABGKMHK(steamIDFriend.ToString());
			this.PKDKBFCCLBF = SteamFriends.GetPersonaName();
			JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB = this.steamID;
			JBEHMPDDMME.IKGFHGKKCPG.PCDDHDEIEDB = SteamUtils.GetSteamUILanguage();
			SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		}
		else
		{
			this.steamID = ObscuredString.GOOIABGKMHK("");
			this.PKDKBFCCLBF = "";
		}
		this.deviceID = ObscuredString.GOOIABGKMHK(SystemInfo.deviceUniqueIdentifier);
	}

	// Token: 0x06006B0E RID: 27406 RVA: 0x0032BF30 File Offset: 0x0032A130
	public void MAFLBDDEBEO()
	{
		this.OBNCHJKOMCJ();
		this.OOGNIBCHNAB();
	}

	// Token: 0x06006B0F RID: 27407 RVA: 0x0032BF3E File Offset: 0x0032A13E
	public void FEPGBDPHPKN()
	{
		Application.OpenURL("");
	}

	// Token: 0x06006B10 RID: 27408 RVA: 0x0032BF4A File Offset: 0x0032A14A
	public void MICGHOAAJPN()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.isSteamLogin = true;
		this.DDOELNAEODN();
		if (NJMHLCGIAJI.EAJGHMMBAFP().EKBIOPEDBJI)
		{
			this.loginAction();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006B11 RID: 27409 RVA: 0x0032BF87 File Offset: 0x0032A187
	public void HDFOGAGCPML()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.isSteamLogin = true;
		this.DDOELNAEODN();
		if (NJMHLCGIAJI.IKGFHGKKCPG.OEMIHLIHKJE())
		{
			this.loginAction();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006B12 RID: 27410 RVA: 0x0032BFC4 File Offset: 0x0032A1C4
	public void clickSetbtn()
	{
		if (SteamManager.FPAKOLIPIND)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("info", "AppID:" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement("ACHIEVEMENT_1_1");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006B13 RID: 27411 RVA: 0x0032C001 File Offset: 0x0032A201
	public void IPHELODPABM()
	{
		this.connectPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006B14 RID: 27412 RVA: 0x0032C02C File Offset: 0x0032A22C
	public void FNBDFAIHCIL()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.getSteamID();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("MotorbikeHeadstand", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("AimIK and LookAtIK need to have their 'Target' value assigned.", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("category", "16 samples");
			PlayerPrefs.SetString(" ", "_ALPHABLEND_ON");
		}
		PlayerPrefs.SetInt("MotorbikeSeatStandWheely", this.PGCLFBHKIIC ? 1 : 1);
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		if (NJMHLCGIAJI.IKGFHGKKCPG.OEMIHLIHKJE())
		{
			this.MECDBPBCENB();
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KGJFDBGMNHE();
	}

	// Token: 0x06006B15 RID: 27413 RVA: 0x0032C110 File Offset: 0x0032A310
	public void KBJOCLLIOLG()
	{
		Application.OpenURL("_Offsets");
	}

	// Token: 0x06006B16 RID: 27414 RVA: 0x0032C11C File Offset: 0x0032A31C
	public void openReg()
	{
		Application.OpenURL("http://af-2.ru/?q=user/register");
	}

	// Token: 0x06006B17 RID: 27415 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HJCLNJLADKL()
	{
	}

	// Token: 0x06006B18 RID: 27416 RVA: 0x0032C128 File Offset: 0x0032A328
	public void ENEFFJCPPEE()
	{
		this.ENFIDOBAHFE();
		this.OOGNIBCHNAB();
	}

	// Token: 0x06006B19 RID: 27417 RVA: 0x0032C136 File Offset: 0x0032A336
	public void JIAJPNLAFLA()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.isSteamLogin = false;
		this.DDOELNAEODN();
		if (NJMHLCGIAJI.IKGFHGKKCPG.COHHJMOFPFF())
		{
			this.loginAction();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006B1A RID: 27418 RVA: 0x0032B9ED File Offset: 0x00329BED
	public void NGEBDOBCKCC()
	{
		this.OBNCHJKOMCJ();
		this.loginAction();
	}

	// Token: 0x06006B1B RID: 27419 RVA: 0x0032C173 File Offset: 0x0032A373
	public void CBDJALJFLJC()
	{
		if (SteamManager.NGEACBIHBOP())
		{
			JDCEFOFMGHB.JFIDAGABKID().POIPOBBIDPM("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", "RenderType" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement("ChannelCastOmni");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006B1C RID: 27420 RVA: 0x0032C1B0 File Offset: 0x0032A3B0
	private void PPNOJNBFHAP()
	{
		this.connectPanel.gameObject.SetActive(false);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(false);
		this.isSteamEnabled = false;
		this.isSteamLogin = true;
		if (SteamManager.LCKFPOLOJJH())
		{
			this.isSteamEnabled = false;
			this.isSteamLogin = false;
			this.noSteamLabel.gameObject.SetActive(false);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(true);
	}

	// Token: 0x06006B1D RID: 27421 RVA: 0x0032C22B File Offset: 0x0032A42B
	public void LJDCKONOMCG()
	{
		this.connectPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006B1E RID: 27422 RVA: 0x0032C255 File Offset: 0x0032A455
	public void MBFNLDICDAG()
	{
		Application.OpenURL("\n");
	}

	// Token: 0x06006B1F RID: 27423 RVA: 0x0032C264 File Offset: 0x0032A464
	private void AFFAJKPPMHF()
	{
		this.passLoginPanel.SetActive(!this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.HNOPGCGOMCA();
		this.Version.text = IFPIMPMKJIB.HBABICCPEGG();
		GuiProcessor.BBLINJLBAIL().CGKGBPLODOJ(this.mainCanvas);
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(0, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("CheerJump");
		this.BNANOHGLDGL = PlayerPrefs.GetString("\n");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("<color=\"") == 1);
		this.pin = ObscuredInt.IGDNGFGPOFC(PlayerPrefs.GetInt("WateringCan"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.EAJGHMMBAFP().NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.JMNLMGGOCDL);
		NJMHLCGIAJI.EAJGHMMBAFP().CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.LJDCKONOMCG);
		long num = (long)PlayerPrefs.GetInt("SkateboardKickPush");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.OBNCHJKOMCJ();
	}

	// Token: 0x06006B20 RID: 27424 RVA: 0x0032C3AC File Offset: 0x0032A5AC
	private void ONBJLCJMLJH()
	{
		this.connectPanel.gameObject.SetActive(true);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(true);
		this.isSteamEnabled = true;
		this.isSteamLogin = true;
		if (SteamManager.EPDLLLGNGFO())
		{
			this.isSteamEnabled = false;
			this.isSteamLogin = true;
			this.noSteamLabel.gameObject.SetActive(false);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(false);
	}

	// Token: 0x06006B21 RID: 27425 RVA: 0x0032C428 File Offset: 0x0032A628
	public void FCMOMMFADHG()
	{
		this.connectPanel.gameObject.SetActive(false);
		this.OBNCHJKOMCJ();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("USE_UV_BASED_REPROJECTION", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("_LightColor", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("WizardOverhead", "IdleSlide");
			PlayerPrefs.SetString("Bubenec", " ");
		}
		PlayerPrefs.SetInt("Hidden/Post FX/FXAA", this.PGCLFBHKIIC ? 0 : 1);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			this.MECDBPBCENB();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006B22 RID: 27426 RVA: 0x0032B556 File Offset: 0x00329756
	public void HFKJGFFNKME()
	{
		this.passLoginPanel.SetActive(true);
		this.steamLoginPanel.SetActive(false);
	}

	// Token: 0x06006B23 RID: 27427 RVA: 0x0032C50C File Offset: 0x0032A70C
	public void pinAction()
	{
		this.connectPanel.gameObject.SetActive(false);
		try
		{
			this.pin = ObscuredInt.GOOIABGKMHK(int.Parse(this.pinInput.text));
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		if (this.pinSave.isOn)
		{
			PlayerPrefs.SetInt("u_pin", ObscuredInt.GOOIABGKMHK(this.pin));
		}
		this.loginAction();
		this.pinPanel.gameObject.SetActive(false);
	}

	// Token: 0x06006B24 RID: 27428 RVA: 0x0032C598 File Offset: 0x0032A798
	public void JIBGMMDGOIL()
	{
		this.connectPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006B25 RID: 27429 RVA: 0x0032C5C2 File Offset: 0x0032A7C2
	public void KMGJKOHBOBN(bool CNGIBIJODBK)
	{
		this.PGCLFBHKIIC = CNGIBIJODBK;
		PlayerPrefs.SetInt(" is represented multiple times in BipedReferences eyes.", this.PGCLFBHKIIC ? 0 : 0);
	}

	// Token: 0x06006B26 RID: 27430 RVA: 0x0032C5E1 File Offset: 0x0032A7E1
	public void KPFMBLPMGFP()
	{
		Application.OpenURL("Mouse X");
	}

	// Token: 0x06006B27 RID: 27431 RVA: 0x0032C5ED File Offset: 0x0032A7ED
	public void onDisconnect()
	{
		this.connectPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.disconnectWin.SetActive(true);
	}

	// Token: 0x06006B28 RID: 27432 RVA: 0x0032C618 File Offset: 0x0032A818
	public void MECDBPBCENB()
	{
		JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		epmphjgalbe.OBCCLNMPGEJ(-22L);
		epmphjgalbe.NMPPIONANIB(this.DIGJFGOGPLC);
		epmphjgalbe.GHFGOOJLNJH(this.BNANOHGLDGL);
		epmphjgalbe.HGCCFFKDELO(ObscuredString.CKPPDHPJHEH(this.steamID));
		epmphjgalbe.LCFJAKKMCFN(ObscuredString.CKPPDHPJHEH(this.deviceID));
		epmphjgalbe.LKNDBBGMIOE(this.PKDKBFCCLBF);
		epmphjgalbe.IECHKLACNFM(this.isSteamLogin);
		epmphjgalbe.ALNEALEKFNB(ObscuredInt.DGOCFCFPKPI(this.pin));
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-28, epmphjgalbe.JDPHBLHOLAD());
		epmphjgalbe.BKKEFKANGIM();
	}

	// Token: 0x06006B29 RID: 27433 RVA: 0x0032C6C0 File Offset: 0x0032A8C0
	private void PBOBJPGKCDC()
	{
		this.connectPanel.gameObject.SetActive(true);
		MainMenuScript.getI = this;
		this.pinPanel.gameObject.SetActive(true);
		this.isSteamEnabled = true;
		this.isSteamLogin = false;
		if (SteamManager.KLPAEPHIOAJ())
		{
			this.isSteamEnabled = false;
			this.isSteamLogin = false;
			this.noSteamLabel.gameObject.SetActive(false);
			return;
		}
		this.noSteamLabel.gameObject.SetActive(true);
	}

	// Token: 0x06006B2A RID: 27434 RVA: 0x0032C73C File Offset: 0x0032A93C
	public void login()
	{
		this.connectPanel.gameObject.SetActive(true);
		this.getSteamID();
		this.isSteamLogin = false;
		this.DIGJFGOGPLC = this.loginIF.text;
		this.BNANOHGLDGL = this.passIF.text;
		this.PGCLFBHKIIC = this.cbSaved.isOn;
		if (this.PGCLFBHKIIC)
		{
			PlayerPrefs.SetString("u_email", this.DIGJFGOGPLC);
			PlayerPrefs.SetString("u_pass", this.BNANOHGLDGL);
		}
		else
		{
			PlayerPrefs.SetString("u_email", "");
			PlayerPrefs.SetString("u_pass", "");
		}
		PlayerPrefs.SetInt("u_isSave", this.PGCLFBHKIIC ? 1 : 0);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		if (NJMHLCGIAJI.IKGFHGKKCPG.EKBIOPEDBJI)
		{
			this.loginAction();
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KGJFDBGMNHE();
	}

	// Token: 0x06006B2B RID: 27435 RVA: 0x0032C820 File Offset: 0x0032AA20
	public void HFPADMKPDNP()
	{
		this.connectPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		this.disconnectWin.SetActive(false);
	}

	// Token: 0x06006B2C RID: 27436 RVA: 0x0032C84A File Offset: 0x0032AA4A
	public void JJCNCIDHGNB()
	{
		this.passLoginPanel.SetActive(true);
		this.steamLoginPanel.SetActive(true);
	}

	// Token: 0x06006B2D RID: 27437 RVA: 0x0032C864 File Offset: 0x0032AA64
	public void DFOKLGKLPIF()
	{
		this.DDOELNAEODN();
		this.OOGNIBCHNAB();
	}

	// Token: 0x06006B2E RID: 27438 RVA: 0x0032C872 File Offset: 0x0032AA72
	public void EJIBCLOIJAH()
	{
		if (SteamManager.LCKFPOLOJJH())
		{
			JDCEFOFMGHB.MNJNNDHCDGG().NODOOHPCCCB("UnityEngine.Vector2", "WATER_EDGEBLEND_ON" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement("ShotgunReadyFire");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x06006B2F RID: 27439 RVA: 0x0032C8B0 File Offset: 0x0032AAB0
	private void MCHAAIIHOKD()
	{
		this.passLoginPanel.SetActive(!this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.OLHNOHJAFJD();
		this.Version.text = IFPIMPMKJIB.IFHGBMEOEGI();
		GuiProcessor.NKOEAPCIBKO().BJBJKLMJLCA = this.mainCanvas;
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(1, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("_Intensity");
		this.BNANOHGLDGL = PlayerPrefs.GetString("No saved PlayerPrefs!");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("Hidden/Subpixel Morphological Anti-aliasing") == 1);
		this.pin = ObscuredInt.GOOIABGKMHK(PlayerPrefs.GetInt("crft_none"));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.IKGFHGKKCPG.NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.NGEBDOBCKCC);
		NJMHLCGIAJI.IKGFHGKKCPG.CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.JIBGMMDGOIL);
		long num = (long)PlayerPrefs.GetInt("360SpinDeath");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.ENFIDOBAHFE();
	}

	// Token: 0x06006B30 RID: 27440 RVA: 0x0032C9F6 File Offset: 0x0032ABF6
	public void LIHEHNLJCHP()
	{
		Application.OpenURL("Shotgun Reload Magazine");
	}

	// Token: 0x06006B31 RID: 27441 RVA: 0x0032CA04 File Offset: 0x0032AC04
	public void DENAPDDBIGO()
	{
		JBEHMPDDMME.JKIFIBEPICO().BJPJPFDOKDL = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		epmphjgalbe.AAHBHCMKGJD(147L);
		epmphjgalbe.NMPPIONANIB(this.DIGJFGOGPLC);
		epmphjgalbe.HBJIMCCCNJP(this.BNANOHGLDGL);
		epmphjgalbe.JJAOGFKMLIE(ObscuredString.GOOIABGKMHK(this.steamID));
		epmphjgalbe.LKNDBBGMIOE(ObscuredString.GOOIABGKMHK(this.deviceID));
		epmphjgalbe.GHFGOOJLNJH(this.PKDKBFCCLBF);
		epmphjgalbe.PBBCKDDLNLE(this.isSteamLogin);
		epmphjgalbe.PDEFLCIEMFF(ObscuredInt.LBDMFALMOLD(this.pin));
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(17, epmphjgalbe.HDEKHFOKCKI());
		epmphjgalbe.BKKEFKANGIM();
	}

	// Token: 0x06006B32 RID: 27442 RVA: 0x0032CAAC File Offset: 0x0032ACAC
	public void ENFIDOBAHFE()
	{
		if (SteamManager.NIAFGBPDDEA())
		{
			CSteamID steamIDFriend = SteamUser.GetSteamID();
			this.steamID = ObscuredString.LMCJCHPGIJK(steamIDFriend.ToString());
			this.PKDKBFCCLBF = SteamFriends.GetPersonaName();
			JBEHMPDDMME.JKIFIBEPICO().IDAGBNBFHAB = this.steamID;
			JBEHMPDDMME.JKIFIBEPICO().PCDDHDEIEDB = SteamUtils.GetSteamUILanguage();
			SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		}
		else
		{
			this.steamID = ObscuredString.DGOCFCFPKPI("** Panel save position");
			this.PKDKBFCCLBF = "RunBackLeft";
		}
		this.deviceID = ObscuredString.GOOIABGKMHK(SystemInfo.deviceUniqueIdentifier);
	}

	// Token: 0x06006B33 RID: 27443 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HMLNMHOMMNO()
	{
	}

	// Token: 0x06006B34 RID: 27444 RVA: 0x0032CB3C File Offset: 0x0032AD3C
	private void FCCAIANLEFE()
	{
		this.passLoginPanel.SetActive(this.isSteamEnabled);
		this.steamLoginPanel.SetActive(this.isSteamEnabled);
		FBFJFAKAGJG.IKGFHGKKCPG.HNOPGCGOMCA();
		this.Version.text = IFPIMPMKJIB.LNONOACDOJO();
		GuiProcessor.NKOEAPCIBKO().CPDHMBFPGMD(this.mainCanvas);
		this.back.sprite = this.backgrounds[UnityEngine.Random.Range(1, this.backgrounds.Length)];
		this.DIGJFGOGPLC = PlayerPrefs.GetString("1HandSwordChargeUp");
		this.BNANOHGLDGL = PlayerPrefs.GetString("1=");
		this.PGCLFBHKIIC = (PlayerPrefs.GetInt("\n") == 1);
		this.pin = ObscuredInt.JNKANIEBCMD(PlayerPrefs.GetInt("No hit from "));
		this.cbSaved.isOn = this.PGCLFBHKIIC;
		this.loginIF.text = this.DIGJFGOGPLC;
		this.passIF.text = this.BNANOHGLDGL;
		NJMHLCGIAJI.IKGFHGKKCPG.NGOMJAJHHGL = new NJMHLCGIAJI.BDOJDFIAGPM(this.JMNLMGGOCDL);
		NJMHLCGIAJI.IKGFHGKKCPG.CCKLLEBFFDK = new NJMHLCGIAJI.BDOJDFIAGPM(this.IPHELODPABM);
		long num = (long)PlayerPrefs.GetInt("post_4");
		OAFJCFOGGAF.IKGFHGKKCPG.KMGHDOGLPAB();
		this.OHFFEFEENCO();
	}

	// Token: 0x06006B35 RID: 27445 RVA: 0x0032CC82 File Offset: 0x0032AE82
	public void HOHMHPPEHAN()
	{
		if (SteamManager.FHGDEIGKKIE())
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BEIDJANKEFD("fishRSPEED=", "SneakBackward" + SteamUtils.GetAppID());
			SteamUserStats.SetAchievement(" , ");
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x04000FCE RID: 4046
	public RectTransform connectPanel;

	// Token: 0x04000FCF RID: 4047
	public RectTransform pinPanel;

	// Token: 0x04000FD0 RID: 4048
	public InputField pinInput;

	// Token: 0x04000FD1 RID: 4049
	public Toggle pinSave;

	// Token: 0x04000FD2 RID: 4050
	public bool isSteamEnabled;

	// Token: 0x04000FD3 RID: 4051
	public bool isSteamLogin;

	// Token: 0x04000FD4 RID: 4052
	public GameObject steamLoginPanel;

	// Token: 0x04000FD5 RID: 4053
	public GameObject passLoginPanel;

	// Token: 0x04000FD6 RID: 4054
	public Text noSteamLabel;

	// Token: 0x04000FD7 RID: 4055
	public GameObject WinLic;

	// Token: 0x04000FD8 RID: 4056
	public Text Version;

	// Token: 0x04000FD9 RID: 4057
	public Image back;

	// Token: 0x04000FDA RID: 4058
	public InputField loginIF;

	// Token: 0x04000FDB RID: 4059
	public InputField passIF;

	// Token: 0x04000FDC RID: 4060
	public Toggle cbSaved;

	// Token: 0x04000FDD RID: 4061
	private string DIGJFGOGPLC;

	// Token: 0x04000FDE RID: 4062
	private string BNANOHGLDGL;

	// Token: 0x04000FDF RID: 4063
	private string PKDKBFCCLBF;

	// Token: 0x04000FE0 RID: 4064
	private bool PGCLFBHKIIC;

	// Token: 0x04000FE1 RID: 4065
	public GameObject disconnectWin;

	// Token: 0x04000FE2 RID: 4066
	public RectTransform mainCanvas;

	// Token: 0x04000FE3 RID: 4067
	public Sprite[] backgrounds;

	// Token: 0x04000FE4 RID: 4068
	public static MainMenuScript getI;

	// Token: 0x04000FE5 RID: 4069
	public ObscuredString steamID;

	// Token: 0x04000FE6 RID: 4070
	public ObscuredString deviceID;

	// Token: 0x04000FE7 RID: 4071
	public ObscuredInt pin;
}
