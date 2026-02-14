using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000248 RID: 584
[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
	// Token: 0x060085DC RID: 34268 RVA: 0x003E8EDC File Offset: 0x003E70DC
	private void CLCJPEDHFJA()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1406f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1498f) + "Mouse Y";
		}
		if (this.isColored)
		{
			float num = this.POAFIPCBAJA();
			if (num < 393f)
			{
				this.DENEJDJJMKG(this.from0to50);
			}
			if (num >= 1129f && num < 1392f)
			{
				float t = (num - 412f) / 170f;
				this.BKOGPOJJJGI(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 287f)
			{
				float t = (num - 169f) / 562f;
				this.BOMMEIEAIMO(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085DD RID: 34269 RVA: 0x003E90B8 File Offset: 0x003E72B8
	private void OPDCJCFMIPE()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1362f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 376f) + "{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}";
		}
		if (this.isColored)
		{
			float num = this.JFAKAKEMFKJ();
			if (num < 1858f)
			{
				this.LBODAJKFJJM(this.from0to50);
			}
			if (num >= 616f && num < 1514f)
			{
				float t = (num - 1848f) / 1539f;
				this.BBHINANJHHL(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1307f)
			{
				float t = (num - 1416f) / 770f;
				this.LBODAJKFJJM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085DE RID: 34270 RVA: 0x003E9294 File Offset: 0x003E7494
	private void HAIMGCDKPDC()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1178f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 410f) + " has been disabled as it requires HDR.";
		}
		if (this.isColored)
		{
			float num = this.POAFIPCBAJA();
			if (num < 1306f)
			{
				this.PPFBKGJPOIM(this.from0to50);
			}
			if (num >= 929f && num < 668f)
			{
				float t = (num - 121f) / 1926f;
				this.KPFLGBDLCNE(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1807f)
			{
				float t = (num - 30f) / 325f;
				this.DJBBLLOOLDP(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085DF RID: 34271 RVA: 0x003E946D File Offset: 0x003E766D
	private void EBNINOBOAII()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085E0 RID: 34272 RVA: 0x003E94A8 File Offset: 0x003E76A8
	private void JBFJPNKLLKI()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1018f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1647f) + "";
		}
		if (this.isColored)
		{
			float num = this.FJILNEGCFIJ();
			if (num < 1074f)
			{
				this.PFNBLCGOIFN(this.from0to50);
			}
			if (num >= 1004f && num < 1902f)
			{
				float t = (num - 1339f) / 700f;
				this.DENEJDJJMKG(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1676f)
			{
				float t = (num - 1719f) / 1982f;
				this.MDHMPEOAOKN(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085E1 RID: 34273 RVA: 0x003E946D File Offset: 0x003E766D
	private void OGMACADJFIN()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085E2 RID: 34274 RVA: 0x003E9681 File Offset: 0x003E7881
	public float PBGHFEKDHPP()
	{
		return 78f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085E3 RID: 34275 RVA: 0x003E96A4 File Offset: 0x003E78A4
	private void BJOICAKCPLI()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1790f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1557f) + "IK unassigned in FABRIKChain.";
		}
		if (this.isColored)
		{
			float num = this.OMDFCFLNODF();
			if (num < 1183f)
			{
				this.MDHMPEOAOKN(this.from0to50);
			}
			if (num >= 1253f && num < 1144f)
			{
				float t = (num - 1048f) / 375f;
				this.BBHINANJHHL(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1916f)
			{
				float t = (num - 1902f) / 562f;
				this.HMCKOPLNHJG(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085E4 RID: 34276 RVA: 0x003E946D File Offset: 0x003E766D
	private void FOIJINIJEID()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x003E9880 File Offset: 0x003E7A80
	private void EKCKBDKEAKO()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 251f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 502f) + "IK Effector is referencing to a bone '";
		}
		if (this.isColored)
		{
			float num = this.HFJJCJEPFIP();
			if (num < 1854f)
			{
				this.GMAHAJIDBPD(this.from0to50);
			}
			if (num >= 1780f && num < 1162f)
			{
				float t = (num - 810f) / 1744f;
				this.LBODAJKFJJM(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1832f)
			{
				float t = (num - 585f) / 1615f;
				this.PPFBKGJPOIM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x003E946D File Offset: 0x003E766D
	private void HNAEALCDLFJ()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x003E9A59 File Offset: 0x003E7C59
	public float MIDIABEDKHH()
	{
		return 1496f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x003E9A7C File Offset: 0x003E7C7C
	private void GCCAPOHGAHA()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 340f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 90f) + "name";
		}
		if (this.isColored)
		{
			float num = this.ICNCLPJHMOM();
			if (num < 1726f)
			{
				this.HMHBKBPMNDA(this.from0to50);
			}
			if (num >= 738f && num < 567f)
			{
				float t = (num - 427f) / 1925f;
				this.OEAEHHNBJKM(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 723f)
			{
				float t = (num - 1946f) / 1963f;
				this.OLIJBFMEHID(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void AALDPJOEIKJ(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x003E946D File Offset: 0x003E766D
	private void APEDLIKHDFA()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x003E9C63 File Offset: 0x003E7E63
	public float OAKBBNPNNAH()
	{
		return 631f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085EC RID: 34284 RVA: 0x003E9C86 File Offset: 0x003E7E86
	public float CDCHGFHHKAP()
	{
		return 993f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085ED RID: 34285 RVA: 0x003E9CAC File Offset: 0x003E7EAC
	private void JIKGIJEHGAP()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1722f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1798f) + "demoByteArray";
		}
		if (this.isColored)
		{
			float num = this.HICGJPPLOEE();
			if (num < 506f)
			{
				this.BBHINANJHHL(this.from0to50);
			}
			if (num >= 69f && num < 928f)
			{
				float t = (num - 1980f) / 497f;
				this.OLIJBFMEHID(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1250f)
			{
				float t = (num - 437f) / 1658f;
				this.DENEJDJJMKG(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085EE RID: 34286 RVA: 0x003E946D File Offset: 0x003E766D
	private void LHHFHDNBKKC()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085EF RID: 34287 RVA: 0x003E9E88 File Offset: 0x003E8088
	private void LFJHDHPJOPE()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 458f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 677f) + "SecondaryCausticsProjector";
		}
		if (this.isColored)
		{
			float num = this.OAMLPEDDMDI();
			if (num < 1141f)
			{
				this.BOICIEGIGLL(this.from0to50);
			}
			if (num >= 333f && num < 422f)
			{
				float t = (num - 719f) / 1897f;
				this.DHPLLBCFOAC(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1474f)
			{
				float t = (num - 1892f) / 1550f;
				this.DHPLLBCFOAC(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085F0 RID: 34288 RVA: 0x003EA061 File Offset: 0x003E8261
	public float PKCLPJJJEPB()
	{
		return 1984f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085F1 RID: 34289 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void GBGKIEKMINH(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085F2 RID: 34290 RVA: 0x003EA084 File Offset: 0x003E8284
	private void FOHLAIIMNFB()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 30f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 769f) + "WRINKLE_MAPS";
		}
		if (this.isColored)
		{
			float num = this.POAFIPCBAJA();
			if (num < 1598f)
			{
				this.OEAEHHNBJKM(this.from0to50);
			}
			if (num >= 1820f && num < 1104f)
			{
				float t = (num - 149f) / 1848f;
				this.GMAHAJIDBPD(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1271f)
			{
				float t = (num - 952f) / 1657f;
				this.LEPFBHKEPIK(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085F3 RID: 34291 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void BBHINANJHHL(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085F4 RID: 34292 RVA: 0x003EA25D File Offset: 0x003E845D
	public float MGFGBGKIAPE()
	{
		return 58f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085F5 RID: 34293 RVA: 0x003EA280 File Offset: 0x003E8480
	public float LKNCNBBGJLN()
	{
		return 142f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085F6 RID: 34294 RVA: 0x003EA2A3 File Offset: 0x003E84A3
	public float JFAKAKEMFKJ()
	{
		return 1433f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x060085F7 RID: 34295 RVA: 0x003EA2C8 File Offset: 0x003E84C8
	private void HFPPENPGGAI()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 665f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1224f) + "Cloth_05_00.wav";
		}
		if (this.isColored)
		{
			float num = this.OAKBBNPNNAH();
			if (num < 226f)
			{
				this.GBGKIEKMINH(this.from0to50);
			}
			if (num >= 1981f && num < 271f)
			{
				float t = (num - 1947f) / 952f;
				this.GBGKIEKMINH(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 472f)
			{
				float t = (num - 588f) / 1465f;
				this.seColor(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x060085F8 RID: 34296 RVA: 0x003E946D File Offset: 0x003E766D
	private void FMNCGCBFJKE()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085F9 RID: 34297 RVA: 0x003E946D File Offset: 0x003E766D
	private void OKCPKBGDFJH()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x060085FA RID: 34298 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void DHPLLBCFOAC(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085FB RID: 34299 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void DJBBLLOOLDP(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085FC RID: 34300 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void seColor(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085FD RID: 34301 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void BAGNJFGPAAE(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085FE RID: 34302 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void EJODIMPOKAI(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x060085FF RID: 34303 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void IELNGEAFOPI(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008600 RID: 34304 RVA: 0x003EA4A1 File Offset: 0x003E86A1
	public float IDBHBAAGIDN()
	{
		return 1981f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008601 RID: 34305 RVA: 0x003EA4C4 File Offset: 0x003E86C4
	private void GCLBNFCBMLL()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 945f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1059f) + "OfficeSittingLegCross";
		}
		if (this.isColored)
		{
			float num = this.GJFJFLCGBHI();
			if (num < 1616f)
			{
				this.LBODAJKFJJM(this.from0to50);
			}
			if (num >= 118f && num < 1422f)
			{
				float t = (num - 1784f) / 1613f;
				this.BAGNJFGPAAE(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1837f)
			{
				float t = (num - 1583f) / 292f;
				this.CODGCIJHGAB(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008602 RID: 34306 RVA: 0x003EA69D File Offset: 0x003E889D
	public float JMIKKGINBJG()
	{
		return 760f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008603 RID: 34307 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void BOICIEGIGLL(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void HMCKOPLNHJG(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008605 RID: 34309 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void CCGGGAFEIBP(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x003EA6C0 File Offset: 0x003E88C0
	private void EINLCOFCLLC()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1775f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1659f) + "RunBackward";
		}
		if (this.isColored)
		{
			float num = this.BCNIPMNBCLL();
			if (num < 1453f)
			{
				this.IELNGEAFOPI(this.from0to50);
			}
			if (num >= 587f && num < 1260f)
			{
				float t = (num - 185f) / 231f;
				this.IELNGEAFOPI(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1060f)
			{
				float t = (num - 749f) / 717f;
				this.OLIJBFMEHID(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x003EA89C File Offset: 0x003E8A9C
	private void HMEAENGBFKC()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1744f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 827f) + "position";
		}
		if (this.isColored)
		{
			float num = this.KNNEBEFDLCC();
			if (num < 1668f)
			{
				this.BBHINANJHHL(this.from0to50);
			}
			if (num >= 474f && num < 1260f)
			{
				float t = (num - 906f) / 1855f;
				this.DHPLLBCFOAC(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 637f)
			{
				float t = (num - 1863f) / 408f;
				this.LBODAJKFJJM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x003E946D File Offset: 0x003E766D
	private void PMDCDECMOOE()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008609 RID: 34313 RVA: 0x003EAA75 File Offset: 0x003E8C75
	public float ICNCLPJHMOM()
	{
		return 970f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600860A RID: 34314 RVA: 0x003EAA98 File Offset: 0x003E8C98
	private void KJJBBLDJHPD()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 980f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1765f) + "TOD_MoonDirection";
		}
		if (this.isColored)
		{
			float num = this.HICGJPPLOEE();
			if (num < 702f)
			{
				this.HMCKOPLNHJG(this.from0to50);
			}
			if (num >= 1226f && num < 1662f)
			{
				float t = (num - 1046f) / 1130f;
				this.EJODIMPOKAI(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1393f)
			{
				float t = (num - 1326f) / 983f;
				this.KPFLGBDLCNE(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600860B RID: 34315 RVA: 0x003EAC71 File Offset: 0x003E8E71
	public float MPFHFMDHOHK()
	{
		return 1841f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600860C RID: 34316 RVA: 0x003EAC94 File Offset: 0x003E8E94
	private void KLFPOILLKDF()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1967f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1969f) + "ObscuredInt:";
		}
		if (this.isColored)
		{
			float num = this.NLLBEMOCADD();
			if (num < 675f)
			{
				this.IELNGEAFOPI(this.from0to50);
			}
			if (num >= 1899f && num < 1548f)
			{
				float t = (num - 596f) / 1443f;
				this.HMCKOPLNHJG(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1750f)
			{
				float t = (num - 1657f) / 1181f;
				this.AALDPJOEIKJ(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600860D RID: 34317 RVA: 0x003EAE6D File Offset: 0x003E906D
	public float OMDFCFLNODF()
	{
		return 997f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600860E RID: 34318 RVA: 0x003EAE90 File Offset: 0x003E9090
	public float KNNEBEFDLCC()
	{
		return 1869f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600860F RID: 34319 RVA: 0x003EAEB4 File Offset: 0x003E90B4
	private void ACLNFGPOHBF()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1745f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1863f) + "gi_um_7";
		}
		if (this.isColored)
		{
			float num = this.ALAOENJAOLB();
			if (num < 1966f)
			{
				this.PFNBLCGOIFN(this.from0to50);
			}
			if (num >= 1311f && num < 1073f)
			{
				float t = (num - 1860f) / 1612f;
				this.BAGNJFGPAAE(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 613f)
			{
				float t = (num - 902f) / 1877f;
				this.BKOGPOJJJGI(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008610 RID: 34320 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void OLIJBFMEHID(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06008611 RID: 34321 RVA: 0x003EB08D File Offset: 0x003E928D
	public float IOLDIEPGOGF
	{
		get
		{
			return 100f * (this.position - this.min) / (this.max - this.min);
		}
	}

	// Token: 0x06008612 RID: 34322 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void DENEJDJJMKG(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008613 RID: 34323 RVA: 0x003EB0B0 File Offset: 0x003E92B0
	private void MLLJFAHJGOJ()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 189f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1011f) + "";
		}
		if (this.isColored)
		{
			float num = this.HFJJCJEPFIP();
			if (num < 702f)
			{
				this.DJBBLLOOLDP(this.from0to50);
			}
			if (num >= 1311f && num < 1066f)
			{
				float t = (num - 1187f) / 864f;
				this.EJODIMPOKAI(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 413f)
			{
				float t = (num - 6f) / 599f;
				this.MMGDLJONJNH(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008614 RID: 34324 RVA: 0x003EB28C File Offset: 0x003E948C
	private void CIBBPIIDHJH()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 453f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 258f) + "<b>ObscuredVector3:</b> ";
		}
		if (this.isColored)
		{
			float num = this.MJKFHABPHNN();
			if (num < 245f)
			{
				this.MMGDLJONJNH(this.from0to50);
			}
			if (num >= 1219f && num < 708f)
			{
				float t = (num - 190f) / 1880f;
				this.DBCIIDFNLIB(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 811f)
			{
				float t = (num - 315f) / 607f;
				this.BOMMEIEAIMO(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008616 RID: 34326 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void FBMMPGBNCFM(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008617 RID: 34327 RVA: 0x003EB483 File Offset: 0x003E9683
	public float DOKHADDNJGL()
	{
		return 380f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008618 RID: 34328 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void DBCIIDFNLIB(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008619 RID: 34329 RVA: 0x003E946D File Offset: 0x003E766D
	private void MNIOJGMLIMC()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600861A RID: 34330 RVA: 0x003EB4A8 File Offset: 0x003E96A8
	private void EDANNBFJHIK()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 658f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1091f) + "FactoryTempTexture";
		}
		if (this.isColored)
		{
			float num = this.HABKDOOOMFL();
			if (num < 1414f)
			{
				this.BKOGPOJJJGI(this.from0to50);
			}
			if (num >= 767f && num < 524f)
			{
				float t = (num - 128f) / 1098f;
				this.OEAEHHNBJKM(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 134f)
			{
				float t = (num - 830f) / 1914f;
				this.CODGCIJHGAB(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600861B RID: 34331 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void BKOGPOJJJGI(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600861C RID: 34332 RVA: 0x003E946D File Offset: 0x003E766D
	private void OBGHAEMCKCP()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x003EB681 File Offset: 0x003E9881
	public float GJFJFLCGBHI()
	{
		return 514f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x003E946D File Offset: 0x003E766D
	private void LBABMJJNIHA()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600861F RID: 34335 RVA: 0x003EB6A4 File Offset: 0x003E98A4
	public float FJILNEGCFIJ()
	{
		return 1872f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x003E946D File Offset: 0x003E766D
	private void IOIJGMFNBMC()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008621 RID: 34337 RVA: 0x003EB6C7 File Offset: 0x003E98C7
	public float OAMLPEDDMDI()
	{
		return 1655f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008622 RID: 34338 RVA: 0x003EB6EA File Offset: 0x003E98EA
	public float DMLCBOGKBFA()
	{
		return 482f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008623 RID: 34339 RVA: 0x003EB710 File Offset: 0x003E9910
	private void OHKHOAKCENL()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1167f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 331f) + "u_UniqueShadowBlockerDistanceScale";
		}
		if (this.isColored)
		{
			float num = this.HICGJPPLOEE();
			if (num < 136f)
			{
				this.CODGCIJHGAB(this.from0to50);
			}
			if (num >= 122f && num < 1751f)
			{
				float t = (num - 1721f) / 1391f;
				this.DHPLLBCFOAC(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1705f)
			{
				float t = (num - 1349f) / 788f;
				this.AALDPJOEIKJ(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x003E946D File Offset: 0x003E766D
	private void HJGFBNMJOOM()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x003E946D File Offset: 0x003E766D
	private void DPNNENHAGOE()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x003EB8EC File Offset: 0x003E9AEC
	private void GPCKACGEILI()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 513f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1874f) + "ClimbIdle";
		}
		if (this.isColored)
		{
			float num = this.HFJJCJEPFIP();
			if (num < 419f)
			{
				this.LEPFBHKEPIK(this.from0to50);
			}
			if (num >= 569f && num < 1507f)
			{
				float t = (num - 776f) / 1525f;
				this.PFNBLCGOIFN(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 723f)
			{
				float t = (num - 1070f) / 805f;
				this.KPFLGBDLCNE(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008627 RID: 34343 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void GMAHAJIDBPD(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x003EBAC8 File Offset: 0x003E9CC8
	private void LBBPCGCMMKF()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 315f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1969f) + "error.wav";
		}
		if (this.isColored)
		{
			float num = this.OEKODBIAGKC();
			if (num < 1763f)
			{
				this.PPFBKGJPOIM(this.from0to50);
			}
			if (num >= 1535f && num < 651f)
			{
				float t = (num - 1593f) / 622f;
				this.MMGDLJONJNH(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1272f)
			{
				float t = (num - 1133f) / 1685f;
				this.LBODAJKFJJM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x003EBCA1 File Offset: 0x003E9EA1
	public float IJHBJNMPHFG()
	{
		return 1397f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x003EBCC4 File Offset: 0x003E9EC4
	private void NFPFDOEENLA()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 920f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 557f) + "cancel";
		}
		if (this.isColored)
		{
			float num = this.MOBFFMIAKKK();
			if (num < 480f)
			{
				this.DJBBLLOOLDP(this.from0to50);
			}
			if (num >= 1390f && num < 16f)
			{
				float t = (num - 1322f) / 1054f;
				this.BOMMEIEAIMO(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 442f)
			{
				float t = (num - 1772f) / 651f;
				this.MDHMPEOAOKN(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600862B RID: 34347 RVA: 0x003E946D File Offset: 0x003E766D
	private void JLBFJMJALOA()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void MDHMPEOAOKN(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x003EBE9D File Offset: 0x003EA09D
	public float OEKODBIAGKC()
	{
		return 1121f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void LBODAJKFJJM(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600862F RID: 34351 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void CODGCIJHGAB(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x003E946D File Offset: 0x003E766D
	private void HCMHMFHMPHN()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008631 RID: 34353 RVA: 0x003E946D File Offset: 0x003E766D
	private void CHHMFDFHFAA()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x003E946D File Offset: 0x003E766D
	private void Awake()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008633 RID: 34355 RVA: 0x003EBEC0 File Offset: 0x003EA0C0
	private void Update()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 100f) + " %";
		}
		if (this.isColored)
		{
			float percent = this.IOLDIEPGOGF;
			if (percent < 50f)
			{
				this.seColor(this.from0to50);
			}
			if (percent >= 50f && percent < 75f)
			{
				float t = (percent - 50f) / 25f;
				this.seColor(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (percent > 75f)
			{
				float t = (percent - 75f) / 25f;
				this.seColor(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void PFNBLCGOIFN(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x003EC09C File Offset: 0x003EA29C
	private void AMDMCKIFBPA()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 529f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 707f) + "ShootRaycastModule";
		}
		if (this.isColored)
		{
			float num = this.ELMAMDIFOIK();
			if (num < 1994f)
			{
				this.OEAEHHNBJKM(this.from0to50);
			}
			if (num >= 738f && num < 1265f)
			{
				float t = (num - 1570f) / 931f;
				this.BBHINANJHHL(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1012f)
			{
				float t = (num - 765f) / 1558f;
				this.GMAHAJIDBPD(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x003E946D File Offset: 0x003E766D
	private void NLMBBNDHPLJ()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008637 RID: 34359 RVA: 0x003E946D File Offset: 0x003E766D
	private void BBEIKJGNAAA()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x003E946D File Offset: 0x003E766D
	private void PFKOLCOAPCN()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void BOMMEIEAIMO(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x003EC278 File Offset: 0x003EA478
	private void IDMCOLDDNCF()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 940f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 928f) + "______________________________";
		}
		if (this.isColored)
		{
			float num = this.IDBHBAAGIDN();
			if (num < 825f)
			{
				this.HMHBKBPMNDA(this.from0to50);
			}
			if (num >= 1455f && num < 390f)
			{
				float t = (num - 801f) / 1588f;
				this.BAGNJFGPAAE(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1128f)
			{
				float t = (num - 26f) / 1935f;
				this.BKOGPOJJJGI(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x003E946D File Offset: 0x003E766D
	private void LPDIHACCGKK()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x003EC451 File Offset: 0x003EA651
	public float MJKFHABPHNN()
	{
		return 1040f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600863D RID: 34365 RVA: 0x003EC474 File Offset: 0x003EA674
	public float OPLCBPPFMLL()
	{
		return 603f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600863E RID: 34366 RVA: 0x003EC497 File Offset: 0x003EA697
	public float OCNCFALFGHD()
	{
		return 399f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600863F RID: 34367 RVA: 0x003EC4BA File Offset: 0x003EA6BA
	public float ELMAMDIFOIK()
	{
		return 968f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008640 RID: 34368 RVA: 0x003E946D File Offset: 0x003E766D
	private void NPHKFNPCANH()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008641 RID: 34369 RVA: 0x003EC4DD File Offset: 0x003EA6DD
	public float BCNIPMNBCLL()
	{
		return 125f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008642 RID: 34370 RVA: 0x003EC500 File Offset: 0x003EA700
	private void PFNOEACNHON()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1595f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1510f) + "release";
		}
		if (this.isColored)
		{
			float num = this.DMLCBOGKBFA();
			if (num < 1153f)
			{
				this.MDHMPEOAOKN(this.from0to50);
			}
			if (num >= 1220f && num < 363f)
			{
				float t = (num - 1138f) / 1515f;
				this.DENEJDJJMKG(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 283f)
			{
				float t = (num - 824f) / 307f;
				this.MDHMPEOAOKN(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008643 RID: 34371 RVA: 0x003EC6D9 File Offset: 0x003EA8D9
	public float HABKDOOOMFL()
	{
		return 1886f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008644 RID: 34372 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void PPFBKGJPOIM(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008645 RID: 34373 RVA: 0x003E946D File Offset: 0x003E766D
	private void IIELJNDNLMO()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008646 RID: 34374 RVA: 0x003EC6FC File Offset: 0x003EA8FC
	public float ELBAGBCIDAL()
	{
		return 132f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008647 RID: 34375 RVA: 0x003EC71F File Offset: 0x003EA91F
	public float ALAOENJAOLB()
	{
		return 1734f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008648 RID: 34376 RVA: 0x003EC742 File Offset: 0x003EA942
	public float MLIMEDMGLJH()
	{
		return 450f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008649 RID: 34377 RVA: 0x003E946D File Offset: 0x003E766D
	private void FEMHFPFDFFH()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600864A RID: 34378 RVA: 0x003E946D File Offset: 0x003E766D
	private void IJCOMACDCDJ()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600864B RID: 34379 RVA: 0x003E946D File Offset: 0x003E766D
	private void HIBOODJBCIE()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600864C RID: 34380 RVA: 0x003EC765 File Offset: 0x003EA965
	public float HFJJCJEPFIP()
	{
		return 1080f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600864D RID: 34381 RVA: 0x003EC788 File Offset: 0x003EA988
	public float HICGJPPLOEE()
	{
		return 651f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600864E RID: 34382 RVA: 0x003EC7AC File Offset: 0x003EA9AC
	private void DABJGOFIDJM()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 25f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1185f) + "WeaponFire";
		}
		if (this.isColored)
		{
			float num = this.ICNCLPJHMOM();
			if (num < 1847f)
			{
				this.HMHBKBPMNDA(this.from0to50);
			}
			if (num >= 1455f && num < 1958f)
			{
				float t = (num - 1426f) / 262f;
				this.OLIJBFMEHID(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1112f)
			{
				float t = (num - 1214f) / 1560f;
				this.HMCKOPLNHJG(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600864F RID: 34383 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void OEAEHHNBJKM(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008650 RID: 34384 RVA: 0x003E946D File Offset: 0x003E766D
	private void OGKKCIOKGJE()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008651 RID: 34385 RVA: 0x003EC985 File Offset: 0x003EAB85
	public float BHNCLAGIMPG()
	{
		return 65f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008652 RID: 34386 RVA: 0x003EC9A8 File Offset: 0x003EABA8
	public float DEFOMPGOIGD()
	{
		return 1133f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008653 RID: 34387 RVA: 0x003EC9CC File Offset: 0x003EABCC
	private void MEIOHFKFEME()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1491f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 726f) + "_ColorBuffer";
		}
		if (this.isColored)
		{
			float num = this.OPLCBPPFMLL();
			if (num < 692f)
			{
				this.AALDPJOEIKJ(this.from0to50);
			}
			if (num >= 114f && num < 1470f)
			{
				float t = (num - 280f) / 1913f;
				this.BOMMEIEAIMO(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 1218f)
			{
				float t = (num - 611f) / 647f;
				this.CCGGGAFEIBP(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008654 RID: 34388 RVA: 0x003E946D File Offset: 0x003E766D
	private void KOJNOPBGPAM()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008655 RID: 34389 RVA: 0x003ECBA8 File Offset: 0x003EADA8
	private void CPJJHOKJEGJ()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1932f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 921f) + "move";
		}
		if (this.isColored)
		{
			float num = this.JFAKAKEMFKJ();
			if (num < 436f)
			{
				this.seColor(this.from0to50);
			}
			if (num >= 735f && num < 1867f)
			{
				float t = (num - 1530f) / 301f;
				this.CODGCIJHGAB(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 951f)
			{
				float t = (num - 168f) / 1572f;
				this.HMCKOPLNHJG(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008656 RID: 34390 RVA: 0x003E946D File Offset: 0x003E766D
	private void HHOACKALPHC()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008657 RID: 34391 RVA: 0x003ECD84 File Offset: 0x003EAF84
	private void AJCHHNKFOHO()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 318f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1338f) + "IdleDodgeRight";
		}
		if (this.isColored)
		{
			float num = this.DEFOMPGOIGD();
			if (num < 1454f)
			{
				this.CCGGGAFEIBP(this.from0to50);
			}
			if (num >= 132f && num < 1089f)
			{
				float t = (num - 1795f) / 50f;
				this.DBCIIDFNLIB(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 626f)
			{
				float t = (num - 1025f) / 1448f;
				this.FBMMPGBNCFM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008658 RID: 34392 RVA: 0x003E946D File Offset: 0x003E766D
	private void FJGEPEENLEJ()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008659 RID: 34393 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void LEPFBHKEPIK(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600865A RID: 34394 RVA: 0x003E946D File Offset: 0x003E766D
	private void ONPEGHFNMLK()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x0600865B RID: 34395 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void CPHPBEIKCLM(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600865C RID: 34396 RVA: 0x003ECF5D File Offset: 0x003EB15D
	public float MOBFFMIAKKK()
	{
		return 1974f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x0600865D RID: 34397 RVA: 0x003ECF80 File Offset: 0x003EB180
	private void KMLNBHIIGKH()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1785f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Horisontal)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1544f) + "Keeper Strafe Left";
		}
		if (this.isColored)
		{
			float num = this.MIDIABEDKHH();
			if (num < 901f)
			{
				this.BKOGPOJJJGI(this.from0to50);
			}
			if (num >= 1573f && num < 849f)
			{
				float t = (num - 1144f) / 1405f;
				this.AALDPJOEIKJ(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 320f)
			{
				float t = (num - 1092f) / 265f;
				this.FBMMPGBNCFM(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x0600865E RID: 34398 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void KPFLGBDLCNE(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x0600865F RID: 34399 RVA: 0x003E946D File Offset: 0x003E766D
	private void CCPOIOJPKIF()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008660 RID: 34400 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void HMHBKBPMNDA(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008661 RID: 34401 RVA: 0x003ED159 File Offset: 0x003EB359
	public float POAFIPCBAJA()
	{
		return 1046f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008662 RID: 34402 RVA: 0x003E946D File Offset: 0x003E766D
	private void BHPGDKJHKKG()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x06008663 RID: 34403 RVA: 0x003ED17C File Offset: 0x003EB37C
	private void INKGAFANFIB()
	{
		if (this.progressPanel == null)
		{
			return;
		}
		this.position = Mathf.Clamp(this.position, this.min, this.max);
		if (this.min == this.max)
		{
			this.max = this.min + 1212f;
		}
		this.ACPMEOHBMIP = (this.position - this.min) / (this.max - this.min);
		Vector2 size = this.progressPanel.rect.size;
		ProgressBar.NIONNPPHLHI nionnpphlhi = this.barType;
		if (nionnpphlhi != ProgressBar.NIONNPPHLHI.Horisontal)
		{
			if (nionnpphlhi == ProgressBar.NIONNPPHLHI.Vertical)
			{
				this.progressPanel.sizeDelta = new Vector2(size.x, (this.mainRect.rect.size.y - this.SizeDelta) * this.ACPMEOHBMIP);
			}
		}
		else
		{
			this.progressPanel.sizeDelta = new Vector2((this.mainRect.rect.size.x - this.SizeDelta) * this.ACPMEOHBMIP, size.y);
		}
		if (this.textProc != null)
		{
			this.textProc.text = (int)(this.ACPMEOHBMIP * 1949f) + "wgt=";
		}
		if (this.isColored)
		{
			float num = this.ALAOENJAOLB();
			if (num < 480f)
			{
				this.BBHINANJHHL(this.from0to50);
			}
			if (num >= 345f && num < 60f)
			{
				float t = (num - 117f) / 1554f;
				this.CCGGGAFEIBP(Color.Lerp(this.from0to50, this.from50to75, t));
			}
			if (num > 645f)
			{
				float t = (num - 1242f) / 564f;
				this.MMGDLJONJNH(Color.Lerp(this.from50to75, this.from75to100, t));
			}
		}
	}

	// Token: 0x06008664 RID: 34404 RVA: 0x003E9C55 File Offset: 0x003E7E55
	public void MMGDLJONJNH(Color FAODPFDPCLH)
	{
		this.recImage.color = FAODPFDPCLH;
	}

	// Token: 0x06008665 RID: 34405 RVA: 0x003ED355 File Offset: 0x003EB555
	public float NLLBEMOCADD()
	{
		return 977f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008666 RID: 34406 RVA: 0x003ED378 File Offset: 0x003EB578
	public float EPFGMIGJPBM()
	{
		return 1248f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008667 RID: 34407 RVA: 0x003ED39B File Offset: 0x003EB59B
	public float OGALNLALINF()
	{
		return 857f * (this.position - this.min) / (this.max - this.min);
	}

	// Token: 0x06008668 RID: 34408 RVA: 0x003E946D File Offset: 0x003E766D
	private void LBKPJAJJLBH()
	{
		if (this.mainRect == null)
		{
			this.mainRect = base.GetComponent<RectTransform>();
		}
		if (this.recImage == null)
		{
			this.recImage = this.progressPanel.GetComponent<Image>();
		}
	}

	// Token: 0x040012C5 RID: 4805
	public ProgressBar.NIONNPPHLHI barType;

	// Token: 0x040012C6 RID: 4806
	public float min;

	// Token: 0x040012C7 RID: 4807
	public float max = 100f;

	// Token: 0x040012C8 RID: 4808
	public float position = 50f;

	// Token: 0x040012C9 RID: 4809
	public float SizeDelta;

	// Token: 0x040012CA RID: 4810
	public RectTransform progressPanel;

	// Token: 0x040012CB RID: 4811
	public RectTransform mainRect;

	// Token: 0x040012CC RID: 4812
	public Image recImage;

	// Token: 0x040012CD RID: 4813
	public Text textProc;

	// Token: 0x040012CE RID: 4814
	public Text textHeader;

	// Token: 0x040012CF RID: 4815
	private float ACPMEOHBMIP;

	// Token: 0x040012D0 RID: 4816
	public bool isColored;

	// Token: 0x040012D1 RID: 4817
	public Color from0to50;

	// Token: 0x040012D2 RID: 4818
	public Color from50to75;

	// Token: 0x040012D3 RID: 4819
	public Color from75to100;

	// Token: 0x02000249 RID: 585
	public enum NIONNPPHLHI
	{
		// Token: 0x040012D5 RID: 4821
		Horisontal,
		// Token: 0x040012D6 RID: 4822
		Vertical
	}
}
