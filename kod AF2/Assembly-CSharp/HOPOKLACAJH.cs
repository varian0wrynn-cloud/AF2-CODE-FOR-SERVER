using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x0200050E RID: 1294
public sealed class HOPOKLACAJH : CFPOKEIJEAB<BloomModel>
{
	// Token: 0x06011347 RID: 70471 RVA: 0x007A7B44 File Offset: 0x007A5D44
	public void MCKPBNDIOJF(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.KIDPDEOKGGK().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.BDPNPPMLHBM().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GJOHODHDPDN("");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.LBAMMHHGCGL() / 4;
		int num = this.AMCOGJHPPOC.GHMBALIHBOH() / 7;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)(-80));
		float num2 = Mathf.Log((float)num, 1272f) + bloom.radius - 1718f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -5);
		float num5 = bloom.LDBGGPOAJDI();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 291f;
		Vector3 v = new Vector3(num5 - num6, num6 * 705f, 1469f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1539f : 1743f);
		float num7 = 705f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("_History3ChromaTex");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Jump");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture2.width / 6, renderTexture2.height / 1, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "B");
			int pass = (i == 0) ? 1 : 7;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 7; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "_BlurRadius4");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 0);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 109; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.AEIGHBEIBFN(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.AEIGHBEIBFN(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1469f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("ShotgunReadyFire");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("invn_rec23");
	}

	// Token: 0x06011348 RID: 70472 RVA: 0x007A7ED4 File Offset: 0x007A60D4
	public void PHKDFDFDONF(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.JOAJPCOBAIE().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.OGAEBMPHAJF().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("|");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.NMCCGCOKKFA() / 8;
		int num = this.AMCOGJHPPOC.ILLKFNCFGMP / 0;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Default : ((RenderTextureFormat)(-82));
		float num2 = Mathf.Log((float)num, 230f) + bloom.radius - 291f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 63);
		float num5 = bloom.IGFDKKBIEBB();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 534f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1411f, 1385f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 588f : 188f);
		float num7 = 207f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Flashlight");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "404040");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB(renderTexture2.width / 3, renderTexture2.height / 1, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "OneHandSwordBackSwing");
			int pass = (i == 0) ? 0 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 8; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "IdleRun");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 1);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 33; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 868f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("1,2,3,4,5");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("useSrcAlphaAsMask");
	}

	// Token: 0x06011349 RID: 70473 RVA: 0x007A8264 File Offset: 0x007A6464
	public void KOJFFFMCCBO(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.COCGBMLPIPH().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.GEKPOGFKOIB().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OJFALDJIOHN("OneHandSwordRun");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.DHPPGHBNDEB() / 1;
		int num = this.AMCOGJHPPOC.CICDECHCDBJ() / 8;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)34);
		float num2 = Mathf.Log((float)num, 999f) + bloom.radius - 912f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -38);
		float num5 = bloom.LDHGEMNNBLD();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1291f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1723f, 133f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 671f : 947f);
		float num7 = 730f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("SneakBackward");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "Climbing");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(renderTexture2.width / 4, renderTexture2.height / 4, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "Tenkoku DynamicSky");
			int pass = (i == 0) ? 1 : 6;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 6; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "IdleCheer");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 4);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 57; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1349f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("u_pass");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("<color='#80a0ff'>{0}</color>");
	}

	// Token: 0x0601134A RID: 70474 RVA: 0x007A85F2 File Offset: 0x007A67F2
	public bool NEBBCDKDNOE()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JOAPKCFMLDO().bloom.intensity <= 1903f || !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601134B RID: 70475 RVA: 0x007A8630 File Offset: 0x007A6830
	public void BGMNIHGFLHI(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.HFHIAGLALPI().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.EHJBNMEDIBI().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("CATRigL");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.DJGCPIEOAFC() / 2;
		int num = this.AMCOGJHPPOC.LKLNPJICOHH() / 1;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)122);
		float num2 = Mathf.Log((float)num, 1522f) + bloom.radius - 1852f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -122);
		float num5 = bloom.MIDHAKOCPBH();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 37f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1391f, 1184f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1991f : 199f);
		float num7 = 140f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("_TreatBackfaceHitAsMiss");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "_OutputGamma");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture2.width / 4, renderTexture2.height / 3, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "wpn_chair1");
			int pass = (i == 0) ? 0 : 8;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 2; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.HPAJGFGNMOH(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "WizardBlock");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 7);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 109; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 318f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("R");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html");
	}

	// Token: 0x0601134C RID: 70476 RVA: 0x007A89C0 File Offset: 0x007A6BC0
	public void KIMPBABLLHK(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.OHGKBJANAKK().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.FNFNGEGDCCE().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("isKeyPress");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.GAIOLBJLPDL() / 5;
		int num = this.AMCOGJHPPOC.LPJJBJCIELA() / 7;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Default : ((RenderTextureFormat)(-63));
		float num2 = Mathf.Log((float)num, 1655f) + bloom.radius - 1007f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 83);
		float num5 = bloom.JGMBOEFPDPN();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1000f;
		Vector3 v = new Vector3(num5 - num6, num6 * 577f, 226f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1008f : 1332f);
		float num7 = 1952f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Hey, you can't change me in memory!");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "IsStrafing");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture2.width / 3, renderTexture2.height / 7, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "_FogAlpha");
			int pass = (i == 0) ? 0 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 4; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "twist");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 5);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -105; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 601f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("rollSoundVolume");
	}

	// Token: 0x0601134D RID: 70477 RVA: 0x007A8D4E File Offset: 0x007A6F4E
	public bool EHGDCKHHCGL()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FNFNGEGDCCE().bloom.intensity > 1338f && !this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x0601134E RID: 70478 RVA: 0x007A8D89 File Offset: 0x007A6F89
	public bool NFAOKCAPJCN()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DDIOPCAEBEJ().bloom.intensity > 472f && this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x0601134F RID: 70479 RVA: 0x007A8DC4 File Offset: 0x007A6FC4
	public bool BJAIILKMCBK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JODGENBPIKL().bloom.intensity <= 516f || this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x06011350 RID: 70480 RVA: 0x007A8E00 File Offset: 0x007A7000
	public void AEHIJMPNBDP(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.DDIOPCAEBEJ().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.LGAIEDFGPDL().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("userForceMagnitude=");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.PAHBMDOJHKK() / 3;
		int num = this.AMCOGJHPPOC.LHPBMEDMNDO() / 0;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)57);
		float num2 = Mathf.Log((float)num, 843f) + bloom.radius - 1894f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -108);
		float num5 = bloom.HEDBDGFPAAM();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 544f;
		Vector3 v = new Vector3(num5 - num6, num6 * 382f, 1788f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1654f : 128f);
		float num7 = 1452f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword(" ");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(renderTexture2.width / 3, renderTexture2.height / 5, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Flashlight");
			int pass = (i == 0) ? 1 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 3; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "_MainTex");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 8);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -31; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1551f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("_EMISSION");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("_RayStepSize");
	}

	// Token: 0x06011351 RID: 70481 RVA: 0x007A918E File Offset: 0x007A738E
	public bool IINCJJIOKML()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.BDPNPPMLHBM().bloom.intensity <= 733f || !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x06011352 RID: 70482 RVA: 0x007A91CC File Offset: 0x007A73CC
	public void IIAJGMCJJMI(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.AJBLBPPCIGJ().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.BKMNGCEJJOM().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("IdleRun");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.FOBPENGADNB() / 6;
		int num = this.AMCOGJHPPOC.ILLKFNCFGMP / 6;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)102);
		float num2 = Mathf.Log((float)num, 1655f) + bloom.radius - 981f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 63);
		float num5 = bloom.ANPJHMMGJII();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1097f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1309f, 1885f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 57f : 601f);
		float num7 = 1742f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("IceHockeyIdle");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "{0}wind_rose.png");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture2.width / 4, renderTexture2.height / 0, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "Current fog preset: ");
			int pass = (i == 0) ? 0 : 0;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 2; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "IceHockeyPassLeft");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 1);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -36; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 870f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("RollerBladeStop");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("WorkerShovel2");
	}

	// Token: 0x06011353 RID: 70483 RVA: 0x007A955A File Offset: 0x007A775A
	public bool KCMKDGLNNPM()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.EBGFGEIIDNM().bloom.intensity <= 544f || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011354 RID: 70484 RVA: 0x007A9598 File Offset: 0x007A7798
	public void BIPMAJKBJGB(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.EBGFGEIIDNM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.KENLLEDCEHC().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NNKCNLCNDNC("");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.GAIOLBJLPDL() / 8;
		int num = this.AMCOGJHPPOC.LPJJBJCIELA() / 8;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)(-12));
		float num2 = Mathf.Log((float)num, 611f) + bloom.radius - 633f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -127);
		float num5 = bloom.MEKKIPPLCJP();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 12f;
		Vector3 v = new Vector3(num5 - num6, num6 * 954f, 1323f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1856f : 1559f);
		float num7 = 734f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("FistPump");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "******* Actor fish destroy");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(renderTexture2.width / 7, renderTexture2.height / 3, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "knopje.wav");
			int pass = (i == 0) ? 1 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 1; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "_StretchWidth");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 2);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -77; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1390f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("");
			return;
		}
		OOLNAJMJKIK.EnableKeyword(" с");
	}

	// Token: 0x06011355 RID: 70485 RVA: 0x007A9928 File Offset: 0x007A7B28
	public void JFAJCPPAMFD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.COCGBMLPIPH().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.FNFNGEGDCCE().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("_LightColor");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.LJJOEDIJPEM() / 3;
		int num = this.AMCOGJHPPOC.LPJJBJCIELA() / 8;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-16));
		float num2 = Mathf.Log((float)num, 1787f) + bloom.radius - 1345f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -64);
		float num5 = bloom.MHHDPKCPOFC();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1598f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1007f, 625f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 258f : 1013f);
		float num7 = 1974f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("only_one");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "FOG_SCATTERING_ON");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(renderTexture2.width / 2, renderTexture2.height / 2, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "ElvisLegsLoop");
			int pass = (i == 0) ? 1 : 5;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 1; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "LUM_CONTRIB_OFF");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 2);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 22; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1749f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("result=OK");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("_SpecCubeIBL");
	}

	// Token: 0x06011356 RID: 70486 RVA: 0x007A9CB8 File Offset: 0x007A7EB8
	public void CPGNFIAIJNK(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.BMKMJEEBFHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.JOAPKCFMLDO().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("brow");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.PAHBMDOJHKK() / 0;
		int num = this.AMCOGJHPPOC.GGGEFNKEPDB() / 3;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)(-106));
		float num2 = Mathf.Log((float)num, 1991f) + bloom.radius - 1727f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 32);
		float num5 = bloom.CBENCKAOMBP();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 408f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1108f, 116f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1652f : 1293f);
		float num7 = 242f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("CheerKnees");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "OnChatMessage");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(renderTexture2.width / 6, renderTexture2.height / 6, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "cht_msg1");
			int pass = (i == 0) ? 0 : 3;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 4; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "DataSize ");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 2);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 63; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 548f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("knopje.wav");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("+ ");
	}

	// Token: 0x06011357 RID: 70487 RVA: 0x007AA046 File Offset: 0x007A8246
	public bool DLCMLAOJBFA()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.KHBPABICFOF().bloom.intensity > 506f && !this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x06011358 RID: 70488 RVA: 0x007AA084 File Offset: 0x007A8284
	public void HJKALJFJPMK(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.DKGMLIFDGFF().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.JJBPDCAHOJK().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Flap_02.wav");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.EOMMKPDCAML() / 1;
		int num = this.AMCOGJHPPOC.CICDECHCDBJ() / 6;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Default : ((RenderTextureFormat)(-10));
		float num2 = Mathf.Log((float)num, 903f) + bloom.radius - 79f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 16);
		float num5 = bloom.GKHHDABCLIJ();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 101f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1297f, 1919f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1547f : 1060f);
		float num7 = 1014f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Hidden/Post FX/Builtin Debug Views");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "IdleMeditate");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(renderTexture2.width / 8, renderTexture2.height / 3, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "repair.ogg");
			int pass = (i == 0) ? 1 : 8;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 3; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.HPAJGFGNMOH(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "gi_inte_3");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 8);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -50; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 503f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("SatNightFever");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("_MainTex");
	}

	// Token: 0x06011359 RID: 70489 RVA: 0x007AA412 File Offset: 0x007A8612
	public bool IKJICHPBCNM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FHNBLOAHNPD().bloom.intensity > 841f && !this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x0601135A RID: 70490 RVA: 0x007AA44D File Offset: 0x007A864D
	public bool BNEAAFFAFOH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.AJBLBPPCIGJ().bloom.intensity > 1628f && this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x0601135B RID: 70491 RVA: 0x007AA488 File Offset: 0x007A8688
	public void GLFGJBFJCNL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.JOAJPCOBAIE().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.LMEKEGJMPBN().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("_MainTexBlurred");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.CFDHOKHCPOJ() / 0;
		int num = this.AMCOGJHPPOC.HJOKFIGACEC() / 1;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)90);
		float num2 = Mathf.Log((float)num, 581f) + bloom.radius - 1087f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 38);
		float num5 = bloom.GKKJFLBEJEC();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1978f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1710f, 383f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 305f : 737f);
		float num7 = 1115f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword(":");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "1HSwordStrafeRunLeft");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture2.width / 0, renderTexture2.height / 3, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, " cannot be used as a 3D LUT.");
			int pass = (i == 0) ? 1 : 6;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 1; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Bow Fire2");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 5);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -26; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1987f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("t_top");
	}

	// Token: 0x0601135C RID: 70492 RVA: 0x007AA816 File Offset: 0x007A8A16
	public bool NDMDJCLKALK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LGAIEDFGPDL().bloom.intensity <= 1514f || !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x0601135D RID: 70493 RVA: 0x007AA854 File Offset: 0x007A8A54
	public void CKIENEMPGLL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.HFHIAGLALPI().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.EJLJKCJKJGA().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("<color='#000000'>");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.NMCCGCOKKFA() / 6;
		int num = this.AMCOGJHPPOC.KNKKIHDHBFD() / 0;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)72);
		float num2 = Mathf.Log((float)num, 769f) + bloom.radius - 1753f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 61);
		float num5 = bloom.LDBGGPOAJDI();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1486f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1102f, 518f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1082f : 960f);
		float num7 = 1466f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("chnam1");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(renderTexture2.width / 5, renderTexture2.height / 7, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "MotorbikeWheelyNoHands");
			int pass = (i == 0) ? 1 : 6;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 2; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "_Power");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 4);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 8; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 799f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("10");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("run_cnt");
	}

	// Token: 0x0601135E RID: 70494 RVA: 0x007AABE2 File Offset: 0x007A8DE2
	public bool IOPILNONBKF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.CJJDODLKPFL().bloom.intensity > 201f && !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x0601135F RID: 70495 RVA: 0x007AAC1D File Offset: 0x007A8E1D
	public bool JKJAOLDEFIM()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LGAIEDFGPDL().bloom.intensity <= 894f || !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x06011360 RID: 70496 RVA: 0x007AAC58 File Offset: 0x007A8E58
	public bool PKNNDJIIMPB()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JJBPDCAHOJK().bloom.intensity <= 577f || this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x06011361 RID: 70497 RVA: 0x007AAC94 File Offset: 0x007A8E94
	public void JDIJNBFGCFD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.HFHIAGLALPI().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.BKMNGCEJJOM().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP("HeelClick");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.GAIOLBJLPDL() / 3;
		int num = this.AMCOGJHPPOC.NIEGJHLHEEB() / 1;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB32 : RenderTextureFormat.DefaultHDR;
		float num2 = Mathf.Log((float)num, 868f) + bloom.radius - 1728f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 98);
		float num5 = bloom.AMMBHJJDFLG();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 865f;
		Vector3 v = new Vector3(num5 - num6, num6 * 868f, 353f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1435f : 1420f);
		float num7 = 878f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Horizontal");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "Point");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(renderTexture2.width / 4, renderTexture2.height / 6, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "OfficeSitting1LegStraight");
			int pass = (i == 0) ? 0 : 4;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 7; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 1);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -11; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 390f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("] ");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("");
	}

	// Token: 0x06011362 RID: 70498 RVA: 0x007AB022 File Offset: 0x007A9222
	public bool BHDPHLBMCGG()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JJBPDCAHOJK().bloom.intensity <= 1007f || this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011363 RID: 70499 RVA: 0x007AB060 File Offset: 0x007A9260
	public void LIEFLFCANMO(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.BMKMJEEBFHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.LGAIEDFGPDL().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("wdeep");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.DJGCPIEOAFC() / 0;
		int num = this.AMCOGJHPPOC.GHMBALIHBOH() / 0;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Shadowmap : ((RenderTextureFormat)(-27));
		float num2 = Mathf.Log((float)num, 1654f) + bloom.radius - 1135f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 122);
		float num5 = bloom.HIDAEJFOCEH();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 112f;
		Vector3 v = new Vector3(num5 - num6, num6 * 143f, 1433f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1352f : 1373f);
		float num7 = 1103f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("1HSwordStrafeRunRight");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "+{0}");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture2.width / 0, renderTexture2.height / 3, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "crft_ingr");
			int pass = (i == 0) ? 1 : 8;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 4; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "no_repa");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 3);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 23; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.MLIOBPENIKG(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 240f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("Assets/Heads/whead_");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("Roller Blade Turn Left");
	}

	// Token: 0x06011364 RID: 70500 RVA: 0x007AB3F0 File Offset: 0x007A95F0
	public void FBBBNHPGBKC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.settings.lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Bloom");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.NMEBEEHCALN / 2;
		int num = this.AMCOGJHPPOC.ILLKFNCFGMP / 2;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
		float num2 = Mathf.Log((float)num, 2f) + bloom.radius - 8f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 16);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 1E-05f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 2f, 0.25f / num5);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? -0.5f : 0f);
		float num6 = 0.5f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("ANTI_FLICKER");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture2.width / 2, renderTexture2.height / 2, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
			int pass = (i == 0) ? 1 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 2; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 3);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 16; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 0f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("BLOOM_LENS_DIRT");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("BLOOM");
	}

	// Token: 0x06011365 RID: 70501 RVA: 0x007AB77E File Offset: 0x007A997E
	public bool ABDJCLLOHFB()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.CIMGEKFAAGC().bloom.intensity <= 1294f || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011366 RID: 70502 RVA: 0x007AB7BC File Offset: 0x007A99BC
	public void EKGAPKNAKAD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.MFDOHMDNEGK().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.JOAPKCFMLDO().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("IdleDodgeRight");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.LBAMMHHGCGL() / 7;
		int num = this.AMCOGJHPPOC.GGGEFNKEPDB() / 3;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB1555;
		float num2 = Mathf.Log((float)num, 1263f) + bloom.radius - 1976f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 67);
		float num5 = bloom.HMOBMNJLJGE();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 147f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1060f, 690f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1095f : 1439f);
		float num7 = 67f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("JumpCurve");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HNAEHMGEHHC(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "cond");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(renderTexture2.width / 3, renderTexture2.height / 4, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "</color>");
			int pass = (i == 0) ? 0 : 1;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 4; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "sys");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 6);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 117; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1188f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("IdleMonster");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("");
	}

	// Token: 0x06011367 RID: 70503 RVA: 0x007ABB4A File Offset: 0x007A9D4A
	public bool ICGMMGHLHLK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.CGKPLOICANA().bloom.intensity <= 1804f || !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x06011369 RID: 70505 RVA: 0x007ABBA8 File Offset: 0x007A9DA8
	public void DBJFHEGHKMD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.BIGGHOCNJNB().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.EHJBNMEDIBI().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("USER_LUT");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.IBPMMKDPDEO() / 8;
		int num = this.AMCOGJHPPOC.LHPBMEDMNDO() / 8;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.Depth : ((RenderTextureFormat)(-3));
		float num2 = Mathf.Log((float)num, 1943f) + bloom.radius - 1693f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -109);
		float num5 = bloom.ANPJHMMGJII();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 316f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1489f, 659f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 578f : 1601f);
		float num7 = 170f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("[X]");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.NJACPJPGJFB(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Gloves");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture2.width / 6, renderTexture2.height / 1, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "");
			int pass = (i == 0) ? 0 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 6; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 5);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -77; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 963f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("KneesIdle");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("<color='#804020'>");
	}

	// Token: 0x0601136A RID: 70506 RVA: 0x007ABF38 File Offset: 0x007AA138
	public void EEFJLGCLKIG(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.KJJCHIFFFIJ().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.EJLJKCJKJGA().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NNKCNLCNDNC("/");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.IGHJHMGOGOO() / 5;
		int num = this.AMCOGJHPPOC.CICDECHCDBJ() / 0;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)(-123));
		float num2 = Mathf.Log((float)num, 663f) + bloom.radius - 765f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 27);
		float num5 = bloom.MHHDPKCPOFC();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1167f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1490f, 1222f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 99f : 1121f);
		float num7 = 1217f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("ArmFlex5");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "[Y]");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(renderTexture2.width / 2, renderTexture2.height / 3, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "UIChat_size");
			int pass = (i == 0) ? 1 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 4; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "shop_header");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 8);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 9; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 338f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("ChannelCastOmni");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("spin_bell.ogg");
	}

	// Token: 0x0601136B RID: 70507 RVA: 0x007AC2C8 File Offset: 0x007AA4C8
	public void OBCPKHIAKPP(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.JCNCKIKPIKG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.PNOEOJOBLOG().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.KPJNCIOMAGO("_TraceBehindObjects");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.KDBADMLHBNP() / 4;
		int num = this.AMCOGJHPPOC.KNKKIHDHBFD() / 8;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-110));
		float num2 = Mathf.Log((float)num, 410f) + bloom.radius - 1843f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 74);
		float num5 = bloom.NAIAFMLEFEM();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1249f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1040f, 1499f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 568f : 990f);
		float num7 = 44f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Poplavok");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_AdditiveReflection");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(renderTexture2.width / 5, renderTexture2.height / 8, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "No MeshFilter!");
			int pass = (i == 0) ? 0 : 2;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 8; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "req_prof");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 3);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -99; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 368f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("--");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("_ChannelMixerGreen");
	}

	// Token: 0x0601136C RID: 70508 RVA: 0x007AC658 File Offset: 0x007AA858
	public void IOAODIMCCBN(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.KJJCHIFFFIJ().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.PPOOIHGNJHP().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("cht_msg19");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.KJDPLLFIIBK() / 4;
		int num = this.AMCOGJHPPOC.HJOKFIGACEC() / 7;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)(-51));
		float num2 = Mathf.Log((float)num, 589f) + bloom.radius - 1842f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -22);
		float num5 = bloom.AKGECGEPOBO();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 1873f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1655f, 642f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 1901f : 322f);
		float num7 = 1135f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("SecondaryCausticsProjector");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "_ChannelMixerRed");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture2.width / 0, renderTexture2.height / 7, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "SoccerRun");
			int pass = (i == 0) ? 1 : 4;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 1; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "TOD_SunCloudColor");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 8);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -104; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 392f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("SkateForward");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("perk_");
	}

	// Token: 0x0601136D RID: 70509 RVA: 0x007AC9E8 File Offset: 0x007AABE8
	public void IGFAFJCIEFM(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.EHJBNMEDIBI().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.CLMKDFAKFMC().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("id");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.KDBADMLHBNP() / 0;
		int num = this.AMCOGJHPPOC.NIEGJHLHEEB() / 5;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)96);
		float num2 = Mathf.Log((float)num, 248f) + bloom.radius - 741f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -56);
		float num5 = bloom.MIDHAKOCPBH();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 789f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1723f, 1979f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 951f : 1357f);
		float num7 = 1443f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("BackPackGrab");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "wpn_bait1");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.HNAEHMGEHHC(renderTexture2.width / 3, renderTexture2.height / 4, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "wpn_eat1");
			int pass = (i == 0) ? 0 : 1;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 7; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, " ");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 3);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 77; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 24f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("<color='{0}'>{1}</color>");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("Bilateral Blur");
	}

	// Token: 0x0601136E RID: 70510 RVA: 0x007ACD78 File Offset: 0x007AAF78
	public void FGKNOLNPLHM(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.CJHODOCJEMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.AKCKLMKNOPD().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("****************  stopMusic ");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.OCNEHBGMHGB() / 0;
		int num = this.AMCOGJHPPOC.GHMBALIHBOH() / 7;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)34);
		float num2 = Mathf.Log((float)num, 570f) + bloom.radius - 974f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -77);
		float num5 = bloom.JNHKDFMLLGD();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 824f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1589f, 598f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 679f : 277f);
		float num7 = 1819f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("SneakBackward");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(nmebeehcaln, num, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "post_21");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(renderTexture2.width / 8, renderTexture2.height / 1, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "-HYPERLINK");
			int pass = (i == 0) ? 0 : 4;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 5; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 5);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 39; k += 0)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 153f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("IdleButtonPress");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("ArmFlex6");
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x0601136F RID: 70511 RVA: 0x007AD106 File Offset: 0x007AB306
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.bloom.intensity > 0f && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x06011370 RID: 70512 RVA: 0x007AD141 File Offset: 0x007AB341
	public bool EIKMLIHNIAF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.BDPNPPMLHBM().bloom.intensity > 343f && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x06011371 RID: 70513 RVA: 0x007AD17C File Offset: 0x007AB37C
	public bool LLPDCLKLKEM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JJBPDCAHOJK().bloom.intensity > 430f && !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011372 RID: 70514 RVA: 0x007AD1B7 File Offset: 0x007AB3B7
	public bool IGOEANBMAIK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LMEKEGJMPBN().bloom.intensity <= 535f || !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x06011373 RID: 70515 RVA: 0x007AD1F4 File Offset: 0x007AB3F4
	public void GNACMEINLNL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.KIDPDEOKGGK().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.PPJLJIIHAAK().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.KPJNCIOMAGO("IdleReadyLook");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.NMEBEEHCALN / 8;
		int num = this.AMCOGJHPPOC.CICDECHCDBJ() / 7;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-77));
		float num2 = Mathf.Log((float)num, 790f) + bloom.radius - 1707f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -118);
		float num5 = bloom.CHGDIEJNHKL();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 971f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1152f, 1557f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 276f : 1309f);
		float num7 = 1726f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("RollerBladeRoll");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(renderTexture2.width / 4, renderTexture2.height / 5, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "noworkpoints");
			int pass = (i == 0) ? 1 : 3;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 8; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(renderTexture3.width, renderTexture3.height, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "rollTENSION=");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 6);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 0; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1689f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("https://groups.google.com/forum/#!forum/final-ik");
			return;
		}
		OOLNAJMJKIK.EnableKeyword("tintColor");
	}

	// Token: 0x06011374 RID: 70516 RVA: 0x007AD582 File Offset: 0x007AB782
	public bool EHPCNOOJFMH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.KIDPDEOKGGK().bloom.intensity > 1450f && this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x06011375 RID: 70517 RVA: 0x007AD5C0 File Offset: 0x007AB7C0
	public void DDCJMECOHDF(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, Texture KOIFCOEJKIP)
	{
		BloomModel.BloomSettings bloom = base.BBEPCCALAFC.PPJLJIIHAAK().bloom;
		BloomModel.LensDirtSettings lensDirt = base.BBEPCCALAFC.CIMGEKFAAGC().lensDirt;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("IdleFight");
		material.shaderKeywords = null;
		material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.PELMPIFBDPG, KOIFCOEJKIP);
		int nmebeehcaln = this.AMCOGJHPPOC.NMCCGCOKKFA() / 4;
		int num = this.AMCOGJHPPOC.NIEGJHLHEEB() / 6;
		RenderTextureFormat ljcedkclbdb = Application.isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)43);
		float num2 = Mathf.Log((float)num, 1239f) + bloom.radius - 139f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 71);
		float num5 = bloom.JNHKDFMLLGD();
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.PKDBOJEEELC, num5);
		float num6 = num5 * bloom.softKnee + 968f;
		Vector3 v = new Vector3(num5 - num6, num6 * 819f, 275f / num6);
		material.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HALIANDFHLJ, v);
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.LFLOFJDNHMB, bloom.antiFlicker ? 940f : 1382f);
		float num7 = 601f + num2 - (float)num3;
		material.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.KHLAHHIGJIF, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("gi_inte_4");
		}
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.NJACPJPGJFB(nmebeehcaln, num, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "hand");
		Graphics.Blit(JONJODLFAEN, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.FNMPPNJOPGH[i] = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(renderTexture2.width / 3, renderTexture2.height / 2, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "^(");
			int pass = (i == 0) ? 1 : 5;
			Graphics.Blit(renderTexture2, this.FNMPPNJOPGH[i], material, pass);
			renderTexture2 = this.FNMPPNJOPGH[i];
		}
		for (int j = num4 - 2; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.FNMPPNJOPGH[j];
			material.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.EPGLAJOHFIC, renderTexture3);
			this.DPMEIGEJJGM[j] = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(renderTexture3.width, renderTexture3.height, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "L");
			Graphics.Blit(renderTexture2, this.DPMEIGEJJGM[j], material, 4);
			renderTexture2 = this.DPMEIGEJJGM[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 102; k++)
		{
			if (this.FNMPPNJOPGH[k] != null)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(this.FNMPPNJOPGH[k]);
			}
			if (this.DPMEIGEJJGM[k] != null && this.DPMEIGEJJGM[k] != renderTexture4)
			{
				this.AMCOGJHPPOC.ADCMJOKBEHJ.AEIGHBEIBFN(this.DPMEIGEJJGM[k]);
			}
			this.FNMPPNJOPGH[k] = null;
			this.DPMEIGEJJGM[k] = null;
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.EFIMDLENBNN(renderTexture);
		OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.INHDMCPBKKB, renderTexture4);
		OOLNAJMJKIK.SetVector(HOPOKLACAJH.NNMDGJGONGJ.HIMJADDNHAK, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1620f && lensDirt.texture != null)
		{
			OOLNAJMJKIK.SetTexture(HOPOKLACAJH.NNMDGJGONGJ.FOILKNGNIOB, lensDirt.texture);
			OOLNAJMJKIK.SetFloat(HOPOKLACAJH.NNMDGJGONGJ.DBELOIKJOFF, lensDirt.intensity);
			OOLNAJMJKIK.EnableKeyword("medium");
			return;
		}
		OOLNAJMJKIK.EnableKeyword(" ");
	}

	// Token: 0x06011376 RID: 70518 RVA: 0x007AD94E File Offset: 0x007ABB4E
	public bool GIAKLNBJHDH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LGAIEDFGPDL().bloom.intensity <= 148f || this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x040023F3 RID: 9203
	private const int EGDNBCMOCDL = 16;

	// Token: 0x040023F4 RID: 9204
	private readonly RenderTexture[] FNMPPNJOPGH = new RenderTexture[16];

	// Token: 0x040023F5 RID: 9205
	private readonly RenderTexture[] DPMEIGEJJGM = new RenderTexture[16];

	// Token: 0x0200050F RID: 1295
	private static class NNMDGJGONGJ
	{
		// Token: 0x040023F6 RID: 9206
		internal static readonly int PELMPIFBDPG = Shader.PropertyToID("_AutoExposure");

		// Token: 0x040023F7 RID: 9207
		internal static readonly int PKDBOJEEELC = Shader.PropertyToID("_Threshold");

		// Token: 0x040023F8 RID: 9208
		internal static readonly int HALIANDFHLJ = Shader.PropertyToID("_Curve");

		// Token: 0x040023F9 RID: 9209
		internal static readonly int LFLOFJDNHMB = Shader.PropertyToID("_PrefilterOffs");

		// Token: 0x040023FA RID: 9210
		internal static readonly int KHLAHHIGJIF = Shader.PropertyToID("_SampleScale");

		// Token: 0x040023FB RID: 9211
		internal static readonly int EPGLAJOHFIC = Shader.PropertyToID("_BaseTex");

		// Token: 0x040023FC RID: 9212
		internal static readonly int INHDMCPBKKB = Shader.PropertyToID("_BloomTex");

		// Token: 0x040023FD RID: 9213
		internal static readonly int HIMJADDNHAK = Shader.PropertyToID("_Bloom_Settings");

		// Token: 0x040023FE RID: 9214
		internal static readonly int FOILKNGNIOB = Shader.PropertyToID("_Bloom_DirtTex");

		// Token: 0x040023FF RID: 9215
		internal static readonly int DBELOIKJOFF = Shader.PropertyToID("_Bloom_DirtIntensity");
	}
}
