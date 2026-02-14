using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000205 RID: 517
public class NJMHLCGIAJI : IPhotonPeerListener
{
	// Token: 0x0600782B RID: 30763 RVA: 0x00399B68 File Offset: 0x00397D68
	public void OnStatusChanged(StatusCode ECDGKMBGCMA)
	{
		Debug.Log("---------- NOnStatusChanged " + ECDGKMBGCMA);
		Debug.Log("OnStatusChanged: " + ECDGKMBGCMA);
		switch (ECDGKMBGCMA)
		{
		case StatusCode.ExceptionOnConnect:
			Debug.Log("ExceptionOnConnect PROCEDURE " + StatusCode.Exception);
			return;
		case StatusCode.Connect:
			if (this.NGOMJAJHHGL != null)
			{
				this.NGOMJAJHHGL();
				return;
			}
			break;
		case StatusCode.Disconnect:
			Debug.Log("onDisconnect PROCEDURE");
			if (this.CCKLLEBFFDK != null)
			{
				this.CCKLLEBFFDK();
				return;
			}
			break;
		default:
			Debug.Log("OnStatusChanged UNKNOW " + ECDGKMBGCMA);
			break;
		}
	}

	// Token: 0x0600782C RID: 30764 RVA: 0x00399C1C File Offset: 0x00397E1C
	public void OnEvent(EventData CAKNKPPGGIK)
	{
		int num = 0;
		if (CAKNKPPGGIK.Parameters.ContainsKey(1))
		{
			num = (int)CAKNKPPGGIK.Parameters[1];
		}
		byte[] ecgngbomhdh = null;
		if (CAKNKPPGGIK.Parameters.ContainsKey(3))
		{
			ecgngbomhdh = (byte[])CAKNKPPGGIK.Parameters[3];
		}
		if (num > 0)
		{
			NJMHLCGIAJI.AEABDIKOKKO item = new NJMHLCGIAJI.AEABDIKOKKO(num, ecgngbomhdh);
			if (this.NAAMHEFBMPI.Count > 100 && num == 3)
			{
				return;
			}
			List<NJMHLCGIAJI.AEABDIKOKKO> naamhefbmpi = this.NAAMHEFBMPI;
			lock (naamhefbmpi)
			{
				this.NAAMHEFBMPI.Add(item);
				return;
			}
		}
		Debug.LogError("OnEvent: Unknow Event");
	}

	// Token: 0x0600782D RID: 30765 RVA: 0x00399CD4 File Offset: 0x00397ED4
	public void MADKBBLOPGO(int ELEMIPMLIGG, long DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.MFPECHIKBCO(DNHBPGOKLKD);
			this.HJPGADJMICM(ELEMIPMLIGG, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x0600782E RID: 30766 RVA: 0x00399D14 File Offset: 0x00397F14
	public void HJPGADJMICM(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH += 0;
		int num = this.BEFLOMKOOCH + ELEMIPMLIGG ^ -124;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				0,
				ELEMIPMLIGG
			},
			{
				7,
				num
			},
			{
				2,
				this.BEFLOMKOOCH
			},
			{
				5,
				DNHBPGOKLKD
			}
		};
		if (this.FNGABAODCEC != null)
		{
			this.FNGABAODCEC.OpCustom(0, customOpParameters, true);
		}
	}

	// Token: 0x0600782F RID: 30767 RVA: 0x00399D8F File Offset: 0x00397F8F
	public void DebugReturn(DebugLevel CNOLCNDBLJE, string EDAPHMJENPK)
	{
		Debug.Log("---------- DebugReturn " + EDAPHMJENPK);
	}

	// Token: 0x06007830 RID: 30768 RVA: 0x00399DA4 File Offset: 0x00397FA4
	public void KMGEJOMMOJF(OperationResponse LJMENJDDMBK)
	{
		int num = 0;
		if (LJMENJDDMBK.Parameters.ContainsKey(0))
		{
			num = (int)LJMENJDDMBK.Parameters[0];
		}
		byte[] dnhbpgoklkd = null;
		if (LJMENJDDMBK.Parameters.ContainsKey(2))
		{
			dnhbpgoklkd = (byte[])LJMENJDDMBK.Parameters[0];
		}
		if (num > 0)
		{
			this.IDNBPHBNNBI++;
			if (Time.time - this.EDCFDDLFAHG > 146f)
			{
				this.EEANFBHNMFG = this.IDNBPHBNNBI;
				this.IDNBPHBNNBI = 1;
				this.EDCFDDLFAHG = Time.time;
			}
			EMJAJDNLEJN.EEOPOHEALPK().FIDCELLHJIH(num, dnhbpgoklkd);
			return;
		}
		Debug.LogError("?");
	}

