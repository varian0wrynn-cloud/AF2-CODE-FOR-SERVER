using System;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002B4 RID: 692
	public class FogVolume : MonoBehaviour
	{
		// Token: 0x0600A289 RID: 41609 RVA: 0x0048C9EC File Offset: 0x0048ABEC
		private void FFJHELOMBDH(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IMBDNCJANDJ())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.GMGBEMOGJFA(this.transitionDuration);
			}
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x0048CA3C File Offset: 0x0048AC3C
		private void JMAKCGIPLIK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.PCPDJLEMNLK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.MKMCPAGDNHG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x0048CA98 File Offset: 0x0048AC98
		private void DHIAKKIOEAN(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x0048CAF4 File Offset: 0x0048ACF4
		private void FBAAKKLLHBG(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void ELCNJDNCAEP()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x0048CB54 File Offset: 0x0048AD54
		private void MBNHMKIOCAE(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.HNPBGHJLEJJ(this.transitionDuration);
			}
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x0048CBA4 File Offset: 0x0048ADA4
		private void AEJDHIFPNHP(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.GMGBEMOGJFA(this.transitionDuration);
			}
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void FGJCIEDDFGN()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x0048CC04 File Offset: 0x0048AE04
		private void IBFJAHODEIA(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.JOMILEKDBGK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.FKIIJJFGNIK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x0048CC60 File Offset: 0x0048AE60
		private void PGHOOLICGCI(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.EJPKCEPIPOL())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.MKMCPAGDNHG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x0048CCBC File Offset: 0x0048AEBC
		private void AKLHBDLPNFI(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x0048CD0C File Offset: 0x0048AF0C
		private void DDEBDCGNCPC()
		{
			this.ANCIMKLOHFH = DynamicFog.NBNCIFDAOAM();
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x0048CD19 File Offset: 0x0048AF19
		private void AFFAJKPPMHF()
		{
			this.ANCIMKLOHFH = DynamicFog.JDEFOBNPMON();
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x0048CD28 File Offset: 0x0048AF28
		private void OnTriggerExit(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x0048CD78 File Offset: 0x0048AF78
		private void GDNIJFHEBLE(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.EFKAIDLKODA(this.transitionDuration);
			}
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x0048CDC8 File Offset: 0x0048AFC8
		private void ODMEJNLPOAK(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.LHCFGKANGED(this.transitionDuration);
			}
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x0048CE18 File Offset: 0x0048B018
		private void INKLPCLOPBH(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.EJPKCEPIPOL())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x0048CE74 File Offset: 0x0048B074
		private void PEDNOGCIDBL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.DOBNPABDLAN(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x0048CED0 File Offset: 0x0048B0D0
		private void GDEGHNONPNM(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.CPNEFFMOLHM(this.transitionDuration);
			}
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x0048CF20 File Offset: 0x0048B120
		private void JCOMIMIEABJ(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.HNPBGHJLEJJ(this.transitionDuration);
			}
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x0048CF70 File Offset: 0x0048B170
		private void KBHDEFHDGLJ(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.DOBNPABDLAN(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x0048CFCC File Offset: 0x0048B1CC
		private void BNMGJPGGIJC(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.AGABOEMCPNG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x0048D028 File Offset: 0x0048B228
		private void FGEKGCEOFPL(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.GMGBEMOGJFA(this.transitionDuration);
			}
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x0048D078 File Offset: 0x0048B278
		private void EGLHCBDKCNK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x0048D0D4 File Offset: 0x0048B2D4
		private void EFGHFLECHGF(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.LHCFGKANGED(this.transitionDuration);
			}
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x0048D124 File Offset: 0x0048B324
		private void KAIMCIDMEKL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.LMIBJIMGAEA(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x0048D180 File Offset: 0x0048B380
		private void LANPGIPENBH(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.CPNEFFMOLHM(this.transitionDuration);
			}
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x0048D1D0 File Offset: 0x0048B3D0
		private void NKFPFHFCLMD(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.PEBDKKJCFFJ(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x0048D22C File Offset: 0x0048B42C
		private void LFCOHHFJIOL(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.PCPDJLEMNLK())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.EFKAIDLKODA(this.transitionDuration);
			}
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x0048D27C File Offset: 0x0048B47C
		private void MIJDNMGKOKP(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.MKMCPAGDNHG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void ADLHNBEDHMJ()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x0048D2D8 File Offset: 0x0048B4D8
		private void PDEJKMAKHBK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.PEBDKKJCFFJ(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x0048D334 File Offset: 0x0048B534
		private void HGAIDKCBAKE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IAEKKOIECNA())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.LMIBJIMGAEA(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x0048D390 File Offset: 0x0048B590
		private void CNBHPCDGIFH(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x0048D3EC File Offset: 0x0048B5EC
		private void BDOAHNKOKBP(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.JOMILEKDBGK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.HNPBGHJLEJJ(this.transitionDuration);
			}
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x0048D43C File Offset: 0x0048B63C
		private void OBJNKEHFHHG(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IAEKKOIECNA())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDENCPBLKLK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x0048CD19 File Offset: 0x0048AF19
		private void EFJDBBDMPMC()
		{
			this.ANCIMKLOHFH = DynamicFog.JDEFOBNPMON();
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x0048D498 File Offset: 0x0048B698
		private void PKEKPFCOOND(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IMBDNCJANDJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.PLEDELDFGOI(this.transitionDuration);
			}
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void LMEJKAEIDCO()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x0048D4E8 File Offset: 0x0048B6E8
		private void DHFHPMAHMGP(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.DOBNPABDLAN(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x0048D544 File Offset: 0x0048B744
		private void HDFCIACDDEK()
		{
			this.ANCIMKLOHFH = DynamicFog.COIPKPKLDAH;
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x0048CD0C File Offset: 0x0048AF0C
		private void PFNPOHMMJDN()
		{
			this.ANCIMKLOHFH = DynamicFog.NBNCIFDAOAM();
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x0048D554 File Offset: 0x0048B754
		private void OFBOOGHDLHP(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.AGABOEMCPNG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x0048D5B0 File Offset: 0x0048B7B0
		private void LGDLIMDGJDA(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IAEKKOIECNA())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDENCPBLKLK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x0048D60C File Offset: 0x0048B80C
		private void ECBGMAOFCBL(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NHIIIJJECAN())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.LHCFGKANGED(this.transitionDuration);
			}
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void BMNJGPIPKLL()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x0048CD19 File Offset: 0x0048AF19
		private void DGDGMFDPEHO()
		{
			this.ANCIMKLOHFH = DynamicFog.JDEFOBNPMON();
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x0048CD19 File Offset: 0x0048AF19
		private void OLBDJCFPKFG()
		{
			this.ANCIMKLOHFH = DynamicFog.JDEFOBNPMON();
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x0048D65C File Offset: 0x0048B85C
		private void HPILJDPOLFB(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x0048D6AC File Offset: 0x0048B8AC
		private void MPNNEKAFHBO(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.HNPBGHJLEJJ(this.transitionDuration);
			}
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void CLHGHANANNL()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void HEMEEOGJDOE()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x0048D6FC File Offset: 0x0048B8FC
		private void OHPJHDICJCA(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.LHCFGKANGED(this.transitionDuration);
			}
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x0048D74C File Offset: 0x0048B94C
		private void DDINGDJKKOC(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.JOMILEKDBGK())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.LMIBJIMGAEA(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x0048D7A8 File Offset: 0x0048B9A8
		private void NMHKBJJDEPA(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.AGABOEMCPNG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void LBEFOABPMFG()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x0048D804 File Offset: 0x0048BA04
		private void KOABECHGJGE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x0048D860 File Offset: 0x0048BA60
		private void AAHEPGADECN(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.JOMILEKDBGK())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.FKIIJJFGNIK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void FCCAIANLEFE()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x0048D8BC File Offset: 0x0048BABC
		private void IONDDMEDNNE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.MKMCPAGDNHG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x0048D944 File Offset: 0x0048BB44
		private void COLPPHAICAJ(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.DOBNPABDLAN(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x0048D9A0 File Offset: 0x0048BBA0
		private void BNJOJNAHJGC(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CPNEFFMOLHM(this.transitionDuration);
			}
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x0048D544 File Offset: 0x0048B744
		private void DHJDMKLBLEF()
		{
			this.ANCIMKLOHFH = DynamicFog.COIPKPKLDAH;
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		private void BGCLAKJHAFK()
		{
			this.ANCIMKLOHFH = DynamicFog.DHJNHDFOODE();
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x0048D9F0 File Offset: 0x0048BBF0
		private void HFJHCEKKIHC(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.EJPKCEPIPOL())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.GMGBEMOGJFA(this.transitionDuration);
			}
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0048DA40 File Offset: 0x0048BC40
		private void LOMPBIFDIDF(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IMBDNCJANDJ())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.EFKAIDLKODA(this.transitionDuration);
			}
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x0048DA90 File Offset: 0x0048BC90
		private void BBHNABKOAFC(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.CPNEFFMOLHM(this.transitionDuration);
			}
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0048DAE0 File Offset: 0x0048BCE0
		private void LMMKDJAIFOL(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.EFKAIDLKODA(this.transitionDuration);
			}
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x0048DB30 File Offset: 0x0048BD30
		private void PCMNKLGCGMK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.FKIIJJFGNIK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x0048DB8C File Offset: 0x0048BD8C
		private void COCNMKJNDBC(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.PLEDELDFGOI(this.transitionDuration);
			}
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x0048DBDC File Offset: 0x0048BDDC
		private void AMDDKDKBDHC(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IMBDNCJANDJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.FKIIJJFGNIK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x0048DC38 File Offset: 0x0048BE38
		private void AEIMGEFCGID(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.JOMILEKDBGK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.DOBNPABDLAN(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x0048DC94 File Offset: 0x0048BE94
		private void KNMKBONMKDE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NDIIHLFECLM())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.CDLDPBMBJEI(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x0048D544 File Offset: 0x0048B744
		private void PMDPLLIBJAF()
		{
			this.ANCIMKLOHFH = DynamicFog.COIPKPKLDAH;
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x0048CD0C File Offset: 0x0048AF0C
		private void ELFLOPJDAKK()
		{
			this.ANCIMKLOHFH = DynamicFog.NBNCIFDAOAM();
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x0048DCF0 File Offset: 0x0048BEF0
		private void AELBGHNFGHO(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.NCAJKCCEEGE())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.AGABOEMCPNG(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x0048DD4C File Offset: 0x0048BF4C
		private void MHGGBNCPFHK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.FKIIJJFGNIK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x0048D544 File Offset: 0x0048B744
		private void KGICJDGIIJK()
		{
			this.ANCIMKLOHFH = DynamicFog.COIPKPKLDAH;
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x0048DDA8 File Offset: 0x0048BFA8
		private void GPOJMKLGNMP(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.LMIBJIMGAEA(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void DMAOHJDKMNN()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x0048DE04 File Offset: 0x0048C004
		private void HBONJDAEONE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.PCPDJLEMNLK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.LMIBJIMGAEA(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x0048D544 File Offset: 0x0048B744
		private void Start()
		{
			this.ANCIMKLOHFH = DynamicFog.COIPKPKLDAH;
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x0048CB44 File Offset: 0x0048AD44
		private void MMACLBBMDLA()
		{
			this.ANCIMKLOHFH = DynamicFog.LLGJHCCPEOI();
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x0048DE60 File Offset: 0x0048C060
		private void ABHIFFDKAJG(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.PCPDJLEMNLK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.CDENCPBLKLK(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x0048DEBC File Offset: 0x0048C0BC
		private void OnTriggerEnter(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x0048DF18 File Offset: 0x0048C118
		private void DLLPDPFOINE(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.PCPDJLEMNLK())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.CPNEFFMOLHM(this.transitionDuration);
			}
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x0048DF68 File Offset: 0x0048C168
		private void NFAKFPJMEEK(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.LHMOAFLBACD())
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.HNPBGHJLEJJ(this.transitionDuration);
			}
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x0048CD0C File Offset: 0x0048AF0C
		private void INDGOHJGCFN()
		{
			this.ANCIMKLOHFH = DynamicFog.NBNCIFDAOAM();
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x0048DFB8 File Offset: 0x0048C1B8
		private void GLBECKMNECL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.EJPKCEPIPOL())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x0048CD19 File Offset: 0x0048AF19
		private void CPNOBMNKPNC()
		{
			this.ANCIMKLOHFH = DynamicFog.JDEFOBNPMON();
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x0048E014 File Offset: 0x0048C214
		private void DOMGIINMCIJ(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.IJBJAIMOBPJ())
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x04001500 RID: 5376
		[Range(0f, 1f)]
		[Tooltip("Target alpha for fog when camera enters this fog volume")]
		public float targetFogAlpha = 0.5f;

		// Token: 0x04001501 RID: 5377
		[Range(0f, 1f)]
		[Tooltip("Target alpha for sky haze when camera enters this fog volume")]
		public float targetSkyHazeAlpha = 0.5f;

		// Token: 0x04001502 RID: 5378
		[Tooltip("Set this to zero for changing fog alpha immediately upon enter/exit fog volume.")]
		public float transitionDuration = 3f;

		// Token: 0x04001503 RID: 5379
		private DynamicFog ANCIMKLOHFH;

		// Token: 0x04001504 RID: 5380
		private bool NHGOCNNCFGD;
	}
}
