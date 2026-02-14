using System;
using UnityEngine;

// Token: 0x02000254 RID: 596
public class WpnUICell : MonoBehaviour
{
	// Token: 0x060088E8 RID: 35048 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void FDKGOFHFOLH()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088E9 RID: 35049 RVA: 0x003F81CC File Offset: 0x003F63CC
	private void NOBANMDHKNK()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 160f, 1027f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 0));
		}
	}

	// Token: 0x060088EA RID: 35050 RVA: 0x003F8300 File Offset: 0x003F6500
	public void MFEHNGOEAFO(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = true;
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("t_top", "Channel Cast Omni").AMNOOPCPOKA();
				if (num <= 1195f)
				{
					num = 1030f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(num, 0, "DISTANCE_CUTOFF_ON" + GameInterface.getI.useWeapon.MBBMKNBDPDA(false) + "gamma", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("{0:0} мин{1}, ", 1238f);
			}
		}
	}

	// Token: 0x060088EB RID: 35051 RVA: 0x003F83D4 File Offset: 0x003F65D4
	public void GJDHEPJLIEM(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("PaperTurn.wav", "").PPAAACJOOGA;
				if (num <= 98f)
				{
					num = 455f;
				}
				JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(num, 1, "_OutputGamma" + GameInterface.getI.useWeapon.ONNIKIAJHBO(true) + "_SampleCount", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Weapon Strafe Run Left", 1781f);
			}
		}
	}

	// Token: 0x060088EC RID: 35052 RVA: 0x003F84A8 File Offset: 0x003F66A8
	public void DKPGDIKNFEP(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = false;
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("reel_type0", "_Intensity").GIBGJFHMGIL();
				if (num <= 1687f)
				{
					num = 1362f;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(num, 0, "ClimbIdle" + GameInterface.getI.useWeapon.ONNIKIAJHBO(false) + "inv_wpers", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("LocationGui.getI.backLockImage.rectTransform is null", 157f);
			}
		}
	}

	// Token: 0x060088ED RID: 35053 RVA: 0x003F857C File Offset: 0x003F677C
	private void CLCJPEDHFJA()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.MNJNNDHCDGG().CHPPAAAAJFC(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088EE RID: 35054 RVA: 0x003F867C File Offset: 0x003F687C
	private void ENCHIIJEJDL()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1695f, 1719f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 1));
		}
	}

	// Token: 0x060088EF RID: 35055 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void OLDFHDFAKDN()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088F0 RID: 35056 RVA: 0x003F87B0 File Offset: 0x003F69B0
	public void DNJNBKJIDLM(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = false;
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("RollerBladeTurnLeft", "RunDive").OEIAFJHKMIJ();
				if (num <= 168f)
				{
					num = 1906f;
				}
				JDCEFOFMGHB.MNJNNDHCDGG().PBJGEIMFNNO(num, 1, "_Curve" + GameInterface.getI.useWeapon.MBBMKNBDPDA(true) + " ms", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("bases/base_{0}", 877f);
			}
		}
	}

	// Token: 0x060088F1 RID: 35057 RVA: 0x003F8883 File Offset: 0x003F6A83
	private void OILPEJCKAKJ()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMMOKECDLEJ().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x060088F2 RID: 35058 RVA: 0x003F88AC File Offset: 0x003F6AAC
	private void EGAEDOHFAJE()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.MNJNNDHCDGG().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088F3 RID: 35059 RVA: 0x003F89AC File Offset: 0x003F6BAC
	private void DHFLFGBENBF()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.CBNDILDBGMP);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IOALEBMCEGM().FFGCPMNCOPP(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.HNMHOJDNHMJ(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x060088F4 RID: 35060 RVA: 0x003F8B00 File Offset: 0x003F6D00
	private void LIOCDEICIFD()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088F5 RID: 35061 RVA: 0x003F8C00 File Offset: 0x003F6E00
	public void NONLFLAIGCL(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("startA", "fshop_hd2").PPAAACJOOGA;
				if (num <= 301f)
				{
					num = 1238f;
				}
				JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(num, 1, "Invalid ObscuredVector2 index!" + GameInterface.getI.useWeapon.NBKLEELCDBJ(true) + "colorA", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("sunshine_ShadowCoordDepthStart", 510f);
			}
		}
	}

	// Token: 0x060088F6 RID: 35062 RVA: 0x003F8CD4 File Offset: 0x003F6ED4
	private void JLMDLHCNGBE()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 639f, 293f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x003F8E08 File Offset: 0x003F7008
	public void JJIDHEJKENE(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("invn_rec20", "t_top").GIBGJFHMGIL();
				if (num <= 956f)
				{
					num = 798f;
				}
				JDCEFOFMGHB.JFIDAGABKID().DKJMCKOJOPF(num, 1, "reqperk" + GameInterface.getI.useWeapon.DFOJOOMBOGI(false) + "QTask.xml", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Tip", 1542f);
			}
		}
	}

	// Token: 0x060088F8 RID: 35064 RVA: 0x003F8EDC File Offset: 0x003F70DC
	private void NGMMNKHDOPG()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.NGMOMPKBOMM);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.EEOPOHEALPK().EAPKBNJJECM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.IOJJCKAKIMA(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x060088F9 RID: 35065 RVA: 0x003F9030 File Offset: 0x003F7230
	private void IEOICHPKEMD()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.JFIDAGABKID().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088FA RID: 35066 RVA: 0x003F9130 File Offset: 0x003F7330
	private void EDANNBFJHIK()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.JFIDAGABKID().CHPPAAAAJFC(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088FB RID: 35067 RVA: 0x003F9230 File Offset: 0x003F7430
	private void IGEICBNMPAD()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.MNJNNDHCDGG().FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x060088FC RID: 35068 RVA: 0x003F9330 File Offset: 0x003F7530
	public void NGHGGMOFKLI(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("_Texture", "TOD_kBetaMie").PPAAACJOOGA;
				if (num <= 1394f)
				{
					num = 492f;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.DKJMCKOJOPF(num, 1, "id" + GameInterface.getI.useWeapon.ONNIKIAJHBO(true) + " x", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("System.Single", 1671f);
			}
		}
	}

	// Token: 0x060088FD RID: 35069 RVA: 0x003F9404 File Offset: 0x003F7604
	private void KDOIOPJDJPL()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.DNJDOGGPMKA);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.KEGBPOJKINC().CCHNMOEMCEG(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.NEPJMOGNJFP(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x060088FE RID: 35070 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void IOIJGMFNBMC()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088FF RID: 35071 RVA: 0x003F9558 File Offset: 0x003F7758
	private void KJJBBLDJHPD()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008900 RID: 35072 RVA: 0x003F9658 File Offset: 0x003F7858
	private void PJHEGHHOJHJ()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.JFIDAGABKID().IJAEDDCCNHG(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x003F9758 File Offset: 0x003F7958
	private void OILHFNOFNPD()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.BOEICKFGGDB);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.KFJMDGGMPJO().KGPMEIGMNNG(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.AGAKDJFNCFK(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008902 RID: 35074 RVA: 0x003F98AC File Offset: 0x003F7AAC
	private void NHOELCKOMJN()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().GGBPIAGIILP().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008903 RID: 35075 RVA: 0x003F98D4 File Offset: 0x003F7AD4
	private void PBEKBHFDHAM()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008904 RID: 35076 RVA: 0x003F99D4 File Offset: 0x003F7BD4
	private void PLLCHLCDKFA()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.CFOLEBFGIGC);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.JMHOODFAGAM().EKONOOHOGBM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.BNMJNNICBMP(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008905 RID: 35077 RVA: 0x003F9B28 File Offset: 0x003F7D28
	private void ANHJAOPPMCI()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().JNDLBOIPCBI().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008906 RID: 35078 RVA: 0x003F9B50 File Offset: 0x003F7D50
	private void EMFOECIPBIP()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.JFIDAGABKID().FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008907 RID: 35079 RVA: 0x003F98AC File Offset: 0x003F7AAC
	private void GKIGMDPGAIP()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().GGBPIAGIILP().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008908 RID: 35080 RVA: 0x003F9C50 File Offset: 0x003F7E50
	private void EAOOIFBELKG()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1714f, 1516f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x06008909 RID: 35081 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void Awake()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600890A RID: 35082 RVA: 0x003F9D84 File Offset: 0x003F7F84
	public void CHHNNIJLFBH(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("weapon", "Cloth_01.wav").GIBGJFHMGIL();
				if (num <= 750f)
				{
					num = 1369f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(num, 0, "Head" + GameInterface.getI.useWeapon.DFOJOOMBOGI(false) + "WoodSaw", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("close", 1842f);
			}
		}
	}

	// Token: 0x0600890B RID: 35083 RVA: 0x003F9E57 File Offset: 0x003F8057
	private void PLBMFJMPMKL()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMMOKECDLEJ().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x0600890C RID: 35084 RVA: 0x003F9E7D File Offset: 0x003F807D
	private void OEIIHELBMFG()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().JNDLBOIPCBI().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x0600890D RID: 35085 RVA: 0x003F9EA4 File Offset: 0x003F80A4
	private void INIMDNDBMDK()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.DNJNBKJIDLM);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.MHFDIJGJGBJ().BGLMJKNIJFP(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.MANMFGJHFHH(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x0600890E RID: 35086 RVA: 0x003F9FF8 File Offset: 0x003F81F8
	public void CBNDILDBGMP(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("LH", "").BHPNANDGNOA();
				if (num <= 1412f)
				{
					num = 1147f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(num, 0, "wpn_rem2" + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + "Error! ", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("_DelItem.wav", 569f);
			}
		}
	}

	// Token: 0x0600890F RID: 35087 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void CKPNKKFIINO()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008910 RID: 35088 RVA: 0x003FA0CB File Offset: 0x003F82CB
	private void OKGEFINHFFL()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().JNDLBOIPCBI().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008911 RID: 35089 RVA: 0x003FA0F4 File Offset: 0x003F82F4
	private void OnEnable()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.onWpnLBDown);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.GHFFJNCLLDK(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008912 RID: 35090 RVA: 0x003FA248 File Offset: 0x003F8448
	public void NGMOMPKBOMM(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("Mouse Y", "").GIBGJFHMGIL();
				if (num <= 1541f)
				{
					num = 1231f;
				}
				JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(num, 1, "gi_um_lv" + GameInterface.getI.useWeapon.ONNIKIAJHBO(true) + "_RgbTex", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("WATER_REFLECTIVE", 352f);
			}
		}
	}

	// Token: 0x06008913 RID: 35091 RVA: 0x003FA31C File Offset: 0x003F851C
	private void BJOICAKCPLI()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.JFIDAGABKID().IJAEDDCCNHG(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008914 RID: 35092 RVA: 0x003FA41C File Offset: 0x003F861C
	private void CBBLGEDCJBF()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008915 RID: 35093 RVA: 0x003FA51C File Offset: 0x003F871C
	private void DJEKNFIFAEK()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.BOEICKFGGDB);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.EEOPOHEALPK().GDPECKOHOFD(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.KLGDODCKLNI(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008916 RID: 35094 RVA: 0x003FA670 File Offset: 0x003F8870
	private void KGGJHGNEHGM()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.GJDHEPJLIEM);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.BCLPDGODGKF().EKONOOHOGBM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.BCNGOOHCMII(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008917 RID: 35095 RVA: 0x003FA7C4 File Offset: 0x003F89C4
	private void BKGHBKPDMDH()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.NONLFLAIGCL);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.EAJHPOJPPFA().NDKBNDNJFMI(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.EDPBHAAHNOM(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008918 RID: 35096 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void DPNNENHAGOE()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008919 RID: 35097 RVA: 0x003FA918 File Offset: 0x003F8B18
	private void KKGLMJEFJOK()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.JJIDHEJKENE);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.BCLPDGODGKF().FFGCPMNCOPP(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.JPPBMMEMMME(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x0600891A RID: 35098 RVA: 0x003FAA6C File Offset: 0x003F8C6C
	private void HCCGBDPCEKO()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1978f, 516f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x0600891B RID: 35099 RVA: 0x003FABA0 File Offset: 0x003F8DA0
	public void onWpnLBDown(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = false;
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("wpn_add/base", "usetime").PPAAACJOOGA;
				if (num <= 1f)
				{
					num = 1f;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(num, 1, "Используем " + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + " {0} сек", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("food_draw.ogg", 1f);
			}
		}
	}

	// Token: 0x0600891C RID: 35100 RVA: 0x003FAC74 File Offset: 0x003F8E74
	private void OFPGMNGFLNH()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.IKGFHGKKCPG.IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x0600891D RID: 35101 RVA: 0x003FAD71 File Offset: 0x003F8F71
	private void FFIBIADBGJB()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().GGBPIAGIILP().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x0600891E RID: 35102 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void OAKCEHBONIP()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600891F RID: 35103 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void CBBIADNKMLI()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008920 RID: 35104 RVA: 0x003FAD98 File Offset: 0x003F8F98
	private void NJKJJNBMKHB()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 950f, 1729f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 1));
		}
	}

	// Token: 0x06008921 RID: 35105 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void MBNCGMLPNLD()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008922 RID: 35106 RVA: 0x003FAECC File Offset: 0x003F90CC
	private void DEGFGIDFFLD()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.NKEPEKOJHMN);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IKGFHGKKCPG.PFNELMIJJFD(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.IOJJCKAKIMA(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008923 RID: 35107 RVA: 0x003FB020 File Offset: 0x003F9220
	private void LEHBKPPGHPC()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.HMJJPNDEKPP().FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008924 RID: 35108 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void JGKDNHLKBEN()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008925 RID: 35109 RVA: 0x003FB120 File Offset: 0x003F9320
	private void NKMPFLIHGCB()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.DNJNBKJIDLM);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.BBLINJLBAIL().CJLEJOBNCPC(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.PNCBMIJMIJC(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008926 RID: 35110 RVA: 0x003FB274 File Offset: 0x003F9474
	private void OnDisable()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GGBPIAGIILP().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008927 RID: 35111 RVA: 0x003FB29C File Offset: 0x003F949C
	public void MAFCAAOJHMI(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = false;
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("_AxialAberration", "Tail").AMNOOPCPOKA();
				if (num <= 952f)
				{
					num = 804f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(num, 0, "1 Hand Sword Back Swing" + GameInterface.getI.useWeapon.JPBOPFNPNHC(true) + "https://www.youtube.com/watch?v=7__IafZGwvI", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Flares", 1654f);
			}
		}
	}

	// Token: 0x06008928 RID: 35112 RVA: 0x003FB370 File Offset: 0x003F9570
	private void GGOKNBBPLHB()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 974f, 1572f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 1));
		}
	}

	// Token: 0x06008929 RID: 35113 RVA: 0x003FB4A4 File Offset: 0x003F96A4
	private void AEFGOFJAKDO()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1033f, 1302f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 0));
		}
	}

	// Token: 0x0600892A RID: 35114 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void PHONLBCOJEG()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600892B RID: 35115 RVA: 0x003FB5D8 File Offset: 0x003F97D8
	public void NKEPEKOJHMN(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = false;
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("MotorbikeBackwardSittingCheer", "_NoiseTex").GIBGJFHMGIL();
				if (num <= 221f)
				{
					num = 915f;
				}
				JDCEFOFMGHB.JFIDAGABKID().DKJMCKOJOPF(num, 0, "Forefeet Root" + GameInterface.getI.useWeapon.ONNIKIAJHBO(true) + "invn_rec18", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("1HandSwordChargeHeavyBash", 1420f);
			}
		}
	}

	// Token: 0x0600892C RID: 35116 RVA: 0x003FB6AC File Offset: 0x003F98AC
	private void HKGCKLBHNPJ()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 134f, 549f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 0));
		}
	}

	// Token: 0x0600892D RID: 35117 RVA: 0x003FB7E0 File Offset: 0x003F99E0
	private void DAFJMNMFOON()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.MNJNNDHCDGG().FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x0600892E RID: 35118 RVA: 0x003FB8E0 File Offset: 0x003F9AE0
	public void BOEICKFGGDB(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = true;
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("FOVKick Increase curve is null, please define the curve for the field of view kicks", "FactoryTempTexture").BHPNANDGNOA();
				if (num <= 486f)
				{
					num = 1610f;
				}
				JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(num, 0, "SUNSHINE_OVERCAST_OFF" + GameInterface.getI.useWeapon.DFOJOOMBOGI(true) + "UNIQUE_SHADOW", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("F", 1303f);
			}
		}
	}

	// Token: 0x0600892F RID: 35119 RVA: 0x003FB9B4 File Offset: 0x003F9BB4
	public void KBJGMHPNGBP(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.MIBOJMFKFGI = true;
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("wpn_lv", "StrafeRunLeft").BHPNANDGNOA();
				if (num <= 697f)
				{
					num = 1754f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(num, 1, "help" + GameInterface.getI.useWeapon.JPBOPFNPNHC(true) + "10", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("WATER_EDGEBLEND_OFF", 922f);
			}
		}
	}

	// Token: 0x06008930 RID: 35120 RVA: 0x003FBA88 File Offset: 0x003F9C88
	private void ECPECFPNLKP()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008931 RID: 35121 RVA: 0x003FBB88 File Offset: 0x003F9D88
	private void BFOPAJGPJLK()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 301f, 1419f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x06008932 RID: 35122 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void DHIJGNHBMFJ()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008933 RID: 35123 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void COOHBKKNOLG()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008934 RID: 35124 RVA: 0x003FBCBC File Offset: 0x003F9EBC
	private void PHIACAJNNIG()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BMMOKECDLEJ().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008935 RID: 35125 RVA: 0x003FBCE4 File Offset: 0x003F9EE4
	private void Update()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008936 RID: 35126 RVA: 0x003FBDE4 File Offset: 0x003F9FE4
	private void LEKDBOJGNEG()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.FFFFJAKKGIN);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.OOIJFNAMEDP().NDKBNDNJFMI(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.AGAKDJFNCFK(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008937 RID: 35127 RVA: 0x003FBF38 File Offset: 0x003FA138
	private void IJILHIBFFCF()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1759f, 1230f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x06008938 RID: 35128 RVA: 0x003FC06C File Offset: 0x003FA26C
	public void FFFFJAKKGIN(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("_Offsets", "http://j.mp/1FRAL5L").GIBGJFHMGIL();
				if (num <= 1790f)
				{
					num = 1559f;
				}
				JDCEFOFMGHB.IKGFHGKKCPG.NOIEEEIONNG(num, 1, " cannot be used as a 3D LUT." + GameInterface.getI.useWeapon.JPBOPFNPNHC(true) + "lifeBar", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("http://af-2.ru/?q=store", 1513f);
			}
		}
	}

	// Token: 0x06008939 RID: 35129 RVA: 0x003FC140 File Offset: 0x003FA340
	private void BBAGNFIALFG()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.CFOLEBFGIGC);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.NPCAKEGNBHD().LDLNKMKLKOC(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.FABHFGACNOH(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x0600893A RID: 35130 RVA: 0x003FC294 File Offset: 0x003FA494
	private void PNAEIDCONFP()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1974f, 1364f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x0600893B RID: 35131 RVA: 0x003FC3C8 File Offset: 0x003FA5C8
	private void DFCJDHJGILP()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().JNDLBOIPCBI().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x0600893C RID: 35132 RVA: 0x003FC3F0 File Offset: 0x003FA5F0
	public void OEFKFEIBJBH(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(true);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("readSadok error ", "COLOR_GRADING_LOG_VIEW").AMNOOPCPOKA();
				if (num <= 1341f)
				{
					num = 863f;
				}
				JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(num, 0, "\n" + GameInterface.getI.useWeapon.NBKLEELCDBJ(true) + "WeaponRunBackward", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("wpn_add/base", 549f);
			}
		}
	}

	// Token: 0x0600893D RID: 35133 RVA: 0x003FC4C4 File Offset: 0x003FA6C4
	public void MDDADMJIGCA(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("knopje.wav", "null").BHPNANDGNOA();
				if (num <= 1353f)
				{
					num = 1785f;
				}
				JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(num, 0, "" + GameInterface.getI.useWeapon.DFOJOOMBOGI(true) + "WeaponStrafeRunRight", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("wpn_add/req/reqPerk", 1083f);
			}
		}
	}

	// Token: 0x0600893E RID: 35134 RVA: 0x003FC598 File Offset: 0x003FA798
	private void NKEJKDGBPOP()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.KBJGMHPNGBP);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.AGAKDJFNCFK(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = true;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x0600893F RID: 35135 RVA: 0x003FC6EC File Offset: 0x003FA8EC
	private void NFPFDOEENLA()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008940 RID: 35136 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void ALPLJPJHBML()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008941 RID: 35137 RVA: 0x003FC7EC File Offset: 0x003FA9EC
	public void FNEEMBJLEOE(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("<color=\"", "wpn_bait_sz").GCMMMODHDBL();
				if (num <= 968f)
				{
					num = 280f;
				}
				JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(num, 1, "GestureHandUp" + GameInterface.getI.useWeapon.DFOJOOMBOGI(false) + "OfficeSitting1LegStraight", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.BGBNNPNHCEF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("loadRodObject ", 989f);
			}
		}
	}

	// Token: 0x06008942 RID: 35138 RVA: 0x003FC8BF File Offset: 0x003FAABF
	private void PCKEAEAHAKG()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.JNDLBOIPCBI().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008943 RID: 35139 RVA: 0x003FC8E5 File Offset: 0x003FAAE5
	private void BIDOGNIGPED()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMMOKECDLEJ().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008944 RID: 35140 RVA: 0x003FC8BF File Offset: 0x003FAABF
	private void IICFAPMJLCN()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.JNDLBOIPCBI().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008945 RID: 35141 RVA: 0x003FC90B File Offset: 0x003FAB0B
	private void DAIKHLLJCPL()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BMMOKECDLEJ().GAOILKHABMH(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008946 RID: 35142 RVA: 0x003FC934 File Offset: 0x003FAB34
	private void KBAJMMCHDOC()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 562f, 41f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 1));
		}
	}

	// Token: 0x06008947 RID: 35143 RVA: 0x003FCA68 File Offset: 0x003FAC68
	private void MOJBLBHKCCM()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.onWpnLBDown);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.JMHOODFAGAM().EAPKBNJJECM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.NMJBBDAHBGI(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008948 RID: 35144 RVA: 0x003FCBBC File Offset: 0x003FADBC
	private void OnGUI()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 56f, 56f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 0));
		}
	}

	// Token: 0x06008949 RID: 35145 RVA: 0x003FCCF0 File Offset: 0x003FAEF0
	private void FKHAKIKPFFO()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.IKGFHGKKCPG.FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x0600894A RID: 35146 RVA: 0x003FCDF0 File Offset: 0x003FAFF0
	public void CFOLEBFGIGC(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.BBLEPPMMPIL("fisht.modelName empty! fid=", "RodParams not found!").BHPNANDGNOA();
				if (num <= 942f)
				{
					num = 1620f;
				}
				JDCEFOFMGHB.MNJNNDHCDGG().PBJGEIMFNNO(num, 0, "u_UniqueShadowBlockerDistanceScale" + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + "<color='#004000'>", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), false);
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("_PrevViewProj", 500f);
			}
		}
	}

	// Token: 0x0600894C RID: 35148 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void MNIOJGMLIMC()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600894D RID: 35149 RVA: 0x003FCEC4 File Offset: 0x003FB0C4
	private void NECHJAHFOFF()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 1294f, 1470f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 0 : 1));
		}
	}

	// Token: 0x0600894E RID: 35150 RVA: 0x003FCFF8 File Offset: 0x003FB1F8
	private void LDDKALDINEB()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.OCHCODJIPHJ.x = this.scrRect.x;
		this.AOKILHGLPMI.OCHCODJIPHJ.y = this.scrRect.y;
		this.isMouseOver = this.scrRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		this.AOKILHGLPMI.OHNAHKMBABD = this.isMouseOver;
		if (Application.isEditor)
		{
			GUI.Label(new Rect(this.rcrd.x, this.rcrd.y, 128f, 1030f), string.Concat(this.AOKILHGLPMI.OHNAHKMBABD ? 1 : 0));
		}
	}

	// Token: 0x0600894F RID: 35151 RVA: 0x003FD12C File Offset: 0x003FB32C
	private void BHMLILLBFLP()
	{
		this.rcrd = new Vector2(this.OCHCODJIPHJ.position.x, (float)Screen.height - this.OCHCODJIPHJ.position.y);
		this.AOKILHGLPMI = new AENEOOFMBKE(null, this.rcrd.x, this.rcrd.y, this.cellid, this.bagid);
		this.AOKILHGLPMI.OCHCODJIPHJ.width = this.OCHCODJIPHJ.rect.width;
		this.AOKILHGLPMI.OCHCODJIPHJ.height = this.OCHCODJIPHJ.rect.height;
		this.scrRect = new Rect(this.rcrd.x, this.rcrd.y, this.OCHCODJIPHJ.rect.width, this.OCHCODJIPHJ.rect.height);
		this.AOKILHGLPMI.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.NKEPEKOJHMN);
		KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = null;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IOALEBMCEGM().BCDFPBPBEHM(this.bagid);
		if (dcjidjjkjck != null)
		{
			ldjpekhhnhb = dcjidjjkjck.CLGOJHMPFFK(this.cellid);
		}
		if (ldjpekhhnhb != null)
		{
			this.AOKILHGLPMI.MGLECJKFBCN = false;
			this.AOKILHGLPMI.FLBHDKHKAPM = ldjpekhhnhb.DHCGCGCFFKA;
		}
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x003FD280 File Offset: 0x003FB480
	private void BAIKCLKJPAA()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().CHPPAAAAJFC(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x003F98AC File Offset: 0x003F7AAC
	private void BMLMKAGHDDE()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().GGBPIAGIILP().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008952 RID: 35154 RVA: 0x003FC8BF File Offset: 0x003FAABF
	private void DENHKOPGLDK()
	{
		if (this.AOKILHGLPMI != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.JNDLBOIPCBI().PLGKNLLJHIO(this.AOKILHGLPMI);
			this.AOKILHGLPMI = null;
		}
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x003FD380 File Offset: 0x003FB580
	private void MIFLHGMPLJD()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.MNJNNDHCDGG().FDMNKDONMFM(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = false;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x003FD480 File Offset: 0x003FB680
	private void IKHCCAANGOP()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.HMJJPNDEKPP().HPCEJKFHNBA(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008955 RID: 35157 RVA: 0x003FD580 File Offset: 0x003FB780
	private void KMLNBHIIGKH()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(0) && JDCEFOFMGHB.HMJJPNDEKPP().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008956 RID: 35158 RVA: 0x003FD680 File Offset: 0x003FB880
	private void HNMODJBBKBI()
	{
		if (this.isMouseOver)
		{
			if (Input.GetMouseButtonDown(1) && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null && this.AOKILHGLPMI.OBLONDPEGLN != null)
			{
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
				this.AOKILHGLPMI.OBLONDPEGLN.BFHKBOPOFGB = true;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.x = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.x - this.scrRect.x;
				MDEKJCCIDIA.IKGFHGKKCPG.GKKGCDPIPPL.y = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF.y - this.scrRect.y;
				MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC = this.AOKILHGLPMI.OBLONDPEGLN;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = this.bagid;
				MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = this.cellid;
			}
		}
	}

	// Token: 0x06008957 RID: 35159 RVA: 0x003FD780 File Offset: 0x003FB980
	public void DNJDOGGPMKA(ONKDCGNBALK ONPHLHKAGFP)
	{
		AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)ONPHLHKAGFP;
		if (aeneoofmbke.OBLONDPEGLN != null)
		{
			GameInterface.getI.useWeapon = aeneoofmbke.OBLONDPEGLN;
			if (GameInterface.getI.useWeapon != null)
			{
				if (Fisherman.getI != null)
				{
					Fisherman.getI.APAPJMNFCPP(false);
				}
				float num = GameInterface.getI.useWeapon.LOLCPOPODKE("ClimbUp", "wpn_fid2").GIBGJFHMGIL();
				if (num <= 1910f)
				{
					num = 1766f;
				}
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(num, 1, "Masks" + GameInterface.getI.useWeapon.NBKLEELCDBJ(false) + "Forward", new ONKDCGNBALK.CMMHGMILOIM(MDEKJCCIDIA.IKGFHGKKCPG.FOONOMCNJPF), true);
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("", 808f);
			}
		}
	}

	// Token: 0x06008958 RID: 35160 RVA: 0x003F81BB File Offset: 0x003F63BB
	private void APNGAHFMCIA()
	{
		this.OCHCODJIPHJ = base.GetComponent<RectTransform>();
	}

	// Token: 0x040012FC RID: 4860
	public int bagid;

	// Token: 0x040012FD RID: 4861
	public int cellid;

	// Token: 0x040012FE RID: 4862
	public Vector2 rcrd;

	// Token: 0x040012FF RID: 4863
	private AENEOOFMBKE AOKILHGLPMI;

	// Token: 0x04001300 RID: 4864
	private RectTransform OCHCODJIPHJ;

	// Token: 0x04001301 RID: 4865
	public bool isMouseOver;

	// Token: 0x04001302 RID: 4866
	public Rect scrRect;

	// Token: 0x04001303 RID: 4867
	private bool LECAOMCEOHN;
}
