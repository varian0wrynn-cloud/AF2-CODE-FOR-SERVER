using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003ED RID: 1005
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		// Token: 0x0600D815 RID: 55317 RVA: 0x0062AD54 File Offset: 0x00628F54
		public virtual void HCPBDBBLMKP(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 982f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("0_", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("_ProjInfo", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("inv_pers", JMJEFKLOKLL);
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x0062AE48 File Offset: 0x00629048
		public virtual void INBECGFLGNJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1375f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("_LerpAmount", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Bases/Base_1.unity3d", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_Offsets", JMJEFKLOKLL);
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x0062AF3C File Offset: 0x0062913C
		private void OnAnimatorMove()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D818 RID: 55320 RVA: 0x0062AFD0 File Offset: 0x006291D0
		private void GNLABLCNFKP()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 677f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D819 RID: 55321 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CKGPEFOKKNL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D81A RID: 55322 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void FGJCIEDDFGN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D81B RID: 55323 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void ANHOOJFEJJE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D81C RID: 55324 RVA: 0x0062B070 File Offset: 0x00629270
		public virtual void HPGBIANDJPO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1409f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("EventSystem", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("OfficeSitting45DegLeg", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("FOG_OF_WAR_ON", JMJEFKLOKLL);
		}

		// Token: 0x0600D81D RID: 55325 RVA: 0x0062B164 File Offset: 0x00629364
		public virtual void NDNLOJFCIKJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 565f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("gi_um_rec", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("<color='#602000'>", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("JNT_Root", JMJEFKLOKLL);
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x0062B258 File Offset: 0x00629458
		private void KBIIGMABBFO()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 154f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D81F RID: 55327 RVA: 0x0062B2EC File Offset: 0x006294EC
		public virtual void CDPIFBKGEIJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1660f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("SUNSHINE_FILTER_PCF_4x4", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Reset", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("rait_5", JMJEFKLOKLL);
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x0062B3E0 File Offset: 0x006295E0
		public virtual void NMJLAEAIBDK(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1200f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("rod_inf2", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("auk_pstinf", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("UserChange", JMJEFKLOKLL);
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x0062B4D4 File Offset: 0x006296D4
		private void BMNNJPNKMGC()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 874f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void FFIGGPHAIBP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void ECMAANIDEBA()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x0062B568 File Offset: 0x00629768
		private void LNMBHPJONFL()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 952f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x0062B5FC File Offset: 0x006297FC
		public virtual void HBILENOGLNG(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 379f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Criticals", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("{0}KLIK_10.tif", JMJEFKLOKLL);
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x0062B6F0 File Offset: 0x006298F0
		private void FPDCCMADIHC()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1469f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D827 RID: 55335 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void MMACLBBMDLA()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x0062B784 File Offset: 0x00629984
		public virtual void GLMDLNALODJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 481f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("MotorbikeShootRight", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("error.wav", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_DelItem.wav", JMJEFKLOKLL);
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void LPNDCJKAKEA()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x0062B878 File Offset: 0x00629A78
		private void GNJAOPCCNOL()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 477f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D82B RID: 55339 RVA: 0x0062B90C File Offset: 0x00629B0C
		public virtual void HOCPKBIPCKE(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 106f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("MotorbikeTurnLeft", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("[/quote]", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("fishStamKF=", JMJEFKLOKLL);
		}

		// Token: 0x0600D82C RID: 55340 RVA: 0x0062BA00 File Offset: 0x00629C00
		private void OGLHLEIPAGA()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 318f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D82D RID: 55341 RVA: 0x0062BA94 File Offset: 0x00629C94
		public virtual void JMGOPIKHDDJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1289f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("post_2", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("***Lots ", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("Speed hack Detected!", JMJEFKLOKLL);
		}

		// Token: 0x0600D82E RID: 55342 RVA: 0x0062BB88 File Offset: 0x00629D88
		public virtual void MBADPHEAJKO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1903f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("chnam1", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("mouseLook not found", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("wpn_add/base", JMJEFKLOKLL);
		}

		// Token: 0x0600D82F RID: 55343 RVA: 0x0062BC7C File Offset: 0x00629E7C
		private void OHCDJPJFHGD()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1224f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D830 RID: 55344 RVA: 0x0062BD10 File Offset: 0x00629F10
		private void GLEDCGNIIHM()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 989f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D831 RID: 55345 RVA: 0x0062BDA4 File Offset: 0x00629FA4
		public virtual void MCOBJLHDIAP(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 259f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("no_inventory", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_Jitter", JMJEFKLOKLL);
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void DMAOHJDKMNN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x0062BE98 File Offset: 0x0062A098
		public virtual void PCCFANHAHMO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 594f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Death", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("OfficeSittingReadingPageFlip", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("<color='#003000'>", JMJEFKLOKLL);
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D835 RID: 55349 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void LHMNFJBJBJM()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D836 RID: 55350 RVA: 0x0062BF8C File Offset: 0x0062A18C
		private void DLAKAGPNNNL()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1598f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D837 RID: 55351 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CHDJGEOFHEE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D838 RID: 55352 RVA: 0x0062C020 File Offset: 0x0062A220
		public virtual void DJHCIHACNAA(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 781f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("WATER_EDGEBLEND_OFF", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("_PrevViewProj", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("", JMJEFKLOKLL);
		}

		// Token: 0x0600D839 RID: 55353 RVA: 0x0062C114 File Offset: 0x0062A314
		private void GHOHCNIHCIL()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1695f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D83A RID: 55354 RVA: 0x0062C1A8 File Offset: 0x0062A3A8
		public virtual void FMADCKHIJJK(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1816f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("#ffff40", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("ShotgunReadyFire", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("GiantGrabIdle2", JMJEFKLOKLL);
		}

		// Token: 0x0600D83B RID: 55355 RVA: 0x0062C29C File Offset: 0x0062A49C
		public virtual void OIKMIGNCGFA(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1015f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Idle Standing Jump", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Trying to solve uninitiated FABRIK chain.", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("One of the Bones is null.", JMJEFKLOKLL);
		}

		// Token: 0x0600D83C RID: 55356 RVA: 0x0062C390 File Offset: 0x0062A590
		private void KMABAMCOMOD()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 108f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D83D RID: 55357 RVA: 0x0062C424 File Offset: 0x0062A624
		public virtual void CAPLHKODIIJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 336f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Pick Up ", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("size", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("[sysname]", JMJEFKLOKLL);
		}

		// Token: 0x0600D83E RID: 55358 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void MKNPFMEMOJO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D83F RID: 55359 RVA: 0x0062C518 File Offset: 0x0062A718
		public virtual void AOOHHGKBICH(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 877f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("The space size '", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("result=OK", JMJEFKLOKLL);
		}

		// Token: 0x0600D840 RID: 55360 RVA: 0x0062C60C File Offset: 0x0062A80C
		public virtual void LHEMPEOIAPP(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 600f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("1HandSwordJabCombo", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("_GuiProcessor", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("defDur", JMJEFKLOKLL);
		}

		// Token: 0x0600D842 RID: 55362 RVA: 0x0062C734 File Offset: 0x0062A934
		public virtual void PMHGPIPFOHI(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 127f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Vertical", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("HeelClick", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("demoRect", JMJEFKLOKLL);
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x0062C828 File Offset: 0x0062AA28
		private void NBHMIODFMIB()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 769f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x0062C8BC File Offset: 0x0062AABC
		public virtual void CGHECDAJCCP(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1394f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("cht_msg18", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("WoodSaw", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("WeaponInstant", JMJEFKLOKLL);
		}

		// Token: 0x0600D845 RID: 55365 RVA: 0x0062C9B0 File Offset: 0x0062ABB0
		public virtual void HBBOOAHGMCM(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1849f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("WeaponRunBackward", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Load costume ", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_SelectColor", JMJEFKLOKLL);
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x0062CAA4 File Offset: 0x0062ACA4
		private void NKAPIPKFHEE()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 572f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D847 RID: 55367 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void PMDPLLIBJAF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D848 RID: 55368 RVA: 0x0062CB38 File Offset: 0x0062AD38
		private void BBMCLFEDFPG()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1087f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x0062CBCC File Offset: 0x0062ADCC
		private void GPIBECCNNGM()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 9f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D84A RID: 55370 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CJNBMPCNKHP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D84B RID: 55371 RVA: 0x0062CC60 File Offset: 0x0062AE60
		private void NGNMCJLDHMI()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1745f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D84C RID: 55372 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void LHJCHPFKGDB()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x0062CCF4 File Offset: 0x0062AEF4
		public virtual void Move(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("X", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Z", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("IsMoving", JMJEFKLOKLL);
		}

		// Token: 0x0600D84E RID: 55374 RVA: 0x0062CDE8 File Offset: 0x0062AFE8
		private void AGEDEENAFJK()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1394f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D84F RID: 55375 RVA: 0x0062CE7C File Offset: 0x0062B07C
		public virtual void DCANDLOECBI(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1744f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("The image effect ", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat(" ms", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("Blank Overcast Texture Missing...", JMJEFKLOKLL);
		}

		// Token: 0x0600D850 RID: 55376 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void FJGIBCHABIG()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D851 RID: 55377 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void LHHKDNILMDI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void LBEFOABPMFG()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D853 RID: 55379 RVA: 0x0062CF70 File Offset: 0x0062B170
		public virtual void LPLKMLKEFLM(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1636f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: ", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("crft_norec2", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("Ok", JMJEFKLOKLL);
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x0062D064 File Offset: 0x0062B264
		private void FDPIDAGMKIG()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1598f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x0062D0F8 File Offset: 0x0062B2F8
		public virtual void FHOLCCLENBL(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 332f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("(game main)", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("DeadmanFloat", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_ReprojectionMatrix", JMJEFKLOKLL);
		}

		// Token: 0x0600D856 RID: 55382 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void BBFPILBIMKC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D857 RID: 55383 RVA: 0x0062D1EC File Offset: 0x0062B3EC
		public virtual void DPNLBEFBNAB(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1384f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("_Exposure", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Idle Strafe Right", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool(" Bones.", JMJEFKLOKLL);
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void PNAAHEFHPCL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void JPHBPEAMNHB()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D85A RID: 55386 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void DPPAAIJCFLC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D85B RID: 55387 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CKIGGCAHAFD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D85C RID: 55388 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void PFNPOHMMJDN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x0062D2E0 File Offset: 0x0062B4E0
		public virtual void JNENPACLMAJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 368f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("OpenRecords", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("IdleButtonPress", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("wpn_add/base", JMJEFKLOKLL);
		}

		// Token: 0x0600D85E RID: 55390 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CPNOBMNKPNC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D85F RID: 55391 RVA: 0x0062D3D4 File Offset: 0x0062B5D4
		private void BELEKAPDMJC()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1703f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x0062D468 File Offset: 0x0062B668
		private void FNDHBBMJGON()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1848f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x0062D4FC File Offset: 0x0062B6FC
		private void BIHLKALHAHM()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1862f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x0062D590 File Offset: 0x0062B790
		private void NFCHINIILBE()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1814f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void HDFCIACDDEK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void PBMPJPIMJBF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D865 RID: 55397 RVA: 0x0062D624 File Offset: 0x0062B824
		public virtual void FMHDIGGEPPM(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 891f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("Climbing Idle", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("CCDIK not found!", JMJEFKLOKLL);
		}

		// Token: 0x0600D866 RID: 55398 RVA: 0x0062D718 File Offset: 0x0062B918
		private void GJJMIEFMNNE()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 99f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D867 RID: 55399 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void FODDAMMNECI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D868 RID: 55400 RVA: 0x0062D7AC File Offset: 0x0062B9AC
		private void NHANPLDNPKO()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 956f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x0062D840 File Offset: 0x0062BA40
		public virtual void CNGEKJMPFBJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 675f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("BowFire", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("WRINKLE_MAPS", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_Offsets", JMJEFKLOKLL);
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x0062D934 File Offset: 0x0062BB34
		private void AMIMDMPCMFE()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1363f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void CGMHGDEKDEP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x0062D9C8 File Offset: 0x0062BBC8
		public virtual void MOPCGHIELAO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 672f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("result=OK", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("MotorbikeBackwardSittingCheer", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("FishbragContainer", JMJEFKLOKLL);
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void DGDGMFDPEHO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void NCALLFHEAGJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x0062DABC File Offset: 0x0062BCBC
		private void KKIINLKKDFD()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1584f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void GDIMBBBPIHI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x0062DB50 File Offset: 0x0062BD50
		private void JOHIAJFJBGD()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1554f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x0062DBE4 File Offset: 0x0062BDE4
		private void OPMLONOBLNP()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1195f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x0062DC78 File Offset: 0x0062BE78
		public virtual void BALAGDCLOMD(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1454f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("id", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("human_move_2.wav", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("WizardPowerUp", JMJEFKLOKLL);
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void IMABGALEMBI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D875 RID: 55413 RVA: 0x0062DD6C File Offset: 0x0062BF6C
		public virtual void DBGDNKOAGPJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1812f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("shop_t17", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("\n", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("FASTEST", JMJEFKLOKLL);
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void DHJDMKLBLEF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D877 RID: 55415 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void OPNPODKLOJK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D878 RID: 55416 RVA: 0x0062DE60 File Offset: 0x0062C060
		public virtual void JCLOJGLONCN(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 738f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Soccer Throw", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("NextFrame", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_History3ChromaTex", JMJEFKLOKLL);
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x0062DF54 File Offset: 0x0062C154
		private void HIKCIDFHNPN()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1051f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void AFFAJKPPMHF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x0062DFE8 File Offset: 0x0062C1E8
		private void BGHGELLKMKO()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1992f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x0062E07C File Offset: 0x0062C27C
		public virtual void FBBAEMKMCMI(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 1505f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("Visit docs to see where PlayerPrefs are stored", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("IceHockey", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("Idle Meditate", JMJEFKLOKLL);
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void ADLHNBEDHMJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D87E RID: 55422 RVA: 0x0062E170 File Offset: 0x0062C370
		public virtual void NAFECHFDNGC(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 751f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("1 Hand Sword Strafe Left", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("<color='#002030'>+{0} {1}</color>", JMJEFKLOKLL);
		}

		// Token: 0x0600D87F RID: 55423 RVA: 0x0062E264 File Offset: 0x0062C464
		private void FOJJLGALGLO()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 11f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x0062E2F8 File Offset: 0x0062C4F8
		public virtual void IHEGIHFJFJF(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			this.OMHLINDNFBG = OMHLINDNFBG;
			Vector3 vector = base.transform.InverseTransformDirection(OEGGGHKNDKE);
			float num = Mathf.Atan2(vector.x, vector.z) * 688f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.KOCEJIPJEHO = Vector3.Lerp(this.KOCEJIPJEHO, OMHLINDNFBG, Time.deltaTime * this.blendSpeed);
			this.KCLACNEILLB.SetFloat("", this.KOCEJIPJEHO.x);
			this.KCLACNEILLB.SetFloat("PersonWomanFisher", this.KOCEJIPJEHO.z);
			this.KCLACNEILLB.SetBool("_UserLut", JMJEFKLOKLL);
		}

		// Token: 0x0600D881 RID: 55425 RVA: 0x0062E3EC File Offset: 0x0062C5EC
		private void HFLKPPGJMBI()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1123f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D882 RID: 55426 RVA: 0x0062E480 File Offset: 0x0062C680
		private void NADFPCBFLBB()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 715f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x0062E514 File Offset: 0x0062C714
		private void PEPIDEKJANC()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1051f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D884 RID: 55428 RVA: 0x0062E5A8 File Offset: 0x0062C7A8
		private void GEPPAOFJMEH()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 121f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void ELCNJDNCAEP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x0062E63C File Offset: 0x0062C83C
		private void AIFJNNHLGLB()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1169f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x0062E6D0 File Offset: 0x0062C8D0
		private void FGIMBLFGNIA()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1041f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void KEIILPMCFEO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600D889 RID: 55433 RVA: 0x0062E764 File Offset: 0x0062C964
		private void APPNFODHEAG()
		{
			this.APOIOHJJDDC = Vector3.Lerp(this.APOIOHJJDDC, base.transform.rotation * Vector3.ClampMagnitude(this.OMHLINDNFBG, 1686f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.APOIOHJJDDC * Time.deltaTime, this.KCLACNEILLB.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x0600D88A RID: 55434 RVA: 0x0062B061 File Offset: 0x00629261
		protected virtual void INDGOHJGCFN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x04001CAB RID: 7339
		public float rotateSpeed = 7f;

		// Token: 0x04001CAC RID: 7340
		public float blendSpeed = 10f;

		// Token: 0x04001CAD RID: 7341
		public float maxAngle = 90f;

		// Token: 0x04001CAE RID: 7342
		public float moveSpeed = 1.5f;

		// Token: 0x04001CAF RID: 7343
		public float rootMotionWeight;

		// Token: 0x04001CB0 RID: 7344
		protected Animator KCLACNEILLB;

		// Token: 0x04001CB1 RID: 7345
		protected Vector3 KOCEJIPJEHO;

		// Token: 0x04001CB2 RID: 7346
		protected Vector3 OMHLINDNFBG;

		// Token: 0x04001CB3 RID: 7347
		protected Vector3 APOIOHJJDDC;
	}
}
