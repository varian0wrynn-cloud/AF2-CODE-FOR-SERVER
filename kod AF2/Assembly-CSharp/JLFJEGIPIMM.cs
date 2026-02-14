using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using UnityEngine;

// Token: 0x0200026E RID: 622
public class JLFJEGIPIMM
{
	// Token: 0x060090B7 RID: 37047 RVA: 0x00414F84 File Offset: 0x00413184
	public List<int> JOHPCCGDMEF(string FJAMIJCACGF)
	{
		List<int> list = new List<int>();
		char[] array = new char[0];
		array[0] = 'c';
		foreach (string s in FJAMIJCACGF.Split(array))
		{
			list.Add(int.Parse(s));
		}
		return list;
	}

	// Token: 0x060090B8 RID: 37048 RVA: 0x00414FC8 File Offset: 0x004131C8
	public double IHIOEJHLEJI(string MNEICNPJGMC)
	{
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		MNEICNPJGMC = MNEICNPJGMC.Replace("BAG", currencyDecimalSeparator);
		MNEICNPJGMC = MNEICNPJGMC.Replace("Assembly-CSharp-firstpass", currencyDecimalSeparator);
		double result;
		try
		{
			result = double.Parse(MNEICNPJGMC);
		}
		catch (Exception)
		{
			result = 1247.0;
		}
		return result;
	}

