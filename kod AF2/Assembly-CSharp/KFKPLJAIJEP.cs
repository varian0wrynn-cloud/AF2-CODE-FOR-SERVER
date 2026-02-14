using System;
using System.IO;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class KFKPLJAIJEP : IDisposable
{
	// Token: 0x060007D9 RID: 2009 RVA: 0x0004989C File Offset: 0x00047A9C
	public void CAFOGICLPCN(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.PFJODLHIIAB(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.JAMBJLGNEMF();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x000498CC File Offset: 0x00047ACC
	public GameObject LPHOBINOBGE(Vector3 MGALEAJOGPL)
	{
		AntaresCurvePoint[] componentsInChildren = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>();
		int num = componentsInChildren.Length;
		float num2 = 199f;
		GameObject result = null;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, componentsInChildren[i].transform.position);
			if (num3 < num2)
			{
				num2 = num3;
				result = componentsInChildren[i].gameObject;
			}
		}
		return result;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x0004992F File Offset: 0x00047B2F
	public void IAGLGAEGLGO()
	{
		if (this.ELAHOBLEGJE)
		{
			return;
		}
		this.ELAHOBLEGJE = false;
		this.EIPMIHNJAJC = null;
		this.HCGGGAEIDLA = null;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00049950 File Offset: 0x00047B50
	public int ALNHANNOOKE(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00049972 File Offset: 0x00047B72
	public KFKPLJAIJEP(GameObject EFKIEOJIMAO)
	{
		this.HCGGGAEIDLA = EFKIEOJIMAO.GetComponent<AntaresBezierController>();
		this.CDEKEEPNNAP(true);
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0004999F File Offset: 0x00047B9F
	public void LKPJOJIBCKK()
	{
		this.HCGGGAEIDLA.FCKCNMFJKCI();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x000499C0 File Offset: 0x00047BC0
	public void NBCNMGKIFJJ(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 1 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.HELDGCCELJD();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00049A23 File Offset: 0x00047C23
	public int GAEDOFCCEOP()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00049A38 File Offset: 0x00047C38
	public float CDEKEEPNNAP(bool CMBMBOAMHKO)
	{
		if (!CMBMBOAMHKO)
		{
			return this.JJAFKLJFJJO;
		}
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length - 1;
		this.JJAFKLJFJJO = 0f;
		for (int i = 0; i < num; i++)
		{
			this.JJAFKLJFJJO += Vector3.Distance(wayPoints[i], wayPoints[i + 1]);
		}
		return this.JJAFKLJFJJO;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00049AA0 File Offset: 0x00047CA0
	public float IAKPDKNGGHN(bool CMBMBOAMHKO)
	{
		if (!CMBMBOAMHKO)
		{
			return this.JJAFKLJFJJO;
		}
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length - 1;
		this.JJAFKLJFJJO = 562f;
		for (int i = 0; i < num; i += 0)
		{
			this.JJAFKLJFJJO += Vector3.Distance(wayPoints[i], wayPoints[i + 0]);
		}
		return this.JJAFKLJFJJO;
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00049B08 File Offset: 0x00047D08
	public void DCPJMNCDIKK()
	{
		this.HCGGGAEIDLA.NEDCOBCLJNM();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00049B26 File Offset: 0x00047D26
	public int LELGHIAOFIP()
	{
		return this.HCGGGAEIDLA.wayPoints.Length;
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00049B35 File Offset: 0x00047D35
	public void POLJNKJADNI()
	{
		this.HCGGGAEIDLA.JKAEKMHFDDC();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00049B54 File Offset: 0x00047D54
	public static string BANAMCKIELE
	{
		get
		{
			if (KFKPLJAIJEP.LBFIGELHBOE == "")
			{
				KFKPLJAIJEP.LBFIGELHBOE = "Antares" + Path.DirectorySeparatorChar.ToString();
			}
			return KFKPLJAIJEP.LBFIGELHBOE;
		}
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00049A23 File Offset: 0x00047C23
	public int CDCIHPHAKJC()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00049A23 File Offset: 0x00047C23
	public int COEOCMLDKDO()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00049B93 File Offset: 0x00047D93
	public void NLNIHGIFHBF()
	{
		this.HCGGGAEIDLA.NHHAAEENMJP();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0004999F File Offset: 0x00047B9F
	public void HLKHGGDDBLG()
	{
		this.HCGGGAEIDLA.FCKCNMFJKCI();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00049BB4 File Offset: 0x00047DB4
	public int GMKILADHMHB(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 1606f;
		int result = -1;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00049C05 File Offset: 0x00047E05
	public void AIDANPJONAN()
	{
		this.HCGGGAEIDLA.InvertCurve();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x0004999F File Offset: 0x00047B9F
	public void OBPPDKFGPEK()
	{
		this.HCGGGAEIDLA.FCKCNMFJKCI();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00049C24 File Offset: 0x00047E24
	public float LKEFNBDNACK(bool CMBMBOAMHKO)
	{
		if (!CMBMBOAMHKO)
		{
			return this.JJAFKLJFJJO;
		}
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length - 0;
		this.JJAFKLJFJJO = 1694f;
		for (int i = 0; i < num; i += 0)
		{
			this.JJAFKLJFJJO += Vector3.Distance(wayPoints[i], wayPoints[i + 1]);
		}
		return this.JJAFKLJFJJO;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00049C8C File Offset: 0x00047E8C
	public void OIKMDGDKLGG(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.IECLECGGOAJ(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.HELDGCCELJD();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00049CBC File Offset: 0x00047EBC
	public static string KKENBHFNEKM()
	{
		if (KFKPLJAIJEP.LBFIGELHBOE == "References has no spine bones assigned, can not initiate the solver.")
		{
			KFKPLJAIJEP.LBFIGELHBOE = "gi_frac_no" + Path.DirectorySeparatorChar.ToString();
		}
		return KFKPLJAIJEP.LBFIGELHBOE;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00049CFC File Offset: 0x00047EFC
	public int EIAFAGKKFAL(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00049A23 File Offset: 0x00047C23
	public int PFOLMFAFFBO()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00049A23 File Offset: 0x00047C23
	public int PEHDPLIFDFD()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00049D20 File Offset: 0x00047F20
	public float CLMFHAIGMEO(bool CMBMBOAMHKO)
	{
		if (!CMBMBOAMHKO)
		{
			return this.JJAFKLJFJJO;
		}
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length - 0;
		this.JJAFKLJFJJO = 1202f;
		for (int i = 0; i < num; i++)
		{
			this.JJAFKLJFJJO += Vector3.Distance(wayPoints[i], wayPoints[i + 0]);
		}
		return this.JJAFKLJFJJO;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00049A23 File Offset: 0x00047C23
	public int AIBOINBEOFF()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00049D88 File Offset: 0x00047F88
	public void JKIADDDMCPL(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.AddCurvePointDuringRuntime(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.MHPGIGLEIPN();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00049DB8 File Offset: 0x00047FB8
	public void OHDDBBFLPBM(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 0 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.RefreshCurve();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00049E1B File Offset: 0x0004801B
	public void AMDEMGODIOF(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.IECLECGGOAJ(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.JAMBJLGNEMF();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00049E48 File Offset: 0x00048048
	public void CMCHNMMCICI()
	{
		this.HCGGGAEIDLA.HELDGCCELJD();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00049E66 File Offset: 0x00048066
	public void AINAFOFAFNG()
	{
		this.HCGGGAEIDLA.POEHPFMKDLA();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00049E84 File Offset: 0x00048084
	public int NBFHOPNEOGE(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 1139f;
		int result = -1;
		for (int i = 1; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00049ED5 File Offset: 0x000480D5
	public void Dispose()
	{
		if (this.ELAHOBLEGJE)
		{
			return;
		}
		this.ELAHOBLEGJE = true;
		this.EIPMIHNJAJC = null;
		this.HCGGGAEIDLA = null;
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00049EF5 File Offset: 0x000480F5
	public void GEKEFEHLJGI()
	{
		this.HCGGGAEIDLA.MMGFECIAFIA();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00049F14 File Offset: 0x00048114
	public int ANBNGLMKPGJ(float MGALEAJOGPL)
	{
		float num = (float)(1 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00049F38 File Offset: 0x00048138
	public int BAKKPGFPKOA(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00049F5A File Offset: 0x0004815A
	public void JLNGBHNMPBD()
	{
		this.HCGGGAEIDLA.ILDBJJLKACP();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00049F78 File Offset: 0x00048178
	public void LBHMFEOLMGI(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 1 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.POEHPFMKDLA();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00049FDC File Offset: 0x000481DC
	public static string GPFMIOMHFFG()
	{
		if (KFKPLJAIJEP.LBFIGELHBOE == "#20a000")
		{
			KFKPLJAIJEP.LBFIGELHBOE = "{0}" + Path.DirectorySeparatorChar.ToString();
		}
		return KFKPLJAIJEP.LBFIGELHBOE;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0004A01C File Offset: 0x0004821C
	public int DNAJLBOHDNO(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 1016f;
		int result = -1;
		for (int i = 0; i < num; i += 0)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0004A06D File Offset: 0x0004826D
	public void IOOHIABCANL(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.AddCurvePointDuringRuntime(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.RefreshCurve();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0004A09A File Offset: 0x0004829A
	public void FAJDFJLMCNL()
	{
		this.HCGGGAEIDLA.RefreshCurve();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0004A0B8 File Offset: 0x000482B8
	public void PCOEGFNICCF(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 1 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.JAMBJLGNEMF();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0004A11C File Offset: 0x0004831C
	public int HIOLPAGDLIJ(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 825f;
		int result = -1;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00049C05 File Offset: 0x00047E05
	public void ENOFNCNLBCA()
	{
		this.HCGGGAEIDLA.InvertCurve();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0004A170 File Offset: 0x00048370
	public int JEIENCICJLH(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0004A192 File Offset: 0x00048392
	public void GLMMPFFNJOP()
	{
		this.HCGGGAEIDLA.MHPGIGLEIPN();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0004A1B0 File Offset: 0x000483B0
	public GameObject JNDKPEJBJLH(Vector3 MGALEAJOGPL)
	{
		AntaresCurvePoint[] componentsInChildren = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>();
		int num = componentsInChildren.Length;
		float num2 = 1139f;
		GameObject result = null;
		for (int i = 1; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, componentsInChildren[i].transform.position);
			if (num3 < num2)
			{
				num2 = num3;
				result = componentsInChildren[i].gameObject;
			}
		}
		return result;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00049B26 File Offset: 0x00047D26
	public int HPKPLOJHPDL()
	{
		return this.HCGGGAEIDLA.wayPoints.Length;
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0004A214 File Offset: 0x00048414
	public int HHCKGANJOAB(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0004A238 File Offset: 0x00048438
	public int OJLPFLOEFDG(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0004A25C File Offset: 0x0004845C
	public void DPJAGNEDKJP(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 0 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.RefreshCurve();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00049A23 File Offset: 0x00047C23
	public int HPHKIBEGJMN()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00049B26 File Offset: 0x00047D26
	public int FEFCMKAPENL()
	{
		return this.HCGGGAEIDLA.wayPoints.Length;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0004A2C0 File Offset: 0x000484C0
	public GameObject KOLHJEHJLAA(Vector3 MGALEAJOGPL)
	{
		AntaresCurvePoint[] componentsInChildren = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>();
		int num = componentsInChildren.Length;
		float num2 = 161f;
		GameObject result = null;
		for (int i = 1; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, componentsInChildren[i].transform.position);
			if (num3 < num2)
			{
				num2 = num3;
				result = componentsInChildren[i].gameObject;
			}
		}
		return result;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00049A23 File Offset: 0x00047C23
	public int DOEHBPENBNP()
	{
		return this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0004A323 File Offset: 0x00048523
	public void BFFIOGKMOCC()
	{
		this.HCGGGAEIDLA.MLHIIFMBBKP();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00049ED5 File Offset: 0x000480D5
	public void JNNMOBBCADO()
	{
		if (this.ELAHOBLEGJE)
		{
			return;
		}
		this.ELAHOBLEGJE = true;
		this.EIPMIHNJAJC = null;
		this.HCGGGAEIDLA = null;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0004A344 File Offset: 0x00048544
	public int OAHPLFBOMPM(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 377f;
		int result = -1;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0004A398 File Offset: 0x00048598
	public void PHPOOJJAAGN(int HHAPKGKNIKD, bool OBEJCFICOBH)
	{
		int num = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>().Length;
		if (HHAPKGKNIKD < 1 || HHAPKGKNIKD > num)
		{
			return;
		}
		UnityEngine.Object.Destroy(this.HCGGGAEIDLA.transform.GetChild(HHAPKGKNIKD).gameObject);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.MHPGIGLEIPN();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0004A3FC File Offset: 0x000485FC
	public int MJIPCFIMMKJ(float MGALEAJOGPL)
	{
		float num = (float)(1 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0004A420 File Offset: 0x00048620
	public int DKKENKDEBHD(float MGALEAJOGPL)
	{
		float num = (float)(0 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x0004A444 File Offset: 0x00048644
	public int DABEHDLMNKB(float MGALEAJOGPL)
	{
		float num = (float)(1 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00049C05 File Offset: 0x00047E05
	public void CBGOBBGHAHM()
	{
		this.HCGGGAEIDLA.InvertCurve();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0004A468 File Offset: 0x00048668
	public int JFPHFBNPFAA(float MGALEAJOGPL)
	{
		float num = (float)(1 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0004A48C File Offset: 0x0004868C
	public int OHAFCLIDFBE(float MGALEAJOGPL)
	{
		float num = (float)(1 / this.HCGGGAEIDLA.wayPoints.Length);
		return (int)(MGALEAJOGPL * num);
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0004A4AE File Offset: 0x000486AE
	public void NKLGDOPHLGB(Vector3 LMPOCDKLLKJ, bool OBEJCFICOBH)
	{
		this.HCGGGAEIDLA.ACIPNKBLOEA(LMPOCDKLLKJ);
		if (OBEJCFICOBH)
		{
			this.HCGGGAEIDLA.HELDGCCELJD();
		}
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00049ED5 File Offset: 0x000480D5
	public void FGMNJBHEEML()
	{
		if (this.ELAHOBLEGJE)
		{
			return;
		}
		this.ELAHOBLEGJE = true;
		this.EIPMIHNJAJC = null;
		this.HCGGGAEIDLA = null;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0004A4E8 File Offset: 0x000486E8
	public int JBHNIKGLMDO(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 10000f;
		int result = -1;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00049B26 File Offset: 0x00047D26
	public int FEGFLCALKAD()
	{
		return this.HCGGGAEIDLA.wayPoints.Length;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0004A53C File Offset: 0x0004873C
	public GameObject CKLOCHAICGC(Vector3 MGALEAJOGPL)
	{
		AntaresCurvePoint[] componentsInChildren = this.HCGGGAEIDLA.transform.GetComponentsInChildren<AntaresCurvePoint>();
		int num = componentsInChildren.Length;
		float num2 = 10000f;
		GameObject result = null;
		for (int i = 0; i < num; i++)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, componentsInChildren[i].transform.position);
			if (num3 < num2)
			{
				num2 = num3;
				result = componentsInChildren[i].gameObject;
			}
		}
		return result;
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00049B26 File Offset: 0x00047D26
	public int IKHDBCFNOLD()
	{
		return this.HCGGGAEIDLA.wayPoints.Length;
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00049C05 File Offset: 0x00047E05
	public void AIPKBNLGOOD()
	{
		this.HCGGGAEIDLA.InvertCurve();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0004A59F File Offset: 0x0004879F
	public void DBOGADFLFPE()
	{
		this.HCGGGAEIDLA.RefreshLineRenderers();
		this.EIPMIHNJAJC = this.HCGGGAEIDLA.wayPoints;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0004A5C0 File Offset: 0x000487C0
	public int NOCAKEEJCCL(Vector3 MGALEAJOGPL)
	{
		Vector3[] wayPoints = this.HCGGGAEIDLA.wayPoints;
		int num = wayPoints.Length;
		float num2 = 1748f;
		int result = -1;
		for (int i = 1; i < num; i += 0)
		{
			float num3 = Vector3.Distance(MGALEAJOGPL, wayPoints[i]);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x040000FA RID: 250
	private AntaresBezierController HCGGGAEIDLA;

	// Token: 0x040000FB RID: 251
	public float JJAFKLJFJJO;

	// Token: 0x040000FC RID: 252
	public Vector3[] EIPMIHNJAJC;

	// Token: 0x040000FD RID: 253
	protected bool ELAHOBLEGJE;

	// Token: 0x040000FE RID: 254
	private static string LBFIGELHBOE = "";
}
