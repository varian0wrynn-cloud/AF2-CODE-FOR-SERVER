using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;

// Token: 0x0200022B RID: 555
public class GAMIMGAEFFG
{
	// Token: 0x06007F78 RID: 32632 RVA: 0x003CF898 File Offset: 0x003CDA98
	public void BMGICGHPAFB(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "_FgOverlap")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 1U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, false, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 2U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.HEGPNOOINDJ(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.FIENLAJDKCH), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F79 RID: 32633 RVA: 0x003CFA00 File Offset: 0x003CDC00
	public void GJPOFPKJMCE(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 4U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.GPPDPHODMFH(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.HLLMBCINEIF), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F7A RID: 32634 RVA: 0x003CFB68 File Offset: 0x003CDD68
	public void GDOENILFJFK(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "crft_cnt")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 2U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.BJNEOELKPKP(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.EJGGDPJKLHI), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F7B RID: 32635 RVA: 0x003CFCD0 File Offset: 0x003CDED0
	private Texture2D OJPEBPOKAHK(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 1; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F7C RID: 32636 RVA: 0x003CFD38 File Offset: 0x003CDF38
	public void GLEICAAIOBN(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "_Gamma")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, true, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.OLGIDAPLGFL(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.BBLHGOMMOBO), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F7D RID: 32637 RVA: 0x003CFEA0 File Offset: 0x003CE0A0
	private Texture2D NHGJLLMGCAG(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 1; i < width; i += 0)
		{
			for (int j = 1; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F7E RID: 32638 RVA: 0x003CFF08 File Offset: 0x003CE108
	public void IMIKJNEDCKM(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "1 Hand Sword Shield Bash")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, true, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.HADCEFHOHCA(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.OIEAHKLLPBE), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F7F RID: 32639 RVA: 0x003D0070 File Offset: 0x003CE270
	public void POELMFIMAEG(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "ScubaOK")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 1U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 1U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.DPODGAPNHKO(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.CDPGMLFBFCN), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F80 RID: 32640 RVA: 0x003D01D8 File Offset: 0x003CE3D8
	private Texture2D OIJKMFEINEF(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F81 RID: 32641 RVA: 0x003D0240 File Offset: 0x003CE440
	private Texture2D FDJPDBPHFFD(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 1; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F82 RID: 32642 RVA: 0x003D02A8 File Offset: 0x003CE4A8
	public void FAIGBFNBFAA(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "ok")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 3U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 4U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.BJNEOELKPKP(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.CGEJADDEHLL), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F83 RID: 32643 RVA: 0x003D0410 File Offset: 0x003CE610
	private Texture2D DPODGAPNHKO(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 0; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F84 RID: 32644 RVA: 0x003D0478 File Offset: 0x003CE678
	private Texture2D BJNEOELKPKP(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F87 RID: 32647 RVA: 0x003D0508 File Offset: 0x003CE708
	private Texture2D HEGPNOOINDJ(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 1; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F88 RID: 32648 RVA: 0x003D0570 File Offset: 0x003CE770
	public void LDDNKBPKHPP(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "wpnlang/wpntypes/type")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 5U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.ARGB32, false, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 6U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.HEFNJJLNDJG(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.DOGADEJHMAC), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F89 RID: 32649 RVA: 0x003D06D8 File Offset: 0x003CE8D8
	public void GHBPKICODIO(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "_camIntensive")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, true, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 6U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.GPPDPHODMFH(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.PDGJNFLKBMC), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F8A RID: 32650 RVA: 0x003D0840 File Offset: 0x003CEA40
	public void DGFFGBNOLEI(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "[weight]")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)8, false, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 6U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.MMPFIMEJEOK(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.PDGJNFLKBMC), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F8B RID: 32651 RVA: 0x003D09A8 File Offset: 0x003CEBA8
	private Texture2D HADCEFHOHCA(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 1; i < width; i += 0)
		{
			for (int j = 0; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F8C RID: 32652 RVA: 0x003D0A10 File Offset: 0x003CEC10
	public void CIGCJAALILF(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "MotorbikeShootFwd")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 6U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.HEFNJJLNDJG(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.DOGADEJHMAC), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F8D RID: 32653 RVA: 0x003D0B78 File Offset: 0x003CED78
	private Texture2D HPCJILEJNNN(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 1; i < width; i++)
		{
			for (int j = 1; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F8E RID: 32654 RVA: 0x003D0BE0 File Offset: 0x003CEDE0
	private Texture2D CEHKCAOPJMC(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 0; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F8F RID: 32655 RVA: 0x003D0C48 File Offset: 0x003CEE48
	public void LPJBJGJJBLB(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "SoccerRun")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, true, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.MMPFIMEJEOK(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.BBLHGOMMOBO), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F90 RID: 32656 RVA: 0x003D0DB0 File Offset: 0x003CEFB0
	private Texture2D OLGIDAPLGFL(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i += 0)
		{
			for (int j = 1; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F91 RID: 32657 RVA: 0x003D0E18 File Offset: 0x003CF018
	public void GFGGBONGJNA(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "UpHillWalk")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, true, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 6U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.HPCJILEJNNN(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.KOIPHKJOGNH), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F92 RID: 32658 RVA: 0x003D0F80 File Offset: 0x003CF180
	public void GFOAKEFAGHF(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "HA ")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 8U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)0, false, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 2U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.OLGIDAPLGFL(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.PFMPGGJEAFM), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F93 RID: 32659 RVA: 0x003D10E8 File Offset: 0x003CF2E8
	private Texture2D GPPDPHODMFH(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 1, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F94 RID: 32660 RVA: 0x003D1150 File Offset: 0x003CF350
	private Texture2D MMPFIMEJEOK(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F95 RID: 32661 RVA: 0x003D11B8 File Offset: 0x003CF3B8
	public void GGHIEBCHCJB(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "_ExposureAdjustment")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 0U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, (TextureFormat)8, true, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.MMPFIMEJEOK(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.BGINBOBELIB), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F96 RID: 32662 RVA: 0x003D1320 File Offset: 0x003CF520
	public void HJPKNFEBBLO(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "Ready Look")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 8U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGB565, false, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				flag = true;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.GPPDPHODMFH(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.BGINBOBELIB), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F97 RID: 32663 RVA: 0x003D1488 File Offset: 0x003CF688
	public void PKBDDBCGDIM(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "http://www.root-motion.com/finalikdox/html/page7.html")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = true;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 1U && num2 > 0U)
		{
			byte[] array = new byte[num * num2 * 4U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.ARGB4444, true, true);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 0U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.CEHKCAOPJMC(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 1UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.BPPGBBLJANF), true);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x06007F98 RID: 32664 RVA: 0x003D15F0 File Offset: 0x003CF7F0
	private Texture2D ILIEDGIFLPJ(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 1; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F99 RID: 32665 RVA: 0x003D1658 File Offset: 0x003CF858
	private Texture2D HEFNJJLNDJG(Texture2D GNLKOIAIBNH)
	{
		Texture2D texture2D = new Texture2D(GNLKOIAIBNH.width, GNLKOIAIBNH.height);
		int width = GNLKOIAIBNH.width;
		int height = GNLKOIAIBNH.height;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j += 0)
			{
				texture2D.SetPixel(i, height - j - 0, GNLKOIAIBNH.GetPixel(i, j));
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007F9A RID: 32666 RVA: 0x003D16C0 File Offset: 0x003CF8C0
	public void KDKICIGMJCI(string GCOIBLDNOIM, Action<Texture2D> DFJFCOKENIA)
	{
		GAMIMGAEFFG.ACFJADDOLDA acfjaddolda = new GAMIMGAEFFG.ACFJADDOLDA();
		acfjaddolda.AENJLLPLILM = this;
		acfjaddolda.GCOIBLDNOIM = GCOIBLDNOIM;
		acfjaddolda.DFJFCOKENIA = DFJFCOKENIA;
		if (acfjaddolda.GCOIBLDNOIM == "GAMMA")
		{
			return;
		}
		ulong ulSteamID = ulong.Parse(acfjaddolda.GCOIBLDNOIM);
		CSteamID steamIDFriend = new CSteamID(ulSteamID);
		if (this.CHLDDJBEOAN.ContainsKey(acfjaddolda.GCOIBLDNOIM))
		{
			acfjaddolda.DFJFCOKENIA(this.CHLDDJBEOAN[acfjaddolda.GCOIBLDNOIM]);
			return;
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(steamIDFriend);
		bool flag = false;
		uint num;
		uint num2;
		if (SteamUtils.GetImageSize(largeFriendAvatar, out num, out num2) && num > 0U && num2 > 1U)
		{
			byte[] array = new byte[num * num2 * 7U];
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, true, false);
			if (SteamUtils.GetImageRGBA(largeFriendAvatar, array, (int)(num * num2 * 3U)))
			{
				flag = false;
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
				Texture2D texture2D2 = this.OLGIDAPLGFL(texture2D);
				this.CHLDDJBEOAN.Add(acfjaddolda.GCOIBLDNOIM, texture2D2);
				acfjaddolda.DFJFCOKENIA(texture2D2);
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
		if (flag)
		{
			GAMIMGAEFFG.JBKCEHKMIJB jbkcehkmijb = new GAMIMGAEFFG.JBKCEHKMIJB();
			jbkcehkmijb.EODEEEFMCIF = acfjaddolda;
			jbkcehkmijb.JMBKDINHDLO = this.NBIIGPKCBIB;
			this.NBIIGPKCBIB += 0UL;
			Callback<AvatarImageLoaded_t> value = new Callback<AvatarImageLoaded_t>(new Callback<AvatarImageLoaded_t>.DispatchDelegate(jbkcehkmijb.HLLMBCINEIF), false);
			this.ALOGHBPOJNC.Add(jbkcehkmijb.JMBKDINHDLO, value);
		}
	}

	// Token: 0x04001261 RID: 4705
	public static GAMIMGAEFFG IKGFHGKKCPG = new GAMIMGAEFFG();

	// Token: 0x04001262 RID: 4706
	private Dictionary<string, Texture2D> CHLDDJBEOAN = new Dictionary<string, Texture2D>();

	// Token: 0x04001263 RID: 4707
	private ulong NBIIGPKCBIB;

	// Token: 0x04001264 RID: 4708
	private Dictionary<ulong, Callback<AvatarImageLoaded_t>> ALOGHBPOJNC = new Dictionary<ulong, Callback<AvatarImageLoaded_t>>();

	// Token: 0x0200022C RID: 556
	[CompilerGenerated]
	private sealed class ACFJADDOLDA
	{
		// Token: 0x04001265 RID: 4709
		public GAMIMGAEFFG AENJLLPLILM;

		// Token: 0x04001266 RID: 4710
		public string GCOIBLDNOIM;

		// Token: 0x04001267 RID: 4711
		public Action<Texture2D> DFJFCOKENIA;
	}

	// Token: 0x0200022D RID: 557
	[CompilerGenerated]
	private sealed class JBKCEHKMIJB
	{
		// Token: 0x06007F9C RID: 32668 RVA: 0x003D1828 File Offset: 0x003CFA28
		internal void DOGADEJHMAC(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.DGFFGBNOLEI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x003D1878 File Offset: 0x003CFA78
		internal void IGMFEKHOLHH(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.POELMFIMAEG(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x003D18C8 File Offset: 0x003CFAC8
		internal void OOJNIKJHJEJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GDOENILFJFK(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x003D1918 File Offset: 0x003CFB18
		internal void BBIJAKNKGHJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.LPJBJGJJBLB(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x003D1968 File Offset: 0x003CFB68
		internal void HLLMBCINEIF(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GJPOFPKJMCE(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x003D19B8 File Offset: 0x003CFBB8
		internal void BBLHGOMMOBO(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.LDDNKBPKHPP(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x003D1A08 File Offset: 0x003CFC08
		internal void AOBHIINAAIF(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.FAIGBFNBFAA(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x003D1A58 File Offset: 0x003CFC58
		internal void BMOEEEIJELM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GDOENILFJFK(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x003D1AA8 File Offset: 0x003CFCA8
		internal void DAHGDCMEEII(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GHBPKICODIO(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x003D1AF8 File Offset: 0x003CFCF8
		internal void LBDGJKEDDBJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GHBPKICODIO(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x003D1B48 File Offset: 0x003CFD48
		internal void OJMEGBEPOMO(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.CIGCJAALILF(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x003D1B98 File Offset: 0x003CFD98
		internal void FBGNFNFFHKA(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GDOENILFJFK(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x003D1BE8 File Offset: 0x003CFDE8
		internal void CGEJADDEHLL(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.FAIGBFNBFAA(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x003D1C38 File Offset: 0x003CFE38
		internal void CCGFNHGKOGL(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GJPOFPKJMCE(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x003D1C88 File Offset: 0x003CFE88
		internal void DBMKNEGDFNA(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.IMIKJNEDCKM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x003D1CD8 File Offset: 0x003CFED8
		internal void CGAPCCPPOHJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GLEICAAIOBN(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x003D1D28 File Offset: 0x003CFF28
		internal void LFBKNJFPGIF(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.DGFFGBNOLEI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x003D1D78 File Offset: 0x003CFF78
		internal void JPBANLDIOOL(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GJPOFPKJMCE(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x003D1DC8 File Offset: 0x003CFFC8
		internal void PHPBGNAIFFA(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.HJPKNFEBBLO(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x003D1E18 File Offset: 0x003D0018
		internal void IMDGNJKLEOB(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.PKBDDBCGDIM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x003D1E68 File Offset: 0x003D0068
		internal void JABIJGMDDBM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GFOAKEFAGHF(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x003D1EB8 File Offset: 0x003D00B8
		internal void PDGJNFLKBMC(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.CIGCJAALILF(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x003D1F08 File Offset: 0x003D0108
		internal void ECLEJPPOCMM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.KDKICIGMJCI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB4 RID: 32692 RVA: 0x003D1F58 File Offset: 0x003D0158
		internal void BGINBOBELIB(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.IMIKJNEDCKM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB5 RID: 32693 RVA: 0x003D1FA8 File Offset: 0x003D01A8
		internal void NKEDFBGJLEO(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.PKBDDBCGDIM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x003D1FF8 File Offset: 0x003D01F8
		internal void EEFIHDEGDAJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.FAIGBFNBFAA(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x003D2048 File Offset: 0x003D0248
		internal void MILHGBCEJOF(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GLEICAAIOBN(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x003D2098 File Offset: 0x003D0298
		internal void PHNLICPGCAI(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.KDKICIGMJCI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x003D20E8 File Offset: 0x003D02E8
		internal void JHDKELAKJHC(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GFOAKEFAGHF(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x003D2138 File Offset: 0x003D0338
		internal void FIENLAJDKCH(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.POELMFIMAEG(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x003D2188 File Offset: 0x003D0388
		internal void FGGHPOJCHEA(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.LDDNKBPKHPP(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x003D21D8 File Offset: 0x003D03D8
		internal void EJGGDPJKLHI(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GJPOFPKJMCE(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x003D2228 File Offset: 0x003D0428
		internal void EEJIILENNHJ(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GJPOFPKJMCE(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x003D2278 File Offset: 0x003D0478
		internal void PFMPGGJEAFM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.LDDNKBPKHPP(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x003D22C8 File Offset: 0x003D04C8
		internal void NHEJNHNKAKP(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GDOENILFJFK(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x003D2318 File Offset: 0x003D0518
		internal void BCDJHMJBDHM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GFGGBONGJNA(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x003D2368 File Offset: 0x003D0568
		internal void PPCIABCAIOH(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.IMIKJNEDCKM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x003D23B8 File Offset: 0x003D05B8
		internal void PGPNGCAJKFM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.KDKICIGMJCI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x003D2408 File Offset: 0x003D0608
		internal void OIEAHKLLPBE(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.GLEICAAIOBN(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x003D2458 File Offset: 0x003D0658
		internal void KOIPHKJOGNH(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.KDKICIGMJCI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x003D24A8 File Offset: 0x003D06A8
		internal void NJKOMEDKFLE(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.POELMFIMAEG(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x003D24F8 File Offset: 0x003D06F8
		internal void INBGJHHABDA(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.IMIKJNEDCKM(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x003D2548 File Offset: 0x003D0748
		internal void MBKOLLDHGAD(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.KDKICIGMJCI(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x003D2598 File Offset: 0x003D0798
		internal void CDPGMLFBFCN(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.CIGCJAALILF(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x003D25E8 File Offset: 0x003D07E8
		internal void GNDLOJPLDMM(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.BMGICGHPAFB(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x003D2638 File Offset: 0x003D0838
		internal void BPPGBBLJANF(AvatarImageLoaded_t KDMGMLJJALK)
		{
			this.EODEEEFMCIF.AENJLLPLILM.BMGICGHPAFB(this.EODEEEFMCIF.GCOIBLDNOIM, this.EODEEEFMCIF.DFJFCOKENIA);
			this.EODEEEFMCIF.AENJLLPLILM.ALOGHBPOJNC.Remove(this.JMBKDINHDLO);
		}

		// Token: 0x04001268 RID: 4712
		public ulong JMBKDINHDLO;

		// Token: 0x04001269 RID: 4713
		public GAMIMGAEFFG.ACFJADDOLDA EODEEEFMCIF;
	}
}
