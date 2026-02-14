using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000246 RID: 582
public class PanelResizer : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x0600853F RID: 34111 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LANAEAJLGJK(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008540 RID: 34112 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EAHBNDBPBPJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008541 RID: 34113 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KGGGLMIDPMJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008542 RID: 34114 RVA: 0x003E7670 File Offset: 0x003E5870
	public void HAIHFGPMACI(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008543 RID: 34115 RVA: 0x003E76FC File Offset: 0x003E58FC
	public void HMLHEBLIPLM(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008544 RID: 34116 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IOKODHBHKHE(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008545 RID: 34117 RVA: 0x00022FCC File Offset: 0x000211CC
	public void JPLEGHHKNHP(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008546 RID: 34118 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BOEJJANKFAD(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008547 RID: 34119 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CBBEDLAGIME(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008548 RID: 34120 RVA: 0x003E7788 File Offset: 0x003E5988
	public void IFBFDHADBJK(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008549 RID: 34121 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PGIHOCPHLLL(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600854A RID: 34122 RVA: 0x003E7814 File Offset: 0x003E5A14
	public void PPHJAEMMMEK(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x0600854B RID: 34123 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ADEAHLPEEDL(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600854C RID: 34124 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BBMAPKNJCFB(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600854D RID: 34125 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OIGAGJHGCOH(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600854E RID: 34126 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IAEAGDAGMOB(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600854F RID: 34127 RVA: 0x003E78A0 File Offset: 0x003E5AA0
	public void ACMFEPPMALI(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008550 RID: 34128 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PLIGGILFIAI(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008552 RID: 34130 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AFMEDDJMCPB(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008553 RID: 34131 RVA: 0x00022FCC File Offset: 0x000211CC
	public void JILGGBHBKBM(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008554 RID: 34132 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ODPAEBIBOFE(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008555 RID: 34133 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KMLICFPLBMI(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008556 RID: 34134 RVA: 0x003E792C File Offset: 0x003E5B2C
	public void OnDrag(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008557 RID: 34135 RVA: 0x003E79B8 File Offset: 0x003E5BB8
	public void GOEDKMLKFJB(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008558 RID: 34136 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BLAHJNLPLHA(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008559 RID: 34137 RVA: 0x003E7A44 File Offset: 0x003E5C44
	public void JCAJHFBELLD(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x0600855A RID: 34138 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OnBeginDrag(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600855B RID: 34139 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CKGAEOFFBHH(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600855C RID: 34140 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LMDAOCHHAKM(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600855D RID: 34141 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OnEndDrag(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600855E RID: 34142 RVA: 0x00022FCC File Offset: 0x000211CC
	public void DPCCAIPFACF(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600855F RID: 34143 RVA: 0x003E7AD0 File Offset: 0x003E5CD0
	public void PCLEGBOBNIG(PointerEventData CAKNKPPGGIK)
	{
		Vector2 vector = this.mainPanel.sizeDelta + new Vector2(CAKNKPPGGIK.delta.x, -CAKNKPPGGIK.delta.y);
		vector.x = Mathf.Clamp(vector.x, this.minimalSize.x, (float)Screen.width);
		vector.y = Mathf.Clamp(vector.y, this.minimalSize.y, (float)Screen.height);
		this.mainPanel.sizeDelta = vector;
	}

	// Token: 0x06008560 RID: 34144 RVA: 0x00022FCC File Offset: 0x000211CC
	public void NEAGBBFIBMC(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008561 RID: 34145 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EKJIOCFCNHM(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x040012BE RID: 4798
	public RectTransform mainPanel;

	// Token: 0x040012BF RID: 4799
	public Vector2 minimalSize;
}
