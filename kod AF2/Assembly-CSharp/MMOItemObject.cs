using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000120 RID: 288
public class MMOItemObject : MonoBehaviour
{
	// Token: 0x06003B18 RID: 15128 RVA: 0x001AAB08 File Offset: 0x001A8D08
	private void OnMouseExit()
	{
		this.onMouseOver = false;
		this.FLABNMCLCED();
		Fisherman.getI.UserLookAtOff();
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x001AAB24 File Offset: 0x001A8D24
	private void Update()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(0f, 180f, 0f);
			float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position);
			this.canvas.gameObject.SetActive(num <= 3f);
			if (this.wpText != null)
			{
				string arg = "#a0d0a0";
				if (JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF < this.workpoints)
				{
					arg = "#a02000";
				}
				string str = string.Format("<color='{0}'> Очков работы: {1}</color>", arg, this.workpoints);
				string str2 = "";
				if (this.baseProf.IBEIBAHKIAH > 0)
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.baseProf.IBEIBAHKIAH);
					if (kdhoddmndfc != null)
					{
						str2 = string.Format(" <color='#a0a070'>Бонус от `{0}` </color>", kdhoddmndfc.KGBHELBLPMF(this.baseProf.ICJDPPOJINN));
						int num2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(this.baseProf.IBEIBAHKIAH) - this.baseProf.ICJDPPOJINN;
						if (num2 >= 0)
						{
							int num3 = (num2 + 1) * this.baseProf.NODLBGKEGPM;
							str2 = string.Format(" <color='#60ff60'>Бонус от `{0}` +{1}%</color>", kdhoddmndfc.KGBHELBLPMF(this.baseProf.ICJDPPOJINN), num3);
						}
					}
				}
				this.wpText.text = str + "\n" + str2;
			}
			if (this.profyText != null)
			{
				if (this.perkList.Count == 0)
				{
					this.profyText.text = "<color='#20a000'> Требований нет </color>";
				}
				if (this.perkList.Count > 0)
				{
					string text = "Требуются навыки:\n";
					foreach (IIBEEKCAAHK iibeekcaahk in this.perkList)
					{
						NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(iibeekcaahk.IBEIBAHKIAH);
						if (kdhoddmndfc2 != null)
						{
							string arg2 = "#20a000";
							if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(iibeekcaahk.IBEIBAHKIAH) < iibeekcaahk.ICJDPPOJINN)
							{
								arg2 = "#a02000";
							}
							text += string.Format("<color='{0}'> {1} ур {2}</color>\n", arg2, kdhoddmndfc2.KKEBDLGHBMN, iibeekcaahk.ICJDPPOJINN);
						}
						else
						{
							text = string.Concat(new object[]
							{
								text,
								"<color='#ffa000'>неизвестная профессия",
								iibeekcaahk,
								"</color>\n"
							});
						}
					}
					this.profyText.text = text;
				}
			}
		}
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x001AAE60 File Offset: 0x001A9060
	private void Start()
	{
		this.BEDEJJKHEPH.Clear();
		Renderer component = base.GetComponent<Renderer>();
		if (component != null && component.material.HasProperty("_isSelect"))
		{
			this.BEDEJJKHEPH.Add(component);
		}
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer.material.HasProperty("_isSelect"))
			{
				this.BEDEJJKHEPH.Add(renderer);
			}
		}
		this.onMouseOver = false;
		this.FLABNMCLCED();
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x001AAEEC File Offset: 0x001A90EC
	private void JGLAJDOIKNC()
	{
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1297f)
		{
			this.onMouseOver = false;
			Fisherman.getI.NADDOPFKIAC(base.transform.position + Vector3.up * 1987f);
		}
		this.FLABNMCLCED();
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x001AAF58 File Offset: 0x001A9158
	private void FLABNMCLCED()
	{
		float value = 0f;
		if (this.onMouseOver)
		{
			value = 1f;
		}
		foreach (Renderer renderer in this.BEDEJJKHEPH)
		{
			renderer.material.SetFloat("_isSelect", value);
		}
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x001AAFC8 File Offset: 0x001A91C8
	private void DAHCBHECNGE()
	{
		float value = 521f;
		if (this.onMouseOver)
		{
			value = 1324f;
		}
		foreach (Renderer renderer in this.BEDEJJKHEPH)
		{
			renderer.material.SetFloat("_rcIn.ogg", value);
		}
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x001AB038 File Offset: 0x001A9238
	private void PJHEGHHOJHJ()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(734f, 1936f, 1036f);
			float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position);
			this.canvas.gameObject.SetActive(num > 1963f);
			if (this.wpText != null)
			{
				string arg = "OfficeSittingLegCross";
				if (JBEHMPDDMME.PLGADNLAEGN().JBJFBDONEFF < this.workpoints)
				{
					arg = "WorkerPickaxe";
				}
				string str = string.Format("#ff6000", arg, this.workpoints);
				string str2 = " ";
				if (this.baseProf.IBEIBAHKIAH > 0)
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.baseProf.IBEIBAHKIAH);
					if (kdhoddmndfc != null)
					{
						str2 = string.Format("bone", kdhoddmndfc.KGBHELBLPMF(this.baseProf.ICJDPPOJINN));
						int num2 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FOACIAGMAPD(this.baseProf.KEHIFGILLJA()) - this.baseProf.NLHKFMMDMMK();
						if (num2 >= 0)
						{
							int num3 = (num2 + 1) * this.baseProf.NFCDJLJNDLO();
							str2 = string.Format("error", kdhoddmndfc.IIEACLAECEI(this.baseProf.ICJDPPOJINN), num3);
						}
					}
				}
				this.wpText.text = str + "MotorbikeHeadstand" + str2;
			}
			if (this.profyText != null)
			{
				if (this.perkList.Count == 0)
				{
					this.profyText.text = "_LightPosition";
				}
				if (this.perkList.Count > 1)
				{
					string text = "SoccerKeeperStrafeLeft";
					foreach (IIBEEKCAAHK iibeekcaahk in this.perkList)
					{
						NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.JEFCOLDKFPI(iibeekcaahk.KEHIFGILLJA());
						if (kdhoddmndfc2 != null)
						{
							string arg2 = "cash.ogg";
							if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FOACIAGMAPD(iibeekcaahk.KEHIFGILLJA()) < iibeekcaahk.KMGAHCANELI())
							{
								arg2 = "teech_perk";
							}
							text += string.Format("wpn_add/base", arg2, kdhoddmndfc2.KKEBDLGHBMN, iibeekcaahk.ICJDPPOJINN);
						}
						else
						{
							object[] array = new object[7];
							array[0] = text;
							array[0] = "invn_rec10";
							array[6] = iibeekcaahk;
							array[4] = "wpn_chair3";
							text = string.Concat(array);
						}
					}
					this.profyText.text = text;
				}
			}
		}
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x001AB334 File Offset: 0x001A9534
	private void KEPJILDJIMB()
	{
		float value = 1992f;
		if (this.onMouseOver)
		{
			value = 23f;
		}
		foreach (Renderer renderer in this.BEDEJJKHEPH)
		{
			renderer.material.SetFloat("", value);
		}
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x001AB3A4 File Offset: 0x001A95A4
	private void BEFMBCBPEMF()
	{
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1063f)
		{
			this.onMouseOver = true;
			Fisherman.getI.JONIILIECGN(base.transform.position + Vector3.up * 1978f);
		}
		this.HNBCLECNJGO();
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x001AB410 File Offset: 0x001A9610
	private void DJAEKNJEEAD()
	{
		float value = 1757f;
		if (this.onMouseOver)
		{
			value = 247f;
		}
		foreach (Renderer renderer in this.BEDEJJKHEPH)
		{
			renderer.material.SetFloat("WizardEyeBeam", value);
		}
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x001AB480 File Offset: 0x001A9680
	private void PBDMGJNFIED()
	{
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1300f)
		{
			this.onMouseOver = true;
			Fisherman.getI.NADDOPFKIAC(base.transform.position + Vector3.up * 312f);
		}
		this.FLABNMCLCED();
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x001AB4EC File Offset: 0x001A96EC
	private void HNBCLECNJGO()
	{
		float value = 1005f;
		if (this.onMouseOver)
		{
			value = 1247f;
		}
		foreach (Renderer renderer in this.BEDEJJKHEPH)
		{
			renderer.material.SetFloat("#02C85F", value);
		}
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x001AB55C File Offset: 0x001A975C
	public void init()
	{
		this.langName = JNBICAJIJMM.IKGFHGKKCPG.OFEHFLGLMKN(this.itemtype);
		if (this.canvas != null)
		{
			this.canvas.worldCamera = Camera.main;
			if (this.textName != null)
			{
				this.textName.text = this.langName;
			}
		}
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x001AB5BC File Offset: 0x001A97BC
	private void FIJKDFIMELM()
	{
		this.BEDEJJKHEPH.Clear();
		Renderer component = base.GetComponent<Renderer>();
		if (component != null && component.material.HasProperty("SoccerStartKick"))
		{
			this.BEDEJJKHEPH.Add(component);
		}
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer.material.HasProperty("Swim"))
			{
				this.BEDEJJKHEPH.Add(renderer);
			}
		}
		this.onMouseOver = false;
		this.DJAEKNJEEAD();
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x001AB648 File Offset: 0x001A9848
	private void OnMouseEnter()
	{
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 15f)
		{
			this.onMouseOver = true;
			Fisherman.getI.UserLookAtOn(base.transform.position + Vector3.up * 0.5f);
		}
		this.FLABNMCLCED();
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x001AB6B1 File Offset: 0x001A98B1
	private void GDAMBAKKCJC()
	{
		this.onMouseOver = true;
		this.KEPJILDJIMB();
		Fisherman.getI.JHOKIGHFGKK();
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x001AB6CA File Offset: 0x001A98CA
	private void BHHJMHIHKPA()
	{
		this.onMouseOver = true;
		this.DJAEKNJEEAD();
		Fisherman.getI.UserLookAtOff();
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x001AB6E4 File Offset: 0x001A98E4
	private void OBJCOJEHLBE()
	{
		this.BEDEJJKHEPH.Clear();
		Renderer component = base.GetComponent<Renderer>();
		if (component != null && component.material.HasProperty("crft_from"))
		{
			this.BEDEJJKHEPH.Add(component);
		}
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer.material.HasProperty(" : "))
			{
				this.BEDEJJKHEPH.Add(renderer);
			}
		}
		this.onMouseOver = true;
		this.HNBCLECNJGO();
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x001AB770 File Offset: 0x001A9970
	private void BOAJJAKEMLH()
	{
		if (this.canvas != null)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = this.canvas.transform.position.y;
			this.canvas.transform.LookAt(position);
			this.canvas.transform.Rotate(1367f, 542f, 1757f);
			float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position);
			this.canvas.gameObject.SetActive(num > 707f);
			if (this.wpText != null)
			{
				string arg = "StShopWindow";
				if (JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF < this.workpoints)
				{
					arg = "knopje.wav";
				}
				string str = string.Format("simple", arg, this.workpoints);
				string str2 = "http://af-2.ru/?q=store";
				if (this.baseProf.IBEIBAHKIAH > 0)
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.baseProf.KEHIFGILLJA());
					if (kdhoddmndfc != null)
					{
						str2 = string.Format("Hidden/Amplify Color/BlendCache", kdhoddmndfc.OBOKLCHDOGM(this.baseProf.ICJDPPOJINN));
						int num2 = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.FOACIAGMAPD(this.baseProf.KMIOLLENCOL()) - this.baseProf.NLHKFMMDMMK();
						if (num2 >= 1)
						{
							int num3 = (num2 + 1) * this.baseProf.CJKILDPJCFJ();
							str2 = string.Format("ClimbIdle", kdhoddmndfc.DDFCFOHNHNN(this.baseProf.NLHKFMMDMMK()), num3);
						}
					}
				}
				this.wpText.text = str + "FireBreath" + str2;
			}
			if (this.profyText != null)
			{
				if (this.perkList.Count == 0)
				{
					this.profyText.text = "Label";
				}
				if (this.perkList.Count > 1)
				{
					string text = "****** locscount=";
					foreach (IIBEEKCAAHK iibeekcaahk in this.perkList)
					{
						NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(iibeekcaahk.IBEIBAHKIAH);
						if (kdhoddmndfc2 != null)
						{
							string arg2 = "Criticals";
							if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FOACIAGMAPD(iibeekcaahk.KMIOLLENCOL()) < iibeekcaahk.KMGAHCANELI())
							{
								arg2 = "DITHER_ON";
							}
							text += string.Format("Crouch180", arg2, kdhoddmndfc2.KKEBDLGHBMN, iibeekcaahk.KMGAHCANELI());
						}
						else
						{
							object[] array = new object[5];
							array[0] = text;
							array[1] = "_ColorBuffer";
							array[3] = iibeekcaahk;
							array[2] = "MotorbikeHandstand";
							text = string.Concat(array);
						}
					}
					this.profyText.text = text;
				}
			}
		}
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x001ABA6C File Offset: 0x001A9C6C
	private void AHDKFACDDOO()
	{
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1664f)
		{
			this.onMouseOver = false;
			Fisherman.getI.LGAHCAIKGHN(base.transform.position + Vector3.up * 198f);
		}
		this.HNBCLECNJGO();
	}

	// Token: 0x0400084D RID: 2125
	public Canvas canvas;

	// Token: 0x0400084E RID: 2126
	public Text textName;

	// Token: 0x0400084F RID: 2127
	public Text wpText;

	// Token: 0x04000850 RID: 2128
	public Text profyText;

	// Token: 0x04000851 RID: 2129
	public int pointId;

	// Token: 0x04000852 RID: 2130
	public int itemtype;

	// Token: 0x04000853 RID: 2131
	public int workpoints;

	// Token: 0x04000854 RID: 2132
	public IIBEEKCAAHK qtask = IIBEEKCAAHK.ECOFBCMPIDO;

	// Token: 0x04000855 RID: 2133
	public IIBEEKCAAHK baseProf = IIBEEKCAAHK.ECOFBCMPIDO;

	// Token: 0x04000856 RID: 2134
	public List<IIBEEKCAAHK> perkList = new List<IIBEEKCAAHK>();

	// Token: 0x04000857 RID: 2135
	public string langName = "---";

	// Token: 0x04000858 RID: 2136
	public bool onMouseOver;

	// Token: 0x04000859 RID: 2137
	private List<Renderer> BEDEJJKHEPH = new List<Renderer>();
}
