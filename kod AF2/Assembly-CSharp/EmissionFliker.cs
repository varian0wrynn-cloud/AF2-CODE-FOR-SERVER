using System;
using UnityEngine;

// Token: 0x02000268 RID: 616
public class EmissionFliker : MonoBehaviour
{
	// Token: 0x06008F7D RID: 36733 RVA: 0x0040F3EC File Offset: 0x0040D5EC
	private void Start()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_EMISSION");
		if (this.rendEmission.material.HasProperty("_EmissionColor"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("_EmissionColor");
		}
	}

	// Token: 0x06008F7E RID: 36734 RVA: 0x0040F448 File Offset: 0x0040D648
	private void ELADFDNPOOI()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("SexyDance");
		if (this.rendEmission.material.HasProperty("_ALPHATEST_ON"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("_BlurredColor");
		}
	}

	// Token: 0x06008F7F RID: 36735 RVA: 0x0040F4A4 File Offset: 0x0040D6A4
	private void LMMDHJJJNJO()
	{
		float b = this.minEmi + OLPINJLCKCI.NPIEJELJPIM().FFDDAGJJOOM((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("_Params1"))
		{
			this.rendEmission.material.SetColor("Mouse X", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x0040F50C File Offset: 0x0040D70C
	private void FJEEADNCKAG()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().FFDDAGJJOOM((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("; "))
		{
			this.rendEmission.material.SetColor("_Offsets", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x0040F574 File Offset: 0x0040D774
	private void MFHGOLNLAAF()
	{
		float b = this.minEmi + OLPINJLCKCI.BMALMDIBLDP().GCPGDOACKLG((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("MotorbikeSeatStand"))
		{
			this.rendEmission.material.SetColor("TOD_MoonMeshContrast", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x0040F5DC File Offset: 0x0040D7DC
	private void PBMPJPIMJBF()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("bright");
		if (this.rendEmission.material.HasProperty("knopje.wav"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("No fish in fishModelData modelid=");
		}
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x0040F638 File Offset: 0x0040D838
	private void GDBBAMFMKII()
	{
		float b = this.minEmi + OLPINJLCKCI.OBDBAABBAKB().GCGEHNMEDIL((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("spinKvok activate"))
		{
			this.rendEmission.material.SetColor("Idle180", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x0040F6A0 File Offset: 0x0040D8A0
	private void DFFOEGHGPGP()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().LLNEEEJIDGI((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("DepthMaskBlendMaterial"))
		{
			this.rendEmission.material.SetColor("buykey", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x0040F708 File Offset: 0x0040D908
	private void OPDCJCFMIPE()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().FFDDAGJJOOM((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("ObscuredDouble vs double, "))
		{
			this.rendEmission.material.SetColor("reel_type0", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F86 RID: 36742 RVA: 0x0040F770 File Offset: 0x0040D970
	private void OHKHOAKCENL()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().GCPGDOACKLG((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("Body"))
		{
			this.rendEmission.material.SetColor("WeaponStrafeRunRight", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F87 RID: 36743 RVA: 0x0040F7D8 File Offset: 0x0040D9D8
	private void EHFPLKEINFO()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("camouflage_intens");
		if (this.rendEmission.material.HasProperty("_Grain_Params2"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("Shoot Forward");
		}
	}

	// Token: 0x06008F88 RID: 36744 RVA: 0x0040F834 File Offset: 0x0040DA34
	private void DPGECEOMHNM()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("****** locscount="))
		{
			this.rendEmission.material.SetColor("Corrupt DT e=", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F89 RID: 36745 RVA: 0x0040F89C File Offset: 0x0040DA9C
	private void ANHOOJFEJJE()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("ok");
		if (this.rendEmission.material.HasProperty("wpn_hookf"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("Bend Constraint is referencing to a bone '");
		}
	}

	// Token: 0x06008F8A RID: 36746 RVA: 0x0040F8F8 File Offset: 0x0040DAF8
	private void JOHDLNOKCOK()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().LLNEEEJIDGI((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html"))
		{
			this.rendEmission.material.SetColor("{not_found}", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x0040F960 File Offset: 0x0040DB60
	private void IJOCHELLKJH()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("SoccerKeeperDiveStrafeCloseLeft");
		if (this.rendEmission.material.HasProperty("</color>"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("Right arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.");
		}
	}

	// Token: 0x06008F8C RID: 36748 RVA: 0x0040F9BC File Offset: 0x0040DBBC
	private void MPLCAGFGEBO()
	{
		float b = this.minEmi + OLPINJLCKCI.BMALMDIBLDP().BCODBMGPBFJ((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("En"))
		{
			this.rendEmission.material.SetColor("auk_wavg", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F8D RID: 36749 RVA: 0x0040FA24 File Offset: 0x0040DC24
	private void JLKBMEBFHBI()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("IdleCheer");
		if (this.rendEmission.material.HasProperty("UV2"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("IdleDodgeRight");
		}
	}

	// Token: 0x06008F8E RID: 36750 RVA: 0x0040FA80 File Offset: 0x0040DC80
	private void PNJHMJNFPLP()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("Idle Keep Back");
		if (this.rendEmission.material.HasProperty("Katana"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("invn_rec6");
		}
	}

	// Token: 0x06008F8F RID: 36751 RVA: 0x0040FADC File Offset: 0x0040DCDC
	private void DHJDMKLBLEF()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("Sound/");
		if (this.rendEmission.material.HasProperty("INTERFACE"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("cht_msg28");
		}
	}

	// Token: 0x06008F90 RID: 36752 RVA: 0x0040FB38 File Offset: 0x0040DD38
	private void KGICJDGIIJK()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_RefractTex");
		if (this.rendEmission.material.HasProperty(""))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("");
		}
	}

	// Token: 0x06008F91 RID: 36753 RVA: 0x0040FB94 File Offset: 0x0040DD94
	private void JLFBDOPFDDJ()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().GCGEHNMEDIL((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("GiantGrabThrow2"))
		{
			this.rendEmission.material.SetColor("RollerBladeGrindRoyale", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x0040FBFC File Offset: 0x0040DDFC
	private void LDDIGEMBDNF()
	{
		float b = this.minEmi + OLPINJLCKCI.OBDBAABBAKB().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("_Histogram"))
		{
			this.rendEmission.material.SetColor("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x0040FC64 File Offset: 0x0040DE64
	private void CGFDDFHECLJ()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_CameraClipInfo");
		if (this.rendEmission.material.HasProperty("Titul.xml"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("a");
		}
	}

	// Token: 0x06008F94 RID: 36756 RVA: 0x0040FCC0 File Offset: 0x0040DEC0
	private void PNAAHEFHPCL()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("wpn_wgt");
		if (this.rendEmission.material.HasProperty("_DeepTex"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("textAsset is NULL! Path: fishModelData");
		}
	}

	// Token: 0x06008F95 RID: 36757 RVA: 0x0040FD1C File Offset: 0x0040DF1C
	private void DGGMJCMLLED()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("!");
		if (this.rendEmission.material.HasProperty("Original position: "))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("IdleFly");
		}
	}

	// Token: 0x06008F96 RID: 36758 RVA: 0x0040FD78 File Offset: 0x0040DF78
	private void EDGALMCHPPH()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("KneesIdle");
		if (this.rendEmission.material.HasProperty("null"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("IdleStandingJump");
		}
	}

	// Token: 0x06008F97 RID: 36759 RVA: 0x0040FDD4 File Offset: 0x0040DFD4
	private void IOGAKGCADBL()
	{
		float b = this.minEmi + OLPINJLCKCI.BMALMDIBLDP().FFDDAGJJOOM((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("..."))
		{
			this.rendEmission.material.SetColor("useSrcAlphaAsMask", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F98 RID: 36760 RVA: 0x0040FE3C File Offset: 0x0040E03C
	private void CAJLCEPLKJG()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("Ambigious asset bundle variant chosen because there was no matching active variant: ");
		if (this.rendEmission.material.HasProperty("F3"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("TOD_Directionality");
		}
	}

	// Token: 0x06008F99 RID: 36761 RVA: 0x0040FE98 File Offset: 0x0040E098
	private void HMLNMHOMMNO()
	{
		float b = this.minEmi + OLPINJLCKCI.OBDBAABBAKB().GKDBPBFOINB((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("WalkBackward"))
		{
			this.rendEmission.material.SetColor("types", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F9A RID: 36762 RVA: 0x0040FF00 File Offset: 0x0040E100
	private void PMKOAHMNBBG()
	{
		float b = this.minEmi + OLPINJLCKCI.NLOGJHEFMHM().JJKCBOPPOHJ((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("gi_uinf_0"))
		{
			this.rendEmission.material.SetColor("wpn_fid3", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x0040FF68 File Offset: 0x0040E168
	private void LACNPNKHCAA()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().GCPGDOACKLG((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("idlist"))
		{
			this.rendEmission.material.SetColor("ShotgunReadyFire", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x0040FFD0 File Offset: 0x0040E1D0
	private void KKCFKEDABLB()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword(" ");
		if (this.rendEmission.material.HasProperty("poplSoundIndex"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("");
		}
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x0041002C File Offset: 0x0040E22C
	private void AIFIEAGFIMM()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("MotorbikeHeartAttack");
		if (this.rendEmission.material.HasProperty(""))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("wpn_add/base");
		}
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x00410088 File Offset: 0x0040E288
	private void MODJFGGIAHD()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("http://www.root-motion.com/finalikdox/html/page6.html");
		if (this.rendEmission.material.HasProperty("DealerIdle"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("BaseLogic");
		}
	}

	// Token: 0x06008F9F RID: 36767 RVA: 0x004100E4 File Offset: 0x0040E2E4
	private void Update()
	{
		float b = this.minEmi + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("_EmissionColor"))
		{
			this.rendEmission.material.SetColor("_EmissionColor", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x0041014C File Offset: 0x0040E34C
	private void JMNNAPNJDNK()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("</color>\n"))
		{
			this.rendEmission.material.SetColor("ZThickness", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FA1 RID: 36769 RVA: 0x004101B4 File Offset: 0x0040E3B4
	private void HHGGCBLOJGB()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("inv_pcs1");
		if (this.rendEmission.material.HasProperty("Giant Grab Throw 2"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("cntx_close");
		}
	}

	// Token: 0x06008FA2 RID: 36770 RVA: 0x00410210 File Offset: 0x0040E410
	private void BNKJNBIDPME()
	{
		float b = this.minEmi + OLPINJLCKCI.NLOGJHEFMHM().GCGEHNMEDIL((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("crft_norec2"))
		{
			this.rendEmission.material.SetColor("crft_from", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FA3 RID: 36771 RVA: 0x00410278 File Offset: 0x0040E478
	private void CLHGHANANNL()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("FlyBackward");
		if (this.rendEmission.material.HasProperty("Quest loaded error"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("DataSize ");
		}
	}

	// Token: 0x06008FA4 RID: 36772 RVA: 0x004102D4 File Offset: 0x0040E4D4
	private void IKHCCAANGOP()
	{
		float b = this.minEmi + OLPINJLCKCI.NLOGJHEFMHM().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("WeaponRun"))
		{
			this.rendEmission.material.SetColor("_MainTex", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FA5 RID: 36773 RVA: 0x0041033C File Offset: 0x0040E53C
	private void OFGMIEJKMGC()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("StrafeRunLeft");
		if (this.rendEmission.material.HasProperty("Reset"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("turn_state");
		}
	}

	// Token: 0x06008FA6 RID: 36774 RVA: 0x00410398 File Offset: 0x0040E598
	private void MCHAAIIHOKD()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_NoiseTex");
		if (this.rendEmission.material.HasProperty("_TintColor"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor(".png");
		}
	}

	// Token: 0x06008FA7 RID: 36775 RVA: 0x004103F4 File Offset: 0x0040E5F4
	private void LPNDCJKAKEA()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("SneakBackward");
		if (this.rendEmission.material.HasProperty("OfficeSittingMouseMovement"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("IdleReadyCrouch");
		}
	}

	// Token: 0x06008FA8 RID: 36776 RVA: 0x00410450 File Offset: 0x0040E650
	private void LIOCDEICIFD()
	{
		float b = this.minEmi + OLPINJLCKCI.BMALMDIBLDP().GCPGDOACKLG((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty(".ogg"))
		{
			this.rendEmission.material.SetColor(" ms", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FA9 RID: 36777 RVA: 0x004104B8 File Offset: 0x0040E6B8
	private void CJHBCHBOLBI()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("_SoftZDistance"))
		{
			this.rendEmission.material.SetColor("t_eye", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FAA RID: 36778 RVA: 0x00410520 File Offset: 0x0040E720
	private void GCNGEFBKMNC()
	{
		float b = this.minEmi + OLPINJLCKCI.IKGFHGKKCPG.LLNEEEJIDGI((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("<b>Supported types:</b>\n"))
		{
			this.rendEmission.material.SetColor("newHour", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FAC RID: 36780 RVA: 0x00410598 File Offset: 0x0040E798
	private void PNBGJBMJLFM()
	{
		float b = this.minEmi + OLPINJLCKCI.IKGFHGKKCPG.GCPGDOACKLG((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("Mouse X"))
		{
			this.rendEmission.material.SetColor("btn_cancel", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FAD RID: 36781 RVA: 0x00410600 File Offset: 0x0040E800
	private void ELFLOPJDAKK()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("");
		if (this.rendEmission.material.HasProperty("Mouse X"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("Assets/Weapons/");
		}
	}

	// Token: 0x06008FAE RID: 36782 RVA: 0x0041065C File Offset: 0x0040E85C
	private void EHDPACPIBNF()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("IdleDodgeLeft");
		if (this.rendEmission.material.HasProperty("droplinemsg1"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("Sat Night Fever");
		}
	}

	// Token: 0x06008FAF RID: 36783 RVA: 0x004106B8 File Offset: 0x0040E8B8
	private void KIEIPFFEDHC()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_");
		if (this.rendEmission.material.HasProperty("cnt_energ"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("KatanaReadyLow");
		}
	}

	// Token: 0x06008FB0 RID: 36784 RVA: 0x00410714 File Offset: 0x0040E914
	private void OLBDJCFPKFG()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("RunJump");
		if (this.rendEmission.material.HasProperty("Vertical"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("DecalMesh");
		}
	}

	// Token: 0x06008FB1 RID: 36785 RVA: 0x00410770 File Offset: 0x0040E970
	private void JIKGIJEHGAP()
	{
		float b = this.minEmi + OLPINJLCKCI.BMALMDIBLDP().FFDDAGJJOOM((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("{not_found}"))
		{
			this.rendEmission.material.SetColor("cut.ogg", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FB2 RID: 36786 RVA: 0x004107D8 File Offset: 0x0040E9D8
	private void GDIMBBBPIHI()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("No Template! ID=");
		if (this.rendEmission.material.HasProperty("FlyRight"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("KatanaReady");
		}
	}

	// Token: 0x06008FB3 RID: 36787 RVA: 0x00410834 File Offset: 0x0040EA34
	private void KJJNMNKPNCH()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("{not_found}");
		if (this.rendEmission.material.HasProperty("gameComplete"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("steamno");
		}
	}

	// Token: 0x06008FB4 RID: 36788 RVA: 0x00410890 File Offset: 0x0040EA90
	private void JCELICPHGEP()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("MotorbikeShootLeft");
		if (this.rendEmission.material.HasProperty("ClimbRight"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("1=");
		}
	}

	// Token: 0x06008FB5 RID: 36789 RVA: 0x004108EC File Offset: 0x0040EAEC
	private void IIKDDILLGLF()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_Offsets");
		if (this.rendEmission.material.HasProperty("_r_"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("TOD_CloudShadow");
		}
	}

	// Token: 0x06008FB6 RID: 36790 RVA: 0x00410948 File Offset: 0x0040EB48
	private void MEFOGCFJBNE()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("IKMappingSpine is missing the right thigh bone."))
		{
			this.rendEmission.material.SetColor("Kernel", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FB7 RID: 36791 RVA: 0x004109B0 File Offset: 0x0040EBB0
	private void EMFOECIPBIP()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>"))
		{
			this.rendEmission.material.SetColor("Add random value", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FB8 RID: 36792 RVA: 0x00410A18 File Offset: 0x0040EC18
	private void LBGKAMLLACN()
	{
		float b = this.minEmi + OLPINJLCKCI.ODDOIHEPICE().JNFGOGFFLKK((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("ScatterColor"))
		{
			this.rendEmission.material.SetColor("{0:F2}, {1:F2}, {2:F2}", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FB9 RID: 36793 RVA: 0x00410A80 File Offset: 0x0040EC80
	private void DDEBDCGNCPC()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("Sonar_pos");
		if (this.rendEmission.material.HasProperty(""))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("SneakRight");
		}
	}

	// Token: 0x06008FBA RID: 36794 RVA: 0x00410ADC File Offset: 0x0040ECDC
	private void IGEICBNMPAD()
	{
		float b = this.minEmi + OLPINJLCKCI.NPIEJELJPIM().BCODBMGPBFJ((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("PlayerPet"))
		{
			this.rendEmission.material.SetColor("</color>\n", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FBB RID: 36795 RVA: 0x00410B44 File Offset: 0x0040ED44
	private void KMLNBHIIGKH()
	{
		float b = this.minEmi + OLPINJLCKCI.IFLFANPMLMM().BCODBMGPBFJ((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty("R"))
		{
			this.rendEmission.material.SetColor("MotorbikeSuperman", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x06008FBC RID: 36796 RVA: 0x00410BAC File Offset: 0x0040EDAC
	private void LHJCHPFKGDB()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("pinky");
		if (this.rendEmission.material.HasProperty("sunshine_OvercastCoord"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("CrouchWalk");
		}
	}

	// Token: 0x06008FBD RID: 36797 RVA: 0x00410C08 File Offset: 0x0040EE08
	private void CBLGFOFHNPJ()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("FS ");
		if (this.rendEmission.material.HasProperty("SUNSHINE_ONE_CASCADE"))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("sys");
		}
	}

	// Token: 0x06008FBE RID: 36798 RVA: 0x00410C64 File Offset: 0x0040EE64
	private void ONIHHFLOJMN()
	{
		bool flag = this.isMovie;
		this.rendEmission.material.EnableKeyword("_DepthTexture");
		if (this.rendEmission.material.HasProperty("rollTENSION="))
		{
			this.FOHDLNKGGKM = this.rendEmission.material.GetColor("AssetLoader: ");
		}
	}

	// Token: 0x06008FBF RID: 36799 RVA: 0x00410CC0 File Offset: 0x0040EEC0
	private void INKGAFANFIB()
	{
		float b = this.minEmi + OLPINJLCKCI.NLOGJHEFMHM().JNFGOGFFLKK((double)(this.maxEmi - this.minEmi));
		if (this.rendEmission.material.HasProperty(" ms"))
		{
			this.rendEmission.material.SetColor("_HitPosition", this.FOHDLNKGGKM * b);
		}
	}

	// Token: 0x0400133C RID: 4924
	public Renderer rendEmission;

	// Token: 0x0400133D RID: 4925
	public float minEmi;

	// Token: 0x0400133E RID: 4926
	public float maxEmi = 1f;

	// Token: 0x0400133F RID: 4927
	public bool isMovie;

	// Token: 0x04001340 RID: 4928
	private Color FOHDLNKGGKM;
}
