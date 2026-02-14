using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000323 RID: 803
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		// Token: 0x0600B7B7 RID: 47031 RVA: 0x0051D8E8 File Offset: 0x0051BAE8
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FFADACJLLLI().SetTexture("RenderType", this.textureRamp);
			base.COCHPLKIEGO().SetFloat("Hidden/ACTk/WallHackTexture", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x0051D923 File Offset: 0x0051BB23
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("wpn_hookf", this.textureRamp);
			base.LHMLPBEDDOG().SetFloat("{not_found}", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x0051D95E File Offset: 0x0051BB5E
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.HGIJAMABJMC().SetTexture("R", this.textureRamp);
			base.AGEHKELMAFL().SetFloat("arm", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x0051D999 File Offset: 0x0051BB99
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("_BlurCoe", this.textureRamp);
			base.FIJPFGKEFLJ().SetFloat("error.wav", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DGBBALICMFF());
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x0051D9D4 File Offset: 0x0051BBD4
		private void IOFFNEIOBEL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FIJPFGKEFLJ().SetTexture("money", this.textureRamp);
			base.ALIMBELCEAL().SetFloat("mid", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x0051DA0F File Offset: 0x0051BC0F
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FFADACJLLLI().SetTexture("360SpinDeath", this.textureRamp);
			base.FIJPFGKEFLJ().SetFloat("IceHockeyGoalieReady", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.AGEHKELMAFL());
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x0051DA4A File Offset: 0x0051BC4A
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.EDJPFAGCMOF().SetTexture("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html", this.textureRamp);
			base.HGIJAMABJMC().SetFloat("FOG_EXP", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OEBEDLDCPIN());
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x0051DA85 File Offset: 0x0051BC85
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.NMIDGHFFOBD().SetTexture("_FogWaterLevel", this.textureRamp);
			base.HGIJAMABJMC().SetFloat("ChannelCastOmni", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ALIMBELCEAL());
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x0051DAC0 File Offset: 0x0051BCC0
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MHNAJNGGDFJ.SetTexture("_RampTex", this.textureRamp);
			base.MHNAJNGGDFJ.SetFloat("_RampOffset", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x0051DAFB File Offset: 0x0051BCFB
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.OJKOJOFCLAG().SetTexture("Sound/Ambients/", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("_FresnelFadePower", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DGBBALICMFF());
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x0051DB36 File Offset: 0x0051BD36
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.NMIDGHFFOBD().SetTexture("crft_use", this.textureRamp);
			base.ILEJDOCOINE().SetFloat("wpn_hookf", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.COCHPLKIEGO());
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x0051DB71 File Offset: 0x0051BD71
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DGBBALICMFF().SetTexture("reqperk", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("WpnTemplateMgr is init", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MFJAILMGELI());
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x0051DBAC File Offset: 0x0051BDAC
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture("crft_costwp", this.textureRamp);
			base.DGBBALICMFF().SetFloat("", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MFJAILMGELI());
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x0051DBE7 File Offset: 0x0051BDE7
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ALIMBELCEAL().SetTexture("_BlurRadius4", this.textureRamp);
			base.DJDKHEANJNM().SetFloat("</color>", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.LHMLPBEDDOG());
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x0051DC22 File Offset: 0x0051BE22
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.LHMLPBEDDOG().SetTexture("</color>", this.textureRamp);
			base.AGEHKELMAFL().SetFloat("_EMISSION", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DGBBALICMFF());
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x0051DC5D File Offset: 0x0051BE5D
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MHNAJNGGDFJ.SetTexture(" ", this.textureRamp);
			base.OJKOJOFCLAG().SetFloat("{0}/{1}/{2}", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DJDKHEANJNM());
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x0051DC98 File Offset: 0x0051BE98
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("t_much", this.textureRamp);
			base.OEBEDLDCPIN().SetFloat("Try to change this Vector3 in memory:\n", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x0051DCD3 File Offset: 0x0051BED3
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.HGIJAMABJMC().SetTexture("WoodSaw", this.textureRamp);
			base.ALIMBELCEAL().SetFloat("_TileTexDebug", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x0051DD0E File Offset: 0x0051BF0E
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ILEJDOCOINE().SetTexture("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.textureRamp);
			base.DNCJDOFOENA().SetFloat("level", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.LHMLPBEDDOG());
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x0051DD49 File Offset: 0x0051BF49
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.LHMLPBEDDOG().SetTexture("podsek action!", this.textureRamp);
			base.FIJPFGKEFLJ().SetFloat("<i><color='#202020'>", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DNCJDOFOENA());
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x0051DD84 File Offset: 0x0051BF84
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.COCHPLKIEGO().SetTexture("ZombieCrawl", this.textureRamp);
			base.OJKOJOFCLAG().SetFloat("ZombieCrawl", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.AGEHKELMAFL());
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x0051DDBF File Offset: 0x0051BFBF
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.LHMLPBEDDOG().SetTexture("demoLong", this.textureRamp);
			base.MHNAJNGGDFJ.SetFloat("[maxcnt]", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x0051DDFA File Offset: 0x0051BFFA
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DJDKHEANJNM().SetTexture("GiantGrabThrow2", this.textureRamp);
			base.HGIJAMABJMC().SetFloat("______________________________", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x0051DE35 File Offset: 0x0051C035
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.IOIGFMMJKNA().SetTexture("setCurrentRod curorder=", this.textureRamp);
			base.LHMLPBEDDOG().SetFloat("OneHandSwordRun", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.IOIGFMMJKNA());
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x0051DE70 File Offset: 0x0051C070
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.JFIFDPEHNHO().SetTexture("_WrinkleOcclusionStrengths", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("_UserLut", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x0051DEAB File Offset: 0x0051C0AB
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.IOIGFMMJKNA().SetTexture("_DistortParams", this.textureRamp);
			base.MFJAILMGELI().SetFloat("", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x0051DEE6 File Offset: 0x0051C0E6
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DJDKHEANJNM().SetTexture("_OcclusionBlurTexture", this.textureRamp);
			base.MHNAJNGGDFJ.SetFloat("Label", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x0051DF21 File Offset: 0x0051C121
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture("Move around with WASD or cursor keys, space to jump", this.textureRamp);
			base.MFJAILMGELI().SetFloat("cht_msg1", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FFADACJLLLI());
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x0051DF5C File Offset: 0x0051C15C
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.OJKOJOFCLAG().SetTexture("RunJump", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("{0}+{1}={2}", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x0051DF97 File Offset: 0x0051C197
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.IOIGFMMJKNA().SetTexture("name", this.textureRamp);
			base.ILEJDOCOINE().SetFloat("_DelItem.wav", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.COCHPLKIEGO());
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x0051DFD2 File Offset: 0x0051C1D2
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("FlyRight", this.textureRamp);
			base.DJDKHEANJNM().SetFloat("1HSwordStrafeRunRight", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x0051E00D File Offset: 0x0051C20D
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("rodorder", this.textureRamp);
			base.MFJAILMGELI().SetFloat("fchair", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x0051E048 File Offset: 0x0051C248
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.IOIGFMMJKNA().SetTexture(",", this.textureRamp);
			base.HGIJAMABJMC().SetFloat("Label", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.NMIDGHFFOBD());
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x0051E083 File Offset: 0x0051C283
		private void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MHNAJNGGDFJ.SetTexture("_Curves", this.textureRamp);
			base.AGEHKELMAFL().SetFloat(".unity3d", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x0051E0BE File Offset: 0x0051C2BE
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DGBBALICMFF().SetTexture("IdleStand", this.textureRamp);
			base.ALIMBELCEAL().SetFloat("<color='#100000'>{0} {1}</color>", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DJDKHEANJNM());
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x0051E0F9 File Offset: 0x0051C2F9
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.COCHPLKIEGO().SetTexture("IdleStand", this.textureRamp);
			base.JFIFDPEHNHO().SetFloat("", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x0051E134 File Offset: 0x0051C334
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DJDKHEANJNM().SetTexture("crft_recnt", this.textureRamp);
			base.DIDMFKOIPCF().SetFloat("sortType", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DIDMFKOIPCF());
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x0051E16F File Offset: 0x0051C36F
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.LHMLPBEDDOG().SetTexture("threshold", this.textureRamp);
			base.ALIMBELCEAL().SetFloat("1HandHeavySwing", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x0051E1AA File Offset: 0x0051C3AA
		private void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("CATRigL", this.textureRamp);
			base.AGEHKELMAFL().SetFloat("DepthMaskMaterial", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MFJAILMGELI());
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x0051E1E5 File Offset: 0x0051C3E5
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FIJPFGKEFLJ().SetTexture("name", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("\n", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x0051E220 File Offset: 0x0051C420
		private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FIJPFGKEFLJ().SetTexture("WeaponStrafeRunLeft", this.textureRamp);
			base.MHNAJNGGDFJ.SetFloat("OneHandSwordBackSwing", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B7E1 RID: 47073 RVA: 0x0051E25B File Offset: 0x0051C45B
		private void FEAGGDCEGFE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.NMIDGHFFOBD().SetTexture("</color>", this.textureRamp);
			base.MHNAJNGGDFJ.SetFloat("_UV_Transform", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DIDMFKOIPCF());
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x0051E296 File Offset: 0x0051C496
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FIJPFGKEFLJ().SetTexture("WalkInjured", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("_TempRT", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x0051E2D1 File Offset: 0x0051C4D1
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.NMIDGHFFOBD().SetTexture("</i></color>", this.textureRamp);
			base.MFJAILMGELI().SetFloat("WeaponInstant", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DIDMFKOIPCF());
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x0051E30C File Offset: 0x0051C50C
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.EDJPFAGCMOF().SetTexture("TOD_k4PI", this.textureRamp);
			base.NMIDGHFFOBD().SetFloat("leg", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x0051E347 File Offset: 0x0051C547
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FFADACJLLLI().SetTexture("level", this.textureRamp);
			base.LHMLPBEDDOG().SetFloat("txt", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ALIMBELCEAL());
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x0051E382 File Offset: 0x0051C582
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.", this.textureRamp);
			base.FFADACJLLLI().SetFloat("MotorbikeSeatStandWheely", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x0051E3BD File Offset: 0x0051C5BD
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("", this.textureRamp);
			base.EDJPFAGCMOF().SetFloat("anfish", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DJDKHEANJNM());
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x0051E3F8 File Offset: 0x0051C5F8
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.NMIDGHFFOBD().SetTexture("FONT", this.textureRamp);
			base.MFJAILMGELI().SetFloat("", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FFADACJLLLI());
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x0051E433 File Offset: 0x0051C633
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ILEJDOCOINE().SetTexture("Allows to detect foreign managed assemblies in your application.", this.textureRamp);
			base.OJKOJOFCLAG().SetFloat("FlyLeft", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.NMIDGHFFOBD());
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x0051E46E File Offset: 0x0051C66E
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.OJKOJOFCLAG().SetTexture(" ", this.textureRamp);
			base.MFJAILMGELI().SetFloat("1HSwordStrafeRunRight", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OEBEDLDCPIN());
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x0051E4A9 File Offset: 0x0051C6A9
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.JFIFDPEHNHO().SetTexture("BlendDirection", this.textureRamp);
			base.JFIFDPEHNHO().SetFloat("20", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x0051E4E4 File Offset: 0x0051C6E4
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.OJKOJOFCLAG().SetTexture("priceCr", this.textureRamp);
			base.LHMLPBEDDOG().SetFloat("Assembly-CSharp-firstpass", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.NMIDGHFFOBD());
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x0051E51F File Offset: 0x0051C71F
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("Biped does not seem to be facing it's forward axis. Please make sure that in the initial pose the character is facing towards the positive Z axis of the Biped root gameobject.", this.textureRamp);
			base.DNCJDOFOENA().SetFloat("---", this.rampOffset);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x04001805 RID: 6149
		public Texture textureRamp;

		// Token: 0x04001806 RID: 6150
		[Range(-1f, 1f)]
		public float rampOffset;
	}
}
