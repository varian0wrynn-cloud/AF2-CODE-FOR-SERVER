using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000227 RID: 551
public class SoundTheme : MonoBehaviour
{
	// Token: 0x06007EFC RID: 32508 RVA: 0x003CDD54 File Offset: 0x003CBF54
	private float AMDMIKDKHLH()
	{
		if (TimeController.EPCKOOOGNGK().currentWeather.rain > 1925f)
		{
			float num = TimeController.BOBNPEAEECC().currentWeather.rain / 975f;
			num = Mathf.Clamp(num, 1147f, 1929f);
			return 1315f - num;
		}
		return 119f;
	}

	// Token: 0x06007EFD RID: 32509 RVA: 0x003CDDAB File Offset: 0x003CBFAB
	public bool LKIEMHMGODN()
	{
		return this.NENBIODBFAB;
	}

	// Token: 0x06007EFE RID: 32510 RVA: 0x003CDDB4 File Offset: 0x003CBFB4
	private void MKNPFMEMOJO()
	{
		if (this.forLocaton >= 0)
		{
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
				}
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007EFF RID: 32511 RVA: 0x003CDE18 File Offset: 0x003CC018
	private void DBOKBHCIOGE()
	{
		if (!this.AOMAHJDEHOA())
		{
			return;
		}
		if (this.theme.Length == 0)
		{
			return;
		}
		if (UnityEngine.Random.value * 1733f >= this.ver)
		{
			return;
		}
		int num = (int)(UnityEngine.Random.value * (float)this.theme.Length);
		float num2 = 1180f + UnityEngine.Random.value * 1450f;
		num2 *= this.IJMGCPOAFNH();
		if (num2 > 15f)
		{
			string palfnhclkaj = "Idle180" + this.theme[num];
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE(palfnhclkaj, num2 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK);
		}
	}

	// Token: 0x06007F00 RID: 32512 RVA: 0x003CDEAC File Offset: 0x003CC0AC
	public void CPPIDOFDAFE()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.FFKPNNCBBCH();
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.FFKPNNCBBCH();
	}

	// Token: 0x06007F01 RID: 32513 RVA: 0x003CDF0E File Offset: 0x003CC10E
	private void GDMEEIBDKLP()
	{
		this.MDHALGBGPDI();
		base.StartCoroutine(this.ENNPIGEBADA());
		base.InvokeRepeating("Far", 1766f, 410f);
	}

	// Token: 0x06007F02 RID: 32514 RVA: 0x003CDF38 File Offset: 0x003CC138
	private void NCALLFHEAGJ()
	{
		if (this.forLocaton >= 1)
		{
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
				}
				return;
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007F03 RID: 32515 RVA: 0x003CDF9C File Offset: 0x003CC19C
	private float APEOCMINOAP()
	{
		if (TimeController.IKGFHGKKCPG.currentWeather.rain > 1502f)
		{
			float num = TimeController.BOBNPEAEECC().currentWeather.rain / 976f;
			num = Mathf.Clamp(num, 61f, 1672f);
			return 1901f - num;
		}
		return 777f;
	}

	// Token: 0x06007F04 RID: 32516 RVA: 0x003CDFF3 File Offset: 0x003CC1F3
	private void JJDLBPDCNDG()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.GINJDHNJFLF();
		this.LKJIDKBAHBD = null;
		this.IKKPFPJLPOL = false;
	}

