using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200029F RID: 671
public class WinSettings : MonoBehaviour
{
	// Token: 0x06009D41 RID: 40257 RVA: 0x004690A4 File Offset: 0x004672A4
	public string HOKKNLBOLDH()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		string result = string.Format("IdleDie", bgjkmcbhnak.KDHENOMNPHK);
		if (num == 0)
		{
			result = "wpnlang/wpntypes/type";
		}
		if (num == -45)
		{
			result = "emergencyMode";
		}
		return result;
	}

	// Token: 0x06009D42 RID: 40258 RVA: 0x004690EC File Offset: 0x004672EC
	public void BADFDJEMGJO(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.KJGPJJPBCPH();
	}

	// Token: 0x06009D43 RID: 40259 RVA: 0x00469118 File Offset: 0x00467318
	public void APIJBMKFMIP(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log(",");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			bgjkmcbhnak.GLKEIPMPKAH(this.slider.value);
		}
		this.CDKKDIMGANB = true;
	}

	// Token: 0x06009D44 RID: 40260 RVA: 0x004691B4 File Offset: 0x004673B4
	public void JABKLCKPJKI(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log("release");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			bgjkmcbhnak.GLKEIPMPKAH(this.slider.value);
		}
		this.CDKKDIMGANB = false;
	}

	// Token: 0x06009D45 RID: 40261 RVA: 0x00469250 File Offset: 0x00467450
	private void Update()
	{
		this.updatePosition();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(false);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
			float z = Mathf.Lerp(180f, 0f, (float)Mathf.RoundToInt((float)num) / 21f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D46 RID: 40262 RVA: 0x00022FCC File Offset: 0x000211CC
	public void INPDDHDPEBJ()
	{
	}

	// Token: 0x06009D47 RID: 40263 RVA: 0x00469310 File Offset: 0x00467510
	private void OOGPDGBACLC()
	{
		this.FMAIACOBNAL();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == -77)
			{
				this.poplPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == -52)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == -103)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D48 RID: 40264 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BFMEFDJJJAG()
	{
	}

	// Token: 0x06009D49 RID: 40265 RVA: 0x004693DC File Offset: 0x004675DC
	public void LMABFDJBIOL()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
		if (num == -37)
		{
			this.fricClose.volume = 1750f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 1224f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 818f;
		this.fricClick.volume = 1741f;
		this.fricClick.pitch = 1244f + num2 * 1836f - 380f;
		this.fricClick.Play();
	}

	// Token: 0x06009D4A RID: 40266 RVA: 0x0046947C File Offset: 0x0046767C
	public void BHKKOPGIENG()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
		if (num == 12)
		{
			this.fricClose.volume = 20f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 732f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 1797f;
		this.fricClick.volume = 315f;
		this.fricClick.pitch = 1034f + num2 * 750f - 788f;
		this.fricClick.Play();
	}

	// Token: 0x06009D4B RID: 40267 RVA: 0x0046951C File Offset: 0x0046771C
	public void BCFOIDHNFOP(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = false;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("gi_cachshe", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D4C RID: 40268 RVA: 0x00469588 File Offset: 0x00467788
	public void DLNJPOKBLEJ(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		bgjkmcbhnak.CJLKGICPCAJ = this.sliderFric.value;
		int num2 = bgjkmcbhnak.CMKFMNBBPNE();
		this.CJABEAKFHOF();
		if (num != num2)
		{
			this.playSoundFric();
		}
	}

	// Token: 0x06009D4D RID: 40269 RVA: 0x004695E4 File Offset: 0x004677E4
	private void MFOGDJHDIDA()
	{
		this.FMAIACOBNAL();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(false);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 81)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -91)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -118)
			{
				this.spinPan.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06009D4E RID: 40270 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IHGILNKDOMH()
	{
	}

	// Token: 0x06009D4F RID: 40271 RVA: 0x004696AE File Offset: 0x004678AE
	public void JFBJDJIHFCI(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009D50 RID: 40272 RVA: 0x004696CC File Offset: 0x004678CC
	public void OnChangeDeep(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log("* change");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			bgjkmcbhnak.CLEJODCMJAA = this.slider.value;
		}
		this.CDKKDIMGANB = false;
	}

	// Token: 0x06009D51 RID: 40273 RVA: 0x00469766 File Offset: 0x00467966
	public void AIDCEKKPMIK(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.PODHOOMBLHI();
	}

	// Token: 0x06009D52 RID: 40274 RVA: 0x00469794 File Offset: 0x00467994
	private void NKKHCJDLMII()
	{
		this.FFGEHEIEHEK();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(false);
		this.fiderPan.gameObject.SetActive(false);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == -33)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -38)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == 68)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D53 RID: 40275 RVA: 0x00469860 File Offset: 0x00467A60
	private void DNPKJPPIHOO()
	{
		this.AMIJJOCDOCK();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(false);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 8)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 58)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 107)
			{
				this.spinPan.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06009D54 RID: 40276 RVA: 0x0046992C File Offset: 0x00467B2C
	public void OnChangeFric(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		bgjkmcbhnak.CJLKGICPCAJ = this.sliderFric.value;
		int num2 = bgjkmcbhnak.GLNFJCIJHDL;
		this.KJGPJJPBCPH();
		if (num != num2)
		{
			this.playSoundFric();
		}
	}

	// Token: 0x06009D55 RID: 40277 RVA: 0x00469988 File Offset: 0x00467B88
	private void ACCKEFCOBGN()
	{
		this.CJABEAKFHOF();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == -76)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -65)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 97)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D56 RID: 40278 RVA: 0x00469A54 File Offset: 0x00467C54
	public void ENHIHPLDILL(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE());
	}

	// Token: 0x06009D57 RID: 40279 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ODIIEAIGLAE()
	{
	}

	// Token: 0x06009D58 RID: 40280 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EACDMIPIBLC()
	{
	}

	// Token: 0x06009D59 RID: 40281 RVA: 0x00469AC0 File Offset: 0x00467CC0
	private void PFPPDNHLCCA()
	{
		this.CNOAIEKIAND();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(false);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
			float z = Mathf.Lerp(1135f, 27f, (float)Mathf.RoundToInt((float)num) / 662f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D5B RID: 40283 RVA: 0x00469B80 File Offset: 0x00467D80
	public void PGENHFNBPKA(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		bgjkmcbhnak.ALIOGHFOFHO(this.sliderFric.value);
		int num2 = bgjkmcbhnak.CMKFMNBBPNE();
		this.GIEFBADELLK();
		if (num != num2)
		{
			this.EFLBGNKMLEE();
		}
	}

	// Token: 0x06009D5C RID: 40284 RVA: 0x00469BDC File Offset: 0x00467DDC
	private void AOABMLPHMME()
	{
		this.FMAIACOBNAL();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 19)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -126)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -98)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x00469CA6 File Offset: 0x00467EA6
	public void BEODKENAKLP(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.CJABEAKFHOF();
	}

	// Token: 0x06009D5E RID: 40286 RVA: 0x00469CD4 File Offset: 0x00467ED4
	public void ILKLIOLCMHP(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = false;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("Vertical", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D5F RID: 40287 RVA: 0x00469D3F File Offset: 0x00467F3F
	public void HEOEEBEDDNN(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.JNLAKILPPIC();
	}

	// Token: 0x06009D60 RID: 40288 RVA: 0x00469D6C File Offset: 0x00467F6C
	public string JIBKNGPLKEB()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		string result = string.Format("ActorFish_", bgjkmcbhnak.PFDMMPFBCJA());
		if (num == 0)
		{
			result = "_BlurRadius4";
		}
		if (num == 83)
		{
			result = "Mouse Y";
		}
		return result;
	}

	// Token: 0x06009D61 RID: 40289 RVA: 0x00469DB4 File Offset: 0x00467FB4
	public void LBADFNDNFPB(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.GIEFBADELLK();
	}

	// Token: 0x06009D62 RID: 40290 RVA: 0x00469DB4 File Offset: 0x00467FB4
	public void PGGMIDPPKIK(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.GIEFBADELLK();
	}

	// Token: 0x06009D63 RID: 40291 RVA: 0x00469DE0 File Offset: 0x00467FE0
	public void OEMHALJOOND(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = false;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("WeaponInstant", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D64 RID: 40292 RVA: 0x00469E4C File Offset: 0x0046804C
	public string HCANJFBBKAJ()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		string result = string.Format("Hidden/ACTk/WallHackTexture", bgjkmcbhnak.PFDMMPFBCJA());
		if (num == 0)
		{
			result = "31";
		}
		if (num == -53)
		{
			result = "PostFX - {0}";
		}
		return result;
	}

	// Token: 0x06009D65 RID: 40293 RVA: 0x00469E94 File Offset: 0x00468094
	public void MJNDGGFLODC(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.AMIJJOCDOCK();
	}

	// Token: 0x06009D66 RID: 40294 RVA: 0x00469EC0 File Offset: 0x004680C0
	public void EKPKOKCFIJO(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		bgjkmcbhnak.CJLKGICPCAJ = this.sliderFric.value;
		int num2 = bgjkmcbhnak.CMKFMNBBPNE();
		this.AMIJJOCDOCK();
		if (num != num2)
		{
			this.LMABFDJBIOL();
		}
	}

	// Token: 0x06009D67 RID: 40295 RVA: 0x00469F1C File Offset: 0x0046811C
	public void JJCKHIDKADE()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
		if (num == 113)
		{
			this.fricClose.volume = 502f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 43f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 1781f;
		this.fricClick.volume = 1143f;
		this.fricClick.pitch = 1979f + num2 * 1579f - 1824f;
		this.fricClick.Play();
	}

	// Token: 0x06009D68 RID: 40296 RVA: 0x00469FBC File Offset: 0x004681BC
	public void IDIMACNBHAI(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("IdleStun", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
	}

	// Token: 0x06009D69 RID: 40297 RVA: 0x0046A028 File Offset: 0x00468228
	private void MMKMNFOOIKL()
	{
		this.FMAIACOBNAL();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(false);
		this.fiderPan.gameObject.SetActive(false);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 86)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 70)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == 105)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D6A RID: 40298 RVA: 0x0046A0F4 File Offset: 0x004682F4
	public void AINDGNBGBBC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log("_MiddleGrey");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			bgjkmcbhnak.GLKEIPMPKAH(this.slider.value);
		}
		this.CDKKDIMGANB = false;
	}

	// Token: 0x06009D6B RID: 40299 RVA: 0x0046A18E File Offset: 0x0046838E
	public void NBFJPOPOBLA(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.FMAIACOBNAL();
	}

	// Token: 0x06009D6C RID: 40300 RVA: 0x0046A1BA File Offset: 0x004683BA
	private void JNLAKILPPIC()
	{
		this.fumText.text = this.getFricText();
	}

	// Token: 0x06009D6D RID: 40301 RVA: 0x00469E94 File Offset: 0x00468094
	public void OJLJMPCLDPC(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.AMIJJOCDOCK();
	}

	// Token: 0x06009D6E RID: 40302 RVA: 0x0046A1D0 File Offset: 0x004683D0
	public void CGILNHGLMJI(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format(" {0}", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
	}

	// Token: 0x06009D6F RID: 40303 RVA: 0x0046A23C File Offset: 0x0046843C
	public void JMFGLFEECFE(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("FlyUp", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
	}

	// Token: 0x06009D70 RID: 40304 RVA: 0x0046A2A8 File Offset: 0x004684A8
	public void LIBICGFJCOE()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
		if (num == -100)
		{
			this.fricClose.volume = 621f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 294f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 1091f;
		this.fricClick.volume = 122f;
		this.fricClick.pitch = 1957f + num2 * 305f - 1999f;
		this.fricClick.Play();
	}

	// Token: 0x06009D71 RID: 40305 RVA: 0x0046A1BA File Offset: 0x004683BA
	private void FMAIACOBNAL()
	{
		this.fumText.text = this.getFricText();
	}

	// Token: 0x06009D72 RID: 40306 RVA: 0x004696AE File Offset: 0x004678AE
	public void PKIKFICBMEO(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009D73 RID: 40307 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CNOAIEKIAND()
	{
	}

	// Token: 0x06009D74 RID: 40308 RVA: 0x0046A348 File Offset: 0x00468548
	public void LFADIBMDPAC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log("BC ");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			bgjkmcbhnak.HFENEGIBAIG(this.slider.value);
		}
		this.CDKKDIMGANB = true;
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x0046A3E4 File Offset: 0x004685E4
	private void MPNHAGONKBG()
	{
		this.FMAIACOBNAL();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 48)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 15)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -36)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D76 RID: 40310 RVA: 0x0046A4AE File Offset: 0x004686AE
	private void CJABEAKFHOF()
	{
		this.fumText.text = this.NMDLONOBDKJ();
	}

	// Token: 0x06009D77 RID: 40311 RVA: 0x0046A4C4 File Offset: 0x004686C4
	private void BBDOHOKDBLO()
	{
		this.JNLAKILPPIC();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(false);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == -30)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -43)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == 87)
			{
				this.spinPan.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AIPEHONDCNN()
	{
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x0046A58E File Offset: 0x0046878E
	private void FFGEHEIEHEK()
	{
		this.fumText.text = this.ENCLLABMMHP();
	}

	// Token: 0x06009D7A RID: 40314 RVA: 0x0046A5A1 File Offset: 0x004687A1
	private void PCCPIKIEEPD()
	{
		this.fumText.text = this.MONBBLNMFBM();
	}

	// Token: 0x06009D7B RID: 40315 RVA: 0x0046A5B4 File Offset: 0x004687B4
	public void IACFDFONLFN(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.MBOIOHOIMHC();
	}

	// Token: 0x06009D7C RID: 40316 RVA: 0x0046A5E0 File Offset: 0x004687E0
	private void OnEnable()
	{
		this.KJGPJJPBCPH();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(false);
		this.spinPan.gameObject.SetActive(false);
		this.fiderPan.gameObject.SetActive(false);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 100)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 101)
			{
				this.fiderPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 102)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D7D RID: 40317 RVA: 0x0046A6AC File Offset: 0x004688AC
	public void playSoundFric()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
		if (num == 21)
		{
			this.fricClose.volume = 0.6f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 0.6f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 21f;
		this.fricClick.volume = 0.6f;
		this.fricClick.pitch = 1.1f + num2 * 0.15f - 0.075f;
		this.fricClick.Play();
	}

	// Token: 0x06009D7E RID: 40318 RVA: 0x0046A74C File Offset: 0x0046894C
	public string ENCLLABMMHP()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		string result = string.Format("wpn_eat4", bgjkmcbhnak.KDHENOMNPHK);
		if (num == 0)
		{
			result = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html";
		}
		if (num == -84)
		{
			result = "_FogWaterLevel";
		}
		return result;
	}

	// Token: 0x06009D7F RID: 40319 RVA: 0x0046A794 File Offset: 0x00468994
	public string NIDLLNKHOCB()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		string result = string.Format("isLocalServer", bgjkmcbhnak.PFDMMPFBCJA());
		if (num == 0)
		{
			result = "Elina";
		}
		if (num == 62)
		{
			result = "http://steamcommunity.com/sharedfiles/filedetails/?id=788064774";
		}
		return result;
	}

	// Token: 0x06009D80 RID: 40320 RVA: 0x0046A4AE File Offset: 0x004686AE
	private void MBOIOHOIMHC()
	{
		this.fumText.text = this.NMDLONOBDKJ();
	}

	// Token: 0x06009D81 RID: 40321 RVA: 0x0046A7DC File Offset: 0x004689DC
	public void EFLBGNKMLEE()
	{
		int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
		if (num == -96)
		{
			this.fricClose.volume = 1029f;
			this.fricClose.Play();
		}
		if (num == 0)
		{
			this.fricOpen.volume = 1165f;
			this.fricOpen.Play();
			return;
		}
		float num2 = (float)num / 1066f;
		this.fricClick.volume = 326f;
		this.fricClick.pitch = 1161f + num2 * 1748f - 1202f;
		this.fricClick.Play();
	}

	// Token: 0x06009D82 RID: 40322 RVA: 0x0046A87C File Offset: 0x00468A7C
	public void JEHIAEJJBGC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && !this.CDKKDIMGANB)
		{
			bgjkmcbhnak.IFNNBJDJBNA = this.slider.value;
			bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(this.slider.value);
			if (Application.isEditor)
			{
				Debug.Log("wpn_dress1");
			}
		}
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = bgjkmcbhnak.DFBHMIIPLCA;
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			bgjkmcbhnak.HFENEGIBAIG(this.slider.value);
		}
		this.CDKKDIMGANB = false;
	}

	// Token: 0x06009D83 RID: 40323 RVA: 0x0046A1BA File Offset: 0x004683BA
	private void NFDIKBMPMEH()
	{
		this.fumText.text = this.getFricText();
	}

	// Token: 0x06009D84 RID: 40324 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ACNBPPMPGEC()
	{
	}

	// Token: 0x06009D85 RID: 40325 RVA: 0x0046A918 File Offset: 0x00468B18
	public string NMDLONOBDKJ()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		string result = string.Format("_ScreenSize", bgjkmcbhnak.KDHENOMNPHK);
		if (num == 0)
		{
			result = " ";
		}
		if (num == -59)
		{
			result = "_NeutralTonemapperParams1";
		}
		return result;
	}

	// Token: 0x06009D86 RID: 40326 RVA: 0x0046A960 File Offset: 0x00468B60
	public void HKJMHHOJNFE(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format(" ms", BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH);
	}

	// Token: 0x06009D87 RID: 40327 RVA: 0x0046A9CC File Offset: 0x00468BCC
	public void POELGPOCLLE(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("_FogSkyColor", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE());
	}

	// Token: 0x06009D88 RID: 40328 RVA: 0x004696AE File Offset: 0x004678AE
	public void OFIJKPHEDCC(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009D89 RID: 40329 RVA: 0x004690EC File Offset: 0x004672EC
	public void setParamsFric(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.KJGPJJPBCPH();
	}

	// Token: 0x06009D8A RID: 40330 RVA: 0x0046AA38 File Offset: 0x00468C38
	private void OHKHOAKCENL()
	{
		this.AIPEHONDCNN();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(false);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
			float z = Mathf.Lerp(1515f, 1094f, (float)Mathf.RoundToInt((float)num) / 1573f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D8B RID: 40331 RVA: 0x0046AAF8 File Offset: 0x00468CF8
	public void OHLANANIIEJ(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		bgjkmcbhnak.ALIOGHFOFHO(this.sliderFric.value);
		int num2 = bgjkmcbhnak.CMKFMNBBPNE();
		this.MBOIOHOIMHC();
		if (num != num2)
		{
			this.EFLBGNKMLEE();
		}
	}

	// Token: 0x06009D8C RID: 40332 RVA: 0x0046AB54 File Offset: 0x00468D54
	private void OPDCJCFMIPE()
	{
		this.BFMEFDJJJAG();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(true);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
			float z = Mathf.Lerp(1916f, 1699f, (float)Mathf.RoundToInt((float)num) / 1702f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D8D RID: 40333 RVA: 0x004696AE File Offset: 0x004678AE
	public void ACOKPLMKOPO(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009D8E RID: 40334 RVA: 0x0046AC13 File Offset: 0x00468E13
	public void KOFMLPMNMGM(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.NFDIKBMPMEH();
	}

	// Token: 0x06009D8F RID: 40335 RVA: 0x0046A58E File Offset: 0x0046878E
	private void AMIJJOCDOCK()
	{
		this.fumText.text = this.ENCLLABMMHP();
	}

	// Token: 0x06009D90 RID: 40336 RVA: 0x0046AC40 File Offset: 0x00468E40
	private void OHPHJCGMNGD()
	{
		this.MBOIOHOIMHC();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(true);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 9)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == -18)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == -73)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009D91 RID: 40337 RVA: 0x0046AD0C File Offset: 0x00468F0C
	private void AMDMCKIFBPA()
	{
		this.EACDMIPIBLC();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(true);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CMKFMNBBPNE();
			float z = Mathf.Lerp(1330f, 1737f, (float)Mathf.RoundToInt((float)num) / 1758f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D92 RID: 40338 RVA: 0x0046A1BA File Offset: 0x004683BA
	private void KJGPJJPBCPH()
	{
		this.fumText.text = this.getFricText();
	}

	// Token: 0x06009D93 RID: 40339 RVA: 0x0046ADCC File Offset: 0x00468FCC
	public void CMKFKNAOACN(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = false;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("Hidden/Post FX/Builtin Debug Views", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D94 RID: 40340 RVA: 0x0046AE38 File Offset: 0x00469038
	public void setParamsDeep(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("{0:f2}", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D95 RID: 40341 RVA: 0x0046AC13 File Offset: 0x00468E13
	public void MLMGOIHPKJC(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.NFDIKBMPMEH();
	}

	// Token: 0x06009D96 RID: 40342 RVA: 0x0046AEA4 File Offset: 0x004690A4
	public void PDNLEAPAGGC(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("FOG_OFF", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D97 RID: 40343 RVA: 0x0046AF0F File Offset: 0x0046910F
	public void AMKMPBFEHMC(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.sliderFric.minValue = FNADKBPAGJH;
		this.sliderFric.maxValue = DAILMANBNMM;
		this.sliderFric.value = HDGCIMPLICJ;
		this.FFGEHEIEHEK();
	}

	// Token: 0x06009D98 RID: 40344 RVA: 0x004696AE File Offset: 0x004678AE
	public void AddValueToSlider(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009D99 RID: 40345 RVA: 0x0046AF3C File Offset: 0x0046913C
	public void LGIDEFMJKLA(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		int num = bgjkmcbhnak.CMKFMNBBPNE();
		bgjkmcbhnak.ALIOGHFOFHO(this.sliderFric.value);
		int num2 = bgjkmcbhnak.CMKFMNBBPNE();
		this.AMIJJOCDOCK();
		if (num != num2)
		{
			this.BHKKOPGIENG();
		}
	}

	// Token: 0x06009D9A RID: 40346 RVA: 0x0046AF98 File Offset: 0x00469198
	private void PAKOHKKBKHD()
	{
		this.PJKIOPGJMAE();
		if (Fisherman.getI != null && !Fisherman.getI.MFENINHGBHM)
		{
			base.gameObject.SetActive(true);
		}
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		if (this.fricImage)
		{
			int num = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GLNFJCIJHDL;
			float z = Mathf.Lerp(1969f, 1973f, (float)Mathf.RoundToInt((float)num) / 1971f);
			Vector3 eulerAngles = this.fricImage.transform.rotation.eulerAngles;
			eulerAngles.z = z;
			this.fricImage.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}

	// Token: 0x06009D9B RID: 40347 RVA: 0x0046A1BA File Offset: 0x004683BA
	private void GIEFBADELLK()
	{
		this.fumText.text = this.getFricText();
	}

	// Token: 0x06009D9C RID: 40348 RVA: 0x0046B058 File Offset: 0x00469258
	public void BBCLOPGIAMP(float FNADKBPAGJH, float DAILMANBNMM, float HDGCIMPLICJ)
	{
		this.CDKKDIMGANB = true;
		this.slider.minValue = FNADKBPAGJH;
		this.slider.maxValue = DAILMANBNMM;
		HDGCIMPLICJ = Mathf.Clamp(HDGCIMPLICJ, FNADKBPAGJH, DAILMANBNMM);
		this.slider.value = HDGCIMPLICJ;
		this.bumText.text = string.Format("?", BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH);
	}

	// Token: 0x06009D9D RID: 40349 RVA: 0x0046B0C4 File Offset: 0x004692C4
	public string MONBBLNMFBM()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		string result = string.Format(">", bgjkmcbhnak.PFDMMPFBCJA());
		if (num == 0)
		{
			result = "Idle Come Here";
		}
		if (num == 44)
		{
			result = "noresult";
		}
		return result;
	}

	// Token: 0x06009D9E RID: 40350 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CNBGANBEEME()
	{
	}

	// Token: 0x06009D9F RID: 40351 RVA: 0x0046A4AE File Offset: 0x004686AE
	private void PODHOOMBLHI()
	{
		this.fumText.text = this.NMDLONOBDKJ();
	}

	// Token: 0x06009DA0 RID: 40352 RVA: 0x0046B10C File Offset: 0x0046930C
	public string getFricText()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		int num = bgjkmcbhnak.GLNFJCIJHDL;
		string result = string.Format("{0:f3}", bgjkmcbhnak.KDHENOMNPHK);
		if (num == 0)
		{
			result = "☰☰☰";
		}
		if (num == 21)
		{
			result = "◍◍◍";
		}
		return result;
	}

	// Token: 0x06009DA1 RID: 40353 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PJKIOPGJMAE()
	{
	}

	// Token: 0x06009DA2 RID: 40354 RVA: 0x004696AE File Offset: 0x004678AE
	public void CHIPLAMHPIK(int FEAGDHLLLOI)
	{
		this.slider.value = this.slider.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06009DA3 RID: 40355 RVA: 0x0046B154 File Offset: 0x00469354
	private void EBAJDGLIAPE()
	{
		this.PCCPIKIEEPD();
		this.JIKGNLMIEJB = base.gameObject.GetComponent<RectTransform>();
		this.poplPan.gameObject.SetActive(true);
		this.spinPan.gameObject.SetActive(false);
		this.fiderPan.gameObject.SetActive(true);
		if (Fisherman.getI != null)
		{
			this.JKAJCGIPPLF = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GMLFCKNNOPJ();
			if (this.JKAJCGIPPLF == 11)
			{
				this.poplPan.gameObject.SetActive(true);
			}
			if (this.JKAJCGIPPLF == 32)
			{
				this.fiderPan.gameObject.SetActive(false);
			}
			if (this.JKAJCGIPPLF == 119)
			{
				this.spinPan.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009DA4 RID: 40356 RVA: 0x00022FCC File Offset: 0x000211CC
	public void updatePosition()
	{
	}

	// Token: 0x0400147E RID: 5246
	public Text bumText;

	// Token: 0x0400147F RID: 5247
	public Text fumText;

	// Token: 0x04001480 RID: 5248
	public Slider slider;

	// Token: 0x04001481 RID: 5249
	public AudioSource fricClick;

	// Token: 0x04001482 RID: 5250
	public AudioSource fricClose;

	// Token: 0x04001483 RID: 5251
	public AudioSource fricOpen;

	// Token: 0x04001484 RID: 5252
	public Slider sliderFric;

	// Token: 0x04001485 RID: 5253
	public RectTransform fricImage;

	// Token: 0x04001486 RID: 5254
	public RectTransform poplPan;

	// Token: 0x04001487 RID: 5255
	public RectTransform spinPan;

	// Token: 0x04001488 RID: 5256
	public RectTransform fiderPan;

	// Token: 0x04001489 RID: 5257
	public AudioClip clacSound;

	// Token: 0x0400148A RID: 5258
	private RectTransform JIKGNLMIEJB;

	// Token: 0x0400148B RID: 5259
	private int JKAJCGIPPLF;

	// Token: 0x0400148C RID: 5260
	private bool CDKKDIMGANB;
}
