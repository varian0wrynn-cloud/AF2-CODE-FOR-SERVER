using System;
using UnityEngine;

// Token: 0x0200018F RID: 399
public class FormattedLabelScript : MonoBehaviour, LDBDNBALLAJ
{
	// Token: 0x060058ED RID: 22765 RVA: 0x002A7F35 File Offset: 0x002A6135
	private void IEHAHBKBLDE(string MBJLKMDMFFB)
	{
		Debug.Log("_GrainOffsetScale" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x002A7F54 File Offset: 0x002A6154
	private void AGBEEDOOOHA()
	{
		GUILayout.BeginArea(new Rect(1625f, 1364f, (float)Screen.width, 688f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.IKFFMDPILNC((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.OCAAGJDPFMJ(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.AMAHKMNFBCM), "CP2", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.GIBBIOLADOH), this.FCPDBOMJKFJ, "Horizontal");
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x002A80B0 File Offset: 0x002A62B0
	private void Start()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Images/MouseCursor/Arrow");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("Images/MouseCursor/Link");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x002A8115 File Offset: 0x002A6315
	void LDBDNBALLAJ.onHyperlinkLeave(string MBJLKMDMFFB)
	{
		Debug.Log("onHyperlinkLeave: " + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x002A8133 File Offset: 0x002A6333
	private void IGEIEFFDIOP(string MBJLKMDMFFB)
	{
		Debug.Log("WandAttack" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x002A8151 File Offset: 0x002A6351
	void LDBDNBALLAJ.onHyperlinkEnter(string MBJLKMDMFFB)
	{
		Debug.Log("onHyperlinkEnter: " + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x002A816F File Offset: 0x002A636F
	private void LAPAPKDFKDP(string MBJLKMDMFFB)
	{
		Debug.Log("_Axis" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058F4 RID: 22772 RVA: 0x002A818D File Offset: 0x002A638D
	private void BDLKMBIGFIC(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.ELPLLPLDNOK();
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x002A819A File Offset: 0x002A639A
	private void DONKLDDBBBI(string MBJLKMDMFFB)
	{
		Debug.Log("Right" + MBJLKMDMFFB);
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x002A81AC File Offset: 0x002A63AC
	private void CNJKDLJAFEL(string MBJLKMDMFFB)
	{
		Debug.Log("OnChatMessage" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x002A81CA File Offset: 0x002A63CA
	private void NBDBGINDDLJ(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.PGHAPDOADEM();
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x002A81D8 File Offset: 0x002A63D8
	private void KBEOAOKBHEK()
	{
		GUILayout.BeginArea(new Rect(1943f, 1141f, (float)Screen.width, 389f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("dummy", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFEFLMMACB((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.CDDDGPLFNKO(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.MOKDILFEGMG), "_FogColor", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.IKFGADAOMAK), this.FCPDBOMJKFJ, "Ok");
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x002A81CA File Offset: 0x002A63CA
	private void IPNABEOBFDD(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.PGHAPDOADEM();
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x002A8333 File Offset: 0x002A6533
	private void EHLFDIFGIEA(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x002A833B File Offset: 0x002A653B
	private void JMFOHMOJBCL(string MBJLKMDMFFB)
	{
		Debug.Log("_SunPosition" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x002A8333 File Offset: 0x002A6533
	private void ADGFLCBAEBO(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x002A8359 File Offset: 0x002A6559
	private void JFIIAGGJBMN(string MBJLKMDMFFB)
	{
		Debug.Log("_MotionAmount" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x002A8377 File Offset: 0x002A6577
	private void PHKACECIMMH(string MBJLKMDMFFB)
	{
		Debug.Log("IdleReadyLook" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x002A8395 File Offset: 0x002A6595
	private void MEJJBMIDKII(string MBJLKMDMFFB)
	{
		Debug.Log("OneHandSwordJab" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005900 RID: 22784 RVA: 0x002A83B4 File Offset: 0x002A65B4
	private void IJILHIBFFCF()
	{
		GUILayout.BeginArea(new Rect(1844f, 1745f, (float)Screen.width, 1229f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.GABFHKFPCPI((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.MHOLLFCOONP(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.KDIOABAIFJC), "sys", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.JOIKEIBFBNM), this.FCPDBOMJKFJ, "\n");
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x002A8510 File Offset: 0x002A6710
	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(0f, 0f, (float)Screen.width, 50f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("Text:", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFOIJNNADN((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.LHLGENPBMCN(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.NNOBFCJLLLK), "Formatted Label", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.ADGFLCBAEBO), this.FCPDBOMJKFJ, "");
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x002A866B File Offset: 0x002A686B
	private void LGALFJFJMAC(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.MCOHGFELCOP();
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x002A8678 File Offset: 0x002A6878
	private void ICDCBAEPLBC(string MBJLKMDMFFB)
	{
		Debug.Log("{{ {{{0}:{1}}}, {{{2}:{3}}} }}" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x002A8698 File Offset: 0x002A6898
	private void CLHGHANANNL()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("TOD_kSun");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("_Offsets");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x002A86FD File Offset: 0x002A68FD
	private void BLFPJBGGGKH(string MBJLKMDMFFB)
	{
		Debug.Log("MotorbikeLassoBack" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x002A8333 File Offset: 0x002A6533
	private void DBFGLCFGMEA(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x002A871C File Offset: 0x002A691C
	private void DNLFEOECBKI()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("post_17");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("demoLong");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x002A8781 File Offset: 0x002A6981
	private void POAELGOOGBF(string MBJLKMDMFFB)
	{
		Debug.Log("_ReflectionTexture3" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x002A81CA File Offset: 0x002A63CA
	private void FDMOALBMALD(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.PGHAPDOADEM();
	}

	// Token: 0x0600590A RID: 22794 RVA: 0x002A879F File Offset: 0x002A699F
	private void NNOBFCJLLLK(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.AHICDNDPPHP();
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x002A87AC File Offset: 0x002A69AC
	private void OCKPMKGOPDH(string MBJLKMDMFFB)
	{
		Debug.Log("[curcnt]" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x002A87CC File Offset: 0x002A69CC
	private void CAJLCEPLKJG()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("HeelClick");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("MotorbikeHeartAttack");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x002A886D File Offset: 0x002A6A6D
	private void DNCMDEEEKLH(string MBJLKMDMFFB)
	{
		Debug.Log("WeaponReload" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x002A888B File Offset: 0x002A6A8B
	private void ILNCFHNELIJ(string MBJLKMDMFFB)
	{
		Debug.Log("_History1ChromaTex" + MBJLKMDMFFB);
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x002A889D File Offset: 0x002A6A9D
	private void HAHMPEOBKCA(string MBJLKMDMFFB)
	{
		Debug.Log("</color>" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x002A88BB File Offset: 0x002A6ABB
	private void GPFLGKLLNAF(string MBJLKMDMFFB)
	{
		Debug.Log("" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x002A88D9 File Offset: 0x002A6AD9
	private void EJHHBCAMCDK(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.HCEIBKGOAMO();
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x002A88E6 File Offset: 0x002A6AE6
	private void NDAMGLGACPL(string MBJLKMDMFFB)
	{
		Debug.Log("OneHandSwordBackSwing" + MBJLKMDMFFB);
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x002A8333 File Offset: 0x002A6533
	private void FGFBPCCKDAA(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x002A88F8 File Offset: 0x002A6AF8
	private void NNEHKPIINMM(string MBJLKMDMFFB)
	{
		Debug.Log("1 Hand Sword Run" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x002A8918 File Offset: 0x002A6B18
	private void LGCJDIGOOFA()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("crft_to");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("_NoiseTex");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x002A81CA File Offset: 0x002A63CA
	private void GJCEDEFGEAI(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.PGHAPDOADEM();
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x002A8980 File Offset: 0x002A6B80
	private void MMACLBBMDLA()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("WorkerPickaxe2");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("knopje.wav");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x002A89E5 File Offset: 0x002A6BE5
	private void IDOHMFLBFDK(string MBJLKMDMFFB)
	{
		Debug.Log("Water" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x002A8A03 File Offset: 0x002A6C03
	private void MOJKJKDOGGO(string MBJLKMDMFFB)
	{
		Debug.Log("Sitting Reading" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600591B RID: 22811 RVA: 0x002A8A21 File Offset: 0x002A6C21
	private void BCMIOCEPCCG(string MBJLKMDMFFB)
	{
		Debug.Log("MotorbikeLassoLeft" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x002A8A3F File Offset: 0x002A6C3F
	private void MPAKDGBMNGE(string MBJLKMDMFFB)
	{
		Debug.Log("TOD_kRadius" + MBJLKMDMFFB);
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x002A8A51 File Offset: 0x002A6C51
	private void GECOPOEPBKM(string MBJLKMDMFFB)
	{
		Debug.Log("<color='#804020'>" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x002A8A6F File Offset: 0x002A6C6F
	private void AHKNDELGLOD(string MBJLKMDMFFB)
	{
		Debug.Log(" not found" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x002A8A8D File Offset: 0x002A6C8D
	private void JINPELCKDGJ(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.MMBOOGEPMJC();
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x002A8333 File Offset: 0x002A6533
	private void GKDAOKJNDHE(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x002A8A9C File Offset: 0x002A6C9C
	private void EAOOIFBELKG()
	{
		GUILayout.BeginArea(new Rect(737f, 1770f, (float)Screen.width, 1875f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label(" < ", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.IAFAILILDNJ((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.OCAAGJDPFMJ(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.KDIOABAIFJC), "_Angle", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.IKFGADAOMAK), this.FCPDBOMJKFJ, "IdleTurns");
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x002A8BF7 File Offset: 0x002A6DF7
	private void FJMPAOGADMN(string MBJLKMDMFFB)
	{
		Debug.Log("{0}Textures/Turnirs/{1}.png" + MBJLKMDMFFB);
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x002A8C0C File Offset: 0x002A6E0C
	private void JBGGMKEKOAN()
	{
		GUILayout.BeginArea(new Rect(1173f, 1413f, (float)Screen.width, 40f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("Please assign all Bones to the IK solver.", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.IKFFMDPILNC((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.EBKFEFDKDGD(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.NBDBGINDDLJ), "gi_frac_i", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.LCEHDEDAAOJ), this.FCPDBOMJKFJ, "the Goscurry is not a lie ;)");
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x002A8D67 File Offset: 0x002A6F67
	private void HMFKIFBDHAC(string MBJLKMDMFFB)
	{
		Debug.Log("WeaponStand" + MBJLKMDMFFB);
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x002A8D7C File Offset: 0x002A6F7C
	private void MHOHPKGCMHC()
	{
		GUILayout.BeginArea(new Rect(1631f, 444f, (float)Screen.width, 788f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("WallRunRight", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFOIJNNADN((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.PPJNENCLFMK(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.KPBEDBGMELP), "SatNightFever", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.LCEHDEDAAOJ), this.FCPDBOMJKFJ, "CardPlayerIdle");
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x002A8ED7 File Offset: 0x002A70D7
	private void IANNOMINGIH(string MBJLKMDMFFB)
	{
		Debug.Log("RGBA(" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x002A8EF5 File Offset: 0x002A70F5
	private void HLNGCBJIKJJ(string MBJLKMDMFFB)
	{
		Debug.Log("_l_" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005928 RID: 22824 RVA: 0x002A8F13 File Offset: 0x002A7113
	private void BCLDMNLACLD(string MBJLKMDMFFB)
	{
		Debug.Log("Shotgun Reload Magazine" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x002A8F34 File Offset: 0x002A7134
	private void AEFGOFJAKDO()
	{
		GUILayout.BeginArea(new Rect(1138f, 1818f, (float)Screen.width, 1614f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("Vertical", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.GABFHKFPCPI((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.MHOLLFCOONP(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.AMAHKMNFBCM), "RollerBladeCrossoverLeft", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.ADGFLCBAEBO), this.FCPDBOMJKFJ, "SUNSHINE_FILTER_PCF_2x2");
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x002A908F File Offset: 0x002A728F
	private void JBIIMAJLDOB(string MBJLKMDMFFB)
	{
		Debug.Log("CrouchWalkBackward" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x002A90AD File Offset: 0x002A72AD
	private void AENPHNCKOLB(string MBJLKMDMFFB)
	{
		Debug.Log("_NoisePerChannel" + MBJLKMDMFFB);
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x002A90C0 File Offset: 0x002A72C0
	private void ANHOOJFEJJE()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("{z}");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("enableFog");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x002A8A8D File Offset: 0x002A6C8D
	private void CDJFBLLHBLA(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.MMBOOGEPMJC();
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x002A9125 File Offset: 0x002A7325
	private void DGIHDGHEGHI(string MBJLKMDMFFB)
	{
		Debug.Log("Staff Heal" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x002A9144 File Offset: 0x002A7344
	private void INDGOHJGCFN()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("BowFire");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("; ");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x002A91A9 File Offset: 0x002A73A9
	private void PIHDKCLMHGN(string MBJLKMDMFFB)
	{
		Debug.Log("FacePalm" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005931 RID: 22833 RVA: 0x002A91C8 File Offset: 0x002A73C8
	private void HDGNIHBIEDG()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("crft_treb");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("double:");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005932 RID: 22834 RVA: 0x002A922D File Offset: 0x002A742D
	private void PKGFLGPPKMJ(string MBJLKMDMFFB)
	{
		Debug.Log("IdleSpew" + MBJLKMDMFFB);
	}

	// Token: 0x06005933 RID: 22835 RVA: 0x002A8333 File Offset: 0x002A6533
	private void LCEHDEDAAOJ(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06005934 RID: 22836 RVA: 0x002A923F File Offset: 0x002A743F
	private void DECNOGDICFG(string MBJLKMDMFFB)
	{
		Debug.Log("_MaxSteps" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x002A8333 File Offset: 0x002A6533
	private void IKFGADAOMAK(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x002A925D File Offset: 0x002A745D
	private void IAAHJAANJOO(string MBJLKMDMFFB)
	{
		Debug.Log("qname_" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005937 RID: 22839 RVA: 0x002A927C File Offset: 0x002A747C
	private void KFGKKLAKFGH()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Crouch180");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("fishSPEED=");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x002A92E1 File Offset: 0x002A74E1
	private void JALNMDCPLBD(string MBJLKMDMFFB)
	{
		Debug.Log(" x" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x002A8333 File Offset: 0x002A6533
	private void JOIKEIBFBNM(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x0600593A RID: 22842 RVA: 0x002A9300 File Offset: 0x002A7500
	private void BBGAONKBIPJ()
	{
		GUILayout.BeginArea(new Rect(442f, 1675f, (float)Screen.width, 261f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("OneHandSwordBackSwing", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.PFCHBAJFDDH((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.MHOLLFCOONP(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.MOKDILFEGMG), "[fish]", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.FGFBPCCKDAA), this.FCPDBOMJKFJ, "wpn_add/base");
	}

	// Token: 0x0600593B RID: 22843 RVA: 0x002A945B File Offset: 0x002A765B
	private void LBDMCFJKMKP(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.HMGALODAHAC();
	}

	// Token: 0x0600593C RID: 22844 RVA: 0x002A8333 File Offset: 0x002A6533
	private void DOMMBIPDMJP(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x002A945B File Offset: 0x002A765B
	private void AMAHKMNFBCM(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.HMGALODAHAC();
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x002A9468 File Offset: 0x002A7668
	private void PKOAFLPBAPB(string MBJLKMDMFFB)
	{
		Debug.Log("WalkInjured" + MBJLKMDMFFB);
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x002A947C File Offset: 0x002A767C
	private void HFNLJIFPMNK()
	{
		GUILayout.BeginArea(new Rect(929f, 1083f, (float)Screen.width, 1756f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("_RampOffset", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFOIJNNADN((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.OCAAGJDPFMJ(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.LGALFJFJMAC), "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.NGGPKEFKPIO), this.FCPDBOMJKFJ, "<color='#000030'>+{0} {1}</color>");
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x002A95D8 File Offset: 0x002A77D8
	private void EFCCCKGCOCB()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("IdleSad");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("MotorbikeHeadstand");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005941 RID: 22849 RVA: 0x002A818D File Offset: 0x002A638D
	private void KDIOABAIFJC(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.ELPLLPLDNOK();
	}

	// Token: 0x06005942 RID: 22850 RVA: 0x002A963D File Offset: 0x002A783D
	private void EMCDEDNLKOJ(string MBJLKMDMFFB)
	{
		Debug.Log("cht_msg29" + MBJLKMDMFFB);
	}

	// Token: 0x06005943 RID: 22851 RVA: 0x002A964F File Offset: 0x002A784F
	private void HGOMDBFEFNJ(string MBJLKMDMFFB)
	{
		Debug.Log("_RgbBlendCacheTex" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005944 RID: 22852 RVA: 0x002A966D File Offset: 0x002A786D
	private void BABLJJEIJHI(string MBJLKMDMFFB)
	{
		Debug.Log("StrafeRunLeft" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x002A968B File Offset: 0x002A788B
	private void BLBNOFAKCNI(string MBJLKMDMFFB)
	{
		Debug.Log("" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x002A96AC File Offset: 0x002A78AC
	private void FECFLBMPAAL()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Occluder Shader Not Supported...");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("No light component found in UniqueShadowSun '{0}!");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x002A88BB File Offset: 0x002A6ABB
	private void MDBBDPMCFED(string MBJLKMDMFFB)
	{
		Debug.Log("" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x002A9711 File Offset: 0x002A7911
	void LDBDNBALLAJ.onHyperLinkActivated(string MBJLKMDMFFB)
	{
		Debug.Log("onHyperLinkActivated: " + MBJLKMDMFFB);
	}

	// Token: 0x06005949 RID: 22857 RVA: 0x002A9723 File Offset: 0x002A7923
	private void NIAPJOGLIEB(string MBJLKMDMFFB)
	{
		Debug.Log("" + MBJLKMDMFFB);
	}

	// Token: 0x0600594A RID: 22858 RVA: 0x002A9735 File Offset: 0x002A7935
	private void GHPJOLAKJGL(string MBJLKMDMFFB)
	{
		Debug.Log("_FogColor2" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600594B RID: 22859 RVA: 0x002A9754 File Offset: 0x002A7954
	private void POHHBKCLBGC()
	{
		GUILayout.BeginArea(new Rect(727f, 627f, (float)Screen.width, 174f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("910 pck get", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.PFCHBAJFDDH((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.GKOOFHJNAPO(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.NNOBFCJLLLK), "ProneIdle", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.LCEHDEDAAOJ), this.FCPDBOMJKFJ, "");
	}

	// Token: 0x0600594C RID: 22860 RVA: 0x002A98AF File Offset: 0x002A7AAF
	private void HCPCDBLDIOH(string MBJLKMDMFFB)
	{
		Debug.Log("IdleFight" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x0600594D RID: 22861 RVA: 0x002A98D0 File Offset: 0x002A7AD0
	private void BGCLAKJHAFK()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("\n");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("OfficeSittingMouseMovement");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x0600594E RID: 22862 RVA: 0x002A9938 File Offset: 0x002A7B38
	private void PMDPLLIBJAF()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Staff Attack");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("WoodSaw");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x0600594F RID: 22863 RVA: 0x002A99A0 File Offset: 0x002A7BA0
	private void BHFMGBNIAMC()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("____________________________________");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("auk_wavg");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005950 RID: 22864 RVA: 0x002A879F File Offset: 0x002A699F
	private void KPBEDBGMELP(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.AHICDNDPPHP();
	}

	// Token: 0x06005951 RID: 22865 RVA: 0x002A8A8D File Offset: 0x002A6C8D
	private void MOKDILFEGMG(int HEOMBFMLJML)
	{
		this.CFPLOLAEMDM.MMBOOGEPMJC();
	}

	// Token: 0x06005952 RID: 22866 RVA: 0x002A9A08 File Offset: 0x002A7C08
	private void IIKDDILLGLF()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("WeaponRun");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("invn_rec5");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005953 RID: 22867 RVA: 0x002A9A6D File Offset: 0x002A7C6D
	private void OJFCKGFNCAD(string MBJLKMDMFFB)
	{
		Debug.Log("Sewing" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005954 RID: 22868 RVA: 0x002A9A8B File Offset: 0x002A7C8B
	private void NJBKPNOGOAC(string MBJLKMDMFFB)
	{
		Debug.Log("Horizontal" + MBJLKMDMFFB);
	}

	// Token: 0x06005955 RID: 22869 RVA: 0x002A9A9D File Offset: 0x002A7C9D
	private void DGHHFIPADEE(string MBJLKMDMFFB)
	{
		Debug.Log("WATER_REFRACTIVE" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x002A9ABB File Offset: 0x002A7CBB
	private void KKGGFCPHJMK(string MBJLKMDMFFB)
	{
		Debug.Log("B" + MBJLKMDMFFB);
	}

	// Token: 0x06005957 RID: 22871 RVA: 0x002A9ACD File Offset: 0x002A7CCD
	private void HKCKIBILNNL(string MBJLKMDMFFB)
	{
		Debug.Log("cht_msg18" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureLink;
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x002A9AEB File Offset: 0x002A7CEB
	private void ACOOHMLNIEG(string MBJLKMDMFFB)
	{
		Debug.Log("help" + MBJLKMDMFFB);
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x002A8333 File Offset: 0x002A6533
	private void NGGPKEFKPIO(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x002A9AFD File Offset: 0x002A7CFD
	private void NDHPOGAPEPA(string MBJLKMDMFFB)
	{
		Debug.Log("Flap_02.wav" + MBJLKMDMFFB);
	}

	// Token: 0x0600595B RID: 22875 RVA: 0x002A9B10 File Offset: 0x002A7D10
	private void KIEIPFFEDHC()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("The 'color' command requires a color parameter of RRGGBBAA or '?'.");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("ScatterIntensityVolumeSky");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x002A9B78 File Offset: 0x002A7D78
	private void GCFOJFDFHGN()
	{
		GUILayout.BeginArea(new Rect(43f, 1627f, (float)Screen.width, 843f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("WorkerHammer", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.IKFFMDPILNC((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.GKOOFHJNAPO(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.NBDBGINDDLJ), "MotorbikeBackwardSitting", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.EHLFDIFGIEA), this.FCPDBOMJKFJ, "\n");
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x002A8333 File Offset: 0x002A6533
	private void GIBBIOLADOH(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x002A9CD4 File Offset: 0x002A7ED4
	private void KLBGEGDHCGA()
	{
		GUILayout.BeginArea(new Rect(1985f, 553f, (float)Screen.width, 1090f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFEFLMMACB((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.LHLGENPBMCN(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.JINPELCKDGJ), "_BaseTex", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.EHLFDIFGIEA), this.FCPDBOMJKFJ, "chnam1");
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x002A9E2F File Offset: 0x002A802F
	private void KBACEGIKOHP(string MBJLKMDMFFB)
	{
		Debug.Log("WalkInjured" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x002A9E50 File Offset: 0x002A8050
	private void KECMAHFJBCD()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Hidden/FXAA3");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("Wand Attack 2");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005961 RID: 22881 RVA: 0x002A9EB8 File Offset: 0x002A80B8
	private void BMNJGPIPKLL()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("Clear reference not set.");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("*************157 baseid=");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x06005962 RID: 22882 RVA: 0x002A9F1D File Offset: 0x002A811D
	private void NLDCBMDGIFD(string MBJLKMDMFFB)
	{
		Debug.Log("error" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005963 RID: 22883 RVA: 0x002A9F3C File Offset: 0x002A813C
	private void PNJHMJNFPLP()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("demoLong");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("IdleStrafeLeft");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = false;
	}

	// Token: 0x06005964 RID: 22884 RVA: 0x002A9FA4 File Offset: 0x002A81A4
	private void NBGFJFIMHAC()
	{
		GUILayout.BeginArea(new Rect(467f, 321f, (float)Screen.width, 1434f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("_PixelsPerMeterAtOneMeter", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.GABFHKFPCPI((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.PPJNENCLFMK(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(0, this.KPKEOKBLEBC, new GUI.WindowFunction(this.NNOBFCJLLLK), "PodsekType", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(1, clientRect, new GUI.WindowFunction(this.NGGPKEFKPIO), this.FCPDBOMJKFJ, "Idle Feed Throw");
	}

	// Token: 0x06005965 RID: 22885 RVA: 0x002AA0FF File Offset: 0x002A82FF
	private void PGCNCHGOIDH(string MBJLKMDMFFB)
	{
		Debug.Log("\n" + MBJLKMDMFFB);
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
	}

	// Token: 0x06005966 RID: 22886 RVA: 0x002AA120 File Offset: 0x002A8320
	private void IBEHHMCBCIH()
	{
		GUILayout.BeginArea(new Rect(101f, 415f, (float)Screen.width, 667f));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("WeaponReady", Array.Empty<GUILayoutOption>());
		int num = GUILayout.SelectionGrid(this.DAGFLOLHAAF, this.MOAAPFOGOIP, this.MOAAPFOGOIP.Length, Array.Empty<GUILayoutOption>());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (num != this.DAGFLOLHAAF || this.CFPLOLAEMDM == null)
		{
			this.DAGFLOLHAAF = num;
			string fpihopocaha = PIEFCKHHFGI.HLFOIJNNADN((PIEFCKHHFGI.HEDPHIDPJHI)Enum.Parse(typeof(PIEFCKHHFGI.HEDPHIDPJHI), this.MOAAPFOGOIP[this.DAGFLOLHAAF]));
			this.CFPLOLAEMDM = new PIEFCKHHFGI(this.KPKEOKBLEBC.width, fpihopocaha);
			this.CFPLOLAEMDM.LHLGENPBMCN(this);
		}
		this.KPKEOKBLEBC = GUILayout.Window(1, this.KPKEOKBLEBC, new GUI.WindowFunction(this.KPBEDBGMELP), "FONTSIZE", Array.Empty<GUILayoutOption>());
		Rect clientRect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, (float)this.FCPDBOMJKFJ.width, (float)this.FCPDBOMJKFJ.height);
		GUI.Window(0, clientRect, new GUI.WindowFunction(this.ADGFLCBAEBO), this.FCPDBOMJKFJ, "cht_msg19");
	}

	// Token: 0x06005967 RID: 22887 RVA: 0x002AA27C File Offset: 0x002A847C
	private void ELADFDNPOOI()
	{
		if (this._mouseCursorTextureArrow == null)
		{
			this._mouseCursorTextureArrow = (Texture2D)Resources.Load("KatanaReady");
		}
		if (this._mouseCursorTextureLink == null)
		{
			this._mouseCursorTextureLink = (Texture2D)Resources.Load("Deadman Float");
		}
		this.FCPDBOMJKFJ = this._mouseCursorTextureArrow;
		Cursor.visible = true;
	}

	// Token: 0x04000D49 RID: 3401
	private const int CLONFOJIHGM = 0;

	// Token: 0x04000D4A RID: 3402
	private const int DJLLEOPNBND = 1;

	// Token: 0x04000D4B RID: 3403
	private Texture2D FCPDBOMJKFJ;

	// Token: 0x04000D4C RID: 3404
	public Texture2D _mouseCursorTextureArrow;

	// Token: 0x04000D4D RID: 3405
	public Texture2D _mouseCursorTextureLink;

	// Token: 0x04000D4E RID: 3406
	private int DAGFLOLHAAF;

	// Token: 0x04000D4F RID: 3407
	private string[] MOAAPFOGOIP = Enum.GetNames(typeof(PIEFCKHHFGI.HEDPHIDPJHI));

	// Token: 0x04000D50 RID: 3408
	private PIEFCKHHFGI CFPLOLAEMDM;

	// Token: 0x04000D51 RID: 3409
	private Rect KPKEOKBLEBC = new Rect(100f, 60f, 300f, 200f);
}
