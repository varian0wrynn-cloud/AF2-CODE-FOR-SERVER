using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000326 RID: 806
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		// Token: 0x0600B871 RID: 47217 RVA: 0x0051F5CC File Offset: 0x0051D7CC
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LIPFDLLKECG.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 3, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1794f, 389f);
			base.FFADACJLLLI().SetTexture("wpn_fid2", this.LIPFDLLKECG);
			base.JFIFDPEHNHO().SetFloat("Account.getI.servSteamID=", 1531f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.ALIMBELCEAL());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x0051F707 File Offset: 0x0051D907
		protected virtual void JKDCKHECHEJ()
		{
			base.ACJNCDAHJDE();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x0051F71A File Offset: 0x0051D91A
		protected virtual void LAFIABNCFPD()
		{
			base.MKLCOEALFBI();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x0051F72D File Offset: 0x0051D92D
		protected virtual void BMNJGPIPKLL()
		{
			base.MKNPFMEMOJO();
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x0051F735 File Offset: 0x0051D935
		protected override void ANHOOJFEJJE()
		{
			base.ANHOOJFEJJE();
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x0051F73D File Offset: 0x0051D93D
		protected virtual void DGEIACONKCJ()
		{
			base.DDEBDCGNCPC();
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x0051F748 File Offset: 0x0051D948
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LIPFDLLKECG.hideFlags = ~HideFlags.DontSaveInBuild;
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 6, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1063f, 231f);
			base.COCHPLKIEGO().SetTexture("offsets", this.LIPFDLLKECG);
			base.ILEJDOCOINE().SetFloat("wpn_bait1", 1359f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.EDJPFAGCMOF());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x0051F884 File Offset: 0x0051DA84
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 5, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1130f, 721f);
			base.OJKOJOFCLAG().SetTexture("\n", this.LIPFDLLKECG);
			base.DGBBALICMFF().SetFloat("wpn_add/base", 1404f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.MHNAJNGGDFJ);
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x0051F9BF File Offset: 0x0051DBBF
		protected override void PIPJPGGEFOL()
		{
			base.DFLLLNDKNBB();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x0051F9D2 File Offset: 0x0051DBD2
		protected override void PFNPOHMMJDN()
		{
			base.EFJDBBDMPMC();
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x0051F9DC File Offset: 0x0051DBDC
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = HideFlags.DontUnloadUnusedAsset;
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 2, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1906f, 1330f);
			base.OJKOJOFCLAG().SetTexture("; ", this.LIPFDLLKECG);
			base.DGBBALICMFF().SetFloat("", 313f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.DGBBALICMFF());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x0051FB18 File Offset: 0x0051DD18
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LIPFDLLKECG.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 7, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1737f, 446f);
			base.HGIJAMABJMC().SetTexture("wpn_add/base", this.LIPFDLLKECG);
			base.OJKOJOFCLAG().SetFloat("sunshine_OvercastCoord", 929f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.AGEHKELMAFL());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x0051FC53 File Offset: 0x0051DE53
		protected virtual void IICFAPMJLCN()
		{
			base.PCKEAEAHAKG();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x0051FC7C File Offset: 0x0051DE7C
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags)125;
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 1, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1302f, 1054f);
			base.NMIDGHFFOBD().SetTexture("maxspd", this.LIPFDLLKECG);
			base.ILEJDOCOINE().SetFloat("exitmsg_1", 1450f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.DIDMFKOIPCF());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x0051FDB7 File Offset: 0x0051DFB7
		protected override void PHIACAJNNIG()
		{
			base.LNNKANCIIFM();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x0051FDCA File Offset: 0x0051DFCA
		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x0051FDE0 File Offset: 0x0051DFE0
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 8, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1875f, 1257f);
			base.DJDKHEANJNM().SetTexture("Noise shaders are not set up! Disabling noise effect.", this.LIPFDLLKECG);
			base.AGEHKELMAFL().SetFloat("Worker Shovel 2", 1003f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.NMIDGHFFOBD());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x0051FF1C File Offset: 0x0051E11C
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 7, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 793f, 540f);
			base.EDJPFAGCMOF().SetTexture("]", this.LIPFDLLKECG);
			base.NMIDGHFFOBD().SetFloat("auk_wset", 1235f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.MHNAJNGGDFJ);
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x00520057 File Offset: 0x0051E257
		protected override void NCALLFHEAGJ()
		{
			base.CAJLCEPLKJG();
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x00520060 File Offset: 0x0051E260
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LIPFDLLKECG.hideFlags = (HideFlags)98;
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 6, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1157f, 1987f);
			base.AGEHKELMAFL().SetTexture("OfficeSittingHandRestFingerTap", this.LIPFDLLKECG);
			base.NMIDGHFFOBD().SetFloat("StrafeRunLeft", 1056f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.MHNAJNGGDFJ);
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x0052019C File Offset: 0x0051E39C
		private void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 1, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 759f, 789f);
			base.HGIJAMABJMC().SetTexture("400000", this.LIPFDLLKECG);
			base.FFADACJLLLI().SetFloat("CratePush", 617f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.FFADACJLLLI());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x005202D7 File Offset: 0x0051E4D7
		protected override void DFLLLNDKNBB()
		{
			base.GPCIBDPEAAE();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x005202EC File Offset: 0x0051E4EC
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 0f, 0.92f);
			base.MHNAJNGGDFJ.SetTexture("_MainTex", this.LIPFDLLKECG);
			base.MHNAJNGGDFJ.SetFloat("_AccumOrig", 1f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.MHNAJNGGDFJ);
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x0051F9BF File Offset: 0x0051DBBF
		protected virtual void AHMFIGNLJOB()
		{
			base.DFLLLNDKNBB();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x00520427 File Offset: 0x0051E627
		protected virtual void PCKOPPKGENK()
		{
			base.GBAEKFJBEFM();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x0052043A File Offset: 0x0051E63A
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x00520444 File Offset: 0x0051E644
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 0, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 527f, 1599f);
			base.HGIJAMABJMC().SetTexture("1 Hand Sword Roll Attack", this.LIPFDLLKECG);
			base.ALIMBELCEAL().SetFloat("{{{0:F2}, {1:F2}, {2:F2}}}", 1021f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.HGIJAMABJMC());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x00520427 File Offset: 0x0051E627
		protected override void BNOLDFLILJA()
		{
			base.GBAEKFJBEFM();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x00520580 File Offset: 0x0051E780
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 8, 0);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 709f, 1479f);
			base.OJKOJOFCLAG().SetTexture("IdleRun", this.LIPFDLLKECG);
			base.FFADACJLLLI().SetFloat("Mouse Y", 512f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.IOIGFMMJKNA());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x005206BC File Offset: 0x0051E8BC
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 1, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 511f, 1839f);
			base.LHMLPBEDDOG().SetTexture("?", this.LIPFDLLKECG);
			base.AGEHKELMAFL().SetFloat("21,22,23", 543f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.EDJPFAGCMOF());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x005207F8 File Offset: 0x0051E9F8
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 2, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 259f, 1049f);
			base.OEBEDLDCPIN().SetTexture("", this.LIPFDLLKECG);
			base.FIJPFGKEFLJ().SetFloat("TextureLoaderCoroutine", 1425f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.OJKOJOFCLAG());
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x00520933 File Offset: 0x0051EB33
		protected virtual void GMJFHNCPCBN()
		{
			base.DENHKOPGLDK();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x00520946 File Offset: 0x0051EB46
		protected virtual void HDFCIACDDEK()
		{
			base.EHDPACPIBNF();
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x00520946 File Offset: 0x0051EB46
		protected virtual void EDGALMCHPPH()
		{
			base.EHDPACPIBNF();
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x0052094E File Offset: 0x0051EB4E
		protected override void LKGIJBLNANI()
		{
			base.ACEEIODKKBE();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x00520961 File Offset: 0x0051EB61
		protected override void APJACOJADAF()
		{
			base.NIOMOLMCNOO();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x00520974 File Offset: 0x0051EB74
		protected virtual void DNBMNPKDPHC()
		{
			base.BNOLDFLILJA();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x00520988 File Offset: 0x0051EB88
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.LIPFDLLKECG == null || this.LIPFDLLKECG.width != JONJODLFAEN.width || this.LIPFDLLKECG.height != JONJODLFAEN.height)
			{
				UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
				this.LIPFDLLKECG = new RenderTexture(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LIPFDLLKECG.hideFlags = (HideFlags)(-71);
				Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 4, 1);
				this.LIPFDLLKECG.MarkRestoreExpected();
				Graphics.Blit(this.LIPFDLLKECG, temporary);
				Graphics.Blit(temporary, this.LIPFDLLKECG);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1152f, 868f);
			base.DNCJDOFOENA().SetTexture("HDR", this.LIPFDLLKECG);
			base.ILEJDOCOINE().SetFloat("Current fog preset: ", 398f - this.blurAmount);
			this.LIPFDLLKECG.MarkRestoreExpected();
			Graphics.Blit(JONJODLFAEN, this.LIPFDLLKECG, base.MHNAJNGGDFJ);
			Graphics.Blit(this.LIPFDLLKECG, OKIIDHIJBEA);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x00520AC3 File Offset: 0x0051ECC3
		protected override void DENHKOPGLDK()
		{
			base.LNEJPGDHJOJ();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x00520AD6 File Offset: 0x0051ECD6
		protected virtual void BABMAHFKPMO()
		{
			base.LKGIJBLNANI();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x00520AE9 File Offset: 0x0051ECE9
		protected virtual void PMDPLLIBJAF()
		{
			base.BJHGPFGBFKF();
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x00520974 File Offset: 0x0051EB74
		protected virtual void LLLBNNNNFPJ()
		{
			base.BNOLDFLILJA();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x00520AF1 File Offset: 0x0051ECF1
		protected virtual void HHGGCBLOJGB()
		{
			base.NCALLFHEAGJ();
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x0051F9BF File Offset: 0x0051DBBF
		protected override void EILDKNMOKBB()
		{
			base.DFLLLNDKNBB();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x00520AF9 File Offset: 0x0051ECF9
		protected override void JGHJOBDKDKM()
		{
			base.CBAJAFAPINE();
			UnityEngine.Object.DestroyImmediate(this.LIPFDLLKECG);
		}

		// Token: 0x04001809 RID: 6153
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		// Token: 0x0400180A RID: 6154
		public bool extraBlur;

		// Token: 0x0400180B RID: 6155
		private RenderTexture LIPFDLLKECG;
	}
}
