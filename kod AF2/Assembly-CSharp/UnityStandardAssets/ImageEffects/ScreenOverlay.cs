using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200032C RID: 812
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		// Token: 0x0600BA83 RID: 47747 RVA: 0x00536B00 File Offset: 0x00534D00
		public virtual bool DEHFEHNMOFH()
		{
			base.EHGENDOEHLP(true);
			this.NHINIBHAGBF = base.BAPJBHPEDIF(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x00536B38 File Offset: 0x00534D38
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(236f, 1086f, 1457f, 1115f);
			this.NHINIBHAGBF.SetVector("WandStand", value);
			this.NHINIBHAGBF.SetFloat("CrouchWalk", this.intensity);
			this.NHINIBHAGBF.SetTexture("enableFog", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x00536BC0 File Offset: 0x00534DC0
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(729f, 1728f, 1205f, 963f);
			this.NHINIBHAGBF.SetVector("pf1m", value);
			this.NHINIBHAGBF.SetFloat("usrto_ignor", this.intensity);
			this.NHINIBHAGBF.SetTexture("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x00536C48 File Offset: 0x00534E48
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1453f, 1817f, 561f, 1323f);
			this.NHINIBHAGBF.SetVector("wpn_wgt", value);
			this.NHINIBHAGBF.SetFloat("", this.intensity);
			this.NHINIBHAGBF.SetTexture("TOD_AmbientColor", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x00536CD0 File Offset: 0x00534ED0
		public virtual bool ENMKIJNFBFF()
		{
			base.EBEBJHLBBBI(true);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x00536D06 File Offset: 0x00534F06
		public virtual bool NCCMOLJNIAB()
		{
			base.OAAFLHNDKBJ(true);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x00536D3C File Offset: 0x00534F3C
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(649f, 1934f, 749f, 907f);
			this.NHINIBHAGBF.SetVector("There is already a virtual axis named ", value);
			this.NHINIBHAGBF.SetFloat("PistolFire", this.intensity);
			this.NHINIBHAGBF.SetTexture("HandPoint", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x00536DC4 File Offset: 0x00534FC4
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1931f, 1859f, 702f, 1444f);
			this.NHINIBHAGBF.SetVector("u_UniqueShadowMatrix", value);
			this.NHINIBHAGBF.SetFloat("IceHockey Goalie Ready", this.intensity);
			this.NHINIBHAGBF.SetTexture("noresult", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x00536E4C File Offset: 0x0053504C
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(860f, 496f, 1815f, 1438f);
			this.NHINIBHAGBF.SetVector("http://af-2.ru/?q=store", value);
			this.NHINIBHAGBF.SetFloat("RollerBladeGrindRoyale", this.intensity);
			this.NHINIBHAGBF.SetTexture("ArmFlex3", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x00536ED4 File Offset: 0x005350D4
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1765f, 1078f, 1805f, 20f);
			this.NHINIBHAGBF.SetVector("UIChat_channel", value);
			this.NHINIBHAGBF.SetFloat("_VelTex", this.intensity);
			this.NHINIBHAGBF.SetTexture("BlendMaterial", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x00536F5C File Offset: 0x0053515C
		private void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(498f, 706f, 773f, 436f);
			this.NHINIBHAGBF.SetVector(" ", value);
			this.NHINIBHAGBF.SetFloat("_WaterLevel", this.intensity);
			this.NHINIBHAGBF.SetTexture("L", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x00536FE4 File Offset: 0x005351E4
		public virtual bool NEOHPOGEHNF()
		{
			base.PKDIKFGAJKM(false);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x0053701C File Offset: 0x0053521C
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(509f, 603f, 1110f, 1682f);
			this.NHINIBHAGBF.SetVector("OnChatMessage", value);
			this.NHINIBHAGBF.SetFloat("wpn_rod2", this.intensity);
			this.NHINIBHAGBF.SetTexture("WATER_SIMPLE", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x005370A4 File Offset: 0x005352A4
		public override bool PKHJBLJFIBF()
		{
			base.OAAFLHNDKBJ(true);
			this.NHINIBHAGBF = base.DJFOEIJIMJB(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x005370DC File Offset: 0x005352DC
		private void IOFFNEIOBEL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1194f, 1368f, 875f, 1725f);
			this.NHINIBHAGBF.SetVector("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", value);
			this.NHINIBHAGBF.SetFloat("gi_um_3", this.intensity);
			this.NHINIBHAGBF.SetTexture("wpn_eat5", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x00537164 File Offset: 0x00535364
		public virtual bool LFFHBBCPHJE()
		{
			base.OFKOBOMCECF(false);
			this.NHINIBHAGBF = base.ALJPMGLOIEG(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x0053719A File Offset: 0x0053539A
		public virtual bool PNMIMCJGPGL()
		{
			base.OAAFLHNDKBJ(false);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x005371D0 File Offset: 0x005353D0
		public virtual bool JKMNILOPECN()
		{
			base.AHFDGALLKFC(false);
			this.NHINIBHAGBF = base.ALJPMGLOIEG(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x00537208 File Offset: 0x00535408
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1337f, 1453f, 287f, 697f);
			this.NHINIBHAGBF.SetVector("GiantGrabThrow2", value);
			this.NHINIBHAGBF.SetFloat("-U", this.intensity);
			this.NHINIBHAGBF.SetTexture("______________________________", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x00537290 File Offset: 0x00535490
		public virtual bool EEGDCIJFLCP()
		{
			base.CDBNBLBOLCL(false);
			this.NHINIBHAGBF = base.JBHLGBPJFEL(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x005372C8 File Offset: 0x005354C8
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(491f, 463f, 1345f, 1360f);
			this.NHINIBHAGBF.SetVector("__c", value);
			this.NHINIBHAGBF.SetFloat("Textures/Noise3", this.intensity);
			this.NHINIBHAGBF.SetTexture("Pistol Quick Stab", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x00537350 File Offset: 0x00535550
		public virtual bool JOAPNOCFFBG()
		{
			base.IDFIHFBEIKD(false);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x00537388 File Offset: 0x00535588
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(332f, 1474f, 1283f, 394f);
			this.NHINIBHAGBF.SetVector("CP3", value);
			this.NHINIBHAGBF.SetFloat("_TempTexture", this.intensity);
			this.NHINIBHAGBF.SetTexture("<.*?>", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x00537410 File Offset: 0x00535610
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(821f, 752f, 986f, 106f);
			this.NHINIBHAGBF.SetVector("Применить", value);
			this.NHINIBHAGBF.SetFloat("invn_rec18", this.intensity);
			this.NHINIBHAGBF.SetTexture("", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x00537498 File Offset: 0x00535698
		public virtual bool NPDBMCCGKEN()
		{
			base.EHGENDOEHLP(false);
			this.NHINIBHAGBF = base.OOAOHFFDMJP(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x005374CE File Offset: 0x005356CE
		public virtual bool NLCKKCKGJDN()
		{
			base.IDFIHFBEIKD(false);
			this.NHINIBHAGBF = base.ALJPMGLOIEG(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x00537504 File Offset: 0x00535704
		private void FEAGGDCEGFE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1971f, 1952f, 281f, 114f);
			this.NHINIBHAGBF.SetVector("OneHandSwordBlock", value);
			this.NHINIBHAGBF.SetFloat("ShootRaycastModule", this.intensity);
			this.NHINIBHAGBF.SetTexture("BC", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BA9E RID: 47774 RVA: 0x0053758C File Offset: 0x0053578C
		public virtual bool FLJEDBINFJC()
		{
			base.OFKOBOMCECF(false);
			this.NHINIBHAGBF = base.OOAOHFFDMJP(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BA9F RID: 47775 RVA: 0x005375C2 File Offset: 0x005357C2
		public virtual bool KCGEMCLLBHM()
		{
			base.MGHNCKDCFGL(true);
			this.NHINIBHAGBF = base.OOAOHFFDMJP(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x005375F8 File Offset: 0x005357F8
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(923f, 1062f, 1946f, 289f);
			this.NHINIBHAGBF.SetVector("act_orderb_", value);
			this.NHINIBHAGBF.SetFloat("wgt_gr", this.intensity);
			this.NHINIBHAGBF.SetTexture("ShotgunReloadChamber", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x00537680 File Offset: 0x00535880
		private void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(720f, 360f, 1883f, 437f);
			this.NHINIBHAGBF.SetVector("\nу вас есть ", value);
			this.NHINIBHAGBF.SetFloat("", this.intensity);
			this.NHINIBHAGBF.SetTexture("Forward", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x00537708 File Offset: 0x00535908
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.NHINIBHAGBF = base.DJFOEIJIMJB(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x0053773E File Offset: 0x0053593E
		public virtual bool NAEJFOJDLCC()
		{
			base.OAAFLHNDKBJ(true);
			this.NHINIBHAGBF = base.OOAOHFFDMJP(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x00537774 File Offset: 0x00535974
		private void LGKJKHBJFCP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(182f, 890f, 1587f, 1615f);
			this.NHINIBHAGBF.SetVector("Adjust", value);
			this.NHINIBHAGBF.SetFloat("GestureHandUp", this.intensity);
			this.NHINIBHAGBF.SetTexture("CraftProf.xml", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x005377FC File Offset: 0x005359FC
		public virtual bool HMDBGMDFHKH()
		{
			base.OFKOBOMCECF(false);
			this.NHINIBHAGBF = base.BAPJBHPEDIF(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x00537834 File Offset: 0x00535A34
		private void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(114f, 801f, 0f, 1023f);
			this.NHINIBHAGBF.SetVector("Refractive", value);
			this.NHINIBHAGBF.SetFloat("Injection Detected! Cause: ", this.intensity);
			this.NHINIBHAGBF.SetTexture("CCDIK not found!", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAA7 RID: 47783 RVA: 0x005378BC File Offset: 0x00535ABC
		public virtual bool FCIOAHEKFIG()
		{
			base.EHGENDOEHLP(true);
			this.NHINIBHAGBF = base.JBHLGBPJFEL(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x005378F2 File Offset: 0x00535AF2
		public virtual bool CKLDIKPLCAO()
		{
			base.CGEGCOKMPHN(true);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x00537928 File Offset: 0x00535B28
		private void LCPJGMMINPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(330f, 511f, 720f, 542f);
			this.NHINIBHAGBF.SetVector("vp", value);
			this.NHINIBHAGBF.SetFloat("UIChat_channel", this.intensity);
			this.NHINIBHAGBF.SetTexture("wpn_fid1", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAAA RID: 47786 RVA: 0x005379B0 File Offset: 0x00535BB0
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(610f, 1072f, 1861f, 1583f);
			this.NHINIBHAGBF.SetVector("\n", value);
			this.NHINIBHAGBF.SetFloat("1HandSwordChargeUp", this.intensity);
			this.NHINIBHAGBF.SetTexture("' that does not excist in the Node Chain.", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAAB RID: 47787 RVA: 0x00537A38 File Offset: 0x00535C38
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(948f, 1212f, 466f, 130f);
			this.NHINIBHAGBF.SetVector("ShootWireframeModule", value);
			this.NHINIBHAGBF.SetFloat("showMetrInfo", this.intensity);
			this.NHINIBHAGBF.SetTexture("<color='#602060'>", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x00537AC0 File Offset: 0x00535CC0
		public virtual bool NOKBDMCHHHJ()
		{
			base.EBEBJHLBBBI(true);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x00537AF6 File Offset: 0x00535CF6
		public virtual bool DHBPAOGJPFE()
		{
			base.OFKOBOMCECF(false);
			this.NHINIBHAGBF = base.ALJPMGLOIEG(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x00537B2C File Offset: 0x00535D2C
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(446f, 1989f, 206f, 1561f);
			this.NHINIBHAGBF.SetVector("_SharpenParameters", value);
			this.NHINIBHAGBF.SetFloat("Mech", this.intensity);
			this.NHINIBHAGBF.SetTexture("FactoryTempTexture", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x00537BB4 File Offset: 0x00535DB4
		public virtual bool CPIFBHFDEFO()
		{
			base.MGHNCKDCFGL(false);
			this.NHINIBHAGBF = base.DJFOEIJIMJB(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x00537BEC File Offset: 0x00535DEC
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(955f, 170f, 796f, 1188f);
			this.NHINIBHAGBF.SetVector("readTurnir STATUS", value);
			this.NHINIBHAGBF.SetFloat("R", this.intensity);
			this.NHINIBHAGBF.SetTexture("", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x00537C74 File Offset: 0x00535E74
		public virtual bool BGDALDCKGKM()
		{
			base.LGANGHEOPOG(true);
			this.NHINIBHAGBF = base.BAPJBHPEDIF(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x00537CAC File Offset: 0x00535EAC
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			this.NHINIBHAGBF.SetVector("_UV_Transform", value);
			this.NHINIBHAGBF.SetFloat("_Intensity", this.intensity);
			this.NHINIBHAGBF.SetTexture("_Overlay", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x00537D34 File Offset: 0x00535F34
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1161f, 787f, 929f, 1617f);
			this.NHINIBHAGBF.SetVector("Criticals", value);
			this.NHINIBHAGBF.SetFloat("from prefab", this.intensity);
			this.NHINIBHAGBF.SetTexture("CrouchWalk", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x00537DBC File Offset: 0x00535FBC
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(794f, 981f, 637f, 1709f);
			this.NHINIBHAGBF.SetVector("msg from NET channel=", value);
			this.NHINIBHAGBF.SetFloat("GiantGrabIdle", this.intensity);
			this.NHINIBHAGBF.SetTexture("Smoking1", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x00537E44 File Offset: 0x00536044
		public virtual bool BGNOLJBJGEL()
		{
			base.EHGENDOEHLP(true);
			this.NHINIBHAGBF = base.DJFOEIJIMJB(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x00537E7C File Offset: 0x0053607C
		private void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(663f, 490f, 759f, 377f);
			this.NHINIBHAGBF.SetVector("WorkerHammer2", value);
			this.NHINIBHAGBF.SetFloat("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this.intensity);
			this.NHINIBHAGBF.SetTexture("Cheer Jump", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x00537F04 File Offset: 0x00536104
		public virtual bool FGENCAKNJAI()
		{
			base.MGHNCKDCFGL(true);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x00537F3C File Offset: 0x0053613C
		private void MFEOIGILLPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(161f, 13f, 248f, 500f);
			this.NHINIBHAGBF.SetVector("Yawn", value);
			this.NHINIBHAGBF.SetFloat("StrafeRunLeft", this.intensity);
			this.NHINIBHAGBF.SetTexture("Invalid ObscuredVector3 index!", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x00537FC4 File Offset: 0x005361C4
		private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(765f, 1269f, 1469f, 366f);
			this.NHINIBHAGBF.SetVector("[maxcnt]", value);
			this.NHINIBHAGBF.SetFloat("gi_um_nt", this.intensity);
			this.NHINIBHAGBF.SetTexture("DealerShuffle", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x0053804C File Offset: 0x0053624C
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(438f, 1494f, 287f, 71f);
			this.NHINIBHAGBF.SetVector("RunBackward", value);
			this.NHINIBHAGBF.SetFloat("BowFire2", this.intensity);
			this.NHINIBHAGBF.SetTexture("Vertical", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x005380D4 File Offset: 0x005362D4
		private void CONNCGCNJPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1562f, 571f, 212f, 228f);
			this.NHINIBHAGBF.SetVector("Below you can try to cheat both regular PlayerPrefs and secure ObscuredPrefs:", value);
			this.NHINIBHAGBF.SetFloat("IKSolverLookAt head transform is null. Can't initiate solver.", this.intensity);
			this.NHINIBHAGBF.SetTexture("Jump", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x0053815C File Offset: 0x0053635C
		private void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1874f, 1011f, 1287f, 482f);
			this.NHINIBHAGBF.SetVector("", value);
			this.NHINIBHAGBF.SetFloat("lastRatingIndex", this.intensity);
			this.NHINIBHAGBF.SetTexture("crft_from", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x005381E4 File Offset: 0x005363E4
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1014f, 166f, 421f, 48f);
			this.NHINIBHAGBF.SetVector("offsets", value);
			this.NHINIBHAGBF.SetFloat("Crouch Strafe Left", this.intensity);
			this.NHINIBHAGBF.SetTexture("SteamPay error:", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x0053826C File Offset: 0x0053646C
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(466f, 1778f, 961f, 344f);
			this.NHINIBHAGBF.SetVector("", value);
			this.NHINIBHAGBF.SetFloat(" ", this.intensity);
			this.NHINIBHAGBF.SetTexture("_History4Weight", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x005382F4 File Offset: 0x005364F4
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1631f, 311f, 316f, 1716f);
			this.NHINIBHAGBF.SetVector("IdleMeditate", value);
			this.NHINIBHAGBF.SetFloat("fishwgt", this.intensity);
			this.NHINIBHAGBF.SetTexture("BowIdle", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x0053837C File Offset: 0x0053657C
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(142f, 650f, 464f, 718f);
			this.NHINIBHAGBF.SetVector("inv_minreq", value);
			this.NHINIBHAGBF.SetFloat("ignorelist", this.intensity);
			this.NHINIBHAGBF.SetTexture("GestureHandUp", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAC1 RID: 47809 RVA: 0x00538404 File Offset: 0x00536604
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(156f, 1871f, 1222f, 1584f);
			this.NHINIBHAGBF.SetVector("crft_from", value);
			this.NHINIBHAGBF.SetFloat("UIChat_fontInterval", this.intensity);
			this.NHINIBHAGBF.SetTexture("IKSolverLookAt head transform is null. Can't initiate solver.", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x0053848C File Offset: 0x0053668C
		public virtual bool DPGLLLMLAAB()
		{
			base.OAAFLHNDKBJ(false);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAC3 RID: 47811 RVA: 0x005384C2 File Offset: 0x005366C2
		public virtual bool KKLBJANNNOH()
		{
			base.CBJDCDELBJN(true);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x005384F8 File Offset: 0x005366F8
		public virtual bool POCBDMNELOB()
		{
			base.MGHNCKDCFGL(false);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x00538530 File Offset: 0x00536730
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1397f, 1142f, 1863f, 947f);
			this.NHINIBHAGBF.SetVector("start.ogg", value);
			this.NHINIBHAGBF.SetFloat(" ", this.intensity);
			this.NHINIBHAGBF.SetTexture("http://docs.unity3d.com/ScriptReference/PlayerPrefs.html", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAC6 RID: 47814 RVA: 0x005385B8 File Offset: 0x005367B8
		public virtual bool NENLAEOGCBK()
		{
			base.DAOKCAOFIGE(false);
			this.NHINIBHAGBF = base.ALJPMGLOIEG(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x005385F0 File Offset: 0x005367F0
		private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1506f, 1692f, 526f, 263f);
			this.NHINIBHAGBF.SetVector(" value=", value);
			this.NHINIBHAGBF.SetFloat("ScatterIntensityVolumeSky", this.intensity);
			this.NHINIBHAGBF.SetTexture("13", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x00538678 File Offset: 0x00536878
		public virtual bool NOCHDCDPIID()
		{
			base.CDBNBLBOLCL(false);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x005386B0 File Offset: 0x005368B0
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1219f, 182f, 1303f, 1069f);
			this.NHINIBHAGBF.SetVector("FOVKick Increase curve is null, please define the curve for the field of view kicks", value);
			this.NHINIBHAGBF.SetFloat("error", this.intensity);
			this.NHINIBHAGBF.SetTexture("Failed parsing scalePlacement.  Setting to \"Fixed\"", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x00538738 File Offset: 0x00536938
		public virtual bool LKFFFIBABBF()
		{
			base.LGANGHEOPOG(false);
			this.NHINIBHAGBF = base.OOAOHFFDMJP(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x0053876E File Offset: 0x0053696E
		public virtual bool CFODPFPIHIF()
		{
			base.AHFDGALLKFC(false);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BACC RID: 47820 RVA: 0x005387A4 File Offset: 0x005369A4
		private void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1839f, 164f, 1820f, 489f);
			this.NHINIBHAGBF.SetVector(" ", value);
			this.NHINIBHAGBF.SetFloat("ZombieCrawl", this.intensity);
			this.NHINIBHAGBF.SetTexture(" ", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BACD RID: 47821 RVA: 0x0053882C File Offset: 0x00536A2C
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(163f, 418f, 525f, 133f);
			this.NHINIBHAGBF.SetVector("IdleMeditate", value);
			this.NHINIBHAGBF.SetFloat("", this.intensity);
			this.NHINIBHAGBF.SetTexture(")?", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x005388B4 File Offset: 0x00536AB4
		public virtual bool EPOEAKJPIEE()
		{
			base.EHGENDOEHLP(false);
			this.NHINIBHAGBF = base.IIIIADNBONI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BACF RID: 47823 RVA: 0x005388EC File Offset: 0x00536AEC
		private void NALFGGIMOLN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(345f, 407f, 419f, 1099f);
			this.NHINIBHAGBF.SetVector("FistPump", value);
			this.NHINIBHAGBF.SetFloat("", this.intensity);
			this.NHINIBHAGBF.SetTexture("Zombie Idle 2", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD0 RID: 47824 RVA: 0x00538974 File Offset: 0x00536B74
		public virtual bool APNCPMNHKOG()
		{
			base.NHCAHIHJHMF(true);
			this.NHINIBHAGBF = base.BAPJBHPEDIF(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAD1 RID: 47825 RVA: 0x005389AC File Offset: 0x00536BAC
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1130f, 336f, 1870f, 1468f);
			this.NHINIBHAGBF.SetVector("_EmissionColor", value);
			this.NHINIBHAGBF.SetFloat("MotorbikeLassoRight", this.intensity);
			this.NHINIBHAGBF.SetTexture("IdleButtonPress", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x00538A34 File Offset: 0x00536C34
		public virtual bool HGBPBGGAFOP()
		{
			base.EHGENDOEHLP(false);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x00538A84 File Offset: 0x00536C84
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1221f, 1339f, 1216f, 1298f);
			this.NHINIBHAGBF.SetVector("_MaxCoC", value);
			this.NHINIBHAGBF.SetFloat("Flap_02.wav", this.intensity);
			this.NHINIBHAGBF.SetTexture(",", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x00538B0C File Offset: 0x00536D0C
		public virtual bool JCCFBJBBHBP()
		{
			base.POJDHPJDFEM(true);
			this.NHINIBHAGBF = base.BAPJBHPEDIF(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x00538B44 File Offset: 0x00536D44
		private void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1652f, 1377f, 1269f, 1220f);
			this.NHINIBHAGBF.SetVector("MotorbikeShootLeft", value);
			this.NHINIBHAGBF.SetFloat("SUNSHINE_FILTER_HARD", this.intensity);
			this.NHINIBHAGBF.SetTexture("WalkDehydrated", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x00538BCC File Offset: 0x00536DCC
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(451f, 1372f, 1933f, 1021f);
			this.NHINIBHAGBF.SetVector("soft", value);
			this.NHINIBHAGBF.SetFloat("SixStep", this.intensity);
			this.NHINIBHAGBF.SetTexture("Staff Heal", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x00538C54 File Offset: 0x00536E54
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(1424f, 1361f, 920f, 569f);
			this.NHINIBHAGBF.SetVector(".unity3d", value);
			this.NHINIBHAGBF.SetFloat("FlyForward", this.intensity);
			this.NHINIBHAGBF.SetTexture("invn_rec3", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x00538CDC File Offset: 0x00536EDC
		public virtual bool POKDAEAADAC()
		{
			base.EBEBJHLBBBI(true);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x00538D14 File Offset: 0x00536F14
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(859f, 1618f, 1449f, 1953f);
			this.NHINIBHAGBF.SetVector("error.wav", value);
			this.NHINIBHAGBF.SetFloat("", this.intensity);
			this.NHINIBHAGBF.SetTexture("Materials/DFGOnlyFog", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x00538D9C File Offset: 0x00536F9C
		public virtual bool CHJBCBDIBJJ()
		{
			base.CGEGCOKMPHN(true);
			this.NHINIBHAGBF = base.BOOFEOGDMBI(this.overlayShader, this.NHINIBHAGBF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x00538DD4 File Offset: 0x00536FD4
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector4 value = new Vector4(170f, 1752f, 848f, 384f);
			this.NHINIBHAGBF.SetVector("Hair", value);
			this.NHINIBHAGBF.SetFloat("IceHockey Pass Right", this.intensity);
			this.NHINIBHAGBF.SetTexture(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", this.texture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NHINIBHAGBF, (int)this.blendMode);
		}

		// Token: 0x04001836 RID: 6198
		public ScreenOverlay.LJPHJFIDMOA blendMode = ScreenOverlay.LJPHJFIDMOA.Overlay;

		// Token: 0x04001837 RID: 6199
		public float intensity = 1f;

		// Token: 0x04001838 RID: 6200
		public Texture2D texture;

		// Token: 0x04001839 RID: 6201
		public Shader overlayShader;

		// Token: 0x0400183A RID: 6202
		private Material NHINIBHAGBF;

		// Token: 0x0200032D RID: 813
		public enum LJPHJFIDMOA
		{
			// Token: 0x0400183C RID: 6204
			Additive,
			// Token: 0x0400183D RID: 6205
			ScreenBlend,
			// Token: 0x0400183E RID: 6206
			Multiply,
			// Token: 0x0400183F RID: 6207
			Overlay,
			// Token: 0x04001840 RID: 6208
			AlphaBlend
		}
	}
}
