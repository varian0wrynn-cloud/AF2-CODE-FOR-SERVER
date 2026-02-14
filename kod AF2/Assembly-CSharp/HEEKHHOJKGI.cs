using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000579 RID: 1401
public sealed class HEEKHHOJKGI : IDisposable
{
	// Token: 0x060124CC RID: 74956 RVA: 0x0080738C File Offset: 0x0080558C
	public RenderTexture ABNFJLOKKMF(RenderTexture ENOPHMLOOKM)
	{
		return this.PDFEEEAPMDC(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)7) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, " ");
	}

	// Token: 0x060124CD RID: 74957 RVA: 0x008073D4 File Offset: 0x008055D4
	public void IJMKJBAPBJO()
	{
		this.DDOPLENPFMK();
	}

	// Token: 0x060124CE RID: 74958 RVA: 0x008073DC File Offset: 0x008055DC
	public RenderTexture GJOHODHDPDN(RenderTexture ENOPHMLOOKM)
	{
		return this.PDFEEEAPMDC(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)8) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, " гр ");
	}

	// Token: 0x060124CF RID: 74959 RVA: 0x00807424 File Offset: 0x00805624
	public void MLIOBPENIKG(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("_OutputGamma", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124D0 RID: 74960 RVA: 0x00807462 File Offset: 0x00805662
	public void EFIMDLENBNN(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("_name", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124D1 RID: 74961 RVA: 0x008074A0 File Offset: 0x008056A0
	public RenderTexture IABGFEANPPO(RenderTexture ENOPHMLOOKM)
	{
		return this.DJFOKFPMPDM(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)5) : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "_TapMedium");
	}

	// Token: 0x060124D2 RID: 74962 RVA: 0x008074E8 File Offset: 0x008056E8
	public void HOBOPJEBGEF()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124D3 RID: 74963 RVA: 0x00807524 File Offset: 0x00805724
	public RenderTexture HJFNEOFMJEJ(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124D4 RID: 74964 RVA: 0x00807564 File Offset: 0x00805764
	public void DOHKAANKEPC()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124D5 RID: 74965 RVA: 0x008075A0 File Offset: 0x008057A0
	public RenderTexture COJFABBKJDB(RenderTexture ENOPHMLOOKM)
	{
		return this.KJOHFKLIJHE(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)4) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "RandomDirection");
	}

	// Token: 0x060124D6 RID: 74966 RVA: 0x008075E8 File Offset: 0x008057E8
	public void NCPCKODLNDC()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124D7 RID: 74967 RVA: 0x00807623 File Offset: 0x00805823
	public void CFAGEDDFOFN()
	{
		this.NNHCDIKKDJH();
	}

	// Token: 0x060124D8 RID: 74968 RVA: 0x0080762B File Offset: 0x0080582B
	public void PINKLLIHCKF()
	{
		this.OFPCBKIAPIN();
	}

	// Token: 0x060124D9 RID: 74969 RVA: 0x00807633 File Offset: 0x00805833
	public void OFKHPBDDKHJ(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("Attempting to remove a RenderTexture that was not allocated: {0}", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124DA RID: 74970 RVA: 0x00807674 File Offset: 0x00805874
	public RenderTexture MLAKMCAPCOJ(RenderTexture ENOPHMLOOKM)
	{
		return this.AFONGIICOJG(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)7) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "medium");
	}

	// Token: 0x060124DB RID: 74971 RVA: 0x008076BC File Offset: 0x008058BC
	public RenderTexture NJACPJPGJFB(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124DC RID: 74972 RVA: 0x008076FC File Offset: 0x008058FC
	public RenderTexture OAJBECLLIEP(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124DD RID: 74973 RVA: 0x0080773C File Offset: 0x0080593C
	public HEEKHHOJKGI()
	{
		this.HNHLEJPBKFF = new HashSet<RenderTexture>();
	}

	// Token: 0x060124DE RID: 74974 RVA: 0x00807750 File Offset: 0x00805950
	public RenderTexture CGAACPIAKHP(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124DF RID: 74975 RVA: 0x00807790 File Offset: 0x00805990
	public void PKNMHMFNAGP(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124E0 RID: 74976 RVA: 0x00807623 File Offset: 0x00805823
	public void CJMADJGMFIP()
	{
		this.NNHCDIKKDJH();
	}

	// Token: 0x060124E1 RID: 74977 RVA: 0x008077D0 File Offset: 0x008059D0
	public RenderTexture JBLDPJMMJOL(RenderTexture ENOPHMLOOKM)
	{
		return this.AFONGIICOJG(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)4) : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "wpn_med1");
	}

	// Token: 0x060124E2 RID: 74978 RVA: 0x00807818 File Offset: 0x00805A18
	public void FCJPDGJDKHF()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124E3 RID: 74979 RVA: 0x00807854 File Offset: 0x00805A54
	public RenderTexture HNAEHMGEHHC(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124E4 RID: 74980 RVA: 0x00807623 File Offset: 0x00805823
	public void LPMNIGCLDED()
	{
		this.NNHCDIKKDJH();
	}

	// Token: 0x060124E5 RID: 74981 RVA: 0x00807894 File Offset: 0x00805A94
	public void OIEFAHGLPIE()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124E6 RID: 74982 RVA: 0x008078CF File Offset: 0x00805ACF
	public void NHHNEKPKHPC(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("No location found baseid=", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124E7 RID: 74983 RVA: 0x00807910 File Offset: 0x00805B10
	public RenderTexture CNKLFOMIGOH(RenderTexture ENOPHMLOOKM)
	{
		return this.HJFNEOFMJEJ(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)7) : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "{not_found}");
	}

	// Token: 0x060124E8 RID: 74984 RVA: 0x00807958 File Offset: 0x00805B58
	public void OFPCBKIAPIN()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124E9 RID: 74985 RVA: 0x00807994 File Offset: 0x00805B94
	public void DDOPLENPFMK()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124EA RID: 74986 RVA: 0x008079CF File Offset: 0x00805BCF
	public void PDIDDBBOGPI(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("SecondaryCausticsProjector", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124EB RID: 74987 RVA: 0x00807790 File Offset: 0x00805990
	public void OPAFGNJADPO(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124EC RID: 74988 RVA: 0x00807A10 File Offset: 0x00805C10
	public void ELPBNJAEJMO()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124ED RID: 74989 RVA: 0x00807A4C File Offset: 0x00805C4C
	public void NNHCDIKKDJH()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124EE RID: 74990 RVA: 0x00807A88 File Offset: 0x00805C88
	public void DCEDFJDEAPP()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124EF RID: 74991 RVA: 0x00807AC4 File Offset: 0x00805CC4
	public void HMJLKLKNCJE()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124F0 RID: 74992 RVA: 0x00807B00 File Offset: 0x00805D00
	public void EMBCCAPCJNK()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124F1 RID: 74993 RVA: 0x00807B3C File Offset: 0x00805D3C
	public void BDDNPDGOKNI()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124F2 RID: 74994 RVA: 0x00807B78 File Offset: 0x00805D78
	public void GOHFDLKECEH()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124F3 RID: 74995 RVA: 0x00807BB4 File Offset: 0x00805DB4
	public RenderTexture ILIOMPBIFIB(RenderTexture ENOPHMLOOKM)
	{
		return this.KJOHFKLIJHE(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)5) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "_Vibrance");
	}

	// Token: 0x060124F4 RID: 74996 RVA: 0x00807BFC File Offset: 0x00805DFC
	public void EIKFNKHPCHF()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124F5 RID: 74997 RVA: 0x00807C38 File Offset: 0x00805E38
	public RenderTexture GBJBBLJOAPI(RenderTexture ENOPHMLOOKM)
	{
		return this.HPAJGFGNMOH(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)6) : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, " ");
	}

	// Token: 0x060124F6 RID: 74998 RVA: 0x00807C80 File Offset: 0x00805E80
	public RenderTexture JDGIHFLNMKB(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x060124F7 RID: 74999 RVA: 0x00807CC0 File Offset: 0x00805EC0
	public void GMBHOMBKHOF(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("\n", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124F8 RID: 75000 RVA: 0x00807CFE File Offset: 0x00805EFE
	public void IKMAOHKFAAC()
	{
		this.EMBCCAPCJNK();
	}

	// Token: 0x060124F9 RID: 75001 RVA: 0x00807D08 File Offset: 0x00805F08
	public void DHIEFFEJIAA()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x060124FA RID: 75002 RVA: 0x00807D44 File Offset: 0x00805F44
	public RenderTexture DALPMLLJPKG(RenderTexture ENOPHMLOOKM)
	{
		return this.JDGIHFLNMKB(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)6) : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "_camouflage");
	}

	// Token: 0x060124FB RID: 75003 RVA: 0x00807D8C File Offset: 0x00805F8C
	public RenderTexture JNKAJCFJHIP(RenderTexture ENOPHMLOOKM)
	{
		return this.KJOHFKLIJHE(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)4) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "MotorbikeLassoLeft");
	}

	// Token: 0x060124FC RID: 75004 RVA: 0x00807DD4 File Offset: 0x00805FD4
	public void Dispose()
	{
		this.CPBLJJACIIB();
	}

	// Token: 0x060124FD RID: 75005 RVA: 0x00807DDC File Offset: 0x00805FDC
	public void IKEIEMKIEKG(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("BattleRoar", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x060124FE RID: 75006 RVA: 0x00807E1C File Offset: 0x0080601C
	public RenderTexture KFKONPLNJGO(RenderTexture ENOPHMLOOKM)
	{
		return this.HPAJGFGNMOH(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? ((RenderTextureReadWrite)3) : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "{0} FPS");
	}

	// Token: 0x060124FF RID: 75007 RVA: 0x00807E64 File Offset: 0x00806064
	public void GJKCCHCFJNO(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("OfficeSittingMouseMovement", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x06012500 RID: 75008 RVA: 0x00807EA4 File Offset: 0x008060A4
	public void KNFBPOKDEFP()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x06012501 RID: 75009 RVA: 0x00807EE0 File Offset: 0x008060E0
	public RenderTexture HPAJGFGNMOH(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x06012502 RID: 75010 RVA: 0x00807F20 File Offset: 0x00806120
	public RenderTexture KJOHFKLIJHE(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x06012503 RID: 75011 RVA: 0x00807F60 File Offset: 0x00806160
	public RenderTexture AFONGIICOJG(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x06012504 RID: 75012 RVA: 0x00807FA0 File Offset: 0x008061A0
	public RenderTexture DFEMMOCHMDM(RenderTexture ENOPHMLOOKM)
	{
		return this.PONLLEMLFBL(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? RenderTextureReadWrite.Default : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "u_UniqueShadowFilterWidth");
	}

	// Token: 0x06012505 RID: 75013 RVA: 0x00807FE8 File Offset: 0x008061E8
	public RenderTexture DJFOKFPMPDM(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x06012506 RID: 75014 RVA: 0x00808028 File Offset: 0x00806228
	public void KEIICHJKHMA(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("IdleMonster", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x06012507 RID: 75015 RVA: 0x00808066 File Offset: 0x00806266
	public void OIHDKCLPEOE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format(">", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x06012508 RID: 75016 RVA: 0x008080A4 File Offset: 0x008062A4
	public void IPJFHDNHCJO()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x06012509 RID: 75017 RVA: 0x008080E0 File Offset: 0x008062E0
	public RenderTexture GNDBFKAJJCI(RenderTexture ENOPHMLOOKM)
	{
		return this.OAJBECLLIEP(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? RenderTextureReadWrite.sRGB : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "iOS");
	}

	// Token: 0x0601250A RID: 75018 RVA: 0x00808128 File Offset: 0x00806328
	public void MFNMCAILHHM()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0601250B RID: 75019 RVA: 0x00808164 File Offset: 0x00806364
	public RenderTexture KGPKPOCMNJP(RenderTexture ENOPHMLOOKM)
	{
		return this.EODAHPDPKJC(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? RenderTextureReadWrite.sRGB : RenderTextureReadWrite.Default, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "RandomSound");
	}

	// Token: 0x0601250C RID: 75020 RVA: 0x008081AC File Offset: 0x008063AC
	public RenderTexture EODAHPDPKJC(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0601250D RID: 75021 RVA: 0x008081EC File Offset: 0x008063EC
	public RenderTexture PONLLEMLFBL(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0601250E RID: 75022 RVA: 0x0080822C File Offset: 0x0080642C
	public RenderTexture JJFELDJCAFA(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0601250F RID: 75023 RVA: 0x0080826C File Offset: 0x0080646C
	public void APPMOHMABMK(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("CrouchStrafeLeft", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x06012510 RID: 75024 RVA: 0x008082AA File Offset: 0x008064AA
	public void FGMNJBHEEML()
	{
		this.DCEDFJDEAPP();
	}

	// Token: 0x06012511 RID: 75025 RVA: 0x008082B2 File Offset: 0x008064B2
	public void AEIGHBEIBFN(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			throw new ArgumentException(string.Format("GestureWonderful", AMCABGBDDNG));
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x06012512 RID: 75026 RVA: 0x008082F0 File Offset: 0x008064F0
	public void LJPJKJABKDN()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x06012513 RID: 75027 RVA: 0x0080832C File Offset: 0x0080652C
	public void BLHPLMDOHGN()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x06012514 RID: 75028 RVA: 0x00808368 File Offset: 0x00806568
	public RenderTexture AFONGIICOJG(RenderTexture ENOPHMLOOKM)
	{
		return this.AFONGIICOJG(ENOPHMLOOKM.width, ENOPHMLOOKM.height, ENOPHMLOOKM.depth, ENOPHMLOOKM.format, ENOPHMLOOKM.sRGB ? RenderTextureReadWrite.sRGB : RenderTextureReadWrite.Linear, ENOPHMLOOKM.filterMode, ENOPHMLOOKM.wrapMode, "FactoryTempTexture");
	}

	// Token: 0x06012515 RID: 75029 RVA: 0x008083B0 File Offset: 0x008065B0
	public void CPBLJJACIIB()
	{
		foreach (RenderTexture temp in this.HNHLEJPBKFF)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x06012516 RID: 75030 RVA: 0x008083EC File Offset: 0x008065EC
	public RenderTexture PDFEEEAPMDC(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite GPALKMOKGIA = RenderTextureReadWrite.Default, FilterMode GACEFBMDIGI = FilterMode.Bilinear, TextureWrapMode JHICJIPPLBM = TextureWrapMode.Clamp, string BNIHFBMEPAB = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB, GPALKMOKGIA);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = JHICJIPPLBM;
		temporary.name = BNIHFBMEPAB;
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x040025DF RID: 9695
	private HashSet<RenderTexture> HNHLEJPBKFF;
}
