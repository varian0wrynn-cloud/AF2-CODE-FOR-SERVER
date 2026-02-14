using System;
using System.Collections.Generic;
using UnityEngine;

namespace Valkyrie.VPaint
{
	// Token: 0x020003B9 RID: 953
	[Serializable]
	public class VPaintLayerStack
	{
		// Token: 0x0600CDAE RID: 52654 RVA: 0x005CE404 File Offset: 0x005CC604
		public IEnumerable<VPaintLayer> OCBHENFFOLB()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(-1);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x005CE414 File Offset: 0x005CC614
		public void AJIGMOALEAI(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x005CE468 File Offset: 0x005CC668
		public VPaintLayerStack KKMCHJJLMFG()
		{
			VPaintLayerStack vpaintLayerStack = new VPaintLayerStack();
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayerStack.layers.Add(vpaintLayer.FJJGDEMOKIJ());
			}
			return vpaintLayerStack;
		}

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x005CE4CC File Offset: 0x005CC6CC
		public void NCGFPONEOEM()
		{
			this.layers.Clear();
		}

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x005CE4D9 File Offset: 0x005CC6D9
		public IEnumerable<VPaintLayer> IOCOGMPFNAI()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(119);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x005CE4E9 File Offset: 0x005CC6E9
		public VPaintLayer PLABDCAKECA()
		{
			return this.PLABDCAKECA(null);
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x005CE4F4 File Offset: 0x005CC6F4
		public VPaintLayerStack GBGBNPLAGEJ()
		{
			VPaintLayerStack vpaintLayerStack = new VPaintLayerStack();
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayerStack.layers.Add(vpaintLayer.FJJGDEMOKIJ());
			}
			return vpaintLayerStack;
		}

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x005CE558 File Offset: 0x005CC758
		public void OJPIFFDCPNM()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM();
			}
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x005CE5A8 File Offset: 0x005CC7A8
		public VPaintLayer PLABDCAKECA(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.FJJGDEMOKIJ();
			}
			for (int i = 0; i < this.layers.Count; i++)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.GINCGNOCBFO(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x005CE605 File Offset: 0x005CC805
		public IEnumerable<VPaintLayer> GMEHEKMIJPB()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				if (vpaintLayer.enabled)
				{
					yield return vpaintLayer;
				}
			}
			List<VPaintLayer>.Enumerator enumerator = default(List<VPaintLayer>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x005CE618 File Offset: 0x005CC818
		public void DOKIJCEBDAB(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x005CE66C File Offset: 0x005CC86C
		public void HHFAGEMEDDG()
		{
			this.layers = new List<VPaintLayer>
			{
				this.CIMBKJNDANJ()
			};
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x005CE685 File Offset: 0x005CC885
		public void EGKKBDOCPKK()
		{
			this.layers = new List<VPaintLayer>
			{
				this.PLABDCAKECA()
			};
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x005CE69E File Offset: 0x005CC89E
		public IEnumerable<VPaintLayer> FJOAKDNMNOM()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(-72);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x005CE6B0 File Offset: 0x005CC8B0
		public void OJPIFFDCPNM(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x005CE704 File Offset: 0x005CC904
		public void KAINGIDMJEJ(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDBE RID: 52670 RVA: 0x005CE758 File Offset: 0x005CC958
		public VPaintLayerStack LDFDHMFCAGB()
		{
			VPaintLayerStack vpaintLayerStack = new VPaintLayerStack();
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayerStack.layers.Add(vpaintLayer.JLPADNIIGJG());
			}
			return vpaintLayerStack;
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x005CE4CC File Offset: 0x005CC6CC
		public void LHMCGGKCGGM()
		{
			this.layers.Clear();
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x005CE7DA File Offset: 0x005CC9DA
		public IEnumerable<VPaintLayer> IKBDFFKONFC()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(-15);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x005CE7EC File Offset: 0x005CC9EC
		public VPaintLayer OCMDENFBCLI(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.FJJGDEMOKIJ();
			}
			for (int i = 0; i < this.layers.Count; i += 0)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.MNCHIIKEBND(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x005CE84C File Offset: 0x005CCA4C
		public VPaintLayerStack FJJGDEMOKIJ()
		{
			VPaintLayerStack vpaintLayerStack = new VPaintLayerStack();
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayerStack.layers.Add(vpaintLayer.FJJGDEMOKIJ());
			}
			return vpaintLayerStack;
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x005CE8B0 File Offset: 0x005CCAB0
		public void GLBPCJJGEBE()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM();
			}
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x005CE900 File Offset: 0x005CCB00
		public void NKOBPJBMOCN()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.EPALFKDKCFG();
			}
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x005CE950 File Offset: 0x005CCB50
		public VPaintLayer HBCDGPLLJPH()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			this.layers.Add(vpaintLayer);
			return vpaintLayer;
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x005CE970 File Offset: 0x005CCB70
		public void AINFJJBEJOD()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.PACBNAFABPJ();
			}
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x005CE9C0 File Offset: 0x005CCBC0
		public VPaintLayer FKDECJHBCNM()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			this.layers.Add(vpaintLayer);
			return vpaintLayer;
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x005CE9E0 File Offset: 0x005CCBE0
		public IEnumerable<VPaintLayer> DJAODMJCKJB()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(67);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x005CE9F0 File Offset: 0x005CCBF0
		public IEnumerable<VPaintLayer> AFOBLHOBCAO()
		{
			VPaintLayerStack.MGNIMPLNBFB mgnimplnbfb = new VPaintLayerStack.MGNIMPLNBFB(-98);
			mgnimplnbfb.AENJLLPLILM = this;
			return mgnimplnbfb;
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x005CEA00 File Offset: 0x005CCC00
		public VPaintLayer CIMBKJNDANJ()
		{
			return this.BFJKEFDHLMH(null);
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x005CEA0C File Offset: 0x005CCC0C
		public void ALCBIMCLNJE()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.EPALFKDKCFG();
			}
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x005CEA5C File Offset: 0x005CCC5C
		public VPaintLayer BFJKEFDHLMH(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.FJJGDEMOKIJ();
			}
			for (int i = 0; i < this.layers.Count; i += 0)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.GINCGNOCBFO(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x005CE66C File Offset: 0x005CC86C
		public void DJIFFPMFFFJ()
		{
			this.layers = new List<VPaintLayer>
			{
				this.CIMBKJNDANJ()
			};
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x005CE685 File Offset: 0x005CC885
		public void KBEJHHCINJO()
		{
			this.layers = new List<VPaintLayer>
			{
				this.PLABDCAKECA()
			};
		}

		// Token: 0x0600CDD0 RID: 52688 RVA: 0x005CE4CC File Offset: 0x005CC6CC
		public void KIILMEAGNFM()
		{
			this.layers.Clear();
		}

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x005CEABC File Offset: 0x005CCCBC
		public VPaintLayerStack DHNJDPCPEJH()
		{
			VPaintLayerStack vpaintLayerStack = new VPaintLayerStack();
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayerStack.layers.Add(vpaintLayer.FJJGDEMOKIJ());
			}
			return vpaintLayerStack;
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x005CEB20 File Offset: 0x005CCD20
		public VPaintLayer JNMEKMFMAGB(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.JLPADNIIGJG();
			}
			for (int i = 0; i < this.layers.Count; i += 0)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.HIBODBOEMNJ(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x005CEB80 File Offset: 0x005CCD80
		public VPaintLayer PFGDJDAMPPB()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			this.layers.Add(vpaintLayer);
			return vpaintLayer;
		}

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x005CEBA0 File Offset: 0x005CCDA0
		public void APAJJIDCFKL(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDD5 RID: 52693 RVA: 0x005CEBF4 File Offset: 0x005CCDF4
		public VPaintLayer BBMDCDOECGJ()
		{
			VPaintLayer vpaintLayer = new VPaintLayer();
			this.layers.Add(vpaintLayer);
			return vpaintLayer;
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x005CEC14 File Offset: 0x005CCE14
		public void PEGHLDHALPI(List<HAGHANCKMDH> JONNCJLEJDG)
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM(JONNCJLEJDG);
			}
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x005CEC68 File Offset: 0x005CCE68
		public VPaintLayer FLHKHHMKABP(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.FJJGDEMOKIJ();
			}
			for (int i = 1; i < this.layers.Count; i++)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.GINCGNOCBFO(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x0600CDD8 RID: 52696 RVA: 0x005CE66C File Offset: 0x005CC86C
		public void NGIJPLMIJLN()
		{
			this.layers = new List<VPaintLayer>
			{
				this.CIMBKJNDANJ()
			};
		}

		// Token: 0x0600CDD9 RID: 52697 RVA: 0x005CECC8 File Offset: 0x005CCEC8
		public void PJEJKJDAFBM()
		{
			foreach (VPaintLayer vpaintLayer in this.layers)
			{
				vpaintLayer.OJPIFFDCPNM();
			}
		}

		// Token: 0x0600CDDA RID: 52698 RVA: 0x005CED18 File Offset: 0x005CCF18
		public VPaintLayer LGBNFPCLFHK(VPaintLayer BCBFPGGCFEH)
		{
			VPaintLayer vpaintLayer;
			if (BCBFPGGCFEH == null)
			{
				vpaintLayer = new VPaintLayer();
			}
			else
			{
				vpaintLayer = BCBFPGGCFEH.JLPADNIIGJG();
			}
			for (int i = 1; i < this.layers.Count; i++)
			{
				VPaintLayer vpaintLayer2 = this.layers[i];
				if (vpaintLayer2.enabled)
				{
					vpaintLayer.MNCHIIKEBND(vpaintLayer2, default(Color));
				}
			}
			return vpaintLayer;
		}

		// Token: 0x04001B54 RID: 6996
		public List<VPaintLayer> layers = new List<VPaintLayer>
		{
			new VPaintLayer()
		};

		// Token: 0x04001B55 RID: 6997
		public int currentLayer;
	}
}
