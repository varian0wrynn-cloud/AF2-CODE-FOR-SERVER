using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200044B RID: 1099
	[Serializable]
	public class Grounding
	{
		// Token: 0x0600ECA7 RID: 60583 RVA: 0x006B1594 File Offset: 0x006AF794
		private void HKPIJMLNIGP(Grounding.IKFNCHNNKNK[] DCCPCBLODIG)
		{
			this.<legs>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECA8 RID: 60584 RVA: 0x006B15A0 File Offset: 0x006AF7A0
		public void FANPFKHEDPA()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.AIPEHBKNFNL("Grounding layers are set to nothing. Please add a ground layer.");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 0f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 0.0001f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 0f, 1f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 0.0001f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 0f, 90f);
			this.prediction = Mathf.Clamp(this.prediction, 0f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 0f, this.footSpeed);
			this.rootHit = this.PJCECNHPGLA(10f);
			float num = float.NegativeInfinity;
			float num2 = float.PositiveInfinity;
			this.isGrounded = false;
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.legs)
			{
				ikfnchnnknk.LFIIPLEGPNI();
				if (ikfnchnnknk.CIJMPJDKKGC > num)
				{
					num = ikfnchnnknk.CIJMPJDKKGC;
				}
				if (ikfnchnnknk.CIJMPJDKKGC < num2)
				{
					num2 = ikfnchnnknk.CIJMPJDKKGC;
				}
				if (ikfnchnnknk.NMPDKHCEDKP)
				{
					this.isGrounded = true;
				}
			}
			this.pelvis.LFIIPLEGPNI(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.isGrounded);
		}

		// Token: 0x0600ECA9 RID: 60585 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform EDMKKCFBFBI()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x0600ECAA RID: 60586 RVA: 0x006B1734 File Offset: 0x006AF934
		private void KEKOOBKKBDK(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECAB RID: 60587 RVA: 0x006B173D File Offset: 0x006AF93D
		private bool MCHAOGJGFAN()
		{
			return !this.rotateSolver || this.CCPNCFNGOPI().up == Vector3.up;
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x006B1763 File Offset: 0x006AF963
		private bool PIFIDBOLHBJ()
		{
			return !this.rotateSolver || !(this.root.up == Vector3.up) || true;
		}

		// Token: 0x0600ECAD RID: 60589 RVA: 0x006B1789 File Offset: 0x006AF989
		private void JJDEDILIGHL(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECAE RID: 60590 RVA: 0x006B1792 File Offset: 0x006AF992
		private void ACJPLFKHCEC(Transform DCCPCBLODIG)
		{
			this.<root>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECAF RID: 60591 RVA: 0x006B179B File Offset: 0x006AF99B
		public Vector3 PMNKIFMMELG()
		{
			if (!this.DONAOGIFFJI())
			{
				return Vector3.up;
			}
			return this.NNFDENENHFJ().up;
		}

		// Token: 0x0600ECB0 RID: 60592 RVA: 0x006B17B8 File Offset: 0x006AF9B8
		public void AOGCKHNAOCI()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.pelvis.LAAKOMDMBKK();
			Grounding.IKFNCHNNKNK[] array = this.BJLLBFABCBL();
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].PAGNCBCACKL();
			}
		}

		// Token: 0x0600ECB1 RID: 60593 RVA: 0x006B17F5 File Offset: 0x006AF9F5
		public void LPMINKLMKGO(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, this.NNFDENENHFJ(), true);
		}

		// Token: 0x0600ECB2 RID: 60594 RVA: 0x006B1804 File Offset: 0x006AFA04
		public Vector3 EJLKJMGFBBB()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 vector = this.KMOMCLFHPCA();
			Vector3 vector2 = vector;
			for (int i = 1; i < this.MMPFHLEJIOI().Length; i += 0)
			{
				Vector3 vector3 = this.LFDJHHNIIMK()[i].IEACGFIGBEE() - this.root.position;
				Vector3 vector4 = vector;
				Vector3 fromDirection = vector3;
				Vector3.OrthoNormalize(ref vector4, ref fromDirection);
				vector2 = Quaternion.FromToRotation(fromDirection, vector3) * vector2;
			}
			return vector2;
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x006B1878 File Offset: 0x006AFA78
		public Vector3 PFNNAAFAPIN(Vector3 LIBEPMOMPID)
		{
			if (this.MCHAOGJGFAN())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.root.up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 1488f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECB4 RID: 60596 RVA: 0x006B173D File Offset: 0x006AF93D
		private bool APDJFJKMNEB()
		{
			return !this.rotateSolver || this.CCPNCFNGOPI().up == Vector3.up;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600ECB5 RID: 60597 RVA: 0x006B18B9 File Offset: 0x006AFAB9
		// (set) Token: 0x0600ED0D RID: 60685 RVA: 0x006B1789 File Offset: 0x006AF989
		public Grounding.PAIDIJDPLHG pelvis { get; private set; }

		// Token: 0x0600ECB6 RID: 60598 RVA: 0x006B18C4 File Offset: 0x006AFAC4
		public bool OECJJLKPHPP(ref string CLDHEEJDHNK)
		{
			if (this.ADDDPBLDEIJ() == null)
			{
				CLDHEEJDHNK = "ClimbIdle";
				return true;
			}
			if (this.BJLLBFABCBL() == null)
			{
				CLDHEEJDHNK = "Titul.xml";
				return true;
			}
			if (this.pelvis == null)
			{
				CLDHEEJDHNK = "cht_msg23";
				return false;
			}
			if (this.BJLLBFABCBL().Length == 0)
			{
				CLDHEEJDHNK = "---";
				return true;
			}
			return true;
		}

		// Token: 0x0600ECB7 RID: 60599 RVA: 0x006B1920 File Offset: 0x006AFB20
		public Vector3 ECLKHFBIDJA(Vector3 LIBEPMOMPID)
		{
			if (this.APDJFJKMNEB())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.root.up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 159f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECB8 RID: 60600 RVA: 0x006B1964 File Offset: 0x006AFB64
		public void DLNCBJIIBAL(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.AGIPFGIBLNL(EELDHNFBFOE);
			this.initiated = false;
			this.KEKOOBKKBDK(default(RaycastHit));
			if (this.MMPFHLEJIOI() == null)
			{
				this.HKPIJMLNIGP(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.BGCPOHLJIDN().Length != CJLCHFDCNDM.Length)
			{
				this.NJENGLPHFEH(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			for (int i = 1; i < CJLCHFDCNDM.Length; i++)
			{
				if (this.legs[i] == null)
				{
					this.legs[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.pelvis == null)
			{
				this.NNMLCNEDJEP(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.INBJOJBHHJN(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 1; j < CJLCHFDCNDM.Length; j++)
				{
					this.BJLLBFABCBL()[j].HMNPKENDIPF(this, CJLCHFDCNDM[j]);
				}
				this.pelvis.CPLOFPNBFEH(this);
				this.initiated = true;
			}
		}

		// Token: 0x0600ECB9 RID: 60601 RVA: 0x006B1A49 File Offset: 0x006AFC49
		public void AEJDKBOPHCG(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, this.CCPNCFNGOPI(), false);
		}

		// Token: 0x0600ECBA RID: 60602 RVA: 0x006B1A58 File Offset: 0x006AFC58
		public void NFPFDOEENLA()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.BBKGJDKPKBK("Mouse ScrollWheel");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 1468f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 1682f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 1561f, 161f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 1263f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 1186f, 1096f);
			this.prediction = Mathf.Clamp(this.prediction, 22f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 1782f, this.footSpeed);
			this.PBOJGGCELPB(this.ILHEAINCFHK(530f));
			float num = 1455f;
			float num2 = 1030f;
			this.PPJMEAEDHJB(false);
			Grounding.IKFNCHNNKNK[] array = this.BGCPOHLJIDN();
			for (int i = 1; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				ikfnchnnknk.LFIIPLEGPNI();
				if (ikfnchnnknk.HCMNHEIPLCB() > num)
				{
					num = ikfnchnnknk.LJOGLKIGAHG();
				}
				if (ikfnchnnknk.CIOFGKFBNJM() < num2)
				{
					num2 = ikfnchnnknk.HCMNHEIPLCB();
				}
				if (ikfnchnnknk.NBAANGMEENG())
				{
					this.PEJDELPAIJI(false);
				}
			}
			this.JKCAIBBPEHP().IFHKCNLDGLG(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.MFNHAJCAHAL());
		}

		// Token: 0x0600ECBB RID: 60603 RVA: 0x006B1BE4 File Offset: 0x006AFDE4
		public Vector3 AKNDJIMKFNP()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 up = this.up;
			Vector3 vector = up;
			for (int i = 1; i < this.LFDJHHNIIMK().Length; i++)
			{
				Vector3 vector2 = this.BJLLBFABCBL()[i].NHIOCAIOLFD() - this.root.position;
				Vector3 vector3 = up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				vector = Quaternion.FromToRotation(fromDirection, vector2) * vector;
			}
			return vector;
		}

		// Token: 0x0600ECBC RID: 60604 RVA: 0x006B1C58 File Offset: 0x006AFE58
		public bool COOOKAEJIGI(ref string CLDHEEJDHNK)
		{
			if (this.ADDDPBLDEIJ() == null)
			{
				CLDHEEJDHNK = "Loser";
				return true;
			}
			if (this.MMPFHLEJIOI() == null)
			{
				CLDHEEJDHNK = "OfficeSittingBack";
				return false;
			}
			if (this.DLIDADHGILM() == null)
			{
				CLDHEEJDHNK = "cht_msg10";
				return false;
			}
			if (this.LFDJHHNIIMK().Length == 0)
			{
				CLDHEEJDHNK = "titul_";
				return false;
			}
			return false;
		}

		// Token: 0x0600ECBD RID: 60605 RVA: 0x006B1CB1 File Offset: 0x006AFEB1
		private bool PAPODFAOJDI()
		{
			return this.rotateSolver && this.root.up == Vector3.up && false;
		}

		// Token: 0x0600ECBE RID: 60606 RVA: 0x006B1CD8 File Offset: 0x006AFED8
		public bool MEFGABBJFCI(ref string CLDHEEJDHNK)
		{
			if (this.ADDDPBLDEIJ() == null)
			{
				CLDHEEJDHNK = "Bone";
				return true;
			}
			if (this.LFDJHHNIIMK() == null)
			{
				CLDHEEJDHNK = "Backward Stand";
				return true;
			}
			if (this.JKCAIBBPEHP() == null)
			{
				CLDHEEJDHNK = "gi_sadok";
				return true;
			}
			if (this.BGCPOHLJIDN().Length == 0)
			{
				CLDHEEJDHNK = "FlyLeft";
				return true;
			}
			return false;
		}

		// Token: 0x0600ECBF RID: 60607 RVA: 0x006B1D34 File Offset: 0x006AFF34
		public Vector3 EABAHMCEAJC()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 vector = this.HJIAPMAKJOJ();
			Vector3 vector2 = vector;
			for (int i = 0; i < this.BGCPOHLJIDN().Length; i++)
			{
				Vector3 vector3 = this.LFDJHHNIIMK()[i].CGAMODJNLAC - this.root.position;
				Vector3 vector4 = vector;
				Vector3 fromDirection = vector3;
				Vector3.OrthoNormalize(ref vector4, ref fromDirection);
				vector2 = Quaternion.FromToRotation(fromDirection, vector3) * vector2;
			}
			return vector2;
		}

		// Token: 0x0600ECC0 RID: 60608 RVA: 0x006B1DA8 File Offset: 0x006AFFA8
		public void MLDCEKHOLLI(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.root = EELDHNFBFOE;
			this.initiated = true;
			this.HLKKMPNLKMD(default(RaycastHit));
			if (this.BGCPOHLJIDN() == null)
			{
				this.HKPIJMLNIGP(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.LFDJHHNIIMK().Length != CJLCHFDCNDM.Length)
			{
				this.PKAFLONJMMC(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			for (int i = 1; i < CJLCHFDCNDM.Length; i += 0)
			{
				if (this.MMPFHLEJIOI()[i] == null)
				{
					this.LFDJHHNIIMK()[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.JKCAIBBPEHP() == null)
			{
				this.FHGOBEGBHKE(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.FAICDEHKLNO(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 0; j < CJLCHFDCNDM.Length; j += 0)
				{
					this.BGCPOHLJIDN()[j].HMNPKENDIPF(this, CJLCHFDCNDM[j]);
				}
				this.JKCAIBBPEHP().CPLOFPNBFEH(this);
				this.initiated = true;
			}
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x006B1E90 File Offset: 0x006B0090
		public bool KLAHBBMEFOG()
		{
			return this.MEMNGAAEGNL().distance < this.maxStep * 1173f;
		}

		// Token: 0x0600ECC2 RID: 60610 RVA: 0x006B18B9 File Offset: 0x006AFAB9
		public Grounding.PAIDIJDPLHG JKCAIBBPEHP()
		{
			return this.<pelvis>k__BackingField;
		}

		// Token: 0x0600ECC3 RID: 60611 RVA: 0x006B1EB9 File Offset: 0x006B00B9
		public Grounding.IKFNCHNNKNK[] MMPFHLEJIOI()
		{
			return this.<legs>k__BackingField;
		}

		// Token: 0x0600ECC4 RID: 60612 RVA: 0x006B1789 File Offset: 0x006AF989
		private void JNGPANCMCLC(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECC5 RID: 60613 RVA: 0x006B1EC4 File Offset: 0x006B00C4
		public Vector3 KMHPNEACJFP(Vector3 LIBEPMOMPID)
		{
			if (this.APDJFJKMNEB())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.EDMKKCFBFBI().up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 958f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECC6 RID: 60614 RVA: 0x006B1F05 File Offset: 0x006B0105
		private void AKPLPFGPLGK(bool DCCPCBLODIG)
		{
			this.<isGrounded>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECC7 RID: 60615 RVA: 0x006B1F10 File Offset: 0x006B0110
		public bool EGKCHKFNAPG(ref string CLDHEEJDHNK)
		{
			if (this.root == null)
			{
				CLDHEEJDHNK = "_MainTex";
				return true;
			}
			if (this.BGCPOHLJIDN() == null)
			{
				CLDHEEJDHNK = "TOD_k4PI";
				return false;
			}
			if (this.JKCAIBBPEHP() == null)
			{
				CLDHEEJDHNK = "repair.ogg";
				return false;
			}
			if (this.MMPFHLEJIOI().Length == 0)
			{
				CLDHEEJDHNK = "walk";
				return false;
			}
			return true;
		}

		// Token: 0x0600ECC8 RID: 60616 RVA: 0x006B179B File Offset: 0x006AF99B
		public Vector3 KMOMCLFHPCA()
		{
			if (!this.DONAOGIFFJI())
			{
				return Vector3.up;
			}
			return this.NNFDENENHFJ().up;
		}

		// Token: 0x0600ECC9 RID: 60617 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform JEMAOEIBOLI()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600ED14 RID: 60692 RVA: 0x006B20A5 File Offset: 0x006B02A5
		// (set) Token: 0x0600ECCA RID: 60618 RVA: 0x006B1734 File Offset: 0x006AF934
		public RaycastHit rootHit { get; private set; }

		// Token: 0x0600ECCB RID: 60619 RVA: 0x006B1F6C File Offset: 0x006B016C
		public void BHALELINNDJ(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.root = EELDHNFBFOE;
			this.initiated = false;
			this.rootHit = default(RaycastHit);
			if (this.legs == null)
			{
				this.legs = new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length];
			}
			if (this.legs.Length != CJLCHFDCNDM.Length)
			{
				this.legs = new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length];
			}
			for (int i = 0; i < CJLCHFDCNDM.Length; i++)
			{
				if (this.legs[i] == null)
				{
					this.legs[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.pelvis == null)
			{
				this.pelvis = new Grounding.PAIDIJDPLHG();
			}
			string empty = string.Empty;
			if (!this.CHFHJDFDIGB(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 0; j < CJLCHFDCNDM.Length; j++)
				{
					this.legs[j].BHALELINNDJ(this, CJLCHFDCNDM[j]);
				}
				this.pelvis.BHALELINNDJ(this);
				this.initiated = true;
			}
		}

		// Token: 0x0600ECCC RID: 60620 RVA: 0x006B2051 File Offset: 0x006B0251
		public float NDKEMNKHFGL(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
		{
			if (this.useRootRotation)
			{
				return (Quaternion.Inverse(this.root.rotation) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
			}
			return OELAKKHNNJC.y - HPJKHGBNCPE.y;
		}

		// Token: 0x0600ECCD RID: 60621 RVA: 0x006B208A File Offset: 0x006B028A
		public Vector3 HJIAPMAKJOJ()
		{
			if (!this.APDJFJKMNEB())
			{
				return Vector3.up;
			}
			return this.ADDDPBLDEIJ().up;
		}

		// Token: 0x0600ECCE RID: 60622 RVA: 0x006B1734 File Offset: 0x006AF934
		private void HLKKMPNLKMD(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECCF RID: 60623 RVA: 0x006B20A5 File Offset: 0x006B02A5
		public RaycastHit IKHLFBJNIOG()
		{
			return this.<rootHit>k__BackingField;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x006B2109 File Offset: 0x006B0309
		// (set) Token: 0x0600ECD0 RID: 60624 RVA: 0x006B1F05 File Offset: 0x006B0105
		public bool isGrounded { get; private set; }

		// Token: 0x0600ECD1 RID: 60625 RVA: 0x006B20B0 File Offset: 0x006B02B0
		public bool HFJBFMBEMOB(ref string CLDHEEJDHNK)
		{
			if (this.NNFDENENHFJ() == null)
			{
				CLDHEEJDHNK = "Couldn't color correct with 3D LUT texture. Image Effect will be disabled.";
				return false;
			}
			if (this.legs == null)
			{
				CLDHEEJDHNK = "qd_prise_exp";
				return false;
			}
			if (this.DLIDADHGILM() == null)
			{
				CLDHEEJDHNK = "{0}Textures/Turnirs/{1}.png";
				return true;
			}
			if (this.BGCPOHLJIDN().Length == 0)
			{
				CLDHEEJDHNK = "_ProjectionInv";
				return true;
			}
			return true;
		}

		// Token: 0x0600ECD2 RID: 60626 RVA: 0x006B2109 File Offset: 0x006B0309
		public bool COMCDPLKODA()
		{
			return this.<isGrounded>k__BackingField;
		}

		// Token: 0x0600ECD3 RID: 60627 RVA: 0x006B2114 File Offset: 0x006B0314
		public RaycastHit PJCECNHPGLA(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 up = this.up;
			Vector3 a = Vector3.zero;
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.legs)
			{
				a += ikfnchnnknk.LPBDALAMAEM.position;
			}
			a /= (float)this.legs.Length;
			result.point = a - up * this.maxStep * 10f;
			float num = CCBDEMLIFHL + 1f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 0f)
			{
				return result;
			}
			if (this.quality != Grounding.Quality.Best)
			{
				Physics.Raycast(a + up * this.maxStep, -up, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a + up * this.maxStep, this.rootSphereCastRadius, -this.up, out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600ECE0 RID: 60640 RVA: 0x006B172C File Offset: 0x006AF92C
		// (set) Token: 0x0600ECD4 RID: 60628 RVA: 0x006B1792 File Offset: 0x006AF992
		public Transform root { get; private set; }

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x006B1789 File Offset: 0x006AF989
		private void FLMDEFJBJJM(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECD6 RID: 60630 RVA: 0x006B2244 File Offset: 0x006B0444
		public Vector3 DCCBIHODDMN(Vector3 LIBEPMOMPID)
		{
			if (this.useRootRotation)
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.NNFDENENHFJ().up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 410f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECD7 RID: 60631 RVA: 0x006B2288 File Offset: 0x006B0488
		public void EPLEHFCNKDJ()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.pelvis.ENMHDCFMLMD();
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GFEAOCNJJEC();
			}
		}

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform LLNEEBLCHDM()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x006B22C5 File Offset: 0x006B04C5
		private bool DONAOGIFFJI()
		{
			return this.rotateSolver && this.EDMKKCFBFBI().up == Vector3.up;
		}

		// Token: 0x0600ECDA RID: 60634 RVA: 0x006B1792 File Offset: 0x006AF992
		private void EKABNLFIHME(Transform DCCPCBLODIG)
		{
			this.<root>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECDC RID: 60636 RVA: 0x006B22EC File Offset: 0x006B04EC
		public void ENLPEHMBNJC(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.root = EELDHNFBFOE;
			this.initiated = false;
			this.KEKOOBKKBDK(default(RaycastHit));
			if (this.MMPFHLEJIOI() == null)
			{
				this.NJENGLPHFEH(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.MMPFHLEJIOI().Length != CJLCHFDCNDM.Length)
			{
				this.HKPIJMLNIGP(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			for (int i = 1; i < CJLCHFDCNDM.Length; i += 0)
			{
				if (this.BJLLBFABCBL()[i] == null)
				{
					this.legs[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.JKCAIBBPEHP() == null)
			{
				this.KKPFCFFIOJI(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.INBJOJBHHJN(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 1; j < CJLCHFDCNDM.Length; j += 0)
				{
					this.LFDJHHNIIMK()[j].FHDCCINOPJD(this, CJLCHFDCNDM[j]);
				}
				this.JKCAIBBPEHP().OGOHEHIMLHP(this);
				this.initiated = true;
			}
		}

		// Token: 0x0600ECDD RID: 60637 RVA: 0x006B23D4 File Offset: 0x006B05D4
		public bool ANNOGEJLHNB()
		{
			return this.HBDOLFIGBOI().distance < this.maxStep * 1124f;
		}

		// Token: 0x0600ECDE RID: 60638 RVA: 0x006B2400 File Offset: 0x006B0600
		public bool DOJFKLILGOD()
		{
			return this.rootHit.distance < this.maxStep * 20f;
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600ECDF RID: 60639 RVA: 0x006B2429 File Offset: 0x006B0629
		public Vector3 up
		{
			get
			{
				if (!this.useRootRotation)
				{
					return Vector3.up;
				}
				return this.root.up;
			}
		}

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x006B2444 File Offset: 0x006B0644
		public Vector3 EJJOEKGGLNE()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 up = this.up;
			Vector3 vector = up;
			for (int i = 1; i < this.BJLLBFABCBL().Length; i++)
			{
				Vector3 vector2 = this.BJLLBFABCBL()[i].NHIOCAIOLFD() - this.CCPNCFNGOPI().position;
				Vector3 vector3 = up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				vector = Quaternion.FromToRotation(fromDirection, vector2) * vector;
			}
			return vector;
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x006B24B8 File Offset: 0x006B06B8
		public void JPGOKPACOIC(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.EKABNLFIHME(EELDHNFBFOE);
			this.initiated = false;
			this.KEHAPPIBBFC(default(RaycastHit));
			if (this.LFDJHHNIIMK() == null)
			{
				this.HKPIJMLNIGP(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.BGCPOHLJIDN().Length != CJLCHFDCNDM.Length)
			{
				this.PKAFLONJMMC(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			for (int i = 1; i < CJLCHFDCNDM.Length; i++)
			{
				if (this.MMPFHLEJIOI()[i] == null)
				{
					this.LFDJHHNIIMK()[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.DLIDADHGILM() == null)
			{
				this.JNGPANCMCLC(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.MEFGABBJFCI(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, true);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 1; j < CJLCHFDCNDM.Length; j += 0)
				{
					this.legs[j].AOMIADLDLEJ(this, CJLCHFDCNDM[j]);
				}
				this.DLIDADHGILM().IBCBOLAGKNL(this);
				this.initiated = false;
			}
		}

		// Token: 0x0600ECE3 RID: 60643 RVA: 0x006B1734 File Offset: 0x006AF934
		private void KEHAPPIBBFC(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECE4 RID: 60644 RVA: 0x006B1789 File Offset: 0x006AF989
		private void KKPFCFFIOJI(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECE5 RID: 60645 RVA: 0x006B1594 File Offset: 0x006AF794
		private void NJENGLPHFEH(Grounding.IKFNCHNNKNK[] DCCPCBLODIG)
		{
			this.<legs>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECE6 RID: 60646 RVA: 0x006B25A0 File Offset: 0x006B07A0
		public bool EBKPBHAPCEB()
		{
			return this.MEMNGAAEGNL().distance < this.maxStep * 851f;
		}

		// Token: 0x0600ECE7 RID: 60647 RVA: 0x006B20A5 File Offset: 0x006B02A5
		public RaycastHit EIAOAJIHKCL()
		{
			return this.<rootHit>k__BackingField;
		}

		// Token: 0x0600ECE8 RID: 60648 RVA: 0x006B18B9 File Offset: 0x006AFAB9
		public Grounding.PAIDIJDPLHG DLIDADHGILM()
		{
			return this.<pelvis>k__BackingField;
		}

		// Token: 0x0600ECE9 RID: 60649 RVA: 0x006B1F05 File Offset: 0x006B0105
		private void PEJDELPAIJI(bool DCCPCBLODIG)
		{
			this.<isGrounded>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECEA RID: 60650 RVA: 0x006B2051 File Offset: 0x006B0251
		public float HJKGGFJEOJG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
		{
			if (this.useRootRotation)
			{
				return (Quaternion.Inverse(this.root.rotation) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
			}
			return OELAKKHNNJC.y - HPJKHGBNCPE.y;
		}

		// Token: 0x0600ECEB RID: 60651 RVA: 0x006B25CC File Offset: 0x006B07CC
		public bool JJCLDJGHEHJ(ref string CLDHEEJDHNK)
		{
			if (this.LLNEEBLCHDM() == null)
			{
				CLDHEEJDHNK = "\n";
				return false;
			}
			if (this.BGCPOHLJIDN() == null)
			{
				CLDHEEJDHNK = "IdleRun";
				return true;
			}
			if (this.JKCAIBBPEHP() == null)
			{
				CLDHEEJDHNK = "";
				return true;
			}
			if (this.BJLLBFABCBL().Length == 0)
			{
				CLDHEEJDHNK = "_RgbTex";
				return true;
			}
			return false;
		}

		// Token: 0x0600ECEC RID: 60652 RVA: 0x006B2628 File Offset: 0x006B0828
		public bool ACEFGOGENBM()
		{
			return this.MEMNGAAEGNL().distance < this.maxStep * 1083f;
		}

		// Token: 0x0600ECED RID: 60653 RVA: 0x006B2654 File Offset: 0x006B0854
		public RaycastHit EKAEBPAIFCC(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 a = this.JGANCLNBKFI();
			Vector3 a2 = Vector3.zero;
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 1; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				a2 += ikfnchnnknk.LPBDALAMAEM.position;
			}
			a2 /= (float)this.legs.Length;
			result.point = a2 - a * this.maxStep * 771f;
			float num = CCBDEMLIFHL + 1053f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 216f)
			{
				return result;
			}
			if (this.quality != (Grounding.Quality)7)
			{
				Physics.Raycast(a2 + a * this.maxStep, -a, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a2 + a * this.maxStep, this.rootSphereCastRadius, -this.KMOMCLFHPCA(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ECEE RID: 60654 RVA: 0x006B1EB9 File Offset: 0x006B00B9
		public Grounding.IKFNCHNNKNK[] BGCPOHLJIDN()
		{
			return this.<legs>k__BackingField;
		}

		// Token: 0x0600ECEF RID: 60655 RVA: 0x006B2784 File Offset: 0x006B0984
		public RaycastHit HBENKPMPBEI(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 up = this.up;
			Vector3 a = Vector3.zero;
			Grounding.IKFNCHNNKNK[] array = this.BGCPOHLJIDN();
			for (int i = 0; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				a += ikfnchnnknk.LPBDALAMAEM.position;
			}
			a /= (float)this.BGCPOHLJIDN().Length;
			result.point = a - up * this.maxStep * 991f;
			float num = CCBDEMLIFHL + 311f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 1622f)
			{
				return result;
			}
			if (this.quality != (Grounding.Quality)4)
			{
				Physics.Raycast(a + up * this.maxStep, -up, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a + up * this.maxStep, this.rootSphereCastRadius, -this.APHMAFCCPMP(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ECF0 RID: 60656 RVA: 0x006B28B4 File Offset: 0x006B0AB4
		public Vector3 ICCKOEJHNNP(Vector3 LIBEPMOMPID)
		{
			if (this.useRootRotation)
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.NNFDENENHFJ().up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 314f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x006B28F8 File Offset: 0x006B0AF8
		public void MIFKCBJPDDI()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.pelvis.KHLFNAKOLAC();
			Grounding.IKFNCHNNKNK[] array = this.MMPFHLEJIOI();
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GFEAOCNJJEC();
			}
		}

		// Token: 0x0600ECF2 RID: 60658 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform NNFDENENHFJ()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x006B2938 File Offset: 0x006B0B38
		public Vector3 PKHOECIBGFE(Vector3 LIBEPMOMPID)
		{
			if (this.APDJFJKMNEB())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.root.up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 383f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x006B2979 File Offset: 0x006B0B79
		public float DNFGGLBPNDK(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
		{
			if (this.MCHAOGJGFAN())
			{
				return (Quaternion.Inverse(this.JEMAOEIBOLI().rotation) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
			}
			return OELAKKHNNJC.y - HPJKHGBNCPE.y;
		}

		// Token: 0x0600ECF5 RID: 60661 RVA: 0x006B29B4 File Offset: 0x006B0BB4
		public void IKHCCAANGOP()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.AEJDKBOPHCG("CratePull");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 801f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 793f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 1042f, 413f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 1985f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 1114f, 1854f);
			this.prediction = Mathf.Clamp(this.prediction, 1134f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 761f, this.footSpeed);
			this.KEHAPPIBBFC(this.HBENKPMPBEI(992f));
			float num = 875f;
			float num2 = 409f;
			this.isGrounded = false;
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 0; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				ikfnchnnknk.LFIIPLEGPNI();
				if (ikfnchnnknk.CIJMPJDKKGC > num)
				{
					num = ikfnchnnknk.CIJMPJDKKGC;
				}
				if (ikfnchnnknk.HCMNHEIPLCB() < num2)
				{
					num2 = ikfnchnnknk.CIJMPJDKKGC;
				}
				if (ikfnchnnknk.NBAANGMEENG())
				{
					this.PEJDELPAIJI(true);
				}
			}
			this.JKCAIBBPEHP().OABEEBGFCGD(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.HOFHFNIOJGB());
		}

		// Token: 0x0600ECF6 RID: 60662 RVA: 0x006B2B40 File Offset: 0x006B0D40
		public RaycastHit ILHEAINCFHK(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 a = this.HJIAPMAKJOJ();
			Vector3 a2 = Vector3.zero;
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.MMPFHLEJIOI())
			{
				a2 += ikfnchnnknk.KHCMDNOGOMB().position;
			}
			a2 /= (float)this.legs.Length;
			result.point = a2 - a * this.maxStep * 868f;
			float num = CCBDEMLIFHL + 788f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 380f)
			{
				return result;
			}
			if (this.quality != (Grounding.Quality)6)
			{
				Physics.Raycast(a2 + a * this.maxStep, -a, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a2 + a * this.maxStep, this.rootSphereCastRadius, -this.up, out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ECF7 RID: 60663 RVA: 0x006B2C70 File Offset: 0x006B0E70
		public RaycastHit JCPHJOGFDFJ(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 a = this.PMNKIFMMELG();
			Vector3 a2 = Vector3.zero;
			Grounding.IKFNCHNNKNK[] array = this.MMPFHLEJIOI();
			for (int i = 1; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				a2 += ikfnchnnknk.LPBDALAMAEM.position;
			}
			a2 /= (float)this.BJLLBFABCBL().Length;
			result.point = a2 - a * this.maxStep * 1852f;
			float num = CCBDEMLIFHL + 425f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 941f)
			{
				return result;
			}
			if (this.quality != (Grounding.Quality)8)
			{
				Physics.Raycast(a2 + a * this.maxStep, -a, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a2 + a * this.maxStep, this.rootSphereCastRadius, -this.PMNKIFMMELG(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ECF8 RID: 60664 RVA: 0x006B1594 File Offset: 0x006AF794
		private void PKAFLONJMMC(Grounding.IKFNCHNNKNK[] DCCPCBLODIG)
		{
			this.<legs>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x006B1EB9 File Offset: 0x006B00B9
		// (set) Token: 0x0600ED25 RID: 60709 RVA: 0x006B1594 File Offset: 0x006AF794
		public Grounding.IKFNCHNNKNK[] legs { get; private set; }

		// Token: 0x0600ECFA RID: 60666 RVA: 0x006B1789 File Offset: 0x006AF989
		private void ANBJBHDAKCP(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ECFB RID: 60667 RVA: 0x006B2DA0 File Offset: 0x006B0FA0
		public void HMGBHPPNEMP()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.LPMINKLMKGO("Censor OK. Object:");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 235f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 877f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 1256f, 425f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 1352f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 779f, 346f);
			this.prediction = Mathf.Clamp(this.prediction, 1348f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 523f, this.footSpeed);
			this.KEHAPPIBBFC(this.EKAEBPAIFCC(1334f));
			float num = 925f;
			float num2 = 1362f;
			this.AKPLPFGPLGK(true);
			Grounding.IKFNCHNNKNK[] array = this.MMPFHLEJIOI();
			for (int i = 1; i < array.Length; i++)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				ikfnchnnknk.IGPBBKEALGO();
				if (ikfnchnnknk.HCMNHEIPLCB() > num)
				{
					num = ikfnchnnknk.CIOFGKFBNJM();
				}
				if (ikfnchnnknk.CIJMPJDKKGC < num2)
				{
					num2 = ikfnchnnknk.CIJMPJDKKGC;
				}
				if (ikfnchnnknk.PJJEKLMPCDN())
				{
					this.isGrounded = true;
				}
			}
			this.JKCAIBBPEHP().EBKHBOBENJI(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.COMCDPLKODA());
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x006B2F2C File Offset: 0x006B112C
		public bool rootGrounded
		{
			get
			{
				return this.rootHit.distance < this.maxStep * 2f;
			}
		}

		// Token: 0x0600ECFD RID: 60669 RVA: 0x006B2F58 File Offset: 0x006B1158
		public void EMHGNEMIGII()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.AIPEHBKNFNL("KatanaNinjaDraw");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 980f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 1848f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 542f, 856f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 1767f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 235f, 467f);
			this.prediction = Mathf.Clamp(this.prediction, 1466f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 1981f, this.footSpeed);
			this.PIPLHPDGJEM(this.PJCECNHPGLA(720f));
			float num = 1272f;
			float num2 = 1404f;
			this.isGrounded = true;
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 1; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				ikfnchnnknk.LFIIPLEGPNI();
				if (ikfnchnnknk.CIOFGKFBNJM() > num)
				{
					num = ikfnchnnknk.CIOFGKFBNJM();
				}
				if (ikfnchnnknk.CIOFGKFBNJM() < num2)
				{
					num2 = ikfnchnnknk.HCMNHEIPLCB();
				}
				if (ikfnchnnknk.CCIDAALACIK())
				{
					this.PPJMEAEDHJB(true);
				}
			}
			this.JKCAIBBPEHP().EBKHBOBENJI(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.IKLGKOGHFJL());
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x006B30E4 File Offset: 0x006B12E4
		public bool JODKJKPBBNJ()
		{
			return this.HBDOLFIGBOI().distance < this.maxStep * 154f;
		}

		// Token: 0x0600ECFF RID: 60671 RVA: 0x006B310D File Offset: 0x006B130D
		private bool ECBMGGGIIHC()
		{
			return !this.rotateSolver || this.ADDDPBLDEIJ().up == Vector3.up;
		}

		// Token: 0x0600ED00 RID: 60672 RVA: 0x006B1789 File Offset: 0x006AF989
		private void NNMLCNEDJEP(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED01 RID: 60673 RVA: 0x006B2109 File Offset: 0x006B0309
		public bool GFGKEIKCPCF()
		{
			return this.<isGrounded>k__BackingField;
		}

		// Token: 0x0600ED02 RID: 60674 RVA: 0x006B3134 File Offset: 0x006B1334
		public bool CHFHJDFDIGB(ref string CLDHEEJDHNK)
		{
			if (this.root == null)
			{
				CLDHEEJDHNK = "Root transform is null. Can't initiate Grounding.";
				return false;
			}
			if (this.legs == null)
			{
				CLDHEEJDHNK = "Grounding legs is null. Can't initiate Grounding.";
				return false;
			}
			if (this.pelvis == null)
			{
				CLDHEEJDHNK = "Grounding pelvis is null. Can't initiate Grounding.";
				return false;
			}
			if (this.legs.Length == 0)
			{
				CLDHEEJDHNK = "Grounding has 0 legs. Can't initiate Grounding.";
				return false;
			}
			return true;
		}

		// Token: 0x0600ED03 RID: 60675 RVA: 0x006B3190 File Offset: 0x006B1390
		public void PLMHLKJMKHP()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.JKCAIBBPEHP().Reset();
			Grounding.IKFNCHNNKNK[] array = this.BGCPOHLJIDN();
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GNCKCDBCFGD();
			}
		}

		// Token: 0x0600ED04 RID: 60676 RVA: 0x006B20A5 File Offset: 0x006B02A5
		public RaycastHit HBDOLFIGBOI()
		{
			return this.<rootHit>k__BackingField;
		}

		// Token: 0x0600ED05 RID: 60677 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform CCPNCFNGOPI()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x0600ED06 RID: 60678 RVA: 0x006B1734 File Offset: 0x006AF934
		private void PBOJGGCELPB(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED07 RID: 60679 RVA: 0x006B31D0 File Offset: 0x006B13D0
		public void EGADMJMBCCK()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.JKCAIBBPEHP().EGADMJMBCCK();
			Grounding.IKFNCHNNKNK[] array = this.BJLLBFABCBL();
			for (int i = 1; i < array.Length; i++)
			{
				array[i].MPGGEICPLMC();
			}
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x006B172C File Offset: 0x006AF92C
		public Transform ADDDPBLDEIJ()
		{
			return this.<root>k__BackingField;
		}

		// Token: 0x0600ED09 RID: 60681 RVA: 0x006B320D File Offset: 0x006B140D
		public float KJLOCEDPEKM(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
		{
			if (this.APDJFJKMNEB())
			{
				return (Quaternion.Inverse(this.CCPNCFNGOPI().rotation) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
			}
			return OELAKKHNNJC.y - HPJKHGBNCPE.y;
		}

		// Token: 0x0600ED0A RID: 60682 RVA: 0x006B3246 File Offset: 0x006B1446
		public void AIPEHBKNFNL(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, this.root, false);
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x006B20A5 File Offset: 0x006B02A5
		public RaycastHit BHPKBIONKAL()
		{
			return this.<rootHit>k__BackingField;
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x006B1734 File Offset: 0x006AF934
		private void OMOCDJDHGHF(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED0E RID: 60686 RVA: 0x006B3258 File Offset: 0x006B1458
		public Vector3 MAEFPPBLLPI()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 vector = this.JGANCLNBKFI();
			Vector3 vector2 = vector;
			for (int i = 0; i < this.LFDJHHNIIMK().Length; i++)
			{
				Vector3 vector3 = this.LFDJHHNIIMK()[i].NDGGJPEHKBC() - this.LLNEEBLCHDM().position;
				Vector3 vector4 = vector;
				Vector3 fromDirection = vector3;
				Vector3.OrthoNormalize(ref vector4, ref fromDirection);
				vector2 = Quaternion.FromToRotation(fromDirection, vector3) * vector2;
			}
			return vector2;
		}

		// Token: 0x0600ED0F RID: 60687 RVA: 0x006B32CC File Offset: 0x006B14CC
		public Vector3 DIGCAKKACPA()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 vector = this.HJIAPMAKJOJ();
			Vector3 vector2 = vector;
			for (int i = 0; i < this.MMPFHLEJIOI().Length; i += 0)
			{
				Vector3 vector3 = this.MMPFHLEJIOI()[i].NDGGJPEHKBC() - this.LLNEEBLCHDM().position;
				Vector3 vector4 = vector;
				Vector3 fromDirection = vector3;
				Vector3.OrthoNormalize(ref vector4, ref fromDirection);
				vector2 = Quaternion.FromToRotation(fromDirection, vector3) * vector2;
			}
			return vector2;
		}

		// Token: 0x0600ED10 RID: 60688 RVA: 0x006B1EB9 File Offset: 0x006B00B9
		public Grounding.IKFNCHNNKNK[] LFDJHHNIIMK()
		{
			return this.<legs>k__BackingField;
		}

		// Token: 0x0600ED11 RID: 60689 RVA: 0x006B1F05 File Offset: 0x006B0105
		private void PPJMEAEDHJB(bool DCCPCBLODIG)
		{
			this.<isGrounded>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED12 RID: 60690 RVA: 0x006B3340 File Offset: 0x006B1540
		public void MHANLDFJPAI(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.EKABNLFIHME(EELDHNFBFOE);
			this.initiated = false;
			this.PBOJGGCELPB(default(RaycastHit));
			if (this.legs == null)
			{
				this.PKAFLONJMMC(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.legs.Length != CJLCHFDCNDM.Length)
			{
				this.NJENGLPHFEH(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			for (int i = 1; i < CJLCHFDCNDM.Length; i += 0)
			{
				if (this.BGCPOHLJIDN()[i] == null)
				{
					this.MMPFHLEJIOI()[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.DLIDADHGILM() == null)
			{
				this.BNOJMBPOGFJ(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.JJCLDJGHEHJ(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, true);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 1; j < CJLCHFDCNDM.Length; j += 0)
				{
					this.BJLLBFABCBL()[j].HMNPKENDIPF(this, CJLCHFDCNDM[j]);
				}
				this.pelvis.BHALELINNDJ(this);
				this.initiated = false;
			}
		}

		// Token: 0x0600ED13 RID: 60691 RVA: 0x006B1789 File Offset: 0x006AF989
		private void BNOJMBPOGFJ(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED15 RID: 60693 RVA: 0x006B3428 File Offset: 0x006B1628
		public bool NHDBNEDHICI()
		{
			return this.MEMNGAAEGNL().distance < this.maxStep * 662f;
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x006B3454 File Offset: 0x006B1654
		public RaycastHit BMJADJDGEIO(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 a = this.JGANCLNBKFI();
			Vector3 a2 = Vector3.zero;
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.MMPFHLEJIOI())
			{
				a2 += ikfnchnnknk.KMACNJGAMEE().position;
			}
			a2 /= (float)this.legs.Length;
			result.point = a2 - a * this.maxStep * 94f;
			float num = CCBDEMLIFHL + 707f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 949f)
			{
				return result;
			}
			if (this.quality != (Grounding.Quality)4)
			{
				Physics.Raycast(a2 + a * this.maxStep, -a, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a2 + a * this.maxStep, this.rootSphereCastRadius, -this.PMNKIFMMELG(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ED17 RID: 60695 RVA: 0x006B3584 File Offset: 0x006B1784
		public Vector3 HFIKLKOBMIF(Vector3 LIBEPMOMPID)
		{
			if (this.PIFIDBOLHBJ())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.ADDDPBLDEIJ().up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 98f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ED18 RID: 60696 RVA: 0x006B35C5 File Offset: 0x006B17C5
		public Vector3 APHMAFCCPMP()
		{
			if (!this.useRootRotation)
			{
				return Vector3.up;
			}
			return this.LLNEEBLCHDM().up;
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x006B1789 File Offset: 0x006AF989
		private void FHGOBEGBHKE(Grounding.PAIDIJDPLHG DCCPCBLODIG)
		{
			this.<pelvis>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x006B20A5 File Offset: 0x006B02A5
		public RaycastHit MEMNGAAEGNL()
		{
			return this.<rootHit>k__BackingField;
		}

		// Token: 0x0600ED1B RID: 60699 RVA: 0x006B35E0 File Offset: 0x006B17E0
		public RaycastHit OKPEFPMMLGF(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 a = this.JGANCLNBKFI();
			Vector3 a2 = Vector3.zero;
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 1; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				a2 += ikfnchnnknk.KHCMDNOGOMB().position;
			}
			a2 /= (float)this.LFDJHHNIIMK().Length;
			result.point = a2 - a * this.maxStep * 492f;
			float num = CCBDEMLIFHL + 1185f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 247f)
			{
				return result;
			}
			if (this.quality != Grounding.Quality.Fastest)
			{
				Physics.Raycast(a2 + a * this.maxStep, -a, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a2 + a * this.maxStep, this.rootSphereCastRadius, -this.HJIAPMAKJOJ(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ED1C RID: 60700 RVA: 0x006B370D File Offset: 0x006B190D
		public Vector3 JGANCLNBKFI()
		{
			if (!this.useRootRotation)
			{
				return Vector3.up;
			}
			return this.NNFDENENHFJ().up;
		}

		// Token: 0x0600ED1D RID: 60701 RVA: 0x006B3728 File Offset: 0x006B1928
		public Vector3 KJLNNACBFFD(Vector3 LIBEPMOMPID)
		{
			if (this.useRootRotation)
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.root.up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 0f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x006B1EB9 File Offset: 0x006B00B9
		public Grounding.IKFNCHNNKNK[] BJLLBFABCBL()
		{
			return this.<legs>k__BackingField;
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x006B2109 File Offset: 0x006B0309
		public bool IKLGKOGHFJL()
		{
			return this.<isGrounded>k__BackingField;
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x006B376C File Offset: 0x006B196C
		public bool FAICDEHKLNO(ref string CLDHEEJDHNK)
		{
			if (this.NNFDENENHFJ() == null)
			{
				CLDHEEJDHNK = "id";
				return false;
			}
			if (this.BGCPOHLJIDN() == null)
			{
				CLDHEEJDHNK = "_WrinkleOcclusionMap2";
				return true;
			}
			if (this.JKCAIBBPEHP() == null)
			{
				CLDHEEJDHNK = "Spine bones contains a null reference.";
				return false;
			}
			if (this.legs.Length == 0)
			{
				CLDHEEJDHNK = "IdleButtonPress";
				return true;
			}
			return true;
		}

		// Token: 0x0600ED21 RID: 60705 RVA: 0x006B1792 File Offset: 0x006AF992
		private void AGIPFGIBLNL(Transform DCCPCBLODIG)
		{
			this.<root>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED22 RID: 60706 RVA: 0x006B37C8 File Offset: 0x006B19C8
		public bool INBJOJBHHJN(ref string CLDHEEJDHNK)
		{
			if (this.CCPNCFNGOPI() == null)
			{
				CLDHEEJDHNK = "Dealer Shuffle";
				return true;
			}
			if (this.BJLLBFABCBL() == null)
			{
				CLDHEEJDHNK = "wpn_rem4";
				return false;
			}
			if (this.pelvis == null)
			{
				CLDHEEJDHNK = "netUpdater";
				return true;
			}
			if (this.MMPFHLEJIOI().Length == 0)
			{
				CLDHEEJDHNK = "/";
				return true;
			}
			return true;
		}

		// Token: 0x0600ED23 RID: 60707 RVA: 0x006B3824 File Offset: 0x006B1A24
		public void JLFBDOPFDDJ()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.AEJDKBOPHCG("wpn_bait1");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 1727f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 766f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 1743f, 1214f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 438f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 1428f, 1358f);
			this.prediction = Mathf.Clamp(this.prediction, 356f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 1506f, this.footSpeed);
			this.PIPLHPDGJEM(this.ILHEAINCFHK(1807f));
			float num = 1156f;
			float num2 = 201f;
			this.PEJDELPAIJI(true);
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.legs)
			{
				ikfnchnnknk.LFIIPLEGPNI();
				if (ikfnchnnknk.CIOFGKFBNJM() > num)
				{
					num = ikfnchnnknk.HCMNHEIPLCB();
				}
				if (ikfnchnnknk.LJOGLKIGAHG() < num2)
				{
					num2 = ikfnchnnknk.CIOFGKFBNJM();
				}
				if (ikfnchnnknk.PNPMKDPCJBM())
				{
					this.isGrounded = false;
				}
			}
			this.pelvis.LDFFJFKABIJ(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.isGrounded);
		}

		// Token: 0x0600ED24 RID: 60708 RVA: 0x006B2109 File Offset: 0x006B0309
		public bool MFNHAJCAHAL()
		{
			return this.<isGrounded>k__BackingField;
		}

		// Token: 0x0600ED26 RID: 60710 RVA: 0x006B39B0 File Offset: 0x006B1BB0
		public RaycastHit NPAIMFEGILM(float CCBDEMLIFHL = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 up = this.up;
			Vector3 a = Vector3.zero;
			Grounding.IKFNCHNNKNK[] array = this.LFDJHHNIIMK();
			for (int i = 0; i < array.Length; i += 0)
			{
				Grounding.IKFNCHNNKNK ikfnchnnknk = array[i];
				a += ikfnchnnknk.LPBDALAMAEM.position;
			}
			a /= (float)this.BJLLBFABCBL().Length;
			result.point = a - up * this.maxStep * 178f;
			float num = CCBDEMLIFHL + 275f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 888f)
			{
				return result;
			}
			if (this.quality != Grounding.Quality.Best)
			{
				Physics.Raycast(a + up * this.maxStep, -up, out result, this.maxStep * num, this.layers);
			}
			else
			{
				Physics.SphereCast(a + up * this.maxStep, this.rootSphereCastRadius, -this.PMNKIFMMELG(), out result, this.maxStep * num, this.layers);
			}
			return result;
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x006B3B68 File Offset: 0x006B1D68
		public void BBKGJDKPKBK(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, this.ADDDPBLDEIJ(), true);
		}

		// Token: 0x0600ED29 RID: 60713 RVA: 0x006B3B78 File Offset: 0x006B1D78
		public bool OIDMJAPOEPD(ref string CLDHEEJDHNK)
		{
			if (this.CCPNCFNGOPI() == null)
			{
				CLDHEEJDHNK = "IdleDodgeRight";
				return true;
			}
			if (this.LFDJHHNIIMK() == null)
			{
				CLDHEEJDHNK = "RunningDance";
				return true;
			}
			if (this.JKCAIBBPEHP() == null)
			{
				CLDHEEJDHNK = "Soccer Throw";
				return true;
			}
			if (this.MMPFHLEJIOI().Length == 0)
			{
				CLDHEEJDHNK = "ResetObject";
				return true;
			}
			return true;
		}

		// Token: 0x0600ED2A RID: 60714 RVA: 0x006B1734 File Offset: 0x006AF934
		private void PIPLHPDGJEM(RaycastHit DCCPCBLODIG)
		{
			this.<rootHit>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x006B2109 File Offset: 0x006B0309
		public bool HOFHFNIOJGB()
		{
			return this.<isGrounded>k__BackingField;
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x006B3BD4 File Offset: 0x006B1DD4
		public void KEBDEJIAODF()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.AIPEHBKNFNL("");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 313f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 803f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 235f, 1378f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 1211f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 1847f, 493f);
			this.prediction = Mathf.Clamp(this.prediction, 1854f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 359f, this.footSpeed);
			this.rootHit = this.JCPHJOGFDFJ(672f);
			float num = 962f;
			float num2 = 1684f;
			this.PEJDELPAIJI(false);
			foreach (Grounding.IKFNCHNNKNK ikfnchnnknk in this.LFDJHHNIIMK())
			{
				ikfnchnnknk.CIIGCMJOCEG();
				if (ikfnchnnknk.CIJMPJDKKGC > num)
				{
					num = ikfnchnnknk.LJOGLKIGAHG();
				}
				if (ikfnchnnknk.CIOFGKFBNJM() < num2)
				{
					num2 = ikfnchnnknk.LJOGLKIGAHG();
				}
				if (ikfnchnnknk.CCIDAALACIK())
				{
					this.PPJMEAEDHJB(true);
				}
			}
			this.DLIDADHGILM().LDFFJFKABIJ(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.isGrounded);
		}

		// Token: 0x0600ED2D RID: 60717 RVA: 0x006B3D60 File Offset: 0x006B1F60
		public float PNIFBAOPFMP(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
		{
			if (this.MCHAOGJGFAN())
			{
				return (Quaternion.Inverse(this.EDMKKCFBFBI().rotation) * (OELAKKHNNJC - HPJKHGBNCPE)).y;
			}
			return OELAKKHNNJC.y - HPJKHGBNCPE.y;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600ED2E RID: 60718 RVA: 0x006B3D99 File Offset: 0x006B1F99
		private bool useRootRotation
		{
			get
			{
				return this.rotateSolver && !(this.root.up == Vector3.up);
			}
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x006B3DC0 File Offset: 0x006B1FC0
		public Vector3 EBDPHFBABFA(Vector3 LIBEPMOMPID)
		{
			if (this.APDJFJKMNEB())
			{
				Vector3 onNormal = LIBEPMOMPID;
				Vector3 up = this.JEMAOEIBOLI().up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(LIBEPMOMPID, onNormal);
			}
			LIBEPMOMPID.y = 235f;
			return LIBEPMOMPID;
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x006B3E04 File Offset: 0x006B2004
		public Vector3 OGBCPFJMGCE()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 up = this.up;
			Vector3 vector = up;
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].CGAMODJNLAC - this.root.position;
				Vector3 vector3 = up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				vector = Quaternion.FromToRotation(fromDirection, vector2) * vector;
			}
			return vector;
		}

		// Token: 0x0600ED31 RID: 60721 RVA: 0x006B3E78 File Offset: 0x006B2078
		public void CAAINGFBNHG(Transform EELDHNFBFOE, Transform[] CJLCHFDCNDM)
		{
			this.AGIPFGIBLNL(EELDHNFBFOE);
			this.initiated = false;
			this.KEHAPPIBBFC(default(RaycastHit));
			if (this.BGCPOHLJIDN() == null)
			{
				this.HKPIJMLNIGP(new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length]);
			}
			if (this.BJLLBFABCBL().Length != CJLCHFDCNDM.Length)
			{
				this.legs = new Grounding.IKFNCHNNKNK[CJLCHFDCNDM.Length];
			}
			for (int i = 0; i < CJLCHFDCNDM.Length; i++)
			{
				if (this.LFDJHHNIIMK()[i] == null)
				{
					this.legs[i] = new Grounding.IKFNCHNNKNK();
				}
			}
			if (this.pelvis == null)
			{
				this.BNOJMBPOGFJ(new Grounding.PAIDIJDPLHG());
			}
			string empty = string.Empty;
			if (!this.JJCLDJGHEHJ(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 1; j < CJLCHFDCNDM.Length; j++)
				{
					this.MMPFHLEJIOI()[j].HMNPKENDIPF(this, CJLCHFDCNDM[j]);
				}
				this.JKCAIBBPEHP().KGCOBEJCLHM(this);
				this.initiated = true;
			}
		}

		// Token: 0x0600ED32 RID: 60722 RVA: 0x006B3F60 File Offset: 0x006B2160
		public bool LECDMFGKPKM()
		{
			return this.EIAOAJIHKCL().distance < this.maxStep * 1976f;
		}

		// Token: 0x0600ED33 RID: 60723 RVA: 0x006B3F8C File Offset: 0x006B218C
		public void Reset()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.pelvis.Reset();
			Grounding.IKFNCHNNKNK[] legs = this.legs;
			for (int i = 0; i < legs.Length; i++)
			{
				legs[i].Reset();
			}
		}

		// Token: 0x04001F09 RID: 7945
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		// Token: 0x04001F0A RID: 7946
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep = 0.5f;

		// Token: 0x04001F0B RID: 7947
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		// Token: 0x04001F0C RID: 7948
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed = 2.5f;

		// Token: 0x04001F0D RID: 7949
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius = 0.15f;

		// Token: 0x04001F0E RID: 7950
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction = 0.05f;

		// Token: 0x04001F0F RID: 7951
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight = 1f;

		// Token: 0x04001F10 RID: 7952
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed = 7f;

		// Token: 0x04001F11 RID: 7953
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle = 45f;

		// Token: 0x04001F12 RID: 7954
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		// Token: 0x04001F13 RID: 7955
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed = 5f;

		// Token: 0x04001F14 RID: 7956
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		// Token: 0x04001F15 RID: 7957
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight = 1f;

		// Token: 0x04001F16 RID: 7958
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		// Token: 0x04001F17 RID: 7959
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius = 0.1f;

		// Token: 0x04001F18 RID: 7960
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Grounding.Quality quality = Grounding.Quality.Best;

		// Token: 0x04001F1E RID: 7966
		private bool initiated;

		// Token: 0x0200044C RID: 1100
		[Serializable]
		public enum Quality
		{
			// Token: 0x04001F20 RID: 7968
			Fastest,
			// Token: 0x04001F21 RID: 7969
			Simple,
			// Token: 0x04001F22 RID: 7970
			Best
		}

		// Token: 0x0200044D RID: 1101
		public class IKFNCHNNKNK
		{
			// Token: 0x0600ED34 RID: 60724 RVA: 0x006B3FCC File Offset: 0x006B21CC
			private float CPPCBHMMNEF()
			{
				return this.FOPGCDCEFOB.NDKEMNKHFGL(this.KHCMDNOGOMB().position, this.FOPGCDCEFOB.ADDDPBLDEIJ().position - this.IEKEFNKJAPB * this.FOPGCDCEFOB.heightOffset);
			}

			// Token: 0x0600ED35 RID: 60725 RVA: 0x006B401C File Offset: 0x006B221C
			public void MPGGEICPLMC()
			{
				this.IABMNPENOFE = this.KHCMDNOGOMB().position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CIJMPJDKKGC = 1086f;
				this.JNGBNPAGAFI(this.KHCMDNOGOMB().position);
				this.DHLGGFPNOEK(Quaternion.identity);
			}

			// Token: 0x0600ED36 RID: 60726 RVA: 0x006B406C File Offset: 0x006B226C
			public void EKOHIDBILAI()
			{
				if (!this.NILINNMKBFL())
				{
					return;
				}
				this.IABMNPENOFE = this.KMACNJGAMEE().position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x0600ED37 RID: 60727 RVA: 0x006B4093 File Offset: 0x006B2293
			// (set) Token: 0x0600ED88 RID: 60808 RVA: 0x006B430A File Offset: 0x006B250A
			public Vector3 CGAMODJNLAC { get; private set; }

			// Token: 0x0600ED38 RID: 60728 RVA: 0x006B409B File Offset: 0x006B229B
			public float CBBCPHHJFNN()
			{
				return Mathf.Clamp(this.PKNLLDNGPKD(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600ED39 RID: 60729 RVA: 0x006B40C0 File Offset: 0x006B22C0
			private RaycastHit BPINMFMFIGF(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.KHCMDNOGOMB().position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 964f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 75f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 1095f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600ED3A RID: 60730 RVA: 0x006B4188 File Offset: 0x006B2388
			private void CJNNMGJHIAO()
			{
				Quaternion b = this.HAHIDCIFJCB();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600ED3B RID: 60731 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void CPDLAEEDLHA(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED3C RID: 60732 RVA: 0x006B41C9 File Offset: 0x006B23C9
			private void INOMNGHNAGO(float DCCPCBLODIG)
			{
				this.<LEDNHBCGIIJ>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED3E RID: 60734 RVA: 0x006B41E5 File Offset: 0x006B23E5
			private void DGKAJMJMGHN(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.HKEMEACGPII(LJGHBOFJDBJ));
				this.FJOMNDLHNHB(this.MOCNMAFBCGJ(JJNHJKFMFLJ));
			}

			// Token: 0x0600ED3F RID: 60735 RVA: 0x006B420C File Offset: 0x006B240C
			public bool FJOENGFNJPC()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600ED40 RID: 60736 RVA: 0x006B4214 File Offset: 0x006B2414
			private float BOHPFFINOPL(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.KJLOCEDPEKM(this.KMACNJGAMEE().position, MDAAKFKHBIC) - this.DCPBCLGPPJJ();
			}

			// Token: 0x0600ED41 RID: 60737 RVA: 0x006B4234 File Offset: 0x006B2434
			private float AKCPCFAPLEM(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.DNFGGLBPNDK(this.LPBDALAMAEM.position, MDAAKFKHBIC) - this.DCPBCLGPPJJ();
			}

			// Token: 0x0600ED42 RID: 60738 RVA: 0x006B4254 File Offset: 0x006B2454
			private void AAEPEPNPIAB(Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP, Vector3 JIAMDOFNODP)
			{
				KACGOENIMCA = this.PJIALAADLDB(KACGOENIMCA);
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, KACGOENIMCA);
				Vector3 mdaakfkhbic = OOJJKBHKGNJ.OFGBHBILPOE(this.LPBDALAMAEM.position + this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep, -this.IEKEFNKJAPB, KACGOENIMCA, AIDDGKFBIOP);
				this.CNJKCMDKBDB = this.MNDDEPBINHK(mdaakfkhbic);
				float max = this.MNDDEPBINHK(JIAMDOFNODP);
				this.CNJKCMDKBDB = Mathf.Clamp(this.CNJKCMDKBDB, float.NegativeInfinity, max);
			}

			// Token: 0x0600ED43 RID: 60739 RVA: 0x006B42E1 File Offset: 0x006B24E1
			private void PFADCNHHFJH(Vector3 DCCPCBLODIG)
			{
				this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED44 RID: 60740 RVA: 0x006B42EA File Offset: 0x006B24EA
			private float OLBFCMHKODL(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.NDKEMNKHFGL(this.KHCMDNOGOMB().position, MDAAKFKHBIC) - this.CPPCBHMMNEF();
			}

			// Token: 0x0600ED45 RID: 60741 RVA: 0x006B430A File Offset: 0x006B250A
			private void JDOLFGHHLCH(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED46 RID: 60742 RVA: 0x006B4313 File Offset: 0x006B2513
			public float LLODPDFLILB()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600ED47 RID: 60743 RVA: 0x006B431B File Offset: 0x006B251B
			public void FHDCCINOPJD(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.CEBGKELMDCE(true);
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.HPJLJDNGHDP(LPBDALAMAEM);
				this.IEKEFNKJAPB = Vector3.up;
				this.JNGBNPAGAFI(LPBDALAMAEM.position);
				this.EOFDOPLDFCG = true;
				this.ADBAOPJBGHG();
			}

			// Token: 0x0600ED48 RID: 60744 RVA: 0x006B4356 File Offset: 0x006B2556
			private void PCBACEDMLJP(float DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED49 RID: 60745 RVA: 0x006B435F File Offset: 0x006B255F
			public void FNHMNDIEGJB(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.EOFDOPLDFCG = false;
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.IEKEFNKJAPB = Vector3.up;
				this.CGAMODJNLAC = LPBDALAMAEM.position;
				this.OAPKDOMNMMK(false);
				this.BHEHCDDBKIE();
			}

			// Token: 0x0600ED4A RID: 60746 RVA: 0x006B4093 File Offset: 0x006B2293
			public Vector3 NDGGJPEHKBC()
			{
				return this.<LBJHENFOFEE>k__BackingField;
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x0600ED4B RID: 60747 RVA: 0x006B439A File Offset: 0x006B259A
			// (set) Token: 0x0600EDB3 RID: 60851 RVA: 0x006B41C0 File Offset: 0x006B23C0
			public bool NMPDKHCEDKP { get; private set; }

			// Token: 0x0600ED4C RID: 60748 RVA: 0x006B43A4 File Offset: 0x006B25A4
			public void GFEAOCNJJEC()
			{
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CIJMPJDKKGC = 1053f;
				this.DJIBEDECBAF(this.LPBDALAMAEM.position);
				this.CNBDLJPJCML(Quaternion.identity);
			}

			// Token: 0x0600ED4D RID: 60749 RVA: 0x006B43F4 File Offset: 0x006B25F4
			private float IMNNNGKOANB(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.KJLOCEDPEKM(this.KHCMDNOGOMB().position, MDAAKFKHBIC) - this.CPPCBHMMNEF();
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x0600ED4E RID: 60750 RVA: 0x006B420C File Offset: 0x006B240C
			// (set) Token: 0x0600EDA4 RID: 60836 RVA: 0x006B4B05 File Offset: 0x006B2D05
			public bool EOFDOPLDFCG { get; private set; }

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x0600ED4F RID: 60751 RVA: 0x006B4313 File Offset: 0x006B2513
			// (set) Token: 0x0600ED79 RID: 60793 RVA: 0x006B41C9 File Offset: 0x006B23C9
			public float CNJKCMDKBDB { get; private set; }

			// Token: 0x0600ED50 RID: 60752 RVA: 0x006B4414 File Offset: 0x006B2614
			private Quaternion HMNHIKMFLBC()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 1655f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 766f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600ED51 RID: 60753 RVA: 0x006B446D File Offset: 0x006B266D
			public void BHALELINNDJ(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.EOFDOPLDFCG = false;
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.IEKEFNKJAPB = Vector3.up;
				this.CGAMODJNLAC = LPBDALAMAEM.position;
				this.EOFDOPLDFCG = true;
				this.ADBAOPJBGHG();
			}

			// Token: 0x0600ED52 RID: 60754 RVA: 0x006B430A File Offset: 0x006B250A
			private void DJIBEDECBAF(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x0600EDB4 RID: 60852 RVA: 0x006B4EDC File Offset: 0x006B30DC
			// (set) Token: 0x0600ED53 RID: 60755 RVA: 0x006B44A8 File Offset: 0x006B26A8
			public Quaternion JNHPAAAFGKC { get; private set; }

			// Token: 0x0600ED54 RID: 60756 RVA: 0x006B439A File Offset: 0x006B259A
			public bool PNPMKDPCJBM()
			{
				return this.<PJAHEGHNFLB>k__BackingField;
			}

			// Token: 0x0600ED55 RID: 60757 RVA: 0x006B406C File Offset: 0x006B226C
			public void CABDFNIKOOI()
			{
				if (!this.NILINNMKBFL())
				{
					return;
				}
				this.IABMNPENOFE = this.KMACNJGAMEE().position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x0600ED56 RID: 60758 RVA: 0x006B44B4 File Offset: 0x006B26B4
			private void FMLMOPDEPMK()
			{
				Quaternion b = this.PPDKHCEBOGM();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600ED57 RID: 60759 RVA: 0x006B44EC File Offset: 0x006B26EC
			private RaycastHit BFIGHDLFMGD(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.LPBDALAMAEM.position + this.FOPGCDCEFOB.root.forward * this.FOPGCDCEFOB.footRadius;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 2f;
				result.normal = this.IEKEFNKJAPB;
				Vector3 vector = a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB;
				Vector3 point = vector + GHPEKJBJOGI;
				Physics.CapsuleCast(vector, point, this.FOPGCDCEFOB.footRadius, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 3f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600ED58 RID: 60760 RVA: 0x006B44A8 File Offset: 0x006B26A8
			private void HFDJMCMPFHG(Quaternion DCCPCBLODIG)
			{
				this.<PMBAGCOIIDD>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED59 RID: 60761 RVA: 0x006B45D4 File Offset: 0x006B27D4
			private float NBHOEPLKGIN()
			{
				return this.FOPGCDCEFOB.DNFGGLBPNDK(this.KHCMDNOGOMB().position, this.FOPGCDCEFOB.CCPNCFNGOPI().position - this.IEKEFNKJAPB * this.FOPGCDCEFOB.heightOffset);
			}

			// Token: 0x0600ED5A RID: 60762 RVA: 0x006B41C9 File Offset: 0x006B23C9
			private void FLMEGBDMINN(float DCCPCBLODIG)
			{
				this.<LEDNHBCGIIJ>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED5B RID: 60763 RVA: 0x006B4622 File Offset: 0x006B2822
			public void BHEHCDDBKIE()
			{
				if (!this.FLHHDDOMEII())
				{
					return;
				}
				this.IABMNPENOFE = this.KMACNJGAMEE().position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x0600ED5C RID: 60764 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 LIAJIMPDHLN()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x0600ED5D RID: 60765 RVA: 0x006B4651 File Offset: 0x006B2851
			private float MNDDEPBINHK(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.HJKGGFJEOJG(this.LPBDALAMAEM.position, MDAAKFKHBIC) - this.KPLMGHLALJC;
			}

			// Token: 0x0600ED5E RID: 60766 RVA: 0x006B4674 File Offset: 0x006B2874
			private void PBLDECPCJIB()
			{
				Quaternion b = this.GFFPEIELLAC();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600ED5F RID: 60767 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 HJEDDLJCJBJ()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x0600ED60 RID: 60768 RVA: 0x006B409B File Offset: 0x006B229B
			public float OANEMHOKJOK()
			{
				return Mathf.Clamp(this.PKNLLDNGPKD(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600ED61 RID: 60769 RVA: 0x006B46AC File Offset: 0x006B28AC
			public void PAGNCBCACKL()
			{
				this.IABMNPENOFE = this.KHCMDNOGOMB().position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.DJGOBAKAJGG(275f);
				this.PGLOPKKFJLB(this.LPBDALAMAEM.position);
				this.HFDJMCMPFHG(Quaternion.identity);
			}

			// Token: 0x0600ED62 RID: 60770 RVA: 0x006B46FC File Offset: 0x006B28FC
			private Vector3 HKEMEACGPII(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == Grounding.Quality.Fastest)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 1744f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600ED63 RID: 60771 RVA: 0x006B4734 File Offset: 0x006B2934
			public void LFIIPLEGPNI()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				if (this.FOPGCDCEFOB.maxStep <= 0f)
				{
					return;
				}
				this.ENLHBNBNPJN = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (this.ENLHBNBNPJN == 0f)
				{
					return;
				}
				this.IEKEFNKJAPB = this.FOPGCDCEFOB.up;
				this.CNJKCMDKBDB = float.PositiveInfinity;
				this.APOIOHJJDDC = (this.LPBDALAMAEM.position - this.IABMNPENOFE) / this.ENLHBNBNPJN;
				this.APOIOHJJDDC = this.FOPGCDCEFOB.KJLNNACBFFD(this.APOIOHJJDDC);
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				Vector3 vector = this.APOIOHJJDDC * this.FOPGCDCEFOB.prediction;
				if (this.FOPGCDCEFOB.footRadius <= 0f)
				{
					this.FOPGCDCEFOB.quality = Grounding.Quality.Fastest;
				}
				switch (this.FOPGCDCEFOB.quality)
				{
				case Grounding.Quality.Fastest:
				{
					RaycastHit raycastHit = this.KACDGAPAIBP(vector);
					this.DLMEDCBMGPM(raycastHit.normal, raycastHit.point);
					break;
				}
				case Grounding.Quality.Simple:
				{
					this.BOAHGBPCPNI = this.KACDGAPAIBP(Vector3.zero);
					RaycastHit raycastHit2 = this.KACDGAPAIBP(this.FOPGCDCEFOB.root.forward * this.FOPGCDCEFOB.footRadius + vector);
					RaycastHit raycastHit3 = this.KACDGAPAIBP(this.FOPGCDCEFOB.root.right * this.FOPGCDCEFOB.footRadius * 0.5f);
					Vector3 vector2 = Vector3.Cross(raycastHit2.point - this.BOAHGBPCPNI.point, raycastHit3.point - this.BOAHGBPCPNI.point).normalized;
					if (Vector3.Dot(vector2, this.IEKEFNKJAPB) < 0f)
					{
						vector2 = -vector2;
					}
					this.AAEPEPNPIAB(vector2, this.BOAHGBPCPNI.point, this.BOAHGBPCPNI.point);
					break;
				}
				case Grounding.Quality.Best:
				{
					this.BOAHGBPCPNI = this.KACDGAPAIBP(Vector3.zero);
					RaycastHit raycastHit4 = this.BFIGHDLFMGD(vector);
					this.AAEPEPNPIAB(raycastHit4.normal, raycastHit4.point, this.BOAHGBPCPNI.point);
					break;
				}
				}
				this.NMPDKHCEDKP = (this.CNJKCMDKBDB < this.FOPGCDCEFOB.maxStep);
				float num = this.CCMCLKENINJ;
				if (!this.FOPGCDCEFOB.rootGrounded)
				{
					num = 0f;
				}
				this.CIJMPJDKKGC = AINDCMJDEOG.CLCJBENKCMB(this.CIJMPJDKKGC, num, this.FOPGCDCEFOB.footSpeed, this.FOPGCDCEFOB.footSpeed);
				this.CIJMPJDKKGC = Mathf.Lerp(this.CIJMPJDKKGC, num, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footSpeed);
				float num2 = this.FOPGCDCEFOB.HJKGGFJEOJG(this.LPBDALAMAEM.position, this.FOPGCDCEFOB.root.position);
				float num3 = Mathf.Clamp(this.FOPGCDCEFOB.maxStep - num2, 0f, this.FOPGCDCEFOB.maxStep);
				this.CIJMPJDKKGC = Mathf.Clamp(this.CIJMPJDKKGC, -num3, this.CIJMPJDKKGC);
				this.PBLDECPCJIB();
				this.CGAMODJNLAC = this.LPBDALAMAEM.position - this.IEKEFNKJAPB * this.CIJMPJDKKGC;
				float footRotationWeight = this.FOPGCDCEFOB.footRotationWeight;
				this.JNHPAAAFGKC = ((footRotationWeight >= 1f) ? this.AJMNDCHJPNK : Quaternion.Slerp(Quaternion.identity, this.AJMNDCHJPNK, footRotationWeight));
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x006B4AFD File Offset: 0x006B2CFD
			// (set) Token: 0x0600ED64 RID: 60772 RVA: 0x006B4356 File Offset: 0x006B2556
			public float CIJMPJDKKGC { get; private set; }

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x0600ED65 RID: 60773 RVA: 0x006B4AD9 File Offset: 0x006B2CD9
			public float CCMCLKENINJ
			{
				get
				{
					return Mathf.Clamp(this.CNJKCMDKBDB, -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
				}
			}

			// Token: 0x0600ED67 RID: 60775 RVA: 0x006B42E1 File Offset: 0x006B24E1
			private void HGKJNEDMLLI(Vector3 DCCPCBLODIG)
			{
				this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED68 RID: 60776 RVA: 0x006B4AFD File Offset: 0x006B2CFD
			public float CIOFGKFBNJM()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600ED69 RID: 60777 RVA: 0x006B4B05 File Offset: 0x006B2D05
			private void KFKDGMKKPAB(bool DCCPCBLODIG)
			{
				this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED6A RID: 60778 RVA: 0x006B4B10 File Offset: 0x006B2D10
			public void CIIGCMJOCEG()
			{
				if (!this.AJCHOLMMDBM())
				{
					return;
				}
				if (this.FOPGCDCEFOB.maxStep <= 159f)
				{
					return;
				}
				this.ENLHBNBNPJN = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (this.ENLHBNBNPJN == 1343f)
				{
					return;
				}
				this.IEKEFNKJAPB = this.FOPGCDCEFOB.APHMAFCCPMP();
				this.FLMEGBDMINN(1473f);
				this.HGKJNEDMLLI((this.LPBDALAMAEM.position - this.IABMNPENOFE) / this.ENLHBNBNPJN);
				this.HGKJNEDMLLI(this.FOPGCDCEFOB.ICCKOEJHNNP(this.HJEDDLJCJBJ()));
				this.IABMNPENOFE = this.KMACNJGAMEE().position;
				Vector3 vector = this.EFIPKDPEBHE() * this.FOPGCDCEFOB.prediction;
				if (this.FOPGCDCEFOB.footRadius <= 527f)
				{
					this.FOPGCDCEFOB.quality = Grounding.Quality.Simple;
				}
				switch (this.FOPGCDCEFOB.quality)
				{
				case Grounding.Quality.Fastest:
				{
					RaycastHit raycastHit = this.KBOPCLKLAGE(vector);
					this.BLCNFOIMAIP(raycastHit.normal, raycastHit.point);
					break;
				}
				case Grounding.Quality.Simple:
				{
					this.BOAHGBPCPNI = this.EHPHIOFHACH(Vector3.zero);
					RaycastHit raycastHit2 = this.BPINMFMFIGF(this.FOPGCDCEFOB.NNFDENENHFJ().forward * this.FOPGCDCEFOB.footRadius + vector);
					RaycastHit raycastHit3 = this.DPCMEMHKCIJ(this.FOPGCDCEFOB.CCPNCFNGOPI().right * this.FOPGCDCEFOB.footRadius * 330f);
					Vector3 vector2 = Vector3.Cross(raycastHit2.point - this.BOAHGBPCPNI.point, raycastHit3.point - this.BOAHGBPCPNI.point).normalized;
					if (Vector3.Dot(vector2, this.IEKEFNKJAPB) < 1360f)
					{
						vector2 = -vector2;
					}
					this.ENBFDEDIDAD(vector2, this.BOAHGBPCPNI.point, this.BOAHGBPCPNI.point);
					break;
				}
				case Grounding.Quality.Best:
				{
					this.BOAHGBPCPNI = this.KBOPCLKLAGE(Vector3.zero);
					RaycastHit raycastHit4 = this.BFIGHDLFMGD(vector);
					this.AAEPEPNPIAB(raycastHit4.normal, raycastHit4.point, this.BOAHGBPCPNI.point);
					break;
				}
				}
				this.BABFNCIDEPB(this.GNMPLJLIEOG() < this.FOPGCDCEFOB.maxStep);
				float num = this.CBBCPHHJFNN();
				if (!this.FOPGCDCEFOB.JODKJKPBBNJ())
				{
					num = 1712f;
				}
				this.ADGLDLCBDJA(AINDCMJDEOG.CLCJBENKCMB(this.CIJMPJDKKGC, num, this.FOPGCDCEFOB.footSpeed, this.FOPGCDCEFOB.footSpeed));
				this.ADGLDLCBDJA(Mathf.Lerp(this.CIJMPJDKKGC, num, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footSpeed));
				float num2 = this.FOPGCDCEFOB.PNIFBAOPFMP(this.KHCMDNOGOMB().position, this.FOPGCDCEFOB.CCPNCFNGOPI().position);
				float num3 = Mathf.Clamp(this.FOPGCDCEFOB.maxStep - num2, 774f, this.FOPGCDCEFOB.maxStep);
				this.HNLIGMHLJEC(Mathf.Clamp(this.CIOFGKFBNJM(), -num3, this.CIOFGKFBNJM()));
				this.JEFFAMJOGAO();
				this.PGLOPKKFJLB(this.KHCMDNOGOMB().position - this.IEKEFNKJAPB * this.CIJMPJDKKGC);
				float footRotationWeight = this.FOPGCDCEFOB.footRotationWeight;
				this.HFDJMCMPFHG((footRotationWeight >= 627f) ? this.AJMNDCHJPNK : Quaternion.Slerp(Quaternion.identity, this.AJMNDCHJPNK, footRotationWeight));
			}

			// Token: 0x0600ED6B RID: 60779 RVA: 0x006B4313 File Offset: 0x006B2513
			public float PKNLLDNGPKD()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600ED6C RID: 60780 RVA: 0x006B4EB5 File Offset: 0x006B30B5
			private void GPBIECNIMFF(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.MOKIDJEAKIA(LJGHBOFJDBJ));
				this.CNJKCMDKBDB = this.MNDDEPBINHK(JJNHJKFMFLJ);
			}

			// Token: 0x0600ED6D RID: 60781 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion PGOCIAGCACN()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600ED6E RID: 60782 RVA: 0x006B409B File Offset: 0x006B229B
			public float NHFBOLMOGGF()
			{
				return Mathf.Clamp(this.PKNLLDNGPKD(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600ED6F RID: 60783 RVA: 0x006B409B File Offset: 0x006B229B
			public float ANFAPKPBIPL()
			{
				return Mathf.Clamp(this.PKNLLDNGPKD(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600ED70 RID: 60784 RVA: 0x006B4356 File Offset: 0x006B2556
			private void DJGOBAKAJGG(float DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED71 RID: 60785 RVA: 0x006B4313 File Offset: 0x006B2513
			public float ACALKNLFBOA()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600ED72 RID: 60786 RVA: 0x006B4356 File Offset: 0x006B2556
			private void HFHFOHHMCDM(float DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED73 RID: 60787 RVA: 0x006B4EE4 File Offset: 0x006B30E4
			private void JKPBJCMFKKJ(Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP, Vector3 JIAMDOFNODP)
			{
				KACGOENIMCA = this.MBLFICEMHNP(KACGOENIMCA);
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, KACGOENIMCA);
				Vector3 mdaakfkhbic = OOJJKBHKGNJ.OFGBHBILPOE(this.KMACNJGAMEE().position + this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep, -this.IEKEFNKJAPB, KACGOENIMCA, AIDDGKFBIOP);
				this.FLMEGBDMINN(this.OLBFCMHKODL(mdaakfkhbic));
				float max = this.CBOLADFEAPN(JIAMDOFNODP);
				this.FJOMNDLHNHB(Mathf.Clamp(this.OHLGJNFFMDB(), 1764f, max));
			}

			// Token: 0x0600ED74 RID: 60788 RVA: 0x006B430A File Offset: 0x006B250A
			private void JNGBNPAGAFI(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED75 RID: 60789 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 NEEEMHFJJDD()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x0600ED76 RID: 60790 RVA: 0x006B4F74 File Offset: 0x006B3174
			private Quaternion HPHFEBGGDEM()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 1341f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 1246f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600ED77 RID: 60791 RVA: 0x006B439A File Offset: 0x006B259A
			public bool CCIDAALACIK()
			{
				return this.<PJAHEGHNFLB>k__BackingField;
			}

			// Token: 0x0600ED78 RID: 60792 RVA: 0x006B430A File Offset: 0x006B250A
			private void PGLPCONGMDE(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED7A RID: 60794 RVA: 0x006B41C9 File Offset: 0x006B23C9
			private void JNKBNOFFNAN(float DCCPCBLODIG)
			{
				this.<LEDNHBCGIIJ>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED7B RID: 60795 RVA: 0x006B4FCD File Offset: 0x006B31CD
			private Vector3 AKKHJFOOMHE(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == Grounding.Quality.Fastest)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 1958f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600ED7C RID: 60796 RVA: 0x006B430A File Offset: 0x006B250A
			private void EGAOMHOMFCB(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED7D RID: 60797 RVA: 0x006B439A File Offset: 0x006B259A
			public bool NBAANGMEENG()
			{
				return this.<PJAHEGHNFLB>k__BackingField;
			}

			// Token: 0x0600ED7E RID: 60798 RVA: 0x006B41C9 File Offset: 0x006B23C9
			private void FJOMNDLHNHB(float DCCPCBLODIG)
			{
				this.<LEDNHBCGIIJ>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED7F RID: 60799 RVA: 0x006B5002 File Offset: 0x006B3202
			private Vector3 MOKIDJEAKIA(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == (Grounding.Quality)3)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 160f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600ED80 RID: 60800 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 MIBIKPDJBJF()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x0600ED81 RID: 60801 RVA: 0x006B420C File Offset: 0x006B240C
			public bool AJCHOLMMDBM()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600ED82 RID: 60802 RVA: 0x006B5037 File Offset: 0x006B3237
			public float OEFBFKPPKOE()
			{
				return Mathf.Clamp(this.ACALKNLFBOA(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600ED83 RID: 60803 RVA: 0x006B4093 File Offset: 0x006B2293
			public Vector3 IEACGFIGBEE()
			{
				return this.<LBJHENFOFEE>k__BackingField;
			}

			// Token: 0x0600ED84 RID: 60804 RVA: 0x006B4313 File Offset: 0x006B2513
			public float GNMPLJLIEOG()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600ED85 RID: 60805 RVA: 0x006B505B File Offset: 0x006B325B
			public void IKFFGPLEECL()
			{
				if (!this.NILINNMKBFL())
				{
					return;
				}
				this.IABMNPENOFE = this.KHCMDNOGOMB().position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x0600ED86 RID: 60806 RVA: 0x006B5082 File Offset: 0x006B3282
			private Vector3 MBLFICEMHNP(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == Grounding.Quality.Fastest)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 1859f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600ED87 RID: 60807 RVA: 0x006B50B7 File Offset: 0x006B32B7
			private void ENDFKGFFDCL(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.HKEMEACGPII(LJGHBOFJDBJ));
				this.FLMEGBDMINN(this.MNDDEPBINHK(JJNHJKFMFLJ));
			}

			// Token: 0x0600ED89 RID: 60809 RVA: 0x006B50DE File Offset: 0x006B32DE
			private void GLJHOJAEKJJ(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.MBLFICEMHNP(LJGHBOFJDBJ));
				this.JNKBNOFFNAN(this.BOHPFFINOPL(JJNHJKFMFLJ));
			}

			// Token: 0x0600ED8A RID: 60810 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion HNPADDHKIAM()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600ED8B RID: 60811 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion PMMFCIFLLMD()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600ED8C RID: 60812 RVA: 0x006B5108 File Offset: 0x006B3308
			public void IGPBBKEALGO()
			{
				if (!this.FLHHDDOMEII())
				{
					return;
				}
				if (this.FOPGCDCEFOB.maxStep <= 524f)
				{
					return;
				}
				this.ENLHBNBNPJN = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (this.ENLHBNBNPJN == 1865f)
				{
					return;
				}
				this.IEKEFNKJAPB = this.FOPGCDCEFOB.HJIAPMAKJOJ();
				this.FLMEGBDMINN(49f);
				this.PFADCNHHFJH((this.KMACNJGAMEE().position - this.IABMNPENOFE) / this.ENLHBNBNPJN);
				this.PFADCNHHFJH(this.FOPGCDCEFOB.DCCBIHODDMN(this.NEEEMHFJJDD()));
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				Vector3 vector = this.NEEEMHFJJDD() * this.FOPGCDCEFOB.prediction;
				if (this.FOPGCDCEFOB.footRadius <= 241f)
				{
					this.FOPGCDCEFOB.quality = Grounding.Quality.Simple;
				}
				switch (this.FOPGCDCEFOB.quality)
				{
				case Grounding.Quality.Fastest:
				{
					RaycastHit raycastHit = this.BPINMFMFIGF(vector);
					this.GPBIECNIMFF(raycastHit.normal, raycastHit.point);
					break;
				}
				case Grounding.Quality.Simple:
				{
					this.BOAHGBPCPNI = this.EHPHIOFHACH(Vector3.zero);
					RaycastHit raycastHit2 = this.DPCMEMHKCIJ(this.FOPGCDCEFOB.NNFDENENHFJ().forward * this.FOPGCDCEFOB.footRadius + vector);
					RaycastHit raycastHit3 = this.KBOPCLKLAGE(this.FOPGCDCEFOB.CCPNCFNGOPI().right * this.FOPGCDCEFOB.footRadius * 864f);
					Vector3 vector2 = Vector3.Cross(raycastHit2.point - this.BOAHGBPCPNI.point, raycastHit3.point - this.BOAHGBPCPNI.point).normalized;
					if (Vector3.Dot(vector2, this.IEKEFNKJAPB) < 918f)
					{
						vector2 = -vector2;
					}
					this.JKPBJCMFKKJ(vector2, this.BOAHGBPCPNI.point, this.BOAHGBPCPNI.point);
					break;
				}
				case Grounding.Quality.Best:
				{
					this.BOAHGBPCPNI = this.KACDGAPAIBP(Vector3.zero);
					RaycastHit raycastHit4 = this.BFIGHDLFMGD(vector);
					this.JKPBJCMFKKJ(raycastHit4.normal, raycastHit4.point, this.BOAHGBPCPNI.point);
					break;
				}
				}
				this.EJIAAJLMMKB(this.EKIOKDOOLLI() < this.FOPGCDCEFOB.maxStep);
				float num = this.MBFAACAFJAE();
				if (!this.FOPGCDCEFOB.rootGrounded)
				{
					num = 596f;
				}
				this.ADGLDLCBDJA(AINDCMJDEOG.CLCJBENKCMB(this.HCMNHEIPLCB(), num, this.FOPGCDCEFOB.footSpeed, this.FOPGCDCEFOB.footSpeed));
				this.ADGLDLCBDJA(Mathf.Lerp(this.CIJMPJDKKGC, num, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footSpeed));
				float num2 = this.FOPGCDCEFOB.PNIFBAOPFMP(this.LPBDALAMAEM.position, this.FOPGCDCEFOB.LLNEEBLCHDM().position);
				float num3 = Mathf.Clamp(this.FOPGCDCEFOB.maxStep - num2, 1855f, this.FOPGCDCEFOB.maxStep);
				this.DJGOBAKAJGG(Mathf.Clamp(this.CIJMPJDKKGC, -num3, this.LJOGLKIGAHG()));
				this.CJNNMGJHIAO();
				this.PGLPCONGMDE(this.KMACNJGAMEE().position - this.IEKEFNKJAPB * this.LJOGLKIGAHG());
				float footRotationWeight = this.FOPGCDCEFOB.footRotationWeight;
				this.JNHPAAAFGKC = ((footRotationWeight >= 496f) ? this.AJMNDCHJPNK : Quaternion.Slerp(Quaternion.identity, this.AJMNDCHJPNK, footRotationWeight));
			}

			// Token: 0x0600ED8D RID: 60813 RVA: 0x006B54AD File Offset: 0x006B36AD
			private void NDFCEKGCNEF(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.FGBLDFMCEHG(LJGHBOFJDBJ));
				this.JNKBNOFFNAN(this.OLBFCMHKODL(JJNHJKFMFLJ));
			}

			// Token: 0x0600ED8E RID: 60814 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 EIAIEMDOOLL()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x0600ED8F RID: 60815 RVA: 0x006B4356 File Offset: 0x006B2556
			private void HNLIGMHLJEC(float DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED90 RID: 60816 RVA: 0x006B54D4 File Offset: 0x006B36D4
			public void Reset()
			{
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CIJMPJDKKGC = 0f;
				this.CGAMODJNLAC = this.LPBDALAMAEM.position;
				this.JNHPAAAFGKC = Quaternion.identity;
			}

			// Token: 0x0600ED91 RID: 60817 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void FONKIPLJBBJ(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED92 RID: 60818 RVA: 0x006B5524 File Offset: 0x006B3724
			public Transform KMACNJGAMEE()
			{
				return this.<HOPPIKMPGON>k__BackingField;
			}

			// Token: 0x0600ED93 RID: 60819 RVA: 0x006B552C File Offset: 0x006B372C
			private void GDIBNEIDHKL()
			{
				Quaternion b = this.PPDKHCEBOGM();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600ED94 RID: 60820 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void DMKECPNHJBM(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED95 RID: 60821 RVA: 0x006B420C File Offset: 0x006B240C
			public bool OMLDMABEOHN()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600ED96 RID: 60822 RVA: 0x006B4AFD File Offset: 0x006B2CFD
			public float HCMNHEIPLCB()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600ED97 RID: 60823 RVA: 0x006B5564 File Offset: 0x006B3764
			private void FKCPAFAHMGL(Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP, Vector3 JIAMDOFNODP)
			{
				KACGOENIMCA = this.MBLFICEMHNP(KACGOENIMCA);
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, KACGOENIMCA);
				Vector3 mdaakfkhbic = OOJJKBHKGNJ.OFGBHBILPOE(this.LPBDALAMAEM.position + this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep, -this.IEKEFNKJAPB, KACGOENIMCA, AIDDGKFBIOP);
				this.INOMNGHNAGO(this.CBOLADFEAPN(mdaakfkhbic));
				float max = this.OLBFCMHKODL(JIAMDOFNODP);
				this.CNJKCMDKBDB = Mathf.Clamp(this.CNJKCMDKBDB, 1344f, max);
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x0600ED9B RID: 60827 RVA: 0x006B4649 File Offset: 0x006B2849
			// (set) Token: 0x0600ED98 RID: 60824 RVA: 0x006B42E1 File Offset: 0x006B24E1
			public Vector3 APOIOHJJDDC { get; private set; }

			// Token: 0x0600ED99 RID: 60825 RVA: 0x006B55F4 File Offset: 0x006B37F4
			private void JEFFAMJOGAO()
			{
				Quaternion b = this.ONGGAMBEJHJ();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600ED9A RID: 60826 RVA: 0x006B562C File Offset: 0x006B382C
			public void AOMIADLDLEJ(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.OFGFGNMMBNL(true);
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.IEKEFNKJAPB = Vector3.up;
				this.CGAMODJNLAC = LPBDALAMAEM.position;
				this.OAPKDOMNMMK(false);
				this.CABDFNIKOOI();
			}

			// Token: 0x0600ED9C RID: 60828 RVA: 0x006B5667 File Offset: 0x006B3867
			private void DLMEDCBMGPM(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.PJIALAADLDB(LJGHBOFJDBJ));
				this.CNJKCMDKBDB = this.MNDDEPBINHK(JJNHJKFMFLJ);
			}

			// Token: 0x0600ED9D RID: 60829 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion BHPMHHGJHME()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600ED9E RID: 60830 RVA: 0x006B4B05 File Offset: 0x006B2D05
			private void CEBGKELMDCE(bool DCCPCBLODIG)
			{
				this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600ED9F RID: 60831 RVA: 0x006B5690 File Offset: 0x006B3890
			private void KIJKHECJLPL()
			{
				Quaternion b = this.HPHFEBGGDEM();
				this.AJMNDCHJPNK = Quaternion.Slerp(this.AJMNDCHJPNK, b, this.ENLHBNBNPJN * this.FOPGCDCEFOB.footRotationSpeed);
			}

			// Token: 0x0600EDA0 RID: 60832 RVA: 0x006B56C8 File Offset: 0x006B38C8
			private Vector3 PJIALAADLDB(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == Grounding.Quality.Best)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 0.017453292f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600EDA1 RID: 60833 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void PPJMEAEDHJB(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x0600EDA2 RID: 60834 RVA: 0x006B5524 File Offset: 0x006B3724
			// (set) Token: 0x0600EDD0 RID: 60880 RVA: 0x006B5D99 File Offset: 0x006B3F99
			public Transform LPBDALAMAEM { get; private set; }

			// Token: 0x0600EDA3 RID: 60835 RVA: 0x006B5700 File Offset: 0x006B3900
			private RaycastHit EHPHIOFHACH(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.LPBDALAMAEM.position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 1591f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 1792f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 991f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600EDA5 RID: 60837 RVA: 0x006B4093 File Offset: 0x006B2293
			public Vector3 BKEKFBNJBDN()
			{
				return this.<LBJHENFOFEE>k__BackingField;
			}

			// Token: 0x0600EDA6 RID: 60838 RVA: 0x006B57C6 File Offset: 0x006B39C6
			private void BLCNFOIMAIP(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.AKKHJFOOMHE(LJGHBOFJDBJ));
				this.FJOMNDLHNHB(this.AKCPCFAPLEM(JJNHJKFMFLJ));
			}

			// Token: 0x0600EDA7 RID: 60839 RVA: 0x006B57ED File Offset: 0x006B39ED
			private void PPJLOLJHCKP(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.HAEAFMHKMFO(LJGHBOFJDBJ));
				this.FJOMNDLHNHB(this.BOHPFFINOPL(JJNHJKFMFLJ));
			}

			// Token: 0x0600EDA8 RID: 60840 RVA: 0x006B5814 File Offset: 0x006B3A14
			public void JCKNOMKGMCP(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.CEBGKELMDCE(false);
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.IEKEFNKJAPB = Vector3.up;
				this.JDOLFGHHLCH(LPBDALAMAEM.position);
				this.OFGFGNMMBNL(true);
				this.IKFFGPLEECL();
			}

			// Token: 0x0600EDA9 RID: 60841 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion PKMFKFAFKCK()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600EDAA RID: 60842 RVA: 0x006B5524 File Offset: 0x006B3724
			public Transform KHCMDNOGOMB()
			{
				return this.<HOPPIKMPGON>k__BackingField;
			}

			// Token: 0x0600EDAB RID: 60843 RVA: 0x006B4649 File Offset: 0x006B2849
			public Vector3 EFIPKDPEBHE()
			{
				return this.<DPBDBCLGIOC>k__BackingField;
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x0600EDAC RID: 60844 RVA: 0x006B5850 File Offset: 0x006B3A50
			private float KPLMGHLALJC
			{
				get
				{
					return this.FOPGCDCEFOB.HJKGGFJEOJG(this.LPBDALAMAEM.position, this.FOPGCDCEFOB.root.position - this.IEKEFNKJAPB * this.FOPGCDCEFOB.heightOffset);
				}
			}

			// Token: 0x0600EDAD RID: 60845 RVA: 0x006B589E File Offset: 0x006B3A9E
			private float CBOLADFEAPN(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.KJLOCEDPEKM(this.LPBDALAMAEM.position, MDAAKFKHBIC) - this.NBHOEPLKGIN();
			}

			// Token: 0x0600EDAE RID: 60846 RVA: 0x006B4AFD File Offset: 0x006B2CFD
			public float LJOGLKIGAHG()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDAF RID: 60847 RVA: 0x006B420C File Offset: 0x006B240C
			public bool FLHHDDOMEII()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600EDB0 RID: 60848 RVA: 0x006B58BE File Offset: 0x006B3ABE
			private void CBILHNOCAGM(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.FGBLDFMCEHG(LJGHBOFJDBJ));
				this.JNKBNOFFNAN(this.MOCNMAFBCGJ(JJNHJKFMFLJ));
			}

			// Token: 0x0600EDB1 RID: 60849 RVA: 0x006B58E5 File Offset: 0x006B3AE5
			public void AKPLEHHPKGC()
			{
				if (!this.OMLDMABEOHN())
				{
					return;
				}
				this.IABMNPENOFE = this.KMACNJGAMEE().position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x0600EDB2 RID: 60850 RVA: 0x006B4356 File Offset: 0x006B2556
			private void ADGLDLCBDJA(float DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDB5 RID: 60853 RVA: 0x006B590C File Offset: 0x006B3B0C
			public void GNCKCDBCFGD()
			{
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.HFHFOHHMCDM(366f);
				this.CGAMODJNLAC = this.KHCMDNOGOMB().position;
				this.CNBDLJPJCML(Quaternion.identity);
			}

			// Token: 0x0600EDB6 RID: 60854 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void EJIAAJLMMKB(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDB7 RID: 60855 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void PGMLIPINKCF(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDB8 RID: 60856 RVA: 0x006B595C File Offset: 0x006B3B5C
			private void POPKBIPFPLG(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.MBLFICEMHNP(LJGHBOFJDBJ));
				this.INOMNGHNAGO(this.BOHPFFINOPL(JJNHJKFMFLJ));
			}

			// Token: 0x0600EDB9 RID: 60857 RVA: 0x006B4093 File Offset: 0x006B2293
			public Vector3 AGKMPPLKBDJ()
			{
				return this.<LBJHENFOFEE>k__BackingField;
			}

			// Token: 0x0600EDBA RID: 60858 RVA: 0x006B5984 File Offset: 0x006B3B84
			private RaycastHit KBOPCLKLAGE(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.LPBDALAMAEM.position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 114f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 548f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 1770f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600EDBB RID: 60859 RVA: 0x006B4313 File Offset: 0x006B2513
			public float OHLGJNFFMDB()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600EDBC RID: 60860 RVA: 0x006B5A4C File Offset: 0x006B3C4C
			private RaycastHit EEDJGKANNKN(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.KMACNJGAMEE().position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 383f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 838f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 0f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600EDBD RID: 60861 RVA: 0x006B41C0 File Offset: 0x006B23C0
			private void BABFNCIDEPB(bool DCCPCBLODIG)
			{
				this.<PJAHEGHNFLB>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDBE RID: 60862 RVA: 0x006B44A8 File Offset: 0x006B26A8
			private void DHLGGFPNOEK(Quaternion DCCPCBLODIG)
			{
				this.<PMBAGCOIIDD>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDBF RID: 60863 RVA: 0x006B430A File Offset: 0x006B250A
			private void PGLOPKKFJLB(Vector3 DCCPCBLODIG)
			{
				this.<LBJHENFOFEE>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDC0 RID: 60864 RVA: 0x006B420C File Offset: 0x006B240C
			public bool NILINNMKBFL()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600EDC1 RID: 60865 RVA: 0x006B5B14 File Offset: 0x006B3D14
			private RaycastHit DPCMEMHKCIJ(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.KMACNJGAMEE().position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 1069f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 1526f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 388f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600EDC2 RID: 60866 RVA: 0x006B5BDA File Offset: 0x006B3DDA
			private float MOCNMAFBCGJ(Vector3 MDAAKFKHBIC)
			{
				return this.FOPGCDCEFOB.DNFGGLBPNDK(this.KHCMDNOGOMB().position, MDAAKFKHBIC) - this.KPLMGHLALJC;
			}

			// Token: 0x0600EDC3 RID: 60867 RVA: 0x006B5BFA File Offset: 0x006B3DFA
			public void HMNPKENDIPF(Grounding FOPGCDCEFOB, Transform LPBDALAMAEM)
			{
				this.EOFDOPLDFCG = true;
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.IEKEFNKJAPB = Vector3.up;
				this.PGLPCONGMDE(LPBDALAMAEM.position);
				this.OFGFGNMMBNL(true);
				this.CABDFNIKOOI();
			}

			// Token: 0x0600EDC4 RID: 60868 RVA: 0x006B5C38 File Offset: 0x006B3E38
			private Quaternion GFFPEIELLAC()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 0f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 180f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600EDC5 RID: 60869 RVA: 0x006B409B File Offset: 0x006B229B
			public float DCIGHHCCAFK()
			{
				return Mathf.Clamp(this.PKNLLDNGPKD(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600EDC6 RID: 60870 RVA: 0x006B4B05 File Offset: 0x006B2D05
			private void OAPKDOMNMMK(bool DCCPCBLODIG)
			{
				this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDC7 RID: 60871 RVA: 0x006B4313 File Offset: 0x006B2513
			public float EKIOKDOOLLI()
			{
				return this.<LEDNHBCGIIJ>k__BackingField;
			}

			// Token: 0x0600EDC8 RID: 60872 RVA: 0x006B5C94 File Offset: 0x006B3E94
			private float DCPBCLGPPJJ()
			{
				return this.FOPGCDCEFOB.DNFGGLBPNDK(this.LPBDALAMAEM.position, this.FOPGCDCEFOB.NNFDENENHFJ().position - this.IEKEFNKJAPB * this.FOPGCDCEFOB.heightOffset);
			}

			// Token: 0x0600EDC9 RID: 60873 RVA: 0x006B4B05 File Offset: 0x006B2D05
			private void OFGFGNMMBNL(bool DCCPCBLODIG)
			{
				this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDCA RID: 60874 RVA: 0x006B5CE4 File Offset: 0x006B3EE4
			private Quaternion PPDKHCEBOGM()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 543f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 1911f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600EDCB RID: 60875 RVA: 0x006B5D40 File Offset: 0x006B3F40
			private Quaternion NGILNCBHMPM()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 317f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 1892f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600EDCC RID: 60876 RVA: 0x006B5D99 File Offset: 0x006B3F99
			private void HPJLJDNGHDP(Transform DCCPCBLODIG)
			{
				this.<HOPPIKMPGON>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDCD RID: 60877 RVA: 0x006B5DA2 File Offset: 0x006B3FA2
			private Vector3 HAEAFMHKMFO(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == (Grounding.Quality)8)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 1702f, this.ENLHBNBNPJN);
			}

			// Token: 0x0600EDCE RID: 60878 RVA: 0x006B5037 File Offset: 0x006B3237
			public float CFCJKBMKIGG()
			{
				return Mathf.Clamp(this.ACALKNLFBOA(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600EDCF RID: 60879 RVA: 0x006B420C File Offset: 0x006B240C
			public bool GCONIGNKBDN()
			{
				return this.<DBJJPDNABBI>k__BackingField;
			}

			// Token: 0x0600EDD1 RID: 60881 RVA: 0x006B5DD8 File Offset: 0x006B3FD8
			private void ENBFDEDIDAD(Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP, Vector3 JIAMDOFNODP)
			{
				KACGOENIMCA = this.FGBLDFMCEHG(KACGOENIMCA);
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, KACGOENIMCA);
				Vector3 mdaakfkhbic = OOJJKBHKGNJ.OFGBHBILPOE(this.LPBDALAMAEM.position + this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep, -this.IEKEFNKJAPB, KACGOENIMCA, AIDDGKFBIOP);
				this.INOMNGHNAGO(this.BOHPFFINOPL(mdaakfkhbic));
				float max = this.IMNNNGKOANB(JIAMDOFNODP);
				this.FJOMNDLHNHB(Mathf.Clamp(this.OHLGJNFFMDB(), 596f, max));
			}

			// Token: 0x0600EDD2 RID: 60882 RVA: 0x006B5E68 File Offset: 0x006B4068
			private void NPPPIPEKPOH(Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP, Vector3 JIAMDOFNODP)
			{
				KACGOENIMCA = this.PJIALAADLDB(KACGOENIMCA);
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, KACGOENIMCA);
				Vector3 mdaakfkhbic = OOJJKBHKGNJ.OFGBHBILPOE(this.LPBDALAMAEM.position + this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep, -this.IEKEFNKJAPB, KACGOENIMCA, AIDDGKFBIOP);
				this.INOMNGHNAGO(this.AKCPCFAPLEM(mdaakfkhbic));
				float max = this.BOHPFFINOPL(JIAMDOFNODP);
				this.INOMNGHNAGO(Mathf.Clamp(this.CNJKCMDKBDB, 635f, max));
			}

			// Token: 0x0600EDD3 RID: 60883 RVA: 0x006B5EF8 File Offset: 0x006B40F8
			private Quaternion ONGGAMBEJHJ()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 1994f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 1221f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600EDD4 RID: 60884 RVA: 0x006B44A8 File Offset: 0x006B26A8
			private void EAEMIGPOOBJ(Quaternion DCCPCBLODIG)
			{
				this.<PMBAGCOIIDD>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDD5 RID: 60885 RVA: 0x006B44A8 File Offset: 0x006B26A8
			private void CBKILMKPCIP(Quaternion DCCPCBLODIG)
			{
				this.<PMBAGCOIIDD>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDD6 RID: 60886 RVA: 0x006B5F54 File Offset: 0x006B4154
			private Quaternion HAHIDCIFJCB()
			{
				if (this.FOPGCDCEFOB.maxFootRotationAngle <= 271f)
				{
					return Quaternion.identity;
				}
				if (this.FOPGCDCEFOB.maxFootRotationAngle >= 804f)
				{
					return this.DPLBKMJLAGM;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.DPLBKMJLAGM, this.FOPGCDCEFOB.maxFootRotationAngle);
			}

			// Token: 0x0600EDD7 RID: 60887 RVA: 0x006B5FAD File Offset: 0x006B41AD
			private void IIEBFAJNGLL(Vector3 LJGHBOFJDBJ, Vector3 JJNHJKFMFLJ)
			{
				this.DPLBKMJLAGM = Quaternion.FromToRotation(this.IEKEFNKJAPB, this.AKKHJFOOMHE(LJGHBOFJDBJ));
				this.INOMNGHNAGO(this.MNDDEPBINHK(JJNHJKFMFLJ));
			}

			// Token: 0x0600EDD8 RID: 60888 RVA: 0x006B5FD4 File Offset: 0x006B41D4
			private RaycastHit KACDGAPAIBP(Vector3 GHPEKJBJOGI)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 a = this.LPBDALAMAEM.position + GHPEKJBJOGI;
				result.point = a - this.IEKEFNKJAPB * this.FOPGCDCEFOB.maxStep * 2f;
				result.normal = this.IEKEFNKJAPB;
				if (this.FOPGCDCEFOB.maxStep <= 0f)
				{
					return result;
				}
				Physics.Raycast(a + this.FOPGCDCEFOB.maxStep * this.IEKEFNKJAPB, -this.IEKEFNKJAPB, out result, this.FOPGCDCEFOB.maxStep * 3f, this.FOPGCDCEFOB.layers);
				return result;
			}

			// Token: 0x0600EDD9 RID: 60889 RVA: 0x006B609A File Offset: 0x006B429A
			public void ADBAOPJBGHG()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.IABMNPENOFE = this.LPBDALAMAEM.position;
				this.EDCFDDLFAHG = Time.deltaTime;
			}

			// Token: 0x0600EDDA RID: 60890 RVA: 0x006B44A8 File Offset: 0x006B26A8
			private void CNBDLJPJCML(Quaternion DCCPCBLODIG)
			{
				this.<PMBAGCOIIDD>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDDB RID: 60891 RVA: 0x006B439A File Offset: 0x006B259A
			public bool PJJEKLMPCDN()
			{
				return this.<PJAHEGHNFLB>k__BackingField;
			}

			// Token: 0x0600EDDC RID: 60892 RVA: 0x006B5037 File Offset: 0x006B3237
			public float MBFAACAFJAE()
			{
				return Mathf.Clamp(this.ACALKNLFBOA(), -this.FOPGCDCEFOB.maxStep, this.FOPGCDCEFOB.maxStep);
			}

			// Token: 0x0600EDDD RID: 60893 RVA: 0x006B4EDC File Offset: 0x006B30DC
			public Quaternion CJFGACCPDEH()
			{
				return this.<PMBAGCOIIDD>k__BackingField;
			}

			// Token: 0x0600EDDE RID: 60894 RVA: 0x006B4093 File Offset: 0x006B2293
			public Vector3 NHIOCAIOLFD()
			{
				return this.<LBJHENFOFEE>k__BackingField;
			}

			// Token: 0x0600EDDF RID: 60895 RVA: 0x006B60C1 File Offset: 0x006B42C1
			private Vector3 FGBLDFMCEHG(Vector3 LJGHBOFJDBJ)
			{
				if (this.FOPGCDCEFOB.quality == Grounding.Quality.Simple)
				{
					return LJGHBOFJDBJ;
				}
				return Vector3.RotateTowards(this.IEKEFNKJAPB, LJGHBOFJDBJ, this.FOPGCDCEFOB.maxFootRotationAngle * 1054f, this.ENLHBNBNPJN);
			}

			// Token: 0x04001F2B RID: 7979
			private Grounding FOPGCDCEFOB;

			// Token: 0x04001F2C RID: 7980
			private float EDCFDDLFAHG;

			// Token: 0x04001F2D RID: 7981
			private float ENLHBNBNPJN;

			// Token: 0x04001F2E RID: 7982
			private Vector3 IABMNPENOFE;

			// Token: 0x04001F2F RID: 7983
			private Quaternion DPLBKMJLAGM;

			// Token: 0x04001F30 RID: 7984
			private Quaternion AJMNDCHJPNK;

			// Token: 0x04001F31 RID: 7985
			private RaycastHit BOAHGBPCPNI;

			// Token: 0x04001F32 RID: 7986
			private Vector3 IEKEFNKJAPB = Vector3.up;
		}

		// Token: 0x0200044E RID: 1102
		public class PAIDIJDPLHG
		{
			// Token: 0x0600EDE0 RID: 60896 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 KPLDCDCLKLC()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDE1 RID: 60897 RVA: 0x006B60FE File Offset: 0x006B42FE
			public void EGADMJMBCCK()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.CCPNCFNGOPI().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.KEFMIFHLPBA(Vector3.zero);
				this.JOLFDIDNHEC = 1877f;
			}

			// Token: 0x0600EDE2 RID: 60898 RVA: 0x006B613C File Offset: 0x006B433C
			public void CPLOFPNBFEH(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = true;
				this.BGKOJIDABKB();
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x0600EE0F RID: 60943 RVA: 0x006B63B9 File Offset: 0x006B45B9
			// (set) Token: 0x0600EDE3 RID: 60899 RVA: 0x006B6152 File Offset: 0x006B4352
			public float JOLFDIDNHEC { get; private set; }

			// Token: 0x0600EDE4 RID: 60900 RVA: 0x006B615B File Offset: 0x006B435B
			public void ADBAOPJBGHG()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EDE5 RID: 60901 RVA: 0x006B618C File Offset: 0x006B438C
			public void OGOHEHIMLHP(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.MLPAEBKPFEN();
			}

			// Token: 0x0600EDE6 RID: 60902 RVA: 0x006B61A2 File Offset: 0x006B43A2
			public void GDICLOPBJKK()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.NNFDENENHFJ().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.JJEPMKCCPKB(Vector3.zero);
				this.LCODNGFLKEN(1441f);
			}

			// Token: 0x0600EDE7 RID: 60903 RVA: 0x006B61E0 File Offset: 0x006B43E0
			public void LFIIPLEGPNI(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 0f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.rootGrounded)
				{
					b = 0f;
				}
				this.JOLFDIDNHEC = Mathf.Lerp(this.JOLFDIDNHEC, b, num * this.FOPGCDCEFOB.pelvisSpeed);
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.root.position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 1f : 0f, 1f, 10f);
				this.JOLFDIDNHEC -= this.FOPGCDCEFOB.HJKGGFJEOJG(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK;
				this.CIJMPJDKKGC = this.FOPGCDCEFOB.up * this.JOLFDIDNHEC;
			}

			// Token: 0x0600EDE8 RID: 60904 RVA: 0x006B62F6 File Offset: 0x006B44F6
			public void ENMHDCFMLMD()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.LLNEEBLCHDM().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.KEFMIFHLPBA(Vector3.zero);
				this.JOLFDIDNHEC = 873f;
			}

			// Token: 0x0600EDE9 RID: 60905 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 CGDAHBENBOI()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDEA RID: 60906 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 NLAAJNKCEIF()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDEB RID: 60907 RVA: 0x006B6334 File Offset: 0x006B4534
			private void JJEPMKCCPKB(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDEC RID: 60908 RVA: 0x006B633D File Offset: 0x006B453D
			public void DJCPMHMDJEN()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.JEMAOEIBOLI().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.JJEPMKCCPKB(Vector3.zero);
				this.ENDDMLPLGHJ(1853f);
			}

			// Token: 0x0600EDED RID: 60909 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 DCPJAAHBKMB()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDEE RID: 60910 RVA: 0x006B637B File Offset: 0x006B457B
			public void Reset()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CIJMPJDKKGC = Vector3.zero;
				this.JOLFDIDNHEC = 0f;
			}

			// Token: 0x0600EDEF RID: 60911 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float BPIJLNHAGEP()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EDF0 RID: 60912 RVA: 0x006B63C1 File Offset: 0x006B45C1
			public void FEEPKDIIPIC(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.BGKOJIDABKB();
			}

			// Token: 0x0600EDF1 RID: 60913 RVA: 0x006B6334 File Offset: 0x006B4534
			private void CDGNHOCDOOM(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDF2 RID: 60914 RVA: 0x006B63D8 File Offset: 0x006B45D8
			public void LDFFJFKABIJ(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 1399f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.NHDBNEDHICI())
				{
					b = 270f;
				}
				this.JOLFDIDNHEC = Mathf.Lerp(this.BPIJLNHAGEP(), b, num * this.FOPGCDCEFOB.pelvisSpeed);
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.LLNEEBLCHDM().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.CCPNCFNGOPI().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 1610f : 1137f, 140f, 201f);
				this.JOLFDIDNHEC = this.BDFHMDPJDPE() - this.FOPGCDCEFOB.PNIFBAOPFMP(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK;
				this.CIJMPJDKKGC = this.FOPGCDCEFOB.HJIAPMAKJOJ() * this.CMEPAJMCIJD();
			}

			// Token: 0x0600EDF3 RID: 60915 RVA: 0x006B64EE File Offset: 0x006B46EE
			public void BGKOJIDABKB()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.LLNEEBLCHDM().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EDF4 RID: 60916 RVA: 0x006B6152 File Offset: 0x006B4352
			private void LCODNGFLKEN(float DCCPCBLODIG)
			{
				this.<KMJBDDEHGBC>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EDF5 RID: 60917 RVA: 0x006B6520 File Offset: 0x006B4720
			public void NNINEJDDJMN(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 59f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.ANNOGEJLHNB())
				{
					b = 915f;
				}
				this.LCODNGFLKEN(Mathf.Lerp(this.GPEKEAGPILB(), b, num * this.FOPGCDCEFOB.pelvisSpeed));
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.JEMAOEIBOLI().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.EDMKKCFBFBI().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 1504f : 1920f, 1690f, 1446f);
				this.LCODNGFLKEN(this.BDFHMDPJDPE() - this.FOPGCDCEFOB.NDKEMNKHFGL(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK);
				this.CIJMPJDKKGC = this.FOPGCDCEFOB.JGANCLNBKFI() * this.BPIJLNHAGEP();
			}

			// Token: 0x0600EDF6 RID: 60918 RVA: 0x006B6636 File Offset: 0x006B4836
			public void CKHKJOHKMEE(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.EEHJEDIFHJI();
			}

			// Token: 0x0600EDF7 RID: 60919 RVA: 0x006B664C File Offset: 0x006B484C
			public void IFHKCNLDGLG(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 1855f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.rootGrounded)
				{
					b = 1306f;
				}
				this.JOLFDIDNHEC = Mathf.Lerp(this.CMEPAJMCIJD(), b, num * this.FOPGCDCEFOB.pelvisSpeed);
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.EDMKKCFBFBI().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.ADDDPBLDEIJ().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 36f : 1954f, 1117f, 1156f);
				this.CLHJDDIIBLH(this.JOLFDIDNHEC - this.FOPGCDCEFOB.PNIFBAOPFMP(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK);
				this.JJEPMKCCPKB(this.FOPGCDCEFOB.JGANCLNBKFI() * this.JOLFDIDNHEC);
			}

			// Token: 0x0600EDF8 RID: 60920 RVA: 0x006B63C1 File Offset: 0x006B45C1
			public void ICPBAGNMFPE(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.BGKOJIDABKB();
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x0600EE16 RID: 60950 RVA: 0x006B60F6 File Offset: 0x006B42F6
			// (set) Token: 0x0600EDF9 RID: 60921 RVA: 0x006B6334 File Offset: 0x006B4534
			public Vector3 CIJMPJDKKGC { get; private set; }

			// Token: 0x0600EDFA RID: 60922 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 CEBNENIONKK()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDFB RID: 60923 RVA: 0x006B615B File Offset: 0x006B435B
			public void ACCKEFCOBGN()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EDFC RID: 60924 RVA: 0x006B6762 File Offset: 0x006B4962
			public void IBCBOLAGKNL(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.CPIEBNMKKMB();
			}

			// Token: 0x0600EDFD RID: 60925 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 BCCMNDJMEPG()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EDFE RID: 60926 RVA: 0x006B6778 File Offset: 0x006B4978
			public void NHPMLPGKKGD()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.NNFDENENHFJ().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CDGNHOCDOOM(Vector3.zero);
				this.LCODNGFLKEN(1878f);
			}

			// Token: 0x0600EDFF RID: 60927 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 PICADOHNEIC()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EE00 RID: 60928 RVA: 0x006B6152 File Offset: 0x006B4352
			private void CLHJDDIIBLH(float DCCPCBLODIG)
			{
				this.<KMJBDDEHGBC>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE01 RID: 60929 RVA: 0x006B6152 File Offset: 0x006B4352
			private void ENDDMLPLGHJ(float DCCPCBLODIG)
			{
				this.<KMJBDDEHGBC>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE02 RID: 60930 RVA: 0x006B64EE File Offset: 0x006B46EE
			public void DCPLMIMFNHG()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.LLNEEBLCHDM().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE03 RID: 60931 RVA: 0x006B67B6 File Offset: 0x006B49B6
			public void KHLFNAKOLAC()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.EDMKKCFBFBI().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CDGNHOCDOOM(Vector3.zero);
				this.CLHJDDIIBLH(453f);
			}

			// Token: 0x0600EE04 RID: 60932 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float KJHPIMBEHIA()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE05 RID: 60933 RVA: 0x006B63C1 File Offset: 0x006B45C1
			public void DPOFMEPOJED(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = false;
				this.BGKOJIDABKB();
			}

			// Token: 0x0600EE06 RID: 60934 RVA: 0x006B615B File Offset: 0x006B435B
			public void EEHJEDIFHJI()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE07 RID: 60935 RVA: 0x006B67F4 File Offset: 0x006B49F4
			public void OABEEBGFCGD(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 319f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.NHDBNEDHICI())
				{
					b = 1733f;
				}
				this.JOLFDIDNHEC = Mathf.Lerp(this.BPIJLNHAGEP(), b, num * this.FOPGCDCEFOB.pelvisSpeed);
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.ADDDPBLDEIJ().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.ADDDPBLDEIJ().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 1387f : 893f, 1701f, 508f);
				this.JOLFDIDNHEC -= this.FOPGCDCEFOB.NDKEMNKHFGL(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK;
				this.BLHDIKGNMFC(this.FOPGCDCEFOB.KMOMCLFHPCA() * this.BDFHMDPJDPE());
			}

			// Token: 0x0600EE08 RID: 60936 RVA: 0x006B690A File Offset: 0x006B4B0A
			public void EPLEHFCNKDJ()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.LLNEEBLCHDM().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CDGNHOCDOOM(Vector3.zero);
				this.CLHJDDIIBLH(1996f);
			}

			// Token: 0x0600EE09 RID: 60937 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float BDFHMDPJDPE()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE0A RID: 60938 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float IDMGMHHMFEO()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE0B RID: 60939 RVA: 0x006B6948 File Offset: 0x006B4B48
			public void MLPAEBKPFEN()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.EDMKKCFBFBI().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE0C RID: 60940 RVA: 0x006B6979 File Offset: 0x006B4B79
			public void LAAKOMDMBKK()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.root.transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.CIJMPJDKKGC = Vector3.zero;
				this.CLHJDDIIBLH(611f);
			}

			// Token: 0x0600EE0D RID: 60941 RVA: 0x006B69B7 File Offset: 0x006B4BB7
			public void BHALELINNDJ(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = true;
				this.ADBAOPJBGHG();
			}

			// Token: 0x0600EE0E RID: 60942 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float GPEKEAGPILB()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE10 RID: 60944 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 DFFHLACPDNO()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EE11 RID: 60945 RVA: 0x006B69CD File Offset: 0x006B4BCD
			public void DDCMDBDIENG()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.EDMKKCFBFBI().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.BCPNBNCLFAP(Vector3.zero);
				this.JOLFDIDNHEC = 1247f;
			}

			// Token: 0x0600EE12 RID: 60946 RVA: 0x006B6A0C File Offset: 0x006B4C0C
			public void FPHAPFBJOJJ(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 1800f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.JODKJKPBBNJ())
				{
					b = 1889f;
				}
				this.JOLFDIDNHEC = Mathf.Lerp(this.GPEKEAGPILB(), b, num * this.FOPGCDCEFOB.pelvisSpeed);
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.JEMAOEIBOLI().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.JEMAOEIBOLI().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 247f : 970f, 685f, 75f);
				this.JOLFDIDNHEC = this.IDMGMHHMFEO() - this.FOPGCDCEFOB.DNFGGLBPNDK(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK;
				this.BCPNBNCLFAP(this.FOPGCDCEFOB.APHMAFCCPMP() * this.CMEPAJMCIJD());
			}

			// Token: 0x0600EE13 RID: 60947 RVA: 0x006B6B24 File Offset: 0x006B4D24
			public void EBKHBOBENJI(float CDFPMCJJNLH, float HMKDPFPFILI, bool NMPDKHCEDKP)
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				float num = Time.time - this.EDCFDDLFAHG;
				this.EDCFDDLFAHG = Time.time;
				if (num <= 1103f)
				{
					return;
				}
				float b = CDFPMCJJNLH + HMKDPFPFILI;
				if (!this.FOPGCDCEFOB.ANNOGEJLHNB())
				{
					b = 616f;
				}
				this.LCODNGFLKEN(Mathf.Lerp(this.JOLFDIDNHEC, b, num * this.FOPGCDCEFOB.pelvisSpeed));
				Vector3 oelakkhnnjc = this.FOPGCDCEFOB.EDMKKCFBFBI().position - this.KBHOMENCBLP;
				this.KBHOMENCBLP = this.FOPGCDCEFOB.CCPNCFNGOPI().position;
				this.JMJPMAPNCGK = AINDCMJDEOG.CLCJBENKCMB(this.JMJPMAPNCGK, NMPDKHCEDKP ? 1895f : 1163f, 1891f, 1705f);
				this.LCODNGFLKEN(this.CMEPAJMCIJD() - this.FOPGCDCEFOB.DNFGGLBPNDK(oelakkhnnjc, Vector3.zero) * this.FOPGCDCEFOB.pelvisDamper * this.JMJPMAPNCGK);
				this.KEFMIFHLPBA(this.FOPGCDCEFOB.HJIAPMAKJOJ() * this.BDFHMDPJDPE());
			}

			// Token: 0x0600EE14 RID: 60948 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 IFIJLDMEODJ()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EE15 RID: 60949 RVA: 0x006B6948 File Offset: 0x006B4B48
			public void CPIEBNMKKMB()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.EDMKKCFBFBI().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE17 RID: 60951 RVA: 0x006B613C File Offset: 0x006B433C
			public void HNBMMLMAGMG(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = true;
				this.BGKOJIDABKB();
			}

			// Token: 0x0600EE18 RID: 60952 RVA: 0x006B6C3A File Offset: 0x006B4E3A
			public void NGOKJEOMFFP()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.ADDDPBLDEIJ().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE19 RID: 60953 RVA: 0x006B6334 File Offset: 0x006B4534
			private void KEFMIFHLPBA(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE1A RID: 60954 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float CMEPAJMCIJD()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE1C RID: 60956 RVA: 0x006B6334 File Offset: 0x006B4534
			private void EGDOINFOANF(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE1D RID: 60957 RVA: 0x006B6334 File Offset: 0x006B4534
			private void BLHDIKGNMFC(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE1E RID: 60958 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 PEKMJMNKKPE()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x0600EE1F RID: 60959 RVA: 0x006B64EE File Offset: 0x006B46EE
			public void NJCODNNAFEG()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.LLNEEBLCHDM().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE20 RID: 60960 RVA: 0x006B613C File Offset: 0x006B433C
			public void KGCOBEJCLHM(Grounding FOPGCDCEFOB)
			{
				this.FOPGCDCEFOB = FOPGCDCEFOB;
				this.EOFDOPLDFCG = true;
				this.BGKOJIDABKB();
			}

			// Token: 0x0600EE21 RID: 60961 RVA: 0x006B63B9 File Offset: 0x006B45B9
			public float PDJIKLPGBDE()
			{
				return this.<KMJBDDEHGBC>k__BackingField;
			}

			// Token: 0x0600EE22 RID: 60962 RVA: 0x006B6C6B File Offset: 0x006B4E6B
			public void KLPHHNMKNGN()
			{
				if (!this.EOFDOPLDFCG)
				{
					return;
				}
				this.KBHOMENCBLP = this.FOPGCDCEFOB.CCPNCFNGOPI().transform.position;
				this.EDCFDDLFAHG = Time.time;
			}

			// Token: 0x0600EE23 RID: 60963 RVA: 0x006B6334 File Offset: 0x006B4534
			private void BCPNBNCLFAP(Vector3 DCCPCBLODIG)
			{
				this.<LECOEMNCLJF>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600EE24 RID: 60964 RVA: 0x006B6C9C File Offset: 0x006B4E9C
			public void IHAMDEGIOGP()
			{
				this.KBHOMENCBLP = this.FOPGCDCEFOB.NNFDENENHFJ().transform.position;
				this.EDCFDDLFAHG = Time.deltaTime;
				this.EGDOINFOANF(Vector3.zero);
				this.JOLFDIDNHEC = 639f;
			}

			// Token: 0x0600EE25 RID: 60965 RVA: 0x006B60F6 File Offset: 0x006B42F6
			public Vector3 MJMIABHOKNF()
			{
				return this.<LECOEMNCLJF>k__BackingField;
			}

			// Token: 0x04001F35 RID: 7989
			private Grounding FOPGCDCEFOB;

			// Token: 0x04001F36 RID: 7990
			private Vector3 KBHOMENCBLP;

			// Token: 0x04001F37 RID: 7991
			private float JMJPMAPNCGK;

			// Token: 0x04001F38 RID: 7992
			private bool EOFDOPLDFCG;

			// Token: 0x04001F39 RID: 7993
			private float EDCFDDLFAHG;
		}
	}
}
