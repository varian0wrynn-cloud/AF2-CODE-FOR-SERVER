using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003FF RID: 1023
	public class KissingRig : MonoBehaviour
	{
		// Token: 0x0600DB8A RID: 56202 RVA: 0x00649D7C File Offset: 0x00647F7C
		private void BJILHFNDDKC()
		{
			for (int i = 1; i < this.iterations; i++)
			{
				this.partner1.FJEEADNCKAG(this.weight);
				this.partner2.PNBGJBMJLFM(this.weight);
			}
		}

		// Token: 0x0600DB8B RID: 56203 RVA: 0x00649DBC File Offset: 0x00647FBC
		private void INDGOHJGCFN()
		{
			this.partner1.BOHLLJEAHAE();
			this.partner2.FCMIMIBJJJI();
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x00649DD4 File Offset: 0x00647FD4
		private void CFHDJOKLHDB()
		{
			for (int i = 1; i < this.iterations; i += 0)
			{
				this.partner1.IGEICBNMPAD(this.weight);
				this.partner2.OPDCJCFMIPE(this.weight);
			}
		}

		// Token: 0x0600DB8D RID: 56205 RVA: 0x00649E14 File Offset: 0x00648014
		private void LateUpdate()
		{
			for (int i = 0; i < this.iterations; i++)
			{
				this.partner1.FANPFKHEDPA(this.weight);
				this.partner2.FANPFKHEDPA(this.weight);
			}
		}

		// Token: 0x0600DB8E RID: 56206 RVA: 0x00649E54 File Offset: 0x00648054
		private void Start()
		{
			this.partner1.BHALELINNDJ();
			this.partner2.BHALELINNDJ();
		}

		// Token: 0x0600DB8F RID: 56207 RVA: 0x00649E6C File Offset: 0x0064806C
		private void LHFBEKCIKOI()
		{
			for (int i = 1; i < this.iterations; i += 0)
			{
				this.partner1.FANPFKHEDPA(this.weight);
				this.partner2.FJEEADNCKAG(this.weight);
			}
		}

		// Token: 0x0600DB90 RID: 56208 RVA: 0x00649EAC File Offset: 0x006480AC
		private void MCHAAIIHOKD()
		{
			this.partner1.CKHKJOHKMEE();
			this.partner2.CPLOFPNBFEH();
		}

		// Token: 0x0600DB91 RID: 56209 RVA: 0x00649EC4 File Offset: 0x006480C4
		private void BMNJGPIPKLL()
		{
			this.partner1.BHALELINNDJ();
			this.partner2.BOHLLJEAHAE();
		}

		// Token: 0x0600DB92 RID: 56210 RVA: 0x00649EDC File Offset: 0x006480DC
		private void ONIHHFLOJMN()
		{
			this.partner1.CPLOFPNBFEH();
			this.partner2.BOHLLJEAHAE();
		}

		// Token: 0x0600DB94 RID: 56212 RVA: 0x00649F03 File Offset: 0x00648103
		private void EDGALMCHPPH()
		{
			this.partner1.BHALELINNDJ();
			this.partner2.ENLPEHMBNJC();
		}

		// Token: 0x0600DB95 RID: 56213 RVA: 0x00649F1B File Offset: 0x0064811B
		private void IIKDDILLGLF()
		{
			this.partner1.OECNHGIPNLB();
			this.partner2.BHALELINNDJ();
		}

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00649F33 File Offset: 0x00648133
		private void FIJKDFIMELM()
		{
			this.partner1.AMGIJEGCAEG();
			this.partner2.CPLOFPNBFEH();
		}

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00649F4B File Offset: 0x0064814B
		private void OFGMIEJKMGC()
		{
			this.partner1.OECNHGIPNLB();
			this.partner2.AMGIJEGCAEG();
		}

		// Token: 0x0600DB98 RID: 56216 RVA: 0x00649F63 File Offset: 0x00648163
		private void KEMGOLACEHI()
		{
			this.partner1.ENLPEHMBNJC();
			this.partner2.FCMIMIBJJJI();
		}

		// Token: 0x04001D1D RID: 7453
		public KissingRig.Partner partner1;

		// Token: 0x04001D1E RID: 7454
		public KissingRig.Partner partner2;

		// Token: 0x04001D1F RID: 7455
		public float weight;

		// Token: 0x04001D20 RID: 7456
		public int iterations = 3;

		// Token: 0x02000400 RID: 1024
		[Serializable]
		public class Partner
		{
			// Token: 0x0600DB99 RID: 56217 RVA: 0x00649F7C File Offset: 0x0064817C
			public void OPDCJCFMIPE(float NKHBAJKMAGD)
			{
				this.ik.solver.FKKHCIDIBLF().positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightShoulderEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.EMPOFCMIGLD().positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightHandEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.leftHandEffector.rotationWeight = NKHBAJKMAGD;
				this.ik.solver.rightHandEffector.rotationWeight = NKHBAJKMAGD;
				this.ik.solver.NEKNDGMNDHG().positionWeight = NKHBAJKMAGD;
				this.ABKCPLKEBMO(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.DEBHFGMKCBJ(FullBodyBipedEffector.RightHand, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.GPODFACNHEG(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.HJPCHINGJCN().position = Vector3.Lerp(new Vector3(this.ik.solver.NEKNDGMNDHG().position.x, this.ik.solver.bodyEffector.bone.position.y, this.ik.solver.NEKNDGMNDHG().position.z), this.ik.solver.NEKNDGMNDHG().position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.NEKNDGMNDHG().position.y, this.ik.solver.NEKNDGMNDHG().bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.KIGACGJAJKO().position = this.touchTargetLeftHand.position;
				this.ik.solver.MJOPIBNHGIK().position = this.touchTargetRightHand.position;
				this.ik.solver.EMPOFCMIGLD().rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.IANMIEDIJPJ().rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.LELJFHDIPHE().rotation;
				this.ik.solver.FANPFKHEDPA();
				this.DBKGILAJMOJ().rotation = Quaternion.Slerp(this.LELJFHDIPHE().rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DB9A RID: 56218 RVA: 0x0064A2A0 File Offset: 0x006484A0
			private void IFGLOGENIJJ(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DB9B RID: 56219 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform NBJDFAOHMOA()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DB9C RID: 56220 RVA: 0x0064A344 File Offset: 0x00648544
			private Transform HGCGPDMHCFA()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 0];
			}

			// Token: 0x0600DB9D RID: 56221 RVA: 0x0064A378 File Offset: 0x00648578
			private void HPOEALPKDKN(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DB9E RID: 56222 RVA: 0x0064A3EB File Offset: 0x006485EB
			public void BHALELINNDJ()
			{
				this.ik.enabled = false;
			}

			// Token: 0x0600DB9F RID: 56223 RVA: 0x0064A3EB File Offset: 0x006485EB
			public void PLDPNLLOANG()
			{
				this.ik.enabled = false;
			}

			// Token: 0x0600DBA0 RID: 56224 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void BOHLLJEAHAE()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBA1 RID: 56225 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform JCJGDHGMCEJ()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBA2 RID: 56226 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void FCMIMIBJJJI()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBA3 RID: 56227 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform OMBFMFEMDCA()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBA4 RID: 56228 RVA: 0x0064A408 File Offset: 0x00648608
			private void LCHEICKHCFG(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBA5 RID: 56229 RVA: 0x0064A47C File Offset: 0x0064867C
			private void JOLCNCMNLML(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBA6 RID: 56230 RVA: 0x0064A4F0 File Offset: 0x006486F0
			public void PNBGJBMJLFM(float NKHBAJKMAGD)
			{
				this.ik.solver.EEHNFKHFPGP().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DMPDLFPCDFO().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DBCIMCKLHIM().positionWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().positionWeight = NKHBAJKMAGD;
				this.ik.solver.KIGACGJAJKO().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.IANMIEDIJPJ().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.NEKNDGMNDHG().positionWeight = NKHBAJKMAGD;
				this.HPOEALPKDKN(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.FJEAEGOEIGP(FullBodyBipedEffector.LeftFoot, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ABKCPLKEBMO(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.position.x, this.ik.solver.NEKNDGMNDHG().bone.position.y, this.ik.solver.bodyEffector.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.NEKNDGMNDHG().bone.position.x, this.ik.solver.NEKNDGMNDHG().position.y, this.ik.solver.HJPCHINGJCN().bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.KIGACGJAJKO().position = this.touchTargetLeftHand.position;
				this.ik.solver.rightHandEffector.position = this.touchTargetRightHand.position;
				this.ik.solver.KIGACGJAJKO().rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.rightHandEffector.rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.KNDLMLFEELI().rotation;
				this.ik.solver.FANPFKHEDPA();
				this.EJKOBAMEHGI().rotation = Quaternion.Slerp(this.FFJECJHJHAF().rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBA7 RID: 56231 RVA: 0x0064A3EB File Offset: 0x006485EB
			public void FFNJMJHPDGF()
			{
				this.ik.enabled = false;
			}

			// Token: 0x0600DBA8 RID: 56232 RVA: 0x0064A814 File Offset: 0x00648A14
			private void BMLJAHIIEGE(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBA9 RID: 56233 RVA: 0x0064A888 File Offset: 0x00648A88
			private void ABKCPLKEBMO(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBAA RID: 56234 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform EJKOBAMEHGI()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBAB RID: 56235 RVA: 0x0064A8FC File Offset: 0x00648AFC
			private void CLGHLPHKKFF(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBAC RID: 56236 RVA: 0x0064A970 File Offset: 0x00648B70
			private void BHBECAOLAGK(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBAD RID: 56237 RVA: 0x0064A9E4 File Offset: 0x00648BE4
			private void CLJDJJJJFME(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBAE RID: 56238 RVA: 0x0064AA58 File Offset: 0x00648C58
			public void IGEICBNMPAD(float NKHBAJKMAGD)
			{
				this.ik.solver.EEHNFKHFPGP().positionWeight = NKHBAJKMAGD;
				this.ik.solver.GPLFMHLNFLL().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DBCIMCKLHIM().positionWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().positionWeight = NKHBAJKMAGD;
				this.ik.solver.leftHandEffector.rotationWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.bodyEffector.positionWeight = NKHBAJKMAGD;
				this.CLGHLPHKKFF(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ABKCPLKEBMO(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.LCHEICKHCFG(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.HJPCHINGJCN().position = Vector3.Lerp(new Vector3(this.ik.solver.HJPCHINGJCN().position.x, this.ik.solver.NEKNDGMNDHG().bone.position.y, this.ik.solver.bodyEffector.position.z), this.ik.solver.HJPCHINGJCN().position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.HJPCHINGJCN().position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.HJPCHINGJCN().position.y, this.ik.solver.bodyEffector.bone.position.z), this.ik.solver.HJPCHINGJCN().position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.leftHandEffector.position = this.touchTargetLeftHand.position;
				this.ik.solver.MJOPIBNHGIK().position = this.touchTargetRightHand.position;
				this.ik.solver.leftHandEffector.rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.IANMIEDIJPJ().rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.HGCGPDMHCFA().rotation;
				this.ik.solver.FANPFKHEDPA();
				this.KNDLMLFEELI().rotation = Quaternion.Slerp(this.OMBFMFEMDCA().rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBAF RID: 56239 RVA: 0x0064AD7C File Offset: 0x00648F7C
			public void FANPFKHEDPA(float NKHBAJKMAGD)
			{
				this.ik.solver.leftShoulderEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightShoulderEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.leftHandEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightHandEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.leftHandEffector.rotationWeight = NKHBAJKMAGD;
				this.ik.solver.rightHandEffector.rotationWeight = NKHBAJKMAGD;
				this.ik.solver.bodyEffector.positionWeight = NKHBAJKMAGD;
				this.ABKCPLKEBMO(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ABKCPLKEBMO(FullBodyBipedEffector.RightShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ABKCPLKEBMO(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.position.x, this.ik.solver.bodyEffector.bone.position.y, this.ik.solver.bodyEffector.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.bodyEffector.position.y, this.ik.solver.bodyEffector.bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.leftHandEffector.position = this.touchTargetLeftHand.position;
				this.ik.solver.rightHandEffector.position = this.touchTargetRightHand.position;
				this.ik.solver.leftHandEffector.rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.rightHandEffector.rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.neck.rotation;
				this.ik.solver.FANPFKHEDPA();
				this.neck.rotation = Quaternion.Slerp(this.neck.rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBB0 RID: 56240 RVA: 0x0064B0A0 File Offset: 0x006492A0
			private void DEBHFGMKCBJ(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBB2 RID: 56242 RVA: 0x0064A3EB File Offset: 0x006485EB
			public void CKHKJOHKMEE()
			{
				this.ik.enabled = false;
			}

			// Token: 0x0600DBB3 RID: 56243 RVA: 0x0064B148 File Offset: 0x00649348
			private void GPODFACNHEG(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBB4 RID: 56244 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform KKBJFNBJEME()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBB5 RID: 56245 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform LBONPEPHLCP()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBB6 RID: 56246 RVA: 0x0064A344 File Offset: 0x00648544
			private Transform BCBHBBNIJKF()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 0];
			}

			// Token: 0x0600DBB7 RID: 56247 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void OECNHGIPNLB()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBB8 RID: 56248 RVA: 0x0064A344 File Offset: 0x00648544
			private Transform FFJECJHJHAF()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 0];
			}

			// Token: 0x0600DBB9 RID: 56249 RVA: 0x0064B1BC File Offset: 0x006493BC
			private void FJEAEGOEIGP(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBBA RID: 56250 RVA: 0x0064B230 File Offset: 0x00649430
			public void FPLNDDMFFKG(float NKHBAJKMAGD)
			{
				this.ik.solver.LLFAEIGHHBK().positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightShoulderEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.leftHandEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().positionWeight = NKHBAJKMAGD;
				this.ik.solver.KIGACGJAJKO().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.HJPCHINGJCN().positionWeight = NKHBAJKMAGD;
				this.IFGLOGENIJJ(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.DEBHFGMKCBJ(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.DEBHFGMKCBJ(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.NEKNDGMNDHG().position.x, this.ik.solver.NEKNDGMNDHG().bone.position.y, this.ik.solver.NEKNDGMNDHG().position.z), this.ik.solver.HJPCHINGJCN().position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.HJPCHINGJCN().position = Vector3.Lerp(new Vector3(this.ik.solver.HJPCHINGJCN().bone.position.x, this.ik.solver.bodyEffector.position.y, this.ik.solver.bodyEffector.bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.DBCIMCKLHIM().position = this.touchTargetLeftHand.position;
				this.ik.solver.IANMIEDIJPJ().position = this.touchTargetRightHand.position;
				this.ik.solver.DBCIMCKLHIM().rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.MJOPIBNHGIK().rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.neck.rotation;
				this.ik.solver.FANPFKHEDPA();
				this.HGCGPDMHCFA().rotation = Quaternion.Slerp(this.BCBHBBNIJKF().rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBBB RID: 56251 RVA: 0x0064B554 File Offset: 0x00649754
			private void HOOIGCKEHJB(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.DAMGOIIBHCN(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBBC RID: 56252 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform LIFOAAAMEEL()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x0600DBBD RID: 56253 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform neck
			{
				get
				{
					return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
				}
			}

			// Token: 0x0600DBBE RID: 56254 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void AMGIJEGCAEG()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBBF RID: 56255 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void ENLPEHMBNJC()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBC0 RID: 56256 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform LELJFHDIPHE()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x0600DBC1 RID: 56257 RVA: 0x0064A344 File Offset: 0x00648544
			private Transform KNDLMLFEELI()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 0];
			}

			// Token: 0x0600DBC2 RID: 56258 RVA: 0x0064B5C8 File Offset: 0x006497C8
			private void PFMBCADNBHE(FullBodyBipedEffector JEFKLIBDHKK, Transform FFGIAHPIPEK, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD)
			{
				Vector3 b = this.ik.solver.LOOAPOLICLC(JEFKLIBDHKK).bone.position - FFGIAHPIPEK.position;
				this.ik.solver.EEKAOKNJLKH(JEFKLIBDHKK).position = Vector3.Lerp(this.ik.solver.OEEPHOCHILL(JEFKLIBDHKK).bone.position, AOBKCEEGJNC + b, NKHBAJKMAGD);
			}

			// Token: 0x0600DBC3 RID: 56259 RVA: 0x0064B63C File Offset: 0x0064983C
			public void FJEEADNCKAG(float NKHBAJKMAGD)
			{
				this.ik.solver.EEHNFKHFPGP().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DMPDLFPCDFO().positionWeight = NKHBAJKMAGD;
				this.ik.solver.CMKJIGNKIMG().positionWeight = NKHBAJKMAGD;
				this.ik.solver.IANMIEDIJPJ().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DBCIMCKLHIM().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.HJPCHINGJCN().positionWeight = NKHBAJKMAGD;
				this.HPOEALPKDKN(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.BMLJAHIIEGE(FullBodyBipedEffector.LeftHand, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.BMLJAHIIEGE(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.HJPCHINGJCN().position.x, this.ik.solver.bodyEffector.bone.position.y, this.ik.solver.NEKNDGMNDHG().position.z), this.ik.solver.NEKNDGMNDHG().position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.bodyEffector.position.y, this.ik.solver.NEKNDGMNDHG().bone.position.z), this.ik.solver.HJPCHINGJCN().position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.EMPOFCMIGLD().position = this.touchTargetLeftHand.position;
				this.ik.solver.rightHandEffector.position = this.touchTargetRightHand.position;
				this.ik.solver.EMPOFCMIGLD().rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.IANMIEDIJPJ().rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.FFJECJHJHAF().rotation;
				this.ik.solver.FANPFKHEDPA();
				this.OMBFMFEMDCA().rotation = Quaternion.Slerp(this.KKBJFNBJEME().rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBC4 RID: 56260 RVA: 0x0064A3F9 File Offset: 0x006485F9
			public void CPLOFPNBFEH()
			{
				this.ik.enabled = true;
			}

			// Token: 0x0600DBC5 RID: 56261 RVA: 0x0064B960 File Offset: 0x00649B60
			public void JLFBDOPFDDJ(float NKHBAJKMAGD)
			{
				this.ik.solver.EEHNFKHFPGP().positionWeight = NKHBAJKMAGD;
				this.ik.solver.rightShoulderEffector.positionWeight = NKHBAJKMAGD;
				this.ik.solver.KIGACGJAJKO().positionWeight = NKHBAJKMAGD;
				this.ik.solver.MJOPIBNHGIK().positionWeight = NKHBAJKMAGD;
				this.ik.solver.DBCIMCKLHIM().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.IANMIEDIJPJ().rotationWeight = NKHBAJKMAGD;
				this.ik.solver.NEKNDGMNDHG().positionWeight = NKHBAJKMAGD;
				this.PFMBCADNBHE(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ABKCPLKEBMO(FullBodyBipedEffector.LeftFoot, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.HOOIGCKEHJB(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.position.x, this.ik.solver.HJPCHINGJCN().bone.position.y, this.ik.solver.bodyEffector.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightVertical * NKHBAJKMAGD);
				this.ik.solver.NEKNDGMNDHG().position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.HJPCHINGJCN().position.y, this.ik.solver.NEKNDGMNDHG().bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * NKHBAJKMAGD);
				this.ik.solver.DBCIMCKLHIM().position = this.touchTargetLeftHand.position;
				this.ik.solver.MJOPIBNHGIK().position = this.touchTargetRightHand.position;
				this.ik.solver.DBCIMCKLHIM().rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.rightHandEffector.rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.neck.rotation;
				this.ik.solver.FANPFKHEDPA();
				this.LELJFHDIPHE().rotation = Quaternion.Slerp(this.neck.rotation, this.neckRotation, this.neckRotationWeight * NKHBAJKMAGD);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * NKHBAJKMAGD, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x0600DBC6 RID: 56262 RVA: 0x0064A313 File Offset: 0x00648513
			private Transform DBKGILAJMOJ()
			{
				return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
			}

			// Token: 0x04001D21 RID: 7457
			public FullBodyBipedIK ik;

			// Token: 0x04001D22 RID: 7458
			public Transform mouth;

			// Token: 0x04001D23 RID: 7459
			public Transform mouthTarget;

			// Token: 0x04001D24 RID: 7460
			public Transform touchTargetLeftHand;

			// Token: 0x04001D25 RID: 7461
			public Transform touchTargetRightHand;

			// Token: 0x04001D26 RID: 7462
			public float bodyWeightHorizontal = 0.4f;

			// Token: 0x04001D27 RID: 7463
			public float bodyWeightVertical = 1f;

			// Token: 0x04001D28 RID: 7464
			public float neckRotationWeight = 0.3f;

			// Token: 0x04001D29 RID: 7465
			public float headTiltAngle = 10f;

			// Token: 0x04001D2A RID: 7466
			public Vector3 headTiltAxis;

			// Token: 0x04001D2B RID: 7467
			private Quaternion neckRotation;
		}
	}
}
