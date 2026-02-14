using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200019D RID: 413
public class UIListBox : MonoBehaviour
{
	// Token: 0x06005C28 RID: 23592 RVA: 0x002B3C9C File Offset: 0x002B1E9C
	public void INMIIODEFGH(int CLBPBJGLHEE)
	{
		this.BBMFIMCIEIA(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.changeItemSound, 780f);
	}

	// Token: 0x06005C29 RID: 23593 RVA: 0x002B3CF4 File Offset: 0x002B1EF4
	public void NIOGJFEPNGK(int CLBPBJGLHEE)
	{
		this.CMIKKLABAPA(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.JGCCLLBCCJD()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.changeItemSound, 833f);
		}
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x002B3D4C File Offset: 0x002B1F4C
	public ItemBase CDNNKDEJOMI()
	{
		if (this.EPMCOEDONPC < 1)
		{
			return null;
		}
		if (this.itemList.Count < 1)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x002B3DAC File Offset: 0x002B1FAC
	public ItemBase PIGADJMBCHB()
	{
		if (this.EPMCOEDONPC < 1)
		{
			return null;
		}
		if (this.itemList.Count < 1)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x002B3E0C File Offset: 0x002B200C
	public void FCPGLAFGEPG(int CLBPBJGLHEE)
	{
		this.CMIKKLABAPA(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.changeItemSound, 692f);
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x002B3E64 File Offset: 0x002B2064
	public void deleteItem(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x002B3EC4 File Offset: 0x002B20C4
	public void JHOPMDEABOG(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 0 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.HNPPOAHNJNI()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.MENJCPOMFIC(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06005C91 RID: 23697 RVA: 0x002B470F File Offset: 0x002B290F
	// (set) Token: 0x06005C2F RID: 23599 RVA: 0x002B3F94 File Offset: 0x002B2194
	public int NMPLGANEKAM
	{
		get
		{
			return this.EPMCOEDONPC;
		}
		set
		{
			int epmcoedonpc = this.EPMCOEDONPC;
			this.EPMCOEDONPC = value;
			if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
			{
				if (this.EPMCOEDONPC >= 0 && this.EPMCOEDONPC < this.itemList.Count)
				{
					this.onChangeItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
				}
				else
				{
					this.onChangeItem(null, null);
				}
			}
			foreach (UIItem uiitem in this.itemList)
			{
				uiitem.OFGDMJJIOEB = (uiitem.itemIndex == this.EPMCOEDONPC);
			}
		}
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x002B4094 File Offset: 0x002B2294
	public void BEMLEDDBMNG(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, false);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.CLNGKPJDLDO));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.PAHMAHOIMOH));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.COLIFILJHIG();
			return;
		}
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x002B41B0 File Offset: 0x002B23B0
	public void JKLIPEKEDID(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 1; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.ALJCGCBNDHL(component.UI_data, component.rect);
			}
		}
		this.JDLKEDMDIHO();
	}

