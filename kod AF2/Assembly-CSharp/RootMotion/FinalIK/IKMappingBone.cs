using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000466 RID: 1126
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x0600F45A RID: 62554 RVA: 0x006D8917 File Offset: 0x006D6B17
		public void ILPGLEPAJLL()
		{
			this.boneMap.LLBLOIDHPAH(true);
		}

		// Token: 0x0600F45B RID: 62555 RVA: 0x006D8925 File Offset: 0x006D6B25
		public virtual bool KDPPOBOKOGD(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.FOMAAOAPDDO(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "-no result-";
				return false;
			}
			return true;
		}

		// Token: 0x0600F45C RID: 62556 RVA: 0x006D894B File Offset: 0x006D6B4B
		public virtual void FONNAJPJEIL(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.BHALELINNDJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F45D RID: 62557 RVA: 0x006D8972 File Offset: 0x006D6B72
		public virtual void IPEKLMKGKKB(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.MCPNEMBJHAM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F45E RID: 62558 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void CGNHGPEGLIF()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F45F RID: 62559 RVA: 0x006D89A6 File Offset: 0x006D6BA6
		public virtual bool FODJFEAAPGJ(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.FBJPAOJCPPA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "msgCancel";
				return false;
			}
			return false;
		}

		// Token: 0x0600F460 RID: 62560 RVA: 0x006D89CC File Offset: 0x006D6BCC
		public virtual bool KGGCPLPHBPN(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CELPINDCLAA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Hyperlink_";
				return true;
			}
			return true;
		}

		// Token: 0x0600F461 RID: 62561 RVA: 0x006D89F2 File Offset: 0x006D6BF2
		public virtual void LIAONJMLNMA(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.IHPLBCJCOPM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F462 RID: 62562 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void NGFHJOCHNPJ()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F463 RID: 62563 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void IEIILHHNBHC()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F464 RID: 62564 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void AENNNDIAPEO()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F465 RID: 62565 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void NCNLFJOFIEJ()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F466 RID: 62566 RVA: 0x006D8A26 File Offset: 0x006D6C26
		public virtual bool NGCJIJHNMNK(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.BGKDELKAGJI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "<color='#a060ff'>{0}</color>: {1}";
				return false;
			}
			return true;
		}

		// Token: 0x0600F467 RID: 62567 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void EEOICCBKEHD()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F468 RID: 62568 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void LCBCOCEEHJE(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F469 RID: 62569 RVA: 0x006D8A6E File Offset: 0x006D6C6E
		public void NBFLOCKKAGC()
		{
			this.boneMap.OBFPCCOCEAO();
		}

		// Token: 0x0600F46A RID: 62570 RVA: 0x006D8972 File Offset: 0x006D6B72
		public virtual void DHGHHKBMLFE(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.MCPNEMBJHAM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x006D8A7B File Offset: 0x006D6C7B
		public override void FOBBCFADGKP(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.FHDCCINOPJD(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F46C RID: 62572 RVA: 0x006D89F2 File Offset: 0x006D6BF2
		public virtual void CAPIPMILACA(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.IHPLBCJCOPM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F46D RID: 62573 RVA: 0x006D8AA2 File Offset: 0x006D6CA2
		public virtual bool ANBOFFNPNCP(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.BGKDELKAGJI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "crft_wpnpr";
				return true;
			}
			return true;
		}

		// Token: 0x0600F46E RID: 62574 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void KDJOOPDEGKP(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x006D8AC8 File Offset: 0x006D6CC8
		public void JJMPLOGNGMJ()
		{
			this.boneMap.EMCPHCMFIOE();
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x006D8AD5 File Offset: 0x006D6CD5
		public virtual bool HLPLDJJAIEB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CELPINDCLAA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Attempting to RefreshSceneDecals without a packed material";
				return false;
			}
			return false;
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x006D8AFB File Offset: 0x006D6CFB
		public void PMOGLICGPFF()
		{
			this.boneMap.AENNNDIAPEO();
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x006D8B08 File Offset: 0x006D6D08
		public virtual bool KMECLNKGJAN(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CELPINDCLAA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "wpn_dress2";
				return false;
			}
			return false;
		}

		// Token: 0x0600F473 RID: 62579 RVA: 0x006D8B2E File Offset: 0x006D6D2E
		public void HEJFHLPOOIJ(float CPGFBJGKGMF)
		{
			this.boneMap.MHFCPAGMBIP(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F474 RID: 62580 RVA: 0x006D8B43 File Offset: 0x006D6D43
		public void PKJAGLBIPHB()
		{
			this.boneMap.EDCNJACMDPE();
		}

		// Token: 0x0600F475 RID: 62581 RVA: 0x006D8B50 File Offset: 0x006D6D50
		public void OFLIOOOJPOK(float CPGFBJGKGMF)
		{
			this.boneMap.MEKODJABLHO(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F476 RID: 62582 RVA: 0x006D8917 File Offset: 0x006D6B17
		public void LADCPMDBMFE()
		{
			this.boneMap.LLBLOIDHPAH(true);
		}

		// Token: 0x0600F477 RID: 62583 RVA: 0x006D8B65 File Offset: 0x006D6D65
		public virtual bool OKMIMMMKBKO(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.DNIAGDMODBI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Arm Flex";
				return false;
			}
			return false;
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x006D8B8B File Offset: 0x006D6D8B
		public virtual bool AEJHBBOFKCJ(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.DPHFOGMGHLI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "_FogData2";
				return false;
			}
			return false;
		}

		// Token: 0x0600F479 RID: 62585 RVA: 0x006D8A6E File Offset: 0x006D6C6E
		public void FLJNJALCMPP()
		{
			this.boneMap.OBFPCCOCEAO();
		}

		// Token: 0x0600F47A RID: 62586 RVA: 0x006D8B2E File Offset: 0x006D6D2E
		public void ALEKPDEOAHL(float CPGFBJGKGMF)
		{
			this.boneMap.MHFCPAGMBIP(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F47B RID: 62587 RVA: 0x006D8BB1 File Offset: 0x006D6DB1
		public void LFJMEIKPAEJ()
		{
			this.boneMap.MPBFIELENJJ(false);
		}

		// Token: 0x0600F47C RID: 62588 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void KCFHDEOMKMM()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F47D RID: 62589 RVA: 0x006D8BBF File Offset: 0x006D6DBF
		public void BBMIPDANAGN()
		{
			this.boneMap.CABOMOMHPKB(false);
		}

		// Token: 0x0600F47E RID: 62590 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void NKCAHJFCLPD()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F47F RID: 62591 RVA: 0x006D8BCD File Offset: 0x006D6DCD
		public virtual bool HMCHENLMFPI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.FOMAAOAPDDO(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Bias";
				return false;
			}
			return true;
		}

		// Token: 0x0600F480 RID: 62592 RVA: 0x006D894B File Offset: 0x006D6B4B
		public virtual void CPLOFPNBFEH(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.BHALELINNDJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void NGLGAMHDIKE()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F482 RID: 62594 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void FJNFBDINNOO(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x006D8C00 File Offset: 0x006D6E00
		public virtual bool LEDFEHFJIPB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.MJJNKICHLFA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "_TurnReg.ogg";
				return true;
			}
			return false;
		}

		// Token: 0x0600F484 RID: 62596 RVA: 0x006D8C26 File Offset: 0x006D6E26
		public IKMappingBone()
		{
		}

		// Token: 0x0600F485 RID: 62597 RVA: 0x006D8C44 File Offset: 0x006D6E44
		public virtual void MLFAABAPOHI(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.OJKNMJEMKDP(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F486 RID: 62598 RVA: 0x006D8C6B File Offset: 0x006D6E6B
		public void PGLFOPLLBBI(float CPGFBJGKGMF)
		{
			this.boneMap.FOLPHINCIPA(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F487 RID: 62599 RVA: 0x006D8C80 File Offset: 0x006D6E80
		public void KBHFKJPNPHG()
		{
			this.boneMap.GIMGDNNGLDG();
		}

		// Token: 0x0600F488 RID: 62600 RVA: 0x006D8C44 File Offset: 0x006D6E44
		public virtual void NKECALBCKBA(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.OJKNMJEMKDP(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F489 RID: 62601 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void FANMDANNBAK(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F48A RID: 62602 RVA: 0x006D89F2 File Offset: 0x006D6BF2
		public virtual void KNEEBLNAGLM(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.IHPLBCJCOPM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F48B RID: 62603 RVA: 0x006D8BB1 File Offset: 0x006D6DB1
		public void JOGHIFGNEKO()
		{
			this.boneMap.MPBFIELENJJ(false);
		}

		// Token: 0x0600F48C RID: 62604 RVA: 0x006D894B File Offset: 0x006D6B4B
		public override void CKHKJOHKMEE(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.BHALELINNDJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F48D RID: 62605 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void AJMDGINBEEI()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F48E RID: 62606 RVA: 0x006D8C8D File Offset: 0x006D6E8D
		public virtual bool COOOKAEJIGI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "DropType";
				return true;
			}
			return true;
		}

		// Token: 0x0600F48F RID: 62607 RVA: 0x006D8BBF File Offset: 0x006D6DBF
		public void JDBHBELINNP()
		{
			this.boneMap.CABOMOMHPKB(false);
		}

		// Token: 0x0600F490 RID: 62608 RVA: 0x006D894B File Offset: 0x006D6B4B
		public override void NPCHHADBLMC(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.BHALELINNDJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F491 RID: 62609 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void FKEILHDJBLF()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x006D89F2 File Offset: 0x006D6BF2
		public override void MLEBBNKPKKF(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.IHPLBCJCOPM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F493 RID: 62611 RVA: 0x006D8CB3 File Offset: 0x006D6EB3
		public IKMappingBone(Transform FBKEODHEMMH)
		{
			this.bone = FBKEODHEMMH;
		}

		// Token: 0x0600F494 RID: 62612 RVA: 0x006D8B43 File Offset: 0x006D6D43
		public void CGDMIIDPELA()
		{
			this.boneMap.EDCNJACMDPE();
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x006D8CD8 File Offset: 0x006D6ED8
		public override bool CHFHJDFDIGB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "IKMappingBone's bone is null.";
				return false;
			}
			return true;
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x006D8A6E File Offset: 0x006D6C6E
		public void PJCKNDKFLMH()
		{
			this.boneMap.OBFPCCOCEAO();
		}

		// Token: 0x0600F497 RID: 62615 RVA: 0x006D8B43 File Offset: 0x006D6D43
		public void IHBMPECFEAF()
		{
			this.boneMap.EDCNJACMDPE();
		}

		// Token: 0x0600F498 RID: 62616 RVA: 0x006D8CFE File Offset: 0x006D6EFE
		public void COOFIMMOEHA()
		{
			this.boneMap.HLEOFGAAOFN();
		}

		// Token: 0x0600F499 RID: 62617 RVA: 0x006D8B2E File Offset: 0x006D6D2E
		public void PLIDBEMMALJ(float CPGFBJGKGMF)
		{
			this.boneMap.MHFCPAGMBIP(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F49A RID: 62618 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void GKEEPAOGMKG()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F49B RID: 62619 RVA: 0x006D8D0B File Offset: 0x006D6F0B
		public virtual void OECNHGIPNLB(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.KNEEBLNAGLM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F49C RID: 62620 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void ELPKLDHHCLL()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F49D RID: 62621 RVA: 0x006D8CFE File Offset: 0x006D6EFE
		public void INHKOKPEKAL()
		{
			this.boneMap.HLEOFGAAOFN();
		}

		// Token: 0x0600F49E RID: 62622 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void CIKPFGCNOEL()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F49F RID: 62623 RVA: 0x006D8D32 File Offset: 0x006D6F32
		public virtual bool LFKIOLIKJOO(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.BLOEHCJCFEK(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "StaffStand";
				return true;
			}
			return true;
		}

		// Token: 0x0600F4A0 RID: 62624 RVA: 0x006D8D58 File Offset: 0x006D6F58
		public void LPEPNHCEBBE()
		{
			this.boneMap.LLBLOIDHPAH(false);
		}

		// Token: 0x0600F4A1 RID: 62625 RVA: 0x006D8AC8 File Offset: 0x006D6CC8
		public void CKNBMMEPJKP()
		{
			this.boneMap.EMCPHCMFIOE();
		}

		// Token: 0x0600F4A2 RID: 62626 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void FGBCANJFNOC()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F4A3 RID: 62627 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void KCIEEGIHNDG(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x006D8C44 File Offset: 0x006D6E44
		public virtual void CBHCMFJCMPL(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.OJKNMJEMKDP(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4A5 RID: 62629 RVA: 0x006D8AC8 File Offset: 0x006D6CC8
		public void KNICENMKBJL()
		{
			this.boneMap.EMCPHCMFIOE();
		}

		// Token: 0x0600F4A6 RID: 62630 RVA: 0x006D8B50 File Offset: 0x006D6D50
		public void KIMKMHNGIGC(float CPGFBJGKGMF)
		{
			this.boneMap.MEKODJABLHO(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4A7 RID: 62631 RVA: 0x006D8A6E File Offset: 0x006D6C6E
		public void BMCNECDKFJE()
		{
			this.boneMap.OBFPCCOCEAO();
		}

		// Token: 0x0600F4A8 RID: 62632 RVA: 0x006D8D66 File Offset: 0x006D6F66
		public void BLOEEPCIPKJ()
		{
			this.boneMap.MKDGKDPKLBL(false);
		}

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x006D8D74 File Offset: 0x006D6F74
		public virtual bool EGKCHKFNAPG(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.OECJJLKPHPP(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Ball";
				return true;
			}
			return false;
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void APLAOLIPGLJ()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F4AB RID: 62635 RVA: 0x006D894B File Offset: 0x006D6B4B
		public override void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.BHALELINNDJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4AC RID: 62636 RVA: 0x006D8D9A File Offset: 0x006D6F9A
		public virtual bool CKHNENDFKFF(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.MJJNKICHLFA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "Original lives count: ";
				return false;
			}
			return false;
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x006D8CFE File Offset: 0x006D6EFE
		public void PGDHJEGKAON()
		{
			this.boneMap.HLEOFGAAOFN();
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x006D8DC0 File Offset: 0x006D6FC0
		public virtual bool BEJJCJCLIOE(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.CHFHJDFDIGB(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "OfficeSittingMouseMovement";
				return true;
			}
			return false;
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void PILHPBLFNGK()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x006D8DE6 File Offset: 0x006D6FE6
		public void BIECFPGBEMF()
		{
			this.boneMap.CABOMOMHPKB(true);
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x006D8DF4 File Offset: 0x006D6FF4
		public void HADFIBKJGOO()
		{
			this.boneMap.MPBFIELENJJ(true);
		}

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x006D8E02 File Offset: 0x006D7002
		public override bool BGKDELKAGJI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.DNIAGDMODBI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "twist";
				return false;
			}
			return false;
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x006D8DE6 File Offset: 0x006D6FE6
		public void OECEGIAKPHD()
		{
			this.boneMap.CABOMOMHPKB(true);
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void BGCCCDLFDAL()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F4B5 RID: 62645 RVA: 0x006D8A7B File Offset: 0x006D6C7B
		public virtual void LHOEOFKKAKK(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.FHDCCINOPJD(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4B6 RID: 62646 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void JKLAKFOLEBJ()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F4B7 RID: 62647 RVA: 0x006D8E28 File Offset: 0x006D7028
		public virtual bool GGALELCCKAL(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.FOMAAOAPDDO(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "MENU.WAV";
				return true;
			}
			return false;
		}

		// Token: 0x0600F4B8 RID: 62648 RVA: 0x006D8DE6 File Offset: 0x006D6FE6
		public void MNGMAJCDDFJ()
		{
			this.boneMap.CABOMOMHPKB(true);
		}

		// Token: 0x0600F4B9 RID: 62649 RVA: 0x006D8A6E File Offset: 0x006D6C6E
		public void JLCCNJOKOIL()
		{
			this.boneMap.OBFPCCOCEAO();
		}

		// Token: 0x0600F4BA RID: 62650 RVA: 0x006D8D66 File Offset: 0x006D6F66
		public void DGACPEEIKCG()
		{
			this.boneMap.MKDGKDPKLBL(false);
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x006D8972 File Offset: 0x006D6B72
		public virtual void OFAOOMGEFEO(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.MCPNEMBJHAM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4BC RID: 62652 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void ENDMPKJAIPN()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x006D8C80 File Offset: 0x006D6E80
		public void KADIPEPGAAF()
		{
			this.boneMap.GIMGDNNGLDG();
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x006D8E4E File Offset: 0x006D704E
		public void NFEAAPAAGEC()
		{
			this.boneMap.MKDGKDPKLBL(true);
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void OPDDEGOEHNC()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F4C0 RID: 62656 RVA: 0x006D8B2E File Offset: 0x006D6D2E
		public void PAACCGCJPGO(float CPGFBJGKGMF)
		{
			this.boneMap.MHFCPAGMBIP(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4C1 RID: 62657 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void EMNIJEECHLM()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x006D8A7B File Offset: 0x006D6C7B
		public virtual void HFEGAPPEBLM(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.FHDCCINOPJD(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x006D8E5C File Offset: 0x006D705C
		public virtual bool GJNJIAMOFOM(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.MJJNKICHLFA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "_Texture";
				return true;
			}
			return false;
		}

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x006D8DF4 File Offset: 0x006D6FF4
		public void ECNNMOIINLI()
		{
			this.boneMap.MPBFIELENJJ(true);
		}

		// Token: 0x0600F4C5 RID: 62661 RVA: 0x006D8BB1 File Offset: 0x006D6DB1
		public void KGJOIBELOGC()
		{
			this.boneMap.MPBFIELENJJ(false);
		}

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x006D8E82 File Offset: 0x006D7082
		public virtual bool IJBNGDMCBLI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.DPHFOGMGHLI(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = " Waypoint Target";
				return true;
			}
			return true;
		}

		// Token: 0x0600F4C7 RID: 62663 RVA: 0x006D8A19 File Offset: 0x006D6C19
		public void IJDBIFNPPHP()
		{
			this.boneMap.NNGBMKILKNJ();
		}

		// Token: 0x0600F4C8 RID: 62664 RVA: 0x006D8EA8 File Offset: 0x006D70A8
		public virtual bool KFGNFGKMCEB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.MJJNKICHLFA(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return true;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "HookPoint";
				return false;
			}
			return true;
		}

		// Token: 0x0600F4C9 RID: 62665 RVA: 0x006D8A4C File Offset: 0x006D6C4C
		public void KNOIDGCLAIF()
		{
			this.boneMap.FGBCANJFNOC();
		}

		// Token: 0x0600F4CA RID: 62666 RVA: 0x006D8C80 File Offset: 0x006D6E80
		public void OCBGKLMHFCF()
		{
			this.boneMap.GIMGDNNGLDG();
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x006D8B50 File Offset: 0x006D6D50
		public void DJGJOIIEKOP(float CPGFBJGKGMF)
		{
			this.boneMap.MEKODJABLHO(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x006D8C6B File Offset: 0x006D6E6B
		public void IGEJKNLHMAA(float CPGFBJGKGMF)
		{
			this.boneMap.FOLPHINCIPA(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void AEKPIHEFODD()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x006D8ECE File Offset: 0x006D70CE
		public virtual void AJDIAOBHOFB(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.AOMIADLDLEJ(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x006D8999 File Offset: 0x006D6B99
		public void LFPEKNFIDOK()
		{
			this.boneMap.MNJDNCNLCJO();
		}

		// Token: 0x0600F4D0 RID: 62672 RVA: 0x006D8D0B File Offset: 0x006D6F0B
		public virtual void INMOJKOEPEH(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.KNEEBLNAGLM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4D1 RID: 62673 RVA: 0x006D8B2E File Offset: 0x006D6D2E
		public void OHLAJEPBANP(float CPGFBJGKGMF)
		{
			this.boneMap.MHFCPAGMBIP(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4D2 RID: 62674 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void GEHFDOCHCEA(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4D3 RID: 62675 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void MAJONKMDJIB()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x0600F4D4 RID: 62676 RVA: 0x006D8D0B File Offset: 0x006D6F0B
		public virtual void KPNKIOOPEMM(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.KNEEBLNAGLM(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x006D8EF5 File Offset: 0x006D70F5
		public virtual bool JCLOIKEEAFO(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			if (!base.BLOEHCJCFEK(NBAKCIDALOF, ref EDAPHMJENPK))
			{
				return false;
			}
			if (this.bone == null)
			{
				EDAPHMJENPK = "INTERFACE";
				return true;
			}
			return false;
		}

		// Token: 0x0600F4D6 RID: 62678 RVA: 0x006D8A7B File Offset: 0x006D6C7B
		public virtual void HMNPKENDIPF(IKSolverFullBody NBAKCIDALOF)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.FHDCCINOPJD(this.bone, NBAKCIDALOF);
		}

		// Token: 0x0600F4D7 RID: 62679 RVA: 0x006D8A59 File Offset: 0x006D6C59
		public void KOGOPKOHMED(float CPGFBJGKGMF)
		{
			this.boneMap.DKAEKNGDLFK(CPGFBJGKGMF * this.maintainRotationWeight);
		}

		// Token: 0x0600F4D8 RID: 62680 RVA: 0x006D8D58 File Offset: 0x006D6F58
		public void MGIGIDDKKEI()
		{
			this.boneMap.LLBLOIDHPAH(false);
		}

		// Token: 0x0600F4D9 RID: 62681 RVA: 0x006D8DF4 File Offset: 0x006D6FF4
		public void CLKGDLFCLIL()
		{
			this.boneMap.MPBFIELENJJ(true);
		}

		// Token: 0x0600F4DA RID: 62682 RVA: 0x006D8BF3 File Offset: 0x006D6DF3
		public void ALDBKKCEFHD()
		{
			this.boneMap.BNIFPFDCHGB();
		}

		// Token: 0x04002005 RID: 8197
		public Transform bone;

		// Token: 0x04002006 RID: 8198
		[Range(0f, 1f)]
		public float maintainRotationWeight = 1f;

		// Token: 0x04002007 RID: 8199
		private IKMapping.BoneMap boneMap = new IKMapping.BoneMap();
	}
}
