using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class AI_Range : MonoBehaviour
{
	// Token: 0x06000648 RID: 1608 RVA: 0x000412C4 File Offset: 0x0003F4C4
	public string[] ObjectInZoneSimple_JS(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x0004136C File Offset: 0x0003F56C
	public string[] IIPIKFJLDFC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.CEGJLILKPEB(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00041414 File Offset: 0x0003F614
	public void IMIFFDEPEKL()
	{
		string name = "fider_Medium_";
		Type[] array = new Type[0];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "_MainTex" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0004154C File Offset: 0x0003F74C
	public List<string> DJNCNDOFEAN(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.JLOHLOFDKKL(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000415F0 File Offset: 0x0003F7F0
	public void OBPMOKDGBKC()
	{
		string name = "shop_t5";
		Type[] array = new Type[1];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "__Refraction" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00041728 File Offset: 0x0003F928
	private bool JJMCJNHFCGK(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.CEGJLILKPEB(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.NGDLPJECNOH(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00041790 File Offset: 0x0003F990
	public string[] FKGLIAADBEA(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00041834 File Offset: 0x0003FA34
	public List<string> PMFFMJJJCPF(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.FJIDOFFCJPI(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000418D4 File Offset: 0x0003FAD4
	public string[] EIFKHAFBAFA(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00041978 File Offset: 0x0003FB78
	public string[] NCICFGKMPOB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.AOLENHHFMPP(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00041A1C File Offset: 0x0003FC1C
	public List<string> LNOAAKEMKOJ(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.ECPEABPIKOH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00041ABC File Offset: 0x0003FCBC
	private bool LAEFIPIJBBN(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 1385f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00041BF0 File Offset: 0x0003FDF0
	public List<string> GIGFOBJAJEN(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.AOLENHHFMPP(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00041C90 File Offset: 0x0003FE90
	public string[] CHFHLCBCAHC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.NGDLPJECNOH(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00041D38 File Offset: 0x0003FF38
	private bool OPDIOBPKMLG(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.NFFBBJHLBFE(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.PBADJJJMPIP(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00041DA0 File Offset: 0x0003FFA0
	private bool KMOGJCHLHNJ(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.LAEFIPIJBBN(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00041E08 File Offset: 0x00040008
	public void AGHNOKKPICA()
	{
		string name = "34";
		Type[] array = new Type[0];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "Jump" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00041F40 File Offset: 0x00040140
	public string[] LHKALHANIIE(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KIAHIDJACCF(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00041FE8 File Offset: 0x000401E8
	public string[] INDDLOPLHHI(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.JLOHLOFDKKL(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00042090 File Offset: 0x00040290
	public string[] KAKCMDMJPME(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.EHCOJLCADNE(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00042138 File Offset: 0x00040338
	private bool AGBIJKCFOAG(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.MEKNNPABKLA(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.OHPGEFILMML(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x000421A0 File Offset: 0x000403A0
	public List<string> NCGDKEOAOOH(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KBCMLCBLMDM(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00042240 File Offset: 0x00040440
	private bool JLOHLOFDKKL(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 1990f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00042374 File Offset: 0x00040574
	private bool CNAFFBCKFHN(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.LAEFIPIJBBN(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x000423DC File Offset: 0x000405DC
	private bool HGAGCBCNGBO(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.OLIFCALEPBO(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.KIAHIDJACCF(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00042444 File Offset: 0x00040644
	public List<string> OGMGFONFNMM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.CNAFFBCKFHN(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x000424E4 File Offset: 0x000406E4
	public List<string> EEGHCGPFDEB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KELAKAMMEDP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00042588 File Offset: 0x00040788
	private bool KBCMLCBLMDM(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.LAEFIPIJBBN(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.MEKNNPABKLA(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x000425F0 File Offset: 0x000407F0
	public string[] JHHLFADIPLN(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00042694 File Offset: 0x00040894
	public List<string> IIPEMAFPKEE(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.PGJAAIJIDMJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00042734 File Offset: 0x00040934
	public void HEGKOJOBMKB()
	{
		string name = "OfficeSittingReading";
		Type[] array = new Type[1];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "StrafeRunLeft" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0004286C File Offset: 0x00040A6C
	public string[] AOBBPBODDII(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.HGAGCBCNGBO(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00042910 File Offset: 0x00040B10
	private bool CEGJLILKPEB(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 30f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00042A44 File Offset: 0x00040C44
	public void EKGALFLNNJI()
	{
		string name = "Fonts/";
		Type[] array = new Type[0];
		array[0] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "post_9" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00042B7C File Offset: 0x00040D7C
	public void JBDPEDCECME()
	{
		Transform transform = new GameObject("Blending ", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "BackPackSearch" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00042CB4 File Offset: 0x00040EB4
	private bool KIAHIDJACCF(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 1395f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00042DE8 File Offset: 0x00040FE8
	public void PJIDONAODMB()
	{
		Transform transform = new GameObject("wgt_gr", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "crft_to" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00042F20 File Offset: 0x00041120
	public List<string> ODPNNCJMMGL(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.IDPKNPHBIOK(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00042FC0 File Offset: 0x000411C0
	public List<string> INDAFKFLIHH(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.FJIDOFFCJPI(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00043060 File Offset: 0x00041260
	public List<string> IGFAFECHCLP(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KCKNBJMPGAH(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00043104 File Offset: 0x00041304
	public string[] LOPDCHIJGMM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.MIDKAGFENPJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x000431A8 File Offset: 0x000413A8
	private bool PIMODJGNMPI(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 652f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x000432DC File Offset: 0x000414DC
	public List<string> ObjectInZoneSimple(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00043380 File Offset: 0x00041580
	private bool KCKNBJMPGAH(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 1198f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000434B4 File Offset: 0x000416B4
	public string[] PJDPDHHAIKD(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.OLIFCALEPBO(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0004355C File Offset: 0x0004175C
	public string[] ICJOCIPCIMF(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.MNNLOLFEJFN(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00043600 File Offset: 0x00041800
	public List<string> ObjectInZoneBoxed(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000436A0 File Offset: 0x000418A0
	public List<string> PGJJLDGOFID(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.LONHAMGIOLC(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00043744 File Offset: 0x00041944
	public List<string> BHBKCMDBONO(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000437E8 File Offset: 0x000419E8
	public string[] AJHGNOAKAAE(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.LAEFIPIJBBN(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00043890 File Offset: 0x00041A90
	public List<string> ICEPOPPBLHP(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.MEKNNPABKLA(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00043934 File Offset: 0x00041B34
	public void FELMGOMNBEJ()
	{
		string name = "Mouse X";
		Type[] array = new Type[0];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "MotorbikeShootRight" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00043A6C File Offset: 0x00041C6C
	private bool OHPGEFILMML(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 891f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00043BA0 File Offset: 0x00041DA0
	private bool LONHAMGIOLC(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 889f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00043CD4 File Offset: 0x00041ED4
	private bool AJNELEFCBHC(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.FOBODOPMCBF(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00043D3C File Offset: 0x00041F3C
	public string[] IKGDJHCEJIJ(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.FOBODOPMCBF(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00043DE4 File Offset: 0x00041FE4
	public List<string> HFFODIMCHDB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00043E88 File Offset: 0x00042088
	public List<string> AKHMGKJLIIM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.AGBIJKCFOAG(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00043F28 File Offset: 0x00042128
	public string[] ObjectInZoneBoxed_JS(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00043FCC File Offset: 0x000421CC
	public void MEGPLBMOCOI()
	{
		string name = "GestureCutThroat";
		Type[] array = new Type[1];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "FistPump2" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00044104 File Offset: 0x00042304
	public void JHPJKBLKELL()
	{
		string name = "IdleDie2";
		Type[] array = new Type[1];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "fider drop" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x0004423C File Offset: 0x0004243C
	public List<string> LBGLOCDGACB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.CNAFFBCKFHN(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000442DC File Offset: 0x000424DC
	private bool KELAKAMMEDP(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 114f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00044410 File Offset: 0x00042610
	private bool NGDLPJECNOH(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 67f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00044544 File Offset: 0x00042744
	private bool IDPKNPHBIOK(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.NFFBBJHLBFE(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x000445AC File Offset: 0x000427AC
	public List<string> MHMDEDHNPOC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.CCMCGGEGFNE(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0004464C File Offset: 0x0004284C
	private bool BIBLKMMCMMH(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x000446B4 File Offset: 0x000428B4
	private bool MIDKAGFENPJ(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.DEJMHGLKKFP(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.LBBFDOGJKGC(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0004471C File Offset: 0x0004291C
	public List<string> ELFHNKGOKCN(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KIAHIDJACCF(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x000447C0 File Offset: 0x000429C0
	public void OOGLABBHNBE()
	{
		Transform transform = new GameObject("Quaternion: ", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x000448F8 File Offset: 0x00042AF8
	private bool JGKPKALCKPN(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.PIMODJGNMPI(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.FOBODOPMCBF(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00044960 File Offset: 0x00042B60
	public List<string> JOCCMHOPBIM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.FJIDOFFCJPI(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00044A00 File Offset: 0x00042C00
	public List<string> IDHGBNCPJIC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KELAKAMMEDP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00044AA4 File Offset: 0x00042CA4
	public string[] HCOLMKNCBIB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.PGJAAIJIDMJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00044B48 File Offset: 0x00042D48
	private bool CCMCGGEGFNE(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.LBBFDOGJKGC(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00044BB0 File Offset: 0x00042DB0
	public string[] NPHLGGEIJBD(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KMOGJCHLHNJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00044C54 File Offset: 0x00042E54
	private bool ECPEABPIKOH(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.OHPGEFILMML(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.KELAKAMMEDP(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00044CBC File Offset: 0x00042EBC
	public string[] IODOLFGDHCL(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00044D64 File Offset: 0x00042F64
	public void CreateMarker()
	{
		Transform transform = new GameObject("RangeMarker", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "Zone " + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00044E9C File Offset: 0x0004309C
	public List<string> BHBCODILKEC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.PGJAAIJIDMJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00044F3C File Offset: 0x0004313C
	private bool BABMKDNBBCJ(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 283f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00045070 File Offset: 0x00043270
	public void LGIPMLANMAI()
	{
		string name = "maxWgtBait";
		Type[] array = new Type[0];
		array[0] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "qd_week" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x000451A8 File Offset: 0x000433A8
	public void LHEFDHIIJFJ()
	{
		Transform transform = new GameObject(" for ", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "Wait" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000452E0 File Offset: 0x000434E0
	public List<string> CNIMKBCIEBI(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.LAEFIPIJBBN(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00045384 File Offset: 0x00043584
	public string[] JBPCOKKFKNK(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KELAKAMMEDP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x0004542C File Offset: 0x0004362C
	public List<string> HPAFANBCNDG(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.PBADJJJMPIP(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000454D0 File Offset: 0x000436D0
	public void EEAJOLHBJOD()
	{
		string name = "";
		Type[] array = new Type[0];
		array[1] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "Speed hack detected!" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00045608 File Offset: 0x00043808
	private bool MEKNNPABKLA(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 348f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return true;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0004573C File Offset: 0x0004393C
	private bool FJIDOFFCJPI(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i += 0)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.EHCOJLCADNE(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.BABMKDNBBCJ(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x000457A4 File Offset: 0x000439A4
	private bool AOLENHHFMPP(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.LONHAMGIOLC(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return false;
			}
			if (this.KIAHIDJACCF(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0004580C File Offset: 0x00043A0C
	public string[] ANEDNNNBPLB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.NFFBBJHLBFE(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000458B4 File Offset: 0x00043AB4
	private bool JFNHDCALMJK(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 1894f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x000459E8 File Offset: 0x00043BE8
	private bool PGJAAIJIDMJ(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.MEKNNPABKLA(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.KELAKAMMEDP(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00045A50 File Offset: 0x00043C50
	private bool MNNLOLFEJFN(Transform FFGIAHPIPEK, AI_RangeMarker BKMFLODIHPL)
	{
		MeshFilter[] componentsInChildren = FFGIAHPIPEK.gameObject.GetComponentsInChildren<MeshFilter>();
		int num = componentsInChildren.Length;
		for (int i = 1; i < num; i++)
		{
			Bounds bounds = componentsInChildren[i].mesh.bounds;
			if (this.KCKNBJMPGAH(FFGIAHPIPEK.TransformPoint(bounds.max), BKMFLODIHPL))
			{
				return true;
			}
			if (this.CEGJLILKPEB(FFGIAHPIPEK.TransformPoint(bounds.min), BKMFLODIHPL))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00045AB8 File Offset: 0x00043CB8
	public string[] IHMKFOAIEIC(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.AGBIJKCFOAG(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00045B5C File Offset: 0x00043D5C
	public void DJJGEDCMGID()
	{
		Transform transform = new GameObject("wpn_rem4", new Type[]
		{
			typeof(AI_RangeMarker)
		}).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "BowFire" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00045C94 File Offset: 0x00043E94
	public List<string> NFHCKDOINFJ(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.NFFBBJHLBFE(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00045D38 File Offset: 0x00043F38
	private bool PBADJJJMPIP(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 338f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00045E6C File Offset: 0x0004406C
	public string[] LHAIBNCEHNH(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.FOBODOPMCBF(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00045F14 File Offset: 0x00044114
	private bool FOBODOPMCBF(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 38f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00046048 File Offset: 0x00044248
	public List<string> ODBLBENIIOM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.JLOHLOFDKKL(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000460EC File Offset: 0x000442EC
	public List<string> ENPEKEOINDI(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.NFFBBJHLBFE(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00046190 File Offset: 0x00044390
	public void PHPKCLKLKKD()
	{
		string name = "---";
		Type[] array = new Type[0];
		array[0] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "x" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x000462C8 File Offset: 0x000444C8
	public string[] NEOBONDKOCB(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x0004636C File Offset: 0x0004456C
	private bool NFFBBJHLBFE(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 1583f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x000464A0 File Offset: 0x000446A0
	private bool DEJMHGLKKFP(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 360f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x000465D4 File Offset: 0x000447D4
	public List<string> DGJIDBODBCE(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KBCMLCBLMDM(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00046674 File Offset: 0x00044874
	public List<string> NBGCCKGJDEL(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.KMOGJCHLHNJ(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00046714 File Offset: 0x00044914
	private bool LBBFDOGJKGC(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 78f)
		{
			return false;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00046848 File Offset: 0x00044A48
	public List<string> NJNFHCCNIEI(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.AOLENHHFMPP(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000468E8 File Offset: 0x00044AE8
	public string[] NFCJLNOCLPK(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.OHPGEFILMML(FFGIAHPIPEK.position, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00046990 File Offset: 0x00044B90
	private bool EHCOJLCADNE(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return true;
		}
		if (BKMFLODIHPL.angleView == 1619f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return false;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00046AC4 File Offset: 0x00044CC4
	public List<string> FLMFCANGCIJ(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 0; i < count; i += 0)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.JGKPKALCKPN(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00046B7C File Offset: 0x00044D7C
	private bool OLIFCALEPBO(Vector3 JJNHJKFMFLJ, AI_RangeMarker BKMFLODIHPL)
	{
		if (Vector3.Distance(BKMFLODIHPL.anchorTarget.position, JJNHJKFMFLJ) > BKMFLODIHPL.runtimeDistance)
		{
			return false;
		}
		if (BKMFLODIHPL.angleView == 603f)
		{
			return true;
		}
		Transform transform = new GameObject().transform;
		transform.position = BKMFLODIHPL.anchorTarget.position;
		transform.LookAt(BKMFLODIHPL.transform);
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = transform));
		if (BKMFLODIHPL.anchorTarget.localEulerAngles.y > BKMFLODIHPL.anchorLeft.localEulerAngles.y || BKMFLODIHPL.anchorTarget.localEulerAngles.y < BKMFLODIHPL.anchorRight.localEulerAngles.y)
		{
			BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
			UnityEngine.Object.Destroy(transform.gameObject);
			return true;
		}
		BKMFLODIHPL.anchorTarget.parent = (BKMFLODIHPL.anchorLeft.parent = (BKMFLODIHPL.anchorRight.parent = null));
		UnityEngine.Object.Destroy(transform.gameObject);
		return false;
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00046CB0 File Offset: 0x00044EB0
	public string[] MFFDMLFACGM(Transform FFGIAHPIPEK)
	{
		int count = this.markersComponents.Count;
		List<string> list = new List<string>();
		for (int i = 1; i < count; i++)
		{
			AI_RangeMarker ai_RangeMarker = this.markersComponents[i];
			ai_RangeMarker.anchorTarget.LookAt(new Vector3(FFGIAHPIPEK.position.x, ai_RangeMarker.anchorTarget.position.y, FFGIAHPIPEK.position.z));
			if (this.BIBLKMMCMMH(FFGIAHPIPEK, ai_RangeMarker))
			{
				ai_RangeMarker.color = Color.magenta;
				list.Add(ai_RangeMarker.zoneName);
			}
			else
			{
				ai_RangeMarker.color = ai_RangeMarker.colorBack;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00046D54 File Offset: 0x00044F54
	public void EIDEGJINNFO()
	{
		string name = "invn_rec28";
		Type[] array = new Type[0];
		array[0] = typeof(AI_RangeMarker);
		Transform transform = new GameObject(name, array).transform;
		transform.rotation = base.transform.rotation;
		transform.position = base.transform.position;
		AI_RangeMarker component = transform.GetComponent<AI_RangeMarker>();
		component.holder = this;
		int count = this.markersComponents.Count;
		switch (count)
		{
		case 0:
			component.color = Color.red;
			break;
		case 1:
			component.color = Color.yellow;
			break;
		case 2:
			component.color = Color.green;
			break;
		case 3:
			component.color = Color.blue;
			break;
		case 4:
			component.color = Color.cyan;
			break;
		case 5:
			component.color = Color.magenta;
			break;
		default:
			component.color = Color.gray;
			break;
		}
		component.zoneName = "repa send" + count;
		this.markersComponents.Add(component);
		transform.Translate(Vector3.forward * (float)this.markersComponents.Count, base.transform);
		transform.parent = base.transform;
	}

	// Token: 0x040000EA RID: 234
	public bool showRings = true;

	// Token: 0x040000EB RID: 235
	public List<AI_RangeMarker> markersComponents = new List<AI_RangeMarker>();
}
