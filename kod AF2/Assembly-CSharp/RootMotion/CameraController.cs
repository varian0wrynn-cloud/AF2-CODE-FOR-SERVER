using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003DE RID: 990
	public class CameraController : MonoBehaviour
	{
		// Token: 0x0600D4C7 RID: 54471 RVA: 0x0060F7F7 File Offset: 0x0060D9F7
		protected virtual void BNKJNBIDPME()
		{
			if (this.updateMode == CameraController.UpdateMode.Update)
			{
				this.GOPPDMFJDBP();
			}
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x0060F807 File Offset: 0x0060DA07
		protected virtual void LateUpdate()
		{
			this.UpdateInput();
			if (this.updateMode == CameraController.UpdateMode.LateUpdate)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x0060F820 File Offset: 0x0060DA20
		public void UpdateInput()
		{
			if (this.target == null || !this.PMMEFNKFJIA.enabled)
			{
				return;
			}
			Cursor.lockState = (this.lockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.lockCursor;
			if (this.rotateAlways || (this.rotateOnLeftButton && Input.GetMouseButton(0)) || (this.rotateOnRightButton && Input.GetMouseButton(1)) || (this.rotateOnMiddleButton && Input.GetMouseButton(2)))
			{
				this.OCNGPCPMCPM += Input.GetAxis("Mouse X") * this.rotationSensitivity;
				this.ADMFAEOOOHD = this.ILKJPHGKMEP(this.ADMFAEOOOHD - Input.GetAxis("Mouse Y") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			}
			this.JGBIOIKLIGN = Mathf.Clamp(this.JGBIOIKLIGN + this.AOKIIFHBBMK, this.minDistance, this.maxDistance);
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x0060F91B File Offset: 0x0060DB1B
		protected virtual void GMKGLKKHGED()
		{
			if (this.updateMode == CameraController.UpdateMode.FixedUpdate)
			{
				this.GOPPDMFJDBP();
			}
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x0060F92C File Offset: 0x0060DB2C
		private float AIJHMAKGECP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 698f)
			{
				NEPBPMGGPKM += 1107f;
			}
			if (NEPBPMGGPKM > 1408f)
			{
				NEPBPMGGPKM -= 1584f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x0060F958 File Offset: 0x0060DB58
		protected virtual void JGIJIPNENLI()
		{
			if (this.updateMode == CameraController.UpdateMode.FixedUpdate)
			{
				this.BLGGIDJKKFI();
			}
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x0060F969 File Offset: 0x0060DB69
		public float JNNHOKBMAOO()
		{
			return this.<LAPBNDKCBEO>k__BackingField;
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x0060F971 File Offset: 0x0060DB71
		protected virtual void FixedUpdate()
		{
			if (this.updateMode == CameraController.UpdateMode.FixedUpdate)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600D4CF RID: 54479 RVA: 0x0060F969 File Offset: 0x0060DB69
		// (set) Token: 0x0600D4E3 RID: 54499 RVA: 0x0060F982 File Offset: 0x0060DB82
		public float ADMFAEOOOHD { get; private set; }

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x0060F982 File Offset: 0x0060DB82
		private void EHBNJFGLGGN(float DCCPCBLODIG)
		{
			this.<LAPBNDKCBEO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x0060F98B File Offset: 0x0060DB8B
		public float FDGGFPLGNIE()
		{
			return this.<CEKBMFELNIB>k__BackingField;
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x0060F994 File Offset: 0x0060DB94
		public void CFPCGNCDJCK()
		{
			if (this.target == null || !this.PMMEFNKFJIA.enabled)
			{
				return;
			}
			Cursor.lockState = (this.lockCursor ? CursorLockMode.None : CursorLockMode.None);
			Cursor.visible = (this.lockCursor || true);
			if (!this.rotateAlways && (!this.rotateOnLeftButton || !Input.GetMouseButton(0)) && (!this.rotateOnRightButton || !Input.GetMouseButton(1)) && (!this.rotateOnMiddleButton || Input.GetMouseButton(7)))
			{
				this.IJOLJCEEGJK(this.FDGGFPLGNIE() + Input.GetAxis("_DeepTex") * this.rotationSensitivity);
				this.EHBNJFGLGGN(this.AIJHMAKGECP(this.JNNHOKBMAOO() - Input.GetAxis("_DepthCurveLut") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit));
			}
			this.FIKCIEKKGCL(Mathf.Clamp(this.AIJKDDCHDFF() + this.DHOPOGKJJED(), this.minDistance, this.maxDistance));
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x0060FA8F File Offset: 0x0060DC8F
		protected virtual void OFPGMNGFLNH()
		{
			if (this.updateMode == CameraController.UpdateMode.Update)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x0060FAA0 File Offset: 0x0060DCA0
		public void ANKHMCCPKIO(float ENLHBNBNPJN)
		{
			if (this.target == null || !this.PMMEFNKFJIA.enabled)
			{
				return;
			}
			this.distance += (this.AIJKDDCHDFF() - this.distance) * this.zoomSpeed * ENLHBNBNPJN;
			this.PHKIOHIBNPA = Quaternion.AngleAxis(this.ECMAPLIGAJM(), Vector3.up) * Quaternion.AngleAxis(this.CLACOMDHCIK(), Vector3.right);
			if (this.rotationSpace != null)
			{
				this.AJMNDCHJPNK = Quaternion.FromToRotation(this.ODLHCADLFPP, this.rotationSpace.up) * this.AJMNDCHJPNK;
				this.PHKIOHIBNPA = this.AJMNDCHJPNK * this.PHKIOHIBNPA;
				this.ODLHCADLFPP = this.rotationSpace.up;
			}
			if (!this.smoothFollow)
			{
				this.HLLIBEJAABP = this.target.position;
			}
			else
			{
				this.HLLIBEJAABP = Vector3.Lerp(this.HLLIBEJAABP, this.target.position, ENLHBNBNPJN * this.followSpeed);
			}
			this.MGALEAJOGPL = this.HLLIBEJAABP + this.PHKIOHIBNPA * (this.offset - Vector3.forward * this.distance);
			base.transform.position = this.MGALEAJOGPL;
			base.transform.rotation = this.PHKIOHIBNPA;
		}

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x0060FC0C File Offset: 0x0060DE0C
		private float DHOPOGKJJED()
		{
			float axis = Input.GetAxis("Reset");
			if (axis > 1054f)
			{
				return -this.zoomSensitivity;
			}
			if (axis < 850f)
			{
				return this.zoomSensitivity;
			}
			return 1483f;
		}

		// Token: 0x0600D4D6 RID: 54486 RVA: 0x0060FC48 File Offset: 0x0060DE48
		private float BICKHKDAMND(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1113f)
			{
				NEPBPMGGPKM += 202f;
			}
			if (NEPBPMGGPKM > 746f)
			{
				NEPBPMGGPKM -= 418f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x0060FC74 File Offset: 0x0060DE74
		public void UpdateTransform()
		{
			this.UpdateTransform(Time.deltaTime);
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x0060FC81 File Offset: 0x0060DE81
		protected virtual void CIJDJLHJHHC()
		{
			if (this.updateMode == CameraController.UpdateMode.FixedUpdate)
			{
				this.DODLNHGCOJL();
			}
		}

		// Token: 0x0600D4D9 RID: 54489 RVA: 0x0060F982 File Offset: 0x0060DB82
		private void CHHDGCEICAK(float DCCPCBLODIG)
		{
			this.<LAPBNDKCBEO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x0060FC92 File Offset: 0x0060DE92
		private void IJOLJCEEGJK(float DCCPCBLODIG)
		{
			this.<CEKBMFELNIB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x0060FC74 File Offset: 0x0060DE74
		public void BLGGIDJKKFI()
		{
			this.UpdateTransform(Time.deltaTime);
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		private void FIKCIEKKGCL(float DCCPCBLODIG)
		{
			this.<OBBPNJPDHDL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		private void CCEFDAPIFNA(float DCCPCBLODIG)
		{
			this.<OBBPNJPDHDL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x0060F969 File Offset: 0x0060DB69
		public float GEDGMMBKPPN()
		{
			return this.<LAPBNDKCBEO>k__BackingField;
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		private void CPGLAJAINLJ(float DCCPCBLODIG)
		{
			this.<OBBPNJPDHDL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600D4E1 RID: 54497 RVA: 0x0060FD60 File Offset: 0x0060DF60
		private float AOKIIFHBBMK
		{
			get
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis > 0f)
				{
					return -this.zoomSensitivity;
				}
				if (axis < 0f)
				{
					return this.zoomSensitivity;
				}
				return 0f;
			}
		}

		// Token: 0x0600D4E2 RID: 54498 RVA: 0x0060FD9C File Offset: 0x0060DF9C
		protected virtual void HKJHIANMOPG()
		{
			this.UpdateInput();
			if (this.updateMode == (CameraController.UpdateMode)5)
			{
				this.BLGGIDJKKFI();
			}
		}

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x0060F98B File Offset: 0x0060DB8B
		public float ECMAPLIGAJM()
		{
			return this.<CEKBMFELNIB>k__BackingField;
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x0060F969 File Offset: 0x0060DB69
		public float MGADKCBHGNI()
		{
			return this.<LAPBNDKCBEO>k__BackingField;
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x0060FDB3 File Offset: 0x0060DFB3
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

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x0060F969 File Offset: 0x0060DB69
		public float CLACOMDHCIK()
		{
			return this.<LAPBNDKCBEO>k__BackingField;
		}

		// Token: 0x0600D4E8 RID: 54504 RVA: 0x0060FDDF File Offset: 0x0060DFDF
		private float JBMNOKLFMMN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1274f)
			{
				NEPBPMGGPKM += 1690f;
			}
			if (NEPBPMGGPKM > 1119f)
			{
				NEPBPMGGPKM -= 1431f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x0060FE0C File Offset: 0x0060E00C
		private float AICNLLKFOOO()
		{
			float axis = Input.GetAxis("wpn_cat3");
			if (axis > 198f)
			{
				return -this.zoomSensitivity;
			}
			if (axis < 1159f)
			{
				return this.zoomSensitivity;
			}
			return 357f;
		}

		// Token: 0x0600D4EA RID: 54506 RVA: 0x0060FA8F File Offset: 0x0060DC8F
		protected virtual void Update()
		{
			if (this.updateMode == CameraController.UpdateMode.Update)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x00610180 File Offset: 0x0060E380
		// (set) Token: 0x0600D4EB RID: 54507 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		public float JGBIOIKLIGN { get; private set; }

		// Token: 0x0600D4EC RID: 54508 RVA: 0x0060FE48 File Offset: 0x0060E048
		private float FANBJKAMCAO()
		{
			float axis = Input.GetAxis("SAMPLES_VERY_LOW");
			if (axis > 522f)
			{
				return -this.zoomSensitivity;
			}
			if (axis < 756f)
			{
				return this.zoomSensitivity;
			}
			return 1024f;
		}

		// Token: 0x0600D4ED RID: 54509 RVA: 0x0060FE84 File Offset: 0x0060E084
		protected virtual void GDMEEIBDKLP()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.IJOLJCEEGJK(eulerAngles.y);
			this.EHBNJFGLGGN(eulerAngles.x);
			this.CPGLAJAINLJ(this.distance);
			this.HLLIBEJAABP = base.transform.position;
			this.PMMEFNKFJIA = base.GetComponent<Camera>();
			this.ODLHCADLFPP = ((this.rotationSpace != null) ? this.rotationSpace.up : Vector3.up);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600D4EE RID: 54510 RVA: 0x0060F98B File Offset: 0x0060DB8B
		// (set) Token: 0x0600D4F0 RID: 54512 RVA: 0x0060FC92 File Offset: 0x0060DE92
		public float OCNGPCPMCPM { get; private set; }

		// Token: 0x0600D4EF RID: 54511 RVA: 0x0060FF04 File Offset: 0x0060E104
		public void GOPPDMFJDBP()
		{
			this.ANKHMCCPKIO(Time.deltaTime);
		}

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x0060FC74 File Offset: 0x0060DE74
		public void DODLNHGCOJL()
		{
			this.UpdateTransform(Time.deltaTime);
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x0060FF14 File Offset: 0x0060E114
		public void UpdateTransform(float ENLHBNBNPJN)
		{
			if (this.target == null || !this.PMMEFNKFJIA.enabled)
			{
				return;
			}
			this.distance += (this.JGBIOIKLIGN - this.distance) * this.zoomSpeed * ENLHBNBNPJN;
			this.PHKIOHIBNPA = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
			if (this.rotationSpace != null)
			{
				this.AJMNDCHJPNK = Quaternion.FromToRotation(this.ODLHCADLFPP, this.rotationSpace.up) * this.AJMNDCHJPNK;
				this.PHKIOHIBNPA = this.AJMNDCHJPNK * this.PHKIOHIBNPA;
				this.ODLHCADLFPP = this.rotationSpace.up;
			}
			if (!this.smoothFollow)
			{
				this.HLLIBEJAABP = this.target.position;
			}
			else
			{
				this.HLLIBEJAABP = Vector3.Lerp(this.HLLIBEJAABP, this.target.position, ENLHBNBNPJN * this.followSpeed);
			}
			this.MGALEAJOGPL = this.HLLIBEJAABP + this.PHKIOHIBNPA * (this.offset - Vector3.forward * this.distance);
			base.transform.position = this.MGALEAJOGPL;
			base.transform.rotation = this.PHKIOHIBNPA;
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x00610080 File Offset: 0x0060E280
		protected virtual void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
			this.JGBIOIKLIGN = this.distance;
			this.HLLIBEJAABP = base.transform.position;
			this.PMMEFNKFJIA = base.GetComponent<Camera>();
			this.ODLHCADLFPP = ((this.rotationSpace != null) ? this.rotationSpace.up : Vector3.up);
		}

		// Token: 0x0600D4F4 RID: 54516 RVA: 0x00610100 File Offset: 0x0060E300
		protected virtual void NKHMBEDDFAJ()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.CHHDGCEICAK(eulerAngles.x);
			this.BEECAMKACAC(this.distance);
			this.HLLIBEJAABP = base.transform.position;
			this.PMMEFNKFJIA = base.GetComponent<Camera>();
			this.ODLHCADLFPP = ((this.rotationSpace != null) ? this.rotationSpace.up : Vector3.up);
		}

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		private void BEECAMKACAC(float DCCPCBLODIG)
		{
			this.<OBBPNJPDHDL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x00610180 File Offset: 0x0060E380
		public float AIJKDDCHDFF()
		{
			return this.<OBBPNJPDHDL>k__BackingField;
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x0060FC9B File Offset: 0x0060DE9B
		private void FIHLCCNECOM(float DCCPCBLODIG)
		{
			this.<OBBPNJPDHDL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x04001C27 RID: 7207
		public Transform target;

		// Token: 0x04001C28 RID: 7208
		public Transform rotationSpace;

		// Token: 0x04001C29 RID: 7209
		public CameraController.UpdateMode updateMode = CameraController.UpdateMode.LateUpdate;

		// Token: 0x04001C2A RID: 7210
		public bool lockCursor = true;

		// Token: 0x04001C2B RID: 7211
		public bool smoothFollow;

		// Token: 0x04001C2C RID: 7212
		public float followSpeed = 10f;

		// Token: 0x04001C2D RID: 7213
		public float distance = 10f;

		// Token: 0x04001C2E RID: 7214
		public float minDistance = 4f;

		// Token: 0x04001C2F RID: 7215
		public float maxDistance = 10f;

		// Token: 0x04001C30 RID: 7216
		public float zoomSpeed = 10f;

		// Token: 0x04001C31 RID: 7217
		public float zoomSensitivity = 1f;

		// Token: 0x04001C32 RID: 7218
		public float rotationSensitivity = 3.5f;

		// Token: 0x04001C33 RID: 7219
		public float yMinLimit = -20f;

		// Token: 0x04001C34 RID: 7220
		public float yMaxLimit = 80f;

		// Token: 0x04001C35 RID: 7221
		public Vector3 offset = new Vector3(0f, 1.5f, 0.5f);

		// Token: 0x04001C36 RID: 7222
		public bool rotateAlways = true;

		// Token: 0x04001C37 RID: 7223
		public bool rotateOnLeftButton;

		// Token: 0x04001C38 RID: 7224
		public bool rotateOnRightButton;

		// Token: 0x04001C39 RID: 7225
		public bool rotateOnMiddleButton;

		// Token: 0x04001C3D RID: 7229
		private Vector3 HEJEJALAHBM;

		// Token: 0x04001C3E RID: 7230
		private Vector3 MGALEAJOGPL;

		// Token: 0x04001C3F RID: 7231
		private Quaternion PHKIOHIBNPA = Quaternion.identity;

		// Token: 0x04001C40 RID: 7232
		private Vector3 HLLIBEJAABP;

		// Token: 0x04001C41 RID: 7233
		private Camera PMMEFNKFJIA;

		// Token: 0x04001C42 RID: 7234
		private Quaternion AJMNDCHJPNK = Quaternion.identity;

		// Token: 0x04001C43 RID: 7235
		private Vector3 ODLHCADLFPP;

		// Token: 0x020003DF RID: 991
		[Serializable]
		public enum UpdateMode
		{
			// Token: 0x04001C45 RID: 7237
			Update,
			// Token: 0x04001C46 RID: 7238
			FixedUpdate,
			// Token: 0x04001C47 RID: 7239
			LateUpdate
		}
	}
}
