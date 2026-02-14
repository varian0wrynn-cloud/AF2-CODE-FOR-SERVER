using System;
using ProBuilder2.Common;
using UnityEngine;

namespace ProBuilder2.Examples
{
	// Token: 0x020004DD RID: 1245
	public class RuntimeEdit : MonoBehaviour
	{
		// Token: 0x06010DC7 RID: 69063 RVA: 0x0078CD14 File Offset: 0x0078AF14
		public void PIEDGJCBCBO()
		{
			if (!this.GCAKJMLKCNJ.CGBFJINDKFH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-10))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 766f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.LEDFEHFJIPB())
				{
					this.LCILPGNEHIB();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DC8 RID: 69064 RVA: 0x0078CDF4 File Offset: 0x0078AFF4
		public void DEFOEBHHLJI()
		{
			if (Input.GetMouseButtonUp(0) && !Input.GetKey((KeyCode)(-17)) && this.DOOAJHGIBGM(Input.mousePosition) && this.GCAKJMLKCNJ.IICMDKCGEFN())
			{
				if (!this.GCAKJMLKCNJ.MBKPGDFDNHP(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.EBHOEJBEEEH();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey(KeyCode.R))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 329f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1225f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-149));
				this.BIDIINOMCAF();
			}
		}

		// Token: 0x06010DC9 RID: 69065 RVA: 0x0078CF2C File Offset: 0x0078B12C
		private void GLLELJMBKJM()
		{
			this.OCBFAMCOLOA();
		}

		// Token: 0x06010DCA RID: 69066 RVA: 0x0078CF34 File Offset: 0x0078B134
		private void PJOENCIPFMN()
		{
			if (GUI.Button(new Rect(732f, (float)(Screen.height - -40), 1845f, 1160f), "_Tile8RT"))
			{
				this.GCAKJMLKCNJ.BKIAAPBGCDG();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.JBHHOIDAOFA();
			}
		}

