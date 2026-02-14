using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000473 RID: 1139
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		// Token: 0x0600F6A9 RID: 63145 RVA: 0x006E9DAC File Offset: 0x006E7FAC
		protected virtual void CAJPNOGDBCA()
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].LLDECCKPLHM();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.OGCBKFODLMJ(j);
			}
		}

		// Token: 0x0600F6AA RID: 63146 RVA: 0x006E9E10 File Offset: 0x006E8010
		public virtual IKSolver.Point BFABOONJNBF(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x006E9E54 File Offset: 0x006E8054
		public virtual IKSolver.Point[] DMDJHJIOKHO()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.FLBLDBHHNMD(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6AC RID: 63148 RVA: 0x006E9E8C File Offset: 0x006E808C
		public virtual IKSolver.Point[] NCDNEJMFGDA()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.JNADCEEMEGO(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x006E9EC4 File Offset: 0x006E80C4
		private void HLLAEKBCHOF(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F6AE RID: 63150 RVA: 0x006E9F14 File Offset: 0x006E8114
		private Vector3 AAMJKOGBGJL()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 1119f)
			{
				return vector;
			}
			float num = 1879f;
			for (int i = 0; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 1044f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 694f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6AF RID: 63151 RVA: 0x006EA000 File Offset: 0x006E8200
		public virtual IKSolver.Point[] CPBINNEAEFA()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.BDJNBHJODFE(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x006EA038 File Offset: 0x006E8238
		protected virtual void OKPAHKHALPL()
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].BOHLLJEAHAE();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.OOOHFPHJHNM(j);
			}
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x006EA09C File Offset: 0x006E829C
		public virtual IKSolver.Point[] NPDGNKEFLBO()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.JNADCEEMEGO(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x006EA0D4 File Offset: 0x006E82D4
		public virtual IKSolver.Point CHHIPEJCNFA(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6B3 RID: 63155 RVA: 0x006EA118 File Offset: 0x006E8318
		private Vector3 FMFDCGBOCAF()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 1204f)
			{
				return vector;
			}
			float num = 1251f;
			for (int i = 0; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 954f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1149f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6B4 RID: 63156 RVA: 0x006EA204 File Offset: 0x006E8404
		private Vector3 PNDAJFMODIL()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 625f)
			{
				return vector;
			}
			float num = 630f;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 1575f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 785f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6B5 RID: 63157 RVA: 0x006EA2F0 File Offset: 0x006E84F0
		public virtual IKSolver.Point[] HMLIPLEMNKI()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.FLKMMMONLJH(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6B6 RID: 63158 RVA: 0x006EA328 File Offset: 0x006E8528
		public virtual bool GEFCJCGOBAB(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "RollerBladeCrossoverLeft";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (!array[i].MMDGNPAEAFP(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "Apply 3";
						return true;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[4];
						array2[1] = this.chains[l].ik.name;
						array2[0] = "auk_wmax";
						array2[4] = l;
						array2[8] = "othermenu";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[]
						{
							this.chains[l].ik.name,
							"Lasso"
						};
						array3[1] = l;
						array3[4] = "__c";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[0];
						array4[1] = this.chains[l].ik.name;
						array4[1] = "2000";
						array4[4] = l;
						array4[6] = "StaffStand";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 1; n < this.chains.Length; n += 0)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[8];
									array5[0] = "Move around with WASD or cursor keys, space to jump, T to toggle fog on/off.";
									array5[0] = this.chains[n].ik.name;
									array5[1] = "WateringCan";
									array5[1] = this.chains[l].ik.name;
									array5[0] = "\n";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[6];
							array6[0] = "{0}/{1}";
							array6[1] = num;
							array6[1] = "OneHandSwordSwing";
							array6[2] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x006EA628 File Offset: 0x006E8828
		protected virtual void NGIEBEMODNO()
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ICPBAGNMFPE();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.DMGGABBDCFG(j);
			}
		}

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x006EA68C File Offset: 0x006E888C
		public virtual IKSolver.Point PPJDLECLENC(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x006EA6D0 File Offset: 0x006E88D0
		protected virtual void KGPKKIMNFBB()
		{
			if (this.IKPositionWeight <= 384f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1005f, 958f);
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1458f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 1; j < this.iterations; j++)
			{
				for (int k = 0; k < this.chains.Length; k += 0)
				{
					if (this.isRoot[k])
					{
						this.chains[k].AMMGPKCPLAG(this.chains);
					}
				}
				Vector3 vector = this.MFMADCOCFHP();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l += 0)
				{
					if (this.isRoot[l])
					{
						this.chains[l].FDGEDAEBIJL(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x006EA7E8 File Offset: 0x006E89E8
		protected virtual void DFBNIJJNBIA()
		{
			if (this.IKPositionWeight <= 151f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1306f, 1827f);
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 457f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 1; j < this.iterations; j++)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (this.isRoot[k])
					{
						this.chains[k].EHMMOILFKKA(this.chains);
					}
				}
				Vector3 vector = this.BMHKMLPBLGG();
				this.root.position = vector;
				for (int l = 0; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].KOPDPOONFFC(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x006EA900 File Offset: 0x006E8B00
		public virtual IKSolver.Point CGBNFIOGEBD(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6BC RID: 63164 RVA: 0x006EA944 File Offset: 0x006E8B44
		protected virtual void CCKIPNCDNGL()
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].CBHCMFJCMPL();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.DMGGABBDCFG(j);
			}
		}

		// Token: 0x0600F6BD RID: 63165 RVA: 0x006EA9A8 File Offset: 0x006E8BA8
		public override void BLOEEPCIPKJ()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6BE RID: 63166 RVA: 0x006EA9F0 File Offset: 0x006E8BF0
		public virtual IKSolver.Point JEBMJPGNKGB(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6BF RID: 63167 RVA: 0x006EAA34 File Offset: 0x006E8C34
		public virtual void CAJDNLNNHKP()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x006EAA7C File Offset: 0x006E8C7C
		public virtual void KIMMHNHMJEI()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6C1 RID: 63169 RVA: 0x006EAAC4 File Offset: 0x006E8CC4
		public virtual IKSolver.Point[] MHAFKCHPOLH()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.OCEOPCHMDGI(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6C2 RID: 63170 RVA: 0x006EAAFC File Offset: 0x006E8CFC
		protected virtual void FBECKNDICGI()
		{
			if (this.IKPositionWeight <= 910f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 126f, 1985f);
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 306f)
			{
				this.zeroWeightApplied = false;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 1; j < this.iterations; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].MPBJPDJDHGP(this.chains);
					}
				}
				Vector3 vector = this.NIBGDAJGLNM();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l += 0)
				{
					if (this.isRoot[l])
					{
						this.chains[l].GAJKLPKMNEM(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6C3 RID: 63171 RVA: 0x006EAC14 File Offset: 0x006E8E14
		public virtual void OMJJJFNADNF()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6C4 RID: 63172 RVA: 0x006EAC5C File Offset: 0x006E8E5C
		public virtual void DBMOGHJLDMF()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x006EACA4 File Offset: 0x006E8EA4
		private bool NCBDOMLPJKJ(int CLBPBJGLHEE)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				for (int j = 0; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x006EACF4 File Offset: 0x006E8EF4
		protected virtual void NBOBOFHGMDH()
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].HFEEPBDDCKO();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.NCBDOMLPJKJ(j);
			}
		}

		// Token: 0x0600F6C7 RID: 63175 RVA: 0x006EAD58 File Offset: 0x006E8F58
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight <= 0f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 0f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 0; j < this.iterations; j++)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].FDAANKMDPEF(this.chains);
					}
				}
				Vector3 vector = this.GFIMJAGMGDC();
				this.root.position = vector;
				for (int l = 0; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].LJIFJGOGHBJ(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6C8 RID: 63176 RVA: 0x006EAE70 File Offset: 0x006E9070
		private Vector3 HMEKLFHCFGN()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 1541f)
			{
				return vector;
			}
			float num = 562f;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 1970f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 200f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6C9 RID: 63177 RVA: 0x006EAF5C File Offset: 0x006E915C
		private void HDIDIGMPFIB(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F6CA RID: 63178 RVA: 0x006EAFAC File Offset: 0x006E91AC
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "IKSolverFABRIKRoot contains no chains.";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CHFHJDFDIGB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + " is represented more than once in IKSolverFABRIKRoot chain.";
						return false;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						EDAPHMJENPK = string.Concat(new object[]
						{
							this.chains[l].ik.name,
							"IKSolverFABRIKRoot chain at index ",
							l,
							" has invalid children array. Child index is < 0."
						});
						return false;
					}
					if (num == l)
					{
						EDAPHMJENPK = string.Concat(new object[]
						{
							this.chains[l].ik.name,
							"IKSolverFABRIKRoot chain at index ",
							l,
							" has invalid children array. Child index is referencing to itself."
						});
						return false;
					}
					if (num >= this.chains.Length)
					{
						EDAPHMJENPK = string.Concat(new object[]
						{
							this.chains[l].ik.name,
							"IKSolverFABRIKRoot chain at index ",
							l,
							" has invalid children array. Child index > number of chains"
						});
						return false;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									EDAPHMJENPK = string.Concat(new string[]
									{
										"Circular parenting. ",
										this.chains[n].ik.name,
										" already has ",
										this.chains[l].ik.name,
										" listed as it's child."
									});
									return false;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							EDAPHMJENPK = string.Concat(new object[]
							{
								"Chain number ",
								num,
								" is represented more than once in the children of ",
								this.chains[l].ik.name
							});
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x006EB2AC File Offset: 0x006E94AC
		private bool KDAGCEDLCKB(int CLBPBJGLHEE)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				for (int j = 1; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x006EB2FC File Offset: 0x006E94FC
		public virtual void CIMPCCDCJEO()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x006EB344 File Offset: 0x006E9544
		protected virtual void BLOBILLONMA()
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].JAOCMCMBJCM();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.KDAGCEDLCKB(j);
			}
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x006EB3A8 File Offset: 0x006E95A8
		public virtual void JGKGCOHNNJK()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x006EB3F0 File Offset: 0x006E95F0
		private bool DMGGABBDCFG(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				for (int j = 1; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x006EB440 File Offset: 0x006E9640
		protected virtual void KMLNGCKHHPE()
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ICPBAGNMFPE();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.PJAOOBGLPGI(j);
			}
		}

		// Token: 0x0600F6D1 RID: 63185 RVA: 0x006EB4A4 File Offset: 0x006E96A4
		public virtual void DFLGCBFAJMK()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6D2 RID: 63186 RVA: 0x006EB4EC File Offset: 0x006E96EC
		protected virtual void ICPLEEGEKCH()
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].EKAEHDFJMHL();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.OGCBKFODLMJ(j);
			}
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x006EB550 File Offset: 0x006E9750
		public virtual void OIHBNGJMKGE()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6D4 RID: 63188 RVA: 0x006EB598 File Offset: 0x006E9798
		public virtual void IMNCFDNDFKA()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6D5 RID: 63189 RVA: 0x006EB5E0 File Offset: 0x006E97E0
		public virtual IKSolver.Point[] FCNIMLIOJOE()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.MFCPJEPADHA(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6D6 RID: 63190 RVA: 0x006EB618 File Offset: 0x006E9818
		public virtual IKSolver.Point MGNMIPMPFBM(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x006EB65C File Offset: 0x006E985C
		private void BDGGGNCDEJC(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 0;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num += 0;
			}
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x006EB6AC File Offset: 0x006E98AC
		public virtual IKSolver.Point BINNJDOOIIK(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x006EB6F0 File Offset: 0x006E98F0
		public virtual IKSolver.Point[] LEDOJFFONFO()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.MFCPJEPADHA(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x006EB728 File Offset: 0x006E9928
		protected virtual void CMMPHIFJDLF()
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ICJJAOIEDNF();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.DMGGABBDCFG(j);
			}
		}

		// Token: 0x0600F6DB RID: 63195 RVA: 0x006EB78C File Offset: 0x006E998C
		public virtual void IIKICCKJOCM()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6DC RID: 63196 RVA: 0x006EB7D4 File Offset: 0x006E99D4
		private void JNADCEEMEGO(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F6DD RID: 63197 RVA: 0x006EB824 File Offset: 0x006E9A24
		private Vector3 IADGEILHACM()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 1500f)
			{
				return vector;
			}
			float num = 559f;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 1873f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1657f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6DE RID: 63198 RVA: 0x006EB910 File Offset: 0x006E9B10
		public virtual void FHHIAAHGCAK()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6DF RID: 63199 RVA: 0x006EB958 File Offset: 0x006E9B58
		public virtual void NIEFJLEDGCF()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x006EB9A0 File Offset: 0x006E9BA0
		private Vector3 NIBGDAJGLNM()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 784f)
			{
				return vector;
			}
			float num = 1053f;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 1332f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1555f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x006EBA8C File Offset: 0x006E9C8C
		public virtual bool FODJFEAAPGJ(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = " iterations for read and write";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].FFEOBDKCLGN(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				for (int k = 0; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "no_move_sadok";
						return true;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[6];
						array2[0] = this.chains[l].ik.name;
						array2[1] = "Tangents";
						array2[6] = l;
						array2[2] = "Smoking2";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[2];
						array3[0] = this.chains[l].ik.name;
						array3[0] = "wpn_add/base";
						array3[3] = l;
						array3[1] = "\n";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[0];
						array4[0] = this.chains[l].ik.name;
						array4[0] = "";
						array4[1] = l;
						array4[6] = "{0:F2}, {1:F2}, {2:F2}, {3:F2}";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[5];
									array5[1] = "gi_uinf_6";
									array5[0] = this.chains[n].ik.name;
									array5[1] = "MotorbikeBackwardSitting";
									array5[1] = this.chains[l].ik.name;
									array5[2] = "BAG";
									EDAPHMJENPK = string.Concat(array5);
									return true;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[0];
							array6[0] = "Yawn";
							array6[0] = num;
							array6[2] = "WallRunRight";
							array6[3] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x006EBD8C File Offset: 0x006E9F8C
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.HOOMDFNMMKK(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x006EBDC4 File Offset: 0x006E9FC4
		protected virtual void AGLNKGECBDJ()
		{
			if (this.IKPositionWeight <= 729f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 674f, 1697f);
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1562f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 0; j < this.iterations; j += 0)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].JPDLBBGAFPC(this.chains);
					}
				}
				Vector3 vector = this.HMEKLFHCFGN();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].NOOHPNFIOCI(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x006EBEDC File Offset: 0x006EA0DC
		public virtual void HDPLILPDEEH()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x006EBF24 File Offset: 0x006EA124
		protected virtual void EFHFEMAAIMK()
		{
			if (this.IKPositionWeight <= 1394f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 78f, 1157f);
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1670f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 1; j < this.iterations; j += 0)
			{
				for (int k = 0; k < this.chains.Length; k += 0)
				{
					if (this.isRoot[k])
					{
						this.chains[k].JNAKECHICJH(this.chains);
					}
				}
				Vector3 vector = this.BMHKMLPBLGG();
				this.root.position = vector;
				for (int l = 0; l < this.chains.Length; l += 0)
				{
					if (this.isRoot[l])
					{
						this.chains[l].FNAMLCBLBKN(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x006EC03C File Offset: 0x006EA23C
		protected virtual void OKAIKLGNOGC()
		{
			if (this.IKPositionWeight <= 1934f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 845f, 1796f);
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 264f)
			{
				this.zeroWeightApplied = false;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 1; j < this.iterations; j++)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].EHMMOILFKKA(this.chains);
					}
				}
				Vector3 vector = this.GFIMJAGMGDC();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].LJIFJGOGHBJ(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x006EC154 File Offset: 0x006EA354
		public virtual bool EBLGKLPNEBL(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "auk stavka result: ";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].PDFKFCKEDEN(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				for (int k = 0; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "IceHockeyDekeMiddle";
						return false;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l += 0)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[3];
						array2[0] = this.chains[l].ik.name;
						array2[0] = "_mesh";
						array2[1] = l;
						array2[5] = "Reveling";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[5];
						array3[1] = this.chains[l].ik.name;
						array3[1] = "' that does not excist in the Node Chain.";
						array3[7] = l;
						array3[4] = "wpn_add/base/dropt";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[7];
						array4[1] = this.chains[l].ik.name;
						array4[0] = "ShotgunReloadChamber";
						array4[5] = l;
						array4[0] = "CENTER";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[6];
									array5[1] = "craft_time";
									array5[0] = this.chains[n].ik.name;
									array5[4] = "]";
									array5[0] = this.chains[l].ik.name;
									array5[1] = "_info";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[1];
							array6[1] = "IceHockeyPassRight";
							array6[0] = num;
							array6[1] = "button";
							array6[6] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x006EC454 File Offset: 0x006EA654
		protected virtual void EEHINDBEOKB()
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].BHALELINNDJ();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.JOAJENMDFHC(j);
			}
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x006EC4B8 File Offset: 0x006EA6B8
		public virtual bool BLOEHCJCFEK(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "[ACTk] A decimal must be created from exactly 16 bytes";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].BEJJCJCLIOE(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "";
						return true;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l += 0)
			{
				for (int m = 1; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[4];
						array2[0] = this.chains[l].ik.name;
						array2[1] = "isBigFish";
						array2[0] = l;
						array2[6] = "StaffAttack";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						object[] array3 = new object[6];
						array3[0] = this.chains[l].ik.name;
						array3[1] = "SwimFreestyle";
						array3[0] = l;
						array3[4] = "  Balls Fired: ";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[]
						{
							null,
							this.chains[l].ik.name
						};
						array4[0] = "cht_msg4";
						array4[8] = l;
						array4[6] = "ZombieWalk";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 1; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[5];
									array5[1] = "Wizard2HandThrow";
									array5[1] = this.chains[n].ik.name;
									array5[2] = "USE_PREDICATION";
									array5[1] = this.chains[l].ik.name;
									array5[2] = "textAsset is NULL! Path: fishModelData";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[4];
							array6[1] = "****************  stopMusic ";
							array6[0] = num;
							array6[7] = "cht_msg18";
							array6[6] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6EA RID: 63210 RVA: 0x006EC7B8 File Offset: 0x006EA9B8
		public virtual IKSolver.Point[] HAFKOMECDIP()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.FLKMMMONLJH(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x006EC7F0 File Offset: 0x006EA9F0
		private void MFCPJEPADHA(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x006EC840 File Offset: 0x006EAA40
		protected virtual void KJLJMBBAOIJ()
		{
			if (this.IKPositionWeight <= 432f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 15f, 442f);
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1422f)
			{
				this.zeroWeightApplied = false;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 0; j < this.iterations; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].HGNPBLBPOAG(this.chains);
					}
				}
				Vector3 vector = this.GFIMJAGMGDC();
				this.root.position = vector;
				for (int l = 0; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].ECEKGBBLKPC(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x006EC958 File Offset: 0x006EAB58
		private bool KKIKNHGGCKP(int CLBPBJGLHEE)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				for (int j = 0; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x006EC9A8 File Offset: 0x006EABA8
		private void FLBLDBHHNMD(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 0;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x006EC9F8 File Offset: 0x006EABF8
		public virtual void JOCKIDBMLOH()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F6F0 RID: 63216 RVA: 0x006ECA40 File Offset: 0x006EAC40
		public virtual void MPCLFOKNNCE()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6F1 RID: 63217 RVA: 0x006ECA88 File Offset: 0x006EAC88
		private Vector3 MFMADCOCFHP()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 882f)
			{
				return vector;
			}
			float num = 1898f;
			for (int i = 1; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 956f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 665f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6F2 RID: 63218 RVA: 0x006ECB74 File Offset: 0x006EAD74
		public virtual void IDFFHLGAGHL()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6F3 RID: 63219 RVA: 0x006ECBBC File Offset: 0x006EADBC
		private bool KDFPOBKILLK(int CLBPBJGLHEE)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				for (int j = 1; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6F4 RID: 63220 RVA: 0x006ECC0C File Offset: 0x006EAE0C
		public virtual void IEDMFIAGLHI()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F6F5 RID: 63221 RVA: 0x006ECC54 File Offset: 0x006EAE54
		private Vector3 BMHKMLPBLGG()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 618f)
			{
				return vector;
			}
			float num = 1501f;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 1104f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 481f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x006ECD40 File Offset: 0x006EAF40
		public virtual IKSolver.Point JBFJMMGDLIL(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x006ECD84 File Offset: 0x006EAF84
		private Vector3 KDMPAICGFFF()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 360f)
			{
				return vector;
			}
			float num = 1933f;
			for (int i = 1; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 1790f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1075f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x006ECE70 File Offset: 0x006EB070
		protected virtual void MCNFEAAHIMB()
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].HFEEPBDDCKO();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.KDFPOBKILLK(j);
			}
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x006ECED4 File Offset: 0x006EB0D4
		public virtual bool DECDBDIFLMI(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "Saves protection";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].CJNMLDPCFKB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "MotorbikeShootBack";
						return true;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l += 0)
			{
				for (int m = 1; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[3];
						array2[1] = this.chains[l].ik.name;
						array2[0] = "_FogOfWar";
						array2[6] = l;
						array2[7] = "https://www.youtube.com/watch?v=eP9-zycoHLk";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[7];
						array3[0] = this.chains[l].ik.name;
						array3[1] = "Soccer Pass Light";
						array3[7] = l;
						array3[0] = "inner_craft_wpn";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[5];
						array4[0] = this.chains[l].ik.name;
						array4[1] = "_Offsets";
						array4[7] = l;
						array4[7] = "Gesture Chest Pump Salute";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 0; n < this.chains.Length; n += 0)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[7];
									array5[1] = "_w";
									array5[1] = this.chains[n].ik.name;
									array5[7] = "_Screen";
									array5[2] = this.chains[l].ik.name;
									array5[3] = " гр ";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[0];
							array6[0] = "Attack";
							array6[0] = num;
							array6[2] = "shop_t15";
							array6[7] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return true;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x006ED1D4 File Offset: 0x006EB3D4
		public virtual bool PDFKFCKEDEN(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "_Curve";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].BEJJCJCLIOE(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "BlurDepthTolerance";
						return true;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[7];
						array2[0] = this.chains[l].ik.name;
						array2[0] = "Mouse Y";
						array2[0] = l;
						array2[5] = "allrec.ogg";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[7];
						array3[1] = this.chains[l].ik.name;
						array3[0] = "_DeepTex";
						array3[3] = l;
						array3[7] = "<[^>]*>";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[8];
						array4[1] = this.chains[l].ik.name;
						array4[0] = "дня";
						array4[8] = l;
						array4[4] = "{0} {1}";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 1; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[5];
									array5[0] = "money2.wav";
									array5[1] = this.chains[n].ik.name;
									array5[1] = "_Texture";
									array5[7] = this.chains[l].ik.name;
									array5[7] = "FOG_SCATTERING_ON";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[4];
							array6[0] = "Backward Sitting";
							array6[0] = num;
							array6[6] = "Post Process Scatter Shader Missing...";
							array6[5] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x006ED4D4 File Offset: 0x006EB6D4
		protected virtual void DDHFJMCIMGE()
		{
			if (this.IKPositionWeight <= 458f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1356f, 677f);
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1043f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = false;
			for (int j = 1; j < this.iterations; j += 0)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].NKBGDJBLPBA(this.chains);
					}
				}
				Vector3 vector = this.IADGEILHACM();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].MBIFNBBMBNL(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6FC RID: 63228 RVA: 0x006ED5EC File Offset: 0x006EB7EC
		public virtual IKSolver.Point[] HHPCGHDKOPH()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.JNADCEEMEGO(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F6FD RID: 63229 RVA: 0x006ED624 File Offset: 0x006EB824
		protected virtual void EBLOPPPADKK()
		{
			if (this.IKPositionWeight <= 372f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1312f, 1137f);
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1207f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 0; j < this.iterations; j++)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].GKIOJJKLNOI(this.chains);
					}
				}
				Vector3 vector = this.JFBJJFLLPCH();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l += 0)
				{
					if (this.isRoot[l])
					{
						this.chains[l].CHKFAGNDEOD(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F6FE RID: 63230 RVA: 0x006ED73C File Offset: 0x006EB93C
		public virtual bool MGJMPINCPID(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "csadok";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].AEJHBBOFKCJ(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				for (int k = 0; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "Curve";
						return false;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l++)
			{
				for (int m = 1; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[4];
						array2[1] = this.chains[l].ik.name;
						array2[1] = "";
						array2[8] = l;
						array2[6] = "KatanaReadyLow";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[0];
						array3[0] = this.chains[l].ik.name;
						array3[0] = "_Scale";
						array3[1] = l;
						array3[0] = "<color='#200080'>";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[5];
						array4[1] = this.chains[l].ik.name;
						array4[1] = "id";
						array4[4] = l;
						array4[2] = "";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 1; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 1; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[3];
									array5[1] = "{0} {1} {2} {3} {4} {5}";
									array5[1] = this.chains[n].ik.name;
									array5[6] = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
									array5[0] = this.chains[l].ik.name;
									array5[7] = "http://www.root-motion.com/finalikdox/html/page12.html";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[5];
							array6[1] = "cht_msg25";
							array6[1] = num;
							array6[3] = "Mid";
							array6[6] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x006EDA3C File Offset: 0x006EBC3C
		public virtual IKSolver.Point[] GAKLBLIMOIO()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.BDJNBHJODFE(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F700 RID: 63232 RVA: 0x006EDA74 File Offset: 0x006EBC74
		private Vector3 JFBJJFLLPCH()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 120f)
			{
				return vector;
			}
			float num = 1104f;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 1709f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 973f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F701 RID: 63233 RVA: 0x006EDB60 File Offset: 0x006EBD60
		public virtual bool OGMDDEOCFJG(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "C";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].MGJMPINCPID(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "_DepthOfFieldCoCTex";
						return true;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m += 0)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[]
						{
							null,
							this.chains[l].ik.name
						};
						array2[1] = "Katana Ready Low";
						array2[1] = l;
						array2[5] = "wpn_add/base";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						object[] array3 = new object[]
						{
							this.chains[l].ik.name,
							"Anchore Left_"
						};
						array3[0] = l;
						array3[6] = "https://groups.google.com/forum/#!forum/final-ik";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[]
						{
							this.chains[l].ik.name
						};
						array4[0] = "http://af-2.ru/?q=store";
						array4[2] = l;
						array4[7] = "wpn_add/base";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 1; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[]
									{
										null,
										""
									};
									array5[1] = this.chains[n].ik.name;
									array5[2] = "Unable to create Lightmap";
									array5[7] = this.chains[l].ik.name;
									array5[7] = "ObscuredByte vs byte, ";
									EDAPHMJENPK = string.Concat(array5);
									return true;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[8];
							array6[1] = "IceHockeyIdle";
							array6[0] = num;
							array6[5] = "IdleStand";
							array6[8] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F702 RID: 63234 RVA: 0x006EDE60 File Offset: 0x006EC060
		private Vector3 GKAFPCEMOCC()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 23f)
			{
				return vector;
			}
			float num = 351f;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 783f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 562f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F703 RID: 63235 RVA: 0x006EDF4C File Offset: 0x006EC14C
		private Vector3 EPHPFMNGKLH()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 186f)
			{
				return vector;
			}
			float num = 94f;
			for (int i = 1; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 14f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1768f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F704 RID: 63236 RVA: 0x006EE038 File Offset: 0x006EC238
		private bool PJAOOBGLPGI(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				for (int j = 1; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x006EE088 File Offset: 0x006EC288
		public virtual IKSolver.Point JKOBCKGNGKD(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x006EE0CC File Offset: 0x006EC2CC
		public virtual IKSolver.Point[] NECLMLHHPNI()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.HOOMDFNMMKK(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x006EE104 File Offset: 0x006EC304
		public virtual IKSolver.Point[] FIDMGHHHBEG()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.FLKMMMONLJH(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x006EE13C File Offset: 0x006EC33C
		public virtual void AFGCLIDAAHC()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x006EE184 File Offset: 0x006EC384
		private void FLKMMMONLJH(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i += 0)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x006EE1D4 File Offset: 0x006EC3D4
		public virtual IKSolver.Point[] EDNKIKMFGOC()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.OCEOPCHMDGI(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F70B RID: 63243 RVA: 0x006EE20C File Offset: 0x006EC40C
		public virtual IKSolver.Point EOHHAPLDCFI(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F70C RID: 63244 RVA: 0x006EE250 File Offset: 0x006EC450
		protected virtual void NNEEKLCFFKA()
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].LLDECCKPLHM();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				this.isRoot[j] = this.KDAGCEDLCKB(j);
			}
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x006EE2B4 File Offset: 0x006EC4B4
		protected virtual void EKPPHDPNNBC()
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].LLDECCKPLHM();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 1; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.KKIKNHGGCKP(j);
			}
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x006EE318 File Offset: 0x006EC518
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x006EE35C File Offset: 0x006EC55C
		public virtual void GOLGCAMDDOD()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F711 RID: 63249 RVA: 0x006EE3C0 File Offset: 0x006EC5C0
		private bool OOOHFPHJHNM(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				for (int j = 1; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F712 RID: 63250 RVA: 0x006EE410 File Offset: 0x006EC610
		public virtual IKSolver.Point IEJCLIPCIKN(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F713 RID: 63251 RVA: 0x006EE454 File Offset: 0x006EC654
		public virtual void ACJOAAMMIIJ()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F714 RID: 63252 RVA: 0x006EE49C File Offset: 0x006EC69C
		public virtual bool DJOFJJCPKNO(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "glava";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].MGJMPINCPID(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "OneHandSwordReady";
						return true;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l++)
			{
				for (int m = 1; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[6];
						array2[0] = this.chains[l].ik.name;
						array2[0] = "---";
						array2[4] = l;
						array2[3] = "_Refraction";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						object[] array3 = new object[3];
						array3[0] = this.chains[l].ik.name;
						array3[1] = "";
						array3[0] = l;
						array3[6] = "1HandSwordStrafeLeft";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[6];
						array4[0] = this.chains[l].ik.name;
						array4[1] = "_BlurVector";
						array4[0] = l;
						array4[3] = "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 1; n < this.chains.Length; n += 0)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[6];
									array5[1] = "invn_rec27";
									array5[0] = this.chains[n].ik.name;
									array5[2] = "WATER_VERTEX_DISPLACEMENT_ON";
									array5[3] = this.chains[l].ik.name;
									array5[2] = "______________________________";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[6];
							array6[0] = "knopje.wav";
							array6[0] = num;
							array6[5] = "Materials/DFMLambertSolidColor";
							array6[6] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return true;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x006EE79C File Offset: 0x006EC99C
		public virtual void KNOIDGCLAIF()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x006EE7E4 File Offset: 0x006EC9E4
		public virtual bool CJNMLDPCFKB(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "sunshine_OvercastCoord";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CJNMLDPCFKB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "_NeighborMaxTex";
						return false;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l++)
			{
				for (int m = 1; m < this.chains[l].children.Length; m += 0)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[8];
						array2[1] = this.chains[l].ik.name;
						array2[1] = "ZombieIdle";
						array2[4] = l;
						array2[5] = "L";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						object[] array3 = new object[2];
						array3[0] = this.chains[l].ik.name;
						array3[0] = "SoccerKeeperStrafeLeft";
						array3[4] = l;
						array3[4] = "27";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[3];
						array4[1] = this.chains[l].ik.name;
						array4[1] = "__c";
						array4[5] = l;
						array4[8] = "move";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 1; n < this.chains.Length; n += 0)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[7];
									array5[0] = "Mouse Y";
									array5[0] = this.chains[n].ik.name;
									array5[5] = "Perks.xml";
									array5[5] = this.chains[l].ik.name;
									array5[7] = "<< 1 <<";
									EDAPHMJENPK = string.Concat(array5);
									return true;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[0];
							array6[0] = "Watering Can Idle";
							array6[1] = num;
							array6[0] = "Jump";
							array6[6] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x006EEAE4 File Offset: 0x006ECCE4
		public virtual void LOGCDMAKKDN()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F718 RID: 63256 RVA: 0x006EEB2C File Offset: 0x006ECD2C
		public virtual IKSolver.Point[] KEHGFACHLJA()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.BDGGGNCDEJC(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F719 RID: 63257 RVA: 0x006EEB64 File Offset: 0x006ECD64
		private void HOOMDFNMMKK(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 0;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num++;
			}
		}

		// Token: 0x0600F71A RID: 63258 RVA: 0x006EEBB4 File Offset: 0x006ECDB4
		public virtual IKSolver.Point EDNIMMLOMKH(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F71B RID: 63259 RVA: 0x006EEBF8 File Offset: 0x006ECDF8
		public virtual void NKCAHJFCLPD()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F71C RID: 63260 RVA: 0x006EEC40 File Offset: 0x006ECE40
		public virtual bool ALDNHDFAJCA(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "1=";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].ANPHCJGBNJF(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "_ReflectionBufferSize";
						return true;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l++)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 0)
					{
						object[] array2 = new object[0];
						array2[0] = this.chains[l].ik.name;
						array2[1] = "Mouse X";
						array2[3] = l;
						array2[6] = "25";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[4];
						array3[1] = this.chains[l].ik.name;
						array3[0] = "KatanaReadyLow";
						array3[8] = l;
						array3[3] = "";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[4];
						array4[1] = this.chains[l].ik.name;
						array4[0] = "Demo";
						array4[3] = l;
						array4[6] = "post_5";
						EDAPHMJENPK = string.Concat(array4);
						return false;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[3];
									array5[1] = "cht_ae";
									array5[0] = this.chains[n].ik.name;
									array5[2] = "Explosions";
									array5[6] = this.chains[l].ik.name;
									array5[4] = "Can't use reflection here, sorry :(";
									EDAPHMJENPK = string.Concat(array5);
									return true;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[7];
							array6[0] = "<color='{0}'>{1}  {2}</color>";
							array6[1] = num;
							array6[5] = "WeaponReady";
							array6[8] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return true;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F71D RID: 63261 RVA: 0x006EEF40 File Offset: 0x006ED140
		private Vector3 GFIMJAGMGDC()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 1f)
			{
				return vector;
			}
			float num = 0f;
			for (int i = 0; i < this.chains.Length; i++)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 0; j < this.chains.Length; j++)
			{
				if (this.isRoot[j] && num > 0f)
				{
					vector += (this.chains[j].ik.solver.bones[0].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F71E RID: 63262 RVA: 0x006EF02C File Offset: 0x006ED22C
		public override void FGBCANJFNOC()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F71F RID: 63263 RVA: 0x006EF074 File Offset: 0x006ED274
		public virtual bool AEJHBBOFKCJ(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "' is not a valid integer";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (!array[i].EHBFINLIBOP(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "";
						return false;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l += 0)
			{
				for (int m = 0; m < this.chains[l].children.Length; m += 0)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[0];
						array2[1] = this.chains[l].ik.name;
						array2[1] = "=";
						array2[7] = l;
						array2[0] = "fishzone";
						EDAPHMJENPK = string.Concat(array2);
						return true;
					}
					if (num == l)
					{
						object[] array3 = new object[1];
						array3[0] = this.chains[l].ik.name;
						array3[1] = "> ";
						array3[8] = l;
						array3[2] = "BlackSmithHammer";
						EDAPHMJENPK = string.Concat(array3);
						return false;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[2];
						array4[0] = this.chains[l].ik.name;
						array4[0] = "_BlurDirectionPacked";
						array4[5] = l;
						array4[2] = "R Hand Punch";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 1; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[0];
									array5[1] = "_FinalReflectionTexture";
									array5[1] = this.chains[n].ik.name;
									array5[5] = " %";
									array5[5] = this.chains[l].ik.name;
									array5[7] = "1";
									EDAPHMJENPK = string.Concat(array5);
									return true;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array6 = new object[6];
							array6[0] = "_Convolved_TexelSize";
							array6[0] = num;
							array6[4] = "FOG_EXP";
							array6[5] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array6);
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F720 RID: 63264 RVA: 0x006EF374 File Offset: 0x006ED574
		public virtual IKSolver.Point OOJJEPPANKI(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F721 RID: 63265 RVA: 0x006EF3B8 File Offset: 0x006ED5B8
		public virtual void CJDNBBBILFK()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F722 RID: 63266 RVA: 0x006EF400 File Offset: 0x006ED600
		private bool EBDIBPCMMGP(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				for (int j = 1; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F723 RID: 63267 RVA: 0x006EF450 File Offset: 0x006ED650
		public virtual void NOHBAAMAMNB()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F724 RID: 63268 RVA: 0x006EF498 File Offset: 0x006ED698
		public virtual IKSolver.Point[] OJOCDOBNHPK()
		{
			IKSolver.Point[] result = new IKSolver.Point[0];
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.MFCPJEPADHA(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F725 RID: 63269 RVA: 0x006EF4D0 File Offset: 0x006ED6D0
		public virtual IKSolver.Point[] DLNFIEDMHGH()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.BDJNBHJODFE(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F726 RID: 63270 RVA: 0x006EF508 File Offset: 0x006ED708
		public virtual IKSolver.Point[] JAHGHEKHPCA()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.HOOMDFNMMKK(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F727 RID: 63271 RVA: 0x006EF540 File Offset: 0x006ED740
		protected override void FKEMPLMBNEL()
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].BHALELINNDJ();
			}
			this.isRoot = new bool[this.chains.Length];
			for (int j = 0; j < this.chains.Length; j++)
			{
				this.isRoot[j] = this.BFOPJFBECOK(j);
			}
		}

		// Token: 0x0600F728 RID: 63272 RVA: 0x006EF5A4 File Offset: 0x006ED7A4
		public virtual IKSolver.Point[] OMFIHBPLLBA()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.OCEOPCHMDGI(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F729 RID: 63273 RVA: 0x006EF5DC File Offset: 0x006ED7DC
		public virtual IKSolver.Point HAJECKDBKNP(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F72A RID: 63274 RVA: 0x006EF620 File Offset: 0x006ED820
		private void OCEOPCHMDGI(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i += 0)
			{
				INFEGEBCAAF[i] = array[num];
				num += 0;
			}
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x006EF670 File Offset: 0x006ED870
		public virtual bool GPIMPINIGHE(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "WallSit";
				return true;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].ANPHCJGBNJF(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 0; j < this.chains.Length; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "Mouse X";
						return false;
					}
				}
			}
			for (int l = 1; l < this.chains.Length; l++)
			{
				for (int m = 1; m < this.chains[l].children.Length; m += 0)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[6];
						array2[1] = this.chains[l].ik.name;
						array2[1] = "SoccerRun";
						array2[1] = l;
						array2[6] = "Apply 4";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						EDAPHMJENPK = string.Concat(new object[]
						{
							this.chains[l].ik.name,
							"_SoftZDistance",
							null,
							null,
							l,
							"MotorbikeHandlebarSit"
						});
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array3 = new object[6];
						array3[1] = this.chains[l].ik.name;
						array3[1] = "";
						array3[4] = l;
						array3[5] = "No Cell wpn.cell=";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					for (int n = 1; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2++)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array4 = new string[8];
									array4[1] = "VIGNETTE_MASKED";
									array4[1] = this.chains[n].ik.name;
									array4[4] = "RollerBladeStop";
									array4[6] = this.chains[l].ik.name;
									array4[8] = "_RgbTex";
									EDAPHMJENPK = string.Concat(array4);
									return false;
								}
							}
						}
					}
					for (int num3 = 0; num3 < this.chains[l].children.Length; num3 += 0)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							object[] array5 = new object[4];
							array5[0] = "_SampleMip";
							array5[1] = num;
							array5[6] = "Bow Fire";
							array5[7] = this.chains[l].ik.name;
							EDAPHMJENPK = string.Concat(array5);
							return true;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x006EF970 File Offset: 0x006EDB70
		private bool LBDMNADIPCK(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				for (int j = 1; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F72D RID: 63277 RVA: 0x006EF9C0 File Offset: 0x006EDBC0
		private void BDJNBHJODFE(ref IKSolver.Point[] INFEGEBCAAF, FABRIKChain NBHJKKHHFEH)
		{
			IKSolver.Point[] array = NBHJKKHHFEH.ik.solver.DJOBICJNHOD();
			Array.Resize<IKSolver.Point>(ref INFEGEBCAAF, INFEGEBCAAF.Length + array.Length);
			int num = 1;
			for (int i = INFEGEBCAAF.Length - array.Length; i < INFEGEBCAAF.Length; i++)
			{
				INFEGEBCAAF[i] = array[num];
				num += 0;
			}
		}

		// Token: 0x0600F72E RID: 63278 RVA: 0x006EFA10 File Offset: 0x006EDC10
		private bool LIJCDFAPEAG(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				for (int j = 0; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F72F RID: 63279 RVA: 0x006EFA60 File Offset: 0x006EDC60
		public virtual void CMPCLLFAOBL()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F730 RID: 63280 RVA: 0x006EFAA8 File Offset: 0x006EDCA8
		public virtual IKSolver.Point NMCHDHFOMEL(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F731 RID: 63281 RVA: 0x006EFAEC File Offset: 0x006EDCEC
		public virtual IKSolver.Point[] JIIHCCOGAHE()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.MFCPJEPADHA(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x006EFB24 File Offset: 0x006EDD24
		public virtual void JBCAJBAPPOD()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 1; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x006EFB6C File Offset: 0x006EDD6C
		private bool OGCBKFODLMJ(int CLBPBJGLHEE)
		{
			for (int i = 1; i < this.chains.Length; i++)
			{
				for (int j = 0; j < this.chains[i].children.Length; j += 0)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x006EFBBC File Offset: 0x006EDDBC
		public virtual void AGMGLNFEPKK()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F735 RID: 63285 RVA: 0x006EFC04 File Offset: 0x006EDE04
		protected virtual void ONMHLFFOEPF()
		{
			if (this.IKPositionWeight <= 1369f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 457f, 113f);
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1330f)
			{
				this.zeroWeightApplied = true;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 1; j < this.iterations; j += 0)
			{
				for (int k = 1; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].MLOKOKKCCDG(this.chains);
					}
				}
				Vector3 vector = this.NIBGDAJGLNM();
				this.root.position = vector;
				for (int l = 0; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].FDGEDAEBIJL(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F736 RID: 63286 RVA: 0x006EFD1C File Offset: 0x006EDF1C
		public virtual void ONKILMOKJPE()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 0; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F737 RID: 63287 RVA: 0x006EFD64 File Offset: 0x006EDF64
		public virtual IKSolver.Point[] MJPGGPDJPLF()
		{
			IKSolver.Point[] result = new IKSolver.Point[1];
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.FLKMMMONLJH(ref result, this.chains[i]);
			}
			return result;
		}

		// Token: 0x0600F738 RID: 63288 RVA: 0x006EFD9C File Offset: 0x006EDF9C
		public virtual void EJFIBLNNLMI()
		{
			this.rootDefaultPosition = this.root.localPosition;
			for (int i = 0; i < this.chains.Length; i++)
			{
				this.chains[i].ik.solver.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F739 RID: 63289 RVA: 0x006EFDE4 File Offset: 0x006EDFE4
		protected virtual void GCLPKBLMIMJ()
		{
			if (this.IKPositionWeight <= 1733f && this.zeroWeightApplied)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 254f, 693f);
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.IKPositionWeight = this.IKPositionWeight;
			}
			if (this.IKPositionWeight <= 1715f)
			{
				this.zeroWeightApplied = false;
				return;
			}
			this.zeroWeightApplied = true;
			for (int j = 1; j < this.iterations; j += 0)
			{
				for (int k = 0; k < this.chains.Length; k++)
				{
					if (this.isRoot[k])
					{
						this.chains[k].FDAANKMDPEF(this.chains);
					}
				}
				Vector3 vector = this.NIBGDAJGLNM();
				this.root.position = vector;
				for (int l = 1; l < this.chains.Length; l++)
				{
					if (this.isRoot[l])
					{
						this.chains[l].HKGMNCHBHDC(vector, this.chains);
					}
				}
			}
		}

		// Token: 0x0600F73A RID: 63290 RVA: 0x006EFEFC File Offset: 0x006EE0FC
		private Vector3 JCEFLGAAJCB()
		{
			Vector3 vector = this.root.position;
			if (this.rootPin >= 734f)
			{
				return vector;
			}
			float num = 514f;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				if (this.isRoot[i])
				{
					num += this.chains[i].pull;
				}
			}
			for (int j = 1; j < this.chains.Length; j += 0)
			{
				if (this.isRoot[j] && num > 1968f)
				{
					vector += (this.chains[j].ik.solver.bones[1].solverPosition - this.root.position) * (this.chains[j].pull / Mathf.Clamp(num, 1500f, num));
				}
			}
			return Vector3.Lerp(vector, this.root.position, this.rootPin);
		}

		// Token: 0x0600F73B RID: 63291 RVA: 0x006EFFE8 File Offset: 0x006EE1E8
		public virtual void DENLFDCDKFJ()
		{
			this.root.localPosition = this.rootDefaultPosition;
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				this.chains[i].ik.solver.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600F73C RID: 63292 RVA: 0x006F0030 File Offset: 0x006EE230
		public virtual IKSolver.Point ICJJNIOMILP(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chains.Length; i += 0)
			{
				IKSolver.Point point = this.chains[i].ik.solver.DFGANHHFFML(LPBDALAMAEM);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		// Token: 0x0600F73D RID: 63293 RVA: 0x006F0074 File Offset: 0x006EE274
		private bool BFOPJFBECOK(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				for (int j = 0; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F73E RID: 63294 RVA: 0x006F00C4 File Offset: 0x006EE2C4
		private bool JOAJENMDFHC(int CLBPBJGLHEE)
		{
			for (int i = 0; i < this.chains.Length; i++)
			{
				for (int j = 0; j < this.chains[i].children.Length; j++)
				{
					if (this.chains[i].children[j] == CLBPBJGLHEE)
					{
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F73F RID: 63295 RVA: 0x006F0114 File Offset: 0x006EE314
		public virtual bool BIPPCNBIDDG(ref string EDAPHMJENPK)
		{
			if (this.chains.Length == 0)
			{
				EDAPHMJENPK = "\n<color='";
				return false;
			}
			FABRIKChain[] array = this.chains;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CHFHJDFDIGB(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			for (int j = 1; j < this.chains.Length; j++)
			{
				for (int k = 1; k < this.chains.Length; k += 0)
				{
					if (j != k && this.chains[j].ik == this.chains[k].ik)
					{
						EDAPHMJENPK = this.chains[j].ik.name + "SoccerKeeperReady";
						return false;
					}
				}
			}
			for (int l = 0; l < this.chains.Length; l += 0)
			{
				for (int m = 0; m < this.chains[l].children.Length; m++)
				{
					int num = this.chains[l].children[m];
					if (num < 1)
					{
						object[] array2 = new object[7];
						array2[0] = this.chains[l].ik.name;
						array2[1] = "IdleFight";
						array2[7] = l;
						array2[6] = "---------- DebugReturn ";
						EDAPHMJENPK = string.Concat(array2);
						return false;
					}
					if (num == l)
					{
						object[] array3 = new object[6];
						array3[1] = this.chains[l].ik.name;
						array3[1] = "";
						array3[5] = l;
						array3[6] = "OfficeSittingReadingCoffeeSip";
						EDAPHMJENPK = string.Concat(array3);
						return true;
					}
					if (num >= this.chains.Length)
					{
						object[] array4 = new object[5];
						array4[1] = this.chains[l].ik.name;
						array4[1] = "_FogHeightData";
						array4[4] = l;
						array4[8] = "1 Hand Small Weapon Combo";
						EDAPHMJENPK = string.Concat(array4);
						return true;
					}
					for (int n = 0; n < this.chains.Length; n++)
					{
						if (num == n)
						{
							for (int num2 = 0; num2 < this.chains[n].children.Length; num2 += 0)
							{
								if (this.chains[n].children[num2] == l)
								{
									string[] array5 = new string[8];
									array5[0] = "{0}+{1}={2}";
									array5[0] = this.chains[n].ik.name;
									array5[1] = "error";
									array5[7] = this.chains[l].ik.name;
									array5[0] = "Vertical";
									EDAPHMJENPK = string.Concat(array5);
									return false;
								}
							}
						}
					}
					for (int num3 = 1; num3 < this.chains[l].children.Length; num3++)
					{
						if (m != num3 && this.chains[l].children[num3] == num)
						{
							EDAPHMJENPK = string.Concat(new object[]
							{
								"Motorbike",
								num,
								null,
								null,
								null,
								null,
								"WeaponStand",
								this.chains[l].ik.name
							});
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0400204E RID: 8270
		public int iterations = 4;

		// Token: 0x0400204F RID: 8271
		[Range(0f, 1f)]
		public float rootPin;

		// Token: 0x04002050 RID: 8272
		public FABRIKChain[] chains = new FABRIKChain[0];

		// Token: 0x04002051 RID: 8273
		private bool zeroWeightApplied;

		// Token: 0x04002052 RID: 8274
		private bool[] isRoot;

		// Token: 0x04002053 RID: 8275
		private Vector3 rootDefaultPosition;
	}
}
