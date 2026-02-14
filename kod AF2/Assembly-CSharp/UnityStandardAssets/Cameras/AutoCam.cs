using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003AB RID: 939
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		// Token: 0x0600CB14 RID: 51988 RVA: 0x005ACBAC File Offset: 0x005AADAC
		protected virtual void FPBEOANGPAD(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 252f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1737f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1899f;
				if (this.m_SpinTurnLimit > 293f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 16f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 46f : 726f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 78f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1998f;
				if (vector.sqrMagnitude < 253f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 803f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x005ACDD0 File Offset: 0x005AAFD0
		protected virtual void APDONJBOLOG(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 157f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 511f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1519f;
				if (this.m_SpinTurnLimit > 52f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1394f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 249f : 470f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1615f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 217f;
				if (vector.sqrMagnitude < 809f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1787f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x005ACFF4 File Offset: 0x005AB1F4
		protected virtual void LHGGPIEFKBM(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 82f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 428f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1345f;
				if (this.m_SpinTurnLimit > 1204f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 106f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1627f : 277f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 128f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1326f;
				if (vector.sqrMagnitude < 1299f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 948f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x005AD218 File Offset: 0x005AB418
		protected virtual void OINKPAKPKJH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1659f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1881f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 321f;
				if (this.m_SpinTurnLimit > 1618f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1769f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1316f : 628f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1851f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1112f;
				if (vector.sqrMagnitude < 1632f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1108f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x005AD43C File Offset: 0x005AB63C
		protected virtual void OEEDMGLAILI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1352f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1222f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 133f;
				if (this.m_SpinTurnLimit > 1877f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 889f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 35f : 44f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1463f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 675f;
				if (vector.sqrMagnitude < 359f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 114f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x005AD660 File Offset: 0x005AB860
		protected virtual void PBKHHKKGIBK(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 434f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 890f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1843f;
				if (this.m_SpinTurnLimit > 178f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 758f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 601f : 1337f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1632f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1216f;
				if (vector.sqrMagnitude < 1314f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 568f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x005AD884 File Offset: 0x005ABA84
		protected virtual void BNFEAINEOON(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 609f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1908f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 568f;
				if (this.m_SpinTurnLimit > 1534f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 558f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 859f : 1946f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 332f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1503f;
				if (vector.sqrMagnitude < 575f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1578f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x005ADAA8 File Offset: 0x005ABCA8
		protected virtual void IEGBHBKFCOM(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1832f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1146f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1054f;
				if (this.m_SpinTurnLimit > 1826f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1165f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 622f : 508f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1541f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 460f;
				if (vector.sqrMagnitude < 1262f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 750f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x005ADD34 File Offset: 0x005ABF34
		protected virtual void ABLDNOGBHCF(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 374f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 745f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 651f;
				if (this.m_SpinTurnLimit > 416f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1227f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 398f : 1286f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1704f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1508f;
				if (vector.sqrMagnitude < 838f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 467f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x005ADF58 File Offset: 0x005AC158
		protected virtual void ALCOIPODLJI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1500f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 563f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1724f;
				if (this.m_SpinTurnLimit > 157f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 850f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 854f : 1705f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1718f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 440f;
				if (vector.sqrMagnitude < 167f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1958f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x005AE17C File Offset: 0x005AC37C
		protected virtual void JOENPDNEMKD(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 76f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1290f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 829f;
				if (this.m_SpinTurnLimit > 370f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1247f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 979f : 662f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 313f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1556f;
				if (vector.sqrMagnitude < 1127f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 827f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB20 RID: 52000 RVA: 0x005AE3A0 File Offset: 0x005AC5A0
		protected virtual void KJFIIAKNHOA(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 838f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 827f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1479f;
				if (this.m_SpinTurnLimit > 1584f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1657f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 122f : 1466f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1200f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1524f;
				if (vector.sqrMagnitude < 1832f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 514f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x005AE5C4 File Offset: 0x005AC7C4
		protected virtual void ACCJCLHAMAC(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1502f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 106f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1197f;
				if (this.m_SpinTurnLimit > 1698f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 371f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1361f : 888f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 725f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1660f;
				if (vector.sqrMagnitude < 1882f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 268f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x005AE7E8 File Offset: 0x005AC9E8
		protected virtual void DJPBNKDDKEI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 517f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1670f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1831f;
				if (this.m_SpinTurnLimit > 1338f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1981f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 330f : 787f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1751f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1966f;
				if (vector.sqrMagnitude < 710f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 268f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x005AEA0C File Offset: 0x005ACC0C
		protected virtual void AHMDIINPJKD(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 549f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1910f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 302f;
				if (this.m_SpinTurnLimit > 1947f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 720f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 266f : 631f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1819f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1151f;
				if (vector.sqrMagnitude < 1560f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 405f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x005AEC30 File Offset: 0x005ACE30
		protected virtual void MFIGCNDOOEF(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1909f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1037f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1337f;
				if (this.m_SpinTurnLimit > 1011f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1695f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 826f : 1223f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1628f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1637f;
				if (vector.sqrMagnitude < 226f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1915f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x005AEE54 File Offset: 0x005AD054
		protected virtual void AEFOKEPNGJH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 212f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1114f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 871f;
				if (this.m_SpinTurnLimit > 24f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 267f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1181f : 1525f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1886f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 350f;
				if (vector.sqrMagnitude < 1620f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1154f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x005AF078 File Offset: 0x005AD278
		protected virtual void OLCAIBGBCAG(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 64f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1623f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 411f;
				if (this.m_SpinTurnLimit > 44f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 346f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1452f : 1864f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1897f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1565f;
				if (vector.sqrMagnitude < 505f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1903f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x005AF29C File Offset: 0x005AD49C
		protected virtual void IBKOHKFGLPK(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 724f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 818f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1527f;
				if (this.m_SpinTurnLimit > 365f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1632f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 377f : 1337f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1327f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1243f;
				if (vector.sqrMagnitude < 1825f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 473f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x005AF4C0 File Offset: 0x005AD6C0
		protected virtual void KMFDNAODMPO(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 932f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1894f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 419f;
				if (this.m_SpinTurnLimit > 466f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 263f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1721f : 1267f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 897f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 515f;
				if (vector.sqrMagnitude < 1008f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 959f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB29 RID: 52009 RVA: 0x005AF6E4 File Offset: 0x005AD8E4
		protected virtual void PCICJNFPLCJ(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1889f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 87f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1217f;
				if (this.m_SpinTurnLimit > 1861f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 727f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1118f : 1348f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1941f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 384f;
				if (vector.sqrMagnitude < 1830f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 811f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2A RID: 52010 RVA: 0x005AF908 File Offset: 0x005ADB08
		protected virtual void BGNACIJEBON(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1802f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 460f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1378f;
				if (this.m_SpinTurnLimit > 1633f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1679f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 280f : 654f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1611f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1187f;
				if (vector.sqrMagnitude < 493f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 506f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2B RID: 52011 RVA: 0x005AFB2C File Offset: 0x005ADD2C
		protected virtual void PKOFOAMBJCH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1100f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1254f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 10f;
				if (this.m_SpinTurnLimit > 221f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1805f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 669f : 206f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1755f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1631f;
				if (vector.sqrMagnitude < 1828f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1720f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2C RID: 52012 RVA: 0x005AFD50 File Offset: 0x005ADF50
		protected virtual void CNKBLOGMGMO(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 378f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1676f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 352f;
				if (this.m_SpinTurnLimit > 1439f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1907f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1951f : 1787f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 930f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1591f;
				if (vector.sqrMagnitude < 579f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1898f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x005AFF74 File Offset: 0x005AE174
		protected virtual void GBCGGNMDAKL(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 328f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1282f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1290f;
				if (this.m_SpinTurnLimit > 405f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 177f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 604f : 239f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 215f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 277f;
				if (vector.sqrMagnitude < 1132f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 976f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x005B0198 File Offset: 0x005AE398
		protected virtual void FBKIAIAEFBG(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 401f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 354f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 86f;
				if (this.m_SpinTurnLimit > 1831f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 527f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 967f : 1719f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 444f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 543f;
				if (vector.sqrMagnitude < 1558f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 248f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x005B03BC File Offset: 0x005AE5BC
		protected virtual void DBFHDGILJHI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1794f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1131f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1370f;
				if (this.m_SpinTurnLimit > 994f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1604f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1004f : 1995f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1580f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 989f;
				if (vector.sqrMagnitude < 320f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1658f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x005B05E0 File Offset: 0x005AE7E0
		protected virtual void BFDJDKHIDLO(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1458f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1970f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 497f;
				if (this.m_SpinTurnLimit > 1264f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1290f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 516f : 1092f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 446f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1014f;
				if (vector.sqrMagnitude < 1752f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1918f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x005B0804 File Offset: 0x005AEA04
		protected virtual void JFFMHFKNLFH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1784f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1180f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1719f;
				if (this.m_SpinTurnLimit > 752f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 298f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1233f : 344f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1042f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 950f;
				if (vector.sqrMagnitude < 468f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 533f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x005B0A28 File Offset: 0x005AEC28
		protected virtual void OOPNPDBDNLJ(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 670f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 277f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 774f;
				if (this.m_SpinTurnLimit > 214f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 272f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1106f : 121f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 385f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 175f;
				if (vector.sqrMagnitude < 1760f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 761f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x005B0C4C File Offset: 0x005AEE4C
		protected virtual void PLGOJCGELOK(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1576f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 440f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 653f;
				if (this.m_SpinTurnLimit > 642f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 938f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1531f : 863f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 99f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1310f;
				if (vector.sqrMagnitude < 665f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1230f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x005B0E70 File Offset: 0x005AF070
		protected virtual void CHHJLJEAFLL(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1819f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 673f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 427f;
				if (this.m_SpinTurnLimit > 1816f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1512f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1422f : 169f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1289f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 679f;
				if (vector.sqrMagnitude < 295f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 352f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x005B1094 File Offset: 0x005AF294
		protected virtual void DMFHGECJFKL(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1367f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1484f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 667f;
				if (this.m_SpinTurnLimit > 324f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 858f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1041f : 1001f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 447f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 100f;
				if (vector.sqrMagnitude < 1417f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 285f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x005B12B8 File Offset: 0x005AF4B8
		protected virtual void DNNEGJKKHGJ(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1361f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 61f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1740f;
				if (this.m_SpinTurnLimit > 1294f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 312f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 862f : 1136f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1874f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 229f;
				if (vector.sqrMagnitude < 1085f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1235f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x005B14DC File Offset: 0x005AF6DC
		protected virtual void MOHOGHIIBEB(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 872f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1761f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1741f;
				if (this.m_SpinTurnLimit > 1204f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 165f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 643f : 856f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1617f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1325f;
				if (vector.sqrMagnitude < 1213f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 663f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x005B1700 File Offset: 0x005AF900
		protected virtual void FKBNPCMMFBH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 726f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1002f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 91f;
				if (this.m_SpinTurnLimit > 1843f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1822f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 40f : 1895f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1849f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 880f;
				if (vector.sqrMagnitude < 459f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 356f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x005B1924 File Offset: 0x005AFB24
		protected virtual void JFLDEFDICKI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1885f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1051f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1986f;
				if (this.m_SpinTurnLimit > 1003f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 511f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 763f : 1869f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1133f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1662f;
				if (vector.sqrMagnitude < 1475f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 93f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x005B1B48 File Offset: 0x005AFD48
		protected virtual void MCOBJEOFFMI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1293f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 379f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1526f;
				if (this.m_SpinTurnLimit > 1300f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 985f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1570f : 366f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1132f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 675f;
				if (vector.sqrMagnitude < 613f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1683f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x005B1D6C File Offset: 0x005AFF6C
		protected virtual void GKKMADIBBCI(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1901f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 787f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 91f;
				if (this.m_SpinTurnLimit > 1495f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1142f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 452f : 656f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1806f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1841f;
				if (vector.sqrMagnitude < 3f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 430f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x005B1F90 File Offset: 0x005B0190
		protected virtual void ONIKMOIOJOP(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 191f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1795f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1600f;
				if (this.m_SpinTurnLimit > 1607f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 332f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1106f : 504f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 342f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 539f;
				if (vector.sqrMagnitude < 669f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1951f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x005B21B4 File Offset: 0x005B03B4
		protected virtual void NIIJHOPGHAA(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 766f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 770f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 267f;
				if (this.m_SpinTurnLimit > 819f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1903f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 671f : 930f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1302f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1479f;
				if (vector.sqrMagnitude < 1698f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1316f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x005B23D8 File Offset: 0x005B05D8
		protected virtual void LMOGGCEDOJN(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1103f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1731f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1127f;
				if (this.m_SpinTurnLimit > 753f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 126f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 782f : 955f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1402f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1938f;
				if (vector.sqrMagnitude < 1007f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 562f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x005B25FC File Offset: 0x005B07FC
		protected virtual void HMGKGAKCHHJ(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 487f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1912f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1690f;
				if (this.m_SpinTurnLimit > 693f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1913f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 411f : 329f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 345f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 918f;
				if (vector.sqrMagnitude < 1682f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 954f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x005B2820 File Offset: 0x005B0A20
		protected virtual void CHPGNJEEGOC(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1678f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 601f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 335f;
				if (this.m_SpinTurnLimit > 1123f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1259f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 550f : 1370f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1030f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1684f;
				if (vector.sqrMagnitude < 798f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 257f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x005B2A44 File Offset: 0x005B0C44
		protected virtual void EMBFHJFCOAF(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 707f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1837f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 151f;
				if (this.m_SpinTurnLimit > 1727f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 962f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 971f : 508f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1583f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1785f;
				if (vector.sqrMagnitude < 239f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1684f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x005B2C68 File Offset: 0x005B0E68
		protected virtual void CHJKAJKKJHC(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1543f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1483f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 47f;
				if (this.m_SpinTurnLimit > 543f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1237f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1444f : 307f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 484f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 232f;
				if (vector.sqrMagnitude < 69f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 850f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x005B2E8C File Offset: 0x005B108C
		protected virtual void DHMEPNIKEBE(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1455f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1060f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1722f;
				if (this.m_SpinTurnLimit > 720f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 508f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1940f : 716f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 500f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 541f;
				if (vector.sqrMagnitude < 766f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 489f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x005B30B0 File Offset: 0x005B12B0
		protected virtual void LDBCEIOJIOC(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 912f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1076f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1446f;
				if (this.m_SpinTurnLimit > 330f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 1850f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 687f : 888f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 154f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 821f;
				if (vector.sqrMagnitude < 864f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 435f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x005B32D4 File Offset: 0x005B14D4
		protected virtual void DKJPOHGFPLN(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 1210f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 809f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 959f;
				if (this.m_SpinTurnLimit > 701f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 974f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1918f : 1804f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 686f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 1992f;
				if (vector.sqrMagnitude < 1444f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1153f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x005B34F8 File Offset: 0x005B16F8
		protected override void IJLMPHHOJIH(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 0f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				if (this.m_SpinTurnLimit > 0f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 0.75f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 0.1f : 1f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 0f;
				if (vector.sqrMagnitude < 1E-45f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 0f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x0600CB47 RID: 52039 RVA: 0x005B371C File Offset: 0x005B191C
		protected virtual void BAPGGLLKGJL(float ENLHBNBNPJN)
		{
			if (ENLHBNBNPJN <= 649f || this.m_Target == null)
			{
				return;
			}
			Vector3 vector = this.m_Target.forward;
			Vector3 up = this.m_Target.up;
			if (this.m_FollowVelocity && Application.isPlaying)
			{
				if (this.FOJMMNLBFDK.velocity.magnitude > this.m_TargetVelocityLowerLimit)
				{
					vector = this.FOJMMNLBFDK.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, 1370f, ref this.BOIONPOMNAI, this.m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(vector.x, vector.z) * 1895f;
				if (this.m_SpinTurnLimit > 209f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(this.HAFEOFJINCJ, num)) / ENLHBNBNPJN;
					float num2 = Mathf.InverseLerp(this.m_SpinTurnLimit, this.m_SpinTurnLimit * 46f, value);
					float smoothTime = (this.EJFPFLHEJCC > num2) ? 1224f : 737f;
					if (Application.isPlaying)
					{
						this.EJFPFLHEJCC = Mathf.SmoothDamp(this.EJFPFLHEJCC, num2, ref this.BOIONPOMNAI, smoothTime);
					}
					else
					{
						this.EJFPFLHEJCC = num2;
					}
				}
				else
				{
					this.EJFPFLHEJCC = 1897f;
				}
				this.HAFEOFJINCJ = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
			if (!this.m_FollowTilt)
			{
				vector.y = 50f;
				if (vector.sqrMagnitude < 492f)
				{
					vector = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(vector, this.NLCMBGDDKID);
			this.NLCMBGDDKID = ((this.m_RollSpeed > 1651f) ? Vector3.Slerp(this.NLCMBGDDKID, up, this.m_RollSpeed * ENLHBNBNPJN) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, this.m_TurnSpeed * this.EJFPFLHEJCC * ENLHBNBNPJN);
		}

		// Token: 0x04001AF3 RID: 6899
		[SerializeField]
		private float m_MoveSpeed = 3f;

		// Token: 0x04001AF4 RID: 6900
		[SerializeField]
		private float m_TurnSpeed = 1f;

		// Token: 0x04001AF5 RID: 6901
		[SerializeField]
		private float m_RollSpeed = 0.2f;

		// Token: 0x04001AF6 RID: 6902
		[SerializeField]
		private bool m_FollowVelocity;

		// Token: 0x04001AF7 RID: 6903
		[SerializeField]
		private bool m_FollowTilt = true;

		// Token: 0x04001AF8 RID: 6904
		[SerializeField]
		private float m_SpinTurnLimit = 90f;

		// Token: 0x04001AF9 RID: 6905
		[SerializeField]
		private float m_TargetVelocityLowerLimit = 4f;

		// Token: 0x04001AFA RID: 6906
		[SerializeField]
		private float m_SmoothTurnTime = 0.2f;

		// Token: 0x04001AFB RID: 6907
		private float HAFEOFJINCJ;

		// Token: 0x04001AFC RID: 6908
		private float EJFPFLHEJCC;

		// Token: 0x04001AFD RID: 6909
		private float BOIONPOMNAI;

		// Token: 0x04001AFE RID: 6910
		private Vector3 NLCMBGDDKID = Vector3.up;
	}
}
