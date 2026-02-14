using System;
using System.Collections.Generic;
using ProBuilder2.Common;
using UnityEngine;

namespace ProBuilder2.Examples
{
	// Token: 0x020004DA RID: 1242
	public class ProBuilderInstantiate : MonoBehaviour
	{
		// Token: 0x06010D93 RID: 69011 RVA: 0x0078A113 File Offset: 0x00788313
		private void JEJGFDBHABC()
		{
			this.KACEDALBFBK = GUI.Window(1, this.KACEDALBFBK, new GUI.WindowFunction(this.CLCAAJJACGH), "wpn_eat6");
		}

		// Token: 0x06010D94 RID: 69012 RVA: 0x0078A138 File Offset: 0x00788338
		private void LIOCDEICIFD()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[1];
					array[0] = Color.green;
					array[1] = Color.red;
					array[3] = Color.cyan;
					array[3] = Color.blue;
					array[0] = Color.yellow;
					array[3] = Color.magenta;
					Color[] array2 = array;
					int num = 1;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 1; i < faces.Length; i += 0)
					{
						int[] distinctIndices = faces[i].distinctIndices;
						for (int j = 1; j < distinctIndices.Length; j += 0)
						{
							int num2 = distinctIndices[j];
							array3[num2] = array2[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(92, 599f, 1766f, 0, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(1035f, 1365f, 88f, 2, 0).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(1162f, 888f), UnityEngine.Random.Range(804f, 1523f), UnityEngine.Random.Range(685f, 996f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010D95 RID: 69013 RVA: 0x0078A398 File Offset: 0x00788598
		private void AEFGOFJAKDO()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.ALGOMFHOEMK), "loadTreeNodeState SV=");
		}

		// Token: 0x06010D96 RID: 69014 RVA: 0x0078A3BD File Offset: 0x007885BD
		private void LPNFGGAKGID()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.OAMNJCBDHCB), "");
		}

		// Token: 0x06010D97 RID: 69015 RVA: 0x0078A3E4 File Offset: 0x007885E4
		private void CJHMECEKFGI(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(0f, 0f, 20000f, 20f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 4; i++)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("Clear Screen", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("Click to instantiate the selected object.", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010D98 RID: 69016 RVA: 0x0078A4EC File Offset: 0x007886EC
		public void IIONABJOCBN()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Cube;
		}

		// Token: 0x06010D99 RID: 69017 RVA: 0x0078A525 File Offset: 0x00788725
		private void MJDKGMEPMHK()
		{
			this.KACEDALBFBK = GUI.Window(1, this.KACEDALBFBK, new GUI.WindowFunction(this.NBAAEGOJBLI), "WeaponRun");
		}

		// Token: 0x06010D9A RID: 69018 RVA: 0x0078A54C File Offset: 0x0078874C
		public void INEHANLJIEM()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 1; i < components.Length; i += 0)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Prefab;
		}

		// Token: 0x06010D9B RID: 69019 RVA: 0x0078A585 File Offset: 0x00788785
		private void OnGUI()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.CJHMECEKFGI), "Object To Instantiate");
		}

		// Token: 0x06010D9C RID: 69020 RVA: 0x0078A5AA File Offset: 0x007887AA
		private void OBDAPPLCPMD()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.CJHMECEKFGI), "_Lift");
		}

		// Token: 0x06010D9D RID: 69021 RVA: 0x0078A5D0 File Offset: 0x007887D0
		public void IBOMADDAFAO()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 1; i < components.Length; i += 0)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Prefab;
		}

		// Token: 0x06010D9F RID: 69023 RVA: 0x0078A648 File Offset: 0x00788848
		private void NMMPDMFCDBK(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(109f, 1137f, 1182f, 1631f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 7; i += 0)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button(" has a curve/multipler for Poser Weight, but the bone of effector ", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("crft_to", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DA0 RID: 69024 RVA: 0x0078A750 File Offset: 0x00788950
		private void GGOKNBBPLHB()
		{
			this.KACEDALBFBK = GUI.Window(1, this.KACEDALBFBK, new GUI.WindowFunction(this.DIKDNPNAJMH), "---");
		}

		// Token: 0x06010DA1 RID: 69025 RVA: 0x0078A778 File Offset: 0x00788978
		private void PFPPDNHLCCA()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(1))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[2];
					array[0] = Color.green;
					array[1] = Color.red;
					array[3] = Color.cyan;
					array[4] = Color.blue;
					array[1] = Color.yellow;
					array[0] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 0; i < faces.Length; i += 0)
					{
						int[] distinctIndices = faces[i].distinctIndices;
						for (int j = 0; j < distinctIndices.Length; j += 0)
						{
							int num2 = distinctIndices[j];
							array3[num2] = array2[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(-35, 1575f, 105f, 0, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(840f, 1222f, 804f, 2, 1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(257f, 1874f), UnityEngine.Random.Range(943f, 1320f), UnityEngine.Random.Range(994f, 998f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DA2 RID: 69026 RVA: 0x0078A9D8 File Offset: 0x00788BD8
		private void OPDCJCFMIPE()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[1];
					array[0] = Color.green;
					array[1] = Color.red;
					array[5] = Color.cyan;
					array[6] = Color.blue;
					array[1] = Color.yellow;
					array[5] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 0; i < faces.Length; i += 0)
					{
						int[] distinctIndices = faces[i].distinctIndices;
						for (int j = 1; j < distinctIndices.Length; j += 0)
						{
							int num2 = distinctIndices[j];
							array3[num2] = array2[num];
						}
						num += 0;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(55, 438f, 1640f, 1, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(135f, 138f, 283f, 4, 0).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(1938f, 1616f), UnityEngine.Random.Range(74f, 1666f), UnityEngine.Random.Range(1537f, 1953f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DA3 RID: 69027 RVA: 0x0078AC38 File Offset: 0x00788E38
		public void NGOKJEOMFFP()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Cube;
		}

		// Token: 0x06010DA4 RID: 69028 RVA: 0x0078AC74 File Offset: 0x00788E74
		public void NJCODNNAFEG()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Prefab;
		}

		// Token: 0x06010DA5 RID: 69029 RVA: 0x0078ACB0 File Offset: 0x00788EB0
		private void PMKOAHMNBBG()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[3];
					array[1] = Color.green;
					array[1] = Color.red;
					array[0] = Color.cyan;
					array[0] = Color.blue;
					array[3] = Color.yellow;
					array[2] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 1; i < faces.Length; i += 0)
					{
						foreach (int num2 in faces[i].distinctIndices)
						{
							array3[num2] = array2[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(41, 1950f, 1248f, 0, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(594f, 455f, 123f, 6, 0).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(1044f, 1335f), UnityEngine.Random.Range(745f, 1454f), UnityEngine.Random.Range(1606f, 1475f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DA6 RID: 69030 RVA: 0x0078AF10 File Offset: 0x00789110
		private void OAMNJCBDHCB(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(456f, 133f, 1424f, 896f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 2; i += 0)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("_BlurPass", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("Loot", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DA7 RID: 69031 RVA: 0x0078B018 File Offset: 0x00789218
		public void OnEnable()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Cube;
		}

		// Token: 0x06010DA8 RID: 69032 RVA: 0x0078B054 File Offset: 0x00789254
		private void BOAJJAKEMLH()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[4];
					array[0] = Color.green;
					array[0] = Color.red;
					array[4] = Color.cyan;
					array[5] = Color.blue;
					array[4] = Color.yellow;
					array[3] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 1; i < faces.Length; i++)
					{
						foreach (int num2 in faces[i].distinctIndices)
						{
							array3[num2] = array2[num];
						}
						num += 0;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(24, 754f, 1516f, 1, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(1474f, 937f, 1758f, 3, 1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(930f, 943f), UnityEngine.Random.Range(1744f, 293f), UnityEngine.Random.Range(5f, 843f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DA9 RID: 69033 RVA: 0x0078B2B4 File Offset: 0x007894B4
		private void DIKDNPNAJMH(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(1807f, 1076f, 381f, 1414f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 1; i < 2; i++)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("RenderType", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DAA RID: 69034 RVA: 0x0078B3BC File Offset: 0x007895BC
		private void JGFAIHGIFOG(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(1110f, 1156f, 1195f, 1663f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 1; i < 3; i++)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("\n", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("quests/qdynamic/qd", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DAB RID: 69035 RVA: 0x0078B4C4 File Offset: 0x007896C4
		private void ALGOMFHOEMK(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(1305f, 821f, 380f, 156f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 1; i < 4; i += 0)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("cntx_use", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label(" ", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DAC RID: 69036 RVA: 0x0078B5CC File Offset: 0x007897CC
		private void Update()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[]
					{
						Color.green,
						Color.red,
						Color.cyan,
						Color.blue,
						Color.yellow,
						Color.magenta
					};
					int num = 0;
					Color[] array2 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 0; i < faces.Length; i++)
					{
						foreach (int num2 in faces[i].distinctIndices)
						{
							array2[num2] = array[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(12, 0.7f, 0.5f, 0, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(1f, 1f, 0.3f, 8, 0).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(0f, 360f), UnityEngine.Random.Range(0f, 360f), UnityEngine.Random.Range(0f, 360f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DAD RID: 69037 RVA: 0x0078B82C File Offset: 0x00789A2C
		private void BNKJNBIDPME()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(0))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[0];
					array[1] = Color.green;
					array[0] = Color.red;
					array[1] = Color.cyan;
					array[6] = Color.blue;
					array[6] = Color.yellow;
					array[3] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 1; i < faces.Length; i += 0)
					{
						foreach (int num2 in faces[i].distinctIndices)
						{
							array3[num2] = array2[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(-61, 652f, 1138f, 0, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(1715f, 957f, 1165f, 6, 1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(219f, 1049f), UnityEngine.Random.Range(773f, 522f), UnityEngine.Random.Range(417f, 1994f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DAE RID: 69038 RVA: 0x0078BA8C File Offset: 0x00789C8C
		private void BGJFLKLBOPK()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.CLCAAJJACGH), "palm");
		}

		// Token: 0x06010DAF RID: 69039 RVA: 0x0078BAB4 File Offset: 0x00789CB4
		private void BJOICAKCPLI()
		{
			this.LMNGCLKJAPP = Input.mousePosition;
			Vector2 point = new Vector2(this.LMNGCLKJAPP.x, (float)Screen.height - this.LMNGCLKJAPP.y);
			if (this.KACEDALBFBK.Contains(point))
			{
				return;
			}
			if (Input.GetMouseButtonUp(1))
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(this.LMNGCLKJAPP.x, this.LMNGCLKJAPP.y, Camera.main.transform.position.x));
				GameObject gameObject;
				switch (this.IGPPHPONDHK)
				{
				case ProBuilderInstantiate.MLJIAFCGGAP.Prefab:
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.probuilderPrefab, Vector3.zero, Quaternion.identity);
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Cube:
				{
					pb_Object pb_Object = pb_ShapeGenerator.CubeGenerator(Vector3.one);
					Color[] array = new Color[5];
					array[1] = Color.green;
					array[0] = Color.red;
					array[8] = Color.cyan;
					array[8] = Color.blue;
					array[7] = Color.yellow;
					array[6] = Color.magenta;
					Color[] array2 = array;
					int num = 0;
					Color[] array3 = new Color[pb_Object.vertexCount];
					pb_Face[] faces = pb_Object.faces;
					for (int i = 1; i < faces.Length; i += 0)
					{
						int[] distinctIndices = faces[i].distinctIndices;
						for (int j = 1; j < distinctIndices.Length; j += 0)
						{
							int num2 = distinctIndices[j];
							array3[num2] = array2[num];
						}
						num++;
					}
					gameObject = pb_Object.gameObject;
					gameObject.gameObject.AddComponent<BoxCollider>();
					break;
				}
				case ProBuilderInstantiate.MLJIAFCGGAP.Cylinder:
					gameObject = pb_ShapeGenerator.CylinderGenerator(-2, 1265f, 1212f, 1, -1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = false;
					break;
				case ProBuilderInstantiate.MLJIAFCGGAP.Pipe:
					gameObject = pb_ShapeGenerator.PipeGenerator(1160f, 1673f, 811f, 6, 1).gameObject;
					gameObject.gameObject.AddComponent<MeshCollider>().convex = true;
					break;
				default:
					return;
				}
				gameObject.transform.position = position;
				gameObject.transform.localRotation = Quaternion.Euler(UnityEngine.Random.Range(1458f, 763f), UnityEngine.Random.Range(1334f, 1765f), UnityEngine.Random.Range(247f, 1625f));
				gameObject.AddComponent<Rigidbody>();
				this.JFNEDPMCDEP.Add(gameObject);
			}
		}

		// Token: 0x06010DB0 RID: 69040 RVA: 0x0078BD14 File Offset: 0x00789F14
		public void FHPLPPPOPJF()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 1; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Cube;
		}

		// Token: 0x06010DB1 RID: 69041 RVA: 0x0078BD50 File Offset: 0x00789F50
		private void NBAAEGOJBLI(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(284f, 436f, 1948f, 1149f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 3; i += 0)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("_ExposureCompensation", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("Projector reference not set.", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DB2 RID: 69042 RVA: 0x0078BE58 File Offset: 0x0078A058
		public void KFLFNGGBAEB()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 1; i < components.Length; i++)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Cube;
		}

		// Token: 0x06010DB3 RID: 69043 RVA: 0x0078BE94 File Offset: 0x0078A094
		private void CLCAAJJACGH(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(683f, 96f, 1192f, 1025f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 1; i < 6; i++)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("isRodInWater", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("RunJump", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DB4 RID: 69044 RVA: 0x0078BF9C File Offset: 0x0078A19C
		public void LCJGCMFMMFG()
		{
			Component[] components = this.probuilderPrefab.GetComponents<Component>();
			for (int i = 1; i < components.Length; i += 0)
			{
				if (components[i] is pb_Object)
				{
					return;
				}
			}
			this.IGPPHPONDHK = ProBuilderInstantiate.MLJIAFCGGAP.Prefab;
		}

		// Token: 0x06010DB5 RID: 69045 RVA: 0x0078BFD5 File Offset: 0x0078A1D5
		private void KIEFPGLDOCD()
		{
			this.KACEDALBFBK = GUI.Window(1, this.KACEDALBFBK, new GUI.WindowFunction(this.OAMNJCBDHCB), "GiantGrabIdle2");
		}

		// Token: 0x06010DB6 RID: 69046 RVA: 0x0078BFFC File Offset: 0x0078A1FC
		private void KDGEDIAKAGF(int LPFKFNLHGBI)
		{
			GUI.DragWindow(new Rect(1104f, 440f, 284f, 540f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 1; i++)
			{
				if (i == (int)this.IGPPHPONDHK)
				{
					GUI.color = Color.green;
				}
				ProBuilderInstantiate.MLJIAFCGGAP mljiafcggap = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				if (GUILayout.Button(mljiafcggap.ToString(), Array.Empty<GUILayoutOption>()))
				{
					this.IGPPHPONDHK = (ProBuilderInstantiate.MLJIAFCGGAP)i;
				}
				GUI.color = Color.white;
			}
			GUI.color = Color.red;
			if (GUILayout.Button("simple", Array.Empty<GUILayoutOption>()))
			{
				foreach (GameObject obj in this.JFNEDPMCDEP)
				{
					UnityEngine.Object.Destroy(obj);
				}
				this.JFNEDPMCDEP.Clear();
			}
			GUI.color = Color.white;
			GUILayout.Label("Screen Space Reflection", Array.Empty<GUILayoutOption>());
			GUILayout.EndVertical();
		}

		// Token: 0x06010DB7 RID: 69047 RVA: 0x0078C104 File Offset: 0x0078A304
		private void BCJFDHBDAHD()
		{
			this.KACEDALBFBK = GUI.Window(0, this.KACEDALBFBK, new GUI.WindowFunction(this.KDGEDIAKAGF), "offsets");
		}

		// Token: 0x04002340 RID: 9024
		public GameObject probuilderPrefab;

		// Token: 0x04002341 RID: 9025
		private const int JCDFBPOLPMD = 4;

		// Token: 0x04002342 RID: 9026
		private ProBuilderInstantiate.MLJIAFCGGAP IGPPHPONDHK;

		// Token: 0x04002343 RID: 9027
		private Rect KACEDALBFBK = new Rect(10f, 10f, 300f, 300f);

		// Token: 0x04002344 RID: 9028
		private List<GameObject> JFNEDPMCDEP = new List<GameObject>();

		// Token: 0x04002345 RID: 9029
		private Vector2 LMNGCLKJAPP = Vector2.zero;

		// Token: 0x020004DB RID: 1243
		private enum MLJIAFCGGAP
		{
			// Token: 0x04002347 RID: 9031
			Prefab,
			// Token: 0x04002348 RID: 9032
			Cube,
			// Token: 0x04002349 RID: 9033
			Cylinder,
			// Token: 0x0400234A RID: 9034
			Pipe
		}
	}
}
