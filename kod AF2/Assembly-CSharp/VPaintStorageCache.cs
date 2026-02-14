using System;
using System.Collections.Generic;
using UnityEngine;
using Valkyrie.VPaint;

// Token: 0x020000A9 RID: 169
public class VPaintStorageCache : ScriptableObject
{
	// Token: 0x06002429 RID: 9257 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] NEGHDEOPFJL()
	{
		return null;
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] EDFKDEPOECE()
	{
		return null;
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject BALIILLGJCA(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject EDAKPACCMED(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x000FFA70 File Offset: 0x000FDC70
	public VPaintGroup OKFBDBFGMDJ(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.KKMCHJJLMFG();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.MNFIHABHMIF());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.CKJLJGJDBIL(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.LILODACFHCC(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.BALIILLGJCA(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.POKKINMBENJ(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.MBEOBHDPINL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x000FFC40 File Offset: 0x000FDE40
	public VPaintGroup CNDBBPNBJJE(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.GBGBNPLAGEJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.ELDEHOJMEND());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AALEOCFDFBE(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.DPFANHHAIOH(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.DBMBJPHCIGD(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.NPCDFPPLIKD(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] DBCHLNKLEHO()
	{
		return null;
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject NIPPPONJLDO(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject OOBOGFIPFFC(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] MNFIHABHMIF()
	{
		return null;
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject DBMBJPHCIGD(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] IIANBNPGKGF()
	{
		return null;
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] CPMCDFJLEMK()
	{
		return null;
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] CIICNBFAAOP()
	{
		return null;
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] PJOAJBADHBD()
	{
		return null;
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject MKDONEDCLDF(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject AALEOCFDFBE(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000FFE10 File Offset: 0x000FE010
	public VPaintGroup NKKHPEFLECJ(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.KKMCHJJLMFG();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.CAJKOAFPNKJ());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AFNPIKJCKPD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.BKJKKKMJIMG(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.NIPPPONJLDO(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.LHPBPGNGDMH(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject LCJPEEDPFNG(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] HPLPGNICMJH()
	{
		return null;
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject AMOCPLENOJE(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject HHHCCHKAEOD(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject ONHGNJPNEMB(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] CAJKOAFPNKJ()
	{
		return null;
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000FFFE0 File Offset: 0x000FE1E0
	public VPaintGroup MONAEJEFEMO(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.NBEHLHEDFAJ());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.NIPPPONJLDO(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.vpaintObject = vpaintObject;
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.NIPPPONJLDO(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					vpaintGroup.vertexCache.Add(new VPaintVertexCache
					{
						vpaintObject = vpaintObject2,
						vertices = vpaintVertexCache.vertices
					});
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x001001B0 File Offset: 0x000FE3B0
	public VPaintGroup ACPNODOLAOF(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.HPLPGNICMJH());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.HHHCCHKAEOD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.MOLBJOENPBO(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.GHMDFDIEBMK(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.ILOKLEADLCP(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.LCHCOJMCIBM(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x00100380 File Offset: 0x000FE580
	public VPaintGroup HBFPKCBILAE(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.EDFKDEPOECE());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.GHMDFDIEBMK(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.HIOPDEKOFEJ(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.GHMDFDIEBMK(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.IFOKNDNINDG(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x00100550 File Offset: 0x000FE750
	public VPaintGroup AIPCLBJAOKB(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.GBGBNPLAGEJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.HCGKADAEDNH());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.DAEKGEALFHJ(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.NOLLAHGJGBD(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.NIPPPONJLDO(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.BAAFPGFPNDB(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x00100720 File Offset: 0x000FE920
	public VPaintGroup NFIPJDPLBBL(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.GBGBNPLAGEJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.EDFKDEPOECE());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.OOBOGFIPFFC(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.APDAGNIOOKF(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.HHHCCHKAEOD(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.JCGOBDLGKCK(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x001008F0 File Offset: 0x000FEAF0
	public VPaintGroup DIKHOHDLMOH(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.DHNJDPCPEJH();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.NEGHDEOPFJL());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AMOCPLENOJE(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.NEFLOMEOHEI(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.MKDONEDCLDF(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.NKELNECDPAO(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.LCHCOJMCIBM(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] IBIIIIMDMGA()
	{
		return null;
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x00100AC0 File Offset: 0x000FECC0
	public VPaintGroup CDMCOHKAOMO(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.IBIIIIMDMGA());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AFNPIKJCKPD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.CIINHFMGOOP(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.MKDONEDCLDF(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.LCMJEJPMHJN(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x00100C90 File Offset: 0x000FEE90
	public VPaintGroup NMNAKLBKPOL(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.LDFDHMFCAGB();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.ELDEHOJMEND());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.HHHCCHKAEOD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.vpaintObject = vpaintObject;
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.NIPPPONJLDO(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.JCGOBDLGKCK(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject IFGHFHHPGLD(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject DAEKGEALFHJ(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x00100E60 File Offset: 0x000FF060
	public VPaintGroup LFKHGLOIBNJ(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.DHNJDPCPEJH();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.IIANBNPGKGF());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AFNPIKJCKPD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.NIGPCEKEEOC(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.OOBOGFIPFFC(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.NKELNECDPAO(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject AFNPIKJCKPD(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject GHMDFDIEBMK(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x00101030 File Offset: 0x000FF230
	public VPaintGroup LBICCOAKIIH(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.LDFDHMFCAGB();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.ELDEHOJMEND());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.AFNPIKJCKPD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.NIGPCEKEEOC(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.DAEKGEALFHJ(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.PAIMFJAHGKK(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] HCGKADAEDNH()
	{
		return null;
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x00101200 File Offset: 0x000FF400
	public VPaintGroup BEIBHMDBIIA(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.DHNJDPCPEJH();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.HPLPGNICMJH());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.GOBECGKJDOP(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.APDAGNIOOKF(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.CKJLJGJDBIL(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.IFOKNDNINDG(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] ELDEHOJMEND()
	{
		return null;
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject CBCPCBMAMJB(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject CKJLJGJDBIL(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x001013FC File Offset: 0x000FF5FC
	public VPaintGroup APNAAFNNOIA(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.EDFKDEPOECE());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.IFGHFHHPGLD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.MOLBJOENPBO(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.GOBECGKJDOP(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.MLBOFLMLHHH(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.COKPHPIJPND(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x001015CC File Offset: 0x000FF7CC
	public VPaintGroup HBKALDEAJKL(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.FJJGDEMOKIJ();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.EDFKDEPOECE());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.DBMBJPHCIGD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.CIINHFMGOOP(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.HHHCCHKAEOD(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					vpaintGroup.vertexCache.Add(new VPaintVertexCache
					{
						vpaintObject = vpaintObject2,
						vertices = vpaintVertexCache.vertices
					});
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.MBEOBHDPINL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x0010179C File Offset: 0x000FF99C
	public VPaintGroup FGPLCADODPG(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.LDFDHMFCAGB();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.HPLPGNICMJH());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.DBMBJPHCIGD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.CIINHFMGOOP(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.BALIILLGJCA(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.OHFFGJNAJGP(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.MBEOBHDPINL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject[] NBEHLHEDFAJ()
	{
		return null;
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x0010196C File Offset: 0x000FFB6C
	public VPaintGroup GLPFOBICAJI(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.LDFDHMFCAGB();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.NBEHLHEDFAJ());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.IFGHFHHPGLD(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.LHPBPGNGDMH(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.DBMBJPHCIGD(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.NCJBFMOONOP(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x00101B3C File Offset: 0x000FFD3C
	public VPaintGroup FKPJPHJKLMI(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.DHNJDPCPEJH();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.HCGKADAEDNH());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.GHMDFDIEBMK(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.FGBGMIIADFO(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.GHMDFDIEBMK(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.JCGOBDLGKCK(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.LCHCOJMCIBM(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x00101D0C File Offset: 0x000FFF0C
	public VPaintGroup KOIJJOPGKLB(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.LDFDHMFCAGB();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.IIANBNPGKGF());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.MKDONEDCLDF(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.OHFFGJNAJGP(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.AALEOCFDFBE(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.HBLGFAHKBJL(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.AddColorer(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x000FFA6B File Offset: 0x000FDC6B
	public virtual VPaintObject GOBECGKJDOP(VPaintStorageObject MBKPMBPLIJN)
	{
		return null;
	}

	// Token: 0x0600245E RID: 9310 RVA: 0x00101EDC File Offset: 0x001000DC
	public VPaintGroup AFAFHLFPKFO(string BNIHFBMEPAB, bool JCEPJOOPLPE = true)
	{
		VPaintGroup vpaintGroup = new GameObject(BNIHFBMEPAB).AddComponent<VPaintGroup>();
		VPaintLayerStack vpaintLayerStack = this.layerStack.DHNJDPCPEJH();
		List<VPaintObject> list = new List<VPaintObject>();
		list.AddRange(this.MNFIHABHMIF());
		foreach (VPaintLayer vpaintLayer in vpaintLayerStack.layers)
		{
			foreach (VPaintVertexData vpaintVertexData in vpaintLayer.paintData)
			{
				VPaintStorageObject mbkpmbplijn = vpaintVertexData.colorer as VPaintStorageObject;
				VPaintObject vpaintObject = this.MKDONEDCLDF(mbkpmbplijn);
				if (vpaintObject)
				{
					vpaintVertexData.APDAGNIOOKF(vpaintObject);
					if (!list.Contains(vpaintObject))
					{
						list.Add(vpaintObject);
					}
				}
			}
		}
		if (JCEPJOOPLPE)
		{
			foreach (VPaintVertexCache vpaintVertexCache in this.vertexCache)
			{
				VPaintObject vpaintObject2 = this.AALEOCFDFBE(vpaintVertexCache.obj as VPaintStorageObject);
				if (vpaintObject2)
				{
					List<VPaintVertexCache> list2 = vpaintGroup.vertexCache;
					VPaintVertexCache vpaintVertexCache2 = new VPaintVertexCache();
					vpaintVertexCache2.EMBHNMMAGIE(vpaintObject2);
					vpaintVertexCache2.vertices = vpaintVertexCache.vertices;
					list2.Add(vpaintVertexCache2);
				}
			}
		}
		VPaintStorageCacheInstance vpaintStorageCacheInstance = vpaintGroup.gameObject.AddComponent<VPaintStorageCacheInstance>();
		vpaintStorageCacheInstance.vpaintStorageCache = this;
		vpaintStorageCacheInstance.vpaintGroup = vpaintGroup;
		foreach (VPaintObject fghenlapejp in list)
		{
			vpaintGroup.GAMDOPKILKL(fghenlapejp);
		}
		vpaintGroup.layerStack = vpaintLayerStack;
		return vpaintGroup;
	}

	// Token: 0x04000422 RID: 1058
	public VPaintLayerStack layerStack = new VPaintLayerStack();

	// Token: 0x04000423 RID: 1059
	[SerializeField]
	[HideInInspector]
	public List<VPaintStorageObject> storageObjects = new List<VPaintStorageObject>();

	// Token: 0x04000424 RID: 1060
	[SerializeField]
	[HideInInspector]
	public List<VPaintVertexCache> vertexCache = new List<VPaintVertexCache>();
}
