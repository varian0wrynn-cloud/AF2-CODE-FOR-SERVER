using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000477 RID: 1143
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		// Token: 0x0600F7E6 RID: 63462 RVA: 0x006F6680 File Offset: 0x006F4880
		public IKConstraintBend JEFIAPGCAJN(FullBodyBipedChain BLGLKIFEJKI)
		{
			switch (BLGLKIFEJKI)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1].bendConstraint;
			case FullBodyBipedChain.RightArm:
				return this.chain[2].bendConstraint;
			case FullBodyBipedChain.LeftLeg:
				return this.chain[3].bendConstraint;
			case FullBodyBipedChain.RightLeg:
				return this.chain[4].bendConstraint;
			default:
				return null;
			}
		}

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x006F66DE File Offset: 0x006F48DE
		public IKMappingLimb LBOOMHCCGKC()
		{
			return this.limbMappings[0];
		}

		// Token: 0x0600F7E8 RID: 63464 RVA: 0x006F66E8 File Offset: 0x006F48E8
		public FBIKChain LGOKBJOBPAO(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.chain[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.chain[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.chain[2];
			case FullBodyBipedEffector.LeftThigh:
				return this.chain[3];
			case FullBodyBipedEffector.RightThigh:
				return this.chain[4];
			case FullBodyBipedEffector.LeftHand:
				return this.chain[1];
			case FullBodyBipedEffector.RightHand:
				return this.chain[2];
			case FullBodyBipedEffector.LeftFoot:
				return this.chain[3];
			case FullBodyBipedEffector.RightFoot:
				return this.chain[4];
			default:
				return null;
			}
		}

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x006F6773 File Offset: 0x006F4973
		public FBIKChain GKPAKFLPCHP()
		{
			return this.chain[7];
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x006F6780 File Offset: 0x006F4980
		public IKConstraintBend CHGINMHHHEM(FullBodyBipedChain BLGLKIFEJKI)
		{
			switch (BLGLKIFEJKI)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[0].bendConstraint;
			case FullBodyBipedChain.RightArm:
				return this.chain[0].bendConstraint;
			case FullBodyBipedChain.LeftLeg:
				return this.chain[4].bendConstraint;
			case FullBodyBipedChain.RightLeg:
				return this.chain[5].bendConstraint;
			default:
				return null;
			}
		}

		// Token: 0x0600F7EB RID: 63467 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb LEPJCJPJBBA()
		{
			return this.limbMappings[1];
		}

		// Token: 0x0600F7EC RID: 63468 RVA: 0x006F67E8 File Offset: 0x006F49E8
		public FBIKChain NNPMPAHLAJD(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.chain[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.chain[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.chain[6];
			case FullBodyBipedEffector.LeftThigh:
				return this.chain[7];
			case FullBodyBipedEffector.RightThigh:
				return this.chain[0];
			case FullBodyBipedEffector.LeftHand:
				return this.chain[1];
			case FullBodyBipedEffector.RightHand:
				return this.chain[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.chain[3];
			case FullBodyBipedEffector.RightFoot:
				return this.chain[4];
			default:
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600F7ED RID: 63469 RVA: 0x006F6873 File Offset: 0x006F4A73
		public IKEffector rightHandEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.RightHand);
			}
		}

		// Token: 0x0600F7EE RID: 63470 RVA: 0x006F687C File Offset: 0x006F4A7C
		public static Transform IBKIHIJCIEN(BipedReferences LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				return null;
			}
			if (LJPKBBNNOIC.spine.Length < 0)
			{
				return null;
			}
			int num = LJPKBBNNOIC.spine.Length;
			if (num == 0)
			{
				return LJPKBBNNOIC.spine[1];
			}
			Vector3 b = Vector3.Lerp(LJPKBBNNOIC.leftThigh.position, LJPKBBNNOIC.rightThigh.position, 1801f);
			Vector3 onNormal = Vector3.Lerp(LJPKBBNNOIC.leftUpperArm.position, LJPKBBNNOIC.rightUpperArm.position, 1518f) - b;
			float magnitude = onNormal.magnitude;
			if (LJPKBBNNOIC.spine.Length < 5)
			{
				return LJPKBBNNOIC.spine[0];
			}
			int num2 = 0;
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Vector3.Project(LJPKBBNNOIC.spine[i].position - b, onNormal);
				if (Vector3.Dot(vector.normalized, onNormal.normalized) > 833f && vector.magnitude / magnitude < 1262f)
				{
					num2 = i;
				}
			}
			return LJPKBBNNOIC.spine[num2];
		}

		// Token: 0x0600F7EF RID: 63471 RVA: 0x006F6980 File Offset: 0x006F4B80
		protected override void OFLIOOOJPOK()
		{
			if (this.iterations == 0)
			{
				this.spineMapping.spineBones[0].position += this.offset;
			}
			base.OFLIOOOJPOK();
		}

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x006F69B4 File Offset: 0x006F4BB4
		public void LHIFOKBEMMG(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM = null)
		{
			this.root = LJPKBBNNOIC.root;
			if (KAOKEJPBAHM == null)
			{
				KAOKEJPBAHM = IKSolverFullBodyBiped.NFJOLIHNHCO(LJPKBBNNOIC);
			}
			this.rootNode = KAOKEJPBAHM;
			if (this.chain == null || this.chain.Length != 7)
			{
				this.chain = new FBIKChain[7];
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i] == null)
				{
					this.chain[i] = new FBIKChain();
				}
			}
			this.chain[1].pin = 656f;
			this.chain[1].IFBOGGIPIMC(new Transform[]
			{
				KAOKEJPBAHM
			});
			this.chain[1].children = new int[]
			{
				1,
				2
			};
			FBIKChain fbikchain = this.chain[1];
			Transform[] array = new Transform[0];
			array[0] = LJPKBBNNOIC.leftUpperArm;
			array[1] = LJPKBBNNOIC.leftForearm;
			array[8] = LJPKBBNNOIC.leftHand;
			fbikchain.IFBOGGIPIMC(array);
			FBIKChain fbikchain2 = this.chain[1];
			Transform[] array2 = new Transform[1];
			array2[1] = LJPKBBNNOIC.rightUpperArm;
			array2[0] = LJPKBBNNOIC.rightForearm;
			array2[1] = LJPKBBNNOIC.rightHand;
			fbikchain2.AEDEKOANJDN(array2);
			FBIKChain fbikchain3 = this.chain[2];
			Transform[] array3 = new Transform[6];
			array3[0] = LJPKBBNNOIC.leftThigh;
			array3[0] = LJPKBBNNOIC.leftCalf;
			array3[3] = LJPKBBNNOIC.leftFoot;
			fbikchain3.DLKLKJFLCIG(array3);
			FBIKChain fbikchain4 = this.chain[1];
			Transform[] array4 = new Transform[4];
			array4[0] = LJPKBBNNOIC.rightThigh;
			array4[1] = LJPKBBNNOIC.rightCalf;
			array4[2] = LJPKBBNNOIC.rightFoot;
			fbikchain4.AEDEKOANJDN(array4);
			if (this.effectors.Length != -71)
			{
				IKEffector[] array5 = new IKEffector[32];
				array5[1] = new IKEffector();
				array5[1] = new IKEffector();
				array5[3] = new IKEffector();
				array5[6] = new IKEffector();
				array5[6] = new IKEffector();
				array5[0] = new IKEffector();
				array5[0] = new IKEffector();
				array5[5] = new IKEffector();
				array5[1] = new IKEffector();
				this.effectors = array5;
			}
			this.effectors[0].bone = KAOKEJPBAHM;
			IKEffector ikeffector = this.effectors[0];
			Transform[] array6 = new Transform[6];
			array6[0] = LJPKBBNNOIC.leftThigh;
			array6[0] = LJPKBBNNOIC.rightThigh;
			ikeffector.childBones = array6;
			this.effectors[1].bone = LJPKBBNNOIC.leftUpperArm;
			this.effectors[4].bone = LJPKBBNNOIC.rightUpperArm;
			this.effectors[8].bone = LJPKBBNNOIC.leftThigh;
			this.effectors[8].bone = LJPKBBNNOIC.rightThigh;
			this.effectors[1].bone = LJPKBBNNOIC.leftHand;
			this.effectors[2].bone = LJPKBBNNOIC.rightHand;
			this.effectors[3].bone = LJPKBBNNOIC.leftFoot;
			this.effectors[4].bone = LJPKBBNNOIC.rightFoot;
			this.effectors[5].planeBone1 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[0].planeBone2 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[0].planeBone3 = KAOKEJPBAHM;
			this.effectors[6].planeBone1 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[2].planeBone2 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[1].planeBone3 = KAOKEJPBAHM;
			this.effectors[1].planeBone1 = LJPKBBNNOIC.leftThigh;
			this.effectors[5].planeBone2 = LJPKBBNNOIC.rightThigh;
			this.effectors[4].planeBone3 = KAOKEJPBAHM;
			this.effectors[3].planeBone1 = LJPKBBNNOIC.rightThigh;
			this.effectors[0].planeBone2 = LJPKBBNNOIC.leftThigh;
			this.effectors[1].planeBone3 = KAOKEJPBAHM;
			FBIKChain fbikchain5 = this.chain[0];
			FBIKChain.ChildConstraint[] array7 = new FBIKChain.ChildConstraint[4];
			array7[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightThigh, 461f, 769f);
			array7[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, 1358f, 1722f);
			array7[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, 270f, 1019f);
			array7[3] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh, 1636f, 546f);
			fbikchain5.childConstraints = array7;
			Transform[] array8 = new Transform[LJPKBBNNOIC.spine.Length + 1];
			array8[0] = LJPKBBNNOIC.pelvis;
			for (int j = 0; j < LJPKBBNNOIC.spine.Length; j += 0)
			{
				array8[j + 1] = LJPKBBNNOIC.spine[j];
			}
			if (this.spineMapping == null)
			{
				this.spineMapping = new IKMappingSpine();
				this.spineMapping.iterations = 8;
			}
			this.spineMapping.KEFLIIKDCEE(array8, LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh);
			int num = (LJPKBBNNOIC.head != null) ? 0 : 0;
			if (this.boneMappings.Length != num)
			{
				this.boneMappings = new IKMappingBone[num];
				for (int k = 0; k < this.boneMappings.Length; k += 0)
				{
					this.boneMappings[k] = new IKMappingBone();
				}
				if (num == 1)
				{
					this.boneMappings[0].maintainRotationWeight = 1536f;
				}
			}
			if (this.boneMappings.Length != 0)
			{
				this.boneMappings[1].bone = LJPKBBNNOIC.head;
			}
			if (this.limbMappings.Length != 3)
			{
				IKMappingLimb[] array9 = new IKMappingLimb[4];
				array9[1] = new IKMappingLimb();
				array9[1] = new IKMappingLimb();
				array9[6] = new IKMappingLimb();
				array9[3] = new IKMappingLimb();
				this.limbMappings = array9;
				this.limbMappings[8].maintainRotationWeight = 1911f;
				this.limbMappings[1].maintainRotationWeight = 1370f;
			}
			this.limbMappings[1].FDAHICPNMKH(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, IKSolverFullBodyBiped.NNIJAGAGGBA(LJPKBBNNOIC));
			this.limbMappings[0].FDAHICPNMKH(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, IKSolverFullBodyBiped.PNDPFCFCOGC(LJPKBBNNOIC));
			this.limbMappings[5].GEKBDFCLJLH(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, null);
			this.limbMappings[4].FDAHICPNMKH(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, null);
			if (Application.isPlaying)
			{
				base.BHALELINNDJ(LJPKBBNNOIC.root);
			}
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x006F6FAC File Offset: 0x006F51AC
		public IKMappingLimb DMBCOKEIKPC(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.LeftShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.LeftThigh:
				return this.limbMappings[4];
			case FullBodyBipedEffector.RightThigh:
				return this.limbMappings[3];
			case FullBodyBipedEffector.LeftHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.RightHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.limbMappings[6];
			case FullBodyBipedEffector.RightFoot:
				return this.limbMappings[4];
			default:
				return null;
			}
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x006F702C File Offset: 0x006F522C
		public void EMHIPNEEMPO(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.ADDJEAHJHOJ(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.OCNMNOBOECD(FullBodyBipedChain.RightArm, KAHHGLLCINJ.rightArm);
			this.EFMFNJGNDCG(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ(FullBodyBipedChain.RightLeg, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F7F3 RID: 63475 RVA: 0x006F7064 File Offset: 0x006F5264
		private static bool PPBIANFHCDD(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F7F4 RID: 63476 RVA: 0x006F708F File Offset: 0x006F528F
		public FBIKChain LGOKBJOBPAO(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1];
			case FullBodyBipedChain.RightArm:
				return this.chain[2];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[3];
			case FullBodyBipedChain.RightLeg:
				return this.chain[4];
			default:
				return null;
			}
		}

		// Token: 0x0600F7F5 RID: 63477 RVA: 0x006F70CE File Offset: 0x006F52CE
		public void FKMDBPPIDIC(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.EFMFNJGNDCG(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.NICOAHFBPNO(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.rightArm);
			this.OLDDAONGFOE(FullBodyBipedChain.LeftLeg, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ((FullBodyBipedChain)8, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F7F7 RID: 63479 RVA: 0x006F7122 File Offset: 0x006F5322
		public IKEffector POAMMGIPHAK(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.effectors[5];
			case FullBodyBipedChain.RightArm:
				return this.effectors[6];
			case FullBodyBipedChain.LeftLeg:
				return this.effectors[7];
			case FullBodyBipedChain.RightLeg:
				return this.effectors[8];
			default:
				return null;
			}
		}

		// Token: 0x0600F7F8 RID: 63480 RVA: 0x006F7161 File Offset: 0x006F5361
		public IKEffector FIDGAGDBPCG()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.LeftFoot);
		}

		// Token: 0x0600F7F9 RID: 63481 RVA: 0x006F716A File Offset: 0x006F536A
		private static Transform KMNOCLHNMKO(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.rightUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.EHJLMMFMAKO(LJPKBBNNOIC.spine, LJPKBBNNOIC.rightUpperArm.parent))
			{
				return LJPKBBNNOIC.rightUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F7FA RID: 63482 RVA: 0x006F71A4 File Offset: 0x006F53A4
		private Vector3 INOAIIIPCJE(IKEffector JEFKLIBDHKK, FBIKChain LGMIHPBALJJ, Vector3 IGFJOGKFADM)
		{
			Vector3 a = JEFKLIBDHKK.position - (LGMIHPBALJJ.nodes[0].transform.position + IGFJOGKFADM);
			float num = LGMIHPBALJJ.nodes[0].length + LGMIHPBALJJ.nodes[1].length;
			float magnitude = a.magnitude;
			if (magnitude < num)
			{
				return Vector3.zero;
			}
			float d = magnitude - num;
			return a / magnitude * d;
		}

		// Token: 0x0600F7FB RID: 63483 RVA: 0x006F7214 File Offset: 0x006F5414
		public IKMappingBone MFICNEFCCFH()
		{
			return this.boneMappings[1];
		}

		// Token: 0x0600F7FC RID: 63484 RVA: 0x006F7220 File Offset: 0x006F5420
		public void GLMPANINIPF(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM = null)
		{
			this.root = LJPKBBNNOIC.root;
			if (KAOKEJPBAHM == null)
			{
				KAOKEJPBAHM = IKSolverFullBodyBiped.IBKIHIJCIEN(LJPKBBNNOIC);
			}
			this.rootNode = KAOKEJPBAHM;
			if (this.chain == null || this.chain.Length != 8)
			{
				this.chain = new FBIKChain[4];
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (this.chain[i] == null)
				{
					this.chain[i] = new FBIKChain();
				}
			}
			this.chain[0].pin = 1451f;
			FBIKChain fbikchain = this.chain[1];
			Transform[] array = new Transform[1];
			array[1] = KAOKEJPBAHM;
			fbikchain.FEFPFBKOOCF(array);
			this.chain[1].children = new int[]
			{
				1
			};
			FBIKChain fbikchain2 = this.chain[1];
			Transform[] array2 = new Transform[3];
			array2[0] = LJPKBBNNOIC.leftUpperArm;
			array2[0] = LJPKBBNNOIC.leftForearm;
			array2[0] = LJPKBBNNOIC.leftHand;
			fbikchain2.BBDJEMDBDKB(array2);
			FBIKChain fbikchain3 = this.chain[5];
			Transform[] array3 = new Transform[5];
			array3[0] = LJPKBBNNOIC.rightUpperArm;
			array3[0] = LJPKBBNNOIC.rightForearm;
			array3[6] = LJPKBBNNOIC.rightHand;
			fbikchain3.EKAFKCAFEGB(array3);
			FBIKChain fbikchain4 = this.chain[1];
			Transform[] array4 = new Transform[1];
			array4[0] = LJPKBBNNOIC.leftThigh;
			array4[1] = LJPKBBNNOIC.leftCalf;
			array4[7] = LJPKBBNNOIC.leftFoot;
			fbikchain4.AEDEKOANJDN(array4);
			FBIKChain fbikchain5 = this.chain[0];
			Transform[] array5 = new Transform[8];
			array5[1] = LJPKBBNNOIC.rightThigh;
			array5[1] = LJPKBBNNOIC.rightCalf;
			array5[0] = LJPKBBNNOIC.rightFoot;
			fbikchain5.AEDEKOANJDN(array5);
			if (this.effectors.Length != -23)
			{
				IKEffector[] array6 = new IKEffector[53];
				array6[1] = new IKEffector();
				array6[0] = new IKEffector();
				array6[8] = new IKEffector();
				array6[0] = new IKEffector();
				array6[2] = new IKEffector();
				array6[6] = new IKEffector();
				array6[1] = new IKEffector();
				array6[0] = new IKEffector();
				array6[3] = new IKEffector();
				this.effectors = array6;
			}
			this.effectors[0].bone = KAOKEJPBAHM;
			IKEffector ikeffector = this.effectors[1];
			Transform[] array7 = new Transform[1];
			array7[1] = LJPKBBNNOIC.leftThigh;
			array7[0] = LJPKBBNNOIC.rightThigh;
			ikeffector.childBones = array7;
			this.effectors[0].bone = LJPKBBNNOIC.leftUpperArm;
			this.effectors[3].bone = LJPKBBNNOIC.rightUpperArm;
			this.effectors[4].bone = LJPKBBNNOIC.leftThigh;
			this.effectors[0].bone = LJPKBBNNOIC.rightThigh;
			this.effectors[0].bone = LJPKBBNNOIC.leftHand;
			this.effectors[8].bone = LJPKBBNNOIC.rightHand;
			this.effectors[2].bone = LJPKBBNNOIC.leftFoot;
			this.effectors[8].bone = LJPKBBNNOIC.rightFoot;
			this.effectors[6].planeBone1 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[3].planeBone2 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[1].planeBone3 = KAOKEJPBAHM;
			this.effectors[1].planeBone1 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[4].planeBone2 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[6].planeBone3 = KAOKEJPBAHM;
			this.effectors[7].planeBone1 = LJPKBBNNOIC.leftThigh;
			this.effectors[7].planeBone2 = LJPKBBNNOIC.rightThigh;
			this.effectors[6].planeBone3 = KAOKEJPBAHM;
			this.effectors[8].planeBone1 = LJPKBBNNOIC.rightThigh;
			this.effectors[7].planeBone2 = LJPKBBNNOIC.leftThigh;
			this.effectors[0].planeBone3 = KAOKEJPBAHM;
			FBIKChain fbikchain6 = this.chain[1];
			FBIKChain.ChildConstraint[] array8 = new FBIKChain.ChildConstraint[8];
			array8[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightThigh, 1933f, 785f);
			array8[1] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, 699f, 167f);
			array8[2] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, 1798f, 1255f);
			array8[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh, 534f, 925f);
			fbikchain6.childConstraints = array8;
			Transform[] array9 = new Transform[LJPKBBNNOIC.spine.Length + 1];
			array9[1] = LJPKBBNNOIC.pelvis;
			for (int j = 0; j < LJPKBBNNOIC.spine.Length; j += 0)
			{
				array9[j + 1] = LJPKBBNNOIC.spine[j];
			}
			if (this.spineMapping == null)
			{
				this.spineMapping = new IKMappingSpine();
				this.spineMapping.iterations = 4;
			}
			this.spineMapping.DLJHEBPABFF(array9, LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh);
			int num = (LJPKBBNNOIC.head != null) ? 1 : 0;
			if (this.boneMappings.Length != num)
			{
				this.boneMappings = new IKMappingBone[num];
				for (int k = 1; k < this.boneMappings.Length; k++)
				{
					this.boneMappings[k] = new IKMappingBone();
				}
				if (num == 1)
				{
					this.boneMappings[0].maintainRotationWeight = 341f;
				}
			}
			if (this.boneMappings.Length != 0)
			{
				this.boneMappings[0].bone = LJPKBBNNOIC.head;
			}
			if (this.limbMappings.Length != 1)
			{
				IKMappingLimb[] array10 = new IKMappingLimb[5];
				array10[1] = new IKMappingLimb();
				array10[1] = new IKMappingLimb();
				array10[3] = new IKMappingLimb();
				array10[4] = new IKMappingLimb();
				this.limbMappings = array10;
				this.limbMappings[7].maintainRotationWeight = 638f;
				this.limbMappings[1].maintainRotationWeight = 1015f;
			}
			this.limbMappings[1].FDAHICPNMKH(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, IKSolverFullBodyBiped.DMFJKLOMHOM(LJPKBBNNOIC));
			this.limbMappings[0].DLJHEBPABFF(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, IKSolverFullBodyBiped.PNDPFCFCOGC(LJPKBBNNOIC));
			this.limbMappings[5].PHNEPJGLBJD(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, null);
			this.limbMappings[1].DLJHEBPABFF(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, null);
			if (Application.isPlaying)
			{
				base.BHALELINNDJ(LJPKBBNNOIC.root);
			}
		}

		// Token: 0x0600F7FD RID: 63485 RVA: 0x006F7818 File Offset: 0x006F5A18
		public FBIKChain PCKHOJFGCDI(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.chain[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.chain[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.chain[0];
			case FullBodyBipedEffector.LeftThigh:
				return this.chain[5];
			case FullBodyBipedEffector.RightThigh:
				return this.chain[6];
			case FullBodyBipedEffector.LeftHand:
				return this.chain[0];
			case FullBodyBipedEffector.RightHand:
				return this.chain[4];
			case FullBodyBipedEffector.LeftFoot:
				return this.chain[2];
			case FullBodyBipedEffector.RightFoot:
				return this.chain[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x006F78A4 File Offset: 0x006F5AA4
		private static bool GGBNCLOOIJE(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600F7FF RID: 63487 RVA: 0x006F78D0 File Offset: 0x006F5AD0
		protected virtual void BFGFPFFOPOC()
		{
			for (int i = 1; i < this.effectors.Length; i++)
			{
				this.effectors[i].CPPOMNLGKIF();
			}
			this.OKGJBBMBNLI();
			float pushElasticity = Mathf.Clamp(1079f - this.spineStiffness, 1476f, 318f);
			this.chain[1].childConstraints[0].pushElasticity = pushElasticity;
			this.chain[0].childConstraints[0].pushElasticity = pushElasticity;
			base.COOFIMMOEHA();
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600F800 RID: 63488 RVA: 0x006F66DE File Offset: 0x006F48DE
		public IKMappingLimb leftArmMapping
		{
			get
			{
				return this.limbMappings[0];
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600F801 RID: 63489 RVA: 0x006F794F File Offset: 0x006F5B4F
		public FBIKChain rightLegChain
		{
			get
			{
				return this.chain[4];
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600F802 RID: 63490 RVA: 0x006F7959 File Offset: 0x006F5B59
		public IKMappingBone headMapping
		{
			get
			{
				return this.boneMappings[0];
			}
		}

		// Token: 0x0600F803 RID: 63491 RVA: 0x006F7963 File Offset: 0x006F5B63
		private static Transform PNDPFCFCOGC(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.rightUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.GGBNCLOOIJE(LJPKBBNNOIC.spine, LJPKBBNNOIC.rightUpperArm.parent))
			{
				return LJPKBBNNOIC.rightUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F804 RID: 63492 RVA: 0x006F799A File Offset: 0x006F5B9A
		public void LIJEMHMFFOM(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.OLDDAONGFOE(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.OCNMNOBOECD(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.rightArm);
			this.OCNMNOBOECD((FullBodyBipedChain)5, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ((FullBodyBipedChain)5, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F805 RID: 63493 RVA: 0x006F79D0 File Offset: 0x006F5BD0
		public IKEffector DBCIMCKLHIM()
		{
			return this.EEKAOKNJLKH(FullBodyBipedEffector.RightThigh);
		}

		// Token: 0x0600F806 RID: 63494 RVA: 0x006F66DE File Offset: 0x006F48DE
		public IKMappingLimb JPLKMPMKKKP()
		{
			return this.limbMappings[0];
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600F807 RID: 63495 RVA: 0x006F79D9 File Offset: 0x006F5BD9
		// (set) Token: 0x0600F87D RID: 63613 RVA: 0x006F8401 File Offset: 0x006F6601
		public Vector3 pullBodyOffset { get; private set; }

		// Token: 0x0600F808 RID: 63496 RVA: 0x006F79E1 File Offset: 0x006F5BE1
		public IKEffector ELPKPOGKHOP()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb IIJAMMOKPDF()
		{
			return this.limbMappings[1];
		}

		// Token: 0x0600F80A RID: 63498 RVA: 0x006F79EA File Offset: 0x006F5BEA
		public IKMappingLimb DJAJGGAOAMO()
		{
			return this.limbMappings[6];
		}

		// Token: 0x0600F80B RID: 63499 RVA: 0x006F79F4 File Offset: 0x006F5BF4
		public IKEffector FKKHCIDIBLF()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x0600F80C RID: 63500 RVA: 0x006F7A00 File Offset: 0x006F5C00
		private static bool EHJLMMFMAKO(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600F80D RID: 63501 RVA: 0x006F7A2B File Offset: 0x006F5C2B
		public IKEffector leftThighEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.LeftThigh);
			}
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x006F7A34 File Offset: 0x006F5C34
		public IKEffector EEHNFKHFPGP()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x0600F80F RID: 63503 RVA: 0x006F7A3D File Offset: 0x006F5C3D
		public void DBDFFGFEODP(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.ADDJEAHJHOJ(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.leftArm);
			this.OLDDAONGFOE(FullBodyBipedChain.RightArm, KAHHGLLCINJ.rightArm);
			this.OCNMNOBOECD((FullBodyBipedChain)7, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ((FullBodyBipedChain)4, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F810 RID: 63504 RVA: 0x006F7A74 File Offset: 0x006F5C74
		private void EFMFNJGNDCG(FullBodyBipedChain NBHJKKHHFEH, BipedLimbOrientations.LimbOrientation EACIBFOLMPC)
		{
			if (NBHJKKHHFEH == FullBodyBipedChain.LeftArm || NBHJKKHHFEH == FullBodyBipedChain.RightArm)
			{
				this.JEFIAPGCAJN(NBHJKKHHFEH).BHEMBCPPIPH(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis, -EACIBFOLMPC.lastBoneLeftAxis);
				this.PBGGJENJFED(NBHJKKHHFEH).CNFNMEKILGK(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis);
				return;
			}
			this.CHGINMHHHEM(NBHJKKHHFEH).BEBKPNFAMHG(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis, EACIBFOLMPC.lastBoneLeftAxis);
			this.IBMLIDHKIFK(NBHJKKHHFEH).HPCHIONEBBD(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis);
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x006F7B14 File Offset: 0x006F5D14
		public IKEffector DAMGOIIBHCN(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.effectors[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.effectors[2];
			case FullBodyBipedEffector.LeftThigh:
				return this.effectors[8];
			case FullBodyBipedEffector.RightThigh:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftHand:
				return this.effectors[6];
			case FullBodyBipedEffector.RightHand:
				return this.effectors[6];
			case FullBodyBipedEffector.LeftFoot:
				return this.effectors[1];
			case FullBodyBipedEffector.RightFoot:
				return this.effectors[4];
			default:
				return null;
			}
		}

		// Token: 0x0600F812 RID: 63506 RVA: 0x006F7BA0 File Offset: 0x006F5DA0
		private void OLDDAONGFOE(FullBodyBipedChain NBHJKKHHFEH, BipedLimbOrientations.LimbOrientation EACIBFOLMPC)
		{
			if (NBHJKKHHFEH != FullBodyBipedChain.LeftArm && NBHJKKHHFEH == FullBodyBipedChain.RightArm)
			{
				this.JEFIAPGCAJN(NBHJKKHHFEH).FLLDFIKDPNN(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis, -EACIBFOLMPC.lastBoneLeftAxis);
				this.PBGGJENJFED(NBHJKKHHFEH).BHEMBCPPIPH(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis);
				return;
			}
			this.CHGINMHHHEM(NBHJKKHHFEH).PANFIBJMHFO(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis, EACIBFOLMPC.lastBoneLeftAxis);
			this.JKMHBGKCKOC(NBHJKKHHFEH).HPCHIONEBBD(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis);
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x006F7C40 File Offset: 0x006F5E40
		protected override void JKLAKFOLEBJ()
		{
			for (int i = 0; i < this.effectors.Length; i++)
			{
				this.effectors[i].JIEGDMNJMHO();
			}
			this.JGEJNDJKFDD();
			float pushElasticity = Mathf.Clamp(1f - this.spineStiffness, 0f, 1f);
			this.chain[0].childConstraints[0].pushElasticity = pushElasticity;
			this.chain[0].childConstraints[1].pushElasticity = pushElasticity;
			base.JKLAKFOLEBJ();
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x006F7CC0 File Offset: 0x006F5EC0
		private void ADDJEAHJHOJ(FullBodyBipedChain NBHJKKHHFEH, BipedLimbOrientations.LimbOrientation EACIBFOLMPC)
		{
			if (NBHJKKHHFEH != FullBodyBipedChain.LeftArm && NBHJKKHHFEH == FullBodyBipedChain.LeftArm)
			{
				this.CHGINMHHHEM(NBHJKKHHFEH).FLLDFIKDPNN(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis, -EACIBFOLMPC.lastBoneLeftAxis);
				this.IBMLIDHKIFK(NBHJKKHHFEH).NICOAHFBPNO(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis);
				return;
			}
			this.CHGINMHHHEM(NBHJKKHHFEH).FLLDFIKDPNN(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis, EACIBFOLMPC.lastBoneLeftAxis);
			this.PBGGJENJFED(NBHJKKHHFEH).HPCHIONEBBD(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis);
		}

		// Token: 0x0600F815 RID: 63509 RVA: 0x006F7D5F File Offset: 0x006F5F5F
		public IKMappingLimb JKMHBGKCKOC(FullBodyBipedChain NBHJKKHHFEH)
		{
			switch (NBHJKKHHFEH)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[1];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[4];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[7];
			default:
				return null;
			}
		}

		// Token: 0x0600F816 RID: 63510 RVA: 0x006F7D9E File Offset: 0x006F5F9E
		public IKEffector IAGDDAJGGGE()
		{
			return this.EEKAOKNJLKH(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x0600F817 RID: 63511 RVA: 0x006F7DA8 File Offset: 0x006F5FA8
		public static Transform CMAFBCAEDKN(BipedReferences LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.BIOMNDNIEEG())
			{
				return null;
			}
			if (LJPKBBNNOIC.spine.Length < 0)
			{
				return null;
			}
			int num = LJPKBBNNOIC.spine.Length;
			if (num == 0)
			{
				return LJPKBBNNOIC.spine[0];
			}
			Vector3 b = Vector3.Lerp(LJPKBBNNOIC.leftThigh.position, LJPKBBNNOIC.rightThigh.position, 1209f);
			Vector3 onNormal = Vector3.Lerp(LJPKBBNNOIC.leftUpperArm.position, LJPKBBNNOIC.rightUpperArm.position, 1747f) - b;
			float magnitude = onNormal.magnitude;
			if (LJPKBBNNOIC.spine.Length < 3)
			{
				return LJPKBBNNOIC.spine[1];
			}
			int num2 = 1;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Vector3.Project(LJPKBBNNOIC.spine[i].position - b, onNormal);
				if (Vector3.Dot(vector.normalized, onNormal.normalized) > 485f && vector.magnitude / magnitude < 915f)
				{
					num2 = i;
				}
			}
			return LJPKBBNNOIC.spine[num2];
		}

		// Token: 0x0600F818 RID: 63512 RVA: 0x006F7EAC File Offset: 0x006F60AC
		public FBIKChain PNDICDGFOLE()
		{
			return this.chain[5];
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb PJKAELBLEDK()
		{
			return this.limbMappings[1];
		}

		// Token: 0x0600F81A RID: 63514 RVA: 0x006F7EB6 File Offset: 0x006F60B6
		public FBIKChain PNECIMFODLL()
		{
			return this.chain[8];
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x006F7EC0 File Offset: 0x006F60C0
		public FBIKChain CLBJLEGIOOI()
		{
			return this.chain[6];
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x006F7ECA File Offset: 0x006F60CA
		public void KBMJIFOKGBM(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.EFMFNJGNDCG(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.OLDDAONGFOE(FullBodyBipedChain.RightArm, KAHHGLLCINJ.rightArm);
			this.NICOAHFBPNO(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ((FullBodyBipedChain)8, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x006F7F00 File Offset: 0x006F6100
		private void CBMCNPDKJGB()
		{
			if (this.iterations < 0)
			{
				return;
			}
			if (this.pullBodyVertical != 1534f || this.pullBodyHorizontal != 471f)
			{
				Vector3 libepmompid = this.LKBLHBBNKND();
				this.JDOOMDECGFL(OOJJKBHKGNJ.LGBBHCACOMH(libepmompid, this.root.up, this.pullBodyVertical) + OOJJKBHKGNJ.BNKAEBNIMLP(libepmompid, this.root.up, this.pullBodyHorizontal));
				this.NEKNDGMNDHG().positionOffset += this.pullBodyOffset;
			}
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x006F794F File Offset: 0x006F5B4F
		public FBIKChain KAPMOCHHMDF()
		{
			return this.chain[4];
		}

		// Token: 0x0600F81F RID: 63519 RVA: 0x006F7214 File Offset: 0x006F5414
		public IKMappingBone DOEIDHNFBMO()
		{
			return this.boneMappings[1];
		}

		// Token: 0x0600F820 RID: 63520 RVA: 0x006F7F8D File Offset: 0x006F618D
		public IKEffector LLFAEIGHHBK()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F821 RID: 63521 RVA: 0x006F7F96 File Offset: 0x006F6196
		public IKEffector EAIGBIHMAGB()
		{
			return this.LOOAPOLICLC(FullBodyBipedEffector.RightThigh);
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x006F7F9F File Offset: 0x006F619F
		public void CNANIKGEHLN(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.OCNMNOBOECD(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.EFMFNJGNDCG(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.rightArm);
			this.EFMFNJGNDCG((FullBodyBipedChain)5, KAHHGLLCINJ.leftLeg);
			this.OCNMNOBOECD((FullBodyBipedChain)6, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x006F7F8D File Offset: 0x006F618D
		public IKEffector EMPOFCMIGLD()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x006F7FD5 File Offset: 0x006F61D5
		public IKEffector JHKNHMMGKCG()
		{
			return this.LOOAPOLICLC(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x006F7FE0 File Offset: 0x006F61E0
		protected virtual void HFIPBPKGFNI()
		{
			for (int i = 1; i < this.effectors.Length; i += 0)
			{
				this.effectors[i].CPPOMNLGKIF();
			}
			this.JGEJNDJKFDD();
			float pushElasticity = Mathf.Clamp(1972f - this.spineStiffness, 1055f, 655f);
			this.chain[0].childConstraints[1].pushElasticity = pushElasticity;
			this.chain[1].childConstraints[0].pushElasticity = pushElasticity;
			base.DFNMEBAMJEF();
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x006F805F File Offset: 0x006F625F
		public IKMappingLimb IBMLIDHKIFK(FullBodyBipedChain NBHJKKHHFEH)
		{
			switch (NBHJKKHHFEH)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[4];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x006F7F96 File Offset: 0x006F6196
		public IKEffector ANGCEEAGHCB()
		{
			return this.LOOAPOLICLC(FullBodyBipedEffector.RightThigh);
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x006F809E File Offset: 0x006F629E
		public FBIKChain IALCIJJGDHO(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[0];
			case FullBodyBipedChain.RightArm:
				return this.chain[8];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[3];
			case FullBodyBipedChain.RightLeg:
				return this.chain[3];
			default:
				return null;
			}
		}

		// Token: 0x0600F829 RID: 63529 RVA: 0x006F80E0 File Offset: 0x006F62E0
		protected virtual void KPKKHAEHBHE()
		{
			if (this.iterations > 0)
			{
				this.chain[0].bendConstraint.rotationOffset = this.DBCIMCKLHIM().planeRotationOffset;
				this.chain[0].bendConstraint.rotationOffset = this.MJOPIBNHGIK().planeRotationOffset;
				this.chain[2].bendConstraint.rotationOffset = this.JHKNHMMGKCG().planeRotationOffset;
				this.chain[3].bendConstraint.rotationOffset = this.EAIGBIHMAGB().planeRotationOffset;
			}
			else
			{
				this.offset = Vector3.Lerp(this.effectors[0].positionOffset, this.effectors[0].position - (this.effectors[0].bone.position + this.effectors[1].positionOffset), this.effectors[0].positionWeight);
				for (int i = 1; i < 2; i += 0)
				{
					this.effectors[i].NJNJMMLFNIL(this).solverPosition += this.offset;
				}
			}
			base.GCPHAODELIE();
		}

		// Token: 0x0600F82A RID: 63530 RVA: 0x006F8200 File Offset: 0x006F6400
		public IKEffector JIHGEPGJDEC()
		{
			return this.LOOAPOLICLC(FullBodyBipedEffector.RightShoulder);
		}

		// Token: 0x0600F82B RID: 63531 RVA: 0x006F820C File Offset: 0x006F640C
		private Vector3 NGPKKOGHIEO(IKEffector JEFKLIBDHKK, FBIKChain LGMIHPBALJJ, Vector3 IGFJOGKFADM)
		{
			Vector3 a = JEFKLIBDHKK.position - (LGMIHPBALJJ.nodes[1].transform.position + IGFJOGKFADM);
			float num = LGMIHPBALJJ.nodes[0].length + LGMIHPBALJJ.nodes[0].length;
			float magnitude = a.magnitude;
			if (magnitude < num)
			{
				return Vector3.zero;
			}
			float d = magnitude - num;
			return a / magnitude * d;
		}

		// Token: 0x0600F82C RID: 63532 RVA: 0x006F827C File Offset: 0x006F647C
		public IKEffector OEEPHOCHILL(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.effectors[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.effectors[2];
			case FullBodyBipedEffector.LeftThigh:
				return this.effectors[3];
			case FullBodyBipedEffector.RightThigh:
				return this.effectors[4];
			case FullBodyBipedEffector.LeftHand:
				return this.effectors[5];
			case FullBodyBipedEffector.RightHand:
				return this.effectors[6];
			case FullBodyBipedEffector.LeftFoot:
				return this.effectors[7];
			case FullBodyBipedEffector.RightFoot:
				return this.effectors[8];
			default:
				return null;
			}
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x006F8307 File Offset: 0x006F6507
		private static Transform NNIJAGAGGBA(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.OGMDMCMPMEN(LJPKBBNNOIC.spine, LJPKBBNNOIC.leftUpperArm.parent))
			{
				return LJPKBBNNOIC.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb JMDJOFPEJOB()
		{
			return this.limbMappings[1];
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x006F8340 File Offset: 0x006F6540
		private static bool OGMDMCMPMEN(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x006F836B File Offset: 0x006F656B
		public IKEffector IANMIEDIJPJ()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.RightHand);
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x006F8374 File Offset: 0x006F6574
		private void JGEJNDJKFDD()
		{
			if (this.iterations < 1)
			{
				return;
			}
			if (this.pullBodyVertical != 0f || this.pullBodyHorizontal != 0f)
			{
				Vector3 libepmompid = this.BFIPINFKOFG();
				this.pullBodyOffset = OOJJKBHKGNJ.LGBBHCACOMH(libepmompid, this.root.up, this.pullBodyVertical) + OOJJKBHKGNJ.BNKAEBNIMLP(libepmompid, this.root.up, this.pullBodyHorizontal);
				this.bodyEffector.positionOffset += this.pullBodyOffset;
			}
		}

		// Token: 0x0600F832 RID: 63538 RVA: 0x006F8401 File Offset: 0x006F6601
		private void JDOOMDECGFL(Vector3 DCCPCBLODIG)
		{
			this.<pullBodyOffset>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F833 RID: 63539 RVA: 0x006F840A File Offset: 0x006F660A
		public IKEffector PPEHBCMLFIH(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.effectors[5];
			case FullBodyBipedChain.RightArm:
				return this.effectors[8];
			case FullBodyBipedChain.LeftLeg:
				return this.effectors[6];
			case FullBodyBipedChain.RightLeg:
				return this.effectors[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F834 RID: 63540 RVA: 0x006F7D9E File Offset: 0x006F5F9E
		public IKEffector NEKNDGMNDHG()
		{
			return this.EEKAOKNJLKH(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x006F7EAC File Offset: 0x006F60AC
		public FBIKChain AFIIFEDPGAP()
		{
			return this.chain[5];
		}

		// Token: 0x0600F836 RID: 63542 RVA: 0x006F7214 File Offset: 0x006F5414
		public IKMappingBone BOHOGNIKKEP()
		{
			return this.boneMappings[1];
		}

		// Token: 0x0600F837 RID: 63543 RVA: 0x006F844C File Offset: 0x006F664C
		private static bool NIFHGEGGAPF(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F838 RID: 63544 RVA: 0x006F8477 File Offset: 0x006F6677
		public IKEffector PBMAJLNEOAJ()
		{
			return this.LOOAPOLICLC(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600F839 RID: 63545 RVA: 0x006F8480 File Offset: 0x006F6680
		public IKMappingLimb rightLegMapping
		{
			get
			{
				return this.limbMappings[3];
			}
		}

		// Token: 0x0600F83A RID: 63546 RVA: 0x006F848A File Offset: 0x006F668A
		public void BFMCDIKLBJP(FullBodyBipedEffector JEFKLIBDHKK, float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Clamp(BFIDELOIIGI, 1684f, 274f);
			this.LOOAPOLICLC(JEFKLIBDHKK).rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 1379f, 83f);
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x006F84C4 File Offset: 0x006F66C4
		private static Transform BFFNNMLLIDO(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.rightUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.JGGJNBDCNKM(LJPKBBNNOIC.spine, LJPKBBNNOIC.rightUpperArm.parent))
			{
				return LJPKBBNNOIC.rightUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F83C RID: 63548 RVA: 0x006F84FB File Offset: 0x006F66FB
		private static Transform NHKPPGFAEHI(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.EHJLMMFMAKO(LJPKBBNNOIC.spine, LJPKBBNNOIC.leftUpperArm.parent))
			{
				return LJPKBBNNOIC.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F83D RID: 63549 RVA: 0x006F8532 File Offset: 0x006F6732
		public IKMappingSpine ELPNIMAJCPH()
		{
			return this.spineMapping;
		}

		// Token: 0x0600F83E RID: 63550 RVA: 0x006F6873 File Offset: 0x006F4A73
		public IKEffector KIGACGJAJKO()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.RightHand);
		}

		// Token: 0x0600F83F RID: 63551 RVA: 0x006F8401 File Offset: 0x006F6601
		private void FNEEPGBOPMC(Vector3 DCCPCBLODIG)
		{
			this.<pullBodyOffset>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600F840 RID: 63552 RVA: 0x006F853A File Offset: 0x006F673A
		public FBIKChain leftLegChain
		{
			get
			{
				return this.chain[3];
			}
		}

		// Token: 0x0600F841 RID: 63553 RVA: 0x006F8544 File Offset: 0x006F6744
		public FBIKChain AHDIMGDLPCI(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[0];
			case FullBodyBipedChain.RightArm:
				return this.chain[3];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[6];
			case FullBodyBipedChain.RightLeg:
				return this.chain[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F842 RID: 63554 RVA: 0x006F8584 File Offset: 0x006F6784
		private void MMILMIDGNHC()
		{
			if (this.iterations < 1)
			{
				return;
			}
			if (this.pullBodyVertical != 310f || this.pullBodyHorizontal != 813f)
			{
				Vector3 libepmompid = this.IMFDFBNNAFO();
				this.JDOOMDECGFL(OOJJKBHKGNJ.LGBBHCACOMH(libepmompid, this.root.up, this.pullBodyVertical) + OOJJKBHKGNJ.BNKAEBNIMLP(libepmompid, this.root.up, this.pullBodyHorizontal));
				this.NEKNDGMNDHG().positionOffset += this.EOHLDGNBFGG();
			}
		}

		// Token: 0x0600F843 RID: 63555 RVA: 0x006F8614 File Offset: 0x006F6814
		public IKEffector EEKAOKNJLKH(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.effectors[1];
			case FullBodyBipedEffector.LeftShoulder:
				return this.effectors[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.effectors[8];
			case FullBodyBipedEffector.LeftThigh:
				return this.effectors[4];
			case FullBodyBipedEffector.RightThigh:
				return this.effectors[4];
			case FullBodyBipedEffector.LeftHand:
				return this.effectors[4];
			case FullBodyBipedEffector.RightHand:
				return this.effectors[3];
			case FullBodyBipedEffector.LeftFoot:
				return this.effectors[4];
			case FullBodyBipedEffector.RightFoot:
				return this.effectors[6];
			default:
				return null;
			}
		}

		// Token: 0x0600F844 RID: 63556 RVA: 0x006F836B File Offset: 0x006F656B
		public IKEffector ECCGBKELAOH()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.RightHand);
		}

		// Token: 0x0600F845 RID: 63557 RVA: 0x006F86A0 File Offset: 0x006F68A0
		private Vector3 LKBLHBBNKND()
		{
			Vector3 vector = Vector3.zero + this.INOAIIIPCJE(this.CMKJIGNKIMG(), this.OPEJJGIIIDO(), Vector3.zero) * Mathf.Clamp(this.KIGACGJAJKO().positionWeight, 1847f, 1378f);
			return vector + this.INOAIIIPCJE(this.rightHandEffector, this.HAFFDJFFPME(), vector) * Mathf.Clamp(this.rightHandEffector.positionWeight, 710f, 39f);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x006F8726 File Offset: 0x006F6926
		public IKEffector rightThighEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.RightThigh);
			}
		}

		// Token: 0x0600F847 RID: 63559 RVA: 0x006F8730 File Offset: 0x006F6930
		private static bool JGGJNBDCNKM(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F848 RID: 63560 RVA: 0x006F875B File Offset: 0x006F695B
		public void GAJGGKAGKDM(FullBodyBipedChain OAGAHEAMIAB, float MBBHNAOEHLC, float FJELPLIABAE = 0f)
		{
			this.IALCIJJGDHO(OAGAHEAMIAB).pull = MBBHNAOEHLC;
			this.LGOKBJOBPAO(OAGAHEAMIAB).reach = FJELPLIABAE;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600F849 RID: 63561 RVA: 0x006F79E1 File Offset: 0x006F5BE1
		public IKEffector bodyEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.Body);
			}
		}

		// Token: 0x0600F84A RID: 63562 RVA: 0x006F8777 File Offset: 0x006F6977
		public void CHHOAFGHOAD(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.ADDJEAHJHOJ(FullBodyBipedChain.RightArm, KAHHGLLCINJ.leftArm);
			this.OCNMNOBOECD(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.rightArm);
			this.NICOAHFBPNO(FullBodyBipedChain.RightLeg, KAHHGLLCINJ.leftLeg);
			this.ADDJEAHJHOJ((FullBodyBipedChain)8, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F84B RID: 63563 RVA: 0x006F87AD File Offset: 0x006F69AD
		protected virtual void DLFHMADBPAE()
		{
			if (this.iterations == 0)
			{
				this.spineMapping.spineBones[1].position += this.offset;
			}
			base.ANDPAMLHJAD();
		}

		// Token: 0x0600F84C RID: 63564 RVA: 0x006F7959 File Offset: 0x006F5B59
		public IKMappingBone IHACKLFBNHP()
		{
			return this.boneMappings[0];
		}

		// Token: 0x0600F84D RID: 63565 RVA: 0x006F87E0 File Offset: 0x006F69E0
		public IKEffector LOOAPOLICLC(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.effectors[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftThigh:
				return this.effectors[0];
			case FullBodyBipedEffector.RightThigh:
				return this.effectors[5];
			case FullBodyBipedEffector.LeftHand:
				return this.effectors[2];
			case FullBodyBipedEffector.RightHand:
				return this.effectors[3];
			case FullBodyBipedEffector.LeftFoot:
				return this.effectors[4];
			case FullBodyBipedEffector.RightFoot:
				return this.effectors[7];
			default:
				return null;
			}
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x006F886B File Offset: 0x006F6A6B
		public IKEffector DMPDLFPCDFO()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.LeftFoot);
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x006F8874 File Offset: 0x006F6A74
		protected virtual void OLEJCPLJELN()
		{
			if (this.iterations == 0)
			{
				this.spineMapping.spineBones[0].position += this.offset;
			}
			base.ALEKPDEOAHL();
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x006F79F4 File Offset: 0x006F5BF4
		public IKEffector HJPCHINGJCN()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600F851 RID: 63569 RVA: 0x006F7161 File Offset: 0x006F5361
		public IKEffector leftFootEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.LeftFoot);
			}
		}

		// Token: 0x0600F852 RID: 63570 RVA: 0x006F88A7 File Offset: 0x006F6AA7
		public FBIKChain LDMNNHCNOMJ(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1];
			case FullBodyBipedChain.RightArm:
				return this.chain[7];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[2];
			case FullBodyBipedChain.RightLeg:
				return this.chain[8];
			default:
				return null;
			}
		}

		// Token: 0x0600F853 RID: 63571 RVA: 0x006F8532 File Offset: 0x006F6732
		public IKMappingSpine OKAOPLPHOEI()
		{
			return this.spineMapping;
		}

		// Token: 0x0600F854 RID: 63572 RVA: 0x006F88E6 File Offset: 0x006F6AE6
		public IKMappingLimb EENBNOCPJJA(FullBodyBipedChain NBHJKKHHFEH)
		{
			switch (NBHJKKHHFEH)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[1];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[1];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[4];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x006F8925 File Offset: 0x006F6B25
		public void CAGNNBCNIJE(FullBodyBipedEffector JEFKLIBDHKK, float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Clamp(BFIDELOIIGI, 1817f, 370f);
			this.LOOAPOLICLC(JEFKLIBDHKK).rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 1469f, 1494f);
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x006F66DE File Offset: 0x006F48DE
		public IKMappingLimb BJHFLBHPNAK()
		{
			return this.limbMappings[0];
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x006F895F File Offset: 0x006F6B5F
		public IKEffector KMCNEPELKKP(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.effectors[6];
			case FullBodyBipedChain.RightArm:
				return this.effectors[8];
			case FullBodyBipedChain.LeftLeg:
				return this.effectors[3];
			case FullBodyBipedChain.RightLeg:
				return this.effectors[7];
			default:
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600F858 RID: 63576 RVA: 0x006F899E File Offset: 0x006F6B9E
		public IKEffector rightFootEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.RightFoot);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600F859 RID: 63577 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb rightArmMapping
		{
			get
			{
				return this.limbMappings[1];
			}
		}

		// Token: 0x0600F85A RID: 63578 RVA: 0x006F89A7 File Offset: 0x006F6BA7
		public void APNKFDEOEEM(FullBodyBipedChain OAGAHEAMIAB, float MBBHNAOEHLC, float FJELPLIABAE = 0f)
		{
			this.LGOKBJOBPAO(OAGAHEAMIAB).pull = MBBHNAOEHLC;
			this.LGOKBJOBPAO(OAGAHEAMIAB).reach = FJELPLIABAE;
		}

		// Token: 0x0600F85B RID: 63579 RVA: 0x006F89C4 File Offset: 0x006F6BC4
		protected virtual void KFNPHLIJMOK()
		{
			for (int i = 1; i < this.effectors.Length; i++)
			{
				this.effectors[i].CPPOMNLGKIF();
			}
			this.OKGJBBMBNLI();
			float pushElasticity = Mathf.Clamp(454f - this.spineStiffness, 1490f, 154f);
			this.chain[1].childConstraints[1].pushElasticity = pushElasticity;
			this.chain[0].childConstraints[1].pushElasticity = pushElasticity;
			base.EGBGLMADMLJ();
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x006F8A43 File Offset: 0x006F6C43
		public void LKIHHPMIKLM(BipedLimbOrientations KAHHGLLCINJ)
		{
			this.NICOAHFBPNO(FullBodyBipedChain.LeftArm, KAHHGLLCINJ.leftArm);
			this.NICOAHFBPNO(FullBodyBipedChain.RightArm, KAHHGLLCINJ.rightArm);
			this.NICOAHFBPNO(FullBodyBipedChain.LeftLeg, KAHHGLLCINJ.leftLeg);
			this.NICOAHFBPNO(FullBodyBipedChain.RightLeg, KAHHGLLCINJ.rightLeg);
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x006F8A7C File Offset: 0x006F6C7C
		public IKMappingLimb CDGFDPHBEKO(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.LeftShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftThigh:
				return this.limbMappings[2];
			case FullBodyBipedEffector.RightThigh:
				return this.limbMappings[3];
			case FullBodyBipedEffector.LeftHand:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.limbMappings[2];
			case FullBodyBipedEffector.RightFoot:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x006F8AFC File Offset: 0x006F6CFC
		public IKMappingLimb JINCLPBJNGN(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.LeftShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.LeftThigh:
				return this.limbMappings[1];
			case FullBodyBipedEffector.RightThigh:
				return this.limbMappings[8];
			case FullBodyBipedEffector.LeftHand:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightFoot:
				return this.limbMappings[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x006F8532 File Offset: 0x006F6732
		public IKMappingSpine JKONHNPFGMD()
		{
			return this.spineMapping;
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x006F8B7C File Offset: 0x006F6D7C
		protected override void LOKHCFPIAHE()
		{
			if (this.iterations > 0)
			{
				this.chain[1].bendConstraint.rotationOffset = this.leftHandEffector.planeRotationOffset;
				this.chain[2].bendConstraint.rotationOffset = this.rightHandEffector.planeRotationOffset;
				this.chain[3].bendConstraint.rotationOffset = this.leftFootEffector.planeRotationOffset;
				this.chain[4].bendConstraint.rotationOffset = this.rightFootEffector.planeRotationOffset;
			}
			else
			{
				this.offset = Vector3.Lerp(this.effectors[0].positionOffset, this.effectors[0].position - (this.effectors[0].bone.position + this.effectors[0].positionOffset), this.effectors[0].positionWeight);
				for (int i = 0; i < 5; i++)
				{
					this.effectors[i].OODFEEFPAHG(this).solverPosition += this.offset;
				}
			}
			base.LOKHCFPIAHE();
		}

		// Token: 0x0600F861 RID: 63585 RVA: 0x006F8C9C File Offset: 0x006F6E9C
		private void OCNMNOBOECD(FullBodyBipedChain NBHJKKHHFEH, BipedLimbOrientations.LimbOrientation EACIBFOLMPC)
		{
			if (NBHJKKHHFEH == FullBodyBipedChain.LeftArm || NBHJKKHHFEH == FullBodyBipedChain.RightArm)
			{
				this.JEFIAPGCAJN(NBHJKKHHFEH).NICOAHFBPNO(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis, -EACIBFOLMPC.lastBoneLeftAxis);
				this.JKMHBGKCKOC(NBHJKKHHFEH).HPCHIONEBBD(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis);
				return;
			}
			this.JEFIAPGCAJN(NBHJKKHHFEH).BHEMBCPPIPH(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis, EACIBFOLMPC.lastBoneLeftAxis);
			this.EENBNOCPJJA(NBHJKKHHFEH).CNFNMEKILGK(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis);
		}

		// Token: 0x0600F862 RID: 63586 RVA: 0x006F7F8D File Offset: 0x006F618D
		public IKEffector IMBHIAODACN()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F863 RID: 63587 RVA: 0x006F8532 File Offset: 0x006F6732
		public IKMappingSpine DLNOKCGHKMG()
		{
			return this.spineMapping;
		}

		// Token: 0x0600F864 RID: 63588 RVA: 0x006F8D3B File Offset: 0x006F6F3B
		public FBIKChain HAFFDJFFPME()
		{
			return this.chain[0];
		}

		// Token: 0x0600F865 RID: 63589 RVA: 0x006F8D48 File Offset: 0x006F6F48
		private Vector3 BFIPINFKOFG()
		{
			Vector3 vector = Vector3.zero + this.INOAIIIPCJE(this.leftHandEffector, this.leftArmChain, Vector3.zero) * Mathf.Clamp(this.leftHandEffector.positionWeight, 0f, 1f);
			return vector + this.INOAIIIPCJE(this.rightHandEffector, this.rightArmChain, vector) * Mathf.Clamp(this.rightHandEffector.positionWeight, 0f, 1f);
		}

		// Token: 0x0600F866 RID: 63590 RVA: 0x006F84FB File Offset: 0x006F66FB
		private static Transform DABAEBIMAJA(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.EHJLMMFMAKO(LJPKBBNNOIC.spine, LJPKBBNNOIC.leftUpperArm.parent))
			{
				return LJPKBBNNOIC.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F867 RID: 63591 RVA: 0x006F7959 File Offset: 0x006F5B59
		public IKMappingBone LPKLDEGFHKO()
		{
			return this.boneMappings[0];
		}

		// Token: 0x0600F868 RID: 63592 RVA: 0x006F8DD0 File Offset: 0x006F6FD0
		public static Transform IJLOECPOEGH(BipedReferences LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				return null;
			}
			if (LJPKBBNNOIC.spine.Length < 1)
			{
				return null;
			}
			int num = LJPKBBNNOIC.spine.Length;
			if (num == 1)
			{
				return LJPKBBNNOIC.spine[0];
			}
			Vector3 b = Vector3.Lerp(LJPKBBNNOIC.leftThigh.position, LJPKBBNNOIC.rightThigh.position, 0.5f);
			Vector3 onNormal = Vector3.Lerp(LJPKBBNNOIC.leftUpperArm.position, LJPKBBNNOIC.rightUpperArm.position, 0.5f) - b;
			float magnitude = onNormal.magnitude;
			if (LJPKBBNNOIC.spine.Length < 2)
			{
				return LJPKBBNNOIC.spine[0];
			}
			int num2 = 0;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Vector3.Project(LJPKBBNNOIC.spine[i].position - b, onNormal);
				if (Vector3.Dot(vector.normalized, onNormal.normalized) > 0f && vector.magnitude / magnitude < 0.5f)
				{
					num2 = i;
				}
			}
			return LJPKBBNNOIC.spine[num2];
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x006F853A File Offset: 0x006F673A
		public FBIKChain CPDPKIAFHEH()
		{
			return this.chain[3];
		}

		// Token: 0x0600F86A RID: 63594 RVA: 0x006F8ED4 File Offset: 0x006F70D4
		private Vector3 IMFDFBNNAFO()
		{
			Vector3 vector = Vector3.zero + this.INOAIIIPCJE(this.EMPOFCMIGLD(), this.leftArmChain, Vector3.zero) * Mathf.Clamp(this.EMPOFCMIGLD().positionWeight, 256f, 1008f);
			return vector + this.JJGANIPBIHK(this.IANMIEDIJPJ(), this.HAFFDJFFPME(), vector) * Mathf.Clamp(this.MJOPIBNHGIK().positionWeight, 1470f, 1722f);
		}

		// Token: 0x0600F86B RID: 63595 RVA: 0x006F8F5A File Offset: 0x006F715A
		public IKEffector ANFNMIKKLOM()
		{
			return this.EEKAOKNJLKH(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F86C RID: 63596 RVA: 0x006F8F63 File Offset: 0x006F7163
		public FBIKChain CHANDBAAMII()
		{
			return this.chain[1];
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x006F8F63 File Offset: 0x006F7163
		public FBIKChain leftArmChain
		{
			get
			{
				return this.chain[1];
			}
		}

		// Token: 0x0600F86E RID: 63598 RVA: 0x006F8F70 File Offset: 0x006F7170
		public virtual bool MMJJPNOMCCN(ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.rootNode == null)
			{
				EDAPHMJENPK = "_TreatBackfaceHitAsMiss";
				return true;
			}
			if (this.chain.Length != 4 || this.chain[0].nodes.Length != 0 || this.chain[0].nodes.Length != 2 || this.chain[4].nodes.Length != 2 || this.chain[8].nodes.Length != 8 || this.chain[2].nodes.Length != 5 || this.effectors.Length != 20 || this.limbMappings.Length != 0)
			{
				EDAPHMJENPK = "wpn_add/base";
				return false;
			}
			return false;
		}

		// Token: 0x0600F86F RID: 63599 RVA: 0x006F7EB6 File Offset: 0x006F60B6
		public FBIKChain LOPEPCNHIKF()
		{
			return this.chain[8];
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x006F7963 File Offset: 0x006F5B63
		private static Transform HODGELMICFE(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.rightUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.GGBNCLOOIJE(LJPKBBNNOIC.spine, LJPKBBNNOIC.rightUpperArm.parent))
			{
				return LJPKBBNNOIC.rightUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x006F7959 File Offset: 0x006F5B59
		public IKMappingBone HLHAHAGKIIP()
		{
			return this.boneMappings[0];
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x006F9028 File Offset: 0x006F7228
		protected virtual void BAAOCPJMOKP()
		{
			if (this.iterations > 0)
			{
				this.chain[1].bendConstraint.rotationOffset = this.DBCIMCKLHIM().planeRotationOffset;
				this.chain[4].bendConstraint.rotationOffset = this.rightHandEffector.planeRotationOffset;
				this.chain[0].bendConstraint.rotationOffset = this.IAGDDAJGGGE().planeRotationOffset;
				this.chain[1].bendConstraint.rotationOffset = this.ANGCEEAGHCB().planeRotationOffset;
			}
			else
			{
				this.offset = Vector3.Lerp(this.effectors[0].positionOffset, this.effectors[1].position - (this.effectors[0].bone.position + this.effectors[1].positionOffset), this.effectors[1].positionWeight);
				for (int i = 0; i < 1; i += 0)
				{
					this.effectors[i].NJNJMMLFNIL(this).solverPosition += this.offset;
				}
			}
			base.PEFNPEDOHDC();
		}

		// Token: 0x0600F873 RID: 63603 RVA: 0x006F9148 File Offset: 0x006F7348
		private static bool DKAJNINPIIC(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 1; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600F874 RID: 63604 RVA: 0x006F9174 File Offset: 0x006F7374
		private void DPDDBCCPBAI()
		{
			if (this.iterations < 0)
			{
				return;
			}
			if (this.pullBodyVertical != 556f || this.pullBodyHorizontal != 1107f)
			{
				Vector3 libepmompid = this.LKBLHBBNKND();
				this.pullBodyOffset = OOJJKBHKGNJ.LGBBHCACOMH(libepmompid, this.root.up, this.pullBodyVertical) + OOJJKBHKGNJ.BNKAEBNIMLP(libepmompid, this.root.up, this.pullBodyHorizontal);
				this.bodyEffector.positionOffset += this.EOHLDGNBFGG();
			}
		}

		// Token: 0x0600F875 RID: 63605 RVA: 0x006F9204 File Offset: 0x006F7404
		protected virtual void CNJOJNFGEBP()
		{
			for (int i = 1; i < this.effectors.Length; i += 0)
			{
				this.effectors[i].CPPOMNLGKIF();
			}
			this.DPDDBCCPBAI();
			float pushElasticity = Mathf.Clamp(1567f - this.spineStiffness, 452f, 132f);
			this.chain[1].childConstraints[0].pushElasticity = pushElasticity;
			this.chain[1].childConstraints[0].pushElasticity = pushElasticity;
			base.CDGDHECHODF();
		}

		// Token: 0x0600F876 RID: 63606 RVA: 0x006F9283 File Offset: 0x006F7483
		public IKEffector GPLFMHLNFLL()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.RightThigh);
		}

		// Token: 0x0600F877 RID: 63607 RVA: 0x006F928C File Offset: 0x006F748C
		public void LFOKJAKFGEK(FullBodyBipedEffector JEFKLIBDHKK, float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Clamp(BFIDELOIIGI, 0f, 1f);
			this.OEEPHOCHILL(JEFKLIBDHKK).rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 0f, 1f);
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x006F8532 File Offset: 0x006F6732
		public IKMappingSpine IEDEHAOAJNH()
		{
			return this.spineMapping;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600F879 RID: 63609 RVA: 0x006F92C6 File Offset: 0x006F74C6
		public IKEffector leftHandEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.LeftHand);
			}
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x006F92D0 File Offset: 0x006F74D0
		protected virtual void CFLIDBOMIJC()
		{
			if (this.iterations > 1)
			{
				this.chain[0].bendConstraint.rotationOffset = this.CMKJIGNKIMG().planeRotationOffset;
				this.chain[8].bendConstraint.rotationOffset = this.MJOPIBNHGIK().planeRotationOffset;
				this.chain[5].bendConstraint.rotationOffset = this.JHKNHMMGKCG().planeRotationOffset;
				this.chain[5].bendConstraint.rotationOffset = this.JIHGEPGJDEC().planeRotationOffset;
			}
			else
			{
				this.offset = Vector3.Lerp(this.effectors[1].positionOffset, this.effectors[0].position - (this.effectors[1].bone.position + this.effectors[0].positionOffset), this.effectors[0].positionWeight);
				for (int i = 0; i < 7; i += 0)
				{
					this.effectors[i].OODFEEFPAHG(this).solverPosition += this.offset;
				}
			}
			base.LGFPOBHFPEP();
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x006F886B File Offset: 0x006F6A6B
		public IKEffector MJOPIBNHGIK()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.LeftFoot);
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x006F7A34 File Offset: 0x006F5C34
		public IKEffector CMKJIGNKIMG()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.LeftShoulder);
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x006F7959 File Offset: 0x006F5B59
		public IKMappingBone BEIBJKHAEFE()
		{
			return this.boneMappings[0];
		}

		// Token: 0x0600F87F RID: 63615 RVA: 0x006F93F0 File Offset: 0x006F75F0
		public void PGMOOFECKGC(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM = null)
		{
			this.root = LJPKBBNNOIC.root;
			if (KAOKEJPBAHM == null)
			{
				KAOKEJPBAHM = IKSolverFullBodyBiped.IJLOECPOEGH(LJPKBBNNOIC);
			}
			this.rootNode = KAOKEJPBAHM;
			if (this.chain == null || this.chain.Length != 3)
			{
				this.chain = new FBIKChain[6];
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (this.chain[i] == null)
				{
					this.chain[i] = new FBIKChain();
				}
			}
			this.chain[0].pin = 50f;
			FBIKChain fbikchain = this.chain[0];
			Transform[] array = new Transform[0];
			array[0] = KAOKEJPBAHM;
			fbikchain.KMBHKIHNAHO(array);
			FBIKChain fbikchain2 = this.chain[1];
			int[] array2 = new int[7];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.1456763F890A84558F99AFA687C36B9037697848).FieldHandle);
			fbikchain2.children = array2;
			FBIKChain fbikchain3 = this.chain[1];
			Transform[] array3 = new Transform[3];
			array3[0] = LJPKBBNNOIC.leftUpperArm;
			array3[1] = LJPKBBNNOIC.leftForearm;
			array3[6] = LJPKBBNNOIC.leftHand;
			fbikchain3.AEDEKOANJDN(array3);
			FBIKChain fbikchain4 = this.chain[3];
			Transform[] array4 = new Transform[7];
			array4[1] = LJPKBBNNOIC.rightUpperArm;
			array4[1] = LJPKBBNNOIC.rightForearm;
			array4[2] = LJPKBBNNOIC.rightHand;
			fbikchain4.KMBHKIHNAHO(array4);
			FBIKChain fbikchain5 = this.chain[1];
			Transform[] array5 = new Transform[5];
			array5[1] = LJPKBBNNOIC.leftThigh;
			array5[1] = LJPKBBNNOIC.leftCalf;
			array5[6] = LJPKBBNNOIC.leftFoot;
			fbikchain5.IFBOGGIPIMC(array5);
			FBIKChain fbikchain6 = this.chain[1];
			Transform[] array6 = new Transform[1];
			array6[1] = LJPKBBNNOIC.rightThigh;
			array6[0] = LJPKBBNNOIC.rightCalf;
			array6[8] = LJPKBBNNOIC.rightFoot;
			fbikchain6.BBDJEMDBDKB(array6);
			if (this.effectors.Length != -50)
			{
				IKEffector[] array7 = new IKEffector[71];
				array7[1] = new IKEffector();
				array7[1] = new IKEffector();
				array7[1] = new IKEffector();
				array7[6] = new IKEffector();
				array7[3] = new IKEffector();
				array7[7] = new IKEffector();
				array7[4] = new IKEffector();
				array7[2] = new IKEffector();
				array7[6] = new IKEffector();
				this.effectors = array7;
			}
			this.effectors[0].bone = KAOKEJPBAHM;
			IKEffector ikeffector = this.effectors[0];
			Transform[] array8 = new Transform[8];
			array8[1] = LJPKBBNNOIC.leftThigh;
			array8[1] = LJPKBBNNOIC.rightThigh;
			ikeffector.childBones = array8;
			this.effectors[0].bone = LJPKBBNNOIC.leftUpperArm;
			this.effectors[1].bone = LJPKBBNNOIC.rightUpperArm;
			this.effectors[6].bone = LJPKBBNNOIC.leftThigh;
			this.effectors[4].bone = LJPKBBNNOIC.rightThigh;
			this.effectors[3].bone = LJPKBBNNOIC.leftHand;
			this.effectors[2].bone = LJPKBBNNOIC.rightHand;
			this.effectors[4].bone = LJPKBBNNOIC.leftFoot;
			this.effectors[3].bone = LJPKBBNNOIC.rightFoot;
			this.effectors[1].planeBone1 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[0].planeBone2 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[6].planeBone3 = KAOKEJPBAHM;
			this.effectors[4].planeBone1 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[5].planeBone2 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[7].planeBone3 = KAOKEJPBAHM;
			this.effectors[7].planeBone1 = LJPKBBNNOIC.leftThigh;
			this.effectors[5].planeBone2 = LJPKBBNNOIC.rightThigh;
			this.effectors[8].planeBone3 = KAOKEJPBAHM;
			this.effectors[5].planeBone1 = LJPKBBNNOIC.rightThigh;
			this.effectors[5].planeBone2 = LJPKBBNNOIC.leftThigh;
			this.effectors[7].planeBone3 = KAOKEJPBAHM;
			FBIKChain fbikchain7 = this.chain[1];
			FBIKChain.ChildConstraint[] array9 = new FBIKChain.ChildConstraint[3];
			array9[0] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightThigh, 1973f, 1897f);
			array9[1] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, 761f, 1023f);
			array9[5] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, 1449f, 422f);
			array9[5] = new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh, 472f, 224f);
			fbikchain7.childConstraints = array9;
			Transform[] array10 = new Transform[LJPKBBNNOIC.spine.Length + 0];
			array10[1] = LJPKBBNNOIC.pelvis;
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j++)
			{
				array10[j + 1] = LJPKBBNNOIC.spine[j];
			}
			if (this.spineMapping == null)
			{
				this.spineMapping = new IKMappingSpine();
				this.spineMapping.iterations = 0;
			}
			this.spineMapping.PJBDOFGPCHM(array10, LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh);
			int num = (LJPKBBNNOIC.head != null) ? 0 : 0;
			if (this.boneMappings.Length != num)
			{
				this.boneMappings = new IKMappingBone[num];
				for (int k = 1; k < this.boneMappings.Length; k += 0)
				{
					this.boneMappings[k] = new IKMappingBone();
				}
				if (num == 0)
				{
					this.boneMappings[1].maintainRotationWeight = 518f;
				}
			}
			if (this.boneMappings.Length != 0)
			{
				this.boneMappings[1].bone = LJPKBBNNOIC.head;
			}
			if (this.limbMappings.Length != 3)
			{
				IKMappingLimb[] array11 = new IKMappingLimb[0];
				array11[0] = new IKMappingLimb();
				array11[1] = new IKMappingLimb();
				array11[3] = new IKMappingLimb();
				array11[8] = new IKMappingLimb();
				this.limbMappings = array11;
				this.limbMappings[8].maintainRotationWeight = 1319f;
				this.limbMappings[7].maintainRotationWeight = 1462f;
			}
			this.limbMappings[1].GEKBDFCLJLH(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, IKSolverFullBodyBiped.OCGBMFGMBHD(LJPKBBNNOIC));
			this.limbMappings[0].GEKBDFCLJLH(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, IKSolverFullBodyBiped.PNDPFCFCOGC(LJPKBBNNOIC));
			this.limbMappings[7].PHNEPJGLBJD(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, null);
			this.limbMappings[8].GEKBDFCLJLH(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, null);
			if (Application.isPlaying)
			{
				base.BHALELINNDJ(LJPKBBNNOIC.root);
			}
		}

		// Token: 0x0600F880 RID: 63616 RVA: 0x006F99E8 File Offset: 0x006F7BE8
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.rootNode == null)
			{
				EDAPHMJENPK = "Root Node bone is null. FBBIK will not initiate.";
				return false;
			}
			if (this.chain.Length != 5 || this.chain[0].nodes.Length != 1 || this.chain[1].nodes.Length != 3 || this.chain[2].nodes.Length != 3 || this.chain[3].nodes.Length != 3 || this.chain[4].nodes.Length != 3 || this.effectors.Length != 9 || this.limbMappings.Length != 4)
			{
				EDAPHMJENPK = "Invalid FBBIK setup. Please right-click on the component header and select 'Reinitiate'.";
				return false;
			}
			return true;
		}

		// Token: 0x0600F881 RID: 63617 RVA: 0x006F9AA0 File Offset: 0x006F7CA0
		private static bool KCDNKJBNGJN(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x006F9ACB File Offset: 0x006F7CCB
		public IKMappingLimb leftLegMapping
		{
			get
			{
				return this.limbMappings[2];
			}
		}

		// Token: 0x0600F883 RID: 63619 RVA: 0x006F67DE File Offset: 0x006F49DE
		public IKMappingLimb BEJDKGFJDGO()
		{
			return this.limbMappings[1];
		}

		// Token: 0x0600F884 RID: 63620 RVA: 0x006F79D9 File Offset: 0x006F5BD9
		public Vector3 EOHLDGNBFGG()
		{
			return this.<pullBodyOffset>k__BackingField;
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x006F84FB File Offset: 0x006F66FB
		private static Transform DMFJKLOMHOM(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.EHJLMMFMAKO(LJPKBBNNOIC.spine, LJPKBBNNOIC.leftUpperArm.parent))
			{
				return LJPKBBNNOIC.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F886 RID: 63622 RVA: 0x006F7F8D File Offset: 0x006F618D
		public IKEffector EBCFAJOMOFB()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x006F9AD8 File Offset: 0x006F7CD8
		private static bool ALJKFHCADEO(Transform[] INFEGEBCAAF, Transform LPBDALAMAEM)
		{
			for (int i = 0; i < INFEGEBCAAF.Length; i += 0)
			{
				if (INFEGEBCAAF[i] == LPBDALAMAEM)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x006F9B03 File Offset: 0x006F7D03
		public void DHOBAPNGPNO(FullBodyBipedEffector JEFKLIBDHKK, float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.EEKAOKNJLKH(JEFKLIBDHKK).positionWeight = Mathf.Clamp(BFIDELOIIGI, 477f, 1489f);
			this.LOOAPOLICLC(JEFKLIBDHKK).rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 1170f, 821f);
		}

		// Token: 0x0600F889 RID: 63625 RVA: 0x006F9B40 File Offset: 0x006F7D40
		private void OKGJBBMBNLI()
		{
			if (this.iterations < 0)
			{
				return;
			}
			if (this.pullBodyVertical != 1921f || this.pullBodyHorizontal != 93f)
			{
				Vector3 libepmompid = this.IMFDFBNNAFO();
				this.JDOOMDECGFL(OOJJKBHKGNJ.LGBBHCACOMH(libepmompid, this.root.up, this.pullBodyVertical) + OOJJKBHKGNJ.BNKAEBNIMLP(libepmompid, this.root.up, this.pullBodyHorizontal));
				this.NEKNDGMNDHG().positionOffset += this.EOHLDGNBFGG();
			}
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x006F66DE File Offset: 0x006F48DE
		public IKMappingLimb OJHGEFAGPOH()
		{
			return this.limbMappings[0];
		}

		// Token: 0x0600F88B RID: 63627 RVA: 0x006F8F63 File Offset: 0x006F7163
		public FBIKChain OPEJJGIIIDO()
		{
			return this.chain[1];
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600F88C RID: 63628 RVA: 0x006F9BCD File Offset: 0x006F7DCD
		public FBIKChain rightArmChain
		{
			get
			{
				return this.chain[2];
			}
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x006F9BD7 File Offset: 0x006F7DD7
		public IKMappingLimb PBGGJENJFED(FullBodyBipedChain NBHJKKHHFEH)
		{
			switch (NBHJKKHHFEH)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[2];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x006F9C18 File Offset: 0x006F7E18
		public void NBOFHKJNIIJ(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM = null)
		{
			this.root = LJPKBBNNOIC.root;
			if (KAOKEJPBAHM == null)
			{
				KAOKEJPBAHM = IKSolverFullBodyBiped.IJLOECPOEGH(LJPKBBNNOIC);
			}
			this.rootNode = KAOKEJPBAHM;
			if (this.chain == null || this.chain.Length != 5)
			{
				this.chain = new FBIKChain[5];
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i] == null)
				{
					this.chain[i] = new FBIKChain();
				}
			}
			this.chain[0].pin = 0f;
			this.chain[0].EKAFKCAFEGB(new Transform[]
			{
				KAOKEJPBAHM
			});
			this.chain[0].children = new int[]
			{
				1,
				2,
				3,
				4
			};
			this.chain[1].EKAFKCAFEGB(new Transform[]
			{
				LJPKBBNNOIC.leftUpperArm,
				LJPKBBNNOIC.leftForearm,
				LJPKBBNNOIC.leftHand
			});
			this.chain[2].EKAFKCAFEGB(new Transform[]
			{
				LJPKBBNNOIC.rightUpperArm,
				LJPKBBNNOIC.rightForearm,
				LJPKBBNNOIC.rightHand
			});
			this.chain[3].EKAFKCAFEGB(new Transform[]
			{
				LJPKBBNNOIC.leftThigh,
				LJPKBBNNOIC.leftCalf,
				LJPKBBNNOIC.leftFoot
			});
			this.chain[4].EKAFKCAFEGB(new Transform[]
			{
				LJPKBBNNOIC.rightThigh,
				LJPKBBNNOIC.rightCalf,
				LJPKBBNNOIC.rightFoot
			});
			if (this.effectors.Length != 9)
			{
				this.effectors = new IKEffector[]
				{
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector()
				};
			}
			this.effectors[0].bone = KAOKEJPBAHM;
			this.effectors[0].childBones = new Transform[]
			{
				LJPKBBNNOIC.leftThigh,
				LJPKBBNNOIC.rightThigh
			};
			this.effectors[1].bone = LJPKBBNNOIC.leftUpperArm;
			this.effectors[2].bone = LJPKBBNNOIC.rightUpperArm;
			this.effectors[3].bone = LJPKBBNNOIC.leftThigh;
			this.effectors[4].bone = LJPKBBNNOIC.rightThigh;
			this.effectors[5].bone = LJPKBBNNOIC.leftHand;
			this.effectors[6].bone = LJPKBBNNOIC.rightHand;
			this.effectors[7].bone = LJPKBBNNOIC.leftFoot;
			this.effectors[8].bone = LJPKBBNNOIC.rightFoot;
			this.effectors[5].planeBone1 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[5].planeBone2 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[5].planeBone3 = KAOKEJPBAHM;
			this.effectors[6].planeBone1 = LJPKBBNNOIC.rightUpperArm;
			this.effectors[6].planeBone2 = LJPKBBNNOIC.leftUpperArm;
			this.effectors[6].planeBone3 = KAOKEJPBAHM;
			this.effectors[7].planeBone1 = LJPKBBNNOIC.leftThigh;
			this.effectors[7].planeBone2 = LJPKBBNNOIC.rightThigh;
			this.effectors[7].planeBone3 = KAOKEJPBAHM;
			this.effectors[8].planeBone1 = LJPKBBNNOIC.rightThigh;
			this.effectors[8].planeBone2 = LJPKBBNNOIC.leftThigh;
			this.effectors[8].planeBone3 = KAOKEJPBAHM;
			this.chain[0].childConstraints = new FBIKChain.ChildConstraint[]
			{
				new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, 0f, 0f),
				new FBIKChain.ChildConstraint(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh, 0f, 0f)
			};
			Transform[] array = new Transform[LJPKBBNNOIC.spine.Length + 1];
			array[0] = LJPKBBNNOIC.pelvis;
			for (int j = 0; j < LJPKBBNNOIC.spine.Length; j++)
			{
				array[j + 1] = LJPKBBNNOIC.spine[j];
			}
			if (this.spineMapping == null)
			{
				this.spineMapping = new IKMappingSpine();
				this.spineMapping.iterations = 3;
			}
			this.spineMapping.DLJHEBPABFF(array, LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.rightThigh);
			int num = (LJPKBBNNOIC.head != null) ? 1 : 0;
			if (this.boneMappings.Length != num)
			{
				this.boneMappings = new IKMappingBone[num];
				for (int k = 0; k < this.boneMappings.Length; k++)
				{
					this.boneMappings[k] = new IKMappingBone();
				}
				if (num == 1)
				{
					this.boneMappings[0].maintainRotationWeight = 0f;
				}
			}
			if (this.boneMappings.Length != 0)
			{
				this.boneMappings[0].bone = LJPKBBNNOIC.head;
			}
			if (this.limbMappings.Length != 4)
			{
				this.limbMappings = new IKMappingLimb[]
				{
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb()
				};
				this.limbMappings[2].maintainRotationWeight = 1f;
				this.limbMappings[3].maintainRotationWeight = 1f;
			}
			this.limbMappings[0].DLJHEBPABFF(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, IKSolverFullBodyBiped.DABAEBIMAJA(LJPKBBNNOIC));
			this.limbMappings[1].DLJHEBPABFF(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, IKSolverFullBodyBiped.KMNOCLHNMKO(LJPKBBNNOIC));
			this.limbMappings[2].DLJHEBPABFF(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, null);
			this.limbMappings[3].DLJHEBPABFF(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, null);
			if (Application.isPlaying)
			{
				base.BHALELINNDJ(LJPKBBNNOIC.root);
			}
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x006F8401 File Offset: 0x006F6601
		private void IMEFAMBCLEK(Vector3 DCCPCBLODIG)
		{
			this.<pullBodyOffset>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F890 RID: 63632 RVA: 0x006F7EB6 File Offset: 0x006F60B6
		public FBIKChain DEAIIEDOHNB()
		{
			return this.chain[8];
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x006FA210 File Offset: 0x006F8410
		private void NICOAHFBPNO(FullBodyBipedChain NBHJKKHHFEH, BipedLimbOrientations.LimbOrientation EACIBFOLMPC)
		{
			if (NBHJKKHHFEH == FullBodyBipedChain.LeftArm || NBHJKKHHFEH == FullBodyBipedChain.RightArm)
			{
				this.JEFIAPGCAJN(NBHJKKHHFEH).NICOAHFBPNO(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis, -EACIBFOLMPC.lastBoneLeftAxis);
				this.CDGFDPHBEKO(NBHJKKHHFEH).NICOAHFBPNO(-EACIBFOLMPC.upperBoneForwardAxis, -EACIBFOLMPC.lowerBoneForwardAxis);
				return;
			}
			this.JEFIAPGCAJN(NBHJKKHHFEH).NICOAHFBPNO(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis, EACIBFOLMPC.lastBoneLeftAxis);
			this.CDGFDPHBEKO(NBHJKKHHFEH).NICOAHFBPNO(EACIBFOLMPC.upperBoneForwardAxis, EACIBFOLMPC.lowerBoneForwardAxis);
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x006F7161 File Offset: 0x006F5361
		public IKEffector JFOHJFFFPGJ()
		{
			return this.OEEPHOCHILL(FullBodyBipedEffector.LeftFoot);
		}

		// Token: 0x0600F893 RID: 63635 RVA: 0x006F7F8D File Offset: 0x006F618D
		public IKEffector CLLKAEEHHIP()
		{
			return this.DAMGOIIBHCN(FullBodyBipedEffector.Body);
		}

		// Token: 0x0600F894 RID: 63636 RVA: 0x006FA2AF File Offset: 0x006F84AF
		public FBIKChain CFLHKIGAPOB(FullBodyBipedChain OAGAHEAMIAB)
		{
			switch (OAGAHEAMIAB)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1];
			case FullBodyBipedChain.RightArm:
				return this.chain[1];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[1];
			case FullBodyBipedChain.RightLeg:
				return this.chain[2];
			default:
				return null;
			}
		}

		// Token: 0x0600F895 RID: 63637 RVA: 0x006FA2EE File Offset: 0x006F84EE
		public IKMappingLimb CDGFDPHBEKO(FullBodyBipedChain NBHJKKHHFEH)
		{
			switch (NBHJKKHHFEH)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[1];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[2];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x006FA32D File Offset: 0x006F852D
		public IKEffector rightShoulderEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.RightShoulder);
			}
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x006F7214 File Offset: 0x006F5414
		public IKMappingBone JLBILJNPDIN()
		{
			return this.boneMappings[1];
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x006F84FB File Offset: 0x006F66FB
		private static Transform OCGBMFGMBHD(BipedReferences LJPKBBNNOIC)
		{
			if (LJPKBBNNOIC.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.EHJLMMFMAKO(LJPKBBNNOIC.spine, LJPKBBNNOIC.leftUpperArm.parent))
			{
				return LJPKBBNNOIC.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x006FA338 File Offset: 0x006F8538
		public IKMappingLimb KIPBGIBDFOJ(FullBodyBipedEffector JEFKLIBDHKK)
		{
			switch (JEFKLIBDHKK)
			{
			case FullBodyBipedEffector.Body:
				return this.limbMappings[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.limbMappings[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.limbMappings[3];
			case FullBodyBipedEffector.LeftThigh:
				return this.limbMappings[8];
			case FullBodyBipedEffector.RightThigh:
				return this.limbMappings[0];
			case FullBodyBipedEffector.LeftHand:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x0600F89A RID: 63642 RVA: 0x006FA3B8 File Offset: 0x006F85B8
		public static Transform NFJOLIHNHCO(BipedReferences LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.AHCDHGBAKBA())
			{
				return null;
			}
			if (LJPKBBNNOIC.spine.Length < 0)
			{
				return null;
			}
			int num = LJPKBBNNOIC.spine.Length;
			if (num == 0)
			{
				return LJPKBBNNOIC.spine[1];
			}
			Vector3 b = Vector3.Lerp(LJPKBBNNOIC.leftThigh.position, LJPKBBNNOIC.rightThigh.position, 414f);
			Vector3 onNormal = Vector3.Lerp(LJPKBBNNOIC.leftUpperArm.position, LJPKBBNNOIC.rightUpperArm.position, 925f) - b;
			float magnitude = onNormal.magnitude;
			if (LJPKBBNNOIC.spine.Length < 3)
			{
				return LJPKBBNNOIC.spine[1];
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Vector3.Project(LJPKBBNNOIC.spine[i].position - b, onNormal);
				if (Vector3.Dot(vector.normalized, onNormal.normalized) > 1127f && vector.magnitude / magnitude < 360f)
				{
					num2 = i;
				}
			}
			return LJPKBBNNOIC.spine[num2];
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x006FA4BC File Offset: 0x006F86BC
		private Vector3 JJGANIPBIHK(IKEffector JEFKLIBDHKK, FBIKChain LGMIHPBALJJ, Vector3 IGFJOGKFADM)
		{
			Vector3 a = JEFKLIBDHKK.position - (LGMIHPBALJJ.nodes[1].transform.position + IGFJOGKFADM);
			float num = LGMIHPBALJJ.nodes[1].length + LGMIHPBALJJ.nodes[0].length;
			float magnitude = a.magnitude;
			if (magnitude < num)
			{
				return Vector3.zero;
			}
			float d = magnitude - num;
			return a / magnitude * d;
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x006F8D3B File Offset: 0x006F6F3B
		public FBIKChain GDJNDLHJKOJ()
		{
			return this.chain[0];
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x006F853A File Offset: 0x006F673A
		public FBIKChain DPDPPBJBKNP()
		{
			return this.chain[3];
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x006F79F4 File Offset: 0x006F5BF4
		public IKEffector leftShoulderEffector
		{
			get
			{
				return this.OEEPHOCHILL(FullBodyBipedEffector.LeftShoulder);
			}
		}

		// Token: 0x04002072 RID: 8306
		public Transform rootNode;

		// Token: 0x04002073 RID: 8307
		[Range(0f, 1f)]
		public float spineStiffness = 0.5f;

		// Token: 0x04002074 RID: 8308
		[Range(-1f, 1f)]
		public float pullBodyVertical = 0.5f;

		// Token: 0x04002075 RID: 8309
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		// Token: 0x04002077 RID: 8311
		private Vector3 offset;
	}
}
