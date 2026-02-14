using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200041D RID: 1053
	public class Mirror : MonoBehaviour
	{
		// Token: 0x0600E356 RID: 58198 RVA: 0x00677F31 File Offset: 0x00676131
		private void NJHJLHBNPOM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FJFAEHMGALO));
			}
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x00677F70 File Offset: 0x00676170
		private void HIKOEAAGOIH()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x00677FFA File Offset: 0x006761FA
		private void IOFCKOOCIMG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LIIHDMMPPDB));
			}
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x00678036 File Offset: 0x00676236
		private void GPPHLKHCHON()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHOECLMLEPI));
			}
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x00678074 File Offset: 0x00676274
		private void APPLKMOGAMJ()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LIIHDMMPPDB));
			}
		}

		// Token: 0x0600E35B RID: 58203 RVA: 0x00678108 File Offset: 0x00676308
		private void KBCMGPMLILG()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E35C RID: 58204 RVA: 0x00678192 File Offset: 0x00676392
		private void OnDestroy()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			}
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x006781D0 File Offset: 0x006763D0
		private void GDGDCKHGHGB()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x0067825A File Offset: 0x0067645A
		private void JJHAIFDONLP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OJAGLLICPMJ));
			}
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x00678298 File Offset: 0x00676498
		private void OPMGCEHKMPI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x00678324 File Offset: 0x00676524
		private void OFGMIEJKMGC()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NDKEHAGOCMI));
			}
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x006783B8 File Offset: 0x006765B8
		private void BGCLAKJHAFK()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PHJLCFIAIFC));
			}
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x0067844A File Offset: 0x0067664A
		private void DAJCCMDCMIK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HHDHPPGJPNI));
			}
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x00678486 File Offset: 0x00676686
		private void PGCPOCKJFGP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CLABJHNOLGI));
			}
		}

		// Token: 0x0600E364 RID: 58212 RVA: 0x006784C4 File Offset: 0x006766C4
		private void EDGALMCHPPH()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LOBJNEANAFD));
			}
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x00678558 File Offset: 0x00676758
		private void HLOEAHPEMAD()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x00678036 File Offset: 0x00676236
		private void CJFGPPKLBMH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHOECLMLEPI));
			}
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x006785E4 File Offset: 0x006767E4
		private void ADLHNBEDHMJ()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HBNPDECAHEO));
			}
		}

		// Token: 0x0600E368 RID: 58216 RVA: 0x00678678 File Offset: 0x00676878
		private void LIIHDMMPPDB()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E369 RID: 58217 RVA: 0x00678702 File Offset: 0x00676902
		private void IEHOIMHFICG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AOPALDIPCHA));
			}
		}

		// Token: 0x0600E36A RID: 58218 RVA: 0x00678740 File Offset: 0x00676940
		private void KIEIPFFEDHC()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KCGKIEPFGCO));
			}
		}

		// Token: 0x0600E36B RID: 58219 RVA: 0x006787D2 File Offset: 0x006769D2
		private void NBENFONBILP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FAFCAJHMFHI));
			}
		}

		// Token: 0x0600E36C RID: 58220 RVA: 0x00678810 File Offset: 0x00676A10
		private void FHOECLMLEPI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x0067889C File Offset: 0x00676A9C
		private void MMPPPKKMHDA()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x00678926 File Offset: 0x00676B26
		private void JPAANPEIKOM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IANLLEPONMH));
			}
		}

		// Token: 0x0600E36F RID: 58223 RVA: 0x00678962 File Offset: 0x00676B62
		private void EEEELHMAIAB()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJNCMIONOOJ));
			}
		}

		// Token: 0x0600E370 RID: 58224 RVA: 0x006789A0 File Offset: 0x00676BA0
		private void JHAKJAMBNAH()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JHLNFFIKMIC));
			}
		}

		// Token: 0x0600E371 RID: 58225 RVA: 0x00678A34 File Offset: 0x00676C34
		private void DPPAAIJCFLC()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLDBENIMCBL));
			}
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x00678AC6 File Offset: 0x00676CC6
		private void AGNGEJGGBGB()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MGJHAJFOMLN));
			}
		}

		// Token: 0x0600E373 RID: 58227 RVA: 0x00678B02 File Offset: 0x00676D02
		private void ILBHBGFAKPN()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AKMFFIONPGE));
			}
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x00678B3E File Offset: 0x00676D3E
		private void FGBEFAILDDL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMPPPKKMHDA));
			}
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00678B7A File Offset: 0x00676D7A
		private void JFOJIAKDCAF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KCGKIEPFGCO));
			}
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x00678486 File Offset: 0x00676686
		private void DNFMEMNJADK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CLABJHNOLGI));
			}
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x00678BB8 File Offset: 0x00676DB8
		private void OALIDDIKLHK()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMPPPKKMHDA));
			}
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x00678C4A File Offset: 0x00676E4A
		private void KGBOBCIIFBI()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OALNBGEFIOF));
			}
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x00678C88 File Offset: 0x00676E88
		private void HOAFNOHHPBE()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00678D14 File Offset: 0x00676F14
		private void PHJLCFIAIFC()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00678DA0 File Offset: 0x00676FA0
		private void CLABJHNOLGI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x00678E2C File Offset: 0x0067702C
		private void BNCNCJGNKJI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x00678EB8 File Offset: 0x006770B8
		private void KNENODFBOIF()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37E RID: 58238 RVA: 0x00678F44 File Offset: 0x00677144
		private void LNBKBOJPNMP()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E37F RID: 58239 RVA: 0x00678FD0 File Offset: 0x006771D0
		private void LGCJDIGOOFA()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GDGDCKHGHGB));
			}
		}

		// Token: 0x0600E380 RID: 58240 RVA: 0x00679062 File Offset: 0x00677262
		private void HMGADNEOKAI()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLDBENIMCBL));
			}
		}

		// Token: 0x0600E381 RID: 58241 RVA: 0x006790A0 File Offset: 0x006772A0
		private void BMNJGPIPKLL()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMPPPKKMHDA));
			}
		}

		// Token: 0x0600E382 RID: 58242 RVA: 0x00679134 File Offset: 0x00677334
		private void JHLNFFIKMIC()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x006791C0 File Offset: 0x006773C0
		private void IEJIIAGOPAL()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x0067924C File Offset: 0x0067744C
		private void FCCAIANLEFE()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LNBKBOJPNMP));
			}
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x006792E0 File Offset: 0x006774E0
		private void CGMHGDEKDEP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMPPPKKMHDA));
			}
		}

		// Token: 0x0600E386 RID: 58246 RVA: 0x00679374 File Offset: 0x00677574
		private void CHDJGEOFHEE()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OALNBGEFIOF));
			}
		}

		// Token: 0x0600E387 RID: 58247 RVA: 0x00679062 File Offset: 0x00677262
		private void KKCCGNNJAJE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLDBENIMCBL));
			}
		}

		// Token: 0x0600E388 RID: 58248 RVA: 0x00679408 File Offset: 0x00677608
		private void CJNBMPCNKHP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EBBPFJAOCBC));
			}
		}

		// Token: 0x0600E389 RID: 58249 RVA: 0x00678962 File Offset: 0x00676B62
		private void LLKLLMDFALO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJNCMIONOOJ));
			}
		}

		// Token: 0x0600E38A RID: 58250 RVA: 0x0067949C File Offset: 0x0067769C
		private void DLDBENIMCBL()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00679526 File Offset: 0x00677726
		private void CDFJDBJKAMO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HOAFNOHHPBE));
			}
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00679562 File Offset: 0x00677762
		private void DMINCEDADIC()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HLOEAHPEMAD));
			}
		}

		// Token: 0x0600E38D RID: 58253 RVA: 0x0067959E File Offset: 0x0067779E
		private void CHEBEMBCKMG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
			}
		}

		// Token: 0x0600E38E RID: 58254 RVA: 0x006795DC File Offset: 0x006777DC
		private void JLKBMEBFHBI()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HIKOEAAGOIH));
			}
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x0067844A File Offset: 0x0067664A
		private void OIICPEBHHKA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HHDHPPGJPNI));
			}
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00679670 File Offset: 0x00677870
		private void LOPNIAICAGI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x006796FA File Offset: 0x006778FA
		private void BCNGPIGDICE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GDGDCKHGHGB));
			}
		}

		// Token: 0x0600E392 RID: 58258 RVA: 0x00679738 File Offset: 0x00677938
		private void KHGJDMCBPOK()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x006797C4 File Offset: 0x006779C4
		private void KFGKKLAKFGH()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OJAGLLICPMJ));
			}
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00679562 File Offset: 0x00677762
		private void KDKONDIFHHK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HLOEAHPEMAD));
			}
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00679858 File Offset: 0x00677A58
		private void OALNBGEFIOF()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x006798E4 File Offset: 0x00677AE4
		private void KCGKIEPFGCO()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00679970 File Offset: 0x00677B70
		private void CGNGBFFGGBP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LNBKBOJPNMP));
			}
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00679A02 File Offset: 0x00677C02
		private void LJLHAJMJDCE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GOHPNIHIGFN));
			}
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00679A40 File Offset: 0x00677C40
		private void FGJCIEDDFGN()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJNCMIONOOJ));
			}
		}

		// Token: 0x0600E39A RID: 58266 RVA: 0x00679AD4 File Offset: 0x00677CD4
		private void GJNCMIONOOJ()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00679B5E File Offset: 0x00677D5E
		private void JIIMDDDEDEA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HBNPDECAHEO));
			}
		}

		// Token: 0x0600E39C RID: 58268 RVA: 0x00679B9C File Offset: 0x00677D9C
		private void GJFCLCIFINB()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E39D RID: 58269 RVA: 0x00679C26 File Offset: 0x00677E26
		private void BHECIFOGAIE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EBBPFJAOCBC));
			}
		}

		// Token: 0x0600E39E RID: 58270 RVA: 0x00679C64 File Offset: 0x00677E64
		private void IAAOGAPJDID()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IEJIIAGOPAL));
			}
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x00679CF8 File Offset: 0x00677EF8
		private void JFHOMJMKBNJ()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HLOEAHPEMAD));
			}
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00678B7A File Offset: 0x00676D7A
		private void IPEPMDODMED()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KCGKIEPFGCO));
			}
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00679D8C File Offset: 0x00677F8C
		private void AOPALDIPCHA()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00679E18 File Offset: 0x00678018
		private void FJFAEHMGALO()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00678926 File Offset: 0x00676B26
		private void EGIPIGJNNJP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IANLLEPONMH));
			}
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00679EA4 File Offset: 0x006780A4
		private void FECFLBMPAAL()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OPMGCEHKMPI));
			}
		}

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00679F38 File Offset: 0x00678138
		private void MGJHAJFOMLN()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00679FC4 File Offset: 0x006781C4
		private void Start()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			}
		}

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x0067A058 File Offset: 0x00678258
		private void AKMFFIONPGE()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00679B5E File Offset: 0x00677D5E
		private void HMDACKBGNJL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HBNPDECAHEO));
			}
		}

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00678036 File Offset: 0x00676236
		private void IDFHJDDHFPP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHOECLMLEPI));
			}
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x0067A0E4 File Offset: 0x006782E4
		private void HBNPDECAHEO()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00678AC6 File Offset: 0x00676CC6
		private void AGGIPMOOBBP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MGJHAJFOMLN));
			}
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x0067A16E File Offset: 0x0067836E
		private void OBMPEBPAOFJ()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BNCNCJGNKJI));
			}
		}

		// Token: 0x0600E3AD RID: 58285 RVA: 0x00678C4A File Offset: 0x00676E4A
		private void GEOHOHNFIAF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OALNBGEFIOF));
			}
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x00678B7A File Offset: 0x00676D7A
		private void PGOIIHGJIHE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KCGKIEPFGCO));
			}
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x0067A1CC File Offset: 0x006783CC
		private void ECMAANIDEBA()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HBNPDECAHEO));
			}
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x0067A260 File Offset: 0x00678460
		private void ELCNJDNCAEP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HBNPDECAHEO));
			}
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x0067A2F4 File Offset: 0x006784F4
		private void LMEABKOGPNA()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x0067A380 File Offset: 0x00678580
		private void GOHPNIHIGFN()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x0067A40C File Offset: 0x0067860C
		private void PMDPLLIBJAF()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LNBKBOJPNMP));
			}
		}

		// Token: 0x0600E3B5 RID: 58293 RVA: 0x0067A4A0 File Offset: 0x006786A0
		private void LELCLMEJJEO()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x006796FA File Offset: 0x006778FA
		private void MCIJGNDJODM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GDGDCKHGHGB));
			}
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x0067A52C File Offset: 0x0067872C
		private void FAFCAJHMFHI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x0067A5B8 File Offset: 0x006787B8
		private void DMAOHJDKMNN()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HHDHPPGJPNI));
			}
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00678486 File Offset: 0x00676686
		private void MEFOBNJIMGC()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CLABJHNOLGI));
			}
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x0067A64C File Offset: 0x0067884C
		private void ELADFDNPOOI()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LNBKBOJPNMP));
			}
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x0067A6E0 File Offset: 0x006788E0
		private void IANLLEPONMH()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x0067A76C File Offset: 0x0067896C
		private void LOBJNEANAFD()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x0067A7F8 File Offset: 0x006789F8
		private void GIADAJFBIOP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BNCNCJGNKJI));
			}
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x0067A88A File Offset: 0x00678A8A
		private void HGNHAGCHGLA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LOBJNEANAFD));
			}
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x0067A8C6 File Offset: 0x00678AC6
		private void BMMEIIIJIFF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JHLNFFIKMIC));
			}
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x0067A904 File Offset: 0x00678B04
		private void JPHBPEAMNHB()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KBCMGPMLILG));
			}
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x0067A998 File Offset: 0x00678B98
		private void DOHJPDNKALP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JHLNFFIKMIC));
			}
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x00678036 File Offset: 0x00676236
		private void ICIIKJJJOEJ()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHOECLMLEPI));
			}
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x006787D2 File Offset: 0x006769D2
		private void NKNDJENDPDJ()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FAFCAJHMFHI));
			}
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x0067AA2C File Offset: 0x00678C2C
		private void EBBPFJAOCBC()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j += 0)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x0067AAB8 File Offset: 0x00678CB8
		private void EJOAPOGPBFM()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHOECLMLEPI));
			}
		}

		// Token: 0x0600E3C6 RID: 58310 RVA: 0x0067A8C6 File Offset: 0x00678AC6
		private void FAHIAIMFOIN()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JHLNFFIKMIC));
			}
		}

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x0067AB4C File Offset: 0x00678D4C
		private void NDKEHAGOCMI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 0; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x0067ABD8 File Offset: 0x00678DD8
		private void LMEJKAEIDCO()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HHDHPPGJPNI));
			}
		}

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x0067AC6C File Offset: 0x00678E6C
		private void HDFCIACDDEK()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KBCMGPMLILG));
			}
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x0067ACFE File Offset: 0x00678EFE
		private void JOPKEFJOKIM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KBCMGPMLILG));
			}
		}

		// Token: 0x0600E3CB RID: 58315 RVA: 0x0067AD3C File Offset: 0x00678F3C
		private void MCHAAIIHOKD()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EBBPFJAOCBC));
			}
		}

		// Token: 0x0600E3CC RID: 58316 RVA: 0x0067ADD0 File Offset: 0x00678FD0
		private void LHMNFJBJBJM()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MGJHAJFOMLN));
			}
		}

		// Token: 0x0600E3CD RID: 58317 RVA: 0x0067AE64 File Offset: 0x00679064
		private void HHDHPPGJPNI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x0067AEF0 File Offset: 0x006790F0
		private void PNJHMJNFPLP()
		{
			if (!this.target.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.JMLEBALIPKC.Length != 0)
			{
				return;
			}
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JMLEBALIPKC = this.target.GetComponentsInChildren<Transform>();
			this.OJMBOCNNLMI = this.target.GetComponent<FullBodyBipedIK>();
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GDGDCKHGHGB));
			}
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x0067AF84 File Offset: 0x00679184
		private void OJAGLLICPMJ()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				for (int j = 1; j < this.JMLEBALIPKC.Length; j++)
				{
					if (this.NJONNOOBGPJ[i].name == this.JMLEBALIPKC[j].name)
					{
						this.NJONNOOBGPJ[i].localPosition = this.JMLEBALIPKC[j].localPosition;
						this.NJONNOOBGPJ[i].localRotation = this.JMLEBALIPKC[j].localRotation;
						break;
					}
				}
			}
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x0067B00E File Offset: 0x0067920E
		private void FLGGHNOABOA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HIKOEAAGOIH));
			}
		}

		// Token: 0x04001DAF RID: 7599
		public Transform target;

		// Token: 0x04001DB0 RID: 7600
		private Transform[] NJONNOOBGPJ = new Transform[0];

		// Token: 0x04001DB1 RID: 7601
		private Transform[] JMLEBALIPKC = new Transform[0];

		// Token: 0x04001DB2 RID: 7602
		private FullBodyBipedIK OJMBOCNNLMI;
	}
}
