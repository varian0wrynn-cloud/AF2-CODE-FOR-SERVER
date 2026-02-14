using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000174 RID: 372
public class KBJGAFNMGCK
{
	// Token: 0x06005144 RID: 20804 RVA: 0x0025A9D4 File Offset: 0x00258BD4
	public static KBJGAFNMGCK MHFDIJGJGBJ()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.BPOGJLNHPDP();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005145 RID: 20805 RVA: 0x0025A9F8 File Offset: 0x00258BF8
	public void JFGGHJDGOIA()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("RendererD2 is init", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("#80ff00");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('\u0005') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("WaterQuad"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.HAJGAHPBJIB()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.BFJNMCOOKDH(" x"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.BFJNMCOOKDH("Mouse Y"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.NOHLIOHBLMF();
				}
				if (diggohpgcnn.BFJNMCOOKDH("offsets") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.KKNNLBKJMCA();
				}
				if (diggohpgcnn.BFJNMCOOKDH("Ок") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.LOLBCAIEFMN();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("Wizard2HandThrow") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.AKKCENFGNCC("newletter") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("28");
	}

	// Token: 0x06005146 RID: 20806 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK BGLMJKNIJFP(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005147 RID: 20807 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK LDLNKMKLKOC(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK KLDEANECAFM(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005149 RID: 20809 RVA: 0x0025AB98 File Offset: 0x00258D98
	public void DJHLJMDGODH()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("_ReflectionTex", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("_ZCurve");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-4) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("\n<color='"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.BFJNMCOOKDH("_ColorBuffer"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.LMNLDJABLMH()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.JKHEMJCFJGJ("8"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.BFJNMCOOKDH("FOG_HAZE_ON") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.PABEGPPNHJK();
				}
				if (diggohpgcnn.BFJNMCOOKDH("Flames") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.CPGPEHEHCPI("auk_swtcost") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("</color>") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.HNPHAGIOAOB();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("wpn_add/base");
	}

	// Token: 0x0600514A RID: 20810 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK JFDKCPKJKEH(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600514B RID: 20811 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK BCDFPBPBEHM(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600514C RID: 20812 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK CJLEJOBNCPC(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600514D RID: 20813 RVA: 0x0025AD28 File Offset: 0x00258F28
	public void GDEGPEEPKNK()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("' does not exist within Assets/Resources/Fonts/", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("22");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-16) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("crft_norec"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.IPPDIFCDJHE()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.LOMKLMPKJEC("ArmFlex6"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.CMNMAJAOGDK()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.BFJNMCOOKDH("21,22,23"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.IPPDIFCDJHE();
				}
				if (diggohpgcnn.BFJNMCOOKDH("Wizard Eye Beam") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.PABEGPPNHJK();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("FactoryTempTexture") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("qd_prise_exp") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.AKKCENFGNCC("netUpdater") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("Injection Detector");
	}

	// Token: 0x0600514E RID: 20814 RVA: 0x0025AEB8 File Offset: 0x002590B8
	public void BCMIIMNMKNO()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("_NeutralTonemapperParams2", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("AFCServer");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('A') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.LOMKLMPKJEC(" %\n"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.HAJGAHPBJIB()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.BFJNMCOOKDH("Shoot Forward"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.LMNLDJABLMH();
				}
				if (diggohpgcnn.LOMKLMPKJEC("_") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.KKNNLBKJMCA();
				}
				if (diggohpgcnn.LIBBKEKPAPJ(" ") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.OKEBIHBDEOO("_CoCTex") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.AKKCENFGNCC("L") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BEJDLFKONDO();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("stacheaderprocess");
	}

	// Token: 0x0600514F RID: 20815 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK FFGCPMNCOPP(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005150 RID: 20816 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK CCHNMOEMCEG(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005151 RID: 20817 RVA: 0x0025B047 File Offset: 0x00259247
	public static KBJGAFNMGCK EEOPOHEALPK()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.HHBLMKHEMEA();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005152 RID: 20818 RVA: 0x0025B06C File Offset: 0x0025926C
	public void LNKHIEIFHNC()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("No location found baseid=", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("FactoryTempTexture");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-38) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.AKKCENFGNCC("Reset"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.LMNLDJABLMH()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.CPGPEHEHCPI("effect"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IPPDIFCDJHE()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LOMKLMPKJEC("BattleRoar"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.IPPDIFCDJHE();
				}
				if (diggohpgcnn.AKKCENFGNCC("Hidden/Amplify Color/Base") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.ENMMJFHEEHB();
				}
				if (diggohpgcnn.AKKCENFGNCC("_Transparency") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.OKEBIHBDEOO("WalkBackward") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.BFJNMCOOKDH("TOD_CloudColor") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BABLCDMBEAN();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("VolumetricFogAndMist/CopyDepth");
	}

	// Token: 0x06005153 RID: 20819 RVA: 0x0025B1FB File Offset: 0x002593FB
	public static KBJGAFNMGCK KEGBPOJKINC()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.NFIEAPBGGKJ();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005154 RID: 20820 RVA: 0x0025B220 File Offset: 0x00259420
	public void NKPIKHPNDAN()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("OneHandSwordReady", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError(" x");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('{') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("</color>"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.AKKCENFGNCC("_Vignette_Center"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.BFJNMCOOKDH("IdleWalk"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DCGNALDFPDB();
				}
				if (diggohpgcnn.AKKCENFGNCC("WateringCan") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.KKNNLBKJMCA();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("offsets") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.OKEBIHBDEOO(" ") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.LOLBCAIEFMN();
				}
				if (diggohpgcnn.LOMKLMPKJEC("qd_prise_exp") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BEJDLFKONDO();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("<color='#206000'>");
	}

	// Token: 0x06005155 RID: 20821 RVA: 0x0025B3B0 File Offset: 0x002595B0
	public void NIDGINCDCNK()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("SneakRight", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("cht_maxcnt");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('\u0018') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.JKHEMJCFJGJ("Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis)."))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.DCGNALDFPDB()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.AKKCENFGNCC("StrafeRunLeft"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IPPDIFCDJHE()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LOMKLMPKJEC("Hidden/Post FX/Ambient Occlusion"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.CMNMAJAOGDK();
				}
				if (diggohpgcnn.AKKCENFGNCC("") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.BFJNMCOOKDH("https://groups.google.com/forum/#!forum/final-ik") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.BFJNMCOOKDH("knopje.wav") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("</color>") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BEJDLFKONDO();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("WATER_VERTEX_DISPLACEMENT_OFF");
	}

	// Token: 0x06005156 RID: 20822 RVA: 0x0025B540 File Offset: 0x00259740
	public void GGDIKJCGNHB()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load(" ", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("crft_krit");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-20) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.CPGPEHEHCPI("isRun"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.DCGNALDFPDB()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.JKHEMJCFJGJ("Water"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LOMKLMPKJEC("<< 1 <<"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.LMNLDJABLMH();
				}
				if (diggohpgcnn.LIBBKEKPAPJ(" ") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.PABEGPPNHJK();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("#") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.OKEBIHBDEOO("WizardBlock") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.LIBBKEKPAPJ("wpn_rem3") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("_FogSkyData");
	}

	// Token: 0x06005157 RID: 20823 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK GIEKGGIOLKM(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005158 RID: 20824 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK NDKBNDNJFMI(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005159 RID: 20825 RVA: 0x0025B6CF File Offset: 0x002598CF
	public static KBJGAFNMGCK JMHOODFAGAM()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.LNKHIEIFHNC();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x0600515A RID: 20826 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK EKONOOHOGBM(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600515B RID: 20827 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK PFNELMIJJFD(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600515C RID: 20828 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK GDPECKOHOFD(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600515D RID: 20829 RVA: 0x0025A9D4 File Offset: 0x00258BD4
	public static KBJGAFNMGCK BCLPDGODGKF()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.BPOGJLNHPDP();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x0600515E RID: 20830 RVA: 0x0025B6F1 File Offset: 0x002598F1
	public static KBJGAFNMGCK KFJMDGGMPJO()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.OPMJJGHLAGF();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x0600515F RID: 20831 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK AOGOIIHDFCG(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005160 RID: 20832 RVA: 0x0025B714 File Offset: 0x00259914
	public void BPOGJLNHPDP()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("foot", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("_Offsets");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('j') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.CPGPEHEHCPI("id"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.HAJGAHPBJIB()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.AKKCENFGNCC("\n"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IPPDIFCDJHE()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.OKEBIHBDEOO("Flashlight"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DCGNALDFPDB();
				}
				if (diggohpgcnn.AKKCENFGNCC("MotorbikeSpecialFlip") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.ENMMJFHEEHB();
				}
				if (diggohpgcnn.BFJNMCOOKDH("{not_found}") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LOMKLMPKJEC("_FgCocMask") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.AKKCENFGNCC("OfficeSittingReadingPageFlip") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.EDAHDHCPIEL;
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("Karate Greet");
	}

	// Token: 0x06005161 RID: 20833 RVA: 0x0025B6CF File Offset: 0x002598CF
	public static KBJGAFNMGCK NPCAKEGNBHD()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.LNKHIEIFHNC();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005162 RID: 20834 RVA: 0x0025B8A3 File Offset: 0x00259AA3
	public static KBJGAFNMGCK BBLINJLBAIL()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.BCMIIMNMKNO();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005163 RID: 20835 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK KGPMEIGMNNG(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005164 RID: 20836 RVA: 0x0025B8C8 File Offset: 0x00259AC8
	public void NDDPHGNHDEL()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("Wrist", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("Vertical");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('\b') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ(""))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.JKHEMJCFJGJ("_RgbTex"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.HAJGAHPBJIB()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.CPGPEHEHCPI("Far"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.HAJGAHPBJIB();
				}
				if (diggohpgcnn.AKKCENFGNCC("http://www.root-motion.com/finalikdox/html/page5.html") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.JKHEMJCFJGJ("actor instaniateRod ") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.OKEBIHBDEOO("ANGLE=") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("inv_money") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("turn_tminfo");
	}

	// Token: 0x06005165 RID: 20837 RVA: 0x0025BA58 File Offset: 0x00259C58
	public void GABHNLEIDMP()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("file:///", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('\0') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LOMKLMPKJEC("BackPackSearch"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.AKKCENFGNCC("BowInstant"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.BFJNMCOOKDH("some kind of resizing horror"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.NOHLIOHBLMF();
				}
				if (diggohpgcnn.AKKCENFGNCC("Smoking1") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.ENMMJFHEEHB();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("_TrStartYou.ogg") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("WeaponRun") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.BFJNMCOOKDH("29") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BABLCDMBEAN();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("IKMappingBone's bone is null.");
	}

	// Token: 0x06005166 RID: 20838 RVA: 0x0025BBE7 File Offset: 0x00259DE7
	public static KBJGAFNMGCK IOALEBMCEGM()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.GGDIKJCGNHB();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005167 RID: 20839 RVA: 0x0025A9D4 File Offset: 0x00258BD4
	public static KBJGAFNMGCK OOIJFNAMEDP()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.BPOGJLNHPDP();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x06005168 RID: 20840 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK NJELCEJFBBN(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005169 RID: 20841 RVA: 0x0025BC0C File Offset: 0x00259E0C
	public void NGICLJJKHII()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load(" {0}", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("error");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-104) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.OKEBIHBDEOO("How your lives count is stored in memory when obscured:\n"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.LMNLDJABLMH()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.LIBBKEKPAPJ(" "))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.NOHLIOHBLMF()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.CPGPEHEHCPI("_Lift"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.CMNMAJAOGDK();
				}
				if (diggohpgcnn.LOMKLMPKJEC("Cloth_01.wav") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.KKNNLBKJMCA();
				}
				if (diggohpgcnn.OKEBIHBDEOO("name") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.CPGPEHEHCPI("WateringCan") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("tech") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.HNPHAGIOAOB();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("error");
	}

	// Token: 0x0600516A RID: 20842 RVA: 0x0025BD9C File Offset: 0x00259F9C
	public void BOIOCDEHDAE()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("_Transparency", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("{not_found}");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('/') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("StrafeRunLeft"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.HAJGAHPBJIB()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.LOMKLMPKJEC("__WaterReflection"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LOMKLMPKJEC(""))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.CPGPEHEHCPI("bag") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.ENMMJFHEEHB();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("root") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.OKEBIHBDEOO("Gesture Crowd Pump") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.LOMKLMPKJEC("cntx_close") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.HNPHAGIOAOB();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
	}

	// Token: 0x0600516B RID: 20843 RVA: 0x0025BF2C File Offset: 0x0025A12C
	public void ODONNAANIEP()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("Cells", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("textAsset is NULL! Path: Cells");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('=') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.OKEBIHBDEOO("bag"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.OKEBIHBDEOO("cellid"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.OKEBIHBDEOO("cellicon"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("position") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.OKEBIHBDEOO("no_change") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("only_one") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.OKEBIHBDEOO("types") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.EDAHDHCPIEL;
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("Inventory manager is init");
	}

	// Token: 0x0600516C RID: 20844 RVA: 0x0025BBE7 File Offset: 0x00259DE7
	public static KBJGAFNMGCK EAJHPOJPPFA()
	{
		if (KBJGAFNMGCK.CCHGNBELGIA == null)
		{
			KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
			KBJGAFNMGCK.CCHGNBELGIA.GGDIKJCGNHB();
		}
		return KBJGAFNMGCK.CCHGNBELGIA;
	}

	// Token: 0x0600516D RID: 20845 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK KILIAKOMMKO(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x0600516E RID: 20846 RVA: 0x0025C0BC File Offset: 0x0025A2BC
	public void HHBLMKHEMEA()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("LHandWeight", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("1HandSwordJabFootPush");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-5) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.AKKCENFGNCC("_DstBlend"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.LOMKLMPKJEC("MotorbikeTurnRight"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.AKKCENFGNCC("BlurXY"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.IPPDIFCDJHE();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("WallSit") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.KKNNLBKJMCA();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.CPGPEHEHCPI("Vertical") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LOMKLMPKJEC("") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BEJDLFKONDO();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("http://www.root-motion.com/finalikdox/html/page2.html");
	}

	// Token: 0x06005170 RID: 20848 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK MFLKDDCBEKO(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x06005171 RID: 20849 RVA: 0x0025C260 File Offset: 0x0025A460
	public void NFAKJBGFDEE()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("_Lift", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("cht_msg18");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-12) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.JKHEMJCFJGJ("offsets"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.LMNLDJABLMH()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.OKEBIHBDEOO("WizardEyeBeam"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.NOHLIOHBLMF()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LIBBKEKPAPJ("pck 230"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DCGNALDFPDB();
				}
				if (diggohpgcnn.CPGPEHEHCPI("fishSTOPTMR=") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.OKEBIHBDEOO("SoccerKeeperDiveStrafeFarLeft") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.OKEBIHBDEOO("Hidden/Post FX/Lut Generator") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LOMKLMPKJEC("_Speed") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("costwpn=");
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06005172 RID: 20850 RVA: 0x0025C3EF File Offset: 0x0025A5EF
	public static KBJGAFNMGCK IKGFHGKKCPG
	{
		get
		{
			if (KBJGAFNMGCK.CCHGNBELGIA == null)
			{
				KBJGAFNMGCK.CCHGNBELGIA = new KBJGAFNMGCK();
				KBJGAFNMGCK.CCHGNBELGIA.ODONNAANIEP();
			}
			return KBJGAFNMGCK.CCHGNBELGIA;
		}
	}

	// Token: 0x06005173 RID: 20851 RVA: 0x0025C414 File Offset: 0x0025A614
	public void NFIEAPBGGKJ()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("GetPoints() is not applicable to IKSolverVR.", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("wpn_add/base");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('2') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.JKHEMJCFJGJ("batechange.ogg"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.BFJNMCOOKDH("hellost"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.IPPDIFCDJHE()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.OKEBIHBDEOO("RollerBladeBackFlip"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.DCGNALDFPDB();
				}
				if (diggohpgcnn.BFJNMCOOKDH("RunBackward") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.CPGPEHEHCPI("_l_") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.CPGPEHEHCPI("The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.DGEEJKEEHPE();
				}
				if (diggohpgcnn.LOMKLMPKJEC("checkPet 1") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.LHMOBCOLGLJ();
				}
			}
		}
		this.LGFJMPLCGJM = true;
		Debug.Log("money");
	}

	// Token: 0x06005174 RID: 20852 RVA: 0x0025C5A4 File Offset: 0x0025A7A4
	public void OPMJJGHLAGF()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		TextAsset textAsset = (TextAsset)Resources.Load("def point foud", typeof(TextAsset));
		if (textAsset == null)
		{
			Debug.LogError("Select option");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = null;
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-127) >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("fshop_btn3"))
				{
					dcjidjjkjck = new KBJGAFNMGCK.DCJIDJJKJCK
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					this.KEKPJOACAAO.Add(dcjidjjkjck.LPFKFNLHGBI, dcjidjjkjck);
				}
				if (diggohpgcnn.CPGPEHEHCPI("---"))
				{
					ldjpekhhnhb = new KBJGAFNMGCK.LDJPEKHHNHB
					{
						LPFKFNLHGBI = diggohpgcnn.NOHLIOHBLMF()
					};
					if (dcjidjjkjck != null)
					{
						dcjidjjkjck.JHFOAGALPOD.Add(ldjpekhhnhb);
					}
				}
				if (diggohpgcnn.LOMKLMPKJEC("harvestmsg2"))
				{
					ldjpekhhnhb.OCEGMAKMPJB = diggohpgcnn.HAJGAHPBJIB();
				}
				if (diggohpgcnn.LIBBKEKPAPJ("1HandSwordChargeUp") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.NBADAMPJBBH = diggohpgcnn.FCIMOMDBEDL;
				}
				if (diggohpgcnn.BFJNMCOOKDH(" not found in resource") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.FPGJKMNIPHB = diggohpgcnn.KPAFFJNBLHK;
				}
				if (diggohpgcnn.AKKCENFGNCC("wpn_rec5") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.PFMPBFOIMLJ = diggohpgcnn.KGFNAIIPHKL();
				}
				if (diggohpgcnn.JKHEMJCFJGJ("_FoamContrast") && ldjpekhhnhb != null)
				{
					ldjpekhhnhb.DHCGCGCFFKA = diggohpgcnn.BABLCDMBEAN();
				}
			}
		}
		this.LGFJMPLCGJM = false;
		Debug.Log("auk_wmin");
	}

	// Token: 0x06005175 RID: 20853 RVA: 0x0025AB87 File Offset: 0x00258D87
	public KBJGAFNMGCK.DCJIDJJKJCK EAPKBNJJECM(int LPFKFNLHGBI)
	{
		return this.KEKPJOACAAO[LPFKFNLHGBI];
	}

	// Token: 0x04000C48 RID: 3144
	private static KBJGAFNMGCK CCHGNBELGIA;

	// Token: 0x04000C49 RID: 3145
	private readonly Dictionary<int, KBJGAFNMGCK.DCJIDJJKJCK> KEKPJOACAAO = new Dictionary<int, KBJGAFNMGCK.DCJIDJJKJCK>();

	// Token: 0x04000C4A RID: 3146
	private bool LGFJMPLCGJM;

	// Token: 0x02000175 RID: 373
	public class LDJPEKHHNHB
	{
		// Token: 0x06005176 RID: 20854 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool KMHBLJIEJDL(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool FBABFEDFMCH(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool JMJBFNAAKIF(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool FMIOJJNLFFO(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool CGJDFMGDOJE(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool NHEJGOAAIGM(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool CDLFMKOAFCD(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool PNHLJNMGLNC(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool OBGAGPMCPNK(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool HNGACKNMONK(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool JNCDHJDMKLB(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool NHAJGDOCDAJ(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool OJCCOOOKMCJ(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool BDNMOALHGHH(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool GHBBGPMFAHI(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool HBFDOAPEKCB(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool NEPJHFBAMDH(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool JJIIHHOPMKM(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool CHPJANLBEDD(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool OGKNCGADCAK(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool OBDFFOEDGKL(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool NKHMKAJKEDD(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool LOPNINIONHC(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool EABNMPGLACN(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool PDCBIOPJDPA(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x0025C733 File Offset: 0x0025A933
		public bool BBMCBABCGIA(int JNFEAFBIMAL)
		{
			return this.DHCGCGCFFKA.Contains(JNFEAFBIMAL);
		}

		// Token: 0x04000C4B RID: 3147
		public int LPFKFNLHGBI;

		// Token: 0x04000C4C RID: 3148
		public int OCEGMAKMPJB;

		// Token: 0x04000C4D RID: 3149
		public IIBEEKCAAHK NBADAMPJBBH;

		// Token: 0x04000C4E RID: 3150
		public List<int> DHCGCGCFFKA = new List<int>();

		// Token: 0x04000C4F RID: 3151
		public bool FPGJKMNIPHB;

		// Token: 0x04000C50 RID: 3152
		public bool PFMPBFOIMLJ;
	}

	// Token: 0x02000176 RID: 374
	public class DCJIDJJKJCK
	{
		// Token: 0x06005191 RID: 20881 RVA: 0x0025C754 File Offset: 0x0025A954
		public KBJGAFNMGCK.LDJPEKHHNHB CLGOJHMPFFK(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.PLBCGAAJMCB));
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x0025C788 File Offset: 0x0025A988
		public KBJGAFNMGCK.LDJPEKHHNHB NMJBBDAHBGI(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.KCLBLLHHDPM));
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x0025C7BC File Offset: 0x0025A9BC
		public KBJGAFNMGCK.LDJPEKHHNHB BEPINGOFCJP(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.JIOPLMKLNDB));
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0025C7F0 File Offset: 0x0025A9F0
		public KBJGAFNMGCK.LDJPEKHHNHB NEPJMOGNJFP(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DPOHKJDGAIM));
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0025C824 File Offset: 0x0025AA24
		public KBJGAFNMGCK.LDJPEKHHNHB PNCBMIJMIJC(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.KCLBLLHHDPM));
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x0025C858 File Offset: 0x0025AA58
		public KBJGAFNMGCK.LDJPEKHHNHB HNMHOJDNHMJ(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.CIJECKFNLDP));
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0025C88C File Offset: 0x0025AA8C
		public KBJGAFNMGCK.LDJPEKHHNHB IOJJCKAKIMA(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.NKMNFLJPLIE));
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x0025C8C0 File Offset: 0x0025AAC0
		public KBJGAFNMGCK.LDJPEKHHNHB FABHFGACNOH(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.GDBDBFMFGJG));
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x0025C8F4 File Offset: 0x0025AAF4
		public KBJGAFNMGCK.LDJPEKHHNHB NJGHFIAGCIP(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.FPNDNHJLLKC));
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x0025C928 File Offset: 0x0025AB28
		public KBJGAFNMGCK.LDJPEKHHNHB DCJGDANEMPD(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.JIOPLMKLNDB));
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0025C95C File Offset: 0x0025AB5C
		public KBJGAFNMGCK.LDJPEKHHNHB OOAAAJFAPAJ(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.PJFFGKIDDLL));
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x0025C990 File Offset: 0x0025AB90
		public KBJGAFNMGCK.LDJPEKHHNHB GKHIMEFGEJB(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.JIOPLMKLNDB));
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x0025C9C4 File Offset: 0x0025ABC4
		public KBJGAFNMGCK.LDJPEKHHNHB KLGDODCKLNI(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.GHKFIEDLBJC));
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x0025C9F8 File Offset: 0x0025ABF8
		public KBJGAFNMGCK.LDJPEKHHNHB ICIGPBCAMGC(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.NKMNFLJPLIE));
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0025CA2C File Offset: 0x0025AC2C
		public KBJGAFNMGCK.LDJPEKHHNHB OPACMDABPJC(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DBFJJMCACNF));
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0025CA60 File Offset: 0x0025AC60
		public KBJGAFNMGCK.LDJPEKHHNHB AGAKDJFNCFK(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DBFJJMCACNF));
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0025CA94 File Offset: 0x0025AC94
		public KBJGAFNMGCK.LDJPEKHHNHB ANGOINCJMJF(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.OACNKNGIJJP));
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x0025CAC8 File Offset: 0x0025ACC8
		public KBJGAFNMGCK.LDJPEKHHNHB CKBFCNJFJIA(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.EACDFMPCFGH));
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0025CAFC File Offset: 0x0025ACFC
		public KBJGAFNMGCK.LDJPEKHHNHB IIJKKMBPEBM(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DPOHKJDGAIM));
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x0025CB30 File Offset: 0x0025AD30
		public KBJGAFNMGCK.LDJPEKHHNHB HMOHCLFGOHG(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.OOIPNNEPKNE));
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x0025CB64 File Offset: 0x0025AD64
		public KBJGAFNMGCK.LDJPEKHHNHB BNMJNNICBMP(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.OOIPNNEPKNE));
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x0025CB98 File Offset: 0x0025AD98
		public KBJGAFNMGCK.LDJPEKHHNHB BCNGOOHCMII(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.PBHBNAIJCHL));
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0025CBCC File Offset: 0x0025ADCC
		public KBJGAFNMGCK.LDJPEKHHNHB ENHIEDPNKIC(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.NKMNFLJPLIE));
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x0025CC00 File Offset: 0x0025AE00
		public KBJGAFNMGCK.LDJPEKHHNHB EDPBHAAHNOM(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DPOHKJDGAIM));
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x0025CC34 File Offset: 0x0025AE34
		public KBJGAFNMGCK.LDJPEKHHNHB FEANIAEEJKI(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.ANPGMEEMOAE));
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x0025CC68 File Offset: 0x0025AE68
		public KBJGAFNMGCK.LDJPEKHHNHB KEDJPJIDACM(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.AEFJEPHMAHP));
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x0025CC9C File Offset: 0x0025AE9C
		public KBJGAFNMGCK.LDJPEKHHNHB AJPNNJEJGHI(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.PJIEBODLLPD));
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x0025CCD0 File Offset: 0x0025AED0
		public KBJGAFNMGCK.LDJPEKHHNHB JPPBMMEMMME(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.GHKFIEDLBJC));
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x0025CD04 File Offset: 0x0025AF04
		public KBJGAFNMGCK.LDJPEKHHNHB GHFFJNCLLDK(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.FFEAMOCLKBO));
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x0025CD38 File Offset: 0x0025AF38
		public KBJGAFNMGCK.LDJPEKHHNHB FKDGJEMMMLN(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.DBFJJMCACNF));
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x0025CD6C File Offset: 0x0025AF6C
		public KBJGAFNMGCK.LDJPEKHHNHB MANMFGJHFHH(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.PHIMDMLNMDC));
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x0025CDA0 File Offset: 0x0025AFA0
		public KBJGAFNMGCK.LDJPEKHHNHB LEBBNFJCLEI(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.NKMNFLJPLIE));
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x0025CDD4 File Offset: 0x0025AFD4
		public KBJGAFNMGCK.LDJPEKHHNHB OIBFINKINIL(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.FPNDNHJLLKC));
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x0025CE08 File Offset: 0x0025B008
		public KBJGAFNMGCK.LDJPEKHHNHB EAABJCKKBFN(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.JBJMCFLLJFO));
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x0025CE4C File Offset: 0x0025B04C
		public KBJGAFNMGCK.LDJPEKHHNHB MFOKOKGGFAG(int MKOFBNFCEBL)
		{
			KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII dnacdjijgii = new KBJGAFNMGCK.DCJIDJJKJCK.DNACDJIJGII();
			dnacdjijgii.MKOFBNFCEBL = MKOFBNFCEBL;
			return this.JHFOAGALPOD.FirstOrDefault(new Func<KBJGAFNMGCK.LDJPEKHHNHB, bool>(dnacdjijgii.BIAANLGGDNC));
		}

		// Token: 0x04000C51 RID: 3153
		public int LPFKFNLHGBI;

		// Token: 0x04000C52 RID: 3154
		public List<KBJGAFNMGCK.LDJPEKHHNHB> JHFOAGALPOD = new List<KBJGAFNMGCK.LDJPEKHHNHB>();

		// Token: 0x02000177 RID: 375
		[CompilerGenerated]
		private sealed class DNACDJIJGII
		{
			// Token: 0x060051B5 RID: 20917 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool OFIHFEHMAMF(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051B6 RID: 20918 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool OACNKNGIJJP(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051B7 RID: 20919 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool BIAANLGGDNC(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051B8 RID: 20920 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool HAOKKMGLKDA(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051B9 RID: 20921 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool KBIEKKILABB(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PEOOGIDPBPH(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool CEFCLPPGCNJ(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool MMADHICAGHA(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool NOELADKCALF(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BE RID: 20926 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool MMEDADCOFKD(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool NKMNFLJPLIE(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C0 RID: 20928 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool FFEAMOCLKBO(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool GGFENFNBJNP(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool DPOHKJDGAIM(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool CHFOPMCONEI(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool HAGCOPINJKH(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C6 RID: 20934 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool GHKFIEDLBJC(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C7 RID: 20935 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool GGGBCHDJOLM(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C8 RID: 20936 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool HLECGGELCED(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051C9 RID: 20937 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool ILDFJMHABNI(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CA RID: 20938 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool OOIPNNEPKNE(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CB RID: 20939 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool KCLBLLHHDPM(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CC RID: 20940 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool KEBLMHPGOMK(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CD RID: 20941 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool EACDFMPCFGH(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CE RID: 20942 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool FPNDNHJLLKC(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051CF RID: 20943 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool NNAMGEOGHPN(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D0 RID: 20944 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool JIOPLMKLNDB(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D1 RID: 20945 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool IMHDHDGLLJO(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool EMPOCHKLJJG(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D3 RID: 20947 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool HIIDAIKINFJ(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D4 RID: 20948 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool ANPGMEEMOAE(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D5 RID: 20949 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool KOAGONFBEMN(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D6 RID: 20950 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool DBFJJMCACNF(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PJIEBODLLPD(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D8 RID: 20952 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool LPBKLHMFEJO(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051D9 RID: 20953 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool IMOPMDFLFOF(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DA RID: 20954 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PLEHBHNAAMB(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DB RID: 20955 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PLBCGAAJMCB(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DC RID: 20956 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool JBJMCFLLJFO(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DD RID: 20957 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool GDBDBFMFGJG(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DE RID: 20958 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool OIGIEIPHEHF(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051DF RID: 20959 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PBHBNAIJCHL(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PJFFGKIDDLL(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E1 RID: 20961 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool AEFJEPHMAHP(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E2 RID: 20962 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PLKCPMOMNIJ(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E3 RID: 20963 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool BHDAEOPLDHI(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E4 RID: 20964 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool KOMCOMEKAKI(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E5 RID: 20965 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool MDKBJALICJA(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E6 RID: 20966 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool EOHDNCFEKGB(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E7 RID: 20967 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool PHIMDMLNMDC(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E8 RID: 20968 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool DPOEFFIHBHO(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x060051E9 RID: 20969 RVA: 0x0025CE7D File Offset: 0x0025B07D
			internal bool CIJECKFNLDP(KBJGAFNMGCK.LDJPEKHHNHB JAHNHOCNJGM)
			{
				return JAHNHOCNJGM.LPFKFNLHGBI == this.MKOFBNFCEBL;
			}

			// Token: 0x04000C53 RID: 3155
			public int MKOFBNFCEBL;
		}
	}
}
