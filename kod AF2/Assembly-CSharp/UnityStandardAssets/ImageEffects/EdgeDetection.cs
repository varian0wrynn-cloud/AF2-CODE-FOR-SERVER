using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200031F RID: 799
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[ExecuteInEditMode]
	public class EdgeDetection : PostEffectsBase
	{
		// Token: 0x0600B722 RID: 46882 RVA: 0x00519440 File Offset: 0x00517640
		public virtual bool DEKBKNINNFB()
		{
			base.OFKOBOMCECF(true);
			this.OFLDILJIEFA = base.BAPJBHPEDIF(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.BIIAIAKNKBK();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x005194A1 File Offset: 0x005176A1
		private void EHFPLKEINFO()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x005194AF File Offset: 0x005176AF
		private void LBKOIJKMCOL()
		{
			this.AAEMDOEIPMM();
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x005194A1 File Offset: 0x005176A1
		private void HHGGCBLOJGB()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x005194A1 File Offset: 0x005176A1
		private void EHDPACPIBNF()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x005194A1 File Offset: 0x005176A1
		private void INDGOHJGCFN()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x0051951C File Offset: 0x0051771C
		private void CKFGEKLJJGL()
		{
			if (this.mode == EdgeDetection.NPKNIMAACCK.SobelDepthThin || this.mode == (EdgeDetection.NPKNIMAACCK)5)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.MotionVectors;
			}
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x00519574 File Offset: 0x00517774
		private void PJFJCCCCMGJ()
		{
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x005195CC File Offset: 0x005177CC
		private void DEMLPGKODDL()
		{
			if (this.mode == EdgeDetection.NPKNIMAACCK.SobelDepth || this.mode == EdgeDetection.NPKNIMAACCK.SobelDepthThin)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x00519624 File Offset: 0x00517824
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("x", new Vector4(vector.x, vector.y, 781f, vector.y));
			this.OFLDILJIEFA.SetFloat("Pistol", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("u_email", this.sampleDist);
			this.OFLDILJIEFA.SetVector("IK Effector is referencing to a bone '", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat(" ", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("rait_5", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x00519708 File Offset: 0x00517908
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			this.OFLDILJIEFA.SetFloat("_BgFade", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("_SampleDistance", this.sampleDist);
			this.OFLDILJIEFA.SetVector("_BgColor", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("_Exponent", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("_Threshold", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x005197EA File Offset: 0x005179EA
		private void ALHFPHHGIHK()
		{
			this.PJFJCCCCMGJ();
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x005197F2 File Offset: 0x005179F2
		private void INEHANLJIEM()
		{
			this.DEMLPGKODDL();
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x005197FC File Offset: 0x005179FC
		private void MMFGDAKJGLO()
		{
			if (this.mode == (EdgeDetection.NPKNIMAACCK)8 || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x00519853 File Offset: 0x00517A53
		private void LCJGCMFMMFG()
		{
			this.BIIAIAKNKBK();
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x0051985C File Offset: 0x00517A5C
		private void AAEMDOEIPMM()
		{
			if (this.mode == EdgeDetection.NPKNIMAACCK.RobertsCrossDepthNormals || this.mode == (EdgeDetection.NPKNIMAACCK)7)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode)8;
			}
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x005198B3 File Offset: 0x00517AB3
		private void JAFCKIKCHGM()
		{
			this.PKEDKLPOGEA();
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x005198BC File Offset: 0x00517ABC
		public virtual bool FGENCAKNJAI()
		{
			base.OFKOBOMCECF(false);
			this.OFLDILJIEFA = base.DJFOEIJIMJB(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.DEMLPGKODDL();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x005197F2 File Offset: 0x005179F2
		private void EBAJDGLIAPE()
		{
			this.DEMLPGKODDL();
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x005194A1 File Offset: 0x005176A1
		private void AFFAJKPPMHF()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x005198B3 File Offset: 0x00517AB3
		private void HNGLBEOAIHN()
		{
			this.PKEDKLPOGEA();
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x00519920 File Offset: 0x00517B20
		private void PKEDKLPOGEA()
		{
			if (this.mode == (EdgeDetection.NPKNIMAACCK)8 || this.mode == (EdgeDetection.NPKNIMAACCK)7)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x00519978 File Offset: 0x00517B78
		private void BIIAIAKNKBK()
		{
			if (this.mode == (EdgeDetection.NPKNIMAACCK)7 || this.mode == (EdgeDetection.NPKNIMAACCK)5)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
				return;
			}
			if (this.mode == EdgeDetection.NPKNIMAACCK.TriangleDepthNormals || this.mode == EdgeDetection.NPKNIMAACCK.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x005199D0 File Offset: 0x00517BD0
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector(".unity3d", new Vector4(vector.x, vector.y, 22f, vector.y));
			this.OFLDILJIEFA.SetFloat("LINEAR", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("IdleCheer", this.sampleDist);
			this.OFLDILJIEFA.SetVector("No location found baseid=", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("addpar", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("Button", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x005197F2 File Offset: 0x005179F2
		private void OnEnable()
		{
			this.DEMLPGKODDL();
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x00519AB4 File Offset: 0x00517CB4
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("<color='#000000'>{0}</color>", new Vector4(vector.x, vector.y, 1318f, vector.y));
			this.OFLDILJIEFA.SetFloat("repair.ogg", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("Near", this.sampleDist);
			this.OFLDILJIEFA.SetVector("PistolReady", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("Windows/", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("Cowboy1HandDraw", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x005194A1 File Offset: 0x005176A1
		private void CGMHGDEKDEP()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x005197F2 File Offset: 0x005179F2
		private void LAHNGMMPPIM()
		{
			this.DEMLPGKODDL();
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x005194A1 File Offset: 0x005176A1
		private new void Start()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x00519B98 File Offset: 0x00517D98
		public virtual bool LFFHBBCPHJE()
		{
			base.DAOKCAOFIGE(true);
			this.OFLDILJIEFA = base.DJFOEIJIMJB(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.AAEMDOEIPMM();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x00519BFC File Offset: 0x00517DFC
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("#FF4040", new Vector4(vector.x, vector.y, 759f, vector.y));
			this.OFLDILJIEFA.SetFloat("", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("\"{0}\"", this.sampleDist);
			this.OFLDILJIEFA.SetVector("1HandSwordStrafeLeft", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("demoLong", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("Vector2: ", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00519CE0 File Offset: 0x00517EE0
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("(Org: ", new Vector4(vector.x, vector.y, 1811f, vector.y));
			this.OFLDILJIEFA.SetFloat("Worker Pickaxe 2", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("SoccerKeeperReady", this.sampleDist);
			this.OFLDILJIEFA.SetVector("Cloth_01.wav", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("id", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("IdleButtonPress", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x00519DC4 File Offset: 0x00517FC4
		public virtual bool MKPJEDFPGHB()
		{
			base.CDBNBLBOLCL(true);
			this.OFLDILJIEFA = base.BOOFEOGDMBI(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.DEMLPGKODDL();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x005194A1 File Offset: 0x005176A1
		private void CPNOBMNKPNC()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x005194A1 File Offset: 0x005176A1
		private void MCHAAIIHOKD()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x005194A1 File Offset: 0x005176A1
		private void ANHOOJFEJJE()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x00519E28 File Offset: 0x00518028
		public virtual bool CFHOHAOFPIO()
		{
			base.LGANGHEOPOG(false);
			this.OFLDILJIEFA = base.IIIIADNBONI(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.DEMLPGKODDL();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x005194A1 File Offset: 0x005176A1
		private void KEMGOLACEHI()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x00519E8C File Offset: 0x0051808C
		public virtual bool BCBDFDEEILK()
		{
			base.OLMOAHDIDNG(true);
			this.OFLDILJIEFA = base.BAPJBHPEDIF(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.BIIAIAKNKBK();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x005194A1 File Offset: 0x005176A1
		private void NCALLFHEAGJ()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x00519853 File Offset: 0x00517A53
		private void NJCODNNAFEG()
		{
			this.BIIAIAKNKBK();
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x00519EF0 File Offset: 0x005180F0
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.OFLDILJIEFA.SetVector("craft/stanok", new Vector4(vector.x, vector.y, 1849f, vector.y));
			this.OFLDILJIEFA.SetFloat("Чат очищен", this.edgesOnly);
			this.OFLDILJIEFA.SetFloat("_Bloom", this.sampleDist);
			this.OFLDILJIEFA.SetVector("Vector3: ", this.edgesOnlyBgColor);
			this.OFLDILJIEFA.SetFloat("<color='#a060ff'>{0}</color>: {1}", this.edgeExp);
			this.OFLDILJIEFA.SetFloat("FOG_DISTANCE_ON", this.lumThreshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OFLDILJIEFA, (int)this.mode);
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x00519FD4 File Offset: 0x005181D4
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.OFLDILJIEFA = base.DJFOEIJIMJB(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.DEMLPGKODDL();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x005194AF File Offset: 0x005176AF
		private void JIOKDOGNKMI()
		{
			this.AAEMDOEIPMM();
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x0051A038 File Offset: 0x00518238
		public virtual bool OJFBHAHHDNC()
		{
			base.POJDHPJDFEM(false);
			this.OFLDILJIEFA = base.DJFOEIJIMJB(this.edgeDetectShader, this.OFLDILJIEFA);
			if (this.mode != this.BIFFNCLJPHJ)
			{
				this.DEMLPGKODDL();
			}
			this.BIFFNCLJPHJ = this.mode;
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x005194A1 File Offset: 0x005176A1
		private void IMABGALEMBI()
		{
			this.BIFFNCLJPHJ = this.mode;
		}

		// Token: 0x040017E7 RID: 6119
		public EdgeDetection.NPKNIMAACCK mode = EdgeDetection.NPKNIMAACCK.SobelDepthThin;

		// Token: 0x040017E8 RID: 6120
		public float sensitivityDepth = 1f;

		// Token: 0x040017E9 RID: 6121
		public float sensitivityNormals = 1f;

		// Token: 0x040017EA RID: 6122
		public float lumThreshold = 0.2f;

		// Token: 0x040017EB RID: 6123
		public float edgeExp = 1f;

		// Token: 0x040017EC RID: 6124
		public float sampleDist = 1f;

		// Token: 0x040017ED RID: 6125
		public float edgesOnly;

		// Token: 0x040017EE RID: 6126
		public Color edgesOnlyBgColor = Color.white;

		// Token: 0x040017EF RID: 6127
		public Shader edgeDetectShader;

		// Token: 0x040017F0 RID: 6128
		private Material OFLDILJIEFA;

		// Token: 0x040017F1 RID: 6129
		private EdgeDetection.NPKNIMAACCK BIFFNCLJPHJ = EdgeDetection.NPKNIMAACCK.SobelDepthThin;

		// Token: 0x02000320 RID: 800
		public enum NPKNIMAACCK
		{
			// Token: 0x040017F3 RID: 6131
			TriangleDepthNormals,
			// Token: 0x040017F4 RID: 6132
			RobertsCrossDepthNormals,
			// Token: 0x040017F5 RID: 6133
			SobelDepth,
			// Token: 0x040017F6 RID: 6134
			SobelDepthThin,
			// Token: 0x040017F7 RID: 6135
			TriangleLuminance
		}
	}
}
