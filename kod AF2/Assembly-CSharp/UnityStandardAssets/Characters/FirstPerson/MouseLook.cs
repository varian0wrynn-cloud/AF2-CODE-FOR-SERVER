using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020003A5 RID: 933
	[Serializable]
	public class MouseLook
	{
		// Token: 0x0600C9CF RID: 51663 RVA: 0x005A4EAC File Offset: 0x005A30AC
		public void NNEHJLGOFFO(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("post_8") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("Wizard Neo Block") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(800f, y, 637f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 966f, 1816f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.JJKKOPIOHNL(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void NBOCAPIABNI(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x005A4FBC File Offset: 0x005A31BC
		public void EGMOGFFEMDN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("--") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("<i><color='#202020'>") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(232f, y, 406f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 290f, 109f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x005A50B4 File Offset: 0x005A32B4
		private Quaternion DHGKDDKMJAN(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1901f;
			float num = 1013f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1481f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x005A513C File Offset: 0x005A333C
		public void PPLPNLOEGEO(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("IdleReady") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("GestureChestPumpSalute") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1871f, y, 791f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1973f, 1524f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.BMNJAFDDAEH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x005A5234 File Offset: 0x005A3434
		public void FLBIDPENOOG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Down Index:") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE(" ") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(154f, y, 1028f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 208f, 1754f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.BOPBFBLOEJN(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D5 RID: 51669 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void AABHPAAMMOJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void MJENLBHDCLG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x005A532C File Offset: 0x005A352C
		public void NFDNGJJADCM(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("BAG") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("KatanaReadyHigh") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(926f, y, 1070f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 357f, 800f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.OCCBEGEFBEK(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D8 RID: 51672 RVA: 0x005A5424 File Offset: 0x005A3624
		public void GFDMIKALOGA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("WoodSaw") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(531f, y, 109f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 22f, 1132f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.OCCBEGEFBEK(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x005A551C File Offset: 0x005A371C
		private Quaternion FKOGAIALINE(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1150f;
			float num = 1130f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1535f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x005A55A4 File Offset: 0x005A37A4
		public void IMIHEBPMGLN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("{0:0.} fps ping:{1} pck/sec: {2}") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("tid") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(817f, y, 1942f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1195f, 1538f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.DHGKDDKMJAN(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void HDOMBPAKEPC(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x005A569C File Offset: 0x005A389C
		public void DGMONPPHMEN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("cntx_close") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("CD") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(348f, y, 1908f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 978f, 176f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.OCCBEGEFBEK(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FPPGDHJOPKH(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9DE RID: 51678 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void MAENOCDHJMB(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9DF RID: 51679 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void LGGBEFANJAE(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9E0 RID: 51680 RVA: 0x005A5794 File Offset: 0x005A3994
		public void EBDDHJAGIGD(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("file") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("_DelItem.wav") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1520f, y, 1879f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 149f, 148f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.BNBKONOJMIJ(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9E1 RID: 51681 RVA: 0x005A588C File Offset: 0x005A3A8C
		private Quaternion BNBKONOJMIJ(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 137f;
			float num = 603f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1930f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9E2 RID: 51682 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void PIGKBMCJAHN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x005A5914 File Offset: 0x005A3B14
		private Quaternion FPPALIBIFMM(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 79f;
			float num = 651f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(74f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9E4 RID: 51684 RVA: 0x005A599C File Offset: 0x005A3B9C
		private Quaternion BOPBFBLOEJN(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1322f;
			float num = 910f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(949f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void JCBPDNHCDAE(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FGHNBCENAOH(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x005A5A24 File Offset: 0x005A3C24
		public void KDEJHPNAAGJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("; ") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("IX") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(946f, y, 843f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1702f, 1059f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.EGGGOHJFJNP(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9E8 RID: 51688 RVA: 0x005A5B1C File Offset: 0x005A3D1C
		public void BCDJIHKMJDO(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("IKSolverFABRIKRoot chain at index ") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(116f, y, 490f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1830f, 663f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.AKMENMNOGPH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x005A5C14 File Offset: 0x005A3E14
		private Quaternion OCCBEGEFBEK(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 806f;
			float num = 778f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(726f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x005A5C9C File Offset: 0x005A3E9C
		private Quaternion AIDNLAMKNOB(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1781f;
			float num = 298f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(564f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void DONMKBAAMKK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void AFGPHPBPJJP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9ED RID: 51693 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void JGKKAKJIMEK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9EE RID: 51694 RVA: 0x005A5D24 File Offset: 0x005A3F24
		private Quaternion EIHLLLCCIFO(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 405f;
			float num = 1688f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1690f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9EF RID: 51695 RVA: 0x005A5DAC File Offset: 0x005A3FAC
		public void BOOBKMJJDPP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("repair.ogg") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("_EMISSION") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1130f, y, 1931f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1380f, 1153f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.OCCBEGEFBEK(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x005A5EA4 File Offset: 0x005A40A4
		public void HOHECFACKAM(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("error.wav") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("Neck") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1596f, y, 722f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1705f, 388f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.CKLOBJKMCAC(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x005A5F9C File Offset: 0x005A419C
		public void EHMKEILENNB(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("-no info-") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("ForwardVelocity") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(20f, y, 1267f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1086f, 763f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.HCKJKFBHDHL(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9F2 RID: 51698 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void HKNHBOEFHGG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9F3 RID: 51699 RVA: 0x005A6094 File Offset: 0x005A4294
		public void HFNBHMLHCJE(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("_WorldToCameraMatrix") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(551f, y, 994f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1811f, 1879f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9F4 RID: 51700 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FGDNNKMAHJO(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x005A618C File Offset: 0x005A438C
		private Quaternion HHAACNJBNCK(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1932f;
			float num = 1996f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1926f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x005A6214 File Offset: 0x005A4414
		private Quaternion AEOCJGFPJKF(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 669f;
			float num = 1824f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1812f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x005A629C File Offset: 0x005A449C
		public void HEMJEIADKDD(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Sorry, VRIK Script reference is not finished yet.") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("OnRodChangeClck 4") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1665f, y, 469f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 386f, 568f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600C9F8 RID: 51704 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void CHBEKLDHLJD(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void GEBDJPNLKAG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9FA RID: 51706 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void IOPLEEHGNJK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9FB RID: 51707 RVA: 0x005A6394 File Offset: 0x005A4594
		private Quaternion HCKJKFBHDHL(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1822f;
			float num = 610f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1196f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9FC RID: 51708 RVA: 0x005A641C File Offset: 0x005A461C
		private Quaternion NFLLLOKFBGG(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1f;
			float num = 114.59156f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(0.008726646f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x005A64A4 File Offset: 0x005A46A4
		private Quaternion JJKKOPIOHNL(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1819f;
			float num = 1605f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(241f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void NHHKCKOKKOP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void ONBFICFJPLM(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x005A652C File Offset: 0x005A472C
		public void JNGJHKKECCE(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Keeper Strafe Dive Far Left") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("WalkInjured") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(300f, y, 1730f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1532f, 1867f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ABNCIGIGGLE(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void MJBIOLJADLH(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x005A6624 File Offset: 0x005A4824
		public void FCFCPIJBKNP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE(", ") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("ScatterDitherMap") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1215f, y, 255f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1854f, 774f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.IDJBNNAIOKI(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA03 RID: 51715 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void OBGCHDDFNCF(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void DKAKMBNJBPG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void HLOFDNPNGOK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void BBCINJAGHEP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x005A671C File Offset: 0x005A491C
		private Quaternion EGGGOHJFJNP(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1346f;
			float num = 1354f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(671f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x005A67A4 File Offset: 0x005A49A4
		public void IGFBPNIHMEB(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Horizontal") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("cntx_close") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1132f, y, 1293f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1171f, 289f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.FPPALIBIFMM(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA09 RID: 51721 RVA: 0x005A689C File Offset: 0x005A4A9C
		private Quaternion AKMENMNOGPH(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1914f;
			float num = 636f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1624f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void KMICLAAHOLM(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x005A6924 File Offset: 0x005A4B24
		public void DDILLBAABKK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("♼ ") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("Jump") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1101f, y, 1378f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 241f, 826f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.CKLOBJKMCAC(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void ENLEBOOIGKJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x005A6A1C File Offset: 0x005A4C1C
		public void MNENBNBNIKE(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("\n") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("USE_DIAG_SEARCH") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1846f, y, 1897f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 940f, 1064f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.BPNBLLMKMBG(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void DFHGBNABLEC(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x005A6B68 File Offset: 0x005A4D68
		public void DAOLNFHFDFO(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("x2") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("1 Hand Sword Jab Foot Push") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(877f, y, 376f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1472f, 520f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.OCCBEGEFBEK(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x005A6C60 File Offset: 0x005A4E60
		private Quaternion BPNBLLMKMBG(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1047f;
			float num = 1403f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(545f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA12 RID: 51730 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void HCJHJBAKBBP(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x005A6CE8 File Offset: 0x005A4EE8
		public void LHEBJIMEBDF(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Axis is Vector3.zero.") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("MotorbikeLassoBack") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1888f, y, 603f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1732f, 1352f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.AEOCJGFPJKF(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x005A6DE0 File Offset: 0x005A4FE0
		public void NCGIALPJKFI(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("UIChat_fontSize") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("RussianDance") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(361f, y, 1578f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 507f, 1173f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.DHGKDDKMJAN(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA15 RID: 51733 RVA: 0x005A6ED8 File Offset: 0x005A50D8
		public void HILODEBFCBN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("SoccerTackle") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("crft_from") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(271f, y, 227f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 164f, 1010f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.FKOGAIALINE(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA16 RID: 51734 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void MBLNJOFJJCG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA17 RID: 51735 RVA: 0x005A6FD0 File Offset: 0x005A51D0
		private Quaternion IIDJMJJDIEH(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 131f;
			float num = 814f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(201f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void EAONEAGNPCD(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA19 RID: 51737 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void NCMPGDLDPJG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA1A RID: 51738 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void NBNPGNFKHMF(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x005A7058 File Offset: 0x005A5258
		private Quaternion GCLCGCOKPOI(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1655f;
			float num = 464f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1454f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x005A70E0 File Offset: 0x005A52E0
		public void EOIEAIMHEEK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("OfficeSittingHandRestFingerTap") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("_SunPosition") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1948f, y, 1663f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 40f, 724f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.EGGGOHJFJNP(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA1D RID: 51741 RVA: 0x005A71D8 File Offset: 0x005A53D8
		public void DLDEJFLMENN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Roar") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("readActorData") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1981f, y, 330f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1257f, 956f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x005A72D0 File Offset: 0x005A54D0
		private Quaternion BMNJAFDDAEH(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1575f;
			float num = 1670f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(973f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x005A7358 File Offset: 0x005A5558
		public void FBAAGDOLLEK(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("#000000") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("IdleButtonPress") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1686f, y, 767f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1518f, 782f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.GCLCGCOKPOI(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x005A7450 File Offset: 0x005A5650
		private Quaternion IDJBNNAIOKI(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 463f;
			float num = 623f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1000f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x005A74D8 File Offset: 0x005A56D8
		public void AKHCBMBFHMJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("_AdaptationSpeed") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("Item_Sell.ogg") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1125f, y, 1056f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1501f, 357f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.AKMENMNOGPH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x005A75D0 File Offset: 0x005A57D0
		private Quaternion CKLOBJKMCAC(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1348f;
			float num = 1678f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(356f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x005A7658 File Offset: 0x005A5858
		public void CMDMHNNKPME(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("Mouse X") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("Mouse Y") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(0f, y, 0f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 0f, 0f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.NFLLLOKFBGG(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x005A7750 File Offset: 0x005A5950
		private Quaternion ABNCIGIGGLE(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1835f;
			float num = 1389f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(697f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void JONEKLKPPJA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void PINLMCCKKNA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void LFLNBKOCHND(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FLHHEEAEPHJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x005A77D8 File Offset: 0x005A59D8
		public void DEIPEHJMDEH(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("1HandSwordChargeSwipe") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("B") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(452f, y, 913f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1171f, 1458f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.IIDJMJJDIEH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FJPNMHHGEEH(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void DAEINNAFDOB(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x005A78D0 File Offset: 0x005A5AD0
		public void ADBNPPELGJN(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("effect") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1468f, y, 691f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1418f, 123f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void FLNCGLFALBF(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void PBDMAGJEBEJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x005A79C8 File Offset: 0x005A5BC8
		public void PNGKHNEIFGA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("wpn_bait1") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("CrawlIdle") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(559f, y, 624f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 276f, 1692f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ABNCIGIGGLE(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x005A7AC0 File Offset: 0x005A5CC0
		private Quaternion ANNEBIDIGAH(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 714f;
			float num = 383f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(696f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA31 RID: 51761 RVA: 0x005A7B48 File Offset: 0x005A5D48
		public void DHEFGEAGHBA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE(" registered.") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("CM") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(369f, y, 769f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 220f, 1496f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.BOPBFBLOEJN(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA32 RID: 51762 RVA: 0x005A7C40 File Offset: 0x005A5E40
		private Quaternion JFOHBBKDCBM(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 531f;
			float num = 36f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(664f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA33 RID: 51763 RVA: 0x005A7CC8 File Offset: 0x005A5EC8
		public void LJHIGPOMDBM(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("_MainTex") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("ClimbRight") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(905f, y, 1575f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1669f, 776f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.AKMENMNOGPH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void KHCLKALPFDG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x005A4FA1 File Offset: 0x005A31A1
		public void KKIGGCNACOG(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			this.m_CharacterTargetRot = IFIIFDKAKDJ.localRotation;
			this.m_CameraTargetRot = LBCHLCGOCOD.localRotation;
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x005A7DC0 File Offset: 0x005A5FC0
		public void ANDOKMCJBLJ(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("_BlurVector") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("http://www.root-motion.com/finalikdox/html/page11.html") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(1638f, y, 1993f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 1483f, 1311f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.EIHLLLCCIFO(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x005A7EB8 File Offset: 0x005A60B8
		public void LLIJNKCADHA(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("11") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE(" on effect ") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(944f, y, 648f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 539f, 1988f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.ANNEBIDIGAH(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x005A7FB0 File Offset: 0x005A61B0
		public void LLJOKNFKPLL(Transform IFIIFDKAKDJ, Transform LBCHLCGOCOD)
		{
			float y = CELBHNONENJ.LBBLPMHONLE("_BumpMap") * this.XSensitivity;
			float num = CELBHNONENJ.LBBLPMHONLE("_Offsets") * this.YSensitivity;
			this.m_CharacterTargetRot *= Quaternion.Euler(113f, y, 1617f);
			this.m_CameraTargetRot *= Quaternion.Euler(-num, 576f, 1864f);
			if (this.clampVerticalRotation)
			{
				this.m_CameraTargetRot = this.GCLCGCOKPOI(this.m_CameraTargetRot);
			}
			if (this.smooth)
			{
				IFIIFDKAKDJ.localRotation = Quaternion.Slerp(IFIIFDKAKDJ.localRotation, this.m_CharacterTargetRot, this.smoothTime * Time.deltaTime);
				LBCHLCGOCOD.localRotation = Quaternion.Slerp(LBCHLCGOCOD.localRotation, this.m_CameraTargetRot, this.smoothTime * Time.deltaTime);
				return;
			}
			IFIIFDKAKDJ.localRotation = this.m_CharacterTargetRot;
			LBCHLCGOCOD.localRotation = this.m_CameraTargetRot;
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x005A80A8 File Offset: 0x005A62A8
		private Quaternion IMGEEIOKDEO(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 835f;
			float num = 1498f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(196f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x005A8130 File Offset: 0x005A6330
		private Quaternion MCIMDLIPLMN(Quaternion HPOGKAAEHKP)
		{
			HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
			HPOGKAAEHKP.w = 1222f;
			float num = 703f * Mathf.Atan(HPOGKAAEHKP.x);
			num = Mathf.Clamp(num, this.MinimumX, this.MaximumX);
			HPOGKAAEHKP.x = Mathf.Tan(1411f * num);
			return HPOGKAAEHKP;
		}

		// Token: 0x04001AC9 RID: 6857
		public float XSensitivity = 2f;

		// Token: 0x04001ACA RID: 6858
		public float YSensitivity = 2f;

		// Token: 0x04001ACB RID: 6859
		public bool clampVerticalRotation = true;

		// Token: 0x04001ACC RID: 6860
		public float MinimumX = -90f;

		// Token: 0x04001ACD RID: 6861
		public float MaximumX = 90f;

		// Token: 0x04001ACE RID: 6862
		public bool smooth;

		// Token: 0x04001ACF RID: 6863
		public float smoothTime = 5f;

		// Token: 0x04001AD0 RID: 6864
		private Quaternion m_CharacterTargetRot;

		// Token: 0x04001AD1 RID: 6865
		private Quaternion m_CameraTargetRot;
	}
}
