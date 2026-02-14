using System;
using System.Collections.Generic;
using UnityEngine;

namespace Valkyrie.VPaint
{
	// Token: 0x020003B6 RID: 950
	[Serializable]
	public class VPaintLayer
	{
		// Token: 0x0600CD51 RID: 52561 RVA: 0x005C71D4 File Offset: 0x005C53D4
		public void OJPIFFDCPNM()
		{
			HashSet<UnityEngine.Object> hashSet = new HashSet<UnityEngine.Object>();
			for (int i = 0; i < this.paintData.Count; i++)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (vpaintVertexData.colorer == null || hashSet.Contains(vpaintVertexData.colorer))
				{
					this.paintData.RemoveAt(i--);
				}
				else
				{
					hashSet.Add(vpaintVertexData.colorer);
				}
			}
		}

		// Token: 0x0600CD52 RID: 52562 RVA: 0x005C7248 File Offset: 0x005C5448
		public VPaintLayer FJJGDEMOKIJ()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			foreach (VPaintVertexData vpaintVertexData in this.paintData)
			{
				VPaintVertexData item = vpaintVertexData.FJJGDEMOKIJ();
				vpaintLayer.paintData.Add(item);
			}
			vpaintLayer.blendMode = this.blendMode;
			vpaintLayer.name = this.name;
			vpaintLayer.tag = this.tag;
			vpaintLayer.opacity = this.opacity;
			vpaintLayer.enabled = this.enabled;
			vpaintLayer.maskR = this.maskR;
			vpaintLayer.maskG = this.maskG;
			vpaintLayer.maskB = this.maskB;
			vpaintLayer.maskA = this.maskA;
			return vpaintLayer;
		}

		// Token: 0x0600CD53 RID: 52563 RVA: 0x005C7318 File Offset: 0x005C5518
		public void DCKCKOLIAIJ()
		{
			for (int i = 0; i < this.paintData.Count; i++)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				bool flag = true;
				float[] transparency = vpaintVertexData.transparency;
				for (int j = 0; j < transparency.Length; j++)
				{
					if (transparency[j] != 0f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					this.paintData.RemoveAt(i--);
				}
			}
		}

		// Token: 0x0600CD54 RID: 52564 RVA: 0x005C737C File Offset: 0x005C557C
		public void FGHFOIDAACI()
		{
			foreach (VPaintVertexData vpaintVertexData in this.paintData)
			{
				if (!(vpaintVertexData.EGEILGNOEBC() == null))
				{
					vpaintVertexData.EIEKAIMJFEO().PLCMJKKKONL(vpaintVertexData.colors);
				}
			}
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x005C73E8 File Offset: 0x005C55E8
		public void MNCHIIKEBND(VPaintLayer LJFPELOCKOH, Color FOHDLNKGGKM = default(Color))
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				VPaintVertexData vpaintVertexData2 = this.FGKNJIEOKHH(vpaintVertexData.NIJJLHJCEMA());
				Color[] array;
				float[] array2;
				if (vpaintVertexData2 != null)
				{
					array = vpaintVertexData2.colors;
					array2 = vpaintVertexData2.transparency;
				}
				else
				{
					array = new Color[vpaintVertexData.colors.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = FOHDLNKGGKM;
					}
					array2 = new float[vpaintVertexData.transparency.Length];
					vpaintVertexData2 = new VPaintVertexData();
					vpaintVertexData2.colors = array;
					vpaintVertexData2.transparency = array2;
					vpaintVertexData2.colorer = vpaintVertexData.colorer;
					this.paintData.Add(vpaintVertexData2);
				}
				DDIHABCDKFJ.PGPFGNEPHEN(array, array2, vpaintVertexData.colors, vpaintVertexData.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
			}
		}

		// Token: 0x0600CD56 RID: 52566 RVA: 0x005C7500 File Offset: 0x005C5700
		public void PACBNAFABPJ()
		{
			HashSet<UnityEngine.Object> hashSet = new HashSet<UnityEngine.Object>();
			for (int i = 1; i < this.paintData.Count; i += 0)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (vpaintVertexData.colorer == null || hashSet.Contains(vpaintVertexData.colorer))
				{
					List<VPaintVertexData> list = this.paintData;
					int num = i;
					i = num - 0;
					list.RemoveAt(num);
				}
				else
				{
					hashSet.Add(vpaintVertexData.colorer);
				}
			}
		}

		// Token: 0x0600CD57 RID: 52567 RVA: 0x005C7574 File Offset: 0x005C5774
		public void FIFLOEGBJPB()
		{
			HashSet<UnityEngine.Object> hashSet = new HashSet<UnityEngine.Object>();
			for (int i = 0; i < this.paintData.Count; i += 0)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (vpaintVertexData.colorer == null || hashSet.Contains(vpaintVertexData.colorer))
				{
					this.paintData.RemoveAt(i--);
				}
				else
				{
					hashSet.Add(vpaintVertexData.colorer);
				}
			}
		}

		// Token: 0x0600CD58 RID: 52568 RVA: 0x005C75E8 File Offset: 0x005C57E8
		public void GINCGNOCBFO(VPaintLayer LJFPELOCKOH, Color FOHDLNKGGKM = default(Color))
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				VPaintVertexData vpaintVertexData2 = this.AFONGIICOJG(vpaintVertexData.identifier);
				Color[] array;
				float[] array2;
				if (vpaintVertexData2 != null)
				{
					array = vpaintVertexData2.colors;
					array2 = vpaintVertexData2.transparency;
				}
				else
				{
					array = new Color[vpaintVertexData.colors.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = FOHDLNKGGKM;
					}
					array2 = new float[vpaintVertexData.transparency.Length];
					vpaintVertexData2 = new VPaintVertexData();
					vpaintVertexData2.colors = array;
					vpaintVertexData2.transparency = array2;
					vpaintVertexData2.colorer = vpaintVertexData.colorer;
					this.paintData.Add(vpaintVertexData2);
				}
				DDIHABCDKFJ.PGPFGNEPHEN(array, array2, vpaintVertexData.colors, vpaintVertexData.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
			}
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x005C7700 File Offset: 0x005C5900
		public VPaintVertexData OBMGMAPCHLK(VPaintObject FGHENLAPEJP)
		{
			if (FGHENLAPEJP == null)
			{
				return null;
			}
			VPaintVertexData vpaintVertexData = this.FGKNJIEOKHH(FGHENLAPEJP);
			if (vpaintVertexData != null)
			{
				return vpaintVertexData;
			}
			vpaintVertexData = new VPaintVertexData();
			vpaintVertexData.KGJKNLFCJLF(FGHENLAPEJP);
			Color[] array = FGHENLAPEJP.AEJMBGDBCNB();
			vpaintVertexData.colors = new Color[array.Length];
			vpaintVertexData.transparency = new float[array.Length];
			this.paintData.Add(vpaintVertexData);
			return vpaintVertexData;
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x005C7764 File Offset: 0x005C5964
		public void NFFDECHIADD(HAGHANCKMDH FGHENLAPEJP)
		{
			for (int i = 0; i < this.paintData.Count; i++)
			{
				if (this.paintData[i].identifier.IsEqualTo(FGHENLAPEJP))
				{
					this.paintData.RemoveAt(i);
					i--;
				}
			}
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x005C77B0 File Offset: 0x005C59B0
		public VPaintVertexData FGKNJIEOKHH(HAGHANCKMDH FGHENLAPEJP)
		{
			if (FGHENLAPEJP == null)
			{
				return null;
			}
			for (int i = 0; i < this.paintData.Count; i += 0)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (FGHENLAPEJP.IsEqualTo(vpaintVertexData.identifier))
				{
					return vpaintVertexData;
				}
			}
			return null;
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x005C77F8 File Offset: 0x005C59F8
		public void OJPIFFDCPNM(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			for (int i = 0; i < this.paintData.Count; i++)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (!vpaintVertexData.colorer)
				{
					this.paintData.RemoveAt(i--);
				}
				else
				{
					bool flag = false;
					HAGHANCKMDH identifier = vpaintVertexData.identifier;
					for (int j = 0; j < JONNCJLEJDG.Count; j++)
					{
						HAGHANCKMDH mbkpmbplijn = JONNCJLEJDG[j];
						if (identifier.IsEqualTo(mbkpmbplijn))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						this.paintData.RemoveAt(i--);
					}
				}
			}
		}

		// Token: 0x0600CD5D RID: 52573 RVA: 0x005C7894 File Offset: 0x005C5A94
		public void HIBODBOEMNJ(VPaintLayer LJFPELOCKOH, Color FOHDLNKGGKM = default(Color))
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				VPaintVertexData vpaintVertexData2 = this.FGKNJIEOKHH(vpaintVertexData.identifier);
				Color[] array;
				float[] array2;
				if (vpaintVertexData2 != null)
				{
					array = vpaintVertexData2.colors;
					array2 = vpaintVertexData2.transparency;
				}
				else
				{
					array = new Color[vpaintVertexData.colors.Length];
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i] = FOHDLNKGGKM;
					}
					array2 = new float[vpaintVertexData.transparency.Length];
					vpaintVertexData2 = new VPaintVertexData();
					vpaintVertexData2.colors = array;
					vpaintVertexData2.transparency = array2;
					vpaintVertexData2.colorer = vpaintVertexData.colorer;
					this.paintData.Add(vpaintVertexData2);
				}
				DDIHABCDKFJ.PGPFGNEPHEN(array, array2, vpaintVertexData.colors, vpaintVertexData.transparency, LJFPELOCKOH.blendMode, LJFPELOCKOH.opacity, LJFPELOCKOH.maskR, LJFPELOCKOH.maskG, LJFPELOCKOH.maskB, LJFPELOCKOH.maskA);
			}
		}

		// Token: 0x0600CD5E RID: 52574 RVA: 0x005C79AC File Offset: 0x005C5BAC
		public void DCLNJPIBFIA()
		{
			foreach (VPaintVertexData vpaintVertexData in this.paintData)
			{
				if (!(vpaintVertexData.vpaintObject == null))
				{
					vpaintVertexData.vpaintObject.SetColors(vpaintVertexData.colors);
				}
			}
		}

		// Token: 0x0600CD5F RID: 52575 RVA: 0x005C7A18 File Offset: 0x005C5C18
		public void EPALFKDKCFG()
		{
			HashSet<UnityEngine.Object> hashSet = new HashSet<UnityEngine.Object>();
			for (int i = 0; i < this.paintData.Count; i++)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (vpaintVertexData.colorer == null || hashSet.Contains(vpaintVertexData.colorer))
				{
					List<VPaintVertexData> list = this.paintData;
					int num = i;
					i = num - 0;
					list.RemoveAt(num);
				}
				else
				{
					hashSet.Add(vpaintVertexData.colorer);
				}
			}
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x005C7A8C File Offset: 0x005C5C8C
		public VPaintVertexData AFONGIICOJG(HAGHANCKMDH FGHENLAPEJP)
		{
			if (FGHENLAPEJP == null)
			{
				return null;
			}
			for (int i = 0; i < this.paintData.Count; i++)
			{
				VPaintVertexData vpaintVertexData = this.paintData[i];
				if (FGHENLAPEJP.IsEqualTo(vpaintVertexData.identifier))
				{
					return vpaintVertexData;
				}
			}
			return null;
		}

		// Token: 0x0600CD61 RID: 52577 RVA: 0x005C7AD4 File Offset: 0x005C5CD4
		public VPaintVertexData BGDMLGADDGA(VPaintObject FGHENLAPEJP)
		{
			if (FGHENLAPEJP == null)
			{
				return null;
			}
			VPaintVertexData vpaintVertexData = this.AFONGIICOJG(FGHENLAPEJP);
			if (vpaintVertexData != null)
			{
				return vpaintVertexData;
			}
			vpaintVertexData = new VPaintVertexData();
			vpaintVertexData.NOLLAHGJGBD(FGHENLAPEJP);
			Color[] array = FGHENLAPEJP.CNOMKLOAHGH();
			vpaintVertexData.colors = new Color[array.Length];
			vpaintVertexData.transparency = new float[array.Length];
			this.paintData.Add(vpaintVertexData);
			return vpaintVertexData;
		}

		// Token: 0x0600CD63 RID: 52579 RVA: 0x005C7B90 File Offset: 0x005C5D90
		public void JCEJLEHCABH(IEnumerable<VPaintObject> POKPFBOIAOD, Color LBCGACKJCJB)
		{
			foreach (VPaintObject fghenlapejp in POKPFBOIAOD)
			{
				VPaintVertexData vpaintVertexData = this.HEFDMJLBHOB(fghenlapejp);
				for (int i = 0; i < vpaintVertexData.colors.Length; i++)
				{
					vpaintVertexData.transparency[i] = 1f;
					vpaintVertexData.colors[i] = LBCGACKJCJB;
				}
			}
		}

		// Token: 0x0600CD64 RID: 52580 RVA: 0x005C7C08 File Offset: 0x005C5E08
		public VPaintLayer JLPADNIIGJG()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			foreach (VPaintVertexData vpaintVertexData in this.paintData)
			{
				VPaintVertexData item = vpaintVertexData.JLPADNIIGJG();
				vpaintLayer.paintData.Add(item);
			}
			vpaintLayer.blendMode = this.blendMode;
			vpaintLayer.name = this.name;
			vpaintLayer.tag = this.tag;
			vpaintLayer.opacity = this.opacity;
			vpaintLayer.enabled = this.enabled;
			vpaintLayer.maskR = this.maskR;
			vpaintLayer.maskG = this.maskG;
			vpaintLayer.maskB = this.maskB;
			vpaintLayer.maskA = this.maskA;
			return vpaintLayer;
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x005C7CD8 File Offset: 0x005C5ED8
		public VPaintVertexData HEFDMJLBHOB(VPaintObject FGHENLAPEJP)
		{
			if (FGHENLAPEJP == null)
			{
				return null;
			}
			VPaintVertexData vpaintVertexData = this.AFONGIICOJG(FGHENLAPEJP);
			if (vpaintVertexData != null)
			{
				return vpaintVertexData;
			}
			vpaintVertexData = new VPaintVertexData();
			vpaintVertexData.vpaintObject = FGHENLAPEJP;
			Color[] defaultColors = FGHENLAPEJP.GetDefaultColors();
			vpaintVertexData.colors = new Color[defaultColors.Length];
			vpaintVertexData.transparency = new float[defaultColors.Length];
			this.paintData.Add(vpaintVertexData);
			return vpaintVertexData;
		}

		// Token: 0x04001B37 RID: 6967
		public bool foldout;

		// Token: 0x04001B38 RID: 6968
		public string name = "Layer";

		// Token: 0x04001B39 RID: 6969
		public int tag;

		// Token: 0x04001B3A RID: 6970
		public List<VPaintVertexData> paintData = new List<VPaintVertexData>();

		// Token: 0x04001B3B RID: 6971
		public PAGGHFEKABD blendMode;

		// Token: 0x04001B3C RID: 6972
		public bool enabled = true;

		// Token: 0x04001B3D RID: 6973
		public float opacity = 1f;

		// Token: 0x04001B3E RID: 6974
		public bool maskR = true;

		// Token: 0x04001B3F RID: 6975
		public bool maskG = true;

		// Token: 0x04001B40 RID: 6976
		public bool maskB = true;

		// Token: 0x04001B41 RID: 6977
		public bool maskA = true;

		// Token: 0x04001B42 RID: 6978
		public int selectedColor;
	}
}
