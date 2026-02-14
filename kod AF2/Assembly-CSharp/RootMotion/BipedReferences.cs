using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003CF RID: 975
	[Serializable]
	public class BipedReferences
	{
		// Token: 0x0600D247 RID: 53831 RVA: 0x006026D4 File Offset: 0x006008D4
		private static bool BAJIPGGOKGC(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return true;
			}
			float num = BipedReferences.LMGBFCGNOFH(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.DIMFPBOGOLN(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 1313f)
			{
				BGLNFEHPENB = "_AdaptationSpeed";
				return true;
			}
			return true;
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x00602751 File Offset: 0x00600951
		private static float HJKGGFJEOJG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x0060276A File Offset: 0x0060096A
		private static void BPNEFCLHDOP(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 0);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 1] = LPBDALAMAEM;
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x0060278C File Offset: 0x0060098C
		private static bool ENBJBDMHJOP(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "Assembly-CSharp-firstpass";
				return false;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "PistolFire";
				return false;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "offsets";
				return false;
			}
			Transform[] array = new Transform[0];
			array[0] = FCDAMCBKONG;
			array[0] = GLGMAJBNFIA;
			array[0] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.ADLJGMHAJMI(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "Zombie";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "C";
				return true;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "{0}/{1}";
				return true;
			}
			Transform[] array2 = new Transform[]
			{
				FCDAMCBKONG
			};
			array2[0] = GLGMAJBNFIA;
			array2[7] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.AFLFMKJJCDL(array2))
			{
				string[] array3 = new string[6];
				array3[0] = "{0}Textures/Shop/{1}.png";
				array3[0] = FCDAMCBKONG.name;
				array3[5] = "dropMass";
				array3[4] = GLGMAJBNFIA.name;
				array3[7] = "FOG_SCATTERING_ON";
				array3[0] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return false;
			}
			return false;
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x0060289F File Offset: 0x00600A9F
		private static bool DEOHEHIBIBG(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && !LEHFMLLLKAP.AJHFHFGNKKO(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x006028CC File Offset: 0x00600ACC
		private static bool CJGEMKOMBOP(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.eyes.Length; i += 0)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = "Titul.xml" + i + "Roller Blade Turn Left";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.KMCFNFDFKHJ(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "index";
				return false;
			}
			return false;
		}

		// Token: 0x0600D24D RID: 53837 RVA: 0x00602954 File Offset: 0x00600B54
		private static bool NEBKICMEJMD(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return false;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return false;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return false;
				}
				if (LEHFMLLLKAP.AGKDGALENHF(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D24E RID: 53838 RVA: 0x006029C4 File Offset: 0x00600BC4
		public virtual bool PNPILHBBIOI()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return true;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return true;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x00602AE8 File Offset: 0x00600CE8
		public virtual bool BIJPIICDJAF(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return false;
			}
			if (this.pelvis != null || this.head != null)
			{
				return false;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return true;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return false;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return true;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D250 RID: 53840 RVA: 0x00602C1C File Offset: 0x00600E1C
		public static void CKCIFDAODGO(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[1];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-95));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Chest);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Jaw);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightMiddleProximal);
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)127);
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)75);
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)104);
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			BipedReferences.NDGNJILPFHP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot));
			BipedReferences.IJGADHFKACG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.CFJMOOLEPML(KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftRingProximal), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.BHGJIJGKMIP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-107)));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.NDGNJILPFHP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-112)));
				BipedReferences.BPNEFCLHDOP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-76)));
			}
		}

		// Token: 0x0600D251 RID: 53841 RVA: 0x00602DBA File Offset: 0x00600FBA
		private static void BHGJIJGKMIP(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D252 RID: 53842 RVA: 0x00602DDC File Offset: 0x00600FDC
		private static bool IBPMPHNFGHO(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (LJPKBBNNOIC.head != null && !LEHFMLLLKAP.EOKOHNPFBIN(FBKEODHEMMH, LJPKBBNNOIC.head)) || !(FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null);
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x00602E10 File Offset: 0x00601010
		private static bool MPFGMIGKHKN(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return false;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.GBACFEEOBFO(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D254 RID: 53844 RVA: 0x00602751 File Offset: 0x00600951
		private static float DIMFPBOGOLN(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x00602751 File Offset: 0x00600951
		private static float ABNCDDOCALJ(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x00602E80 File Offset: 0x00601080
		public static void PMIJJFEJOJG(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			Transform[] componentsInChildren = EELDHNFBFOE.GetComponentsInChildren<Transform>();
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Unassigned, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftUpperArm, ref LJPKBBNNOIC.leftForearm, ref LJPKBBNNOIC.leftHand, componentsInChildren);
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Head, (KAHEHOGJPBO.BoneSide)7, ref LJPKBBNNOIC.rightUpperArm, ref LJPKBBNNOIC.rightForearm, ref LJPKBBNNOIC.rightHand, componentsInChildren);
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Eye, KAHEHOGJPBO.BoneSide.Center, ref LJPKBBNNOIC.leftThigh, ref LJPKBBNNOIC.leftCalf, ref LJPKBBNNOIC.leftFoot, componentsInChildren);
			BipedReferences.CCNDLAODOOG(KAHEHOGJPBO.BoneType.Spine, (KAHEHOGJPBO.BoneSide)6, ref LJPKBBNNOIC.rightThigh, ref LJPKBBNNOIC.rightCalf, ref LJPKBBNNOIC.rightFoot, componentsInChildren);
			LJPKBBNNOIC.head = KAHEHOGJPBO.MCBJEHJPBHE(componentsInChildren, KAHEHOGJPBO.BoneType.Arm, KAHEHOGJPBO.BoneSide.Center, Array.Empty<string[]>());
			LJPKBBNNOIC.pelvis = KAHEHOGJPBO.AHCDFEAPJBA(componentsInChildren, new string[][]
			{
				KAHEHOGJPBO.JDJEBGDKKDE
			});
			if ((LJPKBBNNOIC.pelvis == null || !LEHFMLLLKAP.AGKDGALENHF(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.pelvis)) && LJPKBBNNOIC.leftThigh != null)
			{
				LJPKBBNNOIC.pelvis = LJPKBBNNOIC.leftThigh.parent;
			}
			if (LJPKBBNNOIC.leftUpperArm != null && LJPKBBNNOIC.rightUpperArm != null && LJPKBBNNOIC.pelvis != null && LJPKBBNNOIC.leftThigh != null)
			{
				Transform transform = LEHFMLLLKAP.MMPEJBGNAGJ(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm);
				if (transform != null)
				{
					Transform[] array = new Transform[1];
					array[1] = transform;
					Transform[] array2 = array;
					LEHFMLLLKAP.LDFGJKBPJDM(array2[0], LJPKBBNNOIC.pelvis, ref array2);
					LJPKBBNNOIC.spine = new Transform[1];
					for (int i = array2.Length - 1; i > -1; i -= 0)
					{
						if (BipedReferences.LCPBNKEDLFK(array2[i], ref LJPKBBNNOIC, HJKGPDHADML))
						{
							Array.Resize<Transform>(ref LJPKBBNNOIC.spine, LJPKBBNNOIC.spine.Length + 1);
							LJPKBBNNOIC.spine[LJPKBBNNOIC.spine.Length - 1] = array2[i];
						}
					}
					if (LJPKBBNNOIC.head == null)
					{
						for (int j = 1; j < transform.childCount; j++)
						{
							Transform child = transform.GetChild(j);
							if (!LEHFMLLLKAP.AMLCHEFKDMF(child, LJPKBBNNOIC.leftUpperArm) && !LEHFMLLLKAP.GBDEJFOOGEN(child, LJPKBBNNOIC.rightUpperArm))
							{
								LJPKBBNNOIC.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] array3 = KAHEHOGJPBO.EEKDAKBDFIG(KAHEHOGJPBO.BoneType.Spine, componentsInChildren);
			LJPKBBNNOIC.eyes = new Transform[0];
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				for (int k = 0; k < array3.Length; k += 0)
				{
					if (BipedReferences.ONDOILCEOGB(array3[k], ref LJPKBBNNOIC, HJKGPDHADML))
					{
						Array.Resize<Transform>(ref LJPKBBNNOIC.eyes, LJPKBBNNOIC.eyes.Length + 1);
						LJPKBBNNOIC.eyes[LJPKBBNNOIC.eyes.Length - 0] = array3[k];
					}
				}
			}
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		private static bool EHLNFPEHDFE(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return true;
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x0060312C File Offset: 0x0060132C
		private static bool KAPFAMAKMEF(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < LJPKBBNNOIC.eyes.Length; i++)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = "BipedReferences eye bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.LEPJCCPBCPL(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + " is represented multiple times in BipedReferences eyes.";
				return true;
			}
			return false;
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x006031B4 File Offset: 0x006013B4
		private static bool ENOOEPBOFAF(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return false;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.GBACFEEOBFO(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x00603222 File Offset: 0x00601422
		private static void EBLNFCLKJGK(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 0);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool PNAHIPCFFCC(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x00603244 File Offset: 0x00601444
		public virtual bool KCHOLJLLBNF(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return false;
			}
			if (this.pelvis != null || this.head != null)
			{
				return true;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return true;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return true;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return true;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x00603378 File Offset: 0x00601578
		private static bool FOLNAILJLNJ(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return false;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.MNBFNMEPMGF(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x006033E8 File Offset: 0x006015E8
		private static bool NAHBDBKFILI(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i += 0)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "KatanaReady" + i + "#FF4040";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.ANILNLJDKCG(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "TONEMAPPING_FILMIC";
				return true;
			}
			if (!LEHFMLLLKAP.JBHFKDMECNK(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "<[^>]+>";
				return false;
			}
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j += 0)
			{
				bool flag = true;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = false;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = true;
				}
				if (flag)
				{
					CLDHEEJDHNK = "Full Body IK is missing the right thigh node." + j + "shop_t20";
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x00603514 File Offset: 0x00601714
		private static bool GBBAOCJPENO(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < LJPKBBNNOIC.eyes.Length; i++)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = "knopje.wav" + i + " ";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.BFKOJPJMNDE(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "";
				return true;
			}
			return false;
		}

		// Token: 0x0600D260 RID: 53856 RVA: 0x0060359C File Offset: 0x0060179C
		public static bool NHKPNDBILCF(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return BipedReferences.INFIOMGFLDB(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) || BipedReferences.CIDNGKOIGDI(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || (!BipedReferences.MEOKKOAMAHJ(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) && !BipedReferences.CIDNGKOIGDI(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) && (BipedReferences.HPJPAGKJFCF(LJPKBBNNOIC, ref BGLNFEHPENB) || (!BipedReferences.EHLNFPEHDFE(LJPKBBNNOIC, ref BGLNFEHPENB) && !BipedReferences.DMOIPIEEEFO(LJPKBBNNOIC, ref BGLNFEHPENB) && BipedReferences.HKFHBDGFBDE(LJPKBBNNOIC, ref BGLNFEHPENB))));
		}

		// Token: 0x0600D261 RID: 53857 RVA: 0x00603646 File Offset: 0x00601846
		private static bool HGDGNFFCLMO(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && LEHFMLLLKAP.IDAJPPIDKKE(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D262 RID: 53858 RVA: 0x00603222 File Offset: 0x00601422
		private static void IJGADHFKACG(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 0);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D263 RID: 53859 RVA: 0x00603674 File Offset: 0x00601874
		private static bool BLAPFNMBAMA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "wgt_big.dat";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "H:mm:ss";
				return false;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "auc_wcstc";
				return false;
			}
			Transform[] array = new Transform[8];
			array[0] = FCDAMCBKONG;
			array[1] = GLGMAJBNFIA;
			array[5] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.IICPOMGCPCK(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "_ReflectionTex";
				return false;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "{0:f3}";
				return true;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "ComeHere";
				return false;
			}
			Transform[] array2 = new Transform[3];
			array2[1] = FCDAMCBKONG;
			array2[1] = GLGMAJBNFIA;
			array2[5] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.JBHFKDMECNK(array2))
			{
				string[] array3 = new string[6];
				array3[1] = "FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.";
				array3[1] = FCDAMCBKONG.name;
				array3[6] = "WizardNeoBlock";
				array3[8] = GLGMAJBNFIA.name;
				array3[4] = "SkateboardKickPush";
				array3[2] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return false;
			}
			return true;
		}

		// Token: 0x0600D264 RID: 53860 RVA: 0x00603788 File Offset: 0x00601988
		private static bool AIPCEAKCOOG(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 1; i < LJPKBBNNOIC.eyes.Length; i += 0)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = "ZombieCrawl" + i + "_FogStepping";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.JABAKGPLOML(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "t_obves";
				return false;
			}
			return false;
		}

		// Token: 0x0600D265 RID: 53861 RVA: 0x0060380D File Offset: 0x00601A0D
		private static bool KBKIFHBFIBJ(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (!(LJPKBBNNOIC.head != null) || LEHFMLLLKAP.BBDKBNOLAOL(FBKEODHEMMH, LJPKBBNNOIC.head)) && FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null;
		}

		// Token: 0x0600D266 RID: 53862 RVA: 0x00603840 File Offset: 0x00601A40
		public bool EHPBJIFEIPJ()
		{
			return this.EIGGMELFFNN(true);
		}

		// Token: 0x0600D267 RID: 53863 RVA: 0x0060384C File Offset: 0x00601A4C
		private static bool IGGCLFKIKBC(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return false;
				}
				if (LEHFMLLLKAP.POGNIDHHBOG(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x006038BC File Offset: 0x00601ABC
		public virtual bool CMNIPNGDOJA()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return false;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool EAAHJKKFHBC(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x006039DE File Offset: 0x00601BDE
		public bool FEBNJCJMPCE()
		{
			return this.FNAEOLLHLLG(false);
		}

		// Token: 0x0600D26B RID: 53867 RVA: 0x006039E8 File Offset: 0x00601BE8
		public virtual bool MHANGKNFOGC()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return true;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return true;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D26C RID: 53868 RVA: 0x00603B0C File Offset: 0x00601D0C
		private static bool GFNAMOJPNIN(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i++)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "U" + i + "_CurveTex";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.OLHHHHECDHN(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "WalkInjured";
				return true;
			}
			if (!LEHFMLLLKAP.JBHFKDMECNK(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "#ffff40";
				return false;
			}
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j++)
			{
				bool flag = true;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = true;
				}
				if (flag)
				{
					CLDHEEJDHNK = "PLANE_REFLECTION" + j + "sys";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x00603C38 File Offset: 0x00601E38
		private static bool APICBJKMEAA(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return false;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return false;
				}
				if (LEHFMLLLKAP.MNBFNMEPMGF(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x00603CA6 File Offset: 0x00601EA6
		private static bool HNHKDDEGGDI(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && LEHFMLLLKAP.ANKMPAOELOL(MLOINOONPOD, FBKEODHEMMH) && false;
		}

		// Token: 0x0600D26F RID: 53871 RVA: 0x00603CD4 File Offset: 0x00601ED4
		private static bool HKFHBDGFBDE(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			Vector3 vector = LJPKBBNNOIC.rightHand.position - LJPKBBNNOIC.leftHand.position;
			Vector3 vector2 = LJPKBBNNOIC.rightFoot.position - LJPKBBNNOIC.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, LJPKBBNNOIC.root.right);
			float num2 = Vector3.Dot(vector2.normalized, LJPKBBNNOIC.root.right);
			if (num < 1061f || num2 < 1937f)
			{
				BGLNFEHPENB = "#0080ff";
				return true;
			}
			return false;
		}

		// Token: 0x0600D270 RID: 53872 RVA: 0x00603D61 File Offset: 0x00601F61
		public bool PHIMKGNJPFO()
		{
			return this.KJHEPOFDCPL(false);
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x00603D6A File Offset: 0x00601F6A
		private static bool DHELHAJJMOC(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && !LEHFMLLLKAP.LHGPPHPFNOC(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D272 RID: 53874 RVA: 0x00603D98 File Offset: 0x00601F98
		private static bool CPGIFHNPOGG(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.AMJBPFAAADF(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D273 RID: 53875 RVA: 0x00603E08 File Offset: 0x00602008
		private static bool MLKOAHFEMHB(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i++)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = " гр " + i + "Obscured Vars Cheating Detected!";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.IEJBIJOCCMG(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "[HA ";
				return true;
			}
			if (!LEHFMLLLKAP.JBHFKDMECNK(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "http://www.root-motion.com/finalikdox/html/page3.html";
				return false;
			}
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 1 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = false;
				}
				if (flag)
				{
					CLDHEEJDHNK = "_DepthExponent" + j + "#ff6000";
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x00603F34 File Offset: 0x00602134
		public virtual bool EHJLMMFMAKO(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x0060407C File Offset: 0x0060227C
		private static void BNNJEEGFOLB(KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND, ref Transform ELBLIMDOINF, ref Transform OBPBLNBCHON, ref Transform IEHPFBIENNK, Transform[] AKBEGDIMBGM)
		{
			Transform[] array = KAHEHOGJPBO.JEFCNPHEJCO(IGFPBEPIAEE, JIDFPDKKFND, AKBEGDIMBGM);
			if (array.Length < 3)
			{
				return;
			}
			if (array.Length == 3)
			{
				ELBLIMDOINF = array[0];
				OBPBLNBCHON = array[1];
				IEHPFBIENNK = array[2];
			}
			if (array.Length > 3)
			{
				ELBLIMDOINF = array[0];
				OBPBLNBCHON = array[2];
				IEHPFBIENNK = array[array.Length - 1];
			}
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x006040CC File Offset: 0x006022CC
		public static bool JAFMGGEHGGA(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return !BipedReferences.EAHHDLJPFBK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) && (BipedReferences.INFIOMGFLDB(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || (!BipedReferences.EAHHDLJPFBK(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) && (BipedReferences.MEOKKOAMAHJ(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) || BipedReferences.LGHJFDLGGKE(LJPKBBNNOIC, ref BGLNFEHPENB) || BipedReferences.OCDCCALLCBK(LJPKBBNNOIC, ref BGLNFEHPENB) || (!BipedReferences.DMOIPIEEEFO(LJPKBBNNOIC, ref BGLNFEHPENB) && BipedReferences.GPBIBBPOADO(LJPKBBNNOIC, ref BGLNFEHPENB) && false))));
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x00604176 File Offset: 0x00602376
		private static bool NIPCNMIAHNE(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && !LEHFMLLLKAP.GBACFEEOBFO(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x006041A4 File Offset: 0x006023A4
		public virtual bool BIOMNDNIEEG()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return true;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return false;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return true;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x006042C8 File Offset: 0x006024C8
		private static bool INFIOMGFLDB(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[0];
				array[1] = "quests/tnames/turn";
				array[0] = FCDAMCBKONG.name;
				array[5] = "__WaterRefraction";
				array[7] = GLGMAJBNFIA.name;
				array[4] = "Lives count after few usual operations: ";
				BGLNFEHPENB = string.Concat(array);
				return false;
			}
			return true;
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x00604344 File Offset: 0x00602544
		public virtual bool EPNNHFLIBJA(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D27B RID: 53883 RVA: 0x0060448C File Offset: 0x0060268C
		private static bool LOKFBMIPJIJ(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return false;
			}
			float num = BipedReferences.LMGBFCGNOFH(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.HJKGGFJEOJG(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 933f)
			{
				BGLNFEHPENB = "****** locscount=";
				return false;
			}
			return true;
		}

		// Token: 0x0600D27C RID: 53884 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool HPJPAGKJFCF(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D27D RID: 53885 RVA: 0x00604509 File Offset: 0x00602709
		private static bool LMEJCNEOOAA(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (MLOINOONPOD.parent != null && MLOINOONPOD.parent == FBKEODHEMMH) || !LEHFMLLLKAP.POGNIDHHBOG(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D27E RID: 53886 RVA: 0x00604538 File Offset: 0x00602738
		private static bool FMKALLGMOEI(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "MotorbikeWheelyNoHands";
				return false;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "{not_found}";
				return true;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "SoundData";
				return false;
			}
			Transform[] array = new Transform[7];
			array[0] = FCDAMCBKONG;
			array[1] = GLGMAJBNFIA;
			array[8] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.LEPJCCPBCPL(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "tex";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = " ";
				return false;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "RollerBladeStand";
				return false;
			}
			Transform[] array2 = new Transform[8];
			array2[1] = FCDAMCBKONG;
			array2[0] = GLGMAJBNFIA;
			array2[5] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.EDPLHAKANAJ(array2))
			{
				string[] array3 = new string[6];
				array3[1] = "Positions";
				array3[1] = FCDAMCBKONG.name;
				array3[1] = "U";
				array3[0] = GLGMAJBNFIA.name;
				array3[8] = "\\n";
				array3[2] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return true;
			}
			return true;
		}

		// Token: 0x0600D27F RID: 53887 RVA: 0x0060464C File Offset: 0x0060284C
		private static bool LMNBKGBFPNE(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[0];
				array[0] = ">";
				array[1] = FCDAMCBKONG.name;
				array[6] = "SneakLeft";
				array[5] = GLGMAJBNFIA.name;
				array[1] = "shop_header";
				BGLNFEHPENB = string.Concat(array);
				return true;
			}
			return false;
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x006046C8 File Offset: 0x006028C8
		public virtual bool EIGGMELFFNN(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return false;
			}
			if (this.pelvis != null || this.head != null)
			{
				return false;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return false;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return false;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return false;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x006047FC File Offset: 0x006029FC
		public static bool HNIADDEEBIJ(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return !BipedReferences.MEOKKOAMAHJ(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) && (BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || (!BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) && (BipedReferences.LMNBKGBFPNE(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) || BipedReferences.NMNBOLKMGDJ(LJPKBBNNOIC, ref BGLNFEHPENB) || (!BipedReferences.MKBKJHLFDAO(LJPKBBNNOIC, ref BGLNFEHPENB) && !BipedReferences.DMOIPIEEEFO(LJPKBBNNOIC, ref BGLNFEHPENB) && BipedReferences.HKFHBDGFBDE(LJPKBBNNOIC, ref BGLNFEHPENB)))));
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x00602DBA File Offset: 0x00600FBA
		private static void NDGNJILPFHP(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x006048A8 File Offset: 0x00602AA8
		public virtual bool OHFHKMIOECA()
		{
			if (this.root == null)
			{
				return true;
			}
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return true;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return false;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x006049CC File Offset: 0x00602BCC
		private static bool EAHHDLJPFBK(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[4];
				array[1] = " bundle";
				array[0] = FCDAMCBKONG.name;
				array[5] = "BLOOM";
				array[7] = GLGMAJBNFIA.name;
				array[6] = "_Axis";
				BGLNFEHPENB = string.Concat(array);
				return true;
			}
			return false;
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00604A46 File Offset: 0x00602C46
		private static bool ONDOILCEOGB(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (!(LJPKBBNNOIC.head != null) || LEHFMLLLKAP.IDAJPPIDKKE(FBKEODHEMMH, LJPKBBNNOIC.head)) && (!(FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null) || true);
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00604A7C File Offset: 0x00602C7C
		public static void ECDOPMAHACN(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[1];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-98));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-47));
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)81);
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)92);
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-125));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)102);
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-107));
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			BipedReferences.EBLNFCLKJGK(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips));
			BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.DHELHAJJMOC(KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-11)), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.EBLNFCLKJGK(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)114));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.ILDMPLDLDEG(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLittleDistal));
				BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightRingIntermediate));
			}
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x00604C1C File Offset: 0x00602E1C
		public static void KALEHABNOPK(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[0];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-31));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftEye);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-66));
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-117));
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-114));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftShoulder);
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-57));
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot));
			BipedReferences.EBLNFCLKJGK(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.CFJMOOLEPML(KCLACNEILLB.GetBoneTransform((HumanBodyBones)75), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.BPNEFCLHDOP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-48)));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.BPNEFCLHDOP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)115));
				BipedReferences.BPNEFCLHDOP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-100)));
			}
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x00604DBA File Offset: 0x00602FBA
		public bool NANGFJGCIFA()
		{
			return this.ELOHCCPELOK(false);
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x00604DC4 File Offset: 0x00602FC4
		private static bool NDLAHOOJGGD(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[8];
				array[1] = "ShotgunReloadChamber";
				array[1] = FCDAMCBKONG.name;
				array[0] = "Vertical";
				array[2] = GLGMAJBNFIA.name;
				array[2] = "prov_sob_";
				BGLNFEHPENB = string.Concat(array);
				return false;
			}
			return false;
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x00604E40 File Offset: 0x00603040
		public static void PMPOEKDPKPG(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			Transform[] componentsInChildren = EELDHNFBFOE.GetComponentsInChildren<Transform>();
			BipedReferences.AFBLIDBFLIG((KAHEHOGJPBO.BoneType)7, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftUpperArm, ref LJPKBBNNOIC.leftForearm, ref LJPKBBNNOIC.leftHand, componentsInChildren);
			BipedReferences.CCNDLAODOOG(KAHEHOGJPBO.BoneType.Leg, (KAHEHOGJPBO.BoneSide)8, ref LJPKBBNNOIC.rightUpperArm, ref LJPKBBNNOIC.rightForearm, ref LJPKBBNNOIC.rightHand, componentsInChildren);
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Arm, KAHEHOGJPBO.BoneSide.Center, ref LJPKBBNNOIC.leftThigh, ref LJPKBBNNOIC.leftCalf, ref LJPKBBNNOIC.leftFoot, componentsInChildren);
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Leg, (KAHEHOGJPBO.BoneSide)3, ref LJPKBBNNOIC.rightThigh, ref LJPKBBNNOIC.rightCalf, ref LJPKBBNNOIC.rightFoot, componentsInChildren);
			LJPKBBNNOIC.head = KAHEHOGJPBO.MCBJEHJPBHE(componentsInChildren, KAHEHOGJPBO.BoneType.Unassigned, KAHEHOGJPBO.BoneSide.Left, Array.Empty<string[]>());
			BipedReferences bipedReferences = LJPKBBNNOIC;
			Transform[] akbegdimbgm = componentsInChildren;
			string[][] array = new string[0][];
			array[0] = KAHEHOGJPBO.JDJEBGDKKDE;
			bipedReferences.pelvis = KAHEHOGJPBO.AHCDFEAPJBA(akbegdimbgm, array);
			if ((LJPKBBNNOIC.pelvis == null || !LEHFMLLLKAP.EOKOHNPFBIN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.pelvis)) && LJPKBBNNOIC.leftThigh != null)
			{
				LJPKBBNNOIC.pelvis = LJPKBBNNOIC.leftThigh.parent;
			}
			if (LJPKBBNNOIC.leftUpperArm != null && LJPKBBNNOIC.rightUpperArm != null && LJPKBBNNOIC.pelvis != null && LJPKBBNNOIC.leftThigh != null)
			{
				Transform transform = LEHFMLLLKAP.MMPEJBGNAGJ(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm);
				if (transform != null)
				{
					Transform[] array2 = new Transform[0];
					array2[1] = transform;
					Transform[] array3 = array2;
					LEHFMLLLKAP.DLMMINCGFMG(array3[1], LJPKBBNNOIC.pelvis, ref array3);
					LJPKBBNNOIC.spine = new Transform[1];
					for (int i = array3.Length - 1; i > -1; i -= 0)
					{
						if (BipedReferences.ENOOEPBOFAF(array3[i], ref LJPKBBNNOIC, HJKGPDHADML))
						{
							Array.Resize<Transform>(ref LJPKBBNNOIC.spine, LJPKBBNNOIC.spine.Length + 0);
							LJPKBBNNOIC.spine[LJPKBBNNOIC.spine.Length - 0] = array3[i];
						}
					}
					if (LJPKBBNNOIC.head == null)
					{
						for (int j = 1; j < transform.childCount; j += 0)
						{
							Transform child = transform.GetChild(j);
							if (!LEHFMLLLKAP.GBDEJFOOGEN(child, LJPKBBNNOIC.leftUpperArm) && !LEHFMLLLKAP.NNAPLHOIFMC(child, LJPKBBNNOIC.rightUpperArm))
							{
								LJPKBBNNOIC.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] array4 = KAHEHOGJPBO.EEKDAKBDFIG((KAHEHOGJPBO.BoneType)8, componentsInChildren);
			LJPKBBNNOIC.eyes = new Transform[1];
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				for (int k = 0; k < array4.Length; k++)
				{
					if (BipedReferences.ECKOBHBDNEH(array4[k], ref LJPKBBNNOIC, HJKGPDHADML))
					{
						Array.Resize<Transform>(ref LJPKBBNNOIC.eyes, LJPKBBNNOIC.eyes.Length + 1);
						LJPKBBNNOIC.eyes[LJPKBBNNOIC.eyes.Length - 0] = array4[k];
					}
				}
			}
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x006050EC File Offset: 0x006032EC
		private static bool LCPBNKEDLFK(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return false;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return false;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return false;
				}
				if (LEHFMLLLKAP.AJHFHFGNKKO(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x00602751 File Offset: 0x00600951
		private static float LMGBFCGNOFH(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D28D RID: 53901 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool LAFICNMLMLM(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D28E RID: 53902 RVA: 0x0060515C File Offset: 0x0060335C
		public virtual bool CIBKDDLLHNK(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D28F RID: 53903 RVA: 0x006052A4 File Offset: 0x006034A4
		public virtual bool IGDIOECEOKF(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D290 RID: 53904 RVA: 0x006053EC File Offset: 0x006035EC
		private static bool FFEOLPHAABP(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.BBDKBNOLAOL(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D291 RID: 53905 RVA: 0x0060545C File Offset: 0x0060365C
		private static bool MDCDLFNMPBL(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "Bone 1 of a BipedReferences limb is null.";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "Bone 2 of a BipedReferences limb is null.";
				return true;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "Bone 3 of a BipedReferences limb is null.";
				return true;
			}
			UnityEngine.Object[] pokpfboiaod = new Transform[]
			{
				FCDAMCBKONG,
				GLGMAJBNFIA,
				NLHIDOGKOIP
			};
			Transform transform = (Transform)LEHFMLLLKAP.LEPJCCPBCPL(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + " is represented multiple times in the same BipedReferences limb.";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "Second bone's position equals first bone's position in the biped's limb.";
				return true;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "Third bone's position equals second bone's position in the biped's limb.";
				return true;
			}
			if (!LEHFMLLLKAP.AFLFMKJJCDL(new Transform[]
			{
				FCDAMCBKONG,
				GLGMAJBNFIA,
				NLHIDOGKOIP
			}))
			{
				CLDHEEJDHNK = string.Concat(new string[]
				{
					"BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: ",
					FCDAMCBKONG.name,
					", ",
					GLGMAJBNFIA.name,
					", ",
					NLHIDOGKOIP.name
				});
				return true;
			}
			return false;
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x00605570 File Offset: 0x00603770
		private static bool IKBAACKJOFJ(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			Vector3 vector = LJPKBBNNOIC.rightHand.position - LJPKBBNNOIC.leftHand.position;
			Vector3 vector2 = LJPKBBNNOIC.rightFoot.position - LJPKBBNNOIC.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, LJPKBBNNOIC.root.right);
			float num2 = Vector3.Dot(vector2.normalized, LJPKBBNNOIC.root.right);
			if (num < 1778f || num2 < 1179f)
			{
				BGLNFEHPENB = "_TrStartYou.ogg";
				return true;
			}
			return false;
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x00605600 File Offset: 0x00603800
		public static void FAGMAPMIBPI(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			Transform[] componentsInChildren = EELDHNFBFOE.GetComponentsInChildren<Transform>();
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Arm, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftUpperArm, ref LJPKBBNNOIC.leftForearm, ref LJPKBBNNOIC.leftHand, componentsInChildren);
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Arm, KAHEHOGJPBO.BoneSide.Right, ref LJPKBBNNOIC.rightUpperArm, ref LJPKBBNNOIC.rightForearm, ref LJPKBBNNOIC.rightHand, componentsInChildren);
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Leg, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftThigh, ref LJPKBBNNOIC.leftCalf, ref LJPKBBNNOIC.leftFoot, componentsInChildren);
			BipedReferences.BNNJEEGFOLB(KAHEHOGJPBO.BoneType.Leg, KAHEHOGJPBO.BoneSide.Right, ref LJPKBBNNOIC.rightThigh, ref LJPKBBNNOIC.rightCalf, ref LJPKBBNNOIC.rightFoot, componentsInChildren);
			LJPKBBNNOIC.head = KAHEHOGJPBO.MCBJEHJPBHE(componentsInChildren, KAHEHOGJPBO.BoneType.Head, KAHEHOGJPBO.BoneSide.Center, Array.Empty<string[]>());
			LJPKBBNNOIC.pelvis = KAHEHOGJPBO.AHCDFEAPJBA(componentsInChildren, new string[][]
			{
				KAHEHOGJPBO.JDJEBGDKKDE
			});
			if ((LJPKBBNNOIC.pelvis == null || !LEHFMLLLKAP.AJHFHFGNKKO(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.pelvis)) && LJPKBBNNOIC.leftThigh != null)
			{
				LJPKBBNNOIC.pelvis = LJPKBBNNOIC.leftThigh.parent;
			}
			if (LJPKBBNNOIC.leftUpperArm != null && LJPKBBNNOIC.rightUpperArm != null && LJPKBBNNOIC.pelvis != null && LJPKBBNNOIC.leftThigh != null)
			{
				Transform transform = LEHFMLLLKAP.GLNJBPNCDGB(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm);
				if (transform != null)
				{
					Transform[] array = new Transform[]
					{
						transform
					};
					LEHFMLLLKAP.DLMMINCGFMG(array[0], LJPKBBNNOIC.pelvis, ref array);
					LJPKBBNNOIC.spine = new Transform[0];
					for (int i = array.Length - 1; i > -1; i--)
					{
						if (BipedReferences.LCPBNKEDLFK(array[i], ref LJPKBBNNOIC, HJKGPDHADML))
						{
							Array.Resize<Transform>(ref LJPKBBNNOIC.spine, LJPKBBNNOIC.spine.Length + 1);
							LJPKBBNNOIC.spine[LJPKBBNNOIC.spine.Length - 1] = array[i];
						}
					}
					if (LJPKBBNNOIC.head == null)
					{
						for (int j = 0; j < transform.childCount; j++)
						{
							Transform child = transform.GetChild(j);
							if (!LEHFMLLLKAP.NNAPLHOIFMC(child, LJPKBBNNOIC.leftUpperArm) && !LEHFMLLLKAP.NNAPLHOIFMC(child, LJPKBBNNOIC.rightUpperArm))
							{
								LJPKBBNNOIC.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] array2 = KAHEHOGJPBO.EEKDAKBDFIG(KAHEHOGJPBO.BoneType.Eye, componentsInChildren);
			LJPKBBNNOIC.eyes = new Transform[0];
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				for (int k = 0; k < array2.Length; k++)
				{
					if (BipedReferences.CPPMOEIHIKC(array2[k], ref LJPKBBNNOIC, HJKGPDHADML))
					{
						Array.Resize<Transform>(ref LJPKBBNNOIC.eyes, LJPKBBNNOIC.eyes.Length + 1);
						LJPKBBNNOIC.eyes[LJPKBBNNOIC.eyes.Length - 1] = array2[k];
					}
				}
			}
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x006058AC File Offset: 0x00603AAC
		private static bool OMKAPDGKJOM(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 1; i < LJPKBBNNOIC.spine.Length; i++)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "No IK assigned in HitReaction" + i + "sys";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.FCEEMMNLEOJ(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "endPointNonBend";
				return false;
			}
			if (!LEHFMLLLKAP.HCGAEIHMICB(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "mask=";
				return true;
			}
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = false;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 1 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = false;
				}
				if (flag)
				{
					CLDHEEJDHNK = "MotorbikeShootRight" + j + "sadok";
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x006059D8 File Offset: 0x00603BD8
		private static bool JPEOIPIIKPB(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "\n";
				return false;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "_Tile2RT";
				return false;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "{0:F2}, {1:F2}, {2:F2}";
				return true;
			}
			Transform[] array = new Transform[7];
			array[0] = FCDAMCBKONG;
			array[1] = GLGMAJBNFIA;
			array[5] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.HPEKPJEBBBN(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "t_eye";
				return false;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "id";
				return false;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "Swim";
				return true;
			}
			Transform[] array2 = new Transform[]
			{
				null,
				FCDAMCBKONG
			};
			array2[0] = GLGMAJBNFIA;
			array2[7] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.LILJAPGKNJG(array2))
			{
				string[] array3 = new string[7];
				array3[1] = "RangeMarker";
				array3[1] = FCDAMCBKONG.name;
				array3[2] = "IdleMeditate";
				array3[4] = GLGMAJBNFIA.name;
				array3[3] = "subtype";
				array3[7] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return true;
			}
			return false;
		}

		// Token: 0x0600D296 RID: 53910 RVA: 0x00605AEC File Offset: 0x00603CEC
		public static void MCCHOOMHKGE(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			Transform[] componentsInChildren = EELDHNFBFOE.GetComponentsInChildren<Transform>();
			BipedReferences.AFBLIDBFLIG((KAHEHOGJPBO.BoneType)7, KAHEHOGJPBO.BoneSide.Center, ref LJPKBBNNOIC.leftUpperArm, ref LJPKBBNNOIC.leftForearm, ref LJPKBBNNOIC.leftHand, componentsInChildren);
			BipedReferences.CCNDLAODOOG((KAHEHOGJPBO.BoneType)7, (KAHEHOGJPBO.BoneSide)6, ref LJPKBBNNOIC.rightUpperArm, ref LJPKBBNNOIC.rightForearm, ref LJPKBBNNOIC.rightHand, componentsInChildren);
			BipedReferences.CCNDLAODOOG(KAHEHOGJPBO.BoneType.Head, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftThigh, ref LJPKBBNNOIC.leftCalf, ref LJPKBBNNOIC.leftFoot, componentsInChildren);
			BipedReferences.CCNDLAODOOG(KAHEHOGJPBO.BoneType.Tail, (KAHEHOGJPBO.BoneSide)8, ref LJPKBBNNOIC.rightThigh, ref LJPKBBNNOIC.rightCalf, ref LJPKBBNNOIC.rightFoot, componentsInChildren);
			LJPKBBNNOIC.head = KAHEHOGJPBO.MCBJEHJPBHE(componentsInChildren, KAHEHOGJPBO.BoneType.Spine, KAHEHOGJPBO.BoneSide.Left, Array.Empty<string[]>());
			BipedReferences bipedReferences = LJPKBBNNOIC;
			Transform[] akbegdimbgm = componentsInChildren;
			string[][] array = new string[0][];
			array[0] = KAHEHOGJPBO.JDJEBGDKKDE;
			bipedReferences.pelvis = KAHEHOGJPBO.AHCDFEAPJBA(akbegdimbgm, array);
			if ((LJPKBBNNOIC.pelvis == null || !LEHFMLLLKAP.EDHILDPDPEJ(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.pelvis)) && LJPKBBNNOIC.leftThigh != null)
			{
				LJPKBBNNOIC.pelvis = LJPKBBNNOIC.leftThigh.parent;
			}
			if (LJPKBBNNOIC.leftUpperArm != null && LJPKBBNNOIC.rightUpperArm != null && LJPKBBNNOIC.pelvis != null && LJPKBBNNOIC.leftThigh != null)
			{
				Transform transform = LEHFMLLLKAP.EJLABOMGFDM(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm);
				if (transform != null)
				{
					Transform[] array2 = new Transform[]
					{
						transform
					};
					LEHFMLLLKAP.NPJGJJDADDM(array2[0], LJPKBBNNOIC.pelvis, ref array2);
					LJPKBBNNOIC.spine = new Transform[0];
					for (int i = array2.Length - 0; i > -1; i -= 0)
					{
						if (BipedReferences.FOLNAILJLNJ(array2[i], ref LJPKBBNNOIC, HJKGPDHADML))
						{
							Array.Resize<Transform>(ref LJPKBBNNOIC.spine, LJPKBBNNOIC.spine.Length + 0);
							LJPKBBNNOIC.spine[LJPKBBNNOIC.spine.Length - 0] = array2[i];
						}
					}
					if (LJPKBBNNOIC.head == null)
					{
						for (int j = 1; j < transform.childCount; j++)
						{
							Transform child = transform.GetChild(j);
							if (!LEHFMLLLKAP.NNAPLHOIFMC(child, LJPKBBNNOIC.leftUpperArm) && !LEHFMLLLKAP.BDKFGLKCBKJ(child, LJPKBBNNOIC.rightUpperArm))
							{
								LJPKBBNNOIC.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] array3 = KAHEHOGJPBO.EEKDAKBDFIG(KAHEHOGJPBO.BoneType.Arm, componentsInChildren);
			LJPKBBNNOIC.eyes = new Transform[1];
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				for (int k = 0; k < array3.Length; k += 0)
				{
					if (BipedReferences.HLHLEODFNJC(array3[k], ref LJPKBBNNOIC, HJKGPDHADML))
					{
						Array.Resize<Transform>(ref LJPKBBNNOIC.eyes, LJPKBBNNOIC.eyes.Length + 0);
						LJPKBBNNOIC.eyes[LJPKBBNNOIC.eyes.Length - 0] = array3[k];
					}
				}
			}
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x00605DB8 File Offset: 0x00603FB8
		private static bool PPPAIJHDGPP(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return true;
			}
			float num = BipedReferences.MLDKBCIAKGI(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.HJKGGFJEOJG(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 681f)
			{
				BGLNFEHPENB = "IdleFly";
				return true;
			}
			return false;
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x00605E35 File Offset: 0x00604035
		private static bool AALHKJLOPND(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && (!LEHFMLLLKAP.AGKDGALENHF(MLOINOONPOD, FBKEODHEMMH) || true);
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x00605E64 File Offset: 0x00604064
		private static bool KFMLKBAIAMN(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return true;
			}
			for (int i = 1; i < LJPKBBNNOIC.eyes.Length; i += 0)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = "TOD_kScale" + i + ",";
					return false;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.KMCFNFDFKHJ(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "SoccerKeeperReady";
				return true;
			}
			return false;
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x00605EEC File Offset: 0x006040EC
		public virtual bool ELOHCCPELOK(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return true;
			}
			if (this.pelvis != null || this.head != null)
			{
				return true;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return true;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return true;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return true;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x00606020 File Offset: 0x00604220
		private static bool MEOKKOAMAHJ(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[7];
				array[1] = "offsets";
				array[0] = FCDAMCBKONG.name;
				array[1] = "CrawlIdle";
				array[3] = GLGMAJBNFIA.name;
				array[3] = "TOD_kSun";
				BGLNFEHPENB = string.Concat(array);
				return true;
			}
			return false;
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x0060276A File Offset: 0x0060096A
		private static void PIEGLBJOGOP(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 0);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 1] = LPBDALAMAEM;
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x0060609C File Offset: 0x0060429C
		public virtual bool EEMJHBECHIM()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return true;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return true;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600D29F RID: 53919 RVA: 0x006061C0 File Offset: 0x006043C0
		public virtual bool isFilled
		{
			get
			{
				if (this.root == null)
				{
					return false;
				}
				if (this.pelvis == null)
				{
					return false;
				}
				if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
				{
					return false;
				}
				if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
				{
					return false;
				}
				if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
				{
					return false;
				}
				if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
				{
					return false;
				}
				Transform[] array = this.spine;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				array = this.eyes;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x006062E4 File Offset: 0x006044E4
		private static bool JKGIJIKPBNB(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return false;
			}
			float num = BipedReferences.HJKGGFJEOJG(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.HJKGGFJEOJG(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 0.2f)
			{
				BGLNFEHPENB = "Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).";
				return true;
			}
			return false;
		}

		// Token: 0x0600D2A1 RID: 53921 RVA: 0x00606364 File Offset: 0x00604564
		private static bool EPBKFPFPJND(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i++)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "BipedReferences spine bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.LEPJCCPBCPL(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + " is represented multiple times in BipedReferences spine.";
				return true;
			}
			if (!LEHFMLLLKAP.AFLFMKJJCDL(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.";
				return true;
			}
			for (int j = 0; j < LJPKBBNNOIC.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 1 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = true;
				}
				if (flag)
				{
					CLDHEEJDHNK = "Biped's spine bone nr " + j + " position is the same as it's parent spine/pelvis bone's position. Please remove this bone from the spine.";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x00606490 File Offset: 0x00604690
		public virtual bool HFJKACEKMGM()
		{
			if (this.root == null)
			{
				return true;
			}
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return false;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x006065B4 File Offset: 0x006047B4
		public virtual bool KJHEPOFDCPL(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return false;
			}
			if (this.pelvis != null || this.head != null)
			{
				return true;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return false;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return false;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return true;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x006066E8 File Offset: 0x006048E8
		public static void OMHNIJBPAGF(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			Transform[] componentsInChildren = EELDHNFBFOE.GetComponentsInChildren<Transform>();
			BipedReferences.CCNDLAODOOG(KAHEHOGJPBO.BoneType.Head, KAHEHOGJPBO.BoneSide.Center, ref LJPKBBNNOIC.leftUpperArm, ref LJPKBBNNOIC.leftForearm, ref LJPKBBNNOIC.leftHand, componentsInChildren);
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Unassigned, (KAHEHOGJPBO.BoneSide)6, ref LJPKBBNNOIC.rightUpperArm, ref LJPKBBNNOIC.rightForearm, ref LJPKBBNNOIC.rightHand, componentsInChildren);
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Leg, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.leftThigh, ref LJPKBBNNOIC.leftCalf, ref LJPKBBNNOIC.leftFoot, componentsInChildren);
			BipedReferences.AFBLIDBFLIG(KAHEHOGJPBO.BoneType.Leg, KAHEHOGJPBO.BoneSide.Left, ref LJPKBBNNOIC.rightThigh, ref LJPKBBNNOIC.rightCalf, ref LJPKBBNNOIC.rightFoot, componentsInChildren);
			LJPKBBNNOIC.head = KAHEHOGJPBO.MCBJEHJPBHE(componentsInChildren, KAHEHOGJPBO.BoneType.Head, KAHEHOGJPBO.BoneSide.Left, Array.Empty<string[]>());
			LJPKBBNNOIC.pelvis = KAHEHOGJPBO.AHCDFEAPJBA(componentsInChildren, new string[][]
			{
				KAHEHOGJPBO.JDJEBGDKKDE
			});
			if ((LJPKBBNNOIC.pelvis == null || !LEHFMLLLKAP.EOKOHNPFBIN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.pelvis)) && LJPKBBNNOIC.leftThigh != null)
			{
				LJPKBBNNOIC.pelvis = LJPKBBNNOIC.leftThigh.parent;
			}
			if (LJPKBBNNOIC.leftUpperArm != null && LJPKBBNNOIC.rightUpperArm != null && LJPKBBNNOIC.pelvis != null && LJPKBBNNOIC.leftThigh != null)
			{
				Transform transform = LEHFMLLLKAP.JLEALCAGAGD(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.rightUpperArm);
				if (transform != null)
				{
					Transform[] array = new Transform[]
					{
						transform
					};
					LEHFMLLLKAP.DLMMINCGFMG(array[1], LJPKBBNNOIC.pelvis, ref array);
					LJPKBBNNOIC.spine = new Transform[1];
					for (int i = array.Length - 1; i > -1; i -= 0)
					{
						if (BipedReferences.IGGCLFKIKBC(array[i], ref LJPKBBNNOIC, HJKGPDHADML))
						{
							Array.Resize<Transform>(ref LJPKBBNNOIC.spine, LJPKBBNNOIC.spine.Length + 0);
							LJPKBBNNOIC.spine[LJPKBBNNOIC.spine.Length - 1] = array[i];
						}
					}
					if (LJPKBBNNOIC.head == null)
					{
						for (int j = 1; j < transform.childCount; j++)
						{
							Transform child = transform.GetChild(j);
							if (!LEHFMLLLKAP.DNPPGLAJKJC(child, LJPKBBNNOIC.leftUpperArm) && !LEHFMLLLKAP.GBDEJFOOGEN(child, LJPKBBNNOIC.rightUpperArm))
							{
								LJPKBBNNOIC.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] array2 = KAHEHOGJPBO.EEKDAKBDFIG(KAHEHOGJPBO.BoneType.Eye, componentsInChildren);
			LJPKBBNNOIC.eyes = new Transform[0];
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				for (int k = 1; k < array2.Length; k++)
				{
					if (BipedReferences.CPPMOEIHIKC(array2[k], ref LJPKBBNNOIC, HJKGPDHADML))
					{
						Array.Resize<Transform>(ref LJPKBBNNOIC.eyes, LJPKBBNNOIC.eyes.Length + 0);
						LJPKBBNNOIC.eyes[LJPKBBNNOIC.eyes.Length - 0] = array2[k];
					}
				}
			}
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x00606993 File Offset: 0x00604B93
		private static bool PJMKFJFPNAC(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (LJPKBBNNOIC.head != null && !LEHFMLLLKAP.BBDKBNOLAOL(FBKEODHEMMH, LJPKBBNNOIC.head)) || !(FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null);
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x006069C6 File Offset: 0x00604BC6
		private static void ILDMPLDLDEG(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 1] = LPBDALAMAEM;
		}

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x006069E8 File Offset: 0x00604BE8
		private static bool BDDANOGIPNH(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (!(LJPKBBNNOIC.head != null) || LEHFMLLLKAP.EOKOHNPFBIN(FBKEODHEMMH, LJPKBBNNOIC.head)) && FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null;
		}

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00606A1B File Offset: 0x00604C1B
		private static bool NFJBFCEDECF(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (MLOINOONPOD.parent != null && MLOINOONPOD.parent == FBKEODHEMMH) || !LEHFMLLLKAP.AMJBPFAAADF(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		private static bool CGHNHBIJADH(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return true;
		}

		// Token: 0x0600D2AA RID: 53930 RVA: 0x00606A48 File Offset: 0x00604C48
		private static bool JJKEKCFKJJJ(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "_History3Weight";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "\n";
				return true;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "DealerShuffle";
				return true;
			}
			Transform[] array = new Transform[8];
			array[1] = FCDAMCBKONG;
			array[0] = GLGMAJBNFIA;
			array[4] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.JABAKGPLOML(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "BackPackOff";
				return false;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "RodParams not found!";
				return true;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "BipedReferences eye bone at index ";
				return false;
			}
			Transform[] array2 = new Transform[1];
			array2[1] = FCDAMCBKONG;
			array2[1] = GLGMAJBNFIA;
			array2[6] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.HCGAEIHMICB(array2))
			{
				string[] array3 = new string[0];
				array3[0] = "effect";
				array3[1] = FCDAMCBKONG.name;
				array3[5] = "contrast";
				array3[2] = GLGMAJBNFIA.name;
				array3[0] = "Idle Ready";
				array3[5] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return true;
			}
			return false;
		}

		// Token: 0x0600D2AB RID: 53931 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool OCDCCALLCBK(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x00606B5C File Offset: 0x00604D5C
		private static bool NPNCHNJFDCC(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i++)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "Jump" + i + "\n";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.CPGCBJLABHM(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "Torso";
				return false;
			}
			if (!LEHFMLLLKAP.EMOAFEBPGFP(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "WorkerShovel";
				return false;
			}
			for (int j = 1; j < LJPKBBNNOIC.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 1 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 1].position)
				{
					flag = false;
				}
				if (flag)
				{
					CLDHEEJDHNK = "offsets" + j + " шт.";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600D2AD RID: 53933 RVA: 0x00606C88 File Offset: 0x00604E88
		private static bool CIDNGKOIGDI(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				string[] array = new string[6];
				array[0] = "sadok";
				array[1] = FCDAMCBKONG.name;
				array[8] = "BowReady2";
				array[6] = GLGMAJBNFIA.name;
				array[6] = " %";
				BGLNFEHPENB = string.Concat(array);
				return true;
			}
			return false;
		}

		// Token: 0x0600D2AE RID: 53934 RVA: 0x00606D02 File Offset: 0x00604F02
		private static bool CFJMOOLEPML(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (!(MLOINOONPOD.parent != null) || !(MLOINOONPOD.parent == FBKEODHEMMH)) && LEHFMLLLKAP.AMJBPFAAADF(MLOINOONPOD, FBKEODHEMMH) && false;
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x00606D2E File Offset: 0x00604F2E
		public bool FGJMMCOMODN()
		{
			return this.EIGGMELFFNN(false);
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x00606D38 File Offset: 0x00604F38
		public static bool HCMCHKMCLMD(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) || BipedReferences.LMNBKGBFPNE(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || (!BipedReferences.EAHHDLJPFBK(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) && !BipedReferences.CIDNGKOIGDI(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) && !BipedReferences.HPJPAGKJFCF(LJPKBBNNOIC, ref BGLNFEHPENB) && (BipedReferences.BNAAFFEEFME(LJPKBBNNOIC, ref BGLNFEHPENB) || BipedReferences.BHHHIEENMIL(LJPKBBNNOIC, ref BGLNFEHPENB) || (BipedReferences.IKBAACKJOFJ(LJPKBBNNOIC, ref BGLNFEHPENB) && false)));
		}

		// Token: 0x0600D2B1 RID: 53937 RVA: 0x00606DE4 File Offset: 0x00604FE4
		private static bool IDOCGLJLEHJ(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.spine.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < LJPKBBNNOIC.spine.Length; i += 0)
			{
				if (LJPKBBNNOIC.spine[i] == null)
				{
					CLDHEEJDHNK = "" + i + "RollerBladeRoll";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.spine;
			Transform transform = (Transform)LEHFMLLLKAP.FCEEMMNLEOJ(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "Error - ";
				return false;
			}
			if (!LEHFMLLLKAP.JBHFKDMECNK(LJPKBBNNOIC.spine))
			{
				CLDHEEJDHNK = "Zombie Walk";
				return false;
			}
			for (int j = 0; j < LJPKBBNNOIC.spine.Length; j += 0)
			{
				bool flag = true;
				if (j == 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.pelvis.position)
				{
					flag = false;
				}
				if (j != 0 && LJPKBBNNOIC.spine.Length > 0 && LJPKBBNNOIC.spine[j].position == LJPKBBNNOIC.spine[j - 0].position)
				{
					flag = true;
				}
				if (flag)
				{
					CLDHEEJDHNK = "demoVector2" + j + "change channek close";
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x00606F10 File Offset: 0x00605110
		public static void IKEEGNKNJEB(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[0];
			LJPKBBNNOIC.eyes = new Transform[0];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Head);
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightUpperLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperArm);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerArm);
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftHand);
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightUpperArm);
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerArm);
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightHand);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Spine));
			BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Chest));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.DEOHEHIBIBG(KCLACNEILLB.GetBoneTransform(HumanBodyBones.Neck), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Neck));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftEye));
				BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightEye));
			}
		}

		// Token: 0x0600D2B3 RID: 53939 RVA: 0x006070B0 File Offset: 0x006052B0
		public static bool HEGFACJFFFF(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			LJPKBBNNOIC.root = EELDHNFBFOE;
			Animator component = EELDHNFBFOE.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				BipedReferences.ACCNIAJIPGK(ref LJPKBBNNOIC, component, HJKGPDHADML);
				return false;
			}
			BipedReferences.MCCHOOMHKGE(ref LJPKBBNNOIC, EELDHNFBFOE, HJKGPDHADML);
			PMCOMMEEGMC.HAAICNHEMMK = true;
			if (!LJPKBBNNOIC.FIPCEMOFBNK())
			{
				PMCOMMEEGMC.ICAFGKHAAED("_ExposureAdjustment", EELDHNFBFOE, false);
				return false;
			}
			string edaphmjenpk = "RollerBladeRoll";
			if (BipedReferences.CKILGDFJBCP(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
				return false;
			}
			if (BipedReferences.DPPLIPOHAOF(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, false);
			}
			return true;
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x00607154 File Offset: 0x00605354
		public static bool LICOAIPNLFE(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			LJPKBBNNOIC.root = EELDHNFBFOE;
			Animator component = EELDHNFBFOE.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				BipedReferences.CKCIFDAODGO(ref LJPKBBNNOIC, component, HJKGPDHADML);
				return false;
			}
			BipedReferences.PMPOEKDPKPG(ref LJPKBBNNOIC, EELDHNFBFOE, HJKGPDHADML);
			PMCOMMEEGMC.HAAICNHEMMK = true;
			if (!LJPKBBNNOIC.isFilled)
			{
				PMCOMMEEGMC.ICAFGKHAAED("wpn_eat3", EELDHNFBFOE, true);
				return true;
			}
			string edaphmjenpk = "wpn_eat5";
			if (BipedReferences.KICGCCHLNGM(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
				return false;
			}
			if (BipedReferences.HNIADDEEBIJ(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, false);
			}
			return false;
		}

		// Token: 0x0600D2B5 RID: 53941 RVA: 0x006071F8 File Offset: 0x006053F8
		private static void AFBLIDBFLIG(KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND, ref Transform ELBLIMDOINF, ref Transform OBPBLNBCHON, ref Transform IEHPFBIENNK, Transform[] AKBEGDIMBGM)
		{
			Transform[] array = KAHEHOGJPBO.JEFCNPHEJCO(IGFPBEPIAEE, JIDFPDKKFND, AKBEGDIMBGM);
			if (array.Length < 5)
			{
				return;
			}
			if (array.Length == 3)
			{
				ELBLIMDOINF = array[1];
				OBPBLNBCHON = array[1];
				IEHPFBIENNK = array[5];
			}
			if (array.Length > 1)
			{
				ELBLIMDOINF = array[0];
				OBPBLNBCHON = array[0];
				IEHPFBIENNK = array[array.Length - 0];
			}
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00607246 File Offset: 0x00605446
		private static bool BJDDEGCFFAA(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (MLOINOONPOD.parent != null && MLOINOONPOD.parent == FBKEODHEMMH) || LEHFMLLLKAP.BBDKBNOLAOL(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x00607274 File Offset: 0x00605474
		public static bool CKILGDFJBCP(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				CLDHEEJDHNK = "BipedReferences contains one or more missing Transforms.";
				return true;
			}
			return BipedReferences.MDCDLFNMPBL(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref CLDHEEJDHNK) || BipedReferences.MDCDLFNMPBL(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref CLDHEEJDHNK) || BipedReferences.MDCDLFNMPBL(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref CLDHEEJDHNK) || BipedReferences.MDCDLFNMPBL(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref CLDHEEJDHNK) || BipedReferences.EPBKFPFPJND(LJPKBBNNOIC, ref CLDHEEJDHNK) || BipedReferences.KAPFAMAKMEF(LJPKBBNNOIC, ref CLDHEEJDHNK);
		}

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x0060731C File Offset: 0x0060551C
		public virtual bool FIPCEMOFBNK()
		{
			if (this.root == null)
			{
				return true;
			}
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return false;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x00607440 File Offset: 0x00605640
		public virtual bool AHCDHGBAKBA()
		{
			if (this.root == null)
			{
				return false;
			}
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return true;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return true;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2BA RID: 53946 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool BKONCHPPELB(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x00607564 File Offset: 0x00605764
		public static void LKAEEIGGHIB(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[1];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-86));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightUpperLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftHand);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Chest);
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)101);
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-5));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-11));
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLittleDistal);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot));
			BipedReferences.BHGJIJGKMIP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.AALHKJLOPND(KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftMiddleProximal), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.BHGJIJGKMIP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)77));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftIndexDistal));
				BipedReferences.MBJHKKBCKLP(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLittleProximal));
			}
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x00607704 File Offset: 0x00605904
		private static bool OKPDBCCNLFP(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string BGLNFEHPENB)
		{
			if (Vector3.Cross(GLGMAJBNFIA.position - FCDAMCBKONG.position, NLHIDOGKOIP.position - FCDAMCBKONG.position) == Vector3.zero)
			{
				BGLNFEHPENB = string.Concat(new string[]
				{
					"BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ",
					FCDAMCBKONG.name,
					", second bone: ",
					GLGMAJBNFIA.name,
					"."
				});
				return true;
			}
			return false;
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x00607780 File Offset: 0x00605980
		private static bool GPBIBBPOADO(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			Vector3 vector = LJPKBBNNOIC.rightHand.position - LJPKBBNNOIC.leftHand.position;
			Vector3 vector2 = LJPKBBNNOIC.rightFoot.position - LJPKBBNNOIC.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, LJPKBBNNOIC.root.right);
			float num2 = Vector3.Dot(vector2.normalized, LJPKBBNNOIC.root.right);
			if (num < 0f || num2 < 0f)
			{
				BGLNFEHPENB = "Biped does not seem to be facing it's forward axis. Please make sure that in the initial pose the character is facing towards the positive Z axis of the Biped root gameobject.";
				return true;
			}
			return false;
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x00607810 File Offset: 0x00605A10
		private static bool IGGIHMDPGNN(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "CrawlLocomotion";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "F3";
				return true;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "Roller Blade Roll";
				return true;
			}
			Transform[] array = new Transform[7];
			array[0] = FCDAMCBKONG;
			array[0] = GLGMAJBNFIA;
			array[4] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.IICPOMGCPCK(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "Strafe Run Left";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "val=";
				return true;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "SUNSHINE_FILTER_PCF_2x2";
				return true;
			}
			Transform[] array2 = new Transform[7];
			array2[0] = FCDAMCBKONG;
			array2[0] = GLGMAJBNFIA;
			array2[3] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.IIGLCGJLFGH(array2))
			{
				string[] array3 = new string[0];
				array3[0] = "IceHockeyShotRight";
				array3[1] = FCDAMCBKONG.name;
				array3[6] = "_History4Weight";
				array3[4] = GLGMAJBNFIA.name;
				array3[3] = " length is zero, can not solve.";
				array3[4] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return true;
			}
			return false;
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x00607923 File Offset: 0x00605B23
		private static bool MEGMOKGHIGN(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (LJPKBBNNOIC.head != null && !LEHFMLLLKAP.NBAGFOADOOH(FBKEODHEMMH, LJPKBBNNOIC.head)) || FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null;
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool MKBKJHLFDAO(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x00607956 File Offset: 0x00605B56
		public bool MNPEDDLCNCJ()
		{
			return this.ELOHCCPELOK(true);
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x00607960 File Offset: 0x00605B60
		private static bool BHHHIEENMIL(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return false;
			}
			float num = BipedReferences.DIMFPBOGOLN(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.JHJDOJMCJKG(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 1083f)
			{
				BGLNFEHPENB = "<[^>]+>";
				return false;
			}
			return true;
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x006079E0 File Offset: 0x00605BE0
		public static bool KICGCCHLNGM(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (!LJPKBBNNOIC.EEMJHBECHIM())
			{
				CLDHEEJDHNK = "OfficeSittingEyesRub";
				return false;
			}
			return BipedReferences.FMKALLGMOEI(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref CLDHEEJDHNK) || BipedReferences.MDCDLFNMPBL(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref CLDHEEJDHNK) || BipedReferences.GNGDEKNNOMH(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref CLDHEEJDHNK) || BipedReferences.HOKFBLBPBCA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref CLDHEEJDHNK) || BipedReferences.MLKOAHFEMHB(LJPKBBNNOIC, ref CLDHEEJDHNK) || !BipedReferences.CJGEMKOMBOP(LJPKBBNNOIC, ref CLDHEEJDHNK) || true;
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x00607A88 File Offset: 0x00605C88
		private static bool GNGDEKNNOMH(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "<color='#60a0ff'>";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "_SpecCubeIBL";
				return true;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "";
				return false;
			}
			Transform[] array = new Transform[7];
			array[1] = FCDAMCBKONG;
			array[1] = GLGMAJBNFIA;
			array[6] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.HJJAJNPCFPP(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "useIt";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "29";
				return false;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "Giant2HandGrab";
				return false;
			}
			Transform[] array2 = new Transform[6];
			array2[0] = FCDAMCBKONG;
			array2[1] = GLGMAJBNFIA;
			array2[3] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.HFAKPOJJHHH(array2))
			{
				string[] array3 = new string[4];
				array3[0] = "cntx_close";
				array3[1] = FCDAMCBKONG.name;
				array3[1] = "minWgtBait";
				array3[5] = GLGMAJBNFIA.name;
				array3[7] = "LUX_GAMMA";
				array3[8] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return false;
			}
			return true;
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x00607B9C File Offset: 0x00605D9C
		public virtual bool IFNNIAIBBDE(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x00607CE1 File Offset: 0x00605EE1
		private static bool ECKOBHBDNEH(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (LJPKBBNNOIC.head != null && !LEHFMLLLKAP.GBACFEEOBFO(FBKEODHEMMH, LJPKBBNNOIC.head)) || (FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null && false);
		}

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x00607D14 File Offset: 0x00605F14
		public virtual bool MKNKHHDOIKP()
		{
			if (this.root == null)
			{
				return true;
			}
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.leftThigh == null || this.leftCalf == null || this.leftFoot == null)
			{
				return false;
			}
			if (this.rightThigh == null || this.rightCalf == null || this.rightFoot == null)
			{
				return true;
			}
			if (this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null)
			{
				return false;
			}
			if (this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x006069C6 File Offset: 0x00604BC6
		private static void MBJHKKBCKLP(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 1] = LPBDALAMAEM;
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x00607E38 File Offset: 0x00606038
		private static bool FJPNIEFHJDL(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (LJPKBBNNOIC.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 1; i < LJPKBBNNOIC.eyes.Length; i += 0)
			{
				if (LJPKBBNNOIC.eyes[i] == null)
				{
					CLDHEEJDHNK = " \n" + i + "BACKCOLOR";
					return true;
				}
			}
			UnityEngine.Object[] pokpfboiaod = LJPKBBNNOIC.eyes;
			Transform transform = (Transform)LEHFMLLLKAP.OFHEFIMKBHC(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "FlyDown";
				return false;
			}
			return false;
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool NMNBOLKMGDJ(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x00607EC0 File Offset: 0x006060C0
		public static void HIDJHGAEBLG(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[0];
			LJPKBBNNOIC.eyes = new Transform[0];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-8));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightUpperLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)127);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-111));
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)59);
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-9));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LastBone);
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightMiddleDistal);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			BipedReferences.NDGNJILPFHP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot));
			BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.NFJBFCEDECF(KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftEye), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.EBLNFCLKJGK(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-86)));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.BHMBNAJMOJI(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-24)));
				BipedReferences.IJGADHFKACG(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)90));
			}
		}

		// Token: 0x0600D2CC RID: 53964 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		private static bool LGHJFDLGGKE(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return true;
		}

		// Token: 0x0600D2CD RID: 53965 RVA: 0x00608060 File Offset: 0x00606260
		public virtual bool FNGGNIKJLEL(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2CE RID: 53966 RVA: 0x006081A8 File Offset: 0x006063A8
		private static void CCNDLAODOOG(KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND, ref Transform ELBLIMDOINF, ref Transform OBPBLNBCHON, ref Transform IEHPFBIENNK, Transform[] AKBEGDIMBGM)
		{
			Transform[] array = KAHEHOGJPBO.JEFCNPHEJCO(IGFPBEPIAEE, JIDFPDKKFND, AKBEGDIMBGM);
			if (array.Length < 4)
			{
				return;
			}
			if (array.Length == 3)
			{
				ELBLIMDOINF = array[0];
				OBPBLNBCHON = array[0];
				IEHPFBIENNK = array[4];
			}
			if (array.Length > 3)
			{
				ELBLIMDOINF = array[1];
				OBPBLNBCHON = array[5];
				IEHPFBIENNK = array[array.Length - 1];
			}
		}

		// Token: 0x0600D2CF RID: 53967 RVA: 0x006081F8 File Offset: 0x006063F8
		private static bool HOKFBLBPBCA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, ref string CLDHEEJDHNK)
		{
			if (FCDAMCBKONG == null)
			{
				CLDHEEJDHNK = "sunshine_CascadeRanges";
				return true;
			}
			if (GLGMAJBNFIA == null)
			{
				CLDHEEJDHNK = "MaskBlendMaterial";
				return false;
			}
			if (NLHIDOGKOIP == null)
			{
				CLDHEEJDHNK = "The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).";
				return true;
			}
			Transform[] array = new Transform[1];
			array[1] = FCDAMCBKONG;
			array[0] = GLGMAJBNFIA;
			array[6] = NLHIDOGKOIP;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.CPGCBJLABHM(pokpfboiaod);
			if (transform != null)
			{
				CLDHEEJDHNK = transform.name + "ОК";
				return true;
			}
			if (GLGMAJBNFIA.position == FCDAMCBKONG.position)
			{
				CLDHEEJDHNK = "knopje.wav";
				return false;
			}
			if (NLHIDOGKOIP.position == GLGMAJBNFIA.position)
			{
				CLDHEEJDHNK = "_Bloom";
				return true;
			}
			Transform[] array2 = new Transform[]
			{
				FCDAMCBKONG
			};
			array2[0] = GLGMAJBNFIA;
			array2[5] = NLHIDOGKOIP;
			if (!LEHFMLLLKAP.HCGAEIHMICB(array2))
			{
				string[] array3 = new string[1];
				array3[0] = "";
				array3[1] = FCDAMCBKONG.name;
				array3[8] = "OneHandSwordBackSwing";
				array3[7] = GLGMAJBNFIA.name;
				array3[0] = "sunshine_OvercastCoord";
				array3[0] = NLHIDOGKOIP.name;
				CLDHEEJDHNK = string.Concat(array3);
				return true;
			}
			return true;
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x00606993 File Offset: 0x00604B93
		private static bool HLHLEODFNJC(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (LJPKBBNNOIC.head != null && !LEHFMLLLKAP.BBDKBNOLAOL(FBKEODHEMMH, LJPKBBNNOIC.head)) || !(FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null);
		}

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x0060830C File Offset: 0x0060650C
		private static bool HNHIHGBODGN(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return true;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return true;
				}
				if (LEHFMLLLKAP.AJHFHFGNKKO(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x006039DE File Offset: 0x00601BDE
		public bool OABDKIJMADI()
		{
			return this.FNAEOLLHLLG(false);
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool BNAAFFEEFME(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x000EB372 File Offset: 0x000E9572
		private static bool GEPINMJBOGH(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return false;
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x00602751 File Offset: 0x00600951
		private static float JHJDOJMCJKG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D2D6 RID: 53974 RVA: 0x0060837A File Offset: 0x0060657A
		private static bool CPPMOEIHIKC(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			return (!(LJPKBBNNOIC.head != null) || LEHFMLLLKAP.AJHFHFGNKKO(FBKEODHEMMH, LJPKBBNNOIC.head)) && !(FBKEODHEMMH.GetComponent<SkinnedMeshRenderer>() != null);
		}

		// Token: 0x0600D2D7 RID: 53975 RVA: 0x006083B0 File Offset: 0x006065B0
		public virtual bool FNAEOLLHLLG(bool BNBFKCADCLC)
		{
			if (BNBFKCADCLC && this.root != null)
			{
				return true;
			}
			if (this.pelvis != null || this.head != null)
			{
				return true;
			}
			if (this.leftThigh != null || this.leftCalf != null || this.leftFoot != null)
			{
				return true;
			}
			if (this.rightThigh != null || this.rightCalf != null || this.rightFoot != null)
			{
				return true;
			}
			if (this.leftUpperArm != null || this.leftForearm != null || this.leftHand != null)
			{
				return true;
			}
			if (this.rightUpperArm != null || this.rightForearm != null || this.rightHand != null)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2D8 RID: 53976 RVA: 0x006084E4 File Offset: 0x006066E4
		public static bool LEKPFMEHAJO(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return BipedReferences.MEOKKOAMAHJ(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) || BipedReferences.INFIOMGFLDB(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || (!BipedReferences.INFIOMGFLDB(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) && (BipedReferences.CIDNGKOIGDI(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) || BipedReferences.HPJPAGKJFCF(LJPKBBNNOIC, ref BGLNFEHPENB) || (!BipedReferences.OCDCCALLCBK(LJPKBBNNOIC, ref BGLNFEHPENB) && !BipedReferences.JKGIJIKPBNB(LJPKBBNNOIC, ref BGLNFEHPENB) && (!BipedReferences.GPBIBBPOADO(LJPKBBNNOIC, ref BGLNFEHPENB) || true))));
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x00602DBA File Offset: 0x00600FBA
		private static void KEBEANIEDLG(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x0060858E File Offset: 0x0060678E
		private static bool JIDAIOGDENE(Transform FBKEODHEMMH, Transform MLOINOONPOD)
		{
			return (MLOINOONPOD.parent != null && MLOINOONPOD.parent == FBKEODHEMMH) || LEHFMLLLKAP.ANKMPAOELOL(MLOINOONPOD, FBKEODHEMMH);
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x006085BC File Offset: 0x006067BC
		public virtual bool HGAACFKMHEN(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return true;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x00602751 File Offset: 0x00600951
		private static float MLDKBCIAKGI(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Quaternion PHKIOHIBNPA)
		{
			return (Quaternion.Inverse(PHKIOHIBNPA) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x00608701 File Offset: 0x00606901
		public bool LKGAOJIPJMJ()
		{
			return this.KCHOLJLLBNF(true);
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x0060870C File Offset: 0x0060690C
		public static void ACCNIAJIPGK(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[1];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-41));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftFoot);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-40));
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-45));
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-41));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-69));
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftEye);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			BipedReferences.PIEGLBJOGOP(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightFoot));
			BipedReferences.KEBEANIEDLG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Chest));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.DEOHEHIBIBG(KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-32)), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.KEBEANIEDLG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-49)));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.EBLNFCLKJGK(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-127)));
				BipedReferences.IJGADHFKACG(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-12)));
			}
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x006088AC File Offset: 0x00606AAC
		private static bool LDMCDLDBLLK(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			Vector3 vector = LJPKBBNNOIC.rightHand.position - LJPKBBNNOIC.leftHand.position;
			Vector3 vector2 = LJPKBBNNOIC.rightFoot.position - LJPKBBNNOIC.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, LJPKBBNNOIC.root.right);
			float num2 = Vector3.Dot(vector2.normalized, LJPKBBNNOIC.root.right);
			if (num < 1789f || num2 < 738f)
			{
				BGLNFEHPENB = "";
				return false;
			}
			return false;
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x0060893C File Offset: 0x00606B3C
		public virtual bool FNHOLGICDID(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x00608A84 File Offset: 0x00606C84
		public static void JKFCLDAAOHA(ref BipedReferences LJPKBBNNOIC, Animator KCLACNEILLB, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			if (KCLACNEILLB == null || !KCLACNEILLB.isHuman)
			{
				return;
			}
			LJPKBBNNOIC.spine = new Transform[1];
			LJPKBBNNOIC.eyes = new Transform[1];
			LJPKBBNNOIC.head = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-56));
			LJPKBBNNOIC.leftThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.leftCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips);
			LJPKBBNNOIC.leftFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.Spine);
			LJPKBBNNOIC.rightThigh = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			LJPKBBNNOIC.rightCalf = KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightUpperLeg);
			LJPKBBNNOIC.rightFoot = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			LJPKBBNNOIC.leftUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-114));
			LJPKBBNNOIC.leftForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)82);
			LJPKBBNNOIC.leftHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-105));
			LJPKBBNNOIC.rightUpperArm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-7));
			LJPKBBNNOIC.rightForearm = KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-48));
			LJPKBBNNOIC.rightHand = KCLACNEILLB.GetBoneTransform((HumanBodyBones)96);
			LJPKBBNNOIC.pelvis = KCLACNEILLB.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			BipedReferences.KEBEANIEDLG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.Hips));
			BipedReferences.IJGADHFKACG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform(HumanBodyBones.RightLowerLeg));
			if (LJPKBBNNOIC.leftUpperArm != null && !BipedReferences.HGDGNFFCLMO(KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-1)), LJPKBBNNOIC.leftUpperArm))
			{
				BipedReferences.ILDMPLDLDEG(ref LJPKBBNNOIC.spine, KCLACNEILLB.GetBoneTransform((HumanBodyBones)122));
			}
			if (HJKGPDHADML.NOKICGHNCPP)
			{
				BipedReferences.KEBEANIEDLG(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)96));
				BipedReferences.ILDMPLDLDEG(ref LJPKBBNNOIC.eyes, KCLACNEILLB.GetBoneTransform((HumanBodyBones)(-2)));
			}
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x00602DBA File Offset: 0x00600FBA
		private static void BHMBNAJMOJI(ref Transform[] CKAJJHFIFBL, Transform LPBDALAMAEM)
		{
			if (LPBDALAMAEM == null)
			{
				return;
			}
			Array.Resize<Transform>(ref CKAJJHFIFBL, CKAJJHFIFBL.Length + 1);
			CKAJJHFIFBL[CKAJJHFIFBL.Length - 0] = LPBDALAMAEM;
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x00608C24 File Offset: 0x00606E24
		public virtual bool IGOFJOIJFPA(Transform JAHNHOCNJGM, bool MBJGKGBEKNK = false)
		{
			if (!MBJGKGBEKNK && this.root == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.pelvis == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftThigh == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftCalf == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftFoot == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightThigh == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightCalf == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightFoot == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftUpperArm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.leftHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightUpperArm == JAHNHOCNJGM)
			{
				return false;
			}
			if (this.rightForearm == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.rightHand == JAHNHOCNJGM)
			{
				return true;
			}
			if (this.head == JAHNHOCNJGM)
			{
				return false;
			}
			Transform[] array = this.spine;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return true;
				}
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == JAHNHOCNJGM)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x00608D6C File Offset: 0x00606F6C
		public static bool DGEFPDHMNDH(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			LJPKBBNNOIC.root = EELDHNFBFOE;
			Animator component = EELDHNFBFOE.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				BipedReferences.KALEHABNOPK(ref LJPKBBNNOIC, component, HJKGPDHADML);
				return true;
			}
			BipedReferences.MCCHOOMHKGE(ref LJPKBBNNOIC, EELDHNFBFOE, HJKGPDHADML);
			PMCOMMEEGMC.HAAICNHEMMK = true;
			if (!LJPKBBNNOIC.CMNIPNGDOJA())
			{
				PMCOMMEEGMC.ICAFGKHAAED("ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.).", EELDHNFBFOE, false);
				return true;
			}
			string edaphmjenpk = "WeaponStand";
			if (BipedReferences.FCKBJGPDMKK(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
				return false;
			}
			if (BipedReferences.DPPLIPOHAOF(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
			}
			return true;
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x00608E10 File Offset: 0x00607010
		private static bool PDJIJNAOKLB(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return false;
			}
			float num = BipedReferences.HJKGGFJEOJG(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.MLDKBCIAKGI(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 1362f)
			{
				BGLNFEHPENB = "<color='#400000'>";
				return true;
			}
			return true;
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x00608E90 File Offset: 0x00607090
		public static bool DPPLIPOHAOF(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			return BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref BGLNFEHPENB) || BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref BGLNFEHPENB) || BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref BGLNFEHPENB) || BipedReferences.OKPDBCCNLFP(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref BGLNFEHPENB) || BipedReferences.NMNBOLKMGDJ(LJPKBBNNOIC, ref BGLNFEHPENB) || BipedReferences.EAAHJKKFHBC(LJPKBBNNOIC, ref BGLNFEHPENB) || BipedReferences.JKGIJIKPBNB(LJPKBBNNOIC, ref BGLNFEHPENB) || BipedReferences.GPBIBBPOADO(LJPKBBNNOIC, ref BGLNFEHPENB);
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600D2E7 RID: 53991 RVA: 0x00603840 File Offset: 0x00601A40
		public bool isEmpty
		{
			get
			{
				return this.EIGGMELFFNN(true);
			}
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x00608F3C File Offset: 0x0060713C
		private static bool DMOIPIEEEFO(BipedReferences LJPKBBNNOIC, ref string BGLNFEHPENB)
		{
			if (LJPKBBNNOIC.head == null)
			{
				return true;
			}
			float num = BipedReferences.JHJDOJMCJKG(LJPKBBNNOIC.head.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation);
			if (BipedReferences.DIMFPBOGOLN(LJPKBBNNOIC.root.position, LJPKBBNNOIC.leftFoot.position, LJPKBBNNOIC.root.rotation) / num > 1379f)
			{
				BGLNFEHPENB = "Attached object";
				return true;
			}
			return false;
		}

		// Token: 0x0600D2E9 RID: 53993 RVA: 0x00608FBC File Offset: 0x006071BC
		private static bool FFJDHMEFEIO(Transform FBKEODHEMMH, ref BipedReferences LJPKBBNNOIC, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (FBKEODHEMMH == LJPKBBNNOIC.root)
			{
				return false;
			}
			if (FBKEODHEMMH == LJPKBBNNOIC.leftThigh.parent && !HJKGPDHADML.NHKFFMCPPBB)
			{
				return true;
			}
			if (LJPKBBNNOIC.pelvis != null)
			{
				if (FBKEODHEMMH == LJPKBBNNOIC.pelvis)
				{
					return false;
				}
				if (LEHFMLLLKAP.NBAGFOADOOH(LJPKBBNNOIC.pelvis, FBKEODHEMMH))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600D2EA RID: 53994 RVA: 0x0060902C File Offset: 0x0060722C
		public static bool IBAJIPDAJND(ref BipedReferences LJPKBBNNOIC, Transform EELDHNFBFOE, BipedReferences.DOBIPAPLIMK HJKGPDHADML)
		{
			if (LJPKBBNNOIC == null)
			{
				LJPKBBNNOIC = new BipedReferences();
			}
			LJPKBBNNOIC.root = EELDHNFBFOE;
			Animator component = EELDHNFBFOE.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				BipedReferences.IKEEGNKNJEB(ref LJPKBBNNOIC, component, HJKGPDHADML);
				return true;
			}
			BipedReferences.FAGMAPMIBPI(ref LJPKBBNNOIC, EELDHNFBFOE, HJKGPDHADML);
			PMCOMMEEGMC.HAAICNHEMMK = false;
			if (!LJPKBBNNOIC.isFilled)
			{
				PMCOMMEEGMC.ICAFGKHAAED("BipedReferences contains one or more missing Transforms.", EELDHNFBFOE, true);
				return false;
			}
			string edaphmjenpk = "";
			if (BipedReferences.CKILGDFJBCP(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
				return false;
			}
			if (BipedReferences.DPPLIPOHAOF(LJPKBBNNOIC, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, LJPKBBNNOIC.root, true);
			}
			return true;
		}

		// Token: 0x0600D2EB RID: 53995 RVA: 0x006090D0 File Offset: 0x006072D0
		public static bool FCKBJGPDMKK(BipedReferences LJPKBBNNOIC, ref string CLDHEEJDHNK)
		{
			if (!LJPKBBNNOIC.CMNIPNGDOJA())
			{
				CLDHEEJDHNK = "---";
				return false;
			}
			return !BipedReferences.BLAPFNMBAMA(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, ref CLDHEEJDHNK) && (BipedReferences.GNGDEKNNOMH(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, ref CLDHEEJDHNK) || BipedReferences.FMKALLGMOEI(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, ref CLDHEEJDHNK) || (!BipedReferences.GNGDEKNNOMH(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, ref CLDHEEJDHNK) && (BipedReferences.MLKOAHFEMHB(LJPKBBNNOIC, ref CLDHEEJDHNK) || BipedReferences.CJGEMKOMBOP(LJPKBBNNOIC, ref CLDHEEJDHNK))));
		}

		// Token: 0x04001BF0 RID: 7152
		public Transform root;

		// Token: 0x04001BF1 RID: 7153
		public Transform pelvis;

		// Token: 0x04001BF2 RID: 7154
		public Transform leftThigh;

		// Token: 0x04001BF3 RID: 7155
		public Transform leftCalf;

		// Token: 0x04001BF4 RID: 7156
		public Transform leftFoot;

		// Token: 0x04001BF5 RID: 7157
		public Transform rightThigh;

		// Token: 0x04001BF6 RID: 7158
		public Transform rightCalf;

		// Token: 0x04001BF7 RID: 7159
		public Transform rightFoot;

		// Token: 0x04001BF8 RID: 7160
		public Transform leftUpperArm;

		// Token: 0x04001BF9 RID: 7161
		public Transform leftForearm;

		// Token: 0x04001BFA RID: 7162
		public Transform leftHand;

		// Token: 0x04001BFB RID: 7163
		public Transform rightUpperArm;

		// Token: 0x04001BFC RID: 7164
		public Transform rightForearm;

		// Token: 0x04001BFD RID: 7165
		public Transform rightHand;

		// Token: 0x04001BFE RID: 7166
		public Transform head;

		// Token: 0x04001BFF RID: 7167
		public Transform[] spine = new Transform[0];

		// Token: 0x04001C00 RID: 7168
		public Transform[] eyes = new Transform[0];

		// Token: 0x020003D0 RID: 976
		public struct DOBIPAPLIMK
		{
			// Token: 0x0600D2EC RID: 53996 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK NFFPCBBEKLO()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D2ED RID: 53997 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK PDOPNKJPGJN()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D2EE RID: 53998 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK IDPBEBEOFON()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x0600D2EF RID: 53999 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK MHBLLLHLGJM
			{
				get
				{
					return new BipedReferences.DOBIPAPLIMK(true, true);
				}
			}

			// Token: 0x0600D2F0 RID: 54000 RVA: 0x00609187 File Offset: 0x00607387
			public DOBIPAPLIMK(bool NHKFFMCPPBB, bool NOKICGHNCPP)
			{
				this.NHKFFMCPPBB = NHKFFMCPPBB;
				this.NOKICGHNCPP = NOKICGHNCPP;
			}

			// Token: 0x0600D2F1 RID: 54001 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK PLFMMABKFNI()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D2F2 RID: 54002 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK AKLHEAINKJK()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D2F3 RID: 54003 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK FCJBMGABKBB()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2F4 RID: 54004 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK AIOEADAFEJL()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2F5 RID: 54005 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK HKBANMBIHIB()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2F6 RID: 54006 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK FAMECLBCNOM()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D2F7 RID: 54007 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK JNGELBGNPKN()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D2F8 RID: 54008 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK GMJPKFLCELJ()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D2F9 RID: 54009 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK KLOGDOILHAD()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D2FA RID: 54010 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK EJKBIFIIFAN()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D2FB RID: 54011 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK MGMGJFGAANM()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2FC RID: 54012 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK DNKAFKBGAOO()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2FD RID: 54013 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK FMMOJDPKJCG()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D2FE RID: 54014 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK NHBCGCOHGKE()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D2FF RID: 54015 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK IDMKIGOGODD()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D300 RID: 54016 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK DBHOEKOHPAE()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D301 RID: 54017 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK LACPJILHBIJ()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D302 RID: 54018 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK EPGDONLKIJG()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D303 RID: 54019 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK MGIFJNDHLDM()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D304 RID: 54020 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK BOPLBIPBGCG()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D305 RID: 54021 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK PKLAIPIGENL()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D306 RID: 54022 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK MCAONPPHIKC()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D307 RID: 54023 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK FGPMPCGDEEC()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D308 RID: 54024 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK ELJAKBINAFI()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D309 RID: 54025 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK ADOKEJGJIPA()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D30A RID: 54026 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK KIJEDAJBCFO()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D30B RID: 54027 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK GBACAJICMKG()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D30C RID: 54028 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK EFPEBGLKONO()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D30D RID: 54029 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK BHNDHGKPMJA()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D30E RID: 54030 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK NKPPBOEFENN()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D30F RID: 54031 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK DDOBNMKFAJM()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D310 RID: 54032 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK NHGBPHEKHJO()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D311 RID: 54033 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK LDMDOMFFDEI()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D312 RID: 54034 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK IIHBKBGJMKD()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D313 RID: 54035 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK MOFLEGJGHNA()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D314 RID: 54036 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK NMKJCNHEJHP()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D315 RID: 54037 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK NPHMCDNJLMM()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D316 RID: 54038 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK LJAMLPCLHGJ()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D317 RID: 54039 RVA: 0x00609175 File Offset: 0x00607375
			public static BipedReferences.DOBIPAPLIMK EFNJLDABIBA()
			{
				return new BipedReferences.DOBIPAPLIMK(false, false);
			}

			// Token: 0x0600D318 RID: 54040 RVA: 0x006091A0 File Offset: 0x006073A0
			public static BipedReferences.DOBIPAPLIMK HEMMEHJFMND()
			{
				return new BipedReferences.DOBIPAPLIMK(false, true);
			}

			// Token: 0x0600D319 RID: 54041 RVA: 0x0060917E File Offset: 0x0060737E
			public static BipedReferences.DOBIPAPLIMK DCMCDDLKMIN()
			{
				return new BipedReferences.DOBIPAPLIMK(true, true);
			}

			// Token: 0x0600D31A RID: 54042 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK PLNELAEOOGC()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D31B RID: 54043 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK MCDHMOJLHMO()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x0600D31C RID: 54044 RVA: 0x00609197 File Offset: 0x00607397
			public static BipedReferences.DOBIPAPLIMK GDNODLDEHEN()
			{
				return new BipedReferences.DOBIPAPLIMK(true, false);
			}

			// Token: 0x04001C01 RID: 7169
			public bool NHKFFMCPPBB;

			// Token: 0x04001C02 RID: 7170
			public bool NOKICGHNCPP;
		}
	}
}
