using System;
using UnityEngine;

// Token: 0x020000F7 RID: 247
[ExecuteInEditMode]
public class LinePath : MonoBehaviour
{
	// Token: 0x06002DE7 RID: 11751 RVA: 0x001527FF File Offset: 0x001509FF
	private void NPKEBODNBAI()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x00152819 File Offset: 0x00150A19
	private void JGKDNHLKBEN()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x00152834 File Offset: 0x00150A34
	private void PGIHAIPCJLL()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 955f);
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x00152819 File Offset: 0x00150A19
	private void BLDELNFCEGB()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJNMNKPNCH()
	{
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKGPEFOKKNL()
	{
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FECFLBMPAAL()
	{
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x001527FF File Offset: 0x001509FF
	private void CJCGPPJADJL()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x001528CC File Offset: 0x00150ACC
	private void HCDJABMBDFF()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 33f);
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x00152964 File Offset: 0x00150B64
	private void MNAHGMDDHCA()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1470f);
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLKBMEBFHBI()
	{
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGEIACONKCJ()
	{
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x001527FF File Offset: 0x001509FF
	private void NKHMBEDDFAJ()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x001527FF File Offset: 0x001509FF
	private void DHIJGNHBMFJ()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IAAOGAPJDID()
	{
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CLHGHANANNL()
	{
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x00152819 File Offset: 0x00150A19
	private void ONBJLCJMLJH()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x001529FC File Offset: 0x00150BFC
	private void AMDMCKIFBPA()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1029f);
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x00152819 File Offset: 0x00150A19
	private void KKFKFGPMCND()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x00152A94 File Offset: 0x00150C94
	private void IGEICBNMPAD()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 572f);
	}

	// Token: 0x06002DFB RID: 11771 RVA: 0x00152819 File Offset: 0x00150A19
	private void Awake()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DFC RID: 11772 RVA: 0x00152819 File Offset: 0x00150A19
	private void OGKOHLPFBED()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002DFD RID: 11773 RVA: 0x001527FF File Offset: 0x001509FF
	private void GAOCGDLONBN()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x001527FF File Offset: 0x001509FF
	private void MBNCGMLPNLD()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x00152819 File Offset: 0x00150A19
	private void PBOBJPGKCDC()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x001527FF File Offset: 0x001509FF
	private void AHILDBJHCKI()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E01 RID: 11777 RVA: 0x001527FF File Offset: 0x001509FF
	private void ENJFBODNKHO()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x001527FF File Offset: 0x001509FF
	private void KHKDKMMHJBK()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x00152B2C File Offset: 0x00150D2C
	private void MPLCAGFGEBO()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 929f);
	}

	// Token: 0x06002E04 RID: 11780 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IIKDDILLGLF()
	{
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x00152819 File Offset: 0x00150A19
	private void HJGFBNMJOOM()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002E06 RID: 11782 RVA: 0x00152BC4 File Offset: 0x00150DC4
	private void PNBGJBMJLFM()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 50f);
	}

	// Token: 0x06002E07 RID: 11783 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BMNJGPIPKLL()
	{
	}

	// Token: 0x06002E08 RID: 11784 RVA: 0x001527FF File Offset: 0x001509FF
	private void IOIJGMFNBMC()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E09 RID: 11785 RVA: 0x00152C5C File Offset: 0x00150E5C
	private void AKLFCMNCPKL()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 957f);
	}

	// Token: 0x06002E0A RID: 11786 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LHHKDNILMDI()
	{
	}

	// Token: 0x06002E0B RID: 11787 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AFFAJKPPMHF()
	{
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x00152CF4 File Offset: 0x00150EF4
	private void FOHLAIIMNFB()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 642f);
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x00152D8C File Offset: 0x00150F8C
	private void LMGBKHCHPHO()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 433f);
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x00152E24 File Offset: 0x00151024
	private void Update()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1f);
	}

	// Token: 0x06002E0F RID: 11791 RVA: 0x00152EBC File Offset: 0x001510BC
	private void JFGGBEGNAFP()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1227f);
	}

	// Token: 0x06002E10 RID: 11792 RVA: 0x00152F54 File Offset: 0x00151154
	private void IEOICHPKEMD()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 656f);
	}

	// Token: 0x06002E11 RID: 11793 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FIJKDFIMELM()
	{
	}

	// Token: 0x06002E13 RID: 11795 RVA: 0x00152FEC File Offset: 0x001511EC
	private void EMFOECIPBIP()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1377f);
	}

	// Token: 0x06002E14 RID: 11796 RVA: 0x001527FF File Offset: 0x001509FF
	private void MGNGNBMMAAD()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GDIMBBBPIHI()
	{
	}

	// Token: 0x06002E16 RID: 11798 RVA: 0x00153084 File Offset: 0x00151284
	private void KEBDEJIAODF()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 511f);
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IJOCHELLKJH()
	{
	}

	// Token: 0x06002E18 RID: 11800 RVA: 0x0015311C File Offset: 0x0015131C
	private void HMLNMHOMMNO()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 63f);
	}

	// Token: 0x06002E19 RID: 11801 RVA: 0x001527FF File Offset: 0x001509FF
	private void ECOOMJKPKCC()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E1A RID: 11802 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MMACLBBMDLA()
	{
	}

	// Token: 0x06002E1B RID: 11803 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGALMCHPPH()
	{
	}

	// Token: 0x06002E1C RID: 11804 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LPNDCJKAKEA()
	{
	}

	// Token: 0x06002E1D RID: 11805 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EHDPACPIBNF()
	{
	}

	// Token: 0x06002E1E RID: 11806 RVA: 0x001531B4 File Offset: 0x001513B4
	private void CBBLGEDCJBF()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1051f);
	}

	// Token: 0x06002E1F RID: 11807 RVA: 0x0015324C File Offset: 0x0015144C
	private void GDBBAMFMKII()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1093f);
	}

	// Token: 0x06002E20 RID: 11808 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06002E21 RID: 11809 RVA: 0x001532E4 File Offset: 0x001514E4
	private void IOGAKGCADBL()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1760f);
	}

	// Token: 0x06002E22 RID: 11810 RVA: 0x001527FF File Offset: 0x001509FF
	private void GDMEEIBDKLP()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E23 RID: 11811 RVA: 0x001527FF File Offset: 0x001509FF
	private void CKPNKKFIINO()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E24 RID: 11812 RVA: 0x001527FF File Offset: 0x001509FF
	private void COOHBKKNOLG()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E25 RID: 11813 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELFLOPJDAKK()
	{
	}

	// Token: 0x06002E26 RID: 11814 RVA: 0x0015337C File Offset: 0x0015157C
	private void KJJEEMEHGBF()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 631f);
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x00153414 File Offset: 0x00151614
	private void OFPGMNGFLNH()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1043f);
	}

	// Token: 0x06002E28 RID: 11816 RVA: 0x001534AC File Offset: 0x001516AC
	private void BOAJJAKEMLH()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1590f);
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MKNPFMEMOJO()
	{
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x00152819 File Offset: 0x00150A19
	private void CACBLLBNIJE()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = true;
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNJHMJNFPLP()
	{
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x001527FF File Offset: 0x001509FF
	private void DIENOIPCCDE()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KFGKKLAKFGH()
	{
	}

	// Token: 0x06002E2E RID: 11822 RVA: 0x001527FF File Offset: 0x001509FF
	private void FDGKKBGHNIN()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x00153544 File Offset: 0x00151744
	private void CDLDCKAHLHC()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(0, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1493f);
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBMPJPIMJBF()
	{
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x001527FF File Offset: 0x001509FF
	private void LBKPJAJJLBH()
	{
		this.linerend = base.GetComponent<LineRenderer>();
		this.linerend.useWorldSpace = false;
	}

	// Token: 0x06002E32 RID: 11826 RVA: 0x001535DC File Offset: 0x001517DC
	private void BJOICAKCPLI()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(1, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1057f);
	}

	// Token: 0x06002E33 RID: 11827 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMEJKAEIDCO()
	{
	}

	// Token: 0x06002E34 RID: 11828 RVA: 0x00153674 File Offset: 0x00151874
	private void LFJHDHPJOPE()
	{
		if (this.linerend != null)
		{
			this.linerend.SetPosition(0, base.transform.position);
			if (this.endPoint != null)
			{
				this.linerend.SetPosition(1, this.endPoint.transform.position);
			}
		}
		float x = Vector3.Distance(base.transform.position, this.endPoint.transform.position);
		this.linerend.material.mainTextureScale = new Vector2(x, 1212f);
	}

	// Token: 0x0400064C RID: 1612
	public LineRenderer linerend;

	// Token: 0x0400064D RID: 1613
	public GameObject endPoint;
}
