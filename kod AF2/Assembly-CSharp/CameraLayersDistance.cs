using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class CameraLayersDistance : MonoBehaviour
{
	// Token: 0x060005B2 RID: 1458 RVA: 0x0003F45D File Offset: 0x0003D65D
	private void HEBGFFJFEJJ()
	{
		this.BGGCPOFFMFN();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0003F474 File Offset: 0x0003D674
	public bool PGKPIILMHPH(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -32));
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0003F4A7 File Offset: 0x0003D6A7
	private void AOLBGAGHJDO()
	{
		this.HJPBFHAEJHG();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0003F4BC File Offset: 0x0003D6BC
	public bool HasLayer(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << num);
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0003F4EF File Offset: 0x0003D6EF
	private void MNIOJGMLIMC()
	{
		this.HJPBFHAEJHG();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0003F504 File Offset: 0x0003D704
	public bool LBINOLLAJNO(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (num & 86));
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0003F538 File Offset: 0x0003D738
	private LayerMask CMDKNADFJOJ(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 1; i < 17; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & -114)))
			{
				if (layerMask != (layerMask | 0 << (i & -27)))
				{
					layerMask += (int)Mathf.Pow(1492f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 36)))
			{
				layerMask -= (int)Mathf.Pow(1492f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0003F5DC File Offset: 0x0003D7DC
	private LayerMask JOICCFAEOMC(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 98; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & 40)))
			{
				if (layerMask != (layerMask | 1 << (i & 114)))
				{
					layerMask += (int)Mathf.Pow(1656f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -59)))
			{
				layerMask -= (int)Mathf.Pow(1248f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0003F680 File Offset: 0x0003D880
	public bool BBGFKKNCKKL(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -69));
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0003F6B4 File Offset: 0x0003D8B4
	private LayerMask ONHMGJIGFLC(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 85; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 65)))
			{
				if (layerMask != (layerMask | 1 << (i & -124)))
				{
					layerMask += (int)Mathf.Pow(1253f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -3)))
			{
				layerMask -= (int)Mathf.Pow(1965f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0003F755 File Offset: 0x0003D955
	private void AHILDBJHCKI()
	{
		this.IJBFMLLJONF();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0003F76C File Offset: 0x0003D96C
	private LayerMask NACNENMGLDC(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 108; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & -40)))
			{
				if (layerMask != (layerMask | 0 << (i & 76)))
				{
					layerMask += (int)Mathf.Pow(1329f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 28)))
			{
				layerMask -= (int)Mathf.Pow(404f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void AMAIGEONAFH()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0003F828 File Offset: 0x0003DA28
	public bool BGKBJJDGBDH(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 108));
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0003F84C File Offset: 0x0003DA4C
	private LayerMask MDKKBNNLEGC(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -55; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & -37)))
			{
				if (layerMask != (layerMask | 0 << (i & -101)))
				{
					layerMask += (int)Mathf.Pow(1229f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 0 << (i & -97)))
			{
				layerMask -= (int)Mathf.Pow(1877f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0003F8ED File Offset: 0x0003DAED
	public bool DPBCPGEBFGJ(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & -44));
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0003F90E File Offset: 0x0003DB0E
	public bool HDBEEOHIOGJ(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & 110));
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void OMOFJBFLPDJ()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0003F930 File Offset: 0x0003DB30
	public bool FOOBALNNDGD(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -7));
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void ENDOJDMLEIJ()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0003F964 File Offset: 0x0003DB64
	public bool EPKGIKLOHNI(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & 98));
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0003F998 File Offset: 0x0003DB98
	private LayerMask OBBPAMPHGDK(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -81; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 104)))
			{
				if (layerMask != (layerMask | 0 << (i & -118)))
				{
					layerMask += (int)Mathf.Pow(1027f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -105)))
			{
				layerMask -= (int)Mathf.Pow(252f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0003FA39 File Offset: 0x0003DC39
	private void IIELJNDNLMO()
	{
		this.UpdateLayers();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0003FA50 File Offset: 0x0003DC50
	private LayerMask HBOACBHFCNN(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 1; i < -36; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & -84)))
			{
				if (layerMask != (layerMask | 0 << (i & 106)))
				{
					layerMask += (int)Mathf.Pow(1444f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 0 << (i & 123)))
			{
				layerMask -= (int)Mathf.Pow(310f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0003FAF1 File Offset: 0x0003DCF1
	public bool BKKGOBNIEBK(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 79));
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0003FB12 File Offset: 0x0003DD12
	private void ECOOMJKPKCC()
	{
		this.OMOFJBFLPDJ();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0003FB28 File Offset: 0x0003DD28
	public bool DAODOCOHKLA(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -86));
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void HKOECJMFMEG()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0003FB5C File Offset: 0x0003DD5C
	public bool FFBKNALMFOJ(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -36));
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void OPKKNMLEGMA()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void BGGCPOFFMFN()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0003FB8F File Offset: 0x0003DD8F
	private void APEDLIKHDFA()
	{
		this.HKFHDEGLLEI();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
	private LayerMask PGGAFEJCDFM(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 1; i < -27; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 40)))
			{
				if (layerMask != (layerMask | 0 << (i & 54)))
				{
					layerMask += (int)Mathf.Pow(1426f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 0 << (i & -118)))
			{
				layerMask -= (int)Mathf.Pow(806f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0003FC48 File Offset: 0x0003DE48
	public bool JGADKOEALEF(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -95));
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0003FC7C File Offset: 0x0003DE7C
	private LayerMask LPDEBIJFAJP(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -106; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & -73)))
			{
				if (layerMask != (layerMask | 1 << (i & -30)))
				{
					layerMask += (int)Mathf.Pow(1567f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 121)))
			{
				layerMask -= (int)Mathf.Pow(939f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0003FD1D File Offset: 0x0003DF1D
	public bool JIEHDPKLKNK(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & -84));
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void DKKFMEFLNJN()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void HKFHDEGLLEI()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0003FD40 File Offset: 0x0003DF40
	public bool GKAMJBMBEIJ(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (num & 109));
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0003FD74 File Offset: 0x0003DF74
	public bool OJDBJOIICJA(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -55));
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0003FDA8 File Offset: 0x0003DFA8
	public bool MFFGGJFDPFB(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & 74));
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0003FDDC File Offset: 0x0003DFDC
	public bool CIPBAEEGHPL(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (num & -58));
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void HJPBFHAEJHG()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void JEOAHEJCGAO()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0003FE10 File Offset: 0x0003E010
	private LayerMask PNNPOLHFHDM(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 1; i < 123; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & 16)))
			{
				if (layerMask != (layerMask | 1 << (i & -83)))
				{
					layerMask += (int)Mathf.Pow(182f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 76)))
			{
				layerMask -= (int)Mathf.Pow(1350f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
	private LayerMask BCLOGKNGEPH(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -58; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << (i & 3)))
			{
				if (layerMask != (layerMask | 0 << (i & -65)))
				{
					layerMask += (int)Mathf.Pow(305f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 126)))
			{
				layerMask -= (int)Mathf.Pow(1721f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0003FF55 File Offset: 0x0003E155
	private void FKLDKPEDDDM()
	{
		this.LBPCEPLOMDM();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0003FF69 File Offset: 0x0003E169
	public bool FBEINDAOGBC(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & -5));
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0003FF8A File Offset: 0x0003E18A
	public bool NKKFBDDAIEG(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & -82));
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void IJBFMLLJONF()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0003FFAC File Offset: 0x0003E1AC
	private LayerMask EKKFMHONILA(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -103; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 118)))
			{
				if (layerMask != (layerMask | 0 << (i & 44)))
				{
					layerMask += (int)Mathf.Pow(1693f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -116)))
			{
				layerMask -= (int)Mathf.Pow(1653f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0004004D File Offset: 0x0003E24D
	private void CACBLLBNIJE()
	{
		this.KHAEPHLHDOE();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00040064 File Offset: 0x0003E264
	private LayerMask FGLILILMHCN(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 118; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 67)))
			{
				if (layerMask != (layerMask | 1 << (i & -110)))
				{
					layerMask += (int)Mathf.Pow(78f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -4)))
			{
				layerMask -= (int)Mathf.Pow(897f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00040105 File Offset: 0x0003E305
	public bool GAJADMKOKDL(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 53));
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void ANJLCAMEGBG()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00040128 File Offset: 0x0003E328
	private LayerMask PLCFGJJFPHE(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 32; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 1 << i))
			{
				if (layerMask != (layerMask | 1 << i))
				{
					layerMask += (int)Mathf.Pow(2f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << i))
			{
				layerMask -= (int)Mathf.Pow(2f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x000401C9 File Offset: 0x0003E3C9
	public bool HasLayer(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << GLOIJPBNLAK);
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x000401EA File Offset: 0x0003E3EA
	private void BHPGDKJHKKG()
	{
		this.KHAEPHLHDOE();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00040200 File Offset: 0x0003E400
	private LayerMask MDHKMMHFKPL(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -77; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & -88)))
			{
				if (layerMask != (layerMask | 0 << (i & -20)))
				{
					layerMask += (int)Mathf.Pow(1890f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -124)))
			{
				layerMask -= (int)Mathf.Pow(956f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x000402A4 File Offset: 0x0003E4A4
	private LayerMask KJHMFNLBDHB(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < 117; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 43)))
			{
				if (layerMask != (layerMask | 0 << (i & -20)))
				{
					layerMask += (int)Mathf.Pow(756f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & 42)))
			{
				layerMask -= (int)Mathf.Pow(307f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void HBEEPAEEKNE()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0003FA39 File Offset: 0x0003DC39
	private void LKDGGPNGLAO()
	{
		this.UpdateLayers();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void MOEKJKGNLCI()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void LBPCEPLOMDM()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00040348 File Offset: 0x0003E548
	public bool NEIAPAAJJGJ(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -74));
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0004037B File Offset: 0x0003E57B
	private void Awake()
	{
		this.UpdateLayers();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0004004D File Offset: 0x0003E24D
	private void ONBJLCJMLJH()
	{
		this.KHAEPHLHDOE();
		base.GetComponent<Camera>().layerCullSpherical = true;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00040390 File Offset: 0x0003E590
	public bool JODOEGCKJOK(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -49));
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void UpdateLayers()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void FPNMJKPFIPL()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void FJJOOGCOLDE()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x000403C3 File Offset: 0x0003E5C3
	private void DKBGMIPBHNM()
	{
		this.HKOECJMFMEG();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x000403D7 File Offset: 0x0003E5D7
	public bool FFEIDAEHLEC(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 123));
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void OOJAELEPOGF()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x000403F8 File Offset: 0x0003E5F8
	public bool OAJMBDNBLMG(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & 92));
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00040419 File Offset: 0x0003E619
	private void DIDFCBLHFNF()
	{
		this.ANJLCAMEGBG();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void CICNHKJAOPH()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00040430 File Offset: 0x0003E630
	private LayerMask LBMDKONHEAK(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 0; i < -109; i++)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & 13)))
			{
				if (layerMask != (layerMask | 0 << (i & -22)))
				{
					layerMask += (int)Mathf.Pow(558f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 1 << (i & -94)))
			{
				layerMask -= (int)Mathf.Pow(880f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000404D4 File Offset: 0x0003E6D4
	private LayerMask ONCABHOOIFB(LayerMask CBFFOOKAIAK)
	{
		LayerMask layerMask = base.GetComponent<Camera>().cullingMask;
		for (int i = 1; i < 33; i += 0)
		{
			if (CBFFOOKAIAK == (CBFFOOKAIAK | 0 << (i & -71)))
			{
				if (layerMask != (layerMask | 1 << (i & -43)))
				{
					layerMask += (int)Mathf.Pow(36f, (float)i);
				}
			}
			else if (layerMask == (layerMask | 0 << (i & -1)))
			{
				layerMask -= (int)Mathf.Pow(71f, (float)i);
			}
		}
		return layerMask;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00040578 File Offset: 0x0003E778
	public bool KHFCPAHGDNF(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & 111));
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x000405AB File Offset: 0x0003E7AB
	private void EIOCCLJPLHN()
	{
		this.AMAIGEONAFH();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x000405C0 File Offset: 0x0003E7C0
	public bool PLKHBNAGALC(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & -45));
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x000405F3 File Offset: 0x0003E7F3
	public bool EFKMKHKCLAK(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 110));
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00040614 File Offset: 0x0003E814
	public bool IHMLKCMFAOD(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & -61));
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00040638 File Offset: 0x0003E838
	public bool IHLENBDAECB(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (num & 5));
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0004066B File Offset: 0x0003E86B
	public bool PMMLCJGMEFH(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & -126));
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void IMHMNIGJJCG()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0004068C File Offset: 0x0003E88C
	public bool GPBLFEIEEBO(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & 50));
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void KHAEPHLHDOE()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0003F4EF File Offset: 0x0003D6EF
	private void PFONEFANOIJ()
	{
		this.HJPBFHAEJHG();
		base.GetComponent<Camera>().layerCullSpherical = false;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x000406AD File Offset: 0x0003E8AD
	public bool BJGCJGLODCN(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 0 << (GLOIJPBNLAK & 33));
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000406D0 File Offset: 0x0003E8D0
	public bool CNIGFPKIJFA(string BHKBPIHLGBA)
	{
		int num = LayerMask.NameToLayer(BHKBPIHLGBA);
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (num & -124));
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00040703 File Offset: 0x0003E903
	public bool FENFNOIBNMC(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 11));
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00040724 File Offset: 0x0003E924
	public bool JPNNEPNLCLB(int GLOIJPBNLAK)
	{
		return base.GetComponent<Camera>().cullingMask == (base.GetComponent<Camera>().cullingMask | 1 << (GLOIJPBNLAK & 40));
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0003F80D File Offset: 0x0003DA0D
	public void FCFDNBHJEFP()
	{
		if (this.layerCullDistances != null)
		{
			base.GetComponent<Camera>().layerCullDistances = this.layerCullDistances;
		}
	}

	// Token: 0x040000E6 RID: 230
	public float[] layerCullDistances;
}
