using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001B6 RID: 438
public class ONKDCGNBALK
{
	// Token: 0x06006226 RID: 25126 RVA: 0x002DDAB8 File Offset: 0x002DBCB8
	public void OHMDBGBEPFJ()
	{
		ONKDCGNBALK onkdcgnbalk = null;
		if (this.KNNIPIEENII && this.DPJMPEFEFFF.Count > 1)
		{
			onkdcgnbalk = this.DPJMPEFEFFF[0];
			this.DPJMPEFEFFF.Remove(onkdcgnbalk);
		}
		foreach (ONKDCGNBALK onkdcgnbalk2 in this.DPJMPEFEFFF)
		{
		}
		this.DPJMPEFEFFF.Clear();
		if (onkdcgnbalk != null)
		{
			this.DPJMPEFEFFF.Add(onkdcgnbalk);
		}
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x002DDB50 File Offset: 0x002DBD50
	public void MPKCOJHJIIB()
	{
		ONKDCGNBALK onkdcgnbalk = null;
		if (this.KNNIPIEENII && this.DPJMPEFEFFF.Count > 0)
		{
			onkdcgnbalk = this.DPJMPEFEFFF[0];
			this.DPJMPEFEFFF.Remove(onkdcgnbalk);
		}
		foreach (ONKDCGNBALK onkdcgnbalk2 in this.DPJMPEFEFFF)
		{
		}
		this.DPJMPEFEFFF.Clear();
		if (onkdcgnbalk != null)
		{
			this.DPJMPEFEFFF.Add(onkdcgnbalk);
		}
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x002DDBE8 File Offset: 0x002DBDE8
	public void PLGKNLLJHIO(ONKDCGNBALK MOEEOBJHHCK)
	{
		this.DPJMPEFEFFF.Remove(MOEEOBJHHCK);
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x002DDBF8 File Offset: 0x002DBDF8
	public void FDDMHPAFDAG()
	{
		ONKDCGNBALK onkdcgnbalk = null;
		if (this.KNNIPIEENII && this.DPJMPEFEFFF.Count > 0)
		{
			onkdcgnbalk = this.DPJMPEFEFFF[1];
			this.DPJMPEFEFFF.Remove(onkdcgnbalk);
		}
		foreach (ONKDCGNBALK onkdcgnbalk2 in this.DPJMPEFEFFF)
		{
		}
		this.DPJMPEFEFFF.Clear();
		if (onkdcgnbalk != null)
		{
			this.DPJMPEFEFFF.Add(onkdcgnbalk);
		}
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x002DDC90 File Offset: 0x002DBE90
	private void AMHLJLGNLMN(int HEOMBFMLJML)
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ == this.LPFKFNLHGBI || this.MGPHHHLMEGF)
		{
			Rect rect = new Rect(0f, 0f, this.OCHCODJIPHJ.width, 30f);
			Event current = Event.current;
			if (current.isMouse && current.button == 0)
			{
				if (current.type == EventType.MouseDown)
				{
					GUI.FocusWindow(this.LPFKFNLHGBI);
					if (this.BFHKBOPOFGB && rect.Contains(current.mousePosition))
					{
						this.ENDKBKDPHKP = true;
						this.OCILGGGHDCL = current.mousePosition;
					}
				}
				if (current.type == EventType.MouseUp)
				{
					this.ENDKBKDPHKP = false;
				}
			}
		}
		this.GPMONODDGNK(this.EEIJEADOMJL);
		GUI.DragWindow(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, 30f));
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x002DDD7C File Offset: 0x002DBF7C
	public ONKDCGNBALK ADEOBKDFGOP(int JBGJGFJOHEH)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.LPFKFNLHGBI == JBGJGFJOHEH)
			{
				return onkdcgnbalk;
			}
		}
		return null;
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x002DDDD8 File Offset: 0x002DBFD8
	public virtual void ABOBBJAJCHM()
	{
		if (this.FONJHMOACFJ != null)
		{
			this.FONJHMOACFJ(this);
		}
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.OHNAHKMBABD && onkdcgnbalk.FONJHMOACFJ != null)
			{
				onkdcgnbalk.FONJHMOACFJ(onkdcgnbalk);
			}
		}
	}

	// Token: 0x0600622D RID: 25133 RVA: 0x002DDE54 File Offset: 0x002DC054
	public void LMBPNFHKNGA()
	{
		bool edonpkhbekd = this.EDONPKHBEKD;
		this.EDONPKHBEKD = true;
		this.MPKCOJHJIIB();
		JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Remove(this);
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void OKGKFLNDGOJ()
	{
	}

	// Token: 0x0600622F RID: 25135 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void IPFDPOGBJLP()
	{
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x002DDE7C File Offset: 0x002DC07C
	public virtual void HNAPHDOOCMD()
	{
		if (this.EOPFBIMNPKE != null)
		{
			this.EOPFBIMNPKE(this);
		}
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.OHNAHKMBABD && onkdcgnbalk.EOPFBIMNPKE != null)
			{
				onkdcgnbalk.EOPFBIMNPKE(onkdcgnbalk);
			}
		}
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x002DDEF8 File Offset: 0x002DC0F8
	public void GPMONODDGNK(bool MBPGCNILPHP)
	{
		this.EEIJEADOMJL = MBPGCNILPHP;
		for (int i = 0; i < this.DPJMPEFEFFF.Count; i++)
		{
			ONKDCGNBALK onkdcgnbalk = this.DPJMPEFEFFF[i];
			GUI.enabled = onkdcgnbalk.FNMCIACNOMH;
			if (onkdcgnbalk.NDPMJBODLNE != null)
			{
				onkdcgnbalk.NDPMJBODLNE(onkdcgnbalk);
			}
			else
			{
				onkdcgnbalk.HFJFBDPNCCB(this.EEIJEADOMJL & onkdcgnbalk.FNMCIACNOMH);
			}
			if (onkdcgnbalk.NJPNLLDDKKI != null)
			{
				onkdcgnbalk.NJPNLLDDKKI(onkdcgnbalk);
			}
			GUI.enabled = true;
		}
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x002DDF80 File Offset: 0x002DC180
	public virtual void CFJFEKKKONH()
	{
		if (this.FJBIDGIINCP != null)
		{
			this.FJBIDGIINCP(this);
		}
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.OHNAHKMBABD && onkdcgnbalk.FJBIDGIINCP != null)
			{
				onkdcgnbalk.FJBIDGIINCP(onkdcgnbalk);
			}
		}
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void ILDPHPJECMF()
	{
	}

	// Token: 0x06006234 RID: 25140 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void AIELOEIPFPL()
	{
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x002DDFFC File Offset: 0x002DC1FC
	public virtual void BKHMJNDBHCO()
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			onkdcgnbalk.BKHMJNDBHCO();
		}
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void BEFMBCBPEMF()
	{
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x002DE04C File Offset: 0x002DC24C
	public virtual void LFDHCMOBPIO()
	{
		if (this.FONJHMOACFJ != null)
		{
			this.FONJHMOACFJ(this);
		}
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.OHNAHKMBABD && onkdcgnbalk.FONJHMOACFJ != null)
			{
				onkdcgnbalk.FONJHMOACFJ(onkdcgnbalk);
			}
		}
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x002DE0C8 File Offset: 0x002DC2C8
	public virtual void NLLHGPLNPFN()
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			onkdcgnbalk.NLLHGPLNPFN();
		}
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x002DE118 File Offset: 0x002DC318
	public void DCPOBIGHING()
	{
		ONKDCGNBALK onkdcgnbalk = null;
		if (this.KNNIPIEENII && this.DPJMPEFEFFF.Count > 0)
		{
			onkdcgnbalk = this.DPJMPEFEFFF[0];
			this.DPJMPEFEFFF.Remove(onkdcgnbalk);
		}
		foreach (ONKDCGNBALK onkdcgnbalk2 in this.DPJMPEFEFFF)
		{
		}
		this.DPJMPEFEFFF.Clear();
		if (onkdcgnbalk != null)
		{
			this.DPJMPEFEFFF.Add(onkdcgnbalk);
		}
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x002DE1B0 File Offset: 0x002DC3B0
	public virtual void OOEEGGKDAIJ()
	{
		if (this.ENCPJNMMMJI != null)
		{
			this.ENCPJNMMMJI(this);
		}
		foreach (ONKDCGNBALK onkdcgnbalk in this.DPJMPEFEFFF)
		{
			if (onkdcgnbalk.OHNAHKMBABD && onkdcgnbalk.ENCPJNMMMJI != null)
			{
				onkdcgnbalk.ENCPJNMMMJI(onkdcgnbalk);
			}
		}
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x002DE22C File Offset: 0x002DC42C
	public ONKDCGNBALK(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float CGHAOFGOEFI, float GGAEPDHOCEC, string DPANHMGCBNL, int PPJJJAGNADB, int KFGPPFMOMOM)
	{
		this.OCBAOFLJBGP = OCBAOFLJBGP;
		this.OCHCODJIPHJ = new Rect(POFBHAEFJNE, AIIFDJADHJP, CGHAOFGOEFI, GGAEPDHOCEC);
		this.ODFEKBJCFMN = (long)PPJJJAGNADB;
		this.LPFKFNLHGBI = JDCEFOFMGHB.IKGFHGKKCPG.NLELMGLOACD();
		this.KNIOGNKKINO = KFGPPFMOMOM;
		this.DPANHMGCBNL = DPANHMGCBNL;
		this.KNNIPIEENII = false;
		this.LJIEPIPIAJC = null;
		this.FJBIDGIINCP = null;
		this.ENCPJNMMMJI = null;
		this.FONJHMOACFJ = null;
		this.EOPFBIMNPKE = null;
		this.NJPNLLDDKKI = null;
		this.NDPMJBODLNE = null;
		this.HHGPGBLNGIO = null;
		if (OCBAOFLJBGP != null)
		{
			OCBAOFLJBGP.EGINONODCLO(this);
			return;
		}
		if (KFGPPFMOMOM != 1 && KFGPPFMOMOM != -1)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GGBPIAGIILP().EGINONODCLO(this);
		}
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x002DE316 File Offset: 0x002DC516
	public void IBIOGDHDJEM(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.DPJMPEFEFFF.Add(JMAKEAHMLMI);
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x002DE324 File Offset: 0x002DC524
	public virtual void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (this.KNIOGNKKINO == 1)
		{
			Rect ochcodjiphj = this.OCHCODJIPHJ;
			float num = 10f;
			ochcodjiphj.x -= num;
			ochcodjiphj.y -= num;
			ochcodjiphj.width += 2f * num;
			ochcodjiphj.height += 2f * num;
			GUI.DrawTexture(ochcodjiphj, GuiProcessor.IKGFHGKKCPG.winShadow);
		}
		if (this.ENDKBKDPHKP)
		{
			this.OCHCODJIPHJ.x = vector.x - this.OCILGGGHDCL.x;
			this.OCHCODJIPHJ.y = vector.y - this.OCILGGGHDCL.y;
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		float num2 = 0f;
		float num3 = 0f;
		if (this.OCBAOFLJBGP != null)
		{
			num2 = this.OCBAOFLJBGP.OCHCODJIPHJ.x;
			num3 = this.OCBAOFLJBGP.OCHCODJIPHJ.y;
		}
		this.OHNAHKMBABD = new Rect(num2 + this.OCHCODJIPHJ.x, num3 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(vector);
		if (!ohnahkmbabd && this.OHNAHKMBABD)
		{
			this.AIELOEIPFPL();
		}
		if (ohnahkmbabd && !this.OHNAHKMBABD)
		{
			this.IPFDPOGBJLP();
		}
		this.EEIJEADOMJL = CFMPGCJMHJM;
		if (this.KNIOGNKKINO == 1)
		{
			if (this.OHNAHKMBABD && this.LPFKFNLHGBI != 0)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			}
			if (this.HHGPGBLNGIO != null)
			{
				this.HHGPGBLNGIO(this);
			}
			else
			{
				GUI.Window(this.LPFKFNLHGBI, this.OCHCODJIPHJ, new GUI.WindowFunction(this.AMHLJLGNLMN), this.DPANHMGCBNL);
			}
			if (this.NDPMJBODLNE != null)
			{
				this.NDPMJBODLNE(this);
				return;
			}
		}
		else
		{
			this.GPMONODDGNK(this.EEIJEADOMJL);
		}
	}

	// Token: 0x0600623E RID: 25150 RVA: 0x002DDBE8 File Offset: 0x002DBDE8
	public void GAOILKHABMH(ONKDCGNBALK MOEEOBJHHCK)
	{
		this.DPJMPEFEFFF.Remove(MOEEOBJHHCK);
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x002DE316 File Offset: 0x002DC516
	public void EGINONODCLO(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.DPJMPEFEFFF.Add(JMAKEAHMLMI);
	}

	// Token: 0x04000E19 RID: 3609
	public bool FNMCIACNOMH = true;

	// Token: 0x04000E1A RID: 3610
	public int KNIOGNKKINO = -1;

	// Token: 0x04000E1B RID: 3611
	public int LPFKFNLHGBI;

	// Token: 0x04000E1C RID: 3612
	public long ODFEKBJCFMN;

	// Token: 0x04000E1D RID: 3613
	public bool MGPHHHLMEGF;

	// Token: 0x04000E1E RID: 3614
	public string FNPEGDKBKJC = "";

	// Token: 0x04000E1F RID: 3615
	public Rect OCHCODJIPHJ;

	// Token: 0x04000E20 RID: 3616
	public string DPANHMGCBNL;

	// Token: 0x04000E21 RID: 3617
	public bool NJFFEONAFCC;

	// Token: 0x04000E22 RID: 3618
	public bool OHNAHKMBABD;

	// Token: 0x04000E23 RID: 3619
	public bool GENHHJPGOFK = true;

	// Token: 0x04000E24 RID: 3620
	public ONKDCGNBALK OCBAOFLJBGP;

	// Token: 0x04000E25 RID: 3621
	public List<ONKDCGNBALK> DPJMPEFEFFF = new List<ONKDCGNBALK>();

	// Token: 0x04000E26 RID: 3622
	public ONKDCGNBALK.CMMHGMILOIM LJIEPIPIAJC;

	// Token: 0x04000E27 RID: 3623
	public ONKDCGNBALK.CMMHGMILOIM FJBIDGIINCP;

	// Token: 0x04000E28 RID: 3624
	public ONKDCGNBALK.CMMHGMILOIM ENCPJNMMMJI;

	// Token: 0x04000E29 RID: 3625
	public bool KNNIPIEENII;

	// Token: 0x04000E2A RID: 3626
	public ONKDCGNBALK.CMMHGMILOIM FONJHMOACFJ;

	// Token: 0x04000E2B RID: 3627
	public ONKDCGNBALK.CMMHGMILOIM EOPFBIMNPKE;

	// Token: 0x04000E2C RID: 3628
	public ONKDCGNBALK.CMMHGMILOIM NDPMJBODLNE;

	// Token: 0x04000E2D RID: 3629
	public ONKDCGNBALK.CMMHGMILOIM NJPNLLDDKKI;

	// Token: 0x04000E2E RID: 3630
	public ONKDCGNBALK.CMMHGMILOIM HHGPGBLNGIO;

	// Token: 0x04000E2F RID: 3631
	public ONKDCGNBALK.CMMHGMILOIM IDBDPACMPIP;

	// Token: 0x04000E30 RID: 3632
	public UnityEngine.Object DCNLOOELNKL;

	// Token: 0x04000E31 RID: 3633
	public bool EEIJEADOMJL;

	// Token: 0x04000E32 RID: 3634
	public bool BFHKBOPOFGB = true;

	// Token: 0x04000E33 RID: 3635
	private bool ENDKBKDPHKP;

	// Token: 0x04000E34 RID: 3636
	private bool EDONPKHBEKD;

	// Token: 0x04000E35 RID: 3637
	private Vector2 OCILGGGHDCL;

	// Token: 0x020001B7 RID: 439
	// (Invoke) Token: 0x06006241 RID: 25153
	public delegate void CMMHGMILOIM(ONKDCGNBALK ONPHLHKAGFP);

	// Token: 0x020001B8 RID: 440
	// (Invoke) Token: 0x06006245 RID: 25157
	public delegate void DOKFNNFELDO(int GIPOJDGFLJM);
}
