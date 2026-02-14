using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200021E RID: 542
public class GOSample2D : MonoBehaviour
{
	// Token: 0x06007C64 RID: 31844 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator GGCEBLDONPM()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C65 RID: 31845 RVA: 0x003C456D File Offset: 0x003C276D
	public void FHBCOAJIGLM(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.EDAGJGIDEIG(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C66 RID: 31846 RVA: 0x003C457E File Offset: 0x003C277E
	private IEnumerator OLNBCNOJGPE(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		GOSample2D.IBGOEKFODJK ibgoekfodjk = new GOSample2D.IBGOEKFODJK(1);
		ibgoekfodjk.AENJLLPLILM = this;
		ibgoekfodjk.ALBOCLBFNNI = ALBOCLBFNNI;
		ibgoekfodjk.NJCNBLKBDKO = NJCNBLKBDKO;
		return ibgoekfodjk;
	}

	// Token: 0x06007C67 RID: 31847 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator JHEIIKKEHCE()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007C68 RID: 31848 RVA: 0x003C45AC File Offset: 0x003C27AC
	public void DOFDJGNDBDP(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "Sewing" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1852f;
		base.StartCoroutine(this.BEALIFDMOHD());
	}

	// Token: 0x06007C69 RID: 31849 RVA: 0x003C457E File Offset: 0x003C277E
	private IEnumerator EDAGJGIDEIG(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		GOSample2D.IBGOEKFODJK ibgoekfodjk = new GOSample2D.IBGOEKFODJK(1);
		ibgoekfodjk.AENJLLPLILM = this;
		ibgoekfodjk.ALBOCLBFNNI = ALBOCLBFNNI;
		ibgoekfodjk.NJCNBLKBDKO = NJCNBLKBDKO;
		return ibgoekfodjk;
	}

	// Token: 0x06007C6A RID: 31850 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator IAMICILHDOM()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007C6B RID: 31851 RVA: 0x003C462C File Offset: 0x003C282C
	public void ECNLMCDGMJD(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "ragulaFider" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1451f;
		base.StartCoroutine(this.GACACOAPFFA());
	}

	// Token: 0x06007C6C RID: 31852 RVA: 0x003C46AC File Offset: 0x003C28AC
	private void LAGGDCBJLNK()
	{
		if (this.isMute)
		{
			this.volume -= 1000f * Time.deltaTime;
			if (this.volume <= 975f)
			{
				this.volume = 1898f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1242f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)8)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.JHEIIKKEHCE());
				}
			}
		}
	}

	// Token: 0x06007C6D RID: 31853 RVA: 0x003C47DE File Offset: 0x003C29DE
	public void HBDBJNEEBMJ(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.MJHIMOFMNFM(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C6E RID: 31854 RVA: 0x003C47F0 File Offset: 0x003C29F0
	public void NCKFLOILCHA(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "http://af-2.ru/?q=store" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 42f;
		base.StartCoroutine(this.NDLPDKIDINC());
	}

	// Token: 0x06007C6F RID: 31855 RVA: 0x003C4870 File Offset: 0x003C2A70
	public void KDJNJCJHIOD(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1698f;
		base.StartCoroutine(this.JIPCMCAAELG());
	}

	// Token: 0x06007C70 RID: 31856 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator POFEOIBIJPF()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C71 RID: 31857 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void GELOHGHAMBL()
	{
		this.isMute = true;
	}

	// Token: 0x06007C72 RID: 31858 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator NDLPDKIDINC()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C73 RID: 31859 RVA: 0x003C4906 File Offset: 0x003C2B06
	public void GEHLHOFFAAJ(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.LNHJFKEHLKA(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C74 RID: 31860 RVA: 0x003C4917 File Offset: 0x003C2B17
	public void IDKAJMCCDHN(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.GEOLEHGCHJM(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C75 RID: 31861 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator KLDEONKMDLA()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C76 RID: 31862 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator CBOLCKPCFMD()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C77 RID: 31863 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void HLOHKPKAPNN(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C78 RID: 31864 RVA: 0x003C493C File Offset: 0x003C2B3C
	private void OCJGBIPEELM()
	{
		if (this.isMute)
		{
			this.volume -= 1680f * Time.deltaTime;
			if (this.volume <= 1160f)
			{
				this.volume = 1f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 916f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)5)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GABIEMOPDNM());
				}
			}
		}
	}

	// Token: 0x06007C79 RID: 31865 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator EFDOIDIIHKO(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007C7A RID: 31866 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void mute()
	{
		this.isMute = true;
	}

	// Token: 0x06007C7B RID: 31867 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void DPCCJNJHGND(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C7C RID: 31868 RVA: 0x003C4A8C File Offset: 0x003C2C8C
	public void JMCHMCABOPI(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "_VignetteSettings" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 231f;
		base.StartCoroutine(this.LCFDPJLBAIH());
	}

	// Token: 0x06007C7D RID: 31869 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void BLFLBGDJFAN()
	{
		this.isMute = true;
	}

	// Token: 0x06007C7E RID: 31870 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void CHCJFIEDGBG()
	{
		this.isMute = true;
	}

	// Token: 0x06007C7F RID: 31871 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator FMICPDOCAGH()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007C80 RID: 31872 RVA: 0x003C4B0C File Offset: 0x003C2D0C
	public void GIFOPMIHFAP(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = " x" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1456f;
		base.StartCoroutine(this.PIDOHFJCLBC());
	}

	// Token: 0x06007C81 RID: 31873 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator IHHPHJEOFMA()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C82 RID: 31874 RVA: 0x003C4B8A File Offset: 0x003C2D8A
	public void BGEBAFPHGPO(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.OLNBCNOJGPE(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C83 RID: 31875 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator LCFDPJLBAIH()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C84 RID: 31876 RVA: 0x003C4B9C File Offset: 0x003C2D9C
	private void BJOICAKCPLI()
	{
		if (this.isMute)
		{
			this.volume -= 1519f * Time.deltaTime;
			if (this.volume <= 1659f)
			{
				this.volume = 1915f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1249f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Loaded)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.MBOMNCJMFIC());
				}
			}
		}
	}

	// Token: 0x06007C85 RID: 31877 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator LDONKAHKFLI()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C86 RID: 31878 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator GACACOAPFFA()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C87 RID: 31879 RVA: 0x003C4CD0 File Offset: 0x003C2ED0
	private void KOLCEBEIHKP()
	{
		if (this.isMute)
		{
			this.volume -= 1228f * Time.deltaTime;
			if (this.volume <= 82f)
			{
				this.volume = 1456f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1019f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)4)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.EJEMBKIPPCA());
				}
			}
		}
	}

	// Token: 0x06007C88 RID: 31880 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void HBBIFAFAHBI(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C89 RID: 31881 RVA: 0x003C4E04 File Offset: 0x003C3004
	private void IEOICHPKEMD()
	{
		if (this.isMute)
		{
			this.volume -= 874f * Time.deltaTime;
			if (this.volume <= 1955f)
			{
				this.volume = 711f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 536f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)4)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.JHEIIKKEHCE());
				}
			}
		}
	}

	// Token: 0x06007C8A RID: 31882 RVA: 0x003C4F36 File Offset: 0x003C3136
	public void CKBOBCKNFKG(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.CMGCAGCJNGN(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C8B RID: 31883 RVA: 0x003C4F47 File Offset: 0x003C3147
	private IEnumerator GDNDNKKEINF()
	{
		if (this.BCMFANJFGKE.clip != null)
		{
			this.LHHBOOJPBPH = true;
			float time = Time.time;
			yield return new WaitForSeconds(1f);
			float num = this.BCMFANJFGKE.clip.length - 3f;
			Debug.Log(string.Concat(new object[]
			{
				"******** nextMusicCrt lng=",
				num,
				" path=",
				this.path
			}));
			while (Time.time - time < num)
			{
				num = this.BCMFANJFGKE.clip.length - 3f;
				this.clipLenght = num;
				yield return new WaitForSeconds(1f);
			}
			Debug.Log("******** nextMusicCrt End of music path=" + this.path);
			if (!this.isMute)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPCIKCGADDD();
			}
		}
		yield break;
	}

	// Token: 0x06007C8C RID: 31884 RVA: 0x003C4F58 File Offset: 0x003C3158
	private void JJFHPGDPHGB()
	{
		if (this.isMute)
		{
			this.volume -= 1079f * Time.deltaTime;
			if (this.volume <= 524f)
			{
				this.volume = 1734f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1695f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Loaded)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GDNDNKKEINF());
				}
			}
		}
	}

	// Token: 0x06007C8D RID: 31885 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator PIDOHFJCLBC()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C8E RID: 31886 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator CMGCAGCJNGN(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007C8F RID: 31887 RVA: 0x003C508C File Offset: 0x003C328C
	private void DHDGPGOONBC()
	{
		if (this.isMute)
		{
			this.volume -= 279f * Time.deltaTime;
			if (this.volume <= 1721f)
			{
				this.volume = 63f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1190f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)4)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GDNDNKKEINF());
				}
			}
		}
	}

	// Token: 0x06007C90 RID: 31888 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator KKHKKOELEMG()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C91 RID: 31889 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator CCIOIMEMGFM()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007C92 RID: 31890 RVA: 0x003C51C0 File Offset: 0x003C33C0
	public void MANKHPKCLCH(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "1HandSwordStrafeRight" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 707f;
		base.StartCoroutine(this.FBDKAJDLANJ());
	}

	// Token: 0x06007C93 RID: 31891 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void IHHMJMNBBKO()
	{
		this.isMute = true;
	}

	// Token: 0x06007C94 RID: 31892 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator GABIEMOPDNM()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007C95 RID: 31893 RVA: 0x003C47DE File Offset: 0x003C29DE
	public void MFKDHMNBDAL(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.MJHIMOFMNFM(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C96 RID: 31894 RVA: 0x003C47DE File Offset: 0x003C29DE
	public void CNLFBNDMEKK(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.MJHIMOFMNFM(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x003C5240 File Offset: 0x003C3440
	public void OAMBIPCKEIL(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "droplinemsg1" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1494f;
		base.StartCoroutine(this.APLJGOIEFOD());
	}

	// Token: 0x06007C98 RID: 31896 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void EEAPKMKECGP()
	{
		this.isMute = true;
	}

	// Token: 0x06007C99 RID: 31897 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void KIHANBDIAHP()
	{
		this.isMute = false;
	}

	// Token: 0x06007C9A RID: 31898 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator KBDPLLPGLFO(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007C9B RID: 31899 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator NPIDFADGHIM()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007C9C RID: 31900 RVA: 0x003C52C8 File Offset: 0x003C34C8
	private void KEBDEJIAODF()
	{
		if (this.isMute)
		{
			this.volume -= 1642f * Time.deltaTime;
			if (this.volume <= 375f)
			{
				this.volume = 279f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1405f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Loaded)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GLHBBJHBNOK());
				}
			}
		}
	}

	// Token: 0x06007C9D RID: 31901 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator FJPCPAFADPE()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007C9E RID: 31902 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator MMFIKMPMJPD(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007C9F RID: 31903 RVA: 0x003C53FC File Offset: 0x003C35FC
	public void COAKPNHPOBL(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 354f;
		base.StartCoroutine(this.NDLPDKIDINC());
	}

	// Token: 0x06007CA0 RID: 31904 RVA: 0x003C547C File Offset: 0x003C367C
	private void FPLNDDMFFKG()
	{
		if (this.isMute)
		{
			this.volume -= 1574f * Time.deltaTime;
			if (this.volume <= 778f)
			{
				this.volume = 578f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1700f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)6)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.FMICPDOCAGH());
				}
			}
		}
	}

	// Token: 0x06007CA1 RID: 31905 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator EJEMBKIPPCA()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007CA2 RID: 31906 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void JDBLOMEOFKI(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CA3 RID: 31907 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator GGJCAKJLOII()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CA4 RID: 31908 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void PPICFPNJOKH()
	{
		this.isMute = false;
	}

	// Token: 0x06007CA5 RID: 31909 RVA: 0x003C55B0 File Offset: 0x003C37B0
	private void DIAIKCBANBK()
	{
		if (this.isMute)
		{
			this.volume -= 1916f * Time.deltaTime;
			if (this.volume <= 780f)
			{
				this.volume = 879f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 732f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Unloaded)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.CKMGBJHFLGD());
				}
			}
		}
	}

	// Token: 0x06007CA6 RID: 31910 RVA: 0x003C56E4 File Offset: 0x003C38E4
	private void PBEKBHFDHAM()
	{
		if (this.isMute)
		{
			this.volume -= 1619f * Time.deltaTime;
			if (this.volume <= 403f)
			{
				this.volume = 226f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1773f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)7)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.JHEIIKKEHCE());
				}
			}
		}
	}

	// Token: 0x06007CA7 RID: 31911 RVA: 0x003C5818 File Offset: 0x003C3A18
	private void FKHAKIKPFFO()
	{
		if (this.isMute)
		{
			this.volume -= 1536f * Time.deltaTime;
			if (this.volume <= 1154f)
			{
				this.volume = 1361f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1197f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)4)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.MBOMNCJMFIC());
				}
			}
		}
	}

	// Token: 0x06007CA8 RID: 31912 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void BANDDGHMADP()
	{
		this.isMute = true;
	}

	// Token: 0x06007CA9 RID: 31913 RVA: 0x003C47DE File Offset: 0x003C29DE
	public void HLABCKEKALE(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.MJHIMOFMNFM(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CAA RID: 31914 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void JCIIBONDPAL()
	{
		this.isMute = true;
	}

	// Token: 0x06007CAB RID: 31915 RVA: 0x003C4F47 File Offset: 0x003C3147
	private IEnumerator GLHBBJHBNOK()
	{
		if (this.BCMFANJFGKE.clip != null)
		{
			this.LHHBOOJPBPH = true;
			time = Time.time;
			yield return new WaitForSeconds(1f);
			num = this.BCMFANJFGKE.clip.length - 3f;
			Debug.Log(string.Concat(new object[]
			{
				"******** nextMusicCrt lng=",
				num,
				" path=",
				this.path
			}));
			while (Time.time - time < num)
			{
				num = this.BCMFANJFGKE.clip.length - 3f;
				this.clipLenght = num;
				yield return new WaitForSeconds(1f);
			}
			Debug.Log("******** nextMusicCrt End of music path=" + this.path);
			if (!this.isMute)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPCIKCGADDD();
			}
		}
		yield break;
	}

	// Token: 0x06007CAC RID: 31916 RVA: 0x003C594C File Offset: 0x003C3B4C
	private void JNOHEPNAGLJ()
	{
		if (this.isMute)
		{
			this.volume -= 318f * Time.deltaTime;
			if (this.volume <= 848f)
			{
				this.volume = 1229f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1036f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)7)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.MBOMNCJMFIC());
				}
			}
		}
	}

	// Token: 0x06007CAD RID: 31917 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator JKPHCHBHCCJ(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007CAE RID: 31918 RVA: 0x003C5A80 File Offset: 0x003C3C80
	public void JJFBPNAGHDG(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "_" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1639f;
		base.StartCoroutine(this.NDLPDKIDINC());
	}

	// Token: 0x06007CAF RID: 31919 RVA: 0x003C5B00 File Offset: 0x003C3D00
	public void MMKOJGPMGIE(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1980f;
		base.StartCoroutine(this.LCFDPJLBAIH());
	}

	// Token: 0x06007CB0 RID: 31920 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator IIJKEMFIJGD()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CB1 RID: 31921 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator FFBINIEFNGF()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CB2 RID: 31922 RVA: 0x003C5B7E File Offset: 0x003C3D7E
	public void IIEPKFBCAGC(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.AHOCKAGIGMG(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CB3 RID: 31923 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator MJHIMOFMNFM(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007CB4 RID: 31924 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator CKMGBJHFLGD()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007CB6 RID: 31926 RVA: 0x003C4F47 File Offset: 0x003C3147
	private IEnumerator MBOMNCJMFIC()
	{
		if (this.BCMFANJFGKE.clip != null)
		{
			this.LHHBOOJPBPH = true;
			time = Time.time;
			yield return new WaitForSeconds(1f);
			num = this.BCMFANJFGKE.clip.length - 3f;
			Debug.Log(string.Concat(new object[]
			{
				"******** nextMusicCrt lng=",
				num,
				" path=",
				this.path
			}));
			while (Time.time - time < num)
			{
				num = this.BCMFANJFGKE.clip.length - 3f;
				this.clipLenght = num;
				yield return new WaitForSeconds(1f);
			}
			Debug.Log("******** nextMusicCrt End of music path=" + this.path);
			if (!this.isMute)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPCIKCGADDD();
			}
		}
		yield break;
	}

	// Token: 0x06007CB7 RID: 31927 RVA: 0x003C5BE4 File Offset: 0x003C3DE4
	private void Update()
	{
		if (this.isMute)
		{
			this.volume -= 0.1f * Time.deltaTime;
			if (this.volume <= 0f)
			{
				this.volume = 0f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 0.1f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Loaded)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GLHBBJHBNOK());
				}
			}
		}
	}

	// Token: 0x06007CB8 RID: 31928 RVA: 0x003C5D18 File Offset: 0x003C3F18
	private void HNMODJBBKBI()
	{
		if (this.isMute)
		{
			this.volume -= 1105f * Time.deltaTime;
			if (this.volume <= 251f)
			{
				this.volume = 1296f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 748f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Unloaded)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.NPIDFADGHIM());
				}
			}
		}
	}

	// Token: 0x06007CB9 RID: 31929 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator FBDKAJDLANJ()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CBA RID: 31930 RVA: 0x003C5E4C File Offset: 0x003C404C
	public void NKNHEDJFONP(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "_w" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1477f;
		base.StartCoroutine(this.IHHPHJEOFMA());
	}

	// Token: 0x06007CBB RID: 31931 RVA: 0x003C5ECC File Offset: 0x003C40CC
	private void IDMCOLDDNCF()
	{
		if (this.isMute)
		{
			this.volume -= 286f * Time.deltaTime;
			if (this.volume <= 325f)
			{
				this.volume = 1310f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1429f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)7)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.CKMGBJHFLGD());
				}
			}
		}
	}

	// Token: 0x06007CBC RID: 31932 RVA: 0x003C4F36 File Offset: 0x003C3136
	public void PALMAMLNIAD(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.CMGCAGCJNGN(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CBD RID: 31933 RVA: 0x003C6000 File Offset: 0x003C4200
	public void IIILBCFDLJM(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "Flap_02.wav" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1130f;
		base.StartCoroutine(this.KIFHPBHFMLO());
	}

	// Token: 0x06007CBE RID: 31934 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void FDAABBCGGJJ()
	{
		this.isMute = false;
	}

	// Token: 0x06007CBF RID: 31935 RVA: 0x003C6080 File Offset: 0x003C4280
	public void StreamPlay(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "Music: " + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 0f;
		base.StartCoroutine(this.GGCEBLDONPM());
	}

	// Token: 0x06007CC0 RID: 31936 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void BCIDKPNFHGD(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CC1 RID: 31937 RVA: 0x003C6100 File Offset: 0x003C4300
	public void MCACOAENBBJ(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "\\StreamingAssets\\Quest\\Lang\\" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 673f;
		base.StartCoroutine(this.GGJCAKJLOII());
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x003C617E File Offset: 0x003C437E
	public void PJIBOIGKLHL(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.EFDOIDIIHKO(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator LNHJFKEHLKA(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x003C4F47 File Offset: 0x003C3147
	private IEnumerator EBFBJCPJFBD()
	{
		if (this.BCMFANJFGKE.clip != null)
		{
			this.LHHBOOJPBPH = true;
			time = Time.time;
			yield return new WaitForSeconds(1f);
			num = this.BCMFANJFGKE.clip.length - 3f;
			Debug.Log(string.Concat(new object[]
			{
				"******** nextMusicCrt lng=",
				num,
				" path=",
				this.path
			}));
			while (Time.time - time < num)
			{
				num = this.BCMFANJFGKE.clip.length - 3f;
				this.clipLenght = num;
				yield return new WaitForSeconds(1f);
			}
			Debug.Log("******** nextMusicCrt End of music path=" + this.path);
			if (!this.isMute)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPCIKCGADDD();
			}
		}
		yield break;
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x003C6190 File Offset: 0x003C4390
	private void HMLNMHOMMNO()
	{
		if (this.isMute)
		{
			this.volume -= 600f * Time.deltaTime;
			if (this.volume <= 871f)
			{
				this.volume = 1268f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 19f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)7)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.GABIEMOPDNM());
				}
			}
		}
	}

	// Token: 0x06007CC6 RID: 31942 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator NAKBCLEBABF()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x003C456D File Offset: 0x003C276D
	public void HLKCIOGHIPC(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.EDAGJGIDEIG(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x003C62C4 File Offset: 0x003C44C4
	public void DLOPKNAOHFN(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "<color='#{0}'>{2} {1} </color>\n" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1081f;
		base.StartCoroutine(this.POFEOIBIJPF());
	}

	// Token: 0x06007CC9 RID: 31945 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void AJNJIAPMOLD()
	{
		this.isMute = false;
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void IJEKNMFJPJE()
	{
		this.isMute = true;
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x003C6344 File Offset: 0x003C4544
	private void KMPEBHIPKJH()
	{
		if (this.isMute)
		{
			this.volume -= 338f * Time.deltaTime;
			if (this.volume <= 1959f)
			{
				this.volume = 1475f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1963f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)8)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.EBFBJCPJFBD());
				}
			}
		}
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void IIEMINICHOM(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CCD RID: 31949 RVA: 0x003C6478 File Offset: 0x003C4678
	public void OOBAFPPCKKE(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "SneakIdle" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1482f;
		base.StartCoroutine(this.FHDOGNBMCDG());
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void AHGJALGEICM()
	{
		this.isMute = false;
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x003C64F8 File Offset: 0x003C46F8
	private void NMMGHFDLNOE()
	{
		if (this.isMute)
		{
			this.volume -= 1280f * Time.deltaTime;
			if (this.volume <= 1160f)
			{
				this.volume = 846f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1994f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)7)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.FMICPDOCAGH());
				}
			}
		}
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void PKFLKLDMLGJ()
	{
		this.isMute = false;
	}

	// Token: 0x06007CD1 RID: 31953 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator AHOCKAGIGMG(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007CD2 RID: 31954 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator APLJGOIEFOD()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CD3 RID: 31955 RVA: 0x003C4F36 File Offset: 0x003C3136
	public void BMLAFMKIELF(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.CMGCAGCJNGN(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CD4 RID: 31956 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator JKGGAOGJFGE()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CD5 RID: 31957 RVA: 0x003C4B8A File Offset: 0x003C2D8A
	public void HAEFPNAAFLL(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.OLNBCNOJGPE(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CD6 RID: 31958 RVA: 0x003C4F47 File Offset: 0x003C3147
	private IEnumerator DMJPJEMJBNM()
	{
		if (this.BCMFANJFGKE.clip != null)
		{
			this.LHHBOOJPBPH = true;
			time = Time.time;
			yield return new WaitForSeconds(1f);
			num = this.BCMFANJFGKE.clip.length - 3f;
			Debug.Log(string.Concat(new object[]
			{
				"******** nextMusicCrt lng=",
				num,
				" path=",
				this.path
			}));
			while (Time.time - time < num)
			{
				num = this.BCMFANJFGKE.clip.length - 3f;
				this.clipLenght = num;
				yield return new WaitForSeconds(1f);
			}
			Debug.Log("******** nextMusicCrt End of music path=" + this.path);
			if (!this.isMute)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPCIKCGADDD();
			}
		}
		yield break;
	}

	// Token: 0x06007CD7 RID: 31959 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void CLGGLMMICHE()
	{
		this.isMute = false;
	}

	// Token: 0x06007CD8 RID: 31960 RVA: 0x003C662C File Offset: 0x003C482C
	public void MFLPEIKNAPF(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "ChannelCastOmni" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1376f;
		base.StartCoroutine(this.PIDOHFJCLBC());
	}

	// Token: 0x06007CD9 RID: 31961 RVA: 0x003C66AC File Offset: 0x003C48AC
	private void HAIMGCDKPDC()
	{
		if (this.isMute)
		{
			this.volume -= 353f * Time.deltaTime;
			if (this.volume <= 1826f)
			{
				this.volume = 1039f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 174f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Loading)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.NPIDFADGHIM());
				}
			}
		}
	}

	// Token: 0x06007CDA RID: 31962 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void CPFADIIGDLP()
	{
		this.isMute = true;
	}

	// Token: 0x06007CDB RID: 31963 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator AHCNKHBLFGI()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007CDC RID: 31964 RVA: 0x003C67E0 File Offset: 0x003C49E0
	public void ICHOILJCBAF(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "wpn_rec3" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1465f;
		base.StartCoroutine(this.IHHPHJEOFMA());
	}

	// Token: 0x06007CDD RID: 31965 RVA: 0x003C4B8A File Offset: 0x003C2D8A
	public void BMGGPFBJNIN(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.OLNBCNOJGPE(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CDE RID: 31966 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void JJHGODEKOAI()
	{
		this.isMute = false;
	}

	// Token: 0x06007CDF RID: 31967 RVA: 0x003C685E File Offset: 0x003C4A5E
	public void JDOBKMEPCKF(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.KBDPLLPGLFO(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CE0 RID: 31968 RVA: 0x003C5B7E File Offset: 0x003C3D7E
	public void LoadAndPlay(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.AHOCKAGIGMG(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CE1 RID: 31969 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator DLMHIEGJOGL()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CE2 RID: 31970 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator BEALIFDMOHD()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CE3 RID: 31971 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void CIGFDALEFAH()
	{
		this.isMute = true;
	}

	// Token: 0x06007CE4 RID: 31972 RVA: 0x003C6870 File Offset: 0x003C4A70
	private void PJOKLGLNDHD()
	{
		if (this.isMute)
		{
			this.volume -= 1879f * Time.deltaTime;
			if (this.volume <= 1773f)
			{
				this.volume = 1863f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1692f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)5)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.EJEMBKIPPCA());
				}
			}
		}
	}

	// Token: 0x06007CE5 RID: 31973 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void DKBNFCHNKFB()
	{
		this.isMute = false;
	}

	// Token: 0x06007CE6 RID: 31974 RVA: 0x003C69A4 File Offset: 0x003C4BA4
	public void FGBPFIKJPDJ(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "?" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1762f;
		base.StartCoroutine(this.MJMLGODMMOF());
	}

	// Token: 0x06007CE7 RID: 31975 RVA: 0x003C455E File Offset: 0x003C275E
	private IEnumerator KIFHPBHFMLO()
	{
		this.DHFNKDOCOFK = new WWW(this.path);
		yield return this.DHFNKDOCOFK;
		this.BCMFANJFGKE.clip = this.DHFNKDOCOFK.GetAudioClip(false, true);
		this.IGIMNIABPMN = true;
		yield break;
	}

	// Token: 0x06007CE8 RID: 31976 RVA: 0x003C6A24 File Offset: 0x003C4C24
	private void DAFJMNMFOON()
	{
		if (this.isMute)
		{
			this.volume -= 1911f * Time.deltaTime;
			if (this.volume <= 1613f)
			{
				this.volume = 663f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1269f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)4)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.DMJPJEMJBNM());
				}
			}
		}
	}

	// Token: 0x06007CE9 RID: 31977 RVA: 0x003C6B58 File Offset: 0x003C4D58
	public void ENIBOHAOKNF(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "shop_bccost" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = false;
		this.BCMFANJFGKE.volume = 1136f;
		base.StartCoroutine(this.POFEOIBIJPF());
	}

	// Token: 0x06007CEA RID: 31978 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void GINJDHNJFLF()
	{
		this.isMute = false;
	}

	// Token: 0x06007CEB RID: 31979 RVA: 0x003C4928 File Offset: 0x003C2B28
	public void PBECDEPEJEE(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.JKPHCHBHCCJ(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CEC RID: 31980 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator FHDOGNBMCDG()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CED RID: 31981 RVA: 0x003C457E File Offset: 0x003C277E
	private IEnumerator ICDJNKCHEHI(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		GOSample2D.IBGOEKFODJK ibgoekfodjk = new GOSample2D.IBGOEKFODJK(1);
		ibgoekfodjk.AENJLLPLILM = this;
		ibgoekfodjk.ALBOCLBFNNI = ALBOCLBFNNI;
		ibgoekfodjk.NJCNBLKBDKO = NJCNBLKBDKO;
		return ibgoekfodjk;
	}

	// Token: 0x06007CEE RID: 31982 RVA: 0x003C52BE File Offset: 0x003C34BE
	public void BGFDPADLPMH()
	{
		this.isMute = false;
	}

	// Token: 0x06007CEF RID: 31983 RVA: 0x003C6BD8 File Offset: 0x003C4DD8
	public void FEHIEIEMPIG(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "How your lives count is stored in memory when obscured:\n" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 778f;
		base.StartCoroutine(this.GACACOAPFFA());
	}

	// Token: 0x06007CF0 RID: 31984 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void OCMGAICFCOD()
	{
		this.isMute = true;
	}

	// Token: 0x06007CF1 RID: 31985 RVA: 0x003C6C58 File Offset: 0x003C4E58
	private void JFGGBEGNAFP()
	{
		if (this.isMute)
		{
			this.volume -= 789f * Time.deltaTime;
			if (this.volume <= 183f)
			{
				this.volume = 29f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1475f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)6)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.AHCNKHBLFGI());
				}
			}
		}
	}

	// Token: 0x06007CF2 RID: 31986 RVA: 0x003C6D8C File Offset: 0x003C4F8C
	public void HNHFJFNGOMG(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "_Offsets" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = true;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 798f;
		base.StartCoroutine(this.FBDKAJDLANJ());
	}

	// Token: 0x06007CF3 RID: 31987 RVA: 0x003C6E0C File Offset: 0x003C500C
	private void BOAJJAKEMLH()
	{
		if (this.isMute)
		{
			this.volume -= 1589f * Time.deltaTime;
			if (this.volume <= 863f)
			{
				this.volume = 638f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1261f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)8)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.EBFBJCPJFBD());
				}
			}
		}
	}

	// Token: 0x06007CF4 RID: 31988 RVA: 0x003C6F40 File Offset: 0x003C5140
	private void FJEEADNCKAG()
	{
		if (this.isMute)
		{
			this.volume -= 1921f * Time.deltaTime;
			if (this.volume <= 1320f)
			{
				this.volume = 1541f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1236f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == AudioDataLoadState.Failed)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.DMJPJEMJBNM());
				}
			}
		}
	}

	// Token: 0x06007CF5 RID: 31989 RVA: 0x003C7074 File Offset: 0x003C5274
	public void IMEKONLBJFD(string ALBOCLBFNNI, bool NMFPOEHHFOI = true, bool GEJACGFDHGD = false)
	{
		this.path = ALBOCLBFNNI;
		base.name = "OfficeSittingEyesRub" + ALBOCLBFNNI;
		this.BCMFANJFGKE = base.GetComponent<AudioSource>();
		this.BCMFANJFGKE.mute = false;
		this.BCMFANJFGKE.clip = null;
		this.BCMFANJFGKE.loop = NMFPOEHHFOI;
		this.BCMFANJFGKE.playOnAwake = true;
		this.BCMFANJFGKE.volume = 1953f;
		base.StartCoroutine(this.FFBINIEFNGF());
	}

	// Token: 0x06007CF6 RID: 31990 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator JIPCMCAAELG()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CF7 RID: 31991 RVA: 0x003C4A6E File Offset: 0x003C2C6E
	private IEnumerator GEOLEHGCHJM(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		this.DHFNKDOCOFK = new WWW(ALBOCLBFNNI);
		yield return this.DHFNKDOCOFK;
		AudioClip audioClip = this.DHFNKDOCOFK.GetAudioClip(NJCNBLKBDKO);
		if (this.DHFNKDOCOFK.isDone)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IJCHKHKJCNO(ALBOCLBFNNI, audioClip);
			bool flag = this.isPitchRnd;
			base.GetComponent<AudioSource>().clip = audioClip;
			base.GetComponent<AudioSource>().Play();
			UnityEngine.Object.Destroy(base.gameObject, audioClip.length + 0.2f);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.DHFNKDOCOFK.Dispose();
		yield break;
	}

	// Token: 0x06007CF8 RID: 31992 RVA: 0x003C459B File Offset: 0x003C279B
	private IEnumerator JDGMIAOLHEF()
	{
		GOSample2D.GNNCLLOGCNI gnncllogcni = new GOSample2D.GNNCLLOGCNI(1);
		gnncllogcni.AENJLLPLILM = this;
		return gnncllogcni;
	}

	// Token: 0x06007CF9 RID: 31993 RVA: 0x003C457E File Offset: 0x003C277E
	private IEnumerator MNNMPGMPEJM(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		GOSample2D.IBGOEKFODJK ibgoekfodjk = new GOSample2D.IBGOEKFODJK(1);
		ibgoekfodjk.AENJLLPLILM = this;
		ibgoekfodjk.ALBOCLBFNNI = ALBOCLBFNNI;
		ibgoekfodjk.NJCNBLKBDKO = NJCNBLKBDKO;
		return ibgoekfodjk;
	}

	// Token: 0x06007CFA RID: 31994 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator MJMLGODMMOF()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CFB RID: 31995 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator PACJKEAIBHK()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x06007CFC RID: 31996 RVA: 0x003C70F4 File Offset: 0x003C52F4
	private void AAEFACEGJMB()
	{
		if (this.isMute)
		{
			this.volume -= 1358f * Time.deltaTime;
			if (this.volume <= 902f)
			{
				this.volume = 870f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 1013f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)8)
			{
				this.BCMFANJFGKE.mute = true;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.JHEIIKKEHCE());
				}
			}
		}
	}

	// Token: 0x06007CFD RID: 31997 RVA: 0x003C48EE File Offset: 0x003C2AEE
	public void CLAMMDFHMOI()
	{
		this.isMute = true;
	}

	// Token: 0x06007CFE RID: 31998 RVA: 0x003C4F36 File Offset: 0x003C3136
	public void ANGIBIPFDAO(string ALBOCLBFNNI, bool NJCNBLKBDKO)
	{
		base.StartCoroutine(this.CMGCAGCJNGN(ALBOCLBFNNI, NJCNBLKBDKO));
	}

	// Token: 0x06007CFF RID: 31999 RVA: 0x003C7228 File Offset: 0x003C5428
	private void OKMAHGAAMHA()
	{
		if (this.isMute)
		{
			this.volume -= 243f * Time.deltaTime;
			if (this.volume <= 51f)
			{
				this.volume = 818f;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if (this.tovolume > this.volume)
		{
			this.volume += 871f * Time.deltaTime;
			if (this.volume > this.tovolume)
			{
				this.volume = this.tovolume;
			}
		}
		if (this.IGIMNIABPMN && this.BCMFANJFGKE != null)
		{
			this.BCMFANJFGKE.volume = this.volume;
			if (!this.isMute && !this.BCMFANJFGKE.isPlaying && this.BCMFANJFGKE.clip && this.BCMFANJFGKE.clip.loadState == (AudioDataLoadState)6)
			{
				this.BCMFANJFGKE.mute = false;
				this.BCMFANJFGKE.Play();
				if (!this.LHHBOOJPBPH && !this.BCMFANJFGKE.loop)
				{
					base.StartCoroutine(this.CKMGBJHFLGD());
				}
			}
		}
	}

	// Token: 0x06007D00 RID: 32000 RVA: 0x003C48F7 File Offset: 0x003C2AF7
	private IEnumerator OCNFAPPBFMF()
	{
		GOSample2D.GNGPBBFIMDM gngpbbfimdm = new GOSample2D.GNGPBBFIMDM(1);
		gngpbbfimdm.AENJLLPLILM = this;
		return gngpbbfimdm;
	}

	// Token: 0x0400121B RID: 4635
	private WWW DHFNKDOCOFK;

	// Token: 0x0400121C RID: 4636
	public float clipLenght;

	// Token: 0x0400121D RID: 4637
	public bool isPitchRnd = true;

	// Token: 0x0400121E RID: 4638
	public bool isMute;

	// Token: 0x0400121F RID: 4639
	private const float KCKCPJEOKBL = 0.1f;

	// Token: 0x04001220 RID: 4640
	public float volume = 1f;

	// Token: 0x04001221 RID: 4641
	public float tovolume = 1f;

	// Token: 0x04001222 RID: 4642
	public Vector3 position;

	// Token: 0x04001223 RID: 4643
	public float minDist = 5f;

	// Token: 0x04001224 RID: 4644
	public float maxDist = 50f;

	// Token: 0x04001225 RID: 4645
	public string path = "";

	// Token: 0x04001226 RID: 4646
	private bool IGIMNIABPMN;

	// Token: 0x04001227 RID: 4647
	private AudioSource BCMFANJFGKE;

	// Token: 0x04001228 RID: 4648
	private bool LHHBOOJPBPH;
}
