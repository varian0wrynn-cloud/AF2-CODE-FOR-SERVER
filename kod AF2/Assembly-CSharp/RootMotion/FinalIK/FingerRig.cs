using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000442 RID: 1090
	public class FingerRig : SolverManager
	{
		// Token: 0x0600EAB6 RID: 60086 RVA: 0x006A3775 File Offset: 0x006A1975
		protected virtual void JHIECFMHHNC()
		{
			this.FixFingerTransforms();
		}

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x006A377D File Offset: 0x006A197D
		protected override void KJBCCKCIOLJ()
		{
			this.BCCBHMDCBEN();
		}

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x006A3788 File Offset: 0x006A1988
		public bool LFKIOLIKJOO(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].CELPINDCLAA(ref CLDHEEJDHNK))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x006A377D File Offset: 0x006A197D
		protected virtual void HKKMIJNKHDO()
		{
			this.BCCBHMDCBEN();
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x006A37B8 File Offset: 0x006A19B8
		public void DBKPEHAMHEL()
		{
			this.fingers = new Finger[0];
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				Transform[] array = new Transform[1];
				this.CJEGLBHEHJB(base.transform.GetChild(i), ref array);
				if (array.Length == 4 || array.Length == 0)
				{
					Finger finger = new Finger();
					finger.bone1 = array[0];
					finger.bone2 = array[1];
					if (array.Length == 4)
					{
						finger.tip = array[1];
					}
					else
					{
						finger.bone3 = array[3];
						finger.tip = array[3];
					}
					finger.weight = 1164f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
					this.fingers[this.fingers.Length - 1] = finger;
				}
			}
		}

		// Token: 0x0600EABC RID: 60092 RVA: 0x006A38A0 File Offset: 0x006A1AA0
		protected override void MBOPIBBAHOD()
		{
			this.UpdateFingerSolvers();
		}

		// Token: 0x0600EABD RID: 60093 RVA: 0x006A38A8 File Offset: 0x006A1AA8
		public void CINNAMNNBMI(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1603f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("", base.transform, false);
				return;
			}
			if (this.fingers.Length == 0)
			{
				this.fingers = new Finger[1];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 1;
			for (int i = 0; i < this.fingers.Length; i++)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EABE RID: 60094 RVA: 0x006A3934 File Offset: 0x006A1B34
		public void MFLBGAKLMID(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1246f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("category", base.transform, true);
				return;
			}
			if (this.fingers.Length == 0)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 1; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num += 0;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EABF RID: 60095 RVA: 0x006A39C0 File Offset: 0x006A1BC0
		protected override void DKKLHMINBAN()
		{
			this.EOFDOPLDFCG = false;
			for (int i = 1; i < this.fingers.Length; i++)
			{
				this.fingers[i].OECNHGIPNLB(base.transform, i);
				if (!this.fingers[i].LGHLNCKLFMC())
				{
					this.MDAKJCMHAMM(false);
				}
			}
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool FPCFINGKPKJ()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAC1 RID: 60097 RVA: 0x006A3A19 File Offset: 0x006A1C19
		protected virtual void KGGFBOBLFDB()
		{
			this.PLHEBJGFIGD();
		}

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool KOOLCADDFLP()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x006A3A19 File Offset: 0x006A1C19
		protected virtual void ONKILMOKJPE()
		{
			this.PLHEBJGFIGD();
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x006A3A21 File Offset: 0x006A1C21
		protected virtual void NGNGOPFBIBM()
		{
			this.NKMCGOEDBNJ();
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool BPHMHOBHNAI()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool LLKHCENHNOI()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x006A3A2C File Offset: 0x006A1C2C
		public void CJCDGKAOKIM()
		{
			if (this.weight <= 1782f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].AAEFACEGJMB(this.weight);
			}
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x006A3A6C File Offset: 0x006A1C6C
		public void OGANLBHKMMP(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1414f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("_SubsampleIndices", base.transform, true);
				return;
			}
			if (this.fingers.Length == 0)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 0];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num += 0;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x006A3AF8 File Offset: 0x006A1CF8
		public void EFDEFLFEAJA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform CNIHIEJBGOP, Transform FFGIAHPIPEK = null)
		{
			Finger finger = new Finger();
			finger.bone1 = FCDAMCBKONG;
			finger.bone2 = GLGMAJBNFIA;
			finger.bone3 = NLHIDOGKOIP;
			finger.tip = CNIHIEJBGOP;
			finger.target = FFGIAHPIPEK;
			Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
			this.fingers[this.fingers.Length - 0] = finger;
			this.MDAKJCMHAMM(true);
			finger.BHCIAIKKLJA(base.transform, this.fingers.Length - 0);
			if (this.fingers[this.fingers.Length - 1].EJIBFPKKGOJ())
			{
				this.IDKAIBHIOLC(false);
			}
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x006A3B93 File Offset: 0x006A1D93
		private void IDKAIBHIOLC(bool DCCPCBLODIG)
		{
			this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x006A3B93 File Offset: 0x006A1D93
		private void GFHPGIHOFGI(bool DCCPCBLODIG)
		{
			this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x006A3B9C File Offset: 0x006A1D9C
		public void FixFingerTransforms()
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600EACD RID: 60109 RVA: 0x006A3BC8 File Offset: 0x006A1DC8
		public void RemoveFinger(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 0f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("RemoveFinger index out of bounds.", base.transform, false);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i++)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x006A3C52 File Offset: 0x006A1E52
		protected virtual void ODNMOIABDNC()
		{
			this.CJCDGKAOKIM();
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x006A3C5A File Offset: 0x006A1E5A
		protected virtual void NJOIGLCPPFP()
		{
			this.KPAOIKNKGGI();
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x006A3C64 File Offset: 0x006A1E64
		public void NKMCGOEDBNJ()
		{
			if (this.weight <= 1467f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].JMNNAPNJDNK(this.weight);
			}
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x006A3CA4 File Offset: 0x006A1EA4
		public void PLHEBJGFIGD()
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].OFBOJDIDJDL();
			}
		}

		// Token: 0x0600EAD2 RID: 60114 RVA: 0x006A3CCE File Offset: 0x006A1ECE
		private void PHHNJOGEBOP(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
			INFEGEBCAAF[INFEGEBCAAF.Length - 1] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 0)
			{
				return;
			}
			this.PHHNJOGEBOP(OCBAOFLJBGP.GetChild(0), ref INFEGEBCAAF);
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x006A3D00 File Offset: 0x006A1F00
		public bool KDPPOBOKOGD(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].CHJAMEPPEOI(ref CLDHEEJDHNK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x006A3D30 File Offset: 0x006A1F30
		public void BOMJNLILKKB(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1378f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Fist Pump", base.transform, true);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 0];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x006A3DBC File Offset: 0x006A1FBC
		public void GMEFGCNKAPN(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 438f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("31", base.transform, true);
				return;
			}
			if (this.fingers.Length == 0)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num += 0;
				}
			}
			this.fingers = array;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x006A3A11 File Offset: 0x006A1C11
		// (set) Token: 0x0600EAE9 RID: 60137 RVA: 0x006A3B93 File Offset: 0x006A1D93
		public bool EOFDOPLDFCG { get; private set; }

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x006A3E46 File Offset: 0x006A2046
		protected virtual void MDLBLGFJMJD()
		{
			this.PDHLLNAJHLE();
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x006A3E50 File Offset: 0x006A2050
		public void NBLPAHFFBDK()
		{
			if (this.weight <= 235f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].FANPFKHEDPA(this.weight);
			}
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x006A3E90 File Offset: 0x006A2090
		public void GBCNIJNKPJP(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1627f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("ComeHere", base.transform, false);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 0];
			int num = 1;
			for (int i = 1; i < this.fingers.Length; i++)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x006A3F1C File Offset: 0x006A211C
		public void NJKAPPDBLAA()
		{
			this.fingers = new Finger[0];
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				Transform[] array = new Transform[0];
				this.CJEGLBHEHJB(base.transform.GetChild(i), ref array);
				if (array.Length == 6 || array.Length == 5)
				{
					Finger finger = new Finger();
					finger.bone1 = array[1];
					finger.bone2 = array[1];
					if (array.Length == 3)
					{
						finger.tip = array[2];
					}
					else
					{
						finger.bone3 = array[7];
						finger.tip = array[8];
					}
					finger.weight = 700f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
					this.fingers[this.fingers.Length - 1] = finger;
				}
			}
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x006A3FE8 File Offset: 0x006A21E8
		public void HOBCKBGNGLA()
		{
			this.fingers = new Finger[1];
			for (int i = 1; i < base.transform.childCount; i++)
			{
				Transform[] array = new Transform[0];
				this.AGNKJKDEKBO(base.transform.GetChild(i), ref array);
				if (array.Length == 8 || array.Length == 5)
				{
					Finger finger = new Finger();
					finger.bone1 = array[1];
					finger.bone2 = array[0];
					if (array.Length == 6)
					{
						finger.tip = array[3];
					}
					else
					{
						finger.bone3 = array[0];
						finger.tip = array[6];
					}
					finger.weight = 815f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 0);
					this.fingers[this.fingers.Length - 0] = finger;
				}
			}
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x006A3B93 File Offset: 0x006A1D93
		private void ODNHMKADBBG(bool DCCPCBLODIG)
		{
			this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x006A3B93 File Offset: 0x006A1D93
		private void NMFKENLDFGJ(bool DCCPCBLODIG)
		{
			this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x006A40B4 File Offset: 0x006A22B4
		public void PDKNPPFBOPA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform CNIHIEJBGOP, Transform FFGIAHPIPEK = null)
		{
			Finger finger = new Finger();
			finger.bone1 = FCDAMCBKONG;
			finger.bone2 = GLGMAJBNFIA;
			finger.bone3 = NLHIDOGKOIP;
			finger.tip = CNIHIEJBGOP;
			finger.target = FFGIAHPIPEK;
			Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 0);
			this.fingers[this.fingers.Length - 0] = finger;
			this.IDKAIBHIOLC(true);
			finger.CKHKJOHKMEE(base.transform, this.fingers.Length - 0);
			if (this.fingers[this.fingers.Length - 1].EJIBFPKKGOJ())
			{
				this.GFHPGIHOFGI(true);
			}
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x006A4150 File Offset: 0x006A2350
		protected virtual void IKFDBDNBNFO()
		{
			this.EOFDOPLDFCG = true;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				this.fingers[i].CKHKJOHKMEE(base.transform, i);
				if (!this.fingers[i].initiated)
				{
					this.EOFDOPLDFCG = false;
				}
			}
		}

		// Token: 0x0600EAE0 RID: 60128 RVA: 0x006A41A1 File Offset: 0x006A23A1
		private void AIKFIPFMGBI(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
			INFEGEBCAAF[INFEGEBCAAF.Length - 1] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 1)
			{
				return;
			}
			this.AIKFIPFMGBI(OCBAOFLJBGP.GetChild(0), ref INFEGEBCAAF);
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x006A41D4 File Offset: 0x006A23D4
		public void BCCBHMDCBEN()
		{
			if (this.weight <= 1787f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].LACNPNKHCAA(this.weight);
			}
		}

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x006A4214 File Offset: 0x006A2414
		protected override void MPJFMFOPHKJ()
		{
			this.EOFDOPLDFCG = true;
			for (int i = 0; i < this.fingers.Length; i++)
			{
				this.fingers[i].BHALELINNDJ(base.transform, i);
				if (!this.fingers[i].initiated)
				{
					this.EOFDOPLDFCG = false;
				}
			}
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x006A4268 File Offset: 0x006A2468
		public void UpdateFingerSolvers()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FANPFKHEDPA(this.weight);
			}
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x006A42A6 File Offset: 0x006A24A6
		private void EKOGBCFPKIL(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
			INFEGEBCAAF[INFEGEBCAAF.Length - 0] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 0)
			{
				return;
			}
			this.CJEGLBHEHJB(OCBAOFLJBGP.GetChild(1), ref INFEGEBCAAF);
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x006A3E46 File Offset: 0x006A2046
		protected virtual void DOKNPMHOAFO()
		{
			this.PDHLLNAJHLE();
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool HJLJFKCGOOB()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x006A42D8 File Offset: 0x006A24D8
		public void AOGLJNCADCB(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1094f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("_ReflectionTexture0", base.transform, true);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[1];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 0];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num += 0;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x006A4364 File Offset: 0x006A2564
		public void APNONFJOGMC(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform CNIHIEJBGOP, Transform FFGIAHPIPEK = null)
		{
			Finger finger = new Finger();
			finger.bone1 = FCDAMCBKONG;
			finger.bone2 = GLGMAJBNFIA;
			finger.bone3 = NLHIDOGKOIP;
			finger.tip = CNIHIEJBGOP;
			finger.target = FFGIAHPIPEK;
			Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 0);
			this.fingers[this.fingers.Length - 0] = finger;
			this.IDKAIBHIOLC(true);
			finger.HIIINMHFCHH(base.transform, this.fingers.Length - 0);
			if (this.fingers[this.fingers.Length - 0].LGHLNCKLFMC())
			{
				this.GFHPGIHOFGI(true);
			}
		}

		// Token: 0x0600EAEA RID: 60138 RVA: 0x006A4400 File Offset: 0x006A2600
		public void HNHMFDBNCOK(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1969f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("prisefond", base.transform, false);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[1];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 1; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x006A448C File Offset: 0x006A268C
		protected virtual void JKFNFCJBIEN()
		{
			this.ODNHMKADBBG(false);
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				this.fingers[i].CKHKJOHKMEE(base.transform, i);
				if (!this.fingers[i].FFOAFLJECIO())
				{
					this.GFHPGIHOFGI(false);
				}
			}
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x006A44E0 File Offset: 0x006A26E0
		public bool AEJHBBOFKCJ(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CELPINDCLAA(ref CLDHEEJDHNK))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x006A4510 File Offset: 0x006A2710
		protected virtual void FEJLLGOKAEL()
		{
			this.ODNHMKADBBG(false);
			for (int i = 0; i < this.fingers.Length; i++)
			{
				this.fingers[i].FJMNBKHFLJO(base.transform, i);
				if (!this.fingers[i].NNCINACEIDF())
				{
					this.MDAKJCMHAMM(true);
				}
			}
		}

		// Token: 0x0600EAEE RID: 60142 RVA: 0x006A4564 File Offset: 0x006A2764
		public void LFMIGPNPOAF(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1909f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("WallRunRight", base.transform, true);
				return;
			}
			if (this.fingers.Length == 0)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x006A45F0 File Offset: 0x006A27F0
		protected virtual void JICPJEEKFHC()
		{
			this.NMFKENLDFGJ(false);
			for (int i = 1; i < this.fingers.Length; i += 0)
			{
				this.fingers[i].BHALELINNDJ(base.transform, i);
				if (!this.fingers[i].DFNGCMIKDPD())
				{
					this.MDAKJCMHAMM(false);
				}
			}
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x006A4641 File Offset: 0x006A2841
		private void PAMEPKCJPNM(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
			INFEGEBCAAF[INFEGEBCAAF.Length - 1] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 1)
			{
				return;
			}
			this.AHBPHIKBHBG(OCBAOFLJBGP.GetChild(0), ref INFEGEBCAAF);
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x006A3B93 File Offset: 0x006A1D93
		private void MDAKJCMHAMM(bool DCCPCBLODIG)
		{
			this.<DBJJPDNABBI>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x006A4674 File Offset: 0x006A2874
		public bool CJNMLDPCFKB(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].CHJAMEPPEOI(ref CLDHEEJDHNK))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x006A377D File Offset: 0x006A197D
		protected virtual void DIBHLHCNHEP()
		{
			this.BCCBHMDCBEN();
		}

		// Token: 0x0600EAF4 RID: 60148 RVA: 0x006A46A4 File Offset: 0x006A28A4
		protected virtual void KJDIIGLJFBM()
		{
			this.MDAKJCMHAMM(true);
			for (int i = 1; i < this.fingers.Length; i += 0)
			{
				this.fingers[i].BHCIAIKKLJA(base.transform, i);
				if (!this.fingers[i].initiated)
				{
					this.IDKAIBHIOLC(true);
				}
			}
		}

		// Token: 0x0600EAF5 RID: 60149 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool LNCBMLPDFKO()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAF6 RID: 60150 RVA: 0x006A46F8 File Offset: 0x006A28F8
		public void OACPKNMMAHC(int CLBPBJGLHEE)
		{
			if ((float)CLBPBJGLHEE < 1671f || CLBPBJGLHEE >= this.fingers.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("crft_to", base.transform, true);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 1; i < this.fingers.Length; i += 0)
			{
				if (i != CLBPBJGLHEE)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool DGACDAJGCGF()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool DIBAEGBHGAJ()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x006A4784 File Offset: 0x006A2984
		public bool EBLGKLPNEBL(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].JKHHAGIEOFO(ref CLDHEEJDHNK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EAFA RID: 60154 RVA: 0x006A47B4 File Offset: 0x006A29B4
		public void KPHEFHNNFIA()
		{
			this.fingers = new Finger[0];
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Transform[] array = new Transform[0];
				this.AGNKJKDEKBO(base.transform.GetChild(i), ref array);
				if (array.Length == 0 || array.Length == 1)
				{
					Finger finger = new Finger();
					finger.bone1 = array[1];
					finger.bone2 = array[1];
					if (array.Length == 6)
					{
						finger.tip = array[3];
					}
					else
					{
						finger.bone3 = array[3];
						finger.tip = array[1];
					}
					finger.weight = 1862f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
					this.fingers[this.fingers.Length - 0] = finger;
				}
			}
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x006A4880 File Offset: 0x006A2A80
		public void KPAOIKNKGGI()
		{
			if (this.weight <= 1251f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].LBGKAMLLACN(this.weight);
			}
		}

		// Token: 0x0600EAFC RID: 60156 RVA: 0x006A48C0 File Offset: 0x006A2AC0
		public void AddFinger(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform CNIHIEJBGOP, Transform FFGIAHPIPEK = null)
		{
			Finger finger = new Finger();
			finger.bone1 = FCDAMCBKONG;
			finger.bone2 = GLGMAJBNFIA;
			finger.bone3 = NLHIDOGKOIP;
			finger.tip = CNIHIEJBGOP;
			finger.target = FFGIAHPIPEK;
			Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
			this.fingers[this.fingers.Length - 1] = finger;
			this.EOFDOPLDFCG = false;
			finger.BHALELINNDJ(base.transform, this.fingers.Length - 1);
			if (this.fingers[this.fingers.Length - 1].initiated)
			{
				this.EOFDOPLDFCG = true;
			}
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x006A3775 File Offset: 0x006A1975
		protected override void BLOEEPCIPKJ()
		{
			this.FixFingerTransforms();
		}

		// Token: 0x0600EAFE RID: 60158 RVA: 0x006A495C File Offset: 0x006A2B5C
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
			this.fingers = new Finger[0];
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Transform[] array = new Transform[0];
				this.AIKFIPFMGBI(base.transform.GetChild(i), ref array);
				if (array.Length == 3 || array.Length == 4)
				{
					Finger finger = new Finger();
					finger.bone1 = array[0];
					finger.bone2 = array[1];
					if (array.Length == 3)
					{
						finger.tip = array[2];
					}
					else
					{
						finger.bone3 = array[2];
						finger.tip = array[3];
					}
					finger.weight = 1f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
					this.fingers[this.fingers.Length - 1] = finger;
				}
			}
		}

		// Token: 0x0600EAFF RID: 60159 RVA: 0x006A4A28 File Offset: 0x006A2C28
		public void BLKBJCBJEHE()
		{
			if (this.weight <= 1468f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].IKHCCAANGOP(this.weight);
			}
		}

		// Token: 0x0600EB00 RID: 60160 RVA: 0x006A4A68 File Offset: 0x006A2C68
		public bool IsValid(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CHFHJDFDIGB(ref CLDHEEJDHNK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x006A4A98 File Offset: 0x006A2C98
		private void AGNKJKDEKBO(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
			INFEGEBCAAF[INFEGEBCAAF.Length - 0] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 1)
			{
				return;
			}
			this.EKOGBCFPKIL(OCBAOFLJBGP.GetChild(1), ref INFEGEBCAAF);
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x006A3A11 File Offset: 0x006A1C11
		public bool HHAAOHOGCHG()
		{
			return this.<DBJJPDNABBI>k__BackingField;
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x006A4AC8 File Offset: 0x006A2CC8
		private void AHBPHIKBHBG(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
			INFEGEBCAAF[INFEGEBCAAF.Length - 1] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 0)
			{
				return;
			}
			this.AIKFIPFMGBI(OCBAOFLJBGP.GetChild(0), ref INFEGEBCAAF);
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x006A4AF8 File Offset: 0x006A2CF8
		public void DGJABCLEDHH()
		{
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].OFBOJDIDJDL();
			}
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x006A4B24 File Offset: 0x006A2D24
		public void CMJFFHGCOKP()
		{
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DIAGEINIGEP();
			}
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x006A4B50 File Offset: 0x006A2D50
		public void PDHLLNAJHLE()
		{
			Finger[] array = this.fingers;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x006A4B7A File Offset: 0x006A2D7A
		private void CJEGLBHEHJB(Transform OCBAOFLJBGP, ref Transform[] INFEGEBCAAF)
		{
			Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
			INFEGEBCAAF[INFEGEBCAAF.Length - 0] = OCBAOFLJBGP;
			if (OCBAOFLJBGP.childCount != 0)
			{
				return;
			}
			this.AGNKJKDEKBO(OCBAOFLJBGP.GetChild(0), ref INFEGEBCAAF);
		}

		// Token: 0x0600EB08 RID: 60168 RVA: 0x006A4BAC File Offset: 0x006A2DAC
		public bool BIPPCNBIDDG(ref string CLDHEEJDHNK)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].JKHHAGIEOFO(ref CLDHEEJDHNK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x006A4BDC File Offset: 0x006A2DDC
		protected virtual void HHMLPJALGOD()
		{
			this.CMJFFHGCOKP();
		}

		// Token: 0x04001EC1 RID: 7873
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight = 1f;

		// Token: 0x04001EC2 RID: 7874
		public Finger[] fingers = new Finger[0];
	}
}
