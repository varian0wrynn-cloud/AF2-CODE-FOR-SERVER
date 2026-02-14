using System;
using UnityEngine;
using VolumetricFogAndMist;

// Token: 0x020001CC RID: 460
public class FogVControl : MonoBehaviour
{
	// Token: 0x0600681E RID: 26654 RVA: 0x0030B17A File Offset: 0x0030937A
	private void CFAGILIAJDO()
	{
		this.VF.CGFLAIMHHOO = 313f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600681F RID: 26655 RVA: 0x0030B1A4 File Offset: 0x003093A4
	private void OEHKOKMPIEA()
	{
		this.VF.CGFLAIMHHOO = 736f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006820 RID: 26656 RVA: 0x0030B1CE File Offset: 0x003093CE
	private void COLDOMMLODD()
	{
		this.VF.CGFLAIMHHOO = 1519f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006821 RID: 26657 RVA: 0x0030B1F8 File Offset: 0x003093F8
	private void DJFFLNLPPCC()
	{
		this.VF.CGFLAIMHHOO = 585f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006822 RID: 26658 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MKNPFMEMOJO()
	{
	}

	// Token: 0x06006823 RID: 26659 RVA: 0x0030B222 File Offset: 0x00309422
	private void EDNJADECBOE()
	{
		this.VF.CGFLAIMHHOO = 1314f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006824 RID: 26660 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OBJCOJEHLBE()
	{
	}

	// Token: 0x06006825 RID: 26661 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BBFPILBIMKC()
	{
	}

	// Token: 0x06006826 RID: 26662 RVA: 0x0030B24C File Offset: 0x0030944C
	private void IEOOGCCBEEO()
	{
		this.VF.CGFLAIMHHOO = 1929f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006827 RID: 26663 RVA: 0x0030B278 File Offset: 0x00309478
	private void JOHDLNOKCOK()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.IHOEEDGGJOC();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[6])
		{
			this.HMMOJFKGPCH();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 1711f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1677f);
		if (num < 1045f)
		{
			this.FIEOGNLIFHA();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006828 RID: 26664 RVA: 0x0030B344 File Offset: 0x00309544
	private void KJJBBLDJHPD()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.KKCLPPDOIBH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[1])
		{
			this.LCOPMFIDBIN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 679f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 1878f);
		if (num < 1483f)
		{
			this.JMBPFJDADJG();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006829 RID: 26665 RVA: 0x0030B410 File Offset: 0x00309610
	private void MJKMNBLFEGP()
	{
		this.VF.CGFLAIMHHOO = 1034f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600682A RID: 26666 RVA: 0x0030B43A File Offset: 0x0030963A
	private void GOLKKAJJEML()
	{
		this.VF.CGFLAIMHHOO = 1630f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600682B RID: 26667 RVA: 0x0030B464 File Offset: 0x00309664
	private void EHGNPFFPHAN()
	{
		this.VF.CGFLAIMHHOO = 1904f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600682C RID: 26668 RVA: 0x0030B48E File Offset: 0x0030968E
	private void IHOEEDGGJOC()
	{
		this.VF.CGFLAIMHHOO = 747f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600682D RID: 26669 RVA: 0x0030B4B8 File Offset: 0x003096B8
	private void AHLPNAANCHN()
	{
		this.VF.CGFLAIMHHOO = 258f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600682E RID: 26670 RVA: 0x0030B4E2 File Offset: 0x003096E2
	private void JMBPFJDADJG()
	{
		this.VF.CGFLAIMHHOO = 477f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600682F RID: 26671 RVA: 0x0030B50C File Offset: 0x0030970C
	private void KCMDIKFODAH()
	{
		this.VF.CGFLAIMHHOO = 1822f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006830 RID: 26672 RVA: 0x0030B538 File Offset: 0x00309738
	private void PNBGJBMJLFM()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.EHGNPFFPHAN();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[1])
		{
			this.BNHBFFBEDBO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 1881f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 1118f);
		if (num < 821f)
		{
			this.CFAGILIAJDO();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006831 RID: 26673 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FFIGGPHAIBP()
	{
	}

	// Token: 0x06006832 RID: 26674 RVA: 0x00022FCC File Offset: 0x000211CC
	private void INDGOHJGCFN()
	{
	}

	// Token: 0x06006833 RID: 26675 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFJDBBDMPMC()
	{
	}

	// Token: 0x06006834 RID: 26676 RVA: 0x0030B604 File Offset: 0x00309804
	private void LKLJABKIILJ()
	{
		this.VF.CGFLAIMHHOO = 371f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006835 RID: 26677 RVA: 0x0030B630 File Offset: 0x00309830
	private void DKOIOBMMAGN()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.DJFFLNLPPCC();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.DJFFLNLPPCC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 134f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 692f);
		if (num < 1203f)
		{
			this.BNHBFFBEDBO();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006836 RID: 26678 RVA: 0x0030B6FC File Offset: 0x003098FC
	private void KLFPOILLKDF()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.AEINCCDLCEC();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.EHGNPFFPHAN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 1107f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 132f);
		if (num < 363f)
		{
			this.GLCGEEAIFGC();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006837 RID: 26679 RVA: 0x0030B7C8 File Offset: 0x003099C8
	private void FIEOGNLIFHA()
	{
		this.VF.CGFLAIMHHOO = 1437f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006838 RID: 26680 RVA: 0x0030B7F4 File Offset: 0x003099F4
	private void AKLFCMNCPKL()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.IEOOGCCBEEO();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[6])
		{
			this.KKCLPPDOIBH();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 521f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 264f);
		if (num < 1831f)
		{
			this.EHMIJPJFJLO();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006839 RID: 26681 RVA: 0x0030B8C0 File Offset: 0x00309AC0
	private void ALGAEEMMAOI()
	{
		this.VF.CGFLAIMHHOO = 1146f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600683A RID: 26682 RVA: 0x0030B8EC File Offset: 0x00309AEC
	private void BJOICAKCPLI()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.IBLKEPKMFII();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.IEOOGCCBEEO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 1070f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 486f);
		if (num < 1342f)
		{
			this.KKCLPPDOIBH();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600683B RID: 26683 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DDEBDCGNCPC()
	{
	}

	// Token: 0x0600683C RID: 26684 RVA: 0x0030B9B8 File Offset: 0x00309BB8
	private void DEGCCLNOEKJ()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.PKHHNGLGJKA();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[5])
		{
			this.FIEOGNLIFHA();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 887f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 792f);
		if (num < 1453f)
		{
			this.FIEOGNLIFHA();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600683E RID: 26686 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ADLHNBEDHMJ()
	{
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x0030BA97 File Offset: 0x00309C97
	private void NDKIHKAMDLB()
	{
		this.VF.CGFLAIMHHOO = 1603f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006840 RID: 26688 RVA: 0x0030BAC1 File Offset: 0x00309CC1
	private void GLCGEEAIFGC()
	{
		this.VF.CGFLAIMHHOO = 370f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006841 RID: 26689 RVA: 0x0030BAEB File Offset: 0x00309CEB
	private void LCOPMFIDBIN()
	{
		this.VF.CGFLAIMHHOO = 1279f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006842 RID: 26690 RVA: 0x0030BB15 File Offset: 0x00309D15
	private void FEBHIKMMNLF()
	{
		this.VF.CGFLAIMHHOO = 1227f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006843 RID: 26691 RVA: 0x0030BB40 File Offset: 0x00309D40
	private void IGEICBNMPAD()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.COLDOMMLODD();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.EBODPDOOEDF();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 244f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1168f);
		if (num < 304f)
		{
			this.MJKMNBLFEGP();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006844 RID: 26692 RVA: 0x0030BC0C File Offset: 0x00309E0C
	private void OPEKLHFIDCK()
	{
		this.VF.CGFLAIMHHOO = 1285f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006845 RID: 26693 RVA: 0x0030BC38 File Offset: 0x00309E38
	private void FJEEADNCKAG()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.LKLJABKIILJ();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.LKLJABKIILJ();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 294f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 170f);
		if (num < 1342f)
		{
			this.MCNFPPMPHBN();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006846 RID: 26694 RVA: 0x0030BD04 File Offset: 0x00309F04
	private void GPCKACGEILI()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.HMMOJFKGPCH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.IEOOGCCBEEO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 1224f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 1332f);
		if (num < 741f)
		{
			this.GLCGEEAIFGC();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006847 RID: 26695 RVA: 0x0030BDD0 File Offset: 0x00309FD0
	private void PJHEGHHOJHJ()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.PKHHNGLGJKA();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.FEBHIKMMNLF();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 1874f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 1342f);
		if (num < 1963f)
		{
			this.AHLPNAANCHN();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006848 RID: 26696 RVA: 0x0030BE9C File Offset: 0x0030A09C
	private void LBGKAMLLACN()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.IEOOGCCBEEO();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[1])
		{
			this.DJFFLNLPPCC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.HKBNODJBGEL() + 500f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 798f);
		if (num < 650f)
		{
			this.PKHHNGLGJKA();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006849 RID: 26697 RVA: 0x0030BF68 File Offset: 0x0030A168
	private void Update()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.FBFAJEGEIKM();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[7])
		{
			this.FBFAJEGEIKM();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 6f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 24f);
		if (num < 0f)
		{
			this.FBFAJEGEIKM();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600684A RID: 26698 RVA: 0x0030C034 File Offset: 0x0030A234
	private void MCNFPPMPHBN()
	{
		this.VF.CGFLAIMHHOO = 574f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600684B RID: 26699 RVA: 0x0030C05E File Offset: 0x0030A25E
	private void EHMIJPJFJLO()
	{
		this.VF.CGFLAIMHHOO = 1409f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600684C RID: 26700 RVA: 0x0030C088 File Offset: 0x0030A288
	private void LMMDHJJJNJO()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.FEBHIKMMNLF();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[7])
		{
			this.EDNJADECBOE();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 810f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 364f);
		if (num < 1434f)
		{
			this.LKLJABKIILJ();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600684D RID: 26701 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EHDPACPIBNF()
	{
	}

	// Token: 0x0600684E RID: 26702 RVA: 0x0030C154 File Offset: 0x0030A354
	private void LEHBKPPGHPC()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.LEICCAKDMDH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[1])
		{
			this.EHGNPFFPHAN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 534f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 1108f);
		if (num < 1587f)
		{
			this.FIEOGNLIFHA();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600684F RID: 26703 RVA: 0x0030C220 File Offset: 0x0030A420
	private void IBLKEPKMFII()
	{
		this.VF.CGFLAIMHHOO = 1085f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006850 RID: 26704 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KIEIPFFEDHC()
	{
	}

	// Token: 0x06006851 RID: 26705 RVA: 0x0030C24A File Offset: 0x0030A44A
	private void LEICCAKDMDH()
	{
		this.VF.CGFLAIMHHOO = 92f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006852 RID: 26706 RVA: 0x0030C274 File Offset: 0x0030A474
	private void HJCLNJLADKL()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.LKLJABKIILJ();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[0])
		{
			this.KKCLPPDOIBH();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 682f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 277f);
		if (num < 1071f)
		{
			this.DJFFLNLPPCC();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006853 RID: 26707 RVA: 0x0030C340 File Offset: 0x0030A540
	private void OPDCJCFMIPE()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.PIHOHAHODCL();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[2])
		{
			this.CFAGILIAJDO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 1895f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 835f);
		if (num < 846f)
		{
			this.GLCGEEAIFGC();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006854 RID: 26708 RVA: 0x0030C40C File Offset: 0x0030A60C
	private void NMMGHFDLNOE()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.KKCLPPDOIBH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[2])
		{
			this.ALGAEEMMAOI();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.HKBNODJBGEL() + 290f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1388f);
		if (num < 258f)
		{
			this.ALGAEEMMAOI();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006855 RID: 26709 RVA: 0x0030C4D8 File Offset: 0x0030A6D8
	private void ECPECFPNLKP()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.EHMIJPJFJLO();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[5])
		{
			this.AEINCCDLCEC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 1145f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 126f);
		if (num < 1127f)
		{
			this.MCNFPPMPHBN();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006856 RID: 26710 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CBLGFOFHNPJ()
	{
	}

	// Token: 0x06006857 RID: 26711 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBEFOABPMFG()
	{
	}

	// Token: 0x06006858 RID: 26712 RVA: 0x0030C5A4 File Offset: 0x0030A7A4
	private void DAFJMNMFOON()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.LCOPMFIDBIN();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.MJKMNBLFEGP();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.HKBNODJBGEL() + 923f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1266f);
		if (num < 463f)
		{
			this.LEICCAKDMDH();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006859 RID: 26713 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FJGIBCHABIG()
	{
	}

	// Token: 0x0600685A RID: 26714 RVA: 0x0030C670 File Offset: 0x0030A870
	private void AIAMIFEPALP()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.IEOOGCCBEEO();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[0])
		{
			this.LKLJABKIILJ();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 1147f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 184f);
		if (num < 1788f)
		{
			this.IBLKEPKMFII();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600685B RID: 26715 RVA: 0x0030C73C File Offset: 0x0030A93C
	private void EBODPDOOEDF()
	{
		this.VF.CGFLAIMHHOO = 1421f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600685C RID: 26716 RVA: 0x0030C766 File Offset: 0x0030A966
	private void FDENBPAJOOG()
	{
		this.VF.CGFLAIMHHOO = 1617f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600685D RID: 26717 RVA: 0x0030C790 File Offset: 0x0030A990
	private void AMDMCKIFBPA()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.LCOPMFIDBIN();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.FEBHIKMMNLF();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 681f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 611f);
		if (num < 1784f)
		{
			this.FBFAJEGEIKM();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600685E RID: 26718 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELCNJDNCAEP()
	{
	}

	// Token: 0x0600685F RID: 26719 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ONIHHFLOJMN()
	{
	}

	// Token: 0x06006860 RID: 26720 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JPHBPEAMNHB()
	{
	}

	// Token: 0x06006861 RID: 26721 RVA: 0x0030C85C File Offset: 0x0030AA5C
	private void KKCLPPDOIBH()
	{
		this.VF.CGFLAIMHHOO = 520f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006862 RID: 26722 RVA: 0x0030C888 File Offset: 0x0030AA88
	private void JIKGIJEHGAP()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.HHJBKELEJJP();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.FIEOGNLIFHA();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 450f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EPCKOOOGNGK().time / 505f);
		if (num < 1342f)
		{
			this.OPEKLHFIDCK();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006863 RID: 26723 RVA: 0x0030C954 File Offset: 0x0030AB54
	private void LBOONMDONCF()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.HMMOJFKGPCH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.BNHBFFBEDBO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 27f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 890f);
		if (num < 1084f)
		{
			this.MJKMNBLFEGP();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006864 RID: 26724 RVA: 0x0030CA20 File Offset: 0x0030AC20
	private void PIHOHAHODCL()
	{
		this.VF.CGFLAIMHHOO = 1890f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006865 RID: 26725 RVA: 0x0030CA4C File Offset: 0x0030AC4C
	private void FPLNDDMFFKG()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.EHGNPFFPHAN();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.IHOEEDGGJOC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 1561f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1380f);
		if (num < 49f)
		{
			this.COLDOMMLODD();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006866 RID: 26726 RVA: 0x0030CB18 File Offset: 0x0030AD18
	private void HMMOJFKGPCH()
	{
		this.VF.CGFLAIMHHOO = 70f;
		this.VF.enabled = false;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006867 RID: 26727 RVA: 0x0030CB42 File Offset: 0x0030AD42
	private void HHJBKELEJJP()
	{
		this.VF.CGFLAIMHHOO = 1628f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006868 RID: 26728 RVA: 0x0030CB6C File Offset: 0x0030AD6C
	private void KMPEBHIPKJH()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.FDENBPAJOOG();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[3])
		{
			this.BNHBFFBEDBO();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 788f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.BOBNPEAEECC().time / 161f);
		if (num < 937f)
		{
			this.ALGAEEMMAOI();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006869 RID: 26729 RVA: 0x0030CC38 File Offset: 0x0030AE38
	private void PKHHNGLGJKA()
	{
		this.VF.CGFLAIMHHOO = 1814f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600686A RID: 26730 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMEJKAEIDCO()
	{
	}

	// Token: 0x0600686B RID: 26731 RVA: 0x0030CC64 File Offset: 0x0030AE64
	private void JBFJPNKLLKI()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.GOLKKAJJEML();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.MCNFPPMPHBN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 688f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1886f);
		if (num < 1008f)
		{
			this.LKLJABKIILJ();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600686C RID: 26732 RVA: 0x0030CD30 File Offset: 0x0030AF30
	private void BLMBPFIJJBP()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.KCMDIKFODAH();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.LCOPMFIDBIN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 1860f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EPCKOOOGNGK().time / 1851f);
		if (num < 1896f)
		{
			this.MLNAOBKOHCN();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600686D RID: 26733 RVA: 0x0030CDFC File Offset: 0x0030AFFC
	private void AEINCCDLCEC()
	{
		this.VF.CGFLAIMHHOO = 618f;
		this.VF.enabled = true;
		this.VFPost.enabled = false;
	}

	// Token: 0x0600686E RID: 26734 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOKJMMDMJNO()
	{
	}

	// Token: 0x0600686F RID: 26735 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFCCCKGCOCB()
	{
	}

	// Token: 0x06006870 RID: 26736 RVA: 0x0030CE26 File Offset: 0x0030B026
	private void MLNAOBKOHCN()
	{
		this.VF.CGFLAIMHHOO = 618f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006871 RID: 26737 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EHFPLKEINFO()
	{
	}

	// Token: 0x06006872 RID: 26738 RVA: 0x0030CE50 File Offset: 0x0030B050
	private void FBFAJEGEIKM()
	{
		this.VF.CGFLAIMHHOO = 0f;
		this.VF.enabled = false;
		this.VFPost.enabled = false;
	}

	// Token: 0x06006873 RID: 26739 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IIHNDJOIMAH()
	{
	}

	// Token: 0x06006874 RID: 26740 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KGICJDGIIJK()
	{
	}

	// Token: 0x06006875 RID: 26741 RVA: 0x0030CE7C File Offset: 0x0030B07C
	private void JIBKGOFOPHJ()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.OPEKLHFIDCK();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[8])
		{
			this.HHJBKELEJJP();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 150f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 1780f);
		if (num < 120f)
		{
			this.IBLKEPKMFII();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006876 RID: 26742 RVA: 0x0030CF48 File Offset: 0x0030B148
	private void IDMCOLDDNCF()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.NDKIHKAMDLB();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[5])
		{
			this.AEINCCDLCEC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.HKBNODJBGEL() + 1719f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 782f);
		if (num < 1050f)
		{
			this.BNHBFFBEDBO();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006877 RID: 26743 RVA: 0x0030D014 File Offset: 0x0030B214
	private void LIOCDEICIFD()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.FEBHIKMMNLF();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[1])
		{
			this.IHOEEDGGJOC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 420f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 1611f);
		if (num < 1537f)
		{
			this.JMBPFJDADJG();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006878 RID: 26744 RVA: 0x0030D0E0 File Offset: 0x0030B2E0
	private void HNMODJBBKBI()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.FEBHIKMMNLF();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[7])
		{
			this.IHOEEDGGJOC();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 356f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EPCKOOOGNGK().time / 386f);
		if (num < 757f)
		{
			this.HMMOJFKGPCH();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006879 RID: 26745 RVA: 0x0030D1AC File Offset: 0x0030B3AC
	private void INKGAFANFIB()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.OEHKOKMPIEA();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[5])
		{
			this.MLNAOBKOHCN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.OGJHINOLHJJ + 64f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.IKGFHGKKCPG.time / 115f);
		if (num < 1991f)
		{
			this.HMMOJFKGPCH();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600687A RID: 26746 RVA: 0x0030D278 File Offset: 0x0030B478
	private void GCNGEFBKMNC()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.NOPKKAOFMJP();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[6])
		{
			this.EBODPDOOEDF();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.HKBNODJBGEL() + 117f;
			this.GJEDEEKBAGI = true;
		}
		float num = this.fogICurve.Evaluate(TimeController.EKEBHIJMEML().time / 696f);
		if (num < 7f)
		{
			this.JMBPFJDADJG();
			return;
		}
		this.VF.enabled = false;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x0600687B RID: 26747 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGALMCHPPH()
	{
	}

	// Token: 0x0600687C RID: 26748 RVA: 0x0030D344 File Offset: 0x0030B544
	private void CGOFILDAAGM()
	{
		this.VF.CGFLAIMHHOO = 1841f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600687D RID: 26749 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x0600687E RID: 26750 RVA: 0x0030D36E File Offset: 0x0030B56E
	private void BNHBFFBEDBO()
	{
		this.VF.CGFLAIMHHOO = 1108f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x0600687F RID: 26751 RVA: 0x0030D398 File Offset: 0x0030B598
	private void NOPKKAOFMJP()
	{
		this.VF.CGFLAIMHHOO = 270f;
		this.VF.enabled = true;
		this.VFPost.enabled = true;
	}

	// Token: 0x06006880 RID: 26752 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGEIACONKCJ()
	{
	}

	// Token: 0x06006881 RID: 26753 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CJNBMPCNKHP()
	{
	}

	// Token: 0x06006882 RID: 26754 RVA: 0x0030D3C4 File Offset: 0x0030B5C4
	private void HONIFOPBBKC()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.AHLPNAANCHN();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.PIHOHAHODCL();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.IGHOGONIKLC() + 1306f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.KOJCECHBHLO().time / 502f);
		if (num < 296f)
		{
			this.EHGNPFFPHAN();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = false;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x06006883 RID: 26755 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPNPODKLOJK()
	{
	}

	// Token: 0x06006884 RID: 26756 RVA: 0x0030D490 File Offset: 0x0030B690
	private void NFPFDOEENLA()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (LocNewLogic.getI.isLevelLoadProcess)
		{
			this.NDKIHKAMDLB();
			return;
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4])
		{
			this.MCNFPPMPHBN();
			return;
		}
		this.VF.CDIMIEAMACH = RenderSettings.fogColor;
		if (!this.GJEDEEKBAGI)
		{
			this.VF.LHEHLDMKBKB = LocNewLogic.getI.CDBIEPGNONF() + 53f;
			this.GJEDEEKBAGI = false;
		}
		float num = this.fogICurve.Evaluate(TimeController.EPCKOOOGNGK().time / 1266f);
		if (num < 242f)
		{
			this.CGOFILDAAGM();
			return;
		}
		this.VF.enabled = true;
		this.VFPost.enabled = true;
		this.VF.CGFLAIMHHOO = num;
	}

	// Token: 0x04000EF6 RID: 3830
	public VolumetricFog VF;

	// Token: 0x04000EF7 RID: 3831
	public VolumetricFogPosT VFPost;

	// Token: 0x04000EF8 RID: 3832
	public float lightkf = 1f;

	// Token: 0x04000EF9 RID: 3833
	public Light nightLight;

	// Token: 0x04000EFA RID: 3834
	public AnimationCurve fogICurve;

	// Token: 0x04000EFB RID: 3835
	public AnimationCurve lightICurve;

	// Token: 0x04000EFC RID: 3836
	private bool GJEDEEKBAGI;
}
