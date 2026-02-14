using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000B6 RID: 182
public class EventSystemChecker : MonoBehaviour
{
	// Token: 0x0600270D RID: 9997 RVA: 0x00112B03 File Offset: 0x00110D03
	private void Awake()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("EventSystem");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x0600270E RID: 9998 RVA: 0x00112B2D File Offset: 0x00110D2D
	private void CCPOIOJPKIF()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("RollerBladeRoll");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = false;
		}
	}

	// Token: 0x0600270F RID: 9999 RVA: 0x00112B57 File Offset: 0x00110D57
	private void LHHFHDNBKKC()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("_DistortParams");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x00112B81 File Offset: 0x00110D81
	private void OGKOHLPFBED()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("gi_letgoshe");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x00112BAB File Offset: 0x00110DAB
	private void JMNLEBAPHNJ()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("UpHillWalkHandGrab");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = false;
		}
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x00112BD5 File Offset: 0x00110DD5
	private void JIGAFDHOFKL()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("Fish is init!");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x00112BFF File Offset: 0x00110DFF
	private void CNKLGMCHEBM()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("cntx_teach");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x00112C29 File Offset: 0x00110E29
	private void IOIJGMFNBMC()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject(")");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = false;
		}
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x00112C53 File Offset: 0x00110E53
	private void LKDGGPNGLAO()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("1HandSwordStrafeLeft");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = false;
		}
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x00112C7D File Offset: 0x00110E7D
	private void MBNCGMLPNLD()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("WeaponReload");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x00112CA7 File Offset: 0x00110EA7
	private void CBBIADNKMLI()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = false;
		}
	}
}
