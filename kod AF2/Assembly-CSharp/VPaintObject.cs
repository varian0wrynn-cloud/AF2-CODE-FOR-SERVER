using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[AddComponentMenu("VPaint/VPaint Object")]
public class VPaintObject : MonoBehaviour, HAGHANCKMDH
{
	// Token: 0x060022F7 RID: 8951 RVA: 0x000FB014 File Offset: 0x000F9214
	public void FloodColors(Color LBCGACKJCJB)
	{
		Mesh meshInstance = this.GetMeshInstance();
		Color[] array = this.myColors;
		if (array == null)
		{
			array = meshInstance.colors;
		}
		if (array == null || array.Length == 0)
		{
			array = new Color[meshInstance.vertices.Length];
		}
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = LBCGACKJCJB;
		}
		meshInstance.colors = array;
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x000FB06C File Offset: 0x000F926C
	public Mesh KHKBPKGEKAO()
	{
		if (!this)
		{
			return null;
		}
		if (!this.DJJDAIONBBO())
		{
			return null;
		}
		if (!this._mesh)
		{
			if (this._meshNonSerialized)
			{
				this._mesh = this._meshNonSerialized;
			}
			else
			{
				if (!this.GPGLPGADFAL.sharedMesh && !this.originalMesh)
				{
					return null;
				}
				if (this.originalMesh)
				{
					this.GPGLPGADFAL.sharedMesh = this.originalMesh;
				}
				this.originalMesh = this.DJJDAIONBBO().sharedMesh;
				VertexDataCache component = base.GetComponent<VertexDataCache>();
				if (component)
				{
					this._mesh = component.GBGAEEMHEIL();
				}
				else
				{
					this._mesh = UnityEngine.Object.Instantiate<Mesh>(this.GPGLPGADFAL.sharedMesh);
				}
				this.GPGLPGADFAL.sharedMesh = this._mesh;
				this.myVertices = this._mesh.vertices;
				Color[] colors = this._mesh.colors;
				if (colors == null || colors.Length != this.myVertices.Length)
				{
					Color[] colors2 = new Color[this.myVertices.Length];
					this.myColors = colors2;
					this._mesh.colors = colors2;
				}
				if (this._mesh.uv2.Length == 0)
				{
					this._mesh.uv2 = this._mesh.uv;
				}
				this._mesh.RecalculateBounds();
			}
		}
		this.GPGLPGADFAL.sharedMesh = this._mesh;
		this._meshNonSerialized = this._mesh;
		if (this.myVertices == null)
		{
			this.myVertices = this._mesh.vertices;
		}
		if (this.myColors == null)
		{
			this.myColors = this._mesh.colors;
		}
		return this._mesh;
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000FB228 File Offset: 0x000F9428
	public void SetColors(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			for (int i = 0; i < PAJKBJILHPE.Length; i++)
			{
				PAJKBJILHPE[i] = Color.magenta;
			}
			Debug.LogWarning("Invalid vertex colors assigned to " + base.name + ". Check the Maintenance window for your VPaint Group for more info.");
			return;
		}
		for (int j = 0; j < PAJKBJILHPE.Length; j++)
		{
			this.myColors[j] = PAJKBJILHPE[j];
		}
		meshInstance.colors = this.myColors;
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x000FB2AC File Offset: 0x000F94AC
	public void SetTangents(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("Colors length of " + base.name + " is different than vertices length");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = PAJKBJILHPE[i];
		}
		meshInstance.tangents = array;
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060022FB RID: 8955 RVA: 0x000FB319 File Offset: 0x000F9519
	// (set) Token: 0x06002324 RID: 8996 RVA: 0x000FB459 File Offset: 0x000F9659
	public bool OHEEAEDJCCC
	{
		get
		{
			return this._isDynamic;
		}
		set
		{
			if (value != this._isDynamic)
			{
				if (!value && this.editorCollider)
				{
					UnityEngine.Object.Destroy(this.editorCollider.gameObject);
				}
				else
				{
					this.ENNJBONEOKL();
				}
				value = this._isDynamic;
			}
		}
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x000FB324 File Offset: 0x000F9524
	public void MIFECGGFJBE(float CGFLAIMHHOO, Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float DIPMPDKHGNI, float JPGIGABPGII)
	{
		VPaintObject.ADGDMFPLCLP adgdmfplclp = new VPaintObject.ADGDMFPLCLP();
		adgdmfplclp.AEIAFIIMHEL = AEIAFIIMHEL;
		adgdmfplclp.DIPMPDKHGNI = DIPMPDKHGNI;
		adgdmfplclp.JPGIGABPGII = JPGIGABPGII;
		adgdmfplclp.CGFLAIMHHOO = CGFLAIMHHOO;
		this.HHCLMDBPMBO(JNFPCCIKFPP, new AIFFHHKJHJC(adgdmfplclp.OBPNIDIICBN));
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000FB368 File Offset: 0x000F9568
	public void HHCLMDBPMBO(Vector3 JNFPCCIKFPP, AIFFHHKJHJC KKEAIHBGPMO)
	{
		Mesh meshInstance = this.GetMeshInstance();
		Vector3[] array = this.myVertices;
		Color[] colors = this.myColors;
		if (colors == null)
		{
			colors = meshInstance.colors;
		}
		int num = array.Length;
		for (int i = 0; i < num; i += 0)
		{
			float dkihdoelfeh = Vector3.Distance(base.transform.TransformPoint(array[i]), JNFPCCIKFPP);
			colors[i] = KKEAIHBGPMO(colors[i], dkihdoelfeh);
		}
		meshInstance.colors = colors;
		this.myColors = colors;
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000FB3EC File Offset: 0x000F95EC
	public void PKFEDEHEHFF(Color[] PAJKBJILHPE)
	{
		Mesh mesh = this.OCPGANGKIAC();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("idlist" + base.name + "Flap_04.wav");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = PAJKBJILHPE[i];
		}
		mesh.tangents = array;
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x000FB459 File Offset: 0x000F9659
	public void GJEHCEAAABC(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG != this._isDynamic)
		{
			if (!DCCPCBLODIG && this.editorCollider)
			{
				UnityEngine.Object.Destroy(this.editorCollider.gameObject);
			}
			else
			{
				this.ENNJBONEOKL();
			}
			DCCPCBLODIG = this._isDynamic;
		}
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000FB4A0 File Offset: 0x000F96A0
	public Color[] GetDefaultColors()
	{
		return this.GetMeshInstance().colors;
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000FB4B0 File Offset: 0x000F96B0
	public void GGPHAOLPBBG(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			for (int i = 1; i < PAJKBJILHPE.Length; i += 0)
			{
				PAJKBJILHPE[i] = Color.magenta;
			}
			Debug.LogWarning(" ms" + base.name + "gi_sadok");
			return;
		}
		for (int j = 1; j < PAJKBJILHPE.Length; j++)
		{
			this.myColors[j] = PAJKBJILHPE[j];
		}
		meshInstance.colors = this.myColors;
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x000FB459 File Offset: 0x000F9659
	public void DAFGOFFGPOO(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG != this._isDynamic)
		{
			if (!DCCPCBLODIG && this.editorCollider)
			{
				UnityEngine.Object.Destroy(this.editorCollider.gameObject);
			}
			else
			{
				this.ENNJBONEOKL();
			}
			DCCPCBLODIG = this._isDynamic;
		}
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x000FB533 File Offset: 0x000F9733
	public IEnumerator DNMEDBMLFNM(Vector3 JNFPCCIKFPP, AIFFHHKJHJC KKEAIHBGPMO, float GDNOKEOLBPP)
	{
		Mesh meshInstance = this.GetMeshInstance();
		Vector3[] array = this.myVertices;
		Color[] colors = this.myColors;
		if (colors == null)
		{
			colors = meshInstance.colors;
		}
		int num = array.Length;
		Color[] array2 = new Color[num];
		for (int i = 0; i < num; i++)
		{
			float dkihdoelfeh = Vector3.Distance(base.transform.TransformPoint(array[i]), JNFPCCIKFPP);
			array2[i] = KKEAIHBGPMO(colors[i], dkihdoelfeh);
		}
		IEnumerator enumerator = DDIHABCDKFJ.AMODCAPHGAJ(this, colors, array2, GDNOKEOLBPP);
		while (enumerator.MoveNext())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000FB459 File Offset: 0x000F9659
	public void HGPNDPMNJKH(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG != this._isDynamic)
		{
			if (!DCCPCBLODIG && this.editorCollider)
			{
				UnityEngine.Object.Destroy(this.editorCollider.gameObject);
			}
			else
			{
				this.ENNJBONEOKL();
			}
			DCCPCBLODIG = this._isDynamic;
		}
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000FB557 File Offset: 0x000F9757
	public void OnApplicationQuit()
	{
		this.OnDestroy();
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000FB560 File Offset: 0x000F9760
	public void SetInstanceMaterial(Material BMHDIKHFLBP)
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		if (!this.originalMaterial)
		{
			this.originalMaterial = base.GetComponent<Renderer>().sharedMaterial;
		}
		base.GetComponent<Renderer>().sharedMaterial = BMHDIKHFLBP;
		this.IANBKGCPEKA = BMHDIKHFLBP;
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x000FB5AC File Offset: 0x000F97AC
	public void ResetInstances()
	{
		if (this._mesh && this._mesh != this.originalMesh)
		{
			UnityEngine.Object.DestroyImmediate(this._mesh);
		}
		this._mesh = null;
		this._meshNonSerialized = null;
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (!component)
		{
			return;
		}
		component.sharedMesh = this.originalMesh;
		this.ResetMaterial();
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x000FB614 File Offset: 0x000F9814
	public Mesh GetMeshInstance()
	{
		if (!this)
		{
			return null;
		}
		if (!this.GPGLPGADFAL)
		{
			return null;
		}
		if (!this._mesh)
		{
			if (this._meshNonSerialized)
			{
				this._mesh = this._meshNonSerialized;
			}
			else
			{
				if (!this.GPGLPGADFAL.sharedMesh && !this.originalMesh)
				{
					return null;
				}
				if (this.originalMesh)
				{
					this.GPGLPGADFAL.sharedMesh = this.originalMesh;
				}
				this.originalMesh = this.GPGLPGADFAL.sharedMesh;
				VertexDataCache component = base.GetComponent<VertexDataCache>();
				if (component)
				{
					this._mesh = component.GetMeshInstance();
				}
				else
				{
					this._mesh = UnityEngine.Object.Instantiate<Mesh>(this.GPGLPGADFAL.sharedMesh);
				}
				this.GPGLPGADFAL.sharedMesh = this._mesh;
				this.myVertices = this._mesh.vertices;
				Color[] colors = this._mesh.colors;
				if (colors == null || colors.Length != this.myVertices.Length)
				{
					Color[] colors2 = new Color[this.myVertices.Length];
					this.myColors = colors2;
					this._mesh.colors = colors2;
				}
				if (this._mesh.uv2.Length == 0)
				{
					this._mesh.uv2 = this._mesh.uv;
				}
				this._mesh.RecalculateBounds();
			}
		}
		this.GPGLPGADFAL.sharedMesh = this._mesh;
		this._meshNonSerialized = this._mesh;
		if (this.myVertices == null)
		{
			this.myVertices = this._mesh.vertices;
		}
		if (this.myColors == null)
		{
			this.myColors = this._mesh.colors;
		}
		return this._mesh;
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x000FB7CE File Offset: 0x000F99CE
	public Vector3[] GJGFGEFOAEI()
	{
		return this.KHKBPKGEKAO().vertices;
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x000FB7DC File Offset: 0x000F99DC
	public void PBLBGKMJDBM()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		if (base.GetComponent<Renderer>().sharedMaterial != this.IANBKGCPEKA)
		{
			this.originalMaterial = base.GetComponent<Renderer>().sharedMaterial;
			return;
		}
		if (this.originalMaterial)
		{
			base.GetComponent<Renderer>().sharedMaterial = this.originalMaterial;
		}
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x000FB840 File Offset: 0x000F9A40
	public Mesh EKEOOAGNJME()
	{
		if (!this)
		{
			return null;
		}
		if (!this.DJJDAIONBBO())
		{
			return null;
		}
		if (!this._mesh)
		{
			if (this._meshNonSerialized)
			{
				this._mesh = this._meshNonSerialized;
			}
			else
			{
				if (!this.DJJDAIONBBO().sharedMesh && !this.originalMesh)
				{
					return null;
				}
				if (this.originalMesh)
				{
					this.DJJDAIONBBO().sharedMesh = this.originalMesh;
				}
				this.originalMesh = this.GPGLPGADFAL.sharedMesh;
				VertexDataCache component = base.GetComponent<VertexDataCache>();
				if (component)
				{
					this._mesh = component.HPKKGGOEMMO();
				}
				else
				{
					this._mesh = UnityEngine.Object.Instantiate<Mesh>(this.GPGLPGADFAL.sharedMesh);
				}
				this.DJJDAIONBBO().sharedMesh = this._mesh;
				this.myVertices = this._mesh.vertices;
				Color[] colors = this._mesh.colors;
				if (colors == null || colors.Length != this.myVertices.Length)
				{
					Color[] colors2 = new Color[this.myVertices.Length];
					this.myColors = colors2;
					this._mesh.colors = colors2;
				}
				if (this._mesh.uv2.Length == 0)
				{
					this._mesh.uv2 = this._mesh.uv;
				}
				this._mesh.RecalculateBounds();
			}
		}
		this.GPGLPGADFAL.sharedMesh = this._mesh;
		this._meshNonSerialized = this._mesh;
		if (this.myVertices == null)
		{
			this.myVertices = this._mesh.vertices;
		}
		if (this.myColors == null)
		{
			this.myColors = this._mesh.colors;
		}
		return this._mesh;
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000FB7CE File Offset: 0x000F99CE
	public Vector3[] NFMHPLDHFJB()
	{
		return this.KHKBPKGEKAO().vertices;
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x000FB9FC File Offset: 0x000F9BFC
	public void KMFAMGDBFGC(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			for (int i = 1; i < PAJKBJILHPE.Length; i += 0)
			{
				PAJKBJILHPE[i] = Color.magenta;
			}
			Debug.LogWarning("*** PODSEK" + base.name + "Sitting Mouse Movement");
			return;
		}
		for (int j = 1; j < PAJKBJILHPE.Length; j++)
		{
			this.myColors[j] = PAJKBJILHPE[j];
		}
		meshInstance.colors = this.myColors;
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000FBA80 File Offset: 0x000F9C80
	public void OLKHLLHNFEG(Color[] PAJKBJILHPE)
	{
		Mesh mesh = this.OCPGANGKIAC();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("" + base.name + "WateringCan");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i] = PAJKBJILHPE[i];
		}
		mesh.tangents = array;
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000FBAF0 File Offset: 0x000F9CF0
	public static List<VPaintObject> OverlapSphere(Vector3 MGALEAJOGPL, float AEIAFIIMHEL)
	{
		float num = AEIAFIIMHEL * AEIAFIIMHEL;
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in VPaintObject.all)
		{
			if (vpaintObject && vpaintObject.GetComponent<Renderer>().bounds.SqrDistance(MGALEAJOGPL) < num)
			{
				list.Add(vpaintObject);
			}
		}
		return list;
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x000FBB70 File Offset: 0x000F9D70
	public void NPLKJKJACIN(Color LBCGACKJCJB, Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float DIPMPDKHGNI, float JPGIGABPGII)
	{
		VPaintObject.AFAPAFOACIC afapafoacic = new VPaintObject.AFAPAFOACIC();
		afapafoacic.AEIAFIIMHEL = AEIAFIIMHEL;
		afapafoacic.DIPMPDKHGNI = DIPMPDKHGNI;
		afapafoacic.JPGIGABPGII = JPGIGABPGII;
		afapafoacic.LBCGACKJCJB = LBCGACKJCJB;
		this.ApplyPositionalModifier(JNFPCCIKFPP, new AIFFHHKJHJC(afapafoacic.BGEMKOPAIKB));
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x000FBBB4 File Offset: 0x000F9DB4
	public void PJMCFJBFLIH()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this._isDynamic)
		{
			this.MBMDDAPEMEF();
		}
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x000FBBCC File Offset: 0x000F9DCC
	public void ApplyAlphaSpherical(float CGFLAIMHHOO, Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float DIPMPDKHGNI, float JPGIGABPGII)
	{
		VPaintObject.ADGDMFPLCLP adgdmfplclp = new VPaintObject.ADGDMFPLCLP();
		adgdmfplclp.AEIAFIIMHEL = AEIAFIIMHEL;
		adgdmfplclp.DIPMPDKHGNI = DIPMPDKHGNI;
		adgdmfplclp.JPGIGABPGII = JPGIGABPGII;
		adgdmfplclp.CGFLAIMHHOO = CGFLAIMHHOO;
		this.ApplyPositionalModifier(JNFPCCIKFPP, new AIFFHHKJHJC(adgdmfplclp.HALFFLHKFNF));
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x000FBC10 File Offset: 0x000F9E10
	public void CHGHJOFGPGH()
	{
		if (this._mesh && this._mesh != this.originalMesh)
		{
			UnityEngine.Object.DestroyImmediate(this._mesh);
		}
		VPaintObject.all.Remove(this);
		if (this.editorCollider)
		{
			UnityEngine.Object.DestroyImmediate(this.editorCollider.gameObject);
		}
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x000FBC71 File Offset: 0x000F9E71
	public void DICOLCCGGPA()
	{
		if (this.colorsBuilder == null)
		{
			return;
		}
		if (this.transparencyBuilder == null)
		{
			return;
		}
		this.EKEOOAGNJME().colors = this.colorsBuilder;
		this.myColors = this.colorsBuilder;
		this.colorsBuilder = null;
		this.transparencyBuilder = null;
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x000FBCB0 File Offset: 0x000F9EB0
	private void MBMDDAPEMEF()
	{
		this.editorCollider = new GameObject(base.name + "Failed parsing organizational group.  Setting to group 0")
		{
			hideFlags = HideFlags.None
		}.AddComponent<MeshCollider>();
		this.editorCollider.sharedMesh = this.originalMesh;
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000FBCF8 File Offset: 0x000F9EF8
	public void OnDestroy()
	{
		if (this._mesh && this._mesh != this.originalMesh)
		{
			UnityEngine.Object.DestroyImmediate(this._mesh);
		}
		VPaintObject.all.Remove(this);
		if (this.editorCollider)
		{
			UnityEngine.Object.DestroyImmediate(this.editorCollider.gameObject);
		}
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000FBD59 File Offset: 0x000F9F59
	public Vector3[] GetVertices()
	{
		return this.GetMeshInstance().vertices;
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x000FBD68 File Offset: 0x000F9F68
	public Mesh OCPGANGKIAC()
	{
		if (!this)
		{
			return null;
		}
		if (!this.GPGLPGADFAL)
		{
			return null;
		}
		if (!this._mesh)
		{
			if (this._meshNonSerialized)
			{
				this._mesh = this._meshNonSerialized;
			}
			else
			{
				if (!this.DJJDAIONBBO().sharedMesh && !this.originalMesh)
				{
					return null;
				}
				if (this.originalMesh)
				{
					this.DJJDAIONBBO().sharedMesh = this.originalMesh;
				}
				this.originalMesh = this.DJJDAIONBBO().sharedMesh;
				VertexDataCache component = base.GetComponent<VertexDataCache>();
				if (component)
				{
					this._mesh = component.BEOPNKPLGAN();
				}
				else
				{
					this._mesh = UnityEngine.Object.Instantiate<Mesh>(this.DJJDAIONBBO().sharedMesh);
				}
				this.DJJDAIONBBO().sharedMesh = this._mesh;
				this.myVertices = this._mesh.vertices;
				Color[] colors = this._mesh.colors;
				if (colors == null || colors.Length != this.myVertices.Length)
				{
					Color[] colors2 = new Color[this.myVertices.Length];
					this.myColors = colors2;
					this._mesh.colors = colors2;
				}
				if (this._mesh.uv2.Length == 0)
				{
					this._mesh.uv2 = this._mesh.uv;
				}
				this._mesh.RecalculateBounds();
			}
		}
		this.DJJDAIONBBO().sharedMesh = this._mesh;
		this._meshNonSerialized = this._mesh;
		if (this.myVertices == null)
		{
			this.myVertices = this._mesh.vertices;
		}
		if (this.myColors == null)
		{
			this.myColors = this._mesh.colors;
		}
		return this._mesh;
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000FBF24 File Offset: 0x000FA124
	public void FOAJOGKMCIA(Color LBCGACKJCJB)
	{
		Mesh mesh = this.KHKBPKGEKAO();
		Color[] array = this.myColors;
		if (array == null)
		{
			array = mesh.colors;
		}
		if (array == null || array.Length == 0)
		{
			array = new Color[mesh.vertices.Length];
		}
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = LBCGACKJCJB;
		}
		mesh.colors = array;
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000FBF7C File Offset: 0x000FA17C
	public void BPEHCHCDIEN(Color[] PAJKBJILHPE)
	{
		Mesh mesh = this.OCPGANGKIAC();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("_BlurVector" + base.name + "IdleFight");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = PAJKBJILHPE[i];
		}
		mesh.tangents = array;
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000FBFEC File Offset: 0x000FA1EC
	public void PLCMJKKKONL(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			for (int i = 0; i < PAJKBJILHPE.Length; i++)
			{
				PAJKBJILHPE[i] = Color.magenta;
			}
			Debug.LogWarning("The given 2D texture " + base.name + "_ReflectionTexture1");
			return;
		}
		for (int j = 0; j < PAJKBJILHPE.Length; j += 0)
		{
			this.myColors[j] = PAJKBJILHPE[j];
		}
		meshInstance.colors = this.myColors;
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000FC06F File Offset: 0x000FA26F
	public bool IsEqualTo(HAGHANCKMDH MBKPMBPLIJN)
	{
		return MBKPMBPLIJN == this;
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000FC078 File Offset: 0x000FA278
	public void PONLCCBIDLJ(Color LBCGACKJCJB, Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float DIPMPDKHGNI, float JPGIGABPGII)
	{
		VPaintObject.AFAPAFOACIC afapafoacic = new VPaintObject.AFAPAFOACIC();
		afapafoacic.AEIAFIIMHEL = AEIAFIIMHEL;
		afapafoacic.DIPMPDKHGNI = DIPMPDKHGNI;
		afapafoacic.JPGIGABPGII = JPGIGABPGII;
		afapafoacic.LBCGACKJCJB = LBCGACKJCJB;
		this.ApplyPositionalModifier(JNFPCCIKFPP, new AIFFHHKJHJC(afapafoacic.ENEBIOPEPJA));
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x000FB533 File Offset: 0x000F9733
	public IEnumerator ApplyPositionalModifierAsync(Vector3 JNFPCCIKFPP, AIFFHHKJHJC KKEAIHBGPMO, float GDNOKEOLBPP)
	{
		Mesh meshInstance = this.GetMeshInstance();
		Vector3[] array = this.myVertices;
		Color[] colors = this.myColors;
		if (colors == null)
		{
			colors = meshInstance.colors;
		}
		int num = array.Length;
		Color[] array2 = new Color[num];
		for (int i = 0; i < num; i++)
		{
			float dkihdoelfeh = Vector3.Distance(base.transform.TransformPoint(array[i]), JNFPCCIKFPP);
			array2[i] = KKEAIHBGPMO(colors[i], dkihdoelfeh);
		}
		enumerator = DDIHABCDKFJ.AMODCAPHGAJ(this, colors, array2, GDNOKEOLBPP);
		while (enumerator.MoveNext())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x000FC0BC File Offset: 0x000FA2BC
	private MeshRenderer IOHHNDJIPNB()
	{
		if (!this.HCMPOCJOPKO)
		{
			this.HCMPOCJOPKO = base.GetComponent<MeshRenderer>();
		}
		return this.HCMPOCJOPKO;
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x000FC0DD File Offset: 0x000FA2DD
	public void ApplyColorsBuilder()
	{
		if (this.colorsBuilder == null)
		{
			return;
		}
		if (this.transparencyBuilder == null)
		{
			return;
		}
		this.GetMeshInstance().colors = this.colorsBuilder;
		this.myColors = this.colorsBuilder;
		this.colorsBuilder = null;
		this.transparencyBuilder = null;
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x000FC11C File Offset: 0x000FA31C
	public Bounds GetBounds()
	{
		if (this.editorCollider)
		{
			return this.editorCollider.bounds;
		}
		return base.GetComponent<Renderer>().bounds;
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x000FC144 File Offset: 0x000FA344
	public void LPNHJCGGBPH()
	{
		if (this._mesh && this._mesh != this.originalMesh)
		{
			UnityEngine.Object.DestroyImmediate(this._mesh);
		}
		VPaintObject.all.Remove(this);
		if (this.editorCollider)
		{
			UnityEngine.Object.DestroyImmediate(this.editorCollider.gameObject);
		}
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000FC1A5 File Offset: 0x000FA3A5
	public void Awake()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this._isDynamic)
		{
			this.ENNJBONEOKL();
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06002327 RID: 8999 RVA: 0x000FC1BD File Offset: 0x000FA3BD
	private MeshFilter GPGLPGADFAL
	{
		get
		{
			if (!this.NALNKNHHEEN)
			{
				this.NALNKNHHEEN = base.GetComponent<MeshFilter>();
			}
			return this.NALNKNHHEEN;
		}
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x000FB4A0 File Offset: 0x000F96A0
	public Color[] CNOMKLOAHGH()
	{
		return this.GetMeshInstance().colors;
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x000FC1DE File Offset: 0x000FA3DE
	public Color[] EHOPGKICJBK()
	{
		return this.OCPGANGKIAC().colors;
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000FC1EC File Offset: 0x000FA3EC
	public void IAHOLNKPEPJ(Color[] PAJKBJILHPE)
	{
		Mesh mesh = this.OCPGANGKIAC();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("Ready Crouch" + base.name + "");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = PAJKBJILHPE[i];
		}
		mesh.tangents = array;
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600232B RID: 9003 RVA: 0x000FC0BC File Offset: 0x000FA2BC
	private MeshRenderer JEKPCNHHNCI
	{
		get
		{
			if (!this.HCMPOCJOPKO)
			{
				this.HCMPOCJOPKO = base.GetComponent<MeshRenderer>();
			}
			return this.HCMPOCJOPKO;
		}
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x000FC25C File Offset: 0x000FA45C
	public void CBCPGHIMNDD()
	{
		if (this._mesh && this._mesh != this.originalMesh)
		{
			UnityEngine.Object.DestroyImmediate(this._mesh);
		}
		this._mesh = null;
		this._meshNonSerialized = null;
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (!component)
		{
			return;
		}
		component.sharedMesh = this.originalMesh;
		this.PBLBGKMJDBM();
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x000FC2C4 File Offset: 0x000FA4C4
	public void OnEnable()
	{
		if (!Application.isPlaying)
		{
			if (!this._mesh)
			{
				return;
			}
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(VPaintObject));
			for (int i = 0; i < array.Length; i++)
			{
				VPaintObject vpaintObject = array[i] as VPaintObject;
				if (!(vpaintObject == this) && vpaintObject._mesh == this._mesh)
				{
					this._mesh = null;
					this.ResetInstances();
					return;
				}
			}
		}
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x000FC337 File Offset: 0x000FA537
	public Vector3[] GOJLGPGFGEM()
	{
		return this.EKEOOAGNJME().vertices;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x000FC344 File Offset: 0x000FA544
	public void MKNHPNAAHBB(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("SwimDogPaddle" + base.name + "Idle Fly");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i] = PAJKBJILHPE[i];
		}
		meshInstance.tangents = array;
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x000FB319 File Offset: 0x000F9519
	public bool FFFGANMLMDA()
	{
		return this._isDynamic;
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x000FC3B1 File Offset: 0x000FA5B1
	public Color[] AEJMBGDBCNB()
	{
		return this.KHKBPKGEKAO().colors;
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x000FC3C0 File Offset: 0x000FA5C0
	public void ApplyColorSpherical(Color LBCGACKJCJB, Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float DIPMPDKHGNI, float JPGIGABPGII)
	{
		VPaintObject.AFAPAFOACIC afapafoacic = new VPaintObject.AFAPAFOACIC();
		afapafoacic.AEIAFIIMHEL = AEIAFIIMHEL;
		afapafoacic.DIPMPDKHGNI = DIPMPDKHGNI;
		afapafoacic.JPGIGABPGII = JPGIGABPGII;
		afapafoacic.LBCGACKJCJB = LBCGACKJCJB;
		this.ApplyPositionalModifier(JNFPCCIKFPP, new AIFFHHKJHJC(afapafoacic.FENNPINLKAP));
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000FC404 File Offset: 0x000FA604
	public void FEONPFANLAL(Color[] PAJKBJILHPE)
	{
		Mesh meshInstance = this.GetMeshInstance();
		if (PAJKBJILHPE.Length != this.myVertices.Length)
		{
			Debug.LogWarning("RollerBladeTurnLeft" + base.name + "offsets");
			return;
		}
		Vector4[] array = new Vector4[PAJKBJILHPE.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i] = PAJKBJILHPE[i];
		}
		meshInstance.tangents = array;
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x000FC1BD File Offset: 0x000FA3BD
	private MeshFilter DJJDAIONBBO()
	{
		if (!this.NALNKNHHEEN)
		{
			this.NALNKNHHEEN = base.GetComponent<MeshFilter>();
		}
		return this.NALNKNHHEEN;
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x000FC474 File Offset: 0x000FA674
	public void CALJHHHFLOL()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		if (base.GetComponent<Renderer>().sharedMaterial != this.IANBKGCPEKA)
		{
			this.originalMaterial = base.GetComponent<Renderer>().sharedMaterial;
			return;
		}
		if (this.originalMaterial)
		{
			base.GetComponent<Renderer>().sharedMaterial = this.originalMaterial;
		}
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x000FC4D8 File Offset: 0x000FA6D8
	private void ENNJBONEOKL()
	{
		this.editorCollider = new GameObject(base.name + " Collider")
		{
			hideFlags = HideFlags.HideInHierarchy
		}.AddComponent<MeshCollider>();
		this.editorCollider.sharedMesh = this.originalMesh;
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x000FC520 File Offset: 0x000FA720
	public void ResetMaterial()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		if (base.GetComponent<Renderer>().sharedMaterial != this.IANBKGCPEKA)
		{
			this.originalMaterial = base.GetComponent<Renderer>().sharedMaterial;
			return;
		}
		if (this.originalMaterial)
		{
			base.GetComponent<Renderer>().sharedMaterial = this.originalMaterial;
		}
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000FBBB4 File Offset: 0x000F9DB4
	public void HCMHMFHMPHN()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this._isDynamic)
		{
			this.MBMDDAPEMEF();
		}
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x000FC584 File Offset: 0x000FA784
	public void ApplyPositionalModifier(Vector3 JNFPCCIKFPP, AIFFHHKJHJC KKEAIHBGPMO)
	{
		Mesh meshInstance = this.GetMeshInstance();
		Vector3[] array = this.myVertices;
		Color[] colors = this.myColors;
		if (colors == null)
		{
			colors = meshInstance.colors;
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			float dkihdoelfeh = Vector3.Distance(base.transform.TransformPoint(array[i]), JNFPCCIKFPP);
			colors[i] = KKEAIHBGPMO(colors[i], dkihdoelfeh);
		}
		meshInstance.colors = colors;
		this.myColors = colors;
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x000FC608 File Offset: 0x000FA808
	public void OKFNCPMFIFA()
	{
		if (!base.GetComponent<Renderer>())
		{
			return;
		}
		if (base.GetComponent<Renderer>().sharedMaterial != this.IANBKGCPEKA)
		{
			this.originalMaterial = base.GetComponent<Renderer>().sharedMaterial;
			return;
		}
		if (this.originalMaterial)
		{
			base.GetComponent<Renderer>().sharedMaterial = this.originalMaterial;
		}
	}

	// Token: 0x04000404 RID: 1028
	public static List<VPaintObject> all = new List<VPaintObject>();

	// Token: 0x04000405 RID: 1029
	[HideInInspector]
	public Mesh _mesh;

	// Token: 0x04000406 RID: 1030
	[NonSerialized]
	public Mesh _meshNonSerialized;

	// Token: 0x04000407 RID: 1031
	[HideInInspector]
	public Material originalMaterial;

	// Token: 0x04000408 RID: 1032
	[HideInInspector]
	public Mesh originalMesh;

	// Token: 0x04000409 RID: 1033
	[NonSerialized]
	public Color[] colorsBuilder;

	// Token: 0x0400040A RID: 1034
	[NonSerialized]
	public float[] transparencyBuilder;

	// Token: 0x0400040B RID: 1035
	[NonSerialized]
	public int index;

	// Token: 0x0400040C RID: 1036
	[NonSerialized]
	public Color[] myColors;

	// Token: 0x0400040D RID: 1037
	[NonSerialized]
	public Vector3[] myVertices;

	// Token: 0x0400040E RID: 1038
	[HideInInspector]
	public MeshCollider editorCollider;

	// Token: 0x0400040F RID: 1039
	private MeshRenderer HCMPOCJOPKO;

	// Token: 0x04000410 RID: 1040
	private MeshFilter NALNKNHHEEN;

	// Token: 0x04000411 RID: 1041
	[SerializeField]
	private bool _isDynamic;

	// Token: 0x04000412 RID: 1042
	private Material IANBKGCPEKA;

	// Token: 0x020000A7 RID: 167
	[CompilerGenerated]
	private sealed class AFAPAFOACIC
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x000FE140 File Offset: 0x000FC340
		internal Color HPIBJGGKHDN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(609f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000FE188 File Offset: 0x000FC388
		internal Color OMGINIEJBKH(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1610f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000FE1D0 File Offset: 0x000FC3D0
		internal Color KLABACIKKMC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(143f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000FE218 File Offset: 0x000FC418
		internal Color JJAPNLKMICL(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(993f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000FE260 File Offset: 0x000FC460
		internal Color AIEKCEFKBMG(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(440f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000FE2A8 File Offset: 0x000FC4A8
		internal Color HAILIHBBAOE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(360f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000FE2F0 File Offset: 0x000FC4F0
		internal Color OKNDEEMMPHG(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1465f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000FE338 File Offset: 0x000FC538
		internal Color KDEBLPANNBE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1638f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000FE380 File Offset: 0x000FC580
		internal Color BPPNENMOIBI(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1370f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000FE3C8 File Offset: 0x000FC5C8
		internal Color KMCJFDDBBJE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1021f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000FE410 File Offset: 0x000FC610
		internal Color NEGECCEGAEC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(571f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000FE458 File Offset: 0x000FC658
		internal Color KHLHBODCNNG(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(706f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000FE4A0 File Offset: 0x000FC6A0
		internal Color IIPPIGOEFML(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1062f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000FE4E8 File Offset: 0x000FC6E8
		internal Color IEAJBFKKLIJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1864f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000FE530 File Offset: 0x000FC730
		internal Color BIPDGFIAKBO(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(372f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000FE578 File Offset: 0x000FC778
		internal Color PBCBPAKPMHK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(23f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000FE5C0 File Offset: 0x000FC7C0
		internal Color DHKPMLGOIJI(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(696f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000FE608 File Offset: 0x000FC808
		internal Color AJJLCEHNIKK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1453f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000FE650 File Offset: 0x000FC850
		internal Color IKHGMLGDOJE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(359f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x000FE698 File Offset: 0x000FC898
		internal Color GIIJCGNHCME(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1011f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000FE6E0 File Offset: 0x000FC8E0
		internal Color EEEIHPLKNPK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1833f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000FE728 File Offset: 0x000FC928
		internal Color NHEKEKIMHMA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(273f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x000FE770 File Offset: 0x000FC970
		internal Color FENNPINLKAP(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000FE7B8 File Offset: 0x000FC9B8
		internal Color FCHGANLFPIA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(214f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000FE800 File Offset: 0x000FCA00
		internal Color FFKAOLEDMFE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1893f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x000FE848 File Offset: 0x000FCA48
		internal Color AHEBEMFBKHH(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(753f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x000FE890 File Offset: 0x000FCA90
		internal Color MCLOBKJHGPB(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(654f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000FE8D8 File Offset: 0x000FCAD8
		internal Color CLNIHEPIFCE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(27f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000FE920 File Offset: 0x000FCB20
		internal Color BHCKLGLJKMG(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1329f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000FE968 File Offset: 0x000FCB68
		internal Color BEPCNONBANC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(72f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000FE9B0 File Offset: 0x000FCBB0
		internal Color MPJNCKMAFCC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(234f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000FE9F8 File Offset: 0x000FCBF8
		internal Color NNPNCBBNPLM(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(888f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000FEA40 File Offset: 0x000FCC40
		internal Color NIDFANFEIBD(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(225f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x000FEA88 File Offset: 0x000FCC88
		internal Color DHLGCDICLDJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1609f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x000FEAD0 File Offset: 0x000FCCD0
		internal Color BKKDKBOMFOA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(660f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x000FEB18 File Offset: 0x000FCD18
		internal Color ELJEGJBOLEH(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1237f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x000FEB60 File Offset: 0x000FCD60
		internal Color FIHJNPAJELK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(874f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x000FEBA8 File Offset: 0x000FCDA8
		internal Color CBLPMLHJCID(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(817f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x000FEBF0 File Offset: 0x000FCDF0
		internal Color HGGGFGLAPNF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1880f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000FEC38 File Offset: 0x000FCE38
		internal Color FGKDIIPBHKF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1404f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000FEC80 File Offset: 0x000FCE80
		internal Color HOFDFNGAJEM(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1529f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000FECC8 File Offset: 0x000FCEC8
		internal Color CFLLEKAOBFE(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1008f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000FED10 File Offset: 0x000FCF10
		internal Color HPOCNBAFKPC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(188f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000FED58 File Offset: 0x000FCF58
		internal Color ENEBIOPEPJA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1469f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000FEDA0 File Offset: 0x000FCFA0
		internal Color NCFBEANPPDM(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(202f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000FEDE8 File Offset: 0x000FCFE8
		internal Color DKKHDGHHLME(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(463f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000FEE30 File Offset: 0x000FD030
		internal Color CLMFLMGDMNO(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1878f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000FEE78 File Offset: 0x000FD078
		internal Color NBOLDJKGMFA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1267f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000FEEC0 File Offset: 0x000FD0C0
		internal Color BGEMKOPAIKB(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1168f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000FEF08 File Offset: 0x000FD108
		internal Color EIGEEEGBGCN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(709f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000FEF50 File Offset: 0x000FD150
		internal Color IEEKPCPOOEJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1292f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			return Color.Lerp(OAGAHEAMIAB, this.LBCGACKJCJB, t);
		}

		// Token: 0x0400041A RID: 1050
		public float AEIAFIIMHEL;

		// Token: 0x0400041B RID: 1051
		public float DIPMPDKHGNI;

		// Token: 0x0400041C RID: 1052
		public float JPGIGABPGII;

		// Token: 0x0400041D RID: 1053
		public Color LBCGACKJCJB;
	}

	// Token: 0x020000A8 RID: 168
	[CompilerGenerated]
	private sealed class ADGDMFPLCLP
	{
		// Token: 0x06002407 RID: 9223 RVA: 0x000FEF98 File Offset: 0x000FD198
		internal Color JEMMPHDNIBO(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1886f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x000FEFEC File Offset: 0x000FD1EC
		internal Color LFHGFGLCNMJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1379f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000FF040 File Offset: 0x000FD240
		internal Color MACLBDLNDBF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(965f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x000FF094 File Offset: 0x000FD294
		internal Color OBJKFABOMLK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(296f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x000FF0E8 File Offset: 0x000FD2E8
		internal Color HGEEBDIFGFJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(563f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000FF13C File Offset: 0x000FD33C
		internal Color GLECKBBLCDL(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1658f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000FF190 File Offset: 0x000FD390
		internal Color LGFAFEANEIK(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1644f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000FF1E4 File Offset: 0x000FD3E4
		internal Color KCJMPLHKKNC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(283f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x000FF238 File Offset: 0x000FD438
		internal Color NKCFLJPFGNN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1499f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x000FF28C File Offset: 0x000FD48C
		internal Color DENIIBJMDFB(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1382f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x000FF2E0 File Offset: 0x000FD4E0
		internal Color HDKAJFBPDBP(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1911f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000FF334 File Offset: 0x000FD534
		internal Color BFIMDDCALMI(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1692f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000FF388 File Offset: 0x000FD588
		internal Color LPEFADPHANF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1879f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x000FF3DC File Offset: 0x000FD5DC
		internal Color IGMBDJMPOBF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1407f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x000FF430 File Offset: 0x000FD630
		internal Color CMHNNCPMACN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1583f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x000FF484 File Offset: 0x000FD684
		internal Color FKDJGHKOBJP(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1114f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x000FF4D8 File Offset: 0x000FD6D8
		internal Color DKHGBAIHOIF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1955f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000FF52C File Offset: 0x000FD72C
		internal Color IPMIDJIBADN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(57f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000FF580 File Offset: 0x000FD780
		internal Color NIPJAJLOKHI(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1745f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000FF5D4 File Offset: 0x000FD7D4
		internal Color MGCKCALGBFH(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(589f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000FF628 File Offset: 0x000FD828
		internal Color OBPNIDIICBN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1417f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x000FF67C File Offset: 0x000FD87C
		internal Color CFBJFICBEBC(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1085f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x000FF6D0 File Offset: 0x000FD8D0
		internal Color MENJPAEKKKA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1465f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x000FF724 File Offset: 0x000FD924
		internal Color DJMHPKKMOPP(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1137f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000FF778 File Offset: 0x000FD978
		internal Color CDECABLJDPJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(724f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x000FF7CC File Offset: 0x000FD9CC
		internal Color HALFFLHKFNF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000FF820 File Offset: 0x000FDA20
		internal Color JHBNMGKICJJ(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(534f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000FF874 File Offset: 0x000FDA74
		internal Color NKKMICFAKIP(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1709f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000FF8C8 File Offset: 0x000FDAC8
		internal Color BEOACNKHGPN(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1085f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000FF91C File Offset: 0x000FDB1C
		internal Color GHFHHBMMKIA(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(111f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000FF970 File Offset: 0x000FDB70
		internal Color KEDEHLPBAEF(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1949f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000FF9C4 File Offset: 0x000FDBC4
		internal Color JDECLOHHJID(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(929f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000FFA18 File Offset: 0x000FDC18
		internal Color LGBIOKCPOML(Color OAGAHEAMIAB, float MBFGBDLOKFH)
		{
			if (this.AEIAFIIMHEL < MBFGBDLOKFH)
			{
				return OAGAHEAMIAB;
			}
			float t = Mathf.Pow(1764f - MBFGBDLOKFH / this.AEIAFIIMHEL, this.DIPMPDKHGNI) * this.JPGIGABPGII;
			OAGAHEAMIAB.a = Mathf.Lerp(OAGAHEAMIAB.a, this.CGFLAIMHHOO, t);
			return OAGAHEAMIAB;
		}

		// Token: 0x0400041E RID: 1054
		public float AEIAFIIMHEL;

		// Token: 0x0400041F RID: 1055
		public float DIPMPDKHGNI;

		// Token: 0x04000420 RID: 1056
		public float JPGIGABPGII;

		// Token: 0x04000421 RID: 1057
		public float CGFLAIMHHOO;
	}
}
