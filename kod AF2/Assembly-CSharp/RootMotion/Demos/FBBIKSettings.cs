using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F3 RID: 1011
	public class FBBIKSettings : MonoBehaviour
	{
		// Token: 0x0600D976 RID: 55670 RVA: 0x0063ADA5 File Offset: 0x00638FA5
		private void DPGECEOMHNM()
		{
			this.CPCAGHBPDGJ();
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x0063ADAD File Offset: 0x00638FAD
		private void OHKHOAKCENL()
		{
			this.KGEIPBLAMAD();
		}

		// Token: 0x0600D978 RID: 55672 RVA: 0x0063ADB5 File Offset: 0x00638FB5
		private void PNBGJBMJLFM()
		{
			this.AHPBEENNCEK();
		}

		// Token: 0x0600D979 RID: 55673 RVA: 0x0063ADBD File Offset: 0x00638FBD
		private void LACNPNKHCAA()
		{
			this.CIFMJFAGGJO();
		}

		// Token: 0x0600D97A RID: 55674 RVA: 0x0063ADC8 File Offset: 0x00638FC8
		public void CIFMJFAGGJO()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.IIDLIPDCNJJ(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.OKCMHLJOFFC(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.IOLCGFHGABE(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightLeg.BFDBMDPBJML((FullBodyBipedChain)6, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D97B RID: 55675 RVA: 0x0063AE78 File Offset: 0x00639078
		private void KKCFKEDABLB()
		{
			Debug.Log("_TrEndWin.ogg");
			this.OMKCHIJGGHN();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x0063AE9C File Offset: 0x0063909C
		public void KHELHCGKGMJ()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.BDDGBCBODAI(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.BJANDLJOHKI(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.MCLLJAHGJLP((FullBodyBipedChain)5, this.ik.solver);
			this.rightLeg.LDKOGEDIEEA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.NEKNDGMNDHG().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x0063AF4C File Offset: 0x0063914C
		public void ONKPNJEFLEN()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.BKHIGJJNHAE(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.MFIAPGKJDJA(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.IMLMAAAEEGF((FullBodyBipedChain)6, this.ik.solver);
			this.rightLeg.DDLKHEECNKP((FullBodyBipedChain)8, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D97F RID: 55679 RVA: 0x0063B00B File Offset: 0x0063920B
		private void AFFAJKPPMHF()
		{
			Debug.Log("SneakRight");
			this.LJFOLBAPDJK();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D980 RID: 55680 RVA: 0x0063B02C File Offset: 0x0063922C
		private void AOCDDBNBADJ()
		{
			Debug.Log("crft_from");
			this.BDNEPBGHENO();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D981 RID: 55681 RVA: 0x0063B04D File Offset: 0x0063924D
		private void MCHAAIIHOKD()
		{
			Debug.Log("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
			this.CPCAGHBPDGJ();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x0063B06E File Offset: 0x0063926E
		private void KFGKKLAKFGH()
		{
			Debug.Log("Katana Ninja Draw");
			this.PPJFEBCKKOJ();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x0063B090 File Offset: 0x00639290
		public void BDNEPBGHENO()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.MFIAPGKJDJA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.CAPLBHGKKHA(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.BFDBMDPBJML(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightLeg.FGHFOIDAACI((FullBodyBipedChain)5, this.ik.solver);
			this.ik.solver.chain[1].pin = this.rootPin;
			this.ik.solver.NEKNDGMNDHG().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D984 RID: 55684 RVA: 0x0063B140 File Offset: 0x00639340
		private void IKHCCAANGOP()
		{
			this.AMANNAHPHBM();
		}

		// Token: 0x0600D985 RID: 55685 RVA: 0x0063B148 File Offset: 0x00639348
		public void KDPNAEMEGKN()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.JBNOIPHEGDP(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.JBNOIPHEGDP(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.DAIGOMFBNOD((FullBodyBipedChain)6, this.ik.solver);
			this.rightLeg.BHFEEDKLLHN((FullBodyBipedChain)4, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x0063B1F8 File Offset: 0x006393F8
		private void EDGALMCHPPH()
		{
			Debug.Log("fshop_btn1");
			this.KGEIPBLAMAD();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x0063B219 File Offset: 0x00639419
		private void CBLGFOFHNPJ()
		{
			Debug.Log("money");
			this.UpdateSettings();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x0063B23A File Offset: 0x0063943A
		private void DEGCCLNOEKJ()
		{
			this.BDNEPBGHENO();
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x0063B244 File Offset: 0x00639444
		public void BBEKECJHOMI()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.BJANDLJOHKI(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.JAKKDJFKMDO(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.BKHIGJJNHAE(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightLeg.BFDBMDPBJML(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.ik.solver.chain[1].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x0063B2F4 File Offset: 0x006394F4
		private void Start()
		{
			Debug.Log("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.");
			this.UpdateSettings();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D98B RID: 55691 RVA: 0x0063B315 File Offset: 0x00639515
		private void EHDPACPIBNF()
		{
			Debug.Log("ObscuredInt vs int, ");
			this.MAELGPFFDCG();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x0063B336 File Offset: 0x00639536
		private void JLKBMEBFHBI()
		{
			Debug.Log("---------- DebugReturn ");
			this.LJFOLBAPDJK();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D98D RID: 55693 RVA: 0x0063B357 File Offset: 0x00639557
		private void OFGMIEJKMGC()
		{
			Debug.Log("_Vignette_Opacity");
			this.CCMFNCNIAJI();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D98E RID: 55694 RVA: 0x0063B378 File Offset: 0x00639578
		private void CAJLCEPLKJG()
		{
			Debug.Log("wpn_add/addoptions");
			this.ONKPNJEFLEN();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D98F RID: 55695 RVA: 0x0063B39C File Offset: 0x0063959C
		public void CPCAGHBPDGJ()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.BKPANOKBAMC(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.DDLKHEECNKP(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.OKCMHLJOFFC(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightLeg.FFGPELHNHOF(FullBodyBipedChain.RightArm, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x0063B44C File Offset: 0x0063964C
		private void JIFOELPAEHG()
		{
			this.KDPNAEMEGKN();
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x0063B454 File Offset: 0x00639654
		private void ELFLOPJDAKK()
		{
			Debug.Log("wpn_add/base");
			this.KDPNAEMEGKN();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x0063B475 File Offset: 0x00639675
		private void EMFOECIPBIP()
		{
			this.BBEKECJHOMI();
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x0063B480 File Offset: 0x00639680
		public void AHPBEENNCEK()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.HCNGBMPDFBM(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.FNPOICECOOI(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.BHFEEDKLLHN((FullBodyBipedChain)8, this.ik.solver);
			this.rightLeg.BHFEEDKLLHN((FullBodyBipedChain)5, this.ik.solver);
			this.ik.solver.chain[1].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D994 RID: 55700 RVA: 0x0063B530 File Offset: 0x00639730
		private void KEMGOLACEHI()
		{
			Debug.Log("TOD_SpaceTiling");
			this.UpdateSettings();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x0063B551 File Offset: 0x00639751
		private void HAIMGCDKPDC()
		{
			this.KHELHCGKGMJ();
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x0063B140 File Offset: 0x00639340
		private void GCNGEFBKMNC()
		{
			this.AMANNAHPHBM();
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x0063ADA5 File Offset: 0x00638FA5
		private void BJOICAKCPLI()
		{
			this.CPCAGHBPDGJ();
		}

		// Token: 0x0600D998 RID: 55704 RVA: 0x0063B559 File Offset: 0x00639759
		private void PNAAHEFHPCL()
		{
			Debug.Log("foot");
			this.MAELGPFFDCG();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D999 RID: 55705 RVA: 0x0063B57A File Offset: 0x0063977A
		private void Update()
		{
			this.UpdateSettings();
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x0063B582 File Offset: 0x00639782
		private void MFHGOLNLAAF()
		{
			this.LJFOLBAPDJK();
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x0063B58C File Offset: 0x0063978C
		public void LJFOLBAPDJK()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.MKNEBAOBLNI(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.NCJDJBMJPDL(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.NCJDJBMJPDL(FullBodyBipedChain.LeftLeg, this.ik.solver);
			this.rightLeg.DAIGOMFBNOD((FullBodyBipedChain)7, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D99C RID: 55708 RVA: 0x0063B63C File Offset: 0x0063983C
		public void PPJFEBCKKOJ()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.CLJPMKONBKL(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.NCJDJBMJPDL(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.FNPOICECOOI((FullBodyBipedChain)8, this.ik.solver);
			this.rightLeg.DAIGOMFBNOD((FullBodyBipedChain)6, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D99D RID: 55709 RVA: 0x0063B6EC File Offset: 0x006398EC
		public void CCMFNCNIAJI()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.BOIHIFCKEKB(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.BGFHABPGLFL(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.BDDGBCBODAI((FullBodyBipedChain)7, this.ik.solver);
			this.rightLeg.NHLICKJMGAA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.ik.solver.chain[1].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D99E RID: 55710 RVA: 0x0063B79C File Offset: 0x0063999C
		public void AMANNAHPHBM()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.AKCCCGDAJGI(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.GMNNHFOIBKI(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.LBCOFBOKHJP(FullBodyBipedChain.RightLeg, this.ik.solver);
			this.rightLeg.NCJDJBMJPDL((FullBodyBipedChain)6, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x0063ADAD File Offset: 0x00638FAD
		private void CJHBCHBOLBI()
		{
			this.KGEIPBLAMAD();
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x0063B84C File Offset: 0x00639A4C
		public void KGEIPBLAMAD()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.HCNGBMPDFBM(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.BHFEEDKLLHN(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.IOLCGFHGABE(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightLeg.BOIHIFCKEKB((FullBodyBipedChain)5, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x0063B8FC File Offset: 0x00639AFC
		private void IIKDDILLGLF()
		{
			Debug.Log("Crate Push");
			this.KDPNAEMEGKN();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x0063B920 File Offset: 0x00639B20
		public void UpdateSettings()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.DCLNJPIBFIA(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.DCLNJPIBFIA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.DCLNJPIBFIA(FullBodyBipedChain.LeftLeg, this.ik.solver);
			this.rightLeg.DCLNJPIBFIA(FullBodyBipedChain.RightLeg, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x0063B9D0 File Offset: 0x00639BD0
		private void LPNDCJKAKEA()
		{
			Debug.Log("uierror6.wav");
			this.BDNEPBGHENO();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D9A4 RID: 55716 RVA: 0x0063B9F1 File Offset: 0x00639BF1
		private void BMNJGPIPKLL()
		{
			Debug.Log("BowIdle");
			this.MAELGPFFDCG();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D9A5 RID: 55717 RVA: 0x0063BA12 File Offset: 0x00639C12
		private void PFNPOHMMJDN()
		{
			Debug.Log("Apply 2");
			this.BDNEPBGHENO();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600D9A6 RID: 55718 RVA: 0x0063BA33 File Offset: 0x00639C33
		private void KMLNBHIIGKH()
		{
			this.ONKPNJEFLEN();
		}

		// Token: 0x0600D9A7 RID: 55719 RVA: 0x0063BA3C File Offset: 0x00639C3C
		public void OMKCHIJGGHN()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.DCLNJPIBFIA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.PMMPDNLEPKA(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.GPAMMKENIAH((FullBodyBipedChain)4, this.ik.solver);
			this.rightLeg.KAPBIGHEDPB(FullBodyBipedChain.LeftLeg, this.ik.solver);
			this.ik.solver.chain[1].pin = this.rootPin;
			this.ik.solver.HJPCHINGJCN().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600D9A8 RID: 55720 RVA: 0x0063BAEC File Offset: 0x00639CEC
		private void MODJFGGIAHD()
		{
			Debug.Log(">> 2 >>");
			this.KGEIPBLAMAD();
			if (this.disableAfterStart)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x0063BB10 File Offset: 0x00639D10
		public void MAELGPFFDCG()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.JBNOIPHEGDP(FullBodyBipedChain.RightArm, this.ik.solver);
			this.rightArm.EFODADOEBIH(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.leftLeg.DDNHHNABEGI((FullBodyBipedChain)5, this.ik.solver);
			this.rightLeg.CAPLBHGKKHA((FullBodyBipedChain)6, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.NEKNDGMNDHG().effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x04001CD7 RID: 7383
		public FullBodyBipedIK ik;

		// Token: 0x04001CD8 RID: 7384
		public bool disableAfterStart;

		// Token: 0x04001CD9 RID: 7385
		public FBBIKSettings.Limb leftArm;

		// Token: 0x04001CDA RID: 7386
		public FBBIKSettings.Limb rightArm;

		// Token: 0x04001CDB RID: 7387
		public FBBIKSettings.Limb leftLeg;

		// Token: 0x04001CDC RID: 7388
		public FBBIKSettings.Limb rightLeg;

		// Token: 0x04001CDD RID: 7389
		public float rootPin;

		// Token: 0x04001CDE RID: 7390
		public bool bodyEffectChildNodes = true;

		// Token: 0x020003F4 RID: 1012
		[Serializable]
		public class Limb
		{
			// Token: 0x0600D9AA RID: 55722 RVA: 0x0063BBC0 File Offset: 0x00639DC0
			public void GMNNHFOIBKI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9AB RID: 55723 RVA: 0x0063BBF8 File Offset: 0x00639DF8
			public void CGCCHDHADNC(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9AC RID: 55724 RVA: 0x0063BC30 File Offset: 0x00639E30
			public void AOKIOMBDNMP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9AD RID: 55725 RVA: 0x0063BC68 File Offset: 0x00639E68
			public void MKNEBAOBLNI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9AE RID: 55726 RVA: 0x0063BCA0 File Offset: 0x00639EA0
			public void KOFAHMHMOCG(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9AF RID: 55727 RVA: 0x0063BCD8 File Offset: 0x00639ED8
			public void LBCOFBOKHJP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B0 RID: 55728 RVA: 0x0063BD10 File Offset: 0x00639F10
			public void OKCMHLJOFFC(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B1 RID: 55729 RVA: 0x0063BD48 File Offset: 0x00639F48
			public void BKHIGJJNHAE(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B2 RID: 55730 RVA: 0x0063BD80 File Offset: 0x00639F80
			public void EFODADOEBIH(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B3 RID: 55731 RVA: 0x0063BDB8 File Offset: 0x00639FB8
			public void IMLMAAAEEGF(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B4 RID: 55732 RVA: 0x0063BDF0 File Offset: 0x00639FF0
			public void NCJDJBMJPDL(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B5 RID: 55733 RVA: 0x0063BE28 File Offset: 0x0063A028
			public void BJANDLJOHKI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B6 RID: 55734 RVA: 0x0063BE60 File Offset: 0x0063A060
			public void PMMPDNLEPKA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B7 RID: 55735 RVA: 0x0063BE98 File Offset: 0x0063A098
			public void OBDOALFIIFJ(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B8 RID: 55736 RVA: 0x0063BED0 File Offset: 0x0063A0D0
			public void KAPBIGHEDPB(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9B9 RID: 55737 RVA: 0x0063BD80 File Offset: 0x00639F80
			public void NHLICKJMGAA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9BA RID: 55738 RVA: 0x0063BCA0 File Offset: 0x00639EA0
			public void BFDBMDPBJML(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9BB RID: 55739 RVA: 0x0063BF08 File Offset: 0x0063A108
			public void IIDLIPDCNJJ(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9BC RID: 55740 RVA: 0x0063BF40 File Offset: 0x0063A140
			public void GPAMMKENIAH(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9BD RID: 55741 RVA: 0x0063BE60 File Offset: 0x0063A060
			public void CBANMDBFGDI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9BE RID: 55742 RVA: 0x0063BF78 File Offset: 0x0063A178
			public void PMKCLBCPIDA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C0 RID: 55744 RVA: 0x0063BFC3 File Offset: 0x0063A1C3
			public void DDNHHNABEGI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C1 RID: 55745 RVA: 0x0063BDB8 File Offset: 0x00639FB8
			public void NFEKPOPPICL(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x0063BFFB File Offset: 0x0063A1FB
			public void BOIHIFCKEKB(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x0063BD10 File Offset: 0x00639F10
			public void BHFEEDKLLHN(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C4 RID: 55748 RVA: 0x0063C033 File Offset: 0x0063A233
			public void CLJPMKONBKL(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x0063BFC3 File Offset: 0x0063A1C3
			public void MADHHPOGJLP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C6 RID: 55750 RVA: 0x0063C06B File Offset: 0x0063A26B
			public void IBIBHHPEFEJ(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x0063C0A3 File Offset: 0x0063A2A3
			public void BGFHABPGLFL(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C8 RID: 55752 RVA: 0x0063C0DB File Offset: 0x0063A2DB
			public void JBNOIPHEGDP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.JKMHBGKCKOC(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9C9 RID: 55753 RVA: 0x0063BBF8 File Offset: 0x00639DF8
			public void HCNGBMPDFBM(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CA RID: 55754 RVA: 0x0063C06B File Offset: 0x0063A26B
			public void OOCJDDBPLDJ(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CB RID: 55755 RVA: 0x0063C113 File Offset: 0x0063A313
			public void GBNILLPMJAA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CC RID: 55756 RVA: 0x0063C14B File Offset: 0x0063A34B
			public void CEDJFNODCHA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CD RID: 55757 RVA: 0x0063BDF0 File Offset: 0x00639FF0
			public void ODLPIDHFPEO(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CE RID: 55758 RVA: 0x0063BF40 File Offset: 0x0063A140
			public void AKCCCGDAJGI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9CF RID: 55759 RVA: 0x0063C183 File Offset: 0x0063A383
			public void OPOECNMLAJM(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D0 RID: 55760 RVA: 0x0063BBF8 File Offset: 0x00639DF8
			public void FGHFOIDAACI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LDMNNHCNOMJ(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D1 RID: 55761 RVA: 0x0063BD48 File Offset: 0x00639F48
			public void MCLLJAHGJLP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D2 RID: 55762 RVA: 0x0063C1BB File Offset: 0x0063A3BB
			public void BDDGBCBODAI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D3 RID: 55763 RVA: 0x0063C1F3 File Offset: 0x0063A3F3
			public void FFGPELHNHOF(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.IBMLIDHKIFK(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D4 RID: 55764 RVA: 0x0063C22B File Offset: 0x0063A42B
			public void FNPOICECOOI(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D5 RID: 55765 RVA: 0x0063C183 File Offset: 0x0063A383
			public void MFIAPGKJDJA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.EENBNOCPJJA(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D6 RID: 55766 RVA: 0x0063C263 File Offset: 0x0063A463
			public void DDLKHEECNKP(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D7 RID: 55767 RVA: 0x0063BE60 File Offset: 0x0063A060
			public void LDKOGEDIEEA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D8 RID: 55768 RVA: 0x0063C29B File Offset: 0x0063A49B
			public void DCLNJPIBFIA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.LGOKBJOBPAO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9D9 RID: 55769 RVA: 0x0063C2D3 File Offset: 0x0063A4D3
			public void IOLCGFHGABE(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.KMCNEPELKKP(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9DA RID: 55770 RVA: 0x0063C30B File Offset: 0x0063A50B
			public void JAKKDJFKMDO(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9DB RID: 55771 RVA: 0x0063BCD8 File Offset: 0x00639ED8
			public void ALJDBHIMDNE(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.AHDIMGDLPCI(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9DC RID: 55772 RVA: 0x0063C343 File Offset: 0x0063A543
			public void DAIGOMFBNOD(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.PBGGJENJFED(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9DD RID: 55773 RVA: 0x0063C37B File Offset: 0x0063A57B
			public void CAPLBHGKKHA(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.IALCIJJGDHO(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.PPEHBCMLFIH(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x0600D9DE RID: 55774 RVA: 0x0063C3B3 File Offset: 0x0063A5B3
			public void BKPANOKBAMC(FullBodyBipedChain NBHJKKHHFEH, IKSolverFullBodyBiped NBAKCIDALOF)
			{
				NBAKCIDALOF.CFLHKIGAPOB(NBHJKKHHFEH).reachSmoothing = this.reachSmoothing;
				NBAKCIDALOF.POAMMGIPHAK(NBHJKKHHFEH).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				NBAKCIDALOF.CDGFDPHBEKO(NBHJKKHHFEH).weight = this.mappingWeight;
			}

			// Token: 0x04001CDF RID: 7391
			public FBIKChain.Smoothing reachSmoothing;

			// Token: 0x04001CE0 RID: 7392
			public float maintainRelativePositionWeight;

			// Token: 0x04001CE1 RID: 7393
			public float mappingWeight = 1f;
		}
	}
}
