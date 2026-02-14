using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000244 RID: 580
public class PanelParam : MonoBehaviour
{
	// Token: 0x060084F1 RID: 34033 RVA: 0x003E2532 File Offset: 0x003E0732
	public void paramset()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084F2 RID: 34034 RVA: 0x003E2532 File Offset: 0x003E0732
	public void AGIEAOANJBJ()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084F3 RID: 34035 RVA: 0x003E2532 File Offset: 0x003E0732
	public void PCDIPOEEFMB()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084F4 RID: 34036 RVA: 0x003E2540 File Offset: 0x003E0740
	private void PJHEGHHOJHJ()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 758f;
			this.pbar.max = 959f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.ILKLIOLCMHP(599f, 509f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 549f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("Cloth_05_00.wav", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.BEGMLDJEIHB())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(424f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 730f;
			this.pbar.max = 1191f;
			this.textNumber.text = LocNewLogic.getI.ws.JIBKNGPLKEB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.BADFDJEMGJO(1088f, 1854f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1273f, 1046f, (float)Mathf.RoundToInt((float)num) / 1053f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.MGAMBBLEHBP());
	}

	// Token: 0x060084F5 RID: 34037 RVA: 0x003E27D7 File Offset: 0x003E09D7
	public void PEJMJEPBKOO()
	{
		this.DEFNNEGPNEI = 1377f;
	}

	// Token: 0x060084F6 RID: 34038 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool BLMDPIDIDHG()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x060084F7 RID: 34039 RVA: 0x003E2532 File Offset: 0x003E0732
	public void CDKOLOEJMGB()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084F8 RID: 34040 RVA: 0x003E2532 File Offset: 0x003E0732
	public void DGHLOGDDFOK()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084F9 RID: 34041 RVA: 0x003E2532 File Offset: 0x003E0732
	public void HPELHHENDDF()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084FA RID: 34042 RVA: 0x003E27FD File Offset: 0x003E09FD
	public bool OEEMPMHNBGJ()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel >= Time.time;
	}

