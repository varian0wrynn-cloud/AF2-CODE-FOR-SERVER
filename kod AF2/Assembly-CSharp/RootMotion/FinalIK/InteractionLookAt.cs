using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200048D RID: 1165
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x0600FE84 RID: 65156 RVA: 0x0072B158 File Offset: 0x00729358
		public void BBFAAPIHDMJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1672f;
			this.ik.solver.eyesWeight = 330f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE85 RID: 65157 RVA: 0x0072B1FC File Offset: 0x007293FC
		public void EMECJHHGFKB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1963f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FE86 RID: 65158 RVA: 0x0072B270 File Offset: 0x00729470
		public void FHHCBPBDPGG(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1986f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1897f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE87 RID: 65159 RVA: 0x0072B2FC File Offset: 0x007294FC
		public void KFBHAMLDIMN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 11f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE88 RID: 65160 RVA: 0x0072B370 File Offset: 0x00729570
		public void LFFOBJJALAO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1838f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE89 RID: 65161 RVA: 0x0072B3E4 File Offset: 0x007295E4
		public void PDAFLGAMINH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1526f;
			this.ik.solver.eyesWeight = 1477f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE8A RID: 65162 RVA: 0x0072B488 File Offset: 0x00729688
		public void KDEFLODOFLC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 812f;
			this.ik.solver.eyesWeight = 243f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE8B RID: 65163 RVA: 0x0072B52C File Offset: 0x0072972C
		public void FHNEHFOONPO(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 724f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 245f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE8C RID: 65164 RVA: 0x0072B5B8 File Offset: 0x007297B8
		public void MFHGOLNLAAF()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 1424f, 810f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.MIFFONKAAHP(this.weight, InterpolationMode.InQuadratic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1129f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FE8D RID: 65165 RVA: 0x0072B6CC File Offset: 0x007298CC
		public void DEGCCLNOEKJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 738f, 1728f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NFBGBNIPMFF(this.weight, InterpolationMode.InQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1833f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FE8E RID: 65166 RVA: 0x0072B7E0 File Offset: 0x007299E0
		public void MOHHAEPMPHO(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1379f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1686f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE8F RID: 65167 RVA: 0x0072B86C File Offset: 0x00729A6C
		public void BNLINAAAFEA(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1011f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1695f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE90 RID: 65168 RVA: 0x0072B8F8 File Offset: 0x00729AF8
		public void ENMHMINBNCO(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 168f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1806f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE91 RID: 65169 RVA: 0x0072B984 File Offset: 0x00729B84
		public void ICEPNDCCKHC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1044f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE92 RID: 65170 RVA: 0x0072B9F8 File Offset: 0x00729BF8
		public void PFBAGMNDMLN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1249f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FE93 RID: 65171 RVA: 0x0072BA6C File Offset: 0x00729C6C
		public void HHCCFDHNAPG()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 418f;
			this.ik.solver.eyesWeight = 195f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE94 RID: 65172 RVA: 0x0072BB10 File Offset: 0x00729D10
		public void LFACOFHFEOA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1096f;
			this.ik.solver.eyesWeight = 1583f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE95 RID: 65173 RVA: 0x0072BBB4 File Offset: 0x00729DB4
		public void KEBDEJIAODF()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 1359f, 1027f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.PNJHHPLJDAL(this.weight, InterpolationMode.InOutSine);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1133f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FE96 RID: 65174 RVA: 0x0072BCC8 File Offset: 0x00729EC8
		public void BMAFLDGKIAM()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1935f;
			this.ik.solver.eyesWeight = 1927f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE97 RID: 65175 RVA: 0x0072BD6C File Offset: 0x00729F6C
		public void MKDMMKKBKHK()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1086f;
			this.ik.solver.eyesWeight = 1748f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE98 RID: 65176 RVA: 0x0072BE10 File Offset: 0x0072A010
		public void CEPBFLNFKGJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1771f;
			this.ik.solver.eyesWeight = 482f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE99 RID: 65177 RVA: 0x0072BEB4 File Offset: 0x0072A0B4
		public void DGDMMMHCKMI(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 0f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 3f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE9A RID: 65178 RVA: 0x0072BF40 File Offset: 0x0072A140
		public void FANPFKHEDPA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 0f, 1f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InOutQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 0f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE9B RID: 65179 RVA: 0x0072C054 File Offset: 0x0072A254
		public void CALOIMGPOPH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 2f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE9C RID: 65180 RVA: 0x0072C0C8 File Offset: 0x0072A2C8
		public void PFNOEACNHON()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 297f, 1436f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.PNJHHPLJDAL(this.weight, InterpolationMode.InElastic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1822f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FE9D RID: 65181 RVA: 0x0072C1DC File Offset: 0x0072A3DC
		public void GPHIAGAGNMP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 0f;
			this.ik.solver.eyesWeight = 0f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FE9E RID: 65182 RVA: 0x0072C280 File Offset: 0x0072A480
		public void GNIDNEKCIKM(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1603f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1909f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FE9F RID: 65183 RVA: 0x0072C30C File Offset: 0x0072A50C
		public void PENJHLKOJGM()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 577f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEA0 RID: 65184 RVA: 0x0072C380 File Offset: 0x0072A580
		public void FIEBJMLGELK()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1520f;
			this.ik.solver.eyesWeight = 1611f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEA1 RID: 65185 RVA: 0x0072C424 File Offset: 0x0072A624
		public void NFDFEKGONAP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1393f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEA2 RID: 65186 RVA: 0x0072C498 File Offset: 0x0072A698
		public void PGLCIPOINBL()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1332f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEA3 RID: 65187 RVA: 0x0072C50C File Offset: 0x0072A70C
		public void PKKKIEFAPPE()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1435f;
			this.ik.solver.eyesWeight = 454f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEA4 RID: 65188 RVA: 0x0072C5B0 File Offset: 0x0072A7B0
		public void ABMDFGPBGIB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 273f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEA5 RID: 65189 RVA: 0x0072C624 File Offset: 0x0072A824
		public void PJMHDMINAIB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1473f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEA6 RID: 65190 RVA: 0x0072C698 File Offset: 0x0072A898
		public void KPNIGJJCCKL()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1703f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEA7 RID: 65191 RVA: 0x0072C70C File Offset: 0x0072A90C
		public void CEBBDPFNKKH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 493f;
			this.ik.solver.eyesWeight = 1968f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEA8 RID: 65192 RVA: 0x0072C7B0 File Offset: 0x0072A9B0
		public void BEDAJLJFAFO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 662f, 1458f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 256f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEA9 RID: 65193 RVA: 0x0072C8C4 File Offset: 0x0072AAC4
		public void MMLHGFEPFPF(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 755f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 819f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEAA RID: 65194 RVA: 0x0072C950 File Offset: 0x0072AB50
		public void KCELMJACEDL(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 937f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 866f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEAB RID: 65195 RVA: 0x0072C9DC File Offset: 0x0072ABDC
		public void PPLCMKCAAAC(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1701f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1242f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEAC RID: 65196 RVA: 0x0072CA68 File Offset: 0x0072AC68
		public void HACACFLMIDI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 745f;
			this.ik.solver.eyesWeight = 1477f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEAD RID: 65197 RVA: 0x0072CB0C File Offset: 0x0072AD0C
		public void KKIHGLMLABG()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1639f;
			this.ik.solver.eyesWeight = 1369f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEAE RID: 65198 RVA: 0x0072CBB0 File Offset: 0x0072ADB0
		public void DCHHAENJPNB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 531f;
			this.ik.solver.eyesWeight = 1347f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEAF RID: 65199 RVA: 0x0072CC54 File Offset: 0x0072AE54
		public void DGDBCOBCHLE(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 286f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 361f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEB0 RID: 65200 RVA: 0x0072CCE0 File Offset: 0x0072AEE0
		public void INKGAFANFIB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 722f, 1739f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InOutCubic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1570f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEB1 RID: 65201 RVA: 0x0072CDF4 File Offset: 0x0072AFF4
		public void FBEPDFGHGAJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1926f;
			this.ik.solver.eyesWeight = 1324f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEB2 RID: 65202 RVA: 0x0072CE98 File Offset: 0x0072B098
		public void LMGBKHCHPHO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 1866f, 1033f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InQuadratic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 373f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEB3 RID: 65203 RVA: 0x0072CFAC File Offset: 0x0072B1AC
		public void CHKACGBMEDC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1665f;
			this.ik.solver.eyesWeight = 1488f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEB4 RID: 65204 RVA: 0x0072D050 File Offset: 0x0072B250
		public void LGGBNGEANMM()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 614f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEB5 RID: 65205 RVA: 0x0072D0C4 File Offset: 0x0072B2C4
		public void EGJADIEKCPI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1463f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEB6 RID: 65206 RVA: 0x0072D138 File Offset: 0x0072B338
		public void LENLDPJONHN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 680f;
			this.ik.solver.eyesWeight = 717f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEB7 RID: 65207 RVA: 0x0072D1DC File Offset: 0x0072B3DC
		public void JPHLMNIMDHH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 1137f, 420f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NFBGBNIPMFF(this.weight, InterpolationMode.InCubic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 329f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEB8 RID: 65208 RVA: 0x0072D2F0 File Offset: 0x0072B4F0
		public void GDFHIGFCNGP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 518f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEB9 RID: 65209 RVA: 0x0072D364 File Offset: 0x0072B564
		public void EMFOECIPBIP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 678f, 1190f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InQuartic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1929f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEBA RID: 65210 RVA: 0x0072D478 File Offset: 0x0072B678
		public void PBPFBFLBLFA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 103f;
			this.ik.solver.eyesWeight = 112f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEBB RID: 65211 RVA: 0x0072D51C File Offset: 0x0072B71C
		public void MKGEDJEDHFO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1048f;
			this.ik.solver.eyesWeight = 1150f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEBC RID: 65212 RVA: 0x0072D5C0 File Offset: 0x0072B7C0
		public void JFGGBEGNAFP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 301f, 1073f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.MIFFONKAAHP(this.weight, InterpolationMode.None);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 119f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEBD RID: 65213 RVA: 0x0072D6D4 File Offset: 0x0072B8D4
		public void BHODMHIEAOB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1369f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FEBE RID: 65214 RVA: 0x0072D748 File Offset: 0x0072B948
		public void KODMKGJEHLI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1056f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEBF RID: 65215 RVA: 0x0072D7BC File Offset: 0x0072B9BC
		public void LMLNBKAIEEP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 500f;
			this.ik.solver.eyesWeight = 962f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEC0 RID: 65216 RVA: 0x0072D860 File Offset: 0x0072BA60
		public void KIEKDNINDKB(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1810f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1191f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEC1 RID: 65217 RVA: 0x0072D8EC File Offset: 0x0072BAEC
		public void PAOEDNIDIIN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1185f;
			this.ik.solver.eyesWeight = 573f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEC2 RID: 65218 RVA: 0x0072D990 File Offset: 0x0072BB90
		public void AIJKCBPFPMC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 146f;
			this.ik.solver.eyesWeight = 1843f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEC3 RID: 65219 RVA: 0x0072DA34 File Offset: 0x0072BC34
		public void ANKGIEEOFMP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1834f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEC4 RID: 65220 RVA: 0x0072DAA8 File Offset: 0x0072BCA8
		public void KOPGKJCCELA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 1172f;
			this.ik.solver.eyesWeight = 1737f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEC5 RID: 65221 RVA: 0x0072DB4C File Offset: 0x0072BD4C
		public void FFAEGEBGEBL(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 352f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 943f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEC6 RID: 65222 RVA: 0x0072DBD8 File Offset: 0x0072BDD8
		public void IGEICBNMPAD()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 696f, 1695f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 919f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FEC7 RID: 65223 RVA: 0x0072DCEC File Offset: 0x0072BEEC
		public void OCGGENINACP(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1890f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1595f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FEC8 RID: 65224 RVA: 0x0072DD78 File Offset: 0x0072BF78
		public void GJHKCLKGNIC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 916f;
			this.ik.solver.eyesWeight = 1478f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x0600FEC9 RID: 65225 RVA: 0x0072DE1C File Offset: 0x0072C01C
		public void MEEGCGOIJAA(Transform FFGIAHPIPEK, float GDNOKEOLBPP)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 1477f)
			{
				this.ik.solver.IKPosition = this.ik.solver.CCGINIJINOE().position + this.ik.solver.CCGINIJINOE().forward * 1107f;
			}
			this.lookAtTarget = FFGIAHPIPEK;
			this.stopLookTime = GDNOKEOLBPP;
		}

		// Token: 0x0600FECA RID: 65226 RVA: 0x0072DEA8 File Offset: 0x0072C0A8
		public void BNKJNBIDPME()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 258f, 436f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.PNJHHPLJDAL(this.weight, InterpolationMode.InOutQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 1743f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x0600FECB RID: 65227 RVA: 0x0072DFBC File Offset: 0x0072C1BC
		public void JFCHLKMPOIO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 1115f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FECC RID: 65228 RVA: 0x0072E030 File Offset: 0x0072C230
		public void BGEOPGIJKOJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 0f;
			this.ik.solver.FANPFKHEDPA();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x0600FECD RID: 65229 RVA: 0x0072E0A4 File Offset: 0x0072C2A4
		public void JIBKGOFOPHJ()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = true;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 1627f, 1076f);
			this.ik.solver.IKPositionWeight = AINDCMJDEOG.NAKHKNJFPLK(this.weight, InterpolationMode.InOutQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 796f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = false;
		}

		// Token: 0x04002192 RID: 8594
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		// Token: 0x04002193 RID: 8595
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed = 5f;

		// Token: 0x04002194 RID: 8596
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed = 1f;

		// Token: 0x04002195 RID: 8597
		[HideInInspector]
		public bool isPaused;

		// Token: 0x04002196 RID: 8598
		private Transform lookAtTarget;

		// Token: 0x04002197 RID: 8599
		private float stopLookTime;

		// Token: 0x04002198 RID: 8600
		private float weight;

		// Token: 0x04002199 RID: 8601
		private bool firstFBBIKSolve;
	}
}
