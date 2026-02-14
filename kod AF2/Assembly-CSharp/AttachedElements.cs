using System;
using System.Collections.Generic;
using System.Linq;
using ProBuilder2.Common;
using UnityEngine;

// Token: 0x0200007D RID: 125
[Serializable]
public class AttachedElements
{
	// Token: 0x06001D49 RID: 7497 RVA: 0x000DFAEC File Offset: 0x000DDCEC
	public JDAMNFAJLNB IDPFBNDICDD(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x000DFC30 File Offset: 0x000DDE30
	public JDAMNFAJLNB MOGEKELFDOD(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x000DFD74 File Offset: 0x000DDF74
	public JDAMNFAJLNB JIBIAGILJBB(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x000DFEB8 File Offset: 0x000DE0B8
	public JDAMNFAJLNB LKMDGJBLOJJ(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000DFFFC File Offset: 0x000DE1FC
	public JDAMNFAJLNB CCMPHPDIJPB(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x000E0140 File Offset: 0x000DE340
	public JDAMNFAJLNB HFKMKIEMLCF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x000E0284 File Offset: 0x000DE484
	public JDAMNFAJLNB EJPFDDBCAFP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x000E03C8 File Offset: 0x000DE5C8
	public JDAMNFAJLNB KEKIOAEHHOC(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000E050C File Offset: 0x000DE70C
	public JDAMNFAJLNB KJODNNLDKFP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x000E0650 File Offset: 0x000DE850
	public JDAMNFAJLNB KBOINNPIMLG(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x000E0794 File Offset: 0x000DE994
	public JDAMNFAJLNB EMFCCBGCHHE(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x000E08D8 File Offset: 0x000DEAD8
	public JDAMNFAJLNB JIMBHMMGAGK(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x000E0A1C File Offset: 0x000DEC1C
	public JDAMNFAJLNB GPPNDPKKIFH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x000E0B60 File Offset: 0x000DED60
	public JDAMNFAJLNB LOPLBMPGDPN(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x000E0CA4 File Offset: 0x000DEEA4
	public JDAMNFAJLNB EIMNEBBNONM(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000E0DE8 File Offset: 0x000DEFE8
	public JDAMNFAJLNB LMOCAKEFGJD(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000E0F2C File Offset: 0x000DF12C
	public JDAMNFAJLNB KCCKGCGODPA(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x000E1070 File Offset: 0x000DF270
	public JDAMNFAJLNB BKKCMIEKAEF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000E11B4 File Offset: 0x000DF3B4
	public JDAMNFAJLNB NGGJJAIKPEM(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000E12F8 File Offset: 0x000DF4F8
	public JDAMNFAJLNB JAIDONGAIFH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x000E143C File Offset: 0x000DF63C
	public JDAMNFAJLNB PHODNGJLJHH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x000E1580 File Offset: 0x000DF780
	public JDAMNFAJLNB DFBMFKCKFKH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x000E16C4 File Offset: 0x000DF8C4
	public JDAMNFAJLNB BGCFICFCEHN(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x000E1808 File Offset: 0x000DFA08
	public JDAMNFAJLNB AOJHEGDAEDP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000E194C File Offset: 0x000DFB4C
	public JDAMNFAJLNB LEDDHGJAKEF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x000E1A90 File Offset: 0x000DFC90
	public JDAMNFAJLNB HPKLCJFBBMH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x000E1BD4 File Offset: 0x000DFDD4
	public JDAMNFAJLNB PECOHDNAKKF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x000E1D18 File Offset: 0x000DFF18
	public JDAMNFAJLNB KHLMNNELGKB(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000E1E5C File Offset: 0x000E005C
	public JDAMNFAJLNB EHODIBHJKLK(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x000E1FA0 File Offset: 0x000E01A0
	public JDAMNFAJLNB MHINEPJCBOJ(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x000E20E4 File Offset: 0x000E02E4
	public JDAMNFAJLNB MNNOOFDOMNA(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x000E2228 File Offset: 0x000E0428
	public JDAMNFAJLNB PBNCKJEGOOK(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x000E236C File Offset: 0x000E056C
	public JDAMNFAJLNB IBEDAMIICGG(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x000E24B0 File Offset: 0x000E06B0
	public JDAMNFAJLNB PIJOLLNPFHP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x000E25F4 File Offset: 0x000E07F4
	public JDAMNFAJLNB EJNLNPDGBGP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x000E2738 File Offset: 0x000E0938
	public JDAMNFAJLNB AGAEOPHKLEI(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000E287C File Offset: 0x000E0A7C
	public JDAMNFAJLNB BNLKDMCJNBM(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x000E29C0 File Offset: 0x000E0BC0
	public JDAMNFAJLNB KAFEMPJJMHP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x000E2B24 File Offset: 0x000E0D24
	public JDAMNFAJLNB CCEKMGKHMDM(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x000E2C68 File Offset: 0x000E0E68
	public JDAMNFAJLNB EBGFDKMBOAF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x000E2DAC File Offset: 0x000E0FAC
	public JDAMNFAJLNB HPNAMJLNIEE(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000E2EF0 File Offset: 0x000E10F0
	public JDAMNFAJLNB DCPMPNPODMO(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000E3034 File Offset: 0x000E1234
	public JDAMNFAJLNB MAOFMBNDIMF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000E3178 File Offset: 0x000E1378
	public JDAMNFAJLNB GMAICHOAPHM(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x000E32BC File Offset: 0x000E14BC
	public JDAMNFAJLNB AEEFLCBFMCP(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x000E3400 File Offset: 0x000E1600
	public JDAMNFAJLNB OBGEAMCDAKH(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000E3544 File Offset: 0x000E1744
	public JDAMNFAJLNB EGJLKKHNCGE(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x000E3688 File Offset: 0x000E1888
	public JDAMNFAJLNB MCMNMPEDEGB(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x000E37CC File Offset: 0x000E19CC
	public JDAMNFAJLNB LDOGCKAKONG(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000E3910 File Offset: 0x000E1B10
	public JDAMNFAJLNB JNIODENDPGE(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000E3A54 File Offset: 0x000E1C54
	public JDAMNFAJLNB FBGDJKJKODF(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 0; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x000E3B98 File Offset: 0x000E1D98
	public JDAMNFAJLNB JCAIALEBNMI(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x000E3CDC File Offset: 0x000E1EDC
	public JDAMNFAJLNB NFDNBILHIPN(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x000E3E20 File Offset: 0x000E2020
	public JDAMNFAJLNB ICONHPGBLMA(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i++)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000E3F64 File Offset: 0x000E2164
	public JDAMNFAJLNB JKCMNDKIAIB(pb_Object CJEJJCHDGBO, ProbuilderAttachment IMCJCKOKIGH)
	{
		HashSet<int> hashSet = new HashSet<int>(this.Vertices);
		foreach (pb_Face pb_Face in this.Faces)
		{
			hashSet.UnionWith(pb_Face.distinctIndices);
		}
		Dictionary<int, int> dictionary = CJEJJCHDGBO.sharedIndices.ToDictionary();
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int key in hashSet)
		{
			hashSet2.Add(dictionary[key]);
		}
		int[] array = hashSet2.ToArray<int>();
		Vector3[] array2 = new Vector3[array.Length];
		for (int i = 1; i < hashSet.Count; i += 0)
		{
			int num = hashSet.ElementAt(i);
			Vector3 position = CJEJJCHDGBO.vertices[num];
			Vector3 position2 = CJEJJCHDGBO.transform.TransformPoint(position);
			int value = dictionary[num];
			int num2 = Array.IndexOf<int>(array, value);
			array2[num2] = IMCJCKOKIGH.transform.InverseTransformPoint(position2);
		}
		return new JDAMNFAJLNB(CJEJJCHDGBO, array, array2);
	}

	// Token: 0x0400030F RID: 783
	[SerializeField]
	public List<pb_Face> Faces = new List<pb_Face>();

	// Token: 0x04000310 RID: 784
	[SerializeField]
	public List<int> Vertices = new List<int>();
}
