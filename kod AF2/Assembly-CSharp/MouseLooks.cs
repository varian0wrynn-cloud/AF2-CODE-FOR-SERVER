using System;
using UnityEngine;

// Token: 0x0200027C RID: 636
public class MouseLooks : MonoBehaviour
{
	// Token: 0x06009444 RID: 37956 RVA: 0x00421A3C File Offset: 0x0041FC3C
	private void IGEICBNMPAD()
	{
		if (!this.isFreeze)
		{
			float num = 1647f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 930f : 136f);
			}
			float num2 = Input.GetAxis("x") * 260f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Wizard1HandThrow") * 442f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 18f, Time.deltaTime * 1478f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1568f, Time.deltaTime * 1552f);
	}

	// Token: 0x06009445 RID: 37957 RVA: 0x00421BCC File Offset: 0x0041FDCC
	private Quaternion LGPBFIOKFHH(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1634f;
		float num = 1945f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1525f, 1672f);
		HPOGKAAEHKP.x = Mathf.Tan(1285f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x00421C50 File Offset: 0x0041FE50
	private void LBGKAMLLACN()
	{
		if (!this.isFreeze)
		{
			float num = 1019f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1862f : 1843f);
			}
			float num2 = Input.GetAxis("SoccerSprint") * 426f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("PistolFire") * 917f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 334f, Time.deltaTime * 845f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1733f, Time.deltaTime * 1902f);
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x00421DE0 File Offset: 0x0041FFE0
	private Quaternion FFPAMJIMMKG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1913f;
		float num = 576f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 662f, 461f);
		HPOGKAAEHKP.x = Mathf.Tan(738f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009448 RID: 37960 RVA: 0x00421E64 File Offset: 0x00420064
	public void KNCJPBICKIK(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("No fish in fishModelData modelid=") * 397f * this.sensitivityX;
		float num = Input.GetAxis("msg_other") * 49f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(131f, y, 1679f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1397f, 1463f);
		PMMEFNKFJIA.localRotation = this.FPEGDFBLNKG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009449 RID: 37961 RVA: 0x00421EF8 File Offset: 0x004200F8
	private void KFNOEOIIBOI()
	{
		if (!this.isFreeze)
		{
			float num = 1610f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1115f : 1721f);
			}
			float num2 = Input.GetAxis("sunshine_OvercastMap") * 1182f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("craft_data/categories/category") * 1952f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 404f, Time.deltaTime * 1183f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1244f, Time.deltaTime * 558f);
	}

	// Token: 0x0600944A RID: 37962 RVA: 0x00422088 File Offset: 0x00420288
	private void Update()
	{
		if (!this.isFreeze)
		{
			float num = 1f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 0.3f : 0.4f);
			}
			float num2 = Input.GetAxis("Mouse X") * 40f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Mouse Y") * 40f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 0f, Time.deltaTime * 10f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 0f, Time.deltaTime * 10f);
	}

	// Token: 0x0600944B RID: 37963 RVA: 0x00422218 File Offset: 0x00420418
	private void AODJMLNLHNA()
	{
		if (!this.isFreeze)
		{
			float num = 1304f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1803f : 192f);
			}
			float num2 = Input.GetAxis("\n") * 1660f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("CrawlLocomotion") * 1735f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 913f, Time.deltaTime * 1667f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 991f, Time.deltaTime * 1505f);
	}

	// Token: 0x0600944C RID: 37964 RVA: 0x004223A8 File Offset: 0x004205A8
	public void DHEFGEAGHBA(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("ThisRenderer.bones[i].name is null") * 503f * this.sensitivityX;
		float num = Input.GetAxis("") * 858f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(206f, y, 601f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 855f, 556f);
		PMMEFNKFJIA.localRotation = this.ABNCIGIGGLE(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600944D RID: 37965 RVA: 0x0042243C File Offset: 0x0042063C
	private Quaternion HAADEMEEFLP(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 746f;
		float num = 1908f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1269f, 1809f);
		HPOGKAAEHKP.x = Mathf.Tan(1045f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600944E RID: 37966 RVA: 0x004224C0 File Offset: 0x004206C0
	private void LFJHDHPJOPE()
	{
		if (!this.isFreeze)
		{
			float num = 1372f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 514f : 569f);
			}
			float num2 = Input.GetAxis(" %") * 287f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("wgt_gr") * 75f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 608f, Time.deltaTime * 235f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1894f, Time.deltaTime * 143f);
	}

	// Token: 0x0600944F RID: 37967 RVA: 0x00422650 File Offset: 0x00420850
	private Quaternion HKNFNBGDNDC(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 499f;
		float num = 1569f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 710f, 1466f);
		HPOGKAAEHKP.x = Mathf.Tan(900f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009450 RID: 37968 RVA: 0x004226D4 File Offset: 0x004208D4
	public void DOONBOKFHBJ(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("OfficeSittingReadingLeanBack") * 456f * this.sensitivityX;
		float num = Input.GetAxis("<color='#a0a0a0'>") * 1089f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1071f, y, 1659f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1321f, 54f);
		PMMEFNKFJIA.localRotation = this.FEBLCJJFHBD(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009451 RID: 37969 RVA: 0x00422768 File Offset: 0x00420968
	private void INKGAFANFIB()
	{
		if (!this.isFreeze)
		{
			float num = 1506f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 877f : 1807f);
			}
			float num2 = Input.GetAxis(" not found") * 1548f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_Offsets") * 850f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1138f, Time.deltaTime * 1545f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 968f, Time.deltaTime * 101f);
	}

	// Token: 0x06009452 RID: 37970 RVA: 0x004228F8 File Offset: 0x00420AF8
	private Quaternion LBPLMEFMPHK(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 517f;
		float num = 923f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1755f, 384f);
		HPOGKAAEHKP.x = Mathf.Tan(235f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009453 RID: 37971 RVA: 0x0042297C File Offset: 0x00420B7C
	private void AIAMIFEPALP()
	{
		if (!this.isFreeze)
		{
			float num = 1619f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 741f : 1940f);
			}
			float num2 = Input.GetAxis("StaffAttack") * 1863f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Assets/Weapons/bootsBase.unity3d") * 1831f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 491f, Time.deltaTime * 526f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1688f, Time.deltaTime * 2f);
	}

	// Token: 0x06009454 RID: 37972 RVA: 0x00422B0C File Offset: 0x00420D0C
	private void GGGKKEAABKK()
	{
		if (!this.isFreeze)
		{
			float num = 136f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 44f : 546f);
			}
			float num2 = Input.GetAxis("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/") * 469f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_Offsets") * 427f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1870f, Time.deltaTime * 1778f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1806f, Time.deltaTime * 1487f);
	}

	// Token: 0x06009455 RID: 37973 RVA: 0x00422C9C File Offset: 0x00420E9C
	private Quaternion HCKJKFBHDHL(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 974f;
		float num = 221f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1219f, 605f);
		HPOGKAAEHKP.x = Mathf.Tan(1851f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009456 RID: 37974 RVA: 0x00422D20 File Offset: 0x00420F20
	private Quaternion MCIMDLIPLMN(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 603f;
		float num = 854f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 54f, 1677f);
		HPOGKAAEHKP.x = Mathf.Tan(1605f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009457 RID: 37975 RVA: 0x00422DA4 File Offset: 0x00420FA4
	public void LHEBJIMEBDF(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Horizontal") * 1119f * this.sensitivityX;
		float num = Input.GetAxis("IdleSpew") * 878f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(559f, y, 1373f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1891f, 1499f);
		PMMEFNKFJIA.localRotation = this.MPMEFFCPGLC(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009458 RID: 37976 RVA: 0x00422E38 File Offset: 0x00421038
	private void KLFPOILLKDF()
	{
		if (!this.isFreeze)
		{
			float num = 904f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1517f : 897f);
			}
			float num2 = Input.GetAxis("NextFrame") * 1460f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("paper.wav") * 1675f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1482f, Time.deltaTime * 1578f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 260f, Time.deltaTime * 187f);
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x00422FC8 File Offset: 0x004211C8
	private Quaternion MPMEFFCPGLC(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1111f;
		float num = 39f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 745f, 184f);
		HPOGKAAEHKP.x = Mathf.Tan(1490f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600945A RID: 37978 RVA: 0x0042304C File Offset: 0x0042124C
	private Quaternion CKLOBJKMCAC(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1245f;
		float num = 153f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 543f, 543f);
		HPOGKAAEHKP.x = Mathf.Tan(1050f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600945B RID: 37979 RVA: 0x004230D0 File Offset: 0x004212D0
	private void HFPPENPGGAI()
	{
		if (!this.isFreeze)
		{
			float num = 1156f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1351f : 547f);
			}
			float num2 = Input.GetAxis("WATER_VERTEX_DISPLACEMENT_ON") * 1442f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_FinalBlendParameters") * 1568f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1646f, Time.deltaTime * 169f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 913f, Time.deltaTime * 660f);
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x00423260 File Offset: 0x00421460
	private Quaternion DAKKOLHPMGP(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1322f;
		float num = 664f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1060f, 1610f);
		HPOGKAAEHKP.x = Mathf.Tan(1708f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x004232E4 File Offset: 0x004214E4
	private void LMMDHJJJNJO()
	{
		if (!this.isFreeze)
		{
			float num = 1790f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 789f : 623f);
			}
			float num2 = Input.GetAxis("_name") * 1879f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_EmissionColor") * 1419f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 83f, Time.deltaTime * 1722f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 95f, Time.deltaTime * 87f);
	}

	// Token: 0x0600945E RID: 37982 RVA: 0x00423474 File Offset: 0x00421674
	private void GDBBAMFMKII()
	{
		if (!this.isFreeze)
		{
			float num = 829f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 268f : 515f);
			}
			float num2 = Input.GetAxis("Character Not Active!") * 1527f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("IdleSadHips") * 862f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 112f, Time.deltaTime * 809f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 174f, Time.deltaTime * 264f);
	}

	// Token: 0x0600945F RID: 37983 RVA: 0x00423604 File Offset: 0x00421804
	private Quaternion BNFPMFGJLGB(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1781f;
		float num = 1797f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1989f, 1600f);
		HPOGKAAEHKP.x = Mathf.Tan(1589f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009460 RID: 37984 RVA: 0x00423688 File Offset: 0x00421888
	private void JLFBDOPFDDJ()
	{
		if (!this.isFreeze)
		{
			float num = 410f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 948f : 926f);
			}
			float num2 = Input.GetAxis("\n") * 658f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Flap_02.wav") * 258f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 947f, Time.deltaTime * 161f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 775f, Time.deltaTime * 962f);
	}

	// Token: 0x06009461 RID: 37985 RVA: 0x00423818 File Offset: 0x00421A18
	private Quaternion HCHNAGLLMHB(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1995f;
		float num = 1788f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 472f, 1002f);
		HPOGKAAEHKP.x = Mathf.Tan(102f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009462 RID: 37986 RVA: 0x0042389C File Offset: 0x00421A9C
	private void BOAJJAKEMLH()
	{
		if (!this.isFreeze)
		{
			float num = 1718f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 709f : 1888f);
			}
			float num2 = Input.GetAxis("WalkDehydrated") * 949f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("ObscuredPrefs vs PlayerPrefs, ") * 1158f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1751f, Time.deltaTime * 647f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 59f, Time.deltaTime * 870f);
	}

	// Token: 0x06009463 RID: 37987 RVA: 0x00423A2C File Offset: 0x00421C2C
	public void BCDJIHKMJDO(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("R") * 275f * this.sensitivityX;
		float num = Input.GetAxis("http://www.root-motion.com/finalikdox/html/page3.html") * 655f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1893f, y, 1056f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1345f, 1418f);
		PMMEFNKFJIA.localRotation = this.JJELDLNBKOG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009464 RID: 37988 RVA: 0x00423AC0 File Offset: 0x00421CC0
	private void JFGGBEGNAFP()
	{
		if (!this.isFreeze)
		{
			float num = 139f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1177f : 1132f);
			}
			float num2 = Input.GetAxis("vertices: {0}   triangles: {1}") * 1901f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("</color>") * 1237f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 291f, Time.deltaTime * 1861f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 115f, Time.deltaTime * 1907f);
	}

	// Token: 0x06009465 RID: 37989 RVA: 0x00423C50 File Offset: 0x00421E50
	private void HNMODJBBKBI()
	{
		if (!this.isFreeze)
		{
			float num = 293f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 16f : 1508f);
			}
			float num2 = Input.GetAxis("27") * 435f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("wpn_tank1") * 1618f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 346f, Time.deltaTime * 1473f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 5f, Time.deltaTime * 1523f);
	}

	// Token: 0x06009466 RID: 37990 RVA: 0x00423DE0 File Offset: 0x00421FE0
	private Quaternion MCAJFOCFHDI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1332f;
		float num = 272f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 90f, 944f);
		HPOGKAAEHKP.x = Mathf.Tan(1295f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009467 RID: 37991 RVA: 0x00423E64 File Offset: 0x00422064
	private void LMGBKHCHPHO()
	{
		if (!this.isFreeze)
		{
			float num = 1745f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1742f : 1919f);
			}
			float num2 = Input.GetAxis("BUMPED") * 80f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("CardPlayerIdle") * 180f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 185f, Time.deltaTime * 1366f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1582f, Time.deltaTime * 603f);
	}

	// Token: 0x06009468 RID: 37992 RVA: 0x00423FF4 File Offset: 0x004221F4
	public void IGFBPNIHMEB(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis(" ms") * 349f * this.sensitivityX;
		float num = Input.GetAxis("PaperTurn.wav") * 1929f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(890f, y, 1690f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 571f, 934f);
		PMMEFNKFJIA.localRotation = this.JJELDLNBKOG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009469 RID: 37993 RVA: 0x00424088 File Offset: 0x00422288
	private Quaternion JJELDLNBKOG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1767f;
		float num = 1098f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1708f, 1290f);
		HPOGKAAEHKP.x = Mathf.Tan(769f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600946A RID: 37994 RVA: 0x0042410C File Offset: 0x0042230C
	private void IANJLHIIGLN()
	{
		if (!this.isFreeze)
		{
			float num = 888f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 893f : 91f);
			}
			float num2 = Input.GetAxis("L") * 968f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("?") * 1352f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1837f, Time.deltaTime * 557f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 904f, Time.deltaTime * 585f);
	}

	// Token: 0x0600946B RID: 37995 RVA: 0x0042429C File Offset: 0x0042249C
	public void IGHBNGEOHLK(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("UphillWalk Hand Grab") * 1893f * this.sensitivityX;
		float num = Input.GetAxis("") * 1436f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(337f, y, 1971f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 901f, 1603f);
		PMMEFNKFJIA.localRotation = this.MCIMDLIPLMN(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600946C RID: 37996 RVA: 0x00424330 File Offset: 0x00422530
	private void DKOIOBMMAGN()
	{
		if (!this.isFreeze)
		{
			float num = 1409f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1797f : 276f);
			}
			float num2 = Input.GetAxis("RHandPunch") * 84f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("GiantGrabIdle2") * 1901f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 733f, Time.deltaTime * 1559f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 388f, Time.deltaTime * 249f);
	}

	// Token: 0x0600946D RID: 37997 RVA: 0x004244C0 File Offset: 0x004226C0
	private Quaternion FCBIENONFEP(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1241f;
		float num = 1747f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 164f, 383f);
		HPOGKAAEHKP.x = Mathf.Tan(1391f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x00424544 File Offset: 0x00422744
	private Quaternion BNBKONOJMIJ(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1558f;
		float num = 1578f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 457f, 672f);
		HPOGKAAEHKP.x = Mathf.Tan(1236f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600946F RID: 37999 RVA: 0x004245C8 File Offset: 0x004227C8
	private Quaternion PKEOEFKNBDB(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 117f;
		float num = 96f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 365f, 1885f);
		HPOGKAAEHKP.x = Mathf.Tan(1498f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009470 RID: 38000 RVA: 0x0042464C File Offset: 0x0042284C
	public void NHGPGGBOEAJ(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("<color='#405000'>") * 1888f * this.sensitivityX;
		float num = Input.GetAxis("MotorbikeLassoFwd") * 245f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1465f, y, 1577f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1250f, 560f);
		PMMEFNKFJIA.localRotation = this.CMFLGMNKJFM(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009471 RID: 38001 RVA: 0x004246E0 File Offset: 0x004228E0
	public void FLBIDPENOOG(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("file:///") * 905f * this.sensitivityX;
		float num = Input.GetAxis("Water") * 1953f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1962f, y, 677f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1247f, 1035f);
		PMMEFNKFJIA.localRotation = this.FPEGDFBLNKG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x00424774 File Offset: 0x00422974
	public void CILICHLLDME(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Obscured Cheating Detector") * 451f * this.sensitivityX;
		float num = Input.GetAxis("002000") * 283f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(908f, y, 181f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1359f, 1922f);
		PMMEFNKFJIA.localRotation = this.DCCMPJAMLFI(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x00424808 File Offset: 0x00422A08
	private Quaternion BPNBLLMKMBG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1423f;
		float num = 894f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 634f, 215f);
		HPOGKAAEHKP.x = Mathf.Tan(1802f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009474 RID: 38004 RVA: 0x0042488C File Offset: 0x00422A8C
	private void NFPFDOEENLA()
	{
		if (!this.isFreeze)
		{
			float num = 1635f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 702f : 1763f);
			}
			float num2 = Input.GetAxis("Hidden/Post FX/Builtin Debug Views") * 1047f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("TOD_CloudUV") * 1589f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1017f, Time.deltaTime * 340f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 348f, Time.deltaTime * 1311f);
	}

	// Token: 0x06009475 RID: 38005 RVA: 0x00424A1C File Offset: 0x00422C1C
	private void HABONMJNDAL()
	{
		if (!this.isFreeze)
		{
			float num = 92f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 753f : 1956f);
			}
			float num2 = Input.GetAxis("Auktree.xml") * 1939f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("GiantGrabIdle") * 1235f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 596f, Time.deltaTime * 147f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 733f, Time.deltaTime * 589f);
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x00424BAC File Offset: 0x00422DAC
	private void LIOCDEICIFD()
	{
		if (!this.isFreeze)
		{
			float num = 1557f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 272f : 134f);
			}
			float num2 = Input.GetAxis("|") * 1955f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis(" ") * 245f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1169f, Time.deltaTime * 1012f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1436f, Time.deltaTime * 381f);
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x00424D3C File Offset: 0x00422F3C
	private void EKCKBDKEAKO()
	{
		if (!this.isFreeze)
		{
			float num = 1116f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1198f : 855f);
			}
			float num2 = Input.GetAxis("MotorbikeWheely") * 1862f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Bow") * 1117f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 786f, Time.deltaTime * 505f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1312f, Time.deltaTime * 1322f);
	}

	// Token: 0x06009478 RID: 38008 RVA: 0x00424ECC File Offset: 0x004230CC
	private void HMLNMHOMMNO()
	{
		if (!this.isFreeze)
		{
			float num = 260f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 574f : 74f);
			}
			float num2 = Input.GetAxis("SoccerThrow") * 404f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("MotorbikeBackwardStand") * 582f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 364f, Time.deltaTime * 1756f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1873f, Time.deltaTime * 494f);
	}

	// Token: 0x06009479 RID: 38009 RVA: 0x0042505C File Offset: 0x0042325C
	public void CPGMAFCPLCN(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!") * 99f * this.sensitivityX;
		float num = Input.GetAxis("Отмена") * 991f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1228f, y, 245f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1190f, 1247f);
		PMMEFNKFJIA.localRotation = this.DAKKOLHPMGP(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600947A RID: 38010 RVA: 0x004250F0 File Offset: 0x004232F0
	private Quaternion FGCBMMAJNIF(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1858f;
		float num = 1750f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1087f, 1423f);
		HPOGKAAEHKP.x = Mathf.Tan(1557f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600947B RID: 38011 RVA: 0x00425174 File Offset: 0x00423374
	public void BBJCFNHFOPL(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("\\n") * 1431f * this.sensitivityX;
		float num = Input.GetAxis("Player") * 407f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1341f, y, 1152f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1578f, 1477f);
		PMMEFNKFJIA.localRotation = this.FEBLCJJFHBD(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600947C RID: 38012 RVA: 0x00425208 File Offset: 0x00423408
	public void NABECHFOCNE(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Moustaches") * 1455f * this.sensitivityX;
		float num = Input.GetAxis("_Refraction") * 1425f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1770f, y, 94f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1189f, 650f);
		PMMEFNKFJIA.localRotation = this.LIHPMJDAPIK(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600947D RID: 38013 RVA: 0x0042529C File Offset: 0x0042349C
	private Quaternion ABNCIGIGGLE(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1854f;
		float num = 722f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1102f, 1255f);
		HPOGKAAEHKP.x = Mathf.Tan(1176f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600947E RID: 38014 RVA: 0x00425320 File Offset: 0x00423520
	public void GDJEMIFDFKC(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("SneakRight") * 1249f * this.sensitivityX;
		float num = Input.GetAxis("H:mm:ss") * 1052f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(720f, y, 1025f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 371f, 1915f);
		PMMEFNKFJIA.localRotation = this.EGGGOHJFJNP(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600947F RID: 38015 RVA: 0x004253B4 File Offset: 0x004235B4
	public void NECPAIDJJCB(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("fshop_ks1") * 732f * this.sensitivityX;
		float num = Input.GetAxis("#000000") * 544f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1714f, y, 1639f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1988f, 914f);
		PMMEFNKFJIA.localRotation = this.JLOEBOGDANF(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009480 RID: 38016 RVA: 0x00425448 File Offset: 0x00423648
	public void HNHMIJACMAO(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("</b>\n : ") * 243f * this.sensitivityX;
		float num = Input.GetAxis("new wpn lot ") * 858f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(997f, y, 944f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 975f, 527f);
		PMMEFNKFJIA.localRotation = this.IIGPGCHEKJO(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009481 RID: 38017 RVA: 0x004254DC File Offset: 0x004236DC
	private void LDDIGEMBDNF()
	{
		if (!this.isFreeze)
		{
			float num = 1914f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 231f : 1915f);
			}
			float num2 = Input.GetAxis("PersonManFisher") * 1572f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("/") * 1222f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1317f, Time.deltaTime * 804f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 787f, Time.deltaTime * 1446f);
	}

	// Token: 0x06009482 RID: 38018 RVA: 0x0042566C File Offset: 0x0042386C
	private Quaternion OPCPEICBMMN(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1562f;
		float num = 1751f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 271f, 1569f);
		HPOGKAAEHKP.x = Mathf.Tan(1481f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009483 RID: 38019 RVA: 0x004256F0 File Offset: 0x004238F0
	private void CJHBCHBOLBI()
	{
		if (!this.isFreeze)
		{
			float num = 1460f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 417f : 634f);
			}
			float num2 = Input.GetAxis("{0} принял задание '{1}'") * 1953f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("JumpCurve") * 854f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1101f, Time.deltaTime * 132f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1735f, Time.deltaTime * 1614f);
	}

	// Token: 0x06009484 RID: 38020 RVA: 0x00425880 File Offset: 0x00423A80
	private void GHOBHBMFKHN()
	{
		if (!this.isFreeze)
		{
			float num = 1910f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1564f : 570f);
			}
			float num2 = Input.GetAxis("ObscuredByte vs byte, ") * 1849f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("cntx_close") * 793f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1475f, Time.deltaTime * 820f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 71f, Time.deltaTime * 782f);
	}

	// Token: 0x06009485 RID: 38021 RVA: 0x00425A10 File Offset: 0x00423C10
	private Quaternion LIHPMJDAPIK(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1326f;
		float num = 1136f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1388f, 1281f);
		HPOGKAAEHKP.x = Mathf.Tan(1843f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009486 RID: 38022 RVA: 0x00425A94 File Offset: 0x00423C94
	private void OPDCJCFMIPE()
	{
		if (!this.isFreeze)
		{
			float num = 1554f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 74f : 1247f);
			}
			float num2 = Input.GetAxis("WateringCanWatering") * 1853f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("invn_ver3") * 1191f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1914f, Time.deltaTime * 233f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 345f, Time.deltaTime * 1708f);
	}

	// Token: 0x06009487 RID: 38023 RVA: 0x00425C24 File Offset: 0x00423E24
	public void MENBKMFICGG(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("ff2000") * 907f * this.sensitivityX;
		float num = Input.GetAxis("colorB") * 1479f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1297f, y, 1882f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 544f, 1870f);
		PMMEFNKFJIA.localRotation = this.MPMEFFCPGLC(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009488 RID: 38024 RVA: 0x00425CB8 File Offset: 0x00423EB8
	public void HFHKLDEMGFP(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("******* Actor fish destroy") * 1805f * this.sensitivityX;
		float num = Input.GetAxis("R to reset fog.") * 60f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1085f, y, 980f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 758f, 1316f);
		PMMEFNKFJIA.localRotation = this.BEANBPBOGPI(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009489 RID: 38025 RVA: 0x00425D4C File Offset: 0x00423F4C
	public void JJBPPBMEKJF(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("2") * 1012f * this.sensitivityX;
		float num = Input.GetAxis("quests/qdynamic/qd") * 754f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1729f, y, 1609f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 660f, 316f);
		PMMEFNKFJIA.localRotation = this.OPCPEICBMMN(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600948A RID: 38026 RVA: 0x00425DE0 File Offset: 0x00423FE0
	private void BAIKCLKJPAA()
	{
		if (!this.isFreeze)
		{
			float num = 515f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 632f : 1804f);
			}
			float num2 = Input.GetAxis("Idle Strafe Left") * 411f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_OutputGamma") * 677f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 471f, Time.deltaTime * 1453f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1687f, Time.deltaTime * 1498f);
	}

	// Token: 0x0600948B RID: 38027 RVA: 0x00425F70 File Offset: 0x00424170
	private Quaternion BOPBFBLOEJN(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 580f;
		float num = 1318f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 822f, 940f);
		HPOGKAAEHKP.x = Mathf.Tan(1067f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600948C RID: 38028 RVA: 0x00425FF4 File Offset: 0x004241F4
	private void EHDFKHHOHAD()
	{
		if (!this.isFreeze)
		{
			float num = 1405f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1293f : 1232f);
			}
			float num2 = Input.GetAxis("Textures/Perks/") * 1306f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Reset") * 1133f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1524f, Time.deltaTime * 1299f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 989f, Time.deltaTime * 323f);
	}

	// Token: 0x0600948D RID: 38029 RVA: 0x00426184 File Offset: 0x00424384
	private void PGIHAIPCJLL()
	{
		if (!this.isFreeze)
		{
			float num = 832f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1995f : 833f);
			}
			float num2 = Input.GetAxis("Attached object") * 649f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("auc_reshdr") * 1240f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1840f, Time.deltaTime * 19f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1582f, Time.deltaTime * 1139f);
	}

	// Token: 0x0600948E RID: 38030 RVA: 0x00426314 File Offset: 0x00424514
	public void KFPOBJDDEFP(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Wizard1HandThrow") * 711f * this.sensitivityX;
		float num = Input.GetAxis("cht_msg25") * 1552f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1458f, y, 730f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 699f, 898f);
		PMMEFNKFJIA.localRotation = this.EGGGOHJFJNP(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x0600948F RID: 38031 RVA: 0x004263A8 File Offset: 0x004245A8
	private Quaternion MNGLCOFPLBL(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 57f;
		float num = 1312f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1991f, 168f);
		HPOGKAAEHKP.x = Mathf.Tan(1905f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009490 RID: 38032 RVA: 0x0042642C File Offset: 0x0042462C
	private void CLCJPEDHFJA()
	{
		if (!this.isFreeze)
		{
			float num = 1056f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 893f : 1297f);
			}
			float num2 = Input.GetAxis("_DelItem.wav") * 1329f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("IKMappingSpine is missing the right thigh bone.") * 228f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 875f, Time.deltaTime * 411f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1047f, Time.deltaTime * 1106f);
	}

	// Token: 0x06009491 RID: 38033 RVA: 0x004265BC File Offset: 0x004247BC
	private Quaternion CMOCNAAPEBM(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1328f;
		float num = 18f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 433f, 634f);
		HPOGKAAEHKP.x = Mathf.Tan(371f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009492 RID: 38034 RVA: 0x00426640 File Offset: 0x00424840
	private Quaternion BCJDGGLJPAI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1574f;
		float num = 965f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 164f, 1759f);
		HPOGKAAEHKP.x = Mathf.Tan(790f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009493 RID: 38035 RVA: 0x004266C4 File Offset: 0x004248C4
	private Quaternion GCLCGCOKPOI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 936f;
		float num = 667f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 859f, 993f);
		HPOGKAAEHKP.x = Mathf.Tan(497f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x06009494 RID: 38036 RVA: 0x00426748 File Offset: 0x00424948
	public void HIMABKHLIBO(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("_FogOfWarSize") * 685f * this.sensitivityX;
		float num = Input.GetAxis("IceHockeyGoalieSave2") * 1289f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(258f, y, 1558f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 468f, 881f);
		PMMEFNKFJIA.localRotation = this.MPMEFFCPGLC(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009495 RID: 38037 RVA: 0x004267DC File Offset: 0x004249DC
	public void HIJICJDMLNK(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("wpn_onlym") * 1844f * this.sensitivityX;
		float num = Input.GetAxis("") * 1478f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(501f, y, 683f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 771f, 1379f);
		PMMEFNKFJIA.localRotation = this.MNGLCOFPLBL(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009496 RID: 38038 RVA: 0x00426870 File Offset: 0x00424A70
	public void LLCBAMPHLHM(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("") * 1733f * this.sensitivityX;
		float num = Input.GetAxis("Mouse Y") * 1876f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1406f, y, 543f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1347f, 251f);
		PMMEFNKFJIA.localRotation = this.AHJPDIBMMHB(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009497 RID: 38039 RVA: 0x00426904 File Offset: 0x00424B04
	public void MELFFFMCKDJ(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("OfficeSitting") * 1066f * this.sensitivityX;
		float num = Input.GetAxis("val=") * 1150f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(205f, y, 1594f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1119f, 1484f);
		PMMEFNKFJIA.localRotation = this.FPEGDFBLNKG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x06009498 RID: 38040 RVA: 0x00426998 File Offset: 0x00424B98
	private void OHKHOAKCENL()
	{
		if (!this.isFreeze)
		{
			float num = 558f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 533f : 1080f);
			}
			float num2 = Input.GetAxis("") * 1591f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Middle click") * 1208f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1329f, Time.deltaTime * 1361f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1910f, Time.deltaTime * 542f);
	}

	// Token: 0x06009499 RID: 38041 RVA: 0x00426B28 File Offset: 0x00424D28
	private void OKMAHGAAMHA()
	{
		if (!this.isFreeze)
		{
			float num = 256f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 197f : 1368f);
			}
			float num2 = Input.GetAxis("") * 1528f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("") * 1263f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1000f, Time.deltaTime * 787f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1141f, Time.deltaTime * 137f);
	}

	// Token: 0x0600949A RID: 38042 RVA: 0x00426CB8 File Offset: 0x00424EB8
	private void DFFOEGHGPGP()
	{
		if (!this.isFreeze)
		{
			float num = 665f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1484f : 49f);
			}
			float num2 = Input.GetAxis("private") * 652f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Worker Hammer 2") * 874f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 662f, Time.deltaTime * 29f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 426f, Time.deltaTime * 878f);
	}

	// Token: 0x0600949B RID: 38043 RVA: 0x00426E48 File Offset: 0x00425048
	private Quaternion NFLLLOKFBGG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1f;
		float num = 114.59156f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, -90f, 90f);
		HPOGKAAEHKP.x = Mathf.Tan(0.008726646f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600949C RID: 38044 RVA: 0x00426ECC File Offset: 0x004250CC
	private Quaternion DCCMPJAMLFI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 662f;
		float num = 516f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1722f, 691f);
		HPOGKAAEHKP.x = Mathf.Tan(1500f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600949D RID: 38045 RVA: 0x00426F50 File Offset: 0x00425150
	private Quaternion EKGDCCOOONH(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 683f;
		float num = 1274f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1592f, 824f);
		HPOGKAAEHKP.x = Mathf.Tan(1833f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x0600949E RID: 38046 RVA: 0x00426FD4 File Offset: 0x004251D4
	private void CPJJHOKJEGJ()
	{
		if (!this.isFreeze)
		{
			float num = 71f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1585f : 1871f);
			}
			float num2 = Input.GetAxis("Climb Left") * 451f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("wpn_rec3") * 1402f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1811f, Time.deltaTime * 1631f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 230f, Time.deltaTime * 1879f);
	}

	// Token: 0x0600949F RID: 38047 RVA: 0x00427164 File Offset: 0x00425364
	private void OLGDMBDGLAN()
	{
		if (!this.isFreeze)
		{
			float num = 1072f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 754f : 1569f);
			}
			float num2 = Input.GetAxis("Sitting 1 Leg Straight") * 382f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("CardPlayerIdle") * 333f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1475f, Time.deltaTime * 230f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 884f, Time.deltaTime * 1074f);
	}

	// Token: 0x060094A0 RID: 38048 RVA: 0x004272F4 File Offset: 0x004254F4
	private void JBFJPNKLLKI()
	{
		if (!this.isFreeze)
		{
			float num = 1204f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1189f : 416f);
			}
			float num2 = Input.GetAxis("SoccerWalk") * 962f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта") * 1358f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1896f, Time.deltaTime * 895f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 91f, Time.deltaTime * 1332f);
	}

	// Token: 0x060094A1 RID: 38049 RVA: 0x00427484 File Offset: 0x00425684
	public void IKECFPNKIJJ(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Crouching") * 1637f * this.sensitivityX;
		float num = Input.GetAxis("SwimFreestyle") * 332f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1712f, y, 1337f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1640f, 143f);
		PMMEFNKFJIA.localRotation = this.LIHPMJDAPIK(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094A2 RID: 38050 RVA: 0x00427518 File Offset: 0x00425718
	private Quaternion MNCEMEAIGAH(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1620f;
		float num = 1441f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 138f, 26f);
		HPOGKAAEHKP.x = Mathf.Tan(148f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094A3 RID: 38051 RVA: 0x0042759C File Offset: 0x0042579C
	public void EBDDHJAGIGD(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("gi_uinf_11") * 869f * this.sensitivityX;
		float num = Input.GetAxis("Hidden/Subpixel Morphological Anti-aliasing") * 1626f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(539f, y, 194f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 92f, 415f);
		PMMEFNKFJIA.localRotation = this.HCHNAGLLMHB(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094A4 RID: 38052 RVA: 0x00427630 File Offset: 0x00425830
	private void OIBIGDFPHGO()
	{
		if (!this.isFreeze)
		{
			float num = 257f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1554f : 232f);
			}
			float num2 = Input.GetAxis("RunDive") * 1333f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_MainTex") * 1434f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 797f, Time.deltaTime * 758f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 937f, Time.deltaTime * 1819f);
	}

	// Token: 0x060094A5 RID: 38053 RVA: 0x004277C0 File Offset: 0x004259C0
	private Quaternion AKAEKOPHCNK(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 161f;
		float num = 420f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1362f, 473f);
		HPOGKAAEHKP.x = Mathf.Tan(1818f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094A6 RID: 38054 RVA: 0x00427844 File Offset: 0x00425A44
	public void NIANKCNECAH(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("") * 1241f * this.sensitivityX;
		float num = Input.GetAxis("SwimFreestyle") * 904f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1543f, y, 1793f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1029f, 922f);
		PMMEFNKFJIA.localRotation = this.BEANBPBOGPI(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094A7 RID: 38055 RVA: 0x004278D8 File Offset: 0x00425AD8
	private Quaternion BEANBPBOGPI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 246f;
		float num = 1192f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1062f, 1440f);
		HPOGKAAEHKP.x = Mathf.Tan(886f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094A8 RID: 38056 RVA: 0x0042795C File Offset: 0x00425B5C
	private void KCBECEFNGMO()
	{
		if (!this.isFreeze)
		{
			float num = 1398f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1370f : 1319f);
			}
			float num2 = Input.GetAxis("gi_cachhe") * 1280f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("_Intensity") * 1069f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 478f, Time.deltaTime * 1877f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1434f, Time.deltaTime * 1336f);
	}

	// Token: 0x060094A9 RID: 38057 RVA: 0x00427AEC File Offset: 0x00425CEC
	public void EJMGJBBNDME(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("===== ObscuredIntTest =====\n") * 705f * this.sensitivityX;
		float num = Input.GetAxis("_DayToNight") * 1288f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1774f, y, 1165f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1531f, 553f);
		PMMEFNKFJIA.localRotation = this.BNBKONOJMIJ(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094AA RID: 38058 RVA: 0x00427B80 File Offset: 0x00425D80
	public void BBKDPFGLFMJ(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Object To Instantiate") * 1954f * this.sensitivityX;
		float num = Input.GetAxis("") * 118f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1750f, y, 1133f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1651f, 744f);
		PMMEFNKFJIA.localRotation = this.PKEOEFKNBDB(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094AB RID: 38059 RVA: 0x00427C14 File Offset: 0x00425E14
	private void LAGGDCBJLNK()
	{
		if (!this.isFreeze)
		{
			float num = 20f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1061f : 231f);
			}
			float num2 = Input.GetAxis("_FrustumCornersWS") * 1428f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("ScubaSwim") * 1479f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1482f, Time.deltaTime * 1444f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1738f, Time.deltaTime * 991f);
	}

	// Token: 0x060094AC RID: 38060 RVA: 0x00427DA4 File Offset: 0x00425FA4
	private void AJCHHNKFOHO()
	{
		if (!this.isFreeze)
		{
			float num = 17f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 458f : 200f);
			}
			float num2 = Input.GetAxis("\n<color='#{0}'>{1}</color> ") * 1219f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("***My Lots event ") * 68f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1170f, Time.deltaTime * 1323f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 839f, Time.deltaTime * 1652f);
	}

	// Token: 0x060094AD RID: 38061 RVA: 0x00427F34 File Offset: 0x00426134
	private Quaternion IIGPGCHEKJO(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 26f;
		float num = 1694f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1569f, 929f);
		HPOGKAAEHKP.x = Mathf.Tan(72f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094AE RID: 38062 RVA: 0x00427FB8 File Offset: 0x004261B8
	public void NMDEFFKFGOD(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("") * 1746f * this.sensitivityX;
		float num = Input.GetAxis("ClimbIdle") * 1425f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1948f, y, 1662f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 635f, 1616f);
		PMMEFNKFJIA.localRotation = this.FCBIENONFEP(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094AF RID: 38063 RVA: 0x0042804C File Offset: 0x0042624C
	private Quaternion CMFLGMNKJFM(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 754f;
		float num = 1871f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1758f, 14f);
		HPOGKAAEHKP.x = Mathf.Tan(1144f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094B0 RID: 38064 RVA: 0x004280D0 File Offset: 0x004262D0
	private void EDEODHDFANE()
	{
		if (!this.isFreeze)
		{
			float num = 1610f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 377f : 119f);
			}
			float num2 = Input.GetAxis("SoccerSprint") * 782f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("repair.ogg") * 1258f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 673f, Time.deltaTime * 703f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1567f, Time.deltaTime * 1277f);
	}

	// Token: 0x060094B1 RID: 38065 RVA: 0x00428260 File Offset: 0x00426460
	private Quaternion MOGMDJALIMG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1037f;
		float num = 351f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 128f, 298f);
		HPOGKAAEHKP.x = Mathf.Tan(205f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094B2 RID: 38066 RVA: 0x004282E4 File Offset: 0x004264E4
	private Quaternion LAFLALCJFDF(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1897f;
		float num = 995f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 778f, 1461f);
		HPOGKAAEHKP.x = Mathf.Tan(257f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094B3 RID: 38067 RVA: 0x00428368 File Offset: 0x00426568
	private Quaternion AHJPDIBMMHB(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1359f;
		float num = 729f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 755f, 1641f);
		HPOGKAAEHKP.x = Mathf.Tan(1354f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094B4 RID: 38068 RVA: 0x004283EC File Offset: 0x004265EC
	private void BNKJNBIDPME()
	{
		if (!this.isFreeze)
		{
			float num = 1119f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1004f : 510f);
			}
			float num2 = Input.GetAxis("") * 786f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("WalkDehydrated") * 1648f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 444f, Time.deltaTime * 1550f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 821f, Time.deltaTime * 558f);
	}

	// Token: 0x060094B5 RID: 38069 RVA: 0x0042857C File Offset: 0x0042677C
	public void HILODEBFCBN(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("<color='{0}'>{1}</color>") * 814f * this.sensitivityX;
		float num = Input.GetAxis("SixStep") * 233f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(602f, y, 574f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1932f, 4f);
		PMMEFNKFJIA.localRotation = this.BNFPMFGJLGB(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094B6 RID: 38070 RVA: 0x00428610 File Offset: 0x00426810
	public void DAOLNFHFDFO(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis(" ") * 1478f * this.sensitivityX;
		float num = Input.GetAxis("_n") * 856f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1133f, y, 1037f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 570f, 465f);
		PMMEFNKFJIA.localRotation = this.AKAEKOPHCNK(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094B7 RID: 38071 RVA: 0x004286A4 File Offset: 0x004268A4
	private void EDANNBFJHIK()
	{
		if (!this.isFreeze)
		{
			float num = 1838f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1650f : 1725f);
			}
			float num2 = Input.GetAxis("isHarvest") * 1326f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("-") * 240f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1667f, Time.deltaTime * 131f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 985f, Time.deltaTime * 456f);
	}

	// Token: 0x060094B8 RID: 38072 RVA: 0x00428834 File Offset: 0x00426A34
	private Quaternion NKPJNKEANOE(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1330f;
		float num = 46f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 884f, 321f);
		HPOGKAAEHKP.x = Mathf.Tan(609f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094B9 RID: 38073 RVA: 0x004288B8 File Offset: 0x00426AB8
	private Quaternion LJGLNMOLGAH(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 559f;
		float num = 925f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1524f, 752f);
		HPOGKAAEHKP.x = Mathf.Tan(1994f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094BA RID: 38074 RVA: 0x0042893C File Offset: 0x00426B3C
	private void IOGAKGCADBL()
	{
		if (!this.isFreeze)
		{
			float num = 1377f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 229f : 1122f);
			}
			float num2 = Input.GetAxis("Water") * 903f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Keeper Ready") * 1244f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1649f, Time.deltaTime * 79f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 834f, Time.deltaTime * 1381f);
	}

	// Token: 0x060094BB RID: 38075 RVA: 0x00428ACC File Offset: 0x00426CCC
	public void FJNLEBJABHA(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("GestureChestPumpSalute") * 596f * this.sensitivityX;
		float num = Input.GetAxis("auk_pstinf") * 27f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(429f, y, 2f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1721f, 1044f);
		PMMEFNKFJIA.localRotation = this.HCHNAGLLMHB(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094BC RID: 38076 RVA: 0x00428B60 File Offset: 0x00426D60
	private Quaternion LIACLMNNNLM(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 77f;
		float num = 306f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1325f, 803f);
		HPOGKAAEHKP.x = Mathf.Tan(1583f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094BD RID: 38077 RVA: 0x00428BE4 File Offset: 0x00426DE4
	private void JIFOELPAEHG()
	{
		if (!this.isFreeze)
		{
			float num = 1725f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 477f : 120f);
			}
			float num2 = Input.GetAxis("SteamPay error via request") * 961f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("Horizontal") * 94f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1891f, Time.deltaTime * 1356f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 726f, Time.deltaTime * 314f);
	}

	// Token: 0x060094BE RID: 38078 RVA: 0x00428D74 File Offset: 0x00426F74
	private void KEBDEJIAODF()
	{
		if (!this.isFreeze)
		{
			float num = 1553f;
			if (Fisherman.getI != null && Fisherman.getI.CIHILMCEJND)
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1109f : 796f);
			}
			float num2 = Input.GetAxis("IceHockeyShotLeft") * 1658f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis(" x") * 1318f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1730f, Time.deltaTime * 335f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1683f, Time.deltaTime * 626f);
	}

	// Token: 0x060094BF RID: 38079 RVA: 0x00428F04 File Offset: 0x00427104
	private Quaternion JLOEBOGDANF(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 248f;
		float num = 299f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 299f, 773f);
		HPOGKAAEHKP.x = Mathf.Tan(874f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094C0 RID: 38080 RVA: 0x00428F88 File Offset: 0x00427188
	private Quaternion FEBLCJJFHBD(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 879f;
		float num = 977f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1151f, 755f);
		HPOGKAAEHKP.x = Mathf.Tan(1270f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094C2 RID: 38082 RVA: 0x0042906C File Offset: 0x0042726C
	public void OAFPAKLALCD(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis(" /") * 1403f * this.sensitivityX;
		float num = Input.GetAxis("#ffffff") * 465f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(138f, y, 1165f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 1043f, 100f);
		PMMEFNKFJIA.localRotation = this.BNBKONOJMIJ(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094C3 RID: 38083 RVA: 0x00429100 File Offset: 0x00427300
	private void PAKOHKKBKHD()
	{
		if (!this.isFreeze)
		{
			float num = 1988f;
			if (Fisherman.getI != null && Fisherman.getI.KNMMOLKNLNL())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 660f : 97f);
			}
			float num2 = Input.GetAxis("_LerpRgbTex") * 0f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("foot") * 1041f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1193f, Time.deltaTime * 956f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 1970f, Time.deltaTime * 754f);
	}

	// Token: 0x060094C4 RID: 38084 RVA: 0x00429290 File Offset: 0x00427490
	public void LookRotation(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("Mouse X") * 0.9f * this.sensitivityX;
		float num = Input.GetAxis("Mouse Y") * 0.9f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(0f, y, 0f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 0f, 0f);
		PMMEFNKFJIA.localRotation = this.NFLLLOKFBGG(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x00429324 File Offset: 0x00427524
	private void HCDJABMBDFF()
	{
		if (!this.isFreeze)
		{
			float num = 89f;
			if (Fisherman.getI != null && Fisherman.getI.GECLKEEGJGA())
			{
				num = (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK ? 1575f : 41f);
			}
			float num2 = Input.GetAxis(" ") * 1129f * this.sensitivityX * num * Time.deltaTime;
			float num3 = -Input.GetAxis("C ") * 1716f * this.sensitivityY * num * Time.deltaTime;
			this.ILLJBMIFOBK += num2;
			this.DBJPPLMAIIK += num3;
			Quaternion rotation = base.transform.rotation;
			float num4 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			base.transform.Rotate(Vector3.right, this.DBJPPLMAIIK);
			float num5 = Vector3.Angle(Fisherman.getI.transform.forward, base.transform.forward);
			if (num5 > this.maxYAngle && num4 < num5)
			{
				base.transform.rotation = rotation;
			}
			base.transform.Rotate(base.transform.InverseTransformDirection(Vector3.up), this.ILLJBMIFOBK);
		}
		this.ILLJBMIFOBK = Mathf.Lerp(this.ILLJBMIFOBK, 1050f, Time.deltaTime * 1472f);
		this.DBJPPLMAIIK = Mathf.Lerp(this.DBJPPLMAIIK, 124f, Time.deltaTime * 1127f);
	}

	// Token: 0x060094C6 RID: 38086 RVA: 0x004294B4 File Offset: 0x004276B4
	private Quaternion NMCPHIHJLCO(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 125f;
		float num = 315f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 995f, 1922f);
		HPOGKAAEHKP.x = Mathf.Tan(1468f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x00429538 File Offset: 0x00427738
	private Quaternion MNOPMDKOHCO(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 806f;
		float num = 66f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 973f, 1044f);
		HPOGKAAEHKP.x = Mathf.Tan(914f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094C8 RID: 38088 RVA: 0x004295BC File Offset: 0x004277BC
	private Quaternion NOMCIKAHEAI(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 174f;
		float num = 1576f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 1545f, 765f);
		HPOGKAAEHKP.x = Mathf.Tan(501f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094C9 RID: 38089 RVA: 0x00429640 File Offset: 0x00427840
	public void FBAAGDOLLEK(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("FA") * 173f * this.sensitivityX;
		float num = Input.GetAxis("") * 1600f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(1576f, y, 362f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 700f, 1881f);
		PMMEFNKFJIA.localRotation = this.CMFLGMNKJFM(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094CA RID: 38090 RVA: 0x004296D4 File Offset: 0x004278D4
	public void JBJFCBBNKKG(Transform IFIIFDKAKDJ, Transform PMMEFNKFJIA)
	{
		float y = Input.GetAxis("_TraceBehindObjects") * 626f * this.sensitivityX;
		float num = Input.GetAxis("' that does not excist in the Node Chain.") * 545f * this.sensitivityY;
		IFIIFDKAKDJ.localRotation *= Quaternion.Euler(738f, y, 1084f);
		PMMEFNKFJIA.localRotation *= Quaternion.Euler(-num, 878f, 41f);
		PMMEFNKFJIA.localRotation = this.NOMCIKAHEAI(PMMEFNKFJIA.localRotation);
	}

	// Token: 0x060094CB RID: 38091 RVA: 0x00429768 File Offset: 0x00427968
	private Quaternion EGGGOHJFJNP(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 813f;
		float num = 42f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 342f, 752f);
		HPOGKAAEHKP.x = Mathf.Tan(1123f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094CC RID: 38092 RVA: 0x004297EC File Offset: 0x004279EC
	private Quaternion FPEGDFBLNKG(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 44f;
		float num = 1612f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 599f, 1563f);
		HPOGKAAEHKP.x = Mathf.Tan(223f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x060094CD RID: 38093 RVA: 0x00429870 File Offset: 0x00427A70
	private Quaternion MJKKLJHNEHE(Quaternion HPOGKAAEHKP)
	{
		HPOGKAAEHKP.x /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.y /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.z /= HPOGKAAEHKP.w;
		HPOGKAAEHKP.w = 1683f;
		float num = 242f * Mathf.Atan(HPOGKAAEHKP.x);
		num = Mathf.Clamp(num, 990f, 1954f);
		HPOGKAAEHKP.x = Mathf.Tan(1008f * num);
		return HPOGKAAEHKP;
	}

	// Token: 0x04001390 RID: 5008
	public float maxYAngle = 70f;

	// Token: 0x04001391 RID: 5009
	public float sensitivityX = 15f;

	// Token: 0x04001392 RID: 5010
	public float sensitivityY = 15f;

	// Token: 0x04001393 RID: 5011
	public float minimumX = -360f;

	// Token: 0x04001394 RID: 5012
	public float maximumX = 360f;

	// Token: 0x04001395 RID: 5013
	public float minimumY = -60f;

	// Token: 0x04001396 RID: 5014
	public float maximumY = 60f;

	// Token: 0x04001397 RID: 5015
	private float AEJEJGFFFCD;

	// Token: 0x04001398 RID: 5016
	private float PCBBHADFEFH;

	// Token: 0x04001399 RID: 5017
	private float ECKELLKNKLP;

	// Token: 0x0400139A RID: 5018
	public bool isFreeze;

	// Token: 0x0400139B RID: 5019
	public Quaternion originalRotation;

	// Token: 0x0400139C RID: 5020
	private float ILLJBMIFOBK;

	// Token: 0x0400139D RID: 5021
	private float DBJPPLMAIIK;
}
