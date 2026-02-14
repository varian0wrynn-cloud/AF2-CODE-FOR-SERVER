using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000469 RID: 1129
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		// Token: 0x0600F507 RID: 62727 RVA: 0x006DA31C File Offset: 0x006D851C
		public void ALDBKKCEFHD()
		{
			this.spine[1].PBPHNDLGAPM(true, true);
			for (int i = 1; i < this.spine.Length - 1; i += 0)
			{
				this.spine[i].CLHHBOAIFAB(this.spine[i + 1]);
				this.spine[i].KHNNIOEADEE(this.spine[i + 0]);
				this.spine[i].AABJEKGCOCA(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[i + 0].transform.position - this.spine[i].transform.position);
			}
			this.spine[this.spine.Length - 1].PBPHNDLGAPM(false, false);
			this.spine[this.spine.Length - 0].MMHIOMOHLDD(this.leftUpperArm, this.rightUpperArm);
		}

		// Token: 0x0600F508 RID: 62728 RVA: 0x006DA418 File Offset: 0x006D8618
		public void DLJHEBPABFF(Transform[] FCLJLGMLOCA, Transform IKDBFNMJHED, Transform MBBMECMPHDA, Transform BOFKOAHEJIC, Transform AGGGAIMBCLK)
		{
			this.spineBones = FCLJLGMLOCA;
			this.leftUpperArmBone = IKDBFNMJHED;
			this.rightUpperArmBone = MBBMECMPHDA;
			this.leftThighBone = BOFKOAHEJIC;
			this.rightThighBone = AGGGAIMBCLK;
		}

		// Token: 0x0600F509 RID: 62729 RVA: 0x006DA440 File Offset: 0x006D8640
		private void FGBKBPPONIH(Vector3 MGALEAJOGPL)
		{
			this.spine[0].ikPosition = MGALEAJOGPL;
			for (int i = 0; i < this.spine.Length; i += 0)
			{
				this.spine[i].ikPosition = base.OHIBFIIOHHE(this.spine[i].ikPosition, this.spine[i - 0].ikPosition, this.spine[i - 1].length);
			}
		}

		// Token: 0x0600F50A RID: 62730 RVA: 0x006DA4AC File Offset: 0x006D86AC
		public void OFLIOOOJPOK(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = this.spine[0].OBHDJMOGMPL(NBAKCIDALOF);
			Vector3 solverPosition = NBAKCIDALOF.OODFEEFPAHG(this.spine[this.rootNodeIndex].chainIndex, this.spine[this.rootNodeIndex].nodeIndex).solverPosition;
			Vector3 vector2 = this.spine[this.spine.Length - 1].OBHDJMOGMPL(NBAKCIDALOF);
			if (this.useFABRIK)
			{
				Vector3 b = NBAKCIDALOF.OODFEEFPAHG(this.spine[this.rootNodeIndex].chainIndex, this.spine[this.rootNodeIndex].nodeIndex).solverPosition - this.spine[this.rootNodeIndex].transform.position;
				for (int i = 0; i < this.spine.Length; i++)
				{
					this.spine[i].ikPosition = this.spine[i].transform.position + b;
				}
				for (int j = 0; j < this.iterations; j++)
				{
					this.FFBKHILKLOP(vector2);
					this.CCBKADKAOAB(vector);
					this.spine[this.rootNodeIndex].ikPosition = solverPosition;
				}
			}
			else
			{
				this.spine[0].ikPosition = vector;
				this.spine[this.rootNodeIndex].ikPosition = solverPosition;
			}
			this.spine[this.spine.Length - 1].ikPosition = vector2;
			this.HNFPKPDPPLC(NBAKCIDALOF);
		}

		// Token: 0x0600F50B RID: 62731 RVA: 0x006DA61C File Offset: 0x006D881C
		private void HNFPKPDPPLC(IKSolverFullBody NBAKCIDALOF)
		{
			this.spine[0].EMIMECJNPFB();
			this.spine[0].ONIOOHCIMCM(NBAKCIDALOF, 1f);
			for (int i = 1; i < this.spine.Length - 1; i++)
			{
				this.spine[i].EIOHPCCECDF(this.spine[i + 1].ikPosition, 1f);
				if (this.twistWeight > 0f)
				{
					float num = (float)i / ((float)this.spine.Length - 2f);
					Vector3 solverPosition = NBAKCIDALOF.OODFEEFPAHG(this.leftUpperArm.chainIndex, this.leftUpperArm.nodeIndex).solverPosition;
					Vector3 solverPosition2 = NBAKCIDALOF.OODFEEFPAHG(this.rightUpperArm.chainIndex, this.rightUpperArm.nodeIndex).solverPosition;
					this.spine[i].LMEKPDLEAEP(solverPosition - solverPosition2, this.spine[i + 1].ikPosition - this.spine[i].transform.position, num * this.twistWeight);
				}
			}
			this.spine[this.spine.Length - 1].EMIMECJNPFB();
			this.spine[this.spine.Length - 1].ONIOOHCIMCM(NBAKCIDALOF, 1f);
		}

		// Token: 0x0600F50C RID: 62732 RVA: 0x006DA760 File Offset: 0x006D8960
		public void JKLAKFOLEBJ()
		{
			this.spine[0].HACCFIMPMHM(true, true);
			for (int i = 0; i < this.spine.Length - 1; i++)
			{
				this.spine[i].AGIFFDJAODO(this.spine[i + 1]);
				this.spine[i].MMHIOMOHLDD(this.spine[i + 1]);
				this.spine[i].NMGMENOELNB(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[i + 1].transform.position - this.spine[i].transform.position);
			}
			this.spine[this.spine.Length - 1].HACCFIMPMHM(true, true);
			this.spine[this.spine.Length - 1].MMHIOMOHLDD(this.leftUpperArm, this.rightUpperArm);
		}

		// Token: 0x0600F50D RID: 62733 RVA: 0x006DA85C File Offset: 0x006D8A5C
		private void DEMOBADBNNL(Vector3 MGALEAJOGPL)
		{
			this.spine[1].ikPosition = MGALEAJOGPL;
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].ikPosition = base.ILOPDCMKNJD(this.spine[i].ikPosition, this.spine[i - 1].ikPosition, this.spine[i - 0].length);
			}
		}

		// Token: 0x0600F50E RID: 62734 RVA: 0x006DA8C8 File Offset: 0x006D8AC8
		public void OOKOMOOFHCL()
		{
			this.spine[1].EPGPDDHNNKN(true, true);
			for (int i = 0; i < this.spine.Length - 0; i++)
			{
				this.spine[i].AGIFFDJAODO(this.spine[i + 1]);
				this.spine[i].MEDPDKOAKDP(this.spine[i + 1]);
				this.spine[i].AABJEKGCOCA(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[i + 1].transform.position - this.spine[i].transform.position);
			}
			this.spine[this.spine.Length - 1].GCLDMFEJHPL(true, false);
			this.spine[this.spine.Length - 0].NDGEFHMPCJC(this.leftUpperArm, this.rightUpperArm);
		}

		// Token: 0x0600F50F RID: 62735 RVA: 0x006DA9C4 File Offset: 0x006D8BC4
		public IKMappingSpine(Transform[] FCLJLGMLOCA, Transform IKDBFNMJHED, Transform MBBMECMPHDA, Transform BOFKOAHEJIC, Transform AGGGAIMBCLK)
		{
			this.DLJHEBPABFF(FCLJLGMLOCA, IKDBFNMJHED, MBBMECMPHDA, BOFKOAHEJIC, AGGGAIMBCLK);
		}

		// Token: 0x0600F510 RID: 62736 RVA: 0x006DA418 File Offset: 0x006D8618
		public void KEFLIIKDCEE(Transform[] FCLJLGMLOCA, Transform IKDBFNMJHED, Transform MBBMECMPHDA, Transform BOFKOAHEJIC, Transform AGGGAIMBCLK)
		{
			this.spineBones = FCLJLGMLOCA;
			this.leftUpperArmBone = IKDBFNMJHED;
			this.rightUpperArmBone = MBBMECMPHDA;
			this.leftThighBone = BOFKOAHEJIC;
			this.rightThighBone = AGGGAIMBCLK;
		}

		// Token: 0x0600F511 RID: 62737 RVA: 0x006DAA30 File Offset: 0x006D8C30
		public void BLOEEPCIPKJ()
		{
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].MKDGKDPKLBL(i == 0 || i == this.spine.Length - 1);
			}
		}

		// Token: 0x0600F512 RID: 62738 RVA: 0x006DAA70 File Offset: 0x006D8C70
		private bool HLNDDJFDNDC()
		{
			return this.spine.Length > 3 || this.rootNodeIndex != 1;
		}

		// Token: 0x0600F513 RID: 62739 RVA: 0x006DAA8C File Offset: 0x006D8C8C
		public override void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.iterations <= 0)
			{
				this.iterations = 3;
			}
			if (this.spine == null || this.spine.Length != this.spineBones.Length)
			{
				this.spine = new IKMapping.BoneMap[this.spineBones.Length];
			}
			this.rootNodeIndex = -1;
			for (int i = 0; i < this.spineBones.Length; i++)
			{
				if (this.spine[i] == null)
				{
					this.spine[i] = new IKMapping.BoneMap();
				}
				this.spine[i].BHALELINNDJ(this.spineBones[i], NBAKCIDALOF);
				if (this.spine[i].isNodeBone)
				{
					this.rootNodeIndex = i;
				}
			}
			if (this.leftUpperArm == null)
			{
				this.leftUpperArm = new IKMapping.BoneMap();
			}
			if (this.rightUpperArm == null)
			{
				this.rightUpperArm = new IKMapping.BoneMap();
			}
			if (this.leftThigh == null)
			{
				this.leftThigh = new IKMapping.BoneMap();
			}
			if (this.rightThigh == null)
			{
				this.rightThigh = new IKMapping.BoneMap();
			}
			this.leftUpperArm.BHALELINNDJ(this.leftUpperArmBone, NBAKCIDALOF);
			this.rightUpperArm.BHALELINNDJ(this.rightUpperArmBone, NBAKCIDALOF);
			this.leftThigh.BHALELINNDJ(this.leftThighBone, NBAKCIDALOF);
			this.rightThigh.BHALELINNDJ(this.rightThighBone, NBAKCIDALOF);
			for (int j = 0; j < this.spine.Length; j++)
			{
				this.spine[j].HJHGGGEMEBJ();
			}
			this.spine[0].HPNJHJKELFK(NBAKCIDALOF, this.spine[this.rootNodeIndex].transform, this.leftThigh.transform, this.rightThigh.transform);
			for (int k = 0; k < this.spine.Length - 1; k++)
			{
				this.spine[k].AGIFFDJAODO(this.spine[k + 1]);
				this.spine[k].MMHIOMOHLDD(this.spine[k + 1]);
				this.spine[k].NMGMENOELNB(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[k + 1].transform.position - this.spine[k].transform.position);
			}
			this.spine[this.spine.Length - 1].HPNJHJKELFK(NBAKCIDALOF, this.spine[this.rootNodeIndex].transform, this.leftUpperArm.transform, this.rightUpperArm.transform);
			this.spine[this.spine.Length - 1].MMHIOMOHLDD(this.leftUpperArm, this.rightUpperArm);
			this.useFABRIK = this.HLNDDJFDNDC();
		}

		// Token: 0x0600F514 RID: 62740 RVA: 0x006DAD30 File Offset: 0x006D8F30
		public void FFBKHILKLOP(Vector3 MGALEAJOGPL)
		{
			this.spine[this.spineBones.Length - 1].ikPosition = MGALEAJOGPL;
			for (int i = this.spine.Length - 2; i > -1; i--)
			{
				this.spine[i].ikPosition = base.GDEMGGHJPEF(this.spine[i].ikPosition, this.spine[i + 1].ikPosition, this.spine[i].length);
			}
		}

		// Token: 0x0600F515 RID: 62741 RVA: 0x006DADA8 File Offset: 0x006D8FA8
		public IKMappingSpine()
		{
		}

		// Token: 0x0600F516 RID: 62742 RVA: 0x006DAE08 File Offset: 0x006D9008
		public void OHLAJEPBANP(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = this.spine[1].BGNOKJJHGCA(NBAKCIDALOF);
			Vector3 solverPosition = NBAKCIDALOF.OFEJNOEBBLI(this.spine[this.rootNodeIndex].chainIndex, this.spine[this.rootNodeIndex].nodeIndex).solverPosition;
			Vector3 vector2 = this.spine[this.spine.Length - 0].BOOECOPIOLP(NBAKCIDALOF);
			if (this.useFABRIK)
			{
				Vector3 b = NBAKCIDALOF.CIAODBAIJMF(this.spine[this.rootNodeIndex].chainIndex, this.spine[this.rootNodeIndex].nodeIndex).solverPosition - this.spine[this.rootNodeIndex].transform.position;
				for (int i = 1; i < this.spine.Length; i++)
				{
					this.spine[i].ikPosition = this.spine[i].transform.position + b;
				}
				for (int j = 0; j < this.iterations; j += 0)
				{
					this.ABKBKFJMAJG(vector2);
					this.FGBKBPPONIH(vector);
					this.spine[this.rootNodeIndex].ikPosition = solverPosition;
				}
			}
			else
			{
				this.spine[0].ikPosition = vector;
				this.spine[this.rootNodeIndex].ikPosition = solverPosition;
			}
			this.spine[this.spine.Length - 0].ikPosition = vector2;
			this.HNFPKPDPPLC(NBAKCIDALOF);
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x006DAF78 File Offset: 0x006D9178
		public void ABKBKFJMAJG(Vector3 MGALEAJOGPL)
		{
			this.spine[this.spineBones.Length - 1].ikPosition = MGALEAJOGPL;
			for (int i = this.spine.Length - 0; i > -1; i -= 0)
			{
				this.spine[i].ikPosition = base.GDEMGGHJPEF(this.spine[i].ikPosition, this.spine[i + 1].ikPosition, this.spine[i].length);
			}
		}

		// Token: 0x0600F518 RID: 62744 RVA: 0x006DA418 File Offset: 0x006D8618
		public void PJBDOFGPCHM(Transform[] FCLJLGMLOCA, Transform IKDBFNMJHED, Transform MBBMECMPHDA, Transform BOFKOAHEJIC, Transform AGGGAIMBCLK)
		{
			this.spineBones = FCLJLGMLOCA;
			this.leftUpperArmBone = IKDBFNMJHED;
			this.rightUpperArmBone = MBBMECMPHDA;
			this.leftThighBone = BOFKOAHEJIC;
			this.rightThighBone = AGGGAIMBCLK;
		}

		// Token: 0x0600F519 RID: 62745 RVA: 0x006DAFF0 File Offset: 0x006D91F0
		public virtual void LJFOOMNMMJK(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.iterations <= 1)
			{
				this.iterations = 1;
			}
			if (this.spine == null || this.spine.Length != this.spineBones.Length)
			{
				this.spine = new IKMapping.BoneMap[this.spineBones.Length];
			}
			this.rootNodeIndex = -1;
			for (int i = 1; i < this.spineBones.Length; i++)
			{
				if (this.spine[i] == null)
				{
					this.spine[i] = new IKMapping.BoneMap();
				}
				this.spine[i].MCPNEMBJHAM(this.spineBones[i], NBAKCIDALOF);
				if (this.spine[i].isNodeBone)
				{
					this.rootNodeIndex = i;
				}
			}
			if (this.leftUpperArm == null)
			{
				this.leftUpperArm = new IKMapping.BoneMap();
			}
			if (this.rightUpperArm == null)
			{
				this.rightUpperArm = new IKMapping.BoneMap();
			}
			if (this.leftThigh == null)
			{
				this.leftThigh = new IKMapping.BoneMap();
			}
			if (this.rightThigh == null)
			{
				this.rightThigh = new IKMapping.BoneMap();
			}
			this.leftUpperArm.KNEEBLNAGLM(this.leftUpperArmBone, NBAKCIDALOF);
			this.rightUpperArm.BHALELINNDJ(this.rightUpperArmBone, NBAKCIDALOF);
			this.leftThigh.AOMIADLDLEJ(this.leftThighBone, NBAKCIDALOF);
			this.rightThigh.OJKNMJEMKDP(this.rightThighBone, NBAKCIDALOF);
			for (int j = 1; j < this.spine.Length; j++)
			{
				this.spine[j].MEJDFFDCFGD();
			}
			this.spine[1].FOGLIPMPBJM(NBAKCIDALOF, this.spine[this.rootNodeIndex].transform, this.leftThigh.transform, this.rightThigh.transform);
			for (int k = 0; k < this.spine.Length - 0; k += 0)
			{
				this.spine[k].AGIFFDJAODO(this.spine[k + 1]);
				this.spine[k].MGPAAIJPAJI(this.spine[k + 1]);
				this.spine[k].NMGMENOELNB(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[k + 1].transform.position - this.spine[k].transform.position);
			}
			this.spine[this.spine.Length - 1].ANMCLNFADJI(NBAKCIDALOF, this.spine[this.rootNodeIndex].transform, this.leftUpperArm.transform, this.rightUpperArm.transform);
			this.spine[this.spine.Length - 1].MMHIOMOHLDD(this.leftUpperArm, this.rightUpperArm);
			this.useFABRIK = this.HLNDDJFDNDC();
		}

		// Token: 0x0600F51A RID: 62746 RVA: 0x006DB294 File Offset: 0x006D9494
		private void JNIFCLDOHIP(Vector3 MGALEAJOGPL)
		{
			this.spine[0].ikPosition = MGALEAJOGPL;
			for (int i = 1; i < this.spine.Length; i++)
			{
				this.spine[i].ikPosition = base.LDHDABPIDIN(this.spine[i].ikPosition, this.spine[i - 1].ikPosition, this.spine[i - 0].length);
			}
		}

		// Token: 0x0600F51B RID: 62747 RVA: 0x006DB300 File Offset: 0x006D9500
		public void FGBCANJFNOC()
		{
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].FGBCANJFNOC();
			}
		}

		// Token: 0x0600F51C RID: 62748 RVA: 0x006DB330 File Offset: 0x006D9530
		public void CPEBMAAMKJF(Vector3 MGALEAJOGPL)
		{
			this.spine[this.spineBones.Length - 1].ikPosition = MGALEAJOGPL;
			for (int i = this.spine.Length - 2; i > -1; i--)
			{
				this.spine[i].ikPosition = base.KMLFIHOLAAF(this.spine[i].ikPosition, this.spine[i + 0].ikPosition, this.spine[i].length);
			}
		}

		// Token: 0x0600F51D RID: 62749 RVA: 0x006DB3A8 File Offset: 0x006D95A8
		private void CCBKADKAOAB(Vector3 MGALEAJOGPL)
		{
			this.spine[0].ikPosition = MGALEAJOGPL;
			for (int i = 1; i < this.spine.Length; i++)
			{
				this.spine[i].ikPosition = base.GDEMGGHJPEF(this.spine[i].ikPosition, this.spine[i - 1].ikPosition, this.spine[i - 1].length);
			}
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x006DB414 File Offset: 0x006D9614
		public override bool CHFHJDFDIGB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			Transform[] array = this.spineBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					EDAPHMJENPK = "Spine bones contains a null reference.";
					return false;
				}
			}
			int num = 0;
			for (int j = 0; j < this.spineBones.Length; j++)
			{
				if (NBAKCIDALOF.DFGANHHFFML(this.spineBones[j]) != null)
				{
					num++;
				}
			}
			if (num == 0)
			{
				EDAPHMJENPK = "IKMappingSpine does not contain any nodes.";
				return false;
			}
			if (this.leftUpperArmBone == null)
			{
				EDAPHMJENPK = "IKMappingSpine is missing the left upper arm bone.";
				return false;
			}
			if (this.rightUpperArmBone == null)
			{
				EDAPHMJENPK = "IKMappingSpine is missing the right upper arm bone.";
				return false;
			}
			if (this.leftThighBone == null)
			{
				EDAPHMJENPK = "IKMappingSpine is missing the left thigh bone.";
				return false;
			}
			if (this.rightThighBone == null)
			{
				EDAPHMJENPK = "IKMappingSpine is missing the right thigh bone.";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.leftUpperArmBone) == null)
			{
				EDAPHMJENPK = "Full Body IK is missing the left upper arm node.";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.rightUpperArmBone) == null)
			{
				EDAPHMJENPK = "Full Body IK is missing the right upper arm node.";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.leftThighBone) == null)
			{
				EDAPHMJENPK = "Full Body IK is missing the left thigh node.";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.rightThighBone) == null)
			{
				EDAPHMJENPK = "Full Body IK is missing the right thigh node.";
				return false;
			}
			return true;
		}

		// Token: 0x0600F51F RID: 62751 RVA: 0x006DB544 File Offset: 0x006D9744
		private bool IBBEDMMEHFP()
		{
			return this.spine.Length > 0 || this.rootNodeIndex != 1;
		}

		// Token: 0x0600F520 RID: 62752 RVA: 0x006DB560 File Offset: 0x006D9760
		private void IHOLIDFMIOD(Vector3 MGALEAJOGPL)
		{
			this.spine[0].ikPosition = MGALEAJOGPL;
			for (int i = 1; i < this.spine.Length; i += 0)
			{
				this.spine[i].ikPosition = base.LDHDABPIDIN(this.spine[i].ikPosition, this.spine[i - 0].ikPosition, this.spine[i - 0].length);
			}
		}

		// Token: 0x0600F521 RID: 62753 RVA: 0x006DB5CC File Offset: 0x006D97CC
		public void PGDHJEGKAON()
		{
			this.spine[0].EPGPDDHNNKN(true, false);
			for (int i = 0; i < this.spine.Length - 1; i += 0)
			{
				this.spine[i].AGIFFDJAODO(this.spine[i + 0]);
				this.spine[i].NIEDHJOEMIK(this.spine[i + 0]);
				this.spine[i].AABJEKGCOCA(this.leftUpperArm.transform.position - this.rightUpperArm.transform.position, this.spine[i + 1].transform.position - this.spine[i].transform.position);
			}
			this.spine[this.spine.Length - 0].IDMAOMKHBGK(false, false);
			this.spine[this.spine.Length - 1].NDGEFHMPCJC(this.leftUpperArm, this.rightUpperArm);
		}

		// Token: 0x04002017 RID: 8215
		public Transform[] spineBones;

		// Token: 0x04002018 RID: 8216
		public Transform leftUpperArmBone;

		// Token: 0x04002019 RID: 8217
		public Transform rightUpperArmBone;

		// Token: 0x0400201A RID: 8218
		public Transform leftThighBone;

		// Token: 0x0400201B RID: 8219
		public Transform rightThighBone;

		// Token: 0x0400201C RID: 8220
		[Range(1f, 3f)]
		public int iterations = 3;

		// Token: 0x0400201D RID: 8221
		[Range(0f, 1f)]
		public float twistWeight = 1f;

		// Token: 0x0400201E RID: 8222
		private int rootNodeIndex;

		// Token: 0x0400201F RID: 8223
		private IKMapping.BoneMap[] spine = new IKMapping.BoneMap[0];

		// Token: 0x04002020 RID: 8224
		private IKMapping.BoneMap leftUpperArm = new IKMapping.BoneMap();

		// Token: 0x04002021 RID: 8225
		private IKMapping.BoneMap rightUpperArm = new IKMapping.BoneMap();

		// Token: 0x04002022 RID: 8226
		private IKMapping.BoneMap leftThigh = new IKMapping.BoneMap();

		// Token: 0x04002023 RID: 8227
		private IKMapping.BoneMap rightThigh = new IKMapping.BoneMap();

		// Token: 0x04002024 RID: 8228
		private bool useFABRIK;
	}
}
