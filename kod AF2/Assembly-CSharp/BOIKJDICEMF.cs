using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000138 RID: 312
public class BOIKJDICEMF
{
	// Token: 0x060040F0 RID: 16624 RVA: 0x001D5D40 File Offset: 0x001D3F40
	public Color AAINBHFKJOJ()
	{
		if (this.MPMLJCLEKJP() == null)
		{
			return Color.gray;
		}
		if (this.FALNIKDDCJL().IIOHPBENEFI == null)
		{
			return Color.gray;
		}
		return GuiProcessor.NKOEAPCIBKO().lineColors[this.MPMLJCLEKJP().IIOHPBENEFI.BDHHPAEHFHG.ENBIMFHMLIF()];
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060040F1 RID: 16625 RVA: 0x001D5D94 File Offset: 0x001D3F94
	public float ENDGIODBEEE
	{
		get
		{
			float num = 5f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.ELBKLOECINC);
			if (this.MPMLJCLEKJP() != null && this.MPMLJCLEKJP().LJCLFFINEHJ != null)
			{
				num += num * (this.MPMLJCLEKJP().LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL / 100f);
			}
			return num;
		}
	}

	// Token: 0x060040F2 RID: 16626 RVA: 0x001D5DF4 File Offset: 0x001D3FF4
	public EKBAPCMPANI KBNMKAMMOKM()
	{
		EKBAPCMPANI result = null;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.FALNIKDDCJL();
		if (bgjkmcbhnak != null)
		{
			result = bgjkmcbhnak.AMLEOGHNNPG[0];
		}
		return result;
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060040F3 RID: 16627 RVA: 0x001D5E18 File Offset: 0x001D4018
	public BOIKJDICEMF.JGHABIPEEEO OJLPPKBKDBL
	{
		get
		{
			BOIKJDICEMF.JGHABIPEEEO result = BOIKJDICEMF.JGHABIPEEEO.Poplavok;
			if (this.MPMLJCLEKJP() != null)
			{
				result = this.MPMLJCLEKJP().DFBHMIIPLCA;
			}
			return result;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060040F4 RID: 16628 RVA: 0x001D5E3C File Offset: 0x001D403C
	public EKBAPCMPANI FMNHHGDPOHL
	{
		get
		{
			EKBAPCMPANI result = null;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
			if (bgjkmcbhnak != null)
			{
				result = bgjkmcbhnak.AMLEOGHNNPG[0];
			}
			return result;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x060040F5 RID: 16629 RVA: 0x001D5E60 File Offset: 0x001D4060
	public float AFGBIBMHOAI
	{
		get
		{
			float num = 1f;
			float num2 = 1f;
			if (this.MPMLJCLEKJP() != null && this.MPMLJCLEKJP().NKNCNHGDMLF != null && this.MPMLJCLEKJP().IIOHPBENEFI != null && this.MPMLJCLEKJP().LJCLFFINEHJ != null)
			{
				num = Mathf.Min(this.MPMLJCLEKJP().NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ, this.MPMLJCLEKJP().IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ);
				num2 = 1f + this.MPMLJCLEKJP().LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL / 200f;
			}
			return num2 * num * ((float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) * 40f + 2500f);
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06004114 RID: 16660 RVA: 0x001D72A1 File Offset: 0x001D54A1
	// (set) Token: 0x060040F7 RID: 16631 RVA: 0x001D5F2B File Offset: 0x001D412B
	public float DIBMKDFBPPK
	{
		get
		{
			return this.MPMLJCLEKJP().CLEJODCMJAA;
		}
		set
		{
			this.MPMLJCLEKJP().CLEJODCMJAA = Mathf.Clamp(value, 25f, 75f);
		}
	}

	// Token: 0x060040F8 RID: 16632 RVA: 0x001D5F48 File Offset: 0x001D4148
	public BOIKJDICEMF.BGJKMCBHNAK CIOEFGAIDNC(BOIKJDICEMF.JGHABIPEEEO DFBHMIIPLCA)
	{
		switch (DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			return this.DFHGAOMBMPB[1];
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			return this.DFHGAOMBMPB[0];
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			return this.DFHGAOMBMPB[0];
		default:
			return null;
		}
	}

	// Token: 0x060040F9 RID: 16633 RVA: 0x001D5F7C File Offset: 0x001D417C
	public void MKOJMJKKEBE()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
		if (bgjkmcbhnak != null && bgjkmcbhnak.IKKPFPJLPOL)
		{
			bgjkmcbhnak.MKOJMJKKEBE();
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x060040FA RID: 16634 RVA: 0x001D5FA4 File Offset: 0x001D41A4
	public float OIFCLNKOJHB
	{
		get
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
			float num = 2.1f;
			if (bgjkmcbhnak != null && bgjkmcbhnak.NKNCNHGDMLF != null)
			{
				float num2 = 1f + (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(403) / 10f;
				num = this.CPHHGMPBACB(bgjkmcbhnak.NKNCNHGDMLF.MBKMKGABBGE, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI, 1);
				if (JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH(2, bgjkmcbhnak.NKNCNHGDMLF.OKHPDILIOCH))
				{
					num = this.CPHHGMPBACB(bgjkmcbhnak.NKNCNHGDMLF.MBKMKGABBGE, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI, 2);
				}
				num *= num2;
				BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
				if (dfbhmiiplca != BOIKJDICEMF.JGHABIPEEEO.Spinning)
				{
					if (dfbhmiiplca == BOIKJDICEMF.JGHABIPEEEO.Fider)
					{
						float num3 = bgjkmcbhnak.JAHNFKLFANO();
						float num4 = (float)bgjkmcbhnak.NKNCNHGDMLF.ADOFHHCDGON;
						float num5 = (float)bgjkmcbhnak.NKNCNHGDMLF.ECKKCDKHNEH;
						if (num5 > 0f)
						{
							float num6 = (num3 - num4) / (num5 - num4);
							num6 = Mathf.Clamp(num6, 0f, 2f);
							float num7 = Mathf.LerpUnclamped(1.5f, 1f, num6);
							num *= num7;
						}
						if (Fisherman.getI.CMCPFNJIIHK)
						{
							num *= 0.85f;
						}
					}
				}
				else
				{
					float num8 = bgjkmcbhnak.JAHNFKLFANO();
					float num9 = (float)bgjkmcbhnak.NKNCNHGDMLF.ADOFHHCDGON;
					float num10 = (float)bgjkmcbhnak.NKNCNHGDMLF.ECKKCDKHNEH;
					if (num10 > 0f)
					{
						float num11 = (num8 - num9) / (num10 - num9);
						num11 = Mathf.Clamp(num11, 0f, 2f);
						float num12 = Mathf.LerpUnclamped(1f, 1.5f, num11);
						num *= num12;
					}
					if (Fisherman.getI.CMCPFNJIIHK)
					{
						num *= 0.9f;
					}
				}
			}
			if (bgjkmcbhnak.IIOHPBENEFI != null)
			{
				float max = 0f;
				if (bgjkmcbhnak.LJCLFFINEHJ != null)
				{
					max = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.AGJPNGBDNFE(bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.OBEOJCGHOGL);
				}
				num = Mathf.Clamp(num, 0.1f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.KGKNPAAMDJK);
				num = Mathf.Clamp(num, 0.1f, max);
			}
			else
			{
				num = 0.1f;
			}
			return num;
		}
	}

	// Token: 0x060040FB RID: 16635 RVA: 0x001D61C4 File Offset: 0x001D43C4
	public BOIKJDICEMF()
	{
		for (int i = 0; i < this.DFHGAOMBMPB.Length; i++)
		{
			if (this.DFHGAOMBMPB[i] == null)
			{
				this.DFHGAOMBMPB[i] = new BOIKJDICEMF.BGJKMCBHNAK();
				this.DFHGAOMBMPB[i].GKAHEMBMCNC = true;
			}
		}
	}

	// Token: 0x060040FC RID: 16636 RVA: 0x001D622C File Offset: 0x001D442C
	public BOIKJDICEMF.BGJKMCBHNAK FALNIKDDCJL()
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (kfhelhglnmh == null)
		{
			return this.DFHGAOMBMPB[0];
		}
		BOIKJDICEMF.BGJKMCBHNAK result = this.CIOEFGAIDNC(BOIKJDICEMF.JGHABIPEEEO.Poplavok);
		int num = kfhelhglnmh.GMLFCKNNOPJ();
		if (num == 80)
		{
			result = this.CIOEFGAIDNC((BOIKJDICEMF.JGHABIPEEEO)8);
		}
		if (num == 19)
		{
			result = this.MNCBACCMAAA(BOIKJDICEMF.JGHABIPEEEO.Poplavok);
		}
		return result;
	}

	// Token: 0x060040FD RID: 16637 RVA: 0x001D6278 File Offset: 0x001D4478
	public BOIKJDICEMF.BGJKMCBHNAK DGIPCIKEJII(int MPBFBMAPHJC)
	{
		switch (MPBFBMAPHJC)
		{
		case -90:
			return this.DFHGAOMBMPB[0];
		case -89:
			return this.DFHGAOMBMPB[8];
		case -88:
			return this.DFHGAOMBMPB[1];
		default:
			return null;
		}
	}

	// Token: 0x060040FE RID: 16638 RVA: 0x001D62B0 File Offset: 0x001D44B0
	public void AACBHMPHHFM()
	{
		for (int i = 0; i < this.DFHGAOMBMPB.Length; i++)
		{
			if (this.DFHGAOMBMPB[i] == null)
			{
				this.DFHGAOMBMPB[i] = new BOIKJDICEMF.BGJKMCBHNAK();
			}
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH == null)
		{
			return;
		}
		this.AKJEIJIOLDH = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 6);
		this.DIPHDPIFNGC(this.DFHGAOMBMPB[0], (int)(100L + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_orderb_0") * 100L), BOIKJDICEMF.JGHABIPEEEO.Poplavok);
		this.DIPHDPIFNGC(this.DFHGAOMBMPB[1], (int)(102L + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_orderb_2") * 100L), BOIKJDICEMF.JGHABIPEEEO.Spinning);
		this.DIPHDPIFNGC(this.DFHGAOMBMPB[2], (int)(101L + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_orderb_1") * 100L), BOIKJDICEMF.JGHABIPEEEO.Fider);
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
		if (bgjkmcbhnak.IKKPFPJLPOL)
		{
			try
			{
				if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					if (bgjkmcbhnak.AMLEOGHNNPG[0] != null)
					{
						bgjkmcbhnak.AHELGDAMAEE = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.AMLEOGHNNPG[0].HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.NKNCNHGDMLF != null)
					{
						bgjkmcbhnak.NBHHHBNLBPE = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.NKNCNHGDMLF.HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.LJCLFFINEHJ != null)
					{
						bgjkmcbhnak.PJPIDGGKADI = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.LJCLFFINEHJ.HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.PFNCHEEEBKD != null)
					{
						bgjkmcbhnak.CPEEOJICPCB = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.PFNCHEEEBKD.HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.IFNNBJDJBNA > bgjkmcbhnak.KFEPCNBDMIH)
					{
						bgjkmcbhnak.IFNNBJDJBNA = bgjkmcbhnak.KFEPCNBDMIH;
					}
				}
				if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
				{
					if (bgjkmcbhnak.AMLEOGHNNPG[0] != null)
					{
						bgjkmcbhnak.AHELGDAMAEE = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.AMLEOGHNNPG[0].HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.NKNCNHGDMLF != null)
					{
						bgjkmcbhnak.NBHHHBNLBPE = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.NKNCNHGDMLF.HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.LJCLFFINEHJ != null)
					{
						bgjkmcbhnak.PJPIDGGKADI = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.LJCLFFINEHJ.HHOLFABGDJA), 0, null, "");
					}
				}
				if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
				{
					bgjkmcbhnak.AHELGDAMAEE = null;
					if (bgjkmcbhnak.NKNCNHGDMLF != null)
					{
						bgjkmcbhnak.NBHHHBNLBPE = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.NKNCNHGDMLF.HHOLFABGDJA), 0, null, "");
					}
					if (bgjkmcbhnak.LJCLFFINEHJ != null)
					{
						bgjkmcbhnak.PJPIDGGKADI = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(bgjkmcbhnak.LJCLFFINEHJ.HHOLFABGDJA), 0, null, "");
					}
				}
				if (bgjkmcbhnak.AANHBNICFDL == 1)
				{
					bgjkmcbhnak.PEFCCLINAPN = ObscuredFloat.GOOIABGKMHK(1.8f);
				}
				if (bgjkmcbhnak.AANHBNICFDL == 2)
				{
					bgjkmcbhnak.PEFCCLINAPN = ObscuredFloat.GOOIABGKMHK(1.6f);
				}
				bgjkmcbhnak.FOAAFGBHDAH = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.AGJPNGBDNFE(bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.OBEOJCGHOGL));
				bgjkmcbhnak.JJEFFBGECGL = bgjkmcbhnak.IIOHPBENEFI.KPLOLDJFGBE().x;
				bgjkmcbhnak.IGDMILBFAPF = bgjkmcbhnak.IIOHPBENEFI.KPLOLDJFGBE().y;
				if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
				{
					bgjkmcbhnak.JJEFFBGECGL /= 3f;
				}
				foreach (EKBAPCMPANI ekbapcmpani in bgjkmcbhnak.CBLCFLENIJL)
				{
					if (ekbapcmpani != null)
					{
						IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.BLJKHILCCDL(ekbapcmpani.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
						if (iibeekcaahk.JLLJFKOGLHJ / 1000f > bgjkmcbhnak.JJEFFBGECGL)
						{
							bgjkmcbhnak.JJEFFBGECGL = iibeekcaahk.JLLJFKOGLHJ / 1000f;
						}
						if (iibeekcaahk.OBEOJCGHOGL / 1000f < bgjkmcbhnak.IGDMILBFAPF)
						{
							bgjkmcbhnak.IGDMILBFAPF = iibeekcaahk.OBEOJCGHOGL / 1000f;
						}
					}
				}
				if (bgjkmcbhnak.JJEFFBGECGL > bgjkmcbhnak.IGDMILBFAPF)
				{
					bgjkmcbhnak.JJEFFBGECGL = bgjkmcbhnak.IGDMILBFAPF;
				}
				if (bgjkmcbhnak.IGDMILBFAPF < bgjkmcbhnak.JJEFFBGECGL)
				{
					bgjkmcbhnak.IGDMILBFAPF = bgjkmcbhnak.JJEFFBGECGL;
				}
				if (bgjkmcbhnak.GKAHEMBMCNC || bgjkmcbhnak.CJLKGICPCAJ <= 0f)
				{
					bgjkmcbhnak.NPPJLGLHBJH();
				}
				goto IL_47D;
			}
			catch (Exception message)
			{
				Debug.LogError(message);
				goto IL_47D;
			}
		}
		bgjkmcbhnak.FOAAFGBHDAH = ObscuredFloat.GOOIABGKMHK(0f);
		bgjkmcbhnak.JJEFFBGECGL = 0f;
		bgjkmcbhnak.IGDMILBFAPF = 0f;
		IL_47D:
		if (LocNewLogic.getI != null)
		{
			LocNewLogic.getI.updateImages(this.MPMLJCLEKJP());
		}
		if (Fisherman.getI != null)
		{
			if (!bgjkmcbhnak.IKKPFPJLPOL)
			{
				Fisherman.getI.MFENINHGBHM = false;
			}
			if (Fisherman.getI.dropScrpt != null && bgjkmcbhnak.PBFACOEKPMN && Fisherman.getI.CDNABIHPLHM)
			{
				LocNewLogic.getI.fishDown(false, false);
				Fisherman.getI.CIHILMCEJND = false;
			}
		}
		this.FBCPDABDHOB();
	}

	// Token: 0x060040FF RID: 16639 RVA: 0x001D67D8 File Offset: 0x001D49D8
	public BOIKJDICEMF.BGJKMCBHNAK FJGNFCPLNNF(int MPBFBMAPHJC)
	{
		switch (MPBFBMAPHJC)
		{
		case -56:
			return this.DFHGAOMBMPB[0];
		case -55:
			return this.DFHGAOMBMPB[2];
		case -54:
			return this.DFHGAOMBMPB[1];
		default:
			return null;
		}
	}

	// Token: 0x06004100 RID: 16640 RVA: 0x001D6810 File Offset: 0x001D4A10
	public float HLNMIAPENEO(float DKIHDOELFEH)
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
		float num = 0.4f;
		float num2 = this.MEPKMAFJIOL;
		float num3 = 0.3f;
		float num4 = DKIHDOELFEH - num2;
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		float num5 = (100f - (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) * 1.3f) / 100f;
		float num6 = 1f - (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(405) * 0.1f;
		num6 = Mathf.Clamp(num6, 0.1f, 1f);
		num5 = Mathf.Clamp(num5, 0.1f, 1f);
		float num7 = num + num4 * num3 * num5 * num6;
		if (bgjkmcbhnak != null)
		{
			switch (bgjkmcbhnak.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			{
				float num8 = 0.2f;
				num3 = 0.2f;
				num7 = num8 + num4 * num3 * (num5 * 0.8f) * num6;
				num7 *= 0.75f;
				if (bgjkmcbhnak.AANHBNICFDL == 1)
				{
					num7 *= 0.5f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 2)
				{
					num7 *= 1.2f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 3)
				{
					num7 *= 1.8f;
				}
				break;
			}
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			{
				float num9 = 0.35f;
				num3 = 0.18f;
				num7 = num9 + num4 * num3 * num5 * num6;
				num7 *= 1f;
				if (bgjkmcbhnak.AANHBNICFDL == 1)
				{
					num7 *= 0.8f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 2)
				{
					num7 *= 1.2f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 3)
				{
					num7 *= 1.5f;
				}
				break;
			}
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				float num10 = 0.5f;
				num3 = 0.26f;
				num7 = num10 + num4 * num3 * num5 * num6;
				num7 *= 1f;
				if (bgjkmcbhnak.AANHBNICFDL == 1)
				{
					num7 *= 0.8f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 2)
				{
					num7 *= 1.2f;
				}
				if (bgjkmcbhnak.AANHBNICFDL == 3)
				{
					num7 *= 1.5f;
				}
				break;
			}
			}
		}
		return num7;
	}

	// Token: 0x06004101 RID: 16641 RVA: 0x001D6A0C File Offset: 0x001D4C0C
	public BOIKJDICEMF.BGJKMCBHNAK MNCBACCMAAA(int MPBFBMAPHJC)
	{
		switch (MPBFBMAPHJC)
		{
		case 100:
			return this.DFHGAOMBMPB[0];
		case 101:
			return this.DFHGAOMBMPB[2];
		case 102:
			return this.DFHGAOMBMPB[1];
		default:
			return null;
		}
	}

	// Token: 0x06004102 RID: 16642 RVA: 0x001D6A41 File Offset: 0x001D4C41
	public void DECHOHGOAHF(LineRenderer CLBOFPLFKHD)
	{
		CLBOFPLFKHD.material.SetColor("_TintColor", this.BAKLDPLGDEB());
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06004103 RID: 16643 RVA: 0x001D6A5C File Offset: 0x001D4C5C
	public float MEPKMAFJIOL
	{
		get
		{
			float num = 2f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
			if (bgjkmcbhnak != null && bgjkmcbhnak.NKNCNHGDMLF != null)
			{
				switch (bgjkmcbhnak.DFBHMIIPLCA)
				{
				case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
					num += bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 0.6f;
					num = Mathf.Clamp(num, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 1.1f, 100f);
					break;
				case BOIKJDICEMF.JGHABIPEEEO.Spinning:
					num = 5f + bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 0.8f;
					num = Mathf.Clamp(num, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 2f, 100f);
					break;
				case BOIKJDICEMF.JGHABIPEEEO.Fider:
					num = 5f + bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 0.8f;
					num = Mathf.Clamp(num, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL * 2f, 100f);
					break;
				}
			}
			return num;
		}
	}

	// Token: 0x06004104 RID: 16644 RVA: 0x001D6B68 File Offset: 0x001D4D68
	private void DIPHDPIFNGC(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK, int JGNIDDBNGGP, BOIKJDICEMF.JGHABIPEEEO DFBHMIIPLCA)
	{
		JLJJKMLJBAK.CKBGHMMOAEM = null;
		JLJJKMLJBAK.DFBHMIIPLCA = DFBHMIIPLCA;
		JLJJKMLJBAK.NKNCNHGDMLF = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 1);
		JLJJKMLJBAK.LJCLFFINEHJ = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 2);
		JLJJKMLJBAK.IIOHPBENEFI = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 3);
		JLJJKMLJBAK.PFNCHEEEBKD = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 4);
		JLJJKMLJBAK.CBLCFLENIJL[0] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 10);
		JLJJKMLJBAK.CBLCFLENIJL[1] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 11);
		JLJJKMLJBAK.CBLCFLENIJL[2] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 12);
		JLJJKMLJBAK.AMLEOGHNNPG[0] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 20);
		JLJJKMLJBAK.AMLEOGHNNPG[1] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 21);
		JLJJKMLJBAK.AMLEOGHNNPG[2] = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 22);
		JLJJKMLJBAK.CKBGHMMOAEM = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(JGNIDDBNGGP, 5);
		if (this.OJLPPKBKDBL != BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			if (JLJJKMLJBAK.CBLCFLENIJL[0] == null)
			{
				JLJJKMLJBAK.AMLEOGHNNPG[0] = null;
			}
			if (JLJJKMLJBAK.CBLCFLENIJL[1] == null)
			{
				JLJJKMLJBAK.AMLEOGHNNPG[1] = null;
			}
			if (JLJJKMLJBAK.CBLCFLENIJL[2] == null)
			{
				JLJJKMLJBAK.AMLEOGHNNPG[2] = null;
			}
		}
		long lgeljlocaop = JLJJKMLJBAK.LGELJLOCAOP;
		long cgefcapmhdi = JLJJKMLJBAK.CGEFCAPMHDI;
		JLJJKMLJBAK.LGELJLOCAOP = 0L;
		if (JLJJKMLJBAK.NKNCNHGDMLF != null)
		{
			JLJJKMLJBAK.LGELJLOCAOP += JLJJKMLJBAK.NKNCNHGDMLF.LPFKFNLHGBI;
		}
		if (JLJJKMLJBAK.LJCLFFINEHJ != null)
		{
			JLJJKMLJBAK.LGELJLOCAOP += JLJJKMLJBAK.LJCLFFINEHJ.LPFKFNLHGBI;
		}
		if (JLJJKMLJBAK.IIOHPBENEFI != null)
		{
			JLJJKMLJBAK.LGELJLOCAOP += JLJJKMLJBAK.IIOHPBENEFI.LPFKFNLHGBI;
		}
		JLJJKMLJBAK.CGEFCAPMHDI = JLJJKMLJBAK.LGELJLOCAOP;
		if (JLJJKMLJBAK.CBLCFLENIJL[0] != null)
		{
			JLJJKMLJBAK.LGELJLOCAOP += JLJJKMLJBAK.CBLCFLENIJL[0].LPFKFNLHGBI;
		}
		if (JLJJKMLJBAK.AMLEOGHNNPG[0] != null)
		{
			JLJJKMLJBAK.LGELJLOCAOP += JLJJKMLJBAK.AMLEOGHNNPG[0].LPFKFNLHGBI;
		}
		JLJJKMLJBAK.PBFACOEKPMN = (lgeljlocaop != JLJJKMLJBAK.LGELJLOCAOP);
		JLJJKMLJBAK.GKAHEMBMCNC = (cgefcapmhdi != JLJJKMLJBAK.CGEFCAPMHDI);
		if (JLJJKMLJBAK.GKAHEMBMCNC)
		{
			Debug.Log("************ isChangedRod *********");
		}
		JLJJKMLJBAK.AGHLFMJIMHB();
		JLJJKMLJBAK.AANHBNICFDL = 0;
		if (JLJJKMLJBAK.NKNCNHGDMLF != null && JLJJKMLJBAK.LJCLFFINEHJ != null && JLJJKMLJBAK.IIOHPBENEFI != null)
		{
			JLJJKMLJBAK.AANHBNICFDL = JLJJKMLJBAK.NKNCNHGDMLF.BDHHPAEHFHG.GCLKLEIMABA;
			if (JLJJKMLJBAK.LJCLFFINEHJ.BDHHPAEHFHG.GCLKLEIMABA != JLJJKMLJBAK.AANHBNICFDL)
			{
				JLJJKMLJBAK.IKKPFPJLPOL = false;
			}
			if (JLJJKMLJBAK.IIOHPBENEFI.BDHHPAEHFHG.GCLKLEIMABA != JLJJKMLJBAK.AANHBNICFDL)
			{
				JLJJKMLJBAK.IKKPFPJLPOL = false;
			}
		}
		if (JLJJKMLJBAK.NKNCNHGDMLF != null)
		{
			JLJJKMLJBAK.AANHBNICFDL = JLJJKMLJBAK.NKNCNHGDMLF.BDHHPAEHFHG.GCLKLEIMABA;
		}
	}

	// Token: 0x06004105 RID: 16645 RVA: 0x001D6E34 File Offset: 0x001D5034
	public float CHCJILPBABD()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return 10f;
		}
		float num;
		if (bgjkmcbhnak.IIOHPBENEFI != null)
		{
			float max = 0f;
			num = bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.KGKNPAAMDJK;
			if (bgjkmcbhnak.LJCLFFINEHJ != null)
			{
				max = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.AGJPNGBDNFE(bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.OBEOJCGHOGL);
			}
			num = Mathf.Clamp(num, 0.1f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.KGKNPAAMDJK);
			num = Mathf.Clamp(num, 0.1f, max);
		}
		else
		{
			num = 0.1f;
		}
		return num;
	}

	// Token: 0x06004106 RID: 16646 RVA: 0x001D6ED4 File Offset: 0x001D50D4
	public Color BAKLDPLGDEB()
	{
		if (this.MPMLJCLEKJP() == null)
		{
			return Color.gray;
		}
		if (this.MPMLJCLEKJP().IIOHPBENEFI == null)
		{
			return Color.gray;
		}
		return GuiProcessor.IKGFHGKKCPG.lineColors[this.MPMLJCLEKJP().IIOHPBENEFI.BDHHPAEHFHG.MNKBNODBHEL];
	}

	// Token: 0x06004107 RID: 16647 RVA: 0x001D6F28 File Offset: 0x001D5128
	public Color BHDJOFEHHKN()
	{
		if (this.FALNIKDDCJL() == null)
		{
			return Color.gray;
		}
		if (this.MPMLJCLEKJP().IIOHPBENEFI == null)
		{
			return Color.gray;
		}
		return GuiProcessor.BBLINJLBAIL().lineColors[this.MPMLJCLEKJP().IIOHPBENEFI.BDHHPAEHFHG.MNKBNODBHEL];
	}

	// Token: 0x06004108 RID: 16648 RVA: 0x001D6F7A File Offset: 0x001D517A
	public BOIKJDICEMF.BGJKMCBHNAK LPOLHKLBJKN(int CLBPBJGLHEE)
	{
		return this.DFHGAOMBMPB[CLBPBJGLHEE];
	}

	// Token: 0x06004109 RID: 16649 RVA: 0x001D6F7A File Offset: 0x001D517A
	public BOIKJDICEMF.BGJKMCBHNAK PAGGOCBABNO(int CLBPBJGLHEE)
	{
		return this.DFHGAOMBMPB[CLBPBJGLHEE];
	}

	// Token: 0x0600410A RID: 16650 RVA: 0x001D6F84 File Offset: 0x001D5184
	public float PGHPFFNILCD()
	{
		float num = 1992f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.ELBKLOECINC);
		if (this.FALNIKDDCJL() != null && this.FALNIKDDCJL().LJCLFFINEHJ != null)
		{
			num += num * (this.FALNIKDDCJL().LJCLFFINEHJ.LODGJCMEGAI.PDMNLDLGJNG() / 504f);
		}
		return num;
	}

	// Token: 0x0600410B RID: 16651 RVA: 0x001D6FE4 File Offset: 0x001D51E4
	public BOIKJDICEMF.BGJKMCBHNAK MPMLJCLEKJP()
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (kfhelhglnmh == null)
		{
			return this.DFHGAOMBMPB[0];
		}
		BOIKJDICEMF.BGJKMCBHNAK result = this.MNCBACCMAAA(BOIKJDICEMF.JGHABIPEEEO.Poplavok);
		int num = kfhelhglnmh.GMLFCKNNOPJ();
		if (num == 101)
		{
			result = this.MNCBACCMAAA(BOIKJDICEMF.JGHABIPEEEO.Fider);
		}
		if (num == 102)
		{
			result = this.MNCBACCMAAA(BOIKJDICEMF.JGHABIPEEEO.Spinning);
		}
		return result;
	}

	// Token: 0x0600410C RID: 16652 RVA: 0x001D7030 File Offset: 0x001D5230
	public int FCAONKOECHJ()
	{
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		if (num == 100)
		{
			return 0;
		}
		if (num == 101)
		{
			return 2;
		}
		if (num == 102)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600410D RID: 16653 RVA: 0x001D7064 File Offset: 0x001D5264
	public void FBCPDABDHOB()
	{
		if (this.MPMLJCLEKJP() == null)
		{
			return;
		}
		if (this.MPMLJCLEKJP().IIOHPBENEFI != null)
		{
			Color value = GuiProcessor.IKGFHGKKCPG.lineColors[this.MPMLJCLEKJP().IIOHPBENEFI.BDHHPAEHFHG.MNKBNODBHEL];
			if (this.AOEGNGOGNBI != null)
			{
				if (this.AOEGNGOGNBI.LRRod)
				{
					this.AOEGNGOGNBI.LRRod.material.SetColor("_TintColor", value);
				}
				if (this.AOEGNGOGNBI.LRLine)
				{
					this.AOEGNGOGNBI.LRLine.material.SetColor("_TintColor", value);
				}
				if (this.AOEGNGOGNBI.LRRod)
				{
					this.AOEGNGOGNBI.LRRod.material.SetColor("_Color", value);
				}
				if (this.AOEGNGOGNBI.LRLine)
				{
					this.AOEGNGOGNBI.LRLine.material.SetColor("_Color", value);
				}
			}
		}
	}

	// Token: 0x0600410E RID: 16654 RVA: 0x001D7174 File Offset: 0x001D5374
	public float ELKFFLKOIBF(float DKIHDOELFEH)
	{
		float num = this.MEPKMAFJIOL;
		float num2 = (1156f - (float)ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.EDICLBDIPGG) * 985f) / 1284f;
		num2 = Mathf.Clamp(num2, 1936f, 1532f);
		float num3 = DKIHDOELFEH - num;
		if (num3 < 177f)
		{
			num3 = 100f;
		}
		return (0f + num3 * 1161f * num2) * 882f;
	}

	// Token: 0x0600410F RID: 16655 RVA: 0x001D71E8 File Offset: 0x001D53E8
	public BOIKJDICEMF.BGJKMCBHNAK AFNBANEEFLI(int MPBFBMAPHJC)
	{
		switch (MPBFBMAPHJC)
		{
		case 125:
			return this.DFHGAOMBMPB[1];
		case 126:
			return this.DFHGAOMBMPB[8];
		case 127:
			return this.DFHGAOMBMPB[1];
		default:
			return null;
		}
	}

	// Token: 0x06004110 RID: 16656 RVA: 0x001D721D File Offset: 0x001D541D
	public void GGJABPFNCFM(float DCCPCBLODIG)
	{
		this.MPMLJCLEKJP().HFENEGIBAIG(Mathf.Clamp(DCCPCBLODIG, 240f, 871f));
	}

	// Token: 0x06004111 RID: 16657 RVA: 0x001D723A File Offset: 0x001D543A
	public void FOMMNNJLMAI(LineRenderer CLBOFPLFKHD)
	{
		CLBOFPLFKHD.material.SetColor("usercntinfo", this.AAINBHFKJOJ());
	}

	// Token: 0x06004112 RID: 16658 RVA: 0x001D7252 File Offset: 0x001D5452
	public BOIKJDICEMF.BGJKMCBHNAK MNCBACCMAAA(BOIKJDICEMF.JGHABIPEEEO DFBHMIIPLCA)
	{
		switch (DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			return this.DFHGAOMBMPB[0];
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			return this.DFHGAOMBMPB[1];
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			return this.DFHGAOMBMPB[2];
		default:
			return null;
		}
	}

	// Token: 0x06004113 RID: 16659 RVA: 0x001D7284 File Offset: 0x001D5484
	public void GFGBLCAILJE(float DCCPCBLODIG)
	{
		this.MPMLJCLEKJP().CLEJODCMJAA = Mathf.Clamp(DCCPCBLODIG, 98f, 251f);
	}

	// Token: 0x06004115 RID: 16661 RVA: 0x001D72B0 File Offset: 0x001D54B0
	public float BAHHLOGOIBK()
	{
		float num = 738f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.ELBKLOECINC);
		if (this.MPMLJCLEKJP() != null && this.MPMLJCLEKJP().LJCLFFINEHJ != null)
		{
			num += num * (this.FALNIKDDCJL().LJCLFFINEHJ.LODGJCMEGAI.OAAKPMLGJJH() / 1366f);
		}
		return num;
	}

	// Token: 0x06004116 RID: 16662 RVA: 0x001D7310 File Offset: 0x001D5510
	public float MPNKBOMCCEH(float DKIHDOELFEH)
	{
		float num = this.MEPKMAFJIOL;
		float num2 = (844f - (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.EDICLBDIPGG) * 338f) / 1584f;
		num2 = Mathf.Clamp(num2, 1899f, 69f);
		float num3 = DKIHDOELFEH - num;
		if (num3 < 1999f)
		{
			num3 = 1694f;
		}
		return (1350f + num3 * 1381f * num2) * 1900f;
	}

	// Token: 0x06004117 RID: 16663 RVA: 0x001D7384 File Offset: 0x001D5584
	public float ANEPEHDAFHP()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = this.MPMLJCLEKJP();
		float num = 783f;
		if (bgjkmcbhnak != null && bgjkmcbhnak.NKNCNHGDMLF != null)
		{
			float num2 = 1875f + (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(-69) / 1414f;
			num = this.CPHHGMPBACB(bgjkmcbhnak.NKNCNHGDMLF.MBKMKGABBGE, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI, 1);
			if (JLFJEGIPIMM.MHFDIJGJGBJ().EHEMCMKMECH(2, bgjkmcbhnak.NKNCNHGDMLF.OKHPDILIOCH))
			{
				num = this.CPHHGMPBACB(bgjkmcbhnak.NKNCNHGDMLF.MBKMKGABBGE, bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI, 8);
			}
			num *= num2;
			BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
			if (dfbhmiiplca != BOIKJDICEMF.JGHABIPEEEO.Spinning)
			{
				if (dfbhmiiplca == (BOIKJDICEMF.JGHABIPEEEO)5)
				{
					float num3 = bgjkmcbhnak.ILOBPLGPOCO();
					float num4 = (float)bgjkmcbhnak.NKNCNHGDMLF.ADOFHHCDGON;
					float num5 = (float)bgjkmcbhnak.NKNCNHGDMLF.ECKKCDKHNEH;
					if (num5 > 1297f)
					{
						float num6 = (num3 - num4) / (num5 - num4);
						num6 = Mathf.Clamp(num6, 1653f, 919f);
						float num7 = Mathf.LerpUnclamped(1822f, 347f, num6);
						num *= num7;
					}
					if (Fisherman.getI.OHKDFALEMNL())
					{
						num *= 479f;
					}
				}
			}
			else
			{
				float num8 = bgjkmcbhnak.LPFDCFAIAEM();
				float num9 = (float)bgjkmcbhnak.NKNCNHGDMLF.ADOFHHCDGON;
				float num10 = (float)bgjkmcbhnak.NKNCNHGDMLF.ECKKCDKHNEH;
				if (num10 > 1763f)
				{
					float num11 = (num8 - num9) / (num10 - num9);
					num11 = Mathf.Clamp(num11, 626f, 442f);
					float num12 = Mathf.LerpUnclamped(1959f, 1028f, num11);
					num *= num12;
				}
				if (Fisherman.getI.OHKDFALEMNL())
				{
					num *= 46f;
				}
			}
		}
		if (bgjkmcbhnak.IIOHPBENEFI != null)
		{
			float max = 1417f;
			if (bgjkmcbhnak.LJCLFFINEHJ != null)
			{
				max = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.AKFDHBAJEAJ(bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PDMNLDLGJNG());
			}
			num = Mathf.Clamp(num, 723f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.FIAMGODLKFA());
			num = Mathf.Clamp(num, 122f, max);
		}
		else
		{
			num = 420f;
		}
		return num;
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06004118 RID: 16664 RVA: 0x001D75A4 File Offset: 0x001D57A4
	public float JEJMHADHCLH
	{
		get
		{
			float num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNGLPHCCGDF();
			if (this.MPMLJCLEKJP() != null && this.MPMLJCLEKJP().LJCLFFINEHJ != null)
			{
				num += this.MPMLJCLEKJP().LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL * 0.3f;
			}
			return num;
		}
	}

	// Token: 0x06004119 RID: 16665 RVA: 0x001D75F8 File Offset: 0x001D57F8
	public float ADCJDAPEOOH(float DKIHDOELFEH)
	{
		float num = this.MEPKMAFJIOL;
		float num2 = (100f - (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) * 1.3f) / 100f;
		num2 = Mathf.Clamp(num2, 0.1f, 1f);
		float num3 = DKIHDOELFEH - num;
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		return (0.5f + num3 * 0.32f * num2) * 1.2f;
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x001D766C File Offset: 0x001D586C
	public float CPHHGMPBACB(int MBKMKGABBGE, IIBEEKCAAHK JIOBNFELJHI, int JJJNKODLEEL = 1)
	{
		float num = 2.1f;
		switch (MBKMKGABBGE)
		{
		case 1:
			num = 1f + JIOBNFELJHI.OBEOJCGHOGL * 2.1f;
			num *= 1f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 100f;
			if (JJJNKODLEEL == 2)
			{
				num += JIOBNFELJHI.OBEOJCGHOGL * 3.5f;
			}
			break;
		case 2:
			num = 7f + JIOBNFELJHI.OBEOJCGHOGL * 4.4f;
			num *= 1f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 150f;
			break;
		case 3:
			num = 7f + JIOBNFELJHI.OBEOJCGHOGL * 4f;
			num *= 1f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 150f;
			num *= 1.25f;
			break;
		}
		return num;
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x001D7760 File Offset: 0x001D5960
	public float GDPNONOLEAB()
	{
		float num = 399f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.ELBKLOECINC);
		if (this.MPMLJCLEKJP() != null && this.MPMLJCLEKJP().LJCLFFINEHJ != null)
		{
			num += num * (this.FALNIKDDCJL().LJCLFFINEHJ.LODGJCMEGAI.OAAKPMLGJJH() / 884f);
		}
		return num;
	}

	// Token: 0x040009A2 RID: 2466
	public static BOIKJDICEMF IKGFHGKKCPG = new BOIKJDICEMF();

	// Token: 0x040009A3 RID: 2467
	public bool JIBBDKGDGCD;

	// Token: 0x040009A4 RID: 2468
	private readonly BOIKJDICEMF.BGJKMCBHNAK[] DFHGAOMBMPB = new BOIKJDICEMF.BGJKMCBHNAK[4];

	// Token: 0x040009A5 RID: 2469
	public ObscuredFloat CDLAEGBICMA = ObscuredFloat.GOOIABGKMHK(0f);

	// Token: 0x040009A6 RID: 2470
	public EKBAPCMPANI AKJEIJIOLDH;

	// Token: 0x040009A7 RID: 2471
	public RodParams AOEGNGOGNBI;

	// Token: 0x040009A8 RID: 2472
	public RodPhysic IBPICCOBEFN;

	// Token: 0x040009A9 RID: 2473
	public RollParams ODBKIJBKPBB;

	// Token: 0x02000139 RID: 313
	public enum JGHABIPEEEO
	{
		// Token: 0x040009AB RID: 2475
		Poplavok,
		// Token: 0x040009AC RID: 2476
		Spinning,
		// Token: 0x040009AD RID: 2477
		Fider
	}

	// Token: 0x0200013A RID: 314
	public class BGJKMCBHNAK
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x001D77BF File Offset: 0x001D59BF
		public bool OHOJOANFECE
		{
			get
			{
				return this.GLNFJCIJHDL < 21;
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x001D77CB File Offset: 0x001D59CB
		public void AAINFMALAEN(ObscuredFloat DCCPCBLODIG)
		{
			this.<JALBCKBAEOD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x001D77D4 File Offset: 0x001D59D4
		public float KFEPCNBDMIH
		{
			get
			{
				if (this.NKNCNHGDMLF == null)
				{
					return 100f;
				}
				if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH == null)
				{
					return 100f;
				}
				return this.NKNCNHGDMLF.LODGJCMEGAI.KGKNPAAMDJK + this.NKNCNHGDMLF.LODGJCMEGAI.KGKNPAAMDJK * (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 200f;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x001D78D5 File Offset: 0x001D5AD5
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x001D783E File Offset: 0x001D5A3E
		public ObscuredFloat GIMFIFECPGL { get; set; }

		// Token: 0x06004120 RID: 16672 RVA: 0x001D7847 File Offset: 0x001D5A47
		public float EDNAPPHHHPI()
		{
			return Mathf.Clamp(this.NJBMIOABONL, 1421f, 788f);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x001D7860 File Offset: 0x001D5A60
		public float HNEEGDNEDHJ
		{
			get
			{
				float num = 5f + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 5f;
				if (this.LJCLFFINEHJ != null)
				{
					num += this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL * 0.2f;
				}
				return 8f * (1f + num / 100f);
			}
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x001D78C3 File Offset: 0x001D5AC3
		public int CMKFMNBBPNE()
		{
			return Mathf.RoundToInt(ObscuredFloat.PFCANBAOMCB(this.OGCIFKNBPMA));
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001D78D5 File Offset: 0x001D5AD5
		public ObscuredFloat MPKJDFOMBLI()
		{
			return this.<JOIKHDFHNIE>k__BackingField;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x001D78E0 File Offset: 0x001D5AE0
		public float MKPBNPLJEDL
		{
			get
			{
				float num = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 3f;
				if (this.LJCLFFINEHJ != null)
				{
					num += this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL * 0.6f;
				}
				float num2 = Mathf.Clamp(50f + num, 15f, 80f);
				if (this.AANHBNICFDL == 0)
				{
					num2 *= 3.2f;
				}
				if (this.AANHBNICFDL == 1)
				{
					num2 *= 2.2f;
				}
				if (this.AANHBNICFDL == 2)
				{
					num2 *= 1.5f;
				}
				float num3 = Mathf.Clamp(this.LGALGHAPJND - 50f, 0f, 50f) / 12f * 1f;
				num3 = Mathf.Clamp(num3, 1f, 10f);
				num2 *= num3;
				float num4 = BOIKJDICEMF.IKGFHGKKCPG.ENDGIODBEEE * 1000f;
				float num5 = (2f * num4 + 1f) / (ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) + 1f);
				num5 = Mathf.Lerp(0.3f, 1.5f, num5);
				if (!Fisherman.getI.CDNABIHPLHM)
				{
					num5 = 1f;
				}
				return num2 * num5;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x001D8AB8 File Offset: 0x001D6CB8
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x001D7A0E File Offset: 0x001D5C0E
		public float CJLKGICPCAJ
		{
			get
			{
				return ObscuredFloat.GOOIABGKMHK(this.OGCIFKNBPMA);
			}
			set
			{
				this.OGCIFKNBPMA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(value, 0f, 21f));
			}
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x001D7A2C File Offset: 0x001D5C2C
		public int EGOMGPGLCCJ()
		{
			int result = 0;
			if (ObscuredFloat.EJGOOFALNFF(this.NKHBAJKMAGD) > 1368f)
			{
				result = 1;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) > 1691f)
			{
				result = 7;
			}
			return result;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x001D7A64 File Offset: 0x001D5C64
		public float EFEJJFGGMOF
		{
			get
			{
				float num = 1f;
				float num2 = 1f;
				if (this.IIOHPBENEFI != null)
				{
					if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 1)
					{
						num = 2f;
					}
					if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 2)
					{
						num = 1.5f;
					}
					if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 3)
					{
						num = 0.8f;
					}
					if (Fisherman.getI != null && Fisherman.getI.CDNABIHPLHM)
					{
						FishOnRod fish = Fisherman.getI.dropScrpt.fish;
						num2 = Mathf.Clamp(0.7f, 1.5f, fish.stamKf * ObscuredFloat.GOOIABGKMHK(this.JDIBHEGKALB) / 100f);
					}
				}
				return num * num2;
			}
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x001D7B27 File Offset: 0x001D5D27
		public float ENMACOFAHKG()
		{
			return ObscuredFloat.OBJFODGFMAM(this.OGCIFKNBPMA);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x001D7B34 File Offset: 0x001D5D34
		public void JCIMMJOIBJJ(int NBNMDELPFDM)
		{
			int num = Mathf.CeilToInt(this.JLHNJMPEDAO / 5f) * 5;
			num += NBNMDELPFDM * 5;
			this.JLHNJMPEDAO = (float)num;
			this.JLHNJMPEDAO = Mathf.Clamp(this.JLHNJMPEDAO, 10f, 70f);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x001D7B80 File Offset: 0x001D5D80
		public bool NLOIDGLMPMO()
		{
			bool result = ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) > 571f;
			if (this.DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)5)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x001D7BAC File Offset: 0x001D5DAC
		public float FAFHKDGNCLH
		{
			get
			{
				return this.IFNNBJDJBNA / 100f;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x001D8551 File Offset: 0x001D6751
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x001D7BBA File Offset: 0x001D5DBA
		public ObscuredFloat EALPPCJHPKG { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x001D7EF1 File Offset: 0x001D60F1
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public ObscuredFloat OGLIEFLNLLE { get; set; }

		// Token: 0x0600412E RID: 16686 RVA: 0x001D7BCC File Offset: 0x001D5DCC
		public void NPPJLGLHBJH()
		{
			float b = this.LJCLFFINEHJ.LODGJCMEGAI.KGKNPAAMDJK;
			float num = Mathf.Min(this.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 0.8f, this.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 0.8f);
			num = Mathf.Min(num, b);
			float dccpcblodig = 100f * num / this.LJCLFFINEHJ.LODGJCMEGAI.KGKNPAAMDJK / 5f;
			this.OGCIFKNBPMA = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x001D7C50 File Offset: 0x001D5E50
		public float HHLKHCPDEOF()
		{
			float num = 1929f;
			if (this.IIOHPBENEFI != null)
			{
				num = ObscuredFloat.PFCANBAOMCB(this.LODEKEHKOKP) * 1852f;
			}
			if (this.LJCLFFINEHJ != null)
			{
				num *= 257f + this.LJCLFFINEHJ.LODGJCMEGAI.PDMNLDLGJNG() / 644f;
			}
			float num2 = 303f;
			if (this.AANHBNICFDL == 0)
			{
				num2 *= 643f;
			}
			if (this.AANHBNICFDL == 0)
			{
				num2 *= 1516f;
			}
			if (this.AANHBNICFDL == 7)
			{
				num2 *= 72f;
			}
			return num * num2;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x001D7CE4 File Offset: 0x001D5EE4
		public float DNGEAIGBDIJ()
		{
			float num = 0.1f;
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 1)
			{
				num = 0.08f;
			}
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 2)
			{
				num = 0.2f;
			}
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 3)
			{
				num = 0.25f;
			}
			float num2 = num;
			float num3 = Mathf.Clamp(this.LGALGHAPJND, 0f, 100f) / 100f;
			return num2 + (1f - num3) * 0.1f;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x001D7D70 File Offset: 0x001D5F70
		public float FLHLDIJCPKG()
		{
			float num = 725f;
			float num2 = 1908f;
			if (this.IIOHPBENEFI != null)
			{
				if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 0)
				{
					num = 356f;
				}
				if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 2)
				{
					num = 304f;
				}
				if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 1)
				{
					num = 1785f;
				}
				if (Fisherman.getI != null && Fisherman.getI.CDNABIHPLHM)
				{
					FishOnRod fish = Fisherman.getI.dropScrpt.fish;
					num2 = Mathf.Clamp(1050f, 1729f, fish.stamKf * ObscuredFloat.OBJFODGFMAM(this.JDIBHEGKALB) / 1336f);
				}
			}
			return num * num2;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x001D7E33 File Offset: 0x001D6033
		// (set) Token: 0x0600415B RID: 16731 RVA: 0x001D866E File Offset: 0x001D686E
		public float CLEJODCMJAA
		{
			get
			{
				return this.JLHNJMPEDAO;
			}
			set
			{
				this.JLHNJMPEDAO = value;
				this.JLHNJMPEDAO = Mathf.Clamp(this.JLHNJMPEDAO, 10f, 70f);
			}
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001D7E3B File Offset: 0x001D603B
		public void GLKEIPMPKAH(float DCCPCBLODIG)
		{
			this.JLHNJMPEDAO = DCCPCBLODIG;
			this.JLHNJMPEDAO = Mathf.Clamp(this.JLHNJMPEDAO, 1451f, 344f);
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001D7E60 File Offset: 0x001D6060
		public float BJGMDBIENCA()
		{
			float num = 2f;
			if (this.IIOHPBENEFI != null)
			{
				num = ObscuredFloat.GOOIABGKMHK(this.LODEKEHKOKP) * 1f;
			}
			if (this.LJCLFFINEHJ != null)
			{
				num *= 1f + this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL / 150f;
			}
			float num2 = 1f;
			if (this.AANHBNICFDL == 0)
			{
				num2 *= 1f;
			}
			if (this.AANHBNICFDL == 1)
			{
				num2 *= 1.1f;
			}
			if (this.AANHBNICFDL == 2)
			{
				num2 *= 1.2f;
			}
			return num * num2;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x001D7EF9 File Offset: 0x001D60F9
		public void APMPEDEIPLI(ObscuredFloat DCCPCBLODIG)
		{
			this.<IABBIGOBIGM>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001D7F04 File Offset: 0x001D6104
		public float MADFPIIFGEA()
		{
			float num = 1446f;
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 1)
			{
				num = 1073f;
			}
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 5)
			{
				num = 1808f;
			}
			if (this.IIOHPBENEFI.BDHHPAEHFHG.ILOCKJIAPFC == 6)
			{
				num = 1128f;
			}
			float num2 = num;
			float num3 = Mathf.Clamp(this.LGALGHAPJND, 809f, 678f) / 1473f;
			return num2 + (549f - num3) * 302f;
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x001D7F8D File Offset: 0x001D618D
		public ObscuredFloat JIBAECPPNPL()
		{
			return this.<IABBIGOBIGM>k__BackingField;
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001D7F98 File Offset: 0x001D6198
		public void MKOJMJKKEBE()
		{
			float num = 2f - this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL / 100f;
			if (this.AKPEBMLBHJA < this.NJBMIOABONL)
			{
				num = 2f + this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL / 20f;
			}
			this.NJBMIOABONL = Mathf.Lerp(this.NJBMIOABONL, this.AKPEBMLBHJA, Time.deltaTime * num);
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x001D800C File Offset: 0x001D620C
		public int DIKFPCMKJAK()
		{
			int result = 0;
			if (ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) > 1000f)
			{
				result = 1;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) > 5000f)
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public void BBMNOEDOFDJ(ObscuredFloat DCCPCBLODIG)
		{
			this.<OLJAAEGBGKJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x001D8044 File Offset: 0x001D6244
		public float DCICGEENANE()
		{
			return this.IFELKILNKFP() / 848f;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x001D7F8D File Offset: 0x001D618D
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x001D7EF9 File Offset: 0x001D60F9
		public ObscuredFloat BMJKLAAKEIC { get; set; }

		// Token: 0x0600413E RID: 16702 RVA: 0x001D8054 File Offset: 0x001D6254
		public void EBBCKAIJHPO(int NBNMDELPFDM)
		{
			int num = Mathf.CeilToInt(this.JLHNJMPEDAO / 1219f) * 0;
			num += NBNMDELPFDM * 4;
			this.JLHNJMPEDAO = (float)num;
			this.JLHNJMPEDAO = Mathf.Clamp(this.JLHNJMPEDAO, 1042f, 436f);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x001D80A0 File Offset: 0x001D62A0
		public bool PIJNKIOJEJF
		{
			get
			{
				bool result = ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) > 800f;
				if (this.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x001D80CC File Offset: 0x001D62CC
		public float AAGGJACBMEC
		{
			get
			{
				float num = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 3f;
				if (this.LJCLFFINEHJ != null)
				{
					num += this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL;
				}
				return Mathf.Clamp(50f - num, 15f, 80f);
			}
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public void ACAOJOGNHGC(ObscuredFloat DCCPCBLODIG)
		{
			this.<OLJAAEGBGKJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x001D8128 File Offset: 0x001D6328
		public float KDHENOMNPHK
		{
			get
			{
				if (this.GLNFJCIJHDL == 21)
				{
					return 1E+11f;
				}
				if (this.GLNFJCIJHDL == 0)
				{
					return 0f;
				}
				float num = ObscuredFloat.GOOIABGKMHK(this.OGCIFKNBPMA) * 5f;
				float num2 = 0f;
				if (this.LJCLFFINEHJ != null)
				{
					num2 = num * this.LJCLFFINEHJ.LODGJCMEGAI.KGKNPAAMDJK / 100f * 1000f;
				}
				return Mathf.Ceil(num2 / 100f) * 100f / 1000f;
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x001D81AC File Offset: 0x001D63AC
		public void FBNCAHONHIP()
		{
			this.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(0f);
			this.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(0f);
			this.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0f);
			this.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(0f);
			this.JBLKFABJAMA = ObscuredFloat.GOOIABGKMHK(0f);
			this.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(0f);
			this.CCLOHHCJJAM = 0f;
			this.GAKPODHCHNB = ObscuredFloat.GOOIABGKMHK(0f);
			this.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
			this.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x001D8254 File Offset: 0x001D6454
		public void JFGJKGJODEG(float DCCPCBLODIG)
		{
			this.AKPEBMLBHJA = Mathf.Clamp(DCCPCBLODIG, 34f, 123f);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x001D826C File Offset: 0x001D646C
		public int GLNFJCIJHDL
		{
			get
			{
				return Mathf.RoundToInt(ObscuredFloat.GOOIABGKMHK(this.OGCIFKNBPMA));
			}
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001D77CB File Offset: 0x001D59CB
		public void MIHODKKEDMK(ObscuredFloat DCCPCBLODIG)
		{
			this.<JALBCKBAEOD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x001D827E File Offset: 0x001D647E
		public float CDEPPNBDLLK
		{
			get
			{
				return ObscuredFloat.GOOIABGKMHK(this.NKHBAJKMAGD) / 1000f;
			}
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x001D7F8D File Offset: 0x001D618D
		public ObscuredFloat CEOAIEDDJBP()
		{
			return this.<IABBIGOBIGM>k__BackingField;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x001D8C35 File Offset: 0x001D6E35
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x001D77CB File Offset: 0x001D59CB
		public ObscuredFloat GIMGAKKKHLF { get; set; }

		// Token: 0x0600414A RID: 16714 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public void OCFHDKPNJDA(ObscuredFloat DCCPCBLODIG)
		{
			this.<OLJAAEGBGKJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x001D8F81 File Offset: 0x001D7181
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x001D8294 File Offset: 0x001D6494
		public float LGALGHAPJND
		{
			get
			{
				return ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO);
			}
			set
			{
				this.LEMPPBMEJHP = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP) * 0.99f);
				this.LJNDGALCAKL = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL) * 0.99f);
				if (ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO) > value)
				{
					this.LEMPPBMEJHP = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP) + (ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO) - value) * (ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO) / 100f) * Time.deltaTime * 40f - ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL));
				}
				else
				{
					this.LEMPPBMEJHP = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP) - ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP) * Time.deltaTime * 3f);
				}
				if (ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO) < value)
				{
					this.LJNDGALCAKL = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL) + (value - ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO)) * (1f - ObscuredFloat.GOOIABGKMHK(this.LMILFGDPKJO) / 100f) * Time.deltaTime * 40f - ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP));
				}
				else
				{
					this.LJNDGALCAKL = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL) - ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL) * Time.deltaTime * 3f);
				}
				this.LEMPPBMEJHP = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.LEMPPBMEJHP), 0f, 100f));
				this.LJNDGALCAKL = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.LJNDGALCAKL), 0f, 100f));
				this.LMILFGDPKJO = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(value, 0f, 100f));
			}
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x001D845E File Offset: 0x001D665E
		public bool DFHKBBPDEAK()
		{
			return this.CMKFMNBBPNE() < -108;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public void CDBLOADCDAA(ObscuredFloat DCCPCBLODIG)
		{
			this.<OLJAAEGBGKJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x001D846A File Offset: 0x001D666A
		public void ALIOGHFOFHO(float DCCPCBLODIG)
		{
			this.OGCIFKNBPMA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(DCCPCBLODIG, 1134f, 244f));
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x001D8488 File Offset: 0x001D6688
		public float KKLEBEEGGDG()
		{
			if (this.NKNCNHGDMLF == null)
			{
				return 1709f;
			}
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH == null)
			{
				return 467f;
			}
			return this.NKNCNHGDMLF.LODGJCMEGAI.EPPEFJDDOHN() + this.NKNCNHGDMLF.LODGJCMEGAI.MLOEJFMIAIP() * (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 689f;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x001D84F4 File Offset: 0x001D66F4
		public float GDKDCJGPFGF
		{
			get
			{
				float result = 1f;
				if (this.NKNCNHGDMLF != null)
				{
					result = this.NKNCNHGDMLF.LODGJCMEGAI.OBEOJCGHOGL;
				}
				return result;
			}
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001D8524 File Offset: 0x001D6724
		public float DPDFDEEMNHL()
		{
			float result = 890f;
			if (this.NKNCNHGDMLF != null)
			{
				result = this.NKNCNHGDMLF.LODGJCMEGAI.LOIBCMBMLEC();
			}
			return result;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x001D855C File Offset: 0x001D675C
		public float HFAEKBAHCDJ()
		{
			float num = 497f + (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.EDICLBDIPGG) / 738f;
			if (this.LJCLFFINEHJ != null)
			{
				num += this.LJCLFFINEHJ.LODGJCMEGAI.OAAKPMLGJJH() * 9f;
			}
			return 589f * (1341f + num / 516f);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x001D783E File Offset: 0x001D5A3E
		public void LCKEJCDPBIO(ObscuredFloat DCCPCBLODIG)
		{
			this.<JOIKHDFHNIE>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x001D7F8D File Offset: 0x001D618D
		public ObscuredFloat ALHIIIPEGKD()
		{
			return this.<IABBIGOBIGM>k__BackingField;
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x001D85BF File Offset: 0x001D67BF
		public float IFELKILNKFP()
		{
			if (this.NKNCNHGDMLF != null)
			{
				this.JHBBGGAOHAD = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JHBBGGAOHAD), 392f, this.KKLEBEEGGDG()));
			}
			return ObscuredFloat.EJGOOFALNFF(this.JHBBGGAOHAD);
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x001D85FC File Offset: 0x001D67FC
		public float FBLACLHFLGE()
		{
			if (this.NKNCNHGDMLF == null)
			{
				return 1319f;
			}
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH == null)
			{
				return 849f;
			}
			return this.NKNCNHGDMLF.LODGJCMEGAI.FIAMGODLKFA() + this.NKNCNHGDMLF.LODGJCMEGAI.GHEGIJFKEON() * (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.EDICLBDIPGG) / 571f;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x001D8666 File Offset: 0x001D6866
		// (set) Token: 0x0600416B RID: 16747 RVA: 0x001D8D75 File Offset: 0x001D6F75
		public ObscuredFloat OLCJIJGPOHN { get; set; }

		// Token: 0x0600415A RID: 16730 RVA: 0x001D783E File Offset: 0x001D5A3E
		public void EPIPCOHGJGA(ObscuredFloat DCCPCBLODIG)
		{
			this.<JOIKHDFHNIE>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x001D86C6 File Offset: 0x001D68C6
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x001D8692 File Offset: 0x001D6892
		public float IFNNBJDJBNA
		{
			get
			{
				if (this.NKNCNHGDMLF != null)
				{
					this.JHBBGGAOHAD = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JHBBGGAOHAD), 30f, this.KFEPCNBDMIH));
				}
				return ObscuredFloat.GOOIABGKMHK(this.JHBBGGAOHAD);
			}
			set
			{
				this.JHBBGGAOHAD = ObscuredFloat.GOOIABGKMHK(value);
				this.JHBBGGAOHAD = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JHBBGGAOHAD), 30f, this.KFEPCNBDMIH));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x001D8704 File Offset: 0x001D6904
		public float MHHJEMDJOIK
		{
			get
			{
				float num = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 5f;
				if (this.LJCLFFINEHJ != null)
				{
					num += this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL * 0.2f;
				}
				return 8f * (1f + num / 100f);
			}
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x001D8764 File Offset: 0x001D6964
		public void IPDAAMECLMC()
		{
			this.IKKPFPJLPOL = false;
			switch (this.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				if (this.CBLCFLENIJL[1] == null)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				if (this.PFNCHEEEBKD.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = true;
				return;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				if (this.PFNCHEEEBKD.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = false;
				return;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				bool flag = true;
				if (this.CBLCFLENIJL[1] != null)
				{
					flag = false;
				}
				if (this.CBLCFLENIJL[1] != null)
				{
					flag = true;
				}
				if (this.CBLCFLENIJL[7] != null)
				{
					flag = true;
				}
				if (!flag)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = true;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x001D88E4 File Offset: 0x001D6AE4
		// (set) Token: 0x0600416F RID: 16751 RVA: 0x001D8E56 File Offset: 0x001D7056
		public float CCLOHHCJJAM
		{
			get
			{
				return Mathf.Clamp(this.NJBMIOABONL, 0f, 1f);
			}
			set
			{
				this.AKPEBMLBHJA = Mathf.Clamp(value, 0f, 1f);
			}
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x001D88FC File Offset: 0x001D6AFC
		public float BNKDDPAAPMH()
		{
			float result = 461f;
			if (this.NKNCNHGDMLF != null)
			{
				result = this.NKNCNHGDMLF.LODGJCMEGAI.LOIBCMBMLEC();
			}
			return result;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x001D892C File Offset: 0x001D6B2C
		public float EFIGLGEEMHG()
		{
			float num = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.EDICLBDIPGG) / 578f;
			if (this.LJCLFFINEHJ != null)
			{
				num += this.LJCLFFINEHJ.LODGJCMEGAI.DOFNAOOCDDB() * 398f;
			}
			return 916f * (594f + num / 941f);
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x001D8AC8 File Offset: 0x001D6CC8
		public float GGONBDIICLP()
		{
			float num = (float)ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.EDICLBDIPGG) / 770f;
			if (this.LJCLFFINEHJ != null)
			{
				num += this.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL;
			}
			return Mathf.Clamp(1774f - num, 895f, 1345f);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x001D8B24 File Offset: 0x001D6D24
		public float LPFDCFAIAEM()
		{
			float num = 1354f;
			switch (this.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (this.CBLCFLENIJL[1] != null)
				{
					num += this.CBLCFLENIJL[0].NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[1] != null)
				{
					num += this.AMLEOGHNNPG[1].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[1] != null)
				{
					num += this.AMLEOGHNNPG[1].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
				for (int i = 0; i < 4; i += 0)
				{
					if (this.CBLCFLENIJL[i] != null)
					{
						num += this.CBLCFLENIJL[i].NKHBAJKMAGD;
						if (this.AMLEOGHNNPG[i] != null)
						{
							num += this.AMLEOGHNNPG[i].NKHBAJKMAGD;
						}
					}
				}
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
					if (this.CKBGHMMOAEM != null)
					{
						num += this.PFNCHEEEBKD.LODGJCMEGAI.NAHLEJDLCNF();
					}
				}
				break;
			}
			return num;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x001D8C3D File Offset: 0x001D6E3D
		public void HFENEGIBAIG(float DCCPCBLODIG)
		{
			this.JLHNJMPEDAO = DCCPCBLODIG;
			this.JLHNJMPEDAO = Mathf.Clamp(this.JLHNJMPEDAO, 217f, 1650f);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x001D8C64 File Offset: 0x001D6E64
		public float JAHNFKLFANO()
		{
			float num = 0f;
			switch (this.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (this.CBLCFLENIJL[0] != null)
				{
					num += this.CBLCFLENIJL[0].NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[0] != null)
				{
					num += this.AMLEOGHNNPG[0].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[0] != null)
				{
					num += this.AMLEOGHNNPG[0].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
				for (int i = 0; i < 3; i++)
				{
					if (this.CBLCFLENIJL[i] != null)
					{
						num += this.CBLCFLENIJL[i].NKHBAJKMAGD;
						if (this.AMLEOGHNNPG[i] != null)
						{
							num += this.AMLEOGHNNPG[i].NKHBAJKMAGD;
						}
					}
				}
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
					if (this.CKBGHMMOAEM != null)
					{
						num += this.PFNCHEEEBKD.LODGJCMEGAI.JLLJFKOGLHJ;
					}
				}
				break;
			}
			return num;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x001D8D75 File Offset: 0x001D6F75
		public void ALCDLEHGMLJ(ObscuredFloat DCCPCBLODIG)
		{
			this.<MPJGHALDNHF>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x001D8D80 File Offset: 0x001D6F80
		public float PFDMMPFBCJA()
		{
			if (this.GLNFJCIJHDL == 29)
			{
				return 1826f;
			}
			if (this.CMKFMNBBPNE() == 0)
			{
				return 1295f;
			}
			float num = ObscuredFloat.EJGOOFALNFF(this.OGCIFKNBPMA) * 1889f;
			float num2 = 856f;
			if (this.LJCLFFINEHJ != null)
			{
				num2 = num * this.LJCLFFINEHJ.LODGJCMEGAI.KGKNPAAMDJK / 1015f * 773f;
			}
			return Mathf.Ceil(num2 / 1309f) * 840f / 1435f;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x001D8E04 File Offset: 0x001D7004
		public float AEFAHEMNOCH
		{
			get
			{
				int num = this.GLNFJCIJHDL;
				if (num > 20)
				{
					return 1E+11f;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return 10f;
				}
				return (float)num * 5f * this.LJCLFFINEHJ.LODGJCMEGAI.KGKNPAAMDJK / 100f * 1000f;
			}
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x001D8E70 File Offset: 0x001D7070
		public float ILOBPLGPOCO()
		{
			float num = 494f;
			switch (this.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (this.CBLCFLENIJL[1] != null)
				{
					num += this.CBLCFLENIJL[1].NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[1] != null)
				{
					num += this.AMLEOGHNNPG[1].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
				}
				if (this.AMLEOGHNNPG[1] != null)
				{
					num += this.AMLEOGHNNPG[1].NKHBAJKMAGD;
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
				for (int i = 1; i < 2; i += 0)
				{
					if (this.CBLCFLENIJL[i] != null)
					{
						num += this.CBLCFLENIJL[i].NKHBAJKMAGD;
						if (this.AMLEOGHNNPG[i] != null)
						{
							num += this.AMLEOGHNNPG[i].NKHBAJKMAGD;
						}
					}
				}
				if (this.PFNCHEEEBKD != null)
				{
					num += this.PFNCHEEEBKD.NKHBAJKMAGD;
					if (this.CKBGHMMOAEM != null)
					{
						num += this.PFNCHEEEBKD.LODGJCMEGAI.CLAEAFMCDMP();
					}
				}
				break;
			}
			return num;
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x001D8F90 File Offset: 0x001D7190
		public void AGHLFMJIMHB()
		{
			this.IKKPFPJLPOL = false;
			switch (this.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				if (this.CBLCFLENIJL[0] == null)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				if (this.PFNCHEEEBKD.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = true;
				return;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				if (this.PFNCHEEEBKD.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = true;
				return;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				if (this.NKNCNHGDMLF == null)
				{
					return;
				}
				if (this.LJCLFFINEHJ == null)
				{
					return;
				}
				if (this.IIOHPBENEFI == null)
				{
					return;
				}
				if (this.PFNCHEEEBKD == null)
				{
					return;
				}
				bool flag = false;
				if (this.CBLCFLENIJL[0] != null)
				{
					flag = true;
				}
				if (this.CBLCFLENIJL[1] != null)
				{
					flag = true;
				}
				if (this.CBLCFLENIJL[2] != null)
				{
					flag = true;
				}
				if (!flag)
				{
					return;
				}
				if (this.NKNCNHGDMLF.MJHGLLIJMIM)
				{
					return;
				}
				if (this.LJCLFFINEHJ.MJHGLLIJMIM)
				{
					return;
				}
				if (this.IIOHPBENEFI.MJHGLLIJMIM)
				{
					return;
				}
				this.IKKPFPJLPOL = true;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x001D9110 File Offset: 0x001D7310
		public bool IMONCAGNJPD()
		{
			return this.GLNFJCIJHDL < -95;
		}

		// Token: 0x040009AE RID: 2478
		public bool PBFACOEKPMN;

		// Token: 0x040009AF RID: 2479
		public bool GKAHEMBMCNC;

		// Token: 0x040009B0 RID: 2480
		public long LGELJLOCAOP;

		// Token: 0x040009B1 RID: 2481
		public long CGEFCAPMHDI;

		// Token: 0x040009B2 RID: 2482
		public BOIKJDICEMF.JGHABIPEEEO DFBHMIIPLCA;

		// Token: 0x040009B3 RID: 2483
		public int AANHBNICFDL;

		// Token: 0x040009B4 RID: 2484
		public List<int> OBLEJBEHPHO = new List<int>();

		// Token: 0x040009B5 RID: 2485
		public bool CDNABIHPLHM;

		// Token: 0x040009B6 RID: 2486
		public ObscuredInt NENOBDLCFHO;

		// Token: 0x040009B7 RID: 2487
		public ObscuredFloat NKHBAJKMAGD;

		// Token: 0x040009B8 RID: 2488
		public ObscuredFloat NBLJCEHNKAK;

		// Token: 0x040009B9 RID: 2489
		public ObscuredFloat FLHJLFHELPE;

		// Token: 0x040009BA RID: 2490
		public string CFOFDKKFJMJ = "";

		// Token: 0x040009BB RID: 2491
		public ObscuredFloat JDIBHEGKALB;

		// Token: 0x040009BC RID: 2492
		public ObscuredFloat EFLIAAIOPPI;

		// Token: 0x040009BD RID: 2493
		public ObscuredFloat PGEDLDMLBBE;

		// Token: 0x040009BE RID: 2494
		public ObscuredFloat HFPNHGGIKHP;

		// Token: 0x040009BF RID: 2495
		public ObscuredFloat PLIPAKGHPBE;

		// Token: 0x040009C0 RID: 2496
		private ObscuredFloat JHBBGGAOHAD = ObscuredFloat.GOOIABGKMHK(100f);

		// Token: 0x040009C1 RID: 2497
		public ObscuredFloat JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(-1f);

		// Token: 0x040009C2 RID: 2498
		private float JLHNJMPEDAO = 35f;

		// Token: 0x040009C3 RID: 2499
		public bool NHNHBLLLGDP;

		// Token: 0x040009C4 RID: 2500
		public long HPMPDNLHCKM;

		// Token: 0x040009C5 RID: 2501
		public EKBAPCMPANI BCKECOENDLB;

		// Token: 0x040009C6 RID: 2502
		public ObscuredFloat FOAAFGBHDAH;

		// Token: 0x040009C7 RID: 2503
		public float JJEFFBGECGL;

		// Token: 0x040009C8 RID: 2504
		public float IGDMILBFAPF;

		// Token: 0x040009C9 RID: 2505
		private ObscuredFloat OGCIFKNBPMA = ObscuredFloat.GOOIABGKMHK(-1f);

		// Token: 0x040009CA RID: 2506
		public bool BBANBEEJAPD;

		// Token: 0x040009CB RID: 2507
		public ObscuredFloat PEFCCLINAPN = ObscuredFloat.GOOIABGKMHK(3.6f);

		// Token: 0x040009CC RID: 2508
		public ObscuredFloat BDBIFBGKKGH = ObscuredFloat.GOOIABGKMHK(4f);

		// Token: 0x040009CD RID: 2509
		public ObscuredFloat DKIMCNEFMJE = ObscuredFloat.GOOIABGKMHK(120f);

		// Token: 0x040009CE RID: 2510
		public ObscuredFloat JLOOCAJHKLP = ObscuredFloat.GOOIABGKMHK(100f);

		// Token: 0x040009CF RID: 2511
		public ObscuredFloat FHBEDOJOAPB = ObscuredFloat.GOOIABGKMHK(120f);

		// Token: 0x040009D0 RID: 2512
		public ObscuredFloat GDFMEKHBELH = ObscuredFloat.GOOIABGKMHK(800f);

		// Token: 0x040009D1 RID: 2513
		public ObscuredFloat ECLLJEGCOGM = ObscuredFloat.GOOIABGKMHK(400f);

		// Token: 0x040009D2 RID: 2514
		public bool IKKPFPJLPOL;

		// Token: 0x040009D3 RID: 2515
		public int PEBMMAFEFCB;

		// Token: 0x040009D4 RID: 2516
		public long EBFADOKNMHD;

		// Token: 0x040009D5 RID: 2517
		public EKBAPCMPANI NKNCNHGDMLF;

		// Token: 0x040009D6 RID: 2518
		public EKBAPCMPANI IIOHPBENEFI;

		// Token: 0x040009D7 RID: 2519
		public EKBAPCMPANI LJCLFFINEHJ;

		// Token: 0x040009D8 RID: 2520
		public EKBAPCMPANI PFNCHEEEBKD;

		// Token: 0x040009D9 RID: 2521
		public EKBAPCMPANI[] CBLCFLENIJL = new EKBAPCMPANI[3];

		// Token: 0x040009DA RID: 2522
		public EKBAPCMPANI[] AMLEOGHNNPG = new EKBAPCMPANI[3];

		// Token: 0x040009DB RID: 2523
		public EKBAPCMPANI CKBGHMMOAEM;

		// Token: 0x040009DC RID: 2524
		public OMDDGEDHHNH.BCDNKAGAFBM AHELGDAMAEE;

		// Token: 0x040009DD RID: 2525
		public OMDDGEDHHNH.BCDNKAGAFBM NBHHHBNLBPE;

		// Token: 0x040009DE RID: 2526
		public OMDDGEDHHNH.BCDNKAGAFBM PJPIDGGKADI;

		// Token: 0x040009DF RID: 2527
		public OMDDGEDHHNH.BCDNKAGAFBM CPEEOJICPCB;

		// Token: 0x040009E6 RID: 2534
		public ObscuredFloat KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(100f);

		// Token: 0x040009E7 RID: 2535
		public ObscuredFloat LEMPPBMEJHP = ObscuredFloat.GOOIABGKMHK(0f);

		// Token: 0x040009E8 RID: 2536
		public ObscuredFloat LJNDGALCAKL = ObscuredFloat.GOOIABGKMHK(0f);

		// Token: 0x040009E9 RID: 2537
		private ObscuredFloat LMILFGDPKJO = ObscuredFloat.GOOIABGKMHK(100f);

		// Token: 0x040009EA RID: 2538
		private float AKPEBMLBHJA;

		// Token: 0x040009EB RID: 2539
		private float NJBMIOABONL;

		// Token: 0x040009EC RID: 2540
		public ObscuredFloat NKEGFIJJKIG;

		// Token: 0x040009ED RID: 2541
		public ObscuredFloat ALKAGOMNNOK;

		// Token: 0x040009EE RID: 2542
		public ObscuredFloat DNPDBOODCHK;

		// Token: 0x040009EF RID: 2543
		public ObscuredFloat DJOHGAHBGLG;

		// Token: 0x040009F0 RID: 2544
		public ObscuredFloat BNKBCOAANNG;

		// Token: 0x040009F1 RID: 2545
		public ObscuredFloat PPMKELOFPAJ;

		// Token: 0x040009F2 RID: 2546
		public ObscuredFloat LODEKEHKOKP;

		// Token: 0x040009F3 RID: 2547
		public ObscuredFloat NOMLJIMHFIL;

		// Token: 0x040009F4 RID: 2548
		public ObscuredFloat MENEMPKEBDI;

		// Token: 0x040009F5 RID: 2549
		public ObscuredFloat DHHLCNCMCDN;

		// Token: 0x040009F6 RID: 2550
		public ObscuredFloat DMEINKBOACF;

		// Token: 0x040009F7 RID: 2551
		public ObscuredFloat JBLKFABJAMA;

		// Token: 0x040009F8 RID: 2552
		public ObscuredFloat DLFMEIIADFE;

		// Token: 0x040009F9 RID: 2553
		public ObscuredFloat CKJOFDPBFMC;

		// Token: 0x040009FA RID: 2554
		public ObscuredFloat OCBJPGOKFOI;

		// Token: 0x040009FB RID: 2555
		public ObscuredFloat NOHFLPHECOA;

		// Token: 0x040009FC RID: 2556
		public ObscuredFloat HDFFLMCFGOG;

		// Token: 0x040009FD RID: 2557
		public ObscuredFloat GAKPODHCHNB;

		// Token: 0x040009FE RID: 2558
		public ObscuredFloat AIHLOMHODIB;

		// Token: 0x040009FF RID: 2559
		public ObscuredFloat HAEABJICCCP;
	}
}
