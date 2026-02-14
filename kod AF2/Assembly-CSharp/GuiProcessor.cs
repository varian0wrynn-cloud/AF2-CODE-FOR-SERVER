using System;
using System.Collections;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000193 RID: 403
public class GuiProcessor : MonoBehaviour
{
	// Token: 0x06005975 RID: 22901 RVA: 0x002AA676 File Offset: 0x002A8876
	public void AIBAHOEOHOE(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x06005976 RID: 22902 RVA: 0x002AA69A File Offset: 0x002A889A
	public void ENHGGEIANJC(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.KGNCELFGIMB(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x00022FCC File Offset: 0x000211CC
	public void HLIJCMMNKPI()
	{
	}

	// Token: 0x06005978 RID: 22904 RVA: 0x002AA6AC File Offset: 0x002A88AC
	private void ELLJEHHACHL()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = false;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.OnPostGUI();
		JDCEFOFMGHB.HMJJPNDEKPP().POFHKNCEHKF();
		MDEKJCCIDIA.IKGFHGKKCPG.ANFHJIIMJNL();
		JDCEFOFMGHB.IKGFHGKKCPG.FGEIDOBFJMA();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = false;
		guistyle.richText = false;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		guistyle.fontSize = -40;
		if (JDCEFOFMGHB.JFIDAGABKID().PMPGJJJAPPG > 45f)
		{
			Color color = GUI.color;
			GUI.color = new Color(816f, 1982f, 118f, JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(739f, 244f, (float)(Screen.width + 37), (float)(Screen.height + 19)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x06005979 RID: 22905 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FJLCKKELKLM()
	{
	}

	// Token: 0x0600597A RID: 22906 RVA: 0x002AA7CC File Offset: 0x002A89CC
	private void OnGUI()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = false;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.OnPostGUI();
		JDCEFOFMGHB.IKGFHGKKCPG.ANFHJIIMJNL();
		MDEKJCCIDIA.IKGFHGKKCPG.ANFHJIIMJNL();
		JDCEFOFMGHB.IKGFHGKKCPG.FGEIDOBFJMA();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = true;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		guistyle.fontSize = 14;
		if (JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG > 0f)
		{
			Color color = GUI.color;
			GUI.color = new Color(0f, 0f, 0f, JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(-5f, -5f, (float)(Screen.width + 10), (float)(Screen.height + 10)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x0600597B RID: 22907 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform IHFGNALNJOG()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x0600597C RID: 22908 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
	private IEnumerator HONBDCCDDHF()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield break;
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x002AA69A File Offset: 0x002A889A
	public void NKGKIFELLGH(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.KGNCELFGIMB(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x002AA676 File Offset: 0x002A8876
	public void NDJJPEEGFPG(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x0600597F RID: 22911 RVA: 0x002AA8FC File Offset: 0x002A8AFC
	private void KBAJMMCHDOC()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = false;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.CBEFKGBCAHK();
		JDCEFOFMGHB.IKGFHGKKCPG.ANFHJIIMJNL();
		MDEKJCCIDIA.IKGFHGKKCPG.ANFHJIIMJNL();
		JDCEFOFMGHB.MNJNNDHCDGG().HMCHFIOABPB();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = false;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
		guistyle.fontSize = 45;
		if (JDCEFOFMGHB.HMJJPNDEKPP().PMPGJJJAPPG > 200f)
		{
			Color color = GUI.color;
			GUI.color = new Color(1021f, 9f, 1888f, JDCEFOFMGHB.MNJNNDHCDGG().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(997f, 691f, (float)(Screen.width + 124), (float)(Screen.height + -54)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x002AAA1C File Offset: 0x002A8C1C
	private static IEnumerator KGNCELFGIMB(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = false;
		}
		yield return new WaitForSeconds(FGNPJLIPNFM);
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = true;
		}
		yield break;
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool DHIKIGNAMNM()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x002AAA3C File Offset: 0x002A8C3C
	private void GHCMIKGJPJD()
	{
		SpeedHackDetector.OELLJBDJMLO(new UnityAction(this.HJDENHGOGAP), 1577f);
		HFIINBICCLO.JFNBEACKGKI().LILKJKNMCDK();
		IFPIMPMKJIB.BOIOCDEHDAE();
		JNBICAJIJMM.EKEBHIJMEML().JOGHFKDCNLL();
		IHFEDJEMJMB.OELKEADDKPE().OLEEAIFGCOM();
		ColorGradingModel.Settings settings = this.profileHi.colorGrading.settings;
		settings.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		settings.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		settings.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.KHEABCCDEFA(settings);
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x002AA676 File Offset: 0x002A8876
	public void AAOEDHIKPAC(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	private static void FLLEMJMGKHL(GuiProcessor DCCPCBLODIG)
	{
		GuiProcessor.<ONBFNIBJLPL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x002AAAEE File Offset: 0x002A8CEE
	public void waitButtonEvent(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.LHGNPCFCJPD(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool EFNHFKIEKGC()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x002AAAFE File Offset: 0x002A8CFE
	public void AABBIKNCPII(ONKDCGNBALK JMAKEAHMLMI)
	{
		Application.Quit();
	}

	// Token: 0x06005988 RID: 22920 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator APMMOACELIL()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x002AAB0D File Offset: 0x002A8D0D
	public static GuiProcessor PLGADNLAEGN()
	{
		return GuiProcessor.<ONBFNIBJLPL>k__BackingField;
	}

	// Token: 0x0600598A RID: 22922 RVA: 0x002AAB14 File Offset: 0x002A8D14
	public void ABLEBLIMPBG(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.DDOADDLPKOJ(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x0600598B RID: 22923 RVA: 0x002AAB24 File Offset: 0x002A8D24
	public void DEGLLJMBIPI(ONKDCGNBALK JMAKEAHMLMI)
	{
		FlyMessageManager.getI.GIKDOPKMPEG();
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-12, 1);
	}

	// Token: 0x0600598C RID: 22924 RVA: 0x002AA676 File Offset: 0x002A8876
	public void KCKDDJJGAIP(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x0600598D RID: 22925 RVA: 0x002AAA32 File Offset: 0x002A8C32
	// (set) Token: 0x060059CD RID: 22989 RVA: 0x002AA676 File Offset: 0x002A8876
	public bool ILPMJMCKBIG
	{
		get
		{
			return this.OMOBPIHKDCF;
		}
		set
		{
			this.OMOBPIHKDCF = value;
			GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		}
	}

	// Token: 0x0600598E RID: 22926 RVA: 0x002AAB14 File Offset: 0x002A8D14
	public void BBKLEKGGDDB(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.DDOADDLPKOJ(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x0600598F RID: 22927 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public void FJLPFLCJMPE(RectTransform DCCPCBLODIG)
	{
		this.<GBEMEJPDDJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x002AAB46 File Offset: 0x002A8D46
	public void LHGDILAJMIE(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.AOAKGIDHANF(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x06005991 RID: 22929 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool HFJGFLJEHLL()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x06005992 RID: 22930 RVA: 0x002AAB56 File Offset: 0x002A8D56
	public void GKGBKIMGHMI()
	{
		SceneManager.LoadScene(8);
	}

	// Token: 0x06005993 RID: 22931 RVA: 0x002AAB60 File Offset: 0x002A8D60
	public void sendMsg(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	private static void BPBGGJDOFJD(GuiProcessor DCCPCBLODIG)
	{
		GuiProcessor.<ONBFNIBJLPL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool CLIBACHNKKD()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x06005996 RID: 22934 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LIOHFKBBNML()
	{
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x002AAB90 File Offset: 0x002A8D90
	private void DJIFJMEEBKA()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 1)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.FLLEMJMGKHL(this);
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x002AAAEE File Offset: 0x002A8CEE
	public void BIJCEOBALNE(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.LHGNPCFCJPD(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x06005999 RID: 22937 RVA: 0x002AABDC File Offset: 0x002A8DDC
	public void BPGHPGOJBAF(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x002AA676 File Offset: 0x002A8876
	public void BODBOOMPFEK(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public void CGKGBPLODOJ(RectTransform DCCPCBLODIG)
	{
		this.<GBEMEJPDDJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600599C RID: 22940 RVA: 0x002AAC0C File Offset: 0x002A8E0C
	private void ECOOMJKPKCC()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 0)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.FLLEMJMGKHL(this);
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x0600599D RID: 22941 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	// (set) Token: 0x0600599E RID: 22942 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public RectTransform BJBJKLMJLCA { get; set; }

	// Token: 0x0600599F RID: 22943 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator CBKOPOBCGAC()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x060059A0 RID: 22944 RVA: 0x002AAC58 File Offset: 0x002A8E58
	private void POHHBKCLBGC()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = true;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.FHKCHOLADPC();
		JDCEFOFMGHB.IKGFHGKKCPG.BIOKMDIGOIA();
		MDEKJCCIDIA.IKGFHGKKCPG.CGBKGPPNMNM();
		JDCEFOFMGHB.IKGFHGKKCPG.FGEIDOBFJMA();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = false;
		guistyle.richText = false;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		guistyle.fontSize = -91;
		if (JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG > 1084f)
		{
			Color color = GUI.color;
			GUI.color = new Color(1678f, 1351f, 1186f, JDCEFOFMGHB.JFIDAGABKID().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(976f, 794f, (float)(Screen.width + 2), (float)(Screen.height + -17)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x060059A1 RID: 22945 RVA: 0x00022FCC File Offset: 0x000211CC
	public void APMGPNOOHEN()
	{
	}

	// Token: 0x060059A2 RID: 22946 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform NBMOILGEJIP()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x060059A3 RID: 22947 RVA: 0x002AAB0D File Offset: 0x002A8D0D
	public static GuiProcessor BBLINJLBAIL()
	{
		return GuiProcessor.<ONBFNIBJLPL>k__BackingField;
	}

	// Token: 0x060059A4 RID: 22948 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool FLGLKEKOKPM()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x060059A5 RID: 22949 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
	private IEnumerator FMKBGJLJAFD()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield break;
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
	private IEnumerator BDDBDPJOBPC()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield break;
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x002AAD78 File Offset: 0x002A8F78
	public void IDPKGCKDHLF()
	{
		SceneManager.LoadScene(5);
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x002AAD80 File Offset: 0x002A8F80
	private void GHOBHBMFKHN()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().FANPFKHEDPA();
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 0)
			{
				if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN[JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count - 1].KNNIPIEENII)
				{
					JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 0].LPFKFNLHGBI);
					return;
				}
			}
			else
			{
				Debug.Log("****** locid=" + Application.loadedLevel);
				if (Application.loadedLevel <= 0)
				{
					JDCEFOFMGHB.JFIDAGABKID().CLADNJHAABI(JNBICAJIJMM.NGALDMFKMJH("_AllowBackwardsRays"), JNBICAJIJMM.PGJCPFNJNPM("FaceHit"), new ONKDCGNBALK.CMMHGMILOIM(this.NCHOMOBJBBP), null);
					return;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.CLADNJHAABI(JNBICAJIJMM.BDKHMOOFHHK("Brow"), JNBICAJIJMM.PGJCPFNJNPM("EndPhysPoint"), new ONKDCGNBALK.CMMHGMILOIM(this.LICPDJICIGN), null);
			}
		}
	}

	// Token: 0x060059A9 RID: 22953 RVA: 0x002AA69A File Offset: 0x002A889A
	public void FHBHIMMIOKO(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.KGNCELFGIMB(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x060059AA RID: 22954 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool KCHGPHCHJAE()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x060059AB RID: 22955 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public void CPDHMBFPGMD(RectTransform DCCPCBLODIG)
	{
		this.<GBEMEJPDDJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x00022FCC File Offset: 0x000211CC
	public void JFKHMNDNOEO()
	{
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public void EOPEPOJNLNF(RectTransform DCCPCBLODIG)
	{
		this.<GBEMEJPDDJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059AE RID: 22958 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform CFAEHFDAGCF()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x060059AF RID: 22959 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	private static void CDMBOPJMIDC(GuiProcessor DCCPCBLODIG)
	{
		GuiProcessor.<ONBFNIBJLPL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059B0 RID: 22960 RVA: 0x002AAE87 File Offset: 0x002A9087
	public void BJMPMBFOIDC(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.PAADCIGLEDL(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x060059B1 RID: 22961 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator MOMEOJGHGOG()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x060059B2 RID: 22962 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IOMMJHGKNKC()
	{
	}

	// Token: 0x060059B3 RID: 22963 RVA: 0x002AAE97 File Offset: 0x002A9097
	public Canvas MFCDGFKODCM()
	{
		return this.DMHPCBHMNHC().GetComponent<Canvas>();
	}

	// Token: 0x060059B4 RID: 22964 RVA: 0x002AAEA4 File Offset: 0x002A90A4
	private void JJLABCFMMGC()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = true;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = true;
		FlyMessageManager.getI.KMFCOAHIFDM();
		JDCEFOFMGHB.HMJJPNDEKPP().BIOKMDIGOIA();
		MDEKJCCIDIA.IKGFHGKKCPG.ANFHJIIMJNL();
		JDCEFOFMGHB.MNJNNDHCDGG().OHLLAFIKIKC();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = true;
		guistyle.richText = false;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		guistyle.fontSize = 39;
		if (JDCEFOFMGHB.HMJJPNDEKPP().PMPGJJJAPPG > 1295f)
		{
			Color color = GUI.color;
			GUI.color = new Color(410f, 1100f, 1431f, JDCEFOFMGHB.MNJNNDHCDGG().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(618f, 944f, (float)(Screen.width + -93), (float)(Screen.height + 4)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x060059B5 RID: 22965 RVA: 0x002AAA1C File Offset: 0x002A8C1C
	private static IEnumerator HIDCICDHCPK(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = false;
		}
		yield return new WaitForSeconds(FGNPJLIPNFM);
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = true;
		}
		yield break;
	}

	// Token: 0x060059B6 RID: 22966 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform PBBAIBBHMHG()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x060059B7 RID: 22967 RVA: 0x002AAFC4 File Offset: 0x002A91C4
	private void HBPAAFPALJM()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = false;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = true;
		FlyMessageManager.getI.CBEFKGBCAHK();
		JDCEFOFMGHB.MNJNNDHCDGG().BCJFDHBDAHD();
		MDEKJCCIDIA.IKGFHGKKCPG.CGBKGPPNMNM();
		JDCEFOFMGHB.HMJJPNDEKPP().HMCHFIOABPB();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = true;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		guistyle.fontSize = 95;
		if (JDCEFOFMGHB.JFIDAGABKID().PMPGJJJAPPG > 1231f)
		{
			Color color = GUI.color;
			GUI.color = new Color(583f, 1236f, 1921f, JDCEFOFMGHB.MNJNNDHCDGG().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(1511f, 806f, (float)(Screen.width + 122), (float)(Screen.height + -73)), this.blackWait, ScaleMode.StretchToFill);
			GUI.color = color;
		}
	}

	// Token: 0x060059B8 RID: 22968 RVA: 0x002AB0E4 File Offset: 0x002A92E4
	public Canvas IBONNINGOOJ()
	{
		return this.NBMOILGEJIP().GetComponent<Canvas>();
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform DMHPCBHMNHC()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060059BA RID: 22970 RVA: 0x002AB0F1 File Offset: 0x002A92F1
	public Canvas FCNJIFHIGEH
	{
		get
		{
			return this.BJBJKLMJLCA.GetComponent<Canvas>();
		}
	}

	// Token: 0x060059BB RID: 22971 RVA: 0x002AB100 File Offset: 0x002A9300
	private void GCNGEFBKMNC()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().FANPFKHEDPA();
		if (Input.GetKeyDown((KeyCode)(-95)))
		{
			if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 1)
			{
				if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN[JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count - 0].KNNIPIEENII)
				{
					JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN[JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count - 1].LPFKFNLHGBI);
					return;
				}
			}
			else
			{
				Debug.Log("_DepthCurveLut" + Application.loadedLevel);
				if (Application.loadedLevel <= 8)
				{
					JDCEFOFMGHB.JFIDAGABKID().IGBJKJFAGKN(JNBICAJIJMM.DIOJFJMOPJO("{"), JNBICAJIJMM.BDKHMOOFHHK("wpn_add/use_effect/effect"), new ONKDCGNBALK.CMMHGMILOIM(this.yesProc), null);
					return;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.HJJKHHHLDAJ(JNBICAJIJMM.OOOKJHOHPNN("wpn_eat7"), JNBICAJIJMM.LEBHCLDODNI("gi_cachfish"), new ONKDCGNBALK.CMMHGMILOIM(this.ALLALFJPNCB), null);
			}
		}
	}

	// Token: 0x060059BC RID: 22972 RVA: 0x002AB208 File Offset: 0x002A9408
	private void EHDPACPIBNF()
	{
		SpeedHackDetector.IDPAPOGIOGC(new UnityAction(this.CKDIOHJKILH), 1148f);
		HFIINBICCLO.OOIJFNAMEDP().NCCENLBOIDK();
		IFPIMPMKJIB.BOIOCDEHDAE();
		JNBICAJIJMM.DBMJJPBOPEK().HLKMNAGCFOM();
		IHFEDJEMJMB.AGCBLDIBMNB().NKPIKHPNDAN();
		ColorGradingModel.Settings settings = this.profileHi.colorGrading.LIKDNAJFKMN();
		settings.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		settings.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		settings.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.settings = settings;
	}

	// Token: 0x060059BD RID: 22973 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
	private IEnumerator IPFJLJNLMMG()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield break;
	}

	// Token: 0x060059BE RID: 22974 RVA: 0x002AB0F1 File Offset: 0x002A92F1
	public Canvas PIGELALHFHC()
	{
		return this.BJBJKLMJLCA.GetComponent<Canvas>();
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x002AB2B2 File Offset: 0x002A94B2
	public Canvas FFAMHHPLDMP()
	{
		return this.PBBAIBBHMHG().GetComponent<Canvas>();
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x002AAA1C File Offset: 0x002A8C1C
	private static IEnumerator AOAKGIDHANF(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = false;
		}
		yield return new WaitForSeconds(FGNPJLIPNFM);
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = true;
		}
		yield break;
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	private static void GLEEGJNNBPN(GuiProcessor DCCPCBLODIG)
	{
		GuiProcessor.<ONBFNIBJLPL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059C2 RID: 22978 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
	private IEnumerator CHBCMFMFHKJ()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield break;
	}

	// Token: 0x060059C3 RID: 22979 RVA: 0x002AB2BF File Offset: 0x002A94BF
	public void ICPMIHKEJHP(ONKDCGNBALK JMAKEAHMLMI)
	{
		FlyMessageManager.getI.CFGDGKHCFPP();
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(71, 0);
	}

	// Token: 0x060059C4 RID: 22980 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BBBAMBKDOMN()
	{
	}

	// Token: 0x060059C5 RID: 22981 RVA: 0x002AB2D8 File Offset: 0x002A94D8
	public void KJPHBLCGIJN()
	{
		SceneManager.LoadScene(4);
	}

	// Token: 0x060059C7 RID: 22983 RVA: 0x002AAD78 File Offset: 0x002A8F78
	public void NNMEENDNCPD()
	{
		SceneManager.LoadScene(5);
	}

	// Token: 0x060059C8 RID: 22984 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool BKCPKLPNJMI()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x060059C9 RID: 22985 RVA: 0x002AB2F0 File Offset: 0x002A94F0
	private void MJBLMFLLMAG()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = false;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.CBEFKGBCAHK();
		JDCEFOFMGHB.JFIDAGABKID().BIOKMDIGOIA();
		MDEKJCCIDIA.IKGFHGKKCPG.CGBKGPPNMNM();
		JDCEFOFMGHB.HMJJPNDEKPP().OHLLAFIKIKC();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.wordWrap = true;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
		guistyle.fontSize = -43;
		if (JDCEFOFMGHB.JFIDAGABKID().PMPGJJJAPPG > 1553f)
		{
			Color color = GUI.color;
			GUI.color = new Color(1231f, 49f, 944f, JDCEFOFMGHB.MNJNNDHCDGG().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(716f, 1789f, (float)(Screen.width + 10), (float)(Screen.height + -86)), this.blackWait, ScaleMode.ScaleAndCrop);
			GUI.color = color;
		}
	}

	// Token: 0x060059CA RID: 22986 RVA: 0x002AB410 File Offset: 0x002A9610
	public void ALLALFJPNCB(ONKDCGNBALK JMAKEAHMLMI)
	{
		FlyMessageManager.getI.KJOJGONGLHA();
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(6, 0);
	}

	// Token: 0x060059CB RID: 22987 RVA: 0x002AB429 File Offset: 0x002A9629
	public void HJDENHGOGAP()
	{
		SceneManager.LoadScene(7);
	}

	// Token: 0x060059CC RID: 22988 RVA: 0x002AAA1C File Offset: 0x002A8C1C
	private static IEnumerator LHGNPCFCJPD(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = false;
		}
		yield return new WaitForSeconds(FGNPJLIPNFM);
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = true;
		}
		yield break;
	}

	// Token: 0x060059CE RID: 22990 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OnPostRender()
	{
	}

	// Token: 0x060059CF RID: 22991 RVA: 0x002AB431 File Offset: 0x002A9631
	public void yesProcSelPers(ONKDCGNBALK JMAKEAHMLMI)
	{
		FlyMessageManager.getI.clearFlyIcons();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(110, 0);
	}

	// Token: 0x060059D0 RID: 22992 RVA: 0x002AB44C File Offset: 0x002A964C
	private void OFGMIEJKMGC()
	{
		SpeedHackDetector.DGCOLOFHOFF(new UnityAction(this.IDPKGCKDHLF), 1081f);
		HFIINBICCLO.KPGHCNPGAGL().NCCENLBOIDK();
		IFPIMPMKJIB.ODONNAANIEP();
		JNBICAJIJMM.EEOPOHEALPK().CHMOEIHFKGA();
		IHFEDJEMJMB.EDKKJNHDBPF().OLEEAIFGCOM();
		ColorGradingModel.Settings dccpcblodig = this.profileHi.colorGrading.AEIDMBILAPI();
		dccpcblodig.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		dccpcblodig.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		dccpcblodig.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.KHEABCCDEFA(dccpcblodig);
	}

	// Token: 0x060059D1 RID: 22993 RVA: 0x002AAB3D File Offset: 0x002A8D3D
	public void AMFFCIKGJKJ(RectTransform DCCPCBLODIG)
	{
		this.<GBEMEJPDDJP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059D2 RID: 22994 RVA: 0x002AB4F8 File Offset: 0x002A96F8
	private void AGBEEDOOOHA()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = true;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = true;
		FlyMessageManager.getI.EBOGIFODNAL();
		JDCEFOFMGHB.MNJNNDHCDGG().BCJFDHBDAHD();
		MDEKJCCIDIA.IKGFHGKKCPG.CGBKGPPNMNM();
		JDCEFOFMGHB.MNJNNDHCDGG().FGEIDOBFJMA();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.wordWrap = false;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		guistyle.fontSize = -5;
		if (JDCEFOFMGHB.JFIDAGABKID().PMPGJJJAPPG > 1590f)
		{
			Color color = GUI.color;
			GUI.color = new Color(597f, 900f, 323f, JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(1325f, 553f, (float)(Screen.width + -95), (float)(Screen.height + 67)), this.blackWait, ScaleMode.ScaleAndCrop);
			GUI.color = color;
		}
	}

	// Token: 0x060059D3 RID: 22995 RVA: 0x002AB618 File Offset: 0x002A9818
	private void Awake()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 1)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.IKGFHGKKCPG = this;
	}

	// Token: 0x060059D4 RID: 22996 RVA: 0x002AAAEE File Offset: 0x002A8CEE
	public void AIFPLBGDIEL(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.LHGNPCFCJPD(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x060059D5 RID: 22997 RVA: 0x002AA676 File Offset: 0x002A8876
	public void HLPFHHOLBJO(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x060059D6 RID: 22998 RVA: 0x002AAAFE File Offset: 0x002A8CFE
	public void NCHOMOBJBBP(ONKDCGNBALK JMAKEAHMLMI)
	{
		Application.Quit();
	}

	// Token: 0x060059D7 RID: 22999 RVA: 0x002AA676 File Offset: 0x002A8876
	public void KHCOMIMLMDN(bool DCCPCBLODIG)
	{
		this.OMOBPIHKDCF = DCCPCBLODIG;
		GUI.skin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
	}

	// Token: 0x060059D8 RID: 23000 RVA: 0x002AAB56 File Offset: 0x002A8D56
	public void HOAFOOBNION()
	{
		SceneManager.LoadScene(8);
	}

	// Token: 0x060059D9 RID: 23001 RVA: 0x002AAA1C File Offset: 0x002A8C1C
	private static IEnumerator PAADCIGLEDL(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = false;
		}
		yield return new WaitForSeconds(FGNPJLIPNFM);
		if (GACACKNJKJN != null)
		{
			GACACKNJKJN.interactable = true;
		}
		yield break;
	}

	// Token: 0x060059DA RID: 23002 RVA: 0x002AB661 File Offset: 0x002A9861
	public Canvas FONMMHHPEMC()
	{
		return this.OODKDLPBAIP().GetComponent<Canvas>();
	}

	// Token: 0x060059DB RID: 23003 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	private static void OLCBJOEODAD(GuiProcessor DCCPCBLODIG)
	{
		GuiProcessor.<ONBFNIBJLPL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060059DC RID: 23004 RVA: 0x002AB670 File Offset: 0x002A9870
	public void NEICJPPCPEH(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x060059DD RID: 23005 RVA: 0x002AB661 File Offset: 0x002A9861
	public Canvas KFLFCLOABJF()
	{
		return this.OODKDLPBAIP().GetComponent<Canvas>();
	}

	// Token: 0x060059DE RID: 23006 RVA: 0x002AB6A0 File Offset: 0x002A98A0
	private void BMNJGPIPKLL()
	{
		SpeedHackDetector.DGCOLOFHOFF(new UnityAction(this.GKGBKIMGHMI), 387f);
		HFIINBICCLO.LLEDCIHMOHI().HHFMCEGDDMD();
		IFPIMPMKJIB.BPOGJLNHPDP();
		JNBICAJIJMM.IKGFHGKKCPG.IOKEEJELBCG();
		IHFEDJEMJMB.NNEAHAFBOHC().OLEEAIFGCOM();
		ColorGradingModel.Settings dccpcblodig = this.profileHi.colorGrading.DGMJHJDFFAA();
		dccpcblodig.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		dccpcblodig.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		dccpcblodig.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.KHEABCCDEFA(dccpcblodig);
	}

	// Token: 0x060059DF RID: 23007 RVA: 0x002AAB56 File Offset: 0x002A8D56
	public void SHDetectEvent()
	{
		SceneManager.LoadScene(8);
	}

	// Token: 0x060059E0 RID: 23008 RVA: 0x002AB74C File Offset: 0x002A994C
	private void Update()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.FANPFKHEDPA();
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
			{
				if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].KNNIPIEENII)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI);
					return;
				}
			}
			else
			{
				Debug.Log("loadedLevel=" + Application.loadedLevel);
				if (Application.loadedLevel <= 2)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.LEBHCLDODNI("exitmsg_3"), JNBICAJIJMM.LEBHCLDODNI("exitmsg_1"), new ONKDCGNBALK.CMMHGMILOIM(this.yesProc), null);
					return;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.LEBHCLDODNI("exitmsg_3"), JNBICAJIJMM.LEBHCLDODNI("exitmsg_2"), new ONKDCGNBALK.CMMHGMILOIM(this.yesProcSelPers), null);
			}
		}
	}

	// Token: 0x060059E1 RID: 23009 RVA: 0x002AAAFE File Offset: 0x002A8CFE
	public void IGJPGDCKMPK(ONKDCGNBALK JMAKEAHMLMI)
	{
		Application.Quit();
	}

	// Token: 0x060059E2 RID: 23010 RVA: 0x002AB853 File Offset: 0x002A9A53
	public void CJFNCADFPMJ()
	{
		SceneManager.LoadScene(0);
	}

	// Token: 0x060059E3 RID: 23011 RVA: 0x002AB85C File Offset: 0x002A9A5C
	public void MMGFMLOJKMD(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x060059E4 RID: 23012 RVA: 0x002AB88C File Offset: 0x002A9A8C
	private static IEnumerator DDOADDLPKOJ(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		GuiProcessor.HLPDOMLGEOG hlpdomlgeog = new GuiProcessor.HLPDOMLGEOG(1);
		hlpdomlgeog.GACACKNJKJN = GACACKNJKJN;
		hlpdomlgeog.FGNPJLIPNFM = FGNPJLIPNFM;
		return hlpdomlgeog;
	}

	// Token: 0x060059E5 RID: 23013 RVA: 0x002AB8A4 File Offset: 0x002A9AA4
	public void CNKIDEAKBIC(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x060059E6 RID: 23014 RVA: 0x002AB8D4 File Offset: 0x002A9AD4
	public void LICPDJICIGN(ONKDCGNBALK JMAKEAHMLMI)
	{
		FlyMessageManager.getI.KJOJGONGLHA();
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(37, 0);
	}

	// Token: 0x060059E7 RID: 23015 RVA: 0x002AB8F0 File Offset: 0x002A9AF0
	private void MAGJOJDOGKH()
	{
		SpeedHackDetector.IDPAPOGIOGC(new UnityAction(this.HOAFOOBNION), 407f);
		HFIINBICCLO.GICMOPPKLPC().NCCENLBOIDK();
		IFPIMPMKJIB.NMKBGMBCHCH();
		JNBICAJIJMM.APMJBBDBOJO().DHKFJABPKCB();
		IHFEDJEMJMB.NNEAHAFBOHC().ODONNAANIEP();
		ColorGradingModel.Settings dccpcblodig = this.profileHi.colorGrading.DGMJHJDFFAA();
		dccpcblodig.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		dccpcblodig.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		dccpcblodig.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.CKFGDLGJIGF(dccpcblodig);
	}

	// Token: 0x060059E8 RID: 23016 RVA: 0x002AB99C File Offset: 0x002A9B9C
	private void DIENOIPCCDE()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 0)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.GLEEGJNNBPN(this);
	}

	// Token: 0x060059E9 RID: 23017 RVA: 0x002AB9E8 File Offset: 0x002A9BE8
	private void CCPOIOJPKIF()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 0)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.OLCBJOEODAD(this);
	}

	// Token: 0x060059EA RID: 23018 RVA: 0x002ABA34 File Offset: 0x002A9C34
	private void Start()
	{
		SpeedHackDetector.StartDetection(new UnityAction(this.SHDetectEvent), 10f);
		HFIINBICCLO.IKGFHGKKCPG.ODONNAANIEP();
		IFPIMPMKJIB.ODONNAANIEP();
		JNBICAJIJMM.IKGFHGKKCPG.PINLMCCKKNA();
		IHFEDJEMJMB.IKGFHGKKCPG.ODONNAANIEP();
		ColorGradingModel.Settings settings = this.profileHi.colorGrading.settings;
		settings.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		settings.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		settings.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.settings = settings;
	}

	// Token: 0x060059EB RID: 23019 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator OMGJGKJLCMD()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x060059EC RID: 23020 RVA: 0x002AAAFE File Offset: 0x002A8CFE
	public void HKHCOAJAKGF(ONKDCGNBALK JMAKEAHMLMI)
	{
		Application.Quit();
	}

	// Token: 0x060059ED RID: 23021 RVA: 0x002ABAE0 File Offset: 0x002A9CE0
	public void IHAEJIOFFED(string HKPOHOONCIO)
	{
		Transform[] array = UnityEngine.Object.FindObjectsOfType<Transform>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].gameObject.SendMessage(HKPOHOONCIO, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x060059EE RID: 23022 RVA: 0x002AAAFE File Offset: 0x002A8CFE
	public void yesProc(ONKDCGNBALK JMAKEAHMLMI)
	{
		Application.Quit();
	}

	// Token: 0x060059EF RID: 23023 RVA: 0x002ABB10 File Offset: 0x002A9D10
	public void CKDIOHJKILH()
	{
		SceneManager.LoadScene(2);
	}

	// Token: 0x060059F0 RID: 23024 RVA: 0x002AAA32 File Offset: 0x002A8C32
	public bool KFKDLKHNKLO()
	{
		return this.OMOBPIHKDCF;
	}

	// Token: 0x060059F1 RID: 23025 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ECCLLLNEDBI()
	{
	}

	// Token: 0x060059F2 RID: 23026 RVA: 0x002ABB18 File Offset: 0x002A9D18
	private void ENCHIIJEJDL()
	{
		this.currentSkin = (this.OMOBPIHKDCF ? this.activeSkin : this.alterSkin);
		GUI.skin = this.currentSkin;
		MDEKJCCIDIA.IKGFHGKKCPG.IHNJOHJCBMK = true;
		MDEKJCCIDIA.IKGFHGKKCPG.ABLFGLMKPNO = false;
		FlyMessageManager.getI.ECKEELDFGBH();
		JDCEFOFMGHB.JFIDAGABKID().BIOKMDIGOIA();
		MDEKJCCIDIA.IKGFHGKKCPG.ANFHJIIMJNL();
		JDCEFOFMGHB.IKGFHGKKCPG.HMCHFIOABPB();
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = true;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont3;
		guistyle.fontSize = -61;
		if (JDCEFOFMGHB.IKGFHGKKCPG.PMPGJJJAPPG > 1937f)
		{
			Color color = GUI.color;
			GUI.color = new Color(889f, 768f, 745f, JDCEFOFMGHB.HMJJPNDEKPP().PMPGJJJAPPG);
			GUI.DrawTexture(new Rect(1916f, 1643f, (float)(Screen.width + -33), (float)(Screen.height + 91)), this.blackWait, ScaleMode.ScaleAndCrop);
			GUI.color = color;
		}
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x002ABC38 File Offset: 0x002A9E38
	public Canvas JNBELHHOBHB()
	{
		return this.IHFGNALNJOG().GetComponent<Canvas>();
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x002AAB0D File Offset: 0x002A8D0D
	public static GuiProcessor NKOEAPCIBKO()
	{
		return GuiProcessor.<ONBFNIBJLPL>k__BackingField;
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x002AAB46 File Offset: 0x002A8D46
	public void LPHICPHIKKL(Selectable GACACKNJKJN, float FGNPJLIPNFM)
	{
		base.StartCoroutine(GuiProcessor.AOAKGIDHANF(GACACKNJKJN, FGNPJLIPNFM));
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x002ABC48 File Offset: 0x002A9E48
	private void HDGNIHBIEDG()
	{
		SpeedHackDetector.IDPAPOGIOGC(new UnityAction(this.IDPKGCKDHLF), 1637f);
		HFIINBICCLO.IKGFHGKKCPG.NCCENLBOIDK();
		IFPIMPMKJIB.BPOGJLNHPDP();
		JNBICAJIJMM.LPHMKPDBMPP().PFMONFAKHBK();
		IHFEDJEMJMB.AGCBLDIBMNB().OLEEAIFGCOM();
		ColorGradingModel.Settings dccpcblodig = this.profileHi.colorGrading.EBGFGEIIDNM();
		dccpcblodig.basic.saturation = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		dccpcblodig.basic.contrast = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
		dccpcblodig.basic.postExposure = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
		this.profileHi.colorGrading.KHEABCCDEFA(dccpcblodig);
	}

	// Token: 0x060059F7 RID: 23031 RVA: 0x002ABCF4 File Offset: 0x002A9EF4
	private void DPNNENHAGOE()
	{
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(base.GetType());
		if (array != null && array.Length > 1)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		GuiProcessor.CDMBOPJMIDC(this);
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x002AA8EC File Offset: 0x002A8AEC
	public RectTransform OODKDLPBAIP()
	{
		return this.<GBEMEJPDDJP>k__BackingField;
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x060059F9 RID: 23033 RVA: 0x002AAB0D File Offset: 0x002A8D0D
	// (set) Token: 0x060059FB RID: 23035 RVA: 0x002AAAE6 File Offset: 0x002A8CE6
	public static GuiProcessor IKGFHGKKCPG { get; private set; }

	// Token: 0x060059FA RID: 23034 RVA: 0x002AB0F1 File Offset: 0x002A92F1
	public Canvas BAOFMKDAFMN()
	{
		return this.BJBJKLMJLCA.GetComponent<Canvas>();
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator MEHHPCHIHPP()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FJAMDJFIEGM()
	{
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x002AAB05 File Offset: 0x002A8D05
	private IEnumerator MBKGNPBJDKI()
	{
		return new GuiProcessor.LPHOELKAJPD(1);
	}

	// Token: 0x04000D54 RID: 3412
	public Texture amplyWaterLUT;

	// Token: 0x04000D55 RID: 3413
	public float amplyWaterExpr;

	// Token: 0x04000D56 RID: 3414
	public Shader blurShader;

	// Token: 0x04000D57 RID: 3415
	public PostProcessingProfile profileHi;

	// Token: 0x04000D58 RID: 3416
	public Sprite[] qualityBackgrounds;

	// Token: 0x04000D59 RID: 3417
	public Color[] lineColors;

	// Token: 0x04000D5A RID: 3418
	public Texture closeKeyTex;

	// Token: 0x04000D5B RID: 3419
	public Texture vipKeyTex;

	// Token: 0x04000D5C RID: 3420
	public AnimationCurve soundDefaultCurve;

	// Token: 0x04000D5D RID: 3421
	public AnimationCurve reelTensionCurve;

	// Token: 0x04000D5E RID: 3422
	public AnimationCurve reelSpdTensionCurve;

	// Token: 0x04000D5F RID: 3423
	public AnimationCurve reelFrcTensionCurve;

	// Token: 0x04000D60 RID: 3424
	public AnimationCurve rodTensionCurve;

	// Token: 0x04000D61 RID: 3425
	public AnimationCurve lineTensionCurve;

	// Token: 0x04000D62 RID: 3426
	public AnimationCurve reelTnsTensionCurve;

	// Token: 0x04000D63 RID: 3427
	public Texture durab;

	// Token: 0x04000D64 RID: 3428
	public GUIStyle ico24Style;

	// Token: 0x04000D65 RID: 3429
	public GUIStyle ico16Style;

	// Token: 0x04000D66 RID: 3430
	public GUIStyle textLayoutStyle;

	// Token: 0x04000D67 RID: 3431
	public Texture winShadow;

	// Token: 0x04000D68 RID: 3432
	public LayerMask lowReflect;

	// Token: 0x04000D69 RID: 3433
	public LayerMask medReflect;

	// Token: 0x04000D6A RID: 3434
	public LayerMask hiReflect;

	// Token: 0x04000D6B RID: 3435
	public Material material2D;

	// Token: 0x04000D6C RID: 3436
	public Material materialTexture2D;

	// Token: 0x04000D6D RID: 3437
	public Font rusfont;

	// Token: 0x04000D6E RID: 3438
	public Font rusfont2;

	// Token: 0x04000D6F RID: 3439
	public Font rusfont3;

	// Token: 0x04000D70 RID: 3440
	public Font rusfont4;

	// Token: 0x04000D71 RID: 3441
	public Font qFont;

	// Token: 0x04000D73 RID: 3443
	public GameObject infoWinPrefab;

	// Token: 0x04000D74 RID: 3444
	public GUISkin activeSkin;

	// Token: 0x04000D75 RID: 3445
	public GUISkin alterSkin;

	// Token: 0x04000D76 RID: 3446
	public GUISkin currentSkin;

	// Token: 0x04000D77 RID: 3447
	public Texture2D blackWait;

	// Token: 0x04000D78 RID: 3448
	public Texture2D WLBLine;

	// Token: 0x04000D79 RID: 3449
	public Texture2D Header;

	// Token: 0x04000D7A RID: 3450
	public Texture2D SmallKeyAthlas;

	// Token: 0x04000D7B RID: 3451
	public Texture2D TreeIcons;

	// Token: 0x04000D7C RID: 3452
	public Texture2D WaitLine;

	// Token: 0x04000D7D RID: 3453
	public Texture2D WaitLinePolosok;

	// Token: 0x04000D7E RID: 3454
	public Texture lightButtonTex;

	// Token: 0x04000D7F RID: 3455
	public bool isPanelParamActive;

	// Token: 0x04000D80 RID: 3456
	private bool OMOBPIHKDCF = true;
}
