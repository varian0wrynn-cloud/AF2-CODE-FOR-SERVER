using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200043D RID: 1085
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		// Token: 0x0600E948 RID: 59720 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool HBOOMFLDKAP()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x0069D4C0 File Offset: 0x0069B6C0
		public virtual void GICCCKDHMHJ()
		{
			if (this.weight <= 392f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.JAOFNGKGJHP())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x0069D578 File Offset: 0x0069B778
		public virtual void FJJPDDCBOEH()
		{
			if (this.weight <= 473f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.BMHNMGLFMKB())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E94B RID: 59723 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool JNJNLJFEOOP()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E94C RID: 59724 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool DJGELAPBGCK()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E94D RID: 59725 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool AJJHHHBDLOM()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool AFHPGABOAJB()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E94F RID: 59727 RVA: 0x0069D630 File Offset: 0x0069B830
		public virtual void DMOIOFJKHMN()
		{
			if (this.weight <= 963f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.LPKGLEBAPBG())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E950 RID: 59728 RVA: 0x0069D6E8 File Offset: 0x0069B8E8
		public virtual void KIOKBFOGPIG()
		{
			if (this.weight <= 1360f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.MJAMKIDLMDF())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E951 RID: 59729 RVA: 0x0069D7A0 File Offset: 0x0069B9A0
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
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.positionChanged)
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool IFEIDKOAFCO()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E953 RID: 59731 RVA: 0x0069D858 File Offset: 0x0069BA58
		public virtual void GMNBIAMDOJD()
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
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.OOLGMPPEOFJ())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E954 RID: 59732 RVA: 0x0069D21E File Offset: 0x0069B41E
		public ConstraintPositionOffset()
		{
		}

		// Token: 0x0600E955 RID: 59733 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool MBIAGOGAAAO()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E956 RID: 59734 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool JAOFNGKGJHP()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool PADNMINKFFG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E958 RID: 59736 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool PEGJLJBMJNA()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x0069D910 File Offset: 0x0069BB10
		public virtual void HEGKPLMFJFA()
		{
			if (this.weight <= 1477f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.LPKGLEBAPBG())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LFGCOGAJPAG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool BEEEEGJCMKF()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x0069D9C8 File Offset: 0x0069BBC8
		public virtual void NEMNGJBIHCA()
		{
			if (this.weight <= 1233f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.PEGJLJBMJNA())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x0069DA80 File Offset: 0x0069BC80
		public virtual void BHLLFGFNBPC()
		{
			if (this.weight <= 197f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.EACGECLKJAO())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool EONLOLCEKDA()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool EACGECLKJAO()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x0069DB38 File Offset: 0x0069BD38
		public virtual void PAHJMANJJNN()
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
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.JNJNLJFEOOP())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x0069DBF0 File Offset: 0x0069BDF0
		public virtual void HHLLJIGOOKB()
		{
			if (this.weight <= 230f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.KNJFNGKLACJ())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x0069DCA8 File Offset: 0x0069BEA8
		public virtual void DFAHGPMCMGD()
		{
			if (this.weight <= 1765f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.NCNINJPOOIH())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x0069DD60 File Offset: 0x0069BF60
		public virtual void AKKMPPGDFFP()
		{
			if (this.weight <= 462f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.KNJFNGKLACJ())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool MJAMKIDLMDF()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool BPIAAHDFMCP()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x0069DE18 File Offset: 0x0069C018
		public virtual void IJCFFGILIED()
		{
			if (this.weight <= 926f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.MJAMKIDLMDF())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool HALMBANKHED()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LPKGLEBAPBG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x0069DED0 File Offset: 0x0069C0D0
		public virtual void JNOMMFAEFMO()
		{
			if (this.weight <= 1314f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.positionChanged)
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x0069DF88 File Offset: 0x0069C188
		public virtual void LLEGICGILEK()
		{
			if (this.weight <= 1393f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.HOMGKFKHAGI())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool KNJFNGKLACJ()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LLLEBJFGLFI()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool CDLEIMDNEAA()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x0069E040 File Offset: 0x0069C240
		public virtual void BFMAGLCPLMC()
		{
			if (this.weight <= 72f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.JPJHBHLNAED())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool OOLGMPPEOFJ()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x0069CF0F File Offset: 0x0069B10F
		public ConstraintPositionOffset(Transform LPBDALAMAEM)
		{
			this.transform = LPBDALAMAEM;
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x0069E0F8 File Offset: 0x0069C2F8
		public virtual void DCOCKJDHIOH()
		{
			if (this.weight <= 1525f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.EACGECLKJAO())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool BMHNMGLFMKB()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E973 RID: 59763 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool HOMGKFKHAGI()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600E974 RID: 59764 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool positionChanged
		{
			get
			{
				return this.transform.localPosition != this.lastLocalPosition;
			}
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LBABFJNANIN()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool DHEDBJGOBHG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool NCNINJPOOIH()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool HLFFHFNJMDM()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E979 RID: 59769 RVA: 0x0069E1B0 File Offset: 0x0069C3B0
		public virtual void LBNAHMNDHCL()
		{
			if (this.weight <= 954f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.HALMBANKHED())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x0069E268 File Offset: 0x0069C468
		public virtual void PJGOPMDLGBP()
		{
			if (this.weight <= 1661f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.PEGJLJBMJNA())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool BJBDHJBDKOF()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool JAIALDOMOPG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool MKACFMALCNC()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool EPOCPGMLCMK()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LFLOJMKGPLG()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool LNIBFJCGAHJ()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x0069E320 File Offset: 0x0069C520
		public virtual void FEBDIKDNCPJ()
		{
			if (this.weight <= 1748f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.EACGECLKJAO())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x0069E3D8 File Offset: 0x0069C5D8
		public virtual void CGABFJJCDBF()
		{
			if (this.weight <= 1213f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.JPJHBHLNAED())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x0069E490 File Offset: 0x0069C690
		public virtual void JLPBAKNBGKP()
		{
			if (this.weight <= 1829f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.CDLEIMDNEAA())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x0069E548 File Offset: 0x0069C748
		public virtual void KLPCPIPGBBH()
		{
			if (this.weight <= 1456f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = false;
			}
			if (this.MKACFMALCNC())
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600E985 RID: 59781 RVA: 0x0069D4A6 File Offset: 0x0069B6A6
		private bool JPJHBHLNAED()
		{
			return this.transform.localPosition != this.lastLocalPosition;
		}

		// Token: 0x04001EA4 RID: 7844
		public Vector3 offset;

		// Token: 0x04001EA5 RID: 7845
		private Vector3 defaultLocalPosition;

		// Token: 0x04001EA6 RID: 7846
		private Vector3 lastLocalPosition;

		// Token: 0x04001EA7 RID: 7847
		private bool initiated;
	}
}
