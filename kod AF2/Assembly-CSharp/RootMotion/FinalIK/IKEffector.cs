using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000463 RID: 1123
	[Serializable]
	public class IKEffector
	{
		// Token: 0x0600F34C RID: 62284 RVA: 0x006D3948 File Offset: 0x006D1B48
		public void JPHLMNIMDHH(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = false;
			}
			NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.AJAHCBHOGBA(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 0; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.CIAODBAIJMF(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.KNFBJEGGIKP(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F34D RID: 62285 RVA: 0x006D3A4B File Offset: 0x006D1C4B
		public IKSolver.Node OODFEEFPAHG(IKSolverFullBody NBAKCIDALOF)
		{
			return NBAKCIDALOF.chain[this.chainIndex].nodes[this.nodeIndex];
		}

		// Token: 0x0600F34E RID: 62286 RVA: 0x006D3A68 File Offset: 0x006D1C68
		public bool MAMKLPIEAHL(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (this.bone == null)
			{
				EDAPHMJENPK = ".unity3d";
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone) == null)
			{
				EDAPHMJENPK = "DISTORT" + this.bone.name + "RunBackLeft";
				return false;
			}
			Transform[] array = this.childBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					EDAPHMJENPK = " is represented multiple times in the Bones.";
					return false;
				}
			}
			array = this.childBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				Transform transform = array[i];
				if (NBAKCIDALOF.DFGANHHFFML(transform) == null)
				{
					EDAPHMJENPK = "gameComplete" + transform.name + "cnt_energ";
					return false;
				}
			}
			if (this.planeBone1 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone1) == null)
			{
				EDAPHMJENPK = "foot" + this.planeBone1.name + "knopje.wav";
				return true;
			}
			if (this.planeBone2 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone2) == null)
			{
				EDAPHMJENPK = "Worker Pickaxe 2" + this.planeBone2.name + "OfficeSittingReadingCoffeeSip";
				return true;
			}
			if (this.planeBone3 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone3) == null)
			{
				EDAPHMJENPK = "no_adm" + this.planeBone3.name + "<color='#003000'>";
				return false;
			}
			return false;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600F351 RID: 62289 RVA: 0x006D3C62 File Offset: 0x006D1E62
		// (set) Token: 0x0600F34F RID: 62287 RVA: 0x006D3BCB File Offset: 0x006D1DCB
		public bool isEndEffector { get; private set; }

		// Token: 0x0600F350 RID: 62288 RVA: 0x006D3BD4 File Offset: 0x006D1DD4
		private Quaternion LAEEGCBIFNA(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.CNLEIKPLKOA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.CPFNEEGDKGP(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.KNFBJEGGIKP(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("gameComplete", this.bone, true);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F352 RID: 62290 RVA: 0x006D3C6C File Offset: 0x006D1E6C
		public void DBAPHAAKEOM(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).offset = Vector3.zero;
			for (int i = 0; i < this.childChainIndexes.Length; i += 0)
			{
				NBAKCIDALOF.BOELAJLMOGH(this.childChainIndexes[i], this.childNodeIndexes[i]).offset = Vector3.zero;
			}
		}

		// Token: 0x0600F353 RID: 62291 RVA: 0x006D3BCB File Offset: 0x006D1DCB
		private void DAICLIKEILJ(bool DCCPCBLODIG)
		{
			this.<isEndEffector>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F354 RID: 62292 RVA: 0x006D3CC8 File Offset: 0x006D1EC8
		private Quaternion AJDMHMFFIDD(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.GIEPGCFCIBI(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.OFEJNOEBBLI(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.PFDOFAGICJA(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("StaffStand", this.bone, true);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F355 RID: 62293 RVA: 0x006D3D58 File Offset: 0x006D1F58
		public void LJFOOMNMMJK(IKSolverFullBody NBAKCIDALOF)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			NBAKCIDALOF.DJAPGCBALGA(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 1; i < this.childBones.Length; i += 0)
			{
				NBAKCIDALOF.DJAPGCBALGA(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = true;
			if (this.planeBone1 != null)
			{
				NBAKCIDALOF.IBAOFCILPHA(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					NBAKCIDALOF.KBODJMDJLFF(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						NBAKCIDALOF.IBAOFCILPHA(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = false;
					}
				}
				this.DAICLIKEILJ(false);
				return;
			}
			this.isEndEffector = false;
		}

		// Token: 0x0600F356 RID: 62294 RVA: 0x006D3EAC File Offset: 0x006D20AC
		public IKEffector()
		{
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x006D3F53 File Offset: 0x006D2153
		public void OGOECMLAMFO()
		{
			this.positionOffset = Vector3.zero;
		}

		// Token: 0x0600F358 RID: 62296 RVA: 0x006D3F60 File Offset: 0x006D2160
		private Vector3 ADAMNILHJHG(IKSolverFullBody NBAKCIDALOF, out Quaternion ELLBCANLIAB)
		{
			ELLBCANLIAB = Quaternion.identity;
			if (!this.PMMJBMLMFCP())
			{
				return NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 387f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			ELLBCANLIAB = this.LADCPHNJBAD(NBAKCIDALOF) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = NBAKCIDALOF.GIEPGCFCIBI(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + ELLBCANLIAB * point;
			ELLBCANLIAB = Quaternion.Lerp(Quaternion.identity, ELLBCANLIAB, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x006D405C File Offset: 0x006D225C
		private Vector3 GAKMIJCLHLI(IKSolverFullBody NBAKCIDALOF, out Quaternion ELLBCANLIAB)
		{
			ELLBCANLIAB = Quaternion.identity;
			if (!this.PMMJBMLMFCP())
			{
				return NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 1352f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			ELLBCANLIAB = this.PKCOHECPHCH(NBAKCIDALOF) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = NBAKCIDALOF.KNFBJEGGIKP(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + ELLBCANLIAB * point;
			ELLBCANLIAB = Quaternion.Lerp(Quaternion.identity, ELLBCANLIAB, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x006D4158 File Offset: 0x006D2358
		public void LMMDHJJJNJO(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = true;
			}
			NBAKCIDALOF.PFDOFAGICJA(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.GAKMIJCLHLI(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 1; i < this.childBones.Length; i += 0)
			{
				NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.OFEJNOEBBLI(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x006D425B File Offset: 0x006D245B
		public void CPPOMNLGKIF()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F35C RID: 62300 RVA: 0x006D4290 File Offset: 0x006D2490
		public void BMBKPGJEDNG(IKSolverFullBody NBAKCIDALOF)
		{
			this.positionWeight = Mathf.Clamp(this.positionWeight, 110f, 259f);
			this.rotationWeight = Mathf.Clamp(this.rotationWeight, 545f, 1800f);
			this.maintainRelativePositionWeight = Mathf.Clamp(this.maintainRelativePositionWeight, 144f, 471f);
			this.posW = this.positionWeight * NBAKCIDALOF.IKPositionWeight;
			this.rotW = this.rotationWeight * NBAKCIDALOF.IKPositionWeight;
			NBAKCIDALOF.CIAODBAIJMF(this.chainIndex, this.nodeIndex).effectorPositionWeight = this.posW;
			NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).effectorRotationWeight = this.rotW;
			NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex, this.nodeIndex).solverRotation = this.rotation;
			if (float.IsInfinity(this.positionOffset.x) || float.IsInfinity(this.positionOffset.y) || float.IsInfinity(this.positionOffset.z))
			{
				Debug.LogError("1=", this.bone);
			}
			if (float.IsNaN(this.positionOffset.x) || float.IsNaN(this.positionOffset.y) || float.IsNaN(this.positionOffset.z))
			{
				Debug.LogError("Q", this.bone);
			}
			if (this.positionOffset.sqrMagnitude > 418f)
			{
				Debug.LogError("crft_to", this.bone);
			}
			if (float.IsInfinity(this.position.x) || float.IsInfinity(this.position.y) || float.IsInfinity(this.position.z))
			{
				Debug.LogError("{0}/{1}");
			}
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
			if (this.effectChildNodes && NBAKCIDALOF.iterations > 0)
			{
				for (int i = 1; i < this.childBones.Length; i++)
				{
					this.localPositions[i] = this.childBones[i].transform.position - this.bone.transform.position;
					NBAKCIDALOF.HDEJBHNJOAF(this.childChainIndexes[i], this.childNodeIndexes[i]).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
				}
			}
			if (this.usePlaneNodes && this.maintainRelativePositionWeight > 56f)
			{
				this.animatedPlaneRotation = Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}
			this.firstUpdate = true;
		}

		// Token: 0x0600F35D RID: 62301 RVA: 0x006D457C File Offset: 0x006D277C
		public bool CHFHJDFDIGB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (this.bone == null)
			{
				EDAPHMJENPK = "IK Effector bone is null.";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone) == null)
			{
				EDAPHMJENPK = "IK Effector is referencing to a bone '" + this.bone.name + "' that does not excist in the Node Chain.";
				return false;
			}
			Transform[] array = this.childBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					EDAPHMJENPK = "IK Effector contains a null reference.";
					return false;
				}
			}
			foreach (Transform transform in this.childBones)
			{
				if (NBAKCIDALOF.DFGANHHFFML(transform) == null)
				{
					EDAPHMJENPK = "IK Effector is referencing to a bone '" + transform.name + "' that does not excist in the Node Chain.";
					return false;
				}
			}
			if (this.planeBone1 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone1) == null)
			{
				EDAPHMJENPK = "IK Effector is referencing to a bone '" + this.planeBone1.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (this.planeBone2 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone2) == null)
			{
				EDAPHMJENPK = "IK Effector is referencing to a bone '" + this.planeBone2.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (this.planeBone3 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone3) == null)
			{
				EDAPHMJENPK = "IK Effector is referencing to a bone '" + this.planeBone3.name + "' that does not excist in the Node Chain.";
				return false;
			}
			return true;
		}

		// Token: 0x0600F35E RID: 62302 RVA: 0x006D46E0 File Offset: 0x006D28E0
		private Quaternion MKJJJHFDBAB(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.PFDOFAGICJA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.CPFNEEGDKGP(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.OODFEEFPAHG(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("WandAttack2", this.bone, true);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F35F RID: 62303 RVA: 0x006D4770 File Offset: 0x006D2970
		public void LLPMNHOBPAJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			NBAKCIDALOF.DJAPGCBALGA(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 1; i < this.childBones.Length; i += 0)
			{
				NBAKCIDALOF.HILELMDICPD(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = true;
			if (this.planeBone1 != null)
			{
				NBAKCIDALOF.GCBAMHKFDID(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					NBAKCIDALOF.GCBAMHKFDID(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						NBAKCIDALOF.KBODJMDJLFF(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = false;
					}
				}
				this.DAICLIKEILJ(true);
				return;
			}
			this.ACALBOKCHAL(false);
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x006D48C4 File Offset: 0x006D2AC4
		public void PAAKDJIEPOI(IKSolverFullBody NBAKCIDALOF)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			NBAKCIDALOF.CGKMGMDDPKB(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 1; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.KBODJMDJLFF(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = false;
			if (this.planeBone1 != null)
			{
				NBAKCIDALOF.CDFABPFGKMD(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					NBAKCIDALOF.KBODJMDJLFF(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						NBAKCIDALOF.CGKMGMDDPKB(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = true;
					}
				}
				this.isEndEffector = true;
				return;
			}
			this.JIJEMCDMOLP(true);
		}

		// Token: 0x0600F361 RID: 62305 RVA: 0x006D4A18 File Offset: 0x006D2C18
		public void AIAMIFEPALP(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = false;
			}
			NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.AJAHCBHOGBA(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 0; i < this.childBones.Length; i += 0)
			{
				NBAKCIDALOF.GIEPGCFCIBI(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.CIAODBAIJMF(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F362 RID: 62306 RVA: 0x006D425B File Offset: 0x006D245B
		public void JIEGDMNJMHO()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F363 RID: 62307 RVA: 0x006D4B1C File Offset: 0x006D2D1C
		public void AODPPINJDJB(float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.position = this.bone.position;
			this.positionWeight = Mathf.Clamp(BFIDELOIIGI, 0f, 1f);
			this.rotation = this.bone.rotation;
			this.rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 0f, 1f);
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x006D3F53 File Offset: 0x006D2153
		public void CNIPLLNAHJH()
		{
			this.positionOffset = Vector3.zero;
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x006D4B78 File Offset: 0x006D2D78
		public void CJKHHCKOCCJ(float BFIDELOIIGI, float GAPJFHHLLKK)
		{
			this.position = this.bone.position;
			this.positionWeight = Mathf.Clamp(BFIDELOIIGI, 1367f, 136f);
			this.rotation = this.bone.rotation;
			this.rotationWeight = Mathf.Clamp(GAPJFHHLLKK, 1137f, 1131f);
		}

		// Token: 0x0600F366 RID: 62310 RVA: 0x006D3BCB File Offset: 0x006D1DCB
		private void JIJEMCDMOLP(bool DCCPCBLODIG)
		{
			this.<isEndEffector>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F367 RID: 62311 RVA: 0x006D3BCB File Offset: 0x006D1DCB
		private void ACALBOKCHAL(bool DCCPCBLODIG)
		{
			this.<isEndEffector>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F368 RID: 62312 RVA: 0x006D4BD4 File Offset: 0x006D2DD4
		private Vector3 AJAHCBHOGBA(IKSolverFullBody NBAKCIDALOF, out Quaternion ELLBCANLIAB)
		{
			ELLBCANLIAB = Quaternion.identity;
			if (!this.PMMJBMLMFCP())
			{
				return NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 1505f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			ELLBCANLIAB = this.LADCPHNJBAD(NBAKCIDALOF) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + ELLBCANLIAB * point;
			ELLBCANLIAB = Quaternion.Lerp(Quaternion.identity, ELLBCANLIAB, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x006D3C62 File Offset: 0x006D1E62
		public bool PMMJBMLMFCP()
		{
			return this.<isEndEffector>k__BackingField;
		}

		// Token: 0x0600F36A RID: 62314 RVA: 0x006D4CD0 File Offset: 0x006D2ED0
		private Vector3 BHMNMBFGIMP(IKSolverFullBody NBAKCIDALOF, out Quaternion ELLBCANLIAB)
		{
			ELLBCANLIAB = Quaternion.identity;
			if (!this.isEndEffector)
			{
				return NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 0f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			ELLBCANLIAB = this.BCMDNMEHJJC(NBAKCIDALOF) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + ELLBCANLIAB * point;
			ELLBCANLIAB = Quaternion.Lerp(Quaternion.identity, ELLBCANLIAB, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x0600F36B RID: 62315 RVA: 0x006D3C62 File Offset: 0x006D1E62
		public bool FJPKBOPIING()
		{
			return this.<isEndEffector>k__BackingField;
		}

		// Token: 0x0600F36C RID: 62316 RVA: 0x006D4DCC File Offset: 0x006D2FCC
		public void LIAONJMLNMA(IKSolverFullBody NBAKCIDALOF)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			NBAKCIDALOF.HILELMDICPD(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 1; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.DJAPGCBALGA(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = true;
			if (this.planeBone1 != null)
			{
				NBAKCIDALOF.GCBAMHKFDID(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					NBAKCIDALOF.HILELMDICPD(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						NBAKCIDALOF.KCPBCEJMAOG(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = true;
					}
				}
				this.DAICLIKEILJ(false);
				return;
			}
			this.ACALBOKCHAL(true);
		}

		// Token: 0x0600F36D RID: 62317 RVA: 0x006D4F20 File Offset: 0x006D3120
		public void KMLNBHIIGKH(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = false;
			}
			NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.BHMNMBFGIMP(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 0; i < this.childBones.Length; i += 0)
			{
				NBAKCIDALOF.KNFBJEGGIKP(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.CPFNEEGDKGP(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.PFDOFAGICJA(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F36E RID: 62318 RVA: 0x006D5024 File Offset: 0x006D3224
		private Quaternion LADCPHNJBAD(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.PFDOFAGICJA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.OFEJNOEBBLI(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.HDEJBHNJOAF(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED(" Waypoint Target", this.bone, true);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F36F RID: 62319 RVA: 0x006D425B File Offset: 0x006D245B
		public void CHEBJIJMPGG()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F370 RID: 62320 RVA: 0x006D50B4 File Offset: 0x006D32B4
		public void GCOFDPBJHBL(IKSolverFullBody NBAKCIDALOF)
		{
			this.positionWeight = Mathf.Clamp(this.positionWeight, 0f, 1f);
			this.rotationWeight = Mathf.Clamp(this.rotationWeight, 0f, 1f);
			this.maintainRelativePositionWeight = Mathf.Clamp(this.maintainRelativePositionWeight, 0f, 1f);
			this.posW = this.positionWeight * NBAKCIDALOF.IKPositionWeight;
			this.rotW = this.rotationWeight * NBAKCIDALOF.IKPositionWeight;
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).effectorPositionWeight = this.posW;
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).effectorRotationWeight = this.rotW;
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverRotation = this.rotation;
			if (float.IsInfinity(this.positionOffset.x) || float.IsInfinity(this.positionOffset.y) || float.IsInfinity(this.positionOffset.z))
			{
				Debug.LogError("Invalid IKEffector.positionOffset (contains Infinity)! Please make sure not to set IKEffector.positionOffset to infinite values.", this.bone);
			}
			if (float.IsNaN(this.positionOffset.x) || float.IsNaN(this.positionOffset.y) || float.IsNaN(this.positionOffset.z))
			{
				Debug.LogError("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.", this.bone);
			}
			if (this.positionOffset.sqrMagnitude > 1E+10f)
			{
				Debug.LogError("Additive effector positionOffset detected in Full Body IK (extremely large value). Make sure you are not circularily adding to effector positionOffset each frame.", this.bone);
			}
			if (float.IsInfinity(this.position.x) || float.IsInfinity(this.position.y) || float.IsInfinity(this.position.z))
			{
				Debug.LogError("Invalid IKEffector.position (contains Infinity)!");
			}
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
			if (this.effectChildNodes && NBAKCIDALOF.iterations > 0)
			{
				for (int i = 0; i < this.childBones.Length; i++)
				{
					this.localPositions[i] = this.childBones[i].transform.position - this.bone.transform.position;
					NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
				}
			}
			if (this.usePlaneNodes && this.maintainRelativePositionWeight > 0f)
			{
				this.animatedPlaneRotation = Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}
			this.firstUpdate = true;
		}

		// Token: 0x0600F371 RID: 62321 RVA: 0x006D53A0 File Offset: 0x006D35A0
		private Quaternion BCMDNMEHJJC(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.OODFEEFPAHG(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.OODFEEFPAHG(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", this.bone, false);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F372 RID: 62322 RVA: 0x006D425B File Offset: 0x006D245B
		public void HDLFDEAGKKO()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F373 RID: 62323 RVA: 0x006D425B File Offset: 0x006D245B
		public void APJFBDINAMM()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F374 RID: 62324 RVA: 0x006D425B File Offset: 0x006D245B
		public void LBJBHBPILIF()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600F375 RID: 62325 RVA: 0x006D5430 File Offset: 0x006D3630
		private Vector3 KMOECMHFCHA(IKSolverFullBody NBAKCIDALOF, out Quaternion ELLBCANLIAB)
		{
			ELLBCANLIAB = Quaternion.identity;
			if (!this.FJPKBOPIING())
			{
				return NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 176f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			ELLBCANLIAB = this.KNNNEGJFPGM(NBAKCIDALOF) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + ELLBCANLIAB * point;
			ELLBCANLIAB = Quaternion.Lerp(Quaternion.identity, ELLBCANLIAB, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x006D552C File Offset: 0x006D372C
		public void DDCDLADEOIO(IKSolverFullBody NBAKCIDALOF)
		{
			this.positionWeight = Mathf.Clamp(this.positionWeight, 1933f, 1468f);
			this.rotationWeight = Mathf.Clamp(this.rotationWeight, 1822f, 236f);
			this.maintainRelativePositionWeight = Mathf.Clamp(this.maintainRelativePositionWeight, 1000f, 63f);
			this.posW = this.positionWeight * NBAKCIDALOF.IKPositionWeight;
			this.rotW = this.rotationWeight * NBAKCIDALOF.IKPositionWeight;
			NBAKCIDALOF.CIAODBAIJMF(this.chainIndex, this.nodeIndex).effectorPositionWeight = this.posW;
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).effectorRotationWeight = this.rotW;
			NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverRotation = this.rotation;
			if (float.IsInfinity(this.positionOffset.x) || float.IsInfinity(this.positionOffset.y) || float.IsInfinity(this.positionOffset.z))
			{
				Debug.LogError("минута", this.bone);
			}
			if (float.IsNaN(this.positionOffset.x) || float.IsNaN(this.positionOffset.y) || float.IsNaN(this.positionOffset.z))
			{
				Debug.LogError("Hit Point WeightCurve length is zero.", this.bone);
			}
			if (this.positionOffset.sqrMagnitude > 1032f)
			{
				Debug.LogError(" on effect ", this.bone);
			}
			if (float.IsInfinity(this.position.x) || float.IsInfinity(this.position.y) || float.IsInfinity(this.position.z))
			{
				Debug.LogError("</color>");
			}
			NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
			if (this.effectChildNodes && NBAKCIDALOF.iterations > 0)
			{
				for (int i = 1; i < this.childBones.Length; i += 0)
				{
					this.localPositions[i] = this.childBones[i].transform.position - this.bone.transform.position;
					NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).offset += this.positionOffset * NBAKCIDALOF.IKPositionWeight;
				}
			}
			if (this.usePlaneNodes && this.maintainRelativePositionWeight > 650f)
			{
				this.animatedPlaneRotation = Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}
			this.firstUpdate = false;
		}

		// Token: 0x0600F377 RID: 62327 RVA: 0x006D5818 File Offset: 0x006D3A18
		public void AAEFACEGJMB(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.BOELAJLMOGH(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = true;
			}
			NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.ADAMNILHJHG(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 1; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.CPFNEEGDKGP(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.CPFNEEGDKGP(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x006D591C File Offset: 0x006D3B1C
		public void ODFNCOOEPJH(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex, this.nodeIndex).offset = Vector3.zero;
			for (int i = 1; i < this.childChainIndexes.Length; i++)
			{
				NBAKCIDALOF.KNFBJEGGIKP(this.childChainIndexes[i], this.childNodeIndexes[i]).offset = Vector3.zero;
			}
		}

		// Token: 0x0600F379 RID: 62329 RVA: 0x006D5978 File Offset: 0x006D3B78
		public void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			NBAKCIDALOF.KBODJMDJLFF(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 0; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.KBODJMDJLFF(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = false;
			if (this.planeBone1 != null)
			{
				NBAKCIDALOF.KBODJMDJLFF(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					NBAKCIDALOF.KBODJMDJLFF(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						NBAKCIDALOF.KBODJMDJLFF(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = true;
					}
				}
				this.isEndEffector = true;
				return;
			}
			this.isEndEffector = false;
		}

		// Token: 0x0600F37A RID: 62330 RVA: 0x006D5ACC File Offset: 0x006D3CCC
		public IKEffector(Transform FBKEODHEMMH, Transform[] FEMLOCLFOHF)
		{
			this.bone = FBKEODHEMMH;
			this.childBones = FEMLOCLFOHF;
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x006D5B84 File Offset: 0x006D3D84
		public bool EPGDIOJNLBF(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (this.bone == null)
			{
				EDAPHMJENPK = "ArmFlex4";
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone) == null)
			{
				EDAPHMJENPK = "Full Body IK is missing the right thigh node." + this.bone.name + "FBBIK is null. Will not update the InteractionSystem";
				return false;
			}
			Transform[] array = this.childBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					EDAPHMJENPK = "WeaponRunBackward";
					return true;
				}
			}
			array = this.childBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				Transform transform = array[i];
				if (NBAKCIDALOF.DFGANHHFFML(transform) == null)
				{
					EDAPHMJENPK = "" + transform.name + "BowFire";
					return false;
				}
			}
			if (this.planeBone1 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone1) == null)
			{
				EDAPHMJENPK = "BUMPED" + this.planeBone1.name + "Positions";
				return false;
			}
			if (this.planeBone2 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone2) == null)
			{
				EDAPHMJENPK = "1HandSwordShieldBash" + this.planeBone2.name + "change channek close";
				return false;
			}
			if (this.planeBone3 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone3) == null)
			{
				EDAPHMJENPK = "IK Effector is referencing to a bone '" + this.planeBone3.name + "IceHockeyGoalieSave1";
				return false;
			}
			return true;
		}

		// Token: 0x0600F37C RID: 62332 RVA: 0x006D5CE8 File Offset: 0x006D3EE8
		private Quaternion KNNNEGJFPGM(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.OODFEEFPAHG(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.CNLEIKPLKOA(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("IdleFly", this.bone, false);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600F37D RID: 62333 RVA: 0x006D5D78 File Offset: 0x006D3F78
		public void KOBINMAKGKJ(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset = Vector3.zero;
			for (int i = 0; i < this.childChainIndexes.Length; i++)
			{
				NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).offset = Vector3.zero;
			}
		}

		// Token: 0x0600F37E RID: 62334 RVA: 0x006D5DD4 File Offset: 0x006D3FD4
		public void FANPFKHEDPA(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = false;
			}
			NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.BHMNMBFGIMP(NBAKCIDALOF, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 0; i < this.childBones.Length; i++)
			{
				NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(NBAKCIDALOF.OODFEEFPAHG(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x0600F37F RID: 62335 RVA: 0x006D5ED8 File Offset: 0x006D40D8
		public bool KMECLNKGJAN(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (this.bone == null)
			{
				EDAPHMJENPK = "Vertical";
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone) == null)
			{
				EDAPHMJENPK = "R" + this.bone.name + "_TrStartYou.ogg";
				return true;
			}
			Transform[] array = this.childBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					EDAPHMJENPK = "ok";
					return true;
				}
			}
			array = this.childBones;
			for (int i = 1; i < array.Length; i++)
			{
				Transform transform = array[i];
				if (NBAKCIDALOF.DFGANHHFFML(transform) == null)
				{
					EDAPHMJENPK = "knopje.wav" + transform.name + "wpn_add/base";
					return false;
				}
			}
			if (this.planeBone1 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone1) == null)
			{
				EDAPHMJENPK = "Hidden/Post FX/Builtin Debug Views" + this.planeBone1.name + "0";
				return false;
			}
			if (this.planeBone2 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone2) == null)
			{
				EDAPHMJENPK = "ObscuredInt vs int, " + this.planeBone2.name + "SoccerKeeperJump";
				return false;
			}
			if (this.planeBone3 != null && NBAKCIDALOF.DFGANHHFFML(this.planeBone3) == null)
			{
				EDAPHMJENPK = "_Offsets" + this.planeBone3.name + "";
				return true;
			}
			return false;
		}

		// Token: 0x0600F380 RID: 62336 RVA: 0x006D3A4B File Offset: 0x006D1C4B
		public IKSolver.Node NJNJMMLFNIL(IKSolverFullBody NBAKCIDALOF)
		{
			return NBAKCIDALOF.chain[this.chainIndex].nodes[this.nodeIndex];
		}

		// Token: 0x0600F381 RID: 62337 RVA: 0x006D603C File Offset: 0x006D423C
		private Quaternion PKCOHECPHCH(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 solverPosition = NBAKCIDALOF.CPFNEEGDKGP(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = NBAKCIDALOF.CPFNEEGDKGP(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = NBAKCIDALOF.CIAODBAIJMF(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Initiating IKSolver with null root Transform.", this.bone, true);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x04001FCF RID: 8143
		public Transform bone;

		// Token: 0x04001FD0 RID: 8144
		public Transform target;

		// Token: 0x04001FD1 RID: 8145
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04001FD2 RID: 8146
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04001FD3 RID: 8147
		public Vector3 position = Vector3.zero;

		// Token: 0x04001FD4 RID: 8148
		public Quaternion rotation = Quaternion.identity;

		// Token: 0x04001FD5 RID: 8149
		public Vector3 positionOffset;

		// Token: 0x04001FD7 RID: 8151
		public bool effectChildNodes = true;

		// Token: 0x04001FD8 RID: 8152
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		// Token: 0x04001FD9 RID: 8153
		public Transform[] childBones = new Transform[0];

		// Token: 0x04001FDA RID: 8154
		public Transform planeBone1;

		// Token: 0x04001FDB RID: 8155
		public Transform planeBone2;

		// Token: 0x04001FDC RID: 8156
		public Transform planeBone3;

		// Token: 0x04001FDD RID: 8157
		public Quaternion planeRotationOffset = Quaternion.identity;

		// Token: 0x04001FDE RID: 8158
		private float posW;

		// Token: 0x04001FDF RID: 8159
		private float rotW;

		// Token: 0x04001FE0 RID: 8160
		private Vector3[] localPositions = new Vector3[0];

		// Token: 0x04001FE1 RID: 8161
		private bool usePlaneNodes;

		// Token: 0x04001FE2 RID: 8162
		private Quaternion animatedPlaneRotation = Quaternion.identity;

		// Token: 0x04001FE3 RID: 8163
		private Vector3 animatedPosition;

		// Token: 0x04001FE4 RID: 8164
		private bool firstUpdate;

		// Token: 0x04001FE5 RID: 8165
		private int chainIndex = -1;

		// Token: 0x04001FE6 RID: 8166
		private int nodeIndex = -1;

		// Token: 0x04001FE7 RID: 8167
		private int plane1ChainIndex;

		// Token: 0x04001FE8 RID: 8168
		private int plane1NodeIndex = -1;

		// Token: 0x04001FE9 RID: 8169
		private int plane2ChainIndex = -1;

		// Token: 0x04001FEA RID: 8170
		private int plane2NodeIndex = -1;

		// Token: 0x04001FEB RID: 8171
		private int plane3ChainIndex = -1;

		// Token: 0x04001FEC RID: 8172
		private int plane3NodeIndex = -1;

		// Token: 0x04001FED RID: 8173
		private int[] childChainIndexes = new int[0];

		// Token: 0x04001FEE RID: 8174
		private int[] childNodeIndexes = new int[0];
	}
}