		// Token: 0x06010DCB RID: 69067 RVA: 0x0078CF8C File Offset: 0x0078B18C
		public void HJDEGPKFBNI()
		{
			if (!this.GCAKJMLKCNJ.EODENACKFKK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)(-112))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1747f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.IICMDKCGEFN())
				{
					this.BIDIINOMCAF();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DCC RID: 69068 RVA: 0x0078D06B File Offset: 0x0078B26B
		private void PFONEFANOIJ()
		{
			this.IIHCKACAFGA();
		}

		// Token: 0x06010DCD RID: 69069 RVA: 0x0078D073 File Offset: 0x0078B273
		private void HNAEALCDLFJ()
		{
			this.LKDMHCPHNAN();
		}

		// Token: 0x06010DCE RID: 69070 RVA: 0x0078D07C File Offset: 0x0078B27C
		private void OKICICGNAFP()
		{
			if (GUI.Button(new Rect(430f, (float)(Screen.height - 53), 413f, 928f), "http://www.root-motion.com/finalikdox/html/page1.html"))
			{
				this.GCAKJMLKCNJ.MKPMHJPOCNG();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.JBHHOIDAOFA();
			}
		}

		// Token: 0x06010DCF RID: 69071 RVA: 0x0078D0D4 File Offset: 0x0078B2D4
		public void FJJDBAIJDIM()
		{
			if (!this.GCAKJMLKCNJ.EJLAFOLJOGH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)132)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 407f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.JEJMAJMCJPM())
				{
					this.EBHOEJBEEEH();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DD0 RID: 69072 RVA: 0x0078D1B4 File Offset: 0x0078B3B4
		public void PMKOAHMNBBG()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-196)) && this.OMIPMLGKPFO(Input.mousePosition) && this.GCAKJMLKCNJ.BJFLIAHLBDP())
			{
				if (!this.GCAKJMLKCNJ.MJDHBHHGMKC(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.HNPJHBKPFCO();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-199)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1278f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 437f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)157);
				this.HNPJHBKPFCO();
			}
		}

		// Token: 0x06010DD1 RID: 69073 RVA: 0x0078D2EC File Offset: 0x0078B4EC
		public bool FNMMEILEJOI(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[0] = msh.triangles[raycastHit.triangleIndex * 2];
			array[1] = msh.triangles[raycastHit.triangleIndex * 7 + 1];
			array[1] = msh.triangles[raycastHit.triangleIndex * 1 + 0];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DD2 RID: 69074 RVA: 0x0078D3AC File Offset: 0x0078B5AC
		public void LHFBEKCIKOI()
		{
			if (!this.GCAKJMLKCNJ.DBJBEFJDDKD())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-78))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1305f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.PDFKFCKEDEN())
				{
					this.DMADHFDJBOE();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DD3 RID: 69075 RVA: 0x0078D48C File Offset: 0x0078B68C
		public bool DOOAJHGIBGM(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return true;
			}
			Mesh msh = component.msh;
			int[] array = new int[0];
			array[0] = msh.triangles[raycastHit.triangleIndex * 2];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8 + 0];
			array[2] = msh.triangles[raycastHit.triangleIndex * 6 + 4];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DD4 RID: 69076 RVA: 0x0078D54C File Offset: 0x0078B74C
		private void JBHHOIDAOFA()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010DD5 RID: 69077 RVA: 0x0078D582 File Offset: 0x0078B782
		private void Awake()
		{
			this.PAJMDHLAKOJ();
		}

		// Token: 0x06010DD6 RID: 69078 RVA: 0x0078D58C File Offset: 0x0078B78C
		public void OKMAHGAAMHA()
		{
			if (Input.GetMouseButtonUp(0) && !Input.GetKey(KeyCode.RightCurlyBracket) && this.PGGBHJFGHKD(Input.mousePosition) && this.GCAKJMLKCNJ.DNIAGDMODBI())
			{
				if (!this.GCAKJMLKCNJ.NEBNNHMFKEP(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.BIDIINOMCAF();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-110)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1838f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 811f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)105);
				this.LJJFENEEEMF();
			}
		}

		// Token: 0x06010DD7 RID: 69079 RVA: 0x0078D6C4 File Offset: 0x0078B8C4
		private void LHHFHDNBKKC()
		{
			this.IKMOPNIDMPI();
		}

		// Token: 0x06010DD8 RID: 69080 RVA: 0x0078D073 File Offset: 0x0078B273
		private void FJBJDFDJAMI()
		{
			this.LKDMHCPHNAN();
		}

		// Token: 0x06010DD9 RID: 69081 RVA: 0x0078D6CC File Offset: 0x0078B8CC
		private void IALJIKNFEPB()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j++)
			{
				array[j] += vector.normalized * 611f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)192);
		}

		// Token: 0x06010DDA RID: 69082 RVA: 0x0078D7C8 File Offset: 0x0078B9C8
		public void OHAOGONDAHA()
		{
			if (!this.GCAKJMLKCNJ.JDONAFKEEHJ())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)139)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1787f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.BJFLIAHLBDP())
				{
					this.OGOHBKEKGIB();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DDB RID: 69083 RVA: 0x0078D8A8 File Offset: 0x0078BAA8
		public void IOGAKGCADBL()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-200)) && this.GLGAHPPFFCO(Input.mousePosition) && this.GCAKJMLKCNJ.OECJJLKPHPP())
			{
				if (!this.GCAKJMLKCNJ.BOAENGKCGND(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.LJJFENEEEMF();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-194)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1510f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1551f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)189);
				this.MNAPNOAMIHI();
			}
		}

		// Token: 0x06010DDC RID: 69084 RVA: 0x0078D9E0 File Offset: 0x0078BBE0
		public void PMIFCKJAFEB()
		{
			if (!this.GCAKJMLKCNJ.COJKJGNLAAK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-47))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1782f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.BJFLIAHLBDP())
				{
					this.MIICGLHDKCL();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DDD RID: 69085 RVA: 0x0078DAC0 File Offset: 0x0078BCC0
		public void KCMJALIDEHB()
		{
			if (!this.GCAKJMLKCNJ.OBIOJHLDFMG())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.Pause)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1752f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.DNIAGDMODBI())
				{
					this.PGJNDPKJOFO();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DDE RID: 69086 RVA: 0x0078DBA0 File Offset: 0x0078BDA0
		public bool MHPAKGMJPJD(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[1] = msh.triangles[raycastHit.triangleIndex * 3];
			array[0] = msh.triangles[raycastHit.triangleIndex * 0 + 1];
			array[2] = msh.triangles[raycastHit.triangleIndex * 5 + 3];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DDF RID: 69087 RVA: 0x0078DC60 File Offset: 0x0078BE60
		private void IBJOELCDALL()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010DE0 RID: 69088 RVA: 0x0078DC98 File Offset: 0x0078BE98
		private void MJDKGMEPMHK()
		{
			if (GUI.Button(new Rect(1495f, (float)(Screen.height - 26), 1855f, 1850f), "_MainTex"))
			{
				this.GCAKJMLKCNJ.JNINPMFFLEB();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.LKDMHCPHNAN();
			}
		}

		// Token: 0x06010DE1 RID: 69089 RVA: 0x0078DCEF File Offset: 0x0078BEEF
		private void AOLBGAGHJDO()
		{
			this.HDBGMGCINOH();
		}

		// Token: 0x06010DE2 RID: 69090 RVA: 0x0078DCF8 File Offset: 0x0078BEF8
		public void ECPECFPNLKP()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)75) && this.IAMEJELPJBF(Input.mousePosition) && this.GCAKJMLKCNJ.CHFHJDFDIGB())
			{
				if (!this.GCAKJMLKCNJ.BJFOHGGCKNP(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.PGNHCBEBADO();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey(KeyCode.DoubleQuote))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1597f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 7f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-57));
				this.LCILPGNEHIB();
			}
		}

		// Token: 0x06010DE3 RID: 69091 RVA: 0x0078DE30 File Offset: 0x0078C030
		public void OPDKOENCBDK()
		{
			if (!this.GCAKJMLKCNJ.CGBFJINDKFH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)15)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1224f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.DNIAGDMODBI())
				{
					this.MIICGLHDKCL();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DE4 RID: 69092 RVA: 0x0078DF10 File Offset: 0x0078C110
		public void EANILKHGBKE()
		{
			if (!this.GCAKJMLKCNJ.OBIOJHLDFMG())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)7)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1416f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.BJFLIAHLBDP())
				{
					this.MNAPNOAMIHI();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DE5 RID: 69093 RVA: 0x0078DFF0 File Offset: 0x0078C1F0
		private void AJLEAKOMHJG()
		{
			if (GUI.Button(new Rect(286f, (float)(Screen.height - -99), 1396f, 965f), "rait_2"))
			{
				this.GCAKJMLKCNJ.JNINPMFFLEB();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.HJAFOPMLDCF();
			}
		}

		// Token: 0x06010DE6 RID: 69094 RVA: 0x0078E048 File Offset: 0x0078C248
		public void Update()
		{
			if (Input.GetMouseButtonUp(0) && !Input.GetKey(KeyCode.LeftAlt) && this.FaceCheck(Input.mousePosition) && this.GCAKJMLKCNJ.CHFHJDFDIGB())
			{
				if (!this.GCAKJMLKCNJ.JDBINLKEJMF(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.NKBHIAJONOM();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey(KeyCode.LeftShift))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * -0.5f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 0.5f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh(RefreshMask.All);
				this.NKBHIAJONOM();
			}
		}

		// Token: 0x06010DE7 RID: 69095 RVA: 0x0078E180 File Offset: 0x0078C380
		private void NBGFJFIMHAC()
		{
			if (GUI.Button(new Rect(303f, (float)(Screen.height - -4), 1945f, 1544f), "23"))
			{
				this.GCAKJMLKCNJ.CNAPFIEDNPN();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.EDNBFOMIKNB();
			}
		}

		// Token: 0x06010DE8 RID: 69096 RVA: 0x0078E1D8 File Offset: 0x0078C3D8
		public void JMNNAPNJDNK()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)142) && this.FaceCheck(Input.mousePosition) && this.GCAKJMLKCNJ.HKIAOHBMKJM())
			{
				if (!this.GCAKJMLKCNJ.FFGIMBGINCG(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.MHEEJPELMAB();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)174))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1015f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1081f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh(RefreshMask.Normals | RefreshMask.Collisions);
				this.LCILPGNEHIB();
			}
		}

		// Token: 0x06010DE9 RID: 69097 RVA: 0x0078E310 File Offset: 0x0078C510
		public void JFKCLOJNBJJ()
		{
			if (!this.GCAKJMLKCNJ.EDPGAIOLDKI())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-33))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1666f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.JKHHAGIEOFO())
				{
					this.BIDIINOMCAF();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DEA RID: 69098 RVA: 0x0078E3EF File Offset: 0x0078C5EF
		private void OJDLGCFKCEJ()
		{
			this.KNPKMIAEBBB();
		}

		// Token: 0x06010DEB RID: 69099 RVA: 0x0078E3F8 File Offset: 0x0078C5F8
		public void IGEICBNMPAD()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-176)) && this.FIODGGBABIJ(Input.mousePosition) && this.GCAKJMLKCNJ.MAMKLPIEAHL())
			{
				if (!this.GCAKJMLKCNJ.LCBEDPPBPAH(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.LJJFENEEEMF();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-16)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 610f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1269f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)80);
				this.MHEEJPELMAB();
			}
		}

		// Token: 0x06010DEC RID: 69100 RVA: 0x0078E530 File Offset: 0x0078C730
		public void JOHDLNOKCOK()
		{
			if (Input.GetMouseButtonUp(0) && !Input.GetKey((KeyCode)(-157)) && this.GLHCGDNJDIL(Input.mousePosition) && this.GCAKJMLKCNJ.IBIAEBKPJBN())
			{
				if (!this.GCAKJMLKCNJ.CKDJMHIHLBA(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.OGOHBKEKGIB();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-75)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1652f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 441f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)144);
				this.BIDIINOMCAF();
			}
		}

		// Token: 0x06010DED RID: 69101 RVA: 0x0078E668 File Offset: 0x0078C868
		private void DJDAAIMDLKE()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 551f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)191);
		}

		// Token: 0x06010DEE RID: 69102 RVA: 0x0078E764 File Offset: 0x0078C964
		private void OGOHBKEKGIB()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 1650f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[0] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)(-54));
		}

		// Token: 0x06010DEF RID: 69103 RVA: 0x0078E860 File Offset: 0x0078CA60
		public bool GMDOHGHCHMG(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return true;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[1] = msh.triangles[raycastHit.triangleIndex * 5];
			array[0] = msh.triangles[raycastHit.triangleIndex * 3 + 1];
			array[4] = msh.triangles[raycastHit.triangleIndex * 4 + 3];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DF0 RID: 69104 RVA: 0x0078D06B File Offset: 0x0078B26B
		private void DHIJGNHBMFJ()
		{
			this.IIHCKACAFGA();
		}

		// Token: 0x06010DF1 RID: 69105 RVA: 0x0078E920 File Offset: 0x0078CB20
		private void HDBGMGCINOH()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010DF2 RID: 69106 RVA: 0x0078E958 File Offset: 0x0078CB58
		public void LateUpdate()
		{
			if (!this.GCAKJMLKCNJ.EDPGAIOLDKI())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftAlt)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 0f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.CHFHJDFDIGB())
				{
					this.NKBHIAJONOM();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DF3 RID: 69107 RVA: 0x0078EA38 File Offset: 0x0078CC38
		private void PAJMDHLAKOJ()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010DF4 RID: 69108 RVA: 0x0078EA70 File Offset: 0x0078CC70
		public void IPDFGIOPHAD()
		{
			if (!this.GCAKJMLKCNJ.PBBNBNEJJDG())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)16)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1763f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.OECJJLKPHPP())
				{
					this.PGNHCBEBADO();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DF5 RID: 69109 RVA: 0x0078EB4F File Offset: 0x0078CD4F
		private void PFKOLCOAPCN()
		{
			this.ENFDDGKHAON();
		}

		// Token: 0x06010DF6 RID: 69110 RVA: 0x0078EB58 File Offset: 0x0078CD58
		private void GKFOFOCGPCC()
		{
			if (GUI.Button(new Rect(559f, (float)(Screen.height - 64), 651f, 1069f), "wplabel"))
			{
				this.GCAKJMLKCNJ.CNAPFIEDNPN();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.IBJOELCDALL();
			}
		}

		// Token: 0x06010DF7 RID: 69111 RVA: 0x0078EBB0 File Offset: 0x0078CDB0
		private void HBPAAFPALJM()
		{
			if (GUI.Button(new Rect(1530f, (float)(Screen.height - -123), 1435f, 847f), "loc"))
			{
				this.GCAKJMLKCNJ.FILBKHHNLNA();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.IIHCKACAFGA();
			}
		}

		// Token: 0x06010DF8 RID: 69112 RVA: 0x0078EC08 File Offset: 0x0078CE08
		private void LPNFGGAKGID()
		{
			if (GUI.Button(new Rect(1251f, (float)(Screen.height - -116), 621f, 1548f), "{0:F2}, {1:F2}, {2:F2}, {3:F2}"))
			{
				this.GCAKJMLKCNJ.JGGKDLLBAKD();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.OCBFAMCOLOA();
			}
		}

		// Token: 0x06010DF9 RID: 69113 RVA: 0x0078EC60 File Offset: 0x0078CE60
		public void LBBGAADLMOM()
		{
			if (!this.GCAKJMLKCNJ.OBKIINLEMEK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)198)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 273f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.LEDFEHFJIPB())
				{
					this.PGNHCBEBADO();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010DFA RID: 69114 RVA: 0x0078ED40 File Offset: 0x0078CF40
		public void CFMIMGKFLBJ()
		{
			if (!this.GCAKJMLKCNJ.BIPLHBIPDLK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)(-2))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 542f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.NIKMGNDDGFE())
				{
					this.DMADHFDJBOE();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010DFB RID: 69115 RVA: 0x0078EE20 File Offset: 0x0078D020
		private void GMIBFBMABFK()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 1199f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[0] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh(RefreshMask.UV | RefreshMask.Colors | RefreshMask.Tangents);
		}

		// Token: 0x06010DFC RID: 69116 RVA: 0x0078EF1C File Offset: 0x0078D11C
		private void MIICGLHDKCL()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 605f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[0] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh(RefreshMask.Normals | RefreshMask.Collisions);
		}

		// Token: 0x06010DFD RID: 69117 RVA: 0x0078F018 File Offset: 0x0078D218
		public bool ECJCENBLGGA(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[]
			{
				msh.triangles[raycastHit.triangleIndex * 7]
			};
			array[0] = msh.triangles[raycastHit.triangleIndex * 3 + 1];
			array[3] = msh.triangles[raycastHit.triangleIndex * 8 + 3];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DFE RID: 69118 RVA: 0x0078F0D8 File Offset: 0x0078D2D8
		public bool FaceCheck(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] tri = new int[]
			{
				msh.triangles[raycastHit.triangleIndex * 3],
				msh.triangles[raycastHit.triangleIndex * 3 + 1],
				msh.triangles[raycastHit.triangleIndex * 3 + 2]
			};
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010DFF RID: 69119 RVA: 0x0078F195 File Offset: 0x0078D395
		private void EEININLNBKJ()
		{
			this.BKPJGMPBJFF();
		}

		// Token: 0x06010E00 RID: 69120 RVA: 0x0078F1A0 File Offset: 0x0078D3A0
		private void EMAFBLJDFDF()
		{
			if (GUI.Button(new Rect(115f, (float)(Screen.height - 118), 792f, 1208f), "remWpn="))
			{
				this.GCAKJMLKCNJ.FILBKHHNLNA();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.HDBGMGCINOH();
			}
		}

		// Token: 0x06010E01 RID: 69121 RVA: 0x0078F1F8 File Offset: 0x0078D3F8
		private void BONHOFPGCKL()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E02 RID: 69122 RVA: 0x0078F230 File Offset: 0x0078D430
		private void NKBHIAJONOM()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j++)
			{
				array[j] += vector.normalized * 0.01f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(array, new pb_Face[]
			{
				new pb_Face(array2)
			});
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh(RefreshMask.All);
		}

		// Token: 0x06010E03 RID: 69123 RVA: 0x0078F32C File Offset: 0x0078D52C
		public void BOEFHGKGJMN()
		{
			if (!this.GCAKJMLKCNJ.BIPLHBIPDLK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)187)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1733f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.IICMDKCGEFN())
				{
					this.PGJNDPKJOFO();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E04 RID: 69124 RVA: 0x0078F40B File Offset: 0x0078D60B
		private void GGPMDJNJGPH()
		{
			this.BONHOFPGCKL();
		}

		// Token: 0x06010E05 RID: 69125 RVA: 0x0078F414 File Offset: 0x0078D614
		public void IEEPECJPCFD()
		{
			if (!this.GCAKJMLKCNJ.DBJBEFJDDKD())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-194))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1658f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.IICMDKCGEFN())
				{
					this.OGOHBKEKGIB();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E06 RID: 69126 RVA: 0x0078F4F4 File Offset: 0x0078D6F4
		private void NOOCCBPAIIJ()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E07 RID: 69127 RVA: 0x0078F52C File Offset: 0x0078D72C
		public void EFFFHHCHPIN()
		{
			if (!this.GCAKJMLKCNJ.EJKGEKBOCGH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)(-123))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 603f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.IBIAEBKPJBN())
				{
					this.LCILPGNEHIB();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E08 RID: 69128 RVA: 0x0078F60C File Offset: 0x0078D80C
		public bool PGGBHJFGHKD(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[7];
			array[1] = msh.triangles[raycastHit.triangleIndex * 8];
			array[1] = msh.triangles[raycastHit.triangleIndex * 8 + 0];
			array[1] = msh.triangles[raycastHit.triangleIndex * 7 + 2];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E09 RID: 69129 RVA: 0x0078F6CC File Offset: 0x0078D8CC
		private void LKDMHCPHNAN()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E0A RID: 69130 RVA: 0x0078F704 File Offset: 0x0078D904
		public bool GLGAHPPFFCO(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return true;
			}
			Mesh msh = component.msh;
			int[] array = new int[6];
			array[1] = msh.triangles[raycastHit.triangleIndex * 1];
			array[0] = msh.triangles[raycastHit.triangleIndex * 1 + 0];
			array[5] = msh.triangles[raycastHit.triangleIndex * 0 + 3];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E0B RID: 69131 RVA: 0x0078F195 File Offset: 0x0078D395
		private void GKJNOMMAAPO()
		{
			this.BKPJGMPBJFF();
		}

		// Token: 0x06010E0C RID: 69132 RVA: 0x0078F7C4 File Offset: 0x0078D9C4
		private void BIDIINOMCAF()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j++)
			{
				array[j] += vector.normalized * 1327f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)170);
		}

		// Token: 0x06010E0D RID: 69133 RVA: 0x0078F8C0 File Offset: 0x0078DAC0
		public void KMOHGOOEJOI()
		{
			if (!this.GCAKJMLKCNJ.EJLAFOLJOGH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey(KeyCode.LeftBracket)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1084f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.OECJJLKPHPP())
				{
					this.PGNHCBEBADO();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E0E RID: 69134 RVA: 0x0078F9A0 File Offset: 0x0078DBA0
		public bool NFOGCDLOPHK(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[8];
			array[1] = msh.triangles[raycastHit.triangleIndex * 5];
			array[0] = msh.triangles[raycastHit.triangleIndex * 0 + 0];
			array[0] = msh.triangles[raycastHit.triangleIndex * 3 + 6];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E0F RID: 69135 RVA: 0x0078FA5D File Offset: 0x0078DC5D
		private void LBABMJJNIHA()
		{
			this.EDNBFOMIKNB();
		}

		// Token: 0x06010E10 RID: 69136 RVA: 0x0078FA68 File Offset: 0x0078DC68
		private void LJJFENEEEMF()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j++)
			{
				array[j] += vector.normalized * 7f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)113);
		}

		// Token: 0x06010E11 RID: 69137 RVA: 0x0078FB64 File Offset: 0x0078DD64
		public bool AKOOJJMKOOF(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[4];
			array[1] = msh.triangles[raycastHit.triangleIndex * 3];
			array[1] = msh.triangles[raycastHit.triangleIndex * 7 + 1];
			array[3] = msh.triangles[raycastHit.triangleIndex * 7 + 5];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E12 RID: 69138 RVA: 0x0078FC24 File Offset: 0x0078DE24
		public bool IAMEJELPJBF(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8];
			array[1] = msh.triangles[raycastHit.triangleIndex * 8 + 1];
			array[0] = msh.triangles[raycastHit.triangleIndex * 5 + 7];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E13 RID: 69139 RVA: 0x0078FCE4 File Offset: 0x0078DEE4
		public bool FBENGHIAEOG(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[0];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8];
			array[1] = msh.triangles[raycastHit.triangleIndex * 5 + 1];
			array[3] = msh.triangles[raycastHit.triangleIndex * 4 + 2];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E14 RID: 69140 RVA: 0x0078FDA4 File Offset: 0x0078DFA4
		public bool CLDHLCCHDNA(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return true;
			}
			Mesh msh = component.msh;
			int[] array = new int[1];
			array[0] = msh.triangles[raycastHit.triangleIndex * 4];
			array[1] = msh.triangles[raycastHit.triangleIndex * 0 + 0];
			array[1] = msh.triangles[raycastHit.triangleIndex * 0 + 8];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E15 RID: 69141 RVA: 0x0078FE64 File Offset: 0x0078E064
		public void HMEAENGBFKC()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey(KeyCode.DoubleQuote) && this.GLHCGDNJDIL(Input.mousePosition) && this.GCAKJMLKCNJ.IICMDKCGEFN())
			{
				if (!this.GCAKJMLKCNJ.LNGNHLLMFHN(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.DMADHFDJBOE();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)66))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 135f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1624f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-159));
				this.LJJFENEEEMF();
			}
		}

		// Token: 0x06010E16 RID: 69142 RVA: 0x0078FF9C File Offset: 0x0078E19C
		public bool OAHPLNHAEMN(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[7];
			array[1] = msh.triangles[raycastHit.triangleIndex * 7];
			array[0] = msh.triangles[raycastHit.triangleIndex * 1 + 1];
			array[3] = msh.triangles[raycastHit.triangleIndex * 0 + 8];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E17 RID: 69143 RVA: 0x0079005C File Offset: 0x0078E25C
		public void JGAEKEDEGDI()
		{
			if (!this.GCAKJMLKCNJ.KJCAIIFNOOL())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)165)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 379f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.OEENDMJIPJG())
				{
					this.LJJFENEEEMF();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E18 RID: 69144 RVA: 0x0079013C File Offset: 0x0078E33C
		public bool FBKCDNGPNOO(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[5];
			array[0] = msh.triangles[raycastHit.triangleIndex * 2];
			array[0] = msh.triangles[raycastHit.triangleIndex * 5 + 0];
			array[6] = msh.triangles[raycastHit.triangleIndex * 6 + 7];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E19 RID: 69145 RVA: 0x0078D06B File Offset: 0x0078B26B
		private void FCMABFFDJLC()
		{
			this.IIHCKACAFGA();
		}

		// Token: 0x06010E1A RID: 69146 RVA: 0x007901FC File Offset: 0x0078E3FC
		private void ECLMFCKLJNM()
		{
			if (GUI.Button(new Rect(1277f, (float)(Screen.height - -78), 867f, 396f), "vSyncCount"))
			{
				this.GCAKJMLKCNJ.DLDPMEJFOLH();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E1B RID: 69147 RVA: 0x00790254 File Offset: 0x0078E454
		public void HNMODJBBKBI()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-55)) && this.NFOGCDLOPHK(Input.mousePosition) && this.GCAKJMLKCNJ.IBIAEBKPJBN())
			{
				if (!this.GCAKJMLKCNJ.IKONKPHGOAB(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.HNPJHBKPFCO();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey(KeyCode.Question))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 548f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 85f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-141));
				this.GMIBFBMABFK();
			}
		}

		// Token: 0x06010E1C RID: 69148 RVA: 0x0079038C File Offset: 0x0078E58C
		private void KIEFPGLDOCD()
		{
			if (GUI.Button(new Rect(959f, (float)(Screen.height - 37), 757f, 883f), "fishpoplcatch"))
			{
				this.GCAKJMLKCNJ.JGGKDLLBAKD();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E1D RID: 69149 RVA: 0x007903E4 File Offset: 0x0078E5E4
		public void EFDGMFCGKKA()
		{
			if (!this.GCAKJMLKCNJ.EDPGAIOLDKI())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-72))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 137f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.LEDFEHFJIPB())
				{
					this.NKBHIAJONOM();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E1E RID: 69150 RVA: 0x007904C4 File Offset: 0x0078E6C4
		private void GLJJBDNLANI()
		{
			if (GUI.Button(new Rect(512f, (float)(Screen.height - -37), 624f, 1774f), "textAsset is NULL! Path: Weapons"))
			{
				this.GCAKJMLKCNJ.LCDNJEFLAPE();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E1F RID: 69151 RVA: 0x0079051C File Offset: 0x0078E71C
		private void HNPJHBKPFCO()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j++)
			{
				array[j] += vector.normalized * 64f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(array, new pb_Face[]
			{
				new pb_Face(array2)
			});
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)(-177));
		}

		// Token: 0x06010E20 RID: 69152 RVA: 0x00790618 File Offset: 0x0078E818
		public void BIGPMMGBPJC()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-120)) && this.CLDHLCCHDNA(Input.mousePosition) && this.GCAKJMLKCNJ.BJFLIAHLBDP())
			{
				if (!this.GCAKJMLKCNJ.PIMIMLGPKKD(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.OGOHBKEKGIB();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-101)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1735f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 298f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)112);
				this.PGNHCBEBADO();
			}
		}

		// Token: 0x06010E21 RID: 69153 RVA: 0x00790750 File Offset: 0x0078E950
		public void LKOLHNPIBLM()
		{
			if (!this.GCAKJMLKCNJ.PMBLPCALPLJ())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-199))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1869f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.GGHCAMNAIDE())
				{
					this.PGJNDPKJOFO();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E22 RID: 69154 RVA: 0x00790830 File Offset: 0x0078EA30
		private void LCILPGNEHIB()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 1588f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh(RefreshMask.UV | RefreshMask.Tangents | RefreshMask.Collisions);
		}

		// Token: 0x06010E23 RID: 69155 RVA: 0x0079092A File Offset: 0x0078EB2A
		private void CNKLGMCHEBM()
		{
			this.NOOCCBPAIIJ();
		}

		// Token: 0x06010E24 RID: 69156 RVA: 0x00790934 File Offset: 0x0078EB34
		public bool GLHCGDNJDIL(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[1] = msh.triangles[raycastHit.triangleIndex * 2];
			array[0] = msh.triangles[raycastHit.triangleIndex * 6 + 0];
			array[3] = msh.triangles[raycastHit.triangleIndex * 6 + 0];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E25 RID: 69157 RVA: 0x007909F4 File Offset: 0x0078EBF4
		public void HDPICLGBICL()
		{
			if (!this.GCAKJMLKCNJ.BIPLHBIPDLK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-97))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 873f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.OEENDMJIPJG())
				{
					this.OGOHBKEKGIB();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E26 RID: 69158 RVA: 0x00790AD4 File Offset: 0x0078ECD4
		public void ECHBBKNCLDD()
		{
			if (!this.GCAKJMLKCNJ.CGBFJINDKFH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)170)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 793f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.BJFLIAHLBDP())
				{
					this.LCILPGNEHIB();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E27 RID: 69159 RVA: 0x00790BB4 File Offset: 0x0078EDB4
		public bool IPIJJBLNPLP(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[3];
			array[0] = msh.triangles[raycastHit.triangleIndex * 3];
			array[1] = msh.triangles[raycastHit.triangleIndex * 0 + 1];
			array[7] = msh.triangles[raycastHit.triangleIndex * 8 + 8];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E28 RID: 69160 RVA: 0x00790C74 File Offset: 0x0078EE74
		private void DMADHFDJBOE()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 786f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)197);
		}

		// Token: 0x06010E29 RID: 69161 RVA: 0x00790D70 File Offset: 0x0078EF70
		private void JBGGMKEKOAN()
		{
			if (GUI.Button(new Rect(675f, (float)(Screen.height - 24), 641f, 406f), "CrouchStrafeRight"))
			{
				this.GCAKJMLKCNJ.JKMFJFGGDKM();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x0078FA5D File Offset: 0x0078DC5D
		private void LBKPJAJJLBH()
		{
			this.EDNBFOMIKNB();
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x00790DC8 File Offset: 0x0078EFC8
		private void BKPJGMPBJFF()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x00790E00 File Offset: 0x0078F000
		private void OCBFAMCOLOA()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E2D RID: 69165 RVA: 0x0078EB4F File Offset: 0x0078CD4F
		private void JLBFJMJALOA()
		{
			this.ENFDDGKHAON();
		}

		// Token: 0x06010E2E RID: 69166 RVA: 0x0078FA5D File Offset: 0x0078DC5D
		private void CFNLKNOKAGC()
		{
			this.EDNBFOMIKNB();
		}

		// Token: 0x06010E2F RID: 69167 RVA: 0x00790E38 File Offset: 0x0078F038
		public bool JABEFFLNJNF(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[8];
			array[0] = msh.triangles[raycastHit.triangleIndex * 7];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8 + 1];
			array[2] = msh.triangles[raycastHit.triangleIndex * 5 + 4];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E30 RID: 69168 RVA: 0x00790EF8 File Offset: 0x0078F0F8
		private void PGJNDPKJOFO()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 1719f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)46);
		}

		// Token: 0x06010E31 RID: 69169 RVA: 0x00790FF4 File Offset: 0x0078F1F4
		private void MNAPNOAMIHI()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 0; j < array.Length; j++)
			{
				array[j] += vector.normalized * 648f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)185);
		}

		// Token: 0x06010E32 RID: 69170 RVA: 0x007910F0 File Offset: 0x0078F2F0
		public bool OMIPMLGKPFO(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return true;
			}
			Mesh msh = component.msh;
			int[] array = new int[6];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8];
			array[0] = msh.triangles[raycastHit.triangleIndex * 0 + 0];
			array[3] = msh.triangles[raycastHit.triangleIndex * 4 + 3];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E33 RID: 69171 RVA: 0x007911B0 File Offset: 0x0078F3B0
		public void BNKJNBIDPME()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)154) && this.MHPAKGMJPJD(Input.mousePosition) && this.GCAKJMLKCNJ.INBJOJBHHJN())
			{
				if (!this.GCAKJMLKCNJ.JLAIADLPLFO(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.PGNHCBEBADO();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey(KeyCode.G))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 678f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1854f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-141));
				this.LJJFENEEEMF();
			}
		}

		// Token: 0x06010E34 RID: 69172 RVA: 0x007912E8 File Offset: 0x0078F4E8
		public void IKEBNJAMNDB()
		{
			if (!this.GCAKJMLKCNJ.COJKJGNLAAK())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)67)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 548f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.LEDFEHFJIPB())
				{
					this.DJDAAIMDLKE();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E35 RID: 69173 RVA: 0x007913C8 File Offset: 0x0078F5C8
		private void PGNHCBEBADO()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j++)
			{
				array[j] += vector.normalized * 101f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)(-9));
		}

		// Token: 0x06010E36 RID: 69174 RVA: 0x007914C4 File Offset: 0x0078F6C4
		private void EBHOEJBEEEH()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j++)
			{
				array[j] += vector.normalized * 521f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[0];
			array3[0] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)(-154));
		}

		// Token: 0x06010E37 RID: 69175 RVA: 0x007915C0 File Offset: 0x0078F7C0
		private void KNPKMIAEBBB()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x007915F8 File Offset: 0x0078F7F8
		public void CKCBGFMFNFK()
		{
			if (!this.GCAKJMLKCNJ.GFMOILEDJFM())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(0) && Input.GetKey((KeyCode)(-77))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = true;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1785f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.BJFLIAHLBDP())
				{
					this.IALJIKNFEPB();
				}
			}
			if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(1))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E39 RID: 69177 RVA: 0x007916D8 File Offset: 0x0078F8D8
		private void EDNBFOMIKNB()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = false;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E3A RID: 69178 RVA: 0x00791710 File Offset: 0x0078F910
		public bool FIODGGBABIJ(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[7];
			array[0] = msh.triangles[raycastHit.triangleIndex * 8];
			array[1] = msh.triangles[raycastHit.triangleIndex * 3 + 1];
			array[4] = msh.triangles[raycastHit.triangleIndex * 2 + 0];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E3C RID: 69180 RVA: 0x007917EC File Offset: 0x0078F9EC
		private void ENFDDGKHAON()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E3D RID: 69181 RVA: 0x00791824 File Offset: 0x0078FA24
		private void IIHCKACAFGA()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E3E RID: 69182 RVA: 0x0079185C File Offset: 0x0078FA5C
		public void BDALGHGNCPE()
		{
			if (!this.GCAKJMLKCNJ.JDONAFKEEHJ())
			{
				return;
			}
			if (Input.GetMouseButtonDown(0) || (Input.GetMouseButtonDown(1) && Input.GetKey((KeyCode)(-173))))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 1438f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.NIKMGNDDGFE())
				{
					this.DMADHFDJBOE();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = true;
			}
		}

		// Token: 0x06010E3F RID: 69183 RVA: 0x0079193C File Offset: 0x0078FB3C
		private void OnGUI()
		{
			if (GUI.Button(new Rect(5f, (float)(Screen.height - 25), 80f, 20f), "Reset"))
			{
				this.GCAKJMLKCNJ.MHJKBMIOGCD();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.PAJMDHLAKOJ();
			}
		}

		// Token: 0x06010E40 RID: 69184 RVA: 0x00791994 File Offset: 0x0078FB94
		private void EOCENEIDJKI()
		{
			if (GUI.Button(new Rect(968f, (float)(Screen.height - -55), 1027f, 736f), "wpn_sost"))
			{
				this.GCAKJMLKCNJ.MHJKBMIOGCD();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.KNPKMIAEBBB();
			}
		}

		// Token: 0x06010E41 RID: 69185 RVA: 0x007919EC File Offset: 0x0078FBEC
		private void MHEEJPELMAB()
		{
			Vector3[] array = this.GCAKJMLKCNJ.MPDJOADEOKK.VerticesInWorldSpace(this.GCAKJMLKCNJ.LEBPNFGNEBI.indices);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i] = i;
			}
			Vector3 vector = pb_Math.Normal(array);
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j] += vector.normalized * 1400f;
			}
			if (this.LAFGDIBJMKL)
			{
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
			}
			Vector3[] v = array;
			pb_Face[] array3 = new pb_Face[1];
			array3[1] = new pb_Face(array2);
			this.LAFGDIBJMKL = pb_Object.CreateInstanceWithVerticesFaces(v, array3);
			this.LAFGDIBJMKL.SetFaceMaterial(this.LAFGDIBJMKL.faces, this.previewMaterial);
			this.LAFGDIBJMKL.ToMesh();
			this.LAFGDIBJMKL.Refresh((RefreshMask)151);
		}

		// Token: 0x06010E42 RID: 69186 RVA: 0x00791AE8 File Offset: 0x0078FCE8
		public bool MIPBGOOOKIA(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return true;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[0];
			array[1] = msh.triangles[raycastHit.triangleIndex * 2];
			array[0] = msh.triangles[raycastHit.triangleIndex * 3 + 1];
			array[6] = msh.triangles[raycastHit.triangleIndex * 6 + 4];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E43 RID: 69187 RVA: 0x00791BA8 File Offset: 0x0078FDA8
		public void JEPDBHDFDCJ()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-8)) && this.GLHCGDNJDIL(Input.mousePosition) && this.GCAKJMLKCNJ.DNIAGDMODBI())
			{
				if (!this.GCAKJMLKCNJ.MJDHBHHGMKC(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.OGOHBKEKGIB();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)(-132)))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 136f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 505f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)142);
				this.HNPJHBKPFCO();
			}
		}

		// Token: 0x06010E44 RID: 69188 RVA: 0x00791CE0 File Offset: 0x0078FEE0
		private void IKMOPNIDMPI()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E45 RID: 69189 RVA: 0x00791D18 File Offset: 0x0078FF18
		private void BEOFOEMOJAN()
		{
			if (GUI.Button(new Rect(1213f, (float)(Screen.height - -91), 423f, 1547f), "sys"))
			{
				this.GCAKJMLKCNJ.DLDPMEJFOLH();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E46 RID: 69190 RVA: 0x00791D70 File Offset: 0x0078FF70
		private void HMPFJEPODEL()
		{
			if (GUI.Button(new Rect(849f, (float)(Screen.height - -105), 1588f, 1172f), "inv_effectinf"))
			{
				this.GCAKJMLKCNJ.BKIAAPBGCDG();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.IIHCKACAFGA();
			}
		}

		// Token: 0x06010E47 RID: 69191 RVA: 0x00791DC8 File Offset: 0x0078FFC8
		private void NECHJAHFOFF()
		{
			if (GUI.Button(new Rect(259f, (float)(Screen.height - -29), 961f, 954f), ""))
			{
				this.GCAKJMLKCNJ.AJOBDOMBGND();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.NOOCCBPAIIJ();
			}
		}

		// Token: 0x06010E48 RID: 69192 RVA: 0x00791E20 File Offset: 0x00790020
		private void FCCLAAKBMGM()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E49 RID: 69193 RVA: 0x0078D582 File Offset: 0x0078B782
		private void DHGCOGABJFK()
		{
			this.PAJMDHLAKOJ();
		}

		// Token: 0x06010E4A RID: 69194 RVA: 0x00791E58 File Offset: 0x00790058
		private void BCJFDHBDAHD()
		{
			if (GUI.Button(new Rect(928f, (float)(Screen.height - 53), 1519f, 246f), ""))
			{
				this.GCAKJMLKCNJ.MHJKBMIOGCD();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.BONHOFPGCKL();
			}
		}

		// Token: 0x06010E4B RID: 69195 RVA: 0x00791EB0 File Offset: 0x007900B0
		public bool KCELJMMPEIC(Vector3 NHCLMBOINFG)
		{
			Ray ray = Camera.main.ScreenPointToRay(NHCLMBOINFG);
			RaycastHit raycastHit;
			if (!Physics.Raycast(ray.origin, ray.direction, out raycastHit))
			{
				return false;
			}
			pb_Object component = raycastHit.transform.gameObject.GetComponent<pb_Object>();
			if (component == null)
			{
				return false;
			}
			Mesh msh = component.msh;
			int[] array = new int[5];
			array[1] = msh.triangles[raycastHit.triangleIndex * 6];
			array[1] = msh.triangles[raycastHit.triangleIndex * 4 + 1];
			array[8] = msh.triangles[raycastHit.triangleIndex * 3 + 5];
			int[] tri = array;
			this.GCAKJMLKCNJ.MPDJOADEOKK = component;
			return component.FaceWithTriangle(tri, out this.GCAKJMLKCNJ.LEBPNFGNEBI);
		}

		// Token: 0x06010E4C RID: 69196 RVA: 0x00791F70 File Offset: 0x00790170
		private void BHALJCJOPGD()
		{
			if (GUI.Button(new Rect(1856f, (float)(Screen.height - -115), 98f, 80f), "_FogVoidPosition"))
			{
				this.GCAKJMLKCNJ.AOALOOAOCDF();
				UnityEngine.Object.Destroy(this.LAFGDIBJMKL.gameObject);
				this.KNPKMIAEBBB();
			}
		}

		// Token: 0x06010E4D RID: 69197 RVA: 0x00791FC8 File Offset: 0x007901C8
		private void HJAFOPMLDCF()
		{
			pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			pb_Object.gameObject.AddComponent<MeshCollider>().convex = true;
			this.GCAKJMLKCNJ = new RuntimeEdit.OIEBALKAEJP(pb_Object, null);
		}

		// Token: 0x06010E4E RID: 69198 RVA: 0x0078D06B File Offset: 0x0078B26B
		private void ECOOMJKPKCC()
		{
			this.IIHCKACAFGA();
		}

		// Token: 0x06010E4F RID: 69199 RVA: 0x00792000 File Offset: 0x00790200
		public void CMDJHGMGLCG()
		{
			if (!this.GCAKJMLKCNJ.EJKGEKBOCGH())
			{
				return;
			}
			if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(1) && Input.GetKey(KeyCode.Tilde)))
			{
				this.OCEINHPECIH = Input.mousePosition;
				this.NFAMBCBPICK = false;
			}
			if (this.NFAMBCBPICK)
			{
				Vector2 vector = this.OCEINHPECIH - Input.mousePosition;
				Vector3 axis = new Vector3(vector.y, vector.x, 366f);
				this.GCAKJMLKCNJ.MPDJOADEOKK.gameObject.transform.RotateAround(Vector3.zero, axis, this.rotateSpeed * Time.deltaTime);
				if (this.GCAKJMLKCNJ.IICMDKCGEFN())
				{
					this.HNPJHBKPFCO();
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(0))
			{
				this.NFAMBCBPICK = false;
			}
		}

		// Token: 0x06010E50 RID: 69200 RVA: 0x007920E0 File Offset: 0x007902E0
		public void MEFOGCFJBNE()
		{
			if (Input.GetMouseButtonUp(1) && !Input.GetKey((KeyCode)(-156)) && this.JABEFFLNJNF(Input.mousePosition) && this.GCAKJMLKCNJ.FPMLGFEOGCI())
			{
				if (!this.GCAKJMLKCNJ.JEENIOAMFDH(this.JKEJJDJMCIB))
				{
					this.JKEJJDJMCIB = new RuntimeEdit.OIEBALKAEJP(this.GCAKJMLKCNJ.MPDJOADEOKK, this.GCAKJMLKCNJ.LEBPNFGNEBI);
					this.PGJNDPKJOFO();
					return;
				}
				Vector3 vector = pb_Math.Normal(this.GCAKJMLKCNJ.MPDJOADEOKK.vertices.ValuesWithIndices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices));
				if (Input.GetKey((KeyCode)83))
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1678f);
				}
				else
				{
					this.GCAKJMLKCNJ.MPDJOADEOKK.TranslateVertices(this.GCAKJMLKCNJ.LEBPNFGNEBI.distinctIndices, vector.normalized * 1493f);
				}
				this.GCAKJMLKCNJ.MPDJOADEOKK.Refresh((RefreshMask)(-75));
				this.DJDAAIMDLKE();
			}
		}

		// Token: 0x0400234C RID: 9036
		private RuntimeEdit.OIEBALKAEJP GCAKJMLKCNJ;

		// Token: 0x0400234D RID: 9037
		private RuntimeEdit.OIEBALKAEJP JKEJJDJMCIB;

		// Token: 0x0400234E RID: 9038
		private pb_Object LAFGDIBJMKL;

		// Token: 0x0400234F RID: 9039
		public Material previewMaterial;

		// Token: 0x04002350 RID: 9040
		private Vector2 OCEINHPECIH = Vector2.zero;

		// Token: 0x04002351 RID: 9041
		private bool NFAMBCBPICK;

		// Token: 0x04002352 RID: 9042
		public float rotateSpeed = 100f;

		// Token: 0x020004DE RID: 1246
		private class OIEBALKAEJP
		{
			// Token: 0x06010E51 RID: 69201 RVA: 0x00792218 File Offset: 0x00790418
			public bool JKHHAGIEOFO()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E52 RID: 69202 RVA: 0x00792233 File Offset: 0x00790433
			public bool KAAJNHMODLF(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.INBJOJBHHJN() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E53 RID: 69203 RVA: 0x00792265 File Offset: 0x00790465
			public bool LEDFEHFJIPB()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E54 RID: 69204 RVA: 0x00792280 File Offset: 0x00790480
			public bool PMBLPCALPLJ()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E55 RID: 69205 RVA: 0x0079228E File Offset: 0x0079048E
			public bool EADNBELIHFP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.COPPMLHKOPP() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E56 RID: 69206 RVA: 0x00792280 File Offset: 0x00790480
			public bool DBJBEFJDDKD()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E57 RID: 69207 RVA: 0x007922C0 File Offset: 0x007904C0
			public void FAMOACBDMIL()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E58 RID: 69208 RVA: 0x00792218 File Offset: 0x00790418
			public bool MAMKLPIEAHL()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E59 RID: 69209 RVA: 0x007922E0 File Offset: 0x007904E0
			public bool FFGIMBGINCG(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.FPMLGFEOGCI() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E5A RID: 69210 RVA: 0x00792314 File Offset: 0x00790514
			public virtual string FODPNPHBOKL()
			{
				if ("cht_msg40" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_UserLutParams" + ((this.LEBPNFGNEBI == null) ? "Soccer Pass Heavy" : this.LEBPNFGNEBI.ToString());
				}
				return "Try to change this float in memory:\n";
			}

			// Token: 0x06010E5B RID: 69211 RVA: 0x00792368 File Offset: 0x00790568
			public virtual string PFNDMCPAGLP()
			{
				if ("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "AssetBundleManager" + ((this.LEBPNFGNEBI == null) ? "" : this.LEBPNFGNEBI.ToString());
				}
				return "{0}";
			}

			// Token: 0x06010E5C RID: 69212 RVA: 0x007923BC File Offset: 0x007905BC
			public bool NEBNNHMFKEP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.DNIAGDMODBI() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E5D RID: 69213 RVA: 0x00792280 File Offset: 0x00790480
			public bool EJLAFOLJOGH()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E5E RID: 69214 RVA: 0x007922C0 File Offset: 0x007904C0
			public void OGJAEBBPNCJ()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E5F RID: 69215 RVA: 0x007923F0 File Offset: 0x007905F0
			public virtual string FGNNJFJLENH()
			{
				if ("No hit from " + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_History1Weight" + ((this.LEBPNFGNEBI == null) ? "28" : this.LEBPNFGNEBI.ToString());
				}
				return "RIGHT";
			}

			// Token: 0x06010E60 RID: 69216 RVA: 0x00792444 File Offset: 0x00790644
			public bool AKNGIFMHCKC(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.IBIAEBKPJBN() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E61 RID: 69217 RVA: 0x00792280 File Offset: 0x00790480
			public bool KJCAIIFNOOL()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E62 RID: 69218 RVA: 0x00792478 File Offset: 0x00790678
			public virtual string IPDCPCECFBC()
			{
				if ("iPoint" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "short:" + ((this.LEBPNFGNEBI == null) ? "DepthCamera" : this.LEBPNFGNEBI.ToString());
				}
				return "_Density";
			}

			// Token: 0x06010E63 RID: 69219 RVA: 0x00792218 File Offset: 0x00790418
			public bool OECJJLKPHPP()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E64 RID: 69220 RVA: 0x007924CC File Offset: 0x007906CC
			public virtual string GMLGLOOIEAA()
			{
				if ("'" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "SexyDance3" + ((this.LEBPNFGNEBI == null) ? "ComeHere" : this.LEBPNFGNEBI.ToString());
				}
				return "|";
			}

			// Token: 0x06010E65 RID: 69221 RVA: 0x00792280 File Offset: 0x00790480
			public bool EJKGEKBOCGH()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E66 RID: 69222 RVA: 0x00792520 File Offset: 0x00790720
			public bool FMKEADEGGPP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.LLHDJAGFPIG() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E67 RID: 69223 RVA: 0x00792280 File Offset: 0x00790480
			public bool PHFPODGCCMC()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E68 RID: 69224 RVA: 0x00792552 File Offset: 0x00790752
			public bool JEENIOAMFDH(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.IICMDKCGEFN() || !(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010E69 RID: 69225 RVA: 0x00792584 File Offset: 0x00790784
			public bool CNJEODHMLDK(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.PEFCPOAGLGE() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E6A RID: 69226 RVA: 0x00792280 File Offset: 0x00790480
			public bool CGBFJINDKFH()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E6B RID: 69227 RVA: 0x007925B6 File Offset: 0x007907B6
			public bool JLAIADLPLFO(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.INBJOJBHHJN() && this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010E6C RID: 69228 RVA: 0x007925E8 File Offset: 0x007907E8
			public bool EENJMDNDOHI(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.CHFHJDFDIGB() && this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010E6D RID: 69229 RVA: 0x0079261A File Offset: 0x0079081A
			public bool EMLOCILGCME(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.PDFKFCKEDEN() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E6E RID: 69230 RVA: 0x0079264C File Offset: 0x0079084C
			public bool FMLMAJAOGOG(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.COPPMLHKOPP() || !(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010E6F RID: 69231 RVA: 0x0079267E File Offset: 0x0079087E
			public bool PLMGGFDKEKK(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.MAMKLPIEAHL() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E70 RID: 69232 RVA: 0x00792280 File Offset: 0x00790480
			public bool JDONAFKEEHJ()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E71 RID: 69233 RVA: 0x00792218 File Offset: 0x00790418
			public bool COPPMLHKOPP()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E72 RID: 69234 RVA: 0x007926B0 File Offset: 0x007908B0
			public virtual string CBPDHBKDMGC()
			{
				if ("stacheaderprocess" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "UI_MapWindow_b" + ((this.LEBPNFGNEBI == null) ? "qd_week" : this.LEBPNFGNEBI.ToString());
				}
				return "System.Boolean";
			}

			// Token: 0x06010E73 RID: 69235 RVA: 0x007922C0 File Offset: 0x007904C0
			public void LINDPIMHBGA()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E74 RID: 69236 RVA: 0x00792704 File Offset: 0x00790904
			public virtual string MJODNMLNFJC()
			{
				if ("gi_sadokfull" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "DealerIdle" + ((this.LEBPNFGNEBI == null) ? "name" : this.LEBPNFGNEBI.ToString());
				}
				return "21,22,23";
			}

			// Token: 0x06010E75 RID: 69237 RVA: 0x00792265 File Offset: 0x00790465
			public bool IBIAEBKPJBN()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E76 RID: 69238 RVA: 0x00792758 File Offset: 0x00790958
			public virtual string ANEPAFOMGND()
			{
				if ("<color='#60e0ff'>" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "{" + ((this.LEBPNFGNEBI == null) ? "******* playMusicBase  LocNewLogic" : this.LEBPNFGNEBI.ToString());
				}
				return "RunDive";
			}

			// Token: 0x06010E77 RID: 69239 RVA: 0x007922C0 File Offset: 0x007904C0
			public void AJOBDOMBGND()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E78 RID: 69240 RVA: 0x00792280 File Offset: 0x00790480
			public bool EODENACKFKK()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E79 RID: 69241 RVA: 0x00792280 File Offset: 0x00790480
			public bool ENHPPALLBLB()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E7A RID: 69242 RVA: 0x00792265 File Offset: 0x00790465
			public bool PDFKFCKEDEN()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E7B RID: 69243 RVA: 0x007922C0 File Offset: 0x007904C0
			public void CNAPFIEDNPN()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E7C RID: 69244 RVA: 0x007925E8 File Offset: 0x007907E8
			public bool JDBINLKEJMF(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.CHFHJDFDIGB() && this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010E7D RID: 69245 RVA: 0x00792218 File Offset: 0x00790418
			public bool FPMLGFEOGCI()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E7E RID: 69246 RVA: 0x00792280 File Offset: 0x00790480
			public bool OBIOJHLDFMG()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E7F RID: 69247 RVA: 0x007922C0 File Offset: 0x007904C0
			public void MNANPNMBKEI()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E80 RID: 69248 RVA: 0x0079267E File Offset: 0x0079087E
			public bool KENMLFOLLIN(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.MAMKLPIEAHL() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E81 RID: 69249 RVA: 0x007927AC File Offset: 0x007909AC
			public bool GGAIFHHGFAP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.OPFJLKINOHE() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E82 RID: 69250 RVA: 0x007922C0 File Offset: 0x007904C0
			public void MKPMHJPOCNG()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E83 RID: 69251 RVA: 0x007927E0 File Offset: 0x007909E0
			public virtual string ANJOEAHHDGC()
			{
				if ("Tail" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "PaperTurn.wav" + ((this.LEBPNFGNEBI == null) ? "Bone" : this.LEBPNFGNEBI.ToString());
				}
				return "Cowboy1HandDraw";
			}

			// Token: 0x06010E84 RID: 69252 RVA: 0x007922C0 File Offset: 0x007904C0
			public void JGGKDLLBAKD()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E85 RID: 69253 RVA: 0x00792834 File Offset: 0x00790A34
			public virtual string DINGGHOCDNN()
			{
				if (" " + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "</color>" + ((this.LEBPNFGNEBI == null) ? "IceHockeyPassLeft" : this.LEBPNFGNEBI.ToString());
				}
				return "gi_uinf_9";
			}

			// Token: 0x06010E86 RID: 69254 RVA: 0x00792888 File Offset: 0x00790A88
			public bool PIMIMLGPKKD(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.HKIAOHBMKJM() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E87 RID: 69255 RVA: 0x00792584 File Offset: 0x00790784
			public bool GMDDPAGHGGJ(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.PEFCPOAGLGE() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E88 RID: 69256 RVA: 0x00792265 File Offset: 0x00790465
			public bool CHFHJDFDIGB()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E89 RID: 69257 RVA: 0x007922C0 File Offset: 0x007904C0
			public void NPLCIAHGOJM()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E8A RID: 69258 RVA: 0x007928BC File Offset: 0x00790ABC
			public virtual string DFHAGGBIEIH()
			{
				if ("string: " + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "x" + ((this.LEBPNFGNEBI == null) ? "_WorldToCameraMatrix" : this.LEBPNFGNEBI.ToString());
				}
				return ".unity3d";
			}

			// Token: 0x06010E8B RID: 69259 RVA: 0x00792910 File Offset: 0x00790B10
			public bool CKDJMHIHLBA(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.OEENDMJIPJG() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E8C RID: 69260 RVA: 0x00792218 File Offset: 0x00790418
			public bool HKIAOHBMKJM()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E8D RID: 69261 RVA: 0x00792280 File Offset: 0x00790480
			public bool OBKIINLEMEK()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E8E RID: 69262 RVA: 0x00792944 File Offset: 0x00790B44
			public virtual string JKLONALOFEM()
			{
				if ("isRodOpen" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_AccumOrig" + ((this.LEBPNFGNEBI == null) ? "remWpn=" : this.LEBPNFGNEBI.ToString());
				}
				return "______________________________";
			}

			// Token: 0x06010E8F RID: 69263 RVA: 0x00792998 File Offset: 0x00790B98
			public virtual string GAOJCHIOICI()
			{
				if ("{\n" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "-none-" + ((this.LEBPNFGNEBI == null) ? "mid" : this.LEBPNFGNEBI.ToString());
				}
				return "";
			}

			// Token: 0x06010E90 RID: 69264 RVA: 0x007929EC File Offset: 0x00790BEC
			public virtual string BJALMHGGAFM()
			{
				if ("" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "bag" + ((this.LEBPNFGNEBI == null) ? "_NAME" : this.LEBPNFGNEBI.ToString());
				}
				return "MotorbikeShootFwd";
			}

			// Token: 0x06010E91 RID: 69265 RVA: 0x00792280 File Offset: 0x00790480
			public bool PBBNBNEJJDG()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E92 RID: 69266 RVA: 0x00792A40 File Offset: 0x00790C40
			public bool LNGNHLLMFHN(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.CHFHJDFDIGB() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E93 RID: 69267 RVA: 0x00792A74 File Offset: 0x00790C74
			public virtual string CFPMCOPINOH()
			{
				if ("End" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "Perks" + ((this.LEBPNFGNEBI == null) ? "TOD_SunMeshBrightness" : this.LEBPNFGNEBI.ToString());
				}
				return "C";
			}

			// Token: 0x06010E94 RID: 69268 RVA: 0x00792AC8 File Offset: 0x00790CC8
			public virtual string OEAEGBAEEPP()
			{
				if ("***DropPointerEvnt" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "WorkerShovel2" + ((this.LEBPNFGNEBI == null) ? "WizardBlock" : this.LEBPNFGNEBI.ToString());
				}
				return "wpn_rod2";
			}

			// Token: 0x06010E95 RID: 69269 RVA: 0x00792280 File Offset: 0x00790480
			public bool BIPLHBIPDLK()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010E96 RID: 69270 RVA: 0x00792B1C File Offset: 0x00790D1C
			public OIEBALKAEJP(pb_Object FBIIPFJNFMC, pb_Face EKJKPMDGLEG)
			{
				this.MPDJOADEOKK = FBIIPFJNFMC;
				this.LEBPNFGNEBI = EKJKPMDGLEG;
			}

			// Token: 0x06010E97 RID: 69271 RVA: 0x00792218 File Offset: 0x00790418
			public bool LLHDJAGFPIG()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E98 RID: 69272 RVA: 0x007922C0 File Offset: 0x007904C0
			public void LPAHMHOJNPE()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E99 RID: 69273 RVA: 0x007922C0 File Offset: 0x007904C0
			public void FGCNBAEMAAC()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E9A RID: 69274 RVA: 0x007922C0 File Offset: 0x007904C0
			public void AOALOOAOCDF()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010E9B RID: 69275 RVA: 0x00792B34 File Offset: 0x00790D34
			public virtual string BACHFNMDOLO()
			{
				if ("Copying splat set to mis-matched container length" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_alfavis" + ((this.LEBPNFGNEBI == null) ? "Delete Weapon" : this.LEBPNFGNEBI.ToString());
				}
				return "Attempting to remove a RenderTexture that was not allocated: {0}";
			}

			// Token: 0x06010E9C RID: 69276 RVA: 0x00792B88 File Offset: 0x00790D88
			public virtual string DGOBKBBGGKN()
			{
				if ("Hidden/FXAA3" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "pt_setok" + ((this.LEBPNFGNEBI == null) ? "{x}" : this.LEBPNFGNEBI.ToString());
				}
				return "Crouch Strafe Left";
			}

			// Token: 0x06010E9D RID: 69277 RVA: 0x00792218 File Offset: 0x00790418
			public bool OPFJLKINOHE()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010E9E RID: 69278 RVA: 0x00792444 File Offset: 0x00790644
			public bool GDEOMPINPJA(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.IBIAEBKPJBN() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010E9F RID: 69279 RVA: 0x007922C0 File Offset: 0x007904C0
			public void FILBKHHNLNA()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EA0 RID: 69280 RVA: 0x00792BDC File Offset: 0x00790DDC
			public virtual string KBHGJLAEMFH()
			{
				if ("_CurveTex" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + " " + ((this.LEBPNFGNEBI == null) ? "CrawlIdle" : this.LEBPNFGNEBI.ToString());
				}
				return " is represented multiple times in a single IK chain. Can't initiate solver.";
			}

			// Token: 0x06010EA1 RID: 69281 RVA: 0x00792265 File Offset: 0x00790465
			public bool IICMDKCGEFN()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EA2 RID: 69282 RVA: 0x007922E0 File Offset: 0x007904E0
			public bool CJCOEFNMNNI(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.FPMLGFEOGCI() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EA3 RID: 69283 RVA: 0x00792C30 File Offset: 0x00790E30
			public virtual string DIJJDHMMGCA()
			{
				if ("Leg" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "SoccerKeeperReady" + ((this.LEBPNFGNEBI == null) ? "WalkDehydrated" : this.LEBPNFGNEBI.ToString());
				}
				return "Jump";
			}

			// Token: 0x06010EA4 RID: 69284 RVA: 0x00792A40 File Offset: 0x00790C40
			public bool MBKPGDFDNHP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.CHFHJDFDIGB() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EA5 RID: 69285 RVA: 0x00792C84 File Offset: 0x00790E84
			public virtual string OCJAOJLHOFO()
			{
				if ("\n" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "shop_t16" + ((this.LEBPNFGNEBI == null) ? "SoccerTackle" : this.LEBPNFGNEBI.ToString());
				}
				return "WeaponRun";
			}

			// Token: 0x06010EA6 RID: 69286 RVA: 0x00792CD8 File Offset: 0x00790ED8
			public virtual string EAGIBIOFDBJ()
			{
				if ("reel_type1" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_FilteredReflections" + ((this.LEBPNFGNEBI == null) ? "WeaponFire" : this.LEBPNFGNEBI.ToString());
				}
				return "_Offsets";
			}

			// Token: 0x06010EA7 RID: 69287 RVA: 0x00792265 File Offset: 0x00790465
			public bool GGHCAMNAIDE()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EA8 RID: 69288 RVA: 0x00792D2C File Offset: 0x00790F2C
			public bool HCBHPHCGGEN(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.MAMKLPIEAHL() && this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010EA9 RID: 69289 RVA: 0x00792D5E File Offset: 0x00790F5E
			public bool ICANHIGGPAL(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.BJFLIAHLBDP() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EAA RID: 69290 RVA: 0x00792D90 File Offset: 0x00790F90
			public virtual string MOBHDMJGEEC()
			{
				if ("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_Phase" + ((this.LEBPNFGNEBI == null) ? "reflectQuality" : this.LEBPNFGNEBI.ToString());
				}
				return "Attempting to remove a RenderTexture that was not allocated: {0}";
			}

			// Token: 0x06010EAB RID: 69291 RVA: 0x007922C0 File Offset: 0x007904C0
			public void JNINPMFFLEB()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EAC RID: 69292 RVA: 0x00792DE4 File Offset: 0x00790FE4
			public virtual string PMPNLAFNBBC()
			{
				if ("" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "-l-" + ((this.LEBPNFGNEBI == null) ? "MAP_NAMES" : this.LEBPNFGNEBI.ToString());
				}
				return "bs_nomoney";
			}

			// Token: 0x06010EAD RID: 69293 RVA: 0x00792E38 File Offset: 0x00791038
			public bool BOAENGKCGND(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.PEFCPOAGLGE() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EAE RID: 69294 RVA: 0x00792218 File Offset: 0x00790418
			public bool BJFLIAHLBDP()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EAF RID: 69295 RVA: 0x007922C0 File Offset: 0x007904C0
			public void LCDNJEFLAPE()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EB0 RID: 69296 RVA: 0x00792E6C File Offset: 0x0079106C
			public virtual string IAJFNKBPACC()
			{
				if ("</color>" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "cntx_teachexp" + ((this.LEBPNFGNEBI == null) ? "QUEST CMD " : this.LEBPNFGNEBI.ToString());
				}
				return "rbon";
			}

			// Token: 0x06010EB1 RID: 69297 RVA: 0x00792EC0 File Offset: 0x007910C0
			public virtual string JMCNJFKMDKI()
			{
				if ("\n" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "Far" + ((this.LEBPNFGNEBI == null) ? "_NormalAndRoughnessTexture" : this.LEBPNFGNEBI.ToString());
				}
				return "Curve";
			}

			// Token: 0x06010EB2 RID: 69298 RVA: 0x007922C0 File Offset: 0x007904C0
			public void AJGGOCKJHOJ()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EB3 RID: 69299 RVA: 0x00792218 File Offset: 0x00790418
			public bool DNIAGDMODBI()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EB4 RID: 69300 RVA: 0x00792280 File Offset: 0x00790480
			public bool GFMOILEDJFM()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010EB5 RID: 69301 RVA: 0x00792280 File Offset: 0x00790480
			public bool EDPGAIOLDKI()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010EB6 RID: 69302 RVA: 0x00792265 File Offset: 0x00790465
			public bool INBJOJBHHJN()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EB7 RID: 69303 RVA: 0x007922C0 File Offset: 0x007904C0
			public void MHJKBMIOGCD()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EB8 RID: 69304 RVA: 0x007922C0 File Offset: 0x007904C0
			public void BKIAAPBGCDG()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EB9 RID: 69305 RVA: 0x00792F14 File Offset: 0x00791114
			public bool AFDHOIDFLJA(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.IICMDKCGEFN() || (this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK && this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EBA RID: 69306 RVA: 0x00792F48 File Offset: 0x00791148
			public virtual string KJFKHMONBLB()
			{
				if ("ClimbIdle" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "SneakForward" + ((this.LEBPNFGNEBI == null) ? "#> _Wrinkles Occlusion Camera < " : this.LEBPNFGNEBI.ToString());
				}
				return "FOG_VOID_SPHERE";
			}

			// Token: 0x06010EBB RID: 69307 RVA: 0x00792265 File Offset: 0x00790465
			public bool OEENDMJIPJG()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EBC RID: 69308 RVA: 0x00792F9C File Offset: 0x0079119C
			public bool LCBEDPPBPAH(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.DNIAGDMODBI() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EBD RID: 69309 RVA: 0x00792FD0 File Offset: 0x007911D0
			public virtual string CJMFHLIBCBM()
			{
				if ("LHandPunch" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "C" + ((this.LEBPNFGNEBI == null) ? "Silence OK. Object:" : this.LEBPNFGNEBI.ToString());
				}
				return "holes_max";
			}

			// Token: 0x06010EBE RID: 69310 RVA: 0x007922C0 File Offset: 0x007904C0
			public void JKMFJFGGDKM()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010EBF RID: 69311 RVA: 0x00793024 File Offset: 0x00791224
			public virtual string NJECBCLINBO()
			{
				if ("Auktree.xml" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "FlyRight" + ((this.LEBPNFGNEBI == null) ? "<[^>]+>" : this.LEBPNFGNEBI.ToString());
				}
				return "name";
			}

			// Token: 0x06010EC0 RID: 69312 RVA: 0x00792584 File Offset: 0x00790784
			public bool MJDHBHHGMKC(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.PEFCPOAGLGE() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EC1 RID: 69313 RVA: 0x00793078 File Offset: 0x00791278
			public bool IKONKPHGOAB(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.LEDFEHFJIPB() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EC2 RID: 69314 RVA: 0x007930AA File Offset: 0x007912AA
			public bool BJFOHGGCKNP(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND == null || !DCACHNCPCND.FPMLGFEOGCI() || !(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI;
			}

			// Token: 0x06010EC3 RID: 69315 RVA: 0x00792265 File Offset: 0x00790465
			public bool NIKMGNDDGFE()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010EC4 RID: 69316 RVA: 0x007930DC File Offset: 0x007912DC
			public bool JJALCADHNHE(RuntimeEdit.OIEBALKAEJP DCACHNCPCND)
			{
				return DCACHNCPCND != null && DCACHNCPCND.IBIAEBKPJBN() && (!(this.MPDJOADEOKK == DCACHNCPCND.MPDJOADEOKK) || this.LEBPNFGNEBI == DCACHNCPCND.LEBPNFGNEBI);
			}

			// Token: 0x06010EC5 RID: 69317 RVA: 0x00793110 File Offset: 0x00791310
			public virtual string GJCCJEINDDC()
			{
				if ("Pistol Instant" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "Flap_02.wav" + ((this.LEBPNFGNEBI == null) ? "InteractionObject " : this.LEBPNFGNEBI.ToString());
				}
				return "bs_lowlv";
			}

			// Token: 0x06010EC6 RID: 69318 RVA: 0x00793164 File Offset: 0x00791364
			public virtual string NEIAHJGEINP()
			{
				if ("ok" + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "RandomSound" + ((this.LEBPNFGNEBI == null) ? "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" : this.LEBPNFGNEBI.ToString());
				}
				return "DropType";
			}

			// Token: 0x06010EC7 RID: 69319 RVA: 0x007931B8 File Offset: 0x007913B8
			public virtual string BHLHEJCILKF()
			{
				if ("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center)." + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "_BlurCoe" + ((this.LEBPNFGNEBI == null) ? "Hidden/Post FX/Uber Shader" : this.LEBPNFGNEBI.ToString());
				}
				return "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			}

			// Token: 0x06010EC8 RID: 69320 RVA: 0x0079320C File Offset: 0x0079140C
			public override string ToString()
			{
				if ("pb_Object: " + this.MPDJOADEOKK != null)
				{
					return this.MPDJOADEOKK.name + "\npb_Face: " + ((this.LEBPNFGNEBI == null) ? "Null" : this.LEBPNFGNEBI.ToString());
				}
				return "Null";
			}

			// Token: 0x06010EC9 RID: 69321 RVA: 0x00792280 File Offset: 0x00790480
			public bool COJKJGNLAAK()
			{
				return this.MPDJOADEOKK != null;
			}

			// Token: 0x06010ECA RID: 69322 RVA: 0x007922C0 File Offset: 0x007904C0
			public void DLDPMEJFOLH()
			{
				if (this.MPDJOADEOKK != null)
				{
					UnityEngine.Object.Destroy(this.MPDJOADEOKK.gameObject);
				}
			}

			// Token: 0x06010ECB RID: 69323 RVA: 0x00792265 File Offset: 0x00790465
			public bool JEJMAJMCJPM()
			{
				return this.MPDJOADEOKK != null && this.LEBPNFGNEBI != null;
			}

			// Token: 0x06010ECC RID: 69324 RVA: 0x00792218 File Offset: 0x00790418
			public bool PEFCPOAGLGE()
			{
				return !(this.MPDJOADEOKK != null) || this.LEBPNFGNEBI != null;
			}

			// Token: 0x04002353 RID: 9043
			public pb_Object MPDJOADEOKK;

			// Token: 0x04002354 RID: 9044
			public pb_Face LEBPNFGNEBI;
		}
	}
}
