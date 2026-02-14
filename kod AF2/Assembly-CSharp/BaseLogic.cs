using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001C7 RID: 455
public class BaseLogic : MonoBehaviour
{
	// Token: 0x060066CC RID: 26316 RVA: 0x00302313 File Offset: 0x00300513
	public void BDPDCGKFKHB()
	{
		JLFJEGIPIMM.PKGMBFEMKGP().JOFAKNGHIAD("_EMISSION" + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066CD RID: 26317 RVA: 0x0030234E File Offset: 0x0030054E
	private void HKGCKLBHNPJ()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066CE RID: 26318 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IANJLHIIGLN()
	{
	}

	// Token: 0x060066CF RID: 26319 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLFBDOPFDDJ()
	{
	}

	// Token: 0x060066D0 RID: 26320 RVA: 0x0030234E File Offset: 0x0030054E
	private void PBADPBBJBEJ()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066D1 RID: 26321 RVA: 0x00302356 File Offset: 0x00300556
	public void OpenBaseMap()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("UI_MapWindow_b" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066D2 RID: 26322 RVA: 0x00302391 File Offset: 0x00300591
	public void AEEMOCLKDIG()
	{
		JLFJEGIPIMM.NNEAHAFBOHC().JOFAKNGHIAD("XL" + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066D3 RID: 26323 RVA: 0x003023CC File Offset: 0x003005CC
	public void OMKKMFEHCOE()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("_BokehParams" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066D4 RID: 26324 RVA: 0x00302407 File Offset: 0x00300607
	private void AOLBGAGHJDO()
	{
		BaseLogic.getI = this;
		TimeController.EKEBHIJMEML().JPDHJMIIFEA(null, this.shine);
		TimeController.IKGFHGKKCPG.isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066D5 RID: 26325 RVA: 0x00302430 File Offset: 0x00300630
	public void FNIGCGNPGMI(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.AEIIBNOFLCM();
	}

	// Token: 0x060066D6 RID: 26326 RVA: 0x00302444 File Offset: 0x00300644
	private void FGJCIEDDFGN()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.LIOPCJFCGAF() + string.Format("WeaponRunBackward", num);
		string hojhbmnihba = "OfficeSittingLegCross";
		byte[] array = null;
		if (JBEHMPDDMME.JKIFIBEPICO() != null && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "error.wav";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().IDKKGIPKIHH(530f), 800f, OLPINJLCKCI.NLOGJHEFMHM().CCGBPEKJKOF(1838f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.initShadowsParams(array);
			}
			JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.GJACINHCABC().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.EDKKJNHDBPF().reservPosition;
				this.user.transform.rotation = LocBaseManager.IKGFHGKKCPG.reservRotation;
				LocBaseManager.CHFPAOGEMEM().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.KHCGEDMOGNP();
		}
	}

	// Token: 0x060066D7 RID: 26327 RVA: 0x0030234E File Offset: 0x0030054E
	private void KIEFPGLDOCD()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066D8 RID: 26328 RVA: 0x0030266A File Offset: 0x0030086A
	public void MPAFPDPBNBM()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII("Wrist" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066D9 RID: 26329 RVA: 0x003026A5 File Offset: 0x003008A5
	public void AKNDDNNMGAJ()
	{
		JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("Move around with WASD keys. Press C to enable free look camera" + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066DA RID: 26330 RVA: 0x003026E0 File Offset: 0x003008E0
	public void KBMADJFBJLD(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.LECMGDEDAKF();
	}

	// Token: 0x060066DB RID: 26331 RVA: 0x0030234E File Offset: 0x0030054E
	private void ENCHIIJEJDL()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066DC RID: 26332 RVA: 0x003026F3 File Offset: 0x003008F3
	public void MCNPNMNNDCJ()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("_man" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066DD RID: 26333 RVA: 0x0030272E File Offset: 0x0030092E
	public void PALHPFCLCLJ()
	{
		JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC("PaperTurn.wav" + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066DE RID: 26334 RVA: 0x0030234E File Offset: 0x0030054E
	private void DCHAPIHINBJ()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066DF RID: 26335 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMPEBHIPKJH()
	{
	}

	// Token: 0x060066E0 RID: 26336 RVA: 0x0030276C File Offset: 0x0030096C
	private void PFNPOHMMJDN()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.NKOEAPCIBKO().EOPEPOJNLNF(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.NEJIPLDOMMC() + string.Format("val", num);
		string hojhbmnihba = ")";
		byte[] array = null;
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "1HSwordStrafeRunLeft";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().IDKKGIPKIHH(621f), 352f, OLPINJLCKCI.IKGFHGKKCPG.FOFGPFKPLJL(1457f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.FKEHLGHNELK(array);
			}
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.CHFPAOGEMEM().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPIEJELJPIM().reservPosition;
				this.user.transform.rotation = LocBaseManager.AIHINNHNNIA().reservRotation;
				LocBaseManager.CHFPAOGEMEM().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.HGFJJFPMMKA();
		}
	}

	// Token: 0x060066E1 RID: 26337 RVA: 0x00302992 File Offset: 0x00300B92
	public void GLODOMMPJAK(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.DPBCBCLJHAJ();
	}

	// Token: 0x060066E2 RID: 26338 RVA: 0x003029A8 File Offset: 0x00300BA8
	private void CKGPEFOKKNL()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.LIOPCJFCGAF() + string.Format("Keeper Strafe Dive Close Right", num);
		string hojhbmnihba = "Модификация предмета";
		byte[] array = null;
		if (JBEHMPDDMME.EAJHPOJPPFA() != null && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "_VignetteSettings";
			}
			array = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().FOFGPFKPLJL(1689f), 1432f, OLPINJLCKCI.NLOGJHEFMHM().CAJEBHILIGM(152f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DAJFMBBDJIC(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.NCAMDBAJGOD(array);
			}
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.EDCNMAAMCAB(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.NPCAKEGNBHD().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPCAKEGNBHD().reservPosition;
				this.user.transform.rotation = LocBaseManager.EDKKJNHDBPF().reservRotation;
				LocBaseManager.AIHINNHNNIA().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.GMOFOPHNFBG();
		}
	}

	// Token: 0x060066E3 RID: 26339 RVA: 0x0030234E File Offset: 0x0030054E
	private void GKFOFOCGPCC()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060066E4 RID: 26340 RVA: 0x00302BD0 File Offset: 0x00300DD0
	private void EDGALMCHPPH()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.NKOEAPCIBKO().BJBJKLMJLCA = this.MainCanvas;
		}
		int num = 1;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.ACOEIDGDLJC() + string.Format("The InteractionTrigger in the list 'inContact' has been destroyed", num);
		string hojhbmnihba = "IdleDrink";
		byte[] array = null;
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "lash";
			}
			array = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().CCGBPEKJKOF(381f), 1355f, OLPINJLCKCI.NLOGJHEFMHM().OOAHONKIACK(1426f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().LMFEHHFPAAA(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.ILHFOHFHOLK(array);
			}
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.ONDOHGBIDHO(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.IKGFHGKKCPG.isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.IKGFHGKKCPG.reservPosition;
				this.user.transform.rotation = LocBaseManager.FJLCHDGLMMK().reservRotation;
				LocBaseManager.EDKKJNHDBPF().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.HENOJAIMPFI();
		}
	}

	// Token: 0x060066E5 RID: 26341 RVA: 0x00302DF6 File Offset: 0x00300FF6
	private void HKLPGCKJEJK()
	{
		BaseLogic.getI = this;
		TimeController.KOJCECHBHLO().startNewScene(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066E6 RID: 26342 RVA: 0x00302E20 File Offset: 0x00301020
	private void JCELICPHGEP()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.PLGADNLAEGN().CPDHMBFPGMD(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.LCEBBHPKOHO() + string.Format("WATER_VERTEX_DISPLACEMENT_OFF", num);
		string hojhbmnihba = "Worker Hammer";
		byte[] array = null;
		if (JBEHMPDDMME.PLGADNLAEGN() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "_OcclusionTexture";
			}
			array = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.BMALMDIBLDP().NAHGKAPMKKL(1442f), 768f, OLPINJLCKCI.NPIEJELJPIM().FOFGPFKPLJL(1130f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.BOOCBLKDAPP(array);
			}
			JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.AIHINNHNNIA().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.GJACINHCABC().reservPosition;
				this.user.transform.rotation = LocBaseManager.GJACINHCABC().reservRotation;
				LocBaseManager.GJACINHCABC().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.HENOJAIMPFI();
		}
	}

	// Token: 0x060066E7 RID: 26343 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IDMCOLDDNCF()
	{
	}

	// Token: 0x060066E8 RID: 26344 RVA: 0x00303046 File Offset: 0x00301246
	private void LHHFHDNBKKC()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().JPDHJMIIFEA(null, this.shine);
		TimeController.BOBNPEAEECC().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066E9 RID: 26345 RVA: 0x0030306F File Offset: 0x0030126F
	private void JMNLEBAPHNJ()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().HPCJDECDCEF(null, this.shine);
		TimeController.IKGFHGKKCPG.isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066EA RID: 26346 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMMDHJJJNJO()
	{
	}

	// Token: 0x060066EB RID: 26347 RVA: 0x00303098 File Offset: 0x00301298
	private void PFKOLCOAPCN()
	{
		BaseLogic.getI = this;
		TimeController.IKGFHGKKCPG.startNewScene(null, this.shine);
		TimeController.IKGFHGKKCPG.isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066EC RID: 26348 RVA: 0x003030C4 File Offset: 0x003012C4
	private void NCALLFHEAGJ()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.IKGFHGKKCPG.FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.ENLHJOJICDG() + string.Format("titul_data/p_categories/category", num);
		string hojhbmnihba = "SoccerWalk";
		byte[] array = null;
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "shop_t6";
			}
			array = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().OOAHONKIACK(1939f), 1181f, OLPINJLCKCI.ODDOIHEPICE().OOAHONKIACK(1821f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.HCBMGCJMCBG(array);
			}
			JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.NPCAKEGNBHD().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.GJACINHCABC().reservPosition;
				this.user.transform.rotation = LocBaseManager.IKGFHGKKCPG.reservRotation;
				LocBaseManager.NPIEJELJPIM().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.KHCGEDMOGNP();
		}
	}

	// Token: 0x060066ED RID: 26349 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PJHEGHHOJHJ()
	{
	}

	// Token: 0x060066EE RID: 26350 RVA: 0x003032EA File Offset: 0x003014EA
	public void CHMDINOCBCL(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.HONJOFFBOPH();
	}

	// Token: 0x060066EF RID: 26351 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060066F0 RID: 26352 RVA: 0x003032FD File Offset: 0x003014FD
	private void DIENOIPCCDE()
	{
		BaseLogic.getI = this;
		TimeController.IKGFHGKKCPG.GLEHJCIFJLG(null, this.shine);
		TimeController.EKEBHIJMEML().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066F1 RID: 26353 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FPLNDDMFFKG()
	{
	}

	// Token: 0x060066F2 RID: 26354 RVA: 0x00303326 File Offset: 0x00301526
	private void BLDELNFCEGB()
	{
		BaseLogic.getI = this;
		TimeController.EPCKOOOGNGK().HPCJDECDCEF(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066F3 RID: 26355 RVA: 0x00303350 File Offset: 0x00301550
	private void DHJDMKLBLEF()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.PLGADNLAEGN().FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.EHCJCCILAHM() + string.Format("MotorbikeIdle", num);
		string hojhbmnihba = "Flares";
		byte[] array = null;
		if (JBEHMPDDMME.BPPFAOOCENN() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "Health bar after few usual operations: ";
			}
			array = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.NPIEJELJPIM().FOFGPFKPLJL(1480f), 1052f, OLPINJLCKCI.ODDOIHEPICE().HKJEALHLOLJ(1202f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().JOFAKNGHIAD(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.initShadowsParams(array);
			}
			JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GIDJODKDJGD();
			this.user.EDCNMAAMCAB(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.FJLCHDGLMMK().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPCAKEGNBHD().reservPosition;
				this.user.transform.rotation = LocBaseManager.FJLCHDGLMMK().reservRotation;
				LocBaseManager.GJACINHCABC().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.PINNILCPMAJ();
		}
	}

	// Token: 0x060066F4 RID: 26356 RVA: 0x00303576 File Offset: 0x00301776
	public void CEAPEJBPJII()
	{
		JLFJEGIPIMM.MHFDIJGJGBJ().LMFEHHFPAAA("ANTI_FLICKER" + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066F5 RID: 26357 RVA: 0x003035B4 File Offset: 0x003017B4
	private void DMAOHJDKMNN()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.BBLINJLBAIL().EOPEPOJNLNF(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.EEAKGGDJAGB() + string.Format("1HandSwordChargeSwipe", num);
		string hojhbmnihba = "crft_from";
		byte[] array = null;
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "post_8";
			}
			array = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.NPIEJELJPIM().KKNHLLIFDFJ(1841f), 1908f, OLPINJLCKCI.BMALMDIBLDP().NAHGKAPMKKL(432f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.CEGKIIDPPEK(array);
			}
			JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.CHFPAOGEMEM().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPCAKEGNBHD().reservPosition;
				this.user.transform.rotation = LocBaseManager.FJLCHDGLMMK().reservRotation;
				LocBaseManager.FJLCHDGLMMK().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.BEKJEAEGDLD();
		}
	}

	// Token: 0x060066F6 RID: 26358 RVA: 0x003037DA File Offset: 0x003019DA
	public void PHDHCEPAABB(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.IOHNCGLFGDJ();
	}

	// Token: 0x060066F7 RID: 26359 RVA: 0x003037F0 File Offset: 0x003019F0
	private void BBFPILBIMKC()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.IKGFHGKKCPG.AMFFCIKGJKJ(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.DIDFMAELMJD + string.Format(" on effect ", num);
		string hojhbmnihba = "WorkerHammer2";
		byte[] array = null;
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "";
			}
			array = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().CAJEBHILIGM(123f), 54f, OLPINJLCKCI.IFLFANPMLMM().IDKKGIPKIHH(1161f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.CEGKIIDPPEK(array);
			}
			JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GIDJODKDJGD();
			this.user.GACMMMGCLNC(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.IKGFHGKKCPG.isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.GJACINHCABC().reservPosition;
				this.user.transform.rotation = LocBaseManager.GJACINHCABC().reservRotation;
				LocBaseManager.IKGFHGKKCPG.isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.BEKJEAEGDLD();
		}
	}

	// Token: 0x060066F8 RID: 26360 RVA: 0x00303A16 File Offset: 0x00301C16
	private void PFFMPHLHMIP()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().OAOAILNFJNL(null, this.shine);
		TimeController.IKGFHGKKCPG.isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066F9 RID: 26361 RVA: 0x00303A40 File Offset: 0x00301C40
	private void BGCLAKJHAFK()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.PLGADNLAEGN().BJBJKLMJLCA = this.MainCanvas;
		}
		int num = 0;
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.NEJIPLDOMMC() + string.Format(".unity3d", num);
		string hojhbmnihba = "autherror";
		byte[] array = null;
		if (JBEHMPDDMME.JKIFIBEPICO() != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "1024";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.IKGFHGKKCPG.CCGBPEKJKOF(752f), 1886f, OLPINJLCKCI.IKGFHGKKCPG.FJFNKMAEPMP(362f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().JOFAKNGHIAD(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.ILHFOHFHOLK(array);
			}
			JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.ONDOHGBIDHO(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.CHFPAOGEMEM().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.EDKKJNHDBPF().reservPosition;
				this.user.transform.rotation = LocBaseManager.EDKKJNHDBPF().reservRotation;
				LocBaseManager.FJLCHDGLMMK().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.FONCCBDBFLI();
		}
	}

	// Token: 0x060066FA RID: 26362 RVA: 0x00303C66 File Offset: 0x00301E66
	private void EEININLNBKJ()
	{
		BaseLogic.getI = this;
		TimeController.IKGFHGKKCPG.OAOAILNFJNL(null, this.shine);
		TimeController.BOBNPEAEECC().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066FB RID: 26363 RVA: 0x00303C8F File Offset: 0x00301E8F
	public void CLICEAIADNK()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.JOFAKNGHIAD("isFishGet" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x060066FC RID: 26364 RVA: 0x00303CCC File Offset: 0x00301ECC
	private void DNLFEOECBKI()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.MainCanvas;
		}
		int num = 1;
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.ENLHJOJICDG() + string.Format("UpHillWalk", num);
		string hojhbmnihba = "gi_um_mx";
		byte[] array = null;
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "ClimbUp";
			}
			array = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.NLOGJHEFMHM().HKJEALHLOLJ(1109f), 1826f, OLPINJLCKCI.NPIEJELJPIM().KKNHLLIFDFJ(306f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.PJGINJMFGDK(array);
			}
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.AIHINNHNNIA().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.AIHINNHNNIA().reservPosition;
				this.user.transform.rotation = LocBaseManager.FJLCHDGLMMK().reservRotation;
				LocBaseManager.NPIEJELJPIM().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.applyEffect();
		}
	}

	// Token: 0x060066FD RID: 26365 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EKCKBDKEAKO()
	{
	}

	// Token: 0x060066FE RID: 26366 RVA: 0x00303EF2 File Offset: 0x003020F2
	private void NKHMBEDDFAJ()
	{
		BaseLogic.getI = this;
		TimeController.EPCKOOOGNGK().startNewScene(null, this.shine);
		TimeController.EKEBHIJMEML().isActive = this.isTimeManagerActive;
	}

	// Token: 0x060066FF RID: 26367 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x06006700 RID: 26368 RVA: 0x00303F1B File Offset: 0x0030211B
	public void AMEHIDAIONG(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.PFFJJEJNKPB();
	}

	// Token: 0x06006701 RID: 26369 RVA: 0x00303F2E File Offset: 0x0030212E
	public void NBEJIMAPIDA(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.EIMNFFAAHLI();
	}

	// Token: 0x06006702 RID: 26370 RVA: 0x00303F2E File Offset: 0x0030212E
	public void BOHJGNCKEFC(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.EIMNFFAAHLI();
	}

	// Token: 0x06006703 RID: 26371 RVA: 0x00303F41 File Offset: 0x00302141
	public void OOJJNALAOEE(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.NIOGJOFLPLH();
	}

	// Token: 0x06006704 RID: 26372 RVA: 0x00303F54 File Offset: 0x00302154
	private void FJGIBCHABIG()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.IKGFHGKKCPG.EOPEPOJNLNF(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.EEAKGGDJAGB() + string.Format("FlyUp", num);
		string hojhbmnihba = "RollerBlade";
		byte[] array = null;
		if (JBEHMPDDMME.BPPFAOOCENN() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "IdleStand";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.OBDBAABBAKB().FJFNKMAEPMP(1650f), 1461f, OLPINJLCKCI.NLOGJHEFMHM().KKNHLLIFDFJ(1916f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.EJGLDLFLLPG(array);
			}
			JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GIDJODKDJGD();
			this.user.EDCNMAAMCAB(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.GJACINHCABC().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPIEJELJPIM().reservPosition;
				this.user.transform.rotation = LocBaseManager.NPCAKEGNBHD().reservRotation;
				LocBaseManager.EDKKJNHDBPF().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.applyEffect();
		}
	}

	// Token: 0x06006705 RID: 26373 RVA: 0x0030234E File Offset: 0x0030054E
	private void BHALJCJOPGD()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06006706 RID: 26374 RVA: 0x00303098 File Offset: 0x00301298
	private void Awake()
	{
		BaseLogic.getI = this;
		TimeController.IKGFHGKKCPG.startNewScene(null, this.shine);
		TimeController.IKGFHGKKCPG.isActive = this.isTimeManagerActive;
	}

	// Token: 0x06006707 RID: 26375 RVA: 0x0030417A File Offset: 0x0030237A
	private void LBKPJAJJLBH()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().OAOAILNFJNL(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x06006708 RID: 26376 RVA: 0x003041A3 File Offset: 0x003023A3
	public void FBOPEKJBPHL(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.IOMNHBMOGLG();
	}

	// Token: 0x06006709 RID: 26377 RVA: 0x0030234E File Offset: 0x0030054E
	private void HCCGBDPCEKO()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x0600670A RID: 26378 RVA: 0x003041B6 File Offset: 0x003023B6
	private void GDMEEIBDKLP()
	{
		BaseLogic.getI = this;
		TimeController.IKGFHGKKCPG.OAOAILNFJNL(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x0600670B RID: 26379 RVA: 0x003041DF File Offset: 0x003023DF
	private void NLMBBNDHPLJ()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().startNewScene(null, this.shine);
		TimeController.EKEBHIJMEML().isActive = this.isTimeManagerActive;
	}

	// Token: 0x0600670C RID: 26380 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBOONMDONCF()
	{
	}

	// Token: 0x0600670D RID: 26381 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBGKAMLLACN()
	{
	}

	// Token: 0x0600670E RID: 26382 RVA: 0x00304208 File Offset: 0x00302408
	private void HHGGCBLOJGB()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.LCEBBHPKOHO() + string.Format("\n", num);
		string hojhbmnihba = "_TexelOffsetScale";
		byte[] array = null;
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "medium";
			}
			array = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.ODDOIHEPICE().NAHGKAPMKKL(193f), 1741f, OLPINJLCKCI.ODDOIHEPICE().NAHGKAPMKKL(1944f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().JOFAKNGHIAD(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.HCBMGCJMCBG(array);
			}
			JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GIDJODKDJGD();
			this.user.GACMMMGCLNC(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.NPIEJELJPIM().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPCAKEGNBHD().reservPosition;
				this.user.transform.rotation = LocBaseManager.AIHINNHNNIA().reservRotation;
				LocBaseManager.NPIEJELJPIM().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.GMOFOPHNFBG();
		}
	}

	// Token: 0x0600670F RID: 26383 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJBBLDJHPD()
	{
	}

	// Token: 0x06006710 RID: 26384 RVA: 0x003026E0 File Offset: 0x003008E0
	public void LLEOKNHDFNO(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.LECMGDEDAKF();
	}

	// Token: 0x06006711 RID: 26385 RVA: 0x0030234E File Offset: 0x0030054E
	private void ELLJEHHACHL()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06006712 RID: 26386 RVA: 0x0030234E File Offset: 0x0030054E
	private void PDEEOGAAMBB()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06006714 RID: 26388 RVA: 0x00303F1B File Offset: 0x0030211B
	public void EFDJPMFBIDD(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.PFFJJEJNKPB();
	}

	// Token: 0x06006715 RID: 26389 RVA: 0x0030442E File Offset: 0x0030262E
	public void APAIECJOGCK()
	{
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("cht_msg30" + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006716 RID: 26390 RVA: 0x00304469 File Offset: 0x00302669
	public void PJMMGNAJJBF()
	{
		JLFJEGIPIMM.PKGMBFEMKGP().LMFEHHFPAAA("System.Boolean" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006717 RID: 26391 RVA: 0x0030234E File Offset: 0x0030054E
	private void POFHKNCEHKF()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06006718 RID: 26392 RVA: 0x003044A4 File Offset: 0x003026A4
	private void Start()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.MainCanvas;
		}
		int num = 1;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.DIDFMAELMJD + string.Format("Bases/{0}/", num);
		string hojhbmnihba = "PersonWomanFisher";
		byte[] array = null;
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "PersonManFisher";
			}
			array = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.IKGFHGKKCPG.CAJEBHILIGM(1.5f), 0f, OLPINJLCKCI.IKGFHGKKCPG.CAJEBHILIGM(1.5f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.initShadowsParams(array);
			}
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.IKGFHGKKCPG.isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.IKGFHGKKCPG.reservPosition;
				this.user.transform.rotation = LocBaseManager.IKGFHGKKCPG.reservRotation;
				LocBaseManager.IKGFHGKKCPG.isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.applyEffect();
		}
	}

	// Token: 0x06006719 RID: 26393 RVA: 0x003046CA File Offset: 0x003028CA
	public void loadBaseMapTexture(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.KEDGAOBCNJG;
	}

	// Token: 0x0600671A RID: 26394 RVA: 0x003046DD File Offset: 0x003028DD
	public void JICMOACCBED(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.ANLLGCICOPP();
	}

	// Token: 0x0600671B RID: 26395 RVA: 0x003046F0 File Offset: 0x003028F0
	private void MKNPFMEMOJO()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.BBLINJLBAIL().FJLPFLCJMPE(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.ACOEIDGDLJC() + string.Format("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", num);
		string hojhbmnihba = "_WrinkleNormalMap2";
		byte[] array = null;
		if (JBEHMPDDMME.JKIFIBEPICO() != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "_Sensitivity";
			}
			array = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.NPIEJELJPIM().KKNHLLIFDFJ(658f), 1459f, OLPINJLCKCI.NLOGJHEFMHM().CAJEBHILIGM(238f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().JOFAKNGHIAD(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.initShadowsParams(array);
			}
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.GACMMMGCLNC(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.AIHINNHNNIA().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.FJLCHDGLMMK().reservPosition;
				this.user.transform.rotation = LocBaseManager.EDKKJNHDBPF().reservRotation;
				LocBaseManager.EDKKJNHDBPF().isCancelEnter = false;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.GMOFOPHNFBG();
		}
	}

	// Token: 0x0600671C RID: 26396 RVA: 0x0030234E File Offset: 0x0030054E
	private void BFOPAJGPJLK()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x0600671D RID: 26397 RVA: 0x00304916 File Offset: 0x00302B16
	public void PCJKCLFDJMI(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.OABDBIAHOJH();
	}

	// Token: 0x0600671E RID: 26398 RVA: 0x0030234E File Offset: 0x0030054E
	private void OnGUI()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x0600671F RID: 26399 RVA: 0x00304929 File Offset: 0x00302B29
	public void NBPGJKAHCMH()
	{
		JLFJEGIPIMM.NNEAHAFBOHC().LMFEHHFPAAA("wpn_cat4" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006720 RID: 26400 RVA: 0x00304964 File Offset: 0x00302B64
	private void PLBDELOIINH()
	{
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.NKOEAPCIBKO().EOPEPOJNLNF(this.MainCanvas);
		}
		int num = 1;
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.EEAKGGDJAGB() + string.Format("name", num);
		string hojhbmnihba = "";
		byte[] array = null;
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "Hidden/Post FX/Builtin Debug Views";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.IFLFANPMLMM().IDKKGIPKIHH(579f), 271f, OLPINJLCKCI.NLOGJHEFMHM().FJFNKMAEPMP(1071f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.NCAMDBAJGOD(array);
			}
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.GJACINHCABC().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.CHFPAOGEMEM().reservPosition;
				this.user.transform.rotation = LocBaseManager.NPCAKEGNBHD().reservRotation;
				LocBaseManager.NPIEJELJPIM().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.PINNILCPMAJ();
		}
	}

	// Token: 0x06006721 RID: 26401 RVA: 0x0030234E File Offset: 0x0030054E
	private void AJLEAKOMHJG()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06006722 RID: 26402 RVA: 0x00304B8A File Offset: 0x00302D8A
	public void PIBELDECOPD()
	{
		JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII("useSrcAlphaAsMask" + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x06006723 RID: 26403 RVA: 0x0030417A File Offset: 0x0030237A
	private void IOIJGMFNBMC()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().OAOAILNFJNL(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x06006724 RID: 26404 RVA: 0x00304BC5 File Offset: 0x00302DC5
	public void BICICBMIECO(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.MMKLLFCKCAG();
	}

	// Token: 0x06006725 RID: 26405 RVA: 0x00304BD8 File Offset: 0x00302DD8
	private void AFFAJKPPMHF()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.BBLINJLBAIL().CGKGBPLODOJ(this.MainCanvas);
		}
		int num = 0;
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		}
		IFPIMPMKJIB.LCEBBHPKOHO() + string.Format("D", num);
		string hojhbmnihba = "IdleStand";
		byte[] array = null;
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "uierror6.wav";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 vector = this.userInstPoint.position;
		Vector3 b = new Vector3(OLPINJLCKCI.NLOGJHEFMHM().IDKKGIPKIHH(310f), 1492f, OLPINJLCKCI.NLOGJHEFMHM().IDKKGIPKIHH(1091f));
		vector += b;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII(hojhbmnihba, vector, null);
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			WowCamera component = Camera.main.gameObject.GetComponent<WowCamera>();
			if (component != null)
			{
				component.target = this.user.camPoint;
			}
			Character component2 = this.user.gameObject.GetComponent<Character>();
			if (component2 != null && array != null)
			{
				component2.IIKNAKNILFF(array);
			}
			JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GIDJODKDJGD();
			this.user.ONDOHGBIDHO(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HHAHKJPGOLK);
			if (LocBaseManager.EDKKJNHDBPF().isCancelEnter)
			{
				this.user.transform.position = LocBaseManager.NPIEJELJPIM().reservPosition;
				this.user.transform.rotation = LocBaseManager.AIHINNHNNIA().reservRotation;
				LocBaseManager.FJLCHDGLMMK().isCancelEnter = true;
			}
		}
		if (this.gameChatPrefab != null)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab).transform.SetParent(this.MainCanvas);
		}
		CamEffector camEffector = UnityEngine.Object.FindObjectOfType<CamEffector>();
		if (camEffector != null)
		{
			camEffector.GMOFOPHNFBG();
		}
	}

	// Token: 0x06006726 RID: 26406 RVA: 0x003032EA File Offset: 0x003014EA
	public void DEJFKHFLAPP(CKNLPGEPGGF.IAPCJOBDCEH IEPBGKCHDJO)
	{
		this.LocMap.texture = IEPBGKCHDJO.HONJOFFBOPH();
	}

	// Token: 0x06006727 RID: 26407 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HAIMGCDKPDC()
	{
	}

	// Token: 0x06006728 RID: 26408 RVA: 0x00304DFE File Offset: 0x00302FFE
	private void FJBJDFDJAMI()
	{
		BaseLogic.getI = this;
		TimeController.BOBNPEAEECC().HPCJDECDCEF(null, this.shine);
		TimeController.KOJCECHBHLO().isActive = this.isTimeManagerActive;
	}

	// Token: 0x06006729 RID: 26409 RVA: 0x00304E27 File Offset: 0x00303027
	private void DKBGMIPBHNM()
	{
		BaseLogic.getI = this;
		TimeController.EKEBHIJMEML().GLEHJCIFJLG(null, this.shine);
		TimeController.EPCKOOOGNGK().isActive = this.isTimeManagerActive;
	}

	// Token: 0x0600672A RID: 26410 RVA: 0x00304E50 File Offset: 0x00303050
	public void AHCPOCGEFNB()
	{
		JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII(" " + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x0600672B RID: 26411 RVA: 0x00304E8B File Offset: 0x0030308B
	public void LPKFGKDFIIN()
	{
		JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package." + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, this.MainCanvas.transform);
	}

	// Token: 0x04000E95 RID: 3733
	public static BaseLogic getI;

	// Token: 0x04000E96 RID: 3734
	public bool isTimeManagerActive;

	// Token: 0x04000E97 RID: 3735
	public GameObject gameChatPrefab;

	// Token: 0x04000E98 RID: 3736
	public Transform userInstPoint;

	// Token: 0x04000E99 RID: 3737
	public Fisherman user;

	// Token: 0x04000E9A RID: 3738
	public TOD_Sky todSky;

	// Token: 0x04000E9B RID: 3739
	public RectTransform MainCanvas;

	// Token: 0x04000E9C RID: 3740
	public Sunshine shine;

	// Token: 0x04000E9D RID: 3741
	public RawImage LocMap;
}
