using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000141 RID: 321
[RequireComponent(typeof(RectTransform))]
public class FRodObject : MonoBehaviour, ICanvasRaycastFilter
{
	// Token: 0x060042D9 RID: 17113 RVA: 0x001F62BC File Offset: 0x001F44BC
	private IEnumerator OIKBODOIHCH()
	{
		yield return new WaitForSeconds(0.1f);
		while (this.isFishOnRod)
		{
			this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO();
			this.IAMFCDGBMDP += new Vector3(0f, 0.5f, 0f);
			this.IAMFCDGBMDP.Normalize();
			float seconds = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(2.0);
			yield return new WaitForSeconds(seconds);
		}
		yield break;
	}

	// Token: 0x060042DA RID: 17114 RVA: 0x001F62CB File Offset: 0x001F44CB
	public void OnSelect()
	{
		this.isSelect = true;
		LocationGui.getI.RollPanelupdatePosition();
		this.ABDONEGMGMA();
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060042DE RID: 17118 RVA: 0x001F63EE File Offset: 0x001F45EE
	// (set) Token: 0x060042DB RID: 17115 RVA: 0x001F62E4 File Offset: 0x001F44E4
	public float BICGFMMPIAI
	{
		get
		{
			return this.rodWeapons.IFNNBJDJBNA;
		}
		set
		{
			this.rodWeapons.IFNNBJDJBNA = value;
		}
	}

	// Token: 0x060042DC RID: 17116 RVA: 0x001F62F4 File Offset: 0x001F44F4
	public void fishPodsek()
	{
		if (!this.isKlevFlag)
		{
			this.BGLLPMKNBCE = false;
			return;
		}
		if (this.pointer_Object != null)
		{
			this.isFishTrapped = false;
			Vector2 pointer_Position = this.JHMNHDGLCMP;
			UnityEngine.Object.Destroy(this.pointer_Object);
			this.pointer_Object = UnityEngine.Object.Instantiate<GameObject>(LocationLogic.getI.pointerFishPrefab, Vector3.zero, Quaternion.identity);
			this.pointer = this.pointer_Object.GetComponent<PointerLogic>();
			this.JHMNHDGLCMP = pointer_Position;
			this.isFishOnRod = true;
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[3], 0.8f);
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[4], 0.3f);
			LocationGui.getI.RollPanelupdatePosition();
			Debug.Log("*** PODSEK");
			base.StopCoroutine(this.MNPCLIHPGKN());
			this.NNGFCIOBEFJ = this.NCEDJJAMNLA / 3f;
			base.StartCoroutine(this.DOCPHHJNKIF());
		}
	}

	// Token: 0x060042DD RID: 17117 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public bool AOBILOAHIAC(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		return true;
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x001F63FC File Offset: 0x001F45FC
	private void NIDJADHMLFD(Vector2 EHGOKLMMIKE, int AJBKGOGIIJH)
	{
		this.isKlevFlag = false;
		this.isKlevProcess = false;
		this.isFishGet = false;
		if (this.pointer_Object != null)
		{
			UnityEngine.Object.Destroy(this.pointer_Object);
		}
		if (AJBKGOGIIJH == -1)
		{
			this.pointer_Object = UnityEngine.Object.Instantiate<GameObject>(LocationLogic.getI.pointerFishPrefab, Vector3.zero, Quaternion.identity);
		}
		else
		{
			this.pointer_Object = UnityEngine.Object.Instantiate<GameObject>(LocationLogic.getI.pointerPrefabs[this.otterType], Vector3.zero, Quaternion.identity);
		}
		this.pointer = this.pointer_Object.GetComponent<PointerLogic>();
		if (this.otterType == 0)
		{
			int num = this.rodWeapons.PFNCHEEEBKD.BBLEPPMMPIL("wpn_add/addoptions", "imageindex").DIKKDGKIPEA;
			this.pointer.pointerImage.sprite = LocationLogic.getI.poplImages[num];
			this.pointer.inercia = this.rodWeapons.PFNCHEEEBKD.MIMANMPNLPE.OBEOJCGHOGL / 30f;
			this.pointer.inercia = Mathf.Clamp(this.pointer.inercia, 0.1f, 3f);
			this.pointer.APCNMCOCPAE = 1f;
		}
		this.JHMNHDGLCMP = EHGOKLMMIKE;
		this.pointer.dropAction();
	}

	// Token: 0x060042E0 RID: 17120 RVA: 0x001F63EE File Offset: 0x001F45EE
	public float FOAMDFKHOHC()
	{
		return this.rodWeapons.IFNNBJDJBNA;
	}

	// Token: 0x060042E1 RID: 17121 RVA: 0x000EB372 File Offset: 0x000E9572
	public bool HGABOJJPPPL(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		return false;
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x001F6547 File Offset: 0x001F4747
	private IEnumerator HHBADMOJIPD(float JLHNJDFMHMO, Vector2 EHGOKLMMIKE)
	{
		FRodObject.ACFHHEADFBC acfhheadfbc = new FRodObject.ACFHHEADFBC(1);
		acfhheadfbc.AENJLLPLILM = this;
		acfhheadfbc.JLHNJDFMHMO = JLHNJDFMHMO;
		acfhheadfbc.EHGOKLMMIKE = EHGOKLMMIKE;
		return acfhheadfbc;
	}

	// Token: 0x060042E3 RID: 17123 RVA: 0x001F6564 File Offset: 0x001F4764
	public void HPLDIIIFDCP(bool DCCPCBLODIG)
	{
		this.KKENGLGEHPK = DCCPCBLODIG;
		this.anm.SetBool("MotorbikeShootRight", this.KKENGLGEHPK);
		if (!this.KKENGLGEHPK)
		{
			base.StopCoroutine(this.BMGOPAPCHGF());
			base.StopCoroutine(this.DOCPHHJNKIF());
			if (this.pointer_Object != null)
			{
				UnityEngine.Object.Destroy(this.pointer_Object);
			}
			LocationLogic.getI.PBar_Up.position = 1323f;
			LocationLogic.getI.PBar_Down.position = 612f;
			LocationLogic.getI.PBarAdd_Up.position = 547f;
			LocationLogic.getI.PBarAdd_Down.position = 1395f;
			this.KFPLLOLLMBL = 1237f;
			this.OHCNIOIFMAI = 1500f;
			this.CKNFCENJEGL = 1541f;
			this.JMJKHCJIMEO = 1945f;
			this.isKlevProcess = true;
			this.isFishOnRod = false;
			this.isFishGet = true;
			this.isFishTrapped = true;
		}
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x001F6664 File Offset: 0x001F4864
	public void NPGKFBHCBKB(Vector2 DCCPCBLODIG)
	{
		if (this.pointer_Object != null)
		{
			RectTransform component = this.pointer_Object.GetComponent<RectTransform>();
			if (component != null)
			{
				component.parent = LocationGui.getI.backLockImage.rectTransform;
				Vector3 vector = new Vector3(DCCPCBLODIG.x * LocationGui.getI.backLockImage.rectTransform.rect.width, -DCCPCBLODIG.y * LocationGui.getI.backLockImage.rectTransform.rect.height, 595f);
				vector += component.parent.position;
				component.position = vector;
			}
		}
	}

	// Token: 0x060042E5 RID: 17125 RVA: 0x001F671C File Offset: 0x001F491C
	public void CDGEFHCKPAG()
	{
		if (!this.isKlevFlag)
		{
			this.BGLLPMKNBCE = false;
			return;
		}
		if (this.pointer_Object != null)
		{
			this.isFishTrapped = false;
			Vector2 dccpcblodig = this.INEBDLMFIII();
			UnityEngine.Object.Destroy(this.pointer_Object);
			this.pointer_Object = UnityEngine.Object.Instantiate<GameObject>(LocationLogic.getI.pointerFishPrefab, Vector3.zero, Quaternion.identity);
			this.pointer = this.pointer_Object.GetComponent<PointerLogic>();
			this.NPGKFBHCBKB(dccpcblodig);
			this.isFishOnRod = true;
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[8], 1114f);
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[4], 1172f);
			LocationGui.getI.HLEICCEKCCB();
			Debug.Log("Animation controllers should be parented to character controllers!");
			base.StopCoroutine(this.BMGOPAPCHGF());
			this.NNGFCIOBEFJ = this.NCEDJJAMNLA / 314f;
			base.StartCoroutine(this.OIKBODOIHCH());
		}
	}

	// Token: 0x060042E6 RID: 17126 RVA: 0x001F6818 File Offset: 0x001F4A18
	public Vector2 INEBDLMFIII()
	{
		Vector2 vector = Vector2.zero;
		if (this.pointer != null)
		{
			vector = this.pointer.LBBFONMAKMC();
			vector.y = 1184f - vector.y;
		}
		return vector;
	}

	// Token: 0x060042E7 RID: 17127 RVA: 0x001F6859 File Offset: 0x001F4A59
	private void LPNDCJKAKEA()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.MHFDIJGJGBJ().KEGKCKFOPGG();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.NBAAMOJMECH();
		this.isFishOnRod = true;
	}

	// Token: 0x060042E8 RID: 17128 RVA: 0x001F6895 File Offset: 0x001F4A95
	public void LDPBGALNFNK()
	{
		this.isSelect = true;
		LocationGui.getI.MMJPKLHFCMM();
		this.ABDONEGMGMA();
	}

	// Token: 0x060042E9 RID: 17129 RVA: 0x001F68B0 File Offset: 0x001F4AB0
	public void onClose()
	{
		this.isKlevFlag = false;
		this.isKlevProcess = false;
		this.isFishOnRod = false;
		this.isFishTrapped = false;
		if (this.pointer_Object)
		{
			UnityEngine.Object.Destroy(this.pointer_Object);
		}
		this.buttonRect.gameObject.SetActive(false);
	}

	// Token: 0x060042EA RID: 17130 RVA: 0x001F6902 File Offset: 0x001F4B02
	private IEnumerator IAAHOJCJCJB(float JLHNJDFMHMO, Vector2 EHGOKLMMIKE)
	{
		yield return new WaitForSeconds(JLHNJDFMHMO);
		float num = EHGOKLMMIKE.x * (float)Screen.width - (EHGOKLMMIKE.x - 0.5f) * 200f;
		num = Mathf.Clamp(num, 100f, (float)(Screen.width - 100));
		if (EHGOKLMMIKE.x > 0.4f && EHGOKLMMIKE.x < 0.6f)
		{
			num += 60f;
		}
		Vector3 position = this.rrect.position;
		position.x = num;
		this.rrect.position = position;
		this.BGLLPMKNBCE = true;
		Vector3 eulerAngles = this.rod3D_Object.transform.localRotation.eulerAngles;
		eulerAngles.y = (EHGOKLMMIKE.x - 0.5f) * 20f;
		this.rod3D_Object.transform.localRotation = Quaternion.Euler(eulerAngles);
		yield return new WaitForSeconds(0.5f);
		this.baitDeep = 0f;
		this.NIDJADHMLFD(EHGOKLMMIKE, this.otterType);
		yield break;
	}

	// Token: 0x060042EB RID: 17131 RVA: 0x001F6920 File Offset: 0x001F4B20
	public void FGGMIJIOPLB()
	{
		if (!this.isKlevFlag)
		{
			this.HPLDIIIFDCP(true);
			return;
		}
		if (this.pointer_Object != null)
		{
			this.isFishTrapped = true;
			Vector2 pointer_Position = this.JHMNHDGLCMP;
			UnityEngine.Object.Destroy(this.pointer_Object);
			this.pointer_Object = UnityEngine.Object.Instantiate<GameObject>(LocationLogic.getI.pointerFishPrefab, Vector3.zero, Quaternion.identity);
			this.pointer = this.pointer_Object.GetComponent<PointerLogic>();
			this.DKEMJOIEMMK(pointer_Position);
			this.isFishOnRod = false;
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[3], 638f);
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(SoundSamplesStorage.getI.clips[3], 1584f);
			LocationGui.getI.RollPanelupdatePosition();
			Debug.Log("t_hair");
			base.StopCoroutine(this.BMGOPAPCHGF());
			this.NNGFCIOBEFJ = this.NCEDJJAMNLA / 1131f;
			base.StartCoroutine(this.LMGEOCCAIOJ());
		}
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x001F6A1C File Offset: 0x001F4C1C
	public Vector2 getPointerPosition()
	{
		Vector2 absoluteCoord = new Vector2(-100f, -100f);
		if (!this.PFMNPEOKEKO)
		{
			return absoluteCoord;
		}
		if (!this.BGLLPMKNBCE)
		{
			return absoluteCoord;
		}
		if (this.pointer_Object == null)
		{
			return absoluteCoord;
		}
		if (this.pointer == null)
		{
			return absoluteCoord;
		}
		absoluteCoord = this.pointer.getAbsoluteCoord();
		return absoluteCoord;
	}

	// Token: 0x060042ED RID: 17133 RVA: 0x001F62BC File Offset: 0x001F44BC
	private IEnumerator LMGEOCCAIOJ()
	{
		yield return new WaitForSeconds(0.1f);
		while (this.isFishOnRod)
		{
			this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO();
			this.IAMFCDGBMDP += new Vector3(0f, 0.5f, 0f);
			this.IAMFCDGBMDP.Normalize();
			float seconds = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(2.0);
			yield return new WaitForSeconds(seconds);
		}
		yield break;
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x001F6A7C File Offset: 0x001F4C7C
	private void IGLABCEANOO()
	{
		float num = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(11.0);
		this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF -= (double)num;
		if (this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF <= 10.0)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, this.rodWeapons.IIOHPBENEFI.LPFKFNLHGBI);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("<color='#800000'>Вы потеряли леску: " + this.rodWeapons.IIOHPBENEFI.JPBOPFNPNHC(false) + "</color>");
			this.rodWeapons.IIOHPBENEFI.JGNIDDBNGGP = 500;
			this.rodWeapons.IIOHPBENEFI = null;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.rodWeapons.IIOHPBENEFI.LPFKFNLHGBI);
				epmphjgalbe.DLAIEEJAFDG(num);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1306, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("<color='#800000'>Вы порвали леску: " + Mathf.Round(num) + "м</color>");
		}
		foreach (EKBAPCMPANI ekbapcmpani in this.rodWeapons.CBLCFLENIJL)
		{
			if (ekbapcmpani != null)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, ekbapcmpani.LPFKFNLHGBI);
				ekbapcmpani.JGNIDDBNGGP = 500;
			}
		}
		if (this.rodWeapons.PFNCHEEEBKD != null && num > BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(this.frodid).IFNNBJDJBNA)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, this.rodWeapons.PFNCHEEEBKD.LPFKFNLHGBI);
			this.rodWeapons.PFNCHEEEBKD.JGNIDDBNGGP = 500;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("linebreak.ogg", 1f);
	}

	// Token: 0x060042EF RID: 17135 RVA: 0x001F6C74 File Offset: 0x001F4E74
	public bool LMCCAABKAGE()
	{
		return base.gameObject.activeSelf;
	}

	// Token: 0x060042F0 RID: 17136 RVA: 0x000EB372 File Offset: 0x000E9572
	public bool INANOMGEIEI(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		return false;
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x001F6C81 File Offset: 0x001F4E81
	public void unSelect()
	{
		this.isSelect = false;
		this.ABDONEGMGMA();
	}

	// Token: 0x060042F2 RID: 17138 RVA: 0x001F6C90 File Offset: 0x001F4E90
	public void onOpen()
	{
		this.isKlevFlag = false;
		this.isKlevProcess = false;
		this.isFishOnRod = false;
		this.isFishTrapped = false;
		this.buttonRect.gameObject.SetActive(true);
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[1], 0.5f);
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x001F6547 File Offset: 0x001F4747
	private IEnumerator DMGHIMHGPMI(float JLHNJDFMHMO, Vector2 EHGOKLMMIKE)
	{
		FRodObject.ACFHHEADFBC acfhheadfbc = new FRodObject.ACFHHEADFBC(1);
		acfhheadfbc.AENJLLPLILM = this;
		acfhheadfbc.JLHNJDFMHMO = JLHNJDFMHMO;
		acfhheadfbc.EHGOKLMMIKE = EHGOKLMMIKE;
		return acfhheadfbc;
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x001F6CE8 File Offset: 0x001F4EE8
	public void setPosition(Vector2 EHGOKLMMIKE)
	{
		this.IDBBDOFMDII = EHGOKLMMIKE;
		this.isFishTrapped = false;
		if (this.pointer_Object != null)
		{
			UnityEngine.Object.Destroy(this.pointer_Object);
		}
		float jlhnjdfmhmo = 0.1f;
		if (this.BGLLPMKNBCE)
		{
			this.BGLLPMKNBCE = false;
			jlhnjdfmhmo = 0.1f;
		}
		base.StartCoroutine(this.IAAHOJCJCJB(jlhnjdfmhmo, EHGOKLMMIKE));
	}

	// Token: 0x060042F5 RID: 17141 RVA: 0x001F6D48 File Offset: 0x001F4F48
	public void reDrop()
	{
		if (this.IDBBDOFMDII != Vector2.zero)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[3], 0.8f);
			this.BGLLPMKNBCE = false;
			this.setPosition(this.IDBBDOFMDII);
		}
	}

	// Token: 0x060042F6 RID: 17142 RVA: 0x001F6C74 File Offset: 0x001F4E74
	public bool EFGNLFFKDMI()
	{
		return base.gameObject.activeSelf;
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x001F6D95 File Offset: 0x001F4F95
	private void Start()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.ABDONEGMGMA();
		this.isFishOnRod = false;
	}

	// Token: 0x060042F8 RID: 17144 RVA: 0x001F6DD1 File Offset: 0x001F4FD1
	private IEnumerator BMGOPAPCHGF()
	{
		FRodObject.JPDNMEMCINL jpdnmemcinl = new FRodObject.JPDNMEMCINL(1);
		jpdnmemcinl.AENJLLPLILM = this;
		return jpdnmemcinl;
	}

	// Token: 0x060042F9 RID: 17145 RVA: 0x001F62BC File Offset: 0x001F44BC
	private IEnumerator DOCPHHJNKIF()
	{
		yield return new WaitForSeconds(0.1f);
		while (this.isFishOnRod)
		{
			this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO();
			this.IAMFCDGBMDP += new Vector3(0f, 0.5f, 0f);
			this.IAMFCDGBMDP.Normalize();
			float seconds = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(2.0);
			yield return new WaitForSeconds(seconds);
		}
		yield break;
	}

	// Token: 0x060042FA RID: 17146 RVA: 0x001F6DE0 File Offset: 0x001F4FE0
	private void NBAAMOJMECH()
	{
		int num = 0;
		if (this.isSelect)
		{
			num = 0;
		}
		int num2 = num * 4 + this.frodid;
		this.btnImage.sprite = LocationGui.getI.rodsKeyImages[num2];
	}

	// Token: 0x060042FB RID: 17147 RVA: 0x001F6E1C File Offset: 0x001F501C
	public void IBDLAMAFJNF()
	{
		if (this.isFishTrapped)
		{
			return;
		}
		float num = this.IBMCCLJKOFI / (this.PHCJGMBNBNN + 1069f);
		bool flag = true;
		if (OJCFBJGEEHL.IKGFHGKKCPG.MICELLFEEAD())
		{
			this.KFPLLOLLMBL = 1857f * (float)this.AFKGAMJEPKL / ((float)this.rodWeapons.NKNCNHGDMLF.EMBKDHKGIEL().KMIOLLENCOL() * 375f);
			flag = false;
			LocationLogic.getI.PBarAdd_Down.position = LocationLogic.getI.PBarAdd_Down.position - 1634f * Time.deltaTime;
			this.CKNFCENJEGL = 63f;
		}
		else
		{
			this.KFPLLOLLMBL = 1054f;
			this.CKNFCENJEGL = 1423f;
		}
		if (OJCFBJGEEHL.IKGFHGKKCPG.LODANOFDIEI())
		{
			this.OHCNIOIFMAI = 1652f * (float)this.AFKGAMJEPKL / ((float)this.rodWeapons.IIOHPBENEFI.MIMANMPNLPE.IBEIBAHKIAH * 306f);
			flag = true;
			this.JMJKHCJIMEO = 1767f;
			LocationLogic.getI.PBarAdd_Up.position = LocationLogic.getI.PBarAdd_Up.position - 829f * Time.deltaTime;
		}
		else
		{
			this.OHCNIOIFMAI = 1299f;
			this.JMJKHCJIMEO = 453f;
		}
		this.KFPLLOLLMBL = Mathf.Clamp(this.KFPLLOLLMBL, 679f, 1629f);
		this.OHCNIOIFMAI = Mathf.Clamp(this.OHCNIOIFMAI, 1384f, 1426f);
		float num2 = (LocationLogic.getI.PBar_Up.position < this.KFPLLOLLMBL) ? 145f : 1546f;
		LocationLogic.getI.PBar_Up.position = Mathf.Lerp(LocationLogic.getI.PBar_Up.position, this.KFPLLOLLMBL, Time.deltaTime * num2);
		float num3 = (LocationLogic.getI.PBar_Down.position < this.OHCNIOIFMAI) ? 1898f : 1371f;
		LocationLogic.getI.PBar_Down.position = Mathf.Lerp(LocationLogic.getI.PBar_Down.position, this.OHCNIOIFMAI, Time.deltaTime * num3);
		LocationLogic.getI.PBarAdd_Up.position = Mathf.Lerp(LocationLogic.getI.PBarAdd_Up.position, this.CKNFCENJEGL, Time.deltaTime * 203f);
		LocationLogic.getI.PBarAdd_Down.position = Mathf.Lerp(LocationLogic.getI.PBarAdd_Down.position, this.JMJKHCJIMEO, Time.deltaTime * 611f);
		if (LocationLogic.getI.PBar_Up.position > 1009f)
		{
			this.BGLLPMKNBCE = true;
			if (this.rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.IBEIBAHKIAH < this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI.KMIOLLENCOL())
			{
				NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(92, this.rodWeapons.NKNCNHGDMLF.LPFKFNLHGBI);
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("BowInstant", 1493f);
				this.rodWeapons.NKNCNHGDMLF.JGNIDDBNGGP = 122;
				this.rodWeapons.NKNCNHGDMLF = null;
				OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("inv_pcs1");
			}
			else
			{
				this.FPFCAJEBACH();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
			return;
		}
		if (LocationLogic.getI.PBar_Down.position > 1678f)
		{
			this.BCPJHJEBBPM(true);
			this.IGLABCEANOO();
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
			return;
		}
		if (flag)
		{
			this.IBMCCLJKOFI -= 992f * Time.deltaTime;
		}
		else if (this.NKAHNAEPJCB > 1568f)
		{
			this.IBMCCLJKOFI += 1485f * Time.deltaTime;
		}
		this.IBMCCLJKOFI = Mathf.Clamp(this.IBMCCLJKOFI, 1178f, this.PHCJGMBNBNN);
		if (this.getPointerPosition().y < 692f)
		{
			this.isFishTrapped = false;
			this.isFishGet = false;
			this.isFishOnRod = false;
			this.BCPJHJEBBPM(true);
			this.IAMFCDGBMDP = Vector3.zero;
			this.ECKLGMKIOGB = Vector3.zero;
			this.AFKGAMJEPKL = 0;
			this.ELLDFINKBLP = 1529f;
			this.NCEDJJAMNLA = 1959f;
			this.PHCJGMBNBNN = 1484f;
			this.isKlevFlag = true;
			base.StopCoroutine(this.MNPCLIHPGKN());
			base.StopCoroutine(this.OIKBODOIHCH());
			if (this.pointer_Object != null)
			{
				UnityEngine.Object.Destroy(this.pointer_Object);
			}
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-74, this.frodid);
		}
	}

	// Token: 0x060042FC RID: 17148 RVA: 0x001F72B0 File Offset: 0x001F54B0
	public void HFDOMJNDIJJ()
	{
		if (this.IDBBDOFMDII != Vector2.zero)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[2], 1175f);
			this.BCPJHJEBBPM(true);
			this.setPosition(this.IDBBDOFMDII);
		}
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x001F7300 File Offset: 0x001F5500
	private void FBPCHGLEBMK()
	{
		int num = 1;
		if (this.isSelect)
		{
			num = 1;
		}
		int num2 = num * 3 + this.frodid;
		this.btnImage.sprite = LocationGui.getI.rodsKeyImages[num2];
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x001F63EE File Offset: 0x001F45EE
	public float LJNDEDHCEAL()
	{
		return this.rodWeapons.IFNNBJDJBNA;
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x001F733C File Offset: 0x001F553C
	public void CCHBBGCFGON()
	{
		this.isKlevFlag = true;
		this.isKlevProcess = true;
		this.isFishOnRod = false;
		this.isFishTrapped = true;
		this.buttonRect.gameObject.SetActive(true);
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[0], 822f);
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x001F7394 File Offset: 0x001F5594
	private void FPFCAJEBACH()
	{
		float num = 114f + OLPINJLCKCI.ODDOIHEPICE().GKDBPBFOINB(503.0);
		IIBEEKCAAHK iibeekcaahk = this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI;
		iibeekcaahk.MKOBCGPJMHA(iibeekcaahk.FJACMDGJEBL() - (double)num);
		if (this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF <= 1348.0)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-56, this.rodWeapons.IIOHPBENEFI.LPFKFNLHGBI);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("error.wav" + this.rodWeapons.IIOHPBENEFI.DFOJOOMBOGI(false) + "Saves protection");
			this.rodWeapons.IIOHPBENEFI.JGNIDDBNGGP = -166;
			this.rodWeapons.IIOHPBENEFI = null;
		}
		else
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.rodWeapons.IIOHPBENEFI.LPFKFNLHGBI);
				epmphjgalbe.KCMKJKENAFA(num);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(145, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.BKKEFKANGIM();
			}
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("TOD_Brightness" + Mathf.Round(num) + "WandAttack");
		}
		EKBAPCMPANI[] cblcflenijl = this.rodWeapons.CBLCFLENIJL;
		for (int i = 1; i < cblcflenijl.Length; i += 0)
		{
			EKBAPCMPANI ekbapcmpani = cblcflenijl[i];
			if (ekbapcmpani != null)
			{
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-16, ekbapcmpani.LPFKFNLHGBI);
				ekbapcmpani.JGNIDDBNGGP = -169;
			}
		}
		if (this.rodWeapons.PFNCHEEEBKD != null && num > BOIKJDICEMF.IKGFHGKKCPG.LPOLHKLBJKN(this.frodid).IFNNBJDJBNA)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-25, this.rodWeapons.PFNCHEEEBKD.LPFKFNLHGBI);
			this.rodWeapons.PFNCHEEEBKD.JGNIDDBNGGP = -183;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("<color='#6080ff'>", 307f);
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x001F758C File Offset: 0x001F578C
	public void klevAction(HBPNMNGOFMA KADBECGIMPD)
	{
		this.AFKGAMJEPKL = KADBECGIMPD.HDBGOLAFOBK();
		this.PLMKACBEPFI = KADBECGIMPD.BFPHBMDMODH().Split(new char[]
		{
			','
		});
		this.ELLDFINKBLP = KADBECGIMPD.FFDPCEAFGNF();
		this.NCEDJJAMNLA = KADBECGIMPD.FFDPCEAFGNF();
		this.PHCJGMBNBNN = KADBECGIMPD.FFDPCEAFGNF();
		this.NKAHNAEPJCB = KADBECGIMPD.FFDPCEAFGNF();
		this.OOEFFMLBEBG = KADBECGIMPD.FFDPCEAFGNF();
		this.IBMCCLJKOFI = this.PHCJGMBNBNN;
		if (this.otterType == 0)
		{
			if (this.rodWeapons.PFNCHEEEBKD.BBLEPPMMPIL("wpn_add/addoptions", "signal_enable").KPAFFJNBLHK)
			{
				string palfnhclkaj = this.rodWeapons.PFNCHEEEBKD.BBLEPPMMPIL("wpn_add/addoptions", "signal_tone").IEIMMFODGFG;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(palfnhclkaj, 1f);
			}
			this.pointer.ALFFGECKKDB = this.pointer.ALFFGECKKDB - 1f;
		}
		this.isKlevFlag = true;
		if (this.isKlevProcess)
		{
			base.StopCoroutine(this.MNPCLIHPGKN());
		}
		base.StartCoroutine(this.MNPCLIHPGKN());
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x001F76A8 File Offset: 0x001F58A8
	private void HAAGFBPEFMA()
	{
		Vector2 pointerPosition = this.getPointerPosition();
		if (!LocationLogic.getI.locData.checkWater(pointerPosition.x, 1f - pointerPosition.y))
		{
			this.pointer.rt.position = this.GBEIDPOCJBF;
		}
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x001F76F5 File Offset: 0x001F58F5
	private void MKNPFMEMOJO()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.PKGMBFEMKGP().GJDOHJHDEMO();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.ABDONEGMGMA();
		this.isFishOnRod = true;
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x001F7734 File Offset: 0x001F5934
	public void BCPJHJEBBPM(bool DCCPCBLODIG)
	{
		this.KKENGLGEHPK = DCCPCBLODIG;
		this.anm.SetBool("LEFT", this.KKENGLGEHPK);
		if (!this.KKENGLGEHPK)
		{
			base.StopCoroutine(this.BMGOPAPCHGF());
			base.StopCoroutine(this.DOCPHHJNKIF());
			if (this.pointer_Object != null)
			{
				UnityEngine.Object.Destroy(this.pointer_Object);
			}
			LocationLogic.getI.PBar_Up.position = 1418f;
			LocationLogic.getI.PBar_Down.position = 957f;
			LocationLogic.getI.PBarAdd_Up.position = 1016f;
			LocationLogic.getI.PBarAdd_Down.position = 817f;
			this.KFPLLOLLMBL = 1609f;
			this.OHCNIOIFMAI = 1313f;
			this.CKNFCENJEGL = 1450f;
			this.JMJKHCJIMEO = 67f;
			this.isKlevProcess = false;
			this.isFishOnRod = false;
			this.isFishGet = true;
			this.isFishTrapped = true;
		}
	}

	// Token: 0x06004305 RID: 17157 RVA: 0x001F7832 File Offset: 0x001F5A32
	private void KKCFKEDABLB()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.NNEAHAFBOHC().KEGKCKFOPGG();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.FBPCHGLEBMK();
		this.isFishOnRod = true;
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x0600430E RID: 17166 RVA: 0x001F8578 File Offset: 0x001F6778
	// (set) Token: 0x06004306 RID: 17158 RVA: 0x001F7870 File Offset: 0x001F5A70
	public Vector2 JHMNHDGLCMP
	{
		get
		{
			Vector2 vector = Vector2.zero;
			if (this.pointer != null)
			{
				vector = this.pointer.getAbsoluteCoord();
				vector.y = 1f - vector.y;
			}
			return vector;
		}
		set
		{
			if (this.pointer_Object != null)
			{
				RectTransform component = this.pointer_Object.GetComponent<RectTransform>();
				if (component != null)
				{
					component.parent = LocationGui.getI.backLockImage.rectTransform;
					Vector3 vector = new Vector3(value.x * LocationGui.getI.backLockImage.rectTransform.rect.width, -value.y * LocationGui.getI.backLockImage.rectTransform.rect.height, 0f);
					vector += component.parent.position;
					component.position = vector;
				}
			}
		}
	}

	// Token: 0x06004307 RID: 17159 RVA: 0x001F7927 File Offset: 0x001F5B27
	private IEnumerator MNPCLIHPGKN()
	{
		this.isKlevProcess = true;
		this.IAMFCDGBMDP = Vector3.zero;
		this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO() * 20f;
		this.IAMFCDGBMDP.z = -1f;
		this.isFishGet = true;
		float seconds = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.30000001192092896);
		yield return new WaitForSeconds(seconds);
		while (this.isKlevProcess)
		{
			Vector2 pointerPosition = this.getPointerPosition();
			this.IAMFCDGBMDP = Vector3.zero;
			float deep = LocationLogic.getI.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
			float num = this.baitDeep / deep;
			float num2 = 10f + this.NCEDJJAMNLA / 2f;
			float z = (OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0) - 0.5f) * num2;
			float num3 = 0.2f;
			float num4 = 1f;
			float num5 = 1f;
			float num6 = 3f;
			int pohomkcokoa = (int)(this.ELLDFINKBLP / 20f);
			int num7 = 1 + OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(pohomkcokoa);
			float d = 10f;
			if (!OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(110f - this.ELLDFINKBLP))
			{
				this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO() * d;
				int num8;
				for (int i = 0; i < num7; i = num8 + 1)
				{
					this.isFishGet = true;
					this.IAMFCDGBMDP.z = z;
					float seconds2 = num3 + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num4 - num3));
					yield return new WaitForSeconds(seconds2);
					this.isFishGet = false;
					this.IAMFCDGBMDP = Vector3.zero;
					float seconds3 = num5 + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num6 - num5));
					yield return new WaitForSeconds(seconds3);
					num8 = i;
				}
			}
			num5 = 1f;
			num6 = 3f;
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(110f - this.ELLDFINKBLP))
			{
				num3 = 0.8f;
				num4 = 2f + (110f - this.ELLDFINKBLP) / 50f;
				this.isFishGet = true;
				this.IAMFCDGBMDP = JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO() * d;
				this.IAMFCDGBMDP.z = z;
				float seconds4 = num3 + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num4 - num3));
				yield return new WaitForSeconds(seconds4);
				this.isFishGet = false;
			}
			yield return new WaitForSeconds(num5 + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num6 - num5)));
		}
		this.isKlevProcess = false;
		yield break;
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06004308 RID: 17160 RVA: 0x001F6C74 File Offset: 0x001F4E74
	public bool PFMNPEOKEKO
	{
		get
		{
			return base.gameObject.activeSelf;
		}
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x001F7938 File Offset: 0x001F5B38
	public void DKEMJOIEMMK(Vector2 DCCPCBLODIG)
	{
		if (this.pointer_Object != null)
		{
			RectTransform component = this.pointer_Object.GetComponent<RectTransform>();
			if (component != null)
			{
				component.parent = LocationGui.getI.backLockImage.rectTransform;
				Vector3 vector = new Vector3(DCCPCBLODIG.x * LocationGui.getI.backLockImage.rectTransform.rect.width, -DCCPCBLODIG.y * LocationGui.getI.backLockImage.rectTransform.rect.height, 1490f);
				vector += component.parent.position;
				component.position = vector;
			}
		}
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x001F79F0 File Offset: 0x001F5BF0
	private void Update()
	{
		this.anm.SetBool("isFishOnRod", this.isFishOnRod);
		Vector3 position = this.buttonRect.position;
		position.x = this.rrect.position.x - 30f;
		this.buttonRect.position = position;
		if (this.isFishTrapped)
		{
			return;
		}
		if (!this.isFishGet)
		{
			if (this.baitDeep < this.BICGFMMPIAI)
			{
				this.baitDeep += Time.deltaTime * 100f;
			}
		}
		else
		{
			this.baitDeep += Time.deltaTime * this.IAMFCDGBMDP.z;
		}
		if (this.pointer != null)
		{
			Vector3 vector = this.pointer.rt.position;
			this.GBEIDPOCJBF = this.pointer.rt.position;
			if (!this.isFishGet)
			{
				if (OJCFBJGEEHL.IKGFHGKKCPG.FNBMDPIKIIK())
				{
					vector = this.pointer.rt.position;
					vector.y -= 0.1f;
					this.pointer.rt.position = vector;
					if (vector.y < 0.1f)
					{
						this.BGLLPMKNBCE = false;
					}
				}
				vector = this.pointer.rt.position;
				Vector2 pointerPosition = this.getPointerPosition();
				Vector3 flow = LocationLogic.getI.locData.getFlow(pointerPosition.x, 1f - pointerPosition.y);
				vector += flow * flow.z * LocationLogic.getI.locData.flowForce * Time.deltaTime * (1f - pointerPosition.y);
				vector.z = 0f;
				this.pointer.rt.position = vector;
				this.HAAGFBPEFMA();
			}
			if (this.isFishGet && !this.isFishOnRod)
			{
				vector = this.pointer.rt.position;
				vector += this.IAMFCDGBMDP * Time.deltaTime;
				vector += this.ECKLGMKIOGB * Time.deltaTime;
				vector.z = 0f;
				this.pointer.rt.position = vector;
				this.HAAGFBPEFMA();
			}
			if (this.isFishOnRod)
			{
				vector = this.pointer.rt.position;
				Vector3 iamfcdgbmdp = this.IAMFCDGBMDP;
				Vector3 vector2 = this.getPointerPosition();
				float num = this.IBMCCLJKOFI / (this.PHCJGMBNBNN + 0.1f);
				this.ECKLGMKIOGB = Vector3.Lerp(this.ECKLGMKIOGB, iamfcdgbmdp, 3f * Time.deltaTime);
				this.ECKLGMKIOGB = this.ECKLGMKIOGB.normalized * this.NNGFCIOBEFJ * num * (1f - vector2.y);
				vector = this.pointer.rt.position;
				vector += this.ECKLGMKIOGB * Time.deltaTime;
				this.pointer.rt.position = vector;
				this.HAAGFBPEFMA();
				if (this.isSelect)
				{
					LocationLogic.getI.PBarStamina.position = num * 100f;
					Vector3 eulerAngles = this.rod3D_Object.transform.rotation.eulerAngles;
					eulerAngles.x = -LocationLogic.getI.PBarAdd_Up.position / 3f;
					eulerAngles.y = LocationLogic.getI.PBarAdd_Down.position / 10f;
					this.rod3D_Object.transform.rotation = Quaternion.Euler(eulerAngles);
					float num2 = (float)this.AFKGAMJEPKL / 1000f;
					num2 += num2 * (this.NKAHNAEPJCB / 100f) * num;
					float num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNGLPHCCGDF();
					float num4 = this.rodWeapons.LJCLFFINEHJ.MIMANMPNLPE.JLLJFKOGLHJ;
					num3 = num4 + num4 * (num3 / 100f);
					float a = 0f;
					float b = 0f;
					float num5 = num3 / num2;
					num5 = Mathf.Clamp(num5, 0f, 1f);
					if (OJCFBJGEEHL.IKGFHGKKCPG.MEACLDNOEFN())
					{
						a = 1.3f - LocationLogic.getI.PBarAdd_Up.position / 100f;
					}
					if (OJCFBJGEEHL.IKGFHGKKCPG.FNBMDPIKIIK())
					{
						b = 1.3f - LocationLogic.getI.PBarAdd_Down.position / 100f;
					}
					float num6 = Mathf.Max(a, b);
					float d = 80f * num6 * (1f - vector2.y);
					Vector3 normalized = (this.rrect.position - this.pointer.rt.position).normalized;
					vector = this.pointer.rt.position;
					vector += normalized * d * num5 * Time.deltaTime;
					this.pointer.rt.position = vector;
				}
			}
		}
		Vector2 pointerPosition2 = this.getPointerPosition();
		float deep = LocationLogic.getI.locData.getDeep(pointerPosition2.x, pointerPosition2.y, true);
		if (!this.isFishGet)
		{
			this.baitDeep = Mathf.Clamp(this.baitDeep, 0f, this.BICGFMMPIAI);
		}
		this.baitDeep = Mathf.Clamp(this.baitDeep, 0f, deep);
		if (this.pointer != null)
		{
			float num7 = this.BICGFMMPIAI - this.baitDeep;
			if (num7 < 0f)
			{
				this.pointer.ALFFGECKKDB = -num7 / 10f;
				return;
			}
			if (num7 <= 10f)
			{
				this.pointer.APCNMCOCPAE = this.MOMEOLNOLHP * num7 / 10f;
				if (num7 < 1f)
				{
					this.pointer.ALFFGECKKDB = 0.15f;
				}
				if (Mathf.Abs(this.pointer.APCNMCOCPAE) < 0.01f)
				{
					this.MOMEOLNOLHP = 1f;
					if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(50f))
					{
						this.MOMEOLNOLHP = -1f;
						return;
					}
				}
			}
			else
			{
				this.pointer.APCNMCOCPAE = 1f;
				this.pointer.ALFFGECKKDB = 0f;
			}
		}
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x001F80A8 File Offset: 0x001F62A8
	private void ABDONEGMGMA()
	{
		int num = 0;
		if (this.isSelect)
		{
			num = 1;
		}
		int num2 = num * 3 + this.frodid;
		this.btnImage.sprite = LocationGui.getI.rodsKeyImages[num2];
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x001F80E4 File Offset: 0x001F62E4
	public void RodProcess()
	{
		if (this.isFishTrapped)
		{
			return;
		}
		float num = this.IBMCCLJKOFI / (this.PHCJGMBNBNN + 0.1f);
		bool flag = false;
		if (OJCFBJGEEHL.IKGFHGKKCPG.MEACLDNOEFN())
		{
			this.KFPLLOLLMBL = 100f * (float)this.AFKGAMJEPKL / ((float)this.rodWeapons.NKNCNHGDMLF.MIMANMPNLPE.IBEIBAHKIAH * 1000f);
			flag = true;
			LocationLogic.getI.PBarAdd_Down.position = LocationLogic.getI.PBarAdd_Down.position - 30f * Time.deltaTime;
			this.CKNFCENJEGL = 120f;
		}
		else
		{
			this.KFPLLOLLMBL = 0f;
			this.CKNFCENJEGL = 0f;
		}
		if (OJCFBJGEEHL.IKGFHGKKCPG.FNBMDPIKIIK())
		{
			this.OHCNIOIFMAI = 100f * (float)this.AFKGAMJEPKL / ((float)this.rodWeapons.IIOHPBENEFI.MIMANMPNLPE.IBEIBAHKIAH * 1000f);
			flag = true;
			this.JMJKHCJIMEO = 120f;
			LocationLogic.getI.PBarAdd_Up.position = LocationLogic.getI.PBarAdd_Up.position - 30f * Time.deltaTime;
		}
		else
		{
			this.OHCNIOIFMAI = 0f;
			this.JMJKHCJIMEO = 0f;
		}
		this.KFPLLOLLMBL = Mathf.Clamp(this.KFPLLOLLMBL, 0f, 200f);
		this.OHCNIOIFMAI = Mathf.Clamp(this.OHCNIOIFMAI, 0f, 200f);
		float num2 = (LocationLogic.getI.PBar_Up.position < this.KFPLLOLLMBL) ? 4f : 0.8f;
		LocationLogic.getI.PBar_Up.position = Mathf.Lerp(LocationLogic.getI.PBar_Up.position, this.KFPLLOLLMBL, Time.deltaTime * num2);
		float num3 = (LocationLogic.getI.PBar_Down.position < this.OHCNIOIFMAI) ? 4f : 0.8f;
		LocationLogic.getI.PBar_Down.position = Mathf.Lerp(LocationLogic.getI.PBar_Down.position, this.OHCNIOIFMAI, Time.deltaTime * num3);
		LocationLogic.getI.PBarAdd_Up.position = Mathf.Lerp(LocationLogic.getI.PBarAdd_Up.position, this.CKNFCENJEGL, Time.deltaTime * 0.3f);
		LocationLogic.getI.PBarAdd_Down.position = Mathf.Lerp(LocationLogic.getI.PBarAdd_Down.position, this.JMJKHCJIMEO, Time.deltaTime * 0.3f);
		if (LocationLogic.getI.PBar_Up.position > 98f)
		{
			this.BGLLPMKNBCE = false;
			if (this.rodWeapons.NKNCNHGDMLF.LODGJCMEGAI.IBEIBAHKIAH < this.rodWeapons.IIOHPBENEFI.LODGJCMEGAI.IBEIBAHKIAH)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, this.rodWeapons.NKNCNHGDMLF.LPFKFNLHGBI);
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("spinbreak.ogg", 1f);
				this.rodWeapons.NKNCNHGDMLF.JGNIDDBNGGP = 500;
				this.rodWeapons.NKNCNHGDMLF = null;
				OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL("<color='#ff0000'>Вы сломали удочку</color>");
			}
			else
			{
				this.IGLABCEANOO();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
			return;
		}
		if (LocationLogic.getI.PBar_Down.position > 98f)
		{
			this.BGLLPMKNBCE = false;
			this.IGLABCEANOO();
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
			return;
		}
		if (flag)
		{
			this.IBMCCLJKOFI -= 10f * Time.deltaTime;
		}
		else if (this.NKAHNAEPJCB > 10f)
		{
			this.IBMCCLJKOFI += 2f * Time.deltaTime;
		}
		this.IBMCCLJKOFI = Mathf.Clamp(this.IBMCCLJKOFI, 0f, this.PHCJGMBNBNN);
		if (this.getPointerPosition().y < 0.05f)
		{
			this.isFishTrapped = true;
			this.isFishGet = false;
			this.isFishOnRod = false;
			this.BGLLPMKNBCE = false;
			this.IAMFCDGBMDP = Vector3.zero;
			this.ECKLGMKIOGB = Vector3.zero;
			this.AFKGAMJEPKL = 0;
			this.ELLDFINKBLP = 0f;
			this.NCEDJJAMNLA = 0f;
			this.PHCJGMBNBNN = 0f;
			this.isKlevFlag = false;
			base.StopCoroutine(this.MNPCLIHPGKN());
			base.StopCoroutine(this.DOCPHHJNKIF());
			if (this.pointer_Object != null)
			{
				UnityEngine.Object.Destroy(this.pointer_Object);
			}
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1130, this.frodid);
		}
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x001F85B9 File Offset: 0x001F67B9
	public bool HDEBIPPCHBK()
	{
		return this.KKENGLGEHPK;
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x001F85C1 File Offset: 0x001F67C1
	private void EHFPLKEINFO()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.MHFDIJGJGBJ().GJDOHJHDEMO();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.ABDONEGMGMA();
		this.isFishOnRod = false;
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06004311 RID: 17169 RVA: 0x001F85B9 File Offset: 0x001F67B9
	// (set) Token: 0x06004316 RID: 17174 RVA: 0x001F879C File Offset: 0x001F699C
	public bool BGLLPMKNBCE
	{
		get
		{
			return this.KKENGLGEHPK;
		}
		set
		{
			this.KKENGLGEHPK = value;
			this.anm.SetBool("inWater", this.KKENGLGEHPK);
			if (!this.KKENGLGEHPK)
			{
				base.StopCoroutine(this.MNPCLIHPGKN());
				base.StopCoroutine(this.DOCPHHJNKIF());
				if (this.pointer_Object != null)
				{
					UnityEngine.Object.Destroy(this.pointer_Object);
				}
				LocationLogic.getI.PBar_Up.position = 0f;
				LocationLogic.getI.PBar_Down.position = 0f;
				LocationLogic.getI.PBarAdd_Up.position = 0f;
				LocationLogic.getI.PBarAdd_Down.position = 0f;
				this.KFPLLOLLMBL = 0f;
				this.OHCNIOIFMAI = 0f;
				this.CKNFCENJEGL = 0f;
				this.JMJKHCJIMEO = 0f;
				this.isKlevProcess = false;
				this.isFishOnRod = false;
				this.isFishGet = false;
				this.isFishTrapped = false;
			}
		}
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x001F8600 File Offset: 0x001F6800
	public void JCLOFOLCEMP(HBPNMNGOFMA KADBECGIMPD)
	{
		this.AFKGAMJEPKL = KADBECGIMPD.IFDFHJLCHAE();
		string text = KADBECGIMPD.FDIDEGHPJPF();
		char[] array = new char[0];
		array[1] = '\u001e';
		this.PLMKACBEPFI = text.Split(array);
		this.ELLDFINKBLP = KADBECGIMPD.CGJIINADKNH();
		this.NCEDJJAMNLA = KADBECGIMPD.MOBPFEEAMKD();
		this.PHCJGMBNBNN = KADBECGIMPD.MOBPFEEAMKD();
		this.NKAHNAEPJCB = KADBECGIMPD.AILCEJFAMGN();
		this.OOEFFMLBEBG = KADBECGIMPD.DNGDPHIHLBG();
		this.IBMCCLJKOFI = this.PHCJGMBNBNN;
		if (this.otterType == 0)
		{
			if (this.rodWeapons.PFNCHEEEBKD.BBLEPPMMPIL("Image effects aren't supported on this device ({0})", "ShootWireframeModule").LOLBCAIEFMN())
			{
				string palfnhclkaj = this.rodWeapons.PFNCHEEEBKD.BBLEPPMMPIL("", "openPodsak").LEPDIDFPFBO();
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(palfnhclkaj, 651f);
			}
			this.pointer.ALFFGECKKDB = this.pointer.NDCMMOMKJEL() - 1524f;
		}
		this.isKlevFlag = false;
		if (this.isKlevProcess)
		{
			base.StopCoroutine(this.BMGOPAPCHGF());
		}
		base.StartCoroutine(this.BMGOPAPCHGF());
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x000EB372 File Offset: 0x000E9572
	public bool IsRaycastLocationValid(Vector2 FOMHLOJALEC, Camera IEBEDADFNCE)
	{
		return false;
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x001F871C File Offset: 0x001F691C
	public Vector2 NDJFJMLLNPO()
	{
		Vector2 vector = Vector2.zero;
		if (this.pointer != null)
		{
			vector = this.pointer.PKIDIALNCJF();
			vector.y = 1880f - vector.y;
		}
		return vector;
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x001F875D File Offset: 0x001F695D
	private void INDGOHJGCFN()
	{
		this.MIOPPKFNLDB = JLFJEGIPIMM.PKGMBFEMKGP().GJDOHJHDEMO();
		this.rrect = base.GetComponent<RectTransform>();
		this.anm = this.rod3D_Object.GetComponent<Animator>();
		this.ABDONEGMGMA();
		this.isFishOnRod = false;
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x001F889C File Offset: 0x001F6A9C
	public void HKOICPMLHNA(Vector2 DCCPCBLODIG)
	{
		if (this.pointer_Object != null)
		{
			RectTransform component = this.pointer_Object.GetComponent<RectTransform>();
			if (component != null)
			{
				component.parent = LocationGui.getI.backLockImage.rectTransform;
				Vector3 vector = new Vector3(DCCPCBLODIG.x * LocationGui.getI.backLockImage.rectTransform.rect.width, -DCCPCBLODIG.y * LocationGui.getI.backLockImage.rectTransform.rect.height, 1000f);
				vector += component.parent.position;
				component.position = vector;
			}
		}
	}

	// Token: 0x04000AA9 RID: 2729
	public int frodid;

	// Token: 0x04000AAA RID: 2730
	public BOIKJDICEMF.BGJKMCBHNAK rodWeapons;

	// Token: 0x04000AAB RID: 2731
	public int otterType;

	// Token: 0x04000AAC RID: 2732
	public RectTransform rrect;

	// Token: 0x04000AAD RID: 2733
	public GameObject rod3D_Object;

	// Token: 0x04000AAE RID: 2734
	public Animator anm;

	// Token: 0x04000AAF RID: 2735
	public Image btnImage;

	// Token: 0x04000AB0 RID: 2736
	public GameObject pointer_Object;

	// Token: 0x04000AB1 RID: 2737
	public PointerLogic pointer;

	// Token: 0x04000AB2 RID: 2738
	public RectTransform buttonRect;

	// Token: 0x04000AB3 RID: 2739
	public bool isKlevFlag;

	// Token: 0x04000AB4 RID: 2740
	public bool isKlevProcess;

	// Token: 0x04000AB5 RID: 2741
	public bool isFishGet;

	// Token: 0x04000AB6 RID: 2742
	public float baitDeep;

	// Token: 0x04000AB7 RID: 2743
	public int deepIndex;

	// Token: 0x04000AB8 RID: 2744
	public bool isFishOnRod;

	// Token: 0x04000AB9 RID: 2745
	public bool isFishTrapped;

	// Token: 0x04000ABA RID: 2746
	private int AFKGAMJEPKL;

	// Token: 0x04000ABB RID: 2747
	private string[] PLMKACBEPFI;

	// Token: 0x04000ABC RID: 2748
	private float ELLDFINKBLP;

	// Token: 0x04000ABD RID: 2749
	private float NCEDJJAMNLA;

	// Token: 0x04000ABE RID: 2750
	private float PHCJGMBNBNN;

	// Token: 0x04000ABF RID: 2751
	private float NKAHNAEPJCB;

	// Token: 0x04000AC0 RID: 2752
	private float OOEFFMLBEBG;

	// Token: 0x04000AC1 RID: 2753
	private float IBMCCLJKOFI;

	// Token: 0x04000AC2 RID: 2754
	private float KFPLLOLLMBL;

	// Token: 0x04000AC3 RID: 2755
	private float OHCNIOIFMAI;

	// Token: 0x04000AC4 RID: 2756
	private float CKNFCENJEGL;

	// Token: 0x04000AC5 RID: 2757
	private float JMJKHCJIMEO;

	// Token: 0x04000AC6 RID: 2758
	private Vector3 GBEIDPOCJBF = Vector3.zero;

	// Token: 0x04000AC7 RID: 2759
	public bool isSelect;

	// Token: 0x04000AC8 RID: 2760
	private Vector3 MIOPPKFNLDB = Vector3.zero;

	// Token: 0x04000AC9 RID: 2761
	private bool KKENGLGEHPK;

	// Token: 0x04000ACA RID: 2762
	private float NNGFCIOBEFJ;

	// Token: 0x04000ACB RID: 2763
	private Vector2 IDBBDOFMDII = Vector2.zero;

	// Token: 0x04000ACC RID: 2764
	private Vector3 IAMFCDGBMDP = Vector3.zero;

	// Token: 0x04000ACD RID: 2765
	private float MOMEOLNOLHP = 1f;

	// Token: 0x04000ACE RID: 2766
	private Vector3 ECKLGMKIOGB = Vector3.zero;
}
