using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class AQUAS_BubbleMorph : MonoBehaviour
{
	// Token: 0x0600008A RID: 138 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void EDGALMCHPPH()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void PMDPLLIBJAF()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00006CB4 File Offset: 0x00004EB4
	private void BOAJJAKEMLH()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1737f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1604f, 1126f, this.JAHNHOCNJGM / (this.tTarget / 927f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(551f, 1512f, this.JAHNHOCNJGM / (this.tTarget / 815f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 423f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(940f, 612f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(694f, 845f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 1513f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(408f, 1287f, this.JAHNHOCNJGM / (this.tTarget * 1115f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1161f, 1588f, this.JAHNHOCNJGM / (this.tTarget * 1279f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 472f && this.JAHNHOCNJGM < this.tTarget * 1728f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(228f, 787f, this.JAHNHOCNJGM / (this.tTarget * 970f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(551f, 700f, this.JAHNHOCNJGM / (this.tTarget * 934f)));
			return;
		}
		this.JAHNHOCNJGM = 904f;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00006ED8 File Offset: 0x000050D8
	private void Update()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 2f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(0f, 50f, this.JAHNHOCNJGM / (this.tTarget / 2f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(50f, 0f, this.JAHNHOCNJGM / (this.tTarget / 2f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 2f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(50f, 100f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(0f, 50f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 1.5f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(100f, 50f, this.JAHNHOCNJGM / (this.tTarget * 1.5f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(50f, 100f, this.JAHNHOCNJGM / (this.tTarget * 1.5f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 1.5f && this.JAHNHOCNJGM < this.tTarget * 2f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(50f, 0f, this.JAHNHOCNJGM / (this.tTarget * 2f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(100f, 50f, this.JAHNHOCNJGM / (this.tTarget * 2f)));
			return;
		}
		this.JAHNHOCNJGM = 0f;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void FPLHODJCJDO()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void OFGMIEJKMGC()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000070FC File Offset: 0x000052FC
	private void IOGAKGCADBL()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1626f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1622f, 1147f, this.JAHNHOCNJGM / (this.tTarget / 1608f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1895f, 221f, this.JAHNHOCNJGM / (this.tTarget / 126f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1168f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1419f, 1774f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1917f, 936f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 522f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(37f, 814f, this.JAHNHOCNJGM / (this.tTarget * 1216f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1633f, 337f, this.JAHNHOCNJGM / (this.tTarget * 1922f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 80f && this.JAHNHOCNJGM < this.tTarget * 1970f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(612f, 1768f, this.JAHNHOCNJGM / (this.tTarget * 821f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1668f, 881f, this.JAHNHOCNJGM / (this.tTarget * 322f)));
			return;
		}
		this.JAHNHOCNJGM = 19f;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void HDFCIACDDEK()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00007320 File Offset: 0x00005520
	private void OHKHOAKCENL()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 605f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1429f, 639f, this.JAHNHOCNJGM / (this.tTarget / 759f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1271f, 675f, this.JAHNHOCNJGM / (this.tTarget / 150f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 163f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(751f, 1660f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(107f, 838f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 1377f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1008f, 440f, this.JAHNHOCNJGM / (this.tTarget * 775f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1089f, 1009f, this.JAHNHOCNJGM / (this.tTarget * 876f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 1965f && this.JAHNHOCNJGM < this.tTarget * 1664f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1882f, 418f, this.JAHNHOCNJGM / (this.tTarget * 1381f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1130f, 486f, this.JAHNHOCNJGM / (this.tTarget * 1475f)));
			return;
		}
		this.JAHNHOCNJGM = 1000f;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void NCALLFHEAGJ()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void HHGGCBLOJGB()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00007544 File Offset: 0x00005744
	private void JLFBDOPFDDJ()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1031f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(538f, 1651f, this.JAHNHOCNJGM / (this.tTarget / 33f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1599f, 1710f, this.JAHNHOCNJGM / (this.tTarget / 35f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 831f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(358f, 1317f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(623f, 510f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 607f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1186f, 1794f, this.JAHNHOCNJGM / (this.tTarget * 588f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(411f, 1169f, this.JAHNHOCNJGM / (this.tTarget * 1003f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 857f && this.JAHNHOCNJGM < this.tTarget * 238f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1598f, 1970f, this.JAHNHOCNJGM / (this.tTarget * 1767f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1890f, 1987f, this.JAHNHOCNJGM / (this.tTarget * 1647f)));
			return;
		}
		this.JAHNHOCNJGM = 1324f;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00007768 File Offset: 0x00005968
	private void PGIHAIPCJLL()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 307f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(30f, 679f, this.JAHNHOCNJGM / (this.tTarget / 1630f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(295f, 401f, this.JAHNHOCNJGM / (this.tTarget / 1353f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1086f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1032f, 1588f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1504f, 237f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 81f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(521f, 862f, this.JAHNHOCNJGM / (this.tTarget * 1779f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(4f, 1255f, this.JAHNHOCNJGM / (this.tTarget * 474f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 541f && this.JAHNHOCNJGM < this.tTarget * 1088f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(436f, 1688f, this.JAHNHOCNJGM / (this.tTarget * 1979f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(614f, 206f, this.JAHNHOCNJGM / (this.tTarget * 441f)));
			return;
		}
		this.JAHNHOCNJGM = 373f;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void LPNDCJKAKEA()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000798C File Offset: 0x00005B8C
	private void AIAMIFEPALP()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 223f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1043f, 733f, this.JAHNHOCNJGM / (this.tTarget / 580f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(377f, 327f, this.JAHNHOCNJGM / (this.tTarget / 667f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 775f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1871f, 950f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(112f, 1433f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 1933f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(401f, 505f, this.JAHNHOCNJGM / (this.tTarget * 420f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(793f, 591f, this.JAHNHOCNJGM / (this.tTarget * 163f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 792f && this.JAHNHOCNJGM < this.tTarget * 1732f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1071f, 1621f, this.JAHNHOCNJGM / (this.tTarget * 1174f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1107f, 1746f, this.JAHNHOCNJGM / (this.tTarget * 1154f)));
			return;
		}
		this.JAHNHOCNJGM = 1072f;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void PFNPOHMMJDN()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00007BB0 File Offset: 0x00005DB0
	private void LMMDHJJJNJO()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1937f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(209f, 1914f, this.JAHNHOCNJGM / (this.tTarget / 819f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1547f, 333f, this.JAHNHOCNJGM / (this.tTarget / 114f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1659f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1475f, 1960f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1564f, 262f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 1090f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1401f, 607f, this.JAHNHOCNJGM / (this.tTarget * 1603f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(173f, 576f, this.JAHNHOCNJGM / (this.tTarget * 1369f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 506f && this.JAHNHOCNJGM < this.tTarget * 887f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1644f, 1330f, this.JAHNHOCNJGM / (this.tTarget * 213f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(592f, 930f, this.JAHNHOCNJGM / (this.tTarget * 1668f)));
			return;
		}
		this.JAHNHOCNJGM = 1013f;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void KKCFKEDABLB()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void AFFAJKPPMHF()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00007DD4 File Offset: 0x00005FD4
	private void CBBLGEDCJBF()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1158f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1254f, 1677f, this.JAHNHOCNJGM / (this.tTarget / 1751f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1834f, 1719f, this.JAHNHOCNJGM / (this.tTarget / 160f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1589f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(578f, 1695f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(781f, 1604f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 121f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1630f, 1633f, this.JAHNHOCNJGM / (this.tTarget * 544f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(924f, 1819f, this.JAHNHOCNJGM / (this.tTarget * 688f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 783f && this.JAHNHOCNJGM < this.tTarget * 1445f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(883f, 1030f, this.JAHNHOCNJGM / (this.tTarget * 1099f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1849f, 1982f, this.JAHNHOCNJGM / (this.tTarget * 620f)));
			return;
		}
		this.JAHNHOCNJGM = 527f;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void MCHAAIIHOKD()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void CAJLCEPLKJG()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00007FF8 File Offset: 0x000061F8
	private void LIOCDEICIFD()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1819f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1797f, 940f, this.JAHNHOCNJGM / (this.tTarget / 908f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1602f, 1658f, this.JAHNHOCNJGM / (this.tTarget / 292f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1982f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(334f, 1259f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1150f, 854f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 80f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(818f, 1782f, this.JAHNHOCNJGM / (this.tTarget * 1285f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1528f, 935f, this.JAHNHOCNJGM / (this.tTarget * 1160f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 1609f && this.JAHNHOCNJGM < this.tTarget * 358f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1183f, 1751f, this.JAHNHOCNJGM / (this.tTarget * 893f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1898f, 1570f, this.JAHNHOCNJGM / (this.tTarget * 702f)));
			return;
		}
		this.JAHNHOCNJGM = 1360f;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00006CA4 File Offset: 0x00004EA4
	private void Start()
	{
		this.CEGCBDDNDAH = base.GetComponent<SkinnedMeshRenderer>();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000821C File Offset: 0x0000641C
	private void KJJBBLDJHPD()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1641f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(41f, 83f, this.JAHNHOCNJGM / (this.tTarget / 439f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1936f, 1245f, this.JAHNHOCNJGM / (this.tTarget / 150f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 128f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(193f, 1955f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(372f, 1234f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 678f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(393f, 15f, this.JAHNHOCNJGM / (this.tTarget * 1847f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(131f, 1452f, this.JAHNHOCNJGM / (this.tTarget * 1283f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 28f && this.JAHNHOCNJGM < this.tTarget * 1453f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(388f, 1912f, this.JAHNHOCNJGM / (this.tTarget * 140f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(223f, 187f, this.JAHNHOCNJGM / (this.tTarget * 1495f)));
			return;
		}
		this.JAHNHOCNJGM = 481f;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00008440 File Offset: 0x00006640
	private void OPDCJCFMIPE()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1925f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1069f, 741f, this.JAHNHOCNJGM / (this.tTarget / 1650f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1297f, 404f, this.JAHNHOCNJGM / (this.tTarget / 1066f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 1635f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(224f, 987f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(973f, 1382f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 779f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(846f, 1949f, this.JAHNHOCNJGM / (this.tTarget * 1434f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(967f, 1658f, this.JAHNHOCNJGM / (this.tTarget * 703f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 836f && this.JAHNHOCNJGM < this.tTarget * 1130f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(771f, 728f, this.JAHNHOCNJGM / (this.tTarget * 1712f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(253f, 252f, this.JAHNHOCNJGM / (this.tTarget * 196f)));
			return;
		}
		this.JAHNHOCNJGM = 1204f;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00008664 File Offset: 0x00006864
	private void DFFOEGHGPGP()
	{
		this.JAHNHOCNJGM += Time.deltaTime;
		this.FBJFGKGEFDN += Time.deltaTime;
		if (this.JAHNHOCNJGM < this.tTarget / 1706f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1879f, 711f, this.JAHNHOCNJGM / (this.tTarget / 682f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1189f, 1465f, this.JAHNHOCNJGM / (this.tTarget / 1236f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget / 932f && this.JAHNHOCNJGM < this.tTarget)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1268f, 256f, this.JAHNHOCNJGM / this.tTarget));
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(1510f, 1073f, this.JAHNHOCNJGM / this.tTarget));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget && this.JAHNHOCNJGM < this.tTarget * 494f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(459f, 226f, this.JAHNHOCNJGM / (this.tTarget * 451f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1787f, 592f, this.JAHNHOCNJGM / (this.tTarget * 1596f)));
			return;
		}
		if (this.JAHNHOCNJGM >= this.tTarget * 1255f && this.JAHNHOCNJGM < this.tTarget * 1046f)
		{
			this.CEGCBDDNDAH.SetBlendShapeWeight(1, Mathf.Lerp(185f, 763f, this.JAHNHOCNJGM / (this.tTarget * 1203f)));
			this.CEGCBDDNDAH.SetBlendShapeWeight(0, Mathf.Lerp(1039f, 1468f, this.JAHNHOCNJGM / (this.tTarget * 226f)));
			return;
		}
		this.JAHNHOCNJGM = 780f;
	}

	// Token: 0x04000008 RID: 8
	private float JAHNHOCNJGM;

	// Token: 0x04000009 RID: 9
	private float FBJFGKGEFDN;

	// Token: 0x0400000A RID: 10
	[Space(5f)]
	[Header("Duration of a full morphing cycle")]
	public float tTarget;

	// Token: 0x0400000B RID: 11
	private SkinnedMeshRenderer CEGCBDDNDAH;
}
