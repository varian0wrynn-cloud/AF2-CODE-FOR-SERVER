using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000459 RID: 1113
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		// Token: 0x0600F0DA RID: 61658 RVA: 0x006B99F3 File Offset: 0x006B7BF3
		public virtual IKSolver LGLKFLLEGAB()
		{
			return this.solver;
		}

		// Token: 0x0600F0DB RID: 61659 RVA: 0x006B99FB File Offset: 0x006B7BFB
		protected virtual void JJNENPJGBIE()
		{
			if (this.references.JEKCDODCEJL())
			{
				this.JJLILGCPFGH();
			}
			if (this.references.PLKDOKCBPHL())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0DC RID: 61660 RVA: 0x006B99F3 File Offset: 0x006B7BF3
		public virtual IKSolver DCHKBMBBIPE()
		{
			return this.solver;
		}

		// Token: 0x0600F0DD RID: 61661 RVA: 0x006B9A34 File Offset: 0x006B7C34
		protected virtual void JICPJEEKFHC()
		{
			if (this.references.APOPFNIOGNA())
			{
				this.FPFCLIOJEIM();
			}
			if (this.references.AJPPBCMOJEI())
			{
				this.solver.NBOFHKJNIIJ(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0DE RID: 61662 RVA: 0x006B9A6D File Offset: 0x006B7C6D
		protected virtual void FIGHJNAJGNF()
		{
			if (this.references.APOPFNIOGNA())
			{
				this.PCLPIMIHLFK();
			}
			if (this.references.BAKOHIHHOAJ())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0DF RID: 61663 RVA: 0x006B9AA6 File Offset: 0x006B7CA6
		protected virtual void IBJKGOIOHAA()
		{
			if (this.references.BDJIMMPNOED())
			{
				this.PCLPIMIHLFK();
			}
			if (this.references.KEPDNHHCGGD())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0E0 RID: 61664 RVA: 0x006B9ADF File Offset: 0x006B7CDF
		protected virtual void LGEJDPPCEFN()
		{
			Debug.Log("ArmFlex5");
		}

		// Token: 0x0600F0E1 RID: 61665 RVA: 0x006B9AEB File Offset: 0x006B7CEB
		public void IKHABNDHDDB()
		{
			VRIK.References.OOKFDAMIDIO(base.transform, out this.references);
		}

		// Token: 0x0600F0E2 RID: 61666 RVA: 0x006B9AFF File Offset: 0x006B7CFF
		public void PCDMIKONLEG()
		{
			this.solver.BKFEOFDAHPH(this.references, false);
		}

		// Token: 0x0600F0E3 RID: 61667 RVA: 0x006B9B13 File Offset: 0x006B7D13
		protected virtual void ACEAEJPOAMH()
		{
			if (this.references.DBHNPPOPONA())
			{
				this.AutoDetectReferences();
			}
			if (this.references.NCLDBEBKPDG())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0E4 RID: 61668 RVA: 0x006B9B4C File Offset: 0x006B7D4C
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
			this.solver.NAAPDNHGGDI(this.references, false);
		}

		// Token: 0x0600F0E5 RID: 61669 RVA: 0x006B9B60 File Offset: 0x006B7D60
		protected override void AFEMLFIOJIA()
		{
			Debug.Log("Sorry, VRIK Script reference is not finished yet.");
		}

		// Token: 0x0600F0E6 RID: 61670 RVA: 0x006B9B6C File Offset: 0x006B7D6C
		protected virtual void ICFACKFHDOP()
		{
			Debug.Log("SneakLeft");
		}

		// Token: 0x0600F0E7 RID: 61671 RVA: 0x006B9B78 File Offset: 0x006B7D78
		public void FOFOMLFGBKG()
		{
			this.solver.IAIHPAEACIJ(this.references, true);
		}

		// Token: 0x0600F0E8 RID: 61672 RVA: 0x006B9B8C File Offset: 0x006B7D8C
		protected virtual void FPOMIKGHJOC()
		{
			if (this.references.OABDKIJMADI())
			{
				this.ENNNNGIFBJN();
			}
			if (this.references.AJPPBCMOJEI())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0E9 RID: 61673 RVA: 0x006B9B78 File Offset: 0x006B7D78
		public void ENLFMHJNBEB()
		{
			this.solver.IAIHPAEACIJ(this.references, true);
		}

		// Token: 0x0600F0EA RID: 61674 RVA: 0x006B9BC5 File Offset: 0x006B7DC5
		protected override void MPJFMFOPHKJ()
		{
			if (this.references.isEmpty)
			{
				this.AutoDetectReferences();
			}
			if (this.references.isFilled)
			{
				this.solver.NBOFHKJNIIJ(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0EB RID: 61675 RVA: 0x006B99F3 File Offset: 0x006B7BF3
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x0600F0EC RID: 61676 RVA: 0x006B9BFE File Offset: 0x006B7DFE
		public void ELKOJBMKGGI()
		{
			VRIK.References.HMGMNIFHDJG(base.transform, out this.references);
		}

		// Token: 0x0600F0ED RID: 61677 RVA: 0x006B9C12 File Offset: 0x006B7E12
		protected virtual void OCMBMDPMIOE()
		{
			Debug.Log("currentCount=");
		}

		// Token: 0x0600F0EE RID: 61678 RVA: 0x006B9C1E File Offset: 0x006B7E1E
		protected virtual void OLDHKONJLLL()
		{
			Debug.Log("wpn_chair3");
		}

		// Token: 0x0600F0EF RID: 61679 RVA: 0x006B9C2A File Offset: 0x006B7E2A
		public void JJLILGCPFGH()
		{
			VRIK.References.IKHABNDHDDB(base.transform, out this.references);
		}

		// Token: 0x0600F0F0 RID: 61680 RVA: 0x006B9C3E File Offset: 0x006B7E3E
		protected virtual void JHLIFLAILLC()
		{
			if (this.references.DBHNPPOPONA())
			{
				this.HNACLMNEGDD();
			}
			if (this.references.AEHEHNPOHPO())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0F1 RID: 61681 RVA: 0x006B9C77 File Offset: 0x006B7E77
		public void LPDFEHHKHIN()
		{
			VRIK.References.AHBLFGBEMDM(base.transform, out this.references);
		}

		// Token: 0x0600F0F2 RID: 61682 RVA: 0x006B9C8B File Offset: 0x006B7E8B
		public void JAFKLKKENCI()
		{
			this.solver.IAIHPAEACIJ(this.references, false);
		}

		// Token: 0x0600F0F3 RID: 61683 RVA: 0x006B9C9F File Offset: 0x006B7E9F
		protected override void NLLHEACBOPP()
		{
			Debug.Log("Sorry, VRIK User Manual is not finished yet.");
		}

		// Token: 0x0600F0F4 RID: 61684 RVA: 0x006B9CAB File Offset: 0x006B7EAB
		public void NMOJEAOIKBP()
		{
			this.solver.LFIPEPEDCMN(this.references, true);
		}

		// Token: 0x0600F0F5 RID: 61685 RVA: 0x006B9CBF File Offset: 0x006B7EBF
		public void CKJPKDEGNLB()
		{
			VRIK.References.NDPKLMNGNBO(base.transform, out this.references);
		}

		// Token: 0x0600F0F6 RID: 61686 RVA: 0x006B9CD3 File Offset: 0x006B7ED3
		protected virtual void GICLHHADCGK()
		{
			if (this.references.HMNBMFJKGGB())
			{
				this.LPDFEHHKHIN();
			}
			if (this.references.EHCEHFOMPPC())
			{
				this.solver.IFMMGEPGJJH(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F0F7 RID: 61687 RVA: 0x006B9D0C File Offset: 0x006B7F0C
		protected virtual void AOOPGMEHBHD()
		{
			Debug.Log("Reflection");
		}

		// Token: 0x0600F0F8 RID: 61688 RVA: 0x006B9D18 File Offset: 0x006B7F18
		public void HNACLMNEGDD()
		{
			VRIK.References.JHKFHGPJCHL(base.transform, out this.references);
		}

		// Token: 0x0600F0F9 RID: 61689 RVA: 0x006B9D2C File Offset: 0x006B7F2C
		protected virtual void GEMPMGEJLBN()
		{
			Debug.Log("Flap_08.wav");
		}

		// Token: 0x0600F0FA RID: 61690 RVA: 0x006B9D38 File Offset: 0x006B7F38
		protected virtual void LHMELJAFNCH()
		{
			Debug.Log("OnStatusChanged UNKNOW ");
		}

		// Token: 0x0600F0FB RID: 61691 RVA: 0x006B9D44 File Offset: 0x006B7F44
		protected virtual void LAOFAIEKFGE()
		{
			Debug.Log("SUNSHINE_OVERCAST_OFF");
		}

		// Token: 0x0600F0FC RID: 61692 RVA: 0x006B9D50 File Offset: 0x006B7F50
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
			VRIK.References.IBAJIPDAJND(base.transform, out this.references);
		}

		// Token: 0x0600F0FD RID: 61693 RVA: 0x006B99F3 File Offset: 0x006B7BF3
		public virtual IKSolver EKMKCFMCBID()
		{
			return this.solver;
		}

		// Token: 0x0600F0FE RID: 61694 RVA: 0x006B9D64 File Offset: 0x006B7F64
		protected virtual void MEBGJNEGBCC()
		{
			Debug.Log("wpn_eat3");
		}

		// Token: 0x0600F0FF RID: 61695 RVA: 0x006B9D70 File Offset: 0x006B7F70
		public void FPFCLIOJEIM()
		{
			VRIK.References.HNOFGFFCFKC(base.transform, out this.references);
		}

		// Token: 0x0600F100 RID: 61696 RVA: 0x006B9D84 File Offset: 0x006B7F84
		protected virtual void MPNOBOAIGLC()
		{
			Debug.Log("_RgbTex");
		}

		// Token: 0x0600F101 RID: 61697 RVA: 0x006B9CBF File Offset: 0x006B7EBF
		public void ENNNNGIFBJN()
		{
			VRIK.References.NDPKLMNGNBO(base.transform, out this.references);
		}

		// Token: 0x0600F102 RID: 61698 RVA: 0x006B9D90 File Offset: 0x006B7F90
		protected virtual void PBONADBLPJB()
		{
			if (this.references.HMNBMFJKGGB())
			{
				this.PCLPIMIHLFK();
			}
			if (this.references.AJPPBCMOJEI())
			{
				this.solver.IFMMGEPGJJH(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F103 RID: 61699 RVA: 0x006B9AEB File Offset: 0x006B7CEB
		public void PJDIKBCKFCG()
		{
			VRIK.References.OOKFDAMIDIO(base.transform, out this.references);
		}

		// Token: 0x0600F105 RID: 61701 RVA: 0x006B9DE7 File Offset: 0x006B7FE7
		protected virtual void EDIBMGGFMMJ()
		{
			Debug.Log("_ProjInfoLeft");
		}

		// Token: 0x0600F106 RID: 61702 RVA: 0x006B9DF3 File Offset: 0x006B7FF3
		protected virtual void FAEBOJGJKML()
		{
			if (this.references.OABDKIJMADI())
			{
				this.JJLILGCPFGH();
			}
			if (this.references.LCNJCJCDFML())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F107 RID: 61703 RVA: 0x006B9CBF File Offset: 0x006B7EBF
		public void PCLPIMIHLFK()
		{
			VRIK.References.NDPKLMNGNBO(base.transform, out this.references);
		}

		// Token: 0x0600F108 RID: 61704 RVA: 0x006B9E2C File Offset: 0x006B802C
		protected virtual void GIOEBGNGHOH()
		{
			if (this.references.LIGAHHHDMPC())
			{
				this.LPDFEHHKHIN();
			}
			if (this.references.LCNJCJCDFML())
			{
				this.solver.MIIPNFBLCHM(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F109 RID: 61705 RVA: 0x001B4551 File Offset: 0x001B2751
		protected virtual void GOBPKNJPLFB()
		{
			Debug.Log("");
		}

		// Token: 0x0600F10A RID: 61706 RVA: 0x006B9E65 File Offset: 0x006B8065
		protected virtual void AJMAMBMEAPA()
		{
			if (this.references.JEKCDODCEJL())
			{
				this.FPFCLIOJEIM();
			}
			if (this.references.PLKDOKCBPHL())
			{
				this.solver.NBOFHKJNIIJ(this.references);
			}
			base.MPJFMFOPHKJ();
		}

		// Token: 0x0600F10B RID: 61707 RVA: 0x006B9E9E File Offset: 0x006B809E
		protected virtual void AKOKGDLNCJA()
		{
			Debug.Log("rewgt_msg");
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x006B99F3 File Offset: 0x006B7BF3
		public virtual IKSolver AMBDLDNDPDC()
		{
			return this.solver;
		}

		// Token: 0x0600F10D RID: 61709 RVA: 0x006B9EAA File Offset: 0x006B80AA
		protected virtual void JOEMLKNNJAD()
		{
			Debug.Log("{0}");
		}

		// Token: 0x0600F10E RID: 61710 RVA: 0x006B9EB6 File Offset: 0x006B80B6
		public void LNFNFFJCFMH()
		{
			this.solver.KMCHGHOLCLM(this.references, true);
		}

		// Token: 0x04001F44 RID: 8004
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character.")]
		public VRIK.References references = new VRIK.References();

		// Token: 0x04001F45 RID: 8005
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver = new IKSolverVR();

		// Token: 0x0200045A RID: 1114
		[Serializable]
		public class References
		{
			// Token: 0x0600F110 RID: 61712 RVA: 0x006B9ECC File Offset: 0x006B80CC
			public static bool NJECCNGIBLD(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("componentA");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-76));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-61));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-84));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleDistal);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-110));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-102));
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)124);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-118));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftRingDistal);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)67);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)99);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)61);
				return true;
			}

			// Token: 0x0600F111 RID: 61713 RVA: 0x006BA040 File Offset: 0x006B8240
			public static bool IHNIECBNFDM(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("Wizard1HandThrow");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-2));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)102);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-120));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-80));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleIntermediate);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)114);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-65));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)87);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightIndexIntermediate);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-19));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)116);
				return false;
			}

			// Token: 0x0600F112 RID: 61714 RVA: 0x006BA1B4 File Offset: 0x006B83B4
			public static bool HMGMNIFHDJG(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("Fonts/");
					return true;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-116));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)57);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-65));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-74));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-1));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)104);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)89);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-7));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)100);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-51));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-66));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)126);
				return false;
			}

			// Token: 0x0600F113 RID: 61715 RVA: 0x006BA328 File Offset: 0x006B8528
			public bool CCOCNJNNPGE()
			{
				return (!(this.root != null) && !(this.pelvis != null) && !(this.spine != null) && !(this.chest != null) && !(this.neck != null) && !(this.head != null) && !(this.leftShoulder != null) && !(this.leftUpperArm != null) && !(this.leftForearm != null) && !(this.leftHand != null) && !(this.rightShoulder != null) && !(this.rightUpperArm != null) && !(this.rightForearm != null) && !(this.rightHand != null) && !(this.leftThigh != null) && !(this.leftCalf != null) && !(this.leftFoot != null) && !(this.leftToes != null) && !(this.rightThigh != null) && !(this.rightCalf != null) && !(this.rightFoot != null) && !(this.rightToes != null)) || true;
			}

			// Token: 0x0600F114 RID: 61716 RVA: 0x006BA490 File Offset: 0x006B8690
			public bool BAKOHIHHOAJ()
			{
				return (!(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null)) || true;
			}

			// Token: 0x0600F115 RID: 61717 RVA: 0x006BA5A4 File Offset: 0x006B87A4
			public static bool OPENJLPGCKK(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("' is not a valid integer");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform(HumanBodyBones.Head);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-77));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)122);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-68));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)57);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightIndexDistal);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)106);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-127));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)103);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-125));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-83));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-111));
				return false;
			}

			// Token: 0x0600F116 RID: 61718 RVA: 0x006BA718 File Offset: 0x006B8918
			public bool HMNBMFJKGGB()
			{
				return this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null;
			}

			// Token: 0x0600F117 RID: 61719 RVA: 0x006BA880 File Offset: 0x006B8A80
			public bool OABDKIJMADI()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x0600F118 RID: 61720 RVA: 0x006BA9E8 File Offset: 0x006B8BE8
			public Transform[] KFLBEDODDMM()
			{
				Transform[] array = new Transform[57];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[7] = this.spine;
				array[5] = this.chest;
				array[8] = this.neck;
				array[0] = this.head;
				array[4] = this.leftShoulder;
				array[7] = this.leftUpperArm;
				array[6] = this.leftForearm;
				array[81] = this.leftHand;
				array[-88] = this.rightShoulder;
				array[-56] = this.rightUpperArm;
				array[-39] = this.rightForearm;
				array[42] = this.rightHand;
				array[111] = this.leftThigh;
				array[58] = this.leftCalf;
				array[-8] = this.leftFoot;
				array[-38] = this.leftToes;
				array[-83] = this.rightThigh;
				array[111] = this.rightCalf;
				array[91] = this.rightFoot;
				array[-55] = this.rightToes;
				return array;
			}

			// Token: 0x0600F119 RID: 61721 RVA: 0x006BAAD0 File Offset: 0x006B8CD0
			public Transform[] BEMANMAFPOC()
			{
				Transform[] array = new Transform[39];
				array[0] = this.root;
				array[0] = this.pelvis;
				array[4] = this.spine;
				array[8] = this.chest;
				array[8] = this.neck;
				array[4] = this.head;
				array[6] = this.leftShoulder;
				array[4] = this.leftUpperArm;
				array[2] = this.leftForearm;
				array[108] = this.leftHand;
				array[-21] = this.rightShoulder;
				array[-118] = this.rightUpperArm;
				array[-33] = this.rightForearm;
				array[28] = this.rightHand;
				array[-51] = this.leftThigh;
				array[98] = this.leftCalf;
				array[-6] = this.leftFoot;
				array[22] = this.leftToes;
				array[-97] = this.rightThigh;
				array[-83] = this.rightCalf;
				array[101] = this.rightFoot;
				array[66] = this.rightToes;
				return array;
			}

			// Token: 0x0600F11A RID: 61722 RVA: 0x006BABB8 File Offset: 0x006B8DB8
			public Transform[] JAEPLGLCIOI()
			{
				Transform[] array = new Transform[35];
				array[1] = this.root;
				array[0] = this.pelvis;
				array[7] = this.spine;
				array[7] = this.chest;
				array[3] = this.neck;
				array[2] = this.head;
				array[2] = this.leftShoulder;
				array[8] = this.leftUpperArm;
				array[1] = this.leftForearm;
				array[125] = this.leftHand;
				array[41] = this.rightShoulder;
				array[64] = this.rightUpperArm;
				array[13] = this.rightForearm;
				array[-128] = this.rightHand;
				array[-101] = this.leftThigh;
				array[-28] = this.leftCalf;
				array[-3] = this.leftFoot;
				array[114] = this.leftToes;
				array[-10] = this.rightThigh;
				array[-111] = this.rightCalf;
				array[-10] = this.rightFoot;
				array[-66] = this.rightToes;
				return array;
			}

			// Token: 0x0600F11B RID: 61723 RVA: 0x006BACA0 File Offset: 0x006B8EA0
			public bool AJPPBCMOJEI()
			{
				return !(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null);
			}

			// Token: 0x0600F11C RID: 61724 RVA: 0x006BADB4 File Offset: 0x006B8FB4
			public bool KEPDNHHCGGD()
			{
				return (!(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null)) || true;
			}

			// Token: 0x0600F11D RID: 61725 RVA: 0x006BAEC8 File Offset: 0x006B90C8
			public bool APOPFNIOGNA()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x0600F11E RID: 61726 RVA: 0x006BB030 File Offset: 0x006B9230
			public bool PLKDOKCBPHL()
			{
				return this.root == null || this.pelvis == null || this.spine == null || this.chest == null || this.head == null || this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null || this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null || this.leftThigh == null || this.leftCalf == null || this.leftFoot == null || this.rightThigh == null || this.rightCalf == null || this.rightFoot == null;
			}

			// Token: 0x0600F11F RID: 61727 RVA: 0x006BB144 File Offset: 0x006B9344
			public static bool HNOFGFFCFKC(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("MotorbikeLookBack");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-72));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-23));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-55));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleDistal);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)96);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerArm);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)63);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)103);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.RightRingDistal);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)76);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)124);
				return true;
			}

			// Token: 0x0600F120 RID: 61728 RVA: 0x006BB2B8 File Offset: 0x006B94B8
			public bool EHCEHFOMPPC()
			{
				return this.root == null || this.pelvis == null || this.spine == null || this.chest == null || this.head == null || this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null || this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null || this.leftThigh == null || this.leftCalf == null || this.leftFoot == null || this.rightThigh == null || this.rightCalf == null || this.rightFoot == null;
			}

			// Token: 0x0600F121 RID: 61729 RVA: 0x006BB3CC File Offset: 0x006B95CC
			public bool JKCEFBODIIO()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x0600F122 RID: 61730 RVA: 0x006BB534 File Offset: 0x006B9734
			public bool isFilled
			{
				get
				{
					return !(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null);
				}
			}

			// Token: 0x0600F123 RID: 61731 RVA: 0x006BB648 File Offset: 0x006B9848
			public Transform[] PIFBJPOMJCK()
			{
				Transform[] array = new Transform[12];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[8] = this.spine;
				array[7] = this.chest;
				array[3] = this.neck;
				array[8] = this.head;
				array[5] = this.leftShoulder;
				array[2] = this.leftUpperArm;
				array[6] = this.leftForearm;
				array[32] = this.leftHand;
				array[-81] = this.rightShoulder;
				array[-43] = this.rightUpperArm;
				array[9] = this.rightForearm;
				array[-107] = this.rightHand;
				array[-10] = this.leftThigh;
				array[76] = this.leftCalf;
				array[-12] = this.leftFoot;
				array[-65] = this.leftToes;
				array[42] = this.rightThigh;
				array[2] = this.rightCalf;
				array[-52] = this.rightFoot;
				array[92] = this.rightToes;
				return array;
			}

			// Token: 0x0600F124 RID: 61732 RVA: 0x006BB730 File Offset: 0x006B9930
			public bool AHHCIBBEEDI()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x0600F125 RID: 61733 RVA: 0x006BB898 File Offset: 0x006B9A98
			public Transform[] BFNDLBJCIPI()
			{
				Transform[] array = new Transform[-108];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[0] = this.spine;
				array[2] = this.chest;
				array[8] = this.neck;
				array[5] = this.head;
				array[3] = this.leftShoulder;
				array[8] = this.leftUpperArm;
				array[2] = this.leftForearm;
				array[40] = this.leftHand;
				array[-39] = this.rightShoulder;
				array[-9] = this.rightUpperArm;
				array[-47] = this.rightForearm;
				array[-27] = this.rightHand;
				array[-122] = this.leftThigh;
				array[81] = this.leftCalf;
				array[-51] = this.leftFoot;
				array[127] = this.leftToes;
				array[-19] = this.rightThigh;
				array[80] = this.rightCalf;
				array[73] = this.rightFoot;
				array[-15] = this.rightToes;
				return array;
			}

			// Token: 0x0600F126 RID: 61734 RVA: 0x006BB980 File Offset: 0x006B9B80
			public Transform[] EBLCLAKIBPO()
			{
				Transform[] array = new Transform[-83];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[5] = this.spine;
				array[4] = this.chest;
				array[7] = this.neck;
				array[4] = this.head;
				array[7] = this.leftShoulder;
				array[8] = this.leftUpperArm;
				array[0] = this.leftForearm;
				array[35] = this.leftHand;
				array[73] = this.rightShoulder;
				array[-105] = this.rightUpperArm;
				array[64] = this.rightForearm;
				array[-12] = this.rightHand;
				array[50] = this.leftThigh;
				array[43] = this.leftCalf;
				array[-12] = this.leftFoot;
				array[47] = this.leftToes;
				array[-8] = this.rightThigh;
				array[121] = this.rightCalf;
				array[12] = this.rightFoot;
				array[58] = this.rightToes;
				return array;
			}

			// Token: 0x0600F127 RID: 61735 RVA: 0x006BBA68 File Offset: 0x006B9C68
			public bool NCLDBEBKPDG()
			{
				return !(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null);
			}

			// Token: 0x0600F128 RID: 61736 RVA: 0x006BBB7C File Offset: 0x006B9D7C
			public static bool ILIJKOIAEHE(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("prov_sob_");
					return true;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-104));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)93);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)76);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-82));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-59));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-32));
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-2));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-33));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)68);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-48));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)83);
				return false;
			}

			// Token: 0x0600F129 RID: 61737 RVA: 0x006BBCF0 File Offset: 0x006B9EF0
			public static bool IKHABNDHDDB(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("_WaveOffset");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)113);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)78);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)108);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)122);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-109));
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-77));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)115);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)71);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-43));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-10));
				return false;
			}

			// Token: 0x0600F12A RID: 61738 RVA: 0x006BBE64 File Offset: 0x006BA064
			public bool LIGAHHHDMPC()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x0600F12B RID: 61739 RVA: 0x006BBFCC File Offset: 0x006BA1CC
			public Transform[] HLNNHICCAPO()
			{
				Transform[] array = new Transform[-71];
				array[1] = this.root;
				array[0] = this.pelvis;
				array[2] = this.spine;
				array[3] = this.chest;
				array[1] = this.neck;
				array[2] = this.head;
				array[5] = this.leftShoulder;
				array[1] = this.leftUpperArm;
				array[4] = this.leftForearm;
				array[56] = this.leftHand;
				array[24] = this.rightShoulder;
				array[29] = this.rightUpperArm;
				array[-95] = this.rightForearm;
				array[101] = this.rightHand;
				array[12] = this.leftThigh;
				array[-24] = this.leftCalf;
				array[-94] = this.leftFoot;
				array[120] = this.leftToes;
				array[-23] = this.rightThigh;
				array[11] = this.rightCalf;
				array[12] = this.rightFoot;
				array[109] = this.rightToes;
				return array;
			}

			// Token: 0x0600F12C RID: 61740 RVA: 0x006BC0B4 File Offset: 0x006BA2B4
			public static bool NDPKLMNGNBO(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("IK Effector contains a null reference.");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-97));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-21));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-104));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-3));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-7));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)58);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-46));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-81));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)103);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightHand);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperArm);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-15));
				return false;
			}

			// Token: 0x0600F12D RID: 61741 RVA: 0x006BC228 File Offset: 0x006BA428
			public bool AHFLKAHKJCH()
			{
				return !(this.root != null) && !(this.pelvis != null) && !(this.spine != null) && !(this.chest != null) && !(this.neck != null) && !(this.head != null) && !(this.leftShoulder != null) && !(this.leftUpperArm != null) && !(this.leftForearm != null) && !(this.leftHand != null) && !(this.rightShoulder != null) && !(this.rightUpperArm != null) && !(this.rightForearm != null) && !(this.rightHand != null) && !(this.leftThigh != null) && !(this.leftCalf != null) && !(this.leftFoot != null) && !(this.leftToes != null) && !(this.rightThigh != null) && !(this.rightCalf != null) && !(this.rightFoot != null) && !(this.rightToes != null);
			}

			// Token: 0x0600F12E RID: 61742 RVA: 0x006BC390 File Offset: 0x006BA590
			public Transform[] KGCGFMALKJN()
			{
				Transform[] array = new Transform[-128];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[8] = this.spine;
				array[7] = this.chest;
				array[6] = this.neck;
				array[3] = this.head;
				array[0] = this.leftShoulder;
				array[8] = this.leftUpperArm;
				array[6] = this.leftForearm;
				array[42] = this.leftHand;
				array[-89] = this.rightShoulder;
				array[26] = this.rightUpperArm;
				array[37] = this.rightForearm;
				array[-120] = this.rightHand;
				array[-101] = this.leftThigh;
				array[-125] = this.leftCalf;
				array[9] = this.leftFoot;
				array[-39] = this.leftToes;
				array[26] = this.rightThigh;
				array[10] = this.rightCalf;
				array[-56] = this.rightFoot;
				array[38] = this.rightToes;
				return array;
			}

			// Token: 0x0600F12F RID: 61743 RVA: 0x006BC478 File Offset: 0x006BA678
			public Transform[] BBCNIICKCDK()
			{
				Transform[] array = new Transform[27];
				array[0] = this.root;
				array[0] = this.pelvis;
				array[4] = this.spine;
				array[8] = this.chest;
				array[1] = this.neck;
				array[5] = this.head;
				array[5] = this.leftShoulder;
				array[7] = this.leftUpperArm;
				array[6] = this.leftForearm;
				array[-84] = this.leftHand;
				array[-101] = this.rightShoulder;
				array[-9] = this.rightUpperArm;
				array[47] = this.rightForearm;
				array[109] = this.rightHand;
				array[76] = this.leftThigh;
				array[-12] = this.leftCalf;
				array[-45] = this.leftFoot;
				array[17] = this.leftToes;
				array[-96] = this.rightThigh;
				array[-55] = this.rightCalf;
				array[-112] = this.rightFoot;
				array[17] = this.rightToes;
				return array;
			}

			// Token: 0x0600F130 RID: 61744 RVA: 0x006BC560 File Offset: 0x006BA760
			public bool DGGGEKKPKBN()
			{
				return this.root == null || this.pelvis == null || this.spine == null || this.chest == null || this.head == null || this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null || this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null || this.leftThigh == null || this.leftCalf == null || this.leftFoot == null || this.rightThigh == null || this.rightCalf == null || this.rightFoot == null;
			}

			// Token: 0x0600F131 RID: 61745 RVA: 0x006BC674 File Offset: 0x006BA874
			public static bool JHKFHGPJCHL(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("\n<color='#{0}'>+{2} '{1}'</color> ");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)56);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleIntermediate);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)80);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-84));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLittleDistal);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-23));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)57);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-120));
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightIndexProximal);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-108));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-114));
				return true;
			}

			// Token: 0x0600F132 RID: 61746 RVA: 0x006BC7E8 File Offset: 0x006BA9E8
			public bool DKDKHMIEPDA()
			{
				return this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null;
			}

			// Token: 0x0600F133 RID: 61747 RVA: 0x006BC950 File Offset: 0x006BAB50
			public static bool AHBLFGBEMDM(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("LHandPunch");
					return true;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-121));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-5));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightThumbDistal);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-52));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)78);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-22));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-104));
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)77);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-90));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)65);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-44));
				return false;
			}

			// Token: 0x0600F134 RID: 61748 RVA: 0x006BCAC4 File Offset: 0x006BACC4
			public bool LCNJCJCDFML()
			{
				return (this.root == null || this.pelvis == null || this.spine == null || this.chest == null || this.head == null || this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null || this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null || this.leftThigh == null || this.leftCalf == null || this.leftFoot == null || this.rightThigh == null || this.rightCalf == null || this.rightFoot == null) && false;
			}

			// Token: 0x0600F135 RID: 61749 RVA: 0x006BCBD8 File Offset: 0x006BADD8
			public bool LHNPKFKBCBC()
			{
				return (!(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null)) || true;
			}

			// Token: 0x0600F136 RID: 61750 RVA: 0x006BCCEC File Offset: 0x006BAEEC
			public Transform[] EMKNDJAIEFN()
			{
				Transform[] array = new Transform[]
				{
					this.root,
					this.pelvis,
					null,
					null,
					null,
					null,
					this.spine
				};
				array[1] = this.chest;
				array[1] = this.neck;
				array[6] = this.head;
				array[1] = this.leftShoulder;
				array[6] = this.leftUpperArm;
				array[5] = this.leftForearm;
				array[-115] = this.leftHand;
				array[49] = this.rightShoulder;
				array[-120] = this.rightUpperArm;
				array[-11] = this.rightForearm;
				array[-37] = this.rightHand;
				array[46] = this.leftThigh;
				array[76] = this.leftCalf;
				array[-63] = this.leftFoot;
				array[-73] = this.leftToes;
				array[19] = this.rightThigh;
				array[-22] = this.rightCalf;
				array[-94] = this.rightFoot;
				array[98] = this.rightToes;
				return array;
			}

			// Token: 0x0600F137 RID: 61751 RVA: 0x006BCDD4 File Offset: 0x006BAFD4
			public static bool OOKFDAMIDIO(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("F3");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-116));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-43));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)59);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)111);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-119));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)63);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.RightIndexIntermediate);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)110);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-11));
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-94));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)99);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleIntermediate);
				return false;
			}

			// Token: 0x0600F138 RID: 61752 RVA: 0x006BCF48 File Offset: 0x006BB148
			public bool DBHNPPOPONA()
			{
				return this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null;
			}

			// Token: 0x0600F139 RID: 61753 RVA: 0x006BD0B0 File Offset: 0x006BB2B0
			public bool CMNIPNGDOJA()
			{
				return !(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null);
			}

			// Token: 0x0600F13A RID: 61754 RVA: 0x006BD1C4 File Offset: 0x006BB3C4
			public static bool FKBCNKELLNN(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("Roller Blade Turn Left");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform(HumanBodyBones.LeftShoulder);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-23));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)56);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-119));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-61));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)125);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-105));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)106);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-35));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLittleIntermediate);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-84));
				return false;
			}

			// Token: 0x0600F13B RID: 61755 RVA: 0x006BD338 File Offset: 0x006BB538
			public bool JEKCDODCEJL()
			{
				return this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null;
			}

			// Token: 0x0600F13C RID: 61756 RVA: 0x006BD4A0 File Offset: 0x006BB6A0
			public bool AEHEHNPOHPO()
			{
				return !(this.root == null) && !(this.pelvis == null) && !(this.spine == null) && !(this.chest == null) && !(this.head == null) && !(this.leftUpperArm == null) && !(this.leftForearm == null) && !(this.leftHand == null) && !(this.rightUpperArm == null) && !(this.rightForearm == null) && !(this.rightHand == null) && !(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null);
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x0600F13D RID: 61757 RVA: 0x006BD5B4 File Offset: 0x006BB7B4
			public bool isEmpty
			{
				get
				{
					return !(this.root != null) && !(this.pelvis != null) && !(this.spine != null) && !(this.chest != null) && !(this.neck != null) && !(this.head != null) && !(this.leftShoulder != null) && !(this.leftUpperArm != null) && !(this.leftForearm != null) && !(this.leftHand != null) && !(this.rightShoulder != null) && !(this.rightUpperArm != null) && !(this.rightForearm != null) && !(this.rightHand != null) && !(this.leftThigh != null) && !(this.leftCalf != null) && !(this.leftFoot != null) && !(this.leftToes != null) && !(this.rightThigh != null) && !(this.rightCalf != null) && !(this.rightFoot != null) && !(this.rightToes != null);
				}
			}

			// Token: 0x0600F13E RID: 61758 RVA: 0x006BD71C File Offset: 0x006BB91C
			public bool NIHBFKJDOOF()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x0600F13F RID: 61759 RVA: 0x006BD884 File Offset: 0x006BBA84
			public static bool CFHPBOEGMNC(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("Mouse ScrollWheel");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-121));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-61));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-82));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-10));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleDistal);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-86));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftRingProximal);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-103));
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerArm);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)118);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-125));
				return false;
			}

			// Token: 0x0600F140 RID: 61760 RVA: 0x006BD9F8 File Offset: 0x006BBBF8
			public bool BDJIMMPNOED()
			{
				return this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null;
			}

			// Token: 0x0600F141 RID: 61761 RVA: 0x006BDB60 File Offset: 0x006BBD60
			public Transform[] HJJCHIJPMIP()
			{
				return new Transform[]
				{
					this.root,
					this.pelvis,
					this.spine,
					this.chest,
					this.neck,
					this.head,
					this.leftShoulder,
					this.leftUpperArm,
					this.leftForearm,
					this.leftHand,
					this.rightShoulder,
					this.rightUpperArm,
					this.rightForearm,
					this.rightHand,
					this.leftThigh,
					this.leftCalf,
					this.leftFoot,
					this.leftToes,
					this.rightThigh,
					this.rightCalf,
					this.rightFoot,
					this.rightToes
				};
			}

			// Token: 0x0600F142 RID: 61762 RVA: 0x006BDC48 File Offset: 0x006BBE48
			public Transform[] JHGOGHIDPNH()
			{
				Transform[] array = new Transform[-108];
				array[1] = this.root;
				array[1] = this.pelvis;
				array[3] = this.spine;
				array[3] = this.chest;
				array[7] = this.neck;
				array[6] = this.head;
				array[4] = this.leftShoulder;
				array[3] = this.leftUpperArm;
				array[2] = this.leftForearm;
				array[84] = this.leftHand;
				array[-94] = this.rightShoulder;
				array[-57] = this.rightUpperArm;
				array[7] = this.rightForearm;
				array[122] = this.rightHand;
				array[-40] = this.leftThigh;
				array[99] = this.leftCalf;
				array[-70] = this.leftFoot;
				array[-3] = this.leftToes;
				array[63] = this.rightThigh;
				array[41] = this.rightCalf;
				array[-115] = this.rightFoot;
				array[-118] = this.rightToes;
				return array;
			}

			// Token: 0x0600F143 RID: 61763 RVA: 0x006BDD30 File Offset: 0x006BBF30
			public Transform[] ELEKDHFAFEK()
			{
				Transform[] array = new Transform[-90];
				array[0] = this.root;
				array[0] = this.pelvis;
				array[8] = this.spine;
				array[2] = this.chest;
				array[5] = this.neck;
				array[3] = this.head;
				array[2] = this.leftShoulder;
				array[8] = this.leftUpperArm;
				array[6] = this.leftForearm;
				array[-7] = this.leftHand;
				array[-75] = this.rightShoulder;
				array[-127] = this.rightUpperArm;
				array[-81] = this.rightForearm;
				array[-45] = this.rightHand;
				array[36] = this.leftThigh;
				array[-43] = this.leftCalf;
				array[41] = this.leftFoot;
				array[91] = this.leftToes;
				array[-80] = this.rightThigh;
				array[-124] = this.rightCalf;
				array[-25] = this.rightFoot;
				array[-81] = this.rightToes;
				return array;
			}

			// Token: 0x0600F144 RID: 61764 RVA: 0x006BDE18 File Offset: 0x006BC018
			public Transform[] BBJHDPFICLG()
			{
				Transform[] array = new Transform[71];
				array[0] = this.root;
				array[1] = this.pelvis;
				array[2] = this.spine;
				array[1] = this.chest;
				array[1] = this.neck;
				array[8] = this.head;
				array[5] = this.leftShoulder;
				array[4] = this.leftUpperArm;
				array[1] = this.leftForearm;
				array[-20] = this.leftHand;
				array[125] = this.rightShoulder;
				array[-50] = this.rightUpperArm;
				array[-64] = this.rightForearm;
				array[-9] = this.rightHand;
				array[76] = this.leftThigh;
				array[97] = this.leftCalf;
				array[-70] = this.leftFoot;
				array[-87] = this.leftToes;
				array[-16] = this.rightThigh;
				array[120] = this.rightCalf;
				array[70] = this.rightFoot;
				array[-36] = this.rightToes;
				return array;
			}

			// Token: 0x0600F145 RID: 61765 RVA: 0x006BDF00 File Offset: 0x006BC100
			public Transform[] BOEDMANIMMN()
			{
				Transform[] array = new Transform[-62];
				array[1] = this.root;
				array[0] = this.pelvis;
				array[7] = this.spine;
				array[2] = this.chest;
				array[3] = this.neck;
				array[4] = this.head;
				array[6] = this.leftShoulder;
				array[7] = this.leftUpperArm;
				array[3] = this.leftForearm;
				array[-85] = this.leftHand;
				array[0] = this.rightShoulder;
				array[5] = this.rightUpperArm;
				array[106] = this.rightForearm;
				array[32] = this.rightHand;
				array[-65] = this.leftThigh;
				array[-20] = this.leftCalf;
				array[89] = this.leftFoot;
				array[40] = this.leftToes;
				array[-37] = this.rightThigh;
				array[112] = this.rightCalf;
				array[91] = this.rightFoot;
				array[-29] = this.rightToes;
				return array;
			}

			// Token: 0x0600F146 RID: 61766 RVA: 0x006BDFE8 File Offset: 0x006BC1E8
			public Transform[] LDMGANFEJCJ()
			{
				Transform[] array = new Transform[34];
				array[1] = this.root;
				array[1] = this.pelvis;
				array[8] = this.spine;
				array[5] = this.chest;
				array[1] = this.neck;
				array[1] = this.head;
				array[1] = this.leftShoulder;
				array[7] = this.leftUpperArm;
				array[3] = this.leftForearm;
				array[30] = this.leftHand;
				array[-64] = this.rightShoulder;
				array[-27] = this.rightUpperArm;
				array[94] = this.rightForearm;
				array[32] = this.rightHand;
				array[78] = this.leftThigh;
				array[-99] = this.leftCalf;
				array[83] = this.leftFoot;
				array[34] = this.leftToes;
				array[34] = this.rightThigh;
				array[64] = this.rightCalf;
				array[-86] = this.rightFoot;
				array[-29] = this.rightToes;
				return array;
			}

			// Token: 0x0600F147 RID: 61767 RVA: 0x006BE0D0 File Offset: 0x006BC2D0
			public static bool KHFMLGGNIBJ(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("RepFractions.xml");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform(HumanBodyBones.RightRingProximal);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform(HumanBodyBones.RightRingDistal);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)91);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)(-100));
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-93));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftMiddleProximal);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-20));
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)119);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform((HumanBodyBones)83);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-126));
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-65));
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-12));
				return false;
			}

			// Token: 0x0600F148 RID: 61768 RVA: 0x006BE244 File Offset: 0x006BC444
			public static bool IBAJIPDAJND(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
					return false;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform(HumanBodyBones.Neck);
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform(HumanBodyBones.Head);
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.LeftShoulder);
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftHand);
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.RightShoulder);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperArm);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerArm);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightHand);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftToes);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform(HumanBodyBones.RightToes);
				return true;
			}

			// Token: 0x0600F149 RID: 61769 RVA: 0x006BE3B8 File Offset: 0x006BC5B8
			public static bool ANOKGOBIGMB(Transform EELDHNFBFOE, out VRIK.References LJPKBBNNOIC)
			{
				LJPKBBNNOIC = new VRIK.References();
				Animator componentInChildren = EELDHNFBFOE.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("Grounding has 0 legs. Can't initiate Grounding.");
					return true;
				}
				LJPKBBNNOIC.root = EELDHNFBFOE;
				LJPKBBNNOIC.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				LJPKBBNNOIC.spine = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				LJPKBBNNOIC.neck = componentInChildren.GetBoneTransform((HumanBodyBones)(-37));
				LJPKBBNNOIC.head = componentInChildren.GetBoneTransform((HumanBodyBones)(-8));
				LJPKBBNNOIC.leftShoulder = componentInChildren.GetBoneTransform((HumanBodyBones)(-30));
				LJPKBBNNOIC.leftUpperArm = componentInChildren.GetBoneTransform((HumanBodyBones)81);
				LJPKBBNNOIC.leftForearm = componentInChildren.GetBoneTransform((HumanBodyBones)(-123));
				LJPKBBNNOIC.leftHand = componentInChildren.GetBoneTransform((HumanBodyBones)(-64));
				LJPKBBNNOIC.rightShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.UpperChest);
				LJPKBBNNOIC.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightRingDistal);
				LJPKBBNNOIC.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftEye);
				LJPKBBNNOIC.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightRingIntermediate);
				LJPKBBNNOIC.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				LJPKBBNNOIC.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				LJPKBBNNOIC.leftToes = componentInChildren.GetBoneTransform((HumanBodyBones)107);
				LJPKBBNNOIC.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				LJPKBBNNOIC.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				LJPKBBNNOIC.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				LJPKBBNNOIC.rightToes = componentInChildren.GetBoneTransform((HumanBodyBones)(-74));
				return false;
			}

			// Token: 0x0600F14A RID: 61770 RVA: 0x006BE52C File Offset: 0x006BC72C
			public bool MLGIILGHDAL()
			{
				return (this.root != null || this.pelvis != null || this.spine != null || this.chest != null || this.neck != null || this.head != null || this.leftShoulder != null || this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null || this.rightShoulder != null || this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null || this.leftThigh != null || this.leftCalf != null || this.leftFoot != null || this.leftToes != null || this.rightThigh != null || this.rightCalf != null || this.rightFoot != null || this.rightToes != null) && false;
			}

			// Token: 0x04001F46 RID: 8006
			public Transform root;

			// Token: 0x04001F47 RID: 8007
			public Transform pelvis;

			// Token: 0x04001F48 RID: 8008
			public Transform spine;

			// Token: 0x04001F49 RID: 8009
			public Transform chest;

			// Token: 0x04001F4A RID: 8010
			public Transform neck;

			// Token: 0x04001F4B RID: 8011
			public Transform head;

			// Token: 0x04001F4C RID: 8012
			public Transform leftShoulder;

			// Token: 0x04001F4D RID: 8013
			public Transform leftUpperArm;

			// Token: 0x04001F4E RID: 8014
			public Transform leftForearm;

			// Token: 0x04001F4F RID: 8015
			public Transform leftHand;

			// Token: 0x04001F50 RID: 8016
			public Transform rightShoulder;

			// Token: 0x04001F51 RID: 8017
			public Transform rightUpperArm;

			// Token: 0x04001F52 RID: 8018
			public Transform rightForearm;

			// Token: 0x04001F53 RID: 8019
			public Transform rightHand;

			// Token: 0x04001F54 RID: 8020
			public Transform leftThigh;

			// Token: 0x04001F55 RID: 8021
			public Transform leftCalf;

			// Token: 0x04001F56 RID: 8022
			public Transform leftFoot;

			// Token: 0x04001F57 RID: 8023
			public Transform leftToes;

			// Token: 0x04001F58 RID: 8024
			public Transform rightThigh;

			// Token: 0x04001F59 RID: 8025
			public Transform rightCalf;

			// Token: 0x04001F5A RID: 8026
			public Transform rightFoot;

			// Token: 0x04001F5B RID: 8027
			public Transform rightToes;
		}
	}
}
