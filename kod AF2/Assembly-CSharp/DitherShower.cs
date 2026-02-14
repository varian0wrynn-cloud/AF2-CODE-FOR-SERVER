using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000267 RID: 615
public class DitherShower : MonoBehaviour
{
	// Token: 0x06008F44 RID: 36676 RVA: 0x0040E3C0 File Offset: 0x0040C5C0
	private void MLBIHHDOJPF(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					if (material.HasProperty(""))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F45 RID: 36677 RVA: 0x0040E440 File Offset: 0x0040C640
	private void LPHLKENEFBE(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					if (material.HasProperty(" ms"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F46 RID: 36678 RVA: 0x0040E4C0 File Offset: 0x0040C6C0
	private void Update()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 0f, 1f);
	}

	// Token: 0x06008F47 RID: 36679 RVA: 0x0040E4FE File Offset: 0x0040C6FE
	private void PFNOEACNHON()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 126f, 1220f);
	}

	// Token: 0x06008F48 RID: 36680 RVA: 0x0040E53C File Offset: 0x0040C73C
	private void PMKOAHMNBBG()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 51f, 801f);
	}

	// Token: 0x06008F49 RID: 36681 RVA: 0x0040E57C File Offset: 0x0040C77C
	private void DPCMEGCDAJE(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				foreach (Material material in renderer.materials)
				{
					if (material.HasProperty("_alfavis"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F4A RID: 36682 RVA: 0x0040E5FC File Offset: 0x0040C7FC
	private void LACNPNKHCAA()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 1552f, 1031f);
	}

	// Token: 0x06008F4B RID: 36683 RVA: 0x0040E63C File Offset: 0x0040C83C
	private void ONIHHFLOJMN()
	{
		this.alfa = 1717f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.AFOKPLLIMFB(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.GNGJIIIJOIE(componentsInChildren);
		this.MPCBHLFKNJG();
	}

	// Token: 0x06008F4C RID: 36684 RVA: 0x0040E688 File Offset: 0x0040C888
	private void PNAAHEFHPCL()
	{
		this.alfa = 1292f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.HOBMNFOJBKA(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.MLBIHHDOJPF(componentsInChildren);
		this.PKJKDGJENKB();
	}

	// Token: 0x06008F4D RID: 36685 RVA: 0x0040E6D4 File Offset: 0x0040C8D4
	private void DGEIACONKCJ()
	{
		this.alfa = 88f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.OPNHNIIMMHO(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.DAOBILFAKPF(componentsInChildren);
		this.NMFLFLNANLA();
	}

	// Token: 0x06008F4E RID: 36686 RVA: 0x0040E720 File Offset: 0x0040C920
	private void BLIIBPHMEDP()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("__b", this.alfa);
		}
	}

	// Token: 0x06008F4F RID: 36687 RVA: 0x0040E77C File Offset: 0x0040C97C
	private void BEDAJLJFAFO()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 1886f, 37f);
	}

	// Token: 0x06008F50 RID: 36688 RVA: 0x0040E7BA File Offset: 0x0040C9BA
	private void OGEPJALAFOP()
	{
		this.ADLPMMAIMLF();
	}

	// Token: 0x06008F51 RID: 36689 RVA: 0x0040E7C2 File Offset: 0x0040C9C2
	private void MGBNPAPOKBA()
	{
		this.JNFCFFFEMEK();
	}

	// Token: 0x06008F52 RID: 36690 RVA: 0x0040E7CA File Offset: 0x0040C9CA
	private void OnRenderObject()
	{
		this.AIGFEOHDBFI();
	}

	// Token: 0x06008F53 RID: 36691 RVA: 0x0040E7D2 File Offset: 0x0040C9D2
	private void BNKJNBIDPME()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 1285f, 893f);
	}

	// Token: 0x06008F54 RID: 36692 RVA: 0x0040E810 File Offset: 0x0040CA10
	private void KGICJDGIIJK()
	{
		this.alfa = 1576f;
		this.dirVector = 1;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.GNGJIIIJOIE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.LPHLKENEFBE(componentsInChildren);
		this.AIGFEOHDBFI();
	}

	// Token: 0x06008F55 RID: 36693 RVA: 0x0040E85C File Offset: 0x0040CA5C
	private void AFOKPLLIMFB(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 0; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					if (material.HasProperty("FASTEST"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F56 RID: 36694 RVA: 0x0040E8DC File Offset: 0x0040CADC
	private void LDDNKOKHGEP()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("IdleCheer", this.alfa);
		}
	}

	// Token: 0x06008F58 RID: 36696 RVA: 0x0040E960 File Offset: 0x0040CB60
	private void CGMHGDEKDEP()
	{
		this.alfa = 794f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.LPHLKENEFBE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.DPCMEGCDAJE(componentsInChildren);
		this.MDGKEOHEKOM();
	}

	// Token: 0x06008F59 RID: 36697 RVA: 0x0040E9AC File Offset: 0x0040CBAC
	private void HOBMNFOJBKA(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					if (material.HasProperty("Open turnStatus"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F5A RID: 36698 RVA: 0x0040EA2C File Offset: 0x0040CC2C
	private void ANHOOJFEJJE()
	{
		this.alfa = 1626f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.HOBMNFOJBKA(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.LPHLKENEFBE(componentsInChildren);
		this.NMFLFLNANLA();
	}

	// Token: 0x06008F5B RID: 36699 RVA: 0x0040EA78 File Offset: 0x0040CC78
	private void KHJFAOJHBLH()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("SexyDance3", this.alfa);
		}
	}

	// Token: 0x06008F5C RID: 36700 RVA: 0x0040EAD4 File Offset: 0x0040CCD4
	private void DEGCCLNOEKJ()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 176f, 806f);
	}

	// Token: 0x06008F5D RID: 36701 RVA: 0x0040EB12 File Offset: 0x0040CD12
	private void KNEBLGAJKOC()
	{
		this.KHJFAOJHBLH();
	}

	// Token: 0x06008F5E RID: 36702 RVA: 0x0040EB1A File Offset: 0x0040CD1A
	private void JNGIJCIEKKM()
	{
		this.LDDNKOKHGEP();
	}

	// Token: 0x06008F5F RID: 36703 RVA: 0x0040EB24 File Offset: 0x0040CD24
	private void PKJKDGJENKB()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("______________________________", this.alfa);
		}
	}

	// Token: 0x06008F60 RID: 36704 RVA: 0x0040EB80 File Offset: 0x0040CD80
	private void AIGFEOHDBFI()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("_alfavis", this.alfa);
		}
	}

	// Token: 0x06008F61 RID: 36705 RVA: 0x0040EBDC File Offset: 0x0040CDDC
	private void DHJDMKLBLEF()
	{
		this.alfa = 95f;
		this.dirVector = 1;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.DPCMEGCDAJE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.GNGJIIIJOIE(componentsInChildren);
		this.MPCBHLFKNJG();
	}

	// Token: 0x06008F62 RID: 36706 RVA: 0x0040EB1A File Offset: 0x0040CD1A
	private void DOJEPFKMIEH()
	{
		this.LDDNKOKHGEP();
	}

	// Token: 0x06008F63 RID: 36707 RVA: 0x0040EC28 File Offset: 0x0040CE28
	private void DFELJOCEDOB()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat(".", this.alfa);
		}
	}

	// Token: 0x06008F64 RID: 36708 RVA: 0x0040EC84 File Offset: 0x0040CE84
	private void OALHGPCMPJL(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					if (material.HasProperty("PaperTurn.wav"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F65 RID: 36709 RVA: 0x0040ED04 File Offset: 0x0040CF04
	private void NMFLFLNANLA()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("_DstBlend", this.alfa);
		}
	}

	// Token: 0x06008F66 RID: 36710 RVA: 0x0040ED60 File Offset: 0x0040CF60
	private void IJDMCKPCIGN(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				foreach (Material material in renderer.materials)
				{
					if (material.HasProperty("offsets"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F67 RID: 36711 RVA: 0x0040EDE0 File Offset: 0x0040CFE0
	private void INGBDBLGIMN()
	{
		this.MDGKEOHEKOM();
	}

	// Token: 0x06008F68 RID: 36712 RVA: 0x0040EDE8 File Offset: 0x0040CFE8
	private void MDGKEOHEKOM()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("MotorbikeSuperman", this.alfa);
		}
	}

	// Token: 0x06008F69 RID: 36713 RVA: 0x0040EE44 File Offset: 0x0040D044
	private void LMEJKAEIDCO()
	{
		this.alfa = 1018f;
		this.dirVector = 0;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.LPHLKENEFBE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.MLBIHHDOJPF(componentsInChildren);
		this.NMFLFLNANLA();
	}

	// Token: 0x06008F6A RID: 36714 RVA: 0x0040EE90 File Offset: 0x0040D090
	private void DAOBILFAKPF(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				foreach (Material material in renderer.materials)
				{
					if (material.HasProperty("IKMappingSpine is missing the right thigh bone."))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F6B RID: 36715 RVA: 0x0040EF10 File Offset: 0x0040D110
	private void FPLNDDMFFKG()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 1755f, 1537f);
	}

	// Token: 0x06008F6C RID: 36716 RVA: 0x0040EF50 File Offset: 0x0040D150
	private void Start()
	{
		this.alfa = 0f;
		this.dirVector = 1;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.DPCMEGCDAJE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.DPCMEGCDAJE(componentsInChildren);
		this.AIGFEOHDBFI();
	}

	// Token: 0x06008F6D RID: 36717 RVA: 0x0040EF9B File Offset: 0x0040D19B
	private void BGDDPMFPAFP()
	{
		this.PKJKDGJENKB();
	}

	// Token: 0x06008F6E RID: 36718 RVA: 0x0040EFA4 File Offset: 0x0040D1A4
	private void MPCBHLFKNJG()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("lineTENSIONKGFRIC=", this.alfa);
		}
	}

	// Token: 0x06008F6F RID: 36719 RVA: 0x0040EB1A File Offset: 0x0040CD1A
	private void HGDPLCKDIIC()
	{
		this.LDDNKOKHGEP();
	}

	// Token: 0x06008F70 RID: 36720 RVA: 0x0040F000 File Offset: 0x0040D200
	private void CKNPFOICFDJ()
	{
		this.BLIIBPHMEDP();
	}

	// Token: 0x06008F71 RID: 36721 RVA: 0x0040F008 File Offset: 0x0040D208
	private void AIAMIFEPALP()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 209f, 988f);
	}

	// Token: 0x06008F72 RID: 36722 RVA: 0x0040EB1A File Offset: 0x0040CD1A
	private void KKFBMAGLCEH()
	{
		this.LDDNKOKHGEP();
	}

	// Token: 0x06008F73 RID: 36723 RVA: 0x0040F046 File Offset: 0x0040D246
	private void DFFOEGHGPGP()
	{
		this.alfa += (float)this.dirVector * Time.deltaTime * this.scaleAlfaKF;
		this.alfa = Mathf.Clamp(this.alfa, 1279f, 719f);
	}

	// Token: 0x06008F74 RID: 36724 RVA: 0x0040F084 File Offset: 0x0040D284
	private void ADLPMMAIMLF()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("Loading Asset Bundle ", this.alfa);
		}
	}

	// Token: 0x06008F75 RID: 36725 RVA: 0x0040F0E0 File Offset: 0x0040D2E0
	private void AEBIFFIJNIH()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("aptek.ogg", this.alfa);
		}
	}

	// Token: 0x06008F76 RID: 36726 RVA: 0x0040F13C File Offset: 0x0040D33C
	private void OPNHNIIMMHO(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				foreach (Material material in renderer.materials)
				{
					if (material.HasProperty("from friend"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F77 RID: 36727 RVA: 0x0040F1BC File Offset: 0x0040D3BC
	private void FNGAMMBKAIG()
	{
		this.AEBIFFIJNIH();
	}

	// Token: 0x06008F78 RID: 36728 RVA: 0x0040F1C4 File Offset: 0x0040D3C4
	private void PFNPOHMMJDN()
	{
		this.alfa = 1682f;
		this.dirVector = 1;
		Renderer[] components = base.gameObject.GetComponents<Renderer>();
		this.GNGJIIIJOIE(components);
		Renderer[] componentsInChildren = base.gameObject.GetComponentsInChildren<Renderer>();
		this.IJDMCKPCIGN(componentsInChildren);
		this.PKJKDGJENKB();
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x0040F210 File Offset: 0x0040D410
	private void GNGJIIIJOIE(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					if (material.HasProperty("MotorbikeHandstand"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x0040F290 File Offset: 0x0040D490
	private void MOIMNFDJPAO(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				foreach (Material material in renderer.materials)
				{
					if (material.HasProperty("Hyperlink_"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x0040F310 File Offset: 0x0040D510
	private void JNFCFFFEMEK()
	{
		foreach (Material material in this.currentRenders)
		{
			material.SetFloat("Downsamp", this.alfa);
		}
	}

	// Token: 0x06008F7C RID: 36732 RVA: 0x0040F36C File Offset: 0x0040D56C
	private void FDGANCGMFML(IEnumerable<Renderer> NKLCJOHOJAE)
	{
		foreach (Renderer renderer in NKLCJOHOJAE)
		{
			if (renderer != null)
			{
				Material[] materials = renderer.materials;
				for (int i = 0; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					if (material.HasProperty("\n"))
					{
						this.currentRenders.Add(material);
					}
				}
			}
		}
	}

	// Token: 0x04001338 RID: 4920
	public float scaleAlfaKF = 1f;

	// Token: 0x04001339 RID: 4921
	public float alfa;

	// Token: 0x0400133A RID: 4922
	public int dirVector = 1;

	// Token: 0x0400133B RID: 4923
	public List<Material> currentRenders = new List<Material>();
}
