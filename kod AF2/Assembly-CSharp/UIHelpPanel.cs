using System;
using UnityEngine;

// Token: 0x02000185 RID: 389
public class UIHelpPanel : MonoBehaviour
{
	// Token: 0x0600561F RID: 22047 RVA: 0x00280B59 File Offset: 0x0027ED59
	public void CBDLCEFDIGM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Toggle", 1352f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x00280B86 File Offset: 0x0027ED86
	public void NBCLBLJMMED()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("12 samples", 1f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x00280BB3 File Offset: 0x0027EDB3
	public void FEIHOEOEDPK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("lifeBar", 1522f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x00280BE0 File Offset: 0x0027EDE0
	public void GMCIMPELEBB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("C", 739f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x00280C0D File Offset: 0x0027EE0D
	public void PIDOOMCKHMD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("IdleWalk", 257f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x00280C3A File Offset: 0x0027EE3A
	public void GJFFNOMNLPM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("isMoving", 1057f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x00280C67 File Offset: 0x0027EE67
	public void JJEOAKPODJJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Bluenoise64/LDR_LLL1_", 171f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x00280C94 File Offset: 0x0027EE94
	public void KJJLEJBONKD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("gi_um_nosel", 1754f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005627 RID: 22055 RVA: 0x00280CC1 File Offset: 0x0027EEC1
	private void Start()
	{
		this.FGGPEEGHGMF = "hlp_" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x00280CF7 File Offset: 0x0027EEF7
	public void PCAMHAEBGIF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("PistolFire", 104f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x00280D24 File Offset: 0x0027EF24
	private void LHHKDNILMDI()
	{
		this.FGGPEEGHGMF = "blesna.ogg" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x00280D5A File Offset: 0x0027EF5A
	public void PJBDDHBJDLN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("float:", 679f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x00280D87 File Offset: 0x0027EF87
	public void NKLDPILLPOP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Shotgun Ready Fire", 524f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x00280DB4 File Offset: 0x0027EFB4
	private void DGDGMFDPEHO()
	{
		this.FGGPEEGHGMF = "|" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x00280DEA File Offset: 0x0027EFEA
	private void CLHGHANANNL()
	{
		this.FGGPEEGHGMF = "repair.ogg" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600562E RID: 22062 RVA: 0x00280E20 File Offset: 0x0027F020
	private void KGICJDGIIJK()
	{
		this.FGGPEEGHGMF = "IKSolverFABRIKRoot chain at index " + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600562F RID: 22063 RVA: 0x00280E56 File Offset: 0x0027F056
	private void JFFPLABGMNF()
	{
		this.FGGPEEGHGMF = "The InteractionTrigger in the list 'inContact' has been destroyed" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005630 RID: 22064 RVA: 0x00280E8C File Offset: 0x0027F08C
	private void KJJNMNKPNCH()
	{
		this.FGGPEEGHGMF = "---------- NOnStatusChanged " + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005631 RID: 22065 RVA: 0x00280EC2 File Offset: 0x0027F0C2
	private void FPLHODJCJDO()
	{
		this.FGGPEEGHGMF = "RollerBladeCrossoverRight" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x00280EF8 File Offset: 0x0027F0F8
	private void DHJDMKLBLEF()
	{
		this.FGGPEEGHGMF = "_LogLut_Params" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x00280F2E File Offset: 0x0027F12E
	private void CBLGFOFHNPJ()
	{
		this.FGGPEEGHGMF = "auk_wmax" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x00280F64 File Offset: 0x0027F164
	private void HHGGCBLOJGB()
	{
		this.FGGPEEGHGMF = "[AmplifyColor] Failed to initialize shaders. Please attempt to re-enable the Amplify Color Effect component. If that fails, please reinstall Amplify Color." + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x00280F9A File Offset: 0x0027F19A
	public void EBOGAMCPLLD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("OfficeSittingReading", 435f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x00280FC7 File Offset: 0x0027F1C7
	public void OnCloseClick()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 0.6f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x00280FF4 File Offset: 0x0027F1F4
	public void OGPEGEEMLHC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("ActorFish_", 843f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x00281021 File Offset: 0x0027F221
	public void OAGAMCMKBOC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_ScatterTexture", 579f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x0028104E File Offset: 0x0027F24E
	private void KFGKKLAKFGH()
	{
		this.FGGPEEGHGMF = "</color>" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600563A RID: 22074 RVA: 0x00281084 File Offset: 0x0027F284
	public void EFHAMAGCGJK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_Color", 1920f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x002810B1 File Offset: 0x0027F2B1
	private void NCALLFHEAGJ()
	{
		this.FGGPEEGHGMF = "DealerIdle" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x002810E7 File Offset: 0x0027F2E7
	private void KEMGOLACEHI()
	{
		this.FGGPEEGHGMF = "remWpn=" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600563D RID: 22077 RVA: 0x0028111D File Offset: 0x0027F31D
	private void ANHOOJFEJJE()
	{
		this.FGGPEEGHGMF = "invn_rec21" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600563E RID: 22078 RVA: 0x00281153 File Offset: 0x0027F353
	private void CGFDDFHECLJ()
	{
		this.FGGPEEGHGMF = "Flap_02.wav" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600563F RID: 22079 RVA: 0x00281189 File Offset: 0x0027F389
	public void KCHMMNDBIEA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("MotorbikeShootLeft", 419f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x002811B6 File Offset: 0x0027F3B6
	public void HILPLKNBNBO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Error", 1883f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005641 RID: 22081 RVA: 0x002811E3 File Offset: 0x0027F3E3
	public void BPNJJJACOMK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP(" ", 350f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005642 RID: 22082 RVA: 0x00281210 File Offset: 0x0027F410
	private void AIFIEAGFIMM()
	{
		this.FGGPEEGHGMF = "http://www.root-motion.com/finalikdox/html/page10.html" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005643 RID: 22083 RVA: 0x00281246 File Offset: 0x0027F446
	public void OPMLELBKKIA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("WeaponInstant", 1111f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x00281273 File Offset: 0x0027F473
	private void INDGOHJGCFN()
	{
		this.FGGPEEGHGMF = "CM" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x002812A9 File Offset: 0x0027F4A9
	public void EOHILFKIPNJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("collar", 1075f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x002812D6 File Offset: 0x0027F4D6
	public void POHADCOHMIO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("https://www.youtube.com/watch?v=eP9-zycoHLk", 424f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x00281303 File Offset: 0x0027F503
	public void GLJBKOEJBBE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("MotorbikeLassoBack", 252f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005648 RID: 22088 RVA: 0x00281330 File Offset: 0x0027F530
	private void MKNPFMEMOJO()
	{
		this.FGGPEEGHGMF = "level" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005649 RID: 22089 RVA: 0x00281366 File Offset: 0x0027F566
	private void EDGALMCHPPH()
	{
		this.FGGPEEGHGMF = "_Intensity" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600564A RID: 22090 RVA: 0x0028139C File Offset: 0x0027F59C
	private void IAAOGAPJDID()
	{
		this.FGGPEEGHGMF = "wpn_cat5" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x002813D2 File Offset: 0x0027F5D2
	private void AOCDDBNBADJ()
	{
		this.FGGPEEGHGMF = "demoQuaternion" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x00281408 File Offset: 0x0027F608
	private void FFIGGPHAIBP()
	{
		this.FGGPEEGHGMF = "1HSwordStrafeRunRight" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x0028143E File Offset: 0x0027F63E
	public void JNEONJLDFME()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("F1", 82f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x0028146B File Offset: 0x0027F66B
	private void OLBDJCFPKFG()
	{
		this.FGGPEEGHGMF = "_FinalBlendParameters" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x002814A1 File Offset: 0x0027F6A1
	public void LDLJJODHHBI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("u_UniqueShadowMatrix", 217f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x002814CE File Offset: 0x0027F6CE
	private void CAJLCEPLKJG()
	{
		this.FGGPEEGHGMF = "WandAttack" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x00281504 File Offset: 0x0027F704
	public void APGADMPGLAD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE(" ", 1279f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x00281540 File Offset: 0x0027F740
	private void DGGMJCMLLED()
	{
		this.FGGPEEGHGMF = "stretchWidth" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005654 RID: 22100 RVA: 0x00281576 File Offset: 0x0027F776
	private void DDEBDCGNCPC()
	{
		this.FGGPEEGHGMF = "invn_rec14" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x002815AC File Offset: 0x0027F7AC
	private void MMACLBBMDLA()
	{
		this.FGGPEEGHGMF = "MotorbikeBackwardSittingCheer" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x002815E2 File Offset: 0x0027F7E2
	private void EFJDBBDMPMC()
	{
		this.FGGPEEGHGMF = "SoccerKeeperDiveStrafeCloseRight" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005657 RID: 22103 RVA: 0x00281618 File Offset: 0x0027F818
	private void LPNDCJKAKEA()
	{
		this.FGGPEEGHGMF = "_CurrentMipLevel" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x0028164E File Offset: 0x0027F84E
	public void KCCKPGOLCII()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("ROPE segments=", 541f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x0028167B File Offset: 0x0027F87B
	private void OFGMIEJKMGC()
	{
		this.FGGPEEGHGMF = "ObscuredByte vs byte, " + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x002816B1 File Offset: 0x0027F8B1
	public void CMKHGOCCEGO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("fider_Small_", 854f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x002816DE File Offset: 0x0027F8DE
	public void CKJMEENNKEO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("]", 1082f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x0028170B File Offset: 0x0027F90B
	public void AOGKJIPOCNJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(" гр ", 655f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x00281738 File Offset: 0x0027F938
	public void GEAKADPAECI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("' that does not excist in the Node Chain.", 878f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600565E RID: 22110 RVA: 0x00281765 File Offset: 0x0027F965
	private void DOHJPDNKALP()
	{
		this.FGGPEEGHGMF = "_AdaptationSpeed" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x0028179B File Offset: 0x0027F99B
	private void CGMHGDEKDEP()
	{
		this.FGGPEEGHGMF = "_SampleCount" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x002817D1 File Offset: 0x0027F9D1
	public void CBCEECHNHDK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("WeaponStrafeRunRight", 1394f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 1);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x002817FE File Offset: 0x0027F9FE
	private void CPNOBMNKPNC()
	{
		this.FGGPEEGHGMF = "\\n" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x00281834 File Offset: 0x0027FA34
	private void MODJFGGIAHD()
	{
		this.FGGPEEGHGMF = "lifeBar" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005663 RID: 22115 RVA: 0x0028186A File Offset: 0x0027FA6A
	public void MAJOPJKAOMF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("isPaint", 1071f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005664 RID: 22116 RVA: 0x00281897 File Offset: 0x0027FA97
	private void OBJCOJEHLBE()
	{
		this.FGGPEEGHGMF = " ms" + this.helpid;
		if (PlayerPrefs.GetInt(this.FGGPEEGHGMF) > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06005665 RID: 22117 RVA: 0x002818CD File Offset: 0x0027FACD
	public void IICEJPGJMCL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("auc_wcstc", 1323f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005666 RID: 22118 RVA: 0x002818FA File Offset: 0x0027FAFA
	public void DBHGCOMNGHI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WRINKLE_MAPS", 1557f);
		PlayerPrefs.SetInt(this.FGGPEEGHGMF, 0);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x04000CFE RID: 3326
	public int helpid = 1;

	// Token: 0x04000CFF RID: 3327
	private string FGGPEEGHGMF;
}
