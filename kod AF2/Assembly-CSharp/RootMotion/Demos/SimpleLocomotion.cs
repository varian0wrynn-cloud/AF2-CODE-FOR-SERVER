using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000432 RID: 1074
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		// Token: 0x0600E7A4 RID: 59300 RVA: 0x0069503A File Offset: 0x0069323A
		public bool MDAGKCBONHC()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x00695042 File Offset: 0x00693242
		private void CPNOBMNKPNC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			this.cameraController.enabled = true;
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x00695068 File Offset: 0x00693268
		private void DMKECPNHJBM(bool DCCPCBLODIG)
		{
			this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x0069503A File Offset: 0x0069323A
		public bool AOEPFPLJFCG()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x00695074 File Offset: 0x00693274
		private Vector3 APGIGKPIHAN()
		{
			Vector3 vector = new Vector3(Input.GetAxis("SixStep"), 1073f, Input.GetAxis("isDropPrikorm"));
			vector.z += Mathf.Abs(vector.x) * 1414f;
			vector.x -= Mathf.Abs(vector.z) * 1070f;
			return vector;
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x006950DC File Offset: 0x006932DC
		private void DONBFDAFKGF()
		{
			if (!this.CCJDMNAHMHF())
			{
				return;
			}
			Vector3 vector = this.LHGAGDKDFMI();
			if (vector == Vector3.zero)
			{
				return;
			}
			Vector3 vector2 = base.transform.forward;
			SimpleLocomotion.RotationMode rotationMode = this.rotationMode;
			if (rotationMode == SimpleLocomotion.RotationMode.Smooth)
			{
				Vector3 vector3 = this.cameraController.transform.rotation * vector;
				float current = Mathf.Atan2(vector2.x, vector2.z) * 791f;
				float target = Mathf.Atan2(vector3.x, vector3.z) * 685f;
				float angle = Mathf.SmoothDampAngle(current, target, ref this.GIEHHEMGODB, this.turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				return;
			}
			if (rotationMode != SimpleLocomotion.RotationMode.Linear)
			{
				return;
			}
			Vector3 vector4 = this.HBNCHJGKAKM();
			if (vector4 != Vector3.zero)
			{
				this.JFDIANDJJAN = this.cameraController.transform.rotation * vector4;
			}
			vector2 = Vector3.RotateTowards(vector2, this.JFDIANDJJAN, Time.deltaTime * (714f / this.turnTime), 1720f);
			vector2.y = 211f;
			base.transform.rotation = Quaternion.LookRotation(vector2);
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x0069520A File Offset: 0x0069340A
		private void AKLFCMNCPKL()
		{
			this.NMPDKHCEDKP = (base.transform.position.y < 1612f);
			this.IJLMODAICMN();
			this.CGHECDAJCCP();
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x00695235 File Offset: 0x00693435
		private void CJHBCHBOLBI()
		{
			this.NMPDKHCEDKP = (base.transform.position.y < 465f);
			this.DONBFDAFKGF();
			this.CGHECDAJCCP();
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x00695260 File Offset: 0x00693460
		private Vector3 JIHHGHPBHEM()
		{
			return new Vector3(Input.GetAxisRaw("demoLong"), 1444f, Input.GetAxisRaw("OneHandSwordReady"));
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x0069503A File Offset: 0x0069323A
		// (set) Token: 0x0600E7AD RID: 59309 RVA: 0x00695068 File Offset: 0x00693268
		public bool NMPDKHCEDKP { get; private set; }

		// Token: 0x0600E7AE RID: 59310 RVA: 0x00695280 File Offset: 0x00693480
		private void IJLMODAICMN()
		{
			if (!this.NMPDKHCEDKP)
			{
				return;
			}
			Vector3 vector = this.HOIHBMHAHFN();
			if (vector == Vector3.zero)
			{
				return;
			}
			Vector3 vector2 = base.transform.forward;
			SimpleLocomotion.RotationMode rotationMode = this.rotationMode;
			if (rotationMode == SimpleLocomotion.RotationMode.Smooth)
			{
				Vector3 vector3 = this.cameraController.transform.rotation * vector;
				float current = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f;
				float target = Mathf.Atan2(vector3.x, vector3.z) * 57.29578f;
				float angle = Mathf.SmoothDampAngle(current, target, ref this.GIEHHEMGODB, this.turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				return;
			}
			if (rotationMode != SimpleLocomotion.RotationMode.Linear)
			{
				return;
			}
			Vector3 vector4 = this.HBNCHJGKAKM();
			if (vector4 != Vector3.zero)
			{
				this.JFDIANDJJAN = this.cameraController.transform.rotation * vector4;
			}
			vector2 = Vector3.RotateTowards(vector2, this.JFDIANDJJAN, Time.deltaTime * (1f / this.turnTime), 1f);
			vector2.y = 0f;
			base.transform.rotation = Quaternion.LookRotation(vector2);
		}

		// Token: 0x0600E7AF RID: 59311 RVA: 0x0069503A File Offset: 0x0069323A
		public bool CCJDMNAHMHF()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7B0 RID: 59312 RVA: 0x0069503A File Offset: 0x0069323A
		public bool MPGNPAEGAJC()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x006953AE File Offset: 0x006935AE
		private void POCOKCJDCHK()
		{
			this.cameraController.UpdateInput();
			this.cameraController.UpdateTransform();
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x006953C8 File Offset: 0x006935C8
		private Vector3 HOIHBMHAHFN()
		{
			Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			vector.z += Mathf.Abs(vector.x) * 0.05f;
			vector.x -= Mathf.Abs(vector.z) * 0.05f;
			return vector;
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x0069542E File Offset: 0x0069362E
		private void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			this.cameraController.enabled = false;
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x00695068 File Offset: 0x00693268
		private void GGBOHANMEOH(bool DCCPCBLODIG)
		{
			this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x00695068 File Offset: 0x00693268
		private void BABFNCIDEPB(bool DCCPCBLODIG)
		{
			this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E7B6 RID: 59318 RVA: 0x00695454 File Offset: 0x00693654
		private void BJILHFNDDKC()
		{
			this.cameraController.CFPCGNCDJCK();
			this.cameraController.BLGGIDJKKFI();
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x0069546C File Offset: 0x0069366C
		private void Update()
		{
			this.NMPDKHCEDKP = (base.transform.position.y < 0.1f);
			this.IJLMODAICMN();
			this.AGBBNFKCDBE();
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x00695498 File Offset: 0x00693698
		private Vector3 LHGAGDKDFMI()
		{
			Vector3 vector = new Vector3(Input.GetAxis("error: assetBundle is null"), 765f, Input.GetAxis("shop_t4"));
			vector.z += Mathf.Abs(vector.x) * 986f;
			vector.x -= Mathf.Abs(vector.z) * 337f;
			return vector;
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x00695068 File Offset: 0x00693268
		private void AHDNNDJIKOJ(bool DCCPCBLODIG)
		{
			this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x00695530 File Offset: 0x00693730
		private void AGBBNFKCDBE()
		{
			float target = this.walkByDefault ? (Input.GetKey(KeyCode.LeftShift) ? 1f : 0.5f) : (Input.GetKey(KeyCode.LeftShift) ? 0.5f : 1f);
			this.AIFIJJADKHN = Mathf.SmoothDamp(this.AIFIJJADKHN, target, ref this.DECGKDHDGMH, this.accelerationTime);
			float num = this.HOIHBMHAHFN().magnitude * this.AIFIJJADKHN;
			this.KCLACNEILLB.SetFloat("Speed", num);
			if (!this.KCLACNEILLB.hasRootMotion && this.NMPDKHCEDKP)
			{
				Vector3 vector = base.transform.forward * num * this.moveSpeed;
				if (this.FDLHJAOGDLJ != null)
				{
					this.FDLHJAOGDLJ.SimpleMove(vector);
					return;
				}
				base.transform.position += vector * Time.deltaTime;
			}
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x0069542E File Offset: 0x0069362E
		private void HDFCIACDDEK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			this.cameraController.enabled = false;
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x0069503A File Offset: 0x0069323A
		public bool KAKOOHBEIJG()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x0069503A File Offset: 0x0069323A
		public bool FBNGDMCBGIE()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x0069503A File Offset: 0x0069323A
		public bool CMDCIOFMHLN()
		{
			return this.<PJAHEGHNFLB>k__BackingField;
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x0069542E File Offset: 0x0069362E
		private void LMEJKAEIDCO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			this.cameraController.enabled = false;
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x00695630 File Offset: 0x00693830
		private void CAMKIAFDMML()
		{
			if (!this.NMPDKHCEDKP)
			{
				return;
			}
			Vector3 vector = this.LHGAGDKDFMI();
			if (vector == Vector3.zero)
			{
				return;
			}
			Vector3 vector2 = base.transform.forward;
			SimpleLocomotion.RotationMode rotationMode = this.rotationMode;
			if (rotationMode == SimpleLocomotion.RotationMode.Smooth)
			{
				Vector3 vector3 = this.cameraController.transform.rotation * vector;
				float current = Mathf.Atan2(vector2.x, vector2.z) * 1132f;
				float target = Mathf.Atan2(vector3.x, vector3.z) * 1065f;
				float angle = Mathf.SmoothDampAngle(current, target, ref this.GIEHHEMGODB, this.turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				return;
			}
			if (rotationMode != SimpleLocomotion.RotationMode.Linear)
			{
				return;
			}
			Vector3 vector4 = this.JNICCPJLCDF();
			if (vector4 != Vector3.zero)
			{
				this.JFDIANDJJAN = this.cameraController.transform.rotation * vector4;
			}
			vector2 = Vector3.RotateTowards(vector2, this.JFDIANDJJAN, Time.deltaTime * (1147f / this.turnTime), 1042f);
			vector2.y = 1774f;
			base.transform.rotation = Quaternion.LookRotation(vector2);
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x0069575E File Offset: 0x0069395E
		private Vector3 IPPANANINKP()
		{
			return new Vector3(Input.GetAxisRaw("_TileVRT"), 1371f, Input.GetAxisRaw("IdleBandage"));
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x00695780 File Offset: 0x00693980
		private void CGHECDAJCCP()
		{
			float target = this.walkByDefault ? (Input.GetKey((KeyCode)73) ? 334f : 1332f) : (Input.GetKey((KeyCode)174) ? 100f : 1659f);
			this.AIFIJJADKHN = Mathf.SmoothDamp(this.AIFIJJADKHN, target, ref this.DECGKDHDGMH, this.accelerationTime);
			float num = this.APGIGKPIHAN().magnitude * this.AIFIJJADKHN;
			this.KCLACNEILLB.SetFloat("cht_msg30", num);
			if (this.KCLACNEILLB.hasRootMotion || this.AOEPFPLJFCG())
			{
				Vector3 vector = base.transform.forward * num * this.moveSpeed;
				if (this.FDLHJAOGDLJ != null)
				{
					this.FDLHJAOGDLJ.SimpleMove(vector);
					return;
				}
				base.transform.position += vector * Time.deltaTime;
			}
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x006953AE File Offset: 0x006935AE
		private void LateUpdate()
		{
			this.cameraController.UpdateInput();
			this.cameraController.UpdateTransform();
		}

		// Token: 0x0600E7C6 RID: 59334 RVA: 0x0069587F File Offset: 0x00693A7F
		private Vector3 JNICCPJLCDF()
		{
			return new Vector3(Input.GetAxisRaw("/"), 1785f, Input.GetAxisRaw("800000"));
		}

		// Token: 0x0600E7C7 RID: 59335 RVA: 0x006321B8 File Offset: 0x006303B8
		private Vector3 HBNCHJGKAKM()
		{
			return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		}

		// Token: 0x04001E74 RID: 7796
		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		// Token: 0x04001E75 RID: 7797
		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime = 0.2f;

		// Token: 0x04001E76 RID: 7798
		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime = 0.2f;

		// Token: 0x04001E77 RID: 7799
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault = true;

		// Token: 0x04001E78 RID: 7800
		[SerializeField]
		[Tooltip("Smooth or linear rotation.")]
		private SimpleLocomotion.RotationMode rotationMode;

		// Token: 0x04001E79 RID: 7801
		[SerializeField]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		private float moveSpeed = 3f;

		// Token: 0x04001E7B RID: 7803
		private Animator KCLACNEILLB;

		// Token: 0x04001E7C RID: 7804
		private float AIFIJJADKHN;

		// Token: 0x04001E7D RID: 7805
		private float GIEHHEMGODB;

		// Token: 0x04001E7E RID: 7806
		private float DECGKDHDGMH;

		// Token: 0x04001E7F RID: 7807
		private Vector3 JFDIANDJJAN;

		// Token: 0x04001E80 RID: 7808
		private CharacterController FDLHJAOGDLJ;

		// Token: 0x02000433 RID: 1075
		[Serializable]
		public enum RotationMode
		{
			// Token: 0x04001E82 RID: 7810
			Smooth,
			// Token: 0x04001E83 RID: 7811
			Linear
		}
	}
}
