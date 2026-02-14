using System;
using UnityEngine;

// Token: 0x02000082 RID: 130
[ExecuteInEditMode]
public class CRTEffect : MonoBehaviour
{
	// Token: 0x06001E6F RID: 7791 RVA: 0x000E70B8 File Offset: 0x000E52B8
	private void JHHHJFOOFII(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.HKFLAPHIKHL().SetFloat("t_hair", this.Distortion);
			this.MHNAJNGGDFJ.SetFloat("<color='#300000'>{0} {1}</color>", this.InputGamma);
			this.HKFLAPHIKHL().SetFloat(" iterations for read and write", this.OutputGamma);
			this.MHNAJNGGDFJ.SetVector("gi_inte_3", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.JMDMNMEHAPM());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x000E7150 File Offset: 0x000E5350
	private void OnRenderImage(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.MHNAJNGGDFJ.SetFloat("_Distortion", this.Distortion);
			this.MHNAJNGGDFJ.SetFloat("_InputGamma", this.InputGamma);
			this.MHNAJNGGDFJ.SetFloat("_OutputGamma", this.OutputGamma);
			this.MHNAJNGGDFJ.SetVector("_TextureSize", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.MHNAJNGGDFJ);
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000E71E8 File Offset: 0x000E53E8
	private Material MHNAJNGGDFJ
	{
		get
		{
			if (this.OJCAFNCAAPK == null)
			{
				this.OJCAFNCAAPK = new Material(this.curShader);
				this.OJCAFNCAAPK.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.OJCAFNCAAPK;
		}
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x000E721C File Offset: 0x000E541C
	private Material ELEELKDEAJN()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)118;
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x000E7250 File Offset: 0x000E5450
	private void NJBEKBHCLIO()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x000E7250 File Offset: 0x000E5450
	private void BABMAHFKPMO()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000E726C File Offset: 0x000E546C
	private void PNEFMGMHLJE(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.ALIMBELCEAL().SetFloat("invn_rec2", this.Distortion);
			this.ILEJDOCOINE().SetFloat("\n", this.InputGamma);
			this.FGAJPMBIKLO().SetFloat("GestureHandUp", this.OutputGamma);
			this.ILEJDOCOINE().SetVector("</color>\n", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.IOIGFMMJKNA());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMLNBHIIGKH()
	{
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IKHCCAANGOP()
	{
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000E7250 File Offset: 0x000E5450
	private void JIGLHJINLFH()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x000E7304 File Offset: 0x000E5504
	private void IOFFNEIOBEL(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.ALIMBELCEAL().SetFloat("IdleButtonPress", this.Distortion);
			this.ELEELKDEAJN().SetFloat("Cowboy1HandDraw", this.InputGamma);
			this.FGAJPMBIKLO().SetFloat("fishStamKF=", this.OutputGamma);
			this.LJPCILFOEPA().SetVector("UIChat_pos", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.KIBLMGMPOJD());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000E739C File Offset: 0x000E559C
	private void KEMGOLACEHI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x000E7250 File Offset: 0x000E5450
	private void PIPJPGGEFOL()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x000E73AD File Offset: 0x000E55AD
	private Material ALIMBELCEAL()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)(-113);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPDCJCFMIPE()
	{
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000E7250 File Offset: 0x000E5450
	private void MLPCBOGCEEO()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x000E739C File Offset: 0x000E559C
	private void DGGMJCMLLED()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HAIMGCDKPDC()
	{
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000E73E4 File Offset: 0x000E55E4
	private void EEDJEMLFJKP(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.LBGANKEOJEE().SetFloat("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.", this.Distortion);
			this.ELEELKDEAJN().SetFloat("IKMappingSpine is missing the left thigh bone.", this.InputGamma);
			this.KIBLMGMPOJD().SetFloat("Vertical", this.OutputGamma);
			this.IOIGFMMJKNA().SetVector("Index out of range.", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.KABDJNIDNDC());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PMKOAHMNBBG()
	{
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JPHLMNIMDHH()
	{
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x000E74B0 File Offset: 0x000E56B0
	private Material ILEJDOCOINE()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)74;
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMFOECIPBIP()
	{
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x000E739C File Offset: 0x000E559C
	private void EFJDBBDMPMC()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x000E74E4 File Offset: 0x000E56E4
	private void OJBKOLJAHAO(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.HKFLAPHIKHL().SetFloat("Horizontal", this.Distortion);
			this.KABDJNIDNDC().SetFloat("CrouchStrafeLeft", this.InputGamma);
			this.IOIGFMMJKNA().SetFloat("_FogBaseHeight", this.OutputGamma);
			this.KABDJNIDNDC().SetVector("", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.LBGANKEOJEE());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x000E7250 File Offset: 0x000E5450
	private void NJFOOJIADNH()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLFBDOPFDDJ()
	{
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIAMIFEPALP()
	{
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x000E757C File Offset: 0x000E577C
	private Material FGAJPMBIKLO()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIFOELPAEHG()
	{
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x000E75B0 File Offset: 0x000E57B0
	private void EDCBFNNHICN(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.HKFLAPHIKHL().SetFloat("knopje.wav", this.Distortion);
			this.HKFLAPHIKHL().SetFloat("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.", this.InputGamma);
			this.ALIMBELCEAL().SetFloat("111111111222\n33333333", this.OutputGamma);
			this.ALIMBELCEAL().SetVector("Root Node bone is null. FBBIK will not initiate.", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.JMDMNMEHAPM());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LIOCDEICIFD()
	{
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000E7648 File Offset: 0x000E5848
	private Material JMDMNMEHAPM()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)(-91);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000E767C File Offset: 0x000E587C
	private void KKCFKEDABLB()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x000E739C File Offset: 0x000E559C
	private void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x000E7690 File Offset: 0x000E5890
	private void IBILMNLCCJJ(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.KABDJNIDNDC().SetFloat("wpn_eat1", this.Distortion);
			this.ALIMBELCEAL().SetFloat("WorkerShovel", this.InputGamma);
			this.ELEELKDEAJN().SetFloat("_RgbTex", this.OutputGamma);
			this.KIBLMGMPOJD().SetVector("Bases/{0}/", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.IOIGFMMJKNA());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x000E7728 File Offset: 0x000E5928
	private Material IOIGFMMJKNA()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)(-110);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x000E739C File Offset: 0x000E559C
	private void EHDPACPIBNF()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFPPDNHLCCA()
	{
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x000E7648 File Offset: 0x000E5848
	private Material KABDJNIDNDC()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)(-91);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CBBLGEDCJBF()
	{
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x000E7250 File Offset: 0x000E5450
	private void OnDisable()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x000E775C File Offset: 0x000E595C
	private Material LBGANKEOJEE()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)75;
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x000E7790 File Offset: 0x000E5990
	private Material LJPCILFOEPA()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags)82;
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000E77C4 File Offset: 0x000E59C4
	private Material HKFLAPHIKHL()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HMLNMHOMMNO()
	{
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x000E7250 File Offset: 0x000E5450
	private void ONPDNGNNBIG()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x000E739C File Offset: 0x000E559C
	private void IMABGALEMBI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x000E77F8 File Offset: 0x000E59F8
	private Material KIBLMGMPOJD()
	{
		if (this.OJCAFNCAAPK == null)
		{
			this.OJCAFNCAAPK = new Material(this.curShader);
			this.OJCAFNCAAPK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.OJCAFNCAAPK;
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x000E782C File Offset: 0x000E5A2C
	private void KHHBBMHGMIH(RenderTexture HAFEMHDILBB, RenderTexture LIJLNONNFOI)
	{
		if (this.curShader != null)
		{
			this.ALIMBELCEAL().SetFloat("SwimDogPaddle", this.Distortion);
			this.HKFLAPHIKHL().SetFloat("MotorbikeWheely", this.InputGamma);
			this.ALIMBELCEAL().SetFloat("MotorbikeSeatStandWheely", this.OutputGamma);
			this.JMDMNMEHAPM().SetVector("", new Vector2(this.TextureSize, this.TextureSize));
			Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI, this.LJPCILFOEPA());
			return;
		}
		Graphics.Blit(HAFEMHDILBB, LIJLNONNFOI);
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x000E7250 File Offset: 0x000E5450
	private void PCKOPPKGENK()
	{
		if (this.OJCAFNCAAPK)
		{
			UnityEngine.Object.DestroyImmediate(this.OJCAFNCAAPK);
		}
	}

	// Token: 0x04000322 RID: 802
	public Shader curShader;

	// Token: 0x04000323 RID: 803
	public float Distortion = 0.1f;

	// Token: 0x04000324 RID: 804
	public float InputGamma = 2.4f;

	// Token: 0x04000325 RID: 805
	public float OutputGamma = 2.2f;

	// Token: 0x04000326 RID: 806
	public float TextureSize = 768f;

	// Token: 0x04000327 RID: 807
	private Material OJCAFNCAAPK;
}
