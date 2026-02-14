using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using UnityEngine;

// Token: 0x02000222 RID: 546
public class FBFJFAKAGJG
{
	// Token: 0x06007E07 RID: 32263 RVA: 0x003C9B4A File Offset: 0x003C7D4A
	private static string NMBJFBCFDLC(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.DIDFMAELMJD + "Sound/" + HGGLNBKFHKK;
	}

	// Token: 0x06007E08 RID: 32264 RVA: 0x003C9B5C File Offset: 0x003C7D5C
	public void GIKFMCFHIDJ()
	{
		Debug.Log("wgt_med.dat" + Time.time);
		this.KGPNFABIFLB = "Yawn";
		FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().EFGDDAPIKBH(this.AEGJCIEDFHH.Count)];
		if (this.NNFHPMLCDBO != null && this.AEGJCIEDFHH.Count > 1)
		{
			while (fmhackmbdhg.KCOHPPPOIKC == this.NNFHPMLCDBO.KCOHPPPOIKC)
			{
				fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().JKGCGMKDAHH(this.AEGJCIEDFHH.Count)];
			}
		}
		this.NNFHPMLCDBO = fmhackmbdhg;
		this.MCEEAPOKANB(this.NNFHPMLCDBO.KCOHPPPOIKC, true);
		this.KGPMJIGELMJ(this.NNFHPMLCDBO);
	}

	// Token: 0x06007E09 RID: 32265 RVA: 0x003C9C24 File Offset: 0x003C7E24
	public void NDOICBDIIHB(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[4];
		array[0] = "RunBackLeft";
		array[0] = HMHOKNOOAOK;
		array[5] = "types";
		array[1] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.GOOPKBAKJEN();
		object[] array2 = new object[]
		{
			null,
			"BlendMaterial"
		};
		array2[1] = HMHOKNOOAOK;
		array2[2] = "auc_toauk";
		array2[3] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("_WaveScale4" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 1334f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.ENLHJOJICDG() + "Soccer Pass Heavy" + HMHOKNOOAOK;
		this.OBENMEPCDJF.COAKPNHPOBL(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E0A RID: 32266 RVA: 0x003C9D4C File Offset: 0x003C7F4C
	public void KMDHOHJFJJP()
	{
		this.FGJONLGJOAB(this.FOBGBALNFAF, true);
	}

	// Token: 0x06007E0B RID: 32267 RVA: 0x003C9D5C File Offset: 0x003C7F5C
	public void LOCMIHKMGNL()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("Actor_" + Time.time);
			this.OBENMEPCDJF.CLGGLMMICHE();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = " R ";
		}
	}

	// Token: 0x06007E0C RID: 32268 RVA: 0x003C9DAD File Offset: 0x003C7FAD
	private static string NPBJPFDDNPG(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.DIDFMAELMJD + "gi_nl2" + HGGLNBKFHKK;
	}

	// Token: 0x06007E0D RID: 32269 RVA: 0x003C9DC0 File Offset: 0x003C7FC0
	public BNOOIOKIFJC.DIGGOHPGCNN HEMGAMNINNA(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.JLMPPDBIDKI));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("<b>ObscuredString:</b> " + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("knopje.wav");
	}

	// Token: 0x06007E0E RID: 32270 RVA: 0x003C9E70 File Offset: 0x003C8070
	public void PLKKECPNMEB(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.HKBNODJBGEL();
		if (Time.time - this.ICGDJMOAEFH < 1048f)
		{
			return;
		}
		int num = 0 + OLPINJLCKCI.ODDOIHEPICE().MKOPHEAGIGE(8);
		string pecjfjhkgma = string.Format("wpn_add/use_effect/effect", num);
		this.BJIPPOCFFOK(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 124f, 318f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E0F RID: 32271 RVA: 0x003C9EE0 File Offset: 0x003C80E0
	public void EBDBHKHOPMB(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject(" " + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 553f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 748f);
	}

	// Token: 0x06007E10 RID: 32272 RVA: 0x003C9F7C File Offset: 0x003C817C
	public void FKLPONGNPID(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[]
		{
			null,
			" ♦ "
		};
		array[1] = HMHOKNOOAOK;
		array[0] = "run";
		array[0] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.NDJJCEBAEEP();
		object[] array2 = new object[]
		{
			null,
			"\\StreamingAssets\\Quest\\Lang\\"
		};
		array2[0] = HMHOKNOOAOK;
		array2[3] = "RunBackward";
		array2[0] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("Ошибка!" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 1781f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.BKKFFINMJBO() + "" + HMHOKNOOAOK;
		this.OBENMEPCDJF.DLOPKNAOHFN(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E11 RID: 32273 RVA: 0x003CA0A4 File Offset: 0x003C82A4
	public BNOOIOKIFJC.DIGGOHPGCNN BCGLJCIABFN(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.HGEJNFCBEEM));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("BowInstant" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("OneHandSwordRun");
	}

	// Token: 0x06007E12 RID: 32274 RVA: 0x003CA154 File Offset: 0x003C8354
	private static string MAPNJFFAEBO(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.ACOEIDGDLJC() + "iPoint" + HGGLNBKFHKK;
	}

	// Token: 0x06007E13 RID: 32275 RVA: 0x003CA168 File Offset: 0x003C8368
	public void JHJHHBLGMPJ(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("/" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.CustomRolloff, GuiProcessor.NKOEAPCIBKO().soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1435f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 660f);
	}

	// Token: 0x06007E14 RID: 32276 RVA: 0x003CA204 File Offset: 0x003C8404
	public void AHBODLKJNJP(string PECJFJHKGMA, Vector3 MGALEAJOGPL, float KBBHHMILEOC = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f)
	{
		string text = FBFJFAKAGJG.DCJGBBJECKD(PECJFJHKGMA);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.HFGAHFGKFKL(this.JKCFOMLDOHK[text], MGALEAJOGPL, KBBHHMILEOC, FNADKBPAGJH, DAILMANBNMM, 261f);
			return;
		}
		GameObject gameObject = new GameObject("</color>" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.spatialBlend = 1661f;
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.volume = KBBHHMILEOC;
		audioSource.maxDistance = DAILMANBNMM;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.HBBIFAFAHBI(text, false);
	}

	// Token: 0x06007E15 RID: 32277 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void GJLOGFIFCJE(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E16 RID: 32278 RVA: 0x003CA2C8 File Offset: 0x003C84C8
	public void CLKIIAKCBHO(int PNEDPPPEFFG)
	{
		object[] array = new object[5];
		array[1] = "GiantGrabIdle2";
		array[1] = PNEDPPPEFFG;
		array[2] = "and 'Result' are the same.";
		array[3] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.OIKCOFFEEKE != PNEDPPPEFFG)
		{
			this.NNFHPMLCDBO = this.AEGJCIEDFHH[OLPINJLCKCI.IFLFANPMLMM().MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
			this.HGDPLFMPPNP(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
			this.ENDNIEOEOAH(this.NNFHPMLCDBO);
			this.OIKCOFFEEKE = PNEDPPPEFFG;
		}
	}

	// Token: 0x06007E17 RID: 32279 RVA: 0x003CA35F File Offset: 0x003C855F
	public void ONJGHDHEFFH()
	{
		this.KCEIHPKGGOL(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x003CA370 File Offset: 0x003C8570
	public void NAKCJBKPNFO(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "default";
		}
		string pecjfjhkgma = "StepSound/Other/step1.ogg";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.MCOLCPGIFFN(pecjfjhkgma, MGALEAJOGPL, 0.1f, 1f, 10f);
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x003CA3C0 File Offset: 0x003C85C0
	public void PFJBPLCIMNH(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "No MeshFilter!";
		}
		string pecjfjhkgma = "lut.ogg";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.AHBODLKJNJP(pecjfjhkgma, MGALEAJOGPL, 643f, 1754f, 232f);
	}

	// Token: 0x06007E1A RID: 32282 RVA: 0x003CA40F File Offset: 0x003C860F
	public void HNOPGCGOMCA()
	{
		this.EHPBCCJHGDE(this.FOBGBALNFAF, false);
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x003CA420 File Offset: 0x003C8620
	public void KIOACCJHKNN(int PNEDPPPEFFG)
	{
		object[] array = new object[0];
		array[0] = "Hidden/Amplify Color/BlendCache";
		array[1] = PNEDPPPEFFG;
		array[8] = "DealerIdle";
		array[3] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.OIKCOFFEEKE != PNEDPPPEFFG)
		{
			this.NNFHPMLCDBO = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().MIPEBCJCHNJ(this.AEGJCIEDFHH.Count)];
			this.HGDPLFMPPNP(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
			this.HJJBBFIGNCK(this.NNFHPMLCDBO);
			this.OIKCOFFEEKE = PNEDPPPEFFG;
		}
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void NCCKBLIDAAF(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void BABAHBDKAKD(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E1E RID: 32286 RVA: 0x003CA4D4 File Offset: 0x003C86D4
	public void ECFFFJLCEPE()
	{
		this.MCEEAPOKANB(this.FOBGBALNFAF, true);
	}

	// Token: 0x06007E1F RID: 32287 RVA: 0x003CA4E3 File Offset: 0x003C86E3
	public void FHIEJJNBBIJ()
	{
		this.IECKEPNIBIH(this.FOBGBALNFAF, false);
	}

	// Token: 0x06007E20 RID: 32288 RVA: 0x003CA4F4 File Offset: 0x003C86F4
	public void BKGHEBPEMLM(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("BackPackGrab" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 672f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 526f);
	}

	// Token: 0x06007E21 RID: 32289 RVA: 0x003CA590 File Offset: 0x003C8790
	public BNOOIOKIFJC.DIGGOHPGCNN HOGFBCFJAPC(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.BJLKIOKFNOA));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("chan_head");
	}

	// Token: 0x06007E22 RID: 32290 RVA: 0x003CA640 File Offset: 0x003C8840
	public void MCOLCPGIFFN(string PECJFJHKGMA, Vector3 MGALEAJOGPL, float KBBHHMILEOC = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f)
	{
		string text = FBFJFAKAGJG.NMBJFBCFDLC(PECJFJHKGMA);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.AKDOFKCANPE(this.JKCFOMLDOHK[text], MGALEAJOGPL, KBBHHMILEOC, FNADKBPAGJH, DAILMANBNMM, 1f);
			return;
		}
		GameObject gameObject = new GameObject("#url Sound " + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.spatialBlend = 1f;
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.volume = KBBHHMILEOC;
		audioSource.maxDistance = DAILMANBNMM;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.LoadAndPlay(text, true);
	}

	// Token: 0x06007E23 RID: 32291 RVA: 0x003CA6DC File Offset: 0x003C88DC
	public void GOOPKBAKJEN()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("RollerBladeBackFlip" + Time.time);
			this.OBENMEPCDJF.CHCJFIEDGBG();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "";
		}
	}

	// Token: 0x06007E24 RID: 32292 RVA: 0x003CA730 File Offset: 0x003C8930
	public void JHOELIEBBEE(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("wgt=" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.CustomRolloff, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1349f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 1705f);
	}

	// Token: 0x06007E25 RID: 32293 RVA: 0x003CA7CC File Offset: 0x003C89CC
	public BNOOIOKIFJC.DIGGOHPGCNN NFBNODENFCD(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.BJLKIOKFNOA));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("Textures/NoImage.png" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("IdleSpew");
	}

	// Token: 0x06007E26 RID: 32294 RVA: 0x003CA87C File Offset: 0x003C8A7C
	public BNOOIOKIFJC.DIGGOHPGCNN FAPAMPKDGLJ(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.LJMEACIIBPJ));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("_RgbBlendCacheTex" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("CrouchStrafeLeft");
	}

	// Token: 0x06007E27 RID: 32295 RVA: 0x003CA92C File Offset: 0x003C8B2C
	public void CFJGMNPFLAA()
	{
		this.KCEIHPKGGOL(this.FOBGBALNFAF, true);
	}

	// Token: 0x06007E28 RID: 32296 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void DLHAJLHHDPE(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E29 RID: 32297 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void GPMGFJIBIBP(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E2A RID: 32298 RVA: 0x003CA93C File Offset: 0x003C8B3C
	public void HOPBEEOPABL()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("Open turnStatus" + Time.time);
			this.OBENMEPCDJF.CLAMMDFHMOI();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "Handstand";
		}
	}

	// Token: 0x06007E2B RID: 32299 RVA: 0x003CA990 File Offset: 0x003C8B90
	public void BEEHMHJNHCN(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[3];
		array[0] = "Hand";
		array[1] = HMHOKNOOAOK;
		array[3] = "";
		array[8] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.HMPCKDLGHCF();
		object[] array2 = new object[]
		{
			"CUSTOM_COLOR_ON"
		};
		array2[0] = HMHOKNOOAOK;
		array2[8] = "Cloth_01.wav";
		array2[8] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("IceHockey Goalie Save 2" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 750f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.EEAKGGDJAGB() + "act_order" + HMHOKNOOAOK;
		this.OBENMEPCDJF.ENIBOHAOKNF(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E2C RID: 32300 RVA: 0x003CAAB8 File Offset: 0x003C8CB8
	public void CFMFFHMGDPP(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 0 + OLPINJLCKCI.ODDOIHEPICE().MKOPHEAGIGE(4);
		if (BBOODPCDKAJ > 2)
		{
			BBOODPCDKAJ = 6;
		}
		string text = "{0}";
		if (BBOODPCDKAJ == 0)
		{
			text = "head" + num;
		}
		if (BBOODPCDKAJ == 1)
		{
			text = "SoccerKeeperReady" + num;
		}
		if (BBOODPCDKAJ == 2)
		{
			text = "1HandSwordChargeSwipe" + num;
		}
		text += "IK Effector is referencing to a bone '";
		this.CGEKMDKCDGP(text, NHCLMBOINFG, 536f, 1622f, 528f);
	}

	// Token: 0x06007E2D RID: 32301 RVA: 0x003CAB44 File Offset: 0x003C8D44
	public void HJJBBFIGNCK(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1073f)
		{
			string iabkgmnjljo = string.Format("IceHockeyGoalieSave2", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.MMIEPJKOHNI(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E2E RID: 32302 RVA: 0x003CAB94 File Offset: 0x003C8D94
	public void CJBIOCEDDCG(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 737f)
		{
			string iabkgmnjljo = string.Format("_FadeDistance", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.ELFAEBJJNPM(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E2F RID: 32303 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void JEBDFDJJHKL(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E30 RID: 32304 RVA: 0x003CABE4 File Offset: 0x003C8DE4
	public BNOOIOKIFJC.DIGGOHPGCNN BBLEPPMMPIL(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.BBJKDMMPCGM));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("val=" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("val=");
	}

	// Token: 0x06007E31 RID: 32305 RVA: 0x003CAC94 File Offset: 0x003C8E94
	public void AJEIKIOHFOJ()
	{
		this.NDOICBDIIHB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E32 RID: 32306 RVA: 0x003CACA4 File Offset: 0x003C8EA4
	public void JBNPDPNADEE(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1801f)
		{
			string iabkgmnjljo = string.Format("002000", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.ELOOCKFEMAH(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E33 RID: 32307 RVA: 0x003CACF3 File Offset: 0x003C8EF3
	private static string DCJGBBJECKD(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.ENLHJOJICDG() + " is null." + HGGLNBKFHKK;
	}

	// Token: 0x06007E34 RID: 32308 RVA: 0x003CAD05 File Offset: 0x003C8F05
	public void HJKDHBLEDMC()
	{
		this.BEEHMHJNHCN(this.FOBGBALNFAF, false);
	}

	// Token: 0x06007E35 RID: 32309 RVA: 0x003CAD14 File Offset: 0x003C8F14
	public void LOAGNOGBOAN()
	{
		this.FGJONLGJOAB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E36 RID: 32310 RVA: 0x003CAD24 File Offset: 0x003C8F24
	public void KCEIHPKGGOL(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[5];
		array[0] = "_ALPHABLEND_ON";
		array[1] = HMHOKNOOAOK;
		array[7] = "WorkerPickaxe";
		array[6] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.NHCEMEHKBMM();
		object[] array2 = new object[4];
		array2[0] = "TYPES";
		array2[0] = HMHOKNOOAOK;
		array2[7] = "http://af-2.ru/?q=store";
		array2[1] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("_Angle" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 1026f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.EEAKGGDJAGB() + "name" + HMHOKNOOAOK;
		this.OBENMEPCDJF.MMKOJGPMGIE(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E37 RID: 32311 RVA: 0x003CAE4C File Offset: 0x003C904C
	public void IECKEPNIBIH(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[2];
		array[0] = " : ";
		array[0] = HMHOKNOOAOK;
		array[6] = "error.wav";
		array[4] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.HOPBEEOPABL();
		object[] array2 = new object[]
		{
			"cht_msg34",
			HMHOKNOOAOK,
			null,
			null,
			null,
			null,
			null,
			"isMove"
		};
		array2[4] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("offsets" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 627f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.DIDFMAELMJD + "" + HMHOKNOOAOK;
		this.OBENMEPCDJF.MFLPEIKNAPF(alboclbfnni, NMFPOEHHFOI, true);
	}

	// Token: 0x06007E38 RID: 32312 RVA: 0x003CAF74 File Offset: 0x003C9174
	public BNOOIOKIFJC.DIGGOHPGCNN ILBCOBKMIPC(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.BGNDKIDEDFG));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("cntx_razb" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("Flap_02.wav");
	}

	// Token: 0x06007E39 RID: 32313 RVA: 0x003CB024 File Offset: 0x003C9224
	public void OPLJOEMHEPG(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("Sound " + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 0.2f);
	}

	// Token: 0x06007E3A RID: 32314 RVA: 0x003CB09C File Offset: 0x003C929C
	public void HJICBDFHNOO(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.OPEOECGJJJF(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.NILJMALGHBJ(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("Shadow name=" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.GEHLHOFFAAJ(text, true);
	}

	// Token: 0x06007E3B RID: 32315 RVA: 0x003CB124 File Offset: 0x003C9324
	public void LLABHALMBDG(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.CDBIEPGNONF();
		if (Time.time - this.ICGDJMOAEFH < 1010f)
		{
			return;
		}
		int num = 0 + OLPINJLCKCI.BMALMDIBLDP().HJJBGOAGLKG(2);
		string pecjfjhkgma = string.Format("\n", num);
		this.MCOLCPGIFFN(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 697f, 903f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E3C RID: 32316 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void KPMAKFJBMLP(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E3D RID: 32317 RVA: 0x003CB194 File Offset: 0x003C9394
	public void BJIPPOCFFOK(string PECJFJHKGMA, Vector3 MGALEAJOGPL, float KBBHHMILEOC = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f)
	{
		string text = FBFJFAKAGJG.DCJGBBJECKD(PECJFJHKGMA);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.AKDOFKCANPE(this.JKCFOMLDOHK[text], MGALEAJOGPL, KBBHHMILEOC, FNADKBPAGJH, DAILMANBNMM, 22f);
			return;
		}
		GameObject gameObject = new GameObject("Root Node bone is null. FBBIK will not initiate." + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.spatialBlend = 736f;
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.volume = KBBHHMILEOC;
		audioSource.maxDistance = DAILMANBNMM;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.PALMAMLNIAD(text, true);
	}

	// Token: 0x06007E3E RID: 32318 RVA: 0x003CB230 File Offset: 0x003C9430
	public void IMNNEDBALAB(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("RunBackRight" + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 495f);
	}

	// Token: 0x06007E3F RID: 32319 RVA: 0x003CB2A8 File Offset: 0x003C94A8
	public void KBEMKOJJIKM(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "Window";
		}
		string pecjfjhkgma = " гр ";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.MCOLCPGIFFN(pecjfjhkgma, MGALEAJOGPL, 1317f, 388f, 1303f);
	}

	// Token: 0x06007E40 RID: 32320 RVA: 0x003CB2F8 File Offset: 0x003C94F8
	public void FGJONLGJOAB(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		Debug.Log(string.Concat(new object[]
		{
			"****************  playMusic 1=",
			HMHOKNOOAOK,
			" ",
			Time.time
		}));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.HMPCKDLGHCF();
		Debug.Log(string.Concat(new object[]
		{
			"****************  playMusic 2=",
			HMHOKNOOAOK,
			" ",
			Time.time
		}));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("#url Sound " + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 0f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.DIDFMAELMJD + "Sound/Music/" + HMHOKNOOAOK;
		this.OBENMEPCDJF.StreamPlay(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E42 RID: 32322 RVA: 0x003CB42C File Offset: 0x003C962C
	public void AGJHPNKLJFO(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1275f)
		{
			string iabkgmnjljo = string.Format("SneakIdle", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.IFKOCMOHJEN(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E43 RID: 32323 RVA: 0x003CB47B File Offset: 0x003C967B
	private static string NBHDJOCIIHL(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.NEJIPLDOMMC() + "Lasso" + HGGLNBKFHKK;
	}

	// Token: 0x06007E44 RID: 32324 RVA: 0x003CB490 File Offset: 0x003C9690
	public void LMGDONLPHBJ(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.MAPNJFFAEBO(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.DMPNAMJAOKN(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("error" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.BMGGPFBJNIN(text, true);
	}

	// Token: 0x06007E45 RID: 32325 RVA: 0x003CB518 File Offset: 0x003C9718
	public void HLEKCHCMPKP(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1342f)
		{
			string iabkgmnjljo = string.Format("id", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.MMIEPJKOHNI(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E46 RID: 32326 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void JHEPDHDKPHF(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E47 RID: 32327 RVA: 0x003CB568 File Offset: 0x003C9768
	public void AJFODOCHBNH(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.OGJHINOLHJJ;
		if (Time.time - this.ICGDJMOAEFH < 1990f)
		{
			return;
		}
		int num = 1 + OLPINJLCKCI.NLOGJHEFMHM().MIPEBCJCHNJ(7);
		string pecjfjhkgma = string.Format("VA", num);
		this.CGEKMDKCDGP(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 1934f, 1709f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E48 RID: 32328 RVA: 0x003CB5D8 File Offset: 0x003C97D8
	public void DMPNAMJAOKN(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("StrafeRunRight" + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 1663f);
	}

	// Token: 0x06007E49 RID: 32329 RVA: 0x003CB650 File Offset: 0x003C9850
	public void EAMFNIKDBBD(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 0 + OLPINJLCKCI.OBDBAABBAKB().MIPEBCJCHNJ(7);
		if (BBOODPCDKAJ > 3)
		{
			BBOODPCDKAJ = 8;
		}
		string text = "__a";
		if (BBOODPCDKAJ == 0)
		{
			text = "VIGNETTE_BLUR" + num;
		}
		if (BBOODPCDKAJ == 1)
		{
			text = ", " + num;
		}
		if (BBOODPCDKAJ == 0)
		{
			text = "OneHandSwordBackSwing" + num;
		}
		text += "RHandPunch";
		this.CGEKMDKCDGP(text, NHCLMBOINFG, 417f, 92f, 1439f);
	}

	// Token: 0x06007E4A RID: 32330 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void OAMAMGMENAK(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E4B RID: 32331 RVA: 0x003CB6DC File Offset: 0x003C98DC
	public void JDBBAHDOJOM()
	{
		Debug.Log("gamma" + Time.time);
		this.KGPNFABIFLB = "OfficeSitting";
		FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NLOGJHEFMHM().MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
		if (this.NNFHPMLCDBO != null && this.AEGJCIEDFHH.Count > 0)
		{
			while (fmhackmbdhg.KCOHPPPOIKC == this.NNFHPMLCDBO.KCOHPPPOIKC)
			{
				fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().FCEGAKPPDCA(this.AEGJCIEDFHH.Count)];
			}
		}
		this.NNFHPMLCDBO = fmhackmbdhg;
		this.FKLPONGNPID(this.NNFHPMLCDBO.KCOHPPPOIKC, true);
		this.HJJBBFIGNCK(this.NNFHPMLCDBO);
	}

	// Token: 0x06007E4C RID: 32332 RVA: 0x003CB7A4 File Offset: 0x003C99A4
	public void HGDPLFMPPNP(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[0];
		array[1] = "Idle Monster";
		array[1] = HMHOKNOOAOK;
		array[8] = "SuicideHeadShot";
		array[7] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.GOOPKBAKJEN();
		object[] array2 = new object[7];
		array2[1] = "28";
		array2[1] = HMHOKNOOAOK;
		array2[8] = "WeaponReadyFire";
		array2[8] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("firsStartMovePanel" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 1196f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.BKKFFINMJBO() + "StaffStand" + HMHOKNOOAOK;
		this.OBENMEPCDJF.GIFOPMIHFAP(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E4D RID: 32333 RVA: 0x003CB8CC File Offset: 0x003C9ACC
	public void OLHNOHJAFJD()
	{
		this.FGJONLGJOAB(this.FOBGBALNFAF, false);
	}

	// Token: 0x06007E4E RID: 32334 RVA: 0x003CB8DC File Offset: 0x003C9ADC
	public void NIJMPDCHEBP(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 382f)
		{
			string iabkgmnjljo = string.Format("Music: ", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.OPCBJJGFCHH(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E4F RID: 32335 RVA: 0x003CB92C File Offset: 0x003C9B2C
	public void IAIFBJJHLOA(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.OPEOECGJJJF(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.IMNNEDBALAB(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("Soccer Start Kick" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.HBDBJNEEBMJ(text, false);
	}

	// Token: 0x06007E50 RID: 32336 RVA: 0x003CB9B4 File Offset: 0x003C9BB4
	public void HMPCKDLGHCF()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("****************  stopMusic " + Time.time);
			this.OBENMEPCDJF.mute();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "";
		}
	}

	// Token: 0x06007E51 RID: 32337 RVA: 0x003CBA08 File Offset: 0x003C9C08
	public void IELJIOLPPGE(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "template";
		}
		string pecjfjhkgma = "DealerIdle";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.AHBODLKJNJP(pecjfjhkgma, MGALEAJOGPL, 1876f, 1252f, 888f);
	}

	// Token: 0x06007E52 RID: 32338 RVA: 0x003CBA58 File Offset: 0x003C9C58
	public void HKKKCIAJPAC(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("MotorbikeBackwardSittingCheer" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.NKOEAPCIBKO().soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1285f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 427f);
	}

	// Token: 0x06007E53 RID: 32339 RVA: 0x003CBAF4 File Offset: 0x003C9CF4
	public void EMFOCGGAKEG(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 1 + OLPINJLCKCI.ODDOIHEPICE().MKOPHEAGIGE(5);
		if (BBOODPCDKAJ > 2)
		{
			BBOODPCDKAJ = 7;
		}
		string text = "_BlurRadius4";
		if (BBOODPCDKAJ == 0)
		{
			text = "languageid" + num;
		}
		if (BBOODPCDKAJ == 0)
		{
			text = "MENU.WAV" + num;
		}
		if (BBOODPCDKAJ == 1)
		{
			text = "GAMMA" + num;
		}
		text += "WallRunLeft";
		this.MCOLCPGIFFN(text, NHCLMBOINFG, 113f, 140f, 881f);
	}

	// Token: 0x06007E54 RID: 32340 RVA: 0x003CBB80 File Offset: 0x003C9D80
	public void KMOGGCNEKPB(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.DJGFCFKEMFM(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.MKDDNDEJOEE(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("WorkerHammer" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.PJIBOIGKLHL(text, true);
	}

	// Token: 0x06007E55 RID: 32341 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void IJCHKHKJCNO(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E56 RID: 32342 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void MPKJKBLJEOE(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E57 RID: 32343 RVA: 0x003CBC08 File Offset: 0x003C9E08
	public void NBMHEPNPHFP(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("16" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 755f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 580f);
	}

	// Token: 0x06007E58 RID: 32344 RVA: 0x003CBCA4 File Offset: 0x003C9EA4
	public void KAIGLDBAFEE(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "\n";
		}
		string pecjfjhkgma = "craft_data/categories/category";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.MCOLCPGIFFN(pecjfjhkgma, MGALEAJOGPL, 1150f, 1836f, 674f);
	}

	// Token: 0x06007E59 RID: 32345 RVA: 0x003CBCF4 File Offset: 0x003C9EF4
	public void DECDAIIICFJ(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "Mouse Y";
		}
		string pecjfjhkgma = "_Curve";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.CGEKMDKCDGP(pecjfjhkgma, MGALEAJOGPL, 1445f, 1357f, 137f);
	}

	// Token: 0x06007E5A RID: 32346 RVA: 0x003CBD44 File Offset: 0x003C9F44
	public void MLFGLEOKDFB(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("start load " + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 1514f);
	}

	// Token: 0x06007E5B RID: 32347 RVA: 0x003CBDBC File Offset: 0x003C9FBC
	public void IFMNFEIKLPM(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1063f)
		{
			string iabkgmnjljo = string.Format("Depth textures aren't supported on this device ({0})", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.NCBDDIPLBIN(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E5C RID: 32348 RVA: 0x003CBE0C File Offset: 0x003CA00C
	public void JGOEIANIJFL(int PNEDPPPEFFG)
	{
		Debug.Log(string.Concat(new object[]
		{
			"****************  playMusicBase ",
			PNEDPPPEFFG,
			" tm=",
			Time.time
		}));
		if (this.OIKCOFFEEKE != PNEDPPPEFFG)
		{
			this.NNFHPMLCDBO = this.AEGJCIEDFHH[OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
			this.FGJONLGJOAB(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
			this.CFHAIJGNJMA(this.NNFHPMLCDBO);
			this.OIKCOFFEEKE = PNEDPPPEFFG;
		}
	}

	// Token: 0x06007E5D RID: 32349 RVA: 0x003CBEA4 File Offset: 0x003CA0A4
	public void AIJHMBOALID(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "WateringCanWatering";
		}
		string pecjfjhkgma = "Bone ";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.MCOLCPGIFFN(pecjfjhkgma, MGALEAJOGPL, 391f, 841f, 536f);
	}

	// Token: 0x06007E5E RID: 32350 RVA: 0x003CBEF4 File Offset: 0x003CA0F4
	public void DIHKGFJGMBE(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.NPBJPFDDNPG(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.OPLJOEMHEPG(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("cntx_drop" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.IDKAJMCCDHN(text, true);
	}

	// Token: 0x06007E5F RID: 32351 RVA: 0x003CBF7C File Offset: 0x003CA17C
	public void PIDIGHGJBJD(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 0 + OLPINJLCKCI.ODDOIHEPICE().MKOPHEAGIGE(8);
		if (BBOODPCDKAJ > 8)
		{
			BBOODPCDKAJ = 4;
		}
		string text = "_MaxCoC";
		if (BBOODPCDKAJ == 0)
		{
			text = "" + num;
		}
		if (BBOODPCDKAJ == 0)
		{
			text = "_LerpAmount" + num;
		}
		if (BBOODPCDKAJ == 2)
		{
			text = "206000" + num;
		}
		text += "Roar";
		this.AHBODLKJNJP(text, NHCLMBOINFG, 76f, 183f, 1445f);
	}

	// Token: 0x06007E60 RID: 32352 RVA: 0x003CC008 File Offset: 0x003CA208
	public void MKDDNDEJOEE(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("SkateForward" + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 1466f);
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x003CC080 File Offset: 0x003CA280
	public void IEBJDIENKNB(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 476f)
		{
			string iabkgmnjljo = string.Format("TextureLoaderCoroutine", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.ELFAEBJJNPM(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E62 RID: 32354 RVA: 0x003CC0D0 File Offset: 0x003CA2D0
	public void CGEKMDKCDGP(string PECJFJHKGMA, Vector3 MGALEAJOGPL, float KBBHHMILEOC = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f)
	{
		string text = FBFJFAKAGJG.GACPOOMDMFP(PECJFJHKGMA);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.NBMHEPNPHFP(this.JKCFOMLDOHK[text], MGALEAJOGPL, KBBHHMILEOC, FNADKBPAGJH, DAILMANBNMM, 68f);
			return;
		}
		GameObject gameObject = new GameObject("WorkerHammer" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.spatialBlend = 220f;
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.volume = KBBHHMILEOC;
		audioSource.maxDistance = DAILMANBNMM;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.IIEPKFBCAGC(text, true);
	}

	// Token: 0x06007E63 RID: 32355 RVA: 0x003CAC94 File Offset: 0x003C8E94
	public void JIOAMAPJOFA()
	{
		this.NDOICBDIIHB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E64 RID: 32356 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void EJJPNKHLEGJ(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E65 RID: 32357 RVA: 0x003CC16C File Offset: 0x003CA36C
	public void NELGPHMIGNC(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1945f)
		{
			string iabkgmnjljo = string.Format("Visit docs to see where PlayerPrefs are stored", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.addRightMessageColored(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E66 RID: 32358 RVA: 0x003CC1BC File Offset: 0x003CA3BC
	public void EHPBCCJHGDE(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[4];
		array[1] = "WaveSpeed";
		array[0] = HMHOKNOOAOK;
		array[4] = "<color='#80ffff'>";
		array[5] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.NHCEMEHKBMM();
		object[] array2 = new object[]
		{
			null,
			"> "
		};
		array2[1] = HMHOKNOOAOK;
		array2[2] = "Kernel";
		array2[5] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("_MainTex" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 171f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.ACOEIDGDLJC() + "\n" + HMHOKNOOAOK;
		this.OBENMEPCDJF.ECNLMCDGMJD(alboclbfnni, NMFPOEHHFOI, true);
	}

	// Token: 0x06007E67 RID: 32359 RVA: 0x003CC2E4 File Offset: 0x003CA4E4
	public void NILJMALGHBJ(AudioClip DNIBJBLMPGF, float EBILPJNBGLK = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("ObscuredInt vs int, " + DNIBJBLMPGF.name);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.volume = EBILPJNBGLK;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 1557f);
	}

	// Token: 0x06007E68 RID: 32360 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void MDBKEPOGMBL(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E69 RID: 32361 RVA: 0x003CC35C File Offset: 0x003CA55C
	public FBFJFAKAGJG()
	{
		this.PHHBMKIBCOB = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("SoundData", typeof(TextAsset));
		this.PHHBMKIBCOB.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = this.PHHBMKIBCOB.SelectNodes("sound/steps/step");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					string value = xmlNode.Attributes["tag"].Value;
					string value2 = xmlNode.Attributes["path"].Value;
					this.PDIPIJEPIKC.Add(value, value2);
				}
			}
		}
		Debug.Log("SoundMgr is init part 1");
		string path = Application.streamingAssetsPath + "/Sound/Music/MusicList.xml";
		int num = 0;
		this.PHHBMKIBCOB = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		this.PHHBMKIBCOB.LoadXml(xml);
		xmlNodeList = this.PHHBMKIBCOB.SelectNodes("sound/allmusic/music");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode2 = (XmlNode)obj2;
				if (xmlNode2.Attributes != null)
				{
					FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = new FBFJFAKAGJG.FMHACKMBDHG(xmlNode2);
					num++;
					fmhackmbdhg.LPFKFNLHGBI = num;
					this.AEGJCIEDFHH.Add(fmhackmbdhg);
				}
			}
		}
		this.FOBGBALNFAF = this.BBLEPPMMPIL(this.PHHBMKIBCOB, "sound", "mainmenu").IEIMMFODGFG;
		this.EPMFEFMKFFC = this.BBLEPPMMPIL(this.PHHBMKIBCOB, "sound", "othermenu").IEIMMFODGFG;
		Debug.Log("SoundMgr is init part 2");
	}

	// Token: 0x06007E6A RID: 32362 RVA: 0x003CC598 File Offset: 0x003CA798
	public void AMDLJMNDALF(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.HKBNODJBGEL();
		if (Time.time - this.ICGDJMOAEFH < 76f)
		{
			return;
		}
		int num = 1 + OLPINJLCKCI.NLOGJHEFMHM().FCEGAKPPDCA(7);
		string pecjfjhkgma = string.Format("", num);
		this.MCOLCPGIFFN(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 1422f, 1719f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E6B RID: 32363 RVA: 0x003CC608 File Offset: 0x003CA808
	public void NDJJCEBAEEP()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("GiantGrabThrow" + Time.time);
			this.OBENMEPCDJF.EEAPKMKECGP();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "_Cull";
		}
	}

	// Token: 0x06007E6C RID: 32364 RVA: 0x003CC65C File Offset: 0x003CA85C
	public void OPCIKCGADDD()
	{
		Debug.Log("****************  playNextMusic " + Time.time);
		this.KGPNFABIFLB = "";
		FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
		if (this.NNFHPMLCDBO != null && this.AEGJCIEDFHH.Count > 1)
		{
			while (fmhackmbdhg.KCOHPPPOIKC == this.NNFHPMLCDBO.KCOHPPPOIKC)
			{
				fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
			}
		}
		this.NNFHPMLCDBO = fmhackmbdhg;
		this.FGJONLGJOAB(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
		this.CFHAIJGNJMA(this.NNFHPMLCDBO);
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x003CC724 File Offset: 0x003CA924
	public void CFHAIJGNJMA(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 0.1f)
		{
			string iabkgmnjljo = string.Format("Play: `{0}` {1}", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.addRightMessageColored(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E6E RID: 32366 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void BKLIEBGJANE(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E6F RID: 32367 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void BHLPMMIMGCA(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x003CC774 File Offset: 0x003CA974
	public void BECGGCOLDLP(int PNEDPPPEFFG)
	{
		object[] array = new object[5];
		array[1] = "";
		array[0] = PNEDPPPEFFG;
		array[1] = " x";
		array[6] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.OIKCOFFEEKE != PNEDPPPEFFG)
		{
			this.NNFHPMLCDBO = this.AEGJCIEDFHH[OLPINJLCKCI.BMALMDIBLDP().GHCBFLEDNFE(this.AEGJCIEDFHH.Count)];
			this.KCEIHPKGGOL(this.NNFHPMLCDBO.KCOHPPPOIKC, true);
			this.NIJMPDCHEBP(this.NNFHPMLCDBO);
			this.OIKCOFFEEKE = PNEDPPPEFFG;
		}
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void EJKPNIMLLOP(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E72 RID: 32370 RVA: 0x003CC80B File Offset: 0x003CAA0B
	public void CFGMGCBJNNM()
	{
		this.BEEHMHJNHCN(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E73 RID: 32371 RVA: 0x003CC81C File Offset: 0x003CAA1C
	public void GGDLIEDGMDF(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.HKBNODJBGEL();
		if (Time.time - this.ICGDJMOAEFH < 251f)
		{
			return;
		}
		int num = 0 + OLPINJLCKCI.OBDBAABBAKB().HJJBGOAGLKG(8);
		string pecjfjhkgma = string.Format("ObscuredShort vs short, ", num);
		this.CGEKMDKCDGP(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 726f, 1316f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E74 RID: 32372 RVA: 0x003CC88C File Offset: 0x003CAA8C
	public void DAOCDJPLEPE(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.MAPNJFFAEBO(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.IMNNEDBALAB(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("Clouds reference not set." + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.GEHLHOFFAAJ(text, true);
	}

	// Token: 0x06007E75 RID: 32373 RVA: 0x003CC914 File Offset: 0x003CAB14
	public void FIHNMPAMAFE(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.NMBJFBCFDLC(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.OPLJOEMHEPG(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("#url Sound " + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.LoadAndPlay(text, false);
	}

	// Token: 0x06007E76 RID: 32374 RVA: 0x003CC99C File Offset: 0x003CAB9C
	public void EIJKDEOGEHL(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 0 + OLPINJLCKCI.IFLFANPMLMM().MIPEBCJCHNJ(6);
		if (BBOODPCDKAJ > 5)
		{
			BBOODPCDKAJ = 6;
		}
		string text = "INTERFACE";
		if (BBOODPCDKAJ == 0)
		{
			text = "error" + num;
		}
		if (BBOODPCDKAJ == 1)
		{
			text = "WeaponReady" + num;
		}
		if (BBOODPCDKAJ == 5)
		{
			text = "Jump" + num;
		}
		text += "dummy";
		this.MCOLCPGIFFN(text, NHCLMBOINFG, 1808f, 150f, 644f);
	}

	// Token: 0x06007E77 RID: 32375 RVA: 0x003CCA28 File Offset: 0x003CAC28
	public void CHILAODCBHO(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1082f)
		{
			string iabkgmnjljo = string.Format("Only Hinge Rotation Limits should be used on 2D IK solvers.", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.ELFAEBJJNPM(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E78 RID: 32376 RVA: 0x003CCA78 File Offset: 0x003CAC78
	public void OHKHJCKLDIJ(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = ")";
		}
		string pecjfjhkgma = "wpn_rod4";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.BJIPPOCFFOK(pecjfjhkgma, MGALEAJOGPL, 228f, 283f, 416f);
	}

	// Token: 0x06007E79 RID: 32377 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void OMHJJHECJPC(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E7A RID: 32378 RVA: 0x003CCAC8 File Offset: 0x003CACC8
	public void KCBPPLKKCNP(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("GestureWonderful" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1289f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 181f);
	}

	// Token: 0x06007E7B RID: 32379 RVA: 0x003CCB64 File Offset: 0x003CAD64
	private static string DJGFCFKEMFM(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.ENLHJOJICDG() + "lastRatingIndex" + HGGLNBKFHKK;
	}

	// Token: 0x06007E7C RID: 32380 RVA: 0x003CCB78 File Offset: 0x003CAD78
	public void EIDHGLDAPFI(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.SpatialBlend, GuiProcessor.BBLINJLBAIL().soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1026f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 451f);
	}

	// Token: 0x06007E7D RID: 32381 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void NBOMGFMDKJM(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E7E RID: 32382 RVA: 0x003CCC14 File Offset: 0x003CAE14
	public void KGPMJIGELMJ(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 1841f)
		{
			string iabkgmnjljo = string.Format("ShotgunReadyFire", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.PMOFPBKPKAP(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E7F RID: 32383 RVA: 0x003CAC94 File Offset: 0x003C8E94
	public void NJJEOKEKIPG()
	{
		this.NDOICBDIIHB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E80 RID: 32384 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void PHBAOHENJCM(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E81 RID: 32385 RVA: 0x003CCC64 File Offset: 0x003CAE64
	public void KJDAEGFOAIO(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.NPBJPFDDNPG(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.IMNNEDBALAB(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("CrawlLocomotion" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.ANGIBIPFDAO(text, false);
	}

	// Token: 0x06007E82 RID: 32386 RVA: 0x003CA2A0 File Offset: 0x003C84A0
	public void NCEAPBFBCGC(float EBILPJNBGLK)
	{
		if (this.OBENMEPCDJF != null)
		{
			this.OBENMEPCDJF.volume = EBILPJNBGLK;
			this.OBENMEPCDJF.tovolume = EBILPJNBGLK;
		}
	}

	// Token: 0x06007E83 RID: 32387 RVA: 0x003CCCE9 File Offset: 0x003CAEE9
	public void FLAJMNKOKKF()
	{
		this.BEEHMHJNHCN(this.FOBGBALNFAF, true);
	}

	// Token: 0x06007E84 RID: 32388 RVA: 0x003CCCF8 File Offset: 0x003CAEF8
	public void CPAJNIAMALH()
	{
		this.MCEEAPOKANB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E85 RID: 32389 RVA: 0x003CCD08 File Offset: 0x003CAF08
	public void GGFHIFPFEBI(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.NPBJPFDDNPG(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.OPLJOEMHEPG(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("{not_found}" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.DPCCJNJHGND(text, false);
	}

	// Token: 0x06007E86 RID: 32390 RVA: 0x003CCD90 File Offset: 0x003CAF90
	public void GGNLHBDBFCL()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("sys" + Time.time);
			this.OBENMEPCDJF.IJEKNMFJPJE();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "ObscuredBool:";
		}
	}

	// Token: 0x06007E87 RID: 32391 RVA: 0x003CCDE4 File Offset: 0x003CAFE4
	public void CHCGCGBDPLP(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.DJGFCFKEMFM(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.NILJMALGHBJ(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("Reveling" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.IIEPKFBCAGC(text, false);
	}

	// Token: 0x06007E88 RID: 32392 RVA: 0x003CCE6C File Offset: 0x003CB06C
	public void JNGIGPFIJDB()
	{
		Debug.Log("Drop " + Time.time);
		this.KGPNFABIFLB = "_SrcBlend";
		FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().MKOPHEAGIGE(this.AEGJCIEDFHH.Count)];
		if (this.NNFHPMLCDBO != null && this.AEGJCIEDFHH.Count > 0)
		{
			while (fmhackmbdhg.KCOHPPPOIKC == this.NNFHPMLCDBO.KCOHPPPOIKC)
			{
				fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.ODDOIHEPICE().JKGCGMKDAHH(this.AEGJCIEDFHH.Count)];
			}
		}
		this.NNFHPMLCDBO = fmhackmbdhg;
		this.NDOICBDIIHB(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
		this.IEBJDIENKNB(this.NNFHPMLCDBO);
	}

	// Token: 0x06007E89 RID: 32393 RVA: 0x003CCF34 File Offset: 0x003CB134
	public void HFGAHFGKFKL(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("ust_msg" + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.CustomRolloff, GuiProcessor.BBLINJLBAIL().soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1758f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 864f);
	}

	// Token: 0x06007E8A RID: 32394 RVA: 0x003CCFD0 File Offset: 0x003CB1D0
	public void DEEENJMPIHN(Vector3 NHCLMBOINFG, int BBOODPCDKAJ)
	{
		int num = 1 + OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(3);
		if (BBOODPCDKAJ > 2)
		{
			BBOODPCDKAJ = 2;
		}
		string text = "";
		if (BBOODPCDKAJ == 0)
		{
			text = "fider_Small_" + num;
		}
		if (BBOODPCDKAJ == 1)
		{
			text = "fider_Medium_" + num;
		}
		if (BBOODPCDKAJ == 2)
		{
			text = "fider_big_" + num;
		}
		text += ".ogg";
		this.MCOLCPGIFFN(text, NHCLMBOINFG, 1f, 5f, 30f);
	}

	// Token: 0x06007E8B RID: 32395 RVA: 0x003CD05C File Offset: 0x003CB25C
	public void ACFIKLELAFB(int PNEDPPPEFFG)
	{
		object[] array = new object[5];
		array[1] = "BowReady2";
		array[1] = PNEDPPPEFFG;
		array[7] = "[ACTk] Speed Hack Detector: already running!";
		array[8] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.OIKCOFFEEKE != PNEDPPPEFFG)
		{
			this.NNFHPMLCDBO = this.AEGJCIEDFHH[OLPINJLCKCI.ODDOIHEPICE().EFGDDAPIKBH(this.AEGJCIEDFHH.Count)];
			this.EHPBCCJHGDE(this.NNFHPMLCDBO.KCOHPPPOIKC, true);
			this.ENDNIEOEOAH(this.NNFHPMLCDBO);
			this.OIKCOFFEEKE = PNEDPPPEFFG;
		}
	}

	// Token: 0x06007E8C RID: 32396 RVA: 0x003CA4B7 File Offset: 0x003C86B7
	public void PBCCDCHPPOC(string JKLOOEDHHJP, AudioClip DNIBJBLMPGF)
	{
		if (!this.JKCFOMLDOHK.ContainsKey(JKLOOEDHHJP))
		{
			this.JKCFOMLDOHK.Add(JKLOOEDHHJP, DNIBJBLMPGF);
		}
	}

	// Token: 0x06007E8D RID: 32397 RVA: 0x003CD0F4 File Offset: 0x003CB2F4
	public void AKDOFKCANPE(AudioClip DNIBJBLMPGF, Vector3 MGALEAJOGPL, float EBILPJNBGLK = 1f, float FNADKBPAGJH = 3f, float DAILMANBNMM = 50f, float OEAFHCNGGEP = 1f)
	{
		if (DNIBJBLMPGF == null)
		{
			return;
		}
		GameObject gameObject = new GameObject("#mem Sound " + DNIBJBLMPGF.name);
		gameObject.transform.position = MGALEAJOGPL;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = DNIBJBLMPGF;
		audioSource.SetCustomCurve(AudioSourceCurveType.CustomRolloff, GuiProcessor.IKGFHGKKCPG.soundDefaultCurve);
		audioSource.minDistance = FNADKBPAGJH;
		audioSource.maxDistance = DAILMANBNMM;
		audioSource.spatialBlend = 1f;
		audioSource.volume = EBILPJNBGLK;
		audioSource.pitch = OEAFHCNGGEP;
		audioSource.Play();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UnityEngine.Object.Destroy(gameObject, DNIBJBLMPGF.length + 0.2f);
	}

	// Token: 0x06007E8E RID: 32398 RVA: 0x003CD190 File Offset: 0x003CB390
	public void GAFOHKNHFOA(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.MAPNJFFAEBO(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.IMNNEDBALAB(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("Player" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.BGEBAFPHGPO(text, true);
	}

	// Token: 0x06007E8F RID: 32399 RVA: 0x003CD218 File Offset: 0x003CB418
	public void LBGNEGLBLHF(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.CDBIEPGNONF();
		if (Time.time - this.ICGDJMOAEFH < 858f)
		{
			return;
		}
		int num = 1 + OLPINJLCKCI.ODDOIHEPICE().MIPEBCJCHNJ(7);
		string pecjfjhkgma = string.Format("", num);
		this.BJIPPOCFFOK(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 1127f, 257f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E90 RID: 32400 RVA: 0x003CD288 File Offset: 0x003CB488
	public void MLKBHIACKPP(string JGOFLNIMNGJ, Vector3 MGALEAJOGPL)
	{
		if (JGOFLNIMNGJ == null)
		{
			JGOFLNIMNGJ = "Finished";
		}
		string pecjfjhkgma = "";
		if (this.PDIPIJEPIKC.ContainsKey(JGOFLNIMNGJ))
		{
			pecjfjhkgma = this.PDIPIJEPIKC[JGOFLNIMNGJ];
		}
		this.MCOLCPGIFFN(pecjfjhkgma, MGALEAJOGPL, 1169f, 508f, 477f);
	}

	// Token: 0x06007E91 RID: 32401 RVA: 0x003CD2D8 File Offset: 0x003CB4D8
	public void ENDNIEOEOAH(FBFJFAKAGJG.FMHACKMBDHG DLNDOJEIBAI)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON > 956f)
		{
			string iabkgmnjljo = string.Format("gi_um_lv", this.NNFHPMLCDBO.BNIHFBMEPAB, this.NNFHPMLCDBO.KKPDFDENPLD);
			FlyMessageManager.getI.LECKCLOFJCI(iabkgmnjljo, Color.green);
		}
	}

	// Token: 0x06007E92 RID: 32402 RVA: 0x003CD328 File Offset: 0x003CB528
	public void OOMEDFKJOCN(Vector3 NHCLMBOINFG, float EBILPJNBGLK = 0.3f)
	{
		NHCLMBOINFG.y = LocNewLogic.getI.OGJHINOLHJJ;
		if (Time.time - this.ICGDJMOAEFH < 2f)
		{
			return;
		}
		int num = 1 + OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(7);
		string pecjfjhkgma = string.Format("fishsplash{0}.ogg", num);
		this.MCOLCPGIFFN(pecjfjhkgma, NHCLMBOINFG, EBILPJNBGLK, 1f, 10f);
		this.ICGDJMOAEFH = Time.time;
	}

	// Token: 0x06007E93 RID: 32403 RVA: 0x003CD397 File Offset: 0x003CB597
	private static string GACPOOMDMFP(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.EHCJCCILAHM() + "Demo" + HGGLNBKFHKK;
	}

	// Token: 0x06007E94 RID: 32404 RVA: 0x003CD3AC File Offset: 0x003CB5AC
	public void MCEEAPOKANB(string HMHOKNOOAOK, bool NMFPOEHHFOI = true)
	{
		object[] array = new object[6];
		array[1] = "IdleSad";
		array[0] = HMHOKNOOAOK;
		array[1] = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
		array[8] = Time.time;
		Debug.Log(string.Concat(array));
		if (this.KGPNFABIFLB == HMHOKNOOAOK)
		{
			return;
		}
		this.GOOPKBAKJEN();
		object[] array2 = new object[0];
		array2[1] = "Arm Flex 3";
		array2[0] = HMHOKNOOAOK;
		array2[1] = "<color='#c0c080'>";
		array2[8] = Time.time;
		Debug.Log(string.Concat(array2));
		this.KGPNFABIFLB = HMHOKNOOAOK;
		GameObject gameObject = new GameObject("DeadmanFloat" + HMHOKNOOAOK);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.volume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		audioSource.loop = NMFPOEHHFOI;
		this.OBENMEPCDJF = gameObject.AddComponent<GOSample2D>();
		this.OBENMEPCDJF.volume = 1057f;
		this.OBENMEPCDJF.tovolume = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		string alboclbfnni = IFPIMPMKJIB.ACOEIDGDLJC() + "isMoving" + HMHOKNOOAOK;
		this.OBENMEPCDJF.DOFDJGNDBDP(alboclbfnni, NMFPOEHHFOI, false);
	}

	// Token: 0x06007E95 RID: 32405 RVA: 0x003CD4D4 File Offset: 0x003CB6D4
	public BNOOIOKIFJC.DIGGOHPGCNN AIJFGDMBKHE(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.HGEJNFCBEEM));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("inv_useeff" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("DENSITY");
	}

	// Token: 0x06007E96 RID: 32406 RVA: 0x003CD584 File Offset: 0x003CB784
	public void LIGNCKFEGFK()
	{
		Debug.Log("1 Hand Heavy Swing" + Time.time);
		this.KGPNFABIFLB = "fchair_";
		FBFJFAKAGJG.FMHACKMBDHG fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NPIEJELJPIM().JKGCGMKDAHH(this.AEGJCIEDFHH.Count)];
		if (this.NNFHPMLCDBO != null && this.AEGJCIEDFHH.Count > 1)
		{
			while (fmhackmbdhg.KCOHPPPOIKC == this.NNFHPMLCDBO.KCOHPPPOIKC)
			{
				fmhackmbdhg = this.AEGJCIEDFHH[OLPINJLCKCI.NLOGJHEFMHM().HJJBGOAGLKG(this.AEGJCIEDFHH.Count)];
			}
		}
		this.NNFHPMLCDBO = fmhackmbdhg;
		this.NDOICBDIIHB(this.NNFHPMLCDBO.KCOHPPPOIKC, false);
		this.NELGPHMIGNC(this.NNFHPMLCDBO);
	}

	// Token: 0x06007E97 RID: 32407 RVA: 0x003CD64C File Offset: 0x003CB84C
	public BNOOIOKIFJC.DIGGOHPGCNN PBPGOLMBOCI(XmlDocument LMKLPODNLFC, string JKLOOEDHHJP, string BNIHFBMEPAB)
	{
		FBFJFAKAGJG.LGHNODJFEKE lghnodjfeke = new FBFJFAKAGJG.LGHNODJFEKE();
		lghnodjfeke.BNIHFBMEPAB = BNIHFBMEPAB;
		XmlNode xmlNode = LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = lghnodjfeke.LJOEIPHIJOE) == null)
			{
				predicate = (lghnodjfeke.LJOEIPHIJOE = new Func<XmlNode, bool>(lghnodjfeke.NOLKOJOJIME));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("Delete shadow" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("IdleButtonPress");
	}

	// Token: 0x06007E98 RID: 32408 RVA: 0x003CD6FC File Offset: 0x003CB8FC
	public void NHCEMEHKBMM()
	{
		if (this.OBENMEPCDJF != null)
		{
			Debug.Log("forSex" + Time.time);
			this.OBENMEPCDJF.BLFLBGDJFAN();
			this.OBENMEPCDJF = null;
			this.KGPNFABIFLB = "; ";
		}
	}

	// Token: 0x06007E99 RID: 32409 RVA: 0x003CD74D File Offset: 0x003CB94D
	private static string OPEOECGJJJF(string HGGLNBKFHKK)
	{
		return IFPIMPMKJIB.LIOPCJFCGAF() + "{{ {{{0}:{1}}}, {{{2}:{3}}} }}" + HGGLNBKFHKK;
	}

	// Token: 0x06007E9A RID: 32410 RVA: 0x003CAD14 File Offset: 0x003C8F14
	public void MHMEMCADNHA()
	{
		this.FGJONLGJOAB(this.EPMFEFMKFFC, true);
	}

	// Token: 0x06007E9B RID: 32411 RVA: 0x003CD760 File Offset: 0x003CB960
	public void HFJOFLCNLPA(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.OPEOECGJJJF(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.NILJMALGHBJ(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("gi_um_lv" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.PBECDEPEJEE(text, true);
	}

	// Token: 0x06007E9C RID: 32412 RVA: 0x003CD7E8 File Offset: 0x003CB9E8
	public void BIHLCHODGFB(string PALFNHCLKAJ, float KBBHHMILEOC = 1f)
	{
		string text = FBFJFAKAGJG.NBHDJOCIIHL(PALFNHCLKAJ);
		if (this.JKCFOMLDOHK.ContainsKey(text))
		{
			this.MLFGLEOKDFB(this.JKCFOMLDOHK[text], KBBHHMILEOC);
			return;
		}
		GameObject gameObject = new GameObject("" + text);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.transform.position = Camera.main.transform.position;
		gameObject.AddComponent<AudioSource>().volume = KBBHHMILEOC;
		GOSample2D gosample2D = gameObject.AddComponent<GOSample2D>();
		gosample2D.volume = KBBHHMILEOC;
		gosample2D.JDOBKMEPCKF(text, false);
	}

	// Token: 0x04001236 RID: 4662
	public static FBFJFAKAGJG IKGFHGKKCPG = new FBFJFAKAGJG();

	// Token: 0x04001237 RID: 4663
	private readonly Dictionary<string, AudioClip> JKCFOMLDOHK = new Dictionary<string, AudioClip>();

	// Token: 0x04001238 RID: 4664
	private readonly Dictionary<string, string> PDIPIJEPIKC = new Dictionary<string, string>();

	// Token: 0x04001239 RID: 4665
	private readonly Dictionary<int, FBFJFAKAGJG.OAMCMGDOEIA> MEJLJGGMFBI = new Dictionary<int, FBFJFAKAGJG.OAMCMGDOEIA>();

	// Token: 0x0400123A RID: 4666
	private readonly List<FBFJFAKAGJG.FMHACKMBDHG> AEGJCIEDFHH = new List<FBFJFAKAGJG.FMHACKMBDHG>();

	// Token: 0x0400123B RID: 4667
	private readonly XmlDocument PHHBMKIBCOB;

	// Token: 0x0400123C RID: 4668
	public string KGPNFABIFLB = "";

	// Token: 0x0400123D RID: 4669
	private GOSample2D OBENMEPCDJF;

	// Token: 0x0400123E RID: 4670
	public string FOBGBALNFAF;

	// Token: 0x0400123F RID: 4671
	public string EPMFEFMKFFC;

	// Token: 0x04001240 RID: 4672
	private FBFJFAKAGJG.FMHACKMBDHG NNFHPMLCDBO;

	// Token: 0x04001241 RID: 4673
	private int OIKCOFFEEKE = -1;

	// Token: 0x04001242 RID: 4674
	private float ICGDJMOAEFH;

	// Token: 0x02000223 RID: 547
	public class OAMCMGDOEIA
	{
		// Token: 0x06007E9D RID: 32413 RVA: 0x003CD86D File Offset: 0x003CBA6D
		public OAMCMGDOEIA(int LIEBJOAEFGK, XmlNode JEEEOEBNJDJ)
		{
			this.PNEDPPPEFFG = LIEBJOAEFGK;
		}

		// Token: 0x04001243 RID: 4675
		public int PNEDPPPEFFG;

		// Token: 0x04001244 RID: 4676
		public List<FBFJFAKAGJG.FMHACKMBDHG> HKLKJKJOEND = new List<FBFJFAKAGJG.FMHACKMBDHG>();
	}

	// Token: 0x02000224 RID: 548
	public class FMHACKMBDHG
	{
		// Token: 0x06007E9E RID: 32414 RVA: 0x003CD888 File Offset: 0x003CBA88
		public FMHACKMBDHG(XmlNode JEEEOEBNJDJ)
		{
			this.KCOHPPPOIKC = JEEEOEBNJDJ.Attributes["file"].Value;
			this.BNIHFBMEPAB = JEEEOEBNJDJ.Attributes["name"].Value;
			this.KKPDFDENPLD = JEEEOEBNJDJ.Attributes["author"].Value;
		}

		// Token: 0x04001245 RID: 4677
		public int LPFKFNLHGBI;

		// Token: 0x04001246 RID: 4678
		public string KCOHPPPOIKC;

		// Token: 0x04001247 RID: 4679
		public string BNIHFBMEPAB;

		// Token: 0x04001248 RID: 4680
		public string KKPDFDENPLD;
	}

	// Token: 0x02000225 RID: 549
	[CompilerGenerated]
	private sealed class LGHNODJFEKE
	{
		// Token: 0x06007E9F RID: 32415 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool HGEJNFCBEEM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool JCALIMGADHE(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool BAIOLCDJMKL(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool LJMEACIIBPJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool JLMPPDBIDKI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool BBJKDMMPCGM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool AAHBEPIGIAB(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool BJLKIOKFNOA(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool NOLKOJOJIME(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool NDEGOPHLILO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x003CD8EC File Offset: 0x003CBAEC
		internal bool BGNDKIDEDFG(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.BNIHFBMEPAB;
		}

		// Token: 0x04001249 RID: 4681
		public string BNIHFBMEPAB;

		// Token: 0x0400124A RID: 4682
		public Func<XmlNode, bool> LJOEIPHIJOE;
	}
}