	// Token: 0x06005C33 RID: 23603 RVA: 0x002B420D File Offset: 0x002B240D
	public void GHDEKJNDBPH(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C34 RID: 23604 RVA: 0x002B4244 File Offset: 0x002B2444
	public void addItem(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, false);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.ALMDKFOJBAH));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.ENFEHCPPBJK));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.recalculateList();
			return;
		}
	}

	// Token: 0x06005C35 RID: 23605 RVA: 0x002B435E File Offset: 0x002B255E
	public void OnScrollChanged(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x002B4398 File Offset: 0x002B2598
	public void sortItemList()
	{
		for (int i = 0; i < this.itemList.Count; i++)
		{
			for (int j = i + 1; j < this.itemList.Count; j++)
			{
				UIItem uiitem = this.itemList[i];
				UIItem uiitem2 = this.itemList[j];
				if (uiitem.itemData != null && uiitem2.itemData != null && uiitem.itemData.NBCAEJHKLMG(uiitem2.itemData) > 0)
				{
					this.itemList[j] = uiitem;
					this.itemList[i] = uiitem2;
				}
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x002B4434 File Offset: 0x002B2634
	public void BLHOLGKMFBL(string MNEICNPJGMC)
	{
		this.OOEOIIDOMAE(new ItemBase(MNEICNPJGMC));
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x002B4444 File Offset: 0x002B2644
	public void NEPFNJFHEID(int CLBPBJGLHEE)
	{
		this.NKJDPEBMBIA(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 749f);
	}

	// Token: 0x06005C39 RID: 23609 RVA: 0x002B449C File Offset: 0x002B269C
	public void INDNIHJAONH(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.PAEEMNAFBJG();
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x002B44FC File Offset: 0x002B26FC
	public void OnClick(int CLBPBJGLHEE)
	{
		this.NMPLGANEKAM = CLBPBJGLHEE;
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 1f);
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x002B4554 File Offset: 0x002B2754
	public void OBMAFPODNJA(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, true);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.FKJJCGDLMBC));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.ANLEJMDKDOK));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.FHGACKMFDNL();
			return;
		}
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x002B4670 File Offset: 0x002B2870
	public void LCIJDGDCDFN()
	{
		foreach (UIItem uiitem in this.itemList)
		{
			UnityEngine.Object.Destroy(uiitem.gameObject);
		}
		this.itemList.Clear();
		this.ONAIFHNBDOM(-1);
	}

	// Token: 0x06005C3D RID: 23613 RVA: 0x002B46D8 File Offset: 0x002B28D8
	public void IKACEDPOAGJ(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CLHGHANANNL()
	{
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x002B470F File Offset: 0x002B290F
	public int MHJHEMGCMNI()
	{
		return this.EPMCOEDONPC;
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x002B470F File Offset: 0x002B290F
	public int NJOEGOKDNCC()
	{
		return this.EPMCOEDONPC;
	}

	// Token: 0x06005C41 RID: 23617 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ONIHHFLOJMN()
	{
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x002B4718 File Offset: 0x002B2918
	public ItemBase APDDFECONEH()
	{
		if (this.EPMCOEDONPC < 0)
		{
			return null;
		}
		if (this.itemList.Count < 0)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x002B4777 File Offset: 0x002B2977
	public void addItemStr(string MNEICNPJGMC)
	{
		this.addItem(new ItemBase(MNEICNPJGMC));
	}

	// Token: 0x06005C44 RID: 23620 RVA: 0x002B4788 File Offset: 0x002B2988
	public void MIEAPPJEBCJ(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.FHGACKMFDNL();
	}

	// Token: 0x06005C45 RID: 23621 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KEBDEJIAODF()
	{
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x002B47E8 File Offset: 0x002B29E8
	public void AEEJMKFPGJO(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.FOMFEBJINLG(component.UI_data, component.rect);
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x002B4848 File Offset: 0x002B2A48
	public void EACMONLENJE()
	{
		for (int i = 1; i < this.itemList.Count; i += 0)
		{
			for (int j = i + 0; j < this.itemList.Count; j++)
			{
				UIItem uiitem = this.itemList[i];
				UIItem uiitem2 = this.itemList[j];
				if (uiitem.itemData != null && uiitem2.itemData != null && uiitem.itemData.JBGONEKPPLB(uiitem2.itemData) > 1)
				{
					this.itemList[j] = uiitem;
					this.itemList[i] = uiitem2;
				}
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x002B48E4 File Offset: 0x002B2AE4
	public void KGCJCGJHEOF(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 1 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.HCEOMFDBBLH()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.PEBPGBFDLPC(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x002B49B4 File Offset: 0x002B2BB4
	public void GDPKAEAFLHA(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.NOKFGIAEGJH();
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x002B4A14 File Offset: 0x002B2C14
	public void EBGNPCIKCNA(int CLBPBJGLHEE)
	{
		this.ONAIFHNBDOM(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 356f);
		}
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x002B4A6C File Offset: 0x002B2C6C
	public void EBFCIOAGMLH(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.KOOKFCJGJPH(component.UI_data, component.rect);
			}
		}
		this.NOKFGIAEGJH();
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x002B4ACC File Offset: 0x002B2CCC
	public void MHFOBDKLCJP(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 1; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x002B4B2C File Offset: 0x002B2D2C
	public void FPAOEIHJBOB()
	{
		foreach (UIItem uiitem in this.itemList)
		{
			UnityEngine.Object.Destroy(uiitem.gameObject);
		}
		this.itemList.Clear();
		this.NKJDPEBMBIA(-1);
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNJHMJNFPLP()
	{
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JFGGBEGNAFP()
	{
	}

	// Token: 0x06005C50 RID: 23632 RVA: 0x002B4B94 File Offset: 0x002B2D94
	public ItemBase OLMOBKODKOO()
	{
		if (this.EPMCOEDONPC < 1)
		{
			return null;
		}
		if (this.itemList.Count < 1)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x002B4BF4 File Offset: 0x002B2DF4
	public void CLGPPEILNBD(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.ILEBKJJPCBH();
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HFPPENPGGAI()
	{
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x002B4C54 File Offset: 0x002B2E54
	public void OHELLPPGAPG(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 0 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.AMHINCKKBIN(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C55 RID: 23637 RVA: 0x002B4D24 File Offset: 0x002B2F24
	public void OnRClick(int CLBPBJGLHEE)
	{
		this.NMPLGANEKAM = CLBPBJGLHEE;
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 1f);
		}
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x002B4D7C File Offset: 0x002B2F7C
	public void OIIEJGMGAPJ(int CLBPBJGLHEE)
	{
		this.AOOBGEKFBKP(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.NJOEGOKDNCC()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.changeItemSound, 1378f);
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AFFAJKPPMHF()
	{
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x002B4DD4 File Offset: 0x002B2FD4
	public ItemBase PGOMNGAGCLL()
	{
		if (this.EPMCOEDONPC < 0)
		{
			return null;
		}
		if (this.itemList.Count < 0)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x002B4E34 File Offset: 0x002B3034
	public void NOKFGIAEGJH()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 1183f);
			return;
		}
		float num = 517f;
		for (int i = 1; i < this.itemList.Count; i += 0)
		{
			this.itemList[i].itemData.ELDBGAOKMPC(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(346f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x002B4F48 File Offset: 0x002B3148
	public void BBMFIMCIEIA(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 1 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.NJOEGOKDNCC()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.JAHJGBOEJJI(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C5B RID: 23643 RVA: 0x002B5018 File Offset: 0x002B3218
	public void KEJGEKABKHE(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 0; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.KOOKFCJGJPH(component.UI_data, component.rect);
			}
		}
		this.JDLKEDMDIHO();
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x002B5078 File Offset: 0x002B3278
	public void IPENPEOKJJF(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, false);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.EDHOADIIEML));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.PAHMAHOIMOH));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.ILEBKJJPCBH();
			return;
		}
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x002B5194 File Offset: 0x002B3394
	public void PLFMBONLCFN()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 574f);
			return;
		}
		float num = 672f;
		for (int i = 0; i < this.itemList.Count; i++)
		{
			this.itemList[i].itemData.FOMFEBJINLG(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(547f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C5E RID: 23646 RVA: 0x002B52A8 File Offset: 0x002B34A8
	public void CGMPLCLNGOD(int CLBPBJGLHEE)
	{
		this.OHELLPPGAPG(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.changeItemSound, 71f);
	}

	// Token: 0x06005C5F RID: 23647 RVA: 0x002B5300 File Offset: 0x002B3500
	public void PKEENFBMECJ(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 1; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.COLIFILJHIG();
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x002B5360 File Offset: 0x002B3560
	public void ICFHFAJJBHG(int CLBPBJGLHEE)
	{
		this.AOOBGEKFBKP(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.HNPPOAHNJNI()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 420f);
		}
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CDLDCKAHLHC()
	{
	}

	// Token: 0x06005C62 RID: 23650 RVA: 0x002B53B8 File Offset: 0x002B35B8
	public void HABDINNAKDP(string MNEICNPJGMC)
	{
		this.BEMLEDDBMNG(new ItemBase(MNEICNPJGMC));
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HDFCIACDDEK()
	{
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x002B53C8 File Offset: 0x002B35C8
	public void AGCIEGIGMBH(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.OMBICACBIFH(component.UI_data, component.rect);
			}
		}
		this.PLFMBONLCFN();
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x002B5425 File Offset: 0x002B3625
	public void PEBLBNEADGJ(string MNEICNPJGMC)
	{
		this.IPENPEOKJJF(new ItemBase(MNEICNPJGMC));
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x002B470F File Offset: 0x002B290F
	public int JGCCLLBCCJD()
	{
		return this.EPMCOEDONPC;
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x002B5434 File Offset: 0x002B3634
	public void DPGFMOEPFAP(int CLBPBJGLHEE)
	{
		this.BBMFIMCIEIA(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.JGCCLLBCCJD()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.changeItemSound, 200f);
		}
	}

	// Token: 0x06005C68 RID: 23656 RVA: 0x002B548C File Offset: 0x002B368C
	public void GEPAMIHMJMA(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C69 RID: 23657 RVA: 0x002B54C4 File Offset: 0x002B36C4
	public void NJPJINAODEK(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.NOKFGIAEGJH();
	}

	// Token: 0x06005C6A RID: 23658 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06005C6B RID: 23659 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGALMCHPPH()
	{
	}

	// Token: 0x06005C6C RID: 23660 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DOHJPDNKALP()
	{
	}

	// Token: 0x06005C6D RID: 23661 RVA: 0x002B46D8 File Offset: 0x002B28D8
	public void KKMDJIPIDIL(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x002B5524 File Offset: 0x002B3724
	public void KBBDPJLEMFM(int CLBPBJGLHEE)
	{
		this.NMPLGANEKAM = CLBPBJGLHEE;
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.JGCCLLBCCJD()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.changeItemSound, 461f);
		}
	}

	// Token: 0x06005C6F RID: 23663 RVA: 0x002B557C File Offset: 0x002B377C
	public void GEGDJHBOMHP(string MNEICNPJGMC)
	{
		this.CNNKFIDHPMK(new ItemBase(MNEICNPJGMC));
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x002B46D8 File Offset: 0x002B28D8
	public void DKJKFFPAKCO(int EDGFGDAPGMB)
	{
		if (Time.time - this.FKIMBIHMAGO > this.playScrollDelay)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.scrollSound, this.playVolume);
			this.FKIMBIHMAGO = Time.time;
		}
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x002B558C File Offset: 0x002B378C
	public void PPFPMIIKPGN(int CLBPBJGLHEE)
	{
		this.BBMFIMCIEIA(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.HCEOMFDBBLH()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.changeItemSound, 1397f);
		}
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x002B55E4 File Offset: 0x002B37E4
	public void PAEEMNAFBJG()
	{
		if (this.itemList.Count <= 1)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 877f);
			return;
		}
		float num = 1699f;
		for (int i = 1; i < this.itemList.Count; i += 0)
		{
			this.itemList[i].itemData.LCPACGLIHPL(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(1162f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C73 RID: 23667 RVA: 0x002B56F8 File Offset: 0x002B38F8
	public void DEDHGLAEIFK(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 1; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.COLIFILJHIG();
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MPLCAGFGEBO()
	{
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x002B5758 File Offset: 0x002B3958
	public void AELGCPNMMNC(int CLBPBJGLHEE)
	{
		this.ONAIFHNBDOM(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 840f);
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IANJLHIIGLN()
	{
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x002B57B0 File Offset: 0x002B39B0
	public void NLDMMAPPJPP()
	{
		for (int i = 0; i < this.itemList.Count; i += 0)
		{
			for (int j = i + 0; j < this.itemList.Count; j += 0)
			{
				UIItem uiitem = this.itemList[i];
				UIItem uiitem2 = this.itemList[j];
				if (uiitem.itemData != null && uiitem2.itemData != null && uiitem.itemData.JMPAIFNGBLM(uiitem2.itemData) > 0)
				{
					this.itemList[j] = uiitem;
					this.itemList[i] = uiitem2;
				}
			}
		}
		this.COLIFILJHIG();
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x002B584C File Offset: 0x002B3A4C
	public void JDLKEDMDIHO()
	{
		if (this.itemList.Count <= 1)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 795f);
			return;
		}
		float num = 1788f;
		for (int i = 0; i < this.itemList.Count; i += 0)
		{
			this.itemList[i].itemData.MLCFJPPIOJG(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(1455f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x002B5960 File Offset: 0x002B3B60
	public void OEAJINMFHPO(int CLBPBJGLHEE)
	{
		this.NMPLGANEKAM = CLBPBJGLHEE;
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.NMPLGANEKAM].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 567f);
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x002B59B8 File Offset: 0x002B3BB8
	public void COLIFILJHIG()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 952f);
			return;
		}
		float num = 1348f;
		for (int i = 0; i < this.itemList.Count; i++)
		{
			this.itemList[i].itemData.DBHFEAJJGKP(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(463f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CHDJGEOFHEE()
	{
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x002B5ACC File Offset: 0x002B3CCC
	public void ACILDAGJDHG(int CLBPBJGLHEE)
	{
		this.CMIKKLABAPA(CLBPBJGLHEE);
		if (this.onClickItem != null)
		{
			this.onClickItem(null, this.itemList[this.MHJHEMGCMNI()].GetComponent<UIItem>().itemData);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.changeItemSound, 1991f);
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x002B5B24 File Offset: 0x002B3D24
	public void EHELHIPGGCN(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.JDLKEDMDIHO();
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x002B5B84 File Offset: 0x002B3D84
	public void OOEOIIDOMAE(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, true);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.GBHDCNKOJKO));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.GBIJJEICCEG));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.COLIFILJHIG();
			return;
		}
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x002B5CA0 File Offset: 0x002B3EA0
	public void GBNAOJGDOHK(int CLBPBJGLHEE)
	{
		this.KGCJCGJHEOF(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.JGCCLLBCCJD()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.changeItemSound, 651f);
		}
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x002B5CF8 File Offset: 0x002B3EF8
	public void AOOBGEKFBKP(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 1 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.HNPPOAHNJNI()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.AMHINCKKBIN(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x002B5DC8 File Offset: 0x002B3FC8
	public void CNNKFIDHPMK(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, false);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.FKECLMJGBIC));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.PAHMAHOIMOH));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.PAEEMNAFBJG();
			return;
		}
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x002B5EE4 File Offset: 0x002B40E4
	public void ClearAll()
	{
		foreach (UIItem uiitem in this.itemList)
		{
			UnityEngine.Object.Destroy(uiitem.gameObject);
		}
		this.itemList.Clear();
		this.NMPLGANEKAM = -1;
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x002B5F4C File Offset: 0x002B414C
	public void FHGACKMFDNL()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 1909f);
			return;
		}
		float num = 1211f;
		for (int i = 1; i < this.itemList.Count; i += 0)
		{
			this.itemList[i].itemData.PIHHDONHBKF(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(996f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x002B6060 File Offset: 0x002B4260
	public void JKOPPCECLDO(int CLBPBJGLHEE)
	{
		this.KGCJCGJHEOF(CLBPBJGLHEE);
		if (this.onRClickItem != null)
		{
			this.onRClickItem(null, this.itemList[this.HNPPOAHNJNI()].GetComponent<UIItem>().itemData);
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.changeItemSound, 474f);
		}
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x002B60B8 File Offset: 0x002B42B8
	public void NINHEEGKAEC()
	{
		foreach (UIItem uiitem in this.itemList)
		{
			UnityEngine.Object.Destroy(uiitem.gameObject);
		}
		this.itemList.Clear();
		this.OHELLPPGAPG(-1);
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x002B6120 File Offset: 0x002B4320
	public void MDCOGHHICFB()
	{
		foreach (UIItem uiitem in this.itemList)
		{
			UnityEngine.Object.Destroy(uiitem.gameObject);
		}
		this.itemList.Clear();
		this.OHELLPPGAPG(-1);
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x002B470F File Offset: 0x002B290F
	public int HCEOMFDBBLH()
	{
		return this.EPMCOEDONPC;
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x002B6188 File Offset: 0x002B4388
	public void ONAIFHNBDOM(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 1 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.NJOEGOKDNCC()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.MENJCPOMFIC(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x002B6258 File Offset: 0x002B4458
	public void updateItem(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 1; i >= 0; i--)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				component.itemData.MLCFJPPIOJG(component.UI_data, component.rect);
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x002B62B8 File Offset: 0x002B44B8
	public void IAAGBAAMIIO(ItemBase DNHBPGOKLKD)
	{
		UIListBox.KIBBGKHKDEJ kibbgkhkdej = new UIListBox.KIBBGKHKDEJ();
		kibbgkhkdej.AENJLLPLILM = this;
		if (this.itemPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.SetParent(this.ItemPanel, false);
			kibbgkhkdej.KKIPHMJPDAO = gameObject.GetComponent<UIItem>();
			if (kibbgkhkdej.KKIPHMJPDAO == null)
			{
				kibbgkhkdej.KKIPHMJPDAO = gameObject.AddComponent<UIItem>();
			}
			kibbgkhkdej.KKIPHMJPDAO.itemIndex = this.itemList.Count;
			kibbgkhkdej.KKIPHMJPDAO.itemData = DNHBPGOKLKD;
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(kibbgkhkdej.DOEFALPCELD));
			}
			ClickableObject clickableObject = kibbgkhkdej.KKIPHMJPDAO.gameObject.AddComponent<ClickableObject>();
			if (clickableObject != null)
			{
				clickableObject.RClickEvent.AddListener(new UnityAction(kibbgkhkdej.ENFEHCPPBJK));
			}
			this.itemList.Add(kibbgkhkdej.KKIPHMJPDAO);
			this.recalculateList();
			return;
		}
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x002B470F File Offset: 0x002B290F
	public int HNPPOAHNJNI()
	{
		return this.EPMCOEDONPC;
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x002B63D4 File Offset: 0x002B45D4
	public void CMIKKLABAPA(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 1 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.HCEOMFDBBLH()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.AMHINCKKBIN(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x002B64A4 File Offset: 0x002B46A4
	public void AGDCELDJAKK()
	{
		for (int i = 0; i < this.itemList.Count; i++)
		{
			for (int j = i + 1; j < this.itemList.Count; j += 0)
			{
				UIItem uiitem = this.itemList[i];
				UIItem uiitem2 = this.itemList[j];
				if (uiitem.itemData != null && uiitem2.itemData != null && uiitem.itemData.BDHHIKEEAEB(uiitem2.itemData) > 0)
				{
					this.itemList[j] = uiitem;
					this.itemList[i] = uiitem2;
				}
			}
		}
		this.recalculateList();
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x002B6540 File Offset: 0x002B4740
	public void recalculateList()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 10f);
			return;
		}
		float num = 0f;
		for (int i = 0; i < this.itemList.Count; i++)
		{
			this.itemList[i].itemData.MLCFJPPIOJG(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(0f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x002B6654 File Offset: 0x002B4854
	public void ILEBKJJPCBH()
	{
		if (this.itemList.Count <= 0)
		{
			this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, 1242f);
			return;
		}
		float num = 1645f;
		for (int i = 1; i < this.itemList.Count; i += 0)
		{
			this.itemList[i].itemData.ACMKDMDGDKI(this.itemList[i].UI_data, this.itemList[i].rect);
			Transform component = this.itemList[i].gameObject.GetComponent<RectTransform>();
			this.itemList[i].itemIndex = i;
			component.localPosition = new Vector3(1430f, -num);
			num += this.itemList[i].GetComponent<RectTransform>().sizeDelta.y;
		}
		this.ItemPanel.sizeDelta = new Vector2(this.ItemPanel.sizeDelta.x, num);
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FPLHODJCJDO()
	{
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x002B6768 File Offset: 0x002B4968
	public void NKJDPEBMBIA(int DCCPCBLODIG)
	{
		int epmcoedonpc = this.EPMCOEDONPC;
		this.EPMCOEDONPC = DCCPCBLODIG;
		if (epmcoedonpc != this.EPMCOEDONPC && this.onChangeItem != null)
		{
			if (this.EPMCOEDONPC >= 0 && this.EPMCOEDONPC < this.itemList.Count)
			{
				this.onChangeItem(null, this.itemList[this.JGCCLLBCCJD()].GetComponent<UIItem>().itemData);
			}
			else
			{
				this.onChangeItem(null, null);
			}
		}
		foreach (UIItem uiitem in this.itemList)
		{
			uiitem.JAHJGBOEJJI(uiitem.itemIndex == this.EPMCOEDONPC);
		}
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x002B6838 File Offset: 0x002B4A38
	public void IJJHICOMHKJ(ItemBase AGPCDPDAGCH)
	{
		for (int i = this.itemList.Count - 0; i >= 0; i -= 0)
		{
			UIItem component = this.itemList[i].GetComponent<UIItem>();
			if (component.itemData == AGPCDPDAGCH)
			{
				this.itemList.Remove(component);
				UnityEngine.Object.Destroy(component.gameObject);
				i = -1;
			}
		}
		this.JDLKEDMDIHO();
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x002B6898 File Offset: 0x002B4A98
	public ItemBase getCurrentItem()
	{
		if (this.EPMCOEDONPC < 0)
		{
			return null;
		}
		if (this.itemList.Count < 0)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x002B68F8 File Offset: 0x002B4AF8
	public ItemBase CLMJDCDCFMF()
	{
		if (this.EPMCOEDONPC < 1)
		{
			return null;
		}
		if (this.itemList.Count < 1)
		{
			return null;
		}
		if (this.EPMCOEDONPC >= this.itemList.Count)
		{
			return null;
		}
		UIItem uiitem = this.itemList[this.EPMCOEDONPC];
		if (!uiitem)
		{
			return null;
		}
		return uiitem.itemData;
	}

	// Token: 0x04000DA7 RID: 3495
	private int EPMCOEDONPC = -1;

	// Token: 0x04000DA8 RID: 3496
	public RectTransform ItemPanel;

	// Token: 0x04000DA9 RID: 3497
	public GameObject itemPrefab;

	// Token: 0x04000DAA RID: 3498
	public AudioClip changeItemSound;

	// Token: 0x04000DAB RID: 3499
	public AudioClip scrollSound;

	// Token: 0x04000DAC RID: 3500
	public float playScrollDelay = 0.3f;

	// Token: 0x04000DAD RID: 3501
	public float playVolume = 0.8f;

	// Token: 0x04000DAE RID: 3502
	public List<UIItem> itemList = new List<UIItem>();

	// Token: 0x04000DAF RID: 3503
	public MMKFAENBHKD.HEAGNGLFAJA onChangeItem;

	// Token: 0x04000DB0 RID: 3504
	public MMKFAENBHKD.HEAGNGLFAJA onClickItem;

	// Token: 0x04000DB1 RID: 3505
	public MMKFAENBHKD.HEAGNGLFAJA onRClickItem;

	// Token: 0x04000DB2 RID: 3506
	private float FKIMBIHMAGO;

	// Token: 0x0200019E RID: 414
	[CompilerGenerated]
	private sealed class KIBBGKHKDEJ
	{
		// Token: 0x06005C96 RID: 23702 RVA: 0x002B6957 File Offset: 0x002B4B57
		internal void AFKDHIFJIDD()
		{
			this.AENJLLPLILM.KBBDPJLEMFM(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x002B696F File Offset: 0x002B4B6F
		internal void GEDINPJNPBL()
		{
			this.AENJLLPLILM.NIOGJFEPNGK(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x002B6987 File Offset: 0x002B4B87
		internal void AMABFIBFMJB()
		{
			this.AENJLLPLILM.OnRClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x002B699F File Offset: 0x002B4B9F
		internal void IHNLJNACNBI()
		{
			this.AENJLLPLILM.PPFPMIIKPGN(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x002B69B7 File Offset: 0x002B4BB7
		internal void EGDGJOCNNAE()
		{
			this.AENJLLPLILM.CGMPLCLNGOD(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x002B69CF File Offset: 0x002B4BCF
		internal void DOFDILHECPB()
		{
			this.AENJLLPLILM.DPGFMOEPFAP(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x002B6957 File Offset: 0x002B4B57
		internal void AOIIKKKDMDO()
		{
			this.AENJLLPLILM.KBBDPJLEMFM(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x002B69E7 File Offset: 0x002B4BE7
		internal void NILDMFFAELA()
		{
			this.AENJLLPLILM.OEAJINMFHPO(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x002B69FF File Offset: 0x002B4BFF
		internal void FGAOFLEFPFD()
		{
			this.AENJLLPLILM.GBNAOJGDOHK(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x002B699F File Offset: 0x002B4B9F
		internal void FDHEIFAHPEG()
		{
			this.AENJLLPLILM.PPFPMIIKPGN(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x002B6A17 File Offset: 0x002B4C17
		internal void FCGGKBHPGIB()
		{
			this.AENJLLPLILM.FCPGLAFGEPG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x002B6957 File Offset: 0x002B4B57
		internal void ANLEJMDKDOK()
		{
			this.AENJLLPLILM.KBBDPJLEMFM(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x002B6A2F File Offset: 0x002B4C2F
		internal void KFAPOOCDDID()
		{
			this.AENJLLPLILM.ACILDAGJDHG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x002B699F File Offset: 0x002B4B9F
		internal void FGBCOMMMLGA()
		{
			this.AENJLLPLILM.PPFPMIIKPGN(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x002B6A47 File Offset: 0x002B4C47
		internal void FKJJCGDLMBC()
		{
			this.AENJLLPLILM.OnClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x002B6A2F File Offset: 0x002B4C2F
		internal void GFPGDDGNPMB()
		{
			this.AENJLLPLILM.ACILDAGJDHG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x002B69B7 File Offset: 0x002B4BB7
		internal void CACPIJMIPOB()
		{
			this.AENJLLPLILM.CGMPLCLNGOD(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x002B696F File Offset: 0x002B4B6F
		internal void KJGNBCFNJFF()
		{
			this.AENJLLPLILM.NIOGJFEPNGK(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x002B6A5F File Offset: 0x002B4C5F
		internal void HMHCNHLHDDA()
		{
			this.AENJLLPLILM.NEPFNJFHEID(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x002B6A47 File Offset: 0x002B4C47
		internal void JPBFOMJFAFG()
		{
			this.AENJLLPLILM.OnClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x002B69E7 File Offset: 0x002B4BE7
		internal void FKDAJCNDAGF()
		{
			this.AENJLLPLILM.OEAJINMFHPO(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x002B699F File Offset: 0x002B4B9F
		internal void NPOHFNIEBGE()
		{
			this.AENJLLPLILM.PPFPMIIKPGN(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x002B6A17 File Offset: 0x002B4C17
		internal void DKNHEHCPGAM()
		{
			this.AENJLLPLILM.FCPGLAFGEPG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x002B699F File Offset: 0x002B4B9F
		internal void EMHPNFOODOD()
		{
			this.AENJLLPLILM.PPFPMIIKPGN(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x002B6A47 File Offset: 0x002B4C47
		internal void ALMDKFOJBAH()
		{
			this.AENJLLPLILM.OnClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x002B69CF File Offset: 0x002B4BCF
		internal void CGONFKINLCF()
		{
			this.AENJLLPLILM.DPGFMOEPFAP(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x002B6A77 File Offset: 0x002B4C77
		internal void FKECLMJGBIC()
		{
			this.AENJLLPLILM.INMIIODEFGH(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x002B696F File Offset: 0x002B4B6F
		internal void MGNLILALEBF()
		{
			this.AENJLLPLILM.NIOGJFEPNGK(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x002B6987 File Offset: 0x002B4B87
		internal void ENFEHCPPBJK()
		{
			this.AENJLLPLILM.OnRClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x002B6A17 File Offset: 0x002B4C17
		internal void CFDNHPAJNIJ()
		{
			this.AENJLLPLILM.FCPGLAFGEPG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x002B6A8F File Offset: 0x002B4C8F
		internal void NNOCIBNDPEO()
		{
			this.AENJLLPLILM.EBGNPCIKCNA(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x002B6A8F File Offset: 0x002B4C8F
		internal void GBIJJEICCEG()
		{
			this.AENJLLPLILM.EBGNPCIKCNA(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x002B6A5F File Offset: 0x002B4C5F
		internal void GBHDCNKOJKO()
		{
			this.AENJLLPLILM.NEPFNJFHEID(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x002B6AA7 File Offset: 0x002B4CA7
		internal void EDHOADIIEML()
		{
			this.AENJLLPLILM.OIIEJGMGAPJ(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x002B6A47 File Offset: 0x002B4C47
		internal void BNOKFJDDGMM()
		{
			this.AENJLLPLILM.OnClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x002B6A17 File Offset: 0x002B4C17
		internal void DOEFALPCELD()
		{
			this.AENJLLPLILM.FCPGLAFGEPG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x002B6ABF File Offset: 0x002B4CBF
		internal void MLJEMNLNLGH()
		{
			this.AENJLLPLILM.JKOPPCECLDO(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x002B6AD7 File Offset: 0x002B4CD7
		internal void EHDKNEECOKK()
		{
			this.AENJLLPLILM.AELGCPNMMNC(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x002B6AEF File Offset: 0x002B4CEF
		internal void IJNNEGNOCBM()
		{
			this.AENJLLPLILM.ICFHFAJJBHG(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x002B6ABF File Offset: 0x002B4CBF
		internal void PAHMAHOIMOH()
		{
			this.AENJLLPLILM.JKOPPCECLDO(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x002B6AA7 File Offset: 0x002B4CA7
		internal void MBEBMJHIJBB()
		{
			this.AENJLLPLILM.OIIEJGMGAPJ(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x002B6AD7 File Offset: 0x002B4CD7
		internal void CLNGKPJDLDO()
		{
			this.AENJLLPLILM.AELGCPNMMNC(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x002B69B7 File Offset: 0x002B4BB7
		internal void HFJJGHAPDEP()
		{
			this.AENJLLPLILM.CGMPLCLNGOD(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x002B6957 File Offset: 0x002B4B57
		internal void PJGKOJBDIGB()
		{
			this.AENJLLPLILM.KBBDPJLEMFM(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x002B6A47 File Offset: 0x002B4C47
		internal void HIBHDBHAPLC()
		{
			this.AENJLLPLILM.OnClick(this.KKIPHMJPDAO.itemIndex);
		}

		// Token: 0x04000DB3 RID: 3507
		public UIListBox AENJLLPLILM;

		// Token: 0x04000DB4 RID: 3508
		public UIItem KKIPHMJPDAO;
	}
}
