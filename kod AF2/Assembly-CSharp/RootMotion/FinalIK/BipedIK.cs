using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000439 RID: 1081
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		// Token: 0x0600E867 RID: 59495 RVA: 0x00698E9A File Offset: 0x0069709A
		public void BNJHEHMLIOL()
		{
			this.DKKLHMINBAN();
		}

		// Token: 0x0600E868 RID: 59496 RVA: 0x00698EA4 File Offset: 0x006970A4
		protected virtual void NCBAHFAALOF()
		{
			for (int i = 1; i < this.solvers.LBHJFINAMKL().Length; i += 0)
			{
				this.solvers.KBMCKCHDCNP()[i].HICNGACLCMD();
				this.solvers.LMEEEBGPNOC()[i].PIFJIKJOBLA();
			}
			this.solvers.pelvis.GDBBAMFMKII();
			if (this.solvers.spine.bones.Length > 0)
			{
				this.solvers.spine.FANPFKHEDPA();
			}
			this.solvers.aim.FANPFKHEDPA();
			this.solvers.lookAt.FANPFKHEDPA();
			for (int j = 1; j < this.solvers.EHDPJEMLLCP().Length; j += 0)
			{
				this.solvers.OCNLLBPGKJL()[j].FANPFKHEDPA();
			}
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x00698F6C File Offset: 0x0069716C
		private void EHBIAEONLMF()
		{
			Application.OpenURL("System.Single");
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x00698F78 File Offset: 0x00697178
		protected override void MBOPIBBAHOD()
		{
			for (int i = 0; i < this.solvers.limbs.Length; i++)
			{
				this.solvers.limbs[i].JJMFHEOEFNA();
				this.solvers.limbs[i].BNIFPFDCHGB();
			}
			this.solvers.pelvis.FANPFKHEDPA();
			if (this.solvers.spine.bones.Length > 1)
			{
				this.solvers.spine.FANPFKHEDPA();
			}
			this.solvers.aim.FANPFKHEDPA();
			this.solvers.lookAt.FANPFKHEDPA();
			for (int j = 0; j < this.solvers.limbs.Length; j++)
			{
				this.solvers.limbs[j].FANPFKHEDPA();
			}
		}

		// Token: 0x0600E86B RID: 59499 RVA: 0x00699040 File Offset: 0x00697240
		private void INMDGMIHMIF()
		{
			Application.OpenURL("usr_inf_a3");
		}

		// Token: 0x0600E86C RID: 59500 RVA: 0x0069904C File Offset: 0x0069724C
		public void JJLOGFJHEKH(Vector3 ICPIKFAGMAH)
		{
			this.solvers.spine.HJHGGGEMEBJ(ICPIKFAGMAH);
		}

		// Token: 0x0600E86D RID: 59501 RVA: 0x00699060 File Offset: 0x00697260
		protected override void MPJFMFOPHKJ()
		{
			string edaphmjenpk = "";
			if (BipedReferences.CKILGDFJBCP(this.references, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, this.references.root, false);
				return;
			}
			this.solvers.DECIGIFCPJG(this.references);
			if (this.solvers.spine.bones.Length > 1)
			{
				this.solvers.spine.BHALELINNDJ(base.transform);
			}
			this.solvers.lookAt.BHALELINNDJ(base.transform);
			this.solvers.aim.BHALELINNDJ(base.transform);
			IKSolverLimb[] limbs = this.solvers.limbs;
			for (int i = 0; i < limbs.Length; i++)
			{
				limbs[i].BHALELINNDJ(base.transform);
			}
			this.solvers.pelvis.BHALELINNDJ(this.references.pelvis);
		}

		// Token: 0x0600E86E RID: 59502 RVA: 0x00699140 File Offset: 0x00697340
		protected virtual void ALMMFGEMGHL()
		{
			this.solvers.lookAt.BLOEEPCIPKJ();
			for (int i = 1; i < this.solvers.MHOGIPCHKGJ().Length; i++)
			{
				this.solvers.HECNIFEOMLD()[i].BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600E86F RID: 59503 RVA: 0x00699187 File Offset: 0x00697387
		public void NHFPNLLFJBP()
		{
			this.GGDKOMKKEIG();
		}

		// Token: 0x0600E870 RID: 59504 RVA: 0x0069918F File Offset: 0x0069738F
		public float GetIKPositionWeight(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E871 RID: 59505 RVA: 0x0069918F File Offset: 0x0069738F
		public float FPFMDFBMHEE(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E872 RID: 59506 RVA: 0x0069919D File Offset: 0x0069739D
		private void GOCHJDILHDH()
		{
			Application.OpenURL("H:");
		}

		// Token: 0x0600E873 RID: 59507 RVA: 0x006991A9 File Offset: 0x006973A9
		public void CPDFKMFDFOE(float NKHBAJKMAGD)
		{
			this.solvers.spine.BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E874 RID: 59508 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600E875 RID: 59509 RVA: 0x006991C8 File Offset: 0x006973C8
		private void KIOBNGIOBBJ()
		{
			Application.OpenURL("</color>");
		}

		// Token: 0x0600E876 RID: 59510 RVA: 0x006991D4 File Offset: 0x006973D4
		protected virtual void FJCCLIHFBLA()
		{
			for (int i = 1; i < this.solvers.ODOHJNILJMK().Length; i++)
			{
				this.solvers.GBKIHMBNCCA()[i].DBMGEMOPLIC();
				this.solvers.KFMLOEDDCHD()[i].BEBOBNKBGHF();
			}
			this.solvers.pelvis.DAFJMNMFOON();
			if (this.solvers.spine.bones.Length > 0)
			{
				this.solvers.spine.FANPFKHEDPA();
			}
			this.solvers.aim.FANPFKHEDPA();
			this.solvers.lookAt.FANPFKHEDPA();
			for (int j = 0; j < this.solvers.HKJLNNHJICJ().Length; j += 0)
			{
				this.solvers.LBHJFINAMKL()[j].FANPFKHEDPA();
			}
		}

		// Token: 0x0600E877 RID: 59511 RVA: 0x0069929C File Offset: 0x0069749C
		public void SetIKPosition(AvatarIKGoal AEFBPOBJBII, Vector3 CGAMODJNLAC)
		{
			this.GetGoalIK(AEFBPOBJBII).HJHGGGEMEBJ(CGAMODJNLAC);
		}

		// Token: 0x0600E878 RID: 59512 RVA: 0x006992AB File Offset: 0x006974AB
		private void FGMGJONNLGO()
		{
			Application.OpenURL("Crouch");
		}

		// Token: 0x0600E879 RID: 59513 RVA: 0x006992B7 File Offset: 0x006974B7
		private void AKOKGDLNCJA()
		{
			Application.OpenURL("sound");
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x006992C3 File Offset: 0x006974C3
		public void SetIKPositionWeight(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E87B RID: 59515 RVA: 0x006992D2 File Offset: 0x006974D2
		private void FCLBIKJAOFP()
		{
			Application.OpenURL("SoccerStartKick");
		}

		// Token: 0x0600E87C RID: 59516 RVA: 0x006992DE File Offset: 0x006974DE
		public void LogWarning(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, base.transform, false);
		}

		// Token: 0x0600E87D RID: 59517 RVA: 0x006992ED File Offset: 0x006974ED
		public Quaternion KHNENMMEPDI(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MHCONDPMHGM();
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x006992FB File Offset: 0x006974FB
		public float GKOPFCIHIEN(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).HDDNECMIPAB();
		}

		// Token: 0x0600E87F RID: 59519 RVA: 0x00699309 File Offset: 0x00697509
		private void MDAOLMGHOKG()
		{
			Application.OpenURL("#a0ffa0");
		}

		// Token: 0x0600E880 RID: 59520 RVA: 0x00699187 File Offset: 0x00697387
		public void ONGHHPNGHPG()
		{
			this.GGDKOMKKEIG();
		}

		// Token: 0x0600E881 RID: 59521 RVA: 0x00699315 File Offset: 0x00697515
		public void IKNEBLLFLAD(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x00699324 File Offset: 0x00697524
		private void GOBPKNJPLFB()
		{
			Application.OpenURL("Forward");
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x00699330 File Offset: 0x00697530
		public void FDGIEGOJLKB(Vector3 GAMIBJKANIB)
		{
			this.solvers.lookAt.HJHGGGEMEBJ(GAMIBJKANIB);
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x00699344 File Offset: 0x00697544
		public IKSolverLimb ODPLPENLNBF(AvatarIKGoal AEFBPOBJBII)
		{
			switch (AEFBPOBJBII)
			{
			case AvatarIKGoal.LeftFoot:
				return this.solvers.leftFoot;
			case AvatarIKGoal.RightFoot:
				return this.solvers.rightFoot;
			case AvatarIKGoal.LeftHand:
				return this.solvers.leftHand;
			case AvatarIKGoal.RightHand:
				return this.solvers.rightHand;
			default:
				return null;
			}
		}

		// Token: 0x0600E885 RID: 59525 RVA: 0x0069939A File Offset: 0x0069759A
		private void KHOCIHGGAFP()
		{
			Application.OpenURL("Road Points Marker Left");
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x006993C4 File Offset: 0x006975C4
		public void KCPKDICMFFE()
		{
			this.MPJFMFOPHKJ();
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x006993CC File Offset: 0x006975CC
		public void FKEJMMNABPK()
		{
			this.KJBCCKCIOLJ();
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x006993D4 File Offset: 0x006975D4
		public void KHKPIPKFJOG(AvatarIKGoal AEFBPOBJBII, Vector3 CGAMODJNLAC)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).HJHGGGEMEBJ(CGAMODJNLAC);
		}

		// Token: 0x0600E88A RID: 59530 RVA: 0x006993E3 File Offset: 0x006975E3
		public void EJJIFIMNJGG()
		{
			this.NGHAJHMEKLH();
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x006993C4 File Offset: 0x006975C4
		public void InitiateBipedIK()
		{
			this.MPJFMFOPHKJ();
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x006993EB File Offset: 0x006975EB
		public void SetIKRotation(AvatarIKGoal AEFBPOBJBII, Quaternion PBKNPIGHLGG)
		{
			this.GetGoalIK(AEFBPOBJBII).EMNHOLIPCKJ(PBKNPIGHLGG);
		}

		// Token: 0x0600E88D RID: 59533 RVA: 0x006993FA File Offset: 0x006975FA
		public Vector3 JBKLHABJKKG(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).AEPMIDGGBAP();
		}

		// Token: 0x0600E88E RID: 59534 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void DAACBFHENID()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600E88F RID: 59535 RVA: 0x00699408 File Offset: 0x00697608
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page2.html");
		}

		// Token: 0x0600E890 RID: 59536 RVA: 0x00699414 File Offset: 0x00697614
		protected virtual void PDJLMMFOGIF()
		{
			this.solvers.lookAt.BLOEEPCIPKJ();
			for (int i = 1; i < this.solvers.ODOHJNILJMK().Length; i += 0)
			{
				this.solvers.MPFOMCNOGEI()[i].BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600E891 RID: 59537 RVA: 0x006993E3 File Offset: 0x006975E3
		public void JCFJPINIKHC()
		{
			this.NGHAJHMEKLH();
		}

		// Token: 0x0600E892 RID: 59538 RVA: 0x0069918F File Offset: 0x0069738F
		public float ELABHIPNMFK(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E893 RID: 59539 RVA: 0x00698E9A File Offset: 0x0069709A
		public void MBFEECNHAHP()
		{
			this.DKKLHMINBAN();
		}

		// Token: 0x0600E894 RID: 59540 RVA: 0x0069945B File Offset: 0x0069765B
		public void HECGFCIEFAD()
		{
			this.DPFGGOJNKON();
		}

		// Token: 0x0600E895 RID: 59541 RVA: 0x0069918F File Offset: 0x0069738F
		public float DNMPONLACAP(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E896 RID: 59542 RVA: 0x00699463 File Offset: 0x00697663
		public void BAOIEBPBKDG(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, base.transform, true);
		}

		// Token: 0x0600E897 RID: 59543 RVA: 0x006991A9 File Offset: 0x006973A9
		public void SetSpineWeight(float NKHBAJKMAGD)
		{
			this.solvers.spine.BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x00699187 File Offset: 0x00697387
		public void FALEMCOMEGG()
		{
			this.GGDKOMKKEIG();
		}

		// Token: 0x0600E899 RID: 59545 RVA: 0x0069904C File Offset: 0x0069724C
		public void DNKCFLDFONK(Vector3 ICPIKFAGMAH)
		{
			this.solvers.spine.HJHGGGEMEBJ(ICPIKFAGMAH);
		}

		// Token: 0x0600E89A RID: 59546 RVA: 0x00699472 File Offset: 0x00697672
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html");
		}

		// Token: 0x0600E89B RID: 59547 RVA: 0x0069947E File Offset: 0x0069767E
		public void IECAFJLMPDP(AvatarIKGoal AEFBPOBJBII, Quaternion PBKNPIGHLGG)
		{
			this.GetGoalIK(AEFBPOBJBII).ELCEBBGFNFN(PBKNPIGHLGG);
		}

		// Token: 0x0600E89C RID: 59548 RVA: 0x0069948D File Offset: 0x0069768D
		public Vector3 JHOJCJKDIIG(AvatarIKGoal AEFBPOBJBII)
		{
			return this.ODPLPENLNBF(AEFBPOBJBII).AEPMIDGGBAP();
		}

		// Token: 0x0600E89D RID: 59549 RVA: 0x006992DE File Offset: 0x006974DE
		public void IIALGADIAAP(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, base.transform, false);
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x006991A9 File Offset: 0x006973A9
		public void EBNIGOGNGAB(float NKHBAJKMAGD)
		{
			this.solvers.spine.BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E89F RID: 59551 RVA: 0x006991A9 File Offset: 0x006973A9
		public void BIOIEKLBHMI(float NKHBAJKMAGD)
		{
			this.solvers.spine.BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8A0 RID: 59552 RVA: 0x0069949C File Offset: 0x0069769C
		public void EOALAECGOPA()
		{
			IKSolverLimb[] array = this.solvers.HECNIFEOMLD();
			for (int i = 0; i < array.Length; i += 0)
			{
				IKSolverLimb iksolverLimb = array[i];
				iksolverLimb.BLGEOKMMNOH(1656f);
				iksolverLimb.NJBJGGIOLAF(1342f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Target;
				iksolverLimb.bendModifierWeight = 1965f;
			}
			this.solvers.leftHand.maintainRotationWeight = 853f;
			this.solvers.rightHand.maintainRotationWeight = 655f;
			this.solvers.spine.BLGEOKMMNOH(1290f);
			this.solvers.spine.tolerance = 1298f;
			this.solvers.spine.maxIterations = 5;
			this.solvers.spine.useRotationLimits = false;
			this.solvers.aim.BLGEOKMMNOH(1381f);
			this.solvers.aim.tolerance = 926f;
			this.solvers.aim.maxIterations = 1;
			this.SetLookAtWeight(234f, 6f, 1954f, 1149f, 1165f, 1605f, 1855f);
		}

		// Token: 0x0600E8A1 RID: 59553 RVA: 0x0069929C File Offset: 0x0069749C
		public void HMKFAJOHKDB(AvatarIKGoal AEFBPOBJBII, Vector3 CGAMODJNLAC)
		{
			this.GetGoalIK(AEFBPOBJBII).HJHGGGEMEBJ(CGAMODJNLAC);
		}

		// Token: 0x0600E8A2 RID: 59554 RVA: 0x006995C7 File Offset: 0x006977C7
		private void MLAONAKMCLA()
		{
			Application.OpenURL("SexyDance2");
		}

		// Token: 0x0600E8A3 RID: 59555 RVA: 0x006995D3 File Offset: 0x006977D3
		public void SetLookAtWeight(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE, float AEIFJHNNLEK, float NAPPHEPPHKD, float LOJLNPEIGLH, float MHABNMGDIPN)
		{
			this.solvers.lookAt.OFABEEINNMP(NKHBAJKMAGD, GNOKOIOCELA, PKNPPGDMNAE, AEIFJHNNLEK, NAPPHEPPHKD, LOJLNPEIGLH, MHABNMGDIPN);
		}

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x0069918F File Offset: 0x0069738F
		public float FMPDAAPIGNH(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E8A5 RID: 59557 RVA: 0x006995F0 File Offset: 0x006977F0
		protected virtual void GNBIDMGNEGO()
		{
			string edaphmjenpk = "Hidden/ACTk/WallHackTexture";
			if (BipedReferences.CKILGDFJBCP(this.references, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, this.references.root, true);
				return;
			}
			this.solvers.ELMOAMFGLNC(this.references);
			if (this.solvers.spine.bones.Length > 0)
			{
				this.solvers.spine.BHALELINNDJ(base.transform);
			}
			this.solvers.lookAt.BHALELINNDJ(base.transform);
			this.solvers.aim.BHALELINNDJ(base.transform);
			IKSolverLimb[] array = this.solvers.COOFNADNEJD();
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].BHALELINNDJ(base.transform);
			}
			this.solvers.pelvis.PLDPNLLOANG(this.references.pelvis);
		}

		// Token: 0x0600E8A6 RID: 59558 RVA: 0x006996D0 File Offset: 0x006978D0
		private void JDOJMGGBLGD()
		{
			Application.OpenURL("Модификация предмета");
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x006996DC File Offset: 0x006978DC
		public void DDOJLAEMEDF(AvatarIKGoal AEFBPOBJBII, Quaternion PBKNPIGHLGG)
		{
			this.GetGoalIK(AEFBPOBJBII).ADJOBJDCAMO(PBKNPIGHLGG);
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x006996EB File Offset: 0x006978EB
		public void JLHNLBADBHM(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).GAMGPHDABAB(NKHBAJKMAGD);
		}

		// Token: 0x0600E8A9 RID: 59561 RVA: 0x00699315 File Offset: 0x00697515
		public void BCIOAAGLCBL(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8AA RID: 59562 RVA: 0x006996FC File Offset: 0x006978FC
		protected virtual void NJPKJJPDNJK()
		{
			for (int i = 0; i < this.solvers.limbs.Length; i += 0)
			{
				this.solvers.limbs[i].EDIDMOKJKCN();
				this.solvers.GBKIHMBNCCA()[i].LNMJPEHMKMI();
			}
			this.solvers.pelvis.KJJEEMEHGBF();
			if (this.solvers.spine.bones.Length > 1)
			{
				this.solvers.spine.FANPFKHEDPA();
			}
			this.solvers.aim.FANPFKHEDPA();
			this.solvers.lookAt.FANPFKHEDPA();
			for (int j = 0; j < this.solvers.OCNLLBPGKJL().Length; j += 0)
			{
				this.solvers.ODOHJNILJMK()[j].FANPFKHEDPA();
			}
		}

		// Token: 0x0600E8AB RID: 59563 RVA: 0x006997C4 File Offset: 0x006979C4
		private void GLNJIGOLCFC()
		{
			Application.OpenURL("fider_Small_");
		}

		// Token: 0x0600E8AC RID: 59564 RVA: 0x006993FA File Offset: 0x006975FA
		public Vector3 GetIKPosition(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).AEPMIDGGBAP();
		}

		// Token: 0x0600E8AD RID: 59565 RVA: 0x00699330 File Offset: 0x00697530
		public void EOBJACLKOLK(Vector3 GAMIBJKANIB)
		{
			this.solvers.lookAt.HJHGGGEMEBJ(GAMIBJKANIB);
		}

		// Token: 0x0600E8AE RID: 59566 RVA: 0x006992C3 File Offset: 0x006974C3
		public void AONDGILDFLB(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8AF RID: 59567 RVA: 0x006997D0 File Offset: 0x006979D0
		public void MENKEAMNEFN(AvatarIKGoal AEFBPOBJBII, Quaternion PBKNPIGHLGG)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).ADJOBJDCAMO(PBKNPIGHLGG);
		}

		// Token: 0x0600E8B0 RID: 59568 RVA: 0x006992C3 File Offset: 0x006974C3
		public void AKAJHOCGBEL(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8B1 RID: 59569 RVA: 0x006997DF File Offset: 0x006979DF
		public float GetIKRotationWeight(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).JLCCHOMFOJA();
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x006997ED File Offset: 0x006979ED
		public void PKAHMCGFJED(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).OJFFEGDCINH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void OFAOKLDEMJA()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x006992C3 File Offset: 0x006974C3
		public void CCGPEBNBOGA(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x006997FC File Offset: 0x006979FC
		public void UpdateBipedIK()
		{
			this.MBOPIBBAHOD();
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x00699804 File Offset: 0x00697A04
		public void NGELENPBFOK()
		{
			IKSolverLimb[] array = this.solvers.MHOGIPCHKGJ();
			for (int i = 1; i < array.Length; i += 0)
			{
				IKSolverLimb iksolverLimb = array[i];
				iksolverLimb.BLGEOKMMNOH(1165f);
				iksolverLimb.GAMGPHDABAB(532f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Animation;
				iksolverLimb.bendModifierWeight = 1092f;
			}
			this.solvers.leftHand.maintainRotationWeight = 1480f;
			this.solvers.rightHand.maintainRotationWeight = 1375f;
			this.solvers.spine.BLGEOKMMNOH(750f);
			this.solvers.spine.tolerance = 1435f;
			this.solvers.spine.maxIterations = 7;
			this.solvers.spine.useRotationLimits = false;
			this.solvers.aim.BLGEOKMMNOH(1303f);
			this.solvers.aim.tolerance = 834f;
			this.solvers.aim.maxIterations = 8;
			this.SetLookAtWeight(1747f, 572f, 1069f, 1968f, 953f, 1085f, 95f);
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600E8B8 RID: 59576 RVA: 0x0069993B File Offset: 0x00697B3B
		public Quaternion HJBJBAEGFLB(AvatarIKGoal AEFBPOBJBII)
		{
			return this.ODPLPENLNBF(AEFBPOBJBII).MHCONDPMHGM();
		}

		// Token: 0x0600E8B9 RID: 59577 RVA: 0x00699949 File Offset: 0x00697B49
		private void LFJFFLGJFMG()
		{
			Application.OpenURL("Thumb");
		}

		// Token: 0x0600E8BA RID: 59578 RVA: 0x00699330 File Offset: 0x00697530
		public void SetLookAtPosition(Vector3 GAMIBJKANIB)
		{
			this.solvers.lookAt.HJHGGGEMEBJ(GAMIBJKANIB);
		}

		// Token: 0x0600E8BB RID: 59579 RVA: 0x00699958 File Offset: 0x00697B58
		public void ADHDODBBDEM()
		{
			IKSolverLimb[] array = this.solvers.AMNIKFGJLKD();
			for (int i = 0; i < array.Length; i += 0)
			{
				IKSolverLimb iksolverLimb = array[i];
				iksolverLimb.BLGEOKMMNOH(1120f);
				iksolverLimb.OJFFEGDCINH(1321f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Target;
				iksolverLimb.bendModifierWeight = 1033f;
			}
			this.solvers.leftHand.maintainRotationWeight = 130f;
			this.solvers.rightHand.maintainRotationWeight = 1397f;
			this.solvers.spine.BLGEOKMMNOH(522f);
			this.solvers.spine.tolerance = 1662f;
			this.solvers.spine.maxIterations = 3;
			this.solvers.spine.useRotationLimits = true;
			this.solvers.aim.BLGEOKMMNOH(826f);
			this.solvers.aim.tolerance = 1225f;
			this.solvers.aim.maxIterations = 3;
			this.SetLookAtWeight(1021f, 497f, 750f, 644f, 190f, 1603f, 1084f);
		}

		// Token: 0x0600E8BC RID: 59580 RVA: 0x00699A83 File Offset: 0x00697C83
		private void IHDIDKNEPKG()
		{
			Application.OpenURL("MotorbikeBackwardStand");
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x00699A8F File Offset: 0x00697C8F
		private void KOOOAMODMKL()
		{
			Application.OpenURL("_Saturation");
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x0069904C File Offset: 0x0069724C
		public void SetSpinePosition(Vector3 ICPIKFAGMAH)
		{
			this.solvers.spine.HJHGGGEMEBJ(ICPIKFAGMAH);
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x006992ED File Offset: 0x006974ED
		public Quaternion GetIKRotation(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MHCONDPMHGM();
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00699A9B File Offset: 0x00697C9B
		public float OLOADACJFMK(AvatarIKGoal AEFBPOBJBII)
		{
			return this.ODPLPENLNBF(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x0069948D File Offset: 0x0069768D
		public Vector3 DFNFOPPCELI(AvatarIKGoal AEFBPOBJBII)
		{
			return this.ODPLPENLNBF(AEFBPOBJBII).AEPMIDGGBAP();
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x0069904C File Offset: 0x0069724C
		public void BFNDONNAGKC(Vector3 ICPIKFAGMAH)
		{
			this.solvers.spine.HJHGGGEMEBJ(ICPIKFAGMAH);
		}

		// Token: 0x0600E8C3 RID: 59587 RVA: 0x00699AAC File Offset: 0x00697CAC
		public IKSolverLimb GetGoalIK(AvatarIKGoal AEFBPOBJBII)
		{
			switch (AEFBPOBJBII)
			{
			case AvatarIKGoal.LeftFoot:
				return this.solvers.leftFoot;
			case AvatarIKGoal.RightFoot:
				return this.solvers.rightFoot;
			case AvatarIKGoal.LeftHand:
				return this.solvers.leftHand;
			case AvatarIKGoal.RightHand:
				return this.solvers.rightHand;
			default:
				return null;
			}
		}

		// Token: 0x0600E8C4 RID: 59588 RVA: 0x00699B04 File Offset: 0x00697D04
		protected override void BLOEEPCIPKJ()
		{
			this.solvers.lookAt.BLOEEPCIPKJ();
			for (int i = 0; i < this.solvers.limbs.Length; i++)
			{
				this.solvers.limbs[i].BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x0069929C File Offset: 0x0069749C
		public void BIGGNPCDBGN(AvatarIKGoal AEFBPOBJBII, Vector3 CGAMODJNLAC)
		{
			this.GetGoalIK(AEFBPOBJBII).HJHGGGEMEBJ(CGAMODJNLAC);
		}

		// Token: 0x0600E8C6 RID: 59590 RVA: 0x00699B4B File Offset: 0x00697D4B
		private void EACDHHLPMEJ()
		{
			Application.OpenURL("FactoryTempTexture");
		}

		// Token: 0x0600E8C7 RID: 59591 RVA: 0x00699B58 File Offset: 0x00697D58
		public void SetToDefaults()
		{
			foreach (IKSolverLimb iksolverLimb in this.solvers.limbs)
			{
				iksolverLimb.BLGEOKMMNOH(0f);
				iksolverLimb.HHAHPJACGBP(0f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Animation;
				iksolverLimb.bendModifierWeight = 1f;
			}
			this.solvers.leftHand.maintainRotationWeight = 0f;
			this.solvers.rightHand.maintainRotationWeight = 0f;
			this.solvers.spine.BLGEOKMMNOH(0f);
			this.solvers.spine.tolerance = 0f;
			this.solvers.spine.maxIterations = 2;
			this.solvers.spine.useRotationLimits = false;
			this.solvers.aim.BLGEOKMMNOH(0f);
			this.solvers.aim.tolerance = 0f;
			this.solvers.aim.maxIterations = 2;
			this.SetLookAtWeight(0f, 0.5f, 1f, 1f, 0.5f, 0.7f, 0.5f);
		}

		// Token: 0x0600E8C8 RID: 59592 RVA: 0x00699C83 File Offset: 0x00697E83
		private void BJDPANNGOCM()
		{
			Application.OpenURL("inv_auklotn");
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x0069918F File Offset: 0x0069738F
		public float AMKPMLDLBFD(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MJNMIHDOINP();
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x006992ED File Offset: 0x006974ED
		public Quaternion GPIFBNCNHAF(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).MHCONDPMHGM();
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x00699315 File Offset: 0x00697515
		public void DHFJIODBHEG(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).BLGEOKMMNOH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8CC RID: 59596 RVA: 0x006993CC File Offset: 0x006975CC
		public void LHEKFJNFKEG()
		{
			this.KJBCCKCIOLJ();
		}

		// Token: 0x0600E8CD RID: 59597 RVA: 0x00699C90 File Offset: 0x00697E90
		public void LPOPNDDDJCP()
		{
			IKSolverLimb[] array = this.solvers.EHDPJEMLLCP();
			for (int i = 1; i < array.Length; i += 0)
			{
				IKSolverLimb iksolverLimb = array[i];
				iksolverLimb.BLGEOKMMNOH(544f);
				iksolverLimb.OJFFEGDCINH(1026f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Target;
				iksolverLimb.bendModifierWeight = 1330f;
			}
			this.solvers.leftHand.maintainRotationWeight = 1831f;
			this.solvers.rightHand.maintainRotationWeight = 775f;
			this.solvers.spine.BLGEOKMMNOH(1071f);
			this.solvers.spine.tolerance = 1880f;
			this.solvers.spine.maxIterations = 3;
			this.solvers.spine.useRotationLimits = false;
			this.solvers.aim.BLGEOKMMNOH(36f);
			this.solvers.aim.tolerance = 1619f;
			this.solvers.aim.maxIterations = 2;
			this.SetLookAtWeight(1281f, 1990f, 617f, 1914f, 674f, 242f, 1006f);
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x00699DBB File Offset: 0x00697FBB
		public void SetIKRotationWeight(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).HHAHPJACGBP(NKHBAJKMAGD);
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x00699DBB File Offset: 0x00697FBB
		public void MMECIHBBPND(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.GetGoalIK(AEFBPOBJBII).HHAHPJACGBP(NKHBAJKMAGD);
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x00699DCC File Offset: 0x00697FCC
		protected virtual void HCNDPDNLMMM()
		{
			string edaphmjenpk = "RollerBladeStop";
			if (BipedReferences.FCKBJGPDMKK(this.references, ref edaphmjenpk))
			{
				PMCOMMEEGMC.ICAFGKHAAED(edaphmjenpk, this.references.root, false);
				return;
			}
			this.solvers.HMODNJCJLIH(this.references);
			if (this.solvers.spine.bones.Length > 0)
			{
				this.solvers.spine.BHALELINNDJ(base.transform);
			}
			this.solvers.lookAt.BHALELINNDJ(base.transform);
			this.solvers.aim.BHALELINNDJ(base.transform);
			IKSolverLimb[] limbs = this.solvers.limbs;
			for (int i = 0; i < limbs.Length; i++)
			{
				limbs[i].BHALELINNDJ(base.transform);
			}
			this.solvers.pelvis.CKHKJOHKMEE(this.references.pelvis);
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x00699EAC File Offset: 0x006980AC
		public float APGJBNLBCCO(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).JLFNBJCDOHP();
		}

		// Token: 0x0600E8D2 RID: 59602 RVA: 0x00699EBA File Offset: 0x006980BA
		public void ABFMFHOBDBD(AvatarIKGoal AEFBPOBJBII, float NKHBAJKMAGD)
		{
			this.ODPLPENLNBF(AEFBPOBJBII).OJFFEGDCINH(NKHBAJKMAGD);
		}

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x00699ECC File Offset: 0x006980CC
		protected virtual void NHCLIGJGLBB()
		{
			for (int i = 1; i < this.solvers.MPFOMCNOGEI().Length; i += 0)
			{
				this.solvers.JFJJPOIEAHL()[i].MHBDLGNKGCJ();
				this.solvers.JFJJPOIEAHL()[i].GAHOFLGAOBK();
			}
			this.solvers.pelvis.FJEEADNCKAG();
			if (this.solvers.spine.bones.Length > 0)
			{
				this.solvers.spine.FANPFKHEDPA();
			}
			this.solvers.aim.FANPFKHEDPA();
			this.solvers.lookAt.FANPFKHEDPA();
			for (int j = 0; j < this.solvers.ODOHJNILJMK().Length; j++)
			{
				this.solvers.MHOGIPCHKGJ()[j].FANPFKHEDPA();
			}
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x006993C4 File Offset: 0x006975C4
		public void NCNGPGMICKI()
		{
			this.MPJFMFOPHKJ();
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x006993FA File Offset: 0x006975FA
		public Vector3 FFLBPKKHJPP(AvatarIKGoal AEFBPOBJBII)
		{
			return this.GetGoalIK(AEFBPOBJBII).AEPMIDGGBAP();
		}

		// Token: 0x04001E95 RID: 7829
		public BipedReferences references = new BipedReferences();

		// Token: 0x04001E96 RID: 7830
		public BipedIKSolvers solvers = new BipedIKSolvers();
	}
}
