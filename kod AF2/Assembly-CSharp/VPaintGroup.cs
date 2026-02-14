using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valkyrie.VPaint;

// Token: 0x020000A0 RID: 160
[AddComponentMenu("VPaint/VPaint Group")]
[ExecuteInEditMode]
public class VPaintGroup : MonoBehaviour
{
	// Token: 0x060021E5 RID: 8677 RVA: 0x000F7030 File Offset: 0x000F5230
	public IEnumerator AHHBOBNPGCP(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintGroup.LBJHMNMKJHA lbjhmnmkjha = new VPaintGroup.LBJHMNMKJHA(1);
		lbjhmnmkjha.AENJLLPLILM = this;
		lbjhmnmkjha.FFGIAHPIPEK = FFGIAHPIPEK;
		lbjhmnmkjha.GDNOKEOLBPP = GDNOKEOLBPP;
		return lbjhmnmkjha;
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000F7050 File Offset: 0x000F5250
	public void CIJFDCNHFKB(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.BDDMGDBCANC(fghenlapejp);
		}
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000F70A0 File Offset: 0x000F52A0
	public void FJJJJJDMIFD()
	{
		this.ECPEIKENDNL(this.layerStack.layers);
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack DPNKNFNHHOB()
	{
		return this.layerStack;
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack NMDHOGINLGO()
	{
		return this.layerStack;
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000F70BC File Offset: 0x000F52BC
	public void HNNMKEDGJLB()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.CJEEOPCPBAG();
			if (vpaintObject)
			{
				vpaintObject.PLCMJKKKONL(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000F7144 File Offset: 0x000F5344
	public void EJEMHGLDBCP()
	{
		this.DDNJPOMFHCA(this.layerStack.layers);
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer HPHPMOCEAOI()
	{
		return new VPaintLayer();
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000F715E File Offset: 0x000F535E
	public void PKNABKPOIFI()
	{
		this.PAHHAHBCNOP(this.layerStack.layers);
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000F7030 File Offset: 0x000F5230
	public IEnumerator DPLDMIFALEK(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintGroup.LBJHMNMKJHA lbjhmnmkjha = new VPaintGroup.LBJHMNMKJHA(1);
		lbjhmnmkjha.AENJLLPLILM = this;
		lbjhmnmkjha.FFGIAHPIPEK = FFGIAHPIPEK;
		lbjhmnmkjha.GDNOKEOLBPP = GDNOKEOLBPP;
		return lbjhmnmkjha;
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000F7174 File Offset: 0x000F5374
	public void BLMNDKFDGNC()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.PLABDCAKECA();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.HJLNKFGLCOC();
			if (vpaintObject)
			{
				vpaintObject.GGPHAOLPBBG(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000F71FC File Offset: 0x000F53FC
	private void ECPEIKENDNL(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.LKHOJDOHEGD(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.ApplyColorsBuilder();
		}
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000F72DC File Offset: 0x000F54DC
	public VPaintObject[] GHCFEPBLFFI()
	{
		for (int i = 1; i < this.colorers.Count; i += 0)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000F732D File Offset: 0x000F552D
	private void AIFIEAGFIMM()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.BLMNDKFDGNC();
		}
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000F7348 File Offset: 0x000F5548
	private void EEPAGDMDCHM(VPaintObject FGHENLAPEJP, VPaintLayer LJFPELOCKOH, VPaintVertexData DNHBPGOKLKD)
	{
		if (FGHENLAPEJP.colorsBuilder == null)
		{
			FGHENLAPEJP.colorsBuilder = new Color[DNHBPGOKLKD.colors.Length];
		}
		if (FGHENLAPEJP.transparencyBuilder == null)
		{
			FGHENLAPEJP.transparencyBuilder = new float[DNHBPGOKLKD.colors.Length];
		}
		DDIHABCDKFJ.PGPFGNEPHEN(FGHENLAPEJP.colorsBuilder, FGHENLAPEJP.transparencyBuilder, DNHBPGOKLKD.colors, DNHBPGOKLKD.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000F73CC File Offset: 0x000F55CC
	private void PAHHAHBCNOP(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.LKHOJDOHEGD(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.DICOLCCGGPA();
		}
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000F74AC File Offset: 0x000F56AC
	private void Awake()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.PLABDCAKECA();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnAwake)
			{
				this.Apply();
			}
		}
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer HPEBPOLLLPF()
	{
		return new VPaintLayer();
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000F74D8 File Offset: 0x000F56D8
	public void NNNKADIMHOL()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.JEEDHIPLHHJ();
			if (vpaintObject)
			{
				vpaintObject.SetColors(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000F7560 File Offset: 0x000F5760
	public void RemoveColorer(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.LDGMPADLEJN));
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer GIFCBCGCLEH()
	{
		return new VPaintLayer();
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack IEAHJGEIBLL()
	{
		return this.layerStack;
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x000F75A4 File Offset: 0x000F57A4
	private void EEPAGDMDCHM(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.ApplyColorsBuilder();
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer HHPAPPMEDHF()
	{
		return new VPaintLayer();
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000F7628 File Offset: 0x000F5828
	private void OLDFHDFAKDN()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
			{
				this.EBLDHDEDDJO();
			}
		}
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000F7654 File Offset: 0x000F5854
	private void EDAMHJCFBAM(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.JCCOFDEGCJP(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.ApplyColorsBuilder();
		}
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000F7734 File Offset: 0x000F5934
	public void OKCKPOMCPAK(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.FAAJENACGIO(fghenlapejp);
		}
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack JAAMDCKCLFN()
	{
		return this.layerStack;
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000F7784 File Offset: 0x000F5984
	public void LCHCOJMCIBM(VPaintObject FGHENLAPEJP)
	{
		if (!FGHENLAPEJP)
		{
			return;
		}
		if (this.colorers.Contains(FGHENLAPEJP))
		{
			return;
		}
		if (FGHENLAPEJP.KHKBPKGEKAO() == null)
		{
			Debug.LogError("Kernel");
			return;
		}
		this.colorers.Add(FGHENLAPEJP);
		List<VPaintVertexCache> list = this.vertexCache;
		VPaintVertexCache vpaintVertexCache = new VPaintVertexCache();
		vpaintVertexCache.KFCBNFOGNIF(FGHENLAPEJP);
		vpaintVertexCache.vertices = FGHENLAPEJP.KHKBPKGEKAO().vertices;
		list.Add(vpaintVertexCache);
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000F7144 File Offset: 0x000F5344
	public void AAOPDHBNLDK()
	{
		this.DDNJPOMFHCA(this.layerStack.layers);
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000F77F8 File Offset: 0x000F59F8
	private void AMKNBGGMDAL(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.KNOPGKKFKEJ(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.ApplyColorsBuilder();
		}
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000F78D8 File Offset: 0x000F5AD8
	public void ILPMFHGKIEK(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.DCPBFDIGCCJ(fghenlapejp);
		}
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000F7144 File Offset: 0x000F5344
	public void OLAGGJBICGF()
	{
		this.DDNJPOMFHCA(this.layerStack.layers);
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000F7928 File Offset: 0x000F5B28
	public void BJCPMIJIKCB(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.DMODHJPNFBI));
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000F796C File Offset: 0x000F5B6C
	private void PFNPOHMMJDN()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.HNNMKEDGJLB();
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000F7984 File Offset: 0x000F5B84
	public VPaintObject[] JFPGHGMDNCK()
	{
		for (int i = 0; i < this.colorers.Count; i += 0)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000F79D8 File Offset: 0x000F5BD8
	private void DNPBPKEFAGB(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.MCAINGLEFEF(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.ApplyColorsBuilder();
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000F7A5C File Offset: 0x000F5C5C
	public void GAMDOPKILKL(VPaintObject FGHENLAPEJP)
	{
		if (!FGHENLAPEJP)
		{
			return;
		}
		if (this.colorers.Contains(FGHENLAPEJP))
		{
			return;
		}
		if (FGHENLAPEJP.GetMeshInstance() == null)
		{
			Debug.LogError("");
			return;
		}
		this.colorers.Add(FGHENLAPEJP);
		this.vertexCache.Add(new VPaintVertexCache
		{
			vpaintObject = FGHENLAPEJP,
			vertices = FGHENLAPEJP.GetMeshInstance().vertices
		});
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000F7ACE File Offset: 0x000F5CCE
	private void EIOCCLJPLHN()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnAwake)
			{
				this.EBLDHDEDDJO();
			}
		}
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000F7AF8 File Offset: 0x000F5CF8
	public void ANGIKKAMKIL(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.HOKJCCJJIOC(fghenlapejp);
		}
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000F7B48 File Offset: 0x000F5D48
	private void OMIEBJGFPAD(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.FGKNJIEOKHH(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.NELOIFJNDKO(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.DICOLCCGGPA();
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000F7030 File Offset: 0x000F5230
	public IEnumerator BLBMKPOOGFO(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintGroup.LBJHMNMKJHA lbjhmnmkjha = new VPaintGroup.LBJHMNMKJHA(1);
		lbjhmnmkjha.AENJLLPLILM = this;
		lbjhmnmkjha.FFGIAHPIPEK = FFGIAHPIPEK;
		lbjhmnmkjha.GDNOKEOLBPP = GDNOKEOLBPP;
		return lbjhmnmkjha;
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000F7BCC File Offset: 0x000F5DCC
	public void JFNLCFBNCEN(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.DMODHJPNFBI));
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator DHOOJPBGNGI(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		List<IEnumerator> list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x000F7C30 File Offset: 0x000F5E30
	public VPaintObject[] BJPEAFBPOMP()
	{
		for (int i = 1; i < this.colorers.Count; i++)
		{
			if (!this.colorers[i])
			{
				this.colorers.RemoveAt(i--);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack OCEJMGJMKGE()
	{
		return this.layerStack;
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000F7C84 File Offset: 0x000F5E84
	public void KJGHILBAAOI(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.AJOAGBGAJBO));
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000F7CC8 File Offset: 0x000F5EC8
	public void ApplyToTangents()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.SetTangents(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000F7030 File Offset: 0x000F5230
	public IEnumerator DHAMPCNDHOM(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintGroup.LBJHMNMKJHA lbjhmnmkjha = new VPaintGroup.LBJHMNMKJHA(1);
		lbjhmnmkjha.AENJLLPLILM = this;
		lbjhmnmkjha.FFGIAHPIPEK = FFGIAHPIPEK;
		lbjhmnmkjha.GDNOKEOLBPP = GDNOKEOLBPP;
		return lbjhmnmkjha;
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000F7D9C File Offset: 0x000F5F9C
	private void GGBMJFNGHMC()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.EBLDHDEDDJO();
		}
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack PLGILMFECJA()
	{
		return this.layerStack;
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000F7DB4 File Offset: 0x000F5FB4
	private void OBJCOJEHLBE()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.EKBJCKMBKBA();
		}
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000F7DCC File Offset: 0x000F5FCC
	[ContextMenu("Apply")]
	public void Apply()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.PLABDCAKECA();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.vpaintObject;
			if (vpaintObject)
			{
				vpaintObject.SetColors(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000F7E54 File Offset: 0x000F6054
	public void LGINOKIFLBK()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.MKNHPNAAHBB(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000F7F28 File Offset: 0x000F6128
	public void IIFPDMNJFEJ(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.OHHMDIFMBCF));
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator BlendTo(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000F7F6C File Offset: 0x000F616C
	public void JIGIBHFIBBL()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.FGKNJIEOKHH(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.FEONPFANLAL(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000F8040 File Offset: 0x000F6240
	public void KFCCDGFHENF()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.SetTangents(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000F8114 File Offset: 0x000F6314
	public void AKJCGOLOFLG()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.MFJBKEFAIJF();
			if (vpaintObject)
			{
				vpaintObject.SetColors(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000F819C File Offset: 0x000F639C
	public void HHOABCCOALA()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			VPaintObject[] componentsInChildren = vpaintObject.GetComponentsInChildren<VPaintObject>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				VPaintObject item = componentsInChildren[i];
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.OLKHLLHNFEG(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000F7D9C File Offset: 0x000F5F9C
	private void DGEIACONKCJ()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.EBLDHDEDDJO();
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000F70A0 File Offset: 0x000F52A0
	public void MIGLHFFCCNA()
	{
		this.ECPEIKENDNL(this.layerStack.layers);
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000F8270 File Offset: 0x000F6470
	private void LMEJKAEIDCO()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.LBCOFBOKHJP();
		}
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000F8288 File Offset: 0x000F6488
	public void CFFFMENHLJG(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.DNPBPKEFAGB(fghenlapejp);
		}
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000F82D8 File Offset: 0x000F64D8
	private void CCPOIOJPKIF()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnAwake)
			{
				this.EKBJCKMBKBA();
			}
		}
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000F8304 File Offset: 0x000F6504
	private void KNOPGKKFKEJ(VPaintLayer LJFPELOCKOH, List<VPaintObject> KMKDABMNLAC)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			if (vpaintObject)
			{
				VPaintVertexData vpaintVertexData = LJFPELOCKOH.FGKNJIEOKHH(vpaintObject);
				if (vpaintVertexData != null)
				{
					this.KNNACPNHIFP(vpaintObject, LJFPELOCKOH, vpaintVertexData);
					if (!KMKDABMNLAC.Contains(vpaintObject))
					{
						KMKDABMNLAC.Add(vpaintObject);
					}
				}
			}
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000F837C File Offset: 0x000F657C
	public void LBCOFBOKHJP()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.MJJNPBLIAHC();
			if (vpaintObject)
			{
				vpaintObject.SetColors(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000F8404 File Offset: 0x000F6604
	public void EBLDHDEDDJO()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.GOCAEEMAKOC();
			if (vpaintObject)
			{
				vpaintObject.SetColors(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000F848C File Offset: 0x000F668C
	public void PFGFKCCOMNP(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.FBFOHGGICDO));
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000F84D0 File Offset: 0x000F66D0
	private void BDDMGDBCANC(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.MCAINGLEFEF(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.DICOLCCGGPA();
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000F715E File Offset: 0x000F535E
	public void FCDHGOPOJIL()
	{
		this.PAHHAHBCNOP(this.layerStack.layers);
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000F8554 File Offset: 0x000F6754
	public void ApplyProgressive()
	{
		this.EDAMHJCFBAM(this.layerStack.layers);
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x000F8568 File Offset: 0x000F6768
	private void LKHOJDOHEGD(VPaintLayer LJFPELOCKOH, List<VPaintObject> KMKDABMNLAC)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			if (vpaintObject)
			{
				VPaintVertexData vpaintVertexData = LJFPELOCKOH.FGKNJIEOKHH(vpaintObject);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(vpaintObject, LJFPELOCKOH, vpaintVertexData);
					if (!KMKDABMNLAC.Contains(vpaintObject))
					{
						KMKDABMNLAC.Add(vpaintObject);
					}
				}
			}
		}
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000F85E0 File Offset: 0x000F67E0
	public VPaintObject[] BHGNMBCJBEL()
	{
		for (int i = 0; i < this.colorers.Count; i += 0)
		{
			if (!this.colorers[i])
			{
				this.colorers.RemoveAt(i--);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000F8634 File Offset: 0x000F6834
	private void OPNIBMGLAHP(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.JCCOFDEGCJP(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.ApplyColorsBuilder();
		}
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack GetLayerStack()
	{
		return this.layerStack;
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000F7030 File Offset: 0x000F5230
	public IEnumerator GNLHGICKKOG(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintGroup.LBJHMNMKJHA lbjhmnmkjha = new VPaintGroup.LBJHMNMKJHA(1);
		lbjhmnmkjha.AENJLLPLILM = this;
		lbjhmnmkjha.FFGIAHPIPEK = FFGIAHPIPEK;
		lbjhmnmkjha.GDNOKEOLBPP = GDNOKEOLBPP;
		return lbjhmnmkjha;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack PDBINIOMOBE()
	{
		return this.layerStack;
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000F8714 File Offset: 0x000F6914
	public void AddColorer(VPaintObject FGHENLAPEJP)
	{
		if (!FGHENLAPEJP)
		{
			return;
		}
		if (this.colorers.Contains(FGHENLAPEJP))
		{
			return;
		}
		if (FGHENLAPEJP.GetMeshInstance() == null)
		{
			Debug.LogError("VPaint Object is missing a mesh.");
			return;
		}
		this.colorers.Add(FGHENLAPEJP);
		this.vertexCache.Add(new VPaintVertexCache
		{
			vpaintObject = FGHENLAPEJP,
			vertices = FGHENLAPEJP.GetMeshInstance().vertices
		});
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000F8788 File Offset: 0x000F6988
	public void PaintObjects(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.EEPAGDMDCHM(fghenlapejp);
		}
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000F87D8 File Offset: 0x000F69D8
	public VPaintObject[] DGLGIHKNEEM()
	{
		for (int i = 1; i < this.colorers.Count; i += 0)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000F882C File Offset: 0x000F6A2C
	public void EPOJFIAFLGH(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.HHOGFFKKGEJ));
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000F8870 File Offset: 0x000F6A70
	public void EKBJCKMBKBA()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.FKPGGHCOPCA();
			if (vpaintObject)
			{
				vpaintObject.KMFAMGDBFGC(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000F88F8 File Offset: 0x000F6AF8
	public VPaintObject[] BBAKOJECBMO()
	{
		for (int i = 1; i < this.colorers.Count; i++)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator ECKEKJKMAII(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000F894C File Offset: 0x000F6B4C
	public void PMCHAIKHKLA()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			VPaintObject[] componentsInChildren = vpaintObject.GetComponentsInChildren<VPaintObject>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				VPaintObject item = componentsInChildren[i];
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.SetTangents(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000F8A20 File Offset: 0x000F6C20
	public void AMHNLDKGMJN()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			VPaintObject[] componentsInChildren = vpaintObject.GetComponentsInChildren<VPaintObject>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				VPaintObject item = componentsInChildren[i];
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.FGKNJIEOKHH(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.SetTangents(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000F8AF4 File Offset: 0x000F6CF4
	public VPaintObject[] GetVPaintObjects()
	{
		for (int i = 0; i < this.colorers.Count; i++)
		{
			if (!this.colorers[i])
			{
				this.colorers.RemoveAt(i--);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000F8B48 File Offset: 0x000F6D48
	public VPaintObject[] JJFEOMKAMNO()
	{
		for (int i = 1; i < this.colorers.Count; i += 0)
		{
			if (!this.colorers[i])
			{
				this.colorers.RemoveAt(i--);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000F8B9C File Offset: 0x000F6D9C
	private void PLHMCKJIIEG(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.KNOPGKKFKEJ(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.ApplyColorsBuilder();
		}
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000F8C7C File Offset: 0x000F6E7C
	public void COKPHPIJPND(VPaintObject FGHENLAPEJP)
	{
		if (!FGHENLAPEJP)
		{
			return;
		}
		if (this.colorers.Contains(FGHENLAPEJP))
		{
			return;
		}
		if (FGHENLAPEJP.GetMeshInstance() == null)
		{
			Debug.LogError("SneakRight");
			return;
		}
		this.colorers.Add(FGHENLAPEJP);
		List<VPaintVertexCache> list = this.vertexCache;
		VPaintVertexCache vpaintVertexCache = new VPaintVertexCache();
		vpaintVertexCache.DPFANHHAIOH(FGHENLAPEJP);
		vpaintVertexCache.vertices = FGHENLAPEJP.EKEOOAGNJME().vertices;
		list.Add(vpaintVertexCache);
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator OILKKEMNGKA(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000F8554 File Offset: 0x000F6754
	public void INFCENNGOEI()
	{
		this.EDAMHJCFBAM(this.layerStack.layers);
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000F8CEE File Offset: 0x000F6EEE
	private void AEJLGHDKHHE()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnAwake)
			{
				this.Apply();
			}
		}
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000F8D17 File Offset: 0x000F6F17
	public void MMMLFDFPBLN()
	{
		this.PLHMCKJIIEG(this.layerStack.layers);
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000F8D2C File Offset: 0x000F6F2C
	public void MBEOBHDPINL(VPaintObject FGHENLAPEJP)
	{
		if (!FGHENLAPEJP)
		{
			return;
		}
		if (this.colorers.Contains(FGHENLAPEJP))
		{
			return;
		}
		if (FGHENLAPEJP.OCPGANGKIAC() == null)
		{
			Debug.LogError("<color='{0}'>{1}</color>");
			return;
		}
		this.colorers.Add(FGHENLAPEJP);
		List<VPaintVertexCache> list = this.vertexCache;
		VPaintVertexCache vpaintVertexCache = new VPaintVertexCache();
		vpaintVertexCache.DPFANHHAIOH(FGHENLAPEJP);
		vpaintVertexCache.vertices = FGHENLAPEJP.GetMeshInstance().vertices;
		list.Add(vpaintVertexCache);
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000F8DA0 File Offset: 0x000F6FA0
	private void MCAINGLEFEF(VPaintObject FGHENLAPEJP, VPaintLayer LJFPELOCKOH, VPaintVertexData DNHBPGOKLKD)
	{
		if (FGHENLAPEJP.colorsBuilder == null)
		{
			FGHENLAPEJP.colorsBuilder = new Color[DNHBPGOKLKD.colors.Length];
		}
		if (FGHENLAPEJP.transparencyBuilder == null)
		{
			FGHENLAPEJP.transparencyBuilder = new float[DNHBPGOKLKD.colors.Length];
		}
		DDIHABCDKFJ.PGPFGNEPHEN(FGHENLAPEJP.colorsBuilder, FGHENLAPEJP.transparencyBuilder, DNHBPGOKLKD.colors, DNHBPGOKLKD.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000F8E24 File Offset: 0x000F7024
	public VPaintObject[] JKNMCGKOGKK()
	{
		for (int i = 0; i < this.colorers.Count; i++)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000F70B3 File Offset: 0x000F52B3
	public VPaintLayerStack HKCFDOBIBOH()
	{
		return this.layerStack;
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000F8E78 File Offset: 0x000F7078
	public void NNHCAMCEGIA(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.CLJIFDAFJDE));
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator MCAFBPKAHCA(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer GetBaseLayer()
	{
		return new VPaintLayer();
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer LLDMOJLBAEF()
	{
		return new VPaintLayer();
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer AJLGBKELBFI()
	{
		return new VPaintLayer();
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000F8EBC File Offset: 0x000F70BC
	private void CLPPHHNMMGF(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.ApplyColorsBuilder();
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000F8F40 File Offset: 0x000F7140
	public void PLKMEGFOEEP(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.DANHDHHGOPF));
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000F8F84 File Offset: 0x000F7184
	private void Start()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.Apply();
		}
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer MAEHFADLDMO()
	{
		return new VPaintLayer();
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000F8F84 File Offset: 0x000F7184
	private void DHJDMKLBLEF()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.Apply();
		}
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000F70A0 File Offset: 0x000F52A0
	public void KEMHEGNMABI()
	{
		this.ECPEIKENDNL(this.layerStack.layers);
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000F8F9C File Offset: 0x000F719C
	public void BOECCIGBJHK(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.NOLBBIDCEHG));
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator LCOLIANDMJB(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000F8FE0 File Offset: 0x000F71E0
	public void NOJAPKJHIMB(List<VPaintObject> PIGONEHAJDJ)
	{
		foreach (VPaintObject fghenlapejp in PIGONEHAJDJ)
		{
			this.FAAJENACGIO(fghenlapejp);
		}
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000F9060 File Offset: 0x000F7260
	public void GBCIGAHLHIM()
	{
		if (this.paintLayer == null)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
		}
		foreach (VPaintVertexData vpaintVertexData in this.paintLayer.paintData)
		{
			VPaintObject vpaintObject = vpaintVertexData.LEOEAMABJOG();
			if (vpaintObject)
			{
				vpaintObject.PLCMJKKKONL(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000F90E8 File Offset: 0x000F72E8
	private void FAAJENACGIO(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.FGKNJIEOKHH(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.KNNACPNHIFP(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.DICOLCCGGPA();
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000F916C File Offset: 0x000F736C
	private void HBOJKOIJJDM()
	{
		if (Application.isPlaying)
		{
			this.paintLayer = this.layerStack.CIMBKJNDANJ();
			if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
			{
				this.BLMNDKFDGNC();
			}
		}
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000F9198 File Offset: 0x000F7398
	private void NELOIFJNDKO(VPaintObject FGHENLAPEJP, VPaintLayer LJFPELOCKOH, VPaintVertexData DNHBPGOKLKD)
	{
		if (FGHENLAPEJP.colorsBuilder == null)
		{
			FGHENLAPEJP.colorsBuilder = new Color[DNHBPGOKLKD.colors.Length];
		}
		if (FGHENLAPEJP.transparencyBuilder == null)
		{
			FGHENLAPEJP.transparencyBuilder = new float[DNHBPGOKLKD.colors.Length];
		}
		DDIHABCDKFJ.PGPFGNEPHEN(FGHENLAPEJP.colorsBuilder, FGHENLAPEJP.transparencyBuilder, DNHBPGOKLKD.colors, DNHBPGOKLKD.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000F921C File Offset: 0x000F741C
	public void NBILPGLALNN()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.AFONGIICOJG(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.BPEHCHCDIEN(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000F92F0 File Offset: 0x000F74F0
	public void NNGDNCLPLBN(VPaintObject FGHENLAPEJP)
	{
		VPaintGroup.FMEFGDMNDAF fmefgdmndaf = new VPaintGroup.FMEFGDMNDAF();
		fmefgdmndaf.FGHENLAPEJP = FGHENLAPEJP;
		this.colorers.Remove(fmefgdmndaf.FGHENLAPEJP);
		this.vertexCache.RemoveAll(new Predicate<VPaintVertexCache>(fmefgdmndaf.OHHMDIFMBCF));
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000F9334 File Offset: 0x000F7534
	private void DDNJPOMFHCA(List<VPaintLayer> EAKLJEJNCBK)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			vpaintObject.colorsBuilder = null;
			vpaintObject.transparencyBuilder = null;
		}
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintLayer vpaintLayer in EAKLJEJNCBK)
		{
			if (vpaintLayer.enabled)
			{
				this.LKHOJDOHEGD(vpaintLayer, list);
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			vpaintObject2.DICOLCCGGPA();
		}
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000F7C10 File Offset: 0x000F5E10
	public IEnumerator GABDADCJOLN(VPaintGroup FFGIAHPIPEK, float GDNOKEOLBPP)
	{
		VPaintLayer vpaintLayer = this.paintLayer;
		VPaintLayer vpaintLayer2 = FFGIAHPIPEK.paintLayer;
		list = new List<IEnumerator>();
		foreach (VPaintObject vpaintObject in this.GetVPaintObjects())
		{
			if (FFGIAHPIPEK.colorers.Contains(vpaintObject))
			{
				int num = vpaintObject.GetMeshInstance().colors.Length;
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(vpaintObject);
				Color[] nahdpcpapbo;
				if (vpaintVertexData == null)
				{
					nahdpcpapbo = new Color[num];
				}
				else
				{
					nahdpcpapbo = vpaintVertexData.colors;
				}
				VPaintVertexData vpaintVertexData2 = vpaintLayer2.AFONGIICOJG(vpaintObject);
				Color[] hcnbhaccjhe;
				if (vpaintVertexData2 == null)
				{
					hcnbhaccjhe = new Color[num];
				}
				else
				{
					hcnbhaccjhe = vpaintVertexData2.colors;
				}
				list.Add(DDIHABCDKFJ.AMODCAPHGAJ(vpaintObject, nahdpcpapbo, hcnbhaccjhe, GDNOKEOLBPP));
			}
		}
		for (;;)
		{
			bool flag = true;
			using (List<IEnumerator>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoveNext())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				break;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000F7144 File Offset: 0x000F5344
	public void CBNLPCAELEG()
	{
		this.DDNJPOMFHCA(this.layerStack.layers);
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000F9414 File Offset: 0x000F7614
	private void JCCOFDEGCJP(VPaintLayer LJFPELOCKOH, List<VPaintObject> KMKDABMNLAC)
	{
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			if (vpaintObject)
			{
				VPaintVertexData vpaintVertexData = LJFPELOCKOH.AFONGIICOJG(vpaintObject);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(vpaintObject, LJFPELOCKOH, vpaintVertexData);
					if (!KMKDABMNLAC.Contains(vpaintObject))
					{
						KMKDABMNLAC.Add(vpaintObject);
					}
				}
			}
		}
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x000F7157 File Offset: 0x000F5357
	public VPaintLayer LANMAFDKFJJ()
	{
		return new VPaintLayer();
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000F948C File Offset: 0x000F768C
	public VPaintObject[] DPLIANHJDID()
	{
		for (int i = 0; i < this.colorers.Count; i++)
		{
			if (!this.colorers[i])
			{
				List<VPaintObject> list = this.colorers;
				int num = i;
				i = num - 0;
				list.RemoveAt(num);
			}
		}
		return this.colorers.ToArray();
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000F94E0 File Offset: 0x000F76E0
	private void DCPBFDIGCCJ(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.DICOLCCGGPA();
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000F9564 File Offset: 0x000F7764
	public void GEFHNOMKANB()
	{
		List<VPaintObject> list = new List<VPaintObject>();
		foreach (VPaintObject vpaintObject in this.colorers)
		{
			foreach (VPaintObject item in vpaintObject.GetComponentsInChildren<VPaintObject>())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (VPaintObject vpaintObject2 in list)
		{
			VPaintVertexData vpaintVertexData = this.paintLayer.FGKNJIEOKHH(vpaintObject2);
			if (vpaintVertexData != null)
			{
				vpaintObject2.OLKHLLHNFEG(vpaintVertexData.colors);
			}
		}
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000F9638 File Offset: 0x000F7838
	private void KNNACPNHIFP(VPaintObject FGHENLAPEJP, VPaintLayer LJFPELOCKOH, VPaintVertexData DNHBPGOKLKD)
	{
		if (FGHENLAPEJP.colorsBuilder == null)
		{
			FGHENLAPEJP.colorsBuilder = new Color[DNHBPGOKLKD.colors.Length];
		}
		if (FGHENLAPEJP.transparencyBuilder == null)
		{
			FGHENLAPEJP.transparencyBuilder = new float[DNHBPGOKLKD.colors.Length];
		}
		DDIHABCDKFJ.PGPFGNEPHEN(FGHENLAPEJP.colorsBuilder, FGHENLAPEJP.transparencyBuilder, DNHBPGOKLKD.colors, DNHBPGOKLKD.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000F96BC File Offset: 0x000F78BC
	private void HOKJCCJJIOC(VPaintObject FGHENLAPEJP)
	{
		FGHENLAPEJP.colorsBuilder = null;
		FGHENLAPEJP.transparencyBuilder = null;
		foreach (VPaintLayer vpaintLayer in this.layerStack.layers)
		{
			if (vpaintLayer.enabled)
			{
				VPaintVertexData vpaintVertexData = vpaintLayer.AFONGIICOJG(FGHENLAPEJP);
				if (vpaintVertexData != null)
				{
					this.EEPAGDMDCHM(FGHENLAPEJP, vpaintLayer, vpaintVertexData);
				}
			}
		}
		FGHENLAPEJP.DICOLCCGGPA();
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x000F9740 File Offset: 0x000F7940
	private void KKCFKEDABLB()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.autoApplySchedule == FHKLMOKCGOF.OnStart)
		{
			this.GBCIGAHLHIM();
		}
	}

	// Token: 0x040003F7 RID: 1015
	[HideInInspector]
	public List<VPaintObject> colorers = new List<VPaintObject>();

	// Token: 0x040003F8 RID: 1016
	[HideInInspector]
	public VPaintLayerStack layerStack = new VPaintLayerStack();

	// Token: 0x040003F9 RID: 1017
	public FHKLMOKCGOF autoApplySchedule;

	// Token: 0x040003FA RID: 1018
	public bool autoLoadInEditor = true;

	// Token: 0x040003FB RID: 1019
	[NonSerialized]
	public VPaintLayer paintLayer;

	// Token: 0x040003FC RID: 1020
	[HideInInspector]
	public List<VPaintVertexCache> vertexCache = new List<VPaintVertexCache>();

	// Token: 0x020000A1 RID: 161
	[CompilerGenerated]
	private sealed class FMEFGDMNDAF
	{
		// Token: 0x06002268 RID: 8808 RVA: 0x000F9758 File Offset: 0x000F7958
		internal bool FANMFLJCLHH(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.EJECMNOEJJH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000F976B File Offset: 0x000F796B
		internal bool JKCCJHMBLCC(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.HDGFNBNEBHH() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000F977E File Offset: 0x000F797E
		internal bool ADLGPOKHEND(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LHBANADOCNL() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000F9791 File Offset: 0x000F7991
		internal bool CPPDNLKLJNG(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FFHNDJMKCJF() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000F977E File Offset: 0x000F797E
		internal bool BGALDDJKGGL(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LHBANADOCNL() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000F97A4 File Offset: 0x000F79A4
		internal bool JPGHNGANCMF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KLOHNCMBLCB() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000F97B7 File Offset: 0x000F79B7
		internal bool GBBHOAACHLL(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IODECHGJFOM() == this.FGHENLAPEJP;
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000F97CA File Offset: 0x000F79CA
		internal bool EHGKOGLJEHB(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IBCCHDHJENF() == this.FGHENLAPEJP;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000F9791 File Offset: 0x000F7991
		internal bool PPDDHKGHKHB(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FFHNDJMKCJF() == this.FGHENLAPEJP;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000F97DD File Offset: 0x000F79DD
		internal bool FOJJEHIGFKK(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.HHOJPIAEDJC() == this.FGHENLAPEJP;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000F97F0 File Offset: 0x000F79F0
		internal bool AIKEJLCMLNL(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KKFLFBNFJEH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000F976B File Offset: 0x000F796B
		internal bool EJKAFOCPEBO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.HDGFNBNEBHH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000F9803 File Offset: 0x000F7A03
		internal bool CLJIFDAFJDE(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.OLCANIBGLOH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000F977E File Offset: 0x000F797E
		internal bool DMFAJHOCFMD(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LHBANADOCNL() == this.FGHENLAPEJP;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000F9816 File Offset: 0x000F7A16
		internal bool OHHMDIFMBCF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.DDAFPNIDGGJ() == this.FGHENLAPEJP;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000F976B File Offset: 0x000F796B
		internal bool AOKJAOAAKIF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.HDGFNBNEBHH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000F9829 File Offset: 0x000F7A29
		internal bool LEIMHONNDDG(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KOKALNHPMHH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000F983C File Offset: 0x000F7A3C
		internal bool JIENFPCNAHM(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LNDBLBABCKC() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000F983C File Offset: 0x000F7A3C
		internal bool DBOKPHLLHBN(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LNDBLBABCKC() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000F977E File Offset: 0x000F797E
		internal bool BHGEJNBINAH(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LHBANADOCNL() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000F9758 File Offset: 0x000F7958
		internal bool PHDMEMIBDHA(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.EJECMNOEJJH() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000F984F File Offset: 0x000F7A4F
		internal bool NEODNFGFEJO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.CJEEOPCPBAG() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000F9803 File Offset: 0x000F7A03
		internal bool DINHDNAFIKI(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.OLCANIBGLOH() == this.FGHENLAPEJP;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x000F9862 File Offset: 0x000F7A62
		internal bool MPABIFMONEJ(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NPFBBOHIDOG() == this.FGHENLAPEJP;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000F9875 File Offset: 0x000F7A75
		internal bool CFOJJMJJCED(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FHBABNLPLHP() == this.FGHENLAPEJP;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000F97CA File Offset: 0x000F79CA
		internal bool MCNBMNEELPC(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IBCCHDHJENF() == this.FGHENLAPEJP;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000F9888 File Offset: 0x000F7A88
		internal bool NOLBBIDCEHG(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.CNBKFLLBENK() == this.FGHENLAPEJP;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000F9816 File Offset: 0x000F7A16
		internal bool DKLDGGILHIG(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.DDAFPNIDGGJ() == this.FGHENLAPEJP;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000F989B File Offset: 0x000F7A9B
		internal bool KEMDHKFFGAL(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LFMLKMIFMLL() == this.FGHENLAPEJP;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000F98AE File Offset: 0x000F7AAE
		internal bool BPHJDOBLKHO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LJDONODJONK() == this.FGHENLAPEJP;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000F9862 File Offset: 0x000F7A62
		internal bool AKPABGMHOOD(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NPFBBOHIDOG() == this.FGHENLAPEJP;
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000F97F0 File Offset: 0x000F79F0
		internal bool HHOGFFKKGEJ(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KKFLFBNFJEH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000F98C1 File Offset: 0x000F7AC1
		internal bool LDGMPADLEJN(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.vpaintObject == this.FGHENLAPEJP;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000F9875 File Offset: 0x000F7A75
		internal bool LFPIKENLBHO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FHBABNLPLHP() == this.FGHENLAPEJP;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000F9862 File Offset: 0x000F7A62
		internal bool DOBMOCODGEM(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NPFBBOHIDOG() == this.FGHENLAPEJP;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000F9758 File Offset: 0x000F7958
		internal bool DMODHJPNFBI(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.EJECMNOEJJH() == this.FGHENLAPEJP;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000F9875 File Offset: 0x000F7A75
		internal bool DANHDHHGOPF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FHBABNLPLHP() == this.FGHENLAPEJP;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000F9875 File Offset: 0x000F7A75
		internal bool FAFMPKCLLKP(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FHBABNLPLHP() == this.FGHENLAPEJP;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000F9829 File Offset: 0x000F7A29
		internal bool MLFCBFDKEFL(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KOKALNHPMHH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000F97F0 File Offset: 0x000F79F0
		internal bool MMBKPPPDLNA(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KKFLFBNFJEH() == this.FGHENLAPEJP;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000F9888 File Offset: 0x000F7A88
		internal bool JNNKECDOEJE(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.CNBKFLLBENK() == this.FGHENLAPEJP;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000F98D4 File Offset: 0x000F7AD4
		internal bool LFOIECAENEC(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.DIONAAKDJMP() == this.FGHENLAPEJP;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000F9862 File Offset: 0x000F7A62
		internal bool JEFJLPJEEEJ(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NPFBBOHIDOG() == this.FGHENLAPEJP;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000F98E7 File Offset: 0x000F7AE7
		internal bool LJMHKAPAJMK(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.JGBBEABDAHL() == this.FGHENLAPEJP;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000F9816 File Offset: 0x000F7A16
		internal bool MHGBJMMGMAJ(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.DDAFPNIDGGJ() == this.FGHENLAPEJP;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000F98FA File Offset: 0x000F7AFA
		internal bool FBFOHGGICDO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.PIAKNGMFMNO() == this.FGHENLAPEJP;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000F97A4 File Offset: 0x000F79A4
		internal bool BAKCADHNOGO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.KLOHNCMBLCB() == this.FGHENLAPEJP;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000F983C File Offset: 0x000F7A3C
		internal bool DAGMNEJBHKD(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LNDBLBABCKC() == this.FGHENLAPEJP;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000F983C File Offset: 0x000F7A3C
		internal bool AJOAGBGAJBO(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.LNDBLBABCKC() == this.FGHENLAPEJP;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000F98D4 File Offset: 0x000F7AD4
		internal bool HIJPGFIMKAF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.DIONAAKDJMP() == this.FGHENLAPEJP;
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000F9791 File Offset: 0x000F7991
		internal bool JKAIKKBPGNM(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.FFHNDJMKCJF() == this.FGHENLAPEJP;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000F97CA File Offset: 0x000F79CA
		internal bool HHGFFBEHAHF(VPaintVertexCache MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IBCCHDHJENF() == this.FGHENLAPEJP;
		}

		// Token: 0x040003FD RID: 1021
		public VPaintObject FGHENLAPEJP;
	}
}