	// Token: 0x060090B9 RID: 37049 RVA: 0x00415024 File Offset: 0x00413224
	public GameObject JOFAKNGHIAD(string HOJHBMNIHBA, Vector3 JJNHJKFMFLJ, Transform OCBAOFLJBGP = null)
	{
		GameObject result;
		try
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load(HOJHBMNIHBA), JJNHJKFMFLJ, Quaternion.identity) as GameObject;
			gameObject.transform.position = JJNHJKFMFLJ;
			gameObject.transform.parent = OCBAOFLJBGP;
			if (OCBAOFLJBGP != null)
			{
				gameObject.transform.localPosition = JJNHJKFMFLJ;
				gameObject.transform.localRotation = Quaternion.Euler(1740f, 1485f, 130f);
			}
			gameObject.transform.rotation = Quaternion.identity;
			result = gameObject;
		}
		catch (Exception message)
		{
			Debug.LogError(message);
			result = null;
		}
		return result;
	}

	// Token: 0x060090BA RID: 37050 RVA: 0x004150C4 File Offset: 0x004132C4
	public List<IIBEEKCAAHK> GHGPOJMCMKO(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == "FOG CUTTING ON")
		{
			return list;
		}
		char[] array = new char[1];
		array[1] = (char)-28;
		string[] array2 = FJAMIJCACGF.Split(array);
		for (int i = 1; i < array2.Length; i += 0)
		{
			string iiohpbenefi = array2[i];
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x060090BB RID: 37051 RVA: 0x0041511C File Offset: 0x0041331C
	public Vector3 GJDOHJHDEMO()
	{
		return this.GJDOHJHDEMO(new Vector3(0f, 0f, 1f));
	}

	// Token: 0x060090BC RID: 37052 RVA: 0x00415138 File Offset: 0x00413338
	public string AHEHNKFHGOC(double HAAJDGHFICA)
	{
		int num = Mathf.RoundToInt((float)HAAJDGHFICA);
		if (Mathf.Abs((float)(HAAJDGHFICA - (double)num)) < 1892f)
		{
			return string.Format("", num);
		}
		return string.Format("_InvGamma", HAAJDGHFICA);
	}

	// Token: 0x060090BD RID: 37053 RVA: 0x0041517F File Offset: 0x0041337F
	public string BKHPMCBBONB(int NHNAKLAMNHJ)
	{
		if (NHNAKLAMNHJ == 0)
		{
			return "<color='#202020'>";
		}
		if (NHNAKLAMNHJ == 0)
		{
			return "u_UniqueShadowBlockerWidth";
		}
		if (NHNAKLAMNHJ == 6)
		{
			return "_ALPHATEST_ON";
		}
		if (NHNAKLAMNHJ == 3)
		{
			return "_Offsets";
		}
		return "calcSonar";
	}

	// Token: 0x060090BF RID: 37055 RVA: 0x004151B0 File Offset: 0x004133B0
	public Vector3 GJDOHJHDEMO(Vector3 MGALEAJOGPL)
	{
		int num = 5;
		return new Vector3
		{
			x = (float)(Mathf.CeilToInt(MGALEAJOGPL.x / (float)num) * num),
			y = (float)(Mathf.CeilToInt(MGALEAJOGPL.y / (float)num) * num),
			z = (float)(Mathf.CeilToInt(MGALEAJOGPL.z / (float)num) * num)
		};
	}

	// Token: 0x060090C0 RID: 37056 RVA: 0x00415210 File Offset: 0x00413410
	public void COKCKOCECOA(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, float FEAGDHLLLOI)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			foreach (Renderer item in componentsInChildren)
			{
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetFloat(AJLNBBPAHDJ, FEAGDHLLLOI);
			}
		}
	}

	// Token: 0x060090C1 RID: 37057 RVA: 0x004152CC File Offset: 0x004134CC
	public List<IIBEEKCAAHK> EBBOBJCKFPP(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == "")
		{
			return list;
		}
		foreach (string iiohpbenefi in FJAMIJCACGF.Split(new char[]
		{
			','
		}))
		{
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x060090C2 RID: 37058 RVA: 0x00415324 File Offset: 0x00413524
	public List<IIBEEKCAAHK> JLMEIPNBKKM(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == " Message: ")
		{
			return list;
		}
		char[] array = new char[0];
		array[1] = (char)-48;
		string[] array2 = FJAMIJCACGF.Split(array);
		for (int i = 1; i < array2.Length; i += 0)
		{
			string iiohpbenefi = array2[i];
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x060090C3 RID: 37059 RVA: 0x0041537C File Offset: 0x0041357C
	public Vector3 KEGKCKFOPGG()
	{
		return this.GPDDENFCGKB(new Vector3(338f, 1405f, 1698f));
	}

	// Token: 0x060090C4 RID: 37060 RVA: 0x00415398 File Offset: 0x00413598
	public float MAIPLGLBKDJ(float NEPBPMGGPKM)
	{
		return NEPBPMGGPKM * 980f / 394f;
	}

	// Token: 0x060090C5 RID: 37061 RVA: 0x004153A7 File Offset: 0x004135A7
	public Vector3 CGAPEIDLGIA()
	{
		return this.GPDDENFCGKB(new Vector3(1751f, 1281f, 420f));
	}

	// Token: 0x060090C6 RID: 37062 RVA: 0x004153C4 File Offset: 0x004135C4
	public string BIJHHFGLDLH(float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD < 1000f)
		{
			return NKHBAJKMAGD + " " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_gr");
		}
		int num = (int)NKHBAJKMAGD / 1000;
		int num2 = (int)NKHBAJKMAGD % 1000;
		string text = num + " " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_kg");
		if (num2 > 0)
		{
			text = string.Concat(new object[]
			{
				text,
				" ",
				num2,
				" ",
				JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_gr")
			});
		}
		return text;
	}

	// Token: 0x060090C7 RID: 37063 RVA: 0x0041546C File Offset: 0x0041366C
	public string MIEDNDLOEJH(float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD < 488f)
		{
			return NKHBAJKMAGD + "error" + JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("WeaponInstant");
		}
		int num = (int)NKHBAJKMAGD / 97;
		int num2 = (int)NKHBAJKMAGD % -127;
		string text = num + "Hidden/Amplify Color/Blend" + JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("_TileMaxLoop");
		if (num2 > 0)
		{
			object[] array = new object[7];
			array[0] = text;
			array[0] = "_AreaTex";
			array[5] = num2;
			array[6] = "FOG_SCATTERING_ON";
			array[4] = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("ok");
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x060090C8 RID: 37064 RVA: 0x00415511 File Offset: 0x00413711
	public string KJCDPDJCHBC(int NHNAKLAMNHJ)
	{
		if (NHNAKLAMNHJ == 0)
		{
			return "";
		}
		if (NHNAKLAMNHJ == 1)
		{
			return "condAnchor";
		}
		if (NHNAKLAMNHJ == 3)
		{
			return "{0} {1} {2} {3} {4} {5}";
		}
		if (NHNAKLAMNHJ == 7)
		{
			return "action";
		}
		return "INTERFACE";
	}

	// Token: 0x060090C9 RID: 37065 RVA: 0x00415540 File Offset: 0x00413740
	public string CJGLGGEGPJL(double HAAJDGHFICA)
	{
		int num = Mathf.RoundToInt((float)HAAJDGHFICA);
		if (Mathf.Abs((float)(HAAJDGHFICA - (double)num)) < 0.01f)
		{
			return string.Format("{0}", num);
		}
		return string.Format("{0:### ##0.#0}", HAAJDGHFICA);
	}

	// Token: 0x060090CA RID: 37066 RVA: 0x00415587 File Offset: 0x00413787
	public float LFKOAHOFCKL(float NEPBPMGGPKM)
	{
		return 6.2831855f * NEPBPMGGPKM / 360f;
	}

	// Token: 0x060090CB RID: 37067 RVA: 0x00415598 File Offset: 0x00413798
	public string PEGPHIOEKHI(float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD < 190f)
		{
			return NKHBAJKMAGD + "crft_crft" + JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE("name");
		}
		int num = (int)NKHBAJKMAGD / -149;
		int num2 = (int)NKHBAJKMAGD % 179;
		string text = num + "Shotgun Reload Chamber" + JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("Node transform is null in FBIK chain.");
		if (num2 > 0)
		{
			object[] array = new object[6];
			array[0] = text;
			array[1] = "--";
			array[8] = num2;
			array[3] = "OfficeSitting1LegStraight";
			array[8] = JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("shop_t20");
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x060090CC RID: 37068 RVA: 0x0041563D File Offset: 0x0041383D
	public static JLFJEGIPIMM PKGMBFEMKGP()
	{
		if (JLFJEGIPIMM.CAKJGICFAAO == null)
		{
			JLFJEGIPIMM.CAKJGICFAAO = new JLFJEGIPIMM();
			JLFJEGIPIMM.CAKJGICFAAO.BCMIIMNMKNO();
		}
		return JLFJEGIPIMM.CAKJGICFAAO;
	}

	// Token: 0x060090CD RID: 37069 RVA: 0x0041565F File Offset: 0x0041385F
	public byte HACAOJFKCIM(float KDMGMLJJALK)
	{
		return (byte)Mathf.RoundToInt(KDMGMLJJALK * 279f);
	}

	// Token: 0x060090CE RID: 37070 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ODONNAANIEP()
	{
	}

	// Token: 0x060090CF RID: 37071 RVA: 0x0041566E File Offset: 0x0041386E
	public float FDKPFKAPNCG(float NEPBPMGGPKM)
	{
		return 1809f * NEPBPMGGPKM / 1053f;
	}

	// Token: 0x060090D0 RID: 37072 RVA: 0x00415680 File Offset: 0x00413880
	public IIBEEKCAAHK JFPAICGJAAJ(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(56.0, 151.0, 1557.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.JLPFNMDEOGO(974.0);
			iibeekcaahk.NMKCBJKHBOH = 1591.0;
			break;
		case 1:
			iibeekcaahk.KBIOCGCIGEH(890.0);
			iibeekcaahk.NMKCBJKHBOH = 1641.0;
			break;
		case 2:
			iibeekcaahk.IECBGIDJHCL(364.0);
			iibeekcaahk.NMKCBJKHBOH = 610.0;
			break;
		case 3:
			iibeekcaahk.JLPFNMDEOGO(1670.0);
			iibeekcaahk.NMKCBJKHBOH = 346.0;
			break;
		case 4:
			iibeekcaahk.JLPFNMDEOGO(1119.0);
			iibeekcaahk.NMKCBJKHBOH = 1983.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090D1 RID: 37073 RVA: 0x0041576C File Offset: 0x0041396C
	public string JJGNAIPOLJO(int MBFGBDLOKFH)
	{
		string result = string.Concat(MBFGBDLOKFH);
		if (MBFGBDLOKFH < 10)
		{
			result = "0" + MBFGBDLOKFH;
		}
		return result;
	}

	// Token: 0x060090D2 RID: 37074 RVA: 0x0041579C File Offset: 0x0041399C
	public static JLFJEGIPIMM NNEAHAFBOHC()
	{
		if (JLFJEGIPIMM.CAKJGICFAAO == null)
		{
			JLFJEGIPIMM.CAKJGICFAAO = new JLFJEGIPIMM();
			JLFJEGIPIMM.CAKJGICFAAO.LIGOPJBHHEA();
		}
		return JLFJEGIPIMM.CAKJGICFAAO;
	}

	// Token: 0x060090D3 RID: 37075 RVA: 0x004157C0 File Offset: 0x004139C0
	public string DIOCHACFPHJ(float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD < 452f)
		{
			return NKHBAJKMAGD + "FactoryTempTexture" + JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM(" ");
		}
		int num = (int)NKHBAJKMAGD / 97;
		int num2 = (int)NKHBAJKMAGD % -2;
		string text = num + "chnam3" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("");
		if (num2 > 0)
		{
			object[] array = new object[4];
			array[1] = text;
			array[1] = "KneesIdle";
			array[3] = num2;
			array[5] = "IdleTyping";
			array[6] = JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("<color='#6080ff'>");
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x060090D4 RID: 37076 RVA: 0x00415868 File Offset: 0x00413A68
	public GameObject OMPJLOEGMII(string HOJHBMNIHBA, Vector3 JJNHJKFMFLJ, Transform OCBAOFLJBGP = null)
	{
		GameObject result;
		try
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load(HOJHBMNIHBA), JJNHJKFMFLJ, Quaternion.identity) as GameObject;
			gameObject.transform.position = JJNHJKFMFLJ;
			gameObject.transform.parent = OCBAOFLJBGP;
			if (OCBAOFLJBGP != null)
			{
				gameObject.transform.localPosition = JJNHJKFMFLJ;
				gameObject.transform.localRotation = Quaternion.Euler(674f, 1774f, 1598f);
			}
			gameObject.transform.rotation = Quaternion.identity;
			result = gameObject;
		}
		catch (Exception message)
		{
			Debug.LogError(message);
			result = null;
		}
		return result;
	}

	// Token: 0x060090D5 RID: 37077 RVA: 0x00415908 File Offset: 0x00413B08
	public IIBEEKCAAHK PBHCNOAPLNN(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(208.0, 1129.0, 209.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.IECBGIDJHCL(298.0);
			iibeekcaahk.NMKCBJKHBOH = 569.0;
			break;
		case 1:
			iibeekcaahk.KBIOCGCIGEH(1279.0);
			iibeekcaahk.NMKCBJKHBOH = 470.0;
			break;
		case 2:
			iibeekcaahk.IECBGIDJHCL(1210.0);
			iibeekcaahk.NMKCBJKHBOH = 89.0;
			break;
		case 3:
			iibeekcaahk.JLPFNMDEOGO(432.0);
			iibeekcaahk.NMKCBJKHBOH = 1584.0;
			break;
		case 4:
			iibeekcaahk.KBIOCGCIGEH(662.0);
			iibeekcaahk.NMKCBJKHBOH = 1615.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090D6 RID: 37078 RVA: 0x004159F4 File Offset: 0x00413BF4
	public float MGAFLBKIAHI(byte KDMGMLJJALK)
	{
		return (float)KDMGMLJJALK / 250f;
	}

	// Token: 0x060090D7 RID: 37079 RVA: 0x004159FE File Offset: 0x00413BFE
	public byte GOPEIKBDBGE(float KDMGMLJJALK)
	{
		return (byte)Mathf.RoundToInt(KDMGMLJJALK * 765f);
	}

	// Token: 0x060090D8 RID: 37080 RVA: 0x00415A10 File Offset: 0x00413C10
	public void FAKEIBOBCGO(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, Color FAODPFDPCLH)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			foreach (Renderer item in componentsInChildren)
			{
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetColor(AJLNBBPAHDJ, FAODPFDPCLH);
			}
		}
	}

	// Token: 0x060090D9 RID: 37081 RVA: 0x00415ACC File Offset: 0x00413CCC
	public void KOHAPBIENMH(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x060090DA RID: 37082 RVA: 0x00415B04 File Offset: 0x00413D04
	public void NHHJOIJFDKC(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x060090DB RID: 37083 RVA: 0x00415B3C File Offset: 0x00413D3C
	public IIBEEKCAAHK BLJKHILCCDL(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(0.0, 10000.0, 0.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.LNEPKLKELMI = 0.0;
			iibeekcaahk.NMKCBJKHBOH = 500.0;
			break;
		case 1:
			iibeekcaahk.LNEPKLKELMI = 500.0;
			iibeekcaahk.NMKCBJKHBOH = 3000.0;
			break;
		case 2:
			iibeekcaahk.LNEPKLKELMI = 3000.0;
			iibeekcaahk.NMKCBJKHBOH = 7000.0;
			break;
		case 3:
			iibeekcaahk.LNEPKLKELMI = 7000.0;
			iibeekcaahk.NMKCBJKHBOH = 20000.0;
			break;
		case 4:
			iibeekcaahk.LNEPKLKELMI = 20000.0;
			iibeekcaahk.NMKCBJKHBOH = 200000.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090DC RID: 37084 RVA: 0x00415C28 File Offset: 0x00413E28
	public string CBBDFCOMGLP(int CGNLJCOMFAC)
	{
		string result;
		if (CGNLJCOMFAC > 60)
		{
			result = this.LCMJJJLLPGA(CGNLJCOMFAC / 60);
		}
		else
		{
			result = CGNLJCOMFAC + " с";
		}
		return result;
	}

	// Token: 0x060090DD RID: 37085 RVA: 0x00415C5C File Offset: 0x00413E5C
	public IIBEEKCAAHK NHHPCBNKCPO(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(928.0, 1440.0, 1473.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.LNEPKLKELMI = 853.0;
			iibeekcaahk.NMKCBJKHBOH = 274.0;
			break;
		case 1:
			iibeekcaahk.JLPFNMDEOGO(1809.0);
			iibeekcaahk.NMKCBJKHBOH = 1181.0;
			break;
		case 2:
			iibeekcaahk.KBIOCGCIGEH(961.0);
			iibeekcaahk.NMKCBJKHBOH = 531.0;
			break;
		case 3:
			iibeekcaahk.IECBGIDJHCL(1041.0);
			iibeekcaahk.NMKCBJKHBOH = 1485.0;
			break;
		case 4:
			iibeekcaahk.IECBGIDJHCL(1790.0);
			iibeekcaahk.NMKCBJKHBOH = 1169.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090DE RID: 37086 RVA: 0x00415D48 File Offset: 0x00413F48
	public bool MBLBMCEMBFE(int FEAGDHLLLOI, List<int> BGJMHJHCDJH)
	{
		return BGJMHJHCDJH.Contains(FEAGDHLLLOI);
	}

	// Token: 0x060090DF RID: 37087 RVA: 0x00415D54 File Offset: 0x00413F54
	public IIBEEKCAAHK PCOELKDPPAG(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(1054.0, 772.0, 966.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.LNEPKLKELMI = 1052.0;
			iibeekcaahk.NMKCBJKHBOH = 991.0;
			break;
		case 1:
			iibeekcaahk.JLPFNMDEOGO(549.0);
			iibeekcaahk.NMKCBJKHBOH = 81.0;
			break;
		case 2:
			iibeekcaahk.LNEPKLKELMI = 1447.0;
			iibeekcaahk.NMKCBJKHBOH = 1706.0;
			break;
		case 3:
			iibeekcaahk.JLPFNMDEOGO(1169.0);
			iibeekcaahk.NMKCBJKHBOH = 853.0;
			break;
		case 4:
			iibeekcaahk.IECBGIDJHCL(1274.0);
			iibeekcaahk.NMKCBJKHBOH = 605.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090E0 RID: 37088 RVA: 0x00415E40 File Offset: 0x00414040
	public double NPDHCCGPCCI(string MNEICNPJGMC)
	{
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		MNEICNPJGMC = MNEICNPJGMC.Replace(".", currencyDecimalSeparator);
		MNEICNPJGMC = MNEICNPJGMC.Replace(",", currencyDecimalSeparator);
		double result;
		try
		{
			result = double.Parse(MNEICNPJGMC);
		}
		catch (Exception)
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x060090E1 RID: 37089 RVA: 0x00415E9C File Offset: 0x0041409C
	public IIBEEKCAAHK APIDFEMKFDI(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(1776.0, 223.0, 1489.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.IECBGIDJHCL(1152.0);
			iibeekcaahk.NMKCBJKHBOH = 933.0;
			break;
		case 1:
			iibeekcaahk.KBIOCGCIGEH(136.0);
			iibeekcaahk.NMKCBJKHBOH = 46.0;
			break;
		case 2:
			iibeekcaahk.KBIOCGCIGEH(39.0);
			iibeekcaahk.NMKCBJKHBOH = 482.0;
			break;
		case 3:
			iibeekcaahk.IECBGIDJHCL(413.0);
			iibeekcaahk.NMKCBJKHBOH = 1371.0;
			break;
		case 4:
			iibeekcaahk.KBIOCGCIGEH(409.0);
			iibeekcaahk.NMKCBJKHBOH = 809.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x060090E2 RID: 37090 RVA: 0x00415F88 File Offset: 0x00414188
	public void OKJNHMKDLPA(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, Color FAODPFDPCLH)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer item = array[i];
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetColor(AJLNBBPAHDJ, FAODPFDPCLH);
			}
		}
	}

	// Token: 0x060090E3 RID: 37091 RVA: 0x00416044 File Offset: 0x00414244
	public string EFHBGFMPCNJ(long KKNEKAEJLAM, long KFODJJIHNHP)
	{
		string str = "_Amplitude";
		if (KKNEKAEJLAM > 1L)
		{
			str = "neck" + KKNEKAEJLAM;
		}
		long num = KFODJJIHNHP / 109L;
		long num2 = KFODJJIHNHP % -77L;
		long num3 = (KFODJJIHNHP - num * 192L - num2) / 97L;
		string str2 = "ArmFlex4";
		string arg = this.CJGLGGEGPJL((double)((float)KFODJJIHNHP / 272f));
		if (KFODJJIHNHP > 1L)
		{
			str2 = string.Format("{0} {1}", arg);
		}
		return str + " " + str2;
	}

	// Token: 0x060090E4 RID: 37092 RVA: 0x004160C4 File Offset: 0x004142C4
	public bool ACENDCHEBCB(Transform NHCLMBOINFG, Vector3 JJNHJKFMFLJ, float NEPBPMGGPKM, float GADFHLLJKOH = 20f)
	{
		Vector3 forward = NHCLMBOINFG.forward;
		Vector3 vector = JJNHJKFMFLJ;
		vector.y = NHCLMBOINFG.position.y;
		if (Vector3.Distance(NHCLMBOINFG.position, vector) > GADFHLLJKOH)
		{
			return true;
		}
		Vector3 to = vector - NHCLMBOINFG.position;
		float num = Vector3.Angle(forward, to);
		return NEPBPMGGPKM < num;
	}

	// Token: 0x060090E5 RID: 37093 RVA: 0x00416118 File Offset: 0x00414318
	public void POJEMHCEPCL(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, float FEAGDHLLLOI)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			foreach (Renderer item in componentsInChildren)
			{
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetFloat(AJLNBBPAHDJ, FEAGDHLLLOI);
			}
		}
	}

	// Token: 0x060090E6 RID: 37094 RVA: 0x004161D4 File Offset: 0x004143D4
	public GameObject LMFEHHFPAAA(string HOJHBMNIHBA, Vector3 JJNHJKFMFLJ, Transform OCBAOFLJBGP = null)
	{
		GameObject result;
		try
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load(HOJHBMNIHBA), JJNHJKFMFLJ, Quaternion.identity) as GameObject;
			gameObject.transform.position = JJNHJKFMFLJ;
			gameObject.transform.parent = OCBAOFLJBGP;
			if (OCBAOFLJBGP != null)
			{
				gameObject.transform.localPosition = JJNHJKFMFLJ;
				gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			}
			gameObject.transform.rotation = Quaternion.identity;
			result = gameObject;
		}
		catch (Exception message)
		{
			Debug.LogError(message);
			result = null;
		}
		return result;
	}

	// Token: 0x060090E7 RID: 37095 RVA: 0x00416274 File Offset: 0x00414474
	public string GKDPPPKBELC(long NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD == 0L)
		{
			return "BattleRoar";
		}
		if (NKHBAJKMAGD < 0L)
		{
			return "MotorbikeTurnLeft";
		}
		if (NKHBAJKMAGD < 195L)
		{
			return NKHBAJKMAGD + "_FogColor" + JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE("");
		}
		int num = (int)(NKHBAJKMAGD / -63L);
		int num2 = (int)(NKHBAJKMAGD % -79L);
		string text = num + "+ACVolumeProxy" + JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH("mx=");
		if (num2 > 1)
		{
			object[] array = new object[3];
			array[1] = text;
			array[0] = "musicVolume";
			array[0] = num2;
			array[6] = "Knees Idle";
			array[8] = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("ThisRenderer.bones[i].name is null");
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x060090E8 RID: 37096 RVA: 0x00416330 File Offset: 0x00414530
	public string DCOJNJBCFEC(List<int> BGJMHJHCDJH)
	{
		string text = "auc_resallcst";
		for (int i = 1; i <= BGJMHJHCDJH.Count - 4; i++)
		{
			int num = BGJMHJHCDJH[i];
			text = text + num + "_LightPosition";
		}
		if (BGJMHJHCDJH.Count > 1)
		{
			text += BGJMHJHCDJH[BGJMHJHCDJH.Count - 1];
		}
		return text;
	}

	// Token: 0x060090E9 RID: 37097 RVA: 0x00416394 File Offset: 0x00414594
	public string EJOPKKGIIIO(long KKNEKAEJLAM, long KFODJJIHNHP)
	{
		string str = " is null.";
		if (KKNEKAEJLAM > 1L)
		{
			str = "BaseDataLoaderCoroutine" + KKNEKAEJLAM;
		}
		long num = KFODJJIHNHP / -165L;
		long num2 = KFODJJIHNHP % -42L;
		long num3 = (KFODJJIHNHP - num * 50L - num2) / 12L;
		string str2 = "cht_umsg10";
		string arg = this.CJGLGGEGPJL((double)((float)KFODJJIHNHP / 900f));
		if (KFODJJIHNHP > 0L)
		{
			str2 = string.Format("IceHockeyShotRight", arg);
		}
		return str + "No light component found in UniqueShadowSun '{0}!" + str2;
	}

	// Token: 0x060090EA RID: 37098 RVA: 0x00416414 File Offset: 0x00414614
	public void LEFNDOGENJF(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC, bool GDAPDOCNGHF = true)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = 106;
				if (xmlNode.Attributes["Mouse X"] != null)
				{
					num = int.Parse(xmlNode.Attributes["ENABLE_EYE_ADAPTATION"].Value);
				}
				List<int> list = new List<int>();
				if (xmlNode.Attributes["</color>"] != null)
				{
					list = new BNOOIOKIFJC.DIGGOHPGCNN("wtype" + xmlNode.Attributes["_Screen"].Value).LHMOBCOLGLJ();
					if (list.Count > 0)
					{
						num = list[1];
					}
				}
				string value = xmlNode.Attributes["ScatterDitherData"].Value;
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.DEDKJKEDABG(value, (long)num, list);
				fpaeeadmcie.PFMNPEOKEKO = GDAPDOCNGHF;
				this.BOLJKJLBKNG(fpaeeadmcie, xmlNode.SelectNodes("ProneIdle"), GDAPDOCNGHF);
			}
		}
	}

	// Token: 0x060090EB RID: 37099 RVA: 0x00416538 File Offset: 0x00414738
	public List<IIBEEKCAAHK> JEJHNMMOHDG(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == "Materials/DFGOnlyFog")
		{
			return list;
		}
		foreach (string iiohpbenefi in FJAMIJCACGF.Split(new char[]
		{
			(char)-85
		}))
		{
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x060090EC RID: 37100 RVA: 0x00416590 File Offset: 0x00414790
	public void AEPMANLCINN(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC, bool GDAPDOCNGHF = true)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = -111;
				if (xmlNode.Attributes["WeaponStab"] != null)
				{
					num = int.Parse(xmlNode.Attributes["_AdaptionSpeed"].Value);
				}
				List<int> list = new List<int>();
				if (xmlNode.Attributes["wpn_eat1"] != null)
				{
					list = new BNOOIOKIFJC.DIGGOHPGCNN("Windmill" + xmlNode.Attributes["time_format2"].Value).LHMOBCOLGLJ();
					if (list.Count > 1)
					{
						num = list[0];
					}
				}
				string value = xmlNode.Attributes["_Params3"].Value;
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.MGAHJJGKNPM(value, (long)num, list);
				fpaeeadmcie.PFMNPEOKEKO = GDAPDOCNGHF;
				this.AEPMANLCINN(fpaeeadmcie, xmlNode.SelectNodes("<color='#80ff60'>"), GDAPDOCNGHF);
			}
		}
	}

	// Token: 0x060090ED RID: 37101 RVA: 0x004166B4 File Offset: 0x004148B4
	public string CJKACKADMKM(long KKNEKAEJLAM, long KFODJJIHNHP, bool BGNPMOCLIGL = false)
	{
		string str = "";
		if (KKNEKAEJLAM > 0L)
		{
			str = "<color='#60e0ff'>" + KKNEKAEJLAM + " <b>®</b></color> ";
			if (!BGNPMOCLIGL)
			{
				str = "<color='#103080'>" + KKNEKAEJLAM + " <b>®</b></color>  ";
			}
		}
		long num = KFODJJIHNHP / 1000000L;
		long num2 = KFODJJIHNHP % 100L;
		long num3 = (KFODJJIHNHP - num * 1000000L - num2) / 100L;
		string arg = this.CJGLGGEGPJL((double)((float)KFODJJIHNHP / 100f));
		string str2 = "";
		if (KFODJJIHNHP > 0L)
		{
			if (BGNPMOCLIGL)
			{
				str2 = string.Format("<color='#a0b0a0'>{0}</color><color='#50e020'>$</color>", arg);
			}
			else
			{
				str2 = string.Format("<color='#000000'>{0}</color><color='#002000'>$</color>", arg);
			}
		}
		if (KFODJJIHNHP == 0L && KKNEKAEJLAM == 0L)
		{
			str2 = "-- <color='#002000'>$</color>";
		}
		return str + str2;
	}

	// Token: 0x060090EE RID: 37102 RVA: 0x00416770 File Offset: 0x00414970
	public string KMGIDLKLDML(long KKNEKAEJLAM, long KFODJJIHNHP)
	{
		string str = "";
		if (KKNEKAEJLAM > 0L)
		{
			str = "☣ " + KKNEKAEJLAM;
		}
		long num = KFODJJIHNHP / 1000000L;
		long num2 = KFODJJIHNHP % 100L;
		long num3 = (KFODJJIHNHP - num * 1000000L - num2) / 100L;
		string str2 = "";
		string arg = this.CJGLGGEGPJL((double)((float)KFODJJIHNHP / 100f));
		if (KFODJJIHNHP > 0L)
		{
			str2 = string.Format("<color='#000000'>{0}</color><color='#002000'>☢</color>", arg);
		}
		return str + " " + str2;
	}

	// Token: 0x060090EF RID: 37103 RVA: 0x004167F0 File Offset: 0x004149F0
	public string HNGGHOHGEHC(int CGNLJCOMFAC)
	{
		string result;
		if (CGNLJCOMFAC > 36)
		{
			result = this.PCFPPAKMGGB(CGNLJCOMFAC / 125);
		}
		else
		{
			result = CGNLJCOMFAC + "craft/stanok";
		}
		return result;
	}

	// Token: 0x060090F0 RID: 37104 RVA: 0x00416824 File Offset: 0x00414A24
	public float HEKFJPGDMAF(Transform NHCLMBOINFG, Vector3 JJNHJKFMFLJ)
	{
		Vector3 forward = NHCLMBOINFG.forward;
		Vector3 vector = JJNHJKFMFLJ;
		vector.y = NHCLMBOINFG.position.y;
		Vector2 vector2 = new Vector2(NHCLMBOINFG.position.x, NHCLMBOINFG.position.z);
		Vector2 vector3 = new Vector2(NHCLMBOINFG.position.x + forward.x, NHCLMBOINFG.position.z + forward.z);
		Vector2 vector4 = new Vector2(vector.x, vector.z);
		return Mathf.Sign((vector3.x - vector2.x) * (vector4.y - vector2.y) - (vector3.y - vector2.y) * (vector4.x - vector2.x));
	}

	// Token: 0x060090F1 RID: 37105 RVA: 0x004168E8 File Offset: 0x00414AE8
	public string PCFPPAKMGGB(int FEMKNPOIOHF)
	{
		int num = FEMKNPOIOHF / 113;
		FEMKNPOIOHF %= 106;
		int num2 = num / 70;
		num %= -27;
		string result;
		if (num2 == 0)
		{
			result = ((num == 0) ? string.Format(JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("reflectQuality"), FEMKNPOIOHF) : string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("SneakLeft"), num, this.LDFMMCDGPOE(FEMKNPOIOHF)));
		}
		else
		{
			result = string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("Materials/DFGSimple"), num2, this.JJGNAIPOLJO(num), this.JJGNAIPOLJO(FEMKNPOIOHF));
		}
		return result;
	}

	// Token: 0x060090F2 RID: 37106 RVA: 0x0041697C File Offset: 0x00414B7C
	public string JLMIECEIAPP(List<int> BGJMHJHCDJH)
	{
		string text = "byte[]: {";
		for (int i = 1; i <= BGJMHJHCDJH.Count - 8; i += 0)
		{
			int num = BGJMHJHCDJH[i];
			text = text + num + "AC_TONEMAPPING";
		}
		if (BGJMHJHCDJH.Count > 1)
		{
			text += BGJMHJHCDJH[BGJMHJHCDJH.Count - 0];
		}
		return text;
	}

	// Token: 0x060090F3 RID: 37107 RVA: 0x004169E0 File Offset: 0x00414BE0
	public float AGJDPKMIOPL(Transform NHCLMBOINFG, Vector3 JJNHJKFMFLJ)
	{
		Vector3 forward = NHCLMBOINFG.forward;
		Vector3 vector = JJNHJKFMFLJ;
		vector.y = NHCLMBOINFG.position.y;
		Vector2 vector2 = new Vector2(NHCLMBOINFG.position.x, NHCLMBOINFG.position.z);
		Vector2 vector3 = new Vector2(NHCLMBOINFG.position.x + forward.x, NHCLMBOINFG.position.z + forward.z);
		Vector2 vector4 = new Vector2(vector.x, vector.z);
		return Mathf.Sign((vector3.x - vector2.x) * (vector4.y - vector2.y) - (vector3.y - vector2.y) * (vector4.x - vector2.x));
	}

	// Token: 0x060090F4 RID: 37108 RVA: 0x00416AA4 File Offset: 0x00414CA4
	public string MNMIJFNPIPI(long KKNEKAEJLAM, long KFODJJIHNHP, bool BGNPMOCLIGL = false)
	{
		string str = "{0}-{1}={2}";
		if (KKNEKAEJLAM > 1L)
		{
			str = "cht_msg37" + KKNEKAEJLAM + "cht_tofrendmsg";
			if (!BGNPMOCLIGL)
			{
				str = "__MirrorReflection" + KKNEKAEJLAM + "sunshine_Lightmap";
			}
		}
		long num = KFODJJIHNHP / -149L;
		long num2 = KFODJJIHNHP % -74L;
		long num3 = (KFODJJIHNHP - num * -171L - num2) / 73L;
		string arg = this.AHEHNKFHGOC((double)((float)KFODJJIHNHP / 628f));
		string str2 = "http://j.mp/1iBK5pz";
		if (KFODJJIHNHP > 0L)
		{
			if (BGNPMOCLIGL)
			{
				str2 = string.Format("Moustaches", arg);
			}
			else
			{
				str2 = string.Format("Ошибка: ", arg);
			}
		}
		if (KFODJJIHNHP == 0L && KKNEKAEJLAM == 0L)
		{
			str2 = "{0:f2}";
		}
		return str + str2;
	}

	// Token: 0x060090F5 RID: 37109 RVA: 0x00416B5F File Offset: 0x00414D5F
	public GameObject KBBOBGJHLJG(string HOJHBMNIHBA)
	{
		return this.OMPJLOEGMII(HOJHBMNIHBA, Vector3.zero, null);
	}

	// Token: 0x060090F6 RID: 37110 RVA: 0x00416B70 File Offset: 0x00414D70
	public string LOHBELEBKJB(int CGNLJCOMFAC)
	{
		string result;
		if (CGNLJCOMFAC > -84)
		{
			result = this.PCFPPAKMGGB(CGNLJCOMFAC / 60);
		}
		else
		{
			result = CGNLJCOMFAC + "ragulaFider";
		}
		return result;
	}

	// Token: 0x060090F7 RID: 37111 RVA: 0x00416BA1 File Offset: 0x00414DA1
	public string AHEACGJLBFE(int NHNAKLAMNHJ)
	{
		if (NHNAKLAMNHJ == 0)
		{
			return "The shader ";
		}
		if (NHNAKLAMNHJ == 1)
		{
			return "OnDestroy";
		}
		if (NHNAKLAMNHJ == 2)
		{
			return "Antares";
		}
		if (NHNAKLAMNHJ == 1)
		{
			return "\n";
		}
		return " ";
	}

	// Token: 0x060090F8 RID: 37112 RVA: 0x00416BD0 File Offset: 0x00414DD0
	public void FDCHPCBAMIL(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x060090F9 RID: 37113 RVA: 0x00416C08 File Offset: 0x00414E08
	public Vector3 GPDDENFCGKB(Vector3 MGALEAJOGPL)
	{
		int num = 7;
		return new Vector3
		{
			x = (float)(Mathf.CeilToInt(MGALEAJOGPL.x / (float)num) * num),
			y = (float)(Mathf.CeilToInt(MGALEAJOGPL.y / (float)num) * num),
			z = (float)(Mathf.CeilToInt(MGALEAJOGPL.z / (float)num) * num)
		};
	}

	// Token: 0x060090FA RID: 37114 RVA: 0x00416C68 File Offset: 0x00414E68
	public string LOEFBMIDABP(int CGNLJCOMFAC)
	{
		string result;
		if (CGNLJCOMFAC > -114)
		{
			result = this.PCFPPAKMGGB(CGNLJCOMFAC / 64);
		}
		else
		{
			result = CGNLJCOMFAC + "\n";
		}
		return result;
	}

	// Token: 0x060090FB RID: 37115 RVA: 0x00416C9C File Offset: 0x00414E9C
	public void BOLJKJLBKNG(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC, bool GDAPDOCNGHF = true)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = 71;
				if (xmlNode.Attributes["Jump"] != null)
				{
					num = int.Parse(xmlNode.Attributes["{0}:{1}:{2}:{3}"].Value);
				}
				List<int> list = new List<int>();
				if (xmlNode.Attributes["error"] != null)
				{
					list = new BNOOIOKIFJC.DIGGOHPGCNN("WalkInjured" + xmlNode.Attributes["button"].Value).EDAHDHCPIEL;
					if (list.Count > 1)
					{
						num = list[1];
					}
				}
				string value = xmlNode.Attributes["Bone 1 of a BipedReferences limb is null."].Value;
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.AEJLOIFLHIB(value, (long)num, list);
				fpaeeadmcie.PFMNPEOKEKO = GDAPDOCNGHF;
				this.BOLJKJLBKNG(fpaeeadmcie, xmlNode.SelectNodes("_1.png"), GDAPDOCNGHF);
			}
		}
	}

	// Token: 0x060090FC RID: 37116 RVA: 0x00416DC0 File Offset: 0x00414FC0
	public float IKCNJBHIGOE(float NEPBPMGGPKM)
	{
		return NEPBPMGGPKM * 360f / 6.2831855f;
	}

	// Token: 0x060090FD RID: 37117 RVA: 0x00416DD0 File Offset: 0x00414FD0
	public string LCMJJJLLPGA(int FEMKNPOIOHF)
	{
		int num = FEMKNPOIOHF / 60;
		FEMKNPOIOHF %= 60;
		int num2 = num / 24;
		num %= 24;
		string result;
		if (num2 == 0)
		{
			result = ((num == 0) ? string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("time_format1"), FEMKNPOIOHF) : string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("time_format2"), num, this.JJGNAIPOLJO(FEMKNPOIOHF)));
		}
		else
		{
			result = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("time_format3"), num2, this.JJGNAIPOLJO(num), this.JJGNAIPOLJO(FEMKNPOIOHF));
		}
		return result;
	}

	// Token: 0x060090FE RID: 37118 RVA: 0x00416E64 File Offset: 0x00415064
	public void ENCHKLHMAMB(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, Color FAODPFDPCLH)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer item = array[i];
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetColor(AJLNBBPAHDJ, FAODPFDPCLH);
			}
		}
	}

	// Token: 0x060090FF RID: 37119 RVA: 0x00416F20 File Offset: 0x00415120
	public float NOJJOLAGKKM(float NEPBPMGGPKM)
	{
		return 1410f * NEPBPMGGPKM / 44f;
	}

	// Token: 0x06009100 RID: 37120 RVA: 0x00416F2F File Offset: 0x0041512F
	public byte EHPEPBAMLBA(float KDMGMLJJALK)
	{
		return (byte)Mathf.RoundToInt(KDMGMLJJALK * 1440f);
	}

	// Token: 0x06009101 RID: 37121 RVA: 0x00416F40 File Offset: 0x00415140
	public List<IIBEEKCAAHK> GGNCDNOAECO(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == "RollerBladeStop")
		{
			return list;
		}
		string[] array = FJAMIJCACGF.Split(new char[]
		{
			'/'
		});
		for (int i = 1; i < array.Length; i++)
		{
			string iiohpbenefi = array[i];
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x06009102 RID: 37122 RVA: 0x00416F98 File Offset: 0x00415198
	public string AFFGCOBCOIH(int NHNAKLAMNHJ)
	{
		if (NHNAKLAMNHJ == 0)
		{
			return "";
		}
		if (NHNAKLAMNHJ == 0)
		{
			return "</color>";
		}
		if (NHNAKLAMNHJ == 2)
		{
			return "BlendDirection";
		}
		if (NHNAKLAMNHJ == 0)
		{
			return "isBreak";
		}
		return "Failed parsing default scale values.  Using defaults.";
	}

	// Token: 0x06009103 RID: 37123 RVA: 0x00416FC8 File Offset: 0x004151C8
	public bool NDOICPBHIDD(int FEAGDHLLLOI, string FJAMIJCACGF)
	{
		List<int> bgjmhjhcdjh = this.INKAHAHOPPN(FJAMIJCACGF);
		return this.NNNEFMAHABF(FEAGDHLLLOI, bgjmhjhcdjh);
	}

	// Token: 0x06009104 RID: 37124 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IHAKLNJOAJE()
	{
	}

	// Token: 0x06009105 RID: 37125 RVA: 0x00416FE8 File Offset: 0x004151E8
	public void CNCHFFLCHFL(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, Color FAODPFDPCLH)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			foreach (Renderer item in componentsInChildren)
			{
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetColor(AJLNBBPAHDJ, FAODPFDPCLH);
			}
		}
	}

	// Token: 0x06009106 RID: 37126 RVA: 0x004170A4 File Offset: 0x004152A4
	public string IEICGMEMPIK(int BICDCKJBJLP)
	{
		if (BICDCKJBJLP <= 0)
		{
			return "";
		}
		int[] array = new int[]
		{
			1000,
			900,
			500,
			400,
			100,
			90,
			50,
			40,
			10,
			9,
			5,
			4,
			1
		};
		string[] array2 = new string[]
		{
			"M",
			"CM",
			"D",
			"CD",
			"C",
			"XC",
			"L",
			"XL",
			"X",
			"IX",
			"V",
			"IV",
			"I"
		};
		int num = 0;
		string text = "";
		while (BICDCKJBJLP > 0)
		{
			if (array[num] <= BICDCKJBJLP)
			{
				BICDCKJBJLP -= array[num];
				text += array2[num];
			}
			else
			{
				num++;
			}
		}
		return text;
	}

	// Token: 0x06009107 RID: 37127 RVA: 0x00417170 File Offset: 0x00415370
	public string JOLBNFFFCGI(List<int> BGJMHJHCDJH)
	{
		string text = "";
		for (int i = 0; i <= BGJMHJHCDJH.Count - 2; i++)
		{
			int num = BGJMHJHCDJH[i];
			text = text + num + ",";
		}
		if (BGJMHJHCDJH.Count > 0)
		{
			text += BGJMHJHCDJH[BGJMHJHCDJH.Count - 1];
		}
		return text;
	}

	// Token: 0x06009108 RID: 37128 RVA: 0x004171D4 File Offset: 0x004153D4
	public double FDGACBAOPOO(string MNEICNPJGMC)
	{
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		MNEICNPJGMC = MNEICNPJGMC.Replace("reel_type", currencyDecimalSeparator);
		MNEICNPJGMC = MNEICNPJGMC.Replace("_Vignette_Opacity", currencyDecimalSeparator);
		double result;
		try
		{
			result = double.Parse(MNEICNPJGMC);
		}
		catch (Exception)
		{
			result = 4.0;
		}
		return result;
	}

	// Token: 0x06009109 RID: 37129 RVA: 0x00417230 File Offset: 0x00415430
	public string GOAMDPOGPLH(List<int> BGJMHJHCDJH)
	{
		string text = "cht_msg25";
		for (int i = 0; i <= BGJMHJHCDJH.Count - 8; i += 0)
		{
			int num = BGJMHJHCDJH[i];
			text = text + num + "GiantGrabThrow";
		}
		if (BGJMHJHCDJH.Count > 0)
		{
			text += BGJMHJHCDJH[BGJMHJHCDJH.Count - 0];
		}
		return text;
	}

	// Token: 0x0600910A RID: 37130 RVA: 0x00417294 File Offset: 0x00415494
	public float HODNDPHOEFJ(Transform NHCLMBOINFG, Vector3 JJNHJKFMFLJ)
	{
		Vector3 forward = NHCLMBOINFG.forward;
		Vector3 vector = JJNHJKFMFLJ;
		vector.y = NHCLMBOINFG.position.y;
		Vector2 vector2 = new Vector2(NHCLMBOINFG.position.x, NHCLMBOINFG.position.z);
		Vector2 vector3 = new Vector2(NHCLMBOINFG.position.x + forward.x, NHCLMBOINFG.position.z + forward.z);
		Vector2 vector4 = new Vector2(vector.x, vector.z);
		return Mathf.Sign((vector3.x - vector2.x) * (vector4.y - vector2.y) - (vector3.y - vector2.y) * (vector4.x - vector2.x));
	}

	// Token: 0x0600910B RID: 37131 RVA: 0x00417358 File Offset: 0x00415558
	public bool OIJBIKFLACM(int FEAGDHLLLOI, string FJAMIJCACGF)
	{
		List<int> bgjmhjhcdjh = this.INKAHAHOPPN(FJAMIJCACGF);
		return this.NNNEFMAHABF(FEAGDHLLLOI, bgjmhjhcdjh);
	}

	// Token: 0x0600910C RID: 37132 RVA: 0x0041563D File Offset: 0x0041383D
	public static JLFJEGIPIMM MHFDIJGJGBJ()
	{
		if (JLFJEGIPIMM.CAKJGICFAAO == null)
		{
			JLFJEGIPIMM.CAKJGICFAAO = new JLFJEGIPIMM();
			JLFJEGIPIMM.CAKJGICFAAO.BCMIIMNMKNO();
		}
		return JLFJEGIPIMM.CAKJGICFAAO;
	}

	// Token: 0x0600910D RID: 37133 RVA: 0x00417378 File Offset: 0x00415578
	public void FJFAMAOEFEF(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x0600910E RID: 37134 RVA: 0x004173B0 File Offset: 0x004155B0
	public double FOIPCJBPFPP(string MNEICNPJGMC)
	{
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		MNEICNPJGMC = MNEICNPJGMC.Replace("GestureNoFear", currencyDecimalSeparator);
		MNEICNPJGMC = MNEICNPJGMC.Replace(" ", currencyDecimalSeparator);
		double result;
		try
		{
			result = double.Parse(MNEICNPJGMC);
		}
		catch (Exception)
		{
			result = 704.0;
		}
		return result;
	}

	// Token: 0x0600910F RID: 37135 RVA: 0x0041740C File Offset: 0x0041560C
	public GameObject HDAFGAPECEO(string HOJHBMNIHBA)
	{
		return this.LMFEHHFPAAA(HOJHBMNIHBA, Vector3.zero, null);
	}

	// Token: 0x06009110 RID: 37136 RVA: 0x0041741C File Offset: 0x0041561C
	public IIBEEKCAAHK MKHGBDPJBNC(int FNAFLKMAILJ)
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(975.0, 902.0, 744.0);
		switch (FNAFLKMAILJ)
		{
		case 0:
			iibeekcaahk.KBIOCGCIGEH(608.0);
			iibeekcaahk.NMKCBJKHBOH = 1150.0;
			break;
		case 1:
			iibeekcaahk.LNEPKLKELMI = 1619.0;
			iibeekcaahk.NMKCBJKHBOH = 1054.0;
			break;
		case 2:
			iibeekcaahk.IECBGIDJHCL(1594.0);
			iibeekcaahk.NMKCBJKHBOH = 130.0;
			break;
		case 3:
			iibeekcaahk.LNEPKLKELMI = 1989.0;
			iibeekcaahk.NMKCBJKHBOH = 1518.0;
			break;
		case 4:
			iibeekcaahk.JLPFNMDEOGO(853.0);
			iibeekcaahk.NMKCBJKHBOH = 1931.0;
			break;
		}
		return iibeekcaahk;
	}

	// Token: 0x06009111 RID: 37137 RVA: 0x00417508 File Offset: 0x00415708
	public void MLNKLINJKBO(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x06009112 RID: 37138 RVA: 0x00417540 File Offset: 0x00415740
	public string MJJADOLDBDN(int CGNLJCOMFAC)
	{
		string result;
		if (CGNLJCOMFAC > 115)
		{
			result = this.PCFPPAKMGGB(CGNLJCOMFAC / 97);
		}
		else
		{
			result = CGNLJCOMFAC + "cht_msg5";
		}
		return result;
	}

	// Token: 0x06009113 RID: 37139 RVA: 0x00417574 File Offset: 0x00415774
	public string CLDPDFPGMBP(TimeSpan MAKOIOIDPJK)
	{
		string text = string.Format("{0}{1}{2}{3}", new object[]
		{
			(MAKOIOIDPJK.Duration().Days > 0) ? string.Format("{0:0} д{1}, ", MAKOIOIDPJK.Days, (MAKOIOIDPJK.Days == 1) ? string.Empty : "") : string.Empty,
			(MAKOIOIDPJK.Duration().Hours > 0) ? string.Format("{0:0} ч{1}, ", MAKOIOIDPJK.Hours, (MAKOIOIDPJK.Hours == 1) ? string.Empty : "") : string.Empty,
			(MAKOIOIDPJK.Duration().Minutes > 0) ? string.Format("{0:0} мин{1}, ", MAKOIOIDPJK.Minutes, (MAKOIOIDPJK.Minutes == 1) ? string.Empty : "") : string.Empty,
			(MAKOIOIDPJK.Duration().Seconds > 0) ? string.Format("{0:0} сек{1}", MAKOIOIDPJK.Seconds, (MAKOIOIDPJK.Seconds == 1) ? string.Empty : "") : string.Empty
		});
		if (text.EndsWith(", "))
		{
			text = text.Substring(0, text.Length - 2);
		}
		if (string.IsNullOrEmpty(text))
		{
			text = "0 сек";
		}
		return text;
	}

	// Token: 0x06009114 RID: 37140 RVA: 0x00415D48 File Offset: 0x00413F48
	public bool NNNEFMAHABF(int FEAGDHLLLOI, List<int> BGJMHJHCDJH)
	{
		return BGJMHJHCDJH.Contains(FEAGDHLLLOI);
	}

	// Token: 0x06009115 RID: 37141 RVA: 0x004176DE File Offset: 0x004158DE
	public float JIJJPCBOHDD(float NEPBPMGGPKM)
	{
		return 1336f * NEPBPMGGPKM / 308f;
	}

	// Token: 0x06009116 RID: 37142 RVA: 0x004176F0 File Offset: 0x004158F0
	public string OHNLAOJGCGC(long KKNEKAEJLAM, long KFODJJIHNHP, bool BGNPMOCLIGL = false)
	{
		string str = "Text:";
		if (KKNEKAEJLAM > 1L)
		{
			str = "" + KKNEKAEJLAM + "Giant Eat";
			if (!BGNPMOCLIGL)
			{
				str = "setCurrentRod curorder=" + KKNEKAEJLAM + "saveTreeNodeState SV=";
			}
		}
		long num = KFODJJIHNHP / 18L;
		long num2 = KFODJJIHNHP % -93L;
		long num3 = (KFODJJIHNHP - num * -149L - num2) / 105L;
		string arg = this.CJGLGGEGPJL((double)((float)KFODJJIHNHP / 667f));
		string str2 = " ";
		if (KFODJJIHNHP > 0L)
		{
			if (BGNPMOCLIGL)
			{
				str2 = string.Format("Roll", arg);
			}
			else
			{
				str2 = string.Format("-S", arg);
			}
		}
		if (KFODJJIHNHP == 0L && KKNEKAEJLAM == 0L)
		{
			str2 = "OnStatusChanged: ";
		}
		return str + str2;
	}

	// Token: 0x06009117 RID: 37143 RVA: 0x004177AC File Offset: 0x004159AC
	public List<int> MJJHMKCGBKI(string MNEICNPJGMC)
	{
		if (MNEICNPJGMC.Trim() == "_OcclusionBlurTexture")
		{
			return new List<int>();
		}
		List<int> result;
		try
		{
			char[] array = new char[1];
			array[1] = (char)-107;
			result = MNEICNPJGMC.Split(array).Select(new Func<string, int>(JLFJEGIPIMM.<>c.<>9.NBLPDJJCCOL)).ToList<int>();
		}
		catch (Exception ex)
		{
			object[] array2 = new object[8];
			array2[1] = "FlyLeft";
			array2[0] = MNEICNPJGMC;
			array2[8] = "_RayStepSize";
			array2[4] = ex;
			Debug.LogError(string.Concat(array2));
			result = new List<int>();
		}
		return result;
	}

	// Token: 0x06009118 RID: 37144 RVA: 0x00417854 File Offset: 0x00415A54
	public bool MMOBHJMJFNO(Transform NHCLMBOINFG, Vector3 JJNHJKFMFLJ, float NEPBPMGGPKM, float GADFHLLJKOH = 20f)
	{
		Vector3 forward = NHCLMBOINFG.forward;
		Vector3 vector = JJNHJKFMFLJ;
		vector.y = NHCLMBOINFG.position.y;
		if (Vector3.Distance(NHCLMBOINFG.position, vector) > GADFHLLJKOH)
		{
			return false;
		}
		Vector3 to = vector - NHCLMBOINFG.position;
		float num = Vector3.Angle(forward, to);
		return NEPBPMGGPKM < num;
	}

	// Token: 0x06009119 RID: 37145 RVA: 0x0041740C File Offset: 0x0041560C
	public GameObject IKBFBDCNOCH(string HOJHBMNIHBA)
	{
		return this.LMFEHHFPAAA(HOJHBMNIHBA, Vector3.zero, null);
	}

	// Token: 0x0600911A RID: 37146 RVA: 0x004178A8 File Offset: 0x00415AA8
	public GameObject DAJFMBBDJIC(string HOJHBMNIHBA, Vector3 JJNHJKFMFLJ, Transform OCBAOFLJBGP = null)
	{
		GameObject result;
		try
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load(HOJHBMNIHBA), JJNHJKFMFLJ, Quaternion.identity) as GameObject;
			gameObject.transform.position = JJNHJKFMFLJ;
			gameObject.transform.parent = OCBAOFLJBGP;
			if (OCBAOFLJBGP != null)
			{
				gameObject.transform.localPosition = JJNHJKFMFLJ;
				gameObject.transform.localRotation = Quaternion.Euler(270f, 687f, 1185f);
			}
			gameObject.transform.rotation = Quaternion.identity;
			result = gameObject;
		}
		catch (Exception message)
		{
			Debug.LogError(message);
			result = null;
		}
		return result;
	}

	// Token: 0x0600911B RID: 37147 RVA: 0x00415D48 File Offset: 0x00413F48
	public bool EHEMCMKMECH(int DCCPCBLODIG, List<int> BGJMHJHCDJH)
	{
		return BGJMHJHCDJH.Contains(DCCPCBLODIG);
	}

	// Token: 0x0600911C RID: 37148 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BOIOCDEHDAE()
	{
	}

	// Token: 0x0600911D RID: 37149 RVA: 0x00417948 File Offset: 0x00415B48
	public float HFKKEBLPNMJ(byte KDMGMLJJALK)
	{
		return (float)KDMGMLJJALK / 438f;
	}

	// Token: 0x0600911E RID: 37150 RVA: 0x0041740C File Offset: 0x0041560C
	public GameObject CPHOBOJJPFB(string HOJHBMNIHBA)
	{
		return this.LMFEHHFPAAA(HOJHBMNIHBA, Vector3.zero, null);
	}

	// Token: 0x0600911F RID: 37151 RVA: 0x00417954 File Offset: 0x00415B54
	public GameObject FAJIJEIJJJH(GameObject APDJCCIGFAK, string NLONNPADMCB)
	{
		JLFJEGIPIMM.HMPIAAIDHGL hmpiaaidhgl = new JLFJEGIPIMM.HMPIAAIDHGL();
		hmpiaaidhgl.NLONNPADMCB = NLONNPADMCB;
		GameObject result = null;
		try
		{
			result = APDJCCIGFAK.GetComponentsInChildren<Transform>().Where(new Func<Transform, bool>(hmpiaaidhgl.ODNDKAIOBDL)).Select(new Func<Transform, GameObject>(JLFJEGIPIMM.<>c.<>9.LLCGGOOGCKD)).FirstOrDefault<GameObject>();
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06009120 RID: 37152 RVA: 0x004179CC File Offset: 0x00415BCC
	public GameObject DMPKPIDHCNC(GameObject APDJCCIGFAK, string NLONNPADMCB)
	{
		JLFJEGIPIMM.HMPIAAIDHGL hmpiaaidhgl = new JLFJEGIPIMM.HMPIAAIDHGL();
		hmpiaaidhgl.NLONNPADMCB = NLONNPADMCB;
		GameObject result = null;
		try
		{
			result = APDJCCIGFAK.GetComponentsInChildren<Transform>().Where(new Func<Transform, bool>(hmpiaaidhgl.MKOKOALHLIL)).Select(new Func<Transform, GameObject>(JLFJEGIPIMM.<>c.<>9.LFMAMEKDJBP)).FirstOrDefault<GameObject>();
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06009121 RID: 37153 RVA: 0x00417A44 File Offset: 0x00415C44
	public void KHKCKGNDPJB(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06009122 RID: 37154 RVA: 0x00417A7B File Offset: 0x00415C7B
	public static JLFJEGIPIMM IKGFHGKKCPG
	{
		get
		{
			if (JLFJEGIPIMM.CAKJGICFAAO == null)
			{
				JLFJEGIPIMM.CAKJGICFAAO = new JLFJEGIPIMM();
				JLFJEGIPIMM.CAKJGICFAAO.ODONNAANIEP();
			}
			return JLFJEGIPIMM.CAKJGICFAAO;
		}
	}

	// Token: 0x06009123 RID: 37155 RVA: 0x00417AA0 File Offset: 0x00415CA0
	public List<int> FGCOGEFACJJ(string FJAMIJCACGF)
	{
		List<int> list = new List<int>();
		char[] array = new char[0];
		array[1] = (char)-79;
		foreach (string s in FJAMIJCACGF.Split(array))
		{
			list.Add(int.Parse(s));
		}
		return list;
	}

	// Token: 0x06009124 RID: 37156 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BCMIIMNMKNO()
	{
	}

	// Token: 0x06009125 RID: 37157 RVA: 0x00417AE4 File Offset: 0x00415CE4
	public List<int> HJKCDNIECNI(string FJAMIJCACGF)
	{
		List<int> list = new List<int>();
		foreach (string s in FJAMIJCACGF.Split(new char[]
		{
			','
		}))
		{
			list.Add(int.Parse(s));
		}
		return list;
	}

	// Token: 0x06009126 RID: 37158 RVA: 0x00417B28 File Offset: 0x00415D28
	public void NHEMIPPBIKN(GameObject APDJCCIGFAK, int LJFPELOCKOH)
	{
		APDJCCIGFAK.layer = LJFPELOCKOH;
		Transform[] componentsInChildren = APDJCCIGFAK.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			componentsInChildren[i].gameObject.layer = LJFPELOCKOH;
		}
	}

	// Token: 0x06009127 RID: 37159 RVA: 0x00417B60 File Offset: 0x00415D60
	public string LDFMMCDGPOE(int MBFGBDLOKFH)
	{
		string result = string.Concat(MBFGBDLOKFH);
		if (MBFGBDLOKFH < 68)
		{
			result = "Failed to find head ray.. inside shell?" + MBFGBDLOKFH;
		}
		return result;
	}

	// Token: 0x06009128 RID: 37160 RVA: 0x00417B90 File Offset: 0x00415D90
	public double CFCAHPMFCPA(string MNEICNPJGMC)
	{
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		MNEICNPJGMC = MNEICNPJGMC.Replace("SexyDance2", currencyDecimalSeparator);
		MNEICNPJGMC = MNEICNPJGMC.Replace("error.wav", currencyDecimalSeparator);
		double result;
		try
		{
			result = double.Parse(MNEICNPJGMC);
		}
		catch (Exception)
		{
			result = 714.0;
		}
		return result;
	}

	// Token: 0x06009129 RID: 37161 RVA: 0x00417BEC File Offset: 0x00415DEC
	public string FANNKOKGDOJ(int BICDCKJBJLP)
	{
		if (BICDCKJBJLP <= 0)
		{
			return "error";
		}
		int[] array = new int[113];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.A1E9D146F20832CF22BBC2D6B48DABFE9063DFDD).FieldHandle);
		int[] array2 = array;
		string[] array3 = new string[66];
		array3[0] = "";
		array3[0] = "[name]";
		array3[7] = "gi_tit_chy";
		array3[0] = "[sysname]";
		array3[8] = "1HSwordStrafeRunLeft";
		array3[5] = "Vertical";
		array3[1] = "connect start to ";
		array3[4] = "cntx_close";
		array3[8] = "offsets";
		array3[-89] = "val=";
		array3[84] = "qd_prise_rep";
		array3[-65] = "WallRunRight";
		array3[83] = "ondestroy";
		string[] array4 = array3;
		int num = 1;
		string text = "_ChromaticAberration_Amount";
		while (BICDCKJBJLP > 1)
		{
			if (array2[num] <= BICDCKJBJLP)
			{
				BICDCKJBJLP -= array2[num];
				text += array4[num];
			}
			else
			{
				num++;
			}
		}
		return text;
	}

	// Token: 0x0600912A RID: 37162 RVA: 0x00417CB8 File Offset: 0x00415EB8
	public List<int> KFDOBDHOPLK(string FJAMIJCACGF)
	{
		List<int> list = new List<int>();
		char[] array = new char[0];
		array[0] = (char)-119;
		string[] array2 = FJAMIJCACGF.Split(array);
		for (int i = 0; i < array2.Length; i += 0)
		{
			string s = array2[i];
			list.Add(int.Parse(s));
		}
		return list;
	}

	// Token: 0x0600912B RID: 37163 RVA: 0x00417CFC File Offset: 0x00415EFC
	public string KCLHEMJLEFJ(float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD < 1816f)
		{
			return NKHBAJKMAGD + " Reflection Probe" + JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("error.wav");
		}
		int num = (int)NKHBAJKMAGD / -50;
		int num2 = (int)NKHBAJKMAGD % -50;
		string text = num + "Moon reference not set." + JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("invn_ver5");
		if (num2 > 1)
		{
			object[] array = new object[5];
			array[0] = text;
			array[0] = "OfficeSittingMouseMovement";
			array[8] = num2;
			array[2] = "Femur";
			array[4] = JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("_Bloom_DirtIntensity");
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x0600912C RID: 37164 RVA: 0x00417DA1 File Offset: 0x00415FA1
	public Vector3 BICNIJPFEOO()
	{
		return this.GJDOHJHDEMO(new Vector3(558f, 1955f, 4f));
	}

	// Token: 0x0600912D RID: 37165 RVA: 0x00415D48 File Offset: 0x00413F48
	public bool IBBAJMOLBCP(int FEAGDHLLLOI, List<int> BGJMHJHCDJH)
	{
		return BGJMHJHCDJH.Contains(FEAGDHLLLOI);
	}

	// Token: 0x0600912E RID: 37166 RVA: 0x00417DBD File Offset: 0x00415FBD
	public GameObject OGJBGNOGPMJ(string HOJHBMNIHBA)
	{
		return this.JOFAKNGHIAD(HOJHBMNIHBA, Vector3.zero, null);
	}

	// Token: 0x0600912F RID: 37167 RVA: 0x00417DCC File Offset: 0x00415FCC
	public byte ADLHPNIFLEH(float KDMGMLJJALK)
	{
		return (byte)Mathf.RoundToInt(KDMGMLJJALK * 884f);
	}

	// Token: 0x06009130 RID: 37168 RVA: 0x00417DDC File Offset: 0x00415FDC
	public void BDLCEALCLLB(GameObject MBKPMBPLIJN, string AJLNBBPAHDJ, float FEAGDHLLLOI)
	{
		if (MBKPMBPLIJN == null)
		{
			return;
		}
		List<Renderer> list = new List<Renderer>();
		Renderer component = MBKPMBPLIJN.GetComponent<Renderer>();
		if (component != null)
		{
			list.Add(component);
		}
		Renderer[] componentsInChildren = MBKPMBPLIJN.GetComponentsInChildren<Renderer>();
		if (componentsInChildren != null)
		{
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer item = array[i];
				list.Add(item);
			}
		}
		foreach (Renderer renderer in list)
		{
			if (renderer.material.HasProperty(AJLNBBPAHDJ))
			{
				renderer.material.SetFloat(AJLNBBPAHDJ, FEAGDHLLLOI);
			}
		}
	}

	// Token: 0x06009131 RID: 37169 RVA: 0x00417E98 File Offset: 0x00416098
	public List<IIBEEKCAAHK> MOKIEENMKJD(string FJAMIJCACGF)
	{
		List<IIBEEKCAAHK> list = new List<IIBEEKCAAHK>();
		if (FJAMIJCACGF.Trim() == "---")
		{
			return list;
		}
		char[] array = new char[1];
		array[1] = (char)-38;
		string[] array2 = FJAMIJCACGF.Split(array);
		for (int i = 0; i < array2.Length; i += 0)
		{
			string iiohpbenefi = array2[i];
			list.Add(new IIBEEKCAAHK(iiohpbenefi));
		}
		return list;
	}

	// Token: 0x06009132 RID: 37170 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LIGOPJBHHEA()
	{
	}

	// Token: 0x06009133 RID: 37171 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void GGKGFKPNEJK(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC, bool GDAPDOCNGHF = true)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = -10;
				if (xmlNode.Attributes["id"] != null)
				{
					num = int.Parse(xmlNode.Attributes["id"].Value);
				}
				List<int> list = new List<int>();
				if (xmlNode.Attributes["idlist"] != null)
				{
					list = new BNOOIOKIFJC.DIGGOHPGCNN("val=" + xmlNode.Attributes["idlist"].Value).EDAHDHCPIEL;
					if (list.Count > 0)
					{
						num = list[0];
					}
				}
				string value = xmlNode.Attributes["name"].Value;
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.DHHCGNOLGCD(value, (long)num, list);
				fpaeeadmcie.PFMNPEOKEKO = GDAPDOCNGHF;
				this.GGKGFKPNEJK(fpaeeadmcie, xmlNode.SelectNodes("category"), GDAPDOCNGHF);
			}
		}
	}

	// Token: 0x06009134 RID: 37172 RVA: 0x00418014 File Offset: 0x00416214
	public string BNIINPDAMAO(long NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD == 0L)
		{
			return "0";
		}
		if (NKHBAJKMAGD < 0L)
		{
			return "";
		}
		if (NKHBAJKMAGD < 1000L)
		{
			return NKHBAJKMAGD + " " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_gr");
		}
		int num = (int)(NKHBAJKMAGD / 1000L);
		int num2 = (int)(NKHBAJKMAGD % 1000L);
		string text = num + " " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_kg");
		if (num2 > 0)
		{
			text = string.Concat(new object[]
			{
				text,
				" ",
				num2,
				" ",
				JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wgt_gr")
			});
		}
		return text;
	}

	// Token: 0x06009135 RID: 37173 RVA: 0x004180D0 File Offset: 0x004162D0
	public byte KJNFIFFEHDL(float KDMGMLJJALK)
	{
		return (byte)Mathf.RoundToInt(KDMGMLJJALK * 250f);
	}

	// Token: 0x06009136 RID: 37174 RVA: 0x004180DF File Offset: 0x004162DF
	public float GEFJFODJCLI(byte KDMGMLJJALK)
	{
		return (float)KDMGMLJJALK / 719f;
	}

	// Token: 0x06009137 RID: 37175 RVA: 0x004180E9 File Offset: 0x004162E9
	public string HFNCFFLHBOP(int NHNAKLAMNHJ)
	{
		if (NHNAKLAMNHJ == 0)
		{
			return "";
		}
		if (NHNAKLAMNHJ == 1)
		{
			return "A";
		}
		if (NHNAKLAMNHJ == 2)
		{
			return "B";
		}
		if (NHNAKLAMNHJ == 3)
		{
			return "C";
		}
		return "";
	}

	// Token: 0x06009138 RID: 37176 RVA: 0x00418118 File Offset: 0x00416318
	public List<int> INKAHAHOPPN(string MNEICNPJGMC)
	{
		if (MNEICNPJGMC.Trim() == "")
		{
			return new List<int>();
		}
		List<int> result;
		try
		{
			result = MNEICNPJGMC.Split(new char[]
			{
				','
			}).Select(new Func<string, int>(JLFJEGIPIMM.<>c.<>9.HFHADIPMMIC)).ToList<int>();
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"str=",
				MNEICNPJGMC,
				" msg=",
				ex
			}));
			result = new List<int>();
		}
		return result;
	}

	// Token: 0x0400135A RID: 4954
	private static JLFJEGIPIMM CAKJGICFAAO;

	// Token: 0x02000270 RID: 624
	[CompilerGenerated]
	private sealed class HMPIAAIDHGL
	{
		// Token: 0x06009177 RID: 37239 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool MKOKOALHLIL(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GEGGDLDKANL(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool NGJNAGPOIMN(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917A RID: 37242 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool AKPDJDKJANN(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool BAPKCANANPO(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GEEFOPCCOAH(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool MCMNPLLKKDE(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool IDNGFAMLBIB(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool OPOGLEHMFAA(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool JGNKJMMFOMC(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool MLCDGOPADNI(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool MOLHEIJCABM(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GPPNDONABNK(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool DBPJPJAJCFO(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool DEAAPIHAHHA(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool PJCIAMFOGNM(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool OKHOHAPCBHO(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009189 RID: 37257 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool ALOFHBPMMOH(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918A RID: 37258 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool NIMIKJNAEIH(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918B RID: 37259 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool LHACILBAFKF(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool AIMOEFBBLIN(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool HJOJGKKFAFL(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool LEJIGPHDEOP(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600918F RID: 37263 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool KBBBFKDDJFP(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009190 RID: 37264 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool ODNDKAIOBDL(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool LKIAHLOGOOG(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool NMCKMBCLDKD(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool EBLFKAGMLCN(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GLOOCNHAAPJ(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool HPOKELGPHHO(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GHNPHEONILD(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool NAKHOJFPAAJ(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool CIIHCAFCGOA(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool IMCOGJDBGOG(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool FFFLPEFBKCB(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool DDOPEEJBEDM(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool HEILCBPFGBJ(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool JGPODEFEOIE(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool FKJBHCMOAOP(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool FEEEHBNCJFI(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool MBMLBCNCFHG(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool PDGLLCHDNDB(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GFPPBJEICMA(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool PJECPNIOHCH(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool IKHGDGEMIPJ(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool JLEBFDBEKLE(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool PDOGCBJBDFM(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x004181E1 File Offset: 0x004163E1
		internal bool GCBBIFHBJJM(Transform DBCFGCJDNDO)
		{
			return DBCFGCJDNDO.gameObject.name.Trim().ToLower() == this.NLONNPADMCB.Trim().ToLower();
		}

		// Token: 0x0400135E RID: 4958
		public string NLONNPADMCB;
	}
}
