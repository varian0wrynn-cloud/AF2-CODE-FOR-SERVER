using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000467 RID: 1127
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x0600F4DB RID: 62683 RVA: 0x006D8F1C File Offset: 0x006D711C
		public void OFLIOOOJPOK(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (HNDEMAAEHKA && this.parentBone != null)
			{
				this.boneMapParent.EIOHPCCECDF(NBAKCIDALOF.OODFEEFPAHG(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
			}
			this.boneMap1.ONIOOHCIMCM(NBAKCIDALOF, this.weight);
			this.boneMap2.ONIOOHCIMCM(NBAKCIDALOF, this.weight);
			this.boneMap3.MEKODJABLHO(this.maintainRotationWeight * this.weight * NBAKCIDALOF.IKPositionWeight);
			this.boneMap3.CMJOHIPLCNN(NBAKCIDALOF, this.weight);
		}

		// Token: 0x0600F4DC RID: 62684 RVA: 0x006D8FD0 File Offset: 0x006D71D0
		public void MBLOPPHFKKN()
		{
			this.boneMap1.GOJBPOLCDCN(false, false);
			this.boneMap2.GCLDMFEJHPL(false, false);
			this.weight = Mathf.Clamp(this.weight, 1341f, 1482f);
			this.boneMap3.HLEOFGAAOFN();
		}

		// Token: 0x0600F4DD RID: 62685 RVA: 0x006D9020 File Offset: 0x006D7220
		public IKMappingLimb(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform OPPOCPMMHHO = null)
		{
			this.DLJHEBPABFF(FCDAMCBKONG, GLGMAJBNFIA, NLHIDOGKOIP, OPPOCPMMHHO);
		}

		// Token: 0x0600F4DE RID: 62686 RVA: 0x006D9075 File Offset: 0x006D7275
		public void EJKOMEDJJPB()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.OBFPCCOCEAO();
			}
			this.boneMap1.FGBCANJFNOC();
			this.boneMap2.FGBCANJFNOC();
			this.boneMap3.NNGBMKILKNJ();
		}

		// Token: 0x0600F4DF RID: 62687 RVA: 0x006D90B4 File Offset: 0x006D72B4
		public virtual void OECNHGIPNLB(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMapParent == null)
			{
				this.boneMapParent = new IKMapping.BoneMap();
			}
			if (this.boneMap1 == null)
			{
				this.boneMap1 = new IKMapping.BoneMap();
			}
			if (this.boneMap2 == null)
			{
				this.boneMap2 = new IKMapping.BoneMap();
			}
			if (this.boneMap3 == null)
			{
				this.boneMap3 = new IKMapping.BoneMap();
			}
			if (this.parentBone != null)
			{
				this.boneMapParent.OJKNMJEMKDP(this.parentBone, NBAKCIDALOF);
			}
			this.boneMap1.BHALELINNDJ(this.bone1, NBAKCIDALOF);
			this.boneMap2.KNEEBLNAGLM(this.bone2, NBAKCIDALOF);
			this.boneMap3.AOMIADLDLEJ(this.bone3, NBAKCIDALOF);
			this.boneMap1.HPNJHJKELFK(NBAKCIDALOF, this.boneMap1.transform, this.boneMap2.transform, this.boneMap3.transform);
			this.boneMap2.FOGLIPMPBJM(NBAKCIDALOF, this.boneMap2.transform, this.boneMap3.transform, this.boneMap1.transform);
			if (this.parentBone != null)
			{
				this.boneMapParent.NIEDHJOEMIK(this.boneMap1);
			}
		}

		// Token: 0x0600F4E0 RID: 62688 RVA: 0x006D91DC File Offset: 0x006D73DC
		public virtual bool CHJAMEPPEOI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK) && (!base.MHBIEEKHBCC(this.bone1, NBAKCIDALOF, ref EDAPHMJENPK, null) || !base.EJKNLGLFCCO(this.bone2, NBAKCIDALOF, ref EDAPHMJENPK, null) || !base.EJKNLGLFCCO(this.bone3, NBAKCIDALOF, ref EDAPHMJENPK, null));
		}

		// Token: 0x0600F4E1 RID: 62689 RVA: 0x006D922F File Offset: 0x006D742F
		public void FGBCANJFNOC()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.FGBCANJFNOC();
			}
			this.boneMap1.FGBCANJFNOC();
			this.boneMap2.FGBCANJFNOC();
			this.boneMap3.FGBCANJFNOC();
		}

		// Token: 0x0600F4E2 RID: 62690 RVA: 0x006D926B File Offset: 0x006D746B
		public void PHNEPJGLBJD(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform OPPOCPMMHHO = null)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
			this.parentBone = OPPOCPMMHHO;
		}

		// Token: 0x0600F4E3 RID: 62691 RVA: 0x006D928C File Offset: 0x006D748C
		public IKMapping.BoneMap JLKOJIPLFIF(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("fshop_btn2", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x006D92E8 File Offset: 0x006D74E8
		public override void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMapParent == null)
			{
				this.boneMapParent = new IKMapping.BoneMap();
			}
			if (this.boneMap1 == null)
			{
				this.boneMap1 = new IKMapping.BoneMap();
			}
			if (this.boneMap2 == null)
			{
				this.boneMap2 = new IKMapping.BoneMap();
			}
			if (this.boneMap3 == null)
			{
				this.boneMap3 = new IKMapping.BoneMap();
			}
			if (this.parentBone != null)
			{
				this.boneMapParent.BHALELINNDJ(this.parentBone, NBAKCIDALOF);
			}
			this.boneMap1.BHALELINNDJ(this.bone1, NBAKCIDALOF);
			this.boneMap2.BHALELINNDJ(this.bone2, NBAKCIDALOF);
			this.boneMap3.BHALELINNDJ(this.bone3, NBAKCIDALOF);
			this.boneMap1.HPNJHJKELFK(NBAKCIDALOF, this.boneMap1.transform, this.boneMap2.transform, this.boneMap3.transform);
			this.boneMap2.HPNJHJKELFK(NBAKCIDALOF, this.boneMap2.transform, this.boneMap3.transform, this.boneMap1.transform);
			if (this.parentBone != null)
			{
				this.boneMapParent.MMHIOMOHLDD(this.boneMap1);
			}
		}

		// Token: 0x0600F4E5 RID: 62693 RVA: 0x006D9410 File Offset: 0x006D7610
		public IKMapping.BoneMap HIGFJLLCBCP(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("wpn_rem3", this.bone1, true);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4E6 RID: 62694 RVA: 0x006D946C File Offset: 0x006D766C
		public void AACMGNDNNIM(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (this.weight <= 392f)
			{
				return;
			}
			if (HNDEMAAEHKA && this.parentBone != null)
			{
				this.boneMapParent.LPKOCKMPLAM(NBAKCIDALOF.KNFBJEGGIKP(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
			}
			this.boneMap1.JPMLPIDHMMH(NBAKCIDALOF, this.weight);
			this.boneMap2.AKPIIBCFGCM(NBAKCIDALOF, this.weight);
			this.boneMap3.MHFCPAGMBIP(this.maintainRotationWeight * this.weight * NBAKCIDALOF.IKPositionWeight);
			this.boneMap3.JPAGKICFBFM(NBAKCIDALOF, this.weight);
		}

		// Token: 0x0600F4E7 RID: 62695 RVA: 0x006D951F File Offset: 0x006D771F
		public void AENNNDIAPEO()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.NNGBMKILKNJ();
			}
			this.boneMap1.FGBCANJFNOC();
			this.boneMap2.FGBCANJFNOC();
			this.boneMap3.AENNNDIAPEO();
		}

		// Token: 0x0600F4E8 RID: 62696 RVA: 0x006D926B File Offset: 0x006D746B
		public void GEKBDFCLJLH(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform OPPOCPMMHHO = null)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
			this.parentBone = OPPOCPMMHHO;
		}

		// Token: 0x0600F4E9 RID: 62697 RVA: 0x006D955B File Offset: 0x006D775B
		public void ACJOAAMMIIJ()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.OBFPCCOCEAO();
			}
			this.boneMap1.NNGBMKILKNJ();
			this.boneMap2.NNGBMKILKNJ();
			this.boneMap3.OBFPCCOCEAO();
		}

		// Token: 0x0600F4EA RID: 62698 RVA: 0x006D9598 File Offset: 0x006D7798
		public IKMapping.BoneMap DNAPKCGHOLG(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4EB RID: 62699 RVA: 0x006D95F4 File Offset: 0x006D77F4
		public IKMapping.BoneMap DAGHLOIIPDO(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("This limb does not have a parent (shoulder) bone", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4EC RID: 62700 RVA: 0x006D9650 File Offset: 0x006D7850
		public virtual void BABDKIBBLAD(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMapParent == null)
			{
				this.boneMapParent = new IKMapping.BoneMap();
			}
			if (this.boneMap1 == null)
			{
				this.boneMap1 = new IKMapping.BoneMap();
			}
			if (this.boneMap2 == null)
			{
				this.boneMap2 = new IKMapping.BoneMap();
			}
			if (this.boneMap3 == null)
			{
				this.boneMap3 = new IKMapping.BoneMap();
			}
			if (this.parentBone != null)
			{
				this.boneMapParent.MCPNEMBJHAM(this.parentBone, NBAKCIDALOF);
			}
			this.boneMap1.OJKNMJEMKDP(this.bone1, NBAKCIDALOF);
			this.boneMap2.IHPLBCJCOPM(this.bone2, NBAKCIDALOF);
			this.boneMap3.OJKNMJEMKDP(this.bone3, NBAKCIDALOF);
			this.boneMap1.KLFNDKHFEAB(NBAKCIDALOF, this.boneMap1.transform, this.boneMap2.transform, this.boneMap3.transform);
			this.boneMap2.ANMCLNFADJI(NBAKCIDALOF, this.boneMap2.transform, this.boneMap3.transform, this.boneMap1.transform);
			if (this.parentBone != null)
			{
				this.boneMapParent.MEDPDKOAKDP(this.boneMap1);
			}
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x006D9778 File Offset: 0x006D7978
		public void CDPCOFKFDNO()
		{
			this.boneMap1.EPGPDDHNNKN(true, true);
			this.boneMap2.JEDPGKFDGLK(true, false);
			this.weight = Mathf.Clamp(this.weight, 633f, 162f);
			this.boneMap3.MNJDNCNLCJO();
		}

		// Token: 0x0600F4EE RID: 62702 RVA: 0x006D97C8 File Offset: 0x006D79C8
		public override bool CHFHJDFDIGB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK) && base.FPONBGIJKIA(this.bone1, NBAKCIDALOF, ref EDAPHMJENPK, null) && base.FPONBGIJKIA(this.bone2, NBAKCIDALOF, ref EDAPHMJENPK, null) && base.FPONBGIJKIA(this.bone3, NBAKCIDALOF, ref EDAPHMJENPK, null);
		}

		// Token: 0x0600F4EF RID: 62703 RVA: 0x006D926B File Offset: 0x006D746B
		public void DLJHEBPABFF(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform OPPOCPMMHHO = null)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
			this.parentBone = OPPOCPMMHHO;
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x006D981B File Offset: 0x006D7A1B
		public void BLOEEPCIPKJ()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.MKDGKDPKLBL(false);
			}
			this.boneMap1.MKDGKDPKLBL(true);
			this.boneMap2.MKDGKDPKLBL(false);
			this.boneMap3.MKDGKDPKLBL(false);
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x006D985B File Offset: 0x006D7A5B
		public void OECEGIAKPHD()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.LLBLOIDHPAH(true);
			}
			this.boneMap1.MPBFIELENJJ(true);
			this.boneMap2.CABOMOMHPKB(true);
			this.boneMap3.LLBLOIDHPAH(false);
		}

		// Token: 0x0600F4F2 RID: 62706 RVA: 0x006D989C File Offset: 0x006D7A9C
		public virtual bool EBLGKLPNEBL(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return base.EJMDBNJCBHB(NBAKCIDALOF, ref EDAPHMJENPK) && (!base.CBOECAGIEPB(this.bone1, NBAKCIDALOF, ref EDAPHMJENPK, null) || (base.NEHDCFNHIOH(this.bone2, NBAKCIDALOF, ref EDAPHMJENPK, null) && base.NHIOKPOCDCG(this.bone3, NBAKCIDALOF, ref EDAPHMJENPK, null)));
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x006D98F0 File Offset: 0x006D7AF0
		public void CNFNMEKILGK(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -DENLOFEMFGC));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -CNFCKOGPPFO));
		}

		// Token: 0x0600F4F4 RID: 62708 RVA: 0x006D99B4 File Offset: 0x006D7BB4
		public void NICOAHFBPNO(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -DENLOFEMFGC));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -CNFCKOGPPFO));
		}

		// Token: 0x0600F4F5 RID: 62709 RVA: 0x006D9A78 File Offset: 0x006D7C78
		public void PEBKAPJGHCE(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (this.weight <= 582f)
			{
				return;
			}
			if (HNDEMAAEHKA && this.parentBone != null)
			{
				this.boneMapParent.LPKOCKMPLAM(NBAKCIDALOF.CPFNEEGDKGP(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
			}
			this.boneMap1.JPMLPIDHMMH(NBAKCIDALOF, this.weight);
			this.boneMap2.JPMLPIDHMMH(NBAKCIDALOF, this.weight);
			this.boneMap3.MHFCPAGMBIP(this.maintainRotationWeight * this.weight * NBAKCIDALOF.IKPositionWeight);
			this.boneMap3.AHOOGMHDIAE(NBAKCIDALOF, this.weight);
		}

		// Token: 0x0600F4F6 RID: 62710 RVA: 0x006D9B2C File Offset: 0x006D7D2C
		public virtual void JDNJBDBHDHM(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMapParent == null)
			{
				this.boneMapParent = new IKMapping.BoneMap();
			}
			if (this.boneMap1 == null)
			{
				this.boneMap1 = new IKMapping.BoneMap();
			}
			if (this.boneMap2 == null)
			{
				this.boneMap2 = new IKMapping.BoneMap();
			}
			if (this.boneMap3 == null)
			{
				this.boneMap3 = new IKMapping.BoneMap();
			}
			if (this.parentBone != null)
			{
				this.boneMapParent.KNEEBLNAGLM(this.parentBone, NBAKCIDALOF);
			}
			this.boneMap1.BHALELINNDJ(this.bone1, NBAKCIDALOF);
			this.boneMap2.FHDCCINOPJD(this.bone2, NBAKCIDALOF);
			this.boneMap3.KNEEBLNAGLM(this.bone3, NBAKCIDALOF);
			this.boneMap1.FOGLIPMPBJM(NBAKCIDALOF, this.boneMap1.transform, this.boneMap2.transform, this.boneMap3.transform);
			this.boneMap2.KLFNDKHFEAB(NBAKCIDALOF, this.boneMap2.transform, this.boneMap3.transform, this.boneMap1.transform);
			if (this.parentBone != null)
			{
				this.boneMapParent.NIEDHJOEMIK(this.boneMap1);
			}
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x006D9C54 File Offset: 0x006D7E54
		public virtual bool KGGCPLPHBPN(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return base.DPHFOGMGHLI(NBAKCIDALOF, ref EDAPHMJENPK) && (!base.EJKNLGLFCCO(this.bone1, NBAKCIDALOF, ref EDAPHMJENPK, null) || !base.BEGIHEODOJG(this.bone2, NBAKCIDALOF, ref EDAPHMJENPK, null) || (!base.BIEFLGPOEGK(this.bone3, NBAKCIDALOF, ref EDAPHMJENPK, null) && false));
		}

		// Token: 0x0600F4F8 RID: 62712 RVA: 0x006D9CA8 File Offset: 0x006D7EA8
		public IKMapping.BoneMap FGDBMBALEBD(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED(" iterations for read and write", this.bone1, true);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4F9 RID: 62713 RVA: 0x006D9D03 File Offset: 0x006D7F03
		public void NNGBMKILKNJ()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.AENNNDIAPEO();
			}
			this.boneMap1.AENNNDIAPEO();
			this.boneMap2.AENNNDIAPEO();
			this.boneMap3.OBFPCCOCEAO();
		}

		// Token: 0x0600F4FA RID: 62714 RVA: 0x006D9D3F File Offset: 0x006D7F3F
		public IKMappingLimb()
		{
		}

		// Token: 0x0600F4FB RID: 62715 RVA: 0x006D9D80 File Offset: 0x006D7F80
		public IKMapping.BoneMap AFINOBGNKEH(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("close", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x006D9DDC File Offset: 0x006D7FDC
		public void MHPNDBHEFKC()
		{
			this.boneMap1.GCLDMFEJHPL(false, false);
			this.boneMap2.ENAMNBOEMBD(true, true);
			this.weight = Mathf.Clamp(this.weight, 1748f, 1776f);
			this.boneMap3.EDCNJACMDPE();
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x006D9E2C File Offset: 0x006D802C
		public IKMapping.BoneMap DAIPGIMFNOG(IKMappingLimb.BoneMapType HKEKBKOOGJC)
		{
			switch (HKEKBKOOGJC)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					PMCOMMEEGMC.ICAFGKHAAED("#000000", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x0600F4FE RID: 62718 RVA: 0x006D9E88 File Offset: 0x006D8088
		public override bool DNIAGDMODBI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return base.DPHFOGMGHLI(NBAKCIDALOF, ref EDAPHMJENPK) && base.CBOECAGIEPB(this.bone1, NBAKCIDALOF, ref EDAPHMJENPK, null) && base.BIEFLGPOEGK(this.bone2, NBAKCIDALOF, ref EDAPHMJENPK, null) && !base.BIEFLGPOEGK(this.bone3, NBAKCIDALOF, ref EDAPHMJENPK, null) && false;
		}

		// Token: 0x0600F4FF RID: 62719 RVA: 0x006D9EDC File Offset: 0x006D80DC
		public void MMPLENINHII(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (this.weight <= 1688f)
			{
				return;
			}
			if (HNDEMAAEHKA && this.parentBone != null)
			{
				this.boneMapParent.ABDGDFJHLEI(NBAKCIDALOF.HDEJBHNJOAF(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
			}
			this.boneMap1.AKPIIBCFGCM(NBAKCIDALOF, this.weight);
			this.boneMap2.PCKEODJKPOH(NBAKCIDALOF, this.weight);
			this.boneMap3.DKAEKNGDLFK(this.maintainRotationWeight * this.weight * NBAKCIDALOF.IKPositionWeight);
			this.boneMap3.LELBOMJIICB(NBAKCIDALOF, this.weight);
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x006D9F8F File Offset: 0x006D818F
		public void IGBAJPEIMKI()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.FGBCANJFNOC();
			}
			this.boneMap1.FGBCANJFNOC();
			this.boneMap2.AENNNDIAPEO();
			this.boneMap3.NNGBMKILKNJ();
		}

		// Token: 0x0600F501 RID: 62721 RVA: 0x006D9FCC File Offset: 0x006D81CC
		public void HPCHIONEBBD(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -DENLOFEMFGC));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -CNFCKOGPPFO));
		}

		// Token: 0x0600F502 RID: 62722 RVA: 0x006DA090 File Offset: 0x006D8290
		public void NFPIBODCGOK(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -DENLOFEMFGC));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -CNFCKOGPPFO));
		}

		// Token: 0x0600F503 RID: 62723 RVA: 0x006DA154 File Offset: 0x006D8354
		public void BHEMBCPPIPH(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -DENLOFEMFGC));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -CNFCKOGPPFO));
		}

		// Token: 0x0600F504 RID: 62724 RVA: 0x006DA218 File Offset: 0x006D8418
		public void FJAJLJOIPLO(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (this.weight <= 222f)
			{
				return;
			}
			if (HNDEMAAEHKA && this.parentBone != null)
			{
				this.boneMapParent.ABDGDFJHLEI(NBAKCIDALOF.LGOHEPAGHJG(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
			}
			this.boneMap1.PCKEODJKPOH(NBAKCIDALOF, this.weight);
			this.boneMap2.AKPIIBCFGCM(NBAKCIDALOF, this.weight);
			this.boneMap3.DKAEKNGDLFK(this.maintainRotationWeight * this.weight * NBAKCIDALOF.IKPositionWeight);
			this.boneMap3.JPAGKICFBFM(NBAKCIDALOF, this.weight);
		}

		// Token: 0x0600F505 RID: 62725 RVA: 0x006DA2CC File Offset: 0x006D84CC
		public void JKLAKFOLEBJ()
		{
			this.boneMap1.HACCFIMPMHM(true, true);
			this.boneMap2.HACCFIMPMHM(true, false);
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			this.boneMap3.BNIFPFDCHGB();
		}

		// Token: 0x0600F506 RID: 62726 RVA: 0x006D926B File Offset: 0x006D746B
		public void FDAHICPNMKH(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform OPPOCPMMHHO = null)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
			this.parentBone = OPPOCPMMHHO;
		}

		// Token: 0x04002008 RID: 8200
		public Transform parentBone;

		// Token: 0x04002009 RID: 8201
		public Transform bone1;

		// Token: 0x0400200A RID: 8202
		public Transform bone2;

		// Token: 0x0400200B RID: 8203
		public Transform bone3;

		// Token: 0x0400200C RID: 8204
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x0400200D RID: 8205
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x0400200E RID: 8206
		private IKMapping.BoneMap boneMapParent = new IKMapping.BoneMap();

		// Token: 0x0400200F RID: 8207
		private IKMapping.BoneMap boneMap1 = new IKMapping.BoneMap();

		// Token: 0x04002010 RID: 8208
		private IKMapping.BoneMap boneMap2 = new IKMapping.BoneMap();

		// Token: 0x04002011 RID: 8209
		private IKMapping.BoneMap boneMap3 = new IKMapping.BoneMap();

		// Token: 0x02000468 RID: 1128
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x04002013 RID: 8211
			Parent,
			// Token: 0x04002014 RID: 8212
			Bone1,
			// Token: 0x04002015 RID: 8213
			Bone2,
			// Token: 0x04002016 RID: 8214
			Bone3
		}
	}
}
