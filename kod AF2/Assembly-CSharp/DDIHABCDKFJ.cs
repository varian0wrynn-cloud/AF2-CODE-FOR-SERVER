using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valkyrie.VPaint;

// Token: 0x020003BD RID: 957
public static class DDIHABCDKFJ
{
	// Token: 0x0600CE17 RID: 52759 RVA: 0x005CF52C File Offset: 0x005CD72C
	public static void PGPFGNEPHEN(Color[] JONJODLFAEN, float[] HNLDKDPFBCJ, Color[] FFGIAHPIPEK, float[] GBKKBFHMFCP, PAGGHFEKABD NJAADJLECIB, float JPGJOLLIGPJ, bool JGMKADJKGDB, bool FKEBFDKIGNO, bool HMABFGAJOFP, bool PJNNEIBBGFB)
	{
		if (JONJODLFAEN.Length != FFGIAHPIPEK.Length)
		{
			return;
		}
		for (int i = 0; i < JONJODLFAEN.Length; i++)
		{
			Color color = JONJODLFAEN[i];
			Color color2 = color;
			Color color3 = FFGIAHPIPEK[i];
			float num = Mathf.Clamp01(GBKKBFHMFCP[i] * JPGJOLLIGPJ);
			switch (NJAADJLECIB)
			{
			case PAGGHFEKABD.Opaque:
				color2 = color3;
				break;
			case PAGGHFEKABD.Additive:
				color2 = color + color3;
				break;
			case PAGGHFEKABD.Multiply:
				color2 = color * color3;
				break;
			case PAGGHFEKABD.Overlay:
				color2 = color * color3 * 2f;
				break;
			}
			color2 = Color.Lerp(color, color2, num);
			if (JGMKADJKGDB)
			{
				color.r = color2.r;
			}
			if (FKEBFDKIGNO)
			{
				color.g = color2.g;
			}
			if (HMABFGAJOFP)
			{
				color.b = color2.b;
			}
			if (PJNNEIBBGFB)
			{
				color.a = color2.a;
			}
			JONJODLFAEN[i] = color;
			HNLDKDPFBCJ[i] = Mathf.Clamp01(HNLDKDPFBCJ[i] + num);
		}
	}

	// Token: 0x0600CE18 RID: 52760 RVA: 0x005CF61C File Offset: 0x005CD81C
	public static void JMINHCNIHKB(VPaintLayer[] EAKLJEJNCBK, VPaintObject[] PAOJMKNCFAJ, VPaintObject[] ECDCHGDIGOA, float AEIAFIIMHEL, float INAEHEBPLNN = 1f, Bounds? DDCAPDEHFGC = null)
	{
		IEnumerator<FGEFHILBFDO> enumerator = DDIHABCDKFJ.GHNNBJNOILH(EAKLJEJNCBK, PAOJMKNCFAJ, ECDCHGDIGOA, AEIAFIIMHEL, INAEHEBPLNN, DDCAPDEHFGC);
		while (enumerator.MoveNext())
		{
		}
	}

