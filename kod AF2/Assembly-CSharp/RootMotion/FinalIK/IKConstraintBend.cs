using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000462 RID: 1122
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x0600F2ED RID: 62189 RVA: 0x006D095C File Offset: 0x006CEB5C
		public void DMOINNLLGBO(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CFGCGBAFECA(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.IBAOFCILPHA(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.HILELMDICPD(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.MGBGALGPMCL(NBAKCIDALOF, this.NFBCDIEENBO(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.IDEICOFBBIO(true);
		}

		// Token: 0x0600F2EE RID: 62190 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool LNCBMLPDFKO()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F2EF RID: 62191 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool PFCLPDIAINH()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F2F0 RID: 62192 RVA: 0x006D0A5C File Offset: 0x006CEC5C
		public void KLNJKEEICKH(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.IBAOFCILPHA(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.IBAOFCILPHA(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.CDFABPFGKMD(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OODAFBLFOJL(NBAKCIDALOF, this.MDPKKCEACND(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.IDEICOFBBIO(true);
		}

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x006D0B54 File Offset: 0x006CED54
		private Vector3 NFBCDIEENBO(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.BOELAJLMOGH(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.PFDOFAGICJA(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F2F2 RID: 62194 RVA: 0x006D0BA0 File Offset: 0x006CEDA0
		public void DPOFMEPOJED(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.GCBAMHKFDID(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.CDFABPFGKMD(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.CDFABPFGKMD(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OKJALMCEACH(NBAKCIDALOF, this.GIODBKKMJNJ(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.EEKIOKFFBGJ(false);
		}

		// Token: 0x0600F2F3 RID: 62195 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void IDEICOFBBIO(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F2F4 RID: 62196 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void HDNLLANMLHK(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void PBMCPIDHGDN(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F2F6 RID: 62198 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void HNNKBGAINCA(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void LHDHBLIMDNH(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void ALAJFLMEFDC(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F2F9 RID: 62201 RVA: 0x006D0CB8 File Offset: 0x006CEEB8
		public bool BIIFBFENPGN(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Hey, you can easily change me in memory!");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("white" + this.bone1.name + "Titul");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("_NeighbourMaxTex" + this.bone2.name + "Giant2HandGrab");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("' that does not excist in the Node Chain." + this.bone3.name + "_Overlay");
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600F2FA RID: 62202 RVA: 0x006D0D9C File Offset: 0x006CEF9C
		private Vector3 KECDMDAOBNL(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OODFEEFPAHG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F2FB RID: 62203 RVA: 0x006D0DE8 File Offset: 0x006CEFE8
		private Vector3 FGDMAHKGFKC(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F2FC RID: 62204 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void FAAKKBABDKD(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F2FD RID: 62205 RVA: 0x006D0E34 File Offset: 0x006CF034
		public void ELLKGAPMLJE(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.GCBAMHKFDID(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.DJAPGCBALGA(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.GCBAMHKFDID(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OKJALMCEACH(NBAKCIDALOF, this.GIODBKKMJNJ(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.IDEICOFBBIO(true);
		}

		// Token: 0x0600F2FE RID: 62206 RVA: 0x006D0F2C File Offset: 0x006CF12C
		public void EJJIBAHAPKL(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.GEAPMLDBGGI())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 0, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 236f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 1087f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F2FF RID: 62207 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool GEAPMLDBGGI()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F300 RID: 62208 RVA: 0x006D1064 File Offset: 0x006CF264
		public void LHOEOFKKAKK(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.HILELMDICPD(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.CDFABPFGKMD(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.CFGCGBAFECA(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.KIDHNLLHCLB(NBAKCIDALOF, this.NFBCDIEENBO(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.KAICNFNPBNA(false);
		}

		// Token: 0x0600F301 RID: 62209 RVA: 0x006D115C File Offset: 0x006CF35C
		public void PJFHMMHHBEN(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.GCBAMHKFDID(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.KCPBCEJMAOG(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.HILELMDICPD(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.FJJCAKDBCLB(NBAKCIDALOF, this.EBNHKENIPPP(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.EEKIOKFFBGJ(true);
		}

		// Token: 0x0600F302 RID: 62210 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void PKFDPGOGEJO(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F303 RID: 62211 RVA: 0x006D1254 File Offset: 0x006CF454
		public void EPHNKAEHNBO(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.AHLLPEAFFDC())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 1, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 484f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 601f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F304 RID: 62212 RVA: 0x006D138A File Offset: 0x006CF58A
		public IKConstraintBend(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.DLJHEBPABFF(FCDAMCBKONG, GLGMAJBNFIA, NLHIDOGKOIP);
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x006D13B1 File Offset: 0x006CF5B1
		public IKConstraintBend()
		{
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x006D13D0 File Offset: 0x006CF5D0
		public Vector3 CEMPLCBOPCG(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.GEAPMLDBGGI())
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 469f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.BOELAJLMOGH(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.CIAODBAIJMF(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 465f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.CIAODBAIJMF(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 159f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F307 RID: 62215 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void ALCBOBLCENH(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F308 RID: 62216 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void DLJHEBPABFF(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F309 RID: 62217 RVA: 0x006D158C File Offset: 0x006CF78C
		public void OECNHGIPNLB(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CGKMGMDDPKB(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.IBAOFCILPHA(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.HILELMDICPD(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.CKHFCJAICGG(NBAKCIDALOF, this.DOCFFEEBNJJ(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.NIGEKOEBIAD(false);
		}

		// Token: 0x0600F30A RID: 62218 RVA: 0x006D1684 File Offset: 0x006CF884
		private Vector3 DOCFFEEBNJJ(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F30B RID: 62219 RVA: 0x006D16D0 File Offset: 0x006CF8D0
		public Vector3 AINBEMODFIL(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.GEAPMLDBGGI())
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.PFDOFAGICJA(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 579f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.CIAODBAIJMF(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 1505f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 1056f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool DIBAEGBHGAJ()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F30D RID: 62221 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void FIJBIBNJAMN(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F30E RID: 62222 RVA: 0x006D188C File Offset: 0x006CFA8C
		public bool GGHCAMNAIDE(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("{not_found}");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("IdleReadyCrouch" + this.bone1.name + "Chromatic Aberration Spectrum Lookup");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("sys" + this.bone2.name + "Shadow name=");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("UnityEngine.Vector3" + this.bone3.name + "Swim");
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F30F RID: 62223 RVA: 0x006D1970 File Offset: 0x006CFB70
		private Vector3 GLFCLIMJJGL(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.CIAODBAIJMF(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.BOELAJLMOGH(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F310 RID: 62224 RVA: 0x006D19BC File Offset: 0x006CFBBC
		public void NICOAHFBPNO(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F311 RID: 62225 RVA: 0x006D1A28 File Offset: 0x006CFC28
		public void HFEEPBDDCKO(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CGKMGMDDPKB(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.HILELMDICPD(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.KBODJMDJLFF(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.CKHFCJAICGG(NBAKCIDALOF, this.FJLLHJFMGFE(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.HIKMCOGFHFE(true);
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool MNLFEGALCPA()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F313 RID: 62227 RVA: 0x006D1B20 File Offset: 0x006CFD20
		private Vector3 MGBGALGPMCL(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F314 RID: 62228 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void HLODHMINFLL(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F315 RID: 62229 RVA: 0x006D1B6C File Offset: 0x006CFD6C
		public Vector3 KNNAGOOJGMH(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.DIBAEGBHGAJ())
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 1226f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.PFDOFAGICJA(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 1890f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 680f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F316 RID: 62230 RVA: 0x006D1D28 File Offset: 0x006CFF28
		public bool OKMIMMMKBKO(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(" ");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("SkateboardKickPush" + this.bone1.name + "[X]");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("#606000" + this.bone2.name + "CHROMATIC_ABERRATION");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("WaveSpeed" + this.bone3.name + "isFishGet");
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x006D1E0C File Offset: 0x006D000C
		public void MABPJFMDNFF(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.AHLLPEAFFDC())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 1, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 1623f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 633f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F318 RID: 62232 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void DGLFGPBNFKH(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F319 RID: 62233 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool ANKLCAHHEDM()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600F320 RID: 62240 RVA: 0x006D0A53 File Offset: 0x006CEC53
		// (set) Token: 0x0600F31A RID: 62234 RVA: 0x006D0C97 File Offset: 0x006CEE97
		public bool initiated { get; private set; }

		// Token: 0x0600F31B RID: 62235 RVA: 0x006D1F44 File Offset: 0x006D0144
		public Vector3 NLADBBBNLLI(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.LNCBMLPDFKO())
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.BOELAJLMOGH(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 947f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.BOELAJLMOGH(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 776f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 692f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F31C RID: 62236 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void KAICNFNPBNA(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F31D RID: 62237 RVA: 0x006D2100 File Offset: 0x006D0300
		private Vector3 KIDHNLLHCLB(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.OODFEEFPAHG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F31E RID: 62238 RVA: 0x006D214C File Offset: 0x006D034C
		public void FLLDFIKDPNN(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("_UV_Transform");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("_DistCenterScale");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F31F RID: 62239 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool IBLFDFBJPAJ()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F321 RID: 62241 RVA: 0x006D21B8 File Offset: 0x006D03B8
		public void BEBKPNFAMHG(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("Try to change this string in memory:\n");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("SoccerKeeperReady");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("RollerBladeRoll");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F322 RID: 62242 RVA: 0x006D2224 File Offset: 0x006D0424
		private Vector3 FJJCAKDBCLB(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.BOELAJLMOGH(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F323 RID: 62243 RVA: 0x006D2270 File Offset: 0x006D0470
		private Vector3 OODAFBLFOJL(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F324 RID: 62244 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool FFPBGOOKPHE()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F325 RID: 62245 RVA: 0x006D22BC File Offset: 0x006D04BC
		public void GLPKICANILF(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.AHLLPEAFFDC())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 1, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 1401f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 1124f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F326 RID: 62246 RVA: 0x006D23F4 File Offset: 0x006D05F4
		public void BPJKGOJOLPL(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.MNLFEGALCPA())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = true;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 1, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 131f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 1426f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F327 RID: 62247 RVA: 0x006D252C File Offset: 0x006D072C
		private Vector3 OHHONMBEIGG(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F328 RID: 62248 RVA: 0x006D2578 File Offset: 0x006D0778
		public void BHEMBCPPIPH(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("SteamManager.Initialized failed");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("GiantGrabIdle2");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("inv_pcs1");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F329 RID: 62249 RVA: 0x006D25E4 File Offset: 0x006D07E4
		public void PANFIBJMHFO(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("_Intensity");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("WallRunRight");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("mask=");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F32A RID: 62250 RVA: 0x006D2650 File Offset: 0x006D0850
		public Vector3 IDIBDNEBMJG(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.BOELAJLMOGH(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 538f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 1172f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 1588f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F32B RID: 62251 RVA: 0x006D280C File Offset: 0x006D0A0C
		public bool LLHDJAGFPIG(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(" ms");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("crft_norec" + this.bone1.name + "_DepthOfFieldParams");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Hidden/Post FX/FXAA" + this.bone2.name + "/Localization/langsettings.xml");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("inv_bonus" + this.bone3.name + "_NoiseTex");
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600F32C RID: 62252 RVA: 0x006D28F0 File Offset: 0x006D0AF0
		private Vector3 EBNHKENIPPP(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.GIEPGCFCIBI(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F32D RID: 62253 RVA: 0x006D293C File Offset: 0x006D0B3C
		public Vector3 AALHLODDKFH(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.OODFEEFPAHG(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 1f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OODFEEFPAHG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 0f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 0f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F32E RID: 62254 RVA: 0x006D2AF8 File Offset: 0x006D0CF8
		private Vector3 FJLLHJFMGFE(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F32F RID: 62255 RVA: 0x006D2B44 File Offset: 0x006D0D44
		private Vector3 OKJALMCEACH(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.OODFEEFPAHG(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x006D2B90 File Offset: 0x006D0D90
		public void GKPOLAMAAAG(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("wpn_book2");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("_Cutoff");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("cntx_drop");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F331 RID: 62257 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool AHLLPEAFFDC()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F332 RID: 62258 RVA: 0x006D2BFC File Offset: 0x006D0DFC
		private Vector3 PAPLNFGLCPM(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F333 RID: 62259 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void GKIFFCJHHFB(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F334 RID: 62260 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void PFICKHPBFJM(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F335 RID: 62261 RVA: 0x006D2C48 File Offset: 0x006D0E48
		private Vector3 CKHFCJAICGG(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.BOELAJLMOGH(this.chainIndex2, this.nodeIndex2).solverPosition - NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F336 RID: 62262 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void HIKMCOGFHFE(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F337 RID: 62263 RVA: 0x006D2C94 File Offset: 0x006D0E94
		public void FDELDECKPMK(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CFGCGBAFECA(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.GCBAMHKFDID(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.KCPBCEJMAOG(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.FJJCAKDBCLB(NBAKCIDALOF, this.PAPLNFGLCPM(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.initiated = false;
		}

		// Token: 0x0600F338 RID: 62264 RVA: 0x006D2D8C File Offset: 0x006D0F8C
		public void EPLKHNGNHBL(Vector3 DENLOFEMFGC, Vector3 CNFCKOGPPFO, Vector3 MLEIFLFOOJE)
		{
			if (DENLOFEMFGC == Vector3.zero)
			{
				Debug.LogError("RunningDance");
			}
			if (CNFCKOGPPFO == Vector3.zero)
			{
				Debug.LogError("IdleFight");
			}
			if (MLEIFLFOOJE == Vector3.zero)
			{
				Debug.LogError("_FogVoidPosition");
			}
			this.defaultLocalDirection = DENLOFEMFGC.normalized;
			this.defaultChildDirection = MLEIFLFOOJE.normalized;
		}

		// Token: 0x0600F339 RID: 62265 RVA: 0x006D2DF8 File Offset: 0x006D0FF8
		public Vector3 GHLPGHJBHLP(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.MNLFEGALCPA())
			{
				return Vector3.zero;
			}
			float num = this.weight * NBAKCIDALOF.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 1140f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = NBAKCIDALOF.PFDOFAGICJA(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.PFDOFAGICJA(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 1833f)
			{
				Vector3 b = -Vector3.Cross(vector, NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, NBAKCIDALOF.BOELAJLMOGH(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 1662f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x0600F33A RID: 62266 RVA: 0x006D2FB4 File Offset: 0x006D11B4
		public void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.KBODJMDJLFF(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.KBODJMDJLFF(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.KBODJMDJLFF(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OKJALMCEACH(NBAKCIDALOF, this.KECDMDAOBNL(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.initiated = true;
		}

		// Token: 0x0600F33B RID: 62267 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void EEKIOKFFBGJ(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F33C RID: 62268 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void CJBAAGEPCON(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x0600F33D RID: 62269 RVA: 0x006D30AC File Offset: 0x006D12AC
		public void PPFLAJHIIPF(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.PIJFNBLADPO())
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = true;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 0, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 1247f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 1473f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F33E RID: 62270 RVA: 0x006D31E4 File Offset: 0x006D13E4
		public void NPCHHADBLMC(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.KCPBCEJMAOG(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.CGKMGMDDPKB(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.CGKMGMDDPKB(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OODAFBLFOJL(NBAKCIDALOF, this.KECDMDAOBNL(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.IDEICOFBBIO(false);
		}

		// Token: 0x0600F33F RID: 62271 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool GECBDOOPAJP()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F340 RID: 62272 RVA: 0x006D32DC File Offset: 0x006D14DC
		public void JHOFFCADAOD(float CPGFBJGKGMF, float BFIDELOIIGI)
		{
			if (!this.initiated)
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 vector2 = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = OOJJKBHKGNJ.PNFHIEFDEGD(vector2, vector, this.clampF * CPGFBJGKGMF, 0, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(vector2, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (BFIDELOIIGI > 0f)
			{
				Vector3 vector3 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, BFIDELOIIGI * CPGFBJGKGMF);
			}
			if (flag || BFIDELOIIGI > 0f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x006D3414 File Offset: 0x006D1614
		public void LLPMNHOBPAJ(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CDFABPFGKMD(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.IBAOFCILPHA(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.GCBAMHKFDID(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OKJALMCEACH(NBAKCIDALOF, this.DOCFFEEBNJJ(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.KAICNFNPBNA(true);
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x006D350C File Offset: 0x006D170C
		private Vector3 GIODBKKMJNJ(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.BOELAJLMOGH(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.PFDOFAGICJA(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x006D3558 File Offset: 0x006D1758
		public bool OLOMKGGLEAJ(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Error! ");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("result" + this.bone1.name + "GiantGrabIdle2");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("left" + this.bone2.name + "FishbragContainer");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("IdleTurns" + this.bone3.name + "_Overlay");
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F344 RID: 62276 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void JCHPEONOLPK(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F345 RID: 62277 RVA: 0x006D363C File Offset: 0x006D183C
		public bool CHFHJDFDIGB(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Bend Constraint contains a null reference.");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Bend Constraint is referencing to a bone '" + this.bone1.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Bend Constraint is referencing to a bone '" + this.bone2.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Bend Constraint is referencing to a bone '" + this.bone3.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600F346 RID: 62278 RVA: 0x006D0C97 File Offset: 0x006CEE97
		private void NIGEKOEBIAD(bool DCCPCBLODIG)
		{
			this.<initiated>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600F347 RID: 62279 RVA: 0x006D3720 File Offset: 0x006D1920
		private Vector3 MDPKKCEACND(IKSolverFullBody NBAKCIDALOF, Vector3 BOGIINEDPCF)
		{
			Vector3 vector = NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex3, this.nodeIndex3).solverPosition - NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref BOGIINEDPCF);
			return BOGIINEDPCF;
		}

		// Token: 0x0600F348 RID: 62280 RVA: 0x006D376C File Offset: 0x006D196C
		public bool CEHHFHPKPCH(IKSolverFullBody NBAKCIDALOF, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("post_5");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone1) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("demoRect" + this.bone1.name + "gi_uinf_3i");
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone2) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("Roller Crossover Left" + this.bone2.name + "DepthTolerance");
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(this.bone3) == null)
			{
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG("post_msg6" + this.bone3.name + "Prefabs/FogBoxArea");
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F349 RID: 62281 RVA: 0x006D0A53 File Offset: 0x006CEC53
		public bool PIJFNBLADPO()
		{
			return this.<initiated>k__BackingField;
		}

		// Token: 0x0600F34A RID: 62282 RVA: 0x006D3850 File Offset: 0x006D1A50
		public void CKHKJOHKMEE(IKSolverFullBody NBAKCIDALOF)
		{
			NBAKCIDALOF.CGKMGMDDPKB(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			NBAKCIDALOF.CGKMGMDDPKB(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			NBAKCIDALOF.CGKMGMDDPKB(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OODAFBLFOJL(NBAKCIDALOF, this.MDPKKCEACND(NBAKCIDALOF, this.bone2.position - this.bone1.position));
			this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
			Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
			this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			this.HLODHMINFLL(true);
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x006D0CA0 File Offset: 0x006CEEA0
		public void NKJFHALGKMN(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, Transform NLHIDOGKOIP)
		{
			this.bone1 = FCDAMCBKONG;
			this.bone2 = GLGMAJBNFIA;
			this.bone3 = NLHIDOGKOIP;
		}

		// Token: 0x04001FBE RID: 8126
		public Transform bone1;

		// Token: 0x04001FBF RID: 8127
		public Transform bone2;

		// Token: 0x04001FC0 RID: 8128
		public Transform bone3;

		// Token: 0x04001FC1 RID: 8129
		public Transform bendGoal;

		// Token: 0x04001FC2 RID: 8130
		public Vector3 direction = Vector3.right;

		// Token: 0x04001FC3 RID: 8131
		public Quaternion rotationOffset;

		// Token: 0x04001FC4 RID: 8132
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04001FC5 RID: 8133
		public Vector3 defaultLocalDirection;

		// Token: 0x04001FC6 RID: 8134
		public Vector3 defaultChildDirection;

		// Token: 0x04001FC7 RID: 8135
		[NonSerialized]
		public float clampF = 0.505f;

		// Token: 0x04001FC8 RID: 8136
		private int chainIndex1;

		// Token: 0x04001FC9 RID: 8137
		private int nodeIndex1;

		// Token: 0x04001FCA RID: 8138
		private int chainIndex2;

		// Token: 0x04001FCB RID: 8139
		private int nodeIndex2;

		// Token: 0x04001FCC RID: 8140
		private int chainIndex3;

		// Token: 0x04001FCD RID: 8141
		private int nodeIndex3;
	}
}
