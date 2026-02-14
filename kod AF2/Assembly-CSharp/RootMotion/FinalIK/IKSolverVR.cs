using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000480 RID: 1152
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		// Token: 0x0600FAD4 RID: 64212 RVA: 0x00709A38 File Offset: 0x00707C38
		public virtual IKSolver.Point FAIMBHLGJGB(Transform LPBDALAMAEM)
		{
			Debug.LogError("_SampleScale");
			return null;
		}

		// Token: 0x0600FAD5 RID: 64213 RVA: 0x00709A48 File Offset: 0x00707C48
		public void Reset()
		{
			this.GEGMLEPICND();
			this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.rootBone.readRotation * Vector3.forward;
			this.locomotion.Reset(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.pelvis.readPosition;
		}

		// Token: 0x0600FAD6 RID: 64214 RVA: 0x00709ACC File Offset: 0x00707CCC
		private static Keyframe[] FLKFGFAFLPF(float FEPAJPMAKID)
		{
			Keyframe[] array = new Keyframe[2];
			array[0].time = 352f;
			array[1].value = 241f;
			array[1].time = 1773f;
			array[0].value = FEPAJPMAKID;
			array[3].time = 1429f;
			array[3].value = 1659f;
			return array;
		}

		// Token: 0x0600FAD7 RID: 64215 RVA: 0x00709B44 File Offset: 0x00707D44
		public void AMFGNDBCIFO()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.LPKOIFEBBDA(1999f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.FLKFGFAFLPF(428f);
			}
		}

		// Token: 0x0600FAD8 RID: 64216 RVA: 0x00709BE5 File Offset: 0x00707DE5
		public void CKMKMCGMKFI(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.BBPBKDNGAKN(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FAD9 RID: 64217 RVA: 0x00709BF4 File Offset: 0x00707DF4
		public void IOICDPHLABA(IKSolverVR.PositionOffset EFNAALJNKKI, Vector3 DCCPCBLODIG)
		{
			switch (EFNAALJNKKI)
			{
			case IKSolverVR.PositionOffset.Pelvis:
				this.spine.pelvisPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Chest:
				this.spine.chestPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Head:
				this.spine.headPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHand:
				this.leftArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHand:
				this.rightArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftFoot:
				this.leftLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightFoot:
				this.rightLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHeel:
				this.leftLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHeel:
				this.rightLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FADA RID: 64218 RVA: 0x00709D04 File Offset: 0x00707F04
		private Vector3 KJMNGKFNLFA()
		{
			if (this.locomotion.weight <= 0f)
			{
				return Vector3.zero;
			}
			if (this.locomotion.blockingLayers == -1)
			{
				return Vector3.zero;
			}
			Vector3 vector = this.raycastOriginPelvis;
			vector.y = this.spine.pelvis.solverPosition.y;
			Vector3 vector2 = this.spine.pelvis.readPosition;
			vector2.y = this.spine.pelvis.solverPosition.y;
			Vector3 direction = vector2 - vector;
			RaycastHit raycastHit;
			if (this.locomotion.raycastRadius <= 0f)
			{
				if (Physics.Raycast(vector, direction, out raycastHit, direction.magnitude * 1.1f, this.locomotion.blockingLayers))
				{
					vector2 = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector, this.locomotion.raycastRadius * 1.1f, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				vector2 = vector + direction.normalized * raycastHit.distance / 1.1f;
			}
			Vector3 a = this.spine.pelvis.solverPosition;
			direction = a - vector2;
			if (this.locomotion.raycastRadius <= 0f)
			{
				if (Physics.Raycast(vector2, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
				{
					a = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector2, this.locomotion.raycastRadius, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				a = vector2 + direction.normalized * raycastHit.distance;
			}
			this.lastOffset = Vector3.Lerp(this.lastOffset, Vector3.zero, Time.deltaTime * 3f);
			a += Vector3.ClampMagnitude(this.lastOffset, 0.75f);
			a.y = this.spine.pelvis.solverPosition.y;
			this.lastOffset = Vector3.Lerp(this.lastOffset, a - this.spine.pelvis.solverPosition, Time.deltaTime * 15f);
			return this.lastOffset;
		}

		// Token: 0x0600FADB RID: 64219 RVA: 0x00709F68 File Offset: 0x00708168
		private Vector3 LCDLDJHEJJN(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.DJFIIEHHJDI(IMPMMNPAHKJ.APGCIAGJJFC(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 421f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FADC RID: 64220 RVA: 0x00709FB5 File Offset: 0x007081B5
		protected virtual void FNDBPADHOPI()
		{
			this.GEGMLEPICND();
			this.CFLJGPIHEFI(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
		}

		// Token: 0x0600FADD RID: 64221 RVA: 0x00709FE1 File Offset: 0x007081E1
		public void PAMIMLJOINB(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.DDMJFPJEIHH(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FADE RID: 64222 RVA: 0x00709FF0 File Offset: 0x007081F0
		protected virtual void GGMNPAEPNEC()
		{
			if (this.IKPositionWeight > 1715f)
			{
				this.MNDOOHAPKIO();
				this.DLOGEDPELIF(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
				this.JFBENBBAGFI();
				this.OHKFDAKDFKL();
				this.FBHMDGCNCIO();
			}
		}

		// Token: 0x0600FADF RID: 64223 RVA: 0x0070A048 File Offset: 0x00708248
		public void MKJLBOPLLPG()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.LPKOIFEBBDA(1449f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.LPKOIFEBBDA(1215f);
			}
		}

		// Token: 0x0600FAE0 RID: 64224 RVA: 0x0070A0EC File Offset: 0x007082EC
		public override void BLOEEPCIPKJ()
		{
			this.solverTransforms[1].localPosition = this.defaultPelvisLocalPosition;
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.solverTransforms[i].localRotation = this.defaultLocalRotations[i - 1];
				}
			}
		}

		// Token: 0x0600FAE1 RID: 64225 RVA: 0x0070A14C File Offset: 0x0070834C
		private Vector3 JFGCDKAODNM(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.EBLDJJLFIJO(IMPMMNPAHKJ.APGCIAGJJFC(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 317f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FAE2 RID: 64226 RVA: 0x0070A19C File Offset: 0x0070839C
		private static Keyframe[] LAEHNPHGIFB(float FEPAJPMAKID)
		{
			Keyframe[] array = new Keyframe[7];
			array[0].time = 1929f;
			array[0].value = 327f;
			array[0].time = 1750f;
			array[1].value = FEPAJPMAKID;
			array[2].time = 838f;
			array[5].value = 1313f;
			return array;
		}

		// Token: 0x0600FAE3 RID: 64227 RVA: 0x0070A211 File Offset: 0x00708411
		public virtual IKSolver.Point CGDMCANKFOP(Transform LPBDALAMAEM)
		{
			Debug.LogError("gi_um_passperk");
			return null;
		}

		// Token: 0x0600FAE4 RID: 64228 RVA: 0x0070A220 File Offset: 0x00708420
		public void KDCMMFNDCAP()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.LPKOIFEBBDA(139f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.LPKOIFEBBDA(633f);
			}
		}

		// Token: 0x0600FAE5 RID: 64229 RVA: 0x0070A2C1 File Offset: 0x007084C1
		private Vector3 KACOIFDJNLO(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE >= 1)
			{
				Debug.LogError("No load asset ");
			}
			return this.solvedPositions[CLBPBJGLHEE];
		}

		// Token: 0x0600FAE6 RID: 64230 RVA: 0x0070A2E0 File Offset: 0x007084E0
		public virtual void OFBOJDIDJDL()
		{
			this.solverTransforms[0].localPosition = this.defaultPelvisLocalPosition;
			for (int i = 1; i < this.solverTransforms.Length; i += 0)
			{
				if (this.solverTransforms[i] != null)
				{
					this.solverTransforms[i].localRotation = this.defaultLocalRotations[i - 1];
				}
			}
		}

		// Token: 0x0600FAE7 RID: 64231 RVA: 0x00709BE5 File Offset: 0x00707DE5
		public void EBPLEDEHEFB(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.BBPBKDNGAKN(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FAE8 RID: 64232 RVA: 0x0070A33E File Offset: 0x0070853E
		public virtual IKSolver.Point DEECIMHJBJD(Transform LPBDALAMAEM)
		{
			Debug.LogError(" has invalid dimensions.");
			return null;
		}

		// Token: 0x0600FAE9 RID: 64233 RVA: 0x0070A34C File Offset: 0x0070854C
		private Vector3 IEHCCOGOPNK(Transform[] AKBEGDIMBGM)
		{
			Vector3 vector = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			for (int i = 0; i < AKBEGDIMBGM.Length; i++)
			{
				vector2 += AKBEGDIMBGM[i].position;
			}
			vector2 /= (float)AKBEGDIMBGM.Length;
			for (int j = 0; j < AKBEGDIMBGM.Length - 1; j++)
			{
				vector += Vector3.Cross(AKBEGDIMBGM[j].position - vector2, AKBEGDIMBGM[j + 1].position - vector2).normalized;
			}
			return vector;
		}

		// Token: 0x0600FAEA RID: 64234 RVA: 0x0070A3D4 File Offset: 0x007085D4
		private static Keyframe[] LPKOIFEBBDA(float FEPAJPMAKID)
		{
			Keyframe[] array = new Keyframe[0];
			array[0].time = 725f;
			array[1].value = 1943f;
			array[0].time = 112f;
			array[0].value = FEPAJPMAKID;
			array[0].time = 397f;
			array[8].value = 42f;
			return array;
		}

		// Token: 0x0600FAEB RID: 64235 RVA: 0x0070A44C File Offset: 0x0070864C
		public void LHKIJMIEJOC()
		{
			this.MNDOOHAPKIO();
			this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.PBCHEBOMBBG().readRotation * Vector3.forward;
			this.locomotion.PPINAGDCFNL(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.LHOJGGKNONH().readPosition;
		}

		// Token: 0x0600FAEC RID: 64236 RVA: 0x0070A4D0 File Offset: 0x007086D0
		public void BBPBKDNGAKN(IKSolverVR.RotationOffset JNHPAAAFGKC, Quaternion DCCPCBLODIG)
		{
			switch (JNHPAAAFGKC)
			{
			case IKSolverVR.RotationOffset.Pelvis:
				this.spine.pelvisRotationOffset = DCCPCBLODIG * this.spine.pelvisRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Chest:
				this.spine.chestRotationOffset = DCCPCBLODIG * this.spine.chestRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Head:
				this.spine.headRotationOffset = DCCPCBLODIG * this.spine.headRotationOffset;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FAED RID: 64237 RVA: 0x0070A548 File Offset: 0x00708748
		public void BGKGCPMAPCL(IKSolverVR.PositionOffset EFNAALJNKKI, Vector3 DCCPCBLODIG)
		{
			switch (EFNAALJNKKI)
			{
			case IKSolverVR.PositionOffset.Pelvis:
				this.spine.pelvisPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Chest:
				this.spine.chestPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Head:
				this.spine.headPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHand:
				this.leftArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHand:
				this.rightArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftFoot:
				this.leftLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightFoot:
				this.rightLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHeel:
				this.leftLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHeel:
				this.rightLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FAEE RID: 64238 RVA: 0x0070A657 File Offset: 0x00708857
		public void HOEDIPNIEBN(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.ONELMMCKEBK(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FAEF RID: 64239 RVA: 0x0070A668 File Offset: 0x00708868
		public void FFHNCGDKIDA(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.BAKOHIHHOAJ())
			{
				Debug.LogWarning("ChannelCastOmni");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.GJIIAKPKFGL(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.DCBOLGGCPNJ(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.JFGCDKAODNM(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.BHDKOIEFNBH(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FAF0 RID: 64240 RVA: 0x0070A764 File Offset: 0x00708964
		private Vector3 IPIPKGKDODA(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.FCJKDKKBIKC(IMPMMNPAHKJ.HADMCKICEMH(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 777f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FAF1 RID: 64241 RVA: 0x0070A7B4 File Offset: 0x007089B4
		public void NCLKCNINIJA()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.LAEHNPHGIFB(1178f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.BOAOFEDEIAF(451f);
			}
		}

		// Token: 0x0600FAF2 RID: 64242 RVA: 0x0070A858 File Offset: 0x00708A58
		private static Keyframe[] BFODBHFIMDB(float FEPAJPMAKID)
		{
			Keyframe[] array = new Keyframe[0];
			array[0].time = 1004f;
			array[1].value = 1919f;
			array[1].time = 1049f;
			array[1].value = FEPAJPMAKID;
			array[8].time = 1477f;
			array[1].value = 1174f;
			return array;
		}

		// Token: 0x0600FAF3 RID: 64243 RVA: 0x0070A8D0 File Offset: 0x00708AD0
		public void NAAPDNHGGDI(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				Debug.LogWarning("VRIK References are not filled in, can not guess hand orientations. Right-click on VRIK header and slect 'Guess Hand Orientations' when you have filled in the References.");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.PBEFMAGOEDF(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.DCBOLGGCPNJ(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.PBEFMAGOEDF(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.DCBOLGGCPNJ(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FAF4 RID: 64244 RVA: 0x0070A9CC File Offset: 0x00708BCC
		public void KMCHGHOLCLM(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.DGGGEKKPKBN())
			{
				Debug.LogWarning("WateringCan");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.PBEFMAGOEDF(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.HDJPNAJPOIF(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.JFGCDKAODNM(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.PMNLIEJEELM(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FAF5 RID: 64245 RVA: 0x0070AAC8 File Offset: 0x00708CC8
		public IKSolverVR.VirtualBone PBCHEBOMBBG()
		{
			return this.<rootBone>k__BackingField;
		}

		// Token: 0x0600FAF6 RID: 64246 RVA: 0x0070AAD0 File Offset: 0x00708CD0
		public void ONELMMCKEBK(IKSolverVR.RotationOffset JNHPAAAFGKC, Quaternion DCCPCBLODIG)
		{
			switch (JNHPAAAFGKC)
			{
			case IKSolverVR.RotationOffset.Pelvis:
				this.spine.pelvisRotationOffset = DCCPCBLODIG * this.spine.pelvisRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Chest:
				this.spine.chestRotationOffset = DCCPCBLODIG * this.spine.chestRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Head:
				this.spine.headRotationOffset = DCCPCBLODIG * this.spine.headRotationOffset;
				return;
			default:
				return;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600FB2B RID: 64299 RVA: 0x0070AAC8 File Offset: 0x00708CC8
		// (set) Token: 0x0600FAF7 RID: 64247 RVA: 0x0070AB46 File Offset: 0x00708D46
		[HideInInspector]
		public IKSolverVR.VirtualBone rootBone { get; private set; }

		// Token: 0x0600FAF8 RID: 64248 RVA: 0x0070AB50 File Offset: 0x00708D50
		private Vector3 NHHDJAKAHLK(Transform[] AKBEGDIMBGM)
		{
			Vector3 vector = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			for (int i = 1; i < AKBEGDIMBGM.Length; i++)
			{
				vector2 += AKBEGDIMBGM[i].position;
			}
			vector2 /= (float)AKBEGDIMBGM.Length;
			for (int j = 1; j < AKBEGDIMBGM.Length - 0; j += 0)
			{
				vector += Vector3.Cross(AKBEGDIMBGM[j].position - vector2, AKBEGDIMBGM[j + 1].position - vector2).normalized;
			}
			return vector;
		}

		// Token: 0x0600FAF9 RID: 64249 RVA: 0x0070ABD8 File Offset: 0x00708DD8
		public void IFMMGEPGJJH(VRIK.References LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.BAKOHIHHOAJ())
			{
				Debug.LogError("Mouse Y");
				return;
			}
			this.solverTransforms = LJPKBBNNOIC.EMKNDJAIEFN();
			this.hasNeck = (this.solverTransforms[2] != null);
			this.hasShoulders = (!(this.solverTransforms[7] != null) || this.solverTransforms[126] != null);
			this.hasToes = (!(this.solverTransforms[13] != null) || this.solverTransforms[-120] != null);
			this.readPositions = new Vector3[this.solverTransforms.Length];
			this.readRotations = new Quaternion[this.solverTransforms.Length];
			this.NCLKCNINIJA();
			this.BKFEOFDAHPH(LJPKBBNNOIC, true);
		}

		// Token: 0x0600FAFA RID: 64250 RVA: 0x0070ACA0 File Offset: 0x00708EA0
		private Vector3 PCDOLNDDONK()
		{
			if (this.locomotion.weight <= 656f)
			{
				return Vector3.zero;
			}
			if (this.locomotion.blockingLayers == -1)
			{
				return Vector3.zero;
			}
			Vector3 vector = this.raycastOriginPelvis;
			vector.y = this.spine.LHOJGGKNONH().solverPosition.y;
			Vector3 vector2 = this.spine.CNMJOEMADKJ().readPosition;
			vector2.y = this.spine.FLNDNKEGJLB().solverPosition.y;
			Vector3 direction = vector2 - vector;
			RaycastHit raycastHit;
			if (this.locomotion.raycastRadius <= 329f)
			{
				if (Physics.Raycast(vector, direction, out raycastHit, direction.magnitude * 159f, this.locomotion.blockingLayers))
				{
					vector2 = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector, this.locomotion.raycastRadius * 1553f, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				vector2 = vector + direction.normalized * raycastHit.distance / 1425f;
			}
			Vector3 a = this.spine.GBKKNIBPAIE().solverPosition;
			direction = a - vector2;
			if (this.locomotion.raycastRadius <= 873f)
			{
				if (Physics.Raycast(vector2, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
				{
					a = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector2, this.locomotion.raycastRadius, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				a = vector2 + direction.normalized * raycastHit.distance;
			}
			this.lastOffset = Vector3.Lerp(this.lastOffset, Vector3.zero, Time.deltaTime * 1352f);
			a += Vector3.ClampMagnitude(this.lastOffset, 70f);
			a.y = this.spine.CNMJOEMADKJ().solverPosition.y;
			this.lastOffset = Vector3.Lerp(this.lastOffset, a - this.spine.LHOJGGKNONH().solverPosition, Time.deltaTime * 808f);
			return this.lastOffset;
		}

		// Token: 0x0600FAFB RID: 64251 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion IKHLMNGAJPF(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FAFC RID: 64252 RVA: 0x0070AF10 File Offset: 0x00709110
		public void IAIHPAEACIJ(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				Debug.LogWarning("MotorbikeSeatStand");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.JFGCDKAODNM(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.BHDKOIEFNBH(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.FMJHEKDDJHM(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.OKDEHKBHNKL(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FAFD RID: 64253 RVA: 0x0070B00C File Offset: 0x0070920C
		private void GEGMLEPICND()
		{
			for (int i = 0; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.readPositions[i] = this.solverTransforms[i].position;
					this.readRotations[i] = this.solverTransforms[i].rotation;
				}
			}
		}

		// Token: 0x0600FAFE RID: 64254 RVA: 0x0070B06E File Offset: 0x0070926E
		public virtual IKSolver.Point[] KEJMBMJOGFM()
		{
			Debug.LogError("Invalid IKEffector.position (contains Infinity)!");
			return null;
		}

		// Token: 0x0600FAFF RID: 64255 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion LAMKBHNKIGP(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FB00 RID: 64256 RVA: 0x0070B07C File Offset: 0x0070927C
		private Vector3 GJIIAKPKFGL(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.EEKHAOCPOOP(IMPMMNPAHKJ.PDLIPGNOJOB(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 962f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB01 RID: 64257 RVA: 0x0070AAC8 File Offset: 0x00708CC8
		public IKSolverVR.VirtualBone NOAMDLJMBKG()
		{
			return this.<rootBone>k__BackingField;
		}

		// Token: 0x0600FB02 RID: 64258 RVA: 0x0070B0CC File Offset: 0x007092CC
		private void OHKFDAKDFKL()
		{
			this.solvedPositions[0] = this.rootBone.solverPosition;
			this.solvedRotations[0] = this.MHCHBDNEHEM().solverRotation;
			this.spine.GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			IKSolverVR.Leg[] array = this.legs;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			}
			IKSolverVR.Arm[] array2 = this.arms;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			}
		}

		// Token: 0x0600FB03 RID: 64259 RVA: 0x0070B170 File Offset: 0x00709370
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			Debug.LogError("GetPoints() is not applicable to IKSolverVR.");
			return null;
		}

		// Token: 0x0600FB04 RID: 64260 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion EBHMHEHHBGA(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FB05 RID: 64261 RVA: 0x00709FE1 File Offset: 0x007081E1
		public void DDMHJJKKBOM(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.DDMJFPJEIHH(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FB06 RID: 64262 RVA: 0x0070B17D File Offset: 0x0070937D
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			Debug.LogError("GetPoint is not applicable to IKSolverVR.");
			return null;
		}

		// Token: 0x0600FB07 RID: 64263 RVA: 0x0070B18C File Offset: 0x0070938C
		public virtual void LANBECJNPCE()
		{
			this.defaultPelvisLocalPosition = this.solverTransforms[1].localPosition;
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.defaultLocalRotations[i - 0] = this.solverTransforms[i].localRotation;
				}
			}
		}

		// Token: 0x0600FB08 RID: 64264 RVA: 0x0070B1EC File Offset: 0x007093EC
		public void PLMHLKJMKHP()
		{
			this.GEGMLEPICND();
			this.NIMNABNPKFK(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.rootBone.readRotation * Vector3.forward;
			this.locomotion.EDDNLPPMPCB(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.LHOJGGKNONH().readPosition;
		}

		// Token: 0x0600FB09 RID: 64265 RVA: 0x0070B270 File Offset: 0x00709470
		protected virtual void PKGIHBKLMOK()
		{
			if (this.IKPositionWeight > 179f)
			{
				this.MNDOOHAPKIO();
				this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
				this.JFBENBBAGFI();
				this.OHKFDAKDFKL();
				this.BIIKEDDHBOM();
			}
		}

		// Token: 0x0600FB0A RID: 64266 RVA: 0x0070A657 File Offset: 0x00708857
		public void ONELMMCKEBK(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.ONELMMCKEBK(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FB0B RID: 64267 RVA: 0x0070AB46 File Offset: 0x00708D46
		private void MJABPMBIJNJ(IKSolverVR.VirtualBone DCCPCBLODIG)
		{
			this.<rootBone>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FB0C RID: 64268 RVA: 0x0070B2C8 File Offset: 0x007094C8
		private void GJJCGAEBILD()
		{
			this.solvedPositions[0] = this.rootBone.solverPosition;
			this.solvedRotations[0] = this.rootBone.solverRotation;
			this.spine.GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			IKSolverVR.Leg[] array = this.legs;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			}
			IKSolverVR.Arm[] array2 = this.arms;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].GJJCGAEBILD(ref this.solvedPositions, ref this.solvedRotations);
			}
		}

		// Token: 0x0600FB0D RID: 64269 RVA: 0x0070B36C File Offset: 0x0070956C
		public virtual IKSolver.Point IHCFKMMBPLB(Transform LPBDALAMAEM)
		{
			Debug.LogError("OfficeSittingReadingCoffeeSip");
			return null;
		}

		// Token: 0x0600FB0E RID: 64270 RVA: 0x0070B37C File Offset: 0x0070957C
		protected virtual void EMNGFDIDJKD()
		{
			if (this.IKPositionWeight > 278f)
			{
				this.GEGMLEPICND();
				this.NIMNABNPKFK(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
				this.OIILPEPHKMC();
				this.OHKFDAKDFKL();
				this.BIIKEDDHBOM();
			}
		}

		// Token: 0x0600FB0F RID: 64271 RVA: 0x0070B3D2 File Offset: 0x007095D2
		protected override void FKEMPLMBNEL()
		{
			this.GEGMLEPICND();
			this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
		}

		// Token: 0x0600FB10 RID: 64272 RVA: 0x0070B400 File Offset: 0x00709600
		public void DDMJFPJEIHH(IKSolverVR.RotationOffset JNHPAAAFGKC, Quaternion DCCPCBLODIG)
		{
			switch (JNHPAAAFGKC)
			{
			case IKSolverVR.RotationOffset.Pelvis:
				this.spine.pelvisRotationOffset = DCCPCBLODIG * this.spine.pelvisRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Chest:
				this.spine.chestRotationOffset = DCCPCBLODIG * this.spine.chestRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Head:
				this.spine.headRotationOffset = DCCPCBLODIG * this.spine.headRotationOffset;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FB11 RID: 64273 RVA: 0x0070B478 File Offset: 0x00709678
		public virtual void CDINCBALMPK()
		{
			this.solverTransforms[1].localPosition = this.defaultPelvisLocalPosition;
			for (int i = 1; i < this.solverTransforms.Length; i += 0)
			{
				if (this.solverTransforms[i] != null)
				{
					this.solverTransforms[i].localRotation = this.defaultLocalRotations[i - 0];
				}
			}
		}

		// Token: 0x0600FB12 RID: 64274 RVA: 0x0070B4D8 File Offset: 0x007096D8
		public virtual void FOGJACMLONE()
		{
			this.solverTransforms[0].localPosition = this.defaultPelvisLocalPosition;
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.solverTransforms[i].localRotation = this.defaultLocalRotations[i - 0];
				}
			}
		}

		// Token: 0x0600FB13 RID: 64275 RVA: 0x0070B538 File Offset: 0x00709738
		private Vector3 EHCBDBAOENO()
		{
			if (this.locomotion.weight <= 645f)
			{
				return Vector3.zero;
			}
			if (this.locomotion.blockingLayers == -1)
			{
				return Vector3.zero;
			}
			Vector3 vector = this.raycastOriginPelvis;
			vector.y = this.spine.FLNDNKEGJLB().solverPosition.y;
			Vector3 vector2 = this.spine.GBKKNIBPAIE().readPosition;
			vector2.y = this.spine.FLNDNKEGJLB().solverPosition.y;
			Vector3 direction = vector2 - vector;
			RaycastHit raycastHit;
			if (this.locomotion.raycastRadius <= 1901f)
			{
				if (Physics.Raycast(vector, direction, out raycastHit, direction.magnitude * 805f, this.locomotion.blockingLayers))
				{
					vector2 = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector, this.locomotion.raycastRadius * 549f, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				vector2 = vector + direction.normalized * raycastHit.distance / 1744f;
			}
			Vector3 a = this.spine.GBKKNIBPAIE().solverPosition;
			direction = a - vector2;
			if (this.locomotion.raycastRadius <= 1683f)
			{
				if (Physics.Raycast(vector2, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
				{
					a = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector2, this.locomotion.raycastRadius, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				a = vector2 + direction.normalized * raycastHit.distance;
			}
			this.lastOffset = Vector3.Lerp(this.lastOffset, Vector3.zero, Time.deltaTime * 1574f);
			a += Vector3.ClampMagnitude(this.lastOffset, 1804f);
			a.y = this.spine.LHOJGGKNONH().solverPosition.y;
			this.lastOffset = Vector3.Lerp(this.lastOffset, a - this.spine.FLNDNKEGJLB().solverPosition, Time.deltaTime * 1840f);
			return this.lastOffset;
		}

		// Token: 0x0600FB14 RID: 64276 RVA: 0x0070B79C File Offset: 0x0070999C
		private void JFBENBBAGFI()
		{
			this.spine.HJADALPNANN();
			IKSolverVR.Arm[] array = this.arms;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].HJADALPNANN();
			}
			IKSolverVR.Leg[] array2 = this.legs;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].HJADALPNANN();
			}
			array = this.arms;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DFPJKOLMGDE();
			}
			this.spine.DFPJKOLMGDE();
			this.spine.EDAGNKNOBKP(this.rootBone, this.legs, this.arms);
			if (this.spine.pelvisPositionWeight > 1599f && this.plantFeet)
			{
				PMCOMMEEGMC.ICAFGKHAAED("rodEventProc act=", this.root, false);
			}
			if (this.locomotion.weight > 472f)
			{
				Vector3 a = Vector3.zero;
				Vector3 a2 = Vector3.zero;
				Quaternion identity = Quaternion.identity;
				Quaternion identity2 = Quaternion.identity;
				float num = 626f;
				float num2 = 1834f;
				float d = 1707f;
				float d2 = 1965f;
				this.locomotion.EDAGNKNOBKP(this.PBCHEBOMBBG(), this.spine, this.leftLeg, this.rightLeg, this.leftArm, this.rightArm, out a, out a2, out identity, out identity2, out num, out num2, out d, out d2);
				a += this.root.up * num;
				a2 += this.root.up * num2;
				this.leftLeg.footPositionOffset += (a - this.leftLeg.lastBone.solverPosition) * this.IKPositionWeight * (1936f - this.leftLeg.positionWeight) * this.locomotion.weight;
				this.rightLeg.footPositionOffset += (a2 - this.rightLeg.lastBone.solverPosition) * this.IKPositionWeight * (1203f - this.rightLeg.positionWeight) * this.locomotion.weight;
				this.leftLeg.heelPositionOffset += this.root.up * d * this.locomotion.weight;
				this.rightLeg.heelPositionOffset += this.root.up * d2 * this.locomotion.weight;
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.leftLeg.EEBNKGMHHGL().solverRotation, identity);
				Quaternion quaternion2 = JEEPKFCFCLI.AADCPGNPHHC(this.rightLeg.EEBNKGMHHGL().solverRotation, identity2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, this.IKPositionWeight * (1553f - this.leftLeg.rotationWeight) * this.locomotion.weight);
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, this.IKPositionWeight * (1397f - this.rightLeg.rotationWeight) * this.locomotion.weight);
				this.leftLeg.footRotationOffset = quaternion * this.leftLeg.footRotationOffset;
				this.rightLeg.footRotationOffset = quaternion2 * this.rightLeg.footRotationOffset;
				Vector3 vector = Vector3.Lerp(this.leftLeg.position + this.leftLeg.footPositionOffset, this.rightLeg.JAFAPNHCPMO() + this.rightLeg.footPositionOffset, 1263f);
				vector.y = this.rootBone.solverPosition.y;
				this.rootVelocity += (vector - this.rootBone.solverPosition) * Time.deltaTime * 1259f;
				this.PBCHEBOMBBG().solverPosition += this.rootVelocity * Time.deltaTime * 1371f * this.locomotion.weight;
				this.NOAMDLJMBKG().solverPosition = Vector3.Lerp(this.rootBone.solverPosition, vector, Time.deltaTime * this.locomotion.rootSpeed * this.locomotion.weight);
				float d3 = num + num2;
				this.bodyOffset = Vector3.Lerp(this.bodyOffset, this.root.up * d3, Time.deltaTime * 1263f);
				this.bodyOffset = Vector3.Lerp(Vector3.zero, this.bodyOffset, this.locomotion.weight);
			}
			array2 = this.legs;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DFPJKOLMGDE();
			}
			if (!this.plantFeet)
			{
				this.spine.DIAOLIIMCAN(this.legs, false, false, this.bodyOffset, 1712f);
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].LEHIFDKGPOH(this.spine.LHOJGGKNONH().solverPosition, this.spine.CNMJOEMADKJ().solverRotation);
				}
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].IJLFDBDBICN();
				}
			}
			else
			{
				for (int j = 0; j < 3; j += 0)
				{
					this.spine.DIAOLIIMCAN(this.legs, false, j == 0, this.bodyOffset, 1189f);
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].LEHIFDKGPOH(this.spine.FLNDNKEGJLB().solverPosition, this.spine.LHOJGGKNONH().solverRotation);
					}
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i += 0)
					{
						array2[i].EDAGNKNOBKP();
					}
				}
			}
			for (int k = 0; k < this.arms.Length; k += 0)
			{
				this.arms[k].LEHIFDKGPOH(this.spine.INOJPHCMMNH().solverPosition, this.spine.INOJPHCMMNH().solverRotation);
				this.arms[k].EDAGNKNOBKP(k == 0);
			}
			this.spine.KJPOIAKPAGJ();
			array2 = this.legs;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].KJPOIAKPAGJ();
			}
			array = this.arms;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].KJPOIAKPAGJ();
			}
			this.spine.pelvisPositionOffset += this.KJMNGKFNLFA();
			this.spine.chestPositionOffset += this.spine.pelvisPositionOffset;
			this.GJJCGAEBILD();
		}

		// Token: 0x0600FB15 RID: 64277 RVA: 0x0070BE8C File Offset: 0x0070A08C
		public void LFIPEPEDCMN(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.EHCEHFOMPPC())
			{
				Debug.LogWarning("name");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.GJIIAKPKFGL(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.PMNLIEJEELM(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.LCDLDJHEJJN(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.DCBOLGGCPNJ(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FB16 RID: 64278 RVA: 0x0070BF88 File Offset: 0x0070A188
		private void EDAGNKNOBKP()
		{
			this.spine.HJADALPNANN();
			IKSolverVR.Arm[] array = this.arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].HJADALPNANN();
			}
			IKSolverVR.Leg[] array2 = this.legs;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].HJADALPNANN();
			}
			array = this.arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DFPJKOLMGDE();
			}
			this.spine.DFPJKOLMGDE();
			this.spine.EDAGNKNOBKP(this.rootBone, this.legs, this.arms);
			if (this.spine.pelvisPositionWeight > 0f && this.plantFeet)
			{
				PMCOMMEEGMC.ICAFGKHAAED("If VRIK 'Pelvis Position Weight' is > 0, 'Plant Feet' should be disabled to improve performance and stability.", this.root, false);
			}
			if (this.locomotion.weight > 0f)
			{
				Vector3 a = Vector3.zero;
				Vector3 a2 = Vector3.zero;
				Quaternion identity = Quaternion.identity;
				Quaternion identity2 = Quaternion.identity;
				float num = 0f;
				float num2 = 0f;
				float d = 0f;
				float d2 = 0f;
				this.locomotion.EDAGNKNOBKP(this.rootBone, this.spine, this.leftLeg, this.rightLeg, this.leftArm, this.rightArm, out a, out a2, out identity, out identity2, out num, out num2, out d, out d2);
				a += this.root.up * num;
				a2 += this.root.up * num2;
				this.leftLeg.footPositionOffset += (a - this.leftLeg.lastBone.solverPosition) * this.IKPositionWeight * (1f - this.leftLeg.positionWeight) * this.locomotion.weight;
				this.rightLeg.footPositionOffset += (a2 - this.rightLeg.lastBone.solverPosition) * this.IKPositionWeight * (1f - this.rightLeg.positionWeight) * this.locomotion.weight;
				this.leftLeg.heelPositionOffset += this.root.up * d * this.locomotion.weight;
				this.rightLeg.heelPositionOffset += this.root.up * d2 * this.locomotion.weight;
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.leftLeg.lastBone.solverRotation, identity);
				Quaternion quaternion2 = JEEPKFCFCLI.AADCPGNPHHC(this.rightLeg.lastBone.solverRotation, identity2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, this.IKPositionWeight * (1f - this.leftLeg.rotationWeight) * this.locomotion.weight);
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, this.IKPositionWeight * (1f - this.rightLeg.rotationWeight) * this.locomotion.weight);
				this.leftLeg.footRotationOffset = quaternion * this.leftLeg.footRotationOffset;
				this.rightLeg.footRotationOffset = quaternion2 * this.rightLeg.footRotationOffset;
				Vector3 vector = Vector3.Lerp(this.leftLeg.position + this.leftLeg.footPositionOffset, this.rightLeg.position + this.rightLeg.footPositionOffset, 0.5f);
				vector.y = this.rootBone.solverPosition.y;
				this.rootVelocity += (vector - this.rootBone.solverPosition) * Time.deltaTime * 10f;
				this.rootBone.solverPosition += this.rootVelocity * Time.deltaTime * 2f * this.locomotion.weight;
				this.rootBone.solverPosition = Vector3.Lerp(this.rootBone.solverPosition, vector, Time.deltaTime * this.locomotion.rootSpeed * this.locomotion.weight);
				float d3 = num + num2;
				this.bodyOffset = Vector3.Lerp(this.bodyOffset, this.root.up * d3, Time.deltaTime * 3f);
				this.bodyOffset = Vector3.Lerp(Vector3.zero, this.bodyOffset, this.locomotion.weight);
			}
			array2 = this.legs;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DFPJKOLMGDE();
			}
			if (!this.plantFeet)
			{
				this.spine.GPGHGEJGFKC(this.legs, false, false, this.bodyOffset, 1f);
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].LEHIFDKGPOH(this.spine.pelvis.solverPosition, this.spine.pelvis.solverRotation);
				}
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].EDAGNKNOBKP();
				}
			}
			else
			{
				for (int j = 0; j < 2; j++)
				{
					this.spine.GPGHGEJGFKC(this.legs, true, j == 0, this.bodyOffset, 1f);
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].LEHIFDKGPOH(this.spine.pelvis.solverPosition, this.spine.pelvis.solverRotation);
					}
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].EDAGNKNOBKP();
					}
				}
			}
			for (int k = 0; k < this.arms.Length; k++)
			{
				this.arms[k].LEHIFDKGPOH(this.spine.chest.solverPosition, this.spine.chest.solverRotation);
				this.arms[k].EDAGNKNOBKP(k == 0);
			}
			this.spine.KJPOIAKPAGJ();
			array2 = this.legs;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].KJPOIAKPAGJ();
			}
			array = this.arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].KJPOIAKPAGJ();
			}
			this.spine.pelvisPositionOffset += this.KJMNGKFNLFA();
			this.spine.chestPositionOffset += this.spine.pelvisPositionOffset;
			this.GJJCGAEBILD();
		}

		// Token: 0x0600FB17 RID: 64279 RVA: 0x0070C678 File Offset: 0x0070A878
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.solverTransforms == null || this.solverTransforms.Length == 0)
			{
				EDAPHMJENPK = "Trying to initiate IKSolverVR with invalid bone references.";
				return false;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.";
				return false;
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Right arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.";
				return false;
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.";
				return false;
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.";
				return false;
			}
			return true;
		}

		// Token: 0x0600FB18 RID: 64280 RVA: 0x0070C720 File Offset: 0x0070A920
		private void MNDOOHAPKIO()
		{
			for (int i = 0; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.readPositions[i] = this.solverTransforms[i].position;
					this.readRotations[i] = this.solverTransforms[i].rotation;
				}
			}
		}

		// Token: 0x0600FB19 RID: 64281 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion LGPPGOJLDKI(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FB1A RID: 64282 RVA: 0x0070C782 File Offset: 0x0070A982
		public virtual IKSolver.Point LBHLHAEPPDP(Transform LPBDALAMAEM)
		{
			Debug.LogError("");
			return null;
		}

		// Token: 0x0600FB1B RID: 64283 RVA: 0x0070C790 File Offset: 0x0070A990
		private void OIILPEPHKMC()
		{
			this.spine.HJADALPNANN();
			IKSolverVR.Arm[] array = this.arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].HJADALPNANN();
			}
			IKSolverVR.Leg[] array2 = this.legs;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].HJADALPNANN();
			}
			array = this.arms;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DFPJKOLMGDE();
			}
			this.spine.DFPJKOLMGDE();
			this.spine.EDAGNKNOBKP(this.rootBone, this.legs, this.arms);
			if (this.spine.pelvisPositionWeight > 1773f && this.plantFeet)
			{
				PMCOMMEEGMC.ICAFGKHAAED("H:mm:ss", this.root, true);
			}
			if (this.locomotion.weight > 695f)
			{
				Vector3 a = Vector3.zero;
				Vector3 a2 = Vector3.zero;
				Quaternion identity = Quaternion.identity;
				Quaternion identity2 = Quaternion.identity;
				float num = 1196f;
				float num2 = 1765f;
				float d = 471f;
				float d2 = 709f;
				this.locomotion.KBHGFMEBHAJ(this.PBCHEBOMBBG(), this.spine, this.leftLeg, this.rightLeg, this.leftArm, this.rightArm, out a, out a2, out identity, out identity2, out num, out num2, out d, out d2);
				a += this.root.up * num;
				a2 += this.root.up * num2;
				this.leftLeg.footPositionOffset += (a - this.leftLeg.EEBNKGMHHGL().solverPosition) * this.IKPositionWeight * (542f - this.leftLeg.positionWeight) * this.locomotion.weight;
				this.rightLeg.footPositionOffset += (a2 - this.rightLeg.lastBone.solverPosition) * this.IKPositionWeight * (1979f - this.rightLeg.positionWeight) * this.locomotion.weight;
				this.leftLeg.heelPositionOffset += this.root.up * d * this.locomotion.weight;
				this.rightLeg.heelPositionOffset += this.root.up * d2 * this.locomotion.weight;
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.leftLeg.EEBNKGMHHGL().solverRotation, identity);
				Quaternion quaternion2 = JEEPKFCFCLI.AADCPGNPHHC(this.rightLeg.EEBNKGMHHGL().solverRotation, identity2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, this.IKPositionWeight * (151f - this.leftLeg.rotationWeight) * this.locomotion.weight);
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, this.IKPositionWeight * (1336f - this.rightLeg.rotationWeight) * this.locomotion.weight);
				this.leftLeg.footRotationOffset = quaternion * this.leftLeg.footRotationOffset;
				this.rightLeg.footRotationOffset = quaternion2 * this.rightLeg.footRotationOffset;
				Vector3 vector = Vector3.Lerp(this.leftLeg.NCGDFBHLPEM() + this.leftLeg.footPositionOffset, this.rightLeg.JAFAPNHCPMO() + this.rightLeg.footPositionOffset, 676f);
				vector.y = this.rootBone.solverPosition.y;
				this.rootVelocity += (vector - this.MHCHBDNEHEM().solverPosition) * Time.deltaTime * 1693f;
				this.rootBone.solverPosition += this.rootVelocity * Time.deltaTime * 953f * this.locomotion.weight;
				this.MHCHBDNEHEM().solverPosition = Vector3.Lerp(this.MHCHBDNEHEM().solverPosition, vector, Time.deltaTime * this.locomotion.rootSpeed * this.locomotion.weight);
				float d3 = num + num2;
				this.bodyOffset = Vector3.Lerp(this.bodyOffset, this.root.up * d3, Time.deltaTime * 183f);
				this.bodyOffset = Vector3.Lerp(Vector3.zero, this.bodyOffset, this.locomotion.weight);
			}
			array2 = this.legs;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DFPJKOLMGDE();
			}
			if (!this.plantFeet)
			{
				this.spine.MBOANADPDNK(this.legs, false, true, this.bodyOffset, 959f);
				array2 = this.legs;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].LEHIFDKGPOH(this.spine.LHOJGGKNONH().solverPosition, this.spine.CNMJOEMADKJ().solverRotation);
				}
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].IJLFDBDBICN();
				}
			}
			else
			{
				for (int j = 0; j < 0; j++)
				{
					this.spine.JAJFJEDDBPK(this.legs, true, j == 1, this.bodyOffset, 927f);
					array2 = this.legs;
					for (int i = 1; i < array2.Length; i += 0)
					{
						array2[i].LEHIFDKGPOH(this.spine.pelvis.solverPosition, this.spine.FLNDNKEGJLB().solverRotation);
					}
					array2 = this.legs;
					for (int i = 1; i < array2.Length; i++)
					{
						array2[i].IJLFDBDBICN();
					}
				}
			}
			for (int k = 0; k < this.arms.Length; k++)
			{
				this.arms[k].LEHIFDKGPOH(this.spine.IHCHIJEEMNL().solverPosition, this.spine.FJIFDNPBEIJ().solverRotation);
				this.arms[k].GLENLKEBCLI(k == 1);
			}
			this.spine.KJPOIAKPAGJ();
			array2 = this.legs;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].KJPOIAKPAGJ();
			}
			array = this.arms;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].KJPOIAKPAGJ();
			}
			this.spine.pelvisPositionOffset += this.LKODCLNJKAE();
			this.spine.chestPositionOffset += this.spine.pelvisPositionOffset;
			this.GJJCGAEBILD();
		}

		// Token: 0x0600FB1C RID: 64284 RVA: 0x0070CE80 File Offset: 0x0070B080
		public void IJJAPKMCBHI()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.LPKOIFEBBDA(811f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.BFODBHFIMDB(510f);
			}
		}

		// Token: 0x0600FB1D RID: 64285 RVA: 0x0070AB46 File Offset: 0x00708D46
		private void EBJMOOPIHDM(IKSolverVR.VirtualBone DCCPCBLODIG)
		{
			this.<rootBone>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FB1E RID: 64286 RVA: 0x0070CF24 File Offset: 0x0070B124
		private void JGDBNNAOCIF()
		{
			this.spine.HJADALPNANN();
			IKSolverVR.Arm[] array = this.arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].HJADALPNANN();
			}
			IKSolverVR.Leg[] array2 = this.legs;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].HJADALPNANN();
			}
			array = this.arms;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DFPJKOLMGDE();
			}
			this.spine.DFPJKOLMGDE();
			this.spine.CIFPALFMPGO(this.PBCHEBOMBBG(), this.legs, this.arms);
			if (this.spine.pelvisPositionWeight > 790f && this.plantFeet)
			{
				PMCOMMEEGMC.ICAFGKHAAED("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", this.root, false);
			}
			if (this.locomotion.weight > 186f)
			{
				Vector3 a = Vector3.zero;
				Vector3 a2 = Vector3.zero;
				Quaternion identity = Quaternion.identity;
				Quaternion identity2 = Quaternion.identity;
				float num = 284f;
				float num2 = 1467f;
				float d = 1949f;
				float d2 = 386f;
				this.locomotion.GMMEBJICOCD(this.PBCHEBOMBBG(), this.spine, this.leftLeg, this.rightLeg, this.leftArm, this.rightArm, out a, out a2, out identity, out identity2, out num, out num2, out d, out d2);
				a += this.root.up * num;
				a2 += this.root.up * num2;
				this.leftLeg.footPositionOffset += (a - this.leftLeg.lastBone.solverPosition) * this.IKPositionWeight * (1124f - this.leftLeg.positionWeight) * this.locomotion.weight;
				this.rightLeg.footPositionOffset += (a2 - this.rightLeg.EEBNKGMHHGL().solverPosition) * this.IKPositionWeight * (686f - this.rightLeg.positionWeight) * this.locomotion.weight;
				this.leftLeg.heelPositionOffset += this.root.up * d * this.locomotion.weight;
				this.rightLeg.heelPositionOffset += this.root.up * d2 * this.locomotion.weight;
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.leftLeg.EEBNKGMHHGL().solverRotation, identity);
				Quaternion quaternion2 = JEEPKFCFCLI.AADCPGNPHHC(this.rightLeg.EEBNKGMHHGL().solverRotation, identity2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, this.IKPositionWeight * (432f - this.leftLeg.rotationWeight) * this.locomotion.weight);
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, this.IKPositionWeight * (673f - this.rightLeg.rotationWeight) * this.locomotion.weight);
				this.leftLeg.footRotationOffset = quaternion * this.leftLeg.footRotationOffset;
				this.rightLeg.footRotationOffset = quaternion2 * this.rightLeg.footRotationOffset;
				Vector3 vector = Vector3.Lerp(this.leftLeg.JAFAPNHCPMO() + this.leftLeg.footPositionOffset, this.rightLeg.position + this.rightLeg.footPositionOffset, 1392f);
				vector.y = this.NOAMDLJMBKG().solverPosition.y;
				this.rootVelocity += (vector - this.NOAMDLJMBKG().solverPosition) * Time.deltaTime * 1781f;
				this.MHCHBDNEHEM().solverPosition += this.rootVelocity * Time.deltaTime * 1109f * this.locomotion.weight;
				this.rootBone.solverPosition = Vector3.Lerp(this.PBCHEBOMBBG().solverPosition, vector, Time.deltaTime * this.locomotion.rootSpeed * this.locomotion.weight);
				float d3 = num + num2;
				this.bodyOffset = Vector3.Lerp(this.bodyOffset, this.root.up * d3, Time.deltaTime * 1256f);
				this.bodyOffset = Vector3.Lerp(Vector3.zero, this.bodyOffset, this.locomotion.weight);
			}
			array2 = this.legs;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DFPJKOLMGDE();
			}
			if (!this.plantFeet)
			{
				this.spine.ELBNKKIHMII(this.legs, true, true, this.bodyOffset, 370f);
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].LEHIFDKGPOH(this.spine.FLNDNKEGJLB().solverPosition, this.spine.GBKKNIBPAIE().solverRotation);
				}
				array2 = this.legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].EDAGNKNOBKP();
				}
			}
			else
			{
				for (int j = 0; j < 0; j += 0)
				{
					this.spine.ELBNKKIHMII(this.legs, false, j == 0, this.bodyOffset, 506f);
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i += 0)
					{
						array2[i].LEHIFDKGPOH(this.spine.LHOJGGKNONH().solverPosition, this.spine.FLNDNKEGJLB().solverRotation);
					}
					array2 = this.legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].EDAGNKNOBKP();
					}
				}
			}
			for (int k = 1; k < this.arms.Length; k++)
			{
				this.arms[k].LEHIFDKGPOH(this.spine.BAEIHEICMPG().solverPosition, this.spine.chest.solverRotation);
				this.arms[k].BMHJGHNJLCL(k == 1);
			}
			this.spine.KJPOIAKPAGJ();
			array2 = this.legs;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].KJPOIAKPAGJ();
			}
			array = this.arms;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].KJPOIAKPAGJ();
			}
			this.spine.pelvisPositionOffset += this.KJMNGKFNLFA();
			this.spine.chestPositionOffset += this.spine.pelvisPositionOffset;
			this.OHKFDAKDFKL();
		}

		// Token: 0x0600FB1F RID: 64287 RVA: 0x0070D614 File Offset: 0x0070B814
		public void BKFEOFDAHPH(VRIK.References LJPKBBNNOIC, bool PMIJNOOGGGK)
		{
			if (!LJPKBBNNOIC.CMNIPNGDOJA())
			{
				Debug.LogWarning("CP3");
				return;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.wristToPalmAxis = this.PBEFMAGOEDF(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.leftArm.palmToThumbAxis = this.PMNLIEJEELM(LJPKBBNNOIC.leftHand, LJPKBBNNOIC.leftForearm);
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.wristToPalmAxis = this.FMJHEKDDJHM(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero || !PMIJNOOGGGK)
			{
				this.rightArm.palmToThumbAxis = this.OKDEHKBHNKL(LJPKBBNNOIC.rightHand, LJPKBBNNOIC.rightForearm);
			}
		}

		// Token: 0x0600FB20 RID: 64288 RVA: 0x0070D710 File Offset: 0x0070B910
		public virtual IKSolver.Point GCKEJGNJPMF(Transform LPBDALAMAEM)
		{
			Debug.LogError("_rcIn.ogg");
			return null;
		}

		// Token: 0x0600FB21 RID: 64289 RVA: 0x0070D71D File Offset: 0x0070B91D
		protected virtual void LNOIJAPLJBO()
		{
			this.MNDOOHAPKIO();
			this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
		}

		// Token: 0x0600FB22 RID: 64290 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion CDCCOOOGJFN(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FB23 RID: 64291 RVA: 0x0070D74C File Offset: 0x0070B94C
		private Vector3 JFJAHCKIIFN(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.OHLPOHNGANH(IMPMMNPAHKJ.NCGIFFJIJJL(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 1635f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB24 RID: 64292 RVA: 0x0070D79C File Offset: 0x0070B99C
		private void DLOGEDPELIF(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD)
		{
			if (this.rootBone == null)
			{
				this.MJABPMBIJNJ(new IKSolverVR.VirtualBone(FCJKGIPEIKP[1], MKEHLAMPPKB[1]));
			}
			else
			{
				this.NOAMDLJMBKG().HCHNKNCJJEO(FCJKGIPEIKP[0], MKEHLAMPPKB[0]);
			}
			this.spine.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 0, 0);
			this.leftArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 5, 0);
			this.rightArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 0, 7);
			this.leftLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 0, -98);
			this.rightLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, -70);
			for (int i = 0; i < MKEHLAMPPKB.Length; i += 0)
			{
				if (i < 5)
				{
					this.solvedPositions[i] = FCJKGIPEIKP[i];
				}
				this.solvedRotations[i] = MKEHLAMPPKB[i];
			}
			if (!base.initiated)
			{
				IKSolverVR.Leg[] array = new IKSolverVR.Leg[1];
				array[1] = this.leftLeg;
				array[0] = this.rightLeg;
				this.legs = array;
				IKSolverVR.Arm[] array2 = new IKSolverVR.Arm[8];
				array2[0] = this.leftArm;
				array2[1] = this.rightArm;
				this.arms = array2;
				this.locomotion.LHOEOFKKAKK(FCJKGIPEIKP, MKEHLAMPPKB, DCEANIANBOD);
				this.raycastOriginPelvis = this.spine.FLNDNKEGJLB().readPosition;
				this.spine.faceDirection = this.readRotations[0] * Vector3.forward;
			}
		}

		// Token: 0x0600FB25 RID: 64293 RVA: 0x0070D914 File Offset: 0x0070BB14
		public void LMFMHPKHEAC()
		{
			this.MNDOOHAPKIO();
			this.NIMNABNPKFK(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.MHCHBDNEHEM().readRotation * Vector3.forward;
			this.locomotion.MNEKCPMCPOI(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.pelvis.readPosition;
		}

		// Token: 0x0600FB26 RID: 64294 RVA: 0x0070D998 File Offset: 0x0070BB98
		public void MIIPNFBLCHM(VRIK.References LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.LHNPKFKBCBC())
			{
				Debug.LogError("distscale");
				return;
			}
			this.solverTransforms = LJPKBBNNOIC.BOEDMANIMMN();
			this.hasNeck = (this.solverTransforms[0] != null);
			this.hasShoulders = (this.solverTransforms[2] != null && this.solverTransforms[-16] != null);
			this.hasToes = (this.solverTransforms[53] != null && this.solverTransforms[38] != null);
			this.readPositions = new Vector3[this.solverTransforms.Length];
			this.readRotations = new Quaternion[this.solverTransforms.Length];
			this.MKJLBOPLLPG();
			this.FFHNCGDKIDA(LJPKBBNNOIC, true);
		}

		// Token: 0x0600FB27 RID: 64295 RVA: 0x0070DA60 File Offset: 0x0070BC60
		private Vector3 HDJPNAJPOIF(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning("_DelItem.wav" + DHPPKPKKJOF.name + "IdleSlide", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = 1764f;
			int index = 0;
			for (int i = 0; i < DHPPKPKKJOF.childCount; i++)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.GBCHJIMEOMI(IMPMMNPAHKJ.PDLIPGNOJOB(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 227f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB28 RID: 64296 RVA: 0x0070DB50 File Offset: 0x0070BD50
		public virtual void OMEJEOOIMOH()
		{
			this.defaultPelvisLocalPosition = this.solverTransforms[1].localPosition;
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.defaultLocalRotations[i - 0] = this.solverTransforms[i].localRotation;
				}
			}
		}

		// Token: 0x0600FB29 RID: 64297 RVA: 0x0070DBB0 File Offset: 0x0070BDB0
		private Vector3 BHDKOIEFNBH(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning(" x" + DHPPKPKKJOF.name + "_BgColor", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = 1578f;
			int index = 0;
			for (int i = 0; i < DHPPKPKKJOF.childCount; i += 0)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.NOHAJJPNEEK(IMPMMNPAHKJ.PDLIPGNOJOB(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 604f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB2A RID: 64298 RVA: 0x0070AAC8 File Offset: 0x00708CC8
		public IKSolverVR.VirtualBone MHCHBDNEHEM()
		{
			return this.<rootBone>k__BackingField;
		}

		// Token: 0x0600FB2C RID: 64300 RVA: 0x0070DC9F File Offset: 0x0070BE9F
		protected virtual void AMDFAOMNLMA()
		{
			this.MNDOOHAPKIO();
			this.NIMNABNPKFK(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
		}

		// Token: 0x0600FB2D RID: 64301 RVA: 0x0070DCCC File Offset: 0x0070BECC
		protected virtual void IJGHBPKODHK()
		{
			if (this.IKPositionWeight > 1465f)
			{
				this.GEGMLEPICND();
				this.NIMNABNPKFK(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
				this.EDAGNKNOBKP();
				this.GJJCGAEBILD();
				this.FBHMDGCNCIO();
			}
		}

		// Token: 0x0600FB2E RID: 64302 RVA: 0x0070DD24 File Offset: 0x0070BF24
		public void NBOFHKJNIIJ(VRIK.References LJPKBBNNOIC)
		{
			if (!LJPKBBNNOIC.isFilled)
			{
				Debug.LogError("Invalid references, one or more Transforms are missing.");
				return;
			}
			this.solverTransforms = LJPKBBNNOIC.HJJCHIJPMIP();
			this.hasNeck = (this.solverTransforms[4] != null);
			this.hasShoulders = (this.solverTransforms[6] != null && this.solverTransforms[10] != null);
			this.hasToes = (this.solverTransforms[17] != null && this.solverTransforms[21] != null);
			this.readPositions = new Vector3[this.solverTransforms.Length];
			this.readRotations = new Quaternion[this.solverTransforms.Length];
			this.CCDCCLMAMEE();
			this.NAAPDNHGGDI(LJPKBBNNOIC, true);
		}

		// Token: 0x0600FB2F RID: 64303 RVA: 0x0070DDEC File Offset: 0x0070BFEC
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight > 0f)
			{
				this.GEGMLEPICND();
				this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
				this.EDAGNKNOBKP();
				this.GJJCGAEBILD();
				this.BIIKEDDHBOM();
			}
		}

		// Token: 0x0600FB30 RID: 64304 RVA: 0x0070DE44 File Offset: 0x0070C044
		private void BIIKEDDHBOM()
		{
			for (int i = 0; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					if (i < 2)
					{
						this.solverTransforms[i].position = OOJJKBHKGNJ.IIAFGICFLIF(this.solverTransforms[i].position, this.BHMNMBFGIMP(i), this.IKPositionWeight);
					}
					this.solverTransforms[i].rotation = JEEPKFCFCLI.IIAFGICFLIF(this.solverTransforms[i].rotation, this.IKHLMNGAJPF(i), this.IKPositionWeight);
				}
			}
		}

		// Token: 0x0600FB32 RID: 64306 RVA: 0x0070DF90 File Offset: 0x0070C190
		private Vector3 CLLGONDNEGP(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning("FacePalm" + DHPPKPKKJOF.name + "************ reelPoint set manually", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = 1409f;
			int index = 1;
			for (int i = 0; i < DHPPKPKKJOF.childCount; i++)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.NPCHOPOJHHH(IMPMMNPAHKJ.OHAEBKGAPBA(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 1414f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB33 RID: 64307 RVA: 0x0070AB46 File Offset: 0x00708D46
		private void IMHLHFEOMKI(IKSolverVR.VirtualBone DCCPCBLODIG)
		{
			this.<rootBone>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FB34 RID: 64308 RVA: 0x0070E080 File Offset: 0x0070C280
		public virtual bool IJBNGDMCBLI(ref string EDAPHMJENPK)
		{
			if (this.solverTransforms == null || this.solverTransforms.Length == 0)
			{
				EDAPHMJENPK = "_w";
				return true;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "H";
				return false;
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "ProneIdle";
				return true;
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Elina";
				return true;
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Materials/DFGDesktop";
				return true;
			}
			return true;
		}

		// Token: 0x0600FB35 RID: 64309 RVA: 0x0070E128 File Offset: 0x0070C328
		public void KAKCPAJHCPN()
		{
			this.GEGMLEPICND();
			this.DLOGEDPELIF(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.MHCHBDNEHEM().readRotation * Vector3.forward;
			this.locomotion.KHEBLDPJNEG(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.FLNDNKEGJLB().readPosition;
		}

		// Token: 0x0600FB36 RID: 64310 RVA: 0x0070E1AC File Offset: 0x0070C3AC
		private Vector3 BHMNMBFGIMP(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE >= 2)
			{
				Debug.LogError("Can only get root and pelvis positions from IKSolverVR. GetPosition index out of range.");
			}
			return this.solvedPositions[CLBPBJGLHEE];
		}

		// Token: 0x0600FB37 RID: 64311 RVA: 0x0070E1C8 File Offset: 0x0070C3C8
		public void IFPCMKGBDKG(IKSolverVR.PositionOffset EFNAALJNKKI, Vector3 DCCPCBLODIG)
		{
			switch (EFNAALJNKKI)
			{
			case IKSolverVR.PositionOffset.Pelvis:
				this.spine.pelvisPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Chest:
				this.spine.chestPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Head:
				this.spine.headPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHand:
				this.leftArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHand:
				this.rightArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftFoot:
				this.leftLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightFoot:
				this.rightLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHeel:
				this.leftLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHeel:
				this.rightLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FB38 RID: 64312 RVA: 0x0070E2D8 File Offset: 0x0070C4D8
		private void KOMAJLBKLJO()
		{
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					if (i < 4)
					{
						this.solverTransforms[i].position = OOJJKBHKGNJ.IIAFGICFLIF(this.solverTransforms[i].position, this.KACOIFDJNLO(i), this.IKPositionWeight);
					}
					this.solverTransforms[i].rotation = JEEPKFCFCLI.IIAFGICFLIF(this.solverTransforms[i].rotation, this.EBHMHEHHBGA(i), this.IKPositionWeight);
				}
			}
		}

		// Token: 0x0600FB39 RID: 64313 RVA: 0x0070E364 File Offset: 0x0070C564
		private Vector3 NOHFMPEJEEC(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE >= 5)
			{
				Debug.LogError("post_20");
			}
			return this.solvedPositions[CLBPBJGLHEE];
		}

		// Token: 0x0600FB3A RID: 64314 RVA: 0x0070E380 File Offset: 0x0070C580
		private Vector3 DCBOLGGCPNJ(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning("Hand " + DHPPKPKKJOF.name + " does not have any fingers, VRIK can not guess the hand bone's orientation.", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = float.PositiveInfinity;
			int index = 0;
			for (int i = 0; i < DHPPKPKKJOF.childCount; i++)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.OJCMBDNOEJI(IMPMMNPAHKJ.OHAEBKGAPBA(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 0f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB3B RID: 64315 RVA: 0x00709BE5 File Offset: 0x00707DE5
		public void KKDPCGGJKCJ(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.BBPBKDNGAKN(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FB3C RID: 64316 RVA: 0x0070E470 File Offset: 0x0070C670
		private Vector3 PBEFMAGOEDF(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.OJCMBDNOEJI(IMPMMNPAHKJ.OHAEBKGAPBA(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 0f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB3D RID: 64317 RVA: 0x0070E4C0 File Offset: 0x0070C6C0
		public void NJJOPILNLJN()
		{
			this.MNDOOHAPKIO();
			this.INELKGAHFBJ(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.NOAMDLJMBKG().readRotation * Vector3.forward;
			this.locomotion.GMADDBOCLNF(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.FLNDNKEGJLB().readPosition;
		}

		// Token: 0x0600FB3E RID: 64318 RVA: 0x0070E544 File Offset: 0x0070C744
		private void FBHMDGCNCIO()
		{
			for (int i = 0; i < this.solverTransforms.Length; i += 0)
			{
				if (this.solverTransforms[i] != null)
				{
					if (i < 7)
					{
						this.solverTransforms[i].position = OOJJKBHKGNJ.IIAFGICFLIF(this.solverTransforms[i].position, this.HCHGGEHBIHB(i), this.IKPositionWeight);
					}
					this.solverTransforms[i].rotation = JEEPKFCFCLI.IIAFGICFLIF(this.solverTransforms[i].rotation, this.LAMKBHNKIGP(i), this.IKPositionWeight);
				}
			}
		}

		// Token: 0x0600FB3F RID: 64319 RVA: 0x0070E5D0 File Offset: 0x0070C7D0
		private Vector3 PMNLIEJEELM(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning("Assets/Weapons/" + DHPPKPKKJOF.name + "invn_rec5", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = 773f;
			int index = 0;
			for (int i = 1; i < DHPPKPKKJOF.childCount; i++)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.OAPMBKKENPK(IMPMMNPAHKJ.NCGIFFJIJJL(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 1268f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB40 RID: 64320 RVA: 0x0070E6C0 File Offset: 0x0070C8C0
		private Vector3 FMJHEKDDJHM(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.HHPKAKFOOCD(IMPMMNPAHKJ.OHAEBKGAPBA(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 1544f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB41 RID: 64321 RVA: 0x0070E710 File Offset: 0x0070C910
		private void CFLJGPIHEFI(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD)
		{
			if (this.rootBone == null)
			{
				this.MJABPMBIJNJ(new IKSolverVR.VirtualBone(FCJKGIPEIKP[0], MKEHLAMPPKB[0]));
			}
			else
			{
				this.MHCHBDNEHEM().NFIGHJJKDLL(FCJKGIPEIKP[0], MKEHLAMPPKB[0]);
			}
			this.spine.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, 0);
			this.leftArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 2, 7);
			this.rightArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 3, -46);
			this.leftLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, -113);
			this.rightLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 0, 34);
			for (int i = 1; i < MKEHLAMPPKB.Length; i += 0)
			{
				if (i < 4)
				{
					this.solvedPositions[i] = FCJKGIPEIKP[i];
				}
				this.solvedRotations[i] = MKEHLAMPPKB[i];
			}
			if (!base.initiated)
			{
				IKSolverVR.Leg[] array = new IKSolverVR.Leg[0];
				array[0] = this.leftLeg;
				array[1] = this.rightLeg;
				this.legs = array;
				IKSolverVR.Arm[] array2 = new IKSolverVR.Arm[8];
				array2[1] = this.leftArm;
				array2[1] = this.rightArm;
				this.arms = array2;
				this.locomotion.BHALELINNDJ(FCJKGIPEIKP, MKEHLAMPPKB, DCEANIANBOD);
				this.raycastOriginPelvis = this.spine.CNMJOEMADKJ().readPosition;
				this.spine.faceDirection = this.readRotations[1] * Vector3.forward;
			}
		}

		// Token: 0x0600FB42 RID: 64322 RVA: 0x0070E888 File Offset: 0x0070CA88
		public void JAFHPKNBOFF(IKSolverVR.PositionOffset EFNAALJNKKI, Vector3 DCCPCBLODIG)
		{
			switch (EFNAALJNKKI)
			{
			case IKSolverVR.PositionOffset.Pelvis:
				this.spine.pelvisPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Chest:
				this.spine.chestPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.Head:
				this.spine.headPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHand:
				this.leftArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHand:
				this.rightArm.handPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftFoot:
				this.leftLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightFoot:
				this.rightLeg.footPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.LeftHeel:
				this.leftLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			case IKSolverVR.PositionOffset.RightHeel:
				this.rightLeg.heelPositionOffset += DCCPCBLODIG;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FB43 RID: 64323 RVA: 0x0070E998 File Offset: 0x0070CB98
		private void INELKGAHFBJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD)
		{
			if (this.rootBone == null)
			{
				this.rootBone = new IKSolverVR.VirtualBone(FCJKGIPEIKP[0], MKEHLAMPPKB[0]);
			}
			else
			{
				this.rootBone.INELKGAHFBJ(FCJKGIPEIKP[0], MKEHLAMPPKB[0]);
			}
			this.spine.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 0, 1);
			this.leftArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 3, 6);
			this.rightArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 3, 10);
			this.leftLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, 14);
			this.rightLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, 18);
			for (int i = 0; i < MKEHLAMPPKB.Length; i++)
			{
				if (i < 2)
				{
					this.solvedPositions[i] = FCJKGIPEIKP[i];
				}
				this.solvedRotations[i] = MKEHLAMPPKB[i];
			}
			if (!base.initiated)
			{
				this.legs = new IKSolverVR.Leg[]
				{
					this.leftLeg,
					this.rightLeg
				};
				this.arms = new IKSolverVR.Arm[]
				{
					this.leftArm,
					this.rightArm
				};
				this.locomotion.BHALELINNDJ(FCJKGIPEIKP, MKEHLAMPPKB, DCEANIANBOD);
				this.raycastOriginPelvis = this.spine.pelvis.readPosition;
				this.spine.faceDirection = this.readRotations[0] * Vector3.forward;
			}
		}

		// Token: 0x0600FB44 RID: 64324 RVA: 0x0070EB10 File Offset: 0x0070CD10
		private Vector3 OKDEHKBHNKL(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			if (DHPPKPKKJOF.childCount == 0)
			{
				Debug.LogWarning("wplabel" + DHPPKPKKJOF.name + "_ALPHATEST_ON", DHPPKPKKJOF);
				return Vector3.zero;
			}
			float num = 343f;
			int index = 1;
			for (int i = 1; i < DHPPKPKKJOF.childCount; i += 0)
			{
				float num2 = Vector3.SqrMagnitude(DHPPKPKKJOF.GetChild(i).position - DHPPKPKKJOF.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(DHPPKPKKJOF.position - COPGFLKIMMH.position, DHPPKPKKJOF.GetChild(index).position - DHPPKPKKJOF.position), DHPPKPKKJOF.position - COPGFLKIMMH.position);
			Vector3 vector2 = IMPMMNPAHKJ.HBFIHBBKIEH(IMPMMNPAHKJ.DKELMDIPEDB(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) < 839f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB45 RID: 64325 RVA: 0x0070EC00 File Offset: 0x0070CE00
		public virtual bool DNIAGDMODBI(ref string EDAPHMJENPK)
		{
			if (this.solverTransforms == null || this.solverTransforms.Length == 0)
			{
				EDAPHMJENPK = "_BilateralUpsampling";
				return false;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "_Intensity";
				return false;
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "";
				return false;
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "Sitting 1 Leg Straight";
				return false;
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "error";
				return false;
			}
			return true;
		}

		// Token: 0x0600FB46 RID: 64326 RVA: 0x0070A657 File Offset: 0x00708857
		public void JCELNPEMJEC(IKSolverVR.RotationOffset JNHPAAAFGKC, Vector3 DCCPCBLODIG)
		{
			this.ONELMMCKEBK(JNHPAAAFGKC, Quaternion.Euler(DCCPCBLODIG));
		}

		// Token: 0x0600FB47 RID: 64327 RVA: 0x0070ECA8 File Offset: 0x0070CEA8
		public void CCDCCLMAMEE()
		{
			if (this.locomotion.stepHeight == null)
			{
				this.locomotion.stepHeight = new AnimationCurve();
			}
			if (this.locomotion.heelHeight == null)
			{
				this.locomotion.heelHeight = new AnimationCurve();
			}
			if (this.locomotion.stepHeight.keys.Length == 0)
			{
				this.locomotion.stepHeight.keys = IKSolverVR.BOAOFEDEIAF(0.03f);
			}
			if (this.locomotion.heelHeight.keys.Length == 0)
			{
				this.locomotion.heelHeight.keys = IKSolverVR.BOAOFEDEIAF(0.03f);
			}
		}

		// Token: 0x0600FB48 RID: 64328 RVA: 0x0070ED4C File Offset: 0x0070CF4C
		public void JJKMEFBJBMJ(IKSolverVR.RotationOffset JNHPAAAFGKC, Quaternion DCCPCBLODIG)
		{
			switch (JNHPAAAFGKC)
			{
			case IKSolverVR.RotationOffset.Pelvis:
				this.spine.pelvisRotationOffset = DCCPCBLODIG * this.spine.pelvisRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Chest:
				this.spine.chestRotationOffset = DCCPCBLODIG * this.spine.chestRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Head:
				this.spine.headRotationOffset = DCCPCBLODIG * this.spine.headRotationOffset;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FB49 RID: 64329 RVA: 0x0070EDC4 File Offset: 0x0070CFC4
		private Vector3 CIKKNHCAHLF(Transform[] AKBEGDIMBGM)
		{
			Vector3 vector = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			for (int i = 1; i < AKBEGDIMBGM.Length; i++)
			{
				vector2 += AKBEGDIMBGM[i].position;
			}
			vector2 /= (float)AKBEGDIMBGM.Length;
			for (int j = 0; j < AKBEGDIMBGM.Length - 1; j += 0)
			{
				vector += Vector3.Cross(AKBEGDIMBGM[j].position - vector2, AKBEGDIMBGM[j + 0].position - vector2).normalized;
			}
			return vector;
		}

		// Token: 0x0600FB4A RID: 64330 RVA: 0x0070EE4C File Offset: 0x0070D04C
		public virtual void BFCOAEFOGFF()
		{
			this.defaultPelvisLocalPosition = this.solverTransforms[0].localPosition;
			for (int i = 0; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.defaultLocalRotations[i - 0] = this.solverTransforms[i].localRotation;
				}
			}
		}

		// Token: 0x0600FB4B RID: 64331 RVA: 0x0070EEAC File Offset: 0x0070D0AC
		public void DHDKACLFOOI()
		{
			this.MNDOOHAPKIO();
			this.DLOGEDPELIF(this.readPositions, this.readRotations, this.hasNeck, this.hasShoulders, this.hasToes);
			this.spine.faceDirection = this.rootBone.readRotation * Vector3.forward;
			this.locomotion.GMADDBOCLNF(this.readPositions, this.readRotations);
			this.raycastOriginPelvis = this.spine.GBKKNIBPAIE().readPosition;
		}

		// Token: 0x0600FB4C RID: 64332 RVA: 0x0070EF30 File Offset: 0x0070D130
		public override void FGBCANJFNOC()
		{
			this.defaultPelvisLocalPosition = this.solverTransforms[1].localPosition;
			for (int i = 1; i < this.solverTransforms.Length; i++)
			{
				if (this.solverTransforms[i] != null)
				{
					this.defaultLocalRotations[i - 1] = this.solverTransforms[i].localRotation;
				}
			}
		}

		// Token: 0x0600FB4D RID: 64333 RVA: 0x0070EF8E File Offset: 0x0070D18E
		private Vector3 HCHGGEHBIHB(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE >= 7)
			{
				Debug.LogError("Z");
			}
			return this.solvedPositions[CLBPBJGLHEE];
		}

		// Token: 0x0600FB4E RID: 64334 RVA: 0x0070EFAC File Offset: 0x0070D1AC
		private static Keyframe[] BOAOFEDEIAF(float FEPAJPMAKID)
		{
			Keyframe[] array = new Keyframe[3];
			array[0].time = 0f;
			array[0].value = 0f;
			array[1].time = 0.5f;
			array[1].value = FEPAJPMAKID;
			array[2].time = 1f;
			array[2].value = 0f;
			return array;
		}

		// Token: 0x0600FB4F RID: 64335 RVA: 0x0070F024 File Offset: 0x0070D224
		private Vector3 JFNHFMCCDAA(Transform DHPPKPKKJOF, Transform COPGFLKIMMH)
		{
			Vector3 vector = COPGFLKIMMH.position - DHPPKPKKJOF.position;
			Vector3 vector2 = IMPMMNPAHKJ.HHPKAKFOOCD(IMPMMNPAHKJ.HADMCKICEMH(DHPPKPKKJOF, vector));
			if (Vector3.Dot(vector, DHPPKPKKJOF.rotation * vector2) > 1468f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		// Token: 0x0600FB50 RID: 64336 RVA: 0x0070F074 File Offset: 0x0070D274
		public virtual bool HKIAOHBMKJM(ref string EDAPHMJENPK)
		{
			if (this.solverTransforms == null || this.solverTransforms.Length == 0)
			{
				EDAPHMJENPK = "reputaion/fractions/fraction";
				return true;
			}
			if (this.leftArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "<color='#000000'>";
				return false;
			}
			if (this.rightArm.wristToPalmAxis == Vector3.zero)
			{
				EDAPHMJENPK = "WeaponRun";
				return true;
			}
			if (this.leftArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "_rcpFrameOpt";
				return true;
			}
			if (this.rightArm.palmToThumbAxis == Vector3.zero)
			{
				EDAPHMJENPK = "IdleSpew";
				return true;
			}
			return true;
		}

		// Token: 0x0600FB51 RID: 64337 RVA: 0x0070F11C File Offset: 0x0070D31C
		public void FFFBAMDDDJD(IKSolverVR.RotationOffset JNHPAAAFGKC, Quaternion DCCPCBLODIG)
		{
			switch (JNHPAAAFGKC)
			{
			case IKSolverVR.RotationOffset.Pelvis:
				this.spine.pelvisRotationOffset = DCCPCBLODIG * this.spine.pelvisRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Chest:
				this.spine.chestRotationOffset = DCCPCBLODIG * this.spine.chestRotationOffset;
				return;
			case IKSolverVR.RotationOffset.Head:
				this.spine.headRotationOffset = DCCPCBLODIG * this.spine.headRotationOffset;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FB52 RID: 64338 RVA: 0x0070F192 File Offset: 0x0070D392
		public virtual IKSolver.Point[] CONILHCEJAN()
		{
			Debug.LogError("_camHue");
			return null;
		}

		// Token: 0x0600FB53 RID: 64339 RVA: 0x0070AF02 File Offset: 0x00709102
		private Quaternion PLDAKKIJEJO(int CLBPBJGLHEE)
		{
			return this.solvedRotations[CLBPBJGLHEE];
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x0070F1A0 File Offset: 0x0070D3A0
		private Vector3 LKODCLNJKAE()
		{
			if (this.locomotion.weight <= 776f)
			{
				return Vector3.zero;
			}
			if (this.locomotion.blockingLayers == -1)
			{
				return Vector3.zero;
			}
			Vector3 vector = this.raycastOriginPelvis;
			vector.y = this.spine.pelvis.solverPosition.y;
			Vector3 vector2 = this.spine.LHOJGGKNONH().readPosition;
			vector2.y = this.spine.FLNDNKEGJLB().solverPosition.y;
			Vector3 direction = vector2 - vector;
			RaycastHit raycastHit;
			if (this.locomotion.raycastRadius <= 1589f)
			{
				if (Physics.Raycast(vector, direction, out raycastHit, direction.magnitude * 761f, this.locomotion.blockingLayers))
				{
					vector2 = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector, this.locomotion.raycastRadius * 762f, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				vector2 = vector + direction.normalized * raycastHit.distance / 175f;
			}
			Vector3 a = this.spine.LHOJGGKNONH().solverPosition;
			direction = a - vector2;
			if (this.locomotion.raycastRadius <= 1471f)
			{
				if (Physics.Raycast(vector2, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
				{
					a = raycastHit.point;
				}
			}
			else if (Physics.SphereCast(vector2, this.locomotion.raycastRadius, direction, out raycastHit, direction.magnitude, this.locomotion.blockingLayers))
			{
				a = vector2 + direction.normalized * raycastHit.distance;
			}
			this.lastOffset = Vector3.Lerp(this.lastOffset, Vector3.zero, Time.deltaTime * 1772f);
			a += Vector3.ClampMagnitude(this.lastOffset, 1054f);
			a.y = this.spine.LHOJGGKNONH().solverPosition.y;
			this.lastOffset = Vector3.Lerp(this.lastOffset, a - this.spine.GBKKNIBPAIE().solverPosition, Time.deltaTime * 1137f);
			return this.lastOffset;
		}

		// Token: 0x0600FB55 RID: 64341 RVA: 0x0070F404 File Offset: 0x0070D604
		private void NIMNABNPKFK(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD)
		{
			if (this.NOAMDLJMBKG() == null)
			{
				this.rootBone = new IKSolverVR.VirtualBone(FCJKGIPEIKP[1], MKEHLAMPPKB[1]);
			}
			else
			{
				this.rootBone.HCHNKNCJJEO(FCJKGIPEIKP[1], MKEHLAMPPKB[1]);
			}
			this.spine.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, 0);
			this.leftArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 3, 5);
			this.rightArm.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 6, 22);
			this.leftLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, -93);
			this.rightLeg.INELKGAHFBJ(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, 1, 50);
			for (int i = 0; i < MKEHLAMPPKB.Length; i += 0)
			{
				if (i < 8)
				{
					this.solvedPositions[i] = FCJKGIPEIKP[i];
				}
				this.solvedRotations[i] = MKEHLAMPPKB[i];
			}
			if (!base.initiated)
			{
				IKSolverVR.Leg[] array = new IKSolverVR.Leg[2];
				array[0] = this.leftLeg;
				array[0] = this.rightLeg;
				this.legs = array;
				IKSolverVR.Arm[] array2 = new IKSolverVR.Arm[8];
				array2[0] = this.leftArm;
				array2[0] = this.rightArm;
				this.arms = array2;
				this.locomotion.DCCMFHJNOML(FCJKGIPEIKP, MKEHLAMPPKB, DCEANIANBOD);
				this.raycastOriginPelvis = this.spine.GBKKNIBPAIE().readPosition;
				this.spine.faceDirection = this.readRotations[0] * Vector3.forward;
			}
		}

		// Token: 0x040020B3 RID: 8371
		private Transform[] solverTransforms = new Transform[0];

		// Token: 0x040020B4 RID: 8372
		private bool hasNeck;

		// Token: 0x040020B5 RID: 8373
		private bool hasShoulders;

		// Token: 0x040020B6 RID: 8374
		private bool hasToes;

		// Token: 0x040020B7 RID: 8375
		private Vector3[] readPositions = new Vector3[0];

		// Token: 0x040020B8 RID: 8376
		private Quaternion[] readRotations = new Quaternion[0];

		// Token: 0x040020B9 RID: 8377
		private Vector3[] solvedPositions = new Vector3[2];

		// Token: 0x040020BA RID: 8378
		private Quaternion[] solvedRotations = new Quaternion[22];

		// Token: 0x040020BB RID: 8379
		private Vector3 defaultPelvisLocalPosition;

		// Token: 0x040020BC RID: 8380
		private Quaternion[] defaultLocalRotations = new Quaternion[21];

		// Token: 0x040020BD RID: 8381
		private Vector3 rootV;

		// Token: 0x040020BE RID: 8382
		private Vector3 rootVelocity;

		// Token: 0x040020BF RID: 8383
		private Vector3 bodyOffset;

		// Token: 0x040020C0 RID: 8384
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet = true;

		// Token: 0x040020C2 RID: 8386
		[Tooltip("The spine solver.")]
		public IKSolverVR.Spine spine = new IKSolverVR.Spine();

		// Token: 0x040020C3 RID: 8387
		[Tooltip("The left arm solver.")]
		public IKSolverVR.Arm leftArm = new IKSolverVR.Arm();

		// Token: 0x040020C4 RID: 8388
		[Tooltip("The right arm solver.")]
		public IKSolverVR.Arm rightArm = new IKSolverVR.Arm();

		// Token: 0x040020C5 RID: 8389
		[Tooltip("The left leg solver.")]
		public IKSolverVR.Leg leftLeg = new IKSolverVR.Leg();

		// Token: 0x040020C6 RID: 8390
		[Tooltip("The right leg solver.")]
		public IKSolverVR.Leg rightLeg = new IKSolverVR.Leg();

		// Token: 0x040020C7 RID: 8391
		[Tooltip("The procedural locomotion solver.")]
		public IKSolverVR.Locomotion locomotion = new IKSolverVR.Locomotion();

		// Token: 0x040020C8 RID: 8392
		private IKSolverVR.Leg[] legs = new IKSolverVR.Leg[2];

		// Token: 0x040020C9 RID: 8393
		private IKSolverVR.Arm[] arms = new IKSolverVR.Arm[2];

		// Token: 0x040020CA RID: 8394
		private Vector3 headPosition;

		// Token: 0x040020CB RID: 8395
		private Vector3 headDeltaPosition;

		// Token: 0x040020CC RID: 8396
		private Vector3 raycastOriginPelvis;

		// Token: 0x040020CD RID: 8397
		private Vector3 lastOffset;

		// Token: 0x040020CE RID: 8398
		private Vector3 debugPos1;

		// Token: 0x040020CF RID: 8399
		private Vector3 debugPos2;

		// Token: 0x040020D0 RID: 8400
		private Vector3 debugPos3;

		// Token: 0x040020D1 RID: 8401
		private Vector3 debugPos4;

		// Token: 0x02000481 RID: 1153
		[Serializable]
		public class Arm : IKSolverVR.BodyPart
		{
			// Token: 0x0600FB56 RID: 64342 RVA: 0x0070F579 File Offset: 0x0070D779
			private void FGCGLHDGGCE(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB57 RID: 64343 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion BINOKHLONJJ()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FB58 RID: 64344 RVA: 0x0070F58A File Offset: 0x0070D78A
			public virtual void LKIBOPLMDPG()
			{
				this.MPDLLPMJGGO(this.HJLDBBHIGIC() + this.handPositionOffset);
			}

			// Token: 0x0600FB59 RID: 64345 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void PGOEEKLDMKM(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB5A RID: 64346 RVA: 0x0070F5CC File Offset: 0x0070D7CC
			public void JELGLJLDJBB(bool ICPIPOONLIB)
			{
				this.chestRotation = Quaternion.LookRotation(this.rootRotation * this.chestForwardAxis, this.rootRotation * this.chestUpAxis);
				this.chestForward = this.chestRotation * Vector3.forward;
				this.chestUp = this.chestRotation * Vector3.up;
				if (this.hasShoulder && this.shoulderRotationWeight > 302f)
				{
					IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode = this.shoulderRotationMode;
					if (shoulderRotationMode != IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
					{
						if (shoulderRotationMode == IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
						{
							Quaternion solverRotation = this.HKLAPNCDBDL().solverRotation;
							Quaternion quaternion = Quaternion.FromToRotation((this.CFJHKIEKIAJ().solverPosition - this.MAFEHMNGINB().solverPosition).normalized + this.chestForward, this.position - this.MAFEHMNGINB().solverPosition);
							quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, 1810f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.CAIABJGEMJH(this.bones, quaternion);
							IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 5, 6, this.KONANHEIJLG(), Vector3.Cross(this.forearm.solverPosition - this.shoulder.solverPosition, this.ECINPJIJMGK().solverPosition - this.MAFEHMNGINB().solverPosition), 272f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 5, 8, this.KONANHEIJLG(), this.EPMFGLPJLDE(this.KONANHEIJLG() - this.ODMOOGBEDDO().solverPosition), 1935f);
							Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(this.chestUp, this.chestForward));
							Vector3 vector = rotation * (solverRotation * this.PEDPJGKGEAE().axis);
							Vector3 vector2 = rotation * (this.shoulder.solverRotation * this.shoulder.axis);
							float current = Mathf.Atan2(vector.x, vector.z) * 1462f;
							float num = Mathf.Atan2(vector2.x, vector2.z) * 905f;
							float num2 = Mathf.DeltaAngle(current, num);
							if (ICPIPOONLIB)
							{
								num2 = -num2;
							}
							num2 = Mathf.Clamp(num2 * 630f, 1028f, 1736f);
							this.HKLAPNCDBDL().solverRotation = Quaternion.AngleAxis(num2, this.shoulder.solverRotation * (ICPIPOONLIB ? this.HKLAPNCDBDL().axis : (-this.MAFEHMNGINB().axis))) * this.HKLAPNCDBDL().solverRotation;
							this.CFJHKIEKIAJ().solverRotation = Quaternion.AngleAxis(num2, this.LLOACKDOKIF().solverRotation * (ICPIPOONLIB ? this.HLFAEEBCOAC().axis : (-this.NMGCKOGBNKK().axis))) * this.NCLJMCICLLD().solverRotation;
						}
					}
					else
					{
						Vector3 point = (this.MNGOALIMNCD() - this.MAFEHMNGINB().solverPosition).normalized;
						float num3 = ICPIPOONLIB ? 975f : 898f;
						Quaternion quaternion2 = Quaternion.AngleAxis((ICPIPOONLIB ? 1806f : 594f) + num3, this.chestUp) * this.chestRotation;
						Vector3 vector3 = Quaternion.Inverse(quaternion2) * point;
						float num4 = Mathf.Atan2(vector3.x, vector3.z) * 379f;
						float num5 = Vector3.Dot(vector3, Vector3.up);
						num5 = 1677f - Mathf.Abs(num5);
						num4 *= num5;
						num4 -= num3;
						num4 = this.PGDNKABDJME(num4, 131f - num3, 481f - num3, 260f);
						Quaternion rotation2 = Quaternion.AngleAxis(num4, Vector3.up);
						Vector3 fromDirection = Quaternion.Inverse(quaternion2) * (this.PEDPJGKGEAE().solverRotation * this.PEDPJGKGEAE().axis);
						Vector3 toDirection = rotation2 * Vector3.forward;
						Quaternion rhs = Quaternion.FromToRotation(fromDirection, toDirection);
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 1075f : 1792f, this.chestUp) * this.chestRotation;
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 1244f : 1737f, this.chestForward) * quaternion2;
						point = this.HJLDBBHIGIC() - (this.MAFEHMNGINB().solverPosition + this.chestRotation * (ICPIPOONLIB ? Vector3.right : Vector3.left) * base.mag);
						vector3 = Quaternion.Inverse(quaternion2) * point;
						float num6 = Mathf.Atan2(vector3.y, vector3.z) * 1199f;
						num6 -= 76f;
						num6 = this.KHGGELPLKNK(num6, 305f, 154f, 1504f);
						Quaternion quaternion3 = Quaternion.AngleAxis(-num6, quaternion2 * Vector3.right) * rhs;
						if (this.shoulderRotationWeight < 892f)
						{
							quaternion3 = Quaternion.Lerp(Quaternion.identity, quaternion3, this.shoulderRotationWeight);
						}
						IKSolverVR.VirtualBone.CAIABJGEMJH(this.bones, quaternion3);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 4, 0, this.HJLDBBHIGIC(), this.BMEMGEEFKCB(this.NCGDFBHLPEM() - this.FFADKNIMIAA().solverPosition), 189f);
						float angle = Mathf.Clamp(num6 * 1953f, 85f, 170f);
						this.HCIEAEDEGCG().solverRotation = Quaternion.AngleAxis(angle, this.HKLAPNCDBDL().solverRotation * (ICPIPOONLIB ? this.shoulder.axis : (-this.shoulder.axis))) * this.PEDPJGKGEAE().solverRotation;
						this.FFADKNIMIAA().solverRotation = Quaternion.AngleAxis(angle, this.LLOACKDOKIF().solverRotation * (ICPIPOONLIB ? this.KAHFPABHPKK().axis : (-this.CFJHKIEKIAJ().axis))) * this.CMHKCLCCPDD().solverRotation;
					}
				}
				else
				{
					IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 7, 3, this.LKCIGFAOHME(), this.JNMKIEOCFBJ(this.KPMHCDABDBG() - this.KAHFPABHPKK().solverPosition), 1921f);
				}
				Quaternion quaternion4 = this.NMGCKOGBNKK().solverRotation * this.forearmRelToUpperArm;
				Quaternion lhs = Quaternion.FromToRotation(quaternion4 * this.forearm.axis, this.PMDBINEJCGF().solverPosition - this.GECKPCOLKEA().solverPosition);
				base.BNJGCPDPPON(this.LNEANFIMHLF(), lhs * quaternion4, 1081f);
				this.NJGMNLHIKAG().solverRotation = this.FLONJLEBCFG();
			}

			// Token: 0x0600FB5B RID: 64347 RVA: 0x0070FCA4 File Offset: 0x0070DEA4
			private Vector3 EPMFGLPJLDE(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[1].solverPosition;
				}
				if (this.bendGoalWeight < 1483f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[1].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.rotation * this.wristToPalmAxis;
					vector2 -= this.FLONJLEBCFG() * this.palmToThumbAxis * 203f;
					if (this.bendGoalWeight > 1362f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 517f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x0600FBC3 RID: 64451 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			// (set) Token: 0x0600FB5C RID: 64348 RVA: 0x0070F579 File Offset: 0x0070D779
			public Vector3 position { get; private set; }

			// Token: 0x0600FB5D RID: 64349 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion FLONJLEBCFG()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FB5E RID: 64350 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone MAFEHMNGINB()
			{
				return this.bones[0];
			}

			// Token: 0x0600FB5F RID: 64351 RVA: 0x0070FE2C File Offset: 0x0070E02C
			public virtual void BKGHCGNEAOG(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.HCIEAEDEGCG().solverRotation;
				}
				KJAEHPCNAOM[this.index + 0] = this.CMHKCLCCPDD().solverRotation;
				KJAEHPCNAOM[this.index + 3] = this.MPIFLHBKAKL().solverRotation;
				KJAEHPCNAOM[this.index + 2] = this.PMDBINEJCGF().solverRotation;
			}

			// Token: 0x0600FB60 RID: 64352 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 HJLDBBHIGIC()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB61 RID: 64353 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone KAHFPABHPKK()
			{
				return this.bones[1];
			}

			// Token: 0x0600FB62 RID: 64354 RVA: 0x0070FEBC File Offset: 0x0070E0BC
			public virtual void COKOHBHJBIE()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.MPDLLPMJGGO(OOJJKBHKGNJ.IIAFGICFLIF(this.PDCNLCKKFDK().solverPosition, this.IKPosition, this.positionWeight));
				this.rotation = JEEPKFCFCLI.IIAFGICFLIF(this.hand.solverRotation, this.IKRotation, this.rotationWeight);
				this.PEDPJGKGEAE().axis = this.shoulder.axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.upperArm.solverRotation) * this.BOGCIPEPAFH().solverRotation;
			}

			// Token: 0x0600FB63 RID: 64355 RVA: 0x0070FF80 File Offset: 0x0070E180
			protected override void POOFNALOJAE(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 2];
				Quaternion phkiohibnpa3 = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 3];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				if (!this.initiated)
				{
					this.IKPosition = vector;
					this.IKRotation = quaternion;
					this.hasShoulder = CJCJIGDKDIP;
					this.bones = new IKSolverVR.VirtualBone[this.hasShoulder ? 4 : 3];
					if (this.hasShoulder)
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[2] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[3] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					else
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[2] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					this.chestForwardAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[0] * Vector3.forward);
					this.chestUpAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[0] * Vector3.up);
				}
				if (this.hasShoulder)
				{
					this.bones[0].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
					this.bones[1].INELKGAHFBJ(mgaleajogpl2, phkiohibnpa2);
					this.bones[2].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa3);
					this.bones[3].INELKGAHFBJ(vector, quaternion);
					return;
				}
				this.bones[0].INELKGAHFBJ(mgaleajogpl2, phkiohibnpa2);
				this.bones[1].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa3);
				this.bones[2].INELKGAHFBJ(vector, quaternion);
			}

			// Token: 0x0600FB64 RID: 64356 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 KPMHCDABDBG()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB65 RID: 64357 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone GECKPCOLKEA()
			{
				return this.bones[0];
			}

			// Token: 0x0600FB66 RID: 64358 RVA: 0x00710164 File Offset: 0x0070E364
			private float KIHOHJMAJBF(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 1252f)
				{
					float num2 = DAILMANBNMM - num * 1029f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 1407f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.MIFFONKAAHP(Mathf.Clamp(DCCPCBLODIG / num, 1884f, 861f), InterpolationMode.InElastic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FB67 RID: 64359 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion JKGLMCLPACI()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FB68 RID: 64360 RVA: 0x007101BF File Offset: 0x0070E3BF
			public override void DFPJKOLMGDE()
			{
				this.position += this.handPositionOffset;
			}

			// Token: 0x0600FB69 RID: 64361 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void GANLFLBCHLL(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB6A RID: 64362 RVA: 0x007101D8 File Offset: 0x0070E3D8
			public virtual void EIEHCCONOIG()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.position = OOJJKBHKGNJ.IIAFGICFLIF(this.JBPFDFIPPIA().solverPosition, this.IKPosition, this.positionWeight);
				this.KKIIGAKFIGM(JEEPKFCFCLI.IIAFGICFLIF(this.NJGMNLHIKAG().solverRotation, this.IKRotation, this.rotationWeight));
				this.HCIEAEDEGCG().axis = this.HCIEAEDEGCG().axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.ODMOOGBEDDO().solverRotation) * this.GECKPCOLKEA().solverRotation;
			}

			// Token: 0x0600FB6B RID: 64363 RVA: 0x0071029A File Offset: 0x0070E49A
			public virtual void EMMCJEBLCFE()
			{
				this.MMKECPOINPI(this.KONANHEIJLG() + this.handPositionOffset);
			}

			// Token: 0x0600FB6C RID: 64364 RVA: 0x007102B4 File Offset: 0x0070E4B4
			private Vector3 PCEGPNGDIEH(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 594f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[1].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.BCPJIEEIJKG() * this.wristToPalmAxis;
					vector2 -= this.BINOKHLONJJ() * this.palmToThumbAxis * 650f;
					if (this.bendGoalWeight > 42f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 1715f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FB6D RID: 64365 RVA: 0x00710434 File Offset: 0x0070E634
			public virtual void DDMFGCLHGMD(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.HKLAPNCDBDL().solverRotation;
				}
				KJAEHPCNAOM[this.index + 0] = this.HLFAEEBCOAC().solverRotation;
				KJAEHPCNAOM[this.index + 5] = this.MPIFLHBKAKL().solverRotation;
				KJAEHPCNAOM[this.index + 6] = this.JBPFDFIPPIA().solverRotation;
			}

			// Token: 0x0600FB6E RID: 64366 RVA: 0x007104AF File Offset: 0x0070E6AF
			private IKSolverVR.VirtualBone PMDBINEJCGF()
			{
				return this.bones[7];
			}

			// Token: 0x0600FB6F RID: 64367 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void LCOBDJCGPJA(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB70 RID: 64368 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void EDKPANKMKAN()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FB71 RID: 64369 RVA: 0x007104C6 File Offset: 0x0070E6C6
			public virtual void JPEPOIGBFBE()
			{
				this.MPDLLPMJGGO(this.KONANHEIJLG() + this.handPositionOffset);
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x0600FB8C RID: 64396 RVA: 0x0070F582 File Offset: 0x0070D782
			// (set) Token: 0x0600FB72 RID: 64370 RVA: 0x007104DF File Offset: 0x0070E6DF
			public Quaternion rotation { get; private set; }

			// Token: 0x0600FB73 RID: 64371 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone NCLJMCICLLD()
			{
				return this.bones[1];
			}

			// Token: 0x0600FB74 RID: 64372 RVA: 0x007104E8 File Offset: 0x0070E6E8
			private float PGDNKABDJME(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 735f)
				{
					float num2 = DAILMANBNMM - num * 1939f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 903f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NAKHKNJFPLK(Mathf.Clamp(DCCPCBLODIG / num, 1537f, 1556f), InterpolationMode.InOutSine);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FB75 RID: 64373 RVA: 0x00710543 File Offset: 0x0070E743
			private IKSolverVR.VirtualBone ENLFCLKAGFP()
			{
				return this.bones[4];
			}

			// Token: 0x0600FB76 RID: 64374 RVA: 0x0071054D File Offset: 0x0070E74D
			private IKSolverVR.VirtualBone JBPFDFIPPIA()
			{
				return this.bones[6];
			}

			// Token: 0x0600FB77 RID: 64375 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void FMICFBEPIHD(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB78 RID: 64376 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 MNGOALIMNCD()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB79 RID: 64377 RVA: 0x00710558 File Offset: 0x0070E758
			public virtual void EALLEBIHGJF(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.shoulder.solverRotation;
				}
				KJAEHPCNAOM[this.index + 1] = this.DBNNGDBODGO().solverRotation;
				KJAEHPCNAOM[this.index + 4] = this.forearm.solverRotation;
				KJAEHPCNAOM[this.index + 2] = this.FACLAPFOJJG().solverRotation;
			}

			// Token: 0x0600FB7A RID: 64378 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone PEDPJGKGEAE()
			{
				return this.bones[1];
			}

			// Token: 0x0600FB7B RID: 64379 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void KJMOLFPMMMD(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB7C RID: 64380 RVA: 0x007105D4 File Offset: 0x0070E7D4
			public void GLENLKEBCLI(bool ICPIPOONLIB)
			{
				this.chestRotation = Quaternion.LookRotation(this.rootRotation * this.chestForwardAxis, this.rootRotation * this.chestUpAxis);
				this.chestForward = this.chestRotation * Vector3.forward;
				this.chestUp = this.chestRotation * Vector3.up;
				if (this.hasShoulder && this.shoulderRotationWeight > 1975f)
				{
					IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode = this.shoulderRotationMode;
					if (shoulderRotationMode != IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
					{
						if (shoulderRotationMode == IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
						{
							Quaternion solverRotation = this.PEDPJGKGEAE().solverRotation;
							Quaternion quaternion = Quaternion.FromToRotation((this.HLFAEEBCOAC().solverPosition - this.MAFEHMNGINB().solverPosition).normalized + this.chestForward, this.KONANHEIJLG() - this.shoulder.solverPosition);
							quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, 1320f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.KABPPDHDKGD(this.bones, quaternion);
							IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 1, 7, this.NCGDFBHLPEM(), Vector3.Cross(this.forearm.solverPosition - this.PEDPJGKGEAE().solverPosition, this.ECINPJIJMGK().solverPosition - this.HCIEAEDEGCG().solverPosition), 1230f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 0, 6, 1, this.KPMHCDABDBG(), this.MFALMPLMGFD(this.MNGOALIMNCD() - this.NMGCKOGBNKK().solverPosition), 1295f);
							Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(this.chestUp, this.chestForward));
							Vector3 vector = rotation * (solverRotation * this.MAFEHMNGINB().axis);
							Vector3 vector2 = rotation * (this.HCIEAEDEGCG().solverRotation * this.HKLAPNCDBDL().axis);
							float current = Mathf.Atan2(vector.x, vector.z) * 721f;
							float num = Mathf.Atan2(vector2.x, vector2.z) * 825f;
							float num2 = Mathf.DeltaAngle(current, num);
							if (ICPIPOONLIB)
							{
								num2 = -num2;
							}
							num2 = Mathf.Clamp(num2 * 322f, 787f, 1143f);
							this.MAFEHMNGINB().solverRotation = Quaternion.AngleAxis(num2, this.shoulder.solverRotation * (ICPIPOONLIB ? this.MAFEHMNGINB().axis : (-this.HCIEAEDEGCG().axis))) * this.shoulder.solverRotation;
							this.CMHKCLCCPDD().solverRotation = Quaternion.AngleAxis(num2, this.CMHKCLCCPDD().solverRotation * (ICPIPOONLIB ? this.NMGCKOGBNKK().axis : (-this.CFJHKIEKIAJ().axis))) * this.DBNNGDBODGO().solverRotation;
						}
					}
					else
					{
						Vector3 point = (this.LKCIGFAOHME() - this.HCIEAEDEGCG().solverPosition).normalized;
						float num3 = ICPIPOONLIB ? 1840f : 54f;
						Quaternion quaternion2 = Quaternion.AngleAxis((ICPIPOONLIB ? 1476f : 1813f) + num3, this.chestUp) * this.chestRotation;
						Vector3 vector3 = Quaternion.Inverse(quaternion2) * point;
						float num4 = Mathf.Atan2(vector3.x, vector3.z) * 1533f;
						float num5 = Vector3.Dot(vector3, Vector3.up);
						num5 = 1494f - Mathf.Abs(num5);
						num4 *= num5;
						num4 -= num3;
						num4 = this.KHGGELPLKNK(num4, 1379f - num3, 497f - num3, 1946f);
						Quaternion rotation2 = Quaternion.AngleAxis(num4, Vector3.up);
						Vector3 fromDirection = Quaternion.Inverse(quaternion2) * (this.HCIEAEDEGCG().solverRotation * this.PEDPJGKGEAE().axis);
						Vector3 toDirection = rotation2 * Vector3.forward;
						Quaternion rhs = Quaternion.FromToRotation(fromDirection, toDirection);
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 358f : 465f, this.chestUp) * this.chestRotation;
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 187f : 268f, this.chestForward) * quaternion2;
						point = this.LKCIGFAOHME() - (this.PEDPJGKGEAE().solverPosition + this.chestRotation * (ICPIPOONLIB ? Vector3.right : Vector3.left) * base.mag);
						vector3 = Quaternion.Inverse(quaternion2) * point;
						float num6 = Mathf.Atan2(vector3.y, vector3.z) * 199f;
						num6 -= 258f;
						num6 = this.LCOIGGLBHCC(num6, 382f, 1044f, 1366f);
						Quaternion quaternion3 = Quaternion.AngleAxis(-num6, quaternion2 * Vector3.right) * rhs;
						if (this.shoulderRotationWeight < 1786f)
						{
							quaternion3 = Quaternion.Lerp(Quaternion.identity, quaternion3, this.shoulderRotationWeight);
						}
						IKSolverVR.VirtualBone.GKIBIBHIMOF(this.bones, quaternion3);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 8, 2, this.HJLDBBHIGIC(), this.MFALMPLMGFD(this.MNGOALIMNCD() - this.HLFAEEBCOAC().solverPosition), 389f);
						float angle = Mathf.Clamp(num6 * 1988f, 229f, 1341f);
						this.HKLAPNCDBDL().solverRotation = Quaternion.AngleAxis(angle, this.HCIEAEDEGCG().solverRotation * (ICPIPOONLIB ? this.shoulder.axis : (-this.shoulder.axis))) * this.HKLAPNCDBDL().solverRotation;
						this.ODMOOGBEDDO().solverRotation = Quaternion.AngleAxis(angle, this.HLFAEEBCOAC().solverRotation * (ICPIPOONLIB ? this.LLOACKDOKIF().axis : (-this.NMGCKOGBNKK().axis))) * this.HLFAEEBCOAC().solverRotation;
					}
				}
				else
				{
					IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 6, 5, this.position, this.MFALMPLMGFD(this.LKCIGFAOHME() - this.KAHFPABHPKK().solverPosition), 1578f);
				}
				Quaternion quaternion4 = this.KAHFPABHPKK().solverRotation * this.forearmRelToUpperArm;
				Quaternion lhs = Quaternion.FromToRotation(quaternion4 * this.forearm.axis, this.PMDBINEJCGF().solverPosition - this.ENLFCLKAGFP().solverPosition);
				base.BNJGCPDPPON(this.LNEANFIMHLF(), lhs * quaternion4, 1466f);
				this.FACLAPFOJJG().solverRotation = this.BINOKHLONJJ();
			}

			// Token: 0x0600FB7D RID: 64381 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void FGFGFKEJKPN(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB7E RID: 64382 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void NPLCNEIPIFK(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB7F RID: 64383 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone FFADKNIMIAA()
			{
				return this.bones[0];
			}

			// Token: 0x0600FB80 RID: 64384 RVA: 0x00710CAC File Offset: 0x0070EEAC
			private Vector3 JNMKIEOCFBJ(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 1f)
				{
					Vector3 vector = this.bones[0].solverRotation * this.bones[0].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.rotation * this.wristToPalmAxis;
					vector2 -= this.rotation * this.palmToThumbAxis * 0.5f;
					if (this.bendGoalWeight > 0f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 0f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FB81 RID: 64385 RVA: 0x00710E2C File Offset: 0x0070F02C
			private Vector3 BNIPDENBLLM(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 93f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[1].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.BLDKOFLCGPN() * this.wristToPalmAxis;
					vector2 -= this.JKGLMCLPACI() * this.palmToThumbAxis * 991f;
					if (this.bendGoalWeight > 1750f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 1539f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FB82 RID: 64386 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void PIHPINALNHG()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FB83 RID: 64387 RVA: 0x00710FAC File Offset: 0x0070F1AC
			public override void HJADALPNANN()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.position = OOJJKBHKGNJ.IIAFGICFLIF(this.hand.solverPosition, this.IKPosition, this.positionWeight);
				this.rotation = JEEPKFCFCLI.IIAFGICFLIF(this.hand.solverRotation, this.IKRotation, this.rotationWeight);
				this.shoulder.axis = this.shoulder.axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.upperArm.solverRotation) * this.forearm.solverRotation;
			}

			// Token: 0x0600FB84 RID: 64388 RVA: 0x00711070 File Offset: 0x0070F270
			public void EDAGNKNOBKP(bool ICPIPOONLIB)
			{
				this.chestRotation = Quaternion.LookRotation(this.rootRotation * this.chestForwardAxis, this.rootRotation * this.chestUpAxis);
				this.chestForward = this.chestRotation * Vector3.forward;
				this.chestUp = this.chestRotation * Vector3.up;
				if (this.hasShoulder && this.shoulderRotationWeight > 0f)
				{
					IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode = this.shoulderRotationMode;
					if (shoulderRotationMode != IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
					{
						if (shoulderRotationMode == IKSolverVR.Arm.ShoulderRotationMode.FromTo)
						{
							Quaternion solverRotation = this.shoulder.solverRotation;
							Quaternion quaternion = Quaternion.FromToRotation((this.upperArm.solverPosition - this.shoulder.solverPosition).normalized + this.chestForward, this.position - this.shoulder.solverPosition);
							quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, 0.5f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.OOLOKNPKMMG(this.bones, quaternion);
							IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 2, 3, this.position, Vector3.Cross(this.forearm.solverPosition - this.shoulder.solverPosition, this.hand.solverPosition - this.shoulder.solverPosition), 0.5f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 2, 3, this.position, this.JNMKIEOCFBJ(this.position - this.upperArm.solverPosition), 1f);
							Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(this.chestUp, this.chestForward));
							Vector3 vector = rotation * (solverRotation * this.shoulder.axis);
							Vector3 vector2 = rotation * (this.shoulder.solverRotation * this.shoulder.axis);
							float current = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
							float num = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f;
							float num2 = Mathf.DeltaAngle(current, num);
							if (ICPIPOONLIB)
							{
								num2 = -num2;
							}
							num2 = Mathf.Clamp(num2 * 2f, 0f, 180f);
							this.shoulder.solverRotation = Quaternion.AngleAxis(num2, this.shoulder.solverRotation * (ICPIPOONLIB ? this.shoulder.axis : (-this.shoulder.axis))) * this.shoulder.solverRotation;
							this.upperArm.solverRotation = Quaternion.AngleAxis(num2, this.upperArm.solverRotation * (ICPIPOONLIB ? this.upperArm.axis : (-this.upperArm.axis))) * this.upperArm.solverRotation;
						}
					}
					else
					{
						Vector3 point = (this.position - this.shoulder.solverPosition).normalized;
						float num3 = ICPIPOONLIB ? 45f : -45f;
						Quaternion quaternion2 = Quaternion.AngleAxis((ICPIPOONLIB ? -90f : 90f) + num3, this.chestUp) * this.chestRotation;
						Vector3 vector3 = Quaternion.Inverse(quaternion2) * point;
						float num4 = Mathf.Atan2(vector3.x, vector3.z) * 57.29578f;
						float num5 = Vector3.Dot(vector3, Vector3.up);
						num5 = 1f - Mathf.Abs(num5);
						num4 *= num5;
						num4 -= num3;
						num4 = this.LCOIGGLBHCC(num4, -45f - num3, 45f - num3, 0.7f);
						Quaternion rotation2 = Quaternion.AngleAxis(num4, Vector3.up);
						Vector3 fromDirection = Quaternion.Inverse(quaternion2) * (this.shoulder.solverRotation * this.shoulder.axis);
						Vector3 toDirection = rotation2 * Vector3.forward;
						Quaternion rhs = Quaternion.FromToRotation(fromDirection, toDirection);
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? -90f : 90f, this.chestUp) * this.chestRotation;
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? -30f : 30f, this.chestForward) * quaternion2;
						point = this.position - (this.shoulder.solverPosition + this.chestRotation * (ICPIPOONLIB ? Vector3.right : Vector3.left) * base.mag);
						vector3 = Quaternion.Inverse(quaternion2) * point;
						float num6 = Mathf.Atan2(vector3.y, vector3.z) * 57.29578f;
						num6 -= -30f;
						num6 = this.LCOIGGLBHCC(num6, -15f, 75f, 1f);
						Quaternion quaternion3 = Quaternion.AngleAxis(-num6, quaternion2 * Vector3.right) * rhs;
						if (this.shoulderRotationWeight < 1f)
						{
							quaternion3 = Quaternion.Lerp(Quaternion.identity, quaternion3, this.shoulderRotationWeight);
						}
						IKSolverVR.VirtualBone.OOLOKNPKMMG(this.bones, quaternion3);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 2, 3, this.position, this.JNMKIEOCFBJ(this.position - this.upperArm.solverPosition), 1f);
						float angle = Mathf.Clamp(num6 * 2f, 0f, 180f);
						this.shoulder.solverRotation = Quaternion.AngleAxis(angle, this.shoulder.solverRotation * (ICPIPOONLIB ? this.shoulder.axis : (-this.shoulder.axis))) * this.shoulder.solverRotation;
						this.upperArm.solverRotation = Quaternion.AngleAxis(angle, this.upperArm.solverRotation * (ICPIPOONLIB ? this.upperArm.axis : (-this.upperArm.axis))) * this.upperArm.solverRotation;
					}
				}
				else
				{
					IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 2, 3, this.position, this.JNMKIEOCFBJ(this.position - this.upperArm.solverPosition), 1f);
				}
				Quaternion quaternion4 = this.upperArm.solverRotation * this.forearmRelToUpperArm;
				Quaternion lhs = Quaternion.FromToRotation(quaternion4 * this.forearm.axis, this.hand.solverPosition - this.forearm.solverPosition);
				base.BNJGCPDPPON(this.forearm, lhs * quaternion4, 1f);
				this.hand.solverRotation = this.rotation;
			}

			// Token: 0x0600FB85 RID: 64389 RVA: 0x00711748 File Offset: 0x0070F948
			public virtual void EIGOCJHJMLG(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.HKLAPNCDBDL().solverRotation;
				}
				KJAEHPCNAOM[this.index + 0] = this.NMGCKOGBNKK().solverRotation;
				KJAEHPCNAOM[this.index + 7] = this.GECKPCOLKEA().solverRotation;
				KJAEHPCNAOM[this.index + 7] = this.PDCNLCKKFDK().solverRotation;
			}

			// Token: 0x0600FB86 RID: 64390 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone DBNNGDBODGO()
			{
				return this.bones[1];
			}

			// Token: 0x0600FB87 RID: 64391 RVA: 0x007117C4 File Offset: 0x0070F9C4
			public virtual void MLKFHFPDALD()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.position = OOJJKBHKGNJ.IIAFGICFLIF(this.hand.solverPosition, this.IKPosition, this.positionWeight);
				this.MLHBBKPONAP(JEEPKFCFCLI.IIAFGICFLIF(this.PMDBINEJCGF().solverRotation, this.IKRotation, this.rotationWeight));
				this.HKLAPNCDBDL().axis = this.shoulder.axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.LLOACKDOKIF().solverRotation) * this.MPIFLHBKAKL().solverRotation;
			}

			// Token: 0x0600FB88 RID: 64392 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void LFNOKKJDADA()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FB89 RID: 64393 RVA: 0x0070F579 File Offset: 0x0070D779
			private void MADPCLFHLIG(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB8A RID: 64394 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void BFMLNKBAGHJ(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FB8D RID: 64397 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 NCGDFBHLPEM()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB8E RID: 64398 RVA: 0x007118E8 File Offset: 0x0070FAE8
			private float MBDIOKHJNOD(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 379f)
				{
					float num2 = DAILMANBNMM - num * 891f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 432f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NAKHKNJFPLK(Mathf.Clamp(DCCPCBLODIG / num, 467f, 811f), InterpolationMode.InQuintic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FB8F RID: 64399 RVA: 0x00711944 File Offset: 0x0070FB44
			private Vector3 DMGGACPNLAA(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 427f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[0].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.rotation * this.wristToPalmAxis;
					vector2 -= this.JKGLMCLPACI() * this.palmToThumbAxis * 1143f;
					if (this.bendGoalWeight > 1749f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 512f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FB90 RID: 64400 RVA: 0x00711AC4 File Offset: 0x0070FCC4
			protected virtual void FCMPOJNHLIN(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa3 = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 8];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 7];
				if (!this.initiated)
				{
					this.IKPosition = vector;
					this.IKRotation = quaternion;
					this.hasShoulder = CJCJIGDKDIP;
					this.bones = new IKSolverVR.VirtualBone[this.hasShoulder ? 8 : 1];
					if (this.hasShoulder)
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[4] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[4] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					else
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[3] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					this.chestForwardAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[1] * Vector3.forward);
					this.chestUpAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[1] * Vector3.up);
				}
				if (this.hasShoulder)
				{
					this.bones[0].APAEBLFHDBL(mgaleajogpl, phkiohibnpa);
					this.bones[1].NFIGHJJKDLL(mgaleajogpl2, phkiohibnpa2);
					this.bones[2].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa3);
					this.bones[2].APAEBLFHDBL(vector, quaternion);
					return;
				}
				this.bones[1].APAEBLFHDBL(mgaleajogpl2, phkiohibnpa2);
				this.bones[0].NFIGHJJKDLL(mgaleajogpl3, phkiohibnpa3);
				this.bones[2].HCHNKNCJJEO(vector, quaternion);
			}

			// Token: 0x0600FB91 RID: 64401 RVA: 0x00711CA6 File Offset: 0x0070FEA6
			private IKSolverVR.VirtualBone MPIFLHBKAKL()
			{
				return this.bones[5];
			}

			// Token: 0x0600FB92 RID: 64402 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 KONANHEIJLG()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB93 RID: 64403 RVA: 0x00711CB0 File Offset: 0x0070FEB0
			private IKSolverVR.VirtualBone BOGCIPEPAFH()
			{
				return this.bones[2];
			}

			// Token: 0x0600FB94 RID: 64404 RVA: 0x0070F579 File Offset: 0x0070D779
			private void JKFBBKMEDHP(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x0600FB95 RID: 64405 RVA: 0x00711CB0 File Offset: 0x0070FEB0
			private IKSolverVR.VirtualBone forearm
			{
				get
				{
					return this.bones[2];
				}
			}

			// Token: 0x0600FB96 RID: 64406 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 LKCIGFAOHME()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FB97 RID: 64407 RVA: 0x0070F579 File Offset: 0x0070D779
			private void MPDLLPMJGGO(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB98 RID: 64408 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone HCIEAEDEGCG()
			{
				return this.bones[0];
			}

			// Token: 0x0600FB99 RID: 64409 RVA: 0x0070F579 File Offset: 0x0070D779
			private void NJGFMMFJBHG(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FB9A RID: 64410 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void BCAOFCLPALN()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FB9B RID: 64411 RVA: 0x00711CBA File Offset: 0x0070FEBA
			public virtual void PDKACPMDELJ()
			{
				this.NJGFMMFJBHG(this.MNGOALIMNCD() + this.handPositionOffset);
			}

			// Token: 0x0600FB9C RID: 64412 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion PHHJNECNDNO()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FB9D RID: 64413 RVA: 0x00711CD4 File Offset: 0x0070FED4
			public virtual void EHBFKIPIMOB()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.FGCGLHDGGCE(OOJJKBHKGNJ.IIAFGICFLIF(this.FACLAPFOJJG().solverPosition, this.IKPosition, this.positionWeight));
				this.KKIIGAKFIGM(JEEPKFCFCLI.IIAFGICFLIF(this.hand.solverRotation, this.IKRotation, this.rotationWeight));
				this.PEDPJGKGEAE().axis = this.HCIEAEDEGCG().axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.HLFAEEBCOAC().solverRotation) * this.MPIFLHBKAKL().solverRotation;
			}

			// Token: 0x0600FB9E RID: 64414 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone ODMOOGBEDDO()
			{
				return this.bones[1];
			}

			// Token: 0x0600FB9F RID: 64415 RVA: 0x00711D98 File Offset: 0x0070FF98
			private float LCOIGGLBHCC(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 1f)
				{
					float num2 = DAILMANBNMM - num * 0.5f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 0.5f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NAKHKNJFPLK(Mathf.Clamp(DCCPCBLODIG / num, 0f, 1f), InterpolationMode.InOutQuintic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FBA0 RID: 64416 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void BIDPMFAJOJL()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBA1 RID: 64417 RVA: 0x00711DF4 File Offset: 0x0070FFF4
			private Vector3 BMEMGEEFKCB(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 1843f)
				{
					Vector3 vector = this.bones[0].solverRotation * this.bones[0].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.BCPJIEEIJKG() * this.wristToPalmAxis;
					vector2 -= this.FLONJLEBCFG() * this.palmToThumbAxis * 1592f;
					if (this.bendGoalWeight > 1208f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 880f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FBA2 RID: 64418 RVA: 0x00711F74 File Offset: 0x00710174
			private Vector3 MFALMPLMGFD(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[1].solverPosition;
				}
				if (this.bendGoalWeight < 1984f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[0].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.BCPJIEEIJKG() * this.wristToPalmAxis;
					vector2 -= this.PHHJNECNDNO() * this.palmToThumbAxis * 1137f;
					if (this.bendGoalWeight > 731f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 1207f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FBA3 RID: 64419 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone LLOACKDOKIF()
			{
				return this.bones[0];
			}

			// Token: 0x0600FBA4 RID: 64420 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone CMHKCLCCPDD()
			{
				return this.bones[1];
			}

			// Token: 0x0600FBA5 RID: 64421 RVA: 0x007120F4 File Offset: 0x007102F4
			private float CMNLADFAAID(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 1771f)
				{
					float num2 = DAILMANBNMM - num * 1518f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 628f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NFBGBNIPMFF(Mathf.Clamp(DCCPCBLODIG / num, 1696f, 62f), InterpolationMode.InElastic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FBA6 RID: 64422 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void FFGDJFFMFFP(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBA7 RID: 64423 RVA: 0x00712150 File Offset: 0x00710350
			protected virtual void NECAKJFGAJA(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion phkiohibnpa3 = MKEHLAMPPKB[CLBPBJGLHEE + 8];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 8];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 6];
				if (!this.initiated)
				{
					this.IKPosition = vector;
					this.IKRotation = quaternion;
					this.hasShoulder = CJCJIGDKDIP;
					this.bones = new IKSolverVR.VirtualBone[this.hasShoulder ? 2 : 4];
					if (this.hasShoulder)
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[5] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[5] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					else
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[0] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					this.chestForwardAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[0] * Vector3.forward);
					this.chestUpAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[0] * Vector3.up);
				}
				if (this.hasShoulder)
				{
					this.bones[1].APAEBLFHDBL(mgaleajogpl, phkiohibnpa);
					this.bones[1].HCHNKNCJJEO(mgaleajogpl2, phkiohibnpa2);
					this.bones[0].APAEBLFHDBL(mgaleajogpl3, phkiohibnpa3);
					this.bones[7].NFIGHJJKDLL(vector, quaternion);
					return;
				}
				this.bones[0].NFIGHJJKDLL(mgaleajogpl2, phkiohibnpa2);
				this.bones[0].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa3);
				this.bones[3].HCHNKNCJJEO(vector, quaternion);
			}

			// Token: 0x0600FBA8 RID: 64424 RVA: 0x00712334 File Offset: 0x00710534
			public override void GJJCGAEBILD(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.shoulder.solverRotation;
				}
				KJAEHPCNAOM[this.index + 1] = this.upperArm.solverRotation;
				KJAEHPCNAOM[this.index + 2] = this.forearm.solverRotation;
				KJAEHPCNAOM[this.index + 3] = this.hand.solverRotation;
			}

			// Token: 0x0600FBA9 RID: 64425 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion BLDKOFLCGPN()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FBAA RID: 64426 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone NMGCKOGBNKK()
			{
				return this.bones[1];
			}

			// Token: 0x0600FBAB RID: 64427 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone HKLAPNCDBDL()
			{
				return this.bones[1];
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x0600FBAC RID: 64428 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone upperArm
			{
				get
				{
					return this.bones[1];
				}
			}

			// Token: 0x0600FBAD RID: 64429 RVA: 0x0070F579 File Offset: 0x0070D779
			private void MMKECPOINPI(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBAE RID: 64430 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void OPNJOLOJLNF(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBAF RID: 64431 RVA: 0x007123B0 File Offset: 0x007105B0
			public virtual void MBFCNEHCDNF()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.FGCGLHDGGCE(OOJJKBHKGNJ.IIAFGICFLIF(this.PDCNLCKKFDK().solverPosition, this.IKPosition, this.positionWeight));
				this.HJJADMNKPCI(JEEPKFCFCLI.IIAFGICFLIF(this.ECINPJIJMGK().solverRotation, this.IKRotation, this.rotationWeight));
				this.PEDPJGKGEAE().axis = this.HKLAPNCDBDL().axis.normalized;
				this.forearmRelToUpperArm = Quaternion.Inverse(this.DBNNGDBODGO().solverRotation) * this.LNEANFIMHLF().solverRotation;
			}

			// Token: 0x0600FBB0 RID: 64432 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void CGBAJKPHCFN()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBB1 RID: 64433 RVA: 0x0071054D File Offset: 0x0070E74D
			private IKSolverVR.VirtualBone FACLAPFOJJG()
			{
				return this.bones[6];
			}

			// Token: 0x0600FBB2 RID: 64434 RVA: 0x00712472 File Offset: 0x00710672
			public virtual void HGAHOECLLDG()
			{
				this.position = this.MNGOALIMNCD() + this.handPositionOffset;
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x0600FBB3 RID: 64435 RVA: 0x0071248B File Offset: 0x0071068B
			private IKSolverVR.VirtualBone hand
			{
				get
				{
					return this.bones[3];
				}
			}

			// Token: 0x0600FBB4 RID: 64436 RVA: 0x00712498 File Offset: 0x00710698
			private float PAOABCDLCAP(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 208f)
				{
					float num2 = DAILMANBNMM - num * 1866f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 1023f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.MIFFONKAAHP(Mathf.Clamp(DCCPCBLODIG / num, 1175f, 811f), InterpolationMode.InCubic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FBB5 RID: 64437 RVA: 0x007124F4 File Offset: 0x007106F4
			private Vector3 DPLLNGODILN(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[1].solverPosition;
				}
				if (this.bendGoalWeight < 1235f)
				{
					Vector3 vector = this.bones[0].solverRotation * this.bones[1].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.JJOLHKMFBMG() * this.wristToPalmAxis;
					vector2 -= this.PHHJNECNDNO() * this.palmToThumbAxis * 640f;
					if (this.bendGoalWeight > 1548f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 820f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FBB6 RID: 64438 RVA: 0x0071054D File Offset: 0x0070E74D
			private IKSolverVR.VirtualBone LNEANFIMHLF()
			{
				return this.bones[6];
			}

			// Token: 0x0600FBB7 RID: 64439 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public override void KJPOIAKPAGJ()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBB8 RID: 64440 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void OLENKBFECPO(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBB9 RID: 64441 RVA: 0x00712672 File Offset: 0x00710872
			private IKSolverVR.VirtualBone IMPADCLFMDF()
			{
				return this.bones[8];
			}

			// Token: 0x0600FBBA RID: 64442 RVA: 0x0071248B File Offset: 0x0071068B
			private IKSolverVR.VirtualBone PDCNLCKKFDK()
			{
				return this.bones[3];
			}

			// Token: 0x0600FBBB RID: 64443 RVA: 0x0071267C File Offset: 0x0071087C
			public virtual void JHECMDGAEDH(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.shoulder.solverRotation;
				}
				KJAEHPCNAOM[this.index + 0] = this.DBNNGDBODGO().solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.LNEANFIMHLF().solverRotation;
				KJAEHPCNAOM[this.index + 6] = this.FACLAPFOJJG().solverRotation;
			}

			// Token: 0x0600FBBC RID: 64444 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void LMGCHKBIHFG()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBBD RID: 64445 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion DJECMJCAMIN()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FBBE RID: 64446 RVA: 0x007104AF File Offset: 0x0070E6AF
			private IKSolverVR.VirtualBone NJGMNLHIKAG()
			{
				return this.bones[7];
			}

			// Token: 0x0600FBBF RID: 64447 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone HLFAEEBCOAC()
			{
				return this.bones[0];
			}

			// Token: 0x0600FBC0 RID: 64448 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void ONIKFIKPIHP(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBC1 RID: 64449 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void MLHBBKPONAP(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBC2 RID: 64450 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion BCPJIEEIJKG()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FBC4 RID: 64452 RVA: 0x0070F579 File Offset: 0x0070D779
			private void DNDEEBNMOHH(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBC5 RID: 64453 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void HJJADMNKPCI(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBC6 RID: 64454 RVA: 0x007126F8 File Offset: 0x007108F8
			public virtual void FELKNEIPGHI(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.HKLAPNCDBDL().solverRotation;
				}
				KJAEHPCNAOM[this.index + 1] = this.FFADKNIMIAA().solverRotation;
				KJAEHPCNAOM[this.index + 5] = this.MPIFLHBKAKL().solverRotation;
				KJAEHPCNAOM[this.index + 7] = this.ECINPJIJMGK().solverRotation;
			}

			// Token: 0x0600FBC7 RID: 64455 RVA: 0x00712774 File Offset: 0x00710974
			private Vector3 CEDEKBOKDLJ(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[1].solverPosition;
				}
				if (this.bendGoalWeight < 191f)
				{
					Vector3 vector = this.bones[0].solverRotation * this.bones[1].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.FLONJLEBCFG() * this.wristToPalmAxis;
					vector2 -= this.BINOKHLONJJ() * this.palmToThumbAxis * 117f;
					if (this.bendGoalWeight > 326f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 1234f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x0600FBC8 RID: 64456 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone shoulder
			{
				get
				{
					return this.bones[0];
				}
			}

			// Token: 0x0600FBC9 RID: 64457 RVA: 0x007128F4 File Offset: 0x00710AF4
			private float KHGGELPLKNK(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 1917f)
				{
					float num2 = DAILMANBNMM - num * 1183f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 1654f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NFBGBNIPMFF(Mathf.Clamp(DCCPCBLODIG / num, 1559f, 1586f), InterpolationMode.InCubic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FBCA RID: 64458 RVA: 0x0071294F File Offset: 0x00710B4F
			public virtual void AHHHKMHBFBF()
			{
				this.FGCGLHDGGCE(this.NCGDFBHLPEM() + this.handPositionOffset);
			}

			// Token: 0x0600FBCB RID: 64459 RVA: 0x00712968 File Offset: 0x00710B68
			public void BMHJGHNJLCL(bool ICPIPOONLIB)
			{
				this.chestRotation = Quaternion.LookRotation(this.rootRotation * this.chestForwardAxis, this.rootRotation * this.chestUpAxis);
				this.chestForward = this.chestRotation * Vector3.forward;
				this.chestUp = this.chestRotation * Vector3.up;
				if (this.hasShoulder && this.shoulderRotationWeight > 811f)
				{
					IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode = this.shoulderRotationMode;
					if (shoulderRotationMode != IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
					{
						if (shoulderRotationMode == IKSolverVR.Arm.ShoulderRotationMode.YawPitch)
						{
							Quaternion solverRotation = this.shoulder.solverRotation;
							Quaternion quaternion = Quaternion.FromToRotation((this.FFADKNIMIAA().solverPosition - this.HKLAPNCDBDL().solverPosition).normalized + this.chestForward, this.position - this.PEDPJGKGEAE().solverPosition);
							quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, 1982f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.OOLOKNPKMMG(this.bones, quaternion);
							IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 1, 4, 7, this.KONANHEIJLG(), Vector3.Cross(this.ENLFCLKAGFP().solverPosition - this.shoulder.solverPosition, this.PDCNLCKKFDK().solverPosition - this.HKLAPNCDBDL().solverPosition), 90f * this.shoulderRotationWeight);
							IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 2, 5, this.MNGOALIMNCD(), this.PCEGPNGDIEH(this.FNMPICJAGJM() - this.HLFAEEBCOAC().solverPosition), 1012f);
							Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(this.chestUp, this.chestForward));
							Vector3 vector = rotation * (solverRotation * this.PEDPJGKGEAE().axis);
							Vector3 vector2 = rotation * (this.shoulder.solverRotation * this.shoulder.axis);
							float current = Mathf.Atan2(vector.x, vector.z) * 755f;
							float num = Mathf.Atan2(vector2.x, vector2.z) * 337f;
							float num2 = Mathf.DeltaAngle(current, num);
							if (ICPIPOONLIB)
							{
								num2 = -num2;
							}
							num2 = Mathf.Clamp(num2 * 145f, 347f, 1411f);
							this.shoulder.solverRotation = Quaternion.AngleAxis(num2, this.HKLAPNCDBDL().solverRotation * (ICPIPOONLIB ? this.PEDPJGKGEAE().axis : (-this.PEDPJGKGEAE().axis))) * this.HKLAPNCDBDL().solverRotation;
							this.upperArm.solverRotation = Quaternion.AngleAxis(num2, this.upperArm.solverRotation * (ICPIPOONLIB ? this.KAHFPABHPKK().axis : (-this.upperArm.axis))) * this.NCLJMCICLLD().solverRotation;
						}
					}
					else
					{
						Vector3 point = (this.MNGOALIMNCD() - this.shoulder.solverPosition).normalized;
						float num3 = ICPIPOONLIB ? 1435f : 234f;
						Quaternion quaternion2 = Quaternion.AngleAxis((ICPIPOONLIB ? 1242f : 1837f) + num3, this.chestUp) * this.chestRotation;
						Vector3 vector3 = Quaternion.Inverse(quaternion2) * point;
						float num4 = Mathf.Atan2(vector3.x, vector3.z) * 1770f;
						float num5 = Vector3.Dot(vector3, Vector3.up);
						num5 = 914f - Mathf.Abs(num5);
						num4 *= num5;
						num4 -= num3;
						num4 = this.LCOIGGLBHCC(num4, 1057f - num3, 1012f - num3, 1418f);
						Quaternion rotation2 = Quaternion.AngleAxis(num4, Vector3.up);
						Vector3 fromDirection = Quaternion.Inverse(quaternion2) * (this.HKLAPNCDBDL().solverRotation * this.HKLAPNCDBDL().axis);
						Vector3 toDirection = rotation2 * Vector3.forward;
						Quaternion rhs = Quaternion.FromToRotation(fromDirection, toDirection);
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 1752f : 1862f, this.chestUp) * this.chestRotation;
						quaternion2 = Quaternion.AngleAxis(ICPIPOONLIB ? 1000f : 1269f, this.chestForward) * quaternion2;
						point = this.NCGDFBHLPEM() - (this.PEDPJGKGEAE().solverPosition + this.chestRotation * (ICPIPOONLIB ? Vector3.right : Vector3.left) * base.mag);
						vector3 = Quaternion.Inverse(quaternion2) * point;
						float num6 = Mathf.Atan2(vector3.y, vector3.z) * 1075f;
						num6 -= 596f;
						num6 = this.MBDIOKHJNOD(num6, 969f, 47f, 1404f);
						Quaternion quaternion3 = Quaternion.AngleAxis(-num6, quaternion2 * Vector3.right) * rhs;
						if (this.shoulderRotationWeight < 876f)
						{
							quaternion3 = Quaternion.Lerp(Quaternion.identity, quaternion3, this.shoulderRotationWeight);
						}
						IKSolverVR.VirtualBone.OOLOKNPKMMG(this.bones, quaternion3);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 7, 5, this.KPMHCDABDBG(), this.BMEMGEEFKCB(this.MNGOALIMNCD() - this.upperArm.solverPosition), 1966f);
						float angle = Mathf.Clamp(num6 * 579f, 1212f, 1052f);
						this.HKLAPNCDBDL().solverRotation = Quaternion.AngleAxis(angle, this.shoulder.solverRotation * (ICPIPOONLIB ? this.HKLAPNCDBDL().axis : (-this.MAFEHMNGINB().axis))) * this.shoulder.solverRotation;
						this.HLFAEEBCOAC().solverRotation = Quaternion.AngleAxis(angle, this.NCLJMCICLLD().solverRotation * (ICPIPOONLIB ? this.CFJHKIEKIAJ().axis : (-this.upperArm.axis))) * this.DBNNGDBODGO().solverRotation;
					}
				}
				else
				{
					IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 0, 3, 5, this.position, this.CEDEKBOKDLJ(this.MNGOALIMNCD() - this.KAHFPABHPKK().solverPosition), 77f);
				}
				Quaternion quaternion4 = this.CFJHKIEKIAJ().solverRotation * this.forearmRelToUpperArm;
				Quaternion lhs = Quaternion.FromToRotation(quaternion4 * this.LNEANFIMHLF().axis, this.JBPFDFIPPIA().solverPosition - this.MPIFLHBKAKL().solverPosition);
				base.BNJGCPDPPON(this.forearm, lhs * quaternion4, 1150f);
				this.ECINPJIJMGK().solverRotation = this.JKGLMCLPACI();
			}

			// Token: 0x0600FBCC RID: 64460 RVA: 0x0070FEA7 File Offset: 0x0070E0A7
			public Vector3 FNMPICJAGJM()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FBCD RID: 64461 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void CHLJPHGNHDO(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBCE RID: 64462 RVA: 0x00713040 File Offset: 0x00711240
			private Vector3 LKBDCAKHEPA(Vector3 GMDCCFLLCJA)
			{
				if (this.bendGoal != null)
				{
					this.bendDirection = this.bendGoal.position - this.bones[0].solverPosition;
				}
				if (this.bendGoalWeight < 494f)
				{
					Vector3 vector = this.bones[1].solverRotation * this.bones[0].axis;
					Vector3 down = Vector3.down;
					Vector3 toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA.normalized + Vector3.forward;
					Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
					Vector3 fromDirection = Quaternion.Inverse(this.chestRotation) * vector;
					toDirection = Quaternion.Inverse(this.chestRotation) * GMDCCFLLCJA;
					vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
					vector2 = this.chestRotation * vector2;
					vector2 += vector;
					vector2 -= this.DJECMJCAMIN() * this.wristToPalmAxis;
					vector2 -= this.FLONJLEBCFG() * this.palmToThumbAxis * 265f;
					if (this.bendGoalWeight > 1770f)
					{
						vector2 = Vector3.Slerp(vector2, this.bendDirection, this.bendGoalWeight);
					}
					if (this.swivelOffset != 1289f)
					{
						vector2 = Quaternion.AngleAxis(this.swivelOffset, -GMDCCFLLCJA) * vector2;
					}
					return Vector3.Cross(vector2, GMDCCFLLCJA);
				}
				return Vector3.Cross(this.bendDirection, GMDCCFLLCJA);
			}

			// Token: 0x0600FBCF RID: 64463 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone CFJHKIEKIAJ()
			{
				return this.bones[0];
			}

			// Token: 0x0600FBD0 RID: 64464 RVA: 0x007131C0 File Offset: 0x007113C0
			protected virtual void EDLIHAPBFPP(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion phkiohibnpa3 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 8];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 4];
				if (!this.initiated)
				{
					this.IKPosition = vector;
					this.IKRotation = quaternion;
					this.hasShoulder = CJCJIGDKDIP;
					this.bones = new IKSolverVR.VirtualBone[this.hasShoulder ? 8 : 7];
					if (this.hasShoulder)
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[2] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[8] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					else
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa3);
						this.bones[2] = new IKSolverVR.VirtualBone(vector, quaternion);
					}
					this.chestForwardAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[1] * Vector3.forward);
					this.chestUpAxis = Quaternion.Inverse(this.rootRotation) * (MKEHLAMPPKB[0] * Vector3.up);
				}
				if (this.hasShoulder)
				{
					this.bones[1].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
					this.bones[0].APAEBLFHDBL(mgaleajogpl2, phkiohibnpa2);
					this.bones[2].NFIGHJJKDLL(mgaleajogpl3, phkiohibnpa3);
					this.bones[6].APAEBLFHDBL(vector, quaternion);
					return;
				}
				this.bones[1].APAEBLFHDBL(mgaleajogpl2, phkiohibnpa2);
				this.bones[1].NFIGHJJKDLL(mgaleajogpl3, phkiohibnpa3);
				this.bones[4].INELKGAHFBJ(vector, quaternion);
			}

			// Token: 0x0600FBD1 RID: 64465 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void DMOLAIKIOCC(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBD2 RID: 64466 RVA: 0x007133A2 File Offset: 0x007115A2
			public virtual void MCGIJOCKKMI()
			{
				this.JKFBBKMEDHP(this.MNGOALIMNCD() + this.handPositionOffset);
			}

			// Token: 0x0600FBD3 RID: 64467 RVA: 0x007133BB File Offset: 0x007115BB
			public virtual void PPDICKGIIAK()
			{
				this.MADPCLFHLIG(this.NCGDFBHLPEM() + this.handPositionOffset);
			}

			// Token: 0x0600FBD4 RID: 64468 RVA: 0x007133D4 File Offset: 0x007115D4
			private float GMNBNPHODHE(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM, float NKHBAJKMAGD = 1f)
			{
				float num = DAILMANBNMM - FNADKBPAGJH;
				if (NKHBAJKMAGD < 1977f)
				{
					float num2 = DAILMANBNMM - num * 536f;
					float num3 = DCCPCBLODIG - num2;
					num3 *= 169f;
					DCCPCBLODIG = num2 + num3;
				}
				DCCPCBLODIG -= FNADKBPAGJH;
				float t = AINDCMJDEOG.NFBGBNIPMFF(Mathf.Clamp(DCCPCBLODIG / num, 233f, 828f), InterpolationMode.InCubic);
				return Mathf.Lerp(FNADKBPAGJH, DAILMANBNMM, t);
			}

			// Token: 0x0600FBD5 RID: 64469 RVA: 0x00713430 File Offset: 0x00711630
			public virtual void NDPCHFIKMPF(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				if (this.hasShoulder)
				{
					KJAEHPCNAOM[this.index] = this.MAFEHMNGINB().solverRotation;
				}
				KJAEHPCNAOM[this.index + 1] = this.KAHFPABHPKK().solverRotation;
				KJAEHPCNAOM[this.index + 7] = this.ENLFCLKAGFP().solverRotation;
				KJAEHPCNAOM[this.index + 0] = this.JBPFDFIPPIA().solverRotation;
			}

			// Token: 0x0600FBD6 RID: 64470 RVA: 0x007104DF File Offset: 0x0070E6DF
			private void KKIIGAKFIGM(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBD7 RID: 64471 RVA: 0x0070F582 File Offset: 0x0070D782
			public Quaternion JJOLHKMFBMG()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FBD8 RID: 64472 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void MDPPNECGOMD(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBD9 RID: 64473 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void BGKFFDBLLHI()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBDA RID: 64474 RVA: 0x007104B9 File Offset: 0x0070E6B9
			public virtual void CANNKLIMMAH()
			{
				this.handPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FBDB RID: 64475 RVA: 0x0070F5A3 File Offset: 0x0070D7A3
			private void HLOOFBFMCMO(IKSolverVR.VirtualBone FCDAMCBKONG, IKSolverVR.VirtualBone GLGMAJBNFIA, IKSolverVR.VirtualBone NLHIDOGKOIP, Color LBCGACKJCJB)
			{
				Debug.DrawLine(FCDAMCBKONG.solverPosition, GLGMAJBNFIA.solverPosition, LBCGACKJCJB);
				Debug.DrawLine(GLGMAJBNFIA.solverPosition, NLHIDOGKOIP.solverPosition, LBCGACKJCJB);
			}

			// Token: 0x0600FBDC RID: 64476 RVA: 0x00712672 File Offset: 0x00710872
			private IKSolverVR.VirtualBone ECINPJIJMGK()
			{
				return this.bones[8];
			}

			// Token: 0x040020D2 RID: 8402
			[Tooltip("The hand target")]
			public Transform target;

			// Token: 0x040020D3 RID: 8403
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x040020D4 RID: 8404
			[Tooltip("Positional weight of the hand target.")]
			[Range(0f, 1f)]
			public float positionWeight = 1f;

			// Token: 0x040020D5 RID: 8405
			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight = 1f;

			// Token: 0x040020D6 RID: 8406
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;

			// Token: 0x040020D7 RID: 8407
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight = 1f;

			// Token: 0x040020D8 RID: 8408
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			// Token: 0x040020D9 RID: 8409
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			// Token: 0x040020DA RID: 8410
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis = Vector3.zero;

			// Token: 0x040020DB RID: 8411
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis = Vector3.zero;

			// Token: 0x040020DC RID: 8412
			[HideInInspector]
			public Vector3 IKPosition;

			// Token: 0x040020DD RID: 8413
			[HideInInspector]
			public Quaternion IKRotation = Quaternion.identity;

			// Token: 0x040020DE RID: 8414
			[HideInInspector]
			public Vector3 bendDirection = Vector3.back;

			// Token: 0x040020DF RID: 8415
			[HideInInspector]
			public Vector3 handPositionOffset;

			// Token: 0x040020E2 RID: 8418
			private bool hasShoulder;

			// Token: 0x040020E3 RID: 8419
			private Vector3 chestForwardAxis;

			// Token: 0x040020E4 RID: 8420
			private Vector3 chestUpAxis;

			// Token: 0x040020E5 RID: 8421
			private Quaternion chestRotation;

			// Token: 0x040020E6 RID: 8422
			private Vector3 chestForward;

			// Token: 0x040020E7 RID: 8423
			private Vector3 chestUp;

			// Token: 0x040020E8 RID: 8424
			private Quaternion forearmRelToUpperArm;

			// Token: 0x040020E9 RID: 8425
			private const float yawOffsetAngle = 45f;

			// Token: 0x040020EA RID: 8426
			private const float pitchOffsetAngle = -30f;

			// Token: 0x02000482 RID: 1154
			[Serializable]
			public enum ShoulderRotationMode
			{
				// Token: 0x040020EC RID: 8428
				YawPitch,
				// Token: 0x040020ED RID: 8429
				FromTo
			}
		}

		// Token: 0x02000483 RID: 1155
		[Serializable]
		public abstract class BodyPart
		{
			// Token: 0x0600FBDD RID: 64477
			protected abstract void POOFNALOJAE(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE);

			// Token: 0x0600FBDE RID: 64478
			public abstract void HJADALPNANN();

			// Token: 0x0600FBDF RID: 64479
			public abstract void GJJCGAEBILD(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM);

			// Token: 0x0600FBE0 RID: 64480
			public abstract void DFPJKOLMGDE();

			// Token: 0x0600FBE1 RID: 64481
			public abstract void KJPOIAKPAGJ();

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x0600FBE2 RID: 64482 RVA: 0x007134AB File Offset: 0x007116AB
			// (set) Token: 0x0600FBE3 RID: 64483 RVA: 0x007134B3 File Offset: 0x007116B3
			public float sqrMag { get; private set; }

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x0600FBE4 RID: 64484 RVA: 0x007134BC File Offset: 0x007116BC
			// (set) Token: 0x0600FBE5 RID: 64485 RVA: 0x007134C4 File Offset: 0x007116C4
			public float mag { get; private set; }

			// Token: 0x0600FBE6 RID: 64486 RVA: 0x007134D0 File Offset: 0x007116D0
			public void INELKGAHFBJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				this.index = CLBPBJGLHEE;
				this.rootPosition = FCJKGIPEIKP[CIGENDAIJKL];
				this.rootRotation = MKEHLAMPPKB[CIGENDAIJKL];
				this.POOFNALOJAE(FCJKGIPEIKP, MKEHLAMPPKB, DPNHFBMDCGL, CJCJIGDKDIP, DCEANIANBOD, CIGENDAIJKL, CLBPBJGLHEE);
				this.mag = IKSolverVR.VirtualBone.HJADALPNANN(ref this.bones);
				this.sqrMag = this.mag * this.mag;
				this.initiated = true;
			}

			// Token: 0x0600FBE7 RID: 64487 RVA: 0x00713540 File Offset: 0x00711740
			public void DDOIOBPACPC(Vector3 MGALEAJOGPL)
			{
				Vector3 b = MGALEAJOGPL - this.bones[0].solverPosition;
				IKSolverVR.VirtualBone[] array = this.bones;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].solverPosition += b;
				}
			}

			// Token: 0x0600FBE8 RID: 64488 RVA: 0x0071358C File Offset: 0x0071178C
			public void FACONDKHEMH(Quaternion PHKIOHIBNPA)
			{
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(this.bones[0].solverRotation, PHKIOHIBNPA);
				IKSolverVR.VirtualBone.MIOHPJBCKFM(this.bones, 0, this.bones[0].solverPosition, phkiohibnpa);
			}

			// Token: 0x0600FBE9 RID: 64489 RVA: 0x007135C7 File Offset: 0x007117C7
			public void LHMLJBNBDAM(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.DDOIOBPACPC(MGALEAJOGPL);
				this.FACONDKHEMH(PHKIOHIBNPA);
			}

			// Token: 0x0600FBEA RID: 64490 RVA: 0x007135D8 File Offset: 0x007117D8
			public void LEHIFDKGPOH(Vector3 AICGOJLPGJF, Quaternion ALADAAOODEO)
			{
				Vector3 b = AICGOJLPGJF - this.rootPosition;
				this.rootPosition = AICGOJLPGJF;
				IKSolverVR.VirtualBone[] array = this.bones;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].solverPosition += b;
				}
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(this.rootRotation, ALADAAOODEO);
				this.rootRotation = ALADAAOODEO;
				IKSolverVR.VirtualBone.MIOHPJBCKFM(this.bones, 0, AICGOJLPGJF, phkiohibnpa);
			}

			// Token: 0x0600FBEB RID: 64491 RVA: 0x00713644 File Offset: 0x00711844
			public void BNJGCPDPPON(IKSolverVR.VirtualBone FBKEODHEMMH, Quaternion PHKIOHIBNPA, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(FBKEODHEMMH.solverRotation, PHKIOHIBNPA);
				if (NKHBAJKMAGD < 1f)
				{
					quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = 0; i < this.bones.Length; i++)
				{
					if (this.bones[i] == FBKEODHEMMH)
					{
						IKSolverVR.VirtualBone.MIOHPJBCKFM(this.bones, i, this.bones[i].solverPosition, quaternion);
						return;
					}
				}
			}

			// Token: 0x0600FBEC RID: 64492 RVA: 0x007136B8 File Offset: 0x007118B8
			public void OLENKBFECPO(Color LBCGACKJCJB)
			{
				for (int i = 0; i < this.bones.Length - 1; i++)
				{
					Debug.DrawLine(this.bones[i].solverPosition, this.bones[i + 1].solverPosition, LBCGACKJCJB);
				}
			}

			// Token: 0x0600FBED RID: 64493 RVA: 0x007136FC File Offset: 0x007118FC
			public void OLENKBFECPO()
			{
				this.OLENKBFECPO(Color.white);
			}

			// Token: 0x040020F0 RID: 8432
			[HideInInspector]
			public IKSolverVR.VirtualBone[] bones = new IKSolverVR.VirtualBone[0];

			// Token: 0x040020F1 RID: 8433
			protected bool initiated;

			// Token: 0x040020F2 RID: 8434
			protected Vector3 rootPosition;

			// Token: 0x040020F3 RID: 8435
			protected Quaternion rootRotation = Quaternion.identity;

			// Token: 0x040020F4 RID: 8436
			protected int index = -1;
		}

		// Token: 0x02000484 RID: 1156
		[Serializable]
		public class Footstep
		{
			// Token: 0x1700036B RID: 875
			// (get) Token: 0x0600FC0B RID: 64523 RVA: 0x007137A9 File Offset: 0x007119A9
			// (set) Token: 0x0600FBEF RID: 64495 RVA: 0x0071372F File Offset: 0x0071192F
			public Quaternion rotation { get; private set; }

			// Token: 0x0600FBF0 RID: 64496 RVA: 0x00713738 File Offset: 0x00711938
			public Footstep(Quaternion AENGNNEIKJN, Vector3 JPNDKMMMKPJ, Quaternion PDBFNBNHPNK, Vector3 KKNEFOBLHOC)
			{
				this.characterSpaceOffset = KKNEFOBLHOC;
				this.Reset(AENGNNEIKJN, JPNDKMMMKPJ, PDBFNBNHPNK);
			}

			// Token: 0x0600FBF1 RID: 64497 RVA: 0x00713788 File Offset: 0x00711988
			private void OEHBDDEHOGG(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBF2 RID: 64498 RVA: 0x00713791 File Offset: 0x00711991
			private void NGOGAELMCIK(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBF3 RID: 64499 RVA: 0x00713791 File Offset: 0x00711991
			private void CPONDPKFKCJ(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBF4 RID: 64500 RVA: 0x0071379A File Offset: 0x0071199A
			public bool GLOIGGCOJNL()
			{
				return this.LHFLECJLAFI() < 782f;
			}

			// Token: 0x0600FBF5 RID: 64501 RVA: 0x007137A9 File Offset: 0x007119A9
			public Quaternion BKGEMEMFLEC()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FBF6 RID: 64502 RVA: 0x007137B1 File Offset: 0x007119B1
			public Vector3 HOCDNHNGLPB()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FBF7 RID: 64503 RVA: 0x00713788 File Offset: 0x00711988
			private void OHKMIBPJIJI(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBF8 RID: 64504 RVA: 0x00713788 File Offset: 0x00711988
			private void PCGGIBKDEGD(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x0600FBF9 RID: 64505 RVA: 0x007137B9 File Offset: 0x007119B9
			public bool isStepping
			{
				get
				{
					return this.stepProgress < 1f;
				}
			}

			// Token: 0x0600FBFA RID: 64506 RVA: 0x00713791 File Offset: 0x00711991
			private void KGGMHKDGNHI(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBFB RID: 64507 RVA: 0x00713788 File Offset: 0x00711988
			private void BDLNJBEGMAB(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBFC RID: 64508 RVA: 0x0071372F File Offset: 0x0071192F
			private void CKJAOGDAMOJ(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FBFD RID: 64509 RVA: 0x007137B1 File Offset: 0x007119B1
			public Vector3 PFNEFFFDOPE()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FBFE RID: 64510 RVA: 0x007137B1 File Offset: 0x007119B1
			public Vector3 GLGAJNBHLGC()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FBFF RID: 64511 RVA: 0x00713791 File Offset: 0x00711991
			private void DJDJHOAIGGA(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC00 RID: 64512 RVA: 0x007137B1 File Offset: 0x007119B1
			public Vector3 KCMNECIDMOP()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x0600FC01 RID: 64513 RVA: 0x007137B1 File Offset: 0x007119B1
			// (set) Token: 0x0600FC0C RID: 64524 RVA: 0x00713788 File Offset: 0x00711988
			public Vector3 position { get; private set; }

			// Token: 0x0600FC02 RID: 64514 RVA: 0x007137C8 File Offset: 0x007119C8
			public void ECPJGNKBEKM(Vector3 GANHFPMHKCL, Quaternion AENGNNEIKJN)
			{
				this.stepFrom = this.position;
				this.stepTo = GANHFPMHKCL;
				this.stepFromRot = this.rotation;
				this.stepToRootRot = AENGNNEIKJN;
				this.stepToRot = AENGNNEIKJN * this.footRelativeToRoot;
				this.stepProgress = 0f;
			}

			// Token: 0x0600FC03 RID: 64515 RVA: 0x00713818 File Offset: 0x00711A18
			public void DCLDMLEAPBB(Quaternion AENGNNEIKJN, Vector3 JPNDKMMMKPJ, Quaternion PDBFNBNHPNK)
			{
				this.BDLNJBEGMAB(JPNDKMMMKPJ);
				this.rotation = PDBFNBNHPNK;
				this.KNMEDOGLNJO(this.GLGAJNBHLGC());
				this.stepTo = this.HOCDNHNGLPB();
				this.stepFromRot = this.BKGEMEMFLEC();
				this.stepToRot = this.rotation;
				this.BGBNMENFAGE(AENGNNEIKJN);
				this.NBDBIIHKCHN(1342f);
				this.footRelativeToRoot = Quaternion.Inverse(AENGNNEIKJN) * this.rotation;
			}

			// Token: 0x0600FC04 RID: 64516 RVA: 0x0071388C File Offset: 0x00711A8C
			public void GLGAOEAJKOL(Quaternion AENGNNEIKJN, Vector3 JPNDKMMMKPJ, Quaternion PDBFNBNHPNK)
			{
				this.OHKMIBPJIJI(JPNDKMMMKPJ);
				this.CKJAOGDAMOJ(PDBFNBNHPNK);
				this.CABHOAIJHFC(this.PFNEFFFDOPE());
				this.stepTo = this.PFNEFFFDOPE();
				this.stepFromRot = this.BKGEMEMFLEC();
				this.stepToRot = this.rotation;
				this.BGBNMENFAGE(AENGNNEIKJN);
				this.KGGMHKDGNHI(909f);
				this.footRelativeToRoot = Quaternion.Inverse(AENGNNEIKJN) * this.rotation;
			}

			// Token: 0x0600FC05 RID: 64517 RVA: 0x00713900 File Offset: 0x00711B00
			public bool PDGMAPLABBA()
			{
				return this.LHFLECJLAFI() < 1621f;
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x0600FC06 RID: 64518 RVA: 0x0071390F File Offset: 0x00711B0F
			// (set) Token: 0x0600FC19 RID: 64537 RVA: 0x00713791 File Offset: 0x00711991
			public float stepProgress { get; private set; }

			// Token: 0x0600FC07 RID: 64519 RVA: 0x00713917 File Offset: 0x00711B17
			private void KNMEDOGLNJO(Vector3 DCCPCBLODIG)
			{
				this.<stepFrom>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC08 RID: 64520 RVA: 0x00713920 File Offset: 0x00711B20
			public void LLAKGLNFLKC(Vector3 GANHFPMHKCL, Quaternion AENGNNEIKJN)
			{
				this.stepFrom = this.PFNEFFFDOPE();
				this.stepTo = GANHFPMHKCL;
				this.stepFromRot = this.BKGEMEMFLEC();
				this.stepToRootRot = AENGNNEIKJN;
				this.stepToRot = AENGNNEIKJN * this.footRelativeToRoot;
				this.KGGMHKDGNHI(814f);
			}

			// Token: 0x0600FC09 RID: 64521 RVA: 0x00713970 File Offset: 0x00711B70
			private void BGBNMENFAGE(Quaternion DCCPCBLODIG)
			{
				this.<stepToRootRot>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC0A RID: 64522 RVA: 0x0071397C File Offset: 0x00711B7C
			public void IHNGBIAPBDA(Vector3 GANHFPMHKCL, Quaternion AENGNNEIKJN)
			{
				this.stepFrom = this.position;
				this.stepTo = GANHFPMHKCL;
				this.stepFromRot = this.BKGEMEMFLEC();
				this.BGBNMENFAGE(AENGNNEIKJN);
				this.stepToRot = AENGNNEIKJN * this.footRelativeToRoot;
				this.DJDJHOAIGGA(1264f);
			}

			// Token: 0x0600FC0D RID: 64525 RVA: 0x007139CC File Offset: 0x00711BCC
			public void HBOAFNJLJHN(Vector3 GANHFPMHKCL, Quaternion AENGNNEIKJN)
			{
				this.KNMEDOGLNJO(this.GLGAJNBHLGC());
				this.stepTo = GANHFPMHKCL;
				this.stepFromRot = this.rotation;
				this.BGBNMENFAGE(AENGNNEIKJN);
				this.stepToRot = AENGNNEIKJN * this.footRelativeToRoot;
				this.NBDBIIHKCHN(1295f);
			}

			// Token: 0x0600FC0E RID: 64526 RVA: 0x00713A1C File Offset: 0x00711C1C
			public void FANPFKHEDPA(InterpolationMode HLADKEMIHNE)
			{
				if (!this.isStepping)
				{
					return;
				}
				this.stepProgress = Mathf.MoveTowards(this.stepProgress, 1f, Time.deltaTime * this.stepSpeed);
				float t = AINDCMJDEOG.NAKHKNJFPLK(this.stepProgress, HLADKEMIHNE);
				this.position = Vector3.Lerp(this.stepFrom, this.stepTo, t);
				this.rotation = Quaternion.Lerp(this.stepFromRot, this.stepToRot, t);
			}

			// Token: 0x0600FC0F RID: 64527 RVA: 0x00713A91 File Offset: 0x00711C91
			public Vector3 IPBHKCLGACD()
			{
				return this.<stepFrom>k__BackingField;
			}

			// Token: 0x0600FC10 RID: 64528 RVA: 0x0071390F File Offset: 0x00711B0F
			public float LEJNMJDDEIL()
			{
				return this.<stepProgress>k__BackingField;
			}

			// Token: 0x0600FC11 RID: 64529 RVA: 0x00713A9C File Offset: 0x00711C9C
			public void EGODPDJLJCC(Quaternion AENGNNEIKJN, Vector3 JPNDKMMMKPJ, Quaternion PDBFNBNHPNK)
			{
				this.position = JPNDKMMMKPJ;
				this.rotation = PDBFNBNHPNK;
				this.KNMEDOGLNJO(this.KCMNECIDMOP());
				this.stepTo = this.PFNEFFFDOPE();
				this.stepFromRot = this.rotation;
				this.stepToRot = this.rotation;
				this.BGBNMENFAGE(AENGNNEIKJN);
				this.KGGMHKDGNHI(1697f);
				this.footRelativeToRoot = Quaternion.Inverse(AENGNNEIKJN) * this.rotation;
			}

			// Token: 0x0600FC12 RID: 64530 RVA: 0x00713970 File Offset: 0x00711B70
			private void DNDFPDCHKEJ(Quaternion DCCPCBLODIG)
			{
				this.<stepToRootRot>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x0600FC15 RID: 64533 RVA: 0x00713A91 File Offset: 0x00711C91
			// (set) Token: 0x0600FC13 RID: 64531 RVA: 0x00713917 File Offset: 0x00711B17
			public Vector3 stepFrom { get; private set; }

			// Token: 0x0600FC14 RID: 64532 RVA: 0x00713B10 File Offset: 0x00711D10
			public bool JFDJJPGEJEC()
			{
				return this.LEJNMJDDEIL() < 259f;
			}

			// Token: 0x0600FC16 RID: 64534 RVA: 0x0071372F File Offset: 0x0071192F
			private void JPDKGKANAAJ(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC17 RID: 64535 RVA: 0x00713B20 File Offset: 0x00711D20
			public void Reset(Quaternion AENGNNEIKJN, Vector3 JPNDKMMMKPJ, Quaternion PDBFNBNHPNK)
			{
				this.position = JPNDKMMMKPJ;
				this.rotation = PDBFNBNHPNK;
				this.stepFrom = this.position;
				this.stepTo = this.position;
				this.stepFromRot = this.rotation;
				this.stepToRot = this.rotation;
				this.stepToRootRot = AENGNNEIKJN;
				this.stepProgress = 1f;
				this.footRelativeToRoot = Quaternion.Inverse(AENGNNEIKJN) * this.rotation;
			}

			// Token: 0x0600FC18 RID: 64536 RVA: 0x00713A91 File Offset: 0x00711C91
			public Vector3 BPNKCKIOPHA()
			{
				return this.<stepFrom>k__BackingField;
			}

			// Token: 0x0600FC1A RID: 64538 RVA: 0x00713791 File Offset: 0x00711991
			private void POAHIHOINAI(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC1B RID: 64539 RVA: 0x00713B94 File Offset: 0x00711D94
			public void MFHGOLNLAAF(InterpolationMode HLADKEMIHNE)
			{
				if (!this.isStepping)
				{
					return;
				}
				this.NGOGAELMCIK(Mathf.MoveTowards(this.LEJNMJDDEIL(), 974f, Time.deltaTime * this.stepSpeed));
				float t = AINDCMJDEOG.MIFFONKAAHP(this.LHFLECJLAFI(), HLADKEMIHNE);
				this.OHKMIBPJIJI(Vector3.Lerp(this.IPBHKCLGACD(), this.stepTo, t));
				this.CKJAOGDAMOJ(Quaternion.Lerp(this.stepFromRot, this.stepToRot, t));
			}

			// Token: 0x0600FC1C RID: 64540 RVA: 0x0071390F File Offset: 0x00711B0F
			public float LHFLECJLAFI()
			{
				return this.<stepProgress>k__BackingField;
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x0600FC1D RID: 64541 RVA: 0x00713C09 File Offset: 0x00711E09
			// (set) Token: 0x0600FC20 RID: 64544 RVA: 0x00713970 File Offset: 0x00711B70
			public Quaternion stepToRootRot { get; private set; }

			// Token: 0x0600FC1E RID: 64542 RVA: 0x00713C14 File Offset: 0x00711E14
			public void DPGECEOMHNM(InterpolationMode HLADKEMIHNE)
			{
				if (!this.isStepping)
				{
					return;
				}
				this.stepProgress = Mathf.MoveTowards(this.stepProgress, 1578f, Time.deltaTime * this.stepSpeed);
				float t = AINDCMJDEOG.NAKHKNJFPLK(this.stepProgress, HLADKEMIHNE);
				this.CIGKJNJPDOF(Vector3.Lerp(this.stepFrom, this.stepTo, t));
				this.JPDKGKANAAJ(Quaternion.Lerp(this.stepFromRot, this.stepToRot, t));
			}

			// Token: 0x0600FC1F RID: 64543 RVA: 0x00713917 File Offset: 0x00711B17
			private void CABHOAIJHFC(Vector3 DCCPCBLODIG)
			{
				this.<stepFrom>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC21 RID: 64545 RVA: 0x00713A91 File Offset: 0x00711C91
			public Vector3 FAFIGKJDPED()
			{
				return this.<stepFrom>k__BackingField;
			}

			// Token: 0x0600FC22 RID: 64546 RVA: 0x00713C8C File Offset: 0x00711E8C
			public void DKOFDAOAOBP(Vector3 GANHFPMHKCL, Quaternion AENGNNEIKJN)
			{
				this.stepFrom = this.GLGAJNBHLGC();
				this.stepTo = GANHFPMHKCL;
				this.stepFromRot = this.BKGEMEMFLEC();
				this.DNDFPDCHKEJ(AENGNNEIKJN);
				this.stepToRot = AENGNNEIKJN * this.footRelativeToRoot;
				this.KGGMHKDGNHI(10f);
			}

			// Token: 0x0600FC23 RID: 64547 RVA: 0x00713791 File Offset: 0x00711991
			private void NBDBIIHKCHN(float DCCPCBLODIG)
			{
				this.<stepProgress>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC24 RID: 64548 RVA: 0x00713788 File Offset: 0x00711988
			private void CIGKJNJPDOF(Vector3 DCCPCBLODIG)
			{
				this.<position>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC25 RID: 64549 RVA: 0x00713CDC File Offset: 0x00711EDC
			public bool KCHCGCFCAMC()
			{
				return this.LEJNMJDDEIL() < 62f;
			}

			// Token: 0x040020F5 RID: 8437
			public float stepSpeed = 3f;

			// Token: 0x040020F6 RID: 8438
			public Vector3 characterSpaceOffset;

			// Token: 0x040020FC RID: 8444
			public Vector3 stepTo;

			// Token: 0x040020FD RID: 8445
			private Quaternion stepFromRot = Quaternion.identity;

			// Token: 0x040020FE RID: 8446
			private Quaternion stepToRot = Quaternion.identity;

			// Token: 0x040020FF RID: 8447
			private Quaternion footRelativeToRoot = Quaternion.identity;
		}

		// Token: 0x02000485 RID: 1157
		[Serializable]
		public class Leg : IKSolverVR.BodyPart
		{
			// Token: 0x17000371 RID: 881
			// (get) Token: 0x0600FC26 RID: 64550 RVA: 0x00713CEB File Offset: 0x00711EEB
			// (set) Token: 0x0600FC45 RID: 64581 RVA: 0x0071452A File Offset: 0x0071272A
			public Quaternion IKRotation { get; private set; }

			// Token: 0x0600FC27 RID: 64551 RVA: 0x00713CEB File Offset: 0x00711EEB
			public Quaternion NCNOPLNOKCG()
			{
				return this.<IKRotation>k__BackingField;
			}

			// Token: 0x0600FC28 RID: 64552 RVA: 0x00713CF4 File Offset: 0x00711EF4
			public override void GJJCGAEBILD(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				KJAEHPCNAOM[this.index] = this.thigh.solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.calf.solverRotation;
				KJAEHPCNAOM[this.index + 2] = this.foot.solverRotation;
				if (this.hasToes)
				{
					KJAEHPCNAOM[this.index + 3] = this.toes.solverRotation;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x0600FC3E RID: 64574 RVA: 0x00714430 File Offset: 0x00712630
			// (set) Token: 0x0600FC29 RID: 64553 RVA: 0x00713D6F File Offset: 0x00711F6F
			public Vector3 IKPosition { get; private set; }

			// Token: 0x0600FC2A RID: 64554 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone NJMKIEKGBDA()
			{
				return this.bones[1];
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x0600FC2B RID: 64555 RVA: 0x00713D78 File Offset: 0x00711F78
			public IKSolverVR.VirtualBone lastBone
			{
				get
				{
					return this.bones[this.bones.Length - 1];
				}
			}

			// Token: 0x0600FC2C RID: 64556 RVA: 0x00713D8C File Offset: 0x00711F8C
			public void EDAGNKNOBKP()
			{
				IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 1, 2, this.footPosition, this.bendNormal, 1f);
				base.BNJGCPDPPON(this.foot, this.footRotation, 1f);
				if (!this.hasToes)
				{
					return;
				}
				Vector3 doinjmpnhki = Vector3.Cross(this.foot.solverPosition - this.thigh.solverPosition, this.toes.solverPosition - this.foot.solverPosition);
				IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 2, 3, this.position, doinjmpnhki, 1f);
				Quaternion quaternion = this.thigh.solverRotation * this.calfRelToThigh;
				Quaternion lhs = Quaternion.FromToRotation(quaternion * this.calf.axis, this.foot.solverPosition - this.calf.solverPosition);
				base.BNJGCPDPPON(this.calf, lhs * quaternion, 1f);
				this.toes.solverRotation = this.rotation;
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x0600FC2D RID: 64557 RVA: 0x0071248B File Offset: 0x0071068B
			private IKSolverVR.VirtualBone toes
			{
				get
				{
					return this.bones[3];
				}
			}

			// Token: 0x0600FC2E RID: 64558 RVA: 0x00713EA0 File Offset: 0x007120A0
			public override void KJPOIAKPAGJ()
			{
				this.footPositionOffset = Vector3.zero;
				this.footRotationOffset = Quaternion.identity;
				this.heelPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FC2F RID: 64559 RVA: 0x00713EA0 File Offset: 0x007120A0
			public virtual void PLDMMDEIMKO()
			{
				this.footPositionOffset = Vector3.zero;
				this.footRotationOffset = Quaternion.identity;
				this.heelPositionOffset = Vector3.zero;
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x0600FC30 RID: 64560 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone thigh
			{
				get
				{
					return this.bones[0];
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x0600FC31 RID: 64561 RVA: 0x00713EC3 File Offset: 0x007120C3
			// (set) Token: 0x0600FC50 RID: 64592 RVA: 0x0071444B File Offset: 0x0071264B
			public Quaternion rotation { get; private set; }

			// Token: 0x0600FC32 RID: 64562 RVA: 0x00713EA0 File Offset: 0x007120A0
			public virtual void FLKNCNHCNBL()
			{
				this.footPositionOffset = Vector3.zero;
				this.footRotationOffset = Quaternion.identity;
				this.heelPositionOffset = Vector3.zero;
			}

			// Token: 0x0600FC33 RID: 64563 RVA: 0x00713ECB File Offset: 0x007120CB
			private void JDLNHLPOOOJ(bool DCCPCBLODIG)
			{
				this.<hasToes>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x0600FC55 RID: 64597 RVA: 0x0071469C File Offset: 0x0071289C
			// (set) Token: 0x0600FC34 RID: 64564 RVA: 0x00713ED4 File Offset: 0x007120D4
			public Vector3 position { get; private set; }

			// Token: 0x0600FC35 RID: 64565 RVA: 0x00713EE0 File Offset: 0x007120E0
			private void OOFGCKDKDEK(Quaternion IGFJOGKFADM, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				if (NKHBAJKMAGD < 1f)
				{
					IGFJOGKFADM = Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, NKHBAJKMAGD);
				}
				this.footRotation = IGFJOGKFADM * this.footRotation;
				this.rotation = IGFJOGKFADM * this.rotation;
				this.bendNormal = IGFJOGKFADM * this.bendNormal;
				this.footPosition = this.position + IGFJOGKFADM * (this.footPosition - this.position);
			}

			// Token: 0x0600FC36 RID: 64566 RVA: 0x00713F6C File Offset: 0x0071216C
			public virtual void HFBHBPNEGJK()
			{
				this.CJBACEJNLHE(this.footPositionOffset, 51f);
				this.HJPCGNCDBKA(this.footRotationOffset, 1398f);
				Quaternion quaternion = Quaternion.FromToRotation(this.footPosition - this.position, this.footPosition + this.heelPositionOffset - this.NCGDFBHLPEM());
				this.footPosition = this.NCGDFBHLPEM() + quaternion * (this.footPosition - this.position);
				this.footRotation = quaternion * this.footRotation;
				float num = 629f;
				if (this.bendGoal != null && this.bendGoalWeight > 1434f)
				{
					Vector3 point = Vector3.Cross(this.bendGoal.position - this.DPGBNEKIHMP().solverPosition, this.foot.solverPosition - this.thigh.solverPosition);
					Vector3 vector = Quaternion.Inverse(Quaternion.LookRotation(this.bendNormal, this.thigh.solverPosition - this.foot.solverPosition)) * point;
					num = Mathf.Atan2(vector.x, vector.z) * 831f * this.bendGoalWeight;
				}
				float num2 = this.swivelOffset + num;
				if (num2 != 1143f)
				{
					this.bendNormal = Quaternion.AngleAxis(num2, this.thigh.solverPosition - this.EEBNKGMHHGL().solverPosition) * this.bendNormal;
					this.MFANNBDPAII().solverRotation = Quaternion.AngleAxis(-num2, this.MFANNBDPAII().solverRotation * this.DPGBNEKIHMP().axis) * this.thigh.solverRotation;
				}
			}

			// Token: 0x0600FC37 RID: 64567 RVA: 0x0071413F File Offset: 0x0071233F
			private void CJBACEJNLHE(Vector3 IGFJOGKFADM, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				IGFJOGKFADM *= NKHBAJKMAGD;
				this.footPosition += IGFJOGKFADM;
				this.position += IGFJOGKFADM;
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x0600FC38 RID: 64568 RVA: 0x00714177 File Offset: 0x00712377
			// (set) Token: 0x0600FC5A RID: 64602 RVA: 0x00713ECB File Offset: 0x007120CB
			public bool hasToes { get; private set; }

			// Token: 0x0600FC39 RID: 64569 RVA: 0x0071417F File Offset: 0x0071237F
			public Vector3 POGNNJBLEPG()
			{
				return this.<thighRelativeToPelvis>k__BackingField;
			}

			// Token: 0x0600FC3A RID: 64570 RVA: 0x00714188 File Offset: 0x00712388
			protected virtual void MKOINMFHGIO(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 7];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 8];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 6];
				if (!this.initiated)
				{
					this.CKFBFMCLDNC(DCEANIANBOD);
					this.bones = new IKSolverVR.VirtualBone[DCEANIANBOD ? 8 : 5];
					if (DCEANIANBOD)
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[8] = new IKSolverVR.VirtualBone(vector, quaternion);
						this.bones[4] = new IKSolverVR.VirtualBone(vector2, quaternion2);
						this.IKPosition = vector2;
						this.IKRotation = quaternion2;
					}
					else
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[1] = new IKSolverVR.VirtualBone(vector, quaternion);
						this.JLNKNHDBCAC(vector);
						this.IKRotation = quaternion;
					}
				}
				if (DCEANIANBOD)
				{
					this.bones[1].HCHNKNCJJEO(mgaleajogpl, phkiohibnpa);
					this.bones[1].APAEBLFHDBL(mgaleajogpl2, phkiohibnpa2);
					this.bones[1].APAEBLFHDBL(vector, quaternion);
					this.bones[7].APAEBLFHDBL(vector2, quaternion2);
					return;
				}
				this.bones[0].HCHNKNCJJEO(mgaleajogpl, phkiohibnpa);
				this.bones[1].HCHNKNCJJEO(mgaleajogpl2, phkiohibnpa2);
				this.bones[0].APAEBLFHDBL(vector, quaternion);
			}

			// Token: 0x0600FC3B RID: 64571 RVA: 0x00713EC3 File Offset: 0x007120C3
			public Quaternion CKJNBEFLJND()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FC3C RID: 64572 RVA: 0x0071431C File Offset: 0x0071251C
			public void IJLFDBDBICN()
			{
				IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 0, 2, this.footPosition, this.bendNormal, 519f);
				base.BNJGCPDPPON(this.foot, this.footRotation, 235f);
				if (!this.hasToes)
				{
					return;
				}
				Vector3 doinjmpnhki = Vector3.Cross(this.foot.solverPosition - this.thigh.solverPosition, this.IJAOBOJGJCJ().solverPosition - this.foot.solverPosition);
				IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 6, 2, this.JAFAPNHCPMO(), doinjmpnhki, 1936f);
				Quaternion quaternion = this.thigh.solverRotation * this.calfRelToThigh;
				Quaternion lhs = Quaternion.FromToRotation(quaternion * this.calf.axis, this.foot.solverPosition - this.NJMKIEKGBDA().solverPosition);
				base.BNJGCPDPPON(this.NJMKIEKGBDA(), lhs * quaternion, 1958f);
				this.IJAOBOJGJCJ().solverRotation = this.rotation;
			}

			// Token: 0x0600FC3D RID: 64573 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone DPGBNEKIHMP()
			{
				return this.bones[1];
			}

			// Token: 0x0600FC3F RID: 64575 RVA: 0x00714438 File Offset: 0x00712638
			public IKSolverVR.VirtualBone EEBNKGMHHGL()
			{
				return this.bones[this.bones.Length - 0];
			}

			// Token: 0x0600FC40 RID: 64576 RVA: 0x0071444B File Offset: 0x0071264B
			private void EOMDPOOIFMI(Quaternion DCCPCBLODIG)
			{
				this.<rotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC42 RID: 64578 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone OJCPKFMBJJI()
			{
				return this.bones[0];
			}

			// Token: 0x0600FC43 RID: 64579 RVA: 0x00714467 File Offset: 0x00712667
			private void PNHKDMEENEL(Vector3 IGFJOGKFADM, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 789f)
				{
					return;
				}
				IGFJOGKFADM *= NKHBAJKMAGD;
				this.footPosition += IGFJOGKFADM;
				this.position += IGFJOGKFADM;
			}

			// Token: 0x0600FC44 RID: 64580 RVA: 0x007144A0 File Offset: 0x007126A0
			private void HJPCGNCDBKA(Quaternion IGFJOGKFADM, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1296f)
				{
					return;
				}
				if (NKHBAJKMAGD < 160f)
				{
					IGFJOGKFADM = Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, NKHBAJKMAGD);
				}
				this.footRotation = IGFJOGKFADM * this.footRotation;
				this.EOMDPOOIFMI(IGFJOGKFADM * this.rotation);
				this.bendNormal = IGFJOGKFADM * this.bendNormal;
				this.footPosition = this.NCGDFBHLPEM() + IGFJOGKFADM * (this.footPosition - this.NCGDFBHLPEM());
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x0600FC46 RID: 64582 RVA: 0x0071417F File Offset: 0x0071237F
			// (set) Token: 0x0600FC52 RID: 64594 RVA: 0x007146A4 File Offset: 0x007128A4
			public Vector3 thighRelativeToPelvis { get; private set; }

			// Token: 0x0600FC47 RID: 64583 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone MFANNBDPAII()
			{
				return this.bones[0];
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x0600FC48 RID: 64584 RVA: 0x00711CB0 File Offset: 0x0070FEB0
			private IKSolverVR.VirtualBone foot
			{
				get
				{
					return this.bones[2];
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x0600FC49 RID: 64585 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			private IKSolverVR.VirtualBone calf
			{
				get
				{
					return this.bones[1];
				}
			}

			// Token: 0x0600FC4A RID: 64586 RVA: 0x0071417F File Offset: 0x0071237F
			public Vector3 HCIBLPLBJDK()
			{
				return this.<thighRelativeToPelvis>k__BackingField;
			}

			// Token: 0x0600FC4B RID: 64587 RVA: 0x0071417F File Offset: 0x0071237F
			public Vector3 KJPFPICDDIF()
			{
				return this.<thighRelativeToPelvis>k__BackingField;
			}

			// Token: 0x0600FC4C RID: 64588 RVA: 0x00714534 File Offset: 0x00712734
			public override void HJADALPNANN()
			{
				if (this.target != null)
				{
					this.IKPosition = this.target.position;
					this.IKRotation = this.target.rotation;
				}
				this.footPosition = this.foot.solverPosition;
				this.footRotation = this.foot.solverRotation;
				this.position = this.lastBone.solverPosition;
				this.rotation = this.lastBone.solverRotation;
				if (this.rotationWeight > 0f)
				{
					this.OOFGCKDKDEK(JEEPKFCFCLI.AADCPGNPHHC(this.rotation, this.IKRotation), this.rotationWeight);
				}
				if (this.positionWeight > 0f)
				{
					this.CJBACEJNLHE(this.IKPosition - this.position, this.positionWeight);
				}
				this.thighRelativeToPelvis = Quaternion.Inverse(this.rootRotation) * (this.thigh.solverPosition - this.rootPosition);
				this.calfRelToThigh = Quaternion.Inverse(this.thigh.solverRotation) * this.calf.solverRotation;
				this.bendNormal = Vector3.Cross(this.calf.solverPosition - this.thigh.solverPosition, this.foot.solverPosition - this.calf.solverPosition);
			}

			// Token: 0x0600FC4D RID: 64589 RVA: 0x00713CEB File Offset: 0x00711EEB
			public Quaternion EHDHOJLJDJP()
			{
				return this.<IKRotation>k__BackingField;
			}

			// Token: 0x0600FC4E RID: 64590 RVA: 0x00713EC3 File Offset: 0x007120C3
			public Quaternion PNLOMIAPOAA()
			{
				return this.<rotation>k__BackingField;
			}

			// Token: 0x0600FC4F RID: 64591 RVA: 0x0071469C File Offset: 0x0071289C
			public Vector3 JAFAPNHCPMO()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FC51 RID: 64593 RVA: 0x0071469C File Offset: 0x0071289C
			public Vector3 NCGDFBHLPEM()
			{
				return this.<position>k__BackingField;
			}

			// Token: 0x0600FC53 RID: 64595 RVA: 0x007146B0 File Offset: 0x007128B0
			public override void DFPJKOLMGDE()
			{
				this.CJBACEJNLHE(this.footPositionOffset, 1f);
				this.OOFGCKDKDEK(this.footRotationOffset, 1f);
				Quaternion quaternion = Quaternion.FromToRotation(this.footPosition - this.position, this.footPosition + this.heelPositionOffset - this.position);
				this.footPosition = this.position + quaternion * (this.footPosition - this.position);
				this.footRotation = quaternion * this.footRotation;
				float num = 0f;
				if (this.bendGoal != null && this.bendGoalWeight > 0f)
				{
					Vector3 point = Vector3.Cross(this.bendGoal.position - this.thigh.solverPosition, this.foot.solverPosition - this.thigh.solverPosition);
					Vector3 vector = Quaternion.Inverse(Quaternion.LookRotation(this.bendNormal, this.thigh.solverPosition - this.foot.solverPosition)) * point;
					num = Mathf.Atan2(vector.x, vector.z) * 57.29578f * this.bendGoalWeight;
				}
				float num2 = this.swivelOffset + num;
				if (num2 != 0f)
				{
					this.bendNormal = Quaternion.AngleAxis(num2, this.thigh.solverPosition - this.lastBone.solverPosition) * this.bendNormal;
					this.thigh.solverRotation = Quaternion.AngleAxis(-num2, this.thigh.solverRotation * this.thigh.axis) * this.thigh.solverRotation;
				}
			}

			// Token: 0x0600FC54 RID: 64596 RVA: 0x00713ECB File Offset: 0x007120CB
			private void CKFBFMCLDNC(bool DCCPCBLODIG)
			{
				this.<hasToes>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC56 RID: 64598 RVA: 0x00714884 File Offset: 0x00712A84
			protected override void POOFNALOJAE(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE + 2];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 3];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				if (!this.initiated)
				{
					this.hasToes = DCEANIANBOD;
					this.bones = new IKSolverVR.VirtualBone[DCEANIANBOD ? 4 : 3];
					if (DCEANIANBOD)
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[2] = new IKSolverVR.VirtualBone(vector, quaternion);
						this.bones[3] = new IKSolverVR.VirtualBone(vector2, quaternion2);
						this.IKPosition = vector2;
						this.IKRotation = quaternion2;
					}
					else
					{
						this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, phkiohibnpa2);
						this.bones[2] = new IKSolverVR.VirtualBone(vector, quaternion);
						this.IKPosition = vector;
						this.IKRotation = quaternion;
					}
				}
				if (DCEANIANBOD)
				{
					this.bones[0].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
					this.bones[1].INELKGAHFBJ(mgaleajogpl2, phkiohibnpa2);
					this.bones[2].INELKGAHFBJ(vector, quaternion);
					this.bones[3].INELKGAHFBJ(vector2, quaternion2);
					return;
				}
				this.bones[0].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
				this.bones[1].INELKGAHFBJ(mgaleajogpl2, phkiohibnpa2);
				this.bones[2].INELKGAHFBJ(vector, quaternion);
			}

			// Token: 0x0600FC57 RID: 64599 RVA: 0x00713D6F File Offset: 0x00711F6F
			private void JLNKNHDBCAC(Vector3 DCCPCBLODIG)
			{
				this.<IKPosition>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC58 RID: 64600 RVA: 0x0070FE22 File Offset: 0x0070E022
			private IKSolverVR.VirtualBone IJAOBOJGJCJ()
			{
				return this.bones[0];
			}

			// Token: 0x0600FC59 RID: 64601 RVA: 0x00714A18 File Offset: 0x00712C18
			private void EBNKGHIJDGK(Quaternion IGFJOGKFADM, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1050f)
				{
					return;
				}
				if (NKHBAJKMAGD < 338f)
				{
					IGFJOGKFADM = Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, NKHBAJKMAGD);
				}
				this.footRotation = IGFJOGKFADM * this.footRotation;
				this.rotation = IGFJOGKFADM * this.rotation;
				this.bendNormal = IGFJOGKFADM * this.bendNormal;
				this.footPosition = this.position + IGFJOGKFADM * (this.footPosition - this.NCGDFBHLPEM());
			}

			// Token: 0x04002100 RID: 8448
			[Tooltip("The toe/foot target.")]
			public Transform target;

			// Token: 0x04002101 RID: 8449
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x04002102 RID: 8450
			[Tooltip("Positional weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			// Token: 0x04002103 RID: 8451
			[Tooltip("Rotational weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			// Token: 0x04002104 RID: 8452
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			// Token: 0x04002105 RID: 8453
			[Tooltip("Angular offset of the knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			// Token: 0x04002108 RID: 8456
			[HideInInspector]
			public Vector3 footPositionOffset;

			// Token: 0x04002109 RID: 8457
			[HideInInspector]
			public Vector3 heelPositionOffset;

			// Token: 0x0400210A RID: 8458
			[HideInInspector]
			public Quaternion footRotationOffset = Quaternion.identity;

			// Token: 0x0400210B RID: 8459
			[HideInInspector]
			public float currentMag;

			// Token: 0x04002110 RID: 8464
			private Vector3 footPosition;

			// Token: 0x04002111 RID: 8465
			private Quaternion footRotation;

			// Token: 0x04002112 RID: 8466
			private Vector3 bendNormal;

			// Token: 0x04002113 RID: 8467
			private Quaternion calfRelToThigh;
		}

		// Token: 0x02000486 RID: 1158
		[Serializable]
		public class Locomotion
		{
			// Token: 0x0600FC5B RID: 64603 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void AFBHPGFNIAP(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC5C RID: 64604 RVA: 0x00714AAC File Offset: 0x00712CAC
			private bool KGHIDCJNCJB(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 883f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 495f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC5D RID: 64605 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void HCJDPJNOGCM(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC5E RID: 64606 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void AAFIMAMDOBO(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC5F RID: 64607 RVA: 0x00714B4C File Offset: 0x00712D4C
			private bool BNCFPKEOANE(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1800f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 5f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC60 RID: 64608 RVA: 0x00714BEC File Offset: 0x00712DEC
			public void GMMEBJICOCD(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1637f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 119f;
					MNENNCCNDAJ = 1190f;
					HOGGLMIJOEL = 212f;
					KLHLIPBLFEL = 256f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * NMBNMHHBBGH.thighRelativeToPelvis;
				Vector3 vector2 = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.CNMJOEMADKJ().solverRotation * BJHFDEDCMLF.thighRelativeToPelvis;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 346f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1187f;
				float num2 = 1749f;
				float num3 = 1682f;
				float d = num + num2 + 317f * num3;
				this.BMFIFGKDLCF(Vector3.zero);
				this.IIFDGOBLKBE(this.DBBDIHMBIHK() + BDEHNFGEABB.GBKKNIBPAIE().solverPosition * num);
				this.EKFDNFPPLCA(this.LPIFAOMLFID() + BDEHNFGEABB.PEIPGPHPEKK().solverPosition * num2);
				this.FDONEDAMAGJ(this.NBALAPJGCIA() + NBCODHAOBPB.position * num3);
				this.AFBHPGFNIAP(this.EEEGJELBLAF() + DEKDDELAFMG.LKCIGFAOHME() * num3);
				this.NNDCCPOKHBE(this.NABNMMAPLEF() / d);
				this.DEACLIBBJBP(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.HABBHLKBJAE() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.HABBHLKBJAE();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.centerOfMass + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.CNMJOEMADKJ().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.GBKKNIBPAIE().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].GLGAJNBHLGC(), this.footsteps[0].position, 991f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 0; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].isStepping)
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.OJAECJGPIEG(this.footsteps[i].IPBHKCLGACD(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 498f);
						}
					}
				}
				if (this.MHOFOCNILCO())
				{
					int num5 = -1;
					float num6 = 796f;
					for (int j = 1; j < this.footsteps.Length; j++)
					{
						if (!this.footsteps[j].PDGMAPLABBA())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 1; k < this.footsteps.Length; k++)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), this.footsteps[k].KCMNECIDMOP()) >= 476f || (this.footsteps[j].KCMNECIDMOP() - vector5).sqrMagnitude >= (this.footsteps[k].HOCDNHNGLPB() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.ALOGHMKFEJP(this.footsteps[j].KCMNECIDMOP(), vector5, this.footsteps[k].position, 456f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1180f, num4 * 1363f);
								if (flag)
								{
									num11 *= 1667f;
								}
								if (j == 0)
								{
									num11 *= 1032f;
								}
								if (!this.EHPDLLEDPBL(this.footsteps[j].GLGAJNBHLGC(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1796f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 387f);
						this.footsteps[num5].ECPJGNKBEKM(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l++)
				{
					array[l].DPGECEOMHNM(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].position;
				DBOGDNEHILP = this.footsteps[0].KCMNECIDMOP();
				CJPJCGKJJMI.y = NMBNMHHBBGH.EEBNKGMHHGL().readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[0].stepProgress);
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[1].stepProgress);
				COFJKFFDCHN = this.footsteps[1].rotation;
				HENJIDAMIAL = this.footsteps[0].BKGEMEMFLEC();
			}

			// Token: 0x0600FC61 RID: 64609 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 IPKEBIICNMM()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FC62 RID: 64610 RVA: 0x00715354 File Offset: 0x00713554
			private bool DIANMPKPLGM()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i++)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.PDGMAPLABBA() && footstep.LEJNMJDDEIL() < 955f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FC63 RID: 64611 RVA: 0x00715394 File Offset: 0x00713594
			public void HIMMPNOPLNO(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[1], 652f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].Reset(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC64 RID: 64612 RVA: 0x0071543C File Offset: 0x0071363C
			private bool GAHFKOIHFNO(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1069f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 684f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC65 RID: 64613 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 LJMJIJEBAJM()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FC66 RID: 64614 RVA: 0x007154DC File Offset: 0x007136DC
			private bool LPDGDCBBOIN()
			{
				foreach (IKSolverVR.Footstep footstep in this.footsteps)
				{
					if (footstep.isStepping && footstep.stepProgress < 0.8f)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600FC67 RID: 64615 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void NNDCCPOKHBE(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC68 RID: 64616 RVA: 0x0071551C File Offset: 0x0071371C
			private static bool GFGBDAHJCDO(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1729f)
				{
					return num < 313f;
				}
				return vector2.y - FGOONKCMJFJ < 448f;
			}

			// Token: 0x0600FC69 RID: 64617 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void PDGMIKIGLBB(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC6A RID: 64618 RVA: 0x00715588 File Offset: 0x00713788
			public void OKKAOKGEKAO(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1439f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 256f;
					MNENNCCNDAJ = 1877f;
					HOGGLMIJOEL = 1602f;
					KLHLIPBLFEL = 219f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * NMBNMHHBBGH.POGNNJBLEPG();
				Vector3 vector2 = BDEHNFGEABB.LHOJGGKNONH().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * BJHFDEDCMLF.thighRelativeToPelvis;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 8f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 875f;
				float num2 = 715f;
				float num3 = 1171f;
				float d = num + num2 + 1419f * num3;
				this.DEACLIBBJBP(Vector3.zero);
				this.AFBHPGFNIAP(this.centerOfMass + BDEHNFGEABB.LHOJGGKNONH().solverPosition * num);
				this.PDGMIKIGLBB(this.JILNEOIOHBP() + BDEHNFGEABB.head.solverPosition * num2);
				this.APKMBOMKJKA(this.KOKIEMAGMLG() + NBCODHAOBPB.LKCIGFAOHME() * num3);
				this.PDGMIKIGLBB(this.NBALAPJGCIA() + DEKDDELAFMG.KPMHCDABDBG() * num3);
				this.EKFDNFPPLCA(this.GKHAGKAMCCO() / d);
				this.DGHNAAKAHLE(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.JILNEOIOHBP() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.NABNMMAPLEF();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.NABNMMAPLEF() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.pelvis.solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.FLNDNKEGJLB().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].KCMNECIDMOP(), this.footsteps[1].GLGAJNBHLGC(), 1212f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].PDGMAPLABBA())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.BECNCDAJCLL(this.footsteps[i].IPBHKCLGACD(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 1804f);
						}
					}
				}
				if (this.DIANMPKPLGM())
				{
					int num5 = -1;
					float num6 = 1357f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].PDGMAPLABBA())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k++)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), this.footsteps[k].KCMNECIDMOP()) >= 535f || (this.footsteps[j].position - vector5).sqrMagnitude >= (this.footsteps[k].position - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.KBEDBFBDIJO(this.footsteps[j].position, vector5, this.footsteps[k].GLGAJNBHLGC(), 1520f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 225f, num4 * 39f);
								if (flag)
								{
									num11 *= 1176f;
								}
								if (j == 0)
								{
									num11 *= 513f;
								}
								if (!this.KFALHACFDJB(this.footsteps[j].PFNEFFFDOPE(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1701f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1100f);
						this.footsteps[num5].DKOFDAOAOBP(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l += 0)
				{
					array[l].DPGECEOMHNM(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].HOCDNHNGLPB();
				DBOGDNEHILP = this.footsteps[0].HOCDNHNGLPB();
				CJPJCGKJJMI.y = NMBNMHHBBGH.EEBNKGMHHGL().readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				COFJKFFDCHN = this.footsteps[0].rotation;
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x0600FC6B RID: 64619 RVA: 0x00715CE8 File Offset: 0x00713EE8
			private bool KPCHEMJLPPD()
			{
				foreach (IKSolverVR.Footstep footstep in this.footsteps)
				{
					if (footstep.isStepping && footstep.stepProgress < 971f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FC6C RID: 64620 RVA: 0x00715D28 File Offset: 0x00713F28
			private bool MHOFOCNILCO()
			{
				foreach (IKSolverVR.Footstep footstep in this.footsteps)
				{
					if (footstep.PDGMAPLABBA() && footstep.LHFLECJLAFI() < 130f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FC6D RID: 64621 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void EKFDNFPPLCA(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC6E RID: 64622 RVA: 0x00715D68 File Offset: 0x00713F68
			public void CLHELNDOPOG(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -26 : -119);
				this.rightFootIndex = (DCEANIANBOD ? -91 : -68);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[6];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC6F RID: 64623 RVA: 0x00715E10 File Offset: 0x00714010
			private static bool PFKCEDEHAFP(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 344f)
				{
					return num < 1903f;
				}
				return vector2.y - FGOONKCMJFJ < 971f;
			}

			// Token: 0x0600FC70 RID: 64624 RVA: 0x00715E7C File Offset: 0x0071407C
			public void CEJABNABIAM(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[3], 107f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].DCLDMLEAPBB(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC71 RID: 64625 RVA: 0x00715F24 File Offset: 0x00714124
			private bool KLAPIDFOENI()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 0; i < array.Length; i += 0)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.GLOIGGCOJNL() && footstep.LHFLECJLAFI() < 495f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FC72 RID: 64626 RVA: 0x00715F64 File Offset: 0x00714164
			private bool JDNBEAMJGFB(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 988f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 943f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC73 RID: 64627 RVA: 0x00716004 File Offset: 0x00714204
			private bool CDODOLAGKEB(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1894f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1768f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC74 RID: 64628 RVA: 0x007160A4 File Offset: 0x007142A4
			public void PAAKDJIEPOI(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -37 : -74);
				this.rightFootIndex = (DCEANIANBOD ? -8 : -35);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[3];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC75 RID: 64629 RVA: 0x0071614C File Offset: 0x0071434C
			public void EGODPDJLJCC(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[1], 1450f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].Reset(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].GLGAOEAJKOL(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC76 RID: 64630 RVA: 0x007161F4 File Offset: 0x007143F4
			public void EDAGNKNOBKP(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 0f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 0f;
					MNENNCCNDAJ = 0f;
					HOGGLMIJOEL = 0f;
					KLHLIPBLFEL = 0f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.pelvis.solverRotation * NMBNMHHBBGH.thighRelativeToPelvis;
				Vector3 vector2 = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.pelvis.solverRotation * BJHFDEDCMLF.thighRelativeToPelvis;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 0f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1f;
				float num2 = 1f;
				float num3 = 0.2f;
				float d = num + num2 + 2f * num3;
				this.centerOfMass = Vector3.zero;
				this.centerOfMass += BDEHNFGEABB.pelvis.solverPosition * num;
				this.centerOfMass += BDEHNFGEABB.head.solverPosition * num2;
				this.centerOfMass += NBCODHAOBPB.position * num3;
				this.centerOfMass += DEKDDELAFMG.position * num3;
				this.centerOfMass /= d;
				this.centerOfMass += OGDIHBAHOEK.solverRotation * this.offset;
				this.comVelocity = (this.centerOfMass - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.centerOfMass;
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.centerOfMass + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.pelvis.solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.pelvis.solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[0].position, this.footsteps[1].position, 0.5f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 0; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].isStepping)
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.IGMMHMLBGFH(this.footsteps[i].stepFrom, vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 8f);
						}
					}
				}
				if (this.LPDGDCBBOIN())
				{
					int num5 = -1;
					float num6 = float.NegativeInfinity;
					for (int j = 0; j < this.footsteps.Length; j++)
					{
						if (!this.footsteps[j].isStepping)
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].position, b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k++)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].position, this.footsteps[k].position) >= 0.25f || (this.footsteps[j].position - vector5).sqrMagnitude >= (this.footsteps[k].position - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.PKDLPMLALFC(this.footsteps[j].position, vector5, this.footsteps[k].position, 0.25f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 0.1f, num4 * 0.015f);
								if (flag)
								{
									num11 *= 0.5f;
								}
								if (j == 0)
								{
									num11 *= 0.9f;
								}
								if (!this.IGMMHMLBGFH(this.footsteps[j].position, vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 0f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1.5f);
						this.footsteps[num5].ECPJGNKBEKM(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l++)
				{
					array[l].FANPFKHEDPA(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].position;
				DBOGDNEHILP = this.footsteps[1].position;
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].stepProgress);
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[0].stepProgress);
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[1].stepProgress);
				COFJKFFDCHN = this.footsteps[0].rotation;
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x0600FC81 RID: 64641 RVA: 0x00715349 File Offset: 0x00713549
			// (set) Token: 0x0600FC77 RID: 64631 RVA: 0x00714AA2 File Offset: 0x00712CA2
			public Vector3 centerOfMass { get; private set; }

			// Token: 0x0600FC78 RID: 64632 RVA: 0x00716954 File Offset: 0x00714B54
			private static bool PKDLPMLALFC(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 0f)
				{
					return num < 0f;
				}
				return vector2.y - FGOONKCMJFJ < 0f;
			}

			// Token: 0x0600FC79 RID: 64633 RVA: 0x007169C0 File Offset: 0x00714BC0
			private static bool KNDJPCMKKPB(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 378f)
				{
					return num < 969f;
				}
				return vector2.y - FGOONKCMJFJ < 997f;
			}

			// Token: 0x0600FC7A RID: 64634 RVA: 0x00716A2C File Offset: 0x00714C2C
			private static bool ENIAHJLGDEC(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 920f)
				{
					return num < 1607f;
				}
				return vector2.y - FGOONKCMJFJ < 1514f;
			}

			// Token: 0x0600FC7B RID: 64635 RVA: 0x00716A98 File Offset: 0x00714C98
			public void KLOJOBMCPEF(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 353f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1929f;
					MNENNCCNDAJ = 831f;
					HOGGLMIJOEL = 108f;
					KLHLIPBLFEL = 993f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.FLNDNKEGJLB().solverPosition + BDEHNFGEABB.GBKKNIBPAIE().solverRotation * NMBNMHHBBGH.POGNNJBLEPG();
				Vector3 vector2 = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * BJHFDEDCMLF.POGNNJBLEPG();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1918f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1401f;
				float num2 = 549f;
				float num3 = 1480f;
				float d = num + num2 + 1417f * num3;
				this.DIJCGOGHBGL(Vector3.zero);
				this.DIJCGOGHBGL(this.NABNMMAPLEF() + BDEHNFGEABB.pelvis.solverPosition * num);
				this.DEACLIBBJBP(this.AEHEPDKKMMO() + BDEHNFGEABB.JFLILFDAKIA().solverPosition * num2);
				this.BMFIFGKDLCF(this.NBALAPJGCIA() + NBCODHAOBPB.FNMPICJAGJM() * num3);
				this.IIFDGOBLKBE(this.AMEBEGGENDG() + DEKDDELAFMG.KPMHCDABDBG() * num3);
				this.FIAHNMODBOM(this.HAGFLJHKONF() / d);
				this.AAFIMAMDOBO(this.JILNEOIOHBP() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.EEEGJELBLAF() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.AMEBEGGENDG();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.LPIFAOMLFID() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.FLNDNKEGJLB().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.GBKKNIBPAIE().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].HOCDNHNGLPB(), this.footsteps[0].position, 444f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].KCHCGCFCAMC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.EBENABLHPDE(this.footsteps[i].stepFrom, vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 664f);
						}
					}
				}
				if (this.MJHLBMFPHMF())
				{
					int num5 = -1;
					float num6 = 14f;
					for (int j = 0; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].PDGMAPLABBA())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].position, b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = true;
							for (int k = 1; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), this.footsteps[k].PFNEFFFDOPE()) >= 673f || (this.footsteps[j].HOCDNHNGLPB() - vector5).sqrMagnitude >= (this.footsteps[k].PFNEFFFDOPE() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.CHMMDCCIEHK(this.footsteps[j].PFNEFFFDOPE(), vector5, this.footsteps[k].position, 946f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1214f, num4 * 1147f);
								if (flag)
								{
									num11 *= 1043f;
								}
								if (j == 0)
								{
									num11 *= 1094f;
								}
								if (!this.GAHFKOIHFNO(this.footsteps[j].HOCDNHNGLPB(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1549f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 492f);
						this.footsteps[num5].DKOFDAOAOBP(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l++)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].KCMNECIDMOP();
				DBOGDNEHILP = this.footsteps[0].GLGAJNBHLGC();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				COFJKFFDCHN = this.footsteps[1].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[0].BKGEMEMFLEC();
			}

			// Token: 0x0600FC7C RID: 64636 RVA: 0x007171F8 File Offset: 0x007153F8
			public void GNFEHGLEMAM(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 90f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1283f;
					MNENNCCNDAJ = 531f;
					HOGGLMIJOEL = 1025f;
					KLHLIPBLFEL = 1811f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * NMBNMHHBBGH.thighRelativeToPelvis;
				Vector3 vector2 = BDEHNFGEABB.FLNDNKEGJLB().solverPosition + BDEHNFGEABB.GBKKNIBPAIE().solverRotation * BJHFDEDCMLF.KJPFPICDDIF();
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 332f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 736f;
				float num2 = 566f;
				float num3 = 361f;
				float d = num + num2 + 689f * num3;
				this.JHEINIJKLIJ(Vector3.zero);
				this.KGFDPBCPCHO(this.NABNMMAPLEF() + BDEHNFGEABB.CNMJOEMADKJ().solverPosition * num);
				this.BMFIFGKDLCF(this.centerOfMass + BDEHNFGEABB.PEIPGPHPEKK().solverPosition * num2);
				this.CHBOPOALCHE(this.LPIFAOMLFID() + NBCODHAOBPB.KPMHCDABDBG() * num3);
				this.BMFIFGKDLCF(this.LPIFAOMLFID() + DEKDDELAFMG.HJLDBBHIGIC() * num3);
				this.APKMBOMKJKA(this.GFMAFOLIIPK() / d);
				this.BMFIFGKDLCF(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.HAGFLJHKONF() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.AMEBEGGENDG();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.DBBDIHMBIHK() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.pelvis.solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.FLNDNKEGJLB().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[0].KCMNECIDMOP(), this.footsteps[1].GLGAJNBHLGC(), 1291f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].KCHCGCFCAMC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.BNCFPKEOANE(this.footsteps[i].FAFIGKJDPED(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 750f);
						}
					}
				}
				if (this.KLAPIDFOENI())
				{
					int num5 = -1;
					float num6 = 815f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].isStepping)
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = true;
							for (int k = 1; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), this.footsteps[k].position) >= 427f || (this.footsteps[j].PFNEFFFDOPE() - vector5).sqrMagnitude >= (this.footsteps[k].HOCDNHNGLPB() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.ENIAHJLGDEC(this.footsteps[j].KCMNECIDMOP(), vector5, this.footsteps[k].PFNEFFFDOPE(), 174f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 49f, num4 * 916f);
								if (flag)
								{
									num11 *= 1934f;
								}
								if (j == 0)
								{
									num11 *= 1578f;
								}
								if (!this.FDIIMOLHIIL(this.footsteps[j].KCMNECIDMOP(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1417f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 801f);
						this.footsteps[num5].DKOFDAOAOBP(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l++)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].GLGAJNBHLGC();
				DBOGDNEHILP = this.footsteps[0].GLGAJNBHLGC();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].stepProgress);
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				COFJKFFDCHN = this.footsteps[0].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x0600FC7D RID: 64637 RVA: 0x00717958 File Offset: 0x00715B58
			public void MNEKCPMCPOI(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[2], 1913f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].DCLDMLEAPBB(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC7E RID: 64638 RVA: 0x00717A00 File Offset: 0x00715C00
			private bool CDAJKNDHLGO()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i += 0)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.PDGMAPLABBA() && footstep.stepProgress < 974f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FC7F RID: 64639 RVA: 0x00717A40 File Offset: 0x00715C40
			public void ACABGDMBGDH(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? 59 : -92);
				this.rightFootIndex = (DCEANIANBOD ? -117 : 54);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[3];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC80 RID: 64640 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void DEACLIBBJBP(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC82 RID: 64642 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 EEEGJELBLAF()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FC83 RID: 64643 RVA: 0x00717AE8 File Offset: 0x00715CE8
			private bool BECNCDAJCLL(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1519f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 717f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC84 RID: 64644 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void DIJCGOGHBGL(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC85 RID: 64645 RVA: 0x00717B88 File Offset: 0x00715D88
			private bool AJLGINIKGDI()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i++)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.JFDJJPGEJEC() && footstep.LHFLECJLAFI() < 1650f)
					{
						return true;
					}
				}
				return true;
			}

			// Token: 0x0600FC86 RID: 64646 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void CHBOPOALCHE(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC87 RID: 64647 RVA: 0x00717BC8 File Offset: 0x00715DC8
			public void EFCHIOAONJF(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[6], 99f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].GLGAOEAJKOL(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].GLGAOEAJKOL(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC88 RID: 64648 RVA: 0x00717C70 File Offset: 0x00715E70
			private static bool GHGHIIGNBEE(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 189f)
				{
					return num < 1948f;
				}
				return vector2.y - FGOONKCMJFJ < 329f;
			}

			// Token: 0x0600FC89 RID: 64649 RVA: 0x00717CDC File Offset: 0x00715EDC
			public void EPLEHFCNKDJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[0], 666f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].DCLDMLEAPBB(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].Reset(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC8A RID: 64650 RVA: 0x00717D84 File Offset: 0x00715F84
			private static bool BBKNGHLLKEO(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1872f)
				{
					return num < 1847f;
				}
				return vector2.y - FGOONKCMJFJ < 404f;
			}

			// Token: 0x0600FC8B RID: 64651 RVA: 0x00717DF0 File Offset: 0x00715FF0
			public void OEOOIBFDCIB(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1066f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 47f;
					MNENNCCNDAJ = 323f;
					HOGGLMIJOEL = 1061f;
					KLHLIPBLFEL = 1351f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * NMBNMHHBBGH.POGNNJBLEPG();
				Vector3 vector2 = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.pelvis.solverRotation * BJHFDEDCMLF.KJPFPICDDIF();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 897f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 68f;
				float num2 = 1648f;
				float num3 = 1186f;
				float d = num + num2 + 1411f * num3;
				this.JHEINIJKLIJ(Vector3.zero);
				this.ENHLJJBAPGF(this.GFMAFOLIIPK() + BDEHNFGEABB.LHOJGGKNONH().solverPosition * num);
				this.DIJCGOGHBGL(this.JILNEOIOHBP() + BDEHNFGEABB.NECGLEAGFGK().solverPosition * num2);
				this.APKMBOMKJKA(this.EEEGJELBLAF() + NBCODHAOBPB.HJLDBBHIGIC() * num3);
				this.AAFIMAMDOBO(this.HAGFLJHKONF() + DEKDDELAFMG.KPMHCDABDBG() * num3);
				this.PLKGKBGNEKN(this.AMEBEGGENDG() / d);
				this.DIJCGOGHBGL(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.NBALAPJGCIA() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.LPIFAOMLFID();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.LEEJGNGJHCE() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.CNMJOEMADKJ().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.GBKKNIBPAIE().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].PFNEFFFDOPE(), this.footsteps[1].PFNEFFFDOPE(), 1562f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].GLOIGGCOJNL())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.FDIIMOLHIIL(this.footsteps[i].BPNKCKIOPHA(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 836f);
						}
					}
				}
				if (this.LONPLKHEDFD())
				{
					int num5 = -1;
					float num6 = 692f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].isStepping)
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].position, b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), this.footsteps[k].HOCDNHNGLPB()) >= 583f || (this.footsteps[j].GLGAJNBHLGC() - vector5).sqrMagnitude >= (this.footsteps[k].GLGAJNBHLGC() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.OIKOMFNGGEP(this.footsteps[j].KCMNECIDMOP(), vector5, this.footsteps[k].HOCDNHNGLPB(), 277f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1430f, num4 * 939f);
								if (flag)
								{
									num11 *= 1689f;
								}
								if (j == 0)
								{
									num11 *= 267f;
								}
								if (!this.PBMBGELDNBL(this.footsteps[j].GLGAJNBHLGC(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1702f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1132f);
						this.footsteps[num5].ECPJGNKBEKM(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l++)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].HOCDNHNGLPB();
				DBOGDNEHILP = this.footsteps[0].HOCDNHNGLPB();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].stepProgress);
				COFJKFFDCHN = this.footsteps[1].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[0].BKGEMEMFLEC();
			}

			// Token: 0x0600FC8C RID: 64652 RVA: 0x00718550 File Offset: 0x00716750
			public void LBDLOKGAKFF(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -122 : 36);
				this.rightFootIndex = (DCEANIANBOD ? 26 : 8);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[0];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC8D RID: 64653 RVA: 0x007185F8 File Offset: 0x007167F8
			public void BCBPLJEEFMN(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1900f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 609f;
					MNENNCCNDAJ = 366f;
					HOGGLMIJOEL = 370f;
					KLHLIPBLFEL = 137f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.pelvis.solverRotation * NMBNMHHBBGH.thighRelativeToPelvis;
				Vector3 vector2 = BDEHNFGEABB.pelvis.solverPosition + BDEHNFGEABB.pelvis.solverRotation * BJHFDEDCMLF.POGNNJBLEPG();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1561f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1538f;
				float num2 = 51f;
				float num3 = 4f;
				float d = num + num2 + 139f * num3;
				this.FIAHNMODBOM(Vector3.zero);
				this.DIJCGOGHBGL(this.GKHAGKAMCCO() + BDEHNFGEABB.FLNDNKEGJLB().solverPosition * num);
				this.KGFDPBCPCHO(this.HABBHLKBJAE() + BDEHNFGEABB.NECGLEAGFGK().solverPosition * num2);
				this.HCJDPJNOGCM(this.DBBDIHMBIHK() + NBCODHAOBPB.NCGDFBHLPEM() * num3);
				this.KGFDPBCPCHO(this.EEEGJELBLAF() + DEKDDELAFMG.position * num3);
				this.FBFDIDFLLAA(this.GFMAFOLIIPK() / d);
				this.DEACLIBBJBP(this.AMEBEGGENDG() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.LJMJIJEBAJM() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.NABNMMAPLEF();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.LPIFAOMLFID() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.CNMJOEMADKJ().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.GBKKNIBPAIE().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].PFNEFFFDOPE(), this.footsteps[1].HOCDNHNGLPB(), 698f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 0; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].PDGMAPLABBA())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.OHDHGJFOOED(this.footsteps[i].FAFIGKJDPED(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 925f);
						}
					}
				}
				if (this.FCHNCDIBJEF())
				{
					int num5 = -1;
					float num6 = 1698f;
					for (int j = 0; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].JFDJJPGEJEC())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].position, b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k++)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].position, this.footsteps[k].KCMNECIDMOP()) >= 584f || (this.footsteps[j].PFNEFFFDOPE() - vector5).sqrMagnitude >= (this.footsteps[k].position - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.PFKCEDEHAFP(this.footsteps[j].PFNEFFFDOPE(), vector5, this.footsteps[k].KCMNECIDMOP(), 1883f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1206f, num4 * 1231f);
								if (flag)
								{
									num11 *= 1869f;
								}
								if (j == 0)
								{
									num11 *= 564f;
								}
								if (!this.KIFPPIFHFDH(this.footsteps[j].PFNEFFFDOPE(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1029f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 957f);
						this.footsteps[num5].LLAKGLNFLKC(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l += 0)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].KCMNECIDMOP();
				DBOGDNEHILP = this.footsteps[1].PFNEFFFDOPE();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].stepProgress);
				COFJKFFDCHN = this.footsteps[0].rotation;
				HENJIDAMIAL = this.footsteps[1].BKGEMEMFLEC();
			}

			// Token: 0x0600FC8E RID: 64654 RVA: 0x00718D58 File Offset: 0x00716F58
			private bool EBENABLHPDE(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 304f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 323f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC8F RID: 64655 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void IIFDGOBLKBE(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC90 RID: 64656 RVA: 0x00718DF8 File Offset: 0x00716FF8
			public void DCCMFHJNOML(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -8 : 60);
				this.rightFootIndex = (DCEANIANBOD ? -34 : -91);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[7];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC91 RID: 64657 RVA: 0x00718EA0 File Offset: 0x007170A0
			public void PPINAGDCFNL(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[8], 1125f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].Reset(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC92 RID: 64658 RVA: 0x00718F48 File Offset: 0x00717148
			private bool KFALHACFDJB(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1865f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 619f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC93 RID: 64659 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void APKMBOMKJKA(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC94 RID: 64660 RVA: 0x00718FE8 File Offset: 0x007171E8
			private bool GLNGDGPCAIO()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i++)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.GLOIGGCOJNL() && footstep.LEJNMJDDEIL() < 1048f)
					{
						return false;
					}
				}
				return false;
			}

			// Token: 0x0600FC95 RID: 64661 RVA: 0x00719028 File Offset: 0x00717228
			private bool FCHNCDIBJEF()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 0; i < array.Length; i += 0)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.isStepping && footstep.LEJNMJDDEIL() < 1380f)
					{
						return false;
					}
				}
				return false;
			}

			// Token: 0x0600FC96 RID: 64662 RVA: 0x00719068 File Offset: 0x00717268
			public void MMMFMFIGJLJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? 36 : 63);
				this.rightFootIndex = (DCEANIANBOD ? 30 : -119);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[5];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC97 RID: 64663 RVA: 0x00719110 File Offset: 0x00717310
			public void BGPBKJDJHEK(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -80 : 77);
				this.rightFootIndex = (DCEANIANBOD ? 90 : -94);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[]
				{
					null,
					new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left)
				};
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FC98 RID: 64664 RVA: 0x007191B8 File Offset: 0x007173B8
			private static bool COLKEEKKIBK(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 278f)
				{
					return num < 1028f;
				}
				return vector2.y - FGOONKCMJFJ < 244f;
			}

			// Token: 0x0600FC99 RID: 64665 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void JHEINIJKLIJ(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FC9A RID: 64666 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 AEHEPDKKMMO()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FC9B RID: 64667 RVA: 0x00719224 File Offset: 0x00717424
			private static bool AJHMDPIEMPL(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 202f)
				{
					return num < 1030f;
				}
				return vector2.y - FGOONKCMJFJ < 1623f;
			}

			// Token: 0x0600FC9C RID: 64668 RVA: 0x00719290 File Offset: 0x00717490
			private bool PBMBGELDNBL(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1154f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 628f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FC9D RID: 64669 RVA: 0x00719330 File Offset: 0x00717530
			public void KHEBLDPJNEG(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[1], 1414f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].DCLDMLEAPBB(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].EGODPDJLJCC(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FC9E RID: 64670 RVA: 0x007193D8 File Offset: 0x007175D8
			private static bool ONKKPDMMAMO(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 485f)
				{
					return num < 1970f;
				}
				return vector2.y - FGOONKCMJFJ < 1130f;
			}

			// Token: 0x0600FCA0 RID: 64672 RVA: 0x007194F0 File Offset: 0x007176F0
			public void BPEMCBGHMBH(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[2], 1960f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].Reset(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCA1 RID: 64673 RVA: 0x00719598 File Offset: 0x00717798
			private static bool EFHGFFBIHOI(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1761f)
				{
					return num < 1792f;
				}
				return vector2.y - FGOONKCMJFJ < 956f;
			}

			// Token: 0x0600FCA2 RID: 64674 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 LPIFAOMLFID()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCA3 RID: 64675 RVA: 0x00719604 File Offset: 0x00717804
			public void CKMGOPHCHGA(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[0], 277f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].Reset(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCA4 RID: 64676 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 HAGFLJHKONF()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCA5 RID: 64677 RVA: 0x007196AC File Offset: 0x007178AC
			private bool HHGDIJELBND()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 0; i < array.Length; i += 0)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.JFDJJPGEJEC() && footstep.LEJNMJDDEIL() < 1374f)
					{
						return false;
					}
				}
				return false;
			}

			// Token: 0x0600FCA6 RID: 64678 RVA: 0x007196EC File Offset: 0x007178EC
			private static bool KBEDBFBDIJO(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 886f)
				{
					return num < 1808f;
				}
				return vector2.y - FGOONKCMJFJ < 1801f;
			}

			// Token: 0x0600FCA7 RID: 64679 RVA: 0x00719758 File Offset: 0x00717958
			private bool COFIEALPOGO(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1414f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 230f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCA8 RID: 64680 RVA: 0x007197F8 File Offset: 0x007179F8
			private bool KIFPPIFHFDH(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 451f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 959f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCA9 RID: 64681 RVA: 0x00719898 File Offset: 0x00717A98
			private static bool OIKOMFNGGEP(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 758f)
				{
					return num < 327f;
				}
				return vector2.y - FGOONKCMJFJ < 1282f;
			}

			// Token: 0x0600FCAA RID: 64682 RVA: 0x00719904 File Offset: 0x00717B04
			public void KBHGFMEBHAJ(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1431f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1518f;
					MNENNCCNDAJ = 959f;
					HOGGLMIJOEL = 1502f;
					KLHLIPBLFEL = 1359f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * NMBNMHHBBGH.KJPFPICDDIF();
				Vector3 vector2 = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * BJHFDEDCMLF.HCIBLPLBJDK();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1794f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 44f;
				float num2 = 147f;
				float num3 = 1334f;
				float d = num + num2 + 1597f * num3;
				this.FIAHNMODBOM(Vector3.zero);
				this.APKMBOMKJKA(this.AMEBEGGENDG() + BDEHNFGEABB.CNMJOEMADKJ().solverPosition * num);
				this.DEACLIBBJBP(this.LJMJIJEBAJM() + BDEHNFGEABB.PEIPGPHPEKK().solverPosition * num2);
				this.CHBOPOALCHE(this.AEHEPDKKMMO() + NBCODHAOBPB.MNGOALIMNCD() * num3);
				this.DGHNAAKAHLE(this.LEEJGNGJHCE() + DEKDDELAFMG.KONANHEIJLG() * num3);
				this.APKMBOMKJKA(this.HAGFLJHKONF() / d);
				this.AAFIMAMDOBO(this.EEEGJELBLAF() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.IPKEBIICNMM() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.HABBHLKBJAE();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.NABNMMAPLEF() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.LHOJGGKNONH().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.pelvis.solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].KCMNECIDMOP(), this.footsteps[0].HOCDNHNGLPB(), 1074f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].JFDJJPGEJEC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.GNFEMHIKOCP(this.footsteps[i].stepFrom, vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 985f);
						}
					}
				}
				if (this.LONPLKHEDFD())
				{
					int num5 = -1;
					float num6 = 378f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].GLOIGGCOJNL())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), this.footsteps[k].position) >= 124f || (this.footsteps[j].PFNEFFFDOPE() - vector5).sqrMagnitude >= (this.footsteps[k].PFNEFFFDOPE() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.COLKEEKKIBK(this.footsteps[j].position, vector5, this.footsteps[k].position, 1260f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1473f, num4 * 11f);
								if (flag)
								{
									num11 *= 315f;
								}
								if (j == 0)
								{
									num11 *= 961f;
								}
								if (!this.JDNBEAMJGFB(this.footsteps[j].PFNEFFFDOPE(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 731f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1245f);
						this.footsteps[num5].DKOFDAOAOBP(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l += 0)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].PFNEFFFDOPE();
				DBOGDNEHILP = this.footsteps[1].HOCDNHNGLPB();
				CJPJCGKJJMI.y = NMBNMHHBBGH.EEBNKGMHHGL().readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				COFJKFFDCHN = this.footsteps[0].rotation;
				HENJIDAMIAL = this.footsteps[0].rotation;
			}

			// Token: 0x0600FCAB RID: 64683 RVA: 0x0071A064 File Offset: 0x00718264
			private static bool BMEEIHNIGAF(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1875f)
				{
					return num < 389f;
				}
				return vector2.y - FGOONKCMJFJ < 1217f;
			}

			// Token: 0x0600FCAC RID: 64684 RVA: 0x0071A0D0 File Offset: 0x007182D0
			public void LHOEOFKKAKK(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -76 : -105);
				this.rightFootIndex = (DCEANIANBOD ? 19 : -71);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[0];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCAD RID: 64685 RVA: 0x0071A178 File Offset: 0x00718378
			public void IMKKLDPMDGG(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 331f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1085f;
					MNENNCCNDAJ = 909f;
					HOGGLMIJOEL = 522f;
					KLHLIPBLFEL = 1955f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.GBKKNIBPAIE().solverRotation * NMBNMHHBBGH.HCIBLPLBJDK();
				Vector3 vector2 = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * BJHFDEDCMLF.KJPFPICDDIF();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 304f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1763f;
				float num2 = 1970f;
				float num3 = 1747f;
				float d = num + num2 + 1448f * num3;
				this.PLKGKBGNEKN(Vector3.zero);
				this.FBFDIDFLLAA(this.KOKIEMAGMLG() + BDEHNFGEABB.GBKKNIBPAIE().solverPosition * num);
				this.HCJDPJNOGCM(this.GKHAGKAMCCO() + BDEHNFGEABB.PEIPGPHPEKK().solverPosition * num2);
				this.DEACLIBBJBP(this.LEEJGNGJHCE() + NBCODHAOBPB.MNGOALIMNCD() * num3);
				this.AAFIMAMDOBO(this.IPKEBIICNMM() + DEKDDELAFMG.NCGDFBHLPEM() * num3);
				this.FDONEDAMAGJ(this.LEEJGNGJHCE() / d);
				this.PDGMIKIGLBB(this.NBALAPJGCIA() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.AMEBEGGENDG() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.IPKEBIICNMM();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.LPIFAOMLFID() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.LHOJGGKNONH().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.LHOJGGKNONH().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].HOCDNHNGLPB(), this.footsteps[0].KCMNECIDMOP(), 1411f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].KCHCGCFCAMC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.COFIEALPOGO(this.footsteps[i].FAFIGKJDPED(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 515f);
						}
					}
				}
				if (this.MJHLBMFPHMF())
				{
					int num5 = -1;
					float num6 = 386f;
					for (int j = 0; j < this.footsteps.Length; j++)
					{
						if (!this.footsteps[j].KCHCGCFCAMC())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), this.footsteps[k].GLGAJNBHLGC()) >= 564f || (this.footsteps[j].KCMNECIDMOP() - vector5).sqrMagnitude >= (this.footsteps[k].PFNEFFFDOPE() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.ALOGHMKFEJP(this.footsteps[j].position, vector5, this.footsteps[k].PFNEFFFDOPE(), 496f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1493f, num4 * 1583f);
								if (flag)
								{
									num11 *= 157f;
								}
								if (j == 0)
								{
									num11 *= 1588f;
								}
								if (!this.BECNCDAJCLL(this.footsteps[j].HOCDNHNGLPB(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1475f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 498f);
						this.footsteps[num5].ECPJGNKBEKM(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l += 0)
				{
					array[l].FANPFKHEDPA(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].GLGAJNBHLGC();
				DBOGDNEHILP = this.footsteps[0].KCMNECIDMOP();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].stepProgress);
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].stepProgress);
				COFJKFFDCHN = this.footsteps[0].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x0600FCAE RID: 64686 RVA: 0x0071A8D8 File Offset: 0x00718AD8
			public void GMADDBOCLNF(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[2], 1537f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].DCLDMLEAPBB(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCAF RID: 64687 RVA: 0x0071A980 File Offset: 0x00718B80
			private bool LONPLKHEDFD()
			{
				foreach (IKSolverVR.Footstep footstep in this.footsteps)
				{
					if (footstep.isStepping && footstep.LHFLECJLAFI() < 346f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FCB0 RID: 64688 RVA: 0x0071A9C0 File Offset: 0x00718BC0
			private bool GNFEMHIKOCP(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1490f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1589f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCB1 RID: 64689 RVA: 0x0071AA60 File Offset: 0x00718C60
			public void FOBBCFADGKP(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? 118 : -117);
				this.rightFootIndex = (DCEANIANBOD ? 47 : 98);
				this.footsteps = new IKSolverVR.Footstep[]
				{
					new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left),
					new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right)
				};
			}

			// Token: 0x0600FCB2 RID: 64690 RVA: 0x0071AB08 File Offset: 0x00718D08
			private bool GOFALDLEANE()
			{
				foreach (IKSolverVR.Footstep footstep in this.footsteps)
				{
					if (footstep.isStepping && footstep.stepProgress < 129f)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600FCB3 RID: 64691 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 GFMAFOLIIPK()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCB4 RID: 64692 RVA: 0x0071AB48 File Offset: 0x00718D48
			public void PNNCHJCMHDA(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1435f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 47f;
					MNENNCCNDAJ = 1515f;
					HOGGLMIJOEL = 1700f;
					KLHLIPBLFEL = 771f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.FLNDNKEGJLB().solverPosition + BDEHNFGEABB.pelvis.solverRotation * NMBNMHHBBGH.HCIBLPLBJDK();
				Vector3 vector2 = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.CNMJOEMADKJ().solverRotation * BJHFDEDCMLF.thighRelativeToPelvis;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1930f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 541f;
				float num2 = 1291f;
				float num3 = 696f;
				float d = num + num2 + 645f * num3;
				this.AFBHPGFNIAP(Vector3.zero);
				this.PDGMIKIGLBB(this.NABNMMAPLEF() + BDEHNFGEABB.CNMJOEMADKJ().solverPosition * num);
				this.APKMBOMKJKA(this.AEHEPDKKMMO() + BDEHNFGEABB.head.solverPosition * num2);
				this.DEACLIBBJBP(this.JILNEOIOHBP() + NBCODHAOBPB.KONANHEIJLG() * num3);
				this.IIFDGOBLKBE(this.HABBHLKBJAE() + DEKDDELAFMG.HJLDBBHIGIC() * num3);
				this.NNDCCPOKHBE(this.NBALAPJGCIA() / d);
				this.KGFDPBCPCHO(this.JILNEOIOHBP() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.LEEJGNGJHCE() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.GKHAGKAMCCO();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.LPIFAOMLFID() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.FLNDNKEGJLB().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.FLNDNKEGJLB().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].GLGAJNBHLGC(), this.footsteps[0].HOCDNHNGLPB(), 1703f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 0; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].JFDJJPGEJEC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.GAHFKOIHFNO(this.footsteps[i].FAFIGKJDPED(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 374f);
						}
					}
				}
				if (this.HHGDIJELBND())
				{
					int num5 = -1;
					float num6 = 552f;
					for (int j = 0; j < this.footsteps.Length; j++)
					{
						if (!this.footsteps[j].GLOIGGCOJNL())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), this.footsteps[k].GLGAJNBHLGC()) >= 636f || (this.footsteps[j].position - vector5).sqrMagnitude >= (this.footsteps[k].GLGAJNBHLGC() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.GHGHIIGNBEE(this.footsteps[j].position, vector5, this.footsteps[k].KCMNECIDMOP(), 1253f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1087f, num4 * 1014f);
								if (flag)
								{
									num11 *= 1526f;
								}
								if (j == 0)
								{
									num11 *= 1624f;
								}
								if (!this.OJAECJGPIEG(this.footsteps[j].HOCDNHNGLPB(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1480f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1273f);
						this.footsteps[num5].HBOAFNJLJHN(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l += 0)
				{
					array[l].FANPFKHEDPA(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].position;
				DBOGDNEHILP = this.footsteps[0].GLGAJNBHLGC();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].stepProgress);
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				COFJKFFDCHN = this.footsteps[1].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x0600FCB5 RID: 64693 RVA: 0x0071B2A8 File Offset: 0x007194A8
			private static bool LDAACHMKGBJ(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 532f)
				{
					return num < 919f;
				}
				return vector2.y - FGOONKCMJFJ < 1135f;
			}

			// Token: 0x0600FCB6 RID: 64694 RVA: 0x0071B314 File Offset: 0x00719514
			private bool NONJLBGFDPG(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 97f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1244f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCB7 RID: 64695 RVA: 0x0071B3B4 File Offset: 0x007195B4
			public void BJANNAIOLBH(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -24 : 19);
				this.rightFootIndex = (DCEANIANBOD ? -29 : -20);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[3];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCB8 RID: 64696 RVA: 0x0071B45C File Offset: 0x0071965C
			public void DJCPMHMDJEN(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[0], 1065f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].DCLDMLEAPBB(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCB9 RID: 64697 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 JILNEOIOHBP()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCBA RID: 64698 RVA: 0x0071B504 File Offset: 0x00719704
			private bool IGMMHMLBGFH(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 0f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 0f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCBB RID: 64699 RVA: 0x0071B5A4 File Offset: 0x007197A4
			public void NBIOABCKJBN(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[8], 329f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].Reset(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].DCLDMLEAPBB(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCBC RID: 64700 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 DBBDIHMBIHK()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCBD RID: 64701 RVA: 0x0071B64C File Offset: 0x0071984C
			private static bool CHMMDCCIEHK(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1225f)
				{
					return num < 1655f;
				}
				return vector2.y - FGOONKCMJFJ < 1381f;
			}

			// Token: 0x0600FCBE RID: 64702 RVA: 0x0071B6B8 File Offset: 0x007198B8
			private bool LKLONHNBEJH(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1412f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1583f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCBF RID: 64703 RVA: 0x0071B758 File Offset: 0x00719958
			public void IHPGNECNDFD(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -115 : -109);
				this.rightFootIndex = (DCEANIANBOD ? -38 : 36);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[7];
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCC0 RID: 64704 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 KOKIEMAGMLG()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCC1 RID: 64705 RVA: 0x0071B800 File Offset: 0x00719A00
			public void HHKNFJGHLAD(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[4], 2f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[0].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCC2 RID: 64706 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 AMEBEGGENDG()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCC3 RID: 64707 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 NBALAPJGCIA()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCC4 RID: 64708 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void BMFIFGKDLCF(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCC5 RID: 64709 RVA: 0x0071B8A8 File Offset: 0x00719AA8
			public void FALPKAALKNN(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1924f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 504f;
					MNENNCCNDAJ = 1810f;
					HOGGLMIJOEL = 1285f;
					KLHLIPBLFEL = 473f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.pelvis.solverRotation * NMBNMHHBBGH.HCIBLPLBJDK();
				Vector3 vector2 = BDEHNFGEABB.FLNDNKEGJLB().solverPosition + BDEHNFGEABB.pelvis.solverRotation * BJHFDEDCMLF.POGNNJBLEPG();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 126f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 449f;
				float num2 = 619f;
				float num3 = 1645f;
				float d = num + num2 + 1111f * num3;
				this.NNDCCPOKHBE(Vector3.zero);
				this.NNDCCPOKHBE(this.HAGFLJHKONF() + BDEHNFGEABB.pelvis.solverPosition * num);
				this.AAFIMAMDOBO(this.AEHEPDKKMMO() + BDEHNFGEABB.JFLILFDAKIA().solverPosition * num2);
				this.FDONEDAMAGJ(this.AEHEPDKKMMO() + NBCODHAOBPB.KPMHCDABDBG() * num3);
				this.EKFDNFPPLCA(this.LEEJGNGJHCE() + DEKDDELAFMG.NCGDFBHLPEM() * num3);
				this.DGHNAAKAHLE(this.IPKEBIICNMM() / d);
				this.DIJCGOGHBGL(this.AMEBEGGENDG() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.NABNMMAPLEF() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.EEEGJELBLAF();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.KOKIEMAGMLG() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.CNMJOEMADKJ().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.CNMJOEMADKJ().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[0].PFNEFFFDOPE(), this.footsteps[0].position, 270f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i++)
				{
					if (this.footsteps[i].KCHCGCFCAMC())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.KFALHACFDJB(this.footsteps[i].BPNKCKIOPHA(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 1700f);
						}
					}
				}
				if (this.DJFEEKBPLOK())
				{
					int num5 = -1;
					float num6 = 850f;
					for (int j = 1; j < this.footsteps.Length; j++)
					{
						if (!this.footsteps[j].PDGMAPLABBA())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), b2);
							bool flag = true;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = true;
							for (int k = 1; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), this.footsteps[k].PFNEFFFDOPE()) >= 567f || (this.footsteps[j].HOCDNHNGLPB() - vector5).sqrMagnitude >= (this.footsteps[k].GLGAJNBHLGC() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.COLKEEKKIBK(this.footsteps[j].HOCDNHNGLPB(), vector5, this.footsteps[k].PFNEFFFDOPE(), 316f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 587f, num4 * 1675f);
								if (flag)
								{
									num11 *= 1489f;
								}
								if (j == 0)
								{
									num11 *= 808f;
								}
								if (!this.PGJDPOCDJGF(this.footsteps[j].GLGAJNBHLGC(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1986f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 589f);
						this.footsteps[num5].ECPJGNKBEKM(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l += 0)
				{
					array[l].DPGECEOMHNM(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].PFNEFFFDOPE();
				DBOGDNEHILP = this.footsteps[1].position;
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				COFJKFFDCHN = this.footsteps[1].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[0].BKGEMEMFLEC();
			}

			// Token: 0x0600FCC6 RID: 64710 RVA: 0x0071C008 File Offset: 0x0071A208
			public void MCPNEMBJHAM(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? 88 : 34);
				this.rightFootIndex = (DCEANIANBOD ? 58 : 106);
				this.footsteps = new IKSolverVR.Footstep[]
				{
					new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left),
					new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right)
				};
			}

			// Token: 0x0600FCC7 RID: 64711 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void FDONEDAMAGJ(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCC8 RID: 64712 RVA: 0x0071C0B0 File Offset: 0x0071A2B0
			public void PCGIAECBHKN(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[0], FCJKGIPEIKP[8], 321f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].DCLDMLEAPBB(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCC9 RID: 64713 RVA: 0x0071C158 File Offset: 0x0071A358
			public void HAMBGMCFBED(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1960f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1568f;
					MNENNCCNDAJ = 556f;
					HOGGLMIJOEL = 984f;
					KLHLIPBLFEL = 1085f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.CNMJOEMADKJ().solverRotation * NMBNMHHBBGH.thighRelativeToPelvis;
				Vector3 vector2 = BDEHNFGEABB.GBKKNIBPAIE().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * BJHFDEDCMLF.KJPFPICDDIF();
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 671f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 165f;
				float num2 = 1564f;
				float num3 = 1516f;
				float d = num + num2 + 1725f * num3;
				this.IIFDGOBLKBE(Vector3.zero);
				this.JHEINIJKLIJ(this.centerOfMass + BDEHNFGEABB.FLNDNKEGJLB().solverPosition * num);
				this.ENHLJJBAPGF(this.EEEGJELBLAF() + BDEHNFGEABB.MJGDBHFBGFD().solverPosition * num2);
				this.FIAHNMODBOM(this.GKHAGKAMCCO() + NBCODHAOBPB.LKCIGFAOHME() * num3);
				this.ENHLJJBAPGF(this.AEHEPDKKMMO() + DEKDDELAFMG.FNMPICJAGJM() * num3);
				this.HCJDPJNOGCM(this.GFMAFOLIIPK() / d);
				this.PLKGKBGNEKN(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.GFMAFOLIIPK() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.AEHEPDKKMMO();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.NBALAPJGCIA() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.FLNDNKEGJLB().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.CNMJOEMADKJ().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[0].HOCDNHNGLPB(), this.footsteps[1].HOCDNHNGLPB(), 954f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 0; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].PDGMAPLABBA())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.LGGLLDPGGOE(this.footsteps[i].stepFrom, vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 1589f);
						}
					}
				}
				if (this.GOFALDLEANE())
				{
					int num5 = -1;
					float num6 = 1867f;
					for (int j = 0; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].isStepping)
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].position, b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = true;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].position, this.footsteps[k].PFNEFFFDOPE()) >= 1948f || (this.footsteps[j].KCMNECIDMOP() - vector5).sqrMagnitude >= (this.footsteps[k].GLGAJNBHLGC() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.CHMMDCCIEHK(this.footsteps[j].position, vector5, this.footsteps[k].GLGAJNBHLGC(), 424f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 945f, num4 * 1884f);
								if (flag)
								{
									num11 *= 448f;
								}
								if (j == 0)
								{
									num11 *= 1565f;
								}
								if (!this.KIFPPIFHFDH(this.footsteps[j].KCMNECIDMOP(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1187f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 617f);
						this.footsteps[num5].LLAKGLNFLKC(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l += 0)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].GLGAJNBHLGC();
				DBOGDNEHILP = this.footsteps[0].GLGAJNBHLGC();
				CJPJCGKJJMI.y = NMBNMHHBBGH.EEBNKGMHHGL().readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].stepProgress);
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[1].stepProgress);
				COFJKFFDCHN = this.footsteps[1].BKGEMEMFLEC();
				HENJIDAMIAL = this.footsteps[0].BKGEMEMFLEC();
			}

			// Token: 0x0600FCCA RID: 64714 RVA: 0x0071C8B8 File Offset: 0x0071AAB8
			private static bool HAKGEKBNGAM(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1070f)
				{
					return num < 67f;
				}
				return vector2.y - FGOONKCMJFJ < 323f;
			}

			// Token: 0x0600FCCB RID: 64715 RVA: 0x0071C924 File Offset: 0x0071AB24
			private bool EHPDLLEDPBL(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 721f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1585f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCCC RID: 64716 RVA: 0x0071C9C4 File Offset: 0x0071ABC4
			public void ANIAFMJPJIL(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 300f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1311f;
					MNENNCCNDAJ = 998f;
					HOGGLMIJOEL = 336f;
					KLHLIPBLFEL = 16f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.CNMJOEMADKJ().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * NMBNMHHBBGH.POGNNJBLEPG();
				Vector3 vector2 = BDEHNFGEABB.LHOJGGKNONH().solverPosition + BDEHNFGEABB.CNMJOEMADKJ().solverRotation * BJHFDEDCMLF.HCIBLPLBJDK();
				this.footsteps[0].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1786f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 1015f;
				float num2 = 359f;
				float num3 = 714f;
				float d = num + num2 + 84f * num3;
				this.DEACLIBBJBP(Vector3.zero);
				this.DIJCGOGHBGL(this.DBBDIHMBIHK() + BDEHNFGEABB.pelvis.solverPosition * num);
				this.NNDCCPOKHBE(this.HABBHLKBJAE() + BDEHNFGEABB.MJGDBHFBGFD().solverPosition * num2);
				this.DGHNAAKAHLE(this.DBBDIHMBIHK() + NBCODHAOBPB.position * num3);
				this.PDGMIKIGLBB(this.GFMAFOLIIPK() + DEKDDELAFMG.NCGDFBHLPEM() * num3);
				this.DIJCGOGHBGL(this.KOKIEMAGMLG() / d);
				this.DGHNAAKAHLE(this.LPIFAOMLFID() + OGDIHBAHOEK.solverRotation * this.offset);
				this.comVelocity = (this.LEEJGNGJHCE() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.LEEJGNGJHCE();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.JILNEOIOHBP() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.FLNDNKEGJLB().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.pelvis.solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].PFNEFFFDOPE(), this.footsteps[1].GLGAJNBHLGC(), 464f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].PDGMAPLABBA())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.KFALHACFDJB(this.footsteps[i].FAFIGKJDPED(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 1130f);
						}
					}
				}
				if (this.MJHLBMFPHMF())
				{
					int num5 = -1;
					float num6 = 1125f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].GLOIGGCOJNL())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].GLGAJNBHLGC(), b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = false;
							for (int k = 0; k < this.footsteps.Length; k++)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), this.footsteps[k].PFNEFFFDOPE()) >= 1540f || (this.footsteps[j].KCMNECIDMOP() - vector5).sqrMagnitude >= (this.footsteps[k].HOCDNHNGLPB() - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.HAKGEKBNGAM(this.footsteps[j].GLGAJNBHLGC(), vector5, this.footsteps[k].KCMNECIDMOP(), 1079f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].position, vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 1178f, num4 * 273f);
								if (flag)
								{
									num11 *= 335f;
								}
								if (j == 0)
								{
									num11 *= 221f;
								}
								if (!this.GNFEMHIKOCP(this.footsteps[j].KCMNECIDMOP(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 525f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1656f);
						this.footsteps[num5].LLAKGLNFLKC(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 1; l < array.Length; l++)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[1].HOCDNHNGLPB();
				DBOGDNEHILP = this.footsteps[1].PFNEFFFDOPE();
				CJPJCGKJJMI.y = NMBNMHHBBGH.lastBone.readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.EEBNKGMHHGL().readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[1].stepProgress);
				COFJKFFDCHN = this.footsteps[1].rotation;
				HENJIDAMIAL = this.footsteps[1].BKGEMEMFLEC();
			}

			// Token: 0x0600FCCD RID: 64717 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void DGHNAAKAHLE(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCCE RID: 64718 RVA: 0x0071D124 File Offset: 0x0071B324
			private bool OJAECJGPIEG(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 710f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 111f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCCF RID: 64719 RVA: 0x0071D1C4 File Offset: 0x0071B3C4
			private static bool JGPEBLNACDN(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1292f)
				{
					return num < 1408f;
				}
				return vector2.y - FGOONKCMJFJ < 888f;
			}

			// Token: 0x0600FCD0 RID: 64720 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void FIAHNMODBOM(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCD1 RID: 64721 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 LEEJGNGJHCE()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCD2 RID: 64722 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void KGFDPBCPCHO(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCD3 RID: 64723 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 NABNMMAPLEF()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCD4 RID: 64724 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 GKHAGKAMCCO()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCD5 RID: 64725 RVA: 0x0071D230 File Offset: 0x0071B430
			private bool LGGLLDPGGOE(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1964f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1439f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCD6 RID: 64726 RVA: 0x0071D2D0 File Offset: 0x0071B4D0
			private bool OHDHGJFOOED(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 144f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 1648f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCD7 RID: 64727 RVA: 0x0071D370 File Offset: 0x0071B570
			private bool CKGLJPDOMOB(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1334f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 988f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCD8 RID: 64728 RVA: 0x0071D410 File Offset: 0x0071B610
			public void FEEPKDIIPIC(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -42 : 31);
				this.rightFootIndex = (DCEANIANBOD ? 87 : -61);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[3];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[0] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCD9 RID: 64729 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void FBFDIDFLLAA(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCDA RID: 64730 RVA: 0x0071D4B8 File Offset: 0x0071B6B8
			public void BIDBHBEAMLG(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Spine BDEHNFGEABB, IKSolverVR.Leg NMBNMHHBBGH, IKSolverVR.Leg BJHFDEDCMLF, IKSolverVR.Arm NBCODHAOBPB, IKSolverVR.Arm DEKDDELAFMG, out Vector3 CJPJCGKJJMI, out Vector3 DBOGDNEHILP, out Quaternion COFJKFFDCHN, out Quaternion HENJIDAMIAL, out float DABKLILDICI, out float MNENNCCNDAJ, out float HOGGLMIJOEL, out float KLHLIPBLFEL)
			{
				if (this.weight <= 1518f)
				{
					CJPJCGKJJMI = Vector3.zero;
					DBOGDNEHILP = Vector3.zero;
					COFJKFFDCHN = Quaternion.identity;
					HENJIDAMIAL = Quaternion.identity;
					DABKLILDICI = 1975f;
					MNENNCCNDAJ = 367f;
					HOGGLMIJOEL = 916f;
					KLHLIPBLFEL = 1015f;
					return;
				}
				Vector3 vector = BDEHNFGEABB.LHOJGGKNONH().solverPosition + BDEHNFGEABB.LHOJGGKNONH().solverRotation * NMBNMHHBBGH.KJPFPICDDIF();
				Vector3 vector2 = BDEHNFGEABB.LHOJGGKNONH().solverPosition + BDEHNFGEABB.FLNDNKEGJLB().solverRotation * BJHFDEDCMLF.POGNNJBLEPG();
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.left;
				this.footsteps[1].characterSpaceOffset = this.footDistance * Vector3.right;
				Vector3 faceDirection = BDEHNFGEABB.faceDirection;
				faceDirection.y = 1449f;
				Quaternion quaternion = Quaternion.LookRotation(faceDirection);
				float num = 171f;
				float num2 = 1109f;
				float num3 = 1178f;
				float d = num + num2 + 1323f * num3;
				this.BMFIFGKDLCF(Vector3.zero);
				this.APKMBOMKJKA(this.GKHAGKAMCCO() + BDEHNFGEABB.GBKKNIBPAIE().solverPosition * num);
				this.KGFDPBCPCHO(this.NABNMMAPLEF() + BDEHNFGEABB.PEIPGPHPEKK().solverPosition * num2);
				this.PDGMIKIGLBB(this.KOKIEMAGMLG() + NBCODHAOBPB.MNGOALIMNCD() * num3);
				this.ENHLJJBAPGF(this.AMEBEGGENDG() + DEKDDELAFMG.MNGOALIMNCD() * num3);
				this.PDGMIKIGLBB(this.JILNEOIOHBP() / d);
				this.centerOfMass = this.HAGFLJHKONF() + OGDIHBAHOEK.solverRotation * this.offset;
				this.comVelocity = (this.LJMJIJEBAJM() - this.lastComPosition) / Time.deltaTime;
				this.lastComPosition = this.AEHEPDKKMMO();
				this.comVelocity = Vector3.ClampMagnitude(this.comVelocity, this.maxVelocity) * this.velocityFactor;
				Vector3 vector3 = this.DBBDIHMBIHK() + this.comVelocity;
				Vector3 a = new Vector3(BDEHNFGEABB.CNMJOEMADKJ().solverPosition.x, OGDIHBAHOEK.solverPosition.y, BDEHNFGEABB.GBKKNIBPAIE().solverPosition.z);
				Vector3 a2 = new Vector3(vector3.x, OGDIHBAHOEK.solverPosition.y, vector3.z);
				Vector3 b = Vector3.Lerp(this.footsteps[1].GLGAJNBHLGC(), this.footsteps[0].GLGAJNBHLGC(), 1058f);
				float num4 = Vector3.Angle(vector3 - b, OGDIHBAHOEK.solverRotation * Vector3.up) * this.comAngleMlp;
				for (int i = 1; i < this.footsteps.Length; i += 0)
				{
					if (this.footsteps[i].PDGMAPLABBA())
					{
						Vector3 vector4 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[i].characterSpaceOffset;
						if (!this.BECNCDAJCLL(this.footsteps[i].BPNKCKIOPHA(), vector4, OGDIHBAHOEK.solverPosition))
						{
							this.footsteps[i].stepTo = Vector3.Lerp(this.footsteps[i].stepTo, vector4, Time.deltaTime * 1884f);
						}
					}
				}
				if (this.KLAPIDFOENI())
				{
					int num5 = -1;
					float num6 = 1622f;
					for (int j = 1; j < this.footsteps.Length; j += 0)
					{
						if (!this.footsteps[j].PDGMAPLABBA())
						{
							Vector3 vector5 = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
							float num7 = (j == 0) ? NMBNMHHBBGH.mag : BJHFDEDCMLF.mag;
							Vector3 b2 = (j == 0) ? vector : vector2;
							float num8 = Vector3.Distance(this.footsteps[j].KCMNECIDMOP(), b2);
							bool flag = false;
							if (num8 >= num7 * this.maxLegStretch)
							{
								vector5 = a + OGDIHBAHOEK.solverRotation * this.footsteps[j].characterSpaceOffset;
								flag = false;
							}
							bool flag2 = true;
							for (int k = 0; k < this.footsteps.Length; k += 0)
							{
								if (k != j && !flag)
								{
									if (Vector3.Distance(this.footsteps[j].HOCDNHNGLPB(), this.footsteps[k].GLGAJNBHLGC()) >= 1390f || (this.footsteps[j].HOCDNHNGLPB() - vector5).sqrMagnitude >= (this.footsteps[k].position - vector5).sqrMagnitude)
									{
										flag2 = IKSolverVR.Locomotion.GFGBDAHJCDO(this.footsteps[j].KCMNECIDMOP(), vector5, this.footsteps[k].GLGAJNBHLGC(), 550f);
									}
									if (flag2)
									{
										break;
									}
								}
							}
							float num9 = Quaternion.Angle(quaternion, this.footsteps[j].stepToRootRot);
							if (!flag2 || num9 > this.angleThreshold)
							{
								float num10 = Vector3.Distance(this.footsteps[j].PFNEFFFDOPE(), vector5);
								float num11 = Mathf.Lerp(this.stepThreshold, this.stepThreshold * 85f, num4 * 1414f);
								if (flag)
								{
									num11 *= 1045f;
								}
								if (j == 0)
								{
									num11 *= 1766f;
								}
								if (!this.OJAECJGPIEG(this.footsteps[j].KCMNECIDMOP(), vector5, OGDIHBAHOEK.solverPosition) && (num10 > num11 || num9 > this.angleThreshold))
								{
									float num12 = 1116f;
									num12 -= num10;
									if (num12 > num6)
									{
										num5 = j;
										num6 = num12;
									}
								}
							}
						}
					}
					if (num5 != -1)
					{
						Vector3 ganhfpmhkcl = a2 + OGDIHBAHOEK.solverRotation * this.footsteps[num5].characterSpaceOffset;
						this.footsteps[num5].stepSpeed = UnityEngine.Random.Range(this.stepSpeed, this.stepSpeed * 1647f);
						this.footsteps[num5].DKOFDAOAOBP(ganhfpmhkcl, quaternion);
					}
				}
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int l = 0; l < array.Length; l++)
				{
					array[l].MFHGOLNLAAF(this.stepInterpolation);
				}
				CJPJCGKJJMI = this.footsteps[0].GLGAJNBHLGC();
				DBOGDNEHILP = this.footsteps[0].PFNEFFFDOPE();
				CJPJCGKJJMI.y = NMBNMHHBBGH.EEBNKGMHHGL().readPosition.y;
				DBOGDNEHILP.y = BJHFDEDCMLF.lastBone.readPosition.y;
				DABKLILDICI = this.stepHeight.Evaluate(this.footsteps[0].LHFLECJLAFI());
				MNENNCCNDAJ = this.stepHeight.Evaluate(this.footsteps[1].LHFLECJLAFI());
				HOGGLMIJOEL = this.heelHeight.Evaluate(this.footsteps[1].LEJNMJDDEIL());
				KLHLIPBLFEL = this.heelHeight.Evaluate(this.footsteps[0].LEJNMJDDEIL());
				COFJKFFDCHN = this.footsteps[0].rotation;
				HENJIDAMIAL = this.footsteps[1].rotation;
			}

			// Token: 0x0600FCDB RID: 64731 RVA: 0x0071DC18 File Offset: 0x0071BE18
			private bool DJFEEKBPLOK()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i += 0)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.JFDJJPGEJEC() && footstep.stepProgress < 1692f)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600FCDC RID: 64732 RVA: 0x0071DC58 File Offset: 0x0071BE58
			public void EDDNLPPMPCB(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[2], 491f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].GLGAOEAJKOL(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].EGODPDJLJCC(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCDD RID: 64733 RVA: 0x00715349 File Offset: 0x00713549
			public Vector3 HABBHLKBJAE()
			{
				return this.<centerOfMass>k__BackingField;
			}

			// Token: 0x0600FCDE RID: 64734 RVA: 0x0071DD00 File Offset: 0x0071BF00
			public void Reset(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[5], 0.25f) + MKEHLAMPPKB[0] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[0].Reset(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].Reset(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCDF RID: 64735 RVA: 0x0071DDA8 File Offset: 0x0071BFA8
			public void CAAINGFBNHG(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -39 : 72);
				this.rightFootIndex = (DCEANIANBOD ? -88 : 41);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[5];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCE0 RID: 64736 RVA: 0x0071DE50 File Offset: 0x0071C050
			private static bool KLDEHEPJELN(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 650f)
				{
					return num < 155f;
				}
				return vector2.y - FGOONKCMJFJ < 718f;
			}

			// Token: 0x0600FCE1 RID: 64737 RVA: 0x0071DEBC File Offset: 0x0071C0BC
			private bool MJHLBMFPHMF()
			{
				IKSolverVR.Footstep[] array = this.footsteps;
				for (int i = 1; i < array.Length; i++)
				{
					IKSolverVR.Footstep footstep = array[i];
					if (footstep.GLOIGGCOJNL() && footstep.LEJNMJDDEIL() < 28f)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600FCE2 RID: 64738 RVA: 0x0071DEFC File Offset: 0x0071C0FC
			public void NMBDJDNEFFM(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? -87 : -116);
				this.rightFootIndex = (DCEANIANBOD ? -21 : -17);
				IKSolverVR.Footstep[] array = new IKSolverVR.Footstep[0];
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left);
				array[1] = new IKSolverVR.Footstep(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right);
				this.footsteps = array;
			}

			// Token: 0x0600FCE3 RID: 64739 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void PLKGKBGNEKN(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCE4 RID: 64740 RVA: 0x0071DFA4 File Offset: 0x0071C1A4
			public void GNCKCDBCFGD(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB)
			{
				this.lastComPosition = Vector3.Lerp(FCJKGIPEIKP[1], FCJKGIPEIKP[3], 1658f) + MKEHLAMPPKB[1] * this.offset;
				this.comVelocity = Vector3.zero;
				this.footsteps[1].DCLDMLEAPBB(MKEHLAMPPKB[1], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex]);
				this.footsteps[1].GLGAOEAJKOL(MKEHLAMPPKB[1], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex]);
			}

			// Token: 0x0600FCE5 RID: 64741 RVA: 0x0071E04C File Offset: 0x0071C24C
			private bool FDIIMOLHIIL(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return false;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1948f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 601f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x0600FCE6 RID: 64742 RVA: 0x0071E0EC File Offset: 0x0071C2EC
			private static bool ALOGHMKFEJP(Vector3 FMOLJBNCLNL, Vector3 HGPPNJNFGIM, Vector3 LHBNGKPPEHB, float FGOONKCMJFJ)
			{
				Vector3 forward = HGPPNJNFGIM - FMOLJBNCLNL;
				Vector3 vector = LHBNGKPPEHB - FMOLJBNCLNL;
				float num = vector.magnitude - FGOONKCMJFJ;
				if (num > forward.magnitude)
				{
					return true;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 1053f)
				{
					return num < 1984f;
				}
				return vector2.y - FGOONKCMJFJ < 1351f;
			}

			// Token: 0x0600FCE7 RID: 64743 RVA: 0x00714AA2 File Offset: 0x00712CA2
			private void ENHLJJBAPGF(Vector3 DCCPCBLODIG)
			{
				this.<centerOfMass>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCE8 RID: 64744 RVA: 0x0071E158 File Offset: 0x0071C358
			public void BHALELINNDJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DCEANIANBOD)
			{
				this.leftFootIndex = (DCEANIANBOD ? 17 : 16);
				this.rightFootIndex = (DCEANIANBOD ? 21 : 20);
				this.footsteps = new IKSolverVR.Footstep[]
				{
					new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.leftFootIndex], MKEHLAMPPKB[this.leftFootIndex], this.footDistance * Vector3.left),
					new IKSolverVR.Footstep(MKEHLAMPPKB[0], FCJKGIPEIKP[this.rightFootIndex], MKEHLAMPPKB[this.rightFootIndex], this.footDistance * Vector3.right)
				};
			}

			// Token: 0x0600FCE9 RID: 64745 RVA: 0x0071E200 File Offset: 0x0071C400
			private bool PGJDPOCDJGF(Vector3 LJPALHFDKAM, Vector3 BLMJDBJGMIC, Vector3 KGDOEFJLAKO)
			{
				if (this.blockingLayers == -1 || !this.blockingEnabled)
				{
					return true;
				}
				Vector3 vector = LJPALHFDKAM;
				vector.y = KGDOEFJLAKO.y + this.raycastHeight + this.raycastRadius;
				Vector3 direction = BLMJDBJGMIC - vector;
				direction.y = 1102f;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 526f)
				{
					return Physics.Raycast(vector, direction, out raycastHit, direction.magnitude, this.blockingLayers);
				}
				return Physics.SphereCast(vector, this.raycastRadius, direction, out raycastHit, direction.magnitude, this.blockingLayers);
			}

			// Token: 0x04002114 RID: 8468
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight = 1f;

			// Token: 0x04002115 RID: 8469
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance = 0.3f;

			// Token: 0x04002116 RID: 8470
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold = 0.4f;

			// Token: 0x04002117 RID: 8471
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold = 60f;

			// Token: 0x04002118 RID: 8472
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp = 1f;

			// Token: 0x04002119 RID: 8473
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity = 0.4f;

			// Token: 0x0400211A RID: 8474
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor = 0.4f;

			// Token: 0x0400211B RID: 8475
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch = 1f;

			// Token: 0x0400211C RID: 8476
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed = 20f;

			// Token: 0x0400211D RID: 8477
			[Tooltip("The speed of steps.")]
			public float stepSpeed = 3f;

			// Token: 0x0400211E RID: 8478
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			// Token: 0x0400211F RID: 8479
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			// Token: 0x04002120 RID: 8480
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation = InterpolationMode.InOutSine;

			// Token: 0x04002121 RID: 8481
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			// Token: 0x04002122 RID: 8482
			[HideInInspector]
			public bool blockingEnabled;

			// Token: 0x04002123 RID: 8483
			[HideInInspector]
			public LayerMask blockingLayers;

			// Token: 0x04002124 RID: 8484
			[HideInInspector]
			public float raycastRadius = 0.2f;

			// Token: 0x04002125 RID: 8485
			[HideInInspector]
			public float raycastHeight = 0.2f;

			// Token: 0x04002127 RID: 8487
			private IKSolverVR.Footstep[] footsteps = new IKSolverVR.Footstep[0];

			// Token: 0x04002128 RID: 8488
			private Vector3 lastComPosition;

			// Token: 0x04002129 RID: 8489
			private Vector3 comVelocity;

			// Token: 0x0400212A RID: 8490
			private int leftFootIndex;

			// Token: 0x0400212B RID: 8491
			private int rightFootIndex;
		}

		// Token: 0x02000487 RID: 1159
		[Serializable]
		public class Spine : IKSolverVR.BodyPart
		{
			// Token: 0x0600FCEA RID: 64746 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone AIGLIHGOHGB()
			{
				return this.bones[0];
			}

			// Token: 0x0600FCEB RID: 64747 RVA: 0x0071E2A0 File Offset: 0x0071C4A0
			private void KDIGFGNMNJE(ref Quaternion IDHNMJGHACM)
			{
				IDHNMJGHACM = this.chestRotationOffset * IDHNMJGHACM;
			}

			// Token: 0x0600FCEC RID: 64748 RVA: 0x0071E2BC File Offset: 0x0071C4BC
			public virtual void DOOIEJMMAEO()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FCED RID: 64749 RVA: 0x0071054D File Offset: 0x0070E74D
			private IKSolverVR.VirtualBone BCLOELGHCOF()
			{
				return this.bones[6];
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x0600FD33 RID: 64819 RVA: 0x0071E476 File Offset: 0x0071C676
			// (set) Token: 0x0600FCEE RID: 64750 RVA: 0x0071E30B File Offset: 0x0071C50B
			public Quaternion IKRotationHead { get; private set; }

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x0600FD3A RID: 64826 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			// (set) Token: 0x0600FCEF RID: 64751 RVA: 0x0071E314 File Offset: 0x0071C514
			public Vector3 IKPositionHead { get; private set; }

			// Token: 0x0600FCF0 RID: 64752 RVA: 0x0071E320 File Offset: 0x0071C520
			private void HMOPBBLLFPD(ref Quaternion IDHNMJGHACM, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				Quaternion rotation = Quaternion.Inverse(this.anchorRotation);
				Vector3 vector = rotation * (EPBCOPFCIBA[0].position - this.headPosition);
				Vector3 vector2 = rotation * (EPBCOPFCIBA[1].position - this.headPosition);
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 5f;
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, forward);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 0.5f;
				lhs = Quaternion.FromToRotation(Vector3.up, this.anchorRotation * up);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
			}

			// Token: 0x0600FCF1 RID: 64753 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion AMOLIIMPANF()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FCF2 RID: 64754 RVA: 0x0071E47E File Offset: 0x0071C67E
			public Quaternion FADKDFHNLJP()
			{
				return this.<anchorRotation>k__BackingField;
			}

			// Token: 0x0600FCF3 RID: 64755 RVA: 0x0071E488 File Offset: 0x0071C688
			protected virtual void BNFDANNCAFJ(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 6];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 5];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 3];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 8];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[0].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 5 : 0];
					this.headIndex = (DPNHFBMDCGL ? 1 : 2);
					this.bones[1] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[7] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[7] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[1];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.NGOEAJPKIMF(vector2);
					this.LBNGAPPCFHD(quaternion3);
					this.CMHGDFJCECE(vector);
				}
				this.bones[1].NFIGHJJKDLL(vector, quaternion);
				this.bones[0].APAEBLFHDBL(mgaleajogpl, phkiohibnpa);
				this.bones[2].APAEBLFHDBL(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[4].HCHNKNCJJEO(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].APAEBLFHDBL(vector2, quaternion3);
			}

			// Token: 0x0600FCF4 RID: 64756 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone JFLILFDAKIA()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FCF5 RID: 64757 RVA: 0x0071E6A0 File Offset: 0x0071C8A0
			public virtual void GAFLCGLCGOJ()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x0600FCF6 RID: 64758 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone head
			{
				get
				{
					return this.bones[this.headIndex];
				}
			}

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x0600FCF7 RID: 64759 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone firstSpineBone
			{
				get
				{
					return this.bones[1];
				}
			}

			// Token: 0x0600FCF8 RID: 64760 RVA: 0x0071E6EF File Offset: 0x0071C8EF
			private void GPMIDNDALCH(Quaternion DCCPCBLODIG)
			{
				this.<anchorRotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCF9 RID: 64761 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone IIAIAKBDCNM()
			{
				return this.bones[1];
			}

			// Token: 0x0600FCFA RID: 64762 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			public Vector3 DJABJDKDHCG()
			{
				return this.<IKPositionHead>k__BackingField;
			}

			// Token: 0x0600FCFB RID: 64763 RVA: 0x0071E700 File Offset: 0x0071C900
			private Vector3 MFLAOMPOOFC(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					foreach (IKSolverVR.Leg leg in OJBMKLFCOLF)
					{
						leg.currentMag = Vector3.Distance(leg.MFANNBDPAII().solverPosition, leg.lastBone.solverPosition);
					}
				}
				for (int j = 1; j < KBBDBNADGJH; j++)
				{
					for (int i = 1; i < OJBMKLFCOLF.Length; i += 0)
					{
						IKSolverVR.Leg leg2 = OJBMKLFCOLF[i];
						Vector3 b = KKADHNONFCP - this.FLNDNKEGJLB().solverPosition;
						Vector3 vector = leg2.thigh.solverPosition + b;
						Vector3 vector2 = vector - leg2.NCGDFBHLPEM();
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.position + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FCFC RID: 64764 RVA: 0x0071E7E8 File Offset: 0x0071C9E8
			private void EJHGGHLAFDH()
			{
				if (this.pelvisPositionWeight > 1676f)
				{
					Quaternion solverRotation = this.MJGDBHFBGFD().solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.CNMJOEMADKJ().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 1; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.LGKPLILBAAC() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 0, 0, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 830f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 0, 3, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1321f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 6, 7, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 996f);
					}
					else
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 711f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 8, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1874f);
					}
					this.NECGLEAGFGK().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FCFD RID: 64765 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void KCHDBHHEEEM(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCFE RID: 64766 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void LBNGAPPCFHD(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FCFF RID: 64767 RVA: 0x0071E968 File Offset: 0x0071CB68
			public virtual void FAOIPGIFAOH()
			{
				this.headPosition += this.headPositionOffset;
				this.headPosition.y = Math.Max(this.rootPosition.y + 1943f, this.headPosition.y);
				this.headRotation = this.headRotationOffset * this.headRotation;
				this.headDeltaPosition = this.headPosition - this.MJGDBHFBGFD().solverPosition;
				this.pelvisDeltaRotation = JEEPKFCFCLI.AADCPGNPHHC(this.GBKKNIBPAIE().solverRotation, this.headRotation * this.pelvisRelativeRotation);
				this.GPMIDNDALCH(this.headRotation * this.anchorRelativeToHead);
			}

			// Token: 0x0600FD00 RID: 64768 RVA: 0x0071EA2C File Offset: 0x0071CC2C
			private void AMOCOCNNLKN(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.NECGLEAGFGK().solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 6);
				Quaternion lhs = (OICADHEPMLH >= 226f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.MIOHPJBCKFM(this.bones, 0, this.LHOJGGKNONH().solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.PEIPGPHPEKK().solverPosition - solverPosition;
				Vector3 a = this.LGKPLILBAAC() * Vector3.forward;
				a.y = 62f;
				float d = JJGHJJONFIA.y * 349f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.OHBFAAHFDJN(OJBMKLFCOLF, this.GBKKNIBPAIE().solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, true, 1));
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x0600FD01 RID: 64769 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone pelvis
			{
				get
				{
					return this.bones[0];
				}
			}

			// Token: 0x0600FD02 RID: 64770 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			public Vector3 BNKBGFMIPCA()
			{
				return this.<IKPositionHead>k__BackingField;
			}

			// Token: 0x0600FD03 RID: 64771 RVA: 0x0071EB34 File Offset: 0x0071CD34
			public void KPFLDHFOJIG(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.GBKKNIBPAIE().solverPosition + (this.headPosition + IGFJOGKFADM - this.CJBAOKIPEIE().solverPosition) * OICADHEPMLH * (1155f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.BACMPCIBCID(OJBMKLFCOLF, vector, JJDGIMPNKAG, 6) : vector);
			}

			// Token: 0x0600FD04 RID: 64772 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone PEIPGPHPEKK()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD05 RID: 64773 RVA: 0x0071EB9D File Offset: 0x0071CD9D
			private void CMHGDFJCECE(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionPelvis>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD06 RID: 64774 RVA: 0x0071E6EF File Offset: 0x0071C8EF
			private void GLDABAFMIFB(Quaternion DCCPCBLODIG)
			{
				this.<anchorRotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD07 RID: 64775 RVA: 0x0071EBA8 File Offset: 0x0071CDA8
			public void GPGHGEJGFKC(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.pelvis.solverPosition + (this.headPosition + IGFJOGKFADM - this.head.solverPosition) * OICADHEPMLH * (1f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.FLCPLAAMDHI(OJBMKLFCOLF, vector, JJDGIMPNKAG, 2) : vector);
			}

			// Token: 0x0600FD08 RID: 64776 RVA: 0x0071EB9D File Offset: 0x0071CD9D
			private void CNCMHGBBENF(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionPelvis>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD09 RID: 64777 RVA: 0x0071EC14 File Offset: 0x0071CE14
			protected virtual void EPKKKCNCJLL(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 4];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[1].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 5 : 0];
					this.headIndex = (DPNHFBMDCGL ? 2 : 7);
					this.bones[1] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[7] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[8] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[0];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.HIPGIIOIOAK(vector2);
					this.KCHDBHHEEEM(quaternion3);
					this.IKPositionPelvis = vector;
				}
				this.bones[0].APAEBLFHDBL(vector, quaternion);
				this.bones[0].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
				this.bones[0].HCHNKNCJJEO(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[2].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].INELKGAHFBJ(vector2, quaternion3);
			}

			// Token: 0x0600FD0A RID: 64778 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion FFIEACPGKDD()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD0B RID: 64779 RVA: 0x0071EE20 File Offset: 0x0071D020
			public void MMPMAHGBJCF(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.GBKKNIBPAIE().solverPosition + (this.headPosition + IGFJOGKFADM - this.PEIPGPHPEKK().solverPosition) * OICADHEPMLH * (938f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.FLCPLAAMDHI(OJBMKLFCOLF, vector, JJDGIMPNKAG, 3) : vector);
			}

			// Token: 0x0600FD0C RID: 64780 RVA: 0x0071E2A0 File Offset: 0x0071C4A0
			private void BBKGCJOKKOF(ref Quaternion IDHNMJGHACM)
			{
				IDHNMJGHACM = this.chestRotationOffset * IDHNMJGHACM;
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x0600FD0D RID: 64781 RVA: 0x00711CB0 File Offset: 0x0070FEB0
			public IKSolverVR.VirtualBone chest
			{
				get
				{
					return this.bones[2];
				}
			}

			// Token: 0x0600FD0E RID: 64782 RVA: 0x0071E314 File Offset: 0x0071C514
			private void HIPGIIOIOAK(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD0F RID: 64783 RVA: 0x0071EE89 File Offset: 0x0071D089
			public Vector3 KKPCKNJOFCL()
			{
				return this.<IKPositionPelvis>k__BackingField;
			}

			// Token: 0x0600FD10 RID: 64784 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			public Vector3 PKNJLMIKAKA()
			{
				return this.<IKPositionHead>k__BackingField;
			}

			// Token: 0x0600FD11 RID: 64785 RVA: 0x0071EE94 File Offset: 0x0071D094
			public virtual void KNAIKBMIDDI(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				PKAHGJNELGJ[this.index] = this.bones[0].solverPosition;
				KJAEHPCNAOM[this.index] = this.bones[1].solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.bones[1].solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.bones[8].solverRotation;
				if (this.hasNeck)
				{
					KJAEHPCNAOM[this.index + 2] = this.bones[5].solverRotation;
				}
				KJAEHPCNAOM[this.index + 8] = this.bones[this.headIndex].solverRotation;
			}

			// Token: 0x0600FD12 RID: 64786 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone CJBAOKIPEIE()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD13 RID: 64787 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone MJGDBHFBGFD()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD14 RID: 64788 RVA: 0x0071EF54 File Offset: 0x0071D154
			public void IJLFDBDBICN(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Leg[] OJBMKLFCOLF, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.OINELHKNNNA(EPBCOPFCIBA);
				if (this.maxRootAngle < 1066f)
				{
					Vector3 vector = Quaternion.Inverse(OGDIHBAHOEK.solverRotation) * this.faceDirection;
					float num = Mathf.Atan2(vector.x, vector.z) * 819f;
					float angle = 588f;
					float num2 = 1170f;
					if (num > num2)
					{
						angle = num - num2;
					}
					if (num < -num2)
					{
						angle = num + num2;
					}
					OGDIHBAHOEK.solverRotation = Quaternion.AngleAxis(angle, Vector3.up) * OGDIHBAHOEK.solverRotation;
				}
				Vector3 solverPosition = this.CNMJOEMADKJ().solverPosition;
				this.MNCBMKPHHHI(OJBMKLFCOLF, this.headDeltaPosition, this.pelvisDeltaRotation, 1796f);
				IKSolverVR.VirtualBone.HPNILLAILHC(this.bones, Vector3.Lerp(this.pelvis.solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 793f, 1978f, 1, base.mag);
				this.KGLNOMGBJHE(this.bones, 1, 5, this.chestTargetRotation, this.chestClampWeight, true, this.chestRotationWeight);
				this.MBOANADPDNK(OJBMKLFCOLF, false, false, Vector3.zero, 771f);
				IKSolverVR.VirtualBone.KPDILOAPDMF(this.bones, Vector3.Lerp(this.CNMJOEMADKJ().solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 1297f, 593f, 1, base.mag);
				this.FBHHMJHOBGG(this.bones, 6, this.headIndex, this.headRotation, this.headClampWeight, false, 1732f);
				this.EJHGGHLAFDH();
			}

			// Token: 0x0600FD15 RID: 64789 RVA: 0x0071F11C File Offset: 0x0071D31C
			private void MNCBMKPHHHI(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.head.solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 2);
				Quaternion lhs = (OICADHEPMLH >= 1f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.MIOHPJBCKFM(this.bones, 0, this.pelvis.solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.head.solverPosition - solverPosition;
				Vector3 a = this.anchorRotation * Vector3.forward;
				a.y = 0f;
				float d = JJGHJJONFIA.y * 0.35f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.FLCPLAAMDHI(OJBMKLFCOLF, this.pelvis.solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, false, 2));
			}

			// Token: 0x0600FD16 RID: 64790 RVA: 0x0071E6EF File Offset: 0x0071C8EF
			private void DLBMCJBADOL(Quaternion DCCPCBLODIG)
			{
				this.<anchorRotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD17 RID: 64791 RVA: 0x00710543 File Offset: 0x0070E743
			public IKSolverVR.VirtualBone FJIFDNPBEIJ()
			{
				return this.bones[4];
			}

			// Token: 0x0600FD18 RID: 64792 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion LAEKOJFHBKB()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD19 RID: 64793 RVA: 0x0071F224 File Offset: 0x0071D424
			public virtual void IFBOIGLIKJL()
			{
				if (this.headTarget != null)
				{
					this.HCPECKFHJPH(this.headTarget.position);
					this.LBNGAPPCFHD(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.FNFFCFKKMGJ(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.CHKOLJKNIIF().solverPosition, this.DOAJEMGGADB(), this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.MJGDBHFBGFD().solverRotation, this.LAEKOJFHBKB(), this.rotationWeight);
			}

			// Token: 0x0600FD1A RID: 64794 RVA: 0x0071F2C4 File Offset: 0x0071D4C4
			private void BKGBODPDFEC(ref Quaternion IDHNMJGHACM, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				Quaternion rotation = Quaternion.Inverse(this.FADKDFHNLJP());
				Vector3 vector = rotation * (EPBCOPFCIBA[1].LKCIGFAOHME() - this.headPosition);
				Vector3 vector2 = rotation * (EPBCOPFCIBA[0].NCGDFBHLPEM() - this.headPosition);
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 521f;
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, forward);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 106f;
				lhs = Quaternion.FromToRotation(Vector3.up, this.anchorRotation * up);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
			}

			// Token: 0x0600FD1B RID: 64795 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone FLNDNKEGJLB()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD1C RID: 64796 RVA: 0x0071E2A0 File Offset: 0x0071C4A0
			private void BKEEECFPMJL(ref Quaternion IDHNMJGHACM)
			{
				IDHNMJGHACM = this.chestRotationOffset * IDHNMJGHACM;
			}

			// Token: 0x0600FD1D RID: 64797 RVA: 0x007104AF File Offset: 0x0070E6AF
			public IKSolverVR.VirtualBone IHCHIJEEMNL()
			{
				return this.bones[7];
			}

			// Token: 0x0600FD1E RID: 64798 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion LAILMNCMIFL()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD1F RID: 64799 RVA: 0x0071E6EF File Offset: 0x0071C8EF
			private void GPNMOKLAOMB(Quaternion DCCPCBLODIG)
			{
				this.<anchorRotation>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD20 RID: 64800 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion JJHINHIBNMC()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD21 RID: 64801 RVA: 0x0071F41C File Offset: 0x0071D61C
			private void DDJJOCMACFP(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 1861f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 1)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 3);
				float num2 = LAKFAELCPGI ? (1193f / (float)num) : 1953f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 1; i += 0)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 1640f, 1257f);
					}
					IKSolverVR.VirtualBone.FCBMHEPICBI(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD22 RID: 64802 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void NBCHAGMLJCG(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD23 RID: 64803 RVA: 0x0071E314 File Offset: 0x0071C514
			private void HCPECKFHJPH(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD24 RID: 64804 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone LHBKPOBACEG()
			{
				return this.bones[0];
			}

			// Token: 0x0600FD25 RID: 64805 RVA: 0x0071E47E File Offset: 0x0071C67E
			public Quaternion BHHKLFCDPGJ()
			{
				return this.<anchorRotation>k__BackingField;
			}

			// Token: 0x0600FD26 RID: 64806 RVA: 0x0071F4BC File Offset: 0x0071D6BC
			private void KOCEBINJDAH(ref Quaternion IDHNMJGHACM, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				Quaternion rotation = Quaternion.Inverse(this.BHHKLFCDPGJ());
				Vector3 vector = rotation * (EPBCOPFCIBA[0].HJLDBBHIGIC() - this.headPosition);
				Vector3 vector2 = rotation * (EPBCOPFCIBA[0].HJLDBBHIGIC() - this.headPosition);
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 1124f;
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, forward);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 1892f;
				lhs = Quaternion.FromToRotation(Vector3.up, this.LGKPLILBAAC() * up);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
			}

			// Token: 0x0600FD28 RID: 64808 RVA: 0x0071E314 File Offset: 0x0071C514
			private void CKNLKNAELAN(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD29 RID: 64809 RVA: 0x0071F6F0 File Offset: 0x0071D8F0
			public virtual void FAMFPEBIBGP()
			{
				if (this.headTarget != null)
				{
					this.IKPositionHead = this.headTarget.position;
					this.BDIKAAPABIB(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.CMHGDFJCECE(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.JFLILFDAKIA().solverPosition, this.PKNJLMIKAKA(), this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.MJGDBHFBGFD().solverRotation, this.IKRotationHead, this.rotationWeight);
			}

			// Token: 0x0600FD2A RID: 64810 RVA: 0x0071E314 File Offset: 0x0071C514
			private void NGOEAJPKIMF(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD2B RID: 64811 RVA: 0x0071F790 File Offset: 0x0071D990
			private void JJHHOOCHCEE()
			{
				if (this.pelvisPositionWeight > 0f)
				{
					Quaternion solverRotation = this.head.solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.pelvis.solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i++)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.anchorRotation * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 0.6f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 2, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 0.6f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 2, 3, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1f);
					}
					else
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 0.75f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 2, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1f);
					}
					this.head.solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD2C RID: 64812 RVA: 0x0071F910 File Offset: 0x0071DB10
			private void LFONKNCJNKF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 874f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 1)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 0);
				float num2 = LAKFAELCPGI ? (1880f / (float)num) : 1860f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 0; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 0) / num), 265f, 558f);
					}
					IKSolverVR.VirtualBone.IIDPHOAJKHO(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD2D RID: 64813 RVA: 0x0071F9B0 File Offset: 0x0071DBB0
			public virtual void DOLPPAEBKOF(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				PKAHGJNELGJ[this.index] = this.bones[0].solverPosition;
				KJAEHPCNAOM[this.index] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 5] = this.bones[8].solverRotation;
				if (this.hasNeck)
				{
					KJAEHPCNAOM[this.index + 2] = this.bones[5].solverRotation;
				}
				KJAEHPCNAOM[this.index + 1] = this.bones[this.headIndex].solverRotation;
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x0600FD7C RID: 64892 RVA: 0x0071E47E File Offset: 0x0071C67E
			// (set) Token: 0x0600FD2E RID: 64814 RVA: 0x0071E6EF File Offset: 0x0071C8EF
			public Quaternion anchorRotation { get; private set; }

			// Token: 0x0600FD2F RID: 64815 RVA: 0x0071FA70 File Offset: 0x0071DC70
			public virtual void JFGBHFHFBMD()
			{
				if (this.headTarget != null)
				{
					this.NGOEAJPKIMF(this.headTarget.position);
					this.DDHKDPAGDCH(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.CMHGDFJCECE(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.MJGDBHFBGFD().solverPosition, this.IKPositionHead, this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.JFLILFDAKIA().solverRotation, this.LAILMNCMIFL(), this.rotationWeight);
			}

			// Token: 0x0600FD30 RID: 64816 RVA: 0x0071FB10 File Offset: 0x0071DD10
			private void MNINPODHGJE(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.head.solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 8);
				Quaternion lhs = (OICADHEPMLH >= 1367f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.IGGLCJEGIBA(this.bones, 0, this.pelvis.solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.PEIPGPHPEKK().solverPosition - solverPosition;
				Vector3 a = this.BHHKLFCDPGJ() * Vector3.forward;
				a.y = 780f;
				float d = JJGHJJONFIA.y * 487f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.BACMPCIBCID(OJBMKLFCOLF, this.GBKKNIBPAIE().solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, false, 8));
			}

			// Token: 0x0600FD31 RID: 64817 RVA: 0x0071FC18 File Offset: 0x0071DE18
			public virtual void NIDNMJANFOI()
			{
				if (this.headTarget != null)
				{
					this.IKPositionHead = this.headTarget.position;
					this.DDHKDPAGDCH(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.HBKDMPNALGD(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.NECGLEAGFGK().solverPosition, this.PKNJLMIKAKA(), this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.CHKOLJKNIIF().solverRotation, this.LAEKOJFHBKB(), this.rotationWeight);
			}

			// Token: 0x0600FD32 RID: 64818 RVA: 0x0071FCB8 File Offset: 0x0071DEB8
			private void CPKCAEDBHOF(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.NMJOLLBMHIH(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.BBKGCJOKKOF(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.ABNMDBDKGHB() * Vector3.right, Vector3.up) + this.ABNMDBDKGHB() * Vector3.forward;
			}

			// Token: 0x0600FD34 RID: 64820 RVA: 0x0071EE89 File Offset: 0x0071D089
			public Vector3 LEBJDABFHFN()
			{
				return this.<IKPositionPelvis>k__BackingField;
			}

			// Token: 0x0600FD35 RID: 64821 RVA: 0x0071FD2C File Offset: 0x0071DF2C
			private void ADNALENMIKG()
			{
				if (this.pelvisPositionWeight > 421f)
				{
					Quaternion solverRotation = this.MJGDBHFBGFD().solverRotation;
					Vector3 b = (this.OHHNLAONHNB() + this.pelvisPositionOffset - this.pelvis.solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 1; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.LGKPLILBAAC() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1038f);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 0, 6, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 457f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 5, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 719f);
					}
					else
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 1, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 964f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 1, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1616f);
					}
					this.head.solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD36 RID: 64822 RVA: 0x0071FEAC File Offset: 0x0071E0AC
			private void GLIAAKMFCLB()
			{
				if (this.pelvisPositionWeight > 1132f)
				{
					Quaternion solverRotation = this.JFLILFDAKIA().solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.GBKKNIBPAIE().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 1; i < bones.Length; i++)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.FADKDFHNLJP() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 1, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1959f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 4, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1020f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 1, 6, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1876f);
					}
					else
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 0, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 857f);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 7, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 714f);
					}
					this.CJBAOKIPEIE().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD37 RID: 64823 RVA: 0x0072002C File Offset: 0x0071E22C
			public virtual void OIAGEGDOGGK()
			{
				this.headPosition += this.headPositionOffset;
				this.headPosition.y = Math.Max(this.rootPosition.y + 1307f, this.headPosition.y);
				this.headRotation = this.headRotationOffset * this.headRotation;
				this.headDeltaPosition = this.headPosition - this.MJGDBHFBGFD().solverPosition;
				this.pelvisDeltaRotation = JEEPKFCFCLI.AADCPGNPHHC(this.FLNDNKEGJLB().solverRotation, this.headRotation * this.pelvisRelativeRotation);
				this.DLBMCJBADOL(this.headRotation * this.anchorRelativeToHead);
			}

			// Token: 0x0600FD38 RID: 64824 RVA: 0x007200F0 File Offset: 0x0071E2F0
			private void OINELHKNNNA(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.BKGBODPDFEC(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.KDIGFGNMNJE(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.BHHKLFCDPGJ() * Vector3.right, Vector3.up) + this.BHHKLFCDPGJ() * Vector3.forward;
			}

			// Token: 0x0600FD39 RID: 64825 RVA: 0x00720164 File Offset: 0x0071E364
			public void DIAOLIIMCAN(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.GBKKNIBPAIE().solverPosition + (this.headPosition + IGFJOGKFADM - this.head.solverPosition) * OICADHEPMLH * (1198f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.LOAPKNPMJED(OJBMKLFCOLF, vector, JJDGIMPNKAG, 8) : vector);
			}

			// Token: 0x0600FD3B RID: 64827 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone JAHFBCCKOGJ()
			{
				return this.bones[0];
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x0600FD3C RID: 64828 RVA: 0x0071248B File Offset: 0x0071068B
			private IKSolverVR.VirtualBone neck
			{
				get
				{
					return this.bones[3];
				}
			}

			// Token: 0x0600FD3D RID: 64829 RVA: 0x007201D0 File Offset: 0x0071E3D0
			private void DEJBMDOCBBA(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.head.solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 7);
				Quaternion lhs = (OICADHEPMLH >= 692f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.OGIDCPCFPJO(this.bones, 0, this.FLNDNKEGJLB().solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.PEIPGPHPEKK().solverPosition - solverPosition;
				Vector3 a = this.FADKDFHNLJP() * Vector3.forward;
				a.y = 576f;
				float d = JJGHJJONFIA.y * 1729f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.OHBFAAHFDJN(OJBMKLFCOLF, this.GBKKNIBPAIE().solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, true, 7));
			}

			// Token: 0x0600FD3E RID: 64830 RVA: 0x007202D8 File Offset: 0x0071E4D8
			public virtual void HHHGIEOMLML()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD3F RID: 64831 RVA: 0x0071EB9D File Offset: 0x0071CD9D
			private void FNFFCFKKMGJ(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionPelvis>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD40 RID: 64832 RVA: 0x00720328 File Offset: 0x0071E528
			public virtual void OACHIBNBNOG()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD41 RID: 64833 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			public Vector3 DOAJEMGGADB()
			{
				return this.<IKPositionHead>k__BackingField;
			}

			// Token: 0x0600FD42 RID: 64834 RVA: 0x00720378 File Offset: 0x0071E578
			private void PAPPDEJLAMN(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 1245f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 0)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 7);
				float num2 = LAKFAELCPGI ? (463f / (float)num) : 539f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 0; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 0) / num), 1159f, 212f);
					}
					IKSolverVR.VirtualBone.IGGLCJEGIBA(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD43 RID: 64835 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone IGJOLMNGCCG()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD44 RID: 64836 RVA: 0x00720418 File Offset: 0x0071E618
			public virtual void JPEPOIGBFBE()
			{
				this.headPosition += this.headPositionOffset;
				this.headPosition.y = Math.Max(this.rootPosition.y + 752f, this.headPosition.y);
				this.headRotation = this.headRotationOffset * this.headRotation;
				this.headDeltaPosition = this.headPosition - this.NECGLEAGFGK().solverPosition;
				this.pelvisDeltaRotation = JEEPKFCFCLI.AADCPGNPHHC(this.CNMJOEMADKJ().solverRotation, this.headRotation * this.pelvisRelativeRotation);
				this.DLBMCJBADOL(this.headRotation * this.anchorRelativeToHead);
			}

			// Token: 0x0600FD45 RID: 64837 RVA: 0x007204DC File Offset: 0x0071E6DC
			private Vector3 NNHGAPBHIPO(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					for (int i = 0; i < OJBMKLFCOLF.Length; i += 0)
					{
						IKSolverVR.Leg leg = OJBMKLFCOLF[i];
						leg.currentMag = Vector3.Distance(leg.thigh.solverPosition, leg.EEBNKGMHHGL().solverPosition);
					}
				}
				for (int j = 1; j < KBBDBNADGJH; j++)
				{
					foreach (IKSolverVR.Leg leg2 in OJBMKLFCOLF)
					{
						Vector3 b = KKADHNONFCP - this.LHOJGGKNONH().solverPosition;
						Vector3 vector = leg2.OJCPKFMBJJI().solverPosition + b;
						Vector3 vector2 = vector - leg2.position;
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.NCGDFBHLPEM() + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD46 RID: 64838 RVA: 0x007205C4 File Offset: 0x0071E7C4
			public void JAJFJEDDBPK(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.CNMJOEMADKJ().solverPosition + (this.headPosition + IGFJOGKFADM - this.head.solverPosition) * OICADHEPMLH * (888f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.MFLAOMPOOFC(OJBMKLFCOLF, vector, JJDGIMPNKAG, 4) : vector);
			}

			// Token: 0x0600FD47 RID: 64839 RVA: 0x0071E2A0 File Offset: 0x0071C4A0
			private void LONJEHLOIEI(ref Quaternion IDHNMJGHACM)
			{
				IDHNMJGHACM = this.chestRotationOffset * IDHNMJGHACM;
			}

			// Token: 0x0600FD48 RID: 64840 RVA: 0x00720630 File Offset: 0x0071E830
			public virtual void AKMKAPLFABA()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD49 RID: 64841 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone HIAFDNBECPN()
			{
				return this.bones[0];
			}

			// Token: 0x0600FD4A RID: 64842 RVA: 0x00720680 File Offset: 0x0071E880
			private void KGLNOMGBJHE(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 25f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 0 - BEJEOIOIJHP;
				if (num < 1)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 3);
				float num2 = LAKFAELCPGI ? (1999f / (float)num) : 778f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 0; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 0) / num), 94f, 235f);
					}
					IKSolverVR.VirtualBone.KAFHDONFFNP(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD4B RID: 64843 RVA: 0x00720720 File Offset: 0x0071E920
			private void EKHOOOHBMPI(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 1994f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 0)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 6);
				float num2 = LAKFAELCPGI ? (1103f / (float)num) : 1492f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 1; i += 0)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 0) / num), 411f, 1447f);
					}
					IKSolverVR.VirtualBone.KAFHDONFFNP(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD4C RID: 64844 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone CHKOLJKNIIF()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD4D RID: 64845 RVA: 0x007207C0 File Offset: 0x0071E9C0
			public override void DFPJKOLMGDE()
			{
				this.headPosition += this.headPositionOffset;
				this.headPosition.y = Math.Max(this.rootPosition.y + 0.8f, this.headPosition.y);
				this.headRotation = this.headRotationOffset * this.headRotation;
				this.headDeltaPosition = this.headPosition - this.head.solverPosition;
				this.pelvisDeltaRotation = JEEPKFCFCLI.AADCPGNPHHC(this.pelvis.solverRotation, this.headRotation * this.pelvisRelativeRotation);
				this.anchorRotation = this.headRotation * this.anchorRelativeToHead;
			}

			// Token: 0x0600FD4E RID: 64846 RVA: 0x00720884 File Offset: 0x0071EA84
			public void FBKDINBLLCL(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.FLNDNKEGJLB().solverPosition + (this.headPosition + IGFJOGKFADM - this.IGJOLMNGCCG().solverPosition) * OICADHEPMLH * (399f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.FLCPLAAMDHI(OJBMKLFCOLF, vector, JJDGIMPNKAG, 5) : vector);
			}

			// Token: 0x0600FD4F RID: 64847 RVA: 0x0071054D File Offset: 0x0070E74D
			public IKSolverVR.VirtualBone INOJPHCMMNH()
			{
				return this.bones[6];
			}

			// Token: 0x0600FD50 RID: 64848 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void BAGCLANMBIE(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD51 RID: 64849 RVA: 0x007208F0 File Offset: 0x0071EAF0
			public void EDAGNKNOBKP(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Leg[] OJBMKLFCOLF, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.EIGMKECIOMD(EPBCOPFCIBA);
				if (this.maxRootAngle < 180f)
				{
					Vector3 vector = Quaternion.Inverse(OGDIHBAHOEK.solverRotation) * this.faceDirection;
					float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
					float angle = 0f;
					float num2 = 25f;
					if (num > num2)
					{
						angle = num - num2;
					}
					if (num < -num2)
					{
						angle = num + num2;
					}
					OGDIHBAHOEK.solverRotation = Quaternion.AngleAxis(angle, Vector3.up) * OGDIHBAHOEK.solverRotation;
				}
				Vector3 solverPosition = this.pelvis.solverPosition;
				this.MNCBMKPHHHI(OJBMKLFCOLF, this.headDeltaPosition, this.pelvisDeltaRotation, 1f);
				IKSolverVR.VirtualBone.PCIJGNKLFCA(this.bones, Vector3.Lerp(this.pelvis.solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 1f, 1f, 1, base.mag);
				this.FBHHMJHOBGG(this.bones, 0, 2, this.chestTargetRotation, this.chestClampWeight, false, this.chestRotationWeight);
				this.GPGHGEJGFKC(OJBMKLFCOLF, false, false, Vector3.zero, 1f);
				IKSolverVR.VirtualBone.PCIJGNKLFCA(this.bones, Vector3.Lerp(this.pelvis.solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 1f, 1f, 1, base.mag);
				this.FBHHMJHOBGG(this.bones, 3, this.headIndex, this.headRotation, this.headClampWeight, true, 1f);
				this.JJHHOOCHCEE();
			}

			// Token: 0x0600FD52 RID: 64850 RVA: 0x00720AB8 File Offset: 0x0071ECB8
			private void LFOOIGBKKMA(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.BKGBODPDFEC(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.LONJEHLOIEI(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.LGKPLILBAAC() * Vector3.right, Vector3.up) + this.ABNMDBDKGHB() * Vector3.forward;
			}

			// Token: 0x0600FD53 RID: 64851 RVA: 0x00720B2C File Offset: 0x0071ED2C
			public override void KJPOIAKPAGJ()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD54 RID: 64852 RVA: 0x00720B7C File Offset: 0x0071ED7C
			public void MEOFBLIOKII(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.GBKKNIBPAIE().solverPosition + (this.headPosition + IGFJOGKFADM - this.MJGDBHFBGFD().solverPosition) * OICADHEPMLH * (649f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.MFLAOMPOOFC(OJBMKLFCOLF, vector, JJDGIMPNKAG, 4) : vector);
			}

			// Token: 0x0600FD55 RID: 64853 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone MGFPMBDDEHP()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD56 RID: 64854 RVA: 0x00720BE8 File Offset: 0x0071EDE8
			public void IJCBDIPCNEM(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.FLNDNKEGJLB().solverPosition + (this.headPosition + IGFJOGKFADM - this.IGJOLMNGCCG().solverPosition) * OICADHEPMLH * (388f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.CBDFENCKEGF(OJBMKLFCOLF, vector, JJDGIMPNKAG, 1) : vector);
			}

			// Token: 0x0600FD57 RID: 64855 RVA: 0x00720C54 File Offset: 0x0071EE54
			private void LLCAENIFBAF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 1239f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 0)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 0);
				float num2 = LAKFAELCPGI ? (1469f / (float)num) : 16f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 0; i += 0)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 1960f, 88f);
					}
					IKSolverVR.VirtualBone.OGIDCPCFPJO(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD58 RID: 64856 RVA: 0x00720CF4 File Offset: 0x0071EEF4
			private Vector3 OHBFAAHFDJN(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					for (int i = 1; i < OJBMKLFCOLF.Length; i++)
					{
						IKSolverVR.Leg leg = OJBMKLFCOLF[i];
						leg.currentMag = Vector3.Distance(leg.DPGBNEKIHMP().solverPosition, leg.lastBone.solverPosition);
					}
				}
				for (int j = 1; j < KBBDBNADGJH; j++)
				{
					foreach (IKSolverVR.Leg leg2 in OJBMKLFCOLF)
					{
						Vector3 b = KKADHNONFCP - this.FLNDNKEGJLB().solverPosition;
						Vector3 vector = leg2.thigh.solverPosition + b;
						Vector3 vector2 = vector - leg2.position;
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.position + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD59 RID: 64857 RVA: 0x0071E47E File Offset: 0x0071C67E
			public Quaternion LGKPLILBAAC()
			{
				return this.<anchorRotation>k__BackingField;
			}

			// Token: 0x0600FD5A RID: 64858 RVA: 0x00712672 File Offset: 0x00710872
			private IKSolverVR.VirtualBone PCLHPDLMBEM()
			{
				return this.bones[8];
			}

			// Token: 0x0600FD5B RID: 64859 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone JLPFFJEOIIA()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD5C RID: 64860 RVA: 0x00720DDC File Offset: 0x0071EFDC
			private void HIHKFNJKIJE(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.FANNJOLBCGP(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.BKEEECFPMJL(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.FADKDFHNLJP() * Vector3.right, Vector3.up) + this.FADKDFHNLJP() * Vector3.forward;
			}

			// Token: 0x0600FD5D RID: 64861 RVA: 0x00720E50 File Offset: 0x0071F050
			private void KIAMJMNHHPA()
			{
				if (this.pelvisPositionWeight > 1961f)
				{
					Quaternion solverRotation = this.head.solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.LHOJGGKNONH().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.LGKPLILBAAC() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 1, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1056f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 7, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 137f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 8, 7, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 988f);
					}
					else
					{
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 0, 0, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1488f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 8, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 486f);
					}
					this.PEIPGPHPEKK().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD5E RID: 64862 RVA: 0x00720FD0 File Offset: 0x0071F1D0
			private Vector3 FLCPLAAMDHI(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					foreach (IKSolverVR.Leg leg in OJBMKLFCOLF)
					{
						leg.currentMag = Vector3.Distance(leg.thigh.solverPosition, leg.lastBone.solverPosition);
					}
				}
				for (int j = 0; j < KBBDBNADGJH; j++)
				{
					foreach (IKSolverVR.Leg leg2 in OJBMKLFCOLF)
					{
						Vector3 b = KKADHNONFCP - this.pelvis.solverPosition;
						Vector3 vector = leg2.thigh.solverPosition + b;
						Vector3 vector2 = vector - leg2.position;
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.position + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD5F RID: 64863 RVA: 0x007210B8 File Offset: 0x0071F2B8
			public virtual void EMEFFIMEBMA()
			{
				if (this.headTarget != null)
				{
					this.CKNLKNAELAN(this.headTarget.position);
					this.GHIHGPPPGEA(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.CNCMHGBBENF(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.head.solverPosition, this.PKNJLMIKAKA(), this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.CHKOLJKNIIF().solverRotation, this.AMOLIIMPANF(), this.rotationWeight);
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x0600FD7A RID: 64890 RVA: 0x0071EE89 File Offset: 0x0071D089
			// (set) Token: 0x0600FD60 RID: 64864 RVA: 0x0071EB9D File Offset: 0x0071CD9D
			public Vector3 IKPositionPelvis { get; private set; }

			// Token: 0x0600FD61 RID: 64865 RVA: 0x00721158 File Offset: 0x0071F358
			public virtual void COKOHBHJBIE()
			{
				if (this.headTarget != null)
				{
					this.NGOEAJPKIMF(this.headTarget.position);
					this.GHIHGPPPGEA(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.HBKDMPNALGD(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.PCLADIDNPAE().solverPosition, this.IKPositionHead, this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.PEIPGPHPEKK().solverRotation, this.LAEKOJFHBKB(), this.rotationWeight);
			}

			// Token: 0x0600FD62 RID: 64866 RVA: 0x007211F8 File Offset: 0x0071F3F8
			public virtual void ECLNBCLFDPA()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD63 RID: 64867 RVA: 0x00721248 File Offset: 0x0071F448
			public virtual void CFMMMOFBBDK()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD64 RID: 64868 RVA: 0x00721298 File Offset: 0x0071F498
			public virtual void HLHKIHGFKGD()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD65 RID: 64869 RVA: 0x007212E8 File Offset: 0x0071F4E8
			private Vector3 BACMPCIBCID(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					foreach (IKSolverVR.Leg leg in OJBMKLFCOLF)
					{
						leg.currentMag = Vector3.Distance(leg.thigh.solverPosition, leg.lastBone.solverPosition);
					}
				}
				for (int j = 1; j < KBBDBNADGJH; j++)
				{
					for (int i = 1; i < OJBMKLFCOLF.Length; i += 0)
					{
						IKSolverVR.Leg leg2 = OJBMKLFCOLF[i];
						Vector3 b = KKADHNONFCP - this.LHOJGGKNONH().solverPosition;
						Vector3 vector = leg2.OJCPKFMBJJI().solverPosition + b;
						Vector3 vector2 = vector - leg2.JAFAPNHCPMO();
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.JAFAPNHCPMO() + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD66 RID: 64870 RVA: 0x0071E47E File Offset: 0x0071C67E
			public Quaternion ABNMDBDKGHB()
			{
				return this.<anchorRotation>k__BackingField;
			}

			// Token: 0x0600FD67 RID: 64871 RVA: 0x007213D0 File Offset: 0x0071F5D0
			public virtual void MPCNBAEMAJK()
			{
				this.headPosition += this.headPositionOffset;
				this.headPosition.y = Math.Max(this.rootPosition.y + 1498f, this.headPosition.y);
				this.headRotation = this.headRotationOffset * this.headRotation;
				this.headDeltaPosition = this.headPosition - this.CJBAOKIPEIE().solverPosition;
				this.pelvisDeltaRotation = JEEPKFCFCLI.AADCPGNPHHC(this.GBKKNIBPAIE().solverRotation, this.headRotation * this.pelvisRelativeRotation);
				this.GPMIDNDALCH(this.headRotation * this.anchorRelativeToHead);
			}

			// Token: 0x0600FD68 RID: 64872 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void DDHKDPAGDCH(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD69 RID: 64873 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void GHIHGPPPGEA(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD6A RID: 64874 RVA: 0x0071EE89 File Offset: 0x0071D089
			public Vector3 FFFDEDKCEAO()
			{
				return this.<IKPositionPelvis>k__BackingField;
			}

			// Token: 0x0600FD6B RID: 64875 RVA: 0x00721494 File Offset: 0x0071F694
			public virtual void LEEKLBPCPPA()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD6C RID: 64876 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion INMCMKOCPMI()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD6D RID: 64877 RVA: 0x007214E4 File Offset: 0x0071F6E4
			public virtual void LNLKCGMHEEN(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				PKAHGJNELGJ[this.index] = this.bones[1].solverPosition;
				KJAEHPCNAOM[this.index] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 0] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 8] = this.bones[0].solverRotation;
				if (this.hasNeck)
				{
					KJAEHPCNAOM[this.index + 6] = this.bones[3].solverRotation;
				}
				KJAEHPCNAOM[this.index + 5] = this.bones[this.headIndex].solverRotation;
			}

			// Token: 0x0600FD6E RID: 64878 RVA: 0x0071E476 File Offset: 0x0071C676
			public Quaternion DGPMMMDBEOE()
			{
				return this.<IKRotationHead>k__BackingField;
			}

			// Token: 0x0600FD6F RID: 64879 RVA: 0x007215A4 File Offset: 0x0071F7A4
			private Vector3 CBDFENCKEGF(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					for (int i = 1; i < OJBMKLFCOLF.Length; i++)
					{
						IKSolverVR.Leg leg = OJBMKLFCOLF[i];
						leg.currentMag = Vector3.Distance(leg.DPGBNEKIHMP().solverPosition, leg.EEBNKGMHHGL().solverPosition);
					}
				}
				for (int j = 0; j < KBBDBNADGJH; j += 0)
				{
					for (int i = 1; i < OJBMKLFCOLF.Length; i += 0)
					{
						IKSolverVR.Leg leg2 = OJBMKLFCOLF[i];
						Vector3 b = KKADHNONFCP - this.CNMJOEMADKJ().solverPosition;
						Vector3 vector = leg2.DPGBNEKIHMP().solverPosition + b;
						Vector3 vector2 = vector - leg2.position;
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.position + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD70 RID: 64880 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone HCEMJAKDAKE()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD71 RID: 64881 RVA: 0x0072168C File Offset: 0x0071F88C
			private void AGNAGBNDKGO()
			{
				if (this.pelvisPositionWeight > 381f)
				{
					Quaternion solverRotation = this.CHKOLJKNIIF().solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.LHOJGGKNONH().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.FADKDFHNLJP() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 0, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1377f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1916f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 4, 4, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 969f);
					}
					else
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 394f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 0, 3, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 663f);
					}
					this.CJBAOKIPEIE().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD72 RID: 64882 RVA: 0x0072180C File Offset: 0x0071FA0C
			public void ELBNKKIHMII(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.CNMJOEMADKJ().solverPosition + (this.headPosition + IGFJOGKFADM - this.MJGDBHFBGFD().solverPosition) * OICADHEPMLH * (132f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.MFLAOMPOOFC(OJBMKLFCOLF, vector, JJDGIMPNKAG, 0) : vector);
			}

			// Token: 0x0600FD73 RID: 64883 RVA: 0x00721878 File Offset: 0x0071FA78
			private void JEONKAIBBJM(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.HMOPBBLLFPD(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.BKEEECFPMJL(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.FADKDFHNLJP() * Vector3.right, Vector3.up) + this.anchorRotation * Vector3.forward;
			}

			// Token: 0x0600FD74 RID: 64884 RVA: 0x007218EC File Offset: 0x0071FAEC
			public void MBOANADPDNK(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.CNMJOEMADKJ().solverPosition + (this.headPosition + IGFJOGKFADM - this.NECGLEAGFGK().solverPosition) * OICADHEPMLH * (718f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.CBDFENCKEGF(OJBMKLFCOLF, vector, JJDGIMPNKAG, 2) : vector);
			}

			// Token: 0x0600FD75 RID: 64885 RVA: 0x00721958 File Offset: 0x0071FB58
			public override void HJADALPNANN()
			{
				if (this.headTarget != null)
				{
					this.IKPositionHead = this.headTarget.position;
					this.IKRotationHead = this.headTarget.rotation;
				}
				if (this.pelvisTarget != null)
				{
					this.IKPositionPelvis = this.pelvisTarget.position;
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.head.solverPosition, this.IKPositionHead, this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.head.solverRotation, this.IKRotationHead, this.rotationWeight);
			}

			// Token: 0x0600FD76 RID: 64886 RVA: 0x0071E6F8 File Offset: 0x0071C8F8
			public Vector3 OILLFNPPOGN()
			{
				return this.<IKPositionHead>k__BackingField;
			}

			// Token: 0x0600FD77 RID: 64887 RVA: 0x007219F8 File Offset: 0x0071FBF8
			public virtual void LDBFGJFKPFJ(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				PKAHGJNELGJ[this.index] = this.bones[0].solverPosition;
				KJAEHPCNAOM[this.index] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.bones[1].solverRotation;
				KJAEHPCNAOM[this.index + 8] = this.bones[7].solverRotation;
				if (this.hasNeck)
				{
					KJAEHPCNAOM[this.index + 8] = this.bones[6].solverRotation;
				}
				KJAEHPCNAOM[this.index + 2] = this.bones[this.headIndex].solverRotation;
			}

			// Token: 0x0600FD78 RID: 64888 RVA: 0x00721AB8 File Offset: 0x0071FCB8
			public override void GJJCGAEBILD(ref Vector3[] PKAHGJNELGJ, ref Quaternion[] KJAEHPCNAOM)
			{
				PKAHGJNELGJ[this.index] = this.bones[0].solverPosition;
				KJAEHPCNAOM[this.index] = this.bones[0].solverRotation;
				KJAEHPCNAOM[this.index + 1] = this.bones[1].solverRotation;
				KJAEHPCNAOM[this.index + 2] = this.bones[2].solverRotation;
				if (this.hasNeck)
				{
					KJAEHPCNAOM[this.index + 3] = this.bones[3].solverRotation;
				}
				KJAEHPCNAOM[this.index + 4] = this.bones[this.headIndex].solverRotation;
			}

			// Token: 0x0600FD79 RID: 64889 RVA: 0x00721B78 File Offset: 0x0071FD78
			public void CIFPALFMPGO(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Leg[] OJBMKLFCOLF, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.OINELHKNNNA(EPBCOPFCIBA);
				if (this.maxRootAngle < 1377f)
				{
					Vector3 vector = Quaternion.Inverse(OGDIHBAHOEK.solverRotation) * this.faceDirection;
					float num = Mathf.Atan2(vector.x, vector.z) * 1531f;
					float angle = 456f;
					float num2 = 640f;
					if (num > num2)
					{
						angle = num - num2;
					}
					if (num < -num2)
					{
						angle = num + num2;
					}
					OGDIHBAHOEK.solverRotation = Quaternion.AngleAxis(angle, Vector3.up) * OGDIHBAHOEK.solverRotation;
				}
				Vector3 solverPosition = this.CNMJOEMADKJ().solverPosition;
				this.MNINPODHGJE(OJBMKLFCOLF, this.headDeltaPosition, this.pelvisDeltaRotation, 444f);
				IKSolverVR.VirtualBone.KPDILOAPDMF(this.bones, Vector3.Lerp(this.GBKKNIBPAIE().solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 738f, 1707f, 1, base.mag);
				this.DOOFNGFEOLC(this.bones, 0, 6, this.chestTargetRotation, this.chestClampWeight, false, this.chestRotationWeight);
				this.MEOFBLIOKII(OJBMKLFCOLF, true, true, Vector3.zero, 715f);
				IKSolverVR.VirtualBone.HPNILLAILHC(this.bones, Vector3.Lerp(this.LHOJGGKNONH().solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 509f, 788f, 0, base.mag);
				this.MDAGJHEEHMM(this.bones, 3, this.headIndex, this.headRotation, this.headClampWeight, true, 1098f);
				this.GLIAAKMFCLB();
			}

			// Token: 0x0600FD7B RID: 64891 RVA: 0x00721D40 File Offset: 0x0071FF40
			private void FANNJOLBCGP(ref Quaternion IDHNMJGHACM, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				Quaternion rotation = Quaternion.Inverse(this.FADKDFHNLJP());
				Vector3 vector = rotation * (EPBCOPFCIBA[0].HJLDBBHIGIC() - this.headPosition);
				Vector3 vector2 = rotation * (EPBCOPFCIBA[0].MNGOALIMNCD() - this.headPosition);
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 259f;
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, forward);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 190f;
				lhs = Quaternion.FromToRotation(Vector3.up, this.anchorRotation * up);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
			}

			// Token: 0x0600FD7D RID: 64893 RVA: 0x00721E98 File Offset: 0x00720098
			private void ELIOICEABEA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 808f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 0 - BEJEOIOIJHP;
				if (num < 0)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 3);
				float num2 = LAKFAELCPGI ? (165f / (float)num) : 1416f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 0; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 1353f, 149f);
					}
					IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD7E RID: 64894 RVA: 0x00721F38 File Offset: 0x00720138
			public void OALIFIGFCIJ(IKSolverVR.VirtualBone OGDIHBAHOEK, IKSolverVR.Leg[] OJBMKLFCOLF, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.HIHKFNJKIJE(EPBCOPFCIBA);
				if (this.maxRootAngle < 1665f)
				{
					Vector3 vector = Quaternion.Inverse(OGDIHBAHOEK.solverRotation) * this.faceDirection;
					float num = Mathf.Atan2(vector.x, vector.z) * 1496f;
					float angle = 1916f;
					float num2 = 211f;
					if (num > num2)
					{
						angle = num - num2;
					}
					if (num < -num2)
					{
						angle = num + num2;
					}
					OGDIHBAHOEK.solverRotation = Quaternion.AngleAxis(angle, Vector3.up) * OGDIHBAHOEK.solverRotation;
				}
				Vector3 solverPosition = this.pelvis.solverPosition;
				this.MNCBMKPHHHI(OJBMKLFCOLF, this.headDeltaPosition, this.pelvisDeltaRotation, 1339f);
				IKSolverVR.VirtualBone.KPDILOAPDMF(this.bones, Vector3.Lerp(this.LHOJGGKNONH().solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 886f, 563f, 1, base.mag);
				this.DOOFNGFEOLC(this.bones, 0, 8, this.chestTargetRotation, this.chestClampWeight, true, this.chestRotationWeight);
				this.OHFOHJNPDFF(OJBMKLFCOLF, false, true, Vector3.zero, 1736f);
				IKSolverVR.VirtualBone.PCIJGNKLFCA(this.bones, Vector3.Lerp(this.FLNDNKEGJLB().solverPosition, solverPosition, this.maintainPelvisPosition) + this.pelvisPositionOffset - this.chestPositionOffset, this.headPosition - this.chestPositionOffset, 961f, 1928f, 0, base.mag);
				this.EKHOOOHBMPI(this.bones, 5, this.headIndex, this.headRotation, this.headClampWeight, true, 1179f);
				this.ADNALENMIKG();
			}

			// Token: 0x0600FD7F RID: 64895 RVA: 0x00722100 File Offset: 0x00720300
			private void NMJOLLBMHIH(ref Quaternion IDHNMJGHACM, IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				Quaternion rotation = Quaternion.Inverse(this.FADKDFHNLJP());
				Vector3 vector = rotation * (EPBCOPFCIBA[0].KPMHCDABDBG() - this.headPosition);
				Vector3 vector2 = rotation * (EPBCOPFCIBA[0].KPMHCDABDBG() - this.headPosition);
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 1115f;
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, forward);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 4f;
				lhs = Quaternion.FromToRotation(Vector3.up, this.LGKPLILBAAC() * up);
				IDHNMJGHACM = lhs * IDHNMJGHACM;
			}

			// Token: 0x0600FD80 RID: 64896 RVA: 0x00722258 File Offset: 0x00720458
			private void MDAGJHEEHMM(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 1704f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 0 - BEJEOIOIJHP;
				if (num < 0)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 4);
				float num2 = LAKFAELCPGI ? (1080f / (float)num) : 1123f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 1; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 758f, 1897f);
					}
					IKSolverVR.VirtualBone.FCBMHEPICBI(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD81 RID: 64897 RVA: 0x007222F8 File Offset: 0x007204F8
			private void EIGMKECIOMD(IKSolverVR.Arm[] EPBCOPFCIBA)
			{
				this.chestTargetRotation = this.headRotation * this.chestRelativeRotation;
				this.HMOPBBLLFPD(ref this.chestTargetRotation, EPBCOPFCIBA);
				this.KDIGFGNMNJE(ref this.chestTargetRotation);
				this.faceDirection = Vector3.Cross(this.anchorRotation * Vector3.right, Vector3.up) + this.anchorRotation * Vector3.forward;
			}

			// Token: 0x0600FD82 RID: 64898 RVA: 0x0072236C File Offset: 0x0072056C
			private Vector3 LOAPKNPMJED(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 KKADHNONFCP, bool JJDGIMPNKAG, int KBBDBNADGJH = 2)
			{
				if (JJDGIMPNKAG)
				{
					foreach (IKSolverVR.Leg leg in OJBMKLFCOLF)
					{
						leg.currentMag = Vector3.Distance(leg.DPGBNEKIHMP().solverPosition, leg.EEBNKGMHHGL().solverPosition);
					}
				}
				for (int j = 1; j < KBBDBNADGJH; j++)
				{
					for (int i = 0; i < OJBMKLFCOLF.Length; i += 0)
					{
						IKSolverVR.Leg leg2 = OJBMKLFCOLF[i];
						Vector3 b = KKADHNONFCP - this.CNMJOEMADKJ().solverPosition;
						Vector3 vector = leg2.OJCPKFMBJJI().solverPosition + b;
						Vector3 vector2 = vector - leg2.position;
						float maxLength = JJDGIMPNKAG ? leg2.currentMag : leg2.mag;
						Vector3 a = leg2.position + Vector3.ClampMagnitude(vector2, maxLength);
						KKADHNONFCP += a - vector;
					}
				}
				return KKADHNONFCP;
			}

			// Token: 0x0600FD83 RID: 64899 RVA: 0x00722454 File Offset: 0x00720654
			public virtual void CANNKLIMMAH()
			{
				this.pelvisPositionOffset = Vector3.zero;
				this.chestPositionOffset = Vector3.zero;
				this.headPositionOffset = Vector3.zero;
				this.pelvisRotationOffset = Quaternion.identity;
				this.chestRotationOffset = Quaternion.identity;
				this.headRotationOffset = Quaternion.identity;
			}

			// Token: 0x0600FD84 RID: 64900 RVA: 0x007224A4 File Offset: 0x007206A4
			private void DOOFNGFEOLC(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 540f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 0 - BEJEOIOIJHP;
				if (num < 1)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 7);
				float num2 = LAKFAELCPGI ? (1426f / (float)num) : 470f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 1; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 1712f, 413f);
					}
					IKSolverVR.VirtualBone.OGIDCPCFPJO(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD85 RID: 64901 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone CNMJOEMADKJ()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD86 RID: 64902 RVA: 0x00722544 File Offset: 0x00720744
			private void CNBMBFKFPFK()
			{
				if (this.pelvisPositionWeight > 49f)
				{
					Quaternion solverRotation = this.PCLADIDNPAE().solverRotation;
					Vector3 b = (this.OHHNLAONHNB() + this.pelvisPositionOffset - this.LHOJGGKNONH().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i++)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.BHHKLFCDPGJ() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 1, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1159f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 4, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 96f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 5, 7, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 416f);
					}
					else
					{
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 418f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 7, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1821f);
					}
					this.PCLADIDNPAE().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD87 RID: 64903 RVA: 0x007226C4 File Offset: 0x007208C4
			protected virtual void KPBKLPKKPAO(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 6];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 8];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 8];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 6];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 7];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[0].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 5 : 3];
					this.headIndex = (DPNHFBMDCGL ? 2 : 5);
					this.bones[0] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[2] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[2] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[1];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.IKPositionHead = vector2;
					this.GHIHGPPPGEA(quaternion3);
					this.CNCMHGBBENF(vector);
				}
				this.bones[1].APAEBLFHDBL(vector, quaternion);
				this.bones[0].NFIGHJJKDLL(mgaleajogpl, phkiohibnpa);
				this.bones[1].NFIGHJJKDLL(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[8].APAEBLFHDBL(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].INELKGAHFBJ(vector2, quaternion3);
			}

			// Token: 0x0600FD88 RID: 64904 RVA: 0x007228D0 File Offset: 0x00720AD0
			private void NOGCEOMDCMH(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.IGJOLMNGCCG().solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 4);
				Quaternion lhs = (OICADHEPMLH >= 1110f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.KAFHDONFFNP(this.bones, 0, this.LHOJGGKNONH().solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.JFLILFDAKIA().solverPosition - solverPosition;
				Vector3 a = this.BHHKLFCDPGJ() * Vector3.forward;
				a.y = 142f;
				float d = JJGHJJONFIA.y * 896f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.MFLAOMPOOFC(OJBMKLFCOLF, this.GBKKNIBPAIE().solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, true, 3));
			}

			// Token: 0x0600FD89 RID: 64905 RVA: 0x0071EB9D File Offset: 0x0071CD9D
			private void HBKDMPNALGD(Vector3 DCCPCBLODIG)
			{
				this.<IKPositionPelvis>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD8A RID: 64906 RVA: 0x007229D8 File Offset: 0x00720BD8
			private void KJCFKMKJEKO()
			{
				if (this.pelvisPositionWeight > 1369f)
				{
					Quaternion solverRotation = this.CJBAOKIPEIE().solverRotation;
					Vector3 b = (this.IKPositionPelvis + this.pelvisPositionOffset - this.LHOJGGKNONH().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.FADKDFHNLJP() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 0, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 906f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 6, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1086f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 5, 7, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 581f);
					}
					else
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 0, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 836f);
						IKSolverVR.VirtualBone.MEFEBBMLGEJ(this.bones, 1, 7, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 885f);
					}
					this.PCLADIDNPAE().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD8B RID: 64907 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void BDIKAAPABIB(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD8C RID: 64908 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone PCLADIDNPAE()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD8D RID: 64909 RVA: 0x0071EE89 File Offset: 0x0071D089
			public Vector3 OHHNLAONHNB()
			{
				return this.<IKPositionPelvis>k__BackingField;
			}

			// Token: 0x0600FD8E RID: 64910 RVA: 0x0070FEAF File Offset: 0x0070E0AF
			public IKSolverVR.VirtualBone LHOJGGKNONH()
			{
				return this.bones[1];
			}

			// Token: 0x0600FD8F RID: 64911 RVA: 0x00722B58 File Offset: 0x00720D58
			private void PFDKBFMOHJB()
			{
				if (this.pelvisPositionWeight > 621f)
				{
					Quaternion solverRotation = this.head.solverRotation;
					Vector3 b = (this.LEBJDABFHFN() + this.pelvisPositionOffset - this.CNMJOEMADKJ().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 1; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.BHHKLFCDPGJ() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 1, 0, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1775f);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 1, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 431f);
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 0, 5, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1549f);
					}
					else
					{
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 1, 0, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1462f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 2, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1487f);
					}
					this.NECGLEAGFGK().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD90 RID: 64912 RVA: 0x00722CD8 File Offset: 0x00720ED8
			private void FBHHMJHOBGG(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int BEJEOIOIJHP, int GLJFGCPGFEC, Quaternion BBPPDJKLPNL, float NAPPHEPPHKD, bool LAKFAELCPGI, float OICADHEPMLH)
			{
				if (OICADHEPMLH <= 0f)
				{
					return;
				}
				if (CKAJJHFIFBL.Length == 0)
				{
					return;
				}
				int num = GLJFGCPGFEC + 1 - BEJEOIOIJHP;
				if (num < 1)
				{
					return;
				}
				Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[GLJFGCPGFEC].solverRotation, BBPPDJKLPNL);
				quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, NAPPHEPPHKD, 2);
				float num2 = LAKFAELCPGI ? (1f / (float)num) : 0f;
				for (int i = BEJEOIOIJHP; i < GLJFGCPGFEC + 1; i++)
				{
					if (!LAKFAELCPGI)
					{
						num2 = Mathf.Clamp((float)((i - BEJEOIOIJHP + 1) / num), 0f, 1f);
					}
					IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, i, CKAJJHFIFBL[i].solverPosition, Quaternion.Slerp(Quaternion.identity, quaternion, num2 * OICADHEPMLH));
				}
			}

			// Token: 0x0600FD91 RID: 64913 RVA: 0x00722D78 File Offset: 0x00720F78
			protected virtual void NAILJALFMGM(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 7];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 6];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 0];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[1].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 7 : 1];
					this.headIndex = (DPNHFBMDCGL ? 3 : 7);
					this.bones[1] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[5] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[0];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.IKPositionHead = vector2;
					this.IKRotationHead = quaternion3;
					this.IKPositionPelvis = vector;
				}
				this.bones[0].INELKGAHFBJ(vector, quaternion);
				this.bones[0].APAEBLFHDBL(mgaleajogpl, phkiohibnpa);
				this.bones[6].NFIGHJJKDLL(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[2].APAEBLFHDBL(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].INELKGAHFBJ(vector2, quaternion3);
			}

			// Token: 0x0600FD92 RID: 64914 RVA: 0x0071E30B File Offset: 0x0071C50B
			private void FMMEHEKPKJJ(Quaternion DCCPCBLODIG)
			{
				this.<IKRotationHead>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600FD93 RID: 64915 RVA: 0x00722F84 File Offset: 0x00721184
			private void NDMKHNNEBNA(IKSolverVR.Leg[] OJBMKLFCOLF, Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM, float OICADHEPMLH)
			{
				Vector3 solverPosition = this.head.solverPosition;
				MDAFOPGGGEM = JEEPKFCFCLI.DHGGOAPDLJG(MDAFOPGGGEM, this.chestClampWeight, 7);
				Quaternion lhs = (OICADHEPMLH >= 917f) ? this.pelvisRotationOffset : Quaternion.Slerp(Quaternion.identity, this.pelvisRotationOffset, OICADHEPMLH);
				IKSolverVR.VirtualBone.FCBMHEPICBI(this.bones, 1, this.pelvis.solverPosition, lhs * Quaternion.Slerp(Quaternion.identity, MDAFOPGGGEM, OICADHEPMLH * this.bodyRotStiffness));
				JJGHJJONFIA -= this.PEIPGPHPEKK().solverPosition - solverPosition;
				Vector3 a = this.ABNMDBDKGHB() * Vector3.forward;
				a.y = 1268f;
				float d = JJGHJJONFIA.y * 1295f * this.headHeight;
				JJGHJJONFIA += a * d;
				base.DDOIOBPACPC(this.OHBFAAHFDJN(OJBMKLFCOLF, this.pelvis.solverPosition + JJGHJJONFIA * OICADHEPMLH * this.bodyPosStiffness, true, 0));
			}

			// Token: 0x0600FD94 RID: 64916 RVA: 0x0072308C File Offset: 0x0072128C
			protected override void POOFNALOJAE(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 1];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 2];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 2];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 3];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 3];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 4];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[0].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 5 : 4];
					this.headIndex = (DPNHFBMDCGL ? 4 : 3);
					this.bones[0] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[2] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[3] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[0];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.IKPositionHead = vector2;
					this.IKRotationHead = quaternion3;
					this.IKPositionPelvis = vector;
				}
				this.bones[0].INELKGAHFBJ(vector, quaternion);
				this.bones[1].INELKGAHFBJ(mgaleajogpl, phkiohibnpa);
				this.bones[2].INELKGAHFBJ(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[3].INELKGAHFBJ(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].INELKGAHFBJ(vector2, quaternion3);
			}

			// Token: 0x0600FD95 RID: 64917 RVA: 0x0071E691 File Offset: 0x0071C891
			public IKSolverVR.VirtualBone NECGLEAGFGK()
			{
				return this.bones[this.headIndex];
			}

			// Token: 0x0600FD96 RID: 64918 RVA: 0x00723298 File Offset: 0x00721498
			public void OHFOHJNPDFF(IKSolverVR.Leg[] OJBMKLFCOLF, bool PPILNELAKAL, bool JJDGIMPNKAG, Vector3 IGFJOGKFADM, float OICADHEPMLH)
			{
				Vector3 vector = this.FLNDNKEGJLB().solverPosition + (this.headPosition + IGFJOGKFADM - this.JFLILFDAKIA().solverPosition) * OICADHEPMLH * (254f - this.pelvisPositionWeight);
				base.DDOIOBPACPC(PPILNELAKAL ? this.OHBFAAHFDJN(OJBMKLFCOLF, vector, JJDGIMPNKAG, 3) : vector);
			}

			// Token: 0x0600FD97 RID: 64919 RVA: 0x00723304 File Offset: 0x00721504
			private void JLBPOOAOMBE()
			{
				if (this.pelvisPositionWeight > 1470f)
				{
					Quaternion solverRotation = this.NECGLEAGFGK().solverRotation;
					Vector3 b = (this.LEBJDABFHFN() + this.pelvisPositionOffset - this.LHOJGGKNONH().solverPosition) * this.pelvisPositionWeight;
					IKSolverVR.VirtualBone[] bones = this.bones;
					for (int i = 0; i < bones.Length; i += 0)
					{
						bones[i].solverPosition += b;
					}
					Vector3 doinjmpnhki = this.ABNMDBDKGHB() * Vector3.right;
					if (this.hasNeck)
					{
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 1, 0, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 830f);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 0, 8, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1031f);
						IKSolverVR.VirtualBone.JABDCLLHAHF(this.bones, 5, 2, this.bones.Length - 1, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1467f);
					}
					else
					{
						IKSolverVR.VirtualBone.FMIIOIJAFKB(this.bones, 0, 1, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1630f);
						IKSolverVR.VirtualBone.DOILCBGMMEJ(this.bones, 0, 5, this.bones.Length - 0, this.headPosition, doinjmpnhki, this.pelvisPositionWeight * 1884f);
					}
					this.NECGLEAGFGK().solverRotation = solverRotation;
				}
			}

			// Token: 0x0600FD98 RID: 64920 RVA: 0x00723484 File Offset: 0x00721684
			protected virtual void JOFOJOCACLF(Vector3[] FCJKGIPEIKP, Quaternion[] MKEHLAMPPKB, bool DPNHFBMDCGL, bool CJCJIGDKDIP, bool DCEANIANBOD, int CIGENDAIJKL, int CLBPBJGLHEE)
			{
				Vector3 vector = FCJKGIPEIKP[CLBPBJGLHEE];
				Quaternion quaternion = MKEHLAMPPKB[CLBPBJGLHEE];
				Vector3 mgaleajogpl = FCJKGIPEIKP[CLBPBJGLHEE + 1];
				Quaternion phkiohibnpa = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				Vector3 mgaleajogpl2 = FCJKGIPEIKP[CLBPBJGLHEE + 3];
				Quaternion quaternion2 = MKEHLAMPPKB[CLBPBJGLHEE + 4];
				Vector3 mgaleajogpl3 = FCJKGIPEIKP[CLBPBJGLHEE + 5];
				Quaternion phkiohibnpa2 = MKEHLAMPPKB[CLBPBJGLHEE + 4];
				Vector3 vector2 = FCJKGIPEIKP[CLBPBJGLHEE + 4];
				Quaternion quaternion3 = MKEHLAMPPKB[CLBPBJGLHEE + 0];
				if (!this.initiated)
				{
					this.hasNeck = DPNHFBMDCGL;
					this.headHeight = vector2.y - FCJKGIPEIKP[0].y;
					this.bones = new IKSolverVR.VirtualBone[DPNHFBMDCGL ? 3 : 2];
					this.headIndex = (DPNHFBMDCGL ? 4 : 0);
					this.bones[1] = new IKSolverVR.VirtualBone(vector, quaternion);
					this.bones[0] = new IKSolverVR.VirtualBone(mgaleajogpl, phkiohibnpa);
					this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl2, quaternion2);
					if (DPNHFBMDCGL)
					{
						this.bones[1] = new IKSolverVR.VirtualBone(mgaleajogpl3, phkiohibnpa2);
					}
					this.bones[this.headIndex] = new IKSolverVR.VirtualBone(vector2, quaternion3);
					this.pelvisRotationOffset = Quaternion.identity;
					this.chestRotationOffset = Quaternion.identity;
					this.headRotationOffset = Quaternion.identity;
					this.anchorRelativeToHead = Quaternion.Inverse(quaternion3) * MKEHLAMPPKB[1];
					this.pelvisRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion;
					this.chestRelativeRotation = Quaternion.Inverse(quaternion3) * quaternion2;
					this.faceDirection = MKEHLAMPPKB[0] * Vector3.forward;
					this.NGOEAJPKIMF(vector2);
					this.NBCHAGMLJCG(quaternion3);
					this.IKPositionPelvis = vector;
				}
				this.bones[0].HCHNKNCJJEO(vector, quaternion);
				this.bones[0].HCHNKNCJJEO(mgaleajogpl, phkiohibnpa);
				this.bones[4].HCHNKNCJJEO(mgaleajogpl2, quaternion2);
				if (DPNHFBMDCGL)
				{
					this.bones[1].NFIGHJJKDLL(mgaleajogpl3, phkiohibnpa2);
				}
				this.bones[this.headIndex].APAEBLFHDBL(vector2, quaternion3);
			}

			// Token: 0x0600FD99 RID: 64921 RVA: 0x0070FE22 File Offset: 0x0070E022
			public IKSolverVR.VirtualBone GBKKNIBPAIE()
			{
				return this.bones[0];
			}

			// Token: 0x0600FD9A RID: 64922 RVA: 0x00711CA6 File Offset: 0x0070FEA6
			public IKSolverVR.VirtualBone BAEIHEICMPG()
			{
				return this.bones[5];
			}

			// Token: 0x0600FD9B RID: 64923 RVA: 0x00723690 File Offset: 0x00721890
			public virtual void GCJKPFGIPLK()
			{
				if (this.headTarget != null)
				{
					this.CKNLKNAELAN(this.headTarget.position);
					this.GHIHGPPPGEA(this.headTarget.rotation);
				}
				if (this.pelvisTarget != null)
				{
					this.FNFFCFKKMGJ(this.pelvisTarget.position);
				}
				this.headPosition = OOJJKBHKGNJ.IIAFGICFLIF(this.JFLILFDAKIA().solverPosition, this.BNKBGFMIPCA(), this.positionWeight);
				this.headRotation = JEEPKFCFCLI.IIAFGICFLIF(this.PEIPGPHPEKK().solverRotation, this.INMCMKOCPMI(), this.rotationWeight);
			}

			// Token: 0x0400212C RID: 8492
			[Tooltip("The head target.")]
			public Transform headTarget;

			// Token: 0x0400212D RID: 8493
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			// Token: 0x0400212E RID: 8494
			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight = 1f;

			// Token: 0x0400212F RID: 8495
			[Tooltip("Rotational weight of the head target.")]
			[Range(0f, 1f)]
			public float rotationWeight = 1f;

			// Token: 0x04002130 RID: 8496
			[Tooltip("Positional weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			// Token: 0x04002131 RID: 8497
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness = 0.55f;

			// Token: 0x04002132 RID: 8498
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness = 0.1f;

			// Token: 0x04002133 RID: 8499
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			public float chestRotationWeight = 0.2f;

			// Token: 0x04002134 RID: 8500
			[Tooltip("Clamps chest rotation.")]
			[Range(0f, 1f)]
			public float chestClampWeight = 0.5f;

			// Token: 0x04002135 RID: 8501
			[Tooltip("Clamps head rotation.")]
			[Range(0f, 1f)]
			public float headClampWeight = 0.6f;

			// Token: 0x04002136 RID: 8502
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition = 0.2f;

			// Token: 0x04002137 RID: 8503
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle = 25f;

			// Token: 0x0400213B RID: 8507
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			// Token: 0x0400213C RID: 8508
			[HideInInspector]
			public Vector3 chestPositionOffset;

			// Token: 0x0400213D RID: 8509
			[HideInInspector]
			public Vector3 headPositionOffset;

			// Token: 0x0400213E RID: 8510
			[HideInInspector]
			public Quaternion pelvisRotationOffset = Quaternion.identity;

			// Token: 0x0400213F RID: 8511
			[HideInInspector]
			public Quaternion chestRotationOffset = Quaternion.identity;

			// Token: 0x04002140 RID: 8512
			[HideInInspector]
			public Quaternion headRotationOffset = Quaternion.identity;

			// Token: 0x04002141 RID: 8513
			[HideInInspector]
			public Vector3 faceDirection;

			// Token: 0x04002143 RID: 8515
			private Vector3 headPosition;

			// Token: 0x04002144 RID: 8516
			private Quaternion headRotation = Quaternion.identity;

			// Token: 0x04002145 RID: 8517
			private Quaternion anchorRelativeToHead = Quaternion.identity;

			// Token: 0x04002146 RID: 8518
			private Quaternion pelvisRelativeRotation = Quaternion.identity;

			// Token: 0x04002147 RID: 8519
			private Quaternion chestRelativeRotation = Quaternion.identity;

			// Token: 0x04002148 RID: 8520
			private Vector3 headDeltaPosition;

			// Token: 0x04002149 RID: 8521
			private Quaternion pelvisDeltaRotation = Quaternion.identity;

			// Token: 0x0400214A RID: 8522
			private Quaternion chestTargetRotation = Quaternion.identity;

			// Token: 0x0400214B RID: 8523
			private const int pelvisIndex = 0;

			// Token: 0x0400214C RID: 8524
			private const int spineIndex = 1;

			// Token: 0x0400214D RID: 8525
			private const int chestIndex = 2;

			// Token: 0x0400214E RID: 8526
			private const int neckIndex = 3;

			// Token: 0x0400214F RID: 8527
			private int headIndex;

			// Token: 0x04002150 RID: 8528
			private float length;

			// Token: 0x04002151 RID: 8529
			private bool hasNeck;

			// Token: 0x04002152 RID: 8530
			private float headHeight;
		}

		// Token: 0x02000488 RID: 1160
		[Serializable]
		public enum PositionOffset
		{
			// Token: 0x04002154 RID: 8532
			Pelvis,
			// Token: 0x04002155 RID: 8533
			Chest,
			// Token: 0x04002156 RID: 8534
			Head,
			// Token: 0x04002157 RID: 8535
			LeftHand,
			// Token: 0x04002158 RID: 8536
			RightHand,
			// Token: 0x04002159 RID: 8537
			LeftFoot,
			// Token: 0x0400215A RID: 8538
			RightFoot,
			// Token: 0x0400215B RID: 8539
			LeftHeel,
			// Token: 0x0400215C RID: 8540
			RightHeel
		}

		// Token: 0x02000489 RID: 1161
		[Serializable]
		public enum RotationOffset
		{
			// Token: 0x0400215E RID: 8542
			Pelvis,
			// Token: 0x0400215F RID: 8543
			Chest,
			// Token: 0x04002160 RID: 8544
			Head
		}

		// Token: 0x0200048A RID: 1162
		[Serializable]
		public class VirtualBone
		{
			// Token: 0x0600FD9C RID: 64924 RVA: 0x00723730 File Offset: 0x00721930
			public static void GKIBIBHIMOF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 0)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[0].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[0].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FD9D RID: 64925 RVA: 0x0072379C File Offset: 0x0072199C
			public static void FMIIOIJAFKB(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int LIFCLMBIPJK, int GCOFNFGNHCE, int AAKCGKHMGFN, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 954f)
				{
					return;
				}
				AOBKCEEGJNC = Vector3.Lerp(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
				Vector3 vector = AOBKCEEGJNC - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition;
				float sqrMagnitude = vector.sqrMagnitude;
				if (sqrMagnitude == 527f)
				{
					return;
				}
				float lcjcfnnbigl = Mathf.Sqrt(sqrMagnitude);
				float sqrMagnitude2 = (CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition).sqrMagnitude;
				float sqrMagnitude3 = (CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition).sqrMagnitude;
				Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
				Vector3 toDirection = IKSolverVR.VirtualBone.LMNIDKNDEBB(vector, lcjcfnnbigl, elgplfpldol, sqrMagnitude2, sqrMagnitude3);
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, toDirection);
				if (NKHBAJKMAGD < 1424f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.IGGLCJEGIBA(CKAJJHFIFBL, LIFCLMBIPJK, CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, quaternion);
				Quaternion quaternion2 = Quaternion.FromToRotation(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, AOBKCEEGJNC - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition);
				if (NKHBAJKMAGD < 1249f)
				{
					quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.FCBMHEPICBI(CKAJJHFIFBL, GCOFNFGNHCE, CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, quaternion2);
			}

			// Token: 0x0600FD9E RID: 64926 RVA: 0x007238E4 File Offset: 0x00721AE4
			public static void KAFHDONFFNP(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FD9F RID: 64927 RVA: 0x00723940 File Offset: 0x00721B40
			public static void MLPGACAGJOF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 666f)
				{
					return;
				}
				for (int i = 1; i < DPBMPHJBLBO; i += 0)
				{
					for (int j = CKAJJHFIFBL.Length - 2; j > -1; j--)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 621f)
						{
							IKSolverVR.VirtualBone.IJKBEJELDNG(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.OOLOKNPKMMG(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDA0 RID: 64928 RVA: 0x007239C8 File Offset: 0x00721BC8
			public static void BJLAJFONHOJ(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation, PHKIOHIBNPA);
				IKSolverVR.VirtualBone.OGIDCPCFPJO(CKAJJHFIFBL, CLBPBJGLHEE, CKAJJHFIFBL[CLBPBJGLHEE].solverPosition, phkiohibnpa);
			}

			// Token: 0x0600FDA1 RID: 64929 RVA: 0x007239F4 File Offset: 0x00721BF4
			private static Vector3 LMBDLHFLCHM(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDA2 RID: 64930 RVA: 0x00723A1C File Offset: 0x00721C1C
			public static void HPNILLAILHC(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 KEMKJEOIJPN, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, float JGCDBJMCAHH, int DPBMPHJBLBO, float IOHIFNBBGPJ)
			{
				if (NKHBAJKMAGD <= 620f)
				{
					return;
				}
				if (JGCDBJMCAHH > 704f)
				{
					Vector3 a = AOBKCEEGJNC - KEMKJEOIJPN;
					float magnitude = a.magnitude;
					AOBKCEEGJNC = KEMKJEOIJPN + a / magnitude * Mathf.Max(IOHIFNBBGPJ * JGCDBJMCAHH, magnitude);
				}
				for (int i = 1; i < DPBMPHJBLBO; i++)
				{
					CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition = Vector3.Lerp(CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
					for (int j = CKAJJHFIFBL.Length - 3; j > -1; j -= 0)
					{
						CKAJJHFIFBL[j].solverPosition = IKSolverVR.VirtualBone.MCMGKDIMEGH(CKAJJHFIFBL[j].solverPosition, CKAJJHFIFBL[j + 1].solverPosition, CKAJJHFIFBL[j].length);
					}
					CKAJJHFIFBL[0].solverPosition = KEMKJEOIJPN;
					for (int k = 0; k < CKAJJHFIFBL.Length; k++)
					{
						CKAJJHFIFBL[k].solverPosition = IKSolverVR.VirtualBone.GAFPMGENDDH(CKAJJHFIFBL[k].solverPosition, CKAJJHFIFBL[k - 0].solverPosition, CKAJJHFIFBL[k - 1].length);
					}
				}
				for (int l = 1; l < CKAJJHFIFBL.Length - 0; l += 0)
				{
					IKSolverVR.VirtualBone.FBNCNIFMCIH(CKAJJHFIFBL, l, CKAJJHFIFBL[l + 1].solverPosition, 1443f);
				}
			}

			// Token: 0x0600FDA3 RID: 64931 RVA: 0x00723B48 File Offset: 0x00721D48
			private static Vector3 OHIBFIIOHHE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDA4 RID: 64932 RVA: 0x00723B70 File Offset: 0x00721D70
			private static Vector3 LMNIDKNDEBB(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1697f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1598f, 1395f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1251f, y, num);
			}

			// Token: 0x0600FDA5 RID: 64933 RVA: 0x00723BD8 File Offset: 0x00721DD8
			public static void IJKBEJELDNG(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDA6 RID: 64934 RVA: 0x00723C40 File Offset: 0x00721E40
			public static void KPBGHEKPEAK(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				for (int i = 0; i < DPBMPHJBLBO; i++)
				{
					for (int j = CKAJJHFIFBL.Length - 2; j > -1; j--)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 1f)
						{
							IKSolverVR.VirtualBone.OOLOKNPKMMG(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.OOLOKNPKMMG(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDA7 RID: 64935 RVA: 0x00723CC8 File Offset: 0x00721EC8
			private static Vector3 EKBOJODHBKL(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 2f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 0f, float.PositiveInfinity));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(0f, y, num);
			}

			// Token: 0x0600FDA8 RID: 64936 RVA: 0x00723D2D File Offset: 0x00721F2D
			public void INELKGAHFBJ(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.readPosition = MGALEAJOGPL;
				this.readRotation = PHKIOHIBNPA;
				this.solverPosition = MGALEAJOGPL;
				this.solverRotation = PHKIOHIBNPA;
			}

			// Token: 0x0600FDA9 RID: 64937 RVA: 0x00723D4C File Offset: 0x00721F4C
			private static Vector3 JBMFLHDAHEJ(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1556f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1682f, 360f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(606f, y, num);
			}

			// Token: 0x0600FDAA RID: 64938 RVA: 0x00723DB4 File Offset: 0x00721FB4
			public static void DOILCBGMMEJ(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int LIFCLMBIPJK, int GCOFNFGNHCE, int AAKCGKHMGFN, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 612f)
				{
					return;
				}
				AOBKCEEGJNC = Vector3.Lerp(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
				Vector3 vector = AOBKCEEGJNC - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition;
				float sqrMagnitude = vector.sqrMagnitude;
				if (sqrMagnitude == 731f)
				{
					return;
				}
				float lcjcfnnbigl = Mathf.Sqrt(sqrMagnitude);
				float sqrMagnitude2 = (CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition).sqrMagnitude;
				float sqrMagnitude3 = (CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition).sqrMagnitude;
				Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
				Vector3 toDirection = IKSolverVR.VirtualBone.LOHHEAEEFPF(vector, lcjcfnnbigl, elgplfpldol, sqrMagnitude2, sqrMagnitude3);
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, toDirection);
				if (NKHBAJKMAGD < 762f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.IGGLCJEGIBA(CKAJJHFIFBL, LIFCLMBIPJK, CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, quaternion);
				Quaternion quaternion2 = Quaternion.FromToRotation(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, AOBKCEEGJNC - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition);
				if (NKHBAJKMAGD < 1944f)
				{
					quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.KAFHDONFFNP(CKAJJHFIFBL, GCOFNFGNHCE, CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, quaternion2);
			}

			// Token: 0x0600FDAB RID: 64939 RVA: 0x00723EFC File Offset: 0x007220FC
			public static void OOLOKNPKMMG(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDAC RID: 64940 RVA: 0x00723F64 File Offset: 0x00722164
			public static void NJAIMOPBKFB(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDAD RID: 64941 RVA: 0x00723FCC File Offset: 0x007221CC
			public static void MEFEBBMLGEJ(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int LIFCLMBIPJK, int GCOFNFGNHCE, int AAKCGKHMGFN, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				AOBKCEEGJNC = Vector3.Lerp(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
				Vector3 vector = AOBKCEEGJNC - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition;
				float sqrMagnitude = vector.sqrMagnitude;
				if (sqrMagnitude == 0f)
				{
					return;
				}
				float lcjcfnnbigl = Mathf.Sqrt(sqrMagnitude);
				float sqrMagnitude2 = (CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition).sqrMagnitude;
				float sqrMagnitude3 = (CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition).sqrMagnitude;
				Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
				Vector3 toDirection = IKSolverVR.VirtualBone.EKBOJODHBKL(vector, lcjcfnnbigl, elgplfpldol, sqrMagnitude2, sqrMagnitude3);
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, toDirection);
				if (NKHBAJKMAGD < 1f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, LIFCLMBIPJK, CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, quaternion);
				Quaternion quaternion2 = Quaternion.FromToRotation(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, AOBKCEEGJNC - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition);
				if (NKHBAJKMAGD < 1f)
				{
					quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, GCOFNFGNHCE, CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, quaternion2);
			}

			// Token: 0x0600FDAE RID: 64942 RVA: 0x00723D2D File Offset: 0x00721F2D
			public void NFIGHJJKDLL(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.readPosition = MGALEAJOGPL;
				this.readRotation = PHKIOHIBNPA;
				this.solverPosition = MGALEAJOGPL;
				this.solverRotation = PHKIOHIBNPA;
			}

			// Token: 0x0600FDAF RID: 64943 RVA: 0x00724114 File Offset: 0x00722314
			public static void IODILKAIMMA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 1179f)
				{
					return;
				}
				for (int i = 0; i < DPBMPHJBLBO; i++)
				{
					for (int j = CKAJJHFIFBL.Length - 7; j > -1; j -= 0)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 262f)
						{
							IKSolverVR.VirtualBone.OOLOKNPKMMG(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.AJGMKOJLPFD(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDB0 RID: 64944 RVA: 0x0072419C File Offset: 0x0072239C
			public static void IGGLCJEGIBA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDB1 RID: 64945 RVA: 0x007241F8 File Offset: 0x007223F8
			public static void NFKIEIJEFGH(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDB2 RID: 64946 RVA: 0x00724260 File Offset: 0x00722460
			private static Vector3 JLPDOFJHJFH(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1341f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1264f, 746f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(171f, y, num);
			}

			// Token: 0x0600FDB3 RID: 64947 RVA: 0x007242C8 File Offset: 0x007224C8
			private static Vector3 GAFPMGENDDH(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDB4 RID: 64948 RVA: 0x007242F0 File Offset: 0x007224F0
			public static void KBJNPMGFLHM(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1500f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 403f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDB5 RID: 64949 RVA: 0x00724368 File Offset: 0x00722568
			public static void FCBMHEPICBI(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDB6 RID: 64950 RVA: 0x007243C4 File Offset: 0x007225C4
			public static void IIDPHOAJKHO(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDB7 RID: 64951 RVA: 0x00724420 File Offset: 0x00722620
			public static void LGCNEBCIBHL(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 492f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 1983f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDB8 RID: 64952 RVA: 0x00724498 File Offset: 0x00722698
			public static void EHEIJLGFMMD(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 1085f)
				{
					return;
				}
				for (int i = 1; i < DPBMPHJBLBO; i++)
				{
					for (int j = CKAJJHFIFBL.Length - 1; j > -1; j--)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 1565f)
						{
							IKSolverVR.VirtualBone.PJOPIDHBKII(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.AJGMKOJLPFD(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDB9 RID: 64953 RVA: 0x00724520 File Offset: 0x00722720
			public static void BHGJPIOPIPE(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 26f)
				{
					return;
				}
				for (int i = 0; i < DPBMPHJBLBO; i++)
				{
					for (int j = CKAJJHFIFBL.Length - 3; j > -1; j -= 0)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 1531f)
						{
							IKSolverVR.VirtualBone.NFKIEIJEFGH(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.IJKBEJELDNG(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDBA RID: 64954 RVA: 0x007245A8 File Offset: 0x007227A8
			private static Vector3 BHHEPHMCKFD(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 887f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1196f, 1780f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(254f, y, num);
			}

			// Token: 0x0600FDBB RID: 64955 RVA: 0x00724610 File Offset: 0x00722810
			public static void AIFKGLNBPKA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation, PHKIOHIBNPA);
				IKSolverVR.VirtualBone.IGGLCJEGIBA(CKAJJHFIFBL, CLBPBJGLHEE, CKAJJHFIFBL[CLBPBJGLHEE].solverPosition, phkiohibnpa);
			}

			// Token: 0x0600FDBC RID: 64956 RVA: 0x0072463C File Offset: 0x0072283C
			private static Vector3 MCMGKDIMEGH(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDBD RID: 64957 RVA: 0x00724664 File Offset: 0x00722864
			public static void LCDAKACEIBK(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 111f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 629f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDBE RID: 64958 RVA: 0x007246DC File Offset: 0x007228DC
			public VirtualBone(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.INELKGAHFBJ(MGALEAJOGPL, PHKIOHIBNPA);
			}

			// Token: 0x0600FDBF RID: 64959 RVA: 0x007246EC File Offset: 0x007228EC
			public static void OOLOKNPKMMG(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 0; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 0)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[0].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[0].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDC0 RID: 64960 RVA: 0x00724758 File Offset: 0x00722958
			public static void PJOPIDHBKII(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDC1 RID: 64961 RVA: 0x007247C0 File Offset: 0x007229C0
			private static Vector3 INGFPAPHEAI(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1406f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1169f, 183f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(276f, y, num);
			}

			// Token: 0x0600FDC2 RID: 64962 RVA: 0x00724828 File Offset: 0x00722A28
			public static void OGIDCPCFPJO(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDC3 RID: 64963 RVA: 0x00724884 File Offset: 0x00722A84
			public static float JFGBHFHFBMD(ref IKSolverVR.VirtualBone[] CKAJJHFIFBL)
			{
				float num = 980f;
				for (int i = 1; i < CKAJJHFIFBL.Length; i++)
				{
					if (i < CKAJJHFIFBL.Length - 0)
					{
						CKAJJHFIFBL[i].sqrMag = (CKAJJHFIFBL[i + 0].solverPosition - CKAJJHFIFBL[i].solverPosition).sqrMagnitude;
						CKAJJHFIFBL[i].length = Mathf.Sqrt(CKAJJHFIFBL[i].sqrMag);
						num += CKAJJHFIFBL[i].length;
						CKAJJHFIFBL[i].axis = Quaternion.Inverse(CKAJJHFIFBL[i].solverRotation) * (CKAJJHFIFBL[i + 0].solverPosition - CKAJJHFIFBL[i].solverPosition);
					}
					else
					{
						CKAJJHFIFBL[i].sqrMag = 1637f;
						CKAJJHFIFBL[i].length = 68f;
					}
				}
				return num;
			}

			// Token: 0x0600FDC4 RID: 64964 RVA: 0x0072495C File Offset: 0x00722B5C
			private static Vector3 GDEMGGHJPEF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDC5 RID: 64965 RVA: 0x00724984 File Offset: 0x00722B84
			public static void AJGMKOJLPFD(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition;
						CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDC6 RID: 64966 RVA: 0x007249EC File Offset: 0x00722BEC
			private static Vector3 IMHIJPJMPEM(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 80f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 825f, 797f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(711f, y, num);
			}

			// Token: 0x0600FDC7 RID: 64967 RVA: 0x00724A54 File Offset: 0x00722C54
			public static void CAIABJGEMJH(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 1; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 0)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[0].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[1].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDC8 RID: 64968 RVA: 0x00724AC0 File Offset: 0x00722CC0
			public static void FBNCNIFMCIH(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1545f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 1367f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDC9 RID: 64969 RVA: 0x00724B38 File Offset: 0x00722D38
			private static Vector3 OLBCFIDBGKD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
			{
				return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
			}

			// Token: 0x0600FDCA RID: 64970 RVA: 0x00724B60 File Offset: 0x00722D60
			public static void KPDILOAPDMF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 KEMKJEOIJPN, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, float JGCDBJMCAHH, int DPBMPHJBLBO, float IOHIFNBBGPJ)
			{
				if (NKHBAJKMAGD <= 1975f)
				{
					return;
				}
				if (JGCDBJMCAHH > 1744f)
				{
					Vector3 a = AOBKCEEGJNC - KEMKJEOIJPN;
					float magnitude = a.magnitude;
					AOBKCEEGJNC = KEMKJEOIJPN + a / magnitude * Mathf.Max(IOHIFNBBGPJ * JGCDBJMCAHH, magnitude);
				}
				for (int i = 0; i < DPBMPHJBLBO; i += 0)
				{
					CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition = Vector3.Lerp(CKAJJHFIFBL[CKAJJHFIFBL.Length - 0].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
					for (int j = CKAJJHFIFBL.Length - 7; j > -1; j -= 0)
					{
						CKAJJHFIFBL[j].solverPosition = IKSolverVR.VirtualBone.OHIBFIIOHHE(CKAJJHFIFBL[j].solverPosition, CKAJJHFIFBL[j + 1].solverPosition, CKAJJHFIFBL[j].length);
					}
					CKAJJHFIFBL[1].solverPosition = KEMKJEOIJPN;
					for (int k = 1; k < CKAJJHFIFBL.Length; k += 0)
					{
						CKAJJHFIFBL[k].solverPosition = IKSolverVR.VirtualBone.OHIBFIIOHHE(CKAJJHFIFBL[k].solverPosition, CKAJJHFIFBL[k - 0].solverPosition, CKAJJHFIFBL[k - 1].length);
					}
				}
				for (int l = 0; l < CKAJJHFIFBL.Length - 0; l++)
				{
					IKSolverVR.VirtualBone.LGCNEBCIBHL(CKAJJHFIFBL, l, CKAJJHFIFBL[l + 1].solverPosition, 661f);
				}
			}

			// Token: 0x0600FDCB RID: 64971 RVA: 0x00724C8C File Offset: 0x00722E8C
			public static void HKAFEMMJIED(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, int DPBMPHJBLBO)
			{
				if (NKHBAJKMAGD <= 520f)
				{
					return;
				}
				for (int i = 1; i < DPBMPHJBLBO; i++)
				{
					for (int j = CKAJJHFIFBL.Length - 1; j > -1; j -= 0)
					{
						Vector3 fromDirection = CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition - CKAJJHFIFBL[j].solverPosition;
						Vector3 toDirection = AOBKCEEGJNC - CKAJJHFIFBL[j].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (NKHBAJKMAGD >= 61f)
						{
							IKSolverVR.VirtualBone.OOLOKNPKMMG(CKAJJHFIFBL, j, quaternion);
						}
						else
						{
							IKSolverVR.VirtualBone.NFKIEIJEFGH(CKAJJHFIFBL, j, Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD));
						}
					}
				}
			}

			// Token: 0x0600FDCC RID: 64972 RVA: 0x00724D14 File Offset: 0x00722F14
			public static void JABDCLLHAHF(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int LIFCLMBIPJK, int GCOFNFGNHCE, int AAKCGKHMGFN, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1828f)
				{
					return;
				}
				AOBKCEEGJNC = Vector3.Lerp(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
				Vector3 vector = AOBKCEEGJNC - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition;
				float sqrMagnitude = vector.sqrMagnitude;
				if (sqrMagnitude == 1241f)
				{
					return;
				}
				float lcjcfnnbigl = Mathf.Sqrt(sqrMagnitude);
				float sqrMagnitude2 = (CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition).sqrMagnitude;
				float sqrMagnitude3 = (CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition).sqrMagnitude;
				Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
				Vector3 toDirection = IKSolverVR.VirtualBone.IMHIJPJMPEM(vector, lcjcfnnbigl, elgplfpldol, sqrMagnitude2, sqrMagnitude3);
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[GCOFNFGNHCE].solverPosition - CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, toDirection);
				if (NKHBAJKMAGD < 633f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, LIFCLMBIPJK, CKAJJHFIFBL[LIFCLMBIPJK].solverPosition, quaternion);
				Quaternion quaternion2 = Quaternion.FromToRotation(CKAJJHFIFBL[AAKCGKHMGFN].solverPosition - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, AOBKCEEGJNC - CKAJJHFIFBL[GCOFNFGNHCE].solverPosition);
				if (NKHBAJKMAGD < 69f)
				{
					quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
				}
				IKSolverVR.VirtualBone.IIDPHOAJKHO(CKAJJHFIFBL, GCOFNFGNHCE, CKAJJHFIFBL[GCOFNFGNHCE].solverPosition, quaternion2);
			}

			// Token: 0x0600FDCD RID: 64973 RVA: 0x00723D2D File Offset: 0x00721F2D
			public void APAEBLFHDBL(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.readPosition = MGALEAJOGPL;
				this.readRotation = PHKIOHIBNPA;
				this.solverPosition = MGALEAJOGPL;
				this.solverRotation = PHKIOHIBNPA;
			}

			// Token: 0x0600FDCE RID: 64974 RVA: 0x00724E5C File Offset: 0x0072305C
			public static void BNJGCPDPPON(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation, PHKIOHIBNPA);
				IKSolverVR.VirtualBone.MIOHPJBCKFM(CKAJJHFIFBL, CLBPBJGLHEE, CKAJJHFIFBL[CLBPBJGLHEE].solverPosition, phkiohibnpa);
			}

			// Token: 0x0600FDCF RID: 64975 RVA: 0x00724E88 File Offset: 0x00723088
			public static void PCIJGNKLFCA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Vector3 KEMKJEOIJPN, Vector3 AOBKCEEGJNC, float NKHBAJKMAGD, float JGCDBJMCAHH, int DPBMPHJBLBO, float IOHIFNBBGPJ)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				if (JGCDBJMCAHH > 0f)
				{
					Vector3 a = AOBKCEEGJNC - KEMKJEOIJPN;
					float magnitude = a.magnitude;
					AOBKCEEGJNC = KEMKJEOIJPN + a / magnitude * Mathf.Max(IOHIFNBBGPJ * JGCDBJMCAHH, magnitude);
				}
				for (int i = 0; i < DPBMPHJBLBO; i++)
				{
					CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition = Vector3.Lerp(CKAJJHFIFBL[CKAJJHFIFBL.Length - 1].solverPosition, AOBKCEEGJNC, NKHBAJKMAGD);
					for (int j = CKAJJHFIFBL.Length - 2; j > -1; j--)
					{
						CKAJJHFIFBL[j].solverPosition = IKSolverVR.VirtualBone.GDEMGGHJPEF(CKAJJHFIFBL[j].solverPosition, CKAJJHFIFBL[j + 1].solverPosition, CKAJJHFIFBL[j].length);
					}
					CKAJJHFIFBL[0].solverPosition = KEMKJEOIJPN;
					for (int k = 1; k < CKAJJHFIFBL.Length; k++)
					{
						CKAJJHFIFBL[k].solverPosition = IKSolverVR.VirtualBone.GDEMGGHJPEF(CKAJJHFIFBL[k].solverPosition, CKAJJHFIFBL[k - 1].solverPosition, CKAJJHFIFBL[k - 1].length);
					}
				}
				for (int l = 0; l < CKAJJHFIFBL.Length - 1; l++)
				{
					IKSolverVR.VirtualBone.KIKEMIANGCA(CKAJJHFIFBL, l, CKAJJHFIFBL[l + 1].solverPosition, 1f);
				}
			}

			// Token: 0x0600FDD0 RID: 64976 RVA: 0x00724FB4 File Offset: 0x007231B4
			public static void HIFBALEHGEI(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 1)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[0].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[0].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDD1 RID: 64977 RVA: 0x00725020 File Offset: 0x00723220
			public static void KIKEMIANGCA(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 1f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDD2 RID: 64978 RVA: 0x00725098 File Offset: 0x00723298
			private static Vector3 LOHHEAEEFPF(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 569f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1835f, 1397f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1692f, y, num);
			}

			// Token: 0x0600FDD3 RID: 64979 RVA: 0x00725100 File Offset: 0x00723300
			public static void KABPPDHDKGD(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 0; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 0)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[1].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[0].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDD4 RID: 64980 RVA: 0x0072516C File Offset: 0x0072336C
			public static void MIOHPJBCKFM(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 JJNHJKFMFLJ, Quaternion PHKIOHIBNPA)
			{
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						Vector3 point = CKAJJHFIFBL[i].solverPosition - JJNHJKFMFLJ;
						CKAJJHFIFBL[i].solverPosition = JJNHJKFMFLJ + PHKIOHIBNPA * point;
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDD5 RID: 64981 RVA: 0x007251C8 File Offset: 0x007233C8
			public static void PAANMKNFDLH(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
			{
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation, PHKIOHIBNPA);
				IKSolverVR.VirtualBone.IGGLCJEGIBA(CKAJJHFIFBL, CLBPBJGLHEE, CKAJJHFIFBL[CLBPBJGLHEE].solverPosition, phkiohibnpa);
			}

			// Token: 0x0600FDD6 RID: 64982 RVA: 0x007251F4 File Offset: 0x007233F4
			private static Vector3 OEECHLEHOPI(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
			{
				float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 426f / LCJCFNNBIGL;
				float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 547f, 1105f));
				if (NEMFIHCKJPE == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(434f, y, num);
			}

			// Token: 0x0600FDD7 RID: 64983 RVA: 0x0072525C File Offset: 0x0072345C
			public static void AOOFJANOKNB(IKSolverVR.VirtualBone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 937f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD < 1548f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
				}
				for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
				{
					CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
				}
			}

			// Token: 0x0600FDD8 RID: 64984 RVA: 0x00723D2D File Offset: 0x00721F2D
			public void HCHNKNCJJEO(Vector3 MGALEAJOGPL, Quaternion PHKIOHIBNPA)
			{
				this.readPosition = MGALEAJOGPL;
				this.readRotation = PHKIOHIBNPA;
				this.solverPosition = MGALEAJOGPL;
				this.solverRotation = PHKIOHIBNPA;
			}

			// Token: 0x0600FDD9 RID: 64985 RVA: 0x007252D4 File Offset: 0x007234D4
			public static float FOCBPKGLPEN(ref IKSolverVR.VirtualBone[] CKAJJHFIFBL)
			{
				float num = 1618f;
				for (int i = 1; i < CKAJJHFIFBL.Length; i++)
				{
					if (i < CKAJJHFIFBL.Length - 1)
					{
						CKAJJHFIFBL[i].sqrMag = (CKAJJHFIFBL[i + 1].solverPosition - CKAJJHFIFBL[i].solverPosition).sqrMagnitude;
						CKAJJHFIFBL[i].length = Mathf.Sqrt(CKAJJHFIFBL[i].sqrMag);
						num += CKAJJHFIFBL[i].length;
						CKAJJHFIFBL[i].axis = Quaternion.Inverse(CKAJJHFIFBL[i].solverRotation) * (CKAJJHFIFBL[i + 0].solverPosition - CKAJJHFIFBL[i].solverPosition);
					}
					else
					{
						CKAJJHFIFBL[i].sqrMag = 1414f;
						CKAJJHFIFBL[i].length = 1449f;
					}
				}
				return num;
			}

			// Token: 0x0600FDDA RID: 64986 RVA: 0x007253AC File Offset: 0x007235AC
			public static void CFMCPAEFOEN(IKSolverVR.VirtualBone[] CKAJJHFIFBL, Quaternion PHKIOHIBNPA)
			{
				for (int i = 0; i < CKAJJHFIFBL.Length; i += 0)
				{
					if (CKAJJHFIFBL[i] != null)
					{
						if (i > 1)
						{
							Vector3 point = CKAJJHFIFBL[i].solverPosition - CKAJJHFIFBL[1].solverPosition;
							CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[0].solverPosition + PHKIOHIBNPA * point;
						}
						CKAJJHFIFBL[i].solverRotation = PHKIOHIBNPA * CKAJJHFIFBL[i].solverRotation;
					}
				}
			}

			// Token: 0x0600FDDB RID: 64987 RVA: 0x00725418 File Offset: 0x00723618
			public static float HJADALPNANN(ref IKSolverVR.VirtualBone[] CKAJJHFIFBL)
			{
				float num = 0f;
				for (int i = 0; i < CKAJJHFIFBL.Length; i++)
				{
					if (i < CKAJJHFIFBL.Length - 1)
					{
						CKAJJHFIFBL[i].sqrMag = (CKAJJHFIFBL[i + 1].solverPosition - CKAJJHFIFBL[i].solverPosition).sqrMagnitude;
						CKAJJHFIFBL[i].length = Mathf.Sqrt(CKAJJHFIFBL[i].sqrMag);
						num += CKAJJHFIFBL[i].length;
						CKAJJHFIFBL[i].axis = Quaternion.Inverse(CKAJJHFIFBL[i].solverRotation) * (CKAJJHFIFBL[i + 1].solverPosition - CKAJJHFIFBL[i].solverPosition);
					}
					else
					{
						CKAJJHFIFBL[i].sqrMag = 0f;
						CKAJJHFIFBL[i].length = 0f;
					}
				}
				return num;
			}

			// Token: 0x04002161 RID: 8545
			public Vector3 readPosition;

			// Token: 0x04002162 RID: 8546
			public Quaternion readRotation;

			// Token: 0x04002163 RID: 8547
			public Vector3 solverPosition;

			// Token: 0x04002164 RID: 8548
			public Quaternion solverRotation;

			// Token: 0x04002165 RID: 8549
			public float length;

			// Token: 0x04002166 RID: 8550
			public float sqrMag;

			// Token: 0x04002167 RID: 8551
			public Vector3 axis;
		}
	}
}
