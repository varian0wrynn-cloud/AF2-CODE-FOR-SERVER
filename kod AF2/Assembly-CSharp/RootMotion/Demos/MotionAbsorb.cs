using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000401 RID: 1025
	public class MotionAbsorb : MonoBehaviour
	{
		// Token: 0x0600DBC7 RID: 56263 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator EDCDPNKMHOK()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBC8 RID: 56264 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator OKEPMOKBDOO()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x0064BC9F File Offset: 0x00649E9F
		private void MAHDCGAEEPM()
		{
			if (this.LHGMAMKOCGI > 1709f)
			{
				return;
			}
			base.StartCoroutine(this.PFMHDFINNAO());
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator HPKJMLNFBCD()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBCB RID: 56267 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator EAJJMGHJGPF()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBCC RID: 56268 RVA: 0x0064BCBC File Offset: 0x00649EBC
		private void FJNOEJBFPNJ()
		{
			if (this.LHGMAMKOCGI > 253f)
			{
				return;
			}
			base.StartCoroutine(this.CHAPMJKLLBH());
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator LBHIBKGCICD()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x0064BCD9 File Offset: 0x00649ED9
		private void FPAOMCFNCJA()
		{
			if (this.LHGMAMKOCGI > 301f)
			{
				return;
			}
			base.StartCoroutine(this.HHCDLFAIIBB());
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x0064BCF6 File Offset: 0x00649EF6
		private void FPDCLAEMBGP()
		{
			if (this.LHGMAMKOCGI > 1619f)
			{
				return;
			}
			base.StartCoroutine(this.HIFHLILEDFP());
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator DCHANAOPNCN()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x0064BD13 File Offset: 0x00649F13
		private void EPCDBAOMFCC()
		{
			if (this.LHGMAMKOCGI > 520f)
			{
				return;
			}
			base.StartCoroutine(this.PPCCNPEIHPI());
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator CAHFGAECNGC()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x0064BD30 File Offset: 0x00649F30
		private void OGMFCKNPFPP()
		{
			if (this.LHGMAMKOCGI > 219f)
			{
				return;
			}
			base.StartCoroutine(this.NNFNKKIPPCM());
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x0064BD4D File Offset: 0x00649F4D
		private void NKEFPJDBPHG()
		{
			if (this.LHGMAMKOCGI > 1324f)
			{
				return;
			}
			base.StartCoroutine(this.APLIGKCDJHH());
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x0064BD6A File Offset: 0x00649F6A
		private void FHFBDFHAJID()
		{
			if (this.LHGMAMKOCGI > 1918f)
			{
				return;
			}
			base.StartCoroutine(this.APLIGKCDJHH());
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x0064BD87 File Offset: 0x00649F87
		private void LIEBLHDICIN()
		{
			if (this.LHGMAMKOCGI > 766f)
			{
				return;
			}
			base.StartCoroutine(this.NEEHIKADGEO());
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x0064BDA4 File Offset: 0x00649FA4
		private void MHPALFDFCGA()
		{
			if (this.LHGMAMKOCGI > 535f)
			{
				return;
			}
			base.StartCoroutine(this.EFJLMANDGDH());
		}

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x0064BDC1 File Offset: 0x00649FC1
		private void IMJLFEHBFHH()
		{
			if (this.LHGMAMKOCGI > 1587f)
			{
				return;
			}
			base.StartCoroutine(this.PHMDDFEDHKL());
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator OMOFNGIPMDH()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x0064BDDE File Offset: 0x00649FDE
		private void BKPHKAMHNLP()
		{
			if (this.LHGMAMKOCGI > 926f)
			{
				return;
			}
			base.StartCoroutine(this.APLIGKCDJHH());
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x0064BDFB File Offset: 0x00649FFB
		private void OnCollisionEnter()
		{
			if (this.LHGMAMKOCGI > 0f)
			{
				return;
			}
			base.StartCoroutine(this.FFDJBOPODFG());
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x0064BE18 File Offset: 0x0064A018
		private void EFNLPPFLPLL()
		{
			if (this.LHGMAMKOCGI > 1635f)
			{
				return;
			}
			base.StartCoroutine(this.LLHMLPHOOCE());
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator NNFNKKIPPCM()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBDE RID: 56286 RVA: 0x0064BE35 File Offset: 0x0064A035
		private void PJEHJIPAAPE()
		{
			if (this.LHGMAMKOCGI > 1108f)
			{
				return;
			}
			base.StartCoroutine(this.CHAPMJKLLBH());
		}

		// Token: 0x0600DBDF RID: 56287 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator MJDILPCHLMJ()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator OFHDJBIGDGO()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x0064BE52 File Offset: 0x0064A052
		private void KCONHAMKCGB()
		{
			if (this.LHGMAMKOCGI > 1555f)
			{
				return;
			}
			base.StartCoroutine(this.CAHFGAECNGC());
		}

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x0064BE6F File Offset: 0x0064A06F
		private void DJEBAPCIDNO()
		{
			if (this.LHGMAMKOCGI > 1168f)
			{
				return;
			}
			base.StartCoroutine(this.PFMHDFINNAO());
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x0064BE8C File Offset: 0x0064A08C
		private void PCPLMOEOOGN()
		{
			if (this.LHGMAMKOCGI > 477f)
			{
				return;
			}
			base.StartCoroutine(this.FKHOCIMPGLL());
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x0064BEA9 File Offset: 0x0064A0A9
		private void BNBCCKHBPFH()
		{
			if (this.LHGMAMKOCGI > 1652f)
			{
				return;
			}
			base.StartCoroutine(this.PPCCNPEIHPI());
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x0064BEC6 File Offset: 0x0064A0C6
		private void FEIMHGLLCDB()
		{
			if (this.LHGMAMKOCGI > 1953f)
			{
				return;
			}
			base.StartCoroutine(this.HHCDLFAIIBB());
		}

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x0064BEE3 File Offset: 0x0064A0E3
		private void DCBNEKDBFOF()
		{
			if (this.LHGMAMKOCGI > 1884f)
			{
				return;
			}
			base.StartCoroutine(this.PPCENJCDEFG());
		}

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x0064BF00 File Offset: 0x0064A100
		private void KLPIONDPJKF()
		{
			if (this.LHGMAMKOCGI > 1635f)
			{
				return;
			}
			base.StartCoroutine(this.HHCDLFAIIBB());
		}

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x0064BF1D File Offset: 0x0064A11D
		private void ICPKIJIEDLH()
		{
			if (this.LHGMAMKOCGI > 1065f)
			{
				return;
			}
			base.StartCoroutine(this.LLHMLPHOOCE());
		}

		// Token: 0x0600DBE9 RID: 56297 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator PHMDDFEDHKL()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBEA RID: 56298 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator JEBMHGGOIFK()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBEB RID: 56299 RVA: 0x0064BF3A File Offset: 0x0064A13A
		private void DPEIJOBAPEO()
		{
			if (this.LHGMAMKOCGI > 1168f)
			{
				return;
			}
			base.StartCoroutine(this.EALOHGAJBNI());
		}

		// Token: 0x0600DBEC RID: 56300 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator FKHOCIMPGLL()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x0064BF57 File Offset: 0x0064A157
		private void BCKAGKIGLLA()
		{
			if (this.LHGMAMKOCGI > 1350f)
			{
				return;
			}
			base.StartCoroutine(this.ECINBMAHJAO());
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x0064BF74 File Offset: 0x0064A174
		private void NFGIFAJFGAJ()
		{
			if (this.LHGMAMKOCGI > 1398f)
			{
				return;
			}
			base.StartCoroutine(this.OGFBDMACKJJ());
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator PPCCNPEIHPI()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x0064BF91 File Offset: 0x0064A191
		private void CGAKKDKJKDJ()
		{
			if (this.LHGMAMKOCGI > 1619f)
			{
				return;
			}
			base.StartCoroutine(this.PCCMKGOEMGP());
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x0064BFAE File Offset: 0x0064A1AE
		private void AOJNKDHMEFC()
		{
			if (this.LHGMAMKOCGI > 24f)
			{
				return;
			}
			base.StartCoroutine(this.PHMDDFEDHKL());
		}

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator NEEHIKADGEO()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator OCINKHOAABL()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator CANKJDMHFJJ()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator LACNNCGAEDF()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBF6 RID: 56310 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator PPCENJCDEFG()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF7 RID: 56311 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator HIFHLILEDFP()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF8 RID: 56312 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator FNMPBJCIBEG()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBF9 RID: 56313 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator PDAABPDCGFH()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DBFA RID: 56314 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator CGAEEPFCIEC()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBFB RID: 56315 RVA: 0x0064BFCB File Offset: 0x0064A1CB
		private void LEKLKLDNKIJ()
		{
			if (this.LHGMAMKOCGI > 1091f)
			{
				return;
			}
			base.StartCoroutine(this.NNFNKKIPPCM());
		}

		// Token: 0x0600DBFC RID: 56316 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator CHAPMJKLLBH()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBFD RID: 56317 RVA: 0x0064BFE8 File Offset: 0x0064A1E8
		private void FMAFKMJAMOP()
		{
			if (this.LHGMAMKOCGI > 24f)
			{
				return;
			}
			base.StartCoroutine(this.EFJLMANDGDH());
		}

		// Token: 0x0600DBFE RID: 56318 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator JEFOCNKFLJC()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DBFF RID: 56319 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator DAMFJMPMPJC()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator DGAAEMDBHAP()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x0064C005 File Offset: 0x0064A205
		private void DAAEOMMJCPP()
		{
			if (this.LHGMAMKOCGI > 114f)
			{
				return;
			}
			base.StartCoroutine(this.CAHFGAECNGC());
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x0064C022 File Offset: 0x0064A222
		private void EAAPKABJIJH()
		{
			if (this.LHGMAMKOCGI > 333f)
			{
				return;
			}
			base.StartCoroutine(this.JEBMHGGOIFK());
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator LLHMLPHOOCE()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x0064C03F File Offset: 0x0064A23F
		private void CFKDMNMOHBC()
		{
			if (this.LHGMAMKOCGI > 253f)
			{
				return;
			}
			base.StartCoroutine(this.DAMFJMPMPJC());
		}

		// Token: 0x0600DC05 RID: 56325 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator EALOHGAJBNI()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC06 RID: 56326 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator APLIGKCDJHH()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x0064C05C File Offset: 0x0064A25C
		private void HELIIHPLFDL()
		{
			if (this.LHGMAMKOCGI > 1960f)
			{
				return;
			}
			base.StartCoroutine(this.PPCENJCDEFG());
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x0064C079 File Offset: 0x0064A279
		private void GFLEBIJHEIB()
		{
			if (this.LHGMAMKOCGI > 606f)
			{
				return;
			}
			base.StartCoroutine(this.PFMHDFINNAO());
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x0064C096 File Offset: 0x0064A296
		private void DICALFKKKCM()
		{
			if (this.LHGMAMKOCGI > 1311f)
			{
				return;
			}
			base.StartCoroutine(this.FOMCELPKBKA());
		}

		// Token: 0x0600DC0A RID: 56330 RVA: 0x0064C0B3 File Offset: 0x0064A2B3
		private void GEJCHLEMPBL()
		{
			if (this.LHGMAMKOCGI > 718f)
			{
				return;
			}
			base.StartCoroutine(this.JEFOCNKFLJC());
		}

		// Token: 0x0600DC0B RID: 56331 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator ECINBMAHJAO()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC0C RID: 56332 RVA: 0x0064C0D0 File Offset: 0x0064A2D0
		private void PPKAADBBANJ()
		{
			if (this.LHGMAMKOCGI > 1324f)
			{
				return;
			}
			base.StartCoroutine(this.DAMFJMPMPJC());
		}

		// Token: 0x0600DC0D RID: 56333 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator DNGGGBGKJLM()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC0E RID: 56334 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator PCCMKGOEMGP()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC0F RID: 56335 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator HDANHFOEMDF()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x0064C0ED File Offset: 0x0064A2ED
		private void JJIMGFEJDCH()
		{
			if (this.LHGMAMKOCGI > 188f)
			{
				return;
			}
			base.StartCoroutine(this.HPKJMLNFBCD());
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x0064C10A File Offset: 0x0064A30A
		private void DEGGJBFOKIK()
		{
			if (this.LHGMAMKOCGI > 1765f)
			{
				return;
			}
			base.StartCoroutine(this.HPKJMLNFBCD());
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator MEOKDCNOFMA()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC13 RID: 56339 RVA: 0x0064C127 File Offset: 0x0064A327
		private void GOALHOMJKKK()
		{
			if (this.LHGMAMKOCGI > 894f)
			{
				return;
			}
			base.StartCoroutine(this.FNMPBJCIBEG());
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator OGFBDMACKJJ()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC16 RID: 56342 RVA: 0x0064C162 File Offset: 0x0064A362
		private void ICBIPBCDKKC()
		{
			if (this.LHGMAMKOCGI > 480f)
			{
				return;
			}
			base.StartCoroutine(this.CHAPMJKLLBH());
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x0064C17F File Offset: 0x0064A37F
		private void JLAOHCMOCLM()
		{
			if (this.LHGMAMKOCGI > 1125f)
			{
				return;
			}
			base.StartCoroutine(this.CANKJDMHFJJ());
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator AJCKOIGAHNB()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC19 RID: 56345 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator FFDJBOPODFG()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x0064C19C File Offset: 0x0064A39C
		private void LJMOBGGJCGF()
		{
			if (this.LHGMAMKOCGI > 1894f)
			{
				return;
			}
			base.StartCoroutine(this.LBHIBKGCICD());
		}

		// Token: 0x0600DC1B RID: 56347 RVA: 0x0064C1B9 File Offset: 0x0064A3B9
		private void EAOIPOGDHGP()
		{
			if (this.LHGMAMKOCGI > 1319f)
			{
				return;
			}
			base.StartCoroutine(this.PPCCNPEIHPI());
		}

		// Token: 0x0600DC1C RID: 56348 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator FOMCELPKBKA()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC1D RID: 56349 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator NJPJHLIJBFP()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator EFJLMANDGDH()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator PFMHDFINNAO()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC20 RID: 56352 RVA: 0x0064BC81 File Offset: 0x00649E81
		private IEnumerator NLMFAMPCIBO()
		{
			this.LHGMAMKOCGI = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].LCMMHHLDIFB(this.ik.solver);
			}
			while (this.LHGMAMKOCGI > 0f)
			{
				this.LHGMAMKOCGI -= Time.deltaTime * this.falloffSpeed;
				float num = this.falloff.Evaluate(this.LHGMAMKOCGI);
				for (int j = 0; j < this.absorbers.Length; j++)
				{
					this.absorbers[j].LFOKJAKFGEK(this.ik.solver, num * this.weight);
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0600DC21 RID: 56353 RVA: 0x0064C1D6 File Offset: 0x0064A3D6
		private void AGLGEFLIAAN()
		{
			if (this.LHGMAMKOCGI > 1793f)
			{
				return;
			}
			base.StartCoroutine(this.EDCDPNKMHOK());
		}

		// Token: 0x0600DC22 RID: 56354 RVA: 0x0064C1F3 File Offset: 0x0064A3F3
		private void MJIIJFKNAJH()
		{
			if (this.LHGMAMKOCGI > 1426f)
			{
				return;
			}
			base.StartCoroutine(this.LLHMLPHOOCE());
		}

		// Token: 0x0600DC23 RID: 56355 RVA: 0x0064C210 File Offset: 0x0064A410
		private void GALCDDHNJML()
		{
			if (this.LHGMAMKOCGI > 190f)
			{
				return;
			}
			base.StartCoroutine(this.EALOHGAJBNI());
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator DLPCNNIDNAB()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x0064BC90 File Offset: 0x00649E90
		private IEnumerator HHCDLFAIIBB()
		{
			MotionAbsorb.IMPABOJLMLF impabojlmlf = new MotionAbsorb.IMPABOJLMLF(1);
			impabojlmlf.AENJLLPLILM = this;
			return impabojlmlf;
		}

		// Token: 0x04001D2C RID: 7468
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		// Token: 0x04001D2D RID: 7469
		[Tooltip("Array containing the absorbers")]
		public MotionAbsorb.Absorber[] absorbers;

		// Token: 0x04001D2E RID: 7470
		[Tooltip("The master weight")]
		public float weight = 1f;

		// Token: 0x04001D2F RID: 7471
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		// Token: 0x04001D30 RID: 7472
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed = 1f;

		// Token: 0x04001D31 RID: 7473
		private float LHGMAMKOCGI;

		// Token: 0x02000402 RID: 1026
		[Serializable]
		public class Absorber
		{
			// Token: 0x0600DC27 RID: 56359 RVA: 0x0064C240 File Offset: 0x0064A440
			public void ALAIKAGPJCI(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).position = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC28 RID: 56360 RVA: 0x0064C29B File Offset: 0x0064A49B
			public void IDFEBFOBGHP(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC29 RID: 56361 RVA: 0x0064C2CF File Offset: 0x0064A4CF
			public void OEOOBANFJNB(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC2A RID: 56362 RVA: 0x0064C304 File Offset: 0x0064A504
			public void BCCNEEKLKFC(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.rotation;
			}

			// Token: 0x0600DC2B RID: 56363 RVA: 0x0064C360 File Offset: 0x0064A560
			public void IGACHJGEPIM(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).position = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC2C RID: 56364 RVA: 0x0064C3BC File Offset: 0x0064A5BC
			public void EOCOBKGDBPM(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC2D RID: 56365 RVA: 0x0064C418 File Offset: 0x0064A618
			public void PDCIHODDGJN(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC2E RID: 56366 RVA: 0x0064C474 File Offset: 0x0064A674
			public void GLPJJIHHCLH(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.rotation;
			}

			// Token: 0x0600DC2F RID: 56367 RVA: 0x0064C4CF File Offset: 0x0064A6CF
			public void MEJCNCMJKEK(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC30 RID: 56368 RVA: 0x0064C504 File Offset: 0x0064A704
			public void LGBBGFLBOOI(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.position;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC31 RID: 56369 RVA: 0x0064C560 File Offset: 0x0064A760
			public void IGHHCCONCJJ(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotation = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.rotation;
			}

			// Token: 0x0600DC32 RID: 56370 RVA: 0x0064C5BB File Offset: 0x0064A7BB
			public void JHFEDKHMLIF(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC33 RID: 56371 RVA: 0x0064C5EF File Offset: 0x0064A7EF
			public void LFOKJAKFGEK(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC34 RID: 56372 RVA: 0x0064C624 File Offset: 0x0064A824
			public void HJHNNJHIFMF(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.rotation;
			}

			// Token: 0x0600DC35 RID: 56373 RVA: 0x0064C2CF File Offset: 0x0064A4CF
			public void CAHOFGPIDCI(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC36 RID: 56374 RVA: 0x0064C680 File Offset: 0x0064A880
			public void LCMMHHLDIFB(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotation = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.rotation;
			}

			// Token: 0x0600DC37 RID: 56375 RVA: 0x0064C6DB File Offset: 0x0064A8DB
			public void CKGCKMBLABO(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC38 RID: 56376 RVA: 0x0064C710 File Offset: 0x0064A910
			public void JNMLIGNPPAJ(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).position = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC39 RID: 56377 RVA: 0x0064C76C File Offset: 0x0064A96C
			public void EFPIDHBKEDF(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC3A RID: 56378 RVA: 0x0064C7C8 File Offset: 0x0064A9C8
			public void LHEIEILNOEE(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.rotation;
			}

			// Token: 0x0600DC3B RID: 56379 RVA: 0x0064C824 File Offset: 0x0064AA24
			public void AMJDIECHDBJ(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.rotation;
			}

			// Token: 0x0600DC3C RID: 56380 RVA: 0x0064C87F File Offset: 0x0064AA7F
			public void HBMBNJDKBBA(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC3D RID: 56381 RVA: 0x0064C8B3 File Offset: 0x0064AAB3
			public void BJIBFKCFDBL(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC3E RID: 56382 RVA: 0x0064C8E7 File Offset: 0x0064AAE7
			public void PDOMOGJLLCN(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC3F RID: 56383 RVA: 0x0064C91C File Offset: 0x0064AB1C
			public void NLBNPMABACD(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).position = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.position;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotation = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.rotation;
			}

			// Token: 0x0600DC40 RID: 56384 RVA: 0x0064C5BB File Offset: 0x0064A7BB
			public void MELFLFLMFKE(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC41 RID: 56385 RVA: 0x0064C978 File Offset: 0x0064AB78
			public void HNEAIONMCKF(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.position;
				NBAKCIDALOF.LOOAPOLICLC(this.effector).rotation = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.rotation;
			}

			// Token: 0x0600DC42 RID: 56386 RVA: 0x0064C9D4 File Offset: 0x0064ABD4
			public void ALKHFDJBGMP(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.position;
				NBAKCIDALOF.EEKAOKNJLKH(this.effector).rotation = NBAKCIDALOF.LOOAPOLICLC(this.effector).bone.rotation;
			}

			// Token: 0x0600DC43 RID: 56387 RVA: 0x0064C5BB File Offset: 0x0064A7BB
			public void HHMJEKDEPPL(IKSolverFullBodyBiped NBAKCIDALOF, float OICADHEPMLH)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionWeight = OICADHEPMLH * this.weight;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotationWeight = OICADHEPMLH * this.weight;
			}

			// Token: 0x0600DC44 RID: 56388 RVA: 0x0064CA30 File Offset: 0x0064AC30
			public void JDGLMFMFOBC(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.OEEPHOCHILL(this.effector).position = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.position;
				NBAKCIDALOF.OEEPHOCHILL(this.effector).rotation = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.rotation;
			}

			// Token: 0x0600DC45 RID: 56389 RVA: 0x0064CA8C File Offset: 0x0064AC8C
			public void FDKKLLKHIAL(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LOOAPOLICLC(this.effector).position = NBAKCIDALOF.DAMGOIIBHCN(this.effector).bone.position;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotation = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.rotation;
			}

			// Token: 0x0600DC46 RID: 56390 RVA: 0x0064CAE8 File Offset: 0x0064ACE8
			public void BPIDCIIGMBO(IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).position = NBAKCIDALOF.OEEPHOCHILL(this.effector).bone.position;
				NBAKCIDALOF.DAMGOIIBHCN(this.effector).rotation = NBAKCIDALOF.EEKAOKNJLKH(this.effector).bone.rotation;
			}

			// Token: 0x04001D32 RID: 7474
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			// Token: 0x04001D33 RID: 7475
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight = 1f;
		}
	}
}
