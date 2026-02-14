using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200043F RID: 1087
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		// Token: 0x0600E9B8 RID: 59832 RVA: 0x0069F180 File Offset: 0x0069D380
		public virtual void IJCFFGILIED()
		{
			if (this.weight <= 1394f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.KEDLEPMEJFN())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool JAOEKHAMOKD()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool HMEDDGBPFLI()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x0069F250 File Offset: 0x0069D450
		public virtual void PJGOPMDLGBP()
		{
			if (this.weight <= 330f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.ABLHPIPMJKI())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x0069F308 File Offset: 0x0069D508
		public virtual void FHKLMMDLFEK()
		{
			if (this.weight <= 1984f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.MPEKGGBECKN())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x0069F3C0 File Offset: 0x0069D5C0
		public virtual void BCGDGBPCDPI()
		{
			if (this.weight <= 540f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.KNJNEPPKFJN())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool IDFAFKBIJGO()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x0069F478 File Offset: 0x0069D678
		public virtual void AKKMPPGDFFP()
		{
			if (this.weight <= 1320f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.DEANHCJIFIF())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x0069F530 File Offset: 0x0069D730
		public virtual void JCACDJOHENM()
		{
			if (this.weight <= 1241f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.BBOJPDBPINE())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9C1 RID: 59841 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool LNNCPPFJKBC()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9C2 RID: 59842 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool ILAPAKBFGNH()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9C3 RID: 59843 RVA: 0x0069F5E8 File Offset: 0x0069D7E8
		public virtual void IBHOGHGMIKI()
		{
			if (this.weight <= 41f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.PBCEHBMLNKH())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9C4 RID: 59844 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool POPJLOHCJJG()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x0069F6A0 File Offset: 0x0069D8A0
		public virtual void GICCCKDHMHJ()
		{
			if (this.weight <= 685f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.MBHGPHMIFKE())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool OJNJPMOFPFI()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool IGHJKHPCGJH()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x0069F758 File Offset: 0x0069D958
		public virtual void CACBPCBPNOO()
		{
			if (this.weight <= 617f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.ABLHPIPMJKI())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool BBOJPDBPINE()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9CA RID: 59850 RVA: 0x0069F810 File Offset: 0x0069DA10
		public virtual void MFEJFMPCCPD()
		{
			if (this.weight <= 1002f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.FJEBJJDMDOB())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9CB RID: 59851 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool ABCJPOGLBMK()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9CC RID: 59852 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool BKBOLNLMMMK()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool CFPDGDFEBKG()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x0069CF0F File Offset: 0x0069B10F
		public ConstraintRotationOffset(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
		}

		// Token: 0x0600E9CF RID: 59855 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool HPLDLPFHBCK()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x0069F8C8 File Offset: 0x0069DAC8
		public virtual void GDLOJCEOFBD()
		{
			if (this.weight <= 1146f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.CPBCBJAFJAP())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x0069D21E File Offset: 0x0069B41E
		public ConstraintRotationOffset()
		{
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool HKIEKADNBNI()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x0069F980 File Offset: 0x0069DB80
		public virtual void IJNCLMDLNOH()
		{
			if (this.weight <= 842f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.DEANHCJIFIF())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x0069FA38 File Offset: 0x0069DC38
		public virtual void BFMAGLCPLMC()
		{
			if (this.weight <= 1918f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.BKBOLNLMMMK())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x0069FAF0 File Offset: 0x0069DCF0
		public virtual void NKGAPBIJIHH()
		{
			if (this.weight <= 1898f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.GBPMNKBDDMB())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool GAKBKDPHKPO()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool MPEKGGBECKN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool NCJFGONFEBK()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9D9 RID: 59865 RVA: 0x0069FBA8 File Offset: 0x0069DDA8
		public virtual void MDGCGGKMPFP()
		{
			if (this.weight <= 1176f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.CFGIMPIEHED())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool MBHGPHMIFKE()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9DB RID: 59867 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool KEDLEPMEJFN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9DC RID: 59868 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool BNHODDIBKCA()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9DD RID: 59869 RVA: 0x0069FC60 File Offset: 0x0069DE60
		public virtual void CMMDLNHJAFN()
		{
			if (this.weight <= 84f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.HPLDLPFHBCK())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9DE RID: 59870 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool EANPCIKHNEL()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9DF RID: 59871 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool HCPIDHAEJKO()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E0 RID: 59872 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool DEANHCJIFIF()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool CPBCBJAFJAP()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x0069FD18 File Offset: 0x0069DF18
		public override void CBJIKGNFCJI()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.rotationChanged)
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool MMPPDHEHLDM()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool FEFKCIJNJMK()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool KNJNEPPKFJN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x0069FDD0 File Offset: 0x0069DFD0
		public virtual void FJLELHJBOKO()
		{
			if (this.weight <= 891f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.KLEEPBGMPMH())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool CFGIMPIEHED()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool ABLHPIPMJKI()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool KLDNKMAPGMN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9EA RID: 59882 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool LFNOFMCEIBJ()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9EB RID: 59883 RVA: 0x0069FE88 File Offset: 0x0069E088
		public virtual void FKECLPMIMDN()
		{
			if (this.weight <= 1454f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.HMEDDGBPFLI())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9EC RID: 59884 RVA: 0x0069FF40 File Offset: 0x0069E140
		public virtual void JNOMMFAEFMO()
		{
			if (this.weight <= 955f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.CFPDGDFEBKG())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9ED RID: 59885 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool GNCAHBBDNJN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool IONMAEPADKO()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool rotationChanged
		{
			get
			{
				return this.transform.localRotation != this.lastLocalRotation;
			}
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x0069FFF8 File Offset: 0x0069E1F8
		public virtual void DFAHGPMCMGD()
		{
			if (this.weight <= 1842f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.ILAPAKBFGNH())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F1 RID: 59889 RVA: 0x006A00B0 File Offset: 0x0069E2B0
		public virtual void LBLPMEEHJKK()
		{
			if (this.weight <= 1242f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.KLEEPBGMPMH())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F2 RID: 59890 RVA: 0x006A0168 File Offset: 0x0069E368
		public virtual void CKEHKIFKBFF()
		{
			if (this.weight <= 855f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.HPLDLPFHBCK())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F3 RID: 59891 RVA: 0x006A0220 File Offset: 0x0069E420
		public virtual void MHHNDKIEEAO()
		{
			if (this.weight <= 1998f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.CPBCBJAFJAP())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F4 RID: 59892 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool AEGCANNPIKI()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool IANCJOCJNIM()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x006A02D8 File Offset: 0x0069E4D8
		public virtual void BHLLFGFNBPC()
		{
			if (this.weight <= 337f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.PPECCAMKDDB())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F7 RID: 59895 RVA: 0x006A0390 File Offset: 0x0069E590
		public virtual void CDOHBHBHEGM()
		{
			if (this.weight <= 1262f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.ABLHPIPMJKI())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool FJEBJJDMDOB()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x006A0448 File Offset: 0x0069E648
		public virtual void KDJDLIFKBKD()
		{
			if (this.weight <= 1897f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.FCMAHBCOKEH())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool PPECCAMKDDB()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9FB RID: 59899 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool GBPMNKBDDMB()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9FC RID: 59900 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool PBCEHBMLNKH()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9FD RID: 59901 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool KLEEPBGMPMH()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x006A0500 File Offset: 0x0069E700
		public virtual void NLIKHMMBGCO()
		{
			if (this.weight <= 1507f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.ABCJPOGLBMK())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600E9FF RID: 59903 RVA: 0x006A05B8 File Offset: 0x0069E7B8
		public virtual void GDPIDEINIAE()
		{
			if (this.weight <= 444f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.KEDLEPMEJFN())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool FCMAHBCOKEH()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x0600EA01 RID: 59905 RVA: 0x006A0670 File Offset: 0x0069E870
		public virtual void FJJPDDCBOEH()
		{
			if (this.weight <= 1791f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = false;
			}
			if (this.CFGIMPIEHED())
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x0600EA02 RID: 59906 RVA: 0x0069F237 File Offset: 0x0069D437
		private bool LNJKHPEIFEN()
		{
			return this.transform.localRotation != this.lastLocalRotation;
		}

		// Token: 0x04001EA9 RID: 7849
		public Quaternion offset;

		// Token: 0x04001EAA RID: 7850
		private Quaternion defaultRotation;

		// Token: 0x04001EAB RID: 7851
		private Quaternion defaultLocalRotation;

		// Token: 0x04001EAC RID: 7852
		private Quaternion lastLocalRotation;

		// Token: 0x04001EAD RID: 7853
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x04001EAE RID: 7854
		private bool initiated;
	}
}
