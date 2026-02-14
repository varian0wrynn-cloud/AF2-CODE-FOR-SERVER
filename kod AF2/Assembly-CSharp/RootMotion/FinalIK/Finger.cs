using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000441 RID: 1089
	[Serializable]
	public class Finger
	{
		// Token: 0x0600EA72 RID: 60018 RVA: 0x006A2501 File Offset: 0x006A0701
		private void APIJGFPDKON(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x006A250A File Offset: 0x006A070A
		public bool JKHHAGIEOFO(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "ClimbIdle";
				return true;
			}
			return true;
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x006A2540 File Offset: 0x006A0740
		public void DIAGEINIGEP()
		{
			if (!this.initiated)
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x006A2591 File Offset: 0x006A0791
		public Quaternion HMBPCHPBHNP()
		{
			return this.solver.IKRotation;
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x006A25A0 File Offset: 0x006A07A0
		public void BHALELINNDJ(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.initiated = false;
			string empty = string.Empty;
			if (!this.CHFHJDFDIGB(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Target;
			this.solver.bendModifierWeight = 1f;
			this.IKPosition = this.tip.position;
			this.IKRotation = this.tip.rotation;
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.IKRotation) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.DNPHIDGDLIA(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.initiated = true;
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool LGHLNCKLFMC()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool FFOAFLJECIO()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x006A26B2 File Offset: 0x006A08B2
		public bool CELPINDCLAA(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "";
				return true;
			}
			return false;
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x006A2591 File Offset: 0x006A0791
		public Quaternion JJFJEIBHPFC()
		{
			return this.solver.IKRotation;
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x006A26E8 File Offset: 0x006A08E8
		public bool CHJAMEPPEOI(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "Textures/Fish/";
				return true;
			}
			return false;
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x006A2501 File Offset: 0x006A0701
		private void CFIABFJOFDE(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x006A2501 File Offset: 0x006A0701
		private void NIGEKOEBIAD(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x006A2720 File Offset: 0x006A0920
		public void FJMNBKHFLJO(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.CFIABFJOFDE(true);
			string empty = string.Empty;
			if (!this.CHFHJDFDIGB(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Target;
			this.solver.bendModifierWeight = 1589f;
			this.IKPosition = this.tip.position;
			this.GOINFMAPCGJ(this.tip.rotation);
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.JJFJEIBHPFC()) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.OPOOMPAPADK(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.OFGFGNMMBNL(false);
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x006A282A File Offset: 0x006A0A2A
		public void NCKEPFFPAKK(Quaternion DCCPCBLODIG)
		{
			this.solver.IKRotation = DCCPCBLODIG;
		}

		// Token: 0x0600EA80 RID: 60032 RVA: 0x006A2501 File Offset: 0x006A0701
		private void MJLLIMDOJOM(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool NNCINACEIDF()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x006A2838 File Offset: 0x006A0A38
		public Vector3 ICINIJFKFKJ()
		{
			return this.solver.IKPosition;
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x006A2845 File Offset: 0x006A0A45
		public bool LFKIOLIKJOO(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "repfrac";
				return false;
			}
			return false;
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x006A287C File Offset: 0x006A0A7C
		public void EAAJEBAKIEB()
		{
			if (!this.CKDLJANJKAK())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x006A28D0 File Offset: 0x006A0AD0
		public void AAEFACEGJMB(float GJFEMCAGMOO)
		{
			if (!this.initiated)
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 599f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.JFEEJIGKJMM(this.target.position);
				this.IKRotation = this.target.rotation;
			}
			if (this.bone3 != null)
			{
				if (num >= 1531f)
				{
					this.bone3.rotation = this.BDBDJICBPPF() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.BDBDJICBPPF() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool EJIBFPKKGOJ()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x006A2501 File Offset: 0x006A0701
		private void CLBGMDLKAKK(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x006A29B1 File Offset: 0x006A0BB1
		public bool CHFHJDFDIGB(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "One of the bones in the Finger Rig is null, can not initiate solvers.";
				return false;
			}
			return true;
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x006A2501 File Offset: 0x006A0701
		private void ODOAJHDCGHI(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x006A2501 File Offset: 0x006A0701
		private void MOFIGPNKJFH(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x006A29E7 File Offset: 0x006A0BE7
		public void JFEEJIGKJMM(Vector3 DCCPCBLODIG)
		{
			this.solver.IKPosition = DCCPCBLODIG;
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x006A282A File Offset: 0x006A0A2A
		public void GOINFMAPCGJ(Quaternion DCCPCBLODIG)
		{
			this.solver.IKRotation = DCCPCBLODIG;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x006A2501 File Offset: 0x006A0701
		private void JHBDOHDHIHI(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x006A29F5 File Offset: 0x006A0BF5
		public bool MEFGABBJFCI(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "1HandSwordJabCombo";
				return true;
			}
			return true;
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x006A282A File Offset: 0x006A0A2A
		public void OEKGMDEPPAJ(Quaternion DCCPCBLODIG)
		{
			this.solver.IKRotation = DCCPCBLODIG;
		}

		// Token: 0x0600EA90 RID: 60048 RVA: 0x006A2A2C File Offset: 0x006A0C2C
		public void HIIINMHFCHH(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.APIJGFPDKON(true);
			string empty = string.Empty;
			if (!this.MMDGNPAEAFP(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Animation;
			this.solver.bendModifierWeight = 999f;
			this.IKPosition = this.tip.position;
			this.OEKGMDEPPAJ(this.tip.rotation);
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.IKRotation) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.OPOOMPAPADK(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.MOFIGPNKJFH(true);
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x006A2591 File Offset: 0x006A0791
		// (set) Token: 0x0600EA91 RID: 60049 RVA: 0x006A282A File Offset: 0x006A0A2A
		public Quaternion IKRotation
		{
			get
			{
				return this.solver.IKRotation;
			}
			set
			{
				this.solver.IKRotation = value;
			}
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x006A2591 File Offset: 0x006A0791
		public Quaternion BDBDJICBPPF()
		{
			return this.solver.IKRotation;
		}

		// Token: 0x0600EA93 RID: 60051 RVA: 0x006A2B36 File Offset: 0x006A0D36
		public bool EJMDBNJCBHB(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "_PrefilterOffs";
				return true;
			}
			return true;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600EA94 RID: 60052 RVA: 0x006A26AA File Offset: 0x006A08AA
		// (set) Token: 0x0600EA98 RID: 60056 RVA: 0x006A2501 File Offset: 0x006A0701
		public bool initiated { get; private set; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x006A2838 File Offset: 0x006A0A38
		// (set) Token: 0x0600EAA5 RID: 60069 RVA: 0x006A29E7 File Offset: 0x006A0BE7
		public Vector3 IKPosition
		{
			get
			{
				return this.solver.IKPosition;
			}
			set
			{
				this.solver.IKPosition = value;
			}
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x006A2838 File Offset: 0x006A0A38
		public Vector3 HAEPHFNFNFF()
		{
			return this.solver.IKPosition;
		}

		// Token: 0x0600EA97 RID: 60055 RVA: 0x006A2B6C File Offset: 0x006A0D6C
		public bool MMDGNPAEAFP(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "_EmissionColor";
				return false;
			}
			return true;
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x006A2BA4 File Offset: 0x006A0DA4
		public void JMNNAPNJDNK(float GJFEMCAGMOO)
		{
			if (!this.DFNGCMIKDPD())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 1505f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.OEKGMDEPPAJ(this.target.rotation);
			}
			if (this.bone3 != null)
			{
				if (num >= 309f)
				{
					this.bone3.rotation = this.JJFJEIBHPFC() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.BDBDJICBPPF() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x006A2501 File Offset: 0x006A0701
		private void CAGMADMAEIN(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x006A2C88 File Offset: 0x006A0E88
		public void LBGKAMLLACN(float GJFEMCAGMOO)
		{
			if (!this.EJIBFPKKGOJ())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 1347f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.OEKGMDEPPAJ(this.target.rotation);
			}
			if (this.bone3 != null)
			{
				if (num >= 337f)
				{
					this.bone3.rotation = this.HMBPCHPBHNP() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.HMBPCHPBHNP() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EA9C RID: 60060 RVA: 0x006A2D6C File Offset: 0x006A0F6C
		public void DEGCCLNOEKJ(float GJFEMCAGMOO)
		{
			if (!this.CKDLJANJKAK())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 1927f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.JFEEJIGKJMM(this.target.position);
				this.GOINFMAPCGJ(this.target.rotation);
			}
			if (this.bone3 != null)
			{
				if (num >= 234f)
				{
					this.bone3.rotation = this.IKRotation * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.BDBDJICBPPF() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EA9E RID: 60062 RVA: 0x006A2501 File Offset: 0x006A0701
		private void JFENHLGIHFC(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EA9F RID: 60063 RVA: 0x006A2E50 File Offset: 0x006A1050
		public void LACNPNKHCAA(float GJFEMCAGMOO)
		{
			if (!this.EJIBFPKKGOJ())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 544f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.GOINFMAPCGJ(this.target.rotation);
			}
			if (this.bone3 != null)
			{
				if (num >= 1664f)
				{
					this.bone3.rotation = this.JJFJEIBHPFC() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.IKRotation * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EAA0 RID: 60064 RVA: 0x006A2F34 File Offset: 0x006A1134
		public void OHKHOAKCENL(float GJFEMCAGMOO)
		{
			if (!this.LGHLNCKLFMC())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 1767f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.JFEEJIGKJMM(this.target.position);
				this.OEKGMDEPPAJ(this.target.rotation);
			}
			if (this.bone3 != null)
			{
				if (num >= 98f)
				{
					this.bone3.rotation = this.JJFJEIBHPFC() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.HMBPCHPBHNP() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EAA1 RID: 60065 RVA: 0x006A3018 File Offset: 0x006A1218
		public void FANPFKHEDPA(float GJFEMCAGMOO)
		{
			if (!this.initiated)
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 0f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			if (this.bone3 != null)
			{
				if (num >= 1f)
				{
					this.bone3.rotation = this.IKRotation * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.IKRotation * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EAA2 RID: 60066 RVA: 0x006A30FC File Offset: 0x006A12FC
		public void OFBOJDIDJDL()
		{
			if (!this.LGHLNCKLFMC())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EAA3 RID: 60067 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool CKDLJANJKAK()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x006A3150 File Offset: 0x006A1350
		public void CKHKJOHKMEE(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.ODOAJHDCGHI(true);
			string empty = string.Empty;
			if (!this.MMDGNPAEAFP(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, true);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Target;
			this.solver.bendModifierWeight = 1330f;
			this.IKPosition = this.tip.position;
			this.IKRotation = this.tip.rotation;
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.HMBPCHPBHNP()) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.GGPNLFMBAIM(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.CFIABFJOFDE(false);
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x006A325A File Offset: 0x006A145A
		public bool OIDMJAPOEPD(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "no_money";
				return true;
			}
			return true;
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x006A3290 File Offset: 0x006A1490
		public void MNGMAJCDDFJ()
		{
			if (!this.NNCINACEIDF())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x006A32E4 File Offset: 0x006A14E4
		public void KNNNMPGPALP()
		{
			if (!this.CKDLJANJKAK())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EAA9 RID: 60073 RVA: 0x006A3335 File Offset: 0x006A1535
		public bool BLOEHCJCFEK(ref string CLDHEEJDHNK)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				CLDHEEJDHNK = "_camScale";
				return true;
			}
			return false;
		}

		// Token: 0x0600EAAA RID: 60074 RVA: 0x006A336C File Offset: 0x006A156C
		public void BHCIAIKKLJA(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.OBHPJEJDABI(true);
			string empty = string.Empty;
			if (!this.CELPINDCLAA(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Animation;
			this.solver.bendModifierWeight = 1107f;
			this.IKPosition = this.tip.position;
			this.GOINFMAPCGJ(this.tip.rotation);
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.JJFJEIBHPFC()) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.DNPHIDGDLIA(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.ODOAJHDCGHI(false);
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x006A2501 File Offset: 0x006A0701
		private void HKMOBGHBNHI(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x006A3478 File Offset: 0x006A1678
		public void BLOEEPCIPKJ()
		{
			if (!this.initiated)
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x006A34CC File Offset: 0x006A16CC
		public void OECNHGIPNLB(Transform DHPPKPKKJOF, int CLBPBJGLHEE)
		{
			this.initiated = false;
			string empty = string.Empty;
			if (!this.CELPINDCLAA(ref empty))
			{
				PMCOMMEEGMC.ICAFGKHAAED(empty, DHPPKPKKJOF, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Animation;
			this.solver.bendModifierWeight = 522f;
			this.IKPosition = this.tip.position;
			this.GOINFMAPCGJ(this.tip.rotation);
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.IKRotation) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.AOANEPNJLJN(this.bone1, this.bone2, this.tip, DHPPKPKKJOF);
			this.solver.BHALELINNDJ(DHPPKPKKJOF);
			this.MOFIGPNKJFH(false);
		}

		// Token: 0x0600EAAF RID: 60079 RVA: 0x006A2501 File Offset: 0x006A0701
		private void OFGFGNMMBNL(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x006A2838 File Offset: 0x006A0A38
		public Vector3 NDGGJPEHKBC()
		{
			return this.solver.IKPosition;
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x006A35EC File Offset: 0x006A17EC
		public void IKHCCAANGOP(float GJFEMCAGMOO)
		{
			if (!this.EJIBFPKKGOJ())
			{
				return;
			}
			float num = this.weight * GJFEMCAGMOO;
			if (num <= 1020f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			if (this.bone3 != null)
			{
				if (num >= 162f)
				{
					this.bone3.rotation = this.JJFJEIBHPFC() * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.BDBDJICBPPF() * this.bone3RelativeToTarget, num);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.FANPFKHEDPA();
		}

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x006A36D0 File Offset: 0x006A18D0
		public void IBNJKNMAMHI()
		{
			if (!this.NNCINACEIDF())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x006A26AA File Offset: 0x006A08AA
		public bool DFNGCMIKDPD()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x006A2501 File Offset: 0x006A0701
		private void OBHPJEJDABI(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EAB5 RID: 60085 RVA: 0x006A3724 File Offset: 0x006A1924
		public void ALMMFGEMGHL()
		{
			if (!this.CKDLJANJKAK())
			{
				return;
			}
			this.solver.BLOEEPCIPKJ();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x04001EB6 RID: 7862
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04001EB7 RID: 7863
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		// Token: 0x04001EB8 RID: 7864
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		// Token: 0x04001EB9 RID: 7865
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		// Token: 0x04001EBA RID: 7866
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		// Token: 0x04001EBB RID: 7867
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		// Token: 0x04001EBD RID: 7869
		private IKSolverLimb solver;

		// Token: 0x04001EBE RID: 7870
		private Quaternion bone3RelativeToTarget;

		// Token: 0x04001EBF RID: 7871
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x04001EC0 RID: 7872
		private Quaternion bone3DefaultLocalRotation;
	}
}
