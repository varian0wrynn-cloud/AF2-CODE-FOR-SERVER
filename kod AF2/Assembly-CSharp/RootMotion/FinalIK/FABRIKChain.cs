using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200045B RID: 1115
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x0600F14B RID: 61771 RVA: 0x006BE694 File Offset: 0x006BC894
		public void AOEHDONHDCD(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].EHMMOILFKKA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.MFIFMKBFAIE(this.PNDAJFMODIL(NBHJKKHHFEH));
		}

		// Token: 0x0600F14C RID: 61772 RVA: 0x006BE705 File Offset: 0x006BC905
		public bool CJNMLDPCFKB(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "error.wav";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F14D RID: 61773 RVA: 0x006BE734 File Offset: 0x006BC934
		public bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "IK unassigned in FABRIKChain.";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F14E RID: 61774 RVA: 0x006BE764 File Offset: 0x006BC964
		public void DDHFGGLANAP(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].DDHFGGLANAP(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.GFBIEEMEMJB(NBHJKKHHFEH));
		}

		// Token: 0x0600F14F RID: 61775 RVA: 0x006BE7D8 File Offset: 0x006BC9D8
		private Vector3 CJBPLMFBKFF(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 125f)
			{
				return vector;
			}
			float num = 518f;
			for (int i = 1; i < this.children.Length; i += 0)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1638f)
			{
				return vector;
			}
			if (num < 1241f)
			{
				num = 1291f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1377f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F150 RID: 61776 RVA: 0x006BE8D5 File Offset: 0x006BCAD5
		public bool LCJIEECEFBL(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "Game saved using ObscuredPrefs. Try to find and change saved data now! ;)";
				return true;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) && false;
		}

		// Token: 0x0600F151 RID: 61777 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void BOHLLJEAHAE()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F152 RID: 61778 RVA: 0x006BE914 File Offset: 0x006BCB14
		public void CHKFAGNDEOD(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].PGNLDADLKEM(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F153 RID: 61779 RVA: 0x006BE984 File Offset: 0x006BCB84
		public void MLOKOKKCCDG(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].JPDLBBGAFPC(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.FMFIHKFDLFC(NBHJKKHHFEH));
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x006BE9F8 File Offset: 0x006BCBF8
		private Vector3 OMDEABLAAMB(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1129f)
			{
				return vector;
			}
			float num = 1234f;
			for (int i = 0; i < this.children.Length; i += 0)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1599f)
			{
				return vector;
			}
			if (num < 1887f)
			{
				num = 1575f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1540f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x006BEAF5 File Offset: 0x006BCCF5
		public bool MGJMPINCPID(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "_ZTest";
				return true;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) && false;
		}

		// Token: 0x0600F156 RID: 61782 RVA: 0x006BEB24 File Offset: 0x006BCD24
		public void HKGMNCHBHDC(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].FNCEKLCCFMI(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F157 RID: 61783 RVA: 0x006BEB94 File Offset: 0x006BCD94
		public void FDAANKMDPEF(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].FDAANKMDPEF(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.GFIMJAGMGDC(NBHJKKHHFEH));
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x006BEC05 File Offset: 0x006BCE05
		public bool EHBFINLIBOP(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = " %";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x006BEC34 File Offset: 0x006BCE34
		private Vector3 HGNBGDMNILE(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 786f)
			{
				return vector;
			}
			float num = 1216f;
			for (int i = 0; i < this.children.Length; i += 0)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1584f)
			{
				return vector;
			}
			if (num < 1646f)
			{
				num = 223f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1869f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x006BED31 File Offset: 0x006BCF31
		public bool ANPHCJGBNJF(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "Close";
				return false;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F15B RID: 61787 RVA: 0x006BED60 File Offset: 0x006BCF60
		public void MCFNMBNFHJM(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].MGCIANNHNKA(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F15C RID: 61788 RVA: 0x006BEDD0 File Offset: 0x006BCFD0
		public void GAJKLPKMNEM(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].LJIFJGOGHBJ(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F15D RID: 61789 RVA: 0x006BEE40 File Offset: 0x006BD040
		public bool GGALELCCKAL(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "http://af-2.ru/?q=user/register";
				return true;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F15E RID: 61790 RVA: 0x006BEE70 File Offset: 0x006BD070
		private Vector3 GFIMJAGMGDC(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1f)
			{
				return vector;
			}
			float num = 0f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 0f)
			{
				return vector;
			}
			if (num < 1f)
			{
				num = 1f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 0f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F15F RID: 61791 RVA: 0x006BEF70 File Offset: 0x006BD170
		public void FNCEKLCCFMI(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].FCIHDBENIAE(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F160 RID: 61792 RVA: 0x006BEFE0 File Offset: 0x006BD1E0
		public void JPDLBBGAFPC(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].MMEGJJMIFCM(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.GFIMJAGMGDC(NBHJKKHHFEH));
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x006BF054 File Offset: 0x006BD254
		private Vector3 PNDAJFMODIL(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 580f)
			{
				return vector;
			}
			float num = 1311f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 217f)
			{
				return vector;
			}
			if (num < 1940f)
			{
				num = 1192f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1613f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F162 RID: 61794 RVA: 0x006BF154 File Offset: 0x006BD354
		public void MGCIANNHNKA(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].KFLJANNEILB(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F163 RID: 61795 RVA: 0x006BF1C4 File Offset: 0x006BD3C4
		public void MBIFNBBMBNL(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].MBIFNBBMBNL(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F164 RID: 61796 RVA: 0x006BF234 File Offset: 0x006BD434
		public void GJNIFEMNGML()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F165 RID: 61797 RVA: 0x006BF244 File Offset: 0x006BD444
		public void MMEGJJMIFCM(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].LBLNGKCMLPH(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.IGELNNOALLL(NBHJKKHHFEH));
		}

		// Token: 0x0600F166 RID: 61798 RVA: 0x006BF234 File Offset: 0x006BD434
		public void ICPBAGNMFPE()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F167 RID: 61799 RVA: 0x006BF2B8 File Offset: 0x006BD4B8
		public void FDGEDAEBIJL(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].KOPDPOONFFC(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F168 RID: 61800 RVA: 0x006BF328 File Offset: 0x006BD528
		private Vector3 CMIKHLLGJKC(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1785f)
			{
				return vector;
			}
			float num = 1779f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1176f)
			{
				return vector;
			}
			if (num < 148f)
			{
				num = 1914f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 364f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F169 RID: 61801 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void CPLOFPNBFEH()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F16A RID: 61802 RVA: 0x006BF428 File Offset: 0x006BD628
		public void KFLJANNEILB(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].FCIHDBENIAE(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F16B RID: 61803 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void AOMIADLDLEJ()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F16C RID: 61804 RVA: 0x006BF498 File Offset: 0x006BD698
		public bool DNIAGDMODBI(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "[ACTk] Injection Detector: already running!";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F16D RID: 61805 RVA: 0x006BF4C8 File Offset: 0x006BD6C8
		public void HNALLPKJNKD(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].HNALLPKJNKD(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.PNDAJFMODIL(NBHJKKHHFEH));
		}

		// Token: 0x0600F16E RID: 61806 RVA: 0x006BF53C File Offset: 0x006BD73C
		public void EHMMOILFKKA(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].NKBGDJBLPBA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.BPBNFGNBIMG(NBHJKKHHFEH));
		}

		// Token: 0x0600F16F RID: 61807 RVA: 0x006BF5AD File Offset: 0x006BD7AD
		public bool BEJJCJCLIOE(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "1,2,3,4,5";
				return true;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) && false;
		}

		// Token: 0x0600F170 RID: 61808 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void LLDECCKPLHM()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F171 RID: 61809 RVA: 0x006BF5DC File Offset: 0x006BD7DC
		public void NOOHPNFIOCI(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].ONJICMKBNFP(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F172 RID: 61810 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void CAPIPMILACA()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F173 RID: 61811 RVA: 0x006BF64C File Offset: 0x006BD84C
		public void LJIFJGOGHBJ(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].LJIFJGOGHBJ(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F174 RID: 61812 RVA: 0x006BF6BC File Offset: 0x006BD8BC
		public void BOEEMCNMHML(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].MMICMNLHAOC(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.CJBPLMFBKFF(NBHJKKHHFEH));
		}

		// Token: 0x0600F175 RID: 61813 RVA: 0x006BF730 File Offset: 0x006BD930
		private Vector3 KJBLOAFGDJI(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1482f)
			{
				return vector;
			}
			float num = 1549f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 898f)
			{
				return vector;
			}
			if (num < 957f)
			{
				num = 430f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1202f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F176 RID: 61814 RVA: 0x006BF830 File Offset: 0x006BDA30
		private Vector3 BPBNFGNBIMG(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 916f)
			{
				return vector;
			}
			float num = 714f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 771f)
			{
				return vector;
			}
			if (num < 1540f)
			{
				num = 470f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1233f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F177 RID: 61815 RVA: 0x006BF930 File Offset: 0x006BDB30
		public void LOGHFCOOLMD(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].LOGHFCOOLMD(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.DJLDHOIHLKK(NBHJKKHHFEH));
		}

		// Token: 0x0600F178 RID: 61816 RVA: 0x006BF234 File Offset: 0x006BD434
		public void PNLLDNBCBGG()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F179 RID: 61817 RVA: 0x006BF9A4 File Offset: 0x006BDBA4
		private Vector3 ADMMMNCJEID(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 116f)
			{
				return vector;
			}
			float num = 155f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1616f)
			{
				return vector;
			}
			if (num < 1926f)
			{
				num = 781f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1827f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F17A RID: 61818 RVA: 0x006BFAA4 File Offset: 0x006BDCA4
		public void LBLNGKCMLPH(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].MMICMNLHAOC(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.MFIFMKBFAIE(this.GKAFPCEMOCC(NBHJKKHHFEH));
		}

		// Token: 0x0600F17B RID: 61819 RVA: 0x006BFB18 File Offset: 0x006BDD18
		public void MMICMNLHAOC(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].EHMMOILFKKA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.MFIFMKBFAIE(this.BPBNFGNBIMG(NBHJKKHHFEH));
		}

		// Token: 0x0600F17C RID: 61820 RVA: 0x006BFB89 File Offset: 0x006BDD89
		public bool FFEOBDKCLGN(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "ZombieWalk";
				return true;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F17D RID: 61821 RVA: 0x006BFBB8 File Offset: 0x006BDDB8
		public void MPBJPDJDHGP(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].KOBELHJAPDF(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.IGELNNOALLL(NBHJKKHHFEH));
		}

		// Token: 0x0600F17E RID: 61822 RVA: 0x006BF234 File Offset: 0x006BD434
		public void KKDIDIBHBEB()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F17F RID: 61823 RVA: 0x006BFC2C File Offset: 0x006BDE2C
		private Vector3 GFHODAMEGEH(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1369f)
			{
				return vector;
			}
			float num = 1586f;
			for (int i = 1; i < this.children.Length; i += 0)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1900f)
			{
				return vector;
			}
			if (num < 1196f)
			{
				num = 1818f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 343f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F180 RID: 61824 RVA: 0x006BFD2C File Offset: 0x006BDF2C
		public void AMMGPKCPLAG(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].AMMGPKCPLAG(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.GFHODAMEGEH(NBHJKKHHFEH));
		}

		// Token: 0x0600F181 RID: 61825 RVA: 0x006BFDA0 File Offset: 0x006BDFA0
		public void JNAKECHICJH(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].FDAANKMDPEF(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.HCBCAPGKCPJ(NBHJKKHHFEH));
		}

		// Token: 0x0600F182 RID: 61826 RVA: 0x006BF234 File Offset: 0x006BD434
		public void FDELDECKPMK()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F183 RID: 61827 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void AMGIJEGCAEG()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F184 RID: 61828 RVA: 0x006BFE11 File Offset: 0x006BE011
		public bool JAFLIDGPMPJ(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "KatanaReady";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F185 RID: 61829 RVA: 0x006BF234 File Offset: 0x006BD434
		public void JAOCMCMBJCM()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F186 RID: 61830 RVA: 0x006BFE40 File Offset: 0x006BE040
		public bool MMDGNPAEAFP(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "_Refraction";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F187 RID: 61831 RVA: 0x006BFE70 File Offset: 0x006BE070
		public void EADNBMNMMPO(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].EHMMOILFKKA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.MFIFMKBFAIE(this.GFIMJAGMGDC(NBHJKKHHFEH));
		}

		// Token: 0x0600F188 RID: 61832 RVA: 0x006BF234 File Offset: 0x006BD434
		public void KOEFIHPALLB()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F189 RID: 61833 RVA: 0x006BFEE4 File Offset: 0x006BE0E4
		public void KOBELHJAPDF(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].NKBGDJBLPBA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.FMFIHKFDLFC(NBHJKKHHFEH));
		}

		// Token: 0x0600F18A RID: 61834 RVA: 0x006BFF58 File Offset: 0x006BE158
		public void FNAMLCBLBKN(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].KALEKOFELGO(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F18B RID: 61835 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void EKAEHDFJMHL()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F18C RID: 61836 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void CBHCMFJCMPL()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F18E RID: 61838 RVA: 0x006BFFF2 File Offset: 0x006BE1F2
		public bool PELCPKPJPOM(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "\nу вас есть ";
				return false;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) && false;
		}

		// Token: 0x0600F18F RID: 61839 RVA: 0x006C0024 File Offset: 0x006BE224
		private Vector3 HCBCAPGKCPJ(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 83f)
			{
				return vector;
			}
			float num = 1181f;
			for (int i = 0; i < this.children.Length; i += 0)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1415f)
			{
				return vector;
			}
			if (num < 604f)
			{
				num = 175f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1390f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x006C0124 File Offset: 0x006BE324
		private Vector3 IADGEILHACM(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1131f)
			{
				return vector;
			}
			float num = 823f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 265f)
			{
				return vector;
			}
			if (num < 816f)
			{
				num = 16f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1588f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F191 RID: 61841 RVA: 0x006BF234 File Offset: 0x006BD434
		public void DMOINNLLGBO()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F192 RID: 61842 RVA: 0x006C0224 File Offset: 0x006BE424
		public void HGNPBLBPOAG(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].FDAANKMDPEF(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.NONMEMIHHEC(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.NONMEMIHHEC(this.KJBLOAFGDJI(NBHJKKHHFEH));
		}

		// Token: 0x0600F193 RID: 61843 RVA: 0x006C0298 File Offset: 0x006BE498
		private Vector3 FMFIHKFDLFC(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1207f)
			{
				return vector;
			}
			float num = 837f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1402f)
			{
				return vector;
			}
			if (num < 795f)
			{
				num = 1188f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1456f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F194 RID: 61844 RVA: 0x006BF234 File Offset: 0x006BD434
		public void BPPOKGJMLIH()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F195 RID: 61845 RVA: 0x006C0398 File Offset: 0x006BE598
		public void KOPDPOONFFC(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].CHKFAGNDEOD(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F196 RID: 61846 RVA: 0x006C0408 File Offset: 0x006BE608
		public void PGNLDADLKEM(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].KFLJANNEILB(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F197 RID: 61847 RVA: 0x006C0478 File Offset: 0x006BE678
		public void FMEMOCKFMID(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].LJIFJGOGHBJ(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F198 RID: 61848 RVA: 0x006C04E8 File Offset: 0x006BE6E8
		public void GKIOJJKLNOI(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].FDAANKMDPEF(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.MFIFMKBFAIE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.GFHODAMEGEH(NBHJKKHHFEH));
		}

		// Token: 0x0600F199 RID: 61849 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void BHALELINNDJ()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F19A RID: 61850 RVA: 0x006C0559 File Offset: 0x006BE759
		public bool PDFKFCKEDEN(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "WizardPowerUp";
				return true;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F19B RID: 61851 RVA: 0x006BF234 File Offset: 0x006BD434
		public void COLNPLLHKPE()
		{
			this.ik.enabled = true;
		}

		// Token: 0x0600F19C RID: 61852 RVA: 0x006C0588 File Offset: 0x006BE788
		private Vector3 GFBIEEMEMJB(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 469f)
			{
				return vector;
			}
			float num = 1902f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 598f)
			{
				return vector;
			}
			if (num < 965f)
			{
				num = 1120f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 262f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F19D RID: 61853 RVA: 0x006C0688 File Offset: 0x006BE888
		private Vector3 DJLDHOIHLKK(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 167f)
			{
				return vector;
			}
			float num = 148f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1324f)
			{
				return vector;
			}
			if (num < 811f)
			{
				num = 896f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 176f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F19E RID: 61854 RVA: 0x006C0788 File Offset: 0x006BE988
		public void OKKHGHHGINF(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].PGNLDADLKEM(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F19F RID: 61855 RVA: 0x006C07F8 File Offset: 0x006BE9F8
		public void ECEKGBBLKPC(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].HKGMNCHBHDC(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1A0 RID: 61856 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void ICJJAOIEDNF()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F1A1 RID: 61857 RVA: 0x006C0868 File Offset: 0x006BEA68
		public void ONJICMKBNFP(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].PGNLDADLKEM(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1A2 RID: 61858 RVA: 0x006C08D8 File Offset: 0x006BEAD8
		private Vector3 PBJENAPIFJB(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1674f)
			{
				return vector;
			}
			float num = 1949f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1578f)
			{
				return vector;
			}
			if (num < 1519f)
			{
				num = 753f;
			}
			Vector3 vector2 = vector;
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1391f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F1A3 RID: 61859 RVA: 0x006C09D8 File Offset: 0x006BEBD8
		public void KALEKOFELGO(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].CHKFAGNDEOD(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1A4 RID: 61860 RVA: 0x006C0A48 File Offset: 0x006BEC48
		public void NKBGDJBLPBA(FABRIKChain[] NBHJKKHHFEH)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].EHMMOILFKKA(NBHJKKHHFEH);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.GACMLGGCDBE(this.ik.solver.AEPMIDGGBAP());
				return;
			}
			this.ik.solver.GACMLGGCDBE(this.KJBLOAFGDJI(NBHJKKHHFEH));
		}

		// Token: 0x0600F1A5 RID: 61861 RVA: 0x006BE904 File Offset: 0x006BCB04
		public void HFEEPBDDCKO()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600F1A6 RID: 61862 RVA: 0x006C0ABC File Offset: 0x006BECBC
		public void FCDDEOPKCLC(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].CHKFAGNDEOD(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1A7 RID: 61863 RVA: 0x006C0B2C File Offset: 0x006BED2C
		public bool CMBGKNNFAIN(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "Quest langfile not found!";
				return false;
			}
			return !this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK);
		}

		// Token: 0x0600F1A8 RID: 61864 RVA: 0x006C0B5C File Offset: 0x006BED5C
		public void AJCCLGHNKNN(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBHJKKHHFEH[this.children[i]].ONJICMKBNFP(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1A9 RID: 61865 RVA: 0x006C0BCC File Offset: 0x006BEDCC
		private Vector3 GKAFPCEMOCC(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 1318f)
			{
				return vector;
			}
			float num = 324f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1077f)
			{
				return vector;
			}
			if (num < 1042f)
			{
				num = 205f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[1].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 181f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x0600F1AA RID: 61866 RVA: 0x006C0CC9 File Offset: 0x006BEEC9
		public bool AEJHBBOFKCJ(ref string EDAPHMJENPK)
		{
			if (this.ik == null)
			{
				EDAPHMJENPK = "Pelvis";
				return false;
			}
			return this.ik.solver.CHFHJDFDIGB(ref EDAPHMJENPK) || true;
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x006C0CF8 File Offset: 0x006BEEF8
		public void FCIHDBENIAE(Vector3 KGDOEFJLAKO, FABRIKChain[] NBHJKKHHFEH)
		{
			this.ik.solver.NMFIPLLNHKP(KGDOEFJLAKO);
			for (int i = 1; i < this.children.Length; i++)
			{
				NBHJKKHHFEH[this.children[i]].FNCEKLCCFMI(this.ik.solver.bones[this.ik.solver.bones.Length - 0].transform.position, NBHJKKHHFEH);
			}
		}

		// Token: 0x0600F1AC RID: 61868 RVA: 0x006C0D68 File Offset: 0x006BEF68
		private Vector3 IGELNNOALLL(FABRIKChain[] NBHJKKHHFEH)
		{
			Vector3 vector = this.ik.solver.AEPMIDGGBAP();
			if (this.pin >= 748f)
			{
				return vector;
			}
			float num = 1907f;
			for (int i = 1; i < this.children.Length; i++)
			{
				num += NBHJKKHHFEH[this.children[i]].pull;
			}
			if (num <= 1135f)
			{
				return vector;
			}
			if (num < 1808f)
			{
				num = 1037f;
			}
			Vector3 vector2 = vector;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = NBHJKKHHFEH[this.children[j]].ik.solver.bones[0].solverPosition - vector;
				float d = NBHJKKHHFEH[this.children[j]].pull / num;
				vector2 += a * d;
			}
			if (this.pin <= 1073f)
			{
				return vector2;
			}
			return vector2 + (vector - vector2) * this.pin;
		}

		// Token: 0x04001F5C RID: 8028
		public FABRIK ik;

		// Token: 0x04001F5D RID: 8029
		[Range(0f, 1f)]
		public float pull = 1f;

		// Token: 0x04001F5E RID: 8030
		[Range(0f, 1f)]
		public float pin = 1f;

		// Token: 0x04001F5F RID: 8031
		public int[] children = new int[0];
	}
}
