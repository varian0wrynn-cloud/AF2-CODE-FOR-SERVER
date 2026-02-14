using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000313 RID: 787
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		// Token: 0x0600B5DF RID: 46559 RVA: 0x00509AD7 File Offset: 0x00507CD7
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MHNAJNGGDFJ.SetTexture("_RampTex", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MHNAJNGGDFJ);
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x00509AFC File Offset: 0x00507CFC
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture("CratePush", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x00509B21 File Offset: 0x00507D21
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ALIMBELCEAL().SetTexture("wpn_med2", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.LHMLPBEDDOG());
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x00509B46 File Offset: 0x00507D46
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.OEBEDLDCPIN().SetTexture("_Color", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x00509B6B File Offset: 0x00507D6B
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("human_move_2.wav", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MFJAILMGELI());
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x00509B90 File Offset: 0x00507D90
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DGBBALICMFF().SetTexture(" ms", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x00509BB5 File Offset: 0x00507DB5
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture("donk.ogg", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.MFJAILMGELI());
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x00509BDA File Offset: 0x00507DDA
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DIDMFKOIPCF().SetTexture("SoccerRun", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OJKOJOFCLAG());
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x00509BFF File Offset: 0x00507DFF
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DIDMFKOIPCF().SetTexture("cntx_razb", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x00509C24 File Offset: 0x00507E24
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("_Params2", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DIDMFKOIPCF());
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x00509C49 File Offset: 0x00507E49
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DIDMFKOIPCF().SetTexture("Применить", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x00509C6E File Offset: 0x00507E6E
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.IOIGFMMJKNA().SetTexture("WorkerShovel2", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x00509C93 File Offset: 0x00507E93
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.JFIFDPEHNHO().SetTexture("Flashlight", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OJKOJOFCLAG());
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x00509CB8 File Offset: 0x00507EB8
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.EDJPFAGCMOF().SetTexture(" has invalid children array. Child index > number of chains", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.COCHPLKIEGO());
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x00509CDD File Offset: 0x00507EDD
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture(" шт", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.NMIDGHFFOBD());
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x00509D02 File Offset: 0x00507F02
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DNCJDOFOENA().SetTexture("max_level", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x00509D27 File Offset: 0x00507F27
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("_isSelect", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x00509D4C File Offset: 0x00507F4C
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DGBBALICMFF().SetTexture("3", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x00509D71 File Offset: 0x00507F71
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FFADACJLLLI().SetTexture("CardPlayerIdle", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.LHMLPBEDDOG());
		}

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x00509D96 File Offset: 0x00507F96
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("demoByteArray", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x00509DBB File Offset: 0x00507FBB
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.LHMLPBEDDOG().SetTexture("IdleSpew", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x00509DE0 File Offset: 0x00507FE0
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.DGBBALICMFF().SetTexture("BowReady2", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OJKOJOFCLAG());
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x00509E05 File Offset: 0x00508005
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ALIMBELCEAL().SetTexture("", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.HGIJAMABJMC());
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x00509E2A File Offset: 0x0050802A
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MHNAJNGGDFJ.SetTexture("BowReady", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.EDJPFAGCMOF());
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x00509E4F File Offset: 0x0050804F
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.JFIFDPEHNHO().SetTexture("{0} / {1}", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OEBEDLDCPIN());
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x00509E74 File Offset: 0x00508074
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("DealerFan", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x00509E99 File Offset: 0x00508099
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.HGIJAMABJMC().SetTexture("null", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.OJKOJOFCLAG());
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x00509EBE File Offset: 0x005080BE
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.FFADACJLLLI().SetTexture("Adjust", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.FIJPFGKEFLJ());
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x00509EE3 File Offset: 0x005080E3
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.ALIMBELCEAL().SetTexture("cap", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.ILEJDOCOINE());
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x00509F08 File Offset: 0x00508108
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.MFJAILMGELI().SetTexture("hp", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.DJDKHEANJNM());
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x00509F2D File Offset: 0x0050812D
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			base.AGEHKELMAFL().SetTexture("sunshine_OvercastCoord", this.textureRamp);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, base.JFIFDPEHNHO());
		}

		// Token: 0x0400176F RID: 5999
		public Texture textureRamp;
	}
}
