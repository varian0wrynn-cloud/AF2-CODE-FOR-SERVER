using System;
using UnityEngine;

// Token: 0x02000066 RID: 102
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class qd_Decal : MonoBehaviour
{
	// Token: 0x060016E3 RID: 5859 RVA: 0x000C59B6 File Offset: 0x000C3BB6
	private void Awake()
	{
		this.Verify();
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x000C59BE File Offset: 0x000C3BBE
	private void EBNINOBOAII()
	{
		this.EBJILPKNNHO();
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x000C59C8 File Offset: 0x000C3BC8
	public void KAPJHPJNEON()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x000C5A34 File Offset: 0x000C3C34
	public void IAMLMCDGPNI()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.PIEEBFBIGBI));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("IdleSpew"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[0].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.IBFIHOCLGCE(":" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void FMNDBIBONEN(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x000C5B18 File Offset: 0x000C3D18
	public void FDHDGOLMMME()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.HMAIOOFGEJB));
			if (array == null || array.Length < 0)
			{
				material = new Material(Shader.Find(""));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[0].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.KODLGBCPKOO("_TreatBackfaceHitAsMiss" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void HBAFBNLECBI(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void KFKALMMPODD(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x000C5BF4 File Offset: 0x000C3DF4
	public void ECHGGJJCIEK()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x000C5C5E File Offset: 0x000C3E5E
	private void ENJFBODNKHO()
	{
		this.IAMLMCDGPNI();
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x000C59B6 File Offset: 0x000C3BB6
	private void DJIFJMEEBKA()
	{
		this.Verify();
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void JOCONJKIAOH(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x000C59B6 File Offset: 0x000C3BB6
	private void AHILDBJHCKI()
	{
		this.Verify();
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x000C5C70 File Offset: 0x000C3E70
	public void CIDEJIDBOAO()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x000C5CDC File Offset: 0x000C3EDC
	public void KOILAAKJGIJ()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x000C5C5E File Offset: 0x000C3E5E
	private void IOIJGMFNBMC()
	{
		this.IAMLMCDGPNI();
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x000C5D48 File Offset: 0x000C3F48
	public void Verify()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.NNEFBGOOJAC));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("Transparent/Diffuse"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[0].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.MPBCENPHPPK("DecalMesh" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void JLDIJFPOBAD(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x000C5E22 File Offset: 0x000C4022
	private void DOBFKBMGMNA()
	{
		this.OHEEEIBGPDF();
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D JMDCDPCGFFM()
	{
		return this._texture;
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x000C5E34 File Offset: 0x000C4034
	public void JCPNBAMDHDL(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[0];
		array[0] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[0] = new Vector2(this._rect.x, this._rect.y);
		array[8] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[0] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void OPCGNLABCPC(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x000C5F18 File Offset: 0x000C4118
	public void FLPEFAGNAHC()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x000C59B6 File Offset: 0x000C3BB6
	private void BJHFBOLNMDK()
	{
		this.Verify();
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void MHEKEBEPODJ(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void JKEAGOHGBIA(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x000C5F84 File Offset: 0x000C4184
	public void BNDJCCJDPKO()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D NAANICODLDP()
	{
		return this._texture;
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x000C5FF0 File Offset: 0x000C41F0
	public void HFDAIIHOHJH()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.DHKMMELGJAN));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("bag"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[1].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNNLAJPAGNC("offsets" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06001700 RID: 5888 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D KEDGAOBCNJG
	{
		get
		{
			return this._texture;
		}
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x000C60CC File Offset: 0x000C42CC
	public void FreezeTransform()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void MFNHOJLDCBC(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x000C6136 File Offset: 0x000C4336
	private void MGNGNBMMAAD()
	{
		this.CGIIEDNGBCB();
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x000C6140 File Offset: 0x000C4340
	public void KJBKJPJGGDN(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[1];
		array[1] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[0] = new Vector2(this._rect.x, this._rect.y);
		array[4] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[4] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void FBNMFKJEMBN(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D FEDJJIGCAGC()
	{
		return this._texture;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D HONJOFFBOPH()
	{
		return this._texture;
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void GIBHNOPEFNH(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x000C6224 File Offset: 0x000C4424
	public void HNDFMKHELEE(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[7];
		array[0] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[1] = new Vector2(this._rect.x, this._rect.y);
		array[1] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[5] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x000C6308 File Offset: 0x000C4508
	public void OAMDIOHDDFF()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void ABAHIMLNFIM(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D IOHNCGLFGDJ()
	{
		return this._texture;
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x000C59BE File Offset: 0x000C3BBE
	private void JGKDNHLKBEN()
	{
		this.EBJILPKNNHO();
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x000C6374 File Offset: 0x000C4574
	public void EDNEFHHJLHP(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[7];
		array[1] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[1] = new Vector2(this._rect.x, this._rect.y);
		array[0] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[6] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x000C6458 File Offset: 0x000C4658
	public void DIDGOCHOHBP()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void SetTexture(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x000C59BE File Offset: 0x000C3BBE
	private void OGKKCIOKGJE()
	{
		this.EBJILPKNNHO();
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x000C59B6 File Offset: 0x000C3BB6
	private void CNKLGMCHEBM()
	{
		this.Verify();
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D LECMGDEDAKF()
	{
		return this._texture;
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void AKGPDEBFHFB(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x000C64C4 File Offset: 0x000C46C4
	public void MECLAGCAABH(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[6];
		array[0] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[1] = new Vector2(this._rect.x, this._rect.y);
		array[6] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[8] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D MJLGIMHBMKN()
	{
		return this._texture;
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void KLJGNODGHCK(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void SetScale(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void KDGBGNCIDCK(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void IMBKLBKFGBG(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void JHBGCFBMAPD(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x000C65A8 File Offset: 0x000C47A8
	private void FDKGOFHFOLH()
	{
		this.DJMAAJAGBMF();
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void EIMOPODILOP(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void JJNKOKEKAGK(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x000C65B0 File Offset: 0x000C47B0
	public void DJMAAJAGBMF()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.HMAIOOFGEJB));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("AppID:"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[1].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.MDBDNPOLCPG("Wand/Staff" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x000C5E2A File Offset: 0x000C402A
	public Texture2D PFFJJEJNKPB()
	{
		return this._texture;
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x000C668C File Offset: 0x000C488C
	public void EMAOAAFGCNL(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] array = new Vector2[0];
		array[0] = new Vector2(this._rect.x + this._rect.width, this._rect.y);
		array[0] = new Vector2(this._rect.x, this._rect.y);
		array[2] = new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height);
		array[0] = new Vector2(this._rect.x, this._rect.y + this._rect.height);
		Vector2[] uv = array;
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x000C5B0E File Offset: 0x000C3D0E
	public void EDBOJAMPMEH(float PNMCPDJCKME)
	{
		this._scale = PNMCPDJCKME;
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x000C6770 File Offset: 0x000C4970
	public void EBJILPKNNHO()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.DHKMMELGJAN));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("FistPump2"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[1].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.IBFIHOCLGCE("minWgtBait" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x000C684C File Offset: 0x000C4A4C
	public void BEOGECFCOHJ()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x000C68B8 File Offset: 0x000C4AB8
	public void OHEEEIBGPDF()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.NCHGLGDKAAJ));
			if (array == null || array.Length < 1)
			{
				material = new Material(Shader.Find("Cards"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[1].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.OCABHMBJAMA("' that does not excist in the Node Chain." + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x000C6994 File Offset: 0x000C4B94
	public void LLBKGDANFJB()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x000C6A00 File Offset: 0x000C4C00
	public void CGIIEDNGBCB()
	{
		Material material = base.GetComponent<MeshRenderer>().sharedMaterial;
		if (material == null)
		{
			GameObject[] array = LOKONCPEENH.GPNGKANKDMF(this._texture);
			array = Array.FindAll<GameObject>(array, new Predicate<GameObject>(qd_Decal.<>c.<>9.FJAFJIEMJDD));
			if (array == null || array.Length < 0)
			{
				material = new Material(Shader.Find("Flap_08.wav"));
				material.mainTexture = this._texture;
			}
			else
			{
				material = array[0].GetComponent<MeshRenderer>().sharedMaterial;
			}
			base.GetComponent<MeshRenderer>().sharedMaterial = material;
		}
		if (base.GetComponent<MeshFilter>().sharedMesh == null)
		{
			base.GetComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.DFMILHLPHAJ("#400000" + base.GetInstanceID(), material, this._rect, this._scale);
		}
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x000C6ADC File Offset: 0x000C4CDC
	public void HFMPDPHPJFI()
	{
		Vector3 localScale = base.transform.localScale;
		Mesh sharedMesh = base.transform.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			vertices[i] = Vector3.Scale(vertices[i], localScale);
		}
		sharedMesh.vertices = vertices;
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x000C5C5E File Offset: 0x000C3E5E
	private void CCPOIOJPKIF()
	{
		this.IAMLMCDGPNI();
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void HFIPECPJKBD(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x000C6B48 File Offset: 0x000C4D48
	public void SetUVRect(Rect AJMNDCHJPNK)
	{
		this._rect = AJMNDCHJPNK;
		Vector2[] uv = new Vector2[]
		{
			new Vector2(this._rect.x + this._rect.width, this._rect.y),
			new Vector2(this._rect.x, this._rect.y),
			new Vector2(this._rect.x + this._rect.width, this._rect.y + this._rect.height),
			new Vector2(this._rect.x, this._rect.y + this._rect.height)
		};
		base.GetComponent<MeshFilter>().sharedMesh.uv = uv;
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x000C5C66 File Offset: 0x000C3E66
	public void AFHBEPKNJMI(Texture2D NAGPDILILNL)
	{
		this._texture = NAGPDILILNL;
	}

	// Token: 0x0400027D RID: 637
	[SerializeField]
	[HideInInspector]
	private Texture2D _texture;

	// Token: 0x0400027E RID: 638
	[SerializeField]
	[HideInInspector]
	private Rect _rect;

	// Token: 0x0400027F RID: 639
	[SerializeField]
	[HideInInspector]
	private float _scale;
}
