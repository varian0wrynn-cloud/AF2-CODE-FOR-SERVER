using System;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.XR;

namespace RootMotion.Demos
{
	// Token: 0x0200041E RID: 1054
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class VRAimingController : MonoBehaviour
	{
		// Token: 0x0600E3D1 RID: 58321 RVA: 0x0067B04A File Offset: 0x0067924A
		private Transform AEKACFEGADA()
		{
			return this.animatorController.characterController;
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x0067B058 File Offset: 0x00679258
		private Vector3 MDAAIOPBMEF()
		{
			float d = (InputTracking.GetLocalPosition(XRNode.LeftEye) - InputTracking.GetLocalPosition(XRNode.RightEye)).magnitude * 0.5f;
			Vector3 vector = Vector3.right * d;
			if (this.handedness == VRAimingController.Handedness.Left)
			{
				vector = -vector;
			}
			return this.PMMEFNKFJIA.position + this.PMMEFNKFJIA.rotation * vector;
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x0067B0C2 File Offset: 0x006792C2
		private void GEOHOHNFIAF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DOCFDIFPKHI));
			}
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x0067B100 File Offset: 0x00679300
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.HCALHCCLMFO = this.OJMBOCNNLMI.references.leftHand.GetComponent<Poser>();
			this.EMBMBLHPJBP = this.OJMBOCNNLMI.references.rightHand.GetComponent<Poser>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			this.PIJKOMKCJOG = this.weight;
			this.BJMFNPCBIIM(this.handedness);
			this.HNCLBJOLCOD = this.weaponsAnchor.localPosition;
			this.EDELBPFJBGL = this.weaponsPivot.localPosition;
			this.OCJGOBHACHI = this.pivotMotionTarget.InverseTransformPoint(this.weaponsPivot.position);
			this.DNLGOOJMCCH = this.MDAAIOPBMEF();
			this.PLKCBKCHHII = this.FDLHJAOGDLJ.position;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x0067B04A File Offset: 0x0067924A
		private Transform FDLHJAOGDLJ
		{
			get
			{
				return this.animatorController.characterController;
			}
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x0067B1F0 File Offset: 0x006793F0
		private void LateUpdate()
		{
			this.DNLGOOJMCCH += this.FDLHJAOGDLJ.position - this.PLKCBKCHHII;
			this.PLKCBKCHHII = this.FDLHJAOGDLJ.position;
			this.DNLGOOJMCCH = Vector3.Lerp(this.DNLGOOJMCCH, this.MDAAIOPBMEF(), Time.deltaTime * this.lerpSpeed);
			if (this.weight <= 0f && this.PIJKOMKCJOG <= 0f)
			{
				return;
			}
			this.PIJKOMKCJOG = this.weight;
			float t = this.animatorController.APOIOHJJDDC.magnitude * this.pivotMotionWeight;
			this.weaponsPivot.position = Vector3.Lerp(this.weaponsPivot.position, Vector3.Lerp(this.weaponsPivot.parent.TransformPoint(this.EDELBPFJBGL), this.pivotMotionTarget.TransformPoint(this.OCJGOBHACHI), t), Time.deltaTime * this.pivotMotionSmoothSpeed);
			if (Input.GetKeyDown(KeyCode.H))
			{
				this.BJMFNPCBIIM((this.handedness == VRAimingController.Handedness.Right) ? VRAimingController.Handedness.Left : VRAimingController.Handedness.Right);
			}
			this.HNCLBJOLCOD.x = ((this.handedness == VRAimingController.Handedness.Right) ? this.sideOffset : (-this.sideOffset));
			this.weaponsAnchor.localPosition = Vector3.Lerp(this.weaponsAnchor.localPosition, this.HNCLBJOLCOD, Time.deltaTime * this.lerpSpeed);
			if (this.currentWeapon != null && Input.GetMouseButtonDown(0))
			{
				this.currentWeapon.Fire();
				this.weaponsAnchor.localPosition += this.currentWeapon.recoilDirection + UnityEngine.Random.insideUnitSphere * this.currentWeapon.recoilDirection.magnitude * UnityEngine.Random.value * this.currentWeapon.recoilRandom;
				this.JEKFKPGCIHA.x = this.JEKFKPGCIHA.x - (this.currentWeapon.recoilAngleVertical + this.currentWeapon.recoilAngleVertical * UnityEngine.Random.value * this.currentWeapon.recoilRandom);
				float num = this.currentWeapon.recoilAngleHorizontal * UnityEngine.Random.value;
				if (UnityEngine.Random.value > 0.5f)
				{
					num = -num;
				}
				this.JEKFKPGCIHA.y = this.JEKFKPGCIHA.y + (num + num * UnityEngine.Random.value * this.currentWeapon.recoilRandom);
			}
			foreach (VRAimingController.BoneRotationOffset boneRotationOffset in this.PFJCPCDKALA.boneRotationOffsets)
			{
				boneRotationOffset.transform.localRotation = Quaternion.Euler(boneRotationOffset.value * this.weight) * boneRotationOffset.transform.localRotation;
			}
			bool mouseButton = Input.GetMouseButton(1);
			float target = mouseButton ? 1f : 0f;
			this.BGGLLEKHKDM = Mathf.MoveTowards(this.BGGLLEKHKDM, target, Time.deltaTime * 3f);
			this.HPNNEBIOKLN(Input.GetAxis("Mouse X") * (1f - this.BGGLLEKHKDM), Input.GetAxis("Mouse Y") * (1f - this.BGGLLEKHKDM));
			if (mouseButton)
			{
				this.weaponsPivot.position = Vector3.Lerp(this.weaponsPivot.position, this.DNLGOOJMCCH, this.BGGLLEKHKDM);
				this.weaponsAnchor.localPosition = Vector3.Lerp(this.weaponsAnchor.localPosition, new Vector3(0f, this.weaponsAnchor.localPosition.y, this.aimZ), this.BGGLLEKHKDM);
				this.weaponsPivot.rotation = Quaternion.Lerp(this.weaponsPivot.rotation, Quaternion.LookRotation(this.PMMEFNKFJIA.forward), Time.deltaTime * this.lerpSpeed);
			}
			Vector3 vector = Vector3.Project(this.weaponsAnchor.position - this.MDAAIOPBMEF(), this.PMMEFNKFJIA.forward);
			if (Vector3.Dot(vector, this.PMMEFNKFJIA.forward) < 0f)
			{
				this.weaponsAnchor.position -= vector;
			}
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.PFJCPCDKALA.leftHand.position;
			this.OJMBOCNNLMI.solver.rightHandEffector.position = this.PFJCPCDKALA.rightHand.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = this.weight;
			this.OJMBOCNNLMI.solver.leftArmChain.bendConstraint.bendGoal = this.PFJCPCDKALA.bendGoalLeftArm;
			this.OJMBOCNNLMI.solver.rightArmChain.bendConstraint.bendGoal = this.PFJCPCDKALA.bendGoalRightArm;
			this.OJMBOCNNLMI.solver.leftArmChain.bendConstraint.weight = this.weight;
			this.OJMBOCNNLMI.solver.rightArmChain.bendConstraint.weight = this.weight;
			this.HCALHCCLMFO.weight = this.weight;
			this.EMBMBLHPJBP.weight = this.weight;
			this.animatorController.RotateCharacter(this.weaponsAnchor.forward, this.animatorController.maxViewAngle, this.weaponsPivot);
			this.FOKFDOKIOED();
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x0067B770 File Offset: 0x00679970
		private void CCIPNJMADJD()
		{
			if (this.weight <= 746f)
			{
				return;
			}
			this.OJMBOCNNLMI.references.leftHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.leftHand.rotation, this.PFJCPCDKALA.leftHand.rotation, this.weight);
			this.OJMBOCNNLMI.references.rightHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.rightHand.rotation, this.PFJCPCDKALA.rightHand.rotation, this.weight);
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x0067B818 File Offset: 0x00679A18
		private void HPNNEBIOKLN(float JMHGGPJGHLJ, float DHKNHJNBBHJ)
		{
			Vector3 vector = new Vector3(-DHKNHJNBBHJ, JMHGGPJGHLJ, 0f);
			this.NMABNBGNENF = Vector3.Lerp(this.NMABNBGNENF, UnityEngine.Random.onUnitSphere, Time.deltaTime);
			vector += this.NMABNBGNENF * 0.25f;
			this.JEKFKPGCIHA = Vector3.Lerp(this.JEKFKPGCIHA, vector, Time.deltaTime * 20f);
			Vector3 forward = this.weaponsPivot.forward;
			forward.y = 0f;
			Quaternion rotation = Quaternion.AngleAxis(this.JEKFKPGCIHA.x, Quaternion.LookRotation(forward) * Vector3.right);
			Quaternion rotation2 = Quaternion.AngleAxis(this.JEKFKPGCIHA.y, Vector3.up);
			Vector3 point = Vector3.RotateTowards(forward, rotation * this.weaponsPivot.forward, this.aimVerticalLimit * 0.017453292f, 1f);
			this.weaponsPivot.rotation = Quaternion.LookRotation(rotation2 * point, Vector3.up);
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x0067B919 File Offset: 0x00679B19
		private VRAimingController.Targets PFJCPCDKALA
		{
			get
			{
				if (this.handedness == VRAimingController.Handedness.Right)
				{
					return this.rightHandedTargets;
				}
				return this.leftHandedTargets;
			}
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x0067B930 File Offset: 0x00679B30
		private void CABMDBPACPO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CCIPNJMADJD));
			}
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x0067B96C File Offset: 0x00679B6C
		private void OnDestroy()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x0067B9A8 File Offset: 0x00679BA8
		private void BOEFHGKGJMN()
		{
			this.DNLGOOJMCCH += this.AEKACFEGADA().position - this.PLKCBKCHHII;
			this.PLKCBKCHHII = this.AEKACFEGADA().position;
			this.DNLGOOJMCCH = Vector3.Lerp(this.DNLGOOJMCCH, this.MDAAIOPBMEF(), Time.deltaTime * this.lerpSpeed);
			if (this.weight <= 1620f && this.PIJKOMKCJOG <= 1207f)
			{
				return;
			}
			this.PIJKOMKCJOG = this.weight;
			float t = this.animatorController.PEALGAOLPDF().magnitude * this.pivotMotionWeight;
			this.weaponsPivot.position = Vector3.Lerp(this.weaponsPivot.position, Vector3.Lerp(this.weaponsPivot.parent.TransformPoint(this.EDELBPFJBGL), this.pivotMotionTarget.TransformPoint(this.OCJGOBHACHI), t), Time.deltaTime * this.pivotMotionSmoothSpeed);
			if (Input.GetKeyDown((KeyCode)(-72)))
			{
				this.BJMFNPCBIIM((this.handedness == VRAimingController.Handedness.Right) ? VRAimingController.Handedness.Left : VRAimingController.Handedness.Left);
			}
			this.HNCLBJOLCOD.x = ((this.handedness == VRAimingController.Handedness.Right) ? this.sideOffset : (-this.sideOffset));
			this.weaponsAnchor.localPosition = Vector3.Lerp(this.weaponsAnchor.localPosition, this.HNCLBJOLCOD, Time.deltaTime * this.lerpSpeed);
			if (this.currentWeapon != null && Input.GetMouseButtonDown(0))
			{
				this.currentWeapon.Fire();
				this.weaponsAnchor.localPosition += this.currentWeapon.recoilDirection + UnityEngine.Random.insideUnitSphere * this.currentWeapon.recoilDirection.magnitude * UnityEngine.Random.value * this.currentWeapon.recoilRandom;
				this.JEKFKPGCIHA.x = this.JEKFKPGCIHA.x - (this.currentWeapon.recoilAngleVertical + this.currentWeapon.recoilAngleVertical * UnityEngine.Random.value * this.currentWeapon.recoilRandom);
				float num = this.currentWeapon.recoilAngleHorizontal * UnityEngine.Random.value;
				if (UnityEngine.Random.value > 888f)
				{
					num = -num;
				}
				this.JEKFKPGCIHA.y = this.JEKFKPGCIHA.y + (num + num * UnityEngine.Random.value * this.currentWeapon.recoilRandom);
			}
			VRAimingController.BoneRotationOffset[] boneRotationOffsets = this.PFJCPCDKALA.boneRotationOffsets;
			for (int i = 0; i < boneRotationOffsets.Length; i += 0)
			{
				VRAimingController.BoneRotationOffset boneRotationOffset = boneRotationOffsets[i];
				boneRotationOffset.transform.localRotation = Quaternion.Euler(boneRotationOffset.value * this.weight) * boneRotationOffset.transform.localRotation;
			}
			bool mouseButton = Input.GetMouseButton(0);
			float target = mouseButton ? 1274f : 666f;
			this.BGGLLEKHKDM = Mathf.MoveTowards(this.BGGLLEKHKDM, target, Time.deltaTime * 144f);
			this.HPNNEBIOKLN(Input.GetAxis("null") * (20f - this.BGGLLEKHKDM), Input.GetAxis("VaderChoke") * (1789f - this.BGGLLEKHKDM));
			if (mouseButton)
			{
				this.weaponsPivot.position = Vector3.Lerp(this.weaponsPivot.position, this.DNLGOOJMCCH, this.BGGLLEKHKDM);
				this.weaponsAnchor.localPosition = Vector3.Lerp(this.weaponsAnchor.localPosition, new Vector3(1962f, this.weaponsAnchor.localPosition.y, this.aimZ), this.BGGLLEKHKDM);
				this.weaponsPivot.rotation = Quaternion.Lerp(this.weaponsPivot.rotation, Quaternion.LookRotation(this.PMMEFNKFJIA.forward), Time.deltaTime * this.lerpSpeed);
			}
			Vector3 vector = Vector3.Project(this.weaponsAnchor.position - this.MDAAIOPBMEF(), this.PMMEFNKFJIA.forward);
			if (Vector3.Dot(vector, this.PMMEFNKFJIA.forward) < 1279f)
			{
				this.weaponsAnchor.position -= vector;
			}
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.NMHFDAOIKEF().leftHand.position;
			this.OJMBOCNNLMI.solver.rightHandEffector.position = this.NMHFDAOIKEF().rightHand.position;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = this.weight;
			this.OJMBOCNNLMI.solver.OPEJJGIIIDO().bendConstraint.bendGoal = this.PFJCPCDKALA.bendGoalLeftArm;
			this.OJMBOCNNLMI.solver.HAFFDJFFPME().bendConstraint.bendGoal = this.PFJCPCDKALA.bendGoalRightArm;
			this.OJMBOCNNLMI.solver.leftArmChain.bendConstraint.weight = this.weight;
			this.OJMBOCNNLMI.solver.rightArmChain.bendConstraint.weight = this.weight;
			this.HCALHCCLMFO.weight = this.weight;
			this.EMBMBLHPJBP.weight = this.weight;
			this.animatorController.POLAMGDKIOL(this.weaponsAnchor.forward, this.animatorController.maxViewAngle, this.weaponsPivot);
			this.FOKFDOKIOED();
		}