	// Token: 0x0600CE19 RID: 52761 RVA: 0x005CF63F File Offset: 0x005CD83F
	public static IEnumerator<FGEFHILBFDO> GHNNBJNOILH(VPaintLayer[] EAKLJEJNCBK, VPaintObject[] PAOJMKNCFAJ, VPaintObject[] ECDCHGDIGOA, float AEIAFIIMHEL, float INAEHEBPLNN = 1f, Bounds? DDCAPDEHFGC = null)
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in ECDCHGDIGOA)
		{
			if (Application.isPlaying && !vpaintObject.OHEEAEDJCCC)
			{
				throw new BDGOJDPFENN();
			}
			if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Intersects(vpaintObject.editorCollider.bounds))
			{
				list.Add(vpaintObject);
			}
		}
		int i;
		for (int j = 0; j < EAKLJEJNCBK.Length; j = i + 1)
		{
			VPaintLayer vpaintLayer = EAKLJEJNCBK[j];
			for (int k = 0; k < PAOJMKNCFAJ.Length; k = i + 1)
			{
				VPaintObject vpaintObject2 = PAOJMKNCFAJ[k];
				yield return new FGEFHILBFDO
				{
					EDAPHMJENPK = "Blending " + vpaintObject2.name + " on layer " + vpaintLayer.name,
					DGPGACBMECK = (float)k / (float)PAOJMKNCFAJ.Length
				};
				Vector3[] vertices = vpaintObject2.GetMeshInstance().vertices;
				VPaintVertexData vpaintVertexData = vpaintLayer.HEFDMJLBHOB(vpaintObject2);
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				Transform transform = vpaintObject2.transform;
				Vector4[] array = new Vector4[colors.Length];
				float[] array2 = new float[transparency.Length];
				float[] array3 = new float[transparency.Length];
				float[] array4 = new float[transparency.Length];
				float[] array5 = new float[transparency.Length];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = AEIAFIIMHEL;
				}
				for (int m = 0; m < list.Count; m++)
				{
					VPaintObject vpaintObject3 = list[m];
					VPaintVertexData vpaintVertexData2 = vpaintLayer.HEFDMJLBHOB(vpaintObject3);
					if (vpaintVertexData2 != null)
					{
						Vector3[] vertices2 = vpaintObject3.GetMeshInstance().vertices;
						Color[] colors2 = vpaintVertexData2.colors;
						float[] transparency2 = vpaintVertexData2.transparency;
						Transform transform2 = vpaintObject3.transform;
						for (int n = 0; n < vertices.Length; n++)
						{
							Vector4 vector = Vector4.zero;
							float num = 0f;
							float b = AEIAFIIMHEL;
							float num2 = 0f;
							int num3 = 0;
							Vector3 a = transform.TransformPoint(vertices[n]);
							for (int num4 = 0; num4 < vertices2.Length; num4++)
							{
								Vector3 vector2 = transform2.TransformPoint(vertices2[num4]);
								if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Contains(vector2))
								{
									float num5 = Vector3.Distance(a, vector2);
									if (AEIAFIIMHEL >= num5)
									{
										float num6 = 1f - num5 / AEIAFIIMHEL;
										num2 += num6;
										vector += colors2[num4] * num6;
										num += transparency2[num4] * num6;
										num3++;
										b = Mathf.Min(num5, b);
									}
								}
							}
							array[n] += vector;
							array2[n] += num;
							array3[n] += num2;
							array5[n] += (float)num3;
							array4[n] = Mathf.Min(array4[n], b);
						}
					}
				}
				for (int num7 = 0; num7 < colors.Length; num7++)
				{
					float num8 = array3[num7];
					Color b2 = (num8 == 0f) ? default(Color) : (array[num7] / num8);
					float b3 = (num8 == 0f) ? 0f : (array2[num7] / num8);
					float num9 = (array5[num7] == 0f) ? 0f : (1f - array4[num7] / AEIAFIIMHEL);
					num9 *= INAEHEBPLNN;
					vpaintVertexData.colors[num7] = Color.Lerp(vpaintVertexData.colors[num7], b2, num9);
					vpaintVertexData.transparency[num7] = Mathf.Lerp(vpaintVertexData.transparency[num7], b3, num9);
				}
				vpaintObject2 = null;
				i = k;
			}
			vpaintLayer = null;
			i = j;
		}
		yield break;
	}

	// Token: 0x0600CE1A RID: 52762 RVA: 0x005CF674 File Offset: 0x005CD874
	public static void IGFHNKHNGMN(VPaintLayer[] EAKLJEJNCBK, VPaintObject[] PAOJMKNCFAJ, VPaintObject[] ECDCHGDIGOA, Vector3 NEMFIHCKJPE, float DKIHDOELFEH, float INAEHEBPLNN = 1f, float DIPMPDKHGNI = 1f, Vector3? IGFJOGKFADM = null, Bounds? DDCAPDEHFGC = null)
	{
		IEnumerator<FGEFHILBFDO> enumerator = DDIHABCDKFJ.AJAAMJGJANN(EAKLJEJNCBK, PAOJMKNCFAJ, ECDCHGDIGOA, NEMFIHCKJPE, DKIHDOELFEH, INAEHEBPLNN, DIPMPDKHGNI, IGFJOGKFADM, DDCAPDEHFGC);
		while (enumerator.MoveNext())
		{
		}
	}

	// Token: 0x0600CE1B RID: 52763 RVA: 0x005CF6A0 File Offset: 0x005CD8A0
	public static IEnumerator<FGEFHILBFDO> AJAAMJGJANN(VPaintLayer[] EAKLJEJNCBK, VPaintObject[] PAOJMKNCFAJ, VPaintObject[] ECDCHGDIGOA, Vector3 NEMFIHCKJPE, float DKIHDOELFEH, float INAEHEBPLNN = 1f, float DIPMPDKHGNI = 1f, Vector3? IGFJOGKFADM = null, Bounds? DDCAPDEHFGC = null)
	{
		if (IGFJOGKFADM == null)
		{
			IGFJOGKFADM = new Vector3?(Vector3.zero);
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in ECDCHGDIGOA)
		{
			if (Application.isPlaying && !vpaintObject.OHEEAEDJCCC)
			{
				throw new BDGOJDPFENN();
			}
			if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Intersects(vpaintObject.editorCollider.bounds))
			{
				list.Add(vpaintObject);
			}
		}
		int i;
		for (int j = 0; j < EAKLJEJNCBK.Length; j = i + 1)
		{
			VPaintLayer vpaintLayer = EAKLJEJNCBK[j];
			for (int k = 0; k < PAOJMKNCFAJ.Length; k = i + 1)
			{
				VPaintObject vpaintObject2 = PAOJMKNCFAJ[k];
				string edaphmjenpk = "Blending " + vpaintObject2.name + " on layer " + vpaintLayer.name;
				float num = (float)k / (float)PAOJMKNCFAJ.Length;
				float num2 = ((float)(k + 1) / (float)PAOJMKNCFAJ.Length - num) / 1f;
				Mesh meshInstance = vpaintObject2.GetMeshInstance();
				Vector3[] array = meshInstance.vertices;
				VPaintVertexData vpaintVertexData = vpaintLayer.HEFDMJLBHOB(vpaintObject2);
				Color[] array2 = vpaintVertexData.colors;
				float[] array3 = vpaintVertexData.transparency;
				Transform transform = vpaintObject2.transform;
				float magnitude = IGFJOGKFADM.Value.magnitude;
				for (int l = 0; l < array.Length; l = i + 1)
				{
					yield return new FGEFHILBFDO
					{
						EDAPHMJENPK = edaphmjenpk,
						DGPGACBMECK = num + num2 * (float)l / (float)array.Length
					};
					Vector3 vector = transform.TransformPoint(array[l]);
					if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Contains(vector))
					{
						Vector4 a = Vector4.zero;
						float num3 = 0f;
						float num4 = 0f;
						float num5 = 0f;
						foreach (VPaintObject vpaintObject3 in list)
						{
							Collider editorCollider = vpaintObject3.editorCollider;
							Ray ray = new Ray(vector + IGFJOGKFADM.Value, NEMFIHCKJPE);
							RaycastHit raycastHit;
							if (editorCollider.Raycast(ray, out raycastHit, DKIHDOELFEH) && (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Contains(raycastHit.point)))
							{
								Mesh meshInstance2 = vpaintObject3.GetMeshInstance();
								if (meshInstance2)
								{
									int[] triangles = meshInstance2.triangles;
									VPaintVertexData vpaintVertexData2 = vpaintLayer.HEFDMJLBHOB(vpaintObject3);
									int num6 = triangles[raycastHit.triangleIndex * 3];
									int num7 = triangles[raycastHit.triangleIndex * 3 + 1];
									int num8 = triangles[raycastHit.triangleIndex * 3 + 2];
									Color a2 = vpaintVertexData2.colors[num6];
									Color a3 = vpaintVertexData2.colors[num7];
									Color a4 = vpaintVertexData2.colors[num8];
									float num9 = vpaintVertexData2.transparency[num6];
									float num10 = vpaintVertexData2.transparency[num7];
									float num11 = vpaintVertexData2.transparency[num8];
									Vector3 barycentricCoordinate = raycastHit.barycentricCoordinate;
									Color c = a2 * barycentricCoordinate.x + a3 * barycentricCoordinate.y + a4 * barycentricCoordinate.z;
									float num12 = num9 * barycentricCoordinate.x + num10 * barycentricCoordinate.y + num11 * barycentricCoordinate.z;
									float num13 = Mathf.Pow(1f - (raycastHit.distance - magnitude) / DKIHDOELFEH, DIPMPDKHGNI);
									num4 += num13;
									num3 += num12 * num13;
									a += c * num13;
									num5 += 1f;
								}
							}
						}
						Color b = a / num4;
						float b2 = num3 / num4;
						if (num4 != 0f)
						{
							float t = INAEHEBPLNN * (num4 / num5);
							array2[l] = Color.Lerp(array2[l], b, t);
							array3[l] = Mathf.Lerp(array3[l], b2, t);
						}
					}
					i = l;
				}
				edaphmjenpk = null;
				array = null;
				array2 = null;
				array3 = null;
				transform = null;
				i = k;
			}
			vpaintLayer = null;
			i = j;
		}
		yield break;
	}

	// Token: 0x0600CE1C RID: 52764 RVA: 0x005CF6F7 File Offset: 0x005CD8F7
	public static IEnumerator AMODCAPHGAJ(VPaintObject MBKPMBPLIJN, Color[] NAHDPCPAPBO, Color[] HCNBHACCJHE, float GDNOKEOLBPP)
	{
		float num = 0f;
		int num2 = NAHDPCPAPBO.Length;
		Color[] array = new Color[num2];
		while (num < GDNOKEOLBPP)
		{
			float t = num / GDNOKEOLBPP;
			for (int i = 0; i < num2; i++)
			{
				array[i] = Color.Lerp(NAHDPCPAPBO[i], HCNBHACCJHE[i], t);
			}
			MBKPMBPLIJN.SetColors(array);
			yield return null;
			num += Time.deltaTime;
		}
		MBKPMBPLIJN.SetColors(HCNBHACCJHE);
		yield break;
	}

	// Token: 0x0600CE1D RID: 52765 RVA: 0x005CF71C File Offset: 0x005CD91C
	public static VPaintLayer KGPFBIAJNOB(VPaintObject[] POKPFBOIAOD, float AEIAFIIMHEL, float INAEHEBPLNN, int EDADEJBEFNH, Color GCNIEKJOLNL, Color MFIHIKDAFGC, Bounds? DDCAPDEHFGC = null)
	{
		IEnumerator<GAABGMJMIEF> enumerator = DDIHABCDKFJ.FKFENNILGKP(POKPFBOIAOD, AEIAFIIMHEL, INAEHEBPLNN, EDADEJBEFNH, GCNIEKJOLNL, MFIHIKDAFGC, DDCAPDEHFGC);
		while (enumerator.MoveNext())
		{
		}
		return enumerator.Current.ABKNBDJHBCM;
	}

	// Token: 0x0600CE1E RID: 52766 RVA: 0x005CF74C File Offset: 0x005CD94C
	public static IEnumerator<GAABGMJMIEF> FKFENNILGKP(VPaintObject[] POKPFBOIAOD, float AEIAFIIMHEL, float INAEHEBPLNN, int EDADEJBEFNH, Color GCNIEKJOLNL, Color MFIHIKDAFGC, Bounds? DDCAPDEHFGC = null)
	{
		VPaintLayer vpaintLayer = new VPaintLayer();
		List<VPaintObject> list = new List<VPaintObject>();
		int j;
		for (int i = 0; i < POKPFBOIAOD.Length; i = j + 1)
		{
			VPaintObject vpaintObject = POKPFBOIAOD[i];
			Bounds bounds = vpaintObject.GetBounds();
			bounds.Expand(AEIAFIIMHEL);
			if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Intersects(bounds))
			{
				Mesh mesh = vpaintObject.GetMeshInstance();
				Vector3[] array = mesh.vertices;
				Vector3[] array2 = mesh.normals;
				Vector3[] normals = mesh.normals;
				if (array2.Length != array.Length)
				{
					mesh.RecalculateNormals();
					array2 = mesh.normals;
				}
				Color[] array3 = new Color[array.Length];
				list.Clear();
				foreach (VPaintObject vpaintObject2 in POKPFBOIAOD)
				{
					if ((!Application.isPlaying || vpaintObject2.OHEEAEDJCCC) && bounds.Intersects(vpaintObject2.GetBounds()))
					{
						list.Add(vpaintObject2);
					}
				}
				string text = "Sampling AO on " + vpaintObject.name + " for vert ";
				for (int k = 0; k < array.Length; k = j + 1)
				{
					Vector3 vector = array[k];
					Vector3 vector2 = vpaintObject.transform.TransformPoint(vector);
					if (DDCAPDEHFGC == null || DDCAPDEHFGC.Value.Contains(vector2))
					{
						Vector3 b = array2[k];
						Vector3 normalized = (vpaintObject.transform.TransformPoint(vector + b) - vector2).normalized;
						float num = 0f;
						for (int l = 0; l < EDADEJBEFNH; l++)
						{
							Vector3 vector3 = Quaternion.FromToRotation(Vector3.up, normalized) * Quaternion.Euler(UnityEngine.Random.Range(-90f, 90f), UnityEngine.Random.Range(-90f, 90f), UnityEngine.Random.Range(-90f, 90f)) * Vector3.up;
							Vector3 a = Vector3.Reflect(vector3, normalized);
							vector3 *= AEIAFIIMHEL / vector3.magnitude;
							Ray ray = new Ray(vector2 - a * 0.1f, vector3);
							RaycastHit raycastHit = default(RaycastHit);
							raycastHit.distance = float.PositiveInfinity;
							bool flag = false;
							using (List<VPaintObject>.Enumerator enumerator = list.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									RaycastHit raycastHit2;
									if (enumerator.Current.editorCollider.Raycast(ray, out raycastHit2, AEIAFIIMHEL) && raycastHit2.distance < raycastHit.distance)
									{
										raycastHit = raycastHit2;
										flag = true;
									}
								}
							}
							if (flag)
							{
								num += Mathf.Clamp01(1f - raycastHit.distance / AEIAFIIMHEL);
							}
						}
						num = Mathf.Clamp01(1f - num * INAEHEBPLNN / (float)EDADEJBEFNH);
						array3[k] = Color.Lerp(GCNIEKJOLNL, MFIHIKDAFGC, num);
						if (k % 10 == 0)
						{
							yield return new GAABGMJMIEF
							{
								DGPGACBMECK = (float)k / (float)array.Length,
								EDAPHMJENPK = string.Concat(new object[]
								{
									text,
									k,
									"/",
									array.Length
								}),
								ABKNBDJHBCM = null
							};
						}
					}
					j = k;
				}
				VPaintVertexData vpaintVertexData = vpaintLayer.HEFDMJLBHOB(vpaintObject);
				vpaintVertexData.colors = array3;
				vpaintVertexData.transparency = new float[vpaintVertexData.colors.Length];
				for (int m = 0; m < vpaintVertexData.transparency.Length; m++)
				{
					vpaintVertexData.transparency[m] = 1f;
				}
				mesh.normals = normals;
				vpaintObject = null;
				mesh = null;
				array = null;
				array2 = null;
				normals = null;
				array3 = null;
				text = null;
			}
			j = i;
		}
		yield return new GAABGMJMIEF
		{
			DGPGACBMECK = 1f,
			EDAPHMJENPK = "Finished",
			ABKNBDJHBCM = vpaintLayer
		};
		yield break;
	}
}
