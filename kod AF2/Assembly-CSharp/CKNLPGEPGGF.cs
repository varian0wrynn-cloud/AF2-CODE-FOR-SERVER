using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x020001FC RID: 508
public class CKNLPGEPGGF
{
	// Token: 0x0600765E RID: 30302 RVA: 0x00388E86 File Offset: 0x00387086
	public void GFPOJNDPMLC(int LFFGPHDLPME, CKNLPGEPGGF.FADFMDIHCIN DKBOLOGKEFJ)
	{
		this.PPMAFOGDGAK(string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Textures/Weapons/",
			LFFGPHDLPME,
			".png"
		}), DKBOLOGKEFJ, false);
	}

	// Token: 0x0600765F RID: 30303 RVA: 0x00388EBC File Offset: 0x003870BC
	public void MOPEECLGJIL()
	{
		if (this.NFAGILFBGFJ == null)
		{
			this.NFAGILFBGFJ = this.PFNEPENHMOE(IFPIMPMKJIB.BKKFFINMJBO() + "FlyDown", true);
		}
	}

	// Token: 0x06007660 RID: 30304 RVA: 0x00388EE2 File Offset: 0x003870E2
	public void CDNCEIKGCDN()
	{
		if (this.NFAGILFBGFJ == null)
		{
			this.NFAGILFBGFJ = this.IJMDNINDJGD(IFPIMPMKJIB.LIOPCJFCGAF() + "IdleReadyCrouch", false);
		}
	}

	// Token: 0x06007661 RID: 30305 RVA: 0x00388F08 File Offset: 0x00387108
	public CKNLPGEPGGF.IAPCJOBDCEH PFNEPENHMOE(string ALBOCLBFNNI, bool FCANGILPDHG = false)
	{
		if (this.IPCJPKKHBMN.ContainsKey(ALBOCLBFNNI))
		{
			return this.IPCJPKKHBMN[ALBOCLBFNNI];
		}
		CKNLPGEPGGF.IAPCJOBDCEH iapcjobdceh = new CKNLPGEPGGF.IAPCJOBDCEH
		{
			ALBOCLBFNNI = ALBOCLBFNNI
		};
		iapcjobdceh.OECLFHEEHEG = FilterMode.Point;
		iapcjobdceh.FCANGILPDHG = FCANGILPDHG;
		this.IPCJPKKHBMN.Add(ALBOCLBFNNI, iapcjobdceh);
		CKNLPGEPGGF.BGIIKMBCJGM(iapcjobdceh);
		return iapcjobdceh;
	}

	// Token: 0x06007662 RID: 30306 RVA: 0x00388F60 File Offset: 0x00387160
	public CKNLPGEPGGF.IAPCJOBDCEH EKHFCNKNHEJ(string ALBOCLBFNNI, bool FCANGILPDHG = false)
	{
		if (this.IPCJPKKHBMN.ContainsKey(ALBOCLBFNNI))
		{
			return this.IPCJPKKHBMN[ALBOCLBFNNI];
		}
		CKNLPGEPGGF.IAPCJOBDCEH iapcjobdceh = new CKNLPGEPGGF.IAPCJOBDCEH
		{
			ALBOCLBFNNI = ALBOCLBFNNI
		};
		iapcjobdceh.OECLFHEEHEG = FilterMode.Bilinear;
		iapcjobdceh.FCANGILPDHG = FCANGILPDHG;
		this.IPCJPKKHBMN.Add(ALBOCLBFNNI, iapcjobdceh);
		CKNLPGEPGGF.HIBADBMCFBJ(iapcjobdceh);
		return iapcjobdceh;
	}

	// Token: 0x06007664 RID: 30308 RVA: 0x00388FCA File Offset: 0x003871CA
	public bool GNDHDKPBAFJ(string IGGDHDCPAPK)
	{
		return File.Exists(IGGDHDCPAPK.Substring(7));
	}

	// Token: 0x06007665 RID: 30309 RVA: 0x00388FE0 File Offset: 0x003871E0
	public void MEIFJCHFGHO(string ALBOCLBFNNI, CKNLPGEPGGF.FADFMDIHCIN DKBOLOGKEFJ, bool IEBBODAKPMF = false)
	{
		CKNLPGEPGGF.IAPCJOBDCEH iapcjobdceh;
		if (this.IPCJPKKHBMN.ContainsKey(ALBOCLBFNNI))
		{
			iapcjobdceh = this.IPCJPKKHBMN[ALBOCLBFNNI];
		}
		else
		{
			iapcjobdceh = new CKNLPGEPGGF.IAPCJOBDCEH
			{
				ALBOCLBFNNI = ALBOCLBFNNI
			};
			this.IPCJPKKHBMN.Add(ALBOCLBFNNI, iapcjobdceh);
		}
		if (iapcjobdceh == null)
		{
			return;
		}
		if (DKBOLOGKEFJ != null)
		{
			iapcjobdceh.IBJPIBBOBEP(DKBOLOGKEFJ);
		}
		if (iapcjobdceh.OINDOLGBLOC)
		{
			iapcjobdceh.JNFNCLMDLKA();
			return;
		}
		if (IEBBODAKPMF)
		{
			iapcjobdceh.OECLFHEEHEG = FilterMode.Bilinear;
		}
		CKNLPGEPGGF.HIBADBMCFBJ(iapcjobdceh);
	}

	// Token: 0x06007666 RID: 30310 RVA: 0x00389051 File Offset: 0x00387251
	public static CKNLPGEPGGF PFOLNEGNIPP()
	{
		if (CKNLPGEPGGF.CCHGNBELGIA == null)
		{
			CKNLPGEPGGF.CCHGNBELGIA = new CKNLPGEPGGF();
			CKNLPGEPGGF.CCHGNBELGIA.PINLMCCKKNA();
		}
		return CKNLPGEPGGF.CCHGNBELGIA;
	}

	// Token: 0x06007667 RID: 30311 RVA: 0x00389073 File Offset: 0x00387273
	public Texture FLDLBIHLNKM()
	{
		return this.NFAGILFBGFJ.PFFJJEJNKPB();
	}

	// Token: 0x06007668 RID: 30312 RVA: 0x00389080 File Offset: 0x00387280
	private static void BGIIKMBCJGM(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = NOFCHOFPHAD.ALBOCLBFNNI;
		gameObject.AddComponent<TextureLoader>().MKLABJOONHH(NOFCHOFPHAD);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}

	// Token: 0x06007669 RID: 30313 RVA: 0x003890A4 File Offset: 0x003872A4
	private static void IEGKLKKEADN(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = NOFCHOFPHAD.ALBOCLBFNNI;
		gameObject.AddComponent<TextureLoader>().NOOHBCIHLKG(NOFCHOFPHAD);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}

	// Token: 0x0600766A RID: 30314 RVA: 0x003890C8 File Offset: 0x003872C8
	public void PINLMCCKKNA()
	{
		if (this.NFAGILFBGFJ == null)
		{
			this.NFAGILFBGFJ = this.EKHFCNKNHEJ(IFPIMPMKJIB.DIDFMAELMJD + "Textures/NoImage.png", false);
		}
	}

	// Token: 0x0600766B RID: 30315 RVA: 0x003890EE File Offset: 0x003872EE
	public void IHOFGFGLNBM(int LFFGPHDLPME, CKNLPGEPGGF.FADFMDIHCIN DKBOLOGKEFJ)
	{
		object[] array = new object[6];
		array[0] = IFPIMPMKJIB.EHCJCCILAHM();
		array[1] = "basePar";
		array[7] = LFFGPHDLPME;
		array[2] = "string: ";
		this.PPMAFOGDGAK(string.Concat(array), DKBOLOGKEFJ, true);
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x0600766C RID: 30316 RVA: 0x00389051 File Offset: 0x00387251
	public static CKNLPGEPGGF IKGFHGKKCPG
	{
		get
		{
			if (CKNLPGEPGGF.CCHGNBELGIA == null)
			{
				CKNLPGEPGGF.CCHGNBELGIA = new CKNLPGEPGGF();
				CKNLPGEPGGF.CCHGNBELGIA.PINLMCCKKNA();
			}
			return CKNLPGEPGGF.CCHGNBELGIA;
		}
	}

	// Token: 0x0600766D RID: 30317 RVA: 0x00389124 File Offset: 0x00387324
	public void PPMAFOGDGAK(string ALBOCLBFNNI, CKNLPGEPGGF.FADFMDIHCIN DKBOLOGKEFJ, bool IEBBODAKPMF = false)
	{
		CKNLPGEPGGF.IAPCJOBDCEH iapcjobdceh;
		if (this.IPCJPKKHBMN.ContainsKey(ALBOCLBFNNI))
		{
			iapcjobdceh = this.IPCJPKKHBMN[ALBOCLBFNNI];
		}
		else
		{
			iapcjobdceh = new CKNLPGEPGGF.IAPCJOBDCEH
			{
				ALBOCLBFNNI = ALBOCLBFNNI
			};
			this.IPCJPKKHBMN.Add(ALBOCLBFNNI, iapcjobdceh);
		}
		if (iapcjobdceh == null)
		{
			return;
		}
		if (DKBOLOGKEFJ != null)
		{
			iapcjobdceh.CAPONNNBHMD(DKBOLOGKEFJ);
		}
		if (iapcjobdceh.OINDOLGBLOC)
		{
			iapcjobdceh.IALKJFLJBCP();
			return;
		}
		if (IEBBODAKPMF)
		{
			iapcjobdceh.OECLFHEEHEG = FilterMode.Bilinear;
		}
		CKNLPGEPGGF.HIBADBMCFBJ(iapcjobdceh);
	}

	// Token: 0x0600766E RID: 30318 RVA: 0x00389195 File Offset: 0x00387395
	public Texture FPMCLKLBEPB()
	{
		return this.NFAGILFBGFJ.KEDGAOBCNJG;
	}

	// Token: 0x0600766F RID: 30319 RVA: 0x003891A2 File Offset: 0x003873A2
	private static void HIBADBMCFBJ(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = NOFCHOFPHAD.ALBOCLBFNNI;
		gameObject.AddComponent<TextureLoader>().load(NOFCHOFPHAD);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}

	// Token: 0x06007670 RID: 30320 RVA: 0x003891C6 File Offset: 0x003873C6
	public void FKKFALIBPCF(int LFFGPHDLPME, CKNLPGEPGGF.FADFMDIHCIN DKBOLOGKEFJ)
	{
		object[] array = new object[7];
		array[0] = IFPIMPMKJIB.EHCJCCILAHM();
		array[0] = "knopje.wav";
		array[0] = LFFGPHDLPME;
		array[8] = "innerPerk";
		this.PPMAFOGDGAK(string.Concat(array), DKBOLOGKEFJ, true);
	}

	// Token: 0x06007671 RID: 30321 RVA: 0x003891FC File Offset: 0x003873FC
	public CKNLPGEPGGF.IAPCJOBDCEH IJMDNINDJGD(string ALBOCLBFNNI, bool FCANGILPDHG = false)
	{
		if (this.IPCJPKKHBMN.ContainsKey(ALBOCLBFNNI))
		{
			return this.IPCJPKKHBMN[ALBOCLBFNNI];
		}
		CKNLPGEPGGF.IAPCJOBDCEH iapcjobdceh = new CKNLPGEPGGF.IAPCJOBDCEH
		{
			ALBOCLBFNNI = ALBOCLBFNNI
		};
		iapcjobdceh.OECLFHEEHEG = FilterMode.Point;
		iapcjobdceh.FCANGILPDHG = FCANGILPDHG;
		this.IPCJPKKHBMN.Add(ALBOCLBFNNI, iapcjobdceh);
		CKNLPGEPGGF.IEGKLKKEADN(iapcjobdceh);
		return iapcjobdceh;
	}

	// Token: 0x0400110F RID: 4367
	private CKNLPGEPGGF.IAPCJOBDCEH NFAGILFBGFJ;

	// Token: 0x04001110 RID: 4368
	private readonly Dictionary<string, CKNLPGEPGGF.IAPCJOBDCEH> IPCJPKKHBMN = new Dictionary<string, CKNLPGEPGGF.IAPCJOBDCEH>();

	// Token: 0x04001111 RID: 4369
	private static CKNLPGEPGGF CCHGNBELGIA;

	// Token: 0x020001FD RID: 509
	public class IAPCJOBDCEH
	{
		// Token: 0x06007672 RID: 30322 RVA: 0x00389253 File Offset: 0x00387453
		public void OAEBJKJHLBE()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x0038926E File Offset: 0x0038746E
		public void HPKEOGGNOLI(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00389278 File Offset: 0x00387478
		public void KLIEACHBONI()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x003892D4 File Offset: 0x003874D4
		public Texture2D EJOLKDKEKCG()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.ANLLGCICOPP();
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x0038926E File Offset: 0x0038746E
		public void EAJJDFOIAFB(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x0038926E File Offset: 0x0038746E
		public void LCKNHFIDNOO(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00389253 File Offset: 0x00387453
		public void DLFKJBILIMN()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00389304 File Offset: 0x00387504
		public Texture2D ANLLGCICOPP()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.IOMNHBMOGLG();
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00389334 File Offset: 0x00387534
		public void CLGGECBGNHN(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00389350 File Offset: 0x00387550
		public void EDIOFJIFBFB()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x003893AC File Offset: 0x003875AC
		public Texture2D EIMNFFAAHLI()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.DPBCBCLJHAJ();
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00389334 File Offset: 0x00387534
		public void CAPONNNBHMD(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x003893DC File Offset: 0x003875DC
		public void EBIIBBHKAAK()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00389438 File Offset: 0x00387638
		public Texture2D MLPBJEFJDHM()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.EJOLKDKEKCG();
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00389468 File Offset: 0x00387668
		public void NDHKCMCNMFO()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00389334 File Offset: 0x00387534
		public void LGEOGOEKDLB(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00389334 File Offset: 0x00387534
		public void IBJPIBBOBEP(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x003894C4 File Offset: 0x003876C4
		public Texture2D IOHNCGLFGDJ()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.MLPBJEFJDHM();
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x003894F4 File Offset: 0x003876F4
		public void IALKJFLJBCP()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00389550 File Offset: 0x00387750
		public Texture2D NIOGJOFLPLH()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.MLPBJEFJDHM();
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00389334 File Offset: 0x00387534
		public void AKILHCDGCPI(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x0038926E File Offset: 0x0038746E
		public void PLPLJBHPFEJ(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00389580 File Offset: 0x00387780
		public void PGJIHBMIEOP()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x0038926E File Offset: 0x0038746E
		public void KGNLGCFPMGI(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x0038926E File Offset: 0x0038746E
		public void DLFFEODJFAK(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00389253 File Offset: 0x00387453
		public void AOAKIFHOMJA()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x003895DC File Offset: 0x003877DC
		public void FBCJONKDLDC()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00389253 File Offset: 0x00387453
		public void NLDDNMCENAO()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00389638 File Offset: 0x00387838
		public Texture2D MMKLLFCKCAG()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.LECMGDEDAKF();
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00389253 File Offset: 0x00387453
		public void AEMDIAEBHNB()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00389253 File Offset: 0x00387453
		public void DNECHFMMLBJ()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00389668 File Offset: 0x00387868
		public Texture2D IOMNHBMOGLG()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.NIOGJOFLPLH();
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x0038926E File Offset: 0x0038746E
		public void LHICMCNHKOF(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00389253 File Offset: 0x00387453
		public void PBFFHGOEKEO()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00389334 File Offset: 0x00387534
		public void KOJLMCIBPNJ(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00389334 File Offset: 0x00387534
		public void FDCBBFPCBEO(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00389698 File Offset: 0x00387898
		public IAPCJOBDCEH(Texture NAGPDILILNL, string ILKLJFIPHCA)
		{
			this.OINDOLGBLOC = true;
			this.PMJIHPFGCGJ = false;
			this.ALBOCLBFNNI = ILKLJFIPHCA;
			this.JEPLCKDCJKI = (Texture2D)NAGPDILILNL;
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x0038926E File Offset: 0x0038746E
		public void ENHNACOJIAF(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00389334 File Offset: 0x00387534
		public void PCLBBOGHIDA(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x003894C4 File Offset: 0x003876C4
		public Texture2D AEIIBNOFLCM()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.MLPBJEFJDHM();
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x0038926E File Offset: 0x0038746E
		public void KLIDCDLNLFE(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x003896E9 File Offset: 0x003878E9
		public Texture2D OABDBIAHOJH()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.EJOLKDKEKCG();
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00389334 File Offset: 0x00387534
		public void NNJKPNLMEGB(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x0038971C File Offset: 0x0038791C
		public void FHMMOMPDCNL()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00389253 File Offset: 0x00387453
		public void LAOAGIMKKHB()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00389253 File Offset: 0x00387453
		public void NLJBFPFLDDJ()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00389253 File Offset: 0x00387453
		public void IINFCENJHLM()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00389253 File Offset: 0x00387453
		public void KKNIAKCLBJJ()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00389334 File Offset: 0x00387534
		public void JPPKHNFLNAN(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00389334 File Offset: 0x00387534
		public void HLJLBHCDPBG(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00389778 File Offset: 0x00387978
		public Texture2D PFFJJEJNKPB()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.OABDBIAHOJH();
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00389253 File Offset: 0x00387453
		public void NFIKKHIKCKB()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x003897A8 File Offset: 0x003879A8
		public void ONCLONDJKGC()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00389804 File Offset: 0x00387A04
		public Texture2D HFNHCIGCOBE()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.DPBCBCLJHAJ();
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x0038926E File Offset: 0x0038746E
		public void BMBPCLONCNB(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060076A9 RID: 30377 RVA: 0x00389834 File Offset: 0x00387A34
		// (set) Token: 0x060076BA RID: 30394 RVA: 0x0038926E File Offset: 0x0038746E
		public Texture2D KEDGAOBCNJG
		{
			get
			{
				if (!(this.JEPLCKDCJKI == null))
				{
					return this.JEPLCKDCJKI;
				}
				if (this.FCANGILPDHG)
				{
					return null;
				}
				return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.KEDGAOBCNJG;
			}
			set
			{
				this.JEPLCKDCJKI = value;
			}
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00389864 File Offset: 0x00387A64
		public void OJFNGJKLOGM()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00389253 File Offset: 0x00387453
		public void PGNIDKOBKBC()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x003898C0 File Offset: 0x00387AC0
		public void JHOMNOPGPIL()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x0038991C File Offset: 0x00387B1C
		public Texture2D DPBCBCLJHAJ()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.OABDBIAHOJH();
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00389438 File Offset: 0x00387638
		public Texture2D LECMGDEDAKF()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.PFOLNEGNIPP().NFAGILFBGFJ.EJOLKDKEKCG();
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x0038994C File Offset: 0x00387B4C
		public IAPCJOBDCEH()
		{
			this.OINDOLGBLOC = false;
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00389253 File Offset: 0x00387453
		public void OHMODDNJLBH()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00389334 File Offset: 0x00387534
		public void PDGEHHPNABC(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00389978 File Offset: 0x00387B78
		public void CMBHNGAAAEE()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x0038926E File Offset: 0x0038746E
		public void OINBALKPJNK(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x003899D4 File Offset: 0x00387BD4
		public Texture2D HONJOFFBOPH()
		{
			if (!(this.JEPLCKDCJKI == null))
			{
				return this.JEPLCKDCJKI;
			}
			if (this.FCANGILPDHG)
			{
				return null;
			}
			return CKNLPGEPGGF.IKGFHGKKCPG.NFAGILFBGFJ.IOHNCGLFGDJ();
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00389253 File Offset: 0x00387453
		public void PEFNFPNLHIA()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00389A04 File Offset: 0x00387C04
		public void MHFLMGOIBBA()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00389A60 File Offset: 0x00387C60
		public void IICGEOOFMKL()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00389ABC File Offset: 0x00387CBC
		public void MPLNOLEPEJC()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00389253 File Offset: 0x00387453
		public void KMBHBDJNHMM()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x0038926E File Offset: 0x0038746E
		public void INBHJKABJGA(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x0038926E File Offset: 0x0038746E
		public void GNLNCICNPKO(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00389B18 File Offset: 0x00387D18
		public void LEMNPOFGDGC()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00389334 File Offset: 0x00387534
		public void KIFOOJGKCBD(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x0038926E File Offset: 0x0038746E
		public void ENKFBKALLHI(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00389334 File Offset: 0x00387534
		public void KCOLADPJEDE(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00389253 File Offset: 0x00387453
		public void PAKKNDPOEPL()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x0038926E File Offset: 0x0038746E
		public void OHOIHPDPPMF(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00389334 File Offset: 0x00387534
		public void OMCCMOAPFPN(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x0038926E File Offset: 0x0038746E
		public void KNDBMJJDCHP(Texture2D DCCPCBLODIG)
		{
			this.JEPLCKDCJKI = DCCPCBLODIG;
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00389334 File Offset: 0x00387534
		public void BEGJKDBEOIB(CKNLPGEPGGF.FADFMDIHCIN MCPJBOAKCMK)
		{
			if (!this.EHNIOFHLMDB.Contains(MCPJBOAKCMK))
			{
				this.EHNIOFHLMDB.Add(MCPJBOAKCMK);
			}
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00389B74 File Offset: 0x00387D74
		public void JNFNCLMDLKA()
		{
			foreach (CKNLPGEPGGF.FADFMDIHCIN fadfmdihcin in this.EHNIOFHLMDB)
			{
				fadfmdihcin(this);
			}
			this.EHNIOFHLMDB.Clear();
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00389253 File Offset: 0x00387453
		public void MDAPMEPFOOH()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00389253 File Offset: 0x00387453
		public void JJKEBJMHOLO()
		{
			if (this.JEPLCKDCJKI != null)
			{
				UnityEngine.Object.Destroy(this.JEPLCKDCJKI);
			}
		}

		// Token: 0x04001112 RID: 4370
		public bool FCANGILPDHG;

		// Token: 0x04001113 RID: 4371
		public bool OINDOLGBLOC;

		// Token: 0x04001114 RID: 4372
		public bool PMJIHPFGCGJ;

		// Token: 0x04001115 RID: 4373
		public string ALBOCLBFNNI = "";

		// Token: 0x04001116 RID: 4374
		private Texture2D JEPLCKDCJKI;

		// Token: 0x04001117 RID: 4375
		public int DMOLCIMJGCB;

		// Token: 0x04001118 RID: 4376
		public FilterMode OECLFHEEHEG = FilterMode.Trilinear;

		// Token: 0x04001119 RID: 4377
		private readonly List<CKNLPGEPGGF.FADFMDIHCIN> EHNIOFHLMDB = new List<CKNLPGEPGGF.FADFMDIHCIN>();
	}

	// Token: 0x020001FE RID: 510
	// (Invoke) Token: 0x060076CA RID: 30410
	public delegate void FADFMDIHCIN(CKNLPGEPGGF.IAPCJOBDCEH ONPHLHKAGFP);
}