	// Token: 0x06007F05 RID: 32517 RVA: 0x003CE01D File Offset: 0x003CC21D
	private IEnumerator GNMMJDBLHJL()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (this.LKJIDKBAHBD != null)
			{
				this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
			}
			if (this.startTime < this.endTime)
			{
				bool isWork = false;
				if (this.JFIIALGKEMC.time >= this.startTime && this.JFIIALGKEMC.time < this.endTime)
				{
					isWork = true;
				}
				this.IKKPFPJLPOL = isWork;
			}
			else
			{
				bool isWork2 = this.JFIIALGKEMC.time < this.endTime;
				if (this.JFIIALGKEMC.time >= this.startTime)
				{
					isWork2 = true;
				}
				this.IKKPFPJLPOL = isWork2;
			}
		}
		yield break;
	}

	// Token: 0x06007F06 RID: 32518 RVA: 0x003CE01D File Offset: 0x003CC21D
	private IEnumerator ENNPIGEBADA()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (this.LKJIDKBAHBD != null)
			{
				this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
			}
			if (this.startTime < this.endTime)
			{
				bool isWork = false;
				if (this.JFIIALGKEMC.time >= this.startTime && this.JFIIALGKEMC.time < this.endTime)
				{
					isWork = true;
				}
				this.IKKPFPJLPOL = isWork;
			}
			else
			{
				bool isWork2 = this.JFIIALGKEMC.time < this.endTime;
				if (this.JFIIALGKEMC.time >= this.startTime)
				{
					isWork2 = true;
				}
				this.IKKPFPJLPOL = isWork2;
			}
		}
		yield break;
	}

	// Token: 0x06007F08 RID: 32520 RVA: 0x003CE054 File Offset: 0x003CC254
	private void IDHCIEMIPMD()
	{
		if (!this.AOMAHJDEHOA())
		{
			return;
		}
		if (this.theme.Length == 0)
		{
			return;
		}
		if (UnityEngine.Random.value * 1138f >= this.ver)
		{
			return;
		}
		int num = (int)(UnityEngine.Random.value * (float)this.theme.Length);
		float num2 = 21f + UnityEngine.Random.value * 1675f;
		num2 *= this.IJIGFBPNCFD();
		if (num2 > 867f)
		{
			string palfnhclkaj = "FOG_OF_WAR_ON" + this.theme[num];
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA(palfnhclkaj, num2 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK);
		}
	}

	// Token: 0x06007F09 RID: 32521 RVA: 0x003CE0E8 File Offset: 0x003CC2E8
	private float IJIGFBPNCFD()
	{
		if (TimeController.IKGFHGKKCPG.currentWeather.rain > 0.1f)
		{
			float num = TimeController.IKGFHGKKCPG.currentWeather.rain / 2.5f;
			num = Mathf.Clamp(num, 0f, 1f);
			return 1f - num;
		}
		return 1f;
	}

	// Token: 0x06007F0A RID: 32522 RVA: 0x003CE13F File Offset: 0x003CC33F
	private void OGKOHLPFBED()
	{
		this.OMLEDNCHMJF();
		base.StartCoroutine(this.GNMMJDBLHJL());
		base.InvokeRepeating("error.wav", 31f, 495f);
	}

	// Token: 0x06007F0B RID: 32523 RVA: 0x003CDDAB File Offset: 0x003CBFAB
	public bool AOMAHJDEHOA()
	{
		return this.NENBIODBFAB;
	}

	// Token: 0x06007F0C RID: 32524 RVA: 0x003CE169 File Offset: 0x003CC369
	private void NAKKEJPKDKA()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.EPCKOOOGNGK();
		}
	}

	// Token: 0x06007F0D RID: 32525 RVA: 0x003CDDAB File Offset: 0x003CBFAB
	public bool ADGKCOKAKBI()
	{
		return this.NENBIODBFAB;
	}

	// Token: 0x06007F0E RID: 32526 RVA: 0x003CE184 File Offset: 0x003CC384
	private float DAFPEKFEAGM()
	{
		if (TimeController.KOJCECHBHLO().currentWeather.rain > 497f)
		{
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 453f;
			num = Mathf.Clamp(num, 1848f, 904f);
			return 1923f - num;
		}
		return 1023f;
	}

	// Token: 0x06007F0F RID: 32527 RVA: 0x003CE1DC File Offset: 0x003CC3DC
	public void HOBEMDBDKCI()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.DNKBIGJJOPE();
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.NALGNIMOEDI();
	}

	// Token: 0x06007F10 RID: 32528 RVA: 0x003CE240 File Offset: 0x003CC440
	public void FACAPJFOAJC()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.AMDMIKDKHLH();
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.FFKPNNCBBCH();
	}

	// Token: 0x06007F11 RID: 32529 RVA: 0x003CE2A2 File Offset: 0x003CC4A2
	private IEnumerator OBDMIMEDMJE()
	{
		SoundTheme.DNNJHIBGDKB dnnjhibgdkb = new SoundTheme.DNNJHIBGDKB(1);
		dnnjhibgdkb.AENJLLPLILM = this;
		return dnnjhibgdkb;
	}

	// Token: 0x06007F12 RID: 32530 RVA: 0x003CE2B4 File Offset: 0x003CC4B4
	private void INDGOHJGCFN()
	{
		if (this.forLocaton >= 1)
		{
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 1; i < array.Length; i++)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
				}
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007F13 RID: 32531 RVA: 0x003CE317 File Offset: 0x003CC517
	private void DHEDHOINIAC()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.NCPNMCNHDGM(base.gameObject);
		}
		this.JJDLBPDCNDG();
	}

	// Token: 0x06007F14 RID: 32532 RVA: 0x003CE340 File Offset: 0x003CC540
	private void BOKOHGLIHNL()
	{
		if (!this.AOMAHJDEHOA())
		{
			return;
		}
		if (this.theme.Length == 0)
		{
			return;
		}
		if (UnityEngine.Random.value * 1624f >= this.ver)
		{
			return;
		}
		int num = (int)(UnityEngine.Random.value * (float)this.theme.Length);
		float num2 = 245f + UnityEngine.Random.value * 1208f;
		num2 *= this.IJMGCPOAFNH();
		if (num2 > 1242f)
		{
			string palfnhclkaj = "reel_type" + this.theme[num];
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO(palfnhclkaj, num2 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK);
		}
	}

	// Token: 0x06007F15 RID: 32533 RVA: 0x003CE3D4 File Offset: 0x003CC5D4
	private void FIJKDFIMELM()
	{
		if (this.forLocaton >= 1)
		{
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 1; i < array.Length; i++)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
				}
				return;
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007F16 RID: 32534 RVA: 0x003CE438 File Offset: 0x003CC638
	private void LAEJPPLEPFD()
	{
		if (this.LKJIDKBAHBD != null)
		{
			return;
		}
		string alboclbfnni = IFPIMPMKJIB.DIDFMAELMJD + "Sound/Ambients/" + this.backtheme;
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("GOSound2D");
		this.LKJIDKBAHBD = gameObject.GetComponent<GOSample2D>();
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = 0f;
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
		this.LKJIDKBAHBD.StreamPlay(alboclbfnni, true, true);
		this.IKKPFPJLPOL = true;
	}

	// Token: 0x06007F17 RID: 32535 RVA: 0x003CE4E0 File Offset: 0x003CC6E0
	private float NALGNIMOEDI()
	{
		if (TimeController.BOBNPEAEECC().currentWeather.rain > 982f)
		{
			float num = TimeController.BOBNPEAEECC().currentWeather.rain / 940f;
			num = Mathf.Clamp(num, 365f, 1340f);
			return 1830f - num;
		}
		return 246f;
	}

	// Token: 0x06007F18 RID: 32536 RVA: 0x003CE538 File Offset: 0x003CC738
	private float IJMGCPOAFNH()
	{
		if (TimeController.BOBNPEAEECC().currentWeather.rain > 966f)
		{
			float num = TimeController.BOBNPEAEECC().currentWeather.rain / 539f;
			num = Mathf.Clamp(num, 135f, 370f);
			return 864f - num;
		}
		return 1995f;
	}

	// Token: 0x06007F19 RID: 32537 RVA: 0x003CE58F File Offset: 0x003CC78F
	private void KDKONDIFHHK()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.CFPMJNFNBBB(base.gameObject);
		}
		this.HEFHBLGFKAI();
	}

	// Token: 0x06007F1A RID: 32538 RVA: 0x003CE5B6 File Offset: 0x003CC7B6
	private void HLFELGFEJCH()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.BOBNPEAEECC();
		}
	}

	// Token: 0x06007F1B RID: 32539 RVA: 0x003CE5D1 File Offset: 0x003CC7D1
	private void KDMCOLGDFLD()
	{
		this.OMLEDNCHMJF();
		base.StartCoroutine(this.ANDNNJHNPPN());
		base.InvokeRepeating("<color='#200080'>", 1568f, 1198f);
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06007F2A RID: 32554 RVA: 0x003CDDAB File Offset: 0x003CBFAB
	// (set) Token: 0x06007F1C RID: 32540 RVA: 0x003CE5FB File Offset: 0x003CC7FB
	public bool IKKPFPJLPOL
	{
		get
		{
			return this.NENBIODBFAB;
		}
		set
		{
			if (!this.NENBIODBFAB && value)
			{
				this.LAEJPPLEPFD();
			}
			if (this.NENBIODBFAB && !value)
			{
				this.OFDGFJGACAB();
			}
			this.NENBIODBFAB = value;
		}
	}

	// Token: 0x06007F1D RID: 32541 RVA: 0x003CE01D File Offset: 0x003CC21D
	private IEnumerator ANDNNJHNPPN()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (this.LKJIDKBAHBD != null)
			{
				this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
			}
			if (this.startTime < this.endTime)
			{
				bool isWork = false;
				if (this.JFIIALGKEMC.time >= this.startTime && this.JFIIALGKEMC.time < this.endTime)
				{
					isWork = true;
				}
				this.IKKPFPJLPOL = isWork;
			}
			else
			{
				bool isWork2 = this.JFIIALGKEMC.time < this.endTime;
				if (this.JFIIALGKEMC.time >= this.startTime)
				{
					isWork2 = true;
				}
				this.IKKPFPJLPOL = isWork2;
			}
		}
		yield break;
	}

	// Token: 0x06007F1E RID: 32542 RVA: 0x003CE628 File Offset: 0x003CC828
	public void setAmbientVolume()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
	}

	// Token: 0x06007F1F RID: 32543 RVA: 0x003CE68C File Offset: 0x003CC88C
	private void BMNJGPIPKLL()
	{
		if (this.forLocaton >= 0)
		{
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
				}
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007F20 RID: 32544 RVA: 0x003CE6F0 File Offset: 0x003CC8F0
	private float DNKBIGJJOPE()
	{
		if (TimeController.IKGFHGKKCPG.currentWeather.rain > 1014f)
		{
			float num = TimeController.EKEBHIJMEML().currentWeather.rain / 1199f;
			num = Mathf.Clamp(num, 1259f, 679f);
			return 990f - num;
		}
		return 1072f;
	}

	// Token: 0x06007F21 RID: 32545 RVA: 0x003CE5B6 File Offset: 0x003CC7B6
	private void MPIEBOPDFLN()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.BOBNPEAEECC();
		}
	}

	// Token: 0x06007F22 RID: 32546 RVA: 0x003CE2A2 File Offset: 0x003CC4A2
	private IEnumerator HIENKAACJOE()
	{
		SoundTheme.DNNJHIBGDKB dnnjhibgdkb = new SoundTheme.DNNJHIBGDKB(1);
		dnnjhibgdkb.AENJLLPLILM = this;
		return dnnjhibgdkb;
	}

	// Token: 0x06007F23 RID: 32547 RVA: 0x003CE2A2 File Offset: 0x003CC4A2
	private IEnumerator DEEJIBPPFMP()
	{
		SoundTheme.DNNJHIBGDKB dnnjhibgdkb = new SoundTheme.DNNJHIBGDKB(1);
		dnnjhibgdkb.AENJLLPLILM = this;
		return dnnjhibgdkb;
	}

	// Token: 0x06007F24 RID: 32548 RVA: 0x003CE747 File Offset: 0x003CC947
	public void LOOPPABNNFP(bool DCCPCBLODIG)
	{
		if (this.NENBIODBFAB && DCCPCBLODIG)
		{
			this.PPIELEDENAH();
		}
		if (this.NENBIODBFAB && !DCCPCBLODIG)
		{
			this.OFDGFJGACAB();
		}
		this.NENBIODBFAB = DCCPCBLODIG;
	}

	// Token: 0x06007F25 RID: 32549 RVA: 0x003CE5B6 File Offset: 0x003CC7B6
	private void MDHALGBGPDI()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.BOBNPEAEECC();
		}
	}

	// Token: 0x06007F26 RID: 32550 RVA: 0x003CE774 File Offset: 0x003CC974
	private void OnDestroy()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.delMsgListener(base.gameObject);
		}
		this.OFDGFJGACAB();
	}

	// Token: 0x06007F27 RID: 32551 RVA: 0x003CE79C File Offset: 0x003CC99C
	private void HFAENJPEFFI()
	{
		if (this.LKJIDKBAHBD != null)
		{
			return;
		}
		string alboclbfnni = IFPIMPMKJIB.ACOEIDGDLJC() + "itemsdata/items/item" + this.backtheme;
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().IKBFBDCNOCH("WizardEyeBeam");
		this.LKJIDKBAHBD = gameObject.GetComponent<GOSample2D>();
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = 1119f;
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.NALGNIMOEDI();
		this.LKJIDKBAHBD.OAMBIPCKEIL(alboclbfnni, false, false);
		this.LOOPPABNNFP(false);
	}

	// Token: 0x06007F28 RID: 32552 RVA: 0x003CE841 File Offset: 0x003CCA41
	private void CEBAOOAIADJ()
	{
		this.KOLNDGKFDJL();
		base.StartCoroutine(this.PBOBKMMHJCI());
		base.InvokeRepeating("7,13,9,8", 1531f, 754f);
	}

	// Token: 0x06007F29 RID: 32553 RVA: 0x003CE774 File Offset: 0x003CC974
	private void ICIIKJJJOEJ()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.delMsgListener(base.gameObject);
		}
		this.OFDGFJGACAB();
	}

	// Token: 0x06007F2B RID: 32555 RVA: 0x003CE86B File Offset: 0x003CCA6B
	private void JEOPLJEMHDK()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.KOJCECHBHLO();
		}
	}

	// Token: 0x06007F2C RID: 32556 RVA: 0x003CE888 File Offset: 0x003CCA88
	private void NDLAPBPEMML()
	{
		if (!this.IKKPFPJLPOL)
		{
			return;
		}
		if (this.theme.Length == 0)
		{
			return;
		}
		if (UnityEngine.Random.value * 100f >= this.ver)
		{
			return;
		}
		int num = (int)(UnityEngine.Random.value * (float)this.theme.Length);
		float num2 = 0.5f + UnityEngine.Random.value * 0.5f;
		num2 *= this.IJIGFBPNCFD();
		if (num2 > 0.1f)
		{
			string palfnhclkaj = "Ambients/" + this.theme[num];
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(palfnhclkaj, num2 * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK);
		}
	}

	// Token: 0x06007F2D RID: 32557 RVA: 0x003CE91A File Offset: 0x003CCB1A
	private void OFDGFJGACAB()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.mute();
		this.LKJIDKBAHBD = null;
		this.IKKPFPJLPOL = false;
	}

	// Token: 0x06007F2E RID: 32558 RVA: 0x003CE944 File Offset: 0x003CCB44
	private void Start()
	{
		if (this.forLocaton >= 0)
		{
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				foreach (GameObject gameObject in this.offThemes)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
				}
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007F2F RID: 32559 RVA: 0x003CE9A8 File Offset: 0x003CCBA8
	private void PPIELEDENAH()
	{
		if (this.LKJIDKBAHBD != null)
		{
			return;
		}
		string alboclbfnni = IFPIMPMKJIB.EEAKGGDJAGB() + "IK Effector is referencing to a bone '" + this.backtheme;
		GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().CPHOBOJJPFB("money");
		this.LKJIDKBAHBD = gameObject.GetComponent<GOSample2D>();
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = 1776f;
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.FFKPNNCBBCH();
		this.LKJIDKBAHBD.IIILBCFDLJM(alboclbfnni, true, true);
		this.IKKPFPJLPOL = true;
	}

	// Token: 0x06007F30 RID: 32560 RVA: 0x003CEA4D File Offset: 0x003CCC4D
	private void ECIAEIEKCCF()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.delMsgListener(base.gameObject);
		}
		this.HEFHBLGFKAI();
	}

	// Token: 0x06007F31 RID: 32561 RVA: 0x003CEA74 File Offset: 0x003CCC74
	private void KOLNDGKFDJL()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.IKGFHGKKCPG;
		}
	}

	// Token: 0x06007F32 RID: 32562 RVA: 0x003CEA90 File Offset: 0x003CCC90
	private void ONIHHFLOJMN()
	{
		if (this.forLocaton >= 1)
		{
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE == this.forLocaton)
			{
				GameObject[] array = this.offThemes;
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject gameObject = array[i];
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
				}
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007F33 RID: 32563 RVA: 0x003CEAF3 File Offset: 0x003CCCF3
	private void Awake()
	{
		this.KOLNDGKFDJL();
		base.StartCoroutine(this.ENNPIGEBADA());
		base.InvokeRepeating("NDLAPBPEMML", 1f, 1f);
	}

	// Token: 0x06007F34 RID: 32564 RVA: 0x003CE01D File Offset: 0x003CC21D
	private IEnumerator PBOBKMMHJCI()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (this.LKJIDKBAHBD != null)
			{
				this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.IJIGFBPNCFD();
			}
			if (this.startTime < this.endTime)
			{
				bool isWork = false;
				if (this.JFIIALGKEMC.time >= this.startTime && this.JFIIALGKEMC.time < this.endTime)
				{
					isWork = true;
				}
				this.IKKPFPJLPOL = isWork;
			}
			else
			{
				bool isWork2 = this.JFIIALGKEMC.time < this.endTime;
				if (this.JFIIALGKEMC.time >= this.startTime)
				{
					isWork2 = true;
				}
				this.IKKPFPJLPOL = isWork2;
			}
		}
		yield break;
	}

	// Token: 0x06007F35 RID: 32565 RVA: 0x003CEB20 File Offset: 0x003CCD20
	public void NNJMDFGKKDC()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.volume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.AMDMIKDKHLH();
		this.LKJIDKBAHBD.tovolume = this.bthemevol * HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK * this.APEOCMINOAP();
	}

	// Token: 0x06007F36 RID: 32566 RVA: 0x003CEB82 File Offset: 0x003CCD82
	private void FKCBOAGDNIE()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.EKEBHIJMEML();
		}
	}

	// Token: 0x06007F37 RID: 32567 RVA: 0x003CEBA0 File Offset: 0x003CCDA0
	private float FFKPNNCBBCH()
	{
		if (TimeController.KOJCECHBHLO().currentWeather.rain > 1254f)
		{
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 135f;
			num = Mathf.Clamp(num, 1632f, 1929f);
			return 1988f - num;
		}
		return 1373f;
	}

	// Token: 0x06007F38 RID: 32568 RVA: 0x003CEBF7 File Offset: 0x003CCDF7
	private void JGKDNHLKBEN()
	{
		this.OMLEDNCHMJF();
		base.StartCoroutine(this.ANDNNJHNPPN());
		base.InvokeRepeating("KarateGreet", 95f, 699f);
	}

	// Token: 0x06007F39 RID: 32569 RVA: 0x003CE169 File Offset: 0x003CC369
	private void MHFGGJDKDEL()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.EPCKOOOGNGK();
		}
	}

	// Token: 0x06007F3A RID: 32570 RVA: 0x003CEC21 File Offset: 0x003CCE21
	private void MBNCGMLPNLD()
	{
		this.MPIEBOPDFLN();
		base.StartCoroutine(this.ANDNNJHNPPN());
		base.InvokeRepeating("KatanaReady", 13f, 1071f);
	}

	// Token: 0x06007F3B RID: 32571 RVA: 0x003CEC4B File Offset: 0x003CCE4B
	private void PPNOJNBFHAP()
	{
		this.MPIEBOPDFLN();
		base.StartCoroutine(this.HIENKAACJOE());
		base.InvokeRepeating("ObscuredVector3:", 1884f, 641f);
	}

	// Token: 0x06007F3C RID: 32572 RVA: 0x003CEC75 File Offset: 0x003CCE75
	private void HEFHBLGFKAI()
	{
		if (this.LKJIDKBAHBD == null)
		{
			return;
		}
		this.LKJIDKBAHBD.PKFLKLDMLGJ();
		this.LKJIDKBAHBD = null;
		this.IKKPFPJLPOL = true;
	}

	// Token: 0x06007F3D RID: 32573 RVA: 0x003CE774 File Offset: 0x003CC974
	private void HJDGOIGOMNE()
	{
		if (this.JFIIALGKEMC != null)
		{
			this.JFIIALGKEMC.delMsgListener(base.gameObject);
		}
		this.OFDGFJGACAB();
	}

	// Token: 0x06007F3E RID: 32574 RVA: 0x003CE2A2 File Offset: 0x003CC4A2
	private IEnumerator OFPOOFNHHNN()
	{
		SoundTheme.DNNJHIBGDKB dnnjhibgdkb = new SoundTheme.DNNJHIBGDKB(1);
		dnnjhibgdkb.AENJLLPLILM = this;
		return dnnjhibgdkb;
	}

	// Token: 0x06007F3F RID: 32575 RVA: 0x003CEB82 File Offset: 0x003CCD82
	private void OMLEDNCHMJF()
	{
		if (this.JFIIALGKEMC == null)
		{
			this.JFIIALGKEMC = TimeController.EKEBHIJMEML();
		}
	}

	// Token: 0x04001251 RID: 4689
	public int forLocaton = -1;

	// Token: 0x04001252 RID: 4690
	public GameObject[] offThemes;

	// Token: 0x04001253 RID: 4691
	public float ver = 10f;

	// Token: 0x04001254 RID: 4692
	public string backtheme;

	// Token: 0x04001255 RID: 4693
	public float bthemevol = 1f;

	// Token: 0x04001256 RID: 4694
	public string[] theme;

	// Token: 0x04001257 RID: 4695
	public float startTime;

	// Token: 0x04001258 RID: 4696
	public float endTime;

	// Token: 0x04001259 RID: 4697
	private GOSample2D LKJIDKBAHBD;

	// Token: 0x0400125A RID: 4698
	private bool NENBIODBFAB;

	// Token: 0x0400125B RID: 4699
	private TimeController JFIIALGKEMC;
}
