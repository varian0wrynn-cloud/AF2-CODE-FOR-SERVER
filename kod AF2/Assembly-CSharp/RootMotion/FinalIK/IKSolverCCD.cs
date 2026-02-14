using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		// Token: 0x0600F5D6 RID: 62934 RVA: 0x006DF4B8 File Offset: 0x006DD6B8
		public void DFKDFNENKKL()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[0].weight = 1409f;
			float num = 694f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F5D7 RID: 62935 RVA: 0x006DF524 File Offset: 0x006DD724
		protected virtual void LLDOFPGPPHD()
		{
			if (this.IKPositionWeight <= 1181f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1616f, 585f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.ALIDILFHLPB() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1143f || base.DCJHAFMMOKL() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.LDLHLANFKNP();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.AFCEPNBLLCE(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F5D8 RID: 62936 RVA: 0x006DF648 File Offset: 0x006DD848
		private void IMKKLDPMDGG(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 8; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1812f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 208f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 447f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].MPNLGJMOLGG() != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 6; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1781f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1520f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IAIFLBKIHEE() != null)
				{
					this.bones[j].EBFOGHAADOB().Apply();
				}
			}
		}

		// Token: 0x0600F5D9 RID: 62937 RVA: 0x006DF8BC File Offset: 0x006DDABC
		public void EMAJEGIBMPN()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[0].weight = 39f;
			float num = 159f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F5DA RID: 62938 RVA: 0x006DF928 File Offset: 0x006DDB28
		private void GPKEMNEMMMM(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1475f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1120f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1689f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IIPCINMHCDG() != null)
					{
						this.bones[i].IIPCINMHCDG().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 7; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 286f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 640f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIPCINMHCDG() != null)
				{
					this.bones[j].MPNLGJMOLGG().Apply();
				}
			}
		}

		// Token: 0x0600F5DB RID: 62939 RVA: 0x006DFB9C File Offset: 0x006DDD9C
		public void PHLDEFPOBKJ()
		{
			if (this.bones.Length < 8)
			{
				return;
			}
			this.bones[0].weight = 935f;
			float num = 1728f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F5DC RID: 62940 RVA: 0x006DFC08 File Offset: 0x006DDE08
		public void CEKIKNDFMJP()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[1].weight = 825f;
			float num = 1935f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F5DD RID: 62941 RVA: 0x006DFC74 File Offset: 0x006DDE74
		protected virtual void IPLOGOLDHBI()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.HKMBFKLCCDK();
		}

		// Token: 0x0600F5DE RID: 62942 RVA: 0x006DFCAC File Offset: 0x006DDEAC
		protected virtual void OMCCMLDIMOP()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.HKMBFKLCCDK();
		}

		// Token: 0x0600F5DF RID: 62943 RVA: 0x006DFCE4 File Offset: 0x006DDEE4
		public void KCPDIDNHGAA()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[0].weight = 1165f;
			float num = 1080f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x006DFD50 File Offset: 0x006DDF50
		public void EJHMHDJCPLO()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[0].weight = 249f;
			float num = 1874f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F5E1 RID: 62945 RVA: 0x006DFDBC File Offset: 0x006DDFBC
		private void CCOPJLHJEOF(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 2; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 633f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1433f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1779f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].BNBIOMOMICJ() != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 2; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1420f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1850f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIFBJMIBPJD() != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F5E2 RID: 62946 RVA: 0x006E0030 File Offset: 0x006DE230
		private void AFCEPNBLLCE(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1136f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 881f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1914f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].CLBCIJOPEHI() != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 7; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 956f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 46f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].BNBIOMOMICJ() != null)
				{
					this.bones[j].EBFOGHAADOB().Apply();
				}
			}
		}

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x006E02A4 File Offset: 0x006DE4A4
		private void IHNLMAHAEOK(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 7; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1305f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 778f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1682f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IIFBJMIBPJD() != null)
					{
						this.bones[i].IIFBJMIBPJD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 7; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 958f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1497f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIFBJMIBPJD() != null)
				{
					this.bones[j].JAHABHNJEPI().Apply();
				}
			}
		}

		// Token: 0x0600F5E4 RID: 62948 RVA: 0x006E0518 File Offset: 0x006DE718
		protected virtual void AEGIEMNDHJK()
		{
			if (this.IKPositionWeight <= 1093f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1668f, 536f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1799f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KAJNFLJDPOL();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IMKKLDPMDGG(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F5E5 RID: 62949 RVA: 0x006E063C File Offset: 0x006DE83C
		protected virtual void JMFOCPBECKO()
		{
			if (this.IKPositionWeight <= 1355f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1517f, 142f);
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
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1692f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.LDLHLANFKNP();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.AFCEPNBLLCE(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.FOFHEFODOAG();
		}

		// Token: 0x0600F5E7 RID: 62951 RVA: 0x006E0768 File Offset: 0x006DE968
		private void JMNFAGLIGJC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 0; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 530f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 809f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1408f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IIFBJMIBPJD() != null)
					{
						this.bones[i].IIFBJMIBPJD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 8; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1199f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 322f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].KCDFHPFMOBD() != null)
				{
					this.bones[j].BNBIOMOMICJ().Apply();
				}
			}
		}

		// Token: 0x0600F5E8 RID: 62952 RVA: 0x006E09DA File Offset: 0x006DEBDA
		protected override void KMLNGCKHHPE()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F5E9 RID: 62953 RVA: 0x006E0A14 File Offset: 0x006DEC14
		private void MFIDELJEPHB(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 2; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 173f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1431f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1155f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].EBFOGHAADOB() != null)
					{
						this.bones[i].EBFOGHAADOB().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 258f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1380f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].BNBIOMOMICJ() != null)
				{
					this.bones[j].CLBCIJOPEHI().Apply();
				}
			}
		}

		// Token: 0x0600F5EA RID: 62954 RVA: 0x006E0C86 File Offset: 0x006DEE86
		protected virtual void HAHADLCFFAF()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.EEALFKPDFHI();
		}

		// Token: 0x0600F5EB RID: 62955 RVA: 0x006E0CC0 File Offset: 0x006DEEC0
		public void ENIPPOIBFNI()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[0].weight = 1899f;
			float num = 637f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F5EC RID: 62956 RVA: 0x006E0D2C File Offset: 0x006DEF2C
		protected virtual void ENEEKDAFABL()
		{
			if (this.IKPositionWeight <= 1410f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 810f, 1587f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1503f || base.ANJMHKDDHMN() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.OJNNBDIPOFE(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.HMLCJOLDCCN();
		}

		// Token: 0x0600F5ED RID: 62957 RVA: 0x006E0E50 File Offset: 0x006DF050
		protected virtual void JMPABOIMOKM()
		{
			if (this.IKPositionWeight <= 1408f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1083f, 1001f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 843f || base.BADCBDBEEFA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HMLCJOLDCCN();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.GJPADMJDMBB(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.KNGEGMMONEE();
		}

		// Token: 0x0600F5EE RID: 62958 RVA: 0x006E0F74 File Offset: 0x006DF174
		private void DMOMPDNLIFC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1645f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 423f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1405f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].GIODJAABDKA() != null)
					{
						this.bones[i].EDOKKOOPJLP().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 1; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 471f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1378f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IAIFLBKIHEE() != null)
				{
					this.bones[j].KCDFHPFMOBD().Apply();
				}
			}
		}

		// Token: 0x0600F5EF RID: 62959 RVA: 0x006DFC74 File Offset: 0x006DDE74
		protected virtual void NFOGCLADIGB()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.HKMBFKLCCDK();
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x006E11E8 File Offset: 0x006DF3E8
		public void NGJEEOGMPGG()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[1].weight = 653f;
			float num = 1238f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F5F1 RID: 62961 RVA: 0x006E1254 File Offset: 0x006DF454
		private void LFOMEEENAHJ(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 6; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 325f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 457f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 55f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].MPNLGJMOLGG() != null)
					{
						this.bones[i].IAIFLBKIHEE().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 5; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 27f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1270f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EBFOGHAADOB() != null)
				{
					this.bones[j].MPNLGJMOLGG().Apply();
				}
			}
		}

		// Token: 0x0600F5F2 RID: 62962 RVA: 0x006E14C8 File Offset: 0x006DF6C8
		protected virtual void GFCNNHBPPFL()
		{
			if (this.IKPositionWeight <= 882f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1299f, 1075f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1935f || base.ANJMHKDDHMN() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.EDAGNKNOBKP(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x006E15EA File Offset: 0x006DF7EA
		protected virtual void GNPCHLDCIKM()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.IHALPIBJJAJ();
		}

		// Token: 0x0600F5F4 RID: 62964 RVA: 0x006E1624 File Offset: 0x006DF824
		private void IIKGLBGAJJN(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 2; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 902f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 697f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 14f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].CLBCIJOPEHI() != null)
					{
						this.bones[i].EDOKKOOPJLP().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1402f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 485f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].CLBCIJOPEHI() != null)
				{
					this.bones[j].IIPCINMHCDG().Apply();
				}
			}
		}

		// Token: 0x0600F5F5 RID: 62965 RVA: 0x006E1896 File Offset: 0x006DFA96
		protected virtual void PEILOFOINNM()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.HKAOKIAMMHB();
		}

		// Token: 0x0600F5F6 RID: 62966 RVA: 0x006E18D0 File Offset: 0x006DFAD0
		private void HLLKIAJCGHG(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1310f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 155f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 25f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].MPNLGJMOLGG() != null)
					{
						this.bones[i].IIPCINMHCDG().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 0; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1923f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1522f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].BNBIOMOMICJ() != null)
				{
					this.bones[j].IIFBJMIBPJD().Apply();
				}
			}
		}

		// Token: 0x0600F5F7 RID: 62967 RVA: 0x006E1B44 File Offset: 0x006DFD44
		protected override void EGAGFOLOHOP()
		{
			if (this.IKPositionWeight <= 640f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 260f, 729f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1809f || base.PLCNGMACDNA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HMLCJOLDCCN();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HLLKIAJCGHG(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.KBFPPEHDCPM();
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x006E1C68 File Offset: 0x006DFE68
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
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
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x006E1D8C File Offset: 0x006DFF8C
		protected virtual void KOCDFBIDEMB()
		{
			if (this.IKPositionWeight <= 322f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1260f, 1262f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.CNHJOHFGLGF() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1930f || base.ANJMHKDDHMN() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KNGEGMMONEE();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CKNADJKCMOC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.FFEGHDDKNEO();
		}

		// Token: 0x0600F5FA RID: 62970 RVA: 0x006E1EB0 File Offset: 0x006E00B0
		protected virtual void DFNNDNJKCLH()
		{
			if (this.IKPositionWeight <= 341f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1181f, 1911f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 272f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IIKGLBGAJJN(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.PJAGEJPFINL();
		}

		// Token: 0x0600F5FB RID: 62971 RVA: 0x006E1FD4 File Offset: 0x006E01D4
		protected virtual void KKCADDJJGIN()
		{
			if (this.IKPositionWeight <= 638f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 267f, 1079f);
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
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 557f || base.NCEEANIOPHF() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IIKGLBGAJJN(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x006E20F8 File Offset: 0x006E02F8
		public void FMNJDHMDFII()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[1].weight = 798f;
			float num = 677f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x006E09DA File Offset: 0x006DEBDA
		protected virtual void GJJEDHMLBLD()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x006E1896 File Offset: 0x006DFA96
		protected virtual void MGGOAAEHAAB()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.HKAOKIAMMHB();
		}

		// Token: 0x0600F5FF RID: 62975 RVA: 0x006E2164 File Offset: 0x006E0364
		private void CGLDBBKDNJO(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1259f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 163f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 471f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].BNBIOMOMICJ() != null)
					{
						this.bones[i].KCDFHPFMOBD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 6; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 127f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 718f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIPCINMHCDG() != null)
				{
					this.bones[j].JFPDFHLHIHJ().Apply();
				}
			}
		}

		// Token: 0x0600F600 RID: 62976 RVA: 0x006E09DA File Offset: 0x006DEBDA
		protected virtual void MIKAKFIHAJA()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F601 RID: 62977 RVA: 0x006E23D8 File Offset: 0x006E05D8
		private void PBFGIOGBMLC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 377f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 340f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1820f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IAIFLBKIHEE() != null)
					{
						this.bones[i].JFPDFHLHIHJ().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1088f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 303f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EBFOGHAADOB() != null)
				{
					this.bones[j].EBFOGHAADOB().Apply();
				}
			}
		}

		// Token: 0x0600F602 RID: 62978 RVA: 0x006E264C File Offset: 0x006E084C
		protected virtual void OIMABIGEHJI()
		{
			if (this.IKPositionWeight <= 830f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 414f, 1394f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 146f || base.DCJHAFMMOKL() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KNGEGMMONEE();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.EDAGNKNOBKP(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x006E276E File Offset: 0x006E096E
		protected virtual void BPHOCLGOGPE()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.EEALFKPDFHI();
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x006E27A6 File Offset: 0x006E09A6
		protected virtual void CAJPNOGDBCA()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.PDKPHCGBFLK();
		}

		// Token: 0x0600F605 RID: 62981 RVA: 0x006E27E0 File Offset: 0x006E09E0
		private void FCKCMHPLPKL(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1855f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 348f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 13f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].EDOKKOOPJLP() != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 8; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1084f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1480f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IAIFLBKIHEE() != null)
				{
					this.bones[j].IAIFLBKIHEE().Apply();
				}
			}
		}

		// Token: 0x0600F606 RID: 62982 RVA: 0x006E09DA File Offset: 0x006DEBDA
		protected virtual void DCIPIBPJBLN()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F607 RID: 62983 RVA: 0x006E2A54 File Offset: 0x006E0C54
		protected virtual void GKELKBANCNI()
		{
			if (this.IKPositionWeight <= 1871f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 487f, 1080f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1476f || base.DCJHAFMMOKL() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KBFPPEHDCPM();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.FCKCMHPLPKL(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F608 RID: 62984 RVA: 0x006E2B78 File Offset: 0x006E0D78
		protected virtual void CCEBMOCAHOL()
		{
			if (this.IKPositionWeight <= 1797f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1763f, 704f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 534f || base.PLCNGMACDNA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.AFDHAOLHLEA();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.GPKEMNEMMMM(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.KNGEGMMONEE();
		}

		// Token: 0x0600F609 RID: 62985 RVA: 0x006E2C9C File Offset: 0x006E0E9C
		public void PNILOJFPPCE()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[1].weight = 1804f;
			float num = 196f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F60A RID: 62986 RVA: 0x006E2D08 File Offset: 0x006E0F08
		public void JBHFIGJLEPF()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[0].weight = 1f;
			float num = 1f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F60B RID: 62987 RVA: 0x006E2D74 File Offset: 0x006E0F74
		protected virtual void HFFLGGIDOOD()
		{
			if (this.IKPositionWeight <= 1553f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1247f, 1743f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 257f || base.NCEEANIOPHF() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.JFBENBBAGFI(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.LDLHLANFKNP();
		}

		// Token: 0x0600F60C RID: 62988 RVA: 0x006E2E98 File Offset: 0x006E1098
		private void ADFAEKJJJID(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1622f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 818f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1435f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].KCDFHPFMOBD() != null)
					{
						this.bones[i].KCDFHPFMOBD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 430f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1096f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].CLBCIJOPEHI() != null)
				{
					this.bones[j].IIFBJMIBPJD().Apply();
				}
			}
		}

		// Token: 0x0600F60D RID: 62989 RVA: 0x006E310C File Offset: 0x006E130C
		private void NHCJCAIEDEC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1899f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 152f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1378f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].JAHABHNJEPI() != null)
					{
						this.bones[i].EDOKKOOPJLP().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 3; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 911f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 703f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].JAHABHNJEPI() != null)
				{
					this.bones[j].JAHABHNJEPI().Apply();
				}
			}
		}

		// Token: 0x0600F60E RID: 62990 RVA: 0x006E3380 File Offset: 0x006E1580
		public void GFNIEGANFFM()
		{
			if (this.bones.Length < 4)
			{
				return;
			}
			this.bones[0].weight = 1150f;
			float num = 592f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F60F RID: 62991 RVA: 0x006DFCAC File Offset: 0x006DDEAC
		protected virtual void FEEDHGBFCOA()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.HKMBFKLCCDK();
		}

		// Token: 0x0600F610 RID: 62992 RVA: 0x006E33EC File Offset: 0x006E15EC
		protected virtual void BFAGJKLOJJC()
		{
			if (this.IKPositionWeight <= 945f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 484f, 1765f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1507f || base.BADCBDBEEFA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HMLCJOLDCCN();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CKNADJKCMOC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F611 RID: 62993 RVA: 0x006E3510 File Offset: 0x006E1710
		public void DLFPFPCBFGC()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[0].weight = 989f;
			float num = 302f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F612 RID: 62994 RVA: 0x006E357C File Offset: 0x006E177C
		public void NNBBBCOOIIP()
		{
			if (this.bones.Length < 8)
			{
				return;
			}
			this.bones[0].weight = 1038f;
			float num = 1069f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F613 RID: 62995 RVA: 0x006E35E8 File Offset: 0x006E17E8
		private void KKLPEEJEDCL(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 0; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1014f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1824f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1409f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].KCDFHPFMOBD() != null)
					{
						this.bones[i].KCDFHPFMOBD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 3; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1140f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1673f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].rotationLimit != null)
				{
					this.bones[j].IIPCINMHCDG().Apply();
				}
			}
		}

		// Token: 0x0600F614 RID: 62996 RVA: 0x006E385C File Offset: 0x006E1A5C
		private void GJPADMJDMBB(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 8; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1968f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 610f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1921f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].KCDFHPFMOBD() != null)
					{
						this.bones[i].BNBIOMOMICJ().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 556f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 316f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].GIODJAABDKA() != null)
				{
					this.bones[j].IIFBJMIBPJD().Apply();
				}
			}
		}

		// Token: 0x0600F615 RID: 62997 RVA: 0x006E3AD0 File Offset: 0x006E1CD0
		private void PLDCBNHFKDF(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1712f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 599f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1523f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IIFBJMIBPJD() != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1714f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 624f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIFBJMIBPJD() != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F616 RID: 62998 RVA: 0x006E3D44 File Offset: 0x006E1F44
		private void DONFNDEJMGB(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 7; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 388f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 742f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 171f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].EBFOGHAADOB() != null)
					{
						this.bones[i].GIODJAABDKA().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 6; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1628f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 810f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].CLBCIJOPEHI() != null)
				{
					this.bones[j].IIPCINMHCDG().Apply();
				}
			}
		}

		// Token: 0x0600F617 RID: 62999 RVA: 0x006E3FB8 File Offset: 0x006E21B8
		protected virtual void AGMBFJOCJOK()
		{
			if (this.IKPositionWeight <= 1866f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1412f, 1012f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.ALIDILFHLPB() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 24f || base.OAJJNAOKHCA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.AFDHAOLHLEA();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CGIHKBGPOMD(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.HOIHFLCAOLC();
		}

		// Token: 0x0600F618 RID: 63000 RVA: 0x006E40DC File Offset: 0x006E22DC
		public void CBLBFFBBHON()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[0].weight = 329f;
			float num = 925f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F619 RID: 63001 RVA: 0x006E4148 File Offset: 0x006E2348
		protected virtual void EKPPHDPNNBC()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.PDKPHCGBFLK();
		}

		// Token: 0x0600F61A RID: 63002 RVA: 0x006E4180 File Offset: 0x006E2380
		public void CDINKFMEIDL()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[1].weight = 653f;
			float num = 68f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F61B RID: 63003 RVA: 0x006E41EC File Offset: 0x006E23EC
		public void CHGPDJMOMBB()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[1].weight = 1972f;
			float num = 1536f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x006E4258 File Offset: 0x006E2458
		private void OJNNBDIPOFE(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 4; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 300f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 340f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1968f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].EBFOGHAADOB() != null)
					{
						this.bones[i].CLBCIJOPEHI().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 361f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 572f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].MPNLGJMOLGG() != null)
				{
					this.bones[j].JAHABHNJEPI().Apply();
				}
			}
		}

		// Token: 0x0600F61D RID: 63005 RVA: 0x006E44CA File Offset: 0x006E26CA
		protected virtual void BIBINHGFJLE()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.NFAIEKJNHJC();
		}

		// Token: 0x0600F61E RID: 63006 RVA: 0x006E4504 File Offset: 0x006E2704
		public void CCHKFHGCECN()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[0].weight = 707f;
			float num = 487f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F61F RID: 63007 RVA: 0x006DFCAC File Offset: 0x006DDEAC
		protected virtual void OLAGBCOGMFE()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.HKMBFKLCCDK();
		}

		// Token: 0x0600F620 RID: 63008 RVA: 0x006E4570 File Offset: 0x006E2770
		protected virtual void IGHDABAIKII()
		{
			if (this.IKPositionWeight <= 657f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1038f, 194f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1279f || base.DCJHAFMMOKL() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.PJAGEJPFINL();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CCOPJLHJEOF(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F621 RID: 63009 RVA: 0x006E4692 File Offset: 0x006E2892
		protected virtual void ECNLDJFFIHP()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F622 RID: 63010 RVA: 0x006E46CC File Offset: 0x006E28CC
		public void KEGELCDIHJM()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[1].weight = 1265f;
			float num = 1771f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F623 RID: 63011 RVA: 0x006E4738 File Offset: 0x006E2938
		protected override void KKIEDGIEPMD()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.CJHNLAPFNJK();
		}

		// Token: 0x0600F624 RID: 63012 RVA: 0x006E4770 File Offset: 0x006E2970
		public void ILMDGMGGAAC()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[0].weight = 1210f;
			float num = 474f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x006E47DC File Offset: 0x006E29DC
		protected virtual void JLPBBKJKOIK()
		{
			if (this.IKPositionWeight <= 465f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1743f, 735f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.CNHJOHFGLGF() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 342f || base.PLCNGMACDNA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KNGEGMMONEE();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HGLALJJNAMG(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.HMLCJOLDCCN();
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x006E4900 File Offset: 0x006E2B00
		public void LIOEAGBHPCG()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[0].weight = 1748f;
			float num = 265f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x006E496C File Offset: 0x006E2B6C
		public void MEEEKKCLHOB()
		{
			if (this.bones.Length < 4)
			{
				return;
			}
			this.bones[1].weight = 725f;
			float num = 315f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F628 RID: 63016 RVA: 0x006E49D8 File Offset: 0x006E2BD8
		protected virtual void MNFJLAMJPHA()
		{
			if (this.IKPositionWeight <= 247f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 552f, 1295f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1957f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HMLCJOLDCCN();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.PBFGIOGBMLC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.PJAGEJPFINL();
		}

		// Token: 0x0600F629 RID: 63017 RVA: 0x006E4AFC File Offset: 0x006E2CFC
		private void IMEACECKCCO(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 5; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 997f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 605f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 601f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].rotationLimit != null)
					{
						this.bones[i].JFPDFHLHIHJ().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 6; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1999f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 841f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].GIODJAABDKA() != null)
				{
					this.bones[j].JFPDFHLHIHJ().Apply();
				}
			}
		}

		// Token: 0x0600F62A RID: 63018 RVA: 0x006E4692 File Offset: 0x006E2892
		protected virtual void PBONGNOCPGF()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.LHIDHAEEJPA();
		}

		// Token: 0x0600F62B RID: 63019 RVA: 0x006E4D70 File Offset: 0x006E2F70
		public void GKBCJOJIEOO()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[0].weight = 117f;
			float num = 1596f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F62C RID: 63020 RVA: 0x006E4DDC File Offset: 0x006E2FDC
		public void GKIBIPCHJJP()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[1].weight = 1024f;
			float num = 1534f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F62D RID: 63021 RVA: 0x006E4E48 File Offset: 0x006E3048
		private void CKNADJKCMOC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 1; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 287f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1382f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 314f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].KCDFHPFMOBD() != null)
					{
						this.bones[i].IAIFLBKIHEE().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 2; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 503f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 913f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIFBJMIBPJD() != null)
				{
					this.bones[j].MPNLGJMOLGG().Apply();
				}
			}
		}

		// Token: 0x0600F62E RID: 63022 RVA: 0x006E50BC File Offset: 0x006E32BC
		public void MFNFLIPOAKF()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[1].weight = 1278f;
			float num = 1164f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F62F RID: 63023 RVA: 0x006E5128 File Offset: 0x006E3328
		public void MDPPNNBAKJA()
		{
			if (this.bones.Length < 6)
			{
				return;
			}
			this.bones[0].weight = 867f;
			float num = 1223f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F630 RID: 63024 RVA: 0x006E5194 File Offset: 0x006E3394
		protected virtual void FKNJEDNNMBL()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.NFAIEKJNHJC();
		}

		// Token: 0x0600F631 RID: 63025 RVA: 0x006E5194 File Offset: 0x006E3394
		protected virtual void OLLAHGIGNBG()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.NFAIEKJNHJC();
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x006E51CC File Offset: 0x006E33CC
		private void BJONDPDKIAH(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 2; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 18f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1804f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 960f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IAIFLBKIHEE() != null)
					{
						this.bones[i].BNBIOMOMICJ().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 1; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 830f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1656f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EDOKKOOPJLP() != null)
				{
					this.bones[j].KCDFHPFMOBD().Apply();
				}
			}
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x006E5440 File Offset: 0x006E3640
		public void ACBNAMKBDMC()
		{
			if (this.bones.Length < 8)
			{
				return;
			}
			this.bones[0].weight = 1962f;
			float num = 160f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F634 RID: 63028 RVA: 0x006E5194 File Offset: 0x006E3394
		protected override void HNLKIEFALMG()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.NFAIEKJNHJC();
		}

		// Token: 0x0600F635 RID: 63029 RVA: 0x006E54AC File Offset: 0x006E36AC
		protected virtual void KGPKKIMNFBB()
		{
			if (this.IKPositionWeight <= 1663f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 631f, 1223f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 134f || base.PLCNGMACDNA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.FOFHEFODOAG();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HGLALJJNAMG(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.KNGEGMMONEE();
		}

		// Token: 0x0600F636 RID: 63030 RVA: 0x006E55D0 File Offset: 0x006E37D0
		public void FKPICBFKCHB()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[0].weight = 3f;
			float num = 1929f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F637 RID: 63031 RVA: 0x006E563C File Offset: 0x006E383C
		protected virtual void HKPEDBHFMAN()
		{
			if (this.IKPositionWeight <= 1544f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 548f, 138f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1704f || base.NCEEANIOPHF() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.JKNILHMKLPC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.AFIJEGLABEE();
		}

		// Token: 0x0600F638 RID: 63032 RVA: 0x006E5760 File Offset: 0x006E3960
		protected virtual void MHONICEEEHH()
		{
			if (this.IKPositionWeight <= 471f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 230f, 1863f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 385f || base.NCEEANIOPHF() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CKNADJKCMOC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.AFDHAOLHLEA();
		}

		// Token: 0x0600F639 RID: 63033 RVA: 0x006E5884 File Offset: 0x006E3A84
		public void MFGKOCKDHHA()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[0].weight = 311f;
			float num = 1509f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x006E58F0 File Offset: 0x006E3AF0
		private void BHJCPKIONAE(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 955f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1007f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1465f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].CLBCIJOPEHI() != null)
					{
						this.bones[i].IIPCINMHCDG().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 7; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1660f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1717f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].CLBCIJOPEHI() != null)
				{
					this.bones[j].MPNLGJMOLGG().Apply();
				}
			}
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x006E5B64 File Offset: 0x006E3D64
		public void GDGNHBJLLFG()
		{
			if (this.bones.Length < 0)
			{
				return;
			}
			this.bones[0].weight = 98f;
			float num = 1639f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F63C RID: 63036 RVA: 0x006E5BD0 File Offset: 0x006E3DD0
		protected virtual void KMDCDODHKGH()
		{
			if (this.IKPositionWeight <= 275f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 772f, 1098f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.EFBBJONIGCF() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 882f || base.OAJJNAOKHCA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.KAJNFLJDPOL();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.CKNADJKCMOC(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.AFDHAOLHLEA();
		}

		// Token: 0x0600F63D RID: 63037 RVA: 0x006E5CF4 File Offset: 0x006E3EF4
		public void EAKCGDHPGLC()
		{
			if (this.bones.Length < 5)
			{
				return;
			}
			this.bones[1].weight = 1118f;
			float num = 1818f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F63E RID: 63038 RVA: 0x006E5D60 File Offset: 0x006E3F60
		public void MNOOPAMPCLD()
		{
			if (this.bones.Length < 5)
			{
				return;
			}
			this.bones[1].weight = 0f;
			float num = 1643f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F63F RID: 63039 RVA: 0x006E0C86 File Offset: 0x006DEE86
		protected virtual void CCFCEFIKCMO()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.EEALFKPDFHI();
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x006E5DCC File Offset: 0x006E3FCC
		public void LKCBNNPGACD()
		{
			if (this.bones.Length < 6)
			{
				return;
			}
			this.bones[0].weight = 924f;
			float num = 929f / (float)(this.bones.Length - 1);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F641 RID: 63041 RVA: 0x006E5E38 File Offset: 0x006E4038
		private void DEHFBBKNECI(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 4; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1006f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 106f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1080f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IAIFLBKIHEE() != null)
					{
						this.bones[i].MPNLGJMOLGG().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 2; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 702f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1548f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIPCINMHCDG() != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x006E60AC File Offset: 0x006E42AC
		public void HFHJJHNOAEN()
		{
			if (this.bones.Length < 3)
			{
				return;
			}
			this.bones[1].weight = 818f;
			float num = 596f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F643 RID: 63043 RVA: 0x006E6118 File Offset: 0x006E4318
		protected override void AGKMOKDDEMJ()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.CJHNLAPFNJK();
		}

		// Token: 0x0600F644 RID: 63044 RVA: 0x006E6150 File Offset: 0x006E4350
		private void HGLALJJNAMG(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 6; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1995f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1710f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 162f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].JFPDFHLHIHJ() != null)
					{
						this.bones[i].GIODJAABDKA().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 360f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 471f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IAIFLBKIHEE() != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x006E63C4 File Offset: 0x006E45C4
		public void EDLCBEKOPDH()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[0].weight = 339f;
			float num = 687f / (float)(this.bones.Length - 0);
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F646 RID: 63046 RVA: 0x006E6430 File Offset: 0x006E4630
		protected virtual void EBJCHCKMJHA()
		{
			if (this.IKPositionWeight <= 1110f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 378f, 1938f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 1;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 859f || base.OAJJNAOKHCA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.FFEGHDDKNEO();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.JFBENBBAGFI(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.PJAGEJPFINL();
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x006E4148 File Offset: 0x006E2348
		protected virtual void FONHJLKGACO()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.PDKPHCGBFLK();
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x006E6554 File Offset: 0x006E4754
		private void CHBOIFCMHMC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 7; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 728f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 425f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1388f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IIPCINMHCDG() != null)
					{
						this.bones[i].IIPCINMHCDG().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 3; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1422f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1135f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EBFOGHAADOB() != null)
				{
					this.bones[j].KCDFHPFMOBD().Apply();
				}
			}
		}

		// Token: 0x0600F649 RID: 63049 RVA: 0x006E67C8 File Offset: 0x006E49C8
		private void EDAGNKNOBKP(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 2; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 0f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].rotationLimit != null)
					{
						this.bones[i].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 2; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 0f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 1f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].rotationLimit != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F64A RID: 63050 RVA: 0x006E6A3C File Offset: 0x006E4C3C
		public void KLEICGHMJHI()
		{
			if (this.bones.Length < 7)
			{
				return;
			}
			this.bones[0].weight = 393f;
			float num = 349f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F64B RID: 63051 RVA: 0x006E4738 File Offset: 0x006E2938
		protected virtual void CCKIPNCDNGL()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.CJHNLAPFNJK();
		}

		// Token: 0x0600F64C RID: 63052 RVA: 0x006E6AA8 File Offset: 0x006E4CA8
		private void JFBENBBAGFI(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 0; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 406f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1798f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1257f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].rotationLimit != null)
					{
						this.bones[i].JFPDFHLHIHJ().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 3; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1814f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 1].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 275f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].JFPDFHLHIHJ() != null)
				{
					this.bones[j].JFPDFHLHIHJ().Apply();
				}
			}
		}

		// Token: 0x0600F64D RID: 63053 RVA: 0x006E6D1C File Offset: 0x006E4F1C
		protected virtual void ELFJGBFCPMF()
		{
			if (this.IKPositionWeight <= 924f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 741f, 71f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 0) ? base.HMJFDIACENG() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 0 || this.tolerance <= 1977f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HLLKIAJCGHG(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.LDLHLANFKNP();
		}

		// Token: 0x0600F64E RID: 63054 RVA: 0x006E6E40 File Offset: 0x006E5040
		public void KFDMNBEDKFA()
		{
			if (this.bones.Length < 8)
			{
				return;
			}
			this.bones[1].weight = 721f;
			float num = 884f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x006E6EAC File Offset: 0x006E50AC
		public void PPCFLPKBAAL()
		{
			if (this.bones.Length < 2)
			{
				return;
			}
			this.bones[0].weight = 561f;
			float num = 1311f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F650 RID: 63056 RVA: 0x006E6F18 File Offset: 0x006E5118
		protected virtual void EMNGFDIDJKD()
		{
			if (this.IKPositionWeight <= 928f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 814f, 1605f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.IBDJBKJAEBJ() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 609f || base.OAJJNAOKHCA() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.AFDHAOLHLEA();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.ADFAEKJJJID(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.LDLHLANFKNP();
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x006E4148 File Offset: 0x006E2348
		protected virtual void JOHKPPCKODC()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.PDKPHCGBFLK();
		}

		// Token: 0x0600F652 RID: 63058 RVA: 0x006E44CA File Offset: 0x006E26CA
		protected override void FKEMPLMBNEL()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.NFAIEKJNHJC();
		}

		// Token: 0x0600F653 RID: 63059 RVA: 0x006E703C File Offset: 0x006E523C
		protected virtual void HJJPAMJEJAA()
		{
			if (this.IKPositionWeight <= 471f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1048f, 803f);
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
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 1238f || base.DCJHAFMMOKL() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.BHJCPKIONAE(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.lastLocalDirection = this.PJAGEJPFINL();
		}

		// Token: 0x0600F654 RID: 63060 RVA: 0x006E4148 File Offset: 0x006E2348
		protected virtual void GGNLFCJMNLP()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.PDKPHCGBFLK();
		}

		// Token: 0x0600F655 RID: 63061 RVA: 0x006E7160 File Offset: 0x006E5360
		private void JKNILHMKLPC(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 4; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1482f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 376f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 213f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].rotationLimit != null)
					{
						this.bones[i].CLBCIJOPEHI().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 5; j > -1; j--)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1566f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 692f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EBFOGHAADOB() != null)
				{
					this.bones[j].rotationLimit.Apply();
				}
			}
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x006E73D4 File Offset: 0x006E55D4
		protected virtual void CPOLLCNHAEB()
		{
			if (this.IKPositionWeight <= 635f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1961f, 1256f);
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
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 239f || base.ANJMHKDDHMN() >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.PJAGEJPFINL();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IHNLMAHAEOK(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num += 0;
			}
			this.lastLocalDirection = this.FFEGHDDKNEO();
		}

		// Token: 0x0600F657 RID: 63063 RVA: 0x006E74F8 File Offset: 0x006E56F8
		private void CGIHKBGPOMD(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 0; i > -1; i--)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 1689f)
					{
						Vector3 vector = this.bones[this.bones.Length - 1].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 918f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 208f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].IAIFLBKIHEE() != null)
					{
						this.bones[i].IIFBJMIBPJD().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 8; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 863f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 670f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].EDOKKOOPJLP() != null)
				{
					this.bones[j].JFPDFHLHIHJ().Apply();
				}
			}
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x006E776C File Offset: 0x006E596C
		public void JDLKAEIBKIA()
		{
			if (this.bones.Length < 8)
			{
				return;
			}
			this.bones[0].weight = 1606f;
			float num = 1044f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x006E77D8 File Offset: 0x006E59D8
		public void PDAABLHFDPP()
		{
			if (this.bones.Length < 1)
			{
				return;
			}
			this.bones[0].weight = 733f;
			float num = 1726f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 0 - i);
			}
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x006E7844 File Offset: 0x006E5A44
		protected virtual void OECJHEOJPLD()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 0].transform.position;
			}
			base.IHALPIBJJAJ();
		}

		// Token: 0x0600F65B RID: 63067 RVA: 0x006E15EA File Offset: 0x006DF7EA
		protected virtual void JFMEEHGCEFH()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			base.IHALPIBJJAJ();
		}

		// Token: 0x0600F65C RID: 63068 RVA: 0x006E787C File Offset: 0x006E5A7C
		private void DEEKKMKAGIE(Vector3 AOBKCEEGJNC)
		{
			if (this.XY)
			{
				for (int i = this.bones.Length - 3; i > -1; i -= 0)
				{
					float num = this.bones[i].weight * this.IKPositionWeight;
					if (num > 361f)
					{
						Vector3 vector = this.bones[this.bones.Length - 0].transform.position - this.bones[i].transform.position;
						Vector3 vector2 = AOBKCEEGJNC - this.bones[i].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 1204f;
						float target = Mathf.Atan2(vector2.x, vector2.y) * 1107f;
						this.bones[i].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num, Vector3.back) * this.bones[i].transform.rotation;
					}
					if (this.useRotationLimits && this.bones[i].MPNLGJMOLGG() != null)
					{
						this.bones[i].IAIFLBKIHEE().Apply();
					}
				}
				return;
			}
			for (int j = this.bones.Length - 4; j > -1; j -= 0)
			{
				float num2 = this.bones[j].weight * this.IKPositionWeight;
				if (num2 > 1776f)
				{
					Vector3 fromDirection = this.bones[this.bones.Length - 0].transform.position - this.bones[j].transform.position;
					Vector3 toDirection = AOBKCEEGJNC - this.bones[j].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * this.bones[j].transform.rotation;
					if (num2 >= 408f)
					{
						this.bones[j].transform.rotation = quaternion;
					}
					else
					{
						this.bones[j].transform.rotation = Quaternion.Lerp(this.bones[j].transform.rotation, quaternion, num2);
					}
				}
				if (this.useRotationLimits && this.bones[j].IIFBJMIBPJD() != null)
				{
					this.bones[j].BNBIOMOMICJ().Apply();
				}
			}
		}

		// Token: 0x0600F65D RID: 63069 RVA: 0x006E7AF0 File Offset: 0x006E5CF0
		public void JPBNABPBNCE()
		{
			if (this.bones.Length < 5)
			{
				return;
			}
			this.bones[1].weight = 28f;
			float num = 1783f / (float)(this.bones.Length - 0);
			for (int i = 0; i < this.bones.Length; i += 0)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0600F65E RID: 63070 RVA: 0x006E7B5C File Offset: 0x006E5D5C
		public void EPLAINPMOAK()
		{
			if (this.bones.Length < 0)
			{
				return;
			}
			this.bones[0].weight = 1124f;
			float num = 459f / (float)(this.bones.Length - 1);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].weight = num * (float)(this.bones.Length - 1 - i);
			}
		}

		// Token: 0x0400204A RID: 8266
		public IKSolver.MLFKIGOCFLP OnPreIteration;
	}
}