	// Token: 0x06007831 RID: 30769 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MJHKLIPPGHF()
	{
	}

	// Token: 0x06007832 RID: 30770 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MEJABAKOHCA()
	{
	}

	// Token: 0x06007833 RID: 30771 RVA: 0x00399E50 File Offset: 0x00398050
	public void AKJKNCIKBBF(int ELEMIPMLIGG, int DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007834 RID: 30772 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PPOADKOCBGJ()
	{
	}

	// Token: 0x06007835 RID: 30773 RVA: 0x00399E90 File Offset: 0x00398090
	public void AKJKNCIKBBF(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH++;
		int num = this.BEFLOMKOOCH + ELEMIPMLIGG ^ 177438591;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				1,
				ELEMIPMLIGG
			},
			{
				4,
				num
			},
			{
				2,
				this.BEFLOMKOOCH
			},
			{
				3,
				DNHBPGOKLKD
			}
		};
		if (this.FNGABAODCEC != null)
		{
			this.FNGABAODCEC.OpCustom(1, customOpParameters, true);
		}
	}

	// Token: 0x06007836 RID: 30774 RVA: 0x00399F0C File Offset: 0x0039810C
	public void HNJGANCNGFJ(StatusCode ECDGKMBGCMA)
	{
		Debug.Log("ApplePick" + ECDGKMBGCMA);
		Debug.Log("<color='#003000'>" + ECDGKMBGCMA);
		switch (ECDGKMBGCMA)
		{
		case (StatusCode)157:
			Debug.Log("post_4" + (StatusCode)143);
			return;
		case (StatusCode)158:
			if (this.NGOMJAJHHGL != null)
			{
				this.NGOMJAJHHGL();
				return;
			}
			break;
		case (StatusCode)159:
			Debug.Log("ElvisLegsLoop");
			if (this.CCKLLEBFFDK != null)
			{
				this.CCKLLEBFFDK();
				return;
			}
			break;
		default:
			Debug.Log("shop_t3" + ECDGKMBGCMA);
			break;
		}
	}

	// Token: 0x06007837 RID: 30775 RVA: 0x00399FBE File Offset: 0x003981BE
	public void LLAHNMAHNDB()
	{
		this.BEFLOMKOOCH = 0;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		Application.LoadLevel(0);
	}

	// Token: 0x06007838 RID: 30776 RVA: 0x00399FD8 File Offset: 0x003981D8
	public void NCCHIMCBPMM()
	{
		this.BEFLOMKOOCH = 1;
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
		Application.LoadLevel(1);
	}

	// Token: 0x06007839 RID: 30777 RVA: 0x00399FF2 File Offset: 0x003981F2
	public void MMOGALFKAMK()
	{
		this.BEFLOMKOOCH = 0;
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		Application.LoadLevel(0);
	}

	// Token: 0x0600783A RID: 30778 RVA: 0x0039A00C File Offset: 0x0039820C
	public void AKJKNCIKBBF(int ELEMIPMLIGG, string DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600783B RID: 30779 RVA: 0x0039A04C File Offset: 0x0039824C
	public static NJMHLCGIAJI IKGFHGKKCPG
	{
		get
		{
			NJMHLCGIAJI result;
			if ((result = NJMHLCGIAJI.CCHGNBELGIA) == null)
			{
				result = (NJMHLCGIAJI.CCHGNBELGIA = new NJMHLCGIAJI());
			}
			return result;
		}
	}

	// Token: 0x0600783C RID: 30780 RVA: 0x0039A04C File Offset: 0x0039824C
	public static NJMHLCGIAJI EAJGHMMBAFP()
	{
		NJMHLCGIAJI result;
		if ((result = NJMHLCGIAJI.CCHGNBELGIA) == null)
		{
			result = (NJMHLCGIAJI.CCHGNBELGIA = new NJMHLCGIAJI());
		}
		return result;
	}

	// Token: 0x0600783D RID: 30781 RVA: 0x0039A062 File Offset: 0x00398262
	public bool OEMIHLIHKJE()
	{
		return this.NAGMPNCEMAA() == (PeerStateValue)7;
	}

	// Token: 0x0600783E RID: 30782 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FDKNOADPPFC()
	{
	}

	// Token: 0x0600783F RID: 30783 RVA: 0x0039A06D File Offset: 0x0039826D
	public PeerStateValue NAGMPNCEMAA()
	{
		return this.FNGABAODCEC.PeerState;
	}

	// Token: 0x06007840 RID: 30784 RVA: 0x0039A07A File Offset: 0x0039827A
	public void PEIDJOFCLIM()
	{
		this.BEFLOMKOOCH = 0;
		this.FNGABAODCEC.Disconnect();
	}

	// Token: 0x06007841 RID: 30785 RVA: 0x0039A090 File Offset: 0x00398290
	public void GDNKCAOHEPL(int ELEMIPMLIGG, string DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.JJAOGFKMLIE(DNHBPGOKLKD);
			this.EILLJGEHCOH(ELEMIPMLIGG, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x06007842 RID: 30786 RVA: 0x0039A0D0 File Offset: 0x003982D0
	public void HNGEJGHAGJG(int ELEMIPMLIGG, float DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.KHMBNICGPKC(DNHBPGOKLKD);
			this.EILLJGEHCOH(ELEMIPMLIGG, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007843 RID: 30787 RVA: 0x0039A110 File Offset: 0x00398310
	public void ODONNAANIEP()
	{
		Application.runInBackground = true;
		this.FNGABAODCEC = new PhotonPeer(this, ConnectionProtocol.Tcp)
		{
			DisconnectTimeout = 45000,
			CommandBufferSize = 100000,
			ChannelCount = 4
		};
		this.LGFJMPLCGJM = true;
		Debug.Log("---------- NetManager is init");
	}

	// Token: 0x06007844 RID: 30788 RVA: 0x0039A160 File Offset: 0x00398360
	public void MEFFGFHHGMI()
	{
		if (!this.LGFJMPLCGJM)
		{
			return;
		}
		if (this.EKBIOPEDBJI)
		{
			if ((long)Environment.TickCount - this.HLAFFOKCLLJ > 10000L)
			{
				this.AKJKNCIKBBF(255, 0);
				this.HLAFFOKCLLJ = (long)Environment.TickCount;
			}
			this.MODAFLGHBEC = (long)this.FNGABAODCEC.RoundTripTime;
		}
		try
		{
			this.FNGABAODCEC.Service();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06007845 RID: 30789 RVA: 0x0039A1E4 File Offset: 0x003983E4
	public void OGHNHCDABDO(int ELEMIPMLIGG, string DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.HBJIMCCCNJP(DNHBPGOKLKD);
			this.HJPGADJMICM(ELEMIPMLIGG, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
	}

	// Token: 0x06007846 RID: 30790 RVA: 0x0039A224 File Offset: 0x00398424
	public void HMCFNBDNPKA(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH += 0;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				0,
				ELEMIPMLIGG
			},
			{
				6,
				this.BEFLOMKOOCH
			},
			{
				0,
				DNHBPGOKLKD
			}
		};
		this.FNGABAODCEC.OpCustom(1, customOpParameters, true);
	}

	// Token: 0x06007847 RID: 30791 RVA: 0x00022FCC File Offset: 0x000211CC
	public void NADAJMDGNAI()
	{
	}

	// Token: 0x06007848 RID: 30792 RVA: 0x0039A27C File Offset: 0x0039847C
	public void KCONDIDKLIB(int ELEMIPMLIGG, int DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.LAFILAEOPAJ());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
	}

	// Token: 0x06007849 RID: 30793 RVA: 0x0039A07A File Offset: 0x0039827A
	public void NGKANDGCPHO()
	{
		this.BEFLOMKOOCH = 0;
		this.FNGABAODCEC.Disconnect();
	}

	// Token: 0x0600784A RID: 30794 RVA: 0x0039A06D File Offset: 0x0039826D
	public PeerStateValue AIBOOOELDJB()
	{
		return this.FNGABAODCEC.PeerState;
	}

	// Token: 0x0600784B RID: 30795 RVA: 0x0039A2BC File Offset: 0x003984BC
	public void OnOperationResponse(OperationResponse LJMENJDDMBK)
	{
		int num = 0;
		if (LJMENJDDMBK.Parameters.ContainsKey(1))
		{
			num = (int)LJMENJDDMBK.Parameters[1];
		}
		byte[] dnhbpgoklkd = null;
		if (LJMENJDDMBK.Parameters.ContainsKey(3))
		{
			dnhbpgoklkd = (byte[])LJMENJDDMBK.Parameters[3];
		}
		if (num > 0)
		{
			this.IDNBPHBNNBI++;
			if (Time.time - this.EDCFDDLFAHG > 1f)
			{
				this.EEANFBHNMFG = this.IDNBPHBNNBI;
				this.IDNBPHBNNBI = 0;
				this.EDCFDDLFAHG = Time.time;
			}
			EMJAJDNLEJN.IKGFHGKKCPG.FIDCELLHJIH(num, dnhbpgoklkd);
			return;
		}
		Debug.LogError("OnOperationResponse: Unknow Response");
	}

	// Token: 0x0600784C RID: 30796 RVA: 0x0039A368 File Offset: 0x00398568
	public void FDNCHBKDJOG()
	{
		if (!this.LGFJMPLCGJM)
		{
			return;
		}
		if (this.COHHJMOFPFF())
		{
			if ((long)Environment.TickCount - this.HLAFFOKCLLJ > -83L)
			{
				this.PIGIIJLCADJ(-72, 0);
				this.HLAFFOKCLLJ = (long)Environment.TickCount;
			}
			this.MODAFLGHBEC = (long)this.FNGABAODCEC.RoundTripTime;
		}
		try
		{
			this.FNGABAODCEC.Service();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600784D RID: 30797 RVA: 0x0039A3EC File Offset: 0x003985EC
	public void HJJBBPLFAGE()
	{
		if (this.NAAMHEFBMPI.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < 10; i++)
		{
			if (this.NAAMHEFBMPI.Count > 0)
			{
				List<NJMHLCGIAJI.AEABDIKOKKO> naamhefbmpi = this.NAAMHEFBMPI;
				NJMHLCGIAJI.AEABDIKOKKO aeabdikokko;
				lock (naamhefbmpi)
				{
					aeabdikokko = this.NAAMHEFBMPI[0];
					this.NAAMHEFBMPI.RemoveAt(0);
				}
				if (aeabdikokko != null)
				{
					EMJAJDNLEJN.IKGFHGKKCPG.FIDCELLHJIH(aeabdikokko.ELEMIPMLIGG, aeabdikokko.DNHBPGOKLKD);
				}
			}
		}
	}

	// Token: 0x0600784E RID: 30798 RVA: 0x0039A484 File Offset: 0x00398684
	public void AMEOMLNLOGF(int ELEMIPMLIGG, string DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
	}

	// Token: 0x0600784F RID: 30799 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AHOOIIGJCGN()
	{
	}

	// Token: 0x06007851 RID: 30801 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KDDIGJFLABF()
	{
	}

	// Token: 0x06007852 RID: 30802 RVA: 0x0039A4E2 File Offset: 0x003986E2
	public void FDODPFMAEPP()
	{
		if (this.COHHJMOFPFF())
		{
			this.PEIDJOFCLIM();
		}
		Debug.Log("cht_msg2");
	}

	// Token: 0x06007853 RID: 30803 RVA: 0x0039A4FC File Offset: 0x003986FC
	public void IKLPHGOCFPF(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		NJMHLCGIAJI.AEABDIKOKKO item = new NJMHLCGIAJI.AEABDIKOKKO(ELEMIPMLIGG, DNHBPGOKLKD);
		List<NJMHLCGIAJI.AEABDIKOKKO> naamhefbmpi = this.NAAMHEFBMPI;
		lock (naamhefbmpi)
		{
			this.NAAMHEFBMPI.Add(item);
		}
	}

	// Token: 0x06007854 RID: 30804 RVA: 0x0039A54C File Offset: 0x0039874C
	public void EILLJGEHCOH(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH += 0;
		int num = this.BEFLOMKOOCH + ELEMIPMLIGG ^ -120;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				1,
				ELEMIPMLIGG
			},
			{
				2,
				num
			},
			{
				2,
				this.BEFLOMKOOCH
			},
			{
				3,
				DNHBPGOKLKD
			}
		};
		if (this.FNGABAODCEC != null)
		{
			this.FNGABAODCEC.OpCustom(0, customOpParameters, true);
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06007855 RID: 30805 RVA: 0x0039A5C7 File Offset: 0x003987C7
	public bool EKBIOPEDBJI
	{
		get
		{
			return this.DOLBNOLCBOD == PeerStateValue.Connected;
		}
	}

	// Token: 0x06007856 RID: 30806 RVA: 0x0039A5D4 File Offset: 0x003987D4
	public void AKJKNCIKBBF(int ELEMIPMLIGG, long DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007858 RID: 30808 RVA: 0x0039A062 File Offset: 0x00398262
	public bool COHHJMOFPFF()
	{
		return this.NAGMPNCEMAA() == (PeerStateValue)7;
	}

	// Token: 0x06007859 RID: 30809 RVA: 0x0039A620 File Offset: 0x00398820
	public void BNJEMPKFNLA(int ELEMIPMLIGG, string DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x0600785A RID: 30810 RVA: 0x0039A660 File Offset: 0x00398860
	private string CIJHAJPENDM(IEnumerable<byte> DNHBPGOKLKD)
	{
		return DNHBPGOKLKD.Aggregate("", new Func<string, byte, string>(NJMHLCGIAJI.<>c.<>9.FDEPLICLGKP));
	}

	// Token: 0x0600785B RID: 30811 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AGABLNAAFHA()
	{
	}

	// Token: 0x0600785C RID: 30812 RVA: 0x0039A68C File Offset: 0x0039888C
	public void ELGOFHNAEMD()
	{
		Application.runInBackground = false;
		this.FNGABAODCEC = new PhotonPeer(this, ConnectionProtocol.Udp)
		{
			DisconnectTimeout = 67,
			CommandBufferSize = 7,
			ChannelCount = 5
		};
		this.LGFJMPLCGJM = true;
		Debug.Log("Grounded Strafe");
	}

	// Token: 0x0600785D RID: 30813 RVA: 0x0039A6DC File Offset: 0x003988DC
	public void GDEGPEEPKNK()
	{
		Application.runInBackground = true;
		this.FNGABAODCEC = new PhotonPeer(this, ConnectionProtocol.Udp)
		{
			DisconnectTimeout = -151,
			CommandBufferSize = 66,
			ChannelCount = 3
		};
		this.LGFJMPLCGJM = false;
		Debug.Log("Water");
	}

	// Token: 0x0600785E RID: 30814 RVA: 0x0039A72A File Offset: 0x0039892A
	public void BENNDMGLKHL()
	{
		if (this.EKBIOPEDBJI)
		{
			this.NGKANDGCPHO();
		}
		Debug.Log("Server is closed");
	}

	// Token: 0x0600785F RID: 30815 RVA: 0x0039A744 File Offset: 0x00398944
	public void PIGIIJLCADJ(int ELEMIPMLIGG, int DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ENDMKPCFKND(DNHBPGOKLKD);
			this.EILLJGEHCOH(ELEMIPMLIGG, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
	}

	// Token: 0x06007860 RID: 30816 RVA: 0x0039A784 File Offset: 0x00398984
	public void NAPJMPIHGJO(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH++;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				0,
				ELEMIPMLIGG
			},
			{
				2,
				this.BEFLOMKOOCH
			},
			{
				0,
				DNHBPGOKLKD
			}
		};
		this.FNGABAODCEC.OpCustom(0, customOpParameters, false);
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06007861 RID: 30817 RVA: 0x0039A06D File Offset: 0x0039826D
	public PeerStateValue DOLBNOLCBOD
	{
		get
		{
			return this.FNGABAODCEC.PeerState;
		}
	}

	// Token: 0x06007862 RID: 30818 RVA: 0x0039A7DC File Offset: 0x003989DC
	public void LIBMEPHNNDG(int ELEMIPMLIGG, float DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.HHPABLOHFKL(DNHBPGOKLKD);
			this.HJPGADJMICM(ELEMIPMLIGG, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.OGPGOEJFIBO();
		}
	}

	// Token: 0x06007863 RID: 30819 RVA: 0x0039A81C File Offset: 0x00398A1C
	public void JMAGIHOKLOG(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH += 0;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				0,
				ELEMIPMLIGG
			},
			{
				8,
				this.BEFLOMKOOCH
			},
			{
				1,
				DNHBPGOKLKD
			}
		};
		this.FNGABAODCEC.OpCustom(0, customOpParameters, false);
	}

	// Token: 0x06007864 RID: 30820 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KAIHIGICPOA()
	{
	}

	// Token: 0x06007865 RID: 30821 RVA: 0x0039A874 File Offset: 0x00398A74
	public void BCIPEHPEGLN(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		NJMHLCGIAJI.AEABDIKOKKO item = new NJMHLCGIAJI.AEABDIKOKKO(ELEMIPMLIGG, DNHBPGOKLKD);
		List<NJMHLCGIAJI.AEABDIKOKKO> naamhefbmpi = this.NAAMHEFBMPI;
		bool flag = true;
		try
		{
			Monitor.Enter(naamhefbmpi, ref flag);
			this.NAAMHEFBMPI.Add(item);
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(naamhefbmpi);
			}
		}
	}

	// Token: 0x06007866 RID: 30822 RVA: 0x0039A8C4 File Offset: 0x00398AC4
	public void HCKLNONIMNJ(EventData CAKNKPPGGIK)
	{
		int num = 0;
		if (CAKNKPPGGIK.Parameters.ContainsKey(1))
		{
			num = (int)CAKNKPPGGIK.Parameters[0];
		}
		byte[] ecgngbomhdh = null;
		if (CAKNKPPGGIK.Parameters.ContainsKey(3))
		{
			ecgngbomhdh = (byte[])CAKNKPPGGIK.Parameters[1];
		}
		if (num > 0)
		{
			NJMHLCGIAJI.AEABDIKOKKO item = new NJMHLCGIAJI.AEABDIKOKKO(num, ecgngbomhdh);
			if (this.NAAMHEFBMPI.Count > 7 && num == 4)
			{
				return;
			}
			List<NJMHLCGIAJI.AEABDIKOKKO> naamhefbmpi = this.NAAMHEFBMPI;
			lock (naamhefbmpi)
			{
				this.NAAMHEFBMPI.Add(item);
				return;
			}
		}
		Debug.LogError("aukTree");
	}

	// Token: 0x06007867 RID: 30823 RVA: 0x0039A06D File Offset: 0x0039826D
	public PeerStateValue HOPDDBFKOLP()
	{
		return this.FNGABAODCEC.PeerState;
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06007868 RID: 30824 RVA: 0x0039A97C File Offset: 0x00398B7C
	public int EAACIHMOOLG
	{
		get
		{
			if (this.FNGABAODCEC != null)
			{
				return this.FNGABAODCEC.RoundTripTime;
			}
			return 0;
		}
	}

	// Token: 0x06007869 RID: 30825 RVA: 0x0039A994 File Offset: 0x00398B94
	public void AKJKNCIKBBF(int ELEMIPMLIGG, float DNHBPGOKLKD)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.DLAIEEJAFDG(DNHBPGOKLKD);
			this.AKJKNCIKBBF(ELEMIPMLIGG, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600786A RID: 30826 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EHDDCIMHFAP()
	{
	}

	// Token: 0x0600786B RID: 30827 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KOAIIDOHDMJ()
	{
	}

	// Token: 0x0600786C RID: 30828 RVA: 0x0039A9D4 File Offset: 0x00398BD4
	public void FAJDHCPIJLG(int ELEMIPMLIGG, byte[] DNHBPGOKLKD)
	{
		this.BEFLOMKOOCH++;
		Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
		{
			{
				1,
				ELEMIPMLIGG
			},
			{
				2,
				this.BEFLOMKOOCH
			},
			{
				3,
				DNHBPGOKLKD
			}
		};
		this.FNGABAODCEC.OpCustom(1, customOpParameters, false);
	}

	// Token: 0x0600786D RID: 30829 RVA: 0x0039AA2B File Offset: 0x00398C2B
	public void MELHOPAIKOI()
	{
		this.BEFLOMKOOCH = 1;
		this.FNGABAODCEC.Disconnect();
	}

	// Token: 0x0600786E RID: 30830 RVA: 0x0039AA40 File Offset: 0x00398C40
	public void KGJFDBGMNHE()
	{
		if (!this.EKBIOPEDBJI)
		{
			string text = IFPIMPMKJIB.CFGJDNJEBCI + ":" + 9201;
			this.FNGABAODCEC.Connect(text, NJMHLCGIAJI.IFFNJJDMJMB);
			Debug.Log("connect start to " + text + "   " + NJMHLCGIAJI.IFFNJJDMJMB);
			return;
		}
		Debug.Log("connect already used");
	}

	// Token: 0x04001167 RID: 4455
	public const int CIGIMBEFGON = 1;

	// Token: 0x04001168 RID: 4456
	public const int OFOOFCDNONC = 2;

	// Token: 0x04001169 RID: 4457
	public const int JNFEIDBKMAK = 3;

	// Token: 0x0400116A RID: 4458
	public float KJMDCONDKAI = 1f;

	// Token: 0x0400116B RID: 4459
	private const byte JHKIHLABDKM = 1;

	// Token: 0x0400116C RID: 4460
	private const byte LHEPEALBKPO = 2;

	// Token: 0x0400116D RID: 4461
	private const byte PMHKBHMMMAF = 3;

	// Token: 0x0400116E RID: 4462
	private const byte IPPNLCBFNDH = 1;

	// Token: 0x0400116F RID: 4463
	private const byte IAMDLJNEHEN = 2;

	// Token: 0x04001170 RID: 4464
	private const byte DGECGNBMBLN = 3;

	// Token: 0x04001171 RID: 4465
	private const byte IFBHKFPJEFD = 4;

	// Token: 0x04001172 RID: 4466
	private static NJMHLCGIAJI CCHGNBELGIA;

	// Token: 0x04001173 RID: 4467
	public NJMHLCGIAJI.BDOJDFIAGPM NGOMJAJHHGL;

	// Token: 0x04001174 RID: 4468
	public NJMHLCGIAJI.BDOJDFIAGPM CCKLLEBFFDK;

	// Token: 0x04001175 RID: 4469
	public long MODAFLGHBEC;

	// Token: 0x04001176 RID: 4470
	public static string IFFNJJDMJMB = "AFCServer";

	// Token: 0x04001177 RID: 4471
	private bool LGFJMPLCGJM;

	// Token: 0x04001178 RID: 4472
	private PhotonPeer FNGABAODCEC;

	// Token: 0x04001179 RID: 4473
	private int BEFLOMKOOCH;

	// Token: 0x0400117A RID: 4474
	public int EEANFBHNMFG;

	// Token: 0x0400117B RID: 4475
	private int IDNBPHBNNBI;

	// Token: 0x0400117C RID: 4476
	private float EDCFDDLFAHG;

	// Token: 0x0400117D RID: 4477
	public List<NJMHLCGIAJI.AEABDIKOKKO> NAAMHEFBMPI = new List<NJMHLCGIAJI.AEABDIKOKKO>();

	// Token: 0x0400117E RID: 4478
	public const int COEDJILCANM = 177438591;

	// Token: 0x0400117F RID: 4479
	private long HLAFFOKCLLJ;

	// Token: 0x02000206 RID: 518
	public class AEABDIKOKKO
	{
		// Token: 0x0600786F RID: 30831 RVA: 0x0039AAA6 File Offset: 0x00398CA6
		public AEABDIKOKKO(int HCHLOJGINFP, byte[] ECGNGBOMHDH)
		{
			this.ELEMIPMLIGG = HCHLOJGINFP;
			this.DNHBPGOKLKD = ECGNGBOMHDH;
		}

		// Token: 0x04001180 RID: 4480
		public int ELEMIPMLIGG;

		// Token: 0x04001181 RID: 4481
		public byte[] DNHBPGOKLKD;
	}

	// Token: 0x02000207 RID: 519
	// (Invoke) Token: 0x06007871 RID: 30833
	public delegate void BDOJDFIAGPM();
}
