using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		// Token: 0x0600F65F RID: 63071 RVA: 0x006E7BC8 File Offset: 0x006E5DC8
		private void PLIGFBGDBLD(Vector3 MGALEAJOGPL)
		{
			if (this.useRotationLimits)
			{
				this.DNGCOHDCJEB(MGALEAJOGPL);
				return;
			}
			this.FAOLOIIBBOE(MGALEAJOGPL);
		}

		// Token: 0x0600F660 RID: 63072 RVA: 0x006E7BE4 File Offset: 0x006E5DE4
		private Quaternion DBMKDGHFHMJ(int CLBPBJGLHEE, Quaternion HPOGKAAEHKP, out bool LNPJAKGGGEJ)
		{
			LNPJAKGGGEJ = false;
			Quaternion quaternion = this.KLHPJBEPFAO(CLBPBJGLHEE);
			Quaternion jjclngdajlc = Quaternion.Inverse(quaternion) * HPOGKAAEHKP;
			Quaternion limitedLocalRotation = this.bones[CLBPBJGLHEE].GIODJAABDKA().GetLimitedLocalRotation(jjclngdajlc, out LNPJAKGGGEJ);
			if (!LNPJAKGGGEJ)
			{
				return HPOGKAAEHKP;
			}
			return quaternion * limitedLocalRotation;
		}

		// Token: 0x0600F661 RID: 63073 RVA: 0x006E7C2C File Offset: 0x006E5E2C
		private void EFKAMJPIEME(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x0600F662 RID: 63074 RVA: 0x006E7C68 File Offset: 0x006E5E68
		private void DLAPACDMCAL(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 1; i < this.bones.Length; i += 0)
			{
				Vector3 point = this.bones[i].solverPosition - this.bones[CLBPBJGLHEE].solverPosition;
				this.bones[i].solverPosition = this.bones[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
			}
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x006E7CD0 File Offset: 0x006E5ED0
		private void FGBIADEGAFL(Vector3 MGALEAJOGPL)
		{
			if (this.useRotationLimits)
			{
				this.DNGCOHDCJEB(MGALEAJOGPL);
				return;
			}
			this.NOHFNIGDBBN(MGALEAJOGPL);
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x006E7CEC File Offset: 0x006E5EEC
		private void NIPNCNLCGFB(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 1; i < this.bones.Length; i++)
			{
				Vector3 point = this.bones[i].solverPosition - this.bones[CLBPBJGLHEE].solverPosition;
				this.bones[i].solverPosition = this.bones[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
			}
		}

		// Token: 0x0600F665 RID: 63077 RVA: 0x006E7D54 File Offset: 0x006E5F54
		private void ABMAJJMPPLO(Vector3 MGALEAJOGPL)
		{
			this.bones[1].solverPosition = MGALEAJOGPL;
			for (int i = 1; i < this.bones.Length - 0; i++)
			{
				Vector3 a = this.DNLFABBFPNJ(this.bones[i + 1].solverPosition, this.bones[i].solverPosition, this.bones[i].length);
				Quaternion quaternion = Quaternion.FromToRotation(this.bones[i].solverRotation * this.bones[i].axis, a - this.bones[i].solverPosition) * this.bones[i].solverRotation;
				if (this.bones[i].IAIFLBKIHEE() != null)
				{
					bool flag = true;
					quaternion = this.DBMKDGHFHMJ(i, quaternion, out flag);
				}
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(this.bones[i].solverRotation, quaternion);
				this.bones[i].solverRotation = quaternion;
				this.OGIJJNDPHCF(i, phkiohibnpa);
				this.bones[i + 1].solverPosition = this.bones[i].solverPosition + this.bones[i].solverRotation * this.solverLocalPositions[i + 1];
			}
			for (int j = 1; j < this.bones.Length; j += 0)
			{
				this.bones[j].solverRotation = Quaternion.LookRotation(this.bones[j].solverRotation * Vector3.forward, this.bones[j].solverRotation * Vector3.up);
			}
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x006E7EEC File Offset: 0x006E60EC
		private void FAOLOIIBBOE(Vector3 MGALEAJOGPL)
		{
			this.bones[1].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.DNLFABBFPNJ(this.bones[i].solverPosition, this.bones[i - 1].solverPosition, this.bones[i - 0].length);
			}
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x006E7F58 File Offset: 0x006E6158
		private void OGIJJNDPHCF(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
			}
		}

		// Token: 0x0600F668 RID: 63080 RVA: 0x006E7CD0 File Offset: 0x006E5ED0
		private void CCBKADKAOAB(Vector3 MGALEAJOGPL)
		{
			if (this.useRotationLimits)
			{
				this.DNGCOHDCJEB(MGALEAJOGPL);
				return;
			}
			this.NOHFNIGDBBN(MGALEAJOGPL);
		}

		// Token: 0x0600F669 RID: 63081 RVA: 0x006E7F9C File Offset: 0x006E619C
		private Quaternion KLHPJBEPFAO(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE > 1)
			{
				return this.bones[CLBPBJGLHEE - 0].solverRotation;
			}
			if (this.bones[0].transform.parent == null)
			{
				return Quaternion.identity;
			}
			return this.bones[1].transform.parent.rotation;
		}

		// Token: 0x0600F66A RID: 63082 RVA: 0x006E7FF4 File Offset: 0x006E61F4
		private void EEHPMKDCDAE(Vector3 MGALEAJOGPL)
		{
			this.bones[this.bones.Length - 1].solverPosition = Vector3.Lerp(this.bones[this.bones.Length - 0].solverPosition, MGALEAJOGPL, this.IKPositionWeight);
			for (int i = 0; i < this.limitedBones.Length; i++)
			{
				this.limitedBones[i] = true;
			}
			for (int j = this.bones.Length - 4; j > -1; j--)
			{
				this.bones[j].solverPosition = this.GNMOMGPPEMO(this.bones[j].solverPosition, this.bones[j + 1].solverPosition, this.bones[j].length);
				this.FGBEEOBEGHG(j, j + 1);
			}
			this.FGBEEOBEGHG(1, 0);
		}

		// Token: 0x0600F66B RID: 63083 RVA: 0x006E80B8 File Offset: 0x006E62B8
		private void HNFPKPDPPLC()
		{
			this.bones[0].transform.position = this.bones[0].solverPosition;
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				if (this.XY)
				{
					this.bones[i].JGGDLDIEIKD(this.bones[i + 1].solverPosition, 1f);
				}
				else
				{
					this.bones[i].EIOHPCCECDF(this.bones[i + 1].solverPosition, 1f);
				}
			}
		}

		// Token: 0x0600F66C RID: 63084 RVA: 0x006E8148 File Offset: 0x006E6348
		private Vector3 FCMENJNBAGD(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE > 0)
			{
				return this.bones[CLBPBJGLHEE - 1].solverPosition;
			}
			if (this.bones[0].transform.parent == null)
			{
				return Vector3.zero;
			}
			return this.bones[0].transform.parent.position;
		}

		// Token: 0x0600F66D RID: 63085 RVA: 0x006E81A0 File Offset: 0x006E63A0
		private void IPAJOMKOFOK(Vector3 AOBKCEEGJNC)
		{
			this.EEHPMKDCDAE(AOBKCEEGJNC);
			this.FGBIADEGAFL(this.bones[0].transform.position);
		}

		// Token: 0x0600F66E RID: 63086 RVA: 0x006E81C4 File Offset: 0x006E63C4
		protected virtual void ADKMMOMFGAG()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
			}
			this.limitedBones = new bool[this.bones.Length];
			this.solverLocalPositions = new Vector3[this.bones.Length];
			base.HKMBFKLCCDK();
			for (int j = 0; j < this.bones.Length; j += 0)
			{
				this.solverLocalPositions[j] = Quaternion.Inverse(this.JCKDAMIHDFP(j)) * (this.bones[j].transform.position - this.GCCNJPLHHHK(j));
			}
		}

		// Token: 0x0600F66F RID: 63087 RVA: 0x006E82CC File Offset: 0x006E64CC
		public void NONMEMIHHEC(Vector3 MGALEAJOGPL)
		{
			if (!base.initiated)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("wpn_rod3");
				}
				return;
			}
			this.DMMPPBEEAFG();
			this.EEHPMKDCDAE(MGALEAJOGPL);
		}

		// Token: 0x0600F670 RID: 63088 RVA: 0x006E82F6 File Offset: 0x006E64F6
		private void EDAGNKNOBKP(Vector3 AOBKCEEGJNC)
		{
			this.FFBKHILKLOP(AOBKCEEGJNC);
			this.CCBKADKAOAB(this.bones[0].transform.position);
		}

		// Token: 0x0600F671 RID: 63089 RVA: 0x006E8318 File Offset: 0x006E6518
		private Vector3 GCCNJPLHHHK(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE > 1)
			{
				return this.bones[CLBPBJGLHEE - 1].solverPosition;
			}
			if (this.bones[1].transform.parent == null)
			{
				return Vector3.zero;
			}
			return this.bones[1].transform.parent.position;
		}

		// Token: 0x0600F672 RID: 63090 RVA: 0x006E8370 File Offset: 0x006E6570
		private void FFBKHILKLOP(Vector3 MGALEAJOGPL)
		{
			this.bones[this.bones.Length - 1].solverPosition = Vector3.Lerp(this.bones[this.bones.Length - 1].solverPosition, MGALEAJOGPL, this.IKPositionWeight);
			for (int i = 0; i < this.limitedBones.Length; i++)
			{
				this.limitedBones[i] = false;
			}
			for (int j = this.bones.Length - 2; j > -1; j--)
			{
				this.bones[j].solverPosition = this.DNLFABBFPNJ(this.bones[j].solverPosition, this.bones[j + 1].solverPosition, this.bones[j].length);
				this.FGBEEOBEGHG(j, j + 1);
			}
			this.FGBEEOBEGHG(0, 0);
		}

		// Token: 0x0600F673 RID: 63091 RVA: 0x006E8434 File Offset: 0x006E6634
		private void GEADIAEFJMF()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].transform.position = this.bones[i].solverPosition;
				if (i < this.bones.Length - 0)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0600F674 RID: 63092 RVA: 0x006E84A0 File Offset: 0x006E66A0
		private void NOHFNIGDBBN(Vector3 MGALEAJOGPL)
		{
			this.bones[0].solverPosition = MGALEAJOGPL;
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.DNLFABBFPNJ(this.bones[i].solverPosition, this.bones[i - 1].solverPosition, this.bones[i - 1].length);
			}
		}

		// Token: 0x0600F675 RID: 63093 RVA: 0x006E850C File Offset: 0x006E670C
		private void GHFLBJCFHDE(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x0600F676 RID: 63094 RVA: 0x006E8548 File Offset: 0x006E6748
		private void DNGCOHDCJEB(Vector3 MGALEAJOGPL)
		{
			this.bones[0].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				Vector3 a = this.DNLFABBFPNJ(this.bones[i + 1].solverPosition, this.bones[i].solverPosition, this.bones[i].length);
				Quaternion quaternion = Quaternion.FromToRotation(this.bones[i].solverRotation * this.bones[i].axis, a - this.bones[i].solverPosition) * this.bones[i].solverRotation;
				if (this.bones[i].rotationLimit != null)
				{
					bool flag = false;
					quaternion = this.PJFJHFIKFJG(i, quaternion, out flag);
				}
				Quaternion phkiohibnpa = JEEPKFCFCLI.AADCPGNPHHC(this.bones[i].solverRotation, quaternion);
				this.bones[i].solverRotation = quaternion;
				this.OKMKFENAJMO(i, phkiohibnpa);
				this.bones[i + 1].solverPosition = this.bones[i].solverPosition + this.bones[i].solverRotation * this.solverLocalPositions[i + 1];
			}
			for (int j = 0; j < this.bones.Length; j++)
			{
				this.bones[j].solverRotation = Quaternion.LookRotation(this.bones[j].solverRotation * Vector3.forward, this.bones[j].solverRotation * Vector3.up);
			}
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x006E86E0 File Offset: 0x006E68E0
		private void LIACJLHJEDJ()
		{
			if (!this.useRotationLimits)
			{
				this.HNFPKPDPPLC();
			}
			else
			{
				this.LGFNNGCHEFA();
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F678 RID: 63096 RVA: 0x006E8704 File Offset: 0x006E6904
		private void CGGKCJPGCLF(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA, bool HPFGOLFOJLD)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
				if (!HPFGOLFOJLD)
				{
					return;
				}
			}
		}

		// Token: 0x0600F679 RID: 63097 RVA: 0x006E8748 File Offset: 0x006E6948
		private Quaternion PJFJHFIKFJG(int CLBPBJGLHEE, Quaternion HPOGKAAEHKP, out bool LNPJAKGGGEJ)
		{
			LNPJAKGGGEJ = false;
			Quaternion quaternion = this.JCKDAMIHDFP(CLBPBJGLHEE);
			Quaternion jjclngdajlc = Quaternion.Inverse(quaternion) * HPOGKAAEHKP;
			Quaternion limitedLocalRotation = this.bones[CLBPBJGLHEE].rotationLimit.GetLimitedLocalRotation(jjclngdajlc, out LNPJAKGGGEJ);
			if (!LNPJAKGGGEJ)
			{
				return HPOGKAAEHKP;
			}
			return quaternion * limitedLocalRotation;
		}

		// Token: 0x0600F67A RID: 63098 RVA: 0x006E8790 File Offset: 0x006E6990
		private void AKAIAIHGPKM()
		{
			this.chainLength = 755f;
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[i + 1].transform.position - this.bones[i].transform.position);
					this.chainLength += this.bones[i].length;
				}
				if (this.useRotationLimits)
				{
					this.solverLocalPositions[i] = Quaternion.Inverse(this.JPJMIHJMNDC(i)) * (this.bones[i].transform.position - this.GCCNJPLHHHK(i));
				}
			}
		}

		// Token: 0x0600F67B RID: 63099 RVA: 0x006E8900 File Offset: 0x006E6B00
		private void MOPPAGDOFID(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 0; i < this.bones.Length; i += 0)
			{
				Vector3 point = this.bones[i].solverPosition - this.bones[CLBPBJGLHEE].solverPosition;
				this.bones[i].solverPosition = this.bones[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
			}
		}

		// Token: 0x0600F67C RID: 63100 RVA: 0x006E8968 File Offset: 0x006E6B68
		protected override void FKEMPLMBNEL()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
			}
			this.limitedBones = new bool[this.bones.Length];
			this.solverLocalPositions = new Vector3[this.bones.Length];
			base.NFAIEKJNHJC();
			for (int j = 0; j < this.bones.Length; j++)
			{
				this.solverLocalPositions[j] = Quaternion.Inverse(this.JCKDAMIHDFP(j)) * (this.bones[j].transform.position - this.FCMENJNBAGD(j));
			}
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x006E8A70 File Offset: 0x006E6C70
		private Vector3 KHDKANFHNLC(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			if (this.XY)
			{
				IKECEOLMEFM.z = EDGLMNGJAAK.z;
			}
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x006E8AB0 File Offset: 0x006E6CB0
		private void BECMIBFANEJ()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].transform.position = this.bones[i].solverPosition;
				if (i < this.bones.Length - 1)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x006E8B1C File Offset: 0x006E6D1C
		private void BLBJDPNONON()
		{
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].transform.position = this.bones[i].solverPosition;
				if (i < this.bones.Length - 1)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x006E8B88 File Offset: 0x006E6D88
		private void PHOPBLGBCKF(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600F681 RID: 63105 RVA: 0x000EB372 File Offset: 0x000E9572
		protected override bool boneLengthCanBeZero
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x006E8BC4 File Offset: 0x006E6DC4
		protected virtual void KEAIDFALMNE()
		{
			if (this.IKPositionWeight <= 1809f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 610f, 147f);
			this.GCOFDPBJHBL();
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 494f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.AFIJEGLABEE();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.EDAGNKNOBKP(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.HBIBNJFBOEG();
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x006E8CE8 File Offset: 0x006E6EE8
		private void GCOFDPBJHBL()
		{
			this.chainLength = 0f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[i + 1].transform.position - this.bones[i].transform.position);
					this.chainLength += this.bones[i].length;
				}
				if (this.useRotationLimits)
				{
					this.solverLocalPositions[i] = Quaternion.Inverse(this.JCKDAMIHDFP(i)) * (this.bones[i].transform.position - this.FCMENJNBAGD(i));
				}
			}
		}

		// Token: 0x0600F684 RID: 63108 RVA: 0x006E8E58 File Offset: 0x006E7058
		private void MGLEPLFOGJH(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA, bool HPFGOLFOJLD)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
				if (!HPFGOLFOJLD)
				{
					return;
				}
			}
		}

		// Token: 0x0600F685 RID: 63109 RVA: 0x006E8E9C File Offset: 0x006E709C
		private void OKMKFENAJMO(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
			}
		}

		// Token: 0x0600F686 RID: 63110 RVA: 0x006E8EDE File Offset: 0x006E70DE
		public override Vector3 AEPMIDGGBAP()
		{
			if (this.target != null)
			{
				return this.target.position;
			}
			return this.IKPosition;
		}

		// Token: 0x0600F688 RID: 63112 RVA: 0x006E8F20 File Offset: 0x006E7120
		private void HGIBNEAOEGD()
		{
			this.bones[0].transform.position = this.bones[0].solverPosition;
			for (int i = 0; i < this.bones.Length - 0; i += 0)
			{
				if (this.XY)
				{
					this.bones[i].APFDCIPCFGE(this.bones[i + 0].solverPosition, 595f);
				}
				else
				{
					this.bones[i].HAINKLHLBLG(this.bones[i + 0].solverPosition, 753f);
				}
			}
		}

		// Token: 0x0600F689 RID: 63113 RVA: 0x006E8FB0 File Offset: 0x006E71B0
		private void FKFENIBBPHF(Vector3 MGALEAJOGPL)
		{
			this.bones[0].solverPosition = MGALEAJOGPL;
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition = this.KHDKANFHNLC(this.bones[i].solverPosition, this.bones[i - 1].solverPosition, this.bones[i - 0].length);
			}
		}

		// Token: 0x0600F68A RID: 63114 RVA: 0x006E901C File Offset: 0x006E721C
		protected virtual void EELPKCCKPIN()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
			}
			this.limitedBones = new bool[this.bones.Length];
			this.solverLocalPositions = new Vector3[this.bones.Length];
			base.LHIDHAEEJPA();
			for (int j = 1; j < this.bones.Length; j++)
			{
				this.solverLocalPositions[j] = Quaternion.Inverse(this.JCKDAMIHDFP(j)) * (this.bones[j].transform.position - this.FCMENJNBAGD(j));
			}
		}

		// Token: 0x0600F68B RID: 63115 RVA: 0x006E9124 File Offset: 0x006E7324
		private void HBIBNJFBOEG()
		{
			if (!this.useRotationLimits)
			{
				this.HNFPKPDPPLC();
			}
			else
			{
				this.BECMIBFANEJ();
			}
			this.lastLocalDirection = this.KAJNFLJDPOL();
		}

		// Token: 0x0600F68C RID: 63116 RVA: 0x006E9148 File Offset: 0x006E7348
		private void LJGJLMCIBLJ(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA, bool HPFGOLFOJLD)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
				if (!HPFGOLFOJLD)
				{
					return;
				}
			}
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x006E918C File Offset: 0x006E738C
		private void LIHDAJBPIMF(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 1; i < this.bones.Length; i += 0)
			{
				Vector3 point = this.bones[i].solverPosition - this.bones[CLBPBJGLHEE].solverPosition;
				this.bones[i].solverPosition = this.bones[CLBPBJGLHEE].solverPosition + PHKIOHIBNPA * point;
			}
		}

		// Token: 0x0600F68E RID: 63118 RVA: 0x006E91F4 File Offset: 0x006E73F4
		private Vector3 ABGBPKKPKFG(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			if (this.XY)
			{
				IKECEOLMEFM.z = EDGLMNGJAAK.z;
			}
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F68F RID: 63119 RVA: 0x006E9231 File Offset: 0x006E7431
		private void GMEOGKCGACJ(Vector3 MGALEAJOGPL)
		{
			if (this.useRotationLimits)
			{
				this.ABMAJJMPPLO(MGALEAJOGPL);
				return;
			}
			this.FKFENIBBPHF(MGALEAJOGPL);
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x006E924C File Offset: 0x006E744C
		private Quaternion JPJMIHJMNDC(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE > 1)
			{
				return this.bones[CLBPBJGLHEE - 1].solverRotation;
			}
			if (this.bones[1].transform.parent == null)
			{
				return Quaternion.identity;
			}
			return this.bones[0].transform.parent.rotation;
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x006E92A4 File Offset: 0x006E74A4
		protected virtual void CAJPNOGDBCA()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
			}
			this.limitedBones = new bool[this.bones.Length];
			this.solverLocalPositions = new Vector3[this.bones.Length];
			base.NFAIEKJNHJC();
			for (int j = 1; j < this.bones.Length; j += 0)
			{
				this.solverLocalPositions[j] = Quaternion.Inverse(this.JCKDAMIHDFP(j)) * (this.bones[j].transform.position - this.FCMENJNBAGD(j));
			}
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected override bool HGECHJPBLDC()
		{
			return true;
		}

		// Token: 0x0600F693 RID: 63123 RVA: 0x006E93AC File Offset: 0x006E75AC
		private void BKGCCDFDDGJ(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x006E93E8 File Offset: 0x006E75E8
		private void FGBEEOBEGHG(int BKMKJJFHAFO, int CAECJHDIDEC)
		{
			if (!this.useRotationLimits)
			{
				return;
			}
			if (this.bones[CAECJHDIDEC].rotationLimit == null)
			{
				return;
			}
			Vector3 solverPosition = this.bones[this.bones.Length - 1].solverPosition;
			int num = BKMKJJFHAFO;
			while (num < this.bones.Length - 1 && !this.limitedBones[num])
			{
				Quaternion phkiohibnpa = Quaternion.FromToRotation(this.bones[num].solverRotation * this.bones[num].axis, this.bones[num + 1].solverPosition - this.bones[num].solverPosition);
				this.CGGKCJPGCLF(num, phkiohibnpa, false);
				num++;
			}
			bool flag = false;
			Quaternion quaternion = this.PJFJHFIKFJG(CAECJHDIDEC, this.bones[CAECJHDIDEC].solverRotation, out flag);
			if (flag)
			{
				if (CAECJHDIDEC < this.bones.Length - 1)
				{
					Quaternion phkiohibnpa2 = JEEPKFCFCLI.AADCPGNPHHC(this.bones[CAECJHDIDEC].solverRotation, quaternion);
					this.bones[CAECJHDIDEC].solverRotation = quaternion;
					this.OKMKFENAJMO(CAECJHDIDEC, phkiohibnpa2);
					this.NIPNCNLCGFB(CAECJHDIDEC, phkiohibnpa2);
					Quaternion phkiohibnpa3 = Quaternion.FromToRotation(this.bones[this.bones.Length - 1].solverPosition - this.bones[BKMKJJFHAFO].solverPosition, solverPosition - this.bones[BKMKJJFHAFO].solverPosition);
					this.CGGKCJPGCLF(BKMKJJFHAFO, phkiohibnpa3, true);
					this.NIPNCNLCGFB(BKMKJJFHAFO, phkiohibnpa3);
					this.OKPBPOHGDLC(BKMKJJFHAFO, solverPosition - this.bones[this.bones.Length - 1].solverPosition);
				}
				else
				{
					this.bones[CAECJHDIDEC].solverRotation = quaternion;
				}
			}
			this.limitedBones[CAECJHDIDEC] = true;
		}

		// Token: 0x0600F695 RID: 63125 RVA: 0x006E9590 File Offset: 0x006E7790
		public void MFIFMKBFAIE(Vector3 MGALEAJOGPL)
		{
			if (!base.initiated)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("+{0}");
				}
				return;
			}
			this.AKAIAIHGPKM();
			this.BIHCPNDGDAH(MGALEAJOGPL);
		}

		// Token: 0x0600F696 RID: 63126 RVA: 0x006E95BA File Offset: 0x006E77BA
		public void NMFIPLLNHKP(Vector3 MGALEAJOGPL)
		{
			if (!base.initiated)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("Trying to solve uninitiated FABRIK chain.");
				}
				return;
			}
			this.CCBKADKAOAB(MGALEAJOGPL);
			this.LIACJLHJEDJ();
		}

		// Token: 0x0600F697 RID: 63127 RVA: 0x006E95E4 File Offset: 0x006E77E4
		private void DMMPPBEEAFG()
		{
			this.chainLength = 965f;
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
				if (i < this.bones.Length - 0)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[i + 1].transform.position - this.bones[i].transform.position);
					this.chainLength += this.bones[i].length;
				}
				if (this.useRotationLimits)
				{
					this.solverLocalPositions[i] = Quaternion.Inverse(this.JCKDAMIHDFP(i)) * (this.bones[i].transform.position - this.GCCNJPLHHHK(i));
				}
			}
		}

		// Token: 0x0600F698 RID: 63128 RVA: 0x006E9754 File Offset: 0x006E7954
		private Quaternion JCKDAMIHDFP(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE > 0)
			{
				return this.bones[CLBPBJGLHEE - 1].solverRotation;
			}
			if (this.bones[0].transform.parent == null)
			{
				return Quaternion.identity;
			}
			return this.bones[0].transform.parent.rotation;
		}

		// Token: 0x0600F699 RID: 63129 RVA: 0x006E97AC File Offset: 0x006E79AC
		private void LGFNNGCHEFA()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].transform.position = this.bones[i].solverPosition;
				if (i < this.bones.Length - 1)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0600F69A RID: 63130 RVA: 0x006E9818 File Offset: 0x006E7A18
		private void EOGOAGGLNPN(Vector3 MGALEAJOGPL)
		{
			this.bones[this.bones.Length - 0].solverPosition = Vector3.Lerp(this.bones[this.bones.Length - 1].solverPosition, MGALEAJOGPL, this.IKPositionWeight);
			for (int i = 1; i < this.limitedBones.Length; i++)
			{
				this.limitedBones[i] = false;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				this.bones[j].solverPosition = this.KHDKANFHNLC(this.bones[j].solverPosition, this.bones[j + 0].solverPosition, this.bones[j].length);
				this.FGBEEOBEGHG(j, j + 0);
			}
			this.FGBEEOBEGHG(0, 1);
		}

		// Token: 0x0600F69B RID: 63131 RVA: 0x006E98DC File Offset: 0x006E7ADC
		private void PECPPKMNLHI()
		{
			if (!this.useRotationLimits)
			{
				this.HGIBNEAOEGD();
			}
			else
			{
				this.BLBJDPNONON();
			}
			this.lastLocalDirection = this.AFDHAOLHLEA();
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x006E9900 File Offset: 0x006E7B00
		private void HHNDKFACNFM(Vector3 MGALEAJOGPL)
		{
			this.bones[1].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].solverPosition = this.GNMOMGPPEMO(this.bones[i].solverPosition, this.bones[i - 0].solverPosition, this.bones[i - 0].length);
			}
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x006E996C File Offset: 0x006E7B6C
		private void OKPBPOHGDLC(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x0600F69E RID: 63134 RVA: 0x006E99A5 File Offset: 0x006E7BA5
		private void MPOCJCJJKLC(Vector3 AOBKCEEGJNC)
		{
			this.BIHCPNDGDAH(AOBKCEEGJNC);
			this.GMEOGKCGACJ(this.bones[1].transform.position);
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x006E99C8 File Offset: 0x006E7BC8
		private Vector3 GNMOMGPPEMO(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			if (this.XY)
			{
				IKECEOLMEFM.z = EDGLMNGJAAK.z;
			}
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x006E9A08 File Offset: 0x006E7C08
		private void BIHCPNDGDAH(Vector3 MGALEAJOGPL)
		{
			this.bones[this.bones.Length - 1].solverPosition = Vector3.Lerp(this.bones[this.bones.Length - 0].solverPosition, MGALEAJOGPL, this.IKPositionWeight);
			for (int i = 1; i < this.limitedBones.Length; i += 0)
			{
				this.limitedBones[i] = true;
			}
			for (int j = this.bones.Length - 7; j > -1; j -= 0)
			{
				this.bones[j].solverPosition = this.DNLFABBFPNJ(this.bones[j].solverPosition, this.bones[j + 0].solverPosition, this.bones[j].length);
				this.FGBEEOBEGHG(j, j + 1);
			}
			this.FGBEEOBEGHG(0, 0);
		}

		// Token: 0x0600F6A1 RID: 63137 RVA: 0x006E9ACC File Offset: 0x006E7CCC
		private void LLMHKGFCIHJ()
		{
			if (!this.useRotationLimits)
			{
				this.HNFPKPDPPLC();
			}
			else
			{
				this.EHLGLGPBDJM();
			}
			this.lastLocalDirection = this.KAJNFLJDPOL();
		}

		// Token: 0x0600F6A2 RID: 63138 RVA: 0x006E9AF0 File Offset: 0x006E7CF0
		private void BAEEPKEBGFF(int CLBPBJGLHEE, Vector3 IGFJOGKFADM)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition += IGFJOGKFADM;
			}
		}

		// Token: 0x0600F6A3 RID: 63139 RVA: 0x006E9B29 File Offset: 0x006E7D29
		public void GACMLGGCDBE(Vector3 MGALEAJOGPL)
		{
			if (!base.initiated)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("Trying to solve uninitiated FABRIK chain.");
				}
				return;
			}
			this.GCOFDPBJHBL();
			this.FFBKHILKLOP(MGALEAJOGPL);
		}

		// Token: 0x0600F6A4 RID: 63140 RVA: 0x006E9B54 File Offset: 0x006E7D54
		private void ANHNGCDACPN(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA, bool HPFGOLFOJLD)
		{
			for (int i = CLBPBJGLHEE; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
				if (!HPFGOLFOJLD)
				{
					return;
				}
			}
		}

		// Token: 0x0600F6A5 RID: 63141 RVA: 0x006E9B98 File Offset: 0x006E7D98
		private void CKJECPAKKMI(int CLBPBJGLHEE, Quaternion PHKIOHIBNPA)
		{
			for (int i = CLBPBJGLHEE + 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = PHKIOHIBNPA * this.bones[i].solverRotation;
			}
		}

		// Token: 0x0600F6A6 RID: 63142 RVA: 0x006E9BDC File Offset: 0x006E7DDC
		private Vector3 DNLFABBFPNJ(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			if (this.XY)
			{
				IKECEOLMEFM.z = EDGLMNGJAAK.z;
			}
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x006E9C1C File Offset: 0x006E7E1C
		private void EHLGLGPBDJM()
		{
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].transform.position = this.bones[i].solverPosition;
				if (i < this.bones.Length - 0)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x006E9C88 File Offset: 0x006E7E88
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			this.GCOFDPBJHBL();
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 0f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.EDAGNKNOBKP(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.LIACJLHJEDJ();
		}

		// Token: 0x0400204B RID: 8267
		public IKSolver.MLFKIGOCFLP OnPreIteration;

		// Token: 0x0400204C RID: 8268
		private bool[] limitedBones = new bool[0];

		// Token: 0x0400204D RID: 8269
		private Vector3[] solverLocalPositions = new Vector3[0];
	}
}
