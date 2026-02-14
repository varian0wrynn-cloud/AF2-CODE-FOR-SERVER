using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000328 RID: 808
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		// Token: 0x0600B8B1 RID: 47281 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void JCEKLINBCDB()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x00522E10 File Offset: 0x00521010
		protected Material BNLLIMNHNPH()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)86;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x00522E9C File Offset: 0x0052109C
		private void NEAHFPACLKL()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 360f, 1205f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 127f, 1101f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1640f, 1872f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1337f, 742f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1306f, 1094f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 161f, 408f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1170f, 1270f);
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x00522F68 File Offset: 0x00521168
		private void GDNBEMIGCKN()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1916f, 652f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 370f, 291f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 196f, 1812f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1128f, 638f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1180f, 583f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 728f, 483f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1227f, 603f);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x00523034 File Offset: 0x00521234
		private void BGPCGGLGAML()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1565f, 1670f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1995f, 1313f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 50f, 1664f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1381f, 1778f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 850f, 264f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1586f, 238f);
			this.grainSize = Mathf.Clamp(this.grainSize, 916f, 353f);
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x00523100 File Offset: 0x00521300
		private void MCCMFFLILNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NBJOACOMCHJ();
			if (this.DDDPCCODKBJ <= 932f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 723f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.FIPCLFODIIL();
			material.SetTexture("Katana", this.grainTexture);
			material.SetTexture("aukTree", this.scratchTexture);
			float num = 844f / this.grainSize;
			material.SetVector("RHandPunch", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Vertical", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("stretchWidth", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1594f, 347f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x0052327C File Offset: 0x0052147C
		private void PBALCCGGFNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CLKDIJKDGJH();
			if (this.DDDPCCODKBJ <= 1678f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1169f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MHNAJNGGDFJ;
			material.SetTexture("{not_found}", this.grainTexture);
			material.SetTexture("RIGHT", this.scratchTexture);
			float num = 559f / this.grainSize;
			material.SetVector("offsets", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("http://j.mp/1iBK5pz", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("double: ", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1544f, 527f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x005233F8 File Offset: 0x005215F8
		protected void MMACLBBMDLA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Original lives count:\n");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x0052346C File Offset: 0x0052166C
		protected Material EDEDNLPOMIN()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x005234F8 File Offset: 0x005216F8
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GDNBEMIGCKN();
			if (this.DDDPCCODKBJ <= 1298f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1815f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.HKFFCHHJABN();
			material.SetTexture("wpn_add/base", this.grainTexture);
			material.SetTexture("Trail", this.scratchTexture);
			float num = 1333f / this.grainSize;
			material.SetVector("\n", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("name", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("<color='#003000'>{0}</color>", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 719f, 5f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8BB RID: 47291 RVA: 0x00523674 File Offset: 0x00521874
		protected void AOCDDBNBADJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_NoiseTex");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8BC RID: 47292 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void IDFEHJKAJAM()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x005236E8 File Offset: 0x005218E8
		private void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.JJCLKGHJCGB();
			if (this.DDDPCCODKBJ <= 914f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 316f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.IGBBHJBPOKM();
			material.SetTexture("OneHandSwordJab", this.grainTexture);
			material.SetTexture(" should be overwritten.", this.scratchTexture);
			float num = 1394f / this.grainSize;
			material.SetVector("Not setting 'UniqueShadowSun.instance' because '{0}' is already active!", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("No saved ObscuredPrefs!", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("offsets", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1013f, 848f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x00523864 File Offset: 0x00521A64
		private void KEJDIJIBNAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GJBLMFEPHNF();
			if (this.DDDPCCODKBJ <= 1118f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 239f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MNJNELAGPNJ();
			material.SetTexture("CardPlayerIdle", this.grainTexture);
			material.SetTexture("B", this.scratchTexture);
			float num = 630f / this.grainSize;
			material.SetVector("_", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("RunningDance", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("9", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 390f, 441f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x005239E0 File Offset: 0x00521BE0
		private void MPFCIBPIGGB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.EBFEDJMCKHI();
			if (this.DDDPCCODKBJ <= 1747f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1986f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MHNAJNGGDFJ;
			material.SetTexture("MotorbikeWheelyNoHands", this.grainTexture);
			material.SetTexture("CATRigR", this.scratchTexture);
			float num = 745f / this.grainSize;
			material.SetVector(" ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("CratePull", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("FactoryTempTexture", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1636f, 1170f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x00523B5C File Offset: 0x00521D5C
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.ECNBDOBJLNL();
			if (this.DDDPCCODKBJ <= 427f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 44f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.CDHGPDDEKDF();
			material.SetTexture("MotorbikeBackwardSittingCheer", this.grainTexture);
			material.SetTexture("' that does not excist in the Node Chain.", this.scratchTexture);
			float num = 1626f / this.grainSize;
			material.SetVector("**MMOItem", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("tag", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_SpecCubeIBL", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1720f, 1656f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void OnDisable()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x00523CD8 File Offset: 0x00521ED8
		private void NBJOACOMCHJ()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1793f, 1464f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1187f, 287f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1139f, 1251f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 894f, 116f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 94f, 640f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 936f, 1106f);
			this.grainSize = Mathf.Clamp(this.grainSize, 406f, 1444f);
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x00523DA4 File Offset: 0x00521FA4
		private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.ECNBDOBJLNL();
			if (this.DDDPCCODKBJ <= 1070f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1137f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MHNAJNGGDFJ;
			material.SetTexture("{y}", this.grainTexture);
			material.SetTexture("wpnlang/weapons/weapon", this.scratchTexture);
			float num = 1757f / this.grainSize;
			material.SetVector("buyVIP OK", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Circular parenting. ", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("{0} принял задание '{1}'", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 488f, 1717f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x00523F88 File Offset: 0x00522188
		private void DOALCEAFDKL()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 864f, 521f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1518f, 1250f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 394f, 908f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 63f, 1161f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 783f, 588f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1853f, 1046f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1826f, 1980f);
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x00524054 File Offset: 0x00522254
		private void BBABONCHIIN()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1769f, 63f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1722f, 1785f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 998f, 435f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1649f, 1346f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1920f, 307f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1949f, 346f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1176f, 556f);
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void IDLLAMOBGGO()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x00524120 File Offset: 0x00522320
		protected void CLHGHANANNL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("bright");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x00524194 File Offset: 0x00522394
		protected void LPNDCJKAKEA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("shopCount");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void NMCIALANIHJ()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x00524208 File Offset: 0x00522408
		private void FDJOLBACPBC()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 936f, 1513f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1814f, 1668f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1535f, 823f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 592f, 455f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 719f, 405f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 708f, 1743f);
			this.grainSize = Mathf.Clamp(this.grainSize, 550f, 191f);
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x005242D4 File Offset: 0x005224D4
		protected void DGGMJCMLLED()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("800000");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x00524348 File Offset: 0x00522548
		private void NDLHGBEKICF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GDNBEMIGCKN();
			if (this.DDDPCCODKBJ <= 946f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1154f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.IGBBHJBPOKM();
			material.SetTexture("FA ", this.grainTexture);
			material.SetTexture("WateringCanWatering", this.scratchTexture);
			float num = 1031f / this.grainSize;
			material.SetVector("StaffStand", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("shop_bccount", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("B", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 660f, 1851f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void MKBPPPJKLLF()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x005244C4 File Offset: 0x005226C4
		private void OODHNDFBIDD()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1801f, 540f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 326f, 1220f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1974f, 1616f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 964f, 380f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1216f, 1247f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1062f, 1439f);
			this.grainSize = Mathf.Clamp(this.grainSize, 422f, 1464f);
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x00524590 File Offset: 0x00522790
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.FDJOLBACPBC();
			if (this.DDDPCCODKBJ <= 1413f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 50f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.DIDMFKOIPCF();
			material.SetTexture("_DeepTex", this.grainTexture);
			material.SetTexture("_Parameter", this.scratchTexture);
			float num = 1535f / this.grainSize;
			material.SetVector("_camRotate", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("error", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 576f, 114f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x0052470C File Offset: 0x0052290C
		protected void DHJDMKLBLEF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("hand");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x00524780 File Offset: 0x00522980
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.EMLIANCPHFD();
			if (this.DDDPCCODKBJ <= 134f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 636f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.LDICPMNOPIG();
			material.SetTexture("name", this.grainTexture);
			material.SetTexture("KatanaReady", this.scratchTexture);
			float num = 592f / this.grainSize;
			material.SetVector("#002000", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Sound/Music/", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("chest", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1738f, 1428f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x005248FC File Offset: 0x00522AFC
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GJBLMFEPHNF();
			if (this.DDDPCCODKBJ <= 1584f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 201f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.IGBBHJBPOKM();
			material.SetTexture("PER_VERTEX", this.grainTexture);
			material.SetTexture("ClimbIdle", this.scratchTexture);
			float num = 6f / this.grainSize;
			material.SetVector("_MinVelocity", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("NO TURN", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("SteamManager.Initialized failed", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1869f, 1720f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x00524A78 File Offset: 0x00522C78
		protected void ALDMBECNFFO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_ZTest");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void NDHFCDEKJPC()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x00524AEC File Offset: 0x00522CEC
		private void CODDNDCIELP()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 217f, 378f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1798f, 1815f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1506f, 232f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1249f, 591f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1304f, 1068f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1870f, 1213f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1449f, 1542f);
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x00524BB8 File Offset: 0x00522DB8
		private void EKMKDLLLGFB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 690f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1565f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.GNHBCDIHHEN();
			material.SetTexture("", this.grainTexture);
			material.SetTexture("SoccerKeeperDiveStrafeCloseLeft", this.scratchTexture);
			float num = 156f / this.grainSize;
			material.SetVector(" remnabor=", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Actor", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("47412", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1119f, 818f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x00524D34 File Offset: 0x00522F34
		private void JJDPIILDEFA()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 466f, 1651f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 137f, 1063f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1556f, 149f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 619f, 238f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1282f, 1745f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 318f, 1633f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1251f, 466f);
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x00524E00 File Offset: 0x00523000
		protected void PNJHMJNFPLP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("gi_uinf_6");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8DA RID: 47322 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void OFDECDNDGJI()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x00524E74 File Offset: 0x00523074
		protected Material MNJNELAGPNJ()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)115;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void DGCMCCCLLGA()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x00524F00 File Offset: 0x00523100
		private void PLBCDDJKJHA()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 240f, 810f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1839f, 783f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 86f, 694f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 408f, 1009f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 647f, 1183f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1269f, 602f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1113f, 1235f);
		}

		// Token: 0x0600B8DE RID: 47326 RVA: 0x00524FCC File Offset: 0x005231CC
		private void GJBLMFEPHNF()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 4f, 378f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1385f, 335f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1603f, 257f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 823f, 1579f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 569f, 1016f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1827f, 199f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1140f, 968f);
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x00525098 File Offset: 0x00523298
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 711f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1449f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.IGBBHJBPOKM();
			material.SetTexture("_ToneCurveRange", this.grainTexture);
			material.SetTexture("/", this.scratchTexture);
			float num = 502f / this.grainSize;
			material.SetVector(" ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Steam Overlay has been activated", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_info", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1227f, 1693f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x00525214 File Offset: 0x00523414
		protected void EJOAPOGPBFM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("WeaponRun");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x00525288 File Offset: 0x00523488
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.PNHBMANPJBO();
			if (this.DDDPCCODKBJ <= 1130f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 998f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.DIDMFKOIPCF();
			material.SetTexture("FOG_AREA_BOX", this.grainTexture);
			material.SetTexture("☰☰☰", this.scratchTexture);
			float num = 125f / this.grainSize;
			material.SetVector("_MainTex", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Horizontal", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("\n", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 37f, 1903f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x00525404 File Offset: 0x00523604
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GJBLMFEPHNF();
			if (this.DDDPCCODKBJ <= 310f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1821f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.BNLLIMNHNPH();
			material.SetTexture("_ZTest", this.grainTexture);
			material.SetTexture("USE_DIAG_SEARCH", this.scratchTexture);
			float num = 71f / this.grainSize;
			material.SetVector("0", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("\n", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("RollerBladeTurnRight", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1147f, 199f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x00525580 File Offset: 0x00523780
		private void EMLIANCPHFD()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1784f, 672f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1131f, 651f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 423f, 974f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1613f, 1548f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 457f, 73f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1935f, 1068f);
			this.grainSize = Mathf.Clamp(this.grainSize, 59f, 296f);
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x0052564C File Offset: 0x0052384C
		protected Material EGMHMPFOIHD()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)113;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void KIMKMJMMLLB()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x005256D8 File Offset: 0x005238D8
		private void CLKDIJKDGJH()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1656f, 455f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 374f, 1981f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 343f, 1460f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1109f, 1162f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 419f, 884f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1498f, 1346f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1754f, 1375f);
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void GBAEKFJBEFM()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x005257A4 File Offset: 0x005239A4
		protected Material DIDMFKOIPCF()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = ~HideFlags.HideInInspector;
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)125;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x00525830 File Offset: 0x00523A30
		protected void KIEIPFFEDHC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("CATRigL");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x005258A4 File Offset: 0x00523AA4
		protected void KMMEMAHCFLJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_LayerThickness");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x00525918 File Offset: 0x00523B18
		protected void JFFPLABGMNF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_ReflectionTexture2");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x0052598C File Offset: 0x00523B8C
		private void JCOOPIFFNNH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.OPPBLICIFCC();
			if (this.DDDPCCODKBJ <= 280f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1182f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.EDEDNLPOMIN();
			material.SetTexture("CheckResources () for ", this.grainTexture);
			material.SetTexture("wpn_cmp", this.scratchTexture);
			float num = 1561f / this.grainSize;
			material.SetVector("Hit Point WeightCurve length is zero.", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_WhiteBalance", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("{0} : {1}", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 679f, 248f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x00525B08 File Offset: 0x00523D08
		protected void DOHJPDNKALP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("[F_EXP]");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x00525B7C File Offset: 0x00523D7C
		private void BPCCFPOPPDM()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1499f, 1543f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 507f, 1343f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 907f, 820f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1108f, 783f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1222f, 367f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 283f, 512f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1758f, 493f);
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void HGHMNMOCPJC()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x00525C48 File Offset: 0x00523E48
		private void LAAHBNBACMJ()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 0f, 5f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 0f, 5f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 0f, 5f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 0f, 5f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1f, 30f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 0f, 1f);
			this.grainSize = Mathf.Clamp(this.grainSize, 0.1f, 50f);
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void EACKHNENAML()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x00525D14 File Offset: 0x00523F14
		protected Material MHNAJNGGDFJ
		{
			get
			{
				if (this.KKEBFBPMPFO == null)
				{
					this.KKEBFBPMPFO = new Material(this.shaderRGB);
					this.KKEBFBPMPFO.hideFlags = HideFlags.HideAndDontSave;
				}
				if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
				{
					this.PPBBKDKMDLN = new Material(this.shaderYUV);
					this.PPBBKDKMDLN.hideFlags = HideFlags.HideAndDontSave;
				}
				if (this.KDHNINPHEIC || this.monochrome)
				{
					return this.KKEBFBPMPFO;
				}
				return this.PPBBKDKMDLN;
			}
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x00525DA0 File Offset: 0x00523FA0
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.OPPBLICIFCC();
			if (this.DDDPCCODKBJ <= 561f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1309f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.CDHGPDDEKDF();
			material.SetTexture("Knees Idle", this.grainTexture);
			material.SetTexture("1HandSwordRollAttack", this.scratchTexture);
			float num = 834f / this.grainSize;
			material.SetVector("name", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("U", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_DstBlend", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 434f, 1227f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x00525F1C File Offset: 0x0052411C
		protected Material FIPCLFODIIL()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = ~HideFlags.DontSaveInEditor;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x00525FA8 File Offset: 0x005241A8
		protected Material HKFFCHHJABN()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)104;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x00526034 File Offset: 0x00524234
		protected void LGPJEFMIIOL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("toe");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void IOPEDDLLPPL()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x005260A8 File Offset: 0x005242A8
		protected Material MAAJANGMIIL()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags)(-103);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x00526134 File Offset: 0x00524334
		private void MFEOIGILLPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.KANDGCBKHMM();
			if (this.DDDPCCODKBJ <= 62f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1362f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.LDICPMNOPIG();
			material.SetTexture("_Exposure", this.grainTexture);
			material.SetTexture("CP0", this.scratchTexture);
			float num = 1627f / this.grainSize;
			material.SetVector("wpn_add/addoptions", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("\n", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("name", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 658f, 241f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x005262B0 File Offset: 0x005244B0
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.LAAHBNBACMJ();
			if (this.DDDPCCODKBJ <= 0f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 2f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MHNAJNGGDFJ;
			material.SetTexture("_GrainTex", this.grainTexture);
			material.SetTexture("_ScratchTex", this.scratchTexture);
			float num = 1f / this.grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 0f, 0f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void FKDGPHFONPB()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x0052642C File Offset: 0x0052462C
		private void IAKFCAIJBCF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.LAAHBNBACMJ();
			if (this.DDDPCCODKBJ <= 1455f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1762f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MHNAJNGGDFJ;
			material.SetTexture("[fish]", this.grainTexture);
			material.SetTexture("GetPoints() is not applicable to IKSolverVR.", this.scratchTexture);
			float num = 1515f / this.grainSize;
			material.SetVector("[ACTk] <b>[ ObscuredInt test ]</b>", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("HYPERLINK", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector(" ", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1566f, 874f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x005265A8 File Offset: 0x005247A8
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.ECNBDOBJLNL();
			if (this.DDDPCCODKBJ <= 1470f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 593f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.EGMHMPFOIHD();
			material.SetTexture("ok", this.grainTexture);
			material.SetTexture("cntx_close", this.scratchTexture);
			float num = 1356f / this.grainSize;
			material.SetVector("B", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Katana", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("ApplePick", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1350f, 670f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B8FE RID: 47358 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void NGKEFEKCMOD()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B8FF RID: 47359 RVA: 0x00526724 File Offset: 0x00524924
		private void CCIHPHKDIJL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CDOBAMMNKEI();
			if (this.DDDPCCODKBJ <= 1876f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 428f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.GNHBCDIHHEN();
			material.SetTexture("_Color", this.grainTexture);
			material.SetTexture("_CameraClipInfo", this.scratchTexture);
			float num = 1927f / this.grainSize;
			material.SetVector(",", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Initiating IKSolver with null root Transform.", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("SneakLeft", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 487f, 801f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x005268A0 File Offset: 0x00524AA0
		protected void JCELICPHGEP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log(" ");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x00526914 File Offset: 0x00524B14
		private void OHFAHGGDOCJ()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 380f, 1383f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1493f, 210f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1468f, 1465f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 433f, 29f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1604f, 1421f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 4f, 73f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1478f, 1043f);
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x005269E0 File Offset: 0x00524BE0
		protected Material IGBBHJBPOKM()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags)119;
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)102;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x00526A6C File Offset: 0x00524C6C
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.OODHNDFBIDD();
			if (this.DDDPCCODKBJ <= 842f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1414f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.GNHBCDIHHEN();
			material.SetTexture("Pistol Fire", this.grainTexture);
			material.SetTexture("TOD_kRadius", this.scratchTexture);
			float num = 322f / this.grainSize;
			material.SetVector("IceHockey Goalie Save 2", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("002000", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 687f, 1366f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x00526BE8 File Offset: 0x00524DE8
		protected void PFNPOHMMJDN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("off");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x00526C5C File Offset: 0x00524E5C
		protected Material CDHGPDDEKDF()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)112;
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x00526CE8 File Offset: 0x00524EE8
		private void BDAJHMMPEBP()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 655f, 1356f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 785f, 837f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 77f, 524f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 778f, 1914f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1205f, 822f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1996f, 1942f);
			this.grainSize = Mathf.Clamp(this.grainSize, 564f, 496f);
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void AHDAOLPGGMC()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x00526DB4 File Offset: 0x00524FB4
		private void OOGLBECFKMC()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 918f, 1223f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 431f, 1323f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 36f, 427f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 829f, 1376f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 921f, 961f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1649f, 1657f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1132f, 1986f);
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x00526E80 File Offset: 0x00525080
		protected void CAJLCEPLKJG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("<color='#602000'>");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void OJAIBDJPLHA()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x00526EF4 File Offset: 0x005250F4
		private void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.OODHNDFBIDD();
			if (this.DDDPCCODKBJ <= 967f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 408f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.EGMHMPFOIHD();
			material.SetTexture("^(", this.grainTexture);
			material.SetTexture("Hit Point WeightCurve length is zero.", this.scratchTexture);
			float num = 458f / this.grainSize;
			material.SetVector("Speed hack detected!", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("cht_msg26", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("-H", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 500f, 1637f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void EALKANLKOHI()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void BAAAOKJHGAO()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void HACJAOEBLFG()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void PIPJPGGEFOL()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x00527070 File Offset: 0x00525270
		protected void FDBNPLCPFJB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_WorldLightDir");
				base.enabled = true;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x005270E4 File Offset: 0x005252E4
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 185f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 634f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.EDEDNLPOMIN();
			material.SetTexture("[X]", this.grainTexture);
			material.SetTexture("Couldn't get avatar.", this.scratchTexture);
			float num = 959f / this.grainSize;
			material.SetVector("\n", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("FistPump2", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("SAMPLES_VERY_LOW", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1678f, 819f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x00527260 File Offset: 0x00525460
		protected Material HKNPNNOPPBD()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags)76;
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x005272EC File Offset: 0x005254EC
		protected void GDIMBBBPIHI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Blank Overcast Texture Missing...");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x00527360 File Offset: 0x00525560
		private void CDOBAMMNKEI()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 601f, 817f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1394f, 811f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 560f, 1757f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 127f, 1473f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 672f, 974f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 407f, 694f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1347f, 1379f);
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x0052742C File Offset: 0x0052562C
		protected void MODJFGGIAHD()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("SoccerStartKick");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x005274A0 File Offset: 0x005256A0
		protected void CGMHGDEKDEP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("UIChat_channel");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x00527514 File Offset: 0x00525714
		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x00527588 File Offset: 0x00525788
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CLKDIJKDGJH();
			if (this.DDDPCCODKBJ <= 304f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 329f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.EGMHMPFOIHD();
			material.SetTexture("1HandSwordShieldBash", this.grainTexture);
			material.SetTexture("gi_inte_1", this.scratchTexture);
			float num = 1210f / this.grainSize;
			material.SetVector("", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Sorry, VRIK Script reference is not finished yet.", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("Roar", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 279f, 1525f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x00527704 File Offset: 0x00525904
		private void NJLOPOBJHAC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 1252f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 146f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.CDHGPDDEKDF();
			material.SetTexture("StrafeRunLeft", this.grainTexture);
			material.SetTexture("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.scratchTexture);
			float num = 1832f / this.grainSize;
			material.SetVector("", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Jump", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("\n", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 422f, 833f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void JIGLHJINLFH()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x00527880 File Offset: 0x00525A80
		private void IOFFNEIOBEL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 960f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1183f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.DIDMFKOIPCF();
			material.SetTexture("foot", this.grainTexture);
			material.SetTexture("Assets/Weapons/baseLegs.unity3d", this.scratchTexture);
			float num = 15f / this.grainSize;
			material.SetVector("droplinemsg2", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("act_order", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_FogWindDir", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 254f, 75f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x005279FC File Offset: 0x00525BFC
		private void NHFAFJMICKJ()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1113f, 299f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1367f, 1237f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 180f, 624f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1f, 332f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1271f, 757f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1250f, 1473f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1359f, 1685f);
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x00527AC8 File Offset: 0x00525CC8
		private void ANHFNJJHGPO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.EBFEDJMCKHI();
			if (this.DDDPCCODKBJ <= 1432f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 436f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.DIDMFKOIPCF();
			material.SetTexture("GiantGrabIdle2", this.grainTexture);
			material.SetTexture("1HSwordStrafeRunLeft", this.scratchTexture);
			float num = 831f / this.grainSize;
			material.SetVector("type_", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Flashlight", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1902f, 419f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void DCPLDAKDDBG()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x00527C44 File Offset: 0x00525E44
		private void JJCLKGHJCGB()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 278f, 1682f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1344f, 1237f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 43f, 1125f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 301f, 751f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1185f, 1641f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 344f, 788f);
			this.grainSize = Mathf.Clamp(this.grainSize, 417f, 1686f);
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void LFJPJFCLGKE()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x00527D10 File Offset: 0x00525F10
		private void ECNBDOBJLNL()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1402f, 1310f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1323f, 207f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 470f, 1553f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1616f, 511f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 399f, 1442f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 398f, 1262f);
			this.grainSize = Mathf.Clamp(this.grainSize, 224f, 1923f);
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x00527DDC File Offset: 0x00525FDC
		private void CAJNOJOCPGB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.EMLIANCPHFD();
			if (this.DDDPCCODKBJ <= 549f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 606f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MFJAILMGELI();
			material.SetTexture("RollerBladeTurnRight", this.grainTexture);
			material.SetTexture("selectedTask", this.scratchTexture);
			float num = 103f / this.grainSize;
			material.SetVector("Wizard2HandThrow", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("demoRect", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector(" ms", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 748f, 1262f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x00527F58 File Offset: 0x00526158
		protected void EGDBNKCJOCD()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("wpn_lv");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B924 RID: 47396 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void EIDIHAJDMCI()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x00527FCC File Offset: 0x005261CC
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CDOBAMMNKEI();
			if (this.DDDPCCODKBJ <= 1046f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1571f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.HKFFCHHJABN();
			material.SetTexture("OneHandSwordJab", this.grainTexture);
			material.SetTexture("ClimbUp", this.scratchTexture);
			float num = 1727f / this.grainSize;
			material.SetVector("offsets", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("\n", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1350f, 1776f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x00528148 File Offset: 0x00526348
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.NHFAFJMICKJ();
			if (this.DDDPCCODKBJ <= 1327f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1736f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.MAAJANGMIIL();
			material.SetTexture(" ", this.grainTexture);
			material.SetTexture(" is represented more than once in IKSolverFABRIKRoot chain.", this.scratchTexture);
			float num = 732f / this.grainSize;
			material.SetVector("TOD_CloudSharpness", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("#FF4040", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("23", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1003f, 807f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x005282C4 File Offset: 0x005264C4
		private void PNHBMANPJBO()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 305f, 268f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1862f, 430f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 624f, 1054f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1698f, 51f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 630f, 211f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 237f, 901f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1729f, 487f);
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x00528390 File Offset: 0x00526590
		private void KANDGCBKHMM()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 526f, 781f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1253f, 442f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 794f, 70f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1052f, 1455f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 825f, 630f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 79f, 765f);
			this.grainSize = Mathf.Clamp(this.grainSize, 189f, 647f);
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x0052845C File Offset: 0x0052665C
		protected Material MFJAILMGELI()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = (HideFlags)119;
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x005284E8 File Offset: 0x005266E8
		private void NOKLDCHLBHF()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 456f, 673f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 675f, 581f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1911f, 1086f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 989f, 602f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 78f, 1196f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1598f, 343f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1534f, 782f);
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x005285B4 File Offset: 0x005267B4
		protected Material GNHBCDIHHEN()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = (HideFlags)(-103);
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x00528640 File Offset: 0x00526840
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CODDNDCIELP();
			if (this.DDDPCCODKBJ <= 1944f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1993f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.LDICPMNOPIG();
			material.SetTexture("_MainTex", this.grainTexture);
			material.SetTexture("Soccer Throw", this.scratchTexture);
			float num = 1146f / this.grainSize;
			material.SetVector("WandStand", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("OnChatMessage", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("musicVolume", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 177f, 868f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x005287BC File Offset: 0x005269BC
		private void OPPBLICIFCC()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 990f, 899f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1449f, 767f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 45f, 935f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 895f, 1676f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1603f, 144f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1207f, 481f);
			this.grainSize = Mathf.Clamp(this.grainSize, 544f, 1937f);
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void AHMFIGNLJOB()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void BNOLDFLILJA()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x00522DDE File Offset: 0x00520FDE
		protected void DFCJDHJGILP()
		{
			if (this.KKEBFBPMPFO)
			{
				UnityEngine.Object.DestroyImmediate(this.KKEBFBPMPFO);
			}
			if (this.PPBBKDKMDLN)
			{
				UnityEngine.Object.DestroyImmediate(this.PPBBKDKMDLN);
			}
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x00528888 File Offset: 0x00526A88
		protected void ECMAANIDEBA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = true;
			}
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x005288FC File Offset: 0x00526AFC
		private void EBFEDJMCKHI()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1756f, 388f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 385f, 654f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1863f, 1280f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 527f, 592f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1066f, 742f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 90f, 1426f);
			this.grainSize = Mathf.Clamp(this.grainSize, 297f, 222f);
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x005289C8 File Offset: 0x00526BC8
		protected void LBEFOABPMFG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("aa=");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x00528A3C File Offset: 0x00526C3C
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.GDNBEMIGCKN();
			if (this.DDDPCCODKBJ <= 76f)
			{
				this.DDDPCCODKBJ = UnityEngine.Random.value * 1372f / this.scratchFPS;
				this.ABMGBLINCAO = UnityEngine.Random.value;
				this.KAPOHJHHDBC = UnityEngine.Random.value;
			}
			this.DDDPCCODKBJ -= Time.deltaTime;
			Material material = this.IGBBHJBPOKM();
			material.SetTexture("C", this.grainTexture);
			material.SetTexture("wpn_rod1", this.scratchTexture);
			float num = 362f / this.grainSize;
			material.SetVector("SUNSHINE_THREE_CASCADES", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector(" registered.", new Vector4(this.ABMGBLINCAO + UnityEngine.Random.value * this.scratchJitter, this.KAPOHJHHDBC + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("cntx_close", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 470f, 1835f));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material);
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x00528BB8 File Offset: 0x00526DB8
		protected Material LDICPMNOPIG()
		{
			if (this.KKEBFBPMPFO == null)
			{
				this.KKEBFBPMPFO = new Material(this.shaderRGB);
				this.KKEBFBPMPFO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.PPBBKDKMDLN == null && !this.KDHNINPHEIC)
			{
				this.PPBBKDKMDLN = new Material(this.shaderYUV);
				this.PPBBKDKMDLN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.KDHNINPHEIC || this.monochrome)
			{
				return this.KKEBFBPMPFO;
			}
			return this.PPBBKDKMDLN;
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x00528C44 File Offset: 0x00526E44
		protected void HDGNIHBIEDG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log(" on effect ");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.KDHNINPHEIC = false;
			}
		}

		// Token: 0x0400181E RID: 6174
		public bool monochrome = true;

		// Token: 0x0400181F RID: 6175
		private bool KDHNINPHEIC;

		// Token: 0x04001820 RID: 6176
		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		// Token: 0x04001821 RID: 6177
		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		// Token: 0x04001822 RID: 6178
		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		// Token: 0x04001823 RID: 6179
		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		// Token: 0x04001824 RID: 6180
		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		// Token: 0x04001825 RID: 6181
		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		// Token: 0x04001826 RID: 6182
		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		// Token: 0x04001827 RID: 6183
		public Texture grainTexture;

		// Token: 0x04001828 RID: 6184
		public Texture scratchTexture;

		// Token: 0x04001829 RID: 6185
		public Shader shaderRGB;

		// Token: 0x0400182A RID: 6186
		public Shader shaderYUV;

		// Token: 0x0400182B RID: 6187
		private Material KKEBFBPMPFO;

		// Token: 0x0400182C RID: 6188
		private Material PPBBKDKMDLN;

		// Token: 0x0400182D RID: 6189
		private float DDDPCCODKBJ;

		// Token: 0x0400182E RID: 6190
		private float ABMGBLINCAO;

		// Token: 0x0400182F RID: 6191
		private float KAPOHJHHDBC;
	}
}
