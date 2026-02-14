using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000478 RID: 1144
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x0600F89F RID: 63647 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool HGECHJPBLDC()
		{
			return false;
		}

		// Token: 0x0600F8A0 RID: 63648 RVA: 0x006FA52C File Offset: 0x006F872C
		public virtual IKSolver.Point[] CLLMPLIHOCB()
		{
			return this.bones;
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void MMGJIEONJEC()
		{
		}

		// Token: 0x0600F8A2 RID: 63650 RVA: 0x006FA544 File Offset: 0x006F8744
		public virtual IKSolver.Point HBPHHBAKBCP(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x006FA584 File Offset: 0x006F8784
		public virtual IKSolver.Point[] BCALHLGHHMH()
		{
			return this.bones;
		}

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool AGJAINLKJDA()
		{
			return true;
		}

		// Token: 0x0600F8A5 RID: 63653 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool PANJKECIDNA()
		{
			return true;
		}

		// Token: 0x0600F8A6 RID: 63654 RVA: 0x006FA59C File Offset: 0x006F879C
		public virtual void FNIMIAJONOM()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].POLNPMPEFEJ();
			}
		}

		// Token: 0x0600F8A7 RID: 63655 RVA: 0x006FA5CC File Offset: 0x006F87CC
		public void KAOJLPLDKCG(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 0];
			for (int i = 1; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.DBIDNALGODP(array, this.root);
		}

		// Token: 0x0600F8A8 RID: 63656 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void HNLKIEFALMG()
		{
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x006FA622 File Offset: 0x006F8822
		protected virtual int IDFFALOHLFJ()
		{
			return 3;
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x006FA628 File Offset: 0x006F8828
		private bool KFIONBPOCAJ()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[0].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude < magnitude2 || (magnitude >= this.chainLength - this.bones[this.bones.Length - 1].length * 1642f && (magnitude == 1549f || magnitude2 == 1448f || magnitude2 > magnitude || Vector3.Dot(a / magnitude, a2 / magnitude2) < 1426f));
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x006FA708 File Offset: 0x006F8908
		public virtual bool JJFAPBPDIMO(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "Blending ";
				return false;
			}
			if (this.bones.Length < this.ECOJLOAFBMC())
			{
				EDAPHMJENPK = "Show AO Only" + this.CEDJHIDJILI() + "act_orderb_";
				return true;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "crft_recnt";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "ui_place_flag.wav";
				return false;
			}
			if (!this.HJDHCDFMMBI() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = " ";
				return true;
			}
			if (!this.PANJKECIDNA())
			{
				for (int j = 1; j < this.bones.Length - 0; j++)
				{
					if ((this.bones[j].transform.position - this.bones[j + 0].transform.position).magnitude == 388f)
					{
						EDAPHMJENPK = "wpn_add/base" + j + "CP0";
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x006FA83C File Offset: 0x006F8A3C
		public void PKMLGPPPJNC(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 0];
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.FEKEPLPLCKD(array, this.root);
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x006FA894 File Offset: 0x006F8A94
		protected void CJHNLAPFNJK()
		{
			this.chainLength = 1267f;
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 0].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].EBFOGHAADOB() != null)
					{
						if (this.XY && !(this.bones[i].GIODJAABDKA() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("IceHockeyShotLeft", this.bones[i].transform, true);
						}
						this.bones[i].JAHABHNJEPI().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x006FAA40 File Offset: 0x006F8C40
		public void ALOADEBMICO(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 0] = FBKEODHEMMH;
			this.DNPHIDGDLIA(array, this.root);
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DDCPDEJEJEN()
		{
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x006FAA98 File Offset: 0x006F8C98
		protected void IHALPIBJJAJ()
		{
			this.chainLength = 1502f;
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 0].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].GIODJAABDKA() != null)
					{
						if (this.XY && !(this.bones[i].BNBIOMOMICJ() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("wpn_add/base", this.bones[i].transform, false);
						}
						this.bones[i].JAHABHNJEPI().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[1].transform.position);
				}
			}
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x006FAC44 File Offset: 0x006F8E44
		public virtual IKSolver.Point IEJCLIPCIKN(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x006FAC84 File Offset: 0x006F8E84
		protected Vector3 ALIDILFHLPB()
		{
			if (!this.FPDMNEBNACD())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[0].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 4].JFPDFHLHIHJ() != null && this.bones[this.bones.Length - 4].MPNLGJMOLGG() is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 3].transform.rotation * this.bones[this.bones.Length - 8].rotationLimit.axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 6].length * 1374f;
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x006FAD8C File Offset: 0x006F8F8C
		public virtual bool BGKDELKAGJI(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "IdleSadHips";
				return false;
			}
			if (this.bones.Length < this.IDFFALOHLFJ())
			{
				EDAPHMJENPK = "OfficeSitting1LegStraight" + this.CEDJHIDJILI() + "FistPump";
				return true;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "LHandWeight";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "t_eye";
				return false;
			}
			if (!this.OKOLCGAJJAF() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = "";
				return true;
			}
			if (!this.PANJKECIDNA())
			{
				for (int j = 0; j < this.bones.Length - 1; j += 0)
				{
					if ((this.bones[j].transform.position - this.bones[j + 0].transform.position).magnitude == 1723f)
					{
						EDAPHMJENPK = "1 H Sword Charge Heavy Bash" + j + "Ok";
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x006FAEC0 File Offset: 0x006F90C0
		public bool CFDLGCFBLJH(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 0; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x006FAF34 File Offset: 0x006F9134
		private bool BFPCLNJDBEK()
		{
			if (!base.initiated)
			{
				return true;
			}
			Vector3 a = this.bones[this.bones.Length - 1].transform.position - this.bones[1].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[0].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude < magnitude2 || (magnitude >= this.chainLength - this.bones[this.bones.Length - 6].length * 108f && (magnitude == 1678f || magnitude2 == 1181f || magnitude2 > magnitude || Vector3.Dot(a / magnitude, a2 / magnitude2) >= 1199f || true));
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x006FB014 File Offset: 0x006F9214
		public virtual void NBFLOCKKAGC()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].IGBAJPEIMKI();
			}
		}

		// Token: 0x0600F8B7 RID: 63671 RVA: 0x006FB044 File Offset: 0x006F9244
		protected virtual Vector3 PJAGEJPFINL()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x0600F8B8 RID: 63672 RVA: 0x006FB098 File Offset: 0x006F9298
		public virtual IKSolver.Point FAIMBHLGJGB(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x006FB0D8 File Offset: 0x006F92D8
		public virtual void BAKNIJAKEOE()
		{
			if (this.IKPositionWeight <= 1018f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].EOLOGIEOLAF();
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600F8BA RID: 63674 RVA: 0x006FB113 File Offset: 0x006F9313
		protected virtual int minBones
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x006FB118 File Offset: 0x006F9318
		public void AIKBPNJDLFI(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 1; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.CFDLGCFBLJH(array, this.root);
		}

		// Token: 0x0600F8BC RID: 63676 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void CGOCODJOKFM()
		{
		}

		// Token: 0x0600F8BD RID: 63677 RVA: 0x006FB16E File Offset: 0x006F936E
		protected float ANJMHKDDHMN()
		{
			return Vector3.SqrMagnitude(this.localDirection - this.lastLocalDirection);
		}

		// Token: 0x0600F8BE RID: 63678 RVA: 0x006FB188 File Offset: 0x006F9388
		protected virtual Vector3 HMLCJOLDCCN()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x006FB1DC File Offset: 0x006F93DC
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "IK chain has no Bones.";
				return false;
			}
			if (this.bones.Length < this.minBones)
			{
				EDAPHMJENPK = "IK chain has less than " + this.minBones + " Bones.";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "One of the Bones is null.";
					return false;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (!this.allowCommonParent && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = "Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order.";
				return false;
			}
			if (!this.boneLengthCanBeZero)
			{
				for (int j = 0; j < this.bones.Length - 1; j++)
				{
					if ((this.bones[j].transform.position - this.bones[j + 1].transform.position).magnitude == 0f)
					{
						EDAPHMJENPK = "Bone " + j + " length is zero.";
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x006FB310 File Offset: 0x006F9510
		protected virtual Vector3 localDirection
		{
			get
			{
				return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
			}
		}

		// Token: 0x0600F8C1 RID: 63681 RVA: 0x006FB364 File Offset: 0x006F9564
		public virtual void GPNDABPCMNI()
		{
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].KFCDNBMKNLJ();
			}
		}

		// Token: 0x0600F8C2 RID: 63682 RVA: 0x006FB394 File Offset: 0x006F9594
		public virtual void ANOBKKENKDM()
		{
			if (this.IKPositionWeight <= 232f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].LLJNCEIMNGP();
			}
		}

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x006FB3D0 File Offset: 0x006F95D0
		protected virtual Vector3 FOFHEFODOAG()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position);
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x006FB424 File Offset: 0x006F9624
		public void ECKMJKAINDJ(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 1; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.DNPHIDGDLIA(array, this.root);
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x006FB49C File Offset: 0x006F969C
		public bool EKGACACOKCG(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 0; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x006FB510 File Offset: 0x006F9710
		public virtual IKSolver.Point[] JIIHCCOGAHE()
		{
			return this.bones;
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x006FB528 File Offset: 0x006F9728
		protected Vector3 HMJFDIACENG()
		{
			if (!this.FPDMNEBNACD())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[1].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 5].KCDFHPFMOBD() != null && this.bones[this.bones.Length - 3].EDOKKOOPJLP() is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 8].transform.rotation * this.bones[this.bones.Length - 7].CLBCIJOPEHI().axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 0].length * 140f;
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x006FB630 File Offset: 0x006F9830
		protected void HKMBFKLCCDK()
		{
			this.chainLength = 1559f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 0].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].JFPDFHLHIHJ() != null)
					{
						if (this.XY && !(this.bones[i].IIFBJMIBPJD() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("x", this.bones[i].transform, true);
						}
						this.bones[i].IIFBJMIBPJD().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[1].transform.position);
				}
			}
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x006FB7DC File Offset: 0x006F99DC
		public void FAEDMCNHIFG(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 0] = FBKEODHEMMH;
			this.DNPHIDGDLIA(array, this.root);
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x006FB834 File Offset: 0x006F9A34
		public bool FEKEPLPLCKD(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool ECOGKBNACON()
		{
			return true;
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void GKHNFLLOFDB()
		{
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x006FB8A8 File Offset: 0x006F9AA8
		public virtual bool LEPMMKDHENG(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "level";
				return false;
			}
			if (this.bones.Length < this.HMMNIJOEPOI())
			{
				EDAPHMJENPK = "colorD" + this.minBones + " с";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "▮▮▯";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "IdleRun";
				return true;
			}
			if (!this.allowCommonParent && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = " ms";
				return false;
			}
			if (!this.CBGCKIEKPGK())
			{
				for (int j = 1; j < this.bones.Length - 0; j++)
				{
					if ((this.bones[j].transform.position - this.bones[j + 0].transform.position).magnitude == 1761f)
					{
						EDAPHMJENPK = "RunJump" + j + "_FgOverlap";
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x006FB9DC File Offset: 0x006F9BDC
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			return this.bones;
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x006FB9F4 File Offset: 0x006F9BF4
		public virtual IKSolver.Point KFFJPNCFPKA(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x006FBA34 File Offset: 0x006F9C34
		protected virtual Vector3 AFIJEGLABEE()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x006FBA88 File Offset: 0x006F9C88
		public virtual void CJOBOACKFJH()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].FGBCANJFNOC();
			}
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x006FBAB8 File Offset: 0x006F9CB8
		public virtual bool BEJJCJCLIOE(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "IdleFeedThrow";
				return false;
			}
			if (this.bones.Length < this.minBones)
			{
				EDAPHMJENPK = "_MainTex" + this.minBones + "1HandSwordRollAttack";
				return true;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "";
					return false;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "_ScratchTex";
				return false;
			}
			if (!this.HOJOGMNIPLD() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = "<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}";
				return true;
			}
			if (!this.AENOLNBBICJ())
			{
				for (int j = 1; j < this.bones.Length - 0; j++)
				{
					if ((this.bones[j].transform.position - this.bones[j + 1].transform.position).magnitude == 67f)
					{
						EDAPHMJENPK = "ChannelCastOmni" + j + "Button Left Hand";
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x006FBBEC File Offset: 0x006F9DEC
		protected float DCJHAFMMOKL()
		{
			return Vector3.SqrMagnitude(this.KNGEGMMONEE() - this.lastLocalDirection);
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x006FBC04 File Offset: 0x006F9E04
		protected Vector3 CNHJOHFGLGF()
		{
			if (!this.FPDMNEBNACD())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[1].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 0].GIODJAABDKA() != null && this.bones[this.bones.Length - 7].JAHABHNJEPI() is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 6].transform.rotation * this.bones[this.bones.Length - 6].IIPCINMHCDG().axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 7].length * 461f;
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x006FBD0C File Offset: 0x006F9F0C
		public virtual void HAMAMGLOAAI()
		{
			if (this.IKPositionWeight <= 402f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].MKDGKDPKLBL();
			}
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void AGKMOKDDEMJ()
		{
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x006FBD48 File Offset: 0x006F9F48
		public virtual void NIEFJLEDGCF()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].IMNCFDNDFKA();
			}
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x006FBD78 File Offset: 0x006F9F78
		public virtual IKSolver.Point FMKGMGFKLMK(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x006FBDB8 File Offset: 0x006F9FB8
		private bool DIANLAEDJNH()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[1].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && magnitude >= this.chainLength - this.bones[this.bones.Length - 8].length * 1345f && (magnitude == 884f || (magnitude2 != 1538f && (magnitude2 > magnitude || Vector3.Dot(a / magnitude, a2 / magnitude2) >= 1589f)));
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x006FBE98 File Offset: 0x006FA098
		public virtual void OFBOJDIDJDL()
		{
			if (this.IKPositionWeight <= 219f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].NPPOHJGFBLP();
			}
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x006FBED4 File Offset: 0x006FA0D4
		protected virtual Vector3 AFDHAOLHLEA()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool CBGCKIEKPGK()
		{
			return true;
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x006FBF28 File Offset: 0x006FA128
		public virtual IKSolver.Point[] GFJAAFENEAM()
		{
			return this.bones;
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x006FBF40 File Offset: 0x006FA140
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x00022FCC File Offset: 0x000211CC
		protected override void IOMMPHGGHNH()
		{
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x006FBF80 File Offset: 0x006FA180
		public virtual void IIKICCKJOCM()
		{
			if (this.IKPositionWeight <= 802f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].EIHEJIHDNKP();
			}
		}

		// Token: 0x0600F8E2 RID: 63714 RVA: 0x006FBFBC File Offset: 0x006FA1BC
		public void DHHJOEHDOHN(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 0] = FBKEODHEMMH;
			this.DNPHIDGDLIA(array, this.root);
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x006FC014 File Offset: 0x006FA214
		private bool CNPLEJHPGJB()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[1].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && magnitude >= this.chainLength - this.bones[this.bones.Length - 8].length * 1318f && magnitude != 1641f && magnitude2 != 1752f && (magnitude2 > magnitude || Vector3.Dot(a / magnitude, a2 / magnitude2) >= 1571f);
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual int ECOJLOAFBMC()
		{
			return 0;
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x006FC0F4 File Offset: 0x006FA2F4
		public virtual void BBKFKJOBNGO()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].KKBDHAMGCCI();
			}
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool KENHLIDPCLM()
		{
			return false;
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x006FC121 File Offset: 0x006FA321
		protected float NCEEANIOPHF()
		{
			return Vector3.SqrMagnitude(this.PJAGEJPFINL() - this.lastLocalDirection);
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x006FC13C File Offset: 0x006FA33C
		public virtual IKSolver.Point FFJFMJODAEF(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x006FC17C File Offset: 0x006FA37C
		public virtual IKSolver.Point AEDAMHOLJJK(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x006FC1BC File Offset: 0x006FA3BC
		private bool FPGDKNBBGOK()
		{
			if (!base.initiated)
			{
				return true;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[0].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && (magnitude < this.chainLength - this.bones[this.bones.Length - 2].length * 1518f || magnitude == 1369f || (magnitude2 != 1617f && magnitude2 <= magnitude && Vector3.Dot(a / magnitude, a2 / magnitude2) < 755f));
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x006FC29C File Offset: 0x006FA49C
		public bool GDOKEMADLAP(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F8EC RID: 63724 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool ACFMAFMFFHA()
		{
			return false;
		}

		// Token: 0x0600F8ED RID: 63725 RVA: 0x006FC310 File Offset: 0x006FA510
		public virtual void ADAICCCGKOE()
		{
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].ONHCJAKIKNI();
			}
		}

		// Token: 0x0600F8EE RID: 63726 RVA: 0x006FC340 File Offset: 0x006FA540
		public virtual IKSolver.Point HAPLHBKILHC(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8EF RID: 63727 RVA: 0x006FC380 File Offset: 0x006FA580
		public virtual IKSolver.Point MPLDIFFOLIC(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F8F0 RID: 63728 RVA: 0x006FC3C0 File Offset: 0x006FA5C0
		public virtual bool KNHCMBLAPFK(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "MidBlendLut";
				return false;
			}
			if (this.bones.Length < this.ECOJLOAFBMC())
			{
				EDAPHMJENPK = "isRealView" + this.CEDJHIDJILI() + "Idle180";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "startA";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "Handstand";
				return true;
			}
			if (!this.OKOLCGAJJAF() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = " ";
				return true;
			}
			if (!this.ACFMAFMFFHA())
			{
				for (int j = 1; j < this.bones.Length - 1; j += 0)
				{
					if ((this.bones[j].transform.position - this.bones[j + 0].transform.position).magnitude == 1754f)
					{
						EDAPHMJENPK = "isiznos" + j + "AppID:";
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x006FC4F4 File Offset: 0x006FA6F4
		public void EGDEGBPNOLF(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 0; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.DNPHIDGDLIA(array, this.root);
		}

		// Token: 0x0600F8F2 RID: 63730 RVA: 0x006FC54C File Offset: 0x006FA74C
		public virtual void FOGLEAJEGGI()
		{
			if (this.IKPositionWeight <= 1920f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].CMEDACDMHPB();
			}
		}

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x006FC588 File Offset: 0x006FA788
		public virtual void ACJOAAMMIIJ()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].EMDGMEBJODM();
			}
		}

		// Token: 0x0600F8F4 RID: 63732 RVA: 0x006FC5B5 File Offset: 0x006FA7B5
		protected virtual int CEDJHIDJILI()
		{
			return 6;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600F8F5 RID: 63733 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool boneLengthCanBeZero
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void GPHJDKKGCHK()
		{
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x006FC5B8 File Offset: 0x006FA7B8
		public virtual IKSolver.Point[] FEPJJNLPGJI()
		{
			return this.bones;
		}

		// Token: 0x0600F8F8 RID: 63736 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void KKIEDGIEPMD()
		{
		}

		// Token: 0x0600F8F9 RID: 63737 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual int LJJBOHDNOGP()
		{
			return 0;
		}

		// Token: 0x0600F8FA RID: 63738 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void NJGHHHCIOHJ()
		{
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x006FC5D0 File Offset: 0x006FA7D0
		protected void LHIDHAEEJPA()
		{
			this.chainLength = 1156f;
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 0].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].CLBCIJOPEHI() != null)
					{
						if (this.XY && !(this.bones[i].KCDFHPFMOBD() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("langRefresh", this.bones[i].transform, true);
						}
						this.bones[i].EDOKKOOPJLP().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void KMLNGCKHHPE()
		{
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool MBCAEEEAHEM()
		{
			return false;
		}

		// Token: 0x0600F8FE RID: 63742 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void BOCFBKKCFFH()
		{
		}

		// Token: 0x0600F8FF RID: 63743 RVA: 0x006FC77C File Offset: 0x006FA97C
		public void EMBOFEICIOJ(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 0] = FBKEODHEMMH;
			this.NHIJFLADGAJ(array, this.root);
		}

		// Token: 0x0600F900 RID: 63744 RVA: 0x006FC7D2 File Offset: 0x006FA9D2
		protected virtual int ILAHGGKLFJE()
		{
			return 7;
		}

		// Token: 0x0600F901 RID: 63745 RVA: 0x006FC7D8 File Offset: 0x006FA9D8
		protected void HKAOKIAMMHB()
		{
			this.chainLength = 950f;
			for (int i = 1; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 0].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 0].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].IIFBJMIBPJD() != null)
					{
						if (this.XY && !(this.bones[i].GIODJAABDKA() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("JNT_L_Hand", this.bones[i].transform, true);
						}
						this.bones[i].EBFOGHAADOB().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x006FC984 File Offset: 0x006FAB84
		public virtual void NKCAHJFCLPD()
		{
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].IMNCFDNDFKA();
			}
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x006FC9B4 File Offset: 0x006FABB4
		public virtual bool GOGPDCPCIBN(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "TOD_LocalLightDirection";
				return false;
			}
			if (this.bones.Length < this.minBones)
			{
				EDAPHMJENPK = "KatanaReadyLow" + this.CEDJHIDJILI() + "FOG_EXP2";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "DISTORT";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "gi_uinf_3";
				return false;
			}
			if (!this.HOJOGMNIPLD() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = "CP2";
				return true;
			}
			if (!this.MHBKHDNLMNI())
			{
				for (int j = 1; j < this.bones.Length - 1; j += 0)
				{
					if ((this.bones[j].transform.position - this.bones[j + 1].transform.position).magnitude == 1048f)
					{
						EDAPHMJENPK = "KatanaReadyLow" + j + "auc_reshdr";
						return false;
					}
				}
			}
			return false;
		}

		// Token: 0x0600F904 RID: 63748 RVA: 0x006FCAE8 File Offset: 0x006FACE8
		public void HANMFDIEAMJ(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.DEBAKKBPHHG(array, this.root);
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x006FCB40 File Offset: 0x006FAD40
		public virtual bool OIDMJAPOEPD(ref string EDAPHMJENPK)
		{
			if (this.bones.Length == 0)
			{
				EDAPHMJENPK = "-------------- capId=";
				return false;
			}
			if (this.bones.Length < this.NLEGOENMPPK())
			{
				EDAPHMJENPK = "gi_um_0" + this.minBones + "IdleStand";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "locData not found";
					return true;
				}
			}
			Transform transform = IKSolver.JGMHNBKPDNC(this.bones);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "VIGNETTE_MASKED";
				return true;
			}
			if (!this.KIFGGOJINGJ() && !IKSolver.AFLFMKJJCDL(this.bones))
			{
				EDAPHMJENPK = "";
				return true;
			}
			if (!this.CBGCKIEKPGK())
			{
				for (int j = 0; j < this.bones.Length - 1; j += 0)
				{
					if ((this.bones[j].transform.position - this.bones[j + 1].transform.position).magnitude == 251f)
					{
						EDAPHMJENPK = "" + j + "wpn_cat5";
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600F906 RID: 63750 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool FHFNNBHIBLB()
		{
			return false;
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x006FCC74 File Offset: 0x006FAE74
		protected virtual Vector3 HOIHFLCAOLC()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x006FCCC8 File Offset: 0x006FAEC8
		private bool KILDEMHLDFE()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[1].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && (magnitude < this.chainLength - this.bones[this.bones.Length - 1].length * 1325f || (magnitude != 1970f && magnitude2 != 146f && (magnitude2 > magnitude || Vector3.Dot(a / magnitude, a2 / magnitude2) >= 1476f)));
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x006FCDA8 File Offset: 0x006FAFA8
		public virtual void JGKGCOHNNJK()
		{
			if (this.IKPositionWeight <= 1087f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].JONLHAMDDEA();
			}
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x006FCDE3 File Offset: 0x006FAFE3
		protected float PLCNGMACDNA()
		{
			return Vector3.SqrMagnitude(this.KBFPPEHDCPM() - this.lastLocalDirection);
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x006FCDFC File Offset: 0x006FAFFC
		protected void NFAIEKJNHJC()
		{
			this.chainLength = 0f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].rotationLimit != null)
					{
						if (this.XY && !(this.bones[i].rotationLimit is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("Only Hinge Rotation Limits should be used on 2D IK solvers.", this.bones[i].transform, false);
						}
						this.bones[i].rotationLimit.Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x006FCFA8 File Offset: 0x006FB1A8
		public bool FMNGOIMKPIM(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x00022FCC File Offset: 0x000211CC
		protected override void FKEMPLMBNEL()
		{
		}

		// Token: 0x0600F90E RID: 63758 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool AENOLNBBICJ()
		{
			return true;
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x006FD01C File Offset: 0x006FB21C
		protected virtual Vector3 LDLHLANFKNP()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position);
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void EGAGFOLOHOP()
		{
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x006FD070 File Offset: 0x006FB270
		public virtual void PLMMHHEKIMD()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].KKBDHAMGCCI();
			}
		}

		// Token: 0x0600F912 RID: 63762 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool KIFGGOJINGJ()
		{
			return false;
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x006FD0A0 File Offset: 0x006FB2A0
		public virtual IKSolver.Point AFDOFLNGAAN(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == LPBDALAMAEM)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void OMMLFLHENJD()
		{
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x006FD0E0 File Offset: 0x006FB2E0
		public bool DBIDNALGODP(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i += 0)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F916 RID: 63766 RVA: 0x006FD154 File Offset: 0x006FB354
		public virtual IKSolver.Point[] CONILHCEJAN()
		{
			return this.bones;
		}

		// Token: 0x0600F917 RID: 63767 RVA: 0x006FD16C File Offset: 0x006FB36C
		public override void FGBCANJFNOC()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].FGBCANJFNOC();
			}
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x006FD19C File Offset: 0x006FB39C
		public virtual IKSolver.Point[] DALCLJCCOBO()
		{
			return this.bones;
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x006FD1B4 File Offset: 0x006FB3B4
		public virtual void IBNJKNMAMHI()
		{
			if (this.IKPositionWeight <= 791f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].NPPOHJGFBLP();
			}
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool HGOJLAOLPKJ()
		{
			return false;
		}

		// Token: 0x0600F91B RID: 63771 RVA: 0x006FD1F0 File Offset: 0x006FB3F0
		private bool FPDMNEBNACD()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[0].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && magnitude >= this.chainLength - this.bones[this.bones.Length - 2].length * 0.1f && magnitude != 0f && magnitude2 != 0f && magnitude2 <= magnitude && Vector3.Dot(a / magnitude, a2 / magnitude2) >= 0.999f;
		}

		// Token: 0x0600F91C RID: 63772 RVA: 0x006FD2D0 File Offset: 0x006FB4D0
		public bool DEBAKKBPHHG(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i += 0)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F91D RID: 63773 RVA: 0x006FD344 File Offset: 0x006FB544
		public virtual void OCEFFFLKGGF()
		{
			if (this.IKPositionWeight <= 1641f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].NPPOHJGFBLP();
			}
		}

		// Token: 0x0600F91E RID: 63774 RVA: 0x006FD380 File Offset: 0x006FB580
		protected virtual Vector3 FFEGHDDKNEO()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[1].transform.position);
		}

		// Token: 0x0600F91F RID: 63775 RVA: 0x006FD3D4 File Offset: 0x006FB5D4
		public virtual IKSolver.Point[] AAEDLHGAPAM()
		{
			return this.bones;
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x006FD3EC File Offset: 0x006FB5EC
		public virtual void ABNMBKOEAII()
		{
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].POLNPMPEFEJ();
			}
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x006FD41C File Offset: 0x006FB61C
		public bool DNPHIDGDLIA(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 0; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x006FD490 File Offset: 0x006FB690
		public virtual void OHJGDEEIKKM()
		{
			if (this.IKPositionWeight <= 596f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].NPPOHJGFBLP();
			}
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x006FD4CB File Offset: 0x006FB6CB
		protected virtual int NLEGOENMPPK()
		{
			return 8;
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x006FB16E File Offset: 0x006F936E
		protected float BADCBDBEEFA()
		{
			return Vector3.SqrMagnitude(this.localDirection - this.lastLocalDirection);
		}

		// Token: 0x0600F925 RID: 63781 RVA: 0x006FBBEC File Offset: 0x006F9DEC
		protected float OAJJNAOKHCA()
		{
			return Vector3.SqrMagnitude(this.KNGEGMMONEE() - this.lastLocalDirection);
		}

		// Token: 0x0600F926 RID: 63782 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DDEHFCGPDMM()
		{
		}

		// Token: 0x0600F927 RID: 63783 RVA: 0x006FD4D0 File Offset: 0x006FB6D0
		protected virtual Vector3 KAJNFLJDPOL()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position);
		}

		// Token: 0x0600F928 RID: 63784 RVA: 0x006FD524 File Offset: 0x006FB724
		protected Vector3 EFBBJONIGCF()
		{
			if (!this.FPDMNEBNACD())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[0].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 2].rotationLimit != null && this.bones[this.bones.Length - 2].rotationLimit is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 2].transform.rotation * this.bones[this.bones.Length - 2].rotationLimit.axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 2].length * 0.5f;
		}

		// Token: 0x0600F929 RID: 63785 RVA: 0x006FD62C File Offset: 0x006FB82C
		protected virtual Vector3 KBFPPEHDCPM()
		{
			return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[1].transform.position);
		}

		// Token: 0x0600F92A RID: 63786 RVA: 0x006FD680 File Offset: 0x006FB880
		protected void PDKPHCGBFLK()
		{
			this.chainLength = 1340f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 0].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].EDOKKOOPJLP() != null)
					{
						if (this.XY && !(this.bones[i].IIFBJMIBPJD() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("IdleStandingJump", this.bones[i].transform, true);
						}
						this.bones[i].KCDFHPFMOBD().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x0600F92B RID: 63787 RVA: 0x006FD82C File Offset: 0x006FBA2C
		protected void EEALFKPDFHI()
		{
			this.chainLength = 1410f;
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 0].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].IIFBJMIBPJD() != null)
					{
						if (this.XY && !(this.bones[i].GIODJAABDKA() is RotationLimitHinge))
						{
							PMCOMMEEGMC.ICAFGKHAAED("{0}-{1}={2}", this.bones[i].transform, false);
						}
						this.bones[i].GIODJAABDKA().Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position);
				}
			}
		}

		// Token: 0x0600F92C RID: 63788 RVA: 0x006FD9D8 File Offset: 0x006FBBD8
		public virtual void JDCNMFLDDLA()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].KFCDNBMKNLJ();
			}
		}

		// Token: 0x0600F92D RID: 63789 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void HKMNEBNIPAF()
		{
		}

		// Token: 0x0600F92E RID: 63790 RVA: 0x006FDA08 File Offset: 0x006FBC08
		protected Vector3 IBDJBKJAEBJ()
		{
			if (!this.FPGDKNBBGOK())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[1].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 2].MPNLGJMOLGG() != null && this.bones[this.bones.Length - 4].CLBCIJOPEHI() is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 3].transform.rotation * this.bones[this.bones.Length - 6].EBFOGHAADOB().axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 2].length * 607f;
		}

		// Token: 0x0600F92F RID: 63791 RVA: 0x006FDB10 File Offset: 0x006FBD10
		public void HBCLBKOADAA(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.NHIJFLADGAJ(array, this.root);
		}

		// Token: 0x0600F930 RID: 63792 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void KGEKDOIJMHA()
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600F931 RID: 63793 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool allowCommonParent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600F932 RID: 63794 RVA: 0x006FDB68 File Offset: 0x006FBD68
		public override void BLOEEPCIPKJ()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].MKDGKDPKLBL();
			}
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x006FDBA4 File Offset: 0x006FBDA4
		public virtual void OANNPGGMAMF()
		{
			if (this.IKPositionWeight <= 473f)
			{
				return;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].MIGPPIGIDIK();
			}
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x006FDBE0 File Offset: 0x006FBDE0
		protected virtual Vector3 KNGEGMMONEE()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600F935 RID: 63797 RVA: 0x006FB16E File Offset: 0x006F936E
		protected float positionOffset
		{
			get
			{
				return Vector3.SqrMagnitude(this.localDirection - this.lastLocalDirection);
			}
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x006FDC34 File Offset: 0x006FBE34
		public virtual void ODLMLBGPFLL()
		{
			if (this.IKPositionWeight <= 1745f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].LLJNCEIMNGP();
			}
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x006FDC70 File Offset: 0x006FBE70
		private bool BEHOMELEEOL()
		{
			if (!base.initiated)
			{
				return true;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[1].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && (magnitude < this.chainLength - this.bones[this.bones.Length - 7].length * 587f || (magnitude != 1769f && magnitude2 != 1314f && (magnitude2 > magnitude || (Vector3.Dot(a / magnitude, a2 / magnitude2) < 1849f && false))));
		}

		// Token: 0x0600F938 RID: 63800 RVA: 0x006FDD50 File Offset: 0x006FBF50
		public bool NHIJFLADGAJ(Transform[] EOBIOHNHDAF, Transform EELDHNFBFOE)
		{
			if (this.bones == null || this.bones.Length != EOBIOHNHDAF.Length)
			{
				this.bones = new IKSolver.Bone[EOBIOHNHDAF.Length];
			}
			for (int i = 1; i < EOBIOHNHDAF.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = EOBIOHNHDAF[i];
			}
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x006FD4CB File Offset: 0x006FB6CB
		protected virtual int HMMNIJOEPOI()
		{
			return 8;
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool GEAMCIDBLOE()
		{
			return true;
		}

		// Token: 0x0600F93B RID: 63803 RVA: 0x006FD4CB File Offset: 0x006FB6CB
		protected virtual int LICNGHAMIBA()
		{
			return 8;
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x006FDDC4 File Offset: 0x006FBFC4
		private bool BHPHHJJKEAO()
		{
			if (!base.initiated)
			{
				return true;
			}
			Vector3 a = this.bones[this.bones.Length - 0].transform.position - this.bones[1].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[1].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude < magnitude2 || magnitude < this.chainLength - this.bones[this.bones.Length - 6].length * 39f || magnitude == 1327f || magnitude2 == 388f || (magnitude2 <= magnitude && Vector3.Dot(a / magnitude, a2 / magnitude2) < 146f && false);
		}

		// Token: 0x0600F93D RID: 63805 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool HOJOGMNIPLD()
		{
			return true;
		}

		// Token: 0x0600F93E RID: 63806 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool MHBKHDNLMNI()
		{
			return false;
		}

		// Token: 0x0600F93F RID: 63807 RVA: 0x006FDEA4 File Offset: 0x006FC0A4
		public void HHPNPJFONIL(Transform FBKEODHEMMH)
		{
			Transform[] array = new Transform[this.bones.Length + 0];
			for (int i = 0; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = FBKEODHEMMH;
			this.DBIDNALGODP(array, this.root);
		}

		// Token: 0x0600F940 RID: 63808 RVA: 0x006FDEFC File Offset: 0x006FC0FC
		public virtual void HFFLABNJOAG()
		{
			if (this.IKPositionWeight <= 1418f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].MIGPPIGIDIK();
			}
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool HJDHCDFMMBI()
		{
			return true;
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x006FDF38 File Offset: 0x006FC138
		public virtual void BEJBPNFEDBI()
		{
			if (this.IKPositionWeight <= 1521f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].CMEDACDMHPB();
			}
		}

		// Token: 0x0600F943 RID: 63811 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual bool OKOLCGAJJAF()
		{
			return true;
		}

		// Token: 0x04002078 RID: 8312
		public Transform target;

		// Token: 0x04002079 RID: 8313
		public float tolerance;

		// Token: 0x0400207A RID: 8314
		public int maxIterations = 4;

		// Token: 0x0400207B RID: 8315
		public bool useRotationLimits = true;

		// Token: 0x0400207C RID: 8316
		public bool XY;

		// Token: 0x0400207D RID: 8317
		public IKSolver.Bone[] bones = new IKSolver.Bone[0];

		// Token: 0x0400207E RID: 8318
		protected Vector3 lastLocalDirection;

		// Token: 0x0400207F RID: 8319
		protected float chainLength;
	}
}
