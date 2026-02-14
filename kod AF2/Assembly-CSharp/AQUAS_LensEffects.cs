using System;
using System.Reflection;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000008 RID: 8
public class AQUAS_LensEffects : MonoBehaviour
{
	// Token: 0x0600015D RID: 349 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void PCLOLHKCCHI(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
	private void BLNFPDMDJOA()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("");
		}
		this.PKEELDDHFIG.SetTexture("BuY", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("<b>ObscuredInt:</b> ", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000FE40 File Offset: 0x0000E040
	private void PNAAHEFHPCL()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1890f;
		this.KKDDOIIDBEL = 316f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("IceHockeySlapShot");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("DepthTolerance");
		if (this.HFODKHJLFIE.HasProperty("wpn_wgt"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat(" on effect ");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[0];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("ui_place_flag.wav") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("MotorbikeShootRight");
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000101A4 File Offset: 0x0000E3A4
	private void FFIGGPHAIBP()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1523f;
		this.KKDDOIIDBEL = 1347f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("[fish]");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("FlyLeft");
		if (this.HFODKHJLFIE.HasProperty("MotorbikeIdle"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("Idle 180");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[4];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("Use!") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("_ZTest");
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00010508 File Offset: 0x0000E708
	private void EMFOECIPBIP()
	{
		this.CLGENJGGCDE();
		if (this.CKIBKGLIMAB())
		{
			this.t = 792f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(true);
			this.IDCKGKNECAN = 1;
			this.rundown = false;
			this.LIGGDAFGCKK();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = true;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("MotorbikeShootRight", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("  locid=", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("_AddCountitem.wav", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("Vector3: ", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("Bait VELO=", 1075f);
			this.HFODKHJLFIE.SetFloat("crft_cnt2", 298f);
			this.HFODKHJLFIE.SetFloat("fishStamKF=", this.BNGEOBGCMLA * 1490f);
			this.HFODKHJLFIE.SetFloat("GestureWonderful", 1450f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = false;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = false;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = false;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = true;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("RollerBladeBackFlip");
				FieldInfo field = component.GetType().GetField("1.6.2", ~(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public));
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = true;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 681f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 0;
			this.HGGDLBIMAAI();
			base.InvokeRepeating("Game saved using ObscuredPrefs. Try to find and change saved data now! ;)", 577f / this.wetLens.rundownSpeed, 1947f / this.wetLens.rundownSpeed);
			this.rundown = false;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 621f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = false;
		}
		this.DMDJCPDHFHO = true;
		this.DEECOLECDPD = false;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = false;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("isFishGet", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("actor instaniateRod ", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("WireframeFore", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("Cloth_05_00.wav", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 1139f;
			this.PKEELDDHFIG.SetFloat("MovementZ", 941f);
			this.PKEELDDHFIG.SetFloat("/Sound/Music/MusicList.xml", 1347f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(472f, 1861f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("chnam4", Mathf.Lerp(651f, 1423f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("{0} / {1}", Mathf.Lerp(1289f, 941f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("Grounded", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("ALP=", 1528f);
		this.HFODKHJLFIE.SetFloat("isRodOpen", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("readTurnir STATUS", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("</color>\n");
			FieldInfo field2 = component2.GetType().GetField("FlyForward", BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00010D00 File Offset: 0x0000EF00
	private void JLFBDOPFDDJ()
	{
		this.CLGENJGGCDE();
		if (this.MECHGBFIKAL())
		{
			this.t = 714f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(true);
			this.IDCKGKNECAN = 1;
			this.rundown = true;
			this.MHKPGEEPDIH();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = false;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = true;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("SneakLeft", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("MotorbikeBackwardStand", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale(">", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("Attempting to RefreshSceneDecals without a packed material", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("crft_crft", 678f);
			this.HFODKHJLFIE.SetFloat("Thumb", 896f);
			this.HFODKHJLFIE.SetFloat("UNIQUE_SHADOW_LIGHT_COOKIE", this.BNGEOBGCMLA * 1409f);
			this.HFODKHJLFIE.SetFloat("", 1625f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = false;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = false;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = true;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("CheerJump");
				FieldInfo field = component.GetType().GetField("_Parameter", BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic);
				if (field != null)
				{
					field.SetValue(component, true);
				}
			}
			RenderSettings.fog = false;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 1364f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 1;
			this.AFLDOLFBJPJ();
			base.InvokeRepeating("cht_msg1", 834f / this.wetLens.rundownSpeed, 193f / this.wetLens.rundownSpeed);
			this.rundown = true;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 697f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = true;
		}
		this.DMDJCPDHFHO = false;
		this.DEECOLECDPD = false;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = true;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("invn_rec20", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("MotorbikeSeatStandWheely", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("gi_um_4", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("\n", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 1827f;
			this.PKEELDDHFIG.SetFloat("Sunshine Lightmap", 741f);
			this.PKEELDDHFIG.SetFloat("act_orderb_", 1320f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(267f, 232f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("id", Mathf.Lerp(1633f, 115f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("IdleStandingJump", Mathf.Lerp(1893f, 73f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("_Jitter", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("Hidden/Post FX/Bloom", 713f);
		this.HFODKHJLFIE.SetFloat(")", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("_EmissionColor", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("ClimbRight");
			FieldInfo field2 = component2.GetType().GetField(" ", ~(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy));
			if (field2 != null)
			{
				field2.SetValue(component2, false);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000114F8 File Offset: 0x0000F6F8
	private void Start()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 0f;
		this.KKDDOIIDBEL = 0f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("_FoamContrast");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("_Specular");
		if (this.HFODKHJLFIE.HasProperty("_Refraction"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("_Refraction");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[2];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("Tenkoku DynamicSky") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("Tenkoku DynamicSky");
		}
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0001185C File Offset: 0x0000FA5C
	private void NLKJPCLLBBE()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.MJIKAPDOCIK() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 192f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 677f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 855f))
			{
				this.HAEBHLDGKPG(true);
				return;
			}
			if (this.CONJLGOCEBP() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.EFGBEPGPCFP(true);
				return;
			}
			if (!this.MECHGBFIKAL())
			{
				this.AKIOBHFDICN(this.BPCBOEMLGGK(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.MECHGBFIKAL() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.ACEHGLCDAEM() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.PCLOLHKCCHI(false);
				return;
			}
			if (this.CONJLGOCEBP() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.FGKHNHDGHPK(false);
				return;
			}
			if (!this.PGOACMBPEPO())
			{
				this.HAEBHLDGKPG(this.BPCBOEMLGGK(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600018C RID: 396 RVA: 0x00013EDB File Offset: 0x000120DB
	// (set) Token: 0x06000165 RID: 357 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	public bool ONOHFCLMEMI { get; private set; }

	// Token: 0x06000166 RID: 358 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void AKIOBHFDICN(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00011B0C File Offset: 0x0000FD0C
	private void JEDNCCDAGJN()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(517f, this.bubbleSpawnCriteria.avgScaleSummand * 1578f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1263f, this.bubbleSpawnCriteria.averageUpdrift * 1794f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1814f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG += 0;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1325f, this.bubbleSpawnCriteria.avgScaleSummand * 151f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 45f, this.bubbleSpawnCriteria.averageUpdrift * 1457f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 859f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00011EDC File Offset: 0x000100DC
	private void KCCFIDOEJND()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 1;
			base.CancelInvoke("wpn_add/addoptions");
		}
		this.PKEELDDHFIG.SetTexture("toFishPoint", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("wpn_bait_vob_1", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00011F64 File Offset: 0x00010164
	private void IINEKJOJKML()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("cnt_energ");
		}
		this.PKEELDDHFIG.SetTexture("fchair", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("1 Hand Small Weapon Combo", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN += 0;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00011FEC File Offset: 0x000101EC
	private void LDDIGEMBDNF()
	{
		this.NNKLIBGIIGD();
		if (this.CONJLGOCEBP())
		{
			this.t = 1600f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(true);
			this.IDCKGKNECAN = 1;
			this.rundown = false;
			this.MHKPGEEPDIH();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = false;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("sunshine_ShadowFadeParams", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("_Axis", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("IceHockeyDekeMiddle", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("_Offsets", 1178f);
			this.HFODKHJLFIE.SetFloat("\n", 1728f);
			this.HFODKHJLFIE.SetFloat("Giant2HandSlamSwing", this.BNGEOBGCMLA * 1306f);
			this.HFODKHJLFIE.SetFloat("BEREG!", 204f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = true;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = true;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = false;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("CrawlLocomotion");
				FieldInfo field = component.GetType().GetField("RotationLimitPolygonal reach cones are invalid.", BindingFlags.Public | BindingFlags.NonPublic);
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = false;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 1461f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 0;
			this.BLNFPDMDJOA();
			base.InvokeRepeating("", 1998f / this.wetLens.rundownSpeed, 1f / this.wetLens.rundownSpeed);
			this.rundown = true;
		}
		this.LOLDCEPCLNG = 1;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 191f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = true;
		}
		this.DMDJCPDHFHO = false;
		this.DEECOLECDPD = true;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = false;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("1HSwordStrafeRunLeft", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("ObscuredDouble vs double, ", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("Z (B)", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("_HitPosition", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 166f;
			this.PKEELDDHFIG.SetFloat("IdleFly", 1866f);
			this.PKEELDDHFIG.SetFloat("", 635f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(274f, 655f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat(" ms", Mathf.Lerp(484f, 187f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("", Mathf.Lerp(1073f, 7f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("_TrEndWin.ogg", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("SkateboardKickPush", 268f);
		this.HFODKHJLFIE.SetFloat("Assembly-CSharp-firstpass", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("_FrustumCornersWS", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("auc_wcswcp");
			FieldInfo field2 = component2.GetType().GetField("button.wav", ~(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000127E4 File Offset: 0x000109E4
	private bool BPCBOEMLGGK(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 1; i < NNJEFMKOGLJ; i += 0)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 254f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 828f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 1476f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("noDress") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("id").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find(" ") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_Vignette_Center").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("**MMOItem").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_camIntensive") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("sys").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("#004000").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_Grain_Params1") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find(" ").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00012CD4 File Offset: 0x00010ED4
	private bool EMMDHJOAGGL(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 340f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 498f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 754f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("WizardPowerUp") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("</color>").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_OcclusionTexture2").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("crft_useres") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_Offsets").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_SceneFogMode").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return false;
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < NNJEFMKOGLJ; j += 0)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Loser") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_RgbTex").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Original position: ").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Assets/Hairs/hair_") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("StaffHeal").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_RangeScale").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000131C4 File Offset: 0x000113C4
	private void AFLDOLFBJPJ()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("paper.wav");
		}
		this.PKEELDDHFIG.SetTexture("X", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("cht_msg29", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0001324C File Offset: 0x0001144C
	private void EPBBCAAKFOF()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(1307f, this.bubbleSpawnCriteria.avgScaleSummand * 676f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 146f, this.bubbleSpawnCriteria.averageUpdrift * 1391f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 686f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG++;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1037f, this.bubbleSpawnCriteria.avgScaleSummand * 1729f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 180f, this.bubbleSpawnCriteria.averageUpdrift * 1357f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1018f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0001361C File Offset: 0x0001181C
	private void BGJDHFMBDDJ()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(126f, this.bubbleSpawnCriteria.avgScaleSummand * 1692f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1901f, this.bubbleSpawnCriteria.averageUpdrift * 1017f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 781f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG += 0;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1641f, this.bubbleSpawnCriteria.avgScaleSummand * 372f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1868f, this.bubbleSpawnCriteria.averageUpdrift * 404f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1511f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x000139EC File Offset: 0x00011BEC
	private bool NLHEJDJIGFM(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 1; i < NNJEFMKOGLJ; i += 0)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 1967f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1108f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 1327f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ANGLE=") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("IceHockeyGoalieSave2").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find(" ms").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ArmFlex5").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("WizardEyeBeam").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("1HandSwordStrafeRight") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_PixelsPerMeterAtOneMeter").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("RollerBladeRoll").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find(")") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("MotorbikeBackwardSitting").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool MJIKAPDOCIK()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00013EE4 File Offset: 0x000120E4
	private bool ECPLABIJIOF(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 2f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 2f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 2f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PrimaryCausticsProjector").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SecondaryCausticsProjector").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x000143D4 File Offset: 0x000125D4
	private void DGGMJCMLLED()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 601f;
		this.KKDDOIIDBEL = 10f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("name");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("Far");
		if (this.HFODKHJLFIE.HasProperty("RollerBladeRoll"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("wpn_add/base");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[0];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("wpn_onlyw") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("ObscuredVector3:");
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00014738 File Offset: 0x00012938
	private void PLBDELOIINH()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1333f;
		this.KKDDOIIDBEL = 1188f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("wpn_bait1");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("");
		if (this.HFODKHJLFIE.HasProperty(" iterations for read and write"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off, C to toggle fog cutting, R to reset fog.");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[3];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("RendererD2 is init") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("buyVIP OK");
		}
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00014A9C File Offset: 0x00012C9C
	private void BIAEHGBDKKL()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 1;
			base.CancelInvoke("/");
		}
		this.PKEELDDHFIG.SetTexture("_DepthFade", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("inv_auklotinf", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00014B24 File Offset: 0x00012D24
	private void NPNMAMLKJDO()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.CKALEEAIKGH() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 492f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 921f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 278f))
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (this.ELOBBDHBJOK() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.KJHGKHCFNGI(false);
				return;
			}
			if (!this.CONJLGOCEBP())
			{
				this.HAEBHLDGKPG(this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.ACEHGLCDAEM() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.MECHGBFIKAL() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.ABGCFIADJEJ(true);
				return;
			}
			if (this.ACEHGLCDAEM() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (!this.CKALEEAIKGH())
			{
				this.ABGCFIADJEJ(this.PALEFJGNCOK(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00014E34 File Offset: 0x00013034
	private void MHKPGEEPDIH()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(138f, this.bubbleSpawnCriteria.avgScaleSummand * 1271f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1699f, this.bubbleSpawnCriteria.averageUpdrift * 1597f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1362f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG++;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(516f, this.bubbleSpawnCriteria.avgScaleSummand * 1771f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 116f, this.bubbleSpawnCriteria.averageUpdrift * 1603f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 69f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00015204 File Offset: 0x00013404
	private void HGNAFKOGBAC()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("HGNAFKOGBAC");
		}
		this.PKEELDDHFIG.SetTexture("_CutoutReferenceTexture", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("_Normal", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0001528C File Offset: 0x0001348C
	private void FPLHODJCJDO()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 935f;
		this.KKDDOIIDBEL = 1879f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("PistolLeftHandStab");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("WizardOverhead");
		if (this.HFODKHJLFIE.HasProperty("FistPump2"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("wdeep");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[0];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("invn_ver3") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("Gesture Crowd Pump");
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool CKALEEAIKGH()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x000155F0 File Offset: 0x000137F0
	private void AOMANOCJEID()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("RollerBladeFrontFlip");
		}
		this.PKEELDDHFIG.SetTexture("position", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("{0}{1}{2}{3}", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN += 0;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00015678 File Offset: 0x00013878
	private void LHHKDNILMDI()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1599f;
		this.KKDDOIIDBEL = 398f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("' that does not excist in the Node Chain.");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("1HandHeavySwing");
		if (this.HFODKHJLFIE.HasProperty("Seat Stand"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("Kernel");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[8];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("big_count") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("R");
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000159DC File Offset: 0x00013BDC
	private void HHGGCBLOJGB()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 396f;
		this.KKDDOIIDBEL = 152f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("MovementX");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("IdleKeepBack");
		if (this.HFODKHJLFIE.HasProperty("The InteractionTrigger in the list 'inContact' has been destroyed"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("RollerBladeCrossoverLeft");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[2];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("Move around with WASD or cursor keys, space to jump") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("**MMOItem");
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00015D40 File Offset: 0x00013F40
	private bool OILJFOEIDFF(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 1; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 830f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1326f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 1072f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("exitmsg_3") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("<color='#202020'>").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("USE_CORNER_DETECTION").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("calf") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("upRodState").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_UserLutParams").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return false;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("USE_DIAG_SEARCH") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("MotorbikeLassoRight").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("#FF4040").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ElvisLegsLoop") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("invn_ver5").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("HookPoint").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00016230 File Offset: 0x00014430
	private void BFMBPJIALOK()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("OAJPPMALFDF");
		}
		this.PKEELDDHFIG.SetTexture("FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("Card Player Idle", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN += 0;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000162B8 File Offset: 0x000144B8
	private void CLGENJGGCDE()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.ONOHFCLMEMI && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 2f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 2f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 2f))
			{
				this.ONOHFCLMEMI = false;
				return;
			}
			if (this.ONOHFCLMEMI && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.ONOHFCLMEMI = false;
				return;
			}
			if (!this.ONOHFCLMEMI)
			{
				this.ONOHFCLMEMI = this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count);
				return;
			}
		}
		else
		{
			if ((this.ONOHFCLMEMI && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.ONOHFCLMEMI && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.ONOHFCLMEMI = false;
				return;
			}
			if (this.ONOHFCLMEMI && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.ONOHFCLMEMI = false;
				return;
			}
			if (!this.ONOHFCLMEMI)
			{
				this.ONOHFCLMEMI = this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count);
			}
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00016568 File Offset: 0x00014768
	private bool HDCDNAMNGLJ(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i += 0)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 1907f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 231f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 1398f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("default") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("frnd_ingame").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("RunBackLeft").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("|").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("fwgt_trof_m").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("GiantGrabIdle2") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("category").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("</color>").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Body") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("1HandSmallWeaponCombo").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00016A58 File Offset: 0x00014C58
	private void KFGKKLAKFGH()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 946f;
		this.KKDDOIIDBEL = 1020f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("a");
		if (this.HFODKHJLFIE.HasProperty("Apply 7"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat(", ");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[6];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("_HeightParams") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("Bases/Base_1.unity3d");
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool ELOBBDHBJOK()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00016DBC File Offset: 0x00014FBC
	private void DHILBLNMABD()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.CKALEEAIKGH() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 1873f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 1417f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 875f))
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (this.CONJLGOCEBP() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (!this.ELOBBDHBJOK())
			{
				this.KJHGKHCFNGI(this.AHCMDJGMLIB(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.MECHGBFIKAL() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.ELOBBDHBJOK() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.EFGBEPGPCFP(false);
				return;
			}
			if (this.ACEHGLCDAEM() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.ABGCFIADJEJ(false);
				return;
			}
			if (!this.ONOHFCLMEMI)
			{
				this.ABGCFIADJEJ(this.EPOANFICIIK(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0001706C File Offset: 0x0001526C
	private void OMMELPNIGIO()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(0f, this.bubbleSpawnCriteria.avgScaleSummand * 2f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 0.75f, this.bubbleSpawnCriteria.averageUpdrift * 0.75f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 0.4f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG++;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(0f, this.bubbleSpawnCriteria.avgScaleSummand * 2f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 0.75f, this.bubbleSpawnCriteria.averageUpdrift * 0.75f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 0.4f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0001743C File Offset: 0x0001563C
	private void Update()
	{
		this.CLGENJGGCDE();
		if (this.ONOHFCLMEMI)
		{
			this.t = 0f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(true);
			this.IDCKGKNECAN = 0;
			this.rundown = true;
			this.OMMELPNIGIO();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = false;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = false;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = false;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("_Texture", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("_Intensity", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("_Texture", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("_Intensity", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("_UnderwaterMode", 1f);
			this.HFODKHJLFIE.SetFloat("_FoamContrast", 0f);
			this.HFODKHJLFIE.SetFloat("_Specular", this.BNGEOBGCMLA * 5f);
			this.HFODKHJLFIE.SetFloat("_Refraction", 0.7f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = true;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = true;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = true;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("TenkokuModule");
				FieldInfo field = component.GetType().GetField("enableFog", BindingFlags.Instance | BindingFlags.Public);
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = true;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 0f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 0;
			this.HGNAFKOGBAC();
			base.InvokeRepeating("HGNAFKOGBAC", 1f / this.wetLens.rundownSpeed, 1f / this.wetLens.rundownSpeed);
			this.rundown = false;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 0f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = false;
		}
		this.DMDJCPDHFHO = true;
		this.DEECOLECDPD = true;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = true;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("_Texture", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("_Intensity", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("_Texture", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("_Intensity", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 0.75f;
			this.PKEELDDHFIG.SetFloat("_Refraction", 1f);
			this.PKEELDDHFIG.SetFloat("_Transparency", 0.01f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(0.75f, 0f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("_Refraction", Mathf.Lerp(1f, 0f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("_Transparency", Mathf.Lerp(0.01f, 0f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("_FoamContrast", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("_UnderwaterMode", 0f);
		this.HFODKHJLFIE.SetFloat("_Specular", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("_Refraction", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("TenkokuModule");
			FieldInfo field2 = component2.GetType().GetField("enableFog", BindingFlags.Instance | BindingFlags.Public);
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00017C34 File Offset: 0x00015E34
	private bool AHCMDJGMLIB(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 875f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1025f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 1624f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_WaterLevel") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("/").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("buyVIP OK").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Bip") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_EmissionColor").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return false;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("BipedReferences contains one or more missing Transforms.").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("[curcnt]").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("cht_msg17") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("LHandPunch").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("\n").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00018124 File Offset: 0x00016324
	private void BMLCDNNPAIG()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 0)
		{
			this.IDCKGKNECAN = 1;
			base.CancelInvoke("Hidden/Amplify Color/ProcessOnly");
		}
		this.PKEELDDHFIG.SetTexture("Clear Screen", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("OfficeSittingLegCross", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x000181AC File Offset: 0x000163AC
	private bool HBOONOCOJNN(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i += 0)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 1961f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1515f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 246f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("languageid") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("********* Start load Level ").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ArmFlex4").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("BaseMaterial") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("name").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("cht_msg37").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < NNJEFMKOGLJ; j += 0)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("TOD_kScale") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("level").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("hlp_").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("SUNSHINE_FILTER_PCF_2x2") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("[fish]").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return true;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0001869C File Offset: 0x0001689C
	private void MDDPPMENEOH()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 0)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("_Curve");
		}
		this.PKEELDDHFIG.SetTexture("Idle180", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00018724 File Offset: 0x00016924
	private void CPNOBMNKPNC()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1293f;
		this.KKDDOIIDBEL = 1506f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("run");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("_Refraction");
		if (this.HFODKHJLFIE.HasProperty("wpn_rec3"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("https://groups.google.com/forum/#!forum/final-ik");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[4];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("color") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("Unarmed");
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool CONJLGOCEBP()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00018A88 File Offset: 0x00016C88
	private void JFGGBEGNAFP()
	{
		this.OJFODNFGLFF();
		if (this.CKALEEAIKGH())
		{
			this.t = 242f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(false);
			this.IDCKGKNECAN = 0;
			this.rundown = false;
			this.BGJDHFMBDDJ();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = false;
			}
			this.JGNNFIGNIKI = false;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = false;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("[Y]", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("1HandSwordChargeUp", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("RollerBladeCrossoverLeft", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("IceHockeyGoalieReady", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("StShopPacketWin", 1614f);
			this.HFODKHJLFIE.SetFloat("info", 650f);
			this.HFODKHJLFIE.SetFloat("<color='{2}'>{0}: {1}</color>", this.BNGEOBGCMLA * 112f);
			this.HFODKHJLFIE.SetFloat("", 1536f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = true;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = false;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = false;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("demoUint");
				FieldInfo field = component.GetType().GetField("wpn_rod2", ~(BindingFlags.Public | BindingFlags.FlattenHierarchy));
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = true;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 477f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(true);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 0;
			this.BIAEHGBDKKL();
			base.InvokeRepeating("IdleSad", 832f / this.wetLens.rundownSpeed, 1516f / this.wetLens.rundownSpeed);
			this.rundown = false;
		}
		this.LOLDCEPCLNG = 1;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 55f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = true;
		}
		this.DMDJCPDHFHO = false;
		this.DEECOLECDPD = true;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = false;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("_Threshhold", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("killPodsek", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("forSex", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("Run Back Right", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 1145f;
			this.PKEELDDHFIG.SetFloat("", 1243f);
			this.PKEELDDHFIG.SetFloat("</color>", 1380f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(1012f, 538f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("UserOut", Mathf.Lerp(878f, 1688f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("imgid", Mathf.Lerp(1267f, 1969f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("WeaponRun", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("[userfish]", 388f);
		this.HFODKHJLFIE.SetFloat("/", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("x", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("Press E to resume interaction");
			FieldInfo field2 = component2.GetType().GetField("1", ~BindingFlags.NonPublic);
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void JPJIDCJHCPO(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void KJHGKHCFNGI(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00019280 File Offset: 0x00017480
	private void ONIHHFLOJMN()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 963f;
		this.KKDDOIIDBEL = 797f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("CD");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).");
		if (this.HFODKHJLFIE.HasProperty("wpn_eat1"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[8];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("#c0c0c0") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("_ScreenEdgeFading");
		}
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void FGKHNHDGHPK(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void EFGBEPGPCFP(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool CKIBKGLIMAB()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000195E4 File Offset: 0x000177E4
	private void AIFIEAGFIMM()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 382f;
		this.KKDDOIIDBEL = 1346f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("BAG");
		if (this.HFODKHJLFIE.HasProperty("Flashlight"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("WeaponStrafeRunLeft");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[0];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("quality") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("NadeThrow");
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00019948 File Offset: 0x00017B48
	private void LHJCHPFKGDB()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 536f;
		this.KKDDOIIDBEL = 89f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("USE_UV_BASED_REPROJECTION");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("_Bloom_DirtIntensity");
		if (this.HFODKHJLFIE.HasProperty("crft_costwp"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("RollerBladeCrossoverLeft");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[5];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("Level: ") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("minimalLevel");
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void ABGCFIADJEJ(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00019CAC File Offset: 0x00017EAC
	private void HMLPNHBFIDK()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(12f, this.bubbleSpawnCriteria.avgScaleSummand * 1615f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1370f, this.bubbleSpawnCriteria.averageUpdrift * 61f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1198f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG++;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(503f, this.bubbleSpawnCriteria.avgScaleSummand * 1976f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1386f, this.bubbleSpawnCriteria.averageUpdrift * 527f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1563f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0001A07C File Offset: 0x0001827C
	private void FADICGANJBL()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 0)
		{
			this.IDCKGKNECAN = 0;
			base.CancelInvoke("");
		}
		this.PKEELDDHFIG.SetTexture("NPR_", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("rodDwDelta=", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0001A104 File Offset: 0x00018304
	private void IGOOMEMKLNK()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.AIDPMNAPIID() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 692f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 1841f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 1499f))
			{
				this.EFGBEPGPCFP(true);
				return;
			}
			if (this.ONOHFCLMEMI && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.PCLOLHKCCHI(true);
				return;
			}
			if (!this.CKIBKGLIMAB())
			{
				this.KJHGKHCFNGI(this.IABKLFNJJEG(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.ELOBBDHBJOK() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.MJIKAPDOCIK() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.AKIOBHFDICN(false);
				return;
			}
			if (this.ONOHFCLMEMI && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (!this.MJIKAPDOCIK())
			{
				this.FGKHNHDGHPK(this.EMMDHJOAGGL(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0001A3B4 File Offset: 0x000185B4
	private bool IABKLFNJJEG(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 1250f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1949f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 261f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("signal_tone") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("</color>").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("crft_to").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("offsets") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("IK unassigned in FABRIKChain.").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Giant3HitCombo").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j += 0)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("null") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("/").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("CheerJump").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("u_UniqueShadowLightWidth") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("wpn_rod1").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_Offsets").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool AIDPMNAPIID()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0001A8A4 File Offset: 0x00018AA4
	private void HGGDLBIMAAI()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 1)
		{
			this.IDCKGKNECAN = 1;
			base.CancelInvoke("Unknow CMD:");
		}
		this.PKEELDDHFIG.SetTexture("__a", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture("_Offsets", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN++;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0001A92C File Offset: 0x00018B2C
	private void EDGALMCHPPH()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1295f;
		this.KKDDOIIDBEL = 1404f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("WRINKLE_MAPS");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("_INFO");
		if (this.HFODKHJLFIE.HasProperty(""))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("{0:dd MMMM H:mm}");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[0];
		this.BDELLKJEKFP.loop = true;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[0];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[1];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("---") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("wpn_add/base");
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0001AC90 File Offset: 0x00018E90
	private void OJFODNFGLFF()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.ELOBBDHBJOK() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 1323f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 296f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 532f))
			{
				this.AKIOBHFDICN(false);
				return;
			}
			if (this.CONJLGOCEBP() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.KJHGKHCFNGI(false);
				return;
			}
			if (!this.ONOHFCLMEMI)
			{
				this.JPJIDCJHCPO(this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.ACEHGLCDAEM() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.MJIKAPDOCIK() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.KJHGKHCFNGI(true);
				return;
			}
			if (this.MECHGBFIKAL() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(false);
				return;
			}
			if (!this.PGOACMBPEPO())
			{
				this.AKIOBHFDICN(this.OILJFOEIDFF(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0001AF40 File Offset: 0x00019140
	private void CPGAJBNMEAF()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(1530f, this.bubbleSpawnCriteria.avgScaleSummand * 189f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1261f, this.bubbleSpawnCriteria.averageUpdrift * 85f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 893f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG += 0;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(341f, this.bubbleSpawnCriteria.avgScaleSummand * 513f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 201f, this.bubbleSpawnCriteria.averageUpdrift * 16f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 91f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0001B310 File Offset: 0x00019510
	private void MNAHGMDDHCA()
	{
		this.ICEDJDACEDP();
		if (this.ELOBBDHBJOK())
		{
			this.t = 1447f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(true);
			this.gameObjects.waterLens.SetActive(false);
			this.IDCKGKNECAN = 0;
			this.rundown = true;
			this.OMMELPNIGIO();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = true;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("RollerBladeCrossoverLeft", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat(" \"{0}\"", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale(">", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("repair.ogg", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("crft_cnt", 1316f);
			this.HFODKHJLFIE.SetFloat("ScubaSwim", 175f);
			this.HFODKHJLFIE.SetFloat("#", this.BNGEOBGCMLA * 1698f);
			this.HFODKHJLFIE.SetFloat("def point foud", 851f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = true;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = false;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = false;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("#02C85F");
				FieldInfo field = component.GetType().GetField("Card Player Idle", BindingFlags.Default);
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = false;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = true;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 55f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(true);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 1;
			this.IINEKJOJKML();
			base.InvokeRepeating("_ReflectionTex", 1081f / this.wetLens.rundownSpeed, 1776f / this.wetLens.rundownSpeed);
			this.rundown = false;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 319f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = true;
		}
		this.DMDJCPDHFHO = true;
		this.DEECOLECDPD = false;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = false;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("!", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("NadeThrow", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("Water", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("Ready Fight", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 84f;
			this.PKEELDDHFIG.SetFloat("offsets", 221f);
			this.PKEELDDHFIG.SetFloat("", 105f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(1971f, 1530f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("Weapon Instant", Mathf.Lerp(1651f, 460f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", Mathf.Lerp(1565f, 499f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("OneHandSwordRun", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("obscured focus oO", 1817f);
		this.HFODKHJLFIE.SetFloat("", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("Low adminlevel!");
			FieldInfo field2 = component2.GetType().GetField("_Threshhold", ~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic));
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0001BB08 File Offset: 0x00019D08
	private bool EPOANFICIIK(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 0; i < NNJEFMKOGLJ; i += 0)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 1190f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1824f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 722f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("-none-") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_FullItem.wav").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Fly Forward").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("MotorbikeTurnRight") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("PaperTurn.wav").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("head").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return false;
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < NNJEFMKOGLJ; j += 0)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("WorkerPickaxe") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("Mirror Refl Camera id").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_FogStepping").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("---") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ClimbLeft").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("WeaponRun").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
	private void PFNOEACNHON()
	{
		this.NNKLIBGIIGD();
		if (this.CKALEEAIKGH())
		{
			this.t = 485f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(true);
			this.IDCKGKNECAN = 1;
			this.rundown = true;
			this.EPBBCAAKFOF();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = false;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("CrawlLocomotion", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("Crawl Locomotion", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("#a0a0a0", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("off", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("__Refraction", 1392f);
			this.HFODKHJLFIE.SetFloat("_Offsets", 1820f);
			this.HFODKHJLFIE.SetFloat("IdleTyping", this.BNGEOBGCMLA * 1711f);
			this.HFODKHJLFIE.SetFloat("wpn_eat6", 1549f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = false;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = true;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = false;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent("14,15,16,36");
				FieldInfo field = component.GetType().GetField("wpn_add/base", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				if (field != null)
				{
					field.SetValue(component, true);
				}
			}
			RenderSettings.fog = true;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = false;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 221f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 0;
			this.AFLDOLFBJPJ();
			base.InvokeRepeating("UI_MapWindow_b", 135f / this.wetLens.rundownSpeed, 1773f / this.wetLens.rundownSpeed);
			this.rundown = false;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 215f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = false;
		}
		this.DMDJCPDHFHO = false;
		this.DEECOLECDPD = false;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = true;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("auk_pstinf", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("VolumetricFogAndMist/CopyDepth", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("SixStep", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("KatanaReadyHigh", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 365f;
			this.PKEELDDHFIG.SetFloat("colorA", 1126f);
			this.PKEELDDHFIG.SetFloat("<color='#400000'>", 1385f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(278f, 942f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("_VignetteBlur", Mathf.Lerp(1876f, 323f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("This method requires a mesh filter!", Mathf.Lerp(1557f, 213f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("Bottoms", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("_Color", 1819f);
		this.HFODKHJLFIE.SetFloat("", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("GestureHandUp", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("Error!");
			FieldInfo field2 = component2.GetType().GetField("0", ~(BindingFlags.Static | BindingFlags.FlattenHierarchy));
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool PGOACMBPEPO()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
	private void OCGJJBBJAHH()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.MECHGBFIKAL() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 90f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 1937f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 1070f))
			{
				this.AKIOBHFDICN(true);
				return;
			}
			if (this.ACEHGLCDAEM() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(false);
				return;
			}
			if (!this.CONJLGOCEBP())
			{
				this.ABGCFIADJEJ(this.PALEFJGNCOK(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.CKIBKGLIMAB() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.PGOACMBPEPO() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.ONOHFCLMEMI = true;
				return;
			}
			if (this.ELOBBDHBJOK() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.KJHGKHCFNGI(true);
				return;
			}
			if (!this.CKIBKGLIMAB())
			{
				this.PCLOLHKCCHI(this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
	private void DHHEBAMBJNA()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(1711f, this.bubbleSpawnCriteria.avgScaleSummand * 955f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1280f, this.bubbleSpawnCriteria.averageUpdrift * 1898f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1593f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG += 0;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1466f, this.bubbleSpawnCriteria.avgScaleSummand * 1942f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 31f, this.bubbleSpawnCriteria.averageUpdrift * 1845f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1656f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0001CE70 File Offset: 0x0001B070
	private void DGEIACONKCJ()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(true);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1779f;
		this.KKDDOIIDBEL = 449f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat(",");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("act_orderb_");
		if (this.HFODKHJLFIE.HasProperty("1 Hand Sword Jab ready strafe right"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("WATER_VERTEX_DISPLACEMENT_OFF");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = true;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[6];
		this.KDKIFOMEIDC.loop = true;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("Horizontal") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("\n");
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
	private void FMAIILEPNJJ()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(1941f, this.bubbleSpawnCriteria.avgScaleSummand * 184f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 411f, this.bubbleSpawnCriteria.averageUpdrift * 1498f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1521f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG += 0;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1859f, this.bubbleSpawnCriteria.avgScaleSummand * 942f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 681f, this.bubbleSpawnCriteria.averageUpdrift * 1981f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 436f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	private bool PALEFJGNCOK(int NNJEFMKOGLJ)
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			for (int i = 1; i < NNJEFMKOGLJ; i++)
			{
				if (Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[i].transform.position.x, 160f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[i].transform.position.z, 1862f) < Mathf.Pow(this.gameObjects.waterPlanes[i].GetComponent<Renderer>().bounds.extents.x, 758f))
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("1 Hand Sword Strafe Left") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("ok").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find(" is represented multiple times in BipedReferences eyes.").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_Offsets") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_BlurRadius4").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("There is already a virtual axis named ").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = i;
					if (base.transform.position.y < this.gameObjects.waterPlanes[i].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[i].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = i;
						return false;
					}
				}
			}
		}
		else
		{
			for (int j = 1; j < NNJEFMKOGLJ; j++)
			{
				if (Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[j].transform.position.x) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.x && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[j].transform.position.z) < this.gameObjects.waterPlanes[j].GetComponent<Renderer>().bounds.extents.z)
				{
					if (this.PFHJGLDNAII != this.MKGJGCALLNK)
					{
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("wgt_kg") != null)
						{
							this.BJNHJHIMNGN = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("{0:f2}").GetComponent<Projector>();
							this.BDEJKKLHMKI = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("_TileVRT").GetComponent<AQUAS_Caustics>();
						}
						if (this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("") != null)
						{
							this.FCENCHGCMEM = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("8").GetComponent<Projector>();
							this.OMCPFCHPEPP = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.Find("cellid").GetComponent<AQUAS_Caustics>();
						}
						this.MKGJGCALLNK = this.PFHJGLDNAII;
					}
					this.PFHJGLDNAII = j;
					if (base.transform.position.y < this.gameObjects.waterPlanes[j].transform.position.y)
					{
						this.HFODKHJLFIE = this.gameObjects.waterPlanes[1].GetComponent<Renderer>().material;
						this.PFHJGLDNAII = j;
						return true;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0001DA94 File Offset: 0x0001BC94
	private void BEGHIDDIKDH()
	{
		if (this.IDCKGKNECAN >= this.wetLens.sprayFrames.Length - 0)
		{
			this.IDCKGKNECAN = 1;
			base.CancelInvoke("Kernel");
		}
		this.PKEELDDHFIG.SetTexture(" ", this.wetLens.sprayFramesCutout[this.IDCKGKNECAN]);
		this.PKEELDDHFIG.SetTexture(" гр ", this.wetLens.sprayFrames[this.IDCKGKNECAN]);
		this.IDCKGKNECAN += 0;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0001DB1C File Offset: 0x0001BD1C
	private void LIGGDAFGCKK()
	{
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA > this.LOLDCEPCLNG)
		{
			float num = UnityEngine.Random.Range(685f, this.bubbleSpawnCriteria.avgScaleSummand * 71f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1474f, this.bubbleSpawnCriteria.averageUpdrift * 834f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num, num, num);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1630f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimer, this.bubbleSpawnCriteria.maxSpawnTimer);
			this.LOLDCEPCLNG++;
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
			return;
		}
		if (this.FBJFGKGEFDN > this.KKDDOIIDBEL && this.IEAPNAPIBJA == this.LOLDCEPCLNG)
		{
			float num2 = UnityEngine.Random.Range(1622f, this.bubbleSpawnCriteria.avgScaleSummand * 171f);
			this.PIDKDJEDFHI.mainCamera = this.gameObjects.mainCamera;
			this.PIDKDJEDFHI.waterLevel = this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y;
			this.PIDKDJEDFHI.averageUpdrift = this.bubbleSpawnCriteria.averageUpdrift + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.averageUpdrift * 1454f, this.bubbleSpawnCriteria.averageUpdrift * 1630f);
			this.gameObjects.bubble.transform.localScale += new Vector3(num2, num2, num2);
			UnityEngine.Object.Instantiate<GameObject>(this.gameObjects.bubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance), base.transform.position.y - 1370f, base.transform.position.z + UnityEngine.Random.Range(-this.bubbleSpawnCriteria.maxSpawnDistance, this.bubbleSpawnCriteria.maxSpawnDistance)), Quaternion.identity);
			this.KKDDOIIDBEL += UnityEngine.Random.Range(this.bubbleSpawnCriteria.minSpawnTimerL, this.bubbleSpawnCriteria.maxSpawnTimerL);
			this.gameObjects.bubble.transform.localScale = new Vector3(this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale, this.bubbleSpawnCriteria.baseScale);
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0001DEEC File Offset: 0x0001C0EC
	private void IEOICHPKEMD()
	{
		this.OCGJJBBJAHH();
		if (this.MJIKAPDOCIK())
		{
			this.t = 628f;
			this.FBJFGKGEFDN += Time.deltaTime;
			this.gameObjects.airLens.SetActive(false);
			this.gameObjects.waterLens.SetActive(false);
			this.IDCKGKNECAN = 0;
			this.rundown = true;
			this.CPGAJBNMEAF();
			if (this.DMDJCPDHFHO)
			{
				this.BDELLKJEKFP.Play();
				this.DMDJCPDHFHO = true;
			}
			if (this.DEECOLECDPD)
			{
				this.KDKIFOMEIDC.Play();
				this.DEECOLECDPD = false;
			}
			this.JGNNFIGNIKI = true;
			this.NAKOAONFAJO.Stop();
			this.CCCGHOAMODM.enabled = true;
			this.NAKOAONFAJO.volume = this.soundEffects.surfacingVolume;
			this.BDELLKJEKFP.volume = this.soundEffects.diveVolume;
			this.KDKIFOMEIDC.volume = this.soundEffects.underwaterVolume;
			if (this.BJNHJHIMNGN != null)
			{
				this.BJNHJHIMNGN.material.SetTextureScale("", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.BJNHJHIMNGN.material.SetFloat("Windmill", this.causticSettings.causticIntensity.y);
				this.BDEJKKLHMKI.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			if (this.FCENCHGCMEM != null)
			{
				this.FCENCHGCMEM.material.SetTextureScale("id", new Vector2(this.causticSettings.causticTiling.y, this.causticSettings.causticTiling.y));
				this.FCENCHGCMEM.material.SetFloat("_WrinkleInfluences3", this.causticSettings.causticIntensity.y);
				this.OMCPFCHPEPP.maxCausticDepth = this.causticSettings.maxCausticDepth;
			}
			this.HFODKHJLFIE.SetFloat("rod_inf2", 1299f);
			this.HFODKHJLFIE.SetFloat("error.wav", 377f);
			this.HFODKHJLFIE.SetFloat("?", this.BNGEOBGCMLA * 962f);
			this.HFODKHJLFIE.SetFloat("Sorry, VRIK User Manual is not finished yet.", 1771f);
			if (this.OFHEPDJHPCD != null)
			{
				this.OFHEPDJHPCD.bloomIntensity = this.underWaterParameters.bloom;
				this.OFHEPDJHPCD.enabled = false;
			}
			if (this.LPJFMJONFFM != null)
			{
				this.LPJFMJONFFM.enabled = true;
			}
			if (this.GAELOPABECG != null)
			{
				this.GAELOPABECG.enabled = false;
			}
			if (this.LNDPHABEOOO != null)
			{
				this.LNDPHABEOOO.enabled = true;
			}
			if (this.CKKPLDICLLK != null)
			{
				this.CKKPLDICLLK.enabled = true;
			}
			if (this.ADJKPFAAHNE != null)
			{
				Component component = this.ADJKPFAAHNE.GetComponent(" ");
				FieldInfo field = component.GetType().GetField("Wand Attack", ~(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic));
				if (field != null)
				{
					field.SetValue(component, false);
				}
			}
			RenderSettings.fog = true;
			if (this.LNPJLNGBCAI != null)
			{
				this.LNPJLNGBCAI.enabled = false;
			}
			RenderSettings.fogDensity = this.underWaterParameters.fogDensity;
			RenderSettings.fogColor = this.underWaterParameters.fogColor;
			return;
		}
		this.FBJFGKGEFDN = 476f;
		this.t += Time.deltaTime;
		this.gameObjects.airLens.SetActive(true);
		this.gameObjects.waterLens.SetActive(false);
		if (this.rundown)
		{
			this.IDCKGKNECAN = 1;
			this.KCCFIDOEJND();
			base.InvokeRepeating("UI_MapWindow_b", 809f / this.wetLens.rundownSpeed, 85f / this.wetLens.rundownSpeed);
			this.rundown = true;
		}
		this.LOLDCEPCLNG = 0;
		this.IEAPNAPIBJA = UnityEngine.Random.Range(this.bubbleSpawnCriteria.minBubbleCount, this.bubbleSpawnCriteria.maxBubbleCount);
		this.KKDDOIIDBEL = 444f;
		if (this.JGNNFIGNIKI)
		{
			this.NAKOAONFAJO.Play();
			this.JGNNFIGNIKI = true;
		}
		this.DMDJCPDHFHO = false;
		this.DEECOLECDPD = true;
		this.BDELLKJEKFP.Stop();
		this.KDKIFOMEIDC.Stop();
		this.CCCGHOAMODM.enabled = false;
		if (this.BJNHJHIMNGN != null)
		{
			this.BJNHJHIMNGN.material.SetTextureScale("http://www.root-motion.com/finalikdox/html/page10.html", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.BJNHJHIMNGN.material.SetFloat("wpn_ibsize_", this.causticSettings.causticIntensity.x);
		}
		if (this.FCENCHGCMEM != null)
		{
			this.FCENCHGCMEM.material.SetTextureScale("OneHandSwordRun", new Vector2(this.causticSettings.causticTiling.x, this.causticSettings.causticTiling.x));
			this.FCENCHGCMEM.material.SetFloat("{0}\n{1}", this.causticSettings.causticIntensity.x);
		}
		if (this.t <= this.wetLens.wetTime)
		{
			this.GAELOPABECG.blur = 1018f;
			this.PKEELDDHFIG.SetFloat("IceHockeyGoalieSave1", 468f);
			this.PKEELDDHFIG.SetFloat("Allows to detect foreign managed assemblies in your application.", 1077f);
		}
		else
		{
			this.GAELOPABECG.blur = Mathf.Lerp(1865f, 825f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime);
			this.PKEELDDHFIG.SetFloat("BowFire2", Mathf.Lerp(977f, 83f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
			this.PKEELDDHFIG.SetFloat("<b>ObscuredInt:</b> ", Mathf.Lerp(578f, 1301f, (this.t - this.wetLens.wetTime) / this.wetLens.dryingTime));
		}
		this.HFODKHJLFIE.SetFloat("ok", this.EJAHFDHKLDH);
		this.HFODKHJLFIE.SetFloat("", 178f);
		this.HFODKHJLFIE.SetFloat("fchair", this.BNGEOBGCMLA);
		this.HFODKHJLFIE.SetFloat("_rcIn.ogg", this.EHEEDFLOIGH);
		if (this.OFHEPDJHPCD != null)
		{
			this.OFHEPDJHPCD.bloomIntensity = this.GJIFCHBMMHA;
			this.OFHEPDJHPCD.enabled = this.KJJAHDHAMCO;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.LPJFMJONFFM.enabled = this.DBCPLBABDCM;
		}
		if (this.GAELOPABECG != null)
		{
			this.GAELOPABECG.enabled = this.NOPGPGNECMG;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.LNDPHABEOOO.enabled = this.ILCNJLJLBGC;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CKKPLDICLLK.enabled = this.CCKCCOAJDGP;
		}
		if (this.ADJKPFAAHNE != null)
		{
			Component component2 = this.ADJKPFAAHNE.GetComponent("_rcIn.ogg");
			FieldInfo field2 = component2.GetType().GetField("val=", ~(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
			if (field2 != null)
			{
				field2.SetValue(component2, true);
			}
		}
		RenderSettings.fog = this.MOKDNFICIAN;
		if (this.LNPJLNGBCAI != null)
		{
			this.LNPJLNGBCAI.enabled = this.MOKDNFICIAN;
		}
		RenderSettings.fogColor = this.FPEOJCEGAOI;
		RenderSettings.fogDensity = this.ALCFABBEMDC;
	}

	// Token: 0x060001AE RID: 430 RVA: 0x0000FDAF File Offset: 0x0000DFAF
	private void HAEBHLDGKPG(bool DCCPCBLODIG)
	{
		this.<CDBLPFKDJBE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
	private void ICEDJDACEDP()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.MECHGBFIKAL() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 1400f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 404f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 1076f))
			{
				this.FGKHNHDGHPK(true);
				return;
			}
			if (this.MJIKAPDOCIK() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.EFGBEPGPCFP(false);
				return;
			}
			if (!this.ACEHGLCDAEM())
			{
				this.ONOHFCLMEMI = this.OILJFOEIDFF(this.gameObjects.waterPlanes.Count);
				return;
			}
		}
		else
		{
			if ((this.PGOACMBPEPO() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.CKIBKGLIMAB() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.ABGCFIADJEJ(true);
				return;
			}
			if (this.ACEHGLCDAEM() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.JPJIDCJHCPO(true);
				return;
			}
			if (!this.MJIKAPDOCIK())
			{
				this.HAEBHLDGKPG(this.ECPLABIJIOF(this.gameObjects.waterPlanes.Count));
			}
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool ACEHGLCDAEM()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0001E994 File Offset: 0x0001CB94
	private void NNKLIBGIIGD()
	{
		if (!this.gameObjects.useSquaredPlanes)
		{
			if (this.ELOBBDHBJOK() && Mathf.Pow(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x, 758f) + Mathf.Pow(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z, 484f) > Mathf.Pow(this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x, 724f))
			{
				this.PCLOLHKCCHI(false);
				return;
			}
			if (this.ELOBBDHBJOK() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.AKIOBHFDICN(true);
				return;
			}
			if (!this.AIDPMNAPIID())
			{
				this.HAEBHLDGKPG(this.HBOONOCOJNN(this.gameObjects.waterPlanes.Count));
				return;
			}
		}
		else
		{
			if ((this.PGOACMBPEPO() && Mathf.Abs(base.transform.position.x - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.x) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.x) || (this.CONJLGOCEBP() && Mathf.Abs(base.transform.position.z - this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.z) > this.gameObjects.waterPlanes[this.PFHJGLDNAII].GetComponent<Renderer>().bounds.extents.z))
			{
				this.KJHGKHCFNGI(false);
				return;
			}
			if (this.AIDPMNAPIID() && base.transform.position.y > this.gameObjects.waterPlanes[this.PFHJGLDNAII].transform.position.y)
			{
				this.HAEBHLDGKPG(true);
				return;
			}
			if (!this.AIDPMNAPIID())
			{
				this.ONOHFCLMEMI = this.EPOANFICIIK(this.gameObjects.waterPlanes.Count);
			}
		}
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00013EDB File Offset: 0x000120DB
	public bool MECHGBFIKAL()
	{
		return this.<CDBLPFKDJBE>k__BackingField;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0001EC44 File Offset: 0x0001CE44
	private void IJOCHELLKJH()
	{
		this.OFHEPDJHPCD = this.gameObjects.mainCamera.GetComponent<Bloom>();
		this.LNPJLNGBCAI = this.gameObjects.mainCamera.GetComponent<GlobalFog>();
		this.LPJFMJONFFM = this.gameObjects.mainCamera.GetComponent<BlurOptimized>();
		this.GAELOPABECG = this.gameObjects.mainCamera.GetComponent<VignetteAndChromaticAberration>();
		this.LNDPHABEOOO = this.gameObjects.mainCamera.GetComponent<NoiseAndGrain>();
		this.CKKPLDICLLK = this.gameObjects.mainCamera.GetComponent<SunShafts>();
		this.KDKIFOMEIDC = this.gameObjects.waterLens.GetComponent<AudioSource>();
		this.NAKOAONFAJO = this.gameObjects.airLens.GetComponent<AudioSource>();
		this.BDELLKJEKFP = base.GetComponent<AudioSource>();
		this.CCCGHOAMODM = this.gameObjects.mainCamera.GetComponent<AudioSource>();
		this.PIDKDJEDFHI = this.gameObjects.bubble.GetComponent<AQUAS_BubbleBehaviour>();
		this.gameObjects.airLens.SetActive(false);
		this.gameObjects.waterLens.SetActive(false);
		this.PKEELDDHFIG = this.gameObjects.airLens.GetComponent<Renderer>().material;
		this.HFODKHJLFIE = this.gameObjects.waterPlanes[0].GetComponent<Renderer>().material;
		this.t = this.wetLens.wetTime + this.wetLens.dryingTime;
		this.FBJFGKGEFDN = 1433f;
		this.KKDDOIIDBEL = 184f;
		this.MOKDNFICIAN = RenderSettings.fog;
		this.ALCFABBEMDC = RenderSettings.fogDensity;
		this.FPEOJCEGAOI = RenderSettings.fogColor;
		this.EJAHFDHKLDH = this.HFODKHJLFIE.GetFloat("0 сек");
		this.BNGEOBGCMLA = this.HFODKHJLFIE.GetFloat("ok");
		if (this.HFODKHJLFIE.HasProperty("stname"))
		{
			this.EHEEDFLOIGH = this.HFODKHJLFIE.GetFloat("MotorbikeHandstand");
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.GJIFCHBMMHA = this.OFHEPDJHPCD.bloomIntensity;
		}
		if (this.CKKPLDICLLK != null)
		{
			this.CCKCCOAJDGP = this.CKKPLDICLLK.enabled;
		}
		if (this.OFHEPDJHPCD != null)
		{
			this.KJJAHDHAMCO = this.OFHEPDJHPCD.enabled;
		}
		if (this.LPJFMJONFFM != null)
		{
			this.DBCPLBABDCM = this.LPJFMJONFFM.enabled;
		}
		if (this.GAELOPABECG != null)
		{
			this.NOPGPGNECMG = this.GAELOPABECG.enabled;
		}
		if (this.LNDPHABEOOO != null)
		{
			this.ILCNJLJLBGC = this.LNDPHABEOOO.enabled;
		}
		this.BDELLKJEKFP.clip = this.soundEffects.sounds[1];
		this.BDELLKJEKFP.loop = false;
		this.BDELLKJEKFP.Stop();
		this.NAKOAONFAJO.clip = this.soundEffects.sounds[1];
		this.NAKOAONFAJO.loop = false;
		this.NAKOAONFAJO.Stop();
		this.KDKIFOMEIDC.clip = this.soundEffects.sounds[2];
		this.KDKIFOMEIDC.loop = false;
		this.KDKIFOMEIDC.Stop();
		if (GameObject.Find("WorkerPickaxe") != null)
		{
			this.ADJKPFAAHNE = GameObject.Find("firsStartInfoPanel");
		}
	}

	// Token: 0x04000024 RID: 36
	public AQUAS_Parameters.UnderWaterParameters underWaterParameters = new AQUAS_Parameters.UnderWaterParameters();

	// Token: 0x04000025 RID: 37
	public AQUAS_Parameters.GameObjects gameObjects = new AQUAS_Parameters.GameObjects();

	// Token: 0x04000026 RID: 38
	public AQUAS_Parameters.BubbleSpawnCriteria bubbleSpawnCriteria = new AQUAS_Parameters.BubbleSpawnCriteria();

	// Token: 0x04000027 RID: 39
	public AQUAS_Parameters.WetLens wetLens = new AQUAS_Parameters.WetLens();

	// Token: 0x04000028 RID: 40
	public AQUAS_Parameters.CausticSettings causticSettings = new AQUAS_Parameters.CausticSettings();

	// Token: 0x04000029 RID: 41
	public AQUAS_Parameters.Audio soundEffects = new AQUAS_Parameters.Audio();

	// Token: 0x0400002A RID: 42
	private int IDCKGKNECAN;

	// Token: 0x0400002B RID: 43
	private GameObject ADJKPFAAHNE;

	// Token: 0x0400002C RID: 44
	private Material PKEELDDHFIG;

	// Token: 0x0400002D RID: 45
	private Material HFODKHJLFIE;

	// Token: 0x0400002E RID: 46
	[HideInInspector]
	public float t;

	// Token: 0x0400002F RID: 47
	private float FBJFGKGEFDN;

	// Token: 0x04000030 RID: 48
	private float KKDDOIIDBEL;

	// Token: 0x04000031 RID: 49
	private float ALCFABBEMDC;

	// Token: 0x04000032 RID: 50
	private Color FPEOJCEGAOI;

	// Token: 0x04000033 RID: 51
	private float EJAHFDHKLDH;

	// Token: 0x04000034 RID: 52
	private float GJIFCHBMMHA;

	// Token: 0x04000035 RID: 53
	private float BNGEOBGCMLA;

	// Token: 0x04000036 RID: 54
	private float EHEEDFLOIGH;

	// Token: 0x04000037 RID: 55
	private bool MOKDNFICIAN;

	// Token: 0x04000038 RID: 56
	private bool CCKCCOAJDGP;

	// Token: 0x04000039 RID: 57
	private bool KJJAHDHAMCO;

	// Token: 0x0400003A RID: 58
	private bool DBCPLBABDCM;

	// Token: 0x0400003B RID: 59
	private bool NOPGPGNECMG;

	// Token: 0x0400003C RID: 60
	private bool ILCNJLJLBGC;

	// Token: 0x0400003E RID: 62
	[HideInInspector]
	public bool rundown;

	// Token: 0x0400003F RID: 63
	private bool JGNNFIGNIKI;

	// Token: 0x04000040 RID: 64
	private bool DEECOLECDPD;

	// Token: 0x04000041 RID: 65
	private bool DMDJCPDHFHO;

	// Token: 0x04000042 RID: 66
	private int LOLDCEPCLNG;

	// Token: 0x04000043 RID: 67
	private int IEAPNAPIBJA;

	// Token: 0x04000044 RID: 68
	private int PFHJGLDNAII;

	// Token: 0x04000045 RID: 69
	private int MKGJGCALLNK = 100;

	// Token: 0x04000046 RID: 70
	private Bloom OFHEPDJHPCD;

	// Token: 0x04000047 RID: 71
	private GlobalFog LNPJLNGBCAI;

	// Token: 0x04000048 RID: 72
	private FieldInfo BJEBHBIIFBP;

	// Token: 0x04000049 RID: 73
	private BlurOptimized LPJFMJONFFM;

	// Token: 0x0400004A RID: 74
	private VignetteAndChromaticAberration GAELOPABECG;

	// Token: 0x0400004B RID: 75
	private NoiseAndGrain LNDPHABEOOO;

	// Token: 0x0400004C RID: 76
	private SunShafts CKKPLDICLLK;

	// Token: 0x0400004D RID: 77
	private AudioSource KDKIFOMEIDC;

	// Token: 0x0400004E RID: 78
	private AudioSource NAKOAONFAJO;

	// Token: 0x0400004F RID: 79
	private AudioSource BDELLKJEKFP;

	// Token: 0x04000050 RID: 80
	private AudioSource CCCGHOAMODM;

	// Token: 0x04000051 RID: 81
	private Projector BJNHJHIMNGN;

	// Token: 0x04000052 RID: 82
	private Projector FCENCHGCMEM;

	// Token: 0x04000053 RID: 83
	private AQUAS_Caustics BDEJKKLHMKI;

	// Token: 0x04000054 RID: 84
	private AQUAS_Caustics OMCPFCHPEPP;

	// Token: 0x04000055 RID: 85
	private AQUAS_BubbleBehaviour PIDKDJEDFHI;
}
