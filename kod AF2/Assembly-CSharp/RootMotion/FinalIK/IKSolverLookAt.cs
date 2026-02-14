using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200047C RID: 1148
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		// Token: 0x0600F9E1 RID: 63969 RVA: 0x00705DB8 File Offset: 0x00703FB8
		public override void FGBCANJFNOC()
		{
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].FGBCANJFNOC();
			}
			for (int j = 0; j < this.eyes.Length; j++)
			{
				this.eyes[j].FGBCANJFNOC();
			}
			if (this.head != null && this.head.transform != null)
			{
				this.head.FGBCANJFNOC();
			}
		}

		// Token: 0x0600F9E2 RID: 63970 RVA: 0x00705E2C File Offset: 0x0070402C
		private Vector3[] DDMLINCPGCN(ref Vector3[] NCFEBLDFBIF, Vector3 CJCJCGNNMOM, Vector3 MMBBDEDLIPB, int CKAJJHFIFBL, float NIEJCMKDICH)
		{
			if (NIEJCMKDICH >= 1f || this.IKPositionWeight <= 0f)
			{
				for (int i = 0; i < NCFEBLDFBIF.Length; i++)
				{
					NCFEBLDFBIF[i] = CJCJCGNNMOM;
				}
				return NCFEBLDFBIF;
			}
			float num = Vector3.Angle(CJCJCGNNMOM, MMBBDEDLIPB);
			float num2 = 1f - num / 180f;
			float num3 = (NIEJCMKDICH > 0f) ? Mathf.Clamp(1f - (NIEJCMKDICH - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (NIEJCMKDICH > 0f) ? Mathf.Clamp(num2 / NIEJCMKDICH, 0f, 1f) : 1f;
			for (int j = 0; j < this.clampSmoothing; j++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			if (NCFEBLDFBIF.Length == 1)
			{
				NCFEBLDFBIF[0] = Vector3.Slerp(CJCJCGNNMOM, MMBBDEDLIPB, num4 * num3);
			}
			else
			{
				float num5 = 1f / (float)(NCFEBLDFBIF.Length - 1);
				for (int k = 0; k < NCFEBLDFBIF.Length; k++)
				{
					NCFEBLDFBIF[k] = Vector3.Slerp(CJCJCGNNMOM, MMBBDEDLIPB, this.spineWeightCurve.Evaluate(num5 * (float)k) * num4 * num3);
				}
			}
			return NCFEBLDFBIF;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600F9E3 RID: 63971 RVA: 0x00705F67 File Offset: 0x00704167
		private bool headIsEmpty
		{
			get
			{
				return this.head.transform == null;
			}
		}

		// Token: 0x0600F9E4 RID: 63972 RVA: 0x00705F7C File Offset: 0x0070417C
		public void BLJJHPJKEPC(float NKHBAJKMAGD, float GNOKOIOCELA = 0f, float PKNPPGDMNAE = 1f, float AEIFJHNNLEK = 0.5f, float NAPPHEPPHKD = 0.5f, float LOJLNPEIGLH = 0.5f, float MHABNMGDIPN = 0.3f)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 818f, 90f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 1611f, 640f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 1645f, 1994f);
			this.eyesWeight = Mathf.Clamp(AEIFJHNNLEK, 342f, 144f);
			this.clampWeight = Mathf.Clamp(NAPPHEPPHKD, 1862f, 270f);
			this.clampWeightHead = Mathf.Clamp(LOJLNPEIGLH, 1216f, 727f);
			this.clampWeightEyes = Mathf.Clamp(MHABNMGDIPN, 198f, 720f);
		}

		// Token: 0x0600F9E5 RID: 63973 RVA: 0x00706028 File Offset: 0x00704228
		private void BGEOPGIJKOJ()
		{
			if (this.headWeight <= 0f)
			{
				return;
			}
			if (this.headIsEmpty)
			{
				return;
			}
			Vector3 vector = (this.spine.Length != 0 && this.spine[this.spine.Length - 1].transform != null) ? this.spine[this.spine.Length - 1].forward : this.head.forward;
			Vector3 normalized = Vector3.Lerp(vector, (this.IKPosition - this.head.transform.position).normalized, this.headWeight * this.IKPositionWeight).normalized;
			this.DDMLINCPGCN(ref this.headForwards, vector, normalized, 1, this.clampWeightHead);
			this.head.COEKPBMOFHO(this.headForwards[0], this.headWeight * this.IKPositionWeight);
		}

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x00706110 File Offset: 0x00704310
		private bool MMDEJHHALJM()
		{
			return this.eyes.Length == 1;
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x0070611C File Offset: 0x0070431C
		private bool IDCJDOOJPIP()
		{
			return this.spine.Length == 1;
		}

		// Token: 0x0600F9E8 RID: 63976 RVA: 0x00706128 File Offset: 0x00704328
		public void ILMHGKICIFG(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 1204f, 1193f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 891f, 1697f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 727f, 838f);
		}

		// Token: 0x0600F9E9 RID: 63977 RVA: 0x00705F67 File Offset: 0x00704167
		private bool CODEBMFJFFL()
		{
			return this.head.transform == null;
		}

		// Token: 0x0600F9EA RID: 63978 RVA: 0x00706177 File Offset: 0x00704377
		public void EPNPCKODAHD(float NKHBAJKMAGD, float GNOKOIOCELA)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 1247f, 1226f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 1749f, 1882f);
		}

		// Token: 0x0600F9EB RID: 63979 RVA: 0x007061A5 File Offset: 0x007043A5
		private bool KDLGCJHELLP()
		{
			return this.head == null && false;
		}

		// Token: 0x0600F9EC RID: 63980 RVA: 0x007061B4 File Offset: 0x007043B4
		public void OFABEEINNMP(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 0f, 1f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 0f, 1f);
		}

		// Token: 0x0600F9ED RID: 63981 RVA: 0x00706204 File Offset: 0x00704404
		public virtual IKSolver.Point[] FIJIEOOKGML()
		{
			IKSolver.Point[] array = new IKSolver.Point[this.spine.Length + this.eyes.Length + ((this.head.transform != null) ? 0 : 1)];
			for (int i = 0; i < this.spine.Length; i += 0)
			{
				array[i] = this.spine[i];
			}
			int num = 1;
			for (int j = this.spine.Length; j < array.Length; j++)
			{
				array[j] = this.eyes[num];
				num++;
			}
			if (this.head.transform != null)
			{
				array[array.Length - 1] = this.head;
			}
			return array;
		}

		// Token: 0x0600F9EE RID: 63982 RVA: 0x007062A8 File Offset: 0x007044A8
		public void OFABEEINNMP(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE, float AEIFJHNNLEK, float NAPPHEPPHKD)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 0f, 1f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(AEIFJHNNLEK, 0f, 1f);
			this.clampWeight = Mathf.Clamp(NAPPHEPPHKD, 0f, 1f);
			this.clampWeightHead = this.clampWeight;
			this.clampWeightEyes = this.clampWeight;
		}

		// Token: 0x0600F9EF RID: 63983 RVA: 0x0070633D File Offset: 0x0070453D
		private bool OEPFDBJPFLL()
		{
			return this.head != null;
		}

		// Token: 0x0600F9F0 RID: 63984 RVA: 0x0070611C File Offset: 0x0070431C
		private bool GIKKNIBEGIH()
		{
			return this.spine.Length == 1;
		}

		// Token: 0x0600F9F1 RID: 63985 RVA: 0x0070634C File Offset: 0x0070454C
		private void OMPAGIOOOLN()
		{
			if (this.eyesWeight <= 0f)
			{
				return;
			}
			if (this.eyesIsEmpty)
			{
				return;
			}
			for (int i = 0; i < this.eyes.Length; i++)
			{
				Vector3 cjcjcgnnmom = (this.head.transform != null) ? this.head.forward : this.eyes[i].forward;
				this.DDMLINCPGCN(ref this.eyeForward, cjcjcgnnmom, (this.IKPosition - this.eyes[i].transform.position).normalized, 1, this.clampWeightEyes);
				this.eyes[i].COEKPBMOFHO(this.eyeForward[0], this.eyesWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9F2 RID: 63986 RVA: 0x00706418 File Offset: 0x00704618
		private void GPHIAGAGNMP()
		{
			if (this.bodyWeight <= 0f)
			{
				return;
			}
			if (this.spineIsEmpty)
			{
				return;
			}
			Vector3 normalized = (this.IKPosition - this.spine[this.spine.Length - 1].transform.position).normalized;
			this.DDMLINCPGCN(ref this.spineForwards, this.spine[0].forward, normalized, this.spine.Length, this.clampWeight);
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].COEKPBMOFHO(this.spineForwards[i], this.bodyWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600F9F3 RID: 63987 RVA: 0x007064CD File Offset: 0x007046CD
		private bool eyesIsEmpty
		{
			get
			{
				return this.eyes.Length == 0;
			}
		}

		// Token: 0x0600F9F4 RID: 63988 RVA: 0x006DB7DB File Offset: 0x006D99DB
		public void OFABEEINNMP(float NKHBAJKMAGD)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600F9F5 RID: 63989 RVA: 0x0070633D File Offset: 0x0070453D
		private bool headIsValid
		{
			get
			{
				return this.head != null;
			}
		}

		// Token: 0x0600F9F6 RID: 63990 RVA: 0x00706110 File Offset: 0x00704310
		private bool FNCNPPDKNLD()
		{
			return this.eyes.Length == 1;
		}

		// Token: 0x0600F9F7 RID: 63991 RVA: 0x007064DC File Offset: 0x007046DC
		public void OFABEEINNMP(float NKHBAJKMAGD, float GNOKOIOCELA = 0f, float PKNPPGDMNAE = 1f, float AEIFJHNNLEK = 0.5f, float NAPPHEPPHKD = 0.5f, float LOJLNPEIGLH = 0.5f, float MHABNMGDIPN = 0.3f)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 0f, 1f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(AEIFJHNNLEK, 0f, 1f);
			this.clampWeight = Mathf.Clamp(NAPPHEPPHKD, 0f, 1f);
			this.clampWeightHead = Mathf.Clamp(LOJLNPEIGLH, 0f, 1f);
			this.clampWeightEyes = Mathf.Clamp(MHABNMGDIPN, 0f, 1f);
		}

		// Token: 0x0600F9F8 RID: 63992 RVA: 0x00706588 File Offset: 0x00704788
		public void OFABEEINNMP(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE, float AEIFJHNNLEK)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 0f, 1f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(AEIFJHNNLEK, 0f, 1f);
		}

		// Token: 0x0600F9F9 RID: 63993 RVA: 0x007065F0 File Offset: 0x007047F0
		public virtual IKSolver.Point MHIDLBALNLJ(Transform LPBDALAMAEM)
		{
			IKSolverLookAt.LookAtBone[] array = this.spine;
			for (int i = 1; i < array.Length; i += 0)
			{
				IKSolverLookAt.LookAtBone lookAtBone = array[i];
				if (lookAtBone.transform == LPBDALAMAEM)
				{
					return lookAtBone;
				}
			}
			array = this.eyes;
			for (int i = 1; i < array.Length; i++)
			{
				IKSolverLookAt.LookAtBone lookAtBone2 = array[i];
				if (lookAtBone2.transform == LPBDALAMAEM)
				{
					return lookAtBone2;
				}
			}
			if (this.head.transform == LPBDALAMAEM)
			{
				return this.head;
			}
			return null;
		}

		// Token: 0x0600F9FA RID: 63994 RVA: 0x0070666C File Offset: 0x0070486C
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			IKSolver.Point[] array = new IKSolver.Point[this.spine.Length + this.eyes.Length + ((this.head.transform != null) ? 1 : 0)];
			for (int i = 0; i < this.spine.Length; i++)
			{
				array[i] = this.spine[i];
			}
			int num = 0;
			for (int j = this.spine.Length; j < array.Length; j++)
			{
				array[j] = this.eyes[num];
				num++;
			}
			if (this.head.transform != null)
			{
				array[array.Length - 1] = this.head;
			}
			return array;
		}

		// Token: 0x0600F9FB RID: 63995 RVA: 0x00706710 File Offset: 0x00704910
		private void IIJKFGAOGOB()
		{
			if (this.eyesWeight <= 48f)
			{
				return;
			}
			if (this.DNAPCBFJBAN())
			{
				return;
			}
			for (int i = 0; i < this.eyes.Length; i += 0)
			{
				Vector3 cjcjcgnnmom = (this.head.transform != null) ? this.head.GEHPMLLBKFG() : this.eyes[i].JDINKOCDMME();
				this.DDMLINCPGCN(ref this.eyeForward, cjcjcgnnmom, (this.IKPosition - this.eyes[i].transform.position).normalized, 0, this.clampWeightEyes);
				this.eyes[i].EFBNIHGKEEF(this.eyeForward[1], this.eyesWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9FC RID: 63996 RVA: 0x007067DB File Offset: 0x007049DB
		public bool NFCENJBLLCL(Transform[] BDEHNFGEABB, Transform HNAMPOJELPA, Transform[] EIJOHIGIEGO, Transform EELDHNFBFOE)
		{
			this.DLJHEBPABFF(BDEHNFGEABB, ref this.spine);
			this.head = new IKSolverLookAt.LookAtBone(HNAMPOJELPA);
			this.DLJHEBPABFF(EIJOHIGIEGO, ref this.eyes);
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F9FD RID: 63997 RVA: 0x007067DB File Offset: 0x007049DB
		public bool DNPHIDGDLIA(Transform[] BDEHNFGEABB, Transform HNAMPOJELPA, Transform[] EIJOHIGIEGO, Transform EELDHNFBFOE)
		{
			this.DLJHEBPABFF(BDEHNFGEABB, ref this.spine);
			this.head = new IKSolverLookAt.LookAtBone(HNAMPOJELPA);
			this.DLJHEBPABFF(EIJOHIGIEGO, ref this.eyes);
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600F9FE RID: 63998 RVA: 0x00706811 File Offset: 0x00704A11
		public void NGBGKONLPJF(float NKHBAJKMAGD, float GNOKOIOCELA)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 924f, 476f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 720f, 124f);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600F9FF RID: 63999 RVA: 0x00706840 File Offset: 0x00704A40
		private bool eyesIsValid
		{
			get
			{
				if (this.eyes == null)
				{
					return false;
				}
				if (this.eyes.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < this.eyes.Length; i++)
				{
					if (this.eyes[i] == null || this.eyes[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x0600FA00 RID: 64000 RVA: 0x00706898 File Offset: 0x00704A98
		public override void BLOEEPCIPKJ()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].MKDGKDPKLBL();
			}
			for (int j = 0; j < this.eyes.Length; j++)
			{
				this.eyes[j].MKDGKDPKLBL();
			}
			if (this.head != null && this.head.transform != null)
			{
				this.head.MKDGKDPKLBL();
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600FA01 RID: 64001 RVA: 0x0070691C File Offset: 0x00704B1C
		private bool spineIsValid
		{
			get
			{
				if (this.spine == null)
				{
					return false;
				}
				if (this.spine.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < this.spine.Length; i++)
				{
					if (this.spine[i] == null || this.spine[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x0600FA02 RID: 64002 RVA: 0x00706974 File Offset: 0x00704B74
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			foreach (IKSolverLookAt.LookAtBone lookAtBone in this.spine)
			{
				if (lookAtBone.transform == LPBDALAMAEM)
				{
					return lookAtBone;
				}
			}
			foreach (IKSolverLookAt.LookAtBone lookAtBone2 in this.eyes)
			{
				if (lookAtBone2.transform == LPBDALAMAEM)
				{
					return lookAtBone2;
				}
			}
			if (this.head.transform == LPBDALAMAEM)
			{
				return this.head;
			}
			return null;
		}

		// Token: 0x0600FA03 RID: 64003 RVA: 0x007069EE File Offset: 0x00704BEE
		public void OFABEEINNMP(float NKHBAJKMAGD, float GNOKOIOCELA)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 0f, 1f);
		}

		// Token: 0x0600FA04 RID: 64004 RVA: 0x0070633D File Offset: 0x0070453D
		private bool NIGJBAHNJID()
		{
			return this.head != null;
		}

		// Token: 0x0600FA05 RID: 64005 RVA: 0x007064CD File Offset: 0x007046CD
		private bool DNAPCBFJBAN()
		{
			return this.eyes.Length == 0;
		}

		// Token: 0x0600FA06 RID: 64006 RVA: 0x00706A1C File Offset: 0x00704C1C
		protected virtual void LBDLIOBMENO()
		{
			if (this.IKPositionWeight <= 1669f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1186f, 386f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			this.GPHIAGAGNMP();
			this.BGEOPGIJKOJ();
			this.OMPAGIOOOLN();
		}

		// Token: 0x0600FA07 RID: 64007 RVA: 0x00706A84 File Offset: 0x00704C84
		protected override void FKEMPLMBNEL()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				if (this.spine.Length != 0)
				{
					this.IKPosition = this.spine[this.spine.Length - 1].transform.position + this.root.forward * 3f;
				}
				else if (this.head.transform != null)
				{
					this.IKPosition = this.head.transform.position + this.root.forward * 3f;
				}
				else if (this.eyes.Length != 0 && this.eyes[0].transform != null)
				{
					this.IKPosition = this.eyes[0].transform.position + this.root.forward * 3f;
				}
			}
			IKSolverLookAt.LookAtBone[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].BHALELINNDJ(this.root);
			}
			if (this.head != null)
			{
				this.head.BHALELINNDJ(this.root);
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].BHALELINNDJ(this.root);
			}
			if (this.spineForwards == null || this.spineForwards.Length != this.spine.Length)
			{
				this.spineForwards = new Vector3[this.spine.Length];
			}
			if (this.headForwards == null)
			{
				this.headForwards = new Vector3[1];
			}
			if (this.eyeForward == null)
			{
				this.eyeForward = new Vector3[1];
			}
		}

		// Token: 0x0600FA08 RID: 64008 RVA: 0x0070611C File Offset: 0x0070431C
		private bool DMKDNDPLODG()
		{
			return this.spine.Length == 1;
		}

		// Token: 0x0600FA09 RID: 64009 RVA: 0x00706C38 File Offset: 0x00704E38
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (!this.spineIsValid)
			{
				EDAPHMJENPK = "IKSolverLookAt spine setup is invalid. Can't initiate solver.";
				return false;
			}
			if (!this.headIsValid)
			{
				EDAPHMJENPK = "IKSolverLookAt head transform is null. Can't initiate solver.";
				return false;
			}
			if (!this.eyesIsValid)
			{
				EDAPHMJENPK = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			if (this.spineIsEmpty && this.headIsEmpty && this.eyesIsEmpty)
			{
				EDAPHMJENPK = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			IKSolver.Bone[] ckajjhfifbl = this.spine;
			Transform transform = IKSolver.JGMHNBKPDNC(ckajjhfifbl);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			ckajjhfifbl = this.eyes;
			Transform transform2 = IKSolver.JGMHNBKPDNC(ckajjhfifbl);
			if (transform2 != null)
			{
				EDAPHMJENPK = transform2.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			return true;
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600FA0A RID: 64010 RVA: 0x00706CF0 File Offset: 0x00704EF0
		private bool spineIsEmpty
		{
			get
			{
				return this.spine.Length == 0;
			}
		}

		// Token: 0x0600FA0C RID: 64012 RVA: 0x00706DDC File Offset: 0x00704FDC
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			this.GPHIAGAGNMP();
			this.BGEOPGIJKOJ();
			this.OMPAGIOOOLN();
		}

		// Token: 0x0600FA0D RID: 64013 RVA: 0x00706E44 File Offset: 0x00705044
		public void PODGLFJFOOF(float NKHBAJKMAGD, float GNOKOIOCELA, float PKNPPGDMNAE)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 496f, 1170f);
			this.bodyWeight = Mathf.Clamp(GNOKOIOCELA, 1199f, 764f);
			this.headWeight = Mathf.Clamp(PKNPPGDMNAE, 250f, 275f);
		}

		// Token: 0x0600FA0E RID: 64014 RVA: 0x00706E94 File Offset: 0x00705094
		private void DLJHEBPABFF(Transform[] INFEGEBCAAF, ref IKSolverLookAt.LookAtBone[] CKAJJHFIFBL)
		{
			if (INFEGEBCAAF == null)
			{
				CKAJJHFIFBL = new IKSolverLookAt.LookAtBone[0];
				return;
			}
			if (CKAJJHFIFBL.Length != INFEGEBCAAF.Length)
			{
				CKAJJHFIFBL = new IKSolverLookAt.LookAtBone[INFEGEBCAAF.Length];
			}
			for (int i = 0; i < INFEGEBCAAF.Length; i++)
			{
				if (CKAJJHFIFBL[i] == null)
				{
					CKAJJHFIFBL[i] = new IKSolverLookAt.LookAtBone(INFEGEBCAAF[i]);
				}
				else
				{
					CKAJJHFIFBL[i].transform = INFEGEBCAAF[i];
				}
			}
		}

		// Token: 0x04002099 RID: 8345
		public Transform target;

		// Token: 0x0400209A RID: 8346
		public IKSolverLookAt.LookAtBone[] spine = new IKSolverLookAt.LookAtBone[0];

		// Token: 0x0400209B RID: 8347
		public IKSolverLookAt.LookAtBone head = new IKSolverLookAt.LookAtBone();

		// Token: 0x0400209C RID: 8348
		public IKSolverLookAt.LookAtBone[] eyes = new IKSolverLookAt.LookAtBone[0];

		// Token: 0x0400209D RID: 8349
		[Range(0f, 1f)]
		public float bodyWeight = 0.5f;

		// Token: 0x0400209E RID: 8350
		[Range(0f, 1f)]
		public float headWeight = 0.5f;

		// Token: 0x0400209F RID: 8351
		[Range(0f, 1f)]
		public float eyesWeight = 1f;

		// Token: 0x040020A0 RID: 8352
		[Range(0f, 1f)]
		public float clampWeight = 0.5f;

		// Token: 0x040020A1 RID: 8353
		[Range(0f, 1f)]
		public float clampWeightHead = 0.5f;

		// Token: 0x040020A2 RID: 8354
		[Range(0f, 1f)]
		public float clampWeightEyes = 0.5f;

		// Token: 0x040020A3 RID: 8355
		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		// Token: 0x040020A4 RID: 8356
		public AnimationCurve spineWeightCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0.3f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x040020A5 RID: 8357
		private Vector3[] spineForwards = new Vector3[0];

		// Token: 0x040020A6 RID: 8358
		private Vector3[] headForwards = new Vector3[1];

		// Token: 0x040020A7 RID: 8359
		private Vector3[] eyeForward = new Vector3[1];

		// Token: 0x0200047D RID: 1149
		[Serializable]
		public class LookAtBone : IKSolver.Bone
		{
			// Token: 0x0600FA0F RID: 64015 RVA: 0x00706EEE File Offset: 0x007050EE
			public void EKAEHDFJMHL(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA10 RID: 64016 RVA: 0x00706F20 File Offset: 0x00705120
			public void GHOOJABDGPA(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.LLPELNBBDLO(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA11 RID: 64017 RVA: 0x00706F60 File Offset: 0x00705160
			public void NODIMMDDGEO(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.MPHLBEFLIHC(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA12 RID: 64018 RVA: 0x00706EEE File Offset: 0x007050EE
			public void LLPMNHOBPAJ(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA13 RID: 64019 RVA: 0x00706FA0 File Offset: 0x007051A0
			public void NGFLHGCNNFI(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.GCMDAEAPKMA(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA14 RID: 64020 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 PKAEAOFLEGN()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA15 RID: 64021 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 PDJLHGLKEHJ()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA16 RID: 64022 RVA: 0x00706EEE File Offset: 0x007050EE
			public void KLNJKEEICKH(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA17 RID: 64023 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 AODLJPBAPHA()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA18 RID: 64024 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 LGDECCMNCMO()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA19 RID: 64025 RVA: 0x00706FF8 File Offset: 0x007051F8
			public void COEKPBMOFHO(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.forward, NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA1A RID: 64026 RVA: 0x00706EEE File Offset: 0x007050EE
			public void ELLKGAPMLJE(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA1B RID: 64027 RVA: 0x00706EEE File Offset: 0x007050EE
			public void BHALELINNDJ(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA1C RID: 64028 RVA: 0x00706EEE File Offset: 0x007050EE
			public void PLDPNLLOANG(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA1D RID: 64029 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 BKHEOAJPNNN()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA1E RID: 64030 RVA: 0x00707037 File Offset: 0x00705237
			public LookAtBone(Transform LPBDALAMAEM)
			{
				this.transform = LPBDALAMAEM;
			}

			// Token: 0x0600FA1F RID: 64031 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 OBGIOLEEIKK()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA20 RID: 64032 RVA: 0x00706EEE File Offset: 0x007050EE
			public void LIAONJMLNMA(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA21 RID: 64033 RVA: 0x00707048 File Offset: 0x00705248
			public void NCIMCKHFANP(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.FPANCFICFIC(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA22 RID: 64034 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 HHBMMNFIPBE()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA23 RID: 64035 RVA: 0x00707088 File Offset: 0x00705288
			public void EKJMBHHHBIM(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.ELECKLAAPHG(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA24 RID: 64036 RVA: 0x007070C8 File Offset: 0x007052C8
			public void CIIPOJOMENE(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.HHBMMNFIPBE(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA25 RID: 64037 RVA: 0x00707108 File Offset: 0x00705308
			public void MICNNHFPDCI(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.PPAIIBGHIGP(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x0600FA26 RID: 64038 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 forward
			{
				get
				{
					return this.transform.rotation * this.axis;
				}
			}

			// Token: 0x0600FA27 RID: 64039 RVA: 0x00706EEE File Offset: 0x007050EE
			public void OJKNMJEMKDP(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA28 RID: 64040 RVA: 0x00707148 File Offset: 0x00705348
			public void IDGJPFCGLEL(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.JKGDABJCAJM(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA29 RID: 64041 RVA: 0x00707188 File Offset: 0x00705388
			public void AEFAJKFBKIP(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.ELECKLAAPHG(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA2A RID: 64042 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 PPAIIBGHIGP()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA2B RID: 64043 RVA: 0x007071C8 File Offset: 0x007053C8
			public void HJONIHAGDNE(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.EDMALOJFDKE(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA2C RID: 64044 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 MHCDJACIIOE()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA2D RID: 64045 RVA: 0x00707208 File Offset: 0x00705408
			public void GFMLOMNFLPJ(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.KCNMOCHPINK(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA2E RID: 64046 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 JDINKOCDMME()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA2F RID: 64047 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 ELECKLAAPHG()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA30 RID: 64048 RVA: 0x00707248 File Offset: 0x00705448
			public void PDFBOBKHHBD(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.ECMNLKEDDJB(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA31 RID: 64049 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 NHPBNMOHPJG()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA32 RID: 64050 RVA: 0x00706EEE File Offset: 0x007050EE
			public void NPCHHADBLMC(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA33 RID: 64051 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 JKGDABJCAJM()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA34 RID: 64052 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 KCNMOCHPINK()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA35 RID: 64053 RVA: 0x00707288 File Offset: 0x00705488
			public void EBAPHHAIKFE(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.JDINKOCDMME(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA36 RID: 64054 RVA: 0x007072C8 File Offset: 0x007054C8
			public void JAFCKNBDHOG(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.OBGIOLEEIKK(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA37 RID: 64055 RVA: 0x00706EEE File Offset: 0x007050EE
			public void DAAHJFNPBIF(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA38 RID: 64056 RVA: 0x00706EEE File Offset: 0x007050EE
			public void FJFJNFHKMHJ(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA39 RID: 64057 RVA: 0x00706EEE File Offset: 0x007050EE
			public void FJMNBKHFLJO(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA3A RID: 64058 RVA: 0x00707308 File Offset: 0x00705508
			public void BLEAFMEDKEJ(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.KCNMOCHPINK(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA3B RID: 64059 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 GEHPMLLBKFG()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA3C RID: 64060 RVA: 0x00707348 File Offset: 0x00705548
			public void EHJOMNPMCKL(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.PDJLHGLKEHJ(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA3D RID: 64061 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 EIJFHCGGJEM()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA3E RID: 64062 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 MPHLBEFLIHC()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA3F RID: 64063 RVA: 0x00706EEE File Offset: 0x007050EE
			public void KKDIDIBHBEB(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA40 RID: 64064 RVA: 0x00706EEE File Offset: 0x007050EE
			public void COLNPLLHKPE(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA41 RID: 64065 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 FPANCFICFIC()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA42 RID: 64066 RVA: 0x00707388 File Offset: 0x00705588
			public void BFMGHMNBOLF(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.MHCDJACIIOE(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA43 RID: 64067 RVA: 0x007073C8 File Offset: 0x007055C8
			public void MJKBJHFEFHA(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.KCNMOCHPINK(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA44 RID: 64068 RVA: 0x00706EEE File Offset: 0x007050EE
			public void KGCOBEJCLHM(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA45 RID: 64069 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 HDONMGHPOMO()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA46 RID: 64070 RVA: 0x00707407 File Offset: 0x00705607
			public LookAtBone()
			{
			}

			// Token: 0x0600FA47 RID: 64071 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 NAEAJNDGCNM()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA48 RID: 64072 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 GCMDAEAPKMA()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA49 RID: 64073 RVA: 0x00707410 File Offset: 0x00705610
			public void BOFJPPPABNO(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.NHPBNMOHPJG(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA4A RID: 64074 RVA: 0x00706EEE File Offset: 0x007050EE
			public void FCMIMIBJJJI(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA4B RID: 64075 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 CDOOOMKDJAK()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA4C RID: 64076 RVA: 0x00707450 File Offset: 0x00705650
			public void EHNJILNCIMF(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.EIJFHCGGJEM(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA4D RID: 64077 RVA: 0x00707490 File Offset: 0x00705690
			public void JELOENHICGN(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.forward, NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA4E RID: 64078 RVA: 0x00706EEE File Offset: 0x007050EE
			public void DJJIKBBNKEK(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA4F RID: 64079 RVA: 0x007074D0 File Offset: 0x007056D0
			public void EFBNIHGKEEF(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.MPHLBEFLIHC(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA50 RID: 64080 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 EDMALOJFDKE()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA51 RID: 64081 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 JEGBGCPLDNH()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA52 RID: 64082 RVA: 0x00706EEE File Offset: 0x007050EE
			public void PNLLDNBCBGG(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA53 RID: 64083 RVA: 0x00706EEE File Offset: 0x007050EE
			public void LLDECCKPLHM(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA54 RID: 64084 RVA: 0x00706EEE File Offset: 0x007050EE
			public void MLEBBNKPKKF(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA55 RID: 64085 RVA: 0x00707510 File Offset: 0x00705710
			public void NKFILKCHLMD(Vector3 NEMFIHCKJPE, float NKHBAJKMAGD)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.JDINKOCDMME(), NEMFIHCKJPE);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, NKHBAJKMAGD);
			}

			// Token: 0x0600FA56 RID: 64086 RVA: 0x00706EEE File Offset: 0x007050EE
			public void ICJJAOIEDNF(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA57 RID: 64087 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 ECMNLKEDDJB()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA58 RID: 64088 RVA: 0x00706EEE File Offset: 0x007050EE
			public void OECNHGIPNLB(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA59 RID: 64089 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 LLPELNBBDLO()
			{
				return this.transform.rotation * this.axis;
			}

			// Token: 0x0600FA5A RID: 64090 RVA: 0x00706EEE File Offset: 0x007050EE
			public void IOKNKDMGKDH(Transform EELDHNFBFOE)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * EELDHNFBFOE.forward;
			}

			// Token: 0x0600FA5B RID: 64091 RVA: 0x00706FDF File Offset: 0x007051DF
			public Vector3 EIHKNJDFFME()
			{
				return this.transform.rotation * this.axis;
			}
		}
	}
}
