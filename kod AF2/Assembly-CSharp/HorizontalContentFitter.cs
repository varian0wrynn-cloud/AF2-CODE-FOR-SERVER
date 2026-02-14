using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000173 RID: 371
[AddComponentMenu("Layout/Horizontal Content Fitter", 250)]
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class HorizontalContentFitter : ContentSizeFitter
{
	// Token: 0x06005124 RID: 20772 RVA: 0x00259F24 File Offset: 0x00258124
	public virtual void FAGLMKAOOKA()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)4));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x00259F7C File Offset: 0x0025817C
	public virtual void ENINNBGAGEE()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)8));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005126 RID: 20774 RVA: 0x00259FD4 File Offset: 0x002581D4
	public virtual void ODMGLBKONAO()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005127 RID: 20775 RVA: 0x0025A02C File Offset: 0x0025822C
	public virtual void GLOIEJFBEEN()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)4));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005128 RID: 20776 RVA: 0x0025A084 File Offset: 0x00258284
	public virtual void JKDKIIIPMFI()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)8));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005129 RID: 20777 RVA: 0x0025A0DC File Offset: 0x002582DC
	public virtual void OBNBIHBEHKG()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)6));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512A RID: 20778 RVA: 0x0025A134 File Offset: 0x00258334
	public virtual void BPENGGMABLN()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)5));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512B RID: 20779 RVA: 0x0025A18C File Offset: 0x0025838C
	public virtual void DMLFDKFFJDM()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)7));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512C RID: 20780 RVA: 0x0025A1E4 File Offset: 0x002583E4
	public virtual void KDHLFBFMGFO()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512D RID: 20781 RVA: 0x0025A23C File Offset: 0x0025843C
	public virtual void PAJGAPHBLCG()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512E RID: 20782 RVA: 0x0025A294 File Offset: 0x00258494
	public virtual void AMAEFGOPIKD()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)5));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600512F RID: 20783 RVA: 0x0025A2EC File Offset: 0x002584EC
	public virtual void AHEBFDOIOGP()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.MinSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005130 RID: 20784 RVA: 0x0025A344 File Offset: 0x00258544
	public virtual void JFBJMHCMAPL()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)6));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005132 RID: 20786 RVA: 0x0025A3A4 File Offset: 0x002585A4
	public virtual void BMDODBLBGHB()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.MinSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005133 RID: 20787 RVA: 0x0025A3FC File Offset: 0x002585FC
	public virtual void MBIEHAHPALJ()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005134 RID: 20788 RVA: 0x0025A454 File Offset: 0x00258654
	public virtual void MOBEKDKEMLJ()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)3));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005135 RID: 20789 RVA: 0x0025A4AC File Offset: 0x002586AC
	public virtual void HONFMDKEKGD()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)3));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005136 RID: 20790 RVA: 0x0025A504 File Offset: 0x00258704
	public virtual void EJACPOLFLHL()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.Unconstrained);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005137 RID: 20791 RVA: 0x0025A55C File Offset: 0x0025875C
	public virtual void PCJOFNJDOFO()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)5));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005138 RID: 20792 RVA: 0x0025A5B4 File Offset: 0x002587B4
	public virtual void PEEKHOOKDEH()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ContentSizeFitter.FitMode.MinSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005139 RID: 20793 RVA: 0x0025A60C File Offset: 0x0025880C
	public virtual void IHDDLCGIBEK()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)8));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513A RID: 20794 RVA: 0x0025A664 File Offset: 0x00258864
	public virtual void IHJPMHMDDDF()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)7));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x0025A6BC File Offset: 0x002588BC
	public virtual void CKBPLHFJIHA()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ((ContentSizeFitter.FitMode)3));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x0025A714 File Offset: 0x00258914
	public virtual void LHPDLHNMIOE()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)3));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513D RID: 20797 RVA: 0x0025A76C File Offset: 0x0025896C
	public virtual void JEHJJDOCMGP()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)5));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513E RID: 20798 RVA: 0x0025A7C4 File Offset: 0x002589C4
	public virtual void GNAPBBGCCDF()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)7));
		base.SetLayoutHorizontal();
	}

	// Token: 0x0600513F RID: 20799 RVA: 0x0025A81C File Offset: 0x00258A1C
	public virtual void ODIKFBKICHP()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005140 RID: 20800 RVA: 0x0025A874 File Offset: 0x00258A74
	public virtual void CDKIBMMDIPI()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005141 RID: 20801 RVA: 0x0025A8CC File Offset: 0x00258ACC
	public virtual void MLNGPIGBPAD()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ((ContentSizeFitter.FitMode)4));
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005142 RID: 20802 RVA: 0x0025A924 File Offset: 0x00258B24
	public virtual void BCIIFBDPAEK()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 1) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.MinSize : ContentSizeFitter.FitMode.Unconstrained);
		base.SetLayoutHorizontal();
	}

	// Token: 0x06005143 RID: 20803 RVA: 0x0025A97C File Offset: 0x00258B7C
	public override void SetLayoutHorizontal()
	{
		if (this.FILNCMHPLBB == null)
		{
			this.FILNCMHPLBB = base.GetComponent<RectTransform>();
		}
		base.horizontalFit = ((LayoutUtility.GetPreferredSize(this.FILNCMHPLBB, 0) > this.FILNCMHPLBB.rect.width) ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize);
		base.SetLayoutHorizontal();
	}

	// Token: 0x04000C47 RID: 3143
	private RectTransform FILNCMHPLBB;
}
