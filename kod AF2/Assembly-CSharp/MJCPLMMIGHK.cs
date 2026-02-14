using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200028C RID: 652
public static class MJCPLMMIGHK
{
	// Token: 0x060098E4 RID: 39140 RVA: 0x004435FE File Offset: 0x004417FE
	public static List<GameObject> DDOGNNEOFIL(GameObject MBKPMBPLIJN, Transform EELDHNFBFOE)
	{
		return MJCPLMMIGHK.DDOGNNEOFIL(MBKPMBPLIJN, EELDHNFBFOE, true);
	}

	// Token: 0x060098E5 RID: 39141 RVA: 0x00443608 File Offset: 0x00441808
	public static List<GameObject> DDOGNNEOFIL(GameObject MBKPMBPLIJN, Transform EELDHNFBFOE, bool KFFAHFPBBMB)
	{
		List<GameObject> list = new List<GameObject>();
		if (MBKPMBPLIJN == null)
		{
			return null;
		}
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in MBKPMBPLIJN.GetComponentsInChildren<SkinnedMeshRenderer>())
		{
			skinnedMeshRenderer.rootBone = EELDHNFBFOE;
			GameObject gameObject = MJCPLMMIGHK.NAJHFNGDFDP(skinnedMeshRenderer, EELDHNFBFOE);
			gameObject.tag = skinnedMeshRenderer.gameObject.tag;
			list.Add(gameObject);
		}
		if (KFFAHFPBBMB)
		{
			MBKPMBPLIJN.SetActive(false);
		}
		return list;
	}

	// Token: 0x060098E6 RID: 39142 RVA: 0x00443674 File Offset: 0x00441874
	private static GameObject NAJHFNGDFDP(SkinnedMeshRenderer GALBHMANJDG, Transform EELDHNFBFOE)
	{
		GameObject gameObject = new GameObject(GALBHMANJDG.gameObject.name);
		gameObject.transform.parent = EELDHNFBFOE;
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer;
		Transform[] array = new Transform[GALBHMANJDG.bones.Length];
		for (int i = 0; i < GALBHMANJDG.bones.Length; i++)
		{
			if (EELDHNFBFOE == null)
			{
				Debug.Log("root is null");
			}
			if (GALBHMANJDG.bones[i] == null)
			{
				Debug.Log("ThisRenderer.bones[i] is null i=" + i);
			}
			if (GALBHMANJDG.bones[i].name == null)
			{
				Debug.Log("ThisRenderer.bones[i].name is null");
			}
			if (GALBHMANJDG.bones[i] != null)
			{
				array[i] = MJCPLMMIGHK.HJKKJLBCFID(GALBHMANJDG.bones[i].name, EELDHNFBFOE);
			}
		}
		skinnedMeshRenderer.bones = array;
		skinnedMeshRenderer.sharedMesh = GALBHMANJDG.sharedMesh;
		skinnedMeshRenderer.materials = GALBHMANJDG.materials;
		return gameObject;
	}

	// Token: 0x060098E7 RID: 39143 RVA: 0x00443770 File Offset: 0x00441970
	private static Transform HJKKJLBCFID(string LDAGPOIJNFK, Transform HCCDBPAMBFG)
	{
		if (HCCDBPAMBFG.name == LDAGPOIJNFK)
		{
			return HCCDBPAMBFG.transform;
		}
		foreach (object obj in HCCDBPAMBFG)
		{
			Transform hccdbpambfg = (Transform)obj;
			Transform transform = MJCPLMMIGHK.HJKKJLBCFID(LDAGPOIJNFK, hccdbpambfg);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}
}
