using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200046A RID: 1130
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x0600F522 RID: 62754 RVA: 0x006DB6C8 File Offset: 0x006D98C8
		public bool CHFHJDFDIGB()
		{
			string empty = string.Empty;
			return this.CHFHJDFDIGB(ref empty);
		}

		// Token: 0x0600F523 RID: 62755
		public abstract bool CHFHJDFDIGB(ref string EDAPHMJENPK);

		// Token: 0x0600F524 RID: 62756 RVA: 0x006DB6E4 File Offset: 0x006D98E4
		public void BHALELINNDJ(Transform EELDHNFBFOE)
		{
			if (this.OnPreInitiate != null)
			{
				this.OnPreInitiate();
			}
			if (EELDHNFBFOE == null)
			{
				Debug.LogError("Initiating IKSolver with null root Transform.");
			}
			this.root = EELDHNFBFOE;
			this.initiated = false;
			string empty = string.Empty;
			if (!this.CHFHJDFDIGB(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, EELDHNFBFOE, false);
				return;
			}
			this.FKEMPLMBNEL();
			this.FGBCANJFNOC();
			this.initiated = true;
			this.firstInitiation = false;
			if (this.OnPostInitiate != null)
			{
				this.OnPostInitiate();
			}
		}

		// Token: 0x0600F525 RID: 62757 RVA: 0x006DB76C File Offset: 0x006D996C
		public void FANPFKHEDPA()
		{
			if (this.OnPreUpdate != null)
			{
				this.OnPreUpdate();
			}
			if (this.firstInitiation)
			{
				this.BHALELINNDJ(this.root);
			}
			if (!this.initiated)
			{
				return;
			}
			this.IOMMPHGGHNH();
			if (this.OnPostUpdate != null)
			{
				this.OnPostUpdate();
			}
		}

		// Token: 0x0600F526 RID: 62758 RVA: 0x006DB7C2 File Offset: 0x006D99C2
		public virtual Vector3 AEPMIDGGBAP()
		{
			return this.IKPosition;
		}

		// Token: 0x0600F527 RID: 62759 RVA: 0x006DB7CA File Offset: 0x006D99CA
		public void HJHGGGEMEBJ(Vector3 MGALEAJOGPL)
		{
			this.IKPosition = MGALEAJOGPL;
		}

		// Token: 0x0600F528 RID: 62760 RVA: 0x006DB7D3 File Offset: 0x006D99D3
		public float MJNMIHDOINP()
		{
			return this.IKPositionWeight;
		}

		// Token: 0x0600F529 RID: 62761 RVA: 0x006DB7DB File Offset: 0x006D99DB
		public void BLGEOKMMNOH(float NKHBAJKMAGD)
		{
			this.IKPositionWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
		}

		// Token: 0x0600F52A RID: 62762 RVA: 0x006DB7F3 File Offset: 0x006D99F3
		public Transform CCGINIJINOE()
		{
			return this.root;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600F52B RID: 62763 RVA: 0x006DB7FB File Offset: 0x006D99FB
		// (set) Token: 0x0600F52C RID: 62764 RVA: 0x006DB803 File Offset: 0x006D9A03
		public bool initiated { get; private set; }

		// Token: 0x0600F52D RID: 62765
		public abstract IKSolver.Point[] DJOBICJNHOD();

		// Token: 0x0600F52E RID: 62766
		public abstract IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM);

		// Token: 0x0600F52F RID: 62767
		public abstract void BLOEEPCIPKJ();

		// Token: 0x0600F530 RID: 62768
		public abstract void FGBCANJFNOC();

		// Token: 0x0600F531 RID: 62769
		protected abstract void FKEMPLMBNEL();

		// Token: 0x0600F532 RID: 62770
		protected abstract void IOMMPHGGHNH();

		// Token: 0x0600F533 RID: 62771 RVA: 0x006DB80C File Offset: 0x006D9A0C
		protected void AIPEHBKNFNL(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, this.root, true);
		}

		// Token: 0x0600F534 RID: 62772 RVA: 0x006DB81C File Offset: 0x006D9A1C
		public static Transform JGMHNBKPDNC(IKSolver.Bone[] CKAJJHFIFBL)
		{
			for (int i = 0; i < CKAJJHFIFBL.Length; i++)
			{
				for (int j = 0; j < CKAJJHFIFBL.Length; j++)
				{
					if (i != j && CKAJJHFIFBL[i].transform == CKAJJHFIFBL[j].transform)
					{
						return CKAJJHFIFBL[i].transform;
					}
				}
			}
			return null;
		}

		// Token: 0x0600F535 RID: 62773 RVA: 0x006DB86C File Offset: 0x006D9A6C
		public static bool AFLFMKJJCDL(IKSolver.Bone[] CKAJJHFIFBL)
		{
			for (int i = 1; i < CKAJJHFIFBL.Length; i++)
			{
				if (!LEHFMLLLKAP.AJHFHFGNKKO(CKAJJHFIFBL[i].transform, CKAJJHFIFBL[i - 1].transform))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F536 RID: 62774 RVA: 0x006DB8A4 File Offset: 0x006D9AA4
		protected static float PNHGMGKABOB(ref IKSolver.Bone[] CKAJJHFIFBL)
		{
			float num = 0f;
			for (int i = 0; i < CKAJJHFIFBL.Length; i++)
			{
				CKAJJHFIFBL[i].solverPosition = CKAJJHFIFBL[i].transform.position;
				CKAJJHFIFBL[i].solverRotation = CKAJJHFIFBL[i].transform.rotation;
			}
			for (int j = 0; j < CKAJJHFIFBL.Length; j++)
			{
				if (j < CKAJJHFIFBL.Length - 1)
				{
					CKAJJHFIFBL[j].sqrMag = (CKAJJHFIFBL[j + 1].solverPosition - CKAJJHFIFBL[j].solverPosition).sqrMagnitude;
					CKAJJHFIFBL[j].length = Mathf.Sqrt(CKAJJHFIFBL[j].sqrMag);
					num += CKAJJHFIFBL[j].length;
					CKAJJHFIFBL[j].axis = Quaternion.Inverse(CKAJJHFIFBL[j].solverRotation) * (CKAJJHFIFBL[j + 1].solverPosition - CKAJJHFIFBL[j].solverPosition);
				}
				else
				{
					CKAJJHFIFBL[j].sqrMag = 0f;
					CKAJJHFIFBL[j].length = 0f;
				}
			}
			return num;
		}

		// Token: 0x04002025 RID: 8229
		[HideInInspector]
		public Vector3 IKPosition;

		// Token: 0x04002026 RID: 8230
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight = 1f;

		// Token: 0x04002028 RID: 8232
		public IKSolver.LGGEKCCEELN OnPreInitiate;

		// Token: 0x04002029 RID: 8233
		public IKSolver.LGGEKCCEELN OnPostInitiate;

		// Token: 0x0400202A RID: 8234
		public IKSolver.LGGEKCCEELN OnPreUpdate;

		// Token: 0x0400202B RID: 8235
		public IKSolver.LGGEKCCEELN OnPostUpdate;

		// Token: 0x0400202C RID: 8236
		protected bool firstInitiation = true;

		// Token: 0x0400202D RID: 8237
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		// Token: 0x0200046B RID: 1131
		[Serializable]
		public class Point
		{
			// Token: 0x0600F538 RID: 62776 RVA: 0x006DB9D0 File Offset: 0x006D9BD0
			public void LLJNCEIMNGP()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F539 RID: 62777 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void LDKHLPOGNHP()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F53A RID: 62778 RVA: 0x006DBA53 File Offset: 0x006D9C53
			public void ACLGMPGGMJA()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x0600F53B RID: 62779 RVA: 0x006DBA77 File Offset: 0x006D9C77
			public void ALPDNEENBKA()
			{
				this.solverPosition = this.transform.localPosition;
			}

			// Token: 0x0600F53C RID: 62780 RVA: 0x006DBA8A File Offset: 0x006D9C8A
			public void CIKAIMJLGAP()
			{
				this.solverPosition = this.transform.position;
			}

			// Token: 0x0600F53D RID: 62781 RVA: 0x006DBAA0 File Offset: 0x006D9CA0
			public void CMEDACDMHPB()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F53E RID: 62782 RVA: 0x006DBB00 File Offset: 0x006D9D00
			public void LNKGPDNHDBK()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F53F RID: 62783 RVA: 0x006DBB5F File Offset: 0x006D9D5F
			public void NALKKKIAAFG()
			{
				this.solverPosition = this.transform.position;
				this.solverRotation = this.transform.rotation;
			}

			// Token: 0x0600F540 RID: 62784 RVA: 0x006DBB84 File Offset: 0x006D9D84
			public void MIGPPIGIDIK()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F541 RID: 62785 RVA: 0x006DBA53 File Offset: 0x006D9C53
			public void BFFKGIPICII()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x0600F542 RID: 62786 RVA: 0x006DBA8A File Offset: 0x006D9C8A
			public void BMIDBLHEFKG()
			{
				this.solverPosition = this.transform.position;
			}

			// Token: 0x0600F543 RID: 62787 RVA: 0x006DBA8A File Offset: 0x006D9C8A
			public void BBADLBAMAJM()
			{
				this.solverPosition = this.transform.position;
			}

			// Token: 0x0600F544 RID: 62788 RVA: 0x006DBA8A File Offset: 0x006D9C8A
			public void IKNLONLEBON()
			{
				this.solverPosition = this.transform.position;
			}

			// Token: 0x0600F545 RID: 62789 RVA: 0x006DBBE4 File Offset: 0x006D9DE4
			public void NPPOHJGFBLP()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F546 RID: 62790 RVA: 0x006DBA77 File Offset: 0x006D9C77
			public void DLKIAGBEEKP()
			{
				this.solverPosition = this.transform.localPosition;
			}

			// Token: 0x0600F547 RID: 62791 RVA: 0x006DBB5F File Offset: 0x006D9D5F
			public void CKNNOGANJAO()
			{
				this.solverPosition = this.transform.position;
				this.solverRotation = this.transform.rotation;
			}

			// Token: 0x0600F548 RID: 62792 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void KKBDHAMGCCI()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F549 RID: 62793 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void IMNCFDNDFKA()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F54A RID: 62794 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void EMDGMEBJODM()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F54B RID: 62795 RVA: 0x006DBC44 File Offset: 0x006D9E44
			public void JONLHAMDDEA()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F54C RID: 62796 RVA: 0x006DBCA4 File Offset: 0x006D9EA4
			public void EOLOGIEOLAF()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F54D RID: 62797 RVA: 0x006DBD04 File Offset: 0x006D9F04
			public void MKDGKDPKLBL()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F54E RID: 62798 RVA: 0x006DBA53 File Offset: 0x006D9C53
			public void MECKDOEHKPM()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x0600F54F RID: 62799 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void FGBCANJFNOC()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F550 RID: 62800 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void POLNPMPEFEJ()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F551 RID: 62801 RVA: 0x006DBA77 File Offset: 0x006D9C77
			public void ODGFLFDNEDA()
			{
				this.solverPosition = this.transform.localPosition;
			}

			// Token: 0x0600F552 RID: 62802 RVA: 0x006DBD64 File Offset: 0x006D9F64
			public void EIHEJIHDNKP()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x0600F553 RID: 62803 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void KCFHDEOMKMM()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F554 RID: 62804 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void IGBAJPEIMKI()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F555 RID: 62805 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void LBJPGOPFLJN()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F556 RID: 62806 RVA: 0x006DBA53 File Offset: 0x006D9C53
			public void LICKNAFKLIL()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x0600F557 RID: 62807 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void KFCDNBMKNLJ()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F558 RID: 62808 RVA: 0x006DBA53 File Offset: 0x006D9C53
			public void DMHBKHNPMHC()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x0600F559 RID: 62809 RVA: 0x006DBA2F File Offset: 0x006D9C2F
			public void ONHCJAKIKNI()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0400202E RID: 8238
			public Transform transform;

			// Token: 0x0400202F RID: 8239
			[Range(0f, 1f)]
			public float weight = 1f;

			// Token: 0x04002030 RID: 8240
			public Vector3 solverPosition;

			// Token: 0x04002031 RID: 8241
			public Quaternion solverRotation = Quaternion.identity;

			// Token: 0x04002032 RID: 8242
			public Vector3 defaultLocalPosition;

			// Token: 0x04002033 RID: 8243
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x0200046C RID: 1132
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x0600F55B RID: 62811 RVA: 0x006DBDE4 File Offset: 0x006D9FE4
			public void PCOKBNLDMDF(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1477f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 1376f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 408f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F55C RID: 62812 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void MIFDLIEIMGH(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F55D RID: 62813 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void MNCLMGNIJPH()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F55E RID: 62814 RVA: 0x006DBEAA File Offset: 0x006DA0AA
			public Bone()
			{
			}

			// Token: 0x0600F55F RID: 62815 RVA: 0x006DBECC File Offset: 0x006DA0CC
			public static void NHCNMNBHHCO(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1786f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1705f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F560 RID: 62816 RVA: 0x006DBF68 File Offset: 0x006DA168
			public static void FAONGCLHMIB(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 933f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 786f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F561 RID: 62817 RVA: 0x006DC004 File Offset: 0x006DA204
			public RotationLimit CLBCIJOPEHI()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F562 RID: 62818 RVA: 0x006DC054 File Offset: 0x006DA254
			public void IAIIDKINKBD(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 858f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 276f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F563 RID: 62819 RVA: 0x006DC0E4 File Offset: 0x006DA2E4
			public void MPAJPECOOLD(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 600f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1978f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F564 RID: 62820 RVA: 0x006DC174 File Offset: 0x006DA374
			public static void EPECFFELAMJ(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1262f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1122f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F565 RID: 62821 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void MDDOKIPIDLK()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F566 RID: 62822 RVA: 0x006DC210 File Offset: 0x006DA410
			public RotationLimit JAHABHNJEPI()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F567 RID: 62823 RVA: 0x006DC260 File Offset: 0x006DA460
			public void APFDCIPCFGE(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1748f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 639f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 195f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F568 RID: 62824 RVA: 0x006DC300 File Offset: 0x006DA500
			public RotationLimit MPNLGJMOLGG()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F569 RID: 62825 RVA: 0x006DC350 File Offset: 0x006DA550
			public static void FHLDENOFGIP(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j++)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F56A RID: 62826 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void JNOLPDKOOKL()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F56B RID: 62827 RVA: 0x006DC3EC File Offset: 0x006DA5EC
			public RotationLimit IIPCINMHCDG()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F56C RID: 62828 RVA: 0x006DC43C File Offset: 0x006DA63C
			public RotationLimit KCDFHPFMOBD()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F56D RID: 62829 RVA: 0x006DC48C File Offset: 0x006DA68C
			public static void KMEPMMNNNKP(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1137f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1710f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F56E RID: 62830 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void OEDKLCAFLLJ(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F56F RID: 62831 RVA: 0x006DC528 File Offset: 0x006DA728
			public void FIOHHJIIJEO(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1028f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 35f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F570 RID: 62832 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void OICDINLIIFJ()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F571 RID: 62833 RVA: 0x006DC5B8 File Offset: 0x006DA7B8
			public void OOFFEPEOBJB(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1671f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 61f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 890f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F572 RID: 62834 RVA: 0x006DC655 File Offset: 0x006DA855
			public Bone(Transform LPBDALAMAEM)
			{
				this.transform = LPBDALAMAEM;
			}

			// Token: 0x0600F573 RID: 62835 RVA: 0x006DC67C File Offset: 0x006DA87C
			public void DKMAHFNCMBN(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1151f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 736f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F574 RID: 62836 RVA: 0x006DC70C File Offset: 0x006DA90C
			public void LPKOCKMPLAM(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1820f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1346f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F575 RID: 62837 RVA: 0x006DC79C File Offset: 0x006DA99C
			public static void LCKJDCKNHGA(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 242f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 314f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i += 0)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j++)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x0600F576 RID: 62838 RVA: 0x006DC838 File Offset: 0x006DAA38
			// (set) Token: 0x0600F5A3 RID: 62883 RVA: 0x006DBE81 File Offset: 0x006DA081
			public RotationLimit rotationLimit
			{
				get
				{
					if (!this.isLimited)
					{
						return null;
					}
					if (this._rotationLimit == null)
					{
						this._rotationLimit = this.transform.GetComponent<RotationLimit>();
					}
					this.isLimited = (this._rotationLimit != null);
					return this._rotationLimit;
				}
				set
				{
					this._rotationLimit = value;
					this.isLimited = (value != null);
				}
			}

			// Token: 0x0600F577 RID: 62839 RVA: 0x006DC888 File Offset: 0x006DAA88
			public void CPHGKDFLNIA(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 350f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 965f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F578 RID: 62840 RVA: 0x006DC918 File Offset: 0x006DAB18
			public void ABPLIIPDPJL(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 500f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1027f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F579 RID: 62841 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void IKMBNKOIILC()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F57A RID: 62842 RVA: 0x006DC9A8 File Offset: 0x006DABA8
			public void GDHEJBJFEKJ(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 243f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 304f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F57B RID: 62843 RVA: 0x006DCA38 File Offset: 0x006DAC38
			public void DAILMCKACLA(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 643f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 986f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 929f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F57C RID: 62844 RVA: 0x006DCAD8 File Offset: 0x006DACD8
			public void AJJEGEDEFKG(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1762f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 651f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F57D RID: 62845 RVA: 0x006DCB68 File Offset: 0x006DAD68
			public void HAINKLHLBLG(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1668f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1325f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F57E RID: 62846 RVA: 0x006DCBF8 File Offset: 0x006DADF8
			public RotationLimit IIFBJMIBPJD()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F57F RID: 62847 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void NLMMDCAMLLP(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F580 RID: 62848 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void GFPHLOKLGLK()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F581 RID: 62849 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void OLPMIMNGMMN(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F582 RID: 62850 RVA: 0x006DCC48 File Offset: 0x006DAE48
			public void BFHEMBIKDPD(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1504f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 100f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 162f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F583 RID: 62851 RVA: 0x006DCCE8 File Offset: 0x006DAEE8
			public static void ABKOKFEGIGF(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 556f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1710f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F584 RID: 62852 RVA: 0x006DCD84 File Offset: 0x006DAF84
			public RotationLimit EDOKKOOPJLP()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F585 RID: 62853 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void HHEHNMICONP()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F586 RID: 62854 RVA: 0x006DCDD4 File Offset: 0x006DAFD4
			public void EIOHPCCECDF(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F587 RID: 62855 RVA: 0x006DCE64 File Offset: 0x006DB064
			public RotationLimit EBFOGHAADOB()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F588 RID: 62856 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void KFMLJEKJNCJ()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F589 RID: 62857 RVA: 0x006DCEB4 File Offset: 0x006DB0B4
			public void AAMCNPOCALC(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1693f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 1284f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 1911f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F58A RID: 62858 RVA: 0x006DCF54 File Offset: 0x006DB154
			public void OAFNIANIPFM(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 628f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 739f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F58B RID: 62859 RVA: 0x006DCFE4 File Offset: 0x006DB1E4
			public void AIJCCLIANHE(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1531f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 662f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 1814f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F58C RID: 62860 RVA: 0x006DD084 File Offset: 0x006DB284
			public static void JDIJGEHFJIG(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1241f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1418f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F58D RID: 62861 RVA: 0x006DD120 File Offset: 0x006DB320
			public void BEPOBGOHDDH(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1638f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 416f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 571f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F58E RID: 62862 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void DKAMICJIKHO(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F58F RID: 62863 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void MADFPBIEDPD()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F590 RID: 62864 RVA: 0x006DD1C0 File Offset: 0x006DB3C0
			public void ENPIAHCGPOB(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1508f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 1611f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F591 RID: 62865 RVA: 0x006DD250 File Offset: 0x006DB450
			public static void AODMGAIFADG(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 666f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 47f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j++)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F592 RID: 62866 RVA: 0x006DD2EC File Offset: 0x006DB4EC
			public void FJIOJMCLHGA(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1681f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 1806f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 1073f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F593 RID: 62867 RVA: 0x006DD38C File Offset: 0x006DB58C
			public void LANCNEIJCDL(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 499f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 1529f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 1911f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F594 RID: 62868 RVA: 0x006DD42C File Offset: 0x006DB62C
			public static void PDDIMLKIEBI(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 203f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 1276f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j++)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F595 RID: 62869 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void OEFKJKADEPO()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F596 RID: 62870 RVA: 0x006DD4C8 File Offset: 0x006DB6C8
			public RotationLimit JFPDFHLHIHJ()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F597 RID: 62871 RVA: 0x006DD518 File Offset: 0x006DB718
			public void FPFAOKOFCPH(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 428f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 924f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 1179f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F598 RID: 62872 RVA: 0x006DD5B8 File Offset: 0x006DB7B8
			public RotationLimit GIODJAABDKA()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F599 RID: 62873 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void EDFCCBFFOGF()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F59A RID: 62874 RVA: 0x006DD608 File Offset: 0x006DB808
			public void IOEGFLMLBKK(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1058f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 1565f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 609f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F59B RID: 62875 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void JMFDMIJGDHM()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F59C RID: 62876 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void PIGKADMLHIJ()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F59D RID: 62877 RVA: 0x006DD6A8 File Offset: 0x006DB8A8
			public void JGGDLDIEIKD(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = CCIECPEKMEC - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * NKHBAJKMAGD, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x0600F59E RID: 62878 RVA: 0x006DD748 File Offset: 0x006DB948
			public RotationLimit BNBIOMOMICJ()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F59F RID: 62879 RVA: 0x006DD798 File Offset: 0x006DB998
			public void DGDDFNNCNEC(Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 252f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, CCIECPEKMEC - this.transform.position);
				if (NKHBAJKMAGD >= 405f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * this.transform.rotation;
			}

			// Token: 0x0600F5A0 RID: 62880 RVA: 0x006DD828 File Offset: 0x006DBA28
			public RotationLimit IAIFLBKIHEE()
			{
				if (!this.isLimited)
				{
					return null;
				}
				if (this._rotationLimit == null)
				{
					this._rotationLimit = this.transform.GetComponent<RotationLimit>();
				}
				this.isLimited = (this._rotationLimit != null);
				return this._rotationLimit;
			}

			// Token: 0x0600F5A1 RID: 62881 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void APIEDDEKGPJ()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F5A2 RID: 62882 RVA: 0x006DD878 File Offset: 0x006DBA78
			public static void CNMKAFBOLLK(IKSolver.Bone[] CKAJJHFIFBL, int CLBPBJGLHEE, Vector3 CCIECPEKMEC, float NKHBAJKMAGD = 1f)
			{
				if (NKHBAJKMAGD <= 1573f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(CKAJJHFIFBL[CLBPBJGLHEE].solverRotation * CKAJJHFIFBL[CLBPBJGLHEE].axis, CCIECPEKMEC - CKAJJHFIFBL[CLBPBJGLHEE].solverPosition);
				if (NKHBAJKMAGD >= 364f)
				{
					for (int i = CLBPBJGLHEE; i < CKAJJHFIFBL.Length; i++)
					{
						CKAJJHFIFBL[i].solverRotation = quaternion * CKAJJHFIFBL[i].solverRotation;
					}
					return;
				}
				for (int j = CLBPBJGLHEE; j < CKAJJHFIFBL.Length; j += 0)
				{
					CKAJJHFIFBL[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * CKAJJHFIFBL[j].solverRotation;
				}
			}

			// Token: 0x0600F5A4 RID: 62884 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void NEAGJPMLGBB(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F5A5 RID: 62885 RVA: 0x006DBE97 File Offset: 0x006DA097
			public void GCLJBDIICHJ()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x0600F5A6 RID: 62886 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void IJMDJMGMIPF(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x0600F5A7 RID: 62887 RVA: 0x006DD913 File Offset: 0x006DBB13
			public Bone(Transform LPBDALAMAEM, float NKHBAJKMAGD)
			{
				this.transform = LPBDALAMAEM;
				this.weight = NKHBAJKMAGD;
			}

			// Token: 0x0600F5A8 RID: 62888 RVA: 0x006DBE81 File Offset: 0x006DA081
			public void MAGHDGGIGPA(RotationLimit DCCPCBLODIG)
			{
				this._rotationLimit = DCCPCBLODIG;
				this.isLimited = (DCCPCBLODIG != null);
			}

			// Token: 0x04002034 RID: 8244
			public float length;

			// Token: 0x04002035 RID: 8245
			public float sqrMag;

			// Token: 0x04002036 RID: 8246
			public Vector3 axis = -Vector3.right;

			// Token: 0x04002037 RID: 8247
			private RotationLimit _rotationLimit;

			// Token: 0x04002038 RID: 8248
			private bool isLimited = true;
		}

		// Token: 0x0200046D RID: 1133
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x0600F5A9 RID: 62889 RVA: 0x006DD940 File Offset: 0x006DBB40
			public Node(Transform LPBDALAMAEM, float NKHBAJKMAGD)
			{
				this.transform = LPBDALAMAEM;
				this.weight = NKHBAJKMAGD;
			}

			// Token: 0x0600F5AA RID: 62890 RVA: 0x006DD956 File Offset: 0x006DBB56
			public Node(Transform LPBDALAMAEM)
			{
				this.transform = LPBDALAMAEM;
			}

			// Token: 0x0600F5AB RID: 62891 RVA: 0x006DD965 File Offset: 0x006DBB65
			public Node()
			{
			}

			// Token: 0x04002039 RID: 8249
			public float length;

			// Token: 0x0400203A RID: 8250
			public float effectorPositionWeight;

			// Token: 0x0400203B RID: 8251
			public float effectorRotationWeight;

			// Token: 0x0400203C RID: 8252
			public Vector3 offset;
		}

		// Token: 0x0200046E RID: 1134
		// (Invoke) Token: 0x0600F5AD RID: 62893
		public delegate void LGGEKCCEELN();

		// Token: 0x0200046F RID: 1135
		// (Invoke) Token: 0x0600F5B1 RID: 62897
		public delegate void MLFKIGOCFLP(int LMGJKOMFCFC);
	}
}
