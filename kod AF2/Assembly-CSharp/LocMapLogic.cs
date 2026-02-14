using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200017C RID: 380
public class LocMapLogic : MonoBehaviour
{
	// Token: 0x06005327 RID: 21287 RVA: 0x002717D4 File Offset: 0x0026F9D4
	private void BNKJNBIDPME()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.CEJAONGALAG();
		}
	}

	// Token: 0x06005328 RID: 21288 RVA: 0x002717E4 File Offset: 0x0026F9E4
	private void PNBGJBMJLFM()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.DOABIJJEHHN();
		}
	}

	// Token: 0x06005329 RID: 21289 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void IJOCHELLKJH()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600532A RID: 21290 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void KKCFKEDABLB()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600532B RID: 21291 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void EDGALMCHPPH()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600532C RID: 21292 RVA: 0x00271808 File Offset: 0x0026FA08
	private void CNODAIIOBMI()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId) + "_HalfResolution" + string.Format(JNBICAJIJMM.DCEBAJIILPC("IdleStrafeRight"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().IKGPJIMGAJL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.HJDHMHGBPHH();
		}
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().FCNFDLDHDDE(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600532D RID: 21293 RVA: 0x002719F4 File Offset: 0x0026FBF4
	private void LCLBDNENNFD()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.CGDPJKBODBA();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().IKGPJIMGAJL(locButton.toLocId, locButton.toPointId) + " x" + string.Format(JNBICAJIJMM.CDDCIKKDFMP("_ChromaticAberration_Amount"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.MHBMDFOHDMO(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().LJEJINKGKAK(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600532E RID: 21294 RVA: 0x00271BE0 File Offset: 0x0026FDE0
	private void AHEAOOEKNNE()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().JLDLEFLDHCM(locButton.toLocId, locButton.toPointId) + "noproff" + string.Format(JNBICAJIJMM.CDDCIKKDFMP(""), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().FCNFDLDHDDE(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600532F RID: 21295 RVA: 0x00271DC9 File Offset: 0x0026FFC9
	private void JFGGBEGNAFP()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.COELBAGFCBP();
		}
	}

	// Token: 0x06005330 RID: 21296 RVA: 0x00271DDC File Offset: 0x0026FFDC
	private void HIBOHDDGHDL()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().IGOOOILHFPL(locButton.toLocId, locButton.toPointId) + "Sexy Dance 2" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("e806f6"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.JLDLEFLDHCM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().HHOIGKJMAGP(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005331 RID: 21297 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void PNJHMJNFPLP()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005332 RID: 21298 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void MODJFGGIAHD()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005333 RID: 21299 RVA: 0x00271FC5 File Offset: 0x002701C5
	private void FJEEADNCKAG()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FCFGAJOOAFI();
		}
	}

	// Token: 0x06005334 RID: 21300 RVA: 0x00271FD8 File Offset: 0x002701D8
	private void FMANMOPBKIL()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(locButton.toLocId, locButton.toPointId) + "BowIdle" + string.Format(JNBICAJIJMM.DCEBAJIILPC(" "), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().IAODIDBLHMM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().HFDIEKGBGEN(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005335 RID: 21301 RVA: 0x002721C1 File Offset: 0x002703C1
	private void IGEICBNMPAD()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.KMNEHLPOHEO();
		}
	}

	// Token: 0x06005336 RID: 21302 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void ELFLOPJDAKK()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005337 RID: 21303 RVA: 0x002721D4 File Offset: 0x002703D4
	private void MAMGBCBBBPH()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(locButton.toLocId, locButton.toPointId) + " " + string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_um_lv"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x06005338 RID: 21304 RVA: 0x002723BD File Offset: 0x002705BD
	private void HFPPENPGGAI()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.HECBKLMOMFH();
		}
	}

	// Token: 0x06005339 RID: 21305 RVA: 0x002723D0 File Offset: 0x002705D0
	private void HHBNJMOGLAB()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().JAANDJMPILF(locButton.toLocId, locButton.toPointId) + "aptek.ogg" + string.Format(JNBICAJIJMM.CDDCIKKDFMP("MotorbikeHandstand"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().DPIHNBEBDJF(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600533A RID: 21306 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void CGFDDFHECLJ()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600533B RID: 21307 RVA: 0x002725BC File Offset: 0x002707BC
	private void FMJOLDKIIEB()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "2000" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("WalkInjured"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().JLDLEFLDHCM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().ECDAPHMNOMB(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void FGJCIEDDFGN()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600533D RID: 21309 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void EHFPLKEINFO()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void ACLJDJBJLCD()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void JLKBMEBFHBI()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void MKNPFMEMOJO()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005341 RID: 21313 RVA: 0x002727A8 File Offset: 0x002709A8
	private void GNJNCPNMFFA()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().JAANDJMPILF(locButton.toLocId, locButton.toPointId) + "offsets" + string.Format(JNBICAJIJMM.DIOJFJMOPJO(" гр "), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().KHKAOHCCPAJ(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void PNAAHEFHPCL()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x00272991 File Offset: 0x00270B91
	private void JIBKGOFOPHJ()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.DEEFIJFHLOF();
		}
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x002729A1 File Offset: 0x00270BA1
	private void LIOCDEICIFD()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.BFHKDDDFAAA();
		}
	}

	// Token: 0x06005345 RID: 21317 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void LMEJKAEIDCO()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005346 RID: 21318 RVA: 0x002729B4 File Offset: 0x00270BB4
	private void COELBAGFCBP()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId) + "Femur" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("_Rand"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().DPIHNBEBDJF(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x00272B9D File Offset: 0x00270D9D
	private void PGIHAIPCJLL()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.DPDCKKDFNKC();
		}
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x00272BB0 File Offset: 0x00270DB0
	private void HCCCNPNBFCE()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId) + "weapon" + string.Format(JNBICAJIJMM.BDKHMOOFHHK("Transform is null."), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().DPIHNBEBDJF(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005349 RID: 21321 RVA: 0x002723BD File Offset: 0x002705BD
	private void LBOONMDONCF()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.HECBKLMOMFH();
		}
	}

	// Token: 0x0600534A RID: 21322 RVA: 0x00272D9C File Offset: 0x00270F9C
	private void DEEFIJFHLOF()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.CGDPJKBODBA();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().JLDLEFLDHCM(locButton.toLocId, locButton.toPointId) + "_Jitter" + string.Format(JNBICAJIJMM.DCEBAJIILPC("RollerBladeRoll"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().JAANDJMPILF(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600534B RID: 21323 RVA: 0x00272F85 File Offset: 0x00271185
	private void DFFOEGHGPGP()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.EHDNDEAMBPF();
		}
	}

	// Token: 0x0600534C RID: 21324 RVA: 0x00272F95 File Offset: 0x00271195
	private void HONIFOPBBKC()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.MAMGBCBBBPH();
		}
	}

	// Token: 0x0600534D RID: 21325 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void FCCAIANLEFE()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600534E RID: 21326 RVA: 0x00272FA8 File Offset: 0x002711A8
	private void HECBKLMOMFH()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + " ♦ " + string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().ECDAPHMNOMB(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x00273191 File Offset: 0x00271391
	private void JMNNAPNJDNK()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.CNODAIIOBMI();
		}
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x002723BD File Offset: 0x002705BD
	private void LBGKAMLLACN()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.HECBKLMOMFH();
		}
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x002731A1 File Offset: 0x002713A1
	private void LFJHDHPJOPE()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.HDMMDIOKIMH();
		}
	}

	// Token: 0x06005352 RID: 21330 RVA: 0x002731B4 File Offset: 0x002713B4
	private void JNLDKPOKBHC()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId) + "UpHillWalk" + string.Format(JNBICAJIJMM.CDDCIKKDFMP("===== ObscuredStringTest =====\n"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().IAODIDBLHMM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().HHOIGKJMAGP(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x06005353 RID: 21331 RVA: 0x0027339D File Offset: 0x0027159D
	private void LMMDHJJJNJO()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.BHEAOFBCJID();
		}
	}

	// Token: 0x06005354 RID: 21332 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void BHFMGBNIAMC()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void IIKDDILLGLF()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void GGBMJFNGHMC()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x002733B0 File Offset: 0x002715B0
	private void BNLCAMGLHEL()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "LocationGui.getI.backLockImage is null" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("WindZone"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().DPIHNBEBDJF(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void CGMHGDEKDEP()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x00271FC5 File Offset: 0x002701C5
	private void HMLNMHOMMNO()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FCFGAJOOAFI();
		}
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x0027359C File Offset: 0x0027179C
	private void EHDNDEAMBPF()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.LIPNKJMOKLI(locButton.toLocId, locButton.toPointId) + "reputaion/levels/replevels" + string.Format(JNBICAJIJMM.LEBHCLDODNI("_r_"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().IAODIDBLHMM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().KIBGNDMNMNO(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void KFGKKLAKFGH()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x00273785 File Offset: 0x00271985
	private void CBBLGEDCJBF()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.LKDHHDDFHDE();
		}
	}

	// Token: 0x0600535E RID: 21342 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void BGCLAKJHAFK()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void INDGOHJGCFN()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005360 RID: 21344 RVA: 0x002717D4 File Offset: 0x0026F9D4
	private void NMMGHFDLNOE()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.CEJAONGALAG();
		}
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void HDGNIHBIEDG()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005362 RID: 21346 RVA: 0x00273795 File Offset: 0x00271995
	private void PAKOHKKBKHD()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FMJOLDKIIEB();
		}
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void JCELICPHGEP()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void BFBBJILCKAK()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x002737A8 File Offset: 0x002719A8
	private void LKDHHDDFHDE()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IKGFHGKKCPG.MHBMDFOHDMO(locButton.toLocId, locButton.toPointId) + "" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("_TempRT"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().JDMOHJGPKIC(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void FFIGGPHAIBP()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x00273994 File Offset: 0x00271B94
	private void KMNEHLPOHEO()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().CGDPJKBODBA();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().IKGPJIMGAJL(locButton.toLocId, locButton.toPointId) + "_Transparency" + string.Format(JNBICAJIJMM.PPNKMDJBMLP("***** Export OK"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().JAANDJMPILF(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().HFDIEKGBGEN(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x00273B80 File Offset: 0x00271D80
	private void BHEAOFBCJID()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().CGDPJKBODBA();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId) + "Clavicle" + string.Format(JNBICAJIJMM.LEBHCLDODNI("1HandSwordJabCombo"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().JDMOHJGPKIC(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x002723BD File Offset: 0x002705BD
	private void GCNGEFBKMNC()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.HECBKLMOMFH();
		}
	}

	// Token: 0x0600536A RID: 21354 RVA: 0x0027339D File Offset: 0x0027159D
	private void DEGCCLNOEKJ()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.BHEAOFBCJID();
		}
	}

	// Token: 0x0600536B RID: 21355 RVA: 0x00273D6C File Offset: 0x00271F6C
	private void ONCLANLEOCG()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "Roller Blade Turn Left" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("Giant3HitCombo"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().KIBGNDMNMNO(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x0600536C RID: 21356 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void KGICJDGIIJK()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600536D RID: 21357 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void Start()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600536E RID: 21358 RVA: 0x00273F58 File Offset: 0x00272158
	private void FCFGAJOOAFI()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "auk_wmin" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("wpn_add/base"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().LIPNKJMOKLI(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().HHOIGKJMAGP(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x0600536F RID: 21359 RVA: 0x00274141 File Offset: 0x00272341
	private void AKLFCMNCPKL()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.ECCJLFNOLLM();
		}
	}

	// Token: 0x06005370 RID: 21360 RVA: 0x00273191 File Offset: 0x00271391
	private void INKGAFANFIB()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.CNODAIIOBMI();
		}
	}

	// Token: 0x06005371 RID: 21361 RVA: 0x00272F95 File Offset: 0x00271195
	private void Update()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.MAMGBCBBBPH();
		}
	}

	// Token: 0x06005372 RID: 21362 RVA: 0x00274154 File Offset: 0x00272354
	private void BFHKDDDFAAA()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().KFDGOOIPOFN();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "Flap_08.wav" + string.Format(JNBICAJIJMM.DIOJFJMOPJO("_PrevViewProj"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().JAANDJMPILF(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.HJDHMHGBPHH();
		}
		foreach (LocButton locButton2 in this.locations)
		{
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().KHKAOHCCPAJ(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x06005373 RID: 21363 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void GIADAJFBIOP()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005374 RID: 21364 RVA: 0x00274340 File Offset: 0x00272540
	private void HDMMDIOKIMH()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.IKGFHGKKCPG.JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.IMLLGEMPHAP().IKGPJIMGAJL(locButton.toLocId, locButton.toPointId) + "<size=14><color='#00d0ff'>{0}</color></size>" + string.Format(JNBICAJIJMM.PGJCPFNJNPM(""), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().IGOOOILHFPL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.HJDHMHGBPHH();
		}
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().JDMOHJGPKIC(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005375 RID: 21365 RVA: 0x00274529 File Offset: 0x00272729
	private void DIAIKCBANBK()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.JNLDKPOKBHC();
		}
	}

	// Token: 0x06005376 RID: 21366 RVA: 0x00272F85 File Offset: 0x00271185
	private void IEOICHPKEMD()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.EHDNDEAMBPF();
		}
	}

	// Token: 0x06005377 RID: 21367 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void EFJDBBDMPMC()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005378 RID: 21368 RVA: 0x00274529 File Offset: 0x00272729
	private void FOHLAIIMNFB()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.JNLDKPOKBHC();
		}
	}

	// Token: 0x06005379 RID: 21369 RVA: 0x00271FC5 File Offset: 0x002701C5
	private void IANJLHIIGLN()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FCFGAJOOAFI();
		}
	}

	// Token: 0x0600537A RID: 21370 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void DDEBDCGNCPC()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600537B RID: 21371 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void GHCMIKGJPJD()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600537C RID: 21372 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void ECMAANIDEBA()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600537D RID: 21373 RVA: 0x00274539 File Offset: 0x00272739
	private void DKOIOBMMAGN()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.ONCLANLEOCG();
		}
	}

	// Token: 0x0600537E RID: 21374 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void DPPAAIJCFLC()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x0027454C File Offset: 0x0027274C
	private void CEJAONGALAG()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId) + "Circular parenting. " + string.Format(JNBICAJIJMM.LEBHCLDODNI("Crouch180"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().IKGPJIMGAJL(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.getDstSpawnPoint();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().KIBGNDMNMNO(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x00272F85 File Offset: 0x00271185
	private void GPCKACGEILI()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.EHDNDEAMBPF();
		}
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void CHDJGEOFHEE()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x00272B9D File Offset: 0x00270D9D
	private void PMKOAHMNBBG()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.DPDCKKDFNKC();
		}
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void NOKJMMDMJNO()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void FIJKDFIMELM()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x00274738 File Offset: 0x00272938
	private void DPDCKKDFNKC()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().JLDLEFLDHCM(locButton.toLocId, locButton.toPointId) + "Windmill" + string.Format(JNBICAJIJMM.NGALDMFKMJH("______________________________"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EDKGBBIIBBC().JAANDJMPILF(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i++)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.DBMJJPBOPEK().DPIHNBEBDJF(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void EHDPACPIBNF()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x00271FC5 File Offset: 0x002701C5
	private void JIFOELPAEHG()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FCFGAJOOAFI();
		}
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void OBJCOJEHLBE()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x002717F4 File Offset: 0x0026F9F4
	private void DNLFEOECBKI()
	{
		this.markerTrans = this.marker.GetComponent<RectTransform>();
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x00274924 File Offset: 0x00272B24
	private void ECCJLFNOLLM()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.JMHOODFAGAM().IGDHIPGLIEA;
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		foreach (LocButton locButton in this.locations)
		{
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + "MotorbikeLassoBack" + string.Format(JNBICAJIJMM.DCEBAJIILPC(""), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.EKEBHIJMEML().IAODIDBLHMM(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = true;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 1;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.HJDHMHGBPHH();
		}
		LocButton[] array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.EEOPOHEALPK().ECDAPHMNOMB(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = true;
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x00274B10 File Offset: 0x00272D10
	private void DOABIJJEHHN()
	{
		EDLNGHBMJBL.LKDIADGGOLN lkdiadggoln = EDLNGHBMJBL.FEJILBICKGG().JBANCCFMOCE();
		if (lkdiadggoln == null)
		{
			return;
		}
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		LocButton[] array = this.locations;
		for (int i = 0; i < array.Length; i += 0)
		{
			LocButton locButton = array[i];
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.locName.text = JNBICAJIJMM.CLIMNFDGOEG().IAODIDBLHMM(locButton.toLocId, locButton.toPointId) + " гр " + string.Format(JNBICAJIJMM.DCEBAJIILPC("Textures/Bases/"), locButton.minimalLevel);
			}
			else
			{
				locButton.locName.text = JNBICAJIJMM.APMJBBDBOJO().MHBMDFOHDMO(locButton.toLocId, locButton.toPointId);
			}
			if (locButton.toLocId == kfhelhglnmh.HDELGEDDDCE)
			{
				RectTransform component = locButton.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component.position;
			}
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE) < locButton.minimalLevel)
			{
				locButton.btn.interactable = false;
				locButton.locName.color = Color.gray;
			}
		}
		int num = 0;
		if (LocNewLogic.getI != null)
		{
			num = LocNewLogic.getI.BIGNCFOAKGC();
		}
		array = this.locations;
		for (int i = 1; i < array.Length; i += 0)
		{
			LocButton locButton2 = array[i];
			if (locButton2.toLocId == kfhelhglnmh.HDELGEDDDCE && num == locButton2.toPointId)
			{
				RectTransform component2 = locButton2.gameObject.GetComponent<RectTransform>();
				this.markerTrans.position = component2.position;
			}
		}
		if (this.baseButton != null)
		{
			this.baseButton.locName.text = JNBICAJIJMM.LPHMKPDBMPP().LJEJINKGKAK(lkdiadggoln.LPFKFNLHGBI);
		}
		this.JCLKCGBFJHG = false;
	}

	// Token: 0x0600538C RID: 21388 RVA: 0x00274CF9 File Offset: 0x00272EF9
	private void BOAJJAKEMLH()
	{
		if (!this.JCLKCGBFJHG)
		{
			this.FMANMOPBKIL();
		}
	}

	// Token: 0x04000CB1 RID: 3249
	public Image marker;

	// Token: 0x04000CB2 RID: 3250
	public LocButton baseButton;

	// Token: 0x04000CB3 RID: 3251
	public LocButton[] locations;

	// Token: 0x04000CB4 RID: 3252
	private bool JCLKCGBFJHG;

	// Token: 0x04000CB5 RID: 3253
	public RectTransform markerTrans;
}