		// Token: 0x0600E3DE RID: 58334 RVA: 0x0067BF94 File Offset: 0x0067A194
		private void NBEGFDOMFJP()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			this.OJMBOCNNLMI.references.leftHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.leftHand.rotation, this.PFJCPCDKALA.leftHand.rotation, this.weight);
			this.OJMBOCNNLMI.references.rightHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.rightHand.rotation, this.PFJCPCDKALA.rightHand.rotation, this.weight);
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x0067C039 File Offset: 0x0067A239
		private Transform IFCABGMEBFH()
		{
			return this.animatorController.cam;
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x0067C048 File Offset: 0x0067A248
		private void BJMFNPCBIIM(VRAimingController.Handedness ANJFKMCHPPO)
		{
			this.handedness = ANJFKMCHPPO;
			this.HCALHCCLMFO.poseRoot = this.PFJCPCDKALA.leftHand;
			this.EMBMBLHPJBP.poseRoot = this.PFJCPCDKALA.rightHand;
			this.HCALHCCLMFO.AutoMapping();
			this.EMBMBLHPJBP.AutoMapping();
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x0067C039 File Offset: 0x0067A239
		private Transform PMMEFNKFJIA
		{
			get
			{
				return this.animatorController.cam;
			}
		}

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x0067B919 File Offset: 0x00679B19
		private VRAimingController.Targets HGKCPMGFPFG()
		{
			if (this.handedness == VRAimingController.Handedness.Right)
			{
				return this.rightHandedTargets;
			}
			return this.leftHandedTargets;
		}

		// Token: 0x0600E3E3 RID: 58339 RVA: 0x0067C0A0 File Offset: 0x0067A2A0
		private void DOCFDIFPKHI()
		{
			if (this.weight <= 172f)
			{
				return;
			}
			this.OJMBOCNNLMI.references.leftHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.leftHand.rotation, this.PFJCPCDKALA.leftHand.rotation, this.weight);
			this.OJMBOCNNLMI.references.rightHand.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.references.rightHand.rotation, this.HGKCPMGFPFG().rightHand.rotation, this.weight);
		}

		// Token: 0x0600E3E4 RID: 58340 RVA: 0x0067C148 File Offset: 0x0067A348
		private void IIKDDILLGLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.HCALHCCLMFO = this.OJMBOCNNLMI.references.leftHand.GetComponent<Poser>();
			this.EMBMBLHPJBP = this.OJMBOCNNLMI.references.rightHand.GetComponent<Poser>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			this.PIJKOMKCJOG = this.weight;
			this.BJMFNPCBIIM(this.handedness);
			this.HNCLBJOLCOD = this.weaponsAnchor.localPosition;
			this.EDELBPFJBGL = this.weaponsPivot.localPosition;
			this.OCJGOBHACHI = this.pivotMotionTarget.InverseTransformPoint(this.weaponsPivot.position);
			this.DNLGOOJMCCH = this.MDAAIOPBMEF();
			this.PLKCBKCHHII = this.AEKACFEGADA().position;
		}

		// Token: 0x0600E3E5 RID: 58341 RVA: 0x0067C238 File Offset: 0x0067A438
		private void FOKFDOKIOED()
		{
			if (this.spineTwistWeight <= 0f)
			{
				return;
			}
			Vector3 forward = this.weaponsAnchor.forward;
			forward.y = 0f;
			Quaternion b = Quaternion.FromToRotation(base.transform.forward, forward);
			foreach (VRAimingController.BoneRotationOffset boneRotationOffset in this.PFJCPCDKALA.boneRotationOffsets)
			{
				boneRotationOffset.transform.rotation = Quaternion.Lerp(Quaternion.identity, b, 1f / (float)this.PFJCPCDKALA.boneRotationOffsets.Length * this.spineTwistWeight) * boneRotationOffset.transform.rotation;
			}
		}

		// Token: 0x0600E3E6 RID: 58342 RVA: 0x0067B919 File Offset: 0x00679B19
		private VRAimingController.Targets NMHFDAOIKEF()
		{
			if (this.handedness == VRAimingController.Handedness.Right)
			{
				return this.rightHandedTargets;
			}
			return this.leftHandedTargets;
		}

		// Token: 0x0600E3E7 RID: 58343 RVA: 0x0060FDB3 File Offset: 0x0060DFB3
		private float ILKJPHGKMEP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < -360f)
			{
				NEPBPMGGPKM += 360f;
			}
			if (NEPBPMGGPKM > 360f)
			{
				NEPBPMGGPKM -= 360f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x04001DB3 RID: 7603
		[Header("Component References")]
		public VRAnimatorController animatorController;

		// Token: 0x04001DB4 RID: 7604
		[Tooltip("Which weapon is the character holding at this time?")]
		public WeaponBase currentWeapon;

		// Token: 0x04001DB5 RID: 7605
		[Header("Weights")]
		[Tooltip("The master weight of aiming.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04001DB6 RID: 7606
		[Tooltip("The weight of twisting the spine to better hold the weapons")]
		[Range(0f, 1f)]
		public float spineTwistWeight = 1f;

		// Token: 0x04001DB7 RID: 7607
		[Header("Hands")]
		[Tooltip("Which hand holds the weapon?")]
		public VRAimingController.Handedness handedness;

		// Token: 0x04001DB8 RID: 7608
		[Tooltip("How far left/right to offset the weapons?")]
		public float sideOffset = 0.1f;

		// Token: 0x04001DB9 RID: 7609
		[Tooltip("Various references and settings for left handed weapons.")]
		public VRAimingController.Targets leftHandedTargets;

		// Token: 0x04001DBA RID: 7610
		[Tooltip("Various references and settings for right handed weapons.")]
		public VRAimingController.Targets rightHandedTargets;

		// Token: 0x04001DBB RID: 7611
		[Header("Weapon Positioning")]
		[Tooltip("The Transform that rotates the weapon.")]
		public Transform weaponsPivot;

		// Token: 0x04001DBC RID: 7612
		[Tooltip("Child of weaponsPivot, parent of all weapons.")]
		public Transform weaponsAnchor;

		// Token: 0x04001DBD RID: 7613
		[Tooltip("Weapons will inherit motion from that Transform.")]
		public Transform pivotMotionTarget;

		// Token: 0x04001DBE RID: 7614
		[Tooltip("Speed of various position/rotation interpolations.")]
		public float lerpSpeed = 8f;

		// Token: 0x04001DBF RID: 7615
		[Tooltip("The smoothing speed of inheriting motion from the pivotMotionTarget.")]
		public float pivotMotionSmoothSpeed = 5f;

		// Token: 0x04001DC0 RID: 7616
		[Tooltip("The weight of inheriting motion from the pivotMotionTarget,")]
		[Range(0f, 1f)]
		public float pivotMotionWeight = 0.5f;

		// Token: 0x04001DC1 RID: 7617
		[Tooltip("The limit of up/down rotation for the weapons.")]
		[Range(0f, 90f)]
		public float aimVerticalLimit = 80f;

		// Token: 0x04001DC2 RID: 7618
		[Tooltip("Local Z position of the weapons anchor when the weapon is locked to the camera (while holding RMB).")]
		public float aimZ = 0.05f;

		// Token: 0x04001DC3 RID: 7619
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x04001DC4 RID: 7620
		private float PIJKOMKCJOG;

		// Token: 0x04001DC5 RID: 7621
		private Poser HCALHCCLMFO;

		// Token: 0x04001DC6 RID: 7622
		private Poser EMBMBLHPJBP;

		// Token: 0x04001DC7 RID: 7623
		private Vector3 OCJGOBHACHI;

		// Token: 0x04001DC8 RID: 7624
		private Vector3 EDELBPFJBGL;

		// Token: 0x04001DC9 RID: 7625
		private Vector3 HNCLBJOLCOD;

		// Token: 0x04001DCA RID: 7626
		private Vector3 JEKFKPGCIHA;

		// Token: 0x04001DCB RID: 7627
		private Vector3 NMABNBGNENF;

		// Token: 0x04001DCC RID: 7628
		private float OCNGPCPMCPM;

		// Token: 0x04001DCD RID: 7629
		private float ADMFAEOOOHD;

		// Token: 0x04001DCE RID: 7630
		private float BGGLLEKHKDM;

		// Token: 0x04001DCF RID: 7631
		private Vector3 DNLGOOJMCCH;

		// Token: 0x04001DD0 RID: 7632
		private Vector3 PLKCBKCHHII;

		// Token: 0x0200041F RID: 1055
		[Serializable]
		public struct Targets
		{
			// Token: 0x04001DD1 RID: 7633
			public Transform leftHand;

			// Token: 0x04001DD2 RID: 7634
			public Transform rightHand;

			// Token: 0x04001DD3 RID: 7635
			public Transform bendGoalLeftArm;

			// Token: 0x04001DD4 RID: 7636
			public Transform bendGoalRightArm;

			// Token: 0x04001DD5 RID: 7637
			public VRAimingController.BoneRotationOffset[] boneRotationOffsets;
		}

		// Token: 0x02000420 RID: 1056
		[Serializable]
		public enum Handedness
		{
			// Token: 0x04001DD7 RID: 7639
			Right,
			// Token: 0x04001DD8 RID: 7640
			Left
		}

		// Token: 0x02000421 RID: 1057
		[Serializable]
		public class BoneRotationOffset
		{
			// Token: 0x04001DD9 RID: 7641
			public Transform transform;

			// Token: 0x04001DDA RID: 7642
			public Vector3 value;
		}
	}
}
