using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004C5 RID: 1221
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06010A4A RID: 68170 RVA: 0x0076844E File Offset: 0x0076664E
		protected float ENLHBNBNPJN
		{
			get
			{
				return Time.time - this.EDCFDDLFAHG;
			}
		}

		// Token: 0x06010A4B RID: 68171
		protected abstract void HEHOBGDMLOK();

		// Token: 0x06010A4C RID: 68172 RVA: 0x0076845C File Offset: 0x0076665C
		protected virtual void Start()
		{
			base.StartCoroutine(this.BHALELINNDJ());
		}

		// Token: 0x06010A4D RID: 68173 RVA: 0x0076846B File Offset: 0x0076666B
		private IEnumerator BHALELINNDJ()
		{
			while (this.ik == null)
			{
				yield return null;
			}
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MEGDOKAPBOL));
			this.EDCFDDLFAHG = Time.time;
			yield break;
		}

		// Token: 0x06010A4E RID: 68174 RVA: 0x0076847C File Offset: 0x0076667C
		private void MEGDOKAPBOL()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.ENLHBNBNPJN <= 0f)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			this.HEHOBGDMLOK();
			this.EDCFDDLFAHG = Time.time;
		}

		// Token: 0x06010A4F RID: 68175 RVA: 0x007684EC File Offset: 0x007666EC
		protected void HPEMKHLDHFA(OffsetModifier.OffsetLimits[] FAFPLHIPMGC)
		{
			foreach (OffsetModifier.OffsetLimits offsetLimits in FAFPLHIPMGC)
			{
				offsetLimits.DCLNJPIBFIA(this.ik.solver.OEEPHOCHILL(offsetLimits.effector), base.transform.rotation);
			}
		}

		// Token: 0x06010A50 RID: 68176 RVA: 0x00768534 File Offset: 0x00766734
		protected virtual void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MEGDOKAPBOL));
			}
		}

		// Token: 0x040022A8 RID: 8872
		[Tooltip("The master weight")]
		public float weight = 1f;

		// Token: 0x040022A9 RID: 8873
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		// Token: 0x040022AA RID: 8874
		protected float EDCFDDLFAHG;

		// Token: 0x020004C6 RID: 1222
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x06010A52 RID: 68178 RVA: 0x00768584 File Offset: 0x00766784
			public void ILKCCHANKFJ(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 328f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PKDKPILIABP(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.DICLGALHFAM(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.PKDKPILIABP(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A53 RID: 68179 RVA: 0x007686A9 File Offset: 0x007668A9
			private float GLCFNKKJLLD(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.PLLKOMCOKBA(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.PLLKOMCOKBA(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A54 RID: 68180 RVA: 0x007686CC File Offset: 0x007668CC
			public void BGFHABPGLFL(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 666f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.GLCFNKKJLLD(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.NDOOMBFLEFA(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.NDOOMBFLEFA(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A55 RID: 68181 RVA: 0x007687F4 File Offset: 0x007669F4
			private float MLNCDAFOAHL(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1904f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1714f, num);
			}

			// Token: 0x06010A56 RID: 68182 RVA: 0x00768830 File Offset: 0x00766A30
			private float NDOOMBFLEFA(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.NBLKCOLIOPK(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.IAKHBBGPDPP(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A57 RID: 68183 RVA: 0x00768854 File Offset: 0x00766A54
			private float DKIJILFBFHK(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 565f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 964f, num);
			}

			// Token: 0x06010A58 RID: 68184 RVA: 0x00768890 File Offset: 0x00766A90
			private float DNIKOPOIMLA(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1608f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 241f, num);
			}

			// Token: 0x06010A59 RID: 68185 RVA: 0x007688CC File Offset: 0x00766ACC
			private float HGODLIKODOM(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 701f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 290f, num);
			}

			// Token: 0x06010A5A RID: 68186 RVA: 0x00768908 File Offset: 0x00766B08
			public void LBCOFBOKHJP(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1883f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.CGJJINKLLJA(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.KKALCLCBFAL(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A5B RID: 68187 RVA: 0x00768A30 File Offset: 0x00766C30
			private float IAKHBBGPDPP(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1551f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 926f, num);
			}

			// Token: 0x06010A5C RID: 68188 RVA: 0x00768A6C File Offset: 0x00766C6C
			private float DLGEEIGNKIJ(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.OKKNHPKIIME(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.JILEAGPGFON(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A5D RID: 68189 RVA: 0x00768A90 File Offset: 0x00766C90
			public void IIDLIPDCNJJ(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1582f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PAKCAKJLPDP(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.DLGEEIGNKIJ(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.IAADCEADCMK(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A5E RID: 68190 RVA: 0x00768BB5 File Offset: 0x00766DB5
			private float IAADCEADCMK(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.OKKNHPKIIME(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.GKCFFNCKJDB(DCCPCBLODIG, DAILMANBNMM, true);
			}

			// Token: 0x06010A5F RID: 68191 RVA: 0x00768BD8 File Offset: 0x00766DD8
			private float OPBOICHOBPE(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 738f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1643f, num);
			}

			// Token: 0x06010A60 RID: 68192 RVA: 0x00768C14 File Offset: 0x00766E14
			public void AKCCCGDAJGI(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1916f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PKDKPILIABP(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.CGJJINKLLJA(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.DICLGALHFAM(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A61 RID: 68193 RVA: 0x00768D3C File Offset: 0x00766F3C
			public void GDMKIGLFFDN(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1784f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.KKALCLCBFAL(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.DLGEEIGNKIJ(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.IAADCEADCMK(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A62 RID: 68194 RVA: 0x00768E64 File Offset: 0x00767064
			private float PEAGEDMMENO(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1910f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 393f, num);
			}

			// Token: 0x06010A63 RID: 68195 RVA: 0x00768EA0 File Offset: 0x007670A0
			public void HCNGBMPDFBM(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 155f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.GLCFNKKJLLD(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.CGJJINKLLJA(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.DICLGALHFAM(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A64 RID: 68196 RVA: 0x00768FC8 File Offset: 0x007671C8
			private float OOAMAJAPFMI(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 154f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1899f, num);
			}

			// Token: 0x06010A65 RID: 68197 RVA: 0x00769004 File Offset: 0x00767204
			public void MCLLJAHGJLP(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 532f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.BMLGCKKJKEO(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.DLGEEIGNKIJ(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A66 RID: 68198 RVA: 0x0076912C File Offset: 0x0076732C
			public void FFGPELHNHOF(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 900f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.IAADCEADCMK(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.KKALCLCBFAL(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.GLCFNKKJLLD(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A67 RID: 68199 RVA: 0x00769254 File Offset: 0x00767454
			private float GKCFFNCKJDB(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 805f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1733f, num);
			}

			// Token: 0x06010A68 RID: 68200 RVA: 0x00769290 File Offset: 0x00767490
			private float CGJJINKLLJA(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.CJHCHNFGDPE(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.DPBLABJIPMB(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A69 RID: 68201 RVA: 0x007692B4 File Offset: 0x007674B4
			private float DPBLABJIPMB(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 346f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 239f, num);
			}

			// Token: 0x06010A6A RID: 68202 RVA: 0x007692F0 File Offset: 0x007674F0
			public void GPAMMKENIAH(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1056f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.KKALCLCBFAL(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.PIEINHDFGBA(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.PIEINHDFGBA(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A6B RID: 68203 RVA: 0x00769415 File Offset: 0x00767615
			private float PIEINHDFGBA(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.EDDGKHNCMMO(DCCPCBLODIG, FNADKBPAGJH, false);
				}
				return this.EDDGKHNCMMO(DCCPCBLODIG, DAILMANBNMM, true);
			}

			// Token: 0x06010A6C RID: 68204 RVA: 0x00769438 File Offset: 0x00767638
			private float BMLGCKKJKEO(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.GKCFFNCKJDB(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.EDDGKHNCMMO(DCCPCBLODIG, DAILMANBNMM, true);
			}

			// Token: 0x06010A6D RID: 68205 RVA: 0x0076945C File Offset: 0x0076765C
			public void KOFAHMHMOCG(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 290f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PIEINHDFGBA(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.PAKCAKJLPDP(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.JHOAOIKKOEJ(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A6E RID: 68206 RVA: 0x00769584 File Offset: 0x00767784
			public void IBIBHHPEFEJ(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 819f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.DLGEEIGNKIJ(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.DLGEEIGNKIJ(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.NDOOMBFLEFA(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A6F RID: 68207 RVA: 0x007696AC File Offset: 0x007678AC
			private float PLLKOMCOKBA(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 0f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 0f, num);
			}

			// Token: 0x06010A71 RID: 68209 RVA: 0x007696E8 File Offset: 0x007678E8
			public void CAPLBHGKKHA(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 505f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.GLCFNKKJLLD(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.IAADCEADCMK(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.GLCFNKKJLLD(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A72 RID: 68210 RVA: 0x00769810 File Offset: 0x00767A10
			private float NBLKCOLIOPK(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1111f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 62f, num);
			}

			// Token: 0x06010A73 RID: 68211 RVA: 0x0076984C File Offset: 0x00767A4C
			private float DICLGALHFAM(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.EJJFMHKDLEE(DCCPCBLODIG, FNADKBPAGJH, false);
				}
				return this.HGODLIKODOM(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A74 RID: 68212 RVA: 0x00769870 File Offset: 0x00767A70
			private float JILEAGPGFON(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 916f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 326f, num);
			}

			// Token: 0x06010A75 RID: 68213 RVA: 0x007698AC File Offset: 0x00767AAC
			public void JBNOIPHEGDP(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 847f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PKDKPILIABP(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.CGJJINKLLJA(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A76 RID: 68214 RVA: 0x007699D4 File Offset: 0x00767BD4
			private float LLMBNFJJMBF(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 110f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 778f, num);
			}

			// Token: 0x06010A77 RID: 68215 RVA: 0x00769A10 File Offset: 0x00767C10
			private float CJHCHNFGDPE(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 979f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 699f, num);
			}

			// Token: 0x06010A78 RID: 68216 RVA: 0x00769A4C File Offset: 0x00767C4C
			private float EMNPOGFGKHE(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1327f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 107f, num);
			}

			// Token: 0x06010A79 RID: 68217 RVA: 0x00769A88 File Offset: 0x00767C88
			private float KKCIEKPOJDL(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 219f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 663f, num);
			}

			// Token: 0x06010A7A RID: 68218 RVA: 0x00769AC4 File Offset: 0x00767CC4
			private float PCGCFLJEDGD(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1492f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1732f, num);
			}

			// Token: 0x06010A7B RID: 68219 RVA: 0x00769B00 File Offset: 0x00767D00
			private float MNKBMOKHNEA(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1261f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 2f, num);
			}

			// Token: 0x06010A7C RID: 68220 RVA: 0x00769B3C File Offset: 0x00767D3C
			public void DCLNJPIBFIA(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 0f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.GLCFNKKJLLD(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.GLCFNKKJLLD(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A7D RID: 68221 RVA: 0x00769C61 File Offset: 0x00767E61
			private float PKDKPILIABP(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.PCGCFLJEDGD(DCCPCBLODIG, FNADKBPAGJH, false);
				}
				return this.HHIGBBFHJBG(DCCPCBLODIG, DAILMANBNMM, true);
			}

			// Token: 0x06010A7E RID: 68222 RVA: 0x00769C84 File Offset: 0x00767E84
			public void DDLKHEECNKP(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 395f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.KKALCLCBFAL(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.JHOAOIKKOEJ(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A7F RID: 68223 RVA: 0x00769DAC File Offset: 0x00767FAC
			public void JAKKDJFKMDO(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1943f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.PKDKPILIABP(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.DICLGALHFAM(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.PIEINHDFGBA(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A80 RID: 68224 RVA: 0x00769ED1 File Offset: 0x007680D1
			private float KKALCLCBFAL(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.MLIGOAMEBAD(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.OPBOICHOBPE(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A81 RID: 68225 RVA: 0x00769EF4 File Offset: 0x007680F4
			public void FNPOICECOOI(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 817f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.BMLGCKKJKEO(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.GLCFNKKJLLD(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.DICLGALHFAM(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A82 RID: 68226 RVA: 0x0076A01C File Offset: 0x0076821C
			private float HHIGBBFHJBG(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 792f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 67f, num);
			}

			// Token: 0x06010A83 RID: 68227 RVA: 0x0076A058 File Offset: 0x00768258
			private float MLIGOAMEBAD(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 84f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1258f, num);
			}

			// Token: 0x06010A84 RID: 68228 RVA: 0x0076A094 File Offset: 0x00768294
			private float JHOAOIKKOEJ(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.JILEAGPGFON(DCCPCBLODIG, FNADKBPAGJH, false);
				}
				return this.NBLKCOLIOPK(DCCPCBLODIG, DAILMANBNMM, true);
			}

			// Token: 0x06010A85 RID: 68229 RVA: 0x0076A0B8 File Offset: 0x007682B8
			private float PPKCFBHKEBC(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 504f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1218f, num);
			}

			// Token: 0x06010A86 RID: 68230 RVA: 0x0076A0F4 File Offset: 0x007682F4
			private float KIGPIJNNNGI(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1491f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1056f, num);
			}

			// Token: 0x06010A87 RID: 68231 RVA: 0x0076A130 File Offset: 0x00768330
			private float CPDMPEJFJNG(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 402f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1467f, num);
			}

			// Token: 0x06010A88 RID: 68232 RVA: 0x0076A16C File Offset: 0x0076836C
			private float OKODOAHOGAE(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 89f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1940f, num);
			}

			// Token: 0x06010A89 RID: 68233 RVA: 0x0076A1A8 File Offset: 0x007683A8
			private float OKKNHPKIIME(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 7f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1244f, num);
			}

			// Token: 0x06010A8A RID: 68234 RVA: 0x0076A1E4 File Offset: 0x007683E4
			private float PAKCAKJLPDP(float DCCPCBLODIG, float FNADKBPAGJH, float DAILMANBNMM)
			{
				if (DCCPCBLODIG > FNADKBPAGJH && DCCPCBLODIG < DAILMANBNMM)
				{
					return DCCPCBLODIG;
				}
				if (DCCPCBLODIG < FNADKBPAGJH)
				{
					return this.DNIKOPOIMLA(DCCPCBLODIG, FNADKBPAGJH, true);
				}
				return this.EMNPOGFGKHE(DCCPCBLODIG, DAILMANBNMM, false);
			}

			// Token: 0x06010A8B RID: 68235 RVA: 0x0076A208 File Offset: 0x00768408
			private float EDDGKHNCMMO(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 770f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1085f, num);
			}

			// Token: 0x06010A8C RID: 68236 RVA: 0x0076A244 File Offset: 0x00768444
			public void BKHIGJJNHAE(IKEffector PBDMCLPNCBJ, Quaternion AENGNNEIKJN)
			{
				Vector3 vector = Quaternion.Inverse(AENGNNEIKJN) * PBDMCLPNCBJ.positionOffset;
				if (this.spring <= 1948f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.NDOOMBFLEFA(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.NDOOMBFLEFA(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.PKDKPILIABP(vector.z, this.minZ, this.maxZ);
					}
				}
				PBDMCLPNCBJ.positionOffset = AENGNNEIKJN * vector;
			}

			// Token: 0x06010A8D RID: 68237 RVA: 0x0076A36C File Offset: 0x0076856C
			private float EJJFMHKDLEE(float DCCPCBLODIG, float JKCLLPDKDDI, bool GPPEACJIPCN)
			{
				float num = DCCPCBLODIG - JKCLLPDKDDI;
				float num2 = num * this.spring;
				if (GPPEACJIPCN)
				{
					return DCCPCBLODIG + Mathf.Clamp(-num2, 1458f, -num);
				}
				return DCCPCBLODIG - Mathf.Clamp(num2, 1226f, num);
			}

			// Token: 0x040022AB RID: 8875
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			// Token: 0x040022AC RID: 8876
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			// Token: 0x040022AD RID: 8877
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			// Token: 0x040022AE RID: 8878
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			// Token: 0x040022AF RID: 8879
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			// Token: 0x040022B0 RID: 8880
			[Tooltip("The limits")]
			public float minX;

			// Token: 0x040022B1 RID: 8881
			[Tooltip("The limits")]
			public float maxX;

			// Token: 0x040022B2 RID: 8882
			[Tooltip("The limits")]
			public float minY;

			// Token: 0x040022B3 RID: 8883
			[Tooltip("The limits")]
			public float maxY;

			// Token: 0x040022B4 RID: 8884
			[Tooltip("The limits")]
			public float minZ;

			// Token: 0x040022B5 RID: 8885
			[Tooltip("The limits")]
			public float maxZ;
		}
	}
}
