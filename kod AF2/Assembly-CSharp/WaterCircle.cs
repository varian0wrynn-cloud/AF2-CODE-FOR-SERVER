using System;
using UnityEngine;

// Token: 0x0200029C RID: 668
public class WaterCircle : MonoBehaviour
{
	// Token: 0x06009C65 RID: 40037 RVA: 0x00463CDB File Offset: 0x00461EDB
	private void DILOBFJJNNE()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009C66 RID: 40038 RVA: 0x00463D18 File Offset: 0x00461F18
	private void PFNOEACNHON()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 288f)
		{
			this.BBMNPAIPEJL();
		}
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x00463DC8 File Offset: 0x00461FC8
	private void JIIBCGJJLND()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C68 RID: 40040 RVA: 0x00463E38 File Offset: 0x00462038
	private void NPKEBODNBAI()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C69 RID: 40041 RVA: 0x00463EA8 File Offset: 0x004620A8
	public void GCDELCHLDOD()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "Vertical" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(675f, UnityEngine.Random.value * 1918f, 1541f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.APPANDNOOLO();
				}
			}
		}
	}

	// Token: 0x06009C6A RID: 40042 RVA: 0x00463F84 File Offset: 0x00462184
	private void LBOONMDONCF()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1494f)
		{
			this.FLBNBOMNCLJ();
		}
	}

	// Token: 0x06009C6B RID: 40043 RVA: 0x00464034 File Offset: 0x00462234
	private void CGNGBFFGGBP()
	{
		base.transform.rotation = Quaternion.Euler(1718f, UnityEngine.Random.value * 1577f, 1977f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "Attached object" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C6C RID: 40044 RVA: 0x00464094 File Offset: 0x00462294
	private void LBEFOABPMFG()
	{
		base.transform.rotation = Quaternion.Euler(1368f, UnityEngine.Random.value * 610f, 1620f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "gameComplete" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C6D RID: 40045 RVA: 0x004640F4 File Offset: 0x004622F4
	private void Awake()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C6E RID: 40046 RVA: 0x00464164 File Offset: 0x00462364
	public void FGDJGFEFBJH()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "CrawlLocomotion" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1792f, UnityEngine.Random.value * 461f, 828f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			foreach (WaterCircle waterCircle in base.GetComponentsInChildren<WaterCircle>())
			{
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.NFNHCCHOIEJ();
				}
			}
		}
	}

	// Token: 0x06009C6F RID: 40047 RVA: 0x00464240 File Offset: 0x00462440
	private void CGFDDFHECLJ()
	{
		base.transform.rotation = Quaternion.Euler(592f, UnityEngine.Random.value * 1800f, 1837f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C70 RID: 40048 RVA: 0x004642A0 File Offset: 0x004624A0
	private void LHJCHPFKGDB()
	{
		base.transform.rotation = Quaternion.Euler(1583f, UnityEngine.Random.value * 415f, 293f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "gi_sadok" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C71 RID: 40049 RVA: 0x00464300 File Offset: 0x00462500
	private void FGJCIEDDFGN()
	{
		base.transform.rotation = Quaternion.Euler(1318f, UnityEngine.Random.value * 1797f, 1561f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "KatanaReady" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C72 RID: 40050 RVA: 0x0046435F File Offset: 0x0046255F
	private void OFKNCJINGBM()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C73 RID: 40051 RVA: 0x0046439C File Offset: 0x0046259C
	private void EDANNBFJHIK()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1883f)
		{
			this.BBMNPAIPEJL();
		}
	}

	// Token: 0x06009C74 RID: 40052 RVA: 0x00463CDB File Offset: 0x00461EDB
	private void KCFGIIENIBB()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009C75 RID: 40053 RVA: 0x0046444C File Offset: 0x0046264C
	private void DIAIKCBANBK()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 742f)
		{
			this.FLBNBOMNCLJ();
		}
	}

	// Token: 0x06009C76 RID: 40054 RVA: 0x004644FC File Offset: 0x004626FC
	private void JKJJCEIFJOJ()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C77 RID: 40055 RVA: 0x00464538 File Offset: 0x00462738
	private void KIEIPFFEDHC()
	{
		base.transform.rotation = Quaternion.Euler(1434f, UnityEngine.Random.value * 142f, 350f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "Shader not found ({0})" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C78 RID: 40056 RVA: 0x00464598 File Offset: 0x00462798
	private void Update()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 0f)
		{
			this.MHCNCGOLIJH();
		}
	}

	// Token: 0x06009C79 RID: 40057 RVA: 0x00464648 File Offset: 0x00462848
	private void EBNINOBOAII()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C7A RID: 40058 RVA: 0x004646B8 File Offset: 0x004628B8
	private void HMEAENGBFKC()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 439f)
		{
			this.CPHKEJILBCK();
		}
	}

	// Token: 0x06009C7B RID: 40059 RVA: 0x00464768 File Offset: 0x00462968
	private void JLFBDOPFDDJ()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 666f)
		{
			this.MHCNCGOLIJH();
		}
	}

	// Token: 0x06009C7C RID: 40060 RVA: 0x00464818 File Offset: 0x00462A18
	private void JIGAFDHOFKL()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C7D RID: 40061 RVA: 0x00464888 File Offset: 0x00462A88
	private void IOIJGMFNBMC()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C7E RID: 40062 RVA: 0x004648F8 File Offset: 0x00462AF8
	public void BFCCJCEFPGJ()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "shop_t13" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1663f, UnityEngine.Random.value * 680f, 1376f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			foreach (WaterCircle waterCircle in base.GetComponentsInChildren<WaterCircle>())
			{
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.HBCELHCNJKJ();
				}
			}
		}
	}

	// Token: 0x06009C7F RID: 40063 RVA: 0x004649D4 File Offset: 0x00462BD4
	private void KOJNOPBGPAM()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C80 RID: 40064 RVA: 0x00464A44 File Offset: 0x00462C44
	private void MNIOJGMLIMC()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C81 RID: 40065 RVA: 0x00464AB4 File Offset: 0x00462CB4
	private void JOHDLNOKCOK()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 930f)
		{
			this.HOIKDKEJJBP();
		}
	}

	// Token: 0x06009C82 RID: 40066 RVA: 0x00464B64 File Offset: 0x00462D64
	private void LACNPNKHCAA()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 305f)
		{
			this.OFKNCJINGBM();
		}
	}

	// Token: 0x06009C83 RID: 40067 RVA: 0x00464C14 File Offset: 0x00462E14
	public void JMLJFLCNOJH()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "WallRunLeft" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(593f, UnityEngine.Random.value * 1593f, 674f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.APPANDNOOLO();
				}
			}
		}
	}

	// Token: 0x06009C84 RID: 40068 RVA: 0x00464CF0 File Offset: 0x00462EF0
	private void JFGGBEGNAFP()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1531f)
		{
			this.DILOBFJJNNE();
		}
	}

	// Token: 0x06009C85 RID: 40069 RVA: 0x00464DA0 File Offset: 0x00462FA0
	private void PNBGJBMJLFM()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1428f)
		{
			this.OFKNCJINGBM();
		}
	}

	// Token: 0x06009C86 RID: 40070 RVA: 0x00464E50 File Offset: 0x00463050
	private void FFIGGPHAIBP()
	{
		base.transform.rotation = Quaternion.Euler(1650f, UnityEngine.Random.value * 1937f, 567f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + " iterations for read and write" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C87 RID: 40071 RVA: 0x00464EB0 File Offset: 0x004630B0
	private void CBLGFOFHNPJ()
	{
		base.transform.rotation = Quaternion.Euler(1685f, UnityEngine.Random.value * 208f, 1269f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "__c" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C88 RID: 40072 RVA: 0x0046435F File Offset: 0x0046255F
	private void MCLIFHOCDHP()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C89 RID: 40073 RVA: 0x00464F10 File Offset: 0x00463110
	public void KMEAHBIOPOD()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "No MeshFilter!" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1507f, UnityEngine.Random.value * 701f, 487f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.GGMGILCNCKL();
				}
			}
		}
	}

	// Token: 0x06009C8A RID: 40074 RVA: 0x00464FEC File Offset: 0x004631EC
	private void HIBOODJBCIE()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C8B RID: 40075 RVA: 0x0046505C File Offset: 0x0046325C
	public void reStart()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "_" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(90f, UnityEngine.Random.value * 360f, 0f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			foreach (WaterCircle waterCircle in base.GetComponentsInChildren<WaterCircle>())
			{
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.reStart();
				}
			}
		}
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x00465138 File Offset: 0x00463338
	private void EFJDBBDMPMC()
	{
		base.transform.rotation = Quaternion.Euler(1612f, UnityEngine.Random.value * 799f, 876f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "+{0}" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x00465198 File Offset: 0x00463398
	private void AAEFACEGJMB()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1396f)
		{
			this.DILOBFJJNNE();
		}
	}

	// Token: 0x06009C8E RID: 40078 RVA: 0x00465248 File Offset: 0x00463448
	public void NFNHCCHOIEJ()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "FaceHit" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1836f, UnityEngine.Random.value * 1708f, 1071f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.FGDJGFEFBJH();
				}
			}
		}
	}

	// Token: 0x06009C90 RID: 40080 RVA: 0x00465394 File Offset: 0x00463594
	private void OGKOHLPFBED()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x00465404 File Offset: 0x00463604
	private void IDMCOLDDNCF()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 421f)
		{
			this.FLBNBOMNCLJ();
		}
	}

	// Token: 0x06009C92 RID: 40082 RVA: 0x004654B4 File Offset: 0x004636B4
	private void LMMDHJJJNJO()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1312f)
		{
			this.OFKNCJINGBM();
		}
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x00465564 File Offset: 0x00463764
	private void HABONMJNDAL()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1719f)
		{
			this.OKKJHIMOOMO();
		}
	}

	// Token: 0x06009C94 RID: 40084 RVA: 0x00465614 File Offset: 0x00463814
	public void GGMGILCNCKL()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "1 Hand Sword Swing" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1613f, UnityEngine.Random.value * 226f, 745f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.reStart();
				}
			}
		}
	}

	// Token: 0x06009C95 RID: 40085 RVA: 0x004656F0 File Offset: 0x004638F0
	private void EMFOECIPBIP()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1817f)
		{
			this.LEAGOFKBFEM();
		}
	}

	// Token: 0x06009C96 RID: 40086 RVA: 0x0046435F File Offset: 0x0046255F
	private void HOIKDKEJJBP()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C97 RID: 40087 RVA: 0x004657A0 File Offset: 0x004639A0
	private void AMDMCKIFBPA()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 144f)
		{
			this.FNPAFEDIMGC();
		}
	}

	// Token: 0x06009C98 RID: 40088 RVA: 0x0046435F File Offset: 0x0046255F
	private void CPHKEJILBCK()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C99 RID: 40089 RVA: 0x00465850 File Offset: 0x00463A50
	private void FGNBLJPOMMD()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009C9A RID: 40090 RVA: 0x00463CDB File Offset: 0x00461EDB
	private void BBMNPAIPEJL()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009C9B RID: 40091 RVA: 0x004644FC File Offset: 0x004626FC
	private void FLBNBOMNCLJ()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009C9C RID: 40092 RVA: 0x0046588C File Offset: 0x00463A8C
	private void ECOOMJKPKCC()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009C9D RID: 40093 RVA: 0x004658FC File Offset: 0x00463AFC
	public void EBBJNMNFFIO()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "https://www.youtube.com/watch?v=wT8fViZpLmQ" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(833f, UnityEngine.Random.value * 1864f, 1933f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.reStart();
				}
			}
		}
	}

	// Token: 0x06009C9E RID: 40094 RVA: 0x004659D8 File Offset: 0x00463BD8
	public void HICHPEDLAAK()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "\n" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1805f, UnityEngine.Random.value * 1439f, 1713f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.GGMGILCNCKL();
				}
			}
		}
	}

	// Token: 0x06009C9F RID: 40095 RVA: 0x0046435F File Offset: 0x0046255F
	private void OKKJHIMOOMO()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x00465AB4 File Offset: 0x00463CB4
	public void EODEBHJJLBH()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "Wizard1HandThrow" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1663f, UnityEngine.Random.value * 1781f, 16f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.HBCELHCNJKJ();
				}
			}
		}
	}

	// Token: 0x06009CA1 RID: 40097 RVA: 0x00465B90 File Offset: 0x00463D90
	private void HCMHMFHMPHN()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x00465C00 File Offset: 0x00463E00
	public void HHIEPGGCFKH()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "CratePull" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(1556f, UnityEngine.Random.value * 799f, 1447f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.HICHPEDLAAK();
				}
			}
		}
	}

	// Token: 0x06009CA3 RID: 40099 RVA: 0x00465CDC File Offset: 0x00463EDC
	private void PPNOJNBFHAP()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009CA4 RID: 40100 RVA: 0x004644FC File Offset: 0x004626FC
	private void DPFHHENPAGH()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009CA5 RID: 40101 RVA: 0x00465D4C File Offset: 0x00463F4C
	private void BHMKAOBHAII()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009CA6 RID: 40102 RVA: 0x0046435F File Offset: 0x0046255F
	private void MHCNCGOLIJH()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009CA7 RID: 40103 RVA: 0x00463CDB File Offset: 0x00461EDB
	private void DNMCFDOJBGF()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009CA8 RID: 40104 RVA: 0x00465DBC File Offset: 0x00463FBC
	private void HDFCIACDDEK()
	{
		base.transform.rotation = Quaternion.Euler(863f, UnityEngine.Random.value * 1598f, 1438f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "______________________________" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009CA9 RID: 40105 RVA: 0x00465E1C File Offset: 0x0046401C
	private void EFCCCKGCOCB()
	{
		base.transform.rotation = Quaternion.Euler(1103f, UnityEngine.Random.value * 1977f, 1806f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "_Offsets" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009CAA RID: 40106 RVA: 0x00465850 File Offset: 0x00463A50
	private void LEAGOFKBFEM()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.FHOMOPEGBJF(this);
		}
	}

	// Token: 0x06009CAB RID: 40107 RVA: 0x00465E7C File Offset: 0x0046407C
	private void HMLNMHOMMNO()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 616f)
		{
			this.CPHKEJILBCK();
		}
	}

	// Token: 0x06009CAC RID: 40108 RVA: 0x00465F2C File Offset: 0x0046412C
	private void CFNLKNOKAGC()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009CAD RID: 40109 RVA: 0x00465F9C File Offset: 0x0046419C
	private void DOHJPDNKALP()
	{
		base.transform.rotation = Quaternion.Euler(70f, UnityEngine.Random.value * 1169f, 446f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "lid" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009CAE RID: 40110 RVA: 0x00465FFC File Offset: 0x004641FC
	private void PFPPDNHLCCA()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 2f)
		{
			this.DPFHHENPAGH();
		}
	}

	// Token: 0x06009CAF RID: 40111 RVA: 0x004660AC File Offset: 0x004642AC
	public void HBCELHCNJKJ()
	{
		this.CMBFFHPEJKO++;
		base.gameObject.name = this.baseName + "Quadruped" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(614f, UnityEngine.Random.value * 1858f, 168f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = true;
		if (this.isCataloger)
		{
			WaterCircle[] componentsInChildren = base.GetComponentsInChildren<WaterCircle>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				WaterCircle waterCircle = componentsInChildren[i];
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.HHIEPGGCFKH();
				}
			}
		}
	}

	// Token: 0x06009CB0 RID: 40112 RVA: 0x00466188 File Offset: 0x00464388
	private void MNAHGMDDHCA()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 91f)
		{
			this.HOIKDKEJJBP();
		}
	}

	// Token: 0x06009CB1 RID: 40113 RVA: 0x00466238 File Offset: 0x00464438
	private void JPHLMNIMDHH()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 1938f)
		{
			this.CPHKEJILBCK();
		}
	}

	// Token: 0x06009CB2 RID: 40114 RVA: 0x004662E8 File Offset: 0x004644E8
	private void Start()
	{
		base.transform.rotation = Quaternion.Euler(90f, UnityEngine.Random.value * 360f, 0f);
		this.IKKPFPJLPOL = true;
		base.gameObject.name = this.baseName + "_" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009CB3 RID: 40115 RVA: 0x00466348 File Offset: 0x00464548
	private void FJEEADNCKAG()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		base.transform.localScale += new Vector3(this.scaleSpeed, this.scaleSpeed, this.scaleSpeed) * Time.deltaTime;
		Color fohdlnkggkm = this.FOHDLNKGGKM;
		fohdlnkggkm.a = this.alfa * this.FOHDLNKGGKM.a;
		base.GetComponent<Renderer>().material.SetColor(this.colorName, fohdlnkggkm);
		this.alfa -= this.alphaSpeed * Time.deltaTime;
		if (this.alfa <= 388f)
		{
			this.JKJJCEIFJOJ();
		}
	}

	// Token: 0x06009CB4 RID: 40116 RVA: 0x004663F8 File Offset: 0x004645F8
	private void OBGHAEMCKCP()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x06009CB5 RID: 40117 RVA: 0x00466468 File Offset: 0x00464668
	public void APPANDNOOLO()
	{
		this.CMBFFHPEJKO += 0;
		base.gameObject.name = this.baseName + "intensity" + this.CMBFFHPEJKO;
		base.transform.rotation = Quaternion.Euler(131f, UnityEngine.Random.value * 379f, 1378f);
		base.transform.localScale = this.CMJOPKLPFMP;
		this.alfa = this.CCOFCHJHAGG;
		this.scaleSpeed = this.HLIBNPIGJMD;
		this.alphaSpeed = this.JKNNFDFMKLB;
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			foreach (WaterCircle waterCircle in base.GetComponentsInChildren<WaterCircle>())
			{
				if (waterCircle != this && !waterCircle.isCataloger)
				{
					waterCircle.EBBJNMNFFIO();
				}
			}
		}
	}

	// Token: 0x06009CB6 RID: 40118 RVA: 0x00466544 File Offset: 0x00464744
	private void KJJNMNKPNCH()
	{
		base.transform.rotation = Quaternion.Euler(517f, UnityEngine.Random.value * 1262f, 135f);
		this.IKKPFPJLPOL = false;
		base.gameObject.name = this.baseName + "Account.getI.servSteamID=" + this.CMBFFHPEJKO;
	}

	// Token: 0x06009CB7 RID: 40119 RVA: 0x0046435F File Offset: 0x0046255F
	private void FNPAFEDIMGC()
	{
		if (LocNewLogic.getI == null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		this.IKKPFPJLPOL = false;
		if (this.isCataloger)
		{
			LocNewLogic.getI.deadCircle(this);
		}
	}

	// Token: 0x06009CB8 RID: 40120 RVA: 0x004665A4 File Offset: 0x004647A4
	private void OAKCEHBONIP()
	{
		this.baseName = base.gameObject.name;
		this.CMJOPKLPFMP = base.transform.localScale;
		this.FOHDLNKGGKM = base.GetComponent<Renderer>().material.GetColor(this.colorName);
		this.CCOFCHJHAGG = this.alfa;
		this.HLIBNPIGJMD = this.scaleSpeed;
		this.JKNNFDFMKLB = this.alphaSpeed;
	}

	// Token: 0x04001469 RID: 5225
	public bool isCataloger = true;

	// Token: 0x0400146A RID: 5226
	public int circleType;

	// Token: 0x0400146B RID: 5227
	public float alfa = 1f;

	// Token: 0x0400146C RID: 5228
	public float scaleSpeed = 0.01f;

	// Token: 0x0400146D RID: 5229
	public float alphaSpeed = 0.5f;

	// Token: 0x0400146E RID: 5230
	public string colorName = "_Color";

	// Token: 0x0400146F RID: 5231
	private float CCOFCHJHAGG = 1f;

	// Token: 0x04001470 RID: 5232
	private float HLIBNPIGJMD = 0.01f;

	// Token: 0x04001471 RID: 5233
	private float JKNNFDFMKLB = 0.5f;

	// Token: 0x04001472 RID: 5234
	private Vector3 CMJOPKLPFMP;

	// Token: 0x04001473 RID: 5235
	private bool IKKPFPJLPOL = true;

	// Token: 0x04001474 RID: 5236
	private Color FOHDLNKGGKM;

	// Token: 0x04001475 RID: 5237
	public string baseName;

	// Token: 0x04001476 RID: 5238
	private int CMBFFHPEJKO;
}
