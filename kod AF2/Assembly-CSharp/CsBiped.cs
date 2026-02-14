using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class CsBiped : MonoBehaviour
{
	// Token: 0x060009DA RID: 2522 RVA: 0x0005F890 File Offset: 0x0005DA90
	public void MEJFEPHDBHM(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 811f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.None;
		}
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x0005F984 File Offset: 0x0005DB84
	public void LMNHOELFJAP(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 500f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0005FA78 File Offset: 0x0005DC78
	public void LKBNCDMKEMA(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 758f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0005FBDC File Offset: 0x0005DDDC
	public void GFNFIKBAAGN(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 825f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.NotEditable;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0005FCD0 File Offset: 0x0005DED0
	public void HCIPHJGBPLF(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 873f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0005FDC4 File Offset: 0x0005DFC4
	public void GAPDDMGCNIO(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 794f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.HideInHierarchy;
		}
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0005FEB8 File Offset: 0x0005E0B8
	public void DFJNBFIFHOA(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 693f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.HideInHierarchy;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x0005FFAC File Offset: 0x0005E1AC
	public void ILOCCDABKDI(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1559f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j].hideFlags = HideFlags.None;
		}
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x000600A0 File Offset: 0x0005E2A0
	public void LNGHMMKDEBO(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 832f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00060194 File Offset: 0x0005E394
	public void PEOFNOEFBNM(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1544f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00060288 File Offset: 0x0005E488
	public void AGJBMAEBPIP(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 699f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0006037C File Offset: 0x0005E57C
	public void ICAFIMKPCPF(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1938f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j += 0)
		{
			array[j].hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00060470 File Offset: 0x0005E670
	public void IGCCNCJOFIE(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1648f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j].hideFlags = HideFlags.HideInInspector;
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00060564 File Offset: 0x0005E764
	public void OIDJPEECADN(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1719f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00060658 File Offset: 0x0005E858
	public void GDLPNHIMNHD(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1633f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j += 0)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0006074C File Offset: 0x0005E94C
	public void NIPDHBDJDAP(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1613f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j += 0)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00060840 File Offset: 0x0005EA40
	public void PHNABCIBNAF(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 189f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.DontSaveInEditor;
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00060934 File Offset: 0x0005EB34
	public void HOLHLADNENB(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 127f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00060A28 File Offset: 0x0005EC28
	public void HEMOINDOHIH(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1070f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.DontSaveInEditor;
		}
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00060B1C File Offset: 0x0005ED1C
	public void FindBones(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 0.45f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = HideFlags.HideInInspector;
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00060C10 File Offset: 0x0005EE10
	public void NMIHPKKLLEC(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 203f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j].hideFlags = HideFlags.None;
		}
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00060D04 File Offset: 0x0005EF04
	public void LLNLDJGPOJL(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 1822f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00060DF8 File Offset: 0x0005EFF8
	public void CKDMIAPPKIN(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 415f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00060EEC File Offset: 0x0005F0EC
	public void CKIFCONFCOB(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 39f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 0; j < array.Length; j++)
		{
			array[j].hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00060FE0 File Offset: 0x0005F1E0
	public void AMPCMHHLPHB(string KFNBLHIFFAP)
	{
		if (string.IsNullOrEmpty(KFNBLHIFFAP))
		{
			return;
		}
		this.colorBone = new Color(this.colorBone.r, this.colorBone.g, this.colorBone.b, 755f);
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		List<CsBipedBone> list = new List<CsBipedBone>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			if (componentsInChildren[i].gameObject.name.Contains(KFNBLHIFFAP))
			{
				CsBipedBone component = componentsInChildren[i].gameObject.GetComponent<CsBipedBone>();
				if (component == null)
				{
					list.Add(componentsInChildren[i].gameObject.AddComponent<CsBipedBone>());
				}
				else
				{
					list.Add(component);
				}
			}
		}
		this.bones = new CsBipedBone[list.Count];
		list.CopyTo(this.bones);
		CsBipedBone[] array = this.bones;
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j].hideFlags = HideFlags.HideInHierarchy;
		}
	}

	// Token: 0x04000132 RID: 306
	public Transform head;

	// Token: 0x04000133 RID: 307
	public Transform handLeft;

	// Token: 0x04000134 RID: 308
	public Transform handRight;

	// Token: 0x04000135 RID: 309
	public Transform footLeft;

	// Token: 0x04000136 RID: 310
	public Transform footRight;

	// Token: 0x04000137 RID: 311
	public CsBipedBone[] bones;

	// Token: 0x04000138 RID: 312
	public bool showBones = true;

	// Token: 0x04000139 RID: 313
	public Color colorBone = Color.Lerp(Color.black, Color.green, 0.7f);

	// Token: 0x0400013A RID: 314
	public Color colorSelected = Color.Lerp(Color.black, Color.cyan, 0.75f);

	// Token: 0x0400013B RID: 315
	public List<string> boneNamePrefix = new List<string>
	{
		"Bip",
		"Bone"
	};

	// Token: 0x0400013C RID: 316
	public bool foldout;
}
