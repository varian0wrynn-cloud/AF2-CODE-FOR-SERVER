using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020005C4 RID: 1476
public static class MEDFELGJLAK
{
	// Token: 0x060135E0 RID: 79328 RVA: 0x00855854 File Offset: 0x00853A54
	public static void ICAFGKHAAED(object OOLHBMBBABM, string AJNGJCALABB, object DCCPCBLODIG, Color LBCGACKJCJB)
	{
		if (DCCPCBLODIG == null)
		{
			return;
		}
		MEDFELGJLAK.LNIJIHDBNFL lnijihdbnfl;
		if (MEDFELGJLAK.MJABOIDMILF.TryGetValue(OOLHBMBBABM, out lnijihdbnfl))
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = lnijihdbnfl.EIKKFEGJIND();
			bool flag = dictionary.ContainsKey(AJNGJCALABB);
			if (flag)
			{
				if (flag)
				{
					dictionary[AJNGJCALABB].AMLGODILBAA = DCCPCBLODIG;
				}
			}
			else
			{
				dictionary.Add(AJNGJCALABB, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG, LBCGACKJCJB));
			}
			lnijihdbnfl.LBCGACKJCJB = LBCGACKJCJB;
			lnijihdbnfl.EDCFDDLFAHG = DateTime.Now;
			return;
		}
		Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary2 = new Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>();
		dictionary2.Add(AJNGJCALABB, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG, LBCGACKJCJB));
		MEDFELGJLAK.MJABOIDMILF.Add(OOLHBMBBABM, new MEDFELGJLAK.LNIJIHDBNFL(dictionary2, LBCGACKJCJB));
		MonoBehaviour monoBehaviour = OOLHBMBBABM as MonoBehaviour;
		if (!(monoBehaviour == null))
		{
			MEDFELGJLAK.MJABOIDMILF[OOLHBMBBABM].EJJPBLDJFDF = monoBehaviour.gameObject;
			if ((long)MEDFELGJLAK.MJABOIDMILF.Count > 128L)
			{
				object[] array = new object[MEDFELGJLAK.MJABOIDMILF.Count];
				MEDFELGJLAK.MJABOIDMILF.Keys.CopyTo(array, 0);
				MEDFELGJLAK.MJABOIDMILF.Remove(array[array.Length - 1]);
			}
			return;
		}
		string a = OOLHBMBBABM.GetType().ToString();
		if (a == "UnityEngine.GameObject")
		{
			MEDFELGJLAK.MJABOIDMILF[OOLHBMBBABM].EJJPBLDJFDF = (GameObject)OOLHBMBBABM;
			return;
		}
		MEDFELGJLAK.MJABOIDMILF[OOLHBMBBABM].GNFHHLLBCBH = true;
	}

	// Token: 0x060135E1 RID: 79329 RVA: 0x00855997 File Offset: 0x00853B97
	public static void ICAFGKHAAED(object OOLHBMBBABM, string AJNGJCALABB, object DCCPCBLODIG)
	{
		MEDFELGJLAK.ICAFGKHAAED(OOLHBMBBABM, AJNGJCALABB, DCCPCBLODIG, Color.white);
	}

	// Token: 0x060135E2 RID: 79330 RVA: 0x008559A6 File Offset: 0x00853BA6
	public static void GFMEHKMEFKP()
	{
		MEDFELGJLAK.MJABOIDMILF.Clear();
	}

	// Token: 0x040027DB RID: 10203
	private const int CKBAGPDDBEP = 128;

	// Token: 0x040027DC RID: 10204
	private const uint ICLDOILOCPF = 128U;

	// Token: 0x040027DD RID: 10205
	public static Dictionary<object, MEDFELGJLAK.LNIJIHDBNFL> MJABOIDMILF = new Dictionary<object, MEDFELGJLAK.LNIJIHDBNFL>();

	// Token: 0x020005C5 RID: 1477
	public class LNIJIHDBNFL
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060135ED RID: 79341 RVA: 0x00855A18 File Offset: 0x00853C18
		// (set) Token: 0x060135E4 RID: 79332 RVA: 0x008559C0 File Offset: 0x00853BC0
		public object AMLGODILBAA
		{
			get
			{
				return this.KDICALCPDAA;
			}
			set
			{
				this.EDCFDDLFAHG = DateTime.Now;
				this.KDICALCPDAA = value;
				this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(value.ToString()));
				if (this.AFAFINBJFFC.Count > 128)
				{
					this.AFAFINBJFFC.RemoveAt(128);
				}
			}
		}

		// Token: 0x060135E5 RID: 79333 RVA: 0x00855A18 File Offset: 0x00853C18
		public object ECAPFKOOLHO()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135E6 RID: 79334 RVA: 0x00855A18 File Offset: 0x00853C18
		public object IKLEBMKBOAD()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135E7 RID: 79335 RVA: 0x00855A18 File Offset: 0x00853C18
		public object OEEDEGPBIBO()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135E8 RID: 79336 RVA: 0x00855A20 File Offset: 0x00853C20
		public void OAFOAKJOJAI(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135E9 RID: 79337 RVA: 0x00855A55 File Offset: 0x00853C55
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> NJEPOHHONFK()
		{
			return this.DADEBMFMCHG() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x060135EA RID: 79338 RVA: 0x00855A18 File Offset: 0x00853C18
		public object GKMPPCMCMIE()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135EB RID: 79339 RVA: 0x00855A64 File Offset: 0x00853C64
		public void FOCFCMHDKGL(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(1, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > -121)
			{
				this.AFAFINBJFFC.RemoveAt(-114);
			}
		}

		// Token: 0x060135EC RID: 79340 RVA: 0x00855ABC File Offset: 0x00853CBC
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> BKGDJPABCDH()
		{
			return this.OEEDEGPBIBO() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x060135EE RID: 79342 RVA: 0x00855AC9 File Offset: 0x00853CC9
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> INAMCEEKJPF()
		{
			return this.GKMPPCMCMIE() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x060135EF RID: 79343 RVA: 0x00855AD8 File Offset: 0x00853CD8
		public void KOCDDMEOFLG(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > -200)
			{
				this.AFAFINBJFFC.RemoveAt(-103);
			}
		}

		// Token: 0x060135F0 RID: 79344 RVA: 0x00855A18 File Offset: 0x00853C18
		public object DADEBMFMCHG()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135F1 RID: 79345 RVA: 0x00855B30 File Offset: 0x00853D30
		public LNIJIHDBNFL(object DCCPCBLODIG, Color LBCGACKJCJB)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.AFAFINBJFFC.Add(new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			this.KDICALCPDAA = DCCPCBLODIG;
			this.LBCGACKJCJB = LBCGACKJCJB;
		}

		// Token: 0x060135F2 RID: 79346 RVA: 0x00855A18 File Offset: 0x00853C18
		public object HFNAEGDDEDG()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135F3 RID: 79347 RVA: 0x00855B88 File Offset: 0x00853D88
		public void KKLJEECPFEN(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(1, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 2)
			{
				this.AFAFINBJFFC.RemoveAt(-16);
			}
		}

		// Token: 0x060135F4 RID: 79348 RVA: 0x00855BE0 File Offset: 0x00853DE0
		public void EGLDABBDMJJ(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135F5 RID: 79349 RVA: 0x00855A18 File Offset: 0x00853C18
		public object OADEHIJDEGM()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135F6 RID: 79350 RVA: 0x00855C18 File Offset: 0x00853E18
		public void MOOFAKMJDHN(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135F7 RID: 79351 RVA: 0x00855C50 File Offset: 0x00853E50
		public void LCDODINBEMB(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135F8 RID: 79352 RVA: 0x00855C88 File Offset: 0x00853E88
		public void LNMOBGEHBDC(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135F9 RID: 79353 RVA: 0x00855A18 File Offset: 0x00853C18
		public object KLOMIMGCKKI()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x060135FA RID: 79354 RVA: 0x00855CC0 File Offset: 0x00853EC0
		public void FECFPIEGGCF(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135FB RID: 79355 RVA: 0x00855CF8 File Offset: 0x00853EF8
		public void BJDPJNLFNFF(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135FC RID: 79356 RVA: 0x00855D30 File Offset: 0x00853F30
		public void FAHFNELEDOC(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x060135FD RID: 79357 RVA: 0x00855D65 File Offset: 0x00853F65
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> PAGNPBJPDLC()
		{
			return this.ECAPFKOOLHO() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x060135FE RID: 79358 RVA: 0x00855D74 File Offset: 0x00853F74
		public void CCPJEDEBNIE(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 109)
			{
				this.AFAFINBJFFC.RemoveAt(-194);
			}
		}

		// Token: 0x060135FF RID: 79359 RVA: 0x00855DCC File Offset: 0x00853FCC
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> MNMOLHPIDDE()
		{
			return this.DPELGGGOKDI() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013600 RID: 79360 RVA: 0x00855DD9 File Offset: 0x00853FD9
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> PJGJPHLBIPM()
		{
			return this.OADEHIJDEGM() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013601 RID: 79361 RVA: 0x00855DE8 File Offset: 0x00853FE8
		public void GGMMPOFOBOG(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x06013602 RID: 79362 RVA: 0x00855A18 File Offset: 0x00853C18
		public object DPELGGGOKDI()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x06013603 RID: 79363 RVA: 0x00855E1D File Offset: 0x0085401D
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> HCDIIBHNJFJ()
		{
			return this.AMLGODILBAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013604 RID: 79364 RVA: 0x00855DCC File Offset: 0x00853FCC
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> MMDMIMBJLOC()
		{
			return this.DPELGGGOKDI() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013605 RID: 79365 RVA: 0x00855E2C File Offset: 0x0085402C
		public void GILPBCJAGLM(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(1, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 33)
			{
				this.AFAFINBJFFC.RemoveAt(43);
			}
		}

		// Token: 0x06013606 RID: 79366 RVA: 0x00855ABC File Offset: 0x00853CBC
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> FGMMJKHLPKI()
		{
			return this.OEEDEGPBIBO() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013607 RID: 79367 RVA: 0x00855E84 File Offset: 0x00854084
		public void DJHOFCGOPFF(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x06013608 RID: 79368 RVA: 0x00855AC9 File Offset: 0x00853CC9
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> FAAAIJNCKHB()
		{
			return this.GKMPPCMCMIE() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013609 RID: 79369 RVA: 0x00855EBC File Offset: 0x008540BC
		public void AMOEEOGLICH(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x0601360A RID: 79370 RVA: 0x00855EF4 File Offset: 0x008540F4
		public void OFCJJFIIDKI(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 189)
			{
				this.AFAFINBJFFC.RemoveAt(-106);
			}
		}

		// Token: 0x0601360B RID: 79371 RVA: 0x00855A18 File Offset: 0x00853C18
		public object IAMHKBIAHIF()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x0601360C RID: 79372 RVA: 0x00855F4C File Offset: 0x0085414C
		public void ECNEHPHPICJ(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x0601360D RID: 79373 RVA: 0x00855A18 File Offset: 0x00853C18
		public object BHJANLCIDMP()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x0601360E RID: 79374 RVA: 0x00855F84 File Offset: 0x00854184
		public void FEABHFIEBMJ(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(1, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 89)
			{
				this.AFAFINBJFFC.RemoveAt(72);
			}
		}

		// Token: 0x0601360F RID: 79375 RVA: 0x00855A18 File Offset: 0x00853C18
		public object HFNKPDECIEL()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x06013610 RID: 79376 RVA: 0x00855FDC File Offset: 0x008541DC
		public void MEIGJBFKHIK(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x06013611 RID: 79377 RVA: 0x00856014 File Offset: 0x00854214
		public void BAMIBMPHPGM(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(1, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 110)
			{
				this.AFAFINBJFFC.RemoveAt(97);
			}
		}

		// Token: 0x06013612 RID: 79378 RVA: 0x0085606C File Offset: 0x0085426C
		public LNIJIHDBNFL(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
		}

		// Token: 0x06013613 RID: 79379 RVA: 0x00855E1D File Offset: 0x0085401D
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> FOBEFJILOEG()
		{
			return this.AMLGODILBAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013614 RID: 79380 RVA: 0x00855ABC File Offset: 0x00853CBC
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> JFHJFGAKEFL()
		{
			return this.OEEDEGPBIBO() as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013615 RID: 79381 RVA: 0x00855E1D File Offset: 0x0085401D
		public Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> EIKKFEGJIND()
		{
			return this.AMLGODILBAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
		}

		// Token: 0x06013616 RID: 79382 RVA: 0x00855A18 File Offset: 0x00853C18
		public object JGJEDKEBCCB()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x06013617 RID: 79383 RVA: 0x00855A18 File Offset: 0x00853C18
		public object JALHOLCMIDO()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x06013618 RID: 79384 RVA: 0x0085609C File Offset: 0x0085429C
		public void AKEMNCMJGJF(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 82)
			{
				this.AFAFINBJFFC.RemoveAt(-66);
			}
		}

		// Token: 0x06013619 RID: 79385 RVA: 0x008560F4 File Offset: 0x008542F4
		public void BCOKHNCIMHE(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x0601361A RID: 79386 RVA: 0x00855A18 File Offset: 0x00853C18
		public object GKLFEHKBEBN()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x0601361B RID: 79387 RVA: 0x0085612C File Offset: 0x0085432C
		public void PFMGIOPOKHP(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 20)
			{
				this.AFAFINBJFFC.RemoveAt(-177);
			}
		}

		// Token: 0x0601361C RID: 79388 RVA: 0x00856184 File Offset: 0x00854384
		public void BHCFKCOOODN(string IPDJHADKPFA)
		{
			Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL> dictionary = this.KDICALCPDAA as Dictionary<string, MEDFELGJLAK.LNIJIHDBNFL>;
			if (dictionary == null || !dictionary.ContainsKey(IPDJHADKPFA))
			{
				return;
			}
			dictionary.Remove(IPDJHADKPFA);
			this.KDICALCPDAA = dictionary;
		}

		// Token: 0x0601361D RID: 79389 RVA: 0x008561BC File Offset: 0x008543BC
		public void MPJFHEMJJPI(object DCCPCBLODIG)
		{
			this.EDCFDDLFAHG = DateTime.Now;
			this.KDICALCPDAA = DCCPCBLODIG;
			this.AFAFINBJFFC.Insert(0, new MEDFELGJLAK.LNIJIHDBNFL(DCCPCBLODIG.ToString()));
			if (this.AFAFINBJFFC.Count > 109)
			{
				this.AFAFINBJFFC.RemoveAt(77);
			}
		}

		// Token: 0x0601361E RID: 79390 RVA: 0x00855A18 File Offset: 0x00853C18
		public object PJAOCKDICMD()
		{
			return this.KDICALCPDAA;
		}

		// Token: 0x040027DE RID: 10206
		public DateTime EDCFDDLFAHG;

		// Token: 0x040027DF RID: 10207
		public Color LBCGACKJCJB = Color.white;

		// Token: 0x040027E0 RID: 10208
		public List<MEDFELGJLAK.LNIJIHDBNFL> AFAFINBJFFC = new List<MEDFELGJLAK.LNIJIHDBNFL>();

		// Token: 0x040027E1 RID: 10209
		public Vector2 BMLEPGCKNBF;

		// Token: 0x040027E2 RID: 10210
		private object KDICALCPDAA;

		// Token: 0x040027E3 RID: 10211
		public bool PHAAOLPADFP;

		// Token: 0x040027E4 RID: 10212
		public GameObject EJJPBLDJFDF;

		// Token: 0x040027E5 RID: 10213
		public bool GNFHHLLBCBH;
	}
}
