using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A3 RID: 1187
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x0601030E RID: 66318 RVA: 0x00741740 File Offset: 0x0073F940
		private void OFBOJDIDJDL(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].IEOMCCCKMCB(NKHBAJKMAGD);
			}
		}

		// Token: 0x0601030F RID: 66319 RVA: 0x0074176C File Offset: 0x0073F96C
		private void MMBOIENGOFP()
		{
			this.NBKOCJHAGOL();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i += 0)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = false;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.Normal;
			this.KCLACNEILLB.enabled = true;
			for (int k = 0; k < this.AHILGIJCPJA.Length; k++)
			{
				this.AHILGIJCPJA[k].DBKJJBNHHMB(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l += 0)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = true;
			}
			this.HJLOIHNCDOG = 1093f;
			this.FODJGBALLNF = 1948f;
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010310 RID: 66320 RVA: 0x00741884 File Offset: 0x0073FA84
		private void BOEFHGKGJMN()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.Normal || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.EMGNCCJKGAP();
			}
			this.BLMPHOICDPK = false;
			if (!this.LDDFGONJDGH())
			{
				this.NCODIAOMLKF();
			}
		}

		// Token: 0x06010311 RID: 66321 RVA: 0x007418D0 File Offset: 0x0073FAD0
		public void HHGGCBLOJGB()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 0 : 1;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x06010312 RID: 66322 RVA: 0x007419F5 File Offset: 0x0073FBF5
		private bool AMFMFCLLNOC()
		{
			return this.AHILGIJCPJA[1].AJMNDCHJPNK.isKinematic || this.KCLACNEILLB.enabled;
		}

		// Token: 0x06010313 RID: 66323 RVA: 0x00741A1B File Offset: 0x0073FC1B
		public void FHFKCJJKCJF()
		{
			if (!this.AMFMFCLLNOC())
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.LILNOHOHOLN());
		}

		// Token: 0x06010314 RID: 66324 RVA: 0x00741A40 File Offset: 0x0073FC40
		public void IMABGALEMBI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 0 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 0];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x00741B68 File Offset: 0x0073FD68
		public void HEMEEOGJDOE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HANBFOIKEKH));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 0 : 1;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j++)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x06010316 RID: 66326 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator MLJFPKBLDHD()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x06010317 RID: 66327 RVA: 0x00741C9C File Offset: 0x0073FE9C
		private void ECPECFPNLKP()
		{
			if (!this.NFJMGAFMCFC())
			{
				return;
			}
			if (!this.applyIkOnRagdoll)
			{
				bool flag = false;
				for (int i = 1; i < this.FPIEEFHGHOE.Length; i++)
				{
					if (this.FPIEEFHGHOE[i].enabled)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
					{
						this.BHLJPDPAFMF[j] = false;
					}
				}
				for (int k = 1; k < this.FPIEEFHGHOE.Length; k += 0)
				{
					if (this.FPIEEFHGHOE[k].enabled)
					{
						this.FPIEEFHGHOE[k].enabled = false;
						this.BHLJPDPAFMF[k] = true;
					}
				}
				return;
			}
			bool flag2 = false;
			for (int l = 1; l < this.FPIEEFHGHOE.Length; l++)
			{
				if (this.BHLJPDPAFMF[l])
				{
					flag2 = false;
					break;
				}
			}
			if (flag2)
			{
				for (int m = 0; m < this.FPIEEFHGHOE.Length; m += 0)
				{
					if (this.BHLJPDPAFMF[m])
					{
						this.FPIEEFHGHOE[m].enabled = true;
					}
				}
				for (int n = 1; n < this.FPIEEFHGHOE.Length; n++)
				{
					this.BHLJPDPAFMF[n] = false;
				}
			}
		}

		// Token: 0x06010318 RID: 66328 RVA: 0x00741DBE File Offset: 0x0073FFBE
		private bool KGGKLGNAPPG()
		{
			return this.AHILGIJCPJA[0].AJMNDCHJPNK.isKinematic || this.KCLACNEILLB.enabled;
		}

		// Token: 0x06010319 RID: 66329 RVA: 0x00741DE4 File Offset: 0x0073FFE4
		private void PCEOHENIMNL()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 1; i < ahilgijcpja.Length; i += 0)
			{
				ahilgijcpja[i].DEGHBKAIION();
			}
		}

		// Token: 0x0601031A RID: 66330 RVA: 0x00741E10 File Offset: 0x00740010
		private void CEFANDPICBK()
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].DBFKNNLCABO();
			}
		}

		// Token: 0x0601031B RID: 66331 RVA: 0x00741E3A File Offset: 0x0074003A
		public void DJKAEOFKAAA()
		{
			if (this.EDNCFDPNLDA())
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x0601031C RID: 66332 RVA: 0x00741E52 File Offset: 0x00740052
		public void JEECMAKCBFD()
		{
			if (!this.NFFBPDHJDAL())
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.KCAHNGKKAMN());
		}

		// Token: 0x0601031D RID: 66333 RVA: 0x00741E76 File Offset: 0x00740076
		private void JONHPGJKPBE()
		{
			if (this.AMFMFCLLNOC() && this.applyIkOnRagdoll)
			{
				this.FHHIAAHGCAK(65f);
			}
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0601031E RID: 66334 RVA: 0x00741E9C File Offset: 0x0074009C
		private void Update()
		{
			if (!this.PKDDOJDDIGG)
			{
				return;
			}
			if (!this.applyIkOnRagdoll)
			{
				bool flag = false;
				for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
				{
					if (this.FPIEEFHGHOE[i].enabled)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
					{
						this.BHLJPDPAFMF[j] = false;
					}
				}
				for (int k = 0; k < this.FPIEEFHGHOE.Length; k++)
				{
					if (this.FPIEEFHGHOE[k].enabled)
					{
						this.FPIEEFHGHOE[k].enabled = false;
						this.BHLJPDPAFMF[k] = true;
					}
				}
				return;
			}
			bool flag2 = false;
			for (int l = 0; l < this.FPIEEFHGHOE.Length; l++)
			{
				if (this.BHLJPDPAFMF[l])
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				for (int m = 0; m < this.FPIEEFHGHOE.Length; m++)
				{
					if (this.BHLJPDPAFMF[m])
					{
						this.FPIEEFHGHOE[m].enabled = true;
					}
				}
				for (int n = 0; n < this.FPIEEFHGHOE.Length; n++)
				{
					this.BHLJPDPAFMF[n] = false;
				}
			}
		}

		// Token: 0x0601031F RID: 66335 RVA: 0x00741FBE File Offset: 0x007401BE
		private void FixedUpdate()
		{
			if (this.PKDDOJDDIGG && this.applyIkOnRagdoll)
			{
				this.BLOEEPCIPKJ(1f);
			}
			this.BLMPHOICDPK = true;
		}

		// Token: 0x06010320 RID: 66336 RVA: 0x00741FE2 File Offset: 0x007401E2
		private void HANBFOIKEKH()
		{
			if (this.LDDFGONJDGH())
			{
				this.LFCHIPDCEBA();
			}
		}

		// Token: 0x06010321 RID: 66337 RVA: 0x00741FF4 File Offset: 0x007401F4
		private void EPFLELJKHAH()
		{
			this.MMOCGJEGKHL();
			for (int i = 1; i < this.FPIEEFHGHOE.Length; i += 0)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = true;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = true;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k += 0)
			{
				this.AHILGIJCPJA[k].DBKJJBNHHMB(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 1; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = false;
			}
			this.HJLOIHNCDOG = 1829f;
			this.FODJGBALLNF = 1778f;
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010322 RID: 66338 RVA: 0x0074210C File Offset: 0x0074030C
		private void HNAKGHHGDPE()
		{
			if (this.KGGKLGNAPPG() && this.applyIkOnRagdoll)
			{
				this.OFBOJDIDJDL(1063f);
			}
			this.BLMPHOICDPK = false;
		}

		// Token: 0x06010323 RID: 66339 RVA: 0x00742130 File Offset: 0x00740330
		private void OMGDANMPBAO()
		{
			this.AHAIAFNMOAC();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = true;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.Normal;
			this.KCLACNEILLB.enabled = true;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k += 0)
			{
				this.AHILGIJCPJA[k].FMHHMOMMPOA(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l += 0)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = false;
			}
			this.HJLOIHNCDOG = 676f;
			this.FODJGBALLNF = 1464f;
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010324 RID: 66340 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator MENMKDGKKBN()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x06010325 RID: 66341 RVA: 0x00742248 File Offset: 0x00740448
		private bool EDNCFDPNLDA()
		{
			return !this.AHILGIJCPJA[1].AJMNDCHJPNK.isKinematic && !this.KCLACNEILLB.enabled;
		}

		// Token: 0x06010326 RID: 66342 RVA: 0x0074226E File Offset: 0x0074046E
		public void HPLKDBEEGIH()
		{
			if (this.NFFBPDHJDAL())
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010327 RID: 66343 RVA: 0x00742286 File Offset: 0x00740486
		private void MIPHMELJJJD()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NFBKMIEFINM));
			}
		}

		// Token: 0x06010328 RID: 66344 RVA: 0x007422C2 File Offset: 0x007404C2
		private bool NFFBPDHJDAL()
		{
			return this.AHILGIJCPJA[0].AJMNDCHJPNK.isKinematic || !this.KCLACNEILLB.enabled;
		}

		// Token: 0x06010329 RID: 66345 RVA: 0x007422E8 File Offset: 0x007404E8
		public void PBMPJPIMJBF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JCCICELIEII));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 0 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x0601032A RID: 66346 RVA: 0x0074240D File Offset: 0x0074060D
		private void MNMGBKMJNEG()
		{
			if (this.KGGKLGNAPPG() && this.applyIkOnRagdoll)
			{
				this.FHHIAAHGCAK(733f);
			}
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0601032B RID: 66347 RVA: 0x00742431 File Offset: 0x00740631
		private IEnumerator HIDHLJJEKDB()
		{
			RagdollUtility.MKLGFCDNJDH mklgfcdnjdh = new RagdollUtility.MKLGFCDNJDH(1);
			mklgfcdnjdh.AENJLLPLILM = this;
			return mklgfcdnjdh;
		}

		// Token: 0x0601032C RID: 66348 RVA: 0x00742440 File Offset: 0x00740640
		public void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[0].gameObject == base.gameObject) ? 1 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j++)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x0601032D RID: 66349 RVA: 0x00742565 File Offset: 0x00740765
		private void PHLEMEDNPBN()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
		}

		// Token: 0x0601032E RID: 66350 RVA: 0x007425A4 File Offset: 0x007407A4
		private void ECMPHHFACDN()
		{
			this.MMOCGJEGKHL();
			for (int i = 1; i < this.FPIEEFHGHOE.Length; i += 0)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j += 0)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = true;
						this.BHLJPDPAFMF[j] = false;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.Normal;
			this.KCLACNEILLB.enabled = false;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k += 0)
			{
				this.AHILGIJCPJA[k].CJDKIEIPJNB(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = true;
			}
			this.HJLOIHNCDOG = 140f;
			this.FODJGBALLNF = 1042f;
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x0601032F RID: 66351 RVA: 0x00742565 File Offset: 0x00740765
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
		}

		// Token: 0x06010330 RID: 66352 RVA: 0x007426BC File Offset: 0x007408BC
		private bool LMMAHGPOGCI()
		{
			if (this.ik == null)
			{
				return true;
			}
			if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 1882f)
			{
				return false;
			}
			foreach (IK ik in this.FPIEEFHGHOE)
			{
				if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 226f)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06010331 RID: 66353 RVA: 0x00742738 File Offset: 0x00740938
		private bool LDDFGONJDGH()
		{
			if (this.ik == null)
			{
				return true;
			}
			if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 73f)
			{
				return false;
			}
			IK[] fpieefhghoe = this.FPIEEFHGHOE;
			for (int i = 0; i < fpieefhghoe.Length; i += 0)
			{
				IK ik = fpieefhghoe[i];
				if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 776f)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06010332 RID: 66354 RVA: 0x007427B1 File Offset: 0x007409B1
		private bool PKDDOJDDIGG
		{
			get
			{
				return !this.AHILGIJCPJA[0].AJMNDCHJPNK.isKinematic && !this.KCLACNEILLB.enabled;
			}
		}

		// Token: 0x06010333 RID: 66355 RVA: 0x00742431 File Offset: 0x00740631
		private IEnumerator GIANODPMACE()
		{
			RagdollUtility.MKLGFCDNJDH mklgfcdnjdh = new RagdollUtility.MKLGFCDNJDH(1);
			mklgfcdnjdh.AENJLLPLILM = this;
			return mklgfcdnjdh;
		}

		// Token: 0x06010334 RID: 66356 RVA: 0x007427D8 File Offset: 0x007409D8
		private void FHHIAAHGCAK(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].MJLPBJDMPMD(NKHBAJKMAGD);
			}
		}

		// Token: 0x06010335 RID: 66357 RVA: 0x00742803 File Offset: 0x00740A03
		private void NNNJNKDGLDF()
		{
			if (this.NFFBPDHJDAL() && this.applyIkOnRagdoll)
			{
				this.ONKILMOKJPE(1592f);
			}
			this.BLMPHOICDPK = true;
		}

		// Token: 0x06010336 RID: 66358 RVA: 0x007427B1 File Offset: 0x007409B1
		private bool MPPMKDDJBFH()
		{
			return !this.AHILGIJCPJA[0].AJMNDCHJPNK.isKinematic && !this.KCLACNEILLB.enabled;
		}

		// Token: 0x06010337 RID: 66359 RVA: 0x00742828 File Offset: 0x00740A28
		private bool INFGNNPKDMK()
		{
			if (this.ik == null)
			{
				return true;
			}
			if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 126f)
			{
				return true;
			}
			IK[] fpieefhghoe = this.FPIEEFHGHOE;
			for (int i = 1; i < fpieefhghoe.Length; i += 0)
			{
				IK ik = fpieefhghoe[i];
				if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 1770f)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x06010338 RID: 66360 RVA: 0x007428A1 File Offset: 0x00740AA1
		private void JCCICELIEII()
		{
			if (this.HJCMPFCNIBL())
			{
				this.NCODIAOMLKF();
			}
		}

		// Token: 0x06010339 RID: 66361 RVA: 0x007428B4 File Offset: 0x00740AB4
		private void EFKIAJCBENN()
		{
			this.AHAIAFNMOAC();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
			{
				this.BHLJPDPAFMF[i] = true;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = false;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = true;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k += 0)
			{
				this.AHILGIJCPJA[k].KDGHJKAOFLF(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 1; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = false;
			}
			this.HJLOIHNCDOG = 1112f;
			this.FODJGBALLNF = 1638f;
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x0601033A RID: 66362 RVA: 0x007429CC File Offset: 0x00740BCC
		private void DINOCBHPCIA()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 0; i < ahilgijcpja.Length; i += 0)
			{
				ahilgijcpja[i].DDGHBBLFMHE();
			}
		}

		// Token: 0x0601033B RID: 66363 RVA: 0x007429F8 File Offset: 0x00740BF8
		private void HFFLABNJOAG(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].AAGKCPIONNE(NKHBAJKMAGD);
			}
		}

		// Token: 0x0601033C RID: 66364 RVA: 0x00742565 File Offset: 0x00740765
		private void OLMFELBPCCP()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
		}

		// Token: 0x0601033D RID: 66365 RVA: 0x00742A24 File Offset: 0x00740C24
		private void HCMFEDKOPLJ()
		{
			this.CEFANDPICBK();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
			{
				this.BHLJPDPAFMF[i] = true;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = false;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = true;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k++)
			{
				this.AHILGIJCPJA[k].DLHHKKEHNBH(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 1; l < this.ONLACFLPDGA.Length; l += 0)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = false;
			}
			this.HJLOIHNCDOG = 974f;
			this.FODJGBALLNF = 131f;
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x0601033E RID: 66366 RVA: 0x00742B3C File Offset: 0x00740D3C
		public void GABOEBOKNBM()
		{
			if (this.KGGKLGNAPPG())
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x0601033F RID: 66367 RVA: 0x0074226E File Offset: 0x0074046E
		public void EACMDGBKHGD()
		{
			if (this.NFFBPDHJDAL())
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010340 RID: 66368 RVA: 0x00742B54 File Offset: 0x00740D54
		public void DMAOHJDKMNN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NFBKMIEFINM));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 1 : 1;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 0];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x06010341 RID: 66369 RVA: 0x00742C7C File Offset: 0x00740E7C
		private void HGOFLEEAIJK()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 1; i < ahilgijcpja.Length; i++)
			{
				ahilgijcpja[i].CDCPINJMDGB();
			}
		}

		// Token: 0x06010342 RID: 66370 RVA: 0x00742CA8 File Offset: 0x00740EA8
		public void CLHGHANANNL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NFBKMIEFINM));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[0].gameObject == base.gameObject) ? 0 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j++)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x06010343 RID: 66371 RVA: 0x00742DCD File Offset: 0x00740FCD
		public void EnableRagdoll()
		{
			if (this.PKDDOJDDIGG)
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010344 RID: 66372 RVA: 0x00742DE8 File Offset: 0x00740FE8
		private void JBFJPNKLLKI()
		{
			if (!this.FJAOEGGPLCM())
			{
				return;
			}
			if (!this.applyIkOnRagdoll)
			{
				bool flag = true;
				for (int i = 1; i < this.FPIEEFHGHOE.Length; i += 0)
				{
					if (this.FPIEEFHGHOE[i].enabled)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
					{
						this.BHLJPDPAFMF[j] = false;
					}
				}
				for (int k = 1; k < this.FPIEEFHGHOE.Length; k++)
				{
					if (this.FPIEEFHGHOE[k].enabled)
					{
						this.FPIEEFHGHOE[k].enabled = true;
						this.BHLJPDPAFMF[k] = false;
					}
				}
				return;
			}
			bool flag2 = true;
			for (int l = 1; l < this.FPIEEFHGHOE.Length; l++)
			{
				if (this.BHLJPDPAFMF[l])
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				for (int m = 0; m < this.FPIEEFHGHOE.Length; m += 0)
				{
					if (this.BHLJPDPAFMF[m])
					{
						this.FPIEEFHGHOE[m].enabled = true;
					}
				}
				for (int n = 0; n < this.FPIEEFHGHOE.Length; n++)
				{
					this.BHLJPDPAFMF[n] = true;
				}
			}
		}

		// Token: 0x06010345 RID: 66373 RVA: 0x00741A1B File Offset: 0x0073FC1B
		public void MMMPIDEEMHN()
		{
			if (!this.AMFMFCLLNOC())
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.LILNOHOHOLN());
		}

		// Token: 0x06010346 RID: 66374 RVA: 0x00742F0A File Offset: 0x0074110A
		private void BALDHKGGFDG()
		{
			if (this.FJAOEGGPLCM())
			{
				this.NBKOCJHAGOL();
				return;
			}
			this.BLOEEPCIPKJ(this.HJLOIHNCDOG);
		}

		// Token: 0x06010347 RID: 66375 RVA: 0x00742F28 File Offset: 0x00741128
		private void IJMFEHCAEMP()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 0; i < ahilgijcpja.Length; i++)
			{
				ahilgijcpja[i].PAOOFBFNKGH();
			}
		}

		// Token: 0x06010348 RID: 66376 RVA: 0x00742F52 File Offset: 0x00741152
		private void PMPBNLCGLCK()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEHDOFBAMCN));
			}
		}

		// Token: 0x06010349 RID: 66377 RVA: 0x00742F90 File Offset: 0x00741190
		private void ODLMLBGPFLL(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].CDONAFHONLH(NKHBAJKMAGD);
			}
		}

		// Token: 0x0601034A RID: 66378 RVA: 0x00742FBB File Offset: 0x007411BB
		private bool NFJMGAFMCFC()
		{
			return this.AHILGIJCPJA[1].AJMNDCHJPNK.isKinematic || !this.KCLACNEILLB.enabled;
		}

		// Token: 0x0601034C RID: 66380 RVA: 0x00743054 File Offset: 0x00741254
		private void OKHFFFMLCHI()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 0; i < ahilgijcpja.Length; i += 0)
			{
				ahilgijcpja[i].FINDNCAHEPH();
			}
		}

		// Token: 0x0601034D RID: 66381 RVA: 0x007428A1 File Offset: 0x00740AA1
		private void NFBKMIEFINM()
		{
			if (this.HJCMPFCNIBL())
			{
				this.NCODIAOMLKF();
			}
		}

		// Token: 0x0601034E RID: 66382 RVA: 0x00743080 File Offset: 0x00741280
		private void EANILKHGBKE()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.AnimatePhysics || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.BALDHKGGFDG();
			}
			this.BLMPHOICDPK = true;
			if (!this.LMMAHGPOGCI())
			{
				this.IJPFHKECJPC();
			}
		}

		// Token: 0x0601034F RID: 66383 RVA: 0x007430CC File Offset: 0x007412CC
		public void LGFMMAHDDFB()
		{
			if (!this.MPPMKDDJBFH())
			{
				return;
			}
			this.AHAIAFNMOAC();
			base.StopAllCoroutines();
			base.StartCoroutine(this.DJFCAMEFJMP());
		}

		// Token: 0x06010350 RID: 66384 RVA: 0x007430F0 File Offset: 0x007412F0
		private void GMHLDLHCPHF()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 0; i < ahilgijcpja.Length; i++)
			{
				ahilgijcpja[i].LMKDDIGFGLO();
			}
		}

		// Token: 0x06010351 RID: 66385 RVA: 0x0074311A File Offset: 0x0074131A
		public void HEAJADMBLGG()
		{
			if (!this.NFJMGAFMCFC())
			{
				return;
			}
			this.AHAIAFNMOAC();
			base.StopAllCoroutines();
			base.StartCoroutine(this.KCAHNGKKAMN());
		}

		// Token: 0x06010352 RID: 66386 RVA: 0x00743140 File Offset: 0x00741340
		private void PGJDBNCDPCC(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].EOCEBPHCEKI(NKHBAJKMAGD);
			}
		}

		// Token: 0x06010353 RID: 66387 RVA: 0x0074316C File Offset: 0x0074136C
		private void BNAGHNOEMFH()
		{
			RagdollUtility.MPBOBOLGEJC[] ahilgijcpja = this.AHILGIJCPJA;
			for (int i = 1; i < ahilgijcpja.Length; i += 0)
			{
				ahilgijcpja[i].IJIIIFDLJJO();
			}
		}

		// Token: 0x06010354 RID: 66388 RVA: 0x00742F52 File Offset: 0x00741152
		private void LCAFGJKANMJ()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEHDOFBAMCN));
			}
		}

		// Token: 0x06010355 RID: 66389 RVA: 0x00743198 File Offset: 0x00741398
		private void LateUpdate()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.AnimatePhysics || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics && this.BLMPHOICDPK))
			{
				this.JAFLABMKHGI();
			}
			this.BLMPHOICDPK = false;
			if (!this.CPHIKLICPMG)
			{
				this.IJPFHKECJPC();
			}
		}

		// Token: 0x06010356 RID: 66390 RVA: 0x007431E4 File Offset: 0x007413E4
		private void MMOCGJEGKHL()
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].DNLNIEDBLAC();
			}
		}

		// Token: 0x06010357 RID: 66391 RVA: 0x0074320E File Offset: 0x0074140E
		private void KJGPKCLBLJA()
		{
			if (this.PKDDOJDDIGG && this.applyIkOnRagdoll)
			{
				this.JHIECFMHHNC(371f);
			}
			this.BLMPHOICDPK = false;
		}

		// Token: 0x06010358 RID: 66392 RVA: 0x00743234 File Offset: 0x00741434
		public void CGNGBFFGGBP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JCCICELIEII));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 0 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 1; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x06010359 RID: 66393 RVA: 0x00743359 File Offset: 0x00741559
		public void GOIGBPIKJCN()
		{
			if (!this.PKDDOJDDIGG)
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.MLJFPKBLDHD());
		}

		// Token: 0x0601035A RID: 66394 RVA: 0x00743380 File Offset: 0x00741580
		private void AHAIAFNMOAC()
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].OHKJBOOCODE();
			}
		}

		// Token: 0x0601035B RID: 66395 RVA: 0x007433AA File Offset: 0x007415AA
		public void GLHFGFKPIPI()
		{
			if (!this.NFFBPDHJDAL())
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.LILNOHOHOLN());
		}

		// Token: 0x0601035C RID: 66396 RVA: 0x007433D0 File Offset: 0x007415D0
		private void IGHOFPIMNBN()
		{
			this.AHAIAFNMOAC();
			for (int i = 1; i < this.FPIEEFHGHOE.Length; i += 0)
			{
				this.BHLJPDPAFMF[i] = true;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j += 0)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = true;
						this.BHLJPDPAFMF[j] = false;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = false;
			for (int k = 1; k < this.AHILGIJCPJA.Length; k++)
			{
				this.AHILGIJCPJA[k].OJNLPNKNAEF(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = true;
			}
			this.HJLOIHNCDOG = 95f;
			this.FODJGBALLNF = 276f;
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x0601035D RID: 66397 RVA: 0x007434E8 File Offset: 0x007416E8
		public void ELFALPCLKIE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HANBFOIKEKH));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[0].gameObject == base.gameObject) ? 0 : 1;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 0)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 1; j < this.NJONNOOBGPJ.Length; j += 0)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x0601035E RID: 66398 RVA: 0x0074360D File Offset: 0x0074180D
		private void JHAPJJGJPMN()
		{
			if (this.MPPMKDDJBFH() && this.applyIkOnRagdoll)
			{
				this.HFFLABNJOAG(348f);
			}
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0601035F RID: 66399 RVA: 0x00742431 File Offset: 0x00740631
		private IEnumerator DJFCAMEFJMP()
		{
			RagdollUtility.MKLGFCDNJDH mklgfcdnjdh = new RagdollUtility.MKLGFCDNJDH(1);
			mklgfcdnjdh.AENJLLPLILM = this;
			return mklgfcdnjdh;
		}

		// Token: 0x06010360 RID: 66400 RVA: 0x00743634 File Offset: 0x00741834
		private void GFELHLPHCDN()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.AnimatePhysics || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.BALDHKGGFDG();
			}
			this.BLMPHOICDPK = false;
			if (!this.INFGNNPKDMK())
			{
				this.LFCHIPDCEBA();
			}
		}

		// Token: 0x06010361 RID: 66401 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator KCAHNGKKAMN()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x06010362 RID: 66402 RVA: 0x00743680 File Offset: 0x00741880
		private void PNAPPHLKMIG()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JCCICELIEII));
			}
		}

		// Token: 0x06010363 RID: 66403 RVA: 0x007436BC File Offset: 0x007418BC
		private void MBIBECPJANF()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.AnimatePhysics || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.JAFLABMKHGI();
			}
			this.BLMPHOICDPK = true;
			if (!this.HJCMPFCNIBL())
			{
				this.LFCHIPDCEBA();
			}
		}

		// Token: 0x06010364 RID: 66404 RVA: 0x00743708 File Offset: 0x00741908
		public void FFIGGPHAIBP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[1].gameObject == base.gameObject) ? 1 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i += 0)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j++)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x06010365 RID: 66405 RVA: 0x00743830 File Offset: 0x00741A30
		private void GIKJMPHFJKH()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.Normal || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.EMGNCCJKGAP();
			}
			this.BLMPHOICDPK = false;
			if (!this.LDDFGONJDGH())
			{
				this.IJPFHKECJPC();
			}
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x0074387C File Offset: 0x00741A7C
		public void LFDBKGFHHON()
		{
			if (!this.NFJMGAFMCFC())
			{
				return;
			}
			this.CEFANDPICBK();
			base.StopAllCoroutines();
			base.StartCoroutine(this.GIANODPMACE());
		}

		// Token: 0x06010367 RID: 66407 RVA: 0x007438A0 File Offset: 0x00741AA0
		private void IJPFHKECJPC()
		{
			if (!this.PKDDOJDDIGG)
			{
				this.IJMFEHCAEMP();
			}
			if (this.DDDOGHKDLIL)
			{
				this.JFJBOGAKEBL();
			}
		}

		// Token: 0x06010368 RID: 66408 RVA: 0x007438BE File Offset: 0x00741ABE
		private void JAFLABMKHGI()
		{
			if (this.PKDDOJDDIGG)
			{
				this.NBKOCJHAGOL();
				return;
			}
			this.BLOEEPCIPKJ(this.HJLOIHNCDOG);
		}

		// Token: 0x06010369 RID: 66409 RVA: 0x007438DC File Offset: 0x00741ADC
		private bool HJCMPFCNIBL()
		{
			if (this.ik == null)
			{
				return true;
			}
			if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 719f)
			{
				return true;
			}
			foreach (IK ik in this.FPIEEFHGHOE)
			{
				if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 821f)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x00743958 File Offset: 0x00741B58
		private void JHIECFMHHNC(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].OHOKMMJNFLD(NKHBAJKMAGD);
			}
		}

		// Token: 0x0601036B RID: 66411 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator MEIOOBJCOFF()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0601036C RID: 66412 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator LILNOHOHOLN()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0601036D RID: 66413 RVA: 0x00742F52 File Offset: 0x00741152
		private void ALPOPEGDHBL()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEHDOFBAMCN));
			}
		}

		// Token: 0x0601036E RID: 66414 RVA: 0x00743983 File Offset: 0x00741B83
		private void HBAHMBGCGAB()
		{
			if (this.KGGKLGNAPPG() && this.applyIkOnRagdoll)
			{
				this.ONKILMOKJPE(987f);
			}
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0601036F RID: 66415 RVA: 0x00742565 File Offset: 0x00740765
		private void IEHOIMHFICG()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CPOOEHFCGKO));
			}
		}

		// Token: 0x06010370 RID: 66416 RVA: 0x007439A8 File Offset: 0x00741BA8
		private void BLOEEPCIPKJ(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].MKDGKDPKLBL(NKHBAJKMAGD);
			}
		}

		// Token: 0x06010371 RID: 66417 RVA: 0x007439D3 File Offset: 0x00741BD3
		public void DisableRagdoll()
		{
			if (!this.PKDDOJDDIGG)
			{
				return;
			}
			this.NBKOCJHAGOL();
			base.StopAllCoroutines();
			base.StartCoroutine(this.CCBBCKHPJEM());
		}

		// Token: 0x06010372 RID: 66418 RVA: 0x007439F8 File Offset: 0x00741BF8
		private void GCLIAEKCANG()
		{
			this.AHAIAFNMOAC();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j += 0)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = false;
						this.BHLJPDPAFMF[j] = false;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = true;
			for (int k = 0; k < this.AHILGIJCPJA.Length; k++)
			{
				this.AHILGIJCPJA[k].JEBIPHEDLCF(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = true;
			}
			this.HJLOIHNCDOG = 378f;
			this.FODJGBALLNF = 979f;
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x06010373 RID: 66419 RVA: 0x00743B10 File Offset: 0x00741D10
		private void NAAOMMIEBAC()
		{
			this.MMOCGJEGKHL();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i += 0)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 1; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = true;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.Normal;
			this.KCLACNEILLB.enabled = false;
			for (int k = 0; k < this.AHILGIJCPJA.Length; k += 0)
			{
				this.AHILGIJCPJA[k].DIPILMBKGBF(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 1; l < this.ONLACFLPDGA.Length; l += 0)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = true;
			}
			this.HJLOIHNCDOG = 215f;
			this.FODJGBALLNF = 574f;
			this.DDDOGHKDLIL = true;
		}

		// Token: 0x06010374 RID: 66420 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator CCBBCKHPJEM()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x06010375 RID: 66421 RVA: 0x00743C28 File Offset: 0x00741E28
		public void GHCMIKGJPJD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FPIEEFHGHOE = base.GetComponentsInChildren<IK>();
			this.BHLJPDPAFMF = new bool[this.FPIEEFHGHOE.Length];
			this.ONLACFLPDGA = new bool[this.FPIEEFHGHOE.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEHDOFBAMCN));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[0].gameObject == base.gameObject) ? 0 : 0;
			this.AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 1; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i] = new RagdollUtility.MPBOBOLGEJC(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.NJONNOOBGPJ.Length; j++)
			{
				this.NJONNOOBGPJ[j] = new RagdollUtility.HBIOEBEOFCG(componentsInChildren2[j + 0]);
			}
		}

		// Token: 0x06010376 RID: 66422 RVA: 0x00743D50 File Offset: 0x00741F50
		private void PPIJKKNAJAC()
		{
			if (this.KCLACNEILLB.updateMode != AnimatorUpdateMode.Normal || (this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal && this.BLMPHOICDPK))
			{
				this.BALDHKGGFDG();
			}
			this.BLMPHOICDPK = true;
			if (!this.INFGNNPKDMK())
			{
				this.LFCHIPDCEBA();
			}
		}

		// Token: 0x06010377 RID: 66423 RVA: 0x00743D9C File Offset: 0x00741F9C
		public void MGAPOJHEDNL()
		{
			if (this.NFJMGAFMCFC())
			{
				return;
			}
			base.StopAllCoroutines();
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x06010378 RID: 66424 RVA: 0x00743DB4 File Offset: 0x00741FB4
		private void FEHDOFBAMCN()
		{
			if (this.INFGNNPKDMK())
			{
				this.IJPFHKECJPC();
			}
		}

		// Token: 0x06010379 RID: 66425 RVA: 0x00743DC4 File Offset: 0x00741FC4
		private void NBKOCJHAGOL()
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].NBKOCJHAGOL();
			}
		}

		// Token: 0x0601037A RID: 66426 RVA: 0x00741C8D File Offset: 0x0073FE8D
		private IEnumerator EJMJMAHGMJO()
		{
			for (int i = 0; i < this.AHILGIJCPJA.Length; i++)
			{
				this.AHILGIJCPJA[i].AJMNDCHJPNK.isKinematic = true;
			}
			for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
			{
				this.FPIEEFHGHOE[j].fixTransforms = this.ONLACFLPDGA[j];
				if (this.BHLJPDPAFMF[j])
				{
					this.FPIEEFHGHOE[j].enabled = true;
				}
			}
			this.KCLACNEILLB.updateMode = this.JEIOGJMMLAD;
			this.KCLACNEILLB.enabled = true;
			while (this.HJLOIHNCDOG > 0f)
			{
				this.HJLOIHNCDOG = Mathf.SmoothDamp(this.HJLOIHNCDOG, 0f, ref this.FODJGBALLNF, this.ragdollToAnimationTime);
				if (this.HJLOIHNCDOG < 0.001f)
				{
					this.HJLOIHNCDOG = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x0601037B RID: 66427 RVA: 0x00742431 File Offset: 0x00740631
		private IEnumerator GJLOLIPFCEM()
		{
			RagdollUtility.MKLGFCDNJDH mklgfcdnjdh = new RagdollUtility.MKLGFCDNJDH(1);
			mklgfcdnjdh.AENJLLPLILM = this;
			return mklgfcdnjdh;
		}

		// Token: 0x0601037C RID: 66428 RVA: 0x00743DEE File Offset: 0x00741FEE
		private void LFCHIPDCEBA()
		{
			if (!this.KGGKLGNAPPG())
			{
				this.IJMFEHCAEMP();
			}
			if (this.DDDOGHKDLIL)
			{
				this.MMBOIENGOFP();
			}
		}

		// Token: 0x0601037D RID: 66429 RVA: 0x007427B1 File Offset: 0x007409B1
		private bool FJAOEGGPLCM()
		{
			return !this.AHILGIJCPJA[0].AJMNDCHJPNK.isKinematic && !this.KCLACNEILLB.enabled;
		}

		// Token: 0x0601037E RID: 66430 RVA: 0x00743E0C File Offset: 0x0074200C
		private void LOEFJHKBMIM()
		{
			if (this.NFFBPDHJDAL() && this.applyIkOnRagdoll)
			{
				this.BLOEEPCIPKJ(917f);
			}
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0601037F RID: 66431 RVA: 0x00743E30 File Offset: 0x00742030
		private void NCODIAOMLKF()
		{
			if (!this.AMFMFCLLNOC())
			{
				this.BNAGHNOEMFH();
			}
			if (this.DDDOGHKDLIL)
			{
				this.MMBOIENGOFP();
			}
		}

		// Token: 0x06010380 RID: 66432 RVA: 0x00743E50 File Offset: 0x00742050
		private void ONKILMOKJPE(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i += 0)
			{
				njonnoobgpj[i].PDCFJBELAMG(NKHBAJKMAGD);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06010381 RID: 66433 RVA: 0x00743E7C File Offset: 0x0074207C
		private bool CPHIKLICPMG
		{
			get
			{
				if (this.ik == null)
				{
					return false;
				}
				if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 0f)
				{
					return true;
				}
				foreach (IK ik in this.FPIEEFHGHOE)
				{
					if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 0f)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06010382 RID: 66434 RVA: 0x00743680 File Offset: 0x00741880
		private void BCNGPIGDICE()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JCCICELIEII));
			}
		}

		// Token: 0x06010383 RID: 66435 RVA: 0x00743EF8 File Offset: 0x007420F8
		private void KNGFPALEBBN(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 0; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].OMFEPANOMDC(NKHBAJKMAGD);
			}
		}

		// Token: 0x06010384 RID: 66436 RVA: 0x00743F23 File Offset: 0x00742123
		private void CIEPONCEJPH()
		{
			if (this.MPPMKDDJBFH())
			{
				this.AHAIAFNMOAC();
				return;
			}
			this.ODLMLBGPFLL(this.HJLOIHNCDOG);
		}

		// Token: 0x06010385 RID: 66437 RVA: 0x00743F40 File Offset: 0x00742140
		private void NNJABLBFDBD(float NKHBAJKMAGD)
		{
			RagdollUtility.HBIOEBEOFCG[] njonnoobgpj = this.NJONNOOBGPJ;
			for (int i = 1; i < njonnoobgpj.Length; i++)
			{
				njonnoobgpj[i].OHOKMMJNFLD(NKHBAJKMAGD);
			}
		}

		// Token: 0x06010386 RID: 66438 RVA: 0x00743F6B File Offset: 0x0074216B
		private void EMGNCCJKGAP()
		{
			if (this.PKDDOJDDIGG)
			{
				this.MMOCGJEGKHL();
				return;
			}
			this.OFBOJDIDJDL(this.HJLOIHNCDOG);
		}

		// Token: 0x06010387 RID: 66439 RVA: 0x00743F88 File Offset: 0x00742188
		private void CPOOEHFCGKO()
		{
			if (this.CPHIKLICPMG)
			{
				this.IJPFHKECJPC();
			}
		}

		// Token: 0x06010388 RID: 66440 RVA: 0x00743F98 File Offset: 0x00742198
		private void JFJBOGAKEBL()
		{
			this.NBKOCJHAGOL();
			for (int i = 0; i < this.FPIEEFHGHOE.Length; i++)
			{
				this.BHLJPDPAFMF[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 0; j < this.FPIEEFHGHOE.Length; j++)
				{
					if (this.FPIEEFHGHOE[j].enabled)
					{
						this.FPIEEFHGHOE[j].enabled = false;
						this.BHLJPDPAFMF[j] = true;
					}
				}
			}
			this.JEIOGJMMLAD = this.KCLACNEILLB.updateMode;
			this.KCLACNEILLB.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.KCLACNEILLB.enabled = false;
			for (int k = 0; k < this.AHILGIJCPJA.Length; k++)
			{
				this.AHILGIJCPJA[k].IEJJOPEKGFB(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.ONLACFLPDGA.Length; l++)
			{
				this.ONLACFLPDGA[l] = this.FPIEEFHGHOE[l].fixTransforms;
				this.FPIEEFHGHOE[l].fixTransforms = false;
			}
			this.HJLOIHNCDOG = 1f;
			this.FODJGBALLNF = 0f;
			this.DDDOGHKDLIL = false;
		}

		// Token: 0x0400220A RID: 8714
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		// Token: 0x0400220B RID: 8715
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime = 0.2f;

		// Token: 0x0400220C RID: 8716
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		// Token: 0x0400220D RID: 8717
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity = 1f;

		// Token: 0x0400220E RID: 8718
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity = 1f;

		// Token: 0x0400220F RID: 8719
		private Animator KCLACNEILLB;

		// Token: 0x04002210 RID: 8720
		private RagdollUtility.MPBOBOLGEJC[] AHILGIJCPJA = new RagdollUtility.MPBOBOLGEJC[0];

		// Token: 0x04002211 RID: 8721
		private RagdollUtility.HBIOEBEOFCG[] NJONNOOBGPJ = new RagdollUtility.HBIOEBEOFCG[0];

		// Token: 0x04002212 RID: 8722
		private bool DDDOGHKDLIL;

		// Token: 0x04002213 RID: 8723
		private AnimatorUpdateMode JEIOGJMMLAD;

		// Token: 0x04002214 RID: 8724
		private IK[] FPIEEFHGHOE = new IK[0];

		// Token: 0x04002215 RID: 8725
		private bool[] ONLACFLPDGA = new bool[0];

		// Token: 0x04002216 RID: 8726
		private float HJLOIHNCDOG;

		// Token: 0x04002217 RID: 8727
		private float FODJGBALLNF;

		// Token: 0x04002218 RID: 8728
		private bool BLMPHOICDPK;

		// Token: 0x04002219 RID: 8729
		private bool[] BHLJPDPAFMF = new bool[0];

		// Token: 0x020004A4 RID: 1188
		public class MPBOBOLGEJC
		{
			// Token: 0x06010389 RID: 66441 RVA: 0x007440B0 File Offset: 0x007422B0
			public void BDAHDPMAEPK(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 343f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 126f)
				{
					float num = 1820f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1640f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601038A RID: 66442 RVA: 0x00744184 File Offset: 0x00742384
			public void CDCPINJMDGB()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x0601038B RID: 66443 RVA: 0x007441F8 File Offset: 0x007423F8
			public void DIPILMBKGBF(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 934f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 441f)
				{
					float num = 1599f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1414f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601038C RID: 66444 RVA: 0x007442CC File Offset: 0x007424CC
			public void OJNLPNKNAEF(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 30f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 580f)
				{
					float num = 1586f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 980f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601038D RID: 66445 RVA: 0x007443A0 File Offset: 0x007425A0
			public void KLJHAMKPAHE()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x0601038E RID: 66446 RVA: 0x00744414 File Offset: 0x00742614
			public void KOJGCDHEEJB(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 800f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 95f)
				{
					float num = 1933f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 477f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601038F RID: 66447 RVA: 0x007444E8 File Offset: 0x007426E8
			public void NAKMGEFBJFP(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1727f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 279f)
				{
					float num = 1008f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1331f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x06010390 RID: 66448 RVA: 0x007445BC File Offset: 0x007427BC
			public void AKFPKMOOIJK()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010391 RID: 66449 RVA: 0x00744630 File Offset: 0x00742830
			public void LHMOJDAMPFJ()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010392 RID: 66450 RVA: 0x007446A4 File Offset: 0x007428A4
			public void PMGMKFBNLLK()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010393 RID: 66451 RVA: 0x00744718 File Offset: 0x00742918
			public void FJMNLPAKNPM()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010394 RID: 66452 RVA: 0x0074478C File Offset: 0x0074298C
			public void AMEOBEBLPMI(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1939f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 422f)
				{
					float num = 1446f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1367f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x06010395 RID: 66453 RVA: 0x00744860 File Offset: 0x00742A60
			public void IEIPKIBFEJE(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 855f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 791f)
				{
					float num = 433f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 425f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x06010396 RID: 66454 RVA: 0x00744934 File Offset: 0x00742B34
			public void FMEGKKFFANK(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 233f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 978f)
				{
					float num = 733f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1566f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x06010397 RID: 66455 RVA: 0x00744A08 File Offset: 0x00742C08
			public void PAOOFBFNKGH()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010398 RID: 66456 RVA: 0x00744A7C File Offset: 0x00742C7C
			public void EOHEOIMCDEO()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x06010399 RID: 66457 RVA: 0x00744AF0 File Offset: 0x00742CF0
			public void KPMGJJFFPIA()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x0601039A RID: 66458 RVA: 0x00744B64 File Offset: 0x00742D64
			public void DBKJJBNHHMB(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1801f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 227f)
				{
					float num = 1941f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1246f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601039B RID: 66459 RVA: 0x00744C38 File Offset: 0x00742E38
			public void DIKICPIMHCN(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1341f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1595f)
				{
					float num = 1998f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 78f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601039C RID: 66460 RVA: 0x00744D0C File Offset: 0x00742F0C
			public void HGGJIBCGBLJ(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 167f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1400f)
				{
					float num = 1267f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 333f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601039D RID: 66461 RVA: 0x00744DE0 File Offset: 0x00742FE0
			public void CJDKIEIPJNB(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 196f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 550f)
				{
					float num = 868f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1593f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601039E RID: 66462 RVA: 0x00744EB4 File Offset: 0x007430B4
			public void FJABFGEJIIB(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1784f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1901f)
				{
					float num = 896f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1830f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x0601039F RID: 66463 RVA: 0x00744F88 File Offset: 0x00743188
			public void JEBIPHEDLCF(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 744f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 277f)
				{
					float num = 1149f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 57f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103A0 RID: 66464 RVA: 0x0074505C File Offset: 0x0074325C
			public void DDGHBBLFMHE()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A1 RID: 66465 RVA: 0x007450D0 File Offset: 0x007432D0
			public void EKMECAFOOND(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1363f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1333f)
				{
					float num = 184f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1448f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103A2 RID: 66466 RVA: 0x007451A4 File Offset: 0x007433A4
			public void NGOCOAENENB()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A3 RID: 66467 RVA: 0x00745218 File Offset: 0x00743418
			public void CHLADGAGPFM()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A4 RID: 66468 RVA: 0x0074528C File Offset: 0x0074348C
			public void PBDBGKILBFF()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A5 RID: 66469 RVA: 0x00745300 File Offset: 0x00743500
			public void MNCLNNLCOIH(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1835f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1764f)
				{
					float num = 1890f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 354f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103A6 RID: 66470 RVA: 0x007453D4 File Offset: 0x007435D4
			public void PKIFNOGPOIJ()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A7 RID: 66471 RVA: 0x00745448 File Offset: 0x00743648
			public void IJIIIFDLJJO()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A8 RID: 66472 RVA: 0x007454BC File Offset: 0x007436BC
			public void HNLFAFJODJG()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103A9 RID: 66473 RVA: 0x00745530 File Offset: 0x00743730
			public void GPPJILFMPED(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1133f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1766f)
				{
					float num = 668f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 62f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103AA RID: 66474 RVA: 0x00745604 File Offset: 0x00743804
			public void HKKFJGCNGFA(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 477f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 903f)
				{
					float num = 9f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1811f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103AB RID: 66475 RVA: 0x007456D8 File Offset: 0x007438D8
			public void ABLGIIOOIOH(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1487f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1004f)
				{
					float num = 1768f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1493f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103AC RID: 66476 RVA: 0x007457AC File Offset: 0x007439AC
			public void FOGCIHDDMCO()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103AD RID: 66477 RVA: 0x00745820 File Offset: 0x00743A20
			public void GNGCMIIGDBC()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103AE RID: 66478 RVA: 0x00745894 File Offset: 0x00743A94
			public void MGBJMEDGANH(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 873f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1077f)
				{
					float num = 1488f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1018f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103AF RID: 66479 RVA: 0x00745968 File Offset: 0x00743B68
			public void KEKHAOFNAAB()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B0 RID: 66480 RVA: 0x007459DC File Offset: 0x00743BDC
			public void HACAPKIJFPK()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B1 RID: 66481 RVA: 0x00745A50 File Offset: 0x00743C50
			public void ECNLACKKHND()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B2 RID: 66482 RVA: 0x00745AC4 File Offset: 0x00743CC4
			public void FKIFMPKECLG()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B3 RID: 66483 RVA: 0x00745B38 File Offset: 0x00743D38
			public void JAPNDFNNIFP(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 223f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 624f)
				{
					float num = 546f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 673f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103B4 RID: 66484 RVA: 0x00745C0C File Offset: 0x00743E0C
			public void PDLKBGEHLOA()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B5 RID: 66485 RVA: 0x00745C80 File Offset: 0x00743E80
			public void OJEICMALOHA(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 224f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 553f)
				{
					float num = 179f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1688f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103B6 RID: 66486 RVA: 0x00745D54 File Offset: 0x00743F54
			public void INIFAHMKPDD()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B7 RID: 66487 RVA: 0x00745DC8 File Offset: 0x00743FC8
			public void DIAAAINPDKC()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103B8 RID: 66488 RVA: 0x00745E3C File Offset: 0x0074403C
			public void JBNOJFGFMBA(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1145f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1207f)
				{
					float num = 1338f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1188f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103B9 RID: 66489 RVA: 0x00745F10 File Offset: 0x00744110
			public void FFBDIOOCDHL()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103BA RID: 66490 RVA: 0x00745F84 File Offset: 0x00744184
			public void AANEIIHNGCO(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 381f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1418f)
				{
					float num = 383f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1128f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103BB RID: 66491 RVA: 0x00746058 File Offset: 0x00744258
			public MPBOBOLGEJC(Rigidbody AJMNDCHJPNK)
			{
				this.AJMNDCHJPNK = AJMNDCHJPNK;
				this.JAHNHOCNJGM = AJMNDCHJPNK.transform;
				this.OMKANNGJEEC = this.JAHNHOCNJGM.GetComponent<Joint>();
				this.JNBDKOKIPEC = this.JAHNHOCNJGM.GetComponent<Collider>();
				if (this.OMKANNGJEEC != null)
				{
					this.OAGAHEAMIAB = this.OMKANNGJEEC.connectedBody;
					this.LGMHDFEODHC = (this.OAGAHEAMIAB != null);
				}
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
			}

			// Token: 0x060103BC RID: 66492 RVA: 0x007460F4 File Offset: 0x007442F4
			public void PECMHOLAEBN()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103BD RID: 66493 RVA: 0x00746168 File Offset: 0x00744368
			public void FMHHMOMMPOA(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 626f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1943f)
				{
					float num = 1250f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1244f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103BE RID: 66494 RVA: 0x0074623C File Offset: 0x0074443C
			public void GLFPPIIDEFK(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 332f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 981f)
				{
					float num = 1539f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 950f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103BF RID: 66495 RVA: 0x00746310 File Offset: 0x00744510
			public void IFLLNGAPMFG(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1077f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1884f)
				{
					float num = 380f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 351f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103C0 RID: 66496 RVA: 0x007463E4 File Offset: 0x007445E4
			public void KDGHJKAOFLF(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 408f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1136f)
				{
					float num = 977f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 733f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103C1 RID: 66497 RVA: 0x007464B8 File Offset: 0x007446B8
			public void DLHHKKEHNBH(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 437f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 76f)
				{
					float num = 788f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1129f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103C2 RID: 66498 RVA: 0x0074658C File Offset: 0x0074478C
			public void BFBGPDJPKFI()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103C3 RID: 66499 RVA: 0x00746600 File Offset: 0x00744800
			public void OHJPLOBBMBM()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103C4 RID: 66500 RVA: 0x00746674 File Offset: 0x00744874
			public void AAGNAOEIEHB()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103C5 RID: 66501 RVA: 0x007466E8 File Offset: 0x007448E8
			public void HHNHOEHOCAF(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 377f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 111f)
				{
					float num = 1500f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1489f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103C6 RID: 66502 RVA: 0x007467BC File Offset: 0x007449BC
			public void MDHIGIHAGLD()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103C7 RID: 66503 RVA: 0x00746830 File Offset: 0x00744A30
			public void AJFBLELICPI(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 991f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1650f)
				{
					float num = 1902f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1935f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103C8 RID: 66504 RVA: 0x00746904 File Offset: 0x00744B04
			public void GAEEENLPFNJ()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103C9 RID: 66505 RVA: 0x00746978 File Offset: 0x00744B78
			public void FELMDIBILDA()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103CA RID: 66506 RVA: 0x007469EC File Offset: 0x00744BEC
			public void LIJOHMPHHBM(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 596f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 632f)
				{
					float num = 515f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1437f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103CB RID: 66507 RVA: 0x00746AC0 File Offset: 0x00744CC0
			public void NMHBCNNMJEI()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103CC RID: 66508 RVA: 0x00746B34 File Offset: 0x00744D34
			public void IEJJOPEKGFB(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 0f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 0f)
				{
					float num = 0f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 0.017453292f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103CD RID: 66509 RVA: 0x00746C08 File Offset: 0x00744E08
			public void HKOGPFPOOCP()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103CE RID: 66510 RVA: 0x00746C7C File Offset: 0x00744E7C
			public void DEGHBKAIION()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103CF RID: 66511 RVA: 0x00746CF0 File Offset: 0x00744EF0
			public void ECOAHLMBMJG(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1752f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 627f)
				{
					float num = 1247f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 122f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103D0 RID: 66512 RVA: 0x00746DC4 File Offset: 0x00744FC4
			public void AILGPPCIEFC(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 515f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 111f)
				{
					float num = 650f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 511f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103D1 RID: 66513 RVA: 0x00746E98 File Offset: 0x00745098
			public void OOKPDGJIODA(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1569f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1328f)
				{
					float num = 643f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 957f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103D2 RID: 66514 RVA: 0x00746F6C File Offset: 0x0074516C
			public void MFEHIHIMNHD(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1393f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1085f)
				{
					float num = 640f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1807f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103D3 RID: 66515 RVA: 0x00747040 File Offset: 0x00745240
			public void LFGKIEABGMD()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103D4 RID: 66516 RVA: 0x007470B4 File Offset: 0x007452B4
			public void AJNOHAANJDP(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1462f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1999f)
				{
					float num = 1590f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 867f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103D5 RID: 66517 RVA: 0x00747188 File Offset: 0x00745388
			public void CBMKLJLKNGG()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103D6 RID: 66518 RVA: 0x007471FC File Offset: 0x007453FC
			public void EJPPKMMECJL()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103D7 RID: 66519 RVA: 0x00747270 File Offset: 0x00745470
			public void LMKDDIGFGLO()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103D8 RID: 66520 RVA: 0x007472E4 File Offset: 0x007454E4
			public void IJNNOAIODME()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103D9 RID: 66521 RVA: 0x00747358 File Offset: 0x00745558
			public void DPEFOHHKNNE(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 412f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1069f)
				{
					float num = 54f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1897f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103DA RID: 66522 RVA: 0x0074742C File Offset: 0x0074562C
			public void HCJCKFHMBIC(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 109f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 401f)
				{
					float num = 65f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1833f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103DB RID: 66523 RVA: 0x00747500 File Offset: 0x00745700
			public void FANGNHDGOCC(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 287f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1978f)
				{
					float num = 1845f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 967f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103DC RID: 66524 RVA: 0x007475D4 File Offset: 0x007457D4
			public void DLLAOLEICBA()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103DD RID: 66525 RVA: 0x00747648 File Offset: 0x00745848
			public void HMIINDJGJOC(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = false;
				if (IFLOMLPFLFN != 1561f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1276f)
				{
					float num = 349f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1157f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103DE RID: 66526 RVA: 0x0074771C File Offset: 0x0074591C
			public void JHJONGJLHLB()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103DF RID: 66527 RVA: 0x00747790 File Offset: 0x00745990
			public void FINDNCAHEPH()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103E0 RID: 66528 RVA: 0x00747804 File Offset: 0x00745A04
			public void BFAFNODLJIE()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103E1 RID: 66529 RVA: 0x00747878 File Offset: 0x00745A78
			public void MHPMCEHHMML()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x060103E2 RID: 66530 RVA: 0x007478EC File Offset: 0x00745AEC
			public void PKMECENCJGO(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 627f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 626f)
				{
					float num = 468f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 345f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103E3 RID: 66531 RVA: 0x007479C0 File Offset: 0x00745BC0
			public void BPEPMIIDCCJ(float IFLOMLPFLFN, float ILJOGOBJLNG)
			{
				if (this.LGMHDFEODHC)
				{
					this.OMKANNGJEEC.connectedAnchor = this.JAHNHOCNJGM.InverseTransformPoint(this.OAGAHEAMIAB.position);
				}
				this.AJMNDCHJPNK.isKinematic = true;
				if (IFLOMLPFLFN != 1947f)
				{
					this.AJMNDCHJPNK.velocity = this.JJGHJJONFIA / this.ENLHBNBNPJN * IFLOMLPFLFN;
				}
				if (ILJOGOBJLNG != 1265f)
				{
					float num = 1380f;
					Vector3 vector = Vector3.zero;
					this.MDAFOPGGGEM.ToAngleAxis(out num, out vector);
					num *= 1918f;
					num /= this.ENLHBNBNPJN;
					vector *= num * ILJOGOBJLNG;
					this.AJMNDCHJPNK.angularVelocity = Vector3.ClampMagnitude(vector, this.AJMNDCHJPNK.maxAngularVelocity);
				}
				this.AJMNDCHJPNK.WakeUp();
			}

			// Token: 0x060103E4 RID: 66532 RVA: 0x00747A94 File Offset: 0x00745C94
			public void IAAEFDOHPJK()
			{
				this.JJGHJJONFIA = this.JAHNHOCNJGM.position - this.IABMNPENOFE;
				this.IABMNPENOFE = this.JAHNHOCNJGM.position;
				this.MDAFOPGGGEM = JEEPKFCFCLI.AADCPGNPHHC(this.MHNMPOMNDBH, this.JAHNHOCNJGM.rotation);
				this.MHNMPOMNDBH = this.JAHNHOCNJGM.rotation;
				this.ENLHBNBNPJN = Time.deltaTime;
			}

			// Token: 0x0400221A RID: 8730
			public Rigidbody AJMNDCHJPNK;

			// Token: 0x0400221B RID: 8731
			public Transform JAHNHOCNJGM;

			// Token: 0x0400221C RID: 8732
			public Collider JNBDKOKIPEC;

			// Token: 0x0400221D RID: 8733
			public Joint OMKANNGJEEC;

			// Token: 0x0400221E RID: 8734
			public Rigidbody OAGAHEAMIAB;

			// Token: 0x0400221F RID: 8735
			public bool LGMHDFEODHC;

			// Token: 0x04002220 RID: 8736
			public Vector3 JJGHJJONFIA;

			// Token: 0x04002221 RID: 8737
			public Quaternion MDAFOPGGGEM;

			// Token: 0x04002222 RID: 8738
			public float ENLHBNBNPJN;

			// Token: 0x04002223 RID: 8739
			public Vector3 IABMNPENOFE;

			// Token: 0x04002224 RID: 8740
			public Quaternion MHNMPOMNDBH;
		}

		// Token: 0x020004A5 RID: 1189
		public class HBIOEBEOFCG
		{
			// Token: 0x060103E5 RID: 66533 RVA: 0x00747B08 File Offset: 0x00745D08
			public void JONLHAMDDEA(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1224f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 20f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103E6 RID: 66534 RVA: 0x00747B90 File Offset: 0x00745D90
			public void AAGKCPIONNE(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1141f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1160f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103E7 RID: 66535 RVA: 0x00747C18 File Offset: 0x00745E18
			public void DMJEDCOKONI(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 511f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 302f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103E8 RID: 66536 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void LBENFNNGIIM()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103E9 RID: 66537 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void DBFKNNLCABO()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103EA RID: 66538 RVA: 0x00747CC4 File Offset: 0x00745EC4
			public void IKFPMPFKFPE(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 836f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1913f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103EB RID: 66539 RVA: 0x00747D4C File Offset: 0x00745F4C
			public void CABOMOMHPKB(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1080f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1743f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103EC RID: 66540 RVA: 0x00747DD4 File Offset: 0x00745FD4
			public void INFMCCANBHL(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1563f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 870f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103ED RID: 66541 RVA: 0x00747E5C File Offset: 0x0074605C
			public void BGINDHAFNPI(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 971f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 93f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103EE RID: 66542 RVA: 0x00747EE4 File Offset: 0x007460E4
			public void CDONAFHONLH(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 958f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 349f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103EF RID: 66543 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void FJKOEGKNIGJ()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F0 RID: 66544 RVA: 0x00747F6C File Offset: 0x0074616C
			public void DBKAMBBELHN(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 867f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1760f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103F1 RID: 66545 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MLAGAOKKNKF()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F2 RID: 66546 RVA: 0x00747FF4 File Offset: 0x007461F4
			public void PDCFJBELAMG(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 309f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1859f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103F3 RID: 66547 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void OHKJBOOCODE()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F4 RID: 66548 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MOMEEBICFNI()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F5 RID: 66549 RVA: 0x0074807C File Offset: 0x0074627C
			public void PALDEJEOICC(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1286f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1495f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103F6 RID: 66550 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void NBEOLBNBIBN()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F7 RID: 66551 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void GBOBPCOFDAL()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103F8 RID: 66552 RVA: 0x00748104 File Offset: 0x00746304
			public void HPJJMBCCFBA(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 946f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1767f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103F9 RID: 66553 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void ELEKAPLDBEH()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103FA RID: 66554 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MPHEJADPGHL()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103FB RID: 66555 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void FEHANPFDJJE()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103FC RID: 66556 RVA: 0x0074818C File Offset: 0x0074638C
			public void MDFMCLLEKAB(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1437f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1396f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103FD RID: 66557 RVA: 0x00748214 File Offset: 0x00746414
			public void IFFBBOIAKNB(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1423f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1637f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x060103FE RID: 66558 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MOOLJINIKPA()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x060103FF RID: 66559 RVA: 0x0074829C File Offset: 0x0074649C
			public void MKDGKDPKLBL(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010400 RID: 66560 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void JIKBECJFNPL()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010401 RID: 66561 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void POIJKENCAFK()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010402 RID: 66562 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void DFPOAEKPGBH()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010403 RID: 66563 RVA: 0x00748324 File Offset: 0x00746524
			public void EHLDNOMBLOB(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 840f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1693f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010404 RID: 66564 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void PBOKBCGJACD()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010405 RID: 66565 RVA: 0x007483AC File Offset: 0x007465AC
			public void CPDNHIENKEE(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 342f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 851f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010406 RID: 66566 RVA: 0x00748434 File Offset: 0x00746634
			public void BOJNNBCBJLO(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 232f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 816f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010407 RID: 66567 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void HBKFHFBMDGJ()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010408 RID: 66568 RVA: 0x007484BC File Offset: 0x007466BC
			public void BEHIKEFHKGK(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1100f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1921f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010409 RID: 66569 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void BMCCONKILPL()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601040A RID: 66570 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void BFKMFFFIPAB()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601040B RID: 66571 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void GEOIHACKHLK()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601040C RID: 66572 RVA: 0x00748544 File Offset: 0x00746744
			public void NODJLNDILKL(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 105f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 612f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601040D RID: 66573 RVA: 0x007485CC File Offset: 0x007467CC
			public void IMHHNDNKDKD(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1043f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1189f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601040E RID: 66574 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void OAGGGJCEBNF()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601040F RID: 66575 RVA: 0x00748654 File Offset: 0x00746854
			public void IEOMCCCKMCB(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1765f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 489f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010410 RID: 66576 RVA: 0x007486DC File Offset: 0x007468DC
			public void DFJJDNEFDBG(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1861f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1068f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010411 RID: 66577 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MFCACEGNIOA()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010412 RID: 66578 RVA: 0x00748764 File Offset: 0x00746964
			public void MJLPBJDMPMD(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 514f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 727f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010413 RID: 66579 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void DNLNIEDBLAC()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010414 RID: 66580 RVA: 0x007487EC File Offset: 0x007469EC
			public void KNCNJDHECCM(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1848f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1805f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010415 RID: 66581 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void DOFEFNGBKKC()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010416 RID: 66582 RVA: 0x00748874 File Offset: 0x00746A74
			public void JGCEDNAIOBH(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1001f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 267f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010417 RID: 66583 RVA: 0x007488F9 File Offset: 0x00746AF9
			public HBIOEBEOFCG(Transform LPBDALAMAEM)
			{
				this.JAHNHOCNJGM = LPBDALAMAEM;
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010418 RID: 66584 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void NBKOCJHAGOL()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010419 RID: 66585 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void FHGCFCBDEKH()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601041A RID: 66586 RVA: 0x0074892C File Offset: 0x00746B2C
			public void IDLIGCEKIFO(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1148f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1977f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601041B RID: 66587 RVA: 0x007489B4 File Offset: 0x00746BB4
			public void EMOOCPPFEKP(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 915f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 906f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601041C RID: 66588 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void BKKILFJOMHM()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601041D RID: 66589 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void MFNPKNEMFAM()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601041E RID: 66590 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void BIHMBMGJEAI()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601041F RID: 66591 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void HABLOGGCFKN()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010420 RID: 66592 RVA: 0x00748A3C File Offset: 0x00746C3C
			public void EIHEJIHDNKP(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1055f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1712f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010421 RID: 66593 RVA: 0x00748AC4 File Offset: 0x00746CC4
			public void ONIFFEAAHDA(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 171f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1787f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010422 RID: 66594 RVA: 0x00748B4C File Offset: 0x00746D4C
			public void KPKKGGBLGKD(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 603f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 551f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010423 RID: 66595 RVA: 0x00748BD4 File Offset: 0x00746DD4
			public void OHOKMMJNFLD(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 588f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1629f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010424 RID: 66596 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void KFLAIKMIDCE()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010425 RID: 66597 RVA: 0x00748C5C File Offset: 0x00746E5C
			public void EOCEBPHCEKI(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 337f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 353f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010426 RID: 66598 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void HDEJCECKNPJ()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x06010427 RID: 66599 RVA: 0x00748CE4 File Offset: 0x00746EE4
			public void MGMFMAKHHBP(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 986f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1398f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010428 RID: 66600 RVA: 0x00748D6C File Offset: 0x00746F6C
			public void LLJNCEIMNGP(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 630f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 857f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x06010429 RID: 66601 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void DNDDPBFHFPK()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601042A RID: 66602 RVA: 0x00748DF4 File Offset: 0x00746FF4
			public void ODBDIBIEFIE(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 216f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 1064f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601042B RID: 66603 RVA: 0x00747C9D File Offset: 0x00745E9D
			public void OLBNKFCNAPG()
			{
				this.BACHFGBDKMM = this.JAHNHOCNJGM.localPosition;
				this.JJCLNGDAJLC = this.JAHNHOCNJGM.localRotation;
			}

			// Token: 0x0601042C RID: 66604 RVA: 0x00748E7C File Offset: 0x0074707C
			public void MIGPPIGIDIK(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1222f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 161f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x0601042D RID: 66605 RVA: 0x00748F04 File Offset: 0x00747104
			public void OMFEPANOMDC(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1238f)
				{
					return;
				}
				if (NKHBAJKMAGD >= 182f)
				{
					this.JAHNHOCNJGM.localPosition = this.BACHFGBDKMM;
					this.JAHNHOCNJGM.localRotation = this.JJCLNGDAJLC;
					return;
				}
				this.JAHNHOCNJGM.localPosition = Vector3.Lerp(this.JAHNHOCNJGM.localPosition, this.BACHFGBDKMM, NKHBAJKMAGD);
				this.JAHNHOCNJGM.localRotation = Quaternion.Lerp(this.JAHNHOCNJGM.localRotation, this.JJCLNGDAJLC, NKHBAJKMAGD);
			}

			// Token: 0x04002225 RID: 8741
			public Transform JAHNHOCNJGM;

			// Token: 0x04002226 RID: 8742
			public Vector3 BACHFGBDKMM;

			// Token: 0x04002227 RID: 8743
			public Quaternion JJCLNGDAJLC;
		}
	}
}