	// Token: 0x060084FB RID: 34043 RVA: 0x003E2818 File Offset: 0x003E0A18
	private void BOAJJAKEMLH()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1419f;
			this.pbar.max = 1718f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.CGILNHGLMJI(1722f, 333f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 661f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("NadeThrow", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP();
			if (this.KDJNNDNANGK())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(171f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 184f;
			this.pbar.max = 1020f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.OJLJMPCLDPC(605f, 988f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1399f, 1077f, (float)Mathf.RoundToInt((float)num) / 664f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.ILINGCIECMG());
	}

	// Token: 0x060084FC RID: 34044 RVA: 0x003E2AB0 File Offset: 0x003E0CB0
	private void CDLDCKAHLHC()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 40f;
			this.pbar.max = 370f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.ENHIHPLDILL(820f, 1960f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1120f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG();
			this.textNumber.text = string.Format("http://www.root-motion.com/finalikdox/html/page9.html", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.KDJNNDNANGK())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(96f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 571f;
			this.pbar.max = 380f;
			this.textNumber.text = LocNewLogic.getI.ws.MONBBLNMFBM();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.ILINGCIECMG())
			{
				LocNewLogic.getI.ws.BADFDJEMGJO(981f, 82f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(769f, 1917f, (float)Mathf.RoundToInt((float)num) / 372f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.MGAMBBLEHBP());
	}

	// Token: 0x060084FD RID: 34045 RVA: 0x003E2D48 File Offset: 0x003E0F48
	private void IOGAKGCADBL()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1145f;
			this.pbar.max = 621f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.CGILNHGLMJI(452f, 1737f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 681f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG();
			this.textNumber.text = string.Format("[ACTk] ", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(46f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1149f;
			this.pbar.max = 1045f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.NEJOEDFMMBJ())
			{
				LocNewLogic.getI.ws.NBFJPOPOBLA(425f, 379f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(317f, 231f, (float)Mathf.RoundToInt((float)num) / 883f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.OEEMPMHNBGJ());
	}

	// Token: 0x060084FE RID: 34046 RVA: 0x003E2532 File Offset: 0x003E0732
	public void KLICGOFAICB()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x060084FF RID: 34047 RVA: 0x003E2FE0 File Offset: 0x003E11E0
	private void LIOCDEICIFD()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 817f;
			this.pbar.max = 901f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.BEGMLDJEIHB())
			{
				LocNewLogic.getI.ws.ENHIHPLDILL(1376f, 108f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 460f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("FistPump2", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.OEMHALJOOND(445f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 130f;
			this.pbar.max = 1101f;
			this.textNumber.text = LocNewLogic.getI.ws.NMDLONOBDKJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(1678f, 1418f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1847f, 1950f, (float)Mathf.RoundToInt((float)num) / 279f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.PAIKGDDMADK());
	}

	// Token: 0x06008500 RID: 34048 RVA: 0x003E3278 File Offset: 0x003E1478
	private void PFPPDNHLCCA()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 564f;
			this.pbar.max = 996f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.OEMHALJOOND(378f, 789f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1655f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG();
			this.textNumber.text = string.Format("ArmFlex5", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP();
			if (this.NEJOEDFMMBJ())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(1545f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1569f;
			this.pbar.max = 498f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.NBFJPOPOBLA(766f, 784f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(995f, 1224f, (float)Mathf.RoundToInt((float)num) / 1867f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.LAGMIAHECFB());
	}

	// Token: 0x06008501 RID: 34049 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool DNKHIGNFBLC()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x06008502 RID: 34050 RVA: 0x003E3510 File Offset: 0x003E1710
	private void INKGAFANFIB()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 752f;
			this.pbar.max = 575f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.setParamsDeep(1680f, 1486f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1024f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("Backward Stand", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(47f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 765f;
			this.pbar.max = 617f;
			this.textNumber.text = LocNewLogic.getI.ws.getFricText();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.OJLJMPCLDPC(607f, 939f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(497f, 1506f, (float)Mathf.RoundToInt((float)num) / 718f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.GPJODPBAFNM());
	}

	// Token: 0x06008503 RID: 34051 RVA: 0x003E37A8 File Offset: 0x003E19A8
	private void MNAHGMDDHCA()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1117f;
			this.pbar.max = 807f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.HKJMHHOJNFE(1084f, 397f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1909f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(1469f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1511f;
			this.pbar.max = 1445f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(423f, 1979f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(1011f, 387f, (float)Mathf.RoundToInt((float)num) / 690f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.GPJODPBAFNM());
	}

	// Token: 0x06008504 RID: 34052 RVA: 0x003E2532 File Offset: 0x003E0732
	public void DKLMEPAOBEI()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008505 RID: 34053 RVA: 0x003E3A40 File Offset: 0x003E1C40
	private void KBMKHLDOIKP()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 843f;
			this.pbar.max = 1672f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(311f, 1793f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1872f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("D", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.CGILNHGLMJI(1765f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1335f;
			this.pbar.max = 1389f;
			this.textNumber.text = LocNewLogic.getI.ws.HCANJFBBKAJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(1184f, 957f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
				float z = Mathf.Lerp(954f, 654f, (float)Mathf.RoundToInt((float)num) / 1969f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.GPJODPBAFNM());
	}

	// Token: 0x06008506 RID: 34054 RVA: 0x003E3CD8 File Offset: 0x003E1ED8
	private void DFFOEGHGPGP()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1522f;
			this.pbar.max = 254f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(256f, 783f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1195f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG();
			this.textNumber.text = string.Format("[ACTk] WallHack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.OKNFPACNGLG())
			{
				LocNewLogic.getI.ws.setParamsDeep(1252f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 700f;
			this.pbar.max = 490f;
			this.textNumber.text = LocNewLogic.getI.ws.ENCLLABMMHP();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.NEJOEDFMMBJ())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(1351f, 59f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1262f, 49f, (float)Mathf.RoundToInt((float)num) / 96f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.NEJOEDFMMBJ());
	}

	// Token: 0x06008507 RID: 34055 RVA: 0x003E3F70 File Offset: 0x003E2170
	private void Update()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 10f;
			this.pbar.max = 70f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.setParamsDeep(10f, 70f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 10f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("{0:f2}", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.setParamsDeep(30f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 0f;
			this.pbar.max = 21f;
			this.textNumber.text = LocNewLogic.getI.ws.getFricText();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.setParamsFric(0f, 21f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(180f, 0f, (float)Mathf.RoundToInt((float)num) / 21f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.HKPAEGGJNGG);
	}

	// Token: 0x06008508 RID: 34056 RVA: 0x003E2532 File Offset: 0x003E0732
	public void NLJPFKEEDAM()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008509 RID: 34057 RVA: 0x003E2532 File Offset: 0x003E0732
	public void NJHJJMNBKHO()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600850A RID: 34058 RVA: 0x003E4208 File Offset: 0x003E2408
	private void KMLNBHIIGKH()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1263f;
			this.pbar.max = 647f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.ENHIHPLDILL(448f, 1270f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 899f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("maxspd", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(876f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 516f;
			this.pbar.max = 1647f;
			this.textNumber.text = LocNewLogic.getI.ws.NMDLONOBDKJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.KDJNNDNANGK())
			{
				LocNewLogic.getI.ws.IACFDFONLFN(1833f, 1938f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(160f, 273f, (float)Mathf.RoundToInt((float)num) / 167f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.OKNFPACNGLG());
	}

	// Token: 0x0600850B RID: 34059 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool LDDCGIADNLC()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x0600850C RID: 34060 RVA: 0x003E44A0 File Offset: 0x003E26A0
	private void HAIMGCDKPDC()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1156f;
			this.pbar.max = 197f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.POELGPOCLLE(933f, 143f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 803f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH;
			this.textNumber.text = string.Format("", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP();
			if (this.OKNFPACNGLG())
			{
				LocNewLogic.getI.ws.BCFOIDHNFOP(1027f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1644f;
			this.pbar.max = 1827f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(1791f, 1225f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1574f, 1904f, (float)Mathf.RoundToInt((float)num) / 36f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.ILINGCIECMG());
	}

	// Token: 0x0600850D RID: 34061 RVA: 0x003E2532 File Offset: 0x003E0732
	public void EKJJCKINJFK()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600850E RID: 34062 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool CAJBOBMJALI()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x0600850F RID: 34063 RVA: 0x003E4737 File Offset: 0x003E2937
	public void GHGEFNDCINL()
	{
		this.DEFNNEGPNEI = 1549f;
	}

	// Token: 0x06008510 RID: 34064 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool MGAMBBLEHBP()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06008511 RID: 34065 RVA: 0x003E27FD File Offset: 0x003E09FD
	public bool HKPAEGGJNGG
	{
		get
		{
			return this.DEFNNEGPNEI + this.timeShowPanel >= Time.time;
		}
	}

	// Token: 0x06008512 RID: 34066 RVA: 0x003E4744 File Offset: 0x003E2944
	private void OPDCJCFMIPE()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1344f;
			this.pbar.max = 643f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.HKJMHHOJNFE(1281f, 255f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 578f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("---", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(1694f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1369f;
			this.pbar.max = 1250f;
			this.textNumber.text = LocNewLogic.getI.ws.HCANJFBBKAJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.IACFDFONLFN(1094f, 361f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(685f, 537f, (float)Mathf.RoundToInt((float)num) / 1610f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.PAIKGDDMADK());
	}

	// Token: 0x06008513 RID: 34067 RVA: 0x003E49DC File Offset: 0x003E2BDC
	private void PFNOEACNHON()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1036f;
			this.pbar.max = 1873f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(1572f, 1663f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 354f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("IdleTyping", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.ILINGCIECMG())
			{
				LocNewLogic.getI.ws.BCFOIDHNFOP(640f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1592f;
			this.pbar.max = 94f;
			this.textNumber.text = LocNewLogic.getI.ws.JIBKNGPLKEB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.OKNFPACNGLG())
			{
				LocNewLogic.getI.ws.OJLJMPCLDPC(1398f, 1688f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
				float z = Mathf.Lerp(1789f, 1169f, (float)Mathf.RoundToInt((float)num) / 1164f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.DNKHIGNFBLC());
	}

	// Token: 0x06008514 RID: 34068 RVA: 0x003E4C74 File Offset: 0x003E2E74
	private void BJOICAKCPLI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 208f;
			this.pbar.max = 1678f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(536f, 1178f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1351f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG();
			this.textNumber.text = string.Format("gi_nlheader2", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.setParamsDeep(918f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 264f;
			this.pbar.max = 964f;
			this.textNumber.text = LocNewLogic.getI.ws.NIDLLNKHOCB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(24f, 1695f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1665f, 876f, (float)Mathf.RoundToInt((float)num) / 467f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.PAIKGDDMADK());
	}

	// Token: 0x06008515 RID: 34069 RVA: 0x003E4F0B File Offset: 0x003E310B
	public void DFKDBEHLPOL()
	{
		this.DEFNNEGPNEI = 501f;
	}

	// Token: 0x06008516 RID: 34070 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool GPJODPBAFNM()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x06008517 RID: 34071 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool PAIKGDDMADK()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x06008518 RID: 34072 RVA: 0x003E2532 File Offset: 0x003E0732
	public void DCPKFMMDIOH()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008519 RID: 34073 RVA: 0x003E2532 File Offset: 0x003E0732
	public void BCGBHIKCCLI()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600851A RID: 34074 RVA: 0x003E4F18 File Offset: 0x003E3118
	private void HCDJABMBDFF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 552f;
			this.pbar.max = 1931f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.setParamsDeep(1542f, 353f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 26f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("Auktree.xml", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.OEMHALJOOND(1777f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1119f;
			this.pbar.max = 1733f;
			this.textNumber.text = LocNewLogic.getI.ws.NIDLLNKHOCB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.HEOEEBEDDNN(71f, 433f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1983f, 1847f, (float)Mathf.RoundToInt((float)num) / 1496f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.ILINGCIECMG());
	}

	// Token: 0x0600851B RID: 34075 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool NEJOEDFMMBJ()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x0600851C RID: 34076 RVA: 0x003E51B0 File Offset: 0x003E33B0
	private void FJEEADNCKAG()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1777f;
			this.pbar.max = 118f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(1480f, 329f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 662f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("eye", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.HKJMHHOJNFE(224f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1378f;
			this.pbar.max = 1897f;
			this.textNumber.text = LocNewLogic.getI.ws.NIDLLNKHOCB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.OJLJMPCLDPC(1247f, 412f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(234f, 1418f, (float)Mathf.RoundToInt((float)num) / 1126f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.BLMDPIDIDHG());
	}

	// Token: 0x0600851D RID: 34077 RVA: 0x003E5448 File Offset: 0x003E3648
	private void DKOIOBMMAGN()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1717f;
			this.pbar.max = 1894f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.JMFGLFEECFE(1613f, 248f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1651f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG();
			this.textNumber.text = string.Format("_RgbTex", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP();
			if (this.LAGMIAHECFB())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(93f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 653f;
			this.pbar.max = 1037f;
			this.textNumber.text = LocNewLogic.getI.ws.HCANJFBBKAJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.setParamsFric(1632f, 1292f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1311f, 529f, (float)Mathf.RoundToInt((float)num) / 1013f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.BEGMLDJEIHB());
	}

	// Token: 0x0600851E RID: 34078 RVA: 0x003E2532 File Offset: 0x003E0732
	public void LOLMAOHLGFN()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600851F RID: 34079 RVA: 0x003E2532 File Offset: 0x003E0732
	public void KNKDNGBKAGH()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008520 RID: 34080 RVA: 0x003E56E0 File Offset: 0x003E38E0
	private void JIBKGOFOPHJ()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 711f;
			this.pbar.max = 1874f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.POELGPOCLLE(1695f, 1079f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1799f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH;
			this.textNumber.text = string.Format("PistolInstant", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(1922f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 944f;
			this.pbar.max = 295f;
			this.textNumber.text = LocNewLogic.getI.ws.ENCLLABMMHP();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.HEOEEBEDDNN(1146f, 624f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(39f, 952f, (float)Mathf.RoundToInt((float)num) / 1033f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.NEJOEDFMMBJ());
	}

	// Token: 0x06008521 RID: 34081 RVA: 0x003E5978 File Offset: 0x003E3B78
	private void LMMDHJJJNJO()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 515f;
			this.pbar.max = 1266f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.OKNFPACNGLG())
			{
				LocNewLogic.getI.ws.setParamsDeep(598f, 766f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 527f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG();
			this.textNumber.text = string.Format("{0}", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA;
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(398f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 726f;
			this.pbar.max = 200f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.KOFMLPMNMGM(1683f, 232f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(370f, 1945f, (float)Mathf.RoundToInt((float)num) / 360f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.OEEMPMHNBGJ());
	}

	// Token: 0x06008522 RID: 34082 RVA: 0x003E5C10 File Offset: 0x003E3E10
	private void JPHLMNIMDHH()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 985f;
			this.pbar.max = 1901f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(423f, 91f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1479f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG();
			this.textNumber.text = string.Format("\n", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.OEMHALJOOND(529f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 259f;
			this.pbar.max = 688f;
			this.textNumber.text = LocNewLogic.getI.ws.HCANJFBBKAJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.BADFDJEMGJO(1227f, 1072f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1158f, 160f, (float)Mathf.RoundToInt((float)num) / 1304f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.DNKHIGNFBLC());
	}

	// Token: 0x06008523 RID: 34083 RVA: 0x003E27FD File Offset: 0x003E09FD
	public bool BEGMLDJEIHB()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel >= Time.time;
	}

	// Token: 0x06008524 RID: 34084 RVA: 0x003E5EA7 File Offset: 0x003E40A7
	public void KGGLGPBAMLN()
	{
		this.DEFNNEGPNEI = 971f;
	}

	// Token: 0x06008525 RID: 34085 RVA: 0x003E5EB4 File Offset: 0x003E40B4
	public void EADLDDPGLII()
	{
		this.DEFNNEGPNEI = 718f;
	}

	// Token: 0x06008526 RID: 34086 RVA: 0x003E2532 File Offset: 0x003E0732
	public void GJMOEJDLANC()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008527 RID: 34087 RVA: 0x003E5EC4 File Offset: 0x003E40C4
	private void MFHGOLNLAAF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 310f;
			this.pbar.max = 895f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.CGILNHGLMJI(911f, 213f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1811f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("SkateboardKickPush", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(666f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1748f;
			this.pbar.max = 1965f;
			this.textNumber.text = LocNewLogic.getI.ws.MONBBLNMFBM();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().ENMACOFAHKG();
			if (this.DNKHIGNFBLC())
			{
				LocNewLogic.getI.ws.setParamsFric(554f, 236f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1002f, 620f, (float)Mathf.RoundToInt((float)num) / 1479f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.CAJBOBMJALI());
	}

	// Token: 0x06008529 RID: 34089 RVA: 0x003E27FD File Offset: 0x003E09FD
	public bool LAGMIAHECFB()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel >= Time.time;
	}

	// Token: 0x0600852A RID: 34090 RVA: 0x003E6170 File Offset: 0x003E4370
	private void DPGECEOMHNM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 464f;
			this.pbar.max = 702f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.CGILNHGLMJI(1899f, 1345f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1475f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG();
			this.textNumber.text = string.Format("GestureCrowdPump", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(393f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 653f;
			this.pbar.max = 1735f;
			this.textNumber.text = LocNewLogic.getI.ws.NMDLONOBDKJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.NBFJPOPOBLA(1003f, 199f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(164f, 888f, (float)Mathf.RoundToInt((float)num) / 1147f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.CAJBOBMJALI());
	}

	// Token: 0x0600852B RID: 34091 RVA: 0x003E6408 File Offset: 0x003E4608
	private void PMKOAHMNBBG()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1306f;
			this.pbar.max = 972f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.ENHIHPLDILL(480f, 1957f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1268f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("_rcIn.ogg", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.KDJNNDNANGK())
			{
				LocNewLogic.getI.ws.IDIMACNBHAI(1782f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1484f;
			this.pbar.max = 512f;
			this.textNumber.text = LocNewLogic.getI.ws.ENCLLABMMHP();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.KOFMLPMNMGM(1487f, 1610f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(627f, 434f, (float)Mathf.RoundToInt((float)num) / 1377f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.PAIKGDDMADK());
	}

	// Token: 0x0600852C RID: 34092 RVA: 0x003E66A0 File Offset: 0x003E48A0
	private void PNBGJBMJLFM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1293f;
			this.pbar.max = 1534f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.BEGMLDJEIHB())
			{
				LocNewLogic.getI.ws.CMKFKNAOACN(611f, 1519f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1846f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("UnityEngine.Vector4", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP();
			if (this.BEGMLDJEIHB())
			{
				LocNewLogic.getI.ws.CMKFKNAOACN(826f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1307f;
			this.pbar.max = 807f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.BEODKENAKLP(1086f, 394f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1149f, 1037f, (float)Mathf.RoundToInt((float)num) / 331f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.PAIKGDDMADK());
	}

	// Token: 0x0600852D RID: 34093 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool OKNFPACNGLG()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x0600852E RID: 34094 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool ILINGCIECMG()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x0600852F RID: 34095 RVA: 0x003E27E4 File Offset: 0x003E09E4
	public bool KDJNNDNANGK()
	{
		return this.DEFNNEGPNEI + this.timeShowPanel < Time.time;
	}

	// Token: 0x06008530 RID: 34096 RVA: 0x003E2532 File Offset: 0x003E0732
	public void DALIIFOAMPA()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008531 RID: 34097 RVA: 0x003E6937 File Offset: 0x003E4B37
	public void OFF()
	{
		this.DEFNNEGPNEI = 0f;
	}

	// Token: 0x06008532 RID: 34098 RVA: 0x003E6944 File Offset: 0x003E4B44
	private void KJJEEMEHGBF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 743f;
			this.pbar.max = 1933f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.BLMDPIDIDHG())
			{
				LocNewLogic.getI.ws.BCFOIDHNFOP(1455f, 1246f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1831f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE();
			this.textNumber.text = string.Format("SkateboardIdle", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.setParamsDeep(1277f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 505f;
			this.pbar.max = 721f;
			this.textNumber.text = LocNewLogic.getI.ws.JIBKNGPLKEB();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.LDDCGIADNLC())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(734f, 1706f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1247f, 106f, (float)Mathf.RoundToInt((float)num) / 1794f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.MGAMBBLEHBP());
	}

	// Token: 0x06008533 RID: 34099 RVA: 0x003E6BDC File Offset: 0x003E4DDC
	private void FPLNDDMFFKG()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 474f;
			this.pbar.max = 1778f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.HKPAEGGJNGG)
			{
				LocNewLogic.getI.ws.ILKLIOLCMHP(1976f, 166f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 225f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("Idle Feed Throw", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.PDNLEAPAGGC(1546f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1931f;
			this.pbar.max = 1682f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ;
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.HEOEEBEDDNN(1233f, 447f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
				float z = Mathf.Lerp(1163f, 1992f, (float)Mathf.RoundToInt((float)num) / 1923f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.BEGMLDJEIHB());
	}

	// Token: 0x06008534 RID: 34100 RVA: 0x003E6E74 File Offset: 0x003E5074
	private void KEBDEJIAODF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1705f;
			this.pbar.max = 1609f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA;
			if (this.KDJNNDNANGK())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(651f, 344f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 378f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("_FogOfWar", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.PAIKGDDMADK())
			{
				LocNewLogic.getI.ws.BBCLOPGIAMP(554f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().KKLEBEEGGDG(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 345f;
			this.pbar.max = 24f;
			this.textNumber.text = LocNewLogic.getI.ws.NMDLONOBDKJ();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG();
			if (this.ILINGCIECMG())
			{
				LocNewLogic.getI.ws.AIDCEKKPMIK(1536f, 1777f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ);
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
				float z = Mathf.Lerp(320f, 1013f, (float)Mathf.RoundToInt((float)num) / 853f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.LAGMIAHECFB());
	}

	// Token: 0x06008535 RID: 34101 RVA: 0x003E2532 File Offset: 0x003E0732
	public void GKFJKHJIKMK()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008536 RID: 34102 RVA: 0x003E710B File Offset: 0x003E530B
	public void MBIEIFOCJFA()
	{
		this.DEFNNEGPNEI = 1383f;
	}

	// Token: 0x06008537 RID: 34103 RVA: 0x003E2532 File Offset: 0x003E0732
	public void OEIJIFBDBFJ()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x06008538 RID: 34104 RVA: 0x003E7118 File Offset: 0x003E5318
	private void MEFOGCFJBNE()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 1660f;
			this.pbar.max = 1512f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.CAJBOBMJALI())
			{
				LocNewLogic.getI.ws.ENHIHPLDILL(872f, 1700f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 1647f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().KFEPCNBDMIH;
			this.textNumber.text = string.Format("RunBackRight", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA;
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.HKJMHHOJNFE(1168f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 1079f;
			this.pbar.max = 1831f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.OKNFPACNGLG())
			{
				LocNewLogic.getI.ws.KOFMLPMNMGM(967f, 509f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
				float z = Mathf.Lerp(1600f, 1892f, (float)Mathf.RoundToInt((float)num) / 769f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.MGAMBBLEHBP());
	}

	// Token: 0x06008539 RID: 34105 RVA: 0x003E2532 File Offset: 0x003E0732
	public void JNIFLLMCEMG()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600853A RID: 34106 RVA: 0x003E73AF File Offset: 0x003E55AF
	public void GJAMIEJMJLD()
	{
		this.DEFNNEGPNEI = 1390f;
	}

	// Token: 0x0600853B RID: 34107 RVA: 0x003E73BC File Offset: 0x003E55BC
	public void ALGAEEMMAOI()
	{
		this.DEFNNEGPNEI = 929f;
	}

	// Token: 0x0600853C RID: 34108 RVA: 0x003E73CC File Offset: 0x003E55CC
	private void DEGCCLNOEKJ()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		switch (this.ptype)
		{
		case PanelParam.HKBNOKLFLCI.speed:
			this.pbar.min = 135f;
			this.pbar.max = 156f;
			this.textNumber.text = string.Concat(Mathf.RoundToInt(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA));
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA;
			if (this.MGAMBBLEHBP())
			{
				LocNewLogic.getI.ws.CMKFKNAOACN(1350f, 304f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CLEJODCMJAA);
			}
			break;
		case PanelParam.HKBNOKLFLCI.deep:
			this.pbar.min = 703f;
			this.pbar.max = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE();
			this.textNumber.text = string.Format("drink.wav", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP();
			if (this.OEEMPMHNBGJ())
			{
				LocNewLogic.getI.ws.ILKLIOLCMHP(1226f, BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FBLACLHFLGE(), BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP());
			}
			break;
		case PanelParam.HKBNOKLFLCI.fric:
			this.pbar.min = 350f;
			this.pbar.max = 1163f;
			this.textNumber.text = LocNewLogic.getI.ws.HOKKNLBOLDH();
			this.pbar.position = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CJLKGICPCAJ;
			if (this.GPJODPBAFNM())
			{
				LocNewLogic.getI.ws.MLMGOIHPKJC(1864f, 1806f, BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ENMACOFAHKG());
			}
			if (this.rollImage)
			{
				int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
				float z = Mathf.Lerp(1790f, 1944f, (float)Mathf.RoundToInt((float)num) / 355f);
				Vector3 eulerAngles = this.rollImage.transform.rotation.eulerAngles;
				eulerAngles.z = z;
				this.rollImage.transform.rotation = Quaternion.Euler(eulerAngles);
			}
			break;
		}
		this.panelShow.gameObject.SetActive(this.MGAMBBLEHBP());
	}

	// Token: 0x0600853D RID: 34109 RVA: 0x003E2532 File Offset: 0x003E0732
	public void JBMFGDAKLEP()
	{
		this.DEFNNEGPNEI = Time.time;
	}

	// Token: 0x0600853E RID: 34110 RVA: 0x003E7663 File Offset: 0x003E5863
	public void NDKIHKAMDLB()
	{
		this.DEFNNEGPNEI = 1410f;
	}

	// Token: 0x040012B3 RID: 4787
	public PanelParam.HKBNOKLFLCI ptype;

	// Token: 0x040012B4 RID: 4788
	public Text textNumber;

	// Token: 0x040012B5 RID: 4789
	public ProgressBar pbar;

	// Token: 0x040012B6 RID: 4790
	public RectTransform panelShow;

	// Token: 0x040012B7 RID: 4791
	public RectTransform rollImage;

	// Token: 0x040012B8 RID: 4792
	public float timeShowPanel = 3f;

	// Token: 0x040012B9 RID: 4793
	private float DEFNNEGPNEI;

	// Token: 0x02000245 RID: 581
	public enum HKBNOKLFLCI
	{
		// Token: 0x040012BB RID: 4795
		speed,
		// Token: 0x040012BC RID: 4796
		deep,
		// Token: 0x040012BD RID: 4797
		fric
	}
}
