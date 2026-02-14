using System;
using UnityEngine;

// Token: 0x0200019B RID: 411
public class HFIINBICCLO
{
	// Token: 0x06005B85 RID: 23429 RVA: 0x002AF3C4 File Offset: 0x002AD5C4
	public void ACCHEMEGOLO(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		GMNLJGNOKPD = this.KBCKIEIGKFK(GMNLJGNOKPD);
		LJGGOANMJAJ = this.ICMLJCNBMIH(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005B86 RID: 23430 RVA: 0x002AF454 File Offset: 0x002AD654
	public void EJLOAOAAIOB(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B87 RID: 23431 RVA: 0x002AF5FC File Offset: 0x002AD7FC
	public void FJBPFNKIDCF(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(3);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B88 RID: 23432 RVA: 0x002AF7A4 File Offset: 0x002AD9A4
	public void EJHCGEAOPGA(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		GMNLJGNOKPD = this.IPLDBMKOBLG(GMNLJGNOKPD);
		LJGGOANMJAJ = this.KBCKIEIGKFK(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005B89 RID: 23433 RVA: 0x002AF834 File Offset: 0x002ADA34
	public void ALNLHOCCGDP(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.ScrollWheel)
		{
			return;
		}
		GMNLJGNOKPD = this.MGNICAEJHFF(GMNLJGNOKPD);
		LJGGOANMJAJ = this.ICMLJCNBMIH(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005B8A RID: 23434 RVA: 0x002AF8C4 File Offset: 0x002ADAC4
	public void MPKFMCBGHFC(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.KBCKIEIGKFK(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(5);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B8B RID: 23435 RVA: 0x002AFA6C File Offset: 0x002ADC6C
	public void DONPEIFAEAJ(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 87f / (float)LJNHKLMELHJ;
		float num4 = 1667f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.HAMPOPEIDBC(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005B8C RID: 23436 RVA: 0x002AFAB5 File Offset: 0x002ADCB5
	public void OLIJEHCLELM(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.IPMCBNCKKDP(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(1003f, 342f, 451f, 920f));
	}

	// Token: 0x06005B8D RID: 23437 RVA: 0x002AFAF4 File Offset: 0x002ADCF4
	public void KIEIOCAOCON(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.FHHNPGKHPKC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(179f, 1213f, 534f, 1337f));
	}

	// Token: 0x06005B8E RID: 23438 RVA: 0x002AFB2F File Offset: 0x002ADD2F
	public static HFIINBICCLO ENNAAFEOFAH()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.ODONNAANIEP();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005B8F RID: 23439 RVA: 0x002AFB54 File Offset: 0x002ADD54
	public void MFLCFMEONPN(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.KDKIBPCKGKF(vector, vector2, LBCGACKJCJB);
		this.IHMBPOADDPK(vector2, vector3, LBCGACKJCJB);
		this.CKJFPACIOHH(vector3, vector4, LBCGACKJCJB);
		this.OGHDLCPABHM(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005B90 RID: 23440 RVA: 0x002AFBDC File Offset: 0x002ADDDC
	public void NAPOEGGJNOH(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(2);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B91 RID: 23441 RVA: 0x002AFCD8 File Offset: 0x002ADED8
	public void CEJPPAIJBJG(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB)
	{
		this.FJBPFNKIDCF(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, new Rect(712f, 1658f, 262f, 790f));
	}

	// Token: 0x06005B93 RID: 23443 RVA: 0x002AFCFC File Offset: 0x002ADEFC
	public void FFDEBFHFDJH(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 1f / (float)LJNHKLMELHJ;
		float num4 = 1f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.HHMMBALEHIH(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005B94 RID: 23444 RVA: 0x002AFD78 File Offset: 0x002ADF78
	public void APEBDAJIIEK(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Layout)
		{
			return;
		}
		GMNLJGNOKPD = this.ICMLJCNBMIH(GMNLJGNOKPD);
		LJGGOANMJAJ = this.IPLDBMKOBLG(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(0);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005B95 RID: 23445 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 KBCKIEIGKFK(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005B96 RID: 23446 RVA: 0x002AFE22 File Offset: 0x002AE022
	public void ODONNAANIEP()
	{
		if (!this.LGFJMPLCGJM)
		{
			this.HPPEOOOGGOP = GuiProcessor.IKGFHGKKCPG.material2D;
			this.NFKAIJFNEAK = GuiProcessor.IKGFHGKKCPG.materialTexture2D;
			this.LGFJMPLCGJM = true;
		}
		Debug.Log("RendererD2 is init");
	}

	// Token: 0x06005B97 RID: 23447 RVA: 0x002AFE60 File Offset: 0x002AE060
	private Matrix4x4 DOHBGJCFLMD(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[1] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[0] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005B98 RID: 23448 RVA: 0x002AFEC7 File Offset: 0x002AE0C7
	public void FBAFACNBBKK(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.OKPENCMAMAP(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(1324f, 1696f, 1018f, 632f));
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06005B99 RID: 23449 RVA: 0x002AFB2F File Offset: 0x002ADD2F
	public static HFIINBICCLO IKGFHGKKCPG
	{
		get
		{
			if (HFIINBICCLO.CCHGNBELGIA == null)
			{
				HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
				HFIINBICCLO.CCHGNBELGIA.ODONNAANIEP();
			}
			return HFIINBICCLO.CCHGNBELGIA;
		}
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x002AFF03 File Offset: 0x002AE103
	public static HFIINBICCLO BPCNCENHEAG()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.HHFMCEGDDMD();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005B9B RID: 23451 RVA: 0x002AFF28 File Offset: 0x002AE128
	public void IFCLDNHAIGB(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Layout)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(3);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B9C RID: 23452 RVA: 0x002B0024 File Offset: 0x002AE224
	public void GJIDACBJNEN(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 1435f / (float)LJNHKLMELHJ;
		float num4 = 1918f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.NLCNFAIJOCJ(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005B9D RID: 23453 RVA: 0x002B00A0 File Offset: 0x002AE2A0
	public void OFBMFDHGFPE(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.FHHNPGKHPKC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(382f, 1519f, 51f, 1059f));
	}

	// Token: 0x06005B9E RID: 23454 RVA: 0x002B00DC File Offset: 0x002AE2DC
	public void EDGEJABGECD(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(1);
		GL.PushMatrix();
		GL.Begin(0);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 IPLDBMKOBLG(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005BA0 RID: 23456 RVA: 0x002B0134 File Offset: 0x002AE334
	public void IOIANGKGKFO(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 299f / (float)LJNHKLMELHJ;
		float num4 = 1939f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.EJLOAOAAIOB(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BA1 RID: 23457 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 ICMLJCNBMIH(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005BA2 RID: 23458 RVA: 0x002B01AF File Offset: 0x002AE3AF
	public void PKMPGDPMMBP(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB)
	{
		this.JAJJPHHFHFF(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, new Rect(1125f, 1855f, 1210f, 1489f));
	}

	// Token: 0x06005BA3 RID: 23459 RVA: 0x002B01D4 File Offset: 0x002AE3D4
	public void HFGPGGCCJGD(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 278f / (float)LJNHKLMELHJ;
		float num4 = 353f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.HAMPOPEIDBC(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BA4 RID: 23460 RVA: 0x002B0220 File Offset: 0x002AE420
	private Matrix4x4 JEMEFOLNLMK(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[3] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BA5 RID: 23461 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 MBJOLEOMGBH(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005BA6 RID: 23462 RVA: 0x002B0287 File Offset: 0x002AE487
	public static HFIINBICCLO KPGHCNPGAGL()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.LILKJKNMCDK();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x002B02A9 File Offset: 0x002AE4A9
	public void LILKJKNMCDK()
	{
		if (!this.LGFJMPLCGJM)
		{
			this.HPPEOOOGGOP = GuiProcessor.PLGADNLAEGN().material2D;
			this.NFKAIJFNEAK = GuiProcessor.NKOEAPCIBKO().materialTexture2D;
			this.LGFJMPLCGJM = false;
		}
		Debug.Log("Vertical");
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x002B02E4 File Offset: 0x002AE4E4
	public void IKODDDKKOJL(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Layout)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(7);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x002B03E0 File Offset: 0x002AE5E0
	private Matrix4x4 DPNNBPFMMPF(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[7] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[6] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x002B0448 File Offset: 0x002AE648
	public void LCFAEMLPFIN(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.CKJFPACIOHH(vector, vector2, LBCGACKJCJB);
		this.APEBDAJIIEK(vector2, vector3, LBCGACKJCJB);
		this.IDEMJECKMNA(vector3, vector4, LBCGACKJCJB);
		this.DLKCDFNMDKK(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x002B04D0 File Offset: 0x002AE6D0
	public void OGGKHNMMGNI(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		GMNLJGNOKPD = this.IPLDBMKOBLG(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MBJOLEOMGBH(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x002B0560 File Offset: 0x002AE760
	public void FHHNPGKHPKC(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM, Rect GFELDCAMKCP)
	{
		float num = OCHCODJIPHJ.width / 2f;
		float num2 = OCHCODJIPHJ.height / 2f;
		float num3 = Mathf.Sqrt(num * num + num2 * num2);
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 2.3561945f) * num3 * 1f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 2.3561945f) * num3 * 1f));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 0.7853982f) * num3 * 1f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 0.7853982f) * num3 * 1f));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 5.4977875f) * num3 * 1f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 5.4977875f) * num3 * 1f));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 3.926991f) * num3 * 1f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 3.926991f) * num3 * 1f));
		Vector2 v5 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		Vector2 v6 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v7 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v8 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x002B07E4 File Offset: 0x002AE9E4
	public void MNLMBBLOIBM(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 795f / (float)LJNHKLMELHJ;
		float num4 = 675f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.OKPENCMAMAP(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BAE RID: 23470 RVA: 0x002B0860 File Offset: 0x002AEA60
	public void CKBHKDMJJHB(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.GDLENHBAFPA(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(907f, 789f, 1585f, 1871f));
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x002B089C File Offset: 0x002AEA9C
	public void CKJFPACIOHH(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		GMNLJGNOKPD = this.MGNICAEJHFF(GMNLJGNOKPD);
		LJGGOANMJAJ = this.ICMLJCNBMIH(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x002B092C File Offset: 0x002AEB2C
	public void EPJMCADLJEH(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.IHMBPOADDPK(vector, vector2, LBCGACKJCJB);
		this.ADADIEMBFFI(vector2, vector3, LBCGACKJCJB);
		this.DLKCDFNMDKK(vector3, vector4, LBCGACKJCJB);
		this.ALNLHOCCGDP(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x002B09B4 File Offset: 0x002AEBB4
	public void GDLENHBAFPA(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM, Rect GFELDCAMKCP)
	{
		float num = OCHCODJIPHJ.width / 1252f;
		float num2 = OCHCODJIPHJ.height / 688f;
		float num3 = Mathf.Sqrt(num * num + num2 * num2);
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 1609f) * num3 * 138f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 514f) * num3 * 693f));
		Vector2 v2 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 390f) * num3 * 619f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 1127f) * num3 * 886f));
		Vector2 v3 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 773f) * num3 * 1145f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 1822f) * num3 * 341f));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 730f) * num3 * 772f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 352f) * num3 * 799f));
		Vector2 v5 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		Vector2 v6 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v7 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v8 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(2);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BB2 RID: 23474 RVA: 0x002B0C38 File Offset: 0x002AEE38
	public void NGJMDHDBAPJ(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDown)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x002B0D34 File Offset: 0x002AEF34
	public void ANNBDHOIJGO(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.Begin(0);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x002B0D8C File Offset: 0x002AEF8C
	public void GAFAOHGGKJE(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.HAMPOPEIDBC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(481f, 1274f, 793f, 1105f));
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x002B0DC8 File Offset: 0x002AEFC8
	public void JDOKDJDLPBL(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Layout)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(6);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x002B0EC4 File Offset: 0x002AF0C4
	private Matrix4x4 PODONDBNLPO(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[1] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x002AFB2F File Offset: 0x002ADD2F
	public static HFIINBICCLO LLEDCIHMOHI()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.ODONNAANIEP();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BB8 RID: 23480 RVA: 0x002AFF03 File Offset: 0x002AE103
	public static HFIINBICCLO OOIJFNAMEDP()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.HHFMCEGDDMD();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x002B0F2C File Offset: 0x002AF12C
	public void GGFPGBKPJCN(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x002B1028 File Offset: 0x002AF228
	public void KCDODLFDIFM(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.MGNICAEJHFF(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BBB RID: 23483 RVA: 0x002B11D0 File Offset: 0x002AF3D0
	public void PNEPBCMBJNF(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 1f / (float)LJNHKLMELHJ;
		float num4 = 1f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.FHHNPGKHPKC(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x002AFF03 File Offset: 0x002AE103
	public static HFIINBICCLO GDDAGIILGGM()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.HHFMCEGDDMD();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x002B121C File Offset: 0x002AF41C
	public void FHHNPGKHPKC(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.FHHNPGKHPKC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(0f, 0f, 1f, 1f));
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x002B1258 File Offset: 0x002AF458
	public void FMLKBKMGMHM(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(6);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x002B1354 File Offset: 0x002AF554
	public void LAEGGMJHBBE(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 373f / (float)LJNHKLMELHJ;
		float num4 = 154f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.HAMPOPEIDBC(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x002B139D File Offset: 0x002AF59D
	public void LAFJACANHPF(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.OKPENCMAMAP(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(1021f, 1436f, 1021f, 664f));
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x002B13DC File Offset: 0x002AF5DC
	public void NHBLOINMDEO(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.MGNICAEJHFF(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.KBCKIEIGKFK(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.KBCKIEIGKFK(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x002B1584 File Offset: 0x002AF784
	public void ABENODAMGPC(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.GDLENHBAFPA(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1142f, 577f, 1146f, 1659f));
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x002B15C0 File Offset: 0x002AF7C0
	public void BPBOGFCKPCC(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.FHHNPGKHPKC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1106f, 136f, 1241f, 773f));
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x002B15FC File Offset: 0x002AF7FC
	public void LKFFBDIMKII(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x002B16F8 File Offset: 0x002AF8F8
	public void LONEPNCDEOK(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.ADADIEMBFFI(vector, vector2, LBCGACKJCJB);
		this.ADADIEMBFFI(vector2, vector3, LBCGACKJCJB);
		this.ADADIEMBFFI(vector3, vector4, LBCGACKJCJB);
		this.ADADIEMBFFI(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x002B1780 File Offset: 0x002AF980
	public void NLCNFAIJOCJ(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 JPMIHKMGAEM(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x002B1928 File Offset: 0x002AFB28
	public void HHMMBALEHIH(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x002B0287 File Offset: 0x002AE487
	public static HFIINBICCLO BBLINJLBAIL()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.LILKJKNMCDK();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x002B1AD0 File Offset: 0x002AFCD0
	private Matrix4x4 PKHCICCDMBE(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x002B1B38 File Offset: 0x002AFD38
	public void ILKHLABNOCF(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(1);
		GL.PushMatrix();
		GL.Begin(1);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x002B1B90 File Offset: 0x002AFD90
	public void DLKCDFNMDKK(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseUp)
		{
			return;
		}
		GMNLJGNOKPD = this.MGNICAEJHFF(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MBJOLEOMGBH(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(0);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x002B1C20 File Offset: 0x002AFE20
	public void IMJKNKCFIIN(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.Layout)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(1);
		GL.PushMatrix();
		GL.Begin(0);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BCE RID: 23502 RVA: 0x002B1C78 File Offset: 0x002AFE78
	public void GOKBFCHDDCJ(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 1977f / (float)LJNHKLMELHJ;
		float num4 = 1252f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.FHHNPGKHPKC(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x002B1CC4 File Offset: 0x002AFEC4
	public void IIBIJPNJABF(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.DLKCDFNMDKK(vector, vector2, LBCGACKJCJB);
		this.ACCHEMEGOLO(vector2, vector3, LBCGACKJCJB);
		this.ALNLHOCCGDP(vector3, vector4, LBCGACKJCJB);
		this.OGGKHNMMGNI(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x002B1D4C File Offset: 0x002AFF4C
	public void DJIIAPHNKDK(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 576f / (float)LJNHKLMELHJ;
		float num4 = 1751f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.HHMMBALEHIH(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x002B1DC8 File Offset: 0x002AFFC8
	public void HBPCMNNJNBE(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.GDLENHBAFPA(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1980f, 190f, 1720f, 279f));
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x002B1E04 File Offset: 0x002B0004
	public void NBHJGLHKBMA(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.IDEMJECKMNA(vector, vector2, LBCGACKJCJB);
		this.DLKCDFNMDKK(vector2, vector3, LBCGACKJCJB);
		this.OGGKHNMMGNI(vector3, vector4, LBCGACKJCJB);
		this.DLKCDFNMDKK(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x002B1E8C File Offset: 0x002B008C
	public void ADADIEMBFFI(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		GMNLJGNOKPD = this.MBJOLEOMGBH(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MBJOLEOMGBH(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x002B1F1C File Offset: 0x002B011C
	public void PLDOIIEKPCA(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB)
	{
		this.OKPENCMAMAP(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, new Rect(1285f, 780f, 1821f, 348f));
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x002B1F40 File Offset: 0x002B0140
	public void GCALFLOEPKI(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDown)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(5);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x002B203C File Offset: 0x002B023C
	public void HHMMBALEHIH(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB)
	{
		this.HHMMBALEHIH(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, new Rect(0f, 0f, 1f, 1f));
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x002B2060 File Offset: 0x002B0260
	public void PFGFNNCPIAJ(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 785f / (float)LJNHKLMELHJ;
		float num4 = 1127f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.HHMMBALEHIH(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x002B20DC File Offset: 0x002B02DC
	public void NIKKHFFMFIG(Rect OCHCODJIPHJ, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		float num = (float)(CLBPBJGLHEE % LJNHKLMELHJ);
		int num2 = CLBPBJGLHEE / LJNHKLMELHJ;
		float num3 = 1846f / (float)LJNHKLMELHJ;
		float num4 = 926f / (float)DBDDDMANDNN;
		float x = num * num3;
		float y = (float)num2 * num4;
		this.GDLENHBAFPA(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x002B2128 File Offset: 0x002B0328
	public void AJKIPFJNCBO(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.ADADIEMBFFI(vector, vector2, LBCGACKJCJB);
		this.ECDFJPBMHAL(vector2, vector3, LBCGACKJCJB);
		this.IDEMJECKMNA(vector3, vector4, LBCGACKJCJB);
		this.ADADIEMBFFI(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x002B21B0 File Offset: 0x002B03B0
	private Matrix4x4 HHPODAJMLMM(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[1] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[0] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[6] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[7] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x002B2218 File Offset: 0x002B0418
	public void GNLJLHDHDOO(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.GDLENHBAFPA(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1755f, 301f, 1722f, 728f));
	}

	// Token: 0x06005BDC RID: 23516 RVA: 0x002B2254 File Offset: 0x002B0454
	private Matrix4x4 PIDOPAHFGKB(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[1] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[8] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[4] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x002B22BC File Offset: 0x002B04BC
	public void OKPENCMAMAP(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.MBJOLEOMGBH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(3);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x002AFE08 File Offset: 0x002AE008
	private Vector2 MGNICAEJHFF(Vector2 BDGECGGHECB)
	{
		return new Vector2(BDGECGGHECB.x, (float)Screen.height - BDGECGGHECB.y);
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x002B0287 File Offset: 0x002AE487
	public static HFIINBICCLO PFOLNEGNIPP()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.LILKJKNMCDK();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x002B2464 File Offset: 0x002B0664
	public void PLINGMADGBL(float OCNGPCPMCPM, float ADMFAEOOOHD, int LJNHKLMELHJ, int DBDDDMANDNN, int CLBPBJGLHEE, Texture NAGPDILILNL)
	{
		if (NAGPDILILNL == null)
		{
			return;
		}
		int num = CLBPBJGLHEE / LJNHKLMELHJ;
		float num2 = (float)(CLBPBJGLHEE - num * LJNHKLMELHJ);
		float num3 = 48f / (float)LJNHKLMELHJ;
		float num4 = 410f / (float)DBDDDMANDNN;
		float x = num2 * num3;
		float y = (float)num * num4;
		float width = (float)(NAGPDILILNL.width / LJNHKLMELHJ);
		float height = (float)(NAGPDILILNL.height / DBDDDMANDNN);
		this.HHMMBALEHIH(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, width, height), NAGPDILILNL, Color.white, new Rect(x, y, num3, num4));
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x002B24E0 File Offset: 0x002B06E0
	public void PGPCLEFKLAD(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.IDEMJECKMNA(vector, vector2, LBCGACKJCJB);
		this.JMBIAHAJKJF(vector2, vector3, LBCGACKJCJB);
		this.OGGKHNMMGNI(vector3, vector4, LBCGACKJCJB);
		this.ACCHEMEGOLO(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x002B2565 File Offset: 0x002B0765
	public void LDBHFMDIJMM(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB)
	{
		this.OKPENCMAMAP(OCHCODJIPHJ, NAGPDILILNL, LBCGACKJCJB, new Rect(963f, 717f, 1168f, 1666f));
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x002B2589 File Offset: 0x002B0789
	public void HHFMCEGDDMD()
	{
		if (!this.LGFJMPLCGJM)
		{
			this.HPPEOOOGGOP = GuiProcessor.NKOEAPCIBKO().material2D;
			this.NFKAIJFNEAK = GuiProcessor.PLGADNLAEGN().materialTexture2D;
			this.LGFJMPLCGJM = true;
		}
		Debug.Log(" (");
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x002B25C4 File Offset: 0x002B07C4
	public void GAHHHCCFOOM(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.FHHNPGKHPKC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1301f, 202f, 1734f, 1983f));
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x002B2600 File Offset: 0x002B0800
	public void FLBNLFPGIMA(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseUp)
		{
			return;
		}
		GMNLJGNOKPD = this.JPMIHKMGAEM(GMNLJGNOKPD);
		LJGGOANMJAJ = this.JPMIHKMGAEM(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x002B2690 File Offset: 0x002B0890
	public void KDKIBPCKGKF(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		GMNLJGNOKPD = this.ICMLJCNBMIH(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MBJOLEOMGBH(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(0);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x002B2720 File Offset: 0x002B0920
	private Matrix4x4 FCHMAMFGBJO(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[1] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[4] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[2] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x002B2788 File Offset: 0x002B0988
	public void DPGICBJFEPM(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BE9 RID: 23529 RVA: 0x002B2884 File Offset: 0x002B0A84
	public void JAJJPHHFHFF(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.KBCKIEIGKFK(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.IPLDBMKOBLG(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.MGNICAEJHFF(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BEA RID: 23530 RVA: 0x002B2A2B File Offset: 0x002B0C2B
	public void PIFCEHGFOGH(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.KCDODLFDIFM(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(647f, 60f, 6f, 1748f));
	}

	// Token: 0x06005BEB RID: 23531 RVA: 0x002B2A68 File Offset: 0x002B0C68
	public void HAMPOPEIDBC(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM, Rect GFELDCAMKCP)
	{
		float num = OCHCODJIPHJ.width / 611f;
		float num2 = OCHCODJIPHJ.height / 134f;
		float num3 = Mathf.Sqrt(num * num + num2 * num2);
		Vector2 v = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 1790f) * num3 * 586f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 1770f) * num3 * 1341f));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 492f) * num3 * 1373f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 855f) * num3 * 1678f));
		Vector2 v3 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 1136f) * num3 * 913f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 1979f) * num3 * 1080f));
		Vector2 v4 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x + Mathf.Cos(NEPBPMGGPKM + 1999f) * num3 * 151f, OCHCODJIPHJ.y + Mathf.Sin(NEPBPMGGPKM + 464f) * num3 * 1398f));
		Vector2 v5 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		Vector2 v6 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v7 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v8 = this.KBCKIEIGKFK(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(8);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BEC RID: 23532 RVA: 0x002AFB2F File Offset: 0x002ADD2F
	public static HFIINBICCLO JFNBEACKGKI()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.ODONNAANIEP();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x002B2CEC File Offset: 0x002B0EEC
	public void ECDFJPBMHAL(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseMove)
		{
			return;
		}
		GMNLJGNOKPD = this.MBJOLEOMGBH(GMNLJGNOKPD);
		LJGGOANMJAJ = this.ICMLJCNBMIH(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x002B0287 File Offset: 0x002AE487
	public static HFIINBICCLO DPBNHMCDIIK()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.LILKJKNMCDK();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x002B2D7C File Offset: 0x002B0F7C
	public void HHMMBALEHIH(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.HHMMBALEHIH(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(0f, 0f, 1f, 1f));
	}

	// Token: 0x06005BF0 RID: 23536 RVA: 0x002B2DB8 File Offset: 0x002B0FB8
	public void ABHJNIEJOGD(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		Vector2 vector = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y);
		Vector2 vector2 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y);
		Vector2 vector3 = new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax);
		Vector2 vector4 = new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax);
		this.DLKCDFNMDKK(vector, vector2, LBCGACKJCJB);
		this.EJHCGEAOPGA(vector2, vector3, LBCGACKJCJB);
		this.CKJFPACIOHH(vector3, vector4, LBCGACKJCJB);
		this.ADADIEMBFFI(vector4, vector, LBCGACKJCJB);
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x002B2E40 File Offset: 0x002B1040
	public void JMBIAHAJKJF(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseMove)
		{
			return;
		}
		GMNLJGNOKPD = this.KBCKIEIGKFK(GMNLJGNOKPD);
		LJGGOANMJAJ = this.IPLDBMKOBLG(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(0);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x002B2ED0 File Offset: 0x002B10D0
	public void OGHDLCPABHM(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseUp)
		{
			return;
		}
		GMNLJGNOKPD = this.JPMIHKMGAEM(GMNLJGNOKPD);
		LJGGOANMJAJ = this.KBCKIEIGKFK(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(0);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x002B2F60 File Offset: 0x002B1160
	public void KBGKIEPLLGB(float OCNGPCPMCPM, float ADMFAEOOOHD, Texture NAGPDILILNL)
	{
		this.OKPENCMAMAP(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), NAGPDILILNL, Color.white, new Rect(1130f, 1590f, 1850f, 370f));
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x002B2F9C File Offset: 0x002B119C
	public void INMPNMAIMPJ(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.HAMPOPEIDBC(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(1160f, 1226f, 383f, 1827f));
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x002B2FD8 File Offset: 0x002B11D8
	private Matrix4x4 EGLAPACDMMH(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[0] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[5] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BF6 RID: 23542 RVA: 0x002B3040 File Offset: 0x002B1240
	public void LOCFBIFEECC(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.Begin(1);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x002B3098 File Offset: 0x002B1298
	public void EGLEDCACFNP(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseDown)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.IPLDBMKOBLG(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x002B3194 File Offset: 0x002B1394
	public void MKLNHHJGGAJ(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		GL.invertCulling = true;
		Vector2 v = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x002B3290 File Offset: 0x002B1490
	public void IDEMJECKMNA(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseMove)
		{
			return;
		}
		GMNLJGNOKPD = this.MBJOLEOMGBH(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MGNICAEJHFF(LJGGOANMJAJ);
		GL.invertCulling = false;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(0);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x002B0287 File Offset: 0x002AE487
	public static HFIINBICCLO GICMOPPKLPC()
	{
		if (HFIINBICCLO.CCHGNBELGIA == null)
		{
			HFIINBICCLO.CCHGNBELGIA = new HFIINBICCLO();
			HFIINBICCLO.CCHGNBELGIA.LILKJKNMCDK();
		}
		return HFIINBICCLO.CCHGNBELGIA;
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x002B3320 File Offset: 0x002B1520
	public void GMFOLLABKDH(float OCNGPCPMCPM, float ADMFAEOOOHD, float BBOODPCDKAJ, Texture NAGPDILILNL, Color LBCGACKJCJB, float NEPBPMGGPKM)
	{
		this.GDLENHBAFPA(new Rect(OCNGPCPMCPM, ADMFAEOOOHD, BBOODPCDKAJ, BBOODPCDKAJ), NAGPDILILNL, LBCGACKJCJB, NEPBPMGGPKM, new Rect(25f, 616f, 125f, 916f));
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x002B335B File Offset: 0x002B155B
	public void NCCENLBOIDK()
	{
		if (!this.LGFJMPLCGJM)
		{
			this.HPPEOOOGGOP = GuiProcessor.BBLINJLBAIL().material2D;
			this.NFKAIJFNEAK = GuiProcessor.BBLINJLBAIL().materialTexture2D;
			this.LGFJMPLCGJM = false;
		}
		Debug.Log("ScatterDitherData");
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x002B3398 File Offset: 0x002B1598
	private Matrix4x4 CBLGEDBGPPH(float CGFLAIMHHOO)
	{
		this.PLCGFNFDNGF = Matrix4x4.identity;
		this.PLCGFNFDNGF[0] = Mathf.Cos(CGFLAIMHHOO);
		this.PLCGFNFDNGF[1] = -Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[4] = Mathf.Sin(CGFLAIMHHOO);
		this.PLCGFNFDNGF[7] = Mathf.Cos(CGFLAIMHHOO);
		return this.PLCGFNFDNGF;
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x002B3400 File Offset: 0x002B1600
	public void IHMBPOADDPK(Vector2 GMNLJGNOKPD, Vector2 LJGGOANMJAJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.MouseMove)
		{
			return;
		}
		GMNLJGNOKPD = this.JPMIHKMGAEM(GMNLJGNOKPD);
		LJGGOANMJAJ = this.MBJOLEOMGBH(LJGGOANMJAJ);
		GL.invertCulling = true;
		GL.PushMatrix();
		try
		{
			this.HPPEOOOGGOP.color = LBCGACKJCJB;
			this.HPPEOOOGGOP.SetPass(1);
			GL.LoadPixelMatrix();
			GL.Begin(1);
			GL.Vertex(GMNLJGNOKPD);
			GL.Vertex(LJGGOANMJAJ);
			GL.End();
		}
		finally
		{
			GL.PopMatrix();
		}
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x002B3490 File Offset: 0x002B1690
	public void IPMCBNCKKDP(Rect OCHCODJIPHJ, Texture NAGPDILILNL, Color LBCGACKJCJB, Rect GFELDCAMKCP)
	{
		Vector2 v = this.KBCKIEIGKFK(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.ICMLJCNBMIH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.JPMIHKMGAEM(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MGNICAEJHFF(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		Vector2 v5 = this.JPMIHKMGAEM(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.y));
		Vector2 v6 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.y));
		Vector2 v7 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.xMax, GFELDCAMKCP.yMax));
		Vector2 v8 = this.ICMLJCNBMIH(new Vector2(GFELDCAMKCP.x, GFELDCAMKCP.yMax));
		this.NFKAIJFNEAK.mainTexture = NAGPDILILNL;
		this.NFKAIJFNEAK.color = LBCGACKJCJB;
		this.NFKAIJFNEAK.SetPass(1);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(3);
		GL.Color(LBCGACKJCJB);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v6);
		GL.Vertex(v2);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v5);
		GL.Vertex(v);
		GL.TexCoord(v7);
		GL.Vertex(v3);
		GL.TexCoord(v8);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x002B3638 File Offset: 0x002B1838
	public void NPDIKAPDBNM(Vector3 GMNLJGNOKPD, Vector3 LJGGOANMJAJ, Color CPMFLAALMIM, Color OGCMOICCMEJ)
	{
		if (Event.current.type != EventType.KeyUp)
		{
			return;
		}
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.Begin(0);
		GL.Color(CPMFLAALMIM);
		GL.Vertex(GMNLJGNOKPD);
		GL.Color(OGCMOICCMEJ);
		GL.Vertex(LJGGOANMJAJ);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x002B3690 File Offset: 0x002B1890
	public void OFOFJOLCFMD(Rect OCHCODJIPHJ, Color LBCGACKJCJB)
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		GL.invertCulling = false;
		Vector2 v = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.y));
		Vector2 v2 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.y));
		Vector2 v3 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.xMax, OCHCODJIPHJ.yMax));
		Vector2 v4 = this.MBJOLEOMGBH(new Vector2(OCHCODJIPHJ.x, OCHCODJIPHJ.yMax));
		this.HPPEOOOGGOP.color = LBCGACKJCJB;
		this.HPPEOOOGGOP.SetPass(0);
		GL.PushMatrix();
		GL.LoadPixelMatrix();
		GL.Begin(4);
		GL.Vertex(v);
		GL.Vertex(v2);
		GL.Vertex(v3);
		GL.Vertex(v);
		GL.Vertex(v3);
		GL.Vertex(v4);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x04000D98 RID: 3480
	private static HFIINBICCLO CCHGNBELGIA;

	// Token: 0x04000D99 RID: 3481
	private bool LGFJMPLCGJM;

	// Token: 0x04000D9A RID: 3482
	private Material HPPEOOOGGOP;

	// Token: 0x04000D9B RID: 3483
	private Material NFKAIJFNEAK;

	// Token: 0x04000D9C RID: 3484
	private Matrix4x4 PLCGFNFDNGF;
}
