using System;
using System.Text;
using Steamworks;
using UnityEngine;

// Token: 0x02000081 RID: 129
[DisallowMultipleComponent]
internal class SteamManager : MonoBehaviour
{
	// Token: 0x06001DF1 RID: 7665 RVA: 0x000E5238 File Offset: 0x000E3438
	private void MECEHFDKHPF()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x000E525C File Offset: 0x000E345C
	private void Update()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x000E526C File Offset: 0x000E346C
	public static bool NGEACBIHBOP()
	{
		return SteamManager.AFNOGALPADL().LPLMEIHFMEA;
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000E5278 File Offset: 0x000E3478
	private static SteamManager DNACAAOLFHL()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("PreserveDetails").AddComponent<SteamManager>();
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000E5294 File Offset: 0x000E3494
	private void AKGBDJDMOLC()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("#004000");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("Text node is empy!", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("****************  stopMusic ", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(110U)))
			{
				Debug.LogError("_SampleDistance");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("fanfare.wav" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("<b>Obscured Cheating Detector</b>", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x000E5384 File Offset: 0x000E3584
	private void PHONLBCOJEG()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("1/");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("invn_rec16", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("{0:D2}:{1:D2}", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(138U)))
			{
				Debug.LogError("PaperTurn.wav");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("inv_impr" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("RollerBladeFrontFlip", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000E5474 File Offset: 0x000E3674
	private void IMEIOFGKMDK()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.EFHPJOOCDFJ);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000E54C4 File Offset: 0x000E36C4
	private void CIDFLCGOBKO()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.PAEGAIDHNKI);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000E5512 File Offset: 0x000E3712
	public static bool EPDLLLGNGFO()
	{
		return SteamManager.BAPIFNDJMAN().LPLMEIHFMEA;
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000E551E File Offset: 0x000E371E
	private static void ECOFIHGCIHN(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x000E551E File Offset: 0x000E371E
	private static void LCOMAIKIHLB(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x000E5238 File Offset: 0x000E3438
	private void DAJCCMDCMIK()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x000E525C File Offset: 0x000E345C
	private void FKHAKIKPFFO()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x000E5526 File Offset: 0x000E3726
	public static bool PGAALOOPLCE()
	{
		return SteamManager.CNMIMHNCHOL().LPLMEIHFMEA;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x000E5534 File Offset: 0x000E3734
	private void MMKMNFOOIKL()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ECOFIHGCIHN);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000E5512 File Offset: 0x000E3712
	public static bool NNFCGADDAHL()
	{
		return SteamManager.BAPIFNDJMAN().LPLMEIHFMEA;
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x000E5238 File Offset: 0x000E3438
	private void IOFCKOOCIMG()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x000E525C File Offset: 0x000E345C
	private void FPLNDDMFFKG()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x000E5582 File Offset: 0x000E3782
	public static bool GAEJKDJCOEH()
	{
		return SteamManager.ADHPKNILDOP().LPLMEIHFMEA;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x000E558E File Offset: 0x000E378E
	private static SteamManager HJOJPJALBPF()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("ShootWireframeModule").AddComponent<SteamManager>();
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000E525C File Offset: 0x000E345C
	private void CDLDCKAHLHC()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000E55A8 File Offset: 0x000E37A8
	private void EBAJDGLIAPE()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.CGDPFJHCPFC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x000E55F8 File Offset: 0x000E37F8
	private void OnEnable()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.CDFNJAFHONK);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x000E551E File Offset: 0x000E371E
	private static void CDFNJAFHONK(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000E5648 File Offset: 0x000E3848
	private void IJHHOLCHNNP()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("No hit from ");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError(" load woman version", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("!", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(127U)))
			{
				Debug.LogError("");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("\n" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("wpn_add/base", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000E5738 File Offset: 0x000E3938
	private static SteamManager ADHPKNILDOP()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("<b>ObscuredInt:</b> ").AddComponent<SteamManager>();
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000E5754 File Offset: 0x000E3954
	private void FALFMIAEIJC()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.DGPLEKHPAKC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000E525C File Offset: 0x000E345C
	private void BJOICAKCPLI()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x000E57A4 File Offset: 0x000E39A4
	private void CACBLLBNIJE()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("ShotgunReloadChamber");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("#> _Planar Reflection Camera < ", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_DelItem.wav", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967136U)))
			{
				Debug.LogError("ok");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("Failed to load AssetBundle ", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000E5894 File Offset: 0x000E3A94
	private static SteamManager CNMIMHNCHOL()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("wpn_rod1").AddComponent<SteamManager>();
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x000E551E File Offset: 0x000E371E
	private static void DGPLEKHPAKC(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000E58B0 File Offset: 0x000E3AB0
	private void PBOBJPGKCDC()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("run");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("_SubsampleIndices", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("SceneCamera", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(194U)))
			{
				Debug.LogError(" from ");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("inv_pcs1" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("Root transform is null. Can't initiate Grounding.", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x000E59A0 File Offset: 0x000E3BA0
	private void OJDLGCFKCEJ()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("</color>");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError(" x", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Run Back Left", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967179U)))
			{
				Debug.LogError("gameexist");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("USER" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("Transform is null.", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000E525C File Offset: 0x000E345C
	private void CIBBPIIDHJH()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000E525C File Offset: 0x000E345C
	private void IEOICHPKEMD()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000E5238 File Offset: 0x000E3438
	private void ALPOPEGDHBL()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000E551E File Offset: 0x000E371E
	private static void HLKCCIJOMFI(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000E5A90 File Offset: 0x000E3C90
	public static bool NIAFGBPDDEA()
	{
		return SteamManager.ELOBJGIDGCP.LPLMEIHFMEA;
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000E5A9C File Offset: 0x000E3C9C
	private void LNMBLLMCBAB()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception(" x");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("[ACTk] Speed Hack Detector: already running!", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Obscured Cheating Detector", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967139U)))
			{
				Debug.LogError("isRodOpen");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("Vertical" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("WeaponRun", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x000E5B8C File Offset: 0x000E3D8C
	private void JCMBBMFDBAI()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("_BokehParams", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("\n", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(43U)))
			{
				Debug.LogError("Mouse ScrollWheel");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("_SpecCubeIBL" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("Soccer", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x000E5C7C File Offset: 0x000E3E7C
	private void Awake()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(557780U)))
			{
				Debug.LogError("App QUIT");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x000E5D6C File Offset: 0x000E3F6C
	private void DHIJGNHBMFJ()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("Spine");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("L", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(196U)))
			{
				Debug.LogError("Idle Spew");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("_CameraClipInfo" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000E5E5C File Offset: 0x000E405C
	public static bool GHHNBKFIFOC()
	{
		return SteamManager.INNAPDBCGFE().LPLMEIHFMEA;
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x000E525C File Offset: 0x000E345C
	private void JEPDBHDFDCJ()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x000E5E68 File Offset: 0x000E4068
	private void BHMLILLBFLP()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.CDFNJAFHONK);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000E5EB6 File Offset: 0x000E40B6
	private static SteamManager CCFJJBJBOBG()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("FOG_SCATTERING_ON").AddComponent<SteamManager>();
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x000E5ED0 File Offset: 0x000E40D0
	private void PNGOLEOOHCD()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.PAEGAIDHNKI);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000E5F1E File Offset: 0x000E411E
	public static bool CJBDAMIDAOE()
	{
		return SteamManager.CGJDIGAFBID().LPLMEIHFMEA;
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x000E5582 File Offset: 0x000E3782
	public static bool OIPNMDCOJMD()
	{
		return SteamManager.ADHPKNILDOP().LPLMEIHFMEA;
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000E5F2C File Offset: 0x000E412C
	private void COOHBKKNOLG()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("HDR");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("Grounding layers are set to nothing. Please add a ground layer.", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("CraftProf.xml", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967215U)))
			{
				Debug.LogError("demoDouble");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("act_orderb_" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("IceHockeyDekeMiddle", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x000E5512 File Offset: 0x000E3712
	public static bool HFCCLHMGOKA()
	{
		return SteamManager.BAPIFNDJMAN().LPLMEIHFMEA;
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x000E525C File Offset: 0x000E345C
	private void DAFJMNMFOON()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x000E551E File Offset: 0x000E371E
	private static void CGDPFJHCPFC(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x000E601C File Offset: 0x000E421C
	private void AOABMLPHMME()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.CDFNJAFHONK);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x000E606C File Offset: 0x000E426C
	private void OCIANPBJNND()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ALGKPKLNNHH);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x000E525C File Offset: 0x000E345C
	private void FJIGNBOFFOJ()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x000E5512 File Offset: 0x000E3712
	public static bool LCIFODJFFBL()
	{
		return SteamManager.BAPIFNDJMAN().LPLMEIHFMEA;
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x000E5238 File Offset: 0x000E3438
	private void GPPHLKHCHON()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x000E60BC File Offset: 0x000E42BC
	private void CCGIGJMJCDH()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ALGKPKLNNHH);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x000E5238 File Offset: 0x000E3438
	private void MEFOBNJIMGC()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x000E610A File Offset: 0x000E430A
	private static SteamManager OLPOGLLKDDE()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("jamp").AddComponent<SteamManager>();
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x000E551E File Offset: 0x000E371E
	private static void DAKJOBDCOHF(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x000E551E File Offset: 0x000E371E
	private static void CBOCJPBHNKC(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000E6124 File Offset: 0x000E4324
	private void BBAGNFIALFG()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.HLKCCIJOMFI);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x000E6174 File Offset: 0x000E4374
	private void EIGBKJAEIKO()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.EFHPJOOCDFJ);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000E5A90 File Offset: 0x000E3C90
	public static bool FPAKOLIPIND
	{
		get
		{
			return SteamManager.ELOBJGIDGCP.LPLMEIHFMEA;
		}
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x000E61C4 File Offset: 0x000E43C4
	private void DDEGPPKLAOL()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("post_msg6");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("MotorbikeShootLeft", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("#000000", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967267U)))
			{
				Debug.LogError(" ms");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("IdleSpew" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("result=OK", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x000E62B4 File Offset: 0x000E44B4
	private void KOAEBJLNOLI()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.DGPLEKHPAKC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000E5238 File Offset: 0x000E3438
	private void FLGGHNOABOA()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000E6304 File Offset: 0x000E4504
	private void IBOMADDAFAO()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.CGDPFJHCPFC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x000E6354 File Offset: 0x000E4554
	private void NJJFDKFNBCL()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.LCOMAIKIHLB);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000E63A2 File Offset: 0x000E45A2
	private static SteamManager ELOBJGIDGCP
	{
		get
		{
			return SteamManager.NPAHEICLICM ?? new GameObject("SteamManager").AddComponent<SteamManager>();
		}
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000E63BC File Offset: 0x000E45BC
	private static SteamManager AFNOGALPADL()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("gi_nl3").AddComponent<SteamManager>();
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000E551E File Offset: 0x000E371E
	private static void PAEGAIDHNKI(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000E525C File Offset: 0x000E345C
	private void MEFOGCFJBNE()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x000E63D6 File Offset: 0x000E45D6
	public static bool LCKFPOLOJJH()
	{
		return SteamManager.JKABKIELIAL().LPLMEIHFMEA;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x000E5238 File Offset: 0x000E3438
	private void HGNHAGCHGLA()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000E63E2 File Offset: 0x000E45E2
	public static bool FHGDEIGKKIE()
	{
		return SteamManager.EDBLGHMIEEN().LPLMEIHFMEA;
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000E63EE File Offset: 0x000E45EE
	public static bool LGPCPFGMOGJ()
	{
		return SteamManager.BMHGCKPCLIA().LPLMEIHFMEA;
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000E63FC File Offset: 0x000E45FC
	private void EEININLNBKJ()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("x");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("Cheer Jump", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_ToPrevViewProjCombined", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(158U)))
			{
				Debug.LogError("HeelClick");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("IceHockeyGoalieSave2" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("_Newitem.wav", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000E64EC File Offset: 0x000E46EC
	private void MGNGNBMMAAD()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("_ColorBuffer");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("WorkerPickaxe", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("demoLong", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(174U)))
			{
				Debug.LogError("hgtDst=");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("no_time_period" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("<=|>=|!=", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x000E525C File Offset: 0x000E345C
	private void CLCJPEDHFJA()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000E525C File Offset: 0x000E345C
	private void GDBBAMFMKII()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x000E551E File Offset: 0x000E371E
	private static void ENCEGIGCHFA(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000E65DC File Offset: 0x000E47DC
	private void IIEOKJCJMHH()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.DGPLEKHPAKC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x000E662A File Offset: 0x000E482A
	private static SteamManager BAPIFNDJMAN()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("1HandSwordChargeUp").AddComponent<SteamManager>();
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000E6644 File Offset: 0x000E4844
	private void APEDLIKHDFA()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("id");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("OfficeSitting45DegLeg", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967187U)))
			{
				Debug.LogError("https://groups.google.com/forum/#!forum/final-ik");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("RollerBladeGrindRoyale" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("[AmplifyColor] ", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x000E6734 File Offset: 0x000E4934
	private void BIKPILOBGIE()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.EMJOGJKDDNF);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x000E6784 File Offset: 0x000E4984
	private void IIELJNDNLMO()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception(", ");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("isBigFish", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("VolumetricFogAndMist/CopyDepth", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(130U)))
			{
				Debug.LogError("__c");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("_BlurRadius4" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("** Panel save position", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000E63D6 File Offset: 0x000E45D6
	public static bool ABJAJJMGOKF()
	{
		return SteamManager.JKABKIELIAL().LPLMEIHFMEA;
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000E6874 File Offset: 0x000E4A74
	private static SteamManager EDBLGHMIEEN()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("mask=").AddComponent<SteamManager>();
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000E688E File Offset: 0x000E4A8E
	private static SteamManager KBAFDIKHOGO()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("[sysname]").AddComponent<SteamManager>();
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000E68A8 File Offset: 0x000E4AA8
	private void KFIBDJHDJJP()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ECOFIHGCIHN);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x000E68F8 File Offset: 0x000E4AF8
	private void ECHEPDJBGLP()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.DGPLEKHPAKC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000E551E File Offset: 0x000E371E
	private static void ALGKPKLNNHH(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000E6948 File Offset: 0x000E4B48
	private void DHGCOGABJFK()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("_History4LumaTex");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("WandAttack2", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Add random value", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(23U)))
			{
				Debug.LogError("WizardPowerUp");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("MotorbikeSpecialFlip", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000E551E File Offset: 0x000E371E
	private static void EFGHGMDHLBH(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x000E5512 File Offset: 0x000E3712
	public static bool KLPAEPHIOAJ()
	{
		return SteamManager.BAPIFNDJMAN().LPLMEIHFMEA;
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x000E551E File Offset: 0x000E371E
	private static void EMJOGJKDDNF(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x000E6A38 File Offset: 0x000E4C38
	private static SteamManager JKABKIELIAL()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("IdleDie").AddComponent<SteamManager>();
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000E6A54 File Offset: 0x000E4C54
	private void OBBMOJMEIEO()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("Failed parsing atlas group.  Setting to group 0");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("IdleSandCover", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("SneakBackward", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967234U)))
			{
				Debug.LogError("RussianDance");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("ClimbRight" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("INTERFACE", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x000E6B44 File Offset: 0x000E4D44
	private void DHFLFGBENBF()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ECOFIHGCIHN);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000E6B94 File Offset: 0x000E4D94
	private void NKHMBEDDFAJ()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("Pistol Reload");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("VaderChoke", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(175U)))
			{
				Debug.LogError("money");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("Ban action" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("------------------------------------------------------", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x000E6C84 File Offset: 0x000E4E84
	public static bool PJMKPOFDGCK()
	{
		return SteamManager.IMGFFCGLGPL().LPLMEIHFMEA;
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x000E551E File Offset: 0x000E371E
	private static void PKHNFOCBFOK(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x000E6C90 File Offset: 0x000E4E90
	private void MBKLIKGAKJB()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("Jump");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Квест", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967257U)))
			{
				Debug.LogError("Quadruped");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("B" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("UNDISTORT", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = true;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000E6D80 File Offset: 0x000E4F80
	private static SteamManager BMHGCKPCLIA()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("_Intensity").AddComponent<SteamManager>();
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000E6D9C File Offset: 0x000E4F9C
	private void KDMCOLGDFLD()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("_DstBlend");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("rem", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_StretchWidth", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967194U)))
			{
				Debug.LogError("money");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("preservePlayerPrefs" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("StartPhysPoint", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000E6E8C File Offset: 0x000E508C
	private void JMFMOADCCIE()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.ECOFIHGCIHN);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000E6EDA File Offset: 0x000E50DA
	private static SteamManager CGJDIGAFBID()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("OfficeSitting").AddComponent<SteamManager>();
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x000E525C File Offset: 0x000E345C
	private void NMMGHFDLNOE()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x000E63E2 File Offset: 0x000E45E2
	public static bool JBKCBLGNLLG()
	{
		return SteamManager.EDBLGHMIEEN().LPLMEIHFMEA;
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x000E5238 File Offset: 0x000E3438
	private void HHNFPGKAAMF()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000E5238 File Offset: 0x000E3438
	private void PHLEMEDNPBN()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x000E6EF4 File Offset: 0x000E50F4
	private static SteamManager IMGFFCGLGPL()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("iPoint").AddComponent<SteamManager>();
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x000E6F10 File Offset: 0x000E5110
	private void EKOENFCHNKL()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.EFGHGMDHLBH);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x000E5F1E File Offset: 0x000E411E
	public static bool FNNHOLIBGJH()
	{
		return SteamManager.CGJDIGAFBID().LPLMEIHFMEA;
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x000E5238 File Offset: 0x000E3438
	private void OnDestroy()
	{
		if (SteamManager.NPAHEICLICM != this)
		{
			return;
		}
		SteamManager.NPAHEICLICM = null;
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.Shutdown();
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x000E525C File Offset: 0x000E345C
	private void MEIOHFKFEME()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x000E525C File Offset: 0x000E345C
	private void BNKJNBIDPME()
	{
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x000E6F60 File Offset: 0x000E5160
	private void HCMHMFHMPHN()
	{
		if (SteamManager.NPAHEICLICM != null)
		{
			if (SteamManager.NPAHEICLICM != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		SteamManager.NPAHEICLICM = this;
		if (SteamManager.BNDFOOBLDIB)
		{
			throw new Exception("");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("********* connect to chat ", this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("RHandPunch", this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(new AppId_t(4294967130U)))
			{
				Debug.LogError("{{ {{{0}:{1}}}, {{{2}:{3}}} }}");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("_SunPosition" + arg, this);
			Application.Quit();
			return;
		}
		this.LPLMEIHFMEA = SteamAPI.Init();
		if (!this.LPLMEIHFMEA)
		{
			Debug.LogError("demoLong", this);
			return;
		}
		SteamManager.BNDFOOBLDIB = false;
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x000E63D6 File Offset: 0x000E45D6
	public static bool MFDPJMKMHNG()
	{
		return SteamManager.JKABKIELIAL().LPLMEIHFMEA;
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x000E551E File Offset: 0x000E371E
	private static void EFHPJOOCDFJ(int DJPMBJHGIHE, StringBuilder CINLIPLKLPF)
	{
		Debug.Log(CINLIPLKLPF);
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x000E7050 File Offset: 0x000E5250
	private void HNGLBEOAIHN()
	{
		if (SteamManager.NPAHEICLICM == null)
		{
			SteamManager.NPAHEICLICM = this;
		}
		if (!this.LPLMEIHFMEA)
		{
			return;
		}
		if (this.MBMIEJINHKL == null)
		{
			this.MBMIEJINHKL = new SteamAPIWarningMessageHook_t(SteamManager.DGPLEKHPAKC);
			SteamClient.SetWarningMessageHook(this.MBMIEJINHKL);
		}
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000E709E File Offset: 0x000E529E
	private static SteamManager INNAPDBCGFE()
	{
		return SteamManager.NPAHEICLICM ?? new GameObject("PistolInstant").AddComponent<SteamManager>();
	}

	// Token: 0x0400031E RID: 798
	private static SteamManager NPAHEICLICM;

	// Token: 0x0400031F RID: 799
	private static bool BNDFOOBLDIB;

	// Token: 0x04000320 RID: 800
	private bool LPLMEIHFMEA;

	// Token: 0x04000321 RID: 801
	private SteamAPIWarningMessageHook_t MBMIEJINHKL;
}
