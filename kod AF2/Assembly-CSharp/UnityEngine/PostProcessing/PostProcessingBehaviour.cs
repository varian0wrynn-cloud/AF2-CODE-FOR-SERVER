using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200056E RID: 1390
	[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		// Token: 0x0601233D RID: 74557 RVA: 0x007FCE4C File Offset: 0x007FB04C
		private void OnDisable()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.OEKMJPLIADI();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.Dispose();
			this.LDFKDCKHFEH.Dispose();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x0601233E RID: 74558 RVA: 0x007FCF08 File Offset: 0x007FB108
		private void OnGUI()
		{
			if (Event.current.type != EventType.Repaint)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
			{
				this.BPLNGGNOMNN.ANFHJIIMJNL();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
			{
				this.LOMMHHNHAKC.ANFHJIIMJNL();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.UserLut))
			{
				this.LFGLMIEKGNM.ANFHJIIMJNL();
			}
		}

		// Token: 0x0601233F RID: 74559 RVA: 0x007FCFC4 File Offset: 0x007FB1C4
		private void FKDGPHFONPB()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.IKPPIPMKGND();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.ODJIEEGNPEM();
			this.LDFKDCKHFEH.LPMNIGCLDED();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012340 RID: 74560 RVA: 0x007FD080 File Offset: 0x007FB280
		private void OCGBHGKEOKJ()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012341 RID: 74561 RVA: 0x007FD0E0 File Offset: 0x007FB2E0
		private void BJAPDLJJJFK()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012342 RID: 74562 RVA: 0x007FD140 File Offset: 0x007FB340
		private void KOGKBJGNFJK()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.NKJANLHLHIP();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.IKPPIPMKGND();
				this.HOFBAAOKEMA = this.profile;
			}
			this.MHNHLEEPHJD();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BKDLJJLDFCM())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012343 RID: 74563 RVA: 0x007FD3F0 File Offset: 0x007FB5F0
		private void CHNCJMLDIPE()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.Reset();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.KBOOFNONAOC();
				this.HOFBAAOKEMA = this.profile;
			}
			this.MHNHLEEPHJD();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BKDLJJLDFCM())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012344 RID: 74564 RVA: 0x007FD6A0 File Offset: 0x007FB8A0
		private void IEHEAJJALNG()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, false);
			}
			base.useGUILayout = false;
		}

		// Token: 0x06012345 RID: 74565 RVA: 0x007FD854 File Offset: 0x007FBA54
		private void POLPNCCCGHG()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.MFFNHJECDGH())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012347 RID: 74567 RVA: 0x007FD8D4 File Offset: 0x007FBAD4
		private void MHNHLEEPHJD()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i++)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = true;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j++)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = false;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x06012348 RID: 74568 RVA: 0x007FD9F0 File Offset: 0x007FBBF0
		private void KBOOFNONAOC()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012349 RID: 74569 RVA: 0x007FDA54 File Offset: 0x007FBC54
		private void IEAJMENMGAL()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i += 0)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = false;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j += 0)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = false;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x0601234A RID: 74570 RVA: 0x007FDB70 File Offset: 0x007FBD70
		public void BGACFOKIDNI()
		{
			this.ABJDLFNHICI.GGNPNBDONAI();
			this.KCFAJJDLOOJ.OGDKPBNOBND();
			this.BPLNGGNOMNN.NAEMLGBBDEF();
		}

		// Token: 0x0601234B RID: 74571 RVA: 0x007FDB93 File Offset: 0x007FBD93
		public void ResetTemporalEffects()
		{
			this.ABJDLFNHICI.GGNPNBDONAI();
			this.KCFAJJDLOOJ.GGNPNBDONAI();
			this.BPLNGGNOMNN.GGNPNBDONAI();
		}

		// Token: 0x0601234C RID: 74572 RVA: 0x007FDBB8 File Offset: 0x007FBDB8
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = true;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = this.ABJDLFNHICI.NLFEIOCKHKA && this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.IBMKEBEEFKP("gi_uinf_11");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.GBJBBLJOAPI(renderTexture);
				this.ABJDLFNHICI.PKLNDKLBGOD(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.CFKFCOFAFBC(renderTexture, material);
			}
			material.SetTexture("FistPump", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.KKFNHMCIGKD(renderTexture, material, flag3, this.ABJDLFNHICI.FLNCIFPCKHH, this.ABJDLFNHICI.BBEPCCALAFC.DJDJANEACGF().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.BGMNIHGFLHI(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.DLNFGMANLPN("") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.KGPKPOCMNJP(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.DLFEHGPGALE(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("OfficeSittingLegCross");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.DOHKAANKEPC();
		}

		// Token: 0x0601234D RID: 74573 RVA: 0x007FDE04 File Offset: 0x007FC004
		private void APMGPNOOHEN()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.CMFJEFKBKKJ())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0601234E RID: 74574 RVA: 0x007FDE68 File Offset: 0x007FC068
		private void DGPJEJEJEFB()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.CMPAMKLAKHE();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.JNNMOBBCADO();
			this.LDFKDCKHFEH.Dispose();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x0601234F RID: 74575 RVA: 0x007FDF24 File Offset: 0x007FC124
		private void LFKOHBPGANM()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.Reset();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.OEKMJPLIADI();
				this.HOFBAAOKEMA = this.profile;
			}
			this.JPNABEEOFHA();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.HALPEOLBOFL())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012350 RID: 74576 RVA: 0x007FE1D4 File Offset: 0x007FC3D4
		private void PLBCABCGNPI()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.MPJJBFNIHPK();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.IKPPIPMKGND();
				this.HOFBAAOKEMA = this.profile;
			}
			this.INNILJAOGGC();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.PDIPBDINBGL())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012351 RID: 74577 RVA: 0x007FE484 File Offset: 0x007FC684
		private void MOJBLBHKCCM()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, false);
			}
			base.useGUILayout = true;
		}

		// Token: 0x06012352 RID: 74578 RVA: 0x007FE638 File Offset: 0x007FC838
		private void KHJJKPCKNKM()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.CMPAMKLAKHE();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.LEGLPCODFJE();
			this.LDFKDCKHFEH.CJMADJGMFIP();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012353 RID: 74579 RVA: 0x007FE6F4 File Offset: 0x007FC8F4
		private void KJLGJBFLKLC()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012354 RID: 74580 RVA: 0x007FE758 File Offset: 0x007FC958
		private void PELIKGBJKDJ()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012355 RID: 74581 RVA: 0x007FE7B8 File Offset: 0x007FC9B8
		private void OnPreCull()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.Reset();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.OEKMJPLIADI();
				this.HOFBAAOKEMA = this.profile;
			}
			this.NLGAOMNGEKI();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.willInterrupt)
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012356 RID: 74582 RVA: 0x007FEA68 File Offset: 0x007FCC68
		private void LEEHJDJFLDJ()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.IIBIHEFLMGI();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.OEKMJPLIADI();
				this.HOFBAAOKEMA = this.profile;
			}
			this.INNILJAOGGC();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.GGIFNKPBICM())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012357 RID: 74583 RVA: 0x007FED18 File Offset: 0x007FCF18
		private void AMGINIANPFJ()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, false);
			}
			base.useGUILayout = false;
		}

		// Token: 0x06012358 RID: 74584 RVA: 0x007FEECC File Offset: 0x007FD0CC
		private void BCPBCDEKGDA<T>(AJIEADKHGJM<T> JHCDAMFNILE) where T : PostProcessingModel
		{
			if (JHCDAMFNILE.NLFEIOCKHKA)
			{
				CommandBuffer commandBuffer = this.PLMHPPFEIFE<T>(JHCDAMFNILE.POJFLMAFHEI(), JHCDAMFNILE.KPGFOFFHPOO());
				commandBuffer.Clear();
				JHCDAMFNILE.DNELHGGBBOO(commandBuffer);
				return;
			}
			this.OAAONBLEPKG<T>();
		}

		// Token: 0x06012359 RID: 74585 RVA: 0x007FEF08 File Offset: 0x007FD108
		private void KIEFPGLDOCD()
		{
			if (Event.current.type != EventType.MouseDrag)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
			{
				this.BPLNGGNOMNN.EDFACHIGJGG();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
			{
				this.LOMMHHNHAKC.ANFHJIIMJNL();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.CAOCNMBBHLM((BuiltinDebugViewsModel.CGNLFGLJGKA)79))
			{
				this.LFGLMIEKGNM.JGAMNLOICJN();
			}
		}

		// Token: 0x0601235A RID: 74586 RVA: 0x007FEFC4 File Offset: 0x007FD1C4
		private void LHHBNHAEIEM()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x0601235B RID: 74587 RVA: 0x007FF024 File Offset: 0x007FD224
		private void BKPJAHOPBCP()
		{
			if (Event.current.type != EventType.Layout)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
			{
				this.BPLNGGNOMNN.DGLJIABJPIP();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
			{
				this.LOMMHHNHAKC.ANFHJIIMJNL();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.CAOCNMBBHLM((BuiltinDebugViewsModel.CGNLFGLJGKA)94))
			{
				this.LFGLMIEKGNM.JGAMNLOICJN();
			}
		}

		// Token: 0x0601235C RID: 74588 RVA: 0x007FF0E0 File Offset: 0x007FD2E0
		private void IOFFNEIOBEL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = true;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.MLAKMCAPCOJ("Roar");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.CNKLFOMIGOH(renderTexture);
				this.ABJDLFNHICI.BHLFNCNLBHO(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = true;
				texture = this.BPLNGGNOMNN.ONKPHHNHNDH(renderTexture, material);
			}
			material.SetTexture("WATER_REFLECTIVE", texture);
			if (flag4)
			{
				flag = true;
				this.CPHDIIIAKBM.JFAJCPPAMFD(renderTexture, material, flag3, this.ABJDLFNHICI.PFFDCEIOLOI(), this.ABJDLFNHICI.BBEPCCALAFC.HMCGGODBANJ().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.CKIENEMPGLL(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.PIPNAHLJKKD("") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.JNKAJCFJHIP(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.LCDEHLFNCED(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("Null");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.IPJFHDNHCJO();
		}

		// Token: 0x0601235D RID: 74589 RVA: 0x007FF32C File Offset: 0x007FD52C
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = true;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = this.ABJDLFNHICI.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			bool flag4 = !this.CPHDIIIAKBM.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.KPJNCIOMAGO("FOG_VOID_BOX");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.ABNFJLOKKMF(renderTexture);
				this.ABJDLFNHICI.KBNKCBDHOCH(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = true;
				texture = this.BPLNGGNOMNN.KKFNHMCIGKD(renderTexture, material);
			}
			material.SetTexture("_ALPHATEST_ON", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.JFAJCPPAMFD(renderTexture, material, flag3, this.ABJDLFNHICI.FLNCIFPCKHH, this.ABJDLFNHICI.BBEPCCALAFC.MPHDFJAHKAK().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = false;
				this.GPBJDAPKFBL.PHKDFDFDONF(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.BDHEBJJGFGB("Ошибка") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.KGPKPOCMNJP(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.BJHFHGNPLMO(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("isMove");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 0);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.NCPCKODLNDC();
		}

		// Token: 0x0601235E RID: 74590 RVA: 0x007FF578 File Offset: 0x007FD778
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = true;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			bool flag4 = !this.CPHDIIIAKBM.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.BDHEBJJGFGB("IdleReadyLook");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.DALPMLLJPKG(renderTexture);
				this.ABJDLFNHICI.NDCHOKBBJAG(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = true;
				texture = this.BPLNGGNOMNN.HDLIGPFFGKL(renderTexture, material);
			}
			material.SetTexture("Flap_08.wav", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.LJOHBCBNIPM(renderTexture, material, flag3, this.ABJDLFNHICI.FLNCIFPCKHH, this.ABJDLFNHICI.BBEPCCALAFC.DMJMEMIPKNM().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = false;
				this.GPBJDAPKFBL.DBJFHEGHKMD(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.EIJMKFHFKDG("_r_") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.AFONGIICOJG(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.AAJOPJLLBFK(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword(" is not supported on this platform!");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.NCPCKODLNDC();
		}

		// Token: 0x0601235F RID: 74591 RVA: 0x007FF7C4 File Offset: 0x007FD9C4
		private void NLGAOMNGEKI()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i++)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = false;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j++)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = true;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x06012360 RID: 74592 RVA: 0x007FF8E0 File Offset: 0x007FDAE0
		private void POFHKNCEHKF()
		{
			if (Event.current.type != EventType.MouseDrag)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
			{
				this.BPLNGGNOMNN.EJNHHHFOOOC();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
			{
				this.LOMMHHNHAKC.HMAENHAFPAM();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.EEFEOJIOAMA((BuiltinDebugViewsModel.CGNLFGLJGKA)23))
			{
				this.LFGLMIEKGNM.MBADKFPCOEJ();
			}
		}

		// Token: 0x06012361 RID: 74593 RVA: 0x007FF99C File Offset: 0x007FDB9C
		private void OEKMJPLIADI()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012362 RID: 74594 RVA: 0x007FFA00 File Offset: 0x007FDC00
		private void DJMCCCHACDO()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012363 RID: 74595 RVA: 0x007FFA60 File Offset: 0x007FDC60
		private void ACEEIODKKBE()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.OEKMJPLIADI();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.COEDCIHACHG();
			this.LDFKDCKHFEH.IJMKJBAPBJO();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012364 RID: 74596 RVA: 0x007FFB1C File Offset: 0x007FDD1C
		private void EHCCPEDPEMD()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.PDIPBDINBGL())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012365 RID: 74597 RVA: 0x007FFB80 File Offset: 0x007FDD80
		private void FEHIMBGDLAH()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 1; i < this.CEPAHJHNMLO.Count; i += 0)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = false;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j++)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = true;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x06012366 RID: 74598 RVA: 0x007FFC9C File Offset: 0x007FDE9C
		private void DAKBKMJKKOH()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BIAKGEBHAPM())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012367 RID: 74599 RVA: 0x007FFD00 File Offset: 0x007FDF00
		private void AOILKGIIKDF()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.KJLGJBFLKLC();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.IKMAOHKFAAC();
			this.LDFKDCKHFEH.LPMNIGCLDED();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012368 RID: 74600 RVA: 0x007FFDBC File Offset: 0x007FDFBC
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = true;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = this.ABJDLFNHICI.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			bool flag4 = !this.CPHDIIIAKBM.NLFEIOCKHKA || this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.EIJMKFHFKDG("Spine bones contains a null reference.");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.GNDBFKAJJCI(renderTexture);
				this.ABJDLFNHICI.NDCHOKBBJAG(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.ONKPHHNHNDH(renderTexture, material);
			}
			material.SetTexture("wpn_add/base", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.LJOHBCBNIPM(renderTexture, material, flag3, this.ABJDLFNHICI.OHADKBNEDFA(), this.ABJDLFNHICI.BBEPCCALAFC.NHIAAMIDCED().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.BIPMAJKBJGB(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.AFONGIICOJG("LUX_LINEAR") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.GJOHODHDPDN(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.OMBLMDFCKKG(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("Here you can overview common ACTk features and try to cheat something yourself.");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.NNHCDIKKDJH();
		}

		// Token: 0x06012369 RID: 74601 RVA: 0x00800008 File Offset: 0x007FE208
		private void OnPostRender()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.willInterrupt)
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0601236A RID: 74602 RVA: 0x00800069 File Offset: 0x007FE269
		public void GHNANIJMOHJ()
		{
			this.ABJDLFNHICI.BIAJOHCAICB();
			this.KCFAJJDLOOJ.FEPGHFFNJHK();
			this.BPLNGGNOMNN.LBPLMCAMFEC();
		}

		// Token: 0x0601236B RID: 74603 RVA: 0x0080008C File Offset: 0x007FE28C
		private bool MLMDBBEICFL<T>(CFPOKEIJEAB<T> JHCDAMFNILE, Material MHNAJNGGDFJ) where T : PostProcessingModel
		{
			if (!JHCDAMFNILE.NLFEIOCKHKA)
			{
				return false;
			}
			JHCDAMFNILE.FBBBNHPGBKC(MHNAJNGGDFJ);
			return true;
		}

		// Token: 0x0601236C RID: 74604 RVA: 0x008000A0 File Offset: 0x007FE2A0
		private void DNFONOKOMCC()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x0601236D RID: 74605 RVA: 0x00800100 File Offset: 0x007FE300
		private void KLKPOKBGPKF()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.GIAJGPDKGHE();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.IKPPIPMKGND();
				this.HOFBAAOKEMA = this.profile;
			}
			this.FEHIMBGDLAH();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.PDIPBDINBGL())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x0601236E RID: 74606 RVA: 0x008003B0 File Offset: 0x007FE5B0
		private void AEKFGBNALFL()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.PDIPBDINBGL())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0601236F RID: 74607 RVA: 0x00800414 File Offset: 0x007FE614
		private void JPNABEEOFHA()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i += 0)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = true;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 1; j < this.NPFIEIIPPMN.Count; j += 0)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = true;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x06012370 RID: 74608 RVA: 0x00800530 File Offset: 0x007FE730
		private void CCCAOGJKJOD()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.PCLNJBJKAGH();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.CCFPHAENIML();
			this.LDFKDCKHFEH.Dispose();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012371 RID: 74609 RVA: 0x008005EC File Offset: 0x007FE7EC
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.ACEOHEODOMJ("");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.ILIOMPBIFIB(renderTexture);
				this.ABJDLFNHICI.EJMBCDGBGGC(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.JCIDGLOAJBE(renderTexture, material);
			}
			material.SetTexture("private", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.PMCPADOBJGI(renderTexture, material, flag3, this.ABJDLFNHICI.LKHMCAJHAGK(), this.ABJDLFNHICI.BBEPCCALAFC.FNAOHMNKKMB().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.BGMNIHGFLHI(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.HPAJGFGNMOH("<color='{0}'>{1}</color>") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.DALPMLLJPKG(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.IBOKCODJBGE(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("wpn_break");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 0);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.HOBOPJEBGEF();
		}

		// Token: 0x06012372 RID: 74610 RVA: 0x00800838 File Offset: 0x007FEA38
		private void LBBLFOEJCBB()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012373 RID: 74611 RVA: 0x00800898 File Offset: 0x007FEA98
		private void PEKNHINKHCK()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.PCLNJBJKAGH();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.AGDHBHGEMNI();
			this.LDFKDCKHFEH.FGMNJBHEEML();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012374 RID: 74612 RVA: 0x00800954 File Offset: 0x007FEB54
		private void GJEGBPMANIH()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.FHKJDMPPKLG())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012375 RID: 74613 RVA: 0x008009B8 File Offset: 0x007FEBB8
		private void EPOJLAKECDD()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.MLOPPPBPHNJ();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.IKPPIPMKGND();
				this.HOFBAAOKEMA = this.profile;
			}
			this.JPNABEEOFHA();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BDOOGMAPPCM())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012376 RID: 74614 RVA: 0x00800C68 File Offset: 0x007FEE68
		private void LIOHFKBBNML()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.MCPCAJPLMBF())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012377 RID: 74615 RVA: 0x00800CCC File Offset: 0x007FEECC
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = this.ABJDLFNHICI.NLFEIOCKHKA && this.IEDPAOIKAJB;
			bool flag4 = !this.CPHDIIIAKBM.NLFEIOCKHKA || this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.PIPNAHLJKKD("-H");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.ILIOMPBIFIB(renderTexture);
				this.ABJDLFNHICI.NDCHOKBBJAG(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.MJCCBMCIMFE(renderTexture, material);
			}
			material.SetTexture("Giant3HitCombo2", texture);
			if (flag4)
			{
				flag = true;
				this.CPHDIIIAKBM.BLAIBKFMCEM(renderTexture, material, flag3, this.ABJDLFNHICI.LKHMCAJHAGK(), this.ABJDLFNHICI.BBEPCCALAFC.CNAAMGCNGHF().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.LIEFLFCANMO(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.GNDBFKAJJCI("Crouch Walk Backward") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.DFEMMOCHMDM(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.KMHHHFIFDLF(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("_BlurRadius4");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.OFPCBKIAPIN();
		}

		// Token: 0x06012378 RID: 74616 RVA: 0x00800F18 File Offset: 0x007FF118
		public void FFDDNOPOOKL()
		{
			this.ABJDLFNHICI.GGNPNBDONAI();
			this.KCFAJJDLOOJ.OGDKPBNOBND();
			this.BPLNGGNOMNN.ADPEOCBFJGI();
		}

		// Token: 0x06012379 RID: 74617 RVA: 0x00800F3C File Offset: 0x007FF13C
		private void FNNHJAIIFID()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i++)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = true;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 1; j < this.NPFIEIIPPMN.Count; j += 0)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = true;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x0601237A RID: 74618 RVA: 0x00801058 File Offset: 0x007FF258
		private void PLBMFJMPMKL()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.CMPAMKLAKHE();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.JNNMOBBCADO();
			this.LDFKDCKHFEH.CJMADJGMFIP();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x0601237B RID: 74619 RVA: 0x00801114 File Offset: 0x007FF314
		private void MBADKFPCOEJ()
		{
			if (Event.current.type != EventType.Layout)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
			{
				this.BPLNGGNOMNN.BKFLIDKPDDI();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
			{
				this.LOMMHHNHAKC.PBHKFPELDGF();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.BGKOOHLKCNJ((BuiltinDebugViewsModel.CGNLFGLJGKA)(-124)))
			{
				this.LFGLMIEKGNM.JBGGMKEKOAN();
			}
		}

		// Token: 0x0601237C RID: 74620 RVA: 0x008011D0 File Offset: 0x007FF3D0
		private CommandBuffer EOMAACACLOE<T>(CameraEvent AHJELKJGKEC, string BNIHFBMEPAB) where T : PostProcessingModel
		{
			CommandBuffer value = new CommandBuffer
			{
				name = BNIHFBMEPAB
			};
			KeyValuePair<CameraEvent, CommandBuffer> value2 = new KeyValuePair<CameraEvent, CommandBuffer>(AHJELKJGKEC, value);
			this.EHDPIMNNFED.Add(typeof(T), value2);
			this.MPCEHPBGHII.AddCommandBuffer(AHJELKJGKEC, value2.Value);
			return value2.Value;
		}

		// Token: 0x0601237D RID: 74621 RVA: 0x00801223 File Offset: 0x007FF423
		private T BBBLOAHECJC<T>(T JHCDAMFNILE) where T : GINHKMOJKNN
		{
			this.KHJGHHFPDHM.Add(JHCDAMFNILE);
			return JHCDAMFNILE;
		}

		// Token: 0x0601237E RID: 74622 RVA: 0x00801238 File Offset: 0x007FF438
		private void LIODOCLJPMK()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 1; i < this.CEPAHJHNMLO.Count; i += 0)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = true;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j++)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = false;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x0601237F RID: 74623 RVA: 0x00801354 File Offset: 0x007FF554
		private void PCLNJBJKAGH()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012380 RID: 74624 RVA: 0x008013B8 File Offset: 0x007FF5B8
		private void IBOMADDAFAO()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, true);
			}
			base.useGUILayout = true;
		}

		// Token: 0x06012381 RID: 74625 RVA: 0x0080156C File Offset: 0x007FF76C
		private void EKLMGENBKEC()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BKDLJJLDFCM())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012382 RID: 74626 RVA: 0x008015D0 File Offset: 0x007FF7D0
		private void LLMNIHJCEHN()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.COABEBLDMNF();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.CPGLLIOIKLA();
				this.HOFBAAOKEMA = this.profile;
			}
			this.LIODOCLJPMK();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.BIAKGEBHAPM())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x06012383 RID: 74627 RVA: 0x00801880 File Offset: 0x007FFA80
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.DGOMGBDLAFP("********* LEFT / RIGHT Event ");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.DFEMMOCHMDM(renderTexture);
				this.ABJDLFNHICI.KECAPAJCJGI(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.BLAIBKFMCEM(renderTexture, material);
			}
			material.SetTexture("_rcIn.ogg", texture);
			if (flag4)
			{
				flag = true;
				this.CPHDIIIAKBM.PMCPADOBJGI(renderTexture, material, flag3, this.ABJDLFNHICI.OHADKBNEDFA(), this.ABJDLFNHICI.BBEPCCALAFC.MEPIPLDFEJH().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = false;
				this.GPBJDAPKFBL.KIMPBABLLHK(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.CPFHLGIKEJC("Active Process ") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.ILIOMPBIFIB(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.KMHHHFIFDLF(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("SatNightFever");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.NCPCKODLNDC();
		}

		// Token: 0x06012384 RID: 74628 RVA: 0x00801ACC File Offset: 0x007FFCCC
		private void CPGLLIOIKLA()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012385 RID: 74629 RVA: 0x00801B30 File Offset: 0x007FFD30
		private void OnEnable()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, false);
			}
			base.useGUILayout = false;
		}

		// Token: 0x06012386 RID: 74630 RVA: 0x00801CE4 File Offset: 0x007FFEE4
		private CommandBuffer PLMHPPFEIFE<T>(CameraEvent AHJELKJGKEC, string BNIHFBMEPAB) where T : PostProcessingModel
		{
			KeyValuePair<CameraEvent, CommandBuffer> keyValuePair;
			CommandBuffer result;
			if (!this.EHDPIMNNFED.TryGetValue(typeof(T), out keyValuePair))
			{
				result = this.EOMAACACLOE<T>(AHJELKJGKEC, BNIHFBMEPAB);
			}
			else if (keyValuePair.Key != AHJELKJGKEC)
			{
				this.OAAONBLEPKG<T>();
				result = this.EOMAACACLOE<T>(AHJELKJGKEC, BNIHFBMEPAB);
			}
			else
			{
				result = keyValuePair.Value;
			}
			return result;
		}

		// Token: 0x06012387 RID: 74631 RVA: 0x00801D3C File Offset: 0x007FFF3C
		private void JIALFLDKFPJ()
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.FHKJDMPPKLG())
			{
				this.HPFJMBAMEAG.LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x06012388 RID: 74632 RVA: 0x00801DA0 File Offset: 0x007FFFA0
		private void OnPreRender()
		{
			if (this.profile == null)
			{
				return;
			}
			this.BCPBCDEKGDA<BuiltinDebugViewsModel>(this.IEEJIEIPAMC);
			this.BCPBCDEKGDA<AmbientOcclusionModel>(this.LPAPALACNIO);
			this.BCPBCDEKGDA<ScreenSpaceReflectionModel>(this.CKGEJMJFKAH);
			this.BCPBCDEKGDA<FogModel>(this.JCPEFOLAIOD);
			if (!this.IEDPAOIKAJB)
			{
				this.BCPBCDEKGDA<MotionBlurModel>(this.KCFAJJDLOOJ);
			}
		}

		// Token: 0x06012389 RID: 74633 RVA: 0x00801E00 File Offset: 0x00800000
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = this.ABJDLFNHICI.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.AFONGIICOJG("Hidden/Post FX/Uber Shader");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.AFONGIICOJG(renderTexture);
				this.ABJDLFNHICI.BHLFNCNLBHO(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = true;
				texture = this.BPLNGGNOMNN.FBBBNHPGBKC(renderTexture, material);
			}
			material.SetTexture("_AutoExposure", texture);
			if (flag4)
			{
				flag = true;
				this.CPHDIIIAKBM.FBBBNHPGBKC(renderTexture, material, flag3, this.ABJDLFNHICI.FLNCIFPCKHH, this.ABJDLFNHICI.BBEPCCALAFC.settings.taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.FBBBNHPGBKC(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.AFONGIICOJG("Hidden/Post FX/FXAA") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.AFONGIICOJG(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.BHLFNCNLBHO(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("UNITY_COLORSPACE_GAMMA");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 0);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.CPBLJJACIIB();
		}

		// Token: 0x0601238A RID: 74634 RVA: 0x0080204C File Offset: 0x0080024C
		private void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && !this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.BDHEBJJGFGB("\n");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.ILIOMPBIFIB(renderTexture);
				this.ABJDLFNHICI.EJMBCDGBGGC(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = false;
				texture = this.BPLNGGNOMNN.OBCPKHIAKPP(renderTexture, material);
			}
			material.SetTexture("auk_data/categories/category", texture);
			if (flag4)
			{
				flag = false;
				this.CPHDIIIAKBM.BLAIBKFMCEM(renderTexture, material, flag3, this.ABJDLFNHICI.PFFDCEIOLOI(), this.ABJDLFNHICI.BBEPCCALAFC.JMEDGLJKFDK().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = true;
				this.GPBJDAPKFBL.FBBBNHPGBKC(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.JDGIHFLNMKB(" {0}") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.CNKLFOMIGOH(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.JEIJEHCDOJO(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("Clear Screen");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 1);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.EMBCCAPCJNK();
		}

		// Token: 0x0601238B RID: 74635 RVA: 0x00802298 File Offset: 0x00800498
		private void NKGLONEPKDF()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.Reset();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.OEKMJPLIADI();
				this.HOFBAAOKEMA = this.profile;
			}
			this.MHNHLEEPHJD();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.MCPCAJPLMBF())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x0601238C RID: 74636 RVA: 0x00802548 File Offset: 0x00800748
		public void KGJMOAFIDDJ()
		{
			this.ABJDLFNHICI.GGNPNBDONAI();
			this.KCFAJJDLOOJ.MIOPKCEHLFH();
			this.BPLNGGNOMNN.ELBOGKCENFA();
		}

		// Token: 0x0601238D RID: 74637 RVA: 0x0080256C File Offset: 0x0080076C
		private void KBAJMMCHDOC()
		{
			if (Event.current.type != EventType.MouseDown)
			{
				return;
			}
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			if (this.BPLNGGNOMNN.NLFEIOCKHKA && this.profile.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
			{
				this.BPLNGGNOMNN.JADMEJAFNFO();
				return;
			}
			if (this.LOMMHHNHAKC.NLFEIOCKHKA && this.profile.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
			{
				this.LOMMHHNHAKC.EEOLBBJNOJD();
				return;
			}
			if (this.LFGLMIEKGNM.NLFEIOCKHKA && this.profile.debugViews.CAOCNMBBHLM((BuiltinDebugViewsModel.CGNLFGLJGKA)75))
			{
				this.LFGLMIEKGNM.GKFOFOCGPCC();
			}
		}

		// Token: 0x0601238E RID: 74638 RVA: 0x00802628 File Offset: 0x00800828
		private void BKMLBMAMLLJ()
		{
			this.MPCEHPBGHII = base.GetComponent<Camera>();
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				return;
			}
			NGEENBGMFFM ngeenbgmffm = this.HPFJMBAMEAG.Reset();
			ngeenbgmffm.CICJBNKMECH = this.profile;
			ngeenbgmffm.ADCMJOKBEHJ = this.LDFKDCKHFEH;
			ngeenbgmffm.DJHLKHLPAGA = this.IMBPMIEEFID;
			ngeenbgmffm.LBCHLCGOCOD = this.MPCEHPBGHII;
			this.IEEJIEIPAMC.PINLMCCKKNA(ngeenbgmffm, this.profile.debugViews);
			this.LPAPALACNIO.PINLMCCKKNA(ngeenbgmffm, this.profile.ambientOcclusion);
			this.CKGEJMJFKAH.PINLMCCKKNA(ngeenbgmffm, this.profile.screenSpaceReflection);
			this.JCPEFOLAIOD.PINLMCCKKNA(ngeenbgmffm, this.profile.fog);
			this.KCFAJJDLOOJ.PINLMCCKKNA(ngeenbgmffm, this.profile.motionBlur);
			this.ABJDLFNHICI.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			this.BPLNGGNOMNN.PINLMCCKKNA(ngeenbgmffm, this.profile.eyeAdaptation);
			this.CPHDIIIAKBM.PINLMCCKKNA(ngeenbgmffm, this.profile.depthOfField);
			this.GPBJDAPKFBL.PINLMCCKKNA(ngeenbgmffm, this.profile.bloom);
			this.FNNMNNGCBLC.PINLMCCKKNA(ngeenbgmffm, this.profile.chromaticAberration);
			this.LOMMHHNHAKC.PINLMCCKKNA(ngeenbgmffm, this.profile.colorGrading);
			this.LFGLMIEKGNM.PINLMCCKKNA(ngeenbgmffm, this.profile.userLut);
			this.FFHNABPGBHL.PINLMCCKKNA(ngeenbgmffm, this.profile.grain);
			this.IBOMJANLACB.PINLMCCKKNA(ngeenbgmffm, this.profile.vignette);
			this.OIELPNJCFBN.PINLMCCKKNA(ngeenbgmffm, this.profile.dithering);
			this.DPOGADLIJLC.PINLMCCKKNA(ngeenbgmffm, this.profile.antialiasing);
			if (this.HOFBAAOKEMA != this.profile)
			{
				this.CPGLLIOIKLA();
				this.HOFBAAOKEMA = this.profile;
			}
			this.NLGAOMNGEKI();
			DepthTextureMode depthTextureMode = ngeenbgmffm.LBCHLCGOCOD.depthTextureMode;
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				if (ginhkmojknn.NLFEIOCKHKA)
				{
					depthTextureMode |= ginhkmojknn.PPAJFNGHBCF();
				}
			}
			ngeenbgmffm.LBCHLCGOCOD.depthTextureMode = depthTextureMode;
			if (!this.IEDPAOIKAJB && this.ABJDLFNHICI.NLFEIOCKHKA && !this.profile.debugViews.CMFJEFKBKKJ())
			{
				this.ABJDLFNHICI.OMBPKFEEKOC(this.jitteredMatrixFunc);
			}
		}

		// Token: 0x0601238F RID: 74639 RVA: 0x008028D8 File Offset: 0x00800AD8
		private void IKPPIPMKGND()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x06012390 RID: 74640 RVA: 0x0080293C File Offset: 0x00800B3C
		private void OAAONBLEPKG<T>() where T : PostProcessingModel
		{
			Type typeFromHandle = typeof(T);
			KeyValuePair<CameraEvent, CommandBuffer> keyValuePair;
			if (!this.EHDPIMNNFED.TryGetValue(typeFromHandle, out keyValuePair))
			{
				return;
			}
			this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			this.EHDPIMNNFED.Remove(typeFromHandle);
			keyValuePair.Value.Dispose();
		}

		// Token: 0x06012391 RID: 74641 RVA: 0x00802998 File Offset: 0x00800B98
		private void PCKEAEAHAKG()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.CPGLLIOIKLA();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.LEGLPCODFJE();
			this.LDFKDCKHFEH.IKMAOHKFAAC();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012392 RID: 74642 RVA: 0x00802A54 File Offset: 0x00800C54
		private void DLDOPAGLPPO()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, true);
			}
			base.useGUILayout = true;
		}

		// Token: 0x06012393 RID: 74643 RVA: 0x00802C08 File Offset: 0x00800E08
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.profile == null || this.MPCEHPBGHII == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			bool flag = false;
			bool flag2 = this.DPOGADLIJLC.NLFEIOCKHKA;
			bool flag3 = !this.ABJDLFNHICI.NLFEIOCKHKA || !this.IEDPAOIKAJB;
			bool flag4 = this.CPHDIIIAKBM.NLFEIOCKHKA && this.IEDPAOIKAJB;
			Material material = this.IMBPMIEEFID.JBLDPJMMJOL("_isSelect");
			material.shaderKeywords = null;
			RenderTexture renderTexture = JONJODLFAEN;
			if (flag3)
			{
				RenderTexture renderTexture2 = this.LDFKDCKHFEH.JBLDPJMMJOL(renderTexture);
				this.ABJDLFNHICI.PKLNDKLBGOD(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = CDBICMCJFCE.PGPDKDHFOLI;
			if (this.BPLNGGNOMNN.NLFEIOCKHKA)
			{
				flag = true;
				texture = this.BPLNGGNOMNN.CFKFCOFAFBC(renderTexture, material);
			}
			material.SetTexture("thumb", texture);
			if (flag4)
			{
				flag = true;
				this.CPHDIIIAKBM.JJJAPCHFEIF(renderTexture, material, flag3, this.ABJDLFNHICI.OHADKBNEDFA(), this.ABJDLFNHICI.BBEPCCALAFC.LECLLIGLNIJ().taaSettings.motionBlending);
			}
			if (this.GPBJDAPKFBL.NLFEIOCKHKA)
			{
				flag = false;
				this.GPBJDAPKFBL.GNACMEINLNL(renderTexture, material, texture);
			}
			flag |= this.MLMDBBEICFL<ChromaticAberrationModel>(this.FNNMNNGCBLC, material);
			flag |= this.MLMDBBEICFL<ColorGradingModel>(this.LOMMHHNHAKC, material);
			flag |= this.MLMDBBEICFL<VignetteModel>(this.IBOMJANLACB, material);
			flag |= this.MLMDBBEICFL<UserLutModel>(this.LFGLMIEKGNM, material);
			Material material2 = flag2 ? this.IMBPMIEEFID.JDGIHFLNMKB("crft_krit") : null;
			if (flag2)
			{
				material2.shaderKeywords = null;
				this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material2);
				this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.LDFKDCKHFEH.GJOHODHDPDN(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.DPOGADLIJLC.OMBLMDFCKKG(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				flag |= this.MLMDBBEICFL<GrainModel>(this.FFHNABPGBHL, material);
				flag |= this.MLMDBBEICFL<DitheringModel>(this.OIELPNJCFBN, material);
				if (flag)
				{
					if (!CDBICMCJFCE.AIDPGNAEOMF)
					{
						material.EnableKeyword("0");
					}
					Graphics.Blit(renderTexture, OKIIDHIJBEA, material, 0);
				}
			}
			if (!flag && !flag2)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			this.LDFKDCKHFEH.DDOPLENPFMK();
		}

		// Token: 0x06012394 RID: 74644 RVA: 0x00802E54 File Offset: 0x00801054
		private void BOIFJMFAOGK()
		{
			this.EHDPIMNNFED = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
			this.IMBPMIEEFID = new EEPHKJMCGOD();
			this.LDFKDCKHFEH = new HEEKHHOJKGI();
			this.HPFJMBAMEAG = new NGEENBGMFFM();
			this.KHJGHHFPDHM = new List<GINHKMOJKNN>();
			this.IEEJIEIPAMC = this.BBBLOAHECJC<MCOMBMNALNJ>(new MCOMBMNALNJ());
			this.LPAPALACNIO = this.BBBLOAHECJC<AKFPCBMKBFD>(new AKFPCBMKBFD());
			this.CKGEJMJFKAH = this.BBBLOAHECJC<IIAIELHPNCF>(new IIAIELHPNCF());
			this.JCPEFOLAIOD = this.BBBLOAHECJC<BJKFKMLPPKK>(new BJKFKMLPPKK());
			this.KCFAJJDLOOJ = this.BBBLOAHECJC<DGIEACBKFMJ>(new DGIEACBKFMJ());
			this.ABJDLFNHICI = this.BBBLOAHECJC<PBLABKKFDNK>(new PBLABKKFDNK());
			this.BPLNGGNOMNN = this.BBBLOAHECJC<HLOBLFJOMLP>(new HLOBLFJOMLP());
			this.CPHDIIIAKBM = this.BBBLOAHECJC<GEKKABOAOKA>(new GEKKABOAOKA());
			this.GPBJDAPKFBL = this.BBBLOAHECJC<HOPOKLACAJH>(new HOPOKLACAJH());
			this.FNNMNNGCBLC = this.BBBLOAHECJC<DNAIEBIBHKC>(new DNAIEBIBHKC());
			this.LOMMHHNHAKC = this.BBBLOAHECJC<JODDBBFMMIK>(new JODDBBFMMIK());
			this.LFGLMIEKGNM = this.BBBLOAHECJC<HPEGBBJNDBH>(new HPEGBBJNDBH());
			this.FFHNABPGBHL = this.BBBLOAHECJC<FACEDKBCABP>(new FACEDKBCABP());
			this.IBOMJANLACB = this.BBBLOAHECJC<MJMFKIGMMFL>(new MJMFKIGMMFL());
			this.OIELPNJCFBN = this.BBBLOAHECJC<DKJILIKMHAH>(new DKJILIKMHAH());
			this.DPOGADLIJLC = this.BBBLOAHECJC<BKKAAEAHNJK>(new BKKAAEAHNJK());
			this.BHCPGJCOPKJ = new Dictionary<GINHKMOJKNN, bool>();
			foreach (GINHKMOJKNN key in this.KHJGHHFPDHM)
			{
				this.BHCPGJCOPKJ.Add(key, true);
			}
			base.useGUILayout = true;
		}

		// Token: 0x06012395 RID: 74645 RVA: 0x00803008 File Offset: 0x00801208
		public void ODELAGIOHDN()
		{
			this.ABJDLFNHICI.GGNPNBDONAI();
			this.KCFAJJDLOOJ.JJHCGFKFJKH();
			this.BPLNGGNOMNN.OGDKPBNOBND();
		}

		// Token: 0x06012396 RID: 74646 RVA: 0x0080302C File Offset: 0x0080122C
		private void FKPHBAOKEOF()
		{
			foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.EHDPIMNNFED.Values)
			{
				this.MPCEHPBGHII.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
				keyValuePair.Value.Dispose();
			}
			this.EHDPIMNNFED.Clear();
			if (this.profile != null)
			{
				this.OEKMJPLIADI();
			}
			this.KHJGHHFPDHM.Clear();
			this.IMBPMIEEFID.Dispose();
			this.LDFKDCKHFEH.LPMNIGCLDED();
			CDBICMCJFCE.DAGFCHOFMFP();
		}

		// Token: 0x06012397 RID: 74647 RVA: 0x008030E8 File Offset: 0x008012E8
		private void INNILJAOGGC()
		{
			foreach (KeyValuePair<GINHKMOJKNN, bool> keyValuePair in this.BHCPGJCOPKJ)
			{
				GINHKMOJKNN key = keyValuePair.Key;
				bool enabled = key.IEIKOEPMMDA().enabled;
				if (enabled != keyValuePair.Value)
				{
					if (enabled)
					{
						this.NPFIEIIPPMN.Add(key);
					}
					else
					{
						this.CEPAHJHNMLO.Add(key);
					}
				}
			}
			for (int i = 0; i < this.CEPAHJHNMLO.Count; i += 0)
			{
				GINHKMOJKNN ginhkmojknn = this.CEPAHJHNMLO[i];
				this.BHCPGJCOPKJ[ginhkmojknn] = true;
				ginhkmojknn.BKFHJFNCPAA();
			}
			for (int j = 0; j < this.NPFIEIIPPMN.Count; j++)
			{
				GINHKMOJKNN ginhkmojknn2 = this.NPFIEIIPPMN[j];
				this.BHCPGJCOPKJ[ginhkmojknn2] = false;
				ginhkmojknn2.ADBAOPJBGHG();
			}
			this.CEPAHJHNMLO.Clear();
			this.NPFIEIIPPMN.Clear();
		}

		// Token: 0x06012398 RID: 74648 RVA: 0x00803204 File Offset: 0x00801404
		private void CMPAMKLAKHE()
		{
			foreach (GINHKMOJKNN ginhkmojknn in this.KHJGHHFPDHM)
			{
				PostProcessingModel postProcessingModel = ginhkmojknn.IEIKOEPMMDA();
				if (postProcessingModel != null && postProcessingModel.enabled)
				{
					ginhkmojknn.BKFHJFNCPAA();
				}
			}
		}

		// Token: 0x040025A3 RID: 9635
		public PostProcessingProfile profile;

		// Token: 0x040025A4 RID: 9636
		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		// Token: 0x040025A5 RID: 9637
		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> EHDPIMNNFED;

		// Token: 0x040025A6 RID: 9638
		private List<GINHKMOJKNN> KHJGHHFPDHM;

		// Token: 0x040025A7 RID: 9639
		private Dictionary<GINHKMOJKNN, bool> BHCPGJCOPKJ;

		// Token: 0x040025A8 RID: 9640
		private EEPHKJMCGOD IMBPMIEEFID;

		// Token: 0x040025A9 RID: 9641
		private HEEKHHOJKGI LDFKDCKHFEH;

		// Token: 0x040025AA RID: 9642
		private NGEENBGMFFM HPFJMBAMEAG;

		// Token: 0x040025AB RID: 9643
		private Camera MPCEHPBGHII;

		// Token: 0x040025AC RID: 9644
		private PostProcessingProfile HOFBAAOKEMA;

		// Token: 0x040025AD RID: 9645
		private bool IEDPAOIKAJB;

		// Token: 0x040025AE RID: 9646
		private MCOMBMNALNJ IEEJIEIPAMC;

		// Token: 0x040025AF RID: 9647
		private AKFPCBMKBFD LPAPALACNIO;

		// Token: 0x040025B0 RID: 9648
		private IIAIELHPNCF CKGEJMJFKAH;

		// Token: 0x040025B1 RID: 9649
		private BJKFKMLPPKK JCPEFOLAIOD;

		// Token: 0x040025B2 RID: 9650
		private DGIEACBKFMJ KCFAJJDLOOJ;

		// Token: 0x040025B3 RID: 9651
		private PBLABKKFDNK ABJDLFNHICI;

		// Token: 0x040025B4 RID: 9652
		private HLOBLFJOMLP BPLNGGNOMNN;

		// Token: 0x040025B5 RID: 9653
		private GEKKABOAOKA CPHDIIIAKBM;

		// Token: 0x040025B6 RID: 9654
		private HOPOKLACAJH GPBJDAPKFBL;

		// Token: 0x040025B7 RID: 9655
		private DNAIEBIBHKC FNNMNNGCBLC;

		// Token: 0x040025B8 RID: 9656
		private JODDBBFMMIK LOMMHHNHAKC;

		// Token: 0x040025B9 RID: 9657
		private HPEGBBJNDBH LFGLMIEKGNM;

		// Token: 0x040025BA RID: 9658
		private FACEDKBCABP FFHNABPGBHL;

		// Token: 0x040025BB RID: 9659
		private MJMFKIGMMFL IBOMJANLACB;

		// Token: 0x040025BC RID: 9660
		private DKJILIKMHAH OIELPNJCFBN;

		// Token: 0x040025BD RID: 9661
		private BKKAAEAHNJK DPOGADLIJLC;

		// Token: 0x040025BE RID: 9662
		private List<GINHKMOJKNN> NPFIEIIPPMN = new List<GINHKMOJKNN>();

		// Token: 0x040025BF RID: 9663
		private List<GINHKMOJKNN> CEPAHJHNMLO = new List<GINHKMOJKNN>();
	}
}
