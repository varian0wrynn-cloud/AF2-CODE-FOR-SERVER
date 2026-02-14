using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001D1 RID: 465
public class LocationLogic : MonoBehaviour
{
	// Token: 0x060069DB RID: 27099 RVA: 0x00323338 File Offset: 0x00321538
	public void KLGBBOLIPFH(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.clearImages();
			return;
		}
		bool flag = false;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[1].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[1].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[2].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = false;
		}
		if (flag)
		{
			this.PADDNDCJAOO();
		}
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x003233B4 File Offset: 0x003215B4
	private void COOHBKKNOLG()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.DPBNHMCDIIK().LILKJKNMCDK();
	}

	// Token: 0x060069DD RID: 27101 RVA: 0x003233C8 File Offset: 0x003215C8
	public void clearImages()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069DE RID: 27102 RVA: 0x003233F3 File Offset: 0x003215F3
	private void IIELJNDNLMO()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.KPGHCNPGAGL().LILKJKNMCDK();
	}

	// Token: 0x060069DF RID: 27103 RVA: 0x00323408 File Offset: 0x00321608
	public Vector2 AEIPMEEOMKK()
	{
		Vector2 vector = Input.mousePosition;
		return new Vector2(829f, 1556f)
		{
			x = vector.x / (float)Screen.width,
			y = ((float)Screen.height - vector.y) / LocationGui.getI.backLockImage.rectTransform.rect.height
		};
	}

	// Token: 0x060069E0 RID: 27104 RVA: 0x00323478 File Offset: 0x00321678
	public void EBEMEOOBCKO()
	{
		FRodObject[] array = this.userRods;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].BGLLPMKNBCE = true;
		}
	}

	// Token: 0x060069E1 RID: 27105 RVA: 0x003234A4 File Offset: 0x003216A4
	public void OEGNAHJIPIM(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(1))
		{
			return;
		}
		this.NHMFEMFPMJL(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.GDAPJOFLAIF(0);
			this.ws.setParamsDeep(777f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NFCDJLJNDLO(), this.userRods[this.selectedRod].BICGFMMPIAI);
			this.ws.BFMEFDJJJAG();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(true);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(false);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x060069E2 RID: 27106 RVA: 0x0032356B File Offset: 0x0032176B
	public void ENOCIOIJKDF()
	{
		JLFJEGIPIMM.NNEAHAFBOHC().DAJFMBBDJIC("cht_msg37" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060069E3 RID: 27107 RVA: 0x003235A8 File Offset: 0x003217A8
	private void BNKJNBIDPME()
	{
		if (Input.GetKeyDown((KeyCode)(-131)))
		{
			FlyMessageManager.getI.MAKLOJFMODM("MotorbikeLassoLeft", -89, 4, 0);
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			OJCFBJGEEHL.IKGFHGKKCPG.MIMOACHDMAC(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.KOJCECHBHLO() != null)
		{
			this.lightSky.color = TimeController.IKGFHGKKCPG.currentAmbientColor;
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 0 && !this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			this.NIIOMLGLHCP();
		}
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.locImage.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		bool active = true;
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 1; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = true;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x00323784 File Offset: 0x00321984
	public void PCIJBGHMKOC(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(1))
		{
			return;
		}
		if (this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 5)
		{
			this.PAIPILKFEDC = -118;
			this.IIPDNDLKOKN = -61;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[0];
			this.userRods[this.selectedRod].BCPJHJEBBPM(false);
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.PJHMHBAGFAN(1577f, 1734f, "Cloth_05_00.wav", false);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - 1444f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - 944f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 760f, 1706f, onkdcgnbalk.OCHCODJIPHJ.width - 1260f, onkdcgnbalk.OCHCODJIPHJ.height - 1658f, 1);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == 104)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -59)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.BNMMBHIFKBP();
			int dccpcblodig = 1;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 1; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.IHEILFHMLAG = dccpcblodig;
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.changeBait);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x003239DC File Offset: 0x00321BDC
	public void AEGBCKDLDEO()
	{
		Debug.Log("ChannelCastDirected");
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x003239E8 File Offset: 0x00321BE8
	public void BJGIALGNDGN()
	{
		if (JDCEFOFMGHB.MNJNNDHCDGG().AMGIJECABAD())
		{
			return;
		}
		Vector2 vector = this.BBFJLILKIPJ();
		int num = -1;
		if (Input.GetMouseButtonUp(1))
		{
			num = 0;
		}
		if (Input.GetMouseButtonUp(0))
		{
			num = 0;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].fishPodsek();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.DCNEMBOEEPI(vector.x, vector.y))
				{
					this.userRods[this.selectedRod].setPosition(vector);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[8], 1306f);
				this.userRods[this.selectedRod].BCPJHJEBBPM(true);
				return;
			}
		}
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x00323AEF File Offset: 0x00321CEF
	public void GKLKKICHAAE()
	{
		if (this.sonar == null)
		{
			return;
		}
		this.sonar.gameObject.SetActive(this.sonar.gameObject.activeSelf);
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x00323B23 File Offset: 0x00321D23
	private IEnumerator CPKKCMPJDOA()
	{
		LocationLogic.NOHHCBHCJOH nohhcbhcjoh = new LocationLogic.NOHHCBHCJOH(1);
		nohhcbhcjoh.AENJLLPLILM = this;
		return nohhcbhcjoh;
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00323B32 File Offset: 0x00321D32
	private void MJMMOFELPBM()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.KPGHCNPGAGL().HHFMCEGDDMD();
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x00323B44 File Offset: 0x00321D44
	public void AKBOAIHDEHB()
	{
		JLFJEGIPIMM.PKGMBFEMKGP().OMPJLOEGMII("_rcOut.ogg" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x00323B7F File Offset: 0x00321D7F
	public FRodObject BIFBGCBNEMK()
	{
		if (!this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ODMHNCDHMMB()
	{
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x00323BA4 File Offset: 0x00321DA4
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F1))
		{
			FlyMessageManager.getI.addRightMessage("Проверка предмета", 1050, 3, 0);
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			OJCFBJGEEHL.IKGFHGKKCPG.JALELHDNPLB(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.IKGFHGKKCPG != null)
		{
			this.lightSky.color = TimeController.IKGFHGKKCPG.currentAmbientColor;
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 0 && !this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			this.clearImages();
		}
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.locImage.color = TimeController.IKGFHGKKCPG.currentAmbientColor;
		}
		bool active = false;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = true;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 0; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = true;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x00323D80 File Offset: 0x00321F80
	public void KKKHJHLBGMB()
	{
		FRodObject[] array = this.userRods;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].BGLLPMKNBCE = false;
		}
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x00323DAC File Offset: 0x00321FAC
	public Vector2 BBFJLILKIPJ()
	{
		Vector2 vector = Input.mousePosition;
		return new Vector2(1755f, 1257f)
		{
			x = vector.x / (float)Screen.width,
			y = ((float)Screen.height - vector.y) / LocationGui.getI.backLockImage.rectTransform.rect.height
		};
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CJCLLCGHFFG()
	{
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x00323E1C File Offset: 0x0032201C
	public void PKCHJLBECCA(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(0))
		{
			return;
		}
		this.AJAKALPFNMI(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.JPOGJAHEJHM(1);
			this.ws.HKJMHHOJNFE(1688f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].LJNDEDHCEAL());
			this.ws.CNOAIEKIAND();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(false);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(true);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MouseLeaveLocation()
	{
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x00323EE4 File Offset: 0x003220E4
	private void AFHBOLFGJNE()
	{
		if (Input.GetKeyDown((KeyCode)(-178)))
		{
			FlyMessageManager.getI.MAKLOJFMODM("\n", 130, 1, 0);
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			OJCFBJGEEHL.IKGFHGKKCPG.DNEPMKLKGKG(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.KOJCECHBHLO() != null)
		{
			this.lightSky.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			this.IANMLBJDOBD();
		}
		if (TimeController.KOJCECHBHLO() != null)
		{
			this.locImage.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		bool active = false;
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 1; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.PAGGOCBABNO(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = false;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060069F4 RID: 27124 RVA: 0x00323B23 File Offset: 0x00321D23
	private IEnumerator CENKDKCCDOC()
	{
		LocationLogic.NOHHCBHCJOH nohhcbhcjoh = new LocationLogic.NOHHCBHCJOH(1);
		nohhcbhcjoh.AENJLLPLILM = this;
		return nohhcbhcjoh;
	}

	// Token: 0x060069F5 RID: 27125 RVA: 0x003240C0 File Offset: 0x003222C0
	public void updateImages(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.clearImages();
			return;
		}
		bool flag = true;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[1].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[2].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[3].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			flag = false;
		}
		if (flag)
		{
			this.clearImages();
		}
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x0032413C File Offset: 0x0032233C
	private void JFFPLABGMNF()
	{
		int num = 0;
		if (EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF != null)
		{
			num = EDLNGHBMJBL.FEJILBICKGG().PJBEDBENEJI().LPFKFNLHGBI;
		}
		string text = "ThisRenderer.bones[i].name is null" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("ArmFlex5" + text + "Idle Sand Cover");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("colorC");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("CP1");
		}
		this.FMBOCCAILBA(this.locData);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.MainCanvas);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(14);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(122);
		this.userRods[6].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-28);
		base.StartCoroutine(this.MNPCLIHPGKN());
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x00324260 File Offset: 0x00322460
	public void PADDNDCJAOO()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069F8 RID: 27128 RVA: 0x0032428C File Offset: 0x0032248C
	public void PHDKGGICEJL()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069F9 RID: 27129 RVA: 0x003242B8 File Offset: 0x003224B8
	public void IMNOEKIKDOD()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA())
		{
			return;
		}
		Vector2 clickLocPosition = this.getClickLocPosition();
		int num = -1;
		if (Input.GetMouseButtonUp(0))
		{
			num = 1;
		}
		if (Input.GetMouseButtonUp(0))
		{
			num = 0;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].fishPodsek();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.JHNGECBJEPN(clickLocPosition.x, clickLocPosition.y))
				{
					this.userRods[this.selectedRod].setPosition(clickLocPosition);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[3], 1390f);
				this.userRods[this.selectedRod].HPLDIIIFDCP(false);
				return;
			}
		}
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x003243C0 File Offset: 0x003225C0
	public void IANMLBJDOBD()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069FB RID: 27131 RVA: 0x003243EC File Offset: 0x003225EC
	public void KDMCEAHODJJ(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.DEFBLKPDLPM() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.BMOEEJCBDJO()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.MFPECHIKBCO(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.AAHBHCMKGJD(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(155, epmphjgalbe.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe.PMIGGJHLIDO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.MFPECHIKBCO(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.EAOGDKDBENC(this.PAIPILKFEDC);
				epmphjgalbe2.GOMLLPFFPNP(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-133, epmphjgalbe2.IEJLLFECFHF());
			}
			finally
			{
				epmphjgalbe2.BKKEFKANGIM();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("{{ {{{0}:{1}}}, {{{2}:{3}}} }}", 1007f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.NMDLAAGEAGC(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x003245AC File Offset: 0x003227AC
	public void HJBAIPKABIF(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(1))
		{
			return;
		}
		if (this.userRods[this.selectedRod].EFGNLFFKDMI() && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 0)
		{
			this.PAIPILKFEDC = 60;
			this.IIPDNDLKOKN = -5;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[1];
			this.userRods[this.selectedRod].BCPJHJEBBPM(false);
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PLHAGCDJLPA(344f, 661f, "", false);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - 1464f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - 640f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 1186f, 1458f, onkdcgnbalk.OCHCODJIPHJ.width - 189f, onkdcgnbalk.OCHCODJIPHJ.height - 276f, 1);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -50)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -85)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.GENPNFMLHED();
			int dccpcblodig = 0;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.JJKGANHANFN(dccpcblodig);
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.KNOEDAIEGFA);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x00324804 File Offset: 0x00322A04
	public void NIIOMLGLHCP()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069FE RID: 27134 RVA: 0x00324830 File Offset: 0x00322A30
	public void EKKMDJAOPPF()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x0032485C File Offset: 0x00322A5C
	private void PJOKLGLNDHD()
	{
		if (Input.GetKeyDown((KeyCode)(-138)))
		{
			FlyMessageManager.getI.addRightMessage("", -142, 1, 0);
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			OJCFBJGEEHL.IKGFHGKKCPG.BLMJJLNIPLG(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.EPCKOOOGNGK() != null)
		{
			this.lightSky.color = TimeController.BOBNPEAEECC().currentAmbientColor;
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].EFGNLFFKDMI())
		{
			this.KOINKMHMNHG();
		}
		if (TimeController.IKGFHGKKCPG != null)
		{
			this.locImage.color = TimeController.BOBNPEAEECC().currentAmbientColor;
		}
		bool active = true;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].LMCCAABKAGE() && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 0; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = false;
			}
			else
			{
				this.rodButtons[i].interactable = true;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06006A00 RID: 27136 RVA: 0x00324A38 File Offset: 0x00322C38
	public void DBJEBPJMIHN(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(0))
		{
			return;
		}
		this.MOALJJMJMGL(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.ICNKOEEMFCF(0);
			this.ws.BBCLOPGIAMP(865f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NFCDJLJNDLO(), this.userRods[this.selectedRod].BICGFMMPIAI);
			this.ws.CNBGANBEEME();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(true);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(true);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x06006A01 RID: 27137 RVA: 0x00324B00 File Offset: 0x00322D00
	public void LGCEOHLOFOO(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.OMDHGKHOKDH();
			return;
		}
		bool flag = false;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[0].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[1].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = true;
		}
		if (flag)
		{
			this.IANMLBJDOBD();
		}
	}

	// Token: 0x06006A02 RID: 27138 RVA: 0x00324B7C File Offset: 0x00322D7C
	public void PCCFNLLBBMK()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("prov_sob_" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x00324BB8 File Offset: 0x00322DB8
	public void KNOEDAIEGFA(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.HHJKOIJGNAK() < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.IHEILFHMLAG];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.MFPECHIKBCO(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OBJBHBFAFEE(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(52, epmphjgalbe.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.AAHBHCMKGJD(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.GOMLLPFFPNP(this.PAIPILKFEDC);
				epmphjgalbe2.AEMAHNDEBKJ(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-141, epmphjgalbe2.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe2.NCKMEIBFNGL();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Handstand", 202f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.BILODNADPOH(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A04 RID: 27140 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ECKCGEFDAAC()
	{
	}

	// Token: 0x06006A05 RID: 27141 RVA: 0x00324D78 File Offset: 0x00322F78
	private void ELCNJDNCAEP()
	{
		int num = 0;
		if (EDLNGHBMJBL.IKGFHGKKCPG.PJBEDBENEJI() != null)
		{
			num = EDLNGHBMJBL.IKGFHGKKCPG.PJBEDBENEJI().LPFKFNLHGBI;
		}
		string text = "http://www.root-motion.com/finalikdox/html/page12.html" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("fanfare.wav" + text + "cht_msg36");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("\n");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("****************  stopMusic ");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		GuiProcessor.PLGADNLAEGN().CPDHMBFPGMD(this.MainCanvas);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(42);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-102);
		this.userRods[5].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-63);
		base.StartCoroutine(this.KBHCICGKANE());
	}

	// Token: 0x06006A06 RID: 27142 RVA: 0x00324E9C File Offset: 0x0032309C
	public void selectRod(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].OnSelect();
		this.ws.setParamsDeep(0f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
	}

	// Token: 0x06006A07 RID: 27143 RVA: 0x00324F18 File Offset: 0x00323118
	private void AFFAJKPPMHF()
	{
		int num = 4;
		if (EDLNGHBMJBL.IKGFHGKKCPG.PJBEDBENEJI() != null)
		{
			num = EDLNGHBMJBL.JMHOODFAGAM().ABAABKBBLGK().LPFKFNLHGBI;
		}
		string text = "error.wav" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("ECHO ON " + text + "UNIQUE_SHADOW");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("Show History (messages : {0})");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("TOD_CloudShadow");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		GuiProcessor.NKOEAPCIBKO().FJLPFLCJMPE(this.MainCanvas);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-38);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(68);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.FJGNFCPLNNF(-30);
		base.StartCoroutine(this.EOBPGBGLEMD());
	}

	// Token: 0x06006A08 RID: 27144 RVA: 0x00325039 File Offset: 0x00323239
	private void CHMJOEBCBCM(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A09 RID: 27145 RVA: 0x00325058 File Offset: 0x00323258
	public void HKEHBHBHJAM(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG < 1)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.HHJKOIJGNAK() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.NAIIDOFAJKG()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OACBICLGENB(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-115, epmphjgalbe.HDEKHFOKCKI());
			}
			finally
			{
				epmphjgalbe.PMIGGJHLIDO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.AAHBHCMKGJD(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.EAOGDKDBENC(this.PAIPILKFEDC);
				epmphjgalbe2.PDEFLCIEMFF(this.IIPDNDLKOKN);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-111, epmphjgalbe2.JOCJNOBBELJ());
			}
			finally
			{
				epmphjgalbe2.HDKBMLOJLLC();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Finished", 1875f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.HFIKBPDDOBL(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A0A RID: 27146 RVA: 0x00325218 File Offset: 0x00323418
	public void GJADMJKLMIC(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.FJNDDAMCLFL() < 1)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.DEFBLKPDLPM() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.NAIIDOFAJKG()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OACBICLGENB(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-174, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBJBHBFAFEE(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.JDOLCNDNFGP(this.PAIPILKFEDC);
				epmphjgalbe2.JIIKLOKAGIC(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(141, epmphjgalbe2.HDEKHFOKCKI());
			}
			finally
			{
				epmphjgalbe2.PMIGGJHLIDO();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("invn_win1", 1449f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.LGCEOHLOFOO(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A0B RID: 27147 RVA: 0x003253D8 File Offset: 0x003235D8
	public bool LMODDKDOFKH()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = false;
		if (JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A0C RID: 27148 RVA: 0x00325418 File Offset: 0x00323618
	public void GDJCJIMLIND()
	{
		FRodObject[] array = this.userRods;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].BCPJHJEBBPM(false);
		}
	}

	// Token: 0x06006A0D RID: 27149 RVA: 0x00325444 File Offset: 0x00323644
	public void KIPJLNOLFMM(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.KOINKMHMNHG();
			return;
		}
		bool flag = false;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[0].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[6].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[8].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			flag = false;
		}
		if (flag)
		{
			this.PADDNDCJAOO();
		}
	}

	// Token: 0x06006A0E RID: 27150 RVA: 0x003254C0 File Offset: 0x003236C0
	public bool NPCLNJACPFH()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = false;
		if (JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A0F RID: 27151 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FCDEMOAAKGN()
	{
	}

	// Token: 0x06006A10 RID: 27152 RVA: 0x00325039 File Offset: 0x00323239
	private void HJODAJPBHFE(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A11 RID: 27153 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MouseEnterLocation()
	{
	}

	// Token: 0x06006A12 RID: 27154 RVA: 0x00325500 File Offset: 0x00323700
	private void PFPPDNHLCCA()
	{
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			FlyMessageManager.getI.MAKLOJFMODM("HYPERLINK", -30, 3, 1);
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			OJCFBJGEEHL.IKGFHGKKCPG.GJLBBJHBEJE(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.BOBNPEAEECC() != null)
		{
			this.lightSky.color = TimeController.BOBNPEAEECC().currentAmbientColor;
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].IBDLAMAFJNF();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			this.HLAIJDNDINA();
		}
		if (TimeController.KOJCECHBHLO() != null)
		{
			this.locImage.color = TimeController.IKGFHGKKCPG.currentAmbientColor;
		}
		bool active = false;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].EFGNLFFKDMI() && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = true;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 0; i < this.rodButtons.Length; i += 0)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = true;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06006A13 RID: 27155 RVA: 0x00022FCC File Offset: 0x000211CC
	public void HMNJPEIKFIK()
	{
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x003256DC File Offset: 0x003238DC
	public FRodObject getActiveRod()
	{
		if (!this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x00325704 File Offset: 0x00323904
	public void EBEOJAFODDJ(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].CCHBBGCFGON();
			this.MOALJJMJMGL(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.HLAIJDNDINA();
		}
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x00325780 File Offset: 0x00323980
	public void CPOKGEJLFEL(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.HHJKOIJGNAK() < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.OEAGLNMGGDI() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.DEFBLKPDLPM()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(85, epmphjgalbe.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe.NCKMEIBFNGL();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.EIMEKHOFIEA(this.PAIPILKFEDC);
				epmphjgalbe2.JIIKLOKAGIC(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-84, epmphjgalbe2.HDEKHFOKCKI());
			}
			finally
			{
				epmphjgalbe2.OGPGOEJFIBO();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WeaponRun", 1378f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.BILODNADPOH(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x00325940 File Offset: 0x00323B40
	private void KABLGPBGKBJ()
	{
		int num = 7;
		if (EDLNGHBMJBL.JMHOODFAGAM().AADJMFJMAGF != null)
		{
			num = EDLNGHBMJBL.FEJILBICKGG().ALCPKMFFBNE().LPFKFNLHGBI;
		}
		string text = "" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("newletter" + text + "+{0}");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError(" ");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("Low adminlevel!");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		GuiProcessor.NKOEAPCIBKO().EOPEPOJNLNF(this.MainCanvas);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-98);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(100);
		this.userRods[7].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(-79);
		base.StartCoroutine(this.CGBHIDMFIKO());
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x00325A61 File Offset: 0x00323C61
	public FRodObject HPMHBCNCIOD()
	{
		if (!this.userRods[this.selectedRod].EFGNLFFKDMI())
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A19 RID: 27161 RVA: 0x00325A86 File Offset: 0x00323C86
	public void locationBlockClick()
	{
		Debug.Log("Block");
	}

	// Token: 0x06006A1A RID: 27162 RVA: 0x00325A94 File Offset: 0x00323C94
	public void OIJMHHPDGAG(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].CCHBBGCFGON();
			this.MOALJJMJMGL(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.KOINKMHMNHG();
		}
	}

	// Token: 0x06006A1B RID: 27163 RVA: 0x00325B10 File Offset: 0x00323D10
	public void IHDDJBEGLFE()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x00022FCC File Offset: 0x000211CC
	public void HJLHKBOJMFP()
	{
	}

	// Token: 0x06006A1D RID: 27165 RVA: 0x00325B3B File Offset: 0x00323D3B
	public void OpenBaseMap()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("UI_MapWindow_b" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006A1E RID: 27166 RVA: 0x00325B78 File Offset: 0x00323D78
	public void JAKPNJHDPGA()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A1F RID: 27167 RVA: 0x00325BA4 File Offset: 0x00323DA4
	private void HDGNIHBIEDG()
	{
		int num = 8;
		if (EDLNGHBMJBL.IKGFHGKKCPG.PJBEDBENEJI() != null)
		{
			num = EDLNGHBMJBL.JMHOODFAGAM().AADJMFJMAGF.LPFKFNLHGBI;
		}
		string text = "Attached object" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("_PrefilterOffs" + text + "\n");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("and 'Result' are the same.");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("Joint_");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		GuiProcessor.NKOEAPCIBKO().EOPEPOJNLNF(this.MainCanvas);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-90);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-27);
		this.userRods[8].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-87);
		base.StartCoroutine(this.EOBPGBGLEMD());
	}

	// Token: 0x06006A20 RID: 27168 RVA: 0x00325CC8 File Offset: 0x00323EC8
	public void MOALJJMJMGL(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].OnSelect();
		this.ws.BCFOIDHNFOP(1286f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].LJNDEDHCEAL());
	}

	// Token: 0x06006A21 RID: 27169 RVA: 0x00325039 File Offset: 0x00323239
	private void FMBOCCAILBA(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A22 RID: 27170 RVA: 0x00325D44 File Offset: 0x00323F44
	private void KBMKHLDOIKP()
	{
		if (Input.GetKeyDown(KeyCode.H))
		{
			FlyMessageManager.getI.addRightMessage("Windmill", -141, 1, 0);
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			OJCFBJGEEHL.IKGFHGKKCPG.HPJFBAOGPPC(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.EPCKOOOGNGK() != null)
		{
			this.lightSky.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].EFGNLFFKDMI())
		{
			this.IANMLBJDOBD();
		}
		if (TimeController.EKEBHIJMEML() != null)
		{
			this.locImage.color = TimeController.IKGFHGKKCPG.currentAmbientColor;
		}
		bool active = false;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = true;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 1; i < this.rodButtons.Length; i += 0)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.PAGGOCBABNO(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = true;
			}
			else
			{
				this.rodButtons[i].interactable = true;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06006A23 RID: 27171 RVA: 0x00325F20 File Offset: 0x00324120
	public void WpnCellClick(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(0))
		{
			return;
		}
		if (this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 3)
		{
			this.PAIPILKFEDC = 100;
			this.IIPDNDLKOKN = 20;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[0];
			this.userRods[this.selectedRod].BGLLPMKNBCE = false;
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 350f, "Наживка", true);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - 50f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - 20f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 15f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 70f, 0);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == 10)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == 11)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.MGNDPEIFKAN();
			int dccpcblodig = 0;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.IHEILFHMLAG = dccpcblodig;
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.changeBait);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x06006A24 RID: 27172 RVA: 0x00326178 File Offset: 0x00324378
	public Vector2 AELFDALIFPB()
	{
		Vector2 vector = Input.mousePosition;
		return new Vector2(853f, 663f)
		{
			x = vector.x / (float)Screen.width,
			y = ((float)Screen.height - vector.y) / LocationGui.getI.backLockImage.rectTransform.rect.height
		};
	}

	// Token: 0x06006A25 RID: 27173 RVA: 0x003261E8 File Offset: 0x003243E8
	public Vector2 FDBIGEGKJIO()
	{
		Vector2 vector = Input.mousePosition;
		return new Vector2(534f, 818f)
		{
			x = vector.x / (float)Screen.width,
			y = ((float)Screen.height - vector.y) / LocationGui.getI.backLockImage.rectTransform.rect.height
		};
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x00326258 File Offset: 0x00324458
	public void MAMKNAHOHIK()
	{
		if (JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL)
		{
			return;
		}
		Vector2 clickLocPosition = this.getClickLocPosition();
		int num = -1;
		if (Input.GetMouseButtonUp(0))
		{
			num = 1;
		}
		if (Input.GetMouseButtonUp(0))
		{
			num = 0;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].fishPodsek();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.HBFHGKBIIBP(clickLocPosition.x, clickLocPosition.y))
				{
					this.userRods[this.selectedRod].setPosition(clickLocPosition);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[6], 1690f);
				this.userRods[this.selectedRod].BCPJHJEBBPM(true);
				return;
			}
		}
	}

	// Token: 0x06006A27 RID: 27175 RVA: 0x0032635F File Offset: 0x0032455F
	public void HICCMECABAD()
	{
		Debug.Log("invn_ver2");
	}

	// Token: 0x06006A28 RID: 27176 RVA: 0x0032636C File Offset: 0x0032456C
	public bool IMEEHCHFJME()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = true;
		if (JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A29 RID: 27177 RVA: 0x003263AC File Offset: 0x003245AC
	public bool PCCLPPDMGLA()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = true;
		if (JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y < height)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06006A2A RID: 27178 RVA: 0x003263EC File Offset: 0x003245EC
	private void OFGMIEJKMGC()
	{
		int num = 7;
		if (EDLNGHBMJBL.FEJILBICKGG().ABAABKBBLGK() != null)
		{
			num = EDLNGHBMJBL.JMHOODFAGAM().PJBEDBENEJI().LPFKFNLHGBI;
		}
		string text = "name" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("IdleStand" + text + "[LH &]");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("Skateboard Idle");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("Invalid source renderer type");
		}
		this.HJODAJPBHFE(this.locData);
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		GuiProcessor.PLGADNLAEGN().FJLPFLCJMPE(this.MainCanvas);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-105);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(63);
		this.userRods[3].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-94);
		base.StartCoroutine(this.POFOOGKIPGG());
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x00326510 File Offset: 0x00324710
	public void OALKOMILOAI(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(1))
		{
			return;
		}
		if (this.userRods[this.selectedRod].EFGNLFFKDMI() && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 6)
		{
			this.PAIPILKFEDC = -56;
			this.IIPDNDLKOKN = -118;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[0];
			this.userRods[this.selectedRod].BGLLPMKNBCE = false;
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(1120f, 768f, "turn_state", false);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - 152f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - 177f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 806f, 1347f, onkdcgnbalk.OCHCODJIPHJ.width - 328f, onkdcgnbalk.OCHCODJIPHJ.height - 451f, 0);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -40)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == 97)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.GNGINMOFEEH();
			int dccpcblodig = 0;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.AGFFDCECLBF(dccpcblodig);
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.GJADMJKLMIC);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x06006A2C RID: 27180 RVA: 0x00326768 File Offset: 0x00324968
	public void KHKGDHLLLFF(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.HHJKOIJGNAK() < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.FJNDDAMCLFL() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.LPENOBCEAPP()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.MFPECHIKBCO(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-14, epmphjgalbe.HDEKHFOKCKI());
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.JDOLCNDNFGP(this.PAIPILKFEDC);
				epmphjgalbe2.ALNEALEKFNB(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(88, epmphjgalbe2.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe2.OGPGOEJFIBO();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("_History1LumaTex", 1059f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.HGJCDOJKHHH(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A2D RID: 27181 RVA: 0x00326928 File Offset: 0x00324B28
	public void BILODNADPOH(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.OPCGMKCKKHO();
			return;
		}
		bool flag = true;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[1].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[1].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[4].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[3].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = false;
		}
		if (flag)
		{
			this.KOINKMHMNHG();
		}
	}

	// Token: 0x06006A2E RID: 27182 RVA: 0x003269A4 File Offset: 0x00324BA4
	public void LPFOLHGDDCM(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(1))
		{
			return;
		}
		if (this.userRods[this.selectedRod].EFGNLFFKDMI() && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 6)
		{
			this.PAIPILKFEDC = -66;
			this.IIPDNDLKOKN = 79;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[1];
			this.userRods[this.selectedRod].BCPJHJEBBPM(false);
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(867f, 1438f, "u_UniqueShadowTexture", false);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - 1442f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - 1088f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 1556f, 502f, onkdcgnbalk.OCHCODJIPHJ.width - 1546f, onkdcgnbalk.OCHCODJIPHJ.height - 806f, 0);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == 91)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -49)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.JKOBKMOIOGL();
			int dccpcblodig = 1;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i += 0)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.AGFFDCECLBF(dccpcblodig);
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.JCNLCEMGPIG);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x06006A2F RID: 27183 RVA: 0x00326BFC File Offset: 0x00324DFC
	public void LDCGOFNNALI(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].OnSelect();
		this.ws.HKJMHHOJNFE(1028f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x00326C78 File Offset: 0x00324E78
	public void CBJAIFIDPJI()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A31 RID: 27185 RVA: 0x00326CA4 File Offset: 0x00324EA4
	public void KOINKMHMNHG()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x00326CCF File Offset: 0x00324ECF
	private void FCMABFFDJLC()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.GICMOPPKLPC().NCCENLBOIDK();
	}

	// Token: 0x06006A33 RID: 27187 RVA: 0x00326CE4 File Offset: 0x00324EE4
	public void BLMFHFNIOGL(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.HLAIJDNDINA();
			return;
		}
		bool flag = false;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[1].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[1].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[1].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[6].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = true;
		}
		if (flag)
		{
			this.EKKMDJAOPPF();
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06006A34 RID: 27188 RVA: 0x00326D60 File Offset: 0x00324F60
	public bool PALEEIAKEGE
	{
		get
		{
			float height = this.locImage.rectTransform.rect.height;
			bool result = false;
			if (JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y < height)
			{
				result = true;
			}
			return result;
		}
	}

	// Token: 0x06006A35 RID: 27189 RVA: 0x00326DA0 File Offset: 0x00324FA0
	public void ELOGEBDFBBN(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].CCHBBGCFGON();
			this.CMAFAPEBPBI(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.PHDKGGICEJL();
		}
	}

	// Token: 0x06006A36 RID: 27190 RVA: 0x00325039 File Offset: 0x00323239
	private void HELNLEHCNBK(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x00326E1C File Offset: 0x0032501C
	public void DJOJPHPNMGF(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].CCHBBGCFGON();
			this.MOALJJMJMGL(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.OPCGMKCKKHO();
		}
	}

	// Token: 0x06006A38 RID: 27192 RVA: 0x00326E98 File Offset: 0x00325098
	private void ANHOOJFEJJE()
	{
		int num = 3;
		if (EDLNGHBMJBL.JMHOODFAGAM().ALCPKMFFBNE() != null)
		{
			num = EDLNGHBMJBL.FEJILBICKGG().ABAABKBBLGK().LPFKFNLHGBI;
		}
		string text = "SoccerKeeperDiveStrafeFarLeft" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("IceHockey Goalie Save 2" + text + "UpHillWalk");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("_Opacity");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("CrouchWalk");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		GuiProcessor.BBLINJLBAIL().EOPEPOJNLNF(this.MainCanvas);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.FJGNFCPLNNF(86);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(102);
		this.userRods[3].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-32);
		base.StartCoroutine(this.KBHCICGKANE());
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x00326FBC File Offset: 0x003251BC
	private void OLGDMBDGLAN()
	{
		if (Input.GetKeyDown((KeyCode)(-111)))
		{
			FlyMessageManager.getI.addRightMessage("GetPoints() is not applicable to IKSolverVR.", -84, 8, 1);
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].EFGNLFFKDMI())
		{
			OJCFBJGEEHL.IKGFHGKKCPG.BDEMLIANFBP(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.BOBNPEAEECC() != null)
		{
			this.lightSky.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].IBDLAMAFJNF();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			this.OPCGMKCKKHO();
		}
		if (TimeController.EPCKOOOGNGK() != null)
		{
			this.locImage.color = TimeController.EPCKOOOGNGK().currentAmbientColor;
		}
		bool active = true;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 0; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = true;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AHOONDDIPDN()
	{
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x00327198 File Offset: 0x00325398
	public void openSonar()
	{
		if (this.sonar == null)
		{
			return;
		}
		this.sonar.gameObject.SetActive(!this.sonar.gameObject.activeSelf);
	}

	// Token: 0x06006A3C RID: 27196 RVA: 0x003271CC File Offset: 0x003253CC
	public void openRod(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].onOpen();
			this.selectRod(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.clearImages();
		}
	}

	// Token: 0x06006A3D RID: 27197 RVA: 0x00327248 File Offset: 0x00325448
	private void AHOFKFMMCCI()
	{
		int num = 3;
		if (EDLNGHBMJBL.JMHOODFAGAM().ALCPKMFFBNE() != null)
		{
			num = EDLNGHBMJBL.FEJILBICKGG().PJBEDBENEJI().LPFKFNLHGBI;
		}
		string text = "CrouchWalk" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("InteractionObject Multiplier 'Curve' " + text + "-none: ");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("Mouse Y");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("1HandHeavyOverhead");
		}
		this.LNDBNGIKIAG(this.locData);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.MainCanvas);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(45);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(-3);
		this.userRods[6].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-127);
		base.StartCoroutine(this.CPKKCMPJDOA());
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x0032736C File Offset: 0x0032556C
	public void AJAKALPFNMI(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].OnSelect();
		this.ws.IDIMACNBHAI(1888f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].FOAMDFKHOHC());
	}

	// Token: 0x06006A3F RID: 27199 RVA: 0x00022FCC File Offset: 0x000211CC
	public void DJOKKJADDLM()
	{
	}

	// Token: 0x06006A40 RID: 27200 RVA: 0x003273E8 File Offset: 0x003255E8
	public void OPCGMKCKKHO()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A41 RID: 27201 RVA: 0x00327414 File Offset: 0x00325614
	public bool EBDMDMJJHGK()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = true;
		if (JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y < height)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x00327454 File Offset: 0x00325654
	public void JCNLCEMGPIG(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.HHJKOIJGNAK() < 1)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.LPENOBCEAPP() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.IHEILFHMLAG];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.AAHBHCMKGJD(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OACBICLGENB(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-140, epmphjgalbe.ALLANCHILCM());
			}
			finally
			{
				epmphjgalbe.PMIGGJHLIDO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBJBHBFAFEE(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.KPCGLGHDILI(this.PAIPILKFEDC);
				epmphjgalbe2.DEHJNGMHGAJ(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(32, epmphjgalbe2.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe2.KNPHNLLMJKJ();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("wpn_bait_vob_1", 1811f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.LGCEOHLOFOO(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A43 RID: 27203 RVA: 0x00327614 File Offset: 0x00325814
	public void EPBJPAHIGKC(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG < 1)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.DEFBLKPDLPM() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.LPENOBCEAPP()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBJBHBFAFEE(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-119, epmphjgalbe.PBOPEDMCKDD());
			}
			finally
			{
				epmphjgalbe.BKKEFKANGIM();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.PDEFLCIEMFF(this.PAIPILKFEDC);
				epmphjgalbe2.KPCGLGHDILI(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-13, epmphjgalbe2.PBOPEDMCKDD());
			}
			finally
			{
				epmphjgalbe2.OGPGOEJFIBO();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("checkPet 1", 804f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.updateImages(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A44 RID: 27204 RVA: 0x003277D4 File Offset: 0x003259D4
	private void NKHMBEDDFAJ()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.ENNAAFEOFAH().LILKJKNMCDK();
	}

	// Token: 0x06006A45 RID: 27205 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PGGGEIHOJHC()
	{
	}

	// Token: 0x06006A46 RID: 27206 RVA: 0x003277E8 File Offset: 0x003259E8
	public void AllRodsUp()
	{
		FRodObject[] array = this.userRods;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].BGLLPMKNBCE = false;
		}
	}

	// Token: 0x06006A47 RID: 27207 RVA: 0x00325039 File Offset: 0x00323239
	private void AEELILDMFJP(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A48 RID: 27208 RVA: 0x00327814 File Offset: 0x00325A14
	public void LMHGLIFDFMK(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(0))
		{
			return;
		}
		this.GFLMPAGMFJF(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.JFNOKNJFMLA(1);
			this.ws.BCFOIDHNFOP(1166f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
			this.ws.CNOAIEKIAND();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(false);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(false);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x06006A49 RID: 27209 RVA: 0x003278DC File Offset: 0x00325ADC
	public void CIKOFIJLKEG(int PPJJJAGNADB)
	{
		if (!Input.GetMouseButtonUp(0))
		{
			return;
		}
		if (this.userRods[this.selectedRod].LMCCAABKAGE() && this.userRods[this.selectedRod].otterType == 0 && PPJJJAGNADB == 7)
		{
			this.PAIPILKFEDC = -89;
			this.IIPDNDLKOKN = 65;
			this.KJCFEOPKKCP = this.userRods[this.selectedRod].rodWeapons.AMLEOGHNNPG[0];
			this.userRods[this.selectedRod].BGLLPMKNBCE = false;
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(1114f, 172f, "_Offset", true);
			onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - 458f;
			onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - 1756f - onkdcgnbalk.OCHCODJIPHJ.height;
			this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 814f, 302f, onkdcgnbalk.OCHCODJIPHJ.width - 814f, onkdcgnbalk.OCHCODJIPHJ.height - 620f, 1);
			foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PLLHGAFIAFD.Values)
			{
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -78)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
				if (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE == -26)
				{
					this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
				}
			}
			this.PHFFFJIKHNJ.GENPNFMLHED();
			int dccpcblodig = 1;
			if (this.KJCFEOPKKCP != null)
			{
				for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.KJCFEOPKKCP.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
			this.PHFFFJIKHNJ.IIBCAICFEEF(dccpcblodig);
			this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.EPBJPAHIGKC);
		}
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x06006A4A RID: 27210 RVA: 0x00327B34 File Offset: 0x00325D34
	public void HGJCDOJKHHH(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.OPCGMKCKKHO();
			return;
		}
		bool flag = true;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[1].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[0].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[2].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[5].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = true;
		}
		if (flag)
		{
			this.OPCGMKCKKHO();
		}
	}

	// Token: 0x06006A4B RID: 27211 RVA: 0x00327BB0 File Offset: 0x00325DB0
	public void BMHLJHKPMJB()
	{
		FRodObject[] array = this.userRods;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].BGLLPMKNBCE = false;
		}
	}

	// Token: 0x06006A4C RID: 27212 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EOMFJDLNLMG()
	{
	}

	// Token: 0x06006A4D RID: 27213 RVA: 0x00327BDC File Offset: 0x00325DDC
	public void FJBKLENLNJK(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].CCHBBGCFGON();
			this.MOALJJMJMGL(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.JAKPNJHDPGA();
		}
	}

	// Token: 0x06006A4E RID: 27214 RVA: 0x00327C58 File Offset: 0x00325E58
	public void GLGHCLHIJBA(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(1))
		{
			return;
		}
		this.AJAKALPFNMI(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.HGLAENGFGGO(0);
			this.ws.IDIMACNBHAI(755f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].FOAMDFKHOHC());
			this.ws.AIPEHONDCNN();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(false);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(true);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x06006A50 RID: 27216 RVA: 0x00327D3C File Offset: 0x00325F3C
	public bool HNJGFKKGOEC()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = true;
		if (JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A51 RID: 27217 RVA: 0x003256DC File Offset: 0x003238DC
	public FRodObject INBOKBPPKAB()
	{
		if (!this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A52 RID: 27218 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KJEFNMHJBAF()
	{
	}

	// Token: 0x06006A53 RID: 27219 RVA: 0x00327D7C File Offset: 0x00325F7C
	public void DIDHKCAEDMH()
	{
		if (JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG())
		{
			return;
		}
		Vector2 vector = this.AEIPMEEOMKK();
		int num = -1;
		if (Input.GetMouseButtonUp(1))
		{
			num = 1;
		}
		if (Input.GetMouseButtonUp(0))
		{
			num = 1;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].FGGMIJIOPLB();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.LOCHHHJHEBO(vector.x, vector.y))
				{
					this.userRods[this.selectedRod].setPosition(vector);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[7], 1597f);
				this.userRods[this.selectedRod].HPLDIIIFDCP(false);
				return;
			}
		}
	}

	// Token: 0x06006A54 RID: 27220 RVA: 0x00327E84 File Offset: 0x00326084
	public void HLAIJDNDINA()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A55 RID: 27221 RVA: 0x00327EB0 File Offset: 0x003260B0
	private void KOLCEBEIHKP()
	{
		if (Input.GetKeyDown((KeyCode)(-140)))
		{
			FlyMessageManager.getI.MAKLOJFMODM("NadeThrow", -85, 6, 1);
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			OJCFBJGEEHL.IKGFHGKKCPG.NFCGOKEJGNN(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.IKGFHGKKCPG != null)
		{
			this.lightSky.color = TimeController.EPCKOOOGNGK().currentAmbientColor;
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].IBDLAMAFJNF();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			this.PADDNDCJAOO();
		}
		if (TimeController.KOJCECHBHLO() != null)
		{
			this.locImage.color = TimeController.EKEBHIJMEML().currentAmbientColor;
		}
		bool active = true;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].LMCCAABKAGE() && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 1; i < this.rodButtons.Length; i++)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.PAGGOCBABNO(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = false;
			}
			else
			{
				this.rodButtons[i].interactable = false;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06006A56 RID: 27222 RVA: 0x00323B7F File Offset: 0x00321D7F
	public FRodObject PHBMPPMCEKF()
	{
		if (!this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A57 RID: 27223 RVA: 0x0032808C File Offset: 0x0032628C
	public void GENIMKNPDGB(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.FJNDDAMCLFL() < 1)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.BMOEEJCBDJO() >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.DEFBLKPDLPM()];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBJBHBFAFEE(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-136, epmphjgalbe.IEJLLFECFHF());
			}
			finally
			{
				epmphjgalbe.OGPGOEJFIBO();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OACBICLGENB(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.DEHJNGMHGAJ(this.PAIPILKFEDC);
				epmphjgalbe2.AEMAHNDEBKJ(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-115, epmphjgalbe2.ALLANCHILCM());
			}
			finally
			{
				epmphjgalbe2.HDKBMLOJLLC();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("id", 1500f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.BILODNADPOH(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A58 RID: 27224 RVA: 0x00323B23 File Offset: 0x00321D23
	private IEnumerator KBHCICGKANE()
	{
		LocationLogic.NOHHCBHCJOH nohhcbhcjoh = new LocationLogic.NOHHCBHCJOH(1);
		nohhcbhcjoh.AENJLLPLILM = this;
		return nohhcbhcjoh;
	}

	// Token: 0x06006A59 RID: 27225 RVA: 0x0032824C File Offset: 0x0032644C
	public void AJONCCLGFFJ(int HJKFEEFEDKH)
	{
		this.userRods[HJKFEEFEDKH].gameObject.SetActive(!this.userRods[HJKFEEFEDKH].gameObject.activeSelf);
		if (this.userRods[HJKFEEFEDKH].gameObject.activeSelf)
		{
			this.userRods[HJKFEEFEDKH].onOpen();
			this.NHMFEMFPMJL(HJKFEEFEDKH);
			return;
		}
		this.userRods[HJKFEEFEDKH].onClose();
		if (HJKFEEFEDKH == this.selectedRod)
		{
			this.clearImages();
		}
	}

	// Token: 0x06006A5A RID: 27226 RVA: 0x003282C8 File Offset: 0x003264C8
	public void changeBait(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.IHEILFHMLAG];
		if (this.KJCFEOPKKCP != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.KJCFEOPKKCP.LPFKFNLHGBI);
				epmphjgalbe.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(184, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			int jgniddbnggp = this.KJCFEOPKKCP.JGNIDDBNGGP;
			int dmamopgjock = this.KJCFEOPKKCP.DMAMOPGJOCK;
			this.KJCFEOPKKCP.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.KJCFEOPKKCP.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.GOMLLPFFPNP(this.PAIPILKFEDC);
				epmphjgalbe2.GOMLLPFFPNP(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(182, epmphjgalbe2.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe2.LMBPNFHKNGA();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("crunch.ogg", 1f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		this.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006A5B RID: 27227 RVA: 0x00328488 File Offset: 0x00326688
	public void NHMFEMFPMJL(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].OnSelect();
		this.ws.IDIMACNBHAI(40f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].LJNDEDHCEAL());
	}

	// Token: 0x06006A5C RID: 27228 RVA: 0x00328504 File Offset: 0x00326704
	public void GFLMPAGMFJF(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].LDPBGALNFNK();
		this.ws.ILKLIOLCMHP(195f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NFCDJLJNDLO(), this.userRods[this.selectedRod].LJNDEDHCEAL());
	}

	// Token: 0x06006A5D RID: 27229 RVA: 0x00328580 File Offset: 0x00326780
	public void GGEJBBLCLEN()
	{
		JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("_RefractTex" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006A5E RID: 27230 RVA: 0x003285BC File Offset: 0x003267BC
	public Vector2 getClickLocPosition()
	{
		Vector2 vector = Input.mousePosition;
		return new Vector2(0f, 0f)
		{
			x = vector.x / (float)Screen.width,
			y = ((float)Screen.height - vector.y) / LocationGui.getI.backLockImage.rectTransform.rect.height
		};
	}

	// Token: 0x06006A5F RID: 27231 RVA: 0x0032862B File Offset: 0x0032682B
	private IEnumerator MNPCLIHPGKN()
	{
		for (;;)
		{
			foreach (FRodObject frodObject in this.userRods)
			{
				if (!frodObject.isKlevProcess && frodObject.PFMNPEOKEKO && frodObject.BGLLPMKNBCE && frodObject.otterType == 0 && frodObject.pointer != null && frodObject.rodWeapons.AMLEOGHNNPG[0] != null)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						Vector2 pointerPosition = frodObject.getPointerPosition();
						float deep = this.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
						epmphjgalbe.GOMLLPFFPNP(frodObject.frodid);
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((double)pointerPosition.x, (double)pointerPosition.y, 0.0));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(0.0, 0.0, 0.0));
						epmphjgalbe.DLAIEEJAFDG(frodObject.baitDeep);
						epmphjgalbe.DLAIEEJAFDG(deep);
						epmphjgalbe.OBCCLNMPGEJ(frodObject.rodWeapons.AMLEOGHNNPG[0].LPFKFNLHGBI);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x06006A60 RID: 27232 RVA: 0x0032863C File Offset: 0x0032683C
	private void BIGPMMGBPJC()
	{
		if (Input.GetKeyDown((KeyCode)153))
		{
			FlyMessageManager.getI.MAKLOJFMODM("Wizard Neo Block", -69, 1, 1);
		}
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			OJCFBJGEEHL.IKGFHGKKCPG.DNEPMKLKGKG(this.userRods[this.selectedRod]);
		}
		if (this.lightSky != null && TimeController.BOBNPEAEECC() != null)
		{
			this.lightSky.color = TimeController.KOJCECHBHLO().currentAmbientColor;
		}
		if (this.selectedRod >= 1 && this.userRods[this.selectedRod].BGLLPMKNBCE && this.userRods[this.selectedRod].isFishOnRod)
		{
			this.userRods[this.selectedRod].RodProcess();
		}
		if (this.selectedRod >= 1 && !this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			this.PADDNDCJAOO();
		}
		if (TimeController.BOBNPEAEECC() != null)
		{
			this.locImage.color = TimeController.BOBNPEAEECC().currentAmbientColor;
		}
		bool active = true;
		if (this.selectedRod >= 0 && this.userRods[this.selectedRod].EFGNLFFKDMI() && this.userRods[this.selectedRod].HDEBIPPCHBK() && this.userRods[this.selectedRod].isFishOnRod)
		{
			active = false;
		}
		LocationGui.getI.rollPanel.gameObject.SetActive(active);
		for (int i = 0; i < this.rodButtons.Length; i += 0)
		{
			if (BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(i).IKKPFPJLPOL)
			{
				this.rodButtons[i].interactable = false;
			}
			else
			{
				this.rodButtons[i].interactable = true;
				this.userRods[i].onClose();
				this.userRods[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06006A61 RID: 27233 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OKDGNDGAJKE()
	{
	}

	// Token: 0x06006A62 RID: 27234 RVA: 0x00325039 File Offset: 0x00323239
	private void LNDBNGIKIAG(LocationData DNPKNDMBECP)
	{
		this.locData = DNPKNDMBECP;
		LocationGui.getI.backLockImage.sprite = DNPKNDMBECP.backGround;
	}

	// Token: 0x06006A63 RID: 27235 RVA: 0x00328818 File Offset: 0x00326A18
	public void locationClick()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return;
		}
		Vector2 clickLocPosition = this.getClickLocPosition();
		int num = -1;
		if (Input.GetMouseButtonUp(0))
		{
			num = 0;
		}
		if (Input.GetMouseButtonUp(1))
		{
			num = 1;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].fishPodsek();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.checkWater(clickLocPosition.x, clickLocPosition.y))
				{
					this.userRods[this.selectedRod].setPosition(clickLocPosition);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[3], 0.8f);
				this.userRods[this.selectedRod].BGLLPMKNBCE = false;
				return;
			}
		}
	}

	// Token: 0x06006A64 RID: 27236 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MGFINGPCODB()
	{
	}

	// Token: 0x06006A65 RID: 27237 RVA: 0x003256DC File Offset: 0x003238DC
	public FRodObject OJFGOCIGNGJ()
	{
		if (!this.userRods[this.selectedRod].PFMNPEOKEKO)
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A66 RID: 27238 RVA: 0x00328920 File Offset: 0x00326B20
	public void KEGAENIMIMB(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(0))
		{
			return;
		}
		this.CMAFAPEBPBI(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.OLNPIBLLFNH(1);
			this.ws.IDIMACNBHAI(982f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
			this.ws.ACNBPPMPGEC();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(true);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(false);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x06006A67 RID: 27239 RVA: 0x0032862B File Offset: 0x0032682B
	private IEnumerator CGBHIDMFIKO()
	{
		for (;;)
		{
			foreach (FRodObject frodObject in this.userRods)
			{
				if (!frodObject.isKlevProcess && frodObject.PFMNPEOKEKO && frodObject.BGLLPMKNBCE && frodObject.otterType == 0 && frodObject.pointer != null && frodObject.rodWeapons.AMLEOGHNNPG[0] != null)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						Vector2 pointerPosition = frodObject.getPointerPosition();
						float deep = this.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
						epmphjgalbe.GOMLLPFFPNP(frodObject.frodid);
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((double)pointerPosition.x, (double)pointerPosition.y, 0.0));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(0.0, 0.0, 0.0));
						epmphjgalbe.DLAIEEJAFDG(frodObject.baitDeep);
						epmphjgalbe.DLAIEEJAFDG(deep);
						epmphjgalbe.OBCCLNMPGEJ(frodObject.rodWeapons.AMLEOGHNNPG[0].LPFKFNLHGBI);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x06006A68 RID: 27240 RVA: 0x003289E8 File Offset: 0x00326BE8
	public bool DBPKJJHKEFB()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = true;
		if (JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A69 RID: 27241 RVA: 0x00328A28 File Offset: 0x00326C28
	private void Start()
	{
		int num = 6;
		if (EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF != null)
		{
			num = EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF.LPFKFNLHGBI;
		}
		string text = "loc_" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("Location " + text + " not found");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("ldGo not found");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("locData not found");
		}
		this.HELNLEHCNBK(this.locData);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.MainCanvas;
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(100);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(101);
		this.userRods[2].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(102);
		base.StartCoroutine(this.MNPCLIHPGKN());
	}

	// Token: 0x06006A6A RID: 27242 RVA: 0x00328B4C File Offset: 0x00326D4C
	public void HFIKBPDDOBL(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.PHDKGGICEJL();
			return;
		}
		bool flag = true;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[0].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[0].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			flag = true;
		}
		if (flag)
		{
			this.IANMLBJDOBD();
		}
	}

	// Token: 0x06006A6B RID: 27243 RVA: 0x00323B23 File Offset: 0x00321D23
	private IEnumerator EOBPGBGLEMD()
	{
		LocationLogic.NOHHCBHCJOH nohhcbhcjoh = new LocationLogic.NOHHCBHCJOH(1);
		nohhcbhcjoh.AENJLLPLILM = this;
		return nohhcbhcjoh;
	}

	// Token: 0x06006A6C RID: 27244 RVA: 0x00328BC8 File Offset: 0x00326DC8
	public void NMDLAAGEAGC(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.OPCGMKCKKHO();
			return;
		}
		bool flag = true;
		if (JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[0].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[4].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[0].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			flag = true;
		}
		if (flag)
		{
			this.PADDNDCJAOO();
		}
	}

	// Token: 0x06006A6D RID: 27245 RVA: 0x00328C44 File Offset: 0x00326E44
	private void FODDAMMNECI()
	{
		int num = 5;
		if (EDLNGHBMJBL.JMHOODFAGAM().ALCPKMFFBNE() != null)
		{
			num = EDLNGHBMJBL.IKGFHGKKCPG.ALCPKMFFBNE().LPFKFNLHGBI;
		}
		string text = "Pinky" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("ComeHere" + text + "cht_msg25");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("ObscuredFloat:");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("poplSoundIndex");
		}
		this.FMBOCCAILBA(this.locData);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		GuiProcessor.PLGADNLAEGN().CPDHMBFPGMD(this.MainCanvas);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(-59);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.DGIPCIKEJII(25);
		this.userRods[5].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(99);
		base.StartCoroutine(this.POFOOGKIPGG());
	}

	// Token: 0x06006A6E RID: 27246 RVA: 0x00328D68 File Offset: 0x00326F68
	private void KEIILPMCFEO()
	{
		int num = 2;
		if (EDLNGHBMJBL.JMHOODFAGAM().PJBEDBENEJI() != null)
		{
			num = EDLNGHBMJBL.JMHOODFAGAM().ALCPKMFFBNE().LPFKFNLHGBI;
		}
		string text = "_SharpenParameters" + num;
		GameObject gameObject = Resources.Load(text) as GameObject;
		if (gameObject == null)
		{
			Debug.LogError("act_orderb_" + text + "short:");
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
		if (gameObject2 == null)
		{
			Debug.LogError("wpn_eat5");
		}
		this.locData = gameObject2.GetComponent<LocationData>();
		if (this.locData == null)
		{
			Debug.LogError("action");
		}
		this.HJODAJPBHFE(this.locData);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		GuiProcessor.NKOEAPCIBKO().CPDHMBFPGMD(this.MainCanvas);
		this.userRods[1].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(-116);
		this.userRods[0].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.AFNBANEEFLI(50);
		this.userRods[3].rodWeapons = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(48);
		base.StartCoroutine(this.POFOOGKIPGG());
	}

	// Token: 0x06006A6F RID: 27247 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LMBMPNDBHOK()
	{
	}

	// Token: 0x06006A70 RID: 27248 RVA: 0x0032862B File Offset: 0x0032682B
	private IEnumerator EEKLDJGDLMD()
	{
		for (;;)
		{
			foreach (FRodObject frodObject in this.userRods)
			{
				if (!frodObject.isKlevProcess && frodObject.PFMNPEOKEKO && frodObject.BGLLPMKNBCE && frodObject.otterType == 0 && frodObject.pointer != null && frodObject.rodWeapons.AMLEOGHNNPG[0] != null)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						Vector2 pointerPosition = frodObject.getPointerPosition();
						float deep = this.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
						epmphjgalbe.GOMLLPFFPNP(frodObject.frodid);
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((double)pointerPosition.x, (double)pointerPosition.y, 0.0));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(0.0, 0.0, 0.0));
						epmphjgalbe.DLAIEEJAFDG(frodObject.baitDeep);
						epmphjgalbe.DLAIEEJAFDG(deep);
						epmphjgalbe.OBCCLNMPGEJ(frodObject.rodWeapons.AMLEOGHNNPG[0].LPFKFNLHGBI);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x06006A71 RID: 27249 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PPHGAFDDNGF()
	{
	}

	// Token: 0x06006A72 RID: 27250 RVA: 0x00328E8C File Offset: 0x0032708C
	public void openSettings(int NNNGBOAJFJF)
	{
		if (!Input.GetMouseButton(1))
		{
			return;
		}
		this.selectRod(NNNGBOAJFJF);
		if (this.userRods[this.selectedRod].otterType == 0)
		{
			SoundSamplesStorage.getI.playInterface(1);
			this.ws.setParamsDeep(0f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
			this.ws.updatePosition();
		}
		if (this.NAKDFCKBCEE == NNNGBOAJFJF)
		{
			this.ws.gameObject.SetActive(false);
			this.NAKDFCKBCEE = -1;
			return;
		}
		this.ws.gameObject.SetActive(true);
		this.NAKDFCKBCEE = NNNGBOAJFJF;
	}

	// Token: 0x06006A73 RID: 27251 RVA: 0x00328F54 File Offset: 0x00327154
	public void AIJBKNELLGL()
	{
		FRodObject[] array = this.userRods;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].BGLLPMKNBCE = false;
		}
	}

	// Token: 0x06006A74 RID: 27252 RVA: 0x00323B7F File Offset: 0x00321D7F
	public FRodObject MNEFEFEPLFH()
	{
		if (!this.userRods[this.selectedRod].LMCCAABKAGE())
		{
			return null;
		}
		return this.userRods[this.selectedRod];
	}

	// Token: 0x06006A75 RID: 27253 RVA: 0x0032862B File Offset: 0x0032682B
	private IEnumerator MBCMHDABJCD()
	{
		for (;;)
		{
			foreach (FRodObject frodObject in this.userRods)
			{
				if (!frodObject.isKlevProcess && frodObject.PFMNPEOKEKO && frodObject.BGLLPMKNBCE && frodObject.otterType == 0 && frodObject.pointer != null && frodObject.rodWeapons.AMLEOGHNNPG[0] != null)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						Vector2 pointerPosition = frodObject.getPointerPosition();
						float deep = this.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
						epmphjgalbe.GOMLLPFFPNP(frodObject.frodid);
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((double)pointerPosition.x, (double)pointerPosition.y, 0.0));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(0.0, 0.0, 0.0));
						epmphjgalbe.DLAIEEJAFDG(frodObject.baitDeep);
						epmphjgalbe.DLAIEEJAFDG(deep);
						epmphjgalbe.OBCCLNMPGEJ(frodObject.rodWeapons.AMLEOGHNNPG[0].LPFKFNLHGBI);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x06006A76 RID: 27254 RVA: 0x00328F80 File Offset: 0x00327180
	public void EFGDJOIFHCO()
	{
		FRodObject[] array = this.userRods;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].HPLDIIIFDCP(false);
		}
	}

	// Token: 0x06006A77 RID: 27255 RVA: 0x00022FCC File Offset: 0x000211CC
	public void KPGPOAKPPIA()
	{
	}

	// Token: 0x06006A78 RID: 27256 RVA: 0x00328FAC File Offset: 0x003271AC
	public void CMAFAPEBPBI(int HJKFEEFEDKH)
	{
		this.userRods[this.selectedRod].unSelect();
		this.selectedRod = HJKFEEFEDKH;
		this.userRods[this.selectedRod].LDPBGALNFNK();
		this.ws.ENHIHPLDILL(908f, (float)this.userRods[this.selectedRod].rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.NODLBGKEGPM, this.userRods[this.selectedRod].BICGFMMPIAI);
	}

	// Token: 0x06006A79 RID: 27257 RVA: 0x00329028 File Offset: 0x00327228
	public bool JDGFBKCIICG()
	{
		float height = this.locImage.rectTransform.rect.height;
		bool result = false;
		if (JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y < height)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006A7A RID: 27258 RVA: 0x00329068 File Offset: 0x00327268
	public void IGECADJANGM()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GGCLOKODHEG())
		{
			return;
		}
		Vector2 vector = this.FDBIGEGKJIO();
		int num = -1;
		if (Input.GetMouseButtonUp(1))
		{
			num = 0;
		}
		if (Input.GetMouseButtonUp(1))
		{
			num = 0;
		}
		if (this.userRods[this.selectedRod].gameObject.activeSelf && !this.userRods[this.selectedRod].isFishOnRod)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					return;
				}
				if (this.userRods[this.selectedRod].isFishGet)
				{
					this.userRods[this.selectedRod].fishPodsek();
					return;
				}
				this.userRods[this.selectedRod].reDrop();
			}
			else
			{
				if (this.locData.HOIHMFOGLOD(vector.x, vector.y))
				{
					this.userRods[this.selectedRod].setPosition(vector);
					return;
				}
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[2], 1175f);
				this.userRods[this.selectedRod].BGLLPMKNBCE = true;
				return;
			}
		}
	}

	// Token: 0x06006A7B RID: 27259 RVA: 0x00329170 File Offset: 0x00327370
	public void OMDHGKHOKDH()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x06006A7C RID: 27260 RVA: 0x0032919B File Offset: 0x0032739B
	private void Awake()
	{
		LocationLogic.getI = this;
		HFIINBICCLO.IKGFHGKKCPG.ODONNAANIEP();
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x00323AEF File Offset: 0x00321CEF
	public void DGFJEEOEILI()
	{
		if (this.sonar == null)
		{
			return;
		}
		this.sonar.gameObject.SetActive(this.sonar.gameObject.activeSelf);
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x0032862B File Offset: 0x0032682B
	private IEnumerator POFOOGKIPGG()
	{
		for (;;)
		{
			foreach (FRodObject frodObject in this.userRods)
			{
				if (!frodObject.isKlevProcess && frodObject.PFMNPEOKEKO && frodObject.BGLLPMKNBCE && frodObject.otterType == 0 && frodObject.pointer != null && frodObject.rodWeapons.AMLEOGHNNPG[0] != null)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						Vector2 pointerPosition = frodObject.getPointerPosition();
						float deep = this.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
						epmphjgalbe.GOMLLPFFPNP(frodObject.frodid);
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((double)pointerPosition.x, (double)pointerPosition.y, 0.0));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(0.0, 0.0, 0.0));
						epmphjgalbe.DLAIEEJAFDG(frodObject.baitDeep);
						epmphjgalbe.DLAIEEJAFDG(deep);
						epmphjgalbe.OBCCLNMPGEJ(frodObject.rodWeapons.AMLEOGHNNPG[0].LPFKFNLHGBI);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						epmphjgalbe.OBCCLNMPGEJ(0L);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x003291AD File Offset: 0x003273AD
	public void HLIEHOPOIIE()
	{
		JLFJEGIPIMM.MHFDIJGJGBJ().JOFAKNGHIAD("cht_msg40" + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x04000FAE RID: 4014
	public AudioSource audioReel;

	// Token: 0x04000FAF RID: 4015
	public AudioSource audioSpin;

	// Token: 0x04000FB0 RID: 4016
	public static LocationLogic getI;

	// Token: 0x04000FB1 RID: 4017
	public Light lightSky;

	// Token: 0x04000FB2 RID: 4018
	public ProgressBar PBar_Up;

	// Token: 0x04000FB3 RID: 4019
	public ProgressBar PBar_Down;

	// Token: 0x04000FB4 RID: 4020
	public ProgressBar PBarAdd_Up;

	// Token: 0x04000FB5 RID: 4021
	public ProgressBar PBarAdd_Down;

	// Token: 0x04000FB6 RID: 4022
	public ProgressBar PBarStamina;

	// Token: 0x04000FB7 RID: 4023
	public Sprite[] poplImages;

	// Token: 0x04000FB8 RID: 4024
	public GameObject[] pointerPrefabs;

	// Token: 0x04000FB9 RID: 4025
	public GameObject pointerFishPrefab;

	// Token: 0x04000FBA RID: 4026
	public LocationData locData;

	// Token: 0x04000FBB RID: 4027
	public FRodObject[] userRods = new FRodObject[3];

	// Token: 0x04000FBC RID: 4028
	public int selectedRod;

	// Token: 0x04000FBD RID: 4029
	public WinSettings ws;

	// Token: 0x04000FBE RID: 4030
	public RectTransform MainCanvas;

	// Token: 0x04000FBF RID: 4031
	public Button[] rodButtons;

	// Token: 0x04000FC0 RID: 4032
	public Button echoButton;

	// Token: 0x04000FC1 RID: 4033
	public Button prikormButton;

	// Token: 0x04000FC2 RID: 4034
	public RectTransform sonar;

	// Token: 0x04000FC3 RID: 4035
	public WpnImageObj[] wpnCells;

	// Token: 0x04000FC4 RID: 4036
	public Texture EmptyTexture;

	// Token: 0x04000FC5 RID: 4037
	public Image locImage;

	// Token: 0x04000FC6 RID: 4038
	private int NAKDFCKBCEE = -1;

	// Token: 0x04000FC7 RID: 4039
	private MMKFAENBHKD PHFFFJIKHNJ;

	// Token: 0x04000FC8 RID: 4040
	private EKBAPCMPANI KJCFEOPKKCP;

	// Token: 0x04000FC9 RID: 4041
	private int PAIPILKFEDC;

	// Token: 0x04000FCA RID: 4042
	private int IIPDNDLKOKN;
}
