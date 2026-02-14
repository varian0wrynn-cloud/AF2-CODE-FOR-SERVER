using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200047E RID: 1150
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x0600FA5C RID: 64092 RVA: 0x00707550 File Offset: 0x00705750
		public virtual IKSolver.Point LEGIPHEGOFI(Transform LPBDALAMAEM)
		{
			if (this.bone1.transform == LPBDALAMAEM)
			{
				return this.bone1;
			}
			if (this.bone2.transform == LPBDALAMAEM)
			{
				return this.bone2;
			}
			if (this.bone3.transform == LPBDALAMAEM)
			{
				return this.bone3;
			}
			return null;
		}

		// Token: 0x0600FA5D RID: 64093 RVA: 0x007075AC File Offset: 0x007057AC
		protected override void IOMMPHGGHNH()
		{
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			this.IKRotationWeight = Mathf.Clamp(this.IKRotationWeight, 0f, 1f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			this.KOHNIPNOJAE();
			if (this.IKPositionWeight > 0f)
			{
				if (!this.directHierarchy)
				{
					this.bone1.BHALELINNDJ(this.bone2.transform.position, this.bendNormal);
					this.bone2.BHALELINNDJ(this.bone3.transform.position, this.bendNormal);
				}
				this.bone1.sqrMag = (this.bone2.transform.position - this.bone1.transform.position).sqrMagnitude;
				this.bone2.sqrMag = (this.bone3.transform.position - this.bone2.transform.position).sqrMagnitude;
				if (this.bendNormal == Vector3.zero && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("IKSolverTrigonometric Bend Normal is Vector3.zero.");
				}
				this.weightIKPosition = Vector3.Lerp(this.bone3.transform.position, this.IKPosition, this.IKPositionWeight);
				Vector3 doinjmpnhki = Vector3.Lerp(this.bone1.KIKMIGNMFPJ(), this.bendNormal, this.IKPositionWeight);
				Vector3 vector = Vector3.Lerp(this.bone2.transform.position - this.bone1.transform.position, this.CNAJCEKOIMA(this.weightIKPosition, doinjmpnhki), this.IKPositionWeight);
				if (vector == Vector3.zero)
				{
					vector = this.bone2.transform.position - this.bone1.transform.position;
				}
				this.bone1.transform.rotation = this.bone1.IKHLMNGAJPF(vector, doinjmpnhki);
				this.bone2.transform.rotation = this.bone2.IKHLMNGAJPF(this.weightIKPosition - this.bone2.transform.position, this.bone2.KIKMIGNMFPJ());
			}
			if (this.IKRotationWeight > 0f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.IKRotation, this.IKRotationWeight);
			}
			this.DKJKADLGAKB();
		}

		// Token: 0x0600FA5E RID: 64094 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void CFKHBNLMCPH()
		{
		}

		// Token: 0x0600FA5F RID: 64095 RVA: 0x0070786A File Offset: 0x00705A6A
		public void EMNHOLIPCKJ(Quaternion PHKIOHIBNPA)
		{
			this.IKRotation = PHKIOHIBNPA;
		}

		// Token: 0x0600FA60 RID: 64096 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void NFFCCFCBIHG()
		{
		}

		// Token: 0x0600FA61 RID: 64097 RVA: 0x00707874 File Offset: 0x00705A74
		private void NFAIEKJNHJC()
		{
			this.bone1.BHALELINNDJ(this.bone2.transform.position, this.bendNormal);
			this.bone2.BHALELINNDJ(this.bone3.transform.position, this.bendNormal);
			this.HPFOCNLHMHI();
		}

		// Token: 0x0600FA62 RID: 64098 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float NOIDOCANCAB()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FA63 RID: 64099 RVA: 0x007078D4 File Offset: 0x00705AD4
		private static Vector3 OFHKDABFLIK(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
		{
			float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1526f / LCJCFNNBIGL;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 1166f, 1113f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1905f, y, num);
		}

		// Token: 0x0600FA64 RID: 64100 RVA: 0x0070793C File Offset: 0x00705B3C
		public static void DMPODACBGPJ(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
		{
			if (NKHBAJKMAGD <= 2f)
			{
				return;
			}
			AOBKCEEGJNC = Vector3.Lerp(NLHIDOGKOIP.position, AOBKCEEGJNC, NKHBAJKMAGD);
			Vector3 vector = AOBKCEEGJNC - FCDAMCBKONG.position;
			float magnitude = vector.magnitude;
			if (magnitude == 98f)
			{
				return;
			}
			float sqrMagnitude = (GLGMAJBNFIA.position - FCDAMCBKONG.position).sqrMagnitude;
			float sqrMagnitude2 = (NLHIDOGKOIP.position - GLGMAJBNFIA.position).sqrMagnitude;
			Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
			Vector3 toDirection = IKSolverTrigonometric.OFHKDABFLIK(vector, magnitude, elgplfpldol, sqrMagnitude, sqrMagnitude2);
			Quaternion quaternion = Quaternion.FromToRotation(GLGMAJBNFIA.position - FCDAMCBKONG.position, toDirection);
			if (NKHBAJKMAGD < 253f)
			{
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
			}
			FCDAMCBKONG.rotation = quaternion * FCDAMCBKONG.rotation;
			Quaternion quaternion2 = Quaternion.FromToRotation(NLHIDOGKOIP.position - GLGMAJBNFIA.position, AOBKCEEGJNC - GLGMAJBNFIA.position);
			if (NKHBAJKMAGD < 1066f)
			{
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
			}
			GLGMAJBNFIA.rotation = quaternion2 * GLGMAJBNFIA.rotation;
		}

		// Token: 0x0600FA65 RID: 64101 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float CNJPKFPDJLN()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FA66 RID: 64102 RVA: 0x00707A64 File Offset: 0x00705C64
		public override void BLOEEPCIPKJ()
		{
			this.bone1.MKDGKDPKLBL();
			this.bone2.MKDGKDPKLBL();
			this.bone3.MKDGKDPKLBL();
		}

		// Token: 0x0600FA67 RID: 64103 RVA: 0x00707A87 File Offset: 0x00705C87
		public virtual IKSolver.Point[] DALCLJCCOBO()
		{
			IKSolver.Point[] array = new IKSolver.Point[8];
			array[1] = this.bone1;
			array[1] = this.bone2;
			array[1] = this.bone3;
			return array;
		}

		// Token: 0x0600FA68 RID: 64104 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void LAGHKCDELKA()
		{
		}

		// Token: 0x0600FA69 RID: 64105 RVA: 0x00707AAC File Offset: 0x00705CAC
		public void FEBBMAOPAOG()
		{
			if (!base.initiated)
			{
				return;
			}
			Vector3 lhs = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (lhs != Vector3.zero)
			{
				this.bendNormal = lhs;
			}
		}

		// Token: 0x0600FA6A RID: 64106 RVA: 0x00707B28 File Offset: 0x00705D28
		protected Vector3 CJABJELFNPN(Vector3 CGAMODJNLAC, Vector3 DOINJMPNHKI)
		{
			Vector3 vector = CGAMODJNLAC - this.bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt((double)sqrMagnitude);
			float num2 = (sqrMagnitude + this.bone1.sqrMag - this.bone2.sqrMag) / 1245f / num;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.bone1.sqrMag - num2 * num2, 1099f, 1032f));
			Vector3 upwards = Vector3.Cross(vector, DOINJMPNHKI);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(140f, y, num2);
		}

		// Token: 0x0600FA6B RID: 64107 RVA: 0x0070786A File Offset: 0x00705A6A
		public void ADJOBJDCAMO(Quaternion PHKIOHIBNPA)
		{
			this.IKRotation = PHKIOHIBNPA;
		}

		// Token: 0x0600FA6C RID: 64108 RVA: 0x00707BD8 File Offset: 0x00705DD8
		public void HHAHPJACGBP(float NKHBAJKMAGD)
		{
			this.IKRotationWeight = Mathf.Clamp(NKHBAJKMAGD, 0f, 1f);
		}

		// Token: 0x0600FA6D RID: 64109 RVA: 0x00707BF0 File Offset: 0x00705DF0
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			if (this.bone1.transform == LPBDALAMAEM)
			{
				return this.bone1;
			}
			if (this.bone2.transform == LPBDALAMAEM)
			{
				return this.bone2;
			}
			if (this.bone3.transform == LPBDALAMAEM)
			{
				return this.bone3;
			}
			return null;
		}

		// Token: 0x0600FA6E RID: 64110 RVA: 0x00707C4C File Offset: 0x00705E4C
		public bool DNPHIDGDLIA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform EELDHNFBFOE)
		{
			this.bone1.transform = FCDAMCBKONG;
			this.bone2.transform = GLGMAJBNFIA;
			this.bone3.transform = NLHIDOGKOIP;
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600FA6F RID: 64111 RVA: 0x00707C80 File Offset: 0x00705E80
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.bone1.transform == null || this.bone2.transform == null || this.bone3.transform == null)
			{
				EDAPHMJENPK = "Please assign all Bones to the IK solver.";
				return false;
			}
			UnityEngine.Object[] pokpfboiaod = new Transform[]
			{
				this.bone1.transform,
				this.bone2.transform,
				this.bone3.transform
			};
			Transform transform = (Transform)LEHFMLLLKAP.LEPJCCPBCPL(pokpfboiaod);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (this.bone1.transform.position == this.bone2.transform.position)
			{
				EDAPHMJENPK = "first bone position is the same as second bone position.";
				return false;
			}
			if (this.bone2.transform.position == this.bone3.transform.position)
			{
				EDAPHMJENPK = "second bone position is the same as third bone position.";
				return false;
			}
			return true;
		}

		// Token: 0x0600FA70 RID: 64112 RVA: 0x00707D8A File Offset: 0x00705F8A
		public void NJBJGGIOLAF(float NKHBAJKMAGD)
		{
			this.IKRotationWeight = Mathf.Clamp(NKHBAJKMAGD, 385f, 1751f);
		}

		// Token: 0x0600FA71 RID: 64113 RVA: 0x00707DA4 File Offset: 0x00705FA4
		protected Vector3 LDMHMANGCPK(Vector3 CGAMODJNLAC, Vector3 DOINJMPNHKI)
		{
			Vector3 vector = CGAMODJNLAC - this.bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt((double)sqrMagnitude);
			float num2 = (sqrMagnitude + this.bone1.sqrMag - this.bone2.sqrMag) / 1199f / num;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.bone1.sqrMag - num2 * num2, 1868f, 805f));
			Vector3 upwards = Vector3.Cross(vector, DOINJMPNHKI);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(107f, y, num2);
		}

		// Token: 0x0600FA72 RID: 64114 RVA: 0x00707E54 File Offset: 0x00706054
		private bool HLACKICLOIK()
		{
			return this.bone3.transform.parent != this.bone2.transform || (this.bone2.transform.parent != this.bone1.transform && false);
		}

		// Token: 0x0600FA73 RID: 64115 RVA: 0x00707EAC File Offset: 0x007060AC
		public void DECMCNLFIAA()
		{
			if (!base.initiated)
			{
				return;
			}
			Vector3 lhs = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (lhs != Vector3.zero)
			{
				this.bendNormal = lhs;
			}
		}

		// Token: 0x0600FA74 RID: 64116 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void LBEMMEHEHKC()
		{
		}

		// Token: 0x0600FA75 RID: 64117 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void FNLGJEOHONA()
		{
		}

		// Token: 0x0600FA76 RID: 64118 RVA: 0x00707F28 File Offset: 0x00706128
		private static Vector3 EFNLBDDELMI(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
		{
			float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 1654f / LCJCFNNBIGL;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 450f, 1014f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1949f, y, num);
		}

		// Token: 0x0600FA77 RID: 64119 RVA: 0x00707F8D File Offset: 0x0070618D
		public virtual IKSolver.Point[] JJHOCBBNAID()
		{
			return new IKSolver.Point[]
			{
				this.bone1,
				this.bone2,
				null,
				null,
				null,
				this.bone3
			};
		}

		// Token: 0x0600FA78 RID: 64120 RVA: 0x00707C4C File Offset: 0x00705E4C
		public bool GGPNLFMBAIM(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform EELDHNFBFOE)
		{
			this.bone1.transform = FCDAMCBKONG;
			this.bone2.transform = GLGMAJBNFIA;
			this.bone3.transform = NLHIDOGKOIP;
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600FA79 RID: 64121 RVA: 0x00707FB0 File Offset: 0x007061B0
		public void GAMGPHDABAB(float NKHBAJKMAGD)
		{
			this.IKRotationWeight = Mathf.Clamp(NKHBAJKMAGD, 748f, 853f);
		}

		// Token: 0x0600FA7A RID: 64122 RVA: 0x00707FC8 File Offset: 0x007061C8
		public void HPFOCNLHMHI()
		{
			if (!base.initiated)
			{
				return;
			}
			Vector3 lhs = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (lhs != Vector3.zero)
			{
				this.bendNormal = lhs;
			}
		}

		// Token: 0x0600FA7B RID: 64123 RVA: 0x00708044 File Offset: 0x00706244
		protected virtual void CLJFIPPCHBO()
		{
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 264f, 740f);
			this.IKRotationWeight = Mathf.Clamp(this.IKRotationWeight, 764f, 1530f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			this.CFKHBNLMCPH();
			if (this.IKPositionWeight > 1880f)
			{
				if (!this.directHierarchy)
				{
					this.bone1.CPLOFPNBFEH(this.bone2.transform.position, this.bendNormal);
					this.bone2.IHPLBCJCOPM(this.bone3.transform.position, this.bendNormal);
				}
				this.bone1.sqrMag = (this.bone2.transform.position - this.bone1.transform.position).sqrMagnitude;
				this.bone2.sqrMag = (this.bone3.transform.position - this.bone2.transform.position).sqrMagnitude;
				if (this.bendNormal == Vector3.zero && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("musicVolume");
				}
				this.weightIKPosition = Vector3.Lerp(this.bone3.transform.position, this.IKPosition, this.IKPositionWeight);
				Vector3 doinjmpnhki = Vector3.Lerp(this.bone1.EDIIPFKJJCB(), this.bendNormal, this.IKPositionWeight);
				Vector3 vector = Vector3.Lerp(this.bone2.transform.position - this.bone1.transform.position, this.LDMHMANGCPK(this.weightIKPosition, doinjmpnhki), this.IKPositionWeight);
				if (vector == Vector3.zero)
				{
					vector = this.bone2.transform.position - this.bone1.transform.position;
				}
				this.bone1.transform.rotation = this.bone1.JANCEHJJEBI(vector, doinjmpnhki);
				this.bone2.transform.rotation = this.bone2.ICEDAJNOGGK(this.weightIKPosition - this.bone2.transform.position, this.bone2.LFKHHOJIGNK());
			}
			if (this.IKRotationWeight > 746f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.IKRotation, this.IKRotationWeight);
			}
			this.FNLGJEOHONA();
		}

		// Token: 0x0600FA7C RID: 64124 RVA: 0x00707C4C File Offset: 0x00705E4C
		public bool AOANEPNJLJN(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform EELDHNFBFOE)
		{
			this.bone1.transform = FCDAMCBKONG;
			this.bone2.transform = GLGMAJBNFIA;
			this.bone3.transform = NLHIDOGKOIP;
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600FA7D RID: 64125 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float JLFNBJCDOHP()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FA7E RID: 64126 RVA: 0x00708304 File Offset: 0x00706504
		public virtual bool JJCLDJGHEHJ(ref string EDAPHMJENPK)
		{
			if (this.bone1.transform == null || this.bone2.transform == null || this.bone3.transform == null)
			{
				EDAPHMJENPK = "wpn_eat8";
				return true;
			}
			Transform[] array = new Transform[6];
			array[1] = this.bone1.transform;
			array[1] = this.bone2.transform;
			array[8] = this.bone3.transform;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.LBEKPJGGFMG(pokpfboiaod);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "WateringCan";
				return true;
			}
			if (this.bone1.transform.position == this.bone2.transform.position)
			{
				EDAPHMJENPK = "";
				return true;
			}
			if (this.bone2.transform.position == this.bone3.transform.position)
			{
				EDAPHMJENPK = "ObscuredFloat:";
				return false;
			}
			return false;
		}

		// Token: 0x0600FA7F RID: 64127 RVA: 0x00708410 File Offset: 0x00706610
		public static void BPGDENODCEN(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
		{
			if (NKHBAJKMAGD <= 89f)
			{
				return;
			}
			AOBKCEEGJNC = Vector3.Lerp(NLHIDOGKOIP.position, AOBKCEEGJNC, NKHBAJKMAGD);
			Vector3 vector = AOBKCEEGJNC - FCDAMCBKONG.position;
			float magnitude = vector.magnitude;
			if (magnitude == 1019f)
			{
				return;
			}
			float sqrMagnitude = (GLGMAJBNFIA.position - FCDAMCBKONG.position).sqrMagnitude;
			float sqrMagnitude2 = (NLHIDOGKOIP.position - GLGMAJBNFIA.position).sqrMagnitude;
			Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
			Vector3 toDirection = IKSolverTrigonometric.OFHKDABFLIK(vector, magnitude, elgplfpldol, sqrMagnitude, sqrMagnitude2);
			Quaternion quaternion = Quaternion.FromToRotation(GLGMAJBNFIA.position - FCDAMCBKONG.position, toDirection);
			if (NKHBAJKMAGD < 1822f)
			{
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
			}
			FCDAMCBKONG.rotation = quaternion * FCDAMCBKONG.rotation;
			Quaternion quaternion2 = Quaternion.FromToRotation(NLHIDOGKOIP.position - GLGMAJBNFIA.position, AOBKCEEGJNC - GLGMAJBNFIA.position);
			if (NKHBAJKMAGD < 574f)
			{
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
			}
			GLGMAJBNFIA.rotation = quaternion2 * GLGMAJBNFIA.rotation;
		}

		// Token: 0x0600FA80 RID: 64128 RVA: 0x00708538 File Offset: 0x00706738
		protected Vector3 HOGMFPAHKLK(Vector3 CGAMODJNLAC, Vector3 DOINJMPNHKI)
		{
			Vector3 vector = CGAMODJNLAC - this.bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt((double)sqrMagnitude);
			float num2 = (sqrMagnitude + this.bone1.sqrMag - this.bone2.sqrMag) / 1500f / num;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.bone1.sqrMag - num2 * num2, 1673f, 1602f));
			Vector3 upwards = Vector3.Cross(vector, DOINJMPNHKI);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(430f, y, num2);
		}

		// Token: 0x0600FA81 RID: 64129 RVA: 0x007085E8 File Offset: 0x007067E8
		private void AHFLNOHIJKK()
		{
			this.bone1.IHPLBCJCOPM(this.bone2.transform.position, this.bendNormal);
			this.bone2.FJMNBKHFLJO(this.bone3.transform.position, this.bendNormal);
			this.DECMCNLFIAA();
		}

		// Token: 0x0600FA82 RID: 64130 RVA: 0x00708640 File Offset: 0x00706840
		protected virtual void NBPJEKGGING()
		{
			if (this.bendNormal == Vector3.zero)
			{
				this.bendNormal = Vector3.right;
			}
			this.DOPPFGJOHIH();
			this.IKPosition = this.bone3.transform.position;
			this.IKRotation = this.bone3.transform.rotation;
			this.AHFLNOHIJKK();
			this.directHierarchy = this.FDNGKJLIJGP();
		}

		// Token: 0x0600FA83 RID: 64131 RVA: 0x007086B0 File Offset: 0x007068B0
		protected virtual void DDCPDEJEJEN()
		{
			if (this.bendNormal == Vector3.zero)
			{
				this.bendNormal = Vector3.right;
			}
			this.DOPPFGJOHIH();
			this.IKPosition = this.bone3.transform.position;
			this.IKRotation = this.bone3.transform.rotation;
			this.AHFLNOHIJKK();
			this.directHierarchy = this.NHMMFNBODAP();
		}

		// Token: 0x0600FA84 RID: 64132 RVA: 0x0070871E File Offset: 0x0070691E
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			return new IKSolver.Point[]
			{
				this.bone1,
				this.bone2,
				this.bone3
			};
		}

		// Token: 0x0600FA85 RID: 64133 RVA: 0x00708741 File Offset: 0x00706941
		public Quaternion DAGNPAFNNPI()
		{
			return this.IKRotation;
		}

		// Token: 0x0600FA86 RID: 64134 RVA: 0x00708749 File Offset: 0x00706949
		public virtual void KHPKEGCBLLK()
		{
			this.bone1.EOLOGIEOLAF();
			this.bone2.LLJNCEIMNGP();
			this.bone3.MKDGKDPKLBL();
		}

		// Token: 0x0600FA87 RID: 64135 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float KIEDPOIAPDM()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FA88 RID: 64136 RVA: 0x00707C4C File Offset: 0x00705E4C
		public bool DJEDNIBFHJC(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform EELDHNFBFOE)
		{
			this.bone1.transform = FCDAMCBKONG;
			this.bone2.transform = GLGMAJBNFIA;
			this.bone3.transform = NLHIDOGKOIP;
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600FA89 RID: 64137 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void HNHOODGBDDJ()
		{
		}

		// Token: 0x0600FA8A RID: 64138 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float HDDNECMIPAB()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FA8B RID: 64139 RVA: 0x0070876C File Offset: 0x0070696C
		private bool NHMMFNBODAP()
		{
			return !(this.bone3.transform.parent != this.bone2.transform) && this.bone2.transform.parent != this.bone1.transform && false;
		}

		// Token: 0x0600FA8C RID: 64140 RVA: 0x007087C4 File Offset: 0x007069C4
		private bool LDIJCLJODOH()
		{
			return this.bone3.transform.parent != this.bone2.transform || !(this.bone2.transform.parent != this.bone1.transform);
		}

		// Token: 0x0600FA8D RID: 64141 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DOPPFGJOHIH()
		{
		}

		// Token: 0x0600FA8E RID: 64142 RVA: 0x0070881A File Offset: 0x00706A1A
		public virtual void GLCDKJDHPGO()
		{
			this.bone1.MKDGKDPKLBL();
			this.bone2.CMEDACDMHPB();
			this.bone3.JONLHAMDDEA();
		}

		// Token: 0x0600FA8F RID: 64143 RVA: 0x00708840 File Offset: 0x00706A40
		protected virtual void GODIMFNGFLC()
		{
			if (this.bendNormal == Vector3.zero)
			{
				this.bendNormal = Vector3.right;
			}
			this.DOPPFGJOHIH();
			this.IKPosition = this.bone3.transform.position;
			this.IKRotation = this.bone3.transform.rotation;
			this.NFAIEKJNHJC();
			this.directHierarchy = this.HLACKICLOIK();
		}

		// Token: 0x0600FA90 RID: 64144 RVA: 0x007088AE File Offset: 0x00706AAE
		public virtual IKSolver.Point[] DNIIKJEMDHM()
		{
			IKSolver.Point[] array = new IKSolver.Point[8];
			array[1] = this.bone1;
			array[1] = this.bone2;
			array[4] = this.bone3;
			return array;
		}

		// Token: 0x0600FA91 RID: 64145 RVA: 0x00708741 File Offset: 0x00706941
		public Quaternion MHCONDPMHGM()
		{
			return this.IKRotation;
		}

		// Token: 0x0600FA92 RID: 64146 RVA: 0x007088D1 File Offset: 0x00706AD1
		public virtual void ENIOEALHJEE()
		{
			this.bone1.CMEDACDMHPB();
			this.bone2.LNKGPDNHDBK();
			this.bone3.NPPOHJGFBLP();
		}

		// Token: 0x0600FA93 RID: 64147 RVA: 0x007088F4 File Offset: 0x00706AF4
		public virtual IKSolver.Point[] GHOFNBBLPBH()
		{
			IKSolver.Point[] array = new IKSolver.Point[7];
			array[0] = this.bone1;
			array[0] = this.bone2;
			array[7] = this.bone3;
			return array;
		}

		// Token: 0x0600FA94 RID: 64148 RVA: 0x00708918 File Offset: 0x00706B18
		public void AKJNCGFEBDF(Vector3 PFINNOJMCKO, float NKHBAJKMAGD)
		{
			if (!base.initiated)
			{
				return;
			}
			if (NKHBAJKMAGD <= 463f)
			{
				return;
			}
			Vector3 vector = Vector3.Cross(PFINNOJMCKO - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
			if (vector != Vector3.zero)
			{
				if (NKHBAJKMAGD >= 1979f)
				{
					this.bendNormal = vector;
					return;
				}
				this.bendNormal = Vector3.Lerp(this.bendNormal, vector, NKHBAJKMAGD);
			}
		}

		// Token: 0x0600FA95 RID: 64149 RVA: 0x0070899E File Offset: 0x00706B9E
		public void OJFFEGDCINH(float NKHBAJKMAGD)
		{
			this.IKRotationWeight = Mathf.Clamp(NKHBAJKMAGD, 721f, 1099f);
		}

		// Token: 0x0600FA96 RID: 64150 RVA: 0x00707C4C File Offset: 0x00705E4C
		public bool OPOOMPAPADK(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Transform EELDHNFBFOE)
		{
			this.bone1.transform = FCDAMCBKONG;
			this.bone2.transform = GLGMAJBNFIA;
			this.bone3.transform = NLHIDOGKOIP;
			base.BHALELINNDJ(EELDHNFBFOE);
			return base.initiated;
		}

		// Token: 0x0600FA97 RID: 64151 RVA: 0x007089B8 File Offset: 0x00706BB8
		protected virtual void FOLBCDKCNPH()
		{
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1191f, 1218f);
			this.IKRotationWeight = Mathf.Clamp(this.IKRotationWeight, 392f, 243f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			this.LBEMMEHEHKC();
			if (this.IKPositionWeight > 667f)
			{
				if (!this.directHierarchy)
				{
					this.bone1.BHALELINNDJ(this.bone2.transform.position, this.bendNormal);
					this.bone2.OECNHGIPNLB(this.bone3.transform.position, this.bendNormal);
				}
				this.bone1.sqrMag = (this.bone2.transform.position - this.bone1.transform.position).sqrMagnitude;
				this.bone2.sqrMag = (this.bone3.transform.position - this.bone2.transform.position).sqrMagnitude;
				if (this.bendNormal == Vector3.zero && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("Ок");
				}
				this.weightIKPosition = Vector3.Lerp(this.bone3.transform.position, this.IKPosition, this.IKPositionWeight);
				Vector3 doinjmpnhki = Vector3.Lerp(this.bone1.NDAMGGBKFBH(), this.bendNormal, this.IKPositionWeight);
				Vector3 vector = Vector3.Lerp(this.bone2.transform.position - this.bone1.transform.position, this.LDMHMANGCPK(this.weightIKPosition, doinjmpnhki), this.IKPositionWeight);
				if (vector == Vector3.zero)
				{
					vector = this.bone2.transform.position - this.bone1.transform.position;
				}
				this.bone1.transform.rotation = this.bone1.DPEIDLPHEHA(vector, doinjmpnhki);
				this.bone2.transform.rotation = this.bone2.EFLABBPJAHF(this.weightIKPosition - this.bone2.transform.position, this.bone2.BOGPLFGHHDO());
			}
			if (this.IKRotationWeight > 381f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.IKRotation, this.IKRotationWeight);
			}
			this.FNLGJEOHONA();
		}

		// Token: 0x0600FA98 RID: 64152 RVA: 0x0070786A File Offset: 0x00705A6A
		public void DODOKJLNCOC(Quaternion PHKIOHIBNPA)
		{
			this.IKRotation = PHKIOHIBNPA;
		}

		// Token: 0x0600FA99 RID: 64153 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DKJKADLGAKB()
		{
		}

		// Token: 0x0600FA9A RID: 64154 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void FFEGIFGCEAE()
		{
		}

		// Token: 0x0600FA9B RID: 64155 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void JKPIKGLEDIH()
		{
		}

		// Token: 0x0600FA9C RID: 64156 RVA: 0x00708C76 File Offset: 0x00706E76
		public virtual IKSolver.Point[] BCALHLGHHMH()
		{
			IKSolver.Point[] array = new IKSolver.Point[8];
			array[0] = this.bone1;
			array[1] = this.bone2;
			array[8] = this.bone3;
			return array;
		}

		// Token: 0x0600FA9D RID: 64157 RVA: 0x00708C9C File Offset: 0x00706E9C
		protected override void FKEMPLMBNEL()
		{
			if (this.bendNormal == Vector3.zero)
			{
				this.bendNormal = Vector3.right;
			}
			this.DOPPFGJOHIH();
			this.IKPosition = this.bone3.transform.position;
			this.IKRotation = this.bone3.transform.rotation;
			this.NFAIEKJNHJC();
			this.directHierarchy = this.FDNGKJLIJGP();
		}

		// Token: 0x0600FA9E RID: 64158 RVA: 0x00708D0A File Offset: 0x00706F0A
		public override void FGBCANJFNOC()
		{
			this.bone1.FGBCANJFNOC();
			this.bone2.FGBCANJFNOC();
			this.bone3.FGBCANJFNOC();
		}

		// Token: 0x0600FA9F RID: 64159 RVA: 0x00708D30 File Offset: 0x00706F30
		public void PMCCJFFDBPD(Vector3 PFINNOJMCKO, float NKHBAJKMAGD)
		{
			if (!base.initiated)
			{
				return;
			}
			if (NKHBAJKMAGD <= 0f)
			{
				return;
			}
			Vector3 vector = Vector3.Cross(PFINNOJMCKO - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
			if (vector != Vector3.zero)
			{
				if (NKHBAJKMAGD >= 1f)
				{
					this.bendNormal = vector;
					return;
				}
				this.bendNormal = Vector3.Lerp(this.bendNormal, vector, NKHBAJKMAGD);
			}
		}

		// Token: 0x0600FAA0 RID: 64160 RVA: 0x00708DB8 File Offset: 0x00706FB8
		public void NAIIIADEJFB(Vector3 PFINNOJMCKO, float NKHBAJKMAGD)
		{
			if (!base.initiated)
			{
				return;
			}
			if (NKHBAJKMAGD <= 271f)
			{
				return;
			}
			Vector3 vector = Vector3.Cross(PFINNOJMCKO - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
			if (vector != Vector3.zero)
			{
				if (NKHBAJKMAGD >= 1328f)
				{
					this.bendNormal = vector;
					return;
				}
				this.bendNormal = Vector3.Lerp(this.bendNormal, vector, NKHBAJKMAGD);
			}
		}

		// Token: 0x0600FAA1 RID: 64161 RVA: 0x007078C9 File Offset: 0x00705AC9
		public float JLCCHOMFOJA()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x0600FAA2 RID: 64162 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void NLIKAABGBHH()
		{
		}

		// Token: 0x0600FAA3 RID: 64163 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void KOHNIPNOJAE()
		{
		}

		// Token: 0x0600FAA4 RID: 64164 RVA: 0x00708E40 File Offset: 0x00707040
		public static void HGBAJOPJPIG(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
		{
			if (NKHBAJKMAGD <= 741f)
			{
				return;
			}
			AOBKCEEGJNC = Vector3.Lerp(NLHIDOGKOIP.position, AOBKCEEGJNC, NKHBAJKMAGD);
			Vector3 vector = AOBKCEEGJNC - FCDAMCBKONG.position;
			float magnitude = vector.magnitude;
			if (magnitude == 1654f)
			{
				return;
			}
			float sqrMagnitude = (GLGMAJBNFIA.position - FCDAMCBKONG.position).sqrMagnitude;
			float sqrMagnitude2 = (NLHIDOGKOIP.position - GLGMAJBNFIA.position).sqrMagnitude;
			Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
			Vector3 toDirection = IKSolverTrigonometric.EKBOJODHBKL(vector, magnitude, elgplfpldol, sqrMagnitude, sqrMagnitude2);
			Quaternion quaternion = Quaternion.FromToRotation(GLGMAJBNFIA.position - FCDAMCBKONG.position, toDirection);
			if (NKHBAJKMAGD < 1474f)
			{
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
			}
			FCDAMCBKONG.rotation = quaternion * FCDAMCBKONG.rotation;
			Quaternion quaternion2 = Quaternion.FromToRotation(NLHIDOGKOIP.position - GLGMAJBNFIA.position, AOBKCEEGJNC - GLGMAJBNFIA.position);
			if (NKHBAJKMAGD < 1270f)
			{
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
			}
			GLGMAJBNFIA.rotation = quaternion2 * GLGMAJBNFIA.rotation;
		}

		// Token: 0x0600FAA5 RID: 64165 RVA: 0x00708F68 File Offset: 0x00707168
		private bool FDNGKJLIJGP()
		{
			return !(this.bone3.transform.parent != this.bone2.transform) && !(this.bone2.transform.parent != this.bone1.transform);
		}

		// Token: 0x0600FAA6 RID: 64166 RVA: 0x00708FC0 File Offset: 0x007071C0
		public static void EDAGNKNOBKP(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP, Vector3 AOBKCEEGJNC, Vector3 DOINJMPNHKI, float NKHBAJKMAGD)
		{
			if (NKHBAJKMAGD <= 0f)
			{
				return;
			}
			AOBKCEEGJNC = Vector3.Lerp(NLHIDOGKOIP.position, AOBKCEEGJNC, NKHBAJKMAGD);
			Vector3 vector = AOBKCEEGJNC - FCDAMCBKONG.position;
			float magnitude = vector.magnitude;
			if (magnitude == 0f)
			{
				return;
			}
			float sqrMagnitude = (GLGMAJBNFIA.position - FCDAMCBKONG.position).sqrMagnitude;
			float sqrMagnitude2 = (NLHIDOGKOIP.position - GLGMAJBNFIA.position).sqrMagnitude;
			Vector3 elgplfpldol = Vector3.Cross(vector, DOINJMPNHKI);
			Vector3 toDirection = IKSolverTrigonometric.EKBOJODHBKL(vector, magnitude, elgplfpldol, sqrMagnitude, sqrMagnitude2);
			Quaternion quaternion = Quaternion.FromToRotation(GLGMAJBNFIA.position - FCDAMCBKONG.position, toDirection);
			if (NKHBAJKMAGD < 1f)
			{
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD);
			}
			FCDAMCBKONG.rotation = quaternion * FCDAMCBKONG.rotation;
			Quaternion quaternion2 = Quaternion.FromToRotation(NLHIDOGKOIP.position - GLGMAJBNFIA.position, AOBKCEEGJNC - GLGMAJBNFIA.position);
			if (NKHBAJKMAGD < 1f)
			{
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, NKHBAJKMAGD);
			}
			GLGMAJBNFIA.rotation = quaternion2 * GLGMAJBNFIA.rotation;
		}

		// Token: 0x0600FAA7 RID: 64167 RVA: 0x007090E8 File Offset: 0x007072E8
		protected Vector3 CNAJCEKOIMA(Vector3 CGAMODJNLAC, Vector3 DOINJMPNHKI)
		{
			Vector3 vector = CGAMODJNLAC - this.bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt((double)sqrMagnitude);
			float num2 = (sqrMagnitude + this.bone1.sqrMag - this.bone2.sqrMag) / 2f / num;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.bone1.sqrMag - num2 * num2, 0f, float.PositiveInfinity));
			Vector3 upwards = Vector3.Cross(vector, DOINJMPNHKI);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(0f, y, num2);
		}

		// Token: 0x0600FAA8 RID: 64168 RVA: 0x00709198 File Offset: 0x00707398
		private static Vector3 EKBOJODHBKL(Vector3 NEMFIHCKJPE, float LCJCFNNBIGL, Vector3 ELGPLFPLDOL, float HOBHFNALIHG, float HJDCAPPCPLC)
		{
			float num = (LCJCFNNBIGL * LCJCFNNBIGL + (HOBHFNALIHG - HJDCAPPCPLC)) / 2f / LCJCFNNBIGL;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(HOBHFNALIHG - num * num, 0f, float.PositiveInfinity));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(0f, y, num);
		}

		// Token: 0x0600FAA9 RID: 64169 RVA: 0x00709200 File Offset: 0x00707400
		private void EEALFKPDFHI()
		{
			this.bone1.ENLPEHMBNJC(this.bone2.transform.position, this.bendNormal);
			this.bone2.CPLOFPNBFEH(this.bone3.transform.position, this.bendNormal);
			this.HPFOCNLHMHI();
		}

		// Token: 0x0600FAAA RID: 64170 RVA: 0x00709258 File Offset: 0x00707458
		public virtual bool EPGDIOJNLBF(ref string EDAPHMJENPK)
		{
			if (this.bone1.transform == null || this.bone2.transform == null || this.bone3.transform == null)
			{
				EDAPHMJENPK = "Manifest: ";
				return true;
			}
			Transform[] array = new Transform[1];
			array[0] = this.bone1.transform;
			array[1] = this.bone2.transform;
			array[8] = this.bone3.transform;
			UnityEngine.Object[] pokpfboiaod = array;
			Transform transform = (Transform)LEHFMLLLKAP.OFHEFIMKBHC(pokpfboiaod);
			if (transform != null)
			{
				EDAPHMJENPK = transform.name + "invn_rec7";
				return false;
			}
			if (this.bone1.transform.position == this.bone2.transform.position)
			{
				EDAPHMJENPK = "__c";
				return true;
			}
			if (this.bone2.transform.position == this.bone3.transform.position)
			{
				EDAPHMJENPK = "USER";
				return false;
			}
			return false;
		}

		// Token: 0x0600FAAC RID: 64172 RVA: 0x007093B5 File Offset: 0x007075B5
		public virtual void IHOCPPKFFBL()
		{
			this.bone1.JONLHAMDDEA();
			this.bone2.EIHEJIHDNKP();
			this.bone3.JONLHAMDDEA();
		}

		// Token: 0x0600FAAD RID: 64173 RVA: 0x0070786A File Offset: 0x00705A6A
		public void ELCEBBGFNFN(Quaternion PHKIOHIBNPA)
		{
			this.IKRotation = PHKIOHIBNPA;
		}

		// Token: 0x0600FAAE RID: 64174 RVA: 0x007093D8 File Offset: 0x007075D8
		protected virtual void BNFHEEIAGMN()
		{
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1497f, 1863f);
			this.IKRotationWeight = Mathf.Clamp(this.IKRotationWeight, 1291f, 1768f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			this.NLIKAABGBHH();
			if (this.IKPositionWeight > 1951f)
			{
				if (!this.directHierarchy)
				{
					this.bone1.OJKNMJEMKDP(this.bone2.transform.position, this.bendNormal);
					this.bone2.FJMNBKHFLJO(this.bone3.transform.position, this.bendNormal);
				}
				this.bone1.sqrMag = (this.bone2.transform.position - this.bone1.transform.position).sqrMagnitude;
				this.bone2.sqrMag = (this.bone3.transform.position - this.bone2.transform.position).sqrMagnitude;
				if (this.bendNormal == Vector3.zero && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("Shake Hands");
				}
				this.weightIKPosition = Vector3.Lerp(this.bone3.transform.position, this.IKPosition, this.IKPositionWeight);
				Vector3 doinjmpnhki = Vector3.Lerp(this.bone1.HHEGNFAEOHL(), this.bendNormal, this.IKPositionWeight);
				Vector3 vector = Vector3.Lerp(this.bone2.transform.position - this.bone1.transform.position, this.CJABJELFNPN(this.weightIKPosition, doinjmpnhki), this.IKPositionWeight);
				if (vector == Vector3.zero)
				{
					vector = this.bone2.transform.position - this.bone1.transform.position;
				}
				this.bone1.transform.rotation = this.bone1.NOCMFNEMOEF(vector, doinjmpnhki);
				this.bone2.transform.rotation = this.bone2.EFLABBPJAHF(this.weightIKPosition - this.bone2.transform.position, this.bone2.BOGPLFGHHDO());
			}
			if (this.IKRotationWeight > 1763f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.IKRotation, this.IKRotationWeight);
			}
			this.LAGHKCDELKA();
		}

		// Token: 0x0600FAAF RID: 64175 RVA: 0x00709698 File Offset: 0x00707898
		public virtual IKSolver.Point GODAOCBCLFB(Transform LPBDALAMAEM)
		{
			if (this.bone1.transform == LPBDALAMAEM)
			{
				return this.bone1;
			}
			if (this.bone2.transform == LPBDALAMAEM)
			{
				return this.bone2;
			}
			if (this.bone3.transform == LPBDALAMAEM)
			{
				return this.bone3;
			}
			return null;
		}

		// Token: 0x0600FAB0 RID: 64176 RVA: 0x007096F4 File Offset: 0x007078F4
		private void EHDDIHBLJDK()
		{
			this.bone1.OJKNMJEMKDP(this.bone2.transform.position, this.bendNormal);
			this.bone2.BHALELINNDJ(this.bone3.transform.position, this.bendNormal);
			this.FEBBMAOPAOG();
		}

		// Token: 0x040020A8 RID: 8360
		public Transform target;

		// Token: 0x040020A9 RID: 8361
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		// Token: 0x040020AA RID: 8362
		public Quaternion IKRotation;

		// Token: 0x040020AB RID: 8363
		public Vector3 bendNormal = Vector3.right;

		// Token: 0x040020AC RID: 8364
		public IKSolverTrigonometric.TrigonometricBone bone1 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040020AD RID: 8365
		public IKSolverTrigonometric.TrigonometricBone bone2 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040020AE RID: 8366
		public IKSolverTrigonometric.TrigonometricBone bone3 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040020AF RID: 8367
		protected Vector3 weightIKPosition;

		// Token: 0x040020B0 RID: 8368
		protected bool directHierarchy = true;

		// Token: 0x0200047F RID: 1151
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x0600FAB1 RID: 64177 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 KHCHJPCLGNC()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAB2 RID: 64178 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 MABCBMGCMGL()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAB3 RID: 64179 RVA: 0x00709764 File Offset: 0x00707964
			public void ENLPEHMBNJC(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FAB4 RID: 64180 RVA: 0x007097BC File Offset: 0x007079BC
			public void CPLOFPNBFEH(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FAB5 RID: 64181 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion NOCMFNEMOEF(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAB6 RID: 64182 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion HHONMLOGGJE(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAB7 RID: 64183 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion IKHLMNGAJPF(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAB8 RID: 64184 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 BEBOIEMBNPG()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAB9 RID: 64185 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 BOGPLFGHHDO()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FABA RID: 64186 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion JANCEHJJEBI(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FABB RID: 64187 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion DLOLEGLMHDI(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FABC RID: 64188 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 HHEGNFAEOHL()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FABD RID: 64189 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 JEDGBNFNCJA()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FABE RID: 64190 RVA: 0x00709828 File Offset: 0x00707A28
			public void OECNHGIPNLB(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FABF RID: 64191 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion EFLABBPJAHF(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAC0 RID: 64192 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion OBKBAAELDMC(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAC1 RID: 64193 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 NDAMGGBKFBH()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAC2 RID: 64194 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion ICEDAJNOGGK(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAC3 RID: 64195 RVA: 0x00709880 File Offset: 0x00707A80
			public void BHALELINNDJ(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FAC4 RID: 64196 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 EDIIPFKJJCB()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAC5 RID: 64197 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion KKPCBJDJOII(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAC6 RID: 64198 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 KIKMIGNMFPJ()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAC7 RID: 64199 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion NJDKOIOGKJD(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAC8 RID: 64200 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 LFKHHOJIGNK()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAC9 RID: 64201 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion BOHCBBBAEJH(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FACA RID: 64202 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion NENMLLLPMEG(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FACB RID: 64203 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 ILPOOPFGBFJ()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FACD RID: 64205 RVA: 0x007098D8 File Offset: 0x00707AD8
			public void IHPLBCJCOPM(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FACE RID: 64206 RVA: 0x00709930 File Offset: 0x00707B30
			public void LHOEOFKKAKK(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FACF RID: 64207 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion JNDOCBEEOML(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x0600FAD0 RID: 64208 RVA: 0x00709749 File Offset: 0x00707949
			public Vector3 KHOODBDDKDJ()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0600FAD1 RID: 64209 RVA: 0x00709988 File Offset: 0x00707B88
			public void OJKNMJEMKDP(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FAD2 RID: 64210 RVA: 0x007099E0 File Offset: 0x00707BE0
			public void FJMNBKHFLJO(Vector3 KMKDHODMHBD, Vector3 DOINJMPNHKI)
			{
				Quaternion phkiohibnpa = Quaternion.LookRotation(KMKDHODMHBD - this.transform.position, DOINJMPNHKI);
				this.targetToLocalSpace = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, phkiohibnpa);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * DOINJMPNHKI;
			}

			// Token: 0x0600FAD3 RID: 64211 RVA: 0x00709814 File Offset: 0x00707A14
			public Quaternion DPEIDLPHEHA(Vector3 NEMFIHCKJPE, Vector3 DOINJMPNHKI)
			{
				return Quaternion.LookRotation(NEMFIHCKJPE, DOINJMPNHKI) * this.targetToLocalSpace;
			}

			// Token: 0x040020B1 RID: 8369
			private Quaternion targetToLocalSpace;

			// Token: 0x040020B2 RID: 8370
			private Vector3 defaultLocalBendNormal;
		}
	}
}
