using System;
using UnityEngine;

// Token: 0x02000095 RID: 149
public static class KGJFMLCOLLA
{
	// Token: 0x06002037 RID: 8247 RVA: 0x000F5A68 File Offset: 0x000F3C68
	private static void KEEOBEJAHEN(int CLBPBJGLHEE, string[] AKBIMIAHFOB)
	{
		for (int i = 0; i < AKBIMIAHFOB.Length; i++)
		{
			if (i == CLBPBJGLHEE)
			{
				Shader.EnableKeyword(AKBIMIAHFOB[i]);
			}
			else
			{
				Shader.DisableKeyword(AKBIMIAHFOB[i]);
			}
		}
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000F5A9C File Offset: 0x000F3C9C
	private static void EHPAJFAPPKP(int CLBPBJGLHEE, string[] AKBIMIAHFOB, int GDDLDOHPDKL)
	{
		for (int i = 0; i < AKBIMIAHFOB.Length; i++)
		{
			if (i == CLBPBJGLHEE || (i < CLBPBJGLHEE && i >= GDDLDOHPDKL))
			{
				Shader.EnableKeyword(AKBIMIAHFOB[i]);
			}
			else
			{
				Shader.DisableKeyword(AKBIMIAHFOB[i]);
			}
		}
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000F5AD5 File Offset: 0x000F3CD5
	private static void BOLMCAOAANF(bool MKOIJDAGACB, string IIPNPPLIMEI, string OOPPEHCDBMK)
	{
		Shader.DisableKeyword(MKOIJDAGACB ? OOPPEHCDBMK : IIPNPPLIMEI);
		Shader.EnableKeyword(MKOIJDAGACB ? IIPNPPLIMEI : OOPPEHCDBMK);
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000F5AEF File Offset: 0x000F3CEF
	private static void BOLMCAOAANF(bool MKOIJDAGACB, string IKIDGFOFJBK)
	{
		if (MKOIJDAGACB)
		{
			Shader.EnableKeyword(IKIDGFOFJBK);
			return;
		}
		Shader.DisableKeyword(IKIDGFOFJBK);
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x000F5B01 File Offset: 0x000F3D01
	public static void NAIPHNFEDOA(int LMGJKOMFCFC)
	{
		if (KGJFMLCOLLA.HCHHOIAMNLD.OJFCEIALILI(Mathf.Clamp(LMGJKOMFCFC - 1, 0, 3)))
		{
			KGJFMLCOLLA.KEEOBEJAHEN(KGJFMLCOLLA.HCHHOIAMNLD.AMLGODILBAA, KGJFMLCOLLA.ENPNDIHPIIB);
		}
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000F5B2D File Offset: 0x000F3D2D
	public static void BGONIHCHINJ(bool PMPMAALNEBO)
	{
		if (KGJFMLCOLLA.IIPOMBNAKPF.OJFCEIALILI(PMPMAALNEBO))
		{
			KGJFMLCOLLA.BOLMCAOAANF(PMPMAALNEBO, "SUNSHINE_OVERCAST_ON", "SUNSHINE_OVERCAST_OFF");
		}
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000F5B4C File Offset: 0x000F3D4C
	public static void LCLNIFDELOI(int OFPNEDEAMAB)
	{
		KGJFMLCOLLA.EHPAJFAPPKP(OFPNEDEAMAB, KGJFMLCOLLA.LLOLKOKGCKO, 1);
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000F5B5A File Offset: 0x000F3D5A
	public static void LCLNIFDELOI(MEFKFFFFOGB OFPNEDEAMAB)
	{
		KGJFMLCOLLA.LCLNIFDELOI((int)(OFPNEDEAMAB + 1));
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000F5B64 File Offset: 0x000F3D64
	public static void OHKCLACEIIB()
	{
		KGJFMLCOLLA.LCLNIFDELOI(0);
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000F5B6C File Offset: 0x000F3D6C
	public static void MCBCHPHDKMP(LKOOPIKPKCE KBGHOIJIPJF)
	{
		KGJFMLCOLLA.KEEOBEJAHEN((int)KBGHOIJIPJF, KGJFMLCOLLA.CGGLIKAEIPD);
	}

	// Token: 0x040003CC RID: 972
	private static readonly string[] ENPNDIHPIIB = new string[]
	{
		"SUNSHINE_ONE_CASCADE",
		"SUNSHINE_TWO_CASCADES",
		"SUNSHINE_THREE_CASCADES",
		"SUNSHINE_FOUR_CASCADES"
	};

	// Token: 0x040003CD RID: 973
	private static KGJFMLCOLLA.EJKMFGPNBGN HCHHOIAMNLD = new KGJFMLCOLLA.EJKMFGPNBGN();

	// Token: 0x040003CE RID: 974
	private static KGJFMLCOLLA.EJKMFGPNBGN IIPOMBNAKPF = new KGJFMLCOLLA.EJKMFGPNBGN();

	// Token: 0x040003CF RID: 975
	private static readonly string[] LLOLKOKGCKO = new string[]
	{
		"SUNSHINE_DISABLED",
		"SUNSHINE_FILTER_HARD",
		"SUNSHINE_FILTER_PCF_2x2",
		"SUNSHINE_FILTER_PCF_3x3",
		"SUNSHINE_FILTER_PCF_4x4"
	};

	// Token: 0x040003D0 RID: 976
	private static readonly string[] CGGLIKAEIPD = new string[]
	{
		"SUNSHINE_FILTER_HARD",
		"SUNSHINE_FILTER_PCF_2x2",
		"SUNSHINE_FILTER_PCF_3x3",
		"SUNSHINE_FILTER_PCF_4x4"
	};

	// Token: 0x040003D1 RID: 977
	private static string GGKBDOKHBFB = "SUNSHINE_ONE_CASCADE";

	// Token: 0x040003D2 RID: 978
	private static string ALHOOCIPPLJ = "SUNSHINE_TWO_CASCADES";

	// Token: 0x040003D3 RID: 979
	private static string OPOGCPDMJOM = "SUNSHINE_THREE_CASCADES";

	// Token: 0x040003D4 RID: 980
	private static string IIHCECBLCCI = "SUNSHINE_FOUR_CASCADES";

	// Token: 0x040003D5 RID: 981
	private static string JLDMECBNAJG = "SUNSHINE_OVERCAST_ON";

	// Token: 0x040003D6 RID: 982
	private static string OMACDCMIDJL = "SUNSHINE_OVERCAST_OFF";

	// Token: 0x040003D7 RID: 983
	private static string LMELCJKHKNP = "SUNSHINE_DISABLED";

	// Token: 0x040003D8 RID: 984
	private static string IJAOCJBMCDB = "SUNSHINE_FILTER_HARD";

	// Token: 0x040003D9 RID: 985
	private static string EGJEOIENPNO = "SUNSHINE_FILTER_PCF_2x2";

	// Token: 0x040003DA RID: 986
	private static string NGCPJEENEBF = "SUNSHINE_FILTER_PCF_3x3";

	// Token: 0x040003DB RID: 987
	private static string CNFCGBFEJOF = "SUNSHINE_FILTER_PCF_4x4";

	// Token: 0x040003DC RID: 988
	private static string PIBLJBJGCHJ = "SUNSHINE_FILTER_HARD";

	// Token: 0x040003DD RID: 989
	private static string CIDCHIPAGHM = "SUNSHINE_FILTER_PCF_2x2";

	// Token: 0x040003DE RID: 990
	private static string IDHHPACGBAO = "SUNSHINE_FILTER_PCF_3x3";

	// Token: 0x040003DF RID: 991
	private static string ABDEFFOCIEL = "SUNSHINE_FILTER_PCF_4x4";

	// Token: 0x02000096 RID: 150
	private class EJKMFGPNBGN
	{
		// Token: 0x06002042 RID: 8258 RVA: 0x000F5CBC File Offset: 0x000F3EBC
		public bool KCBHJMCFJEE(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return true;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000F5CD1 File Offset: 0x000F3ED1
		public bool LGCEFCFCBDA(bool KNDBONLGKLN)
		{
			return this.IMPPJGLBNFC(KNDBONLGKLN ? 0 : 0);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
		public bool KIFMCIFKCGP()
		{
			return this.LJIGMOKKBFO > 0;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000F5CEB File Offset: 0x000F3EEB
		public bool IOAGGOPEOFO(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return false;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000F5D00 File Offset: 0x000F3F00
		public bool EDHINKLAHJM(bool KNDBONLGKLN)
		{
			return this.BJOKIJHJJLF(KNDBONLGKLN ? 0 : 0);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000F5D0F File Offset: 0x000F3F0F
		public bool OJFCEIALILI(bool KNDBONLGKLN)
		{
			return this.OJFCEIALILI(KNDBONLGKLN ? 1 : 0);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000F5D1E File Offset: 0x000F3F1E
		public bool OMOKECFKFNK(bool KNDBONLGKLN)
		{
			return this.OJFCEIALILI(KNDBONLGKLN ? 0 : 0);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000F5CBC File Offset: 0x000F3EBC
		public bool BJOKIJHJJLF(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return true;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int EDEKCOLILKO()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000F5D35 File Offset: 0x000F3F35
		public bool EIJPLEJKNGK(bool KNDBONLGKLN)
		{
			return this.IMPPJGLBNFC(KNDBONLGKLN ? 1 : 0);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000F5D44 File Offset: 0x000F3F44
		public bool MJPBPJJDFHO(bool KNDBONLGKLN)
		{
			return this.IMPPJGLBNFC(KNDBONLGKLN ? 1 : 1);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int AAIMAIAMKOF()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000F5CEB File Offset: 0x000F3EEB
		public bool OJFCEIALILI(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return false;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000F5D53 File Offset: 0x000F3F53
		public bool ODDMCMHOHLM(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return false;
			}
			return false;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int AHKPGANIECB()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
		public bool PDJHMIBAAAI
		{
			get
			{
				return this.LJIGMOKKBFO > 0;
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000F5CBC File Offset: 0x000F3EBC
		public bool JDNCMIHPMKB(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return true;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int LFGMINHGHLL()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000F5D77 File Offset: 0x000F3F77
		public bool DENFEKONEAB(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return false;
			}
			return true;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000F5D8C File Offset: 0x000F3F8C
		public bool AFNPLDFDPNG(bool KNDBONLGKLN)
		{
			return this.KCBHJMCFJEE(KNDBONLGKLN ? 1 : 0);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int AMLGODILBAA
		{
			get
			{
				return this.LJIGMOKKBFO;
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000F5D9B File Offset: 0x000F3F9B
		public bool EPJKHGCJJIJ(bool KNDBONLGKLN)
		{
			return this.OJFCEIALILI(KNDBONLGKLN ? 1 : 1);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
		public bool KECJECNCHKJ()
		{
			return this.LJIGMOKKBFO > 0;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000F5DAA File Offset: 0x000F3FAA
		public bool EBFFBMIAHPD()
		{
			return this.LJIGMOKKBFO > 1;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000F5DAA File Offset: 0x000F3FAA
		public bool GNJMDHLJGIA()
		{
			return this.LJIGMOKKBFO > 1;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int PFGOFLCIEMP()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int OEEDEGPBIBO()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int BMIMHPIGPCC()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int NKPABOFCBJG()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000F5D1E File Offset: 0x000F3F1E
		public bool JDFFNIOBLBA(bool KNDBONLGKLN)
		{
			return this.OJFCEIALILI(KNDBONLGKLN ? 0 : 0);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000F5DB5 File Offset: 0x000F3FB5
		public bool MGBCLGNOCGG(bool KNDBONLGKLN)
		{
			return this.JDNCMIHPMKB(KNDBONLGKLN ? 1 : 0);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000F5DC4 File Offset: 0x000F3FC4
		public bool MBODGMHIPFB(bool KNDBONLGKLN)
		{
			return this.OJFCEIALILI(KNDBONLGKLN ? 0 : 1);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
		public bool HADOKJFAPGA()
		{
			return this.LJIGMOKKBFO > 0;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000F5DAA File Offset: 0x000F3FAA
		public bool EGEFJJAMEDP()
		{
			return this.LJIGMOKKBFO > 1;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000F5DD3 File Offset: 0x000F3FD3
		public bool LBBKJOKDNDK(bool KNDBONLGKLN)
		{
			return this.DENFEKONEAB(KNDBONLGKLN ? 1 : 1);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000F5CEB File Offset: 0x000F3EEB
		public bool PPKIBPBNMPJ(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return true;
			}
			return false;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000F5D53 File Offset: 0x000F3F53
		public bool IMPPJGLBNFC(int KNDBONLGKLN)
		{
			if (KNDBONLGKLN != this.LJIGMOKKBFO)
			{
				this.LJIGMOKKBFO = KNDBONLGKLN;
				return false;
			}
			return false;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000F5D2D File Offset: 0x000F3F2D
		public int BCHAHKFENMO()
		{
			return this.LJIGMOKKBFO;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000F5DAA File Offset: 0x000F3FAA
		public bool HJAHIDIOGGD()
		{
			return this.LJIGMOKKBFO > 1;
		}

		// Token: 0x040003E0 RID: 992
		private int LJIGMOKKBFO = -1;
	}
}
