using System;
using UnityEngine;

// Token: 0x020001EE RID: 494
public class OJCFBJGEEHL
{
	// Token: 0x06007250 RID: 29264 RVA: 0x0036B7B4 File Offset: 0x003699B4
	private bool DKKODJGLKNO()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007251 RID: 29265 RVA: 0x0036B808 File Offset: 0x00369A08
	private void NLFDNAOJBMH(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[5], 142f);
		JLJJKMLJBAK.BGLLPMKNBCE = true;
	}

	// Token: 0x06007252 RID: 29266 RVA: 0x0036B82C File Offset: 0x00369A2C
	private void EHHHGICGGNF(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(SoundSamplesStorage.getI.clips[3], 646f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x06007253 RID: 29267 RVA: 0x0036B850 File Offset: 0x00369A50
	public bool AGIADAPNGOI()
	{
		return !this.FJPPICALNLP() && !JDCEFOFMGHB.MNJNNDHCDGG().JBMEDLAFJNI() && (!LocationLogic.getI.HNJGFKKGOEC() || (Input.GetKey(KeyCode.Plus) | Input.GetMouseButton(1)));
	}

	// Token: 0x06007254 RID: 29268 RVA: 0x0036B888 File Offset: 0x00369A88
	public void JALELHDNPLB(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.EIHBGJBIICO() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.HOCANGMOLDF(JLJJKMLJBAK);
		}
		if (this.ICFNBGOMJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x06007255 RID: 29269 RVA: 0x0036B8E0 File Offset: 0x00369AE0
	public bool IABHINHNAAE()
	{
		return this.ONLCFGLMMKH() || (!JDCEFOFMGHB.HMJJPNDEKPP().NKJEEHEODBF() && LocationLogic.getI.IMEEHCHFJME() && (Input.GetKey((KeyCode)25) | Input.GetMouseButton(0)));
	}

	// Token: 0x06007256 RID: 29270 RVA: 0x0036B916 File Offset: 0x00369B16
	public bool ADCNBBOKMJJ()
	{
		return !this.BNFLLODEAPO() && !JDCEFOFMGHB.IKGFHGKKCPG.NKJEEHEODBF() && LocationLogic.getI.JDGFBKCIICG() && (Input.GetKey((KeyCode)77) | Input.GetMouseButton(1));
	}

	// Token: 0x06007257 RID: 29271 RVA: 0x0036B94C File Offset: 0x00369B4C
	private void POLNHPHNDIM(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(SoundSamplesStorage.getI.clips[7], 1457f);
		JLJJKMLJBAK.BCPJHJEBBPM(false);
	}

	// Token: 0x06007258 RID: 29272 RVA: 0x0036B970 File Offset: 0x00369B70
	public bool KJBFOLHOELK()
	{
		return !this.ONLCFGLMMKH() && (JDCEFOFMGHB.IKGFHGKKCPG.NKJEEHEODBF() || (LocationLogic.getI.NPCLNJACPFH() && (Input.GetKey((KeyCode)71) | Input.GetMouseButton(0))));
	}

	// Token: 0x06007259 RID: 29273 RVA: 0x0036B9A6 File Offset: 0x00369BA6
	public bool GLODMHJFOJI()
	{
		return this.DKKODJGLKNO() || !LocationLogic.getI.HNJGFKKGOEC() || Input.GetKeyDown((KeyCode)(-90));
	}

	// Token: 0x0600725A RID: 29274 RVA: 0x0036B9C7 File Offset: 0x00369BC7
	public bool LJJIKDKHIKJ()
	{
		return !this.DFGBGHPFCFO() && (JDCEFOFMGHB.HMJJPNDEKPP().BHBCONNDEBA() || (LocationLogic.getI.EBDMDMJJHGK() && (Input.GetKey(KeyCode.V) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600725B RID: 29275 RVA: 0x0036BA00 File Offset: 0x00369C00
	public void MAFCKINDEAN(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.EIHBGJBIICO() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.LCBGHINEKHI(JLJJKMLJBAK);
		}
		if (this.KDFNIPABIGI())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x0600725C RID: 29276 RVA: 0x0036BA58 File Offset: 0x00369C58
	public bool LEDPNEFACFP()
	{
		return this.LNLNCBGPCNA() || !LocationLogic.getI.LMODDKDOFKH() || Input.GetKeyDown((KeyCode)21);
	}

	// Token: 0x0600725D RID: 29277 RVA: 0x0036BA79 File Offset: 0x00369C79
	private void PJDIAOHMECG(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[8], 1103f);
		JLJJKMLJBAK.HPLDIIIFDCP(false);
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x0036BA9D File Offset: 0x00369C9D
	public bool DCJHLDECING()
	{
		return this.DKKODJGLKNO() || JDCEFOFMGHB.HMJJPNDEKPP().GGCLOKODHEG() || (LocationLogic.getI.HNJGFKKGOEC() && (Input.GetKey((KeyCode)72) | Input.GetMouseButton(1)));
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x0036BAD4 File Offset: 0x00369CD4
	public void GJJAMPHJMMP(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.EPKCLOEGPCM() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.OAAIFBAGDMO(JLJJKMLJBAK);
		}
		if (this.KOABDDLCMHL())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x06007260 RID: 29280 RVA: 0x0036BB2C File Offset: 0x00369D2C
	public bool BJAFDNMHEIC()
	{
		return !this.DLMCBNMPFFF() && !JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA() && (!LocationLogic.getI.NPCLNJACPFH() || (Input.GetKey(KeyCode.S) | Input.GetMouseButton(0)));
	}

	// Token: 0x06007261 RID: 29281 RVA: 0x0036BB64 File Offset: 0x00369D64
	public void DNEPMKLKGKG(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.DDADGHACJMF() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.POLNHPHNDIM(JLJJKMLJBAK);
		}
		if (this.COEICEJLPFF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x06007262 RID: 29282 RVA: 0x0036BBBC File Offset: 0x00369DBC
	public bool IJEFDGKAJFB()
	{
		return this.DLMCBNMPFFF() || !LocationLogic.getI.DBPKJJHKEFB() || Input.GetKeyDown((KeyCode)(-22));
	}

	// Token: 0x06007263 RID: 29283 RVA: 0x0036BBE0 File Offset: 0x00369DE0
	public void GJLBBJHBEJE(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.LNPOODFGCFF() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.JECGALBIFAB(JLJJKMLJBAK);
		}
		if (this.ICFNBGOMJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x06007264 RID: 29284 RVA: 0x0036BC38 File Offset: 0x00369E38
	private void MKDJNEGAPLI(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[5], 1036f);
		JLJJKMLJBAK.BGLLPMKNBCE = true;
	}

	// Token: 0x06007265 RID: 29285 RVA: 0x0036BC5C File Offset: 0x00369E5C
	private void AHGEOEPEMFE(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[3], 996f);
		JLJJKMLJBAK.BGLLPMKNBCE = true;
	}

	// Token: 0x06007266 RID: 29286 RVA: 0x0036BC80 File Offset: 0x00369E80
	private bool OINHKEJJHHD()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007267 RID: 29287 RVA: 0x0036BCD4 File Offset: 0x00369ED4
	private void OGKHEFCBBDI(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[1], 93f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x0036BCF8 File Offset: 0x00369EF8
	public bool GJBIOICNEFH()
	{
		return this.CJJCHJICFFN() || (!JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA() && (!LocationLogic.getI.HNJGFKKGOEC() || (Input.GetKey(KeyCode.LeftParen) | Input.GetMouseButton(1))));
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x0036BD2E File Offset: 0x00369F2E
	public bool KAKNJFILNIE()
	{
		return this.DFGBGHPFCFO() || (Input.GetKeyDown((KeyCode)26) | Input.GetMouseButtonDown(8));
	}

	// Token: 0x0600726A RID: 29290 RVA: 0x0036BD48 File Offset: 0x00369F48
	public bool CODDDHPOOIH()
	{
		return !this.ONLCFGLMMKH() && (JDCEFOFMGHB.HMJJPNDEKPP().JBMEDLAFJNI() || (LocationLogic.getI.PCCLPPDMGLA() && (Input.GetKey(KeyCode.Asterisk) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600726B RID: 29291 RVA: 0x0036BD7E File Offset: 0x00369F7E
	public bool CCNCKIFIOLP()
	{
		return !this.FJPPICALNLP() && (JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG() || (LocationLogic.getI.PCCLPPDMGLA() && (Input.GetKey((KeyCode)(-123)) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600726C RID: 29292 RVA: 0x0036BDB4 File Offset: 0x00369FB4
	public bool CPFGPMBFODO()
	{
		return this.EOMIPBPBCOB() || (LocationLogic.getI.NPCLNJACPFH() && Input.GetKeyDown(KeyCode.G));
	}

	// Token: 0x0600726D RID: 29293 RVA: 0x0036BDD5 File Offset: 0x00369FD5
	public bool IKGALPMNDLA()
	{
		return !this.HAHHHJIHBNE() && (JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD() || (LocationLogic.getI.JDGFBKCIICG() && (Input.GetKey((KeyCode)(-1)) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600726E RID: 29294 RVA: 0x0036BE0C File Offset: 0x0036A00C
	public void NFCGOKEJGNN(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.KPHACMEBMDG() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			this.POIKONDPGEH(JLJJKMLJBAK);
		}
		if (this.KOABDDLCMHL())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x0036BE64 File Offset: 0x0036A064
	public bool EBPADNLPBHD()
	{
		return !this.NNFCABGFBBN() && (JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() || (LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.Question) | Input.GetMouseButton(0))));
	}

	// Token: 0x06007270 RID: 29296 RVA: 0x0036BE9C File Offset: 0x0036A09C
	private bool BNFLLODEAPO()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007271 RID: 29297 RVA: 0x0036BEF0 File Offset: 0x0036A0F0
	public void NDNANOIMIKL(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.EIHBGJBIICO() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.LKLDOFAFKPC(JLJJKMLJBAK);
		}
		if (this.NNCNCNIOIFP())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x06007272 RID: 29298 RVA: 0x0036BF48 File Offset: 0x0036A148
	public bool GIPOBNPGOBJ()
	{
		return this.EOMIPBPBCOB() || (LocationLogic.getI.IMEEHCHFJME() && Input.GetKeyDown(KeyCode.F));
	}

	// Token: 0x06007273 RID: 29299 RVA: 0x0036BF69 File Offset: 0x0036A169
	public bool IKAHBNENMJF()
	{
		return this.OINHKEJJHHD() || JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG() || (LocationLogic.getI.HNJGFKKGOEC() && (Input.GetKey(KeyCode.R) | Input.GetMouseButton(1)));
	}

	// Token: 0x06007274 RID: 29300 RVA: 0x0036BFA0 File Offset: 0x0036A1A0
	private bool DLMCBNMPFFF()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007275 RID: 29301 RVA: 0x0036BFF4 File Offset: 0x0036A1F4
	public bool BFEBNDCACJC()
	{
		return this.DKKODJGLKNO() || (Input.GetKeyDown(KeyCode.Percent) | Input.GetMouseButtonDown(3));
	}

	// Token: 0x06007276 RID: 29302 RVA: 0x0036C010 File Offset: 0x0036A210
	private bool IDIGIKOGMMK()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 0)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007277 RID: 29303 RVA: 0x0036C064 File Offset: 0x0036A264
	private void CFGEDFCANJG(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[1], 1797f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x06007278 RID: 29304 RVA: 0x0036C088 File Offset: 0x0036A288
	private void POIKONDPGEH(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[5], 1614f);
		JLJJKMLJBAK.HPLDIIIFDCP(true);
	}

	// Token: 0x06007279 RID: 29305 RVA: 0x0036C0AC File Offset: 0x0036A2AC
	private void DMDFDJAJHPO(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[6], 1772f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x0600727A RID: 29306 RVA: 0x0036C0D0 File Offset: 0x0036A2D0
	public bool LMNGEPHKHKC()
	{
		return !this.LPAOHPIMADJ() && (Input.GetKeyDown(KeyCode.Tab) | Input.GetMouseButtonDown(3));
	}

	// Token: 0x0600727B RID: 29307 RVA: 0x0036C0EC File Offset: 0x0036A2EC
	public void CALGPDKFLOC(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.BFEBNDCACJC() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.POLNHPHNDIM(JLJJKMLJBAK);
		}
		if (this.COEICEJLPFF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x0600727C RID: 29308 RVA: 0x0036C144 File Offset: 0x0036A344
	public bool KOABDDLCMHL()
	{
		return this.BBNLHAGIEFH() || (LocationLogic.getI.NPCLNJACPFH() && Input.GetKeyDown((KeyCode)(-55)));
	}

	// Token: 0x0600727D RID: 29309 RVA: 0x0036C165 File Offset: 0x0036A365
	public bool BJCENHACKEK()
	{
		return !this.HAHHHJIHBNE() && (JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL || (LocationLogic.getI.HNJGFKKGOEC() && (Input.GetKey((KeyCode)86) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600727E RID: 29310 RVA: 0x0036C19B File Offset: 0x0036A39B
	private void DBELGDCGJND(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[6], 1025f);
		JLJJKMLJBAK.HPLDIIIFDCP(false);
	}

	// Token: 0x0600727F RID: 29311 RVA: 0x0036C1C0 File Offset: 0x0036A3C0
	private bool DFGBGHPFCFO()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007280 RID: 29312 RVA: 0x0036C214 File Offset: 0x0036A414
	private void LKLDOFAFKPC(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[4], 436f);
		JLJJKMLJBAK.BCPJHJEBBPM(false);
	}

	// Token: 0x06007281 RID: 29313 RVA: 0x0036C238 File Offset: 0x0036A438
	public bool KBJBHIIOFPE()
	{
		return this.FJPPICALNLP() || JDCEFOFMGHB.MNJNNDHCDGG().JBMEDLAFJNI() || (LocationLogic.getI.PALEEIAKEGE && (Input.GetKey((KeyCode)(-97)) | Input.GetMouseButton(0)));
	}

	// Token: 0x06007282 RID: 29314 RVA: 0x0036C26E File Offset: 0x0036A46E
	public bool GBIBIHLBCDM()
	{
		return !this.LPAOHPIMADJ() && !JDCEFOFMGHB.HMJJPNDEKPP().NKJEEHEODBF() && (!LocationLogic.getI.DBPKJJHKEFB() || (Input.GetKey(KeyCode.O) | Input.GetMouseButton(1)));
	}

	// Token: 0x06007283 RID: 29315 RVA: 0x0036C2A4 File Offset: 0x0036A4A4
	private void OBNECOPFGCD(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[0], 929f);
		JLJJKMLJBAK.HPLDIIIFDCP(true);
	}

	// Token: 0x06007284 RID: 29316 RVA: 0x0036C2C8 File Offset: 0x0036A4C8
	public bool KGGGBMDJBFD()
	{
		return this.IDIGIKOGMMK() || (LocationLogic.getI.LMODDKDOFKH() && Input.GetKeyDown((KeyCode)(-83)));
	}

	// Token: 0x06007285 RID: 29317 RVA: 0x0036C2E9 File Offset: 0x0036A4E9
	public bool ENCOKMCIBIP()
	{
		return !this.CJJCHJICFFN() && !JDCEFOFMGHB.MNJNNDHCDGG().AMGIJECABAD() && (!LocationLogic.getI.NPCLNJACPFH() || (Input.GetKey((KeyCode)(-46)) | Input.GetMouseButton(1)));
	}

	// Token: 0x06007286 RID: 29318 RVA: 0x0036C31F File Offset: 0x0036A51F
	public bool DLIFNCGAMFF()
	{
		return !this.LNLNCBGPCNA() && LocationLogic.getI.LMODDKDOFKH() && Input.GetKeyDown((KeyCode)67);
	}

	// Token: 0x06007287 RID: 29319 RVA: 0x0036C340 File Offset: 0x0036A540
	public bool FNBMDPIKIIK()
	{
		return !this.CJLMPKABFAF() && !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.G) | Input.GetMouseButton(1));
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x0036C376 File Offset: 0x0036A576
	public bool DBKKNMHMGGN()
	{
		return !this.HAHHHJIHBNE() && (JDCEFOFMGHB.HMJJPNDEKPP().BHBCONNDEBA() || (LocationLogic.getI.LMODDKDOFKH() && (Input.GetKey((KeyCode)(-1)) | Input.GetMouseButton(1))));
	}

	// Token: 0x06007289 RID: 29321 RVA: 0x0036C3AC File Offset: 0x0036A5AC
	public bool DFCFJPPJDEF()
	{
		return this.ONLCFGLMMKH() || !LocationLogic.getI.DBPKJJHKEFB() || Input.GetKeyDown((KeyCode)(-84));
	}

	// Token: 0x0600728A RID: 29322 RVA: 0x0036C3D0 File Offset: 0x0036A5D0
	public void DDNLOPAKLGH(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.GDGJNCCPBPG() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			this.HOCANGMOLDF(JLJJKMLJBAK);
		}
		if (this.ICFNBGOMJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x0600728B RID: 29323 RVA: 0x0036C428 File Offset: 0x0036A628
	private bool NNFCABGFBBN()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600728C RID: 29324 RVA: 0x0036C47C File Offset: 0x0036A67C
	public bool ODPAFFDHFGF()
	{
		return !this.DKKODJGLKNO() && !JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.Underscore) | Input.GetMouseButton(0));
	}

	// Token: 0x0600728D RID: 29325 RVA: 0x0036C4B2 File Offset: 0x0036A6B2
	public bool HKKAHNPLFDA()
	{
		return !this.DLMCBNMPFFF() && LocationLogic.getI.PCCLPPDMGLA() && Input.GetKeyDown((KeyCode)(-105));
	}

	// Token: 0x0600728E RID: 29326 RVA: 0x0036C4D3 File Offset: 0x0036A6D3
	public bool MLOKGGGHOJM()
	{
		return this.LPAOHPIMADJ() || (!JDCEFOFMGHB.JFIDAGABKID().JBMEDLAFJNI() && LocationLogic.getI.EBDMDMJJHGK() && (Input.GetKey((KeyCode)(-31)) | Input.GetMouseButton(1)));
	}

	// Token: 0x0600728F RID: 29327 RVA: 0x0036C509 File Offset: 0x0036A709
	public bool AKNIBCIODDB()
	{
		return !this.BNFLLODEAPO() && (JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD() || (LocationLogic.getI.PCCLPPDMGLA() && (Input.GetKey((KeyCode)(-73)) | Input.GetMouseButton(0))));
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x0036C53F File Offset: 0x0036A73F
	public bool BDOGPPEDHIK()
	{
		return !this.LPAOHPIMADJ() && !JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey((KeyCode)(-44)) | Input.GetMouseButton(1));
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x0036C578 File Offset: 0x0036A778
	public void HOGNMFOFNCG(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.KAKNJFILNIE() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.OGKHEFCBBDI(JLJJKMLJBAK);
		}
		if (this.COEICEJLPFF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x0036C5D0 File Offset: 0x0036A7D0
	private void GHPELOILOBP(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(SoundSamplesStorage.getI.clips[8], 1760f);
		JLJJKMLJBAK.HPLDIIIFDCP(true);
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x0036C5F4 File Offset: 0x0036A7F4
	private bool LNLNCBGPCNA()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007294 RID: 29332 RVA: 0x0036C648 File Offset: 0x0036A848
	public bool HIGLKCLAFLL()
	{
		return this.IDIGIKOGMMK() || (LocationLogic.getI.EBDMDMJJHGK() && Input.GetKeyDown(KeyCode.Slash));
	}

	// Token: 0x06007295 RID: 29333 RVA: 0x0036C669 File Offset: 0x0036A869
	public bool JKKPBBMCOAE()
	{
		return !this.CJLMPKABFAF() && !JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && (!LocationLogic.getI.PCCLPPDMGLA() || (Input.GetKey((KeyCode)(-73)) | Input.GetMouseButton(0)));
	}

	// Token: 0x06007296 RID: 29334 RVA: 0x0036C69F File Offset: 0x0036A89F
	private void NJNPOFCLGCJ(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[5], 1707f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x06007297 RID: 29335 RVA: 0x0036C6C3 File Offset: 0x0036A8C3
	public bool KDFNIPABIGI()
	{
		return !this.CJJCHJICFFN() && LocationLogic.getI.PCCLPPDMGLA() && Input.GetKeyDown(KeyCode.Question);
	}

	// Token: 0x06007298 RID: 29336 RVA: 0x0036C6E4 File Offset: 0x0036A8E4
	public bool FJGJHGODCPB()
	{
		return this.IDIGIKOGMMK() || !LocationLogic.getI.JDGFBKCIICG() || Input.GetKeyDown((KeyCode)(-122));
	}

	// Token: 0x06007299 RID: 29337 RVA: 0x0036C705 File Offset: 0x0036A905
	public bool GGFAIIPPJJG()
	{
		return this.OGHHLFKDLIM() || !LocationLogic.getI.NPCLNJACPFH() || Input.GetKeyDown((KeyCode)(-125));
	}

	// Token: 0x0600729A RID: 29338 RVA: 0x0036C726 File Offset: 0x0036A926
	public bool DIBINELBGEC()
	{
		return this.NNFCABGFBBN() || (!JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && LocationLogic.getI.LMODDKDOFKH() && (Input.GetKey((KeyCode)(-87)) | Input.GetMouseButton(1)));
	}

	// Token: 0x0600729C RID: 29340 RVA: 0x0036C75C File Offset: 0x0036A95C
	public bool MICELLFEEAD()
	{
		return this.DKKODJGLKNO() || (!JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA() && (!LocationLogic.getI.PALEEIAKEGE || (Input.GetKey((KeyCode)(-125)) | Input.GetMouseButton(0))));
	}

	// Token: 0x0600729D RID: 29341 RVA: 0x0036C792 File Offset: 0x0036A992
	public bool DDADGHACJMF()
	{
		return this.DLMCBNMPFFF() || (Input.GetKeyDown((KeyCode)(-70)) | Input.GetMouseButtonDown(8));
	}

	// Token: 0x0600729E RID: 29342 RVA: 0x0036C7AC File Offset: 0x0036A9AC
	public bool HAFDLOAOAKO()
	{
		return this.OINHKEJJHHD() || (Input.GetKeyDown(KeyCode.Quote) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x0600729F RID: 29343 RVA: 0x0036C7C8 File Offset: 0x0036A9C8
	public void OJDMMAEJBMD(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.EMIIHHPCKDE() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.EHGMONLIDGO(JLJJKMLJBAK);
		}
		if (this.POHCIEAAEOM())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x060072A0 RID: 29344 RVA: 0x0036C820 File Offset: 0x0036AA20
	public bool CGJGJHCKDNA()
	{
		return this.CJJCHJICFFN() || !LocationLogic.getI.PCCLPPDMGLA() || Input.GetKeyDown(KeyCode.Pipe);
	}

	// Token: 0x060072A1 RID: 29345 RVA: 0x0036C841 File Offset: 0x0036AA41
	public bool HENAMKKHGBE()
	{
		return !this.DFGBGHPFCFO() && (JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD() || (LocationLogic.getI.IMEEHCHFJME() && (Input.GetKey((KeyCode)(-36)) | Input.GetMouseButton(1))));
	}

	// Token: 0x060072A2 RID: 29346 RVA: 0x0036C877 File Offset: 0x0036AA77
	private void DAHONNCFDPA(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[8], 878f);
		JLJJKMLJBAK.BCPJHJEBBPM(false);
	}

	// Token: 0x060072A3 RID: 29347 RVA: 0x0036C89C File Offset: 0x0036AA9C
	private bool CJJCHJICFFN()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 0)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060072A4 RID: 29348 RVA: 0x0036C8F0 File Offset: 0x0036AAF0
	public bool JLCPGIDHOBG()
	{
		return this.CJLMPKABFAF() || JDCEFOFMGHB.MNJNNDHCDGG().BHBCONNDEBA() || (LocationLogic.getI.JDGFBKCIICG() && (Input.GetKey((KeyCode)(-23)) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072A5 RID: 29349 RVA: 0x0036C926 File Offset: 0x0036AB26
	public bool IDAOJAAHKEK()
	{
		return !this.DFGBGHPFCFO() && !JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG() && (!LocationLogic.getI.JDGFBKCIICG() || (Input.GetKey((KeyCode)(-21)) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072A6 RID: 29350 RVA: 0x0036C95C File Offset: 0x0036AB5C
	public bool FKMKNPICNIB()
	{
		return this.CJJCHJICFFN() || (!JDCEFOFMGHB.MNJNNDHCDGG().BHBCONNDEBA() && (!LocationLogic.getI.IMEEHCHFJME() || (Input.GetKey((KeyCode)85) | Input.GetMouseButton(0))));
	}

	// Token: 0x060072A7 RID: 29351 RVA: 0x0036C992 File Offset: 0x0036AB92
	private void OADECOOBDEE(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[0], 1688f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x060072A8 RID: 29352 RVA: 0x0036C9B6 File Offset: 0x0036ABB6
	private void EHGMONLIDGO(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[4], 1512f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x060072A9 RID: 29353 RVA: 0x0036C9DA File Offset: 0x0036ABDA
	public bool CPECBMEOMGD()
	{
		return this.LNLNCBGPCNA() || !LocationLogic.getI.PALEEIAKEGE || Input.GetKeyDown((KeyCode)(-80));
	}

	// Token: 0x060072AA RID: 29354 RVA: 0x0036C9FC File Offset: 0x0036ABFC
	public void OHMGCNADEKN(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.OGJCGEKAJHP() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.NLFDNAOJBMH(JLJJKMLJBAK);
		}
		if (this.COEICEJLPFF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x060072AB RID: 29355 RVA: 0x0036CA54 File Offset: 0x0036AC54
	public void BDEMLIANFBP(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.KAKNJFILNIE() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.DAHONNCFDPA(JLJJKMLJBAK);
		}
		if (this.GGFAIIPPJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x060072AC RID: 29356 RVA: 0x0036CAAC File Offset: 0x0036ACAC
	public void HPJFBAOGPPC(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.HDEBIPPCHBK() && this.DDADGHACJMF() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			this.PJDIAOHMECG(JLJJKMLJBAK);
		}
		if (this.BAAGNPLLIOF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x0036CB04 File Offset: 0x0036AD04
	public bool EPKCLOEGPCM()
	{
		return !this.DKKODJGLKNO() && (Input.GetKeyDown((KeyCode)87) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x060072AE RID: 29358 RVA: 0x0036CB1E File Offset: 0x0036AD1E
	public bool NAOLCDJJPCN()
	{
		return !this.BBNLHAGIEFH() && !JDCEFOFMGHB.IKGFHGKKCPG.BHBCONNDEBA() && LocationLogic.getI.HNJGFKKGOEC() && (Input.GetKey((KeyCode)(-88)) | Input.GetMouseButton(1));
	}

	// Token: 0x060072AF RID: 29359 RVA: 0x0036CB54 File Offset: 0x0036AD54
	public bool KPHACMEBMDG()
	{
		return this.OINHKEJJHHD() || (Input.GetKeyDown((KeyCode)(-24)) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x060072B0 RID: 29360 RVA: 0x0036CB6E File Offset: 0x0036AD6E
	public bool KJNGLJHBGGK()
	{
		return this.EOMIPBPBCOB() || (Input.GetKeyDown((KeyCode)(-76)) | Input.GetMouseButtonDown(8));
	}

	// Token: 0x060072B2 RID: 29362 RVA: 0x0036CB94 File Offset: 0x0036AD94
	public void LAAOLLAHPNA(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.EMIIHHPCKDE() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.CFGEDFCANJG(JLJJKMLJBAK);
		}
		if (this.DLIFNCGAMFF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x060072B3 RID: 29363 RVA: 0x0036CBEC File Offset: 0x0036ADEC
	public bool FHHNAHDOPMF()
	{
		return this.DFGBGHPFCFO() || JDCEFOFMGHB.MNJNNDHCDGG().JBMEDLAFJNI() || (LocationLogic.getI.DBPKJJHKEFB() && (Input.GetKey((KeyCode)16) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072B4 RID: 29364 RVA: 0x0036CC22 File Offset: 0x0036AE22
	private void HAIOHLEKDFK(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[0], 1938f);
		JLJJKMLJBAK.HPLDIIIFDCP(false);
	}

	// Token: 0x060072B5 RID: 29365 RVA: 0x0036CC46 File Offset: 0x0036AE46
	public bool NHHLFLOJHPH()
	{
		return !this.DFGBGHPFCFO() && (JDCEFOFMGHB.JFIDAGABKID().NKJEEHEODBF() || (LocationLogic.getI.PALEEIAKEGE && (Input.GetKey((KeyCode)(-106)) | Input.GetMouseButton(0))));
	}

	// Token: 0x060072B6 RID: 29366 RVA: 0x0036CC7C File Offset: 0x0036AE7C
	public bool JMAMMIIKPFM()
	{
		return this.DKKODJGLKNO() || (LocationLogic.getI.NPCLNJACPFH() && Input.GetKeyDown((KeyCode)(-128)));
	}

	// Token: 0x060072B7 RID: 29367 RVA: 0x0036CCA0 File Offset: 0x0036AEA0
	private bool ONLCFGLMMKH()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 0)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060072B8 RID: 29368 RVA: 0x0036CCF4 File Offset: 0x0036AEF4
	public void BCMHDKDJGBI(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.OGJCGEKAJHP() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.POIKONDPGEH(JLJJKMLJBAK);
		}
		if (this.GGFAIIPPJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x060072B9 RID: 29369 RVA: 0x0036CD4C File Offset: 0x0036AF4C
	public bool HNELIEGKFLE()
	{
		return this.BBNLHAGIEFH() || (!JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.V) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072BA RID: 29370 RVA: 0x0036CD82 File Offset: 0x0036AF82
	public bool ILBFIJAIEDO()
	{
		return !this.DLMCBNMPFFF() && (JDCEFOFMGHB.IKGFHGKKCPG.BHBCONNDEBA() || !LocationLogic.getI.IMEEHCHFJME() || (Input.GetKey(KeyCode.V) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072BB RID: 29371 RVA: 0x0036CDB8 File Offset: 0x0036AFB8
	public bool NHOFFJBMJCH()
	{
		return this.OGHHLFKDLIM() || (!JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG() && (!LocationLogic.getI.EBDMDMJJHGK() || (Input.GetKey((KeyCode)(-102)) | Input.GetMouseButton(1))));
	}

	// Token: 0x060072BC RID: 29372 RVA: 0x0036CDF0 File Offset: 0x0036AFF0
	private bool BBNLHAGIEFH()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
			{
				return false;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060072BD RID: 29373 RVA: 0x0036CE44 File Offset: 0x0036B044
	public bool CEOCFCJJBOP()
	{
		return this.IDIGIKOGMMK() || JDCEFOFMGHB.IKGFHGKKCPG.JBMEDLAFJNI() || !LocationLogic.getI.IMEEHCHFJME() || (Input.GetKey(KeyCode.Tilde) | Input.GetMouseButton(1));
	}

	// Token: 0x060072BE RID: 29374 RVA: 0x0036CE7A File Offset: 0x0036B07A
	public bool FNOOBGBDKJJ()
	{
		return this.CJLMPKABFAF() || JDCEFOFMGHB.MNJNNDHCDGG().NKJEEHEODBF() || (LocationLogic.getI.DBPKJJHKEFB() && (Input.GetKey(KeyCode.Less) | Input.GetMouseButton(0)));
	}

	// Token: 0x060072BF RID: 29375 RVA: 0x0036CEB0 File Offset: 0x0036B0B0
	public bool GDGJNCCPBPG()
	{
		return this.DFGBGHPFCFO() || (Input.GetKeyDown((KeyCode)(-43)) | Input.GetMouseButtonDown(6));
	}

	// Token: 0x060072C0 RID: 29376 RVA: 0x0036CECC File Offset: 0x0036B0CC
	private bool FJPPICALNLP()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 0)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060072C1 RID: 29377 RVA: 0x0036CF20 File Offset: 0x0036B120
	public bool ACFBCEEJNEF()
	{
		return this.DFGBGHPFCFO() || JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL || (LocationLogic.getI.EBDMDMJJHGK() && (Input.GetKey((KeyCode)71) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072C2 RID: 29378 RVA: 0x0036CF56 File Offset: 0x0036B156
	public bool NNCNCNIOIFP()
	{
		return !this.DLMCBNMPFFF() && (!LocationLogic.getI.HNJGFKKGOEC() || Input.GetKeyDown((KeyCode)(-108)));
	}

	// Token: 0x060072C3 RID: 29379 RVA: 0x0036CF78 File Offset: 0x0036B178
	public void BLMJJLNIPLG(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.IMBDAJPJPNK() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.LKLDOFAFKPC(JLJJKMLJBAK);
		}
		if (this.ICFNBGOMJJG())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x060072C4 RID: 29380 RVA: 0x0036CFD0 File Offset: 0x0036B1D0
	public bool LODANOFDIEI()
	{
		return !this.LPAOHPIMADJ() && (JDCEFOFMGHB.MNJNNDHCDGG().NKJEEHEODBF() || !LocationLogic.getI.HNJGFKKGOEC() || (Input.GetKey((KeyCode)87) | Input.GetMouseButton(0)));
	}

	// Token: 0x060072C5 RID: 29381 RVA: 0x0036D006 File Offset: 0x0036B206
	public bool OEFFCHGLLKI()
	{
		return !this.BNFLLODEAPO() && LocationLogic.getI.LMODDKDOFKH() && Input.GetKeyDown((KeyCode)(-89));
	}

	// Token: 0x060072C6 RID: 29382 RVA: 0x0036D027 File Offset: 0x0036B227
	public bool MEACLDNOEFN()
	{
		return !this.CJLMPKABFAF() && !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.H) | Input.GetMouseButton(0));
	}

	// Token: 0x060072C7 RID: 29383 RVA: 0x0036D05D File Offset: 0x0036B25D
	private void HOCANGMOLDF(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[3], 0.8f);
		JLJJKMLJBAK.BGLLPMKNBCE = false;
	}

	// Token: 0x060072C8 RID: 29384 RVA: 0x0036D084 File Offset: 0x0036B284
	public void MIMOACHDMAC(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.LNPOODFGCFF() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			this.NJNPOFCLGCJ(JLJJKMLJBAK);
		}
		if (this.DFCFJPPJDEF())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.fishPodsek();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x060072C9 RID: 29385 RVA: 0x0036D0DC File Offset: 0x0036B2DC
	public bool EMIIHHPCKDE()
	{
		return !this.EOMIPBPBCOB() && (Input.GetKeyDown((KeyCode)(-78)) | Input.GetMouseButtonDown(6));
	}

	// Token: 0x060072CA RID: 29386 RVA: 0x0036D0F6 File Offset: 0x0036B2F6
	public bool ANFLGMHOCPL()
	{
		return this.EOMIPBPBCOB() || JDCEFOFMGHB.HMJJPNDEKPP().NKJEEHEODBF() || (LocationLogic.getI.PALEEIAKEGE && (Input.GetKey(KeyCode.K) | Input.GetMouseButton(1)));
	}

	// Token: 0x060072CB RID: 29387 RVA: 0x0036D12C File Offset: 0x0036B32C
	public bool LAFNECBBOIH()
	{
		return this.ONLCFGLMMKH() || (Input.GetKeyDown((KeyCode)(-10)) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x0036D146 File Offset: 0x0036B346
	public bool COEICEJLPFF()
	{
		return this.BBNLHAGIEFH() || !LocationLogic.getI.IMEEHCHFJME() || Input.GetKeyDown(KeyCode.Colon);
	}

	// Token: 0x060072CD RID: 29389 RVA: 0x0036D167 File Offset: 0x0036B367
	private void OAAIFBAGDMO(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[2], 1765f);
		JLJJKMLJBAK.BCPJHJEBBPM(true);
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x0036D18B File Offset: 0x0036B38B
	public bool BCEJLPALIFO()
	{
		return !this.ONLCFGLMMKH() && !JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL && LocationLogic.getI.DBPKJJHKEFB() && (Input.GetKey(KeyCode.Plus) | Input.GetMouseButton(0));
	}

	// Token: 0x060072CF RID: 29391 RVA: 0x0036D1C1 File Offset: 0x0036B3C1
	public bool EIHBGJBIICO()
	{
		return !this.CJLMPKABFAF() && (Input.GetKeyDown(KeyCode.Space) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x060072D0 RID: 29392 RVA: 0x0036D1DB File Offset: 0x0036B3DB
	public bool CAIFMJGKEJH()
	{
		return !this.BBNLHAGIEFH() && (JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL || (LocationLogic.getI.DBPKJJHKEFB() && (Input.GetKey((KeyCode)(-43)) | Input.GetMouseButton(0))));
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x0036D211 File Offset: 0x0036B411
	public bool LNPOODFGCFF()
	{
		return !this.CJJCHJICFFN() && (Input.GetKeyDown(KeyCode.LeftParen) | Input.GetMouseButtonDown(7));
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x0036D22B File Offset: 0x0036B42B
	public bool HCKJOLPJNEP()
	{
		return this.LPAOHPIMADJ() || (!JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD() && (!LocationLogic.getI.NPCLNJACPFH() || (Input.GetKey((KeyCode)(-19)) | Input.GetMouseButton(1))));
	}

	// Token: 0x060072D3 RID: 29395 RVA: 0x0036D264 File Offset: 0x0036B464
	private bool HAHHHJIHBNE()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x0036D2B8 File Offset: 0x0036B4B8
	private bool OGHHLFKDLIM()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060072D5 RID: 29397 RVA: 0x0036D30C File Offset: 0x0036B50C
	public bool IMBDAJPJPNK()
	{
		return this.FJPPICALNLP() || (Input.GetKeyDown((KeyCode)(-18)) | Input.GetMouseButtonDown(4));
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x0036D326 File Offset: 0x0036B526
	public bool EJEFLGPAHHN()
	{
		return this.LNLNCBGPCNA() || (!JDCEFOFMGHB.HMJJPNDEKPP().AMGIJECABAD() && LocationLogic.getI.PALEEIAKEGE && (Input.GetKey((KeyCode)(-51)) | Input.GetMouseButton(0)));
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x0036D35C File Offset: 0x0036B55C
	public bool BAAGNPLLIOF()
	{
		return !this.EOMIPBPBCOB() && LocationLogic.getI.PCCLPPDMGLA() && Input.GetKeyDown(KeyCode.Tab);
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x0036D37D File Offset: 0x0036B57D
	public bool POHCIEAAEOM()
	{
		return this.LPAOHPIMADJ() || !LocationLogic.getI.JDGFBKCIICG() || Input.GetKeyDown((KeyCode)(-23));
	}

	// Token: 0x060072D9 RID: 29401 RVA: 0x0036D3A0 File Offset: 0x0036B5A0
	private bool EOMIPBPBCOB()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 0)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x0036D3F4 File Offset: 0x0036B5F4
	public bool OGJCGEKAJHP()
	{
		return this.BBNLHAGIEFH() || (Input.GetKeyDown(KeyCode.RightBracket) | Input.GetMouseButtonDown(2));
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x0036D40E File Offset: 0x0036B60E
	public bool BJIDLLDIPIM()
	{
		return this.DLMCBNMPFFF() || JDCEFOFMGHB.HMJJPNDEKPP().BHBCONNDEBA() || !LocationLogic.getI.PCCLPPDMGLA() || (Input.GetKey(KeyCode.Pause) | Input.GetMouseButton(0));
	}

	// Token: 0x060072DC RID: 29404 RVA: 0x0036D444 File Offset: 0x0036B644
	public bool PHFJHKDKOMG()
	{
		return this.FJPPICALNLP() || !LocationLogic.getI.PALEEIAKEGE || Input.GetKeyDown((KeyCode)87);
	}

	// Token: 0x060072DD RID: 29405 RVA: 0x0036D465 File Offset: 0x0036B665
	private void LCBGHINEKHI(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[4], 1600f);
		JLJJKMLJBAK.BGLLPMKNBCE = true;
	}

	// Token: 0x060072DE RID: 29406 RVA: 0x0036D489 File Offset: 0x0036B689
	public bool HPCBKMAHDJH()
	{
		return !this.EOMIPBPBCOB() && (!LocationLogic.getI.EBDMDMJJHGK() || Input.GetKeyDown((KeyCode)(-83)));
	}

	// Token: 0x060072DF RID: 29407 RVA: 0x0036D4AA File Offset: 0x0036B6AA
	public bool ELBPIABKGJI()
	{
		return this.DKKODJGLKNO() || (!JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL && (!LocationLogic.getI.PALEEIAKEGE || (Input.GetKey((KeyCode)(-7)) | Input.GetMouseButton(1))));
	}

	// Token: 0x060072E0 RID: 29408 RVA: 0x0036D4E0 File Offset: 0x0036B6E0
	private bool CJLMPKABFAF()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x0036D534 File Offset: 0x0036B734
	private void JECGALBIFAB(FRodObject JLJJKMLJBAK)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[8], 1368f);
		JLJJKMLJBAK.HPLDIIIFDCP(true);
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x0036D558 File Offset: 0x0036B758
	public bool ICFNBGOMJJG()
	{
		return !this.CJLMPKABFAF() && LocationLogic.getI.PALEEIAKEGE && Input.GetKeyDown(KeyCode.T);
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x0036D57C File Offset: 0x0036B77C
	private bool LPAOHPIMADJ()
	{
		if (ChatPanelLogic.getI != null)
		{
			if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
			{
				return true;
			}
			if (ChatPanelLogic.getI.chatLine != null && ChatPanelLogic.getI.chatLine.isFocused)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060072E4 RID: 29412 RVA: 0x0036D5D0 File Offset: 0x0036B7D0
	public void LNCNHPBHABK(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.LAFNECBBOIH() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.CFGEDFCANJG(JLJJKMLJBAK);
		}
		if (this.JMAMMIIKPFM())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			JLJJKMLJBAK.reDrop();
		}
	}

	// Token: 0x060072E5 RID: 29413 RVA: 0x0036D628 File Offset: 0x0036B828
	public void OAPHEAFFBAK(FRodObject JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK.BGLLPMKNBCE && this.EIHBGJBIICO() && !JLJJKMLJBAK.isFishTrapped)
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.CDGEFHCKPAG();
				return;
			}
			this.AHGEOEPEMFE(JLJJKMLJBAK);
		}
		if (this.JMAMMIIKPFM())
		{
			if (JLJJKMLJBAK.isFishGet)
			{
				JLJJKMLJBAK.FGGMIJIOPLB();
				return;
			}
			JLJJKMLJBAK.HFDOMJNDIJJ();
		}
	}

	// Token: 0x040010B8 RID: 4280
	public static OJCFBJGEEHL IKGFHGKKCPG = new OJCFBJGEEHL();
}
