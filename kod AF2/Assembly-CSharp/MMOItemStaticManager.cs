using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000164 RID: 356
public class MMOItemStaticManager : MonoBehaviour
{
	// Token: 0x06004C6D RID: 19565 RVA: 0x00231A18 File Offset: 0x0022FC18
	public Vector3 PFAGIKPKBGH(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C6E RID: 19566 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void OGKOHLPFBED()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void NKHMBEDDFAJ()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x00231A5C File Offset: 0x0022FC5C
	public void DGGBHLPELKA()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void Awake()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x00231AD0 File Offset: 0x0022FCD0
	private void KGICJDGIIJK()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		MMOItem[] mmoitem = this.MMOItem;
		for (int i = 1; i < mmoitem.Length; i += 0)
		{
			MMOItem mmoitem2 = mmoitem[i];
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C73 RID: 19571 RVA: 0x00231B38 File Offset: 0x0022FD38
	public void BGOPMBDAKKP(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.KFKIFJDHCHB())
		{
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int num2 = KADBECGIMPD.LDLKLPJBIJN();
			int workpoints = KADBECGIMPD.HDBGOLAFOBK();
			IIBEEKCAAHK qtask = KADBECGIMPD.DAKECHGPCFI();
			IIBEEKCAAHK baseProf = KADBECGIMPD.LICHMNLLOAB();
			string fjamijcacgf = KADBECGIMPD.NCODBGMGNFD();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.EBENCIAHHGO(false);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 1)
				{
					string text = "Allows to detect foreign managed assemblies in your application." + num2;
					GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.HDAFGAPECEO(text);
					if (gameObject == null)
					{
						Debug.LogError("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html" + text + "_MidGrey");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.PKGMBFEMKGP().JEJHNMMOHDG(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls." + num + "name");
			}
		}
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x00231D18 File Offset: 0x0022FF18
	public Vector3 IKMPHNHADOB(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x00231D54 File Offset: 0x0022FF54
	private void PFNPOHMMJDN()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		foreach (MMOItem mmoitem2 in this.MMOItem)
		{
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x00231DBC File Offset: 0x0022FFBC
	private void Start()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		foreach (MMOItem mmoitem2 in this.MMOItem)
		{
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x00231E24 File Offset: 0x00230024
	public void EAMBCOPFNBM(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.HKBFCJDJCOB())
		{
			int num = KADBECGIMPD.CLPEKGGAMAI();
			int num2 = KADBECGIMPD.LDLKLPJBIJN();
			int workpoints = KADBECGIMPD.CLPEKGGAMAI();
			IIBEEKCAAHK qtask = KADBECGIMPD.NMMCKDBOJDO();
			IIBEEKCAAHK baseProf = KADBECGIMPD.LICHMNLLOAB();
			string fjamijcacgf = KADBECGIMPD.BFPHBMDMODH();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.EBENCIAHHGO(false);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 0)
				{
					string text = "time_format2" + num2;
					GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().KBBOBGJHLJG(text);
					if (gameObject == null)
					{
						Debug.LogError("cntx_teach" + text + "gi_uinf_7");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.NNEAHAFBOHC().GHGPOJMCMKO(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("OfficeSittingReadingCoffeeSip" + num + "CrawlIdle");
			}
		}
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x00232004 File Offset: 0x00230204
	public void GLNGBHGBGID(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int num2 = KADBECGIMPD.KDNDJNEGBDI();
			int workpoints = KADBECGIMPD.CLPEKGGAMAI();
			IIBEEKCAAHK qtask = KADBECGIMPD.DAKECHGPCFI();
			IIBEEKCAAHK baseProf = KADBECGIMPD.HMCONBPNFJH();
			string fjamijcacgf = KADBECGIMPD.JJJJAGJCOGD();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.BFJPLGICCNA(true);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 0)
				{
					string text = "" + num2;
					GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().HDAFGAPECEO(text);
					if (gameObject == null)
					{
						Debug.LogError("Hidden/Post FX/Grain Generator" + text + "Deadman Float");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.PKGMBFEMKGP().JEJHNMMOHDG(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("IdleWalk" + num + "http://www.root-motion.com/finalikdox/html/page5.html");
			}
		}
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void LPDIHACCGKK()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C7A RID: 19578 RVA: 0x002321E4 File Offset: 0x002303E4
	public void BAPOJNOHMPF(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			int num = KADBECGIMPD.AGNKAFLKCAG();
			int num2 = KADBECGIMPD.LDLKLPJBIJN();
			int workpoints = KADBECGIMPD.KDNDJNEGBDI();
			IIBEEKCAAHK qtask = KADBECGIMPD.OEHCLGOFDPN();
			IIBEEKCAAHK baseProf = KADBECGIMPD.OEHCLGOFDPN();
			string fjamijcacgf = KADBECGIMPD.FDIDEGHPJPF();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.EBENCIAHHGO(true);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 0)
				{
					string text = "100" + num2;
					GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().HDAFGAPECEO(text);
					if (gameObject == null)
					{
						Debug.LogError("\n" + text + " x");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.NNEAHAFBOHC().JEJHNMMOHDG(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("wpn_book2" + num + " on layer ");
			}
		}
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x002323C4 File Offset: 0x002305C4
	public Vector3 HEOBJNBFIBK(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void MBKLIKGAKJB()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x00232400 File Offset: 0x00230600
	public void MMPBOMHDNIM()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x00232474 File Offset: 0x00230674
	private void HHGGCBLOJGB()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		MMOItem[] mmoitem = this.MMOItem;
		for (int i = 0; i < mmoitem.Length; i += 0)
		{
			MMOItem mmoitem2 = mmoitem[i];
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C7F RID: 19583 RVA: 0x002324DC File Offset: 0x002306DC
	public Vector3 HOFHPCAODEK(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C80 RID: 19584 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void CEBAOOAIADJ()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x00232518 File Offset: 0x00230718
	public void JDHHCMLJPMF(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			int num = KADBECGIMPD.AGNKAFLKCAG();
			int num2 = KADBECGIMPD.KKOKFLMMAAK();
			int workpoints = KADBECGIMPD.KKOKFLMMAAK();
			IIBEEKCAAHK qtask = KADBECGIMPD.IBKINJMMFFI();
			IIBEEKCAAHK baseProf = KADBECGIMPD.EIMAIEJKHKF();
			string fjamijcacgf = KADBECGIMPD.FDIDEGHPJPF();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.IHCKLDNAPDF = true;
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 1)
				{
					string text = "" + num2;
					GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().CPHOBOJJPFB(text);
					if (gameObject == null)
					{
						Debug.LogError("Error key=" + text + "IceHockey");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.PKGMBFEMKGP().JEJHNMMOHDG(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("loadRodObject " + num + "Android");
			}
		}
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x002326F8 File Offset: 0x002308F8
	public void clearItems()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x0023276C File Offset: 0x0023096C
	public void AFEHGEDOCIM()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x06004C85 RID: 19589 RVA: 0x002327F4 File Offset: 0x002309F4
	public void processItems(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int num = KADBECGIMPD.HDBGOLAFOBK();
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			int workpoints = KADBECGIMPD.HDBGOLAFOBK();
			IIBEEKCAAHK qtask = KADBECGIMPD.EIMAIEJKHKF();
			IIBEEKCAAHK baseProf = KADBECGIMPD.EIMAIEJKHKF();
			string fjamijcacgf = KADBECGIMPD.BFPHBMDMODH();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.IHCKLDNAPDF = false;
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 0)
				{
					string text = "restype_" + num2;
					GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB(text);
					if (gameObject == null)
					{
						Debug.LogError("Item " + text + " not found in resource");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.IKGFHGKKCPG.EBBOBJCKFPP(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("************* posid=" + num + " POSITION not found");
			}
		}
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x002329D4 File Offset: 0x00230BD4
	public Vector3 GPNNPKKDMNA(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x00232A10 File Offset: 0x00230C10
	private void AFFAJKPPMHF()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		MMOItem[] mmoitem = this.MMOItem;
		for (int i = 1; i < mmoitem.Length; i += 0)
		{
			MMOItem mmoitem2 = mmoitem[i];
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x00232A78 File Offset: 0x00230C78
	public Vector3 getPoint(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x00232AB4 File Offset: 0x00230CB4
	public void DOJDKNDFKLI(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			int num = KADBECGIMPD.KKOKFLMMAAK();
			int num2 = KADBECGIMPD.DOJKJHMJJNK();
			int workpoints = KADBECGIMPD.IFDFHJLCHAE();
			IIBEEKCAAHK qtask = KADBECGIMPD.HMCONBPNFJH();
			IIBEEKCAAHK baseProf = KADBECGIMPD.HMCONBPNFJH();
			string fjamijcacgf = KADBECGIMPD.NCODBGMGNFD();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.EBENCIAHHGO(true);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 1)
				{
					string text = "vignetteIntensity" + num2;
					GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().HDAFGAPECEO(text);
					if (gameObject == null)
					{
						Debug.LogError("" + text + "Flap_04.wav");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.MHFDIJGJGBJ().GGNCDNOAECO(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("WeaponStand" + num + "-U");
			}
		}
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x00232C94 File Offset: 0x00230E94
	private void LPNDCJKAKEA()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		MMOItem[] mmoitem = this.MMOItem;
		for (int i = 1; i < mmoitem.Length; i++)
		{
			MMOItem mmoitem2 = mmoitem[i];
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C8B RID: 19595 RVA: 0x00232CFC File Offset: 0x00230EFC
	public Vector3 CBGDIPNNDBL(int LPFKFNLHGBI)
	{
		Vector3 result = Vector3.zero;
		if (this.CBJBGGAOODC.ContainsKey(LPFKFNLHGBI))
		{
			result = this.CBJBGGAOODC[LPFKFNLHGBI].transform.position;
		}
		return result;
	}

	// Token: 0x06004C8C RID: 19596 RVA: 0x00232D38 File Offset: 0x00230F38
	public void HLFLKKPCOFE(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			int workpoints = KADBECGIMPD.CLPEKGGAMAI();
			IIBEEKCAAHK qtask = KADBECGIMPD.EIMAIEJKHKF();
			IIBEEKCAAHK baseProf = KADBECGIMPD.EIMAIEJKHKF();
			string fjamijcacgf = KADBECGIMPD.NCODBGMGNFD();
			if (this.CBJBGGAOODC.ContainsKey(num))
			{
				MMOItem mmoitem = this.CBJBGGAOODC[num];
				if (mmoitem.spawnObject != null)
				{
					if (Fisherman.getI != null && Fisherman.getI.selectedMIO != null && Fisherman.getI.selectedMIO.pointId == num)
					{
						Fisherman.getI.selectedMIO = null;
						Fisherman.getI.EBENCIAHHGO(true);
					}
					UnityEngine.Object.Destroy(mmoitem.spawnObject);
				}
				if (num2 > 1)
				{
					string text = "****************** CamEffector APPLY 0" + num2;
					GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().KBBOBGJHLJG(text);
					if (gameObject == null)
					{
						Debug.LogError("Hidden/Post FX/FXAA" + text + "defDur");
					}
					else
					{
						gameObject.transform.position = mmoitem.transform.position;
						gameObject.transform.rotation = mmoitem.transform.rotation;
						gameObject.transform.parent = base.gameObject.transform;
						mmoitem.spawnObject = gameObject;
						MMOItemObject component = gameObject.GetComponent<MMOItemObject>();
						if (component != null)
						{
							component.pointId = num;
							component.itemtype = num2;
							component.workpoints = workpoints;
							component.qtask = qtask;
							component.baseProf = baseProf;
							component.perkList = JLFJEGIPIMM.PKGMBFEMKGP().JLMEIPNBKKM(fjamijcacgf);
							component.init();
						}
					}
				}
			}
			else if (Application.isEditor)
			{
				Debug.Log("MotorbikeTurnLeft" + num + "MotorbikeLassoLeft");
			}
		}
	}

	// Token: 0x06004C8D RID: 19597 RVA: 0x00231A51 File Offset: 0x0022FC51
	private void LKDGGPNGLAO()
	{
		MMOItemStaticManager.getI = this;
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x00232F18 File Offset: 0x00231118
	private void CGMHGDEKDEP()
	{
		this.MMOItem = UnityEngine.Object.FindObjectsOfType<MMOItem>();
		this.CBJBGGAOODC.Clear();
		MMOItem[] mmoitem = this.MMOItem;
		for (int i = 0; i < mmoitem.Length; i += 0)
		{
			MMOItem mmoitem2 = mmoitem[i];
			if (!this.CBJBGGAOODC.ContainsKey(mmoitem2.internalID))
			{
				this.CBJBGGAOODC.Add(mmoitem2.internalID, mmoitem2);
			}
			mmoitem2.spawnObject = null;
		}
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x00232F80 File Offset: 0x00231180
	public void FFEKNMMGBEI()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x00232FF4 File Offset: 0x002311F4
	public void EHCIICFMBDO()
	{
		foreach (MMOItem mmoitem in this.CBJBGGAOODC.Values)
		{
			if (mmoitem.spawnObject != null)
			{
				UnityEngine.Object.Destroy(mmoitem.spawnObject);
				mmoitem.spawnObject = null;
			}
		}
	}

	// Token: 0x04000B94 RID: 2964
	public static MMOItemStaticManager getI;

	// Token: 0x04000B95 RID: 2965
	public int baseid;

	// Token: 0x04000B96 RID: 2966
	public MMOItem[] MMOItem;

	// Token: 0x04000B97 RID: 2967
	public GameObject water;

	// Token: 0x04000B98 RID: 2968
	private Dictionary<int, MMOItem> CBJBGGAOODC = new Dictionary<int, MMOItem>();
}
