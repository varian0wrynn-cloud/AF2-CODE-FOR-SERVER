using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004CA RID: 1226
	public class Recoil : OffsetModifier
	{
		// Token: 0x06010B22 RID: 68386 RVA: 0x0076D448 File Offset: 0x0076B648
		protected virtual void IDADGNCMLID()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
		}

		// Token: 0x06010B23 RID: 68387 RVA: 0x0076D4A0 File Offset: 0x0076B6A0
		protected virtual void KCFKCLCADGM()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JGFLHBEMEGG));
			}
		}

		// Token: 0x06010B25 RID: 68389 RVA: 0x0076D554 File Offset: 0x0076B754
		private void IPPIGAIJFOP()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.DGBPHAJDAAM().rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.BOOKLKKGFAJ().rotation = this.HGDDPALOBGN().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B26 RID: 68390 RVA: 0x0076D5A9 File Offset: 0x0076B7A9
		private IKEffector IIMNIMKDCAC()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B27 RID: 68391 RVA: 0x0076D5D4 File Offset: 0x0076B7D4
		private Transform BOOKLKKGFAJ()
		{
			return this.ILLHDMLIFCL().bone;
		}

		// Token: 0x06010B28 RID: 68392 RVA: 0x0076D5E4 File Offset: 0x0076B7E4
		private void NBEGFDOMFJP()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.KOOIGDKJFPM.rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.JHPNIBJIOGF.rotation = this.KOOIGDKJFPM.rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B29 RID: 68393 RVA: 0x0076D63C File Offset: 0x0076B83C
		public void MLCMNHGHODI(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ELFLOPJDAKK();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 647f;
			}
			else
			{
				this.LPCLDNLHGMO = 1171f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B2A RID: 68394 RVA: 0x0076D6F2 File Offset: 0x0076B8F2
		private IKEffector BBIGNDJPGMC()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B2B RID: 68395 RVA: 0x0076D720 File Offset: 0x0076B920
		public void GLAAFEDJCNH(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].IIKDDILLGLF();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 429f;
			}
			else
			{
				this.LPCLDNLHGMO = 596f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B2C RID: 68396 RVA: 0x0076D7D6 File Offset: 0x0076B9D6
		private IKEffector PCAFGMGEGJL()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.leftHandEffector;
		}

		// Token: 0x06010B2D RID: 68397 RVA: 0x0076D801 File Offset: 0x0076BA01
		public void LHGDPPLIAJO(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B2E RID: 68398 RVA: 0x0076D824 File Offset: 0x0076BA24
		protected virtual void GPPHLKHCHON()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPPIGAIJFOP));
			}
		}

		// Token: 0x06010B2F RID: 68399 RVA: 0x0076D879 File Offset: 0x0076BA79
		public void BPINEDEHBJB(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B30 RID: 68400 RVA: 0x0076D89B File Offset: 0x0076BA9B
		private IKEffector CEMDLFCHKCL()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B31 RID: 68401 RVA: 0x0076D8C6 File Offset: 0x0076BAC6
		private IKEffector BNDGCCJGGKH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.EMPOFCMIGLD();
			}
			return this.ik.solver.IANMIEDIJPJ();
		}

		// Token: 0x06010B32 RID: 68402 RVA: 0x0076D8F4 File Offset: 0x0076BAF4
		public void CIKAKKPDKKI(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].CNIHGFOMCJM();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 770f;
			}
			else
			{
				this.LPCLDNLHGMO = 1054f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B33 RID: 68403 RVA: 0x0076D9AC File Offset: 0x0076BBAC
		protected virtual void DCBCEDCNECB()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PDDCIPKGCMN));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1064f);
			if (this.blendTime > 99f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (249f / this.blendTime), 657f);
			}
			else
			{
				this.LPCLDNLHGMO = 1921f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].GPAMMKENIAH(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.HEAEKGEBFHA().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.OCBCLGLFPPN().rotation) * (this.DPAPMMMKPLD().position - this.KOOIGDKJFPM.position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * this.INBFPFCHEKB().rotation;
				Vector3 a = this.HEAEKGEBFHA().position + this.NCHAADAFGDN().positionOffset + this.CNFHOAKHHNH * point;
				this.GGHCMNCGLPI().positionOffset += a - (this.INBFPFCHEKB().position + this.BNDGCCJGGKH().positionOffset);
			}
		}

		// Token: 0x06010B34 RID: 68404 RVA: 0x0076DCA2 File Offset: 0x0076BEA2
		private Transform EIDNOPIELOK()
		{
			return this.JNNIFOLKNOB().bone;
		}

		// Token: 0x06010B35 RID: 68405 RVA: 0x0076DCAF File Offset: 0x0076BEAF
		private IKEffector DIPAJJJBOMA()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.leftHandEffector;
			}
			return this.ik.solver.IANMIEDIJPJ();
		}

		// Token: 0x06010B36 RID: 68406 RVA: 0x0076D879 File Offset: 0x0076BA79
		public void GGCAOEAOCMM(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B37 RID: 68407 RVA: 0x0076DCDC File Offset: 0x0076BEDC
		protected virtual void ABLPIJEAHGC()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJOFBAONFJF));
			}
		}

		// Token: 0x06010B38 RID: 68408 RVA: 0x0076D6F2 File Offset: 0x0076B8F2
		private IKEffector GFBEIENMNDH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B39 RID: 68409 RVA: 0x0076DD34 File Offset: 0x0076BF34
		public void OAIGIJOFKKO(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].KJJNMNKPNCH();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1728f;
			}
			else
			{
				this.LPCLDNLHGMO = 1442f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B3A RID: 68410 RVA: 0x0076DDEA File Offset: 0x0076BFEA
		private IKEffector LPPBJDEOBBH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.leftHandEffector;
		}

		// Token: 0x06010B3B RID: 68411 RVA: 0x0076DE18 File Offset: 0x0076C018
		protected virtual void NKNDJENDPDJ()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJOFBAONFJF));
			}
		}

		// Token: 0x06010B3C RID: 68412 RVA: 0x0076DE6D File Offset: 0x0076C06D
		private Transform INBFPFCHEKB()
		{
			return this.MFLLMMHPHDG.bone;
		}

		// Token: 0x06010B3D RID: 68413 RVA: 0x0076DE7C File Offset: 0x0076C07C
		public void BMJOLODJDHL(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].PNJHMJNFPLP();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1454f;
			}
			else
			{
				this.LPCLDNLHGMO = 614f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B3E RID: 68414 RVA: 0x0076DF34 File Offset: 0x0076C134
		private void GJOFBAONFJF()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.LNLFAGBILGN().rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.HLHMAILJJKD().rotation = this.EIDNOPIELOK().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B3F RID: 68415 RVA: 0x0076DF8C File Offset: 0x0076C18C
		protected virtual void DDLKLBMNIDM()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1694f);
			if (this.blendTime > 733f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (363f / this.blendTime), 956f);
			}
			else
			{
				this.LPCLDNLHGMO = 114f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].IIDLIPDCNJJ(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.IEBGOEAJKPL().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.OCBCLGLFPPN().rotation) * (this.JHPNIBJIOGF.position - this.KOOIGDKJFPM.position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * this.JHPNIBJIOGF.rotation;
				Vector3 a = this.AGHFBGOIPHK().position + this.JNNIFOLKNOB().positionOffset + this.CNFHOAKHHNH * point;
				this.GGHCMNCGLPI().positionOffset += a - (this.JHPNIBJIOGF.position + this.GGHCMNCGLPI().positionOffset);
			}
		}

		// Token: 0x06010B40 RID: 68416 RVA: 0x0076E284 File Offset: 0x0076C484
		public void HMHCMFKCJBM(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].JPHBPEAMNHB();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1465f;
			}
			else
			{
				this.LPCLDNLHGMO = 730f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B41 RID: 68417 RVA: 0x0076E33C File Offset: 0x0076C53C
		protected virtual void BEJCDHDIMLA()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPPIGAIJFOP));
			}
			this.blendTime = Mathf.Max(this.blendTime, 205f);
			if (this.blendTime > 472f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (959f / this.blendTime), 1602f);
			}
			else
			{
				this.LPCLDNLHGMO = 869f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].ALJDBHIMDNE(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.AGHFBGOIPHK().rotation;
			}
			this.HBFGLDAHIBA = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.HGDDPALOBGN().rotation) * (this.IECHFJPDCMA().position - this.IEBGOEAJKPL().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.IEBGOEAJKPL().rotation) * this.BOOKLKKGFAJ().rotation;
				Vector3 a = this.EIDNOPIELOK().position + this.BBIGNDJPGMC().positionOffset + this.CNFHOAKHHNH * point;
				this.IEADKGANKLG().positionOffset += a - (this.KDMFOLOFPFO().position + this.BNDGCCJGGKH().positionOffset);
			}
		}

		// Token: 0x06010B42 RID: 68418 RVA: 0x0076E632 File Offset: 0x0076C832
		private Transform LNLFAGBILGN()
		{
			return this.PIMEHLCNMEH().bone;
		}

		// Token: 0x06010B43 RID: 68419 RVA: 0x0076E640 File Offset: 0x0076C840
		protected virtual void NECDDLFLEMF()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PDDCIPKGCMN));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1956f);
			if (this.blendTime > 395f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (7f / this.blendTime), 262f);
			}
			else
			{
				this.LPCLDNLHGMO = 1831f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DKNBBNFMAMP(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.AGHFBGOIPHK().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.EIDNOPIELOK().rotation) * (this.EPBGFEPGLBA().position - this.KOOIGDKJFPM.position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.LNLFAGBILGN().rotation) * this.INBFPFCHEKB().rotation;
				Vector3 a = this.IHJOAMODPLO().position + this.KEAEFDFHGFA().positionOffset + this.CNFHOAKHHNH * point;
				this.IEADKGANKLG().positionOffset += a - (this.DPAPMMMKPLD().position + this.BEFDHICBMOB().positionOffset);
			}
		}

		// Token: 0x06010B44 RID: 68420 RVA: 0x0076E936 File Offset: 0x0076CB36
		public void LEIBDJFFIOE(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B45 RID: 68421 RVA: 0x0076E958 File Offset: 0x0076CB58
		private IKEffector KEAEFDFHGFA()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.KIGACGJAJKO();
		}

		// Token: 0x06010B46 RID: 68422 RVA: 0x0076E984 File Offset: 0x0076CB84
		public void GCMMDJBHGOG(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].KKCFKEDABLB();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 593f;
			}
			else
			{
				this.LPCLDNLHGMO = 1667f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B47 RID: 68423 RVA: 0x0076D89B File Offset: 0x0076BA9B
		private IKEffector LCFMMCCOGAG()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B48 RID: 68424 RVA: 0x0076EA3A File Offset: 0x0076CC3A
		private IKEffector JGHANNHEIOF()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x06010B49 RID: 68425 RVA: 0x0076EA68 File Offset: 0x0076CC68
		protected virtual void JOKIOHMEIEN()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JGFLHBEMEGG));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1390f);
			if (this.blendTime > 1712f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (778f / this.blendTime), 586f);
			}
			else
			{
				this.LPCLDNLHGMO = 1597f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].BKPANOKBAMC(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.LNLFAGBILGN().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.KOOIGDKJFPM.rotation) * (this.JHPNIBJIOGF.position - this.HGDDPALOBGN().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.AGHFBGOIPHK().rotation) * this.JHPNIBJIOGF.rotation;
				Vector3 a = this.LNLFAGBILGN().position + this.EGIJHLGJOBH().positionOffset + this.CNFHOAKHHNH * point;
				this.DIPAJJJBOMA().positionOffset += a - (this.HLHMAILJJKD().position + this.BEFDHICBMOB().positionOffset);
			}
		}

		// Token: 0x06010B4A RID: 68426 RVA: 0x0076E632 File Offset: 0x0076C832
		private Transform AGHFBGOIPHK()
		{
			return this.PIMEHLCNMEH().bone;
		}

		// Token: 0x06010B4B RID: 68427 RVA: 0x0076ED60 File Offset: 0x0076CF60
		protected virtual void CAEGFKACKIC()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLCHAKIGNGD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1625f);
			if (this.blendTime > 823f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (718f / this.blendTime), 644f);
			}
			else
			{
				this.LPCLDNLHGMO = 311f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].CAPLBHGKKHA(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.KOOIGDKJFPM.rotation;
			}
			this.HBFGLDAHIBA = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.LHGMMKDICEK().rotation) * (this.HLHMAILJJKD().position - this.HEAEKGEBFHA().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.LNLFAGBILGN().rotation) * this.EPBGFEPGLBA().rotation;
				Vector3 a = this.HEAEKGEBFHA().position + this.HNKNOGKDOGD().positionOffset + this.CNFHOAKHHNH * point;
				this.DIPAJJJBOMA().positionOffset += a - (this.INBFPFCHEKB().position + this.IEADKGANKLG().positionOffset);
			}
		}

		// Token: 0x06010B4C RID: 68428 RVA: 0x0076E632 File Offset: 0x0076C832
		private Transform IEBGOEAJKPL()
		{
			return this.PIMEHLCNMEH().bone;
		}

		// Token: 0x06010B4D RID: 68429 RVA: 0x0076D801 File Offset: 0x0076BA01
		public void BPBPMJAKIIK(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B4E RID: 68430 RVA: 0x0076F056 File Offset: 0x0076D256
		private Transform HEAEKGEBFHA()
		{
			return this.BBIGNDJPGMC().bone;
		}

		// Token: 0x06010B4F RID: 68431 RVA: 0x0076F063 File Offset: 0x0076D263
		private Transform KDMFOLOFPFO()
		{
			return this.AOGCIBEEGFM().bone;
		}

		// Token: 0x06010B50 RID: 68432 RVA: 0x0076E936 File Offset: 0x0076CB36
		public void MNKNJFNJDJP(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06010B51 RID: 68433 RVA: 0x0076F070 File Offset: 0x0076D270
		private Transform KOOIGDKJFPM
		{
			get
			{
				return this.HPEBMINCKCC.bone;
			}
		}

		// Token: 0x06010B52 RID: 68434 RVA: 0x0076F080 File Offset: 0x0076D280
		private void AEFOCOIDKCD()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.KOOIGDKJFPM.rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.IECHFJPDCMA().rotation = this.IEBGOEAJKPL().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B53 RID: 68435 RVA: 0x0076F0D8 File Offset: 0x0076D2D8
		public void ONJBILAACLA(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PMDPLLIBJAF();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 480f;
			}
			else
			{
				this.LPCLDNLHGMO = 1974f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B54 RID: 68436 RVA: 0x0076F190 File Offset: 0x0076D390
		public void KKHDKNHKEJF(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].JPHBPEAMNHB();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1909f;
			}
			else
			{
				this.LPCLDNLHGMO = 1097f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B55 RID: 68437 RVA: 0x0076F246 File Offset: 0x0076D446
		private IKEffector EBMIOGJEKLL()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.KIGACGJAJKO();
		}

		// Token: 0x06010B56 RID: 68438 RVA: 0x0076F271 File Offset: 0x0076D471
		private IKEffector JFFOCJGEJNP()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x0076D5A9 File Offset: 0x0076B7A9
		private IKEffector JNNIFOLKNOB()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x0076F29C File Offset: 0x0076D49C
		private Transform DGBPHAJDAAM()
		{
			return this.CEMDLFCHKCL().bone;
		}

		// Token: 0x06010B59 RID: 68441 RVA: 0x0076D879 File Offset: 0x0076BA79
		public void OAIBKJIOCFM(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B5A RID: 68442 RVA: 0x0076F2AC File Offset: 0x0076D4AC
		public void FBOHLDDINDD(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].KEMGOLACEHI();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 764f;
			}
			else
			{
				this.LPCLDNLHGMO = 607f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B5B RID: 68443 RVA: 0x0076F362 File Offset: 0x0076D562
		private Transform EPBGFEPGLBA()
		{
			return this.BEFDHICBMOB().bone;
		}

		// Token: 0x06010B5C RID: 68444 RVA: 0x0076D5A9 File Offset: 0x0076B7A9
		private IKEffector AMKKALAFEPJ()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B5D RID: 68445 RVA: 0x0076F370 File Offset: 0x0076D570
		public void GBLLCHAJFKO(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].AIFIEAGFIMM();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1914f;
			}
			else
			{
				this.LPCLDNLHGMO = 211f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06010B5E RID: 68446 RVA: 0x0076F426 File Offset: 0x0076D626
		private IKEffector HPEBMINCKCC
		{
			get
			{
				if (this.handedness == Recoil.Handedness.Right)
				{
					return this.ik.solver.rightHandEffector;
				}
				return this.ik.solver.leftHandEffector;
			}
		}

		// Token: 0x06010B5F RID: 68447 RVA: 0x0076F454 File Offset: 0x0076D654
		public void MIGHBHDKKEK(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].AIFIEAGFIMM();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1137f;
			}
			else
			{
				this.LPCLDNLHGMO = 175f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B60 RID: 68448 RVA: 0x0076F50C File Offset: 0x0076D70C
		public void JBFNPHALLDI(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].JLKBMEBFHBI();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1989f;
			}
			else
			{
				this.LPCLDNLHGMO = 372f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B61 RID: 68449 RVA: 0x0076F5C4 File Offset: 0x0076D7C4
		private void JGFLHBEMEGG()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.KOOIGDKJFPM.rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.DPAPMMMKPLD().rotation = this.EIDNOPIELOK().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B62 RID: 68450 RVA: 0x0076F61C File Offset: 0x0076D81C
		public void IFBJBBEEEJM(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ELFLOPJDAKK();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 415f;
			}
			else
			{
				this.LPCLDNLHGMO = 1758f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B63 RID: 68451 RVA: 0x0076D5A9 File Offset: 0x0076B7A9
		private IKEffector LPBAMAJGKDM()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B64 RID: 68452 RVA: 0x0076F6D4 File Offset: 0x0076D8D4
		public void IIFBGNJAEIC(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PMDPLLIBJAF();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 997f;
			}
			else
			{
				this.LPCLDNLHGMO = 87f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B65 RID: 68453 RVA: 0x0076F78A File Offset: 0x0076D98A
		private Transform LHGMMKDICEK()
		{
			return this.HNKNOGKDOGD().bone;
		}

		// Token: 0x06010B66 RID: 68454 RVA: 0x0076F798 File Offset: 0x0076D998
		public void PBPJFNMIAPM(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PMDPLLIBJAF();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 326f;
			}
			else
			{
				this.LPCLDNLHGMO = 1760f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B67 RID: 68455 RVA: 0x0076DE6D File Offset: 0x0076C06D
		private Transform IECHFJPDCMA()
		{
			return this.MFLLMMHPHDG.bone;
		}

		// Token: 0x06010B68 RID: 68456 RVA: 0x0076D879 File Offset: 0x0076BA79
		public void KIPNCACGIOC(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B69 RID: 68457 RVA: 0x0076F84E File Offset: 0x0076DA4E
		private IKEffector AOGCIBEEGFM()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.CMKJIGNKIMG();
			}
			return this.ik.solver.MJOPIBNHGIK();
		}

		// Token: 0x06010B6A RID: 68458 RVA: 0x0076F271 File Offset: 0x0076D471
		private IKEffector FDACIGGGMAG()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06010B6B RID: 68459 RVA: 0x0076DE6D File Offset: 0x0076C06D
		private Transform JHPNIBJIOGF
		{
			get
			{
				return this.MFLLMMHPHDG.bone;
			}
		}

		// Token: 0x06010B6C RID: 68460 RVA: 0x0076F87C File Offset: 0x0076DA7C
		public void CNIFNJMCLHC(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].INDGOHJGCFN();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 180f;
			}
			else
			{
				this.LPCLDNLHGMO = 1822f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B6D RID: 68461 RVA: 0x0076F934 File Offset: 0x0076DB34
		public void IADGOEFLCNL(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].CAJLCEPLKJG();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 421f;
			}
			else
			{
				this.LPCLDNLHGMO = 673f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B6E RID: 68462 RVA: 0x0076F9EC File Offset: 0x0076DBEC
		protected virtual void DOEMHIKKCKB()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPPIGAIJFOP));
			}
		}

		// Token: 0x06010B6F RID: 68463 RVA: 0x0076FA44 File Offset: 0x0076DC44
		public void DGFFGDALEJN(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].PFNPOHMMJDN();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1128f;
			}
			else
			{
				this.LPCLDNLHGMO = 1561f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B70 RID: 68464 RVA: 0x0076FAFC File Offset: 0x0076DCFC
		public void NCOJCPPPNDN(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DHJDMKLBLEF();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 934f;
			}
			else
			{
				this.LPCLDNLHGMO = 1665f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B71 RID: 68465 RVA: 0x0076F78A File Offset: 0x0076D98A
		private Transform HGDDPALOBGN()
		{
			return this.HNKNOGKDOGD().bone;
		}

		// Token: 0x06010B72 RID: 68466 RVA: 0x0076FBB4 File Offset: 0x0076DDB4
		public void KBGHDNDJBCE(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].CKGPEFOKKNL();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1334f;
			}
			else
			{
				this.LPCLDNLHGMO = 1874f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B73 RID: 68467 RVA: 0x0076D5D4 File Offset: 0x0076B7D4
		private Transform HLHMAILJJKD()
		{
			return this.ILLHDMLIFCL().bone;
		}

		// Token: 0x06010B74 RID: 68468 RVA: 0x0076FC6C File Offset: 0x0076DE6C
		protected virtual void BOCDGBIKPAP()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1391f);
			if (this.blendTime > 719f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (835f / this.blendTime), 699f);
			}
			else
			{
				this.LPCLDNLHGMO = 1321f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].CBANMDBFGDI(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.HEAEKGEBFHA().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.LNLFAGBILGN().rotation) * (this.BOOKLKKGFAJ().position - this.DGBPHAJDAAM().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.LHGMMKDICEK().rotation) * this.INBFPFCHEKB().rotation;
				Vector3 a = this.HGDDPALOBGN().position + this.JNNIFOLKNOB().positionOffset + this.CNFHOAKHHNH * point;
				this.ILLHDMLIFCL().positionOffset += a - (this.EPBGFEPGLBA().position + this.NFDBCLCOAGP().positionOffset);
			}
		}

		// Token: 0x06010B75 RID: 68469 RVA: 0x0076FF64 File Offset: 0x0076E164
		public void GDCGPMHFNIB(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].KKCFKEDABLB();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1596f;
			}
			else
			{
				this.LPCLDNLHGMO = 1385f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B76 RID: 68470 RVA: 0x0077001C File Offset: 0x0076E21C
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x06010B77 RID: 68471 RVA: 0x00770071 File Offset: 0x0076E271
		private IKEffector PIMEHLCNMEH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x06010B78 RID: 68472 RVA: 0x0076E936 File Offset: 0x0076CB36
		public void KMCGJBCOINN(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B79 RID: 68473 RVA: 0x0077009C File Offset: 0x0076E29C
		private IKEffector GGHCMNCGLPI()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.CMKJIGNKIMG();
			}
			return this.ik.solver.IANMIEDIJPJ();
		}

		// Token: 0x06010B7A RID: 68474 RVA: 0x007700C8 File Offset: 0x0076E2C8
		protected virtual void BCFDBGIOMBL()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLCHAKIGNGD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 360f);
			if (this.blendTime > 397f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (1887f / this.blendTime), 1581f);
			}
			else
			{
				this.LPCLDNLHGMO = 946f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].ALJDBHIMDNE(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.IHJOAMODPLO().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.OCBCLGLFPPN().rotation) * (this.KDMFOLOFPFO().position - this.HGDDPALOBGN().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.EIDNOPIELOK().rotation) * this.HLHMAILJJKD().rotation;
				Vector3 a = this.LHGMMKDICEK().position + this.JFFOCJGEJNP().positionOffset + this.CNFHOAKHHNH * point;
				this.MFLLMMHPHDG.positionOffset += a - (this.JHPNIBJIOGF.position + this.GGHCMNCGLPI().positionOffset);
			}
		}

		// Token: 0x06010B7B RID: 68475 RVA: 0x007703C0 File Offset: 0x0076E5C0
		public void MJADNBEAGBE(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].INDGOHJGCFN();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 51f;
			}
			else
			{
				this.LPCLDNLHGMO = 1326f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 0].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B7C RID: 68476 RVA: 0x00770478 File Offset: 0x0076E678
		public void BLEMIHOCBNO(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].JLKBMEBFHBI();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 1747f;
			}
			else
			{
				this.LPCLDNLHGMO = 104f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B7D RID: 68477 RVA: 0x0076EA3A File Offset: 0x0076CC3A
		private IKEffector MHGIHBGOAAF()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x06010B7E RID: 68478 RVA: 0x0076D879 File Offset: 0x0076BA79
		public void SetHandRotations(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = true;
		}

		// Token: 0x06010B7F RID: 68479 RVA: 0x0077052E File Offset: 0x0076E72E
		public void EAPEFABCBKH(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B80 RID: 68480 RVA: 0x00770550 File Offset: 0x0076E750
		private void DLCHAKIGNGD()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.IEBGOEAJKPL().rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.HLHMAILJJKD().rotation = this.IHJOAMODPLO().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B81 RID: 68481 RVA: 0x007705A8 File Offset: 0x0076E7A8
		protected virtual void NJHJLHBNPOM()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
		}

		// Token: 0x06010B82 RID: 68482 RVA: 0x00770600 File Offset: 0x0076E800
		protected override void HEHOBGDMLOK()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
			this.blendTime = Mathf.Max(this.blendTime, 0f);
			if (this.blendTime > 0f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (1f / this.blendTime), 1f);
			}
			else
			{
				this.LPCLDNLHGMO = 1f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.KOOIGDKJFPM.rotation;
			}
			this.HBFGLDAHIBA = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.KOOIGDKJFPM.rotation) * (this.JHPNIBJIOGF.position - this.KOOIGDKJFPM.position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.KOOIGDKJFPM.rotation) * this.JHPNIBJIOGF.rotation;
				Vector3 a = this.KOOIGDKJFPM.position + this.HPEBMINCKCC.positionOffset + this.CNFHOAKHHNH * point;
				this.MFLLMMHPHDG.positionOffset += a - (this.JHPNIBJIOGF.position + this.MFLLMMHPHDG.positionOffset);
			}
		}

		// Token: 0x06010B83 RID: 68483 RVA: 0x0076D7D6 File Offset: 0x0076B9D6
		private IKEffector AKPBOGJKCMH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.leftHandEffector;
		}

		// Token: 0x06010B84 RID: 68484 RVA: 0x007708F8 File Offset: 0x0076EAF8
		protected virtual void MEPOMFMNCDE()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 466f);
			if (this.blendTime > 158f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (305f / this.blendTime), 446f);
			}
			else
			{
				this.LPCLDNLHGMO = 86f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].OBDOALFIIFJ(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.OCBCLGLFPPN().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.HEAEKGEBFHA().rotation) * (this.DPAPMMMKPLD().position - this.LHGMMKDICEK().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.KOOIGDKJFPM.rotation) * this.DPAPMMMKPLD().rotation;
				Vector3 a = this.KOOIGDKJFPM.position + this.IIMNIMKDCAC().positionOffset + this.CNFHOAKHHNH * point;
				this.NFDBCLCOAGP().positionOffset += a - (this.INBFPFCHEKB().position + this.AOGCIBEEGFM().positionOffset);
			}
		}

		// Token: 0x06010B85 RID: 68485 RVA: 0x00770BEE File Offset: 0x0076EDEE
		private Transform DPAPMMMKPLD()
		{
			return this.NFDBCLCOAGP().bone;
		}

		// Token: 0x06010B86 RID: 68486 RVA: 0x00770BFC File Offset: 0x0076EDFC
		protected virtual void ICIIKJJJOEJ()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
		}

		// Token: 0x06010B87 RID: 68487 RVA: 0x0077052E File Offset: 0x0076E72E
		public void DPBOJCODOLJ(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B88 RID: 68488 RVA: 0x00770C54 File Offset: 0x0076EE54
		protected virtual void JAFHAAOOBII()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DLCHAKIGNGD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1223f);
			if (this.blendTime > 1806f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (1134f / this.blendTime), 96f);
			}
			else
			{
				this.LPCLDNLHGMO = 496f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GDMKIGLFFDN(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.AGHFBGOIPHK().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.DGBPHAJDAAM().rotation) * (this.INBFPFCHEKB().position - this.AGHFBGOIPHK().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.AGHFBGOIPHK().rotation) * this.JHPNIBJIOGF.rotation;
				Vector3 a = this.IEBGOEAJKPL().position + this.LCFMMCCOGAG().positionOffset + this.CNFHOAKHHNH * point;
				this.IEADKGANKLG().positionOffset += a - (this.BOOKLKKGFAJ().position + this.AOGCIBEEGFM().positionOffset);
			}
		}

		// Token: 0x06010B89 RID: 68489 RVA: 0x0077052E File Offset: 0x0076E72E
		public void KDGOMELOGFD(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B8A RID: 68490 RVA: 0x0076E958 File Offset: 0x0076CB58
		private IKEffector EGIJHLGJOBH()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.KIGACGJAJKO();
		}

		// Token: 0x06010B8B RID: 68491 RVA: 0x00770F4C File Offset: 0x0076F14C
		protected virtual void JKKCAOBAPEO()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JGFLHBEMEGG));
			}
			this.blendTime = Mathf.Max(this.blendTime, 261f);
			if (this.blendTime > 185f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (199f / this.blendTime), 1364f);
			}
			else
			{
				this.LPCLDNLHGMO = 1566f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].BKPANOKBAMC(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.EIDNOPIELOK().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * (this.INBFPFCHEKB().position - this.EIDNOPIELOK().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.DGBPHAJDAAM().rotation) * this.EPBGFEPGLBA().rotation;
				Vector3 a = this.IEBGOEAJKPL().position + this.EGIJHLGJOBH().positionOffset + this.CNFHOAKHHNH * point;
				this.MFLLMMHPHDG.positionOffset += a - (this.JHPNIBJIOGF.position + this.GGHCMNCGLPI().positionOffset);
			}
		}

		// Token: 0x06010B8C RID: 68492 RVA: 0x00771242 File Offset: 0x0076F442
		private IKEffector NFDBCLCOAGP()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.KIGACGJAJKO();
			}
			return this.ik.solver.IANMIEDIJPJ();
		}

		// Token: 0x06010B8D RID: 68493 RVA: 0x0077126D File Offset: 0x0076F46D
		private IKEffector IEADKGANKLG()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.EMPOFCMIGLD();
			}
			return this.ik.solver.rightHandEffector;
		}

		// Token: 0x06010B8E RID: 68494 RVA: 0x00771298 File Offset: 0x0076F498
		protected virtual void HELKCEJMJCO()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1296f);
			if (this.blendTime > 1787f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (224f / this.blendTime), 1150f);
			}
			else
			{
				this.LPCLDNLHGMO = 767f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.KOOIGDKJFPM.rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.HEAEKGEBFHA().rotation) * (this.JHPNIBJIOGF.position - this.IHJOAMODPLO().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * this.IECHFJPDCMA().rotation;
				Vector3 a = this.EIDNOPIELOK().position + this.AKPBOGJKCMH().positionOffset + this.CNFHOAKHHNH * point;
				this.AOGCIBEEGFM().positionOffset += a - (this.KDMFOLOFPFO().position + this.AOGCIBEEGFM().positionOffset);
			}
		}

		// Token: 0x06010B8F RID: 68495 RVA: 0x0076DDEA File Offset: 0x0076BFEA
		private IKEffector NOINOALECCB()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.leftHandEffector;
		}

		// Token: 0x06010B90 RID: 68496 RVA: 0x0077158E File Offset: 0x0076F78E
		private IKEffector BEFDHICBMOB()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.leftHandEffector;
			}
			return this.ik.solver.MJOPIBNHGIK();
		}

		// Token: 0x06010B91 RID: 68497 RVA: 0x0076D6F2 File Offset: 0x0076B8F2
		private IKEffector NMEJEIDKAFJ()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.IANMIEDIJPJ();
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x06010B92 RID: 68498 RVA: 0x0077052E File Offset: 0x0076E72E
		public void KEBFNEHJCGN(Quaternion CHMDKGLDNML, Quaternion CALJLNNIIML)
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				this.KAOKDNEBGGA = CHMDKGLDNML;
			}
			else
			{
				this.KAOKDNEBGGA = CALJLNNIIML;
			}
			this.HBFGLDAHIBA = false;
		}

		// Token: 0x06010B93 RID: 68499 RVA: 0x007715BC File Offset: 0x0076F7BC
		protected virtual void BEEJJBJOKHD()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = true;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PDDCIPKGCMN));
			}
			this.blendTime = Mathf.Max(this.blendTime, 231f);
			if (this.blendTime > 802f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (491f / this.blendTime), 1259f);
			}
			else
			{
				this.LPCLDNLHGMO = 503f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DDLKHEECNKP(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.DGBPHAJDAAM().rotation;
			}
			this.HBFGLDAHIBA = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.DGBPHAJDAAM().rotation) * (this.IECHFJPDCMA().position - this.KOOIGDKJFPM.position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * this.IECHFJPDCMA().rotation;
				Vector3 a = this.HGDDPALOBGN().position + this.CEMDLFCHKCL().positionOffset + this.CNFHOAKHHNH * point;
				this.IEADKGANKLG().positionOffset += a - (this.EPBGFEPGLBA().position + this.AOGCIBEEGFM().positionOffset);
			}
		}

		// Token: 0x06010B94 RID: 68500 RVA: 0x007718B4 File Offset: 0x0076FAB4
		protected virtual void FADIAAGNLCG()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PDDCIPKGCMN));
			}
			this.blendTime = Mathf.Max(this.blendTime, 1910f);
			if (this.blendTime > 1133f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (99f / this.blendTime), 1288f);
			}
			else
			{
				this.LPCLDNLHGMO = 425f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].IIDLIPDCNJJ(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.LHGMMKDICEK().rotation;
			}
			this.HBFGLDAHIBA = true;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.HEAEKGEBFHA().rotation) * (this.HLHMAILJJKD().position - this.IHJOAMODPLO().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.HEAEKGEBFHA().rotation) * this.INBFPFCHEKB().rotation;
				Vector3 a = this.LHGMMKDICEK().position + this.MHGIHBGOAAF().positionOffset + this.CNFHOAKHHNH * point;
				this.GGHCMNCGLPI().positionOffset += a - (this.BOOKLKKGFAJ().position + this.NFDBCLCOAGP().positionOffset);
			}
		}

		// Token: 0x06010B95 RID: 68501 RVA: 0x00771BAC File Offset: 0x0076FDAC
		public void KBKBJOBBJNM(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].HDFCIACDDEK();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 24f;
			}
			else
			{
				this.LPCLDNLHGMO = 387f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B96 RID: 68502 RVA: 0x00771C64 File Offset: 0x0076FE64
		protected virtual void KLLBLFKGMLD()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			if (!this.EOFDOPLDFCG && this.ik != null)
			{
				this.EOFDOPLDFCG = false;
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
			this.blendTime = Mathf.Max(this.blendTime, 873f);
			if (this.blendTime > 1084f)
			{
				this.LPCLDNLHGMO = Mathf.Min(this.LPCLDNLHGMO + Time.deltaTime * (237f / this.blendTime), 1108f);
			}
			else
			{
				this.LPCLDNLHGMO = 1988f;
			}
			float b = this.recoilWeight.Evaluate(this.IOHIFNBBGPJ - (this.CFAGFNEMGCK - Time.time)) * this.BAKGFJMDKBH;
			this.OICADHEPMLH = Mathf.Lerp(this.OICADHEPMLH, b, this.LPCLDNLHGMO);
			Quaternion quaternion = (this.aimIK != null) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.GKJFHJOPKGE * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].BLMNDKFDGNC(this.ik.solver, quaternion, this.OICADHEPMLH, this.IOHIFNBBGPJ, this.CFAGFNEMGCK - Time.time);
			}
			if (!this.HBFGLDAHIBA)
			{
				this.KAOKDNEBGGA = this.LHGMMKDICEK().rotation;
			}
			this.HBFGLDAHIBA = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.GKJFHJOPKGE * this.KAOKDNEBGGA * this.handRotationOffset), this.OICADHEPMLH);
			this.CNFHOAKHHNH = this.rotationOffset * this.KAOKDNEBGGA;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.IHJOAMODPLO().rotation) * (this.BOOKLKKGFAJ().position - this.HGDDPALOBGN().position);
				this.EOHHMGMBNDK = Quaternion.Inverse(this.EIDNOPIELOK().rotation) * this.EPBGFEPGLBA().rotation;
				Vector3 a = this.AGHFBGOIPHK().position + this.EBMIOGJEKLL().positionOffset + this.CNFHOAKHHNH * point;
				this.BNDGCCJGGKH().positionOffset += a - (this.KDMFOLOFPFO().position + this.BNDGCCJGGKH().positionOffset);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06010B97 RID: 68503 RVA: 0x00771F5A File Offset: 0x0077015A
		private IKEffector MFLLMMHPHDG
		{
			get
			{
				if (this.handedness == Recoil.Handedness.Right)
				{
					return this.ik.solver.leftHandEffector;
				}
				return this.ik.solver.rightHandEffector;
			}
		}

		// Token: 0x06010B98 RID: 68504 RVA: 0x00771F88 File Offset: 0x00770188
		public void Fire(float BJFECNMPAJM)
		{
			float num = BJFECNMPAJM * UnityEngine.Random.value * this.magnitudeRandom;
			this.BAKGFJMDKBH = BJFECNMPAJM + num;
			this.GKJFHJOPKGE = Quaternion.Euler(this.rotationRandom * UnityEngine.Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].CNIHGFOMCJM();
			}
			if (Time.time < this.CFAGFNEMGCK)
			{
				this.LPCLDNLHGMO = 0f;
			}
			else
			{
				this.LPCLDNLHGMO = 1f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.IOHIFNBBGPJ = keys[keys.Length - 1].time;
			this.CFAGFNEMGCK = Time.time + this.IOHIFNBBGPJ;
		}

		// Token: 0x06010B99 RID: 68505 RVA: 0x00772040 File Offset: 0x00770240
		private void PDDCIPKGCMN()
		{
			if (Time.time >= this.CFAGFNEMGCK)
			{
				return;
			}
			this.KOOIGDKJFPM.rotation = this.CNFHOAKHHNH;
			if (this.twoHanded)
			{
				this.INBFPFCHEKB().rotation = this.EIDNOPIELOK().rotation * this.EOHHMGMBNDK;
			}
		}

		// Token: 0x06010B9A RID: 68506 RVA: 0x00772098 File Offset: 0x00770298
		protected virtual void CABMDBPACPO()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.AEFOCOIDKCD));
			}
		}

		// Token: 0x06010B9B RID: 68507 RVA: 0x0076F78A File Offset: 0x0076D98A
		private Transform OCBCLGLFPPN()
		{
			return this.HNKNOGKDOGD().bone;
		}

		// Token: 0x06010B9C RID: 68508 RVA: 0x007720ED File Offset: 0x007702ED
		private IKEffector ILLHDMLIFCL()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.DBCIMCKLHIM();
			}
			return this.ik.solver.MJOPIBNHGIK();
		}

		// Token: 0x06010B9D RID: 68509 RVA: 0x00772118 File Offset: 0x00770318
		protected virtual void HMGADNEOKAI()
		{
			base.OnDestroy();
			if (this.ik != null && this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x06010B9E RID: 68510 RVA: 0x0077216D File Offset: 0x0077036D
		private Transform IHJOAMODPLO()
		{
			return this.NOINOALECCB().bone;
		}

		// Token: 0x06010B9F RID: 68511 RVA: 0x0076EA3A File Offset: 0x0076CC3A
		private IKEffector HNKNOGKDOGD()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.MJOPIBNHGIK();
			}
			return this.ik.solver.EMPOFCMIGLD();
		}

		// Token: 0x06010BA0 RID: 68512 RVA: 0x0076D89B File Offset: 0x0076BA9B
		private IKEffector NCHAADAFGDN()
		{
			if (this.handedness == Recoil.Handedness.Right)
			{
				return this.ik.solver.rightHandEffector;
			}
			return this.ik.solver.CMKJIGNKIMG();
		}

		// Token: 0x040022BE RID: 8894
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		// Token: 0x040022BF RID: 8895
		[Tooltip("Which hand is holding the weapon?")]
		public Recoil.Handedness handedness;

		// Token: 0x040022C0 RID: 8896
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded = true;

		// Token: 0x040022C1 RID: 8897
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		// Token: 0x040022C2 RID: 8898
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom = 0.1f;

		// Token: 0x040022C3 RID: 8899
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		// Token: 0x040022C4 RID: 8900
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		// Token: 0x040022C5 RID: 8901
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		// Token: 0x040022C6 RID: 8902
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x040022C7 RID: 8903
		[HideInInspector]
		public Quaternion rotationOffset = Quaternion.identity;

		// Token: 0x040022C8 RID: 8904
		private float BAKGFJMDKBH = 1f;

		// Token: 0x040022C9 RID: 8905
		private float CFAGFNEMGCK = -1f;

		// Token: 0x040022CA RID: 8906
		private Quaternion CNFHOAKHHNH;

		// Token: 0x040022CB RID: 8907
		private Quaternion EOHHMGMBNDK;

		// Token: 0x040022CC RID: 8908
		private Quaternion GKJFHJOPKGE;

		// Token: 0x040022CD RID: 8909
		private float IOHIFNBBGPJ = 1f;

		// Token: 0x040022CE RID: 8910
		private bool EOFDOPLDFCG;

		// Token: 0x040022CF RID: 8911
		private float LPCLDNLHGMO;

		// Token: 0x040022D0 RID: 8912
		private float OICADHEPMLH;

		// Token: 0x040022D1 RID: 8913
		private Quaternion KAOKDNEBGGA = Quaternion.identity;

		// Token: 0x040022D2 RID: 8914
		private bool HBFGLDAHIBA;

		// Token: 0x020004CB RID: 1227
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x06010BA1 RID: 68513 RVA: 0x0077217C File Offset: 0x0077037C
			public void EAHKLHPBEGN(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA2 RID: 68514 RVA: 0x00772214 File Offset: 0x00770414
			public void FFGPELHNHOF(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA3 RID: 68515 RVA: 0x007722AC File Offset: 0x007704AC
			public void BLMNDKFDGNC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA4 RID: 68516 RVA: 0x00772344 File Offset: 0x00770544
			public void BDDGBCBODAI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA5 RID: 68517 RVA: 0x007723DC File Offset: 0x007705DC
			public void CGCCHDHADNC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA6 RID: 68518 RVA: 0x00772474 File Offset: 0x00770674
			public void GPAMMKENIAH(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA7 RID: 68519 RVA: 0x0077250B File Offset: 0x0077070B
			public void JHFAHBIIJDC()
			{
				if (this.additivity <= 375f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BA8 RID: 68520 RVA: 0x00772540 File Offset: 0x00770740
			public void FNPOICECOOI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BA9 RID: 68521 RVA: 0x007725D7 File Offset: 0x007707D7
			public void PFNPOHMMJDN()
			{
				if (this.additivity <= 484f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BAA RID: 68522 RVA: 0x00772609 File Offset: 0x00770809
			public void CKGPEFOKKNL()
			{
				if (this.additivity <= 1301f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BAB RID: 68523 RVA: 0x0077263C File Offset: 0x0077083C
			public void CLJPMKONBKL(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BAC RID: 68524 RVA: 0x007726D4 File Offset: 0x007708D4
			public void GMNNHFOIBKI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BAD RID: 68525 RVA: 0x0077276C File Offset: 0x0077096C
			public void DAIGOMFBNOD(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BAE RID: 68526 RVA: 0x00772803 File Offset: 0x00770A03
			public void CGMHGDEKDEP()
			{
				if (this.additivity <= 1966f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BAF RID: 68527 RVA: 0x00772838 File Offset: 0x00770A38
			public void DCLNJPIBFIA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BB0 RID: 68528 RVA: 0x007728CF File Offset: 0x00770ACF
			public void DGGMJCMLLED()
			{
				if (this.additivity <= 1662f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB1 RID: 68529 RVA: 0x00772901 File Offset: 0x00770B01
			public void ONIHHFLOJMN()
			{
				if (this.additivity <= 1831f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB2 RID: 68530 RVA: 0x00772933 File Offset: 0x00770B33
			public void LHJCHPFKGDB()
			{
				if (this.additivity <= 1549f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB3 RID: 68531 RVA: 0x00772965 File Offset: 0x00770B65
			public void MCHAAIIHOKD()
			{
				if (this.additivity <= 1483f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB4 RID: 68532 RVA: 0x00772997 File Offset: 0x00770B97
			public void AFFAJKPPMHF()
			{
				if (this.additivity <= 1720f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB5 RID: 68533 RVA: 0x007729C9 File Offset: 0x00770BC9
			public void DHJDMKLBLEF()
			{
				if (this.additivity <= 467f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB6 RID: 68534 RVA: 0x007729FC File Offset: 0x00770BFC
			public void EFODADOEBIH(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BB7 RID: 68535 RVA: 0x00772A94 File Offset: 0x00770C94
			public void JAKKDJFKMDO(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BB8 RID: 68536 RVA: 0x00772B2B File Offset: 0x00770D2B
			public void OBJCOJEHLBE()
			{
				if (this.additivity <= 761f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BB9 RID: 68537 RVA: 0x00772B60 File Offset: 0x00770D60
			public void ALJDBHIMDNE(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BBA RID: 68538 RVA: 0x00772BF7 File Offset: 0x00770DF7
			public void ELADFDNPOOI()
			{
				if (this.additivity <= 265f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BBB RID: 68539 RVA: 0x00772C2C File Offset: 0x00770E2C
			public void CBANMDBFGDI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BBC RID: 68540 RVA: 0x00772CC3 File Offset: 0x00770EC3
			public void IJOCHELLKJH()
			{
				if (this.additivity <= 643f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BBD RID: 68541 RVA: 0x00772CF5 File Offset: 0x00770EF5
			public void JLKBMEBFHBI()
			{
				if (this.additivity <= 1631f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BBE RID: 68542 RVA: 0x00772D28 File Offset: 0x00770F28
			public void OBDOALFIIFJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BBF RID: 68543 RVA: 0x00772DBF File Offset: 0x00770FBF
			public void AOCDDBNBADJ()
			{
				if (this.additivity <= 1708f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC0 RID: 68544 RVA: 0x00772DF4 File Offset: 0x00770FF4
			public void MKNEBAOBLNI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BC1 RID: 68545 RVA: 0x00772E8B File Offset: 0x0077108B
			public void HDFCIACDDEK()
			{
				if (this.additivity <= 1395f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC2 RID: 68546 RVA: 0x00772EBD File Offset: 0x007710BD
			public void AIFIEAGFIMM()
			{
				if (this.additivity <= 923f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC3 RID: 68547 RVA: 0x00772EF0 File Offset: 0x007710F0
			public void ODLPIDHFPEO(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BC4 RID: 68548 RVA: 0x00772F88 File Offset: 0x00771188
			public void FGHFOIDAACI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BC5 RID: 68549 RVA: 0x0077301F File Offset: 0x0077121F
			public void MMACLBBMDLA()
			{
				if (this.additivity <= 116f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC6 RID: 68550 RVA: 0x00773051 File Offset: 0x00771251
			public void CAJLCEPLKJG()
			{
				if (this.additivity <= 961f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC7 RID: 68551 RVA: 0x00773083 File Offset: 0x00771283
			public void CNIHGFOMCJM()
			{
				if (this.additivity <= 0f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC8 RID: 68552 RVA: 0x007730B5 File Offset: 0x007712B5
			public void BJHGPFGBFKF()
			{
				if (this.additivity <= 1377f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BC9 RID: 68553 RVA: 0x007730E8 File Offset: 0x007712E8
			public void BIHFKKDHEOA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BCA RID: 68554 RVA: 0x0077317F File Offset: 0x0077137F
			public void GDIMBBBPIHI()
			{
				if (this.additivity <= 1513f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BCB RID: 68555 RVA: 0x007731B4 File Offset: 0x007713B4
			public void OOCJDDBPLDJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BCC RID: 68556 RVA: 0x0077324C File Offset: 0x0077144C
			public void OLDHFHGIPFC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BCD RID: 68557 RVA: 0x007732E3 File Offset: 0x007714E3
			public void EFCCCKGCOCB()
			{
				if (this.additivity <= 1717f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BCE RID: 68558 RVA: 0x00773318 File Offset: 0x00771518
			public void GDMKIGLFFDN(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BCF RID: 68559 RVA: 0x007733B0 File Offset: 0x007715B0
			public void IKKFBNIKGFO(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BD0 RID: 68560 RVA: 0x00773447 File Offset: 0x00771647
			public void CGNGBFFGGBP()
			{
				if (this.additivity <= 245f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BD1 RID: 68561 RVA: 0x00773479 File Offset: 0x00771679
			public void LHHKDNILMDI()
			{
				if (this.additivity <= 1707f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BD2 RID: 68562 RVA: 0x007734AB File Offset: 0x007716AB
			public void KJJNMNKPNCH()
			{
				if (this.additivity <= 520f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BD3 RID: 68563 RVA: 0x007734E0 File Offset: 0x007716E0
			public void JCPAHFMIFOO(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BD4 RID: 68564 RVA: 0x00773578 File Offset: 0x00771778
			public void MCLLJAHGJLP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BD5 RID: 68565 RVA: 0x0077360F File Offset: 0x0077180F
			public void INDGOHJGCFN()
			{
				if (this.additivity <= 1095f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BD6 RID: 68566 RVA: 0x00773641 File Offset: 0x00771841
			public void KKCFKEDABLB()
			{
				if (this.additivity <= 909f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BD7 RID: 68567 RVA: 0x00773674 File Offset: 0x00771874
			public void NFEKPOPPICL(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BD8 RID: 68568 RVA: 0x0077370C File Offset: 0x0077190C
			public void BGFHABPGLFL(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BD9 RID: 68569 RVA: 0x007737A4 File Offset: 0x007719A4
			public void CAPLBHGKKHA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BDA RID: 68570 RVA: 0x0077383C File Offset: 0x00771A3C
			public void IIDLIPDCNJJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BDB RID: 68571 RVA: 0x007738D3 File Offset: 0x00771AD3
			public void IIKDDILLGLF()
			{
				if (this.additivity <= 1183f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BDC RID: 68572 RVA: 0x00773905 File Offset: 0x00771B05
			public void KEMGOLACEHI()
			{
				if (this.additivity <= 609f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BDD RID: 68573 RVA: 0x00773938 File Offset: 0x00771B38
			public void GPKLHAAEEBP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BDE RID: 68574 RVA: 0x007739D0 File Offset: 0x00771BD0
			public void GBNILLPMJAA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BE0 RID: 68576 RVA: 0x00773A85 File Offset: 0x00771C85
			public void PNJHMJNFPLP()
			{
				if (this.additivity <= 1837f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE1 RID: 68577 RVA: 0x00773AB7 File Offset: 0x00771CB7
			public void PBMPJPIMJBF()
			{
				if (this.additivity <= 64f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE2 RID: 68578 RVA: 0x00773AEC File Offset: 0x00771CEC
			public void CFNBOIAPBID(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BE3 RID: 68579 RVA: 0x00773B83 File Offset: 0x00771D83
			public void OFGMIEJKMGC()
			{
				if (this.additivity <= 1774f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE4 RID: 68580 RVA: 0x00773BB8 File Offset: 0x00771DB8
			public void DKNBBNFMAMP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BE5 RID: 68581 RVA: 0x00773C4F File Offset: 0x00771E4F
			public void BMNJGPIPKLL()
			{
				if (this.additivity <= 649f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE6 RID: 68582 RVA: 0x00773C81 File Offset: 0x00771E81
			public void JPHBPEAMNHB()
			{
				if (this.additivity <= 1632f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE7 RID: 68583 RVA: 0x00773CB3 File Offset: 0x00771EB3
			public void OPNPODKLOJK()
			{
				if (this.additivity <= 1770f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BE8 RID: 68584 RVA: 0x00773CE8 File Offset: 0x00771EE8
			public void NDCNDJFEABL(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BE9 RID: 68585 RVA: 0x00773D80 File Offset: 0x00771F80
			public void BKPANOKBAMC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.DAMGOIIBHCN(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BEA RID: 68586 RVA: 0x00773E18 File Offset: 0x00772018
			public void JHPPDFJHKDN(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.LOOAPOLICLC(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BEB RID: 68587 RVA: 0x00773EAF File Offset: 0x007720AF
			public void PMDPLLIBJAF()
			{
				if (this.additivity <= 1893f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BEC RID: 68588 RVA: 0x00773EE1 File Offset: 0x007720E1
			public void ELFLOPJDAKK()
			{
				if (this.additivity <= 471f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x06010BED RID: 68589 RVA: 0x00773F14 File Offset: 0x00772114
			public void PMMPDNLEPKA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.OEEPHOCHILL(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x06010BEE RID: 68590 RVA: 0x00773FAC File Offset: 0x007721AC
			public void DDLKHEECNKP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion PHKIOHIBNPA, float GJFEMCAGMOO, float IOHIFNBBGPJ, float EDGCMKNAILD)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, EDGCMKNAILD / IOHIFNBBGPJ);
				this.lastOffset = PHKIOHIBNPA * (this.offset * GJFEMCAGMOO) + PHKIOHIBNPA * this.additiveOffset;
				Recoil.RecoilOffset.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					Recoil.RecoilOffset.EffectorLink effectorLink = array[i];
					NBAKCIDALOF.EEKAOKNJLKH(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x040022D3 RID: 8915
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			// Token: 0x040022D4 RID: 8916
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity = 1f;

			// Token: 0x040022D5 RID: 8917
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag = 0.2f;

			// Token: 0x040022D6 RID: 8918
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x040022D7 RID: 8919
			private Vector3 additiveOffset;

			// Token: 0x040022D8 RID: 8920
			private Vector3 lastOffset;

			// Token: 0x020004CC RID: 1228
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040022D9 RID: 8921
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040022DA RID: 8922
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}

		// Token: 0x020004CD RID: 1229
		[Serializable]
		public enum Handedness
		{
			// Token: 0x040022DC RID: 8924
			Right,
			// Token: 0x040022DD RID: 8925
			Left
		}
	}
}
