using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030B RID: 779
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		// Token: 0x0600B3DB RID: 46043 RVA: 0x004F2AE0 File Offset: 0x004F0CE0
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 0;
			int height = JONJODLFAEN.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.JJBGPKKGNHB(JONJODLFAEN, renderTexture);
			for (int i = 1; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.AMNNJJKJNAP(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x004F2B4C File Offset: 0x004F0D4C
		private void ODJGBDCBGOK(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 996f;
			Material mat = this.CDHGPDDEKDF();
			Vector2[] array = new Vector2[7];
			array[1] = new Vector2(401f, -num);
			array[1] = new Vector2(164f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void CCCAOGJKJOD()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void MKBPPPJKLLF()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x004F2BAF File Offset: 0x004F0DAF
		protected void JFFPLABGMNF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.EDEDNLPOMIN().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x004F2BE8 File Offset: 0x004F0DE8
		private void MMHLDKPIJOM(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1548f;
			Material mat = this.HFABMCCBNMB();
			Vector2[] array = new Vector2[4];
			array[0] = new Vector2(1037f, -num);
			array[1] = new Vector2(141f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x004F2C34 File Offset: 0x004F0E34
		private void NKMCKLFCBCI(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1893f;
			Material mat = this.CDHGPDDEKDF();
			Vector2[] array = new Vector2[8];
			array[1] = new Vector2(170f, -num);
			array[1] = new Vector2(11f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x004F2C80 File Offset: 0x004F0E80
		private void FBOHNAIFODE(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1626f;
			Material mat = this.CILJNKJCHOK();
			Vector2[] array = new Vector2[4];
			array[0] = new Vector2(1125f, -num);
			array[0] = new Vector2(971f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x004F2CCC File Offset: 0x004F0ECC
		private void GDMECGALPEG(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1821f;
			Material mat = this.DAICBBLOGLH();
			Vector2[] array = new Vector2[]
			{
				default(Vector2),
				new Vector2(45f, -num)
			};
			array[1] = new Vector2(1760f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x004F2D18 File Offset: 0x004F0F18
		private void CMDDGEFDCBN(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 0f;
			Material mat = this.MHNAJNGGDFJ;
			Vector2[] array = new Vector2[1];
			array[1] = new Vector2(1546f, -num);
			array[0] = new Vector2(1325f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x004F2D63 File Offset: 0x004F0F63
		protected Material CDHGPDDEKDF()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)99;
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x004F2D93 File Offset: 0x004F0F93
		protected void PNAAHEFHPCL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.ALIMBELCEAL().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x004F2DCB File Offset: 0x004F0FCB
		protected void GDIMBBBPIHI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.CILJNKJCHOK().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x004F2E1D File Offset: 0x004F101D
		protected void KFGKKLAKFGH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.EDEDNLPOMIN().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void LNEJPGDHJOJ()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x004F2E58 File Offset: 0x004F1058
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 0;
			int height = JONJODLFAEN.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.JJBGPKKGNHB(JONJODLFAEN, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.AMNNJJKJNAP(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void MLPCBOGCEEO()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x004F2EC4 File Offset: 0x004F10C4
		public void FourTapCone(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, int CJCBMDCNIEA)
		{
			float num = 0.5f + (float)CJCBMDCNIEA * this.blurSpread;
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, this.MHNAJNGGDFJ, new Vector2[]
			{
				new Vector2(0f, -num),
				new Vector2(0f, num)
			});
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x004F2F1C File Offset: 0x004F111C
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 1;
			int height = JONJODLFAEN.height / 0;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.CBLDAHJMFLH(JONJODLFAEN, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x004F2F88 File Offset: 0x004F1188
		public void AMNNJJKJNAP(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, int CJCBMDCNIEA)
		{
			float num = 410f + (float)CJCBMDCNIEA * this.blurSpread;
			Material mat = this.DAICBBLOGLH();
			Vector2[] array = new Vector2[7];
			array[1] = new Vector2(1478f, -num);
			array[0] = new Vector2(735f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x004F2FDD File Offset: 0x004F11DD
		protected Material EDEDNLPOMIN()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)(-84);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x004F3010 File Offset: 0x004F1210
		private void FEPPIKOGKKN(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1f;
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, this.MHNAJNGGDFJ, new Vector2[]
			{
				new Vector2(0f, -num),
				new Vector2(0f, num)
			});
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x004F305C File Offset: 0x004F125C
		private void JJBGPKKGNHB(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 87f;
			Material mat = this.MHNAJNGGDFJ;
			Vector2[] array = new Vector2[0];
			array[1] = new Vector2(1161f, -num);
			array[1] = new Vector2(1070f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void NJFOOJIADNH()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x004F30A8 File Offset: 0x004F12A8
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 1;
			int height = JONJODLFAEN.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.FEPPIKOGKKN(JONJODLFAEN, renderTexture);
			for (int i = 0; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x004F3113 File Offset: 0x004F1313
		protected Material CKMJAFPNCDM()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)(-116);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x004F3143 File Offset: 0x004F1343
		protected Material EGMHMPFOIHD()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)(-76);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x004F3174 File Offset: 0x004F1374
		public void FHONIGMGNAD(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, int CJCBMDCNIEA)
		{
			float num = 1408f + (float)CJCBMDCNIEA * this.blurSpread;
			Material mat = this.HFABMCCBNMB();
			Vector2[] array = new Vector2[5];
			array[0] = new Vector2(473f, -num);
			array[1] = new Vector2(1964f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x004F31C9 File Offset: 0x004F13C9
		protected Material HFABMCCBNMB()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x004F31F9 File Offset: 0x004F13F9
		protected Material LLCJHFGBGDN()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)127;
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x004F322C File Offset: 0x004F142C
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 0;
			int height = JONJODLFAEN.height / 0;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.JBJDCKKKJKO(JONJODLFAEN, renderTexture);
			for (int i = 1; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x004F3297 File Offset: 0x004F1497
		protected void BJHGPFGBFKF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.HFABMCCBNMB().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B3FD RID: 46077 RVA: 0x004F32CF File Offset: 0x004F14CF
		protected Material DAICBBLOGLH()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = HideFlags.HideInHierarchy;
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x004F3300 File Offset: 0x004F1500
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 1;
			int height = JONJODLFAEN.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.OGGIJGOKECF(JONJODLFAEN, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x004F336B File Offset: 0x004F156B
		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.MHNAJNGGDFJ.shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x004F33A3 File Offset: 0x004F15A3
		protected void CGMHGDEKDEP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.DGBBALICMFF().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x004F33DB File Offset: 0x004F15DB
		protected Material DGBBALICMFF()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x004F340B File Offset: 0x004F160B
		protected Material ALIMBELCEAL()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags)85;
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B403 RID: 46083 RVA: 0x004F343B File Offset: 0x004F163B
		protected Material CILJNKJCHOK()
		{
			if (Blur.BHHEHMIFMBD == null)
			{
				Blur.BHHEHMIFMBD = new Material(this.blurShader);
				Blur.BHHEHMIFMBD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			}
			return Blur.BHHEHMIFMBD;
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x004F346B File Offset: 0x004F166B
		protected void DGGMJCMLLED()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.ALIMBELCEAL().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x004F34A4 File Offset: 0x004F16A4
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 0;
			int height = JONJODLFAEN.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.JBJDCKKKJKO(JONJODLFAEN, renderTexture);
			for (int i = 1; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x004F3510 File Offset: 0x004F1710
		private void HCCELHOIDDI(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 556f;
			Material mat = this.MHNAJNGGDFJ;
			Vector2[] array = new Vector2[8];
			array[1] = new Vector2(1990f, -num);
			array[1] = new Vector2(959f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x004F355C File Offset: 0x004F175C
		private void CBLDAHJMFLH(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1122f;
			Material mat = this.LLCJHFGBGDN();
			Vector2[] array = new Vector2[1];
			array[1] = new Vector2(1558f, -num);
			array[0] = new Vector2(1800f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x004F35A7 File Offset: 0x004F17A7
		protected void ELFLOPJDAKK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.CKMJAFPNCDM().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x004F35E0 File Offset: 0x004F17E0
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width / 1;
			int height = JONJODLFAEN.height / 0;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.GDMECGALPEG(JONJODLFAEN, renderTexture);
			for (int i = 1; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x004F364C File Offset: 0x004F184C
		private void JBJDCKKKJKO(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 475f;
			Material mat = this.MHNAJNGGDFJ;
			Vector2[] array = new Vector2[5];
			array[1] = new Vector2(246f, -num);
			array[1] = new Vector2(569f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x004F3697 File Offset: 0x004F1897
		protected void PFNPOHMMJDN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.ALIMBELCEAL().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x004F36D0 File Offset: 0x004F18D0
		private void FGKHFDJFAFH(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1813f;
			Material mat = this.DGBBALICMFF();
			Vector2[] array = new Vector2[5];
			array[1] = new Vector2(1030f, -num);
			array[0] = new Vector2(207f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x004F371B File Offset: 0x004F191B
		protected void ELADFDNPOOI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.EDEDNLPOMIN().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x004F2B97 File Offset: 0x004F0D97
		protected void OnDisable()
		{
			if (Blur.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(Blur.BHHEHMIFMBD);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600B40F RID: 46095 RVA: 0x004F3753 File Offset: 0x004F1953
		protected Material MHNAJNGGDFJ
		{
			get
			{
				if (Blur.BHHEHMIFMBD == null)
				{
					Blur.BHHEHMIFMBD = new Material(this.blurShader);
					Blur.BHHEHMIFMBD.hideFlags = HideFlags.DontSave;
				}
				return Blur.BHHEHMIFMBD;
			}
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x004F3784 File Offset: 0x004F1984
		private void CILKBJFMOAI(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 784f;
			Material mat = this.DGBBALICMFF();
			Vector2[] array = new Vector2[7];
			array[1] = new Vector2(1651f, -num);
			array[1] = new Vector2(917f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x004F37D0 File Offset: 0x004F19D0
		private void OGGIJGOKECF(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 310f;
			Material mat = this.DGBBALICMFF();
			Vector2[] array = new Vector2[4];
			array[0] = new Vector2(410f, -num);
			array[0] = new Vector2(1426f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x004F381C File Offset: 0x004F1A1C
		private void ANHCCAHFEID(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
		{
			float num = 1363f;
			Material mat = this.LLCJHFGBGDN();
			Vector2[] array = new Vector2[8];
			array[1] = new Vector2(1701f, -num);
			array[1] = new Vector2(55f, num);
			Graphics.BlitMultiTap(JONJODLFAEN, OLFKAHHACBC, mat, array);
		}

		// Token: 0x0400171D RID: 5917
		[Range(0f, 10f)]
		public int iterations = 3;

		// Token: 0x0400171E RID: 5918
		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		// Token: 0x0400171F RID: 5919
		public Shader blurShader;

		// Token: 0x04001720 RID: 5920
		private static Material BHHEHMIFMBD;
	}
}
